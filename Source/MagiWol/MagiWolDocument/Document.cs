﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace MagiWol.MagiWolDocument {

    internal class Document {

        private List<Address> _addresses = new List<Address>();


        public Document() {
        }

        public void FillListView(ListView list, IEnumerable<Address> selectedItems) {
            var selectionList = new List<Address>();
            if (selectedItems != null) {
                foreach (var iItem in selectedItems) {
                    selectionList.Add(iItem);
                }
            }

            MagiWolDocument.Address potentialFocus = null;

            list.BeginUpdate();
            list.Items.Clear();
            for (int i = 0; i < this._addresses.Count; ++i) {
                _addresses[i].Selected = selectionList.Contains(_addresses[i]);
                list.Items.Add(_addresses[i]);
                if (selectionList.Contains(_addresses[i])) {
                    potentialFocus = _addresses[i];
                }
            }
            list.EndUpdate();

            if (potentialFocus != null) { list.FocusedItem = potentialFocus; }
        }

        public string FileName { get; private set; }


        public static Document Open(string fileName) {
            var doc = new Document();
            doc.FileName = fileName;
            foreach (var iAddress in GetAddressesFromXml(doc, System.IO.File.ReadAllText(fileName))) {
                if (!doc.HasAddress(iAddress)) {
                    doc.AddAddress(iAddress);
                }
            }
            doc.HasChanged = false;
            return doc;
        }

        public void Save() {
            this.Save(this.FileName);
        }

        public void Save(string fileName) {
            File.WriteAllText(fileName, GetXmlFromAddresses(this._addresses));
            this.FileName = fileName;
            this.HasChanged = false;
        }

        public bool HasChanged { get; internal set; }
        internal void MarkAsChanged() {
            this.HasChanged = true;
        }

        public string FileTitle {
            get {
                string fileNamePart;
                if (this.FileName == null) {
                    fileNamePart = "Untitled";
                } else {
                    var fi = new FileInfo(this.FileName);
                    fileNamePart = fi.Name;
                }
                if (this.HasChanged) {
                    return fileNamePart + "*";
                } else {
                    return fileNamePart;
                }
            }
        }

        public bool HasAddress(Address item) {
            return this._addresses.Contains(item);
        }


        public void AddAddress(Address item) {
            if (this._addresses.Contains(item)) {
                //throw new System.InvalidOperationException("Duplicate address.");
            } else {
                item.Parent = this;
                _addresses.Add(item);
                this.HasChanged = true;
            }
        }

        public void RemoveAddress(Address item) {
            this._addresses.Remove(item);
            this.HasChanged = true;
        }

        public void Cut(IEnumerable<Address> addresses) {
            bool isChanged = false;
            Copy(addresses);
            foreach (var iAddress in addresses) {
                if (this._addresses.Contains(iAddress)) {
                    this._addresses.Remove(iAddress);
                    isChanged = true;
                }
            }
            if (isChanged) { this.HasChanged = true; }
        }

        public void Copy(IEnumerable<Address> addresses) {
            var sb = new StringBuilder();
            foreach (var iAddress in addresses) {
                sb.AppendLine(iAddress.Mac + " " + iAddress.Title);
            }

            Clipboard.Clear();
            DataObject clipData = new DataObject();
            clipData.SetData(DataFormats.UnicodeText, true, sb.ToString());
            clipData.SetData("MagiWOL", false, GetXmlFromAddresses(addresses));
            Clipboard.SetDataObject(clipData, true);
        }

        public IEnumerable<Address> Paste() {
            var pastedAddresses = new List<Address>();

            bool isChanged = false;
            IDataObject clipData = Clipboard.GetDataObject();

            string xmlData = clipData.GetData("MagiWOL") as string;
            if (xmlData != null) {
                foreach (var iAddress in GetAddressesFromXml(this, xmlData)) {
                    if (!this.HasAddress(iAddress)) {
                        this.AddAddress(iAddress);
                        pastedAddresses.Add(iAddress);
                        isChanged = true;
                    } else {
                        foreach (var feAddress in this._addresses) {
                            if (feAddress.Equals(iAddress)) {
                                pastedAddresses.Add(feAddress);
                                break;
                            }
                        }
                    }
                }
            } else {
                string dataText = clipData.GetData(DataFormats.UnicodeText, true) as string;
                if (dataText == null) { dataText = clipData.GetData(DataFormats.Text) as string; }
                if (dataText != null) {
                    foreach (var iLine in dataText.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)) {
                        var iAddress = GetAddressFromLine(iLine);
                        if (iAddress != null) {
                            if (!this.HasAddress(iAddress)) {
                                this.AddAddress(iAddress);
                                pastedAddresses.Add(iAddress);
                                isChanged = true;
                            } else {
                                foreach (var feAddress in this._addresses) {
                                    if (feAddress.Equals(iAddress)) {
                                        pastedAddresses.Add(feAddress);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (isChanged) { this.HasChanged = true; }
            return pastedAddresses.AsReadOnly();
        }

        public bool CanPaste() {
            return Clipboard.ContainsData("MagiWOL") || Clipboard.ContainsText();
        }

        private static IEnumerable<Address> GetAddressesFromXml(Document document, string xmlContent) {
            List<Address> all = new List<Address>();

            using (System.IO.StringReader sr = new System.IO.StringReader(xmlContent))
            using (System.Xml.XmlTextReader xr = new System.Xml.XmlTextReader(sr)) {
                while (xr.Read()) {

                    switch (xr.NodeType) {

                        case System.Xml.XmlNodeType.Element: {

                                switch (xr.Name) {
                                    case "MagiWOL":
                                        break;
                                    case "Addresses":
                                        break;
                                    case "Address":
                                        string aName = xr.GetAttribute("name");
                                        string aMac = xr.GetAttribute("macAddress");
                                        string aSecureOn = xr.GetAttribute("secureOnPassword");
                                        string aAddress = xr.GetAttribute("broadcastAddress");
                                        string aPort = xr.GetAttribute("broadcastPort");
                                        string aDescription = xr.GetAttribute("description");
                                        string aIsAddressValid = xr.GetAttribute("isBroadcastAddressValid");
                                        string aIsPortValid = xr.GetAttribute("isBroadcastPortValid");

                                        bool isAddressValid;
                                        IPAddress address;
                                        if ((aAddress != null) && (IPAddress.TryParse(aAddress, out address))) {
                                            if (!bool.TryParse(aIsAddressValid, out isAddressValid)) { //if it is overriden by version 2.00 setting
                                                isAddressValid = true;
                                            }
                                        } else {
                                            address = Settings.DefaultPacketEndPoint.Address;
                                            isAddressValid = false;
                                        }

                                        bool isPortValid;
                                        int port;
                                        if ((aPort != null) && (int.TryParse(aPort, NumberStyles.Integer, CultureInfo.InvariantCulture, out port))) {
                                            if ((port >= 1) || (port <= 65535)) {
                                                if (!bool.TryParse(aIsPortValid, out isPortValid)) { //if it is overriden by version 2.00 setting
                                                    isPortValid = true;
                                                }
                                            } else {
                                                port = Settings.DefaultPacketEndPoint.Port;
                                                isPortValid = false;
                                            }
                                        } else {
                                            port = Settings.DefaultPacketEndPoint.Port;
                                            isPortValid = false;
                                        }

                                        IPEndPoint aEndPoint = new IPEndPoint(address, port);
                                        Address addr = new Address(aName, aMac, aSecureOn, aDescription, aEndPoint, isAddressValid, isPortValid);
                                        if (!all.Contains(addr)) {
                                            all.Add(addr);
                                        }
                                        break;
                                }

                            }
                            break;

                        case System.Xml.XmlNodeType.EndElement: {
                            }
                            break;

                    }


                }
            }
            return all.AsReadOnly();
        }

        private static string GetXmlFromAddresses(IEnumerable<Address> addresses) {
            System.Text.StringBuilder sb = new StringBuilder();
            using (System.IO.StringWriter sw = new System.IO.StringWriter(sb)) {
                using (Medo.Xml.XmlTagWriter xw = new Medo.Xml.XmlTagWriter(sw)) {
                    xw.WriteStartDocument();
                    xw.StartTag("MagiWOL", "version", "2.00");
                    xw.StartTag("Addresses");
                    foreach (var iAddress in addresses) {
                        List<string> paramValuePairs = new List<string>();
                        paramValuePairs.AddRange(new string[] { "name", iAddress.Title });
                        paramValuePairs.AddRange(new string[] { "macAddress", iAddress.Mac });
                        paramValuePairs.AddRange(new string[] { "secureOnPassword", iAddress.SecureOn });
                        paramValuePairs.AddRange(new string[] { "broadcastAddress", iAddress.PacketEndPoint.Address.ToString() });
                        paramValuePairs.AddRange(new string[] { "broadcastPort", iAddress.PacketEndPoint.Port.ToString(CultureInfo.InvariantCulture) });
                        paramValuePairs.AddRange(new string[] { "isBroadcastAddressValid", iAddress.IsPacketEndPointAddressValid.ToString(CultureInfo.InvariantCulture) });
                        paramValuePairs.AddRange(new string[] { "isBroadcastPortValid", iAddress.IsPacketEndPointPortValid.ToString(CultureInfo.InvariantCulture) });
                        paramValuePairs.AddRange(new string[] { "description", iAddress.Notes });
                        xw.WriteTag("Address", paramValuePairs.ToArray());
                    }
                    xw.EndTag(); //Addresses
                    xw.EndTag(); //MagiWOL
                }
            }
            return sb.ToString();
        }


        private static Regex _rxMacValid = new Regex(@"(^[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}-[0-9A-F]{2}$)|(^[0-9A-F]{2}:[0-9A-F]{2}:[0-9A-F]{2}:[0-9A-F]{2}:[0-9A-F]{2}:[0-9A-F]{2}$)|(^[0-9A-F]{4}\.[0-9A-F]{4}\.[0-9A-F]{4}$)|(^[0-9A-F]{12}$)", System.Text.RegularExpressions.RegexOptions.Compiled | System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        private static Address GetAddressFromLine(string line) {
            string[] parts = line.Split(' ');
            for (int i = 0; i < parts.Length; i++) {
                if (_rxMacValid.IsMatch(parts[i])) {
                    if (i == 0) {
                        string name = string.Join(" ", parts, 1, parts.Length - 1);
                        string mac = GetProperMAC(parts[i]);
                        return new Address(name, mac, string.Empty, string.Empty, null, false, false);
                    } else {
                        string name = string.Join(" ", parts, 0, i);
                        string mac = GetProperMAC(parts[i]);
                        string desc = string.Join(" ", parts, i + 1, parts.Length - i - 1);
                        return new Address(name, mac, string.Empty, desc, null, false, false);
                    }
                }
            }
            return null;
        }


        private static string GetProperMAC(string text) {
            string addressText = System.Text.RegularExpressions.Regex.Replace(text.ToUpper(), "[^0-9A-F]", ":") + ":";
            Medo.Text.StringAdder newText = new Medo.Text.StringAdder(":");

            string lastPart = string.Empty;
            for (int i = 0; i < addressText.Length; i++) {
                switch (addressText[i]) {

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        lastPart += addressText.Substring(i, 1);
                        break;

                    case ':':
                        while (lastPart.Length > 0) {
                            string tmpPart = string.Empty;
                            if (lastPart.Length > 2) {
                                tmpPart = lastPart.Substring(0, 2);
                                lastPart = lastPart.Substring(2, lastPart.Length - 2);
                            } else {
                                tmpPart = lastPart;
                                if ((tmpPart.Length < 2) && (i < (addressText.Length - 1))) { tmpPart = tmpPart.PadLeft(2, '0'); }
                                lastPart = string.Empty;
                            }
                            newText.Append(tmpPart);
                        }
                        break;

                }
            }//for

            if (newText.ToString().Length > 2 * 6 + 5) {
                return newText.ToString().Substring(0, 2 * 6 + 5);
            } else {
                return newText.ToString();
            }

        }

    }
}
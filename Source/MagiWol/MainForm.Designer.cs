namespace MagiWol {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnu = new System.Windows.Forms.ToolStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripButton();
            this.mnuOpenRoot = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport0 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveRoot = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripButton();
            this.mnuCopy = new System.Windows.Forms.ToolStripButton();
            this.mnuPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdd = new System.Windows.Forms.ToolStripButton();
            this.mnuChange = new System.Windows.Forms.ToolStripButton();
            this.mnuRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuWake = new System.Windows.Forms.ToolStripButton();
            this.mnuWakeAll = new System.Windows.Forms.ToolStripButton();
            this.mnuApp = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuAppOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApp0 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAppFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAppUpgrade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApp1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAppAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuickWake = new System.Windows.Forms.ToolStripButton();
            this.list = new System.Windows.Forms.ListView();
            this.list_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_MAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnxList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnxListCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnxListCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnxListPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnxListEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnxListAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnxListChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnxListRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnxListActionWake = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnxListQuickWake = new System.Windows.Forms.ToolStripMenuItem();
            this.timerEnableDisable = new System.Windows.Forms.Timer(this.components);
            this.tmrReSort = new System.Windows.Forms.Timer(this.components);
            this.bwCheckForUpgrade = new System.ComponentModel.BackgroundWorker();
            this.mnu.SuspendLayout();
            this.mnxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpenRoot,
            this.mnuSaveRoot,
            this.toolStripSeparator1,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.toolStripSeparator3,
            this.mnuAdd,
            this.mnuChange,
            this.mnuRemove,
            this.toolStripSeparator2,
            this.mnuWake,
            this.mnuWakeAll,
            this.mnuApp,
            this.mnuQuickWake});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mnu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu.Size = new System.Drawing.Size(742, 27);
            this.mnu.Stretch = true;
            this.mnu.TabIndex = 1;
            // 
            // mnuNew
            // 
            this.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuNew.Image = global::MagiWol.Properties.Resources.mnuNew_16;
            this.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(24, 24);
            this.mnuNew.Text = "New";
            this.mnuNew.ToolTipText = "New file (Ctrl+N)";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpenRoot
            // 
            this.mnuOpenRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuOpenRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuImport,
            this.mnuImport0});
            this.mnuOpenRoot.Image = global::MagiWol.Properties.Resources.mnuOpen_16;
            this.mnuOpenRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpenRoot.Name = "mnuOpenRoot";
            this.mnuOpenRoot.Size = new System.Drawing.Size(39, 24);
            this.mnuOpenRoot.Tag = "mnuOpen";
            this.mnuOpenRoot.Text = "Open";
            this.mnuOpenRoot.ToolTipText = "Open file (Ctrl+O)";
            this.mnuOpenRoot.ButtonClick += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = global::MagiWol.Properties.Resources.mnuOpen_16;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeyDisplayString = "Ctrl+O";
            this.mnuOpen.Size = new System.Drawing.Size(173, 26);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuImport
            // 
            this.mnuImport.Image = global::MagiWol.Properties.Resources.mnuImport_16;
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(173, 26);
            this.mnuImport.Text = "&Import";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // mnuImport0
            // 
            this.mnuImport0.Name = "mnuImport0";
            this.mnuImport0.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuSaveRoot
            // 
            this.mnuSaveRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSaveRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuSaveAs});
            this.mnuSaveRoot.Image = global::MagiWol.Properties.Resources.mnuSave_16;
            this.mnuSaveRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSaveRoot.Name = "mnuSaveRoot";
            this.mnuSaveRoot.Size = new System.Drawing.Size(39, 24);
            this.mnuSaveRoot.Tag = "mnuSave";
            this.mnuSaveRoot.Text = "Save";
            this.mnuSaveRoot.ToolTipText = "Save file (Ctrl+S)";
            this.mnuSaveRoot.ButtonClick += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::MagiWol.Properties.Resources.mnuSave_16;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.mnuSave.Size = new System.Drawing.Size(223, 26);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.mnuSaveAs.Size = new System.Drawing.Size(223, 26);
            this.mnuSaveAs.Text = "Save &as";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // mnuCut
            // 
            this.mnuCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCut.Image = global::MagiWol.Properties.Resources.mnuCut_16;
            this.mnuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(24, 24);
            this.mnuCut.Text = "Cut";
            this.mnuCut.ToolTipText = "Cut (Ctrl+X)";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCopy.Image = global::MagiWol.Properties.Resources.mnuCopy_16;
            this.mnuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(24, 24);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.ToolTipText = "Copy (Ctrl+C)";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPaste.Image = global::MagiWol.Properties.Resources.mnuPaste_16;
            this.mnuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(24, 24);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.ToolTipText = "Paste (Ctrl+V)";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // mnuAdd
            // 
            this.mnuAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuAdd.Image = global::MagiWol.Properties.Resources.mnuAdd_16;
            this.mnuAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(24, 24);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add (Ins)";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuChange
            // 
            this.mnuChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuChange.Image = global::MagiWol.Properties.Resources.mnuEdit_16;
            this.mnuChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.Size = new System.Drawing.Size(24, 24);
            this.mnuChange.Tag = "mnuEdit";
            this.mnuChange.Text = "Change";
            this.mnuChange.ToolTipText = "Change (F4)";
            this.mnuChange.Click += new System.EventHandler(this.mnuChange_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuRemove.Image = global::MagiWol.Properties.Resources.mnuSave_16;
            this.mnuRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(24, 24);
            this.mnuRemove.Text = "Remove";
            this.mnuRemove.ToolTipText = "Remove (Del)";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mnuWake
            // 
            this.mnuWake.Image = global::MagiWol.Properties.Resources.mnuWake_16;
            this.mnuWake.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuWake.Name = "mnuWake";
            this.mnuWake.Size = new System.Drawing.Size(128, 24);
            this.mnuWake.Text = "Wake selected";
            this.mnuWake.ToolTipText = "Wake selected (F6)";
            this.mnuWake.Click += new System.EventHandler(this.mnuWake_Click);
            // 
            // mnuWakeAll
            // 
            this.mnuWakeAll.Image = global::MagiWol.Properties.Resources.mnuWakeAll_16;
            this.mnuWakeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuWakeAll.Name = "mnuWakeAll";
            this.mnuWakeAll.Size = new System.Drawing.Size(89, 24);
            this.mnuWakeAll.Text = "Wake all";
            this.mnuWakeAll.ToolTipText = "Wake all (Shift+F6)";
            this.mnuWakeAll.Click += new System.EventHandler(this.mnuWakeAll_Click);
            // 
            // mnuApp
            // 
            this.mnuApp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAppOptions,
            this.mnuApp0,
            this.mnuAppFeedback,
            this.mnuAppUpgrade,
            this.mnuApp1,
            this.mnuAppAbout});
            this.mnuApp.Image = global::MagiWol.Properties.Resources.mnuApp_16;
            this.mnuApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuApp.Name = "mnuApp";
            this.mnuApp.Size = new System.Drawing.Size(34, 24);
            this.mnuApp.Text = "About";
            // 
            // mnuAppOptions
            // 
            this.mnuAppOptions.Name = "mnuAppOptions";
            this.mnuAppOptions.Size = new System.Drawing.Size(206, 26);
            this.mnuAppOptions.Text = "&Options";
            this.mnuAppOptions.Click += new System.EventHandler(this.mnuAppOptions_Click);
            // 
            // mnuApp0
            // 
            this.mnuApp0.Name = "mnuApp0";
            this.mnuApp0.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuAppFeedback
            // 
            this.mnuAppFeedback.Name = "mnuAppFeedback";
            this.mnuAppFeedback.Size = new System.Drawing.Size(206, 26);
            this.mnuAppFeedback.Text = "Send &feedback";
            this.mnuAppFeedback.Click += new System.EventHandler(this.mnuAppFeedback_Click);
            // 
            // mnuAppUpgrade
            // 
            this.mnuAppUpgrade.Name = "mnuAppUpgrade";
            this.mnuAppUpgrade.Size = new System.Drawing.Size(206, 26);
            this.mnuAppUpgrade.Text = "Check for &upgrade";
            this.mnuAppUpgrade.Click += new System.EventHandler(this.mnuAppUpgrade_Click);
            // 
            // mnuApp1
            // 
            this.mnuApp1.Name = "mnuApp1";
            this.mnuApp1.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuAppAbout
            // 
            this.mnuAppAbout.Name = "mnuAppAbout";
            this.mnuAppAbout.Size = new System.Drawing.Size(206, 26);
            this.mnuAppAbout.Text = "&About";
            this.mnuAppAbout.Click += new System.EventHandler(this.mnuAppAbout_Click);
            // 
            // mnuQuickWake
            // 
            this.mnuQuickWake.Image = global::MagiWol.Properties.Resources.mnuQuickWake_16;
            this.mnuQuickWake.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuQuickWake.Name = "mnuQuickWake";
            this.mnuQuickWake.Size = new System.Drawing.Size(108, 24);
            this.mnuQuickWake.Text = "Quick wake";
            this.mnuQuickWake.ToolTipText = "Quick wake (Ctrl+W)";
            this.mnuQuickWake.Click += new System.EventHandler(this.mnuQuickWake_Click);
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_Name,
            this.list_MAC,
            this.list_Notes});
            this.list.ContextMenuStrip = this.mnxList;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.LabelEdit = true;
            this.list.Location = new System.Drawing.Point(0, 27);
            this.list.Name = "list";
            this.list.ShowGroups = false;
            this.list.Size = new System.Drawing.Size(742, 326);
            this.list.TabIndex = 2;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.list_AfterLabelEdit);
            this.list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_ColumnClick);
            this.list.ItemActivate += new System.EventHandler(this.list_ItemActivate);
            this.list.KeyUp += new System.Windows.Forms.KeyEventHandler(this.list_KeyUp);
            // 
            // list_Name
            // 
            this.list_Name.Tag = "Name";
            this.list_Name.Text = "Name";
            this.list_Name.Width = 150;
            // 
            // list_MAC
            // 
            this.list_MAC.Tag = "MAC";
            this.list_MAC.Text = "MAC address";
            this.list_MAC.Width = 150;
            // 
            // list_Notes
            // 
            this.list_Notes.Tag = "Notes";
            this.list_Notes.Text = "Notes";
            this.list_Notes.Width = 150;
            // 
            // mnxList
            // 
            this.mnxList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnxList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnxListCut,
            this.mnxListCopy,
            this.mnxListPaste,
            this.toolStripMenuItem6,
            this.mnxListEditSelectAll,
            this.toolStripMenuItem9,
            this.mnxListAdd,
            this.mnxListChange,
            this.mnxListRemove,
            this.toolStripMenuItem7,
            this.mnxListActionWake,
            this.toolStripMenuItem10,
            this.mnxListQuickWake});
            this.mnxList.Name = "mnxListAddress";
            this.mnxList.Size = new System.Drawing.Size(216, 262);
            this.mnxList.Opening += new System.ComponentModel.CancelEventHandler(this.mnxList_Opening);
            // 
            // mnxListCut
            // 
            this.mnxListCut.Image = global::MagiWol.Properties.Resources.mnuCut_16;
            this.mnxListCut.Name = "mnxListCut";
            this.mnxListCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnxListCut.Size = new System.Drawing.Size(215, 26);
            this.mnxListCut.Tag = "mnuCut";
            this.mnxListCut.Text = "Cu&t";
            this.mnxListCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnxListCopy
            // 
            this.mnxListCopy.Image = global::MagiWol.Properties.Resources.mnuCopy_16;
            this.mnxListCopy.Name = "mnxListCopy";
            this.mnxListCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnxListCopy.Size = new System.Drawing.Size(215, 26);
            this.mnxListCopy.Tag = "mnuCopy";
            this.mnxListCopy.Text = "&Copy";
            this.mnxListCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnxListPaste
            // 
            this.mnxListPaste.Image = global::MagiWol.Properties.Resources.mnuPaste_16;
            this.mnxListPaste.Name = "mnxListPaste";
            this.mnxListPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnxListPaste.Size = new System.Drawing.Size(215, 26);
            this.mnxListPaste.Tag = "mnuPaste";
            this.mnxListPaste.Text = "&Paste";
            this.mnxListPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(212, 6);
            // 
            // mnxListEditSelectAll
            // 
            this.mnxListEditSelectAll.Name = "mnxListEditSelectAll";
            this.mnxListEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnxListEditSelectAll.Size = new System.Drawing.Size(215, 26);
            this.mnxListEditSelectAll.Text = "&Select all";
            this.mnxListEditSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(212, 6);
            // 
            // mnxListAdd
            // 
            this.mnxListAdd.Image = ((System.Drawing.Image)(resources.GetObject("mnxListAdd.Image")));
            this.mnxListAdd.Name = "mnxListAdd";
            this.mnxListAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.mnxListAdd.Size = new System.Drawing.Size(215, 26);
            this.mnxListAdd.Tag = "mnuAdd";
            this.mnxListAdd.Text = "&Add";
            this.mnxListAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnxListChange
            // 
            this.mnxListChange.Image = global::MagiWol.Properties.Resources.mnuEdit_16;
            this.mnxListChange.Name = "mnxListChange";
            this.mnxListChange.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnxListChange.Size = new System.Drawing.Size(215, 26);
            this.mnxListChange.Tag = "mnuEdit";
            this.mnxListChange.Text = "C&hange";
            this.mnxListChange.Click += new System.EventHandler(this.mnuChange_Click);
            // 
            // mnxListRemove
            // 
            this.mnxListRemove.Image = global::MagiWol.Properties.Resources.mnuRemove_16;
            this.mnxListRemove.Name = "mnxListRemove";
            this.mnxListRemove.ShortcutKeyDisplayString = "Del";
            this.mnxListRemove.Size = new System.Drawing.Size(215, 26);
            this.mnxListRemove.Text = "&Remove";
            this.mnxListRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(212, 6);
            // 
            // mnxListActionWake
            // 
            this.mnxListActionWake.Image = global::MagiWol.Properties.Resources.mnuWake_16;
            this.mnxListActionWake.Name = "mnxListActionWake";
            this.mnxListActionWake.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnxListActionWake.Size = new System.Drawing.Size(215, 26);
            this.mnxListActionWake.Tag = "mnuWake";
            this.mnxListActionWake.Text = "&Wake selected";
            this.mnxListActionWake.Click += new System.EventHandler(this.mnuWake_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(212, 6);
            // 
            // mnxListQuickWake
            // 
            this.mnxListQuickWake.Name = "mnxListQuickWake";
            this.mnxListQuickWake.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnxListQuickWake.Size = new System.Drawing.Size(215, 26);
            this.mnxListQuickWake.Text = "&Quick wake";
            this.mnxListQuickWake.Click += new System.EventHandler(this.mnxListQuickWake_Click);
            // 
            // timerEnableDisable
            // 
            this.timerEnableDisable.Enabled = true;
            this.timerEnableDisable.Interval = 500;
            this.timerEnableDisable.Tick += new System.EventHandler(this.timerEnableDisable_Tick);
            // 
            // tmrReSort
            // 
            this.tmrReSort.Tick += new System.EventHandler(this.tmrReSortAfterRename_Tick);
            // 
            // bwCheckForUpgrade
            // 
            this.bwCheckForUpgrade.WorkerSupportsCancellation = true;
            this.bwCheckForUpgrade.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckForUpgrade_DoWork);
            this.bwCheckForUpgrade.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCheckForUpgrade_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 353);
            this.Controls.Add(this.list);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "MainForm";
            this.Text = "MagiWOL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.mnxList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnu;
        private System.Windows.Forms.ToolStripButton mnuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuWake;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader list_Name;
        private System.Windows.Forms.ColumnHeader list_MAC;
        private System.Windows.Forms.ColumnHeader list_Notes;
        private System.Windows.Forms.ToolStripButton mnuAdd;
        private System.Windows.Forms.ToolStripButton mnuChange;
        private System.Windows.Forms.ToolStripButton mnuRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton mnuOpenRoot;
        private System.Windows.Forms.Timer timerEnableDisable;
        private System.Windows.Forms.ToolStripButton mnuQuickWake;
        private System.Windows.Forms.ContextMenuStrip mnxList;
        private System.Windows.Forms.ToolStripMenuItem mnxListCut;
        private System.Windows.Forms.ToolStripMenuItem mnxListCopy;
        private System.Windows.Forms.ToolStripMenuItem mnxListPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnxListAdd;
        private System.Windows.Forms.ToolStripMenuItem mnxListChange;
        private System.Windows.Forms.ToolStripMenuItem mnxListRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnxListQuickWake;
        private System.Windows.Forms.ToolStripButton mnuCut;
        private System.Windows.Forms.ToolStripButton mnuCopy;
        private System.Windows.Forms.ToolStripButton mnuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnxListEditSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem mnxListActionWake;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripButton mnuWakeAll;
        private System.Windows.Forms.Timer tmrReSort;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripSeparator mnuImport0;
        private System.Windows.Forms.ToolStripSplitButton mnuSaveRoot;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripDropDownButton mnuApp;
        private System.Windows.Forms.ToolStripMenuItem mnuAppFeedback;
        private System.Windows.Forms.ToolStripMenuItem mnuAppUpgrade;
        private System.Windows.Forms.ToolStripSeparator mnuApp1;
        private System.Windows.Forms.ToolStripMenuItem mnuAppAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuAppOptions;
        private System.Windows.Forms.ToolStripSeparator mnuApp0;
        private System.ComponentModel.BackgroundWorker bwCheckForUpgrade;
    }
}


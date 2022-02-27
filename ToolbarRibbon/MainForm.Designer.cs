namespace ToolbarRibbon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileRibbonTabMenuItem = new ToolbarRibbon.RibbonTabMenuItem();
            this.startRibbonTabMenuItem = new ToolbarRibbon.RibbonTabMenuItem();
            this.helpRibbonTabMenuItem = new ToolbarRibbon.RibbonTabMenuItem();
            this.fileRibbonToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileNewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileSaveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startRibbonToolStrip = new System.Windows.Forms.ToolStrip();
            this.startCutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startCopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startPasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startCreateCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startModifyCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startDeleteCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpRibbonToolStrip = new System.Windows.Forms.ToolStrip();
            this.helpContentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpAboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ribbonMenuStrip.SuspendLayout();
            this.fileRibbonToolStrip.SuspendLayout();
            this.startRibbonToolStrip.SuspendLayout();
            this.helpRibbonToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMenuStrip
            // 
            this.ribbonMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbonMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileRibbonTabMenuItem,
            this.startRibbonTabMenuItem,
            this.helpRibbonTabMenuItem});
            this.ribbonMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenuStrip.Name = "ribbonMenuStrip";
            this.ribbonMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.ribbonMenuStrip.TabIndex = 0;
            this.ribbonMenuStrip.Text = "menuStrip1";
            // 
            // fileRibbonTabMenuItem
            // 
            this.fileRibbonTabMenuItem.CheckedColor1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileRibbonTabMenuItem.CheckedColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileRibbonTabMenuItem.CheckOnClick = true;
            this.fileRibbonTabMenuItem.GroupId = 0;
            this.fileRibbonTabMenuItem.Name = "fileRibbonTabMenuItem";
            this.fileRibbonTabMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileRibbonTabMenuItem.Text = "&File";
            this.fileRibbonTabMenuItem.CheckStateChanged += new System.EventHandler(this.FileRibbonTabMenuItem_CheckStateChanged);
            // 
            // startRibbonTabMenuItem
            // 
            this.startRibbonTabMenuItem.CheckedColor1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.startRibbonTabMenuItem.CheckedColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.startRibbonTabMenuItem.CheckOnClick = true;
            this.startRibbonTabMenuItem.GroupId = 0;
            this.startRibbonTabMenuItem.Name = "startRibbonTabMenuItem";
            this.startRibbonTabMenuItem.Size = new System.Drawing.Size(54, 24);
            this.startRibbonTabMenuItem.Text = "&Start";
            this.startRibbonTabMenuItem.CheckStateChanged += new System.EventHandler(this.StartRibbonTabMenuItem_CheckStateChanged);
            // 
            // helpRibbonTabMenuItem
            // 
            this.helpRibbonTabMenuItem.CheckedColor1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.helpRibbonTabMenuItem.CheckedColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.helpRibbonTabMenuItem.CheckOnClick = true;
            this.helpRibbonTabMenuItem.GroupId = 0;
            this.helpRibbonTabMenuItem.Name = "helpRibbonTabMenuItem";
            this.helpRibbonTabMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpRibbonTabMenuItem.Text = "&Help";
            this.helpRibbonTabMenuItem.CheckStateChanged += new System.EventHandler(this.HelpRibbonTabMenuItem_CheckStateChanged);
            // 
            // fileRibbonToolStrip
            // 
            this.fileRibbonToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fileRibbonToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fileRibbonToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewToolStripButton,
            this.fileOpenToolStripButton,
            this.fileToolStripSeparator1,
            this.fileSaveToolStripButton,
            this.fileSaveAsToolStripButton,
            this.fileExitToolStripButton});
            this.fileRibbonToolStrip.Location = new System.Drawing.Point(0, 28);
            this.fileRibbonToolStrip.Name = "fileRibbonToolStrip";
            this.fileRibbonToolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileRibbonToolStrip.Size = new System.Drawing.Size(800, 39);
            this.fileRibbonToolStrip.TabIndex = 1;
            this.fileRibbonToolStrip.Text = "File Ribbon";
            // 
            // fileNewToolStripButton
            // 
            this.fileNewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileNewToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.FileNew;
            this.fileNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileNewToolStripButton.Name = "fileNewToolStripButton";
            this.fileNewToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.fileNewToolStripButton.Text = "New File";
            // 
            // fileOpenToolStripButton
            // 
            this.fileOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileOpenToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.FileOpen;
            this.fileOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileOpenToolStripButton.Name = "fileOpenToolStripButton";
            this.fileOpenToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.fileOpenToolStripButton.Text = "Open File...";
            // 
            // fileToolStripSeparator1
            // 
            this.fileToolStripSeparator1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fileToolStripSeparator1.Name = "fileToolStripSeparator1";
            this.fileToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // fileSaveToolStripButton
            // 
            this.fileSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileSaveToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.FileSave;
            this.fileSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveToolStripButton.Name = "fileSaveToolStripButton";
            this.fileSaveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.fileSaveToolStripButton.Text = "Save File";
            // 
            // fileSaveAsToolStripButton
            // 
            this.fileSaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileSaveAsToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.FileSaveAs;
            this.fileSaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveAsToolStripButton.Name = "fileSaveAsToolStripButton";
            this.fileSaveAsToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.fileSaveAsToolStripButton.Text = "Save File As...";
            // 
            // fileExitToolStripButton
            // 
            this.fileExitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fileExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileExitToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ApplicationExit;
            this.fileExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileExitToolStripButton.Name = "fileExitToolStripButton";
            this.fileExitToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.fileExitToolStripButton.Text = "Exit Application";
            // 
            // startRibbonToolStrip
            // 
            this.startRibbonToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.startRibbonToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.startRibbonToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCutToolStripButton,
            this.startCopyToolStripButton,
            this.startPasteToolStripButton,
            this.startToolStripSeparator1,
            this.startCreateCommentToolStripButton,
            this.startModifyCommentToolStripButton,
            this.startDeleteCommentToolStripButton});
            this.startRibbonToolStrip.Location = new System.Drawing.Point(0, 67);
            this.startRibbonToolStrip.Name = "startRibbonToolStrip";
            this.startRibbonToolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startRibbonToolStrip.Size = new System.Drawing.Size(800, 39);
            this.startRibbonToolStrip.TabIndex = 2;
            this.startRibbonToolStrip.Text = "Start Ribbon";
            // 
            // startCutToolStripButton
            // 
            this.startCutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startCutToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.EditCut;
            this.startCutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startCutToolStripButton.Name = "startCutToolStripButton";
            this.startCutToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startCutToolStripButton.Text = "Cut";
            // 
            // startCopyToolStripButton
            // 
            this.startCopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startCopyToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.EditCopy;
            this.startCopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startCopyToolStripButton.Name = "startCopyToolStripButton";
            this.startCopyToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startCopyToolStripButton.Text = "Copy";
            // 
            // startPasteToolStripButton
            // 
            this.startPasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startPasteToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.EditPaste;
            this.startPasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startPasteToolStripButton.Name = "startPasteToolStripButton";
            this.startPasteToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startPasteToolStripButton.Text = "Paste";
            // 
            // startToolStripSeparator1
            // 
            this.startToolStripSeparator1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startToolStripSeparator1.Name = "startToolStripSeparator1";
            this.startToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // startCreateCommentToolStripButton
            // 
            this.startCreateCommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startCreateCommentToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ReviewCreateComment;
            this.startCreateCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startCreateCommentToolStripButton.Name = "startCreateCommentToolStripButton";
            this.startCreateCommentToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startCreateCommentToolStripButton.Text = "Create Comment...";
            // 
            // startModifyCommentToolStripButton
            // 
            this.startModifyCommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startModifyCommentToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ReviewModifyComment;
            this.startModifyCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startModifyCommentToolStripButton.Name = "startModifyCommentToolStripButton";
            this.startModifyCommentToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startModifyCommentToolStripButton.Text = "Modify Comment...";
            // 
            // startDeleteCommentToolStripButton
            // 
            this.startDeleteCommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startDeleteCommentToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ReviewDeleteComment;
            this.startDeleteCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startDeleteCommentToolStripButton.Name = "startDeleteCommentToolStripButton";
            this.startDeleteCommentToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.startDeleteCommentToolStripButton.Text = "Delete Comment...";
            // 
            // helpRibbonToolStrip
            // 
            this.helpRibbonToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.helpRibbonToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.helpRibbonToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentToolStripButton,
            this.helpAboutToolStripButton});
            this.helpRibbonToolStrip.Location = new System.Drawing.Point(0, 106);
            this.helpRibbonToolStrip.Name = "helpRibbonToolStrip";
            this.helpRibbonToolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.helpRibbonToolStrip.Size = new System.Drawing.Size(800, 39);
            this.helpRibbonToolStrip.TabIndex = 3;
            this.helpRibbonToolStrip.Text = "Help Ribon";
            // 
            // helpContentToolStripButton
            // 
            this.helpContentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpContentToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ApplicationHelp;
            this.helpContentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpContentToolStripButton.Name = "helpContentToolStripButton";
            this.helpContentToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpContentToolStripButton.Text = "Help Content";
            // 
            // helpAboutToolStripButton
            // 
            this.helpAboutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpAboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpAboutToolStripButton.Image = global::ToolbarRibbon.Properties.Resources.ApplicationAbout;
            this.helpAboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpAboutToolStripButton.Name = "helpAboutToolStripButton";
            this.helpAboutToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpAboutToolStripButton.Text = "About...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpRibbonToolStrip);
            this.Controls.Add(this.startRibbonToolStrip);
            this.Controls.Add(this.fileRibbonToolStrip);
            this.Controls.Add(this.ribbonMenuStrip);
            this.MainMenuStrip = this.ribbonMenuStrip;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ribbonMenuStrip.ResumeLayout(false);
            this.ribbonMenuStrip.PerformLayout();
            this.fileRibbonToolStrip.ResumeLayout(false);
            this.fileRibbonToolStrip.PerformLayout();
            this.startRibbonToolStrip.ResumeLayout(false);
            this.startRibbonToolStrip.PerformLayout();
            this.helpRibbonToolStrip.ResumeLayout(false);
            this.helpRibbonToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip ribbonMenuStrip;
        private RibbonTabMenuItem fileRibbonTabMenuItem;
        private RibbonTabMenuItem startRibbonTabMenuItem;
        private RibbonTabMenuItem helpRibbonTabMenuItem;
        private ToolStrip fileRibbonToolStrip;
        private ToolStripButton fileNewToolStripButton;
        private ToolStripButton fileOpenToolStripButton;
        private ToolStripSeparator fileToolStripSeparator1;
        private ToolStripButton fileSaveToolStripButton;
        private ToolStripButton fileSaveAsToolStripButton;
        private ToolStripButton fileExitToolStripButton;
        private ToolStrip startRibbonToolStrip;
        private ToolStripButton startCutToolStripButton;
        private ToolStripButton startCopyToolStripButton;
        private ToolStripButton startPasteToolStripButton;
        private ToolStripSeparator startToolStripSeparator1;
        private ToolStripButton startCreateCommentToolStripButton;
        private ToolStripButton startModifyCommentToolStripButton;
        private ToolStripButton startDeleteCommentToolStripButton;
        private ToolStrip helpRibbonToolStrip;
        private ToolStripButton helpContentToolStripButton;
        private ToolStripButton helpAboutToolStripButton;
    }
}
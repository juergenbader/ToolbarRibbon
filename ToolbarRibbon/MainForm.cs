#region Copyright
// ----------------------------------------------------------------------
// Copyright (c) 2022 Bader CONSILIA
// ----------------------------------------------------------------------
// Project   ToolbarRibbon
// Namespace ToolbarRibbon
// FileName  MainForm.cs
// ----------------------------------------------------------------------
// Created   27.02.2022, 16:52
// Updated   27.02.2022, 17:40
// Author    Jürgen Bader (Administrator)
// ----------------------------------------------------------------------
#endregion

namespace ToolbarRibbon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            startRibbonTabMenuItem.Checked = true;
        }

        private void FileRibbonTabMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            fileRibbonToolStrip.Visible = true;
            startRibbonToolStrip.Visible = false;
            helpRibbonToolStrip.Visible = false;
        }

        private void StartRibbonTabMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            fileRibbonToolStrip.Visible = false;
            startRibbonToolStrip.Visible = true;
            helpRibbonToolStrip.Visible = false;
        }

        private void HelpRibbonTabMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            fileRibbonToolStrip.Visible = false;
            startRibbonToolStrip.Visible = false;
            helpRibbonToolStrip.Visible = true;
        }
    }
}

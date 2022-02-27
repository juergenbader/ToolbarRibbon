#region Copyright
// ----------------------------------------------------------------------
// Copyright (c) 2022 Bader CONSILIA
// ----------------------------------------------------------------------
// Project   ToolbarRibbon
// Namespace ToolbarRibbon
// FileName  RibbonTabMenuItem.cs
// ----------------------------------------------------------------------
// Created   27.02.2022, 16:52
// Updated   27.02.2022, 16:58
// Author    Jürgen Bader (Administrator)
// ----------------------------------------------------------------------
#endregion

using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ToolbarRibbon
{
    public class RibbonTabMenuItem : ToolStripMenuItem
    {
        private int groupId = 0;
        private bool updateGroup = true;

        private Color checkedColor1 = Color.FromKnownColor(KnownColor.GradientActiveCaption); //Color.FromArgb(71, 113, 179);
        private Color checkedColor2 = Color.FromKnownColor(KnownColor.GradientActiveCaption); //Color.FromArgb(98, 139, 205);

        public RibbonTabMenuItem()
        {
            this.CheckOnClick = true;
        }

        [Category("Behavior")]
        public int GroupId
        {
            get
            {
                return groupId;
            }
            set
            {
                groupId = value;

                // Make sure no two radio buttons are checked at the same time
                UpdateGroup();
            }
        }

        [Category("Appearance")]
        public Color CheckedColor1
        {
            get { return checkedColor1; }
            set { checkedColor1 = value; }
        }

        [Category("Appearance")]
        public Color CheckedColor2
        {
            get { return checkedColor2; }
            set { checkedColor2 = value; }
        }

        // Set check value without updating (disabling) other radio buttons in the group
        private void SetCheckValue(bool checkValue)
        {
            updateGroup = false;
            this.Checked = checkValue;
            updateGroup = true;
        }

        // To make sure no two radio buttons are checked at the same time
        private void UpdateGroup()
        {
            if (this.Parent != null)
            {
                // Get number of checked radio buttons in group
                int checkedCount = this.Parent.Items.OfType<RibbonTabMenuItem>().Count(x => x.GroupId == GroupId && x.Checked);

                if (checkedCount > 1)
                {
                    this.Checked = false;
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Checked = true;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (this.Parent != null && updateGroup)
            {
                foreach (RibbonTabMenuItem radioButton in this.Parent.Items.OfType<RibbonTabMenuItem>())
                {
                    // Disable all other radio buttons with same group id
                    if (radioButton != this && radioButton.GroupId == this.GroupId)
                    {
                        radioButton.SetCheckValue(false);
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Checked)
            {
                var checkedBackgroundBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), CheckedColor1, CheckedColor2);
                e.Graphics.FillRectangle(checkedBackgroundBrush, new Rectangle(new Point(0, 0), this.Size));
            }

            base.OnPaint(e);
        }

    }
}

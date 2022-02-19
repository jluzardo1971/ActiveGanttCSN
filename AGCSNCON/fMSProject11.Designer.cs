// ----------------------------------------------------------------------------------------
//                              COPYRIGHT NOTICE
// ----------------------------------------------------------------------------------------
//
// The Source Code Store LLC
// ACTIVEGANTT SCHEDULER COMPONENT FOR C# - ActiveGanttCSN
// Windows Forms Control
// Copyright (c) 2002-2017 The Source Code Store LLC
//
// All Rights Reserved. No parts of this file may be reproduced, modified or transmitted 
// in any form or by any means without the written permission of the author.
//
// ----------------------------------------------------------------------------------------
namespace AGCSNCON
{
    partial class fMSProject11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMSProject11));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMSProject2003XMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMSProject2003XMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdLoadXML = new System.Windows.Forms.ToolStripButton();
            this.cmdSaveXML = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.cmdIndent = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdZoomIn = new System.Windows.Forms.ToolStripButton();
            this.cmdZoomOut = new System.Windows.Forms.ToolStripButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ActiveGanttCSNCtl1 = new AGCSN.ActiveGanttCSNCtl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(875, 24);
            this.MenuStrip1.TabIndex = 7;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadMSProject2003XMLFileToolStripMenuItem,
            this.SaveMSProject2003XMLFileToolStripMenuItem,
            this.ToolStripSeparator1,
            this.PrintToolStripMenuItem,
            this.ToolStripSeparator2,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // LoadMSProject2003XMLFileToolStripMenuItem
            // 
            this.LoadMSProject2003XMLFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoadMSProject2003XMLFileToolStripMenuItem.Image")));
            this.LoadMSProject2003XMLFileToolStripMenuItem.Name = "LoadMSProject2003XMLFileToolStripMenuItem";
            this.LoadMSProject2003XMLFileToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.LoadMSProject2003XMLFileToolStripMenuItem.Text = "Load MS-Project 2003 XML File...";
            this.LoadMSProject2003XMLFileToolStripMenuItem.Click += new System.EventHandler(this.LoadMSProject2003XMLFileToolStripMenuItem_Click);
            // 
            // SaveMSProject2003XMLFileToolStripMenuItem
            // 
            this.SaveMSProject2003XMLFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveMSProject2003XMLFileToolStripMenuItem.Image")));
            this.SaveMSProject2003XMLFileToolStripMenuItem.Name = "SaveMSProject2003XMLFileToolStripMenuItem";
            this.SaveMSProject2003XMLFileToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.SaveMSProject2003XMLFileToolStripMenuItem.Text = "Save MS-Project 2003 XML File...";
            this.SaveMSProject2003XMLFileToolStripMenuItem.Click += new System.EventHandler(this.SaveMSProject2003XMLFileToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.PrintToolStripMenuItem.Text = "Print...";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdLoadXML,
            this.cmdSaveXML,
            this.cmdPrint,
            this.cmdIndent,
            this.ToolStripSeparator3,
            this.cmdZoomIn,
            this.cmdZoomOut});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(875, 25);
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // cmdLoadXML
            // 
            this.cmdLoadXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLoadXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoadXML.Image")));
            this.cmdLoadXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoadXML.Name = "cmdLoadXML";
            this.cmdLoadXML.Size = new System.Drawing.Size(23, 22);
            this.cmdLoadXML.Text = "ToolStripButton1";
            this.cmdLoadXML.ToolTipText = "Load MS-Project 2003 XML File";
            this.cmdLoadXML.Click += new System.EventHandler(this.cmdLoadXML_Click);
            // 
            // cmdSaveXML
            // 
            this.cmdSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveXML.Image")));
            this.cmdSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSaveXML.Name = "cmdSaveXML";
            this.cmdSaveXML.Size = new System.Drawing.Size(23, 22);
            this.cmdSaveXML.Text = "ToolStripButton2";
            this.cmdSaveXML.ToolTipText = "Save MS-Project 2003 XML File";
            this.cmdSaveXML.Click += new System.EventHandler(this.cmdSaveXML_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(23, 22);
            this.cmdPrint.Text = "ToolStripButton1";
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdIndent
            // 
            this.cmdIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdIndent.Image = ((System.Drawing.Image)(resources.GetObject("cmdIndent.Image")));
            this.cmdIndent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdIndent.Name = "cmdIndent";
            this.cmdIndent.Size = new System.Drawing.Size(23, 22);
            this.cmdIndent.Text = "ToolStripButton1";
            this.cmdIndent.Click += new System.EventHandler(this.cmdIndent_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomIn.Image")));
            this.cmdZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(23, 22);
            this.cmdZoomIn.Text = "Zoom In";
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomOut.Image")));
            this.cmdZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(23, 22);
            this.cmdZoomOut.Text = "Zoom Out";
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "projectnote2003.gif");
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // ActiveGanttCSNCtl1
            // 
            this.ActiveGanttCSNCtl1.AddDurationInterval = AGCSN.E_INTERVAL.IL_SECOND;
            this.ActiveGanttCSNCtl1.AddMode = AGCSN.E_ADDMODE.AT_TASKADD;
            this.ActiveGanttCSNCtl1.AllowAdd = true;
            this.ActiveGanttCSNCtl1.AllowColumnMove = true;
            this.ActiveGanttCSNCtl1.AllowColumnSize = true;
            this.ActiveGanttCSNCtl1.AllowEdit = true;
            this.ActiveGanttCSNCtl1.AllowPredecessorAdd = true;
            this.ActiveGanttCSNCtl1.AllowRowMove = true;
            this.ActiveGanttCSNCtl1.AllowRowSize = true;
            this.ActiveGanttCSNCtl1.AllowSplitterMove = true;
            this.ActiveGanttCSNCtl1.AllowTimeLineScroll = true;
            this.ActiveGanttCSNCtl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ActiveGanttCSNCtl1.ControlTag = "";
            this.ActiveGanttCSNCtl1.Culture = new System.Globalization.CultureInfo("en-US");
            this.ActiveGanttCSNCtl1.CurrentLayer = "0";
            this.ActiveGanttCSNCtl1.CurrentView = "0";
            this.ActiveGanttCSNCtl1.DoubleBuffering = true;
            this.ActiveGanttCSNCtl1.EnforcePredecessors = false;
            this.ActiveGanttCSNCtl1.ErrorReports = AGCSN.E_REPORTERRORS.RE_MSGBOX;
            this.ActiveGanttCSNCtl1.Image = null;
            this.ActiveGanttCSNCtl1.ImageTag = "";
            this.ActiveGanttCSNCtl1.LayerEnableObjects = AGCSN.E_LAYEROBJECTENABLE.EC_INCURRENTLAYERONLY;
            this.ActiveGanttCSNCtl1.Location = new System.Drawing.Point(36, 22);
            this.ActiveGanttCSNCtl1.MinColumnWidth = 5;
            this.ActiveGanttCSNCtl1.MinRowHeight = 5;
            this.ActiveGanttCSNCtl1.Name = "ActiveGanttCSNCtl1";
            this.ActiveGanttCSNCtl1.PredecessorAddModeKey = System.Windows.Forms.Keys.F2;
            this.ActiveGanttCSNCtl1.PredecessorMode = AGCSN.E_PREDECESSORMODE.PM_CREATEWARNINGFLAG;
            this.ActiveGanttCSNCtl1.ProgressLineScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.ScrollBarBehaviour = AGCSN.E_SCROLLBEHAVIOUR.SB_HIDE;
            this.ActiveGanttCSNCtl1.SelectedCellIndex = 0;
            this.ActiveGanttCSNCtl1.SelectedColumnIndex = 0;
            this.ActiveGanttCSNCtl1.SelectedPercentageIndex = 0;
            this.ActiveGanttCSNCtl1.SelectedPredecessorIndex = 0;
            this.ActiveGanttCSNCtl1.SelectedRowIndex = 0;
            this.ActiveGanttCSNCtl1.SelectedTaskIndex = 0;
            this.ActiveGanttCSNCtl1.Size = new System.Drawing.Size(508, 354);
            this.ActiveGanttCSNCtl1.StyleIndex = "";
            this.ActiveGanttCSNCtl1.TabIndex = 0;
            this.ActiveGanttCSNCtl1.TierAppearanceScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TierFormatScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TimeBlockBehaviour = AGCSN.E_TIMEBLOCKBEHAVIOUR.TBB_ROWEXTENTS;
            this.ActiveGanttCSNCtl1.TimeLineScrollBarScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TreeviewColumnIndex = 0;
            this.ActiveGanttCSNCtl1.ControlMouseWheel += new AGCSN.ActiveGanttCSNCtl.ControlMouseWheelEventHandler(this.ActiveGanttCSNCtl1_ControlMouseWheel);
            this.ActiveGanttCSNCtl1.CustomTierDraw += new AGCSN.ActiveGanttCSNCtl.CustomTierDrawEventHandler(this.ActiveGanttCSNCtl1_CustomTierDraw);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveGanttCSNCtl1);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 401);
            this.panel1.TabIndex = 9;
            // 
            // fMSProject11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "fMSProject11";
            this.Text = "Project 2003 Integration";
            this.Load += new System.EventHandler(this.fMSProject11_Load);
            this.Resize += new System.EventHandler(this.fMSProject11_Resize);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LoadMSProject2003XMLFileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveMSProject2003XMLFileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton cmdLoadXML;
        internal System.Windows.Forms.ToolStripButton cmdSaveXML;
        internal System.Windows.Forms.ToolStripButton cmdPrint;
        internal System.Windows.Forms.ToolStripButton cmdIndent;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton cmdZoomIn;
        internal System.Windows.Forms.ToolStripButton cmdZoomOut;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private AGCSN.ActiveGanttCSNCtl ActiveGanttCSNCtl1;
        private System.Windows.Forms.Panel panel1;
    }
}
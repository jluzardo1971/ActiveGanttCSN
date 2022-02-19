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
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AGCSNCON
{
    partial class fWBSProject
    {
        internal System.Windows.Forms.ImageList imgTreeView;
        public AGCSN.ActiveGanttCSNCtl ActiveGanttCSNCtl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuSaveXML;
        private ToolStripMenuItem mnuLoadXML;
        private ToolStripMenuItem mnuPrint;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuClose;
        private ToolStripMenuItem treeviewPropertiesToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem mnuCheckBoxes;
        private ToolStripMenuItem mnuImages;
        private ToolStripMenuItem mnuFullColumnSelect;
        private ToolStripButton cmdSaveXML;
        private ToolStripButton cmdLoadXML;
        private ToolStripButton cmdPrint;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton cmdZoomIn;
        private ToolStripButton cmdZoomOut;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton cmdBluePercentages;
        private ToolStripButton cmdGreenPercentages;
        private ToolStripButton cmdRedPercentages;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton cmdToolTips;
        private ToolStripButton cmdHelp;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton cmdProperties;
        private ToolStripButton cmdCheck;
        private System.ComponentModel.IContainer components;





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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWBSProject));
            this.ActiveGanttCSNCtl1 = new AGCSN.ActiveGanttCSNCtl();
            this.imgTreeView = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckBoxes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImages = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFullColumnSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdSaveXML = new System.Windows.Forms.ToolStripButton();
            this.cmdLoadXML = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdZoomIn = new System.Windows.Forms.ToolStripButton();
            this.cmdZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBluePercentages = new System.Windows.Forms.ToolStripButton();
            this.cmdGreenPercentages = new System.Windows.Forms.ToolStripButton();
            this.cmdRedPercentages = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdProperties = new System.Windows.Forms.ToolStripButton();
            this.cmdCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdToolTips = new System.Windows.Forms.ToolStripButton();
            this.cmdHelp = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.ActiveGanttCSNCtl1.BackColor = System.Drawing.Color.White;
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
            this.ActiveGanttCSNCtl1.Location = new System.Drawing.Point(62, 20);
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
            this.ActiveGanttCSNCtl1.Size = new System.Drawing.Size(756, 410);
            this.ActiveGanttCSNCtl1.StyleIndex = "";
            this.ActiveGanttCSNCtl1.TabIndex = 0;
            this.ActiveGanttCSNCtl1.TierAppearanceScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TierFormatScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TimeBlockBehaviour = AGCSN.E_TIMEBLOCKBEHAVIOUR.TBB_ROWEXTENTS;
            this.ActiveGanttCSNCtl1.TimeLineScrollBarScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TreeviewColumnIndex = 0;
            this.ActiveGanttCSNCtl1.ControlMouseDown += new AGCSN.ActiveGanttCSNCtl.ControlMouseDownEventHandler(this.ActiveGanttCSNCtl1_ControlMouseDown);
            this.ActiveGanttCSNCtl1.ControlMouseWheel += new AGCSN.ActiveGanttCSNCtl.ControlMouseWheelEventHandler(this.ActiveGanttCSNCtl1_ControlMouseWheel);
            this.ActiveGanttCSNCtl1.CustomTierDraw += new AGCSN.ActiveGanttCSNCtl.CustomTierDrawEventHandler(this.ActiveGanttCSNCtl1_CustomTierDraw);
            this.ActiveGanttCSNCtl1.ObjectAdded += new AGCSN.ActiveGanttCSNCtl.ObjectAddedEventHandler(this.ActiveGanttCSNCtl1_ObjectAdded);
            this.ActiveGanttCSNCtl1.CompleteObjectChange += new AGCSN.ActiveGanttCSNCtl.CompleteObjectChangeEventHandler(this.ActiveGanttCSNCtl1_CompleteObjectChange);
            this.ActiveGanttCSNCtl1.NodeChecked += new AGCSN.ActiveGanttCSNCtl.NodeCheckedEventHandler(this.ActiveGanttCSNCtl1_NodeChecked);
            this.ActiveGanttCSNCtl1.EndTextEdit += new AGCSN.ActiveGanttCSNCtl.EndTextEditHandler(this.ActiveGanttCSNCtl1_EndTextEdit);
            this.ActiveGanttCSNCtl1.ToolTipOnMouseHover += new AGCSN.ActiveGanttCSNCtl.ToolTipOnMouseHoverEventHandler(this.ActiveGanttCSNCtl1_ToolTipOnMouseHover);
            this.ActiveGanttCSNCtl1.ToolTipOnMouseMove += new AGCSN.ActiveGanttCSNCtl.ToolTipOnMouseMoveEventHandler(this.ActiveGanttCSNCtl1_ToolTipOnMouseMove);
            this.ActiveGanttCSNCtl1.OnMouseHoverToolTipDraw += new AGCSN.ActiveGanttCSNCtl.OnMouseHoverToolTipDrawEventHandler(this.ActiveGanttCSNCtl1_OnMouseHoverToolTipDraw);
            this.ActiveGanttCSNCtl1.OnMouseMoveToolTipDraw += new AGCSN.ActiveGanttCSNCtl.OnMouseMoveToolTipDrawEventHandler(this.ActiveGanttCSNCtl1_OnMouseMoveToolTipDraw);
            this.ActiveGanttCSNCtl1.PagePrint += new AGCSN.ActiveGanttCSNCtl.PagePrintEventHandler(this.ActiveGanttCSNCtl1_PagePrint);
            // 
            // imgTreeView
            // 
            this.imgTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeView.ImageStream")));
            this.imgTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeView.Images.SetKeyName(0, "");
            this.imgTreeView.Images.SetKeyName(1, "");
            this.imgTreeView.Images.SetKeyName(2, "");
            this.imgTreeView.Images.SetKeyName(3, "");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.treeviewPropertiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveXML,
            this.mnuLoadXML,
            this.mnuPrint,
            this.toolStripSeparator1,
            this.mnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSaveXML
            // 
            this.mnuSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveXML.Image")));
            this.mnuSaveXML.Name = "mnuSaveXML";
            this.mnuSaveXML.Size = new System.Drawing.Size(208, 30);
            this.mnuSaveXML.Text = "Save as XML...";
            this.mnuSaveXML.Click += new System.EventHandler(this.mnuSaveXML_Click);
            // 
            // mnuLoadXML
            // 
            this.mnuLoadXML.Image = ((System.Drawing.Image)(resources.GetObject("mnuLoadXML.Image")));
            this.mnuLoadXML.Name = "mnuLoadXML";
            this.mnuLoadXML.Size = new System.Drawing.Size(208, 30);
            this.mnuLoadXML.Text = "Load XML...";
            this.mnuLoadXML.Click += new System.EventHandler(this.mnuLoadXML_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Image")));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(208, 30);
            this.mnuPrint.Text = "Print...";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(208, 30);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // treeviewPropertiesToolStripMenuItem
            // 
            this.treeviewPropertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCheckBoxes,
            this.mnuImages,
            this.mnuFullColumnSelect});
            this.treeviewPropertiesToolStripMenuItem.Name = "treeviewPropertiesToolStripMenuItem";
            this.treeviewPropertiesToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.treeviewPropertiesToolStripMenuItem.Text = "Treeview Properties";
            // 
            // mnuCheckBoxes
            // 
            this.mnuCheckBoxes.Checked = true;
            this.mnuCheckBoxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuCheckBoxes.Name = "mnuCheckBoxes";
            this.mnuCheckBoxes.Size = new System.Drawing.Size(232, 30);
            this.mnuCheckBoxes.Text = "CheckBoxes";
            this.mnuCheckBoxes.Click += new System.EventHandler(this.mnuCheckBoxes_Click);
            // 
            // mnuImages
            // 
            this.mnuImages.Checked = true;
            this.mnuImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuImages.Name = "mnuImages";
            this.mnuImages.Size = new System.Drawing.Size(232, 30);
            this.mnuImages.Text = "Images";
            this.mnuImages.Click += new System.EventHandler(this.mnuImages_Click);
            // 
            // mnuFullColumnSelect
            // 
            this.mnuFullColumnSelect.Checked = true;
            this.mnuFullColumnSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFullColumnSelect.Name = "mnuFullColumnSelect";
            this.mnuFullColumnSelect.Size = new System.Drawing.Size(232, 30);
            this.mnuFullColumnSelect.Text = "FullColumnSelect";
            this.mnuFullColumnSelect.Click += new System.EventHandler(this.mnuFullColumnSelect_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSaveXML,
            this.cmdLoadXML,
            this.cmdPrint,
            this.toolStripSeparator2,
            this.cmdZoomIn,
            this.cmdZoomOut,
            this.toolStripSeparator3,
            this.cmdBluePercentages,
            this.cmdGreenPercentages,
            this.cmdRedPercentages,
            this.toolStripSeparator5,
            this.cmdProperties,
            this.cmdCheck,
            this.toolStripSeparator4,
            this.cmdToolTips,
            this.cmdHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdSaveXML
            // 
            this.cmdSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveXML.Image")));
            this.cmdSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSaveXML.Name = "cmdSaveXML";
            this.cmdSaveXML.Size = new System.Drawing.Size(28, 28);
            this.cmdSaveXML.Text = "toolStripButton1";
            this.cmdSaveXML.ToolTipText = "Save as XML";
            this.cmdSaveXML.Click += new System.EventHandler(this.cmdSaveXML_Click);
            // 
            // cmdLoadXML
            // 
            this.cmdLoadXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLoadXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoadXML.Image")));
            this.cmdLoadXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoadXML.Name = "cmdLoadXML";
            this.cmdLoadXML.Size = new System.Drawing.Size(28, 28);
            this.cmdLoadXML.Text = "toolStripButton2";
            this.cmdLoadXML.ToolTipText = "Load XML";
            this.cmdLoadXML.Click += new System.EventHandler(this.cmdLoadXML_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(28, 28);
            this.cmdPrint.Text = "toolStripButton3";
            this.cmdPrint.ToolTipText = "Print";
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomIn.Image")));
            this.cmdZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(28, 28);
            this.cmdZoomIn.Text = "toolStripButton4";
            this.cmdZoomIn.ToolTipText = "Zoom in";
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomOut.Image")));
            this.cmdZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(28, 28);
            this.cmdZoomOut.Text = "toolStripButton5";
            this.cmdZoomOut.ToolTipText = "Zoom out";
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // cmdBluePercentages
            // 
            this.cmdBluePercentages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBluePercentages.Image = ((System.Drawing.Image)(resources.GetObject("cmdBluePercentages.Image")));
            this.cmdBluePercentages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBluePercentages.Name = "cmdBluePercentages";
            this.cmdBluePercentages.Size = new System.Drawing.Size(28, 28);
            this.cmdBluePercentages.Text = "toolStripButton6";
            this.cmdBluePercentages.ToolTipText = "Toggle blue percentages";
            this.cmdBluePercentages.Click += new System.EventHandler(this.cmdBluePercentages_Click);
            // 
            // cmdGreenPercentages
            // 
            this.cmdGreenPercentages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdGreenPercentages.Image = ((System.Drawing.Image)(resources.GetObject("cmdGreenPercentages.Image")));
            this.cmdGreenPercentages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGreenPercentages.Name = "cmdGreenPercentages";
            this.cmdGreenPercentages.Size = new System.Drawing.Size(28, 28);
            this.cmdGreenPercentages.Text = "toolStripButton7";
            this.cmdGreenPercentages.ToolTipText = "Toggle green percentages";
            this.cmdGreenPercentages.Click += new System.EventHandler(this.cmdGreenPercentages_Click);
            // 
            // cmdRedPercentages
            // 
            this.cmdRedPercentages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdRedPercentages.Image = ((System.Drawing.Image)(resources.GetObject("cmdRedPercentages.Image")));
            this.cmdRedPercentages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRedPercentages.Name = "cmdRedPercentages";
            this.cmdRedPercentages.Size = new System.Drawing.Size(28, 28);
            this.cmdRedPercentages.Text = "toolStripButton8";
            this.cmdRedPercentages.ToolTipText = "Toggle red percentages";
            this.cmdRedPercentages.Click += new System.EventHandler(this.cmdRedPercentages_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // cmdProperties
            // 
            this.cmdProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdProperties.Image = ((System.Drawing.Image)(resources.GetObject("cmdProperties.Image")));
            this.cmdProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdProperties.Name = "cmdProperties";
            this.cmdProperties.Size = new System.Drawing.Size(28, 28);
            this.cmdProperties.Text = "toolStripButton1";
            this.cmdProperties.ToolTipText = "Properties";
            this.cmdProperties.Click += new System.EventHandler(this.cmdProperties_Click);
            // 
            // cmdCheck
            // 
            this.cmdCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCheck.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheck.Image")));
            this.cmdCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(28, 28);
            this.cmdCheck.Text = "toolStripButton2";
            this.cmdCheck.ToolTipText = "CheckPredecessors";
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // cmdToolTips
            // 
            this.cmdToolTips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdToolTips.Image = ((System.Drawing.Image)(resources.GetObject("cmdToolTips.Image")));
            this.cmdToolTips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdToolTips.Name = "cmdToolTips";
            this.cmdToolTips.Size = new System.Drawing.Size(28, 28);
            this.cmdToolTips.Text = "toolStripButton9";
            this.cmdToolTips.ToolTipText = "Toggle tooltips";
            this.cmdToolTips.Click += new System.EventHandler(this.cmdToolTips_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(28, 28);
            this.cmdHelp.Text = "toolStripButton10";
            this.cmdHelp.ToolTipText = "Help";
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveGanttCSNCtl1);
            this.panel1.Location = new System.Drawing.Point(19, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 481);
            this.panel1.TabIndex = 3;
            // 
            // fWBSProject
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(872, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fWBSProject";
            this.Text = "fWBSProject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fWBSProject_FormClosed);
            this.Load += new System.EventHandler(this.fWBSProject_Load);
            this.Resize += new System.EventHandler(this.fWBSProject_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
   
    }
}
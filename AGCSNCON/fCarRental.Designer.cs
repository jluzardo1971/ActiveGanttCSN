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
    partial class fCarRental
    {
        public AGCSN.ActiveGanttCSNCtl ActiveGanttCSNCtl1;
        private System.Windows.Forms.ContextMenu mnuRowEdit;
        private System.Windows.Forms.ContextMenu mnuTaskEdit;
        private System.Windows.Forms.MenuItem mnuEditRow;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuDeleteRow;
        private System.Windows.Forms.MenuItem mnuEditTask;
        private System.Windows.Forms.MenuItem mnuConvertToRental;
        private System.Windows.Forms.MenuItem mnuDeleteTask;
        private System.Windows.Forms.MenuItem mnuTaskLine;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuSaveXML;
        private ToolStripMenuItem mnuLoadXML;
        private ToolStripMenuItem mnuPrint;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuClose;
        private ToolStrip toolStrip1;
        private ToolStripButton cmdSaveXML;
        private ToolStripButton cmdLoadXML;
        private ToolStripButton cmdPrint;
        private ToolStripButton cmdZoomIn;
        private ToolStripButton cmdZoomOut;
        private ToolStripButton cmdAddVehicle;
        private ToolStripButton cmdAddBranch;
        private ToolStripButton cmdBack2;
        private ToolStripButton cmdBack1;
        private ToolStripButton cmdBack0;
        private ToolStripButton cmdFwd0;
        private ToolStripButton cmdFwd1;
        private ToolStripButton cmdFwd2;
        private ToolStripButton cmdHelp;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCarRental));
            this.ActiveGanttCSNCtl1 = new AGCSN.ActiveGanttCSNCtl();
            this.mnuRowEdit = new System.Windows.Forms.ContextMenu();
            this.mnuEditRow = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuDeleteRow = new System.Windows.Forms.MenuItem();
            this.mnuTaskEdit = new System.Windows.Forms.ContextMenu();
            this.mnuEditTask = new System.Windows.Forms.MenuItem();
            this.mnuConvertToRental = new System.Windows.Forms.MenuItem();
            this.mnuTaskLine = new System.Windows.Forms.MenuItem();
            this.mnuDeleteTask = new System.Windows.Forms.MenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdSaveXML = new System.Windows.Forms.ToolStripButton();
            this.cmdLoadXML = new System.Windows.Forms.ToolStripButton();
            this.cmdPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdZoomIn = new System.Windows.Forms.ToolStripButton();
            this.cmdZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAddVehicle = new System.Windows.Forms.ToolStripButton();
            this.cmdAddBranch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBack2 = new System.Windows.Forms.ToolStripButton();
            this.cmdBack1 = new System.Windows.Forms.ToolStripButton();
            this.cmdBack0 = new System.Windows.Forms.ToolStripButton();
            this.cmdFwd0 = new System.Windows.Forms.ToolStripButton();
            this.cmdFwd1 = new System.Windows.Forms.ToolStripButton();
            this.cmdFwd2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.drpMode = new System.Windows.Forms.ToolStripComboBox();
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
            this.ActiveGanttCSNCtl1.Location = new System.Drawing.Point(43, 37);
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
            this.ActiveGanttCSNCtl1.Size = new System.Drawing.Size(576, 304);
            this.ActiveGanttCSNCtl1.StyleIndex = "";
            this.ActiveGanttCSNCtl1.TabIndex = 1;
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
            // 
            // mnuRowEdit
            // 
            this.mnuRowEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditRow,
            this.menuItem2,
            this.mnuDeleteRow});
            // 
            // mnuEditRow
            // 
            this.mnuEditRow.Index = 0;
            this.mnuEditRow.Text = "Edit";
            this.mnuEditRow.Click += new System.EventHandler(this.mnuEditRow_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // mnuDeleteRow
            // 
            this.mnuDeleteRow.Index = 2;
            this.mnuDeleteRow.Text = "Delete";
            this.mnuDeleteRow.Click += new System.EventHandler(this.mnuDeleteRow_Click);
            // 
            // mnuTaskEdit
            // 
            this.mnuTaskEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditTask,
            this.mnuConvertToRental,
            this.mnuTaskLine,
            this.mnuDeleteTask});
            // 
            // mnuEditTask
            // 
            this.mnuEditTask.Index = 0;
            this.mnuEditTask.Text = "Edit";
            this.mnuEditTask.Click += new System.EventHandler(this.mnuEditTask_Click);
            // 
            // mnuConvertToRental
            // 
            this.mnuConvertToRental.Index = 1;
            this.mnuConvertToRental.Text = "Convert to Rental";
            this.mnuConvertToRental.Click += new System.EventHandler(this.mnuConvertToRental_Click);
            // 
            // mnuTaskLine
            // 
            this.mnuTaskLine.Index = 2;
            this.mnuTaskLine.Text = "-";
            // 
            // mnuDeleteTask
            // 
            this.mnuDeleteTask.Index = 3;
            this.mnuDeleteTask.Text = "Delete";
            this.mnuDeleteTask.Click += new System.EventHandler(this.mnuDeleteTask_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 33);
            this.menuStrip1.TabIndex = 2;
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
            this.mnuLoadXML.Text = "Load  XML...";
            this.mnuLoadXML.Click += new System.EventHandler(this.mnuLoadXML_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Image")));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(208, 30);
            this.mnuPrint.Text = "Print";
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
            this.cmdAddVehicle,
            this.cmdAddBranch,
            this.toolStripSeparator4,
            this.cmdBack2,
            this.cmdBack1,
            this.cmdBack0,
            this.cmdFwd0,
            this.cmdFwd1,
            this.cmdFwd2,
            this.toolStripSeparator5,
            this.cmdHelp,
            this.toolStripSeparator6,
            this.drpMode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdSaveXML
            // 
            this.cmdSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveXML.Image")));
            this.cmdSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSaveXML.Name = "cmdSaveXML";
            this.cmdSaveXML.Size = new System.Drawing.Size(28, 30);
            this.cmdSaveXML.Text = "Save as XML";
            this.cmdSaveXML.Click += new System.EventHandler(this.cmdSaveXML_Click);
            // 
            // cmdLoadXML
            // 
            this.cmdLoadXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLoadXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoadXML.Image")));
            this.cmdLoadXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoadXML.Name = "cmdLoadXML";
            this.cmdLoadXML.Size = new System.Drawing.Size(28, 30);
            this.cmdLoadXML.Text = "Load XML";
            this.cmdLoadXML.Click += new System.EventHandler(this.cmdLoadXML_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrint.Image")));
            this.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(28, 30);
            this.cmdPrint.Text = "Print";
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomIn.Image")));
            this.cmdZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(28, 30);
            this.cmdZoomIn.Text = "Zoom in";
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomOut.Image")));
            this.cmdZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(28, 30);
            this.cmdZoomOut.Text = "Zoom out";
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // cmdAddVehicle
            // 
            this.cmdAddVehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAddVehicle.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddVehicle.Image")));
            this.cmdAddVehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddVehicle.Name = "cmdAddVehicle";
            this.cmdAddVehicle.Size = new System.Drawing.Size(28, 30);
            this.cmdAddVehicle.Text = "Add vehicle";
            this.cmdAddVehicle.Click += new System.EventHandler(this.cmdAddVehicle_Click);
            // 
            // cmdAddBranch
            // 
            this.cmdAddBranch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAddBranch.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddBranch.Image")));
            this.cmdAddBranch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddBranch.Name = "cmdAddBranch";
            this.cmdAddBranch.Size = new System.Drawing.Size(28, 30);
            this.cmdAddBranch.Text = "Add branch";
            this.cmdAddBranch.Click += new System.EventHandler(this.cmdAddBranch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // cmdBack2
            // 
            this.cmdBack2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBack2.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack2.Image")));
            this.cmdBack2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBack2.Name = "cmdBack2";
            this.cmdBack2.Size = new System.Drawing.Size(28, 30);
            this.cmdBack2.Text = "toolStripButton8";
            this.cmdBack2.Click += new System.EventHandler(this.cmdBack2_Click);
            // 
            // cmdBack1
            // 
            this.cmdBack1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBack1.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack1.Image")));
            this.cmdBack1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBack1.Name = "cmdBack1";
            this.cmdBack1.Size = new System.Drawing.Size(28, 30);
            this.cmdBack1.Text = "toolStripButton9";
            this.cmdBack1.Click += new System.EventHandler(this.cmdBack1_Click);
            // 
            // cmdBack0
            // 
            this.cmdBack0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBack0.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack0.Image")));
            this.cmdBack0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBack0.Name = "cmdBack0";
            this.cmdBack0.Size = new System.Drawing.Size(28, 30);
            this.cmdBack0.Text = "toolStripButton10";
            this.cmdBack0.Click += new System.EventHandler(this.cmdBack0_Click);
            // 
            // cmdFwd0
            // 
            this.cmdFwd0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdFwd0.Image = ((System.Drawing.Image)(resources.GetObject("cmdFwd0.Image")));
            this.cmdFwd0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFwd0.Name = "cmdFwd0";
            this.cmdFwd0.Size = new System.Drawing.Size(28, 30);
            this.cmdFwd0.Text = "toolStripButton11";
            this.cmdFwd0.Click += new System.EventHandler(this.cmdFwd0_Click);
            // 
            // cmdFwd1
            // 
            this.cmdFwd1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdFwd1.Image = ((System.Drawing.Image)(resources.GetObject("cmdFwd1.Image")));
            this.cmdFwd1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFwd1.Name = "cmdFwd1";
            this.cmdFwd1.Size = new System.Drawing.Size(28, 30);
            this.cmdFwd1.Text = "toolStripButton12";
            this.cmdFwd1.Click += new System.EventHandler(this.cmdFwd1_Click);
            // 
            // cmdFwd2
            // 
            this.cmdFwd2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdFwd2.Image = ((System.Drawing.Image)(resources.GetObject("cmdFwd2.Image")));
            this.cmdFwd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFwd2.Name = "cmdFwd2";
            this.cmdFwd2.Size = new System.Drawing.Size(28, 30);
            this.cmdFwd2.Text = "toolStripButton13";
            this.cmdFwd2.Click += new System.EventHandler(this.cmdFwd2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // cmdHelp
            // 
            this.cmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(28, 30);
            this.cmdHelp.Text = "Help";
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // drpMode
            // 
            this.drpMode.Name = "drpMode";
            this.drpMode.Size = new System.Drawing.Size(320, 33);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveGanttCSNCtl1);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 425);
            this.panel1.TabIndex = 4;
            // 
            // fCarRental
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(856, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fCarRental";
            this.Text = "fCarRental";
            this.Load += new System.EventHandler(this.fCarRental_Load);
            this.Resize += new System.EventHandler(this.fCarRental_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripComboBox drpMode;
        private Panel panel1;

    }
}
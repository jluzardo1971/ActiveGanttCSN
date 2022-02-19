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
    partial class fLoadXML
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoadXML));
            this.ActiveGanttCSNCtl1 = new AGCSN.ActiveGanttCSNCtl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdLoadXML = new System.Windows.Forms.ToolStripButton();
            this.cmdSaveXML = new System.Windows.Forms.ToolStripButton();
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
            this.ActiveGanttCSNCtl1.Location = new System.Drawing.Point(34, 19);
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
            this.ActiveGanttCSNCtl1.Size = new System.Drawing.Size(520, 273);
            this.ActiveGanttCSNCtl1.StyleIndex = "";
            this.ActiveGanttCSNCtl1.TabIndex = 0;
            this.ActiveGanttCSNCtl1.TierAppearanceScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TierFormatScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TimeBlockBehaviour = AGCSN.E_TIMEBLOCKBEHAVIOUR.TBB_ROWEXTENTS;
            this.ActiveGanttCSNCtl1.TimeLineScrollBarScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TreeviewColumnIndex = 0;
            this.ActiveGanttCSNCtl1.CustomTierDraw += new AGCSN.ActiveGanttCSNCtl.CustomTierDrawEventHandler(this.ActiveGanttCSNCtl1_CustomTierDraw);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadXML,
            this.mnuSaveXML,
            this.toolStripSeparator1,
            this.mnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuLoadXML
            // 
            this.mnuLoadXML.Name = "mnuLoadXML";
            this.mnuLoadXML.Size = new System.Drawing.Size(165, 22);
            this.mnuLoadXML.Text = "Load from XML...";
            this.mnuLoadXML.Click += new System.EventHandler(this.mnuLoadXML_Click);
            // 
            // mnuSaveXML
            // 
            this.mnuSaveXML.Name = "mnuSaveXML";
            this.mnuSaveXML.Size = new System.Drawing.Size(165, 22);
            this.mnuSaveXML.Text = "Save as XML...";
            this.mnuSaveXML.Click += new System.EventHandler(this.mnuSaveXML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(165, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdLoadXML,
            this.cmdSaveXML});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdLoadXML
            // 
            this.cmdLoadXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLoadXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdLoadXML.Image")));
            this.cmdLoadXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLoadXML.Name = "cmdLoadXML";
            this.cmdLoadXML.Size = new System.Drawing.Size(23, 22);
            this.cmdLoadXML.ToolTipText = "Load XML";
            this.cmdLoadXML.Click += new System.EventHandler(this.cmdLoadXML_Click);
            // 
            // cmdSaveXML
            // 
            this.cmdSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveXML.Image")));
            this.cmdSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSaveXML.Name = "cmdSaveXML";
            this.cmdSaveXML.Size = new System.Drawing.Size(23, 22);
            this.cmdSaveXML.Text = "Save as XML";
            this.cmdSaveXML.ToolTipText = "Load XML";
            this.cmdSaveXML.Click += new System.EventHandler(this.cmdSaveXML_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveGanttCSNCtl1);
            this.panel1.Location = new System.Drawing.Point(93, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 310);
            this.panel1.TabIndex = 3;
            // 
            // fLoadXML
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(852, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fLoadXML";
            this.Text = "ActiveGanttCSN - Load From XML / Save As XML";
            this.Load += new System.EventHandler(this.fLoadXML_Load);
            this.Resize += new System.EventHandler(this.fLoadXML_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private AGCSN.ActiveGanttCSNCtl ActiveGanttCSNCtl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuLoadXML;
        private ToolStripMenuItem mnuSaveXML;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuClose;
        private ToolStrip toolStrip1;
        private ToolStripButton cmdLoadXML;
        private ToolStripButton cmdSaveXML;
        private Panel panel1;
        
    }
}
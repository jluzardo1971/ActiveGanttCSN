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
    partial class fTemplates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTemplates));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActiveGanttCSNCtl1 = new AGCSN.ActiveGanttCSNCtl();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboControlTemplates = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboObjectTemplates = new System.Windows.Forms.ToolStripComboBox();
            this.cmdCopy = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveGanttCSNCtl1);
            this.panel1.Location = new System.Drawing.Point(142, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 291);
            this.panel1.TabIndex = 5;
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
            this.ActiveGanttCSNCtl1.Location = new System.Drawing.Point(27, 25);
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
            this.ActiveGanttCSNCtl1.Size = new System.Drawing.Size(360, 208);
            this.ActiveGanttCSNCtl1.StyleIndex = "";
            this.ActiveGanttCSNCtl1.TabIndex = 1;
            this.ActiveGanttCSNCtl1.TierAppearanceScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TierFormatScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TimeBlockBehaviour = AGCSN.E_TIMEBLOCKBEHAVIOUR.TBB_ROWEXTENTS;
            this.ActiveGanttCSNCtl1.TimeLineScrollBarScope = AGCSN.E_OBJECTSCOPE.OS_CONTROL;
            this.ActiveGanttCSNCtl1.TreeviewColumnIndex = 0;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.cboControlTemplates,
            this.ToolStripLabel2,
            this.cboObjectTemplates,
            this.cmdCopy});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(797, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(103, 22);
            this.ToolStripLabel1.Text = "Control Template:";
            // 
            // cboControlTemplates
            // 
            this.cboControlTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboControlTemplates.Name = "cboControlTemplates";
            this.cboControlTemplates.Size = new System.Drawing.Size(200, 25);
            this.cboControlTemplates.SelectedIndexChanged += new System.EventHandler(this.cboControlTemplates_SelectedIndexChanged);
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(98, 22);
            this.ToolStripLabel2.Text = "Object Template:";
            // 
            // cboObjectTemplates
            // 
            this.cboObjectTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjectTemplates.Name = "cboObjectTemplates";
            this.cboObjectTemplates.Size = new System.Drawing.Size(200, 25);
            this.cboObjectTemplates.SelectedIndexChanged += new System.EventHandler(this.cboObjectTemplates_SelectedIndexChanged);
            // 
            // cmdCopy
            // 
            this.cmdCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCopy.Image = ((System.Drawing.Image)(resources.GetObject("cmdCopy.Image")));
            this.cmdCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(23, 22);
            this.cmdCopy.Text = "ToolStripButton1";
            this.cmdCopy.ToolTipText = "Copy to Clipboard";
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // fTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "fTemplates";
            this.Text = "Available Templates";
            this.Load += new System.EventHandler(this.fTemplates_Load);
            this.Resize += new System.EventHandler(this.fTemplates_Resize);
            this.panel1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public AGCSN.ActiveGanttCSNCtl ActiveGanttCSNCtl1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripComboBox cboControlTemplates;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel2;
        internal System.Windows.Forms.ToolStripComboBox cboObjectTemplates;
        internal System.Windows.Forms.ToolStripButton cmdCopy;
    }
}
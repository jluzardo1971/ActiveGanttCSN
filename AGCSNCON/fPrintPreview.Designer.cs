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
    partial class fPrintPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrintPreview));
            this.cmdNextPage = new System.Windows.Forms.ToolStripButton();
            this.m_HScroll = new System.Windows.Forms.HScrollBar();
            this.lblPage = new System.Windows.Forms.ToolStripLabel();
            this.cmdPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.cmdZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdLeft = new System.Windows.Forms.ToolStripButton();
            this.cmdUp = new System.Windows.Forms.ToolStripButton();
            this.cmdDown = new System.Windows.Forms.ToolStripButton();
            this.cmdRight = new System.Windows.Forms.ToolStripButton();
            this.cmdZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cmdScrollBarsSeparator = new System.Windows.Forms.Button();
            this.m_VScroll = new System.Windows.Forms.VScrollBar();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNextPage
            // 
            this.cmdNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNextPage.Image = ((System.Drawing.Image)(resources.GetObject("cmdNextPage.Image")));
            this.cmdNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNextPage.Name = "cmdNextPage";
            this.cmdNextPage.Size = new System.Drawing.Size(23, 22);
            this.cmdNextPage.Text = "ToolStripButton2";
            this.cmdNextPage.Click += new System.EventHandler(this.cmdNextPage_Click);
            // 
            // m_HScroll
            // 
            this.m_HScroll.Location = new System.Drawing.Point(-6, 480);
            this.m_HScroll.Name = "m_HScroll";
            this.m_HScroll.Size = new System.Drawing.Size(648, 16);
            this.m_HScroll.TabIndex = 5;
            this.m_HScroll.ValueChanged += new System.EventHandler(this.m_HScroll_ValueChanged);
            // 
            // lblPage
            // 
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(89, 22);
            this.lblPage.Text = "Page 999 of 999";
            // 
            // cmdPreviousPage
            // 
            this.cmdPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("cmdPreviousPage.Image")));
            this.cmdPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPreviousPage.Name = "cmdPreviousPage";
            this.cmdPreviousPage.Size = new System.Drawing.Size(23, 22);
            this.cmdPreviousPage.Text = "ToolStripButton1";
            this.cmdPreviousPage.Click += new System.EventHandler(this.cmdPreviousPage_Click);
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomIn.Image")));
            this.cmdZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(23, 22);
            this.cmdZoomIn.Text = "ToolStripButton1";
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdLeft,
            this.cmdUp,
            this.cmdDown,
            this.cmdRight,
            this.ToolStripSeparator2,
            this.cmdPreviousPage,
            this.cmdNextPage,
            this.lblPage,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.cmdZoomIn,
            this.cmdZoomOut});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(652, 25);
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // cmdLeft
            // 
            this.cmdLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLeft.Image = ((System.Drawing.Image)(resources.GetObject("cmdLeft.Image")));
            this.cmdLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLeft.Name = "cmdLeft";
            this.cmdLeft.Size = new System.Drawing.Size(23, 22);
            this.cmdLeft.Text = "ToolStripButton2";
            this.cmdLeft.Click += new System.EventHandler(this.cmdLeft_Click);
            // 
            // cmdUp
            // 
            this.cmdUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUp.Image = ((System.Drawing.Image)(resources.GetObject("cmdUp.Image")));
            this.cmdUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(23, 22);
            this.cmdUp.Text = "ToolStripButton4";
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdDown.Image = ((System.Drawing.Image)(resources.GetObject("cmdDown.Image")));
            this.cmdDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(23, 22);
            this.cmdDown.Text = "ToolStripButton3";
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdRight
            // 
            this.cmdRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdRight.Image = ((System.Drawing.Image)(resources.GetObject("cmdRight.Image")));
            this.cmdRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRight.Name = "cmdRight";
            this.cmdRight.Size = new System.Drawing.Size(23, 22);
            this.cmdRight.Text = "ToolStripButton1";
            this.cmdRight.Click += new System.EventHandler(this.cmdRight_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("cmdZoomOut.Image")));
            this.cmdZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(23, 22);
            this.cmdZoomOut.Text = "ToolStripButton2";
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // cmdScrollBarsSeparator
            // 
            this.cmdScrollBarsSeparator.BackColor = System.Drawing.SystemColors.Menu;
            this.cmdScrollBarsSeparator.Location = new System.Drawing.Point(642, 480);
            this.cmdScrollBarsSeparator.Name = "cmdScrollBarsSeparator";
            this.cmdScrollBarsSeparator.Size = new System.Drawing.Size(16, 16);
            this.cmdScrollBarsSeparator.TabIndex = 7;
            this.cmdScrollBarsSeparator.UseVisualStyleBackColor = false;
            // 
            // m_VScroll
            // 
            this.m_VScroll.Location = new System.Drawing.Point(642, 24);
            this.m_VScroll.Name = "m_VScroll";
            this.m_VScroll.Size = new System.Drawing.Size(16, 456);
            this.m_VScroll.TabIndex = 6;
            this.m_VScroll.ValueChanged += new System.EventHandler(this.m_VScroll_ValueChanged);
            // 
            // fPrintPreview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 521);
            this.Controls.Add(this.m_HScroll);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.cmdScrollBarsSeparator);
            this.Controls.Add(this.m_VScroll);
            this.DoubleBuffered = true;
            this.Name = "fPrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Preview";
            this.Load += new System.EventHandler(this.fPrintPreview_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fPrintPreview_Paint);
            this.Resize += new System.EventHandler(this.fPrintPreview_Resize);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal ToolStripButton cmdNextPage;
        internal HScrollBar m_HScroll;
        internal ToolStripLabel lblPage;
        internal ToolStripButton cmdPreviousPage;
        internal ToolStripButton cmdZoomIn;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStrip ToolStrip1;
        internal ToolStripButton cmdLeft;
        internal ToolStripButton cmdUp;
        internal ToolStripButton cmdDown;
        internal ToolStripButton cmdRight;
        internal ToolStripButton cmdZoomOut;
        internal Button cmdScrollBarsSeparator;
        internal VScrollBar m_VScroll;
    }
}
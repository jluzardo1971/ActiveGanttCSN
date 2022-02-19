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
    partial class fPrintDialog
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
            this.cmdPreview = new System.Windows.Forms.Button();
            this.numEDYear = new System.Windows.Forms.NumericUpDown();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.numSDSecond = new System.Windows.Forms.NumericUpDown();
            this.numSDMinute = new System.Windows.Forms.NumericUpDown();
            this.chkKeepRowsTogether = new System.Windows.Forms.CheckBox();
            this.numSDHour = new System.Windows.Forms.NumericUpDown();
            this.numSDDay = new System.Windows.Forms.NumericUpDown();
            this.numEDSecond = new System.Windows.Forms.NumericUpDown();
            this.chkKeepColumnsTogether = new System.Windows.Forms.CheckBox();
            this.numEDMinute = new System.Windows.Forms.NumericUpDown();
            this.optFrom = new System.Windows.Forms.RadioButton();
            this.numEDHour = new System.Windows.Forms.NumericUpDown();
            this.numEDDay = new System.Windows.Forms.NumericUpDown();
            this.numEDMonth = new System.Windows.Forms.NumericUpDown();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.numSDMonth = new System.Windows.Forms.NumericUpDown();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.numSDYear = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.numMarginLeft = new System.Windows.Forms.NumericUpDown();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.numEndRow = new System.Windows.Forms.NumericUpDown();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.numStartRow = new System.Windows.Forms.NumericUpDown();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.numMarginBottom = new System.Windows.Forms.NumericUpDown();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.numMarginRight = new System.Windows.Forms.NumericUpDown();
            this.numMarginTop = new System.Windows.Forms.NumericUpDown();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.lblPrinterNameCaption = new System.Windows.Forms.Label();
            this.cboPrinters = new System.Windows.Forms.ComboBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblDPIY = new System.Windows.Forms.Label();
            this.lblPrecent = new System.Windows.Forms.Label();
            this.lblDPIX = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.numDPIY = new System.Windows.Forms.NumericUpDown();
            this.Label17 = new System.Windows.Forms.Label();
            this.numDPIX = new System.Windows.Forms.NumericUpDown();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.chkShowAllColumns = new System.Windows.Forms.CheckBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.chkKeepTimeIntervalsTogether = new System.Windows.Forms.CheckBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.chkColumnsInEveryPage = new System.Windows.Forms.CheckBox();
            this.lblFactor = new System.Windows.Forms.Label();
            this.chkHeadingsInEveryPage = new System.Windows.Forms.CheckBox();
            this.numFactor = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndPage = new System.Windows.Forms.TextBox();
            this.txtStartPage = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEDYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDMonth)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSDYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).BeginInit();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBottom)).BeginInit();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginTop)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPIY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPIX)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPreview
            // 
            this.cmdPreview.Location = new System.Drawing.Point(338, 494);
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Size = new System.Drawing.Size(104, 24);
            this.cmdPreview.TabIndex = 78;
            this.cmdPreview.Text = "Preview...";
            this.cmdPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // numEDYear
            // 
            this.numEDYear.Location = new System.Drawing.Point(78, 62);
            this.numEDYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numEDYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEDYear.Name = "numEDYear";
            this.numEDYear.Size = new System.Drawing.Size(50, 20);
            this.numEDYear.TabIndex = 86;
            this.numEDYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(129, 62);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(13, 16);
            this.Label13.TabIndex = 82;
            this.Label13.Text = "/";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(177, 62);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(13, 16);
            this.Label14.TabIndex = 84;
            this.Label14.Text = "/";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(280, 62);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(12, 16);
            this.Label15.TabIndex = 83;
            this.Label15.Text = ":";
            // 
            // cboInterval
            // 
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Location = new System.Drawing.Point(87, 140);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(225, 21);
            this.cboInterval.TabIndex = 64;
            this.cboInterval.SelectedIndexChanged += new System.EventHandler(this.cboInterval_SelectedIndexChanged);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(328, 62);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(12, 16);
            this.Label16.TabIndex = 85;
            this.Label16.Text = ":";
            // 
            // numSDSecond
            // 
            this.numSDSecond.Location = new System.Drawing.Point(344, 32);
            this.numSDSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSDSecond.Name = "numSDSecond";
            this.numSDSecond.Size = new System.Drawing.Size(35, 20);
            this.numSDSecond.TabIndex = 81;
            this.numSDSecond.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // numSDMinute
            // 
            this.numSDMinute.Location = new System.Drawing.Point(290, 32);
            this.numSDMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSDMinute.Name = "numSDMinute";
            this.numSDMinute.Size = new System.Drawing.Size(35, 20);
            this.numSDMinute.TabIndex = 80;
            this.numSDMinute.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // chkKeepRowsTogether
            // 
            this.chkKeepRowsTogether.AutoSize = true;
            this.chkKeepRowsTogether.Location = new System.Drawing.Point(17, 218);
            this.chkKeepRowsTogether.Name = "chkKeepRowsTogether";
            this.chkKeepRowsTogether.Size = new System.Drawing.Size(118, 17);
            this.chkKeepRowsTogether.TabIndex = 61;
            this.chkKeepRowsTogether.Text = "Keep rows together";
            this.chkKeepRowsTogether.UseVisualStyleBackColor = true;
            this.chkKeepRowsTogether.CheckedChanged += new System.EventHandler(this.chkKeepRowsTogether_CheckedChanged);
            // 
            // numSDHour
            // 
            this.numSDHour.Location = new System.Drawing.Point(241, 32);
            this.numSDHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numSDHour.Name = "numSDHour";
            this.numSDHour.Size = new System.Drawing.Size(35, 20);
            this.numSDHour.TabIndex = 79;
            this.numSDHour.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // numSDDay
            // 
            this.numSDDay.Location = new System.Drawing.Point(193, 32);
            this.numSDDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSDDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSDDay.Name = "numSDDay";
            this.numSDDay.Size = new System.Drawing.Size(35, 20);
            this.numSDDay.TabIndex = 78;
            this.numSDDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // numEDSecond
            // 
            this.numEDSecond.Location = new System.Drawing.Point(344, 62);
            this.numEDSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numEDSecond.Name = "numEDSecond";
            this.numEDSecond.Size = new System.Drawing.Size(35, 20);
            this.numEDSecond.TabIndex = 91;
            this.numEDSecond.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // chkKeepColumnsTogether
            // 
            this.chkKeepColumnsTogether.AutoSize = true;
            this.chkKeepColumnsTogether.Location = new System.Drawing.Point(17, 91);
            this.chkKeepColumnsTogether.Name = "chkKeepColumnsTogether";
            this.chkKeepColumnsTogether.Size = new System.Drawing.Size(135, 17);
            this.chkKeepColumnsTogether.TabIndex = 62;
            this.chkKeepColumnsTogether.Text = "Keep columns together";
            this.chkKeepColumnsTogether.UseVisualStyleBackColor = true;
            this.chkKeepColumnsTogether.CheckedChanged += new System.EventHandler(this.chkKeepColumnsTogether_CheckedChanged);
            // 
            // numEDMinute
            // 
            this.numEDMinute.Location = new System.Drawing.Point(290, 62);
            this.numEDMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numEDMinute.Name = "numEDMinute";
            this.numEDMinute.Size = new System.Drawing.Size(35, 20);
            this.numEDMinute.TabIndex = 90;
            this.numEDMinute.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // optFrom
            // 
            this.optFrom.AutoSize = true;
            this.optFrom.Location = new System.Drawing.Point(6, 34);
            this.optFrom.Name = "optFrom";
            this.optFrom.Size = new System.Drawing.Size(51, 17);
            this.optFrom.TabIndex = 1;
            this.optFrom.TabStop = true;
            this.optFrom.Text = "From:";
            this.optFrom.UseVisualStyleBackColor = true;
            // 
            // numEDHour
            // 
            this.numEDHour.Location = new System.Drawing.Point(241, 62);
            this.numEDHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEDHour.Name = "numEDHour";
            this.numEDHour.Size = new System.Drawing.Size(35, 20);
            this.numEDHour.TabIndex = 89;
            this.numEDHour.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // numEDDay
            // 
            this.numEDDay.Location = new System.Drawing.Point(193, 62);
            this.numEDDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numEDDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEDDay.Name = "numEDDay";
            this.numEDDay.Size = new System.Drawing.Size(35, 20);
            this.numEDDay.TabIndex = 88;
            this.numEDDay.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // numEDMonth
            // 
            this.numEDMonth.Location = new System.Drawing.Point(140, 62);
            this.numEDMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numEDMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEDMonth.Name = "numEDMonth";
            this.numEDMonth.Size = new System.Drawing.Size(35, 20);
            this.numEDMonth.TabIndex = 87;
            this.numEDMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Location = new System.Drawing.Point(6, 4);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(36, 17);
            this.optAll.TabIndex = 0;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            // 
            // numSDMonth
            // 
            this.numSDMonth.Location = new System.Drawing.Point(140, 32);
            this.numSDMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSDMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSDMonth.Name = "numSDMonth";
            this.numSDMonth.Size = new System.Drawing.Size(35, 20);
            this.numSDMonth.TabIndex = 77;
            this.numSDMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.numEDSecond);
            this.Panel2.Controls.Add(this.numEDMinute);
            this.Panel2.Controls.Add(this.numEDHour);
            this.Panel2.Controls.Add(this.numEDDay);
            this.Panel2.Controls.Add(this.numEDMonth);
            this.Panel2.Controls.Add(this.numEDYear);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.numSDSecond);
            this.Panel2.Controls.Add(this.numSDMinute);
            this.Panel2.Controls.Add(this.numSDHour);
            this.Panel2.Controls.Add(this.numSDDay);
            this.Panel2.Controls.Add(this.numSDMonth);
            this.Panel2.Controls.Add(this.numSDYear);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Location = new System.Drawing.Point(13, 137);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(398, 95);
            this.Panel2.TabIndex = 82;
            // 
            // numSDYear
            // 
            this.numSDYear.Location = new System.Drawing.Point(78, 32);
            this.numSDYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSDYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSDYear.Name = "numSDYear";
            this.numSDYear.Size = new System.Drawing.Size(50, 20);
            this.numSDYear.TabIndex = 76;
            this.numSDYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Start Date:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "End Date:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(75, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "YYYY";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(137, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 13);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "MM";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(190, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(23, 13);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "DD";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(238, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(19, 13);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "hh";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(287, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(23, 13);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "mm";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(341, 16);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(17, 13);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "ss";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(129, 32);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(13, 16);
            this.Label9.TabIndex = 41;
            this.Label9.Text = "/";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(177, 32);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(13, 16);
            this.Label10.TabIndex = 43;
            this.Label10.Text = "/";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(280, 32);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(12, 16);
            this.Label11.TabIndex = 42;
            this.Label11.Text = ":";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(328, 32);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(12, 16);
            this.Label12.TabIndex = 44;
            this.Label12.Text = ":";
            // 
            // numMarginLeft
            // 
            this.numMarginLeft.Location = new System.Drawing.Point(122, 14);
            this.numMarginLeft.Name = "numMarginLeft";
            this.numMarginLeft.Size = new System.Drawing.Size(56, 20);
            this.numMarginLeft.TabIndex = 12;
            this.numMarginLeft.ValueChanged += new System.EventHandler(this.numMarginLeft_ValueChanged);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(184, 91);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(12, 13);
            this.Label30.TabIndex = 11;
            this.Label30.Text = "\"";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(184, 66);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(12, 13);
            this.Label29.TabIndex = 10;
            this.Label29.Text = "\"";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(184, 39);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(12, 13);
            this.Label28.TabIndex = 9;
            this.Label28.Text = "\"";
            // 
            // numEndRow
            // 
            this.numEndRow.Location = new System.Drawing.Point(121, 62);
            this.numEndRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEndRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndRow.Name = "numEndRow";
            this.numEndRow.Size = new System.Drawing.Size(55, 20);
            this.numEndRow.TabIndex = 3;
            this.numEndRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndRow.ValueChanged += new System.EventHandler(this.numEndRow_ValueChanged);
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.numEndRow);
            this.Panel6.Controls.Add(this.numStartRow);
            this.Panel6.Controls.Add(this.Label32);
            this.Panel6.Controls.Add(this.Label31);
            this.Panel6.Location = new System.Drawing.Point(418, 137);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(223, 95);
            this.Panel6.TabIndex = 86;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(121, 33);
            this.numStartRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.Size = new System.Drawing.Size(56, 20);
            this.numStartRow.TabIndex = 2;
            this.numStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartRow.ValueChanged += new System.EventHandler(this.numStartRow_ValueChanged);
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(12, 62);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(54, 13);
            this.Label32.TabIndex = 1;
            this.Label32.Text = "End Row:";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(12, 33);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(57, 13);
            this.Label31.TabIndex = 0;
            this.Label31.Text = "Start Row:";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(184, 14);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(12, 13);
            this.Label27.TabIndex = 8;
            this.Label27.Text = "\"";
            // 
            // numMarginBottom
            // 
            this.numMarginBottom.Location = new System.Drawing.Point(122, 92);
            this.numMarginBottom.Name = "numMarginBottom";
            this.numMarginBottom.Size = new System.Drawing.Size(56, 20);
            this.numMarginBottom.TabIndex = 7;
            this.numMarginBottom.ValueChanged += new System.EventHandler(this.numMarginBottom_ValueChanged);
            // 
            // Panel5
            // 
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.numMarginLeft);
            this.Panel5.Controls.Add(this.Label30);
            this.Panel5.Controls.Add(this.Label29);
            this.Panel5.Controls.Add(this.Label28);
            this.Panel5.Controls.Add(this.Label27);
            this.Panel5.Controls.Add(this.numMarginBottom);
            this.Panel5.Controls.Add(this.numMarginRight);
            this.Panel5.Controls.Add(this.numMarginTop);
            this.Panel5.Controls.Add(this.Label26);
            this.Panel5.Controls.Add(this.Label25);
            this.Panel5.Controls.Add(this.Label24);
            this.Panel5.Controls.Add(this.Label23);
            this.Panel5.Location = new System.Drawing.Point(417, 238);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(224, 123);
            this.Panel5.TabIndex = 85;
            // 
            // numMarginRight
            // 
            this.numMarginRight.Location = new System.Drawing.Point(122, 66);
            this.numMarginRight.Name = "numMarginRight";
            this.numMarginRight.Size = new System.Drawing.Size(56, 20);
            this.numMarginRight.TabIndex = 6;
            this.numMarginRight.ValueChanged += new System.EventHandler(this.numMarginRight_ValueChanged);
            // 
            // numMarginTop
            // 
            this.numMarginTop.Location = new System.Drawing.Point(122, 40);
            this.numMarginTop.Name = "numMarginTop";
            this.numMarginTop.Size = new System.Drawing.Size(56, 20);
            this.numMarginTop.TabIndex = 5;
            this.numMarginTop.ValueChanged += new System.EventHandler(this.numMarginTop_ValueChanged);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(13, 91);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(78, 13);
            this.Label26.TabIndex = 3;
            this.Label26.Text = "Margin Bottom:";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(13, 64);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(70, 13);
            this.Label25.TabIndex = 2;
            this.Label25.Text = "Margin Right:";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(13, 39);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(64, 13);
            this.Label24.TabIndex = 1;
            this.Label24.Text = "Margin Top:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(13, 16);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(63, 13);
            this.Label23.TabIndex = 0;
            this.Label23.Text = "Margin Left:";
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.cboOrientation);
            this.Panel4.Controls.Add(this.lblPrinterNameCaption);
            this.Panel4.Controls.Add(this.cboPrinters);
            this.Panel4.Controls.Add(this.lblScale);
            this.Panel4.Controls.Add(this.lblDPIY);
            this.Panel4.Controls.Add(this.lblPrecent);
            this.Panel4.Controls.Add(this.lblDPIX);
            this.Panel4.Controls.Add(this.numScale);
            this.Panel4.Controls.Add(this.numDPIY);
            this.Panel4.Controls.Add(this.Label17);
            this.Panel4.Controls.Add(this.numDPIX);
            this.Panel4.Controls.Add(this.cboResolution);
            this.Panel4.Controls.Add(this.Label18);
            this.Panel4.Location = new System.Drawing.Point(13, 7);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(629, 124);
            this.Panel4.TabIndex = 84;
            // 
            // cboOrientation
            // 
            this.cboOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrientation.Location = new System.Drawing.Point(87, 43);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(225, 21);
            this.cboOrientation.TabIndex = 22;
            this.cboOrientation.SelectedIndexChanged += new System.EventHandler(this.cboOrientation_SelectedIndexChanged);
            // 
            // lblPrinterNameCaption
            // 
            this.lblPrinterNameCaption.Location = new System.Drawing.Point(12, 16);
            this.lblPrinterNameCaption.Name = "lblPrinterNameCaption";
            this.lblPrinterNameCaption.Size = new System.Drawing.Size(56, 16);
            this.lblPrinterNameCaption.TabIndex = 12;
            this.lblPrinterNameCaption.Text = "Name:";
            // 
            // cboPrinters
            // 
            this.cboPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinters.Location = new System.Drawing.Point(87, 16);
            this.cboPrinters.Name = "cboPrinters";
            this.cboPrinters.Size = new System.Drawing.Size(510, 21);
            this.cboPrinters.TabIndex = 13;
            this.cboPrinters.SelectedIndexChanged += new System.EventHandler(this.cboPrinters_SelectedIndexChanged);
            // 
            // lblScale
            // 
            this.lblScale.Location = new System.Drawing.Point(12, 71);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(40, 16);
            this.lblScale.TabIndex = 14;
            this.lblScale.Text = "Scale:";
            // 
            // lblDPIY
            // 
            this.lblDPIY.AutoSize = true;
            this.lblDPIY.Location = new System.Drawing.Point(469, 97);
            this.lblDPIY.Name = "lblDPIY";
            this.lblDPIY.Size = new System.Drawing.Size(66, 13);
            this.lblDPIY.TabIndex = 60;
            this.lblDPIY.Text = "Vertical DPI:";
            this.lblDPIY.Visible = false;
            // 
            // lblPrecent
            // 
            this.lblPrecent.Location = new System.Drawing.Point(151, 71);
            this.lblPrecent.Name = "lblPrecent";
            this.lblPrecent.Size = new System.Drawing.Size(24, 16);
            this.lblPrecent.TabIndex = 15;
            this.lblPrecent.Text = "%";
            // 
            // lblDPIX
            // 
            this.lblDPIX.AutoSize = true;
            this.lblDPIX.Location = new System.Drawing.Point(319, 97);
            this.lblDPIX.Name = "lblDPIX";
            this.lblDPIX.Size = new System.Drawing.Size(78, 13);
            this.lblDPIX.TabIndex = 59;
            this.lblDPIX.Text = "Horizontal DPI:";
            this.lblDPIX.Visible = false;
            // 
            // numScale
            // 
            this.numScale.Location = new System.Drawing.Point(87, 71);
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(60, 20);
            this.numScale.TabIndex = 16;
            this.numScale.ValueChanged += new System.EventHandler(this.numScale_ValueChanged);
            // 
            // numDPIY
            // 
            this.numDPIY.Location = new System.Drawing.Point(538, 95);
            this.numDPIY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numDPIY.Name = "numDPIY";
            this.numDPIY.Size = new System.Drawing.Size(60, 20);
            this.numDPIY.TabIndex = 58;
            this.numDPIY.Visible = false;
            this.numDPIY.ValueChanged += new System.EventHandler(this.numDPIY_ValueChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(12, 43);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(61, 13);
            this.Label17.TabIndex = 23;
            this.Label17.Text = "Orientation:";
            // 
            // numDPIX
            // 
            this.numDPIX.Location = new System.Drawing.Point(403, 96);
            this.numDPIX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numDPIX.Name = "numDPIX";
            this.numDPIX.Size = new System.Drawing.Size(60, 20);
            this.numDPIX.TabIndex = 57;
            this.numDPIX.Visible = false;
            this.numDPIX.ValueChanged += new System.EventHandler(this.numDPIX_ValueChanged);
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(87, 96);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(225, 21);
            this.cboResolution.TabIndex = 55;
            this.cboResolution.SelectedIndexChanged += new System.EventHandler(this.cboResolution_SelectedIndexChanged);
            // 
            // Label18
            // 
            this.Label18.Location = new System.Drawing.Point(12, 96);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(61, 21);
            this.Label18.TabIndex = 56;
            this.Label18.Text = "Resolution:";
            // 
            // chkShowAllColumns
            // 
            this.chkShowAllColumns.AutoSize = true;
            this.chkShowAllColumns.Location = new System.Drawing.Point(17, 12);
            this.chkShowAllColumns.Name = "chkShowAllColumns";
            this.chkShowAllColumns.Size = new System.Drawing.Size(108, 17);
            this.chkShowAllColumns.TabIndex = 72;
            this.chkShowAllColumns.Text = "Show all columns";
            this.chkShowAllColumns.UseVisualStyleBackColor = true;
            this.chkShowAllColumns.CheckedChanged += new System.EventHandler(this.chkShowAllColumns_CheckedChanged);
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.chkShowAllColumns);
            this.Panel3.Controls.Add(this.cboInterval);
            this.Panel3.Controls.Add(this.chkKeepRowsTogether);
            this.Panel3.Controls.Add(this.chkKeepColumnsTogether);
            this.Panel3.Controls.Add(this.numColumns);
            this.Panel3.Controls.Add(this.chkKeepTimeIntervalsTogether);
            this.Panel3.Controls.Add(this.Label21);
            this.Panel3.Controls.Add(this.lblInterval);
            this.Panel3.Controls.Add(this.chkColumnsInEveryPage);
            this.Panel3.Controls.Add(this.lblFactor);
            this.Panel3.Controls.Add(this.chkHeadingsInEveryPage);
            this.Panel3.Controls.Add(this.numFactor);
            this.Panel3.Location = new System.Drawing.Point(13, 238);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(398, 250);
            this.Panel3.TabIndex = 83;
            // 
            // numColumns
            // 
            this.numColumns.Location = new System.Drawing.Point(122, 65);
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(60, 20);
            this.numColumns.TabIndex = 71;
            this.numColumns.ValueChanged += new System.EventHandler(this.numColumns_ValueChanged);
            // 
            // chkKeepTimeIntervalsTogether
            // 
            this.chkKeepTimeIntervalsTogether.AutoSize = true;
            this.chkKeepTimeIntervalsTogether.Location = new System.Drawing.Point(17, 114);
            this.chkKeepTimeIntervalsTogether.Name = "chkKeepTimeIntervalsTogether";
            this.chkKeepTimeIntervalsTogether.Size = new System.Drawing.Size(160, 17);
            this.chkKeepTimeIntervalsTogether.TabIndex = 63;
            this.chkKeepTimeIntervalsTogether.Text = "Keep time intervals together:";
            this.chkKeepTimeIntervalsTogether.UseVisualStyleBackColor = true;
            this.chkKeepTimeIntervalsTogether.CheckedChanged += new System.EventHandler(this.chkKeepTimeIntervalsTogether_CheckedChanged);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(14, 64);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(102, 13);
            this.Label21.TabIndex = 70;
            this.Label21.Text = "Number of Columns:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 140);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(45, 13);
            this.lblInterval.TabIndex = 65;
            this.lblInterval.Text = "Interval:";
            // 
            // chkColumnsInEveryPage
            // 
            this.chkColumnsInEveryPage.AutoSize = true;
            this.chkColumnsInEveryPage.Location = new System.Drawing.Point(17, 35);
            this.chkColumnsInEveryPage.Name = "chkColumnsInEveryPage";
            this.chkColumnsInEveryPage.Size = new System.Drawing.Size(136, 17);
            this.chkColumnsInEveryPage.TabIndex = 69;
            this.chkColumnsInEveryPage.Text = "Columns in every page:";
            this.chkColumnsInEveryPage.UseVisualStyleBackColor = true;
            this.chkColumnsInEveryPage.CheckedChanged += new System.EventHandler(this.chkColumnsInEveryPage_CheckedChanged);
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.Location = new System.Drawing.Point(12, 167);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(40, 13);
            this.lblFactor.TabIndex = 66;
            this.lblFactor.Text = "Factor:";
            // 
            // chkHeadingsInEveryPage
            // 
            this.chkHeadingsInEveryPage.AutoSize = true;
            this.chkHeadingsInEveryPage.Location = new System.Drawing.Point(17, 195);
            this.chkHeadingsInEveryPage.Name = "chkHeadingsInEveryPage";
            this.chkHeadingsInEveryPage.Size = new System.Drawing.Size(138, 17);
            this.chkHeadingsInEveryPage.TabIndex = 68;
            this.chkHeadingsInEveryPage.Text = "Headings in every page";
            this.chkHeadingsInEveryPage.UseVisualStyleBackColor = true;
            this.chkHeadingsInEveryPage.CheckedChanged += new System.EventHandler(this.chkHeadingsInEveryPage_CheckedChanged);
            // 
            // numFactor
            // 
            this.numFactor.Location = new System.Drawing.Point(87, 167);
            this.numFactor.Name = "numFactor";
            this.numFactor.Size = new System.Drawing.Size(60, 20);
            this.numFactor.TabIndex = 67;
            this.numFactor.ValueChanged += new System.EventHandler(this.numFactor_ValueChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.optFrom);
            this.GroupBox1.Controls.Add(this.txtEndPage);
            this.GroupBox1.Controls.Add(this.optAll);
            this.GroupBox1.Controls.Add(this.txtStartPage);
            this.GroupBox1.Controls.Add(this.lblTo);
            this.GroupBox1.Location = new System.Drawing.Point(16, 58);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(199, 63);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            // 
            // txtEndPage
            // 
            this.txtEndPage.Location = new System.Drawing.Point(137, 33);
            this.txtEndPage.Name = "txtEndPage";
            this.txtEndPage.Size = new System.Drawing.Size(40, 20);
            this.txtEndPage.TabIndex = 21;
            // 
            // txtStartPage
            // 
            this.txtStartPage.Location = new System.Drawing.Point(58, 34);
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(40, 20);
            this.txtStartPage.TabIndex = 19;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(103, 34);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 16);
            this.lblTo.TabIndex = 20;
            this.lblTo.Text = "To:";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(13, 42);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(31, 13);
            this.Label22.TabIndex = 23;
            this.Label22.Text = "Print:";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label22);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.lblNumberOfPages);
            this.Panel1.Location = new System.Drawing.Point(417, 367);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(225, 121);
            this.Panel1.TabIndex = 81;
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.Location = new System.Drawing.Point(13, 11);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(104, 16);
            this.lblNumberOfPages.TabIndex = 17;
            this.lblNumberOfPages.Text = "Total Pages:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(546, 494);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(96, 24);
            this.cmdCancel.TabIndex = 80;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(446, 494);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(96, 24);
            this.cmdOK.TabIndex = 79;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fPrintDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(662, 531);
            this.Controls.Add(this.cmdPreview);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPrintDialog_FormClosed);
            this.Load += new System.EventHandler(this.fPrintDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEDYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSDMonth)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSDYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).EndInit();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBottom)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginTop)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPIY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPIX)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal Button cmdPreview;
        internal NumericUpDown numEDYear;
        internal Label Label13;
        internal Label Label14;
        internal Label Label15;
        internal ComboBox cboInterval;
        internal Label Label16;
        internal NumericUpDown numSDSecond;
        internal NumericUpDown numSDMinute;
        internal CheckBox chkKeepRowsTogether;
        internal NumericUpDown numSDHour;
        internal NumericUpDown numSDDay;
        internal NumericUpDown numEDSecond;
        internal CheckBox chkKeepColumnsTogether;
        internal NumericUpDown numEDMinute;
        internal RadioButton optFrom;
        internal NumericUpDown numEDHour;
        internal NumericUpDown numEDDay;
        internal NumericUpDown numEDMonth;
        internal RadioButton optAll;
        internal NumericUpDown numSDMonth;
        internal Panel Panel2;
        internal NumericUpDown numSDYear;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal Label Label11;
        internal Label Label12;
        internal NumericUpDown numMarginLeft;
        internal Label Label30;
        internal Label Label29;
        internal Label Label28;
        internal NumericUpDown numEndRow;
        internal Panel Panel6;
        internal NumericUpDown numStartRow;
        internal Label Label32;
        internal Label Label31;
        internal Label Label27;
        internal NumericUpDown numMarginBottom;
        internal Panel Panel5;
        internal NumericUpDown numMarginRight;
        internal NumericUpDown numMarginTop;
        internal Label Label26;
        internal Label Label25;
        internal Label Label24;
        internal Label Label23;
        internal Panel Panel4;
        internal ComboBox cboOrientation;
        internal Label lblPrinterNameCaption;
        internal ComboBox cboPrinters;
        internal Label lblScale;
        internal Label lblDPIY;
        internal Label lblPrecent;
        internal Label lblDPIX;
        internal NumericUpDown numScale;
        internal NumericUpDown numDPIY;
        internal Label Label17;
        internal NumericUpDown numDPIX;
        internal ComboBox cboResolution;
        internal Label Label18;
        internal CheckBox chkShowAllColumns;
        internal Panel Panel3;
        internal NumericUpDown numColumns;
        internal CheckBox chkKeepTimeIntervalsTogether;
        internal Label Label21;
        internal Label lblInterval;
        internal CheckBox chkColumnsInEveryPage;
        internal Label lblFactor;
        internal CheckBox chkHeadingsInEveryPage;
        internal NumericUpDown numFactor;
        internal GroupBox GroupBox1;
        internal TextBox txtEndPage;
        internal TextBox txtStartPage;
        internal Label lblTo;
        internal Label Label22;
        internal Panel Panel1;
        internal Label lblNumberOfPages;
        internal Button cmdCancel;
        internal Button cmdOK;

    }
}
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

namespace AGCSNCON
{
    partial class fCarRentalVehicle
    {
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblACRISS4;
        internal System.Windows.Forms.Label lblACRISS3;
        internal System.Windows.Forms.Label lblACRISS2;
        internal System.Windows.Forms.Label lblACRISS1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox drpACRISS4;
        internal System.Windows.Forms.ComboBox drpACRISS3;
        internal System.Windows.Forms.ComboBox drpACRISS2;
        internal System.Windows.Forms.ComboBox drpACRISS1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.Label lblNotes;
        internal System.Windows.Forms.TextBox txtLicensePlates;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblMake;
        internal System.Windows.Forms.ComboBox drpCarTypeID;
        internal System.Windows.Forms.PictureBox picMake;
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblACRISS4 = new System.Windows.Forms.Label();
            this.lblACRISS3 = new System.Windows.Forms.Label();
            this.lblACRISS2 = new System.Windows.Forms.Label();
            this.lblACRISS1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.drpACRISS4 = new System.Windows.Forms.ComboBox();
            this.drpACRISS3 = new System.Windows.Forms.ComboBox();
            this.drpACRISS2 = new System.Windows.Forms.ComboBox();
            this.drpACRISS1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtLicensePlates = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.drpCarTypeID = new System.Windows.Forms.ComboBox();
            this.picMake = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMake)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmdCancel.Location = new System.Drawing.Point(328, 496);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(72, 24);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmdOK.Location = new System.Drawing.Point(408, 496);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtRate);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.lblACRISS4);
            this.GroupBox1.Controls.Add(this.lblACRISS3);
            this.GroupBox1.Controls.Add(this.lblACRISS2);
            this.GroupBox1.Controls.Add(this.lblACRISS1);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.drpACRISS4);
            this.GroupBox1.Controls.Add(this.drpACRISS3);
            this.GroupBox1.Controls.Add(this.drpACRISS2);
            this.GroupBox1.Controls.Add(this.drpACRISS1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtNotes);
            this.GroupBox1.Controls.Add(this.lblNotes);
            this.GroupBox1.Controls.Add(this.txtLicensePlates);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.lblMake);
            this.GroupBox1.Controls.Add(this.drpCarTypeID);
            this.GroupBox1.Controls.Add(this.picMake);
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(472, 480);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(208, 160);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 16);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "USD";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(160, 160);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(40, 21);
            this.txtRate.TabIndex = 22;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(8, 160);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(128, 16);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "Rate:";
            // 
            // lblACRISS4
            // 
            this.lblACRISS4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACRISS4.Location = new System.Drawing.Point(208, 192);
            this.lblACRISS4.Name = "lblACRISS4";
            this.lblACRISS4.Size = new System.Drawing.Size(16, 16);
            this.lblACRISS4.TabIndex = 20;
            this.lblACRISS4.Text = "W";
            // 
            // lblACRISS3
            // 
            this.lblACRISS3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACRISS3.Location = new System.Drawing.Point(192, 192);
            this.lblACRISS3.Name = "lblACRISS3";
            this.lblACRISS3.Size = new System.Drawing.Size(16, 16);
            this.lblACRISS3.TabIndex = 19;
            this.lblACRISS3.Text = "W";
            // 
            // lblACRISS2
            // 
            this.lblACRISS2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACRISS2.Location = new System.Drawing.Point(176, 192);
            this.lblACRISS2.Name = "lblACRISS2";
            this.lblACRISS2.Size = new System.Drawing.Size(16, 16);
            this.lblACRISS2.TabIndex = 18;
            this.lblACRISS2.Text = "W";
            // 
            // lblACRISS1
            // 
            this.lblACRISS1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACRISS1.Location = new System.Drawing.Point(160, 192);
            this.lblACRISS1.Name = "lblACRISS1";
            this.lblACRISS1.Size = new System.Drawing.Size(16, 16);
            this.lblACRISS1.TabIndex = 17;
            this.lblACRISS1.Text = "W";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 192);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(136, 16);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "ACRISS Code:";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(8, 136);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(144, 16);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "ACRISS Code (4th Letter):";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 112);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(144, 16);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "ACRISS Code (3rd Letter):";
            // 
            // drpACRISS4
            // 
            this.drpACRISS4.Location = new System.Drawing.Point(160, 136);
            this.drpACRISS4.Name = "drpACRISS4";
            this.drpACRISS4.Size = new System.Drawing.Size(304, 21);
            this.drpACRISS4.TabIndex = 12;
            this.drpACRISS4.SelectedValueChanged += new System.EventHandler(this.drpACRISS4_SelectedValueChanged);
            // 
            // drpACRISS3
            // 
            this.drpACRISS3.Location = new System.Drawing.Point(160, 112);
            this.drpACRISS3.Name = "drpACRISS3";
            this.drpACRISS3.Size = new System.Drawing.Size(304, 21);
            this.drpACRISS3.TabIndex = 11;
            this.drpACRISS3.SelectedValueChanged += new System.EventHandler(this.drpACRISS3_SelectedValueChanged);
            // 
            // drpACRISS2
            // 
            this.drpACRISS2.Location = new System.Drawing.Point(160, 88);
            this.drpACRISS2.Name = "drpACRISS2";
            this.drpACRISS2.Size = new System.Drawing.Size(304, 21);
            this.drpACRISS2.TabIndex = 10;
            this.drpACRISS2.SelectedValueChanged += new System.EventHandler(this.drpACRISS2_SelectedValueChanged);
            // 
            // drpACRISS1
            // 
            this.drpACRISS1.Location = new System.Drawing.Point(160, 64);
            this.drpACRISS1.Name = "drpACRISS1";
            this.drpACRISS1.Size = new System.Drawing.Size(304, 21);
            this.drpACRISS1.TabIndex = 9;
            this.drpACRISS1.SelectedValueChanged += new System.EventHandler(this.drpACRISS1_SelectedValueChanged);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 16);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "ACRISS Code (2nd Letter):";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 16);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "ACRISS Code (1st Letter):";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(160, 216);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(304, 56);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(8, 216);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(136, 16);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes:";
            // 
            // txtLicensePlates
            // 
            this.txtLicensePlates.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicensePlates.Location = new System.Drawing.Point(160, 40);
            this.txtLicensePlates.Name = "txtLicensePlates";
            this.txtLicensePlates.Size = new System.Drawing.Size(120, 21);
            this.txtLicensePlates.TabIndex = 4;
            this.txtLicensePlates.TextChanged += new System.EventHandler(this.txtLicensePlates_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "License Plates:";
            // 
            // lblMake
            // 
            this.lblMake.Location = new System.Drawing.Point(8, 16);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(136, 24);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make and Colour:";
            // 
            // drpCarTypeID
            // 
            this.drpCarTypeID.Location = new System.Drawing.Point(160, 16);
            this.drpCarTypeID.Name = "drpCarTypeID";
            this.drpCarTypeID.Size = new System.Drawing.Size(304, 21);
            this.drpCarTypeID.TabIndex = 1;
            this.drpCarTypeID.SelectedValueChanged += new System.EventHandler(this.drpCarTypeID_SelectedValueChanged);
            // 
            // picMake
            // 
            this.picMake.Location = new System.Drawing.Point(16, 288);
            this.picMake.Name = "picMake";
            this.picMake.Size = new System.Drawing.Size(442, 186);
            this.picMake.TabIndex = 0;
            this.picMake.TabStop = false;
            // 
            // fCarRentalVehicle
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 525);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fCarRentalVehicle";
            this.Text = "fCarRentalVehicle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCarRentalVehicle_FormClosed);
            this.Load += new System.EventHandler(this.fCarRentalVehicle_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMake)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
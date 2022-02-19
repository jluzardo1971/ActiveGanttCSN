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
    partial class fCarRentalBranch
    {
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtStateAbr;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtManagerMobile;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtManagerName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtZIP;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBranchName;
        internal System.Windows.Forms.Label Label1;
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStateAbr = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManagerMobile = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(240, 288);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 24);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(336, 288);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(96, 24);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCity);
            this.GroupBox1.Controls.Add(this.txtStateAbr);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.txtZIP);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtAddress);
            this.GroupBox1.Controls.Add(this.txtPhone);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtBranchName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(424, 272);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 72);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 14;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtStateAbr
            // 
            this.txtStateAbr.Location = new System.Drawing.Point(104, 96);
            this.txtStateAbr.Name = "txtStateAbr";
            this.txtStateAbr.Size = new System.Drawing.Size(24, 20);
            this.txtStateAbr.TabIndex = 13;
            this.txtStateAbr.TextChanged += new System.EventHandler(this.txtStateAbr_TextChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtManagerMobile);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.txtManagerName);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(8, 176);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(408, 80);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Manager:";
            // 
            // txtManagerMobile
            // 
            this.txtManagerMobile.Location = new System.Drawing.Point(96, 48);
            this.txtManagerMobile.Name = "txtManagerMobile";
            this.txtManagerMobile.Size = new System.Drawing.Size(80, 20);
            this.txtManagerMobile.TabIndex = 3;
            this.txtManagerMobile.TextChanged += new System.EventHandler(this.txtManagerMobile_TextChanged);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 48);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(56, 16);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Mobile:";
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(96, 24);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(304, 20);
            this.txtManagerName.TabIndex = 1;
            this.txtManagerName.TextChanged += new System.EventHandler(this.txtManagerName_TextChanged);
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(8, 24);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Name:";
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(104, 120);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(40, 20);
            this.txtZIP.TabIndex = 11;
            this.txtZIP.TextChanged += new System.EventHandler(this.txtZIP_TextChanged);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(16, 120);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 16);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "ZIP:";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(16, 96);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 16);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "State:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "City:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 48);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 20);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(80, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 144);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Phone:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(104, 24);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(304, 20);
            this.txtBranchName.TabIndex = 1;
            this.txtBranchName.TextChanged += new System.EventHandler(this.txtBranchName_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Branch Name:";
            // 
            // fCarRentalBranch
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(440, 325);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fCarRentalBranch";
            this.Text = "fCarRentalBranch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fCarRentalBranch_FormClosed);
            this.Load += new System.EventHandler(this.fCarRentalBranch_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
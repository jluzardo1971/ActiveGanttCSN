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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace AGCSN
{
	internal class fAbout : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button cmdOK;
		internal System.Windows.Forms.GroupBox fraForm;
		internal System.Windows.Forms.LinkLabel lblSales;
		internal System.Windows.Forms.LinkLabel lblTechnicalSupport;
		internal System.Windows.Forms.LinkLabel lblRegister;
		internal System.Windows.Forms.Label lblSalesCaption;
		internal System.Windows.Forms.Label lblTechnicalSupportCaption;
		internal System.Windows.Forms.Label lblRegisterCaption;
		internal System.Windows.Forms.LinkLabel lblURL;
		internal System.Windows.Forms.Label lblTitle1;
		internal System.Windows.Forms.Label lblTitle2;
		internal System.Windows.Forms.Label lblCopyright;
		internal System.Windows.Forms.PictureBox PictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fAbout()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAbout));
            this.cmdOK = new System.Windows.Forms.Button();
            this.fraForm = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSales = new System.Windows.Forms.LinkLabel();
            this.lblTechnicalSupport = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.lblSalesCaption = new System.Windows.Forms.Label();
            this.lblTechnicalSupportCaption = new System.Windows.Forms.Label();
            this.lblRegisterCaption = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.fraForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(271, 181);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(88, 24);
            this.cmdOK.TabIndex = 8;
            this.cmdOK.Text = "&OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fraForm
            // 
            this.fraForm.Controls.Add(this.PictureBox1);
            this.fraForm.Controls.Add(this.lblSales);
            this.fraForm.Controls.Add(this.lblTechnicalSupport);
            this.fraForm.Controls.Add(this.lblRegister);
            this.fraForm.Controls.Add(this.lblSalesCaption);
            this.fraForm.Controls.Add(this.lblTechnicalSupportCaption);
            this.fraForm.Controls.Add(this.lblRegisterCaption);
            this.fraForm.Controls.Add(this.lblURL);
            this.fraForm.Controls.Add(this.lblTitle1);
            this.fraForm.Controls.Add(this.lblTitle2);
            this.fraForm.Controls.Add(this.lblCopyright);
            this.fraForm.Location = new System.Drawing.Point(7, 5);
            this.fraForm.Name = "fraForm";
            this.fraForm.Size = new System.Drawing.Size(352, 168);
            this.fraForm.TabIndex = 7;
            this.fraForm.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(16, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 16);
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // lblSales
            // 
            this.lblSales.Location = new System.Drawing.Point(144, 144);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(152, 16);
            this.lblSales.TabIndex = 9;
            this.lblSales.TabStop = true;
            this.lblSales.Text = "sales@sourcecodestore.com";
            this.lblSales.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSales_LinkClicked);
            // 
            // lblTechnicalSupport
            // 
            this.lblTechnicalSupport.Location = new System.Drawing.Point(144, 128);
            this.lblTechnicalSupport.Name = "lblTechnicalSupport";
            this.lblTechnicalSupport.Size = new System.Drawing.Size(192, 16);
            this.lblTechnicalSupport.TabIndex = 8;
            this.lblTechnicalSupport.TabStop = true;
            this.lblTechnicalSupport.Text = "support@sourcecodestore.com";
            this.lblTechnicalSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTechnicalSupport_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(144, 112);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(176, 16);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Secure Online Order Form";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // lblSalesCaption
            // 
            this.lblSalesCaption.Location = new System.Drawing.Point(16, 144);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Size = new System.Drawing.Size(40, 16);
            this.lblSalesCaption.TabIndex = 6;
            this.lblSalesCaption.Text = "Sales:";
            // 
            // lblTechnicalSupportCaption
            // 
            this.lblTechnicalSupportCaption.Location = new System.Drawing.Point(16, 128);
            this.lblTechnicalSupportCaption.Name = "lblTechnicalSupportCaption";
            this.lblTechnicalSupportCaption.Size = new System.Drawing.Size(112, 16);
            this.lblTechnicalSupportCaption.TabIndex = 5;
            this.lblTechnicalSupportCaption.Text = "Technical Support:";
            // 
            // lblRegisterCaption
            // 
            this.lblRegisterCaption.Location = new System.Drawing.Point(16, 112);
            this.lblRegisterCaption.Name = "lblRegisterCaption";
            this.lblRegisterCaption.Size = new System.Drawing.Size(64, 16);
            this.lblRegisterCaption.TabIndex = 4;
            this.lblRegisterCaption.Text = "Register:";
            // 
            // lblURL
            // 
            this.lblURL.Location = new System.Drawing.Point(72, 80);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(232, 16);
            this.lblURL.TabIndex = 3;
            this.lblURL.TabStop = true;
            this.lblURL.Text = "http://www.sourcecodestore.com";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblURL_LinkClicked);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(48, 24);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(296, 16);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "ActiveGanttCSN Scheduler Control, Version 2.0";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Location = new System.Drawing.Point(48, 40);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(232, 16);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = ".NET Windows Form Control (C#)";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(48, 56);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(296, 16);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright © 2002-2011,  The Source Code Store LLC";
            // 
            // fAbout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(366, 211);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.fraForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.fAbout_Load);
            this.fraForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void cmdOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void lblURL_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblURL.LinkVisited = true;
			System.Diagnostics.Process.Start(lblURL.Text);		
		}

		private void lblTechnicalSupport_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblTechnicalSupport.LinkVisited = true;
			System.Diagnostics.Process.Start("http://www.sourcecodestore.com/Support/default.aspx");		
		}

		private void lblSales_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblSales.LinkVisited = true;
			System.Diagnostics.Process.Start("mailto:" + lblSales.Text);		
		}

		private void lblRegister_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblRegister.LinkVisited = true;
			System.Diagnostics.Process.Start(lblRegister.Tag.ToString());		
		}

		private void fAbout_Load(object sender, System.EventArgs e)
		{
			System.Reflection.Assembly ai = System.Reflection.Assembly.GetExecutingAssembly();
			lblTitle1.Text = "ActiveGantt Scheduler Control, Version " + ai.GetName().Version.ToString();
			lblURL.Text = "http://www.sourcecodestore.com";
			lblTechnicalSupport.Text = "Technical Support Page";
			lblSales.Text = "sales@sourcecodestore.com";
            lblRegister.Tag = "http://www.sourcecodestore.com/OnlineStore/default.aspx";
            lblCopyright.Text = "Copyright © 2002-" + System.DateTime.Now.Year.ToString() + ",  The Source Code Store LLC";
		}
	}
}
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
    partial class fWBSProjectTaskView
    {
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGrid DataGrid1;
        internal System.Windows.Forms.TextBox txtTaskName;
        internal System.Windows.Forms.Label Label1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(368, 264);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(96, 24);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.Label2,
																					this.DataGrid1,
																					this.txtTaskName,
																					this.Label1});
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(456, 248);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Predecessors:";
            // 
            // DataGrid1
            // 
            this.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGrid1.CaptionBackColor = System.Drawing.Color.White;
            this.DataGrid1.CaptionVisible = false;
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 72);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ParentRowsVisible = false;
            this.DataGrid1.Size = new System.Drawing.Size(440, 160);
            this.DataGrid1.TabIndex = 2;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.White;
            this.txtTaskName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(56, 16);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.ReadOnly = true;
            this.txtTaskName.Size = new System.Drawing.Size(392, 21);
            this.txtTaskName.TabIndex = 1;
            this.txtTaskName.Text = "";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Task:";
            // 
            // fWBSProjectTaskView
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 293);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cmdOK,
																		  this.GroupBox1});
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fWBSProjectTaskView";
            this.Text = "fWBSProjectTaskView";
            this.Load += new System.EventHandler(this.fWBSProjectTaskView_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
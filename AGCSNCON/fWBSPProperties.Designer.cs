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
    partial class fWBSPProperties
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
            this.chkEnforcePredecessors = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPredecessorMode = new System.Windows.Forms.ComboBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnforcePredecessors
            // 
            this.chkEnforcePredecessors.AutoSize = true;
            this.chkEnforcePredecessors.Location = new System.Drawing.Point(7, 7);
            this.chkEnforcePredecessors.Name = "chkEnforcePredecessors";
            this.chkEnforcePredecessors.Size = new System.Drawing.Size(127, 17);
            this.chkEnforcePredecessors.TabIndex = 2;
            this.chkEnforcePredecessors.Text = "EnforcePredecessors";
            this.chkEnforcePredecessors.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.chkEnforcePredecessors);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.cboPredecessorMode);
            this.Panel1.Location = new System.Drawing.Point(7, 7);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(371, 70);
            this.Panel1.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "PredecessorMode:";
            // 
            // cboPredecessorMode
            // 
            this.cboPredecessorMode.FormattingEnabled = true;
            this.cboPredecessorMode.Items.AddRange(new object[] {
            "PM_FORCE",
            "PM_CREATEWARNINGFLAG",
            "PM_RAISEEVENT"});
            this.cboPredecessorMode.Location = new System.Drawing.Point(154, 35);
            this.cboPredecessorMode.Name = "cboPredecessorMode";
            this.cboPredecessorMode.Size = new System.Drawing.Size(203, 21);
            this.cboPredecessorMode.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(294, 84);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(84, 28);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // fWBSPProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 119);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fWBSPProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.fWBSPProperties_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkEnforcePredecessors;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboPredecessorMode;
        internal System.Windows.Forms.Button cmdOK;
    }
}
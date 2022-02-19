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
    partial class fMain
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.imgTreeView = new System.Windows.Forms.ImageList(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(100, 50);
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // imgTreeView
            // 
            this.imgTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeView.ImageStream")));
            this.imgTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeView.Images.SetKeyName(0, "");
            this.imgTreeView.Images.SetKeyName(1, "");
            this.imgTreeView.Images.SetKeyName(2, "");
            this.imgTreeView.Images.SetKeyName(3, "");
            this.imgTreeView.Images.SetKeyName(4, "");
            this.imgTreeView.Images.SetKeyName(5, "");
            this.imgTreeView.Images.SetKeyName(6, "onlinedocumentation.png");
            this.imgTreeView.Images.SetKeyName(7, "localCHMdocumentation.png");
            this.imgTreeView.Images.SetKeyName(8, "getting_started.png");
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(119)))), ((int)(((byte)(249)))));
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(11, 513);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(653, 21);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright �2002-2009 The Source Code Store LLC. All Rights Reserved. All trademar" +
    "ks are property of their legal owner.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(11, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(760, 432);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Location = new System.Drawing.Point(675, 509);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(96, 25);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Source Code Store - ActiveGantt Schedule Control - Main Screen";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        System.Windows.Forms.TreeNode mp_oParentNode;
        internal System.Windows.Forms.PictureBox picBanner;
        internal System.Windows.Forms.ImageList imgTreeView;
        internal System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TreeView treeView1;
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}
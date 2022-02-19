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

namespace AGCSNCON
{
	/// <summary>
	/// Summary description for fMain.
	/// </summary>
    public partial class fMain : System.Windows.Forms.Form
	{

        [STAThread]
		static void Main()
		{
			Application.Run(new fMain());
		}

		public fMain()
		{
			InitializeComponent();
		}

		private void fMain_Load(object sender, System.EventArgs e)
		{
            lblCopyright.Text = "Copyright ©2002-" + DateTime.Now.Year.ToString() + " The Source Code Store LLC. All Rights Reserved. All trademarks are property of their legal owner.";
			lblCopyright.BackColor = System.Drawing.ColorTranslator.FromOle(0x905100);
			lblCopyright.ForeColor = System.Drawing.Color.Beige;
			treeView1.ImageList = imgTreeView;
			treeView1.Font = new System.Drawing.Font("Tahoma", 9);

            AddTitleNode("AGEX", "ActiveGantt Examples:", 4, 5);

            AddNode("AGEX", "GanttCharts", "Gantt Charts:", 4, 5);

            AddNode("GanttCharts", "WBS", "Work Breakdown Structure (WBS) Project Management Example:", 4, 5);
            AddNode("WBS", "WBSProject", "SQL Server CE 4.0 data source", 2, 2);

            AddNode("GanttCharts", "MSPI", "Microsoft Project Integration Examples (32bit and 64bit compatible):", 4, 5);
            AddNode("MSPI", "Project2003", "Demonstrates how ActiveGantt integrates with MS Project 2003 (using XML Files and the MSP2003 Integration Library)", 2, 2);
            AddNode("MSPI", "Project2007", "Demonstrates how ActiveGantt integrates with MS Project 2007 (using XML Files and the MSP2007 Integration Library)", 2, 2);
            AddNode("MSPI", "Project2010", "Demonstrates how ActiveGantt integrates with MS Project 2010 (using XML Files and the MSP2010 Integration Library)", 2, 2);

            AddNode("AGEX", "Schedules", "Schedules and Rosters:", 4, 5);

            AddNode("Schedules", "VRFC", "Vehicle Rental/Fleet Control Roster Example:", 4, 5);
            AddNode("VRFC", "CarRental", "SQL Server CE 4.0 data source", 2, 2);

            AddNode("AGEX", "TEMPL", "Styles and Templates:", 4, 5);
            AddNode("TEMPL", "Templates", "Available Templates", 2, 2);
            AddNode("TEMPL", "Anakiwa_Blue_Style", "Anakiwa Blue Style without using Templates", 2, 2);
            AddNode("TEMPL", "MSP2003Style", "MS Project 2003 Style without using Templates", 2, 2);
            AddNode("TEMPL", "MSP2007Style", "MS Project 2007 Style without using Templates", 2, 2);
            AddNode("TEMPL", "MSP2010Style", "MS Project 2010 Style without using Templates", 2, 2);
            AddNode("TEMPL", "CRS", "Car Rental Style without using Templates", 2, 2);

            AddNode("AGEX", "OTHER", "Other examples:", 4, 5);
            AddNode("OTHER", "FastLoad", "Fast Loading of Row and Task objects", 2, 2);
            AddNode("OTHER", "CustomDrawing", "Custom Drawing", 2, 2);
            AddNode("OTHER", "SortRows", "Sort Rows", 2, 2);
            AddNode("OTHER", "MillisecondInterval", "5 Millisecond Interval View", 2, 2);
            AddNode("OTHER", "CustomTickMarkArea", "Custom TickMarkArea Drawing", 2, 2);
            AddNode("OTHER", "CustomTickMarkText", "Custom TickMark Text Drawing", 2, 2);

            AddNode("OTHER", "TimeBlocks", "TimeBlocks and Duration Tasks:", 4, 5);
            AddNode("TimeBlocks", "RCT_DAY", "Daily Recurrent TimeBlocks", 2, 2);
            AddNode("TimeBlocks", "RCT_WEEK", "Weekly Recurrent TimeBlocks", 2, 2);
            AddNode("TimeBlocks", "RCT_MONTH", "Monthly Recurrent TimeBlocks", 2, 2);
            AddNode("TimeBlocks", "RCT_YEAR", "Yearly Recurrent TimeBlocks", 2, 2);
            AddNode("TimeBlocks", "DurationTasks", "Duration Tasks (can skip over non-working TimeBlock intervals)", 2, 2);


            mp_ExpandNode("AGEX");
            mp_ExpandNode("GanttCharts");
            mp_ExpandNode("WBS");
            mp_ExpandNode("MSPI");
            mp_ExpandNode("Schedules");
            mp_ExpandNode("VRFC");


		}

        private void mp_ExpandNode(string sKey)
        {
            TreeNode oNode = null;
            oNode = FindTreeNode(sKey, null);
            oNode.Expand();
        }

		private void treeView1_DoubleClick(object sender, System.EventArgs e)
		{
			string sSelectedTag = (string) treeView1.SelectedNode.Tag;
			switch (sSelectedTag) 
			{
                case "WBSProject":
                    {
                        fWBSProject oForm = new fWBSProject();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "CarRental":
                    {
                        fCarRental oForm = new fCarRental();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "Project2003":
                    {
                        fMSProject11 oForm = new fMSProject11();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "Project2007":
                    {
                        fMSProject12 oForm = new fMSProject12();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "Project2010":
                    {
                        fMSProject14 oForm = new fMSProject14();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "FastLoad":
                    {
                        fFastLoading oForm = new fFastLoading();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "CustomDrawing":
                    {
                        fCustomDrawing oForm = new fCustomDrawing();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "SortRows":
                    {
                        fSortRows oForm = new fSortRows();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "MillisecondInterval":
                    {
                        fMillisecondInterval oForm = new fMillisecondInterval();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "DurationTasks":
                    {
                        fDurationTasks oForm = new fDurationTasks();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "RCT_DAY":
                    {
                        fRCT_DAY oForm = new fRCT_DAY();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "RCT_WEEK":
                    {
                        fRCT_WEEK oForm = new fRCT_WEEK();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "RCT_MONTH":
                    {
                        fRCT_MONTH oForm = new fRCT_MONTH();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "RCT_YEAR":
                    {
                        fRCT_YEAR oForm = new fRCT_YEAR();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "CustomTickMarkArea":
                    {
                        fCustomTickMarkAreaDraw oForm = new fCustomTickMarkAreaDraw();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "CustomTickMarkText":
                    {
                        fCustomTickMarkTextDraw oForm = new fCustomTickMarkTextDraw();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "Templates":
                    {
                        fTemplates oForm = new fTemplates();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "Anakiwa_Blue_Style":
                    {
                        fSTL_Anakiwa_Blue oForm = new fSTL_Anakiwa_Blue();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "MSP2003Style":
                    {
                        fSTL_MSP2003 oForm = new fSTL_MSP2003();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "MSP2007Style":
                    {
                        fSTL_MSP2007 oForm = new fSTL_MSP2007();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "MSP2010Style":
                    {
                        fSTL_MSP2010 oForm = new fSTL_MSP2010();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "CRS":
                    {
                        fSTL_CR oForm = new fSTL_CR();
                        this.Cursor = Cursors.WaitCursor;
                        oForm.ShowDialog(this);
                        this.Cursor = Cursors.Default;
                    }
                    break;
			}
		}

        private TreeNode FindTreeNode(string sKey, TreeNodeCollection oNodes)
        {
            if (oNodes == null)
            {
                oNodes = treeView1.Nodes;
            }
            TreeNode oNode = null;
            TreeNode oReturnNode = null;
            foreach (TreeNode oNode_loopVariable in oNodes)
            {
                oNode = oNode_loopVariable;
                if (oNode.Name == sKey)
                {
                    oReturnNode = oNode;
                    return oReturnNode;
                }
                if (oNode.Nodes.Count > 0)
                {
                    oReturnNode = FindTreeNode(sKey, oNode.Nodes);
                    if ((oReturnNode != null))
                    {
                        return oReturnNode;
                    }
                }
            }
            return null;
        }

		private void AddTitleNode(string sKey, string sText, int ImageIndex, int SelectedImageIndex)
		{
			System.Windows.Forms.TreeNode oNode = new System.Windows.Forms.TreeNode();
            oNode.Name = sKey;
			oNode.Text = sText;
			oNode.ImageIndex = ImageIndex;
			oNode.SelectedImageIndex = SelectedImageIndex;
			oNode.Tag = sKey;
			treeView1.Nodes.Add(oNode);
			mp_oParentNode = oNode;
		}

		private void AddNode(string sParentKey, string sKey, string sText, int ImageIndex, int SelectedImageIndex)
		{
			System.Windows.Forms.TreeNode oNode = new System.Windows.Forms.TreeNode();
            System.Windows.Forms.TreeNode[] oParentNode;
            oNode.Name = sKey;
			oNode.Text = sText;
			oNode.ImageIndex = ImageIndex;
			oNode.SelectedImageIndex = SelectedImageIndex;
			oNode.Tag = sKey;
            oParentNode = treeView1.Nodes.Find(sParentKey, true);
            oParentNode[0].Nodes.Add(oNode);
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


	


		

	}
}
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
using AGCSN;

namespace AGCSNCON
{
	/// <summary>
	/// Summary description for fLoadXML.
	/// </summary>
    public partial class fLoadXML : System.Windows.Forms.Form
	{
		bool bLoaded = false;



		public fLoadXML()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}





		private void fLoadXML_Load(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

		private void ActiveGanttCSNCtl1_CustomTierDraw(object sender, AGCSN.CustomTierDrawEventArgs e)
		{
			if (bLoaded == false)
			{
				return;
			}
            if (ActiveGanttCSNCtl1.ControlTag == "CarRental")
            {
                if (e.Interval == E_INTERVAL.IL_HOUR & e.Factor == 12)
                {
                    e.Text = e.StartDate.ToString("tt").ToUpper();
                }
                if (e.Interval == E_INTERVAL.IL_MONTH & e.Factor == 1)
                {
                    e.Text = e.StartDate.ToString("MMMM yyyy");
                }
                if (e.Interval == E_INTERVAL.IL_DAY & e.Factor == 1)
                {
                    e.Text = e.StartDate.ToString("ddd d");
                }
            }
		}

		private void fLoadXML_Resize(object sender, System.EventArgs e)
		{
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, menuStrip1, toolStrip1);
		}

		private void mnuSaveXML_Click(object sender, System.EventArgs e)
		{
            SaveXML();

		}

		private void mnuLoadXML_Click(object sender, System.EventArgs e)
		{
            LoadXML();
		}

        private void SaveXML()
        {
            saveFileDialog1.Title = "Save As XML";
            if (ActiveGanttCSNCtl1.ControlTag == "WBSProject")
            {
                saveFileDialog1.FileName = "AGCSN_WBSP";
            }
            else if (ActiveGanttCSNCtl1.ControlTag == "CarRental")
            {
                saveFileDialog1.FileName = "AGCSN_CR";
            }
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveGanttCSNCtl1.WriteXML(saveFileDialog1.FileName);
            }
        }

        private void LoadXML()
        {
            openFileDialog1.Title = "Open XML";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveGanttCSNCtl1.ReadXML(openFileDialog1.FileName);
                bLoaded = true;
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLoadXML_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void cmdSaveXML_Click(object sender, EventArgs e)
        {
            SaveXML();
        }



	}
}
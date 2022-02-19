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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AGCSN;

namespace AGCSNCON
{
    public partial class fSortRows : Form
    {
        private bool mp_bDescending = false;

        public fSortRows()
        {
            InitializeComponent();
        }

        private void fSortRows_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            int i = 0;
            ActiveGanttCSNCtl1.Columns.Add("", "C1", 125, "");
            for (i = 1; i <= 10; i++)
            {
                string si = null;
                si = i.ToString();
                while (si.Length < 2)
                {
                    si = "0" + si;
                }
                ActiveGanttCSNCtl1.Rows.Add("K" + si, "K" + si, true, true, "");
            }
        }

        private void fSortRows_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, ToolStrip1);
        }

        private void cmdSort_Click(object sender, EventArgs e)
        {
            mp_bDescending = !mp_bDescending;
            ActiveGanttCSNCtl1.Rows.SortRows("Text", mp_bDescending, E_SORTTYPE.ES_STRING, -1, -1);
            ActiveGanttCSNCtl1.Redraw();
        }
    }
}
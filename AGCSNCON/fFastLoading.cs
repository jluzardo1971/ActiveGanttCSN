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
    public partial class fFastLoading : Form
    {
        public fFastLoading()
        {
            InitializeComponent();
        }

        private void fFastLoading_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            System.DateTime dtStart = System.DateTime.Now;


            int i = 0;
            ActiveGanttCSNCtl1.Columns.Add("Tasks", "", 200, "");
            ActiveGanttCSNCtl1.TreeviewColumnIndex = 1;
            clsRow oRow = default(clsRow);
            clsTask oTask = default(clsTask);
            int lCurrentDepth = 0;
            DateTime dtStartDate = default(DateTime);
            DateTime dtEndDate = default(DateTime);
            for (i = 0; i <= 10000; i++)
            {
                oRow = ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString(), "Task K" + i.ToString(), true, true, "", false);
                oRow.Height = 20;
                oRow.Node.Depth = lCurrentDepth;
                dtStartDate = ActiveGanttCSNCtl1.MathLib.DateTimeAdd(E_INTERVAL.IL_HOUR, Globals.GetRnd(0, 5), DateTime.Now);
                dtEndDate = ActiveGanttCSNCtl1.MathLib.DateTimeAdd(E_INTERVAL.IL_HOUR, Globals.GetRnd(2, 7), dtStartDate);
                oTask = ActiveGanttCSNCtl1.Tasks.Add("K" + i.ToString(), "K" + i.ToString(), dtStartDate, dtEndDate);
                lCurrentDepth = lCurrentDepth + Globals.GetRnd(-1, 2);
                if (lCurrentDepth < 0)
                {
                    lCurrentDepth = 0;
                }
            }
            ActiveGanttCSNCtl1.Rows.UpdateScrollBar();
            ActiveGanttCSNCtl1.Rows.UpdateTree();

            System.DateTime dtEnd = System.DateTime.Now;

            TimeSpan oTimeSpan = dtEnd.Subtract(dtStart);

            System.Diagnostics.Debug.WriteLine(oTimeSpan.TotalMilliseconds);
        }

        private void fFastLoading_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
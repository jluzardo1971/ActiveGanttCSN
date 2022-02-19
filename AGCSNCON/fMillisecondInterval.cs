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
    public partial class fMillisecondInterval : Form
    {
        public fMillisecondInterval()
        {
            InitializeComponent();
        }

        private void fMillisecondInterval_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            clsView oView;
            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_MILLISECOND, 5, E_TIERTYPE.ST_MINUTE, E_TIERTYPE.ST_NOT_VISIBLE, E_TIERTYPE.ST_SECOND, "MSI");
            oView.TimeLine.TickMarkArea.Visible = false;
            oView.TimeLine.TierArea.TierFormat.MinuteIntervalFormat = "MMM dd, yyyy hh:mm tt";

            ActiveGanttCSNCtl1.CurrentView = "MSI";

            int i = 0;
            ActiveGanttCSNCtl1.Columns.Add("", "C1", 125, "");
            for (i = 1; i <= 10; i++)
            {
                clsRow oRow;
                oRow = ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString(), "K" + i.ToString(), true, true, "");
            }

            AddTask("K1", GetDate(15, 59, 500), GetDate(16, 0, 100));
            AddTask("K2", GetDate(15, 58, 900), GetDate(16, 1, 200));
            AddTask("K3", GetDate(16, 0, 800), GetDate(16, 1, 300));
            AddTask("K4", GetDate(15, 58, 800), GetDate(16, 2, 0));
            AddTask("K5", GetDate(15, 59, 300), GetDate(16, 1, 0));

            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(GetDate(15, 58, 0));

        }

        private DateTime GetDate(int lMinute, int lSecond, int lMillisecond)
        {
            DateTime dtReturn = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, lMinute, lSecond, lMillisecond);
            return dtReturn;
        }

        private void AddTask(string sRowKey, DateTime dtStart, DateTime dtEnd)
        {
            string sText = "";
            sText = ActiveGanttCSNCtl1.MathLib.DateTimeDiff(E_INTERVAL.IL_MILLISECOND, dtStart, dtEnd).ToString();
            sText = sText + "ms";
            ActiveGanttCSNCtl1.Tasks.Add(sText, sRowKey, dtStart, dtEnd, "", "", "");
        }

        private void ActiveGanttCSNCtl1_CompleteObjectChange(object sender, ObjectStateChangedEventArgs e)
        {
            if (e.EventTarget == E_EVENTTARGET.EVT_TASK)
            {
                clsTask oTask;
                string sText;
                oTask = ActiveGanttCSNCtl1.Tasks.Item(e.Index.ToString());
                sText = ActiveGanttCSNCtl1.MathLib.DateTimeDiff(E_INTERVAL.IL_MILLISECOND, oTask.StartDate, oTask.EndDate).ToString();
                oTask.Text = sText + "ms";
            }
        }

        private void ActiveGanttCSNCtl1_ObjectAdded(object sender, ObjectAddedEventArgs e)
        {
            if (e.EventTarget == E_EVENTTARGET.EVT_TASK)
            {
                clsTask oTask;
                string sText;
                oTask = ActiveGanttCSNCtl1.Tasks.Item(e.TaskIndex.ToString());
                sText = ActiveGanttCSNCtl1.MathLib.DateTimeDiff(E_INTERVAL.IL_MILLISECOND, oTask.StartDate, oTask.EndDate).ToString();
                oTask.Text = sText + "ms";
            }
        }

        private void fMillisecondInterval_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }


    }
}
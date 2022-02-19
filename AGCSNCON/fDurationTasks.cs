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
using System.Diagnostics;

namespace AGCSNCON
{
    public partial class fDurationTasks : Form
    {
        public fDurationTasks()
        {
            InitializeComponent();
        }

        private void fDurationTasks_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            ActiveGanttCSNCtl1.AddMode = E_ADDMODE.AT_DURATION_BOTH;
            ActiveGanttCSNCtl1.AddDurationInterval = E_INTERVAL.IL_HOUR;

            clsView oView;
            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_MINUTE, 10, E_TIERTYPE.ST_MONTH, E_TIERTYPE.ST_NOT_VISIBLE, E_TIERTYPE.ST_DAYOFWEEK, "View1");
            oView.TimeLine.TickMarkArea.Visible = false;

            ActiveGanttCSNCtl1.CurrentView = "View1";

            int i = 0;
            for (i = 0; i <= 110; i++)
            {
                ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString());
            }

            clsTimeBlock oTimeBlock;

            //Note: non-working overlapping TimeBlock objects are combined for duration calculation purposes.


            // TimeBlock starts at 6:00pm and ends on 7:00am next day (13 Hours)
            // This TimeBlock is repeated every day.
            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("TB_OutOfOfficeHours");
            oTimeBlock.NonWorking = true;
            oTimeBlock.BaseDate = new DateTime(2000, 1, 1, 18, 0, 0);
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;
            oTimeBlock.DurationFactor = 13;
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_DAY;

            // TimeBlock starts at 12:00pm (noon) and ends at 1:30pm (90 Minutes)
            // This TimeBlock is repeated every day. 
            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("TB_LunchBreak");
            oTimeBlock.NonWorking = true;
            oTimeBlock.BaseDate = new DateTime(2000, 1, 1, 12, 0, 0);
            oTimeBlock.DurationInterval = E_INTERVAL.IL_MINUTE;
            oTimeBlock.DurationFactor = 90;
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_DAY;

            // Timeblock starts at 12:00am Saturday and ends on 12:00am Monday (48 Hours)
            // This TimeBlock is repeated every week.
            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("TB_Weekend");
            oTimeBlock.NonWorking = true;
            oTimeBlock.BaseDate = new DateTime(2000, 1, 1, 0, 0, 0);
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;
            oTimeBlock.DurationFactor = 48;
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_WEEK;
            oTimeBlock.BaseWeekDay = E_WEEKDAY.WD_SATURDAY;

            // Arbitrary holiday that starts at 12:00am January 8th and ends on 12:00am January 9th (24 hours)
            // This TimeBlock is repeated every year.
            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("TB_Jan8");
            oTimeBlock.NonWorking = true;
            oTimeBlock.BaseDate = new DateTime(2000, 1, 8, 0, 0, 0);
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;
            oTimeBlock.DurationFactor = 24;
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_YEAR;

            ActiveGanttCSNCtl1.TimeBlocks.IntervalStart = new DateTime(2012, 1, 1);
            ActiveGanttCSNCtl1.TimeBlocks.IntervalEnd = new DateTime(2023, 6, 1);
            ActiveGanttCSNCtl1.TimeBlocks.IntervalType = E_TBINTERVALTYPE.TBIT_MANUAL;
            ActiveGanttCSNCtl1.TimeBlocks.CalculateInterval();


            clsTask oTask;
            for (i = 0; i <= 100; i++)
            {
                oTask = ActiveGanttCSNCtl1.Tasks.DAdd("K" + i.ToString(), new DateTime(2013, 1, 1), E_INTERVAL.IL_HOUR, i, i.ToString(), "", "", "0");

                DateTime dtStartDate;
                DateTime dtEndDate;

                dtStartDate = oTask.StartDate;
                dtEndDate = oTask.EndDate;

                int lDuration = 0;
                lDuration = ActiveGanttCSNCtl1.MathLib.CalculateDuration(ref dtStartDate, ref dtEndDate, oTask.DurationInterval);
                if (lDuration != oTask.DurationFactor)
                {
                    Debug.WriteLine("Error: " + i.ToString());
                    Debug.WriteLine("  Task Duration Factor: " + oTask.DurationFactor.ToString());
                    Debug.WriteLine("  Calculated Duration: " + lDuration.ToString());
                    Debug.WriteLine("  Task:");
                    Debug.WriteLine("    " + oTask.StartDate.ToString("yyyy/MM/dd HH:mm:ss"));
                    Debug.WriteLine("    " + oTask.EndDate.ToString("yyyy/MM/dd HH:mm:ss"));
                    Debug.WriteLine("  Calculated:");
                    Debug.WriteLine("    " + dtStartDate.ToString("yyyy/MM/dd HH:mm:ss"));
                    Debug.WriteLine("    " + dtEndDate.ToString("yyyy/MM/dd HH:mm:ss"));
                }


            }

            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(new DateTime(2013, 1, 1));
        }

        private void fDurationTasks_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
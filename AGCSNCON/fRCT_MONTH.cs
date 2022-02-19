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
    public partial class fRCT_MONTH : Form
    {
        public fRCT_MONTH()
        {
            InitializeComponent();
        }

        private void fRCT_MONTH_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            ActiveGanttCSNCtl1.Left = 10;
            ActiveGanttCSNCtl1.Top = 15;
            ActiveGanttCSNCtl1.Width = this.Width - 50;
            ActiveGanttCSNCtl1.Height = this.Height - 50;

            clsView oView;
            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_HOUR, 1, E_TIERTYPE.ST_MONTH, E_TIERTYPE.ST_NOT_VISIBLE, E_TIERTYPE.ST_DAYOFWEEK, "View1");
            oView.TimeLine.TickMarkArea.Visible = false;
            ActiveGanttCSNCtl1.TierFormatScope = E_OBJECTSCOPE.OS_CONTROL;
            ActiveGanttCSNCtl1.TierFormat.DayOfWeekIntervalFormat = "dd";

            ActiveGanttCSNCtl1.CurrentView = "View1";

            int i = 0;
            for (i = 1; i <= 50; i++)
            {
                ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString());
            }

            clsTimeBlock oTimeBlock;
            DateTime dtDate;
            dtDate = new DateTime(2000, 1, 1, 0, 0, 0);

            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("TimeBlock1");
            oTimeBlock.BaseDate = dtDate;
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;
            oTimeBlock.DurationFactor = -48;
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_MONTH;

        }

        private void fRCT_MONTH_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
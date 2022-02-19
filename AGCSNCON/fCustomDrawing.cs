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
    public partial class fCustomDrawing : Form
    {


        public fCustomDrawing()
        {
            InitializeComponent();
        }

        private void fCustomDrawing_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_HGRAD_BLUE_BELL, E_OBJECTTEMPLATE.STO_VARIATION_1);
            
            int i = 0;
            ActiveGanttCSNCtl1.Columns.Add("Column 1", "", 125, "");
            ActiveGanttCSNCtl1.Columns.Add("Column 2", "", 100, "");
            for (i = 1; i <= 10; i++)
            {
                ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString(), "Row " + i.ToString() + " (Key: " + "K" + i.ToString() + ")", true, true, "");
            }

            //ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(new DateTime(2016, 11, 2, 0, 0, 0));

            ActiveGanttCSNCtl1.TimeLineScrollBarScope = E_OBJECTSCOPE.OS_CONTROL;
            ActiveGanttCSNCtl1.TimeLineScrollBar.StartDate = new DateTime(2016, 11, 2, 0, 0, 0);
            ActiveGanttCSNCtl1.TimeLineScrollBar.Interval = E_INTERVAL.IL_DAY;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Factor = 1;
            ActiveGanttCSNCtl1.TimeLineScrollBar.SmallChange = 1;
            ActiveGanttCSNCtl1.TimeLineScrollBar.LargeChange = 10;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Max = 100;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Enabled = true;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Visible = true;






            ActiveGanttCSNCtl1.Tasks.Add("Task 1", "K1", new DateTime(2016, 11, 2, 0, 0, 0), new DateTime(2016, 11, 2, 3, 0, 0), "", "RET1", "");
            ActiveGanttCSNCtl1.Tasks.Add("Task 2", "K2", new DateTime(2016, 11, 2, 1, 0, 0), new DateTime(2016, 11, 2, 4, 0, 0), "", "RET1", "");
            ActiveGanttCSNCtl1.Tasks.Add("Task 3", "K3", new DateTime(2016, 11, 2, 2, 0, 0), new DateTime(2016, 11, 2, 5, 0, 0), "", "RET1", "");

            ActiveGanttCSNCtl1.Redraw();
        }

        private void ActiveGanttCSNCtl1_Draw(object sender, AGCSN.DrawEventArgs e)
        {
            if (e.EventTarget == E_EVENTTARGET.EVT_TASK)
            {
                if (ActiveGanttCSNCtl1.SelectedTaskIndex == e.ObjectIndex)
                {
                    e.CustomDraw = true;
                    clsTask oTask;
                    oTask = ActiveGanttCSNCtl1.Tasks.Item(e.ObjectIndex.ToString());
                    System.Drawing.Font oFont = new System.Drawing.Font("Arial", 7);
                    clsTextFlags oTextFlags = new clsTextFlags();
                    oTextFlags.HorizontalAlignment = GRE_HORIZONTALALIGNMENT.HAL_CENTER;
                    oTextFlags.VerticalAlignment = GRE_VERTICALALIGNMENT.VAL_CENTER;
                    ActiveGanttCSNCtl1.Drawing.PaintImage(ImageList1.Images[0], oTask.Left + 40, oTask.Top + 10, oTask.Left + 64, oTask.Top + 34);
                    ActiveGanttCSNCtl1.Drawing.DrawLine(oTask.Left, ((oTask.Bottom - oTask.Top) / 2) + oTask.Top, oTask.Right, ((oTask.Bottom - oTask.Top) / 2) + oTask.Top, Color.Green, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);
                    ActiveGanttCSNCtl1.Drawing.DrawRectangle(oTask.Left, oTask.Top, oTask.Left + 10, oTask.Top + 10, Color.Red, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);
                    ActiveGanttCSNCtl1.Drawing.DrawBorder(oTask.Left, oTask.Top, oTask.Right, oTask.Bottom, Color.Blue, GRE_LINEDRAWSTYLE.LDS_SOLID, 2);
                    ActiveGanttCSNCtl1.Drawing.DrawAlignedText(oTask.Left, oTask.Top, oTask.Right, oTask.Bottom, oTask.Text + " Is Selected", GRE_HORIZONTALALIGNMENT.HAL_RIGHT, GRE_VERTICALALIGNMENT.VAL_BOTTOM, Color.Blue, oFont);
                    ActiveGanttCSNCtl1.Drawing.DrawText(oTask.Left, oTask.Top, oTask.Right, oTask.Bottom, "Draw Text", oTextFlags, Color.Red, oFont);
                }
            }
        }

        private void fCustomDrawing_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.ProgressLine.LineType = E_PROGRESSLINETYPE.TLMT_SYSTEMTIME;
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.ProgressLine.LineStyle = E_PROGRESSLINESTYLE.PLT_STANDARD;
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.ProgressLine.Length = E_PROGRESSLINELENGTH.TLMA_CA_TIMELINE;
            ActiveGanttCSNCtl1.Redraw();
        }
    }
}
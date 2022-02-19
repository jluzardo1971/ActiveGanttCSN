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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AGCSN;

namespace AGCSNCON
{
    public partial class fSTL_MSP2003 : Form
    {

        private const string mp_sFontName = "Tahoma";

        public fSTL_MSP2003()
        {
            InitializeComponent();
        }

        private void fSTL_MSP2003_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            clsStyle oStyle = null;
            clsView oView = null;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TimeLineTiers");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_RAISED;
            oStyle.BorderColor = Color.FromArgb(255, 169, 169, 169);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TaskStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.Placement = E_PLACEMENT.PLC_OFFSETPLACEMENT;
            oStyle.BackColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.TextPlacement = E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 10;
            oStyle.OffsetTop = 5;
            oStyle.OffsetBottom = 10;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_HATCH;
            oStyle.HatchBackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.HatchForeColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.HatchStyle = GRE_HATCHSTYLE.HS_PERCENT50;
            oStyle.PredecessorStyle.LineColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.MilestoneStyle.ShapeIndex = GRE_FIGURETYPE.FT_DIAMOND;
            oStyle.MilestoneStyle.FillColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.MilestoneStyle.BorderColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.PredecessorStyle.XOffset = 4;
            oStyle.PredecessorStyle.YOffset = 4;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("SummaryStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.Placement = E_PLACEMENT.PLC_OFFSETPLACEMENT;
            oStyle.BackColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.BorderColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.SelectionRectangleStyle.Visible = false;
            oStyle.TextPlacement = E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 10;
            oStyle.TaskStyle.StartShapeIndex = GRE_FIGURETYPE.FT_PROJECTDOWN;
            oStyle.TaskStyle.EndShapeIndex = GRE_FIGURETYPE.FT_PROJECTDOWN;
            oStyle.TaskStyle.EndFillColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.TaskStyle.EndBorderColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.TaskStyle.StartFillColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.TaskStyle.StartBorderColor = Color.FromArgb(255, 0, 128, 0);
            oStyle.FillMode = GRE_FILLMODE.FM_UPPERHALFFILLED;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("CellStyleKeyColumn");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 128, 128, 128);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.CustomBorderStyle.Left = false;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 4;


            clsColumn oColumn;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("ID", "", 30, "");

            oColumn = ActiveGanttCSNCtl1.Columns.Add("Task Name", "", 300, "");

            ActiveGanttCSNCtl1.TreeviewColumnIndex = 2;

            ActiveGanttCSNCtl1.Splitter.Position = 285;
            ActiveGanttCSNCtl1.Treeview.Images = true;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = true;
            ActiveGanttCSNCtl1.Treeview.TreeLines = false;

            ActiveGanttCSNCtl1.Treeview.Images = true;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = true;

            int i = 0;
            clsRow oRow;
            for (i = 1; i <= 100; i++)
            {
                oRow = ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString());
                oRow.MergeCells = false;
                oRow.Node.Text = "Row: " + i.ToString();
                oRow.Cells.Item("1").Text = i.ToString();
                oRow.Cells.Item("1").StyleIndex = "CellStyleKeyColumn";
                oRow.Height = 20;
                if (oRow.Index % 5 == 0 | oRow.Index == 1)
                {
                    oRow.Node.Depth = 0;
                }
                else
                {
                    oRow.Node.CheckBoxVisible = true;
                    oRow.Node.Depth = 1;
                }
            }

            ActiveGanttCSNCtl1.Rows.UpdateTree();

            ActiveGanttCSNCtl1.TimeLineScrollBar.StartDate = new DateTime(2013, 1, 1);
            ActiveGanttCSNCtl1.TimeLineScrollBar.Interval = E_INTERVAL.IL_HOUR;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Factor = 1;
            ActiveGanttCSNCtl1.TimeLineScrollBar.SmallChange = 6;
            ActiveGanttCSNCtl1.TimeLineScrollBar.LargeChange = 480;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Max = 4000;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Value = 0;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Enabled = true;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Visible = true;


            ActiveGanttCSNCtl1.TierFormat.QuarterIntervalFormat = "yyyy Q\\Q";
            ActiveGanttCSNCtl1.TierFormat.MonthIntervalFormat = "MMM";

            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_HOUR, 24, E_TIERTYPE.ST_QUARTER, E_TIERTYPE.ST_NOT_VISIBLE, E_TIERTYPE.ST_MONTH);
            oView.TimeLine.TierArea.UpperTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.UpperTier.StyleIndex = "TimeLineTiers";
            oView.TimeLine.TierArea.LowerTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.LowerTier.StyleIndex = "TimeLineTiers";
            oView.TimeLine.TickMarkArea.Visible = false;

            ActiveGanttCSNCtl1.CurrentView = "1";

            ActiveGanttCSNCtl1.Tasks.Add("", "K1", new DateTime(2013, 3, 1), new DateTime(2014, 3, 1), "SS", "SummaryStyle");

            ActiveGanttCSNCtl1.Tasks.Add("", "K5", new DateTime(2013, 3, 1), new DateTime(2014, 3, 1), "TS", "TaskStyle");

            ActiveGanttCSNCtl1.Redraw();


        }

        private void fSTL_MSP2003_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
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
    public partial class fSTL_MSP2007 : Form
    {

        private const string mp_sFontName = "Tahoma";

        public fSTL_MSP2007()
        {
            InitializeComponent();
        }

        private void fSTL_MSP2007_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            clsStyle oStyle = null;
            clsView oView = null;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ScrollBar");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oStyle.BackColor = Color.FromArgb(255, 122, 151, 193);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 139, 144, 150);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ArrowButtons");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oStyle.BackColor = Color.FromArgb(255, 122, 151, 193);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 150, 158, 168);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ThumbButtonH");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 240, 240, 240);
            oStyle.EndGradientColor = Color.FromArgb(255, 165, 186, 207);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 138, 145, 153);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ThumbButtonV");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_HORIZONTAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 240, 240, 240);
            oStyle.EndGradientColor = Color.FromArgb(255, 165, 186, 207);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 138, 145, 153);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TimeLineTiers");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_TRANSPARENT;
            oStyle.CustomBorderStyle.Left = true;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.CustomBorderStyle.Right = false;
            oStyle.CustomBorderStyle.Bottom = true;
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.BorderColor = Color.FromArgb(255, 197, 206, 216);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TimeLine");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.StartGradientColor = Color.FromArgb(255, 179, 206, 235);
            oStyle.EndGradientColor = Color.FromArgb(255, 161, 193, 232);
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_NONE;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ColumnStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.StartGradientColor = Color.FromArgb(255, 179, 206, 235);
            oStyle.EndGradientColor = Color.FromArgb(255, 161, 193, 232);
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.CustomBorderStyle.Left = false;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.CustomBorderStyle.Right = true;
            oStyle.CustomBorderStyle.Bottom = true;
            oStyle.BorderColor = Color.FromArgb(255, 197, 206, 216);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TaskStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.StartGradientColor = Color.FromArgb(255, 240, 240, 240);
            oStyle.EndGradientColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 148, 152, 179);
            oStyle.Placement = E_PLACEMENT.PLC_OFFSETPLACEMENT;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.TextPlacement = E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 10;
            oStyle.OffsetTop = 5;
            oStyle.OffsetBottom = 10;
            oStyle.PredecessorStyle.LineColor = Color.FromArgb(255, 160, 160, 160);
            oStyle.MilestoneStyle.ShapeIndex = GRE_FIGURETYPE.FT_DIAMOND;
            oStyle.MilestoneStyle.FillColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.MilestoneStyle.BorderColor = Color.FromArgb(255, 0, 0, 255);
            oStyle.PredecessorStyle.XOffset = 4;
            oStyle.PredecessorStyle.YOffset = 4;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("SummaryStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.StartGradientColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.EndGradientColor = Color.FromArgb(255, 240, 240, 240);
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.BackColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.FillMode = GRE_FILLMODE.FM_UPPERHALFFILLED;
            oStyle.Placement = E_PLACEMENT.PLC_OFFSETPLACEMENT;
            oStyle.OffsetTop = 5;
            oStyle.OffsetBottom = 10;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.TextPlacement = E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 10;
            oStyle.PredecessorStyle.LineColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.TaskStyle.StartShapeIndex = GRE_FIGURETYPE.FT_PROJECTDOWN;
            oStyle.TaskStyle.EndShapeIndex = GRE_FIGURETYPE.FT_PROJECTDOWN;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("NodeStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 197, 206, 216);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.CustomBorderStyle.Left = false;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("CellStyleKeyColumn");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 197, 206, 216);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.CustomBorderStyle.Left = false;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 4;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ClientAreaStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_NONE;

            ActiveGanttCSNCtl1.Treeview.Images = true;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = true;
            ActiveGanttCSNCtl1.Treeview.TreeLines = false;

            clsColumn oColumn;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("ID", "", 30, "");
            oColumn.StyleIndex = "ColumnStyle";

            oColumn = ActiveGanttCSNCtl1.Columns.Add("Task Name", "", 300, "");
            oColumn.StyleIndex = "ColumnStyle";

            ActiveGanttCSNCtl1.TreeviewColumnIndex = 2;

            ActiveGanttCSNCtl1.ScrollBarSeparator.Style.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            ActiveGanttCSNCtl1.ScrollBarSeparator.Style.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            ActiveGanttCSNCtl1.ScrollBarSeparator.Style.BackColor = Color.FromArgb(255, 164, 196, 237);

            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.StyleIndex = "ScrollBar";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.NormalStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.PressedStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.DisabledStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.NormalStyleIndex = "ThumbButtonV";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.PressedStyleIndex = "ThumbButtonV";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.DisabledStyleIndex = "ThumbButtonV";

            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.StyleIndex = "ScrollBar";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.NormalStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.PressedStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.DisabledStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.NormalStyleIndex = "ThumbButtonH";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.PressedStyleIndex = "ThumbButtonH";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.DisabledStyleIndex = "ThumbButtonH";

            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.StyleIndex = "ScrollBar";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ArrowButtons.NormalStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ArrowButtons.PressedStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ArrowButtons.DisabledStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ThumbButton.NormalStyleIndex = "ThumbButtonH";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ThumbButton.PressedStyleIndex = "ThumbButtonH";
            ActiveGanttCSNCtl1.TimeLineScrollBar.ScrollBar.ThumbButton.DisabledStyleIndex = "ThumbButtonH";

            ActiveGanttCSNCtl1.Style.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            ActiveGanttCSNCtl1.Style.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            ActiveGanttCSNCtl1.Style.BorderColor = Color.FromArgb(255, 122, 151, 193);
            ActiveGanttCSNCtl1.Style.BorderWidth = 1;

            ActiveGanttCSNCtl1.Splitter.Type = E_SPLITTERTYPE.SA_USERDEFINED;
            ActiveGanttCSNCtl1.Splitter.Width = 4;
            ActiveGanttCSNCtl1.Splitter.SetColor(1, Color.FromArgb(255, 197, 206, 216));
            ActiveGanttCSNCtl1.Splitter.SetColor(2, Color.FromArgb(255, 255, 255, 255));
            ActiveGanttCSNCtl1.Splitter.SetColor(3, Color.FromArgb(255, 255, 255, 255));
            ActiveGanttCSNCtl1.Splitter.SetColor(4, Color.FromArgb(255, 197, 206, 216));
            ActiveGanttCSNCtl1.Splitter.Position = 285;

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
                oRow.Node.StyleIndex = "NodeStyle";
                oRow.ClientAreaStyleIndex = "ClientAreaStyle";
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
            oView.TimeLine.StyleIndex = "TimeLine";

            ActiveGanttCSNCtl1.CurrentView = "1";

            ActiveGanttCSNCtl1.Tasks.Add("", "K1", new DateTime(2013, 3, 1), new DateTime(2014, 3, 1), "SS", "SummaryStyle");

            ActiveGanttCSNCtl1.Tasks.Add("", "K5", new DateTime(2013, 3, 1), new DateTime(2014, 3, 1), "TS", "TaskStyle");


        }

        private void fSTL_MSP2007_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
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
    public partial class fSTL_CR : Form
    {

        private const string mp_sFontName = "Tahoma";

        public fSTL_CR()
        {
            InitializeComponent();
        }

        private void fSTL_CR_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            clsStyle oStyle = null;
            clsView oView = null;
            clsTimeBlock oTimeBlock = null;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ScrollBar");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 150, 158, 168);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ArrowButtons");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 150, 158, 168);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("ThumbButton");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oStyle.BackColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.BorderColor = Color.FromArgb(255, 138, 145, 153);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("SplitterStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 109, 122, 136);
            oStyle.EndGradientColor = Color.FromArgb(255, 220, 220, 220);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Columns");
            oStyle.Font = new Font(mp_sFontName, 8, FontStyle.Bold);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 148, 164, 189);
            oStyle.EndGradientColor = Color.FromArgb(255, 178, 199, 228);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;
            oStyle.CustomBorderStyle.Left = false;
            oStyle.CustomBorderStyle.Top = false;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_BOTTOM;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TimeLine");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 148, 164, 189);
            oStyle.EndGradientColor = Color.FromArgb(255, 178, 199, 228);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.CustomBorderStyle.Left = true;
            oStyle.CustomBorderStyle.Top = true;
            oStyle.CustomBorderStyle.Right = false;
            oStyle.CustomBorderStyle.Bottom = true;
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_CUSTOM;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("TimeLineVA");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 148, 164, 189);
            oStyle.EndGradientColor = Color.FromArgb(255, 178, 199, 228);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.DrawTextInVisibleArea = true;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Branch");
            oStyle.Font = new Font(mp_sFontName, 9, FontStyle.Regular);
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 109, 122, 136);
            oStyle.EndGradientColor = Color.FromArgb(255, 179, 199, 229);
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;
            oStyle.TextXMargin = 5;
            oStyle.TextYMargin = 5;
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.ImageAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.ImageAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_BOTTOM;
            oStyle.ImageXMargin = 5;
            oStyle.ImageYMargin = 5;
            oStyle.UseMask = false;

            oStyle = ActiveGanttCSNCtl1.Styles.Add("BranchCA");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 109, 122, 136);
            oStyle.EndGradientColor = Color.FromArgb(255, 179, 199, 229);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Weekend");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_HORIZONTAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 133, 143, 154);
            oStyle.EndGradientColor = Color.FromArgb(255, 172, 183, 194);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Reservation");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;
            oStyle.TextXMargin = 5;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_HORIZONTAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 109, 122, 136);
            oStyle.EndGradientColor = Color.FromArgb(255, 179, 199, 229);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Rental");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;
            oStyle.TextXMargin = 5;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_HORIZONTAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 162, 78, 50);
            oStyle.EndGradientColor = Color.FromArgb(255, 215, 92, 54);

            oStyle = ActiveGanttCSNCtl1.Styles.Add("Maintenance");
            oStyle.Font = new Font(mp_sFontName, 7, FontStyle.Regular);
            oStyle.ForeColor = Color.FromArgb(255, 255, 255, 255);
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;
            oStyle.TextXMargin = 5;
            oStyle.SelectionRectangleStyle.OffsetTop = 0;
            oStyle.SelectionRectangleStyle.OffsetBottom = 0;
            oStyle.SelectionRectangleStyle.OffsetLeft = 0;
            oStyle.SelectionRectangleStyle.OffsetRight = 0;
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_HORIZONTAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 255, 77, 1);
            oStyle.EndGradientColor = Color.FromArgb(255, 244, 172, 43);

            ActiveGanttCSNCtl1.ControlTag = "CarRental";
            ActiveGanttCSNCtl1.Columns.Add("", "", 45, "Columns");
            ActiveGanttCSNCtl1.Columns.Add("", "", 95, "Columns");
            ActiveGanttCSNCtl1.Columns.Add("", "", 250, "Columns");

            ActiveGanttCSNCtl1.Splitter.Position = 340;
            ActiveGanttCSNCtl1.Splitter.Type = E_SPLITTERTYPE.SA_STYLE;
            ActiveGanttCSNCtl1.Splitter.Width = 6;
            ActiveGanttCSNCtl1.Splitter.StyleIndex = "SplitterStyle";

            ActiveGanttCSNCtl1.ScrollBarSeparator.StyleIndex = "ScrollBar";

            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.StyleIndex = "ScrollBar";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.NormalStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.PressedStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ArrowButtons.DisabledStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.NormalStyleIndex = "ThumbButton";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.PressedStyleIndex = "ThumbButton";
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.ThumbButton.DisabledStyleIndex = "ThumbButton";

            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.StyleIndex = "ScrollBar";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.NormalStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.PressedStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ArrowButtons.DisabledStyleIndex = "ArrowButtons";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.NormalStyleIndex = "ThumbButton";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.PressedStyleIndex = "ThumbButton";
            ActiveGanttCSNCtl1.HorizontalScrollBar.ScrollBar.ThumbButton.DisabledStyleIndex = "ThumbButton";

            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("");
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_WEEK;
            oTimeBlock.BaseWeekDay = E_WEEKDAY.WD_FRIDAY;
            oTimeBlock.BaseDate = new DateTime(2013, 1, 1, 0, 0, 0);
            oTimeBlock.DurationFactor = 48;
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;
            oTimeBlock.StyleIndex = "Weekend";

            ActiveGanttCSNCtl1.TierFormat.DayIntervalFormat = "%d";

            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_MINUTE, 30, E_TIERTYPE.ST_MONTH, E_TIERTYPE.ST_DAY, E_TIERTYPE.ST_NOT_VISIBLE);
            oView.TimeLine.TierArea.UpperTier.Height = 17;
            oView.TimeLine.TierArea.UpperTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.UpperTier.StyleIndex = "TimeLineVA";
            oView.TimeLine.TierArea.MiddleTier.Height = 17;
            oView.TimeLine.TierArea.MiddleTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.MiddleTier.StyleIndex = "TimeLineVA";
            oView.TimeLine.TickMarkArea.Visible = false;
            oView.TimeLine.TickMarkArea.StyleIndex = "TimeLine";
            oView.TimeLine.Style.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oView.TimeLine.Style.BackgroundMode = GRE_BACKGROUNDMODE.FP_SOLID;
            oView.TimeLine.Style.BackColor = Color.FromArgb(255, 0, 0, 0);
            oView.ClientArea.Grid.VerticalLines = true;
            oView.ClientArea.Grid.SnapToGrid = true;

            ActiveGanttCSNCtl1.CurrentView = "1";

            int i = 0;
            clsRow oRow;
            for (i = 1; i <= 100; i++)
            {
                oRow = ActiveGanttCSNCtl1.Rows.Add("K" + i.ToString());
                if (oRow.Index % 5 == 0 | oRow.Index == 1)
                {
                    oRow.Node.Depth = 0;
                    oRow.MergeCells = true;
                    oRow.StyleIndex = "Branch";
                    oRow.ClientAreaStyleIndex = "BranchCA";
                }
                else
                {
                    oRow.Node.Depth = 1;
                }
            }

            ActiveGanttCSNCtl1.Tasks.Add("Reservation", "K2", new DateTime(2013, 1, 2), new DateTime(2013, 1, 7), "RES", "Reservation");

            ActiveGanttCSNCtl1.Tasks.Add("Rental", "K3", new DateTime(2013, 1, 2), new DateTime(2013, 1, 7), "REN", "Rental");

            ActiveGanttCSNCtl1.Tasks.Add("Maintenance", "K4", new DateTime(2013, 1, 2), new DateTime(2013, 1, 7), "MAI", "Maintenance");

            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(new DateTime(2013, 1, 1));


        }

        private void fSTL_CR_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }
    }
}
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
using System.Data.SqlServerCe;
using System.Data;

namespace AGCSNCON
{

    public partial class fWBSProject : System.Windows.Forms.Form
    {

        private DateTime mp_dtStartDate;
        private DateTime mp_dtEndDate;
        private const string mp_sFontName = "Tahoma";

        private bool mp_bBluePercentagesVisible = true;
        private bool mp_bGreenPercentagesVisible = true;
        private bool mp_bRedPercentagesVisible = true;

        internal SqlCeConnection mp_oConn;


        #region "Constructors"

        internal fWBSProject()
        {
            InitializeComponent();
        }

        #endregion

        #region "Form Loaded / Form Closed"

        private void fWBSProject_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            mp_oConn = new SqlCeConnection(modData.g_GetConnectionString());
            mp_oConn.Open();

            mp_dtStartDate = new DateTime();
            mp_dtEndDate = new DateTime();

            this.Text = "Work Breakdown Structure (WBS) Project Management Example - ActiveGanttCSN";


            this.Left = Owner.Left;
            this.Top = Owner.Top;

            clsStyle oStyle = null;
            clsView oView = null;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);

            oStyle = ActiveGanttCSNCtl1.Configuration.DefaultPercentageStyle.Clone("InvisiblePercentages");
            oStyle = ActiveGanttCSNCtl1.Styles.Add("SelectedPredecessor");
            oStyle.PredecessorStyle.LineColor = Color.FromArgb(255, 0, 128, 0);

            ActiveGanttCSNCtl1.ControlTag = "WBSProject";
            ActiveGanttCSNCtl1.AllowRowMove = true;
            ActiveGanttCSNCtl1.AllowRowSize = true;
            ActiveGanttCSNCtl1.AddMode = E_ADDMODE.AT_BOTH;
            ActiveGanttCSNCtl1.Configuration.RowHighlightedBackColor = Color.FromArgb(255, 176, 196, 222);

            clsColumn oColumn;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("ID", "", 30, "");
            oColumn.AllowTextEdit = true;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("Task Name", "", 300, "");
            oColumn.AllowTextEdit = true;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("StartDate", "", 125, "");
            oColumn.AllowTextEdit = true;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("EndDate", "", 125, "");
            oColumn.AllowTextEdit = true;

            ActiveGanttCSNCtl1.TreeviewColumnIndex = 2;

            ActiveGanttCSNCtl1.Treeview.Images = true;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = true;
            ActiveGanttCSNCtl1.Treeview.TreeviewMode = E_TREEVIEWMODE.TM_EXPANDCOLLAPSEICONS;
            ActiveGanttCSNCtl1.Treeview.TreeLines = false;
            ActiveGanttCSNCtl1.ToolTip.Font = new Font(mp_sFontName, 8, FontStyle.Regular);
            ActiveGanttCSNCtl1.Splitter.Position = 255;

            LoadTasks();

            ActiveGanttCSNCtl1.Rows.UpdateTree();

            //// Start one month before the first task:
            ActiveGanttCSNCtl1.TimeLineScrollBar.StartDate = ActiveGanttCSNCtl1.MathLib.DateTimeAdd(E_INTERVAL.IL_MONTH, -1, mp_dtStartDate);
            ActiveGanttCSNCtl1.TimeLineScrollBar.Interval = E_INTERVAL.IL_HOUR;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Factor = 1;
            ActiveGanttCSNCtl1.TimeLineScrollBar.SmallChange = 6;
            ActiveGanttCSNCtl1.TimeLineScrollBar.LargeChange = 480;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Max = 4000;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Value = 0;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Enabled = true;
            ActiveGanttCSNCtl1.TimeLineScrollBar.Visible = true;

            ActiveGanttCSNCtl1.TierFormat.QuarterIntervalFormat = "yyyy";
            ActiveGanttCSNCtl1.TierFormat.MonthIntervalFormat = "MMM";

            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_HOUR, 24, E_TIERTYPE.ST_CUSTOM, E_TIERTYPE.ST_NOT_VISIBLE, E_TIERTYPE.ST_MONTH);
            oView.TimeLine.TierArea.UpperTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.UpperTier.Height = 17;
            oView.TimeLine.TierArea.UpperTier.Interval = E_INTERVAL.IL_QUARTER;
            oView.TimeLine.TierArea.UpperTier.Factor = 1;
            oView.TimeLine.TierArea.LowerTier.BackgroundMode = E_TIERBACKGROUNDMODE.ETBGM_STYLE;
            oView.TimeLine.TierArea.LowerTier.Height = 17;
            oView.TimeLine.TickMarkArea.Visible = false;
            oView.ClientArea.DetectConflicts = false;

            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 12;

            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 6;

            ActiveGanttCSNCtl1.CurrentView = "2";

            if (ActiveGanttCSNCtl1.Printer != null)
            {
                ActiveGanttCSNCtl1.Printer.Orientation = GRE_ORIENTATION.OT_LANDSCAPE;
                ActiveGanttCSNCtl1.Printer.MarginLeft = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginTop = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginRight = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginBottom = 200; //2.0"
                ActiveGanttCSNCtl1.Printer.HeadingsInEveryPage = true;
                ActiveGanttCSNCtl1.Printer.KeepRowsTogether = true;
                ActiveGanttCSNCtl1.Printer.ColumnsInEveryPage = true;
                ActiveGanttCSNCtl1.Printer.Columns = 1;
                ActiveGanttCSNCtl1.Printer.KeepColumnsTogether = true;
                ActiveGanttCSNCtl1.Printer.KeepTimeIntervalsTogether = true;
                ActiveGanttCSNCtl1.Printer.Interval = E_INTERVAL.IL_MONTH;
                ActiveGanttCSNCtl1.Printer.Factor = 1;
            }

            ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.FirstVisibleRow = 21;


            ActiveGanttCSNCtl1.Redraw();
        }

        private void fWBSProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp_oConn.Close();
        }

        #endregion

        #region "Form Resizing"

        private void fWBSProject_Resize(object sender, System.EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, menuStrip1, toolStrip1);
        }

        #endregion

        #region "ActiveGantt Event Handlers"

        private void ActiveGanttCSNCtl1_CustomTierDraw(object sender, CustomTierDrawEventArgs e)
        {
            if (e.Interval == E_INTERVAL.IL_QUARTER)
            {
                e.Text = e.StartDate.Year.ToString() + " Q" + ActiveGanttCSNCtl1.MathLib.Quarter(e.StartDate).ToString();
            }
        }

        private void ActiveGanttCSNCtl1_NodeChecked(object sender, AGCSN.NodeEventArgs e)
        {
            clsRow oRow;
            oRow = ActiveGanttCSNCtl1.Rows.Item(e.Index.ToString());
            oRow.Highlighted = oRow.Node.Checked;
        }

        private void ActiveGanttCSNCtl1_ControlMouseDown(object sender, AGCSN.MouseEventArgs e)
        {
            if ((e.EventTarget == E_EVENTTARGET.EVT_TASK | e.EventTarget == E_EVENTTARGET.EVT_SELECTEDTASK) & e.Button == E_MOUSEBUTTONS.BTN_RIGHT)
            {
                fWBSProjectTaskView oForm = null;
                oForm = new fWBSProjectTaskView(this, ActiveGanttCSNCtl1.MathLib.GetTaskIndexByPosition(e.X, e.Y));
                oForm.ShowDialog(this);
                e.Cancel = true;
            }
        }

        private void ActiveGanttCSNCtl1_ObjectAdded(object sender, AGCSN.ObjectAddedEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                case E_EVENTTARGET.EVT_MILESTONE:
                    clsTask oTask = null;
                    oTask = GetTaskByRowKey(ActiveGanttCSNCtl1.Tasks.Item(e.TaskIndex.ToString()).RowKey);
                    oTask.StartDate = ActiveGanttCSNCtl1.Tasks.Item(e.TaskIndex.ToString()).StartDate;
                    oTask.EndDate = ActiveGanttCSNCtl1.Tasks.Item(e.TaskIndex.ToString()).EndDate;
                    UpdateTask(oTask.Index);
                    ActiveGanttCSNCtl1.Tasks.Remove(e.TaskIndex.ToString());
                    break;
                case E_EVENTTARGET.EVT_PREDECESSOR:
                    ActiveGanttCSNCtl1.Predecessors.Item(e.PredecessorObjectIndex.ToString()).StyleIndex = "T1";
                    ActiveGanttCSNCtl1.Predecessors.Item(e.PredecessorObjectIndex.ToString()).WarningStyleIndex = "TW1";
                    ActiveGanttCSNCtl1.Predecessors.Item(e.PredecessorObjectIndex.ToString()).SelectedStyleIndex = "SelectedPredecessor";
                    InsertPredecessor(e.PredecessorObjectIndex);
                    break;
            }
        }

        private void ActiveGanttCSNCtl1_CompleteObjectChange(object sender, AGCSN.ObjectStateChangedEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                    UpdateTask(e.Index);
                    break;
                case E_EVENTTARGET.EVT_PERCENTAGE:
                    int lTaskIndex = 0;
                    lTaskIndex = ActiveGanttCSNCtl1.Tasks.Item(ActiveGanttCSNCtl1.Percentages.Item(e.Index.ToString()).TaskKey).Index;
                    UpdateTask(lTaskIndex);
                    break;
            }
        }

        private void ActiveGanttCSNCtl1_ToolTipOnMouseHover(object sender, AGCSN.ToolTipEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                case E_EVENTTARGET.EVT_SELECTEDTASK:
                case E_EVENTTARGET.EVT_PERCENTAGE:
                case E_EVENTTARGET.EVT_SELECTEDPERCENTAGE:
                    TaskToolTipCalculateDim(e);
                    return;
            }
            ActiveGanttCSNCtl1.ToolTip.Visible = false;
        }

        private void ActiveGanttCSNCtl1_OnMouseHoverToolTipDraw(object sender, AGCSN.ToolTipEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                case E_EVENTTARGET.EVT_SELECTEDTASK:
                case E_EVENTTARGET.EVT_PERCENTAGE:
                case E_EVENTTARGET.EVT_SELECTEDPERCENTAGE:
                    TaskToolTipDraw(e);
                    e.CustomDraw = true;
                    return;
            }
        }

        private void ActiveGanttCSNCtl1_ToolTipOnMouseMove(object sender, AGCSN.ToolTipEventArgs e)
        {
            switch (e.Operation)
            {
                case E_OPERATION.EO_PERCENTAGESIZING:
                case E_OPERATION.EO_TASKMOVEMENT:
                case E_OPERATION.EO_TASKSTRETCHLEFT:
                case E_OPERATION.EO_TASKSTRETCHRIGHT:
                    TaskToolTipCalculateDim(e);
                    return;
            }
            ActiveGanttCSNCtl1.ToolTip.Visible = false;
        }

        private void ActiveGanttCSNCtl1_OnMouseMoveToolTipDraw(object sender, AGCSN.ToolTipEventArgs e)
        {
            switch (e.Operation)
            {
                case E_OPERATION.EO_PERCENTAGESIZING:
                case E_OPERATION.EO_TASKMOVEMENT:
                case E_OPERATION.EO_TASKSTRETCHLEFT:
                case E_OPERATION.EO_TASKSTRETCHRIGHT:
                    TaskToolTipDraw(e);
                    e.CustomDraw = true;
                    return;
            }
        }

        private void ActiveGanttCSNCtl1_ControlMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta == 0 | ActiveGanttCSNCtl1.VerticalScrollBar.Visible == false)
            {
                return;
            }
            int lDelta = -(e.Delta / 100);
            int lInitialValue = ActiveGanttCSNCtl1.VerticalScrollBar.Value;
            if ((ActiveGanttCSNCtl1.VerticalScrollBar.Value + lDelta < 1))
            {
                ActiveGanttCSNCtl1.VerticalScrollBar.Value = 1;
            }
            else if (((ActiveGanttCSNCtl1.VerticalScrollBar.Value + lDelta) > ActiveGanttCSNCtl1.VerticalScrollBar.Max))
            {
                ActiveGanttCSNCtl1.VerticalScrollBar.Value = ActiveGanttCSNCtl1.VerticalScrollBar.Max;
            }
            else
            {
                ActiveGanttCSNCtl1.VerticalScrollBar.Value = ActiveGanttCSNCtl1.VerticalScrollBar.Value + lDelta;
            }
            ActiveGanttCSNCtl1.Redraw();
        }

        private void ActiveGanttCSNCtl1_EndTextEdit(object sender, TextEditEventArgs e)
        {
            if (e.ObjectType == E_TEXTOBJECTTYPE.TOT_NODE)
            {
                clsRow oRow;
                string sRowKey = null;
                oRow = ActiveGanttCSNCtl1.Rows.Item(e.ObjectIndex.ToString());
                sRowKey = oRow.Key;
                sRowKey = sRowKey.Replace("K", "");
                SqlCeCommand oCmd = null;
                string sSQL = "UPDATE tb_GuysStThomas SET Description='" + e.Text + "' WHERE lTaskID = " + sRowKey;
                oCmd = new SqlCeCommand(sSQL, mp_oConn);
                oCmd.ExecuteNonQuery();
            }
        }

        private void ActiveGanttCSNCtl1_PagePrint(object sender, PagePrintEventArgs e)
        {
            System.Drawing.Font oFont = new System.Drawing.Font("Arial", 8);


            System.Drawing.Color oColor;
            int X2 = 0;
            oColor = ActiveGanttCSNCtl1.Configuration.DefaultControlStyle.BorderColor;
            if ((e.X2 - e.X1) < System.Convert.ToInt32(e.PageWidth * 0.85))
            {
                X2 = System.Convert.ToInt32(e.PageWidth - ActiveGanttCSNCtl1.Printer.MarginRight);
            }
            else
            {
                X2 = e.X2;
            }

            ActiveGanttCSNCtl1.Drawing.DrawLine(e.X1, e.PageHeight - 190, X2, e.PageHeight - 190, oColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 10, e.PageHeight - 190, e.X1 + 290, e.PageHeight - 70, "ActiveGanttCSN Scheduler Component" + Environment.NewLine + "WBS Project Example", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);

            int lLine = e.PageHeight - 180;
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 310, lLine, e.X1 + 400, lLine + 10, "Red Summary", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 450, lLine, e.X1 + 600, lLine + 10, "S3", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 450, lLine, e.X1 + 525, lLine + 5, "SP3", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);

            lLine = e.PageHeight - 160;
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 310, lLine, e.X1 + 400, lLine + 10, "Green Summary", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 450, lLine, e.X1 + 600, lLine + 10, "S2", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 450, lLine, e.X1 + 525, lLine + 5, "SP2", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);

            lLine = e.PageHeight - 140;
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 310, lLine, e.X1 + 400, lLine + 10, "Task", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 445, lLine, e.X1 + 605, lLine + 10, "T1", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 445, lLine + 3, e.X1 + 525, lLine + 7, "P1", "", false, null, GRE_DRAWINGOBJECT.DO_GENERAL);

            lLine = e.PageHeight - 120;
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 310, lLine, e.X1 + 400, lLine + 10, "Milestone", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);
            ActiveGanttCSNCtl1.Drawing.DrawObject(e.X1 + 450, lLine, e.X1 + 450, lLine + 10, "T1", "", false, null, GRE_DRAWINGOBJECT.DO_MILESTONE);

            ActiveGanttCSNCtl1.Drawing.DrawLine(e.X1 + 300, e.PageHeight - 190, e.X1 + 300, e.PageHeight - 70, oColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);

            ActiveGanttCSNCtl1.Drawing.DrawLine(e.X1, e.PageHeight - 70, X2, e.PageHeight - 70, oColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1, e.PageHeight - 70, X2, e.PageHeight - 50, "Page " + e.PageNumber, GRE_HORIZONTALALIGNMENT.HAL_CENTER, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, oFont);


            ActiveGanttCSNCtl1.Drawing.DrawBorder(e.X1, e.Y1, X2, e.PageHeight - 50, oColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1);
        }

        #endregion

        #region "Tooltips"

        private void TaskToolTipCalculateDim(AGCSN.ToolTipEventArgs e)
        {
            int Index = ActiveGanttCSNCtl1.MathLib.GetTaskIndexByPosition(e.X, e.Y);
            clsToolTip oToolTip = ActiveGanttCSNCtl1.ToolTip;
            string sRowKey = null;
            if (Index == -1)
            {
                sRowKey = ActiveGanttCSNCtl1.Rows.Item(ActiveGanttCSNCtl1.MathLib.GetRowIndexByPosition(e.Y).ToString()).Key;
            }
            else
            {
                sRowKey = ActiveGanttCSNCtl1.Tasks.Item(Index.ToString()).RowKey;
            }
            string sRowText = ActiveGanttCSNCtl1.Rows.Item(sRowKey).Text;
            System.Drawing.StringFormat TextFlags = new System.Drawing.StringFormat();
            System.Drawing.SizeF oSize = new System.Drawing.SizeF(0, 0);
            TextFlags.Alignment = StringAlignment.Center;
            oSize = ActiveGanttCSNCtl1.Drawing.GraphicsInfo().MeasureString(sRowText, ActiveGanttCSNCtl1.ToolTip.Font, 300 - 18);
            oToolTip.AutomaticSizing = false;
            oToolTip.Left = e.X + 20;
            oToolTip.Top = System.Convert.ToInt32(e.Y - (oSize.Height + 60) - 20);
            oToolTip.Width = 300;
            oToolTip.Height = System.Convert.ToInt32(oSize.Height + 60);
            if (ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Width < oToolTip.Width)
            {
                oToolTip.Visible = false;
                return;
            }
            if (ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Height < oToolTip.Height)
            {
                oToolTip.Visible = false;
                return;
            }
            if (oToolTip.Left < ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Left)
            {
                oToolTip.Left = ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Left;
            }
            if (oToolTip.Top < ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Top)
            {
                oToolTip.Top = ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Top;
            }
            if (ActiveGanttCSNCtl1.ToolTip.Left + ActiveGanttCSNCtl1.ToolTip.Width > ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Right)
            {
                ActiveGanttCSNCtl1.ToolTip.Left = ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Right - oToolTip.Width;
            }
            if (oToolTip.Top + oToolTip.Height > ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Bottom)
            {
                oToolTip.Top = ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Bottom - oToolTip.Height;
            }
            oToolTip.Visible = true;
        }

        private void TaskToolTipDraw(AGCSN.ToolTipEventArgs e)
        {
            int Index = 0;
            string sRowKey = null;
            string sTaskKey = null;
            DateTime dtStartDate = new DateTime();
            DateTime dtEndDate = new DateTime();
            float fPercentage = 0;
            clsPercentage oPercentage = null;
            clsTask oTask = null;
            if (e.ToolTipType == E_TOOLTIPTYPE.TPT_HOVER)
            {
                Index = ActiveGanttCSNCtl1.MathLib.GetTaskIndexByPosition(e.X, e.Y);
                if (Index < 1)
                {
                    return;
                }
                oTask = ActiveGanttCSNCtl1.Tasks.Item(Index.ToString());
                sRowKey = oTask.RowKey;
                dtStartDate = oTask.StartDate;
                dtEndDate = oTask.EndDate;
                sTaskKey = oTask.Key;
                oPercentage = GetPercentageByTaskKey(sTaskKey);
                if ((oPercentage != null))
                {
                    fPercentage = GetPercentageByTaskKey(sTaskKey).Percent * 100;
                }
            }
            else
            {
                Index = e.TaskIndex;
                if (e.Operation == E_OPERATION.EO_TASKMOVEMENT)
                {
                    sRowKey = ActiveGanttCSNCtl1.Rows.Item(e.InitialRowIndex.ToString()).Key;
                }
                else
                {
                    sRowKey = ActiveGanttCSNCtl1.Rows.Item(e.RowIndex.ToString()).Key;
                }
                dtStartDate = e.StartDate;
                dtEndDate = e.EndDate;
                sTaskKey = ActiveGanttCSNCtl1.Tasks.Item(Index.ToString()).Key;
                if (e.Operation == E_OPERATION.EO_PERCENTAGESIZING)
                {
                    fPercentage = (e.X - e.XStart) / (e.XEnd - e.XStart) * 100;
                }
                else
                {
                    if ((oPercentage != null))
                    {
                        fPercentage = oPercentage.Percent * 100;
                    }
                }
            }
            string sStartDate = dtStartDate.ToString("ddd MMM d, yyyy");
            string sEndDate = dtEndDate.ToString("ddd MMM d, yyyy");
            string sFrom = "From: " + sStartDate + " To " + sEndDate;
            string sDuration = "Duration: " + ActiveGanttCSNCtl1.MathLib.DateTimeDiff(E_INTERVAL.IL_DAY, dtStartDate, dtEndDate) + " days";
            string sRowText = ActiveGanttCSNCtl1.Rows.Item(sRowKey).Text;
            string sPercentage = fPercentage.ToString("00.00");
            clsTextFlags oTextFlags = new clsTextFlags();
            oTextFlags.HorizontalAlignment = GRE_HORIZONTALALIGNMENT.HAL_CENTER;
            oTextFlags.VerticalAlignment = GRE_VERTICALALIGNMENT.VAL_TOP;
            oTextFlags.WordWrap = true;
            System.Drawing.Image oImage = ActiveGanttCSNCtl1.Rows.Item(sRowKey).Node.Image;
            System.Drawing.SizeF oSize = new System.Drawing.SizeF(0, 0);
            oSize = e.Graphics.MeasureString(sRowText, ActiveGanttCSNCtl1.ToolTip.Font, e.X2 - (e.X1 + 18));
            ActiveGanttCSNCtl1.Drawing.PaintImage(oImage, e.X1 + 2, e.Y1 + 2, e.X1 + 17, e.Y1 + 17);
            ActiveGanttCSNCtl1.Drawing.DrawText(e.X1 + 18, e.Y1, e.X2, e.Y2, sRowText, oTextFlags, Color.Black, ActiveGanttCSNCtl1.ToolTip.Font);
            ActiveGanttCSNCtl1.Drawing.DrawLine(e.X1, System.Convert.ToInt32(e.Y1 + oSize.Height + 6), e.X2, System.Convert.ToInt32(e.Y1 + oSize.Height + 6), Color.Black, GRE_LINEDRAWSTYLE.LDS_SOLID, 2);
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 2, System.Convert.ToInt32(e.Y1 + oSize.Height + 10), e.X1 + 300, System.Convert.ToInt32(e.Y1 + oSize.Height + 25), sDuration, GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, ActiveGanttCSNCtl1.ToolTip.Font);
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 2, System.Convert.ToInt32(e.Y1 + oSize.Height + 25), e.X1 + 300, System.Convert.ToInt32(e.Y1 + oSize.Height + 40), sFrom, GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, ActiveGanttCSNCtl1.ToolTip.Font);
            ActiveGanttCSNCtl1.Drawing.DrawAlignedText(e.X1 + 2, System.Convert.ToInt32(e.Y1 + oSize.Height + 40), e.X1 + 300, System.Convert.ToInt32(e.Y1 + oSize.Height + 55), "Percent Completed: " + sPercentage + "%", GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_CENTER, Color.Black, ActiveGanttCSNCtl1.ToolTip.Font);
        }

        #endregion

        #region "Form Properties"

        #endregion

        #region "Functions"

        private void UpdateTask(int Index)
        {
            AGCSN.clsPercentage oPercentage = GetPercentageByTaskKey(ActiveGanttCSNCtl1.Tasks.Item(Index.ToString()).Key);
            clsTask oTask;
            oTask = ActiveGanttCSNCtl1.Tasks.Item(Index.ToString());
            SetTaskGridColumns(oTask);
            string sRowKey = oTask.RowKey;
            DateTime dtStartDate = oTask.StartDate;
            DateTime dtEndDate = oTask.EndDate;
            clsNode oNode = ActiveGanttCSNCtl1.Rows.Item(sRowKey).Node;
            SqlCeCommand oCmd = null;
            string sSQL = "UPDATE tb_GuysStThomas SET " + "dtStartDate = " + modData.g_ConvertDate(dtStartDate) + ", dtEndDate = " + modData.g_ConvertDate(dtEndDate) + ", fPercentCompleted = " + oPercentage.Percent + " WHERE lTaskID = " + sRowKey.Replace("K", "");
            oCmd = new SqlCeCommand(sSQL, mp_oConn);
            oCmd.ExecuteNonQuery();
            UpdateSummary(ref oNode);
        }

        private void InsertPredecessor(int PredecessorObjectIndex)
        {
            clsPredecessor oPredecessor;
            string sPredecessorTaskKey = null;
            string sSuccessorTaskKey = null;
            oPredecessor = ActiveGanttCSNCtl1.Predecessors.Item(PredecessorObjectIndex.ToString());
            sPredecessorTaskKey = oPredecessor.PredecessorTask.Key.Replace("T", "");
            sSuccessorTaskKey = oPredecessor.SuccessorTask.Key.Replace("T", "");
            SqlCeCommand oCmd = null;
            string sSQL = "INSERT INTO tb_GuysStThomas_Predecessors (lPredecessorTaskID, lSuccessorTaskID, lType, lLagFactor, lLagInterval) VALUES (" + sPredecessorTaskKey + "," + sSuccessorTaskKey + "," + System.Convert.ToInt32(oPredecessor.PredecessorType).ToString() + "," + oPredecessor.LagFactor.ToString() + "," + System.Convert.ToInt32(oPredecessor.LagInterval).ToString() + ")";
            oCmd = new SqlCeCommand(sSQL, mp_oConn);
            oCmd.ExecuteNonQuery();
        }

        private void UpdateSummary(ref clsNode oNode)
        {
            SqlCeCommand oCmd = null;
            string sSQL = "";
            clsNode oParentNode = null;
            clsTask oSummaryTask = null;
            clsPercentage oSummaryPercentage = null;
            oParentNode = oNode.Parent();
            while ((oParentNode != null))
            {
                oSummaryTask = GetTaskByRowKey(oParentNode.Row.Key);
                oSummaryPercentage = GetPercentageByTaskKey(oSummaryTask.Key);
                if ((oSummaryTask != null))
                {
                    clsTask oChildTask = null;
                    clsPercentage oChildPercentage = null;
                    clsNode oChildNode = null;
                    DateTime dtSumStartDate = new DateTime();
                    DateTime dtSumEndDate = new DateTime();
                    int lPercentagesCount = 0;
                    float fPercentagesSum = 0;
                    float fPercentageAvg = 0;
                    oChildNode = oParentNode.Child();
                    while ((oChildNode != null))
                    {
                        oChildTask = GetTaskByRowKey(oChildNode.Row.Key);
                        oChildPercentage = GetPercentageByTaskKey(oChildTask.Key);
                        lPercentagesCount = lPercentagesCount + 1;
                        fPercentagesSum = fPercentagesSum + oChildPercentage.Percent;
                        if ((oChildTask != null))
                        {
                            if (dtSumStartDate.Ticks == 0)
                            {
                                dtSumStartDate = oChildTask.StartDate;
                            }
                            else
                            {
                                if (oChildTask.StartDate < dtSumStartDate)
                                {
                                    dtSumStartDate = oChildTask.StartDate;
                                }
                            }
                            if (dtSumEndDate.Ticks == 0)
                            {
                                dtSumEndDate = oChildTask.EndDate;
                            }
                            else
                            {
                                if (oChildTask.EndDate > dtSumEndDate)
                                {
                                    dtSumEndDate = oChildTask.EndDate;
                                }
                            }
                        }
                        oChildNode = oChildNode.NextSibling();
                    }
                    fPercentageAvg = fPercentagesSum / lPercentagesCount;
                    oSummaryTask.StartDate = dtSumStartDate;
                    oSummaryTask.EndDate = dtSumEndDate;
                    SetTaskGridColumns(oSummaryTask);
                    oSummaryPercentage.Percent = fPercentageAvg;
                    sSQL = "UPDATE tb_GuysStThomas SET " + "dtStartDate = " + modData.g_ConvertDate(dtSumStartDate) + ", dtEndDate = " + modData.g_ConvertDate(dtSumEndDate) + ", fPercentCompleted = " + oSummaryPercentage.Percent + " WHERE lTaskID = " + oSummaryTask.RowKey.Replace("K", "");
                    oCmd = new SqlCeCommand(sSQL, mp_oConn);
                    oCmd.ExecuteNonQuery();
                }
                oParentNode = oParentNode.Parent();
            }
        }

        private clsTask GetTaskByRowKey(string sRowKey)
        {
            foreach (clsTask oTask in ActiveGanttCSNCtl1.Tasks)
            {
                if (oTask.RowKey == sRowKey)
                {
                    return oTask;
                }
            }
            return null;
        }

        private clsPercentage GetPercentageByTaskKey(string sTaskKey)
        {
            foreach (clsPercentage oPercentage in ActiveGanttCSNCtl1.Percentages)
            {
                if (oPercentage.TaskKey == sTaskKey)
                {
                    return oPercentage;
                }
            }
            return null;
        }

        #endregion

        #region "Toolbar Buttons"

        private void cmdSaveXML_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void cmdLoadXML_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void cmdPrint_Click(object sender, System.EventArgs e)
        {
            Print();
        }

        private void cmdZoomIn_Click(object sender, System.EventArgs e)
        {
            if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) < 3)
            {
                ActiveGanttCSNCtl1.CurrentView = System.Convert.ToString(System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) + 1);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void cmdZoomOut_Click(object sender, System.EventArgs e)
        {
            if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) > 1)
            {
                ActiveGanttCSNCtl1.CurrentView = System.Convert.ToString(System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) - 1);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void cmdBluePercentages_Click(object sender, System.EventArgs e)
        {
            mp_bBluePercentagesVisible = !mp_bBluePercentagesVisible;
            foreach (clsPercentage oPercentage in ActiveGanttCSNCtl1.Percentages)
            {
                if (oPercentage.StyleIndex == "P1")
                {
                    oPercentage.Visible = mp_bBluePercentagesVisible;
                }
            }
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdGreenPercentages_Click(object sender, System.EventArgs e)
        {
            mp_bGreenPercentagesVisible = !mp_bGreenPercentagesVisible;
            foreach (clsPercentage oPercentage in ActiveGanttCSNCtl1.Percentages)
            {
                if (oPercentage.StyleIndex == "SP2")
                {
                    oPercentage.Visible = mp_bGreenPercentagesVisible;
                }
            }
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdRedPercentages_Click(object sender, System.EventArgs e)
        {
            mp_bRedPercentagesVisible = !mp_bRedPercentagesVisible;
            foreach (clsPercentage oPercentage in ActiveGanttCSNCtl1.Percentages)
            {
                if (oPercentage.StyleIndex == "SP3")
                {
                    oPercentage.Visible = mp_bRedPercentagesVisible;
                }
            }
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdProperties_Click(object sender, EventArgs e)
        {
            fWBSPProperties oForm = new fWBSPProperties(this);
            oForm.ShowDialog();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            ActiveGanttCSNCtl1.CheckPredecessors();
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdToolTips_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.ToolTipsVisible = !ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.ToolTipsVisible;
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdHelp_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("http://www.sourcecodestore.com/Article.aspx?ID=17");
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region "Menu Items"

        private void mnuSaveXML_Click(object sender, System.EventArgs e)
        {
            SaveXML();
        }

        private void mnuLoadXML_Click(object sender, System.EventArgs e)
        {
            LoadXML();
        }

        private void mnuPrint_Click(object sender, System.EventArgs e)
        {
            Print();
        }

        private void mnuClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void mnuCheckBoxes_Click(object sender, System.EventArgs e)
        {
            mnuCheckBoxes.Checked = !mnuCheckBoxes.Checked;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = mnuCheckBoxes.Checked;
            ActiveGanttCSNCtl1.Redraw();
        }

        private void mnuImages_Click(object sender, System.EventArgs e)
        {
            mnuImages.Checked = !mnuImages.Checked;
            ActiveGanttCSNCtl1.Treeview.Images = mnuImages.Checked;
            ActiveGanttCSNCtl1.Redraw();
        }

        private void mnuFullColumnSelect_Click(object sender, System.EventArgs e)
        {
            mnuFullColumnSelect.Checked = !mnuFullColumnSelect.Checked;
            ActiveGanttCSNCtl1.Treeview.FullColumnSelect = mnuFullColumnSelect.Checked;
            ActiveGanttCSNCtl1.Redraw();
        }

        #endregion

        #region "Toolbar Button & Menu Item Functions"

        private void SaveXML()
        {
            saveFileDialog1.Title = "Save As XML";
            saveFileDialog1.FileName = "AGCSN_WBSP";
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveGanttCSNCtl1.WriteXML(saveFileDialog1.FileName);
            }
        }

        private void LoadXML()
        {
            fLoadXML oForm = new fLoadXML();
            oForm.ShowDialog(this);
        }

        private void Print()
        {
            if (ActiveGanttCSNCtl1.Printer != null)
            {
                fPrintDialog oForm = new fPrintDialog(ActiveGanttCSNCtl1, new DateTime(2006, 8, 1, 0, 0, 0), new DateTime(2010, 1, 1, 0, 0, 0));
                oForm.ShowDialog(this);
            }
        }

        #endregion

        #region "Load Data"

        public void LoadTasks()
        {
            clsRow oRow = null;
            clsTask oTask = null;
            SqlCeCommand oCmd = null;
            SqlCeDataReader oReader = null;
            oCmd = new SqlCeCommand("SELECT * FROM tb_GuysStThomas", mp_oConn);
            oReader = oCmd.ExecuteReader();
            while (oReader.Read() == true)
            {
                oRow = ActiveGanttCSNCtl1.Rows.Add("K" + System.Convert.ToString(oReader["lTaskID"]), (System.String)oReader["sDescription"]);
                oRow.Cells.Item("1").Text = Convert.ToString(oReader["lTaskID"]);
                oRow.Cells.Item("1").StyleIndex = "CH";
                oRow.Height = 20;
                oRow.Node.AllowTextEdit = true;
                if ((System.String)oReader["sTaskType"] == "F")
                {
                    if ((System.Int32)oReader["lDepth"] == 0)
                    {
                        oRow.Node.Image = imgTreeView.Images[0];
                        oRow.Node.ExpandedImage = imgTreeView.Images[1];
                        oRow.Node.StyleIndex = "NB";
                    }
                    else
                    {
                        oRow.Node.Image = imgTreeView.Images[2];
                        oRow.Node.StyleIndex = "NR";
                    }
                }
                else if ((System.String)oReader["sTaskType"] == "A")
                {
                    oRow.Node.StyleIndex = "NR";
                    oRow.Node.Image = imgTreeView.Images[3];
                    oRow.Node.CheckBoxVisible = true;
                }
                oRow.Node.Depth = (System.Int32)oReader["lDepth"];
                oRow.Node.ImageVisible = true;
                oRow.Node.AllowTextEdit = true;
                if ((!DBNull.Value.Equals(oReader["dtStartDate"]) & !DBNull.Value.Equals(oReader["dtEndDate"])))
                {
                    if ((mp_dtStartDate.Ticks == 0))
                    {
                        mp_dtStartDate = Globals.FromDate((System.DateTime)oReader["dtStartDate"]);
                    }
                    else
                    {
                        if ((Globals.FromDate((System.DateTime)oReader["dtStartDate"]) < mp_dtStartDate))
                        {
                            mp_dtStartDate = Globals.FromDate((System.DateTime)oReader["dtStartDate"]);
                        }
                    }
                    if ((mp_dtEndDate.Ticks == 0))
                    {
                        mp_dtEndDate = Globals.FromDate((System.DateTime)oReader["dtEndDate"]);
                    }
                    else
                    {
                        if ((Globals.FromDate((System.DateTime)oReader["dtEndDate"]) > mp_dtEndDate))
                        {
                            mp_dtEndDate = Globals.FromDate((System.DateTime)oReader["dtEndDate"]);
                        }
                    }
                    oTask = ActiveGanttCSNCtl1.Tasks.Add("", "K" + System.Convert.ToString(oReader["lTaskID"]), Globals.FromDate((System.DateTime)oReader["dtStartDate"]), Globals.FromDate((System.DateTime)oReader["dtEndDate"]), "T" + System.Convert.ToString(oReader["lTaskID"]), "", "");
                    SetTaskGridColumns(oTask);
                    if ((System.Boolean)oReader["bSummary"] == true)
                    {
                        //// Prevent user from moving/sizing summary tasks
                        oTask.AllowedMovement = E_MOVEMENTTYPE.MT_MOVEMENTDISABLED;
                        oTask.AllowStretchLeft = false;
                        oTask.AllowStretchRight = false;
                        //// Prevent user from adding tasks in these Rows
                        oRow.Container = false;
                        //// Apply Summary Style 
                        if (oRow.Node.Depth == 0)
                        {
                            oTask.StyleIndex = "S3";
                            ActiveGanttCSNCtl1.Percentages.Add("T" + System.Convert.ToString(oReader["lTaskID"]), "SP3", (System.Single)oReader["fPercentCompleted"], "");
                        }
                        else if (oRow.Node.Depth == 1)
                        {
                            oTask.StyleIndex = "S2";
                            ActiveGanttCSNCtl1.Percentages.Add("T" + System.Convert.ToString(oReader["lTaskID"]), "SP2", (System.Single)oReader["fPercentCompleted"], "");
                        }
                        ActiveGanttCSNCtl1.Percentages.Item(ActiveGanttCSNCtl1.Percentages.Count.ToString()).AllowSize = false;
                    }
                    else
                    {
                        oTask.AllowedMovement = E_MOVEMENTTYPE.MT_RESTRICTEDTOROW;
                        oTask.StyleIndex = "T1";
                        oTask.WarningStyleIndex = "TW1";
                        if ((System.Boolean)oReader["bHasTasks"] == false)
                        {
                            oTask.Visible = false;
                            //// Prevent user from adding tasks in these rows
                            oRow.Container = false;
                            ActiveGanttCSNCtl1.Percentages.Add("T" + System.Convert.ToString(oReader["lTaskID"]), "InvisiblePercentages", (System.Single)oReader["fPercentCompleted"], "");
                            ActiveGanttCSNCtl1.Percentages.Item(ActiveGanttCSNCtl1.Percentages.Count.ToString()).AllowSize = false;
                        }
                        else
                        {
                            ActiveGanttCSNCtl1.Percentages.Add("T" + System.Convert.ToString(oReader["lTaskID"]), "P1", (System.Single)oReader["fPercentCompleted"], "");
                        }
                    }
                }
            }
            oReader.Close();
            oCmd = new SqlCeCommand("SELECT * FROM tb_GuysStThomas_Predecessors", mp_oConn);
            oReader = oCmd.ExecuteReader();
            while (oReader.Read())
            {
                clsPredecessor oPredecessor;
                oPredecessor = ActiveGanttCSNCtl1.Predecessors.Add("T" + oReader["lSuccessorTaskID"].ToString(), "T" + oReader["lPredecessorTaskID"].ToString(), (E_CONSTRAINTTYPE)oReader["lType"], "", "T1");
                oPredecessor.LagFactor = (int)oReader["lLagFactor"];
                oPredecessor.LagInterval = (E_INTERVAL)oReader["lLagInterval"];
                oPredecessor.WarningStyleIndex = "TW1";
                oPredecessor.SelectedStyleIndex = "SelectedPredecessor";
            }
        }

        private void SetTaskGridColumns(clsTask oTask)
        {
            oTask.Row.Cells.Item("3").Text = oTask.StartDate.ToString("MM/dd/yyyy");
            oTask.Row.Cells.Item("4").Text = oTask.EndDate.ToString("MM/dd/yyyy");
        }

        #endregion


    }
}
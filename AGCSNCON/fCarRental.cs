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
using AGCSNCON;

namespace AGCSNCON
{

	public partial class fCarRental : System.Windows.Forms.Form
	{

        private HPE_ADDMODE mp_yAddMode = HPE_ADDMODE.AM_RENTAL;
        private int mp_lZoom;
        private string mp_sEditRowKey;
        private string mp_sEditTaskKey;

        private const string mp_sFontName = "Tahoma";

        private clsCR_Objects mp_oObjects;


        #region "Constructors"

        internal fCarRental()
        {
            InitializeComponent();
        }

        #endregion

        #region "Form Loaded / Form Closed"

        private void fCarRental_Load(object sender, System.EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            mp_oObjects = new clsCR_Objects(ActiveGanttCSNCtl1);

            this.Text = "Vehicle Rental/Fleet Control Roster Example - ";
            this.Text = this.Text + "SQL Server CE 4.0 data source - ";
            this.Text = this.Text + "ActiveGanttCSN Version: " + ActiveGanttCSNCtl1.Version;

            clsStyle oStyle = null;
            clsView oView = null;
            clsTimeBlock oTimeBlock = null;

            ////If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            ////you can preview all available Templates.
            ////Or you can also build your own:
            ////fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            ////fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_HGRAD_BLUE_BELL, E_OBJECTTEMPLATE.STO_VARIATION_1);

            oStyle = ActiveGanttCSNCtl1.Styles.Item("RET1");
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;

            oStyle = ActiveGanttCSNCtl1.Styles.Item("RET2");
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;

            oStyle = ActiveGanttCSNCtl1.Styles.Item("RET3");
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;



            oStyle = ActiveGanttCSNCtl1.Configuration.DefaultColumnStyle.Clone("Branch");
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_LEFT;
            oStyle.TextAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_TOP;
            oStyle.TextXMargin = 5;
            oStyle.TextYMargin = 5;
            oStyle.BorderColor = Color.FromArgb(255, 0, 0, 0);
            oStyle.BorderStyle = GRE_BORDERSTYLE.SBR_SINGLE;
            oStyle.ImageAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.ImageAlignmentVertical = GRE_VERTICALALIGNMENT.VAL_BOTTOM;
            oStyle.ImageXMargin = 5;
            oStyle.ImageYMargin = 5;

            oStyle = ActiveGanttCSNCtl1.Configuration.DefaultColumnStyle.Clone("BranchCA");

            oStyle = ActiveGanttCSNCtl1.Styles.Add("SplitterStyle");
            oStyle.Appearance = E_STYLEAPPEARANCE.SA_FLAT;
            oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_GRADIENT;
            oStyle.GradientFillMode = GRE_GRADIENTFILLMODE.GDT_VERTICAL;
            oStyle.StartGradientColor = Color.FromArgb(255, 109, 122, 136);
            oStyle.EndGradientColor = Color.FromArgb(255, 220, 220, 220);

            ActiveGanttCSNCtl1.ControlTag = "CarRental";
            ActiveGanttCSNCtl1.Columns.Add("", "", 60, "");
            ActiveGanttCSNCtl1.Columns.Add("", "", 95, "");
            ActiveGanttCSNCtl1.Columns.Add("", "", 250, "");

            ActiveGanttCSNCtl1.Splitter.Position = 380;
            ActiveGanttCSNCtl1.Splitter.Type = E_SPLITTERTYPE.SA_STYLE;
            ActiveGanttCSNCtl1.Splitter.Width = 6;
            ActiveGanttCSNCtl1.Splitter.StyleIndex = "SplitterStyle";

            ActiveGanttCSNCtl1.Culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            ActiveGanttCSNCtl1.Culture.DateTimeFormat.AMDesignator = ActiveGanttCSNCtl1.Culture.DateTimeFormat.AMDesignator.ToLower();
            ActiveGanttCSNCtl1.Culture.DateTimeFormat.PMDesignator = ActiveGanttCSNCtl1.Culture.DateTimeFormat.PMDesignator.ToLower();

            oTimeBlock = ActiveGanttCSNCtl1.TimeBlocks.Add("");
            oTimeBlock.TimeBlockType = E_TIMEBLOCKTYPE.TBT_RECURRING;
            oTimeBlock.RecurringType = E_RECURRINGTYPE.RCT_WEEK;
            oTimeBlock.BaseWeekDay = E_WEEKDAY.WD_FRIDAY;
            oTimeBlock.BaseDate = new DateTime(2013, 1, 1, 0, 0, 0);
            oTimeBlock.DurationFactor = 48;
            oTimeBlock.DurationInterval = E_INTERVAL.IL_HOUR;

            oView = ActiveGanttCSNCtl1.Views.Add(E_INTERVAL.IL_MINUTE, 30, E_TIERTYPE.ST_CUSTOM, E_TIERTYPE.ST_CUSTOM, E_TIERTYPE.ST_CUSTOM);
            oView.TimeLine.TierArea.UpperTier.Height = 17;
            oView.TimeLine.TierArea.UpperTier.Interval = E_INTERVAL.IL_MONTH;
            oView.TimeLine.TierArea.UpperTier.Factor = 1;
            oView.TimeLine.TierArea.MiddleTier.Height = 17;
            oView.TimeLine.TierArea.MiddleTier.Interval = E_INTERVAL.IL_DAY;
            oView.TimeLine.TierArea.MiddleTier.Factor = 1;
            oView.TimeLine.TierArea.LowerTier.Interval = E_INTERVAL.IL_HOUR;
            oView.TimeLine.TierArea.LowerTier.Factor = 12;
            oView.TimeLine.TierArea.LowerTier.Height = 17;
            oView.TimeLine.TickMarkArea.Visible = false;
            oView.ClientArea.Grid.VerticalLines = true;
            oView.ClientArea.Grid.SnapToGrid = true;
            ActiveGanttCSNCtl1.CurrentView = oView.Index.ToString();
            Zoom = 5;

            //// Load Data
            mp_oObjects.LoadData();

            ActiveGanttCSNCtl1.Rows.UpdateTree();

            drpMode.Items.Add("Add Reservation Mode");
            drpMode.Items.Add("Add Rental Mode");
            drpMode.Items.Add("Add Maintenance Mode");
            drpMode.SelectedIndex = 0;

            if (ActiveGanttCSNCtl1.Printer != null)
            {
                ActiveGanttCSNCtl1.Printer.Orientation = GRE_ORIENTATION.OT_LANDSCAPE;
                ActiveGanttCSNCtl1.Printer.MarginLeft = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginTop = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginRight = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.MarginBottom = 50; //0.5"
                ActiveGanttCSNCtl1.Printer.HeadingsInEveryPage = false;
                ActiveGanttCSNCtl1.Printer.KeepRowsTogether = true;
                ActiveGanttCSNCtl1.Printer.ColumnsInEveryPage = false;
                ActiveGanttCSNCtl1.Printer.KeepColumnsTogether = true;
                ActiveGanttCSNCtl1.Printer.KeepTimeIntervalsTogether = false;
            }

            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(new DateTime(2009, 6, 9));

            ActiveGanttCSNCtl1.Redraw();

        }

        #endregion

        #region "Form Resizing"

        private void fCarRental_Resize(object sender, System.EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, menuStrip1, toolStrip1);
        }

        #endregion

        #region "ActiveGantt Event Handlers"

        private void ActiveGanttCSNCtl1_CustomTierDraw(object sender, AGCSN.CustomTierDrawEventArgs e)
        {
            if (e.Interval == E_INTERVAL.IL_HOUR & e.Factor == 12)
            {
                e.Text = e.StartDate.ToString("tt").ToUpper();
            }
            if (e.Interval == E_INTERVAL.IL_MONTH & e.Factor == 1)
            {
                e.Text = e.StartDate.ToString("MMMM yyyy");
            }
            if (e.Interval == E_INTERVAL.IL_DAY & e.Factor == 1)
            {
                e.Text = e.StartDate.ToString("ddd d");
            }
        }

        private void ActiveGanttCSNCtl1_ObjectAdded(object sender, AGCSN.ObjectAddedEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                    string sTaskKey = mp_oObjects.Tasks.Add(e.TaskIndex, Mode);
                    if (Mode == HPE_ADDMODE.AM_RESERVATION | Mode == HPE_ADDMODE.AM_RENTAL)
                    {
                        fCarRentalReservation oForm = new fCarRentalReservation(PRG_DIALOGMODE.DM_ADD, this, sTaskKey);
                        oForm.ShowDialog(this);
                    }
                    else if (Mode == HPE_ADDMODE.AM_MAINTENANCE)
                    {
                        mp_oObjects.Tasks.Item(sTaskKey).UpdateCaption();
                    }
                    break;
            }
        }

        private void ActiveGanttCSNCtl1_CompleteObjectChange(object sender, AGCSN.ObjectStateChangedEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_TASK:
                    string sTaskKey = ActiveGanttCSNCtl1.Tasks.Item(e.Index.ToString()).Key;
                    mp_oObjects.Tasks.Item(sTaskKey).TaskChanged();
                    break;
                case E_EVENTTARGET.EVT_ROW:
                    if (e.ChangeType == E_CHANGETYPE.CT_MOVE)
                    {
                        mp_oObjects.Rows.UpdateOrder();
                    }
                    break;
            }
        }

        private void ActiveGanttCSNCtl1_ControlMouseDown(object sender, AGCSN.MouseEventArgs e)
        {
            switch (e.EventTarget)
            {
                case E_EVENTTARGET.EVT_SELECTEDROW:
                case E_EVENTTARGET.EVT_ROW:
                    if (e.Button == E_MOUSEBUTTONS.BTN_LEFT)
                    {
                        clsRow oRow = null;
                        oRow = ActiveGanttCSNCtl1.Rows.Item(ActiveGanttCSNCtl1.MathLib.GetRowIndexByPosition(e.Y).ToString());
                        if (e.X > ActiveGanttCSNCtl1.Splitter.Position - 20 & e.X < ActiveGanttCSNCtl1.Splitter.Position - 5 & e.Y < oRow.Bottom - 5 & e.Y > oRow.Bottom - 20)
                        {
                            oRow.Node.Expanded = !oRow.Node.Expanded;
                            ActiveGanttCSNCtl1.Redraw();
                            e.Cancel = true;
                        }
                    }
                    else if (e.Button == E_MOUSEBUTTONS.BTN_RIGHT)
                    {
                        e.Cancel = true;
                        mp_sEditRowKey = ActiveGanttCSNCtl1.Rows.Item(ActiveGanttCSNCtl1.MathLib.GetRowIndexByPosition(e.Y).ToString()).Key;
                        mnuRowEdit.Show(ActiveGanttCSNCtl1, new System.Drawing.Point(e.X, e.Y));
                    }
                    break;
                case E_EVENTTARGET.EVT_SELECTEDTASK:
                case E_EVENTTARGET.EVT_TASK:

                    if (e.Button == E_MOUSEBUTTONS.BTN_RIGHT)
                    {
                        e.Cancel = true;
                        mp_sEditTaskKey = ActiveGanttCSNCtl1.Tasks.Item(ActiveGanttCSNCtl1.MathLib.GetTaskIndexByPosition(e.X, e.Y).ToString()).Key;
                        clsCR_Task oTask = mp_oObjects.Tasks.Item(mp_sEditTaskKey);
                        if (oTask.lMode == HPE_ADDMODE.AM_RESERVATION)
                        {
                            mnuConvertToRental.Visible = true;
                        }
                        else
                        {
                            mnuConvertToRental.Visible = false;
                        }
                        if (oTask.lMode == HPE_ADDMODE.AM_RENTAL)
                        {
                            mnuEditTask.Visible = false;
                            mnuTaskLine.Visible = false;
                        }
                        else
                        {
                            mnuEditTask.Visible = true;
                            mnuTaskLine.Visible = true;
                        }
                        mnuTaskEdit.Show(ActiveGanttCSNCtl1, new System.Drawing.Point(e.X, e.Y));
                    }
                    break;
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

        #endregion

        #region "Tooltips"

        #endregion

        #region "Form Properties"

        public clsCR_Objects Objects
        {
            get { return mp_oObjects; }
        }

        public HPE_ADDMODE Mode
        {
            get
            {
                mp_yAddMode = (HPE_ADDMODE)drpMode.SelectedIndex;
                return mp_yAddMode;
            }
        }

        public string AddModeStyle
        {
            get
            {
                switch (drpMode.SelectedIndex)
                {
                    case 0:
                        return "RET2";
                    case 1:
                        return "RET1";
                    case 2:
                        return "RET3";
                }
                return "Error";
            }
        }

        private int Zoom
        {
            get { return mp_lZoom; }
            set
            {
                if (value > 5 | value < 1)
                {
                    return;
                }
                mp_lZoom = value;
                clsView oView = null;
                oView = ActiveGanttCSNCtl1.CurrentViewObject;
                switch (mp_lZoom)
                {
                    case 5:
                        oView.Interval = E_INTERVAL.IL_MINUTE;
                        oView.Factor = 30;
                        oView.ClientArea.Grid.Interval = E_INTERVAL.IL_HOUR;
                        oView.ClientArea.Grid.Factor = 12;
                        oView.TimeLine.TickMarkArea.Visible = false;
                        break;
                    case 4:
                        oView.Interval = E_INTERVAL.IL_MINUTE;
                        oView.Factor = 15;
                        oView.ClientArea.Grid.Interval = E_INTERVAL.IL_HOUR;
                        oView.ClientArea.Grid.Factor = 6;
                        oView.TimeLine.TickMarkArea.Visible = false;
                        break;
                    case 3:
                        oView.Interval = E_INTERVAL.IL_MINUTE;
                        oView.Factor = 10;
                        oView.ClientArea.Grid.Interval = E_INTERVAL.IL_HOUR;
                        oView.ClientArea.Grid.Factor = 3;
                        oView.TimeLine.TickMarkArea.Visible = false;
                        break;
                    case 2:
                        oView.Interval = E_INTERVAL.IL_MINUTE;
                        oView.Factor = 5;
                        oView.ClientArea.Grid.Interval = E_INTERVAL.IL_HOUR;
                        oView.ClientArea.Grid.Factor = 2;
                        oView.TimeLine.TickMarkArea.Visible = true;
                        oView.TimeLine.TickMarkArea.Height = 30;
                        oView.TimeLine.TickMarkArea.TickMarks.Clear();
                        oView.TimeLine.TickMarkArea.TickMarks.Add(E_INTERVAL.IL_HOUR, 6, E_TICKMARKTYPES.TLT_BIG, true, "hh:mmtt");
                        oView.TimeLine.TickMarkArea.TickMarks.Add(E_INTERVAL.IL_HOUR, 1, E_TICKMARKTYPES.TLT_SMALL, false, "h");
                        break;
                    case 1:
                        oView.Interval = E_INTERVAL.IL_MINUTE;
                        oView.Factor = 1;
                        oView.ClientArea.Grid.Interval = E_INTERVAL.IL_MINUTE;
                        oView.ClientArea.Grid.Factor = 15;
                        oView.TimeLine.TickMarkArea.Visible = true;
                        oView.TimeLine.TickMarkArea.Height = 30;
                        oView.TimeLine.TickMarkArea.TickMarks.Clear();
                        oView.TimeLine.TickMarkArea.TickMarks.Add(E_INTERVAL.IL_HOUR, 1, E_TICKMARKTYPES.TLT_BIG, true, "hh:mmtt");
                        break;
                }
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        #endregion

        #region "Functions"

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
            Zoom = Zoom - 1;
        }

        private void cmdZoomOut_Click(object sender, System.EventArgs e)
        {
            Zoom = Zoom + 1;
        }

        private void cmdAddVehicle_Click(object sender, System.EventArgs e)
        {
            fCarRentalVehicle oForm = new fCarRentalVehicle(PRG_DIALOGMODE.DM_ADD, this, null);
            oForm.ShowDialog(this);
        }

        private void cmdAddBranch_Click(object sender, System.EventArgs e)
        {
            fCarRentalBranch oForm = new fCarRentalBranch(PRG_DIALOGMODE.DM_ADD, this, null);
            oForm.ShowDialog(this);
        }

        private void cmdBack2_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, -10 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdBack1_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, -5 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdBack0_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, -1 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdFwd0_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, 1 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdFwd1_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, 5 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdFwd2_Click(object sender, System.EventArgs e)
        {
            ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.Position(ActiveGanttCSNCtl1.MathLib.DateTimeAdd(ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Interval, 10 * ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Grid.Factor, ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.StartDate));
            ActiveGanttCSNCtl1.Redraw();
        }

        private void cmdHelp_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("http://www.sourcecodestore.com/Article.aspx?ID=16");
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region "Menu Items"

        private void mnuSaveXML_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void mnuLoadXML_Click(object sender, EventArgs e)
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

        private void mnuEditRow_Click(object sender, System.EventArgs e)
        {
            clsRow oRow;
            oRow = ActiveGanttCSNCtl1.Rows.Item(mp_sEditRowKey);
            if (oRow.Node.Depth == 1)
            {
                fCarRentalVehicle oForm = new fCarRentalVehicle(PRG_DIALOGMODE.DM_EDIT, this, mp_sEditRowKey);
                oForm.ShowDialog(this);
            }
            else if (oRow.Node.Depth == 0)
            {
                fCarRentalBranch oForm = new fCarRentalBranch(PRG_DIALOGMODE.DM_EDIT, this, mp_sEditRowKey);
                oForm.ShowDialog(this);
            }
        }

        private void mnuDeleteRow_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Row", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                mp_oObjects.Rows.Delete(mp_sEditRowKey);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void mnuEditTask_Click(object sender, System.EventArgs e)
        {
            fCarRentalReservation oForm = new fCarRentalReservation(PRG_DIALOGMODE.DM_EDIT, this, mp_sEditTaskKey);
            oForm.ShowDialog(this);
        }

        private void mnuDeleteTask_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Task", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
            {
                mp_oObjects.Tasks.Delete(mp_sEditTaskKey);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void mnuConvertToRental_Click(object sender, System.EventArgs e)
        {
            clsCR_Task oTask = mp_oObjects.Tasks.Item(mp_sEditTaskKey);
            oTask.lMode = HPE_ADDMODE.AM_RENTAL;
            oTask.Update();
            oTask.UpdateCaption();
            ActiveGanttCSNCtl1.Redraw();
        }

        #endregion

        #region "Toolbar Button & Menu Item Functions"

        private void LoadXML()
        {
            fLoadXML oForm = new fLoadXML();
            oForm.ShowDialog(this);
        }

        private void SaveXML()
        {
            saveFileDialog1.Title = "Save As XML";
            saveFileDialog1.FileName = "AGCSN_CR";
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveGanttCSNCtl1.WriteXML(saveFileDialog1.FileName);
            }
        }

        private void Print()
        {
            if (ActiveGanttCSNCtl1.Printer != null)
            {
                fPrintDialog oForm = new fPrintDialog(ActiveGanttCSNCtl1, new DateTime(2009, 6, 1, 0, 0, 0), new DateTime(2009, 6, 30, 0, 0, 0));
                oForm.ShowDialog(this);
            }
        }

        #endregion





	}
}
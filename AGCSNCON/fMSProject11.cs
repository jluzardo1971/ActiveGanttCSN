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
    public partial class fMSProject11 : Form
    {

        private MSP2003.MP11 oMP11;
        private const string mp_sFontName = "Tahoma";
        private DateTime mp_dtStartDate;
        private DateTime mp_dtEndDate;


        #region "Constructors"

        public fMSProject11()
        {
            InitializeComponent();
        }

        #endregion

        #region "Form Loaded"

        private void fMSProject11_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.Text = "The Source Code Store - ActiveGantt Scheduler Control Version " + ActiveGanttCSNCtl1.Version + " - Microsoft Project 2003 integration using XML Files and the MSP2003 Integration Library";
            this.Left = Owner.Left;
            this.Top = Owner.Top;

            InitializeAG();
            ActiveGanttCSNCtl1.Redraw();

        }

        #endregion

        #region "Form Resizing"

        private void fMSProject11_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, MenuStrip1, ToolStrip1);
        }

        #endregion

        #region "ActiveGantt Event Handlers"

        private void ActiveGanttCSNCtl1_CustomTierDraw(object sender, AGCSN.CustomTierDrawEventArgs e)
        {
            if (e.TierPosition == E_TIERPOSITION.SP_UPPER)
            {
                
                if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) <= 4)
                {
                    
                    if (e.Interval == E_INTERVAL.IL_QUARTER)
                    {
                        e.Text = e.StartDate.Year.ToString() + " Q" + ActiveGanttCSNCtl1.MathLib.Quarter(e.StartDate).ToString();
                    }
                }
                else
                {
                    e.Text = e.StartDate.ToString("MMMM, yyyy");
                }
            }
            else if (e.TierPosition == E_TIERPOSITION.SP_LOWER)
            {
                if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) <= 4)
                {
                    e.Text = e.StartDate.ToString("MMM");
                }
                else
                {
                    e.Text = e.StartDate.ToString("ddd");
                }
            }
        }

        private void ActiveGanttCSNCtl1_ControlMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta == 0 | ActiveGanttCSNCtl1.VerticalScrollBar.Visible == false)
            {
                return;
            }
            int lDelta = -(e.Delta / 50);
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

        #region "Functions"

        private void InitializeAG()
        {
            mp_dtStartDate = new DateTime();
            mp_dtEndDate = new DateTime();


            clsStyle oStyle = null;
            clsView oView = null;

            ControlTemplateSolid oTemplate = new ControlTemplateSolid();
            oTemplate.ControlBorderColor = Color.FromArgb(255, 120, 120, 120);
            oTemplate.HeadingBorderColor = Color.FromArgb(255, 255, 255, 255);
            oTemplate.HeadingForeColor = Color.FromArgb(255, 255, 255, 255);
            oTemplate.RowForeColor = Color.FromArgb(255, 0, 0, 0);
            oTemplate.HeadingBackColor = Color.FromArgb(255, 111, 120, 156);
            oTemplate.TreeviewColor = Color.FromArgb(255, 0, 0, 0);
            oTemplate.RowBorderColor = Color.FromArgb(255, 192, 192, 192);
            oTemplate.TimeBlockBackColor = Color.FromArgb(255, 115, 119, 135);

            ActiveGanttCSNCtl1.ApplyTemplateSolid(oTemplate, E_OBJECTTEMPLATE.STO_COLOR_HATCH);

            oStyle = ActiveGanttCSNCtl1.Styles.Item("T1");
            oStyle.TextPlacement = E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT;
            oStyle.TextAlignmentHorizontal = GRE_HORIZONTALALIGNMENT.HAL_RIGHT;
            oStyle.TextXMargin = 30;

            ActiveGanttCSNCtl1.AllowRowMove = true;
            ActiveGanttCSNCtl1.AllowRowSize = true;
            ActiveGanttCSNCtl1.AddMode = E_ADDMODE.AT_BOTH;
            ActiveGanttCSNCtl1.Splitter.Position = 285;
            ActiveGanttCSNCtl1.Treeview.Images = true;
            ActiveGanttCSNCtl1.Treeview.CheckBoxes = true;
            ActiveGanttCSNCtl1.Treeview.TreeLines = false;
            ActiveGanttCSNCtl1.VerticalScrollBar.ScrollBar.TimerInterval = 50;
            ActiveGanttCSNCtl1.ToolTip.Font = new Font(mp_sFontName, 8, FontStyle.Regular);

            clsColumn oColumn;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("ID", "", 30, "");
            oColumn.AllowTextEdit = true;

            oColumn = ActiveGanttCSNCtl1.Columns.Add("Task Name", "", 255, "");
            oColumn.AllowTextEdit = true;

            ActiveGanttCSNCtl1.TreeviewColumnIndex = 2;

            oView = ActiveGanttCSNCtl1.CurrentViewObject.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 12;
            oView.TimeLine.TierArea.UpperTier.TierType = E_TIERTYPE.ST_CUSTOM;
            oView.TimeLine.TierArea.UpperTier.Interval = E_INTERVAL.IL_QUARTER;
            oView.TimeLine.TierArea.UpperTier.Factor = 1;
            oView.TimeLine.TierArea.UpperTier.Height = 17;
            oView.TimeLine.TierArea.MiddleTier.TierType = E_TIERTYPE.ST_NOT_VISIBLE;
            oView.TimeLine.TierArea.LowerTier.TierType = E_TIERTYPE.ST_CUSTOM;
            oView.TimeLine.TierArea.LowerTier.Interval = E_INTERVAL.IL_MONTH;
            oView.TimeLine.TierArea.LowerTier.Factor = 1;
            oView.TimeLine.TierArea.LowerTier.Height = 17;
            oView.TimeLine.TickMarkArea.Visible = false;
            oView.TimeLine.TimeLineScrollBar.StartDate = DateTime.Now;
            oView.TimeLine.TimeLineScrollBar.Interval = E_INTERVAL.IL_HOUR;
            oView.TimeLine.TimeLineScrollBar.Factor = 1;
            oView.TimeLine.TimeLineScrollBar.SmallChange = 48;
            oView.TimeLine.TimeLineScrollBar.LargeChange = 2880;
            oView.TimeLine.TimeLineScrollBar.Max = 24000;
            oView.TimeLine.TimeLineScrollBar.Value = 0;
            oView.TimeLine.TimeLineScrollBar.Enabled = true;
            oView.TimeLine.TimeLineScrollBar.Visible = true;
            oView.ClientArea.DetectConflicts = false;
            oView.ClientArea.Grid.Color = Color.FromArgb(255, 197, 206, 216);


            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 12;

            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 6;

            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 3;

            oView = oView.Clone();
            oView.Interval = E_INTERVAL.IL_HOUR;
            oView.Factor = 1;

            if (ActiveGanttCSNCtl1.Printer != null)
            {
                ActiveGanttCSNCtl1.Printer.Orientation = GRE_ORIENTATION.OT_LANDSCAPE;
                ActiveGanttCSNCtl1.Printer.MarginLeft = 50;
                //0.5"
                ActiveGanttCSNCtl1.Printer.MarginTop = 50;
                //0.5"
                ActiveGanttCSNCtl1.Printer.MarginRight = 50;
                //0.5"
                ActiveGanttCSNCtl1.Printer.MarginBottom = 50;
                //0.5"
                ActiveGanttCSNCtl1.Printer.HeadingsInEveryPage = true;
                ActiveGanttCSNCtl1.Printer.KeepRowsTogether = true;
                ActiveGanttCSNCtl1.Printer.ColumnsInEveryPage = true;
                ActiveGanttCSNCtl1.Printer.Columns = 1;
                ActiveGanttCSNCtl1.Printer.KeepColumnsTogether = true;
                ActiveGanttCSNCtl1.Printer.KeepTimeIntervalsTogether = true;
                ActiveGanttCSNCtl1.Printer.Interval = E_INTERVAL.IL_DAY;
                ActiveGanttCSNCtl1.Printer.Factor = 1;
            }

            ActiveGanttCSNCtl1.TimeLineScrollBarScope = E_OBJECTSCOPE.OS_VIEW;

            ActiveGanttCSNCtl1.CurrentView = "1";

        }

        private void AGSetStartDate(DateTime dtStart)
        {
            foreach(clsView oView in ActiveGanttCSNCtl1.Views)
            {
                oView.TimeLine.TimeLineScrollBar.StartDate = dtStart;
            }
        }

        private void MP11_To_AG()
        {
            clsTask oAGTask;
            clsRow oAGRow;
            mp_dtStartDate = new DateTime();
            mp_dtEndDate = new DateTime();
            //// Load Project Tasks
            foreach (MSP2003.Task oMPTask in oMP11.oTasks)
            {
                oAGRow = ActiveGanttCSNCtl1.Rows.Add("K" + oMPTask.lUID.ToString());
                oAGRow.Cells.Item("1").Text = oMPTask.lUID.ToString();
                oAGRow.Cells.Item("1").StyleIndex = "CH";
                oAGRow.Height = 20;
                oAGTask = ActiveGanttCSNCtl1.Tasks.Add("", "K" + oMPTask.lUID.ToString(), Globals.FromDate(oMPTask.dtStart), Globals.FromDate(oMPTask.dtFinish), "", "", "");
                oAGTask.Key = "K" + oMPTask.lUID.ToString();
                oAGTask.AllowedMovement = E_MOVEMENTTYPE.MT_RESTRICTEDTOROW;
                oAGTask.AllowTextEdit = true;
                if (Globals.FromDate(oMPTask.dtStart) < mp_dtStartDate | (mp_dtStartDate.Ticks == 0))
                {
                    mp_dtStartDate = Globals.FromDate(oMPTask.dtStart);
                }
                if (Globals.FromDate(oMPTask.dtFinish) > mp_dtEndDate | (mp_dtEndDate.Ticks == 0))
                {
                    mp_dtEndDate = Globals.FromDate(oMPTask.dtFinish);
                }
                if (oAGTask.StartDate == oAGTask.EndDate)
                {
                    oAGTask.Text = oAGTask.StartDate.ToString("M/d");
                }
                oAGRow.Node.Depth = oMPTask.lOutlineLevel;
                oAGRow.Node.Text = oMPTask.sName;
                oAGRow.Node.AllowTextEdit = true;
                if (oMPTask.sNotes.Length > 0)
                {
                    oAGRow.Node.Image = ImageList1.Images[0];
                    oAGRow.Node.ImageVisible = true;
                }
            }
            ActiveGanttCSNCtl1.Rows.UpdateTree();
            //// Indent & set Predecessors
            foreach (MSP2003.Task oMPTask in oMP11.oTasks)
            {
                oAGRow = ActiveGanttCSNCtl1.Rows.Item("K" + oMPTask.lUID.ToString());
                oAGTask = ActiveGanttCSNCtl1.Tasks.Item("K" + oMPTask.lUID.ToString());
                if (oAGRow.Node.Children() > 0)
                {
                    oAGTask.StyleIndex = "S1";
                }
                else
                {
                    oAGTask.StyleIndex = "T1";
                }
                foreach (MSP2003.TaskPredecessorLink oMPPredecessor in oMPTask.oPredecessorLink_C)
                {
                    ActiveGanttCSNCtl1.Predecessors.Add("K" + oMPTask.lUID.ToString(), "K" + oMPPredecessor.lPredecessorUID.ToString(), GetAGPredecessorType(oMPPredecessor.yType), "", "T1");
                }
            }
            //Assignments
            foreach (MSP2003.Assignment oAssignment in oMP11.oAssignments)
            {
                oAGTask = ActiveGanttCSNCtl1.Tasks.Item("K" + oAssignment.lTaskUID);
                if (oAGTask.StartDate != oAGTask.EndDate)
                {
                    if (oAssignment.lResourceUID > 0)
                    {
                        if (oAGTask.Text.Length == 0)
                        {
                            oAGTask.Text = oMP11.oResources.Item("K" + oAssignment.lResourceUID).sName;
                        }
                        else
                        {
                            oAGTask.Text = oAGTask.Text + ", " + oMP11.oResources.Item("K" + oAssignment.lResourceUID).sName;
                        }
                    }
                }
            }
            mp_dtStartDate = ActiveGanttCSNCtl1.MathLib.DateTimeAdd(E_INTERVAL.IL_DAY, -3, mp_dtStartDate);
            AGSetStartDate(mp_dtStartDate);
        }

        private AGCSN.E_CONSTRAINTTYPE GetAGPredecessorType(MSP2003.E_TYPE_3 MPPredecessorType)
        {
            switch (MPPredecessorType)
            {
                case MSP2003.E_TYPE_3.T_3_FF:
                    return AGCSN.E_CONSTRAINTTYPE.PCT_END_TO_END;
                case MSP2003.E_TYPE_3.T_3_FS:
                    return AGCSN.E_CONSTRAINTTYPE.PCT_END_TO_START;
                case MSP2003.E_TYPE_3.T_3_SF:
                    return AGCSN.E_CONSTRAINTTYPE.PCT_START_TO_END;
                case MSP2003.E_TYPE_3.T_3_SS:
                    return AGCSN.E_CONSTRAINTTYPE.PCT_START_TO_START;
            }
            return AGCSN.E_CONSTRAINTTYPE.PCT_END_TO_START;
        }

        #endregion

        #region "Toolbar Buttons"

        private void cmdLoadXML_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void cmdSaveXML_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void cmdZoomIn_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) < ActiveGanttCSNCtl1.Views.Count)
            {
                ActiveGanttCSNCtl1.CurrentView = System.Convert.ToString(System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) + 1);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void cmdZoomOut_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) > 1)
            {
                ActiveGanttCSNCtl1.CurrentView = System.Convert.ToString(System.Convert.ToInt32(ActiveGanttCSNCtl1.CurrentView) - 1);
                ActiveGanttCSNCtl1.Redraw();
            }
        }

        private void cmdIndent_Click(object sender, EventArgs e)
        {
            Indent();
        }

        #endregion

        #region "Menu Items"

        private void LoadMSProject2003XMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void SaveMSProject2003XMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Toolbar Button & Menu Item Functions"

        private void LoadXML()
        {
            oMP11 = new MSP2003.MP11();
            OpenFileDialog1.Title = "Load MS-Project 2003 XML File";
            OpenFileDialog1.InitialDirectory = Globals.g_GetAppLocation() + "\\MSP2003\\";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
            if ((OpenFileDialog1.ShowDialog(this) == DialogResult.OK))
            {
                if (ValidateMSP2003(OpenFileDialog1.FileName) == false)
                {
                    MessageBox.Show("The file selected is not a valid Microsoft Project 2003 XML File.", "", MessageBoxButtons.OK);
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ActiveGanttCSNCtl1.Clear();
                    oMP11.ReadXML(OpenFileDialog1.FileName);
                    Cursor.Current = Cursors.WaitCursor;
                    InitializeAG();
                    MP11_To_AG();
                    ActiveGanttCSNCtl1.Redraw();
                    ActiveGanttCSNCtl1.VerticalScrollBar.LargeChange = ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.LastVisibleRow - ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.FirstVisibleRow;
                    ActiveGanttCSNCtl1.Redraw();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void SaveXML()
        {
            SaveFileDialog1.Title = "Save As MS-Project 2003 XML File";
            SaveFileDialog1.InitialDirectory = Globals.g_GetAppLocation() + "\\MSP2003\\";
            SaveFileDialog1.Filter = "XML File|*.xml";
            SaveFileDialog1.OverwritePrompt = true;
            if ((SaveFileDialog1.ShowDialog(this) == DialogResult.OK))
            {
                this.Cursor = Cursors.WaitCursor;
                oMP11.WriteXML(SaveFileDialog1.FileName);
                this.Cursor = Cursors.Default;
            }
        }

        private void Print()
        {
            if (ActiveGanttCSNCtl1.Printer != null)
            {
                if (ActiveGanttCSNCtl1.Rows.Count == 0)
                {
                    return;
                }
                if (mp_dtStartDate.Ticks == 0 | mp_dtEndDate.Ticks == 0)
                {
                    return;
                }
                ActiveGanttCSNCtl1.Printer.Interval = ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.TierArea.LowerTier.Interval;
                ActiveGanttCSNCtl1.Printer.Factor = ActiveGanttCSNCtl1.CurrentViewObject.TimeLine.TierArea.LowerTier.Factor;
                fPrintDialog oForm = new fPrintDialog(ActiveGanttCSNCtl1, mp_dtStartDate, mp_dtEndDate);
                oForm.ShowDialog(this);
            }
        }

        private void Indent()
        {
            OpenFileDialog1.Title = "Load XML File";
            OpenFileDialog1.InitialDirectory = Globals.g_GetAppLocation() + "\\MSP2003\\";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "XML File (*.xml)|*.xml|All Files (*.*)|*.*";
            if ((OpenFileDialog1.ShowDialog(this) == DialogResult.OK))
            {
                SaveFileDialog1.Title = "Save XML File As";
                SaveFileDialog1.InitialDirectory = Globals.g_GetAppLocation() + "\\MSP2003\\";
                SaveFileDialog1.Filter = "XML File|*.xml";
                SaveFileDialog1.OverwritePrompt = true;
                if ((SaveFileDialog1.ShowDialog(this) == DialogResult.OK))
                {
                    if ((OpenFileDialog1.FileName != SaveFileDialog1.FileName))
                    {
                        this.Cursor = Cursors.WaitCursor;
                        System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
                        xDoc.Load(OpenFileDialog1.FileName);
                        System.Xml.XmlTextWriter oWriter = new System.Xml.XmlTextWriter(SaveFileDialog1.FileName, System.Text.Encoding.UTF8);
                        oWriter.IndentChar = '\t';
                        oWriter.Formatting = System.Xml.Formatting.Indented;
                        xDoc.Save(oWriter);
                        oWriter.Close();
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private bool ValidateMSP2003(string sFileName)
        {
            string sFile = Globals.g_ReadFile(sFileName);
            if (sFile.Contains("<Project ") == false)
            {
                return false;
            }
            if (sFile.Contains("<SaveVersion>") == true)
            {
                return false;
            }
            return true;
        }

        #endregion

    }
}
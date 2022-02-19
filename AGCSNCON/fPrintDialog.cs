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


namespace AGCSNCON
{
    public partial class fPrintDialog : System.Windows.Forms.Form
	{

        internal ActiveGanttCSNCtl mp_oControl;
        private bool mp_bLoaded = false;

        #region "Constructors"

        public fPrintDialog(ActiveGanttCSNCtl oControl, DateTime dtStartDate, DateTime dtEndDate)
        {
            InitializeComponent();
            mp_oControl = oControl;

            Globals.InitNumCtrl(numSDYear, 0, 3000, dtStartDate.Year);
            Globals.InitNumCtrl(numSDMonth, 1, 12, dtStartDate.Month);
            Globals.InitNumCtrl(numSDDay, 1, 31, dtStartDate.Day);
            Globals.InitNumCtrl(numSDHour, 0, 23, dtStartDate.Hour);
            Globals.InitNumCtrl(numSDMinute, 0, 59, dtStartDate.Minute);
            Globals.InitNumCtrl(numSDSecond, 0, 59, dtStartDate.Second);

            Globals.InitNumCtrl(numEDYear, 0, 3000, dtEndDate.Year);
            Globals.InitNumCtrl(numEDMonth, 1, 12, dtEndDate.Month);
            Globals.InitNumCtrl(numEDDay, 1, 31, dtEndDate.Day);
            Globals.InitNumCtrl(numEDHour, 0, 23, dtEndDate.Hour);
            Globals.InitNumCtrl(numEDMinute, 0, 59, dtEndDate.Minute);
            Globals.InitNumCtrl(numEDSecond, 0, 59, dtEndDate.Second);
        }

        #endregion

        #region "Form Load/Closed"

        private void fPrintDialog_Load(object sender, EventArgs e)
        {
            this.txtStartPage.GotFocus += new System.EventHandler(this.txtStartPage_GotFocus);
            this.txtEndPage.GotFocus += new System.EventHandler(this.txtEndPage_GotFocus);


            int lIndex = 0;
            //// Printer Name
            for (lIndex = 0; lIndex <= System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count - 1; lIndex++)
            {
                cboPrinters.Items.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters[lIndex]);
                if ((System.Drawing.Printing.PrinterSettings.InstalledPrinters[lIndex] == mp_oControl.Printer.PrinterName))
                {
                    cboPrinters.SelectedIndex = lIndex;
                }
            }

            //// Orientation
            for (lIndex = 0; lIndex <= 1; lIndex++)
            {
                GRE_ORIENTATION yOrientation = (GRE_ORIENTATION)lIndex;
                cboOrientation.Items.Add(yOrientation.ToString());
            }
            cboOrientation.SelectedIndex = System.Convert.ToInt32(mp_oControl.Printer.Orientation);

            //// Resolutions
            for (lIndex = 0; lIndex <= 4; lIndex++)
            {
                GRE_PRINTERRESOLUTION yResolution = (GRE_PRINTERRESOLUTION)lIndex;
                cboResolution.Items.Add(yResolution.ToString());
            }
            cboResolution.SelectedIndex = System.Convert.ToInt32(mp_oControl.Printer.PrinterResolution);

            //// Intervals
            for (lIndex = 0; lIndex <= 10; lIndex++)
            {
                E_INTERVAL yInterval = (E_INTERVAL)lIndex;
                cboInterval.Items.Add(yInterval.ToString());
            }
            cboInterval.SelectedIndex = System.Convert.ToInt32(mp_oControl.Printer.Interval);

            Globals.InitNumCtrl(numScale, 10, 200, mp_oControl.Printer.Scale * 100);


            chkKeepRowsTogether.Checked = mp_oControl.Printer.KeepRowsTogether;
            chkKeepColumnsTogether.Checked = mp_oControl.Printer.KeepColumnsTogether;
            chkKeepTimeIntervalsTogether.Checked = mp_oControl.Printer.KeepTimeIntervalsTogether;
            chkHeadingsInEveryPage.Checked = mp_oControl.Printer.HeadingsInEveryPage;

            chkColumnsInEveryPage.Checked = mp_oControl.Printer.ColumnsInEveryPage;
            Globals.InitNumCtrl(numColumns, 0, mp_oControl.Columns.Count, mp_oControl.Printer.Columns);

            chkShowAllColumns.Checked = mp_oControl.Printer.ShowAllColumns;

            Globals.InitNumCtrl(numMarginLeft, 0, 3, mp_oControl.Printer.MarginLeft / 100, 0.1, 2);
            Globals.InitNumCtrl(numMarginTop, 0, 3, mp_oControl.Printer.MarginTop / 100, 0.1, 2);
            Globals.InitNumCtrl(numMarginRight, 0, 3, mp_oControl.Printer.MarginRight / 100, 0.1, 2);
            Globals.InitNumCtrl(numMarginBottom, 0, 3, mp_oControl.Printer.MarginBottom / 100, 0.1, 2);

            Globals.InitNumCtrl(numStartRow, 1, mp_oControl.Rows.Count, 1);
            Globals.InitNumCtrl(numEndRow, 1, mp_oControl.Rows.Count, mp_oControl.Rows.Count);

            Globals.InitNumCtrl(numFactor, 1, 1000, mp_oControl.Printer.Factor);


            optAll.Checked = true;

            txtStartPage.Text = "1";
            if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
            {
                mp_GetNumberOfPages();
                mp_bLoaded = true;
            }
            mp_UpdateVisibility();
        }

        private void fPrintDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp_oControl.Printer.Terminate();
        }

        #endregion

        #region "Properties"

        private DateTime StartDateCtrl
        {
            get { return new DateTime(System.Convert.ToInt32(numSDYear.Value), System.Convert.ToInt32(numSDMonth.Value), System.Convert.ToInt32(numSDDay.Value), System.Convert.ToInt32(numSDHour.Value), System.Convert.ToInt32(numSDMinute.Value), System.Convert.ToInt32(numSDSecond.Value)); }
            set
            {
                numSDYear.Value = System.Convert.ToDecimal(value.Year);
                numSDMonth.Value = System.Convert.ToDecimal(value.Month);
                numSDDay.Value = System.Convert.ToDecimal(value.Day);
                numSDHour.Value = System.Convert.ToDecimal(value.Hour);
                numSDMinute.Value = System.Convert.ToDecimal(value.Minute);
                numSDSecond.Value = System.Convert.ToDecimal(value.Second);
            }
        }

        private DateTime EndDateCtrl
        {
            get { return new DateTime(System.Convert.ToInt32(numEDYear.Value), System.Convert.ToInt32(numEDMonth.Value), System.Convert.ToInt32(numEDDay.Value), System.Convert.ToInt32(numEDHour.Value), System.Convert.ToInt32(numEDMinute.Value), System.Convert.ToInt32(numEDSecond.Value)); }
            set
            {
                numEDYear.Value = System.Convert.ToDecimal(value.Year);
                numEDMonth.Value = System.Convert.ToDecimal(value.Month);
                numEDDay.Value = System.Convert.ToDecimal(value.Day);
                numEDHour.Value = System.Convert.ToDecimal(value.Hour);
                numEDMinute.Value = System.Convert.ToDecimal(value.Minute);
                numEDSecond.Value = System.Convert.ToDecimal(value.Second);
            }
        }


        #endregion

        #region "Control Updating"

        private void mp_UpdateVisibility()
        {
            if (chkKeepTimeIntervalsTogether.Checked == false)
            {
                lblInterval.Visible = false;
                cboInterval.Visible = false;
                lblFactor.Visible = false;
                numFactor.Visible = false;
            }
            if (chkKeepColumnsTogether.Checked == false)
            {
                chkKeepTimeIntervalsTogether.Visible = false;
                lblInterval.Visible = false;
                cboInterval.Visible = false;
                lblFactor.Visible = false;
                numFactor.Visible = false;
            }
            if (chkKeepTimeIntervalsTogether.Checked == true & chkKeepColumnsTogether.Checked == true)
            {
                chkKeepTimeIntervalsTogether.Visible = true;
                lblInterval.Visible = true;
                cboInterval.Visible = true;
                lblFactor.Visible = true;
                numFactor.Visible = true;
            }
        }

        private void cboPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.PrinterName != (System.String)cboPrinters.Items[cboPrinters.SelectedIndex])
            {
                mp_oControl.Printer.PrinterName = (System.String)cboPrinters.Items[cboPrinters.SelectedIndex];
                if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
                {
                    cboOrientation.SelectedIndex = System.Convert.ToInt32(mp_oControl.Printer.Orientation);
                }
            }
        }

        private void cboOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Orientation != (GRE_ORIENTATION)cboOrientation.SelectedIndex)
            {
                mp_oControl.Printer.Orientation = (GRE_ORIENTATION)cboOrientation.SelectedIndex;
                mp_GetNumberOfPages();
            }
        }

        private void cboResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((GRE_PRINTERRESOLUTION)cboResolution.SelectedIndex == GRE_PRINTERRESOLUTION.PR_CUSTOM)
            {
                lblDPIX.Visible = true;
                lblDPIY.Visible = true;
                numDPIX.Visible = true;
                numDPIY.Visible = true;
                numDPIX.Value = mp_oControl.Printer.HorizontalDPI;
                numDPIY.Value = mp_oControl.Printer.VerticalDPI;
            }
            else
            {
                lblDPIX.Visible = false;
                lblDPIY.Visible = false;
                numDPIX.Visible = false;
                numDPIY.Visible = false;
            }
            if (mp_oControl.Printer.PrinterResolution != (GRE_PRINTERRESOLUTION)cboResolution.SelectedIndex)
            {
                mp_oControl.Printer.PrinterResolution = (GRE_PRINTERRESOLUTION)cboResolution.SelectedIndex;
            }
        }

        private void cboInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Interval != (E_INTERVAL)cboInterval.SelectedIndex)
            {
                mp_oControl.Printer.Interval = (E_INTERVAL)cboInterval.SelectedIndex;
                mp_GetNumberOfPages();
            }
        }

        private void numFactor_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Factor != System.Convert.ToInt32(numFactor.Value))
            {
                mp_oControl.Printer.Factor = System.Convert.ToInt32(numFactor.Value);
                mp_GetNumberOfPages();
            }
        }

        private void numDPIX_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.HorizontalDPI != System.Convert.ToInt32(numDPIX.Value))
            {
                mp_oControl.Printer.HorizontalDPI = System.Convert.ToInt32(numDPIX.Value);
            }
        }

        private void numDPIY_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.VerticalDPI != System.Convert.ToInt32(numDPIY.Value))
            {
                mp_oControl.Printer.VerticalDPI = System.Convert.ToInt32(numDPIY.Value);
            }
        }

        private void numScale_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Scale != System.Convert.ToSingle(numScale.Value / 100))
            {
                mp_oControl.Printer.Scale = System.Convert.ToSingle(numScale.Value / 100);
                mp_GetNumberOfPages();
            }
        }

        private void chkKeepRowsTogether_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.KeepRowsTogether != chkKeepRowsTogether.Checked)
            {
                mp_oControl.Printer.KeepRowsTogether = chkKeepRowsTogether.Checked;
                mp_GetNumberOfPages();
            }
        }

        private void chkKeepColumnsTogether_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.KeepColumnsTogether != chkKeepColumnsTogether.Checked)
            {
                mp_oControl.Printer.KeepColumnsTogether = chkKeepColumnsTogether.Checked;
                mp_GetNumberOfPages();
            }
            mp_UpdateVisibility();
        }

        private void chkKeepTimeIntervalsTogether_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.KeepTimeIntervalsTogether != chkKeepTimeIntervalsTogether.Checked)
            {
                mp_oControl.Printer.KeepTimeIntervalsTogether = chkKeepTimeIntervalsTogether.Checked;
                mp_GetNumberOfPages();
            }
            mp_UpdateVisibility();
        }

        private void chkHeadingsInEveryPage_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.HeadingsInEveryPage != chkHeadingsInEveryPage.Checked)
            {
                mp_oControl.Printer.HeadingsInEveryPage = chkHeadingsInEveryPage.Checked;
                mp_GetNumberOfPages();
            }
        }

        private void chkColumnsInEveryPage_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.ColumnsInEveryPage != chkColumnsInEveryPage.Checked)
            {
                mp_oControl.Printer.ColumnsInEveryPage = chkColumnsInEveryPage.Checked;
                mp_GetNumberOfPages();
            }
        }

        private void numColumns_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Columns != numColumns.Value)
            {
                mp_oControl.Printer.Columns = System.Convert.ToInt32(numColumns.Value);
                mp_GetNumberOfPages();
            }
        }

        private void chkShowAllColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.ShowAllColumns != chkShowAllColumns.Checked)
            {
                mp_oControl.Printer.ShowAllColumns = chkShowAllColumns.Checked;
                mp_GetNumberOfPages();
            }
        }

        private void txtStartPage_GotFocus(object sender, System.EventArgs e)
        {
            optFrom.Checked = true;
        }

        private void txtEndPage_GotFocus(object sender, System.EventArgs e)
        {
            optFrom.Checked = true;
        }

        private void numMarginLeft_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.MarginLeft != System.Convert.ToInt32(numMarginLeft.Value * 100))
            {
                mp_oControl.Printer.MarginLeft = System.Convert.ToInt32(numMarginLeft.Value * 100);
            }
        }

        private void numMarginTop_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.MarginTop != System.Convert.ToInt32(numMarginTop.Value * 100))
            {
                mp_oControl.Printer.MarginTop = System.Convert.ToInt32(numMarginTop.Value * 100);
            }
        }

        private void numMarginRight_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.MarginRight != System.Convert.ToInt32(numMarginRight.Value * 100))
            {
                mp_oControl.Printer.MarginRight = System.Convert.ToInt32(numMarginRight.Value * 100);
            }
        }

        private void numMarginBottom_ValueChanged(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.MarginBottom != System.Convert.ToInt32(numMarginBottom.Value * 100))
            {
                mp_oControl.Printer.MarginBottom = System.Convert.ToInt32(numMarginBottom.Value * 100);
            }
        }

        private void numStartRow_ValueChanged(object sender, EventArgs e)
        {
            if (mp_bLoaded == false)
                return;
            if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
            {
                mp_GetNumberOfPages();
            }
        }

        private void numEndRow_ValueChanged(object sender, EventArgs e)
        {
            if (mp_bLoaded == false)
                return;
            if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
            {
                mp_GetNumberOfPages();
            }
        }

        #endregion

        #region "Functions"

        private void mp_GetNumberOfPages()
        {
            mp_oControl.Printer.Calculate();
            txtEndPage.Text = mp_oControl.Printer.Pages.ToString();
            lblNumberOfPages.Text = "Total Pages: " + mp_oControl.Printer.Pages;
        }

        #endregion

        #region "Buttons"

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
            {
                fPrintPreview oForm = new fPrintPreview();
                oForm.mp_oParent = this;
                oForm.ShowDialog(this);
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (mp_oControl.Printer.Initialize(StartDateCtrl, EndDateCtrl, System.Convert.ToInt32(numStartRow.Value), System.Convert.ToInt32(numEndRow.Value)) == true)
            {
                if (optAll.Checked == true)
                {
                    mp_oControl.Printer.PrintAll();
                }
                else
                {
                    mp_oControl.Printer.PrintRange(System.Convert.ToInt32(txtStartPage.Text), System.Convert.ToInt32(txtEndPage.Text));
                }
            }
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
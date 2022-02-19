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
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace AGCSN
{

    public class clsPrinter
    {

        private enum E_PRINTINGOPERATIONTYPE
        {
            PT_SINGLEPAGE = 1,
            PT_RANGE = 2,
            PT_ALL = 3
        }

        private ActiveGanttCSNCtl mp_oControl;
        private DateTime mp_dtStartDate;
        private DateTime mp_dtEndDate;
        private DateTime mp_dtPrintStartDateBuffer;
        private int mp_lSplitterPositionBuffer;
        private int mp_lFirstVisibleRowBuffer;
        private clsView mp_oView;
        private GRE_ORIENTATION mp_yOrientation;
        internal double mp_dPageWidth;
        internal double mp_dPageHeight;
        private double mp_dActualPageWidth;
        private double mp_dActualPageHeight;
        private int mp_lPages;
        private int mp_lPageNumber;
        private bool mp_bInitialized;
        private int mp_lStartRow;
        private int mp_lEndRow;
        private int mp_lXAxisPages;
        private int mp_lYAxisPages;
        private float mp_fScale;
        private bool mp_bKeepRowsTogether;
        private bool mp_bKeepTimeIntervalsTogether;
        private E_INTERVAL mp_yInterval;
        private int mp_lFactor;
        private bool mp_bKeepColumnsTogether;
        private bool mp_bShowAllColumns;
        private bool mp_bHeadingsInEveryPage;
        private bool mp_bColumnsInEveryPage;

        private int mp_lColumns;
        private List<int> mp_aVertical;
        private List<int> mp_aHorizontal;
        private PrintDocument withEventsField_mp_oPrinter;
        private PrintDocument mp_oPrinter
        {
            get { return withEventsField_mp_oPrinter; }
            set
            {
                if (withEventsField_mp_oPrinter != null)
                {
                    withEventsField_mp_oPrinter.PrintPage -= mp_oPrinter_PrintPage;
                }
                withEventsField_mp_oPrinter = value;
                if (withEventsField_mp_oPrinter != null)
                {
                    withEventsField_mp_oPrinter.PrintPage += mp_oPrinter_PrintPage;
                }
            }
        }
        private E_PRINTINGOPERATIONTYPE mp_yPrintingOperationType;
        private int mp_lStartPage;

        private int mp_lEndPage;
        internal clsPrinter(ActiveGanttCSNCtl oControl)
        {
            mp_oControl = oControl;
            Clear();
        }

        public PrintDocument PrintDocument
        {
            get { return mp_oPrinter; }
        }

        public string PrinterName
        {
            get { return mp_oPrinter.PrinterSettings.PrinterName; }
            set
            {
                mp_oPrinter.PrinterSettings.PrinterName = value;
                mp_QueryPrinter();
            }
        }

        public GRE_PRINTERRESOLUTION PrinterResolution
        {
            get
            {
                GRE_PRINTERRESOLUTION yReturn = GRE_PRINTERRESOLUTION.PR_CUSTOM;
                switch (mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind)
                {
                    case PrinterResolutionKind.High:
                        yReturn = GRE_PRINTERRESOLUTION.PR_HIGH;
                        break;
                    case PrinterResolutionKind.Medium:
                        yReturn = GRE_PRINTERRESOLUTION.PR_MEDIUM;
                        break;
                    case PrinterResolutionKind.Low:
                        yReturn = GRE_PRINTERRESOLUTION.PR_LOW;
                        break;
                    case PrinterResolutionKind.Draft:
                        yReturn = GRE_PRINTERRESOLUTION.PR_DRAFT;
                        break;
                    case PrinterResolutionKind.Custom:
                        yReturn = GRE_PRINTERRESOLUTION.PR_CUSTOM;
                        break;
                }
                return yReturn;
            }
            set
            {
                switch (value)
                {
                    case GRE_PRINTERRESOLUTION.PR_HIGH:
                        mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High;
                        break;
                    case GRE_PRINTERRESOLUTION.PR_MEDIUM:
                        mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Medium;
                        break;
                    case GRE_PRINTERRESOLUTION.PR_LOW:
                        mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Low;
                        break;
                    case GRE_PRINTERRESOLUTION.PR_DRAFT:
                        mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Draft;
                        break;
                    case GRE_PRINTERRESOLUTION.PR_CUSTOM:
                        mp_oPrinter.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.Custom;
                        break;
                }
            }
        }

        public int HorizontalDPI
        {
            get { return mp_oPrinter.DefaultPageSettings.PrinterResolution.X; }
            set { mp_oPrinter.DefaultPageSettings.PrinterResolution.X = value; }
        }

        public int VerticalDPI
        {
            get { return mp_oPrinter.DefaultPageSettings.PrinterResolution.Y; }
            set { mp_oPrinter.DefaultPageSettings.PrinterResolution.Y = value; }
        }

        public GRE_PAPERTYPE PaperType
        {
            get { return (GRE_PAPERTYPE)mp_oPrinter.DefaultPageSettings.PaperSize.Kind; }
            set
            {
                int i;
                for (i = 0; i <= mp_oPrinter.PrinterSettings.PaperSizes.Count - 1; i++)
                {
                    if (mp_oPrinter.PrinterSettings.PaperSizes[i].RawKind == (int)value)
                    {
                        mp_oPrinter.DefaultPageSettings.PaperSize = mp_oPrinter.PrinterSettings.PaperSizes[i];
                        break;
                    }
                }
                mp_QueryPrinter();
            }
        }

        public GRE_ORIENTATION Orientation
        {
            get { return mp_yOrientation; }
            set
            {
                mp_yOrientation = value;
                if (mp_yOrientation == GRE_ORIENTATION.OT_PORTRAIT)
                {
                    mp_oPrinter.DefaultPageSettings.Landscape = false;
                }
                else if (mp_yOrientation == GRE_ORIENTATION.OT_LANDSCAPE)
                {
                    mp_oPrinter.DefaultPageSettings.Landscape = true;
                }
            }
        }

        public int MarginLeft
        {
            get { return mp_oPrinter.DefaultPageSettings.Margins.Left; }
            set
            {
                mp_oPrinter.DefaultPageSettings.Margins.Left = value;
                mp_Calculate();
            }
        }

        public int MarginTop
        {
            get { return mp_oPrinter.DefaultPageSettings.Margins.Top; }
            set
            {
                mp_oPrinter.DefaultPageSettings.Margins.Top = value;
                mp_Calculate();
            }
        }

        public int MarginRight
        {
            get { return mp_oPrinter.DefaultPageSettings.Margins.Right; }
            set
            {
                mp_oPrinter.DefaultPageSettings.Margins.Right = value;
                mp_Calculate();
            }
        }

        public int MarginBottom
        {
            get { return mp_oPrinter.DefaultPageSettings.Margins.Bottom; }
            set
            {
                mp_oPrinter.DefaultPageSettings.Margins.Bottom = value;
                mp_Calculate();
            }
        }

        public float Scale
        {
            get { return mp_fScale; }
            set
            {
                mp_fScale = value;
                mp_Calculate();
            }
        }

        public bool HeadingsInEveryPage
        {
            get { return mp_bHeadingsInEveryPage; }
            set
            {
                mp_bHeadingsInEveryPage = value;
                mp_Calculate();
            }
        }

        public bool ColumnsInEveryPage
        {
            get { return mp_bColumnsInEveryPage; }
            set
            {
                mp_bColumnsInEveryPage = value;
                mp_Calculate();
            }
        }

        public int Columns
        {
            get { return mp_lColumns; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                mp_lColumns = value;
                mp_Calculate();
            }
        }

        public bool KeepRowsTogether
        {
            get { return mp_bKeepRowsTogether; }
            set
            {
                mp_bKeepRowsTogether = value;
                mp_Calculate();
            }
        }

        public bool KeepColumnsTogether
        {
            get { return mp_bKeepColumnsTogether; }
            set
            {
                mp_bKeepColumnsTogether = value;
                mp_Calculate();
            }
        }

        public bool KeepTimeIntervalsTogether
        {
            get { return mp_bKeepTimeIntervalsTogether; }
            set
            {
                mp_bKeepTimeIntervalsTogether = value;
                mp_Calculate();
            }
        }

        public bool ShowAllColumns
        {
            get { return mp_bShowAllColumns; }
            set
            {
                mp_bShowAllColumns = value;
                if (mp_bShowAllColumns == true)
                {
                    if (mp_lSplitterPositionBuffer == -1)
                    {
                        mp_lSplitterPositionBuffer = mp_oControl.Splitter.Position;
                    }
                    mp_oControl.Splitter.Position = mp_oControl.Columns.Width + mp_oControl.Splitter.Offset;
                }
                else if (mp_bShowAllColumns == false)
                {
                    if (mp_lSplitterPositionBuffer != -1)
                    {
                        mp_oControl.Splitter.Position = mp_lSplitterPositionBuffer;
                        mp_lSplitterPositionBuffer = -1;
                    }
                }
                mp_Calculate();
            }
        }

        public E_INTERVAL Interval
        {
            get { return mp_yInterval; }
            set
            {
                mp_yInterval = value;
                mp_Calculate();
            }
        }

        public int Factor
        {
            get { return mp_lFactor; }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                mp_lFactor = value;
                mp_Calculate();
            }
        }

        public int Pages
        {
            get { return mp_lPages; }
        }

        public int XAxisPages
        {
            get { return mp_lXAxisPages; }
        }

        public int YAxisPages
        {
            get { return mp_lYAxisPages; }
        }

        public DateTime PrintAreaEndDate
        {
            get { return mp_dtEndDate; }
        }

        public DateTime PrintAreaStartDate
        {
            get { return mp_dtStartDate; }
        }

        public int StartRow
        {
            get { return mp_lStartRow; }
        }

        public int EndRow
        {
            get { return mp_lEndRow; }
        }

        public int PrintAreaWidth
        {
            get { return mp_oControl.clsG.CustomWidth; }
        }

        public int PrintAreaHeight
        {
            get { return mp_oControl.clsG.CustomHeight; }
        }

        public void Clear()
        {
            mp_dtStartDate = new DateTime();
            mp_dtEndDate = new DateTime();
            mp_dtPrintStartDateBuffer = new DateTime();
            mp_lSplitterPositionBuffer = -1;
            mp_lFirstVisibleRowBuffer = -1;
            mp_oView = null;
            mp_yOrientation = GRE_ORIENTATION.OT_PORTRAIT;
            mp_dPageWidth = 0;
            mp_dPageHeight = 0;
            mp_dActualPageWidth = 0;
            mp_dActualPageHeight = 0;
            mp_lPages = 0;
            mp_lPageNumber = 0;
            mp_bInitialized = false;
            if (mp_oControl.Rows.Count > 0)
            {
                mp_lStartRow = 1;
                mp_lEndRow = mp_oControl.Rows.Count;
            }
            else
            {
                mp_lStartRow = -1;
                mp_lEndRow = -1;
            }
            mp_lXAxisPages = 0;
            mp_lYAxisPages = 0;
            mp_fScale = 1f;
            mp_bKeepRowsTogether = true;
            mp_bKeepTimeIntervalsTogether = false;
            mp_yInterval = E_INTERVAL.IL_MONTH;
            mp_lFactor = 1;
            mp_bKeepColumnsTogether = true;
            mp_bShowAllColumns = true;
            mp_bHeadingsInEveryPage = false;
            mp_bColumnsInEveryPage = false;
            mp_lColumns = 1;
            mp_aVertical = new List<int>();
            mp_aHorizontal = new List<int>();
            mp_oPrinter = new PrintDocument();
            mp_yPrintingOperationType = E_PRINTINGOPERATIONTYPE.PT_ALL;
            mp_lStartPage = 0;
            mp_lEndPage = 0;

            mp_QueryPrinter();
        }

        public void GetPagePosition(int PageNumber, ref int Column, ref int Row)
        {
            if (PageNumber < 1 | PageNumber > Pages)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_PAGE, "Invalid PageNumber. PageNumber must be greater than 1 and less than the value of the Pages property.", "ActiveGanttCSNCtl.clsPrinter.GetPagePosition");
                return;
            }
            mp_GetPagePosition(PageNumber, ref Column, ref Row);
            Column = Column + 1;
            Row = Row + 1;
        }

        public int GetPageNumber(int Column, int Row)
        {
            if (Column < 1 | Column > mp_lXAxisPages)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_COLUMN, "Invalid column index. Index must be greater than 1 and less than the value of the XAxisPages property.", "ActiveGanttCSNCtl.clsPrinter.GetPageNumber");
                return -1;
            }
            if (Row < 1 | Row > mp_lYAxisPages)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_COLUMN, "Invalid row index. Index must be greater than 1 and less than the value of the YAxisPages property.", "ActiveGanttCSNCtl.clsPrinter.GetPageNumber");
                return -1;
            }
            if (Row == 1)
            {
                return Column;
            }
            else
            {
                return ((Row - 1) * mp_lXAxisPages) + Column;
            }
        }

        public bool Initialize(DateTime StartDate, DateTime EndDate)
        {
            return Initialize(StartDate, EndDate, -1, -1);
        }

        public bool Initialize(DateTime StartDate, DateTime EndDate, int StartRow = -1)
        {
            return Initialize(StartDate, EndDate, StartRow, -1);
        }

        public bool Initialize(DateTime StartDate, DateTime EndDate, int StartRow = -1, int EndRow = -1)
        {
            mp_oView = mp_oControl.CurrentViewObject;
            mp_dtStartDate = StartDate;
            mp_dtEndDate = EndDate;

            mp_lStartRow = StartRow;
            mp_lEndRow = EndRow;

            if (mp_oControl.Rows.Count == 0)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_NO_ROWS, "No rows to print.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                return false;
            }

            if ((mp_lStartRow < 0 & mp_lEndRow < 0))
            {
                mp_lStartRow = 1;
                mp_lEndRow = mp_oControl.Rows.Count;
            }

            if (mp_lStartRow <= 0)
            {
                mp_lStartRow = 1;
            }

            if ((mp_lEndRow > mp_oControl.Rows.Count) | EndRow <= -1)
            {
                mp_lEndRow = mp_oControl.Rows.Count;
            }

            if (mp_lEndRow < mp_lStartRow)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_ROW_RANGE, "Invalid Row Range. EndRow cannot be smaller than StartRow.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                return false;
            }

            if ((StartDate == EndDate) | (EndDate < StartDate))
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_DATE_RANGE, "Invalid Date Range. EndDate must be greater than StartDate.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                return false;
            }

            if (mp_CalculatePageDimensions() == false)
            {
                return false;
            }
            if (mp_CheckRows() == false)
            {
                return false;
            }
            if (mp_CheckColumns() == false)
            {
                return false;
            }
            if (mp_CheckTimeIntervals() == false)
            {
                return false;
            }

            if (mp_bShowAllColumns == true)
            {
                if (mp_lSplitterPositionBuffer == -1)
                {
                    mp_lSplitterPositionBuffer = mp_oControl.Splitter.Position;
                }
                mp_oControl.Splitter.Position = mp_oControl.Columns.Width + mp_oControl.Splitter.Offset;
            }

            if (mp_oControl.f_TimeLineScrollBar.Enabled == false)
            {
                mp_dtPrintStartDateBuffer = mp_oView.TimeLine.StartDate;
                mp_oView.TimeLine.f_StartDate = mp_dtStartDate;
            }
            else
            {
                mp_dtPrintStartDateBuffer = mp_oControl.f_TimeLineScrollBar.StartDate;
                mp_oControl.f_TimeLineScrollBar.StartDate = mp_dtStartDate;
            }
            if (mp_lFirstVisibleRowBuffer == -1)
            {
                mp_lFirstVisibleRowBuffer = mp_oView.ClientArea.FirstVisibleRow;
            }
            mp_oView.ClientArea.FirstVisibleRow = 1;

            mp_oControl.clsG.CustomWidth = System.Convert.ToInt32(mp_oControl.MathLib.DateTimeDiff(mp_oView.Interval, StartDate, EndDate) / mp_oView.Factor) + mp_oControl.Splitter.Right;
            mp_oControl.clsG.CustomHeight = mp_oControl.Rows.Height() + mp_oControl.CurrentViewObject.TimeLine.Height;

            mp_bInitialized = true;
            mp_Calculate();
            return true;
        }

        public void Terminate()
        {
            if (mp_bInitialized == true)
            {
                if (mp_oControl.f_TimeLineScrollBar.Enabled == false)
                {
                    mp_oView.TimeLine.f_StartDate = mp_dtPrintStartDateBuffer;
                }
                else
                {
                    mp_oControl.f_TimeLineScrollBar.StartDate = mp_dtPrintStartDateBuffer;
                }
                if (mp_lSplitterPositionBuffer != -1)
                {
                    mp_oControl.Splitter.Position = mp_lSplitterPositionBuffer;
                    mp_lSplitterPositionBuffer = -1;
                }
                if (mp_lFirstVisibleRowBuffer != -1)
                {
                    mp_oView.ClientArea.FirstVisibleRow = mp_lFirstVisibleRowBuffer;
                    mp_lFirstVisibleRowBuffer = -1;
                }
                mp_Calculate();
            }
        }

        public void Calculate()
        {
            mp_Calculate();
        }

        public void PrintAll()
        {
            if (mp_bInitialized == true)
            {
                mp_lStartPage = 1;
                mp_lEndPage = Pages;
                mp_lPageNumber = 1;
                mp_yPrintingOperationType = E_PRINTINGOPERATIONTYPE.PT_ALL;
                mp_oPrinter.Print();
            }
        }

        public void PrintRange(int StartPage, int EndPage)
        {
            if (mp_bInitialized == true)
            {
                if ((StartPage < 1) | (EndPage > Pages))
                {
                    mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_PAGE, "Invalid PageNumber. StartPage and EndPage must be greater than 1 and less than the value of the Pages property.", "ActiveGanttCSNCtl.clsPrinter.PrintRange");
                    return;
                }
                if (EndPage < StartPage)
                {
                    mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_PAGE_RANGE, "Invalid Page range. EndPage must be greater than or equal to StartPage.", "ActiveGanttCSNCtl.clsPrinter.PrintRange");
                    return;
                }
                mp_lStartPage = StartPage;
                mp_lEndPage = EndPage;
                mp_lPageNumber = StartPage;
                mp_yPrintingOperationType = E_PRINTINGOPERATIONTYPE.PT_RANGE;
                mp_oPrinter.Print();
            }
        }

        public void PrintPage(int PageNumber)
        {
            if ((PageNumber < 1) | (PageNumber > Pages))
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_PAGE, "Invalid PageNumber. PageNumber must be greater than 1 and less than the value of the Pages property.", "ActiveGanttCSNCtl.clsPrinter.PrintRange");
                return;
            }
            if (mp_bInitialized == true)
            {
                mp_Calculate();
                mp_lPageNumber = PageNumber;
                mp_yPrintingOperationType = E_PRINTINGOPERATIONTYPE.PT_SINGLEPAGE;
                mp_oPrinter.Print();
            }
        }

        public void PreviewPage(Graphics oGraphics, int PageNumber, float Scale, int X, int Y)
        {
            if (Scale <= 0)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SCALE, "Invalid scale, scale must be greater than 0.", "ActiveGanttCSNCtl.clsPrinter.PreviewPage");
                return;
            }
            if ((PageNumber < 1) | (PageNumber > Pages))
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_PAGE, "Invalid PageNumber. PageNumber must be greater than 1 and less than the value of the Pages property.", "ActiveGanttCSNCtl.clsPrinter.PreviewPage");
                return;
            }

            int lMarginLeft = System.Convert.ToInt32(MarginLeft * mp_fScaleInvMultp());
            int lMarginTop = System.Convert.ToInt32(MarginTop * mp_fScaleInvMultp());
            int X1 = System.Convert.ToInt32(X * mp_fScaleInvMultp());
            int Y1 = System.Convert.ToInt32(Y * mp_fScaleInvMultp());

            mp_oControl.clsG.CustomPrinting = true;
            mp_oControl.mp_PositionScrollBars();
            mp_oControl.clsG.CustomDC = oGraphics;

            oGraphics.ScaleTransform(Scale, Scale);
            oGraphics.TranslateTransform((1 / Scale * X) - X, (1 / Scale * Y) - Y);

            if (mp_yOrientation == GRE_ORIENTATION.OT_PORTRAIT)
            {
                oGraphics.FillRectangle(Brushes.White, new Rectangle(X, Y, System.Convert.ToInt32(mp_dPageWidth), System.Convert.ToInt32(mp_dPageHeight)));
            }
            else if (mp_yOrientation == GRE_ORIENTATION.OT_LANDSCAPE)
            {
                oGraphics.FillRectangle(Brushes.White, new Rectangle(X, Y, System.Convert.ToInt32(mp_dPageHeight), System.Convert.ToInt32(mp_dPageWidth)));
            }

            mp_Draw(oGraphics, PageNumber, lMarginLeft, lMarginTop, X1, Y1, false);

            mp_oControl.clsG.CustomPrinting = false;
            mp_oControl.mp_PositionScrollBars();
        }

        #region "Functions"

        private void mp_oPrinter_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            mp_PrintPage(e.Graphics);
            switch (mp_yPrintingOperationType)
            {
                case E_PRINTINGOPERATIONTYPE.PT_SINGLEPAGE:
                    e.HasMorePages = false;
                    break;
                case E_PRINTINGOPERATIONTYPE.PT_RANGE:
                    if (mp_lPageNumber < mp_lEndPage)
                    {
                        mp_lPageNumber = mp_lPageNumber + 1;
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    break;
                case E_PRINTINGOPERATIONTYPE.PT_ALL:
                    if (mp_lPageNumber < mp_lEndPage)
                    {
                        mp_lPageNumber = mp_lPageNumber + 1;
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    break;
            }
        }

        private void mp_PrintPage(Graphics oGraphics)
        {
            int lMarginLeft = System.Convert.ToInt32(MarginLeft * mp_fScaleInvMultp()) - System.Convert.ToInt32(mp_oPrinter.DefaultPageSettings.HardMarginX * mp_fScaleInvMultp());
            int lMarginTop = System.Convert.ToInt32(MarginTop * mp_fScaleInvMultp()) - System.Convert.ToInt32(mp_oPrinter.DefaultPageSettings.HardMarginY * mp_fScaleInvMultp());

            mp_oControl.clsG.CustomPrinting = true;
            mp_oControl.mp_PositionScrollBars();
            mp_oControl.clsG.CustomDC = oGraphics;

            mp_Draw(oGraphics, mp_lPageNumber, lMarginLeft, lMarginTop, 0, 0, true);

            mp_oControl.clsG.CustomPrinting = false;
            mp_oControl.mp_PositionScrollBars();
        }

        private void mp_Draw(Graphics oGraphics, int PageNumber, int lMarginLeft, int lMarginTop, int X1, int Y1, bool bToPrinter)
        {
            int lColumn = -1;
            int lRow = -1;
            System.Drawing.Drawing2D.GraphicsState oGraphicsStartState = null;
            System.Drawing.Drawing2D.GraphicsState oGraphicsState = null;


            lMarginLeft = lMarginLeft + X1;
            lMarginTop = lMarginTop + Y1;

            oGraphicsStartState = oGraphics.Save();
            mp_GetPagePosition(PageNumber, ref lColumn, ref lRow);

            oGraphics.ScaleTransform(mp_fScale, mp_fScale);
            if (mp_bHeadingsInEveryPage == true | lRow == 0)
            {
                oGraphicsState = oGraphics.Save();
                oGraphics.TranslateTransform(-mp_aX(lColumn) + lMarginLeft + mp_lColumnsWidth(lColumn), lMarginTop);
                mp_oControl.clsG.mp_lX1 = mp_aX(lColumn);
                mp_oControl.clsG.mp_lY1 = 0;
                mp_oControl.clsG.mp_lX2 = mp_aX(lColumn + 1);
                mp_oControl.clsG.mp_lY2 = mp_lTimeLineHeight();
                mp_oControl.f_Draw();
                oGraphics.Restore(oGraphicsState);
            }
            if (mp_bColumnsInEveryPage == true & mp_lColumns > 0 & lColumn > 0)
            {
                if (mp_bHeadingsInEveryPage == true | lRow == 0)
                {
                    //// Column Headings
                    oGraphicsState = oGraphics.Save();
                    oGraphics.TranslateTransform(lMarginLeft, lMarginTop);
                    mp_oControl.clsG.mp_lX1 = 0;
                    mp_oControl.clsG.mp_lY1 = 0;
                    mp_oControl.clsG.mp_lX2 = mp_lColumnsWidth(lColumn);
                    mp_oControl.clsG.mp_lY2 = mp_lTimeLineHeight();
                    //g_oControl.clsG.mp_ClipRegion(0, 0, mp_lColumnsWidth(lColumn), mp_lTimeLineHeight, False)
                    //g_oControl.clsG.mp_DrawItem(0, 0, mp_oControl.clsG.Width - 1, mp_oControl.clsG.Height - 1, "", "", False, mp_oControl.Image, 0, 0, mp_oControl.Style)
                    //g_oControl.Columns.Position()
                    //g_oControl.Columns.Draw()
                    mp_oControl.f_Draw();
                    oGraphics.Restore(oGraphicsState);
                }

                //// Columns
                oGraphicsState = oGraphics.Save();
                if (mp_bHeadingsInEveryPage == true | lRow == 0)
                {
                    oGraphics.TranslateTransform(lMarginLeft, -mp_aY(lRow) + lMarginTop - mp_lRowsHeight());
                }
                else
                {
                    oGraphics.TranslateTransform(lMarginLeft, -mp_aY(lRow) + lMarginTop - mp_lTimeLineHeight() - mp_lRowsHeight());
                }
                mp_oControl.clsG.mp_lX1 = 0;
                mp_oControl.clsG.mp_lY1 = mp_aY(lRow) + mp_lTimeLineHeight() + mp_lRowsHeight();
                mp_oControl.clsG.mp_lX2 = mp_lColumnsWidth(lColumn);
                mp_oControl.clsG.mp_lY2 = mp_aY(lRow + 1) + mp_lTimeLineHeight() + mp_lRowsHeight();
                mp_oControl.f_Draw();
                oGraphics.Restore(oGraphicsState);
            }

            if (mp_bHeadingsInEveryPage == true | lRow == 0)
            {
                oGraphics.TranslateTransform(-mp_aX(lColumn) + lMarginLeft + mp_lColumnsWidth(lColumn), -mp_aY(lRow) + lMarginTop - mp_lRowsHeight());
            }
            else
            {
                oGraphics.TranslateTransform(-mp_aX(lColumn) + lMarginLeft + mp_lColumnsWidth(lColumn), -mp_aY(lRow) + lMarginTop - mp_lTimeLineHeight() - mp_lRowsHeight());
            }
            mp_oControl.clsG.mp_lX1 = mp_aX(lColumn);
            mp_oControl.clsG.mp_lY1 = mp_aY(lRow) + mp_lTimeLineHeight() + mp_lRowsHeight();
            mp_oControl.clsG.mp_lX2 = mp_aX(lColumn + 1);
            mp_oControl.clsG.mp_lY2 = mp_aY(lRow + 1) + mp_lTimeLineHeight() + mp_lRowsHeight();
            mp_oControl.f_Draw();


            oGraphics.ResetTransform();


            if (bToPrinter == false)
            {
                oGraphics.Restore(oGraphicsStartState);
                oGraphics.TranslateTransform(X1 * mp_fScale, Y1 * mp_fScale);
            }
            else
            {
                oGraphics.TranslateTransform(-System.Convert.ToInt32(mp_oPrinter.DefaultPageSettings.HardMarginX), -System.Convert.ToInt32(mp_oPrinter.DefaultPageSettings.HardMarginY));
            }
            mp_oControl.PagePrintEventArgs.Clear();
            mp_oControl.PagePrintEventArgs.X1 = MarginLeft;
            mp_oControl.PagePrintEventArgs.Y1 = MarginTop;
            mp_oControl.PagePrintEventArgs.X2 = MarginLeft + System.Convert.ToInt32((mp_aHorizontal[lColumn] + mp_lColumnsWidth(lColumn)) * mp_fScale);
            mp_oControl.PagePrintEventArgs.Y2 = MarginTop + System.Convert.ToInt32((mp_aVertical[lRow] + mp_lTimeLineHeight(lRow)) * mp_fScale);

            if (mp_yOrientation == GRE_ORIENTATION.OT_PORTRAIT)
            {
                mp_oControl.PagePrintEventArgs.PageWidth = System.Convert.ToInt32(mp_dPageWidth);
                mp_oControl.PagePrintEventArgs.PageHeight = System.Convert.ToInt32(mp_dPageHeight);
            }
            else if (mp_yOrientation == GRE_ORIENTATION.OT_LANDSCAPE)
            {
                mp_oControl.PagePrintEventArgs.PageWidth = System.Convert.ToInt32(mp_dPageHeight);
                mp_oControl.PagePrintEventArgs.PageHeight = System.Convert.ToInt32(mp_dPageWidth);
            }

            mp_oControl.PagePrintEventArgs.ActualPageHeight = mp_aVertical[lRow];
            mp_oControl.PagePrintEventArgs.ActualPageWidth = mp_aHorizontal[lColumn];

            mp_oControl.PagePrintEventArgs.Graphics = oGraphics;
            mp_oControl.PagePrintEventArgs.PageNumber = PageNumber;

            mp_oControl.clsG.mp_lX1 = 0;
            mp_oControl.clsG.mp_lY1 = 0;
            mp_oControl.clsG.mp_lX2 = mp_oControl.clsG.CustomWidth;
            mp_oControl.clsG.mp_lY2 = mp_oControl.clsG.CustomHeight;

            oGraphics.ResetClip();
            mp_oControl.FirePagePrint();

        }

        private int mp_lTimeLineHeight(int lRow)
        {
            if (mp_bHeadingsInEveryPage == true | lRow == 0)
            {
                return mp_oControl.CurrentViewObject.TimeLine.Height + mp_oControl.mt_BorderThickness;
            }
            else
            {
                return 0;
            }
        }

        private int mp_lRowsHeight()
        {
            return mp_oControl.Rows.Height(mp_lStartRow - 1);
        }

        private int mp_lTimeLineHeight()
        {
            return mp_oControl.CurrentViewObject.TimeLine.Height + mp_oControl.mt_BorderThickness;
        }

        private int mp_aX(int lIndex)
        {
            if (lIndex == 0)
            {
                return 0;
            }
            else
            {
                int lReturn = 0;
                int i = 0;
                for (i = 0; i <= lIndex - 1; i++)
                {
                    lReturn = lReturn + mp_aHorizontal[i];
                }
                return lReturn;
            }
        }

        private int mp_aY(int lIndex)
        {
            if (lIndex == 0)
            {
                return 0;
            }
            else
            {
                int lReturn = 0;
                int i = 0;
                for (i = 0; i <= lIndex - 1; i++)
                {
                    lReturn = lReturn + mp_aVertical[i];
                }
                return lReturn;
            }
        }

        private void mp_QueryPrinter()
        {
            mp_dPageWidth = System.Convert.ToDouble(mp_oPrinter.DefaultPageSettings.PaperSize.Width);
            mp_dPageHeight = System.Convert.ToDouble(mp_oPrinter.DefaultPageSettings.PaperSize.Height);
            mp_Calculate();
        }

        private void mp_Calculate()
        {
            mp_CalculatePageDimensions();
            if (mp_bInitialized == true)
            {
                mp_CalculateColumns();
                mp_CalculateRows();
                mp_lPages = mp_lXAxisPages * mp_lYAxisPages;
            }
            else
            {
                mp_oControl.clsG.CustomWidth = 0;
                mp_oControl.clsG.CustomHeight = 0;
                mp_dtStartDate = new DateTime();
                mp_dtEndDate = new DateTime();
                mp_lXAxisPages = 0;
                mp_lYAxisPages = 0;
                mp_lPages = 0;
            }
        }

        private int mp_lActualPageHeight(int lRow)
        {
            int lTimeLineHeight = mp_oControl.CurrentViewObject.TimeLine.Height + mp_oControl.mt_BorderThickness;
            if (mp_bHeadingsInEveryPage == true | lRow == 0)
            {
                return System.Convert.ToInt32((mp_dActualPageHeight - lTimeLineHeight) * mp_fScaleInvMultp());
            }
            else
            {
                return System.Convert.ToInt32(mp_dActualPageHeight * mp_fScaleInvMultp());
            }
        }

        private void mp_CalculateRows()
        {
            mp_aVertical = new List<int>();
            if (mp_bKeepRowsTogether == true)
            {
                int lRow = 0;
                int YBuff = 0;
                lRow = mp_lStartRow;
                while (lRow <= mp_lEndRow)
                {
                    if ((YBuff + mp_oControl.Rows.Item(lRow.ToString()).Height + 1) < mp_lActualPageHeight(mp_aVertical.Count))
                    {
                        YBuff = YBuff + mp_oControl.Rows.Item(lRow.ToString()).Height + 1;
                        lRow = lRow + 1;
                    }
                    else
                    {
                        mp_aVertical.Add(YBuff);
                        YBuff = 0;
                    }
                }
                if (YBuff > 0)
                {
                    mp_aVertical.Add(YBuff);
                    YBuff = 0;
                }
                mp_lYAxisPages = mp_aVertical.Count;
            }
            else if (mp_bKeepRowsTogether == false)
            {
                int lRowsHeight = mp_oControl.Rows.Height(mp_lEndRow) - mp_oControl.Rows.Height(mp_lStartRow);
                int yBuff = 0;
                while (yBuff <= lRowsHeight)
                {
                    int lActualPageHeight = mp_lActualPageHeight(mp_aVertical.Count);
                    yBuff = yBuff + lActualPageHeight;
                    if (lActualPageHeight + mp_aY(mp_aVertical.Count) < lRowsHeight)
                    {
                        mp_aVertical.Add(lActualPageHeight);
                    }
                    else
                    {
                        int lRowsHeight1 = 0;
                        if (mp_lEndRow < mp_oControl.Rows.Count)
                        {
                            lRowsHeight1 = mp_oControl.Rows.Height(mp_lEndRow + 1) - mp_oControl.Rows.Height(mp_lStartRow);
                        }
                        else
                        {
                            lRowsHeight1 = mp_oControl.Rows.Height() - mp_oControl.Rows.Height(mp_lStartRow);
                        }
                        mp_aVertical.Add(lRowsHeight1 - mp_aY(mp_aVertical.Count));
                    }

                }
                mp_lYAxisPages = mp_aVertical.Count;
            }
        }

        private void mp_CalculateColumns()
        {
            int lColumn = 0;
            mp_aHorizontal = new List<int>();
            if (mp_bKeepColumnsTogether == true)
            {
                int XBuff = 0;
                lColumn = 1;
                if (mp_bShowAllColumns == true)
                {
                    while (lColumn <= mp_oControl.Columns.Count)
                    {
                        if ((XBuff + mp_oControl.Columns.Item(lColumn.ToString()).Width + 1) < mp_lActualPageWidth(mp_aHorizontal.Count))
                        {
                            XBuff = XBuff + mp_oControl.Columns.Item(lColumn.ToString()).Width;
                            lColumn = lColumn + 1;
                        }
                        else
                        {
                            mp_aHorizontal.Add(XBuff - mp_lColumnsWidth(mp_aHorizontal.Count));
                            XBuff = 0;
                        }
                    }
                }
                else if (mp_bShowAllColumns == false)
                {
                    XBuff = mp_oControl.Splitter.Right;
                }
                if (mp_bKeepTimeIntervalsTogether == true)
                {
                    int lCustomWidth = 0;
                    int XDelta = 0;
                    DateTime dtBuff;
                    mp_dtStartDate = mp_oControl.MathLib.RoundDate(mp_yInterval, mp_lFactor, mp_dtStartDate);
                    mp_dtEndDate = mp_oControl.MathLib.RoundDate(mp_yInterval, mp_lFactor, mp_dtEndDate);
                    mp_oControl.clsG.CustomWidth = System.Convert.ToInt32((mp_oControl.MathLib.DateTimeDiff(mp_oView.Interval, mp_dtStartDate, mp_dtEndDate) / mp_oView.Factor) + mp_oControl.Splitter.Right);
                    lCustomWidth = mp_oControl.clsG.CustomWidth;
                    dtBuff = mp_dtStartDate;
                    while ((dtBuff < mp_dtEndDate))
                    {
                        XDelta = mp_oControl.MathLib.GetXCoordinateFromDate(mp_oControl.MathLib.DateTimeAdd(mp_yInterval, mp_lFactor, dtBuff)) - mp_oControl.MathLib.GetXCoordinateFromDate(dtBuff);
                        if (((XBuff + XDelta) < mp_lActualPageWidth(mp_aHorizontal.Count)))
                        {
                            XBuff = XBuff + XDelta;
                            dtBuff = mp_oControl.MathLib.DateTimeAdd(mp_yInterval, mp_lFactor, dtBuff);
                        }
                        else
                        {
                            mp_aHorizontal.Add(XBuff);
                            XBuff = 0;
                        }
                    }
                    if (XBuff > 0)
                    {
                        mp_aHorizontal.Add(XBuff);
                        XBuff = 0;
                    }
                }
                else if (mp_bKeepTimeIntervalsTogether == false)
                {
                    if (mp_bColumnsInEveryPage == true & mp_lColumns > 0)
                    {
                        mp_lXAxisPages = System.Convert.ToInt32(System.Math.Ceiling(((double)mp_oControl.clsG.CustomWidth - (double)mp_lColumnsWidth(-1)) / (double)mp_lActualPageWidth(-1)));
                    }
                    else if (mp_bColumnsInEveryPage == false | mp_lColumns == 0)
                    {
                        mp_lXAxisPages = System.Convert.ToInt32(System.Math.Ceiling((double)mp_oControl.clsG.CustomWidth / (double)mp_lActualPageWidth()));
                    }
                    for (lColumn = 1; lColumn <= mp_lXAxisPages; lColumn++)
                    {
                        mp_aHorizontal.Add(System.Convert.ToInt32((mp_dActualPageWidth * mp_fScaleInvMultp()) - mp_lColumnsWidth(lColumn - 1)));
                    }
                }
                mp_lXAxisPages = mp_aHorizontal.Count;
            }
            else if (mp_bKeepColumnsTogether == false)
            {
                if (mp_bColumnsInEveryPage == true & mp_lColumns > 0)
                {
                    mp_lXAxisPages = System.Convert.ToInt32(System.Math.Ceiling(((double)mp_oControl.clsG.CustomWidth - (double)mp_lColumnsWidth(-1)) / (double)mp_lActualPageWidth(-1)));
                }
                else if (mp_bColumnsInEveryPage == false | mp_lColumns == 0)
                {
                    mp_lXAxisPages = System.Convert.ToInt32(System.Math.Ceiling((double)mp_oControl.clsG.CustomWidth / (double)mp_lActualPageWidth()));
                }
                for (lColumn = 1; lColumn <= mp_lXAxisPages; lColumn++)
                {
                    mp_aHorizontal.Add(System.Convert.ToInt32((mp_dActualPageWidth * mp_fScaleInvMultp()) - mp_lColumnsWidth(lColumn - 1)));
                }
            }
        }

        private float mp_fScaleInvMultp()
        {
            return 1 / mp_fScale;
        }

        private int mp_lActualPageWidth()
        {
            if (mp_bColumnsInEveryPage == false | mp_lColumns == 0)
            {
                return System.Convert.ToInt32(mp_dActualPageWidth * mp_fScaleInvMultp());
            }
            else
            {
                System.Diagnostics.Debugger.Break();
                return 0;
            }
        }

        private int mp_lActualPageWidth(int lColumn)
        {
            if (mp_bColumnsInEveryPage == true & mp_lColumns > 0)
            {
                return System.Convert.ToInt32((mp_dActualPageWidth - mp_lColumnsWidth(lColumn)) * mp_fScaleInvMultp());
            }
            else if (lColumn == -1)
            {
                return System.Convert.ToInt32((mp_dActualPageWidth - mp_lColumnsWidth(-1)) * mp_fScaleInvMultp());
            }
            else if (mp_bColumnsInEveryPage == false | mp_lColumns == 0)
            {
                return System.Convert.ToInt32(mp_dActualPageWidth * mp_fScaleInvMultp());
            }
            else
            {
                System.Diagnostics.Debugger.Break();
                return 0;
            }
        }

        private int mp_lColumnsWidth(int lColumn)
        {
            int lReturn = 0;
            if (lColumn == 0)
            {
                return 0;
            }
            if (mp_bColumnsInEveryPage == true & mp_lColumns > 0 & mp_bShowAllColumns == false)
            {
                lReturn = mp_oControl.Splitter.Right - mp_oControl.mt_BorderThickness;
            }
            else if (mp_bColumnsInEveryPage == true & mp_lColumns > 0 & mp_bShowAllColumns == true)
            {
                int i = 0;
                for (i = 1; i <= mp_lColumns; i++)
                {
                    if (mp_oControl.Columns.Item(i.ToString()).Visible == true)
                    {
                        lReturn = lReturn + mp_oControl.Columns.Item(i.ToString()).Width;
                    }
                }
            }
            return lReturn + mp_oControl.mt_BorderThickness;
        }

        private void mp_GetPagePosition(int lPageNumber, ref int lColumn, ref int lRow)
        {
            lRow = System.Convert.ToInt32(System.Math.Ceiling((double)lPageNumber / (double)XAxisPages)) - 1;
            lColumn = lPageNumber - (lRow * XAxisPages) - 1;
        }

        #endregion

        #region "Check"

        private bool mp_CalculatePageDimensions()
        {
            if (mp_yOrientation == GRE_ORIENTATION.OT_PORTRAIT)
            {
                mp_dActualPageWidth = mp_dPageWidth - (MarginLeft + MarginRight);
                mp_dActualPageHeight = mp_dPageHeight - (MarginTop + MarginBottom);
            }
            else if (mp_yOrientation == GRE_ORIENTATION.OT_LANDSCAPE)
            {
                mp_dActualPageWidth = mp_dPageHeight - (MarginLeft + MarginRight);
                mp_dActualPageHeight = mp_dPageWidth - (MarginTop + MarginBottom);
            }
            if (mp_dActualPageWidth <= 0 | mp_dActualPageHeight <= 0)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SPECS_MARGINS, "Invalid printing specifications, page printing area cannot be 0. Reduce the margins.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool mp_CheckRows()
        {
            int i = 0;
            int lActualPageHeight = System.Convert.ToInt32(mp_dActualPageHeight * mp_fScaleInvMultp()) - System.Convert.ToInt32(mp_oControl.CurrentViewObject.TimeLine.Height * mp_fScaleInvMultp());
            if (mp_bKeepRowsTogether == true)
            {
                for (i = 1; i <= mp_oControl.Rows.Count; i++)
                {
                    if ((mp_oControl.Rows.Item(i.ToString()).Height + 1) > lActualPageHeight)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SPECS_HEIGHT, "Invalid printing specifications, reduce the top or bottom margin, set the KeepRowsTogether property to false or reduce the scale.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool mp_CheckColumns()
        {
            int i = 0;
            int lActualPageWidth = 0;
            lActualPageWidth = System.Convert.ToInt32(mp_dActualPageWidth * mp_fScaleInvMultp()) - System.Convert.ToInt32(mp_lColumnsInEveryPageWidth() * mp_fScaleInvMultp());
            if (lActualPageWidth <= 0)
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SPECS_COLUMNSINEVERYPAGE, "Invalid printing specifications, reduce the number of Columns in every page, set the ColumnsInEveryPage property to false, reduce the left or right margin or reduce the scale.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                return false;
            }
            if (mp_bKeepColumnsTogether == true)
            {
                for (i = 1; i <= mp_oControl.Columns.Count; i++)
                {
                    if ((mp_oControl.Columns.Item(i.ToString()).Width + 1) > lActualPageWidth)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SPECS_COLUMNS, "Invalid printing specifications, reduce the left or right margin, set the KeepColumnsTogether property to false or reduce the scale.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool mp_CheckTimeIntervals()
        {
            int lActualPageWidth = 0;
            lActualPageWidth = System.Convert.ToInt32(mp_dActualPageWidth * mp_fScaleInvMultp()) - System.Convert.ToInt32(mp_lColumnsInEveryPageWidth() * mp_fScaleInvMultp());
            if (mp_bKeepTimeIntervalsTogether == true & mp_bKeepColumnsTogether == true)
            {
                DateTime dtStartDate = mp_oView.TimeLine.StartDate;
                DateTime dtEndDate = mp_oControl.MathLib.DateTimeAdd(mp_yInterval, mp_lFactor, dtStartDate);
                int lIntervalLength = System.Convert.ToInt32((mp_oControl.MathLib.GetXCoordinateFromDate(dtEndDate) - mp_oControl.MathLib.GetXCoordinateFromDate(dtStartDate)) * mp_fScaleInvMultp());
                if (lIntervalLength > lActualPageWidth)
                {
                    mp_oControl.mp_ErrorReport(SYS_ERRORS.PRINTER_INVALID_SPECS_INTERVAL, "Invalid printing specifications, reduce the left or right margin, set the KeepTimeIntervalsTogether property to false or reduce the scale.", "ActiveGanttCSNCtl.clsPrinter.Initialize");
                    return false;
                }
            }
            return true;
        }

        private int mp_lColumnsInEveryPageWidth()
        {
            if (mp_bColumnsInEveryPage == true & mp_lColumns > 0)
            {
                int i = 0;
                int lReturn = 0;
                for (i = 1; i <= mp_lColumns; i++)
                {
                    if (mp_oControl.Columns.Item(i.ToString()).Visible == true)
                    {
                        lReturn = lReturn + mp_oControl.Columns.Item(i.ToString()).Width;
                    }
                }
                return lReturn;
            }
            else
            {
                return 0;
            }
        }

        #endregion






    }



}
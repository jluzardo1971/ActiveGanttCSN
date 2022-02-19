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
using System.Runtime.InteropServices;

namespace AGCSNCON
{
    public partial class fPrintPreview : System.Windows.Forms.Form
    {

        public fPrintDialog mp_oParent;
        private int mp_lColumn;
        private int mp_lRow;
        private int mp_lPage;
        private float mp_fScale;

        public fPrintPreview()
        {
            InitializeComponent();
            mp_fScale = 1.0F;
            mp_lPage = 1;
        }

        #region "Form Load/Closed"

        private void fPrintPreview_Load(object sender, EventArgs e)
        {
            m_HScroll.Minimum = 0;
            m_HScroll.Maximum = 1200;
            m_HScroll.SmallChange = 25;
            m_HScroll.LargeChange = 100;

            m_VScroll.Minimum = 0;
            m_VScroll.Maximum = 1200;
            m_VScroll.SmallChange = 25;
            m_VScroll.LargeChange = 100;



            mp_UpdatePageNumber();

            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region "Form Resizing"

        private void fPrintPreview_Resize(object sender, EventArgs e)
        {
            Rectangle oClientRect;
            oClientRect = this.ClientRectangle;

            int lDialogWidth = 0;
            int lDialogHeight = 0;

            lDialogWidth = (oClientRect.Right - oClientRect.Left);
            lDialogHeight = (oClientRect.Bottom - oClientRect.Top);



            //// Position Controls

            m_VScroll.Left = lDialogWidth - 17;
            m_VScroll.Top = 25;
            m_VScroll.Width = 17;
            m_VScroll.Height = lDialogHeight - 17 - 25;

            m_HScroll.Left = 0;
            m_HScroll.Top = lDialogHeight - 17;
            m_HScroll.Width = lDialogWidth - 17;
            m_HScroll.Height = 17;

            cmdScrollBarsSeparator.Left = lDialogWidth - 17;
            cmdScrollBarsSeparator.Top = lDialogHeight - 17;
            cmdScrollBarsSeparator.Width = 17;
            cmdScrollBarsSeparator.Height = 17;
        }

        #endregion

        #region "Painting"

        private void fPrintPreview_Paint(object sender, PaintEventArgs e)
        {
            mp_oParent.mp_oControl.Printer.PreviewPage(e.Graphics, mp_lPage, mp_fScale, 100 - m_HScroll.Value, 100 - m_VScroll.Value);
        }

        #endregion

        #region "ScrollBars"

        private void m_HScroll_ValueChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void m_VScroll_ValueChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion

        #region "Functions"

        private void mp_UpdatePageNumber()
        {
            lblPage.Text = "Page " + mp_lPage.ToString() + " of " + mp_oParent.mp_oControl.Printer.Pages;
        }

        #endregion

        #region "Toolbar Buttons"

        private void cmdLeft_Click(object sender, EventArgs e)
        {
            mp_oParent.mp_oControl.Printer.GetPagePosition(mp_lPage, ref mp_lColumn, ref mp_lRow);
            if (mp_lColumn > 1)
            {
                mp_lColumn = mp_lColumn - 1;
                mp_lPage = mp_oParent.mp_oControl.Printer.GetPageNumber(mp_lColumn, mp_lRow);
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdRight_Click(object sender, EventArgs e)
        {
            mp_oParent.mp_oControl.Printer.GetPagePosition(mp_lPage, ref mp_lColumn, ref mp_lRow);
            if (mp_lColumn < mp_oParent.mp_oControl.Printer.XAxisPages)
            {
                mp_lColumn = mp_lColumn + 1;
                mp_lPage = mp_oParent.mp_oControl.Printer.GetPageNumber(mp_lColumn, mp_lRow);
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            mp_oParent.mp_oControl.Printer.GetPagePosition(mp_lPage, ref mp_lColumn, ref mp_lRow);
            if (mp_lRow > 1)
            {
                mp_lRow = mp_lRow - 1;
                mp_lPage = mp_oParent.mp_oControl.Printer.GetPageNumber(mp_lColumn, mp_lRow);
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            mp_oParent.mp_oControl.Printer.GetPagePosition(mp_lPage, ref mp_lColumn, ref mp_lRow);
            if (mp_lRow < mp_oParent.mp_oControl.Printer.YAxisPages)
            {
                mp_lRow = mp_lRow + 1;
                mp_lPage = mp_oParent.mp_oControl.Printer.GetPageNumber(mp_lColumn, mp_lRow);
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdPreviousPage_Click(object sender, EventArgs e)
        {
            if (mp_lPage > 1)
            {
                mp_lPage = mp_lPage - 1;
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdNextPage_Click(object sender, EventArgs e)
        {
            if (mp_lPage < mp_oParent.mp_oControl.Printer.Pages)
            {
                mp_lPage = mp_lPage + 1;
                mp_UpdatePageNumber();
                this.Invalidate();
            }
        }

        private void cmdZoomIn_Click(object sender, EventArgs e)
        {
            if (mp_fScale < 2f)
            {
                mp_fScale = mp_fScale + 0.1f;
                this.Invalidate();
            }
        }

        private void cmdZoomOut_Click(object sender, EventArgs e)
        {
            if (mp_fScale > 0.1f)
            {
                mp_fScale = mp_fScale - 0.1f;
                this.Invalidate();
            }
        }

        #endregion



    }
}
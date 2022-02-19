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
    public partial class fCustomTickMarkAreaDraw : Form
    {
        public fCustomTickMarkAreaDraw()
        {
            InitializeComponent();
        }

        private void fCustomTickMarkAreaDraw_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //If you open the form: Styles And Templates -> Available Templates in the main menu (fTemplates.cs)
            //you can preview all available Templates.
            //Or you can also build your own:
            //fMSProject11.cs shows you how to build a Solid Template in the InitializeAG Method.
            //fMSProject14.cs shows you how to build a Gradient Template in the InitializeAG Method.
            ActiveGanttCSNCtl1.ApplyTemplate(E_CONTROLTEMPLATE.STC_CH_VGRAD_ANAKIWA_BLUE, E_OBJECTTEMPLATE.STO_DEFAULT);


        }

        private void fCustomTickMarkAreaDraw_Resize(object sender, EventArgs e)
        {
            Globals.g_Resize(this, ActiveGanttCSNCtl1, panel1, null, null);
        }

        private void ActiveGanttCSNCtl1_CustomTickMarkAreaDraw(object sender, AGCSN.CustomTickMarkAreaDrawEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.GhostWhite), new Rectangle(e.Left, e.Top, e.Right - e.Left, e.Bottom - e.Top));
            e.CustomDraw = true;
        }

        private void ActiveGanttCSNCtl1_CustomTickMarkDraw(object sender, AGCSN.CustomTickMarkAreaDrawEventArgs e)
        {
            int y1 = (e.Bottom - e.Top) / 4;
            switch (e.oTickMark.TickMarkType)
            {
                case AGCSN.E_TICKMARKTYPES.TLT_BIG:
                    e.Graphics.DrawLine(new Pen(Brushes.Red), e.X, e.Top, e.X, e.Bottom);
                    break;
                case AGCSN.E_TICKMARKTYPES.TLT_MEDIUM:
                    e.Graphics.DrawLine(new Pen(Brushes.Green), e.X, e.Top + y1, e.X, e.Bottom);
                    break;
                case AGCSN.E_TICKMARKTYPES.TLT_SMALL:
                    e.Graphics.DrawLine(new Pen(Brushes.Blue), e.X, e.Top + (2 * y1), e.X, e.Bottom);
                    break;
            }
            e.CustomDraw = true;
        }
    }
}
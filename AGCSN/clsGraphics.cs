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
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace AGCSN
{

	using System.Drawing;

	internal class clsGraphics
	{
    
		private struct T_PRECT
		{
			public int lLeft;
			public int lTop;
			public int lRight;
			public int lBottom;
		}

        private ActiveGanttCSNCtl mp_oControl;
		private T_PRECT mp_udtPreviousClipRegion;
		private System.Collections.ArrayList mp_audtActiveReversibleFrames;
		private System.Collections.ArrayList mp_audtActiveReversibleLinesStart;
		private System.Collections.ArrayList mp_audtActiveReversibleLinesEnd;
		private bool mp_bCustomPrinting;
		private Graphics mp_lCustomDC;
		private int mp_lPWidth;
		private int mp_lPHeight;
		private int mp_lFocusLeft;
		private int mp_lFocusTop;
		private int mp_lFocusRight;
		private int mp_lFocusBottom;
		private bool mp_bEnableClipRegions;
		internal Graphics mp_oToolTipGraphics;
		internal bool bToolTipGraphics;
        internal RectangleF mp_oTextFinalLayout;
        internal int mp_lX1;
        internal int mp_lY1;
        internal int mp_lX2;
        internal int mp_lY2;

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117
        }

        public float mp_GetScalingFactor()
        {
            Graphics oGraphics = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr iDesktop = oGraphics.GetHdc();
            int iLogicalScreenHeight = GetDeviceCaps(iDesktop, Convert.ToInt32(DeviceCap.VERTRES));
            int iPhysicalScreenHeight = GetDeviceCaps(iDesktop, Convert.ToInt32(DeviceCap.DESKTOPVERTRES));
            float fScreenScalingFactor = Convert.ToSingle(iPhysicalScreenHeight) / Convert.ToSingle(iLogicalScreenHeight);
            return fScreenScalingFactor;
        }

        internal clsGraphics(ActiveGanttCSNCtl oControl)
		{
            mp_oControl = oControl;
			mp_audtActiveReversibleFrames = new System.Collections.ArrayList();
			mp_audtActiveReversibleLinesStart = new System.Collections.ArrayList();
			mp_audtActiveReversibleLinesEnd = new System.Collections.ArrayList();
			mp_bCustomPrinting = false;
			mp_bEnableClipRegions = true;
			bToolTipGraphics = false;
		}
 
		internal bool EnableClipRegions 
		{
			get { return mp_bEnableClipRegions; }
			set { mp_bEnableClipRegions = value; }
		}
    
		internal int f_FocusLeft 
		{
			get { return mp_lFocusLeft; }
			set { mp_lFocusLeft = value; }
		}
    
		internal int f_FocusTop 
		{
			get { return mp_lFocusTop; }
			set { mp_lFocusTop = value; }
		}
    
		internal int f_FocusRight 
		{
			get { return mp_lFocusRight; }
			set { mp_lFocusRight = value; }
		}
    
		internal int f_FocusBottom 
		{
			get { return mp_lFocusBottom; }
			set { mp_lFocusBottom = value; }
		}
    
		public Graphics oGraphics 
		{
			get 
			{
				if (mp_bCustomPrinting == false) 
				{
					if (bToolTipGraphics == false) 
					{
						return mp_oControl.mp_oGraphics;
					}
					else 
					{
						return mp_oToolTipGraphics;
					}
				}
				else 
				{
					return mp_lCustomDC;
				}
			}
		}
    
		public bool CustomPrinting 
		{
			get { return mp_bCustomPrinting; }
			set { mp_bCustomPrinting = value; }
		}
    
		public Graphics CustomDC 
		{
			set { mp_lCustomDC = value; }
		}
    
		public int Width()
		{
			if (mp_bCustomPrinting == false) 
			{
				return mp_oControl.Width;
			}
			else 
			{
				return mp_lPWidth;
			}
		}
    
		public int Height()
		{
			if (mp_bCustomPrinting == false) 
			{
				return mp_oControl.Height;
			}
			else 
			{
				return mp_lPHeight;
			}
		}
    
		public int CustomWidth 
		{
			get { return mp_lPWidth; }
			set { mp_lPWidth = value; }
		}
    
		public int CustomHeight 
		{
			get { return mp_lPHeight; }
			set { mp_lPHeight = value; }
		}

        internal void mp_DrawEdge(int X1, int Y1, int X2, int Y2, Color clrBackColor, GRE_BUTTONSTYLE yButtonStyle, GRE_EDGETYPE yEdgeType, bool bFilled, clsStyle oStyle)
		{
			Color lExteriorLeftTopColor = Color.FromArgb(255, 255, 255, 255);
			Color lInteriorLeftTopColor = Color.FromArgb(255, 255, 255, 255);
			Color lExteriorRightBottomColor = Color.FromArgb(255, 255, 255, 255);
			Color lInteriorRightBottomColor = Color.FromArgb(255, 255, 255, 255);
			if (yButtonStyle == GRE_BUTTONSTYLE.BT_NORMALWINDOWS) 
			{
                switch (yEdgeType)
                {
                    case GRE_EDGETYPE.ET_RAISED:
                        if (oStyle == null)
                        {
                            lExteriorLeftTopColor = Color.FromArgb(255, 240, 240, 240);
                            lInteriorLeftTopColor = Color.FromArgb(255, 192, 192, 192);
                            lInteriorRightBottomColor = Color.FromArgb(255, 128, 128, 128);
                            lExteriorRightBottomColor = Color.FromArgb(255, 64, 64, 64);
                        }
                        else
                        {
                            lExteriorLeftTopColor = oStyle.ButtonBorderStyle.RaisedExteriorLeftTopColor;
                            lInteriorLeftTopColor = oStyle.ButtonBorderStyle.RaisedInteriorLeftTopColor;
                            lInteriorRightBottomColor = oStyle.ButtonBorderStyle.RaisedInteriorRightBottomColor;
                            lExteriorRightBottomColor = oStyle.ButtonBorderStyle.RaisedExteriorRightBottomColor;
                        }
                        break;
                    case GRE_EDGETYPE.ET_SUNKEN:
                        if (oStyle == null)
                        {
                            lExteriorLeftTopColor = Color.FromArgb(255, 128, 128, 128);
                            lInteriorLeftTopColor = Color.FromArgb(255, 64, 64, 64);
                            lInteriorRightBottomColor = Color.FromArgb(255, 192, 192, 192);
                            lExteriorRightBottomColor = Color.FromArgb(255, 240, 240, 240);
                        }
                        else
                        {
                            lExteriorLeftTopColor = oStyle.ButtonBorderStyle.SunkenExteriorLeftTopColor;
                            lInteriorLeftTopColor = oStyle.ButtonBorderStyle.SunkenInteriorLeftTopColor;
                            lInteriorRightBottomColor = oStyle.ButtonBorderStyle.SunkenInteriorRightBottomColor;
                            lExteriorRightBottomColor = oStyle.ButtonBorderStyle.SunkenExteriorRightBottomColor;
                        }
                        break;
                }
                // Exterior Left
                mp_DrawLine(X1, Y1, X1, Y2, GRE_LINETYPE.LT_NORMAL, lExteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Exterior Top
                mp_DrawLine(X1, Y1, X2, Y1, GRE_LINETYPE.LT_NORMAL, lExteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Exterior Right
                mp_DrawLine(X2, Y2, X2, Y1, GRE_LINETYPE.LT_NORMAL, lExteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Exterior Bottom
                mp_DrawLine(X1, Y2, X2, Y2, GRE_LINETYPE.LT_NORMAL, lExteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID);

                // Interior Left
                mp_DrawLine(X1 + 1, Y1 + 1, X1 + 1, Y2 - 1, GRE_LINETYPE.LT_NORMAL, lInteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Interior Top
                mp_DrawLine(X1 + 1, Y1 + 1, X2 - 1, Y1 + 1, GRE_LINETYPE.LT_NORMAL, lInteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Interior Right
                mp_DrawLine(X2 - 1, Y2 - 1, X2 - 1, Y1 + 1, GRE_LINETYPE.LT_NORMAL, lInteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                // Interior Bottom
                mp_DrawLine(X1 + 1, Y2 - 1, X2 - 1, Y2 - 1, GRE_LINETYPE.LT_NORMAL, lInteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
				if (bFilled == true) 
				{
					mp_DrawLine(X1 + 2, Y1 + 2, X2 - 2, Y2 - 2, GRE_LINETYPE.LT_FILLED, clrBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				}
			}
			else 
			{
                switch (yEdgeType)
                {
                    case GRE_EDGETYPE.ET_RAISED:
                        if (oStyle == null)
                        {
                            lExteriorLeftTopColor = Color.FromArgb(255, 255, 255, 255);
                            lExteriorRightBottomColor = Color.FromArgb(255, 64, 64, 64);
                        }
                        else
                        {
                            lExteriorLeftTopColor = oStyle.ButtonBorderStyle.RaisedExteriorLeftTopColor;
                            lExteriorRightBottomColor = oStyle.ButtonBorderStyle.RaisedExteriorRightBottomColor;
                        }
                        break;
                    case GRE_EDGETYPE.ET_SUNKEN:
                        if (oStyle == null)
                        {
                            lExteriorLeftTopColor = Color.FromArgb(255, 128, 128, 128);
                            lExteriorRightBottomColor = Color.FromArgb(255, 245, 245, 245);
                        }
                        else
                        {
                            lExteriorLeftTopColor = oStyle.ButtonBorderStyle.SunkenExteriorLeftTopColor;
                            lExteriorRightBottomColor = oStyle.ButtonBorderStyle.SunkenExteriorRightBottomColor;
                        }
                        break;
                }
				mp_DrawLine(X1, Y1, X2, Y1, GRE_LINETYPE.LT_NORMAL, lExteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				mp_DrawLine(X1, Y1, X1, Y2, GRE_LINETYPE.LT_NORMAL, lExteriorLeftTopColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				mp_DrawLine(X1, Y2, X2, Y2, GRE_LINETYPE.LT_NORMAL, lExteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				mp_DrawLine(X2, Y2, X2, Y1 - 1, GRE_LINETYPE.LT_NORMAL, lExteriorRightBottomColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				if (bFilled == true) 
				{
					mp_DrawLine(X1 + 1, Y1 + 1, X2 - 1, Y2 - 1, GRE_LINETYPE.LT_FILLED, clrBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				}
			}
		}

        internal void mp_DrawLine(int X1, int Y1, int X2, int Y2, GRE_LINETYPE yStyle, Color clrColor, GRE_LINEDRAWSTYLE yDrawStyle)
		{
			mp_DrawLine(X1, Y1, X2, Y2, yStyle, clrColor, yDrawStyle, 1, true);
		}

        internal void mp_DrawLine(int X1, int Y1, int X2, int Y2, GRE_LINETYPE yStyle, Color clrColor, GRE_LINEDRAWSTYLE yDrawStyle, int lWidth)
        {
            mp_DrawLine(X1, Y1, X2, Y2, yStyle, clrColor, yDrawStyle, lWidth, true);
        }
    
		internal void mp_DrawLine(int X1, int Y1, int X2, int Y2, GRE_LINETYPE yStyle, Color clrColor, GRE_LINEDRAWSTYLE yDrawStyle, int lWidth, bool bCreatePens)
		{
			Pen mp_ucPen = new Pen(clrColor, lWidth);
			SolidBrush mp_ucBrush = new SolidBrush(clrColor);
			PointF[] Points;
			switch (yDrawStyle) 
			{
				case GRE_LINEDRAWSTYLE.LDS_SOLID:
					mp_ucPen.DashStyle = DashStyle.Solid;
					break;
				case GRE_LINEDRAWSTYLE.LDS_DOT:
					mp_ucPen.DashStyle = DashStyle.Dot;
					break;
			}
			switch (yStyle) 
			{
				case GRE_LINETYPE.LT_NORMAL:
					Points = new PointF[2];
					Points[0].X = X1;
					Points[0].Y = Y1;
					Points[1].X = X2;
					Points[1].Y = Y2;
					oGraphics.DrawPolygon(mp_ucPen, Points);
					break;
				case GRE_LINETYPE.LT_BORDER:
					Points = new PointF[5];
					Points[0].X = X1;
					Points[0].Y = Y1;
					Points[1].X = X2;
					Points[1].Y = Y1;
					Points[2].X = X2;
					Points[2].Y = Y2;
					Points[3].X = X1;
					Points[3].Y = Y2;
					Points[4].X = X1;
					Points[4].Y = Y1;
					oGraphics.DrawPolygon(mp_ucPen, Points);
					break;
				case GRE_LINETYPE.LT_FILLED:
					Points = new PointF[5];
					Points[0].X = X1;
					Points[0].Y = Y1;
					Points[1].X = X2 + 1;
					Points[1].Y = Y1;
					Points[2].X = X2 + 1;
					Points[2].Y = Y2 + 1;
					Points[3].X = X1;
					Points[3].Y = Y2 + 1;
					Points[4].X = X1;
					Points[4].Y = Y1;
					oGraphics.FillPolygon(mp_ucBrush, Points);
					break;
			}
		}
    
		internal void mp_DrawFigure(int X, int Y, int lDx, int lDy, GRE_FIGURETYPE yFigureType, Color clrBorderColor, Color clrFillColor, GRE_LINEDRAWSTYLE yBorderStyle)
		{
			Pen oPen = new Pen(clrBorderColor);
			SolidBrush oBrush = new SolidBrush(clrFillColor);
			PointF[] Points;
			if (lDx % 2 != 0) 
			{
				lDx = lDx + 1;
				lDy = lDy + 1;
			}
			switch (yFigureType) 
			{
				case GRE_FIGURETYPE.FT_PROJECTUP:
					Points = new PointF[5];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 2;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X + lDx / 2;
					Points[2].Y = Y + lDy;
					Points[3].X = X - lDx / 2;
					Points[3].Y = Y + lDy;
					Points[4].X = X - lDx / 2;
					Points[4].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_PROJECTDOWN:
					Points = new PointF[5];
					Points[0].X = X + lDx / 2;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 2;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X;
					Points[2].Y = Y + lDy;
					Points[3].X = X - lDx / 2;
					Points[3].Y = Y + lDy / 2;
					Points[4].X = X - lDx / 2;
					Points[4].Y = Y;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_DIAMOND:
					Points = new PointF[4];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 2;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X;
					Points[2].Y = Y + lDy;
					Points[3].X = X - lDx / 2;
					Points[3].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLEDIAMOND:
					Points = new PointF[4];
					Points[0].X = X;
					Points[0].Y = Y + lDy / 4;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X;
					Points[2].Y = Y + (3 * lDy) / 4;
					Points[3].X = X - lDx / 4;
					Points[3].Y = Y + lDy / 2;
					oGraphics.DrawEllipse(oPen, mp_oControl.MathLib.RoundDouble(X - lDx / 2), Y, lDx, lDy);
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_TRIANGLEUP:
					Points = new PointF[3];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 2;
					Points[1].Y = Y + lDy;
					Points[2].X = X - lDx / 2;
					Points[2].Y = Y + lDy;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_TRIANGLEDOWN:
					Points = new PointF[3];
					Points[0].X = X + lDx / 2;
					Points[0].Y = Y;
					Points[1].X = X - lDx / 2;
					Points[1].Y = Y;
					Points[2].X = X;
					Points[2].Y = Y + lDy;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_TRIANGLERIGHT:
					Points = new PointF[3];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X;
					Points[1].Y = Y + lDy;
					Points[2].X = X + lDx;
					Points[2].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_TRIANGLELEFT:
					Points = new PointF[3];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X;
					Points[1].Y = Y + lDy;
					Points[2].X = X - lDx;
					Points[2].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLETRIANGLEUP:
					Points = new PointF[3];
					Points[0].X = X;
					Points[0].Y = Y + lDy / 4;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + (3 * lDy) / 4;
					Points[2].X = X - lDx / 4;
					Points[2].Y = Y + (3 * lDy) / 4;
					oGraphics.DrawEllipse(oPen, mp_oControl.MathLib.RoundDouble(X - lDx / 2), Y, lDx, lDy);
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLETRIANGLEDOWN:
					Points = new PointF[3];
					Points[0].X = X - lDx / 4;
					Points[0].Y = Y + lDy / 4;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + lDy / 4;
					Points[2].X = X;
					Points[2].Y = Y + (3 * lDy) / 4;
					oGraphics.DrawEllipse(oPen, mp_oControl.MathLib.RoundDouble(X - lDx / 2), Y, lDx, lDy);
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_ARROWUP:
					Points = new PointF[7];
					Points[0].X = X;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 2;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X + lDx / 4;
					Points[2].Y = Y + lDy / 2;
					Points[3].X = X + lDx / 4;
					Points[3].Y = Y + lDy;
					Points[4].X = X - lDx / 4;
					Points[4].Y = Y + lDy;
					Points[5].X = X - lDx / 4;
					Points[5].Y = Y + lDy / 2;
					Points[6].X = X - lDx / 2;
					Points[6].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_ARROWDOWN:
					Points = new PointF[7];
					Points[0].X = X - lDx / 4;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y;
					Points[2].X = X + lDx / 4;
					Points[2].Y = Y + lDy / 2;
					Points[3].X = X + lDx / 2;
					Points[3].Y = Y + lDy / 2;
					Points[4].X = X;
					Points[4].Y = Y + lDy;
					Points[5].X = X - lDx / 2;
					Points[5].Y = Y + lDy / 2;
					Points[6].X = X - lDx / 4;
					Points[6].Y = Y + lDy / 2;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLEARROWUP:
					Points = new PointF[7];
					Points[0].X = X;
					Points[0].Y = Y + lDy / 4;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + lDy / 2;
					Points[2].X = X + lDx / 8;
					Points[2].Y = Y + lDy / 2;
					Points[3].X = X + lDx / 8;
					Points[3].Y = Y + (3 * lDy) / 4;
					Points[4].X = X - lDx / 8;
					Points[4].Y = Y + (3 * lDy) / 4;
					Points[5].X = X - lDx / 8;
					Points[5].Y = Y + lDy / 2;
					Points[6].X = X - lDx / 4;
					Points[6].Y = Y + lDy / 2;
					oGraphics.DrawEllipse(oPen, mp_oControl.MathLib.RoundDouble(X - lDx / 2), Y, lDx, lDy);
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLEARROWDOWN:
					Points = new PointF[7];
					Points[0].X = X - lDx / 8;
					Points[0].Y = Y + lDy / 4;
					Points[1].X = X + lDx / 8;
					Points[1].Y = Y + lDy / 4;
					Points[2].X = X + lDx / 8;
					Points[2].Y = Y + lDy / 2;
					Points[3].X = X + lDx / 4;
					Points[3].Y = Y + lDy / 2;
					Points[4].X = X;
					Points[4].Y = Y + (3 * lDy) / 4;
					Points[5].X = X - lDx / 4;
					Points[5].Y = Y + lDy / 2;
					Points[6].X = X - lDx / 8;
					Points[6].Y = Y + lDy / 2;
					oGraphics.DrawEllipse(oPen, mp_oControl.MathLib.RoundDouble(X - lDx / 2), Y, lDx, lDy);
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_SMALLPROJECTUP:
					Points = new PointF[5];
					Points[0].X = X;
					Points[0].Y = Y + lDy / 2;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + (3 * lDy) / 4;
					Points[2].X = X + lDx / 4;
					Points[2].Y = Y + lDy;
					Points[3].X = X - lDx / 4;
					Points[3].Y = Y + lDy;
					Points[4].X = X - lDx / 4;
					Points[4].Y = Y + (3 * lDy) / 4;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_SMALLPROJECTDOWN:
					Points = new PointF[5];
					Points[0].X = X + lDx / 4;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + lDy / 4;
					Points[2].X = X;
					Points[2].Y = Y + lDy / 2;
					Points[3].X = X - lDx / 4;
					Points[3].Y = Y + lDy / 4;
					Points[4].X = X - lDx / 4;
					Points[4].Y = Y;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_RECTANGLE:
					Points = new PointF[4];
					Points[0].X = X - lDx / 8;
					Points[0].Y = Y;
					Points[1].X = X + lDx / 8;
					Points[1].Y = Y;
					Points[2].X = X + lDx / 8;
					Points[2].Y = Y + lDy;
					Points[3].X = X - lDx / 8;
					Points[3].Y = Y + lDy;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_SQUARE:
					Points = new PointF[4];
					Points[0].X = X - lDx / 4;
					Points[0].Y = Y + lDx / 4;
					Points[1].X = X + lDx / 4;
					Points[1].Y = Y + lDx / 4;
					Points[2].X = X + lDx / 4;
					Points[2].Y = Y + (3 * lDy) / 4;
					Points[3].X = X - lDx / 4;
					Points[3].Y = Y + (3 * lDy) / 4;
					mp_DrawFigureAux(oBrush, oPen, Points);
					break;
				case GRE_FIGURETYPE.FT_CIRCLE:
					oGraphics.FillEllipse(oBrush, (float)X - lDx / 2, (float)Y, (float)lDx, (float)lDy);
					break;
				default:
					return;
            
			}
		}
    
		internal void mp_DrawFigureAux(SolidBrush oBrush, Pen oPen, PointF[] oPoints)
		{
			oGraphics.FillPolygon(oBrush, oPoints);
			oGraphics.DrawPolygon(oPen, oPoints);
		}
    
		internal void mp_DrawPattern(int X1, int Y1, int X2, int Y2, Color clrColor, GRE_PATTERN yDrawStyle, int lPatternFactor)
		{
			int tmp = 0;
			int c = 0;
			int c1 = 0;
			int c2 = 0;
			int i1 = 0;
			int j1 = 0;
			int i2 = 0;
			int j2 = 0;
			if (X1 > X2) 
			{
				tmp = X1;
				X1 = X2;
				X2 = tmp;
			}
			if (Y1 > Y2) 
			{
				tmp = Y1;
				Y1 = Y2;
				Y2 = tmp;
			}
			if (yDrawStyle == GRE_PATTERN.FP_HORIZONTALLINE | yDrawStyle == GRE_PATTERN.FP_CROSS) 
			{
				for (j1 = (Y1 + lPatternFactor); j1 <= Y2; j1 += lPatternFactor) 
				{
					mp_DrawLine(X1, j1, X2, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_VERTICALLINE | yDrawStyle == GRE_PATTERN.FP_CROSS) 
			{
				for (j1 = (X1 + lPatternFactor); j1 <= X2; j1 += lPatternFactor) 
				{
					mp_DrawLine(j1, Y1, j1, Y2, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_UPWARDDIAGONAL | yDrawStyle == GRE_PATTERN.FP_DIAGONALCROSS) 
			{
				c1 = System.Convert.ToInt32((Y1 + X1) / lPatternFactor + 1);
				c2 = System.Convert.ToInt32((Y2 + X2) / lPatternFactor);
				for (c = c1; c <= c2; c++) 
				{
					i1 = X1;
					i2 = X2;
					j1 = c * lPatternFactor - i1;
					j2 = c * lPatternFactor - i2;
					if (j2 < Y1) 
					{
						i2 = c * lPatternFactor - Y1;
						j2 = c * lPatternFactor - i2;
					}
					if (j1 > Y2) 
					{
						i1 = c * lPatternFactor - Y2;
						j1 = c * lPatternFactor - i1;
					}
					mp_DrawLine(i1, j1, i2, j2, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, false);
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_DOWNWARDDIAGONAL | yDrawStyle == GRE_PATTERN.FP_DIAGONALCROSS) 
			{
				c1 = System.Convert.ToInt32((Y1 - X2) / lPatternFactor + 1);
				c2 = System.Convert.ToInt32((Y2 - X1) / lPatternFactor);
				for (c = c1; c <= c2; c++) 
				{
					i1 = X1;
					i2 = X2;
					j1 = i1 + c * lPatternFactor;
					j2 = i2 + c * lPatternFactor;
					if (j1 < Y1) 
					{
						i1 = Y1 - c * lPatternFactor;
						j1 = i1 + c * lPatternFactor;
					}
					if (j2 > Y2) 
					{
						i2 = Y2 - c * lPatternFactor;
						j2 = i2 + c * lPatternFactor;
					}
					mp_DrawLine(i1, j1, i2, j2, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, false);
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_LIGHT) 
			{
				for (j1 = (Y1 + 1); j1 <= (Y2 - 1); j1++) 
				{
					if (j1 % 2 == 0) 
					{
						for (j2 = (X1 + 1); j2 <= (X2 - 1); j2 += 4) 
						{
							mp_DrawLine(j2, j1, j2 + 1, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
						}
					}
					else 
					{
						for (j2 = (X1 + 3); j2 <= (X2 - 1); j2 += 4) 
						{
							mp_DrawLine(j2, j1, j2 + 1, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
						}
					}
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_MEDIUM) 
			{
				for (j1 = (Y1 + 1); j1 <= (Y2 - 1); j1++) 
				{
					if (j1 % 2 == 0) 
					{
						for (j2 = (X1 + 1); j2 <= (X2 - 1); j2 += 2) 
						{
							mp_DrawLine(j2, j1, j2 + 1, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
						}
					}
					else 
					{
						for (j2 = (X1 + 2); j2 <= (X2 - 1); j2 += 2) 
						{
							mp_DrawLine(j2, j1, j2 + 1, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
						}
					}
				}
			}
			if (yDrawStyle == GRE_PATTERN.FP_DARK) 
			{
				for (j1 = (Y1 + 1); j1 <= (Y2 - 1); j1++) 
				{
					if (j1 % 2 == 0) 
					{
						for (j2 = (X1 + 1); j2 <= (X2 - 1); j2 += 4) 
						{
							if (j2 + 3 < X2) 
							{
								mp_DrawLine(j2, j1, j2 + 3, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
							}
							else 
							{
								mp_DrawLine(j2, j1, X2, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
							}
						}
					}
					else 
					{
						mp_DrawLine(X1, j1, X1 + 2, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
						for (j2 = (X1 + 3); j2 <= (X2 - 1); j2 += 4) 
						{
							if (j2 + 3 < X2) 
							{
								mp_DrawLine(j2, j1, j2 + 3, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
							}
							else 
							{
								mp_DrawLine(j2, j1, X2, j1, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID, 1, true);
							}
						}
					}
				}
			}
		}
    
		internal void mp_DrawTextEx(int X1, int Y1, int X2, int Y2, string sParam, clsTextFlags yFlags, Color clrColor, Font oFont, bool bClip)
		{
			SolidBrush mp_ucBrush = new SolidBrush(clrColor);
			RectangleF oRect = new RectangleF();
            StringFormat oStringFormat = yFlags.GetFlags();
			oRect.X = X1;
			oRect.Y = Y1;
			oRect.Width = X2 - X1;
			oRect.Height = Y2 - Y1;
            oGraphics.DrawString(sParam, oFont, mp_ucBrush, oRect, oStringFormat);
            
            if (sParam.Length > 0)
            {
                CharacterRange[] aRanges = { new CharacterRange(0, sParam.Length) };
                Region[] aRegion = new Region[2];
                oStringFormat.SetMeasurableCharacterRanges(aRanges);
                aRegion = oGraphics.MeasureCharacterRanges(sParam, oFont, oRect, oStringFormat);
                if (aRegion.Length > 0)
                {
                    mp_oTextFinalLayout = aRegion[0].GetBounds(oGraphics);
                }
                else
                {
                    System.Diagnostics.Debugger.Break();
                }
            }
		}
    
		internal void mp_DrawAlignedText(int X1, int Y1, int X2, int Y2, string sParam, GRE_HORIZONTALALIGNMENT yHPos, GRE_VERTICALALIGNMENT yVPos, Color clrColor, Font oFont)
		{
			mp_DrawAlignedText(X1, Y1, X2, Y2, sParam, yHPos, yVPos, clrColor, oFont, true);
		}

        internal void mp_DrawAlignedText(int X1, int Y1, int X2, int Y2, string sParam, GRE_HORIZONTALALIGNMENT yHPos, GRE_VERTICALALIGNMENT yVPos, Color clrColor, Font oFont, bool bClip)
		{
			int lHeight = 0;
			int lWidth = 0;
			SolidBrush mp_ucBrush = new SolidBrush(clrColor);
			lHeight = mp_lStrHeight(sParam, oFont);
			lWidth = mp_lStrWidth(sParam, oFont);
			RectangleF oRect = new RectangleF();
			StringFormat oFormat = new StringFormat();
			if (bClip == false & lWidth > (X2 - X1)) return; 
			if (bClip == false & lHeight > (Y2 - Y1)) return; 
			oRect.X = X1;
			oRect.Y = Y1;
			oRect.Width = X2 - X1;
			oRect.Height = Y2 - Y1;
			switch (yHPos) 
			{
				case GRE_HORIZONTALALIGNMENT.HAL_LEFT:
					oFormat.Alignment = StringAlignment.Near;
					break;
				case GRE_HORIZONTALALIGNMENT.HAL_CENTER:
					oFormat.Alignment = StringAlignment.Center;
					break;
				case GRE_HORIZONTALALIGNMENT.HAL_RIGHT:
					oFormat.Alignment = StringAlignment.Far;
					break;
			}
			switch (yVPos) 
			{
				case GRE_VERTICALALIGNMENT.VAL_TOP:
					oFormat.LineAlignment = StringAlignment.Near;
					break;
				case GRE_VERTICALALIGNMENT.VAL_CENTER:
					oFormat.LineAlignment = StringAlignment.Center;
					break;
				case GRE_VERTICALALIGNMENT.VAL_BOTTOM:
					oFormat.LineAlignment = StringAlignment.Far;
					break;
			}
            ///////////////////////////////////////////////////////////////////////////////////////////
            oFormat.FormatFlags = oFormat.FormatFlags | System.Drawing.StringFormatFlags.NoWrap;
            ///////////////////////////////////////////////////////////////////////////////////////////
			oGraphics.DrawString(sParam, oFont, mp_ucBrush, oRect, oFormat);
            if (sParam.Length > 0)
            {
                CharacterRange[] aRanges = { new CharacterRange(0, sParam.Length) };
                Region[] aRegion = new Region[2];
                oFormat.SetMeasurableCharacterRanges(aRanges);
                aRegion = oGraphics.MeasureCharacterRanges(sParam, oFont, oRect, oFormat);
                mp_oTextFinalLayout = aRegion[0].GetBounds(oGraphics);
            }
		}

        internal int mp_lStrWidth(String sString, Font r_oFont)
        {
            return  System.Convert.ToInt32(System.Math.Round(oGraphics.MeasureString(sString, r_oFont).Width));
        }

        internal int mp_lStrHeight(String sString, Font r_oFont)
        {
            return  System.Convert.ToInt32(System.Math.Round(oGraphics.MeasureString(sString, r_oFont).Height));
        }

        internal void mp_ClipRegion(int X1, int Y1, int X2, int Y2, bool bStore)
		{
			if ((mp_bEnableClipRegions == false)) 
			{
				return;
			}
            if (mp_bCustomPrinting == true)
            {
                if (X1 < mp_lX1)
                {
                    X1 = mp_lX1;
                }
                if (Y1 < mp_lY1)
                {
                    Y1 = mp_lY1;
                }
                if (X2 > mp_lX2)
                {
                    X2 = mp_lX2;
                }
                if (Y2 > mp_lY2)
                {
                    Y2 = mp_lY2;
                }
                if ((X1 > mp_lX2) | (Y1 > mp_lY2) | (X2 < mp_lX1) | (Y2 < mp_lY1))
                {
                    X1 = 0;
                    Y1 = 0;
                    X2 = 0;
                    Y2 = 0;
                }
            }
			Rectangle oRect = new Rectangle(X1, Y1, (X2 - X1 + 1), (Y2 - Y1 + 1));
			Region oRegion = new Region(oRect);
			if (bStore == true) 
			{
				mp_udtPreviousClipRegion.lLeft = X1;
				mp_udtPreviousClipRegion.lRight = X2;
				mp_udtPreviousClipRegion.lTop = Y1;
				mp_udtPreviousClipRegion.lBottom = Y2;
			}
			oGraphics.Clip = oRegion;
		}

        internal void mp_ClearClipRegion()
		{
			oGraphics.ResetClip();
		}

        internal void mp_TileImageHorizontal(Image oImageHandle, int X1, int Y1, int X2, int Y2, bool bTransparent)
		{
            int XBuff = 0;
			int lImageWidth = 0;
			int lImageHeight = 0;
			lImageHeight = oImageHandle.Height;
			lImageWidth = oImageHandle.Width;
            while (XBuff < (X2 - X1)) 
			{
                if ((XBuff + lImageWidth) > (X2 - X1)) 
				{
					mp_PaintImage(oImageHandle, X2 - lImageWidth, Y1, X2, Y1 + lImageHeight, 0, 0, bTransparent);
				}
				else 
				{
                    mp_PaintImage(oImageHandle, X1 + XBuff, Y1, X1 + XBuff + lImageWidth, Y1 + lImageHeight, 0, 0, bTransparent);
				}
                XBuff = XBuff + lImageWidth;
			}
		}

        internal void mp_PaintImage(Image Image, int X1, int Y1, int X2, int Y2, int xOrigin, int yOrigin, bool bUseMask)
		{
			RectangleF DestRect = new RectangleF(0,0,0,0);
			RectangleF OriginRect = new RectangleF(0,0,0,0);
			OriginRect.X = xOrigin;
			OriginRect.Y = yOrigin;
			OriginRect.Width = Image.Width - xOrigin;
			OriginRect.Height = Image.Height - yOrigin;
			DestRect.X = X1;
			DestRect.Y = Y1;
			DestRect.Width = X2 - X1;
			DestRect.Height = Y2 - Y1;
			if (bUseMask == false) 
			{
				oGraphics.DrawImage(Image, DestRect, OriginRect, GraphicsUnit.Pixel);
			}
			else 
			{
				Bitmap oBitmap;
				oBitmap = (Bitmap) Image.Clone();
				oBitmap.MakeTransparent(Color.FromArgb(255, 255, 255, 255));
				oGraphics.DrawImage(oBitmap, DestRect, OriginRect, GraphicsUnit.Pixel);
			}
		}

        internal void mp_DrawImage(Image oImage, GRE_HORIZONTALALIGNMENT yHorizontalAlignment, GRE_VERTICALALIGNMENT yVerticalAlignment, int lImageXMargin, int lImageYMargin, int X1, int X2, int Y1, int Y2, bool bTransparent)
		{
			bool bDrawImage = false;
			bool bHorizontalSmall = false;
			bool bVerticalSmall = false;
			int XOrigin = 0;
			int YOrigin = 0;
			int xDest = 0;
			int yDest = 0;
			int lxWidth = 0;
			int lyHeight = 0;
			int lImageHeight = 0;
			int lImageWidth = 0;
			if ((oImage == null)) 
			{
				return;
			}
			lImageHeight = oImage.Height;
			lImageWidth = oImage.Width;
			if (yHorizontalAlignment == GRE_HORIZONTALALIGNMENT.HAL_CENTER) 
			{
				lImageXMargin = 0;
			}
			if (yVerticalAlignment == GRE_VERTICALALIGNMENT.VAL_CENTER) 
			{
				lImageYMargin = 0;
			}
			bDrawImage = true;
			if ((X2 - X1) < (lImageWidth + lImageXMargin)) 
			{
				lxWidth = X2 - X1 - lImageXMargin;
				if (lxWidth <= 0) bDrawImage = false; 
				bHorizontalSmall = true;
			}
			else 
			{
				lxWidth = lImageWidth;
				bHorizontalSmall = false;
			}
			if ((Y2 - Y1) < (lImageHeight + lImageYMargin)) 
			{
				lyHeight = Y2 - Y1 - lImageYMargin;
				if (lyHeight <= 0) bDrawImage = false; 
				bVerticalSmall = true;
			}
			else 
			{
				lyHeight = lImageHeight;
				bVerticalSmall = false;
			}
			if (bHorizontalSmall == false) 
			{
				switch (yHorizontalAlignment) 
				{
					case GRE_HORIZONTALALIGNMENT.HAL_LEFT:
						xDest = X1 + lImageXMargin;
						break;
					case GRE_HORIZONTALALIGNMENT.HAL_CENTER:
						xDest = ((X2 - X1) - lImageWidth) / 2 + X1;
						break;
					case GRE_HORIZONTALALIGNMENT.HAL_RIGHT:
						xDest = X2 - lImageWidth - lImageXMargin;
						break;
				}
				XOrigin = 0;
			}
			else 
			{
				switch (yHorizontalAlignment) 
				{
					case GRE_HORIZONTALALIGNMENT.HAL_LEFT:
						XOrigin = 0;
						xDest = X1 + lImageXMargin;
						break;
					case GRE_HORIZONTALALIGNMENT.HAL_CENTER:
						XOrigin = (lImageWidth - lxWidth) / 2;
						xDest = X1;
						break;
					case GRE_HORIZONTALALIGNMENT.HAL_RIGHT:
						XOrigin = lImageWidth - lxWidth;
						xDest = X2 - lxWidth - lImageXMargin;
						break;
				}
			}
			if (bVerticalSmall == false) 
			{
				switch (yVerticalAlignment) 
				{
					case GRE_VERTICALALIGNMENT.VAL_TOP:
						yDest = Y1 + lImageYMargin;
						break;
					case GRE_VERTICALALIGNMENT.VAL_CENTER:
						yDest = ((Y2 - Y1) - lImageHeight) / 2 + Y1;
						break;
					case GRE_VERTICALALIGNMENT.VAL_BOTTOM:
						yDest = Y2 - lImageHeight - lImageYMargin;
						break;
				}
				YOrigin = 0;
			}
			else 
			{
				switch (yVerticalAlignment) 
				{
					case GRE_VERTICALALIGNMENT.VAL_TOP:
						YOrigin = 0;
						yDest = Y1 + lImageYMargin;
						break;
					case GRE_VERTICALALIGNMENT.VAL_CENTER:
						YOrigin = (lImageHeight - lyHeight) / 2;
						yDest = Y1;
						break;
					case GRE_VERTICALALIGNMENT.VAL_BOTTOM:
						YOrigin = lImageHeight - lyHeight;
						yDest = Y2 - lyHeight - lImageYMargin;
						break;
				}
			}
			if (bDrawImage == true) 
			{
				mp_PaintImage(oImage, xDest, yDest, xDest + lxWidth, yDest + lyHeight, XOrigin, YOrigin, bTransparent);
			}
		}

        internal void mp_DrawFocusRectangle(int X1, int Y1, int X2, int Y2)
		{
			Rectangle myrect = new Rectangle(X1, Y1, X2 - X1, Y2 - Y1);
			System.Windows.Forms.ControlPaint.DrawFocusRectangle(oGraphics, myrect);
		}

        internal void mp_GradientFill(int X1, int Y1, int X2, int Y2, Color clrStartColor, Color clrEndColor, GRE_GRADIENTFILLMODE yGradientType)
		{
            if ((X2 - X1) <= 0)
            {
                return;
            }
            if ((Y2 - Y1) <= 0)
            {
                return;
            }
			RectangleF oRect = new RectangleF(X1, Y1, X2 - X1, Y2 - Y1);
			LinearGradientBrush mp_ucBrush = null;
			if ((yGradientType == GRE_GRADIENTFILLMODE.GDT_VERTICAL)) 
			{
				mp_ucBrush = new LinearGradientBrush(oRect, clrStartColor, clrEndColor, LinearGradientMode.Vertical);
			}
			else if ((yGradientType == GRE_GRADIENTFILLMODE.GDT_HORIZONTAL)) 
			{
				mp_ucBrush = new LinearGradientBrush(oRect, clrStartColor, clrEndColor, LinearGradientMode.Horizontal);
			}
			Point[] Points = new Point[5];
			Points[0].X = X1;
			Points[0].Y = Y1;
			Points[1].X = X2 + 1;
			Points[1].Y = Y1;
			Points[2].X = X2 + 1;
			Points[2].Y = Y2 + 1;
			Points[3].X = X1;
			Points[3].Y = Y2 + 1;
			Points[4].X = X1;
			Points[4].Y = Y1;
			oGraphics.FillPolygon(mp_ucBrush, Points);
		}

        internal void mp_HatchFill(int X1, int Y1, int X2, int Y2, Color clrForeColor, Color clrBackColor, GRE_HATCHSTYLE yHatchStyle)
		{
			HatchBrush mp_ucBrush;
			mp_ucBrush = new HatchBrush((HatchStyle)yHatchStyle, clrForeColor, clrBackColor);
			Point[] Points = new Point[5];
			Points[0].X = X1;
			Points[0].Y = Y1;
			Points[1].X = X2 + 1;
			Points[1].Y = Y1;
			Points[2].X = X2 + 1;
			Points[2].Y = Y2 + 1;
			Points[3].X = X1;
			Points[3].Y = Y2 + 1;
			Points[4].X = X1;
			Points[4].Y = Y1;
			oGraphics.FillPolygon(mp_ucBrush, Points);
		}

        internal void mp_ResetFocusRectangle()
		{
			mp_EraseReversibleFrames();
			mp_lFocusLeft = 0;
			mp_lFocusTop = 0;
			mp_lFocusRight = 0;
			mp_lFocusBottom = 0;
		}

        internal void mp_DrawReversibleFrameEx()
		{
			mp_DrawReversibleFrame(mp_lFocusLeft, mp_lFocusTop, mp_lFocusRight, mp_lFocusBottom);
		}

        internal void mp_DrawReversibleLine(int X1, int Y1, int X2, int Y2)
		{
            float fScalingFactor = mp_GetScalingFactor();
            Point oStart = new Point(0,0);
			Point oEnd = new Point(0,0);
			Point p1;
			Point p2;
			oStart.X = X1;
			oStart.Y = Y1;
			p1 = mp_oControl.PointToScreen(oStart);
			oEnd.X = X2;
			oEnd.Y = Y2;
			p2 = mp_oControl.PointToScreen(oEnd);
            p1.X = System.Convert.ToInt32(p1.X * fScalingFactor);
            p1.Y = System.Convert.ToInt32(p1.Y * fScalingFactor);
            p2.X = System.Convert.ToInt32(p2.X * fScalingFactor);
            p2.Y = System.Convert.ToInt32(p2.Y * fScalingFactor);
            ControlPaint.DrawReversibleLine(p1, p2, Color.FromArgb(255, 240, 248, 255));
			mp_audtActiveReversibleLinesStart.Add(p1);
			mp_audtActiveReversibleLinesEnd.Add(p2);
		}

        internal void mp_EraseReversibleLines()
		{
			int lIndex = 0;
			for (lIndex = 0; lIndex <= mp_audtActiveReversibleLinesStart.Count - 1; lIndex++) 
			{
				Point oStart = new Point();
				Point oEnd = new Point();
				oStart = (Point) mp_audtActiveReversibleLinesStart[lIndex];
				oEnd = (Point) mp_audtActiveReversibleLinesEnd[lIndex];
				ControlPaint.DrawReversibleLine(oStart, oEnd, Color.FromArgb(255, 240, 248, 255));
			}
			mp_audtActiveReversibleLinesStart.Clear();
			mp_audtActiveReversibleLinesEnd.Clear();
		}

        internal void mp_DrawReversibleFrame(int X1, int Y1, int X2, int Y2)
		{
            float fScalingFactor = mp_GetScalingFactor();
			Rectangle udtRect = new Rectangle(0,0,0,0);
			Point p1 = new Point(0,0);
			p1.X = X1;
			p1.Y = Y1;
			p1 = mp_oControl.PointToScreen(p1);
			udtRect.X = p1.X;
			udtRect.Y = p1.Y;
			udtRect.Width = X2 - X1;
			udtRect.Height = Y2 - Y1;
            udtRect.X = System.Convert.ToInt32(udtRect.X * fScalingFactor);
            udtRect.Y = System.Convert.ToInt32(udtRect.Y * fScalingFactor);
            udtRect.Width = System.Convert.ToInt32(udtRect.Width * fScalingFactor);
            udtRect.Height = System.Convert.ToInt32(udtRect.Height * fScalingFactor);
            ControlPaint.DrawReversibleFrame(udtRect, Color.FromArgb(255, 240, 248, 255), FrameStyle.Thick);
			Rectangle udtReversibleFrame = new Rectangle(0,0,0,0);
			udtReversibleFrame.X = udtRect.X;
			udtReversibleFrame.Y = udtRect.Y;
			udtReversibleFrame.Width = udtRect.Width;
			udtReversibleFrame.Height = udtRect.Height;
			mp_audtActiveReversibleFrames.Add(udtReversibleFrame);
		}

        internal void mp_EraseReversibleFrames()
		{
			int lIndex = 0;
			for (lIndex = 0; lIndex <= mp_audtActiveReversibleFrames.Count - 1; lIndex++) 
			{
				Rectangle udtReversibleFrame;
				udtReversibleFrame = (Rectangle) mp_audtActiveReversibleFrames[lIndex];
				ControlPaint.DrawReversibleFrame(udtReversibleFrame, Color.FromArgb(255, 240, 248, 255), FrameStyle.Thick);
			}
			mp_audtActiveReversibleFrames.Clear();
		}

        internal void mp_DrawItemI(int X1, int Y1, int X2, int Y2, string sStyleIndex, string sText, bool bSelected, Image Image, int lLeftTrim, int lRightTrim, clsStyle v_oStyle)
        {
            clsStyle oStyle;
            clsMilestoneStyle oMilestoneStyle;
            if ((v_oStyle == null))
            {
                if (Globals.g_IsNumeric(sStyleIndex))
                {
                    if (System.Convert.ToInt32(sStyleIndex) < 0 | System.Convert.ToInt32(sStyleIndex) > mp_oControl.Styles.Count)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.STYLE_INVALID_INDEX, "Style object element not found when preparing to draw, invalid index", "mp_DrawItemI");
                        return;
                    }
                }
                else
                {
                    if (mp_oControl.Styles.oCollection.m_bDoesKeyExist(sStyleIndex) == false)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.STYLE_INVALID_KEY, "Style object element not found when preparing to draw, invalid key (\"" + sStyleIndex + "\")", "mp_DrawItemI");
                        return;
                    }
                }
                oStyle = mp_oControl.Styles.FItem(sStyleIndex);
            }
            else
            {
                oStyle = v_oStyle;
            }
            switch (oStyle.Appearance)
            {
                case E_STYLEAPPEARANCE.SA_FLAT:
                    oMilestoneStyle = oStyle.MilestoneStyle;
                    mp_DrawFigure(X1 + ((X2 - X1) / 2), Y1, Y2 - Y1, Y2 - Y1, oMilestoneStyle.ShapeIndex, oMilestoneStyle.BorderColor, oMilestoneStyle.FillColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    break;
                case E_STYLEAPPEARANCE.SA_GRAPHICAL:
                    if ((oStyle.MilestoneStyle.Image != null))
                    {
                        mp_DrawImage(oStyle.MilestoneStyle.Image, oStyle.ImageAlignmentHorizontal, oStyle.ImageAlignmentVertical, oStyle.ImageXMargin, oStyle.ImageYMargin, X1, X2, Y1, Y2, oStyle.UseMask);
                    }
                    else if ((Image != null))
                    {
                        mp_DrawImage(Image, oStyle.ImageAlignmentHorizontal, oStyle.ImageAlignmentVertical, oStyle.ImageXMargin, oStyle.ImageYMargin, X1, X2, Y1, Y2, oStyle.UseMask);
                    }
                    break;
                default:
                    oMilestoneStyle = oStyle.MilestoneStyle;
                    mp_DrawFigure(X1 + ((X2 - X1) / 2), Y1, Y2 - Y1, Y2 - Y1, oMilestoneStyle.ShapeIndex, oMilestoneStyle.BorderColor, oMilestoneStyle.FillColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    break;
            }
            mp_DrawItemText(X1, Y1, X2, Y2, lLeftTrim, lRightTrim, oStyle, sText);
            if (oStyle.SelectionRectangleStyle.Visible == true & bSelected)
            {
                if (oStyle.SelectionRectangleStyle.Mode == E_SELECTIONRECTANGLEMODE.SRM_DOTTED)
                {
                    mp_DrawFocusRectangle(X1, Y1, X2, Y2);
                }
                else if (oStyle.SelectionRectangleStyle.Mode == E_SELECTIONRECTANGLEMODE.SRM_COLOR)
                {
                    mp_DrawLine(X1, Y1, X2, Y2, GRE_LINETYPE.LT_BORDER, oStyle.SelectionRectangleStyle.Color, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.SelectionRectangleStyle.BorderWidth);
                }
            }
        }

        internal void mp_DrawItemM(clsTask oTask, string sStyleIndex, bool Selected, clsStyle v_oStyle)
        {
            mp_DrawItemI(oTask.Left, oTask.Top, oTask.Right, oTask.Bottom, oTask.StyleIndex, oTask.Text, Selected, oTask.Style.MilestoneStyle.Image, oTask.LeftTrim, oTask.RightTrim, v_oStyle);
        }

        internal void mp_DrawItemEx(int X1, int Y1, int X2, int Y2, string sText, bool bIsSelected, Image oImage, int lLeftTrim, int lRightTrim, clsStyle v_oStyle, Color clrBackColor, Color clrForeColor, Color clrStartGradientColor, Color clrEndGradientColor, Color clrHatchBackColor, Color clrHatchForeColor)
        {
            clsStyle oStyle;
            clsTaskStyle oTaskStyle;
            if ((v_oStyle == null))
            {
                mp_oControl.mp_ErrorReport(SYS_ERRORS.STYLE_NULL, "Style object is null when preparing to draw.", "mp_DrawItemEx");
                return;
            }
            else
            {
                oStyle = v_oStyle;
            }
            oTaskStyle = oStyle.TaskStyle;
            switch (oStyle.Appearance)
            {
                case E_STYLEAPPEARANCE.SA_RAISED:
                    mp_DrawEdge(X1, Y1, X2, Y2, clrBackColor, oStyle.ButtonStyle, GRE_EDGETYPE.ET_RAISED, true, v_oStyle);
                    break;
                case E_STYLEAPPEARANCE.SA_SUNKEN:
                    mp_DrawEdge(X1, Y1, X2, Y2, clrBackColor, oStyle.ButtonStyle, GRE_EDGETYPE.ET_SUNKEN, true, v_oStyle);
                    break;
                case E_STYLEAPPEARANCE.SA_FLAT:
                    int lTop = 0;
                    int lBottom = 0;
                    lTop = Y1;
                    lBottom = Y2;
                    switch (oStyle.FillMode)
                    {
                        case GRE_FILLMODE.FM_COMPLETELYFILLED:
                            break;
                        case GRE_FILLMODE.FM_UPPERHALFFILLED:
                            lBottom = Y1 + ((Y2 - Y1) / 2);
                            break;
                        case GRE_FILLMODE.FM_LOWERHALFFILLED:
                            lTop = Y2 - ((Y2 - Y1) / 2);
                            break;
                    }
                    if ((oStyle.BackgroundMode == GRE_BACKGROUNDMODE.FP_SOLID))
                    {
                        mp_DrawLine(X1, lTop, X2, lBottom, GRE_LINETYPE.LT_FILLED, clrBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    }
                    else if ((oStyle.BackgroundMode == GRE_BACKGROUNDMODE.FP_GRADIENT))
                    {
                        mp_GradientFill(X1, lTop, X2, lBottom, clrStartGradientColor, clrEndGradientColor, oStyle.GradientFillMode);
                    }
                    else if ((oStyle.BackgroundMode == GRE_BACKGROUNDMODE.FP_PATTERN))
                    {
                        mp_DrawPattern(X1, lTop, X2, lBottom, clrBackColor, oStyle.Pattern, oStyle.PatternFactor);
                    }
                    else if ((oStyle.BackgroundMode == GRE_BACKGROUNDMODE.FP_HATCH))
                    {
                        mp_HatchFill(X1, lTop, X2, lBottom, clrHatchForeColor, clrHatchBackColor, oStyle.HatchStyle);
                    }
                    if (oStyle.BorderStyle == GRE_BORDERSTYLE.SBR_SINGLE)
                    {
                        mp_DrawLine(X1, lTop, X2, lBottom, GRE_LINETYPE.LT_BORDER, oStyle.BorderColor, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.BorderWidth);
                    }
                    else if (oStyle.BorderStyle == GRE_BORDERSTYLE.SBR_CUSTOM)
                    {
                        if (oStyle.CustomBorderStyle.Left == true)
                        {
                            mp_DrawLine(X1, lTop, X1, lBottom, GRE_LINETYPE.LT_NORMAL, oStyle.BorderColor, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.BorderWidth);
                        }
                        if (oStyle.CustomBorderStyle.Top == true)
                        {
                            mp_DrawLine(X1, lTop, X2, lTop, GRE_LINETYPE.LT_NORMAL, oStyle.BorderColor, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.BorderWidth);
                        }
                        if (oStyle.CustomBorderStyle.Right == true)
                        {
                            mp_DrawLine(X2, lTop, X2, lBottom, GRE_LINETYPE.LT_NORMAL, oStyle.BorderColor, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.BorderWidth);
                        }
                        if (oStyle.CustomBorderStyle.Bottom == true)
                        {
                            mp_DrawLine(X1, lBottom, X2, lBottom, GRE_LINETYPE.LT_NORMAL, oStyle.BorderColor, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.BorderWidth);
                        }
                    }
                    mp_DrawFigure(X2, Y1, Y2 - Y1, Y2 - Y1, oTaskStyle.EndShapeIndex, oTaskStyle.EndBorderColor, oTaskStyle.EndFillColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    mp_DrawFigure(X1, Y1, Y2 - Y1, Y2 - Y1, oTaskStyle.StartShapeIndex, oTaskStyle.StartBorderColor, oTaskStyle.StartFillColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    break;
                case E_STYLEAPPEARANCE.SA_GRAPHICAL:

                    if (oTaskStyle.MiddleImage == null | oTaskStyle.StartImage == null | oTaskStyle.EndImage == null)
                    {
                    }
                    else
                    {
                        int lImageHeight = 0;
                        int lImageWidth = 0;
                        lImageHeight = oTaskStyle.MiddleImage.Height;
                        lImageWidth = oTaskStyle.MiddleImage.Width;
                        mp_TileImageHorizontal(oTaskStyle.MiddleImage, X1, Y1, X2, Y2, oStyle.UseMask);
                        //// Exit if the start and end sections don't fit
                        if ((X2 - X1) > (lImageWidth * 2))
                        {
                            //// Left Section
                            mp_PaintImage(oTaskStyle.StartImage, X1, Y1, X1 + lImageWidth, Y1 + lImageHeight, 0, 0, oStyle.UseMask);
                            //// Right Section
                            mp_PaintImage(oTaskStyle.EndImage, X2 - lImageWidth, Y1, X2, Y1 + lImageHeight, 0, 0, oStyle.UseMask);
                        }
                    }
                    break;
            }
            if ((oImage != null))
            {
                mp_DrawImage(oImage, oStyle.ImageAlignmentHorizontal, oStyle.ImageAlignmentVertical, oStyle.ImageXMargin, oStyle.ImageYMargin, X1, X2, Y1, Y2, oStyle.UseMask);
            }
            mp_DrawItemText(X1, Y1, X2, Y2, lLeftTrim, lRightTrim, oStyle, sText);
            if (oStyle.SelectionRectangleStyle.Visible == true & bIsSelected)
            {
                mp_DrawSelectionRectangle(X1, Y1, X2, Y2, oStyle);
            }
        }

        internal void mp_DrawSelectionRectangle(int X1, int Y1, int X2, int Y2, clsStyle oStyle)
        {
            if (oStyle.SelectionRectangleStyle.Mode == E_SELECTIONRECTANGLEMODE.SRM_DOTTED)
            {
                mp_DrawFocusRectangle(X1 + oStyle.SelectionRectangleStyle.OffsetLeft, Y1 + oStyle.SelectionRectangleStyle.OffsetTop, X2 - oStyle.SelectionRectangleStyle.OffsetRight, Y2 - oStyle.SelectionRectangleStyle.OffsetBottom);
            }
            else if (oStyle.SelectionRectangleStyle.Mode == E_SELECTIONRECTANGLEMODE.SRM_COLOR)
            {
                mp_DrawLine(X1 + oStyle.SelectionRectangleStyle.OffsetLeft, Y1 + oStyle.SelectionRectangleStyle.OffsetTop, X2 - oStyle.SelectionRectangleStyle.OffsetRight, Y2 - oStyle.SelectionRectangleStyle.OffsetBottom, GRE_LINETYPE.LT_BORDER, oStyle.SelectionRectangleStyle.Color, GRE_LINEDRAWSTYLE.LDS_SOLID, oStyle.SelectionRectangleStyle.BorderWidth);
            }
        }

        internal void mp_DrawItemRow(int X1, int Y1, int X2, int Y2, string sText, bool bIsSelected, Image oImage, int lLeftTrim, int lRightTrim, clsStyle v_oStyle, clsRow oRow)
        {
            GRE_BACKGROUNDMODE yBackgroundMode;
            if (oRow.Highlighted == true)
            {
                mp_DrawLine(X1, Y1, X2, Y2, GRE_LINETYPE.LT_FILLED, mp_oControl.Configuration.RowHighlightedBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                yBackgroundMode = v_oStyle.BackgroundMode;
                if (v_oStyle.BackgroundMode != GRE_BACKGROUNDMODE.FP_TRANSPARENT)
                {
                    v_oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_TRANSPARENT;
                }
                mp_DrawItem(X1, Y1, X2, Y2, "", sText, bIsSelected, oImage, lLeftTrim, lRightTrim, v_oStyle);
                v_oStyle.BackgroundMode = yBackgroundMode;
            }
            else
            {
                if (mp_oControl.Configuration.AlternatingRowStyles == true)
                {
                    yBackgroundMode = v_oStyle.BackgroundMode;
                    if (v_oStyle.BackgroundMode != GRE_BACKGROUNDMODE.FP_TRANSPARENT)
                    {
                        v_oStyle.BackgroundMode = GRE_BACKGROUNDMODE.FP_TRANSPARENT;
                    }
                    if (oRow.Index % 2 == 1)
                    {
                        ////Odd
                        mp_DrawLine(X1, Y1, X2, Y2, GRE_LINETYPE.LT_FILLED, mp_oControl.Configuration.RowOddBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                        mp_DrawItem(X1, Y1, X2, Y2, "", sText, bIsSelected, oImage, lLeftTrim, lRightTrim,
                        v_oStyle);
                    }
                    else
                    {
                        ////Even
                        mp_DrawLine(X1, Y1, X2, Y2, GRE_LINETYPE.LT_FILLED, mp_oControl.Configuration.RowEvenBackColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                        mp_DrawItem(X1, Y1, X2, Y2, "", sText, bIsSelected, oImage, lLeftTrim, lRightTrim,
                        v_oStyle);
                    }
                    v_oStyle.BackgroundMode = yBackgroundMode;
                }
                else
                {
                    mp_DrawItem(X1, Y1, X2, Y2, "", sText, bIsSelected, oImage, lLeftTrim, lRightTrim,
                    v_oStyle);
                }
            }
        }

        internal void mp_DrawItem(int X1, int Y1, int X2, int Y2, string sStyleIndex, string sText, bool bIsSelected, Image oImage, int lLeftTrim, int lRightTrim, clsStyle v_oStyle)
        {
            clsStyle oStyle;
            if ((v_oStyle == null))
            {
                if (Globals.g_IsNumeric(sStyleIndex))
                {
                    if (System.Convert.ToInt32(sStyleIndex) < 0 | System.Convert.ToInt32(sStyleIndex) > mp_oControl.Styles.Count)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.STYLE_INVALID_INDEX, "Style object element not found when preparing to draw, invalid index", "mp_DrawItem");
                        return;
                    }
                }
                else
                {
                    if (mp_oControl.Styles.oCollection.m_bDoesKeyExist(sStyleIndex) == false)
                    {
                        mp_oControl.mp_ErrorReport(SYS_ERRORS.STYLE_INVALID_KEY, "Style object element not found when preparing to draw, invalid key (\"" + sStyleIndex + "\")", "mp_DrawItem");
                        return;
                    }
                }
                oStyle = mp_oControl.Styles.FItem(sStyleIndex);
            }
            else
            {
                oStyle = v_oStyle;
            }
            mp_DrawItemEx(X1, Y1, X2, Y2, sText, bIsSelected, oImage, lLeftTrim, lRightTrim, oStyle, oStyle.BackColor, oStyle.ForeColor, oStyle.StartGradientColor, oStyle.EndGradientColor, oStyle.HatchBackColor, oStyle.HatchForeColor);
        }
    
		private void mp_DrawItemText(int X1, int Y1, int X2, int Y2, int lLeftTrim, int lRightTrim, clsStyle oStyle, string sText)
		{
			int lTextLeft = 0;
			int lTextRight = 0;
			int lTextTop = 0;
			int lTextBottom = 0;
			if (oStyle.TextVisible == false) 
			{
				return;
			}
			if (sText == "") 
			{
				return;
			}
			switch (oStyle.TextPlacement) 
			{
				case E_TEXTPLACEMENT.SCP_OBJECTEXTENTSPLACEMENT:
					if ((oStyle.DrawTextInVisibleArea == false)) 
					{
						lTextLeft = X1;
						lTextRight = X2;
					}
					else 
					{
						lTextLeft = lLeftTrim;
						lTextRight = lRightTrim;
					}

					lTextTop = Y1;
					lTextBottom = Y2;
					if (oStyle.TextAlignmentHorizontal == GRE_HORIZONTALALIGNMENT.HAL_LEFT) 
					{
						lTextLeft = X1 + oStyle.TextXMargin;
					}

					if (oStyle.TextAlignmentHorizontal == GRE_HORIZONTALALIGNMENT.HAL_RIGHT) 
					{
						lTextRight = X2 - oStyle.TextXMargin;
					}

					if (oStyle.TextAlignmentVertical == GRE_VERTICALALIGNMENT.VAL_TOP) 
					{
						lTextTop = Y1 + oStyle.TextYMargin;
					}

					if (oStyle.TextAlignmentVertical == GRE_VERTICALALIGNMENT.VAL_BOTTOM) 
					{
						lTextBottom = Y2 - oStyle.TextYMargin;
					}

					mp_DrawAlignedText(lTextLeft, lTextTop, lTextRight, lTextBottom, sText, oStyle.TextAlignmentHorizontal, oStyle.TextAlignmentVertical, oStyle.ForeColor, oStyle.Font, oStyle.ClipText
						);
					break;
				case E_TEXTPLACEMENT.SCP_OFFSETPLACEMENT:
					mp_DrawTextEx(X1 + oStyle.TextFlags.OffsetLeft, Y1 + oStyle.TextFlags.OffsetTop, X2 - oStyle.TextFlags.OffsetRight, Y2 - oStyle.TextFlags.OffsetBottom, sText, oStyle.TextFlags, oStyle.ForeColor, oStyle.Font, oStyle.ClipText);
					break;
				case E_TEXTPLACEMENT.SCP_EXTERIORPLACEMENT:
					if (oStyle.TextAlignmentHorizontal == GRE_HORIZONTALALIGNMENT.HAL_LEFT) 
					{
						lTextLeft = X1 - mp_lStrWidth(sText, oStyle.Font) - oStyle.TextXMargin;
						lTextRight = X1 - oStyle.TextXMargin + 1;
					}

					if (oStyle.TextAlignmentHorizontal == GRE_HORIZONTALALIGNMENT.HAL_RIGHT) 
					{
						lTextLeft = X2 + oStyle.TextXMargin;
						lTextRight = X2 + mp_lStrWidth(sText, oStyle.Font) + oStyle.TextXMargin + 1;
					}

					if (oStyle.TextAlignmentHorizontal == GRE_HORIZONTALALIGNMENT.HAL_CENTER) 
					{
						lTextLeft = X1;
						lTextRight = X2 + 1;
					}

					if (oStyle.TextAlignmentVertical == GRE_VERTICALALIGNMENT.VAL_TOP) 
					{
						lTextTop = Y1 - mp_lStrHeight(sText, oStyle.Font) - oStyle.TextYMargin;
						lTextBottom = Y1 - oStyle.TextYMargin + 3;
					}

					if (oStyle.TextAlignmentVertical == GRE_VERTICALALIGNMENT.VAL_BOTTOM) 
					{
						lTextTop = Y2 + oStyle.TextYMargin;
						lTextBottom = Y2 + mp_lStrHeight(sText, oStyle.Font) + oStyle.TextYMargin + 3;
					}

					if (oStyle.TextAlignmentVertical == GRE_VERTICALALIGNMENT.VAL_CENTER) 
					{
						lTextTop = Y1;
						lTextBottom = Y2 + 3;
					}
					mp_DrawAlignedText(lTextLeft, lTextTop, lTextRight, lTextBottom, sText, GRE_HORIZONTALALIGNMENT.HAL_LEFT, GRE_VERTICALALIGNMENT.VAL_TOP, oStyle.ForeColor, oStyle.Font, oStyle.ClipText);
					break;
			}
		}

        internal void mp_DrawPoint(int X, int Y, Color clrColor)
        {
            SolidBrush mp_ucBrush = new SolidBrush(clrColor);
            oGraphics.FillRectangle(mp_ucBrush, X, Y, 1, 1);
        }

        internal void mp_DrawArrow(int X, int Y, GRE_ARROWDIRECTION yArrowDirection, int lArrowSize, Color clrColor)
        {
            int i = 0;
            switch (yArrowDirection)
            {
                case GRE_ARROWDIRECTION.AWD_LEFT:
                    mp_DrawPoint(X, Y, clrColor);
                    for (i = 1; i <= lArrowSize; i++)
                    {
                        X = X + 1;
                        mp_DrawLine(X, Y - i, X, Y + i, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    }

                    break;
                case GRE_ARROWDIRECTION.AWD_RIGHT:
                    mp_DrawPoint(X, Y, clrColor);
                    for (i = 1; i <= lArrowSize; i++)
                    {
                        X = X - 1;
                        mp_DrawLine(X, Y - i, X, Y + i, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    }

                    break;
                case GRE_ARROWDIRECTION.AWD_UP:
                    mp_DrawPoint(X, Y, clrColor);
                    for (i = 1; i <= lArrowSize; i++)
                    {
                        Y = Y + 1;
                        mp_DrawLine(X - i, Y, X + i, Y, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    }

                    break;
                case GRE_ARROWDIRECTION.AWD_DOWN:
                    mp_DrawPoint(X, Y, clrColor);
                    for (i = 1; i <= lArrowSize; i++)
                    {
                        Y = Y - 1;
                        mp_DrawLine(X - i, Y, X + i, Y, GRE_LINETYPE.LT_NORMAL, clrColor, GRE_LINEDRAWSTYLE.LDS_SOLID);
                    }

                    break;
            }
        }

        internal void mp_DrawExpandIcon(int X, int Y, Color oColor, Color oDropShadowColor, Color oBackgroundColor)
        {
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 1, Y), new Point(X + 1, Y + 8));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 1, Y), new Point(X + 5, Y + 4));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 1, Y + 8), new Point(X + 5, Y + 4));
            oGraphics.DrawLine(new Pen(oDropShadowColor, 1), new Point(X + 2, Y), new Point(X + 6, Y + 4));
            oGraphics.DrawLine(new Pen(oDropShadowColor, 1), new Point(X + 2, Y + 8), new Point(X + 6, Y + 4));
            oGraphics.DrawLine(new Pen(oBackgroundColor, 1), new Point(X + 2, Y + 2), new Point(X + 2, Y + 6));
            oGraphics.DrawLine(new Pen(oBackgroundColor, 1), new Point(X + 3, Y + 3), new Point(X + 3, Y + 5));
            oGraphics.FillRectangle(new SolidBrush(oBackgroundColor), X + 4, Y + 4, 1, 1);
        }

        internal void mp_DrawCollapseIcon(int X, int Y, Color oColor, Color oDropShadowColor)
        {
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 5, Y + 2), new Point(X + 6, Y + 2));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 4, Y + 3), new Point(X + 6, Y + 3));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 3, Y + 4), new Point(X + 6, Y + 4));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 2, Y + 5), new Point(X + 6, Y + 5));
            oGraphics.DrawLine(new Pen(oColor, 1), new Point(X + 1, Y + 6), new Point(X + 6, Y + 6));
            oGraphics.DrawLine(new Pen(oDropShadowColor, 1), new Point(X + 6, Y + 1), new Point(X + 1, Y + 6));
        }

	}
}
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

namespace AGCSN
{
	public class clsToolTip
	{

        private ActiveGanttCSNCtl mp_oControl;
		private int mp_lLeft;
		private int mp_lTop;
		private int mp_lWidth;
		private int mp_lHeight;
		private string mp_sText;
		private bool mp_bVisible;
		private bool mp_bBackupDCActive;
		private Font mp_oFont;
		private int mp_lBackupLeft;
		private int mp_lBackupTop;
		private int mp_lBackupRight;
		private int mp_lBackupBottom;
		private bool mp_bAutomaticSizing = false;
		private Color mp_clrBackColor = Color.FromArgb(255, 255, 255, 224);
		private Color mp_clrForeColor = Color.FromArgb(255, 0, 0, 0);
		private Color mp_clrBorderColor = Color.FromArgb(255, 0, 0, 0);

        internal clsToolTip(ActiveGanttCSNCtl oControl)
		{
            mp_oControl = oControl;
            mp_oFont = (Font)mp_oControl.Configuration.DefaultFont.Clone();
		}
    
		public Font Font 
		{
			get { return mp_oFont; }
			set { mp_oFont = value; }
		}
    
		public Color BackColor 
		{
			get { return mp_clrBackColor; }
			set { mp_clrBackColor = value; }
		}
    
		public Color ForeColor 
		{
			get { return mp_clrForeColor; }
			set { mp_clrForeColor = value; }
		}
    
		public Color BorderColor 
		{
			get { return mp_clrBorderColor; }
			set { mp_clrBorderColor = value; }
		}
    
		public string Text 
		{
			get { return mp_sText; }
			set 
			{
				mp_sText = value;
				if (mp_bAutomaticSizing == true) 
				{
					Graphics lControlGraphics = null;
					SizeF oSize = new SizeF(0, 0);
					lControlGraphics = mp_oControl.GetGraphicsObject();
					oSize = lControlGraphics.MeasureString(mp_sText, mp_oFont);
					mp_lWidth = System.Convert.ToInt32(oSize.Width);
					mp_lHeight = System.Convert.ToInt32(oSize.Height);
				}
			}
		}
    
		public bool AutomaticSizing 
		{
			get { return mp_bAutomaticSizing; }
			set { mp_bAutomaticSizing = value; }
		}
    
		public int Left 
		{
			get { return mp_lLeft; }
			set { mp_lLeft = value; }
		}
    
		public int Right 
		{
			get { return mp_lLeft + mp_lWidth; }
		}
    
		public int Top 
		{
			get { return mp_lTop; }
			set { mp_lTop = value; }
		}
    
		public int Bottom 
		{
			get { return mp_lTop + mp_lHeight; }
		}
    
		public int Width 
		{
			get { return mp_lWidth; }
			set { mp_lWidth = value; }
		}
    
		public int Height 
		{
			get { return mp_lHeight; }
			set { mp_lHeight = value; }
		}
    
		public bool Visible 
		{
			get { return mp_bVisible; }
			set 
			{
				Graphics lControlGraphics = null;
				IntPtr lControlHDC = new IntPtr();
				mp_bVisible = value;
				if ((mp_bBackupDCActive == true)) 
				{
					RestoreBackupDC();
				}
				if ((mp_lWidth == 0 | mp_lHeight == 0)) 
				{
					mp_bVisible = false;
				}
				if ((mp_bVisible == true)) 
				{
					Pen oPen = new Pen(Color.FromArgb(255, 0, 0, 0));
					lControlGraphics = mp_oControl.GetGraphicsObject();
					lControlHDC = lControlGraphics.GetHdc();
					mp_lBackupLeft = mp_lLeft;
					mp_lBackupTop = mp_lTop;
					mp_lBackupRight = mp_lLeft + mp_lWidth;
					mp_lBackupBottom = mp_lTop + mp_lHeight;
					lControlGraphics.ReleaseHdc(lControlHDC);
					lControlGraphics.FillRectangle(new SolidBrush(mp_clrBackColor), mp_lLeft, mp_lTop, mp_lWidth, mp_lHeight);
					lControlGraphics.DrawLine(oPen, mp_lLeft, mp_lTop, mp_lLeft + mp_lWidth - 1, mp_lTop);
					lControlGraphics.DrawLine(oPen, mp_lLeft + mp_lWidth - 1, mp_lTop, mp_lLeft + mp_lWidth - 1, mp_lTop + mp_lHeight - 1);
					lControlGraphics.DrawLine(oPen, mp_lLeft, mp_lTop, mp_lLeft, mp_lTop + mp_lHeight - 1);
					lControlGraphics.DrawLine(oPen, mp_lLeft, mp_lTop + mp_lHeight - 1, mp_lLeft + mp_lWidth - 1, mp_lTop + mp_lHeight - 1);
                    mp_oControl.clsG.mp_oToolTipGraphics = lControlGraphics;
                    mp_oControl.clsG.bToolTipGraphics = true;
                    mp_oControl.clsG.mp_ClipRegion(mp_lLeft, mp_lTop, Right - 1, Bottom - 1, false);
					switch (mp_oControl.ToolTipEventArgs.ToolTipType) 
					{
						case E_TOOLTIPTYPE.TPT_HOVER:
                            mp_oControl.ToolTipEventArgs.Graphics = lControlGraphics;
                            mp_oControl.ToolTipEventArgs.CustomDraw = false;
                            mp_oControl.FireOnMouseHoverToolTipDraw(mp_oControl.ToolTipEventArgs.EventTarget);
							break;
						case E_TOOLTIPTYPE.TPT_MOVEMENT:
                            mp_oControl.ToolTipEventArgs.Graphics = lControlGraphics;
                            mp_oControl.ToolTipEventArgs.CustomDraw = false;
                            mp_oControl.FireOnMouseMoveToolTipDraw(mp_oControl.ToolTipEventArgs.Operation);
							break;
					}
                    mp_oControl.clsG.mp_ClearClipRegion();
                    mp_oControl.clsG.bToolTipGraphics = false;
					if (mp_oControl.ToolTipEventArgs.CustomDraw == false) 
					{
						lControlGraphics.DrawString(mp_sText, mp_oFont, new SolidBrush(mp_clrForeColor), mp_lLeft, mp_lTop);
					}
					lControlGraphics.Dispose();
					//lBackupGraphics.Dispose();
					mp_bBackupDCActive = true;
				}
			}
		}
    
		private void RestoreBackupDC()
		{
			Graphics lControlGraphics = null;
			lControlGraphics = mp_oControl.GetGraphicsObject();
			if (mp_bVisible == true) 
			{
				Rectangle oRect = new Rectangle(0, 0, 0, 0);
				oRect.X = mp_lLeft;
				oRect.Y = mp_lTop;
				oRect.Width = mp_lWidth;
				oRect.Height = mp_lHeight;
				lControlGraphics.ExcludeClip(oRect);
			}
			lControlGraphics.DrawImage(mp_oControl.GetBitmap(), 0, 0);
			mp_bBackupDCActive = false;
		}
    
	}
}
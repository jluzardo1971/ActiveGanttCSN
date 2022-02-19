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
using System.Text;

namespace AGCSN
{
    class clsTextBox : System.Windows.Forms.TextBox
    {
        private ActiveGanttCSNCtl mp_oControl;
        private clsColumn mp_oColumn;
        private clsRow mp_oRow;
        private clsCell mp_oCell;
        private clsNode mp_oNode;
        private clsTask mp_oTask;
        private E_TEXTOBJECTTYPE mp_yObjectType;
        private string mp_sText;
        private int mp_lIndex;
        private int mp_lIndex2;
        internal bool mp_bInitialized;

        internal clsTextBox(ActiveGanttCSNCtl oControl)
        {
            mp_oControl = oControl;
            this.Parent = mp_oControl;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Visible = false;
            this.Multiline = true;
            
            mp_bInitialized = false;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clsTextBox_KeyUp);
        }

        public bool Initialized
        {
            get { return mp_bInitialized; }
        }

        internal void Initialize(int lIndex, int lIndex2, E_TEXTOBJECTTYPE yObjectType, int X, int Y)
        {
            mp_yObjectType = yObjectType;
            mp_lIndex = lIndex;
            mp_lIndex2 = lIndex2;
            if (mp_bInitialized == true)
            {
                Terminate();
            }
            mp_oControl.MouseKeyboardEvents.mp_yOperation = E_OPERATION.EO_NONE;
            mp_oControl.MouseKeyboardEvents.mp_SetCursor(E_CURSORTYPE.CT_NORMAL);
            switch (mp_yObjectType)
            {
                case E_TEXTOBJECTTYPE.TOT_COLUMN:
                    mp_oColumn = mp_oControl.Columns.Item(lIndex.ToString());
                    this.Font = mp_oColumn.Style.Font;
                    this.Left = mp_oColumn.mp_lTextLeft;
                    this.Top = mp_oColumn.mp_lTextTop;
                    this.Width = mp_oColumn.mp_lTextRight - mp_oColumn.mp_lTextLeft + 1;
                    this.Height = mp_oColumn.mp_lTextBottom - mp_oColumn.mp_lTextTop + 1;
                    this.Text = mp_oColumn.Text;
                    this.BackColor = mp_oColumn.Style.TextEditBackColor;
                    this.ForeColor = mp_oColumn.Style.TextEditForeColor;
                    break;
                case E_TEXTOBJECTTYPE.TOT_NODE:
                    mp_oRow = mp_oControl.Rows.Item(lIndex.ToString());
                    mp_oNode = mp_oRow.Node;
                    this.Font = mp_oNode.Style.Font;
                    this.Left = mp_oNode.mp_lTextLeft;
                    this.Top = mp_oNode.mp_lTextTop;
                    this.Width = mp_oNode.mp_lTextRight - mp_oNode.mp_lTextLeft + 1;
                    this.Height = mp_oNode.mp_lTextBottom - mp_oNode.mp_lTextTop + 1;
                    this.Text = mp_oNode.Text;
                    this.BackColor = mp_oNode.Style.TextEditBackColor;
                    this.ForeColor = mp_oNode.Style.TextEditForeColor;
                    break;
                case E_TEXTOBJECTTYPE.TOT_ROW:
                    mp_oRow = mp_oControl.Rows.Item(lIndex.ToString());
                    this.Font = mp_oRow.Style.Font;
                    this.Left = mp_oRow.mp_lTextLeft;
                    this.Top = mp_oRow.mp_lTextTop;
                    this.Width = mp_oRow.mp_lTextRight - mp_oRow.mp_lTextLeft + 1;
                    this.Height = mp_oRow.mp_lTextBottom - mp_oRow.mp_lTextTop + 1;
                    this.Text = mp_oRow.Text;
                    this.BackColor = mp_oRow.Style.TextEditBackColor;
                    this.ForeColor = mp_oRow.Style.TextEditForeColor;
                    break;
                case E_TEXTOBJECTTYPE.TOT_CELL:
                    mp_oRow = mp_oControl.Rows.Item(lIndex.ToString());
                    mp_oCell = mp_oRow.Cells.Item(lIndex2.ToString());
                    this.Font = mp_oCell.Style.Font;
                    this.Left = mp_oCell.mp_lTextLeft;
                    this.Top = mp_oCell.mp_lTextTop;
                    this.Width = mp_oCell.mp_lTextRight - mp_oCell.mp_lTextLeft + 1;
                    this.Height = mp_oCell.mp_lTextBottom - mp_oCell.mp_lTextTop + 1;
                    this.Text = mp_oCell.Text;
                    this.BackColor = mp_oCell.Style.TextEditBackColor;
                    this.ForeColor = mp_oCell.Style.TextEditForeColor;
                    break;
                case E_TEXTOBJECTTYPE.TOT_TASK:
                    mp_oTask = mp_oControl.Tasks.Item(lIndex.ToString());
                    this.Font = mp_oTask.Style.Font;
                    this.Left = mp_oTask.mp_lTextLeft;
                    this.Top = mp_oTask.mp_lTextTop;
                    this.Width = mp_oTask.mp_lTextRight - mp_oTask.mp_lTextLeft + 1;
                    this.Height = mp_oTask.mp_lTextBottom - mp_oTask.mp_lTextTop + 1;
                    this.Text = mp_oTask.Text;
                    this.BackColor = mp_oTask.Style.TextEditBackColor;
                    this.ForeColor = mp_oTask.Style.TextEditForeColor;
                    break;
            }

            this.Visible = true;
            if (this.Text.Length > 0)
            {
                System.Drawing.Point oPoint = new System.Drawing.Point(X - this.Left, Y - this.Top);
                this.SelectionStart = this.GetCharIndexFromPosition(oPoint);
                this.SelectionLength = 0;
            }
            this.Focus();
            mp_sText = this.Text;
            mp_oControl.TextEditEventArgs.Clear();
            mp_oControl.TextEditEventArgs.ObjectType = mp_yObjectType;
            if (mp_yObjectType == E_TEXTOBJECTTYPE.TOT_CELL)
            {
                mp_oControl.TextEditEventArgs.ParentObjectIndex = mp_lIndex;
                mp_oControl.TextEditEventArgs.ObjectIndex = mp_lIndex2;
            }
            else
            {
                mp_oControl.TextEditEventArgs.ParentObjectIndex = 0;
                mp_oControl.TextEditEventArgs.ObjectIndex = mp_lIndex;
            }
            mp_oControl.TextEditEventArgs.Text = this.Text;
            mp_oControl.FireBeginTextEdit();
            if (mp_oControl.TextEditEventArgs.Text != this.Text)
            {
                this.Text = mp_oControl.TextEditEventArgs.Text;
            }
            mp_bInitialized = true;
        }

        internal void Terminate()
        {
            if (mp_bInitialized == true)
            {
                mp_oControl.TextEditEventArgs.Clear();
                mp_oControl.TextEditEventArgs.ObjectType = mp_yObjectType;
                if (mp_yObjectType == E_TEXTOBJECTTYPE.TOT_CELL)
                {
                    mp_oControl.TextEditEventArgs.ParentObjectIndex = mp_lIndex;
                    mp_oControl.TextEditEventArgs.ObjectIndex = mp_lIndex2;
                }
                else
                {
                    mp_oControl.TextEditEventArgs.ParentObjectIndex = 0;
                    mp_oControl.TextEditEventArgs.ObjectIndex = mp_lIndex;
                }
                mp_oControl.TextEditEventArgs.Text = this.Text;
                mp_oControl.FireEndTextEdit();
            }
            mp_bInitialized = false;
            this.Visible = false;
        }

        private void clsTextBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (mp_yObjectType)
            {
                case E_TEXTOBJECTTYPE.TOT_COLUMN:
                    mp_oColumn.Text = this.Text;
                    mp_oControl.Redraw();
                    this.Left = mp_oColumn.mp_lTextLeft;
                    this.Top = mp_oColumn.mp_lTextTop;
                    this.Width = mp_oColumn.mp_lTextRight - mp_oColumn.mp_lTextLeft + 1;
                    this.Height = mp_oColumn.mp_lTextBottom - mp_oColumn.mp_lTextTop + 1;
                    break;
                case E_TEXTOBJECTTYPE.TOT_NODE:
                    mp_oNode.Text = this.Text;
                    mp_oControl.Redraw();
                    this.Left = mp_oNode.mp_lTextLeft;
                    this.Top = mp_oNode.mp_lTextTop;
                    this.Width = mp_oNode.mp_lTextRight - mp_oNode.mp_lTextLeft + 1;
                    this.Height = mp_oNode.mp_lTextBottom - mp_oNode.mp_lTextTop + 1;
                    break;
                case E_TEXTOBJECTTYPE.TOT_ROW:
                    mp_oRow.Text = this.Text;
                    mp_oControl.Redraw();
                    this.Left = mp_oRow.mp_lTextLeft;
                    this.Top = mp_oRow.mp_lTextTop;
                    this.Width = mp_oRow.mp_lTextRight - mp_oRow.mp_lTextLeft + 1;
                    this.Height = mp_oRow.mp_lTextBottom - mp_oRow.mp_lTextTop + 1;
                    break;
                case E_TEXTOBJECTTYPE.TOT_CELL:
                    mp_oCell.Text = this.Text;
                    mp_oControl.Redraw();
                    this.Left = mp_oCell.mp_lTextLeft;
                    this.Top = mp_oCell.mp_lTextTop;
                    this.Width = mp_oCell.mp_lTextRight - mp_oCell.mp_lTextLeft + 1;
                    this.Height = mp_oCell.mp_lTextBottom - mp_oCell.mp_lTextTop + 1;
                    break;
                case E_TEXTOBJECTTYPE.TOT_TASK:
                    mp_oTask.Text = this.Text;
                    mp_oControl.Redraw();
                    this.Left = mp_oTask.mp_lTextLeft;
                    this.Top = mp_oTask.mp_lTextTop;
                    this.Width = mp_oTask.mp_lTextRight - mp_oTask.mp_lTextLeft + 1;
                    this.Height = mp_oTask.mp_lTextBottom - mp_oTask.mp_lTextTop + 1;
                    break;
            }
        }



    }
}
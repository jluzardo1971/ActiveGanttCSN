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
using System.Data.SqlServerCe;
using System.Data;
using AGCSN;

namespace AGCSNCON
{

    public partial class fWBSProjectTaskView : System.Windows.Forms.Form
	{
        private int mp_lTaskIndex;
        private fWBSProject mp_oParent;


		public fWBSProjectTaskView(fWBSProject oParent, int lTaskIndex)
		{
			InitializeComponent();
            mp_oParent = oParent;
            mp_lTaskIndex = lTaskIndex;
		}

        private void fWBSProjectTaskView_Load(object sender, System.EventArgs e)
		{
            this.Left = (System.Int32)((Owner.Width - this.Width) / 2) + Owner.Left;
            this.Top = (System.Int32)((Owner.Height - this.Height) / 2) + Owner.Top;
            clsTask oTask = null;
            oTask = mp_oParent.ActiveGanttCSNCtl1.Tasks.Item(mp_lTaskIndex.ToString());
            this.Text = oTask.Row.Text;
            txtTaskName.Text = oTask.Row.Text;

            DataGrid1.TableStyles.Clear();
            DataSet oDataSet = null;

            SqlCeDataAdapter oAdapter = new SqlCeDataAdapter();
            oDataSet = new DataSet();
            string sSQL = "SELECT tb_GuysStThomas_Predecessors.lSuccessorTaskID, tb_GuysStThomas_Predecessors.lPredecessorTaskID, tb_GuysStThomas.sDescription AS sDescription, " +
            "  (CASE WHEN tb_GuysStThomas_Predecessors.lType=0 THEN 'End-To-Start (ES)' ELSE '' END) " +
            "+ (CASE WHEN tb_GuysStThomas_Predecessors.lType=1 THEN 'Start-To-Start (SS)' ELSE '' END) " +
            "+ (CASE WHEN tb_GuysStThomas_Predecessors.lType=2 THEN 'End-To-End (EE)' ELSE '' END) " +
            "+ (CASE WHEN tb_GuysStThomas_Predecessors.lType=3 THEN 'Start-To-End (SE)' ELSE '' END) " +
            "AS sPredecessorType FROM tb_GuysStThomas RIGHT JOIN tb_GuysStThomas_Predecessors ON tb_GuysStThomas.[lTaskID] = tb_GuysStThomas_Predecessors.[lPredecessorTaskID] WHERE tb_GuysStThomas_Predecessors.lSuccessorTaskID=" + mp_lTaskIndex.ToString();
            oAdapter.SelectCommand = new SqlCeCommand(sSQL, mp_oParent.mp_oConn);
            oAdapter.Fill(oDataSet, "qry_GuysStThomas_Predecessors");

            DataGridTableStyle oTableStyle = new DataGridTableStyle();
            oTableStyle.MappingName = "qry_GuysStThomas_Predecessors";

            DataGridTextBoxColumn column = new DataGridTextBoxColumn();
            column.MappingName = "lPredecessorID";
            column.HeaderText = "ID";
            column.Width = 40;
            column.ReadOnly = true;
            oTableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "sDescription";
            column.HeaderText = "Predecessor Task Name";
            column.Width = 260;
            column.ReadOnly = true;
            oTableStyle.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn();
            column.MappingName = "sPredecessorType";
            column.HeaderText = "Type";
            column.Width = 100;
            column.ReadOnly = true;
            oTableStyle.GridColumnStyles.Add(column);

            DataGrid1.TableStyles.Add(oTableStyle);
            DataGrid1.DataSource = oDataSet;
            DataGrid1.Expand(-1);
            DataGrid1.NavigateTo(0, "qry_GuysStThomas_Predecessors");
            DataGrid1.Enabled = false;
		}

		private void cmdOK_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

        private string GetPredecessorType(int lType)
        {
            if (lType == 0)
            {
                return "End-To-Start (ES)";
            }
            else if (lType == 1)
            {
                return "Start-To-Start (SS)";
            }
            else if (lType == 2)
            {
                return "End-To-End (EE)";
            }
            else if (lType == 3)
            {
                return "Start-To-End (SE)";
            }
            return "";
        }

        private string GetTaskDescriptionByTaskKey(string sTaskKey)
        {
            foreach (clsTask oTask in mp_oParent.ActiveGanttCSNCtl1.Tasks)
            {
                if (oTask.Key == sTaskKey)
                {
                    return mp_oParent.ActiveGanttCSNCtl1.Rows.Item(oTask.RowKey).Node.Text;
                }
            }
            return "";
        }


	}
}
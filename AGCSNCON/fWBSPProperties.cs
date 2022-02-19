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

namespace AGCSNCON
{
    public partial class fWBSPProperties : Form
    {
        fWBSProject mp_oParent;

        public fWBSPProperties(fWBSProject oParent)
        {
            InitializeComponent();
            mp_oParent = oParent;
        }

        private void fWBSPProperties_Load(object sender, EventArgs e)
        {
            chkEnforcePredecessors.Checked = mp_oParent.ActiveGanttCSNCtl1.EnforcePredecessors;
            cboPredecessorMode.SelectedIndex = System.Convert.ToInt32(mp_oParent.ActiveGanttCSNCtl1.PredecessorMode);
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            mp_oParent.ActiveGanttCSNCtl1.EnforcePredecessors = chkEnforcePredecessors.Checked;
            mp_oParent.ActiveGanttCSNCtl1.PredecessorMode = (AGCSN.E_PREDECESSORMODE)System.Convert.ToInt32(cboPredecessorMode.SelectedIndex);
            this.Close();
        }
    }
}
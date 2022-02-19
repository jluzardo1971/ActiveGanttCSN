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
using System.Data;
using AGCSN;

namespace AGCSNCON
{
	public partial class fCarRentalVehicle : System.Windows.Forms.Form
	{

        private PRG_DIALOGMODE mp_yDialogMode;
        private fCarRental mp_oParent;
        private clsCR_Row mp_oRow;
        private clsCR_Row mp_oRowClone;
        private string mp_sRowKey;
        private bool mp_bBinding = false;

        #region "Constructors"


        public fCarRentalVehicle(PRG_DIALOGMODE yDialogMode, fCarRental oParent, string sRowKey)
        {
            InitializeComponent();
            mp_yDialogMode = yDialogMode;
            mp_oParent = oParent;
            if (mp_yDialogMode == PRG_DIALOGMODE.DM_ADD)
            {
                mp_sRowKey = oParent.Objects.Rows.Add(1);
            }
            else if (mp_yDialogMode == PRG_DIALOGMODE.DM_EDIT)
            {
                mp_sRowKey = sRowKey;
            }
            mp_oRow = mp_oParent.Objects.Rows.Item(mp_sRowKey);
        }

        #endregion

        #region "Form Loaded"

        private void fCarRentalVehicle_Load(object sender, System.EventArgs e)
		{
            mp_bBinding = true;
            mp_oRow.FillVehicleComboBoxes(drpCarTypeID, drpACRISS1, drpACRISS2, drpACRISS3, drpACRISS4);
            mp_bBinding = false;

            if (mp_yDialogMode == PRG_DIALOGMODE.DM_ADD)
            {
                this.Text = "Add New Vehicle";

                //// Automatically Generated Fields
                mp_oRow.sLicensePlates = Globals.g_GenerateRandomLicense();
                mp_oRow.lCarTypeID = Globals.GetRnd(1, 48);
            }
            else
            {
                this.Text = "Edit Vehicle";
                mp_oRowClone = new clsCR_Row(mp_oRow.mp_oAGRow, mp_oRow.mp_oControl, mp_oRow.mp_oConn, mp_oRow.mp_oObjects);
                mp_oRow.Clone(mp_oRowClone);
            }

            mp_bBinding = true;
            drpCarTypeID.SelectedValue = mp_oRow.lCarTypeID;
            drpACRISS1.SelectedValue = mp_oRow.GetACRISSLetter(1);
            drpACRISS2.SelectedValue = mp_oRow.GetACRISSLetter(2);
            drpACRISS3.SelectedValue = mp_oRow.GetACRISSLetter(3);
            drpACRISS4.SelectedValue = mp_oRow.GetACRISSLetter(4);
            txtLicensePlates.Text = mp_oRow.sLicensePlates;
            txtRate.Text = mp_oRow.sRate;
            txtNotes.Text = mp_oRow.sNotes;
            lblACRISS1.Text = mp_oRow.GetACRISSLetter(1);
            lblACRISS2.Text = mp_oRow.GetACRISSLetter(2);
            lblACRISS3.Text = mp_oRow.GetACRISSLetter(3);
            lblACRISS4.Text = mp_oRow.GetACRISSLetter(4);
            picMake.Image = Globals.g_GetImage("\\CarRental\\Big\\" + Globals.g_GetComboBoxSelectedItem(drpCarTypeID, "sDescription") + ".jpg");
            mp_bBinding = false;
		}

        #endregion

        #region "Form Closed"

        private void fCarRentalVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                mp_oRow.Update();
                mp_oRow.UpdateCaption();
                if (mp_yDialogMode == PRG_DIALOGMODE.DM_ADD)
                {
                    int l = 0;
                    l = System.Convert.ToInt32(System.Math.Floor(System.Convert.ToDecimal(mp_oParent.ActiveGanttCSNCtl1.CurrentViewObject.ClientArea.Height) / 41M));
                    if (((mp_oParent.ActiveGanttCSNCtl1.Rows.Count - l + 2) > 0))
                    {
                        mp_oParent.ActiveGanttCSNCtl1.VerticalScrollBar.Value = (mp_oParent.ActiveGanttCSNCtl1.Rows.Count - l + 2);
                    }
                }
                mp_oParent.ActiveGanttCSNCtl1.Redraw();
            }
            else
            {
                if (mp_yDialogMode == PRG_DIALOGMODE.DM_ADD)
                {
                    mp_oParent.Objects.Rows.Delete(mp_sRowKey);
                }
                else if (mp_yDialogMode == PRG_DIALOGMODE.DM_EDIT)
                {
                    mp_oRowClone.Clone(mp_oRow);
                }
            }
        }

        private void cmdOK_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Vehicle Controls"

        private void drpCarTypeID_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (mp_bBinding == true)
            {
                return;
            }
            mp_oRow.lCarTypeID = System.Convert.ToInt32(Globals.g_GetComboBoxSelectedItem(drpCarTypeID, "lCarTypeID"));
            mp_bBinding = true;
            drpACRISS1.SelectedValue = mp_oRow.GetACRISSLetter(1);
            drpACRISS2.SelectedValue = mp_oRow.GetACRISSLetter(2);
            drpACRISS3.SelectedValue = mp_oRow.GetACRISSLetter(3);
            drpACRISS4.SelectedValue = mp_oRow.GetACRISSLetter(4);
            lblACRISS1.Text = mp_oRow.GetACRISSLetter(1);
            lblACRISS2.Text = mp_oRow.GetACRISSLetter(2);
            lblACRISS3.Text = mp_oRow.GetACRISSLetter(3);
            lblACRISS4.Text = mp_oRow.GetACRISSLetter(4);
            txtRate.Text = mp_oRow.sRate;
            mp_bBinding = false;
            picMake.Image = Globals.g_GetImage("\\CarRental\\Big\\" + Globals.g_GetComboBoxSelectedItem(drpCarTypeID, "sDescription") + ".jpg");
		}

		private void drpACRISS1_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (mp_bBinding == true)
            {
                return;
            }
            lblACRISS1.Text = Globals.g_GetComboBoxSelectedItem(drpACRISS1, "sLetter");
            mp_oRow.sACRISSCode = lblACRISS1.Text + lblACRISS2.Text + lblACRISS3.Text + lblACRISS4.Text;
		}

		private void drpACRISS2_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (mp_bBinding == true)
            {
                return;
            }
            lblACRISS2.Text = Globals.g_GetComboBoxSelectedItem(drpACRISS2, "sLetter");
            mp_oRow.sACRISSCode = lblACRISS1.Text + lblACRISS2.Text + lblACRISS3.Text + lblACRISS4.Text;
		}

		private void drpACRISS3_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (mp_bBinding == true)
            {
                return;
            }
            lblACRISS3.Text = Globals.g_GetComboBoxSelectedItem(drpACRISS3, "sLetter");
            mp_oRow.sACRISSCode = lblACRISS1.Text + lblACRISS2.Text + lblACRISS3.Text + lblACRISS4.Text;	
		}

		private void drpACRISS4_SelectedValueChanged(object sender, System.EventArgs e)
		{
            if (mp_bBinding == true)
            {
                return;
            }
            lblACRISS4.Text = Globals.g_GetComboBoxSelectedItem(drpACRISS4, "sLetter");
            mp_oRow.sACRISSCode = lblACRISS1.Text + lblACRISS2.Text + lblACRISS3.Text + lblACRISS4.Text;
		}

        private void txtLicensePlates_TextChanged(object sender, EventArgs e)
        {
            if (mp_bBinding == true)
            {
                return;
            }
            mp_oRow.sLicensePlates = txtLicensePlates.Text;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (mp_bBinding == true)
            {
                return;
            }
            mp_oRow.cRate = System.Convert.ToDecimal(txtRate.Text);
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (mp_bBinding == true)
            {
                return;
            }
            mp_oRow.sNotes = txtNotes.Text;
        }

        #endregion

    }
}
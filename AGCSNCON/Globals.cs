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
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;
using AGCSN;


namespace AGCSNCON
{

    public enum PRG_DIALOGMODE
    {
        DM_ADD = 0,
        DM_EDIT = 1
    }

	public static class Globals
	{

        public static void g_Resize(System.Windows.Forms.Form oForm, ActiveGanttCSNCtl oControl, Panel oPanel, MenuStrip oMenuStrip, ToolStrip oToolStrip)
        {
            int lToolStripHeight = 0;
            int lMenuStripHeight = 0;
            if ((oToolStrip != null))
            {
                lToolStripHeight = oToolStrip.Height;
            }
            if ((oMenuStrip != null))
            {
                lMenuStripHeight = oMenuStrip.Height;
            }
            oPanel.Left = 10;
            oPanel.Top = lMenuStripHeight + lToolStripHeight + 10;
            oPanel.Width = oForm.ClientRectangle.Width - 20;
            oPanel.Height = oForm.ClientRectangle.Height - lMenuStripHeight - lToolStripHeight - 20;
            oControl.Left = 10;
            oControl.Top = 10;
            oControl.Width = oPanel.Width - 20;
            oControl.Height = oPanel.Height - 20;
        }

        public static int GetTextNum(TextBox oControl, int lDefault)
        {
            string sReturn = null;
            sReturn = oControl.Text;
            if (sReturn.Length == 0)
            {
                return lDefault;
            }
            if (IsNumeric(sReturn) == false)
            {
                return lDefault;
            }
            return System.Convert.ToInt32(sReturn);
        }

        public static string g_GetAppLocation()
        {
            return System.Windows.Forms.Application.StartupPath.Replace("\\bin", "");
        }

        public static string g_ReadFile(string sFullPath)
        {
            System.IO.StreamReader oReader = new System.IO.StreamReader(sFullPath);
            string sReturn = oReader.ReadToEnd();
            oReader.Close();
            return sReturn;
        }

        public static void g_WriteFile(string sFullPath, string sFileContents)
        {
            StreamWriter oWriter = new System.IO.StreamWriter(sFullPath);
            oWriter.Write(sFileContents);
            oWriter.Close();
        }

        public static void g_VerifyWriteAccess(string sDirectory)
        {
            string sFullPath = g_GetAppLocation() + "\\" + sDirectory + "\\";
            try
            {
                g_WriteFile(sFullPath + "test.txt", "TestFile");
                FileInfo oFile = new FileInfo(sFullPath + "test.txt");
                if (oFile.Exists == true)
                {
                    oFile.Delete();
                }
            }
            catch
            {
                MessageBox.Show("In order for this example to work correctly full access to the \"" + sFullPath + "\" must be granted, you can do so by running this application as an Administrator or manually configuring permissions.", "", MessageBoxButtons.OK);
            }
        }

        public static int GetRnd(int lLowerBound, int lUpperBound)
        {
            System.Random oRnd = null;
            string sGUID = System.Guid.NewGuid().ToString("N").Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "");
            int iSeed = System.Convert.ToInt32(sGUID.Substring(0, 5));
            oRnd = new Random(iSeed);
            return oRnd.Next(lLowerBound, lUpperBound);
        }

        public static string g_Format(decimal dParam, string sFormat)
        {
            return dParam.ToString(sFormat);
        }

        public static string g_GetComboBoxSelectedItem(ComboBox oComboBox, string sColumnName)
        {
            string sReturn = null;
            DataRowView oDataRowView;
            oDataRowView = (System.Data.DataRowView)oComboBox.SelectedItem;
            sReturn = System.Convert.ToString(oDataRowView[sColumnName]);
            return sReturn;
        }

        internal static string g_GenerateRandomName(bool IncludePrefix, SqlCeConnection oConn)
        {
            string sReturn = "";
            SqlCeCommand oCmd = null;
            SqlCeDataReader oReader = null;
            oCmd = new SqlCeCommand("SELECT * FROM tb_First_Names WHERE lID=" + GetRnd(1, 5494).ToString(), oConn);
            oReader = oCmd.ExecuteReader();
            if (oReader.Read() == true)
            {
                if (IncludePrefix == true)
                {
                    if ((System.String)oReader["sSex"] == "F")
                    {
                        sReturn = "Ms. ";
                    }
                    else
                    {
                        sReturn = "Mr. ";
                    }
                }
                sReturn = sReturn + (System.String)oReader["sFirstName"];
            }
            oReader.Close();
            oCmd = new SqlCeCommand("SELECT * FROM tb_Last_Names WHERE lID=" + GetRnd(1, 88799).ToString(), oConn);
            oReader = oCmd.ExecuteReader();
            if (oReader.Read() == true)
            {
                sReturn = sReturn + " " + (System.String)oReader["sLastName"];
            }
            oReader.Close();
            return sReturn;
        }

        internal static string g_GenerateRandomAddress(SqlCeConnection oConn)
        {
            string sReturn = "";
            int i = 0;
            int Max = 0;

            Max = GetRnd(1, 3);
            for (i = 1; i <= Max; i++)
            {
                sReturn = sReturn + System.Convert.ToChar(GetRnd(49, 57));
            }
            SqlCeCommand oCmd = null;
            SqlCeDataReader oReader = null;
            oCmd = new SqlCeCommand("SELECT * FROM tb_Last_Names WHERE lID=" + GetRnd(1, 88799).ToString(), oConn);
            oReader = oCmd.ExecuteReader();
            if (oReader.Read() == true)
            {
                sReturn = sReturn + " " + (System.String)oReader["sLastName"];
            }
            oReader.Close();
            oCmd = new SqlCeCommand("SELECT * FROM tb_US_Streets WHERE lID=" + GetRnd(1, 538).ToString(), oConn);
            oReader = oCmd.ExecuteReader();
            if (oReader.Read() == true)
            {
                sReturn = sReturn + " " + (System.String)oReader["sStreetSuffix"];
            }
            oReader.Close();
            return sReturn;
        }

        internal static void g_GenerateRandomCity(ref string sCityName, ref string sStateAbr, ref int lID, SqlCeConnection oConn)
        {
            SqlCeCommand oCmd = null;
            SqlCeDataReader oReader = null;
            oCmd = new SqlCeCommand("SELECT * FROM tb_US_Cities WHERE lID=" + GetRnd(1, 25150).ToString(), oConn);
            oReader = oCmd.ExecuteReader();
            if (oReader.Read() == true)
            {
                sCityName = (System.String)oReader["sCityName"];
                sStateAbr = (System.String)oReader["sStateAbr"];
                lID = (System.Int32)oReader["lID"];
                sCityName = sCityName.Trim();
                sStateAbr = sStateAbr.Trim();
            }
        }

		public static string g_GenerateRandomPhone(string AreaCode)
		{
            int i = 0;
            string sBuff = "";
            if (string.IsNullOrEmpty(AreaCode))
            {
                for (i = 1; i <= 3; i++)
                {
                    if (i == 1)
                    {
                        sBuff = sBuff + System.Convert.ToChar(GetRnd(49, 57));
                    }
                    else
                    {
                        sBuff = sBuff + System.Convert.ToChar(GetRnd(48, 57));
                    }
                }
                sBuff = "(" + sBuff + ") ";
            }
            else
            {
                sBuff = AreaCode + " ";
            }
            for (i = 1; i <= 3; i++)
            {
                if (i == 1)
                {
                    sBuff = sBuff + System.Convert.ToChar(GetRnd(49, 57));
                }
                else
                {
                    sBuff = sBuff + System.Convert.ToChar(GetRnd(48, 57));
                }
            }
            sBuff = sBuff + "-";
            for (i = 1; i <= 4; i++)
            {
                sBuff = sBuff + System.Convert.ToChar(GetRnd(48, 57));
            }
            return sBuff;
		}

		public static string g_GenerateRandomZIP()
		{
            int i = 0;
            string sBuff = "";
            for (i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    sBuff = sBuff + System.Convert.ToChar(GetRnd(49, 57));
                }
                else
                {
                    sBuff = sBuff + System.Convert.ToChar(GetRnd(48, 57));
                }
            }
            return sBuff;
		}

		public static string g_GenerateRandomLicense()
		{
            int i = 0;
            string sBuff = "";
            for (i = 1; i <= 3; i++)
            {
                sBuff = sBuff + System.Convert.ToChar(GetRnd(65, 90));
            }
            sBuff = sBuff + "-";
            for (i = 1; i <= 4; i++)
            {
                sBuff = sBuff + System.Convert.ToChar(GetRnd(48, 57));
            }
            return sBuff;
		}

        private static bool IsNumeric(object value)
        {
            try
            {
                double d = System.Double.Parse(value.ToString(), System.Globalization.NumberStyles.Any);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static DateTime FromDate(System.DateTime dtDate)
        {
            DateTime dtReturn = new DateTime(dtDate.Year, dtDate.Month, dtDate.Day, dtDate.Hour, dtDate.Minute, dtDate.Second);
            return dtReturn;
        }

        public static void InitNumCtrl(NumericUpDown numCtrl, int lMin, int lMax, int lValue)
        {
            numCtrl.Minimum = lMin;
            numCtrl.Maximum = lMax;
            numCtrl.Value = System.Convert.ToDecimal(lValue);
        }

        public static void InitNumCtrl(NumericUpDown numCtrl, int lMin, int lMax, double dValue)
        {
            numCtrl.Minimum = lMin;
            numCtrl.Maximum = lMax;
            numCtrl.Value = System.Convert.ToDecimal(dValue);
        }

        public static void InitNumCtrl(NumericUpDown numCtrl, double dMin, double dMax, double dValue, double dDelta, int lDecimalPlaces)
        {
            numCtrl.DecimalPlaces = lDecimalPlaces;
            numCtrl.Minimum = System.Convert.ToDecimal(dMin);
            numCtrl.Maximum = System.Convert.ToDecimal(dMax);
            numCtrl.Value = System.Convert.ToDecimal(dValue);
            numCtrl.Increment = System.Convert.ToDecimal(dDelta);
        }

        public static System.Drawing.Image g_GetImage(string sPath)
        {
            return System.Drawing.Image.FromFile(g_GetAppLocation() + sPath);
        }

	}

}
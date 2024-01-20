
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace SBOAddOn_TSA
{

    [FormAttribute("SBOAddOn_TSA.NewForm_1_b1f", "Forms/NewForm 1.b1f")]
    class NewForm_1_b1f : UserFormBase
    {
        public NewForm_1_b1f()
        {
            //try
            //{
            //    oForm = Application.SBO_Application.Forms.Item("BIZD.Form1");

            //    Application.SBO_Application.MessageBox(oForm.Title.ToString());
            //}
            //catch (Exception ex)
            //{

            //    Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            //}
        }

        private SAPbouiCOM.IForm oForm;
        private SAPbouiCOM.IItem oItem;

        //Create Delcare Interface UI Button
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Button Button4;

        //Create Delcare Interface UI Button
        private SAPbouiCOM.CheckBox Check0;

        //
        private SAPbouiCOM.IMatrix oMatrix_User;
        //
        private SAPbouiCOM.IColumn oColumn;
        //
        SAPbouiCOM.EditText EditValue;
        //
        public SAPbouiCOM.DBDataSource oDBDataSource1;

        private SAPbouiCOM.DataTable oDataTable;
        //
        //private SAPbouiCOM.Condition oCon;
        //private SAPbouiCOM.Conditions oCons;

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_can").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_ok").Specific));
            this.Button1.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            this.Check0 = ((SAPbouiCOM.CheckBox)(this.GetItem("item_hide").Specific));
            this.Check0.ClickBefore += this.Check0_ClickBefore1;
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("item_lu").Specific));
            this.Matrix0.ClickBefore += new SAPbouiCOM._IMatrixEvents_ClickBeforeEventHandler(this.Matrix0_ClickBefore);
            //       this.Matrix0.DoubleClickBefore += new SAPbouiCOM._IMatrixEvents_DoubleClickBeforeEventHandler(this.Matrix0_DoubleClickBefore);
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_1").Specific));
            this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_3").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_gsu").Specific));
            this.OnCustomInitialize();

        }

        // *** Event Click On Check Box ***
        private void Check0_ClickBefore1(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                oForm = Application.SBO_Application.Forms.ActiveForm;

                Check0.ValOff = "N";
                Check0.ValOn = "Y";

                oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OUSR");

                Check0.DataBind.SetBound(true, "OUSR", "Locked");
                          
                oForm.DataSources.UserDataSources.Item("DS_chk_1").Value = "Y";

                if (Check0.Checked == true)
                {
                    oItem = oForm.Items.Item("item_lu");

                    oMatrix_User = (SAPbouiCOM.IMatrix)(oItem.Specific);

                    //oDataTable = oForm.DataSources.DataTables.Add("DT_OUSR1");
                    //oDataTable.ExecuteQuery("SELECT \"USER_CODE\",\"U_NAME\",\"USERID\",\"Locked\" FROM OUSR ORDER BY \"USER_CODE\"");

                    oMatrix_User.Clear();

                    oColumn = oMatrix_User.Columns.Item("Col_0");
                    oColumn.DataBind.Bind("DT_OUSR1", "USER_CODE");

                    oColumn = oMatrix_User.Columns.Item("Col_1");
                    oColumn.DataBind.Bind("DT_OUSR1", "U_NAME");

                    oColumn = oMatrix_User.Columns.Item("Col_2");
                    oColumn.DataBind.Bind("DT_OUSR1", "USERID");

                    oColumn = oMatrix_User.Columns.Item("Col_3");
                    oColumn.DataBind.Bind("DT_OUSR1", "Locked");

                    oMatrix_User.LoadFromDataSource();

                }
                else
                {
                    oItem = oForm.Items.Item("item_lu");

                    oMatrix_User = (SAPbouiCOM.IMatrix)(oItem.Specific);

                    //oDataTable = oForm.DataSources.DataTables.Add("DT_OUSR2");
                    //oDataTable.ExecuteQuery("SELECT \"USER_CODE\",\"U_NAME\",\"USERID\",\"Locked\" FROM OUSR WHERE \"Locked\"='N' ORDER BY \"USER_CODE\"");

                    oMatrix_User.Clear();

                    oColumn = oMatrix_User.Columns.Item("Col_0");
                    oColumn.DataBind.Bind("DT_OUSR2", "USER_CODE");

                    oColumn = oMatrix_User.Columns.Item("Col_1");
                    oColumn.DataBind.Bind("DT_OUSR2", "U_NAME");

                    oColumn = oMatrix_User.Columns.Item("Col_2");
                    oColumn.DataBind.Bind("DT_OUSR2", "USERID");

                    oColumn = oMatrix_User.Columns.Item("Col_3");
                    oColumn.DataBind.Bind("DT_OUSR2", "Locked");

                    oMatrix_User.LoadFromDataSource();
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message,SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }
        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            
        }        

        // *** Event Click Close Button ***
        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.ActiveForm;
                oForm.Close();
            }
            catch (Exception  ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message,SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }

        }

        // *** Event Click OK Button ***
        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {               
                Application.SBO_Application.MessageBox("OK!");                
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }

        }

        private void OnCustomInitialize()
        {
            try
            {
                DTLoad();

                GrideLoad();

                LoadUser();
                LoadSubject();                
            }
            catch (Exception ex)
            {
                oForm.Close();
                Application.SBO_Application.SetStatusBarMessage(ex.Message,SAPbouiCOM.BoMessageTime.bmt_Short,true);                
            }
        }

        private void LoadUser()
        {
            try
            {
                //
                oForm = Application.SBO_Application.Forms.Item("NewForm1");
                //
                oItem = oForm.Items.Item("item_lu");
                //
                oMatrix_User = ((SAPbouiCOM.IMatrix)(oItem.Specific));
                //
                oColumn = oMatrix_User.Columns.Item("Col_0");                
                oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OUSR");
                oColumn.DataBind.SetBound(true,"OUSR","USER_CODE");
                oColumn.Width = 200;

                oColumn = oMatrix_User.Columns.Item("Col_1");
                oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OUSR");
                oColumn.DataBind.SetBound(true, "OUSR", "U_NAME");
                oColumn.Visible = false;

                oColumn = oMatrix_User.Columns.Item("Col_2");
                oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OUSR");
                oColumn.DataBind.SetBound(true, "OUSR", "USERID");
                oColumn.Visible = false;

                oColumn = oMatrix_User.Columns.Item("Col_3");
                oDBDataSource1 = oForm.DataSources.DBDataSources.Add("OUSR");
                oColumn.DataBind.SetBound(true, "OUSR", "Locked");
                oColumn.Visible = false;

                oDBDataSource1.Query(null);
                //
                oMatrix_User.LoadFromDataSource();
                //
                oColumn = oMatrix_User.Columns.Item("Col_0");
                oColumn.TitleObject.Sort(SAPbouiCOM.BoGridSortType.gst_Ascending);
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }            
        }

        private void LoadSubject()
        {            
            //
            oForm = Application.SBO_Application.Forms.Item("NewForm1");
            //
            oItem = oForm.Items.Item("item_su");
            //
            oMatrix_User = (SAPbouiCOM.IMatrix)(oItem.Specific);
            //
            //oDataTable = oForm.DataSources.DataTables.Add("DT_OUPT");
            //oDataTable.ExecuteQuery("SELECT * FROM OUPT ORDER BY \"VisOrder\"");
            //            
            oColumn = oMatrix_User.Columns.Item("Col_1");
            //
            oColumn = oMatrix_User.Columns.Item("Col_1");
            oColumn.DataBind.Bind("DT_OUPT", "Absid");            

            oColumn = oMatrix_User.Columns.Item("Col_2");
            oColumn.DataBind.Bind("DT_OUPT", "Name");

            //oColumn = oMatrix_User.Columns.Item("Col_6");
            //oColumn.Editable = true;

            //oColumn = oMatrix_User.Columns.Item("Col_6");
            //oColumn.Editable = true;

            oColumn = oMatrix_User.Columns.Item("Col_6");
            oColumn.DataBind.Bind("DT_OUPT", "Fathid");

            oColumn = oMatrix_User.Columns.Item("Col_8");
            oColumn.DataBind.Bind("DT_OUPT", "Levels");

            oColumn = oMatrix_User.Columns.Item("Col_9");
            oColumn.DataBind.Bind("DT_OUPT", "IsItem");

            oMatrix_User.LoadFromDataSource();
        }

        private void DTLoad()
        {
            oForm = Application.SBO_Application.Forms.Item("NewForm1");

            oDataTable = oForm.DataSources.DataTables.Add("DT_OUSR1");
            oDataTable.ExecuteQuery("SELECT \"USER_CODE\",\"U_NAME\",\"USERID\",\"Locked\" FROM OUSR ORDER BY \"USER_CODE\"");

            oDataTable = oForm.DataSources.DataTables.Add("DT_OUSR2");
            oDataTable.ExecuteQuery("SELECT \"USER_CODE\",\"U_NAME\",\"USERID\",\"Locked\" FROM OUSR WHERE \"Locked\"='N' ORDER BY \"USER_CODE\"");

            oDataTable = oForm.DataSources.DataTables.Add("DT_OUPT");
            oDataTable.ExecuteQuery("SELECT * FROM OUPT ORDER BY \"VisOrder\"");
        }

        private SAPbouiCOM.Matrix Matrix0;

        private void Matrix0_DoubleClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
            {
            BubbleEvent = true;
            try
            {               
                //string strValue;

                //oForm = Application.SBO_Application.Forms.Item("NewForm1");
                //oItem = oForm.Items.Item("item_lu");
                //oMatrix_User = (SAPbouiCOM.IMatrix)(oItem.Specific);

                //int selrow1 = oMatrix_User.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder);

                //EditValue = (SAPbouiCOM.EditText)oMatrix_User.GetCellSpecific(2, pVal.Row);
                //strValue = EditValue.Value.ToString().Trim();

                //Application.SBO_Application.SetStatusBarMessage(strValue , SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }
            catch (Exception ex )
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }

        }

        private void Matrix0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (pVal.ColUID == "Col_4")
                {
                    //string strValue;                
                    //int yellow = 252 | (221 << 8) | (130 << 16);               

                    oForm = Application.SBO_Application.Forms.Item("NewForm1");
                    oItem = oForm.Items.Item("item_lu");
                    oMatrix_User = (SAPbouiCOM.IMatrix)(oItem.Specific);

                    EditValue = (SAPbouiCOM.EditText)oMatrix_User.GetCellSpecific(3, pVal.Row);
                    //strValue = EditValue.Value.ToString().Trim();

                    //if (R == 0)
                    //{
                    //    oMatrix_User.CommonSetting.SetCellBackColor(pVal.Row, 1, yellow);
                    //    R = pVal.Row;
                    //}
                    //else
                    //{
                    //    oMatrix_User.CommonSetting.SetCellBackColor(R, 1, -1);
                    //    oMatrix_User.CommonSetting.SetCellBackColor(pVal.Row, 1, yellow);                    
                    //    R = pVal.Row;
                    //}                

                    Application.SBO_Application.SetStatusBarMessage(EditValue.Value.ToString().Trim(), SAPbouiCOM.BoMessageTime.bmt_Short, false);
                }                
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }

        }

        private void Button3_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {                
                
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }

        }

        private void GrideLoad()
        {
            oForm = Application.SBO_Application.Forms.Item("NewForm1");        
            oItem = oForm.Items.Item("Item_gsu");

            SAPbouiCOM.Grid oGrid = (SAPbouiCOM.Grid)(oItem.Specific);

            oForm.DataSources.DataTables.Add("TB_Sub");
            oForm.DataSources.DataTables.Item(0).ExecuteQuery("SELECT * FROM OUPT ORDER BY \"VisOrder\"");
            oGrid.DataTable = oForm.DataSources.DataTables.Item("TB_Sub");

            //1
            oGrid.DataTable.Columns.Add("ID", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric,20);
            //2    
            oGrid.DataTable.Columns.Add("Subject", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 50);
            //3
            oGrid.DataTable.Columns.Add("Authorization", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 1);
            //4
            oGrid.DataTable.Columns.Add("Option", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 1);
            //5
            oGrid.DataTable.Columns.Add("Enable", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 1);
            //6
            oGrid.DataTable.Columns.Add("Father ID", SAPbouiCOM.BoFieldsType.ft_Integer, 6);
            //7
            oGrid.DataTable.Columns.Add("Num of Son", SAPbouiCOM.BoFieldsType.ft_Integer, 6);
            //8
            oGrid.DataTable.Columns.Add("Level", SAPbouiCOM.BoFieldsType.ft_Integer, 6);
            //9
            oGrid.DataTable.Columns.Add("Is Item", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 1);
            //10
            oGrid.DataTable.Columns.Add("Effective Authorization", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric, 1);

            oGrid.AutoResizeColumns();

            oGrid.Columns.Item(0).Width = 50;
            oGrid.Columns.Item(0).Visible = false;
                    
            oGrid.Columns.Item(1).Width = 340;
            oGrid.Columns.Item(1).Visible = true;

            oGrid.Columns.Item(2).Width = 160;
            oGrid.Columns.Item(2).Visible = true;

            oGrid.Columns.Item(3).Width = 50;
            oGrid.Columns.Item(3).Visible = false;

            oGrid.Columns.Item(4).Width = 50;
            oGrid.Columns.Item(4).Visible = false;

            oGrid.Columns.Item(5).Width = 50;
            oGrid.Columns.Item(5).Visible = false;

            oGrid.Columns.Item(6).Width = 50;
            oGrid.Columns.Item(6).Visible = false;

            oGrid.Columns.Item(7).Width = 50;
            oGrid.Columns.Item(7).Visible = false;

            oGrid.Columns.Item(8).Width = 50;
            oGrid.Columns.Item(8).Visible = false;

            oGrid.Columns.Item(9).Width = 160;
            oGrid.Columns.Item(9).Visible = true;
        }

        private SAPbouiCOM.Grid Grid0;
    }
}
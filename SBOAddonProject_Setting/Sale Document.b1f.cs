
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace SBOAddonProject_Setting
{
    [FormAttribute("SBOAddonProject_Setting.Sale_Document_b1f", "Sale Document.b1f")]
    class Sale_Document_b1f : UserFormBase
    {
       // private const bool EnableFlag = true;
        private SAPbouiCOM.Button btnAdd, BtnCancel;
        private SAPbouiCOM.CheckBox CheckBox1, CheckBox2, chFule, chLPG, chLube;
        private SAPbouiCOM.DataTable oDataTable, oDataTable_0, oDataTable1, oDataTable_1, oDataTable2, oDataTable_2, oDataTable3, oDataTable_3, oDatatableIT, oDataTableIT_0;
        private SAPbouiCOM.Matrix Matrix0, Matrix1, Matrix2;
        private SAPbouiCOM.Form oForm;
        private SAPbouiCOM.Folder Folder0, Folder1;
        SAPbouiCOM.ChooseFromList oCFL, oCFLIT;
        SAPbouiCOM.Conditions oCFLConditions, IoCFLConditions;
        SAPbouiCOM.Condition oCFLCondition, IoCFLCondition;
        SAPbouiCOM.Form cForm;
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.btnAdd = ((SAPbouiCOM.Button)(this.GetItem("btnAdd").Specific));
            this.btnAdd.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.btnAdd_ClickBefore);
            this.BtnCancel = ((SAPbouiCOM.Button)(this.GetItem("btnCancel").Specific));
            this.BtnCancel.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            this.CheckBox1 = ((SAPbouiCOM.CheckBox)(this.GetItem("check1").Specific));
            this.CheckBox1.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.CheckBox1_ClickAfter);
            this.CheckBox2 = ((SAPbouiCOM.CheckBox)(this.GetItem("check2").Specific));
            this.CheckBox2.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.CheckBox2_ClickAfter);
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_0").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("oMatrix").Specific));
            this.Matrix0.KeyDownBefore += new SAPbouiCOM._IMatrixEvents_KeyDownBeforeEventHandler(this.Matrix0_KeyDownBefore);
            this.Matrix0.ClickBefore += new SAPbouiCOM._IMatrixEvents_ClickBeforeEventHandler(this.Matrix0_ClickBefore);
            this.Matrix0.ClickAfter += new SAPbouiCOM._IMatrixEvents_ClickAfterEventHandler(this.Matrix0_ClickAfter);
            this.Matrix0.KeyDownAfter += new SAPbouiCOM._IMatrixEvents_KeyDownAfterEventHandler(this.Matrix0_KeyDownAfter);
            this.Matrix0.ChooseFromListBefore += new SAPbouiCOM._IMatrixEvents_ChooseFromListBeforeEventHandler(this.Matrix0_ChooseFromListBefore);
            this.Matrix0.DoubleClickAfter += new SAPbouiCOM._IMatrixEvents_DoubleClickAfterEventHandler(this.Matrix0_DoubleClickAfter);
            this.Matrix0.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix0_ChooseFromListAfter);
            this.Matrix2 = ((SAPbouiCOM.Matrix)(this.GetItem("oMatrix2").Specific));
            this.Matrix2.ClickAfter += new SAPbouiCOM._IMatrixEvents_ClickAfterEventHandler(this.Matrix2_ClickAfter);
            this.chFule = ((SAPbouiCOM.CheckBox)(this.GetItem("cheFuel").Specific));
            this.chFule.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.chFule_ClickAfter);
            this.chLPG = ((SAPbouiCOM.CheckBox)(this.GetItem("cheLPG").Specific));
            this.chLPG.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.chLPG_ClickAfter);
            this.chLube = ((SAPbouiCOM.CheckBox)(this.GetItem("cheLube").Specific));
            this.chLube.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.chLube_ClickAfter);
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_1").Specific));
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_3").Specific));
            this.Matrix1.KeyDownBefore += new SAPbouiCOM._IMatrixEvents_KeyDownBeforeEventHandler(this.Matrix1_KeyDownBefore);
            this.Matrix1.ClickBefore += new SAPbouiCOM._IMatrixEvents_ClickBeforeEventHandler(this.Matrix1_ClickBefore);
            this.Matrix1.ClickAfter += new SAPbouiCOM._IMatrixEvents_ClickAfterEventHandler(this.Matrix1_ClickAfter);
            this.Matrix1.KeyDownAfter += new SAPbouiCOM._IMatrixEvents_KeyDownAfterEventHandler(this.Matrix1_KeyDownAfter);
            this.Matrix1.ChooseFromListBefore += new SAPbouiCOM._IMatrixEvents_ChooseFromListBeforeEventHandler(this.Matrix1_ChooseFromListBefore);
            this.Matrix1.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix1_ChooseFromListAfter);
            this.OnCustomInitialize();

        }
        private void OnCustomInitialize()
        {
        }
        public Sale_Document_b1f()
        {
            //********************************************************************
            oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
            oDataTable = oForm.DataSources.DataTables.Add("TL_BP");
            oDataTable_0 = oForm.DataSources.DataTables.Add("TL_BP1");
             oDatatableIT = oForm.DataSources.DataTables.Add("TL_IT");
            oDataTableIT_0 = oForm.DataSources.DataTables.Add("TL_IT1");
            oDataTable1 = oForm.DataSources.DataTables.Add("TL_ProLine");
            oDataTable_1 = oForm.DataSources.DataTables.Add("TL_ProLine1");
            oDataTable2 = oForm.DataSources.DataTables.Add("TL_PriceList");
            oDataTable_2 = oForm.DataSources.DataTables.Add("TL_PriceList1");
            oDataTable3 = oForm.DataSources.DataTables.Add("TL_DocSet");
            oDataTable_3 = oForm.DataSources.DataTables.Add("TL_DocSet1");
            //********************************************************************
            oForm.Freeze(true);
            LoadData_DocSet();
            LoadDataIT();
            LoadDataBP();
            LoadData_ProLine();
            LoadData_PriceList();
            CheckBox();
            Folder0.Select();
            Matrix1.AutoResizeColumns();
            Matrix0.AutoResizeColumns();
            oForm.Freeze(false);
        }
        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            Application.SBO_Application.MenuEvent += SBO_Application_MenuEvent;
            Application.SBO_Application.RightClickEvent += SBO_Application_RightClickEvent;
        }
        private void SBO_Application_RightClickEvent(ref SAPbouiCOM.ContextMenuInfo eventInfo, out bool BubbleEvent)
        {
            //throw new NotImplementedException();
            BubbleEvent = true;
            try
            {
                if (eventInfo.FormUID=="Form4")
                {
                    if (eventInfo.ItemUID == "oMatrix" || eventInfo.ItemUID == "Item_3")
                    {
                        oForm.EnableMenu("1293", true);
                        oForm.EnableMenu("1292", true);
                        oForm.EnableMenu("775", false);
                        oForm.EnableMenu("774", false);
                        oForm.EnableMenu("773", false);
                        oForm.EnableMenu("771", false);

                        //    oForm = Application.SBO_Application.Forms.ActiveForm;
                        //    SAPbouiCOM.Menus oMenus = null;
                        //    SAPbouiCOM.MenuItem oMenuItem = null;
                        //    SAPbouiCOM.MenuItem oMenuItem1 = null;
                        //    SAPbouiCOM.MenuCreationParams oCreationPackage1; //= null;
                        //    oMenus = Application.SBO_Application.Menus;
                        //    oCreationPackage1 = (SAPbouiCOM.MenuCreationParams)Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
                        //    oMenuItem = Application.SBO_Application.Menus.Item("1293");
                        //    oMenuItem1 = Application.SBO_Application.Menus.Item("1292");
                        //oCreationPackage1.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                        //oCreationPackage1.UniqueID = "Delete";
                        //oCreationPackage1.String = "Delete";
                        //oCreationPackage1.Enabled = true;
                        //oCreationPackage1.Position = -1;
                        //oMenus = oMenuItem.SubMenus;
                        //if (!oForm.Menu.Exists("Delete"))
                        //{
                        //    oForm.Menu.AddEx(oCreationPackage1);
                        //}
                        //oCreationPackage1 = null;
                    }
                    else
                    {
                        oForm.EnableMenu("1293", false);
                        oForm.EnableMenu("1292", false);
                        //oForm.EnableMenu("774",false);
                    }
                }
               
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.Message);
            }
        }
        private void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            //throw new NotImplementedException();
            BubbleEvent = true;
            if (pVal.MenuUID == "1293")
            {
                if (oForm.Mode == SAPbouiCOM.BoFormMode.fm_OK_MODE)
                {
                    oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                    btnAdd.Caption = "Update";
                }
            }
           
            if (pVal.MenuUID == "1292")
            {
                if ( oForm.Mode == SAPbouiCOM.BoFormMode.fm_OK_MODE)
                {
                    if (oForm.PaneLevel == 1)
                    {
                        oForm.Freeze(true);
                        oDataTable.ExecuteQuery("DELETE FROM \"TL_Customer\" WHERE \"CardCode\"=''");
                        oDataTable.ExecuteQuery("INSERT INTO \"TL_Customer\" VALUES('','',CURRENT_TIMESTAMP)");
                        //oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                        //btnAdd.Caption = "Update";
                        LoadDataBP();
                        oForm.Freeze(false);
                    }
                    if (oForm.PaneLevel == 2)
                    {
                        oForm.Freeze(true);
                        oDatatableIT.ExecuteQuery("DELETE FROM \"TL_ITEM\" WHERE \"ItemCode\"=''");
                        oDatatableIT.ExecuteQuery("INSERT INTO \"TL_ITEM\" VALUES('','',CURRENT_TIMESTAMP)");
                        //oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                        //btnAdd.Caption = "Update";
                        LoadDataIT();
                        oForm.Freeze(false);
                    }
                }
            }

        }
        private void Matrix0_ChooseFromListBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            //throw new System.NotImplementedException();
            if (pVal.ColUID == "CardCode" & Matrix0.RowCount == pVal.Row)
            {
                BubbleEvent = true;
                ChooseFromList();
            }
            else
            {
                BubbleEvent = false;

                //Application.SBO_Application.SetStatusBarMessage("Cannot Choose from list.", SAPbouiCOM.BoMessageTime.bmt_Short, true);
                oForm.Freeze(true);
                Matrix0.LoadFromDataSource();
                oForm.Freeze(false);
                Matrix0.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Single;
                Matrix0.SelectRow(Matrix0.RowCount,true,false);
            }
        }


        private void Matrix0_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg CFLValue = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
            if (pVal.ColUID == "CardCode" & Matrix0.RowCount == pVal.Row)
            {
                if (CFLValue.SelectedObjects != null & pVal.InnerEvent == true)
                {
                    LoadDataBP();
                    for (int i = 1; i < Matrix0.VisualRowCount; i++)
                    {
                        SAPbouiCOM.EditText text = (SAPbouiCOM.EditText)Matrix0.Columns.Item("CardCode").Cells.Item(i).Specific;
                        string C = CFLValue.SelectedObjects.GetValue("CardCode", 0).ToString();
                        if (text.Value == C)
                        {
                            Application.SBO_Application.MessageBox("Business Partners already existing.");
                            //oDataTable.SetValue("CardCode", pVal.Row - 1, "");
                            //oDataTable.SetValue("CardName", pVal.Row - 1, "");
                            //Matrix0.LoadFromDataSource();
                            //btnAdd.Caption = "Update";
                            //oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                            LoadDataBP();
                            btnAdd.Caption = "Ok";
                            oForm.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
                            break;
                        }
                        else//if (text.Value != C)
                        {
                            oDataTable.SetValue("CardCode", pVal.Row - 1, CFLValue.SelectedObjects.GetValue("CardCode", 0).ToString());
                            oDataTable.SetValue("CardName", pVal.Row - 1, CFLValue.SelectedObjects.GetValue("CardName", 0).ToString());
                            Matrix0.LoadFromDataSource();
                            btnAdd.Caption = "Update";
                            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                        }
                    }
                    if (Matrix0.RowCount == 1)
                    {
                        oDataTable.SetValue("CardCode", pVal.Row - 1, CFLValue.SelectedObjects.GetValue("CardCode", 0).ToString());
                        oDataTable.SetValue("CardName", pVal.Row - 1, CFLValue.SelectedObjects.GetValue("CardName", 0).ToString());
                        Matrix0.LoadFromDataSource();
                        btnAdd.Caption = "Update";
                        oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                    }
                }
            }
        }
//Button Update*************************************************************************************************
        private void btnAdd_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
           if (pVal.FormMode==1 & pVal.ActionSuccess!=true)
           {
                if (oForm.PaneLevel == 1)
                {
                    oDataTable.ExecuteQuery("DELETE FROM \"TL_Customer\" WHERE \"CardCode\"=''");
                }
                if (oForm.PaneLevel == 2)
                {
                    oDatatableIT.ExecuteQuery("DELETE FROM \"TL_ITEM\" WHERE \"ItemCode\"=''");
                }
                oForm.Close();
            }
           else 
            {
                if (oForm.PaneLevel == 2)
                {
                    Delete_IT();
                    Add_IT();
                    oDatatableIT.ExecuteQuery("DELETE FROM \"TL_ITEM\" WHERE \"ItemCode\"=''");
                    LoadDataIT();
                    //DeleteLOB();
                    //AddLOB();
                }
                if (oForm.PaneLevel == 1)
                {
                    Delete_BP();
                    Add_BP();
                    oDataTable.ExecuteQuery("DELETE FROM \"TL_Customer\" WHERE \"CardCode\"=''");
                    //oDataTable.ExecuteQuery("INSERT INTO \"TL_Customer\" VALUES('','',CURRENT_TIMESTAMP)");
                    LoadDataBP();
                }
                if (oForm.PaneLevel == 3)
                {
                    Delete_PriceList();
                    Add_PriceList();
                }
                if (oForm.PaneLevel==1)
                {
                    Delete_DocSet();
                    Add_DocSet();
                } 
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
                btnAdd.Caption = "Ok";
                Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully.", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "", 0);
            }
        }
//***************************************************************************************************************
        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (pVal.FormMode==2)
                {
                  int message =Application.SBO_Application.MessageBox("Unsaved data will be lost. Do you want to continue without saving?",1,"Yes","No");
                    if (message==1)
                    {
                        oForm.Close();
                    }
                    else
                    {
                        oForm.Visible = true;
                    }
                }
                else
                {
                    oForm.Close();
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }
        }

        private void chFule_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
            btnAdd.Caption = "Update";
        }

        private void chLPG_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
            btnAdd.Caption = "Update";
        }

        private void chLube_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
            btnAdd.Caption = "Update";
        }

        private void AddChooseFromListToEditTextBox(string ObjectType,string CFLUID,SAPbobsCOM.BoYesNoEnum Condtion,string ConAlias="",string ConVal = "")
        {
            try
            {
                SAPbouiCOM.ChooseFromListCollection oCFLs = null;
                SAPbouiCOM.ChooseFromList oCFL = null;
                SAPbouiCOM.ChooseFromListCreationParams oCFLCreationParams = null;
                SAPbouiCOM.Conditions oCons = null;
                SAPbouiCOM.Condition oCon = null;
                oCFLs = oForm.ChooseFromLists;
                oCFLCreationParams = (SAPbouiCOM.ChooseFromListCreationParams)Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_ChooseFromListCreationParams);
                oCFLCreationParams.MultiSelection = false;
                oCFLCreationParams.ObjectType = ObjectType;
                oCFLCreationParams.UniqueID = CFLUID;
                oCFL = oCFLs.Add(oCFLCreationParams);
                if (Condtion==SAPbobsCOM.BoYesNoEnum.tYES)
                {
                    oCons = oCFL.GetConditions();
                    oCon = oCons.Add();
                    oCon.Alias = ConAlias;
                    oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    oCon.CondVal = ConVal;
                    oCFL.SetConditions(oCons);
                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message,SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }
        }
        private void CheckBox1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                btnAdd.Caption = "Update";
        }

        private void CheckBox2_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
            btnAdd.Caption = "Update";
        }

        private void Matrix2_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
           
            if (pVal.ColUID=="Active" & pVal.Row>0)
            {
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                btnAdd.Caption = "Update";
            }
            try
            {
                if (pVal.ItemUID == "oMatrix2" & pVal.ColUID == "Active" && pVal.Row == 0)
                {

                    string checkboxValue = oDataTable2.GetValue("Active", Matrix2.RowCount - 1).ToString();
                    // Toggle the checkbox value for all rows
                    oForm.Freeze(true);
                    for (int i = 0; i < Matrix2.RowCount; i++)
                    {
                        oDataTable2.SetValue("Active", i, (checkboxValue == "N") ? "Y" : "N");
                    }
                    // Refresh the matrix to update the checkbox display
                    //System.Threading.Thread.Sleep(1000);
                    oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                    btnAdd.Caption = "Update";
                    Matrix2.LoadFromDataSource();
                    oForm.Freeze(false);
                    //Application.SBO_Application.SetStatusBarMessage("Warehouse updated ", SAPbouiCOM.BoMessageTime.bmt_Long, false);
                }
                // oForm.Freeze(false);
            }
            catch (Exception ex)
            {
                if (pVal.ItemUID == "oMatrix2" & pVal.ColUID == "Active" && pVal.Row == 0)
                {
                    oForm.Freeze(true);
                    string Query = "SELECT ROW_NUMBER() OVER(Order By A.\"ListNum\") As \"A\", A.\"ListNum\",A.\"ListName\",CASE WHEN B.\"ListNum\" IS NOT NULL AND B.\"ListName\" IS NOT NULL THEN 'Y' ELSE 'N' END \"Active\" FROM \"OPLN\" A LEFT OUTER JOIN \"TL_PriceList\" B ON A.\"ListNum\" = B.\"ListNum\" and A.\"ListName\" = B.\"ListName\"";
                    oDataTable2.ExecuteQuery(Query);
                    //Satrt Bind Data*********************************************
                    // Matrix2.Columns.Item("#").DataBind.Bind("TL_PriceList", "A");
                    // Matrix2.Columns.Item("ListNum").DataBind.Bind("TL_PriceList", "ListNum");
                    // Matrix2.Columns.Item("ListName").DataBind.Bind("TL_PriceList", "ListName");
                    //  Matrix2.Columns.Item("Active").DataBind.Bind("TL_PriceList", "Active");
                    //End Bind Data*********************************************
                    string checkboxValue = oDataTable2.GetValue("Active", Matrix2.RowCount - 1).ToString();
                    // Toggle the checkbox value for all rows
                    for (int i = 0; i < Matrix2.RowCount; i++)
                    {
                        oDataTable2.SetValue("Active", i, (checkboxValue == "N") ? "Y" : "N");
                    }
                    // Refresh the matrix to update the checkbox display
                    oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                    btnAdd.Caption = "Update";
                    //System.Threading.Thread.Sleep(1000);
                    Matrix2.LoadFromDataSource();
                    oForm.Freeze(false);
                    //Application.SBO_Application.SetStatusBarMessage("Warehouse updated ", SAPbouiCOM.BoMessageTime.bmt_Long, true);
                }
            }
        }

        private void Matrix0_DoubleClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            if (pVal.ColUID == "CardName" & Matrix0.RowCount > pVal.Row & pVal.Row>0)
            {
                SAPbouiCOM.EditText text = (SAPbouiCOM.EditText)Matrix0.Columns.Item("CardCode").Cells.Item(pVal.Row).Specific;
                int delete = Application.SBO_Application.MessageBox("Do you want to delete BP Code:" + text.Value.ToString() + "?", 1, "Yes", "No");
                if (delete == 1)
                {
                    oDataTable.ExecuteQuery("DELETE FROM \"TL_Customer\" WHERE \"CardCode\"='" + text.Value.ToString() + "'");
                    LoadDataBP();
                }
            }
        }

        public void ChooseFromList()
        {
            oCFL = (SAPbouiCOM.ChooseFromList)oForm.ChooseFromLists.Item("BP");
            oCFLConditions = oCFL.GetConditions();
            if (oCFLConditions.Count==0)
            {
                oCFLCondition = oCFLConditions.Add();
                oCFLCondition.Alias = "CardType";
                oCFLCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                oCFLCondition.CondVal = "C";
                oCFL.SetConditions(oCFLConditions);
            }   
            else
            {
                oCFL.SetConditions(oCFLConditions);
            }
        }

        private void Matrix1_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            if (pVal.ItemUID == "Item_3" & pVal.ColUID == "ItemCode")
            {
                oForm.Freeze(true);
                LoadDataIT();
                oForm.Freeze(false);
            }
        }

        private void Matrix0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            if (pVal.Row > 0)
            {
                Matrix0.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Single;
                Matrix0.SelectRow(pVal.Row, true, false);
            }

        }

        private void Matrix0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            Matrix0.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_None;
        }

        private void Matrix0_KeyDownBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            LoadDataBP();
        }

        private void Matrix1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            if (pVal.Row > 0)
            {
                Matrix1.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Single;
                Matrix1.SelectRow(pVal.Row, true, false);
            }
        }

        private void Matrix1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
          Matrix1.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_None;
           
        }

        private void Matrix1_KeyDownBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            LoadDataIT();
        }

        public void LoadDataBP()
        {
            oForm.Freeze(true);
            oDataTable = oForm.DataSources.DataTables.Item("TL_BP");
            string Query = "SELECT ROW_NUMBER() OVER() AS \"A\",A.\"CardCode\",A.\"CardName\",A.\"UpdateDate\" FROM \"TL_Customer\" A";
            oDataTable.ExecuteQuery(Query);
            Matrix0.Columns.Item("#").DataBind.Bind("TL_BP", "A");
            Matrix0.Columns.Item("CardCode").DataBind.Bind("TL_BP", "CardCode");
            Matrix0.Columns.Item("CardName").DataBind.Bind("TL_BP", "CardName");
            Matrix0.LoadFromDataSource();
            Matrix0.AutoResizeColumns();
            oForm.Freeze(false);
        }

        private void Matrix0_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            if (pVal.ItemUID =="oMatrix" & pVal.ColUID=="CardCode")
            {
                oForm.Freeze(true);
                LoadDataBP();
                oForm.Freeze(false);
            }
        }

        private void Matrix1_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.ISBOChooseFromListEventArg CFLValueIT = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
            if (pVal.ColUID == "ItemCode" & Matrix1.RowCount == pVal.Row)
            {
                if (CFLValueIT.SelectedObjects != null & pVal.InnerEvent == true)
                {
                    LoadDataIT();
                    for (int i = 1; i < Matrix1.RowCount; i++)
                    {
                        SAPbouiCOM.EditText text = (SAPbouiCOM.EditText)Matrix1.Columns.Item("ItemCode").Cells.Item(i).Specific;
                        string C = CFLValueIT.SelectedObjects.GetValue("ItemCode", 0).ToString();
                        if (text.Value == C)
                        {
                            Application.SBO_Application.MessageBox("Business Partners already existing.");
                            //oDatatableIT.SetValue("ItemCode", pVal.Row - 1, "");
                            //oDatatableIT.SetValue("ItemName", pVal.Row - 1, "");
                            //Matrix1.LoadFromDataSource();
                            LoadDataIT();
                            btnAdd.Caption = "Ok";
                            oForm.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
                            break;
                        }
                        else
                        {
                            oDatatableIT.SetValue("ItemCode", pVal.Row - 1, CFLValueIT.SelectedObjects.GetValue("ItemCode", 0).ToString());
                            oDatatableIT.SetValue("ItemName", pVal.Row - 1, CFLValueIT.SelectedObjects.GetValue("ItemName", 0).ToString());
                            Matrix1.LoadFromDataSource();
                            btnAdd.Caption = "Update";
                            oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                        }
                    }
                    if (Matrix1.RowCount == 1)
                    {
                        oDatatableIT.SetValue("ItemCode", pVal.Row - 1, CFLValueIT.SelectedObjects.GetValue("ItemCode", 0).ToString());
                        oDatatableIT.SetValue("ItemName", pVal.Row - 1, CFLValueIT.SelectedObjects.GetValue("ItemName", 0).ToString());
                        Matrix1.LoadFromDataSource();
                        btnAdd.Caption = "Update";
                        oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE;
                    }
                }
            }
        }

        private void Matrix1_ChooseFromListBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            if (pVal.ColUID == "ItemCode" & Matrix1.RowCount == pVal.Row)
            {
                BubbleEvent = true;
                ChooseFromListIT();
            }
            else
            {
                BubbleEvent = false;
                //Application.SBO_Application.SetStatusBarMessage("Cannot Choose from list.", SAPbouiCOM.BoMessageTime.bmt_Short, true);
                oForm.Freeze(true);
                Matrix1.LoadFromDataSource();
                oForm.Freeze(false);
                Matrix1.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Single;
                Matrix1.SelectRow(Matrix1.RowCount, true, false);
            }
        }

        public void Delete_BP()
        {
            oDataTable_0.ExecuteQuery("DELETE  FROM \"TL_Customer\"");
        }
        public void Add_BP()
        {
            for (int i = 1; i <= Matrix0.VisualRowCount; i++)
            {
               object A = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("CardCode").Cells.Item(i).Specific).Value.ToString();
               object B = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("CardName").Cells.Item(i).Specific).Value.ToString();
               oDataTable.ExecuteQuery("INSERT INTO \"TL_Customer\" VALUES('" + A + "','" + B + "',CURRENT_TIMESTAMP)");
            }
            //Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "", 0);
        }
        public void ChooseFromListIT()
        {
            oCFLIT = (SAPbouiCOM.ChooseFromList)oForm.ChooseFromLists.Item("Item");
            IoCFLConditions = oCFLIT.GetConditions();
            if (IoCFLConditions.Count == 0)
            {
                IoCFLCondition = IoCFLConditions.Add();
                IoCFLCondition.Alias = "SellItem";
                IoCFLCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                IoCFLCondition.CondVal = "Y";
                oCFLIT.SetConditions(IoCFLConditions);
            }
            else
            {
                oCFLIT.SetConditions(IoCFLConditions);
            }
        }
        public void LoadDataIT()
        {
            oForm.Freeze(true);
            string QueryIT = "SELECT ROW_NUMBER() OVER() AS \"A\",A.\"ItemCode\",A.\"ItemName\",A.\"Updatedate\" FROM \"TL_ITEM\" A";
            oDatatableIT.ExecuteQuery(QueryIT);
            Matrix1.Columns.Item("#").DataBind.Bind("TL_IT", "A");
            Matrix1.Columns.Item("ItemCode").DataBind.Bind("TL_IT", "ItemCode");
            Matrix1.Columns.Item("ItemName").DataBind.Bind("TL_IT", "ItemName");
            Matrix1.LoadFromDataSource();
            Matrix1.AutoResizeColumns();
            oForm.Freeze(false);

        }
        public void Delete_IT()
        {
            oDataTableIT_0.ExecuteQuery("DELETE  FROM \"TL_ITEM\"");
        }
        public void Add_IT()
        {
            for (int i = 1; i <= Matrix1.VisualRowCount; i++)
            {
                object A = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("ItemCode").Cells.Item(i).Specific).Value.ToString();
                object B = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("ItemName").Cells.Item(i).Specific).Value.ToString();
                oDatatableIT.ExecuteQuery("INSERT INTO \"TL_ITEM\" VALUES('" + A + "','" + B + "',CURRENT_TIMESTAMP)");
            }
            //Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "", 0);
        }

        public void LoadData_ProLine()
        {
            try
            {
                    string Query = "SELECT A.\"Fuel\",A.\"LPG\",A.\"Lube\" FROM \"TL_ProLine\" A";
                    oDataTable1.ExecuteQuery(Query);
                    chFule.DataBind.Bind("TL_ProLine", "Fuel");
                    chLPG.DataBind.Bind("TL_ProLine", "LPG");
                    chLube.DataBind.Bind("TL_ProLine", "Lube");
            }
            catch (Exception ex)
            {
               Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }
        }
        public void DeleteLOB()
        {
            try
            {
                    string Query2 = "DELETE FROM \"TL_ProLine\"";
                    oDataTable_1.ExecuteQuery(Query2);
            }
            catch (Exception ex)
            {
               Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }
        }
        public void AddLOB()
        {
            try
            {
                    string A1 = "N";
                    string A2 = "N";
                    string A3 = "N";
                    if (chFule.Checked)
                    {
                        A1 = "Y";
                        
                    }
                    if (chLPG.Checked)
                    {
                        A2 = "Y";
                    }
                    if (chLube.Checked)
                    {
                        A3 = "Y";
                    }

                    string QueryInsert = "INSERT INTO \"TL_ProLine\" (\"Fuel\",\"LPG\",\"Lube\",\"UpdateDate\") VALUES('" + A1 + "','" + A2 + "','" + A3 + "',CURRENT_TIMESTAMP )";
                    oDataTable_1.ExecuteQuery(QueryInsert);
                   //Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "", 0);
            }
            catch (Exception ex)
            {

               Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }

        }

        public void LoadData_PriceList()
        {
            try
            {
                Matrix2.FlushToDataSource();
                string Query = "SELECT ROW_NUMBER() OVER(Order By A.\"ListNum\") As \"A\", A.\"ListNum\",A.\"ListName\",CASE WHEN B.\"ListNum\" IS NOT NULL AND B.\"ListName\" IS NOT NULL THEN 'Y' ELSE 'N' END \"Active\" FROM \"OPLN\" A LEFT OUTER JOIN \"TL_PriceList\" B ON A.\"ListNum\" = B.\"ListNum\" and A.\"ListName\" = B.\"ListName\"";
                oDataTable2.ExecuteQuery(Query);
                // Satrt Bind Data*********************************************
                Matrix2.Columns.Item("#").DataBind.Bind("TL_PriceList", "A");
                Matrix2.Columns.Item("ListNum").DataBind.Bind("TL_PriceList", "ListNum");
                Matrix2.Columns.Item("ListName").DataBind.Bind("TL_PriceList", "ListName");
                Matrix2.Columns.Item("Active").DataBind.Bind("TL_PriceList", "Active");
                //End Bind Data*********************************************
                Matrix2.AutoResizeColumns();
                Matrix2.LoadFromDataSource();
            }
            catch (Exception ex)
            {
               Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }

        }
    
    public void Delete_PriceList()
    {
        string Query1 = "DELETE FROM \"TL_PriceList\" ";
        oDataTable2.ExecuteQuery(Query1);
        //Application.SBO_Application.SetStatusBarMessage("Updating...", SAPbouiCOM.BoMessageTime.bmt_Short, false);
    }
    public void Add_PriceList()
    {
        for (int i = 1; i <= Matrix2.RowCount; i++)
        {
            SAPbouiCOM.CheckBox oCheckBox = (SAPbouiCOM.CheckBox)Matrix2.Columns.Item("Active").Cells.Item(i).Specific;

            if (oCheckBox.Checked == true)
            {
                object A = ((SAPbouiCOM.EditText)Matrix2.Columns.Item("ListNum").Cells.Item(i).Specific).Value.ToString();
                object B = ((SAPbouiCOM.EditText)Matrix2.Columns.Item("ListName").Cells.Item(i).Specific).Value.ToString();
                string Query = "INSERT INTO \"TL_PriceList\"(\"ListNum\",\"ListName\",\"Active\",\"UpdateDate\") " +
                                "VALUES('" + A + "','" + B + "','Y',CURRENT_TIMESTAMP)";
                oDataTable2.ExecuteQuery(Query);
            }
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
                btnAdd.Caption = "Update";
            }
           // Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully.", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "",0);
        }
        public void LoadData_DocSet()
        {
            try
            {
                string Query = "SELECT A.\"Lock_Sale\",A.\"Credit_Limit\" FROM \"TL_DocSet\" A";
                oDataTable3.ExecuteQuery(Query);
                CheckBox1.DataBind.Bind("TL_DocSet", "Lock_Sale");
                CheckBox2.DataBind.Bind("TL_DocSet", "Credit_Limit");
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }
        }
        public void Delete_DocSet()
        {
            try
            {
                string Query2 = "DELETE FROM \"TL_DocSet\"";
                oDataTable_3.ExecuteQuery(Query2);
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }
        }
        public void Add_DocSet()
        {
            try
            {
                string A1 = "N";
                string A2 = "N";
                if (CheckBox1.Checked)
                { 
                    A1 = "Y";
                }
                if (CheckBox2.Checked)
                {
                    A2 = "Y";
                }
                
                string QueryInsert = "INSERT INTO \"TL_DocSet\" (\"Lock_Sale\",\"Credit_Limit\",\"UpdateDate\") VALUES('" + A1 + "','" + A2 + "',CURRENT_TIMESTAMP )";
                oDataTable_3.ExecuteQuery(QueryInsert);
                //Application.SBO_Application.StatusBar.SetSystemMessage("Operation completed successfully", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success, "", "", "", 0);
            }
            catch (Exception ex)
            {

                Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }

        }
        public void CheckBox()
        {
            CheckBox1.Item.Width = 20;
            CheckBox1.Item.Height = 18;
            CheckBox2.Item.Width = 20;
            CheckBox2.Item.Height = 18;

            chFule.Item.Width = 100;
            chFule.Item.Height = 18;
            chFule.Caption = "Fule";

            chLPG.Item.Width = 100;
            chLPG.Item.Height = 18;
            chLPG.Caption = "LPG";

            chLube.Item.Width = 100;
            chLube.Item.Height = 18;
            chLube.Caption = "Lube";

          //SAPbouiCOM.Item oNewItem = oForm.Items.Add("1212", SAPbouiCOM.BoFormItemTypes.it_RECTANGLE);
          //  oNewItem.Left = 45;
          //  oNewItem.Width = 300;
          //  oNewItem.Top = 130;
          //  oNewItem.Height = 100;
          //  oNewItem.FromPane = 2;
          //  oNewItem.ToPane = 2;
        }
    }
}

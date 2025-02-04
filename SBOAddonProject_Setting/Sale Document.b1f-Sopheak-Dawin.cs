
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
        public Sale_Document_b1f()
        {
            //oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
            //oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.Item("Form1");
            Folder0.Select();
        }
        private SAPbouiCOM.EditText txtBPCode, txtBPName, txtPLCode, txtPLName, txtPrCode, txtPrName;
        private SAPbouiCOM.StaticText stxtBPCode, stxtBPName, stxtPLCode, stxtPLName,stxtPrCode,stxtPrName;
        private SAPbouiCOM.LinkedButton LinkBP,LinkPL,LinkPr;
        private SAPbouiCOM.Button btnAdd, BtnCancel;
        private SAPbouiCOM.CheckBox CheckBox1, CheckBox2;
       private SAPbouiCOM.DataTable oDataTable;
        private SAPbouiCOM.DBDataSource oDBDataSource;
        private SAPbouiCOM.BoGridColumnType oGridColType;
        private SAPbouiCOM.EditTextColumn oEditColumn;

        private void Matrix0_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //if (pVal.FormUID=="SBOAddonProject_Setting.Sale_Document_b1f" && pVal.ItemUID=="oMatrix" && pVal.ColUID=="CardCode")
            //{
               oDBDataSource = oForm.DataSources.DBDataSources.Item("OCRD");
                SAPbouiCOM.ISBOChooseFromListEventArg CFLValue = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                string Query = "SELECT A.\"CardCode\",A.\"CardName\" FROM \"OCRD\" A";
                oDataTable.ExecuteQuery(Query);
                Matrix0.FlushToDataSource();
                string CFL_Id = CFLValue.ChooseFromListUID;
             //SAPbobsCOM.ChooseFromList CFL = (SAPbobsCOM.ChooseFromList)oForm.ChooseFromLists.Item("BP");
            oDBDataSource = oForm.DataSources.DBDataSources.Item("OCRD");
            oDBDataSource.SetValue("CardCode", 0, CFLValue.SelectedObjects.GetValue("CardCode", 0).ToString());
               oDBDataSource.SetValue("CardName", 0, CFLValue.SelectedObjects.GetValue("CardName", 0).ToString());
                //Matrix0.Columns.Item("CardCode").DataBind.Bind("DT_1", "CardCode");
                //Matrix0.Columns.Item("CardName").DataBind.Bind("DT_1", "CardName");
                // Matrix0.Clear();
                Matrix0.AutoResizeColumns();
                Matrix0.LoadFromDataSource();
          //  }
            
        }

        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Form oForm;
        private SAPbouiCOM.UserDataSource oUserDataSource;
        private SAPbouiCOM.Matrix Matrix0;

        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            // throw new System.NotImplementedException();
            try
            {
                oForm.Close();
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message);
            }

        }
       public void LoadData()
        {
            oDBDataSource = oForm.DataSources.DBDataSources.Item("OCRD");
           //string Query = "SELECT A.\"CardCode\",A.\"CardName\" FROM \"OCRD\" A";
            //oDBDataSource.(Query);
           // Matrix0.FlushToDataSource();
            Matrix0.Columns.Item("CardCode").DataBind.SetBound(true,"OCRD", "CardCode");
            Matrix0.Columns.Item("CardName").DataBind.SetBound(true,"OCRD", "CardName");
            Matrix0.Columns.Item("CardCode").Editable=true;
           // Matrix0.Clear();
            Matrix0.AutoResizeColumns();
            Matrix0.LoadFromDataSource();
           
        }
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.txtBPCode = ((SAPbouiCOM.EditText)(this.GetItem("txtBPCode").Specific));
            this.txtBPCode.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txtBPCode_ChooseFromListAfter);
            this.txtBPName = ((SAPbouiCOM.EditText)(this.GetItem("txtBPName").Specific));
            this.txtPLCode = ((SAPbouiCOM.EditText)(this.GetItem("txtPLCode").Specific));
            this.txtPLCode.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txtPLCode_ChooseFromListAfter);
            this.txtPLName = ((SAPbouiCOM.EditText)(this.GetItem("txtPLName").Specific));
            this.txtPrCode = ((SAPbouiCOM.EditText)(this.GetItem("txtPrCode").Specific));
            this.txtPrCode.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.txtPrCode_ChooseFromListAfter);
            this.txtPrName = ((SAPbouiCOM.EditText)(this.GetItem("txtPrName").Specific));
            this.stxtBPCode = ((SAPbouiCOM.StaticText)(this.GetItem("stxtBPCode").Specific));
            this.stxtBPName = ((SAPbouiCOM.StaticText)(this.GetItem("stxtBPName").Specific));
            this.stxtPLCode = ((SAPbouiCOM.StaticText)(this.GetItem("stxtPLCode").Specific));
            this.stxtPLName = ((SAPbouiCOM.StaticText)(this.GetItem("stxtPLName").Specific));
            this.stxtPrCode = ((SAPbouiCOM.StaticText)(this.GetItem("stxtPrCode").Specific));
            this.stxtPrName = ((SAPbouiCOM.StaticText)(this.GetItem("stxtPrName").Specific));
            this.LinkBP = ((SAPbouiCOM.LinkedButton)(this.GetItem("BPLink").Specific));
            this.LinkPL = ((SAPbouiCOM.LinkedButton)(this.GetItem("PLLink").Specific));
            this.LinkPr = ((SAPbouiCOM.LinkedButton)(this.GetItem("PrLink").Specific));
            this.btnAdd = ((SAPbouiCOM.Button)(this.GetItem("btnAdd").Specific));
            this.BtnCancel = ((SAPbouiCOM.Button)(this.GetItem("btnCancel").Specific));
            this.BtnCancel.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            this.CheckBox1 = ((SAPbouiCOM.CheckBox)(this.GetItem("check1").Specific));
            this.CheckBox2 = ((SAPbouiCOM.CheckBox)(this.GetItem("check2").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_0").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("oMatrix").Specific));
            this.Matrix0.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix0_ChooseFromListAfter);
            this.OnCustomInitialize();

        }
        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }
        public void BP()
        {
            txtBPCode.Item.Height = 19;
            txtBPName.Item.Height = 19;
            stxtBPCode.Item.Height = 19;
            stxtBPName.Item.Height = 19;
            //*************************
            txtPLCode.Item.Height = 19;
            txtPLName.Item.Height = 19;
            stxtPLCode.Item.Height = 19;
            stxtPLName.Item.Height = 19;
            //*************************
            txtPrCode.Item.Height = 19;
            txtPrName.Item.Height = 19;
            stxtPrCode.Item.Height = 19;
            stxtPrName.Item.Height = 19;
            //*************************
            CheckBox1.Item.Width = 18;
            CheckBox1.Item.Height = 16;
            CheckBox2.Item.Width = 18;
            CheckBox2.Item.Height = 16;
        }
        private void txtBPCode_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg CFLValue = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                string UId = CFLValue.ChooseFromListUID;
                SAPbouiCOM.DataTable DT = CFLValue.SelectedObjects;
                txtBPName.Value = DT.GetValue("CardName", 0).ToString();
                txtBPCode.Value = DT.GetValue("CardCode",0).ToString();
            }
            catch ( Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.Message+"BP");
            }

        }
        private void txtPLCode_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg CFLValue = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                string UId = CFLValue.ChooseFromListUID;
                SAPbouiCOM.DataTable DT = CFLValue.SelectedObjects;
                txtPrName.Value = DT.GetValue("ListName", 0).ToString();
                txtPrCode.Value = DT.GetValue("ListName", 0).ToString();
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.Message+"BP");
            }
        }
        private void txtPrCode_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            try
            {
                SAPbouiCOM.ISBOChooseFromListEventArg CFLValue = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                string UId = CFLValue.ChooseFromListUID;
                SAPbouiCOM.DataTable DT = CFLValue.SelectedObjects;
                txtPrName.Value = DT.GetValue("ListName", 0).ToString();
                txtPrCode.Value = DT.GetValue("ListName", 0).ToString();
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.Message+"BP");
            }
        }

        private void OnCustomInitialize()
        {
            try
            {
                oForm = (SAPbouiCOM.Form)Application.SBO_Application.Forms.ActiveForm;
                //oUserDataSource = oForm.DataSources.UserDataSources.Item("UD_0");
                LoadData();
                BP();
                oForm.Visible = true;
        }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage("MMMM"+ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }
}

    }
}

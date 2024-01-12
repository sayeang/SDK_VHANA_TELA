
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
                      
        }

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
            this.Check0.ClickBefore += Check0_ClickBefore1;
            this.OnCustomInitialize();

        }

        private void Check0_ClickBefore1(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item("NewForm1");

                Check0.ValOff = "N";
                Check0.ValOn = "Y";

                Check0.DataBind.SetBound(true,"", "DS_Check1");

                if (Check0.Checked == true)
                {
                    oForm.DataSources.UserDataSources.Item("DS_Check1").Value = "N";
                    Application.SBO_Application.MessageBox("UnCheck");

                }
                else
                {
                    oForm.DataSources.UserDataSources.Item("DS_Check1").Value = "Y";
                    Application.SBO_Application.MessageBox("Check");
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
            try
            {
                
            }
            catch (Exception ex)
            {

                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }
        }

        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;

        private SAPbouiCOM.CheckBox Check0;     

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

        private void Check0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }

        private void OnCustomInitialize()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                Application.SBO_Application.SetStatusBarMessage(ex.Message,SAPbouiCOM.BoMessageTime.bmt_Short,true);
            }
        }

        private void CreateForm()
        {
            //SAPbouiCOM.Item oItem = null;

            //SAPbouiCOM.Button oBtn = null;
            //SAPbouiCOM.CheckBox oCheck = null;

            //SAPbouiCOM.FormCreationParams OCreatPara = null;

            //SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.GetForm("BIZD.Form1",1);
            

            //oForm.DataSources.UserDataSources.Add("DS_Check1",SAPbouiCOM.BoDataType.dt_SHORT_TEXT,1);

            //oForm.Left = 200;
            //oForm.Top = 50;

            //OCreatPara = (SAPbouiCOM.FormCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams));

            //OCreatPara.UniqueID = "Package1";
            //OCreatPara.BorderStyle = SAPbouiCOM.BoFormBorderStyle.fbs_Fixed;           

        }
    }
}

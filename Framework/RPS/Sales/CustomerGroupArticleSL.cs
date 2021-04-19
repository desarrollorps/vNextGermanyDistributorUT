    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerGroupArticleSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerGroupArticleSL:Screen
    {
        public CustomerGroupArticleSL():base()
        {
            this.URL = "sales.customergrouparticlesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerGroupArticleSLVMQueryView  = new CustomerGroupArticleSLVMQueryView(this); 
            CustomerGroupArticleSLVMEntityView  = new CustomerGroupArticleSLVMEntityView(this); 
            CustomerGroupArticlePriceSLView  = new CustomerGroupArticlePriceSLView(this); 
            CustomerGroupArticlePriceCommissionSLView  = new CustomerGroupArticlePriceCommissionSLView(this); 
            CustomerGroupArticleSLVMQueryView.InitializeControls(); 
            CustomerGroupArticleSLVMEntityView.InitializeControls(); 
            CustomerGroupArticlePriceSLView.InitializeControls(); 
            CustomerGroupArticlePriceCommissionSLView.InitializeControls(); 
           
        }
      
            public CustomerGroupArticleSLVMQueryView CustomerGroupArticleSLVMQueryView {get; set; } 
            public CustomerGroupArticleSLVMEntityView CustomerGroupArticleSLVMEntityView {get; set; } 
            public CustomerGroupArticlePriceSLView CustomerGroupArticlePriceSLView {get; set; } 
            public CustomerGroupArticlePriceCommissionSLView CustomerGroupArticlePriceCommissionSLView {get; set; } 
    }
            
    public partial class CustomerGroupArticleSLVMQueryView : View
    {
        public CustomerGroupArticleSLVMQueryView(CustomerGroupArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView>( this,Screen.CustomerGroupArticleSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CustomerGroupArticleSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<CustomerGroupArticleSLVMQueryView>("f71d21c6-d317-4373-a90a-4f86251b793d","","",false, this);
 
            Article = RPSControlFactory.CreateRPSOption<CustomerGroupArticleSLVMQueryView>( "5fb7f79e-8e91-4aea-b4a5-240df2ccf8b6","","",this);
 
            UIIDArticle = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMQueryView>("2377e452-0552-4662-923b-ad46ef96965c","","",false, this);
 
            UIlsIDCustomerGroup = RPSControlFactory.CreateRPSCollectionComboBox<CustomerGroupArticleSLVMQueryView>("fb7fb1e7-9113-4ab3-a553-61ab1cc9723b","","",false, this);
 
            Group = RPSControlFactory.CreateRPSOption<CustomerGroupArticleSLVMQueryView>( "bb28e872-a5e4-4c17-bed3-4599686cb359","","",this);
 
            UIIDCustomerGroup = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMQueryView>("79f41e76-27d4-4818-8f80-cf65ca57e9a5","","",false, this);
 
            UIIDCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMQueryView>("0539f7d2-1855-4b49-abcb-164b83c02f55","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<CustomerGroupArticleSLVMQueryView>("eb94679b-57a7-48dd-8ee1-6029010d54f5","","",false, this);
 
            CollectionInit params_CustomerGroupArticleSLConsult = new CollectionInit(){IDDescriptor = "0a8cddde-1280-45fd-9488-1e6856f31915",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d9c7aa3f-440d-4785-a652-90b53fa0ca1a",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupArticleSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupArticleSLConsultCollectionEditor<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView>,CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView>( params_CustomerGroupArticleSLConsult,this,Screen.CustomerGroupArticleSLVMEntityView);
 

        }
        public IRPSButton<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CustomerGroupArticleSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CustomerGroupArticleSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSOption<CustomerGroupArticleSLVMQueryView> Article { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMQueryView> UIIDArticle { get; set; } 
        public IRPSCollectionComboBox<CustomerGroupArticleSLVMQueryView> UIlsIDCustomerGroup { get; set; } 
        public IRPSOption<CustomerGroupArticleSLVMQueryView> Group { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMQueryView> UIIDCustomerGroup { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMQueryView> UIIDCustomerGroupValue { get; set; } 
        public IRPSCollectionComboBox<CustomerGroupArticleSLVMQueryView> UIlsIDArticle { get; set; } 
        public CustomerGroupArticleSLConsultCollectionEditor<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> CustomerGroupArticleSLConsult { get; set; } 
        public CustomerGroupArticleSL Screen { get; set; }
        public CustomerGroupArticleSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupArticleSLConsultCollectionEditor<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView>:RPSCollectionEditor<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> where CustomerGroupArticleSLVMQueryView : class, IView where CustomerGroupArticleSLVMEntityView : class, IView
    {
        public  CustomerGroupArticleSLConsultGridView<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerGroupArticleSLConsultGridView <CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> :  RPSGridView<CustomerGroupArticleSLVMQueryView,CustomerGroupArticleSLVMEntityView> where CustomerGroupArticleSLVMQueryView : class, IView where CustomerGroupArticleSLVMEntityView : class, IView
    {
        public CustomerGroupArticleSLConsultGridView(CustomerGroupArticleSLVMQueryView currentView,CustomerGroupArticleSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerGroupArticleSL_DescriptionCustomerGroup = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupArticleSLVMQueryView>("","#d9c7aa3f-440d-4785-a652-90b53fa0ca1a .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupArticleSL_DescriptionCustomerGroup']","",false, this.CurrentView);
 
            CustomerGroupArticleSL_ReferenceCustomerGroup = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupArticleSLVMQueryView>("","#d9c7aa3f-440d-4785-a652-90b53fa0ca1a .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupArticleSL_ReferenceCustomerGroup']","",false, this.CurrentView);
 
            CustomerGroupArticleSL_Blocked = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupArticleSLVMQueryView>("","#d9c7aa3f-440d-4785-a652-90b53fa0ca1a .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupArticleSL_Blocked']","",false, this.CurrentView);
 
            CustomerGroupArticleSL_SalesKit = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupArticleSLVMQueryView>("","#d9c7aa3f-440d-4785-a652-90b53fa0ca1a .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupArticleSL_SalesKit']","",false, this.CurrentView);
 
            CustomerGroupArticleSL_VAT = RPSControlFactory.CreateRPSGridCheckBox<CustomerGroupArticleSLVMQueryView>("","#d9c7aa3f-440d-4785-a652-90b53fa0ca1a .ag-row[role='row']@ROWINDEX [col-id='cCustomerGroupArticleSL_VAT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerGroupArticleSLVMQueryView> CustomerGroupArticleSL_DescriptionCustomerGroup { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticleSLVMQueryView> CustomerGroupArticleSL_ReferenceCustomerGroup { get; set; } 
        public IRPSGridCheckbox<CustomerGroupArticleSLVMQueryView> CustomerGroupArticleSL_Blocked { get; set; } 
        public IRPSGridCheckbox<CustomerGroupArticleSLVMQueryView> CustomerGroupArticleSL_SalesKit { get; set; } 
        public IRPSGridCheckbox<CustomerGroupArticleSLVMQueryView> CustomerGroupArticleSL_VAT { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupArticleSLVMEntityView : View
    {
        public CustomerGroupArticleSLVMEntityView(CustomerGroupArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerGroupArticleSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupArticleSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupArticleSLVMEntityView,CustomerGroupArticleSLVMQueryView>( this,Screen.CustomerGroupArticleSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupArticleSLVMEntityView,CustomerGroupArticleSLVMQueryView>( this,Screen.CustomerGroupArticleSLVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMEntityView>("4c296ff8-cc41-46b7-93e9-92f873c04c80","","",true, this);
 
            UIIDCustomerGroup = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMEntityView>("e7d2193b-e064-4c7f-b845-769c27775d2c","","",true, this);
 
            IDCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMEntityView>("d2869921-bec4-488c-b876-3156ebff574a","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMEntityView>("ebf6f661-53c3-4a4c-9edc-ce7e8f395b73","","",false, this);
 
            ReferenceCustomerGroup = RPSControlFactory.CreateRPSTextBox<CustomerGroupArticleSLVMEntityView>("9420879f-2ac1-4d5d-9fcc-8e8280a1fa27","","",false, this);
 
            DescriptionCustomerGroup = RPSControlFactory.CreateRPSTextBox<CustomerGroupArticleSLVMEntityView>("1263f306-0bc6-4942-91f9-4b4178b7bac2","","",false, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticleSLVMEntityView>("29ecb48b-46b0-4c02-b8fb-f85bac7814f0","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticleSLVMEntityView>("d9ae75e3-ebaf-4270-a563-1e152e9a5d40","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticleSLVMEntityView>("bcc9b1f5-02cf-4fd9-a862-2ee01f5d1eed","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticleSLVMEntityView>("500d4922-16e3-4645-9079-5644697d8e67","","",true, this);
 
            CollectionInit params_CustomerGroupArticlePriceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1fc53437-94ba-4271-a30f-8cb1da4eca11",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupArticlePriceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupArticlePriceSLsCollectionEditor<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView>,CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView>( params_CustomerGroupArticlePriceSLs,this,Screen.CustomerGroupArticlePriceSLView);
 

        }
        public IRPSSaveButton<CustomerGroupArticleSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerGroupArticleSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticleSLVMEntityView,CustomerGroupArticleSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticleSLVMEntityView,CustomerGroupArticleSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMEntityView> UIIDCustomerGroup { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMEntityView> IDCustomerGroupValue { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<CustomerGroupArticleSLVMEntityView> ReferenceCustomerGroup { get; set; } 
        public IRPSTextBox<CustomerGroupArticleSLVMEntityView> DescriptionCustomerGroup { get; set; } 
        public IRPSCheckbox<CustomerGroupArticleSLVMEntityView> SalesKit { get; set; } 
        public IRPSCheckbox<CustomerGroupArticleSLVMEntityView> VAT { get; set; } 
        public IRPSCheckbox<CustomerGroupArticleSLVMEntityView> Blocked { get; set; } 
        public IRPSComboBox<CustomerGroupArticleSLVMEntityView> IDCurrency { get; set; } 
        public CustomerGroupArticlePriceSLsCollectionEditor<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView> CustomerGroupArticlePriceSLs { get; set; } 
        public CustomerGroupArticleSL Screen { get; set; }
        public CustomerGroupArticleSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupArticlePriceSLsCollectionEditor<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView>:RPSCollectionEditor<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView> where CustomerGroupArticleSLVMEntityView : class, IView where CustomerGroupArticlePriceSLView : class, IView
    {
        public  CustomerGroupArticlePriceSLsGridView<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView> GridView {get;set;}
    }
    public partial class CustomerGroupArticlePriceSLsGridView <CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView> :  RPSGridView<CustomerGroupArticleSLVMEntityView,CustomerGroupArticlePriceSLView> where CustomerGroupArticleSLVMEntityView : class, IView where CustomerGroupArticlePriceSLView : class, IView
    {
        public CustomerGroupArticlePriceSLsGridView(CustomerGroupArticleSLVMEntityView currentView,CustomerGroupArticlePriceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupArticleSLVMEntityView>("","#1fc53437-94ba-4271-a30f-8cb1da4eca11 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupArticleSLVMEntityView>("","#1fc53437-94ba-4271-a30f-8cb1da4eca11 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupArticleSLVMEntityView>("","#1fc53437-94ba-4271-a30f-8cb1da4eca11 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupArticleSLVMEntityView>("","#1fc53437-94ba-4271-a30f-8cb1da4eca11 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            NetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupArticleSLVMEntityView>("","#1fc53437-94ba-4271-a30f-8cb1da4eca11 .ag-row[role='row']@ROWINDEX [col-id='cNetPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerGroupArticleSLVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticleSLVMEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticleSLVMEntityView> QuantityFrom { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticleSLVMEntityView> Price { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticleSLVMEntityView> NetPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupArticlePriceSLView : View
    {
        public CustomerGroupArticlePriceSLView(CustomerGroupArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupArticlePriceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView>( this,Screen.CustomerGroupArticleSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView>( this,Screen.CustomerGroupArticleSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView>( this,Screen.CustomerGroupArticleSLVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CustomerGroupArticlePriceSLView>("d9bd2050-1921-483f-8727-8a0673a208d8","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CustomerGroupArticlePriceSLView>("87f941ba-13f4-4c7e-90f5-3a28773d77d1","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("11f426c1-7efd-4a3a-a2fe-776f9379e74f","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticlePriceSLView>("67c2fece-c26f-4121-97c6-91fa9fe758ad","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("d311989c-2be8-4c5e-8911-788d208d52fa","","",false, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticlePriceSLView>("48b39c09-8f6f-49d7-8dcc-cc81ac5e3867","","",true, this);
 
            ValidPrice = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("eb4e668b-c6a8-43a2-a2ef-f95e3aab4972","","",true, this);
 
            ValidDiscount = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("9e5d8994-f799-43b7-9349-40e9503e4682","","",true, this);
 
            NetPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("5618790f-2d74-4389-981b-ff32857fcb8e","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("c1c9d419-a4c1-42b7-aa8a-a86dca291c18","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("66e24448-eca8-42ed-8843-a2bf4a770d3f","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("fd4f25f7-11ec-4fe2-9306-999bb7f97da6","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("975a5e4c-d036-47b4-9b9e-144c2d7dcd14","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("ba0f1ccf-0c64-4f3f-9de0-08db1e44c189","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("33981cb0-d5d8-49af-a17b-f21983a3556c","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("078f4f6e-5b04-4483-873c-2f62f505a969","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("ba8a466b-0392-4eda-81cd-9047d8c0f621","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("40931cf7-e18b-42ed-a9ef-0fa77f247bc0","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("0705282c-acc7-4b9b-a23b-cb4716748e13","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("dd40a556-fd85-441a-9218-2d8ecbfcd04a","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceSLView>("2593043e-17e1-4cfa-8c99-0611e79e14fe","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<CustomerGroupArticlePriceSLView>("de9b19e8-e36c-483c-9daf-06450b297871","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerGroupArticlePriceSLView>("b7741006-7c8a-4c97-9fee-177d9bc958ce","","",true, this);
 
            CollectionInit params_CustomerGroupArticlePriceCommissionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ddd97da8-9e50-40f7-89dd-685cbb2c7f98",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupArticlePriceCommissionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupArticlePriceCommissionSLsCollectionEditor<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView>,CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView>( params_CustomerGroupArticlePriceCommissionSLs,this,Screen.CustomerGroupArticlePriceCommissionSLView);
 

        }
        public IRPSButton<CustomerGroupArticlePriceSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupArticlePriceSLView,CustomerGroupArticleSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> DateFrom { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> DateTo { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> QuantityFrom { get; set; } 
        public IRPSComboBox<CustomerGroupArticlePriceSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Price { get; set; } 
        public IRPSComboBox<CustomerGroupArticlePriceSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> ValidPrice { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> ValidDiscount { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> NetPrice { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Discount1 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Discount2 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Discount3 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> CascadeDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Discount4 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> Discount5 { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<CustomerGroupArticlePriceSLView> PositionAmountDiscount { get; set; } 
        public IRPSCheckbox<CustomerGroupArticlePriceSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public CustomerGroupArticlePriceCommissionSLsCollectionEditor<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView> CustomerGroupArticlePriceCommissionSLs { get; set; } 
        public CustomerGroupArticleSL Screen { get; set; }
        public CustomerGroupArticlePriceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupArticlePriceCommissionSLsCollectionEditor<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView>:RPSCollectionEditor<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView> where CustomerGroupArticlePriceSLView : class, IView where CustomerGroupArticlePriceCommissionSLView : class, IView
    {
        public  CustomerGroupArticlePriceCommissionSLsGridView<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView> GridView {get;set;}
    }
    public partial class CustomerGroupArticlePriceCommissionSLsGridView <CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView> :  RPSGridView<CustomerGroupArticlePriceSLView,CustomerGroupArticlePriceCommissionSLView> where CustomerGroupArticlePriceSLView : class, IView where CustomerGroupArticlePriceCommissionSLView : class, IView
    {
        public CustomerGroupArticlePriceCommissionSLsGridView(CustomerGroupArticlePriceSLView currentView,CustomerGroupArticlePriceCommissionSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupArticlePriceSLView>("","#ddd97da8-9e50-40f7-89dd-685cbb2c7f98 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerGroupArticlePriceSLView>("","#ddd97da8-9e50-40f7-89dd-685cbb2c7f98 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupArticlePriceSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<CustomerGroupArticlePriceSLView> Commission { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupArticlePriceCommissionSLView : View
    {
        public CustomerGroupArticlePriceCommissionSLView(CustomerGroupArticleSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupArticlePriceCommissionSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView>( this,Screen.CustomerGroupArticlePriceSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView>( this,Screen.CustomerGroupArticlePriceSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView>( this,Screen.CustomerGroupArticlePriceSLView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CustomerGroupArticlePriceCommissionSLView>("887061a7-acda-4bb8-94b0-31ba8c88e4f0","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<CustomerGroupArticlePriceCommissionSLView>("31fb434d-bbb2-4763-a25e-88e59ed28b1b","","",true, this);
 

        }
        public IRPSButton<CustomerGroupArticlePriceCommissionSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupArticlePriceCommissionSLView,CustomerGroupArticlePriceSLView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerGroupArticlePriceCommissionSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<CustomerGroupArticlePriceCommissionSLView> Commission { get; set; } 
        public CustomerGroupArticleSL Screen { get; set; }
        public CustomerGroupArticlePriceCommissionSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
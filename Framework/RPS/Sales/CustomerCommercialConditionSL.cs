    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerCommercialConditionSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerCommercialConditionSL:Screen
    {
        public CustomerCommercialConditionSL():base()
        {
            this.URL = "sales.customercommercialconditionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCommercialConditionSLVMQueryView  = new CustomerCommercialConditionSLVMQueryView(this); 
            CustomerCommercialConditionSLVMEntityView  = new CustomerCommercialConditionSLVMEntityView(this); 
            CustomerCommercialConditionSLVMQueryView.InitializeControls(); 
            CustomerCommercialConditionSLVMEntityView.InitializeControls(); 
           
        }
      
            public CustomerCommercialConditionSLVMQueryView CustomerCommercialConditionSLVMQueryView {get; set; } 
            public CustomerCommercialConditionSLVMEntityView CustomerCommercialConditionSLVMEntityView {get; set; } 
    }
            
    public partial class CustomerCommercialConditionSLVMQueryView : View
    {
        public CustomerCommercialConditionSLVMQueryView(CustomerCommercialConditionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView>( this,Screen.CustomerCommercialConditionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CustomerCommercialConditionSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<CustomerCommercialConditionSLVMQueryView>("6dc22fd6-c99d-4b42-b67d-216bcd64d1ac","","",false, this);
 
            UIIDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMQueryView>("1b9db3ff-3210-423a-9c20-01ce25fe8fd1","","",false, this);
 
            UIProducLine = RPSControlFactory.CreateRPSCheckBox<CustomerCommercialConditionSLVMQueryView>("f1924baf-b040-4d7d-afe8-b34f3812425e","","",false, this);
 
            UIlsProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView>("425fc1df-64df-4d64-9a95-93cef739b724","","",false, this);
 
            UIFamily = RPSControlFactory.CreateRPSCheckBox<CustomerCommercialConditionSLVMQueryView>("389b8d3e-21c6-47fe-9b4d-21aef4b771de","","",false, this);
 
            UIlsProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView>("d6b8d4f3-59d1-4843-ab19-e5eb4cc342fd","","",false, this);
 
            UISubFamily = RPSControlFactory.CreateRPSCheckBox<CustomerCommercialConditionSLVMQueryView>("156ec951-96cf-49a3-8a92-f64dbeeedd90","","",false, this);
 
            UIlsProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView>("95b62f47-6244-4c60-b077-954eed27c88c","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCheckBox<CustomerCommercialConditionSLVMQueryView>("40b5c6b4-4892-4797-a4cc-11c9fb4bb799","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView>("60edca44-4be7-4500-b3f0-94b6599593e8","","",false, this);
 
            UIAllArticle = RPSControlFactory.CreateRPSCheckBox<CustomerCommercialConditionSLVMQueryView>("6124b774-4be7-4d3e-9592-0520d29a6889","","",false, this);
 
            CollectionInit params_CustomerCommercialConditionSLConsult = new CollectionInit(){IDDescriptor = "5f3119c6-442a-4634-b4a1-f01349bfb38e",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb3db139-fa04-446c-810e-a61dce091965",CSSSelectorGrid="",XPathGrid=""};
            CustomerCommercialConditionSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerCommercialConditionSLConsultCollectionEditor<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView>,CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView>( params_CustomerCommercialConditionSLConsult,this,Screen.CustomerCommercialConditionSLVMEntityView);
 

        }
        public IRPSButton<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CustomerCommercialConditionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMQueryView> UIIDCustomer { get; set; } 
        public IRPSCheckbox<CustomerCommercialConditionSLVMQueryView> UIProducLine { get; set; } 
        public IRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView> UIlsProductLine { get; set; } 
        public IRPSCheckbox<CustomerCommercialConditionSLVMQueryView> UIFamily { get; set; } 
        public IRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView> UIlsProductFamily { get; set; } 
        public IRPSCheckbox<CustomerCommercialConditionSLVMQueryView> UISubFamily { get; set; } 
        public IRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView> UIlsProductSubFamily { get; set; } 
        public IRPSCheckbox<CustomerCommercialConditionSLVMQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<CustomerCommercialConditionSLVMQueryView> UIlsIDArticle { get; set; } 
        public IRPSCheckbox<CustomerCommercialConditionSLVMQueryView> UIAllArticle { get; set; } 
        public CustomerCommercialConditionSLConsultCollectionEditor<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> CustomerCommercialConditionSLConsult { get; set; } 
        public CustomerCommercialConditionSL Screen { get; set; }
        public CustomerCommercialConditionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerCommercialConditionSLConsultCollectionEditor<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView>:RPSCollectionEditor<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMQueryView : class, IView where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public  CustomerCommercialConditionSLConsultGridView<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerCommercialConditionSLConsultGridView <CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> :  RPSGridView<CustomerCommercialConditionSLVMQueryView,CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMQueryView : class, IView where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public CustomerCommercialConditionSLConsultGridView(CustomerCommercialConditionSLVMQueryView currentView,CustomerCommercialConditionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerCommercialConditionSL_Description = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMQueryView>("","#eb3db139-fa04-446c-810e-a61dce091965 .ag-row[role='row']@ROWINDEX [col-id='cCustomerCommercialConditionSL_Description']","",false, this.CurrentView);
 
            CustomerCommercialConditionSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMQueryView>("","#eb3db139-fa04-446c-810e-a61dce091965 .ag-row[role='row']@ROWINDEX [col-id='cCustomerCommercialConditionSL_DateFrom']","",false, this.CurrentView);
 
            CustomerCommercialConditionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMQueryView>("","#eb3db139-fa04-446c-810e-a61dce091965 .ag-row[role='row']@ROWINDEX [col-id='cCustomerCommercialConditionSL_DateTo']","",false, this.CurrentView);
 
            CustomerCommercialConditionSL_ItemType = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMQueryView>("","#eb3db139-fa04-446c-810e-a61dce091965 .ag-row[role='row']@ROWINDEX [col-id='cCustomerCommercialConditionSL_ItemType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerCommercialConditionSLVMQueryView> CustomerCommercialConditionSL_Description { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMQueryView> CustomerCommercialConditionSL_DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMQueryView> CustomerCommercialConditionSL_DateTo { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMQueryView> CustomerCommercialConditionSL_ItemType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerCommercialConditionSLVMEntityView : View
    {
        public CustomerCommercialConditionSLVMEntityView(CustomerCommercialConditionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerCommercialConditionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerCommercialConditionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerCommercialConditionSLVMEntityView,CustomerCommercialConditionSLVMQueryView>( this,Screen.CustomerCommercialConditionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerCommercialConditionSLVMEntityView,CustomerCommercialConditionSLVMQueryView>( this,Screen.CustomerCommercialConditionSLVMQueryView);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("e32a0f27-941f-4328-b890-8f04baa76d68","","",true, this);
 
            IDCommercialConditionType = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("2b23fb3c-ed47-4ff4-9daf-4f877595f7b1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerCommercialConditionSLVMEntityView>("05c8084e-75d0-417c-9e19-51fe0f72c3d6","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CustomerCommercialConditionSLVMEntityView>("78449a4d-e1d3-45d5-9211-0490f5bd7233","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CustomerCommercialConditionSLVMEntityView>("e88ccd55-8f2e-4b42-a336-a9c8590dbf7c","","",true, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CustomerCommercialConditionSLVMEntityView>("1c4d9906-089b-496b-959a-8d57f72cece3","","",true, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("2519e983-cb79-4222-ae52-5b9419ef8c0c","","",false, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("d00c40e9-795d-4857-9bdb-565d2c8dda9d","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("78c8b8f1-6d43-4c46-8c07-69b31ddf30f1","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<CustomerCommercialConditionSLVMEntityView>("167781fb-ce00-40d8-adcf-1c1a31bd5f69","","",false, this);
 
            ConditionValue = RPSControlFactory.CreateRPSFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("ffe22623-9d89-4eb3-9914-03668fda97db","","",true, this);
 
            ConditionValueAmount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("a724afe2-a9aa-49f6-ba8f-dd01d8823564","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<CustomerCommercialConditionSLVMEntityView>( "ecc276f2-6824-43a1-8d04-79070cf5c659","","",this);
 
            CollectionInit params_CustomerCommercialConditionCassationSLApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16795ab6-042d-46c9-a047-06f1556bab25",CSSSelectorGrid="",XPathGrid=""};
            CustomerCommercialConditionCassationSLApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerCommercialConditionCassationSLAppliedsCollectionEditor<CustomerCommercialConditionSLVMEntityView>,CustomerCommercialConditionSLVMEntityView>( params_CustomerCommercialConditionCassationSLApplieds,this);
 
            CollectionInit params_CustomerCommercialConditionCassationSLCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b4a65fa5-9b4c-4078-9339-79d0648ac377",CSSSelectorGrid="",XPathGrid=""};
            CustomerCommercialConditionCassationSLCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerCommercialConditionCassationSLCassationsCollectionEditor<CustomerCommercialConditionSLVMEntityView>,CustomerCommercialConditionSLVMEntityView>( params_CustomerCommercialConditionCassationSLCassations,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerCommercialConditionSLVMEntityView>( "","ul li[rpsid='aef42818-67da-497c-9ca8-520d6b87b8d3']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<CustomerCommercialConditionSLVMEntityView>( "","ul li[rpsid='aadb4295-497a-48a0-98e4-4201ddb76b9c']","",this);
 

        }
        public IRPSSaveButton<CustomerCommercialConditionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerCommercialConditionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerCommercialConditionSLVMEntityView,CustomerCommercialConditionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerCommercialConditionSLVMEntityView,CustomerCommercialConditionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDCommercialConditionType { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDItemArticle { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDItemProductLine { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<CustomerCommercialConditionSLVMEntityView> IDItemProductSubFamily { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> ConditionValue { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> ConditionValueAmount { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> UIApply { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> UILiquidate { get; set; } 
        public IRPSTextBox<CustomerCommercialConditionSLVMEntityView> UIDifference { get; set; } 
        public IRPSButton<CustomerCommercialConditionSLVMEntityView> CassationCommandButton { get; set; } 
        public CustomerCommercialConditionCassationSLAppliedsCollectionEditor<CustomerCommercialConditionSLVMEntityView> CustomerCommercialConditionCassationSLApplieds { get; set; } 
        public CustomerCommercialConditionCassationSLCassationsCollectionEditor<CustomerCommercialConditionSLVMEntityView> CustomerCommercialConditionCassationSLCassations { get; set; } 
        public IRPSSection<CustomerCommercialConditionSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerCommercialConditionSLVMEntityView> SectionCassation { get; set; } 
        public CustomerCommercialConditionSL Screen { get; set; }
        public CustomerCommercialConditionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerCommercialConditionCassationSLAppliedsCollectionEditor<CustomerCommercialConditionSLVMEntityView>:RPSCollectionEditor<CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public  CustomerCommercialConditionCassationSLAppliedsGridView<CustomerCommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerCommercialConditionCassationSLAppliedsGridView <CustomerCommercialConditionSLVMEntityView> :  RPSGridView<CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public CustomerCommercialConditionCassationSLAppliedsGridView(CustomerCommercialConditionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMEntityView>("","#16795ab6-042d-46c9-a047-06f1556bab25 .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerCommercialConditionSLVMEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CustomerCommercialConditionSLVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CustomerCommercialConditionSLVMEntityView> Processed { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CustomerCommercialConditionCassationSLCassationsCollectionEditor<CustomerCommercialConditionSLVMEntityView>:RPSCollectionEditor<CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public  CustomerCommercialConditionCassationSLCassationsGridView<CustomerCommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CustomerCommercialConditionCassationSLCassationsGridView <CustomerCommercialConditionSLVMEntityView> :  RPSGridView<CustomerCommercialConditionSLVMEntityView> where CustomerCommercialConditionSLVMEntityView : class, IView
    {
        public CustomerCommercialConditionCassationSLCassationsGridView(CustomerCommercialConditionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CustomerCommercialConditionSLVMEntityView>("","#b4a65fa5-9b4c-4078-9339-79d0648ac377 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerCommercialConditionSLVMEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CustomerCommercialConditionSLVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CustomerCommercialConditionSLVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CustomerCommercialConditionSLVMEntityView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
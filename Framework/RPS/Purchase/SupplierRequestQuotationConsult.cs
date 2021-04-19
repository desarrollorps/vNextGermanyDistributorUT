    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierRequestQuotationConsult
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRequestQuotationConsult:Screen
    {
        public SupplierRequestQuotationConsult():base()
        {
            this.URL = "purchase.supplierrequestquotationconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRequestQuotationConsultQueryView  = new SupplierRequestQuotationConsultQueryView(this); 
            SupplierRequestQuotationGroupSearchDialogView  = new SupplierRequestQuotationGroupSearchDialogView(this); 
            SupplierRequestQuotationConsultQueryView.InitializeControls(); 
            SupplierRequestQuotationGroupSearchDialogView.InitializeControls(); 
           
        }
      
            public SupplierRequestQuotationConsultQueryView SupplierRequestQuotationConsultQueryView {get; set; } 
            public SupplierRequestQuotationGroupSearchDialogView SupplierRequestQuotationGroupSearchDialogView {get; set; } 
    }
            
    public partial class SupplierRequestQuotationConsultQueryView : View
    {
        public SupplierRequestQuotationConsultQueryView(SupplierRequestQuotationConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierRequestQuotation = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("b191181f-6fac-4247-a6ae-683e37ef9b99","","",false, this);
 
            IDSupplierRQuotationType = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("cba70450-5e5e-4714-a366-e4d5bb12b1e9","","",false, this);
 
            RequestQuotationDateFrom = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("ef4020ba-6f77-42d1-b274-d557d46fc36f","","",false, this);
 
            RequestQuotationDateTo = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("22f43ead-db0e-480b-bfc8-2514713da6fc","","",false, this);
 
            ReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("81aad351-5a44-4e7b-8e84-bc5ea3cd011b","","",false, this);
 
            ReceptionDateTo = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("c34c5652-ca6c-46b5-ab3c-89e558416d91","","",false, this);
 
            StatusOptionAll = RPSControlFactory.CreateRPSOption<SupplierRequestQuotationConsultQueryView>( "d796ad8b-db03-4f25-acc2-8a757924c5fc","","",this);
 
            StatusOptionSelection = RPSControlFactory.CreateRPSOption<SupplierRequestQuotationConsultQueryView>( "6419f265-e1a5-4c0b-a882-5da24edb859b","","",this);
 
            eReceivedStatus = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationConsultQueryView>("19b14043-1783-494e-a5d1-3cd7b656abc5","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("bea436d8-7494-48ce-9331-68c4cd55a2d3","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("3952f968-16fb-4759-974e-35da1da56999","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("264cf332-ff87-410d-a1c3-1e73bd8101e2","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("ea2542f6-ed8f-43f4-aab2-01a3604009ab","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("620a6dce-0cc2-4f06-9f75-c0ac74381393","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView>("3495bb0c-7c5a-4f75-9782-f5a59034d9e4","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationConsultQueryView>("9ff7dfba-941e-4dc2-9c3d-098e9ca9af15","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("78d2d391-3e05-4845-ba2c-9ef9abe95f20","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("dad01057-3d30-4a4f-bb2c-36e923c3555c","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("1e81ba20-1062-4ee9-b0bd-df9e06ddceed","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("2b783b2c-19f5-4f6c-96bf-3f91291c9675","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("364fdeee-6a37-4b66-9c1b-9c75e24b849b","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("51e07343-3b67-48d7-aef6-a031e398abb2","","",false, this);
 
            OnlyExternalTask = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationConsultQueryView>("cc71e8a2-e2db-44f8-94a0-1090ffebb69d","","",false, this);
 
            IDQuotationSL = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("78f14804-ded6-46c5-b5a8-7f5fbf8f2946","","",false, this);
 
            IDPurchaseProposal = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("bb6eff6c-ec94-421a-8929-21170613650d","","",false, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationConsultQueryView>("a12e3cbb-1023-4334-9c05-25dd9c8a258c","","",false, this);
 
            SupplierRequestQuotationGroupSearchNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>("23857e5e-a367-46e5-917c-3d40b2aa051c","","", this,Screen.SupplierRequestQuotationGroupSearchDialogView);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("31eb48b6-0538-49c7-8f33-99f993453b09","","",false, this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationConsultQueryView>("b6f5ed61-9f55-4ed4-a8f2-24906bfdcf55","","",false, this);
 
            CollectionInit params_SupplierRequestQuotationConsultQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11d5a04b-3aa8-45b9-bd56-6eb87d7ed659",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationConsultQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>,SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>( params_SupplierRequestQuotationConsultQuery,this,Screen.SupplierRequestQuotationGroupSearchDialogView);
 
            CollectionInit params_SupplierRequestQuotationLineConsultQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0f1d4fed-fce7-4fef-9c51-68a9052bb13e",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationLineConsultQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationLineConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>,SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>( params_SupplierRequestQuotationLineConsultQuery,this,Screen.SupplierRequestQuotationGroupSearchDialogView);
 

        }
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotation { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDSupplierRQuotationType { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> RequestQuotationDateFrom { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> RequestQuotationDateTo { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> ReceptionDateFrom { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> ReceptionDateTo { get; set; } 
        public IRPSOption<SupplierRequestQuotationConsultQueryView> StatusOptionAll { get; set; } 
        public IRPSOption<SupplierRequestQuotationConsultQueryView> StatusOptionSelection { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> eReceivedStatus { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDSupplierGroup { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationConsultQueryView> IDArticle { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> ReferenceSupplier { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDProject { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDOrderSL { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDArticleStructure { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> InternalCode { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationConsultQueryView> OnlyExternalTask { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDQuotationSL { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDPurchaseProposal { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationConsultQueryView> Group { get; set; } 
        public IRPSButton<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationGroupSearchNavigationCommand { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationConsultQueryView> IDFrameworkContract { get; set; } 
        public SupplierRequestQuotationConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationConsultQuery { get; set; } 
        public SupplierRequestQuotationLineConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationLineConsultQuery { get; set; } 
        public SupplierRequestQuotationConsult Screen { get; set; }
        public SupplierRequestQuotationConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRequestQuotationConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>:RPSCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationConsultQueryView : class, IView where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public  SupplierRequestQuotationConsultQueryGridView<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationConsultQueryGridView <SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> :  RPSGridView<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationConsultQueryView : class, IView where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public SupplierRequestQuotationConsultQueryGridView(SupplierRequestQuotationConsultQueryView currentView,SupplierRequestQuotationGroupSearchDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotation_SupplierRFQDate = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationConsultQueryView>("","#11d5a04b-3aa8-45b9-bd56-6eb87d7ed659 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotation_SupplierRFQDate']","",false, this.CurrentView);
 
            SupplierRequestQuotation_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationConsultQueryView>("","#11d5a04b-3aa8-45b9-bd56-6eb87d7ed659 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotation_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotation_SupplierRFQDate { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotation_ReceptionDate { get; set; } 
                     
    }
 
        public partial class SupplierRequestQuotationLineConsultQueryCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView>:RPSCollectionEditor<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationConsultQueryView : class, IView where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public  SupplierRequestQuotationLineConsultQueryGridView<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationLineConsultQueryGridView <SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> :  RPSGridView<SupplierRequestQuotationConsultQueryView,SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationConsultQueryView : class, IView where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public SupplierRequestQuotationLineConsultQueryGridView(SupplierRequestQuotationConsultQueryView currentView,SupplierRequestQuotationGroupSearchDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotationLine_Description = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationConsultQueryView>("","#0f1d4fed-fce7-4fef-9c51-68a9052bb13e .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_Description']","",false, this.CurrentView);
 
            SupplierRequestQuotationLine_PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationConsultQueryView>("","#0f1d4fed-fce7-4fef-9c51-68a9052bb13e .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_PercentVAT']","",false, this.CurrentView);
 
            SupplierRequestQuotationLine_ReceivedStatus = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationConsultQueryView>("","#0f1d4fed-fce7-4fef-9c51-68a9052bb13e .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_ReceivedStatus']","",false, this.CurrentView);
 
            SupplierRequestQuotationLine_ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationConsultQueryView>("","#0f1d4fed-fce7-4fef-9c51-68a9052bb13e .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_ReferenceSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotationLine_Description { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotationLine_PercentVAT { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotationLine_ReceivedStatus { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationConsultQueryView> SupplierRequestQuotationLine_ReferenceSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierRequestQuotationGroupSearchDialogView : View
    {
        public SupplierRequestQuotationGroupSearchDialogView(SupplierRequestQuotationConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedDateFromFilter = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationGroupSearchDialogView>("a1b114cf-387e-4fa9-b7b6-4de9523f8be5","","",false, this);
 
            ExecuteSupplierRequestQuotationGroupInquire = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationGroupSearchDialogView>( "24cc5453-6066-443f-aff7-9d4abb032361","","",this);
 
            CollectionInit params_SupplierRequestQuotationGroupInquire = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2523b89-dfb3-4acb-b9d5-55de078e7b09",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationGroupInquire = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView>,SupplierRequestQuotationGroupSearchDialogView>( params_SupplierRequestQuotationGroupInquire,this);
 

        }
        public IRPSTextBox<SupplierRequestQuotationGroupSearchDialogView> SelectedDateFromFilter { get; set; } 
        public IRPSButton<SupplierRequestQuotationGroupSearchDialogView> ExecuteSupplierRequestQuotationGroupInquire { get; set; } 
        public SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationGroupInquire { get; set; } 
        public SupplierRequestQuotationConsult Screen { get; set; }
        public SupplierRequestQuotationGroupSearchDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView>:RPSCollectionEditor<SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public  SupplierRequestQuotationGroupInquireGridView<SupplierRequestQuotationGroupSearchDialogView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationGroupInquireGridView <SupplierRequestQuotationGroupSearchDialogView> :  RPSGridView<SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public SupplierRequestQuotationGroupInquireGridView(SupplierRequestQuotationGroupSearchDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotation_SupplierRFQGroup = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationGroupSearchDialogView>("","#a2523b89-dfb3-4acb-b9d5-55de078e7b09 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRFQGroup']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotation_SupplierRFQGroup { get; set; } 
                     
    }
 
    }
  
    

}
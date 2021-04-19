    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.LeasingManagement
{
    //RPS VERSION 1.0.0.0
    public partial class LeasingManagement:Screen
    {
        public LeasingManagement():base()
        {
            this.URL = "generalledger.leasingmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LeasingManagementQueryView  = new LeasingManagementQueryView(this); 
            InstallmentPaymentChildDialogView  = new InstallmentPaymentChildDialogView(this); 
            InstallmentReclassifyChildDialogView  = new InstallmentReclassifyChildDialogView(this); 
            LeasingManagementQueryView.InitializeControls(); 
            InstallmentPaymentChildDialogView.InitializeControls(); 
            InstallmentReclassifyChildDialogView.InitializeControls(); 
           
        }
      
            public LeasingManagementQueryView LeasingManagementQueryView {get; set; } 
            public InstallmentPaymentChildDialogView InstallmentPaymentChildDialogView {get; set; } 
            public InstallmentReclassifyChildDialogView InstallmentReclassifyChildDialogView {get; set; } 
    }
            
    public partial class LeasingManagementQueryView : View
    {
        public LeasingManagementQueryView(LeasingManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Leasing = RPSControlFactory.CreateRPSCollectionComboBox<LeasingManagementQueryView>("259fc0f3-073f-4ba9-ad93-764ac2e90cb2","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<LeasingManagementQueryView>("014a3c4a-db4a-49f0-a9bd-1c30b4a52a85","","",false, this);
 
            FixedAsset = RPSControlFactory.CreateRPSCollectionComboBox<LeasingManagementQueryView>("2ba77478-567b-427a-9c99-06b4537da36f","","",false, this);
 
            InstallmentDateFrom = RPSControlFactory.CreateRPSTextBox<LeasingManagementQueryView>("5e7a333a-ab0a-457a-8b71-76772030364b","","",false, this);
 
            InstallmentDateTo = RPSControlFactory.CreateRPSTextBox<LeasingManagementQueryView>("379d5e8d-7b9c-4211-a19b-398bd858209b","","",false, this);
 
            InstallmentReclassifyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<LeasingManagementQueryView,InstallmentReclassifyChildDialogView>("779f1c38-a943-4157-98b8-1e9f614eb464","","", this,Screen.InstallmentReclassifyChildDialogView);
 
            InstallmentPaymentChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<LeasingManagementQueryView,InstallmentPaymentChildDialogView>("acd2d7de-0f91-425a-bc68-1427f1044cc4","","", this,Screen.InstallmentPaymentChildDialogView);
 
            CollectionInit params_LeasingManagement = new CollectionInit(){IDDescriptor = "8b155a81-5176-49e7-b441-07e06c60d974",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="18465687-ac4f-4b1c-8236-a2647641c442",CSSSelectorGrid="",XPathGrid=""};
            LeasingManagement = RPSControlFactory.RPSCreateCollectionWithGrid<LeasingManagementCollectionEditor<LeasingManagementQueryView,InstallmentPaymentChildDialogView>,LeasingManagementQueryView,InstallmentPaymentChildDialogView>( params_LeasingManagement,this,Screen.InstallmentPaymentChildDialogView);
 

        }
        public IRPSCollectionComboBox<LeasingManagementQueryView> Leasing { get; set; } 
        public IRPSCollectionComboBox<LeasingManagementQueryView> Supplier { get; set; } 
        public IRPSCollectionComboBox<LeasingManagementQueryView> FixedAsset { get; set; } 
        public IRPSTextBox<LeasingManagementQueryView> InstallmentDateFrom { get; set; } 
        public IRPSTextBox<LeasingManagementQueryView> InstallmentDateTo { get; set; } 
        public IRPSButton<LeasingManagementQueryView,InstallmentReclassifyChildDialogView> InstallmentReclassifyChildNavigationCommandButton { get; set; } 
        public IRPSButton<LeasingManagementQueryView,InstallmentPaymentChildDialogView> InstallmentPaymentChildNavigationCommandButton { get; set; } 
        public LeasingManagementCollectionEditor<LeasingManagementQueryView,InstallmentPaymentChildDialogView> LeasingManagement { get; set; } 
        public LeasingManagement Screen { get; set; }
        public LeasingManagementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LeasingManagementCollectionEditor<LeasingManagementQueryView,InstallmentPaymentChildDialogView>:RPSCollectionEditor<LeasingManagementQueryView,InstallmentPaymentChildDialogView> where LeasingManagementQueryView : class, IView where InstallmentPaymentChildDialogView : class, IView
    {
        public  LeasingManagementGridView<LeasingManagementQueryView,InstallmentPaymentChildDialogView> GridView {get;set;}
    }
    public partial class LeasingManagementGridView <LeasingManagementQueryView,InstallmentPaymentChildDialogView> :  RPSGridView<LeasingManagementQueryView,InstallmentPaymentChildDialogView> where LeasingManagementQueryView : class, IView where InstallmentPaymentChildDialogView : class, IView
    {
        public LeasingManagementGridView(LeasingManagementQueryView currentView,InstallmentPaymentChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Leasing_StartDate = RPSControlFactory.CreateRPSGridTextBox<LeasingManagementQueryView>("","#18465687-ac4f-4b1c-8236-a2647641c442 .ag-row[role='row']@ROWINDEX [col-id='cLeasing_StartDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<LeasingManagementQueryView> Leasing_StartDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class InstallmentPaymentChildDialogView : View
    {
        public InstallmentPaymentChildDialogView(LeasingManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InstallmentUntilDate = RPSControlFactory.CreateRPSTextBox<InstallmentPaymentChildDialogView>("1a54ffe5-2826-4aae-8918-2bc5b3964dba","","",false, this);
 
            Fixed = RPSControlFactory.CreateRPSOption<InstallmentPaymentChildDialogView>( "60961201-036b-48af-8e56-3cf32f772d7c","","",this);
 
            FixedDate = RPSControlFactory.CreateRPSTextBox<InstallmentPaymentChildDialogView>("3a3d75bf-48f7-466f-8b5b-1f3ab0850c8e","","",false, this);
 
            Installment = RPSControlFactory.CreateRPSOption<InstallmentPaymentChildDialogView>( "6973e473-67f1-4045-9e15-51abde8caf9c","","",this);
 

        }
        public IRPSTextBox<InstallmentPaymentChildDialogView> InstallmentUntilDate { get; set; } 
        public IRPSOption<InstallmentPaymentChildDialogView> Fixed { get; set; } 
        public IRPSTextBox<InstallmentPaymentChildDialogView> FixedDate { get; set; } 
        public IRPSOption<InstallmentPaymentChildDialogView> Installment { get; set; } 
        public LeasingManagement Screen { get; set; }
        public InstallmentPaymentChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InstallmentReclassifyChildDialogView : View
    {
        public InstallmentReclassifyChildDialogView(LeasingManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ACCYear = RPSControlFactory.CreateRPSComboBox<InstallmentReclassifyChildDialogView>("d46b94cd-cc21-4bf8-8630-c745058bfc53","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InstallmentReclassifyChildDialogView>("8192af1e-9693-44e8-b78b-7a507ff677d2","","",false, this);
 

        }
        public IRPSComboBox<InstallmentReclassifyChildDialogView> ACCYear { get; set; } 
        public IRPSTextBox<InstallmentReclassifyChildDialogView> AccountingDate { get; set; } 
        public LeasingManagement Screen { get; set; }
        public InstallmentReclassifyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
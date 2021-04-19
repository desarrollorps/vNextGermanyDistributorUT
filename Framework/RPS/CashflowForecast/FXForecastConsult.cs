    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXForecastConsult
{
    //RPS VERSION 1.0.0.0
    public partial class FXForecastConsult:Screen
    {
        public FXForecastConsult():base()
        {
            this.URL = "cashflowforecast.fxforecastconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXForecastConsultView  = new FXForecastConsultView(this); 
            FXForecastConsultDetailDialogView  = new FXForecastConsultDetailDialogView(this); 
            FXForecastConsultView.InitializeControls(); 
            FXForecastConsultDetailDialogView.InitializeControls(); 
           
        }
      
            public FXForecastConsultView FXForecastConsultView {get; set; } 
            public FXForecastConsultDetailDialogView FXForecastConsultDetailDialogView {get; set; } 
    }
            
    public partial class FXForecastConsultView : View
    {
        public FXForecastConsultView(FXForecastConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStartDate = RPSControlFactory.CreateRPSTextBox<FXForecastConsultView>("7a0be083-2fc7-4d8e-95bc-b202f4ef18e6","","",false, this);
 
            UIEndDate = RPSControlFactory.CreateRPSTextBox<FXForecastConsultView>("05f44eb0-7ed8-4694-902f-171635a6d511","","",false, this);
 
            UIOptForecast = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "709b1ded-e535-48f3-8961-82accaa06995","","",this);
 
            UIFXForecast = RPSControlFactory.CreateRPSComboBox<FXForecastConsultView>("960b2987-43a9-4fc8-96a3-b941e1fbbd28","","",false, this);
 
            UIOptForecastMulti = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "ec620540-7f45-4070-9682-390c1b69c97e","","",this);
 
            UIFXForecastMulti = RPSControlFactory.CreateRPSComboBox<FXForecastConsultView>("7249cb2c-bf04-49ac-adf8-75f6c8f545da","","",false, this);
 
            UIRoundAmounts = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("2667def7-068a-4a95-9e3f-a6ea451c112b","","",false, this);
 
            UIOnlyWithAmount = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("5affbd29-e93a-4f1d-a768-5999747282e4","","",false, this);
 
            UIOnlyWithBank = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("35d42c5c-f737-48bb-82a7-1ceb6a180291","","",false, this);
 
            UILstBankAccountCompany = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastConsultView>("7a8b64e1-f33f-4537-8492-699a71ac428b","","",false, this);
 
            UILstBank = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastConsultView>("a3dfcb56-8491-4ad0-89f6-8574b8e0046c","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastConsultView>("668df30c-4ee7-484b-86b3-3aa461b41d9b","","",false, this);
 
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastConsultView>("5b499573-e1d2-42dd-892d-58e402005713","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastConsultView>("c88ab142-9502-4572-9418-2adac550fd4d","","",false, this);
 
            UICurrency = RPSControlFactory.CreateRPSComboBox<FXForecastConsultView>("f0884074-9150-49bb-8659-71d3e65f842e","","",false, this);
 
            UIOptYear = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "13e69361-9b74-435a-a392-6556d0a3e9a1","","",this);
 
            UIOptSemestral = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "77edc0e7-eefb-4193-a8f7-7cc6d2fe110d","","",this);
 
            UIOptQuarter = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "f26a87a9-17ff-438a-8462-46bd66ecc391","","",this);
 
            UIOptBiMonth = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "24512f14-7484-4690-8152-63502b4d7497","","",this);
 
            UIOptMonth = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "c6ba8962-d92f-4ef4-a589-b3ae36292b9d","","",this);
 
            UIOptEndMonth = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "be455e74-1180-4067-9876-c0d07b34ed36","","",this);
 
            UIOptMonthDay = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "b87a722b-979d-4425-996c-69ff5d79f83e","","",this);
 
            UIDayOfMonth = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastConsultView>("81698f2c-1755-4bd0-bf64-bbb1cddb39c1","","",false, this);
 
            UIOptWeekly = RPSControlFactory.CreateRPSOption<FXForecastConsultView>( "e10f03a7-6419-4edd-8575-714af31573a8","","",this);
 
            UIInitialAmount = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("138c6435-fc86-4faa-b5cb-5fcbd1b289d6","","",false, this);
 
            UIUseARPCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("ddde5e80-07e3-406a-8e30-7e72828f31ba","","",false, this);
 
            UIUseARPSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("a38f2151-2a5a-42ca-8fd3-b1352f56685a","","",false, this);
 
            UIUseGLMLeasing = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("9db2c91e-59d7-4f3d-9911-e516a8bc408d","","",false, this);
 
            UIUsePROProjects = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("d71b7e90-fc71-49d1-8f06-419be6a9a22b","","",false, this);
 
            UIUsePACSalesPrevisions = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("ff037a95-9b36-44be-b4c7-d88405f89d39","","",false, this);
 
            UIUseMANContractSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("3972a581-f512-4251-ad16-c9f4561fcc7c","","",false, this);
 
            UIUseMANContractCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("65a2314a-e32d-4c00-884b-76a2565aeeff","","",false, this);
 
            UIUsePURProposals = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("29268eac-7a97-48ef-bf1f-37ce4e2f884f","","",false, this);
 
            UIUsePUROrders = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("85d06c73-eae0-4751-ba2a-cf33f110deef","","",false, this);
 
            UIUsePURDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("91ba376a-4627-40f2-abec-85b28c3a6a56","","",false, this);
 
            UIUseSALQuotes = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("88448cb8-6277-41ed-a364-3b989a147048","","",false, this);
 
            UIUseSALOrders = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("78903c77-f66c-4cff-96a1-c87cdde0073f","","",false, this);
 
            UIUseSALDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastConsultView>("f3aa07e1-f2eb-4887-8cec-7ed4f7c97218","","",false, this);
 
            ExecuteFXForecastTreePrecalcButton = RPSControlFactory.CreateRPSButton<FXForecastConsultView>( "759348dd-c34d-4111-b578-caa2a36c29ef","","",this);
 
            DetailsCommandButton = RPSControlFactory.CreateRPSButton<FXForecastConsultView>( "52877c0e-0451-468e-bec8-0f5d18eb30dc","","",this);
 
            CollectionInit params_FXForecastTree = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f97b51f-1f17-4d97-8467-da63b8065225",CSSSelectorGrid="",XPathGrid=""};
            FXForecastTree = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastTreeCollectionEditor<FXForecastConsultView,FXForecastConsultDetailDialogView>,FXForecastConsultView,FXForecastConsultDetailDialogView>( params_FXForecastTree,this,Screen.FXForecastConsultDetailDialogView);
 

        }
        public IRPSTextBox<FXForecastConsultView> UIStartDate { get; set; } 
        public IRPSTextBox<FXForecastConsultView> UIEndDate { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptForecast { get; set; } 
        public IRPSComboBox<FXForecastConsultView> UIFXForecast { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptForecastMulti { get; set; } 
        public IRPSComboBox<FXForecastConsultView> UIFXForecastMulti { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIRoundAmounts { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIOnlyWithAmount { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIOnlyWithBank { get; set; } 
        public IRPSCollectionComboBox<FXForecastConsultView> UILstBankAccountCompany { get; set; } 
        public IRPSCollectionComboBox<FXForecastConsultView> UILstBank { get; set; } 
        public IRPSCollectionComboBox<FXForecastConsultView> UILstCustomer { get; set; } 
        public IRPSCollectionComboBox<FXForecastConsultView> UILstSupplier { get; set; } 
        public IRPSCollectionComboBox<FXForecastConsultView> UILstProject { get; set; } 
        public IRPSComboBox<FXForecastConsultView> UICurrency { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptYear { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptSemestral { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptQuarter { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptBiMonth { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptMonth { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptEndMonth { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptMonthDay { get; set; } 
        public IRPSTextBox<FXForecastConsultView> UIDayOfMonth { get; set; } 
        public IRPSOption<FXForecastConsultView> UIOptWeekly { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIInitialAmount { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseARPCustomer { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseARPSupplier { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseGLMLeasing { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUsePROProjects { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUsePACSalesPrevisions { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseMANContractSupplier { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseMANContractCustomer { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUsePURProposals { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUsePUROrders { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUsePURDeliveryNotes { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseSALQuotes { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseSALOrders { get; set; } 
        public IRPSCheckbox<FXForecastConsultView> UIUseSALDeliveryNotes { get; set; } 
        public IRPSButton<FXForecastConsultView> ExecuteFXForecastTreePrecalcButton { get; set; } 
        public IRPSButton<FXForecastConsultView> DetailsCommandButton { get; set; } 
        public FXForecastTreeCollectionEditor<FXForecastConsultView,FXForecastConsultDetailDialogView> FXForecastTree { get; set; } 
        public FXForecastConsult Screen { get; set; }
        public FXForecastConsultView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXForecastTreeCollectionEditor<FXForecastConsultView,FXForecastConsultDetailDialogView>:RPSCollectionEditor<FXForecastConsultView,FXForecastConsultDetailDialogView> where FXForecastConsultView : class, IView where FXForecastConsultDetailDialogView : class, IView
    {
        public  FXForecastTreeGridView<FXForecastConsultView,FXForecastConsultDetailDialogView> GridView {get;set;}
    }
    public partial class FXForecastTreeGridView <FXForecastConsultView,FXForecastConsultDetailDialogView> :  RPSGridView<FXForecastConsultView,FXForecastConsultDetailDialogView> where FXForecastConsultView : class, IView where FXForecastConsultDetailDialogView : class, IView
    {
        public FXForecastTreeGridView(FXForecastConsultView currentView,FXForecastConsultDetailDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class FXForecastConsultDetailDialogView : View
    {
        public FXForecastConsultDetailDialogView(FXForecastConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIFXIEConcept = RPSControlFactory.CreateRPSComboBox<FXForecastConsultDetailDialogView>("a284208f-6dcc-46c4-8f60-287299b16e79","","",false, this);
 
            DetailDateFrom = RPSControlFactory.CreateRPSTextBox<FXForecastConsultDetailDialogView>("245731fa-5552-4820-8dd6-5dc94d5bf732","","",false, this);
 
            DetailDateTo = RPSControlFactory.CreateRPSTextBox<FXForecastConsultDetailDialogView>("eabd86e2-47e5-4c71-a585-69f99e330ed9","","",false, this);
 
            CollectionInit params_FXForecastDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="05b0d2fa-87d6-47bb-a06e-f1a398f7dd1b",CSSSelectorGrid="",XPathGrid=""};
            FXForecastDetail = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastDetailCollectionEditor<FXForecastConsultDetailDialogView>,FXForecastConsultDetailDialogView>( params_FXForecastDetail,this);
 

        }
        public IRPSComboBox<FXForecastConsultDetailDialogView> UIFXIEConcept { get; set; } 
        public IRPSTextBox<FXForecastConsultDetailDialogView> DetailDateFrom { get; set; } 
        public IRPSTextBox<FXForecastConsultDetailDialogView> DetailDateTo { get; set; } 
        public FXForecastDetailCollectionEditor<FXForecastConsultDetailDialogView> FXForecastDetail { get; set; } 
        public FXForecastConsult Screen { get; set; }
        public FXForecastConsultDetailDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXForecastDetailCollectionEditor<FXForecastConsultDetailDialogView>:RPSCollectionEditor<FXForecastConsultDetailDialogView> where FXForecastConsultDetailDialogView : class, IView
    {
        public  FXForecastDetailGridView<FXForecastConsultDetailDialogView> GridView {get;set;}
    }
    public partial class FXForecastDetailGridView <FXForecastConsultDetailDialogView> :  RPSGridView<FXForecastConsultDetailDialogView> where FXForecastConsultDetailDialogView : class, IView
    {
        public FXForecastDetailGridView(FXForecastConsultDetailDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Company = RPSControlFactory.CreateRPSGridTextBox<FXForecastConsultDetailDialogView>("","#05b0d2fa-87d6-47bb-a06e-f1a398f7dd1b .ag-row[role='row']@ROWINDEX [col-id='cCompany']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FXForecastConsultDetailDialogView>("","#05b0d2fa-87d6-47bb-a06e-f1a398f7dd1b .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FXForecastConsultDetailDialogView> Company { get; set; } 
        public IRPSGridTextBox<FXForecastConsultDetailDialogView> Date { get; set; } 
                     
    }
 
    }
  
    

}
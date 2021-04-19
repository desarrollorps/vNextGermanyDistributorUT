    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXForecastGraphs
{
    //RPS VERSION 1.0.0.0
    public partial class FXForecastGraphs:Screen
    {
        public FXForecastGraphs():base()
        {
            this.URL = "cashflowforecast.fxforecastgraphs";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXForecastGraphsView  = new FXForecastGraphsView(this); 
            FXForecastGraphsView.InitializeControls(); 
           
        }
      
            public FXForecastGraphsView FXForecastGraphsView {get; set; } 
    }
            
    public partial class FXForecastGraphsView : View
    {
        public FXForecastGraphsView(FXForecastGraphs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStartDate = RPSControlFactory.CreateRPSTextBox<FXForecastGraphsView>("d4edf7dd-29f2-4189-a5c4-3efc1fc9f74c","","",true, this);
 
            UIEndDate = RPSControlFactory.CreateRPSTextBox<FXForecastGraphsView>("7d3eaba0-737e-448e-8f52-081ff3718999","","",false, this);
 
            UIOptForecast = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "63d5013b-a712-4298-9d22-a7c0c11bc5d1","","",this);
 
            UIFXForecast = RPSControlFactory.CreateRPSComboBox<FXForecastGraphsView>("4ea63be9-31b5-4127-b6ea-9b1fedccf6c3","","",false, this);
 
            UIOptForecastMulti = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "39673a4f-cba0-407d-a8b3-593fd955b83a","","",this);
 
            UIFXForecastMulti = RPSControlFactory.CreateRPSComboBox<FXForecastGraphsView>("55c024d0-6447-4dcd-8711-ad85d0c38384","","",false, this);
 
            UIOnlyWithBank = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("b8b5f725-6eab-485b-890f-963ef88712fe","","",false, this);
 
            UILstBankAccountCompany = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastGraphsView>("3823c8b5-20ea-4d57-8206-ecd4db852eed","","",false, this);
 
            UILstBank = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastGraphsView>("7a712876-cf35-4428-bce8-6c9f9376054e","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastGraphsView>("a5fe82b7-dea5-487d-b7e6-e32a90aeed34","","",false, this);
 
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastGraphsView>("ad1f2390-241b-465a-a0ab-f182f224de62","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<FXForecastGraphsView>("431be9d0-6761-4c8d-8787-8f034dcec6b5","","",false, this);
 
            UICurrency = RPSControlFactory.CreateRPSComboBox<FXForecastGraphsView>("b1269f79-4cfd-44e6-a8ee-1c245b6c04bb","","",false, this);
 
            UIInitialAmount = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("f8e9165f-fe57-4fa3-8af7-13562fec093f","","",false, this);
 
            UIUseARPCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("7d9441d5-6bd1-4bcc-8ce4-d87f26e39030","","",false, this);
 
            UIUseARPSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("1088db73-689e-472e-902e-5acc9c5a1e07","","",false, this);
 
            UIUseGLMLeasing = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("ba8082d4-77c6-4c33-945e-740549420625","","",false, this);
 
            UIUsePROProjects = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("6de740fd-c559-4d44-902d-32c7631062be","","",false, this);
 
            UIUsePACSalesPrevisions = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("d5b768f6-29bc-49be-ae51-6e2f30bac0d6","","",false, this);
 
            UIUsePURProposals = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("45ae92ae-5d2d-4b2a-b040-80c950f2cc59","","",false, this);
 
            UIUsePUROrders = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("2b92c570-a06b-4f92-a9ff-f33131cdef67","","",false, this);
 
            UIUsePURDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("d337efda-41cd-4a2d-90f0-fe34e60f3d89","","",false, this);
 
            UIUseSALQuotes = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("e4b687d4-bd3b-4eec-aa4e-e9f0d9ca0132","","",false, this);
 
            UIUseSALOrders = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("cc292733-6a91-4b40-889c-2e634328ee6b","","",false, this);
 
            UIUseSALDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("0417e215-7649-4180-bf27-7b163b400f33","","",false, this);
 
            UIUseMANContractCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("b651bb11-74fa-4f35-9cf3-9022434f059b","","",false, this);
 
            UIUseMANContractSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastGraphsView>("be1a94d0-1c17-4b8e-a811-835530d7999f","","",false, this);
 
            LoadChartsCommand = RPSControlFactory.CreateRPSButton<FXForecastGraphsView>( "fe9d91da-5283-4963-95e6-fbaf91214470","","",this);
 
            UIOptMonth = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "fd109746-4806-4ab0-be0d-60eec4da35d8","","",this);
 
            UIOptQuarter = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "797137c3-3664-418c-b9bb-a90f0c8672cb","","",this);
 
            UIOptYear = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "11ffeb84-39f9-4aff-91f7-76377a73994e","","",this);
 
            UIOptMonth1 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "321429b8-f348-48a5-b0d2-a4893e0fa24a","","",this);
 
            UIOptQuarter1 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "27eafefb-64dc-4663-89ff-293bd26dc37c","","",this);
 
            UIOptYear1 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "9f715ace-12a2-44a6-9166-bb24e3341cc9","","",this);
 
            UIOptMonth2 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "c04653f1-72fa-4e72-8160-5d917b96a306","","",this);
 
            UIOptQuarter2 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "ca4459ba-6414-42a3-82bc-50ed63381015","","",this);
 
            UIOptYear2 = RPSControlFactory.CreateRPSOption<FXForecastGraphsView>( "56c04ce7-25f2-465a-87b8-af955ed2bba8","","",this);
 
            IncomeExpenseSources = RPSControlFactory.CreateRPSSection<FXForecastGraphsView>( "","ul li[rpsid='72f80193-1d0d-4bd4-b094-68f8f4a98c46']","",this);
 
            ByBank = RPSControlFactory.CreateRPSSection<FXForecastGraphsView>( "","ul li[rpsid='067a674e-905b-427b-9982-76f9fd7162d7']","",this);
 
            ByDate = RPSControlFactory.CreateRPSSection<FXForecastGraphsView>( "","ul li[rpsid='309ee86e-947d-45d3-b4fe-6aab0099f0e4']","",this);
 
            ByConceptsType = RPSControlFactory.CreateRPSSection<FXForecastGraphsView>( "","ul li[rpsid='53597c5a-c039-4de2-9962-68b565148d0b']","",this);
 
            ByConcepts = RPSControlFactory.CreateRPSSection<FXForecastGraphsView>( "","ul li[rpsid='8ad89dd3-90dc-4d21-a7d2-40126ffdd426']","",this);
 

        }
        public IRPSTextBox<FXForecastGraphsView> UIStartDate { get; set; } 
        public IRPSTextBox<FXForecastGraphsView> UIEndDate { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptForecast { get; set; } 
        public IRPSComboBox<FXForecastGraphsView> UIFXForecast { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptForecastMulti { get; set; } 
        public IRPSComboBox<FXForecastGraphsView> UIFXForecastMulti { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIOnlyWithBank { get; set; } 
        public IRPSCollectionComboBox<FXForecastGraphsView> UILstBankAccountCompany { get; set; } 
        public IRPSCollectionComboBox<FXForecastGraphsView> UILstBank { get; set; } 
        public IRPSCollectionComboBox<FXForecastGraphsView> UILstCustomer { get; set; } 
        public IRPSCollectionComboBox<FXForecastGraphsView> UILstSupplier { get; set; } 
        public IRPSCollectionComboBox<FXForecastGraphsView> UILstProject { get; set; } 
        public IRPSComboBox<FXForecastGraphsView> UICurrency { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIInitialAmount { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseARPCustomer { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseARPSupplier { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseGLMLeasing { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUsePROProjects { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUsePACSalesPrevisions { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUsePURProposals { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUsePUROrders { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUsePURDeliveryNotes { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseSALQuotes { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseSALOrders { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseSALDeliveryNotes { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseMANContractCustomer { get; set; } 
        public IRPSCheckbox<FXForecastGraphsView> UIUseMANContractSupplier { get; set; } 
        public IRPSButton<FXForecastGraphsView> LoadChartsCommand { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptMonth { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptQuarter { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptYear { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptMonth1 { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptQuarter1 { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptYear1 { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptMonth2 { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptQuarter2 { get; set; } 
        public IRPSOption<FXForecastGraphsView> UIOptYear2 { get; set; } 
        public IRPSSection<FXForecastGraphsView> IncomeExpenseSources { get; set; } 
        public IRPSSection<FXForecastGraphsView> ByBank { get; set; } 
        public IRPSSection<FXForecastGraphsView> ByDate { get; set; } 
        public IRPSSection<FXForecastGraphsView> ByConceptsType { get; set; } 
        public IRPSSection<FXForecastGraphsView> ByConcepts { get; set; } 
        public FXForecastGraphs Screen { get; set; }
        public FXForecastGraphsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
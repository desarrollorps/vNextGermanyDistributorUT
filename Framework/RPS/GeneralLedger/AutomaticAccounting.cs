    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AutomaticAccounting
{
    //RPS VERSION 1.0.0.0
    public partial class AutomaticAccounting:Screen
    {
        public AutomaticAccounting():base()
        {
            this.URL = "generalledger.automaticaccounting";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AutomaticAccountingVMQueryView  = new AutomaticAccountingVMQueryView(this); 
            AutomaticAccountingVMEntityView  = new AutomaticAccountingVMEntityView(this); 
            AccDimDetailView  = new AccDimDetailView(this); 
            ConceptExtensionDialogView  = new ConceptExtensionDialogView(this); 
            AutomaticAccountingVMQueryView.InitializeControls(); 
            AutomaticAccountingVMEntityView.InitializeControls(); 
            AccDimDetailView.InitializeControls(); 
            ConceptExtensionDialogView.InitializeControls(); 
           
        }
      
            public AutomaticAccountingVMQueryView AutomaticAccountingVMQueryView {get; set; } 
            public AutomaticAccountingVMEntityView AutomaticAccountingVMEntityView {get; set; } 
            public AccDimDetailView AccDimDetailView {get; set; } 
            public ConceptExtensionDialogView ConceptExtensionDialogView {get; set; } 
    }
            
    public partial class AutomaticAccountingVMQueryView : View
    {
        public AutomaticAccountingVMQueryView(AutomaticAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView>( this,Screen.AutomaticAccountingVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<AutomaticAccountingVMQueryView>( this);
 
            eTypeAcc = RPSControlFactory.CreateRPSEnumComboBox<AutomaticAccountingVMQueryView>("91ce183c-12b2-4f65-b5eb-71cf9508b346","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMQueryView>("9311e823-6557-4f64-bd7c-555994c50eee","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMQueryView>("a49c119b-688e-402f-90e2-57c206601d03","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMQueryView>("9bbfb8b9-6f11-4152-b053-74452ed56cdd","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMQueryView>("4a1e2e19-fbe9-4410-9623-a43c84fee174","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMQueryView>("99d223c8-52a1-499d-a27c-3aba82936905","","",false, this);
 
            CollectionInit params_AutomaticAccountingConsult = new CollectionInit(){IDDescriptor = "292e378a-8c7c-4a78-a3dc-1dd0eb82bbd3",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5838b7e-dcdb-4fa1-be06-dad987ce37ba",CSSSelectorGrid="",XPathGrid=""};
            AutomaticAccountingConsult = RPSControlFactory.RPSCreateCollectionWithGrid<AutomaticAccountingConsultCollectionEditor<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView>,AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView>( params_AutomaticAccountingConsult,this,Screen.AutomaticAccountingVMEntityView);
 

        }
        public IRPSButton<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> NewButton { get; set; } 
        public IRPSButton<AutomaticAccountingVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> eTypeAcc { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> IDVoucherType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> IDThirdAccType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> IDArticleAccType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> IDSite { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMQueryView> IDWareHouse { get; set; } 
        public AutomaticAccountingConsultCollectionEditor<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> AutomaticAccountingConsult { get; set; } 
        public AutomaticAccounting Screen { get; set; }
        public AutomaticAccountingVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AutomaticAccountingConsultCollectionEditor<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView>:RPSCollectionEditor<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> where AutomaticAccountingVMQueryView : class, IView where AutomaticAccountingVMEntityView : class, IView
    {
        public  AutomaticAccountingConsultGridView<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> GridView {get;set;}
    }
    public partial class AutomaticAccountingConsultGridView <AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> :  RPSGridView<AutomaticAccountingVMQueryView,AutomaticAccountingVMEntityView> where AutomaticAccountingVMQueryView : class, IView where AutomaticAccountingVMEntityView : class, IView
    {
        public AutomaticAccountingConsultGridView(AutomaticAccountingVMQueryView currentView,AutomaticAccountingVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AutomaticAccounting_TypeAcc = RPSControlFactory.CreateRPSGridTextBox<AutomaticAccountingVMQueryView>("","#d5838b7e-dcdb-4fa1-be06-dad987ce37ba .ag-row[role='row']@ROWINDEX [col-id='cAutomaticAccounting_TypeAcc']","",false, this.CurrentView);
 
            AutomaticAccounting_Description = RPSControlFactory.CreateRPSGridTextBox<AutomaticAccountingVMQueryView>("","#d5838b7e-dcdb-4fa1-be06-dad987ce37ba .ag-row[role='row']@ROWINDEX [col-id='cAutomaticAccounting_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AutomaticAccountingVMQueryView> AutomaticAccounting_TypeAcc { get; set; } 
        public IRPSGridTextBox<AutomaticAccountingVMQueryView> AutomaticAccounting_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AutomaticAccountingVMEntityView : View
    {
        public AutomaticAccountingVMEntityView(AutomaticAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AutomaticAccountingVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AutomaticAccountingVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AutomaticAccountingVMEntityView,AutomaticAccountingVMQueryView>( this,Screen.AutomaticAccountingVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<AutomaticAccountingVMEntityView,AutomaticAccountingVMQueryView>( this,Screen.AutomaticAccountingVMQueryView);
 
            TypeAcc = RPSControlFactory.CreateRPSEnumComboBox<AutomaticAccountingVMEntityView>("c8cf2e94-0f7f-452e-ba25-4ee3c1e2cd29","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AutomaticAccountingVMEntityView>("3763b1b6-522b-4c0c-847d-52a5e3742252","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("4065c28b-5a5d-46d8-bacc-c876958dd6fe","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("3d048cdc-305c-4ada-81da-1e9d863b68fa","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("839bba59-e325-4ca8-bc6a-fde331054323","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("f57aa090-ada0-4b65-b81d-5090301d0c9e","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("570f4902-4055-4534-9e6f-829a1c1cf05e","","",false, this);
 
            IDIntegrationAccounting = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("c59306ec-6879-4580-a340-abd8d8042c2b","","",false, this);
 
            TypeLine = RPSControlFactory.CreateRPSEnumComboBox<AutomaticAccountingVMEntityView>("5e64eac3-208c-47f6-9d7f-6b778e3bc43f","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("f759c902-e346-4c73-9e3c-f4a341468ca3","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<AutomaticAccountingVMEntityView>("41ba8b51-18f6-4a95-ade5-36a21ed287c8","","",true, this);
 
            ConceptExtension = RPSControlFactory.CreateRPSTextBox<AutomaticAccountingVMEntityView>("44b21e44-c2b5-4520-881e-4ed15722f766","","",false, this);
 
            ConceptExtensionNavigationCommand = RPSControlFactory.CreateRPSButtonToView<AutomaticAccountingVMEntityView,ConceptExtensionDialogView>("798ebb23-d425-4b24-b87e-17736a6cc319","","", this,Screen.ConceptExtensionDialogView);
 
            CollectionInit params_AccDimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ec3fc577-cb02-4ebf-a0bc-02bb24a2d4b0",CSSSelectorGrid="",XPathGrid=""};
            AccDimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<AccDimDetailsCollectionEditor<AutomaticAccountingVMEntityView,AccDimDetailView>,AutomaticAccountingVMEntityView,AccDimDetailView>( params_AccDimDetails,this,Screen.AccDimDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<AutomaticAccountingVMEntityView>( "","ul li[rpsid='83543e68-6f66-4523-b396-543ac942b493']","",this);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<AutomaticAccountingVMEntityView>( "","ul li[rpsid='97d2bbe1-bdc3-459d-9d92-6fdda39077c1']","",this);
 

        }
        public IRPSSaveButton<AutomaticAccountingVMEntityView> SaveButton { get; set; } 
        public IRPSButton<AutomaticAccountingVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<AutomaticAccountingVMEntityView,AutomaticAccountingVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AutomaticAccountingVMEntityView,AutomaticAccountingVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> TypeAcc { get; set; } 
        public IRPSTextBox<AutomaticAccountingVMEntityView> Description { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDIntegrationAccounting { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> TypeLine { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDAccount { get; set; } 
        public IRPSComboBox<AutomaticAccountingVMEntityView> IDAccConcept { get; set; } 
        public IRPSTextBox<AutomaticAccountingVMEntityView> ConceptExtension { get; set; } 
        public IRPSButton<AutomaticAccountingVMEntityView,ConceptExtensionDialogView> ConceptExtensionNavigationCommand { get; set; } 
        public AccDimDetailsCollectionEditor<AutomaticAccountingVMEntityView,AccDimDetailView> AccDimDetails { get; set; } 
        public IRPSSection<AutomaticAccountingVMEntityView> SectionGeneral { get; set; } 
        public IRPSSection<AutomaticAccountingVMEntityView> SectionDetails { get; set; } 
        public AutomaticAccounting Screen { get; set; }
        public AutomaticAccountingVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccDimDetailsCollectionEditor<AutomaticAccountingVMEntityView,AccDimDetailView>:RPSCollectionEditor<AutomaticAccountingVMEntityView,AccDimDetailView> where AutomaticAccountingVMEntityView : class, IView where AccDimDetailView : class, IView
    {
        public  AccDimDetailsGridView<AutomaticAccountingVMEntityView,AccDimDetailView> GridView {get;set;}
    }
    public partial class AccDimDetailsGridView <AutomaticAccountingVMEntityView,AccDimDetailView> :  RPSGridView<AutomaticAccountingVMEntityView,AccDimDetailView> where AutomaticAccountingVMEntityView : class, IView where AccDimDetailView : class, IView
    {
        public AccDimDetailsGridView(AutomaticAccountingVMEntityView currentView,AccDimDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AutomaticAccountingVMEntityView>("","#ec3fc577-cb02-4ebf-a0bc-02bb24a2d4b0 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AutomaticAccountingVMEntityView>("","#ec3fc577-cb02-4ebf-a0bc-02bb24a2d4b0 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticAccountingVMEntityView>("","#ec3fc577-cb02-4ebf-a0bc-02bb24a2d4b0 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AutomaticAccountingVMEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<AutomaticAccountingVMEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AutomaticAccountingVMEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccDimDetailView : View
    {
        public AccDimDetailView(AutomaticAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccDimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccDimDetailView,AutomaticAccountingVMEntityView>( this,Screen.AutomaticAccountingVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccDimDetailView,AutomaticAccountingVMEntityView>( this,Screen.AutomaticAccountingVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccDimDetailView,AutomaticAccountingVMEntityView>( this,Screen.AutomaticAccountingVMEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<AccDimDetailView>("48348c3f-0be5-4292-be1b-48cb2037a909","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<AccDimDetailView>("cae808d0-a1c4-4f07-9c26-0b35a035dc1e","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<AccDimDetailView>("fc6aefa7-9f83-44c2-9100-0cf461a06fc3","","",true, this);
 

        }
        public IRPSButton<AccDimDetailView> DeleteButton { get; set; } 
        public IRPSButton<AccDimDetailView,AutomaticAccountingVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccDimDetailView,AutomaticAccountingVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AccDimDetailView,AutomaticAccountingVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AccDimDetailView> IDDimension { get; set; } 
        public IRPSComboBox<AccDimDetailView> IDDimValue { get; set; } 
        public IRPSTextBox<AccDimDetailView> Percentage { get; set; } 
        public AutomaticAccounting Screen { get; set; }
        public AccDimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ConceptExtensionDialogView : View
    {
        public ConceptExtensionDialogView(AutomaticAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("2222f06e-66d6-4f46-9c5c-368ce5b9276c","","",false, this);
 
            Property = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("bb644734-0944-444e-96d9-1c1baab010bc","","",false, this);
 
            AddProperty = RPSControlFactory.CreateRPSButton<ConceptExtensionDialogView>( "fd23aec7-8218-4501-8be4-9d0ee5ae23bd","","",this);
 
            ConceptExtension = RPSControlFactory.CreateRPSTextBox<ConceptExtensionDialogView>("b21a2d37-1da4-44d2-919d-0bbe008cc592","","",false, this);
 

        }
        public IRPSComboBox<ConceptExtensionDialogView> Entity { get; set; } 
        public IRPSComboBox<ConceptExtensionDialogView> Property { get; set; } 
        public IRPSButton<ConceptExtensionDialogView> AddProperty { get; set; } 
        public IRPSTextBox<ConceptExtensionDialogView> ConceptExtension { get; set; } 
        public AutomaticAccounting Screen { get; set; }
        public ConceptExtensionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
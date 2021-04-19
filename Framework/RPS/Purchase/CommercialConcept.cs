    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.CommercialConcept
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConcept:Screen
    {
        public CommercialConcept():base()
        {
            this.URL = "purchase.commercialconcept";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConceptCollectionView  = new CommercialConceptCollectionView(this); 
            CommercialConceptEntityView  = new CommercialConceptEntityView(this); 
            CommercialConceptCollectionView.InitializeControls(); 
            CommercialConceptEntityView.InitializeControls(); 
           
        }
      
            public CommercialConceptCollectionView CommercialConceptCollectionView {get; set; } 
            public CommercialConceptEntityView CommercialConceptEntityView {get; set; } 
    }
            
    public partial class CommercialConceptCollectionView : View
    {
        public CommercialConceptCollectionView(CommercialConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConceptCollectionView,CommercialConceptEntityView>( this,Screen.CommercialConceptEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f208d118-eb08-43df-a25d-6e2196eb396a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialConceptCollectionView,CommercialConceptEntityView>( params_MainConsult,this,Screen.CommercialConceptEntityView);
 

        }
        public IRPSButton<CommercialConceptCollectionView,CommercialConceptEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialConceptCollectionView,CommercialConceptEntityView> MainConsult { get; set; } 
        public CommercialConcept Screen { get; set; }
        public CommercialConceptCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialConceptEntityView : View
    {
        public CommercialConceptEntityView(CommercialConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConceptEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConceptEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConceptEntityView,CommercialConceptCollectionView>( this,Screen.CommercialConceptCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConceptEntityView,CommercialConceptCollectionView>( this,Screen.CommercialConceptCollectionView);
 
            CodCommercialConcept = RPSControlFactory.CreateRPSTextBox<CommercialConceptEntityView>("cf2726a2-28f3-4409-8a49-e48c2eb07a35","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConceptEntityView>("887c3732-bca1-4e74-840c-c5a4da7533c9","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptEntityView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptEntityView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptEntityView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<CommercialConceptEntityView>( "f10717f3-4181-4900-b8e8-b7693f07e13e","","",this);
 
            CollectionInit params_CommercialConditionCassationApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b192d62d-50e1-4e3c-8993-c1796cd9c52a",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationAppliedsCollectionEditor<CommercialConceptEntityView>,CommercialConceptEntityView>( params_CommercialConditionCassationApplieds,this);
 
            CollectionInit params_CommercialConditionCassationCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e9745c87-c013-40cb-a612-ae2f9a55d800",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationCassationsCollectionEditor<CommercialConceptEntityView>,CommercialConceptEntityView>( params_CommercialConditionCassationCassations,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CommercialConceptEntityView>( "","ul li[rpsid='be4da737-86a4-4307-bd94-913e83e808cd']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<CommercialConceptEntityView>( "","ul li[rpsid='a51a1649-b403-4622-bb1e-e330873a7b5d']","",this);
 

        }
        public IRPSSaveButton<CommercialConceptEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConceptEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConceptEntityView,CommercialConceptCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConceptEntityView,CommercialConceptCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialConceptEntityView> CodCommercialConcept { get; set; } 
        public IRPSTextBox<CommercialConceptEntityView> Description { get; set; } 
        public IRPSTextBox<CommercialConceptEntityView> UIApply { get; set; } 
        public IRPSTextBox<CommercialConceptEntityView> UILiquidate { get; set; } 
        public IRPSTextBox<CommercialConceptEntityView> UIDifference { get; set; } 
        public IRPSButton<CommercialConceptEntityView> CassationCommandButton { get; set; } 
        public CommercialConditionCassationAppliedsCollectionEditor<CommercialConceptEntityView> CommercialConditionCassationApplieds { get; set; } 
        public CommercialConditionCassationCassationsCollectionEditor<CommercialConceptEntityView> CommercialConditionCassationCassations { get; set; } 
        public IRPSSection<CommercialConceptEntityView> GeneralData { get; set; } 
        public IRPSSection<CommercialConceptEntityView> SectionCassation { get; set; } 
        public CommercialConcept Screen { get; set; }
        public CommercialConceptEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionCassationAppliedsCollectionEditor<CommercialConceptEntityView>:RPSCollectionEditor<CommercialConceptEntityView> where CommercialConceptEntityView : class, IView
    {
        public  CommercialConditionCassationAppliedsGridView<CommercialConceptEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationAppliedsGridView <CommercialConceptEntityView> :  RPSGridView<CommercialConceptEntityView> where CommercialConceptEntityView : class, IView
    {
        public CommercialConditionCassationAppliedsGridView(CommercialConceptEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDnvoice = RPSControlFactory.CreateRPSGridComboBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cUIIDnvoice']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptEntityView>("","#b192d62d-50e1-4e3c-8993-c1796cd9c52a .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConceptEntityView> UIIDnvoice { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConceptEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConceptEntityView> Processed { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CommercialConditionCassationCassationsCollectionEditor<CommercialConceptEntityView>:RPSCollectionEditor<CommercialConceptEntityView> where CommercialConceptEntityView : class, IView
    {
        public  CommercialConditionCassationCassationsGridView<CommercialConceptEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationCassationsGridView <CommercialConceptEntityView> :  RPSGridView<CommercialConceptEntityView> where CommercialConceptEntityView : class, IView
    {
        public CommercialConditionCassationCassationsGridView(CommercialConceptEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDnvoice = RPSControlFactory.CreateRPSGridComboBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cUIIDnvoice']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConceptEntityView>("","#e9745c87-c013-40cb-a612-ae2f9a55d800 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConceptEntityView> UIIDnvoice { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConceptEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConceptEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConceptEntityView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
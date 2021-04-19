    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialConceptSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConceptSL:Screen
    {
        public CommercialConceptSL():base()
        {
            this.URL = "sales.commercialconceptsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConceptSLCollectionView  = new CommercialConceptSLCollectionView(this); 
            CommercialConceptSLEntityView  = new CommercialConceptSLEntityView(this); 
            CommercialConceptSLCollectionView.InitializeControls(); 
            CommercialConceptSLEntityView.InitializeControls(); 
           
        }
      
            public CommercialConceptSLCollectionView CommercialConceptSLCollectionView {get; set; } 
            public CommercialConceptSLEntityView CommercialConceptSLEntityView {get; set; } 
    }
            
    public partial class CommercialConceptSLCollectionView : View
    {
        public CommercialConceptSLCollectionView(CommercialConceptSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConceptSLCollectionView,CommercialConceptSLEntityView>( this,Screen.CommercialConceptSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "70396fce-25cc-4192-a08c-0c6bb7e04ea2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialConceptSLCollectionView,CommercialConceptSLEntityView>( params_MainConsult,this,Screen.CommercialConceptSLEntityView);
 

        }
        public IRPSButton<CommercialConceptSLCollectionView,CommercialConceptSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialConceptSLCollectionView,CommercialConceptSLEntityView> MainConsult { get; set; } 
        public CommercialConceptSL Screen { get; set; }
        public CommercialConceptSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialConceptSLEntityView : View
    {
        public CommercialConceptSLEntityView(CommercialConceptSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConceptSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConceptSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConceptSLEntityView,CommercialConceptSLCollectionView>( this,Screen.CommercialConceptSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConceptSLEntityView,CommercialConceptSLCollectionView>( this,Screen.CommercialConceptSLCollectionView);
 
            CodCommercialConcept = RPSControlFactory.CreateRPSTextBox<CommercialConceptSLEntityView>("dd515a96-3e5f-4dc4-956c-37e1cd379921","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConceptSLEntityView>("53e662a3-0fba-4ad8-86c0-cf7b5b4f9895","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptSLEntityView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptSLEntityView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConceptSLEntityView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<CommercialConceptSLEntityView>( "cfa7f913-6adc-49a6-af87-31258e59c8c5","","",this);
 
            CollectionInit params_CommercialConditionCassationSLApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConceptSLEntityView>,CommercialConceptSLEntityView>( params_CommercialConditionCassationSLApplieds,this);
 
            CollectionInit params_CommercialConditionCassationSLCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="defa2a61-2c1f-4b91-86c0-029bb791bf31",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLCassationsCollectionEditor<CommercialConceptSLEntityView>,CommercialConceptSLEntityView>( params_CommercialConditionCassationSLCassations,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CommercialConceptSLEntityView>( "","ul li[rpsid='1ca65055-bf53-48ae-b2cb-f2a71bf8e2f1']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<CommercialConceptSLEntityView>( "","ul li[rpsid='a51a1649-b403-4622-bb1e-e330873a7b5d']","",this);
 

        }
        public IRPSSaveButton<CommercialConceptSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConceptSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConceptSLEntityView,CommercialConceptSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConceptSLEntityView,CommercialConceptSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialConceptSLEntityView> CodCommercialConcept { get; set; } 
        public IRPSTextBox<CommercialConceptSLEntityView> Description { get; set; } 
        public IRPSTextBox<CommercialConceptSLEntityView> UIApply { get; set; } 
        public IRPSTextBox<CommercialConceptSLEntityView> UILiquidate { get; set; } 
        public IRPSTextBox<CommercialConceptSLEntityView> UIDifference { get; set; } 
        public IRPSButton<CommercialConceptSLEntityView> CassationCommandButton { get; set; } 
        public CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConceptSLEntityView> CommercialConditionCassationSLApplieds { get; set; } 
        public CommercialConditionCassationSLCassationsCollectionEditor<CommercialConceptSLEntityView> CommercialConditionCassationSLCassations { get; set; } 
        public IRPSSection<CommercialConceptSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CommercialConceptSLEntityView> SectionCassation { get; set; } 
        public CommercialConceptSL Screen { get; set; }
        public CommercialConceptSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConceptSLEntityView>:RPSCollectionEditor<CommercialConceptSLEntityView> where CommercialConceptSLEntityView : class, IView
    {
        public  CommercialConditionCassationSLAppliedsGridView<CommercialConceptSLEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLAppliedsGridView <CommercialConceptSLEntityView> :  RPSGridView<CommercialConceptSLEntityView> where CommercialConceptSLEntityView : class, IView
    {
        public CommercialConditionCassationSLAppliedsGridView(CommercialConceptSLEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptSLEntityView>("","#3a5ded6f-e3c0-43c4-8f1d-2248b57b78bb .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConceptSLEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConceptSLEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConceptSLEntityView> Processed { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CommercialConditionCassationSLCassationsCollectionEditor<CommercialConceptSLEntityView>:RPSCollectionEditor<CommercialConceptSLEntityView> where CommercialConceptSLEntityView : class, IView
    {
        public  CommercialConditionCassationSLCassationsGridView<CommercialConceptSLEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLCassationsGridView <CommercialConceptSLEntityView> :  RPSGridView<CommercialConceptSLEntityView> where CommercialConceptSLEntityView : class, IView
    {
        public CommercialConditionCassationSLCassationsGridView(CommercialConceptSLEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConceptSLEntityView>("","#defa2a61-2c1f-4b91-86c0-029bb791bf31 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConceptSLEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConceptSLEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConceptSLEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConceptSLEntityView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
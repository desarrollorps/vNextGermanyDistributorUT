    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierCommercialCondition
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierCommercialCondition:Screen
    {
        public SupplierCommercialCondition():base()
        {
            this.URL = "purchase.suppliercommercialcondition";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCommercialConditionVMQueryView  = new SupplierCommercialConditionVMQueryView(this); 
            SupplierCommercialConditionVMEntityView  = new SupplierCommercialConditionVMEntityView(this); 
            SupplierCommercialConditionVMQueryView.InitializeControls(); 
            SupplierCommercialConditionVMEntityView.InitializeControls(); 
           
        }
      
            public SupplierCommercialConditionVMQueryView SupplierCommercialConditionVMQueryView {get; set; } 
            public SupplierCommercialConditionVMEntityView SupplierCommercialConditionVMEntityView {get; set; } 
    }
            
    public partial class SupplierCommercialConditionVMQueryView : View
    {
        public SupplierCommercialConditionVMQueryView(SupplierCommercialCondition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView>( this,Screen.SupplierCommercialConditionVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SupplierCommercialConditionVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<SupplierCommercialConditionVMQueryView>("0e2d1b59-1a3e-402c-8335-dcbc581a4fed","","",false, this);
 
            UIDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMQueryView>("39e6790a-9f1f-4a23-999c-f0e33a19c210","","",false, this);
 
            UIProducLine = RPSControlFactory.CreateRPSCheckBox<SupplierCommercialConditionVMQueryView>("f0eb576e-e559-4b10-bc9f-c62a1ca0cf9e","","",false, this);
 
            UIlsProductLine = RPSControlFactory.CreateRPSCollectionComboBox<SupplierCommercialConditionVMQueryView>("152e8fd7-ee4a-4582-a9e2-314fd17942a9","","",false, this);
 
            UIFamily = RPSControlFactory.CreateRPSCheckBox<SupplierCommercialConditionVMQueryView>("0bdab847-22b9-49b6-ac3e-d77349e6581c","","",false, this);
 
            UIlsProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierCommercialConditionVMQueryView>("0037285f-5427-416d-b4e1-6820ab1fc4ef","","",false, this);
 
            UISubFamily = RPSControlFactory.CreateRPSCheckBox<SupplierCommercialConditionVMQueryView>("cb759f27-949b-44be-81d9-d7a08fabd2f3","","",false, this);
 
            UIlsProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierCommercialConditionVMQueryView>("f00296cb-945d-49e0-90fc-19cff0389689","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCheckBox<SupplierCommercialConditionVMQueryView>("5380daf8-7ff6-4ff1-a253-1bed2a869918","","",false, this);
 
            UIsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<SupplierCommercialConditionVMQueryView>("5df11bee-e15c-49b7-99aa-dc53731834b6","","",false, this);
 
            UIAllArticle = RPSControlFactory.CreateRPSCheckBox<SupplierCommercialConditionVMQueryView>("66890186-1d34-455c-8c03-795e155cff12","","",false, this);
 
            CollectionInit params_SupplierCommercialConditionConsult = new CollectionInit(){IDDescriptor = "cc5e520e-ed20-4c10-9892-8e49c361fb39",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e797fde8-d23c-4c98-8b13-eca9ccf0350d",CSSSelectorGrid="",XPathGrid=""};
            SupplierCommercialConditionConsult = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierCommercialConditionConsultCollectionEditor<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView>,SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView>( params_SupplierCommercialConditionConsult,this,Screen.SupplierCommercialConditionVMEntityView);
 

        }
        public IRPSButton<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> NewButton { get; set; } 
        public IRPSButton<SupplierCommercialConditionVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMQueryView> UIActiveDate { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMQueryView> UIDSupplier { get; set; } 
        public IRPSCheckbox<SupplierCommercialConditionVMQueryView> UIProducLine { get; set; } 
        public IRPSCollectionComboBox<SupplierCommercialConditionVMQueryView> UIlsProductLine { get; set; } 
        public IRPSCheckbox<SupplierCommercialConditionVMQueryView> UIFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierCommercialConditionVMQueryView> UIlsProductFamily { get; set; } 
        public IRPSCheckbox<SupplierCommercialConditionVMQueryView> UISubFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierCommercialConditionVMQueryView> UIlsProductSubFamily { get; set; } 
        public IRPSCheckbox<SupplierCommercialConditionVMQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<SupplierCommercialConditionVMQueryView> UIsIDArticle { get; set; } 
        public IRPSCheckbox<SupplierCommercialConditionVMQueryView> UIAllArticle { get; set; } 
        public SupplierCommercialConditionConsultCollectionEditor<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> SupplierCommercialConditionConsult { get; set; } 
        public SupplierCommercialCondition Screen { get; set; }
        public SupplierCommercialConditionVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierCommercialConditionConsultCollectionEditor<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView>:RPSCollectionEditor<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMQueryView : class, IView where SupplierCommercialConditionVMEntityView : class, IView
    {
        public  SupplierCommercialConditionConsultGridView<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> GridView {get;set;}
    }
    public partial class SupplierCommercialConditionConsultGridView <SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> :  RPSGridView<SupplierCommercialConditionVMQueryView,SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMQueryView : class, IView where SupplierCommercialConditionVMEntityView : class, IView
    {
        public SupplierCommercialConditionConsultGridView(SupplierCommercialConditionVMQueryView currentView,SupplierCommercialConditionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierCommercialCondition_Description = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMQueryView>("","#e797fde8-d23c-4c98-8b13-eca9ccf0350d .ag-row[role='row']@ROWINDEX [col-id='cSupplierCommercialCondition_Description']","",false, this.CurrentView);
 
            SupplierCommercialCondition_DateFrom = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMQueryView>("","#e797fde8-d23c-4c98-8b13-eca9ccf0350d .ag-row[role='row']@ROWINDEX [col-id='cSupplierCommercialCondition_DateFrom']","",false, this.CurrentView);
 
            SupplierCommercialCondition_DateTo = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMQueryView>("","#e797fde8-d23c-4c98-8b13-eca9ccf0350d .ag-row[role='row']@ROWINDEX [col-id='cSupplierCommercialCondition_DateTo']","",false, this.CurrentView);
 
            SupplierCommercialCondition_ItemType = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMQueryView>("","#e797fde8-d23c-4c98-8b13-eca9ccf0350d .ag-row[role='row']@ROWINDEX [col-id='cSupplierCommercialCondition_ItemType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierCommercialConditionVMQueryView> SupplierCommercialCondition_Description { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMQueryView> SupplierCommercialCondition_DateFrom { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMQueryView> SupplierCommercialCondition_DateTo { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMQueryView> SupplierCommercialCondition_ItemType { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierCommercialConditionVMEntityView : View
    {
        public SupplierCommercialConditionVMEntityView(SupplierCommercialCondition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierCommercialConditionVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierCommercialConditionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierCommercialConditionVMEntityView,SupplierCommercialConditionVMQueryView>( this,Screen.SupplierCommercialConditionVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierCommercialConditionVMEntityView,SupplierCommercialConditionVMQueryView>( this,Screen.SupplierCommercialConditionVMQueryView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("90d45a7f-50e4-4b07-9a15-4358da23d7b8","","",true, this);
 
            IDCommercialConditionType = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("1b725bd0-cfe9-4300-9c57-f1324ba8c57c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierCommercialConditionVMEntityView>("7388a4ee-1f60-49a7-a80d-bcb00393f942","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SupplierCommercialConditionVMEntityView>("08df66cb-af65-4bf8-9762-903fcc1d97ca","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SupplierCommercialConditionVMEntityView>("003395a8-f2cd-4eb2-959a-4ca4304bb39f","","",true, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<SupplierCommercialConditionVMEntityView>("f86c417d-f919-4711-b9c5-e7b9ca9754dd","","",true, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("e0004e3a-a442-4f76-992d-8fd4a739dbca","","",false, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("1ceac830-bbf1-4202-9ace-10c142ae2746","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("0f7c5401-b724-4762-8a11-d67db40163b3","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<SupplierCommercialConditionVMEntityView>("f4b8288b-a17d-45c5-a328-268c9bba99fc","","",false, this);
 
            ConditionValue = RPSControlFactory.CreateRPSFormattedTextBox<SupplierCommercialConditionVMEntityView>("c533494b-3846-4ef0-ad97-a608c6fbfcc5","","",true, this);
 
            ConditionValueAmount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierCommercialConditionVMEntityView>("39424e32-157a-48e2-932a-abfce5e81e32","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<SupplierCommercialConditionVMEntityView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<SupplierCommercialConditionVMEntityView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<SupplierCommercialConditionVMEntityView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<SupplierCommercialConditionVMEntityView>( "f142c837-599e-4780-b07d-bd72cd0418c8","","",this);
 
            CollectionInit params_CommercialConditionCassationSLApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="87e50638-cefc-4b6b-90e1-ddd9a88606e0",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLAppliedsCollectionEditor<SupplierCommercialConditionVMEntityView>,SupplierCommercialConditionVMEntityView>( params_CommercialConditionCassationSLApplieds,this);
 
            CollectionInit params_CommercialConditionCassationSLCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="99c1f90c-1d3a-48f6-89e9-12268cbf64d8",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLCassationsCollectionEditor<SupplierCommercialConditionVMEntityView>,SupplierCommercialConditionVMEntityView>( params_CommercialConditionCassationSLCassations,this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<SupplierCommercialConditionVMEntityView>( "","ul li[rpsid='7b3382ad-9532-49ba-bf17-41239fade5bb']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<SupplierCommercialConditionVMEntityView>( "","ul li[rpsid='a51a1649-b403-4622-bb1e-e330873a7b5d']","",this);
 

        }
        public IRPSSaveButton<SupplierCommercialConditionVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierCommercialConditionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierCommercialConditionVMEntityView,SupplierCommercialConditionVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierCommercialConditionVMEntityView,SupplierCommercialConditionVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDCommercialConditionType { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDItemArticle { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDItemProductLine { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<SupplierCommercialConditionVMEntityView> IDItemProductSubFamily { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> ConditionValue { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> ConditionValueAmount { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> UIApply { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> UILiquidate { get; set; } 
        public IRPSTextBox<SupplierCommercialConditionVMEntityView> UIDifference { get; set; } 
        public IRPSButton<SupplierCommercialConditionVMEntityView> CassationCommandButton { get; set; } 
        public CommercialConditionCassationSLAppliedsCollectionEditor<SupplierCommercialConditionVMEntityView> CommercialConditionCassationSLApplieds { get; set; } 
        public CommercialConditionCassationSLCassationsCollectionEditor<SupplierCommercialConditionVMEntityView> CommercialConditionCassationSLCassations { get; set; } 
        public IRPSSection<SupplierCommercialConditionVMEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<SupplierCommercialConditionVMEntityView> SectionCassation { get; set; } 
        public SupplierCommercialCondition Screen { get; set; }
        public SupplierCommercialConditionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionCassationSLAppliedsCollectionEditor<SupplierCommercialConditionVMEntityView>:RPSCollectionEditor<SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMEntityView : class, IView
    {
        public  CommercialConditionCassationSLAppliedsGridView<SupplierCommercialConditionVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLAppliedsGridView <SupplierCommercialConditionVMEntityView> :  RPSGridView<SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMEntityView : class, IView
    {
        public CommercialConditionCassationSLAppliedsGridView(SupplierCommercialConditionVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDnvoice = RPSControlFactory.CreateRPSGridComboBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cUIIDnvoice']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMEntityView>("","#87e50638-cefc-4b6b-90e1-ddd9a88606e0 .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierCommercialConditionVMEntityView> UIIDnvoice { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<SupplierCommercialConditionVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<SupplierCommercialConditionVMEntityView> Processed { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CommercialConditionCassationSLCassationsCollectionEditor<SupplierCommercialConditionVMEntityView>:RPSCollectionEditor<SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMEntityView : class, IView
    {
        public  CommercialConditionCassationSLCassationsGridView<SupplierCommercialConditionVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLCassationsGridView <SupplierCommercialConditionVMEntityView> :  RPSGridView<SupplierCommercialConditionVMEntityView> where SupplierCommercialConditionVMEntityView : class, IView
    {
        public CommercialConditionCassationSLCassationsGridView(SupplierCommercialConditionVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDnvoice = RPSControlFactory.CreateRPSGridComboBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cUIIDnvoice']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<SupplierCommercialConditionVMEntityView>("","#99c1f90c-1d3a-48f6-89e9-12268cbf64d8 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierCommercialConditionVMEntityView> UIIDnvoice { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<SupplierCommercialConditionVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<SupplierCommercialConditionVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<SupplierCommercialConditionVMEntityView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
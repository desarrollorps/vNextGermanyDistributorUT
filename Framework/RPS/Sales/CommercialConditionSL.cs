    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialConditionSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConditionSL:Screen
    {
        public CommercialConditionSL():base()
        {
            this.URL = "sales.commercialconditionsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConditionSLVMQueryView  = new CommercialConditionSLVMQueryView(this); 
            CommercialConditionSLVMEntityView  = new CommercialConditionSLVMEntityView(this); 
            CommercialConditionSLVMQueryView.InitializeControls(); 
            CommercialConditionSLVMEntityView.InitializeControls(); 
           
        }
      
            public CommercialConditionSLVMQueryView CommercialConditionSLVMQueryView {get; set; } 
            public CommercialConditionSLVMEntityView CommercialConditionSLVMEntityView {get; set; } 
    }
            
    public partial class CommercialConditionSLVMQueryView : View
    {
        public CommercialConditionSLVMQueryView(CommercialConditionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView>( this,Screen.CommercialConditionSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommercialConditionSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<CommercialConditionSLVMQueryView>("405e9dfd-3518-4f50-b6ad-2d30bf2d1181","","",false, this);
 
            UIAllArticle = RPSControlFactory.CreateRPSCheckBox<CommercialConditionSLVMQueryView>("7980294e-e211-4c75-8b87-e5a39ee08890","","",false, this);
 
            UIProducLine = RPSControlFactory.CreateRPSCheckBox<CommercialConditionSLVMQueryView>("e092ade4-5e96-4bcc-b5a3-689244c5ff30","","",false, this);
 
            UIlsProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionSLVMQueryView>("bca32498-a2fd-4fcf-b680-ca99747c2532","","",false, this);
 
            UIFamily = RPSControlFactory.CreateRPSCheckBox<CommercialConditionSLVMQueryView>("dc254a58-9352-486b-b354-73fef2051225","","",false, this);
 
            UIlsProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionSLVMQueryView>("d935214f-cca8-4168-ab21-28139ef91e20","","",false, this);
 
            UISubFamily = RPSControlFactory.CreateRPSCheckBox<CommercialConditionSLVMQueryView>("2a48f567-83a7-43f9-88d7-b586bb56ebd4","","",false, this);
 
            UIlsProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionSLVMQueryView>("d06a2642-ec9d-4355-b5ff-511d22056df9","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCheckBox<CommercialConditionSLVMQueryView>("006198bb-c366-4681-80c5-f996ff087588","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionSLVMQueryView>("0adcfc98-9228-4bf1-90b9-5d00ad29f47b","","",false, this);
 
            CollectionInit params_CommercialConditionSLConsult = new CollectionInit(){IDDescriptor = "51856474-d2cc-4eb8-9660-1352659f6957",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4a2bde60-457b-4905-baaa-a784fe7fe9ab",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionSLConsultCollectionEditor<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView>,CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView>( params_CommercialConditionSLConsult,this,Screen.CommercialConditionSLVMEntityView);
 

        }
        public IRPSButton<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommercialConditionSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSCheckbox<CommercialConditionSLVMQueryView> UIAllArticle { get; set; } 
        public IRPSCheckbox<CommercialConditionSLVMQueryView> UIProducLine { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionSLVMQueryView> UIlsProductLine { get; set; } 
        public IRPSCheckbox<CommercialConditionSLVMQueryView> UIFamily { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionSLVMQueryView> UIlsProductFamily { get; set; } 
        public IRPSCheckbox<CommercialConditionSLVMQueryView> UISubFamily { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionSLVMQueryView> UIlsProductSubFamily { get; set; } 
        public IRPSCheckbox<CommercialConditionSLVMQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionSLVMQueryView> UIlsIDArticle { get; set; } 
        public CommercialConditionSLConsultCollectionEditor<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> CommercialConditionSLConsult { get; set; } 
        public CommercialConditionSL Screen { get; set; }
        public CommercialConditionSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionSLConsultCollectionEditor<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView>:RPSCollectionEditor<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> where CommercialConditionSLVMQueryView : class, IView where CommercialConditionSLVMEntityView : class, IView
    {
        public  CommercialConditionSLConsultGridView<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionSLConsultGridView <CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> :  RPSGridView<CommercialConditionSLVMQueryView,CommercialConditionSLVMEntityView> where CommercialConditionSLVMQueryView : class, IView where CommercialConditionSLVMEntityView : class, IView
    {
        public CommercialConditionSLConsultGridView(CommercialConditionSLVMQueryView currentView,CommercialConditionSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommercialConditionSL_Description = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMQueryView>("","#4a2bde60-457b-4905-baaa-a784fe7fe9ab .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionSL_Description']","",false, this.CurrentView);
 
            CommercialConditionSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMQueryView>("","#4a2bde60-457b-4905-baaa-a784fe7fe9ab .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionSL_DateFrom']","",false, this.CurrentView);
 
            CommercialConditionSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMQueryView>("","#4a2bde60-457b-4905-baaa-a784fe7fe9ab .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionSL_DateTo']","",false, this.CurrentView);
 
            CommercialConditionSL_ItemType = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMQueryView>("","#4a2bde60-457b-4905-baaa-a784fe7fe9ab .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionSL_ItemType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommercialConditionSLVMQueryView> CommercialConditionSL_Description { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMQueryView> CommercialConditionSL_DateFrom { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMQueryView> CommercialConditionSL_DateTo { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMQueryView> CommercialConditionSL_ItemType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommercialConditionSLVMEntityView : View
    {
        public CommercialConditionSLVMEntityView(CommercialConditionSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConditionSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConditionSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConditionSLVMEntityView,CommercialConditionSLVMQueryView>( this,Screen.CommercialConditionSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConditionSLVMEntityView,CommercialConditionSLVMQueryView>( this,Screen.CommercialConditionSLVMQueryView);
 
            IDCommercialConditionType = RPSControlFactory.CreateRPSComboBox<CommercialConditionSLVMEntityView>("6d9ac316-e181-4696-8766-0f9fe2b9431b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConditionSLVMEntityView>("b711c779-a4b6-42cd-9c1b-bb80465d056c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommercialConditionSLVMEntityView>("baa8d9bc-a8e1-4a96-8a09-a48a131191b7","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommercialConditionSLVMEntityView>("8f8b70aa-1d49-49a6-ab0e-413b8a38e4e0","","",true, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionSLVMEntityView>("41289422-583a-40ec-835b-ec62bbbc27ff","","",true, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<CommercialConditionSLVMEntityView>("f9845cd9-a62b-4a32-bece-755086d58506","","",false, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<CommercialConditionSLVMEntityView>("6e4b4a88-b463-47bc-9dd1-9e6e2ebbcddc","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<CommercialConditionSLVMEntityView>("59c63554-92d2-44a0-935e-c4e570f0d6fa","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<CommercialConditionSLVMEntityView>("58998564-0866-4611-9d6c-d934fc5c3307","","",false, this);
 
            ConditionValue = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionSLVMEntityView>("92456756-cb35-4ead-ad22-ce9a7c66e57a","","",true, this);
 
            ConditionValueAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionSLVMEntityView>("5b9b4d8a-5ade-455f-9da2-9fbef66176db","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionSLVMEntityView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionSLVMEntityView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionSLVMEntityView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<CommercialConditionSLVMEntityView>( "f6c5b827-202d-4103-b53c-372bdd234920","","",this);
 
            CollectionInit params_CommercialConditionCassationSLApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d581c8bb-939c-4013-8ba0-eb205a357bca",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionSLVMEntityView>,CommercialConditionSLVMEntityView>( params_CommercialConditionCassationSLApplieds,this);
 
            CollectionInit params_CommercialConditionCassationSLCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe99c546-098b-4ce4-9efe-b246e3066761",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionSLVMEntityView>,CommercialConditionSLVMEntityView>( params_CommercialConditionCassationSLCassations,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CommercialConditionSLVMEntityView>( "","ul li[rpsid='89666348-da8b-459b-8855-6ff0b58d7b83']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<CommercialConditionSLVMEntityView>( "","ul li[rpsid='a51a1649-b403-4622-bb1e-e330873a7b5d']","",this);
 

        }
        public IRPSSaveButton<CommercialConditionSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConditionSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConditionSLVMEntityView,CommercialConditionSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConditionSLVMEntityView,CommercialConditionSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> IDCommercialConditionType { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> IDItemArticle { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> IDItemProductLine { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<CommercialConditionSLVMEntityView> IDItemProductSubFamily { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> ConditionValue { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> ConditionValueAmount { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> UIApply { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> UILiquidate { get; set; } 
        public IRPSTextBox<CommercialConditionSLVMEntityView> UIDifference { get; set; } 
        public IRPSButton<CommercialConditionSLVMEntityView> CassationCommandButton { get; set; } 
        public CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionSLVMEntityView> CommercialConditionCassationSLApplieds { get; set; } 
        public CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionSLVMEntityView> CommercialConditionCassationSLCassations { get; set; } 
        public IRPSSection<CommercialConditionSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<CommercialConditionSLVMEntityView> SectionCassation { get; set; } 
        public CommercialConditionSL Screen { get; set; }
        public CommercialConditionSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionSLVMEntityView>:RPSCollectionEditor<CommercialConditionSLVMEntityView> where CommercialConditionSLVMEntityView : class, IView
    {
        public  CommercialConditionCassationSLAppliedsGridView<CommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLAppliedsGridView <CommercialConditionSLVMEntityView> :  RPSGridView<CommercialConditionSLVMEntityView> where CommercialConditionSLVMEntityView : class, IView
    {
        public CommercialConditionCassationSLAppliedsGridView(CommercialConditionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMEntityView>("","#d581c8bb-939c-4013-8ba0-eb205a357bca .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConditionSLVMEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConditionSLVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConditionSLVMEntityView> Processed { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionSLVMEntityView>:RPSCollectionEditor<CommercialConditionSLVMEntityView> where CommercialConditionSLVMEntityView : class, IView
    {
        public  CommercialConditionCassationSLCassationsGridView<CommercialConditionSLVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLCassationsGridView <CommercialConditionSLVMEntityView> :  RPSGridView<CommercialConditionSLVMEntityView> where CommercialConditionSLVMEntityView : class, IView
    {
        public CommercialConditionCassationSLCassationsGridView(CommercialConditionSLVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConditionSLVMEntityView>("","#fe99c546-098b-4ce4-9efe-b246e3066761 .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConditionSLVMEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConditionSLVMEntityView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConditionSLVMEntityView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConditionSLVMEntityView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
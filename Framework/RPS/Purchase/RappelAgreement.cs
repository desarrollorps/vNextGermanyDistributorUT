    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.RappelAgreement
{
    //RPS VERSION 1.0.0.0
    public partial class RappelAgreement:Screen
    {
        public RappelAgreement():base()
        {
            this.URL = "purchase.rappelagreement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelAgreementVMQueryView  = new RappelAgreementVMQueryView(this); 
            RappelAgreementVMEntityView  = new RappelAgreementVMEntityView(this); 
            RappelAgreementItemView  = new RappelAgreementItemView(this); 
            RappelView  = new RappelView(this); 
            RappelAgreementFromCopyChildDialogView  = new RappelAgreementFromCopyChildDialogView(this); 
            RappelAgreementVMQueryView.InitializeControls(); 
            RappelAgreementVMEntityView.InitializeControls(); 
            RappelAgreementItemView.InitializeControls(); 
            RappelView.InitializeControls(); 
            RappelAgreementFromCopyChildDialogView.InitializeControls(); 
           
        }
      
            public RappelAgreementVMQueryView RappelAgreementVMQueryView {get; set; } 
            public RappelAgreementVMEntityView RappelAgreementVMEntityView {get; set; } 
            public RappelAgreementItemView RappelAgreementItemView {get; set; } 
            public RappelView RappelView {get; set; } 
            public RappelAgreementFromCopyChildDialogView RappelAgreementFromCopyChildDialogView {get; set; } 
    }
            
    public partial class RappelAgreementVMQueryView : View
    {
        public RappelAgreementVMQueryView(RappelAgreement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RappelAgreementVMQueryView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<RappelAgreementVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMQueryView>("f1e266e5-0119-452c-b880-ce207dc10dcd","","",false, this);
 
            UIlsIDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<RappelAgreementVMQueryView>("72a8baba-feb3-483c-a218-f95d3619b06e","","",false, this);
 
            Monthly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("a1acb59a-0e19-4e1f-96a1-27ac9abcac44","","",false, this);
 
            Bimonthly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("257c3c7d-bb3e-4868-ae17-04150ebb7a78","","",false, this);
 
            Quarterly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("5e77a582-ee02-4a9f-931f-0d3aed4aff4f","","",false, this);
 
            FourMonthPeriod = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("793c9fa7-60f0-4a18-8212-b33a6c421238","","",false, this);
 
            HalfYearly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("8706cac5-1b0c-4b1d-bb6e-376e4c196bee","","",false, this);
 
            Annual = RPSControlFactory.CreateRPSCheckBox<RappelAgreementVMQueryView>("2d62499a-1a02-43b6-be7b-201459a7e5d3","","",false, this);
 
            CollectionInit params_RappelAgreementConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2af008f5-44db-40fe-830c-91f376249f19",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementConsultCollectionEditor<RappelAgreementVMQueryView,RappelAgreementVMEntityView>,RappelAgreementVMQueryView,RappelAgreementVMEntityView>( params_RappelAgreementConsult,this,Screen.RappelAgreementVMEntityView);
 

        }
        public IRPSButton<RappelAgreementVMQueryView,RappelAgreementVMEntityView> NewButton { get; set; } 
        public IRPSButton<RappelAgreementVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<RappelAgreementVMQueryView> UIActiveDate { get; set; } 
        public IRPSCollectionComboBox<RappelAgreementVMQueryView> UIlsIDSupplier { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> Monthly { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> Bimonthly { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> Quarterly { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> FourMonthPeriod { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> HalfYearly { get; set; } 
        public IRPSCheckbox<RappelAgreementVMQueryView> Annual { get; set; } 
        public RappelAgreementConsultCollectionEditor<RappelAgreementVMQueryView,RappelAgreementVMEntityView> RappelAgreementConsult { get; set; } 
        public RappelAgreement Screen { get; set; }
        public RappelAgreementVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelAgreementConsultCollectionEditor<RappelAgreementVMQueryView,RappelAgreementVMEntityView>:RPSCollectionEditor<RappelAgreementVMQueryView,RappelAgreementVMEntityView> where RappelAgreementVMQueryView : class, IView where RappelAgreementVMEntityView : class, IView
    {
        public  RappelAgreementConsultGridView<RappelAgreementVMQueryView,RappelAgreementVMEntityView> GridView {get;set;}
    }
    public partial class RappelAgreementConsultGridView <RappelAgreementVMQueryView,RappelAgreementVMEntityView> :  RPSGridView<RappelAgreementVMQueryView,RappelAgreementVMEntityView> where RappelAgreementVMQueryView : class, IView where RappelAgreementVMEntityView : class, IView
    {
        public RappelAgreementConsultGridView(RappelAgreementVMQueryView currentView,RappelAgreementVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreement_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreement_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateFrom']","",false, this.CurrentView);
 
            RappelAgreement_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_DateTo']","",false, this.CurrentView);
 
            RappelAgreement_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_RappelType']","",false, this.CurrentView);
 
            RappelAgreement_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Periodicity']","",false, this.CurrentView);
 
            RappelAgreement_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreement_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementVMQueryView>("","#2af008f5-44db-40fe-830c-91f376249f19 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreement_Percentage_Amount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_DateTo { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_RappelType { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMQueryView> RappelAgreement_Percentage_Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelAgreementVMEntityView : View
    {
        public RappelAgreementVMEntityView(RappelAgreement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RappelAgreementVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelAgreementVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelAgreementVMEntityView,RappelAgreementVMQueryView>( this,Screen.RappelAgreementVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelAgreementVMEntityView,RappelAgreementVMQueryView>( this,Screen.RappelAgreementVMQueryView);
 
            CodRappelAgreement = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("8714e932-0055-4fa0-83a9-4d33b0b59675","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("807d7b42-2139-4620-a883-5893e831473e","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("c082f6e9-1a69-4a25-9b8a-8a5d094b86df","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("fc3b3eda-15d1-4d1a-9df7-bd45a211e965","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("b7d35f4c-5722-463d-878d-5e2603aeb22f","","",true, this);
 
            Periodicity = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementVMEntityView>("263fa9e8-6e04-4984-8785-85feca48126a","","",true, this);
 
            BaseApply = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementVMEntityView>("d8b456fa-47d3-4bf4-a8d4-688187545cdf","","",true, this);
 
            RappelType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementVMEntityView>("88b2ad96-2526-48bc-ae95-198d97b63a7b","","",true, this);
 
            MinimunValue = RPSControlFactory.CreateRPSFormattedTextBox<RappelAgreementVMEntityView>("e71a4ee9-c14d-4bad-9411-75d0b470c1cf","","",true, this);
 
            Percentage_Amount = RPSControlFactory.CreateRPSFormattedTextBox<RappelAgreementVMEntityView>("a9e4aaaa-f896-4e5b-b4da-8394f3f7d70f","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementVMEntityView>("100a7615-66e2-4df9-95e2-e1a208f46ccb","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("7b7eff48-9afb-4974-8757-14a9b5d4e991","","",false, this);
 
            IDPurDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("00fa3d0a-c923-4e44-85f9-fe47ef8936f6","","",false, this);
 
            IDFacDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("7889c50d-3450-48c0-920f-8b1127dc1c30","","",false, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("4336825e-cecc-4992-a526-05b191f228d5","","",false, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("3d02a6bd-d981-4c0e-9578-554ad21b0f5b","","",false, this);
 
            IDSupplierCommercialCondition = RPSControlFactory.CreateRPSComboBox<RappelAgreementVMEntityView>("c2b68378-c842-4e56-bd04-60be70bcf3fd","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<RappelAgreementVMEntityView>("c87a0a59-77b9-48d0-a527-511ad583b266","","",false, this);
 
            GenerateRappelsCommandButton = RPSControlFactory.CreateRPSButton<RappelAgreementVMEntityView>( "7adb93d2-82e6-4354-b3ec-6b8c2db66379","","",this);
 
            RappelAgreementFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RappelAgreementVMEntityView,RappelAgreementFromCopyChildDialogView>("0481dad3-60d8-4803-a0aa-b26b64cf3dd0","","", this,Screen.RappelAgreementFromCopyChildDialogView);
 
            CollectionInit params_Rappels = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b480fefd-4280-469d-ba71-5cf1677d27ea",CSSSelectorGrid="",XPathGrid=""};
            Rappels = RPSControlFactory.RPSCreateCollectionWithGrid<RappelsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView>,RappelAgreementVMEntityView,RappelAgreementItemView>( params_Rappels,this,Screen.RappelAgreementItemView);
 
            CollectionInit params_RappelAgreementItems = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="50b25878-460f-464a-a8ff-1dd3b2518e3a",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementItems = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementItemsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView>,RappelAgreementVMEntityView,RappelAgreementItemView>( params_RappelAgreementItems,this,Screen.RappelAgreementItemView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<RappelAgreementVMEntityView>( "","ul li[rpsid='acf42752-da42-46f5-a617-ba25818de33b']","",this);
 
            Rappels1 = RPSControlFactory.CreateRPSSection<RappelAgreementVMEntityView>( "","ul li[rpsid='84fd6422-d7b7-4ba3-9a2c-f8f8f43e6f9a']","",this);
 
            RappelItem = RPSControlFactory.CreateRPSSection<RappelAgreementVMEntityView>( "","ul li[rpsid='ce8b20ac-f56c-48d0-a04e-81cf88f5a15e']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<RappelAgreementVMEntityView>( "","ul li[rpsid='a201ec9e-8ec8-4fef-9d06-bed4e712cdb3']","",this);
 

        }
        public IRPSSaveButton<RappelAgreementVMEntityView> SaveButton { get; set; } 
        public IRPSButton<RappelAgreementVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<RappelAgreementVMEntityView,RappelAgreementVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelAgreementVMEntityView,RappelAgreementVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> CodRappelAgreement { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> Description { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> Periodicity { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> BaseApply { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> RappelType { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> MinimunValue { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> Percentage_Amount { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> DocumentType { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDPurDeliveryNoteType { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDFacDeliveryNoteTypeSL { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> LastCalculationDate { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDCommercialConcept { get; set; } 
        public IRPSComboBox<RappelAgreementVMEntityView> IDSupplierCommercialCondition { get; set; } 
        public IRPSTextBox<RappelAgreementVMEntityView> Comment { get; set; } 
        public IRPSButton<RappelAgreementVMEntityView> GenerateRappelsCommandButton { get; set; } 
        public IRPSButton<RappelAgreementVMEntityView,RappelAgreementFromCopyChildDialogView> RappelAgreementFromCopyChildNavigationCommandButton { get; set; } 
        public RappelsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView> Rappels { get; set; } 
        public RappelAgreementItemsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView> RappelAgreementItems { get; set; } 
        public IRPSSection<RappelAgreementVMEntityView> GeneralData { get; set; } 
        public IRPSSection<RappelAgreementVMEntityView> Rappels1 { get; set; } 
        public IRPSSection<RappelAgreementVMEntityView> RappelItem { get; set; } 
        public IRPSSection<RappelAgreementVMEntityView> Comments { get; set; } 
        public RappelAgreement Screen { get; set; }
        public RappelAgreementVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView>:RPSCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView> where RappelAgreementVMEntityView : class, IView where RappelAgreementItemView : class, IView
    {
        public  RappelsGridView<RappelAgreementVMEntityView,RappelAgreementItemView> GridView {get;set;}
    }
    public partial class RappelsGridView <RappelAgreementVMEntityView,RappelAgreementItemView> :  RPSGridView<RappelAgreementVMEntityView,RappelAgreementItemView> where RappelAgreementVMEntityView : class, IView where RappelAgreementItemView : class, IView
    {
        public RappelsGridView(RappelAgreementVMEntityView currentView,RappelAgreementItemView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cLastCalculationDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementVMEntityView>("","#b480fefd-4280-469d-ba71-5cf1677d27ea .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelAgreementVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMEntityView> LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMEntityView> Base { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<RappelAgreementVMEntityView> Quantity { get; set; } 
        public IRPSGridComboBox<RappelAgreementVMEntityView> Status { get; set; } 
                     
    }
 
        public partial class RappelAgreementItemsCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView>:RPSCollectionEditor<RappelAgreementVMEntityView,RappelAgreementItemView> where RappelAgreementVMEntityView : class, IView where RappelAgreementItemView : class, IView
    {
        public  RappelAgreementItemsGridView<RappelAgreementVMEntityView,RappelAgreementItemView> GridView {get;set;}
    }
    public partial class RappelAgreementItemsGridView <RappelAgreementVMEntityView,RappelAgreementItemView> :  RPSGridView<RappelAgreementVMEntityView,RappelAgreementItemView> where RappelAgreementVMEntityView : class, IView where RappelAgreementItemView : class, IView
    {
        public RappelAgreementItemsGridView(RappelAgreementVMEntityView currentView,RappelAgreementItemView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ItemType = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementVMEntityView>("","#50b25878-460f-464a-a8ff-1dd3b2518e3a .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<RappelAgreementVMEntityView>("","#50b25878-460f-464a-a8ff-1dd3b2518e3a .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IncludeExclude = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementVMEntityView>("","#50b25878-460f-464a-a8ff-1dd3b2518e3a .ag-row[role='row']@ROWINDEX [col-id='cIncludeExclude']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<RappelAgreementVMEntityView> ItemType { get; set; } 
        public IRPSGridComboBox<RappelAgreementVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<RappelAgreementVMEntityView> IncludeExclude { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelAgreementItemView : View
    {
        public RappelAgreementItemView(RappelAgreement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelAgreementItemView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelAgreementItemView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelAgreementItemView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RappelAgreementItemView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementItemView>("808b2190-6026-4c2a-a50f-ba8ae4de6792","","",true, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemView>("c318fb53-9d5a-4793-b345-db3c9ecf066a","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemView>("f6c54016-57bd-4781-861e-ae16302bab64","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemView>("542b72b2-8151-44d1-827f-f0d6c097767d","","",false, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemView>("370c88ab-c19b-44ba-95f0-fe9409d368b6","","",false, this);
 
            IncludeExclude = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementItemView>("d28adec8-9041-4ae5-a7c7-5273b40eb203","","",true, this);
 

        }
        public IRPSButton<RappelAgreementItemView> DeleteButton { get; set; } 
        public IRPSButton<RappelAgreementItemView,RappelAgreementVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelAgreementItemView,RappelAgreementVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RappelAgreementItemView,RappelAgreementVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> ItemType { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> IDItemProductLine { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> IDItemProductSubFamily { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> IDItemArticle { get; set; } 
        public IRPSComboBox<RappelAgreementItemView> IncludeExclude { get; set; } 
        public RappelAgreement Screen { get; set; }
        public RappelAgreementItemView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RappelView : View
    {
        public RappelView(RappelAgreement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RappelView,RappelAgreementVMEntityView>( this,Screen.RappelAgreementVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RappelView>("19b7a259-58d2-4ae3-b8df-f28b08a18496","","",true, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<RappelView>("7b347926-ba7c-4527-8553-d05a1da36348","","",false, this);
 
            Base = RPSControlFactory.CreateRPSFormattedTextBox<RappelView>("494aeeaa-5acb-4c8c-8370-1811235ebe27","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RappelView>("0151c0bf-7b88-40ed-8dd6-435c28767942","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<RappelView>("27521519-99b4-4178-8e51-3b26b8fe4f6b","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<RappelView>("d0b69961-0263-4f7c-a406-d8e2cca1d0de","","",true, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<RappelView>("a01f2666-b6e5-42cd-b877-4debd45b39f9","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<RappelView>("961f0434-db95-4de3-a776-c722edd48c5f","","",false, this);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSTextBox<RappelView>("5fa3b887-34b7-411b-8849-8baa3e2bb314","","",false, this);
 
            CollectionInit params_RappelArticles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c909645-39e4-4856-a482-ff5a54cdab39",CSSSelectorGrid="",XPathGrid=""};
            RappelArticles = RPSControlFactory.RPSCreateCollectionWithGrid<RappelArticlesCollectionEditor<RappelView>,RappelView>( params_RappelArticles,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<RappelView>( "","ul li[rpsid='4253f520-6c9c-4357-b46a-49193fa32d83']","",this);
 
            RappelsArticle = RPSControlFactory.CreateRPSSection<RappelView>( "","ul li[rpsid='037f59ec-b382-45ec-af89-d508c137c252']","",this);
 

        }
        public IRPSButton<RappelView> DeleteButton { get; set; } 
        public IRPSButton<RappelView,RappelAgreementVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelView,RappelAgreementVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RappelView,RappelAgreementVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<RappelView> DateFrom { get; set; } 
        public IRPSTextBox<RappelView> LastCalculationDate { get; set; } 
        public IRPSTextBox<RappelView> Base { get; set; } 
        public IRPSTextBox<RappelView> Amount { get; set; } 
        public IRPSTextBox<RappelView> Quantity { get; set; } 
        public IRPSComboBox<RappelView> Status { get; set; } 
        public IRPSTextBox<RappelView> CodOrder { get; set; } 
        public IRPSTextBox<RappelView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<RappelView> CodMerchandiseGift { get; set; } 
        public RappelArticlesCollectionEditor<RappelView> RappelArticles { get; set; } 
        public IRPSSection<RappelView> GeneralData { get; set; } 
        public IRPSSection<RappelView> RappelsArticle { get; set; } 
        public RappelAgreement Screen { get; set; }
        public RappelView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelArticlesCollectionEditor<RappelView>:RPSCollectionEditor<RappelView> where RappelView : class, IView
    {
        public  RappelArticlesGridView<RappelView> GridView {get;set;}
    }
    public partial class RappelArticlesGridView <RappelView> :  RPSGridView<RappelView> where RappelView : class, IView
    {
        public RappelArticlesGridView(RappelView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<RappelView>("","#5c909645-39e4-4856-a482-ff5a54cdab39 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelView>("","#5c909645-39e4-4856-a482-ff5a54cdab39 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelView>("","#5c909645-39e4-4856-a482-ff5a54cdab39 .ag-row[role='row']@ROWINDEX [col-id='cCodMerchandiseGift']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<RappelView> IDArticle { get; set; } 
        public IRPSGridTextBox<RappelView> Quantity { get; set; } 
        public IRPSGridTextBox<RappelView> CodMerchandiseGift { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelAgreementFromCopyChildDialogView : View
    {
        public RappelAgreementFromCopyChildDialogView(RappelAgreement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewIDSupplier = RPSControlFactory.CreateRPSComboBox<RappelAgreementFromCopyChildDialogView>("55919641-48ec-49ea-9c9a-7e31b67eb73f","","",true, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<RappelAgreementFromCopyChildDialogView>("28084d04-2849-4f85-8a65-f2f486edd01a","","",true, this);
 

        }
        public IRPSComboBox<RappelAgreementFromCopyChildDialogView> NewIDSupplier { get; set; } 
        public IRPSTextBox<RappelAgreementFromCopyChildDialogView> NewCode { get; set; } 
        public RappelAgreement Screen { get; set; }
        public RappelAgreementFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
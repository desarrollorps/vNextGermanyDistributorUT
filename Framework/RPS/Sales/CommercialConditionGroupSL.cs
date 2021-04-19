    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialConditionGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialConditionGroupSL:Screen
    {
        public CommercialConditionGroupSL():base()
        {
            this.URL = "sales.commercialconditiongroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialConditionGroupSLVMQueryView  = new CommercialConditionGroupSLVMQueryView(this); 
            CommercialConditionGroupSLVMEntityView  = new CommercialConditionGroupSLVMEntityView(this); 
            CommercialConditionGroupDetailSLView  = new CommercialConditionGroupDetailSLView(this); 
            CommercialConditionGroupSLVMQueryView.InitializeControls(); 
            CommercialConditionGroupSLVMEntityView.InitializeControls(); 
            CommercialConditionGroupDetailSLView.InitializeControls(); 
           
        }
      
            public CommercialConditionGroupSLVMQueryView CommercialConditionGroupSLVMQueryView {get; set; } 
            public CommercialConditionGroupSLVMEntityView CommercialConditionGroupSLVMEntityView {get; set; } 
            public CommercialConditionGroupDetailSLView CommercialConditionGroupDetailSLView {get; set; } 
    }
            
    public partial class CommercialConditionGroupSLVMQueryView : View
    {
        public CommercialConditionGroupSLVMQueryView(CommercialConditionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView>( this,Screen.CommercialConditionGroupSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommercialConditionGroupSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupSLVMQueryView>("1dcca418-45b5-40d0-a918-a7e2d0d54192","","",false, this);
 
            UIAllArticle = RPSControlFactory.CreateRPSCheckBox<CommercialConditionGroupSLVMQueryView>("46d1192e-6c41-48b8-9cd0-07b191ea6563","","",false, this);
 
            UIProducLine = RPSControlFactory.CreateRPSCheckBox<CommercialConditionGroupSLVMQueryView>("71f9a746-a025-4722-b081-12d14eb7fd41","","",false, this);
 
            UIlsProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView>("ac4f58b2-e1ae-43c3-9734-1381957b7ba2","","",false, this);
 
            UIFamily = RPSControlFactory.CreateRPSCheckBox<CommercialConditionGroupSLVMQueryView>("68be64e1-323b-40ce-b476-cdb8c33555dd","","",false, this);
 
            UIlsProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView>("521b7476-8b00-4e97-8e3f-0e96756f391e","","",false, this);
 
            UISubFamily = RPSControlFactory.CreateRPSCheckBox<CommercialConditionGroupSLVMQueryView>("f1f22f19-4826-4ba0-accb-5f836eb1c66a","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView>("0ad25af3-bb67-4602-bb4a-0188ca4164af","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCheckBox<CommercialConditionGroupSLVMQueryView>("6d8b2ca6-fef3-4e8b-b717-768a9b276fec","","",false, this);
 
            UIlsIDArticle = RPSControlFactory.CreateRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView>("e6b82c1c-6325-4b6e-b33e-e22c85e0b5d2","","",false, this);
 
            CollectionInit params_CommercialConditionGroupSLConsult = new CollectionInit(){IDDescriptor = "25e8afd4-00df-40f1-bfaa-36bcc3f5e17c",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7b794b54-0783-4604-a6d2-941a411a9c9f",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionGroupSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionGroupSLConsultCollectionEditor<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView>,CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView>( params_CommercialConditionGroupSLConsult,this,Screen.CommercialConditionGroupSLVMEntityView);
 

        }
        public IRPSButton<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommercialConditionGroupSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CommercialConditionGroupSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSCheckbox<CommercialConditionGroupSLVMQueryView> UIAllArticle { get; set; } 
        public IRPSCheckbox<CommercialConditionGroupSLVMQueryView> UIProducLine { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView> UIlsProductLine { get; set; } 
        public IRPSCheckbox<CommercialConditionGroupSLVMQueryView> UIFamily { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView> UIlsProductFamily { get; set; } 
        public IRPSCheckbox<CommercialConditionGroupSLVMQueryView> UISubFamily { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCheckbox<CommercialConditionGroupSLVMQueryView> UIArticle { get; set; } 
        public IRPSCollectionComboBox<CommercialConditionGroupSLVMQueryView> UIlsIDArticle { get; set; } 
        public CommercialConditionGroupSLConsultCollectionEditor<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> CommercialConditionGroupSLConsult { get; set; } 
        public CommercialConditionGroupSL Screen { get; set; }
        public CommercialConditionGroupSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionGroupSLConsultCollectionEditor<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView>:RPSCollectionEditor<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> where CommercialConditionGroupSLVMQueryView : class, IView where CommercialConditionGroupSLVMEntityView : class, IView
    {
        public  CommercialConditionGroupSLConsultGridView<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> GridView {get;set;}
    }
    public partial class CommercialConditionGroupSLConsultGridView <CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> :  RPSGridView<CommercialConditionGroupSLVMQueryView,CommercialConditionGroupSLVMEntityView> where CommercialConditionGroupSLVMQueryView : class, IView where CommercialConditionGroupSLVMEntityView : class, IView
    {
        public CommercialConditionGroupSLConsultGridView(CommercialConditionGroupSLVMQueryView currentView,CommercialConditionGroupSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommercialConditionGroupSL_CodCommercialConditionGroup = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupSLVMQueryView>("","#7b794b54-0783-4604-a6d2-941a411a9c9f .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionGroupSL_CodCommercialConditionGroup']","",false, this.CurrentView);
 
            CommercialConditionGroupSL_Description = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupSLVMQueryView>("","#7b794b54-0783-4604-a6d2-941a411a9c9f .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionGroupSL_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommercialConditionGroupSLVMQueryView> CommercialConditionGroupSL_CodCommercialConditionGroup { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupSLVMQueryView> CommercialConditionGroupSL_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommercialConditionGroupSLVMEntityView : View
    {
        public CommercialConditionGroupSLVMEntityView(CommercialConditionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialConditionGroupSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConditionGroupSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupSLVMQueryView>( this,Screen.CommercialConditionGroupSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupSLVMQueryView>( this,Screen.CommercialConditionGroupSLVMQueryView);
 
            CodCommercialConditionGroup = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupSLVMEntityView>("b45bf147-1259-4332-a927-4bfdcf1c9e31","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupSLVMEntityView>("759f1618-ecda-4ee6-a2ba-fc3108394dcd","","",false, this);
 
            CollectionInit params_CommercialConditionGroupDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b2cf9255-7911-4ca5-8298-a19ec35fb36c",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionGroupDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionGroupDetailsCollectionEditor<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView>,CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView>( params_CommercialConditionGroupDetails,this,Screen.CommercialConditionGroupDetailSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CommercialConditionGroupSLVMEntityView>( "","ul li[rpsid='133a29db-c8bc-4420-99df-4ff21ac8f94e']","",this);
 

        }
        public IRPSSaveButton<CommercialConditionGroupSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialConditionGroupSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupSLVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<CommercialConditionGroupSLVMEntityView> CodCommercialConditionGroup { get; set; } 
        public IRPSTextBox<CommercialConditionGroupSLVMEntityView> Description { get; set; } 
        public CommercialConditionGroupDetailsCollectionEditor<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView> CommercialConditionGroupDetails { get; set; } 
        public IRPSSection<CommercialConditionGroupSLVMEntityView> GeneralData { get; set; } 
        public CommercialConditionGroupSL Screen { get; set; }
        public CommercialConditionGroupSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionGroupDetailsCollectionEditor<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView>:RPSCollectionEditor<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView> where CommercialConditionGroupSLVMEntityView : class, IView where CommercialConditionGroupDetailSLView : class, IView
    {
        public  CommercialConditionGroupDetailsGridView<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView> GridView {get;set;}
    }
    public partial class CommercialConditionGroupDetailsGridView <CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView> :  RPSGridView<CommercialConditionGroupSLVMEntityView,CommercialConditionGroupDetailSLView> where CommercialConditionGroupSLVMEntityView : class, IView where CommercialConditionGroupDetailSLView : class, IView
    {
        public CommercialConditionGroupDetailsGridView(CommercialConditionGroupSLVMEntityView currentView,CommercialConditionGroupDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialConditionType = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialConditionType']","",false, this.CurrentView);
 
            ItemType = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupSLVMEntityView>("","#b2cf9255-7911-4ca5-8298-a19ec35fb36c .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConditionGroupSLVMEntityView> IDCommercialConditionType { get; set; } 
        public IRPSGridComboBox<CommercialConditionGroupSLVMEntityView> ItemType { get; set; } 
        public IRPSGridComboBox<CommercialConditionGroupSLVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupSLVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupSLVMEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupSLVMEntityView> ConditionValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommercialConditionGroupDetailSLView : View
    {
        public CommercialConditionGroupDetailSLView(CommercialConditionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialConditionGroupDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView>( this,Screen.CommercialConditionGroupSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView>( this,Screen.CommercialConditionGroupSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView>( this,Screen.CommercialConditionGroupSLVMEntityView);
 
            IDCommercialConditionType = RPSControlFactory.CreateRPSComboBox<CommercialConditionGroupDetailSLView>("7caaf463-4529-41a5-bf5b-5b4dd27f8d7d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupDetailSLView>("90fb79de-6e2b-4f8e-80c3-20aef9e5bea9","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupDetailSLView>("b1f13c35-bd06-4a8f-bf42-fe41031fe057","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommercialConditionGroupDetailSLView>("b132de9c-7411-40ba-bead-44e7f4068b61","","",true, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CommercialConditionGroupDetailSLView>("5fe6a921-b72a-42e9-a6b8-5525948d31f6","","",true, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<CommercialConditionGroupDetailSLView>("b2cb8287-a5d2-412f-8ef4-18244657483a","","",false, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<CommercialConditionGroupDetailSLView>("ca1a1f59-0a06-411a-ba41-b1d7357583fc","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<CommercialConditionGroupDetailSLView>("2a0afa5a-c8f4-4d9c-8e43-a507eba084e1","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<CommercialConditionGroupDetailSLView>("69d7af4b-41bb-44e0-acd6-342b0f5b837a","","",false, this);
 
            ConditionValue = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionGroupDetailSLView>("200a7ee6-568a-459f-9808-d16da9995b23","","",true, this);
 
            ConditionValueAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionGroupDetailSLView>("4e007c72-2737-42ac-97ae-59405bcfb1f7","","",false, this);
 
            UIApply = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionGroupDetailSLView>("7b6227c0-b247-42bc-aff4-f633044d3946","","",false, this);
 
            UILiquidate = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionGroupDetailSLView>("ef9c3fe0-47b5-4556-9700-8429c99a811c","","",false, this);
 
            UIDifference = RPSControlFactory.CreateRPSFormattedTextBox<CommercialConditionGroupDetailSLView>("b7cccbca-cd80-4c63-beae-0a192b6d52ab","","",false, this);
 
            CassationCommandButton = RPSControlFactory.CreateRPSButton<CommercialConditionGroupDetailSLView>( "cd3df315-825e-484a-934b-e30dc6ae280a","","",this);
 
            CollectionInit params_CommercialConditionCassationSLApplieds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="35fe155c-e280-4ec8-a9db-90dfda0ca67f",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLApplieds = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionGroupDetailSLView>,CommercialConditionGroupDetailSLView>( params_CommercialConditionCassationSLApplieds,this);
 
            CollectionInit params_CommercialConditionCassationSLCassations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="50dd1644-faeb-4b4b-88bf-9656c77147fe",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionCassationSLCassations = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionGroupDetailSLView>,CommercialConditionGroupDetailSLView>( params_CommercialConditionCassationSLCassations,this);
 
            Section = RPSControlFactory.CreateRPSSection<CommercialConditionGroupDetailSLView>( "","ul li[rpsid='a0081495-aef3-4573-a319-6c560a349bc5']","",this);
 
            SectionCassation = RPSControlFactory.CreateRPSSection<CommercialConditionGroupDetailSLView>( "","ul li[rpsid='a51a1649-b403-4622-bb1e-e330873a7b5d']","",this);
 

        }
        public IRPSButton<CommercialConditionGroupDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CommercialConditionGroupDetailSLView,CommercialConditionGroupSLVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> IDCommercialConditionType { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> Description { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> DateFrom { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> DateTo { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> ItemType { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> IDItemArticle { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> IDItemProductLine { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<CommercialConditionGroupDetailSLView> IDItemProductSubFamily { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> ConditionValue { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> ConditionValueAmount { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> UIApply { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> UILiquidate { get; set; } 
        public IRPSTextBox<CommercialConditionGroupDetailSLView> UIDifference { get; set; } 
        public IRPSButton<CommercialConditionGroupDetailSLView> CassationCommandButton { get; set; } 
        public CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionGroupDetailSLView> CommercialConditionCassationSLApplieds { get; set; } 
        public CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionGroupDetailSLView> CommercialConditionCassationSLCassations { get; set; } 
        public IRPSSection<CommercialConditionGroupDetailSLView> Section { get; set; } 
        public IRPSSection<CommercialConditionGroupDetailSLView> SectionCassation { get; set; } 
        public CommercialConditionGroupSL Screen { get; set; }
        public CommercialConditionGroupDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommercialConditionCassationSLAppliedsCollectionEditor<CommercialConditionGroupDetailSLView>:RPSCollectionEditor<CommercialConditionGroupDetailSLView> where CommercialConditionGroupDetailSLView : class, IView
    {
        public  CommercialConditionCassationSLAppliedsGridView<CommercialConditionGroupDetailSLView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLAppliedsGridView <CommercialConditionGroupDetailSLView> :  RPSGridView<CommercialConditionGroupDetailSLView> where CommercialConditionGroupDetailSLView : class, IView
    {
        public CommercialConditionCassationSLAppliedsGridView(CommercialConditionGroupDetailSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 
            CodCassationInvoice = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupDetailSLView>("","#35fe155c-e280-4ec8-a9db-90dfda0ca67f .ag-row[role='row']@ROWINDEX [col-id='cCodCassationInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConditionGroupDetailSLView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConditionGroupDetailSLView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConditionGroupDetailSLView> Processed { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> CodCassationInvoice { get; set; } 
                     
    }
 
        public partial class CommercialConditionCassationSLCassationsCollectionEditor<CommercialConditionGroupDetailSLView>:RPSCollectionEditor<CommercialConditionGroupDetailSLView> where CommercialConditionGroupDetailSLView : class, IView
    {
        public  CommercialConditionCassationSLCassationsGridView<CommercialConditionGroupDetailSLView> GridView {get;set;}
    }
    public partial class CommercialConditionCassationSLCassationsGridView <CommercialConditionGroupDetailSLView> :  RPSGridView<CommercialConditionGroupDetailSLView> where CommercialConditionGroupDetailSLView : class, IView
    {
        public CommercialConditionCassationSLCassationsGridView(CommercialConditionGroupDetailSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDInvoiceSL = RPSControlFactory.CreateRPSGridComboBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cUIIDInvoiceSL']","",false, this.CurrentView);
 
            UIOrdernation = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cUIOrdernation']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountCompanyCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cAmountCompanyCurrency']","",true, this.CurrentView);
 
            Processed = RPSControlFactory.CreateRPSGridCheckBox<CommercialConditionGroupDetailSLView>("","#50dd1644-faeb-4b4b-88bf-9656c77147fe .ag-row[role='row']@ROWINDEX [col-id='cProcessed']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialConditionGroupDetailSLView> UIIDInvoiceSL { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> UIOrdernation { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<CommercialConditionGroupDetailSLView> Type { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> Amount { get; set; } 
        public IRPSGridTextBox<CommercialConditionGroupDetailSLView> AmountCompanyCurrency { get; set; } 
        public IRPSGridCheckbox<CommercialConditionGroupDetailSLView> Processed { get; set; } 
                     
    }
 
    }
  
    

}
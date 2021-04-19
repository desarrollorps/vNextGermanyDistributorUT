    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionDefinitionByObjectiveSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionDefinitionByObjectiveSL:Screen
    {
        public CommissionDefinitionByObjectiveSL():base()
        {
            this.URL = "sales.commissiondefinitionbyobjectivesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionDefinitionByObjectiveSLVMQueryView  = new CommissionDefinitionByObjectiveSLVMQueryView(this); 
            CommissionDefinitionByObjectiveSLVMEntityView  = new CommissionDefinitionByObjectiveSLVMEntityView(this); 
            CommissionDefinitionByObjectiveDetailSLView  = new CommissionDefinitionByObjectiveDetailSLView(this); 
            CommissionDefinitionByObjectivePeriodSLView  = new CommissionDefinitionByObjectivePeriodSLView(this); 
            CommissionDefinitionByObjectiveSLVMQueryView.InitializeControls(); 
            CommissionDefinitionByObjectiveSLVMEntityView.InitializeControls(); 
            CommissionDefinitionByObjectiveDetailSLView.InitializeControls(); 
            CommissionDefinitionByObjectivePeriodSLView.InitializeControls(); 
           
        }
      
            public CommissionDefinitionByObjectiveSLVMQueryView CommissionDefinitionByObjectiveSLVMQueryView {get; set; } 
            public CommissionDefinitionByObjectiveSLVMEntityView CommissionDefinitionByObjectiveSLVMEntityView {get; set; } 
            public CommissionDefinitionByObjectiveDetailSLView CommissionDefinitionByObjectiveDetailSLView {get; set; } 
            public CommissionDefinitionByObjectivePeriodSLView CommissionDefinitionByObjectivePeriodSLView {get; set; } 
    }
            
    public partial class CommissionDefinitionByObjectiveSLVMQueryView : View
    {
        public CommissionDefinitionByObjectiveSLVMQueryView(CommissionDefinitionByObjectiveSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommissionDefinitionByObjectiveSLVMQueryView>( this);
 
            UIEffectiveDate = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("c3960abe-139b-4796-90ee-2bea6bf26474","","",false, this);
 
            Agent = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "05673858-3f60-4884-8287-06ad63114645","","",this);
 
            CommercialAgentSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("898a5328-be99-48e8-9391-2d4363ceed55","","",false, this);
 
            AgentGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "c2f754a6-7bc4-4c9b-98ae-7ebb3ab9e9ef","","",this);
 
            CommercialAgentCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("d283fcc9-27d6-464d-80b7-831af0818c10","","",false, this);
 
            GenericAgent = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "43bc89b5-eebe-47f4-84f0-7934fcce49f8","","",this);
 
            Customer = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "09fea032-cba6-4691-bfb2-0977499ddc82","","",this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("5d95a389-0163-4bc8-9d0d-8611d7a7b888","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "20de3b75-f6e1-4c26-96be-fd6ea9813ed5","","",this);
 
            CustomerCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("a79ffd58-9f10-4416-a449-cfb9321fe5d1","","",false, this);
 
            GenericCustomer = RPSControlFactory.CreateRPSOption<CommissionDefinitionByObjectiveSLVMQueryView>( "acdf86bb-184f-4ba0-8e28-275db6d57580","","",this);
 
            bProductLine = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("27028f19-f7aa-4669-abe8-8d60f930f699","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("39055cb5-86bb-4dae-b137-61192c92bef1","","",false, this);
 
            bProductFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("6d138379-fd8a-4150-ace9-a7ecdf22ec79","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("b6dc7812-0a05-4c5a-a04a-05b50a316d68","","",false, this);
 
            bProductSubFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("4d67b6af-ccf6-4d2c-bc4c-7d4850bd413c","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("7c29a07b-8a55-4d10-82fe-baf52dea54d4","","",false, this);
 
            bArticle = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("3a6a024f-b40c-4d16-9ac9-9e642b8908cd","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView>("09019fa1-1b87-44a4-9491-5b6347fd61e6","","",false, this);
 
            bAllArticles = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("08672799-b6d0-4b9c-918e-26b45163a01e","","",false, this);
 
            bMonthly = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("14962d76-6c32-4acf-a222-ea29408071b8","","",false, this);
 
            b2Monthly = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("c9a6e081-d79a-4e5f-8d4e-a84ef7539c49","","",false, this);
 
            b3Monthly = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("1313e29c-8e7e-4790-a04b-3fd9d121e2d7","","",false, this);
 
            b4Monthly = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("e165cc66-5cb6-448c-af07-c4cb233cbea5","","",false, this);
 
            b6Monthly = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("d57a370a-aa36-44b8-80f4-bed112107ae9","","",false, this);
 
            bAnual = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveSLVMQueryView>("047c3d4b-3f41-4f26-977c-d4ce6b594d37","","",false, this);
 
            CollectionInit params_CommissionDefinitionByObjectiveSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="688ed4ec-f37b-4694-b002-9938692165b5",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionByObjectiveSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionByObjectiveSLConsultCollectionEditor<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView>,CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView>( params_CommissionDefinitionByObjectiveSLConsult,this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 

        }
        public IRPSButton<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveSLVMQueryView> UIEffectiveDate { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> Agent { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView> CommercialAgentSL { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> AgentGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView> CommercialAgentCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> GenericAgent { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> Customer { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView> Customer1 { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> CustomerGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMQueryView> CustomerCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionByObjectiveSLVMQueryView> GenericCustomer { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bProductLine { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView> ProductLine { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bProductFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView> ProductFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bArticle { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByObjectiveSLVMQueryView> Article { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bAllArticles { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bMonthly { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> b2Monthly { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> b3Monthly { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> b4Monthly { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> b6Monthly { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveSLVMQueryView> bAnual { get; set; } 
        public CommissionDefinitionByObjectiveSLConsultCollectionEditor<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> CommissionDefinitionByObjectiveSLConsult { get; set; } 
        public CommissionDefinitionByObjectiveSL Screen { get; set; }
        public CommissionDefinitionByObjectiveSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionDefinitionByObjectiveSLConsultCollectionEditor<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView>:RPSCollectionEditor<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> where CommissionDefinitionByObjectiveSLVMQueryView : class, IView where CommissionDefinitionByObjectiveSLVMEntityView : class, IView
    {
        public  CommissionDefinitionByObjectiveSLConsultGridView<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> GridView {get;set;}
    }
    public partial class CommissionDefinitionByObjectiveSLConsultGridView <CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> :  RPSGridView<CommissionDefinitionByObjectiveSLVMQueryView,CommissionDefinitionByObjectiveSLVMEntityView> where CommissionDefinitionByObjectiveSLVMQueryView : class, IView where CommissionDefinitionByObjectiveSLVMEntityView : class, IView
    {
        public CommissionDefinitionByObjectiveSLConsultGridView(CommissionDefinitionByObjectiveSLVMQueryView currentView,CommissionDefinitionByObjectiveSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommissionDefinitionByObjectiveSL_ItemType = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("","#688ed4ec-f37b-4694-b002-9938692165b5 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByObjectiveSL_ItemType']","",false, this.CurrentView);
 
            CommissionDefinitionByObjectiveSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("","#688ed4ec-f37b-4694-b002-9938692165b5 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByObjectiveSL_DateFrom']","",false, this.CurrentView);
 
            CommissionDefinitionByObjectiveSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("","#688ed4ec-f37b-4694-b002-9938692165b5 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByObjectiveSL_DateTo']","",false, this.CurrentView);
 
            CommissionDefinitionByObjectiveSL_Periodicity = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("","#688ed4ec-f37b-4694-b002-9938692165b5 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByObjectiveSL_Periodicity']","",false, this.CurrentView);
 
            CommissionDefinitionByObjectiveSL_Type = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView>("","#688ed4ec-f37b-4694-b002-9938692165b5 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByObjectiveSL_Type']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView> CommissionDefinitionByObjectiveSL_ItemType { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView> CommissionDefinitionByObjectiveSL_DateFrom { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView> CommissionDefinitionByObjectiveSL_DateTo { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView> CommissionDefinitionByObjectiveSL_Periodicity { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMQueryView> CommissionDefinitionByObjectiveSL_Type { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionDefinitionByObjectiveSLVMEntityView : View
    {
        public CommissionDefinitionByObjectiveSLVMEntityView(CommissionDefinitionByObjectiveSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommissionDefinitionByObjectiveSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionByObjectiveSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveSLVMQueryView>( this,Screen.CommissionDefinitionByObjectiveSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveSLVMQueryView>( this,Screen.CommissionDefinitionByObjectiveSLVMQueryView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("96fe0d33-d886-459b-9fbe-34e0271e06e5","","",false, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("6ac149d6-eb3e-433a-b100-0573ce68eb10","","",false, this);
 
            IDCommercialAgentCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("7df7bd3d-c312-46d8-b375-d9a4eac1585a","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("c86ae543-c699-41b4-a515-d3964586b77b","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("a20238c2-62dc-4774-9447-d7087d14df0b","","",false, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("9135fc9c-ef24-4506-bdc3-c350c299509b","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("0406f996-d0c6-4df9-9536-c9de5e944e62","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("f67e0406-2730-4334-b91f-8d9a2214ebfd","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("13c58f86-5ac5-4e6c-a481-515b5a08b79b","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("ed200945-7959-45b5-ae91-c2e62d2bfa86","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("aa9337c2-9f17-47be-841c-4464e143a5ad","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("12331e41-51f0-4bfa-867e-82ed0781cd7b","","",true, this);
 
            Periodicity = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("01ff8cbe-9c01-4896-bbb5-1ba5c5e11e98","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("e4aa5b23-00a6-4c75-8000-36690ba2d95c","","",true, this);
 
            CollectionInit params_CommissionDefinitionByObjectiveDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2c7ae865-3348-43ce-ab6a-79ee513482bc",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionByObjectiveDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionByObjectiveDetailSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>,CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>( params_CommissionDefinitionByObjectiveDetailSLs,this,Screen.CommissionDefinitionByObjectiveDetailSLView);
 
            CollectionInit params_CommissionDefinitionByObjectivePeriodSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="92a4ff49-018d-4054-8b46-3a0c4c5628c1",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionByObjectivePeriodSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionByObjectivePeriodSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>,CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>( params_CommissionDefinitionByObjectivePeriodSLs,this,Screen.CommissionDefinitionByObjectiveDetailSLView);
 
            Details = RPSControlFactory.CreateRPSSection<CommissionDefinitionByObjectiveSLVMEntityView>( "","ul li[rpsid='cd11231b-795e-470a-a49b-557fe6e3b017']","",this);
 
            Periods = RPSControlFactory.CreateRPSSection<CommissionDefinitionByObjectiveSLVMEntityView>( "","ul li[rpsid='9b5ce120-16bc-40fc-b6b8-6223b9ecb4f0']","",this);
 

        }
        public IRPSSaveButton<CommissionDefinitionByObjectiveSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDCommercialAgentCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveSLVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> Periodicity { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectiveSLVMEntityView> Type { get; set; } 
        public CommissionDefinitionByObjectiveDetailSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> CommissionDefinitionByObjectiveDetailSLs { get; set; } 
        public CommissionDefinitionByObjectivePeriodSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> CommissionDefinitionByObjectivePeriodSLs { get; set; } 
        public IRPSSection<CommissionDefinitionByObjectiveSLVMEntityView> Details { get; set; } 
        public IRPSSection<CommissionDefinitionByObjectiveSLVMEntityView> Periods { get; set; } 
        public CommissionDefinitionByObjectiveSL Screen { get; set; }
        public CommissionDefinitionByObjectiveSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionDefinitionByObjectiveDetailSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>:RPSCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> where CommissionDefinitionByObjectiveSLVMEntityView : class, IView where CommissionDefinitionByObjectiveDetailSLView : class, IView
    {
        public  CommissionDefinitionByObjectiveDetailSLsGridView<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> GridView {get;set;}
    }
    public partial class CommissionDefinitionByObjectiveDetailSLsGridView <CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> :  RPSGridView<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> where CommissionDefinitionByObjectiveSLVMEntityView : class, IView where CommissionDefinitionByObjectiveDetailSLView : class, IView
    {
        public CommissionDefinitionByObjectiveDetailSLsGridView(CommissionDefinitionByObjectiveSLVMEntityView currentView,CommissionDefinitionByObjectiveDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            From = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#2c7ae865-3348-43ce-ab6a-79ee513482bc .ag-row[role='row']@ROWINDEX [col-id='cFrom']","",true, this.CurrentView);
 
            Cascade = RPSControlFactory.CreateRPSGridCheckBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#2c7ae865-3348-43ce-ab6a-79ee513482bc .ag-row[role='row']@ROWINDEX [col-id='cCascade']","",true, this.CurrentView);
 
            CommissionPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#2c7ae865-3348-43ce-ab6a-79ee513482bc .ag-row[role='row']@ROWINDEX [col-id='cCommissionPercent']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#2c7ae865-3348-43ce-ab6a-79ee513482bc .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView> From { get; set; } 
        public IRPSGridCheckbox<CommissionDefinitionByObjectiveSLVMEntityView> Cascade { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView> CommissionPercent { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView> CommissionAmount { get; set; } 
                     
    }
 
        public partial class CommissionDefinitionByObjectivePeriodSLsCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView>:RPSCollectionEditor<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> where CommissionDefinitionByObjectiveSLVMEntityView : class, IView where CommissionDefinitionByObjectiveDetailSLView : class, IView
    {
        public  CommissionDefinitionByObjectivePeriodSLsGridView<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> GridView {get;set;}
    }
    public partial class CommissionDefinitionByObjectivePeriodSLsGridView <CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> :  RPSGridView<CommissionDefinitionByObjectiveSLVMEntityView,CommissionDefinitionByObjectiveDetailSLView> where CommissionDefinitionByObjectiveSLVMEntityView : class, IView where CommissionDefinitionByObjectiveDetailSLView : class, IView
    {
        public CommissionDefinitionByObjectivePeriodSLsGridView(CommissionDefinitionByObjectiveSLVMEntityView currentView,CommissionDefinitionByObjectiveDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#92a4ff49-018d-4054-8b46-3a0c4c5628c1 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#92a4ff49-018d-4054-8b46-3a0c4c5628c1 .ag-row[role='row']@ROWINDEX [col-id='cLastCalculationDate']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<CommissionDefinitionByObjectiveSLVMEntityView>("","#92a4ff49-018d-4054-8b46-3a0c4c5628c1 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByObjectiveSLVMEntityView> LastCalculationDate { get; set; } 
        public IRPSGridComboBox<CommissionDefinitionByObjectiveSLVMEntityView> Status { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionDefinitionByObjectiveDetailSLView : View
    {
        public CommissionDefinitionByObjectiveDetailSLView(CommissionDefinitionByObjectiveSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionByObjectiveDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            From = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByObjectiveDetailSLView>("d385beb7-66c5-44d6-8aeb-8a4c44e1920e","","",true, this);
 
            CommissionPercent = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByObjectiveDetailSLView>("a442bafa-12c1-4256-9e5a-e44832185ef0","","",true, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByObjectiveDetailSLView>("5efaa2c0-e38e-4df3-984e-1a2a8023939c","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByObjectiveDetailSLView>("08b7f781-a539-4bb7-ba74-83d3b7735d26","","",true, this);
 

        }
        public IRPSButton<CommissionDefinitionByObjectiveDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CommissionDefinitionByObjectiveDetailSLView,CommissionDefinitionByObjectiveSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveDetailSLView> From { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveDetailSLView> CommissionPercent { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByObjectiveDetailSLView> Cascade { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectiveDetailSLView> CommissionAmount { get; set; } 
        public CommissionDefinitionByObjectiveSL Screen { get; set; }
        public CommissionDefinitionByObjectiveDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommissionDefinitionByObjectivePeriodSLView : View
    {
        public CommissionDefinitionByObjectivePeriodSLView(CommissionDefinitionByObjectiveSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionByObjectivePeriodSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView>( this,Screen.CommissionDefinitionByObjectiveSLVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionByObjectivePeriodSLView>("db547d24-78c6-4e47-8272-777e4f93cfb5","","",false, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<CommissionDefinitionByObjectivePeriodSLView>("3568ed7c-49a3-45af-8629-a4a7bfb574e3","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByObjectivePeriodSLView>("b9894c8f-29f0-400e-a91d-63fbc1e5864f","","",true, this);
 

        }
        public IRPSButton<CommissionDefinitionByObjectivePeriodSLView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CommissionDefinitionByObjectivePeriodSLView,CommissionDefinitionByObjectiveSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectivePeriodSLView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionDefinitionByObjectivePeriodSLView> LastCalculationDate { get; set; } 
        public IRPSComboBox<CommissionDefinitionByObjectivePeriodSLView> Status { get; set; } 
        public CommissionDefinitionByObjectiveSL Screen { get; set; }
        public CommissionDefinitionByObjectivePeriodSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
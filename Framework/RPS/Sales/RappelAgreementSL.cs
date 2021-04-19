    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.RappelAgreementSL
{
    //RPS VERSION 1.0.0.0
    public partial class RappelAgreementSL:Screen
    {
        public RappelAgreementSL():base()
        {
            this.URL = "sales.rappelagreementsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RappelAgreementSLVMQueryView  = new RappelAgreementSLVMQueryView(this); 
            RappelAgreementSLVMEntityView  = new RappelAgreementSLVMEntityView(this); 
            RappelSLView  = new RappelSLView(this); 
            RappelAgreementItemSLView  = new RappelAgreementItemSLView(this); 
            RappelAgreementSLFromCopyChildDialogView  = new RappelAgreementSLFromCopyChildDialogView(this); 
            RappelAgreementSLVMQueryView.InitializeControls(); 
            RappelAgreementSLVMEntityView.InitializeControls(); 
            RappelSLView.InitializeControls(); 
            RappelAgreementItemSLView.InitializeControls(); 
            RappelAgreementSLFromCopyChildDialogView.InitializeControls(); 
           
        }
      
            public RappelAgreementSLVMQueryView RappelAgreementSLVMQueryView {get; set; } 
            public RappelAgreementSLVMEntityView RappelAgreementSLVMEntityView {get; set; } 
            public RappelSLView RappelSLView {get; set; } 
            public RappelAgreementItemSLView RappelAgreementItemSLView {get; set; } 
            public RappelAgreementSLFromCopyChildDialogView RappelAgreementSLFromCopyChildDialogView {get; set; } 
    }
            
    public partial class RappelAgreementSLVMQueryView : View
    {
        public RappelAgreementSLVMQueryView(RappelAgreementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<RappelAgreementSLVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMQueryView>("900a4ca0-f54c-45b0-85c7-009c97e95c12","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<RappelAgreementSLVMQueryView>( "4ee9d244-a28f-4cec-abf0-53838c7e6084","","",this);
 
            UIlsIDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<RappelAgreementSLVMQueryView>("ebc4db6d-1ef6-40b7-a4c0-61c0a4aceb01","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<RappelAgreementSLVMQueryView>( "a951f398-1c40-4cb6-9096-5c8a26342157","","",this);
 
            UIlsIDCustomerGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<RappelAgreementSLVMQueryView>("23ec93da-419d-48e3-8e5a-8fedb104ac6c","","",false, this);
 
            Monthly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("edbed515-c397-4f8e-9cf1-d474bd15ced0","","",false, this);
 
            Bimonthly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("f333f0bd-fd93-4988-be0d-46af4f1fc8f8","","",false, this);
 
            Quarterly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("f2c34617-961a-418f-87c6-ecf89d7167c6","","",false, this);
 
            FourMonthPeriod = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("92987368-370a-49b4-9109-46adb5e5489b","","",false, this);
 
            HalfYearly = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("447bb799-9bdb-43fd-bab0-9500b648fb7e","","",false, this);
 
            Annual = RPSControlFactory.CreateRPSCheckBox<RappelAgreementSLVMQueryView>("bbc14c25-efb8-4c5c-90b5-7a296da0e248","","",false, this);
 
            CollectionInit params_RappelAgreementSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ced3c0c0-91eb-4204-85ce-b75c4284af39",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementSLConsultCollectionEditor<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView>,RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView>( params_RappelAgreementSLConsult,this,Screen.RappelAgreementSLVMEntityView);
 

        }
        public IRPSButton<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<RappelAgreementSLVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMQueryView> UIActiveDate { get; set; } 
        public IRPSOption<RappelAgreementSLVMQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<RappelAgreementSLVMQueryView> UIlsIDCustomer { get; set; } 
        public IRPSOption<RappelAgreementSLVMQueryView> CustomerGroup { get; set; } 
        public IRPSCollectionComboBox<RappelAgreementSLVMQueryView> UIlsIDCustomerGroupSL { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> Monthly { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> Bimonthly { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> Quarterly { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> FourMonthPeriod { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> HalfYearly { get; set; } 
        public IRPSCheckbox<RappelAgreementSLVMQueryView> Annual { get; set; } 
        public RappelAgreementSLConsultCollectionEditor<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> RappelAgreementSLConsult { get; set; } 
        public RappelAgreementSL Screen { get; set; }
        public RappelAgreementSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelAgreementSLConsultCollectionEditor<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView>:RPSCollectionEditor<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> where RappelAgreementSLVMQueryView : class, IView where RappelAgreementSLVMEntityView : class, IView
    {
        public  RappelAgreementSLConsultGridView<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> GridView {get;set;}
    }
    public partial class RappelAgreementSLConsultGridView <RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> :  RPSGridView<RappelAgreementSLVMQueryView,RappelAgreementSLVMEntityView> where RappelAgreementSLVMQueryView : class, IView where RappelAgreementSLVMEntityView : class, IView
    {
        public RappelAgreementSLConsultGridView(RappelAgreementSLVMQueryView currentView,RappelAgreementSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RappelAgreementSL_CodRappelAgreement = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_CodRappelAgreement']","",false, this.CurrentView);
 
            RappelAgreementSL_DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateFrom']","",false, this.CurrentView);
 
            RappelAgreementSL_DateTo = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_DateTo']","",false, this.CurrentView);
 
            RappelAgreementSL_RappelType = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_RappelType']","",false, this.CurrentView);
 
            RappelAgreementSL_Periodicity = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Periodicity']","",false, this.CurrentView);
 
            RappelAgreementSL_MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_MinimunValue']","",false, this.CurrentView);
 
            RappelAgreementSL_Percentage_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementSLVMQueryView>("","#ced3c0c0-91eb-4204-85ce-b75c4284af39 .ag-row[role='row']@ROWINDEX [col-id='cRappelAgreementSL_Percentage_Amount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_CodRappelAgreement { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_DateFrom { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_DateTo { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_RappelType { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_Periodicity { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_MinimunValue { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMQueryView> RappelAgreementSL_Percentage_Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelAgreementSLVMEntityView : View
    {
        public RappelAgreementSLVMEntityView(RappelAgreementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RappelAgreementSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelAgreementSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelAgreementSLVMEntityView,RappelAgreementSLVMQueryView>( this,Screen.RappelAgreementSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelAgreementSLVMEntityView,RappelAgreementSLVMQueryView>( this,Screen.RappelAgreementSLVMQueryView);
 
            CodRappelAgreement = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("55a7c32a-5861-4b27-9293-6636b8eab615","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("4bb08d24-381d-4123-8146-60c58fa5bb96","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("05b8fcc7-f422-4648-963e-f4ce974065c8","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("0e185d1a-d645-438b-92d5-84c0a7f2ec02","","",true, this);
 
            RappelAgreementType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementSLVMEntityView>("c8cad65c-8a6c-45fc-82e1-0cd5cbff42dc","","",true, this);
 
            IDItemCustomer = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("95d0aabc-0037-410d-a528-f57be6e11a4b","","",false, this);
 
            IDCustomerGroup = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("a5df989b-7f12-4265-8ce1-23ead3ed15ef","","",false, this);
 
            IDItemCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("90a78a3b-f2f3-436b-a90f-52e66ddd2b57","","",false, this);
 
            Periodicity = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementSLVMEntityView>("2418556e-2fca-45a1-aa4e-994f8c12538e","","",true, this);
 
            BaseApply = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementSLVMEntityView>("197ae13f-2681-4166-8b34-0957a9328a70","","",true, this);
 
            RappelType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementSLVMEntityView>("cf746cdd-8756-49c6-bbf3-9a10dcd8bc8b","","",true, this);
 
            MinimunValue = RPSControlFactory.CreateRPSFormattedTextBox<RappelAgreementSLVMEntityView>("5e1d3722-2d7a-4d57-8bf3-219d8f0afccd","","",true, this);
 
            Percentage_Amount = RPSControlFactory.CreateRPSFormattedTextBox<RappelAgreementSLVMEntityView>("f8798e97-ea04-4694-8a29-8e1a5e73ed60","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementSLVMEntityView>("ebb86b64-b8e6-4c25-9330-e8fd4cf52f72","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("bc664489-59c6-4259-b8c2-6366529e7efe","","",true, this);
 
            IDFacDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("9a8b176d-af72-4a80-ae45-f0cb456f7c19","","",false, this);
 
            IDPurDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("9e956cbf-97a6-482b-ac47-2fb435fd7d25","","",false, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("3e778ab4-1e13-4799-b736-ffc4d448ee4e","","",false, this);
 
            IDCommercialCondition = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("9a8dc7eb-fe34-43c7-8966-aadd63b81228","","",false, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("a5c072a7-ea59-4add-b7de-6796f8a2229a","","",false, this);
 
            IDCustomerCommercialCondition = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("3bed5c86-6658-43fc-a8f6-001f8ad649a3","","",false, this);
 
            IDCommercialConditionGroupDetail = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLVMEntityView>("1e2834a9-6390-4b24-abfe-a952967d814e","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLVMEntityView>("3daec99c-c615-45cb-b057-8156e43a78c3","","",false, this);
 
            GenerateRappelsCommandButton = RPSControlFactory.CreateRPSButton<RappelAgreementSLVMEntityView>( "f3d9ccfa-84cb-4d8b-a725-2be99739be1c","","",this);
 
            RappelAgreementSLFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RappelAgreementSLVMEntityView,RappelAgreementSLFromCopyChildDialogView>("370ed53e-c7e0-4e65-8778-8b01c0a60b7b","","", this,Screen.RappelAgreementSLFromCopyChildDialogView);
 
            CollectionInit params_CommercialConditionGroupDetailSLWithoutConditionGroup = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            CommercialConditionGroupDetailSLWithoutConditionGroup = RPSControlFactory.RPSCreateCollection<RappelAgreementSLVMEntityView,RappelAgreementItemSLView>( params_CommercialConditionGroupDetailSLWithoutConditionGroup,this,Screen.RappelAgreementItemSLView);
 
            CollectionInit params_RappelSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="916eb127-41d9-40a1-b6d6-1c8a51644323",CSSSelectorGrid="",XPathGrid=""};
            RappelSLs = RPSControlFactory.RPSCreateCollectionWithGrid<RappelSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView>,RappelAgreementSLVMEntityView,RappelAgreementItemSLView>( params_RappelSLs,this,Screen.RappelAgreementItemSLView);
 
            CollectionInit params_RappelAgreementItemSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="827d115c-f4ab-48b3-94d7-508cf89b5d5a",CSSSelectorGrid="",XPathGrid=""};
            RappelAgreementItemSLs = RPSControlFactory.RPSCreateCollectionWithGrid<RappelAgreementItemSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView>,RappelAgreementSLVMEntityView,RappelAgreementItemSLView>( params_RappelAgreementItemSLs,this,Screen.RappelAgreementItemSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<RappelAgreementSLVMEntityView>( "","ul li[rpsid='62cacd21-f79c-472f-9412-5ebc2f125517']","",this);
 
            Rappels = RPSControlFactory.CreateRPSSection<RappelAgreementSLVMEntityView>( "","ul li[rpsid='ba2f0f60-faa4-4536-b670-6527cb258fc2']","",this);
 
            RappelItem = RPSControlFactory.CreateRPSSection<RappelAgreementSLVMEntityView>( "","ul li[rpsid='54d4158b-6892-407d-9083-bba911c89ea5']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<RappelAgreementSLVMEntityView>( "","ul li[rpsid='f006afbf-e89e-484c-acc0-768be8d27690']","",this);
 

        }
        public IRPSSaveButton<RappelAgreementSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<RappelAgreementSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<RappelAgreementSLVMEntityView,RappelAgreementSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelAgreementSLVMEntityView,RappelAgreementSLVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> CodRappelAgreement { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> Description { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> DateTo { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> RappelAgreementType { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDItemCustomer { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDCustomerGroup { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDItemCustomerGroupValue { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> Periodicity { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> BaseApply { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> RappelType { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> MinimunValue { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> Percentage_Amount { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> DocumentType { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDFacDeliveryNoteTypeSL { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDPurDeliveryNoteType { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> LastCalculationDate { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDCommercialCondition { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDCommercialConcept { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDCustomerCommercialCondition { get; set; } 
        public IRPSComboBox<RappelAgreementSLVMEntityView> IDCommercialConditionGroupDetail { get; set; } 
        public IRPSTextBox<RappelAgreementSLVMEntityView> Comment { get; set; } 
        public IRPSButton<RappelAgreementSLVMEntityView> GenerateRappelsCommandButton { get; set; } 
        public IRPSButton<RappelAgreementSLVMEntityView,RappelAgreementSLFromCopyChildDialogView> RappelAgreementSLFromCopyChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> CommercialConditionGroupDetailSLWithoutConditionGroup { get; set; } 
        public RappelSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> RappelSLs { get; set; } 
        public RappelAgreementItemSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> RappelAgreementItemSLs { get; set; } 
        public IRPSSection<RappelAgreementSLVMEntityView> GeneralData { get; set; } 
        public IRPSSection<RappelAgreementSLVMEntityView> Rappels { get; set; } 
        public IRPSSection<RappelAgreementSLVMEntityView> RappelItem { get; set; } 
        public IRPSSection<RappelAgreementSLVMEntityView> Comments { get; set; } 
        public RappelAgreementSL Screen { get; set; }
        public RappelAgreementSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView>:RPSCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> where RappelAgreementSLVMEntityView : class, IView where RappelAgreementItemSLView : class, IView
    {
        public  RappelSLsGridView<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> GridView {get;set;}
    }
    public partial class RappelSLsGridView <RappelAgreementSLVMEntityView,RappelAgreementItemSLView> :  RPSGridView<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> where RappelAgreementSLVMEntityView : class, IView where RappelAgreementItemSLView : class, IView
    {
        public RappelSLsGridView(RappelAgreementSLVMEntityView currentView,RappelAgreementItemSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            LastCalculationDate = RPSControlFactory.CreateRPSGridTextBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cLastCalculationDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementSLVMEntityView>("","#916eb127-41d9-40a1-b6d6-1c8a51644323 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<RappelAgreementSLVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMEntityView> LastCalculationDate { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMEntityView> Base { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<RappelAgreementSLVMEntityView> Quantity { get; set; } 
        public IRPSGridComboBox<RappelAgreementSLVMEntityView> Status { get; set; } 
                     
    }
 
        public partial class RappelAgreementItemSLsCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView>:RPSCollectionEditor<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> where RappelAgreementSLVMEntityView : class, IView where RappelAgreementItemSLView : class, IView
    {
        public  RappelAgreementItemSLsGridView<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> GridView {get;set;}
    }
    public partial class RappelAgreementItemSLsGridView <RappelAgreementSLVMEntityView,RappelAgreementItemSLView> :  RPSGridView<RappelAgreementSLVMEntityView,RappelAgreementItemSLView> where RappelAgreementSLVMEntityView : class, IView where RappelAgreementItemSLView : class, IView
    {
        public RappelAgreementItemSLsGridView(RappelAgreementSLVMEntityView currentView,RappelAgreementItemSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ItemType = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementSLVMEntityView>("","#827d115c-f4ab-48b3-94d7-508cf89b5d5a .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<RappelAgreementSLVMEntityView>("","#827d115c-f4ab-48b3-94d7-508cf89b5d5a .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IncludeExclude = RPSControlFactory.CreateRPSGridEnumComboBox<RappelAgreementSLVMEntityView>("","#827d115c-f4ab-48b3-94d7-508cf89b5d5a .ag-row[role='row']@ROWINDEX [col-id='cIncludeExclude']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<RappelAgreementSLVMEntityView> ItemType { get; set; } 
        public IRPSGridComboBox<RappelAgreementSLVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<RappelAgreementSLVMEntityView> IncludeExclude { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelSLView : View
    {
        public RappelSLView(RappelAgreementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RappelSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RappelSLView>("01cbf82b-051d-4b89-86eb-5e8276f18c63","","",true, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<RappelSLView>("4320d46d-5f10-40ad-bcb9-16f4fb9f29fd","","",false, this);
 
            Base = RPSControlFactory.CreateRPSFormattedTextBox<RappelSLView>("248aa538-4404-4aca-ae26-a663c9d4f21c","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RappelSLView>("fde8adae-60b8-4d90-afe6-b479f1dee7bb","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<RappelSLView>("f2bbe4f4-f61a-4c6e-8102-46551ccd279a","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<RappelSLView>("2f89f4b1-8cef-47fc-8af1-0899c031bf8c","","",true, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<RappelSLView>("0293b5e8-eb79-442d-ac20-b3abf7659a63","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<RappelSLView>("34a81b9f-7777-4129-912f-e66117d89767","","",false, this);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSTextBox<RappelSLView>("3680d39f-49fc-4fcf-bf57-7222353299a7","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<RappelSLView>("bce384bd-ae86-4b74-9b57-0d6376064721","","",false, this);
 
            CollectionInit params_RappelArticleSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="50d2ef22-9ad2-4150-956c-6542f426cfa4",CSSSelectorGrid="",XPathGrid=""};
            RappelArticleSLs = RPSControlFactory.RPSCreateCollectionWithGrid<RappelArticleSLsCollectionEditor<RappelSLView>,RappelSLView>( params_RappelArticleSLs,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<RappelSLView>( "","ul li[rpsid='810f4d95-88b3-4526-97cd-8f0e62eaf517']","",this);
 
            RapplesArticle = RPSControlFactory.CreateRPSSection<RappelSLView>( "","ul li[rpsid='f6a52b22-e0c9-47c6-abb2-741d3e7d5471']","",this);
 

        }
        public IRPSButton<RappelSLView> DeleteButton { get; set; } 
        public IRPSButton<RappelSLView,RappelAgreementSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelSLView,RappelAgreementSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RappelSLView,RappelAgreementSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<RappelSLView> DateFrom { get; set; } 
        public IRPSTextBox<RappelSLView> LastCalculationDate { get; set; } 
        public IRPSTextBox<RappelSLView> Base { get; set; } 
        public IRPSTextBox<RappelSLView> Amount { get; set; } 
        public IRPSTextBox<RappelSLView> Quantity { get; set; } 
        public IRPSComboBox<RappelSLView> Status { get; set; } 
        public IRPSTextBox<RappelSLView> CodOrder { get; set; } 
        public IRPSTextBox<RappelSLView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<RappelSLView> CodMerchandiseGift { get; set; } 
        public IRPSComboBox<RappelSLView> IDCustomer { get; set; } 
        public RappelArticleSLsCollectionEditor<RappelSLView> RappelArticleSLs { get; set; } 
        public IRPSSection<RappelSLView> GeneralData { get; set; } 
        public IRPSSection<RappelSLView> RapplesArticle { get; set; } 
        public RappelAgreementSL Screen { get; set; }
        public RappelSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RappelArticleSLsCollectionEditor<RappelSLView>:RPSCollectionEditor<RappelSLView> where RappelSLView : class, IView
    {
        public  RappelArticleSLsGridView<RappelSLView> GridView {get;set;}
    }
    public partial class RappelArticleSLsGridView <RappelSLView> :  RPSGridView<RappelSLView> where RappelSLView : class, IView
    {
        public RappelArticleSLsGridView(RappelSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<RappelSLView>("","#50d2ef22-9ad2-4150-956c-6542f426cfa4 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<RappelSLView>("","#50d2ef22-9ad2-4150-956c-6542f426cfa4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<RappelSLView>("","#50d2ef22-9ad2-4150-956c-6542f426cfa4 .ag-row[role='row']@ROWINDEX [col-id='cCodMerchandiseGift']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<RappelSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<RappelSLView> Quantity { get; set; } 
        public IRPSGridTextBox<RappelSLView> CodMerchandiseGift { get; set; } 
                     
    }
 
    }
  
            
    public partial class RappelAgreementItemSLView : View
    {
        public RappelAgreementItemSLView(RappelAgreementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<RappelAgreementItemSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView>( this,Screen.RappelAgreementSLVMEntityView);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementItemSLView>("499bd60e-2fc9-4be0-8b17-ca842c76a5ef","","",true, this);
 
            IDItemProductLine = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemSLView>("35d4716e-8ce1-4a97-abd7-c0b3d58007cd","","",false, this);
 
            IDItemProductFamily = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemSLView>("c2cd4b07-17fe-4164-b16e-6a70d67c01c1","","",false, this);
 
            IDItemProductSubFamily = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemSLView>("47fc5eac-3356-4158-a720-2577a64fb6c9","","",false, this);
 
            IDItemArticle = RPSControlFactory.CreateRPSComboBox<RappelAgreementItemSLView>("c4f17ae5-0ef0-4262-9301-5a451715b632","","",false, this);
 
            IncludeExclude = RPSControlFactory.CreateRPSEnumComboBox<RappelAgreementItemSLView>("75a68573-6f99-4548-819b-7755e487122f","","",true, this);
 

        }
        public IRPSButton<RappelAgreementItemSLView> DeleteButton { get; set; } 
        public IRPSButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<RappelAgreementItemSLView,RappelAgreementSLVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> ItemType { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> IDItemProductLine { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> IDItemProductFamily { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> IDItemProductSubFamily { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> IDItemArticle { get; set; } 
        public IRPSComboBox<RappelAgreementItemSLView> IncludeExclude { get; set; } 
        public RappelAgreementSL Screen { get; set; }
        public RappelAgreementItemSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RappelAgreementSLFromCopyChildDialogView : View
    {
        public RappelAgreementSLFromCopyChildDialogView(RappelAgreementSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewIDItemCustomer = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLFromCopyChildDialogView>("c319606b-7d9b-43dd-a8c9-72fba8c400f7","","",false, this);
 
            NewIDCustomerGroup = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLFromCopyChildDialogView>("d765c923-e00f-4967-8307-be361745ff1a","","",false, this);
 
            NewIDItemCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<RappelAgreementSLFromCopyChildDialogView>("2b3b0455-a6b5-4605-a007-34303cc7970e","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<RappelAgreementSLFromCopyChildDialogView>("01357a95-e5e7-4ce3-8f27-bda92b974800","","",true, this);
 

        }
        public IRPSComboBox<RappelAgreementSLFromCopyChildDialogView> NewIDItemCustomer { get; set; } 
        public IRPSComboBox<RappelAgreementSLFromCopyChildDialogView> NewIDCustomerGroup { get; set; } 
        public IRPSComboBox<RappelAgreementSLFromCopyChildDialogView> NewIDItemCustomerGroupValue { get; set; } 
        public IRPSTextBox<RappelAgreementSLFromCopyChildDialogView> NewCode { get; set; } 
        public RappelAgreementSL Screen { get; set; }
        public RappelAgreementSLFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
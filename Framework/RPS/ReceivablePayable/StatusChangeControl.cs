    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.StatusChangeControl
{
    //RPS VERSION 1.0.0.0
    public partial class StatusChangeControl:Screen
    {
        public StatusChangeControl():base()
        {
            this.URL = "receivablepayable.statuschangecontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatusChangeControlVMQueryView  = new StatusChangeControlVMQueryView(this); 
            StatusChangeControlVMEntityView  = new StatusChangeControlVMEntityView(this); 
            StatusChangeControlDetailView  = new StatusChangeControlDetailView(this); 
            ConceptExtensionDialogView  = new ConceptExtensionDialogView(this); 
            AccountFormulatedChildDialogView  = new AccountFormulatedChildDialogView(this); 
            AmountFormulaChildDialogView  = new AmountFormulaChildDialogView(this); 
            StatusChangeControlVMQueryView.InitializeControls(); 
            StatusChangeControlVMEntityView.InitializeControls(); 
            StatusChangeControlDetailView.InitializeControls(); 
            ConceptExtensionDialogView.InitializeControls(); 
            AccountFormulatedChildDialogView.InitializeControls(); 
            AmountFormulaChildDialogView.InitializeControls(); 
           
        }
      
            public StatusChangeControlVMQueryView StatusChangeControlVMQueryView {get; set; } 
            public StatusChangeControlVMEntityView StatusChangeControlVMEntityView {get; set; } 
            public StatusChangeControlDetailView StatusChangeControlDetailView {get; set; } 
            public ConceptExtensionDialogView ConceptExtensionDialogView {get; set; } 
            public AccountFormulatedChildDialogView AccountFormulatedChildDialogView {get; set; } 
            public AmountFormulaChildDialogView AmountFormulaChildDialogView {get; set; } 
    }
            
    public partial class StatusChangeControlVMQueryView : View
    {
        public StatusChangeControlVMQueryView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView>( this,Screen.StatusChangeControlVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<StatusChangeControlVMQueryView>( this);
 
            ListIdPaymentTypeFrom = RPSControlFactory.CreateRPSCollectionComboBox<StatusChangeControlVMQueryView>("cfc79a06-6998-425a-9946-771b209dc2a5","","",false, this);
 
            ListIdPaymentStatusFrom = RPSControlFactory.CreateRPSCollectionComboBox<StatusChangeControlVMQueryView>("06dac63a-12ef-48de-949f-55d9955e8416","","",false, this);
 
            ListIdPaymentTypeTo = RPSControlFactory.CreateRPSCollectionComboBox<StatusChangeControlVMQueryView>("84d6214b-4cda-4e40-8d38-255010ce8e1f","","",false, this);
 
            ListIdPaymentStatusTo = RPSControlFactory.CreateRPSCollectionComboBox<StatusChangeControlVMQueryView>("f6d37b9b-e18e-4d26-ba32-e6fd5714873c","","",false, this);
 
            CollectionInit params_GetStatusChangeControl = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c730213a-5818-4426-8c10-5633321b3f72",CSSSelectorGrid="",XPathGrid=""};
            GetStatusChangeControl = RPSControlFactory.RPSCreateCollectionWithGrid<GetStatusChangeControlCollectionEditor<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView>,StatusChangeControlVMQueryView,StatusChangeControlVMEntityView>( params_GetStatusChangeControl,this,Screen.StatusChangeControlVMEntityView);
 

        }
        public IRPSButton<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> NewButton { get; set; } 
        public IRPSButton<StatusChangeControlVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<StatusChangeControlVMQueryView> ListIdPaymentTypeFrom { get; set; } 
        public IRPSCollectionComboBox<StatusChangeControlVMQueryView> ListIdPaymentStatusFrom { get; set; } 
        public IRPSCollectionComboBox<StatusChangeControlVMQueryView> ListIdPaymentTypeTo { get; set; } 
        public IRPSCollectionComboBox<StatusChangeControlVMQueryView> ListIdPaymentStatusTo { get; set; } 
        public GetStatusChangeControlCollectionEditor<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> GetStatusChangeControl { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public StatusChangeControlVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetStatusChangeControlCollectionEditor<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView>:RPSCollectionEditor<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> where StatusChangeControlVMQueryView : class, IView where StatusChangeControlVMEntityView : class, IView
    {
        public  GetStatusChangeControlGridView<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> GridView {get;set;}
    }
    public partial class GetStatusChangeControlGridView <StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> :  RPSGridView<StatusChangeControlVMQueryView,StatusChangeControlVMEntityView> where StatusChangeControlVMQueryView : class, IView where StatusChangeControlVMEntityView : class, IView
    {
        public GetStatusChangeControlGridView(StatusChangeControlVMQueryView currentView,StatusChangeControlVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StatusChangeControl_AccPosting = RPSControlFactory.CreateRPSGridCheckBox<StatusChangeControlVMQueryView>("","#c730213a-5818-4426-8c10-5633321b3f72 .ag-row[role='row']@ROWINDEX [col-id='cStatusChangeControl_AccPosting']","",false, this.CurrentView);
 
            StatusChangeControl_RegisterChangeHistory = RPSControlFactory.CreateRPSGridCheckBox<StatusChangeControlVMQueryView>("","#c730213a-5818-4426-8c10-5633321b3f72 .ag-row[role='row']@ROWINDEX [col-id='cStatusChangeControl_RegisterChangeHistory']","",false, this.CurrentView);
 
            StatusChangeControl_CreateEvidence = RPSControlFactory.CreateRPSGridCheckBox<StatusChangeControlVMQueryView>("","#c730213a-5818-4426-8c10-5633321b3f72 .ag-row[role='row']@ROWINDEX [col-id='cStatusChangeControl_CreateEvidence']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<StatusChangeControlVMQueryView> StatusChangeControl_AccPosting { get; set; } 
        public IRPSGridCheckbox<StatusChangeControlVMQueryView> StatusChangeControl_RegisterChangeHistory { get; set; } 
        public IRPSGridCheckbox<StatusChangeControlVMQueryView> StatusChangeControl_CreateEvidence { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusChangeControlVMEntityView : View
    {
        public StatusChangeControlVMEntityView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StatusChangeControlVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusChangeControlVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusChangeControlVMEntityView,StatusChangeControlVMQueryView>( this,Screen.StatusChangeControlVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusChangeControlVMEntityView,StatusChangeControlVMQueryView>( this,Screen.StatusChangeControlVMQueryView);
 
            IDPaymentTypeFrom = RPSControlFactory.CreateRPSComboBox<StatusChangeControlVMEntityView>("dad92c4d-3835-4e09-ad17-e770f03aa37f","","",true, this);
 
            IDPaymentStatusFrom = RPSControlFactory.CreateRPSComboBox<StatusChangeControlVMEntityView>("20a80bb3-3226-4d10-84d0-05fe56ad14d2","","",true, this);
 
            IDPaymentTypeTo = RPSControlFactory.CreateRPSComboBox<StatusChangeControlVMEntityView>("edb3fd73-27dc-4fe4-bf15-5e1816b506c4","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<StatusChangeControlVMEntityView>("ea7b3c23-f787-48b0-9ed5-3816c21267be","","",true, this);
 
            AccPosting = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("e1d3c0ba-46d6-4749-9074-e42459d9f032","","",true, this);
 
            RegisterChangeHistory = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("807c8198-495c-4730-8ddc-e2f7e978930e","","",true, this);
 
            UpdateCollectionDate = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("3147f258-4ff1-4d63-95bc-316e17d0d25d","","",false, this);
 
            UpdateCDUsed = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlVMEntityView>("8723137e-63b5-44f0-9e7e-1d0413cf8499","","",true, this);
 
            UpdateAmountCollection = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlVMEntityView>("4bd3d15e-4fa1-491c-bd5d-88824db83c79","","",true, this);
 
            UpdateAmountUnpaid = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlVMEntityView>("877aaa38-50b7-44dc-85d0-40e07dedbbf2","","",true, this);
 
            CreateEvidence = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("2600ce3e-df5c-4c67-a063-3fa69b1b648d","","",true, this);
 
            BreakEvidenceByThird = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("1af5484c-deb8-4e6d-b09a-dc16b33a3e4e","","",true, this);
 
            EvidenceAsReference = RPSControlFactory.CreateRPSCheckBox<StatusChangeControlVMEntityView>("8cc913c1-f92a-4a80-bfaa-69b0c1685894","","",true, this);
 
            IDCodingSeriesEvidence = RPSControlFactory.CreateRPSComboBox<StatusChangeControlVMEntityView>("5b617fb5-deac-45f7-aa78-1eaa7f905e89","","",false, this);
 
            CollectionInit params_StatusChangeControlDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="59821d99-1a03-48e2-888f-0907728a43e8",CSSSelectorGrid="",XPathGrid=""};
            StatusChangeControlDetails = RPSControlFactory.RPSCreateCollectionWithGrid<StatusChangeControlDetailsCollectionEditor<StatusChangeControlVMEntityView,StatusChangeControlDetailView>,StatusChangeControlVMEntityView,StatusChangeControlDetailView>( params_StatusChangeControlDetails,this,Screen.StatusChangeControlDetailView);
 

        }
        public IRPSSaveButton<StatusChangeControlVMEntityView> SaveButton { get; set; } 
        public IRPSButton<StatusChangeControlVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<StatusChangeControlVMEntityView,StatusChangeControlVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusChangeControlVMEntityView,StatusChangeControlVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> IDPaymentTypeFrom { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> IDPaymentStatusFrom { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> IDPaymentTypeTo { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> IDPaymentStatusTo { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> AccPosting { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> RegisterChangeHistory { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> UpdateCollectionDate { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> UpdateCDUsed { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> UpdateAmountCollection { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> UpdateAmountUnpaid { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> CreateEvidence { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> BreakEvidenceByThird { get; set; } 
        public IRPSCheckbox<StatusChangeControlVMEntityView> EvidenceAsReference { get; set; } 
        public IRPSComboBox<StatusChangeControlVMEntityView> IDCodingSeriesEvidence { get; set; } 
        public StatusChangeControlDetailsCollectionEditor<StatusChangeControlVMEntityView,StatusChangeControlDetailView> StatusChangeControlDetails { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public StatusChangeControlVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StatusChangeControlDetailsCollectionEditor<StatusChangeControlVMEntityView,StatusChangeControlDetailView>:RPSCollectionEditor<StatusChangeControlVMEntityView,StatusChangeControlDetailView> where StatusChangeControlVMEntityView : class, IView where StatusChangeControlDetailView : class, IView
    {
        public  StatusChangeControlDetailsGridView<StatusChangeControlVMEntityView,StatusChangeControlDetailView> GridView {get;set;}
    }
    public partial class StatusChangeControlDetailsGridView <StatusChangeControlVMEntityView,StatusChangeControlDetailView> :  RPSGridView<StatusChangeControlVMEntityView,StatusChangeControlDetailView> where StatusChangeControlVMEntityView : class, IView where StatusChangeControlDetailView : class, IView
    {
        public StatusChangeControlDetailsGridView(StatusChangeControlVMEntityView currentView,StatusChangeControlDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLine = RPSControlFactory.CreateRPSGridFormattedTextBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine']","",true, this.CurrentView);
 
            IDVoucherType = RPSControlFactory.CreateRPSGridComboBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cIDVoucherType']","",true, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 
            TypeAcc = RPSControlFactory.CreateRPSGridEnumComboBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cTypeAcc']","",true, this.CurrentView);
 
            CodPosting = RPSControlFactory.CreateRPSGridTextBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cCodPosting']","",false, this.CurrentView);
 
            GroupType = RPSControlFactory.CreateRPSGridEnumComboBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cGroupType']","",true, this.CurrentView);
 
            AmountFormula = RPSControlFactory.CreateRPSGridTextBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cAmountFormula']","",false, this.CurrentView);
 
            IDAccConcept = RPSControlFactory.CreateRPSGridComboBox<StatusChangeControlVMEntityView>("","#59821d99-1a03-48e2-888f-0907728a43e8 .ag-row[role='row']@ROWINDEX [col-id='cIDAccConcept']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusChangeControlVMEntityView> OrderLine { get; set; } 
        public IRPSGridComboBox<StatusChangeControlVMEntityView> IDVoucherType { get; set; } 
        public IRPSGridComboBox<StatusChangeControlVMEntityView> SignType { get; set; } 
        public IRPSGridComboBox<StatusChangeControlVMEntityView> TypeAcc { get; set; } 
        public IRPSGridTextBox<StatusChangeControlVMEntityView> CodPosting { get; set; } 
        public IRPSGridComboBox<StatusChangeControlVMEntityView> GroupType { get; set; } 
        public IRPSGridTextBox<StatusChangeControlVMEntityView> AmountFormula { get; set; } 
        public IRPSGridComboBox<StatusChangeControlVMEntityView> IDAccConcept { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusChangeControlDetailView : View
    {
        public StatusChangeControlDetailView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StatusChangeControlDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView>( this,Screen.StatusChangeControlVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView>( this,Screen.StatusChangeControlVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView>( this,Screen.StatusChangeControlVMEntityView);
 
            OrderLine = RPSControlFactory.CreateRPSFormattedTextBox<StatusChangeControlDetailView>("f2da6c10-5e4e-47d1-9a54-05f498bd0dfe","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<StatusChangeControlDetailView>("9609c894-c275-4057-8339-e93b58e082c8","","",true, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlDetailView>("6d3d17da-1d92-4cc1-b6ae-b8d6772f5c26","","",true, this);
 
            TypeAcc = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlDetailView>("daf5ed84-5d86-44d4-a368-cd6153d508d1","","",true, this);
 
            GroupType = RPSControlFactory.CreateRPSEnumComboBox<StatusChangeControlDetailView>("ce8c6d5c-798d-48a0-8a99-2e6eeebb51f5","","",true, this);
 
            CodPosting = RPSControlFactory.CreateRPSTextBox<StatusChangeControlDetailView>("f97381c2-9cd6-4a2e-a83b-b75baafe63de","","",false, this);
 
            AccountFormulatedChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StatusChangeControlDetailView,AccountFormulatedChildDialogView>("4b59fc4a-563a-4c06-aef6-5a0746fb7b3d","","", this,Screen.AccountFormulatedChildDialogView);
 
            IdAccount = RPSControlFactory.CreateRPSComboBox<StatusChangeControlDetailView>("de5b3836-b8d3-4e6e-ad91-d074cfaccdc3","","",false, this);
 
            AmountFormula = RPSControlFactory.CreateRPSTextBox<StatusChangeControlDetailView>("d824793f-0f90-4f15-a456-30515ffaa5d5","","",false, this);
 
            AmountFormulaChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StatusChangeControlDetailView,AmountFormulaChildDialogView>("bcb695e2-1d04-4c34-b632-e5c0043d8337","","", this,Screen.AmountFormulaChildDialogView);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<StatusChangeControlDetailView>("24942916-ea0e-4535-bf5a-48438f02aafe","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<StatusChangeControlDetailView>("fbcefe84-15ce-4d8a-a972-a5f8c60e2b32","","",false, this);
 
            ConceptExtensionNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StatusChangeControlDetailView,ConceptExtensionDialogView>("318d5c71-887c-474e-95d9-867ec8434478","","", this,Screen.ConceptExtensionDialogView);
 

        }
        public IRPSButton<StatusChangeControlDetailView> DeleteButton { get; set; } 
        public IRPSButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StatusChangeControlDetailView,StatusChangeControlVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<StatusChangeControlDetailView> OrderLine { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> IDVoucherType { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> SignType { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> TypeAcc { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> GroupType { get; set; } 
        public IRPSTextBox<StatusChangeControlDetailView> CodPosting { get; set; } 
        public IRPSButton<StatusChangeControlDetailView,AccountFormulatedChildDialogView> AccountFormulatedChildNavigationCommand { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> IdAccount { get; set; } 
        public IRPSTextBox<StatusChangeControlDetailView> AmountFormula { get; set; } 
        public IRPSButton<StatusChangeControlDetailView,AmountFormulaChildDialogView> AmountFormulaChildNavigationCommand { get; set; } 
        public IRPSComboBox<StatusChangeControlDetailView> IDAccConcept { get; set; } 
        public IRPSTextBox<StatusChangeControlDetailView> Extension { get; set; } 
        public IRPSButton<StatusChangeControlDetailView,ConceptExtensionDialogView> ConceptExtensionNavigationCommand { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public StatusChangeControlDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ConceptExtensionDialogView : View
    {
        public ConceptExtensionDialogView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("8343b94a-7d29-4eeb-bbbf-c85776b366f3","","",false, this);
 
            Property = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("6ef63af4-ba43-489c-9923-39155d2eda70","","",false, this);
 
            AddProperty = RPSControlFactory.CreateRPSButton<ConceptExtensionDialogView>( "1055ee22-1693-43ba-bfc8-75143164d27d","","",this);
 
            Concept = RPSControlFactory.CreateRPSTextBox<ConceptExtensionDialogView>("91c955a5-ab70-4499-a9bd-d34be2a5cb83","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<ConceptExtensionDialogView>( "5cfba667-e406-428e-9035-5968c1088683","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ConceptExtensionDialogView>( "cf82278e-4e16-4093-b70e-17e5b58680a3","","",this);
 

        }
        public IRPSComboBox<ConceptExtensionDialogView> Entity { get; set; } 
        public IRPSComboBox<ConceptExtensionDialogView> Property { get; set; } 
        public IRPSButton<ConceptExtensionDialogView> AddProperty { get; set; } 
        public IRPSTextBox<ConceptExtensionDialogView> Concept { get; set; } 
        public IRPSButton<ConceptExtensionDialogView> AcceptCommand { get; set; } 
        public IRPSButton<ConceptExtensionDialogView> CancelCommand { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public ConceptExtensionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccountFormulatedChildDialogView : View
    {
        public AccountFormulatedChildDialogView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodPosting = RPSControlFactory.CreateRPSTextBox<AccountFormulatedChildDialogView>("d1551c16-c9e0-4d18-b962-f2f71295af6d","","",false, this);
 
            Third = RPSControlFactory.CreateRPSOption<AccountFormulatedChildDialogView>( "7ddb9dcc-bb91-447f-a0dd-7a2837b91e74","","",this);
 
            Bank = RPSControlFactory.CreateRPSOption<AccountFormulatedChildDialogView>( "7cafdb6b-7b91-4f47-b1ac-4568e42334e8","","",this);
 
            CashCollector = RPSControlFactory.CreateRPSOption<AccountFormulatedChildDialogView>( "2d58b512-2c27-47b7-a238-50321558385f","","",this);
 
            Precode = RPSControlFactory.CreateRPSTextBox<AccountFormulatedChildDialogView>("76f6000c-a093-4dd5-8e33-bad78b36199e","","",false, this);
 
            From = RPSControlFactory.CreateRPSFormattedTextBox<AccountFormulatedChildDialogView>("5692cbcf-e556-4812-a1d8-15ad1462217d","","",false, this);
 
            To = RPSControlFactory.CreateRPSFormattedTextBox<AccountFormulatedChildDialogView>("e155facf-ca18-42f0-8dc5-499a4a45a83c","","",false, this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<AccountFormulatedChildDialogView>("668fa15f-99d4-40f7-b1a5-640f37ffa2ef","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<AccountFormulatedChildDialogView>( "e7e1e000-a049-4043-aae8-b595e35f2c72","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<AccountFormulatedChildDialogView>( "6eccf28d-05a1-4363-8ec4-f3601c281dfe","","",this);
 

        }
        public IRPSTextBox<AccountFormulatedChildDialogView> CodPosting { get; set; } 
        public IRPSOption<AccountFormulatedChildDialogView> Third { get; set; } 
        public IRPSOption<AccountFormulatedChildDialogView> Bank { get; set; } 
        public IRPSOption<AccountFormulatedChildDialogView> CashCollector { get; set; } 
        public IRPSTextBox<AccountFormulatedChildDialogView> Precode { get; set; } 
        public IRPSTextBox<AccountFormulatedChildDialogView> From { get; set; } 
        public IRPSTextBox<AccountFormulatedChildDialogView> To { get; set; } 
        public IRPSTextBox<AccountFormulatedChildDialogView> Formula { get; set; } 
        public IRPSButton<AccountFormulatedChildDialogView> AcceptCommand { get; set; } 
        public IRPSButton<AccountFormulatedChildDialogView> CancelCommand { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public AccountFormulatedChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AmountFormulaChildDialogView : View
    {
        public AmountFormulaChildDialogView(StatusChangeControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Formula = RPSControlFactory.CreateRPSTextBox<AmountFormulaChildDialogView>("5661fea1-c7ea-45a6-9e7a-73c573d4f127","","",false, this);
 
            AddCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "22db5242-e201-4467-81fe-3bb7854addd6","","",this);
 
            SubtractCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "4d0c600b-7451-4c0a-95c9-0c01047cd361","","",this);
 
            MultiplyCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "ebc6fc70-16de-4714-b526-510a88568a10","","",this);
 
            DivideCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "a02311e6-e2d2-430d-a434-dc10b4a95814","","",this);
 
            Options = RPSControlFactory.CreateRPSEnumComboBox<AmountFormulaChildDialogView>("a0748ac8-5fc6-408a-9b50-cfabd10a9990","","",false, this);
 
            AddCommand = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "cce31a11-5f44-4c6e-96c2-57f00014cd82","","",this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "e9a2f551-7612-436d-b7e6-a2f909e859e0","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "bc5d5510-ed2e-4be6-bc3a-5e76b7d006d9","","",this);
 

        }
        public IRPSTextBox<AmountFormulaChildDialogView> Formula { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> AddCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> SubtractCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> MultiplyCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> DivideCommandOperator { get; set; } 
        public IRPSComboBox<AmountFormulaChildDialogView> Options { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> AddCommand { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> AcceptCommand { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> CancelCommand { get; set; } 
        public StatusChangeControl Screen { get; set; }
        public AmountFormulaChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
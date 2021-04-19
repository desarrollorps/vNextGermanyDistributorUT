    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FIRunReport
{
    //RPS VERSION 1.0.0.0
    public partial class FIRunReport:Screen
    {
        public FIRunReport():base()
        {
            this.URL = "generalledger.firunreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FIRunReportView  = new FIRunReportView(this); 
            DetailsChildDialogView  = new DetailsChildDialogView(this); 
            AreasChildDialogView  = new AreasChildDialogView(this); 
            VoucherTypesChildDialogView  = new VoucherTypesChildDialogView(this); 
            DocumenttypesChildDialogView  = new DocumenttypesChildDialogView(this); 
            VATChidDialogView  = new VATChidDialogView(this); 
            MovementTypesChildDialogView  = new MovementTypesChildDialogView(this); 
            TAXChildDialogView  = new TAXChildDialogView(this); 
            TAXValuesChildDialogView  = new TAXValuesChildDialogView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            FIRunReportView.InitializeControls(); 
            DetailsChildDialogView.InitializeControls(); 
            AreasChildDialogView.InitializeControls(); 
            VoucherTypesChildDialogView.InitializeControls(); 
            DocumenttypesChildDialogView.InitializeControls(); 
            VATChidDialogView.InitializeControls(); 
            MovementTypesChildDialogView.InitializeControls(); 
            TAXChildDialogView.InitializeControls(); 
            TAXValuesChildDialogView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public FIRunReportView FIRunReportView {get; set; } 
            public DetailsChildDialogView DetailsChildDialogView {get; set; } 
            public AreasChildDialogView AreasChildDialogView {get; set; } 
            public VoucherTypesChildDialogView VoucherTypesChildDialogView {get; set; } 
            public DocumenttypesChildDialogView DocumenttypesChildDialogView {get; set; } 
            public VATChidDialogView VATChidDialogView {get; set; } 
            public MovementTypesChildDialogView MovementTypesChildDialogView {get; set; } 
            public TAXChildDialogView TAXChildDialogView {get; set; } 
            public TAXValuesChildDialogView TAXValuesChildDialogView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class FIRunReportView : View
    {
        public FIRunReportView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDFILineModel = RPSControlFactory.CreateRPSComboBox<FIRunReportView>("531db56a-4167-43fd-a76d-226a32a7d1a4","","",false, this);
 
            IDFIColumnModel = RPSControlFactory.CreateRPSComboBox<FIRunReportView>("683f836b-2d1f-4399-99e2-b8cf99ea6a94","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FIRunReportView>("7b4f2780-5a90-4b2b-8370-8fe78e8a642d","","",false, this);
 
            TC = RPSControlFactory.CreateRPSCheckBox<FIRunReportView>("a7097a4f-2dbf-409c-81bc-953290d3caa8","","",false, this);
 
            IDBudget = RPSControlFactory.CreateRPSComboBox<FIRunReportView>("6c54f946-eefc-49f2-bb2c-afe558c65f4d","","",false, this);
 
            NoRounding = RPSControlFactory.CreateRPSOption<FIRunReportView>( "c18296ed-aa65-4a83-8178-b599ccc788d5","","",this);
 
            kRounding = RPSControlFactory.CreateRPSOption<FIRunReportView>( "aa344fcc-6c48-46fa-8dc4-657c7e7c7b16","","",this);
 
            Mrounding = RPSControlFactory.CreateRPSOption<FIRunReportView>( "770de41a-e49c-40a8-81d0-f4bf30508c26","","",this);
 
            Analytic = RPSControlFactory.CreateRPSCheckBox<FIRunReportView>("2c1f1bcd-8079-4acf-8342-27140710c64c","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<FIRunReportView>("b3a866ba-b544-4ef2-8699-02829217a8b7","","",false, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<FIRunReportView>("4b358691-6298-4044-acf0-d7d097e4958d","","",false, this);
 
            First = RPSControlFactory.CreateRPSOption<FIRunReportView>( "ae3642eb-c9ca-4990-9e11-7e5bbb26134d","","",this);
 
            Last = RPSControlFactory.CreateRPSOption<FIRunReportView>( "91d0e8e0-32e3-4147-ad96-437024af9fda","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<FIRunReportView>( "1374bdba-46c3-4072-8f3b-3ffdbeb793d8","","",this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<FIRunReportView>( "ef67df06-5910-451c-9a25-814ecf6a3ca2","","",this);
 
            DetailsCommand = RPSControlFactory.CreateRPSButton<FIRunReportView>( "ea8e5940-f658-4b84-baa1-b2f9c1b1cfbb","","",this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FIRunReportView,PrintChildDialogView>("c5adbe2d-6016-4ce5-b4b4-26e53c8953f1","","", this,Screen.PrintChildDialogView);
 
            Section = RPSControlFactory.CreateRPSSection<FIRunReportView>( "","ul li[rpsid='d5f5478a-a174-4b0e-8896-458f9eb58288']","",this);
 

        }
        public IRPSComboBox<FIRunReportView> IDFILineModel { get; set; } 
        public IRPSComboBox<FIRunReportView> IDFIColumnModel { get; set; } 
        public IRPSTextBox<FIRunReportView> DateTo { get; set; } 
        public IRPSCheckbox<FIRunReportView> TC { get; set; } 
        public IRPSComboBox<FIRunReportView> IDBudget { get; set; } 
        public IRPSOption<FIRunReportView> NoRounding { get; set; } 
        public IRPSOption<FIRunReportView> kRounding { get; set; } 
        public IRPSOption<FIRunReportView> Mrounding { get; set; } 
        public IRPSCheckbox<FIRunReportView> Analytic { get; set; } 
        public IRPSComboBox<FIRunReportView> IDDimension { get; set; } 
        public IRPSComboBox<FIRunReportView> IDDimValue { get; set; } 
        public IRPSOption<FIRunReportView> First { get; set; } 
        public IRPSOption<FIRunReportView> Last { get; set; } 
        public IRPSOption<FIRunReportView> Selected { get; set; } 
        public IRPSButton<FIRunReportView> AcceptCommand { get; set; } 
        public IRPSButton<FIRunReportView> DetailsCommand { get; set; } 
        public IRPSButton<FIRunReportView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public IRPSSection<FIRunReportView> Section { get; set; } 
        public FIRunReport Screen { get; set; }
        public FIRunReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DetailsChildDialogView : View
    {
        public DetailsChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("45244f1d-3b30-4b25-ae0d-1579652875b4","","",false, this);
 
            Label = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("71258e6a-8725-4cf7-99d6-797847493b59","","",false, this);
 
            AmountResult = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("c21ce2b7-8571-405f-8d50-6815d2abe85c","","",false, this);
 
            DateFromDetail = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("22b46a42-e903-4e14-b538-7c90c3439c70","","",false, this);
 
            DateToDetail = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("4c12c640-33e1-4b4a-83b4-da4a0cd97097","","",false, this);
 
            AmountDebit = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("8e2450c5-b167-40d7-8ad6-228b60036d21","","",false, this);
 
            AmountCredit = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("c14a5b54-ea42-43f8-8346-aff53efb3c41","","",false, this);
 
            AmountNet = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("083470a8-7517-41d9-96a9-2f4d7239b550","","",false, this);
 
            ErrorText = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("3aec40a6-be6b-4b26-bafe-69f658dcd92f","","",false, this);
 
            IDFILineModel = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("e48edb71-eb0f-43f4-b587-f0283e203f74","","",false, this);
 
            IDFIColumnModel = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("42439d71-c13e-4a76-90de-12e8785dab12","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("1d04ef32-b77d-4b7b-9cf1-e35b4472066f","","",false, this);
 
            TC = RPSControlFactory.CreateRPSCheckBox<DetailsChildDialogView>("18b2d55f-62b0-4bc6-bc61-45e48a170121","","",false, this);
 
            IDBudget = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("8de75256-ca75-455f-abbc-c6b8f273973d","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("a13f46ef-5a03-4c79-898a-a5a953cce3f8","","",false, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("308ce710-5266-46cd-abcd-9a31ff5c8057","","",false, this);
 
            SelectedCodLine = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("06a965f0-d54d-4d14-9cf2-84aae3f332d4","","",false, this);
 
            DescLine = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("25e02bfd-4cd9-4154-9437-5c8d71bbb745","","",false, this);
 
            LineTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("6970c921-35cf-41b8-9211-d47ca83ad8d4","","",false, this);
 
            LineContent = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("cb34d655-b1b9-4b88-88cc-2eb343121874","","",false, this);
 
            LineSignTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("f2236ef0-18c0-4cfa-b9f2-cbed6fdd9695","","",false, this);
 
            LineChangeSign = RPSControlFactory.CreateRPSCheckBox<DetailsChildDialogView>("b0553ceb-9a33-4b85-bbf2-b64223847488","","",false, this);
 
            LineUseWhenSignName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("22a43f2c-23f5-445b-89d6-6a1e7c1aec6a","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("2815c08d-53c0-4edd-8111-806ef18be719","","",false, this);
 
            CodColumn = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("9afebfe8-4830-4754-8021-40641ea82d86","","",false, this);
 
            DescColumn = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("4a41b136-5e51-4910-b7d2-2adf60e2d375","","",false, this);
 
            ColumnTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("e98a32a7-afcb-4584-a77f-b92a994813de","","",false, this);
 
            ColumnContent = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("f71b08cd-48c9-48ee-8de0-3f927c7d6920","","",false, this);
 
            ColumnSignTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("9d0e9af4-1a61-44b6-aa59-bf0057d27998","","",false, this);
 
            ColumnChangeSign = RPSControlFactory.CreateRPSCheckBox<DetailsChildDialogView>("f3f01ad7-1f38-4337-becb-e687a4b9bf7d","","",false, this);
 
            ColumnUseWhenSignName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("3178762c-6be0-4c78-a0fc-e33cc6e403f1","","",false, this);
 
            ColumnPeriodTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("b04fb413-100c-4d2f-8dc3-cf47c56fb21f","","",false, this);
 
            ColumnPeriodStep = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("6678e2b4-4af2-4ef7-b8f7-f30fd20c3f81","","",false, this);
 
            IDFIComplexLine = RPSControlFactory.CreateRPSComboBox<DetailsChildDialogView>("8ab38c94-ec72-4bb8-9109-e9a172de1a34","","",false, this);
 
            ComplexLineAreas = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("1a523915-9908-48e8-ad33-152733e31ae3","","",false, this);
 
            AreasChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,AreasChildDialogView>("bb1f95ab-101d-438c-8bf8-db45d1a260a2","","", this,Screen.AreasChildDialogView);
 
            ComplexLineVoucherTypes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("d5248310-526c-4070-b524-7f1e3f02536a","","",false, this);
 
            VoucherTypesChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,VoucherTypesChildDialogView>("64fccc68-5e6e-4895-9607-8c79c3a9cf39","","", this,Screen.VoucherTypesChildDialogView);
 
            ComplexLineDocumentTypes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("2737f103-0955-4ed7-97f1-7d64c483d7c3","","",false, this);
 
            DocumenttypesChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,DocumenttypesChildDialogView>("cbc28d78-b6fc-4dc0-950d-d37a6903b3ae","","", this,Screen.DocumenttypesChildDialogView);
 
            ComplexLineCountryTypeName = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("aefe5aa1-6f78-4066-965f-6927cc10eb45","","",false, this);
 
            ComplexLineMovementTypes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("b76d80d2-d714-4b4d-9059-0a67378fbb8a","","",false, this);
 
            MovementTypesChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,MovementTypesChildDialogView>("ecfe7136-12a2-4763-9b65-7f5fc2eaaacd","","", this,Screen.MovementTypesChildDialogView);
 
            ComplexLineVATCodes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("5a1b7269-6ecb-4f19-be48-d7dac5d278fd","","",false, this);
 
            VATChidNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,VATChidDialogView>("cf272d73-0010-43a6-acc2-d5d4fc2ff88e","","", this,Screen.VATChidDialogView);
 
            ComplexLineTaxCodes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("e50f9f9f-821e-4e11-b2dd-e0fc286f077f","","",false, this);
 
            TAXChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,TAXChildDialogView>("6da8ea06-fefe-442d-ac15-0ad3d261a294","","", this,Screen.TAXChildDialogView);
 
            ComplexLineTaxValueCodes = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("7a308e18-6503-4986-8a2a-d6e21a8e2c52","","",false, this);
 
            TAXValuesChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DetailsChildDialogView,TAXValuesChildDialogView>("700e9a2f-48b6-4d88-933b-fd26ddfcfab7","","", this,Screen.TAXValuesChildDialogView);
 
            ComplexLinePercentage = RPSControlFactory.CreateRPSFormattedTextBox<DetailsChildDialogView>("40270455-c06f-4719-af90-c3611765522c","","",false, this);
 
            MovementType = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("952700ae-fb3b-484e-a56c-19ee948f8d13","","",false, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("47a85ea6-9b0a-4562-bd45-caafb1f25d3b","","",false, this);
 
            MovementType1 = RPSControlFactory.CreateRPSTextBox<DetailsChildDialogView>("a6e12d54-4237-4a27-a230-1291437d1b23","","",false, this);
 
            CollectionInit params_GetReportGridTransactions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="149b26c3-390d-42ca-9dc5-09cb0d92e835",CSSSelectorGrid="",XPathGrid=""};
            GetReportGridTransactions = RPSControlFactory.RPSCreateCollectionWithGrid<GetReportGridTransactionsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>,DetailsChildDialogView,AreasChildDialogView>( params_GetReportGridTransactions,this,Screen.AreasChildDialogView);
 
            CollectionInit params_GetReportGridAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="69866a95-75da-4645-83b5-392221dd1728",CSSSelectorGrid="",XPathGrid=""};
            GetReportGridAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<GetReportGridAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>,DetailsChildDialogView,AreasChildDialogView>( params_GetReportGridAnalytics,this,Screen.AreasChildDialogView);
 
            CollectionInit params_GetReportGridBudget = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c94033ce-4d25-4259-9098-a40c48f8fbbc",CSSSelectorGrid="",XPathGrid=""};
            GetReportGridBudget = RPSControlFactory.RPSCreateCollectionWithGrid<GetReportGridBudgetCollectionEditor<DetailsChildDialogView,AreasChildDialogView>,DetailsChildDialogView,AreasChildDialogView>( params_GetReportGridBudget,this,Screen.AreasChildDialogView);
 
            CollectionInit params_GetReportGridBudgetAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a05f666-1585-4f89-9d58-5096a5feee1e",CSSSelectorGrid="",XPathGrid=""};
            GetReportGridBudgetAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<GetReportGridBudgetAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>,DetailsChildDialogView,AreasChildDialogView>( params_GetReportGridBudgetAnalytics,this,Screen.AreasChildDialogView);
 

        }
        public IRPSTextBox<DetailsChildDialogView> Description { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> Label { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> AmountResult { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> DateFromDetail { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> DateToDetail { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> AmountDebit { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> AmountCredit { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> AmountNet { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ErrorText { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDFILineModel { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDFIColumnModel { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<DetailsChildDialogView> TC { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDBudget { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDDimension { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDDimValue { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> SelectedCodLine { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> DescLine { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> LineTypeName { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> LineContent { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> LineSignTypeName { get; set; } 
        public IRPSCheckbox<DetailsChildDialogView> LineChangeSign { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> LineUseWhenSignName { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> CodColumn { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> DescColumn { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnTypeName { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnContent { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnSignTypeName { get; set; } 
        public IRPSCheckbox<DetailsChildDialogView> ColumnChangeSign { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnUseWhenSignName { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnPeriodTypeName { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ColumnPeriodStep { get; set; } 
        public IRPSComboBox<DetailsChildDialogView> IDFIComplexLine { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineAreas { get; set; } 
        public IRPSButton<DetailsChildDialogView,AreasChildDialogView> AreasChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineVoucherTypes { get; set; } 
        public IRPSButton<DetailsChildDialogView,VoucherTypesChildDialogView> VoucherTypesChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineDocumentTypes { get; set; } 
        public IRPSButton<DetailsChildDialogView,DocumenttypesChildDialogView> DocumenttypesChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineCountryTypeName { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineMovementTypes { get; set; } 
        public IRPSButton<DetailsChildDialogView,MovementTypesChildDialogView> MovementTypesChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineVATCodes { get; set; } 
        public IRPSButton<DetailsChildDialogView,VATChidDialogView> VATChidNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineTaxCodes { get; set; } 
        public IRPSButton<DetailsChildDialogView,TAXChildDialogView> TAXChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLineTaxValueCodes { get; set; } 
        public IRPSButton<DetailsChildDialogView,TAXValuesChildDialogView> TAXValuesChildNavigationCommand { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> ComplexLinePercentage { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> MovementType { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> Extension { get; set; } 
        public IRPSTextBox<DetailsChildDialogView> MovementType1 { get; set; } 
        public GetReportGridTransactionsCollectionEditor<DetailsChildDialogView,AreasChildDialogView> GetReportGridTransactions { get; set; } 
        public GetReportGridAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView> GetReportGridAnalytics { get; set; } 
        public GetReportGridBudgetCollectionEditor<DetailsChildDialogView,AreasChildDialogView> GetReportGridBudget { get; set; } 
        public GetReportGridBudgetAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView> GetReportGridBudgetAnalytics { get; set; } 
        public FIRunReport Screen { get; set; }
        public DetailsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetReportGridTransactionsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>:RPSCollectionEditor<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public  GetReportGridTransactionsGridView<DetailsChildDialogView,AreasChildDialogView> GridView {get;set;}
    }
    public partial class GetReportGridTransactionsGridView <DetailsChildDialogView,AreasChildDialogView> :  RPSGridView<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public GetReportGridTransactionsGridView(DetailsChildDialogView currentView,AreasChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MovementType = RPSControlFactory.CreateRPSGridTextBox<DetailsChildDialogView>("","#149b26c3-390d-42ca-9dc5-09cb0d92e835 .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",false, this.CurrentView);
 
            CompanyName = RPSControlFactory.CreateRPSGridTextBox<DetailsChildDialogView>("","#149b26c3-390d-42ca-9dc5-09cb0d92e835 .ag-row[role='row']@ROWINDEX [col-id='cCompanyName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailsChildDialogView> MovementType { get; set; } 
        public IRPSGridTextBox<DetailsChildDialogView> CompanyName { get; set; } 
                     
    }
 
        public partial class GetReportGridAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>:RPSCollectionEditor<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public  GetReportGridAnalyticsGridView<DetailsChildDialogView,AreasChildDialogView> GridView {get;set;}
    }
    public partial class GetReportGridAnalyticsGridView <DetailsChildDialogView,AreasChildDialogView> :  RPSGridView<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public GetReportGridAnalyticsGridView(DetailsChildDialogView currentView,AreasChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CompanyName = RPSControlFactory.CreateRPSGridTextBox<DetailsChildDialogView>("","#69866a95-75da-4645-83b5-392221dd1728 .ag-row[role='row']@ROWINDEX [col-id='cCompanyName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailsChildDialogView> CompanyName { get; set; } 
                     
    }
 
        public partial class GetReportGridBudgetCollectionEditor<DetailsChildDialogView,AreasChildDialogView>:RPSCollectionEditor<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public  GetReportGridBudgetGridView<DetailsChildDialogView,AreasChildDialogView> GridView {get;set;}
    }
    public partial class GetReportGridBudgetGridView <DetailsChildDialogView,AreasChildDialogView> :  RPSGridView<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public GetReportGridBudgetGridView(DetailsChildDialogView currentView,AreasChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodACCType = RPSControlFactory.CreateRPSGridTextBox<DetailsChildDialogView>("","#c94033ce-4d25-4259-9098-a40c48f8fbbc .ag-row[role='row']@ROWINDEX [col-id='cCodACCType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailsChildDialogView> CodACCType { get; set; } 
                     
    }
 
        public partial class GetReportGridBudgetAnalyticsCollectionEditor<DetailsChildDialogView,AreasChildDialogView>:RPSCollectionEditor<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public  GetReportGridBudgetAnalyticsGridView<DetailsChildDialogView,AreasChildDialogView> GridView {get;set;}
    }
    public partial class GetReportGridBudgetAnalyticsGridView <DetailsChildDialogView,AreasChildDialogView> :  RPSGridView<DetailsChildDialogView,AreasChildDialogView> where DetailsChildDialogView : class, IView where AreasChildDialogView : class, IView
    {
        public GetReportGridBudgetAnalyticsGridView(DetailsChildDialogView currentView,AreasChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodACCType = RPSControlFactory.CreateRPSGridTextBox<DetailsChildDialogView>("","#3a05f666-1585-4f89-9d58-5096a5feee1e .ag-row[role='row']@ROWINDEX [col-id='cCodACCType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailsChildDialogView> CodACCType { get; set; } 
                     
    }
 
    }
  
            
    public partial class AreasChildDialogView : View
    {
        public AreasChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetAreas = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="602c8581-2ab1-47e6-9935-99f1e3d7867e",CSSSelectorGrid="",XPathGrid=""};
            GetAreas = RPSControlFactory.RPSCreateCollectionWithGrid<GetAreasCollectionEditor<AreasChildDialogView>,AreasChildDialogView>( params_GetAreas,this);
 

        }
        public GetAreasCollectionEditor<AreasChildDialogView> GetAreas { get; set; } 
        public FIRunReport Screen { get; set; }
        public AreasChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetAreasCollectionEditor<AreasChildDialogView>:RPSCollectionEditor<AreasChildDialogView> where AreasChildDialogView : class, IView
    {
        public  GetAreasGridView<AreasChildDialogView> GridView {get;set;}
    }
    public partial class GetAreasGridView <AreasChildDialogView> :  RPSGridView<AreasChildDialogView> where AreasChildDialogView : class, IView
    {
        public GetAreasGridView(AreasChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<AreasChildDialogView>("","#602c8581-2ab1-47e6-9935-99f1e3d7867e .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<AreasChildDialogView>("","#602c8581-2ab1-47e6-9935-99f1e3d7867e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<AreasChildDialogView>("","#602c8581-2ab1-47e6-9935-99f1e3d7867e .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AreasChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<AreasChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<AreasChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class VoucherTypesChildDialogView : View
    {
        public VoucherTypesChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetVoucherTypes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="51c25e3e-bf0a-4df3-97bb-24f569d69a0d",CSSSelectorGrid="",XPathGrid=""};
            GetVoucherTypes = RPSControlFactory.RPSCreateCollectionWithGrid<GetVoucherTypesCollectionEditor<VoucherTypesChildDialogView>,VoucherTypesChildDialogView>( params_GetVoucherTypes,this);
 

        }
        public GetVoucherTypesCollectionEditor<VoucherTypesChildDialogView> GetVoucherTypes { get; set; } 
        public FIRunReport Screen { get; set; }
        public VoucherTypesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVoucherTypesCollectionEditor<VoucherTypesChildDialogView>:RPSCollectionEditor<VoucherTypesChildDialogView> where VoucherTypesChildDialogView : class, IView
    {
        public  GetVoucherTypesGridView<VoucherTypesChildDialogView> GridView {get;set;}
    }
    public partial class GetVoucherTypesGridView <VoucherTypesChildDialogView> :  RPSGridView<VoucherTypesChildDialogView> where VoucherTypesChildDialogView : class, IView
    {
        public GetVoucherTypesGridView(VoucherTypesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<VoucherTypesChildDialogView>("","#51c25e3e-bf0a-4df3-97bb-24f569d69a0d .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<VoucherTypesChildDialogView>("","#51c25e3e-bf0a-4df3-97bb-24f569d69a0d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<VoucherTypesChildDialogView>("","#51c25e3e-bf0a-4df3-97bb-24f569d69a0d .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VoucherTypesChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<VoucherTypesChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<VoucherTypesChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocumenttypesChildDialogView : View
    {
        public DocumenttypesChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentType = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9316476e-f369-49a4-a2ca-af5941ef0ce3",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentType = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentTypeCollectionEditor<DocumenttypesChildDialogView>,DocumenttypesChildDialogView>( params_GetDocumentType,this);
 

        }
        public GetDocumentTypeCollectionEditor<DocumenttypesChildDialogView> GetDocumentType { get; set; } 
        public FIRunReport Screen { get; set; }
        public DocumenttypesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDocumentTypeCollectionEditor<DocumenttypesChildDialogView>:RPSCollectionEditor<DocumenttypesChildDialogView> where DocumenttypesChildDialogView : class, IView
    {
        public  GetDocumentTypeGridView<DocumenttypesChildDialogView> GridView {get;set;}
    }
    public partial class GetDocumentTypeGridView <DocumenttypesChildDialogView> :  RPSGridView<DocumenttypesChildDialogView> where DocumenttypesChildDialogView : class, IView
    {
        public GetDocumentTypeGridView(DocumenttypesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<DocumenttypesChildDialogView>("","#9316476e-f369-49a4-a2ca-af5941ef0ce3 .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DocumenttypesChildDialogView>("","#9316476e-f369-49a4-a2ca-af5941ef0ce3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<DocumenttypesChildDialogView>("","#9316476e-f369-49a4-a2ca-af5941ef0ce3 .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumenttypesChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<DocumenttypesChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<DocumenttypesChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class VATChidDialogView : View
    {
        public VATChidDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetVATs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14cc40ce-0876-4c49-b4e0-3d7975006280",CSSSelectorGrid="",XPathGrid=""};
            GetVATs = RPSControlFactory.RPSCreateCollectionWithGrid<GetVATsCollectionEditor<VATChidDialogView>,VATChidDialogView>( params_GetVATs,this);
 

        }
        public GetVATsCollectionEditor<VATChidDialogView> GetVATs { get; set; } 
        public FIRunReport Screen { get; set; }
        public VATChidDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVATsCollectionEditor<VATChidDialogView>:RPSCollectionEditor<VATChidDialogView> where VATChidDialogView : class, IView
    {
        public  GetVATsGridView<VATChidDialogView> GridView {get;set;}
    }
    public partial class GetVATsGridView <VATChidDialogView> :  RPSGridView<VATChidDialogView> where VATChidDialogView : class, IView
    {
        public GetVATsGridView(VATChidDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<VATChidDialogView>("","#14cc40ce-0876-4c49-b4e0-3d7975006280 .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<VATChidDialogView>("","#14cc40ce-0876-4c49-b4e0-3d7975006280 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<VATChidDialogView>("","#14cc40ce-0876-4c49-b4e0-3d7975006280 .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VATChidDialogView> Cod { get; set; } 
        public IRPSGridTextBox<VATChidDialogView> Description { get; set; } 
        public IRPSGridCheckbox<VATChidDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class MovementTypesChildDialogView : View
    {
        public MovementTypesChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMovementType = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49c22f04-092a-452f-a2f6-f6432e73216b",CSSSelectorGrid="",XPathGrid=""};
            GetMovementType = RPSControlFactory.RPSCreateCollectionWithGrid<GetMovementTypeCollectionEditor<MovementTypesChildDialogView>,MovementTypesChildDialogView>( params_GetMovementType,this);
 

        }
        public GetMovementTypeCollectionEditor<MovementTypesChildDialogView> GetMovementType { get; set; } 
        public FIRunReport Screen { get; set; }
        public MovementTypesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMovementTypeCollectionEditor<MovementTypesChildDialogView>:RPSCollectionEditor<MovementTypesChildDialogView> where MovementTypesChildDialogView : class, IView
    {
        public  GetMovementTypeGridView<MovementTypesChildDialogView> GridView {get;set;}
    }
    public partial class GetMovementTypeGridView <MovementTypesChildDialogView> :  RPSGridView<MovementTypesChildDialogView> where MovementTypesChildDialogView : class, IView
    {
        public GetMovementTypeGridView(MovementTypesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<MovementTypesChildDialogView>("","#49c22f04-092a-452f-a2f6-f6432e73216b .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MovementTypesChildDialogView>("","#49c22f04-092a-452f-a2f6-f6432e73216b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<MovementTypesChildDialogView>("","#49c22f04-092a-452f-a2f6-f6432e73216b .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MovementTypesChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<MovementTypesChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<MovementTypesChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class TAXChildDialogView : View
    {
        public TAXChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a568755-6650-40b0-a957-992ba54a2993",CSSSelectorGrid="",XPathGrid=""};
            GetTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<GetTaxsCollectionEditor<TAXChildDialogView>,TAXChildDialogView>( params_GetTaxs,this);
 

        }
        public GetTaxsCollectionEditor<TAXChildDialogView> GetTaxs { get; set; } 
        public FIRunReport Screen { get; set; }
        public TAXChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTaxsCollectionEditor<TAXChildDialogView>:RPSCollectionEditor<TAXChildDialogView> where TAXChildDialogView : class, IView
    {
        public  GetTaxsGridView<TAXChildDialogView> GridView {get;set;}
    }
    public partial class GetTaxsGridView <TAXChildDialogView> :  RPSGridView<TAXChildDialogView> where TAXChildDialogView : class, IView
    {
        public GetTaxsGridView(TAXChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<TAXChildDialogView>("","#3a568755-6650-40b0-a957-992ba54a2993 .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TAXChildDialogView>("","#3a568755-6650-40b0-a957-992ba54a2993 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<TAXChildDialogView>("","#3a568755-6650-40b0-a957-992ba54a2993 .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TAXChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<TAXChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<TAXChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class TAXValuesChildDialogView : View
    {
        public TAXValuesChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetTaxValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dbf4f304-efe8-47d9-b9c0-c1e6008e258b",CSSSelectorGrid="",XPathGrid=""};
            GetTaxValues = RPSControlFactory.RPSCreateCollectionWithGrid<GetTaxValuesCollectionEditor<TAXValuesChildDialogView>,TAXValuesChildDialogView>( params_GetTaxValues,this);
 

        }
        public GetTaxValuesCollectionEditor<TAXValuesChildDialogView> GetTaxValues { get; set; } 
        public FIRunReport Screen { get; set; }
        public TAXValuesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTaxValuesCollectionEditor<TAXValuesChildDialogView>:RPSCollectionEditor<TAXValuesChildDialogView> where TAXValuesChildDialogView : class, IView
    {
        public  GetTaxValuesGridView<TAXValuesChildDialogView> GridView {get;set;}
    }
    public partial class GetTaxValuesGridView <TAXValuesChildDialogView> :  RPSGridView<TAXValuesChildDialogView> where TAXValuesChildDialogView : class, IView
    {
        public GetTaxValuesGridView(TAXValuesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Cod = RPSControlFactory.CreateRPSGridTextBox<TAXValuesChildDialogView>("","#dbf4f304-efe8-47d9-b9c0-c1e6008e258b .ag-row[role='row']@ROWINDEX [col-id='cCod']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TAXValuesChildDialogView>("","#dbf4f304-efe8-47d9-b9c0-c1e6008e258b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Selected = RPSControlFactory.CreateRPSGridCheckBox<TAXValuesChildDialogView>("","#dbf4f304-efe8-47d9-b9c0-c1e6008e258b .ag-row[role='row']@ROWINDEX [col-id='cSelected']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TAXValuesChildDialogView> Cod { get; set; } 
        public IRPSGridTextBox<TAXValuesChildDialogView> Description { get; set; } 
        public IRPSGridCheckbox<TAXValuesChildDialogView> Selected { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(FIRunReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCustomReport = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("b10f39f4-a987-4509-aa74-e62faaeb9dde","","",false, this);
 
            ShowAccount = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("fcbcc8fc-ccdf-4fb6-9b9a-32de50a80d7b","","",false, this);
 

        }
        public IRPSComboBox<PrintChildDialogView> CodCustomReport { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> ShowAccount { get; set; } 
        public FIRunReport Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
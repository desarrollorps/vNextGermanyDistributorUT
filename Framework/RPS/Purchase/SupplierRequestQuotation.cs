    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierRequestQuotation
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRequestQuotation:Screen
    {
        public SupplierRequestQuotation():base()
        {
            this.URL = "purchase.supplierrequestquotation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRequestQuotationCollectionView  = new SupplierRequestQuotationCollectionView(this); 
            SupplierRequestQuotationEntityView  = new SupplierRequestQuotationEntityView(this); 
            SupplierRequestQuotationLineView  = new SupplierRequestQuotationLineView(this); 
            NewSupplierRequestQuotationFromCopyChildDialogView  = new NewSupplierRequestQuotationFromCopyChildDialogView(this); 
            SupplierReqQuotationAdvanceView  = new SupplierReqQuotationAdvanceView(this); 
            SupplierRequestQuotationVariablePaymentView  = new SupplierRequestQuotationVariablePaymentView(this); 
            OrderGenerateChildDialogView  = new OrderGenerateChildDialogView(this); 
            SupplierRQFPrintDialogView  = new SupplierRQFPrintDialogView(this); 
            ChangeReceivedStatusAceptedChildDialogView  = new ChangeReceivedStatusAceptedChildDialogView(this); 
            ChangeSupplierChildDialogView  = new ChangeSupplierChildDialogView(this); 
            FrameworkContractFromSupplierRequesQuotationChildDialogView  = new FrameworkContractFromSupplierRequesQuotationChildDialogView(this); 
            ChaneSupplierRFQLinesDialogView  = new ChaneSupplierRFQLinesDialogView(this); 
            UpdateCostsOfferLineChildDialogView  = new UpdateCostsOfferLineChildDialogView(this); 
            CuDistEmployeeChangedPopUpDialogView  = new CuDistEmployeeChangedPopUpDialogView(this); 
            SupplierRequestQuotationCollectionView.InitializeControls(); 
            SupplierRequestQuotationEntityView.InitializeControls(); 
            SupplierRequestQuotationLineView.InitializeControls(); 
            NewSupplierRequestQuotationFromCopyChildDialogView.InitializeControls(); 
            SupplierReqQuotationAdvanceView.InitializeControls(); 
            SupplierRequestQuotationVariablePaymentView.InitializeControls(); 
            OrderGenerateChildDialogView.InitializeControls(); 
            SupplierRQFPrintDialogView.InitializeControls(); 
            ChangeReceivedStatusAceptedChildDialogView.InitializeControls(); 
            ChangeSupplierChildDialogView.InitializeControls(); 
            FrameworkContractFromSupplierRequesQuotationChildDialogView.InitializeControls(); 
            ChaneSupplierRFQLinesDialogView.InitializeControls(); 
            UpdateCostsOfferLineChildDialogView.InitializeControls(); 
            CuDistEmployeeChangedPopUpDialogView.InitializeControls(); 
           
        }
      
            public SupplierRequestQuotationCollectionView SupplierRequestQuotationCollectionView {get; set; } 
            public SupplierRequestQuotationEntityView SupplierRequestQuotationEntityView {get; set; } 
            public SupplierRequestQuotationLineView SupplierRequestQuotationLineView {get; set; } 
            public NewSupplierRequestQuotationFromCopyChildDialogView NewSupplierRequestQuotationFromCopyChildDialogView {get; set; } 
            public SupplierReqQuotationAdvanceView SupplierReqQuotationAdvanceView {get; set; } 
            public SupplierRequestQuotationVariablePaymentView SupplierRequestQuotationVariablePaymentView {get; set; } 
            public OrderGenerateChildDialogView OrderGenerateChildDialogView {get; set; } 
            public SupplierRQFPrintDialogView SupplierRQFPrintDialogView {get; set; } 
            public ChangeReceivedStatusAceptedChildDialogView ChangeReceivedStatusAceptedChildDialogView {get; set; } 
            public ChangeSupplierChildDialogView ChangeSupplierChildDialogView {get; set; } 
            public FrameworkContractFromSupplierRequesQuotationChildDialogView FrameworkContractFromSupplierRequesQuotationChildDialogView {get; set; } 
            public ChaneSupplierRFQLinesDialogView ChaneSupplierRFQLinesDialogView {get; set; } 
            public UpdateCostsOfferLineChildDialogView UpdateCostsOfferLineChildDialogView {get; set; } 
            public CuDistEmployeeChangedPopUpDialogView CuDistEmployeeChangedPopUpDialogView {get; set; } 
    }
            
    public partial class SupplierRequestQuotationCollectionView : View
    {
        public SupplierRequestQuotationCollectionView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierRequestQuotationCollectionView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5db35dc4-2682-47fc-a176-e1737c427709",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierRequestQuotationCollectionView,SupplierRequestQuotationEntityView>( params_MainConsult,this,Screen.SupplierRequestQuotationEntityView);
 

        }
        public IRPSButton<SupplierRequestQuotationCollectionView,SupplierRequestQuotationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierRequestQuotationCollectionView,SupplierRequestQuotationEntityView> MainConsult { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierRequestQuotationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierRequestQuotationEntityView : View
    {
        public SupplierRequestQuotationEntityView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierRequestQuotationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierRequestQuotationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierRequestQuotationEntityView,SupplierRequestQuotationCollectionView>( this,Screen.SupplierRequestQuotationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierRequestQuotationEntityView,SupplierRequestQuotationCollectionView>( this,Screen.SupplierRequestQuotationCollectionView);
 
            UITotalLines = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("630c64e3-dfd7-4cf4-a7f1-a248ff37c606","","",false, this);
 
            UIBase = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("79ac5423-d68e-4e66-8ff1-71fa5ebf3329","","",false, this);
 
            UITotalVAT = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("53d855f5-25bb-4a71-bb33-d05bdcb3bacf","","",false, this);
 
            UITotal = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("e4692b6e-9cb1-470d-951b-44b06f8043ee","","",false, this);
 
            UITotalAdvances = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("7be22c9b-210a-41b6-a2fb-f87b3735c9f7","","",false, this);
 
            InsertPurchaseProposalCommandButton = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationEntityView>( "05539e9c-a96c-4330-8a59-cc5797a81df3","","",this);
 
            ChaneSupplierRFQLinesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,ChaneSupplierRFQLinesDialogView>("ee79ad5e-7d1c-443d-8445-44dc455acfb6","","", this,Screen.ChaneSupplierRFQLinesDialogView);
 
            CodSupplierRFQ = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("99923047-b957-45a2-b973-870737178423","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("096a2065-6877-4504-88c1-42ff7428cda0","","",true, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("cebc7db6-92ab-404f-a8fc-68890862cbb2","","",false, this);
 
            SupplierRFQNumber = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("f286b9bb-956d-42df-9eb8-2fc0f87f0f00","","",false, this);
 
            UIOrderStatus = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("44994eb2-4b0b-4310-9ded-9a7b3f395062","","",false, this);
 
            IDSupplierRQuotationType = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("5e8f7482-ac62-4590-8340-ca8a32dd791d","","",false, this);
 
            SupplierRFQGroup = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("c2652ae5-2383-4651-985e-436dd20f95f6","","",false, this);
 
            Printed = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationEntityView>("eb860eaa-8f1d-4033-9904-157bed4e625e","","",true, this);
 
            SupplierRFQDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("0ae808de-bd2a-4624-b033-cb546920244a","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("35a01109-a762-4b79-bc7b-6a1099ca6001","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("a5f020e2-2a2d-4c87-8a38-759017e1c987","","",true, this);
 
            FrameworkContract = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationEntityView>("adc5e3d9-ec22-4d72-b133-83702b59e4c3","","",true, this);
 
            ImpressionNumber = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("02956bed-1de4-4df9-a8c5-4094d2553d46","","",false, this);
 
            LastPrintDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("5003458f-e2cc-4b24-aed6-ce733cb5cbda","","",false, this);
 
            LastPrintUser = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("bdc46429-ab28-4d98-95fe-5375b631939d","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("367faba5-7e6a-40dd-9103-61a8c2edee3b","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("f1a5511a-3ba7-4612-8ae0-ae1c05a8e7fc","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("ce2aa1e7-a5b5-4c18-b435-f7878bc4ff91","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationEntityView>("ae0b9866-725c-41e3-a4df-a0c2e36f8ab8","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("d1a81951-7772-4d12-bf91-66d0cd10df1b","","",false, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("51c4a9a6-084a-49cb-8c2a-2e9a4f6c19d4","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("70dca2bd-abef-4fae-867f-fef34ef31e9b","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("24a1c64b-abd5-4ac1-9aee-f37e570cb974","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("e26ee24c-df47-4d4e-9fde-31ac0e6f9d2e","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("6a419871-37ed-4917-90a7-72900f12d5e7","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationEntityView>("d1196bd2-a314-4f59-8b8c-f80ead73cf53","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("a56072ab-90c6-4827-94a2-aacad946fa2f","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("e8d46fe9-3a32-4392-bc1c-eb55efcc59c9","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("9f065580-d6a1-4d31-86cf-1c29d53ed9bd","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("f5a5be03-81bf-48f5-866b-e8499793fc98","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("5233e7a1-7a88-4b9e-937c-358109aa5682","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("e888063d-1d80-4392-8df9-65beb9864edc","","",false, this);
 
            IDSupplierOrderAddress = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("1d325e4a-b96a-4477-9141-d4a8c781055c","","",false, this);
 
            IDDeliveryAddress = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("7ff6d461-1f80-4ae0-b80a-78ec5905428f","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("de14ef8f-8d42-4813-8edb-263d47c44544","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("0a9eb156-552d-4796-8862-5f29ee6ae362","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("f8c16ea6-0d87-4391-9b46-b8ecd5c63ab3","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("3fcd67d3-9e78-4360-84e0-07875e6b3706","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("f82d2bb0-ada7-48e4-82a2-47d64fe1728a","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("dcb6bb49-11b3-45ad-9920-5c8ebbea29bc","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("4341dcf3-0d9a-40c1-8911-d945f3724903","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("1558bbfa-edb8-467d-9d71-f2d017466db1","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("db982d03-1c7d-4741-8a87-b65acd1650a0","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("4a542743-1e1a-4b82-a095-b90fb6a18905","","",false, this);
 
            IDRequester = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationEntityView>("6d8a2669-7686-4486-9cc2-1770ffaf2ce1","","",false, this);
 
            RequestDescription = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationEntityView>("66742d6f-bd78-4b9d-a692-5183928bee95","","",false, this);
 
            SupplierRQFPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,SupplierRQFPrintDialogView>("e7b9691b-5b2f-4ab9-bf64-0dba0dfbd56e","","", this,Screen.SupplierRQFPrintDialogView);
 
            NewSupplierRequestQuotationFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,NewSupplierRequestQuotationFromCopyChildDialogView>("8a7f6fc9-0798-4f31-a1fb-5c6e2213304e","","", this,Screen.NewSupplierRequestQuotationFromCopyChildDialogView);
 
            ChangeReceivedStatusReceivedCommandButton = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationEntityView>( "46fbdf83-311b-495c-b26d-4b04780a271e","","",this);
 
            ChangeReceivedStatusAceptedChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,ChangeReceivedStatusAceptedChildDialogView>("18ae70f3-e256-482f-af1d-10f892255c9c","","", this,Screen.ChangeReceivedStatusAceptedChildDialogView);
 
            ExecuteChangeReceivedStatusRejectedButton = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationEntityView>( "26cce461-d58f-4515-9ad1-e7ad2d8251f1","","",this);
 
            OrderGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,OrderGenerateChildDialogView>("423d34ab-c8f5-41eb-92c5-79e0a5cb7b2a","","", this,Screen.OrderGenerateChildDialogView);
 
            ChangeSupplierChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,ChangeSupplierChildDialogView>("8d3c6bc5-a0d0-4ed2-bf31-a04ed7a60e2f","","", this,Screen.ChangeSupplierChildDialogView);
 
            FrameworkContractFromSupplierRequesQuotationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,FrameworkContractFromSupplierRequesQuotationChildDialogView>("f79aad0a-f968-4577-ab6c-b54891bf48bf","","", this,Screen.FrameworkContractFromSupplierRequesQuotationChildDialogView);
 
            ExecuteGetTotalSupplierRequestQuotationButton = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationEntityView>( "13238420-2388-4ef0-a523-cb754697fd07","","",this);
 
            UpdateCostsOfferLineChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationEntityView,UpdateCostsOfferLineChildDialogView>("8ac79e4f-1bab-45f9-98e5-78a5c5559f94","","", this,Screen.UpdateCostsOfferLineChildDialogView);
 
            CollectionInit params_SupplierRequestQuotationLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c95d1f42-7806-4ded-9e41-3b425a879751",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationLines = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationLinesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>,SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>( params_SupplierRequestQuotationLines,this,Screen.SupplierRequestQuotationLineView);
 
            CollectionInit params_SupplierReqQuotationAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6",CSSSelectorGrid="",XPathGrid=""};
            SupplierReqQuotationAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierReqQuotationAdvancesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>,SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>( params_SupplierReqQuotationAdvances,this,Screen.SupplierRequestQuotationLineView);
 
            CollectionInit params_SupplierRequestQuotationVariablePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90f92d47-a24d-4820-a8d8-f90f608d584f",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationVariablePayments = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationVariablePaymentsCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>,SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>( params_SupplierRequestQuotationVariablePayments,this,Screen.SupplierRequestQuotationLineView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='40f086fd-c7ff-4352-a2bf-52e3c2aa5fcd']","",this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='c99e1409-6150-4fe3-a159-6a5022440f7f']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='4dbac138-8bd8-46b6-ac13-a2286d86689b']","",this);
 
            Advances = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='3e7ef03c-a0ef-47cf-aaae-066b5fe45904']","",this);
 
            VariablePayments = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='cb48b776-450b-4d4a-9532-d75fb73f2288']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='ea63890f-52df-4b26-a880-db3e7eaf0abb']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationEntityView>( "","ul li[rpsid='3092f9c0-b583-4574-80a6-efcc8a2cc499']","",this);
 

        }
        public IRPSSaveButton<SupplierRequestQuotationEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,SupplierRequestQuotationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,SupplierRequestQuotationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UITotalLines { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UIBase { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UITotalVAT { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UITotal { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UITotalAdvances { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView> InsertPurchaseProposalCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,ChaneSupplierRFQLinesDialogView> ChaneSupplierRFQLinesNavigationCommandButton { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> CodSupplierRFQ { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDSupplierContact { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> SupplierRFQNumber { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> UIOrderStatus { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDSupplierRQuotationType { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> SupplierRFQGroup { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationEntityView> Printed { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> SupplierRFQDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> ReceptionDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> ReceptionDemandDate { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationEntityView> FrameworkContract { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> ImpressionNumber { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> LastPrintDate { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> LastPrintUser { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Change { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationEntityView> FixedChange { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> PurchaseManager { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Discount1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Discount2 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Discount3 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> CashDiscount { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDEmployee { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Comment { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> PreText { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> PostText { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDSupplierOrderAddress { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDDeliveryAddress { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> City { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> ZipCode { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> ContactPerson { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> CodCountry { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDCounty { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDState { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> Fax { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationEntityView> IDRequester { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationEntityView> RequestDescription { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,SupplierRQFPrintDialogView> SupplierRQFPrintNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,NewSupplierRequestQuotationFromCopyChildDialogView> NewSupplierRequestQuotationFromCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView> ChangeReceivedStatusReceivedCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,ChangeReceivedStatusAceptedChildDialogView> ChangeReceivedStatusAceptedChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView> ExecuteChangeReceivedStatusRejectedButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,OrderGenerateChildDialogView> OrderGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,ChangeSupplierChildDialogView> ChangeSupplierChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,FrameworkContractFromSupplierRequesQuotationChildDialogView> FrameworkContractFromSupplierRequesQuotationChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView> ExecuteGetTotalSupplierRequestQuotationButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationEntityView,UpdateCostsOfferLineChildDialogView> UpdateCostsOfferLineChildNavigationCommandButton { get; set; } 
        public SupplierRequestQuotationLinesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> SupplierRequestQuotationLines { get; set; } 
        public SupplierReqQuotationAdvancesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> SupplierReqQuotationAdvances { get; set; } 
        public SupplierRequestQuotationVariablePaymentsCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> SupplierRequestQuotationVariablePayments { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> LinesSection { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> Comments { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> Advances { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> VariablePayments { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> Section { get; set; } 
        public IRPSSection<SupplierRequestQuotationEntityView> DPS { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierRequestQuotationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRequestQuotationLinesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>:RPSCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public  SupplierRequestQuotationLinesGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationLinesGridView <SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> :  RPSGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public SupplierRequestQuotationLinesGridView(SupplierRequestQuotationEntityView currentView,SupplierRequestQuotationLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cReferenceSupplier']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            IDPurchaseProposal = RPSControlFactory.CreateRPSGridComboBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cIDPurchaseProposal']","",false, this.CurrentView);
 
            ReceivedStatus = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierRequestQuotationEntityView>("","#c95d1f42-7806-4ded-9e41-3b425a879751 .ag-row[role='row']@ROWINDEX [col-id='cReceivedStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierRequestQuotationEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Matchcode { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> ReferenceSupplier { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> QuantityFrom { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Price { get; set; } 
        public IRPSGridCheckbox<SupplierRequestQuotationEntityView> VAT { get; set; } 
        public IRPSGridComboBox<SupplierRequestQuotationEntityView> IDPurchaseProposal { get; set; } 
        public IRPSGridComboBox<SupplierRequestQuotationEntityView> ReceivedStatus { get; set; } 
                     
    }
 
        public partial class SupplierReqQuotationAdvancesCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>:RPSCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public  SupplierReqQuotationAdvancesGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> GridView {get;set;}
    }
    public partial class SupplierReqQuotationAdvancesGridView <SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> :  RPSGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public SupplierReqQuotationAdvancesGridView(SupplierRequestQuotationEntityView currentView,SupplierRequestQuotationLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumAdvance = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cNumAdvance']","",true, this.CurrentView);
 
            AdvanceDate = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            Invoice = RPSControlFactory.CreateRPSGridCheckBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cInvoice']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierRequestQuotationEntityView>("","#d8c98bd2-ecba-4dc2-a58b-6b6140d77cf6 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> NumAdvance { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> AdvanceDate { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Amount { get; set; } 
        public IRPSGridCheckbox<SupplierRequestQuotationEntityView> VAT { get; set; } 
        public IRPSGridCheckbox<SupplierRequestQuotationEntityView> Invoice { get; set; } 
        public IRPSGridComboBox<SupplierRequestQuotationEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class SupplierRequestQuotationVariablePaymentsCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView>:RPSCollectionEditor<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public  SupplierRequestQuotationVariablePaymentsGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationVariablePaymentsGridView <SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> :  RPSGridView<SupplierRequestQuotationEntityView,SupplierRequestQuotationLineView> where SupplierRequestQuotationEntityView : class, IView where SupplierRequestQuotationLineView : class, IView
    {
        public SupplierRequestQuotationVariablePaymentsGridView(SupplierRequestQuotationEntityView currentView,SupplierRequestQuotationLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",false, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<SupplierRequestQuotationEntityView>("","#90f92d47-a24d-4820-a8d8-f90f608d584f .ag-row[role='row']@ROWINDEX [col-id='cRest']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> DayPayment { get; set; } 
        public IRPSGridComboBox<SupplierRequestQuotationEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Amount { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<SupplierRequestQuotationEntityView> Rest { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierRequestQuotationLineView : View
    {
        public SupplierRequestQuotationLineView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierRequestQuotationLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("fbdf2fce-7e06-471a-a0e3-c7d5adc903bc","","",true, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationLineView>("542a5909-29c8-4c22-b6da-934ea74a98e3","","",false, this);
 
            QuantityFrom1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("2b62317a-992b-453b-86d0-44d8cf0e5f4b","","",true, this);
 
            Price1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("92cfc7c0-fa07-4216-a8f1-7184169025a6","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("044d9110-ce9b-4543-8f95-1368711cf808","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("8711604a-e3f1-41df-931f-411cb8945210","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("1872ace1-65df-4f2c-9688-621e01cefe0d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("4e7f7355-6965-4f63-9da3-452f3a9de80b","","",false, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("85016780-ccef-494d-9ffe-e56cdff380ff","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("ea1d6368-3654-4914-a3bf-0855c09b72f7","","",true, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("1f589579-6143-4591-94fd-a001bde845e6","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("6ad8827f-d853-453b-8e6f-18a16e5d3fae","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("7b3eb7c2-8c61-43fd-94f6-f96e924d4fbb","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("f243d135-ed84-43bb-af0c-52c0db81744a","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("b5429244-9f4c-483b-bee2-99391728276d","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("561a545c-d4f6-463b-8201-5b1082e0ce9b","","",true, this);
 
            ReceivedStatus = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationLineView>("354e1426-8b7a-4fb5-97de-1e1e9cd5b2b6","","",false, this);
 
            IDPurchaseProposal = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("88bf377a-66cf-4166-a4f0-3240bd51712d","","",false, this);
 
            AcceptedDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("70f24222-18e9-4286-a556-79be3d46c0c4","","",false, this);
 
            ReceivedDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("56a2cb7a-e972-4836-85e0-42873a0ed463","","",false, this);
 
            OrderQuantity = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("74784454-7a3f-47c9-93a9-ba8046fe611c","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("93462dd9-11fa-4e7e-b91b-d32e8c600471","","",true, this);
 
            MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("89987111-6037-4943-91ed-16e37d59300c","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("d6bcf932-f3e8-44d0-b84d-c24148369db9","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("0d789bd7-fc90-4cf5-bf72-9a1d21ecd7d0","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("bdc2fb7c-639b-4a13-9ca8-ba7517b2c125","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("e3d8de3b-361b-42e3-baf3-d5c1d50d2828","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("d1875f62-8ccc-4542-9dd8-6dccfcfc5f1b","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("828478d8-cb5d-4278-8d71-193d322ef4f1","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("a17e2a27-74d0-4575-b5a1-feefb5f11872","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("b936cf38-47a3-4e47-86cc-2612778dbd78","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("bba29b6a-ec72-4957-912e-7c6c16c406ff","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("77e4bfb6-bb23-4c88-b33c-f7fce1a1852f","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("f7a920a9-39d1-49cd-8ba1-744567d7b82f","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("b818e40c-daed-4e7a-bf62-aaa8224a154d","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("eecc69d0-72b8-472b-80b7-40a2f09f5ed5","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationLineView>("53f9b590-ce35-4bb7-a960-3fc50a0421f8","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("e297ec7d-5786-47c9-aab7-a8c8a674fbaf","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("ba2accce-bc37-4da3-aec6-5a033cfe0ada","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("dd9eb01d-f3db-49e6-b75d-7c8e8ede80e8","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationLineView>("7b25ad55-61a8-4d93-a486-38781c6701c8","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("ede86033-9322-4238-8cbd-9dfd51d8fd10","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("4285d298-2f5a-4640-9c7b-95e846b8fcd6","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("1b5e33f6-7be8-437b-8829-e05f0df1f3eb","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("ab424961-81eb-4743-933c-3e3e9ab1fcd1","","",false, this);
 
            IDProMaterial = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("6f9330d2-b419-45fd-86c3-69fc389c8a4a","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("692f02a5-da68-45f4-ac7d-ba01df8b29e3","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("36be8f15-abdd-411a-9699-95b39fa20340","","",false, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("acf22808-d6ec-4617-bc93-01df11d3ed91","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("90479f41-c1c4-4335-ae13-ea98d7581077","","",false, this);
 
            UIExternalTask = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationLineView>("d15137fa-ae0f-46a6-871f-caedd56b26ec","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("7bcf803b-c5bd-44c4-9d55-3ae498e1c4a5","","",false, this);
 
            UIIDOrderSL = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("83183328-faf7-4ce6-b89f-1cb22445aca6","","",false, this);
 
            IDOrderLineSales = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("1e7af277-372e-4410-9ee5-ac425c35b4f0","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("85da11c3-4ad1-4c43-a5b9-446447cfd09b","","",false, this);
 
            IDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("d6b5fea8-d1c8-44bf-abfc-b6c41d8ea450","","",false, this);
 
            IDQuotation = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("8d8971cb-b45c-4fc7-b708-e5927f935ef2","","",false, this);
 
            IDQuotationMaterial = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("b324d10f-60c1-435f-aeb6-dd63f8164313","","",false, this);
 
            IDQuotationMaterialLot = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("ff3f355d-b9d5-406b-96c7-73e5a67f44f2","","",false, this);
 
            IDQuotationTask = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("0845e27e-e324-405e-833e-4ed03bff5304","","",false, this);
 
            IDQuotationTaskLot = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationLineView>("1925c3ea-396d-42dd-ba97-455e4f1e2862","","",false, this);
 
            ExecuteSupplierRQLineCommentAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationLineView>( "8cf1093f-b446-492f-bf76-b742aa6ef223","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("5abb8056-1128-42aa-bbf5-26c570a59c31","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationLineView>("f3809d06-315d-4e6c-9132-2c553037535e","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationLineView>( "","ul li[rpsid='72409eba-8670-4c7e-aad4-d109069e38b6']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationLineView>( "","ul li[rpsid='a467eeb0-6bfa-4ec8-8364-7dd7799b6f27']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<SupplierRequestQuotationLineView>( "","ul li[rpsid='df0b6359-e4dc-4669-a3f6-7f3f9e947a6a']","",this);
 

        }
        public IRPSButton<SupplierRequestQuotationLineView> DeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierRequestQuotationLineView,SupplierRequestQuotationEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDArticle { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> ReferenceSupplier { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> QuantityFrom1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Price1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Amount { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> VAT { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Description { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Ordenation { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDUnitPrice { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> ReceptionDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> ReceptionDemandDate { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> ReceivedStatus { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDPurchaseProposal { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> AcceptedDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> ReceivedDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> OrderQuantity { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> PurchaseLot { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> MinimumLot { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> DeliveryDays { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDEmployee { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Discount1 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Discount2 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Discount3 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Discount4 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Discount5 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDVAT { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> PercentVAT { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> PercentSurcharge { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDSite { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDProject { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDProTask { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDProMaterial { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDMOTask { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDMOMaterial { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDArticleStructure { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationLineView> UIExternalTask { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> InternalCode { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> UIIDOrderSL { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDOrderLineSales { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDOrderMaterialPrevision { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDQuotation { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDQuotationMaterial { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDQuotationMaterialLot { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDQuotationTask { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationLineView> IDQuotationTaskLot { get; set; } 
        public IRPSButton<SupplierRequestQuotationLineView> ExecuteSupplierRQLineCommentAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Comment { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationLineView> Matchcode { get; set; } 
        public IRPSSection<SupplierRequestQuotationLineView> Section { get; set; } 
        public IRPSSection<SupplierRequestQuotationLineView> Section1 { get; set; } 
        public IRPSSection<SupplierRequestQuotationLineView> DPS { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierRequestQuotationLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewSupplierRequestQuotationFromCopyChildDialogView : View
    {
        public NewSupplierRequestQuotationFromCopyChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RecalculateHead = RPSControlFactory.CreateRPSCheckBox<NewSupplierRequestQuotationFromCopyChildDialogView>("c0feef5b-b1fd-49ef-b694-6b7865842d0d","","",false, this);
 
            AdvanceCopy = RPSControlFactory.CreateRPSCheckBox<NewSupplierRequestQuotationFromCopyChildDialogView>("91469055-2e02-42e9-a04f-f7da1700d55b","","",false, this);
 
            VariablePaymentCopy = RPSControlFactory.CreateRPSCheckBox<NewSupplierRequestQuotationFromCopyChildDialogView>("31a46b2f-f060-4824-8d7c-3711347bbf29","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<NewSupplierRequestQuotationFromCopyChildDialogView>("5c62b1d2-cf7c-4d2f-afb3-aba632cd9e25","","",false, this);
 
            SupplierRFQGroup = RPSControlFactory.CreateRPSTextBox<NewSupplierRequestQuotationFromCopyChildDialogView>("e86762bb-20fd-4a73-8837-9b062c810f96","","",false, this);
 
            SelectedSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<NewSupplierRequestQuotationFromCopyChildDialogView>("ab520640-efd3-4f84-8c21-ed9924e94d62","","",false, this);
 
            AddSupplierToGroupCommandButton = RPSControlFactory.CreateRPSButton<NewSupplierRequestQuotationFromCopyChildDialogView>( "52571fec-3fe7-4ae6-a72f-3fec9f028e67","","",this);
 
            CollectionInit params_SupplierShownVM = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06e0dbba-d37b-4b56-afe4-1cb0946c1d75",CSSSelectorGrid="",XPathGrid=""};
            SupplierShownVM = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierShownVMCollectionEditor<NewSupplierRequestQuotationFromCopyChildDialogView>,NewSupplierRequestQuotationFromCopyChildDialogView>( params_SupplierShownVM,this);
 

        }
        public IRPSCheckbox<NewSupplierRequestQuotationFromCopyChildDialogView> RecalculateHead { get; set; } 
        public IRPSCheckbox<NewSupplierRequestQuotationFromCopyChildDialogView> AdvanceCopy { get; set; } 
        public IRPSCheckbox<NewSupplierRequestQuotationFromCopyChildDialogView> VariablePaymentCopy { get; set; } 
        public IRPSCheckbox<NewSupplierRequestQuotationFromCopyChildDialogView> CopyDocuments { get; set; } 
        public IRPSTextBox<NewSupplierRequestQuotationFromCopyChildDialogView> SupplierRFQGroup { get; set; } 
        public IRPSCollectionComboBox<NewSupplierRequestQuotationFromCopyChildDialogView> SelectedSupplierGroup { get; set; } 
        public IRPSButton<NewSupplierRequestQuotationFromCopyChildDialogView> AddSupplierToGroupCommandButton { get; set; } 
        public SupplierShownVMCollectionEditor<NewSupplierRequestQuotationFromCopyChildDialogView> SupplierShownVM { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public NewSupplierRequestQuotationFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierShownVMCollectionEditor<NewSupplierRequestQuotationFromCopyChildDialogView>:RPSCollectionEditor<NewSupplierRequestQuotationFromCopyChildDialogView> where NewSupplierRequestQuotationFromCopyChildDialogView : class, IView
    {
        public  SupplierShownVMGridView<NewSupplierRequestQuotationFromCopyChildDialogView> GridView {get;set;}
    }
    public partial class SupplierShownVMGridView <NewSupplierRequestQuotationFromCopyChildDialogView> :  RPSGridView<NewSupplierRequestQuotationFromCopyChildDialogView> where NewSupplierRequestQuotationFromCopyChildDialogView : class, IView
    {
        public SupplierShownVMGridView(NewSupplierRequestQuotationFromCopyChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveCommand = RPSControlFactory.CreateRPSGridButton<NewSupplierRequestQuotationFromCopyChildDialogView>( "","#06e0dbba-d37b-4b56-afe4-1cb0946c1d75 .ag-row[role='row']@ROWINDEX [col-id='cRemoveCommand']","",this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<NewSupplierRequestQuotationFromCopyChildDialogView>("","#06e0dbba-d37b-4b56-afe4-1cb0946c1d75 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<NewSupplierRequestQuotationFromCopyChildDialogView> RemoveCommand { get; set; } 
        public IRPSGridComboBox<NewSupplierRequestQuotationFromCopyChildDialogView> IDSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierReqQuotationAdvanceView : View
    {
        public SupplierReqQuotationAdvanceView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierReqQuotationAdvanceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            NumAdvance = RPSControlFactory.CreateRPSFormattedTextBox<SupplierReqQuotationAdvanceView>("b2e1bf61-f939-48cc-9d4f-2684cedc2986","","",true, this);
 
            AdvanceDate = RPSControlFactory.CreateRPSTextBox<SupplierReqQuotationAdvanceView>("1cbc8b7e-9122-4536-b9cd-e798618988e8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierReqQuotationAdvanceView>("60c8db61-d08a-4092-a47c-aad6fe147101","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierReqQuotationAdvanceView>("0a67152b-df6f-4d50-bf0c-98d24d697d6c","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SupplierReqQuotationAdvanceView>("21577f81-47c8-4e5b-844e-c8ccd0064f85","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<SupplierReqQuotationAdvanceView>("523d4451-76c0-465a-a05e-d5b8075454ac","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierReqQuotationAdvanceView>("cbfdb443-379c-477e-a4d5-74709073263a","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierReqQuotationAdvanceView>("481bc33f-681e-4529-bf18-aeed8203c7c5","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierReqQuotationAdvanceView>( "","ul li[rpsid='3ad51737-540f-4f01-a16b-d3c2eca3decd']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<SupplierReqQuotationAdvanceView>( "","ul li[rpsid='23cfdc90-ad5e-4d12-b117-81f7f165cf60']","",this);
 

        }
        public IRPSButton<SupplierReqQuotationAdvanceView> DeleteButton { get; set; } 
        public IRPSButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierReqQuotationAdvanceView,SupplierRequestQuotationEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierReqQuotationAdvanceView> NumAdvance { get; set; } 
        public IRPSTextBox<SupplierReqQuotationAdvanceView> AdvanceDate { get; set; } 
        public IRPSTextBox<SupplierReqQuotationAdvanceView> Description { get; set; } 
        public IRPSTextBox<SupplierReqQuotationAdvanceView> Amount { get; set; } 
        public IRPSCheckbox<SupplierReqQuotationAdvanceView> VAT { get; set; } 
        public IRPSCheckbox<SupplierReqQuotationAdvanceView> Invoice { get; set; } 
        public IRPSComboBox<SupplierReqQuotationAdvanceView> IDPaymentMethod { get; set; } 
        public IRPSTextBox<SupplierReqQuotationAdvanceView> Comment { get; set; } 
        public IRPSSection<SupplierReqQuotationAdvanceView> GeneralData { get; set; } 
        public IRPSSection<SupplierReqQuotationAdvanceView> Comment1 { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierReqQuotationAdvanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierRequestQuotationVariablePaymentView : View
    {
        public SupplierRequestQuotationVariablePaymentView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierRequestQuotationVariablePaymentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView>( this,Screen.SupplierRequestQuotationEntityView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationVariablePaymentView>("015c0fb1-b42a-48cd-b79e-b76bcd5ba2f4","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationVariablePaymentView>("15cabd2c-b4d1-4338-903c-7c8216a461a8","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationVariablePaymentView>("f15ab9fb-c6aa-419e-901b-9a6e9a8f6051","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationVariablePaymentView>("d30f2616-9951-424a-906e-a8dfe498fa4c","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationVariablePaymentView>("19efc24d-704b-42d8-8b3c-d91b6349096b","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationVariablePaymentView>("34897c0c-74d9-495f-ad73-96a9c96da8b6","","",false, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationVariablePaymentView>("051f9df5-6f56-4f8e-b154-07d2ecb8d23e","","",true, this);
 

        }
        public IRPSButton<SupplierRequestQuotationVariablePaymentView> DeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierRequestQuotationVariablePaymentView,SupplierRequestQuotationEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationVariablePaymentView> NumPayment { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationVariablePaymentView> DatePayment { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationVariablePaymentView> DayPayment { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationVariablePaymentView> IDPaymentMethod { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationVariablePaymentView> Percentage { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationVariablePaymentView> Amount { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationVariablePaymentView> Rest { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierRequestQuotationVariablePaymentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderGenerateChildDialogView : View
    {
        public OrderGenerateChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OrderDate = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("2a385e60-cdd0-4d57-bed2-cd218620f74d","","",true, this);
 
            ReceptionDateOfer = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "ba05d04e-4897-462f-bf22-5bd9bc918f7e","","",this);
 
            Recalculate = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "91bcf9c9-4148-41c0-b189-6ab0604a0390","","",this);
 
            Advances = RPSControlFactory.CreateRPSCheckBox<OrderGenerateChildDialogView>("8a007e95-e032-4a1b-a55d-92c57e036baf","","",false, this);
 
            Documents = RPSControlFactory.CreateRPSCheckBox<OrderGenerateChildDialogView>("4594041d-c008-4fb0-be30-9f7ff9b3e66c","","",false, this);
 
            VariablePayments = RPSControlFactory.CreateRPSCheckBox<OrderGenerateChildDialogView>("efd6cbcd-2537-48c1-b79f-7e943d2e86e5","","",false, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("c3d01b85-9fe4-4e1f-9b38-6b4af6ba5476","","",false, this);
 
            CollectionInit params_OrderGenerateGridLinesCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2fd332bf-440d-4a49-bf46-ff8d2b1c5120",CSSSelectorGrid="",XPathGrid=""};
            OrderGenerateGridLinesCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OrderGenerateGridLinesCollectionCollectionEditor<OrderGenerateChildDialogView>,OrderGenerateChildDialogView>( params_OrderGenerateGridLinesCollection,this);
 

        }
        public IRPSTextBox<OrderGenerateChildDialogView> OrderDate { get; set; } 
        public IRPSOption<OrderGenerateChildDialogView> ReceptionDateOfer { get; set; } 
        public IRPSOption<OrderGenerateChildDialogView> Recalculate { get; set; } 
        public IRPSCheckbox<OrderGenerateChildDialogView> Advances { get; set; } 
        public IRPSCheckbox<OrderGenerateChildDialogView> Documents { get; set; } 
        public IRPSCheckbox<OrderGenerateChildDialogView> VariablePayments { get; set; } 
        public IRPSTextBox<OrderGenerateChildDialogView> CodOrder { get; set; } 
        public OrderGenerateGridLinesCollectionCollectionEditor<OrderGenerateChildDialogView> OrderGenerateGridLinesCollection { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public OrderGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderGenerateGridLinesCollectionCollectionEditor<OrderGenerateChildDialogView>:RPSCollectionEditor<OrderGenerateChildDialogView> where OrderGenerateChildDialogView : class, IView
    {
        public  OrderGenerateGridLinesCollectionGridView<OrderGenerateChildDialogView> GridView {get;set;}
    }
    public partial class OrderGenerateGridLinesCollectionGridView <OrderGenerateChildDialogView> :  RPSGridView<OrderGenerateChildDialogView> where OrderGenerateChildDialogView : class, IView
    {
        public OrderGenerateGridLinesCollectionGridView(OrderGenerateChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderGenerateChildDialogView>("","#2fd332bf-440d-4a49-bf46-ff8d2b1c5120 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderGenerateChildDialogView>("","#2fd332bf-440d-4a49-bf46-ff8d2b1c5120 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderGenerateChildDialogView>("","#2fd332bf-440d-4a49-bf46-ff8d2b1c5120 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",true, this.CurrentView);
 
            QuantityToOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderGenerateChildDialogView>("","#2fd332bf-440d-4a49-bf46-ff8d2b1c5120 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderGenerateChildDialogView> IDArticle { get; set; } 
        public IRPSGridTextBox<OrderGenerateChildDialogView> QuantityFrom { get; set; } 
        public IRPSGridTextBox<OrderGenerateChildDialogView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<OrderGenerateChildDialogView> QuantityToOrder { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierRQFPrintDialogView : View
    {
        public SupplierRQFPrintDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSupplier = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "487d5fb8-853d-4fc3-987c-301a25177f28","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "8b12961e-cb7c-4591-ac02-bbca26843961","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<SupplierRQFPrintDialogView>("bad798a5-0838-429c-937b-414d127fa987","","",false, this);
 
            UISRQPrintOptDocuments = RPSControlFactory.CreateRPSCheckBox<SupplierRQFPrintDialogView>("99b2f343-e26f-4ca0-b3e7-7062dd11eae5","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "9e86a6ef-a5c8-4a94-acf5-24867c8775be","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "fa1ea699-9126-4ff9-ae52-ecfe67269c7b","","",this);
 
            UISRQPrintOptArticleDocuments = RPSControlFactory.CreateRPSCheckBox<SupplierRQFPrintDialogView>("1b8cfee0-0d62-472c-8021-226363640564","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "a0f0839e-4a88-41da-8515-a7b0fd11e40b","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "26bd017c-a4de-4e54-8152-19500be540ff","","",this);
 
            UIDocumentsMaterial = RPSControlFactory.CreateRPSCheckBox<SupplierRQFPrintDialogView>("cfee148d-a1d8-4ffc-89a6-7f20ee62d7c9","","",false, this);
 
            UIOptAllDocuments2 = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "61a7f007-3479-4a1a-9974-75009e2e55b0","","",this);
 
            UIOptByDocument2 = RPSControlFactory.CreateRPSOption<SupplierRQFPrintDialogView>( "89089c03-c6a3-4f26-add9-46db068bbd16","","",this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<SupplierRQFPrintDialogView>("23f50b0e-8b8c-48a2-bc74-cfc27bf5ac6e","","",false, this);
 
            UICodOrderReport = RPSControlFactory.CreateRPSComboBox<SupplierRQFPrintDialogView>("604969fe-5c2c-49d7-b576-bc510400f99d","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<SupplierRQFPrintDialogView>("96842611-8093-4add-a261-9552035e6b88","","",false, this);
 
            LaunchPrintedReportButton = RPSControlFactory.CreateRPSButton<SupplierRQFPrintDialogView>( "6786bcd2-7f42-4a6d-9529-758f3ad48e75","","",this);
 
            LaunchByEmailCommandButton = RPSControlFactory.CreateRPSButton<SupplierRQFPrintDialogView>( "23ffd191-7db1-458f-8023-02754bc569e4","","",this);
 
            LaunchToCustomerEmalCommandButton = RPSControlFactory.CreateRPSButton<SupplierRQFPrintDialogView>( "292f930b-547f-46df-8e98-ed28bc1bd668","","",this);
 

        }
        public IRPSOption<SupplierRQFPrintDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<SupplierRQFPrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<SupplierRQFPrintDialogView> UISRQPrintOptDocuments { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptAllDocuments { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<SupplierRQFPrintDialogView> UISRQPrintOptArticleDocuments { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<SupplierRQFPrintDialogView> UIDocumentsMaterial { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptAllDocuments2 { get; set; } 
        public IRPSOption<SupplierRQFPrintDialogView> UIOptByDocument2 { get; set; } 
        public IRPSCheckbox<SupplierRQFPrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<SupplierRQFPrintDialogView> UICodOrderReport { get; set; } 
        public IRPSCheckbox<SupplierRQFPrintDialogView> bClaim { get; set; } 
        public IRPSButton<SupplierRQFPrintDialogView> LaunchPrintedReportButton { get; set; } 
        public IRPSButton<SupplierRQFPrintDialogView> LaunchByEmailCommandButton { get; set; } 
        public IRPSButton<SupplierRQFPrintDialogView> LaunchToCustomerEmalCommandButton { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public SupplierRQFPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeReceivedStatusAceptedChildDialogView : View
    {
        public ChangeReceivedStatusAceptedChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bUpdateSupplier = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("a7b1a3fb-1220-4f35-9540-57629bc61326","","",false, this);
 
            bUpdatecost = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("44ee2b84-c913-4885-b555-40c38db7ec85","","",false, this);
 
            bUpdatePrices = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("abb0ef84-7d72-402b-b85d-1c0bdabe4e37","","",false, this);
 
            bQuantity = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("da0c0694-7fff-4d73-ad3b-8a896cb84c88","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ChangeReceivedStatusAceptedChildDialogView>("7d16bd01-7576-4763-8929-e97b8b43055e","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ChangeReceivedStatusAceptedChildDialogView>("47acea35-c7a3-4a63-9ffe-8edb96fe1c72","","",false, this);
 
            ALLLot = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("b26e7a89-e857-486c-b223-c8e4e061b2f8","","",false, this);
 

        }
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdateSupplier { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdatecost { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdatePrices { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bQuantity { get; set; } 
        public IRPSTextBox<ChangeReceivedStatusAceptedChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<ChangeReceivedStatusAceptedChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> ALLLot { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public ChangeReceivedStatusAceptedChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSupplierChildDialogView : View
    {
        public ChangeSupplierChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ChangeSupplierChildDialogView>("b386141f-9a65-4c17-85a6-1d6054023e9f","","",true, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeSupplierChildDialogView>("d0db0443-2e4f-4e9f-91eb-ecab117b8e6c","","",false, this);
 
            NewSupplier = RPSControlFactory.CreateRPSComboBox<ChangeSupplierChildDialogView>("91bd6cf6-8847-4940-8c55-31560620b21e","","",true, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeSupplierChildDialogView>("d952536c-f69b-4c0a-947b-7ff732b51aea","","",false, this);
 
            bChangeHeader = RPSControlFactory.CreateRPSCheckBox<ChangeSupplierChildDialogView>("b1a38687-3491-449b-a2b5-5db77525fb33","","",false, this);
 

        }
        public IRPSComboBox<ChangeSupplierChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<ChangeSupplierChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeSupplierChildDialogView> NewSupplier { get; set; } 
        public IRPSTextBox<ChangeSupplierChildDialogView> NewVATNumber { get; set; } 
        public IRPSCheckbox<ChangeSupplierChildDialogView> bChangeHeader { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public ChangeSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractFromSupplierRequesQuotationChildDialogView : View
    {
        public FrameworkContractFromSupplierRequesQuotationChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewFrameworkContractCode = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView>("2f6617a2-857c-40ac-90ab-70da606778b4","","",false, this);
 
            NewFrameworkContractDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView>("2445c235-f9a0-44af-9c44-e30ca2ef5edc","","",true, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<FrameworkContractFromSupplierRequesQuotationChildDialogView>("47981114-ea0b-414a-82ff-c8f7a9d7c246","","",false, this);
 
            NewFrameworkContractDateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView>("98983c96-e996-4b61-b012-dc6668398a58","","",true, this);
 
            NewFrameworkContractDateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView>("7e1cdb51-c431-492c-bca7-f467b6b14deb","","",true, this);
 

        }
        public IRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView> NewFrameworkContractCode { get; set; } 
        public IRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView> NewFrameworkContractDate { get; set; } 
        public IRPSCheckbox<FrameworkContractFromSupplierRequesQuotationChildDialogView> CopyDocuments { get; set; } 
        public IRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView> NewFrameworkContractDateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractFromSupplierRequesQuotationChildDialogView> NewFrameworkContractDateTo { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public FrameworkContractFromSupplierRequesQuotationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChaneSupplierRFQLinesDialogView : View
    {
        public ChaneSupplierRFQLinesDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<ChaneSupplierRFQLinesDialogView>("cb86d829-1725-4ca7-869e-d4b56a7027c2","","",false, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<ChaneSupplierRFQLinesDialogView>("c8e244f7-0cac-4795-9901-23af94bf0d29","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ChaneSupplierRFQLinesDialogView>("b04a9f2c-a006-4cdb-8472-8e8b38f7b3a8","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<ChaneSupplierRFQLinesDialogView>("d34cbaa9-72b8-4867-9965-5f183be51382","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ChaneSupplierRFQLinesDialogView>("d0b8412a-afda-42b5-959f-8a0d6b93d39f","","",false, this);
 

        }
        public IRPSTextBox<ChaneSupplierRFQLinesDialogView> ReceptionDate { get; set; } 
        public IRPSTextBox<ChaneSupplierRFQLinesDialogView> ReceptionDemandDate { get; set; } 
        public IRPSComboBox<ChaneSupplierRFQLinesDialogView> IDSite { get; set; } 
        public IRPSComboBox<ChaneSupplierRFQLinesDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<ChaneSupplierRFQLinesDialogView> IDEmployee { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public ChaneSupplierRFQLinesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateCostsOfferLineChildDialogView : View
    {
        public UpdateCostsOfferLineChildDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bUpdateSupplier = RPSControlFactory.CreateRPSCheckBox<UpdateCostsOfferLineChildDialogView>("fc5385d5-f6c4-450b-a74f-c11e62f18998","","",false, this);
 
            bUpdatecost = RPSControlFactory.CreateRPSCheckBox<UpdateCostsOfferLineChildDialogView>("ff658529-ff01-433e-a153-7cea483bb30a","","",false, this);
 
            bUpdatePrices = RPSControlFactory.CreateRPSCheckBox<UpdateCostsOfferLineChildDialogView>("990f69e8-8ab1-4ec6-970a-03e043a376eb","","",false, this);
 
            bQuantity = RPSControlFactory.CreateRPSCheckBox<UpdateCostsOfferLineChildDialogView>("09fcb996-62ff-4e53-a0b5-e1576940e306","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<UpdateCostsOfferLineChildDialogView>("f6cdd6dc-e01d-49d5-897d-cb41d80daf67","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<UpdateCostsOfferLineChildDialogView>("a6709382-c9b5-4a49-880e-4bb2cbe9d190","","",false, this);
 
            ALLLot = RPSControlFactory.CreateRPSCheckBox<UpdateCostsOfferLineChildDialogView>("2f7fdcd3-b761-4f2b-9d09-28183cb55f92","","",false, this);
 

        }
        public IRPSCheckbox<UpdateCostsOfferLineChildDialogView> bUpdateSupplier { get; set; } 
        public IRPSCheckbox<UpdateCostsOfferLineChildDialogView> bUpdatecost { get; set; } 
        public IRPSCheckbox<UpdateCostsOfferLineChildDialogView> bUpdatePrices { get; set; } 
        public IRPSCheckbox<UpdateCostsOfferLineChildDialogView> bQuantity { get; set; } 
        public IRPSTextBox<UpdateCostsOfferLineChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<UpdateCostsOfferLineChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<UpdateCostsOfferLineChildDialogView> ALLLot { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public UpdateCostsOfferLineChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistEmployeeChangedPopUpDialogView : View
    {
        public CuDistEmployeeChangedPopUpDialogView(SupplierRequestQuotation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionValueNoChange = RPSControlFactory.CreateRPSOption<CuDistEmployeeChangedPopUpDialogView>( "d2cadb7b-4aba-42ad-aacd-111336da6c20","","",this);
 
            OptionValueChangeAll = RPSControlFactory.CreateRPSOption<CuDistEmployeeChangedPopUpDialogView>( "7068fe3e-5b2a-4926-99b4-15f577db8cb3","","",this);
 
            OptionValueOnlyForEmployee = RPSControlFactory.CreateRPSOption<CuDistEmployeeChangedPopUpDialogView>( "cf385239-3ffc-48c4-8e49-723d5a740e13","","",this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeChangedPopUpDialogView>( "b4a08af0-2e27-4bf1-b316-aa109f528a6d","","",this);
 

        }
        public IRPSOption<CuDistEmployeeChangedPopUpDialogView> OptionValueNoChange { get; set; } 
        public IRPSOption<CuDistEmployeeChangedPopUpDialogView> OptionValueChangeAll { get; set; } 
        public IRPSOption<CuDistEmployeeChangedPopUpDialogView> OptionValueOnlyForEmployee { get; set; } 
        public IRPSButton<CuDistEmployeeChangedPopUpDialogView> AcceptCommand { get; set; } 
        public SupplierRequestQuotation Screen { get; set; }
        public CuDistEmployeeChangedPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
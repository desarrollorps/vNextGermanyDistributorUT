    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.PotentialCustomerSL
{
    //RPS VERSION 1.0.0.0
    public partial class PotentialCustomerSL:Screen
    {
        public PotentialCustomerSL():base()
        {
            this.URL = "salescrm.potentialcustomersl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PotentialCustomerSLQueryView  = new PotentialCustomerSLQueryView(this); 
            PotentialCustomerSLEntityView  = new PotentialCustomerSLEntityView(this); 
            PotentialDeliveryAddressSLView  = new PotentialDeliveryAddressSLView(this); 
            PotentialCustomerContactSLView  = new PotentialCustomerContactSLView(this); 
            PotentialCustomerCommercialAgentSLView  = new PotentialCustomerCommercialAgentSLView(this); 
            NewCodForCustomerDialogView  = new NewCodForCustomerDialogView(this); 
            PotentialCustomerSLQueryView.InitializeControls(); 
            PotentialCustomerSLEntityView.InitializeControls(); 
            PotentialDeliveryAddressSLView.InitializeControls(); 
            PotentialCustomerContactSLView.InitializeControls(); 
            PotentialCustomerCommercialAgentSLView.InitializeControls(); 
            NewCodForCustomerDialogView.InitializeControls(); 
           
        }
      
            public PotentialCustomerSLQueryView PotentialCustomerSLQueryView {get; set; } 
            public PotentialCustomerSLEntityView PotentialCustomerSLEntityView {get; set; } 
            public PotentialDeliveryAddressSLView PotentialDeliveryAddressSLView {get; set; } 
            public PotentialCustomerContactSLView PotentialCustomerContactSLView {get; set; } 
            public PotentialCustomerCommercialAgentSLView PotentialCustomerCommercialAgentSLView {get; set; } 
            public NewCodForCustomerDialogView NewCodForCustomerDialogView {get; set; } 
    }
            
    public partial class PotentialCustomerSLQueryView : View
    {
        public PotentialCustomerSLQueryView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PotentialCustomerSLQueryView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7416f0bb-ced7-43d3-ac45-e7e0ded4bfb0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PotentialCustomerSLQueryView,PotentialCustomerSLEntityView>( params_MainConsult,this,Screen.PotentialCustomerSLEntityView);
 

        }
        public IRPSButton<PotentialCustomerSLQueryView,PotentialCustomerSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PotentialCustomerSLQueryView,PotentialCustomerSLEntityView> MainConsult { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialCustomerSLEntityView : View
    {
        public PotentialCustomerSLEntityView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PotentialCustomerSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialCustomerSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialCustomerSLEntityView,PotentialCustomerSLQueryView>( this,Screen.PotentialCustomerSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialCustomerSLEntityView,PotentialCustomerSLQueryView>( this,Screen.PotentialCustomerSLQueryView);
 
            CodPotentialCustomer = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("4e2a8c8b-df0d-453f-b14a-5f015f6c5bda","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("54152feb-6d38-45e7-8f7f-e5643f4e375e","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("1f72b682-a09c-40e9-b1a0-766af2bd68b1","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("767224cd-c7f3-4d44-aadc-63a2cc52dbfc","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<PotentialCustomerSLEntityView>("a0f13eaa-9f7b-4ee0-b540-a92430a83a27","","",true, this);
 
            IDCustomerClassification = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("2649fda1-c2f9-4e78-a8b5-9a7500add4f5","","",false, this);
 
            IDSector = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("9b8f5049-b0d1-4064-a45f-3c1aeb58e4ed","","",false, this);
 
            IDZone = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("91413958-7b57-440e-a74c-6ba146ef1145","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("42b04276-e442-43bc-a207-912e345545aa","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("21e3d31b-d648-464e-9640-6af9366c68ef","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("a6d74fa7-68e3-46c9-bf73-08081348b368","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("7e4cb5e4-b455-4bfa-8aff-43caf5356798","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("417d7083-347b-4b8a-9689-f1692782a0d0","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("b231bb02-bf69-4c52-a559-987f4e834328","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("704b6f09-3b45-4752-8ffb-ba3724261055","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("93c38159-dc33-4637-b4a4-11e16adccad5","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("2c508403-0127-46e3-8c77-67dbe68ca962","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("354ce2d4-e06a-4064-b873-c74e0bde5a6c","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("0535c51b-91f1-459d-aa4a-156b026fa5f9","","",false, this);
 
            Email1 = RPSControlFactory.CreateRPSEmailTextBox<PotentialCustomerSLEntityView>("82384af1-18e4-4d66-8b49-76a1c3cdd465","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("7fd7803e-2970-4892-b676-9386983db397","","",false, this);
 
            IDCustomerGroup1 = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("2b6b1416-2c1a-4249-b100-683c7e25f541","","",false, this);
 
            IDCustomerGroup1Value = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("63f7d683-f6b1-4475-8c13-e1729854485d","","",false, this);
 
            IDCustomerGroup2 = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("9029bdff-baad-4f92-97b7-d5e9db8fd907","","",false, this);
 
            IDCustomerGroup2Value = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("a5b24ebf-30fd-4263-a9a4-32187dae0cb4","","",false, this);
 
            IDCustomerGroup3 = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("4877d25d-15c2-4e63-94cb-3e517cc91a31","","",false, this);
 
            IDCustomerGroup3Value = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("e4a7aacd-0c1c-4f45-9074-b0b25aa47a86","","",false, this);
 
            IDCustomerGroup4 = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("a111a8c4-6af8-4067-adfa-20519cf1d4a2","","",false, this);
 
            IDCustomerGroup4Value = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("5a59be95-9478-4cd3-b3e1-15bc03d24046","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("a8f23bdd-139d-444e-bf1e-17f810e07c58","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("b6629659-ff16-4a36-aeff-19a1718cc6d4","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("ff713065-e091-458f-9951-6d9dc3ecc035","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("a1f9cdaa-b7fb-4384-93aa-147927b16471","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("120aeb18-790a-47ed-813d-aee021d3c855","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("78827813-f5fe-4b1b-9477-4e11c48087df","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("26194ffc-407e-4130-b63f-ff64f1040530","","",false, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("97d5fe23-b5c6-498b-b7b1-20d8e49446e1","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("d32d228a-7f78-4481-a717-cede7736a380","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("7ba52eec-d923-486f-bb0c-b1412bcf3fc7","","",false, this);
 
            IDDiscountGroup = RPSControlFactory.CreateRPSComboBox<PotentialCustomerSLEntityView>("84694ed1-9fe2-4689-9ed3-5491e0174782","","",false, this);
 
            ConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerSLEntityView>("fb29b381-2fb1-40ba-95c3-8d16c2c85ab9","","",true, this);
 
            ConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerSLEntityView>("0c3f74b8-65e4-449e-bbb5-db1b4af33e70","","",true, this);
 
            DiscountCondition = RPSControlFactory.CreateRPSEnumComboBox<PotentialCustomerSLEntityView>("ecc6faba-e3cd-4ef6-97a0-bcfc2b353b3c","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<PotentialCustomerSLEntityView>("d214a127-c2f5-4903-86d7-47b0eec5ff73","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<PotentialCustomerSLEntityView>("e977149a-6d7b-4f51-a7db-f3583723cc9e","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<PotentialCustomerSLEntityView>("689f42a4-3e8a-411c-97de-920b27f2a89b","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<PotentialCustomerSLEntityView>("a13b1cbd-a9ba-42b2-9fe8-4ac713cd86ec","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<PotentialCustomerSLEntityView>("10883f7d-a0b2-4ae0-b749-378308a01353","","",true, this);
 
            CommentPotentialCustomer = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("d876a0da-8c90-4338-aee3-83338e9a1950","","",false, this);
 
            TextNoticeSalesQuote = RPSControlFactory.CreateRPSTextBox<PotentialCustomerSLEntityView>("c7279e32-2042-41b7-bc1b-565616245913","","",false, this);
 
            ChangeToRealCustomerButton = RPSControlFactory.CreateRPSButton<PotentialCustomerSLEntityView>( "96809f7a-99cc-4c53-90ca-a091043a7119","","",this);
 
            CollectionInit params_PotentialDeliveryAddressSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1dd39ee9-a433-4461-9e19-43d47c771b78",CSSSelectorGrid="",XPathGrid=""};
            PotentialDeliveryAddressSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PotentialDeliveryAddressSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>,PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>( params_PotentialDeliveryAddressSLs,this,Screen.PotentialCustomerCommercialAgentSLView);
 
            CollectionInit params_PotentialCustomerContactSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3f52b440-023d-4696-a243-c5f608aeb123",CSSSelectorGrid="",XPathGrid=""};
            PotentialCustomerContactSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PotentialCustomerContactSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>,PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>( params_PotentialCustomerContactSLs,this,Screen.PotentialCustomerCommercialAgentSLView);
 
            CollectionInit params_PotentialCustomerCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4eb39ed2-5f82-44e4-9aef-61c661ca8bc8",CSSSelectorGrid="",XPathGrid=""};
            PotentialCustomerCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PotentialCustomerCommercialAgentSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>,PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>( params_PotentialCustomerCommercialAgentSLs,this,Screen.PotentialCustomerCommercialAgentSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='ea341001-7860-4226-be7e-393f53bb63fe']","",this);
 
            InvoicingDataSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='bad1a228-61ed-47b9-bb10-20904d886b8a']","",this);
 
            DeliveryAddressSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='1ae0b023-fcb5-4133-9dcd-b48addde512f']","",this);
 
            ContactsSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='4c9ee04c-e86c-4fbe-a9b4-5291e910adc7']","",this);
 
            CommercialAgentsSection = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='4b8ab1a4-b4b9-4ee9-a3de-faa09caaffe4']","",this);
 
            Coments = RPSControlFactory.CreateRPSSection<PotentialCustomerSLEntityView>( "","ul li[rpsid='39d39d5e-f6f3-46e1-be83-f96ed93e442b']","",this);
 

        }
        public IRPSSaveButton<PotentialCustomerSLEntityView> SaveButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView,PotentialCustomerSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView,PotentialCustomerSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CodPotentialCustomer { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Description { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CompanyName { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerClassification { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDSector { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDZone { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDState { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Address { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> City { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Position { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Fax { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Email1 { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup1 { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup1Value { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup2 { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup2Value { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup3 { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup3Value { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup4 { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerGroup4Value { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> IDDiscountGroup { get; set; } 
        public IRPSCheckbox<PotentialCustomerSLEntityView> ConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<PotentialCustomerSLEntityView> ConditionsNotAffectDocument { get; set; } 
        public IRPSComboBox<PotentialCustomerSLEntityView> DiscountCondition { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> CommentPotentialCustomer { get; set; } 
        public IRPSTextBox<PotentialCustomerSLEntityView> TextNoticeSalesQuote { get; set; } 
        public IRPSButton<PotentialCustomerSLEntityView> ChangeToRealCustomerButton { get; set; } 
        public PotentialDeliveryAddressSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> PotentialDeliveryAddressSLs { get; set; } 
        public PotentialCustomerContactSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> PotentialCustomerContactSLs { get; set; } 
        public PotentialCustomerCommercialAgentSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> PotentialCustomerCommercialAgentSLs { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> InvoicingDataSection { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> DeliveryAddressSection { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> ContactsSection { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> CommercialAgentsSection { get; set; } 
        public IRPSSection<PotentialCustomerSLEntityView> Coments { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PotentialDeliveryAddressSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>:RPSCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public  PotentialDeliveryAddressSLsGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> GridView {get;set;}
    }
    public partial class PotentialDeliveryAddressSLsGridView <PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> :  RPSGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public PotentialDeliveryAddressSLsGridView(PotentialCustomerSLEntityView currentView,PotentialCustomerCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DefaultAddress = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAddress']","",true, this.CurrentView);
 
            CodPotentialDeliveryAddress = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cCodPotentialDeliveryAddress']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#1dd39ee9-a433-4461-9e19-43d47c771b78 .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> DefaultAddress { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> CodPotentialDeliveryAddress { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Email { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> ContactPerson { get; set; } 
                     
    }
 
        public partial class PotentialCustomerContactSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>:RPSCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public  PotentialCustomerContactSLsGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> GridView {get;set;}
    }
    public partial class PotentialCustomerContactSLsGridView <PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> :  RPSGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public PotentialCustomerContactSLsGridView(PotentialCustomerSLEntityView currentView,PotentialCustomerCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            DefaultContact = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDefaultContact']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            FirstName = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cFirstName']","",false, this.CurrentView);
 
            LastName = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cLastName']","",false, this.CurrentView);
 
            Gender = RPSControlFactory.CreateRPSGridEnumComboBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cGender']","",true, this.CurrentView);
 
            Title = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cTitle']","",false, this.CurrentView);
 
            Position = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cPosition']","",false, this.CurrentView);
 
            Mobile = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cMobile']","",false, this.CurrentView);
 
            Location = RPSControlFactory.CreateRPSGridMemoTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cLocation']","",false, this.CurrentView);
 
            SkypeName = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cSkypeName']","",false, this.CurrentView);
 
            Newsletter = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cNewsletter']","",true, this.CurrentView);
 
            DateOfBirth = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDateOfBirth']","",false, this.CurrentView);
 
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            Department = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDepartment']","",false, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#3f52b440-023d-4696-a243-c5f608aeb123 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PotentialCustomerSLEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Description { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> Technical { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> DefaultContact { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> DefaultAdministration { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> FirstName { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> LastName { get; set; } 
        public IRPSGridComboBox<PotentialCustomerSLEntityView> Gender { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Title { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Position { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Mobile { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Location { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> SkypeName { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> Newsletter { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> DateOfBirth { get; set; } 
        public IRPSGridComboBox<PotentialCustomerSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Department { get; set; } 
        public IRPSGridCheckbox<PotentialCustomerSLEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> Email { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class PotentialCustomerCommercialAgentSLsCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView>:RPSCollectionEditor<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public  PotentialCustomerCommercialAgentSLsGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> GridView {get;set;}
    }
    public partial class PotentialCustomerCommercialAgentSLsGridView <PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> :  RPSGridView<PotentialCustomerSLEntityView,PotentialCustomerCommercialAgentSLView> where PotentialCustomerSLEntityView : class, IView where PotentialCustomerCommercialAgentSLView : class, IView
    {
        public PotentialCustomerCommercialAgentSLsGridView(PotentialCustomerSLEntityView currentView,PotentialCustomerCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<PotentialCustomerSLEntityView>("","#4eb39ed2-5f82-44e4-9aef-61c661ca8bc8 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<PotentialCustomerSLEntityView>("","#4eb39ed2-5f82-44e4-9aef-61c661ca8bc8 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<PotentialCustomerSLEntityView>("","#4eb39ed2-5f82-44e4-9aef-61c661ca8bc8 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PotentialCustomerSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<PotentialCustomerSLEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<PotentialCustomerSLEntityView> InactiveDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class PotentialDeliveryAddressSLView : View
    {
        public PotentialDeliveryAddressSLView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialDeliveryAddressSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            CodPotentialDeliveryAddress = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("1e05e41e-c9ac-46ca-856c-f109a7b48548","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("5eab7a65-c45f-4e4a-9c36-3733237c4374","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<PotentialDeliveryAddressSLView>("0e1bb9bc-9fc5-490a-b5cf-9ffb8e40b068","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("c2f6d4e1-a414-4e5d-bf0e-3e2e35b1a23f","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("60d0fdab-4382-4bf5-bbda-9e3e07d8b583","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("abca75be-9b63-4032-acec-cbee81814204","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("6d7a0cbb-2880-46a0-9006-f4d9d018fe17","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("c425e8e1-6ee1-43bf-863a-2260bde2aeb3","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("0a33e778-e09d-4cad-b922-b65fbd42d902","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("0783b88f-f3ad-4a89-883d-b631f49acedb","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("24a63bf2-7838-4f0c-9b68-9ca6662312d0","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("f43b8166-0f85-4742-aa9e-14f32371767e","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<PotentialDeliveryAddressSLView>("7fe7fe03-b894-437b-a7e3-16edf28debd7","","",false, this);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("c044d07f-0680-4bad-afeb-bb4dabac85d0","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("6598de75-5969-433b-88d6-638de75239cf","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("6d92450e-d6bf-44d3-99e2-7b9036f1c138","","",false, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("52e89ecf-a45f-4308-a35d-4ae3709031e3","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<PotentialDeliveryAddressSLView>("8a409085-4edd-4401-adbf-08363680e43f","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PotentialDeliveryAddressSLView>("efcfb3f9-82f6-471d-b43f-5c6745bc8d3c","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PotentialDeliveryAddressSLView>( "","ul li[rpsid='f0ac2b8c-fd4a-465a-9e29-4284a5f75047']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<PotentialDeliveryAddressSLView>( "","ul li[rpsid='617d640a-464a-4eea-b0cf-0e87da27ee03']","",this);
 

        }
        public IRPSButton<PotentialDeliveryAddressSLView> DeleteButton { get; set; } 
        public IRPSButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotentialDeliveryAddressSLView,PotentialCustomerSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> CodPotentialDeliveryAddress { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Description { get; set; } 
        public IRPSCheckbox<PotentialDeliveryAddressSLView> DefaultAddress { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> CodCountry { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> ZipCode { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDState { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDCounty { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Address { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> City { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Phone1 { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Phone2 { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Fax { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Email { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDPotentialCustomerContact { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> ContactPerson { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDVATType { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<PotentialDeliveryAddressSLView> IDTaxGroup { get; set; } 
        public IRPSTextBox<PotentialDeliveryAddressSLView> Comment { get; set; } 
        public IRPSSection<PotentialDeliveryAddressSLView> GeneralDataSection { get; set; } 
        public IRPSSection<PotentialDeliveryAddressSLView> CommentSection { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialDeliveryAddressSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialCustomerContactSLView : View
    {
        public PotentialCustomerContactSLView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialCustomerContactSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<PotentialCustomerContactSLView>("d243662b-cc8e-4d0e-b2fd-bffec47b92b4","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("8556b5f5-46b1-4c81-9323-2d45baeceaa5","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("c3efcbf8-1254-48ef-8bd4-4827223d2534","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("81960df6-c4aa-4b31-9f57-ce30ef4ceda8","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("fbf232b9-c881-4a73-afd9-fc42e354f534","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("2fb1bb1d-6c2d-4f6b-a2cc-28184ebe5ff6","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<PotentialCustomerContactSLView>("0545bfd5-ae2b-481d-92f5-d3a6d02a6a98","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("e5e68955-09a4-4564-a75c-ceeaf2191db2","","",true, this);
 
            DefaultContact = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("fc298c99-f3af-416c-82f1-3a4bc0817adb","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("74f64a12-5bbb-4918-9cca-e4b680c26894","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("c4a0d245-5236-4d4f-ba51-a79af65c5970","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("139726e6-a35a-4f09-a6aa-16ea9ff96559","","",true, this);
 
            FirstName = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("4a37bb83-ce6a-4917-b52c-759c18963051","","",false, this);
 
            LastName = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("a7558e12-6145-4959-95db-78f84c8b6ba1","","",false, this);
 
            Gender = RPSControlFactory.CreateRPSEnumComboBox<PotentialCustomerContactSLView>("2c5703b9-38c2-4751-a90a-460a0a48ff58","","",true, this);
 
            Title = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("32d7e943-7445-46ce-ac9a-a9403d2c201b","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("abeac479-8896-4df6-a82d-b9e625290103","","",false, this);
 
            Mobile = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("37786589-06b8-4325-81f3-7388defa15f0","","",false, this);
 
            DateOfBirth = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("eb2d32b1-d93a-4c3d-b940-ec3f1a804997","","",false, this);
 
            SkypeName = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("643b5728-09df-4255-8de9-1c813b8f637a","","",false, this);
 
            Department = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("7cba7571-a089-42e8-8f27-f84c1b2be83a","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PotentialCustomerContactSLView>("9ee0b2be-bbbb-40d1-95a4-a8bc9500f0e9","","",false, this);
 
            Newsletter = RPSControlFactory.CreateRPSCheckBox<PotentialCustomerContactSLView>("25380d83-0740-4ba9-ade4-713922caccc4","","",true, this);
 
            InactiveDate1 = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("749c971f-5851-4186-9e76-c1d3d50d7506","","",false, this);
 
            Location = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("5c8e7606-05f2-4ff6-840b-92160c3efb14","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PotentialCustomerContactSLView>("186c05e4-188a-48be-a681-4569bf895890","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PotentialCustomerContactSLView>( "","ul li[rpsid='4c9b1ed6-06ba-47c3-8992-e6db0f61b07e']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<PotentialCustomerContactSLView>( "","ul li[rpsid='cc067014-b100-4518-ba15-bf93879b97ed']","",this);
 

        }
        public IRPSButton<PotentialCustomerContactSLView> DeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotentialCustomerContactSLView,PotentialCustomerSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PotentialCustomerContactSLView> IDContactType { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Description { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> InactiveDate { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Phone1 { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Phone2 { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Fax { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Email { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> Commercial { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> DefaultContact { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> DefaultFinancial { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> Technical { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> FirstName { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> LastName { get; set; } 
        public IRPSComboBox<PotentialCustomerContactSLView> Gender { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Title { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Position { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Mobile { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> DateOfBirth { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> SkypeName { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Department { get; set; } 
        public IRPSComboBox<PotentialCustomerContactSLView> CodLanguage { get; set; } 
        public IRPSCheckbox<PotentialCustomerContactSLView> Newsletter { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> InactiveDate1 { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Location { get; set; } 
        public IRPSTextBox<PotentialCustomerContactSLView> Comment { get; set; } 
        public IRPSSection<PotentialCustomerContactSLView> GeneralDataSection { get; set; } 
        public IRPSSection<PotentialCustomerContactSLView> CommentSection { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerContactSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PotentialCustomerCommercialAgentSLView : View
    {
        public PotentialCustomerCommercialAgentSLView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PotentialCustomerCommercialAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView>( this,Screen.PotentialCustomerSLEntityView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<PotentialCustomerCommercialAgentSLView>("c3d70d76-9f69-4e5e-a4bb-12905969bd0c","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<PotentialCustomerCommercialAgentSLView>("b48f8303-ce63-4caa-a0b4-a339b9b08d25","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<PotentialCustomerCommercialAgentSLView>("f72a0bd6-b3e7-45cd-b8d5-4130f61f12e7","","",false, this);
 

        }
        public IRPSButton<PotentialCustomerCommercialAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PotentialCustomerCommercialAgentSLView,PotentialCustomerSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PotentialCustomerCommercialAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<PotentialCustomerCommercialAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<PotentialCustomerCommercialAgentSLView> InactiveDate { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public PotentialCustomerCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewCodForCustomerDialogView : View
    {
        public NewCodForCustomerDialogView(PotentialCustomerSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UICodNewCustomerCode = RPSControlFactory.CreateRPSTextBox<NewCodForCustomerDialogView>("afc5cd66-d2d1-4ac8-a6b1-a91a3c52a437","","",false, this);
 

        }
        public IRPSTextBox<NewCodForCustomerDialogView> UICodNewCustomerCode { get; set; } 
        public PotentialCustomerSL Screen { get; set; }
        public NewCodForCustomerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
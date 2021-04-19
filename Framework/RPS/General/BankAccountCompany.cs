    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BankAccountCompany
{
    //RPS VERSION 1.0.0.0
    public partial class BankAccountCompany:Screen
    {
        public BankAccountCompany():base()
        {
            this.URL = "general.bankaccountcompany";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankAccountCompanyCollectionView  = new BankAccountCompanyCollectionView(this); 
            BankAccountCompanyEntityView  = new BankAccountCompanyEntityView(this); 
            ConfigureSpecificBankRuleChildDialogView  = new ConfigureSpecificBankRuleChildDialogView(this); 
            BankAccountCompanyCollectionView.InitializeControls(); 
            BankAccountCompanyEntityView.InitializeControls(); 
            ConfigureSpecificBankRuleChildDialogView.InitializeControls(); 
           
        }
      
            public BankAccountCompanyCollectionView BankAccountCompanyCollectionView {get; set; } 
            public BankAccountCompanyEntityView BankAccountCompanyEntityView {get; set; } 
            public ConfigureSpecificBankRuleChildDialogView ConfigureSpecificBankRuleChildDialogView {get; set; } 
    }
            
    public partial class BankAccountCompanyCollectionView : View
    {
        public BankAccountCompanyCollectionView(BankAccountCompany screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BankAccountCompanyCollectionView,BankAccountCompanyEntityView>( this,Screen.BankAccountCompanyEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "946ff3a6-25db-48b0-8ff3-a0d906535e37",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BankAccountCompanyCollectionView,BankAccountCompanyEntityView>( params_MainConsult,this,Screen.BankAccountCompanyEntityView);
 

        }
        public IRPSButton<BankAccountCompanyCollectionView,BankAccountCompanyEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BankAccountCompanyCollectionView,BankAccountCompanyEntityView> MainConsult { get; set; } 
        public BankAccountCompany Screen { get; set; }
        public BankAccountCompanyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BankAccountCompanyEntityView : View
    {
        public BankAccountCompanyEntityView(BankAccountCompany screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BankAccountCompanyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankAccountCompanyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankAccountCompanyEntityView,BankAccountCompanyCollectionView>( this,Screen.BankAccountCompanyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankAccountCompanyEntityView,BankAccountCompanyCollectionView>( this,Screen.BankAccountCompanyCollectionView);
 
            CodBankAccountCompany = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("cc167cb2-7570-4580-8857-4f6f4be1986f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("155e2529-993a-49c6-8b96-f573ed1517b4","","",false, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("c148363c-9b9a-4e9f-ab32-4f3a5682c135","","",false, this);
 
            CodBankBranch = RPSControlFactory.CreateRPSEnumComboBox<BankAccountCompanyEntityView>("4d2336d4-e52b-49a7-a0e7-ad1cb62ef49f","","",false, this);
 
            DigitControl = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("cce87f28-2a96-4a5a-a9d1-6cf7ba55c82a","","",false, this);
 
            BankAccount = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("b574f905-20e5-4f9b-8cb8-e27d23e0a3eb","","",false, this);
 
            BankAccNumber = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("187f62dc-cf2a-450a-abe7-6713676729cc","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("29719448-7418-407a-8481-fa6c8383d526","","",true, this);
 
            TypeBankAcc = RPSControlFactory.CreateRPSEnumComboBox<BankAccountCompanyEntityView>("2deda394-0707-49d2-8bd6-edbb9b4e5e05","","",true, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("27a38736-debf-44d4-a4b7-d134d504b98d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("38a157b7-d4fe-4ddf-8eaf-19408a00a3df","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("50fe4a8c-fce8-4873-bf43-edca21f574f8","","",false, this);
 
            RiskLimit = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("5d99b36c-5ba5-4a7a-8185-6cf280019ea1","","",true, this);
 
            BankRisk = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("52d75759-7808-4beb-87b7-982945c66efd","","",false, this);
 
            MarginDays = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("c409ff20-2ce7-4f7a-85ba-aeb874669e2b","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("324a2d12-012b-4846-a7f2-3754def6a5c7","","",true, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("724a55bb-ea90-4e37-885a-36e48aa3f076","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("0bd39a13-df6d-4cd7-bf75-66c9df02f8df","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("7df6c29e-f547-4b89-9271-a27adf71e175","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("2916563f-db68-4e8a-aed0-7b787a4f360e","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("4989bbb6-6f7e-407f-98be-8f009d044f59","","",false, this);
 
            IDCodingSeriesRemittanceNumber = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("c66f8c8d-4c25-42c0-a321-10e8ac6a98cc","","",false, this);
 
            IDCodingSeriesCheck = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("358f8625-dad8-420d-b105-95392635c395","","",false, this);
 
            IDCodingSeriesPromissoryNote = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("3cdb2b92-c2e6-47fb-92ee-e9fe67f3d4c4","","",false, this);
 
            IDCodingSeriesMovement = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyEntityView>("142e8ab1-8a3f-4159-ad41-966bf47bc1e7","","",false, this);
 
            DomiciledCommissionPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("a795b897-e143-45a2-a1ea-d03ab7083f08","","",true, this);
 
            NonDomiciledCommissionPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("941057fa-25ed-472b-b474-6c51d215c5e6","","",true, this);
 
            CommissionMinimumAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("115d7b76-bc21-4e52-ae37-f1d26344c05f","","",true, this);
 
            ExpensesPostages1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("5d00cc7a-125f-49c0-ab29-a44a8a8c317b","","",true, this);
 
            DomiciledInterestBefore30Days1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("f99bd86e-1408-4926-9963-4f88430da81f","","",true, this);
 
            DomiciledInterest31601 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("e07268e7-dddd-4e13-8b5b-eff96bd78430","","",true, this);
 
            DomiciledInterest61901 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("b7634c7e-2f86-45d0-9d54-c558e9404669","","",true, this);
 
            DomiciledInterest911801 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("38ae2333-ab23-45e2-a37d-c9fcfa8f99c1","","",true, this);
 
            DomiciledInterestAfter1801 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("cde25b4a-cb7c-4d1a-9e0e-1f14314661cb","","",true, this);
 
            NonDomiciledInterestBefore30Days1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("5329f954-29e9-47aa-934f-88f2ee801b41","","",true, this);
 
            NonDomiciledInterest31601 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("124af614-3ca4-4a51-a724-00a41c7ba781","","",true, this);
 
            NonDomiciledInterest61901 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("af613ea0-27eb-4ce7-9f72-8b9079ed0ef1","","",true, this);
 
            NonDomiciledInterest911801 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("57c9307c-4d7d-4ab7-b559-c541f9fc065c","","",true, this);
 
            NonDomiciledInterestAfter180Days1 = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("5ffcbb6a-aba1-41c9-9c8f-ac334e3a9f35","","",true, this);
 
            CodBankRuleCustomer = RPSControlFactory.CreateRPSEnumComboBox<BankAccountCompanyEntityView>("55dec13c-ba47-4cae-9c20-fb35f98a2146","","",false, this);
 
            NameRuleCustomer = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("d5180c2a-d498-4589-9a5b-2056c751e5ab","","",false, this);
 
            CodBankRuleSupplier = RPSControlFactory.CreateRPSEnumComboBox<BankAccountCompanyEntityView>("b8930eda-f484-4a8d-b95b-c37a4ae025e4","","",false, this);
 
            NameRuleSupplier = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("f8686345-6818-4afb-afbd-5cd39fbb0d6b","","",false, this);
 
            Sufix = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("f45fbad9-4cf0-4430-b667-354b97b8e2db","","",false, this);
 
            GrantorNumber = RPSControlFactory.CreateRPSTextBox<BankAccountCompanyEntityView>("270da04a-9668-421f-b0ce-9efbe3eb8049","","",false, this);
 
            LastDomiciledPaymentNumber = RPSControlFactory.CreateRPSFormattedTextBox<BankAccountCompanyEntityView>("dd4d8a3d-ee86-45a9-aa58-17569ba96a3c","","",false, this);
 
            CollectionInit params_GenericBankRulesForBank = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="18dff95c-6219-44ac-be9e-dfd4fd686df6",CSSSelectorGrid="",XPathGrid=""};
            GenericBankRulesForBank = RPSControlFactory.RPSCreateCollectionWithGrid<GenericBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>,BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>( params_GenericBankRulesForBank,this,Screen.ConfigureSpecificBankRuleChildDialogView);
 
            CollectionInit params_SpecificBankRulesForBank = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14e14529-e5ef-4afa-90dd-338e6c5c6bca",CSSSelectorGrid="",XPathGrid=""};
            SpecificBankRulesForBank = RPSControlFactory.RPSCreateCollectionWithGrid<SpecificBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>,BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>( params_SpecificBankRulesForBank,this,Screen.ConfigureSpecificBankRuleChildDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<BankAccountCompanyEntityView>( "","ul li[rpsid='2f7a86d9-b60f-43c2-9aed-233b737254e0']","",this);
 
            BankInterestInfo = RPSControlFactory.CreateRPSSection<BankAccountCompanyEntityView>( "","ul li[rpsid='507ac7d1-8687-4311-ae57-a3c3a8b66b7f']","",this);
 
            Rules = RPSControlFactory.CreateRPSSection<BankAccountCompanyEntityView>( "","ul li[rpsid='6f830138-15a6-4bb7-a38a-dc9a041d3993']","",this);
 
            SpecificRules = RPSControlFactory.CreateRPSSection<BankAccountCompanyEntityView>( "","ul li[rpsid='992716ff-6a49-4e60-aced-995bafae988f']","",this);
 

        }
        public IRPSSaveButton<BankAccountCompanyEntityView> SaveButton { get; set; } 
        public IRPSButton<BankAccountCompanyEntityView> DeleteButton { get; set; } 
        public IRPSButton<BankAccountCompanyEntityView,BankAccountCompanyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankAccountCompanyEntityView,BankAccountCompanyCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> CodBankAccountCompany { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> Description { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> CodBank { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> CodBankBranch { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DigitControl { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> BankAccount { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> BankAccNumber { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> IBAN { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> TypeBankAcc { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> SWIFTCode { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDVAT { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> RiskLimit { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> BankRisk { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> MarginDays { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> CodCountry { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> ZipCode { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDState { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCounty { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> Address { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> City { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCodingSeriesRemittanceNumber { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCodingSeriesCheck { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCodingSeriesPromissoryNote { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> IDCodingSeriesMovement { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledCommissionPercentage1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledCommissionPercentage1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> CommissionMinimumAmount1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> ExpensesPostages1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledInterestBefore30Days1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledInterest31601 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledInterest61901 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledInterest911801 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> DomiciledInterestAfter1801 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledInterestBefore30Days1 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledInterest31601 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledInterest61901 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledInterest911801 { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NonDomiciledInterestAfter180Days1 { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> CodBankRuleCustomer { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NameRuleCustomer { get; set; } 
        public IRPSComboBox<BankAccountCompanyEntityView> CodBankRuleSupplier { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> NameRuleSupplier { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> Sufix { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> GrantorNumber { get; set; } 
        public IRPSTextBox<BankAccountCompanyEntityView> LastDomiciledPaymentNumber { get; set; } 
        public GenericBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> GenericBankRulesForBank { get; set; } 
        public SpecificBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> SpecificBankRulesForBank { get; set; } 
        public IRPSSection<BankAccountCompanyEntityView> GeneralData { get; set; } 
        public IRPSSection<BankAccountCompanyEntityView> BankInterestInfo { get; set; } 
        public IRPSSection<BankAccountCompanyEntityView> Rules { get; set; } 
        public IRPSSection<BankAccountCompanyEntityView> SpecificRules { get; set; } 
        public BankAccountCompany Screen { get; set; }
        public BankAccountCompanyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GenericBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>:RPSCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> where BankAccountCompanyEntityView : class, IView where ConfigureSpecificBankRuleChildDialogView : class, IView
    {
        public  GenericBankRulesForBankGridView<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> GridView {get;set;}
    }
    public partial class GenericBankRulesForBankGridView <BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> :  RPSGridView<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> where BankAccountCompanyEntityView : class, IView where ConfigureSpecificBankRuleChildDialogView : class, IView
    {
        public GenericBankRulesForBankGridView(BankAccountCompanyEntityView currentView,ConfigureSpecificBankRuleChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Check = RPSControlFactory.CreateRPSGridCheckBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='cCheck']","",false, this.CurrentView);
 
            Rule = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='cRule']","",false, this.CurrentView);
 
            eType = RPSControlFactory.CreateRPSGridEnumComboBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='ceType']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            UseForTRA = RPSControlFactory.CreateRPSGridCheckBox<BankAccountCompanyEntityView>("","#18dff95c-6219-44ac-be9e-dfd4fd686df6 .ag-row[role='row']@ROWINDEX [col-id='cUseForTRA']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<BankAccountCompanyEntityView> Check { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> Rule { get; set; } 
        public IRPSGridComboBox<BankAccountCompanyEntityView> eType { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> DateTo { get; set; } 
        public IRPSGridCheckbox<BankAccountCompanyEntityView> UseForTRA { get; set; } 
                     
    }
 
        public partial class SpecificBankRulesForBankCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView>:RPSCollectionEditor<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> where BankAccountCompanyEntityView : class, IView where ConfigureSpecificBankRuleChildDialogView : class, IView
    {
        public  SpecificBankRulesForBankGridView<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> GridView {get;set;}
    }
    public partial class SpecificBankRulesForBankGridView <BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> :  RPSGridView<BankAccountCompanyEntityView,ConfigureSpecificBankRuleChildDialogView> where BankAccountCompanyEntityView : class, IView where ConfigureSpecificBankRuleChildDialogView : class, IView
    {
        public SpecificBankRulesForBankGridView(BankAccountCompanyEntityView currentView,ConfigureSpecificBankRuleChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ConfigureCommand = RPSControlFactory.CreateRPSGridButton<BankAccountCompanyEntityView>( "","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cConfigureCommand']","",this.CurrentView);
 
            Check = RPSControlFactory.CreateRPSGridCheckBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cCheck']","",false, this.CurrentView);
 
            Rule = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cRule']","",false, this.CurrentView);
 
            eType = RPSControlFactory.CreateRPSGridEnumComboBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='ceType']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            UseForTRA = RPSControlFactory.CreateRPSGridCheckBox<BankAccountCompanyEntityView>("","#14e14529-e5ef-4afa-90dd-338e6c5c6bca .ag-row[role='row']@ROWINDEX [col-id='cUseForTRA']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<BankAccountCompanyEntityView> ConfigureCommand { get; set; } 
        public IRPSGridCheckbox<BankAccountCompanyEntityView> Check { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> Rule { get; set; } 
        public IRPSGridComboBox<BankAccountCompanyEntityView> eType { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<BankAccountCompanyEntityView> DateTo { get; set; } 
        public IRPSGridCheckbox<BankAccountCompanyEntityView> UseForTRA { get; set; } 
                     
    }
 
    }
  
            
    public partial class ConfigureSpecificBankRuleChildDialogView : View
    {
        public ConfigureSpecificBankRuleChildDialogView(BankAccountCompany screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ConfigureSpecificBankRuleChildDialogView>("6f4ff825-2c44-46fb-80b7-74cb11f250b3","","",false, this);
 
            Value_CONTRATO = RPSControlFactory.CreateRPSTextBox<ConfigureSpecificBankRuleChildDialogView>("50830063-6434-4f42-a761-fc73ec537d78","","",false, this);
 
            Options_MODALIDAD = RPSControlFactory.CreateRPSEnumComboBox<ConfigureSpecificBankRuleChildDialogView>("2d599b86-b254-43fb-91ed-223faee640d8","","",false, this);
 
            Value_CLIENTE = RPSControlFactory.CreateRPSTextBox<ConfigureSpecificBankRuleChildDialogView>("4a89bdf0-6ed0-48f5-811a-2d372f2b6fc2","","",false, this);
 
            Value_N_OPERACION = RPSControlFactory.CreateRPSTextBox<ConfigureSpecificBankRuleChildDialogView>("634c2e0b-8581-462f-be87-9f3cebbd148e","","",false, this);
 
            Value_MNEMO = RPSControlFactory.CreateRPSTextBox<ConfigureSpecificBankRuleChildDialogView>("8ab46d4a-f70a-4008-bc34-bb521e021c08","","",false, this);
 
            Value_SUFIJO = RPSControlFactory.CreateRPSTextBox<ConfigureSpecificBankRuleChildDialogView>("b1241759-6a6e-406a-958c-6fae27ea09e2","","",false, this);
 
            Options_TIPO_LOTE = RPSControlFactory.CreateRPSEnumComboBox<ConfigureSpecificBankRuleChildDialogView>("b9d59957-43de-4257-83a8-7b466f22769f","","",false, this);
 
            Options_FORMA_ENVIO = RPSControlFactory.CreateRPSEnumComboBox<ConfigureSpecificBankRuleChildDialogView>("94283ce7-d6fb-45bc-b1d4-efd01f219800","","",false, this);
 
            Options_TIPO_ENVIO = RPSControlFactory.CreateRPSEnumComboBox<ConfigureSpecificBankRuleChildDialogView>("e3ac2901-ad5a-4db1-afe1-a86ff25354d3","","",false, this);
 
            NotSaveCommand = RPSControlFactory.CreateRPSButton<ConfigureSpecificBankRuleChildDialogView>( "b7859498-66d2-4f74-99d5-eb075c0b7932","","",this);
 
            SaveCommand = RPSControlFactory.CreateRPSButton<ConfigureSpecificBankRuleChildDialogView>( "3e2e07d6-ff59-4993-ac4e-54fbc96911a6","","",this);
 

        }
        public IRPSComboBox<ConfigureSpecificBankRuleChildDialogView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<ConfigureSpecificBankRuleChildDialogView> Value_CONTRATO { get; set; } 
        public IRPSComboBox<ConfigureSpecificBankRuleChildDialogView> Options_MODALIDAD { get; set; } 
        public IRPSTextBox<ConfigureSpecificBankRuleChildDialogView> Value_CLIENTE { get; set; } 
        public IRPSTextBox<ConfigureSpecificBankRuleChildDialogView> Value_N_OPERACION { get; set; } 
        public IRPSTextBox<ConfigureSpecificBankRuleChildDialogView> Value_MNEMO { get; set; } 
        public IRPSTextBox<ConfigureSpecificBankRuleChildDialogView> Value_SUFIJO { get; set; } 
        public IRPSComboBox<ConfigureSpecificBankRuleChildDialogView> Options_TIPO_LOTE { get; set; } 
        public IRPSComboBox<ConfigureSpecificBankRuleChildDialogView> Options_FORMA_ENVIO { get; set; } 
        public IRPSComboBox<ConfigureSpecificBankRuleChildDialogView> Options_TIPO_ENVIO { get; set; } 
        public IRPSButton<ConfigureSpecificBankRuleChildDialogView> NotSaveCommand { get; set; } 
        public IRPSButton<ConfigureSpecificBankRuleChildDialogView> SaveCommand { get; set; } 
        public BankAccountCompany Screen { get; set; }
        public ConfigureSpecificBankRuleChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
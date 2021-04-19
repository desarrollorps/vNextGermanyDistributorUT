    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceConsult
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceConsult:Screen
    {
        public InvoiceConsult():base()
        {
            this.URL = "sales.invoiceconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceSLCollectionView  = new InvoiceSLCollectionView(this); 
            InvoiceSLEntityView  = new InvoiceSLEntityView(this); 
            InvoiceLineSLView  = new InvoiceLineSLView(this); 
            PrintInvoiceChildDialogView  = new PrintInvoiceChildDialogView(this); 
            EditCommentsChildDialogView  = new EditCommentsChildDialogView(this); 
            EditCommentsChildLineDialogView  = new EditCommentsChildLineDialogView(this); 
            InvoiceSLCollectionView.InitializeControls(); 
            InvoiceSLEntityView.InitializeControls(); 
            InvoiceLineSLView.InitializeControls(); 
            PrintInvoiceChildDialogView.InitializeControls(); 
            EditCommentsChildDialogView.InitializeControls(); 
            EditCommentsChildLineDialogView.InitializeControls(); 
           
        }
      
            public InvoiceSLCollectionView InvoiceSLCollectionView {get; set; } 
            public InvoiceSLEntityView InvoiceSLEntityView {get; set; } 
            public InvoiceLineSLView InvoiceLineSLView {get; set; } 
            public PrintInvoiceChildDialogView PrintInvoiceChildDialogView {get; set; } 
            public EditCommentsChildDialogView EditCommentsChildDialogView {get; set; } 
            public EditCommentsChildLineDialogView EditCommentsChildLineDialogView {get; set; } 
    }
            
    public partial class InvoiceSLCollectionView : View
    {
        public InvoiceSLCollectionView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceSLCollectionView,InvoiceSLEntityView>( this,Screen.InvoiceSLEntityView);
 
            NewDeliveryNoteSLLinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<InvoiceSLCollectionView>( "e19c1b03-0517-4e60-97f2-0416776bf598","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5523f5d7-9976-4232-982b-1dfceec84050",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceSLCollectionView,InvoiceSLEntityView>( params_MainConsult,this,Screen.InvoiceSLEntityView);
 

        }
        public IRPSButton<InvoiceSLCollectionView,InvoiceSLEntityView> NewButton { get; set; } 
        public IRPSButton<InvoiceSLCollectionView> NewDeliveryNoteSLLinkNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<InvoiceSLCollectionView,InvoiceSLEntityView> MainConsult { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceSLEntityView : View
    {
        public InvoiceSLEntityView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceSLEntityView,InvoiceSLCollectionView>( this,Screen.InvoiceSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceSLEntityView,InvoiceSLCollectionView>( this,Screen.InvoiceSLCollectionView);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("c30519fc-449c-47c9-bb54-892a6d494c6a","","",true, this);
 
            IDCustomerPayment = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("f990e03b-0750-48c3-abba-c3287c8a4445","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("f616ae19-f000-4057-b35b-1f5e74e0fadb","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("aca048d7-580b-47c5-becb-c416e4c131ab","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("8f19fff8-abbc-42e3-a5d0-134687f0c1c9","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("b2257597-1414-4b73-9682-b886b51d63a8","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceSLEntityView>("059ddc04-b961-4cfb-a448-3556707cc5f1","","",false, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("0b70cb91-b097-421c-b7b7-0003c313be16","","",false, this);
 
            AdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("f1c24caf-753e-4608-98f3-98d762485415","","",true, this);
 
            UIAccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("0df3b0f4-c355-4d64-ab1f-7b67b96e4ecb","","",false, this);
 
            UIJournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("e8ac8367-3012-4c8a-9500-f31f62cba395","","",false, this);
 
            UIVATARRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("ba8b35c2-77e4-4d26-b127-11a20a08a2c2","","",false, this);
 
            CodAutoInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("47e6ddb6-7386-47f5-bbdd-144ca1ee5e6d","","",false, this);
 
            AutoInvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("3b28698c-0e39-4b90-b203-1dbd83ebd197","","",false, this);
 
            UIVoucherNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("4ba3f3db-7cd4-48a8-8a53-5771cf976ed3","","",false, this);
 
            UICodCompanyPurchase = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("b05370e7-21ae-47b4-9c33-f6caa30c4f63","","",false, this);
 
            IDIntInvoicePurchase = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("d0f38710-6c1a-4280-bb45-4a454615fbca","","",false, this);
 
            VATBASE = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("e7672b5b-4e64-429a-ad39-7f47a9e2c178","","",true, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("2d27d67a-7d11-41ba-8904-796276ce09d3","","",true, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("25d14c40-4be4-4f8d-a426-f826c580ece8","","",true, this);
 
            TotalAdvanceInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("bce21b5a-1d0c-4bed-8adb-d6db99c312d0","","",true, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("a25a3e41-1742-4c62-a500-7ad1aeb88821","","",true, this);
 
            TotalTaxInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("f61b643d-a4cf-4b23-b825-8700cd2dcba6","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("b5c7fb68-5466-4e4b-8ed1-2eedcd67f843","","",false, this);
 
            FinancialSurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("9cae2379-24b6-4490-98ad-a48ded914dfb","","",true, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("2d815675-8dce-4bf1-bbac-35517c054b97","","",true, this);
 
            IDInvoiceTypeGroup = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("9aa4ec3d-0a2f-4af0-9f67-862e70d30107","","",true, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("cf0db79f-3f75-4505-a974-5a4b62829736","","",true, this);
 
            IDInvoicingPoint = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("72c76c1d-125d-4d87-b393-b6d491935024","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("9d54443c-2470-43c5-838d-4fed4bc8d658","","",false, this);
 
            IDCustomerPaymentAddress = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("6a6a5cb2-c8b1-496e-ab66-773e37642443","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("09d8eceb-b16a-4a78-b7c9-24d85c7e7c25","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("416cd052-ad11-4d5e-9562-58853c2c61aa","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("99835bab-7333-41b1-9a35-221928712b02","","",false, this);
 
            IDCashPayment = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("b56caba3-7be9-41e0-a1d0-7e0feb8e6416","","",false, this);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("3d383af6-a580-4d23-ba24-696b4ad53701","","",false, this);
 
            Ticket = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("decbaa36-eb06-46f2-bbe9-15c76f9275fc","","",true, this);
 
            RentingInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("4034ea9f-757a-44b1-857e-9710beef1a5f","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("adb86753-76ab-4aae-8c73-95c6f75ae813","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("c991333c-9d50-4ad8-98b2-d561a003002d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("078142b5-58d9-4023-a54a-e2013d8e4318","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("fd46f02b-4d75-48c7-946c-bbe467fc3adf","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("3340d772-d832-4b91-8d2e-68d16c137b63","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("70363c48-df33-4324-ad11-d630ee9247ad","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("96d46707-71f5-4ce1-8dd7-1b7d49ae1dd3","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("b27d52b6-8a6e-42a8-8bbb-c6abcfecb555","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("5c189166-d608-48d3-9358-afc73276ddf2","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("b4438fa0-fe15-4288-899b-52edad964c70","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("6f0c70fe-f859-4da8-8553-d8376b83959a","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("a2952234-427c-4ade-8520-3d0642f1a84a","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("84cb450f-e7b6-48cd-9583-7e059ac2c879","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0847db30-ff46-4023-991c-9eda31d0b399","","",true, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("3eaf6fb1-8f0a-49d7-8f24-0aa626e2d928","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("41cd905b-69d3-49a6-b02e-3fabecd67d58","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("8f9a24cf-9330-4032-9368-653e8c222966","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("ea897cb2-d699-44b5-a4ae-79dd681bfc91","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("bf3fa5b9-bf98-4380-b6b5-671b56bf865b","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("0c2456e7-d3d2-4d48-9701-e07ccc2ce7e2","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("bdefa438-43ea-4731-b037-0ecc497e2ed9","","",false, this);
 
            MaintenanceContract = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("4cdc714f-1e07-4de7-b947-82b53d77c93c","","",false, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("c8d41964-bff9-4156-b70a-e6c86a2ba88f","","",true, this);
 
            VATPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("5df4e448-6594-4add-8dc9-6ae5501cedc7","","",true, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0724fd15-cad5-4d8e-bc26-5a6661d7c745","","",true, this);
 
            SurchargePercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("a4f23d97-a2e1-431a-9e05-5fdd3737c708","","",true, this);
 
            SurchargeAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("00aedf4a-c7c8-4fbb-9013-690f306c0172","","",true, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("974652a4-b153-4daf-8576-d086fac0846c","","",true, this);
 
            VATPercentage2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("405692c8-0b74-40a9-9369-476ea5be0be8","","",true, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("7282e89b-6340-42d5-8c27-3d69d3126a63","","",true, this);
 
            SurchargePercentage2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("f9c50720-e5fc-4a37-9c67-1daa9f5b1452","","",true, this);
 
            SurchargeAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("2edb5b21-8923-4fd6-9f4c-d8f58d6b6816","","",true, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("4efe3aa3-6049-4087-8104-afaeed123ae7","","",true, this);
 
            VATPercentage3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("4f7982ae-9266-48bb-921e-69e7c5dc9280","","",true, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("6ca5a574-dfe0-48f2-ab93-3f52186fbe43","","",true, this);
 
            SurchargePercentage3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("99d319f0-1a7d-4e03-8fe0-47dc5f45bd90","","",true, this);
 
            SurchargeAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("8450df30-f038-416d-802b-cf730dc48c9d","","",true, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("8578a48c-a6ca-4948-80da-78612434cd77","","",true, this);
 
            VATPercentage4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("586ce5d1-c428-4d3a-8bc1-fa745f417470","","",true, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("881d3855-de24-4ea0-b4f7-819b64f76ad9","","",true, this);
 
            SurchargePercentage4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("e8d6df75-0bdd-40d5-9dd4-7f4f6744ed8f","","",true, this);
 
            SurchargeAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("217c534d-cb0c-407a-ae0e-ce8cc7388d9b","","",true, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("2c228d59-6d41-42a5-a137-4d8c5d5dd2be","","",true, this);
 
            VATPercentage5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("217b712e-909a-4079-9ea5-bcd90e7d572d","","",true, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("804c1bf3-d0d7-4ec6-a7bd-614f1a971656","","",true, this);
 
            SurchargePercentage5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("a30000e9-2ef4-447f-8d28-3eb43a80811e","","",true, this);
 
            SurchargeAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("460ffa1f-d476-494f-b50c-a721856e012d","","",true, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("1d0997ab-d468-43c8-8eb3-a90a7067142f","","",true, this);
 
            VATPercentage6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0c518a5e-d816-4fec-ab1f-f74d274e0259","","",true, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("4188d838-8e78-4ba6-adf3-9c06ef042ae4","","",true, this);
 
            SurchargePercentage6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("8fcf94a9-72c5-4551-9d20-b242104bc439","","",true, this);
 
            SurchargeAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("6a2935f4-e620-4ce5-905f-ebb3ab4287c3","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("1043a4fd-bec4-4412-a809-8789439fe2f7","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("02a999db-4db8-48b0-9026-bd3c76da8ee6","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("bfab7875-a232-4bf6-bd33-ec9d59767720","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("fe1a05af-acfc-4e45-9624-09c6b1c5725a","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("e68357f1-dd6c-483c-9486-f95c2f723030","","",false, this);
 
            NewDeliveryNoteSLLinkNavigationCommand = RPSControlFactory.CreateRPSButton<InvoiceSLEntityView>( "5b320251-af1f-40d7-8b1a-b72f864d8599","","",this);
 
            PrintInvoiceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceSLEntityView,PrintInvoiceChildDialogView>("abc0113b-9abe-4052-a198-4b73e1182026","","", this,Screen.PrintInvoiceChildDialogView);
 
            EditCommentInvoiceButton = RPSControlFactory.CreateRPSButtonToView<InvoiceSLEntityView,EditCommentsChildDialogView>("6ddd500a-1b3f-4d50-92cc-a8c5fdb6d7ba","","", this,Screen.EditCommentsChildDialogView);
 
            InvoiceAnulationCommandButton = RPSControlFactory.CreateRPSButton<InvoiceSLEntityView>( "21b9a3a1-0f5d-4e43-82e6-592bd882e721","","",this);
 
            CollectionInit params_InvoiceLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5db2e59-ca69-490f-a8d4-047848feb77e",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>,InvoiceSLEntityView,InvoiceLineSLView>( params_InvoiceLineSLs,this,Screen.InvoiceLineSLView);
 
            CollectionInit params_InvoicePaymentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7ab0f878-3336-4793-9f24-47e656a149a9",CSSSelectorGrid="",XPathGrid=""};
            InvoicePaymentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePaymentSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>,InvoiceSLEntityView,InvoiceLineSLView>( params_InvoicePaymentSLs,this,Screen.InvoiceLineSLView);
 
            CollectionInit params_InvoiceTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="68b60950-1d90-410e-936b-898876c780e5",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTaxSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>,InvoiceSLEntityView,InvoiceLineSLView>( params_InvoiceTaxSLs,this,Screen.InvoiceLineSLView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='a15ae6e0-d8b0-4714-a7ef-09763b3771d9']","",this);
 
            BasicDataSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='7daf43a3-273f-40d2-817b-e872e96dde2a']","",this);
 
            VATSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='cdc186d6-b475-4638-ac6d-2ec0947c09f3']","",this);
 
            PaymentSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='396063bc-7bb3-4bee-a80c-f5e8e6e91c14']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='9a1b51b4-058a-4b42-9547-11f92d4aaff3']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='b4e81a7a-ac7b-44ec-961a-9e29d86dda17']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='122bc55a-14e9-4871-a82a-4b54313fe46b']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='40e11cc8-cf48-4170-bd0f-4eadf5615671']","",this);
 

        }
        public IRPSSaveButton<InvoiceSLEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView,InvoiceSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView,InvoiceSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomerPayment { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDContactAdministration { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> InvoiceDate { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> DocumentType { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodFromInvoice { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> AdvanceInvoice { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UIAccountingDate { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UIJournalNumber { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UIVATARRegisterNumber { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodAutoInvoice { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> AutoInvoiceDate { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UIVoucherNumber { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UICodCompanyPurchase { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDIntInvoicePurchase { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBASE { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> TotalAdvanceInvoiced { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Retention { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> TotalTaxInvoice { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Transport { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> FinancialSurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> TotalInvoice { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDInvoiceTypeGroup { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDInvoicingPoint { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomerPaymentAddress { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCashPayment { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> Ticket { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> RentingInvoice { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDFixedAsset { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Change { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> FixedChange { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> RetentionPercent { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CompanyName { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDState { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> City { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCounty { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> MaintenanceContract { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase4 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage4 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount4 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage4 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount4 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase5 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage5 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount5 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage5 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount5 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATBase6 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATPercentage6 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATAmount6 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargePercentage6 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> SurchargeAmount6 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Comment { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CommentInvoice { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> PreText { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> PostText { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDEmployee { get; set; } 
        public IRPSButton<InvoiceSLEntityView> NewDeliveryNoteSLLinkNavigationCommand { get; set; } 
        public IRPSButton<InvoiceSLEntityView,PrintInvoiceChildDialogView> PrintInvoiceChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView,EditCommentsChildDialogView> EditCommentInvoiceButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView> InvoiceAnulationCommandButton { get; set; } 
        public InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> InvoiceLineSLs { get; set; } 
        public InvoicePaymentSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> InvoicePaymentSLs { get; set; } 
        public InvoiceTaxSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> InvoiceTaxSLs { get; set; } 
        public IRPSSection<InvoiceSLEntityView> LinesSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> BasicDataSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> VATSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> PaymentSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> TaxSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> CommentSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> TextLine { get; set; } 
        public IRPSSection<InvoiceSLEntityView> DPS { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>:RPSCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public  InvoiceLineSLsGridView<InvoiceSLEntityView,InvoiceLineSLView> GridView {get;set;}
    }
    public partial class InvoiceLineSLsGridView <InvoiceSLEntityView,InvoiceLineSLView> :  RPSGridView<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public InvoiceLineSLsGridView(InvoiceSLEntityView currentView,InvoiceLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#d5db2e59-ca69-490f-a8d4-047848feb77e .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceSLEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridComboBox<InvoiceSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> PlanNumber { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> AmountWithVAT { get; set; } 
                     
    }
 
        public partial class InvoicePaymentSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>:RPSCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public  InvoicePaymentSLsGridView<InvoiceSLEntityView,InvoiceLineSLView> GridView {get;set;}
    }
    public partial class InvoicePaymentSLsGridView <InvoiceSLEntityView,InvoiceLineSLView> :  RPSGridView<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public InvoicePaymentSLsGridView(InvoiceSLEntityView currentView,InvoiceLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#7ab0f878-3336-4793-9f24-47e656a149a9 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#7ab0f878-3336-4793-9f24-47e656a149a9 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<InvoiceSLEntityView>("","#7ab0f878-3336-4793-9f24-47e656a149a9 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#7ab0f878-3336-4793-9f24-47e656a149a9 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Date { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Amount { get; set; } 
                     
    }
 
        public partial class InvoiceTaxSLsCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView>:RPSCollectionEditor<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public  InvoiceTaxSLsGridView<InvoiceSLEntityView,InvoiceLineSLView> GridView {get;set;}
    }
    public partial class InvoiceTaxSLsGridView <InvoiceSLEntityView,InvoiceLineSLView> :  RPSGridView<InvoiceSLEntityView,InvoiceLineSLView> where InvoiceSLEntityView : class, IView where InvoiceLineSLView : class, IView
    {
        public InvoiceTaxSLsGridView(InvoiceSLEntityView currentView,InvoiceLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTax = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#68b60950-1d90-410e-936b-898876c780e5 .ag-row[role='row']@ROWINDEX [col-id='cIDTax']","",true, this.CurrentView);
 
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#68b60950-1d90-410e-936b-898876c780e5 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#68b60950-1d90-410e-936b-898876c780e5 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#68b60950-1d90-410e-936b-898876c780e5 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            TaxAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#68b60950-1d90-410e-936b-898876c780e5 .ag-row[role='row']@ROWINDEX [col-id='cTaxAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceSLEntityView> IDTax { get; set; } 
        public IRPSGridComboBox<InvoiceSLEntityView> IDTaxValue { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Value { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> TaxAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceLineSLView : View
    {
        public InvoiceLineSLView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineSLView,InvoiceSLEntityView>( this,Screen.InvoiceSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineSLView,InvoiceSLEntityView>( this,Screen.InvoiceSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineSLView,InvoiceSLEntityView>( this,Screen.InvoiceSLEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("c84133b1-5330-43bc-ae97-fbe693585f0a","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("3514b41d-30aa-43ee-b2ad-8b67a755b703","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("e00cbda3-621f-45f1-8a2e-36089b243c17","","",false, this);
 
            IDOrderAdvance = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("4398d046-ff9c-4f2f-8a03-109155904345","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("0664c885-e61c-40cd-aec9-30d0c096dbac","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("739954f6-e711-402f-8ba3-a73c3d25b66b","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("0e5a7165-7678-41c8-b630-052dfcd3673d","","",false, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("4c2b4d04-dd67-473e-b15a-76eff4e069ee","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("38532a2e-f0fb-4874-9b23-b1522a554de9","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("422587f7-36e4-484b-9c41-726e38a43b9a","","",false, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("a90f74e2-9d46-4842-ace8-1640c5316191","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("cbf8e29f-c14b-45ed-acb6-9740922e38f3","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("09741d7f-a807-468c-a178-100dbcab985e","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("9b0f157f-f8fa-42ec-9ea7-55bc0e71f2e2","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("4371c304-0b37-43a1-8c4a-99e75a2435f0","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("0d275291-157c-4f95-883f-fb19bae24ad0","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("6335c6b4-7fca-48a6-bf83-25f20a835439","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("6105e690-1790-46e9-b017-b15b6e9c921b","","",false, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("a86748ba-1d35-4517-bcdd-f00b01327ab5","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("6e1f2da0-3fab-4e1b-8a9d-8e6d39a9344f","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("072d82d7-e7ae-4e52-be92-6eb16687d9a6","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("5a48b30f-7e79-4b40-99c9-fbd94cca2f37","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("e169f833-2641-45c9-9510-8d7531561c81","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("e9795e96-6c0b-4be4-bb6e-89873a9b921b","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("3508097c-f34e-46e7-83d9-5d6e82612353","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("812937b6-4b92-4539-a305-327bd5c78bfa","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("77700d87-a4c2-4664-95b2-941bf4d05dc2","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("5e812009-11ac-4f70-9622-4b99e8bed8fc","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("055ea1e0-a437-494e-ac6e-97ea78cab727","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("acb58da5-fc8d-4609-98ce-b2b2e3dd903d","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("a2358cea-685c-4dab-bb11-19b5e773cc34","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("0ec8fecf-11bf-4112-a85f-978799ad55f7","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("5c5eb42b-e0d9-4cb1-8b5f-e5725bedeca1","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineSLView>("7538dc04-8eac-400f-85f7-12cc30c6f5d6","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("7da8ec7c-eef5-4525-abc2-64ed9059395e","","",false, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("c5399ff7-4bd7-410c-aa49-46c10d97b35c","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("c3977c1a-e32c-473c-b336-c980e642c04a","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("6dec3b5e-3906-40b4-9026-9cab25bb73f5","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("fae823a8-c425-4dac-a2dc-d6eed98f1dfc","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("11742507-9bd9-4f1e-83d5-728bbbea355b","","",false, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("c5b0333a-e9b1-44b5-8a28-49e47156e252","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("47224b8b-f626-4273-b399-83e714ef7205","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("b9455f86-2a64-487a-b424-4d0dabc53aa2","","",false, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("1766c7a5-7e48-4eec-98a8-82c6346d1846","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceLineSLView>("a725d001-f186-4ed6-8cc1-b3cf785235b6","","",false, this);
 
            Kit = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("1cb96322-97c8-42cb-b40f-19adcffbd038","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("3edf3c30-949a-4a88-a147-067d9ba3c089","","",false, this);
 
            GeneratedProm = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("014db3cf-3723-4b99-9688-5abcc6f0dab8","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineSLView>("dc56531f-765a-4ebd-a8da-32aacf03624f","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<InvoiceLineSLView>("ff0fcca9-db6c-43b8-a571-9e96c200d728","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("418dd3e6-60de-4420-81d8-9723722dad3d","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("fcc4ee8a-13a2-4a84-97e8-d57970bd770b","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<InvoiceLineSLView>("a86edb9f-a99b-461e-bb0f-1279eb80361a","","",false, this);
 
            EditCommentsChildLineNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceLineSLView,EditCommentsChildLineDialogView>("aa09b644-5dac-4c64-8d39-40899ceaa211","","", this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2a9205c-e4d9-4a84-b09d-2e084a9dd9cd",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineAnalyticSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>,InvoiceLineSLView,EditCommentsChildLineDialogView>( params_InvoiceLineAnalyticSLs,this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="079ef8e8-407c-4f91-bd69-441bd658f75b",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineTaxSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>,InvoiceLineSLView,EditCommentsChildLineDialogView>( params_InvoiceLineTaxSLs,this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineConditionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6d1343a7-0c33-4187-a6b9-eb9d9d7bf078",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineConditionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineConditionSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>,InvoiceLineSLView,EditCommentsChildLineDialogView>( params_InvoiceLineConditionSLs,this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="958f5725-3f35-4320-a3f8-726a0799e5fe",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineCommercialAgentSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>,InvoiceLineSLView,EditCommentsChildLineDialogView>( params_InvoiceLineCommercialAgentSLs,this,Screen.EditCommentsChildLineDialogView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='47b4aadc-edf4-4060-b3ac-faf649d486e3']","",this);
 
            AnalyticSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='cd35bb2f-6293-4882-a8f4-765aaa2fac95']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='07f13d19-245c-43a8-8e8c-d2429a7a9b1e']","",this);
 
            ConditionSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='6e38d0d9-804a-4cd3-822c-462c4464f448']","",this);
 
            CommissionSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='836683bb-d29d-4388-b6c2-a0354d85c6ba']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='b73de8c4-5ede-477e-a113-a987cc573eb9']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<InvoiceLineSLView>( "","ul li[rpsid='c3692754-a76f-4288-aa72-cd4f81dded10']","",this);
 

        }
        public IRPSButton<InvoiceLineSLView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineSLView,InvoiceSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineSLView,InvoiceSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineSLView,InvoiceSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Ordenation { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDOrderLine { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDOrderAdvance { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Description { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Series { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Quantity { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Dimension1 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Dimension2 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Dimension3 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Price { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> VAT { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDUnitPrice { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Amount { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> AmountWithVAT { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Cost { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Discount1 { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Discount2 { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Discount3 { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Discount4 { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Discount5 { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDVAT { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> PercentVAT { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDSite { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDReturnCause { get; set; } 
        public IRPSComboBox<InvoiceLineSLView> IDAccount { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Kit { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> CostPercentage { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> GeneratedProm { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> NumProm { get; set; } 
        public IRPSCheckbox<InvoiceLineSLView> Rappel { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> Comment { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> CommentInvoice { get; set; } 
        public IRPSTextBox<InvoiceLineSLView> PlanNumber { get; set; } 
        public IRPSButton<InvoiceLineSLView,EditCommentsChildLineDialogView> EditCommentsChildLineNavigationCommandButton { get; set; } 
        public InvoiceLineAnalyticSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> InvoiceLineAnalyticSLs { get; set; } 
        public InvoiceLineTaxSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> InvoiceLineTaxSLs { get; set; } 
        public InvoiceLineConditionSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> InvoiceLineConditionSLs { get; set; } 
        public InvoiceLineCommercialAgentSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> InvoiceLineCommercialAgentSLs { get; set; } 
        public IRPSSection<InvoiceLineSLView> GeneralDataSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> AnalyticSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> TaxSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> ConditionSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> CommissionSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> CommentSection { get; set; } 
        public IRPSSection<InvoiceLineSLView> DPS { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineAnalyticSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineAnalyticSLsGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineAnalyticSLsGridView <InvoiceLineSLView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineAnalyticSLsGridView(InvoiceLineSLView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineSLView>("","#c2a9205c-e4d9-4a84-b09d-2e084a9dd9cd .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineSLView>("","#c2a9205c-e4d9-4a84-b09d-2e084a9dd9cd .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#c2a9205c-e4d9-4a84-b09d-2e084a9dd9cd .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineSLView> IDDimension { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> IDDimValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Percentage { get; set; } 
                     
    }
 
        public partial class InvoiceLineTaxSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineTaxSLsGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineTaxSLsGridView <InvoiceLineSLView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineTaxSLsGridView(InvoiceLineSLView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineSLView>("","#079ef8e8-407c-4f91-bd69-441bd658f75b .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> BaseType { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Value { get; set; } 
        public IRPSGridCheckbox<InvoiceLineSLView> VAT { get; set; } 
        public IRPSGridCheckbox<InvoiceLineSLView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class InvoiceLineConditionSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineConditionSLsGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineConditionSLsGridView <InvoiceLineSLView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineConditionSLsGridView(InvoiceLineSLView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#6d1343a7-0c33-4187-a6b9-eb9d9d7bf078 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineSLView> Type { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> BaseApply { get; set; } 
        public IRPSGridCheckbox<InvoiceLineSLView> AffectsPrice { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Amount { get; set; } 
                     
    }
 
        public partial class InvoiceLineCommercialAgentSLsCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineCommercialAgentSLsGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineCommercialAgentSLsGridView <InvoiceLineSLView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineSLView,EditCommentsChildLineDialogView> where InvoiceLineSLView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineCommercialAgentSLsGridView(InvoiceLineSLView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineSLView>("","#958f5725-3f35-4320-a3f8-726a0799e5fe .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridComboBox<InvoiceLineSLView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Commission { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> CommissionAmount { get; set; } 
        public IRPSGridTextBox<InvoiceLineSLView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintInvoiceChildDialogView : View
    {
        public PrintInvoiceChildDialogView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "8e573a7b-02ad-4d6f-9238-9d8a87c11d30","","",this);
 
            Language = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "d9b21e44-dd7d-436b-9b57-bf2d7cf2f028","","",this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("3d1214b5-14b9-4fb5-9ca8-72a4c124dc6e","","",false, this);
 
            CustomerCopies = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "68c61dbf-b0ec-4c68-a2d6-78a15e5606c7","","",this);
 
            Copies = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "b5b1a400-60fd-4ce2-b598-7b707fdb217e","","",this);
 
            NumCopies = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("93674615-3da3-4237-a1f6-dd15eadf5394","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintInvoiceChildDialogView>("37c01dc9-5446-4c9c-ba92-3ffc4d8acef2","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("b3b2dda6-c96c-4ddb-9c9d-3dca126d179b","","",false, this);
 
            PrintInvoiceCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "9f73c755-af85-4736-bfba-2485dbefe006","","",this);
 
            SendInvoiceByEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "059d4f52-5f4a-4b7c-a06b-cc5e0a8a099f","","",this);
 
            SendInvoiceToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "a43181bd-87de-41ca-b058-7dc574b1d936","","",this);
 

        }
        public IRPSOption<PrintInvoiceChildDialogView> Customer { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> Language { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> CodLanguage { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> CustomerCopies { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> Copies { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> NumCopies { get; set; } 
        public IRPSCheckbox<PrintInvoiceChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> CustomReport { get; set; } 
        public IRPSButton<PrintInvoiceChildDialogView> PrintInvoiceCommandButton { get; set; } 
        public IRPSButton<PrintInvoiceChildDialogView> SendInvoiceByEmailCommandButton { get; set; } 
        public IRPSButton<PrintInvoiceChildDialogView> SendInvoiceToCustomerEmailCommandButton { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public PrintInvoiceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditCommentsChildDialogView : View
    {
        public EditCommentsChildDialogView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<EditCommentsChildDialogView>("5ee3be01-bc17-4416-9256-36beb910df96","","",false, this);
 

        }
        public IRPSTextBox<EditCommentsChildDialogView> CommentInvoice { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public EditCommentsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditCommentsChildLineDialogView : View
    {
        public EditCommentsChildLineDialogView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<EditCommentsChildLineDialogView>("f3e6fc61-bf40-409a-9132-1ee803361911","","",false, this);
 

        }
        public IRPSTextBox<EditCommentsChildLineDialogView> CommentInvoice { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public EditCommentsChildLineDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceConsult
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceConsult:Screen
    {
        public InvoiceConsult():base()
        {
            this.URL = "purchase.invoiceconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceCollectionView  = new InvoiceCollectionView(this); 
            InvoiceEntityView  = new InvoiceEntityView(this); 
            InvoiceLineView  = new InvoiceLineView(this); 
            PrintInvoiceChildDialogView  = new PrintInvoiceChildDialogView(this); 
            EditCommentsChildDialogView  = new EditCommentsChildDialogView(this); 
            EditCommentsChildLineDialogView  = new EditCommentsChildLineDialogView(this); 
            InvoiceCollectionView.InitializeControls(); 
            InvoiceEntityView.InitializeControls(); 
            InvoiceLineView.InitializeControls(); 
            PrintInvoiceChildDialogView.InitializeControls(); 
            EditCommentsChildDialogView.InitializeControls(); 
            EditCommentsChildLineDialogView.InitializeControls(); 
           
        }
      
            public InvoiceCollectionView InvoiceCollectionView {get; set; } 
            public InvoiceEntityView InvoiceEntityView {get; set; } 
            public InvoiceLineView InvoiceLineView {get; set; } 
            public PrintInvoiceChildDialogView PrintInvoiceChildDialogView {get; set; } 
            public EditCommentsChildDialogView EditCommentsChildDialogView {get; set; } 
            public EditCommentsChildLineDialogView EditCommentsChildLineDialogView {get; set; } 
    }
            
    public partial class InvoiceCollectionView : View
    {
        public InvoiceCollectionView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceCollectionView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            NewDeliveryNoteLinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<InvoiceCollectionView>( "4cbb2798-2511-4cdc-aa8c-01009b2c278e","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ee664cc0-93c5-4b4c-8231-4cf47cd6f490",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceCollectionView,InvoiceEntityView>( params_MainConsult,this,Screen.InvoiceEntityView);
 

        }
        public IRPSButton<InvoiceCollectionView,InvoiceEntityView> NewButton { get; set; } 
        public IRPSButton<InvoiceCollectionView> NewDeliveryNoteLinkNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<InvoiceCollectionView,InvoiceEntityView> MainConsult { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceEntityView : View
    {
        public InvoiceEntityView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceEntityView,InvoiceCollectionView>( this,Screen.InvoiceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceEntityView,InvoiceCollectionView>( this,Screen.InvoiceCollectionView);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("839ff24a-645d-4ba8-9069-bc51ad7c6df6","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("eccbed9d-27c5-4c6d-a407-04361735bb0a","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("d4344a93-28e3-45e7-bfcf-ef3a2f21bc8c","","",true, this);
 
            AdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceEntityView>("9ffc37de-d057-4be5-b523-23584c9b3ce4","","",true, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("6cbae4e9-f2a5-4281-8731-6f676e5dce59","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("ed5bacd6-4e2f-4fe3-ad69-b47e47ce06bf","","",false, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceEntityView>("2263a7b8-9847-4157-878b-87d022b186fe","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("59a44fc4-bff6-4b76-bf42-9d7d04eb7e5f","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("fe189c6a-96d0-4f79-b314-ee0be6cdcc09","","",false, this);
 
            UIJournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("7036c024-7121-42d0-a6c1-171e423b591b","","",false, this);
 
            VATAPRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("3f4316c3-1e1f-4e10-934a-b135f69b3e83","","",true, this);
 
            UIVoucherNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("60edb7d2-67dc-4ce5-9fe1-0613b4179ac5","","",false, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("604ad5d7-f93b-44ae-8674-652d11411e57","","",false, this);
 
            IDIntInvoiceSales = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("5c7c869f-28cd-4274-82e2-f7865f635807","","",false, this);
 
            VATBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("aeeacc7a-0e8d-4230-9693-2b6252095259","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("ffbfc454-502f-450b-9b02-e268ba6c66ca","","",true, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("6b7bd42e-beb2-43a0-b88b-10fed110b57d","","",true, this);
 
            TotalAdvance = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("8388d981-b63e-4dba-931d-d1e4cb402407","","",true, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("2d6a86b7-6e3e-497a-aa7d-554d73bb8341","","",true, this);
 
            TotalTaxInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("5e51a017-1233-43f9-a18c-0f8ba535dbbb","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("1dc17498-32dd-4259-a030-075b770181a5","","",true, this);
 
            FinancialSurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("3e45d95e-2e21-47ee-8f95-cf9b6956ed99","","",true, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("609786d8-8012-49b3-b88a-a96132ba1f4b","","",true, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("5c6ad5d4-27d4-4ecf-b1bc-41b4eec563d9","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("f83d07cf-ca9c-480d-ba2b-4e243d9e3fd9","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("26c657e4-86a8-4816-b44f-ee8cbaf65f01","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("1a505aa1-a4d7-4316-bf4d-d1907845ea6e","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("47af4e1d-5e89-42ef-a9cc-ee63062801c2","","",true, this);
 
            IDInvoicingPoint = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("3055f32c-731e-4f18-b35c-6451762520a0","","",false, this);
 
            IDImportOrderType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("a97f9e9f-38dc-4ffe-8be3-d5ab696821c1","","",false, this);
 
            RentingInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceEntityView>("57180af4-318c-4a8c-90b0-073a6a0cb0cd","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("b7f5c278-ffb5-40e8-9c41-923802eacbbf","","",false, this);
 
            IDSupplierPayment = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("62dc325e-ffe7-4ed5-81ec-102bd82ed5c3","","",false, this);
 
            IDSupplierPayer = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("3b96d22a-4812-416a-b9a2-dbe46ad57d16","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("fa322d77-1593-4859-af3a-63b24b4bdd35","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("7c3eb510-22ac-4459-915e-8e5aa78babea","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("de94fd86-9854-443a-b2f3-ffe1c42468ed","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<InvoiceEntityView>("d460b56a-4694-4e95-a671-3694edadc35a","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("8235d27e-f1bc-4fe5-8bda-eac5414b5f12","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("78181624-dc82-4ea3-9fc3-9cd57b862de2","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("c681461d-2357-48c4-9ec3-83885167f68a","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("1a11412c-07a4-4fad-876b-c007c47f29dc","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("e20002fd-7685-43a4-8c98-f19cebeccff5","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("fa7d6cd8-b5f4-47b9-b77b-f74cc8b6b17c","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("d22b23fc-a5dc-455e-a256-faf7fa3a522d","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("725adf9d-20fa-4fd9-91ff-e454d0155a8a","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("d2727743-f11a-45db-8292-4f8e69824e58","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("8c44da86-0208-45b2-b68e-f6832a4cc40a","","",false, this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("8bb333cb-b2d0-4380-8d9b-fccafd3edb58","","",false, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("3730fd52-e76b-4b11-883e-2189065c3d70","","",true, this);
 
            VATPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("6719b231-095f-4032-b749-ce46e2ddb555","","",true, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("83f30790-b2b4-4ab0-aa7f-d7b174d51be3","","",true, this);
 
            SurchargePercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("02a3f107-f0b0-497a-937b-27da29201fb4","","",true, this);
 
            SurchargeAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("41ddeeaf-08d4-4877-bf9b-d6e45adcdfa7","","",true, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("fcc51f46-a5ea-4835-9ba5-c4f3039d146f","","",true, this);
 
            VATPercentage2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("842bcb36-f250-4dd2-8989-6c936d8e0977","","",true, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("7ac190e3-55f5-4b69-abb6-d55a1aae0405","","",true, this);
 
            SurchargePercentage2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("5a5ee810-1b8e-40e4-a0b7-2398add7f54d","","",true, this);
 
            SurchargeAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("9cffe9d8-11f8-4c62-93c9-4c7141655818","","",true, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("0102d140-55c3-4df2-8bdf-39fc07ff5b65","","",true, this);
 
            VATPercentage3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("a662dd85-905c-470f-942e-966eccd24c73","","",true, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("60e9ef58-18ce-413c-8491-6f3a8dd52be7","","",true, this);
 
            SurchargePercentage3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("3f165c81-f867-4d27-badd-5463404d575f","","",true, this);
 
            SurchargeAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("e18a29fd-dd17-43e8-9cbe-b3753dec3f50","","",true, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("80fad81c-9a5d-4675-8ae2-0ca8406ee107","","",true, this);
 
            VATPercentage4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("8986bba5-08f3-4d70-8277-5e2c4499784f","","",true, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("31b8ef88-1af6-4aa1-8070-c106c37f2c42","","",true, this);
 
            SurchargePercentage4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("ea8d60c6-cb17-4849-935d-cc58c3e2df6b","","",true, this);
 
            SurchargeAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("8dda47f3-fa6b-4314-8f66-3ff12617d597","","",true, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("881e128d-0c82-43f3-a694-c06d1b6345c5","","",true, this);
 
            VATPercentage5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("9230925f-56f5-42b5-8f43-d88880862b78","","",true, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("9d5df5f7-fb71-47f3-bc35-6c790e6b6e39","","",true, this);
 
            SurchargePercentage5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("7ade63e2-2a53-4b2c-9908-2c8369525968","","",true, this);
 
            SurchargeAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("776b3fcf-3e93-4a95-b9e1-ef11c3f0a973","","",true, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("1037a704-943c-41f2-9e46-9019e272a5bc","","",true, this);
 
            VATPercentage6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("19b5736f-5f04-4b39-80da-2dec47786471","","",true, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("1e614c97-64d2-4a64-a24a-80273f63de35","","",true, this);
 
            SurchargePercentage6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("00e05814-320f-4ea4-bd8f-6d0051ef8f78","","",true, this);
 
            SurchargeAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("6d68bc23-82e6-4bdb-bce4-421fdef4eee7","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("b025ccf0-6581-4120-bfad-ceb54c26b759","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("90c99885-6e00-4046-a78d-b2d2deaf2c88","","",false, this);
 
            PrintInvoiceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceEntityView,PrintInvoiceChildDialogView>("73c427f6-6616-455d-902f-1b27f270c191","","", this,Screen.PrintInvoiceChildDialogView);
 
            NewDeliveryNoteLinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<InvoiceEntityView>( "0c35cdc5-5960-47ed-a416-b70c76c1c88b","","",this);
 
            EditCommentsChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceEntityView,EditCommentsChildDialogView>("4610ccf7-e442-4a67-a1fc-d43048b3c109","","", this,Screen.EditCommentsChildDialogView);
 
            InvoiceAnulationCommandButton = RPSControlFactory.CreateRPSButton<InvoiceEntityView>( "171cef31-aa8d-4665-b3d2-b437ba21e490","","",this);
 
            CollectionInit params_InvoiceLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="71ce8195-f9f4-4b2c-b2f5-52530c80e41c",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView>,InvoiceEntityView,InvoiceLineView>( params_InvoiceLines,this,Screen.InvoiceLineView);
 
            CollectionInit params_InvoicePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2b1a3299-3c80-4699-866b-67c3ce594c1f",CSSSelectorGrid="",XPathGrid=""};
            InvoicePayments = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePaymentsCollectionEditor<InvoiceEntityView,InvoiceLineView>,InvoiceEntityView,InvoiceLineView>( params_InvoicePayments,this,Screen.InvoiceLineView);
 
            CollectionInit params_InvoiceTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="09af90fa-8c60-4682-8450-d7c5206be931",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTaxsCollectionEditor<InvoiceEntityView,InvoiceLineView>,InvoiceEntityView,InvoiceLineView>( params_InvoiceTaxs,this,Screen.InvoiceLineView);
 
            BasicDataSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='a31d1166-dfff-496e-be09-b1dbeb92320b']","",this);
 
            LinesSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='fdce3d7f-342b-4bc3-9fab-fad486167bf9']","",this);
 
            VATSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='a6b2a25e-f8b8-4689-b356-bfc3e5c67651']","",this);
 
            PaymentSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='fdcbc4a1-0eba-402a-b530-36b9e42a9e0a']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='511a27c3-5e83-415b-82fe-9e33ebfebc78']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='b2c4c55d-c624-4078-853a-44d6d9218e16']","",this);
 

        }
        public IRPSSaveButton<InvoiceEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<InvoiceEntityView> InvoiceDate { get; set; } 
        public IRPSCheckbox<InvoiceEntityView> AdvanceInvoice { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATNumber { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDContactAdministration { get; set; } 
        public IRPSComboBox<InvoiceEntityView> DocumentType { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CodFromInvoice { get; set; } 
        public IRPSTextBox<InvoiceEntityView> AccountingDate { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UIJournalNumber { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAPRegisterNumber { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UIVoucherNumber { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UICodCompanySales { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDIntInvoiceSales { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceEntityView> TotalAdvance { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Retention { get; set; } 
        public IRPSTextBox<InvoiceEntityView> TotalTaxInvoice { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Transport { get; set; } 
        public IRPSTextBox<InvoiceEntityView> FinancialSurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceEntityView> TotalInvoice { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<InvoiceEntityView> IDInvoicingPoint { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDImportOrderType { get; set; } 
        public IRPSCheckbox<InvoiceEntityView> RentingInvoice { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDFixedAsset { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplierPayment { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplierPayer { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Change { get; set; } 
        public IRPSCheckbox<InvoiceEntityView> FixedChange { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDVATType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDMaintenanceContract { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase4 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage4 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount4 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage4 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount4 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase5 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage5 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount5 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage5 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount5 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATBase6 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATPercentage6 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAmount6 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargePercentage6 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> SurchargeAmount6 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Comment { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CommentInvoice { get; set; } 
        public IRPSButton<InvoiceEntityView,PrintInvoiceChildDialogView> PrintInvoiceChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceEntityView> NewDeliveryNoteLinkNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceEntityView,EditCommentsChildDialogView> EditCommentsChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceEntityView> InvoiceAnulationCommandButton { get; set; } 
        public InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView> InvoiceLines { get; set; } 
        public InvoicePaymentsCollectionEditor<InvoiceEntityView,InvoiceLineView> InvoicePayments { get; set; } 
        public InvoiceTaxsCollectionEditor<InvoiceEntityView,InvoiceLineView> InvoiceTaxs { get; set; } 
        public IRPSSection<InvoiceEntityView> BasicDataSection { get; set; } 
        public IRPSSection<InvoiceEntityView> LinesSection { get; set; } 
        public IRPSSection<InvoiceEntityView> VATSection { get; set; } 
        public IRPSSection<InvoiceEntityView> PaymentSection { get; set; } 
        public IRPSSection<InvoiceEntityView> TaxSection { get; set; } 
        public IRPSSection<InvoiceEntityView> CommentSection { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView>:RPSCollectionEditor<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public  InvoiceLinesGridView<InvoiceEntityView,InvoiceLineView> GridView {get;set;}
    }
    public partial class InvoiceLinesGridView <InvoiceEntityView,InvoiceLineView> :  RPSGridView<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public InvoiceLinesGridView(InvoiceEntityView currentView,InvoiceLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#71ce8195-f9f4-4b2c-b2f5-52530c80e41c .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridComboBox<InvoiceEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Description { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Price { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> AmountWithVAT { get; set; } 
                     
    }
 
        public partial class InvoicePaymentsCollectionEditor<InvoiceEntityView,InvoiceLineView>:RPSCollectionEditor<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public  InvoicePaymentsGridView<InvoiceEntityView,InvoiceLineView> GridView {get;set;}
    }
    public partial class InvoicePaymentsGridView <InvoiceEntityView,InvoiceLineView> :  RPSGridView<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public InvoicePaymentsGridView(InvoiceEntityView currentView,InvoiceLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#2b1a3299-3c80-4699-866b-67c3ce594c1f .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#2b1a3299-3c80-4699-866b-67c3ce594c1f .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#2b1a3299-3c80-4699-866b-67c3ce594c1f .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#2b1a3299-3c80-4699-866b-67c3ce594c1f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Date { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Amount { get; set; } 
                     
    }
 
        public partial class InvoiceTaxsCollectionEditor<InvoiceEntityView,InvoiceLineView>:RPSCollectionEditor<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public  InvoiceTaxsGridView<InvoiceEntityView,InvoiceLineView> GridView {get;set;}
    }
    public partial class InvoiceTaxsGridView <InvoiceEntityView,InvoiceLineView> :  RPSGridView<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public InvoiceTaxsGridView(InvoiceEntityView currentView,InvoiceLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTax = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#09af90fa-8c60-4682-8450-d7c5206be931 .ag-row[role='row']@ROWINDEX [col-id='cIDTax']","",true, this.CurrentView);
 
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#09af90fa-8c60-4682-8450-d7c5206be931 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#09af90fa-8c60-4682-8450-d7c5206be931 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#09af90fa-8c60-4682-8450-d7c5206be931 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            TaxAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#09af90fa-8c60-4682-8450-d7c5206be931 .ag-row[role='row']@ROWINDEX [col-id='cTaxAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceEntityView> IDTax { get; set; } 
        public IRPSGridComboBox<InvoiceEntityView> IDTaxValue { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Value { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> TaxAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceLineView : View
    {
        public InvoiceLineView(InvoiceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("d81a6da0-43ab-44b0-a066-b125967b8fed","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("7fdbfce3-7b22-42ab-9a13-85487ca5ca0c","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("c0bf209d-0e91-486f-af9e-ba0794ee7bd1","","",false, this);
 
            IDOrderAdvance = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("1d0f391a-a7c9-45f3-a410-d1a4eea40950","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("2b696201-28f3-4b4e-914d-3b2c0023379b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("5586bb4e-6b14-4986-9ad4-9cf71ac43abf","","",false, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("6e57fd4d-a174-45c3-af7c-180e65c53fc9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("84426257-3a80-4f48-91af-677927175295","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("131fe998-0bc3-4d56-8a22-0f0a897b0e00","","",false, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("847f3811-ba30-41a5-b7a8-c6a79d8ea41d","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("2f9fa9d7-ab05-4503-8c14-13bb3e8cb90e","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("074e4ea3-7ce2-4802-9b14-b98b855b419e","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("edf02f22-8fbe-4f63-af0b-5849854f59f5","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ac44db6-ab74-4ebf-8892-7f7e3f792488","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ca0c9cf8-f174-4d01-a2a6-f65c800d5fd6","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("1f240acc-047e-40d1-b2e6-f7a0a17e5800","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("abb40a85-b2cd-43ae-a46c-1ef4f53d9212","","",false, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("d31dbef6-ac0d-4532-b088-1a5a40a3cf3f","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8ddc46c4-df92-4cac-b891-14159251d71d","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("032758d3-db54-4d43-b670-8277de41b8b1","","",true, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("78d046b2-96ca-4ba1-9c82-95eec2933a2a","","",false, this);
 
            DeliveryCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a5ed0f5d-41d2-4bfb-acf6-3d98312002c5","","",true, this);
 
            ImportCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8e30e041-682b-4c81-abd2-4954e1ed6f74","","",true, this);
 
            TariffCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ff25a75-2a45-4ebc-8086-2ed10705d5ef","","",true, this);
 
            PermissionsCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("1726e446-58a0-4207-9b19-c18ac80f2428","","",false, this);
 
            BankingCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("9da73ec1-f578-4f6a-bd4a-ee32e84a71af","","",false, this);
 
            OthersCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("fc025cea-8cba-4fbd-befe-4af40e4d62cf","","",false, this);
 
            ExternalCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("097fb9f7-50c3-43a6-aba1-63f79f435bd9","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8dc3529b-9f80-4b59-9b73-8301cdf5ae93","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("19994742-9e54-49e9-b6cd-eb04c509ec91","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a7fd42d7-ec5c-4f4a-b3b1-88d80260b674","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("8806ef4c-8486-4367-9b64-0f183bcd2d45","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("195543e9-b17f-488a-b79a-8b72b71023de","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("39c05bf1-d7d0-4d3e-9d44-710244ea7da9","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("64504d70-57df-4800-93ac-c11bcd457417","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("90deba88-c186-403e-b0bb-a15e7acba383","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("f3090a23-1b2f-4536-9f16-4e78944a1702","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("2a5be61a-b276-439d-bc77-ab7cd71e33f8","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ea627bf-8063-4195-9c7d-538b9fe08724","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineView>("6a088417-df38-4220-aa66-1fe4fbe643b5","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("8282ae6b-df27-471a-8e34-a368d919bd83","","",false, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("da24b7e4-b6d2-447b-9f4e-7731a5389073","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ae807c0b-ba8f-4005-9560-564f6027be2b","","",true, this);
 
            GenerateAutoInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("3cbf3f4c-e21c-47ff-aad2-e0a269531615","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("c93290e0-5713-4cbf-8141-affa54449daf","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("ebe50917-4044-46e6-9a7a-6c26cc88864e","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("1adb2744-3998-4b34-bec3-415d994c5eed","","",false, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("0c613a7b-e3ba-4145-a25a-a39cab6898ac","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("74fbcab0-41ed-450d-8969-cab02f43f751","","",false, this);
 
            Kit = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("da5ef119-0419-48b1-91ec-3d53eb65416d","","",false, this);
 
            CostPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ea956850-830b-4f28-9c26-b36305c606b6","","",false, this);
 
            GeneratedProm = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("14085ffa-babc-4529-8d59-61a7b3e9c224","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a4fb6c41-9da0-4bfc-9dfe-64e739f0c095","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("b9a2799e-c3fe-40d2-88be-b2d5357e96c4","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("108b4c67-f3cb-4e5c-be07-a60f969a1887","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("3cd89316-ba71-4406-8d33-068b1ec58d78","","",false, this);
 
            EditCommentsChildLineNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceLineView,EditCommentsChildLineDialogView>("ac48ed47-cf56-4f9c-bbb2-bcf505444094","","", this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8b2176e7-3b8a-4128-bbed-b1411c1f61d6",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>,InvoiceLineView,EditCommentsChildLineDialogView>( params_InvoiceLineAnalytics,this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="47182ac8-746f-48b2-ba2f-d1ce191b30ea",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineTaxsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>,InvoiceLineView,EditCommentsChildLineDialogView>( params_InvoiceLineTaxs,this,Screen.EditCommentsChildLineDialogView);
 
            CollectionInit params_InvoiceLineConditions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db6dadd3-3a0d-42f4-b384-9ce43c16e9f2",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineConditions = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineConditionsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>,InvoiceLineView,EditCommentsChildLineDialogView>( params_InvoiceLineConditions,this,Screen.EditCommentsChildLineDialogView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='79d72880-739e-4291-9ce7-f65b2e94ac8c']","",this);
 
            AnalyticSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='df04656a-06b4-47ed-927c-ff23c9238f77']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='ee6aecb4-b4cf-4883-8dab-c2a15afc2afe']","",this);
 
            ConditionSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='bdb69194-daeb-41ff-ae77-8e3c0ee74218']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='620ee05b-a4d8-4390-b9bc-3bf222e4b3c4']","",this);
 

        }
        public IRPSButton<InvoiceLineView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineView,InvoiceEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<InvoiceLineView> Ordenation { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDOrderLine { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDOrderAdvance { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDArticle { get; set; } 
        public IRPSTextBox<InvoiceLineView> Description { get; set; } 
        public IRPSTextBox<InvoiceLineView> Series { get; set; } 
        public IRPSTextBox<InvoiceLineView> Quantity { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension2 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension3 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Price { get; set; } 
        public IRPSCheckbox<InvoiceLineView> VAT { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDUnitPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> Amount { get; set; } 
        public IRPSTextBox<InvoiceLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage { get; set; } 
        public IRPSTextBox<InvoiceLineView> DeliveryCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> ImportCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> TariffCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> PermissionsCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> BankingCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> OthersCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> ExternalCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount1 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount2 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount3 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount4 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount5 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<InvoiceLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDVAT { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<InvoiceLineView> PercentSurcharge { get; set; } 
        public IRPSCheckbox<InvoiceLineView> GenerateAutoInvoice { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDSite { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDReturnCause { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDAccount { get; set; } 
        public IRPSTextBox<InvoiceLineView> Kit { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> GeneratedProm { get; set; } 
        public IRPSTextBox<InvoiceLineView> NumProm { get; set; } 
        public IRPSCheckbox<InvoiceLineView> Rappel { get; set; } 
        public IRPSTextBox<InvoiceLineView> Comment { get; set; } 
        public IRPSTextBox<InvoiceLineView> CommentInvoice { get; set; } 
        public IRPSButton<InvoiceLineView,EditCommentsChildLineDialogView> EditCommentsChildLineNavigationCommandButton { get; set; } 
        public InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> InvoiceLineAnalytics { get; set; } 
        public InvoiceLineTaxsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> InvoiceLineTaxs { get; set; } 
        public InvoiceLineConditionsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> InvoiceLineConditions { get; set; } 
        public IRPSSection<InvoiceLineView> GeneralDataSection { get; set; } 
        public IRPSSection<InvoiceLineView> AnalyticSection { get; set; } 
        public IRPSSection<InvoiceLineView> TaxSection { get; set; } 
        public IRPSSection<InvoiceLineView> ConditionSection { get; set; } 
        public IRPSSection<InvoiceLineView> Comments { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public InvoiceLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineAnalyticsGridView<InvoiceLineView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineAnalyticsGridView <InvoiceLineView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineAnalyticsGridView(InvoiceLineView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#8b2176e7-3b8a-4128-bbed-b1411c1f61d6 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#8b2176e7-3b8a-4128-bbed-b1411c1f61d6 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#8b2176e7-3b8a-4128-bbed-b1411c1f61d6 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> IDDimension { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> IDDimValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Percentage { get; set; } 
                     
    }
 
        public partial class InvoiceLineTaxsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineTaxsGridView<InvoiceLineView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineTaxsGridView <InvoiceLineView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineTaxsGridView(InvoiceLineView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineView>("","#47182ac8-746f-48b2-ba2f-d1ce191b30ea .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> ApplicationType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> BaseType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Value { get; set; } 
        public IRPSGridCheckbox<InvoiceLineView> VAT { get; set; } 
        public IRPSGridCheckbox<InvoiceLineView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class InvoiceLineConditionsCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView>:RPSCollectionEditor<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public  InvoiceLineConditionsGridView<InvoiceLineView,EditCommentsChildLineDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineConditionsGridView <InvoiceLineView,EditCommentsChildLineDialogView> :  RPSGridView<InvoiceLineView,EditCommentsChildLineDialogView> where InvoiceLineView : class, IView where EditCommentsChildLineDialogView : class, IView
    {
        public InvoiceLineConditionsGridView(InvoiceLineView currentView,EditCommentsChildLineDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#db6dadd3-3a0d-42f4-b384-9ce43c16e9f2 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> Type { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> BaseApply { get; set; } 
        public IRPSGridCheckbox<InvoiceLineView> AffectsPrice { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Amount { get; set; } 
                     
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
            UIOptSupplier = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "487d5fb8-853d-4fc3-987c-301a25177f28","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "8b12961e-cb7c-4591-ac02-bbca26843961","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("bad798a5-0838-429c-937b-414d127fa987","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintInvoiceChildDialogView>("e7a1697b-bb13-4d4a-b0c6-89605d6e22df","","",false, this);
 
            UICodInvoiceReport = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("79c70eb2-5456-44f9-a3ef-0e44317409f9","","",false, this);
 
            PrintInvoiceCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "276a66fa-ba46-45df-bde7-d7989511325e","","",this);
 
            SendInvoiceByEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "6de5a6b4-21c8-49a7-86d6-34fd96ff32d9","","",this);
 
            SendInvoiceToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintInvoiceChildDialogView>( "5cb49ede-3305-423d-96d6-2462573387a9","","",this);
 

        }
        public IRPSOption<PrintInvoiceChildDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<PrintInvoiceChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> UICodInvoiceReport { get; set; } 
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
            CommentInvoiceAux = RPSControlFactory.CreateRPSTextBox<EditCommentsChildDialogView>("925b2752-dd88-4eba-b546-8299f1c49ac1","","",false, this);
 

        }
        public IRPSTextBox<EditCommentsChildDialogView> CommentInvoiceAux { get; set; } 
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
            CommentInvoiceAux = RPSControlFactory.CreateRPSTextBox<EditCommentsChildLineDialogView>("9765556b-c0f6-48b0-8edf-29d33cd21aac","","",false, this);
 

        }
        public IRPSTextBox<EditCommentsChildLineDialogView> CommentInvoiceAux { get; set; } 
        public InvoiceConsult Screen { get; set; }
        public EditCommentsChildLineDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
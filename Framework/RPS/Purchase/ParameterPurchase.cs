    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ParameterPurchase
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterPurchase:Screen
    {
        public ParameterPurchase():base()
        {
            this.URL = "purchase.parameterpurchase";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterPurchaseEntityView  = new ParameterPurchaseEntityView(this); 
            ParameterPurchaseEntityView.InitializeControls(); 
           
        }
      
            public ParameterPurchaseEntityView ParameterPurchaseEntityView {get; set; } 
    }
            
    public partial class ParameterPurchaseEntityView : View
    {
        public ParameterPurchaseEntityView(ParameterPurchase screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ControlUser = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("ff6d1ecd-ed6c-4e67-88c3-9663094aad92","","",true, this);
 
            ControlBusinessUnit = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("15c1d760-d2ca-436e-9d8e-d501e74a68cd","","",true, this);
 
            AllowModifyPrice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("96612f79-94c5-432c-b62f-3fc26782bbff","","",true, this);
 
            RecalculatePrice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("22bb4885-de61-4c7a-8be3-24f64f77dbed","","",true, this);
 
            IDSupplierClassification = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("eb0d4f68-8ac8-4143-9bd0-70e1a48222aa","","",false, this);
 
            IDSupplierRQuotationType = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("bd12f4e7-dee6-4983-8512-af4f7f22716d","","",false, this);
 
            SupplierRFQAllReceived = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("bf425d0e-b3ef-4108-b620-879bb08c2f74","","",true, this);
 
            IDDocCategoryRequestQuotation = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("b08323be-0878-4aba-b8d6-e242b8e58ab8","","",false, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("0aa4f2e7-1c38-4d6b-babc-ffc160f8f4f2","","",true, this);
 
            KitWarehouse = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("332d9ddc-9c8b-4197-817d-26916d982728","","",true, this);
 
            InputComponent = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("bdb63a01-5208-4b22-be1a-589c4506fe7b","","",true, this);
 
            PercentReceived = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPurchaseEntityView>("7d61d41d-6bda-4cb5-9e11-a8cbad81e968","","",true, this);
 
            IDDocumentCategoryOrder = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("c644b987-e4f9-4176-9cf6-71d97415405e","","",false, this);
 
            FrameworkContractPrice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("e946a288-49fe-44d3-b015-97192d975df8","","",true, this);
 
            ReceptionDateComCondition = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("c2b88e15-7892-4e79-9109-00960ea01306","","",true, this);
 
            DeleteOrder = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("f6852c02-6793-4feb-a7b8-3a661b5c0bbf","","",true, this);
 
            TariffFactor = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPurchaseEntityView>("1244f832-c077-4e71-bec5-2ee8d3ed0c36","","",true, this);
 
            ZippedDocuments = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("0aad1b40-a3d8-47d6-8b29-4f45393daf86","","",true, this);
 
            PreliminaryDeliveryNote = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("ea2a263a-ab44-4394-b2a6-1082b93aa2d0","","",true, this);
 
            RegisteredInvoice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("661da454-3f4c-4839-82c7-7850a5d6ea6c","","",true, this);
 
            FinalizedInvoice = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("57fb4564-dbed-4f31-8b98-280bcab1240e","","",true, this);
 
            IDSiteQuality = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("a310aab0-5295-4316-873f-8aaaddb09d72","","",false, this);
 
            IDWareHouseQuality = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("cc495a79-bb44-40e4-bf00-74447807e416","","",false, this);
 
            IDWareHouseReject = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("231428e2-dc6e-4a2a-b525-6fba95e6f04f","","",false, this);
 
            OutputExternalTask = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("526ca291-6ae8-4f53-b58b-8aca57f7265e","","",true, this);
 
            IDVATFree = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("eb17199d-4027-45cd-b7c6-42b541edab5d","","",false, this);
 
            IDVATTypeTransport = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("53290ffe-c291-41b8-944e-5bd892d92d4f","","",false, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<ParameterPurchaseEntityView>("6140698e-026e-4d01-97d3-c0782330bb71","","",false, this);
 
            PeriodNotPayment = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("ef451f25-63e3-4d2f-b388-b6a5905722b2","","",true, this);
 
            KeyNotPayment = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("1b173bd5-3f47-4d18-ae97-da87982732ce","","",true, this);
 
            FixedDayPayment = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("8a54cdcf-1a6e-475e-8434-892511a5bd35","","",true, this);
 
            FixedMonthPayment = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("d17ea01e-c30c-4de0-ad0c-8fbed813a7b6","","",true, this);
 
            AdvancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPurchaseEntityView>("00b103c3-40e9-41b1-892a-608fa54d98a0","","",true, this);
 
            DayNotPaymentFrom1 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("8ad5787e-82d0-487a-8ba7-66546072b8d0","","",true, this);
 
            MonthNotPaymentFrom1 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("6546c7e8-647f-4918-b1e0-307292c01752","","",true, this);
 
            DayNotPaymentTo1 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("51d9711c-57d7-4159-a379-aa86cdfbfdc2","","",true, this);
 
            MonthNotPaymentTo1 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("6cab9b91-81c5-4631-9377-a48a190a59c4","","",true, this);
 
            DayNotPaymentFrom2 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("3b414c0c-c5b8-4e20-b0ab-6af62efbd6d5","","",true, this);
 
            MonthNotPaymentFrom2 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("b6631e3b-247a-4a5a-8af7-ac09839523e7","","",true, this);
 
            DayNotPaymentTo2 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("65136cd4-4e33-483c-850a-819636408623","","",true, this);
 
            MonthNotPaymentTo2 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("e29e3559-bc9f-46d7-9a16-2b7e33e8f146","","",true, this);
 
            DayNotPaymentFrom3 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("5d0665c7-2403-4820-97bb-c2027079a042","","",true, this);
 
            MonthNotPaymentFrom3 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("21eebb09-38b4-4e1f-9803-47465eb6a3ca","","",true, this);
 
            DayNotPaymentTo3 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("77872ee9-9a68-4730-ae03-7c303cbb2ce3","","",true, this);
 
            MonthNotPaymentTo3 = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("d09ad1d5-fa9c-43c8-8563-781a82d19f82","","",true, this);
 
            IDArticleAdvanceStatistic = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("b2f6197b-844f-475d-aa74-35c942955e37","","",false, this);
 
            IDAdvancePaymentVATType = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("dbb71153-8afd-46a8-b27d-324e565a4b1a","","",false, this);
 
            IDAdvancePaymentMethod = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("33cad58b-652d-4837-a1ab-8ea1c03df34b","","",false, this);
 
            RetentionAdvances = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("78920ae5-b91a-4820-861d-d9efc5562578","","",true, this);
 
            IDCodingSeriePurchaseProposal = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("04be4d0a-4a25-4209-8a34-0bcb78875f60","","",false, this);
 
            IDCodingSerieSupplierRFQ = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("58e22493-8478-48b2-8d6d-94e5ace830ea","","",false, this);
 
            IDCodingSeriePurchaseDeliveryNote = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("98de770b-2dc6-44ac-ad43-5bef0e9a40b1","","",false, this);
 
            IDCodingSerieRappelAgreement = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("9e300f31-ee01-4dda-bf6f-d128bc573ea8","","",false, this);
 
            IDCodingSerieMerchandiseGift = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("80307fc0-f3b6-40fd-94b9-9423e53f54bc","","",false, this);
 
            IDDocCategoryRetentionInvoice = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("becb82be-abe7-4c6c-b474-eda0d93621a6","","",false, this);
 
            IDFrameworkCStatusInitial = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("2d56d6f6-c59b-46ea-9e9e-aa17295a6b19","","",false, this);
 
            IDFrameworkCStatusOffer = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("b3b3e0f3-f1e6-4f6e-a7fe-71296f62bef9","","",false, this);
 
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("1fcde048-393e-4d73-848b-761bbafeb104","","",false, this);
 
            IDOrderSituationManual = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("1b5abc1c-5360-40fb-b5e9-5cf07b899973","","",true, this);
 
            IDOrderSituationDirect = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("2f960306-3fa2-43c4-8e60-c67d4ea1bb49","","",true, this);
 
            MaxAmountOrder = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPurchaseEntityView>("f7eaaa3c-24b9-451a-8f1a-4df1dcf53999","","",true, this);
 
            IDOrderSituationMax = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("f5c33402-9920-4dd5-824e-ce98615532be","","",false, this);
 
            IDOrderSituationMin = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("f8f2ebcd-44df-4d4b-a7cf-88597ecceafc","","",false, this);
 
            TextLineGeneralReplace = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("529591b9-2438-4c83-90a5-ac30d6236538","","",true, this);
 
            IDTextLineSRQuotationPre = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("bffb5c3f-e4a2-461a-9d1f-65bf2817c528","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("909f8d57-fccb-49c5-8233-fd20e20ec5bd","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("390c8754-f8b9-4e35-bd5f-017185c1a2d0","","",false, this);
 
            IDTextLineSRQuotationPost = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("4bc2b971-0535-4c10-9a88-46afa85cf9cd","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("5a27b871-74e2-4e3d-80e4-09d0801b5d82","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("f818946c-1626-4c68-9ba4-c16275ef8b55","","",false, this);
 
            ProposalValidatedStockMimimun = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("127298fb-63cf-487c-a425-76529eb5f14e","","",true, this);
 
            ProposalValidatedProject = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("ada4bf31-0846-4ca9-b369-e782da4ad6eb","","",true, this);
 
            ProposalValidatedManufacturing = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("f8a86ab7-2797-454f-931d-c678832fc876","","",true, this);
 
            ProposalValidatedFromMRP = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("19d61bf4-7bab-4c08-ad88-30edd7dbe3ba","","",false, this);
 
            ProposalValidatedMaintenance = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("f091f5c9-7f42-4d59-85e6-c89e358ef3a1","","",true, this);
 
            ProposalValidatedOrderLine = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("0dbf7da6-fd32-42fa-b17f-80ec4d82f324","","",true, this);
 
            ProposalValidatedFromSales = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("fdeb53a3-05f4-4946-a564-862978a1d6d3","","",true, this);
 
            ProposalValidatedFromProvisioningList = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("e411ffb7-3431-4195-bfaf-633e972d9f2a","","",true, this);
 
            ProposalValidatedSupplierRFQ = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("5e6e1a7d-29b0-4f72-a28b-b386f7f15a00","","",true, this);
 
            TypePurchaseFromSales = RPSControlFactory.CreateRPSEnumComboBox<ParameterPurchaseEntityView>("5e272e0b-6a30-4848-ba01-acb0247ccc1f","","",true, this);
 
            IDArticleCommission = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("b5a70527-effa-4397-b1f8-1bec6963f785","","",false, this);
 
            FinalizedSalesRappel = RPSControlFactory.CreateRPSCheckBox<ParameterPurchaseEntityView>("7fbdfb80-f02a-4baa-90af-8ec46f8f7791","","",true, this);
 
            IDDeliveryNoteTypeMaintenance = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("0417d638-37fc-4ca0-b529-8c8300f01a75","","",false, this);
 
            IDDeliveryNoteTypeContractMAN = RPSControlFactory.CreateRPSComboBox<ParameterPurchaseEntityView>("d3edc09f-0017-4375-a4ac-174607e47818","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<ParameterPurchaseEntityView>( "","ul li[rpsid='223863f2-ad94-4a65-853a-c41704683d83']","",this);
 
            ServicesIntegration = RPSControlFactory.CreateRPSSection<ParameterPurchaseEntityView>( "","ul li[rpsid='85311154-8022-46dd-9d82-7550a4dc1ff2']","",this);
 

        }
        public IRPSCheckbox<ParameterPurchaseEntityView> ControlUser { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ControlBusinessUnit { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> AllowModifyPrice { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> RecalculatePrice { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDSupplierClassification { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDSupplierRQuotationType { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> SupplierRFQAllReceived { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDDocCategoryRequestQuotation { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> PurchasePrice { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> KitWarehouse { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> InputComponent { get; set; } 
        public IRPSTextBox<ParameterPurchaseEntityView> PercentReceived { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDDocumentCategoryOrder { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> FrameworkContractPrice { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ReceptionDateComCondition { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DeleteOrder { get; set; } 
        public IRPSTextBox<ParameterPurchaseEntityView> TariffFactor { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ZippedDocuments { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> PreliminaryDeliveryNote { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> RegisteredInvoice { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> FinalizedInvoice { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDSiteQuality { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDWareHouseQuality { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDWareHouseReject { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> OutputExternalTask { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDVATFree { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDVATTypeTransport { get; set; } 
        public IRPSTextBox<ParameterPurchaseEntityView> ClosedDate { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> PeriodNotPayment { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> KeyNotPayment { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> FixedDayPayment { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> FixedMonthPayment { get; set; } 
        public IRPSTextBox<ParameterPurchaseEntityView> AdvancePercentage { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentFrom1 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentFrom1 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentTo1 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentTo1 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentFrom2 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentFrom2 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentTo2 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentTo2 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentFrom3 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentFrom3 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> DayNotPaymentTo3 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> MonthNotPaymentTo3 { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDArticleAdvanceStatistic { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDAdvancePaymentVATType { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDAdvancePaymentMethod { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> RetentionAdvances { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDCodingSeriePurchaseProposal { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDCodingSerieSupplierRFQ { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDCodingSeriePurchaseDeliveryNote { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDCodingSerieRappelAgreement { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDCodingSerieMerchandiseGift { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDDocCategoryRetentionInvoice { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDFrameworkCStatusInitial { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDFrameworkCStatusOffer { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDOrderSituation { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDOrderSituationManual { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDOrderSituationDirect { get; set; } 
        public IRPSTextBox<ParameterPurchaseEntityView> MaxAmountOrder { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDOrderSituationMax { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDOrderSituationMin { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> TextLineGeneralReplace { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineSRQuotationPre { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineSRQuotationPost { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedStockMimimun { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedProject { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedManufacturing { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedFromMRP { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedMaintenance { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedOrderLine { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedFromSales { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedFromProvisioningList { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> ProposalValidatedSupplierRFQ { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> TypePurchaseFromSales { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDArticleCommission { get; set; } 
        public IRPSCheckbox<ParameterPurchaseEntityView> FinalizedSalesRappel { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDDeliveryNoteTypeMaintenance { get; set; } 
        public IRPSComboBox<ParameterPurchaseEntityView> IDDeliveryNoteTypeContractMAN { get; set; } 
        public IRPSSection<ParameterPurchaseEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<ParameterPurchaseEntityView> ServicesIntegration { get; set; } 
        public ParameterPurchase Screen { get; set; }
        public ParameterPurchaseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
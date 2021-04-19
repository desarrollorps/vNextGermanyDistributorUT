    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierClassification
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierClassification:Screen
    {
        public SupplierClassification():base()
        {
            this.URL = "purchase.supplierclassification";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierClassificationCollectionView  = new SupplierClassificationCollectionView(this); 
            SupplierClassificationEntityView  = new SupplierClassificationEntityView(this); 
            SupplierClassificationDetailView  = new SupplierClassificationDetailView(this); 
            SupplierClassificationCollectionView.InitializeControls(); 
            SupplierClassificationEntityView.InitializeControls(); 
            SupplierClassificationDetailView.InitializeControls(); 
           
        }
      
            public SupplierClassificationCollectionView SupplierClassificationCollectionView {get; set; } 
            public SupplierClassificationEntityView SupplierClassificationEntityView {get; set; } 
            public SupplierClassificationDetailView SupplierClassificationDetailView {get; set; } 
    }
            
    public partial class SupplierClassificationCollectionView : View
    {
        public SupplierClassificationCollectionView(SupplierClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierClassificationCollectionView,SupplierClassificationEntityView>( this,Screen.SupplierClassificationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "05e5b6ff-5ac6-45f1-8534-cd1db139d28a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierClassificationCollectionView,SupplierClassificationEntityView>( params_MainConsult,this,Screen.SupplierClassificationEntityView);
 

        }
        public IRPSButton<SupplierClassificationCollectionView,SupplierClassificationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierClassificationCollectionView,SupplierClassificationEntityView> MainConsult { get; set; } 
        public SupplierClassification Screen { get; set; }
        public SupplierClassificationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierClassificationEntityView : View
    {
        public SupplierClassificationEntityView(SupplierClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierClassificationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierClassificationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierClassificationEntityView,SupplierClassificationCollectionView>( this,Screen.SupplierClassificationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierClassificationEntityView,SupplierClassificationCollectionView>( this,Screen.SupplierClassificationCollectionView);
 
            CodSupplierClassification = RPSControlFactory.CreateRPSTextBox<SupplierClassificationEntityView>("f2534bf8-3e86-4d02-a478-a9752e56bab5","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierClassificationEntityView>("81f93922-ef29-4d3e-b01e-26ef03ad802b","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierClassificationEntityView>("cedef9c9-cb1a-45de-a761-7dbbf97af901","","",true, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("4381af41-f82b-4571-89cc-b99e958f7012","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("bc2917ba-5b82-4141-8d8e-d3046c0991c9","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("da2f4ee4-af86-4c37-a79b-6c93cf82f243","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("10d6e81e-63cd-4539-a3e0-e731882bc232","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("dfe17a44-3105-474d-93d0-fbd1f7a8c5bd","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierClassificationEntityView>("a177129e-b8ab-44af-8fc4-33518555a1aa","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("dd48a114-ef5b-40a8-899a-c3046372b417","","",false, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("237d7cd5-d1d1-42a6-9a3f-1fdcafb3edfb","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("442ad070-f0da-41c6-ba78-19cf109daecd","","",false, this);
 
            InvoiceType = RPSControlFactory.CreateRPSEnumComboBox<SupplierClassificationEntityView>("4738fd70-9e65-490e-88f6-68e06be45a99","","",true, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("b9a6dd41-4115-4064-8ee2-00d20e4b4a0d","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("c6b4bd9c-1bec-449b-a3b5-28ccad1319bc","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("919fe2a7-ad1a-44e7-a4da-12fc29280f9a","","",false, this);
 
            TypeAdvanceInvoice = RPSControlFactory.CreateRPSEnumComboBox<SupplierClassificationEntityView>("3ea8e04a-77df-4c55-a6bf-ee32d8108497","","",true, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("a0f2ffd3-348a-4a7b-8bb9-eba055faa81a","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("bc857176-22c1-4c6a-8694-2b2b185b82aa","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("c914a690-d525-412b-91fb-fd5eab885cfe","","",false, this);
 
            IDSupplierType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("5726ae84-89cf-4397-9a28-a5adf22171e1","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("e0825c19-b3c9-44c2-9118-0e89f162502b","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("bd8ab711-0f0a-4e20-9902-46dd090a301f","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("8f83c8be-5a85-4f16-9efb-30edcc7e9c43","","",false, this);
 
            IDCodingSerieRetentionVoucher = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("81ea63d5-7ecd-4b72-a50b-858dfd2c61c8","","",false, this);
 
            AutoLiquidate = RPSControlFactory.CreateRPSCheckBox<SupplierClassificationEntityView>("7a41eb81-d530-4364-94ba-a83aa68f4898","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("dc7ed69d-c3be-44be-ab71-934c530c05d5","","",false, this);
 
            IDCodingSerieSupplier = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("c2218cf5-8a97-4050-badf-da84691e46f6","","",false, this);
 
            IDTextLineSRQuotationPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("047f784d-4582-40f5-8445-2997bd0d0b04","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("1ad45e65-ed57-408f-9595-33d448d1112c","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("820b3dd2-e712-4629-967a-6899b273ecce","","",false, this);
 
            IDTextLineSRQuotationPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("f2ef6338-0fe2-4e6c-b86d-baf2b95b6d43","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("2a2a99bd-ba9c-4ef0-b964-9421fb67bb60","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationEntityView>("cce5e58e-1476-4632-953f-3334b15eb261","","",false, this);
 
            CollectionInit params_SupplierClassificationDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="518f9725-e5c8-4d96-95ad-2bcb49cac46d",CSSSelectorGrid="",XPathGrid=""};
            SupplierClassificationDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierClassificationDetailsCollectionEditor<SupplierClassificationEntityView,SupplierClassificationDetailView>,SupplierClassificationEntityView,SupplierClassificationDetailView>( params_SupplierClassificationDetails,this,Screen.SupplierClassificationDetailView);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierClassificationEntityView>( "","ul li[rpsid='e5f78130-c7d9-4091-9456-bddd0bf8a8ba']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<SupplierClassificationEntityView>( "","ul li[rpsid='a0138173-e0f1-4106-8093-bd57627088a7']","",this);
 

        }
        public IRPSSaveButton<SupplierClassificationEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierClassificationEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierClassificationEntityView,SupplierClassificationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierClassificationEntityView,SupplierClassificationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierClassificationEntityView> CodSupplierClassification { get; set; } 
        public IRPSTextBox<SupplierClassificationEntityView> Description { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> ThirdType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> CodCountry { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierClassificationEntityView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDVATType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> InvoiceType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> TypeAdvanceInvoice { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDSupplierType { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieRetentionVoucher { get; set; } 
        public IRPSCheckbox<SupplierClassificationEntityView> AutoLiquidate { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDCodingSerieSupplier { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineSRQuotationPre { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineSRQuotationPost { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<SupplierClassificationEntityView> IDTextLineOrderPost { get; set; } 
        public SupplierClassificationDetailsCollectionEditor<SupplierClassificationEntityView,SupplierClassificationDetailView> SupplierClassificationDetails { get; set; } 
        public IRPSSection<SupplierClassificationEntityView> Section { get; set; } 
        public IRPSSection<SupplierClassificationEntityView> Subsidiaries { get; set; } 
        public SupplierClassification Screen { get; set; }
        public SupplierClassificationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierClassificationDetailsCollectionEditor<SupplierClassificationEntityView,SupplierClassificationDetailView>:RPSCollectionEditor<SupplierClassificationEntityView,SupplierClassificationDetailView> where SupplierClassificationEntityView : class, IView where SupplierClassificationDetailView : class, IView
    {
        public  SupplierClassificationDetailsGridView<SupplierClassificationEntityView,SupplierClassificationDetailView> GridView {get;set;}
    }
    public partial class SupplierClassificationDetailsGridView <SupplierClassificationEntityView,SupplierClassificationDetailView> :  RPSGridView<SupplierClassificationEntityView,SupplierClassificationDetailView> where SupplierClassificationEntityView : class, IView where SupplierClassificationDetailView : class, IView
    {
        public SupplierClassificationDetailsGridView(SupplierClassificationEntityView currentView,SupplierClassificationDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierClassificationEntityView>("","#518f9725-e5c8-4d96-95ad-2bcb49cac46d .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSGridComboBox<SupplierClassificationEntityView>("","#518f9725-e5c8-4d96-95ad-2bcb49cac46d .ag-row[role='row']@ROWINDEX [col-id='cIDBusinessUnit']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierClassificationEntityView>("","#518f9725-e5c8-4d96-95ad-2bcb49cac46d .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<SupplierClassificationEntityView>("","#518f9725-e5c8-4d96-95ad-2bcb49cac46d .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<SupplierClassificationEntityView>("","#518f9725-e5c8-4d96-95ad-2bcb49cac46d .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierClassificationEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierClassificationEntityView> IDBusinessUnit { get; set; } 
        public IRPSGridComboBox<SupplierClassificationEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<SupplierClassificationEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<SupplierClassificationEntityView> IDVATType { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierClassificationDetailView : View
    {
        public SupplierClassificationDetailView(SupplierClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierClassificationDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierClassificationDetailView,SupplierClassificationEntityView>( this,Screen.SupplierClassificationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierClassificationDetailView,SupplierClassificationEntityView>( this,Screen.SupplierClassificationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierClassificationDetailView,SupplierClassificationEntityView>( this,Screen.SupplierClassificationEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("bb0d256d-aa20-4bfd-8f2d-de7b2414cbdc","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("411e9809-4a55-4be9-a2d4-430c1a93b802","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("9aa8fa96-07f0-49c9-80c7-75ca27862817","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("a60cf430-d8f4-4e97-9d03-59dca4861f0a","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierClassificationDetailView>("f9ed9863-cc30-41f2-ba44-56c90eaacd38","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("9b8764f3-45ee-4462-826b-6014e87939db","","",false, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("79078265-372a-4e97-8e2c-4db0054bba0b","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("19898c5a-7072-4ea8-ba8e-9da9e51f5b59","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("01689f16-f8cd-4238-898a-e5db16e02897","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("88aea0ef-c306-46bf-b40a-a3842bf2250d","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("e12941b2-6dd1-4d3a-b042-4642fc00fba1","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("1a9dcb67-0581-4cef-bbe1-290a11f2c995","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("594e868d-bc96-496e-b1cd-a7a54d5f0ced","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("febca84b-2186-475f-8365-f01ecf26993b","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("b108063f-7494-48fc-929a-c4ca649e6306","","",false, this);
 
            IDCodingSerieRetentionVoucher = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("a0c63ec7-80a7-4a41-af56-3382d65b0df4","","",false, this);
 
            AutoLiquidate = RPSControlFactory.CreateRPSCheckBox<SupplierClassificationDetailView>("330b3f2a-a945-4517-869f-513f2e35d515","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("de03c8ea-a50f-4324-8f4e-75c496fd1e01","","",false, this);
 
            IDCodingSerieSupplier = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("260255fd-5fd0-45f0-bf02-a5d77c87a79b","","",false, this);
 
            IDTextLineSRQuotationPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("b46536bc-c7da-4234-9ea4-175dff7d2caf","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("20655578-293c-4775-9e7f-d55a017a641d","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("10c7a66b-7e81-47b7-861d-2d4645fc22bf","","",false, this);
 
            IDTextLineSRQuotationPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("eceff1f6-278e-4975-a69c-d10ca393d06c","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("696f172e-e9ea-4192-9cb4-3937b5cdef98","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<SupplierClassificationDetailView>("0242fb46-a0fb-4d2e-b664-a715562947f6","","",false, this);
 

        }
        public IRPSButton<SupplierClassificationDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierClassificationDetailView,SupplierClassificationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierClassificationDetailView,SupplierClassificationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierClassificationDetailView,SupplierClassificationEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> CodCompany { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierClassificationDetailView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDVATType { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTaxGroup { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieRetentionVoucher { get; set; } 
        public IRPSCheckbox<SupplierClassificationDetailView> AutoLiquidate { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDCodingSerieSupplier { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineSRQuotationPre { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineSRQuotationPost { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<SupplierClassificationDetailView> IDTextLineOrderPost { get; set; } 
        public SupplierClassification Screen { get; set; }
        public SupplierClassificationDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
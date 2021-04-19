    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.FrameworkContractSL
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContractSL:Screen
    {
        public FrameworkContractSL():base()
        {
            this.URL = "sales.frameworkcontractsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrameworkContractSLCollectionView  = new FrameworkContractSLCollectionView(this); 
            FrameworkContractSLEntityView  = new FrameworkContractSLEntityView(this); 
            FrameworkContractLineSLView  = new FrameworkContractLineSLView(this); 
            FrameworkContractCopyChildDialogView  = new FrameworkContractCopyChildDialogView(this); 
            FrameworkContractChangeCustomerDialogView  = new FrameworkContractChangeCustomerDialogView(this); 
            FrameworkContractPrintDialogView  = new FrameworkContractPrintDialogView(this); 
            FrameworkContractSLCollectionView.InitializeControls(); 
            FrameworkContractSLEntityView.InitializeControls(); 
            FrameworkContractLineSLView.InitializeControls(); 
            FrameworkContractCopyChildDialogView.InitializeControls(); 
            FrameworkContractChangeCustomerDialogView.InitializeControls(); 
            FrameworkContractPrintDialogView.InitializeControls(); 
           
        }
      
            public FrameworkContractSLCollectionView FrameworkContractSLCollectionView {get; set; } 
            public FrameworkContractSLEntityView FrameworkContractSLEntityView {get; set; } 
            public FrameworkContractLineSLView FrameworkContractLineSLView {get; set; } 
            public FrameworkContractCopyChildDialogView FrameworkContractCopyChildDialogView {get; set; } 
            public FrameworkContractChangeCustomerDialogView FrameworkContractChangeCustomerDialogView {get; set; } 
            public FrameworkContractPrintDialogView FrameworkContractPrintDialogView {get; set; } 
    }
            
    public partial class FrameworkContractSLCollectionView : View
    {
        public FrameworkContractSLCollectionView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrameworkContractSLCollectionView,FrameworkContractSLEntityView>( this,Screen.FrameworkContractSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cc52a5c0-8187-4bc5-96ec-7995b4f57b54",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrameworkContractSLCollectionView,FrameworkContractSLEntityView>( params_MainConsult,this,Screen.FrameworkContractSLEntityView);
 

        }
        public IRPSButton<FrameworkContractSLCollectionView,FrameworkContractSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrameworkContractSLCollectionView,FrameworkContractSLEntityView> MainConsult { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractSLEntityView : View
    {
        public FrameworkContractSLEntityView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrameworkContractSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractSLEntityView,FrameworkContractSLCollectionView>( this,Screen.FrameworkContractSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractSLEntityView,FrameworkContractSLCollectionView>( this,Screen.FrameworkContractSLCollectionView);
 
            CodFrameworkContract = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("e047da3f-0270-41e3-b359-1ca1d0033df6","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("95f8b7af-4fc1-4a36-bc53-d74eb6b63816","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("b97244e8-dd71-4479-b71e-6b3c30a677b0","","",false, this);
 
            IDFrameworkContractStatus = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("22107792-03ca-4616-a000-1b1e1b35406c","","",true, this);
 
            FrameworkContractDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("def5f738-3446-4207-97d6-7d1d537e9298","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("6aa0086c-12d7-4c86-ad22-7659c6053bcc","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("5f7a4025-ea1f-4c60-a3b9-8185284dddb7","","",true, this);
 
            LimitedQuantity = RPSControlFactory.CreateRPSCheckBox<FrameworkContractSLEntityView>("31aa3427-3d7a-4cc0-977b-005437de3af5","","",true, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("07c664d5-ccc1-4b2b-aaae-c232c9d9f71d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("279a2b2d-8705-407e-93f6-9fc51bf2e21b","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("747765a8-eaff-4f38-a819-67b5c2b63ef1","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("1e767a07-63c5-4554-803d-26797c1c0062","","",false, this);
 
            IDDeliveryAddress = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("c091b3e3-238a-4c28-82ef-94ff9565132b","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("b3cf3c2b-0df1-4e0f-9e3c-d0644cbd1d44","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("33314081-ca67-4cc1-b4c0-2e28ac6cc86d","","",false, this);
 
            IDSalesQuote = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("afe15dd3-bf4b-4160-919f-d051d4af42ca","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("d854c7d2-1b88-4123-b519-d07fbf944933","","",false, this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("b729bb5f-5cb6-4217-b28c-94c3c65f17d8","","",false, this);
 
            DeliveryProgNumber = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("e193967b-0f66-4c1e-8e52-6e236d58c6e6","","",false, this);
 
            TotalFrameworkContract = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractSLEntityView>("ee215af8-ff8e-4517-820c-729679f079fa","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractSLEntityView>("79efa8a0-83ea-45aa-8954-c7ca66123480","","",false, this);
 
            VATBaseAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractSLEntityView>("593c494f-8e8d-4e5f-ac37-6a00a077cb04","","",false, this);
 
            TotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractSLEntityView>("6a650709-43f5-438c-828b-5d3ba9c2e23d","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("476ade05-7a10-4db1-a7a3-772cc0b89d49","","",false, this);
 
            CommentsSend = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("fb641a7c-230b-40bf-a70d-1a0aafd5b65a","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("adefce9b-31b2-4ee3-9e20-0b72decceeec","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("edd3d31f-29d4-475d-ae54-5192976ad45e","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("ecda12a5-b47b-4910-b2a6-2e9840f57a98","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("ef1f63b7-f1f0-457e-8880-bd29a5700c99","","",false, this);
 
            IDDeliveryAddress1 = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("923eb39b-a86b-4ace-8aa7-1bc903d877ae","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("d2ed6a0b-f08c-46f1-a408-94364fefa3b6","","",false, this);
 
            AddressDescription = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("53cb2311-1a2a-4d35-ae1d-4edf62438f59","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("337398c3-7efb-4c77-ba69-f363a99a4623","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("a91dba02-d82e-48bd-9427-839700b9b208","","",false, this);
 
            IDZipCode = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("4d328c38-f6f6-42a8-a341-c36194aff7b2","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("fc66bcf9-4858-4328-8ed6-e405e82715f6","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("e9d49c82-de0e-4b3d-b672-f02856f6c3d0","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("65e2fdd5-cbc5-4601-964a-70ceee34c2fe","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("a4194820-ada2-43ac-afde-513464734f68","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<FrameworkContractSLEntityView>("24b1e435-a859-49c4-a264-356253fb5068","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<FrameworkContractSLEntityView>("ea8499a0-1401-4053-a353-314918b59d39","","",false, this);
 
            FrameworkContractCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractSLEntityView,FrameworkContractCopyChildDialogView>("1aec4ff4-36e5-4bc6-9a37-1f934d270f49","","", this,Screen.FrameworkContractCopyChildDialogView);
 
            FrameworkContractChangeCustomerNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractSLEntityView,FrameworkContractChangeCustomerDialogView>("c9a76d47-6a70-4dde-b8f0-cc2e4d4cb64b","","", this,Screen.FrameworkContractChangeCustomerDialogView);
 
            FrameworkContractPrintOptionsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractSLEntityView,FrameworkContractPrintDialogView>("70b571bd-ec2b-4d09-a6b4-f2a11d053a34","","", this,Screen.FrameworkContractPrintDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<FrameworkContractSLEntityView>( "e2a04486-514d-437a-8ec1-5b6c34d7102b","","",this);
 
            CollectionInit params_FrameworkContractLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b91c6d51-834c-4af1-add1-f5afa9a322b1",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractLineSLsCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView>,FrameworkContractSLEntityView,FrameworkContractLineSLView>( params_FrameworkContractLineSLs,this,Screen.FrameworkContractLineSLView);
 
            CollectionInit params_FrameworkContractDeliveryAddresss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8a3c69a0-e64b-4b82-bed8-4342a0998d24",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractDeliveryAddresss = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractDeliveryAddresssCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView>,FrameworkContractSLEntityView,FrameworkContractLineSLView>( params_FrameworkContractDeliveryAddresss,this,Screen.FrameworkContractLineSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='4b1e2107-690c-479f-9462-bf93c32e3626']","",this);
 
            Lines = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='4b2afe06-bd44-4597-b393-1335b83729a7']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='0e61085d-2b8e-409c-831c-f5249063dfe5']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='6ea227ef-4b67-4d61-8181-73c9806a78e9']","",this);
 
            Delivery = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='8a8f14d8-4e37-4852-b2e7-97e7da4e5786']","",this);
 
            Send = RPSControlFactory.CreateRPSSection<FrameworkContractSLEntityView>( "","ul li[rpsid='847297f9-0949-4284-8f78-8dc2ef19bf00']","",this);
 

        }
        public IRPSSaveButton<FrameworkContractSLEntityView> SaveButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView,FrameworkContractSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView,FrameworkContractSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> CodFrameworkContract { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDFrameworkContractStatus { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> FrameworkContractDate { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> DateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> DateTo { get; set; } 
        public IRPSCheckbox<FrameworkContractSLEntityView> LimitedQuantity { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDDeliveryAddress { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDSalesQuote { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDEmployee { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> OrderNumberCustomer { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> DeliveryProgNumber { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> TotalFrameworkContract { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> VATAmount { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> VATBaseAmount { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> TotalLinesAmount { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> Comment { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> CommentsSend { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> PreText { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> PostText { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDDeliveryAddress1 { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> Address { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> AddressDescription { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> City { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> IDZipCode { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> ContactPerson { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDState { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> Phone2 { get; set; } 
        public IRPSComboBox<FrameworkContractSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<FrameworkContractSLEntityView> Fax { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView,FrameworkContractCopyChildDialogView> FrameworkContractCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView,FrameworkContractChangeCustomerDialogView> FrameworkContractChangeCustomerNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView,FrameworkContractPrintDialogView> FrameworkContractPrintOptionsNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractSLEntityView> TotalsUpdateButton { get; set; } 
        public FrameworkContractLineSLsCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView> FrameworkContractLineSLs { get; set; } 
        public FrameworkContractDeliveryAddresssCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView> FrameworkContractDeliveryAddresss { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> GeneralData { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> Lines { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> Comments { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> TextLine { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> Delivery { get; set; } 
        public IRPSSection<FrameworkContractSLEntityView> Send { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FrameworkContractLineSLsCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView>:RPSCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView> where FrameworkContractSLEntityView : class, IView where FrameworkContractLineSLView : class, IView
    {
        public  FrameworkContractLineSLsGridView<FrameworkContractSLEntityView,FrameworkContractLineSLView> GridView {get;set;}
    }
    public partial class FrameworkContractLineSLsGridView <FrameworkContractSLEntityView,FrameworkContractLineSLView> :  RPSGridView<FrameworkContractSLEntityView,FrameworkContractLineSLView> where FrameworkContractSLEntityView : class, IView where FrameworkContractLineSLView : class, IView
    {
        public FrameworkContractLineSLsGridView(FrameworkContractSLEntityView currentView,FrameworkContractLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomerDeliveryAddress']","",false, this.CurrentView);
 
            NumberOfSalesOrdersOpen = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cNumberOfSalesOrdersOpen']","",true, this.CurrentView);
 
            OpenQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractSLEntityView>("","#b91c6d51-834c-4af1-add1-f5afa9a322b1 .ag-row[role='row']@ROWINDEX [col-id='cOpenQuantity']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<FrameworkContractSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> PlanNumber { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> AmountWithVAT { get; set; } 
        public IRPSGridComboBox<FrameworkContractSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> NumberOfSalesOrdersOpen { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> OpenQuantity { get; set; } 
                     
    }
 
        public partial class FrameworkContractDeliveryAddresssCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView>:RPSCollectionEditor<FrameworkContractSLEntityView,FrameworkContractLineSLView> where FrameworkContractSLEntityView : class, IView where FrameworkContractLineSLView : class, IView
    {
        public  FrameworkContractDeliveryAddresssGridView<FrameworkContractSLEntityView,FrameworkContractLineSLView> GridView {get;set;}
    }
    public partial class FrameworkContractDeliveryAddresssGridView <FrameworkContractSLEntityView,FrameworkContractLineSLView> :  RPSGridView<FrameworkContractSLEntityView,FrameworkContractLineSLView> where FrameworkContractSLEntityView : class, IView where FrameworkContractLineSLView : class, IView
    {
        public FrameworkContractDeliveryAddresssGridView(FrameworkContractSLEntityView currentView,FrameworkContractLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomerDeliveryAddress']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            CodCountry = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cCodCountry']","",false, this.CurrentView);
 
            ZipCode = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cZipCode']","",false, this.CurrentView);
 
            IDCounty = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cIDCounty']","",false, this.CurrentView);
 
            Address = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 
            DeliveryProgNumber = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractSLEntityView>("","#8a3c69a0-e64b-4b82-bed8-4342a0998d24 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryProgNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FrameworkContractSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> CodCountry { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> ZipCode { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> IDCounty { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> Address { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> ContactPerson { get; set; } 
        public IRPSGridTextBox<FrameworkContractSLEntityView> DeliveryProgNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class FrameworkContractLineSLView : View
    {
        public FrameworkContractLineSLView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractLineSLView,FrameworkContractSLEntityView>( this,Screen.FrameworkContractSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractLineSLView,FrameworkContractSLEntityView>( this,Screen.FrameworkContractSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FrameworkContractLineSLView,FrameworkContractSLEntityView>( this,Screen.FrameworkContractSLEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("77321d41-f20f-4715-8f8f-ca0d1c60c73c","","",true, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractLineSLView>("2da08ddf-2ecb-43f5-ba60-83ed6b975600","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("f4a0ac28-371d-48e3-b247-13fed0492b21","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("6fea210d-af14-4075-8b91-db3a51af6ee3","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("2910a563-3a7f-496f-b254-ddd4fff68693","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("2b0db0ab-0eff-4c79-819c-23bc012d1e43","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("295568ff-c391-43f2-9869-fb3a58d455e3","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<FrameworkContractLineSLView>("fff5b23a-fc62-49fc-81d2-6b5fdb95d60f","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("6388de70-fa3e-4e22-b270-c736aeabe200","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("67f2a673-e774-4b4f-93d5-87519996e1e5","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("5d70a864-a7da-433d-b7dc-f339fb90efdd","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("a40e0423-774a-4453-b61f-491094874d29","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("f506dad4-50a9-46e8-aca7-e2504e02a5d9","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("c827f2db-a20f-44f0-b474-80db84a63d60","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("d78209e6-70fe-4f9b-b811-2b4936ab6ed3","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("c250615d-f1ef-4366-b6ad-c1ee0396d0ac","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("35886c2f-a2d2-46d2-a475-6437460d99f6","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("3b63162f-5fdb-497d-b2e0-5ea29fe436ec","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("8c462a3e-0e07-494d-92f7-6cfcc4a0f89a","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("d4a5ea39-c828-4846-9f7f-8cd9b92f518a","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("55bd6a76-055e-40b3-82b4-e31126fe9c99","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractLineSLView>("6a6c94c7-1382-4807-83f7-c673eedd1ce5","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("73858d79-2617-4d8a-a45e-e5af08f20453","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("2fb50e97-f9de-46fe-8a51-0962082b4b2c","","",true, this);
 
            VAT1 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineSLView>("02b117a9-e470-4dfa-a70c-e88789c27e9f","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("a89ec29a-e628-4673-a460-60ab1ed35bf6","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("67916cba-775c-4008-8d1c-e84f00f71088","","",true, this);
 
            OrderQuantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("e2d45462-fa0b-4fd4-ace4-5aee8616fc82","","",true, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("7b31f100-6145-45c3-be85-b2d9420e9fca","","",true, this);
 
            MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("b566253e-e9d5-4203-a784-0ec3eaeb9395","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("931b1c94-efb9-48ad-b715-8076739ec09d","","",true, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineSLView>("029f6cab-e889-4c81-9412-cc7b9efe0be2","","",false, this);
 
            OpenQuantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("6d97e812-dac7-4090-be22-901992610119","","",true, this);
 
            NumberOfSalesOrdersOpen = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("a707f969-4f4e-472e-8d34-86095e04829a","","",true, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("d552e207-eb13-48bb-8599-6609beedf9ee","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineSLView>("929bb151-96f2-40ae-99a1-25e748e211e7","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FrameworkContractLineSLView>("770422a6-59d7-4593-808b-d5a9dad7d15d","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<FrameworkContractLineSLView>("233db370-cb25-46f4-8af2-5ac3b26ef595","","",false, this);
 
            CollectionInit params_FrameworkCLineConditionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b5fe558d-abbe-4089-af2d-7fd47cb1f54e",CSSSelectorGrid="",XPathGrid=""};
            FrameworkCLineConditionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkCLineConditionSLsCollectionEditor<FrameworkContractLineSLView>,FrameworkContractLineSLView>( params_FrameworkCLineConditionSLs,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FrameworkContractLineSLView>( "","ul li[rpsid='c71f0353-3b42-49fd-9805-c43d8fb0d602']","",this);
 
            SpecialConditionSection = RPSControlFactory.CreateRPSSection<FrameworkContractLineSLView>( "","ul li[rpsid='ca4821b3-8e3d-4a8a-87f9-8106cbb3323d']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<FrameworkContractLineSLView>( "","ul li[rpsid='6c489651-2208-4af3-a698-3497208b1ba2']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<FrameworkContractLineSLView>( "","ul li[rpsid='1d9f6d88-6fa1-42f9-87b0-57f5d3212d27']","",this);
 

        }
        public IRPSButton<FrameworkContractLineSLView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractLineSLView,FrameworkContractSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractLineSLView,FrameworkContractSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FrameworkContractLineSLView,FrameworkContractSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDArticle { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Quantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Price { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Amount { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDUnitPrice { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> ConversionFactorPrice { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> VAT { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> AmountWithVAT { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Discount1 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Discount2 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Discount3 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Discount4 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Discount5 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDVAT { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> PercentVAT { get; set; } 
        public IRPSCheckbox<FrameworkContractLineSLView> VAT1 { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> PercentSurcharge { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> OrderQuantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> SalesLot { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> MinimumLot { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<FrameworkContractLineSLView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> OpenQuantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> NumberOfSalesOrdersOpen { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> PriceBase { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> UIconditionPrice { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> Comment { get; set; } 
        public IRPSTextBox<FrameworkContractLineSLView> PlanNumber { get; set; } 
        public FrameworkCLineConditionSLsCollectionEditor<FrameworkContractLineSLView> FrameworkCLineConditionSLs { get; set; } 
        public IRPSSection<FrameworkContractLineSLView> GeneralData { get; set; } 
        public IRPSSection<FrameworkContractLineSLView> SpecialConditionSection { get; set; } 
        public IRPSSection<FrameworkContractLineSLView> Section { get; set; } 
        public IRPSSection<FrameworkContractLineSLView> DPS { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FrameworkCLineConditionSLsCollectionEditor<FrameworkContractLineSLView>:RPSCollectionEditor<FrameworkContractLineSLView> where FrameworkContractLineSLView : class, IView
    {
        public  FrameworkCLineConditionSLsGridView<FrameworkContractLineSLView> GridView {get;set;}
    }
    public partial class FrameworkCLineConditionSLsGridView <FrameworkContractLineSLView> :  RPSGridView<FrameworkContractLineSLView> where FrameworkContractLineSLView : class, IView
    {
        public FrameworkCLineConditionSLsGridView(FrameworkContractLineSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<FrameworkContractLineSLView>("","#b5fe558d-abbe-4089-af2d-7fd47cb1f54e .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FrameworkContractLineSLView> Type { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> Base { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> Amount { get; set; } 
        public IRPSGridComboBox<FrameworkContractLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<FrameworkContractLineSLView> BaseApply { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineSLView> DateTo { get; set; } 
        public IRPSGridCheckbox<FrameworkContractLineSLView> AffectsPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class FrameworkContractCopyChildDialogView : View
    {
        public FrameworkContractCopyChildDialogView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedOriginFrameworkContract = RPSControlFactory.CreateRPSComboBox<FrameworkContractCopyChildDialogView>("e82058ed-0bcf-4e68-9eea-667128da798b","","",false, this);
 
            UINewCodFrameworkContract = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("488557af-a00c-4818-a515-225ade2544f8","","",true, this);
 
            IDSelectedCustomer = RPSControlFactory.CreateRPSComboBox<FrameworkContractCopyChildDialogView>("9eec5212-4b68-4f87-938e-2cbdd1b7030d","","",true, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("e4f6938d-cb9e-4697-af04-eddb312d9ee7","","",true, this);
 
            SelectedDateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("0787c58b-8727-4a55-a298-246d6c0bac0a","","",true, this);
 
            SelectedDateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("bcbc5e16-7bc0-4238-a38f-fc61684d59e0","","",true, this);
 
            SelectedHeaderRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("213eaac8-847d-4d05-afbf-aad69a34dd71","","",false, this);
 
            SelectedLinesRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("4de2fe86-c328-4a78-b7dc-8d79bd1e6460","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("20e1c21b-ac86-45df-b838-13b381a678de","","",false, this);
 

        }
        public IRPSComboBox<FrameworkContractCopyChildDialogView> IDSelectedOriginFrameworkContract { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> UINewCodFrameworkContract { get; set; } 
        public IRPSComboBox<FrameworkContractCopyChildDialogView> IDSelectedCustomer { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDate { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDateTo { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> SelectedHeaderRecalc { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> SelectedLinesRecalc { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> CopyDocuments { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractChangeCustomerDialogView : View
    {
        public FrameworkContractChangeCustomerDialogView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedCustomer = RPSControlFactory.CreateRPSComboBox<FrameworkContractChangeCustomerDialogView>("add3a695-2f0d-4e94-bd9d-88ec1b1f6974","","",false, this);
 
            SelectedHeaderRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractChangeCustomerDialogView>("4a461a00-7669-464f-9c34-c6392ce94c20","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<FrameworkContractChangeCustomerDialogView>("97eb0895-0500-4bc3-bbe6-e946da194236","","",false, this);
 

        }
        public IRPSComboBox<FrameworkContractChangeCustomerDialogView> IDSelectedCustomer { get; set; } 
        public IRPSCheckbox<FrameworkContractChangeCustomerDialogView> SelectedHeaderRecalc { get; set; } 
        public IRPSTextBox<FrameworkContractChangeCustomerDialogView> VATNumber { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractChangeCustomerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractPrintDialogView : View
    {
        public FrameworkContractPrintDialogView(FrameworkContractSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerLanguage = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "93a3b69d-99b4-49c4-bf4a-f95ac203af5a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "3b99e97c-6694-4af0-89ed-fe70b0061c7a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<FrameworkContractPrintDialogView>("74b00122-e12e-4583-9517-d0d912383dd3","","",false, this);
 
            CustomerCopy = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "3884df1c-5049-4602-9808-afa9d25c478f","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "5a549762-2aaf-4f7e-ab3f-2294e3248e89","","",this);
 
            UINumberOfCopies = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractPrintDialogView>("0cdfeb27-c7cd-421a-867e-eafcb2581fb2","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<FrameworkContractPrintDialogView>("c20e1889-adf0-4d27-a4b8-f1c528316e17","","",false, this);
 
            UIDCustomReport = RPSControlFactory.CreateRPSComboBox<FrameworkContractPrintDialogView>("871ab567-9fb8-4536-ba40-37569e0ea499","","",false, this);
 
            PrintFWCCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "68476ef0-15ad-49a7-95cd-41485a40bbf5","","",this);
 
            SendFWCByEmailCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "b2a7352d-27d5-42c1-9a62-ee60fe80d266","","",this);
 
            SendFWCToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "c65769b6-fb21-4120-bcac-0ab3dc22fa18","","",this);
 

        }
        public IRPSOption<FrameworkContractPrintDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<FrameworkContractPrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> CustomerCopy { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> SelectedCopy { get; set; } 
        public IRPSTextBox<FrameworkContractPrintDialogView> UINumberOfCopies { get; set; } 
        public IRPSCheckbox<FrameworkContractPrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<FrameworkContractPrintDialogView> UIDCustomReport { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> PrintFWCCommandButton { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> SendFWCByEmailCommandButton { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> SendFWCToCustomerEmailCommandButton { get; set; } 
        public FrameworkContractSL Screen { get; set; }
        public FrameworkContractPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
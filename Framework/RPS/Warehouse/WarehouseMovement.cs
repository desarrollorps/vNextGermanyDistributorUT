    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.WarehouseMovement
{
    //RPS VERSION 1.0.0.0
    public partial class WarehouseMovement:Screen
    {
        public WarehouseMovement():base()
        {
            this.URL = "warehouse.warehousemovement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarehouseMovementVMQueryView  = new WarehouseMovementVMQueryView(this); 
            WarehouseMovementVMEntityView  = new WarehouseMovementVMEntityView(this); 
            WarehouseMovementVMChildDialogView  = new WarehouseMovementVMChildDialogView(this); 
            SelectPriceChildDialogView  = new SelectPriceChildDialogView(this); 
            WarehouseMovementVMQueryView.InitializeControls(); 
            WarehouseMovementVMEntityView.InitializeControls(); 
            WarehouseMovementVMChildDialogView.InitializeControls(); 
            SelectPriceChildDialogView.InitializeControls(); 
           
        }
      
            public WarehouseMovementVMQueryView WarehouseMovementVMQueryView {get; set; } 
            public WarehouseMovementVMEntityView WarehouseMovementVMEntityView {get; set; } 
            public WarehouseMovementVMChildDialogView WarehouseMovementVMChildDialogView {get; set; } 
            public SelectPriceChildDialogView SelectPriceChildDialogView {get; set; } 
    }
            
    public partial class WarehouseMovementVMQueryView : View
    {
        public WarehouseMovementVMQueryView(WarehouseMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView>( this,Screen.WarehouseMovementVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<WarehouseMovementVMQueryView>( this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("fa5ee251-eaad-4d9a-af8e-69e1a6b87e2b","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("a6fcc59c-e2f5-4fe3-8800-dd1fb6e47426","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("e3c5a273-3159-4649-843e-67873924205b","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("c9619dbb-64e4-4f47-b959-163260058fb5","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("c96cc322-85aa-47b4-942b-9c6d73cf0bf1","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("05bf282c-1197-4ff6-9ebb-b4edf92d3e21","","",false, this);
 
            WarehouseSeries = RPSControlFactory.CreateRPSEnumComboBox<WarehouseMovementVMQueryView>("6ff15e2e-3125-4f5a-acc1-f163b2579d29","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("36cfd303-da53-4571-8044-3e998522cbc9","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMQueryView>("e7262b2c-32f1-4479-a51d-43f0a7656891","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMQueryView>("c55c36c7-73fd-4ffd-a3e5-ba0903e4f9dd","","",false, this);
 
            MovementType = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("88dd3969-10ed-49a5-bfdb-6687463cecfd","","",false, this);
 
            Preliminary = RPSControlFactory.CreateRPSCheckBox<WarehouseMovementVMQueryView>("10397acf-0f64-4b1d-968f-dbce515a5931","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<WarehouseMovementVMQueryView>( "4eccfc21-0ef1-41f3-a871-504eecc2f8ef","","",this);
 
            Proveedor = RPSControlFactory.CreateRPSOption<WarehouseMovementVMQueryView>( "952e2a4d-00e1-403e-bbd3-b08ffe32aa65","","",this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMQueryView>("3465ee60-e710-4037-8a40-fc202465cfdf","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMQueryView>("68660514-68a6-4e30-847e-18d3df01ea5e","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMQueryView>("f6073e20-492d-44cd-bd16-af44e7a77b85","","",false, this);
 
            ArticleStructure = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseMovementVMQueryView>("0d203612-852f-4499-98b1-67a9f55643f1","","",false, this);
 
            CollectionInit params_WarehouseMovementQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8b110c55-a53f-4db5-abe4-b164503d69f8",CSSSelectorGrid="",XPathGrid=""};
            WarehouseMovementQuery = RPSControlFactory.RPSCreateCollectionWithGrid<WarehouseMovementQueryCollectionEditor<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView>,WarehouseMovementVMQueryView,WarehouseMovementVMEntityView>( params_WarehouseMovementQuery,this,Screen.WarehouseMovementVMEntityView);
 

        }
        public IRPSButton<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> NewButton { get; set; } 
        public IRPSButton<WarehouseMovementVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> WareHouse { get; set; } 
        public IRPSComboBox<WarehouseMovementVMQueryView> WarehouseSeries { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> LocationWarehouse { get; set; } 
        public IRPSTextBox<WarehouseMovementVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<WarehouseMovementVMQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> MovementType { get; set; } 
        public IRPSCheckbox<WarehouseMovementVMQueryView> Preliminary { get; set; } 
        public IRPSOption<WarehouseMovementVMQueryView> Customer { get; set; } 
        public IRPSOption<WarehouseMovementVMQueryView> Proveedor { get; set; } 
        public IRPSComboBox<WarehouseMovementVMQueryView> Customer1 { get; set; } 
        public IRPSComboBox<WarehouseMovementVMQueryView> Supplier { get; set; } 
        public IRPSTextBox<WarehouseMovementVMQueryView> InternalCode { get; set; } 
        public IRPSCollectionComboBox<WarehouseMovementVMQueryView> ArticleStructure { get; set; } 
        public WarehouseMovementQueryCollectionEditor<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> WarehouseMovementQuery { get; set; } 
        public WarehouseMovement Screen { get; set; }
        public WarehouseMovementVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WarehouseMovementQueryCollectionEditor<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView>:RPSCollectionEditor<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> where WarehouseMovementVMQueryView : class, IView where WarehouseMovementVMEntityView : class, IView
    {
        public  WarehouseMovementQueryGridView<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> GridView {get;set;}
    }
    public partial class WarehouseMovementQueryGridView <WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> :  RPSGridView<WarehouseMovementVMQueryView,WarehouseMovementVMEntityView> where WarehouseMovementVMQueryView : class, IView where WarehouseMovementVMEntityView : class, IView
    {
        public WarehouseMovementQueryGridView(WarehouseMovementVMQueryView currentView,WarehouseMovementVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WarehouseMovement_Series = RPSControlFactory.CreateRPSGridTextBox<WarehouseMovementVMQueryView>("","#8b110c55-a53f-4db5-abe4-b164503d69f8 .ag-row[role='row']@ROWINDEX [col-id='cWarehouseMovement_Series']","",false, this.CurrentView);
 
            WarehouseMovement_MovementType = RPSControlFactory.CreateRPSGridTextBox<WarehouseMovementVMQueryView>("","#8b110c55-a53f-4db5-abe4-b164503d69f8 .ag-row[role='row']@ROWINDEX [col-id='cWarehouseMovement_MovementType']","",false, this.CurrentView);
 
            WarehouseMovement_MovementDate = RPSControlFactory.CreateRPSGridTextBox<WarehouseMovementVMQueryView>("","#8b110c55-a53f-4db5-abe4-b164503d69f8 .ag-row[role='row']@ROWINDEX [col-id='cWarehouseMovement_MovementDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarehouseMovementVMQueryView> WarehouseMovement_Series { get; set; } 
        public IRPSGridTextBox<WarehouseMovementVMQueryView> WarehouseMovement_MovementType { get; set; } 
        public IRPSGridTextBox<WarehouseMovementVMQueryView> WarehouseMovement_MovementDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class WarehouseMovementVMEntityView : View
    {
        public WarehouseMovementVMEntityView(WarehouseMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarehouseMovementVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarehouseMovementVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarehouseMovementVMEntityView,WarehouseMovementVMQueryView>( this,Screen.WarehouseMovementVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarehouseMovementVMEntityView,WarehouseMovementVMQueryView>( this,Screen.WarehouseMovementVMQueryView);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("0165efd5-0a33-41df-9b83-d798cf2760c5","","",true, this);
 
            MovementType = RPSControlFactory.CreateRPSEnumComboBox<WarehouseMovementVMEntityView>("ab66fce8-bfed-4bc6-a04b-529a7d41500f","","",true, this);
 
            MovementDate = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("9ee5980f-d690-4faa-9b89-b807e2cc5e14","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("4d7e48cc-616a-4f14-a9d9-e42251ea404b","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("fe1a3385-8c99-498f-a23c-afd6e0cd1571","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("2e39c1d9-1e80-4709-871f-e75d1982c914","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<WarehouseMovementVMEntityView>("8c1d6c68-f684-4a61-89c3-304744e6982a","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("54d28372-0283-4717-a365-c9e800145216","","",false, this);
 
            SiteTo = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("57bd920f-7d38-49a2-9316-f476dfb76c14","","",false, this);
 
            WareHouseTo = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("c5875ef1-376f-4219-ae90-4be7017a4c00","","",false, this);
 
            LocationWarehouseTo = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("4866235a-271e-40e4-a316-2d69d1a04c9a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("97636bd7-ce13-4658-a3c3-308770e0095f","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("88d28ed0-68a4-4e69-b663-ba1d2ec8708d","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("7344bbfb-5daf-4bfc-956a-0d08e8d3cb06","","",true, this);
 
            SelectPriceChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<WarehouseMovementVMEntityView,SelectPriceChildDialogView>("7022c599-6c7b-4be0-8a5c-d42a2ffdea85","","", this,Screen.SelectPriceChildDialogView);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("e561958d-c978-4ae5-873a-4212bf990b1b","","",true, this);
 
            InventoryQuantity = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("39efb3ad-e73b-4d53-a552-87648992a650","","",false, this);
 
            InventoryQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("f6a35898-d4a4-4283-bab6-6f6bb221f843","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("284f8041-eda3-43a2-a3f3-d0c1caf6fef6","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("60679f67-7b81-4615-b966-ccbd25d72b87","","",true, this);
 
            GeneratedFrom = RPSControlFactory.CreateRPSEnumComboBox<WarehouseMovementVMEntityView>("1adaaf1d-7a9c-4bb2-bcfa-feebb6a37fd1","","",true, this);
 
            DocumentGenerated = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("9c68c0f2-fb04-49eb-a786-bc86c3c2440c","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("4d792595-de4a-46f7-978b-2fb6dcd879cc","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("ba5c4e0d-0a3e-4c6a-9964-bbc20bc3cae0","","",false, this);
 
            Project = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("d91062fb-6d96-4e6f-9884-3ccd4132889b","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("9681fb81-ef19-40d7-bffe-1cbd35e4ae43","","",false, this);
 
            DeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("19b3344a-feb5-4a96-b7cb-c9465be4c778","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("ab54654b-9393-4a25-ac3c-75ac94944efa","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("21c8a89f-1ca1-4daf-96e3-c729928efc23","","",false, this);
 
            IntroductionDate = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("89e4dc4e-157d-4bdf-9cb3-a55ff328857e","","",true, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("bf73e22f-45a0-420d-a8ce-c65958f8c7c1","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<WarehouseMovementVMEntityView>("4398c15d-318c-44bb-897c-c1fe5df4c8ab","","",false, this);
 
            Preliminary = RPSControlFactory.CreateRPSCheckBox<WarehouseMovementVMEntityView>("ce6c2c1a-7436-4eea-8546-fa8b0a84d7f8","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("fc3055a8-9792-4f93-8d91-317167bbf5c5","","",false, this);
 
            PurchasePriceArticle = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("4a691209-47ad-4c8c-a90b-b75c68218c65","","",true, this);
 
            PurchasePriceSite = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("63fbd60a-c70a-4007-b6e8-82e6952290d9","","",true, this);
 
            PurchasePriceWarehouse = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("d2972659-3e9f-4bce-a631-f8a21c92c748","","",true, this);
 
            PurchasePriceSerie = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("7bab6887-d65a-4404-a9dd-c9c7e3bbb8e5","","",true, this);
 
            ManufacturePriceArticle = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("94608ef2-0df3-4492-ac95-1d156cf300c9","","",true, this);
 
            ManufacturePriceSite = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("9d29a7f1-784e-46fd-98d0-02a13871b8f8","","",true, this);
 
            ManufacturePriceWarehouse = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("f2c94c56-2617-41ad-a1b6-3cc8fcde7d2e","","",true, this);
 
            ManufacturePriceSerie = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("e3db2da2-3d64-4b33-916e-a30b33cace69","","",true, this);
 
            AveragePriceArticle = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("14a72753-1e09-463d-b108-eef288581255","","",true, this);
 
            AveragePriceSite = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("4b5b5c91-169b-4052-93d0-da392f9ccb69","","",true, this);
 
            AveragePriceWarehouse = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("4380a919-5d07-4ff2-81c2-fa2b1f434798","","",true, this);
 
            AveragePriceSerie = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("0c4157c4-a2a9-4372-ac82-abc3972aa3be","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("adb92320-ff1e-4887-8b09-098dc112a02e","","",true, this);
 
            StandardPriceSite = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMEntityView>("9f9f354c-0883-446b-bbad-253c294a016e","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<WarehouseMovementVMEntityView>("301a35c3-90b9-4fc1-97d1-022b8e27b9d9","","",false, this);
 
            BasicData = RPSControlFactory.CreateRPSSection<WarehouseMovementVMEntityView>( "","ul li[rpsid='e693d2d1-00f0-4ecf-b116-fd0515386b24']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<WarehouseMovementVMEntityView>( "","ul li[rpsid='69fca035-2b4d-4967-88dd-31e845b948b4']","",this);
 

        }
        public IRPSSaveButton<WarehouseMovementVMEntityView> SaveButton { get; set; } 
        public IRPSButton<WarehouseMovementVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarehouseMovementVMEntityView,WarehouseMovementVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarehouseMovementVMEntityView,WarehouseMovementVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDMovementType { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> MovementType { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> MovementDate { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> Series { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> SiteTo { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> WareHouseTo { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> LocationWarehouseTo { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> Price { get; set; } 
        public IRPSButton<WarehouseMovementVMEntityView,SelectPriceChildDialogView> SelectPriceChildNavigationCommand { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> Amount { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> InventoryQuantity { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> InventoryQuantitySecondUnit { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ReferenceSupplier { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> PotencyValue { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> GeneratedFrom { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> DocumentGenerated { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> MaintenanceOrder { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> Project { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> DeliveryNote { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> DeliveryNoteSL { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> IntroductionDate { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ExpiryDate { get; set; } 
        public IRPSComboBox<WarehouseMovementVMEntityView> IDArticleStructure { get; set; } 
        public IRPSCheckbox<WarehouseMovementVMEntityView> Preliminary { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> InternalCode { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> PurchasePriceArticle { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> PurchasePriceSite { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> PurchasePriceWarehouse { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> PurchasePriceSerie { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ManufacturePriceArticle { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ManufacturePriceSite { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ManufacturePriceWarehouse { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> ManufacturePriceSerie { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> AveragePriceArticle { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> AveragePriceSite { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> AveragePriceWarehouse { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> AveragePriceSerie { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> StandardPrice { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> StandardPriceSite { get; set; } 
        public IRPSTextBox<WarehouseMovementVMEntityView> Comment { get; set; } 
        public IRPSSection<WarehouseMovementVMEntityView> BasicData { get; set; } 
        public IRPSSection<WarehouseMovementVMEntityView> Comments { get; set; } 
        public WarehouseMovement Screen { get; set; }
        public WarehouseMovementVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarehouseMovementVMChildDialogView : View
    {
        public WarehouseMovementVMChildDialogView(WarehouseMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSEnumComboBox<WarehouseMovementVMChildDialogView>("e5db1f2e-3ea3-4222-bbb8-87d88fc45cf9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseMovementVMChildDialogView>("44f525ac-d699-42c8-9ae6-39e1fa954c24","","",true, this);
 

        }
        public IRPSComboBox<WarehouseMovementVMChildDialogView> Series { get; set; } 
        public IRPSTextBox<WarehouseMovementVMChildDialogView> Quantity { get; set; } 
        public WarehouseMovement Screen { get; set; }
        public WarehouseMovementVMChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SelectPriceChildDialogView : View
    {
        public SelectPriceChildDialogView(WarehouseMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PurchaseLastPrice = RPSControlFactory.CreateRPSOption<SelectPriceChildDialogView>( "ec8d6ef2-ba86-4bfb-9ba2-65ac7de7ecd0","","",this);
 
            LastPurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<SelectPriceChildDialogView>("137602e6-3ff9-4466-8827-1d64094a045b","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSOption<SelectPriceChildDialogView>( "081e31e3-603e-455f-8fc5-4eb3d55b6f6f","","",this);
 
            AveragePrice1 = RPSControlFactory.CreateRPSFormattedTextBox<SelectPriceChildDialogView>("b8c7fbc8-0420-41b7-afa4-7ce0fcad16e9","","",false, this);
 
            ManufacturingLastPrice = RPSControlFactory.CreateRPSOption<SelectPriceChildDialogView>( "86dc2774-7651-491e-b8d4-cbf0e98fb8d5","","",this);
 
            ManufacturingPrice = RPSControlFactory.CreateRPSFormattedTextBox<SelectPriceChildDialogView>("05656ea5-bc75-476a-89a6-ae6279d31a6f","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSOption<SelectPriceChildDialogView>( "d08596c4-9234-4e9b-a93f-a5cf71e2e67f","","",this);
 
            StandardPrice1 = RPSControlFactory.CreateRPSFormattedTextBox<SelectPriceChildDialogView>("6c0f295b-c8ee-4254-9c1a-3a0239ff1f84","","",false, this);
 
            CostValuationAccording = RPSControlFactory.CreateRPSOption<SelectPriceChildDialogView>( "2a9507f3-4af0-4ac3-ae6a-4eda845576b9","","",this);
 
            ValuationCostPrice = RPSControlFactory.CreateRPSFormattedTextBox<SelectPriceChildDialogView>("47904846-044a-448f-9997-c7e79845da4e","","",false, this);
 

        }
        public IRPSOption<SelectPriceChildDialogView> PurchaseLastPrice { get; set; } 
        public IRPSTextBox<SelectPriceChildDialogView> LastPurchasePrice { get; set; } 
        public IRPSOption<SelectPriceChildDialogView> AveragePrice { get; set; } 
        public IRPSTextBox<SelectPriceChildDialogView> AveragePrice1 { get; set; } 
        public IRPSOption<SelectPriceChildDialogView> ManufacturingLastPrice { get; set; } 
        public IRPSTextBox<SelectPriceChildDialogView> ManufacturingPrice { get; set; } 
        public IRPSOption<SelectPriceChildDialogView> StandardPrice { get; set; } 
        public IRPSTextBox<SelectPriceChildDialogView> StandardPrice1 { get; set; } 
        public IRPSOption<SelectPriceChildDialogView> CostValuationAccording { get; set; } 
        public IRPSTextBox<SelectPriceChildDialogView> ValuationCostPrice { get; set; } 
        public WarehouseMovement Screen { get; set; }
        public SelectPriceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
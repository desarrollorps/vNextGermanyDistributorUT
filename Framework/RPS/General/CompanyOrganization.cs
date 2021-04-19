    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CompanyOrganization
{
    //RPS VERSION 1.0.0.0
    public partial class CompanyOrganization:Screen
    {
        public CompanyOrganization():base()
        {
            this.URL = "general.companyorganization";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CompanyOrganizationView  = new CompanyOrganizationView(this); 
            CompanyView  = new CompanyView(this); 
            SiteView  = new SiteView(this); 
            WareHouseView  = new WareHouseView(this); 
            CompanyOrganizationView.InitializeControls(); 
            CompanyView.InitializeControls(); 
            SiteView.InitializeControls(); 
            WareHouseView.InitializeControls(); 
           
        }
      
            public CompanyOrganizationView CompanyOrganizationView {get; set; } 
            public CompanyView CompanyView {get; set; } 
            public SiteView SiteView {get; set; } 
            public WareHouseView WareHouseView {get; set; } 
    }
            
    public partial class CompanyOrganizationView : View
    {
        public CompanyOrganizationView(CompanyOrganization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public CompanyOrganization Screen { get; set; }
        public CompanyOrganizationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CompanyView : View
    {
        public CompanyView(CompanyOrganization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CompanyView>( this);
 
            CodCompany = RPSControlFactory.CreateRPSTextBox<CompanyView>("7b7c9220-e02e-41ee-9dfc-6fd201444d74","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CompanyView>("7e347cbd-5b00-4761-942d-848bd1a7cb0f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CompanyView>("52925633-8f4c-4390-887b-a2228a074658","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CompanyView>("44eaf136-744d-476c-bf9b-e74ca05770a3","","",true, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CompanyView>("a64f4363-b402-4f42-8481-dcd544aa9613","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CompanyView>("6a4dd1b2-29a1-4344-9a15-34fa88515162","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CompanyView>("db0c374c-4396-4b31-8e2b-bf714db24492","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CompanyView>("3ce203a3-dfaf-4f57-a870-d09e540701e0","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<CompanyView>("2d216129-693f-4a5e-a3aa-0193236e73c5","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CompanyView>("3c200b3f-2c8d-459a-b9d1-289f756c794d","","",false, this);
 
            DecimalPrice = RPSControlFactory.CreateRPSFormattedTextBox<CompanyView>("84abca98-81be-4584-8365-d033fc25b5e8","","",true, this);
 
            IDHourTypeDefault = RPSControlFactory.CreateRPSComboBox<CompanyView>("806e583a-102f-45cf-8ee6-1d5407d62f70","","",false, this);
 
            AllowModifiedMaster = RPSControlFactory.CreateRPSCheckBox<CompanyView>("d598a849-e0b2-4acc-9373-be6da4330920","","",true, this);
 
            CheckDuplicateCustomer = RPSControlFactory.CreateRPSCheckBox<CompanyView>("c79884da-2dbe-4b86-8992-28fcf1f579bb","","",true, this);
 
            CheckDuplicateSupplier = RPSControlFactory.CreateRPSCheckBox<CompanyView>("a9dd3514-0d03-4bf2-8781-7387f51404e3","","",true, this);
 
            ArticleManagment = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("83098382-b9de-4422-861a-3e4c0d214aa7","","",true, this);
 
            ArticleCodification = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("e022ac3c-abd8-4ef3-8341-187816e3b2e5","","",true, this);
 
            SupplierManagment = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("7ea071ba-c9c9-4527-a6cb-e68748f2f978","","",true, this);
 
            SupplierCodification = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("06c65d10-1dcb-4301-a3d0-8f65a17d1ee8","","",true, this);
 
            PurchaseCommercialConditions = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("930b4048-c555-4d38-b64a-20ba78a58d4e","","",true, this);
 
            CustomerManagment = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("c384381c-a8b0-45b0-9249-304112c96501","","",true, this);
 
            CustomerCodification = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("f5a5bf2c-53da-4b73-95c6-a3c085d79002","","",true, this);
 
            SalesPriceList = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("6c393c76-329d-4ba2-bb5c-1d5908892b98","","",true, this);
 
            SalesDiscountGroup = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("e209c1ef-5f0f-4685-86b6-47b55feca5f6","","",true, this);
 
            SalesSpecialPrices = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("21e42077-0fb1-48e0-ae5c-699754ed8df3","","",true, this);
 
            SalesPromotions = RPSControlFactory.CreateRPSEnumComboBox<CompanyView>("7eccecfa-d074-4180-8643-a871d1924cd6","","",true, this);
 
            CollectionInit params_CompanySubsidiarysArticle = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2ae71f8-f66c-4610-b7e2-47a3a8f3ce7f",CSSSelectorGrid="",XPathGrid=""};
            CompanySubsidiarysArticle = RPSControlFactory.RPSCreateCollectionWithGrid<CompanySubsidiarysArticleCollectionEditor<CompanyView>,CompanyView>( params_CompanySubsidiarysArticle,this);
 
            CollectionInit params_CompanySubsidiarysSupplier = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="26c5b1a9-40a7-4939-a678-177b0b486010",CSSSelectorGrid="",XPathGrid=""};
            CompanySubsidiarysSupplier = RPSControlFactory.RPSCreateCollectionWithGrid<CompanySubsidiarysSupplierCollectionEditor<CompanyView>,CompanyView>( params_CompanySubsidiarysSupplier,this);
 
            CollectionInit params_CompanyPurchaseRelationss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2976e25a-e947-4f03-b911-fe4a35caf958",CSSSelectorGrid="",XPathGrid=""};
            CompanyPurchaseRelationss = RPSControlFactory.RPSCreateCollectionWithGrid<CompanyPurchaseRelationssCollectionEditor<CompanyView>,CompanyView>( params_CompanyPurchaseRelationss,this);
 
            CollectionInit params_CompanySubsidiarysCustomer = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ec83e833-c22c-4d73-add3-c99e611779e9",CSSSelectorGrid="",XPathGrid=""};
            CompanySubsidiarysCustomer = RPSControlFactory.RPSCreateCollectionWithGrid<CompanySubsidiarysCustomerCollectionEditor<CompanyView>,CompanyView>( params_CompanySubsidiarysCustomer,this);
 
            CollectionInit params_CompanySalesRelationss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b83a234a-0219-499b-9f74-e066c848a797",CSSSelectorGrid="",XPathGrid=""};
            CompanySalesRelationss = RPSControlFactory.RPSCreateCollectionWithGrid<CompanySalesRelationssCollectionEditor<CompanyView>,CompanyView>( params_CompanySalesRelationss,this);
 
            CollectionInit params_CompanyVisibilityRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="08990acd-20bf-43a4-a8ef-e012f1137c9a",CSSSelectorGrid="",XPathGrid=""};
            CompanyVisibilityRelations = RPSControlFactory.RPSCreateCollectionWithGrid<CompanyVisibilityRelationsCollectionEditor<CompanyView>,CompanyView>( params_CompanyVisibilityRelations,this);
 
            SectionCompany = RPSControlFactory.CreateRPSSection<CompanyView>( "","ul li[rpsid='79692de0-8aa4-4eb3-a3fb-c6ca85308c9d']","",this);
 
            SectionAlmacen = RPSControlFactory.CreateRPSSection<CompanyView>( "","ul li[rpsid='263a2a51-e94f-4c71-950f-0610089e2484']","",this);
 
            SectionCompras = RPSControlFactory.CreateRPSSection<CompanyView>( "","ul li[rpsid='1a6fe587-ff73-410b-9ca6-455a889919e7']","",this);
 
            SectionVentas = RPSControlFactory.CreateRPSSection<CompanyView>( "","ul li[rpsid='ce71a7a5-b6c6-44ff-bfce-82357750b8bf']","",this);
 
            SectionVisibilidad = RPSControlFactory.CreateRPSSection<CompanyView>( "","ul li[rpsid='512fe125-9962-4a44-8a7a-a885ac4e9594']","",this);
 

        }
        public IRPSSaveButton<CompanyView> SaveButton { get; set; } 
        public IRPSTextBox<CompanyView> CodCompany { get; set; } 
        public IRPSTextBox<CompanyView> CompanyName { get; set; } 
        public IRPSTextBox<CompanyView> Description { get; set; } 
        public IRPSComboBox<CompanyView> CodCountry { get; set; } 
        public IRPSComboBox<CompanyView> IDState { get; set; } 
        public IRPSTextBox<CompanyView> City { get; set; } 
        public IRPSTextBox<CompanyView> Address { get; set; } 
        public IRPSTextBox<CompanyView> ZipCode { get; set; } 
        public IRPSTextBox<CompanyView> Phone { get; set; } 
        public IRPSComboBox<CompanyView> IDCurrency { get; set; } 
        public IRPSTextBox<CompanyView> DecimalPrice { get; set; } 
        public IRPSComboBox<CompanyView> IDHourTypeDefault { get; set; } 
        public IRPSCheckbox<CompanyView> AllowModifiedMaster { get; set; } 
        public IRPSCheckbox<CompanyView> CheckDuplicateCustomer { get; set; } 
        public IRPSCheckbox<CompanyView> CheckDuplicateSupplier { get; set; } 
        public IRPSComboBox<CompanyView> ArticleManagment { get; set; } 
        public IRPSComboBox<CompanyView> ArticleCodification { get; set; } 
        public IRPSComboBox<CompanyView> SupplierManagment { get; set; } 
        public IRPSComboBox<CompanyView> SupplierCodification { get; set; } 
        public IRPSComboBox<CompanyView> PurchaseCommercialConditions { get; set; } 
        public IRPSComboBox<CompanyView> CustomerManagment { get; set; } 
        public IRPSComboBox<CompanyView> CustomerCodification { get; set; } 
        public IRPSComboBox<CompanyView> SalesPriceList { get; set; } 
        public IRPSComboBox<CompanyView> SalesDiscountGroup { get; set; } 
        public IRPSComboBox<CompanyView> SalesSpecialPrices { get; set; } 
        public IRPSComboBox<CompanyView> SalesPromotions { get; set; } 
        public CompanySubsidiarysArticleCollectionEditor<CompanyView> CompanySubsidiarysArticle { get; set; } 
        public CompanySubsidiarysSupplierCollectionEditor<CompanyView> CompanySubsidiarysSupplier { get; set; } 
        public CompanyPurchaseRelationssCollectionEditor<CompanyView> CompanyPurchaseRelationss { get; set; } 
        public CompanySubsidiarysCustomerCollectionEditor<CompanyView> CompanySubsidiarysCustomer { get; set; } 
        public CompanySalesRelationssCollectionEditor<CompanyView> CompanySalesRelationss { get; set; } 
        public CompanyVisibilityRelationsCollectionEditor<CompanyView> CompanyVisibilityRelations { get; set; } 
        public IRPSSection<CompanyView> SectionCompany { get; set; } 
        public IRPSSection<CompanyView> SectionAlmacen { get; set; } 
        public IRPSSection<CompanyView> SectionCompras { get; set; } 
        public IRPSSection<CompanyView> SectionVentas { get; set; } 
        public IRPSSection<CompanyView> SectionVisibilidad { get; set; } 
        public CompanyOrganization Screen { get; set; }
        public CompanyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CompanySubsidiarysArticleCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanySubsidiarysArticleGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanySubsidiarysArticleGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanySubsidiarysArticleGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanySubsidiary = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#a2ae71f8-f66c-4610-b7e2-47a3a8f3ce7f .ag-row[role='row']@ROWINDEX [col-id='cCodCompanySubsidiary']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanySubsidiary { get; set; } 
                     
    }
 
        public partial class CompanySubsidiarysSupplierCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanySubsidiarysSupplierGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanySubsidiarysSupplierGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanySubsidiarysSupplierGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanySubsidiary = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#26c5b1a9-40a7-4939-a678-177b0b486010 .ag-row[role='row']@ROWINDEX [col-id='cCodCompanySubsidiary']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanySubsidiary { get; set; } 
                     
    }
 
        public partial class CompanyPurchaseRelationssCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanyPurchaseRelationssGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanyPurchaseRelationssGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanyPurchaseRelationssGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanyPurchase = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#2976e25a-e947-4f03-b911-fe4a35caf958 .ag-row[role='row']@ROWINDEX [col-id='cCodCompanyPurchase']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#2976e25a-e947-4f03-b911-fe4a35caf958 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            SalesPrice = RPSControlFactory.CreateRPSGridCheckBox<CompanyView>("","#2976e25a-e947-4f03-b911-fe4a35caf958 .ag-row[role='row']@ROWINDEX [col-id='cSalesPrice']","",true, this.CurrentView);
 
            AutomaticDeliveryNote = RPSControlFactory.CreateRPSGridCheckBox<CompanyView>("","#2976e25a-e947-4f03-b911-fe4a35caf958 .ag-row[role='row']@ROWINDEX [col-id='cAutomaticDeliveryNote']","",true, this.CurrentView);
 
            AutomaticInvoice = RPSControlFactory.CreateRPSGridCheckBox<CompanyView>("","#2976e25a-e947-4f03-b911-fe4a35caf958 .ag-row[role='row']@ROWINDEX [col-id='cAutomaticInvoice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanyPurchase { get; set; } 
        public IRPSGridComboBox<CompanyView> IDSupplier { get; set; } 
        public IRPSGridCheckbox<CompanyView> SalesPrice { get; set; } 
        public IRPSGridCheckbox<CompanyView> AutomaticDeliveryNote { get; set; } 
        public IRPSGridCheckbox<CompanyView> AutomaticInvoice { get; set; } 
                     
    }
 
        public partial class CompanySubsidiarysCustomerCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanySubsidiarysCustomerGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanySubsidiarysCustomerGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanySubsidiarysCustomerGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanySubsidiary = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#ec83e833-c22c-4d73-add3-c99e611779e9 .ag-row[role='row']@ROWINDEX [col-id='cCodCompanySubsidiary']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanySubsidiary { get; set; } 
                     
    }
 
        public partial class CompanySalesRelationssCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanySalesRelationssGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanySalesRelationssGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanySalesRelationssGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanySales = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#b83a234a-0219-499b-9f74-e066c848a797 .ag-row[role='row']@ROWINDEX [col-id='cCodCompanySales']","",true, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#b83a234a-0219-499b-9f74-e066c848a797 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanySales { get; set; } 
        public IRPSGridComboBox<CompanyView> IDCustomer { get; set; } 
                     
    }
 
        public partial class CompanyVisibilityRelationsCollectionEditor<CompanyView>:RPSCollectionEditor<CompanyView> where CompanyView : class, IView
    {
        public  CompanyVisibilityRelationsGridView<CompanyView> GridView {get;set;}
    }
    public partial class CompanyVisibilityRelationsGridView <CompanyView> :  RPSGridView<CompanyView> where CompanyView : class, IView
    {
        public CompanyVisibilityRelationsGridView(CompanyView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanyVisibility = RPSControlFactory.CreateRPSGridComboBox<CompanyView>("","#08990acd-20bf-43a4-a8ef-e012f1137c9a .ag-row[role='row']@ROWINDEX [col-id='cCodCompanyVisibility']","",true, this.CurrentView);
 
            Ticket = RPSControlFactory.CreateRPSGridCheckBox<CompanyView>("","#08990acd-20bf-43a4-a8ef-e012f1137c9a .ag-row[role='row']@ROWINDEX [col-id='cTicket']","",true, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridCheckBox<CompanyView>("","#08990acd-20bf-43a4-a8ef-e012f1137c9a .ag-row[role='row']@ROWINDEX [col-id='cStock']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyView> CodCompanyVisibility { get; set; } 
        public IRPSGridCheckbox<CompanyView> Ticket { get; set; } 
        public IRPSGridCheckbox<CompanyView> Stock { get; set; } 
                     
    }
 
    }
  
            
    public partial class SiteView : View
    {
        public SiteView(CompanyOrganization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SiteView>( this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SiteView>("17244109-aa30-43d9-83d8-8e560c9b9006","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SiteView>("a2efeb65-5028-469f-bee4-67f86aa9946b","","",false, this);
 
            IDWarehouseQuality = RPSControlFactory.CreateRPSComboBox<SiteView>("569a09ef-e198-44b2-bb5b-d73272fe59cb","","",false, this);
 
            CollectionInit params_SitePurchaseRelationss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30347a6b-8a69-4673-8684-c0828d764405",CSSSelectorGrid="",XPathGrid=""};
            SitePurchaseRelationss = RPSControlFactory.RPSCreateCollectionWithGrid<SitePurchaseRelationssCollectionEditor<SiteView>,SiteView>( params_SitePurchaseRelationss,this);
 
            CollectionInit params_SiteSalesRelationss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d9d3f18-633e-487e-86a3-99ba434335ed",CSSSelectorGrid="",XPathGrid=""};
            SiteSalesRelationss = RPSControlFactory.RPSCreateCollectionWithGrid<SiteSalesRelationssCollectionEditor<SiteView>,SiteView>( params_SiteSalesRelationss,this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<SiteView>( "","ul li[rpsid='336f2301-aed6-4763-a512-ff9ab2204ffe']","",this);
 
            SectionCompras = RPSControlFactory.CreateRPSSection<SiteView>( "","ul li[rpsid='a8b7d45c-0507-4084-b5da-ed24a8d11070']","",this);
 
            SectionVentas = RPSControlFactory.CreateRPSSection<SiteView>( "","ul li[rpsid='fa7c90b8-46b1-479d-b90c-ce57162ec34c']","",this);
 

        }
        public IRPSSaveButton<SiteView> SaveButton { get; set; } 
        public IRPSTextBox<SiteView> Description { get; set; } 
        public IRPSComboBox<SiteView> IDWarehouse { get; set; } 
        public IRPSComboBox<SiteView> IDWarehouseQuality { get; set; } 
        public SitePurchaseRelationssCollectionEditor<SiteView> SitePurchaseRelationss { get; set; } 
        public SiteSalesRelationssCollectionEditor<SiteView> SiteSalesRelationss { get; set; } 
        public IRPSSection<SiteView> SectionGeneral { get; set; } 
        public IRPSSection<SiteView> SectionCompras { get; set; } 
        public IRPSSection<SiteView> SectionVentas { get; set; } 
        public CompanyOrganization Screen { get; set; }
        public SiteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SitePurchaseRelationssCollectionEditor<SiteView>:RPSCollectionEditor<SiteView> where SiteView : class, IView
    {
        public  SitePurchaseRelationssGridView<SiteView> GridView {get;set;}
    }
    public partial class SitePurchaseRelationssGridView <SiteView> :  RPSGridView<SiteView> where SiteView : class, IView
    {
        public SitePurchaseRelationssGridView(SiteView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSitePurchase = RPSControlFactory.CreateRPSGridComboBox<SiteView>("","#30347a6b-8a69-4673-8684-c0828d764405 .ag-row[role='row']@ROWINDEX [col-id='cIDSitePurchase']","",false, this.CurrentView);
 
            Supplier = RPSControlFactory.CreateRPSGridComboBox<SiteView>("","#30347a6b-8a69-4673-8684-c0828d764405 .ag-row[role='row']@ROWINDEX [col-id='cSupplier']","",true, this.CurrentView);
 
            SalesPrice = RPSControlFactory.CreateRPSGridCheckBox<SiteView>("","#30347a6b-8a69-4673-8684-c0828d764405 .ag-row[role='row']@ROWINDEX [col-id='cSalesPrice']","",true, this.CurrentView);
 
            AutomaticDeliveryNote = RPSControlFactory.CreateRPSGridCheckBox<SiteView>("","#30347a6b-8a69-4673-8684-c0828d764405 .ag-row[role='row']@ROWINDEX [col-id='cAutomaticDeliveryNote']","",true, this.CurrentView);
 
            AutomaticInvoice = RPSControlFactory.CreateRPSGridCheckBox<SiteView>("","#30347a6b-8a69-4673-8684-c0828d764405 .ag-row[role='row']@ROWINDEX [col-id='cAutomaticInvoice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SiteView> IDSitePurchase { get; set; } 
        public IRPSGridComboBox<SiteView> Supplier { get; set; } 
        public IRPSGridCheckbox<SiteView> SalesPrice { get; set; } 
        public IRPSGridCheckbox<SiteView> AutomaticDeliveryNote { get; set; } 
        public IRPSGridCheckbox<SiteView> AutomaticInvoice { get; set; } 
                     
    }
 
        public partial class SiteSalesRelationssCollectionEditor<SiteView>:RPSCollectionEditor<SiteView> where SiteView : class, IView
    {
        public  SiteSalesRelationssGridView<SiteView> GridView {get;set;}
    }
    public partial class SiteSalesRelationssGridView <SiteView> :  RPSGridView<SiteView> where SiteView : class, IView
    {
        public SiteSalesRelationssGridView(SiteView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSiteSales = RPSControlFactory.CreateRPSGridComboBox<SiteView>("","#7d9d3f18-633e-487e-86a3-99ba434335ed .ag-row[role='row']@ROWINDEX [col-id='cIDSiteSales']","",false, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<SiteView>("","#7d9d3f18-633e-487e-86a3-99ba434335ed .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SiteView> IDSiteSales { get; set; } 
        public IRPSGridComboBox<SiteView> IDCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class WareHouseView : View
    {
        public WareHouseView(CompanyOrganization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WareHouseView>( this);
 
            CodWarehouse = RPSControlFactory.CreateRPSTextBox<WareHouseView>("914546c4-9669-4dee-a7ec-02d04e49a75b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WareHouseView>("f7e21bc1-f0b9-424e-8b6b-494b6d47e561","","",false, this);
 
            StockNegative = RPSControlFactory.CreateRPSCheckBox<WareHouseView>("8d5d3f13-6590-4ade-9ac5-ae01752921c9","","",true, this);
 
            Available = RPSControlFactory.CreateRPSCheckBox<WareHouseView>("1e299a1f-72ad-43cf-ad60-ec17adbeebc5","","",true, this);
 
            AvailableMRP = RPSControlFactory.CreateRPSCheckBox<WareHouseView>("82fcfa2d-7041-4b00-91b8-685163d28576","","",true, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<WareHouseView>("4ad3498f-13e2-464b-9d57-f66210a1e7b2","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<WareHouseView>("978ff6d7-af6b-4191-b1ae-3a7c14a14640","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<WareHouseView>("c9f4fc0e-9cca-4267-b1ca-deb366d0b6fb","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<WareHouseView>("66a1319c-8057-4342-a8c8-886ac0ac4489","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<WareHouseView>("5118ddb6-363b-4cfb-bda3-9eac555b021f","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<WareHouseView>("28cfe75b-7da1-4fe9-ae6e-e03dd36e7a8b","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<WareHouseView>("00563404-be12-4676-b5ec-f3db0169c4ac","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<WareHouseView>("92202aaf-f80d-4518-8f5c-078de4571b09","","",false, this);
 
            SectionInformacion = RPSControlFactory.CreateRPSSection<WareHouseView>( "","ul li[rpsid='2e5f0bfa-7dc3-4056-a84f-466f73e3dd2d']","",this);
 

        }
        public IRPSSaveButton<WareHouseView> SaveButton { get; set; } 
        public IRPSTextBox<WareHouseView> CodWarehouse { get; set; } 
        public IRPSTextBox<WareHouseView> Description { get; set; } 
        public IRPSCheckbox<WareHouseView> StockNegative { get; set; } 
        public IRPSCheckbox<WareHouseView> Available { get; set; } 
        public IRPSCheckbox<WareHouseView> AvailableMRP { get; set; } 
        public IRPSTextBox<WareHouseView> ClosedDate { get; set; } 
        public IRPSComboBox<WareHouseView> IDSite { get; set; } 
        public IRPSComboBox<WareHouseView> CodCountry { get; set; } 
        public IRPSTextBox<WareHouseView> ZipCode { get; set; } 
        public IRPSComboBox<WareHouseView> IDState { get; set; } 
        public IRPSComboBox<WareHouseView> IDCounty { get; set; } 
        public IRPSTextBox<WareHouseView> Address { get; set; } 
        public IRPSTextBox<WareHouseView> City { get; set; } 
        public IRPSSection<WareHouseView> SectionInformacion { get; set; } 
        public CompanyOrganization Screen { get; set; }
        public WareHouseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
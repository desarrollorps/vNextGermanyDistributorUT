    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceComponent
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceComponent:Screen
    {
        public MaintenanceComponent():base()
        {
            this.URL = "maintenance.maintenancecomponent";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceComponentVMTreeView  = new MaintenanceComponentVMTreeView(this); 
            MaintenanceComponentVMEntityView  = new MaintenanceComponentVMEntityView(this); 
            ComponentUserView  = new ComponentUserView(this); 
            ImportComponentDialogView  = new ImportComponentDialogView(this); 
            ChangeComponentLocationDialogView  = new ChangeComponentLocationDialogView(this); 
            CuDistCreateMaintenanceStructureView  = new CuDistCreateMaintenanceStructureView(this); 
            CuDistManFeatureView  = new CuDistManFeatureView(this); 
            MaintenanceComponentVMTreeView.InitializeControls(); 
            MaintenanceComponentVMEntityView.InitializeControls(); 
            ComponentUserView.InitializeControls(); 
            ImportComponentDialogView.InitializeControls(); 
            ChangeComponentLocationDialogView.InitializeControls(); 
            CuDistCreateMaintenanceStructureView.InitializeControls(); 
            CuDistManFeatureView.InitializeControls(); 
           
        }
      
            public MaintenanceComponentVMTreeView MaintenanceComponentVMTreeView {get; set; } 
            public MaintenanceComponentVMEntityView MaintenanceComponentVMEntityView {get; set; } 
            public ComponentUserView ComponentUserView {get; set; } 
            public ImportComponentDialogView ImportComponentDialogView {get; set; } 
            public ChangeComponentLocationDialogView ChangeComponentLocationDialogView {get; set; } 
            public CuDistCreateMaintenanceStructureView CuDistCreateMaintenanceStructureView {get; set; } 
            public CuDistManFeatureView CuDistManFeatureView {get; set; } 
    }
            
    public partial class MaintenanceComponentVMTreeView : View
    {
        public MaintenanceComponentVMTreeView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ExecuteNewCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceComponentVMTreeView>( "5d5246e8-2d7e-4666-b56d-3fc97a62cbcb","","",this);
 
            FiltersCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceComponentVMTreeView>( "48fa7351-458e-4819-a64f-0b9f9780dd85","","",this);
 
            ImportComponentNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceComponentVMTreeView,ImportComponentDialogView>("9ef4aafd-344a-46ea-8c07-4c444bf85da4","","", this,Screen.ImportComponentDialogView);
 

        }
        public IRPSButton<MaintenanceComponentVMTreeView> ExecuteNewCommandButton { get; set; } 
        public IRPSButton<MaintenanceComponentVMTreeView> FiltersCommandButton { get; set; } 
        public IRPSButton<MaintenanceComponentVMTreeView,ImportComponentDialogView> ImportComponentNavigationCommandButton { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public MaintenanceComponentVMTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceComponentVMEntityView : View
    {
        public MaintenanceComponentVMEntityView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceComponentVMEntityView>( this);
 
            ComponentClass = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceComponentVMEntityView>("ca0695e9-86d8-4a3b-9ea8-39a20b41b128","","",true, this);
 
            CodElement = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("49fc3a2c-fad9-4400-80bc-c65f61479b14","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("066a4e76-50e4-4d89-a0a2-0a65d20b9045","","",false, this);
 
            IDMaintenanceComponentType = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("80a66fbd-e857-4906-9bc0-6e2222bb777e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("fe99080c-e0c4-43d0-933c-4ddc403befc8","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("9499e58d-23d6-4d42-bbaf-29cf458200c9","","",false, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("0b16bdfb-e3e5-45f2-8dd5-a719e3a33e30","","",false, this);
 
            CodUserResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("6d251a52-c6bd-4b37-aa86-383a4ccbdf8c","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("afe82cd1-fcb9-44c7-8e20-b8d2cc1e6cb0","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("3fc1f524-1c4b-46b4-bf0a-768ad093af30","","",false, this);
 
            CodUserResponsible1 = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("69c8664c-c507-4749-a355-626a2a747fd1","","",false, this);
 
            IDServicePartner = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("c8af5bc6-44b2-43be-8adf-b452862ac8c5","","",false, this);
 
            IDFinalCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("05774b13-5d2e-441b-8201-0974840d8159","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceComponentVMEntityView>("d6b5873d-c13f-4a61-bb6b-4b6cc0fd6b7f","","",true, this);
 
            ActivationDate = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("3ed648c8-eabf-44c2-8f79-41eb4863eda2","","",false, this);
 
            OutOfOrderDate = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("6713dc45-2480-4822-bd64-b3651a38075e","","",false, this);
 
            StartupDate = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("765c5d46-abd5-43d3-88a1-25c5b6e74ca2","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("aa4dc45d-7280-45d7-939e-9f0b1fe4a2cb","","",false, this);
 
            SupplierGuaranteeExpiryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("cbabe6f8-0b6b-46e2-a221-ca6869a0da38","","",false, this);
 
            Manufacturer = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("025e7f7e-147d-4f82-bc44-ecbc4ac8f44e","","",false, this);
 
            Model = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("388d81c8-33b4-4639-b2ab-f6038f587363","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("5d8e42b9-42cf-4c61-8536-74ea64b1af56","","",false, this);
 
            Patent = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("e046dc8f-ffdc-4843-81cf-dfc776310631","","",false, this);
 
            Location = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("7e17fe96-625f-4c2d-a1c5-5eb5bf569025","","",false, this);
 
            Line = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("3757270b-6e53-4d1d-98ed-34b09723ea74","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("c649550c-c109-4a0e-960e-afa54533ed5d","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("85c5bf06-4020-401b-b25f-91e284e46f34","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("53a989a4-7282-440a-bfc6-329fe165ba00","","",false, this);
 
            UIIDArticle = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("8e2c89e9-fe92-479a-8a5e-7c9b27c6e321","","",false, this);
 
            GuaranteeCode = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("6703bff7-336b-4702-8948-e1b915170da0","","",false, this);
 
            GuaranteeExpiryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("b23deddb-8c8f-461d-9d6f-5fbfa002ef31","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("1302f4fd-9081-4700-b536-4346f01d1c6c","","",false, this);
 
            CumulativeValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceComponentVMEntityView>("b31399e2-0123-42f7-aa14-4c48ebb3441d","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceComponentVMEntityView>("cfb329c3-9fdd-4750-b7a6-414ab33aa8a4","","",true, this);
 
            MaintenancePrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceComponentVMEntityView>("cb7611b0-cc11-48b1-8fc7-cb1db0504b97","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("693fa98b-d6a8-4993-838b-72f84f145a22","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("02e06de1-8247-4ceb-b1f8-2a4701ecf2d7","","",false, this);
 
            CPRElementType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceComponentVMEntityView>("ca391a71-f5e7-4a4a-b17e-dc8bf3d98f35","","",true, this);
 
            CPRElementMachine = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("02e56e4d-88ec-450b-8266-5c20592047cc","","",false, this);
 
            CPRElementMachineGroup = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("28795753-a561-4de2-a591-f485facd0a32","","",false, this);
 
            CPRElementTool = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentVMEntityView>("044a4cf8-75a8-4756-9022-163abf91478f","","",false, this);
 
            DetailedDescription = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentVMEntityView>("adc40036-d380-481f-9da3-b90c6ded8bc6","","",false, this);
 
            CuDistCreateMaintenanceStructureNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceComponentVMEntityView,CuDistCreateMaintenanceStructureView>("b90a2491-45f7-40f5-99fa-42e66d580e81","","", this,Screen.CuDistCreateMaintenanceStructureView);
 
            ChangeComponentLocationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceComponentVMEntityView,ChangeComponentLocationDialogView>("b9a32d18-79c9-4301-bbef-11637930c205","","", this,Screen.ChangeComponentLocationDialogView);
 
            CollectionInit params_ComponentUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8a67984c-752b-4f14-a2dd-2942547545cb",CSSSelectorGrid="",XPathGrid=""};
            ComponentUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ComponentUsersCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>,MaintenanceComponentVMEntityView,ComponentUserView>( params_ComponentUsers,this,Screen.ComponentUserView);
 
            CollectionInit params_ComponentStatusChangess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="27939a11-854b-4b12-96cb-b29918501746",CSSSelectorGrid="",XPathGrid=""};
            ComponentStatusChangess = RPSControlFactory.RPSCreateCollectionWithGrid<ComponentStatusChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>,MaintenanceComponentVMEntityView,ComponentUserView>( params_ComponentStatusChangess,this,Screen.ComponentUserView);
 
            CollectionInit params_ComponentLocationChangess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fc5ed31c-3728-4142-baa6-6293737c37f6",CSSSelectorGrid="",XPathGrid=""};
            ComponentLocationChangess = RPSControlFactory.RPSCreateCollectionWithGrid<ComponentLocationChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>,MaintenanceComponentVMEntityView,ComponentUserView>( params_ComponentLocationChangess,this,Screen.ComponentUserView);
 
            CollectionInit params_CuDistManFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="40d7d0a1-7fdf-40cc-8ecc-9d0b5943b92b",CSSSelectorGrid="",XPathGrid=""};
            CuDistManFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistManFeaturesCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>,MaintenanceComponentVMEntityView,ComponentUserView>( params_CuDistManFeatures,this,Screen.ComponentUserView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='7668bba1-058c-481e-a300-9392841b7dcf']","",this);
 
            DetailedDescription1 = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='146ad61c-a7ba-4046-8503-f86edb074ddc']","",this);
 
            ComponentUsers1 = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='9df0ae55-b80f-476a-894a-a1f56c02b050']","",this);
 
            StatusChanges = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='09d7add2-80b8-48b0-9aaf-1bcd6ba51e0a']","",this);
 
            LocationChanges = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='16faa092-3372-4883-ac50-a16f5b6db748']","",this);
 
            Features = RPSControlFactory.CreateRPSSection<MaintenanceComponentVMEntityView>( "","ul li[rpsid='e22b4fc3-2959-4be8-af59-25cf7946848a']","",this);
 

        }
        public IRPSSaveButton<MaintenanceComponentVMEntityView> SaveButton { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> ComponentClass { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> CodElement { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDMaintenanceComponentType { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CodUserResponsible { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CodUserResponsible1 { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDServicePartner { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDFinalCustomer { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> Status { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> ActivationDate { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> OutOfOrderDate { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> StartupDate { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> SupplierGuaranteeExpiryDate { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Manufacturer { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Model { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> SerialNumber { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Patent { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Location { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Line { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> UIIDArticle { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> GuaranteeCode { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> GuaranteeExpiryDate { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDCalendar { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> CumulativeValue { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> MaintenancePrice { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CPRElementType { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CPRElementMachine { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CPRElementMachineGroup { get; set; } 
        public IRPSComboBox<MaintenanceComponentVMEntityView> CPRElementTool { get; set; } 
        public IRPSTextBox<MaintenanceComponentVMEntityView> DetailedDescription { get; set; } 
        public IRPSButton<MaintenanceComponentVMEntityView,CuDistCreateMaintenanceStructureView> CuDistCreateMaintenanceStructureNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceComponentVMEntityView,ChangeComponentLocationDialogView> ChangeComponentLocationNavigationCommandButton { get; set; } 
        public ComponentUsersCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> ComponentUsers { get; set; } 
        public ComponentStatusChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> ComponentStatusChangess { get; set; } 
        public ComponentLocationChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> ComponentLocationChangess { get; set; } 
        public CuDistManFeaturesCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> CuDistManFeatures { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> DetailedDescription1 { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> ComponentUsers1 { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> StatusChanges { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> LocationChanges { get; set; } 
        public IRPSSection<MaintenanceComponentVMEntityView> Features { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public MaintenanceComponentVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ComponentUsersCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>:RPSCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public  ComponentUsersGridView<MaintenanceComponentVMEntityView,ComponentUserView> GridView {get;set;}
    }
    public partial class ComponentUsersGridView <MaintenanceComponentVMEntityView,ComponentUserView> :  RPSGridView<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public ComponentUsersGridView(MaintenanceComponentVMEntityView currentView,ComponentUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            Admin = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cAdmin']","",true, this.CurrentView);
 
            TicketPermission = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cTicketPermission']","",true, this.CurrentView);
 
            PlanPermission = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cPlanPermission']","",true, this.CurrentView);
 
            ContractPermission = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cContractPermission']","",true, this.CurrentView);
 
            OrderPermission = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cOrderPermission']","",true, this.CurrentView);
 
            StartupPermission = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#8a67984c-752b-4f14-a2dd-2942547545cb .ag-row[role='row']@ROWINDEX [col-id='cStartupPermission']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> CodUser { get; set; } 
        public IRPSGridCheckbox<MaintenanceComponentVMEntityView> Admin { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> TicketPermission { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> PlanPermission { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> ContractPermission { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> OrderPermission { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> StartupPermission { get; set; } 
                     
    }
 
        public partial class ComponentStatusChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>:RPSCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public  ComponentStatusChangessGridView<MaintenanceComponentVMEntityView,ComponentUserView> GridView {get;set;}
    }
    public partial class ComponentStatusChangessGridView <MaintenanceComponentVMEntityView,ComponentUserView> :  RPSGridView<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public ComponentStatusChangessGridView(MaintenanceComponentVMEntityView currentView,ComponentUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceComponentVMEntityView>("","#27939a11-854b-4b12-96cb-b29918501746 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceComponentVMEntityView>("","#27939a11-854b-4b12-96cb-b29918501746 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceComponentVMEntityView> Date { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> Status { get; set; } 
                     
    }
 
        public partial class ComponentLocationChangessCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>:RPSCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public  ComponentLocationChangessGridView<MaintenanceComponentVMEntityView,ComponentUserView> GridView {get;set;}
    }
    public partial class ComponentLocationChangessGridView <MaintenanceComponentVMEntityView,ComponentUserView> :  RPSGridView<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public ComponentLocationChangessGridView(MaintenanceComponentVMEntityView currentView,ComponentUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceComponentVMEntityView>("","#fc5ed31c-3728-4142-baa6-6293737c37f6 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            IDMaintenanceComponentParent = RPSControlFactory.CreateRPSGridComboBox<MaintenanceComponentVMEntityView>("","#fc5ed31c-3728-4142-baa6-6293737c37f6 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceComponentParent']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceComponentVMEntityView> Date { get; set; } 
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> IDMaintenanceComponentParent { get; set; } 
                     
    }
 
        public partial class CuDistManFeaturesCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView>:RPSCollectionEditor<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public  CuDistManFeaturesGridView<MaintenanceComponentVMEntityView,ComponentUserView> GridView {get;set;}
    }
    public partial class CuDistManFeaturesGridView <MaintenanceComponentVMEntityView,ComponentUserView> :  RPSGridView<MaintenanceComponentVMEntityView,ComponentUserView> where MaintenanceComponentVMEntityView : class, IView where ComponentUserView : class, IView
    {
        public CuDistManFeaturesGridView(MaintenanceComponentVMEntityView currentView,ComponentUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDManFeatureLabel = RPSControlFactory.CreateRPSGridComboBox<MaintenanceComponentVMEntityView>("","#40d7d0a1-7fdf-40cc-8ecc-9d0b5943b92b .ag-row[role='row']@ROWINDEX [col-id='cIDManFeatureLabel']","",false, this.CurrentView);
 
            UIValue = RPSControlFactory.CreateRPSGridTextBox<MaintenanceComponentVMEntityView>("","#40d7d0a1-7fdf-40cc-8ecc-9d0b5943b92b .ag-row[role='row']@ROWINDEX [col-id='cUIValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceComponentVMEntityView> IDManFeatureLabel { get; set; } 
        public IRPSGridTextBox<MaintenanceComponentVMEntityView> UIValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class ComponentUserView : View
    {
        public ComponentUserView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ComponentUserView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ComponentUserView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ComponentUserView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ComponentUserView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ComponentUserView>("4756cc46-ccaa-46a8-8c5b-c375cb4273e4","","",true, this);
 
            Admin = RPSControlFactory.CreateRPSCheckBox<ComponentUserView>("15b8dade-bfa3-4069-a801-7848008075a0","","",true, this);
 
            TicketPermission = RPSControlFactory.CreateRPSEnumComboBox<ComponentUserView>("03123eb5-52b5-42cf-bb3a-27cc527d31fd","","",true, this);
 
            PlanPermission = RPSControlFactory.CreateRPSEnumComboBox<ComponentUserView>("8be8074b-1905-4074-8c72-b7bd776bdf4c","","",true, this);
 
            ContractPermission = RPSControlFactory.CreateRPSEnumComboBox<ComponentUserView>("7d1dafc0-af53-4317-a1e7-8eb45dbf5af1","","",true, this);
 
            OrderPermission = RPSControlFactory.CreateRPSEnumComboBox<ComponentUserView>("d2334322-9f41-43f9-965c-693e68466584","","",true, this);
 
            StartupPermission = RPSControlFactory.CreateRPSEnumComboBox<ComponentUserView>("b6db480f-8ab1-4432-a9f5-e0693a22334d","","",true, this);
 

        }
        public IRPSButton<ComponentUserView> DeleteButton { get; set; } 
        public IRPSButton<ComponentUserView,MaintenanceComponentVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ComponentUserView,MaintenanceComponentVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ComponentUserView,MaintenanceComponentVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ComponentUserView> CodUser { get; set; } 
        public IRPSCheckbox<ComponentUserView> Admin { get; set; } 
        public IRPSComboBox<ComponentUserView> TicketPermission { get; set; } 
        public IRPSComboBox<ComponentUserView> PlanPermission { get; set; } 
        public IRPSComboBox<ComponentUserView> ContractPermission { get; set; } 
        public IRPSComboBox<ComponentUserView> OrderPermission { get; set; } 
        public IRPSComboBox<ComponentUserView> StartupPermission { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public ComponentUserView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportComponentDialogView : View
    {
        public ImportComponentDialogView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptArticle = RPSControlFactory.CreateRPSOption<ImportComponentDialogView>( "60a5eb6d-871d-4cfe-abf1-ccab45bb01dd","","",this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<ImportComponentDialogView>("d9003eb2-5ebc-499b-86ab-7e0cadce9e42","","",false, this);
 
            UIOptMachine = RPSControlFactory.CreateRPSOption<ImportComponentDialogView>( "ad397e59-bcef-44c3-921d-67c7e82ec18f","","",this);
 
            UILstMachine = RPSControlFactory.CreateRPSCollectionComboBox<ImportComponentDialogView>("c1d0f777-349c-4162-8efe-5f59a835d248","","",false, this);
 
            UIOptMachineGroup = RPSControlFactory.CreateRPSOption<ImportComponentDialogView>( "837ca089-ddd6-4a1b-af56-08addbe9cee1","","",this);
 
            UILstMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<ImportComponentDialogView>("e95a19bb-3a8d-49bd-948a-6593ee3bee68","","",false, this);
 
            UIOptTool = RPSControlFactory.CreateRPSOption<ImportComponentDialogView>( "f6233fa1-e7f1-4707-acc0-e2a8b10dd7e5","","",this);
 
            UILstTool = RPSControlFactory.CreateRPSCollectionComboBox<ImportComponentDialogView>("a1c3dd64-af41-45f0-879f-b3ca044cfb92","","",false, this);
 
            UIMaintenanceComponentType = RPSControlFactory.CreateRPSComboBox<ImportComponentDialogView>("042fc0ed-fdd2-4a52-8742-6c7bf754062d","","",false, this);
 

        }
        public IRPSOption<ImportComponentDialogView> UIOptArticle { get; set; } 
        public IRPSCollectionComboBox<ImportComponentDialogView> UILstArticle { get; set; } 
        public IRPSOption<ImportComponentDialogView> UIOptMachine { get; set; } 
        public IRPSCollectionComboBox<ImportComponentDialogView> UILstMachine { get; set; } 
        public IRPSOption<ImportComponentDialogView> UIOptMachineGroup { get; set; } 
        public IRPSCollectionComboBox<ImportComponentDialogView> UILstMachineGroup { get; set; } 
        public IRPSOption<ImportComponentDialogView> UIOptTool { get; set; } 
        public IRPSCollectionComboBox<ImportComponentDialogView> UILstTool { get; set; } 
        public IRPSComboBox<ImportComponentDialogView> UIMaintenanceComponentType { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public ImportComponentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeComponentLocationDialogView : View
    {
        public ChangeComponentLocationDialogView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaintenanceComponentParent = RPSControlFactory.CreateRPSComboBox<ChangeComponentLocationDialogView>("9b3f52b4-3565-461a-b73b-bd06e489bb76","","",true, this);
 

        }
        public IRPSComboBox<ChangeComponentLocationDialogView> IDMaintenanceComponentParent { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public ChangeComponentLocationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistCreateMaintenanceStructureView : View
    {
        public CuDistCreateMaintenanceStructureView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<CuDistCreateMaintenanceStructureView>("6e06a6cb-48e6-4f4b-b94a-a6607cd5ce34","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<CuDistCreateMaintenanceStructureView>("dd2e09b5-cb95-4414-93c8-0fa8207af651","","",false, this);
 
            ExecuteSearchTree = RPSControlFactory.CreateRPSButton<CuDistCreateMaintenanceStructureView>( "ecf6a0c2-db02-4620-855c-7f05eb9fabd4","","",this);
 
            cmdAccept = RPSControlFactory.CreateRPSButton<CuDistCreateMaintenanceStructureView>( "63d0ad32-1066-4431-b0a8-4bd04236400b","","",this);
 
            cmdCancel = RPSControlFactory.CreateRPSButton<CuDistCreateMaintenanceStructureView>( "9aa79fac-ee99-41c6-b31d-fa4f7c724e1e","","",this);
 

        }
        public IRPSComboBox<CuDistCreateMaintenanceStructureView> IDProject { get; set; } 
        public IRPSComboBox<CuDistCreateMaintenanceStructureView> IDManufacturingOrder { get; set; } 
        public IRPSButton<CuDistCreateMaintenanceStructureView> ExecuteSearchTree { get; set; } 
        public IRPSButton<CuDistCreateMaintenanceStructureView> cmdAccept { get; set; } 
        public IRPSButton<CuDistCreateMaintenanceStructureView> cmdCancel { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public CuDistCreateMaintenanceStructureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistManFeatureView : View
    {
        public CuDistManFeatureView(MaintenanceComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistManFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistManFeatureView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistManFeatureView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CuDistManFeatureView,MaintenanceComponentVMEntityView>( this,Screen.MaintenanceComponentVMEntityView);
 
            IDManFeatureLabel = RPSControlFactory.CreateRPSComboBox<CuDistManFeatureView>("2f8b133a-3436-4d3c-a5ad-646f0ad47d7c","","",false, this);
 
            ValueString = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureView>("05d02723-3d74-4407-97f3-746569154e59","","",false, this);
 
            ValueInt = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureView>("c9296ce5-3b34-4dc0-86b1-8368f4e436a8","","",false, this);
 
            ValueDecimal = RPSControlFactory.CreateRPSFormattedTextBox<CuDistManFeatureView>("250b19b9-849d-4cb6-bf84-59b3f5d056a8","","",false, this);
 
            ValueDate = RPSControlFactory.CreateRPSTextBox<CuDistManFeatureView>("16f6c70e-7c7b-4f06-99e4-679189aa0a7c","","",false, this);
 
            ValueTable = RPSControlFactory.CreateRPSEnumComboBox<CuDistManFeatureView>("869c6a62-7d43-4f06-83ab-99a1821e7619","","",false, this);
 

        }
        public IRPSButton<CuDistManFeatureView> DeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureView,MaintenanceComponentVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistManFeatureView,MaintenanceComponentVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CuDistManFeatureView,MaintenanceComponentVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CuDistManFeatureView> IDManFeatureLabel { get; set; } 
        public IRPSTextBox<CuDistManFeatureView> ValueString { get; set; } 
        public IRPSTextBox<CuDistManFeatureView> ValueInt { get; set; } 
        public IRPSTextBox<CuDistManFeatureView> ValueDecimal { get; set; } 
        public IRPSTextBox<CuDistManFeatureView> ValueDate { get; set; } 
        public IRPSComboBox<CuDistManFeatureView> ValueTable { get; set; } 
        public MaintenanceComponent Screen { get; set; }
        public CuDistManFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
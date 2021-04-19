    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "manufacturing.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierDetailView SupplierDetailView {get; set; } 
    }
            
    public partial class SupplierCollectionView : View
    {
        public SupplierCollectionView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierCollectionView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "68aa53eb-4fa3-491d-b5c7-ca8a7382538c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierCollectionView,SupplierEntityView>( params_MainConsult,this,Screen.SupplierEntityView);
 

        }
        public IRPSButton<SupplierCollectionView,SupplierEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierCollectionView,SupplierEntityView> MainConsult { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEntityView : View
    {
        public SupplierEntityView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("758b2537-a0c8-4bd8-ae3e-3f597da5d3eb","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("e41f3463-e63c-40b4-b951-4b7a18170b65","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("a5015ea3-c237-4aac-b7ab-d3cbff5a4a90","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("4f4392a5-1b30-419a-9916-081ecbd9e966","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("bac5598e-857a-4cad-a860-f5434ac227a4","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("a35fc308-efe9-46ef-b5bf-3fe17c2e3d85","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("5bc16eab-779f-44d9-b8ff-f82cc8b248fd","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("6ca00a9a-28a2-4e86-b122-5fa7edfe3c62","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("bd6e18c7-52fc-46f7-b5ad-eb492995c496","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("619edf4a-155f-4151-8297-7ae4549e3852","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d04bfdca-5470-44c0-bb93-bc1de74481cf","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("16c8ded8-e52d-410c-9b01-861b3ba29d70","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("5ff5c065-1df1-4f66-a991-79612302b54d","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("73f1a541-ae6f-4dcc-844f-599270d08e5c","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("688a15b2-efc5-49ef-bbe3-62d9480dc220","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("686072de-b94a-444f-9a49-c8817b58133c","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("23564372-cf7f-4875-b59a-0a4393ae75f0","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("d3b4eec4-289c-4003-8829-db449f2a8cb7","","",false, this);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a64e147-e100-4fcc-a29f-c93f046dbc3c",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierDetails,this,Screen.SupplierDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='ad521e7b-311c-4e2c-9307-d67221e7cbe8']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='3d50e148-90e9-47b7-83aa-45237e73cb88']","",this);
 

        }
        public IRPSSaveButton<SupplierEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierEntityView> CodSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierEntityView> CompanyName { get; set; } 
        public IRPSTextBox<SupplierEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdType { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierEntityView> City { get; set; } 
        public IRPSTextBox<SupplierEntityView> Position { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierEntityView> SubsidiaryCompanies { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierDetailsGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierDetailsGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierDetailsGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#3a64e147-e100-4fcc-a29f-c93f046dbc3c .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierDetailView : View
    {
        public SupplierDetailView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("1e358650-b529-4105-ac67-35f9d491d4c9","","",true, this);
 

        }
        public IRPSButton<SupplierDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierDetailView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierDetailView> CodCompany { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
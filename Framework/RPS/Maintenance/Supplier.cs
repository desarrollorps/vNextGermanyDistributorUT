    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "maintenance.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierContactView  = new SupplierContactView(this); 
            SupplierEmployeeView  = new SupplierEmployeeView(this); 
            SupplierAccreditationView  = new SupplierAccreditationView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierContactView.InitializeControls(); 
            SupplierEmployeeView.InitializeControls(); 
            SupplierAccreditationView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierContactView SupplierContactView {get; set; } 
            public SupplierEmployeeView SupplierEmployeeView {get; set; } 
            public SupplierAccreditationView SupplierAccreditationView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4df9edf8-0dda-4d39-acb5-aba7b3574bd9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("25ee2289-e059-4824-a043-781f01c96703","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("13162adf-d63b-4fa2-9055-758beeaf40bd","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f8ae2d48-0563-496c-a59b-f5e042d27862","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("7560b36f-ea31-4f08-8748-ab155c2e0884","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("4be6caea-c2bd-4d53-aee7-d7a19785c770","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("dc6832b1-205a-4cdc-b0ba-7572c7ba0baf","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("290c73e5-7ced-47fd-9e2f-66d6c9dde6ce","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("caac87f8-94a6-454e-8b98-959c9a398675","","",true, this);
 
            RGSA = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("76986c72-8a3a-418b-9d2e-bbf31f9c26a5","","",false, this);
 
            ROESP = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("32a96bb5-25ae-4391-bd14-e003c1fc7256","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("d09b41aa-6cbb-41c3-9972-12588728ffe3","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f410c183-a332-40f9-8bc9-37001ab42836","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("62e9764a-d9a7-4611-9184-9c39117e988f","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("65388e44-52ff-402d-909d-829d877760e3","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("ff67c33c-ba8b-4752-81aa-5aa4ece8a33f","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("7dfee44e-5f40-4300-a4e3-8ddf9c04db76","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("947a4dad-5a0d-4fbf-a72e-a946e1076729","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("de846e66-e00f-427b-9a6d-7bb859bdd0c7","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("e738c7da-7947-4adf-9aed-07f47bd05c90","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("24935986-3edc-47bb-9239-789d999cb4be","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("076d8777-cd75-4ea2-859f-7706a8287fa8","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("885e2b1e-5229-4acf-87bc-cb83efd42c2c","","",false, this);
 
            CollectionInit params_SupplierContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="675084a5-85d5-4ae0-b645-e6a670f21508",CSSSelectorGrid="",XPathGrid=""};
            SupplierContacts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierContacts,this,Screen.SupplierDetailView);
 
            CollectionInit params_SupplierEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="12c13770-7671-486b-b3bc-3cea5a4d4893",CSSSelectorGrid="",XPathGrid=""};
            SupplierEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierEmployees,this,Screen.SupplierDetailView);
 
            CollectionInit params_SupplierAccreditations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="df652d74-0b18-4316-b456-978c2792716d",CSSSelectorGrid="",XPathGrid=""};
            SupplierAccreditations = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierAccreditations,this,Screen.SupplierDetailView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3374fbf4-b5b9-4011-ada9-b94ecff54d3f",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierDetails,this,Screen.SupplierDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='f904248b-2a14-47b2-9016-bc7f7eb04be3']","",this);
 
            Contacts = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='3810de0a-460f-429d-a428-1631cff5dc86']","",this);
 
            Employee = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='6e16fa80-8319-4cf9-8cd3-00386425abc7']","",this);
 
            Accreditations = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='3cd39a0e-214f-498a-a891-33970a94be78']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='10cb5580-24e7-476f-b836-39cc6724be40']","",this);
 

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
        public IRPSTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<SupplierEntityView> RGSA { get; set; } 
        public IRPSTextBox<SupplierEntityView> ROESP { get; set; } 
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
        public SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierContacts { get; set; } 
        public SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierEmployees { get; set; } 
        public SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierAccreditations { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierEntityView> Contacts { get; set; } 
        public IRPSSection<SupplierEntityView> Employee { get; set; } 
        public IRPSSection<SupplierEntityView> Accreditations { get; set; } 
        public IRPSSection<SupplierEntityView> SubsidiaryCompanies { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierContactsCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierContactsGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierContactsGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierContactsGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Phone2 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cPhone2']","",false, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#675084a5-85d5-4ae0-b645-e6a670f21508 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierEmployeesGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierEmployeesGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierEmployeesGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#12c13770-7671-486b-b3bc-3cea5a4d4893 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDEmployee { get; set; } 
                     
    }
 
        public partial class SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierDetailView>:RPSCollectionEditor<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public  SupplierAccreditationsGridView<SupplierEntityView,SupplierDetailView> GridView {get;set;}
    }
    public partial class SupplierAccreditationsGridView <SupplierEntityView,SupplierDetailView> :  RPSGridView<SupplierEntityView,SupplierDetailView> where SupplierEntityView : class, IView where SupplierDetailView : class, IView
    {
        public SupplierAccreditationsGridView(SupplierEntityView currentView,SupplierDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccreditation = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#df652d74-0b18-4316-b456-978c2792716d .ag-row[role='row']@ROWINDEX [col-id='cIDAccreditation']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDAccreditation { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#3374fbf4-b5b9-4011-ada9-b94ecff54d3f .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#3374fbf4-b5b9-4011-ada9-b94ecff54d3f .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierContactView : View
    {
        public SupplierContactView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("d6c25d11-1f93-4506-83de-9cba2a3faba6","","",false, this);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("472b6ba9-9b97-40f8-84c6-e609411b559c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("99664a58-a371-4d2e-a5e4-7e7503932a42","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("42cb7e44-0f47-47b3-ab59-c38864e3fc4d","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("ed8d8e4b-c4b5-43a7-adae-6b13205bb728","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("9fa38caa-247b-4404-ba9c-061c0940e513","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("5e46caac-d990-4eae-9e08-cc4f2137eecf","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierContactView>("81ae442d-b8d7-43f5-b125-51b8004b6632","","",false, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("7bbd8809-6c90-4f5d-908c-03c395891921","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("565a9aba-834c-4bed-a348-f43910206c52","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("8f0955c6-fd95-4658-898c-6605ad2258d3","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("8213b828-b6f7-4398-b3e4-c315a75a5637","","",false, this);
 
            GenerateData = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='53c26e39-20a6-4480-af02-6b7b9d658d81']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='80a7ce65-cf01-4817-a698-473f468caaf8']","",this);
 

        }
        public IRPSButton<SupplierContactView> DeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierContactView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate { get; set; } 
        public IRPSComboBox<SupplierContactView> IDContactType { get; set; } 
        public IRPSTextBox<SupplierContactView> Description { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierContactView> Fax { get; set; } 
        public IRPSComboBox<SupplierContactView> CodUser { get; set; } 
        public IRPSTextBox<SupplierContactView> Email { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultFinancial { get; set; } 
        public IRPSTextBox<SupplierContactView> Comment { get; set; } 
        public IRPSSection<SupplierContactView> GenerateData { get; set; } 
        public IRPSSection<SupplierContactView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEmployeeView : View
    {
        public SupplierEmployeeView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SupplierEmployeeView>("26862a62-29e0-40db-a544-1ccc5711cdfa","","",true, this);
 

        }
        public IRPSButton<SupplierEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEmployeeView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEmployeeView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierEmployeeView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierEmployeeView> IDEmployee { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierAccreditationView : View
    {
        public SupplierAccreditationView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierAccreditationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDAccreditation = RPSControlFactory.CreateRPSComboBox<SupplierAccreditationView>("3ae38955-eb38-4ef2-a0f1-328d08b5f6c4","","",true, this);
 

        }
        public IRPSButton<SupplierAccreditationView> DeleteButton { get; set; } 
        public IRPSButton<SupplierAccreditationView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierAccreditationView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierAccreditationView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierAccreditationView> IDAccreditation { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierAccreditationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("9bc777a8-369b-4391-b6d4-f0f8b2475236","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("c12bfcce-a96a-41e9-a2b9-e4c82e979789","","",true, this);
 

        }
        public IRPSButton<SupplierDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierDetailView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierDetailView> CodCompany { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCurrency { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
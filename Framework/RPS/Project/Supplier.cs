    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "project.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierEmployeeView  = new SupplierEmployeeView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierEmployeeView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierEmployeeView SupplierEmployeeView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "122af525-f223-451d-a75f-877881c9cfd4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("caae8332-0e45-4fd4-89d7-98a1f475bd0f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("88185879-0f0c-4a98-9988-639b995df550","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("1b15149b-b87f-437d-8db9-245ca64462c0","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("b9be2cbd-01ca-4eb4-ba8e-19d1c84d79a5","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("10b91fe7-b08b-4e9d-9026-4792870c831b","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("b9227edd-f967-462e-b101-2de9e31f82d9","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("420ffa0f-ee91-4520-bb9c-6437c27a6c31","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("d0cc3aaf-f37a-4e07-85bc-1b6f61b2262a","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("29e57918-dbc1-4119-ab85-32f617f73798","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f10dfbec-217d-4b93-aba3-f21e52373ae1","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c6bad60d-bbb2-4dd2-b701-e7a5ea4d3cd3","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f92412d0-17cf-4a24-ba8f-ae87c96c25fc","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("783e75fd-443e-4fa4-88dd-4aafe00a51d6","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("2d1ba969-a2d6-4ea0-b84d-5418955e38d4","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("2d5601ef-bfd6-42b0-9705-a2770ae2e948","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("05543eeb-4bd3-4093-a897-b7771c102c9d","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("955b025a-2a3b-4247-87dc-8ad4908f726f","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("e074e5df-9e72-4dc3-8360-ef29ea43ffa6","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("b0e7f983-3617-4926-bc39-62b81d1aad97","","",false, this);
 
            CollectionInit params_SupplierEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="46a80181-709b-4225-b1b1-e1f29afc3459",CSSSelectorGrid="",XPathGrid=""};
            SupplierEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierEmployees,this,Screen.SupplierDetailView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2a27105-5df4-4eff-89da-5d60452e779f",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView>,SupplierEntityView,SupplierDetailView>( params_SupplierDetails,this,Screen.SupplierDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='9ad643ae-315e-4ff0-8f95-6df8b2dd59fb']","",this);
 
            Employee = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='af5f7803-7727-412c-b924-4ef0e462c149']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='61ad128b-f3db-4ab2-b248-2ea65641d07d']","",this);
 

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
        public SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierEmployees { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierDetailView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierEntityView> Employee { get; set; } 
        public IRPSSection<SupplierEntityView> SubsidiaryCompanies { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
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
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#46a80181-709b-4225-b1b1-e1f29afc3459 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDEmployee { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#a2a27105-5df4-4eff-89da-5d60452e779f .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
                     
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
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SupplierEmployeeView>("be6de8d6-cb2c-453a-aa81-4366246fa0a7","","",true, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("eb8b1c0b-f331-41f3-9f74-d29c249cb5e5","","",true, this);
 

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
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceType:Screen
    {
        public MaintenanceType():base()
        {
            this.URL = "maintenance.maintenancetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceTypeCollectionView  = new MaintenanceTypeCollectionView(this); 
            MaintenanceTypeEntityView  = new MaintenanceTypeEntityView(this); 
            MaintenanceIntermediateStatusView  = new MaintenanceIntermediateStatusView(this); 
            MaintenanceTypeProductView  = new MaintenanceTypeProductView(this); 
            MaintenanceTypeQualifyView  = new MaintenanceTypeQualifyView(this); 
            MaintenanceTypeAccreditationView  = new MaintenanceTypeAccreditationView(this); 
            MaintenanceTypeCollectionView.InitializeControls(); 
            MaintenanceTypeEntityView.InitializeControls(); 
            MaintenanceIntermediateStatusView.InitializeControls(); 
            MaintenanceTypeProductView.InitializeControls(); 
            MaintenanceTypeQualifyView.InitializeControls(); 
            MaintenanceTypeAccreditationView.InitializeControls(); 
           
        }
      
            public MaintenanceTypeCollectionView MaintenanceTypeCollectionView {get; set; } 
            public MaintenanceTypeEntityView MaintenanceTypeEntityView {get; set; } 
            public MaintenanceIntermediateStatusView MaintenanceIntermediateStatusView {get; set; } 
            public MaintenanceTypeProductView MaintenanceTypeProductView {get; set; } 
            public MaintenanceTypeQualifyView MaintenanceTypeQualifyView {get; set; } 
            public MaintenanceTypeAccreditationView MaintenanceTypeAccreditationView {get; set; } 
    }
            
    public partial class MaintenanceTypeCollectionView : View
    {
        public MaintenanceTypeCollectionView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceTypeCollectionView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a13ee740-ce69-40a1-b6d5-d46548c25751",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceTypeCollectionView,MaintenanceTypeEntityView>( params_MainConsult,this,Screen.MaintenanceTypeEntityView);
 

        }
        public IRPSButton<MaintenanceTypeCollectionView,MaintenanceTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceTypeCollectionView,MaintenanceTypeEntityView> MainConsult { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceTypeEntityView : View
    {
        public MaintenanceTypeEntityView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceTypeEntityView,MaintenanceTypeCollectionView>( this,Screen.MaintenanceTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceTypeEntityView,MaintenanceTypeCollectionView>( this,Screen.MaintenanceTypeCollectionView);
 
            CodMaintenanceType = RPSControlFactory.CreateRPSTextBox<MaintenanceTypeEntityView>("8e3c8a3c-0909-4d89-a52b-1b7969243fd2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceTypeEntityView>("551890c8-a467-498e-b6d4-4df78f349869","","",false, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<MaintenanceTypeEntityView>( "08b78782-d4d3-4c64-9740-5792eb453c3b","","",this);
 
            Predictive = RPSControlFactory.CreateRPSCheckBox<MaintenanceTypeEntityView>("4f22504a-673e-47c1-b52a-fdbcc050a8f9","","",true, this);
 
            Programmed = RPSControlFactory.CreateRPSCheckBox<MaintenanceTypeEntityView>("175f0a3f-3263-4516-b087-66b7fe0c5769","","",true, this);
 
            IDMaintenanceOrderStatusInitial = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("38f7730b-1cca-4e88-b543-33fe8412de4b","","",true, this);
 
            IDMaintenanceOrderStatusFinal = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("274fcc2f-8a39-401b-a813-05ba1a9958c1","","",true, this);
 
            IDIntAccMaintEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("c73f03e9-e66d-4d34-8cbe-f958ce3e03d7","","",false, this);
 
            IDIntAccMaintMachine = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("625f4154-e359-4b82-bf53-4c6a45027fd1","","",false, this);
 
            IDIntAccMaintExpEmpl = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("add279e0-82d2-4e8d-b837-a2181d9b353e","","",false, this);
 
            IDIntAccMaintCost = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("1d41d65c-f3fc-478c-ad04-b9d98d02becf","","",false, this);
 
            IDIntAccMaintService = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("5a25de60-db39-4c6b-a910-f9ba59738936","","",false, this);
 
            IDIntAccMaintMatWithoutMov = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("856f87f8-2c51-4a7c-90e6-70ff3104d3ce","","",false, this);
 
            IDIntAccMaintClosed = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeEntityView>("1b74be14-dfab-4801-ac9c-c793645018ad","","",false, this);
 
            CollectionInit params_MaintenanceIntermediateStatuss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30278119-e775-4b0d-902c-b99ae4c058bc",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceIntermediateStatuss = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceIntermediateStatussCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>,MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>( params_MaintenanceIntermediateStatuss,this,Screen.MaintenanceIntermediateStatusView);
 
            CollectionInit params_MaintenanceTypeFamilies = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ad70a57-8211-4e18-9478-2c6362f2c171",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceTypeFamilies = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceTypeFamiliesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>,MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>( params_MaintenanceTypeFamilies,this,Screen.MaintenanceIntermediateStatusView);
 
            CollectionInit params_MaintenanceTypeQualifies = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a306e756-b630-4d2b-820c-c9cce1ebd8c2",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceTypeQualifies = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceTypeQualifiesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>,MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>( params_MaintenanceTypeQualifies,this,Screen.MaintenanceIntermediateStatusView);
 
            CollectionInit params_MaintenanceTypeAccreditations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ed190401-16bb-4da0-b0aa-0d6e3bf7d261",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceTypeAccreditations = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceTypeAccreditationsCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>,MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>( params_MaintenanceTypeAccreditations,this,Screen.MaintenanceIntermediateStatusView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceTypeEntityView>( "","ul li[rpsid='b1be6ccc-8968-4ff1-a6c2-890af8c42a6c']","",this);
 
            Products = RPSControlFactory.CreateRPSSection<MaintenanceTypeEntityView>( "","ul li[rpsid='619994c4-fb0f-4cd7-b778-b28b4163e9e4']","",this);
 
            Qualifications = RPSControlFactory.CreateRPSSection<MaintenanceTypeEntityView>( "","ul li[rpsid='80935002-3803-4476-8f8c-da1afefa4784']","",this);
 
            Accreditations = RPSControlFactory.CreateRPSSection<MaintenanceTypeEntityView>( "","ul li[rpsid='32b75f33-4f9f-41b9-a961-c22f124aee1e']","",this);
 
            Integration = RPSControlFactory.CreateRPSSection<MaintenanceTypeEntityView>( "","ul li[rpsid='7e4b8dbb-498b-4a36-a7bd-98886577dd83']","",this);
 

        }
        public IRPSSaveButton<MaintenanceTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeEntityView,MaintenanceTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeEntityView,MaintenanceTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceTypeEntityView> CodMaintenanceType { get; set; } 
        public IRPSTextBox<MaintenanceTypeEntityView> Description { get; set; } 
        public IRPSColorEditor<MaintenanceTypeEntityView> Color { get; set; } 
        public IRPSCheckbox<MaintenanceTypeEntityView> Predictive { get; set; } 
        public IRPSCheckbox<MaintenanceTypeEntityView> Programmed { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDMaintenanceOrderStatusInitial { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDMaintenanceOrderStatusFinal { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintEmployee { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintMachine { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintExpEmpl { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintCost { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintService { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintMatWithoutMov { get; set; } 
        public IRPSComboBox<MaintenanceTypeEntityView> IDIntAccMaintClosed { get; set; } 
        public MaintenanceIntermediateStatussCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> MaintenanceIntermediateStatuss { get; set; } 
        public MaintenanceTypeFamiliesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> MaintenanceTypeFamilies { get; set; } 
        public MaintenanceTypeQualifiesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> MaintenanceTypeQualifies { get; set; } 
        public MaintenanceTypeAccreditationsCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> MaintenanceTypeAccreditations { get; set; } 
        public IRPSSection<MaintenanceTypeEntityView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceTypeEntityView> Products { get; set; } 
        public IRPSSection<MaintenanceTypeEntityView> Qualifications { get; set; } 
        public IRPSSection<MaintenanceTypeEntityView> Accreditations { get; set; } 
        public IRPSSection<MaintenanceTypeEntityView> Integration { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceIntermediateStatussCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>:RPSCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public  MaintenanceIntermediateStatussGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> GridView {get;set;}
    }
    public partial class MaintenanceIntermediateStatussGridView <MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> :  RPSGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public MaintenanceIntermediateStatussGridView(MaintenanceTypeEntityView currentView,MaintenanceIntermediateStatusView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceOrderStatus = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#30278119-e775-4b0d-902c-b99ae4c058bc .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceOrderStatus']","",true, this.CurrentView);
 
            ImputationStatus = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceTypeEntityView>("","#30278119-e775-4b0d-902c-b99ae4c058bc .ag-row[role='row']@ROWINDEX [col-id='cImputationStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDMaintenanceOrderStatus { get; set; } 
        public IRPSGridCheckbox<MaintenanceTypeEntityView> ImputationStatus { get; set; } 
                     
    }
 
        public partial class MaintenanceTypeFamiliesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>:RPSCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public  MaintenanceTypeFamiliesGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> GridView {get;set;}
    }
    public partial class MaintenanceTypeFamiliesGridView <MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> :  RPSGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public MaintenanceTypeFamiliesGridView(MaintenanceTypeEntityView currentView,MaintenanceIntermediateStatusView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDProductLine = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#3ad70a57-8211-4e18-9478-2c6362f2c171 .ag-row[role='row']@ROWINDEX [col-id='cIDProductLine']","",true, this.CurrentView);
 
            IDProductFamily = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#3ad70a57-8211-4e18-9478-2c6362f2c171 .ag-row[role='row']@ROWINDEX [col-id='cIDProductFamily']","",false, this.CurrentView);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#3ad70a57-8211-4e18-9478-2c6362f2c171 .ag-row[role='row']@ROWINDEX [col-id='cIDProductSubFamily']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDProductLine { get; set; } 
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDProductFamily { get; set; } 
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDProductSubFamily { get; set; } 
                     
    }
 
        public partial class MaintenanceTypeQualifiesCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>:RPSCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public  MaintenanceTypeQualifiesGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> GridView {get;set;}
    }
    public partial class MaintenanceTypeQualifiesGridView <MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> :  RPSGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public MaintenanceTypeQualifiesGridView(MaintenanceTypeEntityView currentView,MaintenanceIntermediateStatusView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#a306e756-b630-4d2b-820c-c9cce1ebd8c2 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDQualify { get; set; } 
                     
    }
 
        public partial class MaintenanceTypeAccreditationsCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView>:RPSCollectionEditor<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public  MaintenanceTypeAccreditationsGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> GridView {get;set;}
    }
    public partial class MaintenanceTypeAccreditationsGridView <MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> :  RPSGridView<MaintenanceTypeEntityView,MaintenanceIntermediateStatusView> where MaintenanceTypeEntityView : class, IView where MaintenanceIntermediateStatusView : class, IView
    {
        public MaintenanceTypeAccreditationsGridView(MaintenanceTypeEntityView currentView,MaintenanceIntermediateStatusView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccreditation = RPSControlFactory.CreateRPSGridComboBox<MaintenanceTypeEntityView>("","#ed190401-16bb-4da0-b0aa-0d6e3bf7d261 .ag-row[role='row']@ROWINDEX [col-id='cIDAccreditation']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceTypeEntityView> IDAccreditation { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceIntermediateStatusView : View
    {
        public MaintenanceIntermediateStatusView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceIntermediateStatusView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            IDMaintenanceOrderStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceIntermediateStatusView>("7912f47e-df53-4dbd-850b-e3513f2b149e","","",true, this);
 
            ImputationStatus = RPSControlFactory.CreateRPSCheckBox<MaintenanceIntermediateStatusView>("0c4b8245-56d8-48a6-916e-d49cb7841d79","","",true, this);
 

        }
        public IRPSButton<MaintenanceIntermediateStatusView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceIntermediateStatusView,MaintenanceTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceIntermediateStatusView> IDMaintenanceOrderStatus { get; set; } 
        public IRPSCheckbox<MaintenanceIntermediateStatusView> ImputationStatus { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceIntermediateStatusView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceTypeProductView : View
    {
        public MaintenanceTypeProductView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceTypeProductView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceTypeProductView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceTypeProductView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceTypeProductView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeProductView>("209e3ea0-98d6-495f-879f-43d6fffb3bd0","","",true, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeProductView>("0180847a-24f6-4059-988a-81acca91884f","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeProductView>("d986d25a-f4b8-44a7-9c07-11d47c55942d","","",false, this);
 

        }
        public IRPSButton<MaintenanceTypeProductView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeProductView,MaintenanceTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeProductView,MaintenanceTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceTypeProductView,MaintenanceTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceTypeProductView> IDProductLine { get; set; } 
        public IRPSComboBox<MaintenanceTypeProductView> IDProductFamily { get; set; } 
        public IRPSComboBox<MaintenanceTypeProductView> IDProductSubFamily { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceTypeProductView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceTypeQualifyView : View
    {
        public MaintenanceTypeQualifyView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceTypeQualifyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeQualifyView>("9e018c76-fc84-422b-b433-b784491338c5","","",true, this);
 

        }
        public IRPSButton<MaintenanceTypeQualifyView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceTypeQualifyView,MaintenanceTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceTypeQualifyView> IDQualify { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceTypeQualifyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceTypeAccreditationView : View
    {
        public MaintenanceTypeAccreditationView(MaintenanceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceTypeAccreditationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView>( this,Screen.MaintenanceTypeEntityView);
 
            IDAccreditation = RPSControlFactory.CreateRPSComboBox<MaintenanceTypeAccreditationView>("26d85bfe-2562-4380-9668-7ccd95862299","","",true, this);
 

        }
        public IRPSButton<MaintenanceTypeAccreditationView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceTypeAccreditationView,MaintenanceTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceTypeAccreditationView> IDAccreditation { get; set; } 
        public MaintenanceType Screen { get; set; }
        public MaintenanceTypeAccreditationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
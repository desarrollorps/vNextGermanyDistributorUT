    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrderPrint
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrderPrint:Screen
    {
        public MaintenanceOrderPrint():base()
        {
            this.URL = "maintenance.maintenanceorderprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderPrintQueryView  = new MaintenanceOrderPrintQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            MaintenanceOrderPrintQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderPrintQueryView MaintenanceOrderPrintQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class MaintenanceOrderPrintQueryView : View
    {
        public MaintenanceOrderPrintQueryView(MaintenanceOrderPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MaintenanceOrderFrom = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("ac1e1b6f-f6f9-4cc4-8b96-b66c6f317334","","",false, this);
 
            MaintenanceOrderTo = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("118345a7-7fd5-4fe1-83e8-8075c782fa7c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPrintQueryView>("50070c60-851a-4e73-8c51-60679cf2e479","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPrintQueryView>("e93fa95b-4f49-469a-9d21-b8a84326b145","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "e8507ea3-fac4-44f7-9b8d-196aeca3f515","","",this);
 
            Qualify = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "38600c3e-10ed-476d-aae2-c1821b0eb033","","",this);
 
            Qualify1 = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("42ee18b6-13d4-46e4-b62a-a60bb578e3e3","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "25965f3e-6e07-4f42-a706-bd7724fe4c62","","",this);
 
            Employee1 = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("123f8d8c-f2b3-4474-82fe-e0ffbf20acc9","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "e5780e82-3cfd-4ba8-967a-d3e6d46339e1","","",this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("4bc772f3-d433-4143-a77b-397fc57cbb36","","",false, this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "3d2e3086-4697-405a-86bf-196f348b2060","","",this);
 
            Language = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintQueryView>( "e55aac39-6772-40ed-88a1-3a360d47831b","","",this);
 
            Language1 = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("f631c345-5256-4e10-8d76-03c163e4da47","","",false, this);
 
            SpecificList = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderPrintQueryView>("bcb255e9-c2ae-4f8f-8d82-6fadbe3bca13","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintQueryView>("ca0bc32c-0389-406e-8293-75bf7d07c369","","",false, this);
 
            UseClientEmailConfiguration = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderPrintQueryView>("4a4cdc5f-e417-46c8-a9df-52baa0e32270","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderPrintQueryView,EmailChildDialogView>("ae6727f3-c6fd-49ec-a94f-c8a470d41cf6","","", this,Screen.EmailChildDialogView);
 

        }
        public IRPSComboBox<MaintenanceOrderPrintQueryView> MaintenanceOrderFrom { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> MaintenanceOrderTo { get; set; } 
        public IRPSTextBox<MaintenanceOrderPrintQueryView> DateFrom { get; set; } 
        public IRPSTextBox<MaintenanceOrderPrintQueryView> DateTo { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> All { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> Qualify { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> Qualify1 { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> Employee { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> Employee1 { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> Supplier { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> Supplier1 { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> CustomerLanguage { get; set; } 
        public IRPSOption<MaintenanceOrderPrintQueryView> Language { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> Language1 { get; set; } 
        public IRPSCheckbox<MaintenanceOrderPrintQueryView> SpecificList { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintQueryView> CustomReport { get; set; } 
        public IRPSCheckbox<MaintenanceOrderPrintQueryView> UseClientEmailConfiguration { get; set; } 
        public IRPSButton<MaintenanceOrderPrintQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public MaintenanceOrderPrint Screen { get; set; }
        public MaintenanceOrderPrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(MaintenanceOrderPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrderPrintableQuery = new CollectionInit(){IDDescriptor = "a63a70e6-c07a-4631-98fe-dab879e04d1b",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="506ba936-9c73-4090-bbbd-e9122e6598df",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderPrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_MaintenanceOrderPrintableQuery,this);
 

        }
        public MaintenanceOrderPrintableQueryCollectionEditor<EmailChildDialogView> MaintenanceOrderPrintableQuery { get; set; } 
        public MaintenanceOrderPrint Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderPrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  MaintenanceOrderPrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderPrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public MaintenanceOrderPrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#506ba936-9c73-4090-bbbd-e9122e6598df .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> MaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
    }
  
    

}
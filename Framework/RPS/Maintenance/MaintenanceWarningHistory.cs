    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarningHistory
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarningHistory:Screen
    {
        public MaintenanceWarningHistory():base()
        {
            this.URL = "maintenance.maintenancewarninghistory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningHistoryQueryView  = new MaintenanceWarningHistoryQueryView(this); 
            MaintenanceWarningHistoryQueryView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningHistoryQueryView MaintenanceWarningHistoryQueryView {get; set; } 
    }
            
    public partial class MaintenanceWarningHistoryQueryView : View
    {
        public MaintenanceWarningHistoryQueryView(MaintenanceWarningHistory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UICompany = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("f6e288ad-f35d-40af-a71c-76bf63cfce0b","","",false, this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("4f3de861-b2bd-4ae8-bd6c-3e12bdd4d9b4","","",false, this);
 
            UIPendingTickets = RPSControlFactory.CreateRPSCheckBox<MaintenanceWarningHistoryQueryView>("a9f93acd-d9ac-4e25-9d3b-60c45745a43b","","",false, this);
 
            UILstMaintenanceWarningStatus = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceWarningHistoryQueryView>("89938db6-c1de-4198-bd09-0a1c2a0b9ee7","","",false, this);
 
            UIMaintenanceWarning = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("5fb6e883-149b-44aa-8038-2c9e364cc7af","","",false, this);
 
            UIMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("3b0ef8f3-2197-4de5-a1a6-9df5cf56a3fc","","",false, this);
 
            UISerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningHistoryQueryView>("85d7f1ab-9bf7-45d4-ada3-8a235f3c61eb","","",false, this);
 
            UILstMaintenanceWarningType = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceWarningHistoryQueryView>("04558bc4-7840-4e6c-a900-c7bae98b2f0f","","",false, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningHistoryQueryView>("eb196338-071e-490d-958d-42428336778c","","",false, this);
 
            UIUserReported = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("42db4598-36d3-4907-ad49-21daa9dd791c","","",false, this);
 
            UIUserManaged = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("300429ef-07a8-4dd2-8b55-4c291dec2c25","","",false, this);
 
            UIUserAssigned = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("bbe8dc03-475d-4049-b6a3-6f9079fea1e8","","",false, this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "02a528fe-df2c-478e-9b29-17f25dfcd131","","",this);
 
            UIOptEmployee = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "bdd35318-0cf9-4f0f-b266-3a00402a67b4","","",this);
 
            UIEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("a47baed8-18dc-4ebb-8015-9abfcd9fd3fb","","",false, this);
 
            UIOptCustomer = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "32a447e9-4516-4578-a382-17009ecc9fb5","","",this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningHistoryQueryView>("ebf4a6ba-0d46-4cfe-8e75-2582cbf5b061","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningHistoryQueryView>("e39476a5-0b12-496f-b1dc-51ce9991c211","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningHistoryQueryView>("5ce7188e-a194-453d-9374-a19d5a014079","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "6f759624-2abc-4ee6-9ae2-dcd2c8f2ecfe","","",this);
 
            Ticket = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "799c657c-3284-48b8-a5b1-4961bd35981a","","",this);
 
            StartUp = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "42c4a401-0565-41af-82e5-f3f76cbbc6e9","","",this);
 
            UIOptAll1 = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "887abc04-a277-4ecf-ab13-8589838693ad","","",this);
 
            UIOptInternal = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "7bd1ed24-088d-43ad-9b61-4b4b04557a33","","",this);
 
            UIOptExternal = RPSControlFactory.CreateRPSOption<MaintenanceWarningHistoryQueryView>( "a9db5e9a-d479-42ee-a37d-fbffa5af413a","","",this);
 
            CollectionInit params_MaintenanceWarningHistory = new CollectionInit(){IDDescriptor = "40963d53-bec7-4a9e-a228-f22882ab3b09",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="23401148-5dde-4603-a3f2-84f511d82729",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningHistory = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningHistoryCollectionEditor<MaintenanceWarningHistoryQueryView>,MaintenanceWarningHistoryQueryView>( params_MaintenanceWarningHistory,this);
 
            CollectionInit params_MaintenanceWarningHistorySolution = new CollectionInit(){IDDescriptor = "40963d53-bec7-4a9e-a228-f22882ab3b09",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e75996bf-07ac-4b33-b3bf-e7cde5b4062d",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningHistorySolution = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningHistoryQueryView>,MaintenanceWarningHistoryQueryView>( params_MaintenanceWarningHistorySolution,this);
 

        }
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UICompany { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UISite { get; set; } 
        public IRPSCheckbox<MaintenanceWarningHistoryQueryView> UIPendingTickets { get; set; } 
        public IRPSCollectionComboBox<MaintenanceWarningHistoryQueryView> UILstMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIMaintenanceWarning { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceWarningHistoryQueryView> UISerialNumber { get; set; } 
        public IRPSCollectionComboBox<MaintenanceWarningHistoryQueryView> UILstMaintenanceWarningType { get; set; } 
        public IRPSTextBox<MaintenanceWarningHistoryQueryView> UIDescription { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIUserReported { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIUserManaged { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIUserAssigned { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptAll { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptEmployee { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UIEmployee { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptCustomer { get; set; } 
        public IRPSComboBox<MaintenanceWarningHistoryQueryView> UICustomer { get; set; } 
        public IRPSTextBox<MaintenanceWarningHistoryQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<MaintenanceWarningHistoryQueryView> UIDateTo { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> All { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> Ticket { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> StartUp { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptAll1 { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptInternal { get; set; } 
        public IRPSOption<MaintenanceWarningHistoryQueryView> UIOptExternal { get; set; } 
        public MaintenanceWarningHistoryCollectionEditor<MaintenanceWarningHistoryQueryView> MaintenanceWarningHistory { get; set; } 
        public MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningHistoryQueryView> MaintenanceWarningHistorySolution { get; set; } 
        public MaintenanceWarningHistory Screen { get; set; }
        public MaintenanceWarningHistoryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceWarningHistoryCollectionEditor<MaintenanceWarningHistoryQueryView>:RPSCollectionEditor<MaintenanceWarningHistoryQueryView> where MaintenanceWarningHistoryQueryView : class, IView
    {
        public  MaintenanceWarningHistoryGridView<MaintenanceWarningHistoryQueryView> GridView {get;set;}
    }
    public partial class MaintenanceWarningHistoryGridView <MaintenanceWarningHistoryQueryView> :  RPSGridView<MaintenanceWarningHistoryQueryView> where MaintenanceWarningHistoryQueryView : class, IView
    {
        public MaintenanceWarningHistoryGridView(MaintenanceWarningHistoryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarning_Type = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningHistoryQueryView>("","#23401148-5dde-4603-a3f2-84f511d82729 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_Type']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningHistoryQueryView> MaintenanceWarning_Type { get; set; } 
                     
    }
 
        public partial class MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningHistoryQueryView>:RPSCollectionEditor<MaintenanceWarningHistoryQueryView> where MaintenanceWarningHistoryQueryView : class, IView
    {
        public  MaintenanceWarningHistorySolutionGridView<MaintenanceWarningHistoryQueryView> GridView {get;set;}
    }
    public partial class MaintenanceWarningHistorySolutionGridView <MaintenanceWarningHistoryQueryView> :  RPSGridView<MaintenanceWarningHistoryQueryView> where MaintenanceWarningHistoryQueryView : class, IView
    {
        public MaintenanceWarningHistorySolutionGridView(MaintenanceWarningHistoryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarningSolution_NumMaintenanceWarningSolution = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceWarningHistoryQueryView>("","#e75996bf-07ac-4b33-b3bf-e7cde5b4062d .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_NumMaintenanceWarningSolution']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningHistoryQueryView>("","#e75996bf-07ac-4b33-b3bf-e7cde5b4062d .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningHistoryQueryView>("","#e75996bf-07ac-4b33-b3bf-e7cde5b4062d .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningHistoryQueryView> MaintenanceWarningSolution_NumMaintenanceWarningSolution { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningHistoryQueryView> MaintenanceWarningSolution_EntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningHistoryQueryView> MaintenanceWarningSolution_EntryTime { get; set; } 
                     
    }
 
    }
  
    

}
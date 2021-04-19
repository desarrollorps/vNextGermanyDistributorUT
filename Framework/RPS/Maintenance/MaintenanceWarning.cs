    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarning
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarning:Screen
    {
        public MaintenanceWarning():base()
        {
            this.URL = "maintenance.maintenancewarning";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningCollectionView  = new MaintenanceWarningCollectionView(this); 
            MaintenanceWarningEntityView  = new MaintenanceWarningEntityView(this); 
            MaintenanceWarningProcedureView  = new MaintenanceWarningProcedureView(this); 
            MaintenanceWarningSolutionView  = new MaintenanceWarningSolutionView(this); 
            MaintenanceWarningProcTaskView  = new MaintenanceWarningProcTaskView(this); 
            WarningPrerequisiteView  = new WarningPrerequisiteView(this); 
            CommentDialogView  = new CommentDialogView(this); 
            ReassignDialogView  = new ReassignDialogView(this); 
            OrderGenerationDialogView  = new OrderGenerationDialogView(this); 
            MaintenanceWarningChangeSituationDialogView  = new MaintenanceWarningChangeSituationDialogView(this); 
            ChangeComponentDialogView  = new ChangeComponentDialogView(this); 
            CuDistChangeCustomerDialogView  = new CuDistChangeCustomerDialogView(this); 
            MaintenanceWarningCollectionView.InitializeControls(); 
            MaintenanceWarningEntityView.InitializeControls(); 
            MaintenanceWarningProcedureView.InitializeControls(); 
            MaintenanceWarningSolutionView.InitializeControls(); 
            MaintenanceWarningProcTaskView.InitializeControls(); 
            WarningPrerequisiteView.InitializeControls(); 
            CommentDialogView.InitializeControls(); 
            ReassignDialogView.InitializeControls(); 
            OrderGenerationDialogView.InitializeControls(); 
            MaintenanceWarningChangeSituationDialogView.InitializeControls(); 
            ChangeComponentDialogView.InitializeControls(); 
            CuDistChangeCustomerDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningCollectionView MaintenanceWarningCollectionView {get; set; } 
            public MaintenanceWarningEntityView MaintenanceWarningEntityView {get; set; } 
            public MaintenanceWarningProcedureView MaintenanceWarningProcedureView {get; set; } 
            public MaintenanceWarningSolutionView MaintenanceWarningSolutionView {get; set; } 
            public MaintenanceWarningProcTaskView MaintenanceWarningProcTaskView {get; set; } 
            public WarningPrerequisiteView WarningPrerequisiteView {get; set; } 
            public CommentDialogView CommentDialogView {get; set; } 
            public ReassignDialogView ReassignDialogView {get; set; } 
            public OrderGenerationDialogView OrderGenerationDialogView {get; set; } 
            public MaintenanceWarningChangeSituationDialogView MaintenanceWarningChangeSituationDialogView {get; set; } 
            public ChangeComponentDialogView ChangeComponentDialogView {get; set; } 
            public CuDistChangeCustomerDialogView CuDistChangeCustomerDialogView {get; set; } 
    }
            
    public partial class MaintenanceWarningCollectionView : View
    {
        public MaintenanceWarningCollectionView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningCollectionView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ae87bf63-2f45-47b7-a14d-81f5b63e734d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceWarningCollectionView,MaintenanceWarningEntityView>( params_MainConsult,this,Screen.MaintenanceWarningEntityView);
 

        }
        public IRPSButton<MaintenanceWarningCollectionView,MaintenanceWarningEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceWarningCollectionView,MaintenanceWarningEntityView> MainConsult { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningEntityView : View
    {
        public MaintenanceWarningEntityView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningEntityView,MaintenanceWarningCollectionView>( this,Screen.MaintenanceWarningCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningEntityView,MaintenanceWarningCollectionView>( this,Screen.MaintenanceWarningCollectionView);
 
            CodMaintenanceWarning = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("d7a82764-113b-4b14-b2a4-dc3912907a26","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceWarningEntityView>("44fec9c2-851e-4cae-9b5f-dbaa0f37d548","","",true, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("e65571b7-7d16-4673-99ad-bad267f638c4","","",true, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("928d4c95-1836-4090-bca4-d205a3baca7e","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("b9020702-0de7-4731-95d8-b9c61a7e81ae","","",false, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("083dca8c-17ba-4c39-b0f1-5f54d5eb9e9c","","",true, this);
 
            EntryTime = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("08e602b9-fe3b-47c5-a226-ba972d1d2057","","",true, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("c89b7cd2-fa7f-4c84-9b3d-5c12a261bb09","","",false, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("607c5f21-34d7-48d9-8090-90ee80457647","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("0fc1774c-8527-4d67-9916-8d84729b40ed","","",false, this);
 
            IDCustomerReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("c537c1ef-edcc-4f01-bcda-4a88fa6dce5f","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("fd67f143-65e0-40b9-b5ba-66bddc314220","","",false, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("3c206c4e-a492-41c5-8cf4-0a86b0af6dee","","",false, this);
 
            IsExternWarning = RPSControlFactory.CreateRPSCheckBox<MaintenanceWarningEntityView>("76ea7709-5538-4525-a5e2-1d0030c08a95","","",false, this);
 
            IsInternWarning = RPSControlFactory.CreateRPSCheckBox<MaintenanceWarningEntityView>("f1afcc95-8f67-42f6-a5a7-5b9f61547182","","",false, this);
 
            ContactName = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("78cc1ea0-5566-4293-9a78-a67ca1996548","","",false, this);
 
            ContactPhone = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("fff28ae1-535b-4b30-bc26-40cd6ed17767","","",false, this);
 
            ContactEmail = RPSControlFactory.CreateRPSEmailTextBox<MaintenanceWarningEntityView>("e7873395-9c8e-49c3-9fca-4233df64f1bf","","",false, this);
 
            CustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("b3e04b4d-d85f-46fe-9868-92ccea5e8470","","",false, this);
 
            IDMaintenanceWarningType = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("98253591-bb95-4bc6-9b01-e985ba4d087b","","",false, this);
 
            IDMaintenanceWarningStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("a27b67b1-fffc-4a2b-a40c-adc8639471b3","","",true, this);
 
            IDMaintenanceWarningSeverity = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("0aa2a0b1-e731-458d-bab0-b2e5d3fd46e2","","",true, this);
 
            IDMaintenanceWarningPriority = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("dee70ea0-c3ed-4a14-8364-3841360b7a20","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningEntityView>("6e202604-f5ea-4c56-83de-32777f1710f4","","",false, this);
 
            CodUserInsertedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("13fdca62-0d5f-4149-a838-12660851efc8","","",false, this);
 
            CodUserManager = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("ed3c6f99-29e6-47ab-96ce-4474fc347926","","",false, this);
 
            CodUserAssignedTo = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningEntityView>("aa24f58f-4395-4867-85f6-9465e0fa1e30","","",false, this);
 
            OrderGenerationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,OrderGenerationDialogView>("ecc192a5-a294-450d-a2bd-53d609b6936e","","", this,Screen.OrderGenerationDialogView);
 
            CommentNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,CommentDialogView>("b91675da-65af-4524-810b-bb664837c827","","", this,Screen.CommentDialogView);
 
            GeneratePurchaseOrderCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningEntityView>( "dfc1e9db-5ee4-4899-936f-e1f4ad0449f3","","",this);
 
            ReassignNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,ReassignDialogView>("b43c46c9-547e-4825-8a32-b47f249564ae","","", this,Screen.ReassignDialogView);
 
            MaintenanceWarningChangeSituationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,MaintenanceWarningChangeSituationDialogView>("64a61e28-a982-450d-b80e-2bf3cc6f0cc1","","", this,Screen.MaintenanceWarningChangeSituationDialogView);
 
            ChangeComponentNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,ChangeComponentDialogView>("8f7b8f46-4def-40c6-a55c-6c8c4559f0ed","","", this,Screen.ChangeComponentDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningEntityView>( "3e241187-da73-4e05-8202-1a933d07a4d3","","",this);
 
            CuDistChangeCustomerNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningEntityView,CuDistChangeCustomerDialogView>("db4ccfe6-d71c-4875-acfa-965c299275d9","","", this,Screen.CuDistChangeCustomerDialogView);
 
            CollectionInit params_MANMaintenanceWarningProcedures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3c6a5692-f3cb-4567-b671-297fb47c9407",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceWarningProcedures = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceWarningProceduresCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>,MaintenanceWarningEntityView,MaintenanceWarningSolutionView>( params_MANMaintenanceWarningProcedures,this,Screen.MaintenanceWarningSolutionView);
 
            CollectionInit params_WarningPrerequisites = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6148ef81-e836-461b-bc41-f0f73e4aaee6",CSSSelectorGrid="",XPathGrid=""};
            WarningPrerequisites = RPSControlFactory.RPSCreateCollectionWithGrid<WarningPrerequisitesCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>,MaintenanceWarningEntityView,MaintenanceWarningSolutionView>( params_WarningPrerequisites,this,Screen.MaintenanceWarningSolutionView);
 
            CollectionInit params_MANMaintenanceWarningSolutions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36f730ae-cca4-4ff4-85c2-a9eda7a4fca7",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceWarningSolutions = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceWarningSolutionsCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>,MaintenanceWarningEntityView,MaintenanceWarningSolutionView>( params_MANMaintenanceWarningSolutions,this,Screen.MaintenanceWarningSolutionView);
 
            CollectionInit params_MaintenanceWarningRelated = new CollectionInit(){IDDescriptor = "11d56143-0458-4036-a05a-32d0616fc433",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e6f13da4-edd7-44ab-8433-6378543563a9",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningRelated = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningRelatedCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>,MaintenanceWarningEntityView,MaintenanceWarningSolutionView>( params_MaintenanceWarningRelated,this,Screen.MaintenanceWarningSolutionView);
 
            CollectionInit params_MaintenanceWarningHistorySolution = new CollectionInit(){IDDescriptor = "11d56143-0458-4036-a05a-32d0616fc433",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14e6dbe4-f310-4639-af5c-95fa32d23eba",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningHistorySolution = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>,MaintenanceWarningEntityView,MaintenanceWarningSolutionView>( params_MaintenanceWarningHistorySolution,this,Screen.MaintenanceWarningSolutionView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='11892134-e82c-4a26-895e-bda02d592560']","",this);
 
            Description1 = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='38224e06-df85-458f-b27c-8de971b694f6']","",this);
 
            Management = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='9a40d86f-161e-49c4-817b-d2324f6cb838']","",this);
 
            Prerequisites = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='8bf246dd-ad28-48e1-a0a1-2a1292a15999']","",this);
 
            Solution = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='3854562a-565b-444f-8f30-d45a8dbafc08']","",this);
 
            History = RPSControlFactory.CreateRPSSection<MaintenanceWarningEntityView>( "","ul li[rpsid='1b407b78-47f3-431d-a35c-736bb42e690e']","",this);
 

        }
        public IRPSSaveButton<MaintenanceWarningEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,MaintenanceWarningCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,MaintenanceWarningCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> CodMaintenanceWarning { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> Type { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> SerialNumber { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDSite { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> EntryDate { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> EntryTime { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> ClosingDate { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> ClosingTime { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDCustomerReportedBy { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDEmployeeReportedBy { get; set; } 
        public IRPSCheckbox<MaintenanceWarningEntityView> IsExternWarning { get; set; } 
        public IRPSCheckbox<MaintenanceWarningEntityView> IsInternWarning { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> ContactName { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> ContactPhone { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> ContactEmail { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> CustomerDeliveryAddress { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDMaintenanceWarningType { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDMaintenanceWarningSeverity { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> IDMaintenanceWarningPriority { get; set; } 
        public IRPSTextBox<MaintenanceWarningEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> CodUserInsertedBy { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> CodUserManager { get; set; } 
        public IRPSComboBox<MaintenanceWarningEntityView> CodUserAssignedTo { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,OrderGenerationDialogView> OrderGenerationNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,CommentDialogView> CommentNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView> GeneratePurchaseOrderCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,ReassignDialogView> ReassignNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,MaintenanceWarningChangeSituationDialogView> MaintenanceWarningChangeSituationNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,ChangeComponentDialogView> ChangeComponentNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningEntityView,CuDistChangeCustomerDialogView> CuDistChangeCustomerNavigationCommandButton { get; set; } 
        public MANMaintenanceWarningProceduresCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> MANMaintenanceWarningProcedures { get; set; } 
        public WarningPrerequisitesCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> WarningPrerequisites { get; set; } 
        public MANMaintenanceWarningSolutionsCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> MANMaintenanceWarningSolutions { get; set; } 
        public MaintenanceWarningRelatedCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> MaintenanceWarningRelated { get; set; } 
        public MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> MaintenanceWarningHistorySolution { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> Description1 { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> Management { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> Prerequisites { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> Solution { get; set; } 
        public IRPSSection<MaintenanceWarningEntityView> History { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANMaintenanceWarningProceduresCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>:RPSCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public  MANMaintenanceWarningProceduresGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> GridView {get;set;}
    }
    public partial class MANMaintenanceWarningProceduresGridView <MaintenanceWarningEntityView,MaintenanceWarningSolutionView> :  RPSGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public MANMaintenanceWarningProceduresGridView(MaintenanceWarningEntityView currentView,MaintenanceWarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSGridComboBox<MaintenanceWarningEntityView>("","#3c6a5692-f3cb-4567-b671-297fb47c9407 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcedure']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#3c6a5692-f3cb-4567-b671-297fb47c9407 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceWarningEntityView> IDMaintenanceProcedure { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> Description { get; set; } 
                     
    }
 
        public partial class WarningPrerequisitesCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>:RPSCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public  WarningPrerequisitesGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> GridView {get;set;}
    }
    public partial class WarningPrerequisitesGridView <MaintenanceWarningEntityView,MaintenanceWarningSolutionView> :  RPSGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public WarningPrerequisitesGridView(MaintenanceWarningEntityView currentView,MaintenanceWarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#6148ef81-e836-461b-bc41-f0f73e4aaee6 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Done = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceWarningEntityView>("","#6148ef81-e836-461b-bc41-f0f73e4aaee6 .ag-row[role='row']@ROWINDEX [col-id='cDone']","",true, this.CurrentView);
 
            DoneDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#6148ef81-e836-461b-bc41-f0f73e4aaee6 .ag-row[role='row']@ROWINDEX [col-id='cDoneDate']","",false, this.CurrentView);
 
            DoneBy = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#6148ef81-e836-461b-bc41-f0f73e4aaee6 .ag-row[role='row']@ROWINDEX [col-id='cDoneBy']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceWarningEntityView>("","#6148ef81-e836-461b-bc41-f0f73e4aaee6 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningEntityView> Description { get; set; } 
        public IRPSGridCheckbox<MaintenanceWarningEntityView> Done { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> DoneDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> DoneBy { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> Comment { get; set; } 
                     
    }
 
        public partial class MANMaintenanceWarningSolutionsCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>:RPSCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public  MANMaintenanceWarningSolutionsGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> GridView {get;set;}
    }
    public partial class MANMaintenanceWarningSolutionsGridView <MaintenanceWarningEntityView,MaintenanceWarningSolutionView> :  RPSGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public MANMaintenanceWarningSolutionsGridView(MaintenanceWarningEntityView currentView,MaintenanceWarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumMaintenanceWarningSolution = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cNumMaintenanceWarningSolution']","",true, this.CurrentView);
 
            IDMaintenanceSolutionType = RPSControlFactory.CreateRPSGridComboBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceSolutionType']","",false, this.CurrentView);
 
            CodSolution = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cCodSolution']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cEntryDate']","",true, this.CurrentView);
 
            EntryTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cEntryTime']","",true, this.CurrentView);
 
            CodUserReportedBy = RPSControlFactory.CreateRPSGridComboBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cCodUserReportedBy']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            KnowledgeDataBase = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceWarningEntityView>("","#36f730ae-cca4-4ff4-85c2-a9eda7a4fca7 .ag-row[role='row']@ROWINDEX [col-id='cKnowledgeDataBase']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningEntityView> NumMaintenanceWarningSolution { get; set; } 
        public IRPSGridComboBox<MaintenanceWarningEntityView> IDMaintenanceSolutionType { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> CodSolution { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> Description { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> EntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> EntryTime { get; set; } 
        public IRPSGridComboBox<MaintenanceWarningEntityView> CodUserReportedBy { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceWarningEntityView> Duration { get; set; } 
        public IRPSGridCheckbox<MaintenanceWarningEntityView> KnowledgeDataBase { get; set; } 
                     
    }
 
        public partial class MaintenanceWarningRelatedCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>:RPSCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public  MaintenanceWarningRelatedGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> GridView {get;set;}
    }
    public partial class MaintenanceWarningRelatedGridView <MaintenanceWarningEntityView,MaintenanceWarningSolutionView> :  RPSGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public MaintenanceWarningRelatedGridView(MaintenanceWarningEntityView currentView,MaintenanceWarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarning_Description = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceWarningEntityView>("","#e6f13da4-edd7-44ab-8433-6378543563a9 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_Description']","",false, this.CurrentView);
 
            MaintenanceWarning_Type = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#e6f13da4-edd7-44ab-8433-6378543563a9 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_Type']","",false, this.CurrentView);
 
            MaintenanceWarning_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#e6f13da4-edd7-44ab-8433-6378543563a9 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarning_ClosingDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#e6f13da4-edd7-44ab-8433-6378543563a9 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_ClosingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarning_Description { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarning_Type { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarning_EntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarning_ClosingDate { get; set; } 
                     
    }
 
        public partial class MaintenanceWarningHistorySolutionCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView>:RPSCollectionEditor<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public  MaintenanceWarningHistorySolutionGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> GridView {get;set;}
    }
    public partial class MaintenanceWarningHistorySolutionGridView <MaintenanceWarningEntityView,MaintenanceWarningSolutionView> :  RPSGridView<MaintenanceWarningEntityView,MaintenanceWarningSolutionView> where MaintenanceWarningEntityView : class, IView where MaintenanceWarningSolutionView : class, IView
    {
        public MaintenanceWarningHistorySolutionGridView(MaintenanceWarningEntityView currentView,MaintenanceWarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarningSolution_NumMaintenanceWarningSolution = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceWarningEntityView>("","#14e6dbe4-f310-4639-af5c-95fa32d23eba .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_NumMaintenanceWarningSolution']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#14e6dbe4-f310-4639-af5c-95fa32d23eba .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningEntityView>("","#14e6dbe4-f310-4639-af5c-95fa32d23eba .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarningSolution_NumMaintenanceWarningSolution { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarningSolution_EntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningEntityView> MaintenanceWarningSolution_EntryTime { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceWarningProcedureView : View
    {
        public MaintenanceWarningProcedureView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningProcedureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningProcedureView>("792223a6-5b6a-4d8d-8aab-ffccb107cd7e","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningProcedureView>("e5d9cdd8-6c66-4fb2-a6ae-cdd1a42014b4","","",false, this);
 
            CollectionInit params_MANMaintenanceWarningProcTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f330e42-4ff6-4cb2-86d3-4c0c9b3d464d",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceWarningProcTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceWarningProcTasksCollectionEditor<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView>,MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView>( params_MANMaintenanceWarningProcTasks,this,Screen.MaintenanceWarningProcTaskView);
 

        }
        public IRPSButton<MaintenanceWarningProcedureView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceWarningProcedureView,MaintenanceWarningEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceWarningProcedureView> IDMaintenanceProcedure { get; set; } 
        public IRPSTextBox<MaintenanceWarningProcedureView> Description { get; set; } 
        public MANMaintenanceWarningProcTasksCollectionEditor<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView> MANMaintenanceWarningProcTasks { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningProcedureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANMaintenanceWarningProcTasksCollectionEditor<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView>:RPSCollectionEditor<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView> where MaintenanceWarningProcedureView : class, IView where MaintenanceWarningProcTaskView : class, IView
    {
        public  MANMaintenanceWarningProcTasksGridView<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView> GridView {get;set;}
    }
    public partial class MANMaintenanceWarningProcTasksGridView <MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView> :  RPSGridView<MaintenanceWarningProcedureView,MaintenanceWarningProcTaskView> where MaintenanceWarningProcedureView : class, IView where MaintenanceWarningProcTaskView : class, IView
    {
        public MANMaintenanceWarningProcTasksGridView(MaintenanceWarningProcedureView currentView,MaintenanceWarningProcTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSGridComboBox<MaintenanceWarningProcedureView>("","#5f330e42-4ff6-4cb2-86d3-4c0c9b3d464d .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcTask']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningProcedureView>("","#5f330e42-4ff6-4cb2-86d3-4c0c9b3d464d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceWarningProcedureView>("","#5f330e42-4ff6-4cb2-86d3-4c0c9b3d464d .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceWarningProcedureView> IDMaintenanceProcTask { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningProcedureView> Description { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceWarningProcedureView> Duration { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceWarningSolutionView : View
    {
        public MaintenanceWarningSolutionView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningSolutionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            IDMaintenanceSolutionType = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("13d75659-7295-4ea9-b416-fd71bd39f385","","",false, this);
 
            IDMaintenanceSolution = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("058a1f45-3950-4dc2-a495-a6cde1525b93","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("b8cb9145-91dc-45f1-baeb-4104fea91311","","",false, this);
 
            UIIDOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("3deffbe4-97f8-4450-8ba0-37b87360b9f9","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("b7920b6e-ccb0-4f9b-8787-797cba459232","","",false, this);
 
            UIIDProject = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("2fd7caa1-4c10-4db0-9aa1-f07d9f310efd","","",false, this);
 
            UIIDOrderSL = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("5df7bddc-ffee-49c6-943d-186b77bb708e","","",false, this);
 
            CodSolution = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSolutionView>("412890d6-d4e3-4b9e-92c2-16c91fd0f4ca","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSolutionView>("bd4d0865-0b2f-4ae6-8b2f-e3087d8d36d9","","",false, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSolutionView>("ee992836-0fbe-4b08-b3a8-3856ad0b5a66","","",true, this);
 
            EntryTime = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSolutionView>("d2d02ac2-1f6b-43a9-ab26-b3ff60db9264","","",true, this);
 
            CodUserReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningSolutionView>("35cf8a49-8286-4f4c-9acb-ce8599ee01f6","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceWarningSolutionView>("8afd9c53-c37e-40d5-a794-6829648a91e4","","",true, this);
 
            KnowledgeDataBase = RPSControlFactory.CreateRPSCheckBox<MaintenanceWarningSolutionView>("5f230cc1-54fd-41a9-afe3-2afea1c59f6f","","",true, this);
 

        }
        public IRPSButton<MaintenanceWarningSolutionView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceWarningSolutionView,MaintenanceWarningEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> IDMaintenanceSolutionType { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> IDMaintenanceSolution { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> UIIDMaintenanceOrder { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> UIIDOrder { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> UIIDProject { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> UIIDOrderSL { get; set; } 
        public IRPSTextBox<MaintenanceWarningSolutionView> CodSolution { get; set; } 
        public IRPSTextBox<MaintenanceWarningSolutionView> Description { get; set; } 
        public IRPSTextBox<MaintenanceWarningSolutionView> EntryDate { get; set; } 
        public IRPSTextBox<MaintenanceWarningSolutionView> EntryTime { get; set; } 
        public IRPSComboBox<MaintenanceWarningSolutionView> CodUserReportedBy { get; set; } 
        public IRPSDurationTextBox<MaintenanceWarningSolutionView> Duration { get; set; } 
        public IRPSCheckbox<MaintenanceWarningSolutionView> KnowledgeDataBase { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningSolutionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningProcTaskView : View
    {
        public MaintenanceWarningProcTaskView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningProcTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView>( this,Screen.MaintenanceWarningProcedureView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView>( this,Screen.MaintenanceWarningProcedureView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView>( this,Screen.MaintenanceWarningProcedureView);
 
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningProcTaskView>("1f8ff7e4-2ae6-47a8-b9df-a2c1d0b1ee4f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningProcTaskView>("202c9aa6-340c-4e53-8fbf-4981633a9676","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceWarningProcTaskView>("62f879ef-a516-418e-8fe0-5b33d17d9674","","",false, this);
 

        }
        public IRPSButton<MaintenanceWarningProcTaskView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceWarningProcTaskView,MaintenanceWarningProcedureView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceWarningProcTaskView> IDMaintenanceProcTask { get; set; } 
        public IRPSTextBox<MaintenanceWarningProcTaskView> Description { get; set; } 
        public IRPSDurationTextBox<MaintenanceWarningProcTaskView> Duration { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningProcTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarningPrerequisiteView : View
    {
        public WarningPrerequisiteView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningPrerequisiteView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningPrerequisiteView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningPrerequisiteView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<WarningPrerequisiteView,MaintenanceWarningEntityView>( this,Screen.MaintenanceWarningEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningPrerequisiteView>("71ae0b4e-fb29-45ef-8086-4b2637823b59","","",false, this);
 
            Done = RPSControlFactory.CreateRPSCheckBox<WarningPrerequisiteView>("dfb31afb-38c5-4894-b6bb-e1dd5db6389d","","",true, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<WarningPrerequisiteView>("f3eaceae-2ee7-493b-9390-706dd145c001","","",false, this);
 
            DoneBy = RPSControlFactory.CreateRPSTextBox<WarningPrerequisiteView>("971689c5-13c6-4ca4-9fbd-589b5a177bcf","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<WarningPrerequisiteView>("76bb22c3-2c35-4ac0-b27b-ba14ae5d06aa","","",false, this);
 

        }
        public IRPSButton<WarningPrerequisiteView> DeleteButton { get; set; } 
        public IRPSButton<WarningPrerequisiteView,MaintenanceWarningEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningPrerequisiteView,MaintenanceWarningEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<WarningPrerequisiteView,MaintenanceWarningEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<WarningPrerequisiteView> Description { get; set; } 
        public IRPSCheckbox<WarningPrerequisiteView> Done { get; set; } 
        public IRPSTextBox<WarningPrerequisiteView> DoneDate { get; set; } 
        public IRPSTextBox<WarningPrerequisiteView> DoneBy { get; set; } 
        public IRPSTextBox<WarningPrerequisiteView> Comment { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public WarningPrerequisiteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommentDialogView : View
    {
        public CommentDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIComment = RPSControlFactory.CreateRPSTextBox<CommentDialogView>("66c98c8d-00b7-4c0a-a3eb-4394edec22e0","","",true, this);
 

        }
        public IRPSTextBox<CommentDialogView> UIComment { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public CommentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReassignDialogView : View
    {
        public ReassignDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIComment = RPSControlFactory.CreateRPSTextBox<ReassignDialogView>("af312181-4a28-404d-8036-35ba64d3c029","","",true, this);
 
            UIDlgUsers = RPSControlFactory.CreateRPSComboBox<ReassignDialogView>("d799eb82-d1e6-4916-844b-4229d46476e3","","",true, this);
 

        }
        public IRPSTextBox<ReassignDialogView> UIComment { get; set; } 
        public IRPSComboBox<ReassignDialogView> UIDlgUsers { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public ReassignDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderGenerationDialogView : View
    {
        public OrderGenerationDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDlgOrderExecutionDate = RPSControlFactory.CreateRPSTextBox<OrderGenerationDialogView>("16471ee5-4552-4fbd-abd8-260b7db17dae","","",true, this);
 
            UIDlgOrderExecutionTime = RPSControlFactory.CreateRPSTextBox<OrderGenerationDialogView>("153409d4-1410-4f15-9084-3b9c5ac0e3c7","","",false, this);
 
            UIDlgOrderDurationTime = RPSControlFactory.CreateRPSDurationTextBox<OrderGenerationDialogView>("5c102b81-9359-4162-800b-f6e6f92d681a","","",true, this);
 
            UIDlgUsers = RPSControlFactory.CreateRPSComboBox<OrderGenerationDialogView>("1f319079-50bd-4d45-ab0a-bc856aedac4a","","",true, this);
 
            UIDlgOrderMaintenanceType = RPSControlFactory.CreateRPSComboBox<OrderGenerationDialogView>("6942b4a5-ff2e-46e7-96ad-ae9208be3456","","",true, this);
 
            UIDlgOrderResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<OrderGenerationDialogView>("5a376f43-d5b1-4fb9-b3b7-80cc9b32bad0","","",false, this);
 
            UIDlgOrderQualify = RPSControlFactory.CreateRPSComboBox<OrderGenerationDialogView>("d7f42255-f713-496f-9ad9-9753994165aa","","",true, this);
 
            UIDlgOrderEmployee = RPSControlFactory.CreateRPSComboBox<OrderGenerationDialogView>("1493be64-966e-4b64-9083-221d9ad0a3f7","","",true, this);
 
            UIDlgOrderSupplier = RPSControlFactory.CreateRPSComboBox<OrderGenerationDialogView>("8ec45547-81b0-43c0-a10f-14d272761774","","",true, this);
 

        }
        public IRPSTextBox<OrderGenerationDialogView> UIDlgOrderExecutionDate { get; set; } 
        public IRPSTextBox<OrderGenerationDialogView> UIDlgOrderExecutionTime { get; set; } 
        public IRPSDurationTextBox<OrderGenerationDialogView> UIDlgOrderDurationTime { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgUsers { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgOrderMaintenanceType { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgOrderResponsibleType { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgOrderQualify { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgOrderEmployee { get; set; } 
        public IRPSComboBox<OrderGenerationDialogView> UIDlgOrderSupplier { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public OrderGenerationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningChangeSituationDialogView : View
    {
        public MaintenanceWarningChangeSituationDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaintenanceWarningStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningChangeSituationDialogView>("c74dfc3d-1580-4937-a279-08ba3eee6b23","","",false, this);
 
            IDWarningStatusDestination = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningChangeSituationDialogView>("0c8c5edf-0659-49f4-93b3-c04371a6320c","","",true, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningChangeSituationDialogView>("acae2f7b-a922-4746-b6e9-d8f06d22d79c","","",true, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningChangeSituationDialogView>("63677e04-c9a4-49e2-82c0-f7f854440224","","",true, this);
 

        }
        public IRPSComboBox<MaintenanceWarningChangeSituationDialogView> IDMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceWarningChangeSituationDialogView> IDWarningStatusDestination { get; set; } 
        public IRPSTextBox<MaintenanceWarningChangeSituationDialogView> ClosingDate { get; set; } 
        public IRPSTextBox<MaintenanceWarningChangeSituationDialogView> ClosingTime { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public MaintenanceWarningChangeSituationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeComponentDialogView : View
    {
        public ChangeComponentDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDNewMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<ChangeComponentDialogView>("30a2fc6e-29d9-4e43-876b-696f05b55508","","",true, this);
 

        }
        public IRPSComboBox<ChangeComponentDialogView> IDNewMaintenanceComponent { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public ChangeComponentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistChangeCustomerDialogView : View
    {
        public CuDistChangeCustomerDialogView(MaintenanceWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CuDistChangeCustomerDialogView>("555c95fd-a60d-4c06-bcba-2505f5aa29c8","","",false, this);
 

        }
        public IRPSComboBox<CuDistChangeCustomerDialogView> IDCustomer { get; set; } 
        public MaintenanceWarning Screen { get; set; }
        public CuDistChangeCustomerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Employee
{
    //RPS VERSION 1.0.0.0
    public partial class Employee:Screen
    {
        public Employee():base()
        {
            this.URL = "general.employee";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            EmployeeCollectionView  = new EmployeeCollectionView(this); 
            EmployeeEntityView  = new EmployeeEntityView(this); 
            EmployeeQualifyView  = new EmployeeQualifyView(this); 
            EmployeeEducationView  = new EmployeeEducationView(this); 
            CuDistEmployeeFromHRPopUpDialogView  = new CuDistEmployeeFromHRPopUpDialogView(this); 
            EmployeeCollectionView.InitializeControls(); 
            EmployeeEntityView.InitializeControls(); 
            EmployeeQualifyView.InitializeControls(); 
            EmployeeEducationView.InitializeControls(); 
            CuDistEmployeeFromHRPopUpDialogView.InitializeControls(); 
           
        }
      
            public EmployeeCollectionView EmployeeCollectionView {get; set; } 
            public EmployeeEntityView EmployeeEntityView {get; set; } 
            public EmployeeQualifyView EmployeeQualifyView {get; set; } 
            public EmployeeEducationView EmployeeEducationView {get; set; } 
            public CuDistEmployeeFromHRPopUpDialogView CuDistEmployeeFromHRPopUpDialogView {get; set; } 
    }
            
    public partial class EmployeeCollectionView : View
    {
        public EmployeeCollectionView(Employee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<EmployeeCollectionView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "726191c6-659d-4b04-840a-183e123f08ee",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<EmployeeCollectionView,EmployeeEntityView>( params_MainConsult,this,Screen.EmployeeEntityView);
 

        }
        public IRPSButton<EmployeeCollectionView,EmployeeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<EmployeeCollectionView,EmployeeEntityView> MainConsult { get; set; } 
        public Employee Screen { get; set; }
        public EmployeeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeEntityView : View
    {
        public EmployeeEntityView(Employee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EmployeeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeEntityView,EmployeeCollectionView>( this,Screen.EmployeeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeEntityView,EmployeeCollectionView>( this,Screen.EmployeeCollectionView);
 
            CodEmployee = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("823ce8d7-787f-475a-9903-6d79f26747f2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("a6da4580-f436-4085-8023-daf89e35def0","","",false, this);
 
            IDCategory = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("2c9b0c06-bf6e-48f0-b504-68ce33bdfbc2","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<EmployeeEntityView>("50049759-d252-4ed6-93b0-9cce140c535f","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("c893e5b8-60d0-4600-9047-a266b22af90f","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("6bdb6850-7caf-4f39-85e7-9aca485d254c","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("83108884-9937-4eda-a50b-80fb80887709","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("df18a93c-0d97-4f70-940c-60148ad57b90","","",false, this);
 
            IDDepartment = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("d7da8544-fedd-47d6-931b-2cdf1762c993","","",false, this);
 
            Fictitious = RPSControlFactory.CreateRPSCheckBox<EmployeeEntityView>("3c122fef-4401-477b-85cf-5e4851da4f6d","","",true, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<EmployeeEntityView>("2a93e862-2e16-4a57-9de6-c1d6286067b6","","",true, this);
 
            ImputationOnLineUnique = RPSControlFactory.CreateRPSCheckBox<EmployeeEntityView>("68d3bfeb-95e8-4d92-a2b4-8e13b91f734f","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeEntityView>("4e64ccce-8e6d-44d7-abc6-4d5317604da0","","",true, this);
 
            ManageImputations = RPSControlFactory.CreateRPSEnumComboBox<EmployeeEntityView>("bada8afc-a4be-415c-b68d-6e9c7e8e09ba","","",true, this);
 
            MaintenanceWorker = RPSControlFactory.CreateRPSCheckBox<EmployeeEntityView>("2c1bea67-aeee-4152-98ca-dca42d825081","","",true, this);
 
            MaintenanceWorkerPwd = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("9646a091-3c11-461b-b037-6c11b3a5d30c","","",false, this);
 
            MaintenanceWorkerPwdConfirm = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("6c60eab5-786f-4cb1-a77a-33171f6782e6","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("3f542044-ae43-4811-9204-c145005aaf16","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("0fe6212a-921e-4e3d-bbc4-3876ad4392ba","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("dfb17f08-70ec-498c-a0ec-e36d160d4228","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("9dfd9b42-8f46-4ce5-ab85-01664a0243a7","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("2328ff6e-ffbe-4057-bd8e-65e0df8592d7","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("581fca8e-68fd-4057-a57b-5f067e3c1b5d","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("22783b43-e86b-48bf-868f-662d4e5d5a32","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<EmployeeEntityView>("2295f497-1d61-44b6-a412-7087264be2cc","","",false, this);
 
            IDTRAFlow = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("3ce28c95-d721-4818-ba12-92026a1c7f84","","",false, this);
 
            IDEmployeeAccType = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("8d294bdd-9fda-47b8-883c-3cebd31e63d9","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("4aaea1af-32f4-4b9e-8c33-e5579ec849cc","","",false, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<EmployeeEntityView>("52a1534e-afaa-4558-b15a-829598b8a19f","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("1281bba6-9dff-4c70-98f7-f70aad95cc7f","","",false, this);
 
            ChipCode = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("70fc5155-ee8c-4b7f-9c58-402d44bba686","","",false, this);
 
            ExternalCodEmployee = RPSControlFactory.CreateRPSTextBox<EmployeeEntityView>("f0aab2c0-8456-41ee-9853-5ae49d974514","","",false, this);
 
            CuDistEmployeeFromHRPopUpNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<EmployeeEntityView,CuDistEmployeeFromHRPopUpDialogView>("6e5ab102-78fd-4c0b-95b5-36db71e8774d","","", this,Screen.CuDistEmployeeFromHRPopUpDialogView);
 
            CollectionInit params_GENEmployeeQualifys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d63b90f2-47ec-4b35-91bb-84361fa44534",CSSSelectorGrid="",XPathGrid=""};
            GENEmployeeQualifys = RPSControlFactory.RPSCreateCollectionWithGrid<GENEmployeeQualifysCollectionEditor<EmployeeEntityView,EmployeeQualifyView>,EmployeeEntityView,EmployeeQualifyView>( params_GENEmployeeQualifys,this,Screen.EmployeeQualifyView);
 
            CollectionInit params_EmployeeEducations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5eb938c-0d2c-48ef-9f46-a14b5696c655",CSSSelectorGrid="",XPathGrid=""};
            EmployeeEducations = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeEducationsCollectionEditor<EmployeeEntityView,EmployeeQualifyView>,EmployeeEntityView,EmployeeQualifyView>( params_EmployeeEducations,this,Screen.EmployeeQualifyView);
 
            CollectionInit params_TrainingPlanEmployeeConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="73713b12-414d-461f-b33b-f8077c0ca5b0",CSSSelectorGrid="",XPathGrid=""};
            TrainingPlanEmployeeConsult = RPSControlFactory.RPSCreateCollectionWithGrid<TrainingPlanEmployeeConsultCollectionEditor<EmployeeEntityView,EmployeeQualifyView>,EmployeeEntityView,EmployeeQualifyView>( params_TrainingPlanEmployeeConsult,this,Screen.EmployeeQualifyView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<EmployeeEntityView>( "","ul li[rpsid='a3202478-93ae-4ee3-ad78-fecff9615c68']","",this);
 
            Qualification = RPSControlFactory.CreateRPSSection<EmployeeEntityView>( "","ul li[rpsid='b0a1a6a8-2ff3-4f5b-90ed-dd3ef15e91ce']","",this);
 
            Education = RPSControlFactory.CreateRPSSection<EmployeeEntityView>( "","ul li[rpsid='974048e4-3ecf-4dcd-bda3-5e1d9449d1f0']","",this);
 
            PlanesFormacion = RPSControlFactory.CreateRPSSection<EmployeeEntityView>( "","ul li[rpsid='8b364b0e-6f0c-4ed2-8da7-2952b7b994d2']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<EmployeeEntityView>( "","ul li[rpsid='dd2eb268-642b-4bde-aefc-fa34e1963416']","",this);
 

        }
        public IRPSSaveButton<EmployeeEntityView> SaveButton { get; set; } 
        public IRPSButton<EmployeeEntityView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeEntityView,EmployeeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeEntityView,EmployeeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<EmployeeEntityView> CodEmployee { get; set; } 
        public IRPSTextBox<EmployeeEntityView> Description { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDCategory { get; set; } 
        public IRPSComboBox<EmployeeEntityView> Type { get; set; } 
        public IRPSTextBox<EmployeeEntityView> InactivateDate { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<EmployeeEntityView> CodUser { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDSite { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDDepartment { get; set; } 
        public IRPSCheckbox<EmployeeEntityView> Fictitious { get; set; } 
        public IRPSCheckbox<EmployeeEntityView> BottleNeck { get; set; } 
        public IRPSCheckbox<EmployeeEntityView> ImputationOnLineUnique { get; set; } 
        public IRPSTextBox<EmployeeEntityView> DisplayOrder { get; set; } 
        public IRPSComboBox<EmployeeEntityView> ManageImputations { get; set; } 
        public IRPSCheckbox<EmployeeEntityView> MaintenanceWorker { get; set; } 
        public IRPSTextBox<EmployeeEntityView> MaintenanceWorkerPwd { get; set; } 
        public IRPSTextBox<EmployeeEntityView> MaintenanceWorkerPwdConfirm { get; set; } 
        public IRPSComboBox<EmployeeEntityView> CodCountry { get; set; } 
        public IRPSTextBox<EmployeeEntityView> ZipCode { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDState { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDCounty { get; set; } 
        public IRPSTextBox<EmployeeEntityView> Address { get; set; } 
        public IRPSTextBox<EmployeeEntityView> City { get; set; } 
        public IRPSTextBox<EmployeeEntityView> Phone { get; set; } 
        public IRPSTextBox<EmployeeEntityView> Email { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDTRAFlow { get; set; } 
        public IRPSComboBox<EmployeeEntityView> IDEmployeeAccType { get; set; } 
        public IRPSTextBox<EmployeeEntityView> VATNumber { get; set; } 
        public IRPSComboBox<EmployeeEntityView> CodBank { get; set; } 
        public IRPSTextBox<EmployeeEntityView> IBAN { get; set; } 
        public IRPSTextBox<EmployeeEntityView> ChipCode { get; set; } 
        public IRPSTextBox<EmployeeEntityView> ExternalCodEmployee { get; set; } 
        public IRPSButton<EmployeeEntityView,CuDistEmployeeFromHRPopUpDialogView> CuDistEmployeeFromHRPopUpNavigationCommandButton { get; set; } 
        public GENEmployeeQualifysCollectionEditor<EmployeeEntityView,EmployeeQualifyView> GENEmployeeQualifys { get; set; } 
        public EmployeeEducationsCollectionEditor<EmployeeEntityView,EmployeeQualifyView> EmployeeEducations { get; set; } 
        public TrainingPlanEmployeeConsultCollectionEditor<EmployeeEntityView,EmployeeQualifyView> TrainingPlanEmployeeConsult { get; set; } 
        public IRPSSection<EmployeeEntityView> GeneralData { get; set; } 
        public IRPSSection<EmployeeEntityView> Qualification { get; set; } 
        public IRPSSection<EmployeeEntityView> Education { get; set; } 
        public IRPSSection<EmployeeEntityView> PlanesFormacion { get; set; } 
        public IRPSSection<EmployeeEntityView> DPS { get; set; } 
        public Employee Screen { get; set; }
        public EmployeeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENEmployeeQualifysCollectionEditor<EmployeeEntityView,EmployeeQualifyView>:RPSCollectionEditor<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public  GENEmployeeQualifysGridView<EmployeeEntityView,EmployeeQualifyView> GridView {get;set;}
    }
    public partial class GENEmployeeQualifysGridView <EmployeeEntityView,EmployeeQualifyView> :  RPSGridView<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public GENEmployeeQualifysGridView(EmployeeEntityView currentView,EmployeeQualifyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<EmployeeEntityView>("","#d63b90f2-47ec-4b35-91bb-84361fa44534 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",true, this.CurrentView);
 
            DefaultQualify = RPSControlFactory.CreateRPSGridCheckBox<EmployeeEntityView>("","#d63b90f2-47ec-4b35-91bb-84361fa44534 .ag-row[role='row']@ROWINDEX [col-id='cDefaultQualify']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<EmployeeEntityView>("","#d63b90f2-47ec-4b35-91bb-84361fa44534 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Alternative = RPSControlFactory.CreateRPSGridCheckBox<EmployeeEntityView>("","#d63b90f2-47ec-4b35-91bb-84361fa44534 .ag-row[role='row']@ROWINDEX [col-id='cAlternative']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EmployeeEntityView> IDQualify { get; set; } 
        public IRPSGridCheckbox<EmployeeEntityView> DefaultQualify { get; set; } 
        public IRPSGridTextBox<EmployeeEntityView> Priority { get; set; } 
        public IRPSGridCheckbox<EmployeeEntityView> Alternative { get; set; } 
                     
    }
 
        public partial class EmployeeEducationsCollectionEditor<EmployeeEntityView,EmployeeQualifyView>:RPSCollectionEditor<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public  EmployeeEducationsGridView<EmployeeEntityView,EmployeeQualifyView> GridView {get;set;}
    }
    public partial class EmployeeEducationsGridView <EmployeeEntityView,EmployeeQualifyView> :  RPSGridView<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public EmployeeEducationsGridView(EmployeeEntityView currentView,EmployeeQualifyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Title = RPSControlFactory.CreateRPSGridTextBox<EmployeeEntityView>("","#d5eb938c-0d2c-48ef-9f46-a14b5696c655 .ag-row[role='row']@ROWINDEX [col-id='cTitle']","",true, this.CurrentView);
 
            IssueDate = RPSControlFactory.CreateRPSGridTextBox<EmployeeEntityView>("","#d5eb938c-0d2c-48ef-9f46-a14b5696c655 .ag-row[role='row']@ROWINDEX [col-id='cIssueDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmployeeEntityView> Title { get; set; } 
        public IRPSGridTextBox<EmployeeEntityView> IssueDate { get; set; } 
                     
    }
 
        public partial class TrainingPlanEmployeeConsultCollectionEditor<EmployeeEntityView,EmployeeQualifyView>:RPSCollectionEditor<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public  TrainingPlanEmployeeConsultGridView<EmployeeEntityView,EmployeeQualifyView> GridView {get;set;}
    }
    public partial class TrainingPlanEmployeeConsultGridView <EmployeeEntityView,EmployeeQualifyView> :  RPSGridView<EmployeeEntityView,EmployeeQualifyView> where EmployeeEntityView : class, IView where EmployeeQualifyView : class, IView
    {
        public TrainingPlanEmployeeConsultGridView(EmployeeEntityView currentView,EmployeeQualifyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TrainingPlan_DateReal = RPSControlFactory.CreateRPSGridTextBox<EmployeeEntityView>("","#73713b12-414d-461f-b33b-f8077c0ca5b0 .ag-row[role='row']@ROWINDEX [col-id='cTrainingPlan_DateReal']","",false, this.CurrentView);
 
            TrainingPlan_TrainingType = RPSControlFactory.CreateRPSGridTextBox<EmployeeEntityView>("","#73713b12-414d-461f-b33b-f8077c0ca5b0 .ag-row[role='row']@ROWINDEX [col-id='cTrainingPlan_TrainingType']","",false, this.CurrentView);
 
            TrainingPlan_GivenBy = RPSControlFactory.CreateRPSGridTextBox<EmployeeEntityView>("","#73713b12-414d-461f-b33b-f8077c0ca5b0 .ag-row[role='row']@ROWINDEX [col-id='cTrainingPlan_GivenBy']","",false, this.CurrentView);
 
            Training_TotalHours = RPSControlFactory.CreateRPSGridFormattedTextBox<EmployeeEntityView>("","#73713b12-414d-461f-b33b-f8077c0ca5b0 .ag-row[role='row']@ROWINDEX [col-id='cTraining_TotalHours']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmployeeEntityView> TrainingPlan_DateReal { get; set; } 
        public IRPSGridTextBox<EmployeeEntityView> TrainingPlan_TrainingType { get; set; } 
        public IRPSGridTextBox<EmployeeEntityView> TrainingPlan_GivenBy { get; set; } 
        public IRPSGridTextBox<EmployeeEntityView> Training_TotalHours { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmployeeQualifyView : View
    {
        public EmployeeQualifyView(Employee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeQualifyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeQualifyView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeQualifyView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EmployeeQualifyView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<EmployeeQualifyView>("dc70a6f2-360c-4900-a66e-b98489c39934","","",true, this);
 
            DefaultQualify = RPSControlFactory.CreateRPSCheckBox<EmployeeQualifyView>("d4236f1d-c33c-4b1f-bb87-9ac423973c6f","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<EmployeeQualifyView>("2fa45549-72ec-42c6-8d29-20e3c2cb79bf","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<EmployeeQualifyView>("9cda378b-1a99-4911-b4c1-ef65b54b0b7e","","",true, this);
 

        }
        public IRPSButton<EmployeeQualifyView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeQualifyView,EmployeeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeQualifyView,EmployeeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EmployeeQualifyView,EmployeeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<EmployeeQualifyView> IDQualify { get; set; } 
        public IRPSCheckbox<EmployeeQualifyView> DefaultQualify { get; set; } 
        public IRPSTextBox<EmployeeQualifyView> Priority { get; set; } 
        public IRPSCheckbox<EmployeeQualifyView> Alternative { get; set; } 
        public Employee Screen { get; set; }
        public EmployeeQualifyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeEducationView : View
    {
        public EmployeeEducationView(Employee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EmployeeEducationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EmployeeEducationView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EmployeeEducationView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EmployeeEducationView,EmployeeEntityView>( this,Screen.EmployeeEntityView);
 
            Title = RPSControlFactory.CreateRPSTextBox<EmployeeEducationView>("0e2d4e8b-ca07-4aca-bbd9-2b6081973685","","",true, this);
 
            IssueDate = RPSControlFactory.CreateRPSTextBox<EmployeeEducationView>("28e6bd79-ebad-439e-8e2c-877837287a4f","","",false, this);
 

        }
        public IRPSButton<EmployeeEducationView> DeleteButton { get; set; } 
        public IRPSButton<EmployeeEducationView,EmployeeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EmployeeEducationView,EmployeeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EmployeeEducationView,EmployeeEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<EmployeeEducationView> Title { get; set; } 
        public IRPSTextBox<EmployeeEducationView> IssueDate { get; set; } 
        public Employee Screen { get; set; }
        public EmployeeEducationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistEmployeeFromHRPopUpDialogView : View
    {
        public CuDistEmployeeFromHRPopUpDialogView(Employee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ImportCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeFromHRPopUpDialogView>( "d6fc8ba7-7f9b-4845-b978-1e4f49b45893","","",this);
 
            LinkCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeFromHRPopUpDialogView>( "8ccd19b8-bcaa-4a47-9bf1-60d661c98703","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeFromHRPopUpDialogView>( "9961caca-ac1d-47b0-8032-7e0947aff6f7","","",this);
 
            CollectionInit params_CuDistEmployeeView = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b1b56546-d9a7-429f-9b12-81201ecf7678",CSSSelectorGrid="",XPathGrid=""};
            CuDistEmployeeView = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistEmployeeViewCollectionEditor<CuDistEmployeeFromHRPopUpDialogView>,CuDistEmployeeFromHRPopUpDialogView>( params_CuDistEmployeeView,this);
 

        }
        public IRPSButton<CuDistEmployeeFromHRPopUpDialogView> ImportCommand { get; set; } 
        public IRPSButton<CuDistEmployeeFromHRPopUpDialogView> LinkCommand { get; set; } 
        public IRPSButton<CuDistEmployeeFromHRPopUpDialogView> CancelCommand { get; set; } 
        public CuDistEmployeeViewCollectionEditor<CuDistEmployeeFromHRPopUpDialogView> CuDistEmployeeView { get; set; } 
        public Employee Screen { get; set; }
        public CuDistEmployeeFromHRPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistEmployeeViewCollectionEditor<CuDistEmployeeFromHRPopUpDialogView>:RPSCollectionEditor<CuDistEmployeeFromHRPopUpDialogView> where CuDistEmployeeFromHRPopUpDialogView : class, IView
    {
        public  CuDistEmployeeViewGridView<CuDistEmployeeFromHRPopUpDialogView> GridView {get;set;}
    }
    public partial class CuDistEmployeeViewGridView <CuDistEmployeeFromHRPopUpDialogView> :  RPSGridView<CuDistEmployeeFromHRPopUpDialogView> where CuDistEmployeeFromHRPopUpDialogView : class, IView
    {
        public CuDistEmployeeViewGridView(CuDistEmployeeFromHRPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistEmployeeView_HRCodEmployee = RPSControlFactory.CreateRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView>("","#b1b56546-d9a7-429f-9b12-81201ecf7678 .ag-row[role='row']@ROWINDEX [col-id='cCuDistEmployeeView_HRCodEmployee']","",false, this.CurrentView);
 
            CuDistEmployeeView_EmployeeName = RPSControlFactory.CreateRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView>("","#b1b56546-d9a7-429f-9b12-81201ecf7678 .ag-row[role='row']@ROWINDEX [col-id='cCuDistEmployeeView_EmployeeName']","",false, this.CurrentView);
 
            CodEmployeeRPS = RPSControlFactory.CreateRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView>("","#b1b56546-d9a7-429f-9b12-81201ecf7678 .ag-row[role='row']@ROWINDEX [col-id='cCodEmployeeRPS']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView> CuDistEmployeeView_HRCodEmployee { get; set; } 
        public IRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView> CuDistEmployeeView_EmployeeName { get; set; } 
        public IRPSGridTextBox<CuDistEmployeeFromHRPopUpDialogView> CodEmployeeRPS { get; set; } 
                     
    }
 
    }
  
    

}
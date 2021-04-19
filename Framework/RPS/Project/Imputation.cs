    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Imputation
{
    //RPS VERSION 1.0.0.0
    public partial class Imputation:Screen
    {
        public Imputation():base()
        {
            this.URL = "project.imputation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationVMQueryView  = new ImputationVMQueryView(this); 
            ImputationVMEntityView  = new ImputationVMEntityView(this); 
            ImputationVMQueryView.InitializeControls(); 
            ImputationVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationVMQueryView ImputationVMQueryView {get; set; } 
            public ImputationVMEntityView ImputationVMEntityView {get; set; } 
    }
            
    public partial class ImputationVMQueryView : View
    {
        public ImputationVMQueryView(Imputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationVMQueryView,ImputationVMEntityView>( this,Screen.ImputationVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationVMQueryView>( this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<ImputationVMQueryView>("242275dd-be86-4dec-9745-e2091aef93a6","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<ImputationVMQueryView>("33364811-69ac-40c6-925c-ce2b7a185366","","",false, this);
 
            UILstProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<ImputationVMQueryView>("bd4db8ab-4ba5-429b-9b5b-ac8de6565605","","",false, this);
 
            UIWarning = RPSControlFactory.CreateRPSComboBox<ImputationVMQueryView>("27f58944-ce2f-4205-9c30-0ff4ad4085fa","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<ImputationVMQueryView>("3d6fdfb5-9271-4f1a-8f11-00a50fb7b6ef","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<ImputationVMQueryView>("c13cf6d0-3865-49bf-a971-f706677db748","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ImputationVMQueryView>("520f8f05-24b5-4467-a742-3832e1a6600d","","",false, this);
 
            UIGetEmployeeImputations = RPSControlFactory.CreateRPSCheckBox<ImputationVMQueryView>("2d077b8d-9966-4769-93ae-05664d448775","","",false, this);
 
            UILstEmployee = RPSControlFactory.CreateRPSCollectionComboBox<ImputationVMQueryView>("80652188-dcff-4f8f-97b8-03b7847a02bc","","",false, this);
 
            UIGetMachineImputations = RPSControlFactory.CreateRPSCheckBox<ImputationVMQueryView>("a2f7a6ca-3985-4498-ab20-37ed37159e40","","",false, this);
 
            UILstMachine = RPSControlFactory.CreateRPSCollectionComboBox<ImputationVMQueryView>("bca6bc23-63b6-4480-b6cb-02fd46b349ee","","",false, this);
 
            UIGetToolImputations = RPSControlFactory.CreateRPSCheckBox<ImputationVMQueryView>("fab23a1d-5a51-41d5-a681-8f1bd83332fd","","",false, this);
 
            UILstTool = RPSControlFactory.CreateRPSCollectionComboBox<ImputationVMQueryView>("350eb7ff-7e7d-4839-b579-aeedebad4a6f","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationVMQueryView>( "3aa98dd0-0929-4ceb-b79c-b6d11ab3513f","","",this);
 
            CollectionInit params_Imputation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="84f33f63-2f7b-4ddb-ba2e-89c2d3d58421",CSSSelectorGrid="",XPathGrid=""};
            Imputation = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationCollectionEditor<ImputationVMQueryView,ImputationVMEntityView>,ImputationVMQueryView,ImputationVMEntityView>( params_Imputation,this,Screen.ImputationVMEntityView);
 

        }
        public IRPSButton<ImputationVMQueryView,ImputationVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationVMQueryView> UISite { get; set; } 
        public IRPSCollectionComboBox<ImputationVMQueryView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<ImputationVMQueryView> UILstProjectTask { get; set; } 
        public IRPSComboBox<ImputationVMQueryView> UIWarning { get; set; } 
        public IRPSTextBox<ImputationVMQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<ImputationVMQueryView> UIDateTo { get; set; } 
        public IRPSCheckbox<ImputationVMQueryView> UIGetIncludeChild { get; set; } 
        public IRPSCheckbox<ImputationVMQueryView> UIGetEmployeeImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationVMQueryView> UILstEmployee { get; set; } 
        public IRPSCheckbox<ImputationVMQueryView> UIGetMachineImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationVMQueryView> UILstMachine { get; set; } 
        public IRPSCheckbox<ImputationVMQueryView> UIGetToolImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationVMQueryView> UILstTool { get; set; } 
        public IRPSButton<ImputationVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationCollectionEditor<ImputationVMQueryView,ImputationVMEntityView> Imputation { get; set; } 
        public Imputation Screen { get; set; }
        public ImputationVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationCollectionEditor<ImputationVMQueryView,ImputationVMEntityView>:RPSCollectionEditor<ImputationVMQueryView,ImputationVMEntityView> where ImputationVMQueryView : class, IView where ImputationVMEntityView : class, IView
    {
        public  ImputationGridView<ImputationVMQueryView,ImputationVMEntityView> GridView {get;set;}
    }
    public partial class ImputationGridView <ImputationVMQueryView,ImputationVMEntityView> :  RPSGridView<ImputationVMQueryView,ImputationVMEntityView> where ImputationVMQueryView : class, IView where ImputationVMEntityView : class, IView
    {
        public ImputationGridView(ImputationVMQueryView currentView,ImputationVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Imputation_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationVMQueryView>("","#84f33f63-2f7b-4ddb-ba2e-89c2d3d58421 .ag-row[role='row']@ROWINDEX [col-id='cImputation_ImputationDate']","",false, this.CurrentView);
 
            Imputation_Descripton = RPSControlFactory.CreateRPSGridTextBox<ImputationVMQueryView>("","#84f33f63-2f7b-4ddb-ba2e-89c2d3d58421 .ag-row[role='row']@ROWINDEX [col-id='cImputation_Descripton']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationVMQueryView> Imputation_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationVMQueryView> Imputation_Descripton { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationVMEntityView : View
    {
        public ImputationVMEntityView(Imputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationVMEntityView,ImputationVMQueryView>( this,Screen.ImputationVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationVMEntityView,ImputationVMQueryView>( this,Screen.ImputationVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationVMEntityView>("655bdfe0-b816-4cf1-baa1-05645c685f77","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("e41f15e5-e0e9-46cd-bc00-d39221b98582","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("412bfc25-a4df-4640-bb87-5885caba8d5f","","",true, this);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<ImputationVMEntityView>("1c518790-6182-4e20-a450-defa2a1880d6","","",true, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("2e350eb5-905f-4304-86bd-5c397882b5f1","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("608c1d53-b993-46ff-aa83-a146beded2df","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("546f93f3-c4cc-4772-b580-eeb880e19e9e","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ImputationVMEntityView>("68a71c48-630a-4814-93c8-3894df4313a1","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ImputationVMEntityView>("b7836c29-add9-4fac-905c-3fc2cd64274d","","",true, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationVMEntityView>("db8a9a32-259c-4cb4-a371-0b664096d638","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationVMEntityView>("56c68408-365e-47da-a66e-b70136db90dc","","",false, this);
 
            PendingTime = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("62696eb8-c5b8-425b-8e65-dda4c564452f","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("12f3885a-1d33-4ec9-81f3-7e05d85c5eb9","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("557ced33-1ec6-4cfe-83b4-cd1e644296c0","","",true, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationVMEntityView>("496fdbcf-c27f-4e13-a4aa-fdb84aa7f096","","",true, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("7edf6c65-5978-4ac2-ad38-a407ad6edb2c","","",false, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("b6e18fa6-e574-41a7-8d4f-5462a27a6180","","",true, this);
 
            NumberResources = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("f565d0b4-125d-47fe-9c24-14d820b64f81","","",true, this);
 
            Descripton = RPSControlFactory.CreateRPSTextBox<ImputationVMEntityView>("fe83daf0-0ae7-44ea-8493-646c3570a935","","",false, this);
 
            IDPROResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("b6e9feca-255e-407c-a5fa-472b039a6ace","","",false, this);
 
            IDPROResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("2737ad52-5ba1-49f0-b18b-adc07885d01f","","",false, this);
 
            IDPROResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("6b17f2f4-ae20-4699-b962-5d3e84bc3110","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<ImputationVMEntityView>("8f4d035d-9161-4ab4-b818-432f231e3620","","",true, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("a82a0e73-426a-4e81-a174-a58b047c4484","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("7cba037e-1f00-428f-8a41-b76e910fd03b","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("2e9963dc-5f31-4e89-b8d2-6fe537b8528d","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationVMEntityView>("7e91b0a0-0973-450a-a734-af647ebd7fde","","",true, this);
 
            IDPROWarning = RPSControlFactory.CreateRPSComboBox<ImputationVMEntityView>("c47041ea-b2e8-4f36-9d83-8e50452ec1cc","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<ImputationVMEntityView>("f885e55c-9df2-4fbb-83c5-ce04810b1d84","","",false, this);
 
            Billable = RPSControlFactory.CreateRPSCheckBox<ImputationVMEntityView>("4a71a32a-796a-4640-9d6b-d8d8cf9bdccb","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<ImputationVMEntityView>("04afb63e-916b-4fea-9fcf-2e5761a2d364","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationVMEntityView>("dcbeb432-8b34-478b-8416-b0f97029c19c","","",true, this);
 
            ImputationMaterialNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationVMEntityView>( "e487fb07-fd6b-43f9-a9f4-dd22b953c068","","",this);
 

        }
        public IRPSSaveButton<ImputationVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationVMEntityView,ImputationVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationVMEntityView,ImputationVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDPROTask { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> ResourceType { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDResourceMachine { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDResourceTool { get; set; } 
        public IRPSDurationTextBox<ImputationVMEntityView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ImputationVMEntityView> ExecutionTime { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> StartHour { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> EndHour { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> PendingTime { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> PercentProgress { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDHourType { get; set; } 
        public IRPSCheckbox<ImputationVMEntityView> Unproductive { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDUnproductiveType { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> DedicationPercent { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> NumberResources { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> Descripton { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDPROResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDPROResourceMachine { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDPROResourceTool { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> CostType { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> CostQuantity { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDMachine { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> CostAmountReal { get; set; } 
        public IRPSComboBox<ImputationVMEntityView> IDPROWarning { get; set; } 
        public IRPSTextBox<ImputationVMEntityView> CodDeliveryNote { get; set; } 
        public IRPSCheckbox<ImputationVMEntityView> Billable { get; set; } 
        public IRPSCheckbox<ImputationVMEntityView> Invoiced { get; set; } 
        public IRPSCheckbox<ImputationVMEntityView> IsPosting { get; set; } 
        public IRPSButton<ImputationVMEntityView> ImputationMaterialNavigationCommandButton { get; set; } 
        public Imputation Screen { get; set; }
        public ImputationVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
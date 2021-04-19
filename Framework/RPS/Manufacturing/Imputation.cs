    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Imputation
{
    //RPS VERSION 1.0.0.0
    public partial class Imputation:Screen
    {
        public Imputation():base()
        {
            this.URL = "manufacturing.imputation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationMOVMQueryView  = new ImputationMOVMQueryView(this); 
            ImputationMOVMEntityView  = new ImputationMOVMEntityView(this); 
            ImputationMOVMQueryView.InitializeControls(); 
            ImputationMOVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationMOVMQueryView ImputationMOVMQueryView {get; set; } 
            public ImputationMOVMEntityView ImputationMOVMEntityView {get; set; } 
    }
            
    public partial class ImputationMOVMQueryView : View
    {
        public ImputationMOVMQueryView(Imputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationMOVMQueryView,ImputationMOVMEntityView>( this,Screen.ImputationMOVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationMOVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ImputationMOVMQueryView>("48f22527-f1d9-464b-a2e0-ddc84e672627","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("3b47500e-786a-4dc8-819b-48834eebbb56","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("2467944e-16e8-41c2-b52b-0ba18aabb3b3","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImputationMOVMQueryView>("3dbd261a-7f18-4579-a806-bbeb109d58ba","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ImputationMOVMQueryView>("1e17deaa-4f1c-4e00-b7c5-a9bbf8a29a6b","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ImputationMOVMQueryView>("0b3f247e-a5af-4bda-a150-d791a317ecb4","","",false, this);
 
            UIGetEmployeeImputations = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMQueryView>("35e22f08-d6c4-410a-ae1e-1bab366550a0","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("49ca2380-0292-4c8f-8818-b9cb6947eadf","","",false, this);
 
            UIGetMachineImputations = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMQueryView>("0fa2843e-3d7d-4a94-bafa-4b3134b8282d","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("ede26a48-a654-41f4-870f-5c5f6d7bdae9","","",false, this);
 
            UIGetToolImputations = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMQueryView>("cd6ec4d8-7aa1-492a-a063-99d3ff8cd711","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("69b8174f-6316-41ca-bf80-87b5d439d053","","",false, this);
 
            UIGetQualityImputations = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMQueryView>("a96e60a7-8422-4dec-b9e1-099af91a4964","","",false, this);
 
            EmployeeQuality = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMOVMQueryView>("b0fd4cc9-cea1-4697-a6ac-7e858171a927","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationMOVMQueryView>( "09fc04ef-20f0-4bc7-b340-f5d906d003c4","","",this);
 
            CollectionInit params_Imputation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ecf3e1c3-511f-4328-91ed-4de347da7d8e",CSSSelectorGrid="",XPathGrid=""};
            Imputation = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationCollectionEditor<ImputationMOVMQueryView,ImputationMOVMEntityView>,ImputationMOVMQueryView,ImputationMOVMEntityView>( params_Imputation,this,Screen.ImputationMOVMEntityView);
 

        }
        public IRPSButton<ImputationMOVMQueryView,ImputationMOVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationMOVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationMOVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> MOTask { get; set; } 
        public IRPSTextBox<ImputationMOVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ImputationMOVMQueryView> DateTo { get; set; } 
        public IRPSTextBox<ImputationMOVMQueryView> UIInternalCode { get; set; } 
        public IRPSCheckbox<ImputationMOVMQueryView> UIGetEmployeeImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> Employee { get; set; } 
        public IRPSCheckbox<ImputationMOVMQueryView> UIGetMachineImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> Machine { get; set; } 
        public IRPSCheckbox<ImputationMOVMQueryView> UIGetToolImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> Tool { get; set; } 
        public IRPSCheckbox<ImputationMOVMQueryView> UIGetQualityImputations { get; set; } 
        public IRPSCollectionComboBox<ImputationMOVMQueryView> EmployeeQuality { get; set; } 
        public IRPSButton<ImputationMOVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationCollectionEditor<ImputationMOVMQueryView,ImputationMOVMEntityView> Imputation { get; set; } 
        public Imputation Screen { get; set; }
        public ImputationMOVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationCollectionEditor<ImputationMOVMQueryView,ImputationMOVMEntityView>:RPSCollectionEditor<ImputationMOVMQueryView,ImputationMOVMEntityView> where ImputationMOVMQueryView : class, IView where ImputationMOVMEntityView : class, IView
    {
        public  ImputationGridView<ImputationMOVMQueryView,ImputationMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationGridView <ImputationMOVMQueryView,ImputationMOVMEntityView> :  RPSGridView<ImputationMOVMQueryView,ImputationMOVMEntityView> where ImputationMOVMQueryView : class, IView where ImputationMOVMEntityView : class, IView
    {
        public ImputationGridView(ImputationMOVMQueryView currentView,ImputationMOVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMOVMQueryView>("","#ecf3e1c3-511f-4328-91ed-4de347da7d8e .ag-row[role='row']@ROWINDEX [col-id='cImputationMO_ImputationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMOVMQueryView> ImputationMO_ImputationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMOVMEntityView : View
    {
        public ImputationMOVMEntityView(Imputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationMOVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationMOVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationMOVMEntityView,ImputationMOVMQueryView>( this,Screen.ImputationMOVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationMOVMEntityView,ImputationMOVMQueryView>( this,Screen.ImputationMOVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("15cb29b1-0cb5-4ee1-a828-aa17f076f200","","",true, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("d26cf7c2-8c78-473b-aaad-ef1da65e26d4","","",true, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("a813e9aa-71d4-4d1d-9515-875a1cbedf6a","","",true, this);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("da6ea5a1-6c45-4f32-9998-55708f5234a7","","",false, this);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<ImputationMOVMEntityView>("bb88fdfd-3af4-4c7c-bf61-2d364f8c4e9a","","",true, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("5ea8d78a-d3a3-414c-a309-5170fbcac346","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("c2189e7e-b783-4b41-8755-df2e4230f8a5","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("1ef75b74-0d8d-413c-8538-238a9fda495b","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("79a3a43b-9086-4eb4-a717-abd0d0463f3d","","",true, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("ad92f4ba-2a98-430e-a7e6-2a7653192b36","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ImputationMOVMEntityView>("a9b27ca3-a52d-4cea-ba6e-fd354ca75450","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ImputationMOVMEntityView>("1a137309-a239-4e35-88e2-0011ac593d69","","",true, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSDurationTextBox<ImputationMOVMEntityView>("6be15e78-fef7-4299-a952-e169b4282c5a","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("5e152ef2-ac7b-42d3-8137-7f54b1f5b31d","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("62d3b766-76ba-48ea-b04d-2383d8d01343","","",true, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMEntityView>("6a6882fc-2aca-4f4b-9d41-7725657abf0d","","",true, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("0a1a37b3-2cac-422b-9b08-652430d27182","","",false, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("9475682b-ac6b-473b-b84b-71cedde29b16","","",true, this);
 
            NumberResources = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("aa6d1f8d-86b0-4747-8320-54843e996fc5","","",true, this);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("dd2d8d96-292e-4e4f-99cb-470ca387b8cb","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMEntityView>("a6a631a8-298c-446f-8647-1edd9f772c70","","",true, this);
 
            PendingQuantityOnly = RPSControlFactory.CreateRPSCheckBox<ImputationMOVMEntityView>("c6191c65-9a29-4737-b883-bc81bcaad72d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("ee049058-7bbd-453f-b8a1-bf03eb1ecae1","","",false, this);
 
            IDMOResourceEmployee = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("3b9eb0cb-f90e-4c90-b49e-10c8166bceb4","","",false, this);
 
            IDMOResourceMachine = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("540e5a5b-6ece-4387-9de5-c8dd2c029d1e","","",false, this);
 
            IDMOResourceTool = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("a55c95e2-1f50-415c-be20-1caed3243c10","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ImputationMOVMEntityView>("f6ee99a3-2b55-4361-bf71-0c7f5146f5db","","",false, this);
 
            CostType = RPSControlFactory.CreateRPSEnumComboBox<ImputationMOVMEntityView>("caf31a27-913a-41da-b712-1faa3e4d22b2","","",true, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("838f21f7-6d0c-4a5c-bad9-689887e80a3e","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ImputationMOVMEntityView>("4901a834-a9f9-424f-a850-d587300c7e9a","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("fa67d404-1d7a-4760-b9dd-9c0761f2f20a","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMOVMEntityView>("39e8b7fe-17ca-4eb3-99cc-e573a5835183","","",true, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMOVMEntityView>( "8c1e526d-9724-453f-b0ac-bd0f7398959f","","",this);
 
            ImputationMaterialNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMOVMEntityView>( "7aae14ac-5866-41e8-ab12-86374008153e","","",this);
 
            CollectionInit params_ImputationRejects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49ed2f1b-12a3-47bf-ac5f-fee018467772",CSSSelectorGrid="",XPathGrid=""};
            ImputationRejects = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationRejectsCollectionEditor<ImputationMOVMEntityView>,ImputationMOVMEntityView>( params_ImputationRejects,this);
 

        }
        public IRPSSaveButton<ImputationMOVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationMOVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMOVMEntityView,ImputationMOVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMOVMEntityView,ImputationMOVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDMOTask { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> WorkSheetNumber { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> ResourceType { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDResourceMachine { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDResourceTool { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> StartHour { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> EndHour { get; set; } 
        public IRPSDurationTextBox<ImputationMOVMEntityView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ImputationMOVMEntityView> ExecutionTime { get; set; } 
        public IRPSDurationTextBox<ImputationMOVMEntityView> RepetitionTime { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> PercentProgress { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDHourType { get; set; } 
        public IRPSCheckbox<ImputationMOVMEntityView> Unproductive { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDUnproductiveType { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> DedicationPercent { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> NumberResources { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> ManufacturedQuantity { get; set; } 
        public IRPSCheckbox<ImputationMOVMEntityView> IsPosting { get; set; } 
        public IRPSCheckbox<ImputationMOVMEntityView> PendingQuantityOnly { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> Description { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDMOResourceEmployee { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDMOResourceMachine { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDMOResourceTool { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> DocumentNumber { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> CostType { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> CostQuantity { get; set; } 
        public IRPSComboBox<ImputationMOVMEntityView> IDMachine { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMOVMEntityView> CostAmountReal { get; set; } 
        public IRPSButton<ImputationMOVMEntityView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<ImputationMOVMEntityView> ImputationMaterialNavigationCommandButton { get; set; } 
        public ImputationRejectsCollectionEditor<ImputationMOVMEntityView> ImputationRejects { get; set; } 
        public Imputation Screen { get; set; }
        public ImputationMOVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationRejectsCollectionEditor<ImputationMOVMEntityView>:RPSCollectionEditor<ImputationMOVMEntityView> where ImputationMOVMEntityView : class, IView
    {
        public  ImputationRejectsGridView<ImputationMOVMEntityView> GridView {get;set;}
    }
    public partial class ImputationRejectsGridView <ImputationMOVMEntityView> :  RPSGridView<ImputationMOVMEntityView> where ImputationMOVMEntityView : class, IView
    {
        public ImputationRejectsGridView(ImputationMOVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RejectedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMOVMEntityView>("","#49ed2f1b-12a3-47bf-ac5f-fee018467772 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQuantity']","",true, this.CurrentView);
 
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<ImputationMOVMEntityView>("","#49ed2f1b-12a3-47bf-ac5f-fee018467772 .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMOVMEntityView> RejectedQuantity { get; set; } 
        public IRPSGridComboBox<ImputationMOVMEntityView> IDRejectionCause { get; set; } 
                     
    }
 
    }
  
    

}
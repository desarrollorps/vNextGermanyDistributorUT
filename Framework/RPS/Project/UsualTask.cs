    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.UsualTask
{
    //RPS VERSION 1.0.0.0
    public partial class UsualTask:Screen
    {
        public UsualTask():base()
        {
            this.URL = "project.usualtask";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UsualTaskCollectionView  = new UsualTaskCollectionView(this); 
            UsualTaskEntityView  = new UsualTaskEntityView(this); 
            UsualTaskCollectionView.InitializeControls(); 
            UsualTaskEntityView.InitializeControls(); 
           
        }
      
            public UsualTaskCollectionView UsualTaskCollectionView {get; set; } 
            public UsualTaskEntityView UsualTaskEntityView {get; set; } 
    }
            
    public partial class UsualTaskCollectionView : View
    {
        public UsualTaskCollectionView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UsualTaskCollectionView,UsualTaskEntityView>( this,Screen.UsualTaskEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0fe06e57-426d-4de7-86fe-e19c1e5379ae",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UsualTaskCollectionView,UsualTaskEntityView>( params_MainConsult,this,Screen.UsualTaskEntityView);
 

        }
        public IRPSButton<UsualTaskCollectionView,UsualTaskEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UsualTaskCollectionView,UsualTaskEntityView> MainConsult { get; set; } 
        public UsualTask Screen { get; set; }
        public UsualTaskCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UsualTaskEntityView : View
    {
        public UsualTaskEntityView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UsualTaskEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UsualTaskEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UsualTaskEntityView,UsualTaskCollectionView>( this,Screen.UsualTaskCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UsualTaskEntityView,UsualTaskCollectionView>( this,Screen.UsualTaskCollectionView);
 
            CodPROUsualTask = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("6c02ba58-2953-4643-a639-89f666af0712","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("2bde8d91-1b31-4276-bbc4-896043f7f9bc","","",false, this);
 
            IDPROTaskType = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("b6ba3c6f-d787-4fd4-ae54-50844df0fa10","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("852cbb75-73db-428d-856b-aa110738ad72","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("22bc928b-6586-436d-a37b-f048da6696fe","","",false, this);
 
            ResEmployeeDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("b741e6c3-74c9-4e61-8d5a-9d0997fe3bf6","","",false, this);
 
            ResEmployeePlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("5b88042f-e8d1-498e-8a4b-96b411446217","","",true, this);
 
            ResEmployeeDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskEntityView>("4b4f4db8-0de1-4e7c-89a3-ff3b4b44f654","","",true, this);
 
            IDResEmployeeBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("e4ecabfd-0b5f-471b-99e8-47be4e86045c","","",false, this);
 
            ResEmployeeVariable = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("1f807a0e-8826-44f5-bc25-2fc4f2232055","","",true, this);
 
            ResEmployeeDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskEntityView>("0b63925c-9c32-460a-a523-8d9e166de514","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("4e3d779f-709f-481c-beb4-7b823d1a8e9b","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("3e4083e8-e3fb-4994-8fdc-7fe436adf337","","",false, this);
 
            ResMachineDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("a02d9481-d06c-4358-886d-5e68cd692446","","",false, this);
 
            ResMachinePlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("b673bfb1-4541-46d8-8594-a3f24f6dbcf3","","",true, this);
 
            ResMachineDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskEntityView>("92ad40b6-63b0-4c84-b553-90c7c84aa57f","","",true, this);
 
            IDResMachineBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("03536e31-c8fc-4169-b1ab-dcae8204f6cb","","",false, this);
 
            ResMachineLinkedToEmployee = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("78dfa14c-a927-4a59-a686-99f0af9e7254","","",true, this);
 
            ResMachineVariable = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("ae329139-aa6f-4c6e-bbf8-e13ef35b6c1b","","",true, this);
 
            ResMachineDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskEntityView>("3a3f6d55-aa6a-4844-bea4-87cf9cda3b80","","",true, this);
 
            ResMachineCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskEntityView>("53243fc7-0248-4104-ae4a-8c8653a793d9","","",true, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("21959f32-9713-4b41-8946-edc95b57a2ab","","",false, this);
 
            ResToolDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("5192bc67-8926-4a81-8b22-da2a597df366","","",false, this);
 
            ResToolPlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("9b785828-7505-4aaf-8220-836d798ed346","","",true, this);
 
            ResToolDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskEntityView>("1795ab52-2170-463d-8fac-406292c88984","","",true, this);
 
            IDResToolBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskEntityView>("42e10a1c-1586-4a68-901f-c1b94dc2b60b","","",false, this);
 
            ResToolDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskEntityView>("85ee468a-7f0a-4ede-a81f-48b14c674392","","",true, this);
 
            ResToolTimeUnit = RPSControlFactory.CreateRPSEnumComboBox<UsualTaskEntityView>("38ebb883-61e8-479a-b93b-1d1595b2495a","","",true, this);
 
            ResToolLinkedToEmployee = RPSControlFactory.CreateRPSCheckBox<UsualTaskEntityView>("10af5078-0dbf-4895-9d1b-a7ea097abcb9","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<UsualTaskEntityView>("0dd6f058-71ee-4858-8204-0d17ebdd680f","","",false, this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<UsualTaskEntityView>( "","ul li[rpsid='eb92e948-9a55-49b6-b0dc-211ed3f17e7f']","",this);
 
            SectionComments = RPSControlFactory.CreateRPSSection<UsualTaskEntityView>( "","ul li[rpsid='931535cd-44ae-4d6b-8aff-a629b60da483']","",this);
 

        }
        public IRPSSaveButton<UsualTaskEntityView> SaveButton { get; set; } 
        public IRPSButton<UsualTaskEntityView> DeleteButton { get; set; } 
        public IRPSButton<UsualTaskEntityView,UsualTaskCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UsualTaskEntityView,UsualTaskCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> CodPROUsualTask { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> Description { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDPROTaskType { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDQualify { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResEmployeeDescription { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResEmployeePlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskEntityView> ResEmployeeDuration { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDResEmployeeBudgetCategory { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResEmployeeVariable { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResEmployeeDedicationPercent { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDMachine { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDMachineGroup { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResMachineDescription { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResMachinePlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskEntityView> ResMachineDuration { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDResMachineBudgetCategory { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResMachineLinkedToEmployee { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResMachineVariable { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResMachineDedicationPercent { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResMachineCostQuantity { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDTool { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResToolDescription { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResToolPlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskEntityView> ResToolDuration { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> IDResToolBudgetCategory { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> ResToolDedicationPercent { get; set; } 
        public IRPSComboBox<UsualTaskEntityView> ResToolTimeUnit { get; set; } 
        public IRPSCheckbox<UsualTaskEntityView> ResToolLinkedToEmployee { get; set; } 
        public IRPSTextBox<UsualTaskEntityView> Notes { get; set; } 
        public IRPSSection<UsualTaskEntityView> SectionGeneral { get; set; } 
        public IRPSSection<UsualTaskEntityView> SectionComments { get; set; } 
        public UsualTask Screen { get; set; }
        public UsualTaskEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
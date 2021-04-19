    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.UsualTask
{
    //RPS VERSION 1.0.0.0
    public partial class UsualTask:Screen
    {
        public UsualTask():base()
        {
            this.URL = "manufacturing.usualtask";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UsualTaskSTRCollectionView  = new UsualTaskSTRCollectionView(this); 
            UsualTaskSTREntityView  = new UsualTaskSTREntityView(this); 
            UsualTaskSTRCollectionView.InitializeControls(); 
            UsualTaskSTREntityView.InitializeControls(); 
           
        }
      
            public UsualTaskSTRCollectionView UsualTaskSTRCollectionView {get; set; } 
            public UsualTaskSTREntityView UsualTaskSTREntityView {get; set; } 
    }
            
    public partial class UsualTaskSTRCollectionView : View
    {
        public UsualTaskSTRCollectionView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UsualTaskSTRCollectionView,UsualTaskSTREntityView>( this,Screen.UsualTaskSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3d192d48-c634-40d5-a866-09577438bc12",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UsualTaskSTRCollectionView,UsualTaskSTREntityView>( params_MainConsult,this,Screen.UsualTaskSTREntityView);
 

        }
        public IRPSButton<UsualTaskSTRCollectionView,UsualTaskSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UsualTaskSTRCollectionView,UsualTaskSTREntityView> MainConsult { get; set; } 
        public UsualTask Screen { get; set; }
        public UsualTaskSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UsualTaskSTREntityView : View
    {
        public UsualTaskSTREntityView(UsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UsualTaskSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UsualTaskSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UsualTaskSTREntityView,UsualTaskSTRCollectionView>( this,Screen.UsualTaskSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UsualTaskSTREntityView,UsualTaskSTRCollectionView>( this,Screen.UsualTaskSTRCollectionView);
 
            CodUsualTask = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("d1c7c2a5-c5bb-474d-b3ea-548c34d7f062","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("72242d5e-46bc-4945-9822-55166a988e31","","",false, this);
 
            IDTaskType = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("4414cbf8-15e3-477f-897c-b9bfa83a2ec3","","",false, this);
 
            ContrManQtyInDC = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("4c6d5569-ddb9-483a-be75-3401edbfe59b","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("f81447b8-f055-47cf-b054-68ccd5dadcf7","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("119eb22a-1b78-4a2d-a805-bd59a4167029","","",false, this);
 
            ResEmployeeDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("58654e51-2a51-4cdc-aa13-81be53f2d1f8","","",false, this);
 
            ResEmployeePlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("45b1727f-0412-49b0-ae6b-81a1548cc5df","","",true, this);
 
            ResEmployeeDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskSTREntityView>("a483d8c9-d14f-449a-9923-b4ce90cf6218","","",true, this);
 
            IDResEmployeeBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("e4c13db6-fa64-4ae2-80f9-5ab8fd935579","","",false, this);
 
            ResEmployeeVariable = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("36078a2f-181d-4ca2-9d5d-6bc71ae41b64","","",true, this);
 
            ResEmployeeDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskSTREntityView>("5d7cd977-0c81-45d7-8db9-437986782bb4","","",true, this);
 
            ResEmployeeParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<UsualTaskSTREntityView>("cef7d98e-0cbd-4ef1-a9b7-cec486f4c14b","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("87250231-4a67-479e-b1a7-de4492f5c0e0","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("ea697ead-b0bc-4c6a-a3e9-5f1a815c15d6","","",false, this);
 
            ResMachineDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("04017c92-c38b-45bf-9939-9498519ac7b4","","",false, this);
 
            ResMachinePlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("d0d415f9-5ea8-480b-b923-58f2d11a6961","","",true, this);
 
            ResMachineDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskSTREntityView>("da4cf349-a009-4243-a650-bd08804fa5eb","","",true, this);
 
            IDResMachineBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("90700b43-ed70-49ee-9ee8-fc87d8ef0764","","",false, this);
 
            ResMachineLinkedToEmployee = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("9ac6e48b-f2c0-4834-883a-6759da93941d","","",true, this);
 
            ResMachineVariable = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("10258d9c-d1af-49ed-96b5-7731ff9458b6","","",true, this);
 
            ResMachineDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskSTREntityView>("34868986-b0d2-4ad4-b463-1ad283f972f9","","",true, this);
 
            ResMachineCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskSTREntityView>("564548f2-17db-44dc-a467-dc36f190e506","","",true, this);
 
            ResMachineParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<UsualTaskSTREntityView>("c0922001-4918-4f56-ab98-c773e951af30","","",true, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("3e7d7840-8b24-4c42-a779-be4a1f32145b","","",false, this);
 
            ResToolDescription = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("224864ea-934f-4d0a-b8aa-20ff36673578","","",false, this);
 
            ResToolPlanify = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("ac10b2e1-5da5-4942-99bc-7cc7f469841d","","",true, this);
 
            ResToolDuration = RPSControlFactory.CreateRPSDurationTextBox<UsualTaskSTREntityView>("17d80a94-09e4-4c58-9245-f8dabe1a4c65","","",true, this);
 
            IDResToolBudgetCategory = RPSControlFactory.CreateRPSComboBox<UsualTaskSTREntityView>("42615618-6982-4225-8eec-03ee0c555afa","","",false, this);
 
            ResToolDedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<UsualTaskSTREntityView>("77245208-e561-4d49-842c-91d01d9284cd","","",true, this);
 
            ResToolTimeUnit = RPSControlFactory.CreateRPSEnumComboBox<UsualTaskSTREntityView>("7286039a-7ccb-4377-81b9-92e3016e1c2c","","",true, this);
 
            ResToolLinkedToEmployee = RPSControlFactory.CreateRPSCheckBox<UsualTaskSTREntityView>("d092da02-e5bd-4e98-aee3-b66c34ee0585","","",true, this);
 
            ResToolParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<UsualTaskSTREntityView>("3492c3cf-afb2-49be-ac1b-6fe348e872c4","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<UsualTaskSTREntityView>("b845622c-16e3-4480-84c0-5a8c07789574","","",false, this);
 
            SectionData = RPSControlFactory.CreateRPSSection<UsualTaskSTREntityView>( "","ul li[rpsid='8794c018-b84b-47f0-82d2-5f69170d9518']","",this);
 
            SectionComments = RPSControlFactory.CreateRPSSection<UsualTaskSTREntityView>( "","ul li[rpsid='6f510088-5cfd-4bf3-a7f8-8b7d75473fab']","",this);
 

        }
        public IRPSSaveButton<UsualTaskSTREntityView> SaveButton { get; set; } 
        public IRPSButton<UsualTaskSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<UsualTaskSTREntityView,UsualTaskSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UsualTaskSTREntityView,UsualTaskSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> CodUsualTask { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> Description { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDTaskType { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ContrManQtyInDC { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDEmployee { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDQualify { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResEmployeeDescription { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResEmployeePlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskSTREntityView> ResEmployeeDuration { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDResEmployeeBudgetCategory { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResEmployeeVariable { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResEmployeeDedicationPercent { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> ResEmployeeParticipateIn { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDMachine { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDMachineGroup { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResMachineDescription { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResMachinePlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskSTREntityView> ResMachineDuration { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDResMachineBudgetCategory { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResMachineLinkedToEmployee { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResMachineVariable { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResMachineDedicationPercent { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResMachineCostQuantity { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> ResMachineParticipateIn { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDTool { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResToolDescription { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResToolPlanify { get; set; } 
        public IRPSDurationTextBox<UsualTaskSTREntityView> ResToolDuration { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> IDResToolBudgetCategory { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> ResToolDedicationPercent { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> ResToolTimeUnit { get; set; } 
        public IRPSCheckbox<UsualTaskSTREntityView> ResToolLinkedToEmployee { get; set; } 
        public IRPSComboBox<UsualTaskSTREntityView> ResToolParticipateIn { get; set; } 
        public IRPSTextBox<UsualTaskSTREntityView> Notes { get; set; } 
        public IRPSSection<UsualTaskSTREntityView> SectionData { get; set; } 
        public IRPSSection<UsualTaskSTREntityView> SectionComments { get; set; } 
        public UsualTask Screen { get; set; }
        public UsualTaskSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
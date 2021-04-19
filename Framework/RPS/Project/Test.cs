    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Test
{
    //RPS VERSION 1.0.0.0
    public partial class Test:Screen
    {
        public Test():base()
        {
            this.URL = "project.test";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TestVMQueryView  = new TestVMQueryView(this); 
            TestVMEntityView  = new TestVMEntityView(this); 
            GenerateTestDialogView  = new GenerateTestDialogView(this); 
            NewWarningFromTestDialogView  = new NewWarningFromTestDialogView(this); 
            ChangeStateDialogView  = new ChangeStateDialogView(this); 
            ChangeTestsSituationChildDialogView  = new ChangeTestsSituationChildDialogView(this); 
            TestVMQueryView.InitializeControls(); 
            TestVMEntityView.InitializeControls(); 
            GenerateTestDialogView.InitializeControls(); 
            NewWarningFromTestDialogView.InitializeControls(); 
            ChangeStateDialogView.InitializeControls(); 
            ChangeTestsSituationChildDialogView.InitializeControls(); 
           
        }
      
            public TestVMQueryView TestVMQueryView {get; set; } 
            public TestVMEntityView TestVMEntityView {get; set; } 
            public GenerateTestDialogView GenerateTestDialogView {get; set; } 
            public NewWarningFromTestDialogView NewWarningFromTestDialogView {get; set; } 
            public ChangeStateDialogView ChangeStateDialogView {get; set; } 
            public ChangeTestsSituationChildDialogView ChangeTestsSituationChildDialogView {get; set; } 
    }
            
    public partial class TestVMQueryView : View
    {
        public TestVMQueryView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TestVMQueryView,TestVMEntityView>( this,Screen.TestVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<TestVMQueryView>( this);
 
            Project = RPSControlFactory.CreateRPSComboBox<TestVMQueryView>("6b12a7e4-9736-49f9-abf1-c5038546e469","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<TestVMQueryView>("ef2d4eef-6568-4181-96e4-c628d47b0b4e","","",false, this);
 
            SituationTest = RPSControlFactory.CreateRPSCollectionComboBox<TestVMQueryView>("c8cc9ea3-25bd-4244-ba2f-34a3f1a8c8de","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSCollectionComboBox<TestVMQueryView>("75d07e22-e12e-48e0-b256-198606a1a0ed","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<TestVMQueryView>("7aec2cd3-1d6e-405e-b04a-b58fbea63285","","",false, this);
 
            EmployeeRun = RPSControlFactory.CreateRPSComboBox<TestVMQueryView>("c57dab26-a36c-4fdf-91a2-f2464e92375d","","",false, this);
 
            OnlyPending = RPSControlFactory.CreateRPSCheckBox<TestVMQueryView>("96fa04ea-9d1b-402b-b1e3-175cf4f8b340","","",false, this);
 
            GenerateTestNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TestVMQueryView,GenerateTestDialogView>("e75a6f8a-fcd6-4315-af82-8514adfbcd8a","","", this,Screen.GenerateTestDialogView);
 
            DeleteTestsCommandButton = RPSControlFactory.CreateRPSButton<TestVMQueryView>( "adfb3123-742f-489d-965b-2c1be342e844","","",this);
 
            ChangeTestsSituationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TestVMQueryView,ChangeTestsSituationChildDialogView>("42897e80-1ca4-40d6-8a74-f6519655ef96","","", this,Screen.ChangeTestsSituationChildDialogView);
 
            CollectionInit params_TestByProject = new CollectionInit(){IDDescriptor = "ea94da1b-ec8e-4eaa-b0bd-69065fac6026",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="40409b67-dac8-46e4-8635-1aa675c5733c",CSSSelectorGrid="",XPathGrid=""};
            TestByProject = RPSControlFactory.RPSCreateCollectionWithGrid<TestByProjectCollectionEditor<TestVMQueryView,TestVMEntityView>,TestVMQueryView,TestVMEntityView>( params_TestByProject,this,Screen.TestVMEntityView);
 

        }
        public IRPSButton<TestVMQueryView,TestVMEntityView> NewButton { get; set; } 
        public IRPSButton<TestVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<TestVMQueryView> Project { get; set; } 
        public IRPSComboBox<TestVMQueryView> ProjectTask { get; set; } 
        public IRPSCollectionComboBox<TestVMQueryView> SituationTest { get; set; } 
        public IRPSCollectionComboBox<TestVMQueryView> ControlType { get; set; } 
        public IRPSComboBox<TestVMQueryView> Employee { get; set; } 
        public IRPSComboBox<TestVMQueryView> EmployeeRun { get; set; } 
        public IRPSCheckbox<TestVMQueryView> OnlyPending { get; set; } 
        public IRPSButton<TestVMQueryView,GenerateTestDialogView> GenerateTestNavigationCommandButton { get; set; } 
        public IRPSButton<TestVMQueryView> DeleteTestsCommandButton { get; set; } 
        public IRPSButton<TestVMQueryView,ChangeTestsSituationChildDialogView> ChangeTestsSituationChildNavigationCommandButton { get; set; } 
        public TestByProjectCollectionEditor<TestVMQueryView,TestVMEntityView> TestByProject { get; set; } 
        public Test Screen { get; set; }
        public TestVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TestByProjectCollectionEditor<TestVMQueryView,TestVMEntityView>:RPSCollectionEditor<TestVMQueryView,TestVMEntityView> where TestVMQueryView : class, IView where TestVMEntityView : class, IView
    {
        public  TestByProjectGridView<TestVMQueryView,TestVMEntityView> GridView {get;set;}
    }
    public partial class TestByProjectGridView <TestVMQueryView,TestVMEntityView> :  RPSGridView<TestVMQueryView,TestVMEntityView> where TestVMQueryView : class, IView where TestVMEntityView : class, IView
    {
        public TestByProjectGridView(TestVMQueryView currentView,TestVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Test_CodTest = RPSControlFactory.CreateRPSGridTextBox<TestVMQueryView>("","#40409b67-dac8-46e4-8635-1aa675c5733c .ag-row[role='row']@ROWINDEX [col-id='cTest_CodTest']","",false, this.CurrentView);
 
            Test_Description = RPSControlFactory.CreateRPSGridTextBox<TestVMQueryView>("","#40409b67-dac8-46e4-8635-1aa675c5733c .ag-row[role='row']@ROWINDEX [col-id='cTest_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TestVMQueryView> Test_CodTest { get; set; } 
        public IRPSGridTextBox<TestVMQueryView> Test_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class TestVMEntityView : View
    {
        public TestVMEntityView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TestVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TestVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TestVMEntityView,TestVMQueryView>( this,Screen.TestVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<TestVMEntityView,TestVMQueryView>( this,Screen.TestVMQueryView);
 
            CodTest = RPSControlFactory.CreateRPSTextBox<TestVMEntityView>("fb9d357b-784a-48c4-9f66-2696d78fdb47","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TestVMEntityView>("e4ad8339-1735-4fb7-87b9-583e54e6d65d","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("bd1383d0-9a8b-42d5-b9aa-0fb7c9dd40e2","","",true, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("58ff8032-d417-493c-9730-33d4ea247ed8","","",true, this);
 
            DateEntry = RPSControlFactory.CreateRPSTextBox<TestVMEntityView>("25393564-f1b8-40a9-b8aa-e7abce35ec10","","",false, this);
 
            IDControlType = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("1a9203b3-3afc-4cc7-a928-0910e76e9dd3","","",false, this);
 
            IDPROSituationTest = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("6568dba7-603e-41d9-bbc9-1b454b97becd","","",true, this);
 
            DateRun = RPSControlFactory.CreateRPSTextBox<TestVMEntityView>("fe3678d4-79dd-456a-99b7-10212100adc1","","",false, this);
 
            IDEmployeeRun = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("78175623-c868-4a4b-8e8c-38549a647d0f","","",false, this);
 
            IDEmployeeDefinition = RPSControlFactory.CreateRPSComboBox<TestVMEntityView>("27812cf2-63fb-4f68-bbc5-fa03cbb7c198","","",true, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<TestVMEntityView>("54ec4a17-034a-40cd-90f8-6dfcc443214e","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<TestVMEntityView>("f9dbc3b6-e160-4386-8542-ab115fba2102","","",false, this);
 
            NewWarningFromTestNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TestVMEntityView,NewWarningFromTestDialogView>("70ad55d3-edff-4d11-a794-fe0b65c8038a","","", this,Screen.NewWarningFromTestDialogView);
 
            ChangeStateNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TestVMEntityView,ChangeStateDialogView>("66d99987-a64c-4f47-803f-da8f6458bd09","","", this,Screen.ChangeStateDialogView);
 
            CollectionInit params_WarningFromTest = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e23949f6-cc8a-462c-be6e-8b1fb56dbfba",CSSSelectorGrid="",XPathGrid=""};
            WarningFromTest = RPSControlFactory.RPSCreateCollectionWithGrid<WarningFromTestCollectionEditor<TestVMEntityView,NewWarningFromTestDialogView>,TestVMEntityView,NewWarningFromTestDialogView>( params_WarningFromTest,this,Screen.NewWarningFromTestDialogView);
 
            General = RPSControlFactory.CreateRPSSection<TestVMEntityView>( "","ul li[rpsid='d01bc662-be9a-4fc9-aa63-90cebe5c9a04']","",this);
 
            Warning = RPSControlFactory.CreateRPSSection<TestVMEntityView>( "","ul li[rpsid='bf90b11a-8410-49ab-9061-1bdb2562354b']","",this);
 

        }
        public IRPSSaveButton<TestVMEntityView> SaveButton { get; set; } 
        public IRPSButton<TestVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<TestVMEntityView,TestVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TestVMEntityView,TestVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<TestVMEntityView> CodTest { get; set; } 
        public IRPSTextBox<TestVMEntityView> Description { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDProTask { get; set; } 
        public IRPSTextBox<TestVMEntityView> DateEntry { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDControlType { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDPROSituationTest { get; set; } 
        public IRPSTextBox<TestVMEntityView> DateRun { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDEmployeeRun { get; set; } 
        public IRPSComboBox<TestVMEntityView> IDEmployeeDefinition { get; set; } 
        public IRPSTextBox<TestVMEntityView> Order { get; set; } 
        public IRPSTextBox<TestVMEntityView> Notes { get; set; } 
        public IRPSButton<TestVMEntityView,NewWarningFromTestDialogView> NewWarningFromTestNavigationCommandButton { get; set; } 
        public IRPSButton<TestVMEntityView,ChangeStateDialogView> ChangeStateNavigationCommandButton { get; set; } 
        public WarningFromTestCollectionEditor<TestVMEntityView,NewWarningFromTestDialogView> WarningFromTest { get; set; } 
        public IRPSSection<TestVMEntityView> General { get; set; } 
        public IRPSSection<TestVMEntityView> Warning { get; set; } 
        public Test Screen { get; set; }
        public TestVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WarningFromTestCollectionEditor<TestVMEntityView,NewWarningFromTestDialogView>:RPSCollectionEditor<TestVMEntityView,NewWarningFromTestDialogView> where TestVMEntityView : class, IView where NewWarningFromTestDialogView : class, IView
    {
        public  WarningFromTestGridView<TestVMEntityView,NewWarningFromTestDialogView> GridView {get;set;}
    }
    public partial class WarningFromTestGridView <TestVMEntityView,NewWarningFromTestDialogView> :  RPSGridView<TestVMEntityView,NewWarningFromTestDialogView> where TestVMEntityView : class, IView where NewWarningFromTestDialogView : class, IView
    {
        public WarningFromTestGridView(TestVMEntityView currentView,NewWarningFromTestDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Warning_Description = RPSControlFactory.CreateRPSGridMemoTextBox<TestVMEntityView>("","#e23949f6-cc8a-462c-be6e-8b1fb56dbfba .ag-row[role='row']@ROWINDEX [col-id='cWarning_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TestVMEntityView> Warning_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateTestDialogView : View
    {
        public GenerateTestDialogView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProjectTest = RPSControlFactory.CreateRPSOption<GenerateTestDialogView>( "6bf4c080-54ee-45aa-929c-5dbe131a3c98","","",this);
 
            OriginProject = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("2fd95e40-3f4b-4b0c-a277-2d47fb822e26","","",false, this);
 
            OriginProjectTask = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("d5d64aa4-383a-4335-af45-7ad7ac1a8c69","","",false, this);
 
            UsualTest1 = RPSControlFactory.CreateRPSOption<GenerateTestDialogView>( "b74ee492-6ed8-4c0e-b378-77a9c1e586ba","","",this);
 
            UsualTest = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("8cd0d585-3758-462d-bc6a-8f2bfa77f688","","",false, this);
 
            DestinationProject = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("d84365d0-49e4-4ac8-b6b9-2022a0effba1","","",false, this);
 
            DestinationProjectTask = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("232053ba-7405-425c-8465-d280e2c16312","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<GenerateTestDialogView>("28bb7415-6a10-4e64-88d1-139f7581893b","","",false, this);
 

        }
        public IRPSOption<GenerateTestDialogView> ProjectTest { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> OriginProject { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> OriginProjectTask { get; set; } 
        public IRPSOption<GenerateTestDialogView> UsualTest1 { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> UsualTest { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> DestinationProject { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> DestinationProjectTask { get; set; } 
        public IRPSComboBox<GenerateTestDialogView> Employee { get; set; } 
        public Test Screen { get; set; }
        public GenerateTestDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewWarningFromTestDialogView : View
    {
        public NewWarningFromTestDialogView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UINewCodWarning = RPSControlFactory.CreateRPSTextBox<NewWarningFromTestDialogView>("58815a7c-c1e5-4d2e-8095-343172571b9d","","",false, this);
 
            UINewDescription = RPSControlFactory.CreateRPSTextBox<NewWarningFromTestDialogView>("4a8b8eba-7d24-4ab8-b1bc-2eb99fbb9498","","",false, this);
 
            UINewEmployee = RPSControlFactory.CreateRPSComboBox<NewWarningFromTestDialogView>("fab79699-e310-4046-a903-6fec0d63ade0","","",false, this);
 
            UINewWarningType = RPSControlFactory.CreateRPSComboBox<NewWarningFromTestDialogView>("7216aa3b-ff0e-4a0c-be98-201f15b349d7","","",false, this);
 
            UINewWarningSeverity = RPSControlFactory.CreateRPSComboBox<NewWarningFromTestDialogView>("721c2b05-24ca-4531-829c-e6102b784558","","",false, this);
 
            UINewWarningPriority = RPSControlFactory.CreateRPSComboBox<NewWarningFromTestDialogView>("c3d9f507-0d56-4012-9e3f-ab49c203dbdb","","",false, this);
 
            UINewPlannedDate = RPSControlFactory.CreateRPSTextBox<NewWarningFromTestDialogView>("2a456434-8860-4f8a-a972-b0be6330bfa6","","",false, this);
 

        }
        public IRPSTextBox<NewWarningFromTestDialogView> UINewCodWarning { get; set; } 
        public IRPSTextBox<NewWarningFromTestDialogView> UINewDescription { get; set; } 
        public IRPSComboBox<NewWarningFromTestDialogView> UINewEmployee { get; set; } 
        public IRPSComboBox<NewWarningFromTestDialogView> UINewWarningType { get; set; } 
        public IRPSComboBox<NewWarningFromTestDialogView> UINewWarningSeverity { get; set; } 
        public IRPSComboBox<NewWarningFromTestDialogView> UINewWarningPriority { get; set; } 
        public IRPSTextBox<NewWarningFromTestDialogView> UINewPlannedDate { get; set; } 
        public Test Screen { get; set; }
        public NewWarningFromTestDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeStateDialogView : View
    {
        public ChangeStateDialogView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISituationTest = RPSControlFactory.CreateRPSComboBox<ChangeStateDialogView>("c7d49870-d5cd-431b-b0c5-2f8ea67912c6","","",false, this);
 

        }
        public IRPSComboBox<ChangeStateDialogView> UISituationTest { get; set; } 
        public Test Screen { get; set; }
        public ChangeStateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeTestsSituationChildDialogView : View
    {
        public ChangeTestsSituationChildDialogView(Test screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UINewSituation = RPSControlFactory.CreateRPSComboBox<ChangeTestsSituationChildDialogView>("f17482b1-d201-4f67-b20d-2becef838ccb","","",false, this);
 

        }
        public IRPSComboBox<ChangeTestsSituationChildDialogView> UINewSituation { get; set; } 
        public Test Screen { get; set; }
        public ChangeTestsSituationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
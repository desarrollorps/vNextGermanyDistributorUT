    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectTaskCadMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectTaskCadMaterial:Screen
    {
        public ProjectTaskCadMaterial():base()
        {
            this.URL = "project.projecttaskcadmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectTaskCadMaterialView  = new ProjectTaskCadMaterialView(this); 
            ChangeSituationChildDialogView  = new ChangeSituationChildDialogView(this); 
            ProjectTaskCadMaterialView.InitializeControls(); 
            ChangeSituationChildDialogView.InitializeControls(); 
           
        }
      
            public ProjectTaskCadMaterialView ProjectTaskCadMaterialView {get; set; } 
            public ChangeSituationChildDialogView ChangeSituationChildDialogView {get; set; } 
    }
            
    public partial class ProjectTaskCadMaterialView : View
    {
        public ProjectTaskCadMaterialView(ProjectTaskCadMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<ProjectTaskCadMaterialView>("64cca733-08a3-4a94-a2d5-44104393eee0","","",true, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<ProjectTaskCadMaterialView>("b7b0816e-915c-41af-b920-05c04ae3ca1e","","",false, this);
 
            QueryCommand = RPSControlFactory.CreateRPSButton<ProjectTaskCadMaterialView>( "53311dea-8f39-4729-945d-2a4167a3ebd9","","",this);
 
            Item = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("2ab15b8b-6c86-4828-b8c5-93177b6eb8e1","","",false, this);
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("c4a95347-6ddf-4506-bc16-08a15ccdd3c5","","",false, this);
 
            MaterialState = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("04ce85f0-1347-4310-b980-b2597da1ecfa","","",false, this);
 
            MaterialSituation = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("d0608cd7-6b72-4bab-9752-01c52e917e46","","",false, this);
 
            IdDocumentSituation = RPSControlFactory.CreateRPSComboBox<ProjectTaskCadMaterialView>("cee6e6c9-2f29-4ab7-9ad1-30236e8e75a6","","",false, this);
 
            CheckOutBy = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("dd38a11b-6fe5-4400-9ca4-aa23052fcc1b","","",false, this);
 
            Observations = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("00e72fd4-38b3-43b9-993e-9f401e1a5a3c","","",false, this);
 
            Item1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("da8d1a35-77cc-43c2-9420-bfeedd09e531","","",false, this);
 
            CodArticle1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("381ab1a2-09ed-4c3a-9c65-609e16f778dd","","",false, this);
 
            MaterialState1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("b7143e56-f00d-402e-bde6-c12267db28f9","","",false, this);
 
            MaterialSituation1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("c7bc1fc8-c8e7-46b5-a8f1-4deaa865b896","","",false, this);
 
            DocumentSituationDescription = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("b3236632-3a6d-41d9-8d41-b02a4c8dff8e","","",false, this);
 
            DocumentPath = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("1be0645f-eced-4bff-9032-e3f193ca97d8","","",false, this);
 
            CheckOutBy1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("2e3d4a73-d4cd-428d-b962-d9fcb4323234","","",false, this);
 
            CheckOutMachine = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("0cde1d77-7bed-4b14-b7f5-328392280392","","",false, this);
 
            Observations1 = RPSControlFactory.CreateRPSTextBox<ProjectTaskCadMaterialView>("7346e013-942a-45dc-b6de-e2cd7b1dd2a1","","",false, this);
 
            ChangeSituationCommandButton = RPSControlFactory.CreateRPSButton<ProjectTaskCadMaterialView>( "8af0e62d-8850-43c8-b241-e158e251dcce","","",this);
 

        }
        public IRPSComboBox<ProjectTaskCadMaterialView> Project { get; set; } 
        public IRPSComboBox<ProjectTaskCadMaterialView> ProjectTask { get; set; } 
        public IRPSButton<ProjectTaskCadMaterialView> QueryCommand { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> Item { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> CodArticle { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> MaterialState { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> MaterialSituation { get; set; } 
        public IRPSComboBox<ProjectTaskCadMaterialView> IdDocumentSituation { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> CheckOutBy { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> Observations { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> Item1 { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> CodArticle1 { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> MaterialState1 { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> MaterialSituation1 { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> DocumentSituationDescription { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> DocumentPath { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> CheckOutBy1 { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> CheckOutMachine { get; set; } 
        public IRPSTextBox<ProjectTaskCadMaterialView> Observations1 { get; set; } 
        public IRPSButton<ProjectTaskCadMaterialView> ChangeSituationCommandButton { get; set; } 
        public ProjectTaskCadMaterial Screen { get; set; }
        public ProjectTaskCadMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSituationChildDialogView : View
    {
        public ChangeSituationChildDialogView(ProjectTaskCadMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DocumentSituation = RPSControlFactory.CreateRPSComboBox<ChangeSituationChildDialogView>("986ac7cd-d67a-4f9c-8c16-a0a8472f960b","","",false, this);
 
            eStatus = RPSControlFactory.CreateRPSEnumComboBox<ChangeSituationChildDialogView>("c0cd5c35-e66a-4a5b-aa40-4c0f16a2212f","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ChangeSituationChildDialogView>("4a9eb493-c197-41e3-9604-d44b5ff24698","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<ChangeSituationChildDialogView>( "3c423082-8b4b-4880-91aa-06f067abf0a8","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ChangeSituationChildDialogView>( "d3d41224-9ea2-49c6-b490-8b81f148a5cf","","",this);
 

        }
        public IRPSComboBox<ChangeSituationChildDialogView> DocumentSituation { get; set; } 
        public IRPSComboBox<ChangeSituationChildDialogView> eStatus { get; set; } 
        public IRPSTextBox<ChangeSituationChildDialogView> Comments { get; set; } 
        public IRPSButton<ChangeSituationChildDialogView> AcceptCommand { get; set; } 
        public IRPSButton<ChangeSituationChildDialogView> CancelCommand { get; set; } 
        public ProjectTaskCadMaterial Screen { get; set; }
        public ChangeSituationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
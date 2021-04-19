    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectConsult
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectConsult:Screen
    {
        public ProjectConsult():base()
        {
            this.URL = "project.projectconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectConsultQueryView  = new ProjectConsultQueryView(this); 
            ProjectTaskDialogView  = new ProjectTaskDialogView(this); 
            ProjectConsultQueryView.InitializeControls(); 
            ProjectTaskDialogView.InitializeControls(); 
           
        }
      
            public ProjectConsultQueryView ProjectConsultQueryView {get; set; } 
            public ProjectTaskDialogView ProjectTaskDialogView {get; set; } 
    }
            
    public partial class ProjectConsultQueryView : View
    {
        public ProjectConsultQueryView(ProjectConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("3ba44967-de60-440a-8554-2230879935e4","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("8412d901-9a68-4141-9cd3-36e3c3906058","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("06e8ec7c-1f10-4494-98d7-5e91124910c1","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("1b542fbb-6997-41f0-9767-8279e89308d7","","",false, this);
 
            UI_FromDeliveryDate = RPSControlFactory.CreateRPSTextBox<ProjectConsultQueryView>("e3231cf9-b182-4b4a-a4e8-67fb49642a5e","","",false, this);
 
            UI_ToDeliveryDate = RPSControlFactory.CreateRPSTextBox<ProjectConsultQueryView>("8881f084-0062-4bbd-8943-2f928ad7d7b8","","",false, this);
 
            UI_IDEmployee = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("d18b3047-aad5-461c-8229-0584471420f1","","",false, this);
 
            UI_IDQualify = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("3b9a99e7-481f-4749-9ca5-caa1cca25d26","","",false, this);
 
            UI_IDMachine = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("82f291cf-63c1-489b-8a69-c61dd32f2305","","",false, this);
 
            UI_IDMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("893e5e9a-7c9b-4a67-a294-ef8cdfa4a1cd","","",false, this);
 
            UI_IDTool = RPSControlFactory.CreateRPSCollectionComboBox<ProjectConsultQueryView>("69d44e3d-3b55-4d22-adbe-7b91a993ce03","","",false, this);
 
            ProjectTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectConsultQueryView,ProjectTaskDialogView>("0e9244a2-82b2-466f-b53a-d5b443c6c953","","", this,Screen.ProjectTaskDialogView);
 

        }
        public IRPSCollectionComboBox<ProjectConsultQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> Situation { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> ProjectType { get; set; } 
        public IRPSTextBox<ProjectConsultQueryView> UI_FromDeliveryDate { get; set; } 
        public IRPSTextBox<ProjectConsultQueryView> UI_ToDeliveryDate { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> UI_IDEmployee { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> UI_IDQualify { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> UI_IDMachine { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> UI_IDMachineGroup { get; set; } 
        public IRPSCollectionComboBox<ProjectConsultQueryView> UI_IDTool { get; set; } 
        public IRPSButton<ProjectConsultQueryView,ProjectTaskDialogView> ProjectTaskNavigationCommandButton { get; set; } 
        public ProjectConsult Screen { get; set; }
        public ProjectConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskDialogView : View
    {
        public ProjectTaskDialogView(ProjectConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<ProjectTaskDialogView>("31a89aa5-4d1f-4695-a8be-33f4a4043534","","",true, this);
 
            UIProjectTask = RPSControlFactory.CreateRPSComboBox<ProjectTaskDialogView>("73cda263-0774-45ab-8cfd-228503407b14","","",false, this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<ProjectTaskDialogView>( "d8e8069c-a7a3-4bba-b57b-c60fbeb807bc","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ProjectTaskDialogView>( "9324f8a7-a7d3-4512-92e6-3400502d8fcb","","",this);
 
            CollectionInit params_ProjectResourceEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="241b277a-7802-4072-8909-dded5352a3bb",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceEmployeesCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectResourceEmployees,this);
 
            CollectionInit params_ProjectResourceMachines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b7e2c98b-115f-41f4-8ff6-547a73a77ec9",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceMachines = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceMachinesCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectResourceMachines,this);
 
            CollectionInit params_ProjectResourceTools = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a76325a2-dea3-4867-b98a-53fa73bf4d77",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceTools = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceToolsCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectResourceTools,this);
 
            ProjectResourceEmployees1 = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='38d7a0e8-fbaa-441f-a352-63566cb67225']","",this);
 
            ProjectResourceMachines1 = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='c2eb0db0-d762-4c61-a579-ad315bd4365e']","",this);
 
            ProjectResourceTools1 = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='0cb2608b-7a18-49be-888a-69c42b825c82']","",this);
 

        }
        public IRPSComboBox<ProjectTaskDialogView> IDProject { get; set; } 
        public IRPSComboBox<ProjectTaskDialogView> UIProjectTask { get; set; } 
        public IRPSButton<ProjectTaskDialogView> OKCommand { get; set; } 
        public IRPSButton<ProjectTaskDialogView> CancelCommand { get; set; } 
        public ProjectResourceEmployeesCollectionEditor<ProjectTaskDialogView> ProjectResourceEmployees { get; set; } 
        public ProjectResourceMachinesCollectionEditor<ProjectTaskDialogView> ProjectResourceMachines { get; set; } 
        public ProjectResourceToolsCollectionEditor<ProjectTaskDialogView> ProjectResourceTools { get; set; } 
        public IRPSSection<ProjectTaskDialogView> ProjectResourceEmployees1 { get; set; } 
        public IRPSSection<ProjectTaskDialogView> ProjectResourceMachines1 { get; set; } 
        public IRPSSection<ProjectTaskDialogView> ProjectResourceTools1 { get; set; } 
        public ProjectConsult Screen { get; set; }
        public ProjectTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectResourceEmployeesCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectResourceEmployeesGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectResourceEmployeesGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectResourceEmployeesGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodResourceEmployee = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cCodResourceEmployee']","",true, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskDialogView>("","#241b277a-7802-4072-8909-dded5352a3bb .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskDialogView> CodResourceEmployee { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDEmployee { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDQualify { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> DedicationPercent { get; set; } 
        public IRPSGridCheckbox<ProjectTaskDialogView> Planify { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskDialogView> Duration { get; set; } 
                     
    }
 
        public partial class ProjectResourceMachinesCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectResourceMachinesGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectResourceMachinesGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectResourceMachinesGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodResourceMachine = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cCodResourceMachine']","",true, this.CurrentView);
 
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cIDMachineGroup']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskDialogView>("","#b7e2c98b-115f-41f4-8ff6-547a73a77ec9 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskDialogView> CodResourceMachine { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDMachine { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDMachineGroup { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> DedicationPercent { get; set; } 
        public IRPSGridCheckbox<ProjectTaskDialogView> Planify { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskDialogView> Duration { get; set; } 
                     
    }
 
        public partial class ProjectResourceToolsCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectResourceToolsGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectResourceToolsGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectResourceToolsGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodResourceTool = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cCodResourceTool']","",true, this.CurrentView);
 
            IDTool = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cIDTool']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskDialogView>("","#a76325a2-dea3-4867-b98a-53fa73bf4d77 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskDialogView> CodResourceTool { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDTool { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> DedicationPercent { get; set; } 
        public IRPSGridCheckbox<ProjectTaskDialogView> Planify { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskDialogView> Duration { get; set; } 
                     
    }
 
    }
  
    

}
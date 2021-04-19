    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Traceability
{
    //RPS VERSION 1.0.0.0
    public partial class Traceability:Screen
    {
        public Traceability():base()
        {
            this.URL = "quality.traceability";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TraceabilityView  = new TraceabilityView(this); 
            CreateAlertBySerieDialogView  = new CreateAlertBySerieDialogView(this); 
            TraceabilityView.InitializeControls(); 
            CreateAlertBySerieDialogView.InitializeControls(); 
           
        }
      
            public TraceabilityView TraceabilityView {get; set; } 
            public CreateAlertBySerieDialogView CreateAlertBySerieDialogView {get; set; } 
    }
            
    public partial class TraceabilityView : View
    {
        public TraceabilityView(Traceability screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<TraceabilityView>("37d60d70-e19c-4878-866f-5c2503f0e783","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<TraceabilityView>("a69b7518-29d8-424b-9895-6d36839e80cb","","",false, this);
 
            ExecuteTraceabilityTree = RPSControlFactory.CreateRPSButton<TraceabilityView>( "c1c030d1-d855-4012-90ac-6983982157e0","","",this);
 
            ExpandAllCommand = RPSControlFactory.CreateRPSButton<TraceabilityView>( "7f5b0b10-c404-45d6-8fc6-92acf931abf3","","",this);
 
            CollapseAllCommand = RPSControlFactory.CreateRPSButton<TraceabilityView>( "f0fb9367-7832-4e5d-9911-c28e6cd5e652","","",this);
 
            CreateAlertBySerieCommandButton = RPSControlFactory.CreateRPSButtonToView<TraceabilityView,CreateAlertBySerieDialogView>("d353a008-b291-41b7-afc0-52e4e89ce941","","", this,Screen.CreateAlertBySerieDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<TraceabilityView>( "4001f762-5186-47ea-a2a3-943a5618c499","","",this);
 

        }
        public IRPSComboBox<TraceabilityView> IDArticle { get; set; } 
        public IRPSComboBox<TraceabilityView> Series { get; set; } 
        public IRPSButton<TraceabilityView> ExecuteTraceabilityTree { get; set; } 
        public IRPSButton<TraceabilityView> ExpandAllCommand { get; set; } 
        public IRPSButton<TraceabilityView> CollapseAllCommand { get; set; } 
        public IRPSButton<TraceabilityView,CreateAlertBySerieDialogView> CreateAlertBySerieCommandButton { get; set; } 
        public IRPSButton<TraceabilityView> ReportCommandButton { get; set; } 
        public Traceability Screen { get; set; }
        public TraceabilityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateAlertBySerieDialogView : View
    {
        public CreateAlertBySerieDialogView(Traceability screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodAlert = RPSControlFactory.CreateRPSTextBox<CreateAlertBySerieDialogView>("d3b6eefe-bee3-4b95-a327-217269ed7793","","",true, this);
 
            LaunchDateTime = RPSControlFactory.CreateRPSTextBox<CreateAlertBySerieDialogView>("ac0333ed-1e9a-4f45-8f44-5acab28e418b","","",false, this);
 
            DetectionDate = RPSControlFactory.CreateRPSTextBox<CreateAlertBySerieDialogView>("17465b22-8df6-4d9f-94c9-d27472adb19a","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<CreateAlertBySerieDialogView>("ea6b5d06-291b-4891-a7e3-67db84f3951f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CreateAlertBySerieDialogView>("5bffb91b-e92f-4f57-a14b-27c7fe3e498b","","",false, this);
 

        }
        public IRPSTextBox<CreateAlertBySerieDialogView> CodAlert { get; set; } 
        public IRPSTextBox<CreateAlertBySerieDialogView> LaunchDateTime { get; set; } 
        public IRPSTextBox<CreateAlertBySerieDialogView> DetectionDate { get; set; } 
        public IRPSComboBox<CreateAlertBySerieDialogView> IDEmployee { get; set; } 
        public IRPSTextBox<CreateAlertBySerieDialogView> Description { get; set; } 
        public Traceability Screen { get; set; }
        public CreateAlertBySerieDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
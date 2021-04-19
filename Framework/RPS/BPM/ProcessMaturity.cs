    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ProcessMaturity
{
    //RPS VERSION 1.0.0.0
    public partial class ProcessMaturity:Screen
    {
        public ProcessMaturity():base()
        {
            this.URL = "bpm.processmaturity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProcessMaturityView  = new ProcessMaturityView(this); 
            NewSnapshotDialogView  = new NewSnapshotDialogView(this); 
            ProcessMaturityView.InitializeControls(); 
            NewSnapshotDialogView.InitializeControls(); 
           
        }
      
            public ProcessMaturityView ProcessMaturityView {get; set; } 
            public NewSnapshotDialogView NewSnapshotDialogView {get; set; } 
    }
            
    public partial class ProcessMaturityView : View
    {
        public ProcessMaturityView(ProcessMaturity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CurrentViewOption = RPSControlFactory.CreateRPSOption<ProcessMaturityView>( "1d282b68-37a5-4542-8de6-883165bec093","","",this);
 
            SnapshotViewOption = RPSControlFactory.CreateRPSOption<ProcessMaturityView>( "c848b711-c950-4f95-8226-17d4e8fef3a1","","",this);
 
            IDProcessMaturity = RPSControlFactory.CreateRPSComboBox<ProcessMaturityView>("d9df59bd-45ec-4c14-9a85-3ec71c495d03","","",false, this);
 
            QueryCommand = RPSControlFactory.CreateRPSButton<ProcessMaturityView>( "f88a6a00-af1b-48e5-828e-6ce2680cc376","","",this);
 
            NewSnapshotNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProcessMaturityView,NewSnapshotDialogView>("95e715b4-05ab-4e5d-9155-b5a78e2ff546","","", this,Screen.NewSnapshotDialogView);
 

        }
        public IRPSOption<ProcessMaturityView> CurrentViewOption { get; set; } 
        public IRPSOption<ProcessMaturityView> SnapshotViewOption { get; set; } 
        public IRPSComboBox<ProcessMaturityView> IDProcessMaturity { get; set; } 
        public IRPSButton<ProcessMaturityView> QueryCommand { get; set; } 
        public IRPSButton<ProcessMaturityView,NewSnapshotDialogView> NewSnapshotNavigationCommandButton { get; set; } 
        public ProcessMaturity Screen { get; set; }
        public ProcessMaturityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewSnapshotDialogView : View
    {
        public NewSnapshotDialogView(ProcessMaturity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTime = RPSControlFactory.CreateRPSTextBox<NewSnapshotDialogView>("d55246e6-1f9b-44ac-8da1-89367aefd1ec","","",false, this);
 
            SnapshotLabel = RPSControlFactory.CreateRPSTextBox<NewSnapshotDialogView>("9e99337a-59d5-4ccb-9e32-f4c824255b56","","",false, this);
 

        }
        public IRPSTextBox<NewSnapshotDialogView> DateTime { get; set; } 
        public IRPSTextBox<NewSnapshotDialogView> SnapshotLabel { get; set; } 
        public ProcessMaturity Screen { get; set; }
        public NewSnapshotDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.GlobalParameter
{
    //RPS VERSION 1.0.0.0
    public partial class GlobalParameter:Screen
    {
        public GlobalParameter():base()
        {
            this.URL = "general.globalparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            GlobalParameterView  = new GlobalParameterView(this); 
            GlobalParameterView1  = new GlobalParameterView1(this); 
            GlobalParameterView.InitializeControls(); 
            GlobalParameterView1.InitializeControls(); 
           
        }
      
            public GlobalParameterView GlobalParameterView {get; set; } 
            public GlobalParameterView1 GlobalParameterView1 {get; set; } 
    }
            
    public partial class GlobalParameterView : View
    {
        public GlobalParameterView(GlobalParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public GlobalParameter Screen { get; set; }
        public GlobalParameterView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GlobalParameterView1 : View
    {
        public GlobalParameterView1(GlobalParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<GlobalParameterView1>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<GlobalParameterView1>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<GlobalParameterView1,GlobalParameterView>( this,Screen.GlobalParameterView);
 
            BackButton = RPSControlFactory.RPSBackButton<GlobalParameterView1,GlobalParameterView>( this,Screen.GlobalParameterView);
 
            RPSServiceUrl = RPSControlFactory.CreateRPSTextBox<GlobalParameterView1>("df4d501c-70fa-415c-b1e3-4abf3f570a58","","",false, this);
 
            ExternalUserCompany = RPSControlFactory.CreateRPSComboBox<GlobalParameterView1>("50bcee3e-46e5-4a9c-aca6-01d751a3360c","","",false, this);
 
            ExternalUserCodingSeries = RPSControlFactory.CreateRPSComboBox<GlobalParameterView1>("9ee23c7b-c477-4530-b6cd-ed8779598f8e","","",false, this);
 
            ExternalUserCodRole = RPSControlFactory.CreateRPSComboBox<GlobalParameterView1>("c2731e49-6c12-4a63-a690-6da4695a12ea","","",false, this);
 
            ExternalUserCodLanguage = RPSControlFactory.CreateRPSComboBox<GlobalParameterView1>("3df455e0-f7f7-4d38-9365-3c94a836a1b0","","",false, this);
 
            CCHDocumentServiceUrl = RPSControlFactory.CreateRPSTextBox<GlobalParameterView1>("b5f9dbf1-77d3-4a85-bd9e-3bd009f58b8a","","",false, this);
 
            CCHVault = RPSControlFactory.CreateRPSTextBox<GlobalParameterView1>("a6d43d5d-4c85-49e2-a56f-e3910a7a0f56","","",false, this);
 
            PackFileServiceUrl = RPSControlFactory.CreateRPSTextBox<GlobalParameterView1>("24297ccc-f382-4f63-8f28-86702f866598","","",false, this);
 
            PackFileVault = RPSControlFactory.CreateRPSTextBox<GlobalParameterView1>("d4168f79-3380-428b-927c-3a65063ef4e1","","",false, this);
 
            PackFileDays = RPSControlFactory.CreateRPSFormattedTextBox<GlobalParameterView1>("f8399d22-f60e-48b1-a4a6-a577bc979d09","","",true, this);
 

        }
        public IRPSSaveButton<GlobalParameterView1> SaveButton { get; set; } 
        public IRPSButton<GlobalParameterView1> DeleteButton { get; set; } 
        public IRPSButton<GlobalParameterView1,GlobalParameterView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<GlobalParameterView1,GlobalParameterView> BackButton { get; set; } 
        public IRPSTextBox<GlobalParameterView1> RPSServiceUrl { get; set; } 
        public IRPSComboBox<GlobalParameterView1> ExternalUserCompany { get; set; } 
        public IRPSComboBox<GlobalParameterView1> ExternalUserCodingSeries { get; set; } 
        public IRPSComboBox<GlobalParameterView1> ExternalUserCodRole { get; set; } 
        public IRPSComboBox<GlobalParameterView1> ExternalUserCodLanguage { get; set; } 
        public IRPSTextBox<GlobalParameterView1> CCHDocumentServiceUrl { get; set; } 
        public IRPSTextBox<GlobalParameterView1> CCHVault { get; set; } 
        public IRPSTextBox<GlobalParameterView1> PackFileServiceUrl { get; set; } 
        public IRPSTextBox<GlobalParameterView1> PackFileVault { get; set; } 
        public IRPSTextBox<GlobalParameterView1> PackFileDays { get; set; } 
        public GlobalParameter Screen { get; set; }
        public GlobalParameterView1 Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
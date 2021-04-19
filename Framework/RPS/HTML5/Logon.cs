    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.HTML5.Logon
{
    //RPS VERSION 1.0.0.0
    public partial class Logon:Screen
    {
        public Logon():base()
        {
            this.URL = "html5.logon";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LogonView  = new LogonView(this); 
            changePasswordDialogView  = new changePasswordDialogView(this); 
            RecoverPasswordDialogView  = new RecoverPasswordDialogView(this); 
            LogonView.InitializeControls(); 
            changePasswordDialogView.InitializeControls(); 
            RecoverPasswordDialogView.InitializeControls(); 
           
        }
      
            public LogonView LogonView {get; set; } 
            public changePasswordDialogView changePasswordDialogView {get; set; } 
            public RecoverPasswordDialogView RecoverPasswordDialogView {get; set; } 
    }
            
    public partial class LogonView : View
    {
        public LogonView(Logon screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            codUser = RPSControlFactory.CreateRPSTextBox<LogonView>("4641df06-8908-4cf1-a249-5f42988b5b83","","",false, this);
 
            keepSessionOpen = RPSControlFactory.CreateRPSCheckBox<LogonView>("a24961ec-6367-49ad-8e8f-ceff67b48e9d","","",false, this);
 
            logOn = RPSControlFactory.CreateRPSButton<LogonView>( "8bf1080a-f56a-45f4-8771-2647825f082a","","",this);
 
            windowsLogOn = RPSControlFactory.CreateRPSButton<LogonView>( "3f0a95eb-09ba-4501-bc68-c193533a956d","","",this);
 
            changePasswordNavigationCommand = RPSControlFactory.CreateRPSButtonToView<LogonView,changePasswordDialogView>("dc11e4da-3a9f-4404-9829-7deae1379aee","","", this,Screen.changePasswordDialogView);
 
            RecoverPasswordNavigationCommand = RPSControlFactory.CreateRPSButtonToView<LogonView,RecoverPasswordDialogView>("57e01afb-297a-4ef8-84ca-21af4782c963","","", this,Screen.RecoverPasswordDialogView);
 

        }
        public IRPSTextBox<LogonView> codUser { get; set; } 
        public IRPSCheckbox<LogonView> keepSessionOpen { get; set; } 
        public IRPSButton<LogonView> logOn { get; set; } 
        public IRPSButton<LogonView> windowsLogOn { get; set; } 
        public IRPSButton<LogonView,changePasswordDialogView> changePasswordNavigationCommand { get; set; } 
        public IRPSButton<LogonView,RecoverPasswordDialogView> RecoverPasswordNavigationCommand { get; set; } 
        public Logon Screen { get; set; }
        public LogonView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class changePasswordDialogView : View
    {
        public changePasswordDialogView(Logon screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            codUser = RPSControlFactory.CreateRPSTextBox<changePasswordDialogView>("adca0d7b-e89b-42c3-bb30-700840b74b23","","",true, this);
 
            oldPassword = RPSControlFactory.CreateRPSTextBox<changePasswordDialogView>("e8cd5220-7033-40e6-be6a-7ebeffdb2448","","",true, this);
 
            newPassword = RPSControlFactory.CreateRPSTextBox<changePasswordDialogView>("36b8c2d7-96b5-4ed3-ac89-5b8f1f3a0f0c","","",true, this);
 
            newPasswordConfirmation = RPSControlFactory.CreateRPSTextBox<changePasswordDialogView>("2c51bb27-6882-4033-a5f7-51ee87c12251","","",true, this);
 

        }
        public IRPSTextBox<changePasswordDialogView> codUser { get; set; } 
        public IRPSTextBox<changePasswordDialogView> oldPassword { get; set; } 
        public IRPSTextBox<changePasswordDialogView> newPassword { get; set; } 
        public IRPSTextBox<changePasswordDialogView> newPasswordConfirmation { get; set; } 
        public Logon Screen { get; set; }
        public changePasswordDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecoverPasswordDialogView : View
    {
        public RecoverPasswordDialogView(Logon screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIUserEmail = RPSControlFactory.CreateRPSTextBox<RecoverPasswordDialogView>("ead22bf9-b7a6-49ee-97aa-e553e46eaaeb","","",true, this);
 
            NewCodeCommand = RPSControlFactory.CreateRPSButton<RecoverPasswordDialogView>( "64215c8d-8fce-430c-98aa-e3f1d9833cac","","",this);
 
            UIConfirmationCode = RPSControlFactory.CreateRPSTextBox<RecoverPasswordDialogView>("9744edf2-341b-4df5-a3de-6996fcaa4d2d","","",false, this);
 
            NewPasswordCommand = RPSControlFactory.CreateRPSButton<RecoverPasswordDialogView>( "6be60b73-d28f-4376-b635-9bf5f7ad54e4","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<RecoverPasswordDialogView>( "634513d5-1db2-40ac-bf2e-67cb19559432","","",this);
 

        }
        public IRPSTextBox<RecoverPasswordDialogView> UIUserEmail { get; set; } 
        public IRPSButton<RecoverPasswordDialogView> NewCodeCommand { get; set; } 
        public IRPSTextBox<RecoverPasswordDialogView> UIConfirmationCode { get; set; } 
        public IRPSButton<RecoverPasswordDialogView> NewPasswordCommand { get; set; } 
        public IRPSButton<RecoverPasswordDialogView> LinkNavigationCommand { get; set; } 
        public Logon Screen { get; set; }
        public RecoverPasswordDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
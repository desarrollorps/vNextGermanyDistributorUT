    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.HTML5.Settings
{
    //RPS VERSION 1.0.0.0
    public partial class Settings:Screen
    {
        public Settings():base()
        {
            this.URL = "html5.settings";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SettingsView  = new SettingsView(this); 
            SettingsView.InitializeControls(); 
           
        }
      
            public SettingsView SettingsView {get; set; } 
    }
            
    public partial class SettingsView : View
    {
        public SettingsView(Settings screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SessionCompany = RPSControlFactory.CreateRPSComboBox<SettingsView>("9c788b44-7b59-4c52-a2b8-9fc74de6bbda","","",false, this);
 
            SessionSite = RPSControlFactory.CreateRPSComboBox<SettingsView>("65d759c5-9ea3-42cf-8e1b-79684b263ac5","","",false, this);
 
            SessionAllSitesProperty = RPSControlFactory.CreateRPSCheckBox<SettingsView>("fbaac88d-a63c-466a-97ef-c63fa94b69f8","","",false, this);
 
            SessionInvoicingPoint = RPSControlFactory.CreateRPSComboBox<SettingsView>("72336872-1e2f-4603-8101-391521563509","","",false, this);
 
            SessionCommercialAgentSL = RPSControlFactory.CreateRPSComboBox<SettingsView>("8fb5cfbf-870a-417a-b4b8-e507eaff3d91","","",false, this);
 
            SessionCashPaymentSL = RPSControlFactory.CreateRPSComboBox<SettingsView>("81b60c18-5765-4823-985e-4fcc03547d28","","",false, this);
 
            SessionAccType = RPSControlFactory.CreateRPSComboBox<SettingsView>("ce57f197-fa79-4dfa-a063-e1f0a1d23c5a","","",false, this);
 
            SessionLanguage = RPSControlFactory.CreateRPSComboBox<SettingsView>("7190aeaf-0755-41c3-a86e-de728615d91b","","",false, this);
 
            SessionZoom = RPSControlFactory.CreateRPSFormattedTextBox<SettingsView>("6bd12e25-1d6a-4595-b143-522edfd239c7","","",false, this);
 
            ApplySessionData = RPSControlFactory.CreateRPSButton<SettingsView>( "f1ed3be2-1780-4431-ba64-9fc51c6bb89b","","",this);
 
            UserName = RPSControlFactory.CreateRPSTextBox<SettingsView>("09c0136c-aed2-49e5-8e5d-f2067463fd2f","","",false, this);
 
            UserCompany = RPSControlFactory.CreateRPSComboBox<SettingsView>("44cad158-36d6-40f4-bbb1-80011fdc0552","","",false, this);
 
            UserSite = RPSControlFactory.CreateRPSComboBox<SettingsView>("a07c881f-2633-4835-944e-9ce075618856","","",false, this);
 
            UserAllSites = RPSControlFactory.CreateRPSCheckBox<SettingsView>("44b529b6-763c-4ad4-9376-f2cf23628a16","","",false, this);
 
            UserLanguage = RPSControlFactory.CreateRPSComboBox<SettingsView>("b8611830-7b23-4222-9882-c2968dd461bb","","",false, this);
 
            ChangePassword = RPSControlFactory.CreateRPSButton<SettingsView>( "f8414c46-d463-4f89-bb30-8ffcd7f55069","","",this);
 
            ChangeEmailConnectionData = RPSControlFactory.CreateRPSButton<SettingsView>( "0af98125-10a1-41b0-8430-4afeafc8f078","","",this);
 
            SaveUserData = RPSControlFactory.CreateRPSButton<SettingsView>( "264036c2-5acb-4de3-b37e-e1e47097cd29","","",this);
 
            SessionDataSection = RPSControlFactory.CreateRPSSection<SettingsView>( "","ul li[rpsid='a94813e7-be3a-4189-9558-2d484365840e']","",this);
 
            UserDataSection = RPSControlFactory.CreateRPSSection<SettingsView>( "","ul li[rpsid='f56db83a-f2f3-4b3d-8d91-feed5842c585']","",this);
 

        }
        public IRPSComboBox<SettingsView> SessionCompany { get; set; } 
        public IRPSComboBox<SettingsView> SessionSite { get; set; } 
        public IRPSCheckbox<SettingsView> SessionAllSitesProperty { get; set; } 
        public IRPSComboBox<SettingsView> SessionInvoicingPoint { get; set; } 
        public IRPSComboBox<SettingsView> SessionCommercialAgentSL { get; set; } 
        public IRPSComboBox<SettingsView> SessionCashPaymentSL { get; set; } 
        public IRPSComboBox<SettingsView> SessionAccType { get; set; } 
        public IRPSComboBox<SettingsView> SessionLanguage { get; set; } 
        public IRPSTextBox<SettingsView> SessionZoom { get; set; } 
        public IRPSButton<SettingsView> ApplySessionData { get; set; } 
        public IRPSTextBox<SettingsView> UserName { get; set; } 
        public IRPSComboBox<SettingsView> UserCompany { get; set; } 
        public IRPSComboBox<SettingsView> UserSite { get; set; } 
        public IRPSCheckbox<SettingsView> UserAllSites { get; set; } 
        public IRPSComboBox<SettingsView> UserLanguage { get; set; } 
        public IRPSButton<SettingsView> ChangePassword { get; set; } 
        public IRPSButton<SettingsView> ChangeEmailConnectionData { get; set; } 
        public IRPSButton<SettingsView> SaveUserData { get; set; } 
        public IRPSSection<SettingsView> SessionDataSection { get; set; } 
        public IRPSSection<SettingsView> UserDataSection { get; set; } 
        public Settings Screen { get; set; }
        public SettingsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CopyConfiguration
{
    //RPS VERSION 1.0.0.0
    public partial class CopyConfiguration:Screen
    {
        public CopyConfiguration():base()
        {
            this.URL = "general.copyconfiguration";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CopyConfigurationView  = new CopyConfigurationView(this); 
            CopyConfigurationView.InitializeControls(); 
           
        }
      
            public CopyConfigurationView CopyConfigurationView {get; set; } 
    }
            
    public partial class CopyConfigurationView : View
    {
        public CopyConfigurationView(CopyConfiguration screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UserRole = RPSControlFactory.CreateRPSEnumComboBox<CopyConfigurationView>("a8ecde8a-f7cb-41ff-9736-d1b5949b2d81","","",false, this);
 
            UserFrom = RPSControlFactory.CreateRPSComboBox<CopyConfigurationView>("cf83ea94-2372-4719-b580-fdccb463a711","","",false, this);
 
            UserTo = RPSControlFactory.CreateRPSComboBox<CopyConfigurationView>("5033af1a-ccf4-4e3f-8100-2a1fa17c7d75","","",false, this);
 
            RoleFrom = RPSControlFactory.CreateRPSComboBox<CopyConfigurationView>("4659081b-4369-43a3-99b5-b97b740e0a8a","","",false, this);
 
            RoleTo = RPSControlFactory.CreateRPSComboBox<CopyConfigurationView>("86aaf24b-3ae4-4d06-a0cf-e40a4b947640","","",false, this);
 
            IsReports = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("1fcf2406-2a40-4c46-aa11-ff101a11cb30","","",false, this);
 
            IsCustomQuery = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("81e4351a-6eee-423e-b442-db745e177d46","","",false, this);
 
            IsMenuPermisions = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("1f04965d-ec04-4e19-bad7-b4d14508de3a","","",false, this);
 
            IsMenuPermisionsHTML5 = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("bbb95550-65e5-41a6-94ac-3367e3f3213c","","",false, this);
 
            IsScreenConfiguration = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("77afe29d-939c-4901-acbd-b4a82e5f922b","","",false, this);
 
            IsUserManagement = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("b875f21b-0a6b-4714-8126-bd8efdb0f255","","",false, this);
 
            IsGrids = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("97f9bdbc-d69d-4362-b976-6eb004328d8d","","",false, this);
 
            IsGridHTML5 = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("bb2681eb-3db6-448d-8ded-163874e0ec56","","",false, this);
 
            IsRemoveConfiguration = RPSControlFactory.CreateRPSCheckBox<CopyConfigurationView>("b16ecc2c-ba87-4375-b9b4-d8c6a3d07315","","",false, this);
 
            ExecuteDuplicateConfigurationButton = RPSControlFactory.CreateRPSButton<CopyConfigurationView>( "10dab93f-1a72-4661-a555-d5f3d97208c3","","",this);
 

        }
        public IRPSComboBox<CopyConfigurationView> UserRole { get; set; } 
        public IRPSComboBox<CopyConfigurationView> UserFrom { get; set; } 
        public IRPSComboBox<CopyConfigurationView> UserTo { get; set; } 
        public IRPSComboBox<CopyConfigurationView> RoleFrom { get; set; } 
        public IRPSComboBox<CopyConfigurationView> RoleTo { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsReports { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsCustomQuery { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsMenuPermisions { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsMenuPermisionsHTML5 { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsScreenConfiguration { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsUserManagement { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsGrids { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsGridHTML5 { get; set; } 
        public IRPSCheckbox<CopyConfigurationView> IsRemoveConfiguration { get; set; } 
        public IRPSButton<CopyConfigurationView> ExecuteDuplicateConfigurationButton { get; set; } 
        public CopyConfiguration Screen { get; set; }
        public CopyConfigurationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
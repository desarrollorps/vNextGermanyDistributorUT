    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.MenuPermissions
{
    //RPS VERSION 1.0.0.0
    public partial class MenuPermissions:Screen
    {
        public MenuPermissions():base()
        {
            this.URL = "general.menupermissions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MenuPermissionsView  = new MenuPermissionsView(this); 
            MenuPermissionsView.InitializeControls(); 
           
        }
      
            public MenuPermissionsView MenuPermissionsView {get; set; } 
    }
            
    public partial class MenuPermissionsView : View
    {
        public MenuPermissionsView(MenuPermissions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Role = RPSControlFactory.CreateRPSOption<MenuPermissionsView>( "ed3cdaea-a610-453e-9ae3-d3e0002821e2","","",this);
 
            User = RPSControlFactory.CreateRPSOption<MenuPermissionsView>( "1b8a484e-6c0c-40f6-b14b-dded627a2eeb","","",this);
 
            Role1 = RPSControlFactory.CreateRPSComboBox<MenuPermissionsView>("10bad653-eec7-4c4c-a3fe-82b960606be2","","",false, this);
 
            User1 = RPSControlFactory.CreateRPSComboBox<MenuPermissionsView>("bfd7c1ed-60af-4bed-8597-9e1b863237bd","","",false, this);
 
            SelectedCompany = RPSControlFactory.CreateRPSComboBox<MenuPermissionsView>("6d08499f-b7fc-4eab-a3f2-e13f671694ca","","",false, this);
 

        }
        public IRPSOption<MenuPermissionsView> Role { get; set; } 
        public IRPSOption<MenuPermissionsView> User { get; set; } 
        public IRPSComboBox<MenuPermissionsView> Role1 { get; set; } 
        public IRPSComboBox<MenuPermissionsView> User1 { get; set; } 
        public IRPSComboBox<MenuPermissionsView> SelectedCompany { get; set; } 
        public MenuPermissions Screen { get; set; }
        public MenuPermissionsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
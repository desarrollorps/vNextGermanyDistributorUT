    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Organization
{
    //RPS VERSION 1.0.0.0
    public partial class Organization:Screen
    {
        public Organization():base()
        {
            this.URL = "general.organization";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrganizationTreeView  = new OrganizationTreeView(this); 
            OrganizationEntityView  = new OrganizationEntityView(this); 
            OrganizationTreeView.InitializeControls(); 
            OrganizationEntityView.InitializeControls(); 
           
        }
      
            public OrganizationTreeView OrganizationTreeView {get; set; } 
            public OrganizationEntityView OrganizationEntityView {get; set; } 
    }
            
    public partial class OrganizationTreeView : View
    {
        public OrganizationTreeView(Organization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Organization Screen { get; set; }
        public OrganizationTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrganizationEntityView : View
    {
        public OrganizationEntityView(Organization screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrganizationEntityView>( this);
 
            CodUserChild = RPSControlFactory.CreateRPSComboBox<OrganizationEntityView>("8d361d44-9475-4ef5-9e0e-df1e36ae910f","","",true, this);
 

        }
        public IRPSSaveButton<OrganizationEntityView> SaveButton { get; set; } 
        public IRPSComboBox<OrganizationEntityView> CodUserChild { get; set; } 
        public Organization Screen { get; set; }
        public OrganizationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
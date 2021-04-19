    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderDelete
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderDelete:Screen
    {
        public ManufacturingOrderDelete():base()
        {
            this.URL = "manufacturing.manufacturingorderdelete";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderDeleteView  = new ManufacturingOrderDeleteView(this); 
            ManufacturingOrderDeleteView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderDeleteView ManufacturingOrderDeleteView {get; set; } 
    }
            
    public partial class ManufacturingOrderDeleteView : View
    {
        public ManufacturingOrderDeleteView(ManufacturingOrderDelete screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderDeleteView>("52c14e04-a2fa-4307-a3b9-7d05997e445d","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderDeleteView>("f35ad3bd-7cd5-45c2-964f-e86199fc1022","","",false, this);
 
            Delete = RPSControlFactory.CreateRPSButton<ManufacturingOrderDeleteView>( "3bdf79ad-489f-4dea-b8d1-89cca351826c","","",this);
 

        }
        public IRPSComboBox<ManufacturingOrderDeleteView> Site { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderDeleteView> ManufacturingOrder { get; set; } 
        public IRPSButton<ManufacturingOrderDeleteView> Delete { get; set; } 
        public ManufacturingOrderDelete Screen { get; set; }
        public ManufacturingOrderDeleteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
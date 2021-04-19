    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.CPQParameter
{
    //RPS VERSION 1.0.0.0
    public partial class CPQParameter:Screen
    {
        public CPQParameter():base()
        {
            this.URL = "configurator.cpqparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CPQParameterEntityView  = new CPQParameterEntityView(this); 
            CPQParameterEntityView.InitializeControls(); 
           
        }
      
            public CPQParameterEntityView CPQParameterEntityView {get; set; } 
    }
            
    public partial class CPQParameterEntityView : View
    {
        public CPQParameterEntityView(CPQParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCodingSerieCPQProduct = RPSControlFactory.CreateRPSComboBox<CPQParameterEntityView>("5e8690b1-3b87-483d-ac2f-20ec8d8093c9","","",false, this);
 
            IDDocumentLabel = RPSControlFactory.CreateRPSComboBox<CPQParameterEntityView>("64fa18b4-65c4-419d-845e-e6597d01d5be","","",false, this);
 

        }
        public IRPSComboBox<CPQParameterEntityView> IDCodingSerieCPQProduct { get; set; } 
        public IRPSComboBox<CPQParameterEntityView> IDDocumentLabel { get; set; } 
        public CPQParameter Screen { get; set; }
        public CPQParameterEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
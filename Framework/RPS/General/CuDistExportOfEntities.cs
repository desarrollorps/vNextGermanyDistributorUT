    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CuDistExportOfEntities
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistExportOfEntities:Screen
    {
        public CuDistExportOfEntities():base()
        {
            this.URL = "general.cudistexportofentities";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistExportOfEntitiesView  = new CuDistExportOfEntitiesView(this); 
            CuDistExportOfEntitiesView.InitializeControls(); 
           
        }
      
            public CuDistExportOfEntitiesView CuDistExportOfEntitiesView {get; set; } 
    }
            
    public partial class CuDistExportOfEntitiesView : View
    {
        public CuDistExportOfEntitiesView(CuDistExportOfEntities screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MainFieldOfSelectedEntity = RPSControlFactory.CreateRPSEnumComboBox<CuDistExportOfEntitiesView>("2df9c928-73ee-4c5b-bf4f-26610abd09cc","","",false, this);
 
            ExecuteCuDistExportOfEntitiesQuerySource = RPSControlFactory.CreateRPSButton<CuDistExportOfEntitiesView>( "d470da08-6e93-46d1-9f65-d7546be91519","","",this);
 
            IncludeFK = RPSControlFactory.CreateRPSCheckBox<CuDistExportOfEntitiesView>("306d7ed7-1f0f-419c-b294-0e2a092a0e95","","",false, this);
 
            Path = RPSControlFactory.CreateRPSTextBox<CuDistExportOfEntitiesView>("6f795498-c8f3-402e-8842-1b190ab4293a","","",false, this);
 
            CuDistExportToCSVCommand = RPSControlFactory.CreateRPSButton<CuDistExportOfEntitiesView>( "2eb167ad-4275-49aa-a5bb-36c3d108d316","","",this);
 

        }
        public IRPSComboBox<CuDistExportOfEntitiesView> MainFieldOfSelectedEntity { get; set; } 
        public IRPSButton<CuDistExportOfEntitiesView> ExecuteCuDistExportOfEntitiesQuerySource { get; set; } 
        public IRPSCheckbox<CuDistExportOfEntitiesView> IncludeFK { get; set; } 
        public IRPSTextBox<CuDistExportOfEntitiesView> Path { get; set; } 
        public IRPSButton<CuDistExportOfEntitiesView> CuDistExportToCSVCommand { get; set; } 
        public CuDistExportOfEntities Screen { get; set; }
        public CuDistExportOfEntitiesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
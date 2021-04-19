    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SituationChange
{
    //RPS VERSION 1.0.0.0
    public partial class SituationChange:Screen
    {
        public SituationChange():base()
        {
            this.URL = "manufacturing.situationchange";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationChangeView  = new SituationChangeView(this); 
            SituationChangeView.InitializeControls(); 
           
        }
      
            public SituationChangeView SituationChangeView {get; set; } 
    }
            
    public partial class SituationChangeView : View
    {
        public SituationChangeView(SituationChange screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("49218da0-8352-4679-a2ff-6d33404c966a","","",false, this);
 
            LstIdSourceManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<SituationChangeView>("9bd16415-60d1-4e76-8c71-3efbaf342f24","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<SituationChangeView>( "7b3eabcf-e6a0-46ca-9666-742ef7870c4d","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<SituationChangeView>( "b7112319-2408-43d7-b81f-12b48983985d","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<SituationChangeView>("efb2de40-0a73-47ed-ad51-edce5628444e","","",false, this);
 
            FromTo = RPSControlFactory.CreateRPSOption<SituationChangeView>( "1bee1428-852a-4e10-a728-7abb1038c272","","",this);
 
            ManufacturingOrderFrom = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("337d929e-4bfe-4ee5-a5a7-0128de1c7956","","",false, this);
 
            ManufacturingOrderTo = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("a86725e0-61a6-493c-94d7-82567a7ca348","","",false, this);
 
            NewManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("5a8a0978-755d-48a7-aa0e-355c8a4a402a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("c8bced70-3a11-48d9-9760-bb862742457a","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("de42ed81-9286-4335-ac58-033d0d5561df","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSButton<SituationChangeView>( "040c6b5a-e04f-48dd-82be-90ce504f9dce","","",this);
 

        }
        public IRPSComboBox<SituationChangeView> Site { get; set; } 
        public IRPSCollectionComboBox<SituationChangeView> LstIdSourceManufacturingOrderSituation { get; set; } 
        public IRPSOption<SituationChangeView> All { get; set; } 
        public IRPSOption<SituationChangeView> Selected { get; set; } 
        public IRPSCollectionComboBox<SituationChangeView> ManufacturingOrder { get; set; } 
        public IRPSOption<SituationChangeView> FromTo { get; set; } 
        public IRPSComboBox<SituationChangeView> ManufacturingOrderFrom { get; set; } 
        public IRPSComboBox<SituationChangeView> ManufacturingOrderTo { get; set; } 
        public IRPSComboBox<SituationChangeView> NewManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<SituationChangeView> Date { get; set; } 
        public IRPSTextBox<SituationChangeView> InternalCode { get; set; } 
        public IRPSButton<SituationChangeView> Apply { get; set; } 
        public SituationChange Screen { get; set; }
        public SituationChangeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Prices
{
    //RPS VERSION 1.0.0.0
    public partial class Prices:Screen
    {
        public Prices():base()
        {
            this.URL = "warehouse.prices";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PricesView  = new PricesView(this); 
            PricesView.InitializeControls(); 
           
        }
      
            public PricesView PricesView {get; set; } 
    }
            
    public partial class PricesView : View
    {
        public PricesView(Prices screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<PricesView>("07f9e1c9-4333-408e-84dd-218104198e12","","",false, this);
 
            MeasureUnit = RPSControlFactory.CreateRPSComboBox<PricesView>("4e34468b-31c6-4f04-928c-313feac747e5","","",false, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("ba0d0c4c-f7bb-42b4-8e64-5e607d736a7f","","",false, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("f8d66fca-813a-4461-8560-33a0f0ec1cbf","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("9ea6c0d1-0500-44d8-9394-e34cbbf1c3e2","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("8f448a73-1bf0-495a-b7ea-330da0b65d3f","","",false, this);
 
            PurchasePrice1 = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("3ac42db6-b140-42e9-9dae-595af5af5d6b","","",false, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<PricesView>("b23b8211-3337-49c8-8707-7f163a5fad5d","","",false, this);
 
            ManufacturePrice1 = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("65c3e3be-ccf9-44d7-99b8-9aa48ff48fdf","","",false, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<PricesView>("bc58f2e3-605c-4b62-9ba8-7ea2da033b66","","",false, this);
 
            AveragePrice1 = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("bd92d7e5-1438-40e6-ae34-f908beed94f3","","",false, this);
 
            StandardPrice1 = RPSControlFactory.CreateRPSFormattedTextBox<PricesView>("904b3ecd-fb69-4760-8dec-899465b83a60","","",false, this);
 

        }
        public IRPSComboBox<PricesView> Article { get; set; } 
        public IRPSComboBox<PricesView> MeasureUnit { get; set; } 
        public IRPSTextBox<PricesView> PurchasePrice { get; set; } 
        public IRPSTextBox<PricesView> ManufacturePrice { get; set; } 
        public IRPSTextBox<PricesView> AveragePrice { get; set; } 
        public IRPSTextBox<PricesView> StandardPrice { get; set; } 
        public IRPSTextBox<PricesView> PurchasePrice1 { get; set; } 
        public IRPSTextBox<PricesView> PurchaseDate { get; set; } 
        public IRPSTextBox<PricesView> ManufacturePrice1 { get; set; } 
        public IRPSTextBox<PricesView> ManufactureDate { get; set; } 
        public IRPSTextBox<PricesView> AveragePrice1 { get; set; } 
        public IRPSTextBox<PricesView> StandardPrice1 { get; set; } 
        public Prices Screen { get; set; }
        public PricesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
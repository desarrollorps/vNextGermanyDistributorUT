    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.QuotaCostYear
{
    //RPS VERSION 1.0.0.0
    public partial class QuotaCostYear:Screen
    {
        public QuotaCostYear():base()
        {
            this.URL = "manufacturing.quotacostyear";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QuotaCostYearView  = new QuotaCostYearView(this); 
            QuotaCostYearView.InitializeControls(); 
           
        }
      
            public QuotaCostYearView QuotaCostYearView {get; set; } 
    }
            
    public partial class QuotaCostYearView : View
    {
        public QuotaCostYearView(QuotaCostYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDate = RPSControlFactory.CreateRPSTextBox<QuotaCostYearView>("1798c1b3-9fef-465b-a8e9-3d708852138f","","",true, this);
 
            UIHourType = RPSControlFactory.CreateRPSCollectionComboBox<QuotaCostYearView>("d5f55caf-6df4-44f1-ae05-088a49114a3d","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("1ea2d48f-17c8-454e-9961-290f70a247a3","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("77ec0a2d-5542-4ae8-b4b2-a433436c4270","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("9ee55515-1236-41ae-be40-9fc9ae6bab63","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("7d69b61b-1a3f-493b-ba2d-331ddaba4b19","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("bcbc4a03-6ffb-4e88-9c9f-99b3645afe10","","",false, this);
 
            UICostComponent = RPSControlFactory.CreateRPSCheckBox<QuotaCostYearView>("6e6b2629-0ddc-4358-bf88-fd4a3b1c666d","","",false, this);
 
            UIBalance = RPSControlFactory.CreateRPSFormattedTextBox<QuotaCostYearView>("8c70a92b-4f71-4d18-9133-959f728fb425","","",false, this);
 
            GetDataCommand = RPSControlFactory.CreateRPSButton<QuotaCostYearView>( "a7476633-f7eb-4e3c-aca1-210abd95a475","","",this);
 
            ExecuteQuotaCostYearSaveDataButton = RPSControlFactory.CreateRPSButton<QuotaCostYearView>( "9f9c2cb7-113e-4aa2-bca6-08c1eac5adc1","","",this);
 
            CreateRatesCommandButton = RPSControlFactory.CreateRPSButton<QuotaCostYearView>( "c8e40c04-2b61-45c3-be52-80f0f0688f14","","",this);
 

        }
        public IRPSTextBox<QuotaCostYearView> UIDate { get; set; } 
        public IRPSCollectionComboBox<QuotaCostYearView> UIHourType { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UIQualify { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UIEmployee { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UIMachine { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UIMachineGroup { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UITool { get; set; } 
        public IRPSCheckbox<QuotaCostYearView> UICostComponent { get; set; } 
        public IRPSTextBox<QuotaCostYearView> UIBalance { get; set; } 
        public IRPSButton<QuotaCostYearView> GetDataCommand { get; set; } 
        public IRPSButton<QuotaCostYearView> ExecuteQuotaCostYearSaveDataButton { get; set; } 
        public IRPSButton<QuotaCostYearView> CreateRatesCommandButton { get; set; } 
        public QuotaCostYear Screen { get; set; }
        public QuotaCostYearView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
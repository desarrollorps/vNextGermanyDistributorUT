    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.QuotaCostReal
{
    //RPS VERSION 1.0.0.0
    public partial class QuotaCostReal:Screen
    {
        public QuotaCostReal():base()
        {
            this.URL = "manufacturing.quotacostreal";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QuotaCostRealView  = new QuotaCostRealView(this); 
            QuotaCostRealView.InitializeControls(); 
           
        }
      
            public QuotaCostRealView QuotaCostRealView {get; set; } 
    }
            
    public partial class QuotaCostRealView : View
    {
        public QuotaCostRealView(QuotaCostReal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIYear = RPSControlFactory.CreateRPSFormattedTextBox<QuotaCostRealView>("a4594664-5aaf-4a88-82b0-080e1cb45b3b","","",false, this);
 
            UIMonth = RPSControlFactory.CreateRPSFormattedTextBox<QuotaCostRealView>("88eff99e-3607-4439-8347-917ba740885b","","",false, this);
 
            UIHourType = RPSControlFactory.CreateRPSCollectionComboBox<QuotaCostRealView>("ca0947d4-a124-46ec-b0b1-d254c36ad9dc","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("a65b2489-e2dd-4ff0-ae34-c2c0de8ad463","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("b86fb9a1-8247-4799-9435-83087c0c1ef0","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("fd20e65c-2876-4f3f-a2e1-d71e879faa97","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("d41f4be9-e945-4552-b418-a869d435c3d6","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("2b567c3a-4eb7-4173-bafa-8e56a91d5d6b","","",false, this);
 
            UICostComponent = RPSControlFactory.CreateRPSCheckBox<QuotaCostRealView>("2e380f23-60a6-4c6d-bd63-53a2e241ddae","","",false, this);
 
            UIBalance = RPSControlFactory.CreateRPSFormattedTextBox<QuotaCostRealView>("5a40ae14-e829-498f-9bf5-70e573d20a3c","","",false, this);
 
            GetDataCommand = RPSControlFactory.CreateRPSButton<QuotaCostRealView>( "e6c4f65a-ea18-4838-ae62-98f896164e67","","",this);
 
            CreateRatesCommandButton = RPSControlFactory.CreateRPSButton<QuotaCostRealView>( "5ad6a2f2-2fab-416d-b912-3158c5f521c0","","",this);
 

        }
        public IRPSTextBox<QuotaCostRealView> UIYear { get; set; } 
        public IRPSTextBox<QuotaCostRealView> UIMonth { get; set; } 
        public IRPSCollectionComboBox<QuotaCostRealView> UIHourType { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UIQualify { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UIEmployee { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UIMachine { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UIMachineGroup { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UITool { get; set; } 
        public IRPSCheckbox<QuotaCostRealView> UICostComponent { get; set; } 
        public IRPSTextBox<QuotaCostRealView> UIBalance { get; set; } 
        public IRPSButton<QuotaCostRealView> GetDataCommand { get; set; } 
        public IRPSButton<QuotaCostRealView> CreateRatesCommandButton { get; set; } 
        public QuotaCostReal Screen { get; set; }
        public QuotaCostRealView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
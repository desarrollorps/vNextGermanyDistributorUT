    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PurchaseAmountByMonth
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseAmountByMonth:Screen
    {
        public PurchaseAmountByMonth():base()
        {
            this.URL = "purchase.purchaseamountbymonth";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseAmountByMonthView  = new PurchaseAmountByMonthView(this); 
            PurchaseAmountByMonthView.InitializeControls(); 
           
        }
      
            public PurchaseAmountByMonthView PurchaseAmountByMonthView {get; set; } 
    }
            
    public partial class PurchaseAmountByMonthView : View
    {
        public PurchaseAmountByMonthView(PurchaseAmountByMonth screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseAmountByMonthView>("c8e53259-f164-4f77-b44a-9150919eca1d","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<PurchaseAmountByMonthView>( "","ul li[rpsid='2eed556b-a9b3-4877-ab9c-c91df2b97d1e']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<PurchaseAmountByMonthView>( "","ul li[rpsid='ca8b5193-a1ce-4f70-9679-278e26954367']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<PurchaseAmountByMonthView>( "","ul li[rpsid='aa6c61ea-8a54-4c95-a5b0-802cd847c966']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<PurchaseAmountByMonthView>( "","ul li[rpsid='4f0624e1-7573-4dd3-b207-5a80a419dc6f']","",this);
 
            Section4 = RPSControlFactory.CreateRPSSection<PurchaseAmountByMonthView>( "","ul li[rpsid='3cc2d2ab-1dd8-45e2-bb71-a4ee434bf0d7']","",this);
 

        }
        public IRPSTextBox<PurchaseAmountByMonthView> Year { get; set; } 
        public IRPSSection<PurchaseAmountByMonthView> Section { get; set; } 
        public IRPSSection<PurchaseAmountByMonthView> Section1 { get; set; } 
        public IRPSSection<PurchaseAmountByMonthView> Section2 { get; set; } 
        public IRPSSection<PurchaseAmountByMonthView> Section3 { get; set; } 
        public IRPSSection<PurchaseAmountByMonthView> Section4 { get; set; } 
        public PurchaseAmountByMonth Screen { get; set; }
        public PurchaseAmountByMonthView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
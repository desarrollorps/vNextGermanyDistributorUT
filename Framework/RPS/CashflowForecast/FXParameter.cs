    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXParameter
{
    //RPS VERSION 1.0.0.0
    public partial class FXParameter:Screen
    {
        public FXParameter():base()
        {
            this.URL = "cashflowforecast.fxparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXParameterEntityView  = new FXParameterEntityView(this); 
            FXParameterEntityView.InitializeControls(); 
           
        }
      
            public FXParameterEntityView FXParameterEntityView {get; set; } 
    }
            
    public partial class FXParameterEntityView : View
    {
        public FXParameterEntityView(FXParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<FXParameterEntityView>("0d99796b-3602-435e-9647-93d2bb98ecbc","","",false, this);
 
            IDPaymentMethodSL = RPSControlFactory.CreateRPSComboBox<FXParameterEntityView>("0b466453-6378-4364-a05b-8b7e25c0d38f","","",false, this);
 
            TaxPercentagePUR = RPSControlFactory.CreateRPSFormattedTextBox<FXParameterEntityView>("a26331af-79a6-44bc-ae72-b9f187a897cb","","",true, this);
 
            TaxPercentageSAL = RPSControlFactory.CreateRPSFormattedTextBox<FXParameterEntityView>("ac713851-5fad-4486-9e57-8d0d6f3f6d69","","",true, this);
 
            AvgInvoiceDaysPUR = RPSControlFactory.CreateRPSFormattedTextBox<FXParameterEntityView>("fafd1c5f-5654-4fc9-8221-8ad51262ba9a","","",true, this);
 
            AvgInvoiceDaysSAL = RPSControlFactory.CreateRPSFormattedTextBox<FXParameterEntityView>("98f30d99-83cf-4033-ab9e-efe205d8a4e6","","",true, this);
 
            IDAccountClusterDeposit = RPSControlFactory.CreateRPSComboBox<FXParameterEntityView>("7ba80d92-32b9-4a88-91c2-78dd9257a45e","","",false, this);
 
            CollectionInit params_GENFXParameterCategorys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11cd9eee-0db6-4e46-94e1-117546baea6a",CSSSelectorGrid="",XPathGrid=""};
            GENFXParameterCategorys = RPSControlFactory.RPSCreateCollectionWithGrid<GENFXParameterCategorysCollectionEditor<FXParameterEntityView>,FXParameterEntityView>( params_GENFXParameterCategorys,this);
 

        }
        public IRPSComboBox<FXParameterEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<FXParameterEntityView> IDPaymentMethodSL { get; set; } 
        public IRPSTextBox<FXParameterEntityView> TaxPercentagePUR { get; set; } 
        public IRPSTextBox<FXParameterEntityView> TaxPercentageSAL { get; set; } 
        public IRPSTextBox<FXParameterEntityView> AvgInvoiceDaysPUR { get; set; } 
        public IRPSTextBox<FXParameterEntityView> AvgInvoiceDaysSAL { get; set; } 
        public IRPSComboBox<FXParameterEntityView> IDAccountClusterDeposit { get; set; } 
        public GENFXParameterCategorysCollectionEditor<FXParameterEntityView> GENFXParameterCategorys { get; set; } 
        public FXParameter Screen { get; set; }
        public FXParameterEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENFXParameterCategorysCollectionEditor<FXParameterEntityView>:RPSCollectionEditor<FXParameterEntityView> where FXParameterEntityView : class, IView
    {
        public  GENFXParameterCategorysGridView<FXParameterEntityView> GridView {get;set;}
    }
    public partial class GENFXParameterCategorysGridView <FXParameterEntityView> :  RPSGridView<FXParameterEntityView> where FXParameterEntityView : class, IView
    {
        public GENFXParameterCategorysGridView(FXParameterEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<FXParameterEntityView>("","#11cd9eee-0db6-4e46-94e1-117546baea6a .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FXParameterEntityView> IDBudgetCategory { get; set; } 
                     
    }
 
    }
  
    

}
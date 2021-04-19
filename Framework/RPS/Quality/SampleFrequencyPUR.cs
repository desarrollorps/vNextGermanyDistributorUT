    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SampleFrequencyPUR
{
    //RPS VERSION 1.0.0.0
    public partial class SampleFrequencyPUR:Screen
    {
        public SampleFrequencyPUR():base()
        {
            this.URL = "quality.samplefrequencypur";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SampleFrecuencyPURVMQueryView  = new SampleFrecuencyPURVMQueryView(this); 
            SampleFrecuencyPURVMEntityView  = new SampleFrecuencyPURVMEntityView(this); 
            SampleFrecuencyPURVMQueryView.InitializeControls(); 
            SampleFrecuencyPURVMEntityView.InitializeControls(); 
           
        }
      
            public SampleFrecuencyPURVMQueryView SampleFrecuencyPURVMQueryView {get; set; } 
            public SampleFrecuencyPURVMEntityView SampleFrecuencyPURVMEntityView {get; set; } 
    }
            
    public partial class SampleFrecuencyPURVMQueryView : View
    {
        public SampleFrecuencyPURVMQueryView(SampleFrequencyPUR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView>( this,Screen.SampleFrecuencyPURVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SampleFrecuencyPURVMQueryView>( this);
 
            Article = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyPURVMQueryView>("d1efc434-6cb0-462d-9bce-1910f4297f92","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyPURVMQueryView>("62be385c-4a17-4f4f-b57a-2135a63ccec2","","",false, this);
 
            CollectionInit params_SampleFrecuencyPURQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be28ce39-549f-4e03-b142-2fc36e9b8418",CSSSelectorGrid="",XPathGrid=""};
            SampleFrecuencyPURQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SampleFrecuencyPURQueryCollectionEditor<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView>,SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView>( params_SampleFrecuencyPURQuery,this,Screen.SampleFrecuencyPURVMEntityView);
 

        }
        public IRPSButton<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> NewButton { get; set; } 
        public IRPSButton<SampleFrecuencyPURVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<SampleFrecuencyPURVMQueryView> Article { get; set; } 
        public IRPSComboBox<SampleFrecuencyPURVMQueryView> Supplier { get; set; } 
        public SampleFrecuencyPURQueryCollectionEditor<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> SampleFrecuencyPURQuery { get; set; } 
        public SampleFrequencyPUR Screen { get; set; }
        public SampleFrecuencyPURVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SampleFrecuencyPURQueryCollectionEditor<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView>:RPSCollectionEditor<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> where SampleFrecuencyPURVMQueryView : class, IView where SampleFrecuencyPURVMEntityView : class, IView
    {
        public  SampleFrecuencyPURQueryGridView<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> GridView {get;set;}
    }
    public partial class SampleFrecuencyPURQueryGridView <SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> :  RPSGridView<SampleFrecuencyPURVMQueryView,SampleFrecuencyPURVMEntityView> where SampleFrecuencyPURVMQueryView : class, IView where SampleFrecuencyPURVMEntityView : class, IView
    {
        public SampleFrecuencyPURQueryGridView(SampleFrecuencyPURVMQueryView currentView,SampleFrecuencyPURVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SampleFrecuencyPUR_QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<SampleFrecuencyPURVMQueryView>("","#be28ce39-549f-4e03-b142-2fc36e9b8418 .ag-row[role='row']@ROWINDEX [col-id='cSampleFrecuencyPUR_QuantityFrom']","",false, this.CurrentView);
 
            SampleFrecuencyPUR_QuantitySample = RPSControlFactory.CreateRPSGridFormattedTextBox<SampleFrecuencyPURVMQueryView>("","#be28ce39-549f-4e03-b142-2fc36e9b8418 .ag-row[role='row']@ROWINDEX [col-id='cSampleFrecuencyPUR_QuantitySample']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SampleFrecuencyPURVMQueryView> SampleFrecuencyPUR_QuantityFrom { get; set; } 
        public IRPSGridTextBox<SampleFrecuencyPURVMQueryView> SampleFrecuencyPUR_QuantitySample { get; set; } 
                     
    }
 
    }
  
            
    public partial class SampleFrecuencyPURVMEntityView : View
    {
        public SampleFrecuencyPURVMEntityView(SampleFrequencyPUR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SampleFrecuencyPURVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleFrecuencyPURVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleFrecuencyPURVMEntityView,SampleFrecuencyPURVMQueryView>( this,Screen.SampleFrecuencyPURVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleFrecuencyPURVMEntityView,SampleFrecuencyPURVMQueryView>( this,Screen.SampleFrecuencyPURVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyPURVMEntityView>("365c83b9-ac40-4e98-aab2-4aa0e73f6799","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyPURVMEntityView>("42fe2834-6d07-4454-88f8-f0c680a57a2f","","",false, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<SampleFrecuencyPURVMEntityView>("cdf08b49-5abf-490b-965a-87c630a93648","","",true, this);
 
            QuantitySample = RPSControlFactory.CreateRPSFormattedTextBox<SampleFrecuencyPURVMEntityView>("33494923-7bff-4e16-b4cf-efe396965d99","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<SampleFrecuencyPURVMEntityView>("23989efc-8c91-420b-a9bb-3fe08aa7363a","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SampleFrecuencyPURVMEntityView>( "","ul li[rpsid='1ee26c67-8689-4cda-9407-95eb0a55c72d']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SampleFrecuencyPURVMEntityView>( "","ul li[rpsid='ebfc1ca2-97cb-4c14-bd71-f7bc7c34cffa']","",this);
 

        }
        public IRPSSaveButton<SampleFrecuencyPURVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SampleFrecuencyPURVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SampleFrecuencyPURVMEntityView,SampleFrecuencyPURVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleFrecuencyPURVMEntityView,SampleFrecuencyPURVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SampleFrecuencyPURVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<SampleFrecuencyPURVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<SampleFrecuencyPURVMEntityView> QuantityFrom { get; set; } 
        public IRPSTextBox<SampleFrecuencyPURVMEntityView> QuantitySample { get; set; } 
        public IRPSTextBox<SampleFrecuencyPURVMEntityView> Comments { get; set; } 
        public IRPSSection<SampleFrecuencyPURVMEntityView> Section { get; set; } 
        public IRPSSection<SampleFrecuencyPURVMEntityView> Section1 { get; set; } 
        public SampleFrequencyPUR Screen { get; set; }
        public SampleFrecuencyPURVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
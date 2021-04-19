    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SampleFrequencyCPR
{
    //RPS VERSION 1.0.0.0
    public partial class SampleFrequencyCPR:Screen
    {
        public SampleFrequencyCPR():base()
        {
            this.URL = "quality.samplefrequencycpr";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SampleFrecuencyCPRVMQueryView  = new SampleFrecuencyCPRVMQueryView(this); 
            SampleFrecuencyCPRVMEntityView  = new SampleFrecuencyCPRVMEntityView(this); 
            SampleFrecuencyCPRVMQueryView.InitializeControls(); 
            SampleFrecuencyCPRVMEntityView.InitializeControls(); 
           
        }
      
            public SampleFrecuencyCPRVMQueryView SampleFrecuencyCPRVMQueryView {get; set; } 
            public SampleFrecuencyCPRVMEntityView SampleFrecuencyCPRVMEntityView {get; set; } 
    }
            
    public partial class SampleFrecuencyCPRVMQueryView : View
    {
        public SampleFrecuencyCPRVMQueryView(SampleFrequencyCPR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView>( this,Screen.SampleFrecuencyCPRVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SampleFrecuencyCPRVMQueryView>( this);
 
            Article = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyCPRVMQueryView>("8c7dd26e-2835-4c35-8214-48b182130840","","",false, this);
 
            CollectionInit params_SampleFrequencyCPRQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4e01284a-e3de-4f81-9940-9065a5d91ad1",CSSSelectorGrid="",XPathGrid=""};
            SampleFrequencyCPRQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SampleFrequencyCPRQueryCollectionEditor<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView>,SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView>( params_SampleFrequencyCPRQuery,this,Screen.SampleFrecuencyCPRVMEntityView);
 

        }
        public IRPSButton<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> NewButton { get; set; } 
        public IRPSButton<SampleFrecuencyCPRVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<SampleFrecuencyCPRVMQueryView> Article { get; set; } 
        public SampleFrequencyCPRQueryCollectionEditor<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> SampleFrequencyCPRQuery { get; set; } 
        public SampleFrequencyCPR Screen { get; set; }
        public SampleFrecuencyCPRVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SampleFrequencyCPRQueryCollectionEditor<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView>:RPSCollectionEditor<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> where SampleFrecuencyCPRVMQueryView : class, IView where SampleFrecuencyCPRVMEntityView : class, IView
    {
        public  SampleFrequencyCPRQueryGridView<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> GridView {get;set;}
    }
    public partial class SampleFrequencyCPRQueryGridView <SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> :  RPSGridView<SampleFrecuencyCPRVMQueryView,SampleFrecuencyCPRVMEntityView> where SampleFrecuencyCPRVMQueryView : class, IView where SampleFrecuencyCPRVMEntityView : class, IView
    {
        public SampleFrequencyCPRQueryGridView(SampleFrecuencyCPRVMQueryView currentView,SampleFrecuencyCPRVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SampleFrecuencyCPR_QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<SampleFrecuencyCPRVMQueryView>("","#4e01284a-e3de-4f81-9940-9065a5d91ad1 .ag-row[role='row']@ROWINDEX [col-id='cSampleFrecuencyCPR_QuantityFrom']","",false, this.CurrentView);
 
            SampleFrecuencyCPR_QuantitySample = RPSControlFactory.CreateRPSGridFormattedTextBox<SampleFrecuencyCPRVMQueryView>("","#4e01284a-e3de-4f81-9940-9065a5d91ad1 .ag-row[role='row']@ROWINDEX [col-id='cSampleFrecuencyCPR_QuantitySample']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SampleFrecuencyCPRVMQueryView> SampleFrecuencyCPR_QuantityFrom { get; set; } 
        public IRPSGridTextBox<SampleFrecuencyCPRVMQueryView> SampleFrecuencyCPR_QuantitySample { get; set; } 
                     
    }
 
    }
  
            
    public partial class SampleFrecuencyCPRVMEntityView : View
    {
        public SampleFrecuencyCPRVMEntityView(SampleFrequencyCPR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SampleFrecuencyCPRVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SampleFrecuencyCPRVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SampleFrecuencyCPRVMEntityView,SampleFrecuencyCPRVMQueryView>( this,Screen.SampleFrecuencyCPRVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SampleFrecuencyCPRVMEntityView,SampleFrecuencyCPRVMQueryView>( this,Screen.SampleFrecuencyCPRVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SampleFrecuencyCPRVMEntityView>("701f4429-103f-426b-a90c-1a8350a28679","","",false, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<SampleFrecuencyCPRVMEntityView>("2acdc79a-8e43-4c10-bc97-44e68c8f619a","","",true, this);
 
            QuantitySample = RPSControlFactory.CreateRPSFormattedTextBox<SampleFrecuencyCPRVMEntityView>("09c489c3-fcab-4b29-8956-60fdeac2cd4c","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<SampleFrecuencyCPRVMEntityView>("ffe4c702-3f01-43a7-b6ae-4a49e35391e3","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SampleFrecuencyCPRVMEntityView>( "","ul li[rpsid='9e0df583-697c-404c-beaf-ce4e534f1c01']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SampleFrecuencyCPRVMEntityView>( "","ul li[rpsid='2deaa108-2952-4b63-a133-f013d9c71a14']","",this);
 

        }
        public IRPSSaveButton<SampleFrecuencyCPRVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SampleFrecuencyCPRVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SampleFrecuencyCPRVMEntityView,SampleFrecuencyCPRVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SampleFrecuencyCPRVMEntityView,SampleFrecuencyCPRVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SampleFrecuencyCPRVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<SampleFrecuencyCPRVMEntityView> QuantityFrom { get; set; } 
        public IRPSTextBox<SampleFrecuencyCPRVMEntityView> QuantitySample { get; set; } 
        public IRPSTextBox<SampleFrecuencyCPRVMEntityView> Comments { get; set; } 
        public IRPSSection<SampleFrecuencyCPRVMEntityView> Section { get; set; } 
        public IRPSSection<SampleFrecuencyCPRVMEntityView> Section1 { get; set; } 
        public SampleFrequencyCPR Screen { get; set; }
        public SampleFrecuencyCPRVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
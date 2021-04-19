    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SeverityVsOccurrence
{
    //RPS VERSION 1.0.0.0
    public partial class SeverityVsOccurrence:Screen
    {
        public SeverityVsOccurrence():base()
        {
            this.URL = "quality.severityvsoccurrence";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SeverityVsOccurrenceVMCollectionView  = new SeverityVsOccurrenceVMCollectionView(this); 
            SeverityVsOccurrenceVMCollectionView.InitializeControls(); 
           
        }
      
            public SeverityVsOccurrenceVMCollectionView SeverityVsOccurrenceVMCollectionView {get; set; } 
    }
            
    public partial class SeverityVsOccurrenceVMCollectionView : View
    {
        public SeverityVsOccurrenceVMCollectionView(SeverityVsOccurrence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LinkFMEAActionPriorityUpdateButton = RPSControlFactory.CreateRPSButton<SeverityVsOccurrenceVMCollectionView>( "0af846bb-2d2f-4743-9891-63550cf1906c","","",this);
 
            CollectionInit params_SeverityVsOccurrence = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e6840953-7c87-493b-9d9c-f16f592611bc",CSSSelectorGrid="",XPathGrid=""};
            SeverityVsOccurrence = RPSControlFactory.RPSCreateCollectionWithGrid<SeverityVsOccurrenceCollectionEditor<SeverityVsOccurrenceVMCollectionView>,SeverityVsOccurrenceVMCollectionView>( params_SeverityVsOccurrence,this);
 

        }
        public IRPSButton<SeverityVsOccurrenceVMCollectionView> LinkFMEAActionPriorityUpdateButton { get; set; } 
        public SeverityVsOccurrenceCollectionEditor<SeverityVsOccurrenceVMCollectionView> SeverityVsOccurrence { get; set; } 
        public SeverityVsOccurrence Screen { get; set; }
        public SeverityVsOccurrenceVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeverityVsOccurrenceCollectionEditor<SeverityVsOccurrenceVMCollectionView>:RPSCollectionEditor<SeverityVsOccurrenceVMCollectionView> where SeverityVsOccurrenceVMCollectionView : class, IView
    {
        public  SeverityVsOccurrenceGridView<SeverityVsOccurrenceVMCollectionView> GridView {get;set;}
    }
    public partial class SeverityVsOccurrenceGridView <SeverityVsOccurrenceVMCollectionView> :  RPSGridView<SeverityVsOccurrenceVMCollectionView> where SeverityVsOccurrenceVMCollectionView : class, IView
    {
        public SeverityVsOccurrenceGridView(SeverityVsOccurrenceVMCollectionView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SeverityValue = RPSControlFactory.CreateRPSGridFormattedTextBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cSeverityValue']","",true, this.CurrentView);
 
            Occurrence1 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence1']","",true, this.CurrentView);
 
            Occurrence2 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence2']","",true, this.CurrentView);
 
            Occurrence3 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence3']","",true, this.CurrentView);
 
            Occurrence4 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence4']","",true, this.CurrentView);
 
            Occurrence5 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence5']","",true, this.CurrentView);
 
            Occurrence6 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence6']","",true, this.CurrentView);
 
            Occurrence7 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence7']","",true, this.CurrentView);
 
            Occurrence8 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence8']","",true, this.CurrentView);
 
            Occurrence9 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence9']","",true, this.CurrentView);
 
            Occurrence10 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsOccurrenceVMCollectionView>("","#e6840953-7c87-493b-9d9c-f16f592611bc .ag-row[role='row']@ROWINDEX [col-id='cOccurrence10']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SeverityVsOccurrenceVMCollectionView> SeverityValue { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence1 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence2 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence3 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence4 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence5 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence6 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence7 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence8 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence9 { get; set; } 
        public IRPSGridComboBox<SeverityVsOccurrenceVMCollectionView> Occurrence10 { get; set; } 
                     
    }
 
    }
  
    

}
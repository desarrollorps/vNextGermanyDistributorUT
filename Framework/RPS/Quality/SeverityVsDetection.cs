    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SeverityVsDetection
{
    //RPS VERSION 1.0.0.0
    public partial class SeverityVsDetection:Screen
    {
        public SeverityVsDetection():base()
        {
            this.URL = "quality.severityvsdetection";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SeverityVsDetectionVMCollectionView  = new SeverityVsDetectionVMCollectionView(this); 
            SeverityVsDetectionVMCollectionView.InitializeControls(); 
           
        }
      
            public SeverityVsDetectionVMCollectionView SeverityVsDetectionVMCollectionView {get; set; } 
    }
            
    public partial class SeverityVsDetectionVMCollectionView : View
    {
        public SeverityVsDetectionVMCollectionView(SeverityVsDetection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LinkFMEAActionPriorityUpdateButton = RPSControlFactory.CreateRPSButton<SeverityVsDetectionVMCollectionView>( "420ffc58-9b51-4a2f-a189-196e37068e91","","",this);
 
            CollectionInit params_SeverityVsDetection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2f34bf76-fec5-440a-b126-639f22b30619",CSSSelectorGrid="",XPathGrid=""};
            SeverityVsDetection = RPSControlFactory.RPSCreateCollectionWithGrid<SeverityVsDetectionCollectionEditor<SeverityVsDetectionVMCollectionView>,SeverityVsDetectionVMCollectionView>( params_SeverityVsDetection,this);
 

        }
        public IRPSButton<SeverityVsDetectionVMCollectionView> LinkFMEAActionPriorityUpdateButton { get; set; } 
        public SeverityVsDetectionCollectionEditor<SeverityVsDetectionVMCollectionView> SeverityVsDetection { get; set; } 
        public SeverityVsDetection Screen { get; set; }
        public SeverityVsDetectionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeverityVsDetectionCollectionEditor<SeverityVsDetectionVMCollectionView>:RPSCollectionEditor<SeverityVsDetectionVMCollectionView> where SeverityVsDetectionVMCollectionView : class, IView
    {
        public  SeverityVsDetectionGridView<SeverityVsDetectionVMCollectionView> GridView {get;set;}
    }
    public partial class SeverityVsDetectionGridView <SeverityVsDetectionVMCollectionView> :  RPSGridView<SeverityVsDetectionVMCollectionView> where SeverityVsDetectionVMCollectionView : class, IView
    {
        public SeverityVsDetectionGridView(SeverityVsDetectionVMCollectionView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SeverityValue = RPSControlFactory.CreateRPSGridFormattedTextBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cSeverityValue']","",true, this.CurrentView);
 
            Detection1 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection1']","",true, this.CurrentView);
 
            Detection2 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection2']","",true, this.CurrentView);
 
            Detection3 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection3']","",true, this.CurrentView);
 
            Detection4 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection4']","",true, this.CurrentView);
 
            Detection5 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection5']","",true, this.CurrentView);
 
            Detection6 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection6']","",true, this.CurrentView);
 
            Detection7 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection7']","",true, this.CurrentView);
 
            Detection8 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection8']","",true, this.CurrentView);
 
            Detection9 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection9']","",true, this.CurrentView);
 
            Detection10 = RPSControlFactory.CreateRPSGridEnumComboBox<SeverityVsDetectionVMCollectionView>("","#2f34bf76-fec5-440a-b126-639f22b30619 .ag-row[role='row']@ROWINDEX [col-id='cDetection10']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SeverityVsDetectionVMCollectionView> SeverityValue { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection1 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection2 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection3 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection4 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection5 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection6 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection7 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection8 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection9 { get; set; } 
        public IRPSGridComboBox<SeverityVsDetectionVMCollectionView> Detection10 { get; set; } 
                     
    }
 
    }
  
    

}
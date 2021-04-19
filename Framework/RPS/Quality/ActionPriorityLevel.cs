    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ActionPriorityLevel
{
    //RPS VERSION 1.0.0.0
    public partial class ActionPriorityLevel:Screen
    {
        public ActionPriorityLevel():base()
        {
            this.URL = "quality.actionprioritylevel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ActionPriorityLevelVMCollectionView  = new ActionPriorityLevelVMCollectionView(this); 
            ActionPriorityLevelVMCollectionView.InitializeControls(); 
           
        }
      
            public ActionPriorityLevelVMCollectionView ActionPriorityLevelVMCollectionView {get; set; } 
    }
            
    public partial class ActionPriorityLevelVMCollectionView : View
    {
        public ActionPriorityLevelVMCollectionView(ActionPriorityLevel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LinkFMEAActionPriorityUpdateButton = RPSControlFactory.CreateRPSButton<ActionPriorityLevelVMCollectionView>( "9504ddc2-e4b8-4bdc-8388-64effaadb49b","","",this);
 
            CollectionInit params_ActionPriorityLevel = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6769939f-17bf-4a28-831f-c9382a98f61b",CSSSelectorGrid="",XPathGrid=""};
            ActionPriorityLevel = RPSControlFactory.RPSCreateCollectionWithGrid<ActionPriorityLevelCollectionEditor<ActionPriorityLevelVMCollectionView>,ActionPriorityLevelVMCollectionView>( params_ActionPriorityLevel,this);
 

        }
        public IRPSButton<ActionPriorityLevelVMCollectionView> LinkFMEAActionPriorityUpdateButton { get; set; } 
        public ActionPriorityLevelCollectionEditor<ActionPriorityLevelVMCollectionView> ActionPriorityLevel { get; set; } 
        public ActionPriorityLevel Screen { get; set; }
        public ActionPriorityLevelVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ActionPriorityLevelCollectionEditor<ActionPriorityLevelVMCollectionView>:RPSCollectionEditor<ActionPriorityLevelVMCollectionView> where ActionPriorityLevelVMCollectionView : class, IView
    {
        public  ActionPriorityLevelGridView<ActionPriorityLevelVMCollectionView> GridView {get;set;}
    }
    public partial class ActionPriorityLevelGridView <ActionPriorityLevelVMCollectionView> :  RPSGridView<ActionPriorityLevelVMCollectionView> where ActionPriorityLevelVMCollectionView : class, IView
    {
        public ActionPriorityLevelGridView(ActionPriorityLevelVMCollectionView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SeverityVsOccurrence = RPSControlFactory.CreateRPSGridEnumComboBox<ActionPriorityLevelVMCollectionView>("","#6769939f-17bf-4a28-831f-c9382a98f61b .ag-row[role='row']@ROWINDEX [col-id='cSeverityVsOccurrence']","",true, this.CurrentView);
 
            SeverityVsDetection = RPSControlFactory.CreateRPSGridEnumComboBox<ActionPriorityLevelVMCollectionView>("","#6769939f-17bf-4a28-831f-c9382a98f61b .ag-row[role='row']@ROWINDEX [col-id='cSeverityVsDetection']","",true, this.CurrentView);
 
            ActionPriority = RPSControlFactory.CreateRPSGridEnumComboBox<ActionPriorityLevelVMCollectionView>("","#6769939f-17bf-4a28-831f-c9382a98f61b .ag-row[role='row']@ROWINDEX [col-id='cActionPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ActionPriorityLevelVMCollectionView> SeverityVsOccurrence { get; set; } 
        public IRPSGridComboBox<ActionPriorityLevelVMCollectionView> SeverityVsDetection { get; set; } 
        public IRPSGridComboBox<ActionPriorityLevelVMCollectionView> ActionPriority { get; set; } 
                     
    }
 
    }
  
    

}
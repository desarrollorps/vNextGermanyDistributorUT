    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.TrackingFromOrders
{
    //RPS VERSION 1.0.0.0
    public partial class TrackingFromOrders:Screen
    {
        public TrackingFromOrders():base()
        {
            this.URL = "manufacturing.trackingfromorders";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TrackingFromOrdersView  = new TrackingFromOrdersView(this); 
            TrackingFromOrdersView.InitializeControls(); 
           
        }
      
            public TrackingFromOrdersView TrackingFromOrdersView {get; set; } 
    }
            
    public partial class TrackingFromOrdersView : View
    {
        public TrackingFromOrdersView(TrackingFromOrders screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<TrackingFromOrdersView>("65adf633-fc3d-4834-b22f-f9bca9ee42e6","","",true, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<TrackingFromOrdersView>("afb2f1c2-3683-48d0-9092-61d1d2861ded","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<TrackingFromOrdersView>("6ca175aa-5ac3-4e26-a027-93b2eec1657b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<TrackingFromOrdersView>("fea616fc-d0c6-44c3-bd6d-1a0aa8d12faf","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<TrackingFromOrdersView>("067776e9-5107-4a38-ae47-a3a676d11d4e","","",false, this);
 
            ExecuteTrackingFromOrdersPrecalc = RPSControlFactory.CreateRPSButton<TrackingFromOrdersView>( "6da1add9-31a4-4fe5-bf6d-0d9b8a2c9094","","",this);
 
            CollectionInit params_TrackingFromOrderArticleLevel = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="323042ec-78a9-41ed-9993-997be9d2ddb1",CSSSelectorGrid="",XPathGrid=""};
            TrackingFromOrderArticleLevel = RPSControlFactory.RPSCreateCollectionWithGrid<TrackingFromOrderArticleLevelCollectionEditor<TrackingFromOrdersView>,TrackingFromOrdersView>( params_TrackingFromOrderArticleLevel,this);
 
            CollectionInit params_TrackingFromOrderMOLevel = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be06e9a9-31fc-4e5e-9c2a-aa8583414ba3",CSSSelectorGrid="",XPathGrid=""};
            TrackingFromOrderMOLevel = RPSControlFactory.RPSCreateCollectionWithGrid<TrackingFromOrderMOLevelCollectionEditor<TrackingFromOrdersView>,TrackingFromOrdersView>( params_TrackingFromOrderMOLevel,this);
 

        }
        public IRPSComboBox<TrackingFromOrdersView> Site { get; set; } 
        public IRPSCollectionComboBox<TrackingFromOrdersView> Article { get; set; } 
        public IRPSCollectionComboBox<TrackingFromOrdersView> Customer { get; set; } 
        public IRPSTextBox<TrackingFromOrdersView> DateFrom { get; set; } 
        public IRPSTextBox<TrackingFromOrdersView> DateTo { get; set; } 
        public IRPSButton<TrackingFromOrdersView> ExecuteTrackingFromOrdersPrecalc { get; set; } 
        public TrackingFromOrderArticleLevelCollectionEditor<TrackingFromOrdersView> TrackingFromOrderArticleLevel { get; set; } 
        public TrackingFromOrderMOLevelCollectionEditor<TrackingFromOrdersView> TrackingFromOrderMOLevel { get; set; } 
        public TrackingFromOrders Screen { get; set; }
        public TrackingFromOrdersView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TrackingFromOrderArticleLevelCollectionEditor<TrackingFromOrdersView>:RPSCollectionEditor<TrackingFromOrdersView> where TrackingFromOrdersView : class, IView
    {
        public  TrackingFromOrderArticleLevelGridView<TrackingFromOrdersView> GridView {get;set;}
    }
    public partial class TrackingFromOrderArticleLevelGridView <TrackingFromOrdersView> :  RPSGridView<TrackingFromOrdersView> where TrackingFromOrdersView : class, IView
    {
        public TrackingFromOrderArticleLevelGridView(TrackingFromOrdersView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class TrackingFromOrderMOLevelCollectionEditor<TrackingFromOrdersView>:RPSCollectionEditor<TrackingFromOrdersView> where TrackingFromOrdersView : class, IView
    {
        public  TrackingFromOrderMOLevelGridView<TrackingFromOrdersView> GridView {get;set;}
    }
    public partial class TrackingFromOrderMOLevelGridView <TrackingFromOrdersView> :  RPSGridView<TrackingFromOrdersView> where TrackingFromOrdersView : class, IView
    {
        public TrackingFromOrderMOLevelGridView(TrackingFromOrdersView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<TrackingFromOrdersView>("","#be06e9a9-31fc-4e5e-9c2a-aa8583414ba3 .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TrackingFromOrdersView> PlannedEndDate { get; set; } 
                     
    }
 
    }
  
    

}
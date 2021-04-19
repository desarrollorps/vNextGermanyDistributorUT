    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.TransportRouteSL
{
    //RPS VERSION 1.0.0.0
    public partial class TransportRouteSL:Screen
    {
        public TransportRouteSL():base()
        {
            this.URL = "sales.transportroutesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TransportRouteSLCollectionView  = new TransportRouteSLCollectionView(this); 
            TransportRouteSLEntityView  = new TransportRouteSLEntityView(this); 
            TransportRouteCustomerSLView  = new TransportRouteCustomerSLView(this); 
            TransportRouteSLCollectionView.InitializeControls(); 
            TransportRouteSLEntityView.InitializeControls(); 
            TransportRouteCustomerSLView.InitializeControls(); 
           
        }
      
            public TransportRouteSLCollectionView TransportRouteSLCollectionView {get; set; } 
            public TransportRouteSLEntityView TransportRouteSLEntityView {get; set; } 
            public TransportRouteCustomerSLView TransportRouteCustomerSLView {get; set; } 
    }
            
    public partial class TransportRouteSLCollectionView : View
    {
        public TransportRouteSLCollectionView(TransportRouteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TransportRouteSLCollectionView,TransportRouteSLEntityView>( this,Screen.TransportRouteSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f828fef0-3c83-4512-b511-187d896ecdf4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TransportRouteSLCollectionView,TransportRouteSLEntityView>( params_MainConsult,this,Screen.TransportRouteSLEntityView);
 

        }
        public IRPSButton<TransportRouteSLCollectionView,TransportRouteSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TransportRouteSLCollectionView,TransportRouteSLEntityView> MainConsult { get; set; } 
        public TransportRouteSL Screen { get; set; }
        public TransportRouteSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TransportRouteSLEntityView : View
    {
        public TransportRouteSLEntityView(TransportRouteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TransportRouteSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TransportRouteSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TransportRouteSLEntityView,TransportRouteSLCollectionView>( this,Screen.TransportRouteSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TransportRouteSLEntityView,TransportRouteSLCollectionView>( this,Screen.TransportRouteSLCollectionView);
 
            CodTransportRoute = RPSControlFactory.CreateRPSTextBox<TransportRouteSLEntityView>("edb149e4-c1c2-4ee8-97b7-12d8c89c0da3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TransportRouteSLEntityView>("642fc356-24b5-44dd-a632-3f47f0db5de2","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<TransportRouteSLEntityView>("b76d09a9-2c04-4315-8ad4-a43417b67605","","",false, this);
 
            CollectionInit params_TransportRouteCustomerSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9799476b-093d-4f15-9958-60c42ef385ce",CSSSelectorGrid="",XPathGrid=""};
            TransportRouteCustomerSLs = RPSControlFactory.RPSCreateCollectionWithGrid<TransportRouteCustomerSLsCollectionEditor<TransportRouteSLEntityView,TransportRouteCustomerSLView>,TransportRouteSLEntityView,TransportRouteCustomerSLView>( params_TransportRouteCustomerSLs,this,Screen.TransportRouteCustomerSLView);
 

        }
        public IRPSSaveButton<TransportRouteSLEntityView> SaveButton { get; set; } 
        public IRPSButton<TransportRouteSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<TransportRouteSLEntityView,TransportRouteSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TransportRouteSLEntityView,TransportRouteSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TransportRouteSLEntityView> CodTransportRoute { get; set; } 
        public IRPSTextBox<TransportRouteSLEntityView> Description { get; set; } 
        public IRPSComboBox<TransportRouteSLEntityView> IDShippingAgent { get; set; } 
        public TransportRouteCustomerSLsCollectionEditor<TransportRouteSLEntityView,TransportRouteCustomerSLView> TransportRouteCustomerSLs { get; set; } 
        public TransportRouteSL Screen { get; set; }
        public TransportRouteSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TransportRouteCustomerSLsCollectionEditor<TransportRouteSLEntityView,TransportRouteCustomerSLView>:RPSCollectionEditor<TransportRouteSLEntityView,TransportRouteCustomerSLView> where TransportRouteSLEntityView : class, IView where TransportRouteCustomerSLView : class, IView
    {
        public  TransportRouteCustomerSLsGridView<TransportRouteSLEntityView,TransportRouteCustomerSLView> GridView {get;set;}
    }
    public partial class TransportRouteCustomerSLsGridView <TransportRouteSLEntityView,TransportRouteCustomerSLView> :  RPSGridView<TransportRouteSLEntityView,TransportRouteCustomerSLView> where TransportRouteSLEntityView : class, IView where TransportRouteCustomerSLView : class, IView
    {
        public TransportRouteCustomerSLsGridView(TransportRouteSLEntityView currentView,TransportRouteCustomerSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<TransportRouteSLEntityView>("","#9799476b-093d-4f15-9958-60c42ef385ce .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",true, this.CurrentView);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSGridComboBox<TransportRouteSLEntityView>("","#9799476b-093d-4f15-9958-60c42ef385ce .ag-row[role='row']@ROWINDEX [col-id='cIDCustomerDeliveryAddress']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<TransportRouteSLEntityView>("","#9799476b-093d-4f15-9958-60c42ef385ce .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TransportRouteSLEntityView>("","#9799476b-093d-4f15-9958-60c42ef385ce .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TransportRouteSLEntityView> IDCustomer { get; set; } 
        public IRPSGridComboBox<TransportRouteSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSGridTextBox<TransportRouteSLEntityView> Priority { get; set; } 
        public IRPSGridTextBox<TransportRouteSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class TransportRouteCustomerSLView : View
    {
        public TransportRouteCustomerSLView(TransportRouteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TransportRouteCustomerSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TransportRouteCustomerSLView,TransportRouteSLEntityView>( this,Screen.TransportRouteSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TransportRouteCustomerSLView,TransportRouteSLEntityView>( this,Screen.TransportRouteSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TransportRouteCustomerSLView,TransportRouteSLEntityView>( this,Screen.TransportRouteSLEntityView);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<TransportRouteCustomerSLView>("6166fd2b-af16-454f-b589-bf9b6e840808","","",true, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<TransportRouteCustomerSLView>("70c10ecf-621f-4fef-8e55-da9a97cd166d","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<TransportRouteCustomerSLView>("00c568ba-ded5-4c0d-8a5b-37995a32bce4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TransportRouteCustomerSLView>("658766c2-f0e6-4ccf-bdf2-12af47597def","","",false, this);
 

        }
        public IRPSButton<TransportRouteCustomerSLView> DeleteButton { get; set; } 
        public IRPSButton<TransportRouteCustomerSLView,TransportRouteSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TransportRouteCustomerSLView,TransportRouteSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TransportRouteCustomerSLView,TransportRouteSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TransportRouteCustomerSLView> IDCustomer { get; set; } 
        public IRPSComboBox<TransportRouteCustomerSLView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<TransportRouteCustomerSLView> Priority { get; set; } 
        public IRPSTextBox<TransportRouteCustomerSLView> Description { get; set; } 
        public TransportRouteSL Screen { get; set; }
        public TransportRouteCustomerSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
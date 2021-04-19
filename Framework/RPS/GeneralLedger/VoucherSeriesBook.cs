    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VoucherSeriesBook
{
    //RPS VERSION 1.0.0.0
    public partial class VoucherSeriesBook:Screen
    {
        public VoucherSeriesBook():base()
        {
            this.URL = "generalledger.voucherseriesbook";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VoucherSeriesBookCollectionView  = new VoucherSeriesBookCollectionView(this); 
            VoucherSeriesBookEntityView  = new VoucherSeriesBookEntityView(this); 
            VoucherSeriesBookDetailView  = new VoucherSeriesBookDetailView(this); 
            VoucherSeriesBookCollectionView.InitializeControls(); 
            VoucherSeriesBookEntityView.InitializeControls(); 
            VoucherSeriesBookDetailView.InitializeControls(); 
           
        }
      
            public VoucherSeriesBookCollectionView VoucherSeriesBookCollectionView {get; set; } 
            public VoucherSeriesBookEntityView VoucherSeriesBookEntityView {get; set; } 
            public VoucherSeriesBookDetailView VoucherSeriesBookDetailView {get; set; } 
    }
            
    public partial class VoucherSeriesBookCollectionView : View
    {
        public VoucherSeriesBookCollectionView(VoucherSeriesBook screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VoucherSeriesBookCollectionView,VoucherSeriesBookEntityView>( this,Screen.VoucherSeriesBookEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a61fe9bf-cec0-4ec8-af17-b8e71a370fef",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VoucherSeriesBookCollectionView,VoucherSeriesBookEntityView>( params_MainConsult,this,Screen.VoucherSeriesBookEntityView);
 

        }
        public IRPSButton<VoucherSeriesBookCollectionView,VoucherSeriesBookEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VoucherSeriesBookCollectionView,VoucherSeriesBookEntityView> MainConsult { get; set; } 
        public VoucherSeriesBook Screen { get; set; }
        public VoucherSeriesBookCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VoucherSeriesBookEntityView : View
    {
        public VoucherSeriesBookEntityView(VoucherSeriesBook screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VoucherSeriesBookEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherSeriesBookEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherSeriesBookEntityView,VoucherSeriesBookCollectionView>( this,Screen.VoucherSeriesBookCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherSeriesBookEntityView,VoucherSeriesBookCollectionView>( this,Screen.VoucherSeriesBookCollectionView);
 
            CodVoucherSeriesBook = RPSControlFactory.CreateRPSTextBox<VoucherSeriesBookEntityView>("8c6df295-992d-4964-9257-31607c91f2fe","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VoucherSeriesBookEntityView>("a7994931-0a75-4679-93fd-abc34eeb9d7b","","",false, this);
 
            CollectionInit params_VoucherSeriesBookDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="21c63c5a-76e3-407a-b6ea-3fb0812bcef9",CSSSelectorGrid="",XPathGrid=""};
            VoucherSeriesBookDetails = RPSControlFactory.RPSCreateCollectionWithGrid<VoucherSeriesBookDetailsCollectionEditor<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView>,VoucherSeriesBookEntityView,VoucherSeriesBookDetailView>( params_VoucherSeriesBookDetails,this,Screen.VoucherSeriesBookDetailView);
 

        }
        public IRPSSaveButton<VoucherSeriesBookEntityView> SaveButton { get; set; } 
        public IRPSButton<VoucherSeriesBookEntityView> DeleteButton { get; set; } 
        public IRPSButton<VoucherSeriesBookEntityView,VoucherSeriesBookCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherSeriesBookEntityView,VoucherSeriesBookCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VoucherSeriesBookEntityView> CodVoucherSeriesBook { get; set; } 
        public IRPSTextBox<VoucherSeriesBookEntityView> Description { get; set; } 
        public VoucherSeriesBookDetailsCollectionEditor<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView> VoucherSeriesBookDetails { get; set; } 
        public VoucherSeriesBook Screen { get; set; }
        public VoucherSeriesBookEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VoucherSeriesBookDetailsCollectionEditor<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView>:RPSCollectionEditor<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView> where VoucherSeriesBookEntityView : class, IView where VoucherSeriesBookDetailView : class, IView
    {
        public  VoucherSeriesBookDetailsGridView<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView> GridView {get;set;}
    }
    public partial class VoucherSeriesBookDetailsGridView <VoucherSeriesBookEntityView,VoucherSeriesBookDetailView> :  RPSGridView<VoucherSeriesBookEntityView,VoucherSeriesBookDetailView> where VoucherSeriesBookEntityView : class, IView where VoucherSeriesBookDetailView : class, IView
    {
        public VoucherSeriesBookDetailsGridView(VoucherSeriesBookEntityView currentView,VoucherSeriesBookDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<VoucherSeriesBookEntityView>("","#21c63c5a-76e3-407a-b6ea-3fb0812bcef9 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            VoucherLastNumberUsed = RPSControlFactory.CreateRPSGridFormattedTextBox<VoucherSeriesBookEntityView>("","#21c63c5a-76e3-407a-b6ea-3fb0812bcef9 .ag-row[role='row']@ROWINDEX [col-id='cVoucherLastNumberUsed']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<VoucherSeriesBookEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<VoucherSeriesBookEntityView> VoucherLastNumberUsed { get; set; } 
                     
    }
 
    }
  
            
    public partial class VoucherSeriesBookDetailView : View
    {
        public VoucherSeriesBookDetailView(VoucherSeriesBook screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherSeriesBookDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView>( this,Screen.VoucherSeriesBookEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView>( this,Screen.VoucherSeriesBookEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView>( this,Screen.VoucherSeriesBookEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<VoucherSeriesBookDetailView>("68821e23-ef7c-4b84-aea2-1bf615a2a691","","",true, this);
 
            VoucherLastNumberUsed = RPSControlFactory.CreateRPSFormattedTextBox<VoucherSeriesBookDetailView>("924601e8-cf82-4857-9978-7135282cb06b","","",true, this);
 

        }
        public IRPSButton<VoucherSeriesBookDetailView> DeleteButton { get; set; } 
        public IRPSButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VoucherSeriesBookDetailView,VoucherSeriesBookEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<VoucherSeriesBookDetailView> DateFrom { get; set; } 
        public IRPSTextBox<VoucherSeriesBookDetailView> VoucherLastNumberUsed { get; set; } 
        public VoucherSeriesBook Screen { get; set; }
        public VoucherSeriesBookDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
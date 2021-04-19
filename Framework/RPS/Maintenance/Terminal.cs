    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.Terminal
{
    //RPS VERSION 1.0.0.0
    public partial class Terminal:Screen
    {
        public Terminal():base()
        {
            this.URL = "maintenance.terminal";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TerminalCollectionView  = new TerminalCollectionView(this); 
            TerminalEntityView  = new TerminalEntityView(this); 
            TerminalComponentView  = new TerminalComponentView(this); 
            TerminalCollectionView.InitializeControls(); 
            TerminalEntityView.InitializeControls(); 
            TerminalComponentView.InitializeControls(); 
           
        }
      
            public TerminalCollectionView TerminalCollectionView {get; set; } 
            public TerminalEntityView TerminalEntityView {get; set; } 
            public TerminalComponentView TerminalComponentView {get; set; } 
    }
            
    public partial class TerminalCollectionView : View
    {
        public TerminalCollectionView(Terminal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TerminalCollectionView,TerminalEntityView>( this,Screen.TerminalEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "39a837a3-a380-42e6-a5a1-4c9d873ae105",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TerminalCollectionView,TerminalEntityView>( params_MainConsult,this,Screen.TerminalEntityView);
 

        }
        public IRPSButton<TerminalCollectionView,TerminalEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TerminalCollectionView,TerminalEntityView> MainConsult { get; set; } 
        public Terminal Screen { get; set; }
        public TerminalCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TerminalEntityView : View
    {
        public TerminalEntityView(Terminal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TerminalEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TerminalEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TerminalEntityView,TerminalCollectionView>( this,Screen.TerminalCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TerminalEntityView,TerminalCollectionView>( this,Screen.TerminalCollectionView);
 
            CodTerminal = RPSControlFactory.CreateRPSTextBox<TerminalEntityView>("d4b4b3b3-1716-436b-8ed3-66258e71d2c0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TerminalEntityView>("4b487aaf-eb85-4f6d-86fa-babf15f0f0a5","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<TerminalEntityView>("04d84d83-303b-4bf5-9d1e-8016ec0cb579","","",false, this);
 
            CollectionInit params_TerminalComponents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b4f7bf21-9057-49cf-89ef-97d94b3d0761",CSSSelectorGrid="",XPathGrid=""};
            TerminalComponents = RPSControlFactory.RPSCreateCollectionWithGrid<TerminalComponentsCollectionEditor<TerminalEntityView,TerminalComponentView>,TerminalEntityView,TerminalComponentView>( params_TerminalComponents,this,Screen.TerminalComponentView);
 

        }
        public IRPSSaveButton<TerminalEntityView> SaveButton { get; set; } 
        public IRPSButton<TerminalEntityView> DeleteButton { get; set; } 
        public IRPSButton<TerminalEntityView,TerminalCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TerminalEntityView,TerminalCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TerminalEntityView> CodTerminal { get; set; } 
        public IRPSTextBox<TerminalEntityView> Description { get; set; } 
        public IRPSComboBox<TerminalEntityView> CodUser { get; set; } 
        public TerminalComponentsCollectionEditor<TerminalEntityView,TerminalComponentView> TerminalComponents { get; set; } 
        public Terminal Screen { get; set; }
        public TerminalEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TerminalComponentsCollectionEditor<TerminalEntityView,TerminalComponentView>:RPSCollectionEditor<TerminalEntityView,TerminalComponentView> where TerminalEntityView : class, IView where TerminalComponentView : class, IView
    {
        public  TerminalComponentsGridView<TerminalEntityView,TerminalComponentView> GridView {get;set;}
    }
    public partial class TerminalComponentsGridView <TerminalEntityView,TerminalComponentView> :  RPSGridView<TerminalEntityView,TerminalComponentView> where TerminalEntityView : class, IView where TerminalComponentView : class, IView
    {
        public TerminalComponentsGridView(TerminalEntityView currentView,TerminalComponentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceComponent = RPSControlFactory.CreateRPSGridComboBox<TerminalEntityView>("","#b4f7bf21-9057-49cf-89ef-97d94b3d0761 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceComponent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TerminalEntityView> IDMaintenanceComponent { get; set; } 
                     
    }
 
    }
  
            
    public partial class TerminalComponentView : View
    {
        public TerminalComponentView(Terminal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TerminalComponentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TerminalComponentView,TerminalEntityView>( this,Screen.TerminalEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TerminalComponentView,TerminalEntityView>( this,Screen.TerminalEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TerminalComponentView,TerminalEntityView>( this,Screen.TerminalEntityView);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<TerminalComponentView>("d2632073-d12d-4f76-adcf-57acca38c8f5","","",true, this);
 

        }
        public IRPSButton<TerminalComponentView> DeleteButton { get; set; } 
        public IRPSButton<TerminalComponentView,TerminalEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TerminalComponentView,TerminalEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TerminalComponentView,TerminalEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TerminalComponentView> IDMaintenanceComponent { get; set; } 
        public Terminal Screen { get; set; }
        public TerminalComponentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
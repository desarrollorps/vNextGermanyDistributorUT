    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CuDistPrefix
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistPrefix:Screen
    {
        public CuDistPrefix():base()
        {
            this.URL = "general.cudistprefix";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistPrefixVMQueryView  = new CuDistPrefixVMQueryView(this); 
            CuDistPrefixVMEntityView  = new CuDistPrefixVMEntityView(this); 
            CuDistPrefixVMQueryView.InitializeControls(); 
            CuDistPrefixVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistPrefixVMQueryView CuDistPrefixVMQueryView {get; set; } 
            public CuDistPrefixVMEntityView CuDistPrefixVMEntityView {get; set; } 
    }
            
    public partial class CuDistPrefixVMQueryView : View
    {
        public CuDistPrefixVMQueryView(CuDistPrefix screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView>( this,Screen.CuDistPrefixVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistPrefixVMQueryView>( this);
 
            CollectionInit params_CuDistPrefixQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4242affe-b9a2-4a6b-9bde-58477906af83",CSSSelectorGrid="",XPathGrid=""};
            CuDistPrefixQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistPrefixQueryCollectionEditor<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView>,CuDistPrefixVMQueryView,CuDistPrefixVMEntityView>( params_CuDistPrefixQuery,this,Screen.CuDistPrefixVMEntityView);
 

        }
        public IRPSButton<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistPrefixVMQueryView> ConsultButton { get; set; } 
        public CuDistPrefixQueryCollectionEditor<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> CuDistPrefixQuery { get; set; } 
        public CuDistPrefix Screen { get; set; }
        public CuDistPrefixVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistPrefixQueryCollectionEditor<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView>:RPSCollectionEditor<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> where CuDistPrefixVMQueryView : class, IView where CuDistPrefixVMEntityView : class, IView
    {
        public  CuDistPrefixQueryGridView<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> GridView {get;set;}
    }
    public partial class CuDistPrefixQueryGridView <CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> :  RPSGridView<CuDistPrefixVMQueryView,CuDistPrefixVMEntityView> where CuDistPrefixVMQueryView : class, IView where CuDistPrefixVMEntityView : class, IView
    {
        public CuDistPrefixQueryGridView(CuDistPrefixVMQueryView currentView,CuDistPrefixVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistPrefix_CodPrefix = RPSControlFactory.CreateRPSGridTextBox<CuDistPrefixVMQueryView>("","#4242affe-b9a2-4a6b-9bde-58477906af83 .ag-row[role='row']@ROWINDEX [col-id='cCuDistPrefix_CodPrefix']","",false, this.CurrentView);
 
            CuDistPrefix_PrefixType = RPSControlFactory.CreateRPSGridTextBox<CuDistPrefixVMQueryView>("","#4242affe-b9a2-4a6b-9bde-58477906af83 .ag-row[role='row']@ROWINDEX [col-id='cCuDistPrefix_PrefixType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistPrefixVMQueryView> CuDistPrefix_CodPrefix { get; set; } 
        public IRPSGridTextBox<CuDistPrefixVMQueryView> CuDistPrefix_PrefixType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistPrefixVMEntityView : View
    {
        public CuDistPrefixVMEntityView(CuDistPrefix screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistPrefixVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistPrefixVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistPrefixVMEntityView,CuDistPrefixVMQueryView>( this,Screen.CuDistPrefixVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistPrefixVMEntityView,CuDistPrefixVMQueryView>( this,Screen.CuDistPrefixVMQueryView);
 
            CodPrefix = RPSControlFactory.CreateRPSTextBox<CuDistPrefixVMEntityView>("5bf6978b-e306-439a-96e2-19ee6ee1bfef","","",true, this);
 
            PrefixType = RPSControlFactory.CreateRPSEnumComboBox<CuDistPrefixVMEntityView>("99653e6c-24b5-4298-ba92-ceed24089210","","",true, this);
 

        }
        public IRPSSaveButton<CuDistPrefixVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistPrefixVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistPrefixVMEntityView,CuDistPrefixVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistPrefixVMEntityView,CuDistPrefixVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<CuDistPrefixVMEntityView> CodPrefix { get; set; } 
        public IRPSComboBox<CuDistPrefixVMEntityView> PrefixType { get; set; } 
        public CuDistPrefix Screen { get; set; }
        public CuDistPrefixVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
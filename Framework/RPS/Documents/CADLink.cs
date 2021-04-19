    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.CADLink
{
    //RPS VERSION 1.0.0.0
    public partial class CADLink:Screen
    {
        public CADLink():base()
        {
            this.URL = "documents.cadlink";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CADLinkQueryView  = new CADLinkQueryView(this); 
            CADLinkQueryView.InitializeControls(); 
           
        }
      
            public CADLinkQueryView CADLinkQueryView {get; set; } 
    }
            
    public partial class CADLinkQueryView : View
    {
        public CADLinkQueryView(CADLink screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDesignCode = RPSControlFactory.CreateRPSTextBox<CADLinkQueryView>("165502f0-9746-4ede-afab-27e5e80e093d","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSComboBox<CADLinkQueryView>("d100f222-1632-413c-80e7-3e571c680c6f","","",false, this);
 
            CollectionInit params_GetCADLinkComplete = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="23d4ccd6-e0da-47bf-b317-5b89b688d725",CSSSelectorGrid="",XPathGrid=""};
            GetCADLinkComplete = RPSControlFactory.RPSCreateCollectionWithGrid<GetCADLinkCompleteCollectionEditor<CADLinkQueryView>,CADLinkQueryView>( params_GetCADLinkComplete,this);
 

        }
        public IRPSTextBox<CADLinkQueryView> UIDesignCode { get; set; } 
        public IRPSComboBox<CADLinkQueryView> Article1 { get; set; } 
        public GetCADLinkCompleteCollectionEditor<CADLinkQueryView> GetCADLinkComplete { get; set; } 
        public CADLink Screen { get; set; }
        public CADLinkQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetCADLinkCompleteCollectionEditor<CADLinkQueryView>:RPSCollectionEditor<CADLinkQueryView> where CADLinkQueryView : class, IView
    {
        public  GetCADLinkCompleteGridView<CADLinkQueryView> GridView {get;set;}
    }
    public partial class GetCADLinkCompleteGridView <CADLinkQueryView> :  RPSGridView<CADLinkQueryView> where CADLinkQueryView : class, IView
    {
        public GetCADLinkCompleteGridView(CADLinkQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CadLink_DesignCode = RPSControlFactory.CreateRPSGridTextBox<CADLinkQueryView>("","#23d4ccd6-e0da-47bf-b317-5b89b688d725 .ag-row[role='row']@ROWINDEX [col-id='cCadLink_DesignCode']","",false, this.CurrentView);
 
            CadLink_Configuration = RPSControlFactory.CreateRPSGridTextBox<CADLinkQueryView>("","#23d4ccd6-e0da-47bf-b317-5b89b688d725 .ag-row[role='row']@ROWINDEX [col-id='cCadLink_Configuration']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CADLinkQueryView> CadLink_DesignCode { get; set; } 
        public IRPSGridTextBox<CADLinkQueryView> CadLink_Configuration { get; set; } 
                     
    }
 
    }
  
    

}
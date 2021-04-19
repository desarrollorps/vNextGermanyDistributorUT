    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.CloseReasonSL
{
    //RPS VERSION 1.0.0.0
    public partial class CloseReasonSL:Screen
    {
        public CloseReasonSL():base()
        {
            this.URL = "salescrm.closereasonsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CloseReasonSLQueryView  = new CloseReasonSLQueryView(this); 
            CloseReasonSLEntityView  = new CloseReasonSLEntityView(this); 
            CloseReasonSLQueryView.InitializeControls(); 
            CloseReasonSLEntityView.InitializeControls(); 
           
        }
      
            public CloseReasonSLQueryView CloseReasonSLQueryView {get; set; } 
            public CloseReasonSLEntityView CloseReasonSLEntityView {get; set; } 
    }
            
    public partial class CloseReasonSLQueryView : View
    {
        public CloseReasonSLQueryView(CloseReasonSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CloseReasonSLQueryView,CloseReasonSLEntityView>( this,Screen.CloseReasonSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0a9c70d1-7883-4f2c-9b14-cbc249d37350",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CloseReasonSLQueryView,CloseReasonSLEntityView>( params_MainConsult,this,Screen.CloseReasonSLEntityView);
 

        }
        public IRPSButton<CloseReasonSLQueryView,CloseReasonSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CloseReasonSLQueryView,CloseReasonSLEntityView> MainConsult { get; set; } 
        public CloseReasonSL Screen { get; set; }
        public CloseReasonSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CloseReasonSLEntityView : View
    {
        public CloseReasonSLEntityView(CloseReasonSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CloseReasonSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CloseReasonSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CloseReasonSLEntityView,CloseReasonSLQueryView>( this,Screen.CloseReasonSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CloseReasonSLEntityView,CloseReasonSLQueryView>( this,Screen.CloseReasonSLQueryView);
 
            CodCloseReason = RPSControlFactory.CreateRPSTextBox<CloseReasonSLEntityView>("b360fbb0-fe02-4a84-89f8-d363c1fd5fe0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CloseReasonSLEntityView>("0e4ee80a-5fb7-464f-92c4-018633fac0fc","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CloseReasonSLEntityView>("9f658c68-ac1c-4169-a305-b35d163a01d4","","",true, this);
 
            IDSalesQuoteStatus = RPSControlFactory.CreateRPSComboBox<CloseReasonSLEntityView>("d3078cc7-c589-41ba-a177-08e85f989c77","","",false, this);
 

        }
        public IRPSSaveButton<CloseReasonSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CloseReasonSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CloseReasonSLEntityView,CloseReasonSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CloseReasonSLEntityView,CloseReasonSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<CloseReasonSLEntityView> CodCloseReason { get; set; } 
        public IRPSTextBox<CloseReasonSLEntityView> Description { get; set; } 
        public IRPSComboBox<CloseReasonSLEntityView> Type { get; set; } 
        public IRPSComboBox<CloseReasonSLEntityView> IDSalesQuoteStatus { get; set; } 
        public CloseReasonSL Screen { get; set; }
        public CloseReasonSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
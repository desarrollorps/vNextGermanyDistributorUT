    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.LeadSourceSL
{
    //RPS VERSION 1.0.0.0
    public partial class LeadSourceSL:Screen
    {
        public LeadSourceSL():base()
        {
            this.URL = "salescrm.leadsourcesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LeadSourceSLQueryView  = new LeadSourceSLQueryView(this); 
            LeadSourceSLEntityView  = new LeadSourceSLEntityView(this); 
            LeadSourceSLQueryView.InitializeControls(); 
            LeadSourceSLEntityView.InitializeControls(); 
           
        }
      
            public LeadSourceSLQueryView LeadSourceSLQueryView {get; set; } 
            public LeadSourceSLEntityView LeadSourceSLEntityView {get; set; } 
    }
            
    public partial class LeadSourceSLQueryView : View
    {
        public LeadSourceSLQueryView(LeadSourceSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<LeadSourceSLQueryView,LeadSourceSLEntityView>( this,Screen.LeadSourceSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "65d2c247-fab2-4172-88a0-47b75b0cefaf",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<LeadSourceSLQueryView,LeadSourceSLEntityView>( params_MainConsult,this,Screen.LeadSourceSLEntityView);
 

        }
        public IRPSButton<LeadSourceSLQueryView,LeadSourceSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<LeadSourceSLQueryView,LeadSourceSLEntityView> MainConsult { get; set; } 
        public LeadSourceSL Screen { get; set; }
        public LeadSourceSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LeadSourceSLEntityView : View
    {
        public LeadSourceSLEntityView(LeadSourceSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<LeadSourceSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<LeadSourceSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LeadSourceSLEntityView,LeadSourceSLQueryView>( this,Screen.LeadSourceSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<LeadSourceSLEntityView,LeadSourceSLQueryView>( this,Screen.LeadSourceSLQueryView);
 
            CodLeadSource = RPSControlFactory.CreateRPSTextBox<LeadSourceSLEntityView>("96229ec2-ef2d-4846-b1a6-e3101e178f70","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<LeadSourceSLEntityView>("cadbecd4-3a20-49e1-80e2-75c25f4cce43","","",false, this);
 

        }
        public IRPSSaveButton<LeadSourceSLEntityView> SaveButton { get; set; } 
        public IRPSButton<LeadSourceSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<LeadSourceSLEntityView,LeadSourceSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LeadSourceSLEntityView,LeadSourceSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<LeadSourceSLEntityView> CodLeadSource { get; set; } 
        public IRPSTextBox<LeadSourceSLEntityView> Description { get; set; } 
        public LeadSourceSL Screen { get; set; }
        public LeadSourceSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialAgentClassificationSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialAgentClassificationSL:Screen
    {
        public CommercialAgentClassificationSL():base()
        {
            this.URL = "sales.commercialagentclassificationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialAgentClassificationSLCollectionView  = new CommercialAgentClassificationSLCollectionView(this); 
            CommercialAgentClassificationSLEntityView  = new CommercialAgentClassificationSLEntityView(this); 
            AgentClassificationByLangSLView  = new AgentClassificationByLangSLView(this); 
            CommercialAgentClassificationSLCollectionView.InitializeControls(); 
            CommercialAgentClassificationSLEntityView.InitializeControls(); 
            AgentClassificationByLangSLView.InitializeControls(); 
           
        }
      
            public CommercialAgentClassificationSLCollectionView CommercialAgentClassificationSLCollectionView {get; set; } 
            public CommercialAgentClassificationSLEntityView CommercialAgentClassificationSLEntityView {get; set; } 
            public AgentClassificationByLangSLView AgentClassificationByLangSLView {get; set; } 
    }
            
    public partial class CommercialAgentClassificationSLCollectionView : View
    {
        public CommercialAgentClassificationSLCollectionView(CommercialAgentClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialAgentClassificationSLCollectionView,CommercialAgentClassificationSLEntityView>( this,Screen.CommercialAgentClassificationSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fc662953-6c72-4027-b5db-c8f858677b29",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialAgentClassificationSLCollectionView,CommercialAgentClassificationSLEntityView>( params_MainConsult,this,Screen.CommercialAgentClassificationSLEntityView);
 

        }
        public IRPSButton<CommercialAgentClassificationSLCollectionView,CommercialAgentClassificationSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialAgentClassificationSLCollectionView,CommercialAgentClassificationSLEntityView> MainConsult { get; set; } 
        public CommercialAgentClassificationSL Screen { get; set; }
        public CommercialAgentClassificationSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialAgentClassificationSLEntityView : View
    {
        public CommercialAgentClassificationSLEntityView(CommercialAgentClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialAgentClassificationSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialAgentClassificationSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialAgentClassificationSLEntityView,CommercialAgentClassificationSLCollectionView>( this,Screen.CommercialAgentClassificationSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialAgentClassificationSLEntityView,CommercialAgentClassificationSLCollectionView>( this,Screen.CommercialAgentClassificationSLCollectionView);
 
            CodCommercialAgentClassification = RPSControlFactory.CreateRPSTextBox<CommercialAgentClassificationSLEntityView>("6a6c51c5-a2a4-428e-9998-4a554ebfb19c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialAgentClassificationSLEntityView>("de4b8031-b2ea-46e3-bfb9-dcc74da5906c","","",false, this);
 
            CollectionInit params_AgentClassificationByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="44434e99-2501-47a6-8df8-fee536a31fff",CSSSelectorGrid="",XPathGrid=""};
            AgentClassificationByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<AgentClassificationByLangSLsCollectionEditor<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView>,CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView>( params_AgentClassificationByLangSLs,this,Screen.AgentClassificationByLangSLView);
 

        }
        public IRPSSaveButton<CommercialAgentClassificationSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialAgentClassificationSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialAgentClassificationSLEntityView,CommercialAgentClassificationSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialAgentClassificationSLEntityView,CommercialAgentClassificationSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialAgentClassificationSLEntityView> CodCommercialAgentClassification { get; set; } 
        public IRPSTextBox<CommercialAgentClassificationSLEntityView> Description { get; set; } 
        public AgentClassificationByLangSLsCollectionEditor<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView> AgentClassificationByLangSLs { get; set; } 
        public CommercialAgentClassificationSL Screen { get; set; }
        public CommercialAgentClassificationSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AgentClassificationByLangSLsCollectionEditor<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView>:RPSCollectionEditor<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView> where CommercialAgentClassificationSLEntityView : class, IView where AgentClassificationByLangSLView : class, IView
    {
        public  AgentClassificationByLangSLsGridView<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView> GridView {get;set;}
    }
    public partial class AgentClassificationByLangSLsGridView <CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView> :  RPSGridView<CommercialAgentClassificationSLEntityView,AgentClassificationByLangSLView> where CommercialAgentClassificationSLEntityView : class, IView where AgentClassificationByLangSLView : class, IView
    {
        public AgentClassificationByLangSLsGridView(CommercialAgentClassificationSLEntityView currentView,AgentClassificationByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CommercialAgentClassificationSLEntityView>("","#44434e99-2501-47a6-8df8-fee536a31fff .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CommercialAgentClassificationSLEntityView>("","#44434e99-2501-47a6-8df8-fee536a31fff .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CommercialAgentClassificationSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CommercialAgentClassificationSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AgentClassificationByLangSLView : View
    {
        public AgentClassificationByLangSLView(CommercialAgentClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AgentClassificationByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView>( this,Screen.CommercialAgentClassificationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView>( this,Screen.CommercialAgentClassificationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView>( this,Screen.CommercialAgentClassificationSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<AgentClassificationByLangSLView>("53e7b8f0-0708-4578-9d5e-4eb2a582972d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AgentClassificationByLangSLView>("0d3a52d6-0365-450e-abcb-196754c5fe41","","",false, this);
 

        }
        public IRPSButton<AgentClassificationByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AgentClassificationByLangSLView,CommercialAgentClassificationSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AgentClassificationByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<AgentClassificationByLangSLView> Description { get; set; } 
        public CommercialAgentClassificationSL Screen { get; set; }
        public AgentClassificationByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ZoneSL
{
    //RPS VERSION 1.0.0.0
    public partial class ZoneSL:Screen
    {
        public ZoneSL():base()
        {
            this.URL = "sales.zonesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ZoneSLCollectionView  = new ZoneSLCollectionView(this); 
            ZoneSLEntityView  = new ZoneSLEntityView(this); 
            ZoneCommercialAgentSLView  = new ZoneCommercialAgentSLView(this); 
            ZoneSLCollectionView.InitializeControls(); 
            ZoneSLEntityView.InitializeControls(); 
            ZoneCommercialAgentSLView.InitializeControls(); 
           
        }
      
            public ZoneSLCollectionView ZoneSLCollectionView {get; set; } 
            public ZoneSLEntityView ZoneSLEntityView {get; set; } 
            public ZoneCommercialAgentSLView ZoneCommercialAgentSLView {get; set; } 
    }
            
    public partial class ZoneSLCollectionView : View
    {
        public ZoneSLCollectionView(ZoneSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ZoneSLCollectionView,ZoneSLEntityView>( this,Screen.ZoneSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "778c1279-e6cf-4330-a0cf-b95e930bd91a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ZoneSLCollectionView,ZoneSLEntityView>( params_MainConsult,this,Screen.ZoneSLEntityView);
 

        }
        public IRPSButton<ZoneSLCollectionView,ZoneSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ZoneSLCollectionView,ZoneSLEntityView> MainConsult { get; set; } 
        public ZoneSL Screen { get; set; }
        public ZoneSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ZoneSLEntityView : View
    {
        public ZoneSLEntityView(ZoneSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ZoneSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ZoneSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ZoneSLEntityView,ZoneSLCollectionView>( this,Screen.ZoneSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ZoneSLEntityView,ZoneSLCollectionView>( this,Screen.ZoneSLCollectionView);
 
            CodZone = RPSControlFactory.CreateRPSTextBox<ZoneSLEntityView>("136c5461-3153-40e4-8407-6260a7d7a83f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ZoneSLEntityView>("87421466-7ed1-4002-ae13-c4478bed3441","","",false, this);
 
            CollectionInit params_ZoneCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="47891fca-3c0a-42c2-ae1b-6b0f2a78726d",CSSSelectorGrid="",XPathGrid=""};
            ZoneCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<ZoneCommercialAgentSLsCollectionEditor<ZoneSLEntityView,ZoneCommercialAgentSLView>,ZoneSLEntityView,ZoneCommercialAgentSLView>( params_ZoneCommercialAgentSLs,this,Screen.ZoneCommercialAgentSLView);
 

        }
        public IRPSSaveButton<ZoneSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ZoneSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ZoneSLEntityView,ZoneSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ZoneSLEntityView,ZoneSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ZoneSLEntityView> CodZone { get; set; } 
        public IRPSTextBox<ZoneSLEntityView> Description { get; set; } 
        public ZoneCommercialAgentSLsCollectionEditor<ZoneSLEntityView,ZoneCommercialAgentSLView> ZoneCommercialAgentSLs { get; set; } 
        public ZoneSL Screen { get; set; }
        public ZoneSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ZoneCommercialAgentSLsCollectionEditor<ZoneSLEntityView,ZoneCommercialAgentSLView>:RPSCollectionEditor<ZoneSLEntityView,ZoneCommercialAgentSLView> where ZoneSLEntityView : class, IView where ZoneCommercialAgentSLView : class, IView
    {
        public  ZoneCommercialAgentSLsGridView<ZoneSLEntityView,ZoneCommercialAgentSLView> GridView {get;set;}
    }
    public partial class ZoneCommercialAgentSLsGridView <ZoneSLEntityView,ZoneCommercialAgentSLView> :  RPSGridView<ZoneSLEntityView,ZoneCommercialAgentSLView> where ZoneSLEntityView : class, IView where ZoneCommercialAgentSLView : class, IView
    {
        public ZoneCommercialAgentSLsGridView(ZoneSLEntityView currentView,ZoneCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<ZoneSLEntityView>("","#47891fca-3c0a-42c2-ae1b-6b0f2a78726d .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<ZoneSLEntityView>("","#47891fca-3c0a-42c2-ae1b-6b0f2a78726d .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ZoneSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<ZoneSLEntityView> IDCommercialAgentClassification { get; set; } 
                     
    }
 
    }
  
            
    public partial class ZoneCommercialAgentSLView : View
    {
        public ZoneCommercialAgentSLView(ZoneSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ZoneCommercialAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ZoneCommercialAgentSLView,ZoneSLEntityView>( this,Screen.ZoneSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ZoneCommercialAgentSLView,ZoneSLEntityView>( this,Screen.ZoneSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ZoneCommercialAgentSLView,ZoneSLEntityView>( this,Screen.ZoneSLEntityView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<ZoneCommercialAgentSLView>("e20303c7-43d1-4426-9bd7-7bfc74e4a547","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<ZoneCommercialAgentSLView>("f5eaa706-05c0-4112-9778-85ac2bb51a7e","","",true, this);
 

        }
        public IRPSButton<ZoneCommercialAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<ZoneCommercialAgentSLView,ZoneSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ZoneCommercialAgentSLView,ZoneSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ZoneCommercialAgentSLView,ZoneSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ZoneCommercialAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<ZoneCommercialAgentSLView> IDCommercialAgentClassification { get; set; } 
        public ZoneSL Screen { get; set; }
        public ZoneCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
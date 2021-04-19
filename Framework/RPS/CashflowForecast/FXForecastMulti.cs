    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXForecastMulti
{
    //RPS VERSION 1.0.0.0
    public partial class FXForecastMulti:Screen
    {
        public FXForecastMulti():base()
        {
            this.URL = "cashflowforecast.fxforecastmulti";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXForecastMultiCollectionView  = new FXForecastMultiCollectionView(this); 
            FXForecastMultiEntityView  = new FXForecastMultiEntityView(this); 
            FXForecastMultiCollectionView.InitializeControls(); 
            FXForecastMultiEntityView.InitializeControls(); 
           
        }
      
            public FXForecastMultiCollectionView FXForecastMultiCollectionView {get; set; } 
            public FXForecastMultiEntityView FXForecastMultiEntityView {get; set; } 
    }
            
    public partial class FXForecastMultiCollectionView : View
    {
        public FXForecastMultiCollectionView(FXForecastMulti screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FXForecastMultiCollectionView,FXForecastMultiEntityView>( this,Screen.FXForecastMultiEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "11e42151-06c0-4962-950e-6e39cad9d88f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FXForecastMultiCollectionView,FXForecastMultiEntityView>( params_MainConsult,this,Screen.FXForecastMultiEntityView);
 

        }
        public IRPSButton<FXForecastMultiCollectionView,FXForecastMultiEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FXForecastMultiCollectionView,FXForecastMultiEntityView> MainConsult { get; set; } 
        public FXForecastMulti Screen { get; set; }
        public FXForecastMultiCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FXForecastMultiEntityView : View
    {
        public FXForecastMultiEntityView(FXForecastMulti screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FXForecastMultiEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXForecastMultiEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXForecastMultiEntityView,FXForecastMultiCollectionView>( this,Screen.FXForecastMultiCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXForecastMultiEntityView,FXForecastMultiCollectionView>( this,Screen.FXForecastMultiCollectionView);
 
            CodFXForecastMulti = RPSControlFactory.CreateRPSTextBox<FXForecastMultiEntityView>("e5709b9c-8c8c-4c48-8acc-0dd3ff8ae7f3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FXForecastMultiEntityView>("60c774af-e6f7-46c6-9f4e-bbd80fef87ed","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FXForecastMultiEntityView>("234ae70f-c2e1-4ba3-b616-4c5e41f43574","","",false, this);
 
            CollectionInit params_FXForecastMultiCompanys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="25aeeeca-8df6-4fdd-b48b-3dc29976bb59",CSSSelectorGrid="",XPathGrid=""};
            FXForecastMultiCompanys = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastMultiCompanysCollectionEditor<FXForecastMultiEntityView>,FXForecastMultiEntityView>( params_FXForecastMultiCompanys,this);
 
            General = RPSControlFactory.CreateRPSSection<FXForecastMultiEntityView>( "","ul li[rpsid='09a33e48-be9b-4af8-bdbf-34b3a16df75f']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<FXForecastMultiEntityView>( "","ul li[rpsid='76b9cc75-818e-4594-af4c-7f0cb7d0a87a']","",this);
 

        }
        public IRPSSaveButton<FXForecastMultiEntityView> SaveButton { get; set; } 
        public IRPSButton<FXForecastMultiEntityView> DeleteButton { get; set; } 
        public IRPSButton<FXForecastMultiEntityView,FXForecastMultiCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXForecastMultiEntityView,FXForecastMultiCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FXForecastMultiEntityView> CodFXForecastMulti { get; set; } 
        public IRPSTextBox<FXForecastMultiEntityView> Description { get; set; } 
        public IRPSTextBox<FXForecastMultiEntityView> Comment { get; set; } 
        public FXForecastMultiCompanysCollectionEditor<FXForecastMultiEntityView> FXForecastMultiCompanys { get; set; } 
        public IRPSSection<FXForecastMultiEntityView> General { get; set; } 
        public IRPSSection<FXForecastMultiEntityView> Comment1 { get; set; } 
        public FXForecastMulti Screen { get; set; }
        public FXForecastMultiEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXForecastMultiCompanysCollectionEditor<FXForecastMultiEntityView>:RPSCollectionEditor<FXForecastMultiEntityView> where FXForecastMultiEntityView : class, IView
    {
        public  FXForecastMultiCompanysGridView<FXForecastMultiEntityView> GridView {get;set;}
    }
    public partial class FXForecastMultiCompanysGridView <FXForecastMultiEntityView> :  RPSGridView<FXForecastMultiEntityView> where FXForecastMultiEntityView : class, IView
    {
        public FXForecastMultiCompanysGridView(FXForecastMultiEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanySource = RPSControlFactory.CreateRPSGridComboBox<FXForecastMultiEntityView>("","#25aeeeca-8df6-4fdd-b48b-3dc29976bb59 .ag-row[role='row']@ROWINDEX [col-id='cCodCompanySource']","",true, this.CurrentView);
 
            Change = RPSControlFactory.CreateRPSGridFormattedTextBox<FXForecastMultiEntityView>("","#25aeeeca-8df6-4fdd-b48b-3dc29976bb59 .ag-row[role='row']@ROWINDEX [col-id='cChange']","",true, this.CurrentView);
 
            IDFXForecast = RPSControlFactory.CreateRPSGridComboBox<FXForecastMultiEntityView>("","#25aeeeca-8df6-4fdd-b48b-3dc29976bb59 .ag-row[role='row']@ROWINDEX [col-id='cIDFXForecast']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FXForecastMultiEntityView> CodCompanySource { get; set; } 
        public IRPSGridTextBox<FXForecastMultiEntityView> Change { get; set; } 
        public IRPSGridComboBox<FXForecastMultiEntityView> IDFXForecast { get; set; } 
                     
    }
 
    }
  
    

}
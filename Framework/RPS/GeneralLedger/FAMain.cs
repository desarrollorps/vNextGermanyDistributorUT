    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FAMain
{
    //RPS VERSION 1.0.0.0
    public partial class FAMain:Screen
    {
        public FAMain():base()
        {
            this.URL = "generalledger.famain";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FAMainCollectionView  = new FAMainCollectionView(this); 
            FAMainEntityView  = new FAMainEntityView(this); 
            FAMainCollectionView.InitializeControls(); 
            FAMainEntityView.InitializeControls(); 
           
        }
      
            public FAMainCollectionView FAMainCollectionView {get; set; } 
            public FAMainEntityView FAMainEntityView {get; set; } 
    }
            
    public partial class FAMainCollectionView : View
    {
        public FAMainCollectionView(FAMain screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FAMainCollectionView,FAMainEntityView>( this,Screen.FAMainEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e2a3e89e-d828-47a7-ab28-6a1872c328db",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FAMainCollectionView,FAMainEntityView>( params_MainConsult,this,Screen.FAMainEntityView);
 

        }
        public IRPSButton<FAMainCollectionView,FAMainEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FAMainCollectionView,FAMainEntityView> MainConsult { get; set; } 
        public FAMain Screen { get; set; }
        public FAMainCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAMainEntityView : View
    {
        public FAMainEntityView(FAMain screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FAMainEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FAMainEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FAMainEntityView,FAMainCollectionView>( this,Screen.FAMainCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FAMainEntityView,FAMainCollectionView>( this,Screen.FAMainCollectionView);
 
            CodFAMain = RPSControlFactory.CreateRPSTextBox<FAMainEntityView>("d7fe34e6-ca8d-4393-907a-486e07b1bfff","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FAMainEntityView>("87681313-b7a0-4653-8852-0c08a1559428","","",false, this);
 
            CollectionInit params_GetFixedAssetFromFAMain = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="105b60c0-e8bd-4ffa-9ee3-3db13d316e94",CSSSelectorGrid="",XPathGrid=""};
            GetFixedAssetFromFAMain = RPSControlFactory.RPSCreateCollectionWithGrid<GetFixedAssetFromFAMainCollectionEditor<FAMainEntityView>,FAMainEntityView>( params_GetFixedAssetFromFAMain,this);
 

        }
        public IRPSSaveButton<FAMainEntityView> SaveButton { get; set; } 
        public IRPSButton<FAMainEntityView> DeleteButton { get; set; } 
        public IRPSButton<FAMainEntityView,FAMainCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FAMainEntityView,FAMainCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FAMainEntityView> CodFAMain { get; set; } 
        public IRPSTextBox<FAMainEntityView> Description { get; set; } 
        public GetFixedAssetFromFAMainCollectionEditor<FAMainEntityView> GetFixedAssetFromFAMain { get; set; } 
        public FAMain Screen { get; set; }
        public FAMainEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetFixedAssetFromFAMainCollectionEditor<FAMainEntityView>:RPSCollectionEditor<FAMainEntityView> where FAMainEntityView : class, IView
    {
        public  GetFixedAssetFromFAMainGridView<FAMainEntityView> GridView {get;set;}
    }
    public partial class GetFixedAssetFromFAMainGridView <FAMainEntityView> :  RPSGridView<FAMainEntityView> where FAMainEntityView : class, IView
    {
        public GetFixedAssetFromFAMainGridView(FAMainEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}
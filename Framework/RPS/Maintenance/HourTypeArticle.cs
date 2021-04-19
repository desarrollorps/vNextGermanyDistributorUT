    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.HourTypeArticle
{
    //RPS VERSION 1.0.0.0
    public partial class HourTypeArticle:Screen
    {
        public HourTypeArticle():base()
        {
            this.URL = "maintenance.hourtypearticle";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            HourTypeArticleCollectionView  = new HourTypeArticleCollectionView(this); 
            HourTypeArticleEntityView  = new HourTypeArticleEntityView(this); 
            HourTypeArticleCollectionView.InitializeControls(); 
            HourTypeArticleEntityView.InitializeControls(); 
           
        }
      
            public HourTypeArticleCollectionView HourTypeArticleCollectionView {get; set; } 
            public HourTypeArticleEntityView HourTypeArticleEntityView {get; set; } 
    }
            
    public partial class HourTypeArticleCollectionView : View
    {
        public HourTypeArticleCollectionView(HourTypeArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<HourTypeArticleCollectionView,HourTypeArticleEntityView>( this,Screen.HourTypeArticleEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5be0e2df-f03c-4cf7-9c89-4d2dc7af39a9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<HourTypeArticleCollectionView,HourTypeArticleEntityView>( params_MainConsult,this,Screen.HourTypeArticleEntityView);
 

        }
        public IRPSButton<HourTypeArticleCollectionView,HourTypeArticleEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<HourTypeArticleCollectionView,HourTypeArticleEntityView> MainConsult { get; set; } 
        public HourTypeArticle Screen { get; set; }
        public HourTypeArticleCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class HourTypeArticleEntityView : View
    {
        public HourTypeArticleEntityView(HourTypeArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<HourTypeArticleEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<HourTypeArticleEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<HourTypeArticleEntityView,HourTypeArticleCollectionView>( this,Screen.HourTypeArticleCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<HourTypeArticleEntityView,HourTypeArticleCollectionView>( this,Screen.HourTypeArticleCollectionView);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<HourTypeArticleEntityView>("74867f9c-3ded-4cd8-b75d-fde38d9ca11b","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<HourTypeArticleEntityView>("e728d506-79b4-4a30-b79a-4c49ef98b49b","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<HourTypeArticleEntityView>("273db0e7-e3ff-47d5-ad6e-cc40c8a087a0","","",true, this);
 

        }
        public IRPSSaveButton<HourTypeArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<HourTypeArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<HourTypeArticleEntityView,HourTypeArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<HourTypeArticleEntityView,HourTypeArticleCollectionView> BackButton { get; set; } 
        public IRPSComboBox<HourTypeArticleEntityView> IDQualify { get; set; } 
        public IRPSComboBox<HourTypeArticleEntityView> IDHourType { get; set; } 
        public IRPSComboBox<HourTypeArticleEntityView> IDArticle { get; set; } 
        public HourTypeArticle Screen { get; set; }
        public HourTypeArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
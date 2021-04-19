    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TagSubscription
{
    //RPS VERSION 1.0.0.0
    public partial class TagSubscription:Screen
    {
        public TagSubscription():base()
        {
            this.URL = "general.tagsubscription";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TagSubscriptionCollectionView  = new TagSubscriptionCollectionView(this); 
            TagSubscriptionEntityView  = new TagSubscriptionEntityView(this); 
            TagSubscriptionCollectionView.InitializeControls(); 
            TagSubscriptionEntityView.InitializeControls(); 
           
        }
      
            public TagSubscriptionCollectionView TagSubscriptionCollectionView {get; set; } 
            public TagSubscriptionEntityView TagSubscriptionEntityView {get; set; } 
    }
            
    public partial class TagSubscriptionCollectionView : View
    {
        public TagSubscriptionCollectionView(TagSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TagSubscriptionCollectionView,TagSubscriptionEntityView>( this,Screen.TagSubscriptionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c9e74e3b-9d52-4977-84e2-407bc0076368",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TagSubscriptionCollectionView,TagSubscriptionEntityView>( params_MainConsult,this,Screen.TagSubscriptionEntityView);
 

        }
        public IRPSButton<TagSubscriptionCollectionView,TagSubscriptionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TagSubscriptionCollectionView,TagSubscriptionEntityView> MainConsult { get; set; } 
        public TagSubscription Screen { get; set; }
        public TagSubscriptionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TagSubscriptionEntityView : View
    {
        public TagSubscriptionEntityView(TagSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TagSubscriptionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TagSubscriptionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TagSubscriptionEntityView,TagSubscriptionCollectionView>( this,Screen.TagSubscriptionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TagSubscriptionEntityView,TagSubscriptionCollectionView>( this,Screen.TagSubscriptionCollectionView);
 
            UIOptEntityType = RPSControlFactory.CreateRPSOption<TagSubscriptionEntityView>( "cec0e1b4-d452-4f45-a1d6-781579fbd4e7","","",this);
 
            UIOptDocumentCategory = RPSControlFactory.CreateRPSOption<TagSubscriptionEntityView>( "d26c6e0e-852f-485d-986b-cf8d9a775954","","",this);
 
            UIService = RPSControlFactory.CreateRPSEnumComboBox<TagSubscriptionEntityView>("9eb1a06d-0b82-4bb7-ab66-6df334cadc48","","",false, this);
 
            EntityType = RPSControlFactory.CreateRPSEnumComboBox<TagSubscriptionEntityView>("1cb31e46-7724-469b-a9ae-0808b3ec8a07","","",true, this);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<TagSubscriptionEntityView>("f3929aa3-811e-4f28-8280-0f40a0fedd19","","",false, this);
 
            UIDocumentCategory = RPSControlFactory.CreateRPSComboBox<TagSubscriptionEntityView>("8d8002bf-6de2-495c-916e-bf4df4d84dc0","","",false, this);
 

        }
        public IRPSSaveButton<TagSubscriptionEntityView> SaveButton { get; set; } 
        public IRPSButton<TagSubscriptionEntityView> DeleteButton { get; set; } 
        public IRPSButton<TagSubscriptionEntityView,TagSubscriptionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TagSubscriptionEntityView,TagSubscriptionCollectionView> BackButton { get; set; } 
        public IRPSOption<TagSubscriptionEntityView> UIOptEntityType { get; set; } 
        public IRPSOption<TagSubscriptionEntityView> UIOptDocumentCategory { get; set; } 
        public IRPSComboBox<TagSubscriptionEntityView> UIService { get; set; } 
        public IRPSComboBox<TagSubscriptionEntityView> EntityType { get; set; } 
        public IRPSComboBox<TagSubscriptionEntityView> CodCompany { get; set; } 
        public IRPSComboBox<TagSubscriptionEntityView> UIDocumentCategory { get; set; } 
        public TagSubscription Screen { get; set; }
        public TagSubscriptionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
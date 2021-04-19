    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.OpinionsSubscription
{
    //RPS VERSION 1.0.0.0
    public partial class OpinionsSubscription:Screen
    {
        public OpinionsSubscription():base()
        {
            this.URL = "documents.opinionssubscription";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TagSubscriptionVMQueryView  = new TagSubscriptionVMQueryView(this); 
            TagSubscriptionVMEntityView  = new TagSubscriptionVMEntityView(this); 
            TagSubscriptionVMQueryView.InitializeControls(); 
            TagSubscriptionVMEntityView.InitializeControls(); 
           
        }
      
            public TagSubscriptionVMQueryView TagSubscriptionVMQueryView {get; set; } 
            public TagSubscriptionVMEntityView TagSubscriptionVMEntityView {get; set; } 
    }
            
    public partial class TagSubscriptionVMQueryView : View
    {
        public TagSubscriptionVMQueryView(OpinionsSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView>( this,Screen.TagSubscriptionVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<TagSubscriptionVMQueryView>( this);
 
            CollectionInit params_OpinionsSubscriptionViewSource = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="86990af0-7ae6-4fe3-a29d-f03ab0b75353",CSSSelectorGrid="",XPathGrid=""};
            OpinionsSubscriptionViewSource = RPSControlFactory.RPSCreateCollectionWithGrid<OpinionsSubscriptionViewSourceCollectionEditor<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView>,TagSubscriptionVMQueryView,TagSubscriptionVMEntityView>( params_OpinionsSubscriptionViewSource,this,Screen.TagSubscriptionVMEntityView);
 

        }
        public IRPSButton<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> NewButton { get; set; } 
        public IRPSButton<TagSubscriptionVMQueryView> ConsultButton { get; set; } 
        public OpinionsSubscriptionViewSourceCollectionEditor<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> OpinionsSubscriptionViewSource { get; set; } 
        public OpinionsSubscription Screen { get; set; }
        public TagSubscriptionVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OpinionsSubscriptionViewSourceCollectionEditor<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView>:RPSCollectionEditor<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> where TagSubscriptionVMQueryView : class, IView where TagSubscriptionVMEntityView : class, IView
    {
        public  OpinionsSubscriptionViewSourceGridView<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> GridView {get;set;}
    }
    public partial class OpinionsSubscriptionViewSourceGridView <TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> :  RPSGridView<TagSubscriptionVMQueryView,TagSubscriptionVMEntityView> where TagSubscriptionVMQueryView : class, IView where TagSubscriptionVMEntityView : class, IView
    {
        public OpinionsSubscriptionViewSourceGridView(TagSubscriptionVMQueryView currentView,TagSubscriptionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class TagSubscriptionVMEntityView : View
    {
        public TagSubscriptionVMEntityView(OpinionsSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TagSubscriptionVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TagSubscriptionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TagSubscriptionVMEntityView,TagSubscriptionVMQueryView>( this,Screen.TagSubscriptionVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<TagSubscriptionVMEntityView,TagSubscriptionVMQueryView>( this,Screen.TagSubscriptionVMQueryView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<TagSubscriptionVMEntityView>("703c6b60-9119-4f80-88af-c4d828eb1911","","",true, this);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<TagSubscriptionVMEntityView>("60f3e97a-241f-454e-be48-f6d920f6ccfb","","",false, this);
 
            EntityPKValue = RPSControlFactory.CreateRPSComboBox<TagSubscriptionVMEntityView>("88684d54-f940-46bb-a3f7-e19bbb5891e1","","",false, this);
 

        }
        public IRPSSaveButton<TagSubscriptionVMEntityView> SaveButton { get; set; } 
        public IRPSButton<TagSubscriptionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<TagSubscriptionVMEntityView,TagSubscriptionVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TagSubscriptionVMEntityView,TagSubscriptionVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<TagSubscriptionVMEntityView> CodUser { get; set; } 
        public IRPSComboBox<TagSubscriptionVMEntityView> CodCompany { get; set; } 
        public IRPSComboBox<TagSubscriptionVMEntityView> EntityPKValue { get; set; } 
        public OpinionsSubscription Screen { get; set; }
        public TagSubscriptionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
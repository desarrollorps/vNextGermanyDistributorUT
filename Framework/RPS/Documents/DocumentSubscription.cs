    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentSubscription
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentSubscription:Screen
    {
        public DocumentSubscription():base()
        {
            this.URL = "documents.documentsubscription";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentSubscriptionCollectionView  = new DocumentSubscriptionCollectionView(this); 
            DocumentSubscriptionEntityView  = new DocumentSubscriptionEntityView(this); 
            DocumentSubscriptionCollectionView.InitializeControls(); 
            DocumentSubscriptionEntityView.InitializeControls(); 
           
        }
      
            public DocumentSubscriptionCollectionView DocumentSubscriptionCollectionView {get; set; } 
            public DocumentSubscriptionEntityView DocumentSubscriptionEntityView {get; set; } 
    }
            
    public partial class DocumentSubscriptionCollectionView : View
    {
        public DocumentSubscriptionCollectionView(DocumentSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentSubscriptionCollectionView,DocumentSubscriptionEntityView>( this,Screen.DocumentSubscriptionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0c85bfeb-5b6b-419b-baa5-5f627a7242fb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentSubscriptionCollectionView,DocumentSubscriptionEntityView>( params_MainConsult,this,Screen.DocumentSubscriptionEntityView);
 

        }
        public IRPSButton<DocumentSubscriptionCollectionView,DocumentSubscriptionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentSubscriptionCollectionView,DocumentSubscriptionEntityView> MainConsult { get; set; } 
        public DocumentSubscription Screen { get; set; }
        public DocumentSubscriptionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentSubscriptionEntityView : View
    {
        public DocumentSubscriptionEntityView(DocumentSubscription screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentSubscriptionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentSubscriptionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentSubscriptionEntityView,DocumentSubscriptionCollectionView>( this,Screen.DocumentSubscriptionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentSubscriptionEntityView,DocumentSubscriptionCollectionView>( this,Screen.DocumentSubscriptionCollectionView);
 
            SubscriptorType = RPSControlFactory.CreateRPSEnumComboBox<DocumentSubscriptionEntityView>("363dd15a-b4f0-4df1-b554-103012c61573","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<DocumentSubscriptionEntityView>("d6a8df02-f75a-4e2a-aecd-8c819dbd78c3","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<DocumentSubscriptionEntityView>("c01a6632-f1f6-4345-9e91-9e39f7c850bc","","",false, this);
 
            SubscriptionType = RPSControlFactory.CreateRPSEnumComboBox<DocumentSubscriptionEntityView>("693d9361-dc82-4b15-9520-1d5713a4a4c4","","",true, this);
 
            IDDocument = RPSControlFactory.CreateRPSComboBox<DocumentSubscriptionEntityView>("ddf01789-dead-4455-9e3d-472996931043","","",false, this);
 
            IDDocumentCategory = RPSControlFactory.CreateRPSComboBox<DocumentSubscriptionEntityView>("ec14c4d9-d13c-475e-8e23-97fb92afef44","","",false, this);
 

        }
        public IRPSSaveButton<DocumentSubscriptionEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentSubscriptionEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentSubscriptionEntityView,DocumentSubscriptionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentSubscriptionEntityView,DocumentSubscriptionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> SubscriptorType { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> CodUser { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> CodRole { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> SubscriptionType { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> IDDocument { get; set; } 
        public IRPSComboBox<DocumentSubscriptionEntityView> IDDocumentCategory { get; set; } 
        public DocumentSubscription Screen { get; set; }
        public DocumentSubscriptionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
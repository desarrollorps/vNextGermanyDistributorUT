    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ContactType
{
    //RPS VERSION 1.0.0.0
    public partial class ContactType:Screen
    {
        public ContactType():base()
        {
            this.URL = "purchase.contacttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ContactTypeCollectionView  = new ContactTypeCollectionView(this); 
            ContactTypeEntityView  = new ContactTypeEntityView(this); 
            ContactTypeByLangView  = new ContactTypeByLangView(this); 
            ContactTypeCollectionView.InitializeControls(); 
            ContactTypeEntityView.InitializeControls(); 
            ContactTypeByLangView.InitializeControls(); 
           
        }
      
            public ContactTypeCollectionView ContactTypeCollectionView {get; set; } 
            public ContactTypeEntityView ContactTypeEntityView {get; set; } 
            public ContactTypeByLangView ContactTypeByLangView {get; set; } 
    }
            
    public partial class ContactTypeCollectionView : View
    {
        public ContactTypeCollectionView(ContactType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ContactTypeCollectionView,ContactTypeEntityView>( this,Screen.ContactTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ca26f73e-0538-4e39-a5b4-de0bfbb4c176",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ContactTypeCollectionView,ContactTypeEntityView>( params_MainConsult,this,Screen.ContactTypeEntityView);
 

        }
        public IRPSButton<ContactTypeCollectionView,ContactTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ContactTypeCollectionView,ContactTypeEntityView> MainConsult { get; set; } 
        public ContactType Screen { get; set; }
        public ContactTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ContactTypeEntityView : View
    {
        public ContactTypeEntityView(ContactType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ContactTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ContactTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ContactTypeEntityView,ContactTypeCollectionView>( this,Screen.ContactTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ContactTypeEntityView,ContactTypeCollectionView>( this,Screen.ContactTypeCollectionView);
 
            CodContactType = RPSControlFactory.CreateRPSTextBox<ContactTypeEntityView>("be6bd183-55fb-445c-b7d8-e0a7af9971b2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ContactTypeEntityView>("3b664824-f92f-4823-9595-7f48f6f27dd0","","",false, this);
 
            CollectionInit params_ContactTypeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="450157e2-0eb4-440d-b6b7-e95875c01d00",CSSSelectorGrid="",XPathGrid=""};
            ContactTypeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ContactTypeByLangsCollectionEditor<ContactTypeEntityView,ContactTypeByLangView>,ContactTypeEntityView,ContactTypeByLangView>( params_ContactTypeByLangs,this,Screen.ContactTypeByLangView);
 

        }
        public IRPSSaveButton<ContactTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ContactTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ContactTypeEntityView,ContactTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ContactTypeEntityView,ContactTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ContactTypeEntityView> CodContactType { get; set; } 
        public IRPSTextBox<ContactTypeEntityView> Description { get; set; } 
        public ContactTypeByLangsCollectionEditor<ContactTypeEntityView,ContactTypeByLangView> ContactTypeByLangs { get; set; } 
        public ContactType Screen { get; set; }
        public ContactTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ContactTypeByLangsCollectionEditor<ContactTypeEntityView,ContactTypeByLangView>:RPSCollectionEditor<ContactTypeEntityView,ContactTypeByLangView> where ContactTypeEntityView : class, IView where ContactTypeByLangView : class, IView
    {
        public  ContactTypeByLangsGridView<ContactTypeEntityView,ContactTypeByLangView> GridView {get;set;}
    }
    public partial class ContactTypeByLangsGridView <ContactTypeEntityView,ContactTypeByLangView> :  RPSGridView<ContactTypeEntityView,ContactTypeByLangView> where ContactTypeEntityView : class, IView where ContactTypeByLangView : class, IView
    {
        public ContactTypeByLangsGridView(ContactTypeEntityView currentView,ContactTypeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ContactTypeEntityView>("","#450157e2-0eb4-440d-b6b7-e95875c01d00 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ContactTypeEntityView>("","#450157e2-0eb4-440d-b6b7-e95875c01d00 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ContactTypeEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ContactTypeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ContactTypeByLangView : View
    {
        public ContactTypeByLangView(ContactType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ContactTypeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ContactTypeByLangView,ContactTypeEntityView>( this,Screen.ContactTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ContactTypeByLangView,ContactTypeEntityView>( this,Screen.ContactTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ContactTypeByLangView,ContactTypeEntityView>( this,Screen.ContactTypeEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ContactTypeByLangView>("b1c300be-859e-42c0-903f-85ffaa9f307a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ContactTypeByLangView>("8c20eec1-203e-4f37-9953-58405fad15f8","","",false, this);
 

        }
        public IRPSButton<ContactTypeByLangView> DeleteButton { get; set; } 
        public IRPSButton<ContactTypeByLangView,ContactTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ContactTypeByLangView,ContactTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ContactTypeByLangView,ContactTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ContactTypeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ContactTypeByLangView> Description { get; set; } 
        public ContactType Screen { get; set; }
        public ContactTypeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
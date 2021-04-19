    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ContactTypeSL
{
    //RPS VERSION 1.0.0.0
    public partial class ContactTypeSL:Screen
    {
        public ContactTypeSL():base()
        {
            this.URL = "sales.contacttypesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ContactTypeSLCollectionView  = new ContactTypeSLCollectionView(this); 
            ContactTypeSLEntityView  = new ContactTypeSLEntityView(this); 
            ContactTypeByLangSLView  = new ContactTypeByLangSLView(this); 
            ContactTypeSLCollectionView.InitializeControls(); 
            ContactTypeSLEntityView.InitializeControls(); 
            ContactTypeByLangSLView.InitializeControls(); 
           
        }
      
            public ContactTypeSLCollectionView ContactTypeSLCollectionView {get; set; } 
            public ContactTypeSLEntityView ContactTypeSLEntityView {get; set; } 
            public ContactTypeByLangSLView ContactTypeByLangSLView {get; set; } 
    }
            
    public partial class ContactTypeSLCollectionView : View
    {
        public ContactTypeSLCollectionView(ContactTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ContactTypeSLCollectionView,ContactTypeSLEntityView>( this,Screen.ContactTypeSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fe5a3c1a-5f6e-467f-a889-bc3b6f984396",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ContactTypeSLCollectionView,ContactTypeSLEntityView>( params_MainConsult,this,Screen.ContactTypeSLEntityView);
 

        }
        public IRPSButton<ContactTypeSLCollectionView,ContactTypeSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ContactTypeSLCollectionView,ContactTypeSLEntityView> MainConsult { get; set; } 
        public ContactTypeSL Screen { get; set; }
        public ContactTypeSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ContactTypeSLEntityView : View
    {
        public ContactTypeSLEntityView(ContactTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ContactTypeSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ContactTypeSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ContactTypeSLEntityView,ContactTypeSLCollectionView>( this,Screen.ContactTypeSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ContactTypeSLEntityView,ContactTypeSLCollectionView>( this,Screen.ContactTypeSLCollectionView);
 
            CodContactType = RPSControlFactory.CreateRPSTextBox<ContactTypeSLEntityView>("397af703-73e7-4224-a008-676e2f063807","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ContactTypeSLEntityView>("f268de85-a29b-478d-8341-dbceeef0ffc6","","",false, this);
 
            CollectionInit params_ContactTypeByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="47bf5751-a782-4d0f-946d-438f02a60551",CSSSelectorGrid="",XPathGrid=""};
            ContactTypeByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<ContactTypeByLangSLsCollectionEditor<ContactTypeSLEntityView,ContactTypeByLangSLView>,ContactTypeSLEntityView,ContactTypeByLangSLView>( params_ContactTypeByLangSLs,this,Screen.ContactTypeByLangSLView);
 

        }
        public IRPSSaveButton<ContactTypeSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ContactTypeSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ContactTypeSLEntityView,ContactTypeSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ContactTypeSLEntityView,ContactTypeSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ContactTypeSLEntityView> CodContactType { get; set; } 
        public IRPSTextBox<ContactTypeSLEntityView> Description { get; set; } 
        public ContactTypeByLangSLsCollectionEditor<ContactTypeSLEntityView,ContactTypeByLangSLView> ContactTypeByLangSLs { get; set; } 
        public ContactTypeSL Screen { get; set; }
        public ContactTypeSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ContactTypeByLangSLsCollectionEditor<ContactTypeSLEntityView,ContactTypeByLangSLView>:RPSCollectionEditor<ContactTypeSLEntityView,ContactTypeByLangSLView> where ContactTypeSLEntityView : class, IView where ContactTypeByLangSLView : class, IView
    {
        public  ContactTypeByLangSLsGridView<ContactTypeSLEntityView,ContactTypeByLangSLView> GridView {get;set;}
    }
    public partial class ContactTypeByLangSLsGridView <ContactTypeSLEntityView,ContactTypeByLangSLView> :  RPSGridView<ContactTypeSLEntityView,ContactTypeByLangSLView> where ContactTypeSLEntityView : class, IView where ContactTypeByLangSLView : class, IView
    {
        public ContactTypeByLangSLsGridView(ContactTypeSLEntityView currentView,ContactTypeByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ContactTypeSLEntityView>("","#47bf5751-a782-4d0f-946d-438f02a60551 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ContactTypeSLEntityView>("","#47bf5751-a782-4d0f-946d-438f02a60551 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ContactTypeSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ContactTypeSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ContactTypeByLangSLView : View
    {
        public ContactTypeByLangSLView(ContactTypeSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ContactTypeByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ContactTypeByLangSLView,ContactTypeSLEntityView>( this,Screen.ContactTypeSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ContactTypeByLangSLView,ContactTypeSLEntityView>( this,Screen.ContactTypeSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ContactTypeByLangSLView,ContactTypeSLEntityView>( this,Screen.ContactTypeSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ContactTypeByLangSLView>("9ca613fc-fc0d-4895-9c9a-608ccdaeb503","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ContactTypeByLangSLView>("b0788563-cce7-4d27-a686-bf58a5f88d9b","","",false, this);
 

        }
        public IRPSButton<ContactTypeByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<ContactTypeByLangSLView,ContactTypeSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ContactTypeByLangSLView,ContactTypeSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ContactTypeByLangSLView,ContactTypeSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ContactTypeByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<ContactTypeByLangSLView> Description { get; set; } 
        public ContactTypeSL Screen { get; set; }
        public ContactTypeByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
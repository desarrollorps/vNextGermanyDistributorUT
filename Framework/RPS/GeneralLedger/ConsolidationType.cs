    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ConsolidationType
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidationType:Screen
    {
        public ConsolidationType():base()
        {
            this.URL = "generalledger.consolidationtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidationTypeCollectionView  = new ConsolidationTypeCollectionView(this); 
            ConsolidationTypeEntityView  = new ConsolidationTypeEntityView(this); 
            AccConsolidationView  = new AccConsolidationView(this); 
            AccByCompanyView  = new AccByCompanyView(this); 
            ConsolidationTypeCollectionView.InitializeControls(); 
            ConsolidationTypeEntityView.InitializeControls(); 
            AccConsolidationView.InitializeControls(); 
            AccByCompanyView.InitializeControls(); 
           
        }
      
            public ConsolidationTypeCollectionView ConsolidationTypeCollectionView {get; set; } 
            public ConsolidationTypeEntityView ConsolidationTypeEntityView {get; set; } 
            public AccConsolidationView AccConsolidationView {get; set; } 
            public AccByCompanyView AccByCompanyView {get; set; } 
    }
            
    public partial class ConsolidationTypeCollectionView : View
    {
        public ConsolidationTypeCollectionView(ConsolidationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ConsolidationTypeCollectionView,ConsolidationTypeEntityView>( this,Screen.ConsolidationTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b1208b91-395d-4362-8b0e-9f2e0283a0fb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ConsolidationTypeCollectionView,ConsolidationTypeEntityView>( params_MainConsult,this,Screen.ConsolidationTypeEntityView);
 

        }
        public IRPSButton<ConsolidationTypeCollectionView,ConsolidationTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ConsolidationTypeCollectionView,ConsolidationTypeEntityView> MainConsult { get; set; } 
        public ConsolidationType Screen { get; set; }
        public ConsolidationTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ConsolidationTypeEntityView : View
    {
        public ConsolidationTypeEntityView(ConsolidationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ConsolidationTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ConsolidationTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ConsolidationTypeEntityView,ConsolidationTypeCollectionView>( this,Screen.ConsolidationTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ConsolidationTypeEntityView,ConsolidationTypeCollectionView>( this,Screen.ConsolidationTypeCollectionView);
 
            CodConsolidationType = RPSControlFactory.CreateRPSTextBox<ConsolidationTypeEntityView>("2aec1eba-79ba-4999-9590-3899c1bea588","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ConsolidationTypeEntityView>("98144546-caf1-47cb-9552-9a0ee1cdd193","","",false, this);
 
            CollectionInit params_AccConsolidations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="01382067-2986-473f-b497-255b06d438e3",CSSSelectorGrid="",XPathGrid=""};
            AccConsolidations = RPSControlFactory.RPSCreateCollectionWithGrid<AccConsolidationsCollectionEditor<ConsolidationTypeEntityView,AccConsolidationView>,ConsolidationTypeEntityView,AccConsolidationView>( params_AccConsolidations,this,Screen.AccConsolidationView);
 

        }
        public IRPSSaveButton<ConsolidationTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ConsolidationTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ConsolidationTypeEntityView,ConsolidationTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ConsolidationTypeEntityView,ConsolidationTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ConsolidationTypeEntityView> CodConsolidationType { get; set; } 
        public IRPSTextBox<ConsolidationTypeEntityView> Description { get; set; } 
        public AccConsolidationsCollectionEditor<ConsolidationTypeEntityView,AccConsolidationView> AccConsolidations { get; set; } 
        public ConsolidationType Screen { get; set; }
        public ConsolidationTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccConsolidationsCollectionEditor<ConsolidationTypeEntityView,AccConsolidationView>:RPSCollectionEditor<ConsolidationTypeEntityView,AccConsolidationView> where ConsolidationTypeEntityView : class, IView where AccConsolidationView : class, IView
    {
        public  AccConsolidationsGridView<ConsolidationTypeEntityView,AccConsolidationView> GridView {get;set;}
    }
    public partial class AccConsolidationsGridView <ConsolidationTypeEntityView,AccConsolidationView> :  RPSGridView<ConsolidationTypeEntityView,AccConsolidationView> where ConsolidationTypeEntityView : class, IView where AccConsolidationView : class, IView
    {
        public AccConsolidationsGridView(ConsolidationTypeEntityView currentView,AccConsolidationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAccConsolidation = RPSControlFactory.CreateRPSGridTextBox<ConsolidationTypeEntityView>("","#01382067-2986-473f-b497-255b06d438e3 .ag-row[role='row']@ROWINDEX [col-id='cCodAccConsolidation']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ConsolidationTypeEntityView>("","#01382067-2986-473f-b497-255b06d438e3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ConsolidationTypeEntityView> CodAccConsolidation { get; set; } 
        public IRPSGridTextBox<ConsolidationTypeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccConsolidationView : View
    {
        public AccConsolidationView(ConsolidationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccConsolidationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccConsolidationView,ConsolidationTypeEntityView>( this,Screen.ConsolidationTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccConsolidationView,ConsolidationTypeEntityView>( this,Screen.ConsolidationTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccConsolidationView,ConsolidationTypeEntityView>( this,Screen.ConsolidationTypeEntityView);
 
            CodAccConsolidation = RPSControlFactory.CreateRPSTextBox<AccConsolidationView>("97ef1b4e-bb0a-4bfe-af88-33a4a31dc619","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccConsolidationView>("fbde1332-40f2-46fd-aa36-621ac40823d3","","",false, this);
 
            CollectionInit params_AccByCompanys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="41b22818-ea76-40d0-a8b9-4a20bd2fb8dd",CSSSelectorGrid="",XPathGrid=""};
            AccByCompanys = RPSControlFactory.RPSCreateCollectionWithGrid<AccByCompanysCollectionEditor<AccConsolidationView,AccByCompanyView>,AccConsolidationView,AccByCompanyView>( params_AccByCompanys,this,Screen.AccByCompanyView);
 

        }
        public IRPSButton<AccConsolidationView> DeleteButton { get; set; } 
        public IRPSButton<AccConsolidationView,ConsolidationTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccConsolidationView,ConsolidationTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AccConsolidationView,ConsolidationTypeEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<AccConsolidationView> CodAccConsolidation { get; set; } 
        public IRPSTextBox<AccConsolidationView> Description { get; set; } 
        public AccByCompanysCollectionEditor<AccConsolidationView,AccByCompanyView> AccByCompanys { get; set; } 
        public ConsolidationType Screen { get; set; }
        public AccConsolidationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccByCompanysCollectionEditor<AccConsolidationView,AccByCompanyView>:RPSCollectionEditor<AccConsolidationView,AccByCompanyView> where AccConsolidationView : class, IView where AccByCompanyView : class, IView
    {
        public  AccByCompanysGridView<AccConsolidationView,AccByCompanyView> GridView {get;set;}
    }
    public partial class AccByCompanysGridView <AccConsolidationView,AccByCompanyView> :  RPSGridView<AccConsolidationView,AccByCompanyView> where AccConsolidationView : class, IView where AccByCompanyView : class, IView
    {
        public AccByCompanysGridView(AccConsolidationView currentView,AccByCompanyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<AccConsolidationView>("","#41b22818-ea76-40d0-a8b9-4a20bd2fb8dd .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            CodACCType = RPSControlFactory.CreateRPSGridEnumComboBox<AccConsolidationView>("","#41b22818-ea76-40d0-a8b9-4a20bd2fb8dd .ag-row[role='row']@ROWINDEX [col-id='cCodACCType']","",true, this.CurrentView);
 
            CodPrefixAcc = RPSControlFactory.CreateRPSGridTextBox<AccConsolidationView>("","#41b22818-ea76-40d0-a8b9-4a20bd2fb8dd .ag-row[role='row']@ROWINDEX [col-id='cCodPrefixAcc']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccConsolidationView> CodCompany { get; set; } 
        public IRPSGridComboBox<AccConsolidationView> CodACCType { get; set; } 
        public IRPSGridTextBox<AccConsolidationView> CodPrefixAcc { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccByCompanyView : View
    {
        public AccByCompanyView(ConsolidationType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccByCompanyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccByCompanyView,AccConsolidationView>( this,Screen.AccConsolidationView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccByCompanyView,AccConsolidationView>( this,Screen.AccConsolidationView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccByCompanyView,AccConsolidationView>( this,Screen.AccConsolidationView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<AccByCompanyView>("a94123d8-1f39-4c1e-9b11-72f371a70dd7","","",true, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<AccByCompanyView>("f0561a0e-afc6-45fd-be90-33530f5d0201","","",true, this);
 
            CodPrefixAcc = RPSControlFactory.CreateRPSTextBox<AccByCompanyView>("77d3df0a-c355-4a3a-ad99-db7f16fea01c","","",true, this);
 

        }
        public IRPSButton<AccByCompanyView> DeleteButton { get; set; } 
        public IRPSButton<AccByCompanyView,AccConsolidationView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccByCompanyView,AccConsolidationView> BackButton { get; set; } 
        public IRPSAcceptButton<AccByCompanyView,AccConsolidationView> AcceptButton { get; set; } 
        public IRPSComboBox<AccByCompanyView> CodCompany { get; set; } 
        public IRPSComboBox<AccByCompanyView> CodACCType { get; set; } 
        public IRPSTextBox<AccByCompanyView> CodPrefixAcc { get; set; } 
        public ConsolidationType Screen { get; set; }
        public AccByCompanyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
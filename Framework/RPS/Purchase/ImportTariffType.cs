    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ImportTariffType
{
    //RPS VERSION 1.0.0.0
    public partial class ImportTariffType:Screen
    {
        public ImportTariffType():base()
        {
            this.URL = "purchase.importtarifftype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImportTariffTypeCollectionView  = new ImportTariffTypeCollectionView(this); 
            ImportTariffTypeEntityView  = new ImportTariffTypeEntityView(this); 
            ImportTariffTypeDetailView  = new ImportTariffTypeDetailView(this); 
            ImportTariffTypeCollectionView.InitializeControls(); 
            ImportTariffTypeEntityView.InitializeControls(); 
            ImportTariffTypeDetailView.InitializeControls(); 
           
        }
      
            public ImportTariffTypeCollectionView ImportTariffTypeCollectionView {get; set; } 
            public ImportTariffTypeEntityView ImportTariffTypeEntityView {get; set; } 
            public ImportTariffTypeDetailView ImportTariffTypeDetailView {get; set; } 
    }
            
    public partial class ImportTariffTypeCollectionView : View
    {
        public ImportTariffTypeCollectionView(ImportTariffType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImportTariffTypeCollectionView,ImportTariffTypeEntityView>( this,Screen.ImportTariffTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "69c212bf-0793-4d8e-9887-43e1838fb34f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ImportTariffTypeCollectionView,ImportTariffTypeEntityView>( params_MainConsult,this,Screen.ImportTariffTypeEntityView);
 

        }
        public IRPSButton<ImportTariffTypeCollectionView,ImportTariffTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ImportTariffTypeCollectionView,ImportTariffTypeEntityView> MainConsult { get; set; } 
        public ImportTariffType Screen { get; set; }
        public ImportTariffTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportTariffTypeEntityView : View
    {
        public ImportTariffTypeEntityView(ImportTariffType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImportTariffTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImportTariffTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImportTariffTypeEntityView,ImportTariffTypeCollectionView>( this,Screen.ImportTariffTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImportTariffTypeEntityView,ImportTariffTypeCollectionView>( this,Screen.ImportTariffTypeCollectionView);
 
            CodImportTariffType = RPSControlFactory.CreateRPSTextBox<ImportTariffTypeEntityView>("14fd7053-002b-49e7-b3e6-1e3c8ebae357","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImportTariffTypeEntityView>("f32e48e8-bb2f-48a1-a0fc-e7f2686f08cd","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ImportTariffTypeEntityView>("7ab9dd1f-ced9-4aeb-ad1b-02c2dde4220d","","",false, this);
 
            CollectionInit params_ImportTariffTypeDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be9ee1d8-a7d4-41c2-aee6-875726ccf4ca",CSSSelectorGrid="",XPathGrid=""};
            ImportTariffTypeDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ImportTariffTypeDetailsCollectionEditor<ImportTariffTypeEntityView,ImportTariffTypeDetailView>,ImportTariffTypeEntityView,ImportTariffTypeDetailView>( params_ImportTariffTypeDetails,this,Screen.ImportTariffTypeDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ImportTariffTypeEntityView>( "","ul li[rpsid='df1fc8af-8a2e-4a17-b5b3-09d92d8e88cd']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ImportTariffTypeEntityView>( "","ul li[rpsid='c6d6ab23-1bab-4521-82a2-2fd6f011f7f7']","",this);
 

        }
        public IRPSSaveButton<ImportTariffTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ImportTariffTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImportTariffTypeEntityView,ImportTariffTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImportTariffTypeEntityView,ImportTariffTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ImportTariffTypeEntityView> CodImportTariffType { get; set; } 
        public IRPSTextBox<ImportTariffTypeEntityView> Description { get; set; } 
        public IRPSTextBox<ImportTariffTypeEntityView> Comment { get; set; } 
        public ImportTariffTypeDetailsCollectionEditor<ImportTariffTypeEntityView,ImportTariffTypeDetailView> ImportTariffTypeDetails { get; set; } 
        public IRPSSection<ImportTariffTypeEntityView> GeneralData { get; set; } 
        public IRPSSection<ImportTariffTypeEntityView> Comments { get; set; } 
        public ImportTariffType Screen { get; set; }
        public ImportTariffTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImportTariffTypeDetailsCollectionEditor<ImportTariffTypeEntityView,ImportTariffTypeDetailView>:RPSCollectionEditor<ImportTariffTypeEntityView,ImportTariffTypeDetailView> where ImportTariffTypeEntityView : class, IView where ImportTariffTypeDetailView : class, IView
    {
        public  ImportTariffTypeDetailsGridView<ImportTariffTypeEntityView,ImportTariffTypeDetailView> GridView {get;set;}
    }
    public partial class ImportTariffTypeDetailsGridView <ImportTariffTypeEntityView,ImportTariffTypeDetailView> :  RPSGridView<ImportTariffTypeEntityView,ImportTariffTypeDetailView> where ImportTariffTypeEntityView : class, IView where ImportTariffTypeDetailView : class, IView
    {
        public ImportTariffTypeDetailsGridView(ImportTariffTypeEntityView currentView,ImportTariffTypeDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCountry = RPSControlFactory.CreateRPSGridComboBox<ImportTariffTypeEntityView>("","#be9ee1d8-a7d4-41c2-aee6-875726ccf4ca .ag-row[role='row']@ROWINDEX [col-id='cCodCountry']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<ImportTariffTypeEntityView>("","#be9ee1d8-a7d4-41c2-aee6-875726ccf4ca .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Percent = RPSControlFactory.CreateRPSGridFormattedTextBox<ImportTariffTypeEntityView>("","#be9ee1d8-a7d4-41c2-aee6-875726ccf4ca .ag-row[role='row']@ROWINDEX [col-id='cPercent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ImportTariffTypeEntityView> CodCountry { get; set; } 
        public IRPSGridTextBox<ImportTariffTypeEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<ImportTariffTypeEntityView> Percent { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImportTariffTypeDetailView : View
    {
        public ImportTariffTypeDetailView(ImportTariffType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImportTariffTypeDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView>( this,Screen.ImportTariffTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView>( this,Screen.ImportTariffTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView>( this,Screen.ImportTariffTypeEntityView);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<ImportTariffTypeDetailView>("d87c7383-3583-4238-bc12-8be176bbaba9","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ImportTariffTypeDetailView>("b43de24b-85da-4a0e-ab1e-d2c0c66a0a38","","",true, this);
 
            Percent = RPSControlFactory.CreateRPSFormattedTextBox<ImportTariffTypeDetailView>("c06a107b-922b-4921-ac3e-a95c01933f42","","",true, this);
 

        }
        public IRPSButton<ImportTariffTypeDetailView> DeleteButton { get; set; } 
        public IRPSButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ImportTariffTypeDetailView,ImportTariffTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ImportTariffTypeDetailView> CodCountry { get; set; } 
        public IRPSTextBox<ImportTariffTypeDetailView> DateFrom { get; set; } 
        public IRPSTextBox<ImportTariffTypeDetailView> Percent { get; set; } 
        public ImportTariffType Screen { get; set; }
        public ImportTariffTypeDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
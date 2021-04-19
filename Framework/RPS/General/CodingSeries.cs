    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CodingSeries
{
    //RPS VERSION 1.0.0.0
    public partial class CodingSeries:Screen
    {
        public CodingSeries():base()
        {
            this.URL = "general.codingseries";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CodingSeriesCollectionView  = new CodingSeriesCollectionView(this); 
            CodingSeriesEntityView  = new CodingSeriesEntityView(this); 
            CodificationDefinitionView  = new CodificationDefinitionView(this); 
            CodingSeriesCollectionView.InitializeControls(); 
            CodingSeriesEntityView.InitializeControls(); 
            CodificationDefinitionView.InitializeControls(); 
           
        }
      
            public CodingSeriesCollectionView CodingSeriesCollectionView {get; set; } 
            public CodingSeriesEntityView CodingSeriesEntityView {get; set; } 
            public CodificationDefinitionView CodificationDefinitionView {get; set; } 
    }
            
    public partial class CodingSeriesCollectionView : View
    {
        public CodingSeriesCollectionView(CodingSeries screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CodingSeriesCollectionView,CodingSeriesEntityView>( this,Screen.CodingSeriesEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "12d8f36d-44e1-421d-9b5b-dd3078cd601c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CodingSeriesCollectionView,CodingSeriesEntityView>( params_MainConsult,this,Screen.CodingSeriesEntityView);
 

        }
        public IRPSButton<CodingSeriesCollectionView,CodingSeriesEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CodingSeriesCollectionView,CodingSeriesEntityView> MainConsult { get; set; } 
        public CodingSeries Screen { get; set; }
        public CodingSeriesCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CodingSeriesEntityView : View
    {
        public CodingSeriesEntityView(CodingSeries screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CodingSeriesEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CodingSeriesEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CodingSeriesEntityView,CodingSeriesCollectionView>( this,Screen.CodingSeriesCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CodingSeriesEntityView,CodingSeriesCollectionView>( this,Screen.CodingSeriesCollectionView);
 
            CodSerie = RPSControlFactory.CreateRPSTextBox<CodingSeriesEntityView>("aa35ee2f-1285-41d7-a573-634477115331","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CodingSeriesEntityView>("2407a9c6-42ac-4703-8fb0-572e586c23a8","","",false, this);
 
            TypeSerie = RPSControlFactory.CreateRPSEnumComboBox<CodingSeriesEntityView>("81df1889-8441-4279-9547-aa1bdf5433f6","","",true, this);
 
            NumLines = RPSControlFactory.CreateRPSFormattedTextBox<CodingSeriesEntityView>("8596f138-f7fa-4b19-9eac-f64dfc83a9e7","","",true, this);
 
            CollectionInit params_GENCodificationDefinitions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="44e912a4-e14f-4add-bd9d-c6010ff31aeb",CSSSelectorGrid="",XPathGrid=""};
            GENCodificationDefinitions = RPSControlFactory.RPSCreateCollectionWithGrid<GENCodificationDefinitionsCollectionEditor<CodingSeriesEntityView,CodificationDefinitionView>,CodingSeriesEntityView,CodificationDefinitionView>( params_GENCodificationDefinitions,this,Screen.CodificationDefinitionView);
 

        }
        public IRPSSaveButton<CodingSeriesEntityView> SaveButton { get; set; } 
        public IRPSButton<CodingSeriesEntityView> DeleteButton { get; set; } 
        public IRPSButton<CodingSeriesEntityView,CodingSeriesCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CodingSeriesEntityView,CodingSeriesCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CodingSeriesEntityView> CodSerie { get; set; } 
        public IRPSTextBox<CodingSeriesEntityView> Description { get; set; } 
        public IRPSComboBox<CodingSeriesEntityView> TypeSerie { get; set; } 
        public IRPSTextBox<CodingSeriesEntityView> NumLines { get; set; } 
        public GENCodificationDefinitionsCollectionEditor<CodingSeriesEntityView,CodificationDefinitionView> GENCodificationDefinitions { get; set; } 
        public CodingSeries Screen { get; set; }
        public CodingSeriesEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENCodificationDefinitionsCollectionEditor<CodingSeriesEntityView,CodificationDefinitionView>:RPSCollectionEditor<CodingSeriesEntityView,CodificationDefinitionView> where CodingSeriesEntityView : class, IView where CodificationDefinitionView : class, IView
    {
        public  GENCodificationDefinitionsGridView<CodingSeriesEntityView,CodificationDefinitionView> GridView {get;set;}
    }
    public partial class GENCodificationDefinitionsGridView <CodingSeriesEntityView,CodificationDefinitionView> :  RPSGridView<CodingSeriesEntityView,CodificationDefinitionView> where CodingSeriesEntityView : class, IView where CodificationDefinitionView : class, IView
    {
        public GENCodificationDefinitionsGridView(CodingSeriesEntityView currentView,CodificationDefinitionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CodingSeriesEntityView>("","#44e912a4-e14f-4add-bd9d-c6010ff31aeb .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Precode = RPSControlFactory.CreateRPSGridTextBox<CodingSeriesEntityView>("","#44e912a4-e14f-4add-bd9d-c6010ff31aeb .ag-row[role='row']@ROWINDEX [col-id='cPrecode']","",false, this.CurrentView);
 
            CorrelativeNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<CodingSeriesEntityView>("","#44e912a4-e14f-4add-bd9d-c6010ff31aeb .ag-row[role='row']@ROWINDEX [col-id='cCorrelativeNumber']","",true, this.CurrentView);
 
            DigitNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<CodingSeriesEntityView>("","#44e912a4-e14f-4add-bd9d-c6010ff31aeb .ag-row[role='row']@ROWINDEX [col-id='cDigitNumber']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CodingSeriesEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CodingSeriesEntityView> Precode { get; set; } 
        public IRPSGridTextBox<CodingSeriesEntityView> CorrelativeNumber { get; set; } 
        public IRPSGridTextBox<CodingSeriesEntityView> DigitNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class CodificationDefinitionView : View
    {
        public CodificationDefinitionView(CodingSeries screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CodificationDefinitionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CodificationDefinitionView,CodingSeriesEntityView>( this,Screen.CodingSeriesEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CodificationDefinitionView,CodingSeriesEntityView>( this,Screen.CodingSeriesEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CodificationDefinitionView,CodingSeriesEntityView>( this,Screen.CodingSeriesEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CodificationDefinitionView>("f7ec386e-af6f-4052-b7fb-704dbad6de8c","","",true, this);
 
            Precode = RPSControlFactory.CreateRPSTextBox<CodificationDefinitionView>("59561249-8913-486b-a106-7600f73a4b2d","","",false, this);
 
            CorrelativeNumber = RPSControlFactory.CreateRPSFormattedTextBox<CodificationDefinitionView>("1459e75e-03d4-4569-9652-bc5228a54f46","","",true, this);
 
            DigitNumber = RPSControlFactory.CreateRPSFormattedTextBox<CodificationDefinitionView>("f59ef6c1-ea1a-49c1-b775-3bbe423ab463","","",true, this);
 

        }
        public IRPSButton<CodificationDefinitionView> DeleteButton { get; set; } 
        public IRPSButton<CodificationDefinitionView,CodingSeriesEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CodificationDefinitionView,CodingSeriesEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CodificationDefinitionView,CodingSeriesEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CodificationDefinitionView> DateFrom { get; set; } 
        public IRPSTextBox<CodificationDefinitionView> Precode { get; set; } 
        public IRPSTextBox<CodificationDefinitionView> CorrelativeNumber { get; set; } 
        public IRPSTextBox<CodificationDefinitionView> DigitNumber { get; set; } 
        public CodingSeries Screen { get; set; }
        public CodificationDefinitionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
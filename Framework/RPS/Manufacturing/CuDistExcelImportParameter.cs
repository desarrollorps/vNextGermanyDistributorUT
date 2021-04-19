    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CuDistExcelImportParameter
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistExcelImportParameter:Screen
    {
        public CuDistExcelImportParameter():base()
        {
            this.URL = "manufacturing.cudistexcelimportparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistExcelStrImportCollectionView  = new CuDistExcelStrImportCollectionView(this); 
            CuDistExcelStrImportEntityView  = new CuDistExcelStrImportEntityView(this); 
            CuDistExcelStrImportCollectionView.InitializeControls(); 
            CuDistExcelStrImportEntityView.InitializeControls(); 
           
        }
      
            public CuDistExcelStrImportCollectionView CuDistExcelStrImportCollectionView {get; set; } 
            public CuDistExcelStrImportEntityView CuDistExcelStrImportEntityView {get; set; } 
    }
            
    public partial class CuDistExcelStrImportCollectionView : View
    {
        public CuDistExcelStrImportCollectionView(CuDistExcelImportParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistExcelStrImportCollectionView,CuDistExcelStrImportEntityView>( this,Screen.CuDistExcelStrImportEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "62e3e411-4d07-443f-909d-c9b26f27363f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CuDistExcelStrImportCollectionView,CuDistExcelStrImportEntityView>( params_MainConsult,this,Screen.CuDistExcelStrImportEntityView);
 

        }
        public IRPSButton<CuDistExcelStrImportCollectionView,CuDistExcelStrImportEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CuDistExcelStrImportCollectionView,CuDistExcelStrImportEntityView> MainConsult { get; set; } 
        public CuDistExcelImportParameter Screen { get; set; }
        public CuDistExcelStrImportCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistExcelStrImportEntityView : View
    {
        public CuDistExcelStrImportEntityView(CuDistExcelImportParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistExcelStrImportEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistExcelStrImportEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistExcelStrImportEntityView,CuDistExcelStrImportCollectionView>( this,Screen.CuDistExcelStrImportCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistExcelStrImportEntityView,CuDistExcelStrImportCollectionView>( this,Screen.CuDistExcelStrImportCollectionView);
 
            CodCuDistExcelStrImport = RPSControlFactory.CreateRPSTextBox<CuDistExcelStrImportEntityView>("b1d21f51-722d-46c9-b784-a09aa1ad6bb8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistExcelStrImportEntityView>("c8baed05-2462-4fe1-bcd1-ab6d0f4c10f2","","",true, this);
 
            InitialLine = RPSControlFactory.CreateRPSFormattedTextBox<CuDistExcelStrImportEntityView>("9cf04ecc-9abc-42cd-af06-2afa6e8da35f","","",true, this);
 
            ColArticleTemplate = RPSControlFactory.CreateRPSTextBox<CuDistExcelStrImportEntityView>("e3935296-5d9f-4cfb-88a1-8a81c8225923","","",false, this);
 
            CollectionInit params_CuDistExcelStrImportLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a795c598-b78a-41bb-8444-9ef5d9a58133",CSSSelectorGrid="",XPathGrid=""};
            CuDistExcelStrImportLines = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistExcelStrImportLinesCollectionEditor<CuDistExcelStrImportEntityView>,CuDistExcelStrImportEntityView>( params_CuDistExcelStrImportLines,this);
 

        }
        public IRPSSaveButton<CuDistExcelStrImportEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistExcelStrImportEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistExcelStrImportEntityView,CuDistExcelStrImportCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistExcelStrImportEntityView,CuDistExcelStrImportCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CuDistExcelStrImportEntityView> CodCuDistExcelStrImport { get; set; } 
        public IRPSTextBox<CuDistExcelStrImportEntityView> Description { get; set; } 
        public IRPSTextBox<CuDistExcelStrImportEntityView> InitialLine { get; set; } 
        public IRPSTextBox<CuDistExcelStrImportEntityView> ColArticleTemplate { get; set; } 
        public CuDistExcelStrImportLinesCollectionEditor<CuDistExcelStrImportEntityView> CuDistExcelStrImportLines { get; set; } 
        public CuDistExcelImportParameter Screen { get; set; }
        public CuDistExcelStrImportEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistExcelStrImportLinesCollectionEditor<CuDistExcelStrImportEntityView>:RPSCollectionEditor<CuDistExcelStrImportEntityView> where CuDistExcelStrImportEntityView : class, IView
    {
        public  CuDistExcelStrImportLinesGridView<CuDistExcelStrImportEntityView> GridView {get;set;}
    }
    public partial class CuDistExcelStrImportLinesGridView <CuDistExcelStrImportEntityView> :  RPSGridView<CuDistExcelStrImportEntityView> where CuDistExcelStrImportEntityView : class, IView
    {
        public CuDistExcelStrImportLinesGridView(CuDistExcelStrImportEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntityType = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistExcelStrImportEntityView>("","#a795c598-b78a-41bb-8444-9ef5d9a58133 .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",true, this.CurrentView);
 
            EntityProperty = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistExcelStrImportEntityView>("","#a795c598-b78a-41bb-8444-9ef5d9a58133 .ag-row[role='row']@ROWINDEX [col-id='cEntityProperty']","",true, this.CurrentView);
 
            Column = RPSControlFactory.CreateRPSGridTextBox<CuDistExcelStrImportEntityView>("","#a795c598-b78a-41bb-8444-9ef5d9a58133 .ag-row[role='row']@ROWINDEX [col-id='cColumn']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CuDistExcelStrImportEntityView> EntityType { get; set; } 
        public IRPSGridComboBox<CuDistExcelStrImportEntityView> EntityProperty { get; set; } 
        public IRPSGridTextBox<CuDistExcelStrImportEntityView> Column { get; set; } 
                     
    }
 
    }
  
    

}
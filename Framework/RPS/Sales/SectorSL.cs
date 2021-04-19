    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.SectorSL
{
    //RPS VERSION 1.0.0.0
    public partial class SectorSL:Screen
    {
        public SectorSL():base()
        {
            this.URL = "sales.sectorsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SectorSLCollectionView  = new SectorSLCollectionView(this); 
            SectorSLEntityView  = new SectorSLEntityView(this); 
            SectorByLangSLView  = new SectorByLangSLView(this); 
            SectorSLCollectionView.InitializeControls(); 
            SectorSLEntityView.InitializeControls(); 
            SectorByLangSLView.InitializeControls(); 
           
        }
      
            public SectorSLCollectionView SectorSLCollectionView {get; set; } 
            public SectorSLEntityView SectorSLEntityView {get; set; } 
            public SectorByLangSLView SectorByLangSLView {get; set; } 
    }
            
    public partial class SectorSLCollectionView : View
    {
        public SectorSLCollectionView(SectorSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SectorSLCollectionView,SectorSLEntityView>( this,Screen.SectorSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "dac68acd-f41d-4104-86d5-be4c515c0c74",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SectorSLCollectionView,SectorSLEntityView>( params_MainConsult,this,Screen.SectorSLEntityView);
 

        }
        public IRPSButton<SectorSLCollectionView,SectorSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SectorSLCollectionView,SectorSLEntityView> MainConsult { get; set; } 
        public SectorSL Screen { get; set; }
        public SectorSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SectorSLEntityView : View
    {
        public SectorSLEntityView(SectorSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SectorSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SectorSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SectorSLEntityView,SectorSLCollectionView>( this,Screen.SectorSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SectorSLEntityView,SectorSLCollectionView>( this,Screen.SectorSLCollectionView);
 
            CodSector = RPSControlFactory.CreateRPSTextBox<SectorSLEntityView>("8c95c00f-a990-49d1-9a96-988d7e2fa886","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SectorSLEntityView>("ad3b6cef-b7be-4b91-b8a4-7457637746c1","","",false, this);
 
            CollectionInit params_SectorByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c5bb2731-bdde-4acc-aba2-41160a14e42c",CSSSelectorGrid="",XPathGrid=""};
            SectorByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SectorByLangSLsCollectionEditor<SectorSLEntityView,SectorByLangSLView>,SectorSLEntityView,SectorByLangSLView>( params_SectorByLangSLs,this,Screen.SectorByLangSLView);
 

        }
        public IRPSSaveButton<SectorSLEntityView> SaveButton { get; set; } 
        public IRPSButton<SectorSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<SectorSLEntityView,SectorSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SectorSLEntityView,SectorSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SectorSLEntityView> CodSector { get; set; } 
        public IRPSTextBox<SectorSLEntityView> Description { get; set; } 
        public SectorByLangSLsCollectionEditor<SectorSLEntityView,SectorByLangSLView> SectorByLangSLs { get; set; } 
        public SectorSL Screen { get; set; }
        public SectorSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SectorByLangSLsCollectionEditor<SectorSLEntityView,SectorByLangSLView>:RPSCollectionEditor<SectorSLEntityView,SectorByLangSLView> where SectorSLEntityView : class, IView where SectorByLangSLView : class, IView
    {
        public  SectorByLangSLsGridView<SectorSLEntityView,SectorByLangSLView> GridView {get;set;}
    }
    public partial class SectorByLangSLsGridView <SectorSLEntityView,SectorByLangSLView> :  RPSGridView<SectorSLEntityView,SectorByLangSLView> where SectorSLEntityView : class, IView where SectorByLangSLView : class, IView
    {
        public SectorByLangSLsGridView(SectorSLEntityView currentView,SectorByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SectorSLEntityView>("","#c5bb2731-bdde-4acc-aba2-41160a14e42c .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SectorSLEntityView>("","#c5bb2731-bdde-4acc-aba2-41160a14e42c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SectorSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SectorSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class SectorByLangSLView : View
    {
        public SectorByLangSLView(SectorSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SectorByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SectorByLangSLView,SectorSLEntityView>( this,Screen.SectorSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SectorByLangSLView,SectorSLEntityView>( this,Screen.SectorSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SectorByLangSLView,SectorSLEntityView>( this,Screen.SectorSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SectorByLangSLView>("6d60ac1e-fce1-4954-ae38-2d458f54f7e2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SectorByLangSLView>("fcf43321-e113-452a-8c29-8b9da865e6b6","","",false, this);
 

        }
        public IRPSButton<SectorByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<SectorByLangSLView,SectorSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SectorByLangSLView,SectorSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SectorByLangSLView,SectorSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SectorByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<SectorByLangSLView> Description { get; set; } 
        public SectorSL Screen { get; set; }
        public SectorByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
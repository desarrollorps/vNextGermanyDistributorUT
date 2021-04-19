    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PriceListSL
{
    //RPS VERSION 1.0.0.0
    public partial class PriceListSL:Screen
    {
        public PriceListSL():base()
        {
            this.URL = "sales.pricelistsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PriceListSLCollectionView  = new PriceListSLCollectionView(this); 
            PriceListSLEntityView  = new PriceListSLEntityView(this); 
            PriceListSerieSLView  = new PriceListSerieSLView(this); 
            PriceListSLCollectionView.InitializeControls(); 
            PriceListSLEntityView.InitializeControls(); 
            PriceListSerieSLView.InitializeControls(); 
           
        }
      
            public PriceListSLCollectionView PriceListSLCollectionView {get; set; } 
            public PriceListSLEntityView PriceListSLEntityView {get; set; } 
            public PriceListSerieSLView PriceListSerieSLView {get; set; } 
    }
            
    public partial class PriceListSLCollectionView : View
    {
        public PriceListSLCollectionView(PriceListSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PriceListSLCollectionView,PriceListSLEntityView>( this,Screen.PriceListSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9ae689aa-324a-48e1-921d-962dfdece29c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PriceListSLCollectionView,PriceListSLEntityView>( params_MainConsult,this,Screen.PriceListSLEntityView);
 

        }
        public IRPSButton<PriceListSLCollectionView,PriceListSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<PriceListSLCollectionView,PriceListSLEntityView> MainConsult { get; set; } 
        public PriceListSL Screen { get; set; }
        public PriceListSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PriceListSLEntityView : View
    {
        public PriceListSLEntityView(PriceListSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PriceListSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PriceListSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PriceListSLEntityView,PriceListSLCollectionView>( this,Screen.PriceListSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PriceListSLEntityView,PriceListSLCollectionView>( this,Screen.PriceListSLCollectionView);
 
            CodPriceList = RPSControlFactory.CreateRPSTextBox<PriceListSLEntityView>("a593538e-f739-4f69-a150-8d02de808c37","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PriceListSLEntityView>("be8c6e70-1c1d-4f26-b52c-b5e2cb136248","","",false, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<PriceListSLEntityView>("fa4681c6-845c-4a29-b9b7-2e8fcd796904","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<PriceListSLEntityView>("9e0160ab-6dd9-42ba-bc69-9df192259802","","",true, this);
 
            CollectionInit params_PriceListSerieSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8401523c-cadc-4960-b22c-f9c29f28e122",CSSSelectorGrid="",XPathGrid=""};
            PriceListSerieSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PriceListSerieSLsCollectionEditor<PriceListSLEntityView,PriceListSerieSLView>,PriceListSLEntityView,PriceListSerieSLView>( params_PriceListSerieSLs,this,Screen.PriceListSerieSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PriceListSLEntityView>( "","ul li[rpsid='ef6f182a-1575-45b7-b649-c6c5bb2ee794']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<PriceListSLEntityView>( "","ul li[rpsid='4b99feda-a5ab-4555-bed2-0511a82685cb']","",this);
 

        }
        public IRPSSaveButton<PriceListSLEntityView> SaveButton { get; set; } 
        public IRPSButton<PriceListSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<PriceListSLEntityView,PriceListSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PriceListSLEntityView,PriceListSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PriceListSLEntityView> CodPriceList { get; set; } 
        public IRPSTextBox<PriceListSLEntityView> Description { get; set; } 
        public IRPSCheckbox<PriceListSLEntityView> VAT { get; set; } 
        public IRPSComboBox<PriceListSLEntityView> IDCurrency { get; set; } 
        public PriceListSerieSLsCollectionEditor<PriceListSLEntityView,PriceListSerieSLView> PriceListSerieSLs { get; set; } 
        public IRPSSection<PriceListSLEntityView> GeneralData { get; set; } 
        public IRPSSection<PriceListSLEntityView> Section { get; set; } 
        public PriceListSL Screen { get; set; }
        public PriceListSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PriceListSerieSLsCollectionEditor<PriceListSLEntityView,PriceListSerieSLView>:RPSCollectionEditor<PriceListSLEntityView,PriceListSerieSLView> where PriceListSLEntityView : class, IView where PriceListSerieSLView : class, IView
    {
        public  PriceListSerieSLsGridView<PriceListSLEntityView,PriceListSerieSLView> GridView {get;set;}
    }
    public partial class PriceListSerieSLsGridView <PriceListSLEntityView,PriceListSerieSLView> :  RPSGridView<PriceListSLEntityView,PriceListSerieSLView> where PriceListSLEntityView : class, IView where PriceListSerieSLView : class, IView
    {
        public PriceListSerieSLsGridView(PriceListSLEntityView currentView,PriceListSerieSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDUnitPrice = RPSControlFactory.CreateRPSGridComboBox<PriceListSLEntityView>("","#8401523c-cadc-4960-b22c-f9c29f28e122 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PriceListSLEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<PriceListSLEntityView> Series { get; set; } 
        public IRPSGridTextBox<PriceListSLEntityView> QuantityFrom { get; set; } 
        public IRPSGridComboBox<PriceListSLEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<PriceListSLEntityView> Price { get; set; } 
        public IRPSGridComboBox<PriceListSLEntityView> IDUnitPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class PriceListSerieSLView : View
    {
        public PriceListSerieSLView(PriceListSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PriceListSerieSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PriceListSerieSLView,PriceListSLEntityView>( this,Screen.PriceListSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PriceListSerieSLView,PriceListSLEntityView>( this,Screen.PriceListSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PriceListSerieSLView,PriceListSLEntityView>( this,Screen.PriceListSLEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PriceListSerieSLView>("648ea606-cbc5-4dcd-a894-0a834b083000","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<PriceListSerieSLView>("abca59bd-bab9-45ce-999a-a298501aa418","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<PriceListSerieSLView>("426126e8-5963-428f-afdf-8285ab951479","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PriceListSerieSLView>("3ee06f73-fe3a-4455-abda-d05bdd529843","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<PriceListSerieSLView>("71a29392-f52c-49f6-af4b-96350600459c","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<PriceListSerieSLView>("e3ddfbf2-8253-43bf-bcb5-4233103b92cf","","",true, this);
 
            ApplyConditionsAffectDocument1 = RPSControlFactory.CreateRPSCheckBox<PriceListSerieSLView>("1424a4fc-7d1a-4543-809b-f1df12c4f2ce","","",true, this);
 
            ApplyConditionsNotAffectDocument1 = RPSControlFactory.CreateRPSCheckBox<PriceListSerieSLView>("ae9713d8-a904-4e30-88b3-dea547a2ceb4","","",true, this);
 

        }
        public IRPSButton<PriceListSerieSLView> DeleteButton { get; set; } 
        public IRPSButton<PriceListSerieSLView,PriceListSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PriceListSerieSLView,PriceListSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PriceListSerieSLView,PriceListSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<PriceListSerieSLView> IDArticle { get; set; } 
        public IRPSComboBox<PriceListSerieSLView> Series { get; set; } 
        public IRPSTextBox<PriceListSerieSLView> QuantityFrom { get; set; } 
        public IRPSComboBox<PriceListSerieSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<PriceListSerieSLView> Price { get; set; } 
        public IRPSComboBox<PriceListSerieSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<PriceListSerieSLView> ApplyConditionsAffectDocument1 { get; set; } 
        public IRPSCheckbox<PriceListSerieSLView> ApplyConditionsNotAffectDocument1 { get; set; } 
        public PriceListSL Screen { get; set; }
        public PriceListSerieSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
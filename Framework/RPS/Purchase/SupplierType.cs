    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierType
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierType:Screen
    {
        public SupplierType():base()
        {
            this.URL = "purchase.suppliertype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierTypeCollectionView  = new SupplierTypeCollectionView(this); 
            SupplierTypeEntityView  = new SupplierTypeEntityView(this); 
            SupplierTypeByLangView  = new SupplierTypeByLangView(this); 
            SupplierTypeCollectionView.InitializeControls(); 
            SupplierTypeEntityView.InitializeControls(); 
            SupplierTypeByLangView.InitializeControls(); 
           
        }
      
            public SupplierTypeCollectionView SupplierTypeCollectionView {get; set; } 
            public SupplierTypeEntityView SupplierTypeEntityView {get; set; } 
            public SupplierTypeByLangView SupplierTypeByLangView {get; set; } 
    }
            
    public partial class SupplierTypeCollectionView : View
    {
        public SupplierTypeCollectionView(SupplierType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierTypeCollectionView,SupplierTypeEntityView>( this,Screen.SupplierTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f9b1c8e0-523a-4aef-8c6a-92cffed92f48",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierTypeCollectionView,SupplierTypeEntityView>( params_MainConsult,this,Screen.SupplierTypeEntityView);
 

        }
        public IRPSButton<SupplierTypeCollectionView,SupplierTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierTypeCollectionView,SupplierTypeEntityView> MainConsult { get; set; } 
        public SupplierType Screen { get; set; }
        public SupplierTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierTypeEntityView : View
    {
        public SupplierTypeEntityView(SupplierType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierTypeEntityView,SupplierTypeCollectionView>( this,Screen.SupplierTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierTypeEntityView,SupplierTypeCollectionView>( this,Screen.SupplierTypeCollectionView);
 
            CodSupplierType = RPSControlFactory.CreateRPSTextBox<SupplierTypeEntityView>("398fae4b-80c8-47e6-968a-8c89dc6898fe","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierTypeEntityView>("cdba9015-fe6b-4cc5-9b11-bccace3438e9","","",false, this);
 
            CollectionInit params_SupplierTypeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="51e63ea7-61da-4a1d-8a6e-a5aca9ef4b95",CSSSelectorGrid="",XPathGrid=""};
            SupplierTypeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierTypeByLangsCollectionEditor<SupplierTypeEntityView,SupplierTypeByLangView>,SupplierTypeEntityView,SupplierTypeByLangView>( params_SupplierTypeByLangs,this,Screen.SupplierTypeByLangView);
 

        }
        public IRPSSaveButton<SupplierTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierTypeEntityView,SupplierTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierTypeEntityView,SupplierTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierTypeEntityView> CodSupplierType { get; set; } 
        public IRPSTextBox<SupplierTypeEntityView> Description { get; set; } 
        public SupplierTypeByLangsCollectionEditor<SupplierTypeEntityView,SupplierTypeByLangView> SupplierTypeByLangs { get; set; } 
        public SupplierType Screen { get; set; }
        public SupplierTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierTypeByLangsCollectionEditor<SupplierTypeEntityView,SupplierTypeByLangView>:RPSCollectionEditor<SupplierTypeEntityView,SupplierTypeByLangView> where SupplierTypeEntityView : class, IView where SupplierTypeByLangView : class, IView
    {
        public  SupplierTypeByLangsGridView<SupplierTypeEntityView,SupplierTypeByLangView> GridView {get;set;}
    }
    public partial class SupplierTypeByLangsGridView <SupplierTypeEntityView,SupplierTypeByLangView> :  RPSGridView<SupplierTypeEntityView,SupplierTypeByLangView> where SupplierTypeEntityView : class, IView where SupplierTypeByLangView : class, IView
    {
        public SupplierTypeByLangsGridView(SupplierTypeEntityView currentView,SupplierTypeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SupplierTypeEntityView>("","#51e63ea7-61da-4a1d-8a6e-a5aca9ef4b95 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierTypeEntityView>("","#51e63ea7-61da-4a1d-8a6e-a5aca9ef4b95 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierTypeEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SupplierTypeEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierTypeByLangView : View
    {
        public SupplierTypeByLangView(SupplierType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierTypeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierTypeByLangView,SupplierTypeEntityView>( this,Screen.SupplierTypeEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierTypeByLangView,SupplierTypeEntityView>( this,Screen.SupplierTypeEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierTypeByLangView,SupplierTypeEntityView>( this,Screen.SupplierTypeEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierTypeByLangView>("5d895623-6245-454b-8271-f926e89b87d8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierTypeByLangView>("62808d24-c233-4f53-b355-c6cb6b4b0416","","",false, this);
 

        }
        public IRPSButton<SupplierTypeByLangView> DeleteButton { get; set; } 
        public IRPSButton<SupplierTypeByLangView,SupplierTypeEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierTypeByLangView,SupplierTypeEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierTypeByLangView,SupplierTypeEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierTypeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<SupplierTypeByLangView> Description { get; set; } 
        public SupplierType Screen { get; set; }
        public SupplierTypeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNoteTypeGroup
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteTypeGroup:Screen
    {
        public DeliveryNoteTypeGroup():base()
        {
            this.URL = "sales.deliverynotetypegroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteTypeGroupSLCollectionView  = new DeliveryNoteTypeGroupSLCollectionView(this); 
            DeliveryNoteTypeGroupSLEntityView  = new DeliveryNoteTypeGroupSLEntityView(this); 
            DeliveryNoteTypeGroupByLangSLView  = new DeliveryNoteTypeGroupByLangSLView(this); 
            DeliveryNoteTypeGroupSLCollectionView.InitializeControls(); 
            DeliveryNoteTypeGroupSLEntityView.InitializeControls(); 
            DeliveryNoteTypeGroupByLangSLView.InitializeControls(); 
           
        }
      
            public DeliveryNoteTypeGroupSLCollectionView DeliveryNoteTypeGroupSLCollectionView {get; set; } 
            public DeliveryNoteTypeGroupSLEntityView DeliveryNoteTypeGroupSLEntityView {get; set; } 
            public DeliveryNoteTypeGroupByLangSLView DeliveryNoteTypeGroupByLangSLView {get; set; } 
    }
            
    public partial class DeliveryNoteTypeGroupSLCollectionView : View
    {
        public DeliveryNoteTypeGroupSLCollectionView(DeliveryNoteTypeGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteTypeGroupSLCollectionView,DeliveryNoteTypeGroupSLEntityView>( this,Screen.DeliveryNoteTypeGroupSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d6a43adc-f3c3-407d-a7b8-336c599d2077",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteTypeGroupSLCollectionView,DeliveryNoteTypeGroupSLEntityView>( params_MainConsult,this,Screen.DeliveryNoteTypeGroupSLEntityView);
 

        }
        public IRPSButton<DeliveryNoteTypeGroupSLCollectionView,DeliveryNoteTypeGroupSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteTypeGroupSLCollectionView,DeliveryNoteTypeGroupSLEntityView> MainConsult { get; set; } 
        public DeliveryNoteTypeGroup Screen { get; set; }
        public DeliveryNoteTypeGroupSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteTypeGroupSLEntityView : View
    {
        public DeliveryNoteTypeGroupSLEntityView(DeliveryNoteTypeGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryNoteTypeGroupSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteTypeGroupSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupSLCollectionView>( this,Screen.DeliveryNoteTypeGroupSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupSLCollectionView>( this,Screen.DeliveryNoteTypeGroupSLCollectionView);
 
            CodDeliveryNoteTypeGroup = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeGroupSLEntityView>("f7ce1aac-483d-4b05-b872-1e6c5565054c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeGroupSLEntityView>("f4cc4c61-d117-46a7-b52a-0cf7bf10c481","","",false, this);
 
            Grouped = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteTypeGroupSLEntityView>("0ccb2e07-8413-45eb-9d5d-f9991947cf77","","",true, this);
 
            CollectionInit params_DeliveryNoteTypeGroupByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9ffc4004-0475-449a-95b3-36fba5f2a428",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteTypeGroupByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteTypeGroupByLangSLsCollectionEditor<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView>,DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView>( params_DeliveryNoteTypeGroupByLangSLs,this,Screen.DeliveryNoteTypeGroupByLangSLView);
 

        }
        public IRPSSaveButton<DeliveryNoteTypeGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeGroupSLEntityView> CodDeliveryNoteTypeGroup { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeGroupSLEntityView> Description { get; set; } 
        public IRPSCheckbox<DeliveryNoteTypeGroupSLEntityView> Grouped { get; set; } 
        public DeliveryNoteTypeGroupByLangSLsCollectionEditor<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView> DeliveryNoteTypeGroupByLangSLs { get; set; } 
        public DeliveryNoteTypeGroup Screen { get; set; }
        public DeliveryNoteTypeGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteTypeGroupByLangSLsCollectionEditor<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView>:RPSCollectionEditor<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView> where DeliveryNoteTypeGroupSLEntityView : class, IView where DeliveryNoteTypeGroupByLangSLView : class, IView
    {
        public  DeliveryNoteTypeGroupByLangSLsGridView<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteTypeGroupByLangSLsGridView <DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView> :  RPSGridView<DeliveryNoteTypeGroupSLEntityView,DeliveryNoteTypeGroupByLangSLView> where DeliveryNoteTypeGroupSLEntityView : class, IView where DeliveryNoteTypeGroupByLangSLView : class, IView
    {
        public DeliveryNoteTypeGroupByLangSLsGridView(DeliveryNoteTypeGroupSLEntityView currentView,DeliveryNoteTypeGroupByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteTypeGroupSLEntityView>("","#9ffc4004-0475-449a-95b3-36fba5f2a428 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteTypeGroupSLEntityView>("","#9ffc4004-0475-449a-95b3-36fba5f2a428 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteTypeGroupSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<DeliveryNoteTypeGroupSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteTypeGroupByLangSLView : View
    {
        public DeliveryNoteTypeGroupByLangSLView(DeliveryNoteTypeGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteTypeGroupByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView>( this,Screen.DeliveryNoteTypeGroupSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView>( this,Screen.DeliveryNoteTypeGroupSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView>( this,Screen.DeliveryNoteTypeGroupSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<DeliveryNoteTypeGroupByLangSLView>("8be9808a-cbe9-4207-b755-9a21c8c598f2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryNoteTypeGroupByLangSLView>("4863c173-1296-4f35-a113-896f3e208943","","",false, this);
 

        }
        public IRPSButton<DeliveryNoteTypeGroupByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteTypeGroupByLangSLView,DeliveryNoteTypeGroupSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteTypeGroupByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<DeliveryNoteTypeGroupByLangSLView> Description { get; set; } 
        public DeliveryNoteTypeGroup Screen { get; set; }
        public DeliveryNoteTypeGroupByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
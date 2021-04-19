    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Tax
{
    //RPS VERSION 1.0.0.0
    public partial class Tax:Screen
    {
        public Tax():base()
        {
            this.URL = "general.tax";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaxCollectionView  = new TaxCollectionView(this); 
            TaxEntityView  = new TaxEntityView(this); 
            TaxValueView  = new TaxValueView(this); 
            TaxValueDetailView  = new TaxValueDetailView(this); 
            TaxCollectionView.InitializeControls(); 
            TaxEntityView.InitializeControls(); 
            TaxValueView.InitializeControls(); 
            TaxValueDetailView.InitializeControls(); 
           
        }
      
            public TaxCollectionView TaxCollectionView {get; set; } 
            public TaxEntityView TaxEntityView {get; set; } 
            public TaxValueView TaxValueView {get; set; } 
            public TaxValueDetailView TaxValueDetailView {get; set; } 
    }
            
    public partial class TaxCollectionView : View
    {
        public TaxCollectionView(Tax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaxCollectionView,TaxEntityView>( this,Screen.TaxEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5a8f6d85-afd5-40ed-b948-8aa628cd416c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TaxCollectionView,TaxEntityView>( params_MainConsult,this,Screen.TaxEntityView);
 

        }
        public IRPSButton<TaxCollectionView,TaxEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TaxCollectionView,TaxEntityView> MainConsult { get; set; } 
        public Tax Screen { get; set; }
        public TaxCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaxEntityView : View
    {
        public TaxEntityView(Tax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaxEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxEntityView,TaxCollectionView>( this,Screen.TaxCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxEntityView,TaxCollectionView>( this,Screen.TaxCollectionView);
 
            CodTax = RPSControlFactory.CreateRPSTextBox<TaxEntityView>("02819d88-f8cf-4136-bc4a-f1e34e1b9bbc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaxEntityView>("9027a22e-d382-489d-bf38-dac77f1d5c80","","",false, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<TaxEntityView>("6580da04-c42c-401f-9b79-d3fc5453cb19","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<TaxEntityView>("815c7566-0ffa-4de6-8e19-67b7a40708a1","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<TaxEntityView>("21712682-f149-4968-af5a-a79e64d1ced9","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<TaxEntityView>("773cb0c8-0fda-4826-b3a5-13e99984a798","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<TaxEntityView>("453c82c7-2716-4a61-8035-ddab25c64fc8","","",true, this);
 
            RetentionType = RPSControlFactory.CreateRPSEnumComboBox<TaxEntityView>("bc676a15-5f5a-4606-aaa7-fec95e43f2ec","","",true, this);
 
            RetentionReceipt = RPSControlFactory.CreateRPSCheckBox<TaxEntityView>("29174a99-7ce2-4456-bee6-1f7dbc8a7d88","","",true, this);
 
            CollectionInit params_TaxValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a09867d6-7578-4fc9-888a-f82f4b0ea18a",CSSSelectorGrid="",XPathGrid=""};
            TaxValues = RPSControlFactory.RPSCreateCollectionWithGrid<TaxValuesCollectionEditor<TaxEntityView,TaxValueView>,TaxEntityView,TaxValueView>( params_TaxValues,this,Screen.TaxValueView);
 

        }
        public IRPSSaveButton<TaxEntityView> SaveButton { get; set; } 
        public IRPSButton<TaxEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaxEntityView,TaxCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxEntityView,TaxCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TaxEntityView> CodTax { get; set; } 
        public IRPSTextBox<TaxEntityView> Description { get; set; } 
        public IRPSComboBox<TaxEntityView> ApplicationType { get; set; } 
        public IRPSComboBox<TaxEntityView> Type { get; set; } 
        public IRPSCheckbox<TaxEntityView> PriceIncluded { get; set; } 
        public IRPSCheckbox<TaxEntityView> VAT { get; set; } 
        public IRPSComboBox<TaxEntityView> BaseType { get; set; } 
        public IRPSComboBox<TaxEntityView> RetentionType { get; set; } 
        public IRPSCheckbox<TaxEntityView> RetentionReceipt { get; set; } 
        public TaxValuesCollectionEditor<TaxEntityView,TaxValueView> TaxValues { get; set; } 
        public Tax Screen { get; set; }
        public TaxEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaxValuesCollectionEditor<TaxEntityView,TaxValueView>:RPSCollectionEditor<TaxEntityView,TaxValueView> where TaxEntityView : class, IView where TaxValueView : class, IView
    {
        public  TaxValuesGridView<TaxEntityView,TaxValueView> GridView {get;set;}
    }
    public partial class TaxValuesGridView <TaxEntityView,TaxValueView> :  RPSGridView<TaxEntityView,TaxValueView> where TaxEntityView : class, IView where TaxValueView : class, IView
    {
        public TaxValuesGridView(TaxEntityView currentView,TaxValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodTaxValue = RPSControlFactory.CreateRPSGridTextBox<TaxEntityView>("","#a09867d6-7578-4fc9-888a-f82f4b0ea18a .ag-row[role='row']@ROWINDEX [col-id='cCodTaxValue']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TaxEntityView>("","#a09867d6-7578-4fc9-888a-f82f4b0ea18a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaxEntityView> CodTaxValue { get; set; } 
        public IRPSGridTextBox<TaxEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaxValueView : View
    {
        public TaxValueView(Tax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxValueView,TaxEntityView>( this,Screen.TaxEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxValueView,TaxEntityView>( this,Screen.TaxEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaxValueView,TaxEntityView>( this,Screen.TaxEntityView);
 
            CodTaxValue = RPSControlFactory.CreateRPSTextBox<TaxValueView>("ec28b13a-14bf-4c70-bd59-6b6c3c7fd07c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaxValueView>("171f2298-6851-430c-ac96-1ceb491cb382","","",true, this);
 
            CollectionInit params_TaxValueDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="74293a73-e46e-4f58-a428-c93e00643ce5",CSSSelectorGrid="",XPathGrid=""};
            TaxValueDetails = RPSControlFactory.RPSCreateCollectionWithGrid<TaxValueDetailsCollectionEditor<TaxValueView,TaxValueDetailView>,TaxValueView,TaxValueDetailView>( params_TaxValueDetails,this,Screen.TaxValueDetailView);
 

        }
        public IRPSButton<TaxValueView> DeleteButton { get; set; } 
        public IRPSButton<TaxValueView,TaxEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxValueView,TaxEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TaxValueView,TaxEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<TaxValueView> CodTaxValue { get; set; } 
        public IRPSTextBox<TaxValueView> Description { get; set; } 
        public TaxValueDetailsCollectionEditor<TaxValueView,TaxValueDetailView> TaxValueDetails { get; set; } 
        public Tax Screen { get; set; }
        public TaxValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaxValueDetailsCollectionEditor<TaxValueView,TaxValueDetailView>:RPSCollectionEditor<TaxValueView,TaxValueDetailView> where TaxValueView : class, IView where TaxValueDetailView : class, IView
    {
        public  TaxValueDetailsGridView<TaxValueView,TaxValueDetailView> GridView {get;set;}
    }
    public partial class TaxValueDetailsGridView <TaxValueView,TaxValueDetailView> :  RPSGridView<TaxValueView,TaxValueDetailView> where TaxValueView : class, IView where TaxValueDetailView : class, IView
    {
        public TaxValueDetailsGridView(TaxValueView currentView,TaxValueDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<TaxValueView>("","#74293a73-e46e-4f58-a428-c93e00643ce5 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxValueView>("","#74293a73-e46e-4f58-a428-c93e00643ce5 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaxValueView> DateFrom { get; set; } 
        public IRPSGridTextBox<TaxValueView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaxValueDetailView : View
    {
        public TaxValueDetailView(Tax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxValueDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxValueDetailView,TaxValueView>( this,Screen.TaxValueView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxValueDetailView,TaxValueView>( this,Screen.TaxValueView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaxValueDetailView,TaxValueView>( this,Screen.TaxValueView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<TaxValueDetailView>("ff37ee95-e803-40b8-99ce-ee1999e03b05","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<TaxValueDetailView>("5fb01d04-98d7-42f1-956a-3c2551b45804","","",true, this);
 

        }
        public IRPSButton<TaxValueDetailView> DeleteButton { get; set; } 
        public IRPSButton<TaxValueDetailView,TaxValueView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxValueDetailView,TaxValueView> BackButton { get; set; } 
        public IRPSAcceptButton<TaxValueDetailView,TaxValueView> AcceptButton { get; set; } 
        public IRPSTextBox<TaxValueDetailView> DateFrom { get; set; } 
        public IRPSTextBox<TaxValueDetailView> Value { get; set; } 
        public Tax Screen { get; set; }
        public TaxValueDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
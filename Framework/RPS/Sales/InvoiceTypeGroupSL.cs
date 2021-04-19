    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceTypeGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceTypeGroupSL:Screen
    {
        public InvoiceTypeGroupSL():base()
        {
            this.URL = "sales.invoicetypegroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceTypeGroupSLCollectionView  = new InvoiceTypeGroupSLCollectionView(this); 
            InvoiceTypeGroupSLEntityView  = new InvoiceTypeGroupSLEntityView(this); 
            InvoiceTypeGroupByLangSLView  = new InvoiceTypeGroupByLangSLView(this); 
            InvoiceTypeGroupSLCollectionView.InitializeControls(); 
            InvoiceTypeGroupSLEntityView.InitializeControls(); 
            InvoiceTypeGroupByLangSLView.InitializeControls(); 
           
        }
      
            public InvoiceTypeGroupSLCollectionView InvoiceTypeGroupSLCollectionView {get; set; } 
            public InvoiceTypeGroupSLEntityView InvoiceTypeGroupSLEntityView {get; set; } 
            public InvoiceTypeGroupByLangSLView InvoiceTypeGroupByLangSLView {get; set; } 
    }
            
    public partial class InvoiceTypeGroupSLCollectionView : View
    {
        public InvoiceTypeGroupSLCollectionView(InvoiceTypeGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceTypeGroupSLCollectionView,InvoiceTypeGroupSLEntityView>( this,Screen.InvoiceTypeGroupSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e20ed6c3-c6eb-459c-8087-dd9b5846fca8",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceTypeGroupSLCollectionView,InvoiceTypeGroupSLEntityView>( params_MainConsult,this,Screen.InvoiceTypeGroupSLEntityView);
 

        }
        public IRPSButton<InvoiceTypeGroupSLCollectionView,InvoiceTypeGroupSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoiceTypeGroupSLCollectionView,InvoiceTypeGroupSLEntityView> MainConsult { get; set; } 
        public InvoiceTypeGroupSL Screen { get; set; }
        public InvoiceTypeGroupSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceTypeGroupSLEntityView : View
    {
        public InvoiceTypeGroupSLEntityView(InvoiceTypeGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceTypeGroupSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceTypeGroupSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupSLCollectionView>( this,Screen.InvoiceTypeGroupSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupSLCollectionView>( this,Screen.InvoiceTypeGroupSLCollectionView);
 
            CodInvoiceTypeGroup = RPSControlFactory.CreateRPSTextBox<InvoiceTypeGroupSLEntityView>("3d88c629-0518-446a-a75e-8b8a921f7ab4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceTypeGroupSLEntityView>("e7fe0fbc-f067-4911-b8c5-dbfaeb2d545d","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<InvoiceTypeGroupSLEntityView>("6a34eb89-80f6-4d69-97e2-06e1302efae4","","",true, this);
 
            PaymentDateType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceTypeGroupSLEntityView>("5b00b54a-e3b3-41f6-8c04-b71dda0bb4c3","","",true, this);
 
            Day1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTypeGroupSLEntityView>("4817d744-35d5-44d1-a1ea-9c085d592692","","",true, this);
 
            Day2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTypeGroupSLEntityView>("041f9065-bc87-495e-b729-573df3cbf6e9","","",true, this);
 
            Day3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTypeGroupSLEntityView>("e0c88843-f1a9-4d59-9178-b67c11e713fc","","",true, this);
 
            Day4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTypeGroupSLEntityView>("45ec4de2-6b4f-49b0-a8db-0bcfecc950b6","","",true, this);
 
            CollectionInit params_InvoiceTypeGroupByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8bc61767-7ab8-43d7-944d-f3b29d13f948",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTypeGroupByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTypeGroupByLangSLsCollectionEditor<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView>,InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView>( params_InvoiceTypeGroupByLangSLs,this,Screen.InvoiceTypeGroupByLangSLView);
 

        }
        public IRPSSaveButton<InvoiceTypeGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceTypeGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> CodInvoiceTypeGroup { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> Description { get; set; } 
        public IRPSComboBox<InvoiceTypeGroupSLEntityView> Type { get; set; } 
        public IRPSComboBox<InvoiceTypeGroupSLEntityView> PaymentDateType { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> Day1 { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> Day2 { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> Day3 { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupSLEntityView> Day4 { get; set; } 
        public InvoiceTypeGroupByLangSLsCollectionEditor<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView> InvoiceTypeGroupByLangSLs { get; set; } 
        public InvoiceTypeGroupSL Screen { get; set; }
        public InvoiceTypeGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceTypeGroupByLangSLsCollectionEditor<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView>:RPSCollectionEditor<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView> where InvoiceTypeGroupSLEntityView : class, IView where InvoiceTypeGroupByLangSLView : class, IView
    {
        public  InvoiceTypeGroupByLangSLsGridView<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView> GridView {get;set;}
    }
    public partial class InvoiceTypeGroupByLangSLsGridView <InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView> :  RPSGridView<InvoiceTypeGroupSLEntityView,InvoiceTypeGroupByLangSLView> where InvoiceTypeGroupSLEntityView : class, IView where InvoiceTypeGroupByLangSLView : class, IView
    {
        public InvoiceTypeGroupByLangSLsGridView(InvoiceTypeGroupSLEntityView currentView,InvoiceTypeGroupByLangSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<InvoiceTypeGroupSLEntityView>("","#8bc61767-7ab8-43d7-944d-f3b29d13f948 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceTypeGroupSLEntityView>("","#8bc61767-7ab8-43d7-944d-f3b29d13f948 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceTypeGroupSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<InvoiceTypeGroupSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceTypeGroupByLangSLView : View
    {
        public InvoiceTypeGroupByLangSLView(InvoiceTypeGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceTypeGroupByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView>( this,Screen.InvoiceTypeGroupSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView>( this,Screen.InvoiceTypeGroupSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView>( this,Screen.InvoiceTypeGroupSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<InvoiceTypeGroupByLangSLView>("18d1b077-8c2c-4f56-bf22-1b8240fbbf60","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceTypeGroupByLangSLView>("43b6e9ae-9b25-49b5-bb96-1203cef2b46c","","",false, this);
 

        }
        public IRPSButton<InvoiceTypeGroupByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceTypeGroupByLangSLView,InvoiceTypeGroupSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<InvoiceTypeGroupByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<InvoiceTypeGroupByLangSLView> Description { get; set; } 
        public InvoiceTypeGroupSL Screen { get; set; }
        public InvoiceTypeGroupByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
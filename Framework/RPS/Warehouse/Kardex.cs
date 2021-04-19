    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Kardex
{
    //RPS VERSION 1.0.0.0
    public partial class Kardex:Screen
    {
        public Kardex():base()
        {
            this.URL = "warehouse.kardex";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            KardexQueryView  = new KardexQueryView(this); 
            KardexChildDialogView  = new KardexChildDialogView(this); 
            KardexQueryView.InitializeControls(); 
            KardexChildDialogView.InitializeControls(); 
           
        }
      
            public KardexQueryView KardexQueryView {get; set; } 
            public KardexChildDialogView KardexChildDialogView {get; set; } 
    }
            
    public partial class KardexQueryView : View
    {
        public KardexQueryView(Kardex screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<KardexQueryView>("4ad86383-d0ed-4eb8-bfeb-698fd62a456f","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<KardexQueryView>("9f415bd5-6e8f-41df-8004-c9e4353eeebe","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<KardexQueryView>("1de4aa94-3f14-4838-a77d-7b772f5a1097","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<KardexQueryView>("35473d41-6c63-48a1-b66e-8e00a491c834","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSOption<KardexQueryView>( "010e12f6-fcb0-4fbd-92b0-52c9992a4fbc","","",this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<KardexQueryView>("0324b0ef-fc0e-454c-8285-b9f030a36840","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSOption<KardexQueryView>( "9b803c00-c283-41a2-8d7f-4d3dbdf59551","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<KardexQueryView>("40884c2c-f767-4436-9021-521730409e2a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<KardexQueryView>("33d22360-86a7-4ac7-94f3-e56789a785fe","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<KardexQueryView>("4a60e821-8a93-47c5-805f-b25c0a73ce3a","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<KardexQueryView>("b6fda514-3715-4cad-98d2-3e2357965b0e","","",false, this);
 
            TotalInventory = RPSControlFactory.CreateRPSFormattedTextBox<KardexQueryView>("50245b5c-c96f-409a-bb3d-fd2a510306d3","","",false, this);
 
            QuantityAbreviature = RPSControlFactory.CreateRPSTextBox<KardexQueryView>("c0522fc9-1f4a-47d1-8d60-68d17a09fa99","","",false, this);
 
            PriceAbreviature = RPSControlFactory.CreateRPSTextBox<KardexQueryView>("8c70ef8a-e08f-4c15-9e9c-189c3a6741ab","","",false, this);
 
            KardexChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<KardexQueryView,KardexChildDialogView>("e89cafc8-c218-4cf8-9d68-9a28875dc7f6","","", this,Screen.KardexChildDialogView);
 
            CollectionInit params_Kardex = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a68fefa3-aad7-4e06-a6c0-382da4cb13f0",CSSSelectorGrid="",XPathGrid=""};
            Kardex = RPSControlFactory.RPSCreateCollectionWithGrid<KardexCollectionEditor<KardexQueryView,KardexChildDialogView>,KardexQueryView,KardexChildDialogView>( params_Kardex,this,Screen.KardexChildDialogView);
 

        }
        public IRPSComboBox<KardexQueryView> IDArticle { get; set; } 
        public IRPSComboBox<KardexQueryView> IDSite { get; set; } 
        public IRPSComboBox<KardexQueryView> IDWareHouse { get; set; } 
        public IRPSTextBox<KardexQueryView> DateFrom { get; set; } 
        public IRPSOption<KardexQueryView> Quantity { get; set; } 
        public IRPSTextBox<KardexQueryView> DateTo { get; set; } 
        public IRPSOption<KardexQueryView> QuantitySecondUnit { get; set; } 
        public IRPSCollectionComboBox<KardexQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<KardexQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<KardexQueryView> ProductSubFamily { get; set; } 
        public IRPSTextBox<KardexQueryView> TotalAmount { get; set; } 
        public IRPSTextBox<KardexQueryView> TotalInventory { get; set; } 
        public IRPSTextBox<KardexQueryView> QuantityAbreviature { get; set; } 
        public IRPSTextBox<KardexQueryView> PriceAbreviature { get; set; } 
        public IRPSButton<KardexQueryView,KardexChildDialogView> KardexChildNavigationCommandButton { get; set; } 
        public KardexCollectionEditor<KardexQueryView,KardexChildDialogView> Kardex { get; set; } 
        public Kardex Screen { get; set; }
        public KardexQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KardexCollectionEditor<KardexQueryView,KardexChildDialogView>:RPSCollectionEditor<KardexQueryView,KardexChildDialogView> where KardexQueryView : class, IView where KardexChildDialogView : class, IView
    {
        public  KardexGridView<KardexQueryView,KardexChildDialogView> GridView {get;set;}
    }
    public partial class KardexGridView <KardexQueryView,KardexChildDialogView> :  RPSGridView<KardexQueryView,KardexChildDialogView> where KardexQueryView : class, IView where KardexChildDialogView : class, IView
    {
        public KardexGridView(KardexQueryView currentView,KardexChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MovementDate = RPSControlFactory.CreateRPSGridTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cMovementDate']","",false, this.CurrentView);
 
            MovementType1 = RPSControlFactory.CreateRPSGridComboBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cMovementType1']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            EntryQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cEntryQuantity']","",false, this.CurrentView);
 
            EntryPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cEntryPrice']","",false, this.CurrentView);
 
            EntryAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cEntryAmount']","",false, this.CurrentView);
 
            OutputQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cOutputQuantity']","",false, this.CurrentView);
 
            OutputPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cOutputPrice']","",false, this.CurrentView);
 
            OutputAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cOutputAmount']","",false, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",false, this.CurrentView);
 
            TotalPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cTotalPrice']","",false, this.CurrentView);
 
            TotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cTotalAmount']","",false, this.CurrentView);
 
            TotalInventory = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexQueryView>("","#a68fefa3-aad7-4e06-a6c0-382da4cb13f0 .ag-row[role='row']@ROWINDEX [col-id='cTotalInventory']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<KardexQueryView> MovementDate { get; set; } 
        public IRPSGridComboBox<KardexQueryView> MovementType1 { get; set; } 
        public IRPSGridTextBox<KardexQueryView> Description { get; set; } 
        public IRPSGridTextBox<KardexQueryView> EntryQuantity { get; set; } 
        public IRPSGridTextBox<KardexQueryView> EntryPrice { get; set; } 
        public IRPSGridTextBox<KardexQueryView> EntryAmount { get; set; } 
        public IRPSGridTextBox<KardexQueryView> OutputQuantity { get; set; } 
        public IRPSGridTextBox<KardexQueryView> OutputPrice { get; set; } 
        public IRPSGridTextBox<KardexQueryView> OutputAmount { get; set; } 
        public IRPSGridTextBox<KardexQueryView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<KardexQueryView> TotalPrice { get; set; } 
        public IRPSGridTextBox<KardexQueryView> TotalAmount { get; set; } 
        public IRPSGridTextBox<KardexQueryView> TotalInventory { get; set; } 
                     
    }
 
    }
  
            
    public partial class KardexChildDialogView : View
    {
        public KardexChildDialogView(Kardex screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Total = RPSControlFactory.CreateRPSFormattedTextBox<KardexChildDialogView>("17a6c2a0-37c6-47ce-9002-ee0da553845f","","",false, this);
 
            CollectionInit params_GenerelaLedgedData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0690091c-7214-49bb-8875-cd0c53681c4c",CSSSelectorGrid="",XPathGrid=""};
            GenerelaLedgedData = RPSControlFactory.RPSCreateCollectionWithGrid<GenerelaLedgedDataCollectionEditor<KardexChildDialogView>,KardexChildDialogView>( params_GenerelaLedgedData,this);
 

        }
        public IRPSTextBox<KardexChildDialogView> Total { get; set; } 
        public GenerelaLedgedDataCollectionEditor<KardexChildDialogView> GenerelaLedgedData { get; set; } 
        public Kardex Screen { get; set; }
        public KardexChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GenerelaLedgedDataCollectionEditor<KardexChildDialogView>:RPSCollectionEditor<KardexChildDialogView> where KardexChildDialogView : class, IView
    {
        public  GenerelaLedgedDataGridView<KardexChildDialogView> GridView {get;set;}
    }
    public partial class GenerelaLedgedDataGridView <KardexChildDialogView> :  RPSGridView<KardexChildDialogView> where KardexChildDialogView : class, IView
    {
        public GenerelaLedgedDataGridView(KardexChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<KardexChildDialogView>("","#0690091c-7214-49bb-8875-cd0c53681c4c .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<KardexChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
    

}
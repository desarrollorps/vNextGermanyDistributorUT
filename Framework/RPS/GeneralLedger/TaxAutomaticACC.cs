    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.TaxAutomaticACC
{
    //RPS VERSION 1.0.0.0
    public partial class TaxAutomaticACC:Screen
    {
        public TaxAutomaticACC():base()
        {
            this.URL = "generalledger.taxautomaticacc";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaxAutomaticACCCollectionView  = new TaxAutomaticACCCollectionView(this); 
            TaxAutomaticACCEntityView  = new TaxAutomaticACCEntityView(this); 
            TaxAutomaticACCCollectionView.InitializeControls(); 
            TaxAutomaticACCEntityView.InitializeControls(); 
           
        }
      
            public TaxAutomaticACCCollectionView TaxAutomaticACCCollectionView {get; set; } 
            public TaxAutomaticACCEntityView TaxAutomaticACCEntityView {get; set; } 
    }
            
    public partial class TaxAutomaticACCCollectionView : View
    {
        public TaxAutomaticACCCollectionView(TaxAutomaticACC screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaxAutomaticACCCollectionView,TaxAutomaticACCEntityView>( this,Screen.TaxAutomaticACCEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "30bdad6e-b73b-4fa8-abd5-f88a2b91578e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TaxAutomaticACCCollectionView,TaxAutomaticACCEntityView>( params_MainConsult,this,Screen.TaxAutomaticACCEntityView);
 

        }
        public IRPSButton<TaxAutomaticACCCollectionView,TaxAutomaticACCEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TaxAutomaticACCCollectionView,TaxAutomaticACCEntityView> MainConsult { get; set; } 
        public TaxAutomaticACC Screen { get; set; }
        public TaxAutomaticACCCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaxAutomaticACCEntityView : View
    {
        public TaxAutomaticACCEntityView(TaxAutomaticACC screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaxAutomaticACCEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxAutomaticACCEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxAutomaticACCEntityView,TaxAutomaticACCCollectionView>( this,Screen.TaxAutomaticACCCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxAutomaticACCEntityView,TaxAutomaticACCCollectionView>( this,Screen.TaxAutomaticACCCollectionView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("86aaa9f3-1d9b-447b-b2de-1956ada7c3da","","",true, this);
 
            IDAccountPurchase = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("7cc530b5-49e5-4979-a72d-9f2baf129f0e","","",false, this);
 
            IDAccountSales = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("d683ccff-3905-4a3a-b68e-b067fa66c20c","","",false, this);
 
            IDAccConceptTaxPurchase = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("83e69d4e-cf5a-4669-b5a3-4c2ad2c19629","","",false, this);
 
            IDAccConceptTaxSales = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("1d818d8d-ac7f-485e-bfd3-b06ea4757b4e","","",false, this);
 
            DeclarePay = RPSControlFactory.CreateRPSCheckBox<TaxAutomaticACCEntityView>("8a5de529-6c58-465e-99d8-ce70dfbd4732","","",true, this);
 
            IDAccountPurchasePen = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("a0e07de4-0101-4c67-9e4a-98d1b8fe262c","","",false, this);
 
            IDAccountSalesPen = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("7143b5a8-95b4-449a-81c9-9d8ec84ba507","","",false, this);
 
            IDAccountExhangePos = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("26312dbe-c52b-4804-8b9b-0694ef5d235e","","",false, this);
 
            IDAccountExhangeNeg = RPSControlFactory.CreateRPSComboBox<TaxAutomaticACCEntityView>("b15fe490-65f3-465a-b618-2984c6c7483a","","",false, this);
 

        }
        public IRPSSaveButton<TaxAutomaticACCEntityView> SaveButton { get; set; } 
        public IRPSButton<TaxAutomaticACCEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaxAutomaticACCEntityView,TaxAutomaticACCCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxAutomaticACCEntityView,TaxAutomaticACCCollectionView> BackButton { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDTaxValue { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountPurchase { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountSales { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccConceptTaxPurchase { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccConceptTaxSales { get; set; } 
        public IRPSCheckbox<TaxAutomaticACCEntityView> DeclarePay { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountPurchasePen { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountSalesPen { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountExhangePos { get; set; } 
        public IRPSComboBox<TaxAutomaticACCEntityView> IDAccountExhangeNeg { get; set; } 
        public TaxAutomaticACC Screen { get; set; }
        public TaxAutomaticACCEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
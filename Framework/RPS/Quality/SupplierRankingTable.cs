    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SupplierRankingTable
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRankingTable:Screen
    {
        public SupplierRankingTable():base()
        {
            this.URL = "quality.supplierrankingtable";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRankingTableCollectionView  = new SupplierRankingTableCollectionView(this); 
            SupplierRankingTableEntityView  = new SupplierRankingTableEntityView(this); 
            SupplierRankingTableCollectionView.InitializeControls(); 
            SupplierRankingTableEntityView.InitializeControls(); 
           
        }
      
            public SupplierRankingTableCollectionView SupplierRankingTableCollectionView {get; set; } 
            public SupplierRankingTableEntityView SupplierRankingTableEntityView {get; set; } 
    }
            
    public partial class SupplierRankingTableCollectionView : View
    {
        public SupplierRankingTableCollectionView(SupplierRankingTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierRankingTableCollectionView,SupplierRankingTableEntityView>( this,Screen.SupplierRankingTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d79954bb-597b-4dab-b778-c65a82090a3e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierRankingTableCollectionView,SupplierRankingTableEntityView>( params_MainConsult,this,Screen.SupplierRankingTableEntityView);
 

        }
        public IRPSButton<SupplierRankingTableCollectionView,SupplierRankingTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierRankingTableCollectionView,SupplierRankingTableEntityView> MainConsult { get; set; } 
        public SupplierRankingTable Screen { get; set; }
        public SupplierRankingTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierRankingTableEntityView : View
    {
        public SupplierRankingTableEntityView(SupplierRankingTable screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierRankingTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierRankingTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierRankingTableEntityView,SupplierRankingTableCollectionView>( this,Screen.SupplierRankingTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierRankingTableEntityView,SupplierRankingTableCollectionView>( this,Screen.SupplierRankingTableCollectionView);
 
            RankingCode = RPSControlFactory.CreateRPSTextBox<SupplierRankingTableEntityView>("5169700b-a36f-40d4-b2c0-b185db95a791","","",true, this);
 
            LowerLimit = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRankingTableEntityView>("80e8d986-931c-4780-aa59-23f3b10e9c33","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierRankingTableEntityView>("d17b47ea-313d-4c33-a746-595fe97b6423","","",false, this);
 

        }
        public IRPSSaveButton<SupplierRankingTableEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierRankingTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierRankingTableEntityView,SupplierRankingTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierRankingTableEntityView,SupplierRankingTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierRankingTableEntityView> RankingCode { get; set; } 
        public IRPSTextBox<SupplierRankingTableEntityView> LowerLimit { get; set; } 
        public IRPSTextBox<SupplierRankingTableEntityView> Description { get; set; } 
        public SupplierRankingTable Screen { get; set; }
        public SupplierRankingTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
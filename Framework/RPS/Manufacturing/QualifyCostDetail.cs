    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.QualifyCostDetail
{
    //RPS VERSION 1.0.0.0
    public partial class QualifyCostDetail:Screen
    {
        public QualifyCostDetail():base()
        {
            this.URL = "manufacturing.qualifycostdetail";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualifyCostDetailCollectionView  = new QualifyCostDetailCollectionView(this); 
            QualifyCostDetailEntityView  = new QualifyCostDetailEntityView(this); 
            QualifyCostDetailCollectionView.InitializeControls(); 
            QualifyCostDetailEntityView.InitializeControls(); 
           
        }
      
            public QualifyCostDetailCollectionView QualifyCostDetailCollectionView {get; set; } 
            public QualifyCostDetailEntityView QualifyCostDetailEntityView {get; set; } 
    }
            
    public partial class QualifyCostDetailCollectionView : View
    {
        public QualifyCostDetailCollectionView(QualifyCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualifyCostDetailCollectionView,QualifyCostDetailEntityView>( this,Screen.QualifyCostDetailEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2b853898-b127-4a74-b829-7cb23f870eae",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QualifyCostDetailCollectionView,QualifyCostDetailEntityView>( params_MainConsult,this,Screen.QualifyCostDetailEntityView);
 

        }
        public IRPSButton<QualifyCostDetailCollectionView,QualifyCostDetailEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<QualifyCostDetailCollectionView,QualifyCostDetailEntityView> MainConsult { get; set; } 
        public QualifyCostDetail Screen { get; set; }
        public QualifyCostDetailCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualifyCostDetailEntityView : View
    {
        public QualifyCostDetailEntityView(QualifyCostDetail screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyCostDetailEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualifyCostDetailEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualifyCostDetailEntityView,QualifyCostDetailCollectionView>( this,Screen.QualifyCostDetailCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualifyCostDetailEntityView,QualifyCostDetailCollectionView>( this,Screen.QualifyCostDetailCollectionView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<QualifyCostDetailEntityView>("a7d111cc-48fc-427e-880b-e480ba75444a","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QualifyCostDetailEntityView>("d3cb9b5e-8eda-495a-a662-24de4ee3c273","","",true, this);
 

        }
        public IRPSSaveButton<QualifyCostDetailEntityView> SaveButton { get; set; } 
        public IRPSButton<QualifyCostDetailEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualifyCostDetailEntityView,QualifyCostDetailCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualifyCostDetailEntityView,QualifyCostDetailCollectionView> BackButton { get; set; } 
        public IRPSComboBox<QualifyCostDetailEntityView> IDCostDetailType { get; set; } 
        public IRPSTextBox<QualifyCostDetailEntityView> CostPrice { get; set; } 
        public QualifyCostDetail Screen { get; set; }
        public QualifyCostDetailEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
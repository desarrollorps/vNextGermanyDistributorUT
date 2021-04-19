    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.QualifyCostCPR
{
    //RPS VERSION 1.0.0.0
    public partial class QualifyCostCPR:Screen
    {
        public QualifyCostCPR():base()
        {
            this.URL = "manufacturing.qualifycostcpr";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualifyCostCollectionView  = new QualifyCostCollectionView(this); 
            QualifyCostEntityView  = new QualifyCostEntityView(this); 
            QualifyCostDetailView  = new QualifyCostDetailView(this); 
            QualifyCostCollectionView.InitializeControls(); 
            QualifyCostEntityView.InitializeControls(); 
            QualifyCostDetailView.InitializeControls(); 
           
        }
      
            public QualifyCostCollectionView QualifyCostCollectionView {get; set; } 
            public QualifyCostEntityView QualifyCostEntityView {get; set; } 
            public QualifyCostDetailView QualifyCostDetailView {get; set; } 
    }
            
    public partial class QualifyCostCollectionView : View
    {
        public QualifyCostCollectionView(QualifyCostCPR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualifyCostCollectionView,QualifyCostEntityView>( this,Screen.QualifyCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "272b8d03-dd71-4fa8-a311-bd272f3ee0ec",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QualifyCostCollectionView,QualifyCostEntityView>( params_MainConsult,this,Screen.QualifyCostEntityView);
 

        }
        public IRPSButton<QualifyCostCollectionView,QualifyCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<QualifyCostCollectionView,QualifyCostEntityView> MainConsult { get; set; } 
        public QualifyCostCPR Screen { get; set; }
        public QualifyCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualifyCostEntityView : View
    {
        public QualifyCostEntityView(QualifyCostCPR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualifyCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualifyCostEntityView,QualifyCostCollectionView>( this,Screen.QualifyCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualifyCostEntityView,QualifyCostCollectionView>( this,Screen.QualifyCostCollectionView);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<QualifyCostEntityView>("13421dce-84f9-41c9-8654-eec0b92b60a3","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<QualifyCostEntityView>("bdeec09f-a11a-47df-a043-dc0a3ccb4b1c","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<QualifyCostEntityView>("8e09e580-40a0-4e7f-bce1-5e8f2af474c2","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QualifyCostEntityView>("a77cf4cf-ed01-496b-adbf-cef62f6db5d0","","",true, this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<QualifyCostEntityView>( "6f474846-8ed0-47a7-b3bd-8723070a877a","","",this);
 
            CollectionInit params_QualifyCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ca2b0b80-9eca-475f-81c7-12bf3204faeb",CSSSelectorGrid="",XPathGrid=""};
            QualifyCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<QualifyCostDetailCollectionEditor<QualifyCostEntityView>,QualifyCostEntityView>( params_QualifyCostDetail,this);
 

        }
        public IRPSSaveButton<QualifyCostEntityView> SaveButton { get; set; } 
        public IRPSButton<QualifyCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualifyCostEntityView,QualifyCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualifyCostEntityView,QualifyCostCollectionView> BackButton { get; set; } 
        public IRPSComboBox<QualifyCostEntityView> IDQualify { get; set; } 
        public IRPSComboBox<QualifyCostEntityView> IDHourType { get; set; } 
        public IRPSTextBox<QualifyCostEntityView> DateFrom { get; set; } 
        public IRPSTextBox<QualifyCostEntityView> CostPrice { get; set; } 
        public IRPSButton<QualifyCostEntityView> LinkNavigationCommand { get; set; } 
        public QualifyCostDetailCollectionEditor<QualifyCostEntityView> QualifyCostDetail { get; set; } 
        public QualifyCostCPR Screen { get; set; }
        public QualifyCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QualifyCostDetailCollectionEditor<QualifyCostEntityView>:RPSCollectionEditor<QualifyCostEntityView> where QualifyCostEntityView : class, IView
    {
        public  QualifyCostDetailGridView<QualifyCostEntityView> GridView {get;set;}
    }
    public partial class QualifyCostDetailGridView <QualifyCostEntityView> :  RPSGridView<QualifyCostEntityView> where QualifyCostEntityView : class, IView
    {
        public QualifyCostDetailGridView(QualifyCostEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class QualifyCostDetailView : View
    {
        public QualifyCostDetailView(QualifyCostCPR screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyCostDetailView>( this);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<QualifyCostDetailView>("69fecaa4-2a77-40bc-bc1c-f30b24d0e7b1","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QualifyCostDetailView>("c36acf8b-e906-475a-ae1c-70d682e91d51","","",true, this);
 

        }
        public IRPSSaveButton<QualifyCostDetailView> SaveButton { get; set; } 
        public IRPSComboBox<QualifyCostDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<QualifyCostDetailView> CostPrice { get; set; } 
        public QualifyCostCPR Screen { get; set; }
        public QualifyCostDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
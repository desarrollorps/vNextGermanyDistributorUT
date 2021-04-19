    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.SimulationQualify
{
    //RPS VERSION 1.0.0.0
    public partial class SimulationQualify:Screen
    {
        public SimulationQualify():base()
        {
            this.URL = "manufacturing.simulationqualify";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualifyCostSimVMQueryView  = new QualifyCostSimVMQueryView(this); 
            QualifyCostSimVMEntityView  = new QualifyCostSimVMEntityView(this); 
            QualifyCostSimDetailView  = new QualifyCostSimDetailView(this); 
            SimulationQualifyDialogView  = new SimulationQualifyDialogView(this); 
            QualifyCostSimVMQueryView.InitializeControls(); 
            QualifyCostSimVMEntityView.InitializeControls(); 
            QualifyCostSimDetailView.InitializeControls(); 
            SimulationQualifyDialogView.InitializeControls(); 
           
        }
      
            public QualifyCostSimVMQueryView QualifyCostSimVMQueryView {get; set; } 
            public QualifyCostSimVMEntityView QualifyCostSimVMEntityView {get; set; } 
            public QualifyCostSimDetailView QualifyCostSimDetailView {get; set; } 
            public SimulationQualifyDialogView SimulationQualifyDialogView {get; set; } 
    }
            
    public partial class QualifyCostSimVMQueryView : View
    {
        public QualifyCostSimVMQueryView(SimulationQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView>( this,Screen.QualifyCostSimVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<QualifyCostSimVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSComboBox<QualifyCostSimVMQueryView>("12b0cff4-cdce-4621-a2c5-859fadac2411","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<QualifyCostSimVMQueryView>( "07bf1c9d-0900-4d9a-b075-dc476af386b6","","",this);
 
            SimulationQualifyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QualifyCostSimVMQueryView,SimulationQualifyDialogView>("0d2e5904-9e0c-467b-8f1f-7400490b9fb0","","", this,Screen.SimulationQualifyDialogView);
 
            CollectionInit params_QualifyCostSim = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5724454d-74b9-44dc-af9a-517d139f905b",CSSSelectorGrid="",XPathGrid=""};
            QualifyCostSim = RPSControlFactory.RPSCreateCollectionWithGrid<QualifyCostSimCollectionEditor<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView>,QualifyCostSimVMQueryView,QualifyCostSimVMEntityView>( params_QualifyCostSim,this,Screen.QualifyCostSimVMEntityView);
 

        }
        public IRPSButton<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> NewButton { get; set; } 
        public IRPSButton<QualifyCostSimVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<QualifyCostSimVMQueryView> Site { get; set; } 
        public IRPSButton<QualifyCostSimVMQueryView> DeleteCommandButton { get; set; } 
        public IRPSButton<QualifyCostSimVMQueryView,SimulationQualifyDialogView> SimulationQualifyNavigationCommandButton { get; set; } 
        public QualifyCostSimCollectionEditor<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> QualifyCostSim { get; set; } 
        public SimulationQualify Screen { get; set; }
        public QualifyCostSimVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QualifyCostSimCollectionEditor<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView>:RPSCollectionEditor<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> where QualifyCostSimVMQueryView : class, IView where QualifyCostSimVMEntityView : class, IView
    {
        public  QualifyCostSimGridView<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> GridView {get;set;}
    }
    public partial class QualifyCostSimGridView <QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> :  RPSGridView<QualifyCostSimVMQueryView,QualifyCostSimVMEntityView> where QualifyCostSimVMQueryView : class, IView where QualifyCostSimVMEntityView : class, IView
    {
        public QualifyCostSimGridView(QualifyCostSimVMQueryView currentView,QualifyCostSimVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class QualifyCostSimVMEntityView : View
    {
        public QualifyCostSimVMEntityView(SimulationQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualifyCostSimVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualifyCostSimVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualifyCostSimVMEntityView,QualifyCostSimVMQueryView>( this,Screen.QualifyCostSimVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualifyCostSimVMEntityView,QualifyCostSimVMQueryView>( this,Screen.QualifyCostSimVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<QualifyCostSimVMEntityView>("4e82043d-bb9d-42e0-9556-a15c211294a4","","",true, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<QualifyCostSimVMEntityView>("c45bf998-e025-433d-92d3-4fd12a2c0b8e","","",true, this);
 
            CollectionInit params_CPRQualifyCostSimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6f1556a-0054-4707-8d82-5d24c72f0ff3",CSSSelectorGrid="",XPathGrid=""};
            CPRQualifyCostSimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CPRQualifyCostSimDetailsCollectionEditor<QualifyCostSimVMEntityView,QualifyCostSimDetailView>,QualifyCostSimVMEntityView,QualifyCostSimDetailView>( params_CPRQualifyCostSimDetails,this,Screen.QualifyCostSimDetailView);
 

        }
        public IRPSSaveButton<QualifyCostSimVMEntityView> SaveButton { get; set; } 
        public IRPSButton<QualifyCostSimVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualifyCostSimVMEntityView,QualifyCostSimVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualifyCostSimVMEntityView,QualifyCostSimVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<QualifyCostSimVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<QualifyCostSimVMEntityView> IDQualify { get; set; } 
        public CPRQualifyCostSimDetailsCollectionEditor<QualifyCostSimVMEntityView,QualifyCostSimDetailView> CPRQualifyCostSimDetails { get; set; } 
        public SimulationQualify Screen { get; set; }
        public QualifyCostSimVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CPRQualifyCostSimDetailsCollectionEditor<QualifyCostSimVMEntityView,QualifyCostSimDetailView>:RPSCollectionEditor<QualifyCostSimVMEntityView,QualifyCostSimDetailView> where QualifyCostSimVMEntityView : class, IView where QualifyCostSimDetailView : class, IView
    {
        public  CPRQualifyCostSimDetailsGridView<QualifyCostSimVMEntityView,QualifyCostSimDetailView> GridView {get;set;}
    }
    public partial class CPRQualifyCostSimDetailsGridView <QualifyCostSimVMEntityView,QualifyCostSimDetailView> :  RPSGridView<QualifyCostSimVMEntityView,QualifyCostSimDetailView> where QualifyCostSimVMEntityView : class, IView where QualifyCostSimDetailView : class, IView
    {
        public CPRQualifyCostSimDetailsGridView(QualifyCostSimVMEntityView currentView,QualifyCostSimDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<QualifyCostSimVMEntityView>("","#d6f1556a-0054-4707-8d82-5d24c72f0ff3 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QualifyCostSimVMEntityView>("","#d6f1556a-0054-4707-8d82-5d24c72f0ff3 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<QualifyCostSimVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<QualifyCostSimVMEntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class QualifyCostSimDetailView : View
    {
        public QualifyCostSimDetailView(SimulationQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualifyCostSimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView>( this,Screen.QualifyCostSimVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView>( this,Screen.QualifyCostSimVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView>( this,Screen.QualifyCostSimVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<QualifyCostSimDetailView>("863df27b-70cb-42ae-acd4-c2b3803d2267","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QualifyCostSimDetailView>("c1965685-4bd5-4dd9-9066-86d81a396b8b","","",true, this);
 

        }
        public IRPSButton<QualifyCostSimDetailView> DeleteButton { get; set; } 
        public IRPSButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QualifyCostSimDetailView,QualifyCostSimVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<QualifyCostSimDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<QualifyCostSimDetailView> CostPrice { get; set; } 
        public SimulationQualify Screen { get; set; }
        public QualifyCostSimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SimulationQualifyDialogView : View
    {
        public SimulationQualifyDialogView(SimulationQualify screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Qualify = RPSControlFactory.CreateRPSCollectionComboBox<SimulationQualifyDialogView>("27faa714-2898-4213-a2f7-890173860e7a","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<SimulationQualifyDialogView>("16637c19-82fb-4771-a375-96c28bd936e7","","",false, this);
 
            CostDetailType = RPSControlFactory.CreateRPSCollectionComboBox<SimulationQualifyDialogView>("e14cc708-0fc1-4e4e-9f55-cf9109a841ab","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SimulationQualifyDialogView>("4aa8b817-3a34-40f0-ab79-289081a2e322","","",false, this);
 

        }
        public IRPSCollectionComboBox<SimulationQualifyDialogView> Qualify { get; set; } 
        public IRPSComboBox<SimulationQualifyDialogView> HourType { get; set; } 
        public IRPSCollectionComboBox<SimulationQualifyDialogView> CostDetailType { get; set; } 
        public IRPSTextBox<SimulationQualifyDialogView> Percentage { get; set; } 
        public SimulationQualify Screen { get; set; }
        public SimulationQualifyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
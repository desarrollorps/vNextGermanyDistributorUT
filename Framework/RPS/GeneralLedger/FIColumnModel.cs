    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FIColumnModel
{
    //RPS VERSION 1.0.0.0
    public partial class FIColumnModel:Screen
    {
        public FIColumnModel():base()
        {
            this.URL = "generalledger.ficolumnmodel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FIColumnModelCollectionView  = new FIColumnModelCollectionView(this); 
            FIColumnModelEntityView  = new FIColumnModelEntityView(this); 
            FIColumnDetailView  = new FIColumnDetailView(this); 
            FIColumnModelCollectionView.InitializeControls(); 
            FIColumnModelEntityView.InitializeControls(); 
            FIColumnDetailView.InitializeControls(); 
           
        }
      
            public FIColumnModelCollectionView FIColumnModelCollectionView {get; set; } 
            public FIColumnModelEntityView FIColumnModelEntityView {get; set; } 
            public FIColumnDetailView FIColumnDetailView {get; set; } 
    }
            
    public partial class FIColumnModelCollectionView : View
    {
        public FIColumnModelCollectionView(FIColumnModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FIColumnModelCollectionView,FIColumnModelEntityView>( this,Screen.FIColumnModelEntityView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<FIColumnModelCollectionView>( "b236655d-3692-46bc-83d4-4eecb66a686d","","",this);
 
            LinkNavigationCommandImportButton = RPSControlFactory.CreateRPSButton<FIColumnModelCollectionView>( "f42e942d-1c5f-4bc4-878d-dc3b79b98f52","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "426a07aa-8380-4446-9e28-9e976ef1b6da",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FIColumnModelCollectionView,FIColumnModelEntityView>( params_MainConsult,this,Screen.FIColumnModelEntityView);
 

        }
        public IRPSButton<FIColumnModelCollectionView,FIColumnModelEntityView> NewButton { get; set; } 
        public IRPSButton<FIColumnModelCollectionView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<FIColumnModelCollectionView> LinkNavigationCommandImportButton { get; set; } 
        public IRPSCollectionEditor<FIColumnModelCollectionView,FIColumnModelEntityView> MainConsult { get; set; } 
        public FIColumnModel Screen { get; set; }
        public FIColumnModelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FIColumnModelEntityView : View
    {
        public FIColumnModelEntityView(FIColumnModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FIColumnModelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FIColumnModelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FIColumnModelEntityView,FIColumnModelCollectionView>( this,Screen.FIColumnModelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FIColumnModelEntityView,FIColumnModelCollectionView>( this,Screen.FIColumnModelCollectionView);
 
            CodFIColumnModel = RPSControlFactory.CreateRPSTextBox<FIColumnModelEntityView>("42c5677b-bc8a-40fd-a378-0b001e744e6a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FIColumnModelEntityView>("068de3f7-5499-4198-abae-73dbd1a5c53b","","",false, this);
 
            IDCustomReport = RPSControlFactory.CreateRPSComboBox<FIColumnModelEntityView>("99fcdd81-5a69-4c41-8136-e8cab6d5a84a","","",false, this);
 
            CollectionInit params_FIColumnDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0634a1e6-ba7e-4f8d-b306-fb9e089dfb87",CSSSelectorGrid="",XPathGrid=""};
            FIColumnDetails = RPSControlFactory.RPSCreateCollectionWithGrid<FIColumnDetailsCollectionEditor<FIColumnModelEntityView,FIColumnDetailView>,FIColumnModelEntityView,FIColumnDetailView>( params_FIColumnDetails,this,Screen.FIColumnDetailView);
 

        }
        public IRPSSaveButton<FIColumnModelEntityView> SaveButton { get; set; } 
        public IRPSButton<FIColumnModelEntityView> DeleteButton { get; set; } 
        public IRPSButton<FIColumnModelEntityView,FIColumnModelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FIColumnModelEntityView,FIColumnModelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FIColumnModelEntityView> CodFIColumnModel { get; set; } 
        public IRPSTextBox<FIColumnModelEntityView> Description { get; set; } 
        public IRPSComboBox<FIColumnModelEntityView> IDCustomReport { get; set; } 
        public FIColumnDetailsCollectionEditor<FIColumnModelEntityView,FIColumnDetailView> FIColumnDetails { get; set; } 
        public FIColumnModel Screen { get; set; }
        public FIColumnModelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FIColumnDetailsCollectionEditor<FIColumnModelEntityView,FIColumnDetailView>:RPSCollectionEditor<FIColumnModelEntityView,FIColumnDetailView> where FIColumnModelEntityView : class, IView where FIColumnDetailView : class, IView
    {
        public  FIColumnDetailsGridView<FIColumnModelEntityView,FIColumnDetailView> GridView {get;set;}
    }
    public partial class FIColumnDetailsGridView <FIColumnModelEntityView,FIColumnDetailView> :  RPSGridView<FIColumnModelEntityView,FIColumnDetailView> where FIColumnModelEntityView : class, IView where FIColumnDetailView : class, IView
    {
        public FIColumnDetailsGridView(FIColumnModelEntityView currentView,FIColumnDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodColumn = RPSControlFactory.CreateRPSGridTextBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cCodColumn']","",true, this.CurrentView);
 
            Sequence = RPSControlFactory.CreateRPSGridFormattedTextBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cSequence']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ColumnType = RPSControlFactory.CreateRPSGridEnumComboBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cColumnType']","",false, this.CurrentView);
 
            PeriodType = RPSControlFactory.CreateRPSGridEnumComboBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cPeriodType']","",false, this.CurrentView);
 
            PeriodStep = RPSControlFactory.CreateRPSGridFormattedTextBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cPeriodStep']","",false, this.CurrentView);
 
            Show = RPSControlFactory.CreateRPSGridCheckBox<FIColumnModelEntityView>("","#0634a1e6-ba7e-4f8d-b306-fb9e089dfb87 .ag-row[role='row']@ROWINDEX [col-id='cShow']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIColumnModelEntityView> CodColumn { get; set; } 
        public IRPSGridTextBox<FIColumnModelEntityView> Sequence { get; set; } 
        public IRPSGridTextBox<FIColumnModelEntityView> Description { get; set; } 
        public IRPSGridComboBox<FIColumnModelEntityView> ColumnType { get; set; } 
        public IRPSGridComboBox<FIColumnModelEntityView> PeriodType { get; set; } 
        public IRPSGridTextBox<FIColumnModelEntityView> PeriodStep { get; set; } 
        public IRPSGridCheckbox<FIColumnModelEntityView> Show { get; set; } 
                     
    }
 
    }
  
            
    public partial class FIColumnDetailView : View
    {
        public FIColumnDetailView(FIColumnModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FIColumnDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FIColumnDetailView,FIColumnModelEntityView>( this,Screen.FIColumnModelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FIColumnDetailView,FIColumnModelEntityView>( this,Screen.FIColumnModelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FIColumnDetailView,FIColumnModelEntityView>( this,Screen.FIColumnModelEntityView);
 
            CodColumn = RPSControlFactory.CreateRPSTextBox<FIColumnDetailView>("87aa920a-8bce-416d-9128-88665c86f59f","","",true, this);
 
            Sequence = RPSControlFactory.CreateRPSFormattedTextBox<FIColumnDetailView>("eddc16b1-d5a3-4b20-be27-ed76af8349b2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FIColumnDetailView>("813e06fd-545a-4aec-9ff8-1544ad1d3730","","",false, this);
 
            ColumnType = RPSControlFactory.CreateRPSEnumComboBox<FIColumnDetailView>("18c9a71b-56a1-4b2e-8162-88f152903b9b","","",false, this);
 
            ColumnContent = RPSControlFactory.CreateRPSTextBox<FIColumnDetailView>("884b2e84-04f5-4c17-b555-3ce179c42b1a","","",false, this);
 
            PeriodType = RPSControlFactory.CreateRPSEnumComboBox<FIColumnDetailView>("836564df-14f8-44eb-8dbd-11cfd13a478e","","",false, this);
 
            PeriodStep = RPSControlFactory.CreateRPSFormattedTextBox<FIColumnDetailView>("5e8c8294-c22c-472b-80a7-e945b70b4cfd","","",false, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<FIColumnDetailView>("baa7f194-1e90-4c2f-b45a-dffccc205a7b","","",false, this);
 
            Show = RPSControlFactory.CreateRPSCheckBox<FIColumnDetailView>("65fd686f-58a3-4ba8-8b9b-a1fc5168c8ea","","",false, this);
 
            ChangeSign = RPSControlFactory.CreateRPSCheckBox<FIColumnDetailView>("3d9d27c8-2b2c-43ad-983c-d0628e9e5e9e","","",true, this);
 
            UseWhenSign = RPSControlFactory.CreateRPSEnumComboBox<FIColumnDetailView>("15389c0f-81db-4d35-bd0e-5a52339a5284","","",true, this);
 
            ShowBlankIfZero = RPSControlFactory.CreateRPSCheckBox<FIColumnDetailView>("ccfb2819-f614-4511-b5ad-ed6b102f30ae","","",true, this);
 

        }
        public IRPSButton<FIColumnDetailView> DeleteButton { get; set; } 
        public IRPSButton<FIColumnDetailView,FIColumnModelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FIColumnDetailView,FIColumnModelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FIColumnDetailView,FIColumnModelEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FIColumnDetailView> CodColumn { get; set; } 
        public IRPSTextBox<FIColumnDetailView> Sequence { get; set; } 
        public IRPSTextBox<FIColumnDetailView> Description { get; set; } 
        public IRPSComboBox<FIColumnDetailView> ColumnType { get; set; } 
        public IRPSTextBox<FIColumnDetailView> ColumnContent { get; set; } 
        public IRPSComboBox<FIColumnDetailView> PeriodType { get; set; } 
        public IRPSTextBox<FIColumnDetailView> PeriodStep { get; set; } 
        public IRPSComboBox<FIColumnDetailView> SignType { get; set; } 
        public IRPSCheckbox<FIColumnDetailView> Show { get; set; } 
        public IRPSCheckbox<FIColumnDetailView> ChangeSign { get; set; } 
        public IRPSComboBox<FIColumnDetailView> UseWhenSign { get; set; } 
        public IRPSCheckbox<FIColumnDetailView> ShowBlankIfZero { get; set; } 
        public FIColumnModel Screen { get; set; }
        public FIColumnDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FILineModel
{
    //RPS VERSION 1.0.0.0
    public partial class FILineModel:Screen
    {
        public FILineModel():base()
        {
            this.URL = "generalledger.filinemodel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FILineModelCollectionView  = new FILineModelCollectionView(this); 
            FILineModelEntityView  = new FILineModelEntityView(this); 
            FILineDetailView  = new FILineDetailView(this); 
            FILineModelCollectionView.InitializeControls(); 
            FILineModelEntityView.InitializeControls(); 
            FILineDetailView.InitializeControls(); 
           
        }
      
            public FILineModelCollectionView FILineModelCollectionView {get; set; } 
            public FILineModelEntityView FILineModelEntityView {get; set; } 
            public FILineDetailView FILineDetailView {get; set; } 
    }
            
    public partial class FILineModelCollectionView : View
    {
        public FILineModelCollectionView(FILineModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FILineModelCollectionView,FILineModelEntityView>( this,Screen.FILineModelEntityView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<FILineModelCollectionView>( "455f7253-a687-45eb-8764-31400b215ca5","","",this);
 
            LinkNavigationCommandImportButton = RPSControlFactory.CreateRPSButton<FILineModelCollectionView>( "ac8c1def-1af7-4638-b82f-381e7a183c03","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "366f4be6-52a1-4d42-be08-6ba3c47d78c3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FILineModelCollectionView,FILineModelEntityView>( params_MainConsult,this,Screen.FILineModelEntityView);
 

        }
        public IRPSButton<FILineModelCollectionView,FILineModelEntityView> NewButton { get; set; } 
        public IRPSButton<FILineModelCollectionView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<FILineModelCollectionView> LinkNavigationCommandImportButton { get; set; } 
        public IRPSCollectionEditor<FILineModelCollectionView,FILineModelEntityView> MainConsult { get; set; } 
        public FILineModel Screen { get; set; }
        public FILineModelCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FILineModelEntityView : View
    {
        public FILineModelEntityView(FILineModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FILineModelEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FILineModelEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FILineModelEntityView,FILineModelCollectionView>( this,Screen.FILineModelCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FILineModelEntityView,FILineModelCollectionView>( this,Screen.FILineModelCollectionView);
 
            CodFILineModel = RPSControlFactory.CreateRPSTextBox<FILineModelEntityView>("c1bf7644-36c3-4b34-92e5-9803421f6f8d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FILineModelEntityView>("0132e368-f015-496f-a382-d04f801dd359","","",false, this);
 
            IDFIColumnModel = RPSControlFactory.CreateRPSComboBox<FILineModelEntityView>("32a7e023-e4da-4543-b1da-d95cb5a74765","","",false, this);
 
            ExportLineModelCommandButton = RPSControlFactory.CreateRPSButton<FILineModelEntityView>( "c0b536f0-3e31-4114-abc2-bf052edc07d7","","",this);
 
            CollectionInit params_FILineDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d5c022dd-0780-4429-822c-91b53cacb368",CSSSelectorGrid="",XPathGrid=""};
            FILineDetails = RPSControlFactory.RPSCreateCollectionWithGrid<FILineDetailsCollectionEditor<FILineModelEntityView,FILineDetailView>,FILineModelEntityView,FILineDetailView>( params_FILineDetails,this,Screen.FILineDetailView);
 

        }
        public IRPSSaveButton<FILineModelEntityView> SaveButton { get; set; } 
        public IRPSButton<FILineModelEntityView> DeleteButton { get; set; } 
        public IRPSButton<FILineModelEntityView,FILineModelCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FILineModelEntityView,FILineModelCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FILineModelEntityView> CodFILineModel { get; set; } 
        public IRPSTextBox<FILineModelEntityView> Description { get; set; } 
        public IRPSComboBox<FILineModelEntityView> IDFIColumnModel { get; set; } 
        public IRPSButton<FILineModelEntityView> ExportLineModelCommandButton { get; set; } 
        public FILineDetailsCollectionEditor<FILineModelEntityView,FILineDetailView> FILineDetails { get; set; } 
        public FILineModel Screen { get; set; }
        public FILineModelEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FILineDetailsCollectionEditor<FILineModelEntityView,FILineDetailView>:RPSCollectionEditor<FILineModelEntityView,FILineDetailView> where FILineModelEntityView : class, IView where FILineDetailView : class, IView
    {
        public  FILineDetailsGridView<FILineModelEntityView,FILineDetailView> GridView {get;set;}
    }
    public partial class FILineDetailsGridView <FILineModelEntityView,FILineDetailView> :  RPSGridView<FILineModelEntityView,FILineDetailView> where FILineModelEntityView : class, IView where FILineDetailView : class, IView
    {
        public FILineDetailsGridView(FILineModelEntityView currentView,FILineDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLine = RPSControlFactory.CreateRPSGridTextBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cCodLine']","",true, this.CurrentView);
 
            Sequence = RPSControlFactory.CreateRPSGridFormattedTextBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cSequence']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            LineType = RPSControlFactory.CreateRPSGridEnumComboBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cLineType']","",true, this.CurrentView);
 
            LineContent = RPSControlFactory.CreateRPSGridTextBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cLineContent']","",false, this.CurrentView);
 
            IDFIComplexLine = RPSControlFactory.CreateRPSGridComboBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cIDFIComplexLine']","",false, this.CurrentView);
 
            Show = RPSControlFactory.CreateRPSGridCheckBox<FILineModelEntityView>("","#d5c022dd-0780-4429-822c-91b53cacb368 .ag-row[role='row']@ROWINDEX [col-id='cShow']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FILineModelEntityView> CodLine { get; set; } 
        public IRPSGridTextBox<FILineModelEntityView> Sequence { get; set; } 
        public IRPSGridTextBox<FILineModelEntityView> Description { get; set; } 
        public IRPSGridComboBox<FILineModelEntityView> LineType { get; set; } 
        public IRPSGridTextBox<FILineModelEntityView> LineContent { get; set; } 
        public IRPSGridComboBox<FILineModelEntityView> IDFIComplexLine { get; set; } 
        public IRPSGridCheckbox<FILineModelEntityView> Show { get; set; } 
                     
    }
 
    }
  
            
    public partial class FILineDetailView : View
    {
        public FILineDetailView(FILineModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FILineDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FILineDetailView,FILineModelEntityView>( this,Screen.FILineModelEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FILineDetailView,FILineModelEntityView>( this,Screen.FILineModelEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FILineDetailView,FILineModelEntityView>( this,Screen.FILineModelEntityView);
 
            CodLine = RPSControlFactory.CreateRPSTextBox<FILineDetailView>("0cd35d3f-36fe-4198-a17d-563358e23ab9","","",true, this);
 
            Sequence = RPSControlFactory.CreateRPSFormattedTextBox<FILineDetailView>("14305920-e443-43b9-bee5-49e57d3b3ced","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FILineDetailView>("4b9d1fc9-be99-448a-b0c7-9bf86d1037a1","","",false, this);
 
            LineType = RPSControlFactory.CreateRPSEnumComboBox<FILineDetailView>("82bfa921-a3b0-4db8-adac-795e44faeff2","","",true, this);
 
            LineContent = RPSControlFactory.CreateRPSTextBox<FILineDetailView>("16131520-e951-4d95-8d66-24aad3e22cea","","",false, this);
 
            IDFIComplexLine = RPSControlFactory.CreateRPSComboBox<FILineDetailView>("05f7b0f5-bff1-4c59-8ae1-421b50ea7f87","","",false, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<FILineDetailView>("30550c52-8897-4b75-aef5-a079154f5ead","","",false, this);
 
            Show = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("d5011bfd-d67c-4830-87eb-48f779d5c6b8","","",true, this);
 
            DrillDown = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("a35d5546-4428-4707-aa7d-5a5d47c98b38","","",true, this);
 
            ChangeSign = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("7eedfccb-76c9-44a9-a6e6-0793268fecb7","","",true, this);
 
            UseWhenSign = RPSControlFactory.CreateRPSEnumComboBox<FILineDetailView>("d122732c-80fb-4885-973b-7543c8fbd546","","",true, this);
 
            HideIfZeros = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("1de34a84-4205-494c-9f07-19d6e00315bb","","",true, this);
 
            PageBreak = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("52adb8d5-16c0-4985-a98e-a1b9bae62dc3","","",true, this);
 
            Bold = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("5838cfbc-a944-45b0-8cd8-5868dcf2d795","","",true, this);
 
            Italic = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("bf0c133f-a17c-470e-bdb9-c3d24c90585d","","",true, this);
 
            Underline = RPSControlFactory.CreateRPSCheckBox<FILineDetailView>("c85bbe2a-2697-4a17-bcfd-9c8ed242ad59","","",true, this);
 
            Level = RPSControlFactory.CreateRPSFormattedTextBox<FILineDetailView>("34256fbd-a567-4e06-9558-e4ecf9b5de8c","","",true, this);
 

        }
        public IRPSButton<FILineDetailView> DeleteButton { get; set; } 
        public IRPSButton<FILineDetailView,FILineModelEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FILineDetailView,FILineModelEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FILineDetailView,FILineModelEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FILineDetailView> CodLine { get; set; } 
        public IRPSTextBox<FILineDetailView> Sequence { get; set; } 
        public IRPSTextBox<FILineDetailView> Description { get; set; } 
        public IRPSComboBox<FILineDetailView> LineType { get; set; } 
        public IRPSTextBox<FILineDetailView> LineContent { get; set; } 
        public IRPSComboBox<FILineDetailView> IDFIComplexLine { get; set; } 
        public IRPSComboBox<FILineDetailView> SignType { get; set; } 
        public IRPSCheckbox<FILineDetailView> Show { get; set; } 
        public IRPSCheckbox<FILineDetailView> DrillDown { get; set; } 
        public IRPSCheckbox<FILineDetailView> ChangeSign { get; set; } 
        public IRPSComboBox<FILineDetailView> UseWhenSign { get; set; } 
        public IRPSCheckbox<FILineDetailView> HideIfZeros { get; set; } 
        public IRPSCheckbox<FILineDetailView> PageBreak { get; set; } 
        public IRPSCheckbox<FILineDetailView> Bold { get; set; } 
        public IRPSCheckbox<FILineDetailView> Italic { get; set; } 
        public IRPSCheckbox<FILineDetailView> Underline { get; set; } 
        public IRPSTextBox<FILineDetailView> Level { get; set; } 
        public FILineModel Screen { get; set; }
        public FILineDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
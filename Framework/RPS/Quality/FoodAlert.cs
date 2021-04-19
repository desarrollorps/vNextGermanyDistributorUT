    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FoodAlert
{
    //RPS VERSION 1.0.0.0
    public partial class FoodAlert:Screen
    {
        public FoodAlert():base()
        {
            this.URL = "quality.foodalert";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FoodAlertCollectionView  = new FoodAlertCollectionView(this); 
            FoodAlertEntityView  = new FoodAlertEntityView(this); 
            CreateNewNonConformityDialogView  = new CreateNewNonConformityDialogView(this); 
            FoodAlertCollectionView.InitializeControls(); 
            FoodAlertEntityView.InitializeControls(); 
            CreateNewNonConformityDialogView.InitializeControls(); 
           
        }
      
            public FoodAlertCollectionView FoodAlertCollectionView {get; set; } 
            public FoodAlertEntityView FoodAlertEntityView {get; set; } 
            public CreateNewNonConformityDialogView CreateNewNonConformityDialogView {get; set; } 
    }
            
    public partial class FoodAlertCollectionView : View
    {
        public FoodAlertCollectionView(FoodAlert screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FoodAlertCollectionView,FoodAlertEntityView>( this,Screen.FoodAlertEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e7bb7506-9432-4e2f-97a5-6eec30444f63",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FoodAlertCollectionView,FoodAlertEntityView>( params_MainConsult,this,Screen.FoodAlertEntityView);
 

        }
        public IRPSButton<FoodAlertCollectionView,FoodAlertEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FoodAlertCollectionView,FoodAlertEntityView> MainConsult { get; set; } 
        public FoodAlert Screen { get; set; }
        public FoodAlertCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FoodAlertEntityView : View
    {
        public FoodAlertEntityView(FoodAlert screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FoodAlertEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FoodAlertEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FoodAlertEntityView,FoodAlertCollectionView>( this,Screen.FoodAlertCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FoodAlertEntityView,FoodAlertCollectionView>( this,Screen.FoodAlertCollectionView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<FoodAlertEntityView>("9a0813b7-55a4-421c-8fa2-3205c2fb7f38","","",true, this);
 
            CodFoodAlert = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("a08bc5c7-2b1d-4c04-825d-ca0111786d59","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("fc8d3841-e274-4e8a-a689-7a4464bcc8ce","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FoodAlertEntityView>("160a5bad-fbd7-457f-a779-9a722c5af7bc","","",true, this);
 
            DetectionDate = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("6cc7b17b-586c-4621-94e0-4f6e183533c3","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<FoodAlertEntityView>("56be7a01-96f4-474c-a7b8-ed21fa799a26","","",false, this);
 
            LaunchDate = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("3d27260d-91f9-44d7-a0bc-dccc1c9fed63","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("e75df693-fa0f-4e0e-a2d6-383df3cb00b3","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("42531818-f401-4470-8cac-b846bf8ebedf","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<FoodAlertEntityView>("205623c6-b955-4566-a704-dee2d97c2f07","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<FoodAlertEntityView>( "9ec321f2-c4bb-43b4-908e-9a78260adddd","","",this);
 
            CreateNewNonConformityCommandButton = RPSControlFactory.CreateRPSButtonToView<FoodAlertEntityView,CreateNewNonConformityDialogView>("947c3b5b-8fd7-4570-9fb4-62f195f112ef","","", this,Screen.CreateNewNonConformityDialogView);
 
            CollectionInit params_SeriesAffected = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e7afe293-6efe-4d94-9012-91cd7940f342",CSSSelectorGrid="",XPathGrid=""};
            SeriesAffected = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesAffectedCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView>,FoodAlertEntityView,CreateNewNonConformityDialogView>( params_SeriesAffected,this,Screen.CreateNewNonConformityDialogView);
 
            CollectionInit params_SeriesAffectedDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="61ba8282-9a31-4b44-894f-78d0c4f6e2e3",CSSSelectorGrid="",XPathGrid=""};
            SeriesAffectedDetail = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesAffectedDetailCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView>,FoodAlertEntityView,CreateNewNonConformityDialogView>( params_SeriesAffectedDetail,this,Screen.CreateNewNonConformityDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FoodAlertEntityView>( "","ul li[rpsid='fb6daade-a38a-440a-8879-76379a402e75']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<FoodAlertEntityView>( "","ul li[rpsid='4a4894bf-8f86-44f7-a33f-a858fa6a682d']","",this);
 

        }
        public IRPSSaveButton<FoodAlertEntityView> SaveButton { get; set; } 
        public IRPSButton<FoodAlertEntityView> DeleteButton { get; set; } 
        public IRPSButton<FoodAlertEntityView,FoodAlertCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FoodAlertEntityView,FoodAlertCollectionView> BackButton { get; set; } 
        public IRPSComboBox<FoodAlertEntityView> Type { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> CodFoodAlert { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> Description { get; set; } 
        public IRPSComboBox<FoodAlertEntityView> IDArticle { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> DetectionDate { get; set; } 
        public IRPSComboBox<FoodAlertEntityView> IDEmployee { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> LaunchDate { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> DateFrom { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> DateTo { get; set; } 
        public IRPSTextBox<FoodAlertEntityView> Comments { get; set; } 
        public IRPSButton<FoodAlertEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<FoodAlertEntityView,CreateNewNonConformityDialogView> CreateNewNonConformityCommandButton { get; set; } 
        public SeriesAffectedCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView> SeriesAffected { get; set; } 
        public SeriesAffectedDetailCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView> SeriesAffectedDetail { get; set; } 
        public IRPSSection<FoodAlertEntityView> GeneralData { get; set; } 
        public IRPSSection<FoodAlertEntityView> Comments1 { get; set; } 
        public FoodAlert Screen { get; set; }
        public FoodAlertEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesAffectedCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView>:RPSCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView> where FoodAlertEntityView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public  SeriesAffectedGridView<FoodAlertEntityView,CreateNewNonConformityDialogView> GridView {get;set;}
    }
    public partial class SeriesAffectedGridView <FoodAlertEntityView,CreateNewNonConformityDialogView> :  RPSGridView<FoodAlertEntityView,CreateNewNonConformityDialogView> where FoodAlertEntityView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public SeriesAffectedGridView(FoodAlertEntityView currentView,CreateNewNonConformityDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Affected = RPSControlFactory.CreateRPSGridCheckBox<FoodAlertEntityView>("","#e7afe293-6efe-4d94-9012-91cd7940f342 .ag-row[role='row']@ROWINDEX [col-id='cAffected']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridTextBox<FoodAlertEntityView>("","#e7afe293-6efe-4d94-9012-91cd7940f342 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<FoodAlertEntityView> Affected { get; set; } 
        public IRPSGridTextBox<FoodAlertEntityView> Series { get; set; } 
                     
    }
 
        public partial class SeriesAffectedDetailCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView>:RPSCollectionEditor<FoodAlertEntityView,CreateNewNonConformityDialogView> where FoodAlertEntityView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public  SeriesAffectedDetailGridView<FoodAlertEntityView,CreateNewNonConformityDialogView> GridView {get;set;}
    }
    public partial class SeriesAffectedDetailGridView <FoodAlertEntityView,CreateNewNonConformityDialogView> :  RPSGridView<FoodAlertEntityView,CreateNewNonConformityDialogView> where FoodAlertEntityView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public SeriesAffectedDetailGridView(FoodAlertEntityView currentView,CreateNewNonConformityDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<FoodAlertEntityView>("","#61ba8282-9a31-4b44-894f-78d0c4f6e2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDManufacturingOrder']","",false, this.CurrentView);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSGridComboBox<FoodAlertEntityView>("","#61ba8282-9a31-4b44-894f-78d0c4f6e2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNote']","",false, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<FoodAlertEntityView>("","#61ba8282-9a31-4b44-894f-78d0c4f6e2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FoodAlertEntityView>("","#61ba8282-9a31-4b44-894f-78d0c4f6e2e3 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Observation = RPSControlFactory.CreateRPSGridMemoTextBox<FoodAlertEntityView>("","#61ba8282-9a31-4b44-894f-78d0c4f6e2e3 .ag-row[role='row']@ROWINDEX [col-id='cObservation']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FoodAlertEntityView> IDManufacturingOrder { get; set; } 
        public IRPSGridComboBox<FoodAlertEntityView> IDDeliveryNote { get; set; } 
        public IRPSGridComboBox<FoodAlertEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<FoodAlertEntityView> Date { get; set; } 
        public IRPSGridTextBox<FoodAlertEntityView> Observation { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreateNewNonConformityDialogView : View
    {
        public CreateNewNonConformityDialogView(FoodAlert screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodNonConformity = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("796093d9-59c3-4eea-84c4-f00f9bb92c1d","","",true, this);
 
            CodUserCreatedBy = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("e01ec547-4f73-4948-919c-3f0d4bd5239b","","",false, this);
 
            IDNCSource = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("15e68ec4-1f4a-42d0-8f79-d440715de889","","",true, this);
 
            eSeverity = RPSControlFactory.CreateRPSEnumComboBox<CreateNewNonConformityDialogView>("6d4b41a4-1019-4624-9d5f-081c00093e3d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("f4e00856-793b-4d58-b345-e2b08fd4eaff","","",false, this);
 
            CollectionInit params_FoodAlertSeriess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="97cd1bb3-7545-4ebc-bb51-671447b9cf88",CSSSelectorGrid="",XPathGrid=""};
            FoodAlertSeriess = RPSControlFactory.RPSCreateCollectionWithGrid<FoodAlertSeriessCollectionEditor<CreateNewNonConformityDialogView>,CreateNewNonConformityDialogView>( params_FoodAlertSeriess,this);
 

        }
        public IRPSTextBox<CreateNewNonConformityDialogView> CodNonConformity { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> CodUserCreatedBy { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> IDNCSource { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> eSeverity { get; set; } 
        public IRPSTextBox<CreateNewNonConformityDialogView> Description { get; set; } 
        public FoodAlertSeriessCollectionEditor<CreateNewNonConformityDialogView> FoodAlertSeriess { get; set; } 
        public FoodAlert Screen { get; set; }
        public CreateNewNonConformityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FoodAlertSeriessCollectionEditor<CreateNewNonConformityDialogView>:RPSCollectionEditor<CreateNewNonConformityDialogView> where CreateNewNonConformityDialogView : class, IView
    {
        public  FoodAlertSeriessGridView<CreateNewNonConformityDialogView> GridView {get;set;}
    }
    public partial class FoodAlertSeriessGridView <CreateNewNonConformityDialogView> :  RPSGridView<CreateNewNonConformityDialogView> where CreateNewNonConformityDialogView : class, IView
    {
        public FoodAlertSeriessGridView(CreateNewNonConformityDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<CreateNewNonConformityDialogView>("","#97cd1bb3-7545-4ebc-bb51-671447b9cf88 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",true, this.CurrentView);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<CreateNewNonConformityDialogView>("","#97cd1bb3-7545-4ebc-bb51-671447b9cf88 .ag-row[role='row']@ROWINDEX [col-id='cIDManufacturingOrder']","",false, this.CurrentView);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSGridComboBox<CreateNewNonConformityDialogView>("","#97cd1bb3-7545-4ebc-bb51-671447b9cf88 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewNonConformityDialogView> Series { get; set; } 
        public IRPSGridComboBox<CreateNewNonConformityDialogView> IDManufacturingOrder { get; set; } 
        public IRPSGridComboBox<CreateNewNonConformityDialogView> IDDeliveryNote { get; set; } 
                     
    }
 
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlPatternByUsualTask
{
    //RPS VERSION 1.0.0.0
    public partial class ControlPatternByUsualTask:Screen
    {
        public ControlPatternByUsualTask():base()
        {
            this.URL = "quality.controlpatternbyusualtask";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlPatternByUsualTaskCollectionView  = new ControlPatternByUsualTaskCollectionView(this); 
            ControlPatternByUsualTaskEntityView  = new ControlPatternByUsualTaskEntityView(this); 
            PatternUTaskCharacteristicView  = new PatternUTaskCharacteristicView(this); 
            UTaskCharacteristicByLangView  = new UTaskCharacteristicByLangView(this); 
            CopyControlPatternByUsualTaskDialogView  = new CopyControlPatternByUsualTaskDialogView(this); 
            UpdateControlPatternsDialogView  = new UpdateControlPatternsDialogView(this); 
            UpdateControlSheetsDialogView  = new UpdateControlSheetsDialogView(this); 
            ControlPatternByUsualTaskCollectionView.InitializeControls(); 
            ControlPatternByUsualTaskEntityView.InitializeControls(); 
            PatternUTaskCharacteristicView.InitializeControls(); 
            UTaskCharacteristicByLangView.InitializeControls(); 
            CopyControlPatternByUsualTaskDialogView.InitializeControls(); 
            UpdateControlPatternsDialogView.InitializeControls(); 
            UpdateControlSheetsDialogView.InitializeControls(); 
           
        }
      
            public ControlPatternByUsualTaskCollectionView ControlPatternByUsualTaskCollectionView {get; set; } 
            public ControlPatternByUsualTaskEntityView ControlPatternByUsualTaskEntityView {get; set; } 
            public PatternUTaskCharacteristicView PatternUTaskCharacteristicView {get; set; } 
            public UTaskCharacteristicByLangView UTaskCharacteristicByLangView {get; set; } 
            public CopyControlPatternByUsualTaskDialogView CopyControlPatternByUsualTaskDialogView {get; set; } 
            public UpdateControlPatternsDialogView UpdateControlPatternsDialogView {get; set; } 
            public UpdateControlSheetsDialogView UpdateControlSheetsDialogView {get; set; } 
    }
            
    public partial class ControlPatternByUsualTaskCollectionView : View
    {
        public ControlPatternByUsualTaskCollectionView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlPatternByUsualTaskCollectionView,ControlPatternByUsualTaskEntityView>( this,Screen.ControlPatternByUsualTaskEntityView);
 
            UpdateControlPatternsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByUsualTaskCollectionView,UpdateControlPatternsDialogView>("d803ff34-17b9-4159-a5b3-70bfc9d603ef","","", this,Screen.UpdateControlPatternsDialogView);
 
            UpdateControlSheetsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByUsualTaskCollectionView,UpdateControlSheetsDialogView>("175a060d-e40a-425c-bb3c-6e640acfeae3","","", this,Screen.UpdateControlSheetsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "34751ad7-9e05-4d19-81ab-2488766be9fa",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlPatternByUsualTaskCollectionView,ControlPatternByUsualTaskEntityView>( params_MainConsult,this,Screen.ControlPatternByUsualTaskEntityView);
 

        }
        public IRPSButton<ControlPatternByUsualTaskCollectionView,ControlPatternByUsualTaskEntityView> NewButton { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskCollectionView,UpdateControlPatternsDialogView> UpdateControlPatternsCommandButton { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskCollectionView,UpdateControlSheetsDialogView> UpdateControlSheetsCommandButton { get; set; } 
        public IRPSCollectionEditor<ControlPatternByUsualTaskCollectionView,ControlPatternByUsualTaskEntityView> MainConsult { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public ControlPatternByUsualTaskCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlPatternByUsualTaskEntityView : View
    {
        public ControlPatternByUsualTaskEntityView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlPatternByUsualTaskEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlPatternByUsualTaskEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlPatternByUsualTaskEntityView,ControlPatternByUsualTaskCollectionView>( this,Screen.ControlPatternByUsualTaskCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlPatternByUsualTaskEntityView,ControlPatternByUsualTaskCollectionView>( this,Screen.ControlPatternByUsualTaskCollectionView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ControlPatternByUsualTaskEntityView>("5c47867d-1bee-4ddc-a398-3c101feb834e","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<ControlPatternByUsualTaskEntityView>("439647e2-2b5c-46c7-9e7a-21bfef8d6526","","",false, this);
 
            IDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<ControlPatternByUsualTaskEntityView>("4c9349b4-d1b2-4906-a2a6-215a7c8dbfcb","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ControlPatternByUsualTaskEntityView>("7e7f50c6-7d39-40fd-b308-602786c15635","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ControlPatternByUsualTaskEntityView>("032a4b4f-632c-4e25-8eb0-ef432d2b3379","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ControlPatternByUsualTaskEntityView>("93032f2e-3bd7-417b-8c06-44bff1eb94ac","","",true, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<ControlPatternByUsualTaskEntityView>("afe115f6-c9b8-4b87-92c8-5681adf99bed","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlPatternByUsualTaskEntityView>("b748d09d-accd-4834-965c-aba59212ee40","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ControlPatternByUsualTaskEntityView>("aa7c1c35-4c46-42b4-969a-8789f8c02557","","",false, this);
 
            CopyControlPatternByUsualTaskCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByUsualTaskEntityView,CopyControlPatternByUsualTaskDialogView>("db5d9b1c-8bc3-4717-9824-2ac5e67331a1","","", this,Screen.CopyControlPatternByUsualTaskDialogView);
 
            CollectionInit params_PatternUTaskCharacteristics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="763c7473-8f57-47c5-98c9-78cc911f9832",CSSSelectorGrid="",XPathGrid=""};
            PatternUTaskCharacteristics = RPSControlFactory.RPSCreateCollectionWithGrid<PatternUTaskCharacteristicsCollectionEditor<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView>,ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView>( params_PatternUTaskCharacteristics,this,Screen.PatternUTaskCharacteristicView);
 
            Characteristics = RPSControlFactory.CreateRPSSection<ControlPatternByUsualTaskEntityView>( "","ul li[rpsid='e1c31ad7-b248-441d-b78b-aa4456ab5423']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ControlPatternByUsualTaskEntityView>( "","ul li[rpsid='1a9edb2d-8115-419a-9976-3eb7bef70e9c']","",this);
 

        }
        public IRPSSaveButton<ControlPatternByUsualTaskEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskEntityView,ControlPatternByUsualTaskCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskEntityView,ControlPatternByUsualTaskCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ControlPatternByUsualTaskEntityView> Type { get; set; } 
        public IRPSComboBox<ControlPatternByUsualTaskEntityView> IDUsualTask { get; set; } 
        public IRPSComboBox<ControlPatternByUsualTaskEntityView> IDUsualTaskSTR { get; set; } 
        public IRPSComboBox<ControlPatternByUsualTaskEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ControlPatternByUsualTaskEntityView> Version { get; set; } 
        public IRPSComboBox<ControlPatternByUsualTaskEntityView> CodUser { get; set; } 
        public IRPSTextBox<ControlPatternByUsualTaskEntityView> DoneDate { get; set; } 
        public IRPSTextBox<ControlPatternByUsualTaskEntityView> Description { get; set; } 
        public IRPSTextBox<ControlPatternByUsualTaskEntityView> Comment { get; set; } 
        public IRPSButton<ControlPatternByUsualTaskEntityView,CopyControlPatternByUsualTaskDialogView> CopyControlPatternByUsualTaskCommandButton { get; set; } 
        public PatternUTaskCharacteristicsCollectionEditor<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView> PatternUTaskCharacteristics { get; set; } 
        public IRPSSection<ControlPatternByUsualTaskEntityView> Characteristics { get; set; } 
        public IRPSSection<ControlPatternByUsualTaskEntityView> Comments { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public ControlPatternByUsualTaskEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PatternUTaskCharacteristicsCollectionEditor<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView>:RPSCollectionEditor<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView> where ControlPatternByUsualTaskEntityView : class, IView where PatternUTaskCharacteristicView : class, IView
    {
        public  PatternUTaskCharacteristicsGridView<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView> GridView {get;set;}
    }
    public partial class PatternUTaskCharacteristicsGridView <ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView> :  RPSGridView<ControlPatternByUsualTaskEntityView,PatternUTaskCharacteristicView> where ControlPatternByUsualTaskEntityView : class, IView where PatternUTaskCharacteristicView : class, IView
    {
        public PatternUTaskCharacteristicsGridView(ControlPatternByUsualTaskEntityView currentView,PatternUTaskCharacteristicView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCharacteristic = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cNumCharacteristic']","",true, this.CurrentView);
 
            IDCharacteristic = RPSControlFactory.CreateRPSGridComboBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristic']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSGridComboBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicType']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",true, this.CurrentView);
 
            ViewControlSheet = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cViewControlSheet']","",true, this.CurrentView);
 
            ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cViewCertificate']","",true, this.CurrentView);
 
            ViewControlPlan = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByUsualTaskEntityView>("","#763c7473-8f57-47c5-98c9-78cc911f9832 .ag-row[role='row']@ROWINDEX [col-id='cViewControlPlan']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlPatternByUsualTaskEntityView> NumCharacteristic { get; set; } 
        public IRPSGridComboBox<ControlPatternByUsualTaskEntityView> IDCharacteristic { get; set; } 
        public IRPSGridTextBox<ControlPatternByUsualTaskEntityView> Description { get; set; } 
        public IRPSGridComboBox<ControlPatternByUsualTaskEntityView> IDCharacteristicType { get; set; } 
        public IRPSGridComboBox<ControlPatternByUsualTaskEntityView> ControlType { get; set; } 
        public IRPSGridCheckbox<ControlPatternByUsualTaskEntityView> ViewControlSheet { get; set; } 
        public IRPSGridCheckbox<ControlPatternByUsualTaskEntityView> ViewCertificate { get; set; } 
        public IRPSGridCheckbox<ControlPatternByUsualTaskEntityView> ViewControlPlan { get; set; } 
                     
    }
 
    }
  
            
    public partial class PatternUTaskCharacteristicView : View
    {
        public PatternUTaskCharacteristicView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PatternUTaskCharacteristicView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView>( this,Screen.ControlPatternByUsualTaskEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView>( this,Screen.ControlPatternByUsualTaskEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView>( this,Screen.ControlPatternByUsualTaskEntityView);
 
            NumCharacteristic = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("2883628d-b288-4451-bb34-aa4ae695f92e","","",true, this);
 
            IDCharacteristic = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("fb135272-cb88-47c7-b204-e1e5ccc61c2d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("d1f8e552-a703-42b1-83eb-bb7ab43b505f","","",false, this);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("ceee7045-b018-4f3d-8a37-5986da74ed1b","","",false, this);
 
            IDCharacteristicClass = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("56a37a40-c7a3-4a2b-82e3-ef2fee8602a0","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<PatternUTaskCharacteristicView>("883cb4a4-d911-404b-b3bd-365a5852f039","","",true, this);
 
            Nominal = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("10e5ee95-12cf-43b6-91f4-b1538fc6bcbb","","",true, this);
 
            Min = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("ba0d7276-c95f-4f2e-89cf-215628aa81b8","","",true, this);
 
            Max = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("1d80d160-aaa7-47b8-b89b-97a44c83297c","","",true, this);
 
            InspectBy = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("2ecf085a-5528-47d0-ba39-d32c82cfaf2e","","",false, this);
 
            IDToleranceSpecification = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("1366d9e5-7512-4a6b-b4e3-5d0fa3be42cd","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("2befca93-b1ea-4139-b3e8-4ffde325805b","","",false, this);
 
            IDMeasureTechnique = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("d2e4dfe3-1f89-4cfa-a70f-69554e39613e","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("5d9231c5-02f9-4632-a9e3-b91fd171b374","","",false, this);
 
            IDSampleSize = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("4297606d-2a13-426f-b2ca-f4c1c6cfd43d","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("61ac7e54-ccd4-45ed-baa5-4621b1b7a5cc","","",false, this);
 
            IDSampleFrequency = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("5d3bb283-55bb-4b83-a276-a571de6f2960","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("d5799d42-8809-48b7-989d-89522bbec457","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("eaf9d8b5-25d5-4bc2-983a-944a2b47d42b","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("0f9360ba-77ad-46c0-a694-eef17930a82c","","",false, this);
 
            IDReactionPlan = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("6c19b65d-b5f1-4a27-8a21-22372c3fcc8d","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("d87953cd-1067-44df-af26-f8d0a9e97008","","",false, this);
 
            ViewControlSheet = RPSControlFactory.CreateRPSCheckBox<PatternUTaskCharacteristicView>("2dac8f68-43cc-4c1a-a9fd-40b4c0454803","","",true, this);
 
            ViewCertificate = RPSControlFactory.CreateRPSCheckBox<PatternUTaskCharacteristicView>("96a5950b-0576-448c-992c-c6eb4824d436","","",true, this);
 
            ViewControlPlan = RPSControlFactory.CreateRPSCheckBox<PatternUTaskCharacteristicView>("97ecfd53-ac51-4bcf-ada5-7c3876518cd1","","",true, this);
 
            AQIsRequired = RPSControlFactory.CreateRPSCheckBox<PatternUTaskCharacteristicView>("f15ec510-9aed-4905-9349-9a01e3a418ba","","",true, this);
 
            AQDrawingPosition = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("bbb6331c-db98-4cbf-b05b-d4a693f53492","","",false, this);
 
            AQInspectedBy = RPSControlFactory.CreateRPSEnumComboBox<PatternUTaskCharacteristicView>("a20b7584-e5a4-48f0-9f2d-a354b780f084","","",true, this);
 
            AQIDMeasuringInstrument = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("fa82639d-5f40-4e25-b8f5-7a945b5e4682","","",false, this);
 
            AQSamplesNumber = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("dda1d970-a26d-460b-9465-6b67490f43cf","","",true, this);
 
            AQFrequency = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("dd98762c-38c3-44f4-8c61-12d05a2c3de8","","",true, this);
 
            AQIDFrequencyUnit = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("4c5a1a50-612c-4ddf-8c74-589532d0f63a","","",false, this);
 
            AQIDFrequencyType = RPSControlFactory.CreateRPSComboBox<PatternUTaskCharacteristicView>("86a967d9-a50a-4f26-9ec1-6b7c6d279585","","",false, this);
 
            AQRBase = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("ee8fb27a-1c87-4291-9a4d-06ae6359d85e","","",true, this);
 
            AQIsCountable = RPSControlFactory.CreateRPSCheckBox<PatternUTaskCharacteristicView>("d6821cf4-41a5-4f49-967c-721dd99d065f","","",true, this);
 
            AQControlType = RPSControlFactory.CreateRPSEnumComboBox<PatternUTaskCharacteristicView>("498a69b4-8486-4e05-a218-a53f3ad0ca98","","",true, this);
 
            AQToleranceType = RPSControlFactory.CreateRPSEnumComboBox<PatternUTaskCharacteristicView>("90bcec6e-3835-46a9-a33e-08a6e688dac4","","",true, this);
 
            Nominal1 = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("a12366e1-4098-4fcb-b6cd-78fdbee7ee9d","","",true, this);
 
            Max1 = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("ba8613a9-76f9-414e-8e3d-7381c470bc2c","","",true, this);
 
            Min1 = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("b02ff5ef-0a97-4e58-8711-5912544dec47","","",true, this);
 
            AQLCType = RPSControlFactory.CreateRPSEnumComboBox<PatternUTaskCharacteristicView>("df17473d-b905-442b-8a10-bf098d878b58","","",true, this);
 
            AQLCMS = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("347e3a44-e544-481d-8cab-b7444d924384","","",true, this);
 
            AQLCMI = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("fc2dbb0e-f37b-4d29-90ba-bc3704be4df0","","",true, this);
 
            AQLCRS = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("89742fb9-9839-4082-94c3-60bbcc4a4bcb","","",true, this);
 
            AQLCRI = RPSControlFactory.CreateRPSFormattedTextBox<PatternUTaskCharacteristicView>("aab2c76f-a415-4125-9c99-c2cc3584dbde","","",true, this);
 
            AQMeasureUnit = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("39a6957f-cbcc-4e58-adc3-4732334fbf62","","",false, this);
 
            AQOperatorNotes = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("ad6ee9d6-505a-4b14-8c77-39d37e783993","","",false, this);
 
            AQInspectorNotes = RPSControlFactory.CreateRPSTextBox<PatternUTaskCharacteristicView>("4fa30e85-9bbd-43d8-a4a2-aba40c5d6adb","","",false, this);
 
            CollectionInit params_UTaskCharacteristicByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="036bfab1-6e12-46f1-90cd-2128f7e3b73a",CSSSelectorGrid="",XPathGrid=""};
            UTaskCharacteristicByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<UTaskCharacteristicByLangsCollectionEditor<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView>,PatternUTaskCharacteristicView,UTaskCharacteristicByLangView>( params_UTaskCharacteristicByLangs,this,Screen.UTaskCharacteristicByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PatternUTaskCharacteristicView>( "","ul li[rpsid='d8c080a2-9bc6-44d2-9fa7-6ea202fc59bf']","",this);
 
            CharacteristicsByLang = RPSControlFactory.CreateRPSSection<PatternUTaskCharacteristicView>( "","ul li[rpsid='b083ede0-358c-4d09-91ae-8465540ed63d']","",this);
 
            AutoQ = RPSControlFactory.CreateRPSSection<PatternUTaskCharacteristicView>( "","ul li[rpsid='c2eb6910-b682-4e34-9671-5da4f0fab2ea']","",this);
 

        }
        public IRPSButton<PatternUTaskCharacteristicView> DeleteButton { get; set; } 
        public IRPSButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PatternUTaskCharacteristicView,ControlPatternByUsualTaskEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> NumCharacteristic { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDCharacteristic { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Description { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDCharacteristicType { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDCharacteristicClass { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> ControlType { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Nominal { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Min { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Max { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> InspectBy { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDToleranceSpecification { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> ToleranceSpecification { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDMeasureTechnique { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> MeasureTechnique { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDSampleSize { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> SampleSize { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDSampleFrequency { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> SampleFrecuency { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDControlMethod { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> ControlMethod { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> IDReactionPlan { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> ReactionPlan { get; set; } 
        public IRPSCheckbox<PatternUTaskCharacteristicView> ViewControlSheet { get; set; } 
        public IRPSCheckbox<PatternUTaskCharacteristicView> ViewCertificate { get; set; } 
        public IRPSCheckbox<PatternUTaskCharacteristicView> ViewControlPlan { get; set; } 
        public IRPSCheckbox<PatternUTaskCharacteristicView> AQIsRequired { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQDrawingPosition { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQInspectedBy { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQIDMeasuringInstrument { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQSamplesNumber { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQFrequency { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQIDFrequencyUnit { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQIDFrequencyType { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQRBase { get; set; } 
        public IRPSCheckbox<PatternUTaskCharacteristicView> AQIsCountable { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQControlType { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQToleranceType { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Nominal1 { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Max1 { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> Min1 { get; set; } 
        public IRPSComboBox<PatternUTaskCharacteristicView> AQLCType { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQLCMS { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQLCMI { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQLCRS { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQLCRI { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQMeasureUnit { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQOperatorNotes { get; set; } 
        public IRPSTextBox<PatternUTaskCharacteristicView> AQInspectorNotes { get; set; } 
        public UTaskCharacteristicByLangsCollectionEditor<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView> UTaskCharacteristicByLangs { get; set; } 
        public IRPSSection<PatternUTaskCharacteristicView> GeneralData { get; set; } 
        public IRPSSection<PatternUTaskCharacteristicView> CharacteristicsByLang { get; set; } 
        public IRPSSection<PatternUTaskCharacteristicView> AutoQ { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public PatternUTaskCharacteristicView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UTaskCharacteristicByLangsCollectionEditor<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView>:RPSCollectionEditor<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView> where PatternUTaskCharacteristicView : class, IView where UTaskCharacteristicByLangView : class, IView
    {
        public  UTaskCharacteristicByLangsGridView<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView> GridView {get;set;}
    }
    public partial class UTaskCharacteristicByLangsGridView <PatternUTaskCharacteristicView,UTaskCharacteristicByLangView> :  RPSGridView<PatternUTaskCharacteristicView,UTaskCharacteristicByLangView> where PatternUTaskCharacteristicView : class, IView where UTaskCharacteristicByLangView : class, IView
    {
        public UTaskCharacteristicByLangsGridView(PatternUTaskCharacteristicView currentView,UTaskCharacteristicByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PatternUTaskCharacteristicView>("","#036bfab1-6e12-46f1-90cd-2128f7e3b73a .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PatternUTaskCharacteristicView>("","#036bfab1-6e12-46f1-90cd-2128f7e3b73a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PatternUTaskCharacteristicView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PatternUTaskCharacteristicView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class UTaskCharacteristicByLangView : View
    {
        public UTaskCharacteristicByLangView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<UTaskCharacteristicByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView>( this,Screen.PatternUTaskCharacteristicView);
 
            BackButton = RPSControlFactory.RPSBackButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView>( this,Screen.PatternUTaskCharacteristicView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView>( this,Screen.PatternUTaskCharacteristicView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<UTaskCharacteristicByLangView>("db8120d8-82bb-4056-b816-1d2dd416db7b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("01c8f1e7-fe9a-4a19-8ddc-77738733ecef","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("d3d91c94-7f56-4b20-b654-81d437bd9f1a","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("f906f714-5bdd-44c7-bee7-9c76e76af6a0","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("3632b952-261a-420a-a2b6-630f3b37ca81","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("bd60890d-77e9-46f3-ba17-94910c99ca0d","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("2497662a-4b70-42da-adb0-e3184a071dbe","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<UTaskCharacteristicByLangView>("66aab941-1eff-4435-a948-bebb54bf44d4","","",false, this);
 

        }
        public IRPSButton<UTaskCharacteristicByLangView> DeleteButton { get; set; } 
        public IRPSButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView> BackButton { get; set; } 
        public IRPSAcceptButton<UTaskCharacteristicByLangView,PatternUTaskCharacteristicView> AcceptButton { get; set; } 
        public IRPSComboBox<UTaskCharacteristicByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> Description { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> ToleranceSpecification { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> MeasureTechnique { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> SampleSize { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> SampleFrecuency { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> ControlMethod { get; set; } 
        public IRPSTextBox<UTaskCharacteristicByLangView> ReactionPlan { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public UTaskCharacteristicByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyControlPatternByUsualTaskDialogView : View
    {
        public CopyControlPatternByUsualTaskDialogView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSEnumComboBox<CopyControlPatternByUsualTaskDialogView>("e808b531-4261-443b-90a3-ad2e0ecbd90b","","",true, this);
 
            IDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByUsualTaskDialogView>("520aeaff-2993-486e-8170-d7e097737d99","","",false, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByUsualTaskDialogView>("4bacc1df-5e99-4623-a63c-224916e4ecd8","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByUsualTaskDialogView>("bbfb5baf-ad19-4421-b8c1-de177009779a","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CopyControlPatternByUsualTaskDialogView>("948ad3a9-232a-4224-bd41-830a4eb3a23a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CopyControlPatternByUsualTaskDialogView>("016132dd-caff-4f5e-aaf5-de3d450b1c06","","",false, this);
 

        }
        public IRPSComboBox<CopyControlPatternByUsualTaskDialogView> Type { get; set; } 
        public IRPSComboBox<CopyControlPatternByUsualTaskDialogView> IDUsualTaskSTR { get; set; } 
        public IRPSComboBox<CopyControlPatternByUsualTaskDialogView> IDUsualTask { get; set; } 
        public IRPSComboBox<CopyControlPatternByUsualTaskDialogView> IDArticle { get; set; } 
        public IRPSTextBox<CopyControlPatternByUsualTaskDialogView> Version { get; set; } 
        public IRPSTextBox<CopyControlPatternByUsualTaskDialogView> Description { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public CopyControlPatternByUsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateControlPatternsDialogView : View
    {
        public UpdateControlPatternsDialogView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNew = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "c9e9b90f-5a88-4a5e-b236-d38969b27782","","",this);
 
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<UpdateControlPatternsDialogView>("74184fb1-5de7-4dda-a09d-2c6f368e79d6","","",true, this);
 
            Update = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "a4f87e3b-78d3-4275-aaf6-168a2afd1ded","","",this);
 
            Restore = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "885a7695-b6b4-45c4-8ec2-9885dc4ee553","","",this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlPatternsDialogView>("4ae82a53-2ec1-471e-827e-4398474f5eb4","","",true, this);
 
            IDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("3c7268e6-e5fc-40c1-bad9-c8003ac2ca28","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("2898c19a-2a15-4569-b29e-363404673220","","",false, this);
 
            IDCharacteristicOfControlVersion = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("c3ef7317-99e7-4f3c-9276-facc83b3c80c","","",false, this);
 
            Type1 = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlPatternsDialogView>("e676f3dd-d475-47f3-a60e-14e13e89d6ad","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("12a25faf-718a-4691-93a2-d7e3c2bdac32","","",false, this);
 
            IDArticle1 = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("9b125340-0e59-47f1-a35b-db32a0bd8118","","",false, this);
 
            IDCharacteristicOfControlVersion1 = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("d5bf8536-cfc1-4d2e-a28d-5725a539ab3c","","",false, this);
 

        }
        public IRPSOption<UpdateControlPatternsDialogView> AddNew { get; set; } 
        public IRPSCheckbox<UpdateControlPatternsDialogView> OnlyNotApproved { get; set; } 
        public IRPSOption<UpdateControlPatternsDialogView> Update { get; set; } 
        public IRPSOption<UpdateControlPatternsDialogView> Restore { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> Type { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDUsualTaskSTR { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDArticle { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDCharacteristicOfControlVersion { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> Type1 { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDUsualTask { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDArticle1 { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDCharacteristicOfControlVersion1 { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public UpdateControlPatternsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateControlSheetsDialogView : View
    {
        public UpdateControlSheetsDialogView(ControlPatternByUsualTask screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNew = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "0efe4d01-4505-4ae8-989b-a0522f17d447","","",this);
 
            OnlyWithPendingInspections = RPSControlFactory.CreateRPSCheckBox<UpdateControlSheetsDialogView>("8ac953b3-e92f-44c2-9290-38589a603f3b","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "38a09def-d490-4f98-8f19-afcf99c7ae54","","",this);
 
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<UpdateControlSheetsDialogView>("d1a03f72-3f47-4bbf-8cfa-66ede086ef1c","","",true, this);
 
            Restore = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "bb41b383-4b00-4dff-80a8-b3829b806d5b","","",this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlSheetsDialogView>("b0bc6606-6418-486e-aa62-181ed0639800","","",true, this);
 
            IDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("4703e2ed-d9d4-4ff8-8c6d-763a761e9b56","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("b6610473-0958-4aae-a41d-2690b453d0c8","","",false, this);
 
            IDControlSheetVersion = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("3bfde06d-4ef5-4e41-b322-766c1eefe650","","",false, this);
 
            Type1 = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlSheetsDialogView>("bf83dbd8-9522-4603-b6b5-240ba4bf7c97","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("a07b6af3-68e8-4339-866a-f74b6a9e667a","","",false, this);
 
            IDArticle1 = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("cc91d81a-f366-4bfb-a262-4e31afb98408","","",false, this);
 
            IDControlSheetVersion1 = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("11fb15ca-78b0-4821-86f3-34a9136cb0ea","","",false, this);
 

        }
        public IRPSOption<UpdateControlSheetsDialogView> AddNew { get; set; } 
        public IRPSCheckbox<UpdateControlSheetsDialogView> OnlyWithPendingInspections { get; set; } 
        public IRPSOption<UpdateControlSheetsDialogView> Update { get; set; } 
        public IRPSCheckbox<UpdateControlSheetsDialogView> OnlyNotApproved { get; set; } 
        public IRPSOption<UpdateControlSheetsDialogView> Restore { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> Type { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDUsualTaskSTR { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDArticle { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDControlSheetVersion { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> Type1 { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDUsualTask { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDArticle1 { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDControlSheetVersion1 { get; set; } 
        public ControlPatternByUsualTask Screen { get; set; }
        public UpdateControlSheetsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlPatternByFamily
{
    //RPS VERSION 1.0.0.0
    public partial class ControlPatternByFamily:Screen
    {
        public ControlPatternByFamily():base()
        {
            this.URL = "quality.controlpatternbyfamily";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlPatternByFamilyCollectionView  = new ControlPatternByFamilyCollectionView(this); 
            ControlPatternByFamilyEntityView  = new ControlPatternByFamilyEntityView(this); 
            PatternFamilyCharacteristicView  = new PatternFamilyCharacteristicView(this); 
            FamilyCharacteristicByLangView  = new FamilyCharacteristicByLangView(this); 
            CopyControlPatternByFamilyDialogView  = new CopyControlPatternByFamilyDialogView(this); 
            UpdateControlPatternsDialogView  = new UpdateControlPatternsDialogView(this); 
            UpdateControlSheetsDialogView  = new UpdateControlSheetsDialogView(this); 
            ControlPatternByFamilyCollectionView.InitializeControls(); 
            ControlPatternByFamilyEntityView.InitializeControls(); 
            PatternFamilyCharacteristicView.InitializeControls(); 
            FamilyCharacteristicByLangView.InitializeControls(); 
            CopyControlPatternByFamilyDialogView.InitializeControls(); 
            UpdateControlPatternsDialogView.InitializeControls(); 
            UpdateControlSheetsDialogView.InitializeControls(); 
           
        }
      
            public ControlPatternByFamilyCollectionView ControlPatternByFamilyCollectionView {get; set; } 
            public ControlPatternByFamilyEntityView ControlPatternByFamilyEntityView {get; set; } 
            public PatternFamilyCharacteristicView PatternFamilyCharacteristicView {get; set; } 
            public FamilyCharacteristicByLangView FamilyCharacteristicByLangView {get; set; } 
            public CopyControlPatternByFamilyDialogView CopyControlPatternByFamilyDialogView {get; set; } 
            public UpdateControlPatternsDialogView UpdateControlPatternsDialogView {get; set; } 
            public UpdateControlSheetsDialogView UpdateControlSheetsDialogView {get; set; } 
    }
            
    public partial class ControlPatternByFamilyCollectionView : View
    {
        public ControlPatternByFamilyCollectionView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlPatternByFamilyCollectionView,ControlPatternByFamilyEntityView>( this,Screen.ControlPatternByFamilyEntityView);
 
            UpdateControlPatternsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByFamilyCollectionView,UpdateControlPatternsDialogView>("b2852365-9168-44d6-9294-63dbf7cfa689","","", this,Screen.UpdateControlPatternsDialogView);
 
            UpdateControlSheetsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByFamilyCollectionView,UpdateControlSheetsDialogView>("90f585e2-0c93-4c05-b72d-a2ab79b38a11","","", this,Screen.UpdateControlSheetsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "45c5020e-4589-4db7-82c5-c12c8b3565ca",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlPatternByFamilyCollectionView,ControlPatternByFamilyEntityView>( params_MainConsult,this,Screen.ControlPatternByFamilyEntityView);
 

        }
        public IRPSButton<ControlPatternByFamilyCollectionView,ControlPatternByFamilyEntityView> NewButton { get; set; } 
        public IRPSButton<ControlPatternByFamilyCollectionView,UpdateControlPatternsDialogView> UpdateControlPatternsCommandButton { get; set; } 
        public IRPSButton<ControlPatternByFamilyCollectionView,UpdateControlSheetsDialogView> UpdateControlSheetsCommandButton { get; set; } 
        public IRPSCollectionEditor<ControlPatternByFamilyCollectionView,ControlPatternByFamilyEntityView> MainConsult { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public ControlPatternByFamilyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlPatternByFamilyEntityView : View
    {
        public ControlPatternByFamilyEntityView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlPatternByFamilyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlPatternByFamilyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlPatternByFamilyEntityView,ControlPatternByFamilyCollectionView>( this,Screen.ControlPatternByFamilyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlPatternByFamilyEntityView,ControlPatternByFamilyCollectionView>( this,Screen.ControlPatternByFamilyCollectionView);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ControlPatternByFamilyEntityView>("8753de6d-8474-4d80-a658-9e77824f593f","","",true, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ControlPatternByFamilyEntityView>("bf2d22b5-e427-42e9-a9e7-2d886337ef75","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ControlPatternByFamilyEntityView>("62eceb9d-463b-4782-96fa-74e3f4ff1442","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlPatternByFamilyEntityView>("a56b773f-45d1-4263-a592-b5dbb493171d","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ControlPatternByFamilyEntityView>("ccd83199-b712-4a29-97eb-1a2de4f21bb6","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ControlPatternByFamilyEntityView>("09fe5d64-8317-49f8-88a5-d76af34d025f","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ControlPatternByFamilyEntityView>("2a23306e-05f0-4890-8745-af1635959f90","","",true, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<ControlPatternByFamilyEntityView>("32d645e3-7ad4-4514-8dd8-f9a3eb99ecaf","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ControlPatternByFamilyEntityView>("7d3c9b2e-1c11-48f4-8eb0-976603e0deb7","","",false, this);
 
            CopyControlPatternByFamilyCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPatternByFamilyEntityView,CopyControlPatternByFamilyDialogView>("af15bd11-154b-4168-be4a-b8734bbecf78","","", this,Screen.CopyControlPatternByFamilyDialogView);
 
            CollectionInit params_PatternFamilyCharacteristics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="98851695-ee21-40f7-b9da-139dc6c0b5cd",CSSSelectorGrid="",XPathGrid=""};
            PatternFamilyCharacteristics = RPSControlFactory.RPSCreateCollectionWithGrid<PatternFamilyCharacteristicsCollectionEditor<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView>,ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView>( params_PatternFamilyCharacteristics,this,Screen.PatternFamilyCharacteristicView);
 
            Characteristics = RPSControlFactory.CreateRPSSection<ControlPatternByFamilyEntityView>( "","ul li[rpsid='1364a1ce-a0bb-435d-bae5-3a6ecc08faf6']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ControlPatternByFamilyEntityView>( "","ul li[rpsid='80cecf0c-db35-4352-9b28-10fd83dc0771']","",this);
 

        }
        public IRPSSaveButton<ControlPatternByFamilyEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlPatternByFamilyEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlPatternByFamilyEntityView,ControlPatternByFamilyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlPatternByFamilyEntityView,ControlPatternByFamilyCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ControlPatternByFamilyEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ControlPatternByFamilyEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ControlPatternByFamilyEntityView> IDProductSubFamily { get; set; } 
        public IRPSTextBox<ControlPatternByFamilyEntityView> Description { get; set; } 
        public IRPSComboBox<ControlPatternByFamilyEntityView> Type { get; set; } 
        public IRPSTextBox<ControlPatternByFamilyEntityView> Version { get; set; } 
        public IRPSComboBox<ControlPatternByFamilyEntityView> CodUser { get; set; } 
        public IRPSTextBox<ControlPatternByFamilyEntityView> DoneDate { get; set; } 
        public IRPSTextBox<ControlPatternByFamilyEntityView> Comment { get; set; } 
        public IRPSButton<ControlPatternByFamilyEntityView,CopyControlPatternByFamilyDialogView> CopyControlPatternByFamilyCommandButton { get; set; } 
        public PatternFamilyCharacteristicsCollectionEditor<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView> PatternFamilyCharacteristics { get; set; } 
        public IRPSSection<ControlPatternByFamilyEntityView> Characteristics { get; set; } 
        public IRPSSection<ControlPatternByFamilyEntityView> Comments { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public ControlPatternByFamilyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PatternFamilyCharacteristicsCollectionEditor<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView>:RPSCollectionEditor<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView> where ControlPatternByFamilyEntityView : class, IView where PatternFamilyCharacteristicView : class, IView
    {
        public  PatternFamilyCharacteristicsGridView<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView> GridView {get;set;}
    }
    public partial class PatternFamilyCharacteristicsGridView <ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView> :  RPSGridView<ControlPatternByFamilyEntityView,PatternFamilyCharacteristicView> where ControlPatternByFamilyEntityView : class, IView where PatternFamilyCharacteristicView : class, IView
    {
        public PatternFamilyCharacteristicsGridView(ControlPatternByFamilyEntityView currentView,PatternFamilyCharacteristicView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCharacteristic = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cNumCharacteristic']","",true, this.CurrentView);
 
            IDCharacteristic = RPSControlFactory.CreateRPSGridComboBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristic']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSGridComboBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicType']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",true, this.CurrentView);
 
            ViewControlSheet = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cViewControlSheet']","",true, this.CurrentView);
 
            ViewControlPlan = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cViewControlPlan']","",true, this.CurrentView);
 
            ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<ControlPatternByFamilyEntityView>("","#98851695-ee21-40f7-b9da-139dc6c0b5cd .ag-row[role='row']@ROWINDEX [col-id='cViewCertificate']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlPatternByFamilyEntityView> NumCharacteristic { get; set; } 
        public IRPSGridComboBox<ControlPatternByFamilyEntityView> IDCharacteristic { get; set; } 
        public IRPSGridTextBox<ControlPatternByFamilyEntityView> Description { get; set; } 
        public IRPSGridComboBox<ControlPatternByFamilyEntityView> IDCharacteristicType { get; set; } 
        public IRPSGridComboBox<ControlPatternByFamilyEntityView> ControlType { get; set; } 
        public IRPSGridCheckbox<ControlPatternByFamilyEntityView> ViewControlSheet { get; set; } 
        public IRPSGridCheckbox<ControlPatternByFamilyEntityView> ViewControlPlan { get; set; } 
        public IRPSGridCheckbox<ControlPatternByFamilyEntityView> ViewCertificate { get; set; } 
                     
    }
 
    }
  
            
    public partial class PatternFamilyCharacteristicView : View
    {
        public PatternFamilyCharacteristicView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PatternFamilyCharacteristicView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView>( this,Screen.ControlPatternByFamilyEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView>( this,Screen.ControlPatternByFamilyEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView>( this,Screen.ControlPatternByFamilyEntityView);
 
            NumCharacteristic = RPSControlFactory.CreateRPSFormattedTextBox<PatternFamilyCharacteristicView>("386dac7a-68ff-4005-b532-5f39824ac742","","",true, this);
 
            IDCharacteristic = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("3b7f444c-d706-42a8-ab1b-ea30f6a5be0b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("1d977fd3-1d16-4b74-a802-5681eff90016","","",false, this);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("4d25ec07-d965-41bf-8f6d-98a1bf3fc308","","",false, this);
 
            IDCharacteristicClass = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("ac1c2f5f-d981-4e03-939b-ebf026247a33","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<PatternFamilyCharacteristicView>("e88a2baf-b841-4ef5-8ad8-4f402f302021","","",true, this);
 
            Nominal = RPSControlFactory.CreateRPSFormattedTextBox<PatternFamilyCharacteristicView>("8237b512-bb50-4e89-8d1d-2d9dea507750","","",true, this);
 
            Min = RPSControlFactory.CreateRPSFormattedTextBox<PatternFamilyCharacteristicView>("e8407c71-4230-4e76-9fbf-272aef1b1443","","",true, this);
 
            Max = RPSControlFactory.CreateRPSFormattedTextBox<PatternFamilyCharacteristicView>("1156006c-e0a0-421d-842e-344903a98210","","",true, this);
 
            InspectBy = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("d0b99dca-134d-406e-867a-5252529b49a6","","",false, this);
 
            IDToleranceSpecification = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("dd0b2e0e-ea7f-496b-b40e-a5844922ccb1","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("b596b8c6-95bf-44a0-85e8-17dc35f442e9","","",false, this);
 
            IDMeasureTechnique = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("b54fba4d-1a58-472d-b132-40c7bca08bc0","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("a2e5693d-e92d-40f6-aa63-aa4571e23a74","","",false, this);
 
            IDSampleSize = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("39356365-2f70-48c4-9265-9a59a038b3e5","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("2ac210de-b406-4671-a285-be45bf92feb6","","",false, this);
 
            IDSampleFrequency = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("501b0673-3ace-4152-aaa3-9460549a39bc","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("673ebfa5-8c48-42f7-b062-f376ccb07f75","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("6f1791e8-5e15-4f9e-b903-992f1668a355","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("d6daaa4b-ef49-4f2a-a616-e1e2460abdfb","","",false, this);
 
            IDReactionPlan = RPSControlFactory.CreateRPSComboBox<PatternFamilyCharacteristicView>("ae808f10-7850-4b83-bf28-50471b02f665","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<PatternFamilyCharacteristicView>("5f9339f2-b27c-40f7-b6dd-4f5dade6012b","","",false, this);
 
            ViewControlSheet = RPSControlFactory.CreateRPSCheckBox<PatternFamilyCharacteristicView>("d66f7953-cc80-40cf-a8f6-f916a63fdd8b","","",true, this);
 
            ViewControlPlan = RPSControlFactory.CreateRPSCheckBox<PatternFamilyCharacteristicView>("fd119620-c19e-4f03-86e0-c482de2d89ed","","",true, this);
 
            ViewCertificate = RPSControlFactory.CreateRPSCheckBox<PatternFamilyCharacteristicView>("e1efe172-0c9f-42de-bea7-568a1fcc19b2","","",true, this);
 
            CollectionInit params_FamilyCharacteristicByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6dba8545-344e-4174-802f-e2b83e121db0",CSSSelectorGrid="",XPathGrid=""};
            FamilyCharacteristicByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FamilyCharacteristicByLangsCollectionEditor<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView>,PatternFamilyCharacteristicView,FamilyCharacteristicByLangView>( params_FamilyCharacteristicByLangs,this,Screen.FamilyCharacteristicByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PatternFamilyCharacteristicView>( "","ul li[rpsid='075a63e3-edfe-4d62-9400-bffa6df19b4d']","",this);
 
            CharacteristicsByLang = RPSControlFactory.CreateRPSSection<PatternFamilyCharacteristicView>( "","ul li[rpsid='b1ff522a-8f51-4dbe-8f45-063c78bbfa63']","",this);
 

        }
        public IRPSButton<PatternFamilyCharacteristicView> DeleteButton { get; set; } 
        public IRPSButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PatternFamilyCharacteristicView,ControlPatternByFamilyEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> NumCharacteristic { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDCharacteristic { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> Description { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDCharacteristicType { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDCharacteristicClass { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> ControlType { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> Nominal { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> Min { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> Max { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> InspectBy { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDToleranceSpecification { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> ToleranceSpecification { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDMeasureTechnique { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> MeasureTechnique { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDSampleSize { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> SampleSize { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDSampleFrequency { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> SampleFrecuency { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDControlMethod { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> ControlMethod { get; set; } 
        public IRPSComboBox<PatternFamilyCharacteristicView> IDReactionPlan { get; set; } 
        public IRPSTextBox<PatternFamilyCharacteristicView> ReactionPlan { get; set; } 
        public IRPSCheckbox<PatternFamilyCharacteristicView> ViewControlSheet { get; set; } 
        public IRPSCheckbox<PatternFamilyCharacteristicView> ViewControlPlan { get; set; } 
        public IRPSCheckbox<PatternFamilyCharacteristicView> ViewCertificate { get; set; } 
        public FamilyCharacteristicByLangsCollectionEditor<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView> FamilyCharacteristicByLangs { get; set; } 
        public IRPSSection<PatternFamilyCharacteristicView> GeneralData { get; set; } 
        public IRPSSection<PatternFamilyCharacteristicView> CharacteristicsByLang { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public PatternFamilyCharacteristicView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FamilyCharacteristicByLangsCollectionEditor<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView>:RPSCollectionEditor<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView> where PatternFamilyCharacteristicView : class, IView where FamilyCharacteristicByLangView : class, IView
    {
        public  FamilyCharacteristicByLangsGridView<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView> GridView {get;set;}
    }
    public partial class FamilyCharacteristicByLangsGridView <PatternFamilyCharacteristicView,FamilyCharacteristicByLangView> :  RPSGridView<PatternFamilyCharacteristicView,FamilyCharacteristicByLangView> where PatternFamilyCharacteristicView : class, IView where FamilyCharacteristicByLangView : class, IView
    {
        public FamilyCharacteristicByLangsGridView(PatternFamilyCharacteristicView currentView,FamilyCharacteristicByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<PatternFamilyCharacteristicView>("","#6dba8545-344e-4174-802f-e2b83e121db0 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PatternFamilyCharacteristicView>("","#6dba8545-344e-4174-802f-e2b83e121db0 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PatternFamilyCharacteristicView> CodLanguage { get; set; } 
        public IRPSGridTextBox<PatternFamilyCharacteristicView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class FamilyCharacteristicByLangView : View
    {
        public FamilyCharacteristicByLangView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FamilyCharacteristicByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView>( this,Screen.PatternFamilyCharacteristicView);
 
            BackButton = RPSControlFactory.RPSBackButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView>( this,Screen.PatternFamilyCharacteristicView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView>( this,Screen.PatternFamilyCharacteristicView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FamilyCharacteristicByLangView>("83eedc52-ce0a-46c5-889a-6a6e636b03d9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("e25985dc-9def-43e2-bf6e-99fab39d1856","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("be82b3cf-e82e-4801-92bf-9a74b22a7a2a","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("5367615f-51f8-4377-b3d5-e016a947c0c5","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("f7b67d60-d6aa-4816-b1bd-66037703de51","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("37398ce3-2105-44b0-844f-fe16b7cf4be8","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("b4aa22d0-a1d2-4109-82f6-7c2517cbfb99","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<FamilyCharacteristicByLangView>("f84acc10-c50b-47f9-9281-7710923ca662","","",false, this);
 

        }
        public IRPSButton<FamilyCharacteristicByLangView> DeleteButton { get; set; } 
        public IRPSButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView> BackButton { get; set; } 
        public IRPSAcceptButton<FamilyCharacteristicByLangView,PatternFamilyCharacteristicView> AcceptButton { get; set; } 
        public IRPSComboBox<FamilyCharacteristicByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> Description { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> ToleranceSpecification { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> MeasureTechnique { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> SampleSize { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> SampleFrecuency { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> ControlMethod { get; set; } 
        public IRPSTextBox<FamilyCharacteristicByLangView> ReactionPlan { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public FamilyCharacteristicByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyControlPatternByFamilyDialogView : View
    {
        public CopyControlPatternByFamilyDialogView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByFamilyDialogView>("cd929f4f-6ad6-4086-b4f1-87e4fab9abe3","","",true, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByFamilyDialogView>("83439cc0-451d-42a4-ab3f-1c376a3c6ab9","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CopyControlPatternByFamilyDialogView>("d03e546f-8a73-441b-8d30-547129078133","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CopyControlPatternByFamilyDialogView>("eb5c6012-9912-4a4b-987b-c0217687d189","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CopyControlPatternByFamilyDialogView>("d753bd3e-bc74-49bb-99b1-7c004adaba01","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CopyControlPatternByFamilyDialogView>("7a442198-5afe-4d9b-b25e-a32f630e56b8","","",true, this);
 

        }
        public IRPSComboBox<CopyControlPatternByFamilyDialogView> IDProductLine { get; set; } 
        public IRPSComboBox<CopyControlPatternByFamilyDialogView> IDProductFamily { get; set; } 
        public IRPSComboBox<CopyControlPatternByFamilyDialogView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<CopyControlPatternByFamilyDialogView> Type { get; set; } 
        public IRPSTextBox<CopyControlPatternByFamilyDialogView> Description { get; set; } 
        public IRPSTextBox<CopyControlPatternByFamilyDialogView> Version { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public CopyControlPatternByFamilyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateControlPatternsDialogView : View
    {
        public UpdateControlPatternsDialogView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNew = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "c9e9b90f-5a88-4a5e-b236-d38969b27782","","",this);
 
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<UpdateControlPatternsDialogView>("74184fb1-5de7-4dda-a09d-2c6f368e79d6","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "a4f87e3b-78d3-4275-aaf6-168a2afd1ded","","",this);
 
            Restore = RPSControlFactory.CreateRPSOption<UpdateControlPatternsDialogView>( "885a7695-b6b4-45c4-8ec2-9885dc4ee553","","",this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("7aa13bb5-cd6c-4791-ae7e-b753954a23fb","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("c50dfe1b-6ae4-420e-b6ad-4d8980e7d1bd","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("bd4c5baa-5310-4b5b-ad7b-4c55c70b2bf7","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("1b2daeb8-d54b-4389-98f2-7821e813ba89","","",false, this);
 
            PatternType = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlPatternsDialogView>("cc9ab528-4874-4918-ad09-d48b268eebec","","",true, this);
 
            IDCharacteristicOfControlVersion = RPSControlFactory.CreateRPSComboBox<UpdateControlPatternsDialogView>("32c957a5-f360-485a-bff4-08decf5e2a0c","","",false, this);
 

        }
        public IRPSOption<UpdateControlPatternsDialogView> AddNew { get; set; } 
        public IRPSCheckbox<UpdateControlPatternsDialogView> OnlyNotApproved { get; set; } 
        public IRPSOption<UpdateControlPatternsDialogView> Update { get; set; } 
        public IRPSOption<UpdateControlPatternsDialogView> Restore { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDProductLine { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDProductFamily { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDArticle { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> PatternType { get; set; } 
        public IRPSComboBox<UpdateControlPatternsDialogView> IDCharacteristicOfControlVersion { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public UpdateControlPatternsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateControlSheetsDialogView : View
    {
        public UpdateControlSheetsDialogView(ControlPatternByFamily screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNew = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "c80e397e-ac58-44e5-b9f1-a77106486744","","",this);
 
            OnlyWithPendingInspections = RPSControlFactory.CreateRPSCheckBox<UpdateControlSheetsDialogView>("8ac953b3-e92f-44c2-9290-38589a603f3b","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "e387d318-fd07-41b8-bd2b-a8e16841f900","","",this);
 
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<UpdateControlSheetsDialogView>("d1a03f72-3f47-4bbf-8cfa-66ede086ef1c","","",false, this);
 
            Restore = RPSControlFactory.CreateRPSOption<UpdateControlSheetsDialogView>( "601c84df-21a6-4c56-9dfc-6adc06dcfe38","","",this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("2e9b7d58-f346-4695-b380-0eb5de546a38","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("06ca49c4-f8d6-4a8f-9978-3c4486b9e9de","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("078a333b-6d0f-4717-8c44-ff9995ce08cf","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("580a813e-bf29-4c78-9510-bde368c9784d","","",false, this);
 
            PatternType = RPSControlFactory.CreateRPSEnumComboBox<UpdateControlSheetsDialogView>("fbaf0157-317f-47c7-aa39-98a278bc76ce","","",false, this);
 
            IDControlSheetVersion = RPSControlFactory.CreateRPSComboBox<UpdateControlSheetsDialogView>("171c8cc5-44f4-4265-86a5-65918da99bbc","","",false, this);
 

        }
        public IRPSOption<UpdateControlSheetsDialogView> AddNew { get; set; } 
        public IRPSCheckbox<UpdateControlSheetsDialogView> OnlyWithPendingInspections { get; set; } 
        public IRPSOption<UpdateControlSheetsDialogView> Update { get; set; } 
        public IRPSCheckbox<UpdateControlSheetsDialogView> OnlyNotApproved { get; set; } 
        public IRPSOption<UpdateControlSheetsDialogView> Restore { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDProductLine { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDProductFamily { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDArticle { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> PatternType { get; set; } 
        public IRPSComboBox<UpdateControlSheetsDialogView> IDControlSheetVersion { get; set; } 
        public ControlPatternByFamily Screen { get; set; }
        public UpdateControlSheetsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
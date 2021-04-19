    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectIndicator
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectIndicator:Screen
    {
        public ProjectIndicator():base()
        {
            this.URL = "project.projectindicator";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectIndicatorCollectionView  = new ProjectIndicatorCollectionView(this); 
            ProjectIndicatorEntityView  = new ProjectIndicatorEntityView(this); 
            IndicatorFormulasDialogView  = new IndicatorFormulasDialogView(this); 
            EditLimitsDialogView  = new EditLimitsDialogView(this); 
            ProjectIndicatorCalculateDialogView  = new ProjectIndicatorCalculateDialogView(this); 
            AllIndicatorsCalculateDialogView  = new AllIndicatorsCalculateDialogView(this); 
            ImportToXMLDialogView  = new ImportToXMLDialogView(this); 
            ExportToXMLDialogView  = new ExportToXMLDialogView(this); 
            ProjectIndicatorCollectionView.InitializeControls(); 
            ProjectIndicatorEntityView.InitializeControls(); 
            IndicatorFormulasDialogView.InitializeControls(); 
            EditLimitsDialogView.InitializeControls(); 
            ProjectIndicatorCalculateDialogView.InitializeControls(); 
            AllIndicatorsCalculateDialogView.InitializeControls(); 
            ImportToXMLDialogView.InitializeControls(); 
            ExportToXMLDialogView.InitializeControls(); 
           
        }
      
            public ProjectIndicatorCollectionView ProjectIndicatorCollectionView {get; set; } 
            public ProjectIndicatorEntityView ProjectIndicatorEntityView {get; set; } 
            public IndicatorFormulasDialogView IndicatorFormulasDialogView {get; set; } 
            public EditLimitsDialogView EditLimitsDialogView {get; set; } 
            public ProjectIndicatorCalculateDialogView ProjectIndicatorCalculateDialogView {get; set; } 
            public AllIndicatorsCalculateDialogView AllIndicatorsCalculateDialogView {get; set; } 
            public ImportToXMLDialogView ImportToXMLDialogView {get; set; } 
            public ExportToXMLDialogView ExportToXMLDialogView {get; set; } 
    }
            
    public partial class ProjectIndicatorCollectionView : View
    {
        public ProjectIndicatorCollectionView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProjectIndicatorCollectionView,ProjectIndicatorEntityView>( this,Screen.ProjectIndicatorEntityView);
 
            ExportToXMLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorCollectionView,ExportToXMLDialogView>("9c727358-ed10-4630-bb59-e6d0abb17817","","", this,Screen.ExportToXMLDialogView);
 
            ImportToXMLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorCollectionView,ImportToXMLDialogView>("d3a22eb1-ac5f-44c8-94f2-ea3961de7ce4","","", this,Screen.ImportToXMLDialogView);
 
            AllIndicatorsCalculateCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorCollectionView,AllIndicatorsCalculateDialogView>("24cd9778-6886-48e5-8d72-b7dd67e89610","","", this,Screen.AllIndicatorsCalculateDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "79655ae8-4747-4693-a9fd-9b09d64b407a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProjectIndicatorCollectionView,ProjectIndicatorEntityView>( params_MainConsult,this,Screen.ProjectIndicatorEntityView);
 

        }
        public IRPSButton<ProjectIndicatorCollectionView,ProjectIndicatorEntityView> NewButton { get; set; } 
        public IRPSButton<ProjectIndicatorCollectionView,ExportToXMLDialogView> ExportToXMLNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectIndicatorCollectionView,ImportToXMLDialogView> ImportToXMLNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectIndicatorCollectionView,AllIndicatorsCalculateDialogView> AllIndicatorsCalculateCommandButton { get; set; } 
        public IRPSCollectionEditor<ProjectIndicatorCollectionView,ProjectIndicatorEntityView> MainConsult { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public ProjectIndicatorCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectIndicatorEntityView : View
    {
        public ProjectIndicatorEntityView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectIndicatorEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectIndicatorEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectIndicatorEntityView,ProjectIndicatorCollectionView>( this,Screen.ProjectIndicatorCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectIndicatorEntityView,ProjectIndicatorCollectionView>( this,Screen.ProjectIndicatorCollectionView);
 
            CodIndicator = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("db546606-751c-4f07-a415-6463a69f5692","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("008bff5d-256c-466e-8de1-24a75fee1c0a","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("b922bc3d-efa1-4ce4-8911-e64a40524f60","","",true, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorEntityView>("c69f02d3-74ec-45bb-935d-78f417c214a1","","",true, this);
 
            ValueType = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("cc44f4f6-0277-4b89-bc2a-f299a62fdffe","","",true, this);
 
            IDMeasureUnit = RPSControlFactory.CreateRPSComboBox<ProjectIndicatorEntityView>("7c0dfdaf-b22b-490d-9fae-4f96806e7156","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("c32f4aa5-68cc-4d81-8414-6ae858496b0b","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("9f4e9a6f-a5b8-4648-a43e-f597476fcbf1","","",true, this);
 
            LastCalculationDate = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("4446945c-6eec-48f1-8e42-b8b85c7e0e2c","","",false, this);
 
            ApplyTo = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("06c7c1c2-efc7-407b-8a89-9328ea6da95a","","",true, this);
 
            Operation = RPSControlFactory.CreateRPSEnumComboBox<ProjectIndicatorEntityView>("110260bf-8b47-407d-adfc-d0b21c292974","","",true, this);
 
            EditFormulaCommand = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorEntityView,IndicatorFormulasDialogView>("fc43d0c9-82b7-4c3e-8fd0-1fe3bfc887fa","","", this,Screen.IndicatorFormulasDialogView);
 
            Formula = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("63a85ed4-03aa-46ac-aef7-f2a594db59e7","","",false, this);
 
            EditUpperLimit = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorEntityView,EditLimitsDialogView>("a993d8b0-a367-455f-a21a-9b51d34ad53c","","", this,Screen.EditLimitsDialogView);
 
            UpperLimit = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("fe06c616-b713-4231-a607-24d47ceaef0a","","",false, this);
 
            EditMediumLimit = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorEntityView,EditLimitsDialogView>("36415cd5-b28d-48b6-8c29-158cafbc4597","","", this,Screen.EditLimitsDialogView);
 
            MediumLimit = RPSControlFactory.CreateRPSTextBox<ProjectIndicatorEntityView>("e697731b-8d7a-4c79-b2cf-adfd6703aacc","","",false, this);
 
            ProjectIndicatorCalculateCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorEntityView,ProjectIndicatorCalculateDialogView>("8f0b96e0-cd39-408e-b2d1-8356917e135b","","", this,Screen.ProjectIndicatorCalculateDialogView);
 

        }
        public IRPSSaveButton<ProjectIndicatorEntityView> SaveButton { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,ProjectIndicatorCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,ProjectIndicatorCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> CodIndicator { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> Description { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> Type { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> Order { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> ValueType { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> IDMeasureUnit { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> Priority { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> Status { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> LastCalculationDate { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> ApplyTo { get; set; } 
        public IRPSComboBox<ProjectIndicatorEntityView> Operation { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,IndicatorFormulasDialogView> EditFormulaCommand { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> Formula { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,EditLimitsDialogView> EditUpperLimit { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> UpperLimit { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,EditLimitsDialogView> EditMediumLimit { get; set; } 
        public IRPSTextBox<ProjectIndicatorEntityView> MediumLimit { get; set; } 
        public IRPSButton<ProjectIndicatorEntityView,ProjectIndicatorCalculateDialogView> ProjectIndicatorCalculateCommandButton { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public ProjectIndicatorEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IndicatorFormulasDialogView : View
    {
        public IndicatorFormulasDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<IndicatorFormulasDialogView>("08f844b9-84ef-47f5-905f-c4382d651cf6","","",false, this);
 
            Property = RPSControlFactory.CreateRPSEnumComboBox<IndicatorFormulasDialogView>("fae4248c-08a8-4ed7-aa1c-6c557a2fe6e7","","",true, this);
 
            AddProperty = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "89ff55bf-8bc7-40d6-8b2c-d2a5031eb80e","","",this);
 
            Entity1 = RPSControlFactory.CreateRPSEnumComboBox<IndicatorFormulasDialogView>("9ddb7de6-44d7-44ee-8ff4-c6598acf4eb8","","",false, this);
 
            FeatureLabel = RPSControlFactory.CreateRPSEnumComboBox<IndicatorFormulasDialogView>("2fe719d6-dda4-4f5e-ae2a-7716056893c0","","",false, this);
 
            AddProperty1 = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "52f29563-08c1-4e0d-90ca-15eecf01c9a9","","",this);
 
            Constant = RPSControlFactory.CreateRPSEnumComboBox<IndicatorFormulasDialogView>("29111fa4-8f7d-42da-abe7-774446fcb441","","",false, this);
 
            AddConstant = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "9ca70aac-a933-42eb-a5f1-77abab78ab39","","",this);
 
            LeftParenthesisCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "6512eda1-aeb0-47cc-8c0c-a100b166da2f","","",this);
 
            RightParenthesisCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "89058830-663d-49da-b82f-465b0a157dba","","",this);
 
            EqualsCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "82c61b48-81cc-410c-9bfa-85b56219416c","","",this);
 
            LessCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "a30a7c3d-1f75-40a1-be8c-469889136906","","",this);
 
            LessThanOrEqualCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "1922a7e1-4251-41a5-a116-6120a8c49458","","",this);
 
            GreaterCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "a421b20e-2b7a-46a0-8845-153eca24e6d1","","",this);
 
            GreaterThanOrEqualCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "6e238c51-faa1-4a78-8a51-7c5b33db04a3","","",this);
 
            DifferentCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "7c317f42-0a46-4e6c-a66c-3a50591220ce","","",this);
 
            AndCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "9b3fd1e8-61c7-4ae2-833f-f1c1df715ef1","","",this);
 
            OrCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "a84120de-c962-44d4-89ec-0fd20dfad479","","",this);
 
            PlusCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "026d2618-a137-4a52-80c7-257fe6cdb656","","",this);
 
            MinusCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "2ca490c2-b0d7-48b6-ade1-f54bc1af75b0","","",this);
 
            TimesCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "23ad3372-a077-4543-b0ca-31d43608735e","","",this);
 
            DividedCommand = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "25e87290-a7d6-48ba-aa5d-7c6c512e7dc3","","",this);
 
            FinalExpresion = RPSControlFactory.CreateRPSTextBox<IndicatorFormulasDialogView>("a3ae87f8-a23f-4a2b-b64f-d65e5812c7da","","",false, this);
 
            ValidateFormulaButton = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "b9ada1ff-eb11-4c8c-a5d3-e34e9c49e8d3","","",this);
 
            CleanFormulaCommandButton = RPSControlFactory.CreateRPSButton<IndicatorFormulasDialogView>( "91b283cb-c0b5-455f-ba44-e3ade5131199","","",this);
 

        }
        public IRPSComboBox<IndicatorFormulasDialogView> Entity { get; set; } 
        public IRPSComboBox<IndicatorFormulasDialogView> Property { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> AddProperty { get; set; } 
        public IRPSComboBox<IndicatorFormulasDialogView> Entity1 { get; set; } 
        public IRPSComboBox<IndicatorFormulasDialogView> FeatureLabel { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> AddProperty1 { get; set; } 
        public IRPSComboBox<IndicatorFormulasDialogView> Constant { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> AddConstant { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> LeftParenthesisCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> RightParenthesisCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> EqualsCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> LessCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> LessThanOrEqualCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> GreaterCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> GreaterThanOrEqualCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> DifferentCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> AndCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> OrCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> PlusCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> MinusCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> TimesCommand { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> DividedCommand { get; set; } 
        public IRPSTextBox<IndicatorFormulasDialogView> FinalExpresion { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> ValidateFormulaButton { get; set; } 
        public IRPSButton<IndicatorFormulasDialogView> CleanFormulaCommandButton { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public IndicatorFormulasDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditLimitsDialogView : View
    {
        public EditLimitsDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<EditLimitsDialogView>("b9b3b846-f442-40e9-8ce6-499e515ee985","","",false, this);
 
            Property = RPSControlFactory.CreateRPSEnumComboBox<EditLimitsDialogView>("0bcce3af-6039-4ac9-9069-b539f4de2283","","",true, this);
 
            AddProperty = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "93b273ab-a038-48b6-b003-bdf79f16c689","","",this);
 
            Entity1 = RPSControlFactory.CreateRPSEnumComboBox<EditLimitsDialogView>("3356b12c-f79e-457c-b4d1-c9d0981a8411","","",false, this);
 
            FeatureLabel = RPSControlFactory.CreateRPSEnumComboBox<EditLimitsDialogView>("5317f49f-91aa-4104-bb1f-c280fa8406ab","","",false, this);
 
            AddProperty1 = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "14899028-762a-4c04-bd9a-ae80d8029f0c","","",this);
 
            AddIndicatorValue = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "eb0e0993-e9c7-4c87-9944-6c2973c64a5c","","",this);
 
            Constant = RPSControlFactory.CreateRPSEnumComboBox<EditLimitsDialogView>("649e1a62-b721-4e84-9736-9de4f2c9197f","","",false, this);
 
            AddConstant = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "a0b8bf2e-21a6-46ce-8c2f-0732b8ca6ca2","","",this);
 
            LeftParenthesisCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "4d9b95bf-4d4c-4e43-b275-f867bc754cf0","","",this);
 
            RightParenthesisCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "8c6f25f8-1e24-4a50-939d-c511ada58f30","","",this);
 
            EqualsCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "d02b0bac-78ed-4ed3-b3da-ed7c5cf29d3b","","",this);
 
            LessCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "c3b8293f-a9b5-4886-8192-e63151ae79cf","","",this);
 
            LessThanOrEqualCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "57abe611-7507-402b-b651-1d56bd373885","","",this);
 
            GreaterCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "a25fa2ab-6e9a-4833-83a4-6c13daab3275","","",this);
 
            GreaterThanOrEqualCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "6b366345-2870-4702-9840-00231376bec7","","",this);
 
            DifferentCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "27a766be-0c63-4f38-b1f3-804d9e34ee85","","",this);
 
            AndCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "8227ac2f-e0e2-40f1-b119-aa38ad61b9f7","","",this);
 
            OrCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "ab622c76-ca20-4bfd-9d36-93d6c7cb2879","","",this);
 
            PlusCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "57eb8a91-cdf7-4a85-8d16-8ccb2213ac87","","",this);
 
            MinusCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "93a53f8f-ba85-494c-9ffe-567d7bb06c49","","",this);
 
            TimesCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "83433492-73fe-45dc-9c8a-64d2fc0ca000","","",this);
 
            DividedCommand = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "a6eb90ff-2ea6-4ced-8194-fc673f6687b6","","",this);
 
            FinalExpresion = RPSControlFactory.CreateRPSTextBox<EditLimitsDialogView>("dca775a2-1a4c-456a-9d27-f3f1727b8c8b","","",false, this);
 
            ValidateFormulaCommandButton = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "88990b62-d603-4975-8ccf-490f55c6d9e3","","",this);
 
            CleanFormulaCommandButton = RPSControlFactory.CreateRPSButton<EditLimitsDialogView>( "72705bdd-58f7-4c19-b75c-72d5b00b718f","","",this);
 

        }
        public IRPSComboBox<EditLimitsDialogView> Entity { get; set; } 
        public IRPSComboBox<EditLimitsDialogView> Property { get; set; } 
        public IRPSButton<EditLimitsDialogView> AddProperty { get; set; } 
        public IRPSComboBox<EditLimitsDialogView> Entity1 { get; set; } 
        public IRPSComboBox<EditLimitsDialogView> FeatureLabel { get; set; } 
        public IRPSButton<EditLimitsDialogView> AddProperty1 { get; set; } 
        public IRPSButton<EditLimitsDialogView> AddIndicatorValue { get; set; } 
        public IRPSComboBox<EditLimitsDialogView> Constant { get; set; } 
        public IRPSButton<EditLimitsDialogView> AddConstant { get; set; } 
        public IRPSButton<EditLimitsDialogView> LeftParenthesisCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> RightParenthesisCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> EqualsCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> LessCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> LessThanOrEqualCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> GreaterCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> GreaterThanOrEqualCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> DifferentCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> AndCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> OrCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> PlusCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> MinusCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> TimesCommand { get; set; } 
        public IRPSButton<EditLimitsDialogView> DividedCommand { get; set; } 
        public IRPSTextBox<EditLimitsDialogView> FinalExpresion { get; set; } 
        public IRPSButton<EditLimitsDialogView> ValidateFormulaCommandButton { get; set; } 
        public IRPSButton<EditLimitsDialogView> CleanFormulaCommandButton { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public EditLimitsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectIndicatorCalculateDialogView : View
    {
        public ProjectIndicatorCalculateDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OnlyProjectsInRealization = RPSControlFactory.CreateRPSCheckBox<ProjectIndicatorCalculateDialogView>("f7f6f89d-e22a-4520-bbac-a5ad14a9293e","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ProjectIndicatorCalculateDialogView>( "2e9a332a-3b2a-44b3-afd5-986c1386af85","","",this);
 
            OnlyMyProjects = RPSControlFactory.CreateRPSOption<ProjectIndicatorCalculateDialogView>( "1e1703f2-6495-44a4-be66-83de066b8a95","","",this);
 
            OnlyMyTeamProjects = RPSControlFactory.CreateRPSOption<ProjectIndicatorCalculateDialogView>( "e73d3b13-a697-423e-964c-cc434d7359dc","","",this);
 
            Projects = RPSControlFactory.CreateRPSCollectionComboBox<ProjectIndicatorCalculateDialogView>("a6cac8e5-bb68-4572-81cf-4b1b7a1175ff","","",false, this);
 

        }
        public IRPSCheckbox<ProjectIndicatorCalculateDialogView> OnlyProjectsInRealization { get; set; } 
        public IRPSOption<ProjectIndicatorCalculateDialogView> All { get; set; } 
        public IRPSOption<ProjectIndicatorCalculateDialogView> OnlyMyProjects { get; set; } 
        public IRPSOption<ProjectIndicatorCalculateDialogView> OnlyMyTeamProjects { get; set; } 
        public IRPSCollectionComboBox<ProjectIndicatorCalculateDialogView> Projects { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public ProjectIndicatorCalculateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AllIndicatorsCalculateDialogView : View
    {
        public AllIndicatorsCalculateDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProjectIndicator = RPSControlFactory.CreateRPSCollectionComboBox<AllIndicatorsCalculateDialogView>("9dd1acf0-c981-4f7c-a7db-5aadec90ad13","","",false, this);
 
            OnlyProjectsInRealization = RPSControlFactory.CreateRPSCheckBox<AllIndicatorsCalculateDialogView>("f0beb248-5bd1-4e4f-af33-9bac4faa5232","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<AllIndicatorsCalculateDialogView>( "70c3a877-4251-42af-b510-ac9aed601529","","",this);
 
            OnlyMyProjects = RPSControlFactory.CreateRPSOption<AllIndicatorsCalculateDialogView>( "8a0e2f56-9eed-4fcd-b4c2-074b937c9bc0","","",this);
 
            OnlyMyTeamProjects = RPSControlFactory.CreateRPSOption<AllIndicatorsCalculateDialogView>( "14dbf1e2-8279-414e-84ad-dc695032ddb9","","",this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<AllIndicatorsCalculateDialogView>("52020662-87ab-4c2e-8a0e-763a081f46a9","","",false, this);
 

        }
        public IRPSCollectionComboBox<AllIndicatorsCalculateDialogView> ProjectIndicator { get; set; } 
        public IRPSCheckbox<AllIndicatorsCalculateDialogView> OnlyProjectsInRealization { get; set; } 
        public IRPSOption<AllIndicatorsCalculateDialogView> All { get; set; } 
        public IRPSOption<AllIndicatorsCalculateDialogView> OnlyMyProjects { get; set; } 
        public IRPSOption<AllIndicatorsCalculateDialogView> OnlyMyTeamProjects { get; set; } 
        public IRPSCollectionComboBox<AllIndicatorsCalculateDialogView> Project { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public AllIndicatorsCalculateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportToXMLDialogView : View
    {
        public ImportToXMLDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ProjectIndicator Screen { get; set; }
        public ImportToXMLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ExportToXMLDialogView : View
    {
        public ExportToXMLDialogView(ProjectIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProjectIndicator = RPSControlFactory.CreateRPSCollectionComboBox<ExportToXMLDialogView>("87670146-2265-49c1-a6f9-73501ccf8b74","","",false, this);
 

        }
        public IRPSCollectionComboBox<ExportToXMLDialogView> ProjectIndicator { get; set; } 
        public ProjectIndicator Screen { get; set; }
        public ExportToXMLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
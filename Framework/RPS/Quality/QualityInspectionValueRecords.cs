    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.QualityInspectionValueRecords
{
    //RPS VERSION 1.0.0.0
    public partial class QualityInspectionValueRecords:Screen
    {
        public QualityInspectionValueRecords():base()
        {
            this.URL = "quality.qualityinspectionvaluerecords";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualityInspectionValueRecordsView  = new QualityInspectionValueRecordsView(this); 
            ControlSheetCharacView  = new ControlSheetCharacView(this); 
            EmptyScreenView  = new EmptyScreenView(this); 
            ChangeEmployeeDialogView  = new ChangeEmployeeDialogView(this); 
            CreateNewNonConformityDialogView  = new CreateNewNonConformityDialogView(this); 
            QualityInspectionValueRecordsView.InitializeControls(); 
            ControlSheetCharacView.InitializeControls(); 
            EmptyScreenView.InitializeControls(); 
            ChangeEmployeeDialogView.InitializeControls(); 
            CreateNewNonConformityDialogView.InitializeControls(); 
           
        }
      
            public QualityInspectionValueRecordsView QualityInspectionValueRecordsView {get; set; } 
            public ControlSheetCharacView ControlSheetCharacView {get; set; } 
            public EmptyScreenView EmptyScreenView {get; set; } 
            public ChangeEmployeeDialogView ChangeEmployeeDialogView {get; set; } 
            public CreateNewNonConformityDialogView CreateNewNonConformityDialogView {get; set; } 
    }
            
    public partial class QualityInspectionValueRecordsView : View
    {
        public QualityInspectionValueRecordsView(QualityInspectionValueRecords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ChangeEmployeeCommand = RPSControlFactory.CreateRPSButtonToView<QualityInspectionValueRecordsView,ChangeEmployeeDialogView>("0446d9d6-e2e3-436a-8081-1371e82a329e","","", this,Screen.ChangeEmployeeDialogView);
 
            InspectionType = RPSControlFactory.CreateRPSEnumComboBox<QualityInspectionValueRecordsView>("5845c843-8bd2-41f5-bc7b-19ff5a32f5e2","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("5e3c6ace-596d-40d8-b4f2-66dde8880966","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("548eb1b1-11dc-4ea5-ac32-c43f796b5bb8","","",false, this);
 
            GroupBySerie = RPSControlFactory.CreateRPSCheckBox<QualityInspectionValueRecordsView>("9d34388f-465d-4632-9a81-a9660cabb060","","",false, this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("4873653c-17e9-4329-9106-66ad1428c9ac","","",false, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("468a9019-7fd4-4989-ba06-4b764c91dcb5","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("3f3de449-050b-4484-a542-6a6b89d1424c","","",false, this);
 
            GroupBySerie1 = RPSControlFactory.CreateRPSCheckBox<QualityInspectionValueRecordsView>("dfabcb7b-7167-4537-9565-1d86525a7497","","",false, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("6177d48d-dfc4-4347-a191-7d6ea950c239","","",false, this);
 
            IDDeliveryNoteLineSL = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("aa7200ee-f96f-46ac-96f8-4da5ba7ad093","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("2a57678f-f6e0-44af-865b-6d27aa46ddd9","","",false, this);
 
            IDOrderLineSL = RPSControlFactory.CreateRPSComboBox<QualityInspectionValueRecordsView>("897449ee-b340-42d7-87ff-dcfcd57cce97","","",false, this);
 
            GoToFirstCharac = RPSControlFactory.CreateRPSButton<QualityInspectionValueRecordsView>( "df12b4db-cd2e-48dc-9fc3-5552461eb235","","",this);
 
            GoToPreviousCharac = RPSControlFactory.CreateRPSButton<QualityInspectionValueRecordsView>( "bd86a441-281d-41da-ae07-fcbac8cb808c","","",this);
 
            GoToNextCharac = RPSControlFactory.CreateRPSButton<QualityInspectionValueRecordsView>( "92ae08f3-ccbe-4281-b3f1-f4a6e29ae38d","","",this);
 
            GoToLastCharac = RPSControlFactory.CreateRPSButton<QualityInspectionValueRecordsView>( "dd9bbdc0-94b3-4b21-9fb8-60eef4604465","","",this);
 

        }
        public IRPSButton<QualityInspectionValueRecordsView,ChangeEmployeeDialogView> ChangeEmployeeCommand { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> InspectionType { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDMOTask { get; set; } 
        public IRPSCheckbox<QualityInspectionValueRecordsView> GroupBySerie { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDDeliveryNote { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDOrderLine { get; set; } 
        public IRPSCheckbox<QualityInspectionValueRecordsView> GroupBySerie1 { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDDeliveryNoteSL { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDDeliveryNoteLineSL { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDOrderSL { get; set; } 
        public IRPSComboBox<QualityInspectionValueRecordsView> IDOrderLineSL { get; set; } 
        public IRPSButton<QualityInspectionValueRecordsView> GoToFirstCharac { get; set; } 
        public IRPSButton<QualityInspectionValueRecordsView> GoToPreviousCharac { get; set; } 
        public IRPSButton<QualityInspectionValueRecordsView> GoToNextCharac { get; set; } 
        public IRPSButton<QualityInspectionValueRecordsView> GoToLastCharac { get; set; } 
        public QualityInspectionValueRecords Screen { get; set; }
        public QualityInspectionValueRecordsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetCharacView : View
    {
        public ControlSheetCharacView(QualityInspectionValueRecords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlSheetCharacView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetCharacView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetCharacView,QualityInspectionValueRecordsView>( this,Screen.QualityInspectionValueRecordsView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetCharacView,QualityInspectionValueRecordsView>( this,Screen.QualityInspectionValueRecordsView);
 
            NumCharacteristic = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("2f625af8-22d7-4259-a5b4-8c41ed398bc8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("94d3ca06-45ce-4ad6-91c6-36bb831c26f6","","",false, this);
 
            IDCharacteristicClass = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("f68e2a8c-f418-404f-96ae-f6149df52e47","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("a199b466-bedd-4fa2-b28f-8ce7f5a40731","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("b72ecbcc-e74b-4a99-87bd-e7b853da2e61","","",false, this);
 
            Nominal = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("113ebd9c-c7c5-460e-82b1-6cb784cf7e5a","","",false, this);
 
            Max = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("e9b840d3-60ff-4301-8fd1-dd827e9dabd6","","",false, this);
 
            Min = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("e8a5679c-a056-41b5-a32b-9be47437fa45","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("05cf61db-5e1d-4560-8d6a-1c2af902d144","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("c696d313-231b-44ba-9880-7cff420ae1cc","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("9bbce885-77de-48fa-b2ee-e50b0b957fb5","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("7e8fa219-31b1-44c5-888e-07945500f0d9","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("b42b01cf-d6a6-4f51-8cc8-95f0795e43ab","","",false, this);
 
            InspectionDate = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("9624a7bd-e3e0-4d55-9ae9-8a423cab4085","","",false, this);
 
            InspectionSeries = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("d14c6e20-523b-47df-8cbc-ce615a3f798a","","",false, this);
 
            InspectionValue = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("10f5d0c6-6020-493b-bae2-8597825dac79","","",false, this);
 
            AddNewValue = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "74393068-45ca-44d5-8da6-a0a2a5392a43","","",this);
 
            InspectionOkorNOK = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("508623ac-3ce5-4fe0-abba-603140359420","","",false, this);
 
            AddNewValue1 = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "58f17401-254a-44e0-a4fc-def8ba0d9272","","",this);
 
            InspectionText = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("007177d9-adfa-40e8-8f95-fbd635ca91dd","","",false, this);
 
            AddNewValue2 = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "c4d5c1ab-fef8-4fd7-948a-aeada4000ddc","","",this);
 
            LinkControlSheetVersionButton = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "3f9292e0-cdf8-4f65-98d5-d1874ec41c54","","",this);
 
            ShowControlSheetAttachmentsButton = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "05206b17-3832-44a7-823a-bd72dd18310d","","",this);
 
            CreateNewNonConformityCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetCharacView,CreateNewNonConformityDialogView>("6080130f-338f-4fb4-9327-636ff50db363","","", this,Screen.CreateNewNonConformityDialogView);
 
            LinkToNCConsultationButton = RPSControlFactory.CreateRPSButton<ControlSheetCharacView>( "ed78d298-a3e7-48ea-a3ec-de05895c9d8b","","",this);
 
            CollectionInit params_ControlSheetValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetValues = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetValuesCollectionEditor<ControlSheetCharacView,CreateNewNonConformityDialogView>,ControlSheetCharacView,CreateNewNonConformityDialogView>( params_ControlSheetValues,this,Screen.CreateNewNonConformityDialogView);
 

        }
        public IRPSSaveButton<ControlSheetCharacView> SaveButton { get; set; } 
        public IRPSButton<ControlSheetCharacView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacView,QualityInspectionValueRecordsView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacView,QualityInspectionValueRecordsView> BackButton { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> NumCharacteristic { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Description { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDCharacteristicClass { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> ControlType { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ToleranceSpecification { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Nominal { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Max { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Min { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ControlMethod { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> MeasureTechnique { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> SampleSize { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> SampleFrecuency { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ReactionPlan { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> InspectionDate { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> InspectionSeries { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> InspectionValue { get; set; } 
        public IRPSButton<ControlSheetCharacView> AddNewValue { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> InspectionOkorNOK { get; set; } 
        public IRPSButton<ControlSheetCharacView> AddNewValue1 { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> InspectionText { get; set; } 
        public IRPSButton<ControlSheetCharacView> AddNewValue2 { get; set; } 
        public IRPSButton<ControlSheetCharacView> LinkControlSheetVersionButton { get; set; } 
        public IRPSButton<ControlSheetCharacView> ShowControlSheetAttachmentsButton { get; set; } 
        public IRPSButton<ControlSheetCharacView,CreateNewNonConformityDialogView> CreateNewNonConformityCommandButton { get; set; } 
        public IRPSButton<ControlSheetCharacView> LinkToNCConsultationButton { get; set; } 
        public ControlSheetValuesCollectionEditor<ControlSheetCharacView,CreateNewNonConformityDialogView> ControlSheetValues { get; set; } 
        public QualityInspectionValueRecords Screen { get; set; }
        public ControlSheetCharacView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetValuesCollectionEditor<ControlSheetCharacView,CreateNewNonConformityDialogView>:RPSCollectionEditor<ControlSheetCharacView,CreateNewNonConformityDialogView> where ControlSheetCharacView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public  ControlSheetValuesGridView<ControlSheetCharacView,CreateNewNonConformityDialogView> GridView {get;set;}
    }
    public partial class ControlSheetValuesGridView <ControlSheetCharacView,CreateNewNonConformityDialogView> :  RPSGridView<ControlSheetCharacView,CreateNewNonConformityDialogView> where ControlSheetCharacView : class, IView where CreateNewNonConformityDialogView : class, IView
    {
        public ControlSheetValuesGridView(ControlSheetCharacView currentView,CreateNewNonConformityDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SampleNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cSampleNumber']","",true, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            OKorNOK = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cOKorNOK']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 
            SampleDate = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cSampleDate']","",true, this.CurrentView);
 
            SampleTime = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cSampleTime']","",false, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<ControlSheetCharacView>("","#6a4628d5-e9ba-4acb-bc8f-dd0c7818ae2f .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetCharacView> SampleNumber { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> Series { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Value { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> OKorNOK { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Text { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> SampleDate { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> SampleTime { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> IDEmployee { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Notes { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmptyScreenView : View
    {
        public EmptyScreenView(QualityInspectionValueRecords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public QualityInspectionValueRecords Screen { get; set; }
        public EmptyScreenView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeEmployeeDialogView : View
    {
        public ChangeEmployeeDialogView(QualityInspectionValueRecords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_EmployeeActive = new CollectionInit(){IDDescriptor = "49f9ac6f-b775-46bb-8e12-6debb820f55e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            EmployeeActive = RPSControlFactory.RPSCreateCollection<ChangeEmployeeDialogView>( params_EmployeeActive,this);
 

        }
        public IRPSCollectionEditor<ChangeEmployeeDialogView> EmployeeActive { get; set; } 
        public QualityInspectionValueRecords Screen { get; set; }
        public ChangeEmployeeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateNewNonConformityDialogView : View
    {
        public CreateNewNonConformityDialogView(QualityInspectionValueRecords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NCCode = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("18fc4f67-6240-43d2-a9ad-5185fb6806ed","","",true, this);
 
            NCCreatedBy = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("696244fb-a805-4465-87ac-ee90275d677e","","",true, this);
 
            NCSource = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("76742bb5-9d6c-4d01-8921-ac81f9e6f5bd","","",true, this);
 
            NCSeverity = RPSControlFactory.CreateRPSEnumComboBox<CreateNewNonConformityDialogView>("4122814e-30bf-4de8-83a1-a7bd3f0fa6e9","","",true, this);
 
            NCDescription = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("71e81db4-b962-459e-889f-0c576b08950b","","",false, this);
 

        }
        public IRPSTextBox<CreateNewNonConformityDialogView> NCCode { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCCreatedBy { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCSource { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCSeverity { get; set; } 
        public IRPSTextBox<CreateNewNonConformityDialogView> NCDescription { get; set; } 
        public QualityInspectionValueRecords Screen { get; set; }
        public CreateNewNonConformityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
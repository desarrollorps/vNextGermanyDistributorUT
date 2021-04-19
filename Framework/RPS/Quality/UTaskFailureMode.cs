    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.UTaskFailureMode
{
    //RPS VERSION 1.0.0.0
    public partial class UTaskFailureMode:Screen
    {
        public UTaskFailureMode():base()
        {
            this.URL = "quality.utaskfailuremode";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UTaskFailureModeVMQueryView  = new UTaskFailureModeVMQueryView(this); 
            UTaskFailureModeVMEntityView  = new UTaskFailureModeVMEntityView(this); 
            UTaskEffectView  = new UTaskEffectView(this); 
            UTaskCauseView  = new UTaskCauseView(this); 
            UpdateFMEAFailuresDialogView  = new UpdateFMEAFailuresDialogView(this); 
            UTaskFailureModeVMQueryView.InitializeControls(); 
            UTaskFailureModeVMEntityView.InitializeControls(); 
            UTaskEffectView.InitializeControls(); 
            UTaskCauseView.InitializeControls(); 
            UpdateFMEAFailuresDialogView.InitializeControls(); 
           
        }
      
            public UTaskFailureModeVMQueryView UTaskFailureModeVMQueryView {get; set; } 
            public UTaskFailureModeVMEntityView UTaskFailureModeVMEntityView {get; set; } 
            public UTaskEffectView UTaskEffectView {get; set; } 
            public UTaskCauseView UTaskCauseView {get; set; } 
            public UpdateFMEAFailuresDialogView UpdateFMEAFailuresDialogView {get; set; } 
    }
            
    public partial class UTaskFailureModeVMQueryView : View
    {
        public UTaskFailureModeVMQueryView(UTaskFailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<UTaskFailureModeVMQueryView>( this);
 
            eTemplateType = RPSControlFactory.CreateRPSEnumComboBox<UTaskFailureModeVMQueryView>("c414da2c-d871-4db0-873a-4b404f3bb3a8","","",false, this);
 
            UsualTask = RPSControlFactory.CreateRPSComboBox<UTaskFailureModeVMQueryView>("7e626084-60b7-4738-ac2e-76a567274fbf","","",false, this);
 
            UsualTaskSTR = RPSControlFactory.CreateRPSComboBox<UTaskFailureModeVMQueryView>("47551428-84a3-49d4-b2ee-321751f7af79","","",false, this);
 
            UpdateFMEAFailuresCommandButton = RPSControlFactory.CreateRPSButtonToView<UTaskFailureModeVMQueryView,UpdateFMEAFailuresDialogView>("c464d002-d620-418a-8219-27f8017bc024","","", this,Screen.UpdateFMEAFailuresDialogView);
 
            CollectionInit params_UsualTaskFailureModesQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9d9d99d5-4685-4363-91f4-b33c970ed7f6",CSSSelectorGrid="",XPathGrid=""};
            UsualTaskFailureModesQuery = RPSControlFactory.RPSCreateCollectionWithGrid<UsualTaskFailureModesQueryCollectionEditor<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView>,UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView>( params_UsualTaskFailureModesQuery,this,Screen.UTaskFailureModeVMEntityView);
 

        }
        public IRPSButton<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> NewButton { get; set; } 
        public IRPSButton<UTaskFailureModeVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<UTaskFailureModeVMQueryView> eTemplateType { get; set; } 
        public IRPSComboBox<UTaskFailureModeVMQueryView> UsualTask { get; set; } 
        public IRPSComboBox<UTaskFailureModeVMQueryView> UsualTaskSTR { get; set; } 
        public IRPSButton<UTaskFailureModeVMQueryView,UpdateFMEAFailuresDialogView> UpdateFMEAFailuresCommandButton { get; set; } 
        public UsualTaskFailureModesQueryCollectionEditor<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> UsualTaskFailureModesQuery { get; set; } 
        public UTaskFailureMode Screen { get; set; }
        public UTaskFailureModeVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UsualTaskFailureModesQueryCollectionEditor<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView>:RPSCollectionEditor<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> where UTaskFailureModeVMQueryView : class, IView where UTaskFailureModeVMEntityView : class, IView
    {
        public  UsualTaskFailureModesQueryGridView<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> GridView {get;set;}
    }
    public partial class UsualTaskFailureModesQueryGridView <UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> :  RPSGridView<UTaskFailureModeVMQueryView,UTaskFailureModeVMEntityView> where UTaskFailureModeVMQueryView : class, IView where UTaskFailureModeVMEntityView : class, IView
    {
        public UsualTaskFailureModesQueryGridView(UTaskFailureModeVMQueryView currentView,UTaskFailureModeVMEntityView newView)
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
  
            
    public partial class UTaskFailureModeVMEntityView : View
    {
        public UTaskFailureModeVMEntityView(UTaskFailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UTaskFailureModeVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UTaskFailureModeVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UTaskFailureModeVMEntityView,UTaskFailureModeVMQueryView>( this,Screen.UTaskFailureModeVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<UTaskFailureModeVMEntityView,UTaskFailureModeVMQueryView>( this,Screen.UTaskFailureModeVMQueryView);
 
            IDFailureMode = RPSControlFactory.CreateRPSComboBox<UTaskFailureModeVMEntityView>("b1ae2a1d-4133-48e8-a176-f09c1ac4630d","","",true, this);
 
            IDRequirement = RPSControlFactory.CreateRPSComboBox<UTaskFailureModeVMEntityView>("180efa9b-e0e8-45a4-af32-73470b0bb0a7","","",false, this);
 
            RPNMax = RPSControlFactory.CreateRPSFormattedTextBox<UTaskFailureModeVMEntityView>("f1c625a3-475c-49dd-85e0-0f909b60db7b","","",false, this);
 
            CollectionInit params_UTaskEffects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="008fb345-c705-4a61-8a1b-dc41b1151bfa",CSSSelectorGrid="",XPathGrid=""};
            UTaskEffects = RPSControlFactory.RPSCreateCollectionWithGrid<UTaskEffectsCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView>,UTaskFailureModeVMEntityView,UTaskEffectView>( params_UTaskEffects,this,Screen.UTaskEffectView);
 
            CollectionInit params_UTaskCauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="04cf0247-4d0f-4454-b1eb-ff640339eeed",CSSSelectorGrid="",XPathGrid=""};
            UTaskCauses = RPSControlFactory.RPSCreateCollectionWithGrid<UTaskCausesCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView>,UTaskFailureModeVMEntityView,UTaskEffectView>( params_UTaskCauses,this,Screen.UTaskEffectView);
 

        }
        public IRPSSaveButton<UTaskFailureModeVMEntityView> SaveButton { get; set; } 
        public IRPSButton<UTaskFailureModeVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<UTaskFailureModeVMEntityView,UTaskFailureModeVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UTaskFailureModeVMEntityView,UTaskFailureModeVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<UTaskFailureModeVMEntityView> IDFailureMode { get; set; } 
        public IRPSComboBox<UTaskFailureModeVMEntityView> IDRequirement { get; set; } 
        public IRPSTextBox<UTaskFailureModeVMEntityView> RPNMax { get; set; } 
        public UTaskEffectsCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView> UTaskEffects { get; set; } 
        public UTaskCausesCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView> UTaskCauses { get; set; } 
        public UTaskFailureMode Screen { get; set; }
        public UTaskFailureModeVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UTaskEffectsCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView>:RPSCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView> where UTaskFailureModeVMEntityView : class, IView where UTaskEffectView : class, IView
    {
        public  UTaskEffectsGridView<UTaskFailureModeVMEntityView,UTaskEffectView> GridView {get;set;}
    }
    public partial class UTaskEffectsGridView <UTaskFailureModeVMEntityView,UTaskEffectView> :  RPSGridView<UTaskFailureModeVMEntityView,UTaskEffectView> where UTaskFailureModeVMEntityView : class, IView where UTaskEffectView : class, IView
    {
        public UTaskEffectsGridView(UTaskFailureModeVMEntityView currentView,UTaskEffectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEffect = RPSControlFactory.CreateRPSGridComboBox<UTaskFailureModeVMEntityView>("","#008fb345-c705-4a61-8a1b-dc41b1151bfa .ag-row[role='row']@ROWINDEX [col-id='cIDEffect']","",true, this.CurrentView);
 
            SeverityStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<UTaskFailureModeVMEntityView>("","#008fb345-c705-4a61-8a1b-dc41b1151bfa .ag-row[role='row']@ROWINDEX [col-id='cSeverityStringValue']","",false, this.CurrentView);
 
            Class = RPSControlFactory.CreateRPSGridComboBox<UTaskFailureModeVMEntityView>("","#008fb345-c705-4a61-8a1b-dc41b1151bfa .ag-row[role='row']@ROWINDEX [col-id='cClass']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> IDEffect { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> SeverityStringValue { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> Class { get; set; } 
                     
    }
 
        public partial class UTaskCausesCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView>:RPSCollectionEditor<UTaskFailureModeVMEntityView,UTaskEffectView> where UTaskFailureModeVMEntityView : class, IView where UTaskEffectView : class, IView
    {
        public  UTaskCausesGridView<UTaskFailureModeVMEntityView,UTaskEffectView> GridView {get;set;}
    }
    public partial class UTaskCausesGridView <UTaskFailureModeVMEntityView,UTaskEffectView> :  RPSGridView<UTaskFailureModeVMEntityView,UTaskEffectView> where UTaskFailureModeVMEntityView : class, IView where UTaskEffectView : class, IView
    {
        public UTaskCausesGridView(UTaskFailureModeVMEntityView currentView,UTaskEffectView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCause = RPSControlFactory.CreateRPSGridComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cIDCause']","",true, this.CurrentView);
 
            OccurrenceStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cOccurrenceStringValue']","",false, this.CurrentView);
 
            DetectionStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cDetectionStringValue']","",false, this.CurrentView);
 
            RPN = RPSControlFactory.CreateRPSGridFormattedTextBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cRPN']","",false, this.CurrentView);
 
            ActionPriorityLevel = RPSControlFactory.CreateRPSGridEnumComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cActionPriorityLevel']","",true, this.CurrentView);
 
            IDRecomendedAction = RPSControlFactory.CreateRPSGridComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cIDRecomendedAction']","",false, this.CurrentView);
 
            IDActionTaken = RPSControlFactory.CreateRPSGridComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cIDActionTaken']","",false, this.CurrentView);
 
            RPNNew = RPSControlFactory.CreateRPSGridFormattedTextBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cRPNNew']","",false, this.CurrentView);
 
            APriorityNew = RPSControlFactory.CreateRPSGridEnumComboBox<UTaskFailureModeVMEntityView>("","#04cf0247-4d0f-4454-b1eb-ff640339eeed .ag-row[role='row']@ROWINDEX [col-id='cAPriorityNew']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> IDCause { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> OccurrenceStringValue { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> DetectionStringValue { get; set; } 
        public IRPSGridTextBox<UTaskFailureModeVMEntityView> RPN { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> ActionPriorityLevel { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> IDRecomendedAction { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> IDActionTaken { get; set; } 
        public IRPSGridTextBox<UTaskFailureModeVMEntityView> RPNNew { get; set; } 
        public IRPSGridComboBox<UTaskFailureModeVMEntityView> APriorityNew { get; set; } 
                     
    }
 
    }
  
            
    public partial class UTaskEffectView : View
    {
        public UTaskEffectView(UTaskFailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<UTaskEffectView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UTaskEffectView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<UTaskEffectView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<UTaskEffectView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            IDEffect = RPSControlFactory.CreateRPSComboBox<UTaskEffectView>("545932ba-b9d6-48cc-8fe5-184f5d3b563e","","",true, this);
 
            SeverityStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskEffectView>("2be44bf1-d4a0-4fdc-9f75-a222ca8e60bd","","",false, this);
 
            Class = RPSControlFactory.CreateRPSComboBox<UTaskEffectView>("0c739c58-9a47-40a9-a342-9400fa29da0d","","",false, this);
 

        }
        public IRPSButton<UTaskEffectView> DeleteButton { get; set; } 
        public IRPSButton<UTaskEffectView,UTaskFailureModeVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UTaskEffectView,UTaskFailureModeVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<UTaskEffectView,UTaskFailureModeVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<UTaskEffectView> IDEffect { get; set; } 
        public IRPSComboBox<UTaskEffectView> SeverityStringValue { get; set; } 
        public IRPSComboBox<UTaskEffectView> Class { get; set; } 
        public UTaskFailureMode Screen { get; set; }
        public UTaskEffectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UTaskCauseView : View
    {
        public UTaskCauseView(UTaskFailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<UTaskCauseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UTaskCauseView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<UTaskCauseView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<UTaskCauseView,UTaskFailureModeVMEntityView>( this,Screen.UTaskFailureModeVMEntityView);
 
            IDCause = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("047114b4-0e46-4ab7-9e28-fd577b835898","","",true, this);
 
            OccurrenceStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("5fceb055-f24a-4447-aa86-eb005fd9b7f6","","",false, this);
 
            SeverityVsOccurrence = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("054bd0a0-35fd-4ff3-9fc2-12b2546c1cd7","","",true, this);
 
            DetectionStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("e2aca29c-1b67-412f-a623-4069615e31a5","","",false, this);
 
            SeverityVsDetection = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("15466012-1c71-48fa-ab7f-26e466b1658e","","",true, this);
 
            RPN = RPSControlFactory.CreateRPSFormattedTextBox<UTaskCauseView>("efb6fd11-3734-4ef3-ac24-c75c59b8fb3a","","",false, this);
 
            ActionPriorityLevel = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("32ea2aae-0789-4e1e-b77c-952b8436b157","","",true, this);
 
            IDVerify = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("7cfb076d-014a-427c-ac98-c9b32b13c53c","","",false, this);
 
            IDVerify_DET = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("ef4571a8-cf89-4c8d-b1b9-6b1c08dd3f80","","",false, this);
 
            IDRecomendedAction = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("fde29b51-2c35-4c08-8ca7-03c33903ff1d","","",false, this);
 
            IDResponsible = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("45bf0301-f874-4feb-ba9e-9c36f234e72f","","",false, this);
 
            TargetDate = RPSControlFactory.CreateRPSTextBox<UTaskCauseView>("a7fd69b9-a8d2-43de-846a-814d20de7c27","","",false, this);
 
            IDActionTaken = RPSControlFactory.CreateRPSComboBox<UTaskCauseView>("8c624094-dac3-487e-a93b-a1c39e3c5f6d","","",false, this);
 
            SeverityNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("e6ec4da7-a266-4bac-b1de-2331dccada67","","",false, this);
 
            OccurrenceNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("1e48cc72-332d-427d-920c-0a80d28e8814","","",false, this);
 
            SvOccurrenceNew = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("4d9ffa47-3a1b-49cc-b812-8d6e4215d143","","",true, this);
 
            DetectionNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("3a47ece1-2021-40c3-814f-6fb8ca43d25e","","",false, this);
 
            SvDetectionNew = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("6f22409f-d703-45f6-b442-12e151fa4745","","",true, this);
 
            RPNNew = RPSControlFactory.CreateRPSFormattedTextBox<UTaskCauseView>("c8f1b8a3-d7b7-48b4-a763-b0173c4c1026","","",false, this);
 
            APriorityNew = RPSControlFactory.CreateRPSEnumComboBox<UTaskCauseView>("5ea54bb2-3224-4069-8da8-2fedd2df4202","","",true, this);
 

        }
        public IRPSButton<UTaskCauseView> DeleteButton { get; set; } 
        public IRPSButton<UTaskCauseView,UTaskFailureModeVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UTaskCauseView,UTaskFailureModeVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<UTaskCauseView,UTaskFailureModeVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDCause { get; set; } 
        public IRPSComboBox<UTaskCauseView> OccurrenceStringValue { get; set; } 
        public IRPSComboBox<UTaskCauseView> SeverityVsOccurrence { get; set; } 
        public IRPSComboBox<UTaskCauseView> DetectionStringValue { get; set; } 
        public IRPSComboBox<UTaskCauseView> SeverityVsDetection { get; set; } 
        public IRPSTextBox<UTaskCauseView> RPN { get; set; } 
        public IRPSComboBox<UTaskCauseView> ActionPriorityLevel { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDVerify { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDVerify_DET { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDRecomendedAction { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDResponsible { get; set; } 
        public IRPSTextBox<UTaskCauseView> TargetDate { get; set; } 
        public IRPSComboBox<UTaskCauseView> IDActionTaken { get; set; } 
        public IRPSComboBox<UTaskCauseView> SeverityNewStringValue { get; set; } 
        public IRPSComboBox<UTaskCauseView> OccurrenceNewStringValue { get; set; } 
        public IRPSComboBox<UTaskCauseView> SvOccurrenceNew { get; set; } 
        public IRPSComboBox<UTaskCauseView> DetectionNewStringValue { get; set; } 
        public IRPSComboBox<UTaskCauseView> SvDetectionNew { get; set; } 
        public IRPSTextBox<UTaskCauseView> RPNNew { get; set; } 
        public IRPSComboBox<UTaskCauseView> APriorityNew { get; set; } 
        public UTaskFailureMode Screen { get; set; }
        public UTaskCauseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateFMEAFailuresDialogView : View
    {
        public UpdateFMEAFailuresDialogView(UTaskFailureMode screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNew = RPSControlFactory.CreateRPSOption<UpdateFMEAFailuresDialogView>( "c9e9b90f-5a88-4a5e-b236-d38969b27782","","",this);
 
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<UpdateFMEAFailuresDialogView>("74184fb1-5de7-4dda-a09d-2c6f368e79d6","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<UpdateFMEAFailuresDialogView>( "a4f87e3b-78d3-4275-aaf6-168a2afd1ded","","",this);
 
            Restore = RPSControlFactory.CreateRPSOption<UpdateFMEAFailuresDialogView>( "885a7695-b6b4-45c4-8ec2-9885dc4ee553","","",this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("8387bbb1-08c2-4722-b2f7-b4196d71e3a8","","",false, this);
 
            eTemplateType = RPSControlFactory.CreateRPSEnumComboBox<UpdateFMEAFailuresDialogView>("6463da08-e6cd-425c-96d1-6031ad3270b6","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("2d71c670-df75-48c1-bfa4-63d4277f1215","","",false, this);
 
            IDFMEAProjectVersion = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("80fabfe5-b8de-42ef-9f60-8a0d6021836f","","",false, this);
 
            IDArticle1 = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("4caf883e-a0c1-47e1-9a7e-e37022d9b29e","","",false, this);
 
            eTemplateType1 = RPSControlFactory.CreateRPSEnumComboBox<UpdateFMEAFailuresDialogView>("01f36da4-bcd1-4170-9b12-e99ac148ccf1","","",true, this);
 
            IDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("b0dbea5a-bad9-4d5c-81c4-51bc434460a6","","",false, this);
 
            IDFMEAManufacturingVersion = RPSControlFactory.CreateRPSComboBox<UpdateFMEAFailuresDialogView>("090b8f6b-4733-4cb3-b5d9-91eeabb32fb2","","",false, this);
 

        }
        public IRPSOption<UpdateFMEAFailuresDialogView> AddNew { get; set; } 
        public IRPSCheckbox<UpdateFMEAFailuresDialogView> OnlyNotApproved { get; set; } 
        public IRPSOption<UpdateFMEAFailuresDialogView> Update { get; set; } 
        public IRPSOption<UpdateFMEAFailuresDialogView> Restore { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDArticle { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> eTemplateType { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDUsualTask { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDFMEAProjectVersion { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDArticle1 { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> eTemplateType1 { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDUsualTaskSTR { get; set; } 
        public IRPSComboBox<UpdateFMEAFailuresDialogView> IDFMEAManufacturingVersion { get; set; } 
        public UTaskFailureMode Screen { get; set; }
        public UpdateFMEAFailuresDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ParameterPRO
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterPRO:Screen
    {
        public ParameterPRO():base()
        {
            this.URL = "project.parameterpro";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterPROEntityView  = new ParameterPROEntityView(this); 
            ParameterNotifyView  = new ParameterNotifyView(this); 
            ParameterPROEntityView.InitializeControls(); 
            ParameterNotifyView.InitializeControls(); 
           
        }
      
            public ParameterPROEntityView ParameterPROEntityView {get; set; } 
            public ParameterNotifyView ParameterNotifyView {get; set; } 
    }
            
    public partial class ParameterPROEntityView : View
    {
        public ParameterPROEntityView(ParameterPRO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ControlUser = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("dbc8a61b-ad8b-4b86-9e99-20d0c3de00c7","","",true, this);
 
            OverrideDataSituationChange = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("3b071522-66b1-47a4-a239-cd30ff732ad7","","",false, this);
 
            PendingTime = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("2f132026-5fca-4119-8c43-db72435af63c","","",false, this);
 
            PercentCompleted = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("3a0cf187-d6a6-4714-8d37-7f9518ac76b6","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("56cfe1c3-ab9c-45de-81bb-77d975a9699c","","",true, this);
 
            IDProjectType = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("1e15386d-f02d-491e-bfa0-9198cd631f61","","",true, this);
 
            IDPROWarningPriority = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("3d595f34-5e4c-4a93-a25c-5f0aca555e91","","",true, this);
 
            ManualPlanning = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("8c743c22-528c-41bf-a152-9bdc3ae5dc84","","",true, this);
 
            IDPROWarningType = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("49b1fc3e-d020-4269-aba7-0814e02a09c7","","",true, this);
 
            IDPROTaskType = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("f8a78874-8745-4f87-b696-0bb82f6591b0","","",true, this);
 
            CalPriceSales = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("5a149db0-57fa-4f82-a9e1-aa8cf786fbc7","","",true, this);
 
            IDPROSolutionType = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("4c73193a-d41e-4cb2-b33d-c4fd21b31b0e","","",true, this);
 
            IDHourTypeDefault = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("cc2c841f-8948-45f6-b358-c4c584bc99be","","",false, this);
 
            MaterialExitDefault = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("00f41d9c-c212-402d-b103-e48aca274f5e","","",true, this);
 
            IDPROWarningSeverity = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("d945480d-2dd2-4788-b30c-e29bbce89944","","",true, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("698d1314-c25d-4d33-b1c4-8b67ea935f04","","",true, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("79e01aaa-aca5-46a1-abf1-3d17c640eca9","","",true, this);
 
            IDPROSituationCreated = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("98793257-a856-4fcf-8d63-57087f278c35","","",true, this);
 
            IDPROSituationDismissed = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("6d40fe26-47f9-4dee-b1df-f39f594a2828","","",true, this);
 
            IDPROSituationWarningInitial = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("a492ad1e-4d03-4d96-acde-0645729e4cf8","","",true, this);
 
            IDPROSituationWarningFinal = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("14c8f600-958f-4235-b999-c3f9ad4f758f","","",true, this);
 
            IDPROSituationTestInitial = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("b0e9a0bd-341c-42b8-9fed-d7a49071599e","","",true, this);
 
            IDPROSituationTestFinal = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("bd349e2b-70cc-4db6-91a1-4e0d8fa4d204","","",true, this);
 
            IDSituationMilestoneInitial = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("4e3bafad-b1d8-4287-9bbb-eeffce1374e2","","",true, this);
 
            IDSituationMilestoneFinal = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("2251dcbf-db6f-487a-a8e6-e01e59c6fe26","","",true, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("1fb4b103-ce5e-4f2e-af9d-9f75a0f899e6","","",true, this);
 
            PrecodeGroup = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("59f5538a-3dd5-4a2f-b99b-c61957e32243","","",false, this);
 
            LengthGroup = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("9c11e950-b1ac-4cc9-8d0b-fb9d1984010d","","",true, this);
 
            PrecodeEmployee = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("568b4f2a-9d5a-4530-b11f-a6f8582b5f00","","",false, this);
 
            LengthEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("21684614-caa2-4f59-a726-712073a3e4a0","","",true, this);
 
            PrecodeTask = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("edc3c863-524d-46d1-9302-77258b4c1122","","",false, this);
 
            LengthTask = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("bb4ea7d7-3fc2-4b1c-9109-21464ffe9a23","","",true, this);
 
            PrecodeMachine = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("e467001d-ae13-40bb-805f-133d09030604","","",false, this);
 
            LengthMachine = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("51ded917-792b-4982-a2c6-0c874655c241","","",true, this);
 
            PrecodeMilestone = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("fe04f164-af34-46d8-a8cd-0a34750bf98f","","",false, this);
 
            LengthMilestone = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("881b32e4-c55d-4beb-8084-6299a192b51c","","",true, this);
 
            PrecodeTool = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("def3cb37-ff71-465f-802b-f51373d52f7d","","",false, this);
 
            LengthTool = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("979c9d1e-70e1-441b-a688-8b744f7c9770","","",true, this);
 
            PrecodeMaterial = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("1284fa0e-6884-4ad2-83f2-6b34b1270b1d","","",false, this);
 
            LengthMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("b4b568d1-c5ed-453c-ba14-62384cd73775","","",true, this);
 
            PrecodeCostComponent = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("b2669ff2-58e6-4d6d-8e54-5a88e9d27056","","",false, this);
 
            LengthCostComponent = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("a48af334-b49c-4845-a792-a3d845d434f7","","",true, this);
 
            IDCodingSerieProject = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("b19e2a7b-25f7-43ed-9a5e-651dfa156c59","","",false, this);
 
            IDCodingSeriesWarning = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("b0d9b42d-8011-4508-8aaf-cc7d4847f28f","","",false, this);
 
            IDCodingSeriesTest = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("46ee9528-212b-42df-9ea0-b2db6b6da9e2","","",false, this);
 
            IDCodingSeriesUsualTest = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("de65067d-bda9-4f4c-84fd-c9385dd42fc5","","",false, this);
 
            BlockedDateImputation = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("3f51de03-2b7f-4b84-b355-ee7cbe2117ba","","",false, this);
 
            ImputationStyle = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("350e569c-5f5c-4c71-b513-f45a3879eb2f","","",false, this);
 
            PendingTimeCalculation = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("aad568f7-8ed2-433f-a970-2231b21485c5","","",true, this);
 
            EnabledImputationZero = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("e50abc75-3c57-4c31-9017-752e3e2758b4","","",true, this);
 
            EnabledNegative = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("69bb283a-74d6-468e-b59e-be7338552c55","","",true, this);
 
            WhoCanNegative = RPSControlFactory.CreateRPSEnumComboBox<ParameterPROEntityView>("8e2efbe6-ad1c-4741-a530-b7cfeffc7550","","",true, this);
 
            GenerateBaseLine = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("8187cbeb-de9c-4a5b-a5af-4833bd25f38c","","",false, this);
 
            SuffixCodeProjectAccepted = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("dcaa2fdb-ccd7-4ca8-8dfe-3eb028aeeb78","","",false, this);
 
            IDSituationProjectAccepted = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("5b3c3b43-7de0-4cfa-8167-f1f245286944","","",false, this);
 
            SuffixCodeProjectBaseline = RPSControlFactory.CreateRPSTextBox<ParameterPROEntityView>("148e0038-eb1c-43d6-9ca7-22a39bd6de80","","",false, this);
 
            IDSituationProjectBaseline = RPSControlFactory.CreateRPSComboBox<ParameterPROEntityView>("c642acb5-fcd5-4449-873e-ccd542b9f882","","",false, this);
 
            WarningThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("1d989a38-3c45-4518-ad58-310fa0dac2c4","","",true, this);
 
            BlockingThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("cb1d8507-5b6c-4982-9ffd-17c6adce96f2","","",true, this);
 
            SendResponsibleMessage = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("0c09d4db-b3b8-42d1-b508-9a4357245ef1","","",true, this);
 
            MinimumLevelProd = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("38e39c8a-5092-4489-8034-00461640601d","","",true, this);
 
            MediumLevelProd = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("a64a0326-e32a-4f72-91f9-f9a4bfc57e3f","","",true, this);
 
            FromLowPriority = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("761e1262-8298-41cc-b8ed-58ffd38a97cb","","",false, this);
 
            ToPriorityLow = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("0415ab83-6bdb-40e0-affb-555645f91910","","",true, this);
 
            FromMediumPriority = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("9fb059cc-35ff-4870-ad12-8ac3bd41ee7c","","",false, this);
 
            ToPriorityMedium = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("1efa5d4f-2a24-4012-9074-0a7549363802","","",true, this);
 
            ToHighPriority = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPROEntityView>("862304f5-d5e9-4f13-ad98-40682866230b","","",false, this);
 
            NotifyEmployeeTechnical = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("e8b1d2d3-3dfb-4ef3-8238-00ab9668133f","","",true, this);
 
            NotifyEmployeeTechnicalTask = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("d955fa16-eabd-45fe-b167-eeba8364352a","","",true, this);
 
            NotifyEmployeeCommercial = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("da9adb79-2ec9-437b-91ac-812e6f7d716a","","",true, this);
 
            ShowCheckinCheckout = RPSControlFactory.CreateRPSCheckBox<ParameterPROEntityView>("72902612-8d27-41e8-9bd2-17a41925037d","","",true, this);
 
            CollectionInit params_ParameterNotifys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="61dcad77-3289-4388-a664-5a26d08a84b5",CSSSelectorGrid="",XPathGrid=""};
            ParameterNotifys = RPSControlFactory.RPSCreateCollectionWithGrid<ParameterNotifysCollectionEditor<ParameterPROEntityView,ParameterNotifyView>,ParameterPROEntityView,ParameterNotifyView>( params_ParameterNotifys,this,Screen.ParameterNotifyView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ParameterPROEntityView>( "","ul li[rpsid='f185c8e3-4ff3-44ba-8276-184e301c4c45']","",this);
 
            Notify = RPSControlFactory.CreateRPSSection<ParameterPROEntityView>( "","ul li[rpsid='d1842ac9-5c2a-4a41-91c8-4cd11b835efd']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<ParameterPROEntityView>( "","ul li[rpsid='c1a09682-bf09-4053-940e-a9dec462d44f']","",this);
 

        }
        public IRPSCheckbox<ParameterPROEntityView> ControlUser { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> OverrideDataSituationChange { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> PendingTime { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PercentCompleted { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> InternalCode { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDProjectType { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROWarningPriority { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> ManualPlanning { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROWarningType { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROTaskType { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> CalPriceSales { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSolutionType { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDHourTypeDefault { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> MaterialExitDefault { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROWarningSeverity { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PercentProfit { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> TimeUnitDefault { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationCreated { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationDismissed { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationWarningInitial { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationWarningFinal { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationTestInitial { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDPROSituationTestFinal { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDSituationMilestoneInitial { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDSituationMilestoneFinal { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> AutomaticCodification { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeGroup { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthGroup { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeEmployee { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthEmployee { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeTask { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthTask { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeMachine { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthMachine { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeMilestone { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthMilestone { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeTool { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthTool { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeMaterial { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthMaterial { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> PrecodeCostComponent { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> LengthCostComponent { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDCodingSerieProject { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDCodingSeriesWarning { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDCodingSeriesTest { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDCodingSeriesUsualTest { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> BlockedDateImputation { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> ImputationStyle { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> PendingTimeCalculation { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> EnabledImputationZero { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> EnabledNegative { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> WhoCanNegative { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> GenerateBaseLine { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> SuffixCodeProjectAccepted { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDSituationProjectAccepted { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> SuffixCodeProjectBaseline { get; set; } 
        public IRPSComboBox<ParameterPROEntityView> IDSituationProjectBaseline { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> WarningThreshold { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> BlockingThreshold { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> SendResponsibleMessage { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> MinimumLevelProd { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> MediumLevelProd { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> FromLowPriority { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> ToPriorityLow { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> FromMediumPriority { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> ToPriorityMedium { get; set; } 
        public IRPSTextBox<ParameterPROEntityView> ToHighPriority { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> NotifyEmployeeTechnical { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> NotifyEmployeeTechnicalTask { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> NotifyEmployeeCommercial { get; set; } 
        public IRPSCheckbox<ParameterPROEntityView> ShowCheckinCheckout { get; set; } 
        public ParameterNotifysCollectionEditor<ParameterPROEntityView,ParameterNotifyView> ParameterNotifys { get; set; } 
        public IRPSSection<ParameterPROEntityView> GeneralData { get; set; } 
        public IRPSSection<ParameterPROEntityView> Notify { get; set; } 
        public IRPSSection<ParameterPROEntityView> DPS { get; set; } 
        public ParameterPRO Screen { get; set; }
        public ParameterPROEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ParameterNotifysCollectionEditor<ParameterPROEntityView,ParameterNotifyView>:RPSCollectionEditor<ParameterPROEntityView,ParameterNotifyView> where ParameterPROEntityView : class, IView where ParameterNotifyView : class, IView
    {
        public  ParameterNotifysGridView<ParameterPROEntityView,ParameterNotifyView> GridView {get;set;}
    }
    public partial class ParameterNotifysGridView <ParameterPROEntityView,ParameterNotifyView> :  RPSGridView<ParameterPROEntityView,ParameterNotifyView> where ParameterPROEntityView : class, IView where ParameterNotifyView : class, IView
    {
        public ParameterNotifysGridView(ParameterPROEntityView currentView,ParameterNotifyView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<ParameterPROEntityView>("","#61dcad77-3289-4388-a664-5a26d08a84b5 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            CodRole = RPSControlFactory.CreateRPSGridComboBox<ParameterPROEntityView>("","#61dcad77-3289-4388-a664-5a26d08a84b5 .ag-row[role='row']@ROWINDEX [col-id='cCodRole']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ParameterPROEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<ParameterPROEntityView> CodRole { get; set; } 
                     
    }
 
    }
  
            
    public partial class ParameterNotifyView : View
    {
        public ParameterNotifyView(ParameterPRO screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ParameterNotifyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ParameterNotifyView,ParameterPROEntityView>( this,Screen.ParameterPROEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ParameterNotifyView,ParameterPROEntityView>( this,Screen.ParameterPROEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ParameterNotifyView,ParameterPROEntityView>( this,Screen.ParameterPROEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ParameterNotifyView>("f35ef094-bcb1-4e91-8dfe-7a8e487cd3f5","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<ParameterNotifyView>("3a5edeac-1d8d-4ec8-9a0d-3dd2861ca99b","","",false, this);
 

        }
        public IRPSButton<ParameterNotifyView> DeleteButton { get; set; } 
        public IRPSButton<ParameterNotifyView,ParameterPROEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ParameterNotifyView,ParameterPROEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ParameterNotifyView,ParameterPROEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ParameterNotifyView> CodUser { get; set; } 
        public IRPSComboBox<ParameterNotifyView> CodRole { get; set; } 
        public ParameterPRO Screen { get; set; }
        public ParameterNotifyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
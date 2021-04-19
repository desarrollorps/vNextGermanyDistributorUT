    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.StrategicIndicator
{
    //RPS VERSION 1.0.0.0
    public partial class StrategicIndicator:Screen
    {
        public StrategicIndicator():base()
        {
            this.URL = "bpm.strategicindicator";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StrategicIndicatorCollectionView  = new StrategicIndicatorCollectionView(this); 
            StrategicIndicatorEntityView  = new StrategicIndicatorEntityView(this); 
            StrategicIndicatorUserView  = new StrategicIndicatorUserView(this); 
            StrategicIndicatorCollectionView.InitializeControls(); 
            StrategicIndicatorEntityView.InitializeControls(); 
            StrategicIndicatorUserView.InitializeControls(); 
           
        }
      
            public StrategicIndicatorCollectionView StrategicIndicatorCollectionView {get; set; } 
            public StrategicIndicatorEntityView StrategicIndicatorEntityView {get; set; } 
            public StrategicIndicatorUserView StrategicIndicatorUserView {get; set; } 
    }
            
    public partial class StrategicIndicatorCollectionView : View
    {
        public StrategicIndicatorCollectionView(StrategicIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StrategicIndicatorCollectionView,StrategicIndicatorEntityView>( this,Screen.StrategicIndicatorEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "993a1b9c-fa1e-4490-bc8b-58efc8ec91d0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StrategicIndicatorCollectionView,StrategicIndicatorEntityView>( params_MainConsult,this,Screen.StrategicIndicatorEntityView);
 

        }
        public IRPSButton<StrategicIndicatorCollectionView,StrategicIndicatorEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StrategicIndicatorCollectionView,StrategicIndicatorEntityView> MainConsult { get; set; } 
        public StrategicIndicator Screen { get; set; }
        public StrategicIndicatorCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StrategicIndicatorEntityView : View
    {
        public StrategicIndicatorEntityView(StrategicIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StrategicIndicatorEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StrategicIndicatorEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StrategicIndicatorEntityView,StrategicIndicatorCollectionView>( this,Screen.StrategicIndicatorCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StrategicIndicatorEntityView,StrategicIndicatorCollectionView>( this,Screen.StrategicIndicatorCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("5dec957d-ae07-4507-9dba-c1d08612a7da","","",false, this);
 
            IDStrategicIndicatorGroup = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("abb442c3-cb63-4fd1-81c8-a2da05f742fc","","",false, this);
 
            IndicatorType = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorEntityView>("ec4f2a8c-a77b-4a54-9fdf-78178ab6b605","","",true, this);
 
            CompareType = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorEntityView>("44facd6b-99e6-4979-8cd7-d1b83f200185","","",true, this);
 
            ValueInterpretation = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorEntityView>("6be86bc0-8f34-4f94-ab86-8b235a314f70","","",true, this);
 
            MeasurementUnit = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorEntityView>("0fb8745b-b481-4c5c-bebb-13d4bcc46eb8","","",true, this);
 
            MeasurementUnitOther = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("a112ee7a-9db7-4ead-baaf-55fccd0fb93a","","",false, this);
 
            ComputationType = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorEntityView>("d7f3f7ac-f27f-4e5d-81cc-516666e293dc","","",true, this);
 
            IDAggregationMatrix = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("f4af6f3d-0c38-49d9-becf-36306d60e89d","","",false, this);
 
            IDWorkflow = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("b52b3fb5-f840-4a75-9f9a-83db0f2328aa","","",false, this);
 
            Periodicity = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("17110bdb-ab34-48a5-b853-04017f47f36a","","",false, this);
 
            UIMeasurementResponsible = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("45ef6686-b949-47d3-8cde-768dd62ee1b7","","",false, this);
 
            UIControlResponsible = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("450d4fe4-bfe4-44c9-80b9-c25983902d7e","","",false, this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("a5e6cf23-8b3b-447f-898c-9d8e8234f651","","",false, this);
 
            Source = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("fd6fb30a-fce1-4c68-83f9-fdf97ad9487e","","",false, this);
 
            Interpretation = RPSControlFactory.CreateRPSTextBox<StrategicIndicatorEntityView>("01d33df1-254e-4241-9d45-624711d954da","","",false, this);
 
            StrategicPlan = RPSControlFactory.CreateRPSComboBox<StrategicIndicatorEntityView>("ef45b98f-6ad9-4d18-901a-bbef9c77e96d","","",false, this);
 
            ControlUserRegister = RPSControlFactory.CreateRPSCheckBox<StrategicIndicatorEntityView>("0a8bc4b1-eb13-4080-b8d6-9418bd7827e7","","",true, this);
 
            CollectionInit params_StrategicIndicatorPeriodByIndicator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6672126-6236-4cad-90a1-170e3540e7b6",CSSSelectorGrid="",XPathGrid=""};
            StrategicIndicatorPeriodByIndicator = RPSControlFactory.RPSCreateCollectionWithGrid<StrategicIndicatorPeriodByIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>,StrategicIndicatorEntityView,StrategicIndicatorUserView>( params_StrategicIndicatorPeriodByIndicator,this,Screen.StrategicIndicatorUserView);
 
            CollectionInit params_InfluencedStrategicIndicator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9f010113-9008-4301-9c2f-3cad70166ffe",CSSSelectorGrid="",XPathGrid=""};
            InfluencedStrategicIndicator = RPSControlFactory.RPSCreateCollectionWithGrid<InfluencedStrategicIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>,StrategicIndicatorEntityView,StrategicIndicatorUserView>( params_InfluencedStrategicIndicator,this,Screen.StrategicIndicatorUserView);
 
            CollectionInit params_StrategicIndicatorUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d7cbeb40-ca36-48d3-94f1-05b9958bfafe",CSSSelectorGrid="",XPathGrid=""};
            StrategicIndicatorUsers = RPSControlFactory.RPSCreateCollectionWithGrid<StrategicIndicatorUsersCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>,StrategicIndicatorEntityView,StrategicIndicatorUserView>( params_StrategicIndicatorUsers,this,Screen.StrategicIndicatorUserView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<StrategicIndicatorEntityView>( "","ul li[rpsid='28c784d0-cb1e-40e9-ac4b-71bfe98f8a3b']","",this);
 
            Details = RPSControlFactory.CreateRPSSection<StrategicIndicatorEntityView>( "","ul li[rpsid='b2fa3cea-5990-49d6-ab0c-c946edd7b8cd']","",this);
 
            InfluencedBy = RPSControlFactory.CreateRPSSection<StrategicIndicatorEntityView>( "","ul li[rpsid='8bf08747-ffe5-47d0-8720-89d57e7f12a4']","",this);
 
            Data = RPSControlFactory.CreateRPSSection<StrategicIndicatorEntityView>( "","ul li[rpsid='56e1579f-dbdc-46ec-9309-42814b1e2045']","",this);
 
            Registry = RPSControlFactory.CreateRPSSection<StrategicIndicatorEntityView>( "","ul li[rpsid='86348593-4a5b-44c7-ad58-a06d6199cb0b']","",this);
 

        }
        public IRPSSaveButton<StrategicIndicatorEntityView> SaveButton { get; set; } 
        public IRPSButton<StrategicIndicatorEntityView> DeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorEntityView,StrategicIndicatorCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorEntityView,StrategicIndicatorCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> Description { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> IDStrategicIndicatorGroup { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> IndicatorType { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> CompareType { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> ValueInterpretation { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> MeasurementUnit { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> MeasurementUnitOther { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> ComputationType { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> IDAggregationMatrix { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> IDWorkflow { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> Periodicity { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> UIMeasurementResponsible { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> UIControlResponsible { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> Formula { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> Source { get; set; } 
        public IRPSTextBox<StrategicIndicatorEntityView> Interpretation { get; set; } 
        public IRPSComboBox<StrategicIndicatorEntityView> StrategicPlan { get; set; } 
        public IRPSCheckbox<StrategicIndicatorEntityView> ControlUserRegister { get; set; } 
        public StrategicIndicatorPeriodByIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> StrategicIndicatorPeriodByIndicator { get; set; } 
        public InfluencedStrategicIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> InfluencedStrategicIndicator { get; set; } 
        public StrategicIndicatorUsersCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> StrategicIndicatorUsers { get; set; } 
        public IRPSSection<StrategicIndicatorEntityView> GeneralData { get; set; } 
        public IRPSSection<StrategicIndicatorEntityView> Details { get; set; } 
        public IRPSSection<StrategicIndicatorEntityView> InfluencedBy { get; set; } 
        public IRPSSection<StrategicIndicatorEntityView> Data { get; set; } 
        public IRPSSection<StrategicIndicatorEntityView> Registry { get; set; } 
        public StrategicIndicator Screen { get; set; }
        public StrategicIndicatorEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StrategicIndicatorPeriodByIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>:RPSCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public  StrategicIndicatorPeriodByIndicatorGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> GridView {get;set;}
    }
    public partial class StrategicIndicatorPeriodByIndicatorGridView <StrategicIndicatorEntityView,StrategicIndicatorUserView> :  RPSGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public StrategicIndicatorPeriodByIndicatorGridView(StrategicIndicatorEntityView currentView,StrategicIndicatorUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StrategicIndicatorPeriod_TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorEntityView>("","#d6672126-6236-4cad-90a1-170e3540e7b6 .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_TargetValue']","",false, this.CurrentView);
 
            StrategicIndicatorPeriod_LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicIndicatorEntityView>("","#d6672126-6236-4cad-90a1-170e3540e7b6 .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_LimitValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StrategicIndicatorEntityView> StrategicIndicatorPeriod_TargetValue { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorEntityView> StrategicIndicatorPeriod_LimitValue { get; set; } 
                     
    }
 
        public partial class InfluencedStrategicIndicatorCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>:RPSCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public  InfluencedStrategicIndicatorGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> GridView {get;set;}
    }
    public partial class InfluencedStrategicIndicatorGridView <StrategicIndicatorEntityView,StrategicIndicatorUserView> :  RPSGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public InfluencedStrategicIndicatorGridView(StrategicIndicatorEntityView currentView,StrategicIndicatorUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InfluencedStrategicIndicator_Implication = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorEntityView>("","#9f010113-9008-4301-9c2f-3cad70166ffe .ag-row[role='row']@ROWINDEX [col-id='cInfluencedStrategicIndicator_Implication']","",false, this.CurrentView);
 
            InfluencedStrategicIndicator_Weight = RPSControlFactory.CreateRPSGridTextBox<StrategicIndicatorEntityView>("","#9f010113-9008-4301-9c2f-3cad70166ffe .ag-row[role='row']@ROWINDEX [col-id='cInfluencedStrategicIndicator_Weight']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StrategicIndicatorEntityView> InfluencedStrategicIndicator_Implication { get; set; } 
        public IRPSGridTextBox<StrategicIndicatorEntityView> InfluencedStrategicIndicator_Weight { get; set; } 
                     
    }
 
        public partial class StrategicIndicatorUsersCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView>:RPSCollectionEditor<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public  StrategicIndicatorUsersGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> GridView {get;set;}
    }
    public partial class StrategicIndicatorUsersGridView <StrategicIndicatorEntityView,StrategicIndicatorUserView> :  RPSGridView<StrategicIndicatorEntityView,StrategicIndicatorUserView> where StrategicIndicatorEntityView : class, IView where StrategicIndicatorUserView : class, IView
    {
        public StrategicIndicatorUsersGridView(StrategicIndicatorEntityView currentView,StrategicIndicatorUserView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridEnumComboBox<StrategicIndicatorEntityView>("","#d7cbeb40-ca36-48d3-94f1-05b9958bfafe .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<StrategicIndicatorEntityView> CodUser { get; set; } 
                     
    }
 
    }
  
            
    public partial class StrategicIndicatorUserView : View
    {
        public StrategicIndicatorUserView(StrategicIndicator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StrategicIndicatorUserView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StrategicIndicatorUserView,StrategicIndicatorEntityView>( this,Screen.StrategicIndicatorEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StrategicIndicatorUserView,StrategicIndicatorEntityView>( this,Screen.StrategicIndicatorEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StrategicIndicatorUserView,StrategicIndicatorEntityView>( this,Screen.StrategicIndicatorEntityView);
 
            CodUser = RPSControlFactory.CreateRPSEnumComboBox<StrategicIndicatorUserView>("e464f9e3-5b14-45c0-8a06-d77584ec51d0","","",true, this);
 

        }
        public IRPSButton<StrategicIndicatorUserView> DeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorUserView,StrategicIndicatorEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StrategicIndicatorUserView,StrategicIndicatorEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StrategicIndicatorUserView,StrategicIndicatorEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<StrategicIndicatorUserView> CodUser { get; set; } 
        public StrategicIndicator Screen { get; set; }
        public StrategicIndicatorUserView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
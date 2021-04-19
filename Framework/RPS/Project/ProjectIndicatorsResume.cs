    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectIndicatorsResume
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectIndicatorsResume:Screen
    {
        public ProjectIndicatorsResume():base()
        {
            this.URL = "project.projectindicatorsresume";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectIndicatorsResumeQueryView  = new ProjectIndicatorsResumeQueryView(this); 
            ProjectValuesForIndicatorView  = new ProjectValuesForIndicatorView(this); 
            CalculateAllProjectIndicatorsDialogView  = new CalculateAllProjectIndicatorsDialogView(this); 
            DetailValuesForProjectIndicatorDialogView  = new DetailValuesForProjectIndicatorDialogView(this); 
            ProjectIndicatorsResumeQueryView.InitializeControls(); 
            ProjectValuesForIndicatorView.InitializeControls(); 
            CalculateAllProjectIndicatorsDialogView.InitializeControls(); 
            DetailValuesForProjectIndicatorDialogView.InitializeControls(); 
           
        }
      
            public ProjectIndicatorsResumeQueryView ProjectIndicatorsResumeQueryView {get; set; } 
            public ProjectValuesForIndicatorView ProjectValuesForIndicatorView {get; set; } 
            public CalculateAllProjectIndicatorsDialogView CalculateAllProjectIndicatorsDialogView {get; set; } 
            public DetailValuesForProjectIndicatorDialogView DetailValuesForProjectIndicatorDialogView {get; set; } 
    }
            
    public partial class ProjectIndicatorsResumeQueryView : View
    {
        public ProjectIndicatorsResumeQueryView(ProjectIndicatorsResume screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<ProjectIndicatorsResumeQueryView>("5d15ab2e-fad7-4b27-9133-e8ddac1771ad","","",false, this);
 
            IDProjectSituation = RPSControlFactory.CreateRPSComboBox<ProjectIndicatorsResumeQueryView>("5670cc91-e388-4ad1-8d8f-83ab9f13f9d8","","",false, this);
 
            OnlyProjectsInRealization = RPSControlFactory.CreateRPSCheckBox<ProjectIndicatorsResumeQueryView>("4da1e228-8d81-4858-8cb2-28a4050982a6","","",false, this);
 
            IDProjectType = RPSControlFactory.CreateRPSComboBox<ProjectIndicatorsResumeQueryView>("b409613d-8384-48ba-953e-3ffbaa243b7c","","",false, this);
 
            IDProjects = RPSControlFactory.CreateRPSCollectionComboBox<ProjectIndicatorsResumeQueryView>("95f9ea83-cbd6-424b-8c57-16c004a4b3c4","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "ad1d213e-9fdb-4a2c-8820-9bc2a75da20c","","",this);
 
            OnlyMyProjects = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "8654f7d9-cc01-40b3-8fdf-39964af15f35","","",this);
 
            OnlyMyTeamProjects = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "163df50f-fb61-4c83-950e-9230fccbb72a","","",this);
 
            All1 = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "cb544165-b223-447d-b9ad-4f0aa1f8d874","","",this);
 
            Economic = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "9581c658-35d5-4404-80d8-6260b3afd424","","",this);
 
            InvertedTime = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "d02eb306-1191-412d-9161-ea584727c671","","",this);
 
            Term = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "48d67253-0dd9-4b15-b58c-0c02e9c8e260","","",this);
 
            Material = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "c00545a6-3ba7-4963-8689-8379d4599e00","","",this);
 
            Other = RPSControlFactory.CreateRPSOption<ProjectIndicatorsResumeQueryView>( "07a5986b-0e4b-4781-b566-7f678b423314","","",this);
 
            SetIndicatorInStudyCommand = RPSControlFactory.CreateRPSButton<ProjectIndicatorsResumeQueryView>( "bbed75f8-cee5-4850-82b9-8a51d686cec1","","",this);
 
            FinalizeIndicatorStudyCommand = RPSControlFactory.CreateRPSButton<ProjectIndicatorsResumeQueryView>( "b6164968-3a21-4f7c-892d-e58934f1c632","","",this);
 
            TotalNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("0182dfb7-9acd-4d44-b99a-dbc8ecd9d7e8","","",false, this);
 
            DesigningNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("193ef4f7-bc30-4e59-9cf0-32e8f3de52a5","","",false, this);
 
            RealizationNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("d008e878-d8f2-4bbf-8261-1c6e94f3e9a5","","",false, this);
 
            BlockedNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("6af14c08-0897-47cc-9653-c18ab230d89d","","",false, this);
 
            CanceledNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("aa19a641-681c-4b71-a38e-d09d7e5ed609","","",false, this);
 
            ClosedNumOfProjects = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("e3da5494-81fb-41d0-bae8-bba4d5f9feea","","",false, this);
 
            TotalCostOffered = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("6932f4cd-6bc3-4bb3-8ccd-82ffbbd6c3e0","","",false, this);
 
            TotalCostInitial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("c623960e-f1f5-4ed3-bd8a-5b6af4fdec9f","","",false, this);
 
            TotalCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("133ae3d4-7092-4ec9-9f8a-81254a95a8ed","","",false, this);
 
            TotalCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("b20521ea-79c8-4826-81f8-94cf15b7a9b6","","",false, this);
 
            TotalAmountInOrders = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("fb0248b7-03e0-4baa-a7eb-02088e335d44","","",false, this);
 
            TotalAmountInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("f0c5bd34-d3ff-4e9c-88f6-6bc6999c1e19","","",false, this);
 
            TotalAmountPendingInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("488b0ea0-2703-41e9-9419-dbc46005ee70","","",false, this);
 
            TotalHourEstimatedInitial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("c68f1b9d-6208-4415-b267-a1a1e3c44805","","",false, this);
 
            TotalHourEstimated = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("55a1d727-27a9-4fae-a6d2-22447aaa5440","","",false, this);
 
            TotalHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("82965b71-ab22-426b-b9bf-9efbe8fbe03e","","",false, this);
 
            TotalHourPending = RPSControlFactory.CreateRPSFormattedTextBox<ProjectIndicatorsResumeQueryView>("f92f4ad7-d26f-45ca-8108-f9cc57bb2aa6","","",false, this);
 
            SituationResumeCommandButton = RPSControlFactory.CreateRPSButton<ProjectIndicatorsResumeQueryView>( "b0984fa5-69b1-4d61-9e81-bcde0adf99b6","","",this);
 
            ProjectViewCommandButton = RPSControlFactory.CreateRPSButton<ProjectIndicatorsResumeQueryView>( "b0370eb7-2417-4a4f-b9a2-8db06ff8433f","","",this);
 
            CalculateAllProjectIndicatorsCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>("b8b9d0fd-49d4-4fa8-a5c8-c23e1dad07b4","","", this,Screen.CalculateAllProjectIndicatorsDialogView);
 
            CollectionInit params_GlobalViewIndicators = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="12cf35e1-06d5-482b-a321-7498b5d8ac89",CSSSelectorGrid="",XPathGrid=""};
            GlobalViewIndicators = RPSControlFactory.RPSCreateCollectionWithGrid<GlobalViewIndicatorsCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>,ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>( params_GlobalViewIndicators,this,Screen.CalculateAllProjectIndicatorsDialogView);
 
            CollectionInit params_ProjectIndicatorsByType = new CollectionInit(){IDDescriptor = "2074e426-cc34-4344-b1f8-2c7f3b65b0e0",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="34f70185-d92f-4e14-82a6-3b8c69ee8a72",CSSSelectorGrid="",XPathGrid=""};
            ProjectIndicatorsByType = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectIndicatorsByTypeCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>,ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>( params_ProjectIndicatorsByType,this,Screen.CalculateAllProjectIndicatorsDialogView);
 
            GlobalViewIndicators1 = RPSControlFactory.CreateRPSSection<ProjectIndicatorsResumeQueryView>( "","ul li[rpsid='2818e3e2-5839-4192-8d91-a2b81338c2a2']","",this);
 
            IndicatorsResume = RPSControlFactory.CreateRPSSection<ProjectIndicatorsResumeQueryView>( "","ul li[rpsid='2e4175f4-2c23-4de1-bac0-84ca462bf4ca']","",this);
 
            SelectedOneProjectResults = RPSControlFactory.CreateRPSSection<ProjectIndicatorsResumeQueryView>( "","ul li[rpsid='7afe180c-ec7e-4296-8d9c-7fa9edc72103']","",this);
 
            SituationResume = RPSControlFactory.CreateRPSSection<ProjectIndicatorsResumeQueryView>( "","ul li[rpsid='c237b377-2c58-4051-930c-8ff6d65ee189']","",this);
 

        }
        public IRPSComboBox<ProjectIndicatorsResumeQueryView> IDSite { get; set; } 
        public IRPSComboBox<ProjectIndicatorsResumeQueryView> IDProjectSituation { get; set; } 
        public IRPSCheckbox<ProjectIndicatorsResumeQueryView> OnlyProjectsInRealization { get; set; } 
        public IRPSComboBox<ProjectIndicatorsResumeQueryView> IDProjectType { get; set; } 
        public IRPSCollectionComboBox<ProjectIndicatorsResumeQueryView> IDProjects { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> All { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> OnlyMyProjects { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> OnlyMyTeamProjects { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> All1 { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> Economic { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> InvertedTime { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> Term { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> Material { get; set; } 
        public IRPSOption<ProjectIndicatorsResumeQueryView> Other { get; set; } 
        public IRPSButton<ProjectIndicatorsResumeQueryView> SetIndicatorInStudyCommand { get; set; } 
        public IRPSButton<ProjectIndicatorsResumeQueryView> FinalizeIndicatorStudyCommand { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> DesigningNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> RealizationNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> BlockedNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> CanceledNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> ClosedNumOfProjects { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalCostOffered { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalCostInitial { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalCostTheoric { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalCostReal { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalAmountInOrders { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalAmountInvoiced { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalAmountPendingInvoiced { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalHourEstimatedInitial { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalHourEstimated { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalHourReal { get; set; } 
        public IRPSTextBox<ProjectIndicatorsResumeQueryView> TotalHourPending { get; set; } 
        public IRPSButton<ProjectIndicatorsResumeQueryView> SituationResumeCommandButton { get; set; } 
        public IRPSButton<ProjectIndicatorsResumeQueryView> ProjectViewCommandButton { get; set; } 
        public IRPSButton<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> CalculateAllProjectIndicatorsCommandButton { get; set; } 
        public GlobalViewIndicatorsCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> GlobalViewIndicators { get; set; } 
        public ProjectIndicatorsByTypeCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> ProjectIndicatorsByType { get; set; } 
        public IRPSSection<ProjectIndicatorsResumeQueryView> GlobalViewIndicators1 { get; set; } 
        public IRPSSection<ProjectIndicatorsResumeQueryView> IndicatorsResume { get; set; } 
        public IRPSSection<ProjectIndicatorsResumeQueryView> SelectedOneProjectResults { get; set; } 
        public IRPSSection<ProjectIndicatorsResumeQueryView> SituationResume { get; set; } 
        public ProjectIndicatorsResume Screen { get; set; }
        public ProjectIndicatorsResumeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GlobalViewIndicatorsCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>:RPSCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> where ProjectIndicatorsResumeQueryView : class, IView where CalculateAllProjectIndicatorsDialogView : class, IView
    {
        public  GlobalViewIndicatorsGridView<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> GridView {get;set;}
    }
    public partial class GlobalViewIndicatorsGridView <ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> :  RPSGridView<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> where ProjectIndicatorsResumeQueryView : class, IView where CalculateAllProjectIndicatorsDialogView : class, IView
    {
        public GlobalViewIndicatorsGridView(ProjectIndicatorsResumeQueryView currentView,CalculateAllProjectIndicatorsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<ProjectIndicatorsResumeQueryView>("","#12cf35e1-06d5-482b-a321-7498b5d8ac89 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectIndicatorsResumeQueryView> Type { get; set; } 
                     
    }
 
        public partial class ProjectIndicatorsByTypeCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView>:RPSCollectionEditor<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> where ProjectIndicatorsResumeQueryView : class, IView where CalculateAllProjectIndicatorsDialogView : class, IView
    {
        public  ProjectIndicatorsByTypeGridView<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> GridView {get;set;}
    }
    public partial class ProjectIndicatorsByTypeGridView <ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> :  RPSGridView<ProjectIndicatorsResumeQueryView,CalculateAllProjectIndicatorsDialogView> where ProjectIndicatorsResumeQueryView : class, IView where CalculateAllProjectIndicatorsDialogView : class, IView
    {
        public ProjectIndicatorsByTypeGridView(ProjectIndicatorsResumeQueryView currentView,CalculateAllProjectIndicatorsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectIndicator_Type = RPSControlFactory.CreateRPSGridTextBox<ProjectIndicatorsResumeQueryView>("","#34f70185-d92f-4e14-82a6-3b8c69ee8a72 .ag-row[role='row']@ROWINDEX [col-id='cProjectIndicator_Type']","",false, this.CurrentView);
 
            HighAlertProjects = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectIndicatorsResumeQueryView>("","#34f70185-d92f-4e14-82a6-3b8c69ee8a72 .ag-row[role='row']@ROWINDEX [col-id='cHighAlertProjects']","",false, this.CurrentView);
 
            MediumAlertProjects = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectIndicatorsResumeQueryView>("","#34f70185-d92f-4e14-82a6-3b8c69ee8a72 .ag-row[role='row']@ROWINDEX [col-id='cMediumAlertProjects']","",false, this.CurrentView);
 
            InStudyAlertProjects = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectIndicatorsResumeQueryView>("","#34f70185-d92f-4e14-82a6-3b8c69ee8a72 .ag-row[role='row']@ROWINDEX [col-id='cInStudyAlertProjects']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectIndicatorsResumeQueryView> ProjectIndicator_Type { get; set; } 
        public IRPSGridTextBox<ProjectIndicatorsResumeQueryView> HighAlertProjects { get; set; } 
        public IRPSGridTextBox<ProjectIndicatorsResumeQueryView> MediumAlertProjects { get; set; } 
        public IRPSGridTextBox<ProjectIndicatorsResumeQueryView> InStudyAlertProjects { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectValuesForIndicatorView : View
    {
        public ProjectValuesForIndicatorView(ProjectIndicatorsResume screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SetIndicatorInStudyButton = RPSControlFactory.CreateRPSButton<ProjectValuesForIndicatorView>( "d75bb591-a2c2-4243-b0c2-87a7f11a4cdb","","",this);
 
            FinalizeInStudyButton = RPSControlFactory.CreateRPSButton<ProjectValuesForIndicatorView>( "3700bf94-aaff-4686-8e79-fdac08d51287","","",this);
 
            CollectionInit params_ValuesForProjectIndicator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ffc81d49-69c5-4201-9181-abc8289a4542",CSSSelectorGrid="",XPathGrid=""};
            ValuesForProjectIndicator = RPSControlFactory.RPSCreateCollectionWithGrid<ValuesForProjectIndicatorCollectionEditor<ProjectValuesForIndicatorView>,ProjectValuesForIndicatorView>( params_ValuesForProjectIndicator,this);
 

        }
        public IRPSButton<ProjectValuesForIndicatorView> SetIndicatorInStudyButton { get; set; } 
        public IRPSButton<ProjectValuesForIndicatorView> FinalizeInStudyButton { get; set; } 
        public ValuesForProjectIndicatorCollectionEditor<ProjectValuesForIndicatorView> ValuesForProjectIndicator { get; set; } 
        public ProjectIndicatorsResume Screen { get; set; }
        public ProjectValuesForIndicatorView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ValuesForProjectIndicatorCollectionEditor<ProjectValuesForIndicatorView>:RPSCollectionEditor<ProjectValuesForIndicatorView> where ProjectValuesForIndicatorView : class, IView
    {
        public  ValuesForProjectIndicatorGridView<ProjectValuesForIndicatorView> GridView {get;set;}
    }
    public partial class ValuesForProjectIndicatorGridView <ProjectValuesForIndicatorView> :  RPSGridView<ProjectValuesForIndicatorView> where ProjectValuesForIndicatorView : class, IView
    {
        public ValuesForProjectIndicatorGridView(ProjectValuesForIndicatorView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DetailValuesViewCommand = RPSControlFactory.CreateRPSGridButton<ProjectValuesForIndicatorView>( "","#ffc81d49-69c5-4201-9181-abc8289a4542 .ag-row[role='row']@ROWINDEX [col-id='cDetailValuesViewCommand']","",this.CurrentView);
 
            ProjectIndicatorValue_Value = RPSControlFactory.CreateRPSGridTextBox<ProjectValuesForIndicatorView>("","#ffc81d49-69c5-4201-9181-abc8289a4542 .ag-row[role='row']@ROWINDEX [col-id='cProjectIndicatorValue_Value']","",false, this.CurrentView);
 
            ValueDecimal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectValuesForIndicatorView>("","#ffc81d49-69c5-4201-9181-abc8289a4542 .ag-row[role='row']@ROWINDEX [col-id='cValueDecimal']","",false, this.CurrentView);
 
            ValueInteger = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectValuesForIndicatorView>("","#ffc81d49-69c5-4201-9181-abc8289a4542 .ag-row[role='row']@ROWINDEX [col-id='cValueInteger']","",false, this.CurrentView);
 
            ValueDateTime = RPSControlFactory.CreateRPSGridTextBox<ProjectValuesForIndicatorView>("","#ffc81d49-69c5-4201-9181-abc8289a4542 .ag-row[role='row']@ROWINDEX [col-id='cValueDateTime']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<ProjectValuesForIndicatorView> DetailValuesViewCommand { get; set; } 
        public IRPSGridTextBox<ProjectValuesForIndicatorView> ProjectIndicatorValue_Value { get; set; } 
        public IRPSGridTextBox<ProjectValuesForIndicatorView> ValueDecimal { get; set; } 
        public IRPSGridTextBox<ProjectValuesForIndicatorView> ValueInteger { get; set; } 
        public IRPSGridTextBox<ProjectValuesForIndicatorView> ValueDateTime { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalculateAllProjectIndicatorsDialogView : View
    {
        public CalculateAllProjectIndicatorsDialogView(ProjectIndicatorsResume screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProjectIndicator = RPSControlFactory.CreateRPSCollectionComboBox<CalculateAllProjectIndicatorsDialogView>("59ea8c62-afaa-420d-b3f6-ebb97ca751cd","","",false, this);
 
            OnlyProjectsInRealization = RPSControlFactory.CreateRPSCheckBox<CalculateAllProjectIndicatorsDialogView>("daeabc20-5a47-4c8b-b14c-11313407ef77","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<CalculateAllProjectIndicatorsDialogView>( "2e9a332a-3b2a-44b3-afd5-986c1386af85","","",this);
 
            OnlyMyProjects = RPSControlFactory.CreateRPSOption<CalculateAllProjectIndicatorsDialogView>( "1e1703f2-6495-44a4-be66-83de066b8a95","","",this);
 
            OnlyMyTeamProjects = RPSControlFactory.CreateRPSOption<CalculateAllProjectIndicatorsDialogView>( "e73d3b13-a697-423e-964c-cc434d7359dc","","",this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<CalculateAllProjectIndicatorsDialogView>("5da70cf8-faf3-4774-84dc-277d062e1948","","",false, this);
 

        }
        public IRPSCollectionComboBox<CalculateAllProjectIndicatorsDialogView> ProjectIndicator { get; set; } 
        public IRPSCheckbox<CalculateAllProjectIndicatorsDialogView> OnlyProjectsInRealization { get; set; } 
        public IRPSOption<CalculateAllProjectIndicatorsDialogView> All { get; set; } 
        public IRPSOption<CalculateAllProjectIndicatorsDialogView> OnlyMyProjects { get; set; } 
        public IRPSOption<CalculateAllProjectIndicatorsDialogView> OnlyMyTeamProjects { get; set; } 
        public IRPSCollectionComboBox<CalculateAllProjectIndicatorsDialogView> Project { get; set; } 
        public ProjectIndicatorsResume Screen { get; set; }
        public CalculateAllProjectIndicatorsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DetailValuesForProjectIndicatorDialogView : View
    {
        public DetailValuesForProjectIndicatorDialogView(ProjectIndicatorsResume screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DetailValuesForProjectIndicator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="27edd8d2-0327-4708-b5a9-8d31b5530e07",CSSSelectorGrid="",XPathGrid=""};
            DetailValuesForProjectIndicator = RPSControlFactory.RPSCreateCollectionWithGrid<DetailValuesForProjectIndicatorCollectionEditor<DetailValuesForProjectIndicatorDialogView>,DetailValuesForProjectIndicatorDialogView>( params_DetailValuesForProjectIndicator,this);
 

        }
        public DetailValuesForProjectIndicatorCollectionEditor<DetailValuesForProjectIndicatorDialogView> DetailValuesForProjectIndicator { get; set; } 
        public ProjectIndicatorsResume Screen { get; set; }
        public DetailValuesForProjectIndicatorDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DetailValuesForProjectIndicatorCollectionEditor<DetailValuesForProjectIndicatorDialogView>:RPSCollectionEditor<DetailValuesForProjectIndicatorDialogView> where DetailValuesForProjectIndicatorDialogView : class, IView
    {
        public  DetailValuesForProjectIndicatorGridView<DetailValuesForProjectIndicatorDialogView> GridView {get;set;}
    }
    public partial class DetailValuesForProjectIndicatorGridView <DetailValuesForProjectIndicatorDialogView> :  RPSGridView<DetailValuesForProjectIndicatorDialogView> where DetailValuesForProjectIndicatorDialogView : class, IView
    {
        public DetailValuesForProjectIndicatorGridView(DetailValuesForProjectIndicatorDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectIndicatorValueDetail_Value = RPSControlFactory.CreateRPSGridTextBox<DetailValuesForProjectIndicatorDialogView>("","#27edd8d2-0327-4708-b5a9-8d31b5530e07 .ag-row[role='row']@ROWINDEX [col-id='cProjectIndicatorValueDetail_Value']","",false, this.CurrentView);
 
            ValueDecimal = RPSControlFactory.CreateRPSGridFormattedTextBox<DetailValuesForProjectIndicatorDialogView>("","#27edd8d2-0327-4708-b5a9-8d31b5530e07 .ag-row[role='row']@ROWINDEX [col-id='cValueDecimal']","",false, this.CurrentView);
 
            ValueInteger = RPSControlFactory.CreateRPSGridFormattedTextBox<DetailValuesForProjectIndicatorDialogView>("","#27edd8d2-0327-4708-b5a9-8d31b5530e07 .ag-row[role='row']@ROWINDEX [col-id='cValueInteger']","",false, this.CurrentView);
 
            ValueDateTime = RPSControlFactory.CreateRPSGridTextBox<DetailValuesForProjectIndicatorDialogView>("","#27edd8d2-0327-4708-b5a9-8d31b5530e07 .ag-row[role='row']@ROWINDEX [col-id='cValueDateTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailValuesForProjectIndicatorDialogView> ProjectIndicatorValueDetail_Value { get; set; } 
        public IRPSGridTextBox<DetailValuesForProjectIndicatorDialogView> ValueDecimal { get; set; } 
        public IRPSGridTextBox<DetailValuesForProjectIndicatorDialogView> ValueInteger { get; set; } 
        public IRPSGridTextBox<DetailValuesForProjectIndicatorDialogView> ValueDateTime { get; set; } 
                     
    }
 
    }
  
    

}
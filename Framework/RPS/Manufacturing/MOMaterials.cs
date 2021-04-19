    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MOMaterials
{
    //RPS VERSION 1.0.0.0
    public partial class MOMaterials:Screen
    {
        public MOMaterials():base()
        {
            this.URL = "manufacturing.momaterials";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MOMaterialsQueryView  = new MOMaterialsQueryView(this); 
            MOMaterialsQueryView.InitializeControls(); 
           
        }
      
            public MOMaterialsQueryView MOMaterialsQueryView {get; set; } 
    }
            
    public partial class MOMaterialsQueryView : View
    {
        public MOMaterialsQueryView(MOMaterials screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MOMaterialsQueryView>("15d84b95-275f-4645-a0bf-669523c04e09","","",false, this);
 
            LstManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<MOMaterialsQueryView>("4d08c10c-a553-4aa8-a5bb-034b08c143ae","","",false, this);
 
            LstArticle = RPSControlFactory.CreateRPSCollectionComboBox<MOMaterialsQueryView>("49996dd4-5b27-42fc-ad2d-1c27847dd5de","","",false, this);
 
            PendingMaterialsOnly = RPSControlFactory.CreateRPSCheckBox<MOMaterialsQueryView>("1dcb6dac-1aa5-412d-acdf-998525a0f38e","","",false, this);
 
            LstManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<MOMaterialsQueryView>("bcaa2656-2787-4c27-9aa6-497e144e6648","","",false, this);
 
            ManufacturingOrderDateFrom = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("849cd35f-c7ab-45dc-ba0b-f6ae2926df69","","",false, this);
 
            ManufacturingOrderDateTo = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("e08ee0b8-d869-40bd-8667-4a2c8ee97ee4","","",false, this);
 
            LstArticleMOMaterial = RPSControlFactory.CreateRPSCollectionComboBox<MOMaterialsQueryView>("bebac065-4ab4-4e89-b5a3-e968339970fd","","",false, this);
 
            LstProject = RPSControlFactory.CreateRPSCollectionComboBox<MOMaterialsQueryView>("74494a3b-dbcb-4da1-ae72-a37dd1180fdf","","",false, this);
 
            MOTaskDateFrom = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("46ea7f60-41b2-4c68-8407-185bc36d0e1c","","",false, this);
 
            MOTaskDateTo = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("d4f7a499-ffa5-4253-8d96-6bef1914f4f9","","",false, this);
 
            ColorInfo = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("5af7113f-ffb2-4006-9b2a-257df0789ced","","",false, this);
 
            ColorPositive = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("a92ba347-eae2-4b55-9973-1b84179904c9","","",false, this);
 
            ColorNegative = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("907ff9c4-37cc-49ea-874d-f53a83a20444","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("86c8f6a6-be1b-4cf5-b3c5-9b65e57e0e29","","",false, this);
 
            ManufacturingOrderPlannedDate = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("d5c9a4b6-e046-4cc4-8559-e6c295bc5c78","","",false, this);
 
            eType = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialsQueryView>("c01b209d-94ae-478a-a98f-a60f936372ba","","",false, this);
 
            TaskPlannedDate = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("42f59906-2153-4696-936c-7e4eecd15401","","",false, this);
 
            Completed = RPSControlFactory.CreateRPSCheckBox<MOMaterialsQueryView>("72d3e671-6148-4fd0-9f1f-35fff80381cf","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<MOMaterialsQueryView>("82c2f344-bbc4-4237-918c-37d4f2a34ab7","","",false, this);
 
            CollectionInit params_MOMaterialsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="46156a59-b03c-4390-9974-632127c6dcd6",CSSSelectorGrid="",XPathGrid=""};
            MOMaterialsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MOMaterialsConsultCollectionEditor<MOMaterialsQueryView>,MOMaterialsQueryView>( params_MOMaterialsConsult,this);
 
            DPS = RPSControlFactory.CreateRPSSection<MOMaterialsQueryView>( "","ul li[rpsid='3e37b542-f29b-4beb-a052-499a553471c0']","",this);
 

        }
        public IRPSComboBox<MOMaterialsQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<MOMaterialsQueryView> LstManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<MOMaterialsQueryView> LstArticle { get; set; } 
        public IRPSCheckbox<MOMaterialsQueryView> PendingMaterialsOnly { get; set; } 
        public IRPSCollectionComboBox<MOMaterialsQueryView> LstManufacturingOrderSituation { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ManufacturingOrderDateFrom { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ManufacturingOrderDateTo { get; set; } 
        public IRPSCollectionComboBox<MOMaterialsQueryView> LstArticleMOMaterial { get; set; } 
        public IRPSCollectionComboBox<MOMaterialsQueryView> LstProject { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> MOTaskDateFrom { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> MOTaskDateTo { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ColorInfo { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ColorPositive { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ColorNegative { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> InternalCode { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> ManufacturingOrderPlannedDate { get; set; } 
        public IRPSComboBox<MOMaterialsQueryView> eType { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> TaskPlannedDate { get; set; } 
        public IRPSCheckbox<MOMaterialsQueryView> Completed { get; set; } 
        public IRPSTextBox<MOMaterialsQueryView> MatchCode { get; set; } 
        public MOMaterialsConsultCollectionEditor<MOMaterialsQueryView> MOMaterialsConsult { get; set; } 
        public IRPSSection<MOMaterialsQueryView> DPS { get; set; } 
        public MOMaterials Screen { get; set; }
        public MOMaterialsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOMaterialsConsultCollectionEditor<MOMaterialsQueryView>:RPSCollectionEditor<MOMaterialsQueryView> where MOMaterialsQueryView : class, IView
    {
        public  MOMaterialsConsultGridView<MOMaterialsQueryView> GridView {get;set;}
    }
    public partial class MOMaterialsConsultGridView <MOMaterialsQueryView> :  RPSGridView<MOMaterialsQueryView> where MOMaterialsQueryView : class, IView
    {
        public MOMaterialsConsultGridView(MOMaterialsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Color = RPSControlFactory.CreateRPSGridTextBox<MOMaterialsQueryView>("","#46156a59-b03c-4390-9974-632127c6dcd6 .ag-row[role='row']@ROWINDEX [col-id='cColor']","",false, this.CurrentView);
 
            Completed = RPSControlFactory.CreateRPSGridCheckBox<MOMaterialsQueryView>("","#46156a59-b03c-4390-9974-632127c6dcd6 .ag-row[role='row']@ROWINDEX [col-id='cCompleted']","",false, this.CurrentView);
 
            MatchCode = RPSControlFactory.CreateRPSGridTextBox<MOMaterialsQueryView>("","#46156a59-b03c-4390-9974-632127c6dcd6 .ag-row[role='row']@ROWINDEX [col-id='cMatchCode']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOMaterialsQueryView> Color { get; set; } 
        public IRPSGridCheckbox<MOMaterialsQueryView> Completed { get; set; } 
        public IRPSGridTextBox<MOMaterialsQueryView> MatchCode { get; set; } 
                     
    }
 
    }
  
    

}
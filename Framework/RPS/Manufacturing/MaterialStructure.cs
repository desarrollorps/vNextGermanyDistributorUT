    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MaterialStructure
{
    //RPS VERSION 1.0.0.0
    public partial class MaterialStructure:Screen
    {
        public MaterialStructure():base()
        {
            this.URL = "manufacturing.materialstructure";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaterialStructureQueryView  = new MaterialStructureQueryView(this); 
            MaterialStructureQueryView.InitializeControls(); 
           
        }
      
            public MaterialStructureQueryView MaterialStructureQueryView {get; set; } 
    }
            
    public partial class MaterialStructureQueryView : View
    {
        public MaterialStructureQueryView(MaterialStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MaterialStructureQueryView>("db067f80-1ac6-434e-a239-79dca84e1460","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<MaterialStructureQueryView>("374b5bf6-bc77-4c96-9fd9-93aef792d287","","",true, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<MaterialStructureQueryView>("9b27ea1a-570d-4a24-bee3-21c9488c2ef6","","",false, this);
 
            Route = RPSControlFactory.CreateRPSComboBox<MaterialStructureQueryView>("01cce473-bbe9-47d2-8df3-a72a65772b50","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MaterialStructureQueryView>("b1daf361-1c12-44e7-9acd-344ff3bb6bfa","","",false, this);
 
            OptionValueImmediate = RPSControlFactory.CreateRPSOption<MaterialStructureQueryView>( "986774dc-84f5-4857-9e28-b12529635868","","",this);
 
            OptionValueAll = RPSControlFactory.CreateRPSOption<MaterialStructureQueryView>( "a4982574-df8b-441f-97f7-3e3066e0bd4e","","",this);
 
            OptionValueUp = RPSControlFactory.CreateRPSOption<MaterialStructureQueryView>( "1dae3221-a4a5-4713-810e-3ed92ee427fc","","",this);
 
            Level = RPSControlFactory.CreateRPSFormattedTextBox<MaterialStructureQueryView>("4801a58f-8b12-4a65-8dab-a7426ea89e11","","",false, this);
 
            Level1 = RPSControlFactory.CreateRPSFormattedTextBox<MaterialStructureQueryView>("858b480e-057d-4e07-b24f-0f9744a00d56","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<MaterialStructureQueryView>( "00ceaa11-5a86-49e1-a15b-b462a6ecbec6","","",this);
 
            CollectionInit params_MaterialStructure = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e8ed136-5472-4a66-b79f-13040b1e876f",CSSSelectorGrid="",XPathGrid=""};
            MaterialStructure = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialStructureCollectionEditor<MaterialStructureQueryView>,MaterialStructureQueryView>( params_MaterialStructure,this);
 

        }
        public IRPSComboBox<MaterialStructureQueryView> Site { get; set; } 
        public IRPSComboBox<MaterialStructureQueryView> Article { get; set; } 
        public IRPSComboBox<MaterialStructureQueryView> Version { get; set; } 
        public IRPSComboBox<MaterialStructureQueryView> Route { get; set; } 
        public IRPSTextBox<MaterialStructureQueryView> Date { get; set; } 
        public IRPSOption<MaterialStructureQueryView> OptionValueImmediate { get; set; } 
        public IRPSOption<MaterialStructureQueryView> OptionValueAll { get; set; } 
        public IRPSOption<MaterialStructureQueryView> OptionValueUp { get; set; } 
        public IRPSTextBox<MaterialStructureQueryView> Level { get; set; } 
        public IRPSTextBox<MaterialStructureQueryView> Level1 { get; set; } 
        public IRPSButton<MaterialStructureQueryView> ReportCommandButton { get; set; } 
        public MaterialStructureCollectionEditor<MaterialStructureQueryView> MaterialStructure { get; set; } 
        public MaterialStructure Screen { get; set; }
        public MaterialStructureQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialStructureCollectionEditor<MaterialStructureQueryView>:RPSCollectionEditor<MaterialStructureQueryView> where MaterialStructureQueryView : class, IView
    {
        public  MaterialStructureGridView<MaterialStructureQueryView> GridView {get;set;}
    }
    public partial class MaterialStructureGridView <MaterialStructureQueryView> :  RPSGridView<MaterialStructureQueryView> where MaterialStructureQueryView : class, IView
    {
        public MaterialStructureGridView(MaterialStructureQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<MaterialStructureQueryView>("","#1e8ed136-5472-4a66-b79f-13040b1e876f .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaterialStructureQueryView> Level { get; set; } 
                     
    }
 
    }
  
    

}
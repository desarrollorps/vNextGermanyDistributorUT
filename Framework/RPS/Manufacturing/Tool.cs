    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Tool
{
    //RPS VERSION 1.0.0.0
    public partial class Tool:Screen
    {
        public Tool():base()
        {
            this.URL = "manufacturing.tool";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ToolCollectionView  = new ToolCollectionView(this); 
            ToolEntityView  = new ToolEntityView(this); 
            ToolCollectionView.InitializeControls(); 
            ToolEntityView.InitializeControls(); 
           
        }
      
            public ToolCollectionView ToolCollectionView {get; set; } 
            public ToolEntityView ToolEntityView {get; set; } 
    }
            
    public partial class ToolCollectionView : View
    {
        public ToolCollectionView(Tool screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ToolCollectionView,ToolEntityView>( this,Screen.ToolEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7a983ba1-dc26-46c9-ae0c-9a429f46253f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ToolCollectionView,ToolEntityView>( params_MainConsult,this,Screen.ToolEntityView);
 

        }
        public IRPSButton<ToolCollectionView,ToolEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ToolCollectionView,ToolEntityView> MainConsult { get; set; } 
        public Tool Screen { get; set; }
        public ToolCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ToolEntityView : View
    {
        public ToolEntityView(Tool screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ToolEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ToolEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ToolEntityView,ToolCollectionView>( this,Screen.ToolCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ToolEntityView,ToolCollectionView>( this,Screen.ToolCollectionView);
 
            CodTool = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("bfbf1c77-c35f-4cdc-aba1-9c9225bdd079","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("e7542757-4d30-41f5-b729-9d065441b765","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("c8566e6a-282b-4ec7-b7e5-555d84b9f540","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("eda4c43a-2bea-497e-9aa3-73681d3737e1","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("280dc037-24d0-4798-af6b-c10aa85d75ef","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<ToolEntityView>("15719e80-eac9-4bac-8197-b6e3db33ec33","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<ToolEntityView>("db913f2a-b6c4-4427-aa4d-18f7ae02e3a6","","",true, this);
 

        }
        public IRPSSaveButton<ToolEntityView> SaveButton { get; set; } 
        public IRPSButton<ToolEntityView> DeleteButton { get; set; } 
        public IRPSButton<ToolEntityView,ToolCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ToolEntityView,ToolCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ToolEntityView> CodTool { get; set; } 
        public IRPSTextBox<ToolEntityView> Description { get; set; } 
        public IRPSTextBox<ToolEntityView> InactivateDate { get; set; } 
        public IRPSComboBox<ToolEntityView> IDCalendar { get; set; } 
        public IRPSComboBox<ToolEntityView> IDSite { get; set; } 
        public IRPSCheckbox<ToolEntityView> BottleNeck { get; set; } 
        public IRPSTextBox<ToolEntityView> DisplayOrder { get; set; } 
        public Tool Screen { get; set; }
        public ToolEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
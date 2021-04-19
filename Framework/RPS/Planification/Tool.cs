    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Tool
{
    //RPS VERSION 1.0.0.0
    public partial class Tool:Screen
    {
        public Tool():base()
        {
            this.URL = "planification.tool";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c3334759-2234-4edf-aecd-d22d84df0b7d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodTool = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("41ca21c9-4b51-4330-b97a-7299822eea0a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("796c5fa1-7ee9-4d81-8baa-d8f9dd487d11","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("f2dfbf37-aa16-48a7-a7e3-5a9c03cf1c3c","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("bdd0891e-ba13-4b8f-8ad5-6964ebb38f14","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("a5b2fe88-c00c-4a07-b3f5-2cb98457cbb2","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<ToolEntityView>("2ca547d2-e2be-4788-85cc-3d2f57cffc42","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<ToolEntityView>("73b36d32-86c8-47b2-8a32-f8f6c1fec58e","","",true, this);
 

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
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Tool
{
    //RPS VERSION 1.0.0.0
    public partial class Tool:Screen
    {
        public Tool():base()
        {
            this.URL = "project.tool";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9e00d01b-4063-495a-b9c7-7837a0c75a5c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodTool = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("f3357914-1b34-4cbe-9f39-335dded6fff8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("c6f46379-395d-402b-832f-b98c04a8e9bf","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<ToolEntityView>("4e4636bf-aba0-4fa4-9e2c-5ec80e14f36f","","",false, this);
 
            IDCalendar = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("8ba97976-9aa3-4247-9e22-8f7973be8b08","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ToolEntityView>("2f6a3503-6489-4fd9-82a1-cd21714594b6","","",false, this);
 
            BottleNeck = RPSControlFactory.CreateRPSCheckBox<ToolEntityView>("732db06f-b437-47e2-893f-a431a895f3b3","","",true, this);
 
            DisplayOrder = RPSControlFactory.CreateRPSFormattedTextBox<ToolEntityView>("61a31f04-64bd-4397-a4a3-985fe1ac38c2","","",true, this);
 

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
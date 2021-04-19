    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.BaseCostYear
{
    //RPS VERSION 1.0.0.0
    public partial class BaseCostYear:Screen
    {
        public BaseCostYear():base()
        {
            this.URL = "manufacturing.basecostyear";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BaseCostYearView  = new BaseCostYearView(this); 
            AddRemoveResourcesDialogView  = new AddRemoveResourcesDialogView(this); 
            BaseCostYearView.InitializeControls(); 
            AddRemoveResourcesDialogView.InitializeControls(); 
           
        }
      
            public BaseCostYearView BaseCostYearView {get; set; } 
            public AddRemoveResourcesDialogView AddRemoveResourcesDialogView {get; set; } 
    }
            
    public partial class BaseCostYearView : View
    {
        public BaseCostYearView(BaseCostYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIYear = RPSControlFactory.CreateRPSFormattedTextBox<BaseCostYearView>("3081f6fb-aaa2-461a-a16b-48cc91b61f66","","",true, this);
 
            UIHourType = RPSControlFactory.CreateRPSCollectionComboBox<BaseCostYearView>("a19b1bbc-6675-42df-8fde-a77f331e5144","","",false, this);
 
            UIBaseCost = RPSControlFactory.CreateRPSCollectionComboBox<BaseCostYearView>("6538222e-902d-44e6-b346-4dfd4578eb3b","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("0ebaf5d9-a498-44bc-a500-225bb6ea3e07","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("374f8df3-64a6-4e67-9036-3a0afd9c7735","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("1c5e9fa5-138f-497c-bfdb-52964eaa8f29","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("ba2b8e22-96bd-4df6-bf35-676cf6608f09","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("f59dad71-e5c1-448b-abe2-6278b84dca34","","",false, this);
 
            UICostComponent = RPSControlFactory.CreateRPSCheckBox<BaseCostYearView>("f59e45f3-df98-48b4-955b-2dbfa84bfbc8","","",false, this);
 
            ColumnsCommand = RPSControlFactory.CreateRPSButton<BaseCostYearView>( "98a5f2ed-2e8e-4e65-876a-eb4d572277bd","","",this);
 
            SaveDataCommandButton = RPSControlFactory.CreateRPSButton<BaseCostYearView>( "11b00753-cad1-4ce8-a3ea-972769c530a7","","",this);
 
            AddResourcesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BaseCostYearView,AddRemoveResourcesDialogView>("9688b1f1-351c-4221-99a7-d6a699f8b88c","","", this,Screen.AddRemoveResourcesDialogView);
 
            RemoveResourcesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BaseCostYearView,AddRemoveResourcesDialogView>("ffdf0298-fd95-42b8-9a49-f6a8264a1aad","","", this,Screen.AddRemoveResourcesDialogView);
 

        }
        public IRPSTextBox<BaseCostYearView> UIYear { get; set; } 
        public IRPSCollectionComboBox<BaseCostYearView> UIHourType { get; set; } 
        public IRPSCollectionComboBox<BaseCostYearView> UIBaseCost { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UIQualify { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UIEmployee { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UIMachine { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UIMachineGroup { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UITool { get; set; } 
        public IRPSCheckbox<BaseCostYearView> UICostComponent { get; set; } 
        public IRPSButton<BaseCostYearView> ColumnsCommand { get; set; } 
        public IRPSButton<BaseCostYearView> SaveDataCommandButton { get; set; } 
        public IRPSButton<BaseCostYearView,AddRemoveResourcesDialogView> AddResourcesNavigationCommandButton { get; set; } 
        public IRPSButton<BaseCostYearView,AddRemoveResourcesDialogView> RemoveResourcesNavigationCommandButton { get; set; } 
        public BaseCostYear Screen { get; set; }
        public BaseCostYearView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddRemoveResourcesDialogView : View
    {
        public AddRemoveResourcesDialogView(BaseCostYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIETypeResource = RPSControlFactory.CreateRPSEnumComboBox<AddRemoveResourcesDialogView>("60855815-1808-48d7-bc6c-c76df4a16dd3","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("b0870977-82c0-4964-9853-eaa1062081af","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("9f8dce16-0011-4e15-9e71-4e51d9faa299","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("04194fae-268d-47f4-a978-49a143a30ca3","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("6a216471-779c-4d2a-b8cc-d9d566f27509","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("e6f89cff-29d1-4065-b9f4-6f718758ade5","","",false, this);
 
            UICostComponentSTR = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("d2680877-0a6c-45d5-936a-6aaf5a553e55","","",false, this);
 
            UIHourType = RPSControlFactory.CreateRPSComboBox<AddRemoveResourcesDialogView>("95a8d99a-6a59-4f3d-a6d9-0d9b40a9b502","","",true, this);
 

        }
        public IRPSComboBox<AddRemoveResourcesDialogView> UIETypeResource { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIQualify { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIEmployee { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIMachine { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIMachineGroup { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UITool { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UICostComponentSTR { get; set; } 
        public IRPSComboBox<AddRemoveResourcesDialogView> UIHourType { get; set; } 
        public BaseCostYear Screen { get; set; }
        public AddRemoveResourcesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
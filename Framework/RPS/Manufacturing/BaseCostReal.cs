    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.BaseCostReal
{
    //RPS VERSION 1.0.0.0
    public partial class BaseCostReal:Screen
    {
        public BaseCostReal():base()
        {
            this.URL = "manufacturing.basecostreal";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BaseCostRealView  = new BaseCostRealView(this); 
            AddRemoveResourcesDialogView  = new AddRemoveResourcesDialogView(this); 
            BaseCostRealView.InitializeControls(); 
            AddRemoveResourcesDialogView.InitializeControls(); 
           
        }
      
            public BaseCostRealView BaseCostRealView {get; set; } 
            public AddRemoveResourcesDialogView AddRemoveResourcesDialogView {get; set; } 
    }
            
    public partial class BaseCostRealView : View
    {
        public BaseCostRealView(BaseCostReal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIYear = RPSControlFactory.CreateRPSFormattedTextBox<BaseCostRealView>("b3ed23cb-06cb-4534-9317-5298238a6d6b","","",true, this);
 
            UIMonth = RPSControlFactory.CreateRPSFormattedTextBox<BaseCostRealView>("50c7b7e4-b726-4185-b906-3b1c8e91bf6c","","",true, this);
 
            UIHourType = RPSControlFactory.CreateRPSCollectionComboBox<BaseCostRealView>("effa8aa9-44d3-4786-b929-cbd15316f62d","","",false, this);
 
            UIBaseCost = RPSControlFactory.CreateRPSCollectionComboBox<BaseCostRealView>("f5b098c4-7ea8-4cf4-9d82-ffdfbf482e8a","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("167c9ebc-c52c-41eb-880c-a68053baf3d4","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("b191ea52-eb60-49a6-ac58-1b772d4eb69d","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("b3ead28d-f440-4ec5-a5f3-3334e02fab07","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("bb9bf517-ea3e-441a-8bf3-11d44aab2b23","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("edc516c4-6a14-4890-9d55-c66612aaa005","","",false, this);
 
            UICostComponent = RPSControlFactory.CreateRPSCheckBox<BaseCostRealView>("482e05c3-322f-46ad-b7e0-d1b30df6ff74","","",false, this);
 
            ColumnsCommand = RPSControlFactory.CreateRPSButton<BaseCostRealView>( "ab6a3d5e-3631-497b-90df-920536ce2f8e","","",this);
 
            SaveDataCommandButton = RPSControlFactory.CreateRPSButton<BaseCostRealView>( "e1a05a9b-7e3b-4db7-80ef-6e387a0115f0","","",this);
 
            AddResourcesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BaseCostRealView,AddRemoveResourcesDialogView>("dc8f8583-bb2a-4a0d-a5a3-62a5bba8f7c2","","", this,Screen.AddRemoveResourcesDialogView);
 
            RemoveResourcesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BaseCostRealView,AddRemoveResourcesDialogView>("bb0d74c8-7e04-4d46-8840-75de0171c8d2","","", this,Screen.AddRemoveResourcesDialogView);
 
            GetDataFromTheLastMonthCommandButton = RPSControlFactory.CreateRPSButton<BaseCostRealView>( "fe6dc945-2d36-460f-8270-9dfa1fb7b73d","","",this);
 
            GetDataFromBudgetCommandButton = RPSControlFactory.CreateRPSButton<BaseCostRealView>( "30d8c9eb-d9b9-4146-8c93-eb75db3443df","","",this);
 
            GetDataFromImputationCommandButton = RPSControlFactory.CreateRPSButton<BaseCostRealView>( "cbb7416c-409a-453e-9e26-a70db24021ed","","",this);
 

        }
        public IRPSTextBox<BaseCostRealView> UIYear { get; set; } 
        public IRPSTextBox<BaseCostRealView> UIMonth { get; set; } 
        public IRPSCollectionComboBox<BaseCostRealView> UIHourType { get; set; } 
        public IRPSCollectionComboBox<BaseCostRealView> UIBaseCost { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UIQualify { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UIEmployee { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UIMachine { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UIMachineGroup { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UITool { get; set; } 
        public IRPSCheckbox<BaseCostRealView> UICostComponent { get; set; } 
        public IRPSButton<BaseCostRealView> ColumnsCommand { get; set; } 
        public IRPSButton<BaseCostRealView> SaveDataCommandButton { get; set; } 
        public IRPSButton<BaseCostRealView,AddRemoveResourcesDialogView> AddResourcesNavigationCommandButton { get; set; } 
        public IRPSButton<BaseCostRealView,AddRemoveResourcesDialogView> RemoveResourcesNavigationCommandButton { get; set; } 
        public IRPSButton<BaseCostRealView> GetDataFromTheLastMonthCommandButton { get; set; } 
        public IRPSButton<BaseCostRealView> GetDataFromBudgetCommandButton { get; set; } 
        public IRPSButton<BaseCostRealView> GetDataFromImputationCommandButton { get; set; } 
        public BaseCostReal Screen { get; set; }
        public BaseCostRealView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddRemoveResourcesDialogView : View
    {
        public AddRemoveResourcesDialogView(BaseCostReal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eTypeResource = RPSControlFactory.CreateRPSEnumComboBox<AddRemoveResourcesDialogView>("f02c94bf-7cad-4538-8419-7c0eb975a8dc","","",false, this);
 
            UIQualify = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("b0870977-82c0-4964-9853-eaa1062081af","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("9f8dce16-0011-4e15-9e71-4e51d9faa299","","",false, this);
 
            UIMachine = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("04194fae-268d-47f4-a978-49a143a30ca3","","",false, this);
 
            UIMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("6a216471-779c-4d2a-b8cc-d9d566f27509","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("e6f89cff-29d1-4065-b9f4-6f718758ade5","","",false, this);
 
            UICostComponentSTR = RPSControlFactory.CreateRPSCollectionComboBox<AddRemoveResourcesDialogView>("d2680877-0a6c-45d5-936a-6aaf5a553e55","","",false, this);
 
            UIHourType = RPSControlFactory.CreateRPSComboBox<AddRemoveResourcesDialogView>("95a8d99a-6a59-4f3d-a6d9-0d9b40a9b502","","",true, this);
 

        }
        public IRPSComboBox<AddRemoveResourcesDialogView> eTypeResource { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIQualify { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIEmployee { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIMachine { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UIMachineGroup { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UITool { get; set; } 
        public IRPSCollectionComboBox<AddRemoveResourcesDialogView> UICostComponentSTR { get; set; } 
        public IRPSComboBox<AddRemoveResourcesDialogView> UIHourType { get; set; } 
        public BaseCostReal Screen { get; set; }
        public AddRemoveResourcesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
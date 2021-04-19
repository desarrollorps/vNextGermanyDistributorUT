    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.AutomaticInputOutput
{
    //RPS VERSION 1.0.0.0
    public partial class AutomaticInputOutput:Screen
    {
        public AutomaticInputOutput():base()
        {
            this.URL = "manufacturing.automaticinputoutput";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AutomaticInputOutputView  = new AutomaticInputOutputView(this); 
            AutomaticInputOutputView.InitializeControls(); 
           
        }
      
            public AutomaticInputOutputView AutomaticInputOutputView {get; set; } 
    }
            
    public partial class AutomaticInputOutputView : View
    {
        public AutomaticInputOutputView(AutomaticInputOutput screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<AutomaticInputOutputView>( "10fd8525-1428-4c83-bb90-3d735a112f4a","","",this);
 
            Group = RPSControlFactory.CreateRPSOption<AutomaticInputOutputView>( "003bdc9e-0f8c-4d35-9242-0ab069f31c07","","",this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<AutomaticInputOutputView>("64c96a01-4802-4986-8b87-ff90eb624146","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<AutomaticInputOutputView>("f7fc1056-7606-4abd-84ab-4a0231f2cf0d","","",false, this);
 
            CheckMaterialConsumption = RPSControlFactory.CreateRPSCheckBox<AutomaticInputOutputView>("2579b74f-1afe-43bf-8ac5-d0fc51440fda","","",false, this);
 
            CheckProductEntry = RPSControlFactory.CreateRPSCheckBox<AutomaticInputOutputView>("53040fa2-5e37-4e71-992f-644958ecacf5","","",false, this);
 
            CheckPendingQuantityOnly = RPSControlFactory.CreateRPSCheckBox<AutomaticInputOutputView>("030d415f-32a8-45aa-b6c2-8e845c52b38d","","",false, this);
 
            ManufacturingOrder1 = RPSControlFactory.CreateRPSComboBox<AutomaticInputOutputView>("9caab67e-f20d-451f-a85a-51779ea3feab","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSCollectionComboBox<AutomaticInputOutputView>("a388adef-54c4-4994-b7ad-3952b575c228","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<AutomaticInputOutputView>("f250bc8d-f32f-4b4d-811f-b5a7fa7cdd28","","",false, this);
 
            AddManufacturingOrderButton = RPSControlFactory.CreateRPSButton<AutomaticInputOutputView>( "fe23f38e-cce9-46c7-b8fd-25cc9e29e612","","",this);
 
            DeleteManufacturingOrderButton = RPSControlFactory.CreateRPSButton<AutomaticInputOutputView>( "dbcdce6a-fd51-48b1-88c3-2aac097c82f3","","",this);
 
            AddManufacturingOrderButton1 = RPSControlFactory.CreateRPSButton<AutomaticInputOutputView>( "3fb8fa16-4442-4457-a6d0-48ea2414830b","","",this);
 
            DeleteManufacturingOrderButton1 = RPSControlFactory.CreateRPSButton<AutomaticInputOutputView>( "c0b6333b-737a-483e-874c-6bad314946fd","","",this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<AutomaticInputOutputView>( "dd43f57e-bcb6-428a-86df-1fec34bbb4cd","","",this);
 
            CollectionInit params_GroupModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c815f2c2-7f2d-424e-a3bc-c35bdae31653",CSSSelectorGrid="",XPathGrid=""};
            GroupModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<GroupModelCollectionCollectionEditor<AutomaticInputOutputView>,AutomaticInputOutputView>( params_GroupModelCollection,this);
 
            CollectionInit params_MOTasksForInputOuput = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6f7ea9c1-9f93-48f5-ae03-058137e15dcb",CSSSelectorGrid="",XPathGrid=""};
            MOTasksForInputOuput = RPSControlFactory.RPSCreateCollectionWithGrid<MOTasksForInputOuputCollectionEditor<AutomaticInputOutputView>,AutomaticInputOutputView>( params_MOTasksForInputOuput,this);
 
            CollectionInit params_GroupModelCollection1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9c6683d-c458-4351-8f87-fa59db9afdf9",CSSSelectorGrid="",XPathGrid=""};
            GroupModelCollection1 = RPSControlFactory.RPSCreateCollectionWithGrid<GroupModelCollectionCollectionEditor<AutomaticInputOutputView>,AutomaticInputOutputView>( params_GroupModelCollection1,this);
 
            SectionManufacturingOrder = RPSControlFactory.CreateRPSSection<AutomaticInputOutputView>( "","ul li[rpsid='8c78ca30-8c59-4949-bf86-7f353de7f0bb']","",this);
 
            SectionGroup = RPSControlFactory.CreateRPSSection<AutomaticInputOutputView>( "","ul li[rpsid='30a6dbcb-e032-49f7-bcee-77b0c27fa667']","",this);
 

        }
        public IRPSOption<AutomaticInputOutputView> ManufacturingOrder { get; set; } 
        public IRPSOption<AutomaticInputOutputView> Group { get; set; } 
        public IRPSTextBox<AutomaticInputOutputView> DocumentNumber { get; set; } 
        public IRPSTextBox<AutomaticInputOutputView> ImputationDate { get; set; } 
        public IRPSCheckbox<AutomaticInputOutputView> CheckMaterialConsumption { get; set; } 
        public IRPSCheckbox<AutomaticInputOutputView> CheckProductEntry { get; set; } 
        public IRPSCheckbox<AutomaticInputOutputView> CheckPendingQuantityOnly { get; set; } 
        public IRPSComboBox<AutomaticInputOutputView> ManufacturingOrder1 { get; set; } 
        public IRPSCollectionComboBox<AutomaticInputOutputView> MOTask { get; set; } 
        public IRPSTextBox<AutomaticInputOutputView> Quantity { get; set; } 
        public IRPSButton<AutomaticInputOutputView> AddManufacturingOrderButton { get; set; } 
        public IRPSButton<AutomaticInputOutputView> DeleteManufacturingOrderButton { get; set; } 
        public IRPSButton<AutomaticInputOutputView> AddManufacturingOrderButton1 { get; set; } 
        public IRPSButton<AutomaticInputOutputView> DeleteManufacturingOrderButton1 { get; set; } 
        public IRPSButton<AutomaticInputOutputView> AcceptCommandButton { get; set; } 
        public GroupModelCollectionCollectionEditor<AutomaticInputOutputView> GroupModelCollection { get; set; } 
        public MOTasksForInputOuputCollectionEditor<AutomaticInputOutputView> MOTasksForInputOuput { get; set; } 
        public GroupModelCollectionCollectionEditor<AutomaticInputOutputView> GroupModelCollection1 { get; set; } 
        public IRPSSection<AutomaticInputOutputView> SectionManufacturingOrder { get; set; } 
        public IRPSSection<AutomaticInputOutputView> SectionGroup { get; set; } 
        public AutomaticInputOutput Screen { get; set; }
        public AutomaticInputOutputView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GroupModelCollectionCollectionEditor<AutomaticInputOutputView>:RPSCollectionEditor<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public  GroupModelCollectionManufacturingOrderView<AutomaticInputOutputView> ManufacturingOrderView {get;set;}
    }
    public partial class GroupModelCollectionManufacturingOrderView <AutomaticInputOutputView> :  RPSGridView<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public GroupModelCollectionManufacturingOrderView(AutomaticInputOutputView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<AutomaticInputOutputView>("","#c815f2c2-7f2d-424e-a3bc-c35bdae31653 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticInputOutputView>("","#c815f2c2-7f2d-424e-a3bc-c35bdae31653 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            BlankString = RPSControlFactory.CreateRPSGridTextBox<AutomaticInputOutputView>("","#c815f2c2-7f2d-424e-a3bc-c35bdae31653 .ag-row[role='row']@ROWINDEX [col-id='cBlankString']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AutomaticInputOutputView> ManufacturingOrder { get; set; } 
        public IRPSGridTextBox<AutomaticInputOutputView> Quantity { get; set; } 
        public IRPSGridTextBox<AutomaticInputOutputView> BlankString { get; set; } 
                     
    }
 
        public partial class GroupModelCollectionCollectionEditor<AutomaticInputOutputView>:RPSCollectionEditor<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public  GroupModelCollectionGridView<AutomaticInputOutputView> GridView {get;set;}
    }
    public partial class GroupModelCollectionGridView <AutomaticInputOutputView> :  RPSGridView<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public GroupModelCollectionGridView(AutomaticInputOutputView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SelectedTask = RPSControlFactory.CreateRPSGridCheckBox<AutomaticInputOutputView>("","#6f7ea9c1-9f93-48f5-ae03-058137e15dcb .ag-row[role='row']@ROWINDEX [col-id='cSelectedTask']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<AutomaticInputOutputView> SelectedTask { get; set; } 
                     
    }
 
        public partial class MOTasksForInputOuputCollectionEditor<AutomaticInputOutputView>:RPSCollectionEditor<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public  MOTasksForInputOuputGridView<AutomaticInputOutputView> GridView {get;set;}
    }
    public partial class MOTasksForInputOuputGridView <AutomaticInputOutputView> :  RPSGridView<AutomaticInputOutputView> where AutomaticInputOutputView : class, IView
    {
        public MOTasksForInputOuputGridView(AutomaticInputOutputView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SelectedTask = RPSControlFactory.CreateRPSGridCheckBox<AutomaticInputOutputView>("","#6f7ea9c1-9f93-48f5-ae03-058137e15dcb .ag-row[role='row']@ROWINDEX [col-id='cSelectedTask']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<AutomaticInputOutputView> SelectedTask { get; set; } 
                     
    }
 
    }
  
    

}
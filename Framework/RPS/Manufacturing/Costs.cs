    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Costs
{
    //RPS VERSION 1.0.0.0
    public partial class Costs:Screen
    {
        public Costs():base()
        {
            this.URL = "manufacturing.costs";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostsView  = new CostsView(this); 
            MachineCostView  = new MachineCostView(this); 
            MachineGroupCostView  = new MachineGroupCostView(this); 
            ToolCostView  = new ToolCostView(this); 
            CostsView.InitializeControls(); 
            MachineCostView.InitializeControls(); 
            MachineGroupCostView.InitializeControls(); 
            ToolCostView.InitializeControls(); 
           
        }
      
            public CostsView CostsView {get; set; } 
            public MachineCostView MachineCostView {get; set; } 
            public MachineGroupCostView MachineGroupCostView {get; set; } 
            public ToolCostView ToolCostView {get; set; } 
    }
            
    public partial class CostsView : View
    {
        public CostsView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<CostsView>("95544349-3c33-4229-81ec-b7ee75942a5c","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<CostsView>("70e94c73-2d14-45c1-8c48-3ab2034e4409","","",false, this);
 
            UIlsDHourType = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("5282340e-6b86-4c1a-a0c2-a427e22648b5","","",false, this);
 
            FilterByEmployee = RPSControlFactory.CreateRPSCheckBox<CostsView>("7ce0a135-38eb-4294-9b16-4e3567a63bbb","","",false, this);
 
            UIlsIDEmployee = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("10f82867-54b1-4578-8d6d-f66e98bddf1b","","",false, this);
 
            FilterByQualify = RPSControlFactory.CreateRPSCheckBox<CostsView>("58807365-dd05-49fb-a054-c776d447c426","","",false, this);
 
            UIlsIDQualify = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("efe7de33-fa69-4994-ab57-7f1ec9a7597c","","",false, this);
 
            FilterByMachine = RPSControlFactory.CreateRPSCheckBox<CostsView>("a45c9cb7-705a-49dc-8871-c0e251c137d1","","",false, this);
 
            UIlsIDMachine = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("4da9e74b-749c-4b7f-8046-3bbc5dc072d1","","",false, this);
 
            FilterByMachineGroup = RPSControlFactory.CreateRPSCheckBox<CostsView>("fdd1f639-fc4d-4258-bab2-9a43a9cea349","","",false, this);
 
            UIlsIDMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("8e382165-b9d3-47ca-98c8-a550ae590526","","",false, this);
 
            FilterByTool = RPSControlFactory.CreateRPSCheckBox<CostsView>("751486aa-caac-4a50-ba9e-3c109735dcfa","","",false, this);
 
            UIlsIDTool = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("09d20d6a-2984-4d57-94ed-733adbce8d2e","","",false, this);
 
            ExecuteQuery = RPSControlFactory.CreateRPSButton<CostsView>( "63d22e2b-4001-458e-a5f9-e57f213366f3","","",this);
 
            LinkNavigationCommandNewEmployeeCost = RPSControlFactory.CreateRPSButton<CostsView>( "27781337-fdac-4bfd-b4a3-0f149cfe920c","","",this);
 
            LinkNavigationCommandNewQualifyCost = RPSControlFactory.CreateRPSButton<CostsView>( "10b85e58-5b3d-48d0-8ab8-78169b6c7506","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<CostsView>( "a5bf3323-3e76-4acf-a993-ac11568c87a3","","",this);
 
            LinkNavigationCommandNewMachineGroupCost = RPSControlFactory.CreateRPSButton<CostsView>( "835a1910-df5e-4422-abbb-2839e746bcdf","","",this);
 
            LinkNavigationCommandNewToolCost = RPSControlFactory.CreateRPSButton<CostsView>( "5e8798e5-416e-4119-b8d0-fe991fea0554","","",this);
 
            CollectionInit params_EmployeeCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e76f238-28e4-47e1-bb58-7e1232d25dca",CSSSelectorGrid="",XPathGrid=""};
            EmployeeCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeCostConsultCollectionEditor<CostsView,ToolCostView>,CostsView,ToolCostView>( params_EmployeeCostConsult,this,Screen.ToolCostView);
 
            CollectionInit params_QualifyCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f4789f6c-1064-4509-a085-bfe5a85e7508",CSSSelectorGrid="",XPathGrid=""};
            QualifyCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<QualifyCostConsultCollectionEditor<CostsView,ToolCostView>,CostsView,ToolCostView>( params_QualifyCostConsult,this,Screen.ToolCostView);
 
            CollectionInit params_MachineCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9838593a-b4ae-4a1e-b1a7-93fd3af37524",CSSSelectorGrid="",XPathGrid=""};
            MachineCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MachineCostConsultCollectionEditor<CostsView,ToolCostView>,CostsView,ToolCostView>( params_MachineCostConsult,this,Screen.ToolCostView);
 
            CollectionInit params_MachineGroupCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="755a4a30-519b-48f2-a75b-be6cfe749452",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupCostConsultCollectionEditor<CostsView,ToolCostView>,CostsView,ToolCostView>( params_MachineGroupCostConsult,this,Screen.ToolCostView);
 
            CollectionInit params_ToolCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7c313a4e-19e7-45c6-b29d-1661c7f2efc2",CSSSelectorGrid="",XPathGrid=""};
            ToolCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ToolCostConsultCollectionEditor<CostsView,ToolCostView>,CostsView,ToolCostView>( params_ToolCostConsult,this,Screen.ToolCostView);
 
            EmployeeCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='3cf1a854-9701-484e-a02d-a8f853176de8']","",this);
 
            QualifyCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='6fddffa3-682a-46f2-a90f-7df21ee8d322']","",this);
 
            MachineCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='9af7c45a-637f-4b8e-bf36-e6671e8a9980']","",this);
 
            MachineGroupCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='0dca8cdc-9274-4dd3-a97e-763edb58c1bf']","",this);
 
            ToolCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='1a8c9cdc-2cca-4886-8ee8-e1252241790a']","",this);
 

        }
        public IRPSTextBox<CostsView> UIDateFrom { get; set; } 
        public IRPSTextBox<CostsView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsDHourType { get; set; } 
        public IRPSCheckbox<CostsView> FilterByEmployee { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDEmployee { get; set; } 
        public IRPSCheckbox<CostsView> FilterByQualify { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDQualify { get; set; } 
        public IRPSCheckbox<CostsView> FilterByMachine { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDMachine { get; set; } 
        public IRPSCheckbox<CostsView> FilterByMachineGroup { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDMachineGroup { get; set; } 
        public IRPSCheckbox<CostsView> FilterByTool { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDTool { get; set; } 
        public IRPSButton<CostsView> ExecuteQuery { get; set; } 
        public IRPSButton<CostsView> LinkNavigationCommandNewEmployeeCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationCommandNewQualifyCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationCommand { get; set; } 
        public IRPSButton<CostsView> LinkNavigationCommandNewMachineGroupCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationCommandNewToolCost { get; set; } 
        public EmployeeCostConsultCollectionEditor<CostsView,ToolCostView> EmployeeCostConsult { get; set; } 
        public QualifyCostConsultCollectionEditor<CostsView,ToolCostView> QualifyCostConsult { get; set; } 
        public MachineCostConsultCollectionEditor<CostsView,ToolCostView> MachineCostConsult { get; set; } 
        public MachineGroupCostConsultCollectionEditor<CostsView,ToolCostView> MachineGroupCostConsult { get; set; } 
        public ToolCostConsultCollectionEditor<CostsView,ToolCostView> ToolCostConsult { get; set; } 
        public IRPSSection<CostsView> EmployeeCost { get; set; } 
        public IRPSSection<CostsView> QualifyCost { get; set; } 
        public IRPSSection<CostsView> MachineCost { get; set; } 
        public IRPSSection<CostsView> MachineGroupCost { get; set; } 
        public IRPSSection<CostsView> ToolCost { get; set; } 
        public Costs Screen { get; set; }
        public CostsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EmployeeCostConsultCollectionEditor<CostsView,ToolCostView>:RPSCollectionEditor<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public  EmployeeCostConsultGridView<CostsView,ToolCostView> GridView {get;set;}
    }
    public partial class EmployeeCostConsultGridView <CostsView,ToolCostView> :  RPSGridView<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public EmployeeCostConsultGridView(CostsView currentView,ToolCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EmployeeCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#1e76f238-28e4-47e1-bb58-7e1232d25dca .ag-row[role='row']@ROWINDEX [col-id='cEmployeeCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> EmployeeCost_DateFrom { get; set; } 
                     
    }
 
        public partial class QualifyCostConsultCollectionEditor<CostsView,ToolCostView>:RPSCollectionEditor<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public  QualifyCostConsultGridView<CostsView,ToolCostView> GridView {get;set;}
    }
    public partial class QualifyCostConsultGridView <CostsView,ToolCostView> :  RPSGridView<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public QualifyCostConsultGridView(CostsView currentView,ToolCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            QualifyCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#f4789f6c-1064-4509-a085-bfe5a85e7508 .ag-row[role='row']@ROWINDEX [col-id='cQualifyCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> QualifyCost_DateFrom { get; set; } 
                     
    }
 
        public partial class MachineCostConsultCollectionEditor<CostsView,ToolCostView>:RPSCollectionEditor<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public  MachineCostConsultGridView<CostsView,ToolCostView> GridView {get;set;}
    }
    public partial class MachineCostConsultGridView <CostsView,ToolCostView> :  RPSGridView<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public MachineCostConsultGridView(CostsView currentView,ToolCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MachineCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#9838593a-b4ae-4a1e-b1a7-93fd3af37524 .ag-row[role='row']@ROWINDEX [col-id='cMachineCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> MachineCost_DateFrom { get; set; } 
                     
    }
 
        public partial class MachineGroupCostConsultCollectionEditor<CostsView,ToolCostView>:RPSCollectionEditor<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public  MachineGroupCostConsultGridView<CostsView,ToolCostView> GridView {get;set;}
    }
    public partial class MachineGroupCostConsultGridView <CostsView,ToolCostView> :  RPSGridView<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public MachineGroupCostConsultGridView(CostsView currentView,ToolCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MachineGroupCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#755a4a30-519b-48f2-a75b-be6cfe749452 .ag-row[role='row']@ROWINDEX [col-id='cMachineGroupCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> MachineGroupCost_DateFrom { get; set; } 
                     
    }
 
        public partial class ToolCostConsultCollectionEditor<CostsView,ToolCostView>:RPSCollectionEditor<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public  ToolCostConsultGridView<CostsView,ToolCostView> GridView {get;set;}
    }
    public partial class ToolCostConsultGridView <CostsView,ToolCostView> :  RPSGridView<CostsView,ToolCostView> where CostsView : class, IView where ToolCostView : class, IView
    {
        public ToolCostConsultGridView(CostsView currentView,ToolCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ToolCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#7c313a4e-19e7-45c6-b29d-1661c7f2efc2 .ag-row[role='row']@ROWINDEX [col-id='cToolCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> ToolCost_DateFrom { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineCostView : View
    {
        public MachineCostView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineCostView>( this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineCostView>("165ba8a7-a999-432e-9fdd-c7faf7515b2f","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineCostView>("906ab796-435b-45c6-8e3e-af9652c9154d","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineCostView>("92f38b3f-9d83-4c17-a045-230120ad7105","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostView>("e759622b-1c0d-4dbb-93f4-f8ba13f6619d","","",true, this);
 

        }
        public IRPSSaveButton<MachineCostView> SaveButton { get; set; } 
        public IRPSComboBox<MachineCostView> IDMachine { get; set; } 
        public IRPSComboBox<MachineCostView> IDHourType { get; set; } 
        public IRPSTextBox<MachineCostView> DateFrom { get; set; } 
        public IRPSTextBox<MachineCostView> CostPrice { get; set; } 
        public Costs Screen { get; set; }
        public MachineCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineGroupCostView : View
    {
        public MachineGroupCostView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineGroupCostView>( this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<MachineGroupCostView>("fef65728-7b5f-46a1-acda-ee555a791ead","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostView>("399c6b9e-bf31-42e5-94e8-917e9553a6c9","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineGroupCostView>("14756a56-63a3-43e9-af2d-2f219f07b56a","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostView>("b2031d79-e5a0-4332-8143-0dc5b37e98c6","","",true, this);
 

        }
        public IRPSSaveButton<MachineGroupCostView> SaveButton { get; set; } 
        public IRPSComboBox<MachineGroupCostView> IDMachineGroup { get; set; } 
        public IRPSComboBox<MachineGroupCostView> IDHourType { get; set; } 
        public IRPSTextBox<MachineGroupCostView> DateFrom { get; set; } 
        public IRPSTextBox<MachineGroupCostView> CostPrice { get; set; } 
        public Costs Screen { get; set; }
        public MachineGroupCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ToolCostView : View
    {
        public ToolCostView(Costs screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ToolCostView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ToolCostView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ToolCostView,CostsView>( this,Screen.CostsView);
 
            BackButton = RPSControlFactory.RPSBackButton<ToolCostView,CostsView>( this,Screen.CostsView);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ToolCostView>("f864f7cd-84ba-48ec-9a78-ddea8ad08d0d","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ToolCostView>("0ac9e61e-8ec6-445c-871a-515a82abaf2a","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ToolCostView>("813a7296-0afa-402c-a2bd-71f96a6cc4a7","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<ToolCostView>("80f3ff78-063f-4330-9a29-184d99f3bcdd","","",true, this);
 

        }
        public IRPSSaveButton<ToolCostView> SaveButton { get; set; } 
        public IRPSButton<ToolCostView> DeleteButton { get; set; } 
        public IRPSButton<ToolCostView,CostsView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ToolCostView,CostsView> BackButton { get; set; } 
        public IRPSComboBox<ToolCostView> IDTool { get; set; } 
        public IRPSComboBox<ToolCostView> IDHourType { get; set; } 
        public IRPSTextBox<ToolCostView> DateFrom { get; set; } 
        public IRPSTextBox<ToolCostView> CostPrice { get; set; } 
        public Costs Screen { get; set; }
        public ToolCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
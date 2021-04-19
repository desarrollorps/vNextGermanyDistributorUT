    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Costs
{
    //RPS VERSION 1.0.0.0
    public partial class Costs:Screen
    {
        public Costs():base()
        {
            this.URL = "project.costs";
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
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<CostsView>("ced80f23-2b24-455d-a073-a80fbc54760e","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<CostsView>("21785223-ac8d-4da1-8475-673dbfe7c14a","","",false, this);
 
            UIlsIDHourType = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("196019bb-19d6-4886-8808-199f2e3182d4","","",false, this);
 
            FilterByEmployee = RPSControlFactory.CreateRPSCheckBox<CostsView>("a4866608-150b-4dff-9247-811f0f96786c","","",false, this);
 
            UIlsIDEmployee = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("71f233ad-2614-4a7c-93dc-3d1d92ea6917","","",false, this);
 
            FilterByQualify = RPSControlFactory.CreateRPSCheckBox<CostsView>("ed6d6ca1-d7bc-4cb5-a3d9-e5cff77015f4","","",false, this);
 
            UIlsIDQualify = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("eb965f03-abfc-49d1-93db-fd2ef89d4253","","",false, this);
 
            FilterByMachine = RPSControlFactory.CreateRPSCheckBox<CostsView>("1e2611c6-0d69-434a-afc2-6b1346502306","","",false, this);
 
            UIlsIDMachine = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("25574485-8e5d-423b-bbb8-6527f098afe0","","",false, this);
 
            FilterByMachineGroup = RPSControlFactory.CreateRPSCheckBox<CostsView>("c64aef46-2bc8-41cb-8b0a-560030677554","","",false, this);
 
            UIlsIDMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("a8a8b1e5-d15e-4a94-9b99-4473797eb68f","","",false, this);
 
            FilterByTool = RPSControlFactory.CreateRPSCheckBox<CostsView>("f7cc91da-ef23-4756-b534-789bccd17696","","",false, this);
 
            UIlsIDTool = RPSControlFactory.CreateRPSCollectionComboBox<CostsView>("c983bcb7-8f77-4406-8298-7712ba4fa837","","",false, this);
 
            ExecuteQuery = RPSControlFactory.CreateRPSButton<CostsView>( "b6cc1c80-6d02-4638-9927-877d548d8b6c","","",this);
 
            LinkNavigationCommandNewEmployeeCost = RPSControlFactory.CreateRPSButton<CostsView>( "3878543e-130d-4821-880a-86e5a091a05b","","",this);
 
            LinkNavigationCommandNewQualifyCost = RPSControlFactory.CreateRPSButton<CostsView>( "2ffb79e8-c0e3-46d5-8c04-3e326f2039cb","","",this);
 
            LinkNavigationNewMachineCost = RPSControlFactory.CreateRPSButton<CostsView>( "7b8baf27-6b19-4113-87da-0867081a928b","","",this);
 
            LinkNavigationNewMachineGroupCost = RPSControlFactory.CreateRPSButton<CostsView>( "1912b8c7-7d00-47c8-b3f3-9dc5112393ea","","",this);
 
            LinkNavigationNewToolCost = RPSControlFactory.CreateRPSButton<CostsView>( "6469d6d2-925f-4c1a-9e26-a1c59f8f2249","","",this);
 
            CollectionInit params_EmployeeCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1b482269-5d87-4793-9365-d726831388b6",CSSSelectorGrid="",XPathGrid=""};
            EmployeeCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<EmployeeCostConsultCollectionEditor<CostsView>,CostsView>( params_EmployeeCostConsult,this);
 
            CollectionInit params_QualifyCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4be2c6bd-97a4-44e8-8cfe-0450589a5309",CSSSelectorGrid="",XPathGrid=""};
            QualifyCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<QualifyCostConsultCollectionEditor<CostsView>,CostsView>( params_QualifyCostConsult,this);
 
            CollectionInit params_MachineCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="61fff38b-5069-4a6b-9fed-32345865ac9b",CSSSelectorGrid="",XPathGrid=""};
            MachineCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MachineCostConsultCollectionEditor<CostsView>,CostsView>( params_MachineCostConsult,this);
 
            CollectionInit params_MachineGroupCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ce1da1a6-4429-4af4-b6fb-d95230551cf4",CSSSelectorGrid="",XPathGrid=""};
            MachineGroupCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MachineGroupCostConsultCollectionEditor<CostsView>,CostsView>( params_MachineGroupCostConsult,this);
 
            CollectionInit params_ToolCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a332a9d6-af53-4013-9c0c-ac18c9c003cc",CSSSelectorGrid="",XPathGrid=""};
            ToolCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ToolCostConsultCollectionEditor<CostsView>,CostsView>( params_ToolCostConsult,this);
 
            EmployeeCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='87e68aa8-180c-49ac-a745-a6368732188e']","",this);
 
            QualifyCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='47a57e34-190e-4e10-805b-3b673dae20de']","",this);
 
            MachineCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='75a3faa8-d718-482a-86b3-df5b6c3692c8']","",this);
 
            MachineGroupCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='7505df2c-6fc6-462c-9fff-a25bf8559699']","",this);
 
            ToolCost = RPSControlFactory.CreateRPSSection<CostsView>( "","ul li[rpsid='2befc757-5787-49a0-90de-1d23ba172fc2']","",this);
 

        }
        public IRPSTextBox<CostsView> UIDateFrom { get; set; } 
        public IRPSTextBox<CostsView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<CostsView> UIlsIDHourType { get; set; } 
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
        public IRPSButton<CostsView> LinkNavigationNewMachineCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationNewMachineGroupCost { get; set; } 
        public IRPSButton<CostsView> LinkNavigationNewToolCost { get; set; } 
        public EmployeeCostConsultCollectionEditor<CostsView> EmployeeCostConsult { get; set; } 
        public QualifyCostConsultCollectionEditor<CostsView> QualifyCostConsult { get; set; } 
        public MachineCostConsultCollectionEditor<CostsView> MachineCostConsult { get; set; } 
        public MachineGroupCostConsultCollectionEditor<CostsView> MachineGroupCostConsult { get; set; } 
        public ToolCostConsultCollectionEditor<CostsView> ToolCostConsult { get; set; } 
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
      
    
        public partial class EmployeeCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  EmployeeCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class EmployeeCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public EmployeeCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EmployeeCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#1b482269-5d87-4793-9365-d726831388b6 .ag-row[role='row']@ROWINDEX [col-id='cEmployeeCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> EmployeeCost_DateFrom { get; set; } 
                     
    }
 
        public partial class QualifyCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  QualifyCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class QualifyCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public QualifyCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            QualifyCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#4be2c6bd-97a4-44e8-8cfe-0450589a5309 .ag-row[role='row']@ROWINDEX [col-id='cQualifyCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> QualifyCost_DateFrom { get; set; } 
                     
    }
 
        public partial class MachineCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  MachineCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class MachineCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public MachineCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MachineCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#61fff38b-5069-4a6b-9fed-32345865ac9b .ag-row[role='row']@ROWINDEX [col-id='cMachineCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> MachineCost_DateFrom { get; set; } 
                     
    }
 
        public partial class MachineGroupCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  MachineGroupCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class MachineGroupCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public MachineGroupCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MachineGroupCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#ce1da1a6-4429-4af4-b6fb-d95230551cf4 .ag-row[role='row']@ROWINDEX [col-id='cMachineGroupCost_DateFrom']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostsView> MachineGroupCost_DateFrom { get; set; } 
                     
    }
 
        public partial class ToolCostConsultCollectionEditor<CostsView>:RPSCollectionEditor<CostsView> where CostsView : class, IView
    {
        public  ToolCostConsultGridView<CostsView> GridView {get;set;}
    }
    public partial class ToolCostConsultGridView <CostsView> :  RPSGridView<CostsView> where CostsView : class, IView
    {
        public ToolCostConsultGridView(CostsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ToolCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostsView>("","#a332a9d6-af53-4013-9c0c-ac18c9c003cc .ag-row[role='row']@ROWINDEX [col-id='cToolCost_DateFrom']","",false, this.CurrentView);
 

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
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineCostView>("6bded93b-bec6-4387-82a0-b318ac2c240f","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineCostView>("ab2146bd-4354-412d-9432-b43949d3ee6c","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineCostView>("ab9f5633-2c86-42a6-88ee-01709e2e929c","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostView>("0a40ec6d-11a8-4653-8be7-8da7ef22cea8","","",true, this);
 

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
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<MachineGroupCostView>("db57c0a5-0472-4c36-bc61-b5aef52fecdf","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineGroupCostView>("0faaec2d-0e27-4248-98f7-0caf3fd03926","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineGroupCostView>("6a32e30c-ff46-4926-9b45-53218287d33e","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineGroupCostView>("4477b611-25ee-454b-8de3-64c5b8273f77","","",true, this);
 

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
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ToolCostView>("a96308fb-3702-477e-a965-579f833eff61","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ToolCostView>("32786238-834c-4fd1-b9e8-91d379bc8d6e","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ToolCostView>("3dfeb33f-9edb-4b43-875d-3549390d17bf","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<ToolCostView>("e8eb6b9c-4839-4131-b946-481d95f24923","","",true, this);
 

        }
        public IRPSSaveButton<ToolCostView> SaveButton { get; set; } 
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
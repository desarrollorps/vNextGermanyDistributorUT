    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.MachineAssembly
{
    //RPS VERSION 1.0.0.0
    public partial class MachineAssembly:Screen
    {
        public MachineAssembly():base()
        {
            this.URL = "planification.machineassembly";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineAssemblyQueryView  = new MachineAssemblyQueryView(this); 
            MachineAssemblyQueryView.InitializeControls(); 
           
        }
      
            public MachineAssemblyQueryView MachineAssemblyQueryView {get; set; } 
    }
            
    public partial class MachineAssemblyQueryView : View
    {
        public MachineAssemblyQueryView(MachineAssembly screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckResourceEmployee = RPSControlFactory.CreateRPSCheckBox<MachineAssemblyQueryView>("44c0c5d8-d6c7-4821-894e-29d3c6541b82","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<MachineAssemblyQueryView>("4063b808-7fc7-4a9c-ab42-07c695d326c1","","",false, this);
 
            CheckResourceMachine = RPSControlFactory.CreateRPSCheckBox<MachineAssemblyQueryView>("107b4757-af40-4624-9378-b4b3a5f0508f","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<MachineAssemblyQueryView>("3959bb9a-032d-4acb-a804-c5f361fd9743","","",false, this);
 
            CheckResourceTool = RPSControlFactory.CreateRPSCheckBox<MachineAssemblyQueryView>("9b5e1f07-b207-4d6d-8e17-27c027c5f3ba","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<MachineAssemblyQueryView>("b1537083-37c6-4a37-b596-065f138f127d","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineAssemblyQueryView>("d224def3-79f5-41be-acc9-9b4cfa8ea597","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MachineAssemblyQueryView>("4de8ae5d-37d1-44d2-a9e2-dbb99ed5a48e","","",false, this);
 
            NewOptionOccupancy = RPSControlFactory.CreateRPSEnumComboBox<MachineAssemblyQueryView>("1cb24d2b-d232-4722-a03a-1ee52af03bb1","","",false, this);
 
            CollectionInit params_MachineAssemblyResourceOccupancy = new CollectionInit(){IDDescriptor = "ec182a6e-7d99-412f-8b9c-6f4e4b2e0533",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="acf1d100-0af1-4033-b755-8dc53ed56b5c",CSSSelectorGrid="",XPathGrid=""};
            MachineAssemblyResourceOccupancy = RPSControlFactory.RPSCreateCollectionWithGrid<MachineAssemblyResourceOccupancyCollectionEditor<MachineAssemblyQueryView>,MachineAssemblyQueryView>( params_MachineAssemblyResourceOccupancy,this);
 
            CollectionInit params_ResourceOccupancyDetail = new CollectionInit(){IDDescriptor = "ec182a6e-7d99-412f-8b9c-6f4e4b2e0533",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            ResourceOccupancyDetail = RPSControlFactory.RPSCreateCollection<MachineAssemblyQueryView>( params_ResourceOccupancyDetail,this);
 
            SectionData = RPSControlFactory.CreateRPSSection<MachineAssemblyQueryView>( "","ul li[rpsid='0eda0a31-28f6-415c-8546-efe99cc2218a']","",this);
 
            SectionChart = RPSControlFactory.CreateRPSSection<MachineAssemblyQueryView>( "","ul li[rpsid='cb09589a-ed11-46ee-bf63-161d280991df']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<MachineAssemblyQueryView>( "","ul li[rpsid='3fd55b0a-b820-4861-ba83-af00ab1dd56a']","",this);
 

        }
        public IRPSCheckbox<MachineAssemblyQueryView> CheckResourceEmployee { get; set; } 
        public IRPSCollectionComboBox<MachineAssemblyQueryView> Employee { get; set; } 
        public IRPSCheckbox<MachineAssemblyQueryView> CheckResourceMachine { get; set; } 
        public IRPSCollectionComboBox<MachineAssemblyQueryView> Machine { get; set; } 
        public IRPSCheckbox<MachineAssemblyQueryView> CheckResourceTool { get; set; } 
        public IRPSCollectionComboBox<MachineAssemblyQueryView> Tool { get; set; } 
        public IRPSTextBox<MachineAssemblyQueryView> DateFrom { get; set; } 
        public IRPSTextBox<MachineAssemblyQueryView> DateTo { get; set; } 
        public IRPSComboBox<MachineAssemblyQueryView> NewOptionOccupancy { get; set; } 
        public MachineAssemblyResourceOccupancyCollectionEditor<MachineAssemblyQueryView> MachineAssemblyResourceOccupancy { get; set; } 
        public IRPSCollectionEditor<MachineAssemblyQueryView> ResourceOccupancyDetail { get; set; } 
        public IRPSSection<MachineAssemblyQueryView> SectionData { get; set; } 
        public IRPSSection<MachineAssemblyQueryView> SectionChart { get; set; } 
        public IRPSSection<MachineAssemblyQueryView> Section { get; set; } 
        public MachineAssembly Screen { get; set; }
        public MachineAssemblyQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineAssemblyResourceOccupancyCollectionEditor<MachineAssemblyQueryView>:RPSCollectionEditor<MachineAssemblyQueryView> where MachineAssemblyQueryView : class, IView
    {
        public  MachineAssemblyResourceOccupancyGridView<MachineAssemblyQueryView> GridView {get;set;}
    }
    public partial class MachineAssemblyResourceOccupancyGridView <MachineAssemblyQueryView> :  RPSGridView<MachineAssemblyQueryView> where MachineAssemblyQueryView : class, IView
    {
        public MachineAssemblyResourceOccupancyGridView(MachineAssemblyQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<MachineAssemblyQueryView>("","#acf1d100-0af1-4033-b755-8dc53ed56b5c .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MachineAssemblyQueryView> Date { get; set; } 
                     
    }
 
    }
  
    

}
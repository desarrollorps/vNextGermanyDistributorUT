    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.CostUpdate
{
    //RPS VERSION 1.0.0.0
    public partial class CostUpdate:Screen
    {
        public CostUpdate():base()
        {
            this.URL = "project.costupdate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostUpdateView  = new CostUpdateView(this); 
            CostUpdateView.InitializeControls(); 
           
        }
      
            public CostUpdateView CostUpdateView {get; set; } 
    }
            
    public partial class CostUpdateView : View
    {
        public CostUpdateView(CostUpdate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Machine = RPSControlFactory.CreateRPSOption<CostUpdateView>( "cb1edb30-af15-4208-9cf1-03225a0d76f9","","",this);
 
            MachineGroup = RPSControlFactory.CreateRPSOption<CostUpdateView>( "8ec55bba-57a7-4a7c-8564-3ac8a69e5195","","",this);
 
            Employee = RPSControlFactory.CreateRPSOption<CostUpdateView>( "dea3336d-edc3-4a86-81ab-655ec36d8f53","","",this);
 
            Qualify = RPSControlFactory.CreateRPSOption<CostUpdateView>( "a388e5fb-e4dd-473c-85f3-ea68c7967686","","",this);
 
            Tool = RPSControlFactory.CreateRPSOption<CostUpdateView>( "46949f4f-2397-41fe-85c2-a14d1c1a0a97","","",this);
 
            All = RPSControlFactory.CreateRPSOption<CostUpdateView>( "89fe942a-1df7-4d8f-8c67-a8b4008ae354","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<CostUpdateView>( "7a5dbd1d-36b9-47ce-a92a-59971e99e60e","","",this);
 
            lsIDMachine = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("37af3a8b-0601-4681-be9e-f588a28bd3e4","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<CostUpdateView>( "18eb1e94-42d3-440c-adad-ec274754a339","","",this);
 
            Duplicate = RPSControlFactory.CreateRPSOption<CostUpdateView>( "c74dce3c-e329-4246-9b19-3eef4145a749","","",this);
 
            DateSource = RPSControlFactory.CreateRPSTextBox<CostUpdateView>("e7dbdfa2-de70-4f74-a69f-12f561543d25","","",false, this);
 
            DateTarget = RPSControlFactory.CreateRPSTextBox<CostUpdateView>("99d0dce3-c97b-447a-8f7f-fd5e7062920e","","",false, this);
 
            Fix = RPSControlFactory.CreateRPSOption<CostUpdateView>( "5d501ac4-4fdf-4e40-a8fd-717aeb7a235d","","",this);
 
            Percent = RPSControlFactory.CreateRPSOption<CostUpdateView>( "70ae919e-f058-42e3-8bb8-e69ae7b98475","","",this);
 
            Coste = RPSControlFactory.CreateRPSFormattedTextBox<CostUpdateView>("8c7c9a1f-ea99-43c8-9859-462b714012bf","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "000f16ef-268d-4036-9c5f-b80103694c45","","",this);
 
            Selection1 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "0c046437-054b-46ff-9d5b-ee7cb8b845f3","","",this);
 
            lsIDHourType = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("8b6eef7a-28bf-49af-bd73-b43da84998d7","","",false, this);
 
            All2 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "6726a77d-90bf-4dbe-92fc-67474dbd567f","","",this);
 
            Selection2 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "bedf52df-1bc1-443d-900e-06c1b7fd5083","","",this);
 
            lsIDMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("e6b11868-a4fc-4458-a61c-17449e3167e4","","",false, this);
 
            All3 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "aad61be9-2727-4478-b103-30ab306f0d11","","",this);
 
            Selection3 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "49eeabba-40cc-4a45-b63b-821311537a5b","","",this);
 
            lsIDEmployee = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("bcdd4751-8b65-4d06-b984-4a6c6231edc4","","",false, this);
 
            All4 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "93e54465-1ad4-41e1-9d63-8e209f9c3548","","",this);
 
            Selection4 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "879db9dc-124d-47c5-9d4e-ac282b9dcacb","","",this);
 
            lsIDQualify = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("7901cd5e-bc1a-4b2a-9955-92478ba82f7a","","",false, this);
 
            All5 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "78c38ac4-a788-4eec-bbfd-dd35ba5d6751","","",this);
 
            Selection5 = RPSControlFactory.CreateRPSOption<CostUpdateView>( "a2d9adc2-a998-4d2f-9ab5-be94ebc95d74","","",this);
 
            lsIDTool = RPSControlFactory.CreateRPSCollectionComboBox<CostUpdateView>("0a8aef5e-dc55-46e0-b80c-b54ab035791c","","",false, this);
 

        }
        public IRPSOption<CostUpdateView> Machine { get; set; } 
        public IRPSOption<CostUpdateView> MachineGroup { get; set; } 
        public IRPSOption<CostUpdateView> Employee { get; set; } 
        public IRPSOption<CostUpdateView> Qualify { get; set; } 
        public IRPSOption<CostUpdateView> Tool { get; set; } 
        public IRPSOption<CostUpdateView> All { get; set; } 
        public IRPSOption<CostUpdateView> Selection { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDMachine { get; set; } 
        public IRPSOption<CostUpdateView> Update { get; set; } 
        public IRPSOption<CostUpdateView> Duplicate { get; set; } 
        public IRPSTextBox<CostUpdateView> DateSource { get; set; } 
        public IRPSTextBox<CostUpdateView> DateTarget { get; set; } 
        public IRPSOption<CostUpdateView> Fix { get; set; } 
        public IRPSOption<CostUpdateView> Percent { get; set; } 
        public IRPSTextBox<CostUpdateView> Coste { get; set; } 
        public IRPSOption<CostUpdateView> All1 { get; set; } 
        public IRPSOption<CostUpdateView> Selection1 { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDHourType { get; set; } 
        public IRPSOption<CostUpdateView> All2 { get; set; } 
        public IRPSOption<CostUpdateView> Selection2 { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDMachineGroup { get; set; } 
        public IRPSOption<CostUpdateView> All3 { get; set; } 
        public IRPSOption<CostUpdateView> Selection3 { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDEmployee { get; set; } 
        public IRPSOption<CostUpdateView> All4 { get; set; } 
        public IRPSOption<CostUpdateView> Selection4 { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDQualify { get; set; } 
        public IRPSOption<CostUpdateView> All5 { get; set; } 
        public IRPSOption<CostUpdateView> Selection5 { get; set; } 
        public IRPSCollectionComboBox<CostUpdateView> lsIDTool { get; set; } 
        public CostUpdate Screen { get; set; }
        public CostUpdateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
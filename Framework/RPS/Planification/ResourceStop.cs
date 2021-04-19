    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ResourceStop
{
    //RPS VERSION 1.0.0.0
    public partial class ResourceStop:Screen
    {
        public ResourceStop():base()
        {
            this.URL = "planification.resourcestop";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ResourceStopVMCollectionView  = new ResourceStopVMCollectionView(this); 
            GenerateResourceStopMassiveDialogView  = new GenerateResourceStopMassiveDialogView(this); 
            ResourceStopView  = new ResourceStopView(this); 
            ResourceStopVMCollectionView.InitializeControls(); 
            GenerateResourceStopMassiveDialogView.InitializeControls(); 
            ResourceStopView.InitializeControls(); 
           
        }
      
            public ResourceStopVMCollectionView ResourceStopVMCollectionView {get; set; } 
            public GenerateResourceStopMassiveDialogView GenerateResourceStopMassiveDialogView {get; set; } 
            public ResourceStopView ResourceStopView {get; set; } 
    }
            
    public partial class ResourceStopVMCollectionView : View
    {
        public ResourceStopVMCollectionView(ResourceStop screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ResourceStopVMCollectionView>("65fb7385-5a45-4cdf-8718-30bbbac7664b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ResourceStopVMCollectionView>("1dea28a7-f6b4-496d-a3ca-d7518af1c1d8","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ResourceStopVMCollectionView>("4b8da21d-96d5-4e16-b8f5-59311a53ea05","","",false, this);
 
            CheckResourceEmployee = RPSControlFactory.CreateRPSCheckBox<ResourceStopVMCollectionView>("82482af8-214a-4013-bf0d-766d32e7da58","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<ResourceStopVMCollectionView>("0b9ec491-7c0a-4da8-83c6-f0efff3c5df8","","",false, this);
 
            CheckResourceMachine = RPSControlFactory.CreateRPSCheckBox<ResourceStopVMCollectionView>("95872356-7869-4bec-b79f-1cdd335b0702","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<ResourceStopVMCollectionView>("a75fc05f-7c69-4051-b296-060b0755133f","","",false, this);
 
            CheckTool = RPSControlFactory.CreateRPSCheckBox<ResourceStopVMCollectionView>("1fa921dc-896b-44e5-8324-422fe1442af6","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<ResourceStopVMCollectionView>("3456239b-d2d7-457d-ad3b-8f0ef1193d64","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ResourceStopVMCollectionView>( "eb9bee7a-ead9-4985-85f1-ad09009c3019","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ResourceStopVMCollectionView>( "6be5f7df-deaf-4c24-abdd-02666fca9267","","",this);
 
            CollectionInit params_ResourceStopQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f44f1ac9-c554-44d7-a55a-ecdb9756306c",CSSSelectorGrid="",XPathGrid=""};
            ResourceStopQuery = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceStopQueryCollectionEditor<ResourceStopVMCollectionView,ResourceStopView>,ResourceStopVMCollectionView,ResourceStopView>( params_ResourceStopQuery,this,Screen.ResourceStopView);
 

        }
        public IRPSComboBox<ResourceStopVMCollectionView> Site { get; set; } 
        public IRPSTextBox<ResourceStopVMCollectionView> DateFrom { get; set; } 
        public IRPSTextBox<ResourceStopVMCollectionView> DateTo { get; set; } 
        public IRPSCheckbox<ResourceStopVMCollectionView> CheckResourceEmployee { get; set; } 
        public IRPSCollectionComboBox<ResourceStopVMCollectionView> Employee { get; set; } 
        public IRPSCheckbox<ResourceStopVMCollectionView> CheckResourceMachine { get; set; } 
        public IRPSCollectionComboBox<ResourceStopVMCollectionView> Machine { get; set; } 
        public IRPSCheckbox<ResourceStopVMCollectionView> CheckTool { get; set; } 
        public IRPSCollectionComboBox<ResourceStopVMCollectionView> Tool { get; set; } 
        public IRPSButton<ResourceStopVMCollectionView> DeleteCommandButton { get; set; } 
        public IRPSButton<ResourceStopVMCollectionView> LinkNavigationCommandButton { get; set; } 
        public ResourceStopQueryCollectionEditor<ResourceStopVMCollectionView,ResourceStopView> ResourceStopQuery { get; set; } 
        public ResourceStop Screen { get; set; }
        public ResourceStopVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ResourceStopQueryCollectionEditor<ResourceStopVMCollectionView,ResourceStopView>:RPSCollectionEditor<ResourceStopVMCollectionView,ResourceStopView> where ResourceStopVMCollectionView : class, IView where ResourceStopView : class, IView
    {
        public  ResourceStopQueryGridView<ResourceStopVMCollectionView,ResourceStopView> GridView {get;set;}
    }
    public partial class ResourceStopQueryGridView <ResourceStopVMCollectionView,ResourceStopView> :  RPSGridView<ResourceStopVMCollectionView,ResourceStopView> where ResourceStopVMCollectionView : class, IView where ResourceStopView : class, IView
    {
        public ResourceStopQueryGridView(ResourceStopVMCollectionView currentView,ResourceStopView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ResourceType = RPSControlFactory.CreateRPSGridEnumComboBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cResourceType']","",true, this.CurrentView);
 
            Resource = RPSControlFactory.CreateRPSGridComboBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cResource']","",false, this.CurrentView);
 
            IDStopType = RPSControlFactory.CreateRPSGridComboBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cIDStopType']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            TimeDateFrom = RPSControlFactory.CreateRPSGridTextBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cTimeDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            TimeDateTo = RPSControlFactory.CreateRPSGridTextBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cTimeDateTo']","",false, this.CurrentView);
 
            RedirectWF = RPSControlFactory.CreateRPSGridCheckBox<ResourceStopVMCollectionView>("","#f44f1ac9-c554-44d7-a55a-ecdb9756306c .ag-row[role='row']@ROWINDEX [col-id='cRedirectWF']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ResourceStopVMCollectionView> ResourceType { get; set; } 
        public IRPSGridComboBox<ResourceStopVMCollectionView> Resource { get; set; } 
        public IRPSGridComboBox<ResourceStopVMCollectionView> IDStopType { get; set; } 
        public IRPSGridTextBox<ResourceStopVMCollectionView> DateFrom { get; set; } 
        public IRPSGridTextBox<ResourceStopVMCollectionView> TimeDateFrom { get; set; } 
        public IRPSGridTextBox<ResourceStopVMCollectionView> DateTo { get; set; } 
        public IRPSGridTextBox<ResourceStopVMCollectionView> TimeDateTo { get; set; } 
        public IRPSGridCheckbox<ResourceStopVMCollectionView> RedirectWF { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateResourceStopMassiveDialogView : View
    {
        public GenerateResourceStopMassiveDialogView(ResourceStop screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<GenerateResourceStopMassiveDialogView>("1131d21c-4541-41ec-a8a7-2e8e378e6cbc","","",false, this);
 
            StopType = RPSControlFactory.CreateRPSComboBox<GenerateResourceStopMassiveDialogView>("a5e3d56b-0e93-4e6a-94cd-a82e52c654c3","","",false, this);
 
            CheckResourceEmployee = RPSControlFactory.CreateRPSCheckBox<GenerateResourceStopMassiveDialogView>("9beeab16-dd19-453e-b0ac-9ec1c374cf08","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<GenerateResourceStopMassiveDialogView>("60b60deb-91ee-4eeb-b373-b1f26924d7a8","","",false, this);
 
            CheckResourceMachine = RPSControlFactory.CreateRPSCheckBox<GenerateResourceStopMassiveDialogView>("ef0db603-f351-4288-a351-aa36bd8aaccc","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<GenerateResourceStopMassiveDialogView>("78a15373-74e5-4c35-9ea7-55ba8ad1b3b0","","",false, this);
 
            CheckTool = RPSControlFactory.CreateRPSCheckBox<GenerateResourceStopMassiveDialogView>("64d04e7b-1feb-4c3f-a14d-91018d47e7ca","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<GenerateResourceStopMassiveDialogView>("f43c9c91-b91a-4784-bfef-9425ec656b14","","",false, this);
 
            RedirectWF = RPSControlFactory.CreateRPSCheckBox<GenerateResourceStopMassiveDialogView>("f8272959-b24d-415a-8f8d-fb70864dbb9c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<GenerateResourceStopMassiveDialogView>("3aec3772-56eb-4042-b1cb-12367ddcfd20","","",false, this);
 
            TimeDateFrom = RPSControlFactory.CreateRPSTextBox<GenerateResourceStopMassiveDialogView>("8db67eff-0b53-4f96-99f3-7457b94ae022","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<GenerateResourceStopMassiveDialogView>("771368a2-dc76-4134-a1dc-6688ce7d1dab","","",false, this);
 
            TimeDateTo = RPSControlFactory.CreateRPSTextBox<GenerateResourceStopMassiveDialogView>("c49a61c3-0c57-4bba-96aa-2f8b53c23871","","",false, this);
 
            MassiveResourceStop = RPSControlFactory.CreateRPSButton<GenerateResourceStopMassiveDialogView>( "6ea6c236-8fc1-4446-88d6-5f36a477ccf7","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<GenerateResourceStopMassiveDialogView>( "52ef293a-fb9c-4067-8f73-033459e30ada","","",this);
 

        }
        public IRPSComboBox<GenerateResourceStopMassiveDialogView> Site { get; set; } 
        public IRPSComboBox<GenerateResourceStopMassiveDialogView> StopType { get; set; } 
        public IRPSCheckbox<GenerateResourceStopMassiveDialogView> CheckResourceEmployee { get; set; } 
        public IRPSCollectionComboBox<GenerateResourceStopMassiveDialogView> Employee { get; set; } 
        public IRPSCheckbox<GenerateResourceStopMassiveDialogView> CheckResourceMachine { get; set; } 
        public IRPSCollectionComboBox<GenerateResourceStopMassiveDialogView> Machine { get; set; } 
        public IRPSCheckbox<GenerateResourceStopMassiveDialogView> CheckTool { get; set; } 
        public IRPSCollectionComboBox<GenerateResourceStopMassiveDialogView> Tool { get; set; } 
        public IRPSCheckbox<GenerateResourceStopMassiveDialogView> RedirectWF { get; set; } 
        public IRPSTextBox<GenerateResourceStopMassiveDialogView> DateFrom { get; set; } 
        public IRPSTextBox<GenerateResourceStopMassiveDialogView> TimeDateFrom { get; set; } 
        public IRPSTextBox<GenerateResourceStopMassiveDialogView> DateTo { get; set; } 
        public IRPSTextBox<GenerateResourceStopMassiveDialogView> TimeDateTo { get; set; } 
        public IRPSButton<GenerateResourceStopMassiveDialogView> MassiveResourceStop { get; set; } 
        public IRPSButton<GenerateResourceStopMassiveDialogView> LinkNavigationCommand { get; set; } 
        public ResourceStop Screen { get; set; }
        public GenerateResourceStopMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ResourceStopView : View
    {
        public ResourceStopView(ResourceStop screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ResourceStopView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ResourceStopView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ResourceStopView,ResourceStopVMCollectionView>( this,Screen.ResourceStopVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ResourceStopView,ResourceStopVMCollectionView>( this,Screen.ResourceStopVMCollectionView);
 
            ResourceType = RPSControlFactory.CreateRPSEnumComboBox<ResourceStopView>("07f901f4-e133-49a8-8e13-eaaa3fc9bd54","","",true, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ResourceStopView>("49bfd7b9-eb33-4000-a35f-5d746eac354f","","",false, this);
 
            IDResourceMachine = RPSControlFactory.CreateRPSComboBox<ResourceStopView>("ac285dd5-8ad8-43cc-acf2-433af3aba1af","","",false, this);
 
            IDResourceTool = RPSControlFactory.CreateRPSComboBox<ResourceStopView>("61a9d625-45a5-4eb8-8d4b-c74cdd5cb3cd","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<ResourceStopView>("6b841858-cd64-44f2-b057-4ae4dbb7702a","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ResourceStopView>("66a863e4-3986-4408-9f53-65fcd1b7cf46","","",true, this);
 
            TimeDateFrom = RPSControlFactory.CreateRPSTextBox<ResourceStopView>("2ac030b6-47de-4c82-9fc2-3cb484bad6fc","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ResourceStopView>("b808ffcd-28a1-4a44-b427-76672e4e08f3","","",true, this);
 
            TimeDateTo = RPSControlFactory.CreateRPSTextBox<ResourceStopView>("b2093773-b8c1-4e0c-9978-454d28649b6c","","",false, this);
 

        }
        public IRPSSaveButton<ResourceStopView> SaveButton { get; set; } 
        public IRPSButton<ResourceStopView> DeleteButton { get; set; } 
        public IRPSButton<ResourceStopView,ResourceStopVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ResourceStopView,ResourceStopVMCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ResourceStopView> ResourceType { get; set; } 
        public IRPSComboBox<ResourceStopView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ResourceStopView> IDResourceMachine { get; set; } 
        public IRPSComboBox<ResourceStopView> IDResourceTool { get; set; } 
        public IRPSComboBox<ResourceStopView> IDStopType { get; set; } 
        public IRPSTextBox<ResourceStopView> DateFrom { get; set; } 
        public IRPSTextBox<ResourceStopView> TimeDateFrom { get; set; } 
        public IRPSTextBox<ResourceStopView> DateTo { get; set; } 
        public IRPSTextBox<ResourceStopView> TimeDateTo { get; set; } 
        public ResourceStop Screen { get; set; }
        public ResourceStopView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
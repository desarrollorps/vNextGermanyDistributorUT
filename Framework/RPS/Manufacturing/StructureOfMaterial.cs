    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.StructureOfMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class StructureOfMaterial:Screen
    {
        public StructureOfMaterial():base()
        {
            this.URL = "manufacturing.structureofmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StructureOfMaterialView  = new StructureOfMaterialView(this); 
            StructureOfMaterialView.InitializeControls(); 
           
        }
      
            public StructureOfMaterialView StructureOfMaterialView {get; set; } 
    }
            
    public partial class StructureOfMaterialView : View
    {
        public StructureOfMaterialView(StructureOfMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<StructureOfMaterialView>("2d4d6aa1-f5ac-4e2b-90ca-07b112c33215","","",true, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<StructureOfMaterialView>("5ad9239d-2618-417b-9f7c-142500d842b3","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<StructureOfMaterialView>("fb46051a-a334-4f15-b71a-7e3876cfc6e8","","",false, this);
 
            UsingProject = RPSControlFactory.CreateRPSCheckBox<StructureOfMaterialView>("498b8970-a539-481c-b916-92f3f002d4b9","","",false, this);
 
            Immediate = RPSControlFactory.CreateRPSOption<StructureOfMaterialView>( "59b26429-716b-4721-83f0-37345081786d","","",this);
 
            Final = RPSControlFactory.CreateRPSOption<StructureOfMaterialView>( "a78cb775-535e-43d2-b658-b0e28c983485","","",this);
 
            Total = RPSControlFactory.CreateRPSOption<StructureOfMaterialView>( "fdf4b273-5306-40c5-9c50-834accebf1cc","","",this);
 
            ExecuteConsultCommand = RPSControlFactory.CreateRPSButton<StructureOfMaterialView>( "c0bda097-440b-4b81-864e-53e78077cdea","","",this);
 
            CollectionInit params_ImmediateMaterialOfStructure = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a82d671b-d514-4f73-8c11-69a2b3087f87",CSSSelectorGrid="",XPathGrid=""};
            ImmediateMaterialOfStructure = RPSControlFactory.RPSCreateCollectionWithGrid<ImmediateMaterialOfStructureCollectionEditor<StructureOfMaterialView>,StructureOfMaterialView>( params_ImmediateMaterialOfStructure,this);
 
            CollectionInit params_FinalMaterialOfStructure = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e94e11a4-4d48-4b39-8813-a3fb5d39ab94",CSSSelectorGrid="",XPathGrid=""};
            FinalMaterialOfStructure = RPSControlFactory.RPSCreateCollectionWithGrid<FinalMaterialOfStructureCollectionEditor<StructureOfMaterialView>,StructureOfMaterialView>( params_FinalMaterialOfStructure,this);
 
            CollectionInit params_ProjectMaterialOfStructure = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7da869bf-652d-4fc6-9601-5347d35cfb68",CSSSelectorGrid="",XPathGrid=""};
            ProjectMaterialOfStructure = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectMaterialOfStructureCollectionEditor<StructureOfMaterialView>,StructureOfMaterialView>( params_ProjectMaterialOfStructure,this);
 
            SectionStructure = RPSControlFactory.CreateRPSSection<StructureOfMaterialView>( "","ul li[rpsid='e6aaeb79-bf1e-4ece-82db-0b55e5ac5bcb']","",this);
 
            SectionProject = RPSControlFactory.CreateRPSSection<StructureOfMaterialView>( "","ul li[rpsid='523dc5c8-8868-41f4-a614-c90500860e4f']","",this);
 

        }
        public IRPSComboBox<StructureOfMaterialView> Site { get; set; } 
        public IRPSComboBox<StructureOfMaterialView> Article { get; set; } 
        public IRPSTextBox<StructureOfMaterialView> Date { get; set; } 
        public IRPSCheckbox<StructureOfMaterialView> UsingProject { get; set; } 
        public IRPSOption<StructureOfMaterialView> Immediate { get; set; } 
        public IRPSOption<StructureOfMaterialView> Final { get; set; } 
        public IRPSOption<StructureOfMaterialView> Total { get; set; } 
        public IRPSButton<StructureOfMaterialView> ExecuteConsultCommand { get; set; } 
        public ImmediateMaterialOfStructureCollectionEditor<StructureOfMaterialView> ImmediateMaterialOfStructure { get; set; } 
        public FinalMaterialOfStructureCollectionEditor<StructureOfMaterialView> FinalMaterialOfStructure { get; set; } 
        public ProjectMaterialOfStructureCollectionEditor<StructureOfMaterialView> ProjectMaterialOfStructure { get; set; } 
        public IRPSSection<StructureOfMaterialView> SectionStructure { get; set; } 
        public IRPSSection<StructureOfMaterialView> SectionProject { get; set; } 
        public StructureOfMaterial Screen { get; set; }
        public StructureOfMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImmediateMaterialOfStructureCollectionEditor<StructureOfMaterialView>:RPSCollectionEditor<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public  ImmediateMaterialOfStructureGridView<StructureOfMaterialView> GridView {get;set;}
    }
    public partial class ImmediateMaterialOfStructureGridView <StructureOfMaterialView> :  RPSGridView<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public ImmediateMaterialOfStructureGridView(StructureOfMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSGridTextBox<StructureOfMaterialView>("","#a82d671b-d514-4f73-8c11-69a2b3087f87 .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StructureOfMaterialView> Version { get; set; } 
                     
    }
 
        public partial class FinalMaterialOfStructureCollectionEditor<StructureOfMaterialView>:RPSCollectionEditor<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public  FinalMaterialOfStructureGridView<StructureOfMaterialView> GridView {get;set;}
    }
    public partial class FinalMaterialOfStructureGridView <StructureOfMaterialView> :  RPSGridView<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public FinalMaterialOfStructureGridView(StructureOfMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class ProjectMaterialOfStructureCollectionEditor<StructureOfMaterialView>:RPSCollectionEditor<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public  ProjectMaterialOfStructureGridView<StructureOfMaterialView> GridView {get;set;}
    }
    public partial class ProjectMaterialOfStructureGridView <StructureOfMaterialView> :  RPSGridView<StructureOfMaterialView> where StructureOfMaterialView : class, IView
    {
        public ProjectMaterialOfStructureGridView(StructureOfMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSGridTextBox<StructureOfMaterialView>("","#7da869bf-652d-4fc6-9601-5347d35cfb68 .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StructureOfMaterialView> Version { get; set; } 
                     
    }
 
    }
  
    

}
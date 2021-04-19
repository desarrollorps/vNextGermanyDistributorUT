    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.UseOfMaterials
{
    //RPS VERSION 1.0.0.0
    public partial class UseOfMaterials:Screen
    {
        public UseOfMaterials():base()
        {
            this.URL = "project.useofmaterials";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UseOfMaterialsQueryView  = new UseOfMaterialsQueryView(this); 
            UseOfMaterialsQueryView.InitializeControls(); 
           
        }
      
            public UseOfMaterialsQueryView UseOfMaterialsQueryView {get; set; } 
    }
            
    public partial class UseOfMaterialsQueryView : View
    {
        public UseOfMaterialsQueryView(UseOfMaterials screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<UseOfMaterialsQueryView>("6b77baba-94a7-4f8c-9d17-28342d71a701","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<UseOfMaterialsQueryView>("ebd0dd23-95c6-4dd9-8c3e-1a51227eb0cb","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<UseOfMaterialsQueryView>("35d33f03-97d8-4fac-9761-dd54067b6e23","","",false, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<UseOfMaterialsQueryView>("6c4f207e-338f-4cde-9c9b-1cd3c76a3db3","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<UseOfMaterialsQueryView>("dfbecd23-6353-4372-afee-a1cce33e50ff","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSComboBox<UseOfMaterialsQueryView>("b3d59c41-d3fd-4e76-93ea-13c459613848","","",false, this);
 
            CollectionInit params_GetUseOfMaterialsData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f2eceac9-aacb-49d6-9343-073908407a04",CSSSelectorGrid="",XPathGrid=""};
            GetUseOfMaterialsData = RPSControlFactory.RPSCreateCollectionWithGrid<GetUseOfMaterialsDataCollectionEditor<UseOfMaterialsQueryView>,UseOfMaterialsQueryView>( params_GetUseOfMaterialsData,this);
 

        }
        public IRPSComboBox<UseOfMaterialsQueryView> Article { get; set; } 
        public IRPSComboBox<UseOfMaterialsQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<UseOfMaterialsQueryView> Project { get; set; } 
        public IRPSComboBox<UseOfMaterialsQueryView> Version { get; set; } 
        public IRPSCollectionComboBox<UseOfMaterialsQueryView> Situation { get; set; } 
        public IRPSComboBox<UseOfMaterialsQueryView> ProjectType { get; set; } 
        public GetUseOfMaterialsDataCollectionEditor<UseOfMaterialsQueryView> GetUseOfMaterialsData { get; set; } 
        public UseOfMaterials Screen { get; set; }
        public UseOfMaterialsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetUseOfMaterialsDataCollectionEditor<UseOfMaterialsQueryView>:RPSCollectionEditor<UseOfMaterialsQueryView> where UseOfMaterialsQueryView : class, IView
    {
        public  GetUseOfMaterialsDataGridView<UseOfMaterialsQueryView> GridView {get;set;}
    }
    public partial class GetUseOfMaterialsDataGridView <UseOfMaterialsQueryView> :  RPSGridView<UseOfMaterialsQueryView> where UseOfMaterialsQueryView : class, IView
    {
        public GetUseOfMaterialsDataGridView(UseOfMaterialsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectMaterial_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<UseOfMaterialsQueryView>("","#f2eceac9-aacb-49d6-9343-073908407a04 .ag-row[role='row']@ROWINDEX [col-id='cProjectMaterial_Quantity']","",false, this.CurrentView);
 
            ProjectMaterial_QuantityImputed = RPSControlFactory.CreateRPSGridFormattedTextBox<UseOfMaterialsQueryView>("","#f2eceac9-aacb-49d6-9343-073908407a04 .ag-row[role='row']@ROWINDEX [col-id='cProjectMaterial_QuantityImputed']","",false, this.CurrentView);
 
            SupplySituation = RPSControlFactory.CreateRPSGridEnumComboBox<UseOfMaterialsQueryView>("","#f2eceac9-aacb-49d6-9343-073908407a04 .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UseOfMaterialsQueryView> ProjectMaterial_Quantity { get; set; } 
        public IRPSGridTextBox<UseOfMaterialsQueryView> ProjectMaterial_QuantityImputed { get; set; } 
        public IRPSGridComboBox<UseOfMaterialsQueryView> SupplySituation { get; set; } 
                     
    }
 
    }
  
    

}
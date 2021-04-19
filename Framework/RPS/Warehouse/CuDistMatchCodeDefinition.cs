    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.CuDistMatchCodeDefinition
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistMatchCodeDefinition:Screen
    {
        public CuDistMatchCodeDefinition():base()
        {
            this.URL = "warehouse.cudistmatchcodedefinition";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistMatchCodeDefinitionVMQueryView  = new CuDistMatchCodeDefinitionVMQueryView(this); 
            CuDistMatchCodeDefinitionVMEntityView  = new CuDistMatchCodeDefinitionVMEntityView(this); 
            CuDistMatchCodeDefinitionVMQueryView.InitializeControls(); 
            CuDistMatchCodeDefinitionVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistMatchCodeDefinitionVMQueryView CuDistMatchCodeDefinitionVMQueryView {get; set; } 
            public CuDistMatchCodeDefinitionVMEntityView CuDistMatchCodeDefinitionVMEntityView {get; set; } 
    }
            
    public partial class CuDistMatchCodeDefinitionVMQueryView : View
    {
        public CuDistMatchCodeDefinitionVMQueryView(CuDistMatchCodeDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView>( this,Screen.CuDistMatchCodeDefinitionVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistMatchCodeDefinitionVMQueryView>( this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistMatchCodeDefinitionVMQueryView>("f59af3c9-a338-4e32-a011-239dec94ac93","","",false, this);
 
            TypeOfObject = RPSControlFactory.CreateRPSEnumComboBox<CuDistMatchCodeDefinitionVMQueryView>("d7104dcc-e18d-464b-b662-723cccc2b4bb","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMQueryView>("1e299bef-03a6-432b-aa29-0d0816cba671","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMQueryView>("48d0ea4a-114d-4798-97f1-af2a0978dd52","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMQueryView>("ef661e6b-4749-4c37-8b53-4f3a10c71a4f","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMQueryView>("56a0825b-3f6e-41c4-bd99-5f204e85d851","","",false, this);
 
            CollectionInit params_CuDistMatchCodeDefinitionQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="52b24f55-63fc-42ca-9331-39167d14b047",CSSSelectorGrid="",XPathGrid=""};
            CuDistMatchCodeDefinitionQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistMatchCodeDefinitionQueryCollectionEditor<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView>,CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView>( params_CuDistMatchCodeDefinitionQuery,this,Screen.CuDistMatchCodeDefinitionVMEntityView);
 

        }
        public IRPSButton<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistMatchCodeDefinitionVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CuDistMatchCodeDefinitionVMQueryView> Description { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMQueryView> TypeOfObject { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMQueryView> IDArticle { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMQueryView> IDProductLine { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMQueryView> IDProductFamily { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMQueryView> IDProductSubFamily { get; set; } 
        public CuDistMatchCodeDefinitionQueryCollectionEditor<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> CuDistMatchCodeDefinitionQuery { get; set; } 
        public CuDistMatchCodeDefinition Screen { get; set; }
        public CuDistMatchCodeDefinitionVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistMatchCodeDefinitionQueryCollectionEditor<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView>:RPSCollectionEditor<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> where CuDistMatchCodeDefinitionVMQueryView : class, IView where CuDistMatchCodeDefinitionVMEntityView : class, IView
    {
        public  CuDistMatchCodeDefinitionQueryGridView<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> GridView {get;set;}
    }
    public partial class CuDistMatchCodeDefinitionQueryGridView <CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> :  RPSGridView<CuDistMatchCodeDefinitionVMQueryView,CuDistMatchCodeDefinitionVMEntityView> where CuDistMatchCodeDefinitionVMQueryView : class, IView where CuDistMatchCodeDefinitionVMEntityView : class, IView
    {
        public CuDistMatchCodeDefinitionQueryGridView(CuDistMatchCodeDefinitionVMQueryView currentView,CuDistMatchCodeDefinitionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistMatchCodeDefinition_CodMatchCodeDefinition = RPSControlFactory.CreateRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView>("","#52b24f55-63fc-42ca-9331-39167d14b047 .ag-row[role='row']@ROWINDEX [col-id='cCuDistMatchCodeDefinition_CodMatchCodeDefinition']","",false, this.CurrentView);
 
            CuDistMatchCodeDefinition_Description = RPSControlFactory.CreateRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView>("","#52b24f55-63fc-42ca-9331-39167d14b047 .ag-row[role='row']@ROWINDEX [col-id='cCuDistMatchCodeDefinition_Description']","",false, this.CurrentView);
 
            CuDistMatchCodeDefinition_TypeOfObject = RPSControlFactory.CreateRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView>("","#52b24f55-63fc-42ca-9331-39167d14b047 .ag-row[role='row']@ROWINDEX [col-id='cCuDistMatchCodeDefinition_TypeOfObject']","",false, this.CurrentView);
 
            CuDistMatchCodeDefinition_CodObject = RPSControlFactory.CreateRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView>("","#52b24f55-63fc-42ca-9331-39167d14b047 .ag-row[role='row']@ROWINDEX [col-id='cCuDistMatchCodeDefinition_ObjectDescription']","",false, this.CurrentView);
 
            CuDistMatchCodeDefinition_IDArticleLabel = RPSControlFactory.CreateRPSGridComboBox<CuDistMatchCodeDefinitionVMQueryView>("","#52b24f55-63fc-42ca-9331-39167d14b047 .ag-row[role='row']@ROWINDEX [col-id='cCuDistMatchCodeDefinition_IDArticleLabel']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView> CuDistMatchCodeDefinition_CodMatchCodeDefinition { get; set; } 
        public IRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView> CuDistMatchCodeDefinition_Description { get; set; } 
        public IRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView> CuDistMatchCodeDefinition_TypeOfObject { get; set; } 
        public IRPSGridTextBox<CuDistMatchCodeDefinitionVMQueryView> CuDistMatchCodeDefinition_CodObject { get; set; } 
        public IRPSGridComboBox<CuDistMatchCodeDefinitionVMQueryView> CuDistMatchCodeDefinition_IDArticleLabel { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistMatchCodeDefinitionVMEntityView : View
    {
        public CuDistMatchCodeDefinitionVMEntityView(CuDistMatchCodeDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistMatchCodeDefinitionVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistMatchCodeDefinitionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistMatchCodeDefinitionVMEntityView,CuDistMatchCodeDefinitionVMQueryView>( this,Screen.CuDistMatchCodeDefinitionVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistMatchCodeDefinitionVMEntityView,CuDistMatchCodeDefinitionVMQueryView>( this,Screen.CuDistMatchCodeDefinitionVMQueryView);
 
            CodMatchCodeDefinition = RPSControlFactory.CreateRPSTextBox<CuDistMatchCodeDefinitionVMEntityView>("15d5d094-68b1-455a-b7a0-35fd02e154a4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistMatchCodeDefinitionVMEntityView>("fc6f8d3d-0210-4e68-a304-863922b6a67b","","",false, this);
 
            TypeOfObject = RPSControlFactory.CreateRPSEnumComboBox<CuDistMatchCodeDefinitionVMEntityView>("f191e88f-2d23-4316-8c57-a05849eaa631","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMEntityView>("bca5fe0f-260b-46ca-b659-79e55627bced","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMEntityView>("8df9777e-4245-478d-87e4-aaf8172fc0dc","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMEntityView>("090b8e78-3734-4bd1-b35b-fdfbd8fbfa57","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMEntityView>("cf98d9d4-9e41-4ce5-bffc-2d92579c399c","","",false, this);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<CuDistMatchCodeDefinitionVMEntityView>("6e7cac10-98d9-454b-9489-408d404b1418","","",false, this);
 

        }
        public IRPSSaveButton<CuDistMatchCodeDefinitionVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistMatchCodeDefinitionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistMatchCodeDefinitionVMEntityView,CuDistMatchCodeDefinitionVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistMatchCodeDefinitionVMEntityView,CuDistMatchCodeDefinitionVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<CuDistMatchCodeDefinitionVMEntityView> CodMatchCodeDefinition { get; set; } 
        public IRPSTextBox<CuDistMatchCodeDefinitionVMEntityView> Description { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> TypeOfObject { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<CuDistMatchCodeDefinitionVMEntityView> IDArticleLabel { get; set; } 
        public CuDistMatchCodeDefinition Screen { get; set; }
        public CuDistMatchCodeDefinitionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
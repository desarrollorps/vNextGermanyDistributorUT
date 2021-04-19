    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.MRPArticleSelection
{
    //RPS VERSION 1.0.0.0
    public partial class MRPArticleSelection:Screen
    {
        public MRPArticleSelection():base()
        {
            this.URL = "planification.mrparticleselection";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MRPArticleSelectionVMCollectionView  = new MRPArticleSelectionVMCollectionView(this); 
            MRPArticleSelectionVMEntityView  = new MRPArticleSelectionVMEntityView(this); 
            MRPArticleSelectionLoadDialogView  = new MRPArticleSelectionLoadDialogView(this); 
            MRPArticleSelectionVMCollectionView.InitializeControls(); 
            MRPArticleSelectionVMEntityView.InitializeControls(); 
            MRPArticleSelectionLoadDialogView.InitializeControls(); 
           
        }
      
            public MRPArticleSelectionVMCollectionView MRPArticleSelectionVMCollectionView {get; set; } 
            public MRPArticleSelectionVMEntityView MRPArticleSelectionVMEntityView {get; set; } 
            public MRPArticleSelectionLoadDialogView MRPArticleSelectionLoadDialogView {get; set; } 
    }
            
    public partial class MRPArticleSelectionVMCollectionView : View
    {
        public MRPArticleSelectionVMCollectionView(MRPArticleSelection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionVMCollectionView>("110623b8-5323-4716-ba19-0356cda84b2f","","",false, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionVMCollectionView>("4d47c168-0c3b-4c3c-9d53-bd92cd637fdf","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MRPArticleSelectionVMCollectionView>("148f71f8-c358-4fce-b92f-0427fbc98fa2","","",false, this);
 
            ExecuteMRPArticleSelectionChangeStateToPendingButtonButton = RPSControlFactory.CreateRPSButton<MRPArticleSelectionVMCollectionView>( "ecfadedb-6570-41ab-82e8-b3501497e26a","","",this);
 
            DeleteSelectionButton = RPSControlFactory.CreateRPSButton<MRPArticleSelectionVMCollectionView>( "d86aace4-4b1f-4bab-b4a5-3dd9c7af1606","","",this);
 
            MRPArticleSelectionLoadNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MRPArticleSelectionVMCollectionView,MRPArticleSelectionLoadDialogView>("f3944e88-684b-4345-bcaf-f22da7c9e794","","", this,Screen.MRPArticleSelectionLoadDialogView);
 
            CollectionInit params_MRPArticleSelectionQueryEntity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7f5970b1-975c-4e8c-9a5a-a48514dce36c",CSSSelectorGrid="",XPathGrid=""};
            MRPArticleSelectionQueryEntity = RPSControlFactory.RPSCreateCollectionWithGrid<MRPArticleSelectionQueryEntityCollectionEditor<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView>,MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView>( params_MRPArticleSelectionQueryEntity,this,Screen.MRPArticleSelectionVMEntityView);
 

        }
        public IRPSComboBox<MRPArticleSelectionVMCollectionView> Site { get; set; } 
        public IRPSComboBox<MRPArticleSelectionVMCollectionView> Scene { get; set; } 
        public IRPSCollectionComboBox<MRPArticleSelectionVMCollectionView> Article { get; set; } 
        public IRPSButton<MRPArticleSelectionVMCollectionView> ExecuteMRPArticleSelectionChangeStateToPendingButtonButton { get; set; } 
        public IRPSButton<MRPArticleSelectionVMCollectionView> DeleteSelectionButton { get; set; } 
        public IRPSButton<MRPArticleSelectionVMCollectionView,MRPArticleSelectionLoadDialogView> MRPArticleSelectionLoadNavigationCommandButton { get; set; } 
        public MRPArticleSelectionQueryEntityCollectionEditor<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView> MRPArticleSelectionQueryEntity { get; set; } 
        public MRPArticleSelection Screen { get; set; }
        public MRPArticleSelectionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MRPArticleSelectionQueryEntityCollectionEditor<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView>:RPSCollectionEditor<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView> where MRPArticleSelectionVMCollectionView : class, IView where MRPArticleSelectionVMEntityView : class, IView
    {
        public  MRPArticleSelectionQueryEntityGridView<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView> GridView {get;set;}
    }
    public partial class MRPArticleSelectionQueryEntityGridView <MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView> :  RPSGridView<MRPArticleSelectionVMCollectionView,MRPArticleSelectionVMEntityView> where MRPArticleSelectionVMCollectionView : class, IView where MRPArticleSelectionVMEntityView : class, IView
    {
        public MRPArticleSelectionQueryEntityGridView(MRPArticleSelectionVMCollectionView currentView,MRPArticleSelectionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MRPArticleSelectionVMCollectionView>("","#7f5970b1-975c-4e8c-9a5a-a48514dce36c .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridEnumComboBox<MRPArticleSelectionVMCollectionView>("","#7f5970b1-975c-4e8c-9a5a-a48514dce36c .ag-row[role='row']@ROWINDEX [col-id='cState']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MRPArticleSelectionVMCollectionView> IDArticle { get; set; } 
        public IRPSGridComboBox<MRPArticleSelectionVMCollectionView> State { get; set; } 
                     
    }
 
    }
  
            
    public partial class MRPArticleSelectionVMEntityView : View
    {
        public MRPArticleSelectionVMEntityView(MRPArticleSelection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MRPArticleSelectionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView>( this,Screen.MRPArticleSelectionVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView>( this,Screen.MRPArticleSelectionVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView>( this,Screen.MRPArticleSelectionVMCollectionView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionVMEntityView>("fbb91c9f-6f7c-4430-8cab-c9395cf653bf","","",true, this);
 
            IDScene = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionVMEntityView>("01d4d9cf-ca17-41d7-bc67-416228e6e9c7","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionVMEntityView>("dc4cd1ac-defe-4bc9-9adb-e17ce968a5cc","","",true, this);
 

        }
        public IRPSButton<MRPArticleSelectionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<MRPArticleSelectionVMEntityView,MRPArticleSelectionVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<MRPArticleSelectionVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<MRPArticleSelectionVMEntityView> IDScene { get; set; } 
        public IRPSComboBox<MRPArticleSelectionVMEntityView> IDArticle { get; set; } 
        public MRPArticleSelection Screen { get; set; }
        public MRPArticleSelectionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MRPArticleSelectionLoadDialogView : View
    {
        public MRPArticleSelectionLoadDialogView(MRPArticleSelection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionLoadDialogView>("504db420-32b9-4ed8-8a83-fbc6dd1bc3a3","","",true, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<MRPArticleSelectionLoadDialogView>("a9973fce-7bb9-45bf-84a9-b91ffe77b7d8","","",false, this);
 
            Articles = RPSControlFactory.CreateRPSCheckBox<MRPArticleSelectionLoadDialogView>("cc3820dd-1e64-49d6-8c1a-0e78cd7df4b8","","",false, this);
 
            ArticlePlanification = RPSControlFactory.CreateRPSCollectionComboBox<MRPArticleSelectionLoadDialogView>("f0afa513-e1ef-4fac-abd2-28f42db92853","","",false, this);
 
            OrderSales = RPSControlFactory.CreateRPSCheckBox<MRPArticleSelectionLoadDialogView>("1ba497cb-20f7-4a51-999f-2f2b95f8f35d","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSCollectionComboBox<MRPArticleSelectionLoadDialogView>("afa0e19e-08c2-4e90-994a-5f1959ad88f3","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCheckBox<MRPArticleSelectionLoadDialogView>("9c994265-cc22-4ee3-801b-f8774bd78057","","",false, this);
 
            ProjectList = RPSControlFactory.CreateRPSCollectionComboBox<MRPArticleSelectionLoadDialogView>("293ffa94-ead9-4e98-9428-dd1d7aaaab9c","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<MRPArticleSelectionLoadDialogView>("f1ac7e25-2f31-48ca-a775-4e6c46f6caa9","","",false, this);
 
            ManufacturingOrderList = RPSControlFactory.CreateRPSCollectionComboBox<MRPArticleSelectionLoadDialogView>("5d4d6a2d-fe15-447a-9f24-ea451919db6f","","",false, this);
 
            ConsultMassiveLoad = RPSControlFactory.CreateRPSButton<MRPArticleSelectionLoadDialogView>( "22bf0bd3-e2c3-4d6e-ac54-1abce0a0bc15","","",this);
 
            CommandMRPArticleSelectionCreate = RPSControlFactory.CreateRPSButton<MRPArticleSelectionLoadDialogView>( "7bcb57c8-7ab4-4ea2-b824-e375e9011071","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<MRPArticleSelectionLoadDialogView>( "9276a29d-2568-4158-bdf1-705aadbfdf3d","","",this);
 
            CollectionInit params_MRPArticleSelectionMassiveLoad = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0c0e132b-ff17-4fa4-9366-d498769f219b",CSSSelectorGrid="",XPathGrid=""};
            MRPArticleSelectionMassiveLoad = RPSControlFactory.RPSCreateCollectionWithGrid<MRPArticleSelectionMassiveLoadCollectionEditor<MRPArticleSelectionLoadDialogView>,MRPArticleSelectionLoadDialogView>( params_MRPArticleSelectionMassiveLoad,this);
 

        }
        public IRPSComboBox<MRPArticleSelectionLoadDialogView> Site { get; set; } 
        public IRPSComboBox<MRPArticleSelectionLoadDialogView> Scene { get; set; } 
        public IRPSCheckbox<MRPArticleSelectionLoadDialogView> Articles { get; set; } 
        public IRPSCollectionComboBox<MRPArticleSelectionLoadDialogView> ArticlePlanification { get; set; } 
        public IRPSCheckbox<MRPArticleSelectionLoadDialogView> OrderSales { get; set; } 
        public IRPSCollectionComboBox<MRPArticleSelectionLoadDialogView> OrderSL { get; set; } 
        public IRPSCheckbox<MRPArticleSelectionLoadDialogView> Project { get; set; } 
        public IRPSCollectionComboBox<MRPArticleSelectionLoadDialogView> ProjectList { get; set; } 
        public IRPSCheckbox<MRPArticleSelectionLoadDialogView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<MRPArticleSelectionLoadDialogView> ManufacturingOrderList { get; set; } 
        public IRPSButton<MRPArticleSelectionLoadDialogView> ConsultMassiveLoad { get; set; } 
        public IRPSButton<MRPArticleSelectionLoadDialogView> CommandMRPArticleSelectionCreate { get; set; } 
        public IRPSButton<MRPArticleSelectionLoadDialogView> LinkNavigationCommand { get; set; } 
        public MRPArticleSelectionMassiveLoadCollectionEditor<MRPArticleSelectionLoadDialogView> MRPArticleSelectionMassiveLoad { get; set; } 
        public MRPArticleSelection Screen { get; set; }
        public MRPArticleSelectionLoadDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MRPArticleSelectionMassiveLoadCollectionEditor<MRPArticleSelectionLoadDialogView>:RPSCollectionEditor<MRPArticleSelectionLoadDialogView> where MRPArticleSelectionLoadDialogView : class, IView
    {
        public  MRPArticleSelectionMassiveLoadGridView<MRPArticleSelectionLoadDialogView> GridView {get;set;}
    }
    public partial class MRPArticleSelectionMassiveLoadGridView <MRPArticleSelectionLoadDialogView> :  RPSGridView<MRPArticleSelectionLoadDialogView> where MRPArticleSelectionLoadDialogView : class, IView
    {
        public MRPArticleSelectionMassiveLoadGridView(MRPArticleSelectionLoadDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            State = RPSControlFactory.CreateRPSGridEnumComboBox<MRPArticleSelectionLoadDialogView>("","#0c0e132b-ff17-4fa4-9366-d498769f219b .ag-row[role='row']@ROWINDEX [col-id='cState']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MRPArticleSelectionLoadDialogView> State { get; set; } 
                     
    }
 
    }
  
    

}
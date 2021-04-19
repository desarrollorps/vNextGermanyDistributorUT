    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.CostReconstruction
{
    //RPS VERSION 1.0.0.0
    public partial class CostReconstruction:Screen
    {
        public CostReconstruction():base()
        {
            this.URL = "warehouse.costreconstruction";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostReconstructionView  = new CostReconstructionView(this); 
            CostReconstructionChildViewModelDialogView  = new CostReconstructionChildViewModelDialogView(this); 
            CostReconstructionView.InitializeControls(); 
            CostReconstructionChildViewModelDialogView.InitializeControls(); 
           
        }
      
            public CostReconstructionView CostReconstructionView {get; set; } 
            public CostReconstructionChildViewModelDialogView CostReconstructionChildViewModelDialogView {get; set; } 
    }
            
    public partial class CostReconstructionView : View
    {
        public CostReconstructionView(CostReconstruction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Automatic = RPSControlFactory.CreateRPSOption<CostReconstructionView>( "f6ca4f7e-2072-4370-8e30-84e088bb3c77","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<CostReconstructionView>( "47067328-d146-4d46-b040-88c654cbba9b","","",this);
 
            CostReconstructionChildViewModelNavigationCommand = RPSControlFactory.CreateRPSButton<CostReconstructionView>( "50b4a618-1646-4ba1-a483-93dc239e55f4","","",this);
 
            bLastInvetoryDate = RPSControlFactory.CreateRPSCheckBox<CostReconstructionView>("41727758-a40e-4249-92d4-501a5678180b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostReconstructionView>("0646bfe4-c719-47e1-9e8b-6decbd351911","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<CostReconstructionView>("f99bd772-6bf4-4609-88e5-db2a478686d4","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<CostReconstructionView>( "74bf45f5-b3bd-4442-8fa0-ae67dc584e40","","",this);
 

        }
        public IRPSOption<CostReconstructionView> Automatic { get; set; } 
        public IRPSOption<CostReconstructionView> Manual { get; set; } 
        public IRPSButton<CostReconstructionView> CostReconstructionChildViewModelNavigationCommand { get; set; } 
        public IRPSCheckbox<CostReconstructionView> bLastInvetoryDate { get; set; } 
        public IRPSTextBox<CostReconstructionView> DateFrom { get; set; } 
        public IRPSCollectionComboBox<CostReconstructionView> Article { get; set; } 
        public IRPSButton<CostReconstructionView> AcceptCommand { get; set; } 
        public CostReconstruction Screen { get; set; }
        public CostReconstructionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostReconstructionChildViewModelDialogView : View
    {
        public CostReconstructionChildViewModelDialogView(CostReconstruction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetAllArticleReconstruction = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1cf419e2-09e0-42d9-a09e-0c34f726482f",CSSSelectorGrid="",XPathGrid=""};
            GetAllArticleReconstruction = RPSControlFactory.RPSCreateCollectionWithGrid<GetAllArticleReconstructionCollectionEditor<CostReconstructionChildViewModelDialogView>,CostReconstructionChildViewModelDialogView>( params_GetAllArticleReconstruction,this);
 

        }
        public GetAllArticleReconstructionCollectionEditor<CostReconstructionChildViewModelDialogView> GetAllArticleReconstruction { get; set; } 
        public CostReconstruction Screen { get; set; }
        public CostReconstructionChildViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetAllArticleReconstructionCollectionEditor<CostReconstructionChildViewModelDialogView>:RPSCollectionEditor<CostReconstructionChildViewModelDialogView> where CostReconstructionChildViewModelDialogView : class, IView
    {
        public  GetAllArticleReconstructionGridView<CostReconstructionChildViewModelDialogView> GridView {get;set;}
    }
    public partial class GetAllArticleReconstructionGridView <CostReconstructionChildViewModelDialogView> :  RPSGridView<CostReconstructionChildViewModelDialogView> where CostReconstructionChildViewModelDialogView : class, IView
    {
        public GetAllArticleReconstructionGridView(CostReconstructionChildViewModelDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ReconstructionDate = RPSControlFactory.CreateRPSGridTextBox<CostReconstructionChildViewModelDialogView>("","#1cf419e2-09e0-42d9-a09e-0c34f726482f .ag-row[role='row']@ROWINDEX [col-id='cReconstructionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostReconstructionChildViewModelDialogView> ReconstructionDate { get; set; } 
                     
    }
 
    }
  
    

}
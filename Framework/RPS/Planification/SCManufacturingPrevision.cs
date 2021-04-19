    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.SCManufacturingPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class SCManufacturingPrevision:Screen
    {
        public SCManufacturingPrevision():base()
        {
            this.URL = "planification.scmanufacturingprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SCManufacturingPrevisionVMCollectionView  = new SCManufacturingPrevisionVMCollectionView(this); 
            SCManufacturingPrevisionVMEntityView  = new SCManufacturingPrevisionVMEntityView(this); 
            SCManufacturingPrevisionVMCollectionView.InitializeControls(); 
            SCManufacturingPrevisionVMEntityView.InitializeControls(); 
           
        }
      
            public SCManufacturingPrevisionVMCollectionView SCManufacturingPrevisionVMCollectionView {get; set; } 
            public SCManufacturingPrevisionVMEntityView SCManufacturingPrevisionVMEntityView {get; set; } 
    }
            
    public partial class SCManufacturingPrevisionVMCollectionView : View
    {
        public SCManufacturingPrevisionVMCollectionView(SCManufacturingPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<SCManufacturingPrevisionVMCollectionView>("d9b91347-fd6b-4653-ae46-94a7a142fffd","","",false, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<SCManufacturingPrevisionVMCollectionView>("a6d5205d-518b-42b6-8f2c-3d765712c2c1","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SCManufacturingPrevisionVMCollectionView>("e817f6ac-ee42-4c11-b6a0-26fa212242f6","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<SCManufacturingPrevisionVMCollectionView>("ec24fe73-2fd7-40bf-8901-bac0d3020b49","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SCManufacturingPrevisionVMCollectionView>("43426b2e-2938-425e-8894-c7d660ef9a3f","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SCManufacturingPrevisionVMCollectionView>("6c15c09e-5712-4707-97ca-b7ef67a52784","","",false, this);
 
            ChangeStatus = RPSControlFactory.CreateRPSButton<SCManufacturingPrevisionVMCollectionView>( "71eaf305-a100-4d56-864f-6819a8db60e9","","",this);
 
            CollectionInit params_SCManufacturingPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49f8e854-4597-4e97-91ca-b946b86bec10",CSSSelectorGrid="",XPathGrid=""};
            SCManufacturingPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<SCManufacturingPrevisionCollectionEditor<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView>,SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView>( params_SCManufacturingPrevision,this,Screen.SCManufacturingPrevisionVMEntityView);
 

        }
        public IRPSComboBox<SCManufacturingPrevisionVMCollectionView> Site { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMCollectionView> Scene { get; set; } 
        public IRPSCollectionComboBox<SCManufacturingPrevisionVMCollectionView> Article { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMCollectionView> eState { get; set; } 
        public IRPSTextBox<SCManufacturingPrevisionVMCollectionView> DateFrom { get; set; } 
        public IRPSTextBox<SCManufacturingPrevisionVMCollectionView> DateTo { get; set; } 
        public IRPSButton<SCManufacturingPrevisionVMCollectionView> ChangeStatus { get; set; } 
        public SCManufacturingPrevisionCollectionEditor<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView> SCManufacturingPrevision { get; set; } 
        public SCManufacturingPrevision Screen { get; set; }
        public SCManufacturingPrevisionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SCManufacturingPrevisionCollectionEditor<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView>:RPSCollectionEditor<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView> where SCManufacturingPrevisionVMCollectionView : class, IView where SCManufacturingPrevisionVMEntityView : class, IView
    {
        public  SCManufacturingPrevisionGridView<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView> GridView {get;set;}
    }
    public partial class SCManufacturingPrevisionGridView <SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView> :  RPSGridView<SCManufacturingPrevisionVMCollectionView,SCManufacturingPrevisionVMEntityView> where SCManufacturingPrevisionVMCollectionView : class, IView where SCManufacturingPrevisionVMEntityView : class, IView
    {
        public SCManufacturingPrevisionGridView(SCManufacturingPrevisionVMCollectionView currentView,SCManufacturingPrevisionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",true, this.CurrentView);
 
            PrevisionDate = RPSControlFactory.CreateRPSGridTextBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cPrevisionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridEnumComboBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cState']","",true, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<SCManufacturingPrevisionVMCollectionView>("","#49f8e854-4597-4e97-91ca-b946b86bec10 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SCManufacturingPrevisionVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<SCManufacturingPrevisionVMCollectionView> CreationDate { get; set; } 
        public IRPSGridTextBox<SCManufacturingPrevisionVMCollectionView> PrevisionDate { get; set; } 
        public IRPSGridTextBox<SCManufacturingPrevisionVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<SCManufacturingPrevisionVMCollectionView> State { get; set; } 
        public IRPSGridTextBox<SCManufacturingPrevisionVMCollectionView> InternalCode { get; set; } 
                     
    }
 
    }
  
            
    public partial class SCManufacturingPrevisionVMEntityView : View
    {
        public SCManufacturingPrevisionVMEntityView(SCManufacturingPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SCManufacturingPrevisionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView>( this,Screen.SCManufacturingPrevisionVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView>( this,Screen.SCManufacturingPrevisionVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView>( this,Screen.SCManufacturingPrevisionVMCollectionView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SCManufacturingPrevisionVMEntityView>("775d0703-5704-436e-b79f-d135fac82e8a","","",true, this);
 
            IDScene = RPSControlFactory.CreateRPSComboBox<SCManufacturingPrevisionVMEntityView>("74a19562-76c5-4f3c-a3a4-bfd53696e3b2","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SCManufacturingPrevisionVMEntityView>("6830c5e2-90ef-4668-a366-0a217656c986","","",true, this);
 
            PrevisionDate = RPSControlFactory.CreateRPSTextBox<SCManufacturingPrevisionVMEntityView>("5e8fdceb-88bb-444f-a21c-f9c95063fdf6","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SCManufacturingPrevisionVMEntityView>("91cff7a9-6d76-46de-bacf-2dda0f4a56e7","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SCManufacturingPrevisionVMEntityView>("33a735cd-8b60-4172-a945-1e2dfd77939b","","",false, this);
 
            State = RPSControlFactory.CreateRPSEnumComboBox<SCManufacturingPrevisionVMEntityView>("a1addb78-fa27-462f-a5a6-9b85c5bef913","","",true, this);
 

        }
        public IRPSButton<SCManufacturingPrevisionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<SCManufacturingPrevisionVMEntityView,SCManufacturingPrevisionVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMEntityView> IDScene { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<SCManufacturingPrevisionVMEntityView> PrevisionDate { get; set; } 
        public IRPSTextBox<SCManufacturingPrevisionVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<SCManufacturingPrevisionVMEntityView> InternalCode { get; set; } 
        public IRPSComboBox<SCManufacturingPrevisionVMEntityView> State { get; set; } 
        public SCManufacturingPrevision Screen { get; set; }
        public SCManufacturingPrevisionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.SCSalesPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class SCSalesPrevision:Screen
    {
        public SCSalesPrevision():base()
        {
            this.URL = "planification.scsalesprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SCSalesPrevisionVMCollectionView  = new SCSalesPrevisionVMCollectionView(this); 
            SCSalesPrevisionVMEntityView  = new SCSalesPrevisionVMEntityView(this); 
            SCSalesPrevisionVMCollectionView.InitializeControls(); 
            SCSalesPrevisionVMEntityView.InitializeControls(); 
           
        }
      
            public SCSalesPrevisionVMCollectionView SCSalesPrevisionVMCollectionView {get; set; } 
            public SCSalesPrevisionVMEntityView SCSalesPrevisionVMEntityView {get; set; } 
    }
            
    public partial class SCSalesPrevisionVMCollectionView : View
    {
        public SCSalesPrevisionVMCollectionView(SCSalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<SCSalesPrevisionVMCollectionView>("dd390680-171c-437b-82ea-a4795d80831c","","",false, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<SCSalesPrevisionVMCollectionView>("a3844b8d-b862-44ea-b488-c296c3286657","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SCSalesPrevisionVMCollectionView>("79d807a8-dd7f-4f9b-8699-ee1c9600839c","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<SCSalesPrevisionVMCollectionView>("6b7511d9-9860-4be0-a696-f9f08c014800","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SCSalesPrevisionVMCollectionView>("42fbc5ab-bf72-48b3-bed0-02568717be86","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SCSalesPrevisionVMCollectionView>("c50508bc-1923-41fb-b099-22a31378b117","","",false, this);
 
            ChangeState = RPSControlFactory.CreateRPSButton<SCSalesPrevisionVMCollectionView>( "de1cd9b3-55ce-4719-8ecd-2a8d92841363","","",this);
 
            CollectionInit params_SCSalesPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="08942aaf-873e-4798-9c3f-3b1c89775405",CSSSelectorGrid="",XPathGrid=""};
            SCSalesPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<SCSalesPrevisionCollectionEditor<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView>,SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView>( params_SCSalesPrevision,this,Screen.SCSalesPrevisionVMEntityView);
 

        }
        public IRPSComboBox<SCSalesPrevisionVMCollectionView> Site { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMCollectionView> Scene { get; set; } 
        public IRPSCollectionComboBox<SCSalesPrevisionVMCollectionView> Article { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMCollectionView> eState { get; set; } 
        public IRPSTextBox<SCSalesPrevisionVMCollectionView> DateFrom { get; set; } 
        public IRPSTextBox<SCSalesPrevisionVMCollectionView> DateTo { get; set; } 
        public IRPSButton<SCSalesPrevisionVMCollectionView> ChangeState { get; set; } 
        public SCSalesPrevisionCollectionEditor<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView> SCSalesPrevision { get; set; } 
        public SCSalesPrevision Screen { get; set; }
        public SCSalesPrevisionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SCSalesPrevisionCollectionEditor<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView>:RPSCollectionEditor<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView> where SCSalesPrevisionVMCollectionView : class, IView where SCSalesPrevisionVMEntityView : class, IView
    {
        public  SCSalesPrevisionGridView<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView> GridView {get;set;}
    }
    public partial class SCSalesPrevisionGridView <SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView> :  RPSGridView<SCSalesPrevisionVMCollectionView,SCSalesPrevisionVMEntityView> where SCSalesPrevisionVMCollectionView : class, IView where SCSalesPrevisionVMEntityView : class, IView
    {
        public SCSalesPrevisionGridView(SCSalesPrevisionVMCollectionView currentView,SCSalesPrevisionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SCSalesPrevisionVMCollectionView>("","#08942aaf-873e-4798-9c3f-3b1c89775405 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            PrevisionDate = RPSControlFactory.CreateRPSGridTextBox<SCSalesPrevisionVMCollectionView>("","#08942aaf-873e-4798-9c3f-3b1c89775405 .ag-row[role='row']@ROWINDEX [col-id='cPrevisionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SCSalesPrevisionVMCollectionView>("","#08942aaf-873e-4798-9c3f-3b1c89775405 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridEnumComboBox<SCSalesPrevisionVMCollectionView>("","#08942aaf-873e-4798-9c3f-3b1c89775405 .ag-row[role='row']@ROWINDEX [col-id='cState']","",true, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<SCSalesPrevisionVMCollectionView>("","#08942aaf-873e-4798-9c3f-3b1c89775405 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SCSalesPrevisionVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<SCSalesPrevisionVMCollectionView> PrevisionDate { get; set; } 
        public IRPSGridTextBox<SCSalesPrevisionVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<SCSalesPrevisionVMCollectionView> State { get; set; } 
        public IRPSGridTextBox<SCSalesPrevisionVMCollectionView> InternalCode { get; set; } 
                     
    }
 
    }
  
            
    public partial class SCSalesPrevisionVMEntityView : View
    {
        public SCSalesPrevisionVMEntityView(SCSalesPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SCSalesPrevisionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView>( this,Screen.SCSalesPrevisionVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView>( this,Screen.SCSalesPrevisionVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView>( this,Screen.SCSalesPrevisionVMCollectionView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SCSalesPrevisionVMEntityView>("f3a2c78a-3452-434b-913f-b67632d5347c","","",true, this);
 
            IDScene = RPSControlFactory.CreateRPSComboBox<SCSalesPrevisionVMEntityView>("6a720314-3e78-410e-9aa8-7330c80f29f2","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SCSalesPrevisionVMEntityView>("ccce9386-3a64-4865-ae13-2a45969cbc23","","",true, this);
 
            PrevisionDate = RPSControlFactory.CreateRPSTextBox<SCSalesPrevisionVMEntityView>("aca1714e-41f6-4c6f-999e-86e58d2fdc50","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SCSalesPrevisionVMEntityView>("e1d307a4-a5f4-4730-9be8-058ac14bea05","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SCSalesPrevisionVMEntityView>("33b0f0ab-48d8-4995-9f75-3a669c5ce708","","",false, this);
 
            State = RPSControlFactory.CreateRPSEnumComboBox<SCSalesPrevisionVMEntityView>("eefcfd75-2a4c-4dd7-bc1d-f5369df99083","","",true, this);
 

        }
        public IRPSButton<SCSalesPrevisionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<SCSalesPrevisionVMEntityView,SCSalesPrevisionVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMEntityView> IDScene { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<SCSalesPrevisionVMEntityView> PrevisionDate { get; set; } 
        public IRPSTextBox<SCSalesPrevisionVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<SCSalesPrevisionVMEntityView> InternalCode { get; set; } 
        public IRPSComboBox<SCSalesPrevisionVMEntityView> State { get; set; } 
        public SCSalesPrevision Screen { get; set; }
        public SCSalesPrevisionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ManufacturingPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingPrevision:Screen
    {
        public ManufacturingPrevision():base()
        {
            this.URL = "planification.manufacturingprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingPrevisionVMCollectionView  = new ManufacturingPrevisionVMCollectionView(this); 
            ManufacturingPrevisionVMEntityView  = new ManufacturingPrevisionVMEntityView(this); 
            MassiveDeleteDialogView  = new MassiveDeleteDialogView(this); 
            ManufacturingPrevisionVMCollectionView.InitializeControls(); 
            ManufacturingPrevisionVMEntityView.InitializeControls(); 
            MassiveDeleteDialogView.InitializeControls(); 
           
        }
      
            public ManufacturingPrevisionVMCollectionView ManufacturingPrevisionVMCollectionView {get; set; } 
            public ManufacturingPrevisionVMEntityView ManufacturingPrevisionVMEntityView {get; set; } 
            public MassiveDeleteDialogView MassiveDeleteDialogView {get; set; } 
    }
            
    public partial class ManufacturingPrevisionVMCollectionView : View
    {
        public ManufacturingPrevisionVMCollectionView(ManufacturingPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingPrevisionVMCollectionView>("05541213-0d1b-4d26-ae5b-55143c8adc9c","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingPrevisionVMCollectionView>("bfae039b-9729-49eb-bb7d-f1aeead16669","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingPrevisionVMCollectionView>("15f8fc06-602f-491f-9e91-8f0508c50136","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ManufacturingPrevisionVMCollectionView>("cd453ad9-df10-46d3-927b-31bbf1ae3a91","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ManufacturingPrevisionVMCollectionView>("37066386-5877-4ee7-9d35-41bd5e451262","","",false, this);
 
            CommandChangeStateButton = RPSControlFactory.CreateRPSButton<ManufacturingPrevisionVMCollectionView>( "06ad8f05-fc77-45fa-8bb5-8f5081ba097e","","",this);
 
            CommandDeleteButton = RPSControlFactory.CreateRPSButton<ManufacturingPrevisionVMCollectionView>( "70ef5f69-b45f-40d3-90dc-201b2f2c247a","","",this);
 
            MassiveDeleteNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingPrevisionVMCollectionView,MassiveDeleteDialogView>("58940534-bacd-4d74-8aa3-b16e9145a406","","", this,Screen.MassiveDeleteDialogView);
 
            CollectionInit params_ManufacturingPrevisionQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db20cd46-5b8c-48da-bb5c-dcd842927a45",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingPrevisionQuery = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingPrevisionQueryCollectionEditor<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView>,ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView>( params_ManufacturingPrevisionQuery,this,Screen.ManufacturingPrevisionVMEntityView);
 

        }
        public IRPSComboBox<ManufacturingPrevisionVMCollectionView> Site { get; set; } 
        public IRPSCollectionComboBox<ManufacturingPrevisionVMCollectionView> Article { get; set; } 
        public IRPSComboBox<ManufacturingPrevisionVMCollectionView> eState { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMCollectionView> DateFrom { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMCollectionView> DateTo { get; set; } 
        public IRPSButton<ManufacturingPrevisionVMCollectionView> CommandChangeStateButton { get; set; } 
        public IRPSButton<ManufacturingPrevisionVMCollectionView> CommandDeleteButton { get; set; } 
        public IRPSButton<ManufacturingPrevisionVMCollectionView,MassiveDeleteDialogView> MassiveDeleteNavigationCommandButton { get; set; } 
        public ManufacturingPrevisionQueryCollectionEditor<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView> ManufacturingPrevisionQuery { get; set; } 
        public ManufacturingPrevision Screen { get; set; }
        public ManufacturingPrevisionVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingPrevisionQueryCollectionEditor<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView>:RPSCollectionEditor<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView> where ManufacturingPrevisionVMCollectionView : class, IView where ManufacturingPrevisionVMEntityView : class, IView
    {
        public  ManufacturingPrevisionQueryGridView<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView> GridView {get;set;}
    }
    public partial class ManufacturingPrevisionQueryGridView <ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView> :  RPSGridView<ManufacturingPrevisionVMCollectionView,ManufacturingPrevisionVMEntityView> where ManufacturingPrevisionVMCollectionView : class, IView where ManufacturingPrevisionVMEntityView : class, IView
    {
        public ManufacturingPrevisionQueryGridView(ManufacturingPrevisionVMCollectionView currentView,ManufacturingPrevisionVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",true, this.CurrentView);
 
            PrevisionDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cPrevisionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridEnumComboBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cState']","",true, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManufacturingPrevisionVMCollectionView>("","#db20cd46-5b8c-48da-bb5c-dcd842927a45 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ManufacturingPrevisionVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<ManufacturingPrevisionVMCollectionView> CreationDate { get; set; } 
        public IRPSGridTextBox<ManufacturingPrevisionVMCollectionView> PrevisionDate { get; set; } 
        public IRPSGridTextBox<ManufacturingPrevisionVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<ManufacturingPrevisionVMCollectionView> State { get; set; } 
        public IRPSGridTextBox<ManufacturingPrevisionVMCollectionView> InternalCode { get; set; } 
                     
    }
 
    }
  
            
    public partial class ManufacturingPrevisionVMEntityView : View
    {
        public ManufacturingPrevisionVMEntityView(ManufacturingPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManufacturingPrevisionVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView>( this,Screen.ManufacturingPrevisionVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView>( this,Screen.ManufacturingPrevisionVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView>( this,Screen.ManufacturingPrevisionVMCollectionView);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<ManufacturingPrevisionVMEntityView>("7812229f-b338-4f9d-94d3-f869f85a69d6","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ManufacturingPrevisionVMEntityView>("b5762bec-a210-49c9-813f-2483efdfdefb","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ManufacturingPrevisionVMEntityView>("6e155058-29fa-4d06-b342-2ab37d79338c","","",true, this);
 
            PrevisionDate = RPSControlFactory.CreateRPSTextBox<ManufacturingPrevisionVMEntityView>("8cfbf5b0-2f79-4ec8-9b0a-fd93be1523be","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingPrevisionVMEntityView>("54d62f07-4d27-412e-89e8-2153c6d6b397","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingPrevisionVMEntityView>("0d16917e-7747-4122-b833-d9efcaf59b99","","",false, this);
 
            State = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingPrevisionVMEntityView>("83e13efc-e1c5-406f-8bb0-c115aab9ccd9","","",true, this);
 

        }
        public IRPSButton<ManufacturingPrevisionVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<ManufacturingPrevisionVMEntityView,ManufacturingPrevisionVMCollectionView> AcceptButton { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMEntityView> CreationDate { get; set; } 
        public IRPSComboBox<ManufacturingPrevisionVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ManufacturingPrevisionVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMEntityView> PrevisionDate { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ManufacturingPrevisionVMEntityView> InternalCode { get; set; } 
        public IRPSComboBox<ManufacturingPrevisionVMEntityView> State { get; set; } 
        public ManufacturingPrevision Screen { get; set; }
        public ManufacturingPrevisionVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MassiveDeleteDialogView : View
    {
        public MassiveDeleteDialogView(ManufacturingPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MassiveDeleteDialogView>("06722bc9-add3-495d-a742-259b05f5cb7f","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MassiveDeleteDialogView>("7e64c5fb-848f-4cb2-9864-31db7fb45e5d","","",false, this);
 
            eState = RPSControlFactory.CreateRPSEnumComboBox<MassiveDeleteDialogView>("2b3c7b13-4686-4d2b-abe8-e7598746b57c","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MassiveDeleteDialogView>("0dc5aef2-c228-4745-bf2e-3dcf4fef9bb0","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MassiveDeleteDialogView>("2dd4e143-ffb5-4c2b-9045-f0e7c79a7533","","",false, this);
 
            CommandMassiveDelete = RPSControlFactory.CreateRPSButton<MassiveDeleteDialogView>( "2e46e6ce-3fef-4aa6-818b-9a6f452a47d1","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<MassiveDeleteDialogView>( "5a5ea570-1c33-44ec-8b9d-1a17beb22414","","",this);
 

        }
        public IRPSComboBox<MassiveDeleteDialogView> Site { get; set; } 
        public IRPSCollectionComboBox<MassiveDeleteDialogView> Article { get; set; } 
        public IRPSComboBox<MassiveDeleteDialogView> eState { get; set; } 
        public IRPSTextBox<MassiveDeleteDialogView> DateFrom { get; set; } 
        public IRPSTextBox<MassiveDeleteDialogView> DateTo { get; set; } 
        public IRPSButton<MassiveDeleteDialogView> CommandMassiveDelete { get; set; } 
        public IRPSButton<MassiveDeleteDialogView> LinkNavigationCommand { get; set; } 
        public ManufacturingPrevision Screen { get; set; }
        public MassiveDeleteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
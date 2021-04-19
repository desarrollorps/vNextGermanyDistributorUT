    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PackingList
{
    //RPS VERSION 1.0.0.0
    public partial class PackingList:Screen
    {
        public PackingList():base()
        {
            this.URL = "sales.packinglist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PackingListSLCollectionView  = new PackingListSLCollectionView(this); 
            PackingListSLEntityView  = new PackingListSLEntityView(this); 
            PackingListBoxSLView  = new PackingListBoxSLView(this); 
            PackingListNewDetailDialogView  = new PackingListNewDetailDialogView(this); 
            SearchPackingListDialogView  = new SearchPackingListDialogView(this); 
            PackingListReportDialogView  = new PackingListReportDialogView(this); 
            PackingListLabelReportDialogView  = new PackingListLabelReportDialogView(this); 
            NewFromWizardDialogView  = new NewFromWizardDialogView(this); 
            NewFromWizardResultDialogView  = new NewFromWizardResultDialogView(this); 
            CuDistPackingListWizardChildDialogView  = new CuDistPackingListWizardChildDialogView(this); 
            PackingListSLCollectionView.InitializeControls(); 
            PackingListSLEntityView.InitializeControls(); 
            PackingListBoxSLView.InitializeControls(); 
            PackingListNewDetailDialogView.InitializeControls(); 
            SearchPackingListDialogView.InitializeControls(); 
            PackingListReportDialogView.InitializeControls(); 
            PackingListLabelReportDialogView.InitializeControls(); 
            NewFromWizardDialogView.InitializeControls(); 
            NewFromWizardResultDialogView.InitializeControls(); 
            CuDistPackingListWizardChildDialogView.InitializeControls(); 
           
        }
      
            public PackingListSLCollectionView PackingListSLCollectionView {get; set; } 
            public PackingListSLEntityView PackingListSLEntityView {get; set; } 
            public PackingListBoxSLView PackingListBoxSLView {get; set; } 
            public PackingListNewDetailDialogView PackingListNewDetailDialogView {get; set; } 
            public SearchPackingListDialogView SearchPackingListDialogView {get; set; } 
            public PackingListReportDialogView PackingListReportDialogView {get; set; } 
            public PackingListLabelReportDialogView PackingListLabelReportDialogView {get; set; } 
            public NewFromWizardDialogView NewFromWizardDialogView {get; set; } 
            public NewFromWizardResultDialogView NewFromWizardResultDialogView {get; set; } 
            public CuDistPackingListWizardChildDialogView CuDistPackingListWizardChildDialogView {get; set; } 
    }
            
    public partial class PackingListSLCollectionView : View
    {
        public PackingListSLCollectionView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PackingListSLCollectionView,PackingListSLEntityView>( this,Screen.PackingListSLEntityView);
 
            SearchPackingListCommandButton = RPSControlFactory.CreateRPSButtonToView<PackingListSLCollectionView,SearchPackingListDialogView>("8dba9b81-2f23-4c3b-a039-5028ffded19b","","", this,Screen.SearchPackingListDialogView);
 
            CuDistPackingListWizardCommandButton = RPSControlFactory.CreateRPSButton<PackingListSLCollectionView>( "3c3f92bb-e116-4a6d-a0ff-4c5d05c93dcb","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<PackingListSLCollectionView>( "6a0c1578-e00b-4c58-a88a-90a970984aa0","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "34d97f70-baf5-4cbc-a0d8-6f6377e2e058",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PackingListSLCollectionView,PackingListSLEntityView>( params_MainConsult,this,Screen.PackingListSLEntityView);
 

        }
        public IRPSButton<PackingListSLCollectionView,PackingListSLEntityView> NewButton { get; set; } 
        public IRPSButton<PackingListSLCollectionView,SearchPackingListDialogView> SearchPackingListCommandButton { get; set; } 
        public IRPSButton<PackingListSLCollectionView> CuDistPackingListWizardCommandButton { get; set; } 
        public IRPSButton<PackingListSLCollectionView> LinkNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<PackingListSLCollectionView,PackingListSLEntityView> MainConsult { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PackingListSLEntityView : View
    {
        public PackingListSLEntityView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PackingListSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PackingListSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PackingListSLEntityView,PackingListSLCollectionView>( this,Screen.PackingListSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PackingListSLEntityView,PackingListSLCollectionView>( this,Screen.PackingListSLCollectionView);
 
            CodPackingList = RPSControlFactory.CreateRPSTextBox<PackingListSLEntityView>("81905ff5-77ee-4b43-8c28-0cc0126f9314","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<PackingListSLEntityView>("53592d40-f6a1-4cbc-820d-c609e12e9a00","","",true, this);
 
            PackingDate = RPSControlFactory.CreateRPSTextBox<PackingListSLEntityView>("82046588-36f0-40cd-b1b5-ce17a50a0f17","","",true, this);
 
            Finished = RPSControlFactory.CreateRPSCheckBox<PackingListSLEntityView>("7e10e0ea-76c0-41b6-b4e3-9cc181427196","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PackingListSLEntityView>("0c91a881-d6e0-4409-a666-881c8f8e6c63","","",false, this);
 
            FinishCommandButton = RPSControlFactory.CreateRPSButton<PackingListSLEntityView>( "fd50edd3-9356-4e0c-b5f2-c629f362f6a7","","",this);
 
            ReopenPackingListCommandButton = RPSControlFactory.CreateRPSButton<PackingListSLEntityView>( "115c9d84-65e3-4454-8091-499ff30ebf11","","",this);
 
            TotalCalculateWeightCommandButton = RPSControlFactory.CreateRPSButton<PackingListSLEntityView>( "5b781360-5ef9-46d7-9caa-90e307883d4b","","",this);
 
            PackingListReportNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PackingListSLEntityView,PackingListReportDialogView>("5bb7631d-f8e6-4841-82d8-205beb0a02fd","","", this,Screen.PackingListReportDialogView);
 
            PackingListLabelReportNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PackingListSLEntityView,PackingListLabelReportDialogView>("e3741d60-dcfd-4c46-84f3-2fd5c3581aab","","", this,Screen.PackingListLabelReportDialogView);
 
            CollectionInit params_PackingListBoxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0afc6a0f-265a-4108-a2cc-3da1d8d58a86",CSSSelectorGrid="",XPathGrid=""};
            PackingListBoxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListBoxSLsCollectionEditor<PackingListSLEntityView,PackingListBoxSLView>,PackingListSLEntityView,PackingListBoxSLView>( params_PackingListBoxSLs,this,Screen.PackingListBoxSLView);
 
            CollectionInit params_PackingListSummary = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03170f4f-2cce-48b8-a592-474724d2326f",CSSSelectorGrid="",XPathGrid=""};
            PackingListSummary = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListSummaryCollectionEditor<PackingListSLEntityView,PackingListBoxSLView>,PackingListSLEntityView,PackingListBoxSLView>( params_PackingListSummary,this,Screen.PackingListBoxSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PackingListSLEntityView>( "","ul li[rpsid='135ace54-d6fe-402e-bd1a-7b3b51aa7e91']","",this);
 
            SummarySection = RPSControlFactory.CreateRPSSection<PackingListSLEntityView>( "","ul li[rpsid='745da14d-bdd6-496d-b0e6-6e3b26c576b9']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<PackingListSLEntityView>( "","ul li[rpsid='8dba0740-9588-4bdd-924c-9dc5c0a0d8d5']","",this);
 

        }
        public IRPSSaveButton<PackingListSLEntityView> SaveButton { get; set; } 
        public IRPSButton<PackingListSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<PackingListSLEntityView,PackingListSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PackingListSLEntityView,PackingListSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PackingListSLEntityView> CodPackingList { get; set; } 
        public IRPSComboBox<PackingListSLEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<PackingListSLEntityView> PackingDate { get; set; } 
        public IRPSCheckbox<PackingListSLEntityView> Finished { get; set; } 
        public IRPSTextBox<PackingListSLEntityView> Comment { get; set; } 
        public IRPSButton<PackingListSLEntityView> FinishCommandButton { get; set; } 
        public IRPSButton<PackingListSLEntityView> ReopenPackingListCommandButton { get; set; } 
        public IRPSButton<PackingListSLEntityView> TotalCalculateWeightCommandButton { get; set; } 
        public IRPSButton<PackingListSLEntityView,PackingListReportDialogView> PackingListReportNavigationCommandButton { get; set; } 
        public IRPSButton<PackingListSLEntityView,PackingListLabelReportDialogView> PackingListLabelReportNavigationCommandButton { get; set; } 
        public PackingListBoxSLsCollectionEditor<PackingListSLEntityView,PackingListBoxSLView> PackingListBoxSLs { get; set; } 
        public PackingListSummaryCollectionEditor<PackingListSLEntityView,PackingListBoxSLView> PackingListSummary { get; set; } 
        public IRPSSection<PackingListSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<PackingListSLEntityView> SummarySection { get; set; } 
        public IRPSSection<PackingListSLEntityView> CommentSection { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListBoxSLsCollectionEditor<PackingListSLEntityView,PackingListBoxSLView>:RPSCollectionEditor<PackingListSLEntityView,PackingListBoxSLView> where PackingListSLEntityView : class, IView where PackingListBoxSLView : class, IView
    {
        public  PackingListBoxSLsGridView<PackingListSLEntityView,PackingListBoxSLView> GridView {get;set;}
    }
    public partial class PackingListBoxSLsGridView <PackingListSLEntityView,PackingListBoxSLView> :  RPSGridView<PackingListSLEntityView,PackingListBoxSLView> where PackingListSLEntityView : class, IView where PackingListBoxSLView : class, IView
    {
        public PackingListBoxSLsGridView(PackingListSLEntityView currentView,PackingListBoxSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",true, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",true, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",true, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",true, this.CurrentView);
 
            Height = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cHeight']","",true, this.CurrentView);
 
            Length = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cLength']","",true, this.CurrentView);
 
            Width = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cWidth']","",true, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#0afc6a0f-265a-4108-a2cc-3da1d8d58a86 .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListSLEntityView> BoxNumber { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Comment { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> GrossWeight { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> NetWeight { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Volume { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Height { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Length { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Width { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> LabelNumber { get; set; } 
                     
    }
 
        public partial class PackingListSummaryCollectionEditor<PackingListSLEntityView,PackingListBoxSLView>:RPSCollectionEditor<PackingListSLEntityView,PackingListBoxSLView> where PackingListSLEntityView : class, IView where PackingListBoxSLView : class, IView
    {
        public  PackingListSummaryGridView<PackingListSLEntityView,PackingListBoxSLView> GridView {get;set;}
    }
    public partial class PackingListSummaryGridView <PackingListSLEntityView,PackingListBoxSLView> :  RPSGridView<PackingListSLEntityView,PackingListBoxSLView> where PackingListSLEntityView : class, IView where PackingListBoxSLView : class, IView
    {
        public PackingListSummaryGridView(PackingListSLEntityView currentView,PackingListBoxSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",false, this.CurrentView);
 
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",false, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Serie = RPSControlFactory.CreateRPSGridTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",true, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",true, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",true, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListSLEntityView>("","#03170f4f-2cce-48b8-a592-474724d2326f .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListSLEntityView> BoxNumber { get; set; } 
        public IRPSGridComboBox<PackingListSLEntityView> IDOrderLine { get; set; } 
        public IRPSGridComboBox<PackingListSLEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridComboBox<PackingListSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Serie { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> GrossWeight { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> NetWeight { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> Volume { get; set; } 
        public IRPSGridTextBox<PackingListSLEntityView> LabelNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class PackingListBoxSLView : View
    {
        public PackingListBoxSLView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<PackingListBoxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PackingListBoxSLView,PackingListSLEntityView>( this,Screen.PackingListSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<PackingListBoxSLView,PackingListSLEntityView>( this,Screen.PackingListSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<PackingListBoxSLView,PackingListSLEntityView>( this,Screen.PackingListSLEntityView);
 
            BoxNumber = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("ce2bc3fc-c014-49f5-b598-1d57aa5aa59f","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PackingListBoxSLView>("9f23dd7a-1e86-4d35-8712-1a69f03530ff","","",false, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("539baddf-8da2-48f8-803e-e87dc4de1b42","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("8a715e99-d277-4465-8270-97d2f07714df","","",true, this);
 
            Volume = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("7eeb199d-3fb5-4c31-a17a-fc06fd5f293a","","",true, this);
 
            LabelNumber = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("793f5b4f-10ee-4575-a82f-f66a9ddc9cbb","","",true, this);
 
            Height = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("8fd3929c-943f-4b2b-b239-bc9b35402fc5","","",true, this);
 
            Length = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("792d9137-f444-48a2-9cf5-049970a5e9f8","","",true, this);
 
            Width = RPSControlFactory.CreateRPSFormattedTextBox<PackingListBoxSLView>("7b263e0d-00ad-4d74-847b-dd13e192962b","","",true, this);
 
            OpenNewDetailCommand = RPSControlFactory.CreateRPSButtonToView<PackingListBoxSLView,PackingListNewDetailDialogView>("4cd8c2d0-12df-485d-b764-6549e375fd56","","", this,Screen.PackingListNewDetailDialogView);
 
            CalculateWeightCommandButton = RPSControlFactory.CreateRPSButton<PackingListBoxSLView>( "8f7f78ae-ae64-495b-a057-2f8b46f3fa31","","",this);
 
            CollectionInit params_PackingListBoxDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14442498-1d46-472f-a753-9f42254a9954",CSSSelectorGrid="",XPathGrid=""};
            PackingListBoxDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListBoxDetailSLsCollectionEditor<PackingListBoxSLView,PackingListNewDetailDialogView>,PackingListBoxSLView,PackingListNewDetailDialogView>( params_PackingListBoxDetailSLs,this,Screen.PackingListNewDetailDialogView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PackingListBoxSLView>( "","ul li[rpsid='f4e3a90a-340b-493b-b1fc-79264b3f5677']","",this);
 

        }
        public IRPSButton<PackingListBoxSLView> DeleteButton { get; set; } 
        public IRPSButton<PackingListBoxSLView,PackingListSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PackingListBoxSLView,PackingListSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<PackingListBoxSLView,PackingListSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> BoxNumber { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> Comment { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> GrossWeight { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> NetWeight { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> Volume { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> LabelNumber { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> Height { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> Length { get; set; } 
        public IRPSTextBox<PackingListBoxSLView> Width { get; set; } 
        public IRPSButton<PackingListBoxSLView,PackingListNewDetailDialogView> OpenNewDetailCommand { get; set; } 
        public IRPSButton<PackingListBoxSLView> CalculateWeightCommandButton { get; set; } 
        public PackingListBoxDetailSLsCollectionEditor<PackingListBoxSLView,PackingListNewDetailDialogView> PackingListBoxDetailSLs { get; set; } 
        public IRPSSection<PackingListBoxSLView> GeneralDataSection { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListBoxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListBoxDetailSLsCollectionEditor<PackingListBoxSLView,PackingListNewDetailDialogView>:RPSCollectionEditor<PackingListBoxSLView,PackingListNewDetailDialogView> where PackingListBoxSLView : class, IView where PackingListNewDetailDialogView : class, IView
    {
        public  PackingListBoxDetailSLsGridView<PackingListBoxSLView,PackingListNewDetailDialogView> GridView {get;set;}
    }
    public partial class PackingListBoxDetailSLsGridView <PackingListBoxSLView,PackingListNewDetailDialogView> :  RPSGridView<PackingListBoxSLView,PackingListNewDetailDialogView> where PackingListBoxSLView : class, IView where PackingListNewDetailDialogView : class, IView
    {
        public PackingListBoxDetailSLsGridView(PackingListBoxSLView currentView,PackingListNewDetailDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",false, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Serie = RPSControlFactory.CreateRPSGridTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",true, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",true, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",true, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListBoxSLView>("","#14442498-1d46-472f-a753-9f42254a9954 .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PackingListBoxSLView> IDOrderLine { get; set; } 
        public IRPSGridComboBox<PackingListBoxSLView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridComboBox<PackingListBoxSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> Serie { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> Quantity { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> GrossWeight { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> NetWeight { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> Volume { get; set; } 
        public IRPSGridTextBox<PackingListBoxSLView> LabelNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class PackingListNewDetailDialogView : View
    {
        public PackingListNewDetailDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptProposal = RPSControlFactory.CreateRPSOption<PackingListNewDetailDialogView>( "8cd596bd-9476-453d-9729-4330be5bc830","","",this);
 
            UIOptOrders = RPSControlFactory.CreateRPSOption<PackingListNewDetailDialogView>( "30b8e79a-c977-41bc-9174-51bd3feba915","","",this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<PackingListNewDetailDialogView>("e6513dde-6e09-48f4-8e80-1848a8e4336a","","",false, this);
 
            UIOptDeliveryNotes = RPSControlFactory.CreateRPSOption<PackingListNewDetailDialogView>( "b6d91a62-8766-4a44-b646-bbd106dac5a7","","",this);
 
            UIDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<PackingListNewDetailDialogView>("f92f03fe-be72-4b85-ad15-31038a408944","","",false, this);
 
            CollectionInit params_OrdersForPackingList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e14a5f03-db20-478b-9ca9-d044f716ff38",CSSSelectorGrid="",XPathGrid=""};
            OrdersForPackingList = RPSControlFactory.RPSCreateCollectionWithGrid<OrdersForPackingListCollectionEditor<PackingListNewDetailDialogView>,PackingListNewDetailDialogView>( params_OrdersForPackingList,this);
 
            CollectionInit params_DeliveryNotesForPackingList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b86ba9c8-3513-4678-8ccf-b3e99bbb18b3",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNotesForPackingList = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNotesForPackingListCollectionEditor<PackingListNewDetailDialogView>,PackingListNewDetailDialogView>( params_DeliveryNotesForPackingList,this);
 
            CollectionInit params_ProposalsForPackingList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1abcb7c5-d6b5-4271-83d8-faee87419b93",CSSSelectorGrid="",XPathGrid=""};
            ProposalsForPackingList = RPSControlFactory.RPSCreateCollectionWithGrid<ProposalsForPackingListCollectionEditor<PackingListNewDetailDialogView>,PackingListNewDetailDialogView>( params_ProposalsForPackingList,this);
 

        }
        public IRPSOption<PackingListNewDetailDialogView> UIOptProposal { get; set; } 
        public IRPSOption<PackingListNewDetailDialogView> UIOptOrders { get; set; } 
        public IRPSComboBox<PackingListNewDetailDialogView> UIOrderSL { get; set; } 
        public IRPSOption<PackingListNewDetailDialogView> UIOptDeliveryNotes { get; set; } 
        public IRPSComboBox<PackingListNewDetailDialogView> UIDeliveryNoteSL { get; set; } 
        public OrdersForPackingListCollectionEditor<PackingListNewDetailDialogView> OrdersForPackingList { get; set; } 
        public DeliveryNotesForPackingListCollectionEditor<PackingListNewDetailDialogView> DeliveryNotesForPackingList { get; set; } 
        public ProposalsForPackingListCollectionEditor<PackingListNewDetailDialogView> ProposalsForPackingList { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListNewDetailDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrdersForPackingListCollectionEditor<PackingListNewDetailDialogView>:RPSCollectionEditor<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public  OrdersForPackingListGridView<PackingListNewDetailDialogView> GridView {get;set;}
    }
    public partial class OrdersForPackingListGridView <PackingListNewDetailDialogView> :  RPSGridView<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public OrdersForPackingListGridView(PackingListNewDetailDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#e14a5f03-db20-478b-9ca9-d044f716ff38 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#e14a5f03-db20-478b-9ca9-d044f716ff38 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            Kit = RPSControlFactory.CreateRPSGridTextBox<PackingListNewDetailDialogView>("","#e14a5f03-db20-478b-9ca9-d044f716ff38 .ag-row[role='row']@ROWINDEX [col-id='cKit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListNewDetailDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> Kit { get; set; } 
                     
    }
 
        public partial class DeliveryNotesForPackingListCollectionEditor<PackingListNewDetailDialogView>:RPSCollectionEditor<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public  DeliveryNotesForPackingListGridView<PackingListNewDetailDialogView> GridView {get;set;}
    }
    public partial class DeliveryNotesForPackingListGridView <PackingListNewDetailDialogView> :  RPSGridView<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public DeliveryNotesForPackingListGridView(PackingListNewDetailDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<PackingListNewDetailDialogView>("","#b86ba9c8-3513-4678-8ccf-b3e99bbb18b3 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#b86ba9c8-3513-4678-8ccf-b3e99bbb18b3 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#b86ba9c8-3513-4678-8ccf-b3e99bbb18b3 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            Kit = RPSControlFactory.CreateRPSGridTextBox<PackingListNewDetailDialogView>("","#b86ba9c8-3513-4678-8ccf-b3e99bbb18b3 .ag-row[role='row']@ROWINDEX [col-id='cKit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListNewDetailDialogView> Series { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> Kit { get; set; } 
                     
    }
 
        public partial class ProposalsForPackingListCollectionEditor<PackingListNewDetailDialogView>:RPSCollectionEditor<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public  ProposalsForPackingListGridView<PackingListNewDetailDialogView> GridView {get;set;}
    }
    public partial class ProposalsForPackingListGridView <PackingListNewDetailDialogView> :  RPSGridView<PackingListNewDetailDialogView> where PackingListNewDetailDialogView : class, IView
    {
        public ProposalsForPackingListGridView(PackingListNewDetailDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#1abcb7c5-d6b5-4271-83d8-faee87419b93 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#1abcb7c5-d6b5-4271-83d8-faee87419b93 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PackingListNewDetailDialogView>("","#1abcb7c5-d6b5-4271-83d8-faee87419b93 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            Kit = RPSControlFactory.CreateRPSGridTextBox<PackingListNewDetailDialogView>("","#1abcb7c5-d6b5-4271-83d8-faee87419b93 .ag-row[role='row']@ROWINDEX [col-id='cKit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListNewDetailDialogView> Ordenation { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<PackingListNewDetailDialogView> Kit { get; set; } 
                     
    }
 
    }
  
            
    public partial class SearchPackingListDialogView : View
    {
        public SearchPackingListDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptOrder = RPSControlFactory.CreateRPSOption<SearchPackingListDialogView>( "d1aa0885-03c0-4b51-9478-39789db2b786","","",this);
 
            UIOptDeliveryNote = RPSControlFactory.CreateRPSOption<SearchPackingListDialogView>( "0a6d0638-bd84-43c1-b575-17bf5f6f02bf","","",this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<SearchPackingListDialogView>("c0fbb784-dcd8-4588-8a24-ba1fbeaaf311","","",false, this);
 
            UIDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<SearchPackingListDialogView>("22833285-9736-4e94-8727-0ec3181ebb01","","",false, this);
 
            CollectionInit params_SearchPackingListFromOrder = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ac236f9-d29e-44eb-9ca4-321a764dc2e9",CSSSelectorGrid="",XPathGrid=""};
            SearchPackingListFromOrder = RPSControlFactory.RPSCreateCollectionWithGrid<SearchPackingListFromOrderCollectionEditor<SearchPackingListDialogView>,SearchPackingListDialogView>( params_SearchPackingListFromOrder,this);
 
            CollectionInit params_SearchPackingListFromDeliveryNote = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="314c88c2-8469-452d-b6b8-6e6a3d275c37",CSSSelectorGrid="",XPathGrid=""};
            SearchPackingListFromDeliveryNote = RPSControlFactory.RPSCreateCollectionWithGrid<SearchPackingListFromDeliveryNoteCollectionEditor<SearchPackingListDialogView>,SearchPackingListDialogView>( params_SearchPackingListFromDeliveryNote,this);
 

        }
        public IRPSOption<SearchPackingListDialogView> UIOptOrder { get; set; } 
        public IRPSOption<SearchPackingListDialogView> UIOptDeliveryNote { get; set; } 
        public IRPSComboBox<SearchPackingListDialogView> UIOrderSL { get; set; } 
        public IRPSComboBox<SearchPackingListDialogView> UIDeliveryNoteSL { get; set; } 
        public SearchPackingListFromOrderCollectionEditor<SearchPackingListDialogView> SearchPackingListFromOrder { get; set; } 
        public SearchPackingListFromDeliveryNoteCollectionEditor<SearchPackingListDialogView> SearchPackingListFromDeliveryNote { get; set; } 
        public PackingList Screen { get; set; }
        public SearchPackingListDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SearchPackingListFromOrderCollectionEditor<SearchPackingListDialogView>:RPSCollectionEditor<SearchPackingListDialogView> where SearchPackingListDialogView : class, IView
    {
        public  SearchPackingListFromOrderGridView<SearchPackingListDialogView> GridView {get;set;}
    }
    public partial class SearchPackingListFromOrderGridView <SearchPackingListDialogView> :  RPSGridView<SearchPackingListDialogView> where SearchPackingListDialogView : class, IView
    {
        public SearchPackingListFromOrderGridView(SearchPackingListDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",false, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",false, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",false, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#3ac236f9-d29e-44eb-9ca4-321a764dc2e9 .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SearchPackingListDialogView> BoxNumber { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> GrossWeight { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> NetWeight { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> Volume { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> LabelNumber { get; set; } 
                     
    }
 
        public partial class SearchPackingListFromDeliveryNoteCollectionEditor<SearchPackingListDialogView>:RPSCollectionEditor<SearchPackingListDialogView> where SearchPackingListDialogView : class, IView
    {
        public  SearchPackingListFromDeliveryNoteGridView<SearchPackingListDialogView> GridView {get;set;}
    }
    public partial class SearchPackingListFromDeliveryNoteGridView <SearchPackingListDialogView> :  RPSGridView<SearchPackingListDialogView> where SearchPackingListDialogView : class, IView
    {
        public SearchPackingListFromDeliveryNoteGridView(SearchPackingListDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",false, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",false, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",false, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SearchPackingListDialogView>("","#314c88c2-8469-452d-b6b8-6e6a3d275c37 .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SearchPackingListDialogView> BoxNumber { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> GrossWeight { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> NetWeight { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> Volume { get; set; } 
        public IRPSGridTextBox<SearchPackingListDialogView> LabelNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class PackingListReportDialogView : View
    {
        public PackingListReportDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIFinalizePacking = RPSControlFactory.CreateRPSCheckBox<PackingListReportDialogView>("3fab70dc-12d3-40ca-bf9c-61356196fdd1","","",false, this);
 
            UIOptCustomer = RPSControlFactory.CreateRPSOption<PackingListReportDialogView>( "240a61d4-ce59-44c6-8843-061791b5828b","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<PackingListReportDialogView>( "d448a903-9deb-4801-bac5-20573c79597f","","",this);
 
            UILanguage = RPSControlFactory.CreateRPSComboBox<PackingListReportDialogView>("008cc42b-207f-4b65-8ec4-65ac9d73ccf7","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PackingListReportDialogView>("328817d9-9e46-4f40-9c0c-b95d64d1733e","","",false, this);
 
            UICustomReport = RPSControlFactory.CreateRPSComboBox<PackingListReportDialogView>("e972025f-1d18-4b31-8817-4e3fc455e51f","","",false, this);
 
            PrintPackingListCommandButton = RPSControlFactory.CreateRPSButton<PackingListReportDialogView>( "370ba9e2-5d8b-455a-825d-6d3145df72d2","","",this);
 
            SendPackingListByEmailCommandButton = RPSControlFactory.CreateRPSButton<PackingListReportDialogView>( "6b946508-8b19-48d1-9ba0-2994dd8b3899","","",this);
 
            SendPackingListToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PackingListReportDialogView>( "aa1ca575-b724-4bd0-8a57-bc57833f5991","","",this);
 

        }
        public IRPSCheckbox<PackingListReportDialogView> UIFinalizePacking { get; set; } 
        public IRPSOption<PackingListReportDialogView> UIOptCustomer { get; set; } 
        public IRPSOption<PackingListReportDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<PackingListReportDialogView> UILanguage { get; set; } 
        public IRPSCheckbox<PackingListReportDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PackingListReportDialogView> UICustomReport { get; set; } 
        public IRPSButton<PackingListReportDialogView> PrintPackingListCommandButton { get; set; } 
        public IRPSButton<PackingListReportDialogView> SendPackingListByEmailCommandButton { get; set; } 
        public IRPSButton<PackingListReportDialogView> SendPackingListToCustomerEmailCommandButton { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListReportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PackingListLabelReportDialogView : View
    {
        public PackingListLabelReportDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptByLabelNumber = RPSControlFactory.CreateRPSOption<PackingListLabelReportDialogView>( "6086a9b8-e70f-403b-be60-2b7cf6ac9ebe","","",this);
 
            UIOptByLabel = RPSControlFactory.CreateRPSOption<PackingListLabelReportDialogView>( "131188ff-b915-4134-993b-8200843460a6","","",this);
 
            PrintPackingListLabelsCommandButton = RPSControlFactory.CreateRPSButton<PackingListLabelReportDialogView>( "d57af0c9-48f9-46ae-ae20-997e2e42ef79","","",this);
 

        }
        public IRPSOption<PackingListLabelReportDialogView> UIOptByLabelNumber { get; set; } 
        public IRPSOption<PackingListLabelReportDialogView> UIOptByLabel { get; set; } 
        public IRPSButton<PackingListLabelReportDialogView> PrintPackingListLabelsCommandButton { get; set; } 
        public PackingList Screen { get; set; }
        public PackingListLabelReportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromWizardDialogView : View
    {
        public NewFromWizardDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodPackingList = RPSControlFactory.CreateRPSTextBox<NewFromWizardDialogView>("c9ce1e81-f8b1-488a-8cf9-d8e8146b7ce8","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<NewFromWizardDialogView>("bf2be7ad-d39d-4e3b-a1da-7fe67f9652d3","","",true, this);
 
            UIOptProposal = RPSControlFactory.CreateRPSOption<NewFromWizardDialogView>( "fb47dd06-cd02-4d9a-8f7d-a861308238e6","","",this);
 
            UIOptOrders = RPSControlFactory.CreateRPSOption<NewFromWizardDialogView>( "f015e1f0-be6e-41f5-a7f0-6044467f3de3","","",this);
 
            IDOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<NewFromWizardDialogView>("b5a6cb0f-31e0-4d79-883c-b37a812edcfb","","",false, this);
 
            UIOptDeliveryNotes = RPSControlFactory.CreateRPSOption<NewFromWizardDialogView>( "5642ee1c-6bf5-470c-a56b-3b4080176bbd","","",this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSCollectionComboBox<NewFromWizardDialogView>("2e7bc63f-7605-4e7b-9e55-23cfcb0a1e28","","",false, this);
 
            OneBox = RPSControlFactory.CreateRPSOption<NewFromWizardDialogView>( "6fc712ea-e7a1-4e59-8cb5-79aeaa3656a6","","",this);
 
            NBoxes = RPSControlFactory.CreateRPSOption<NewFromWizardDialogView>( "ff3155bf-701d-40dc-b153-fe4c57dee8b7","","",this);
 
            NewFromWizardResultNavigationCommand = RPSControlFactory.CreateRPSButtonToView<NewFromWizardDialogView,NewFromWizardResultDialogView>("54872dfa-dd73-4bb1-9e7f-27e7e704da94","","", this,Screen.NewFromWizardResultDialogView);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<NewFromWizardDialogView>( "ac1bc731-09d2-466e-90bc-4b7b843fab36","","",this);
 

        }
        public IRPSTextBox<NewFromWizardDialogView> CodPackingList { get; set; } 
        public IRPSComboBox<NewFromWizardDialogView> IDCustomer { get; set; } 
        public IRPSOption<NewFromWizardDialogView> UIOptProposal { get; set; } 
        public IRPSOption<NewFromWizardDialogView> UIOptOrders { get; set; } 
        public IRPSCollectionComboBox<NewFromWizardDialogView> IDOrderSL { get; set; } 
        public IRPSOption<NewFromWizardDialogView> UIOptDeliveryNotes { get; set; } 
        public IRPSCollectionComboBox<NewFromWizardDialogView> IDDeliveryNoteSL { get; set; } 
        public IRPSOption<NewFromWizardDialogView> OneBox { get; set; } 
        public IRPSOption<NewFromWizardDialogView> NBoxes { get; set; } 
        public IRPSButton<NewFromWizardDialogView,NewFromWizardResultDialogView> NewFromWizardResultNavigationCommand { get; set; } 
        public IRPSButton<NewFromWizardDialogView> LinkNavigationCommand { get; set; } 
        public PackingList Screen { get; set; }
        public NewFromWizardDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromWizardResultDialogView : View
    {
        public NewFromWizardResultDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AcceptCommand = RPSControlFactory.CreateRPSButton<NewFromWizardResultDialogView>( "df7e0007-47aa-4f08-a3da-d3650c17b905","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<NewFromWizardResultDialogView>( "8e4581d3-8f24-439c-9e71-d44f08cb5208","","",this);
 
            CollectionInit params_PackingListWizardCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9d094dff-2713-4c00-a5ed-e03583769297",CSSSelectorGrid="",XPathGrid=""};
            PackingListWizardCollection = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListWizardCollectionCollectionEditor<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView>,NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView>( params_PackingListWizardCollection,this,Screen.CuDistPackingListWizardChildDialogView);
 

        }
        public IRPSButton<NewFromWizardResultDialogView> AcceptCommand { get; set; } 
        public IRPSButton<NewFromWizardResultDialogView> LinkNavigationCommand { get; set; } 
        public PackingListWizardCollectionCollectionEditor<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView> PackingListWizardCollection { get; set; } 
        public PackingList Screen { get; set; }
        public NewFromWizardResultDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListWizardCollectionCollectionEditor<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView>:RPSCollectionEditor<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView> where NewFromWizardResultDialogView : class, IView where CuDistPackingListWizardChildDialogView : class, IView
    {
        public  PackingListWizardCollectionGridView<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView> GridView {get;set;}
    }
    public partial class PackingListWizardCollectionGridView <NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView> :  RPSGridView<NewFromWizardResultDialogView,CuDistPackingListWizardChildDialogView> where NewFromWizardResultDialogView : class, IView where CuDistPackingListWizardChildDialogView : class, IView
    {
        public PackingListWizardCollectionGridView(NewFromWizardResultDialogView currentView,CuDistPackingListWizardChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",false, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",false, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",false, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",false, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromWizardResultDialogView>("","#9d094dff-2713-4c00-a5ed-e03583769297 .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NewFromWizardResultDialogView> BoxNumber { get; set; } 
        public IRPSGridComboBox<NewFromWizardResultDialogView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridComboBox<NewFromWizardResultDialogView> IDOrderLine { get; set; } 
        public IRPSGridComboBox<NewFromWizardResultDialogView> IDArticle { get; set; } 
        public IRPSGridTextBox<NewFromWizardResultDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<NewFromWizardResultDialogView> GrossWeight { get; set; } 
        public IRPSGridTextBox<NewFromWizardResultDialogView> NetWeight { get; set; } 
        public IRPSGridTextBox<NewFromWizardResultDialogView> Volume { get; set; } 
        public IRPSGridTextBox<NewFromWizardResultDialogView> LabelNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistPackingListWizardChildDialogView : View
    {
        public CuDistPackingListWizardChildDialogView(PackingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodPackingList = RPSControlFactory.CreateRPSTextBox<CuDistPackingListWizardChildDialogView>("8230886c-f271-4501-b7ef-31b6b9b80da6","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CuDistPackingListWizardChildDialogView>("e740de69-4318-4fde-82fa-9a2ce349fd06","","",false, this);
 
            PackingListDate = RPSControlFactory.CreateRPSTextBox<CuDistPackingListWizardChildDialogView>("66253337-0747-4041-a68e-aad024af1984","","",true, this);
 
            OneBoxValue = RPSControlFactory.CreateRPSOption<CuDistPackingListWizardChildDialogView>( "7c59e56d-ec31-40a9-850d-0d32e7ef754c","","",this);
 
            NBoxesValue = RPSControlFactory.CreateRPSOption<CuDistPackingListWizardChildDialogView>( "1b0dec37-ee82-47cf-a65e-c1addca074fc","","",this);
 
            CollectionInit params_CuDistPackingListWizardOLQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe32d9f7-cd7b-4b27-9f35-d9ec4155827f",CSSSelectorGrid="",XPathGrid=""};
            CuDistPackingListWizardOLQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistPackingListWizardOLQueryCollectionEditor<CuDistPackingListWizardChildDialogView>,CuDistPackingListWizardChildDialogView>( params_CuDistPackingListWizardOLQuery,this);
 
            CollectionInit params_CuDistWizardLinesCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03583065-58ba-4f77-8db7-54e5369c652f",CSSSelectorGrid="",XPathGrid=""};
            CuDistWizardLinesCollection = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistWizardLinesCollectionCollectionEditor<CuDistPackingListWizardChildDialogView>,CuDistPackingListWizardChildDialogView>( params_CuDistWizardLinesCollection,this);
 

        }
        public IRPSTextBox<CuDistPackingListWizardChildDialogView> CodPackingList { get; set; } 
        public IRPSComboBox<CuDistPackingListWizardChildDialogView> IDCustomer { get; set; } 
        public IRPSTextBox<CuDistPackingListWizardChildDialogView> PackingListDate { get; set; } 
        public IRPSOption<CuDistPackingListWizardChildDialogView> OneBoxValue { get; set; } 
        public IRPSOption<CuDistPackingListWizardChildDialogView> NBoxesValue { get; set; } 
        public CuDistPackingListWizardOLQueryCollectionEditor<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardOLQuery { get; set; } 
        public CuDistWizardLinesCollectionCollectionEditor<CuDistPackingListWizardChildDialogView> CuDistWizardLinesCollection { get; set; } 
        public PackingList Screen { get; set; }
        public CuDistPackingListWizardChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistPackingListWizardOLQueryCollectionEditor<CuDistPackingListWizardChildDialogView>:RPSCollectionEditor<CuDistPackingListWizardChildDialogView> where CuDistPackingListWizardChildDialogView : class, IView
    {
        public  CuDistPackingListWizardOLQueryGridView<CuDistPackingListWizardChildDialogView> GridView {get;set;}
    }
    public partial class CuDistPackingListWizardOLQueryGridView <CuDistPackingListWizardChildDialogView> :  RPSGridView<CuDistPackingListWizardChildDialogView> where CuDistPackingListWizardChildDialogView : class, IView
    {
        public CuDistPackingListWizardOLQueryGridView(CuDistPackingListWizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistPackingListWizardView_CodOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_CodOrder']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_Description = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_Description']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_CodArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_CodArticle']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_TechnicalDescription']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_OrderDate = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_OrderDate']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_CodDeliveryAddress = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_CodDeliveryAddress']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_DescDeliveryAddress = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_DescDeliveryAddress']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_ReceptionDate']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_PlannedEndDate']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_AvailableWarehouse = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_AvailableWarehouse']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_PendingQuantity']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_CodManufacturingOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_CodManufacturingOrder']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_LastStartedTask = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_LastStartedTask']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_RealStartDate = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_RealStartDate']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_OrderNumberCustomer']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_OrderPriority = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_OrderPriority']","",false, this.CurrentView);
 
            CuDistPackingListWizardView_Drawing = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#fe32d9f7-cd7b-4b27-9f35-d9ec4155827f .ag-row[role='row']@ROWINDEX [col-id='cCuDistPackingListWizardView_Drawing']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_CodOrder { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_Description { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_CodArticle { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_TechnicalDescription { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_OrderDate { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_CodDeliveryAddress { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_DescDeliveryAddress { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_ReceptionDate { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_PlannedEndDate { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_AvailableWarehouse { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_PendingQuantity { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_CodManufacturingOrder { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_LastStartedTask { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_RealStartDate { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_OrderNumberCustomer { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_OrderPriority { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CuDistPackingListWizardView_Drawing { get; set; } 
                     
    }
 
        public partial class CuDistWizardLinesCollectionCollectionEditor<CuDistPackingListWizardChildDialogView>:RPSCollectionEditor<CuDistPackingListWizardChildDialogView> where CuDistPackingListWizardChildDialogView : class, IView
    {
        public  CuDistWizardLinesCollectionGridView<CuDistPackingListWizardChildDialogView> GridView {get;set;}
    }
    public partial class CuDistWizardLinesCollectionGridView <CuDistPackingListWizardChildDialogView> :  RPSGridView<CuDistPackingListWizardChildDialogView> where CuDistPackingListWizardChildDialogView : class, IView
    {
        public CuDistWizardLinesCollectionGridView(CuDistPackingListWizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BoxNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cBoxNumber']","",false, this.CurrentView);
 
            CodDocument = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cCodDocument']","",false, this.CurrentView);
 
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            CodArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cCodArticle']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            GrossWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cGrossWeight']","",false, this.CurrentView);
 
            NetWeight = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cNetWeight']","",false, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",false, this.CurrentView);
 
            LabelNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cLabelNumber']","",false, this.CurrentView);
 
            Height = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cHeight']","",false, this.CurrentView);
 
            Length = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cLength']","",false, this.CurrentView);
 
            Width = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistPackingListWizardChildDialogView>("","#03583065-58ba-4f77-8db7-54e5369c652f .ag-row[role='row']@ROWINDEX [col-id='cWidth']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> BoxNumber { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CodDocument { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> NumLine { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> CodArticle { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Description { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> GrossWeight { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> NetWeight { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Volume { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> LabelNumber { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Height { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Length { get; set; } 
        public IRPSGridTextBox<CuDistPackingListWizardChildDialogView> Width { get; set; } 
                     
    }
 
    }
  
    

}
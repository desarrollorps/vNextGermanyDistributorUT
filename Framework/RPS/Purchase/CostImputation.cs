    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.CostImputation
{
    //RPS VERSION 1.0.0.0
    public partial class CostImputation:Screen
    {
        public CostImputation():base()
        {
            this.URL = "purchase.costimputation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostImputationCollectionView  = new CostImputationCollectionView(this); 
            CostImputationEntityView  = new CostImputationEntityView(this); 
            RecalculatedChildDialogView  = new RecalculatedChildDialogView(this); 
            AddDeliveryNotePurSLChildDialogView  = new AddDeliveryNotePurSLChildDialogView(this); 
            CostImputationCollectionView.InitializeControls(); 
            CostImputationEntityView.InitializeControls(); 
            RecalculatedChildDialogView.InitializeControls(); 
            AddDeliveryNotePurSLChildDialogView.InitializeControls(); 
           
        }
      
            public CostImputationCollectionView CostImputationCollectionView {get; set; } 
            public CostImputationEntityView CostImputationEntityView {get; set; } 
            public RecalculatedChildDialogView RecalculatedChildDialogView {get; set; } 
            public AddDeliveryNotePurSLChildDialogView AddDeliveryNotePurSLChildDialogView {get; set; } 
    }
            
    public partial class CostImputationCollectionView : View
    {
        public CostImputationCollectionView(CostImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostImputationCollectionView,CostImputationEntityView>( this,Screen.CostImputationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4dd0e98f-c02b-4530-972e-1d8dadaa0856",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostImputationCollectionView,CostImputationEntityView>( params_MainConsult,this,Screen.CostImputationEntityView);
 

        }
        public IRPSButton<CostImputationCollectionView,CostImputationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostImputationCollectionView,CostImputationEntityView> MainConsult { get; set; } 
        public CostImputation Screen { get; set; }
        public CostImputationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostImputationEntityView : View
    {
        public CostImputationEntityView(CostImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostImputationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostImputationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostImputationEntityView,CostImputationCollectionView>( this,Screen.CostImputationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostImputationEntityView,CostImputationCollectionView>( this,Screen.CostImputationCollectionView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CostImputationEntityView>("84930e69-cec0-4220-9c84-55260b90fdad","","",false, this);
 
            IDInvoice = RPSControlFactory.CreateRPSComboBox<CostImputationEntityView>("b8cd3a30-b111-4586-aacf-39e6e59b68d6","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CostImputationEntityView>("805ec3af-2321-4613-9626-c295ae29af3a","","",true, this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<CostImputationEntityView>("60da3336-b748-4cf8-8b07-21a1bbe53fc3","","",true, this);
 
            SumAmount = RPSControlFactory.CreateRPSFormattedTextBox<CostImputationEntityView>("b344fd74-e24a-4aa8-b3b0-97a638774cac","","",false, this);
 
            Pending = RPSControlFactory.CreateRPSFormattedTextBox<CostImputationEntityView>("c9369592-9a90-4a77-b95f-e3845749f83a","","",false, this);
 
            AddDeliveryNotePurSLChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CostImputationEntityView,AddDeliveryNotePurSLChildDialogView>("11446e33-4979-44aa-a149-e6f906a9ba1c","","", this,Screen.AddDeliveryNotePurSLChildDialogView);
 
            RecalculatedChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CostImputationEntityView,RecalculatedChildDialogView>("fca0666e-e325-4582-a703-3a92ed18f5f5","","", this,Screen.RecalculatedChildDialogView);
 
            CollectionInit params_CostImputationDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="39d9433f-1e39-403b-ab1c-d82a166f7c9b",CSSSelectorGrid="",XPathGrid=""};
            CostImputationDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CostImputationDetailsCollectionEditor<CostImputationEntityView,RecalculatedChildDialogView>,CostImputationEntityView,RecalculatedChildDialogView>( params_CostImputationDetails,this,Screen.RecalculatedChildDialogView);
 

        }
        public IRPSSaveButton<CostImputationEntityView> SaveButton { get; set; } 
        public IRPSButton<CostImputationEntityView> DeleteButton { get; set; } 
        public IRPSButton<CostImputationEntityView,CostImputationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostImputationEntityView,CostImputationCollectionView> BackButton { get; set; } 
        public IRPSComboBox<CostImputationEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<CostImputationEntityView> IDInvoice { get; set; } 
        public IRPSComboBox<CostImputationEntityView> Type { get; set; } 
        public IRPSTextBox<CostImputationEntityView> Total { get; set; } 
        public IRPSTextBox<CostImputationEntityView> SumAmount { get; set; } 
        public IRPSTextBox<CostImputationEntityView> Pending { get; set; } 
        public IRPSButton<CostImputationEntityView,AddDeliveryNotePurSLChildDialogView> AddDeliveryNotePurSLChildNavigationCommandButton { get; set; } 
        public IRPSButton<CostImputationEntityView,RecalculatedChildDialogView> RecalculatedChildNavigationCommandButton { get; set; } 
        public CostImputationDetailsCollectionEditor<CostImputationEntityView,RecalculatedChildDialogView> CostImputationDetails { get; set; } 
        public CostImputation Screen { get; set; }
        public CostImputationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CostImputationDetailsCollectionEditor<CostImputationEntityView,RecalculatedChildDialogView>:RPSCollectionEditor<CostImputationEntityView,RecalculatedChildDialogView> where CostImputationEntityView : class, IView where RecalculatedChildDialogView : class, IView
    {
        public  CostImputationDetailsGridView<CostImputationEntityView,RecalculatedChildDialogView> GridView {get;set;}
    }
    public partial class CostImputationDetailsGridView <CostImputationEntityView,RecalculatedChildDialogView> :  RPSGridView<CostImputationEntityView,RecalculatedChildDialogView> where CostImputationEntityView : class, IView where RecalculatedChildDialogView : class, IView
    {
        public CostImputationDetailsGridView(CostImputationEntityView currentView,RecalculatedChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            AmountLine = RPSControlFactory.CreateRPSGridFormattedTextBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cAmountLine']","",false, this.CurrentView);
 
            CostLine = RPSControlFactory.CreateRPSGridFormattedTextBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cCostLine']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CostImputationEntityView>("","#39d9433f-1e39-403b-ab1c-d82a166f7c9b .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CostImputationEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<CostImputationEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<CostImputationEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<CostImputationEntityView> AmountLine { get; set; } 
        public IRPSGridTextBox<CostImputationEntityView> CostLine { get; set; } 
        public IRPSGridTextBox<CostImputationEntityView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculatedChildDialogView : View
    {
        public RecalculatedChildDialogView(CostImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AllLines = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "993b5e9b-a8e6-4711-ad71-b5de4f99c630","","",this);
 
            LineCost0 = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "68e872ba-d2a6-4aa7-b6f6-706dd5b57d8e","","",this);
 
            PositiveAmount = RPSControlFactory.CreateRPSCheckBox<RecalculatedChildDialogView>("240116e9-a0d8-419f-9aa2-90349cd703bc","","",false, this);
 
            OnlyArticles = RPSControlFactory.CreateRPSCheckBox<RecalculatedChildDialogView>("db7a33d8-3f5f-4993-a6b6-17ca5621178a","","",false, this);
 
            Equitably = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "08c54570-c0ec-467d-bdd7-536905dfc050","","",this);
 
            Proportional = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "46cc0f2e-0cd3-40f2-ae43-173a7c7af784","","",this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculatedChildDialogView>("30de48cc-04bc-4230-9aa1-d8bebaeae4ad","","",false, this);
 
            LineAmount = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "d3dde6ec-6333-4fe9-9a03-beba5dcc8e74","","",this);
 
            Quantity = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "0f4ab818-93a2-4460-8e33-ca5d576a467f","","",this);
 
            NetWeight = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "b9350676-82f7-4d9c-8a26-e660bfb895c2","","",this);
 
            GrossWeight = RPSControlFactory.CreateRPSOption<RecalculatedChildDialogView>( "d8ab3996-463c-4ded-9f5f-d4464c8c7761","","",this);
 

        }
        public IRPSOption<RecalculatedChildDialogView> AllLines { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> LineCost0 { get; set; } 
        public IRPSCheckbox<RecalculatedChildDialogView> PositiveAmount { get; set; } 
        public IRPSCheckbox<RecalculatedChildDialogView> OnlyArticles { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> Equitably { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> Proportional { get; set; } 
        public IRPSTextBox<RecalculatedChildDialogView> CostQuantity { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> LineAmount { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> Quantity { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> NetWeight { get; set; } 
        public IRPSOption<RecalculatedChildDialogView> GrossWeight { get; set; } 
        public CostImputation Screen { get; set; }
        public RecalculatedChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddDeliveryNotePurSLChildDialogView : View
    {
        public AddDeliveryNotePurSLChildDialogView(CostImputation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FromDateTime = RPSControlFactory.CreateRPSTextBox<AddDeliveryNotePurSLChildDialogView>("3ca0b123-4e0a-4c0f-8655-10bffcb6985e","","",false, this);
 
            PurIDShippingAgentSL = RPSControlFactory.CreateRPSComboBox<AddDeliveryNotePurSLChildDialogView>("18cec520-2418-4913-bd94-f013c59ce4ff","","",false, this);
 
            DeliveryNotePurOptionValue = RPSControlFactory.CreateRPSOption<AddDeliveryNotePurSLChildDialogView>( "1e801b3f-9d19-49e3-b93a-6e0cd5ee97b2","","",this);
 
            PurDeliveryNote = RPSControlFactory.CreateRPSCollectionComboBox<AddDeliveryNotePurSLChildDialogView>("2b2e1747-7e73-448b-8eb7-b804711ff991","","",false, this);
 
            DeliveryNoteSLOptionValue = RPSControlFactory.CreateRPSOption<AddDeliveryNotePurSLChildDialogView>( "ef5686ce-0300-44fc-aa18-eba14155cbe9","","",this);
 
            SalesDeliveryNoteSL = RPSControlFactory.CreateRPSCollectionComboBox<AddDeliveryNotePurSLChildDialogView>("31e79a34-98e0-4cd8-a7bd-4ab7bf38fccb","","",false, this);
 
            ExecutePurDeliveryNoteWithLineAmountPositivFiltered = RPSControlFactory.CreateRPSButton<AddDeliveryNotePurSLChildDialogView>( "80b29dcc-67d5-40a0-9fdc-5a38420ea3f6","","",this);
 
            ExecuteSalesDeliveryNoteWithLineAmountPositivFiltered = RPSControlFactory.CreateRPSButton<AddDeliveryNotePurSLChildDialogView>( "b4d8bd72-4961-44dd-a6a8-d8e2d5055b72","","",this);
 
            CollectionInit params_PurDeliveryNoteWithLineAmountPositivFiltered = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e10ef95e-7327-444c-b6f5-a956bde8440e",CSSSelectorGrid="",XPathGrid=""};
            PurDeliveryNoteWithLineAmountPositivFiltered = RPSControlFactory.RPSCreateCollectionWithGrid<PurDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView>,AddDeliveryNotePurSLChildDialogView>( params_PurDeliveryNoteWithLineAmountPositivFiltered,this);
 
            CollectionInit params_SalesDeliveryNoteWithLineAmountPositivFiltered = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fafc8018-d844-4637-b9e5-8fa7615600df",CSSSelectorGrid="",XPathGrid=""};
            SalesDeliveryNoteWithLineAmountPositivFiltered = RPSControlFactory.RPSCreateCollectionWithGrid<SalesDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView>,AddDeliveryNotePurSLChildDialogView>( params_SalesDeliveryNoteWithLineAmountPositivFiltered,this);
 

        }
        public IRPSTextBox<AddDeliveryNotePurSLChildDialogView> FromDateTime { get; set; } 
        public IRPSComboBox<AddDeliveryNotePurSLChildDialogView> PurIDShippingAgentSL { get; set; } 
        public IRPSOption<AddDeliveryNotePurSLChildDialogView> DeliveryNotePurOptionValue { get; set; } 
        public IRPSCollectionComboBox<AddDeliveryNotePurSLChildDialogView> PurDeliveryNote { get; set; } 
        public IRPSOption<AddDeliveryNotePurSLChildDialogView> DeliveryNoteSLOptionValue { get; set; } 
        public IRPSCollectionComboBox<AddDeliveryNotePurSLChildDialogView> SalesDeliveryNoteSL { get; set; } 
        public IRPSButton<AddDeliveryNotePurSLChildDialogView> ExecutePurDeliveryNoteWithLineAmountPositivFiltered { get; set; } 
        public IRPSButton<AddDeliveryNotePurSLChildDialogView> ExecuteSalesDeliveryNoteWithLineAmountPositivFiltered { get; set; } 
        public PurDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView> PurDeliveryNoteWithLineAmountPositivFiltered { get; set; } 
        public SalesDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView> SalesDeliveryNoteWithLineAmountPositivFiltered { get; set; } 
        public CostImputation Screen { get; set; }
        public AddDeliveryNotePurSLChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PurDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView>:RPSCollectionEditor<AddDeliveryNotePurSLChildDialogView> where AddDeliveryNotePurSLChildDialogView : class, IView
    {
        public  PurDeliveryNoteWithLineAmountPositivFilteredGridView<AddDeliveryNotePurSLChildDialogView> GridView {get;set;}
    }
    public partial class PurDeliveryNoteWithLineAmountPositivFilteredGridView <AddDeliveryNotePurSLChildDialogView> :  RPSGridView<AddDeliveryNotePurSLChildDialogView> where AddDeliveryNotePurSLChildDialogView : class, IView
    {
        public PurDeliveryNoteWithLineAmountPositivFilteredGridView(AddDeliveryNotePurSLChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNote_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<AddDeliveryNotePurSLChildDialogView>("","#e10ef95e-7327-444c-b6f5-a956bde8440e .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddDeliveryNotePurSLChildDialogView> DeliveryNote_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class SalesDeliveryNoteWithLineAmountPositivFilteredCollectionEditor<AddDeliveryNotePurSLChildDialogView>:RPSCollectionEditor<AddDeliveryNotePurSLChildDialogView> where AddDeliveryNotePurSLChildDialogView : class, IView
    {
        public  SalesDeliveryNoteWithLineAmountPositivFilteredGridView<AddDeliveryNotePurSLChildDialogView> GridView {get;set;}
    }
    public partial class SalesDeliveryNoteWithLineAmountPositivFilteredGridView <AddDeliveryNotePurSLChildDialogView> :  RPSGridView<AddDeliveryNotePurSLChildDialogView> where AddDeliveryNotePurSLChildDialogView : class, IView
    {
        public SalesDeliveryNoteWithLineAmountPositivFilteredGridView(AddDeliveryNotePurSLChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<AddDeliveryNotePurSLChildDialogView>("","#fafc8018-d844-4637-b9e5-8fa7615600df .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddDeliveryNotePurSLChildDialogView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
    }
  
    

}
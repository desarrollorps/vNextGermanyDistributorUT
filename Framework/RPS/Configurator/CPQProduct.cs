    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.CPQProduct
{
    //RPS VERSION 1.0.0.0
    public partial class CPQProduct:Screen
    {
        public CPQProduct():base()
        {
            this.URL = "configurator.cpqproduct";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CPQProductCollectionView  = new CPQProductCollectionView(this); 
            CPQProductEntityView  = new CPQProductEntityView(this); 
            CreateNewCPQProductDialogView  = new CreateNewCPQProductDialogView(this); 
            InformationExtendedDialogView  = new InformationExtendedDialogView(this); 
            CopyCPQProductDialogView  = new CopyCPQProductDialogView(this); 
            CPQProductCollectionView.InitializeControls(); 
            CPQProductEntityView.InitializeControls(); 
            CreateNewCPQProductDialogView.InitializeControls(); 
            InformationExtendedDialogView.InitializeControls(); 
            CopyCPQProductDialogView.InitializeControls(); 
           
        }
      
            public CPQProductCollectionView CPQProductCollectionView {get; set; } 
            public CPQProductEntityView CPQProductEntityView {get; set; } 
            public CreateNewCPQProductDialogView CreateNewCPQProductDialogView {get; set; } 
            public InformationExtendedDialogView InformationExtendedDialogView {get; set; } 
            public CopyCPQProductDialogView CopyCPQProductDialogView {get; set; } 
    }
            
    public partial class CPQProductCollectionView : View
    {
        public CPQProductCollectionView(CPQProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CPQProductCollectionView,CPQProductEntityView>( this,Screen.CPQProductEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "15fad757-a360-4bdf-9638-3f994b3e7136",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CPQProductCollectionView,CPQProductEntityView>( params_MainConsult,this,Screen.CPQProductEntityView);
 

        }
        public IRPSButton<CPQProductCollectionView,CPQProductEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CPQProductCollectionView,CPQProductEntityView> MainConsult { get; set; } 
        public CPQProduct Screen { get; set; }
        public CPQProductCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CPQProductEntityView : View
    {
        public CPQProductEntityView(CPQProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CPQProductEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CPQProductEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CPQProductEntityView,CPQProductCollectionView>( this,Screen.CPQProductCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CPQProductEntityView,CPQProductCollectionView>( this,Screen.CPQProductCollectionView);
 
            IDCPQModel = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("5f99c455-9b34-4e3d-ba6b-88b72a543c05","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CPQProductEntityView>("2654112b-5453-4fd6-bc1f-b0f3dc11c2e5","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<CPQProductEntityView>("728f7ebe-fa49-4d91-ba99-ac8e56904812","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("c03f646f-0b32-473c-8b59-5f53a51df66c","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("ff81468c-cbff-43f7-9a80-ad39478c6b26","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("306a4ff2-3faa-4381-a3ce-2808e1a69460","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("feafbb3a-84d3-4a24-9e6c-5fcd00891d8b","","",false, this);
 
            IDSalesQuote = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("fde7f741-05c9-408d-b73e-3e0e541aa7d7","","",false, this);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<CPQProductEntityView>("b0ea382a-393b-4678-a8e2-3611996d2acd","","",false, this);
 
            DescriptionExtended = RPSControlFactory.CreateRPSTextBox<CPQProductEntityView>("f6e79441-0471-4779-bb18-1a5eb2f65552","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<CPQProductEntityView>("73e6a5c3-2e27-4ecc-903f-8ef30f5e7c6e","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<CPQProductEntityView>("1f61c8b7-4281-4c1c-aced-3fb6845fd5e9","","",true, this);
 
            CopyCPQProductCommandButton = RPSControlFactory.CreateRPSButtonToView<CPQProductEntityView,CopyCPQProductDialogView>("40374919-460d-496a-bf2d-331d68b829b5","","", this,Screen.CopyCPQProductDialogView);
 
            ExecuteCPQEndProductButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "96cd32cf-72a6-4c3c-b582-19de50695224","","",this);
 
            ExecuteCPQApproveProductButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "d6c1da82-3b3a-43f2-8c4c-84ed5d607f7d","","",this);
 
            ExecuteCPQRetryButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "84af03e8-8bda-49aa-9082-f292c92426ff","","",this);
 
            ReevaluateFormulasButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "55e80d4d-f9e5-41ae-a4f0-dab0a165d927","","",this);
 
            ShowActionsStackCommandButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "c81b233f-3d45-4d02-99dd-307b8d273f3a","","",this);
 
            HideActionsStackCommandButton = RPSControlFactory.CreateRPSButton<CPQProductEntityView>( "dd486de1-48ba-4d05-b6a2-2a6c23375251","","",this);
 
            CollectionInit params_ArticleListCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5bc0c1e4-4a86-4f57-9109-29bcc7587710",CSSSelectorGrid="",XPathGrid=""};
            ArticleListCollection = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleListCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>,CPQProductEntityView,InformationExtendedDialogView>( params_ArticleListCollection,this,Screen.InformationExtendedDialogView);
 
            CollectionInit params_GetActionsStack = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b5d53f93-908d-4c05-becf-934710982489",CSSSelectorGrid="",XPathGrid=""};
            GetActionsStack = RPSControlFactory.RPSCreateCollectionWithGrid<GetActionsStackCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>,CPQProductEntityView,InformationExtendedDialogView>( params_GetActionsStack,this,Screen.InformationExtendedDialogView);
 
            CollectionInit params_VariableDataCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b9ea8b1b-2706-4b49-9813-9e5174eefaea",CSSSelectorGrid="",XPathGrid=""};
            VariableDataCollection = RPSControlFactory.RPSCreateCollectionWithGrid<VariableDataCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>,CPQProductEntityView,InformationExtendedDialogView>( params_VariableDataCollection,this,Screen.InformationExtendedDialogView);
 

        }
        public IRPSSaveButton<CPQProductEntityView> SaveButton { get; set; } 
        public IRPSButton<CPQProductEntityView> DeleteButton { get; set; } 
        public IRPSButton<CPQProductEntityView,CPQProductCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CPQProductEntityView,CPQProductCollectionView> BackButton { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDCPQModel { get; set; } 
        public IRPSTextBox<CPQProductEntityView> Description { get; set; } 
        public IRPSComboBox<CPQProductEntityView> Status { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDOportunity { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDSalesQuote { get; set; } 
        public IRPSComboBox<CPQProductEntityView> IDOrder { get; set; } 
        public IRPSTextBox<CPQProductEntityView> DescriptionExtended { get; set; } 
        public IRPSTextBox<CPQProductEntityView> Price { get; set; } 
        public IRPSTextBox<CPQProductEntityView> Cost { get; set; } 
        public IRPSButton<CPQProductEntityView,CopyCPQProductDialogView> CopyCPQProductCommandButton { get; set; } 
        public IRPSButton<CPQProductEntityView> ExecuteCPQEndProductButton { get; set; } 
        public IRPSButton<CPQProductEntityView> ExecuteCPQApproveProductButton { get; set; } 
        public IRPSButton<CPQProductEntityView> ExecuteCPQRetryButton { get; set; } 
        public IRPSButton<CPQProductEntityView> ReevaluateFormulasButton { get; set; } 
        public IRPSButton<CPQProductEntityView> ShowActionsStackCommandButton { get; set; } 
        public IRPSButton<CPQProductEntityView> HideActionsStackCommandButton { get; set; } 
        public ArticleListCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> ArticleListCollection { get; set; } 
        public GetActionsStackCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> GetActionsStack { get; set; } 
        public VariableDataCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> VariableDataCollection { get; set; } 
        public CPQProduct Screen { get; set; }
        public CPQProductEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleListCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>:RPSCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public  ArticleListCollectionGridView<CPQProductEntityView,InformationExtendedDialogView> GridView {get;set;}
    }
    public partial class ArticleListCollectionGridView <CPQProductEntityView,InformationExtendedDialogView> :  RPSGridView<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public ArticleListCollectionGridView(CPQProductEntityView currentView,InformationExtendedDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCPQOptionGroup = RPSControlFactory.CreateRPSGridComboBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cIDCPQOptionGroup']","",false, this.CurrentView);
 
            IDCPQOption = RPSControlFactory.CreateRPSGridComboBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cIDCPQOption']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQProductEntityView>("","#5bc0c1e4-4a86-4f57-9109-29bcc7587710 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQProductEntityView> IDCPQOptionGroup { get; set; } 
        public IRPSGridComboBox<CPQProductEntityView> IDCPQOption { get; set; } 
        public IRPSGridComboBox<CPQProductEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> Price { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> Amount { get; set; } 
                     
    }
 
        public partial class GetActionsStackCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>:RPSCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public  GetActionsStackGridView<CPQProductEntityView,InformationExtendedDialogView> GridView {get;set;}
    }
    public partial class GetActionsStackGridView <CPQProductEntityView,InformationExtendedDialogView> :  RPSGridView<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public GetActionsStackGridView(CPQProductEntityView currentView,InformationExtendedDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecutionOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cExecutionOrder']","",false, this.CurrentView);
 
            Deactivate = RPSControlFactory.CreateRPSGridCheckBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cDeactivate']","",false, this.CurrentView);
 
            Event = RPSControlFactory.CreateRPSGridTextBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cEvent']","",false, this.CurrentView);
 
            Action = RPSControlFactory.CreateRPSGridTextBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cAction']","",false, this.CurrentView);
 
            ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cExecutionDate']","",false, this.CurrentView);
 
            ErrorDetails = RPSControlFactory.CreateRPSGridMemoTextBox<CPQProductEntityView>("","#b5d53f93-908d-4c05-becf-934710982489 .ag-row[role='row']@ROWINDEX [col-id='cErrorDetails']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CPQProductEntityView> ExecutionOrder { get; set; } 
        public IRPSGridCheckbox<CPQProductEntityView> Deactivate { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> Event { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> Action { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> ExecutionDate { get; set; } 
        public IRPSGridTextBox<CPQProductEntityView> ErrorDetails { get; set; } 
                     
    }
 
        public partial class VariableDataCollectionCollectionEditor<CPQProductEntityView,InformationExtendedDialogView>:RPSCollectionEditor<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public  VariableDataCollectionGridView<CPQProductEntityView,InformationExtendedDialogView> GridView {get;set;}
    }
    public partial class VariableDataCollectionGridView <CPQProductEntityView,InformationExtendedDialogView> :  RPSGridView<CPQProductEntityView,InformationExtendedDialogView> where CPQProductEntityView : class, IView where InformationExtendedDialogView : class, IView
    {
        public VariableDataCollectionGridView(CPQProductEntityView currentView,InformationExtendedDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCPQVariableDataLabel = RPSControlFactory.CreateRPSGridComboBox<CPQProductEntityView>("","#b9ea8b1b-2706-4b49-9813-9e5174eefaea .ag-row[role='row']@ROWINDEX [col-id='cIDCPQVariableDataLabel']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CPQProductEntityView> IDCPQVariableDataLabel { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreateNewCPQProductDialogView : View
    {
        public CreateNewCPQProductDialogView(CPQProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCPQModel = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("1cdc853d-8026-4b1a-a030-7b2ffc29be80","","",true, this);
 
            NewProductDescription = RPSControlFactory.CreateRPSTextBox<CreateNewCPQProductDialogView>("93dcafa9-57e7-430f-8cbf-da572ba1a666","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("f1dfd62b-d1ba-42f1-8b9d-0f2f799ffd34","","",false, this);
 
            IDPotentialCustomerSL = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("76c5918c-a537-4071-b419-f0735524f4b2","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("3973a370-b98b-467a-9b33-b2ee460d891d","","",true, this);
 
            IDOportunitySL = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("c72f1391-944d-4339-ac1b-fd1ade8eafc3","","",false, this);
 
            IDSalesQuoteSL = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("553409c7-13b6-4f0d-a8da-abc40dce861f","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<CreateNewCPQProductDialogView>("9b164fd2-094a-42a9-977d-da43aaf15b11","","",false, this);
 

        }
        public IRPSComboBox<CreateNewCPQProductDialogView> IDCPQModel { get; set; } 
        public IRPSTextBox<CreateNewCPQProductDialogView> NewProductDescription { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDPotentialCustomerSL { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDCurrency { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDOportunitySL { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDSalesQuoteSL { get; set; } 
        public IRPSComboBox<CreateNewCPQProductDialogView> IDOrderSL { get; set; } 
        public CPQProduct Screen { get; set; }
        public CreateNewCPQProductDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InformationExtendedDialogView : View
    {
        public InformationExtendedDialogView(CPQProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public CPQProduct Screen { get; set; }
        public InformationExtendedDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyCPQProductDialogView : View
    {
        public CopyCPQProductDialogView(CPQProduct screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewProductDescription = RPSControlFactory.CreateRPSTextBox<CopyCPQProductDialogView>("050f705d-69d7-4505-bc78-de803d13df6c","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("7da43345-696b-46bb-a38f-ecf42a1c1e10","","",false, this);
 
            IDPotentialCustomerSL = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("1800ffd1-82ea-49f1-b2ed-f917153acb6a","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("f7d2ab06-a08c-49ed-95c3-81623911e952","","",true, this);
 
            IDOportunitySL = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("4b4fddf6-7ace-4d56-9cd6-57f5c972105a","","",false, this);
 
            IDSalesQuoteSL = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("0ec49598-c659-4db6-8ad2-0c4a82486aff","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<CopyCPQProductDialogView>("f70ad3ee-3fb2-49b2-9f62-d0724679bc08","","",false, this);
 

        }
        public IRPSTextBox<CopyCPQProductDialogView> NewProductDescription { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDPotentialCustomerSL { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDCurrency { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDOportunitySL { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDSalesQuoteSL { get; set; } 
        public IRPSComboBox<CopyCPQProductDialogView> IDOrderSL { get; set; } 
        public CPQProduct Screen { get; set; }
        public CopyCPQProductDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
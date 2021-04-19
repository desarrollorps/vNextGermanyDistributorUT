    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXLoan
{
    //RPS VERSION 1.0.0.0
    public partial class FXLoan:Screen
    {
        public FXLoan():base()
        {
            this.URL = "cashflowforecast.fxloan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXLoanCollectionView  = new FXLoanCollectionView(this); 
            FXLoanEntityView  = new FXLoanEntityView(this); 
            FXLoanDetailView  = new FXLoanDetailView(this); 
            NewLoanChildDialogView  = new NewLoanChildDialogView(this); 
            GenerateManualDataChildDialogView  = new GenerateManualDataChildDialogView(this); 
            GenerateAgainManualDataChildDialogView  = new GenerateAgainManualDataChildDialogView(this); 
            DeleteManualDataChildDialogView  = new DeleteManualDataChildDialogView(this); 
            FXLoanCollectionView.InitializeControls(); 
            FXLoanEntityView.InitializeControls(); 
            FXLoanDetailView.InitializeControls(); 
            NewLoanChildDialogView.InitializeControls(); 
            GenerateManualDataChildDialogView.InitializeControls(); 
            GenerateAgainManualDataChildDialogView.InitializeControls(); 
            DeleteManualDataChildDialogView.InitializeControls(); 
           
        }
      
            public FXLoanCollectionView FXLoanCollectionView {get; set; } 
            public FXLoanEntityView FXLoanEntityView {get; set; } 
            public FXLoanDetailView FXLoanDetailView {get; set; } 
            public NewLoanChildDialogView NewLoanChildDialogView {get; set; } 
            public GenerateManualDataChildDialogView GenerateManualDataChildDialogView {get; set; } 
            public GenerateAgainManualDataChildDialogView GenerateAgainManualDataChildDialogView {get; set; } 
            public DeleteManualDataChildDialogView DeleteManualDataChildDialogView {get; set; } 
    }
            
    public partial class FXLoanCollectionView : View
    {
        public FXLoanCollectionView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FXLoanCollectionView,FXLoanEntityView>( this,Screen.FXLoanEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "31994256-4836-4cd6-8556-8361cb5629f6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FXLoanCollectionView,FXLoanEntityView>( params_MainConsult,this,Screen.FXLoanEntityView);
 

        }
        public IRPSButton<FXLoanCollectionView,FXLoanEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FXLoanCollectionView,FXLoanEntityView> MainConsult { get; set; } 
        public FXLoan Screen { get; set; }
        public FXLoanCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FXLoanEntityView : View
    {
        public FXLoanEntityView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FXLoanEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXLoanEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXLoanEntityView,FXLoanCollectionView>( this,Screen.FXLoanCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXLoanEntityView,FXLoanCollectionView>( this,Screen.FXLoanCollectionView);
 
            CodFXLoan = RPSControlFactory.CreateRPSTextBox<FXLoanEntityView>("c4747809-0c03-44dc-85e0-7b1aca80d15c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FXLoanEntityView>("8643bb43-7008-47bc-af64-a5b71b669a21","","",false, this);
 
            IDFXIEManualIncome = RPSControlFactory.CreateRPSComboBox<FXLoanEntityView>("7c3f6e2a-c2e7-4c43-b259-4b44058ef3b3","","",false, this);
 
            IDFXIEManualExpenses = RPSControlFactory.CreateRPSComboBox<FXLoanEntityView>("5bb3769f-c152-428e-86e4-6ee6070ae0fa","","",false, this);
 
            IncomeDate = RPSControlFactory.CreateRPSTextBox<FXLoanEntityView>("03ac8962-fb68-40d2-9bdb-25e2ef1763c7","","",true, this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<FXLoanEntityView>("d7435f89-9b0b-43d1-b484-7906c9e4a327","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<FXLoanEntityView>("bce57f2a-af7e-41e8-9c49-baadcf8d81e2","","",false, this);
 
            LoanAmount = RPSControlFactory.CreateRPSFormattedTextBox<FXLoanEntityView>("7b19ba3f-06bb-45fe-ab15-5aed2be1b2a5","","",true, this);
 
            InterestPercentage = RPSControlFactory.CreateRPSFormattedTextBox<FXLoanEntityView>("30c09c35-bbde-43f7-b315-c6e6ed0832db","","",true, this);
 
            Years = RPSControlFactory.CreateRPSFormattedTextBox<FXLoanEntityView>("3a17f861-2471-40df-a52c-9f39f7851d55","","",true, this);
 
            PeriodType = RPSControlFactory.CreateRPSEnumComboBox<FXLoanEntityView>("d1acd918-27e2-4b9f-9d07-fe885f92247d","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FXLoanEntityView>("730f20cb-5f43-40cd-bad9-f25719af7e96","","",false, this);
 
            NewLoanChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXLoanEntityView,NewLoanChildDialogView>("9f8b8225-b82b-4127-99c3-14a705729600","","", this,Screen.NewLoanChildDialogView);
 
            GenerateInstallmentsCommandButton = RPSControlFactory.CreateRPSButton<FXLoanEntityView>( "906113b2-ab9b-42ac-85f4-eb82de73694d","","",this);
 
            GenerateManualDataCommandButton = RPSControlFactory.CreateRPSButton<FXLoanEntityView>( "8498f179-e473-43a7-88b4-202b15b41410","","",this);
 
            DeleteManualDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXLoanEntityView,DeleteManualDataChildDialogView>("d2d06e77-7ba6-489f-aa5a-dd34abee0ab1","","", this,Screen.DeleteManualDataChildDialogView);
 
            CollectionInit params_FXLoanDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ba1d45ff-717e-4055-ae86-823668bd91e8",CSSSelectorGrid="",XPathGrid=""};
            FXLoanDetails = RPSControlFactory.RPSCreateCollectionWithGrid<FXLoanDetailsCollectionEditor<FXLoanEntityView,FXLoanDetailView>,FXLoanEntityView,FXLoanDetailView>( params_FXLoanDetails,this,Screen.FXLoanDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FXLoanEntityView>( "","ul li[rpsid='2f5fbdaf-62fe-4ff7-ad94-d232cadb7038']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<FXLoanEntityView>( "","ul li[rpsid='30a3b8c5-7d08-4347-88b1-40b38332dfa0']","",this);
 

        }
        public IRPSSaveButton<FXLoanEntityView> SaveButton { get; set; } 
        public IRPSButton<FXLoanEntityView> DeleteButton { get; set; } 
        public IRPSButton<FXLoanEntityView,FXLoanCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXLoanEntityView,FXLoanCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FXLoanEntityView> CodFXLoan { get; set; } 
        public IRPSTextBox<FXLoanEntityView> Description { get; set; } 
        public IRPSComboBox<FXLoanEntityView> IDFXIEManualIncome { get; set; } 
        public IRPSComboBox<FXLoanEntityView> IDFXIEManualExpenses { get; set; } 
        public IRPSTextBox<FXLoanEntityView> IncomeDate { get; set; } 
        public IRPSTextBox<FXLoanEntityView> InitialDate { get; set; } 
        public IRPSComboBox<FXLoanEntityView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<FXLoanEntityView> LoanAmount { get; set; } 
        public IRPSTextBox<FXLoanEntityView> InterestPercentage { get; set; } 
        public IRPSTextBox<FXLoanEntityView> Years { get; set; } 
        public IRPSComboBox<FXLoanEntityView> PeriodType { get; set; } 
        public IRPSTextBox<FXLoanEntityView> Comment { get; set; } 
        public IRPSButton<FXLoanEntityView,NewLoanChildDialogView> NewLoanChildNavigationCommandButton { get; set; } 
        public IRPSButton<FXLoanEntityView> GenerateInstallmentsCommandButton { get; set; } 
        public IRPSButton<FXLoanEntityView> GenerateManualDataCommandButton { get; set; } 
        public IRPSButton<FXLoanEntityView,DeleteManualDataChildDialogView> DeleteManualDataChildNavigationCommandButton { get; set; } 
        public FXLoanDetailsCollectionEditor<FXLoanEntityView,FXLoanDetailView> FXLoanDetails { get; set; } 
        public IRPSSection<FXLoanEntityView> GeneralData { get; set; } 
        public IRPSSection<FXLoanEntityView> Comments { get; set; } 
        public FXLoan Screen { get; set; }
        public FXLoanEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXLoanDetailsCollectionEditor<FXLoanEntityView,FXLoanDetailView>:RPSCollectionEditor<FXLoanEntityView,FXLoanDetailView> where FXLoanEntityView : class, IView where FXLoanDetailView : class, IView
    {
        public  FXLoanDetailsGridView<FXLoanEntityView,FXLoanDetailView> GridView {get;set;}
    }
    public partial class FXLoanDetailsGridView <FXLoanEntityView,FXLoanDetailView> :  RPSGridView<FXLoanEntityView,FXLoanDetailView> where FXLoanEntityView : class, IView where FXLoanDetailView : class, IView
    {
        public FXLoanDetailsGridView(FXLoanEntityView currentView,FXLoanDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ValueDate = RPSControlFactory.CreateRPSGridTextBox<FXLoanEntityView>("","#ba1d45ff-717e-4055-ae86-823668bd91e8 .ag-row[role='row']@ROWINDEX [col-id='cValueDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FXLoanEntityView>("","#ba1d45ff-717e-4055-ae86-823668bd91e8 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FXLoanEntityView> ValueDate { get; set; } 
        public IRPSGridTextBox<FXLoanEntityView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class FXLoanDetailView : View
    {
        public FXLoanDetailView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXLoanDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXLoanDetailView,FXLoanEntityView>( this,Screen.FXLoanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXLoanDetailView,FXLoanEntityView>( this,Screen.FXLoanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FXLoanDetailView,FXLoanEntityView>( this,Screen.FXLoanEntityView);
 
            ValueDate = RPSControlFactory.CreateRPSTextBox<FXLoanDetailView>("9298c8ed-3327-437c-9732-fd0486c47030","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<FXLoanDetailView>("91e842f1-1a2c-4e70-8414-832e46501c51","","",true, this);
 

        }
        public IRPSButton<FXLoanDetailView> DeleteButton { get; set; } 
        public IRPSButton<FXLoanDetailView,FXLoanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXLoanDetailView,FXLoanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FXLoanDetailView,FXLoanEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FXLoanDetailView> ValueDate { get; set; } 
        public IRPSTextBox<FXLoanDetailView> Amount { get; set; } 
        public FXLoan Screen { get; set; }
        public FXLoanDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewLoanChildDialogView : View
    {
        public NewLoanChildDialogView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodFXLoan = RPSControlFactory.CreateRPSTextBox<NewLoanChildDialogView>("fa1b2be6-d451-4340-bfb5-d17bfb8d3202","","",false, this);
 
            NewDescription = RPSControlFactory.CreateRPSTextBox<NewLoanChildDialogView>("c2593078-4db7-4d37-95f4-f0638e502868","","",false, this);
 

        }
        public IRPSTextBox<NewLoanChildDialogView> NewCodFXLoan { get; set; } 
        public IRPSTextBox<NewLoanChildDialogView> NewDescription { get; set; } 
        public FXLoan Screen { get; set; }
        public NewLoanChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateManualDataChildDialogView : View
    {
        public GenerateManualDataChildDialogView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            BankAccountCompany = RPSControlFactory.CreateRPSComboBox<GenerateManualDataChildDialogView>("a5733581-9d2e-4624-8700-a0b6d32b18ae","","",false, this);
 
            FXIncomeConcept = RPSControlFactory.CreateRPSComboBox<GenerateManualDataChildDialogView>("ea55bfa7-6ee2-4235-b6d1-fb2b8602378f","","",true, this);
 
            CodIncomeManualData = RPSControlFactory.CreateRPSTextBox<GenerateManualDataChildDialogView>("f9a81bd7-f933-40ad-a43c-35086970ff2d","","",true, this);
 
            IncomeDescription = RPSControlFactory.CreateRPSTextBox<GenerateManualDataChildDialogView>("c6d5141f-cf0c-450a-9068-b963235aa18d","","",true, this);
 
            FXExpenseConcept = RPSControlFactory.CreateRPSComboBox<GenerateManualDataChildDialogView>("2729bf20-8997-4ae2-aa45-06db62607fea","","",true, this);
 
            CodExpenseManualData = RPSControlFactory.CreateRPSTextBox<GenerateManualDataChildDialogView>("ea912c80-b3e4-4a9d-a19c-5aa65f0bea9b","","",true, this);
 
            ExpenseDescription = RPSControlFactory.CreateRPSTextBox<GenerateManualDataChildDialogView>("5dce64af-7c0a-416a-9bb6-7e464f69ffe8","","",true, this);
 

        }
        public IRPSComboBox<GenerateManualDataChildDialogView> BankAccountCompany { get; set; } 
        public IRPSComboBox<GenerateManualDataChildDialogView> FXIncomeConcept { get; set; } 
        public IRPSTextBox<GenerateManualDataChildDialogView> CodIncomeManualData { get; set; } 
        public IRPSTextBox<GenerateManualDataChildDialogView> IncomeDescription { get; set; } 
        public IRPSComboBox<GenerateManualDataChildDialogView> FXExpenseConcept { get; set; } 
        public IRPSTextBox<GenerateManualDataChildDialogView> CodExpenseManualData { get; set; } 
        public IRPSTextBox<GenerateManualDataChildDialogView> ExpenseDescription { get; set; } 
        public FXLoan Screen { get; set; }
        public GenerateManualDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateAgainManualDataChildDialogView : View
    {
        public GenerateAgainManualDataChildDialogView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDFXIEManualIncome = RPSControlFactory.CreateRPSComboBox<GenerateAgainManualDataChildDialogView>("a9fe6111-d12a-46d9-84d6-5ce156d3bec4","","",false, this);
 
            IncomeStatusDescription = RPSControlFactory.CreateRPSTextBox<GenerateAgainManualDataChildDialogView>("c79165b4-3265-4901-a48f-aa07fd1f198b","","",false, this);
 
            IncomeManualValueFiles = RPSControlFactory.CreateRPSFormattedTextBox<GenerateAgainManualDataChildDialogView>("6e983d41-e97f-4e6a-ad0c-525b6e43a609","","",false, this);
 
            IncomeManualValuePendingFiles = RPSControlFactory.CreateRPSFormattedTextBox<GenerateAgainManualDataChildDialogView>("36a9d8b5-bd81-42af-9af4-06f684d3c145","","",false, this);
 
            IDFXIEManualExpenses = RPSControlFactory.CreateRPSComboBox<GenerateAgainManualDataChildDialogView>("9523fa3d-b2f7-4484-9d17-0bce5c2756d6","","",false, this);
 
            ExpenseStatusDescription = RPSControlFactory.CreateRPSTextBox<GenerateAgainManualDataChildDialogView>("7fe8a487-996f-4d2f-9ae0-d6aa6f215fb7","","",false, this);
 
            ExpenseManualValueFiles = RPSControlFactory.CreateRPSFormattedTextBox<GenerateAgainManualDataChildDialogView>("0335103a-e540-4e68-92fa-5375b876d7e2","","",false, this);
 
            ExpenseManualValuePendingFiles = RPSControlFactory.CreateRPSFormattedTextBox<GenerateAgainManualDataChildDialogView>("eea070b5-6f1a-46e8-bbc0-3a988ecd1293","","",false, this);
 

        }
        public IRPSComboBox<GenerateAgainManualDataChildDialogView> IDFXIEManualIncome { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> IncomeStatusDescription { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> IncomeManualValueFiles { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> IncomeManualValuePendingFiles { get; set; } 
        public IRPSComboBox<GenerateAgainManualDataChildDialogView> IDFXIEManualExpenses { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> ExpenseStatusDescription { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> ExpenseManualValueFiles { get; set; } 
        public IRPSTextBox<GenerateAgainManualDataChildDialogView> ExpenseManualValuePendingFiles { get; set; } 
        public FXLoan Screen { get; set; }
        public GenerateAgainManualDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeleteManualDataChildDialogView : View
    {
        public DeleteManualDataChildDialogView(FXLoan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDFXIEManualIncome = RPSControlFactory.CreateRPSComboBox<DeleteManualDataChildDialogView>("d1cdb340-5020-4639-9491-e3c958a6862e","","",false, this);
 
            IncomeStatusDescription = RPSControlFactory.CreateRPSTextBox<DeleteManualDataChildDialogView>("d4ed1068-daff-45d4-b684-c8424e7fda7e","","",false, this);
 
            IncomeManualValueFiles = RPSControlFactory.CreateRPSFormattedTextBox<DeleteManualDataChildDialogView>("0c29752e-958b-4cce-b253-2e7d619c9227","","",false, this);
 
            IncomeManualValuePendingFiles = RPSControlFactory.CreateRPSFormattedTextBox<DeleteManualDataChildDialogView>("0a84a909-9f00-42ba-af91-879a0c36aba1","","",false, this);
 
            IDFXIEManualExpenses = RPSControlFactory.CreateRPSComboBox<DeleteManualDataChildDialogView>("15e9a490-dfa0-42a4-bda0-bd93dc72773f","","",false, this);
 
            ExpenseStatusDescription = RPSControlFactory.CreateRPSTextBox<DeleteManualDataChildDialogView>("bfc2f229-1bfe-4951-b2de-05083bd336cc","","",false, this);
 
            ExpenseManualValueFiles = RPSControlFactory.CreateRPSFormattedTextBox<DeleteManualDataChildDialogView>("d0b9936f-e192-4eb5-ba93-9d1a8a8fc701","","",false, this);
 
            ExpenseManualValuePendingFiles = RPSControlFactory.CreateRPSFormattedTextBox<DeleteManualDataChildDialogView>("56cba721-5efa-430e-aecd-8e20ee7d32fc","","",false, this);
 

        }
        public IRPSComboBox<DeleteManualDataChildDialogView> IDFXIEManualIncome { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> IncomeStatusDescription { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> IncomeManualValueFiles { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> IncomeManualValuePendingFiles { get; set; } 
        public IRPSComboBox<DeleteManualDataChildDialogView> IDFXIEManualExpenses { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> ExpenseStatusDescription { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> ExpenseManualValueFiles { get; set; } 
        public IRPSTextBox<DeleteManualDataChildDialogView> ExpenseManualValuePendingFiles { get; set; } 
        public FXLoan Screen { get; set; }
        public DeleteManualDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.CashMovements
{
    //RPS VERSION 1.0.0.0
    public partial class CashMovements:Screen
    {
        public CashMovements():base()
        {
            this.URL = "taxmodel.cashmovements";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashMovementVMQueryView  = new CashMovementVMQueryView(this); 
            CashMovementVMEntityView  = new CashMovementVMEntityView(this); 
            CashMovementVMQueryView.InitializeControls(); 
            CashMovementVMEntityView.InitializeControls(); 
           
        }
      
            public CashMovementVMQueryView CashMovementVMQueryView {get; set; } 
            public CashMovementVMEntityView CashMovementVMEntityView {get; set; } 
    }
            
    public partial class CashMovementVMQueryView : View
    {
        public CashMovementVMQueryView(CashMovements screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CashMovementVMQueryView,CashMovementVMEntityView>( this,Screen.CashMovementVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CashMovementVMQueryView>( this);
 
            UIYear = RPSControlFactory.CreateRPSFormattedTextBox<CashMovementVMQueryView>("4ee87437-97cb-4413-85a7-84c099f7e835","","",false, this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<CashMovementVMQueryView>( "1c1e5573-a312-436b-839d-5bab71ce9d9f","","",this);
 
            LoadDataCommandButton = RPSControlFactory.CreateRPSButton<CashMovementVMQueryView>( "c3344099-1bc9-434b-9609-96fdfa2934df","","",this);
 
            SendCashMovementsButton = RPSControlFactory.CreateRPSButton<CashMovementVMQueryView>( "870edaf8-edc7-4a4c-8902-422d48a6db77","","",this);
 
            CollectionInit params_GetCashMovements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d1a5202-5f93-4b91-b17d-3c5b40fce9d8",CSSSelectorGrid="",XPathGrid=""};
            GetCashMovements = RPSControlFactory.RPSCreateCollectionWithGrid<GetCashMovementsCollectionEditor<CashMovementVMQueryView,CashMovementVMEntityView>,CashMovementVMQueryView,CashMovementVMEntityView>( params_GetCashMovements,this,Screen.CashMovementVMEntityView);
 

        }
        public IRPSButton<CashMovementVMQueryView,CashMovementVMEntityView> NewButton { get; set; } 
        public IRPSButton<CashMovementVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<CashMovementVMQueryView> UIYear { get; set; } 
        public IRPSButton<CashMovementVMQueryView> SaveCommandButton { get; set; } 
        public IRPSButton<CashMovementVMQueryView> LoadDataCommandButton { get; set; } 
        public IRPSButton<CashMovementVMQueryView> SendCashMovementsButton { get; set; } 
        public GetCashMovementsCollectionEditor<CashMovementVMQueryView,CashMovementVMEntityView> GetCashMovements { get; set; } 
        public CashMovements Screen { get; set; }
        public CashMovementVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetCashMovementsCollectionEditor<CashMovementVMQueryView,CashMovementVMEntityView>:RPSCollectionEditor<CashMovementVMQueryView,CashMovementVMEntityView> where CashMovementVMQueryView : class, IView where CashMovementVMEntityView : class, IView
    {
        public  GetCashMovementsGridView<CashMovementVMQueryView,CashMovementVMEntityView> GridView {get;set;}
    }
    public partial class GetCashMovementsGridView <CashMovementVMQueryView,CashMovementVMEntityView> :  RPSGridView<CashMovementVMQueryView,CashMovementVMEntityView> where CashMovementVMQueryView : class, IView where CashMovementVMEntityView : class, IView
    {
        public GetCashMovementsGridView(CashMovementVMQueryView currentView,CashMovementVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CashMovement_CustomerVATNumber = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_CustomerVATNumber']","",false, this.CurrentView);
 
            CashMovement_CustomerCountry = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_CustomerCountry']","",false, this.CurrentView);
 
            CashMovement_CodCustomer = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_CodCustomer']","",false, this.CurrentView);
 
            CashMovement_IsMiscellaneous = RPSControlFactory.CreateRPSGridCheckBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_IsMiscellaneous']","",false, this.CurrentView);
 
            CashMovement_CustomerName = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_CustomerName']","",false, this.CurrentView);
 
            CashMovement_Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_Amount']","",false, this.CurrentView);
 
            CashMovement_CreatedStatus = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_CreatedStatus']","",false, this.CurrentView);
 
            CashMovement_SentTime = RPSControlFactory.CreateRPSGridTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_SentTime']","",false, this.CurrentView);
 
            CashMovement_ErrorInfo = RPSControlFactory.CreateRPSGridMemoTextBox<CashMovementVMQueryView>("","#7d1a5202-5f93-4b91-b17d-3c5b40fce9d8 .ag-row[role='row']@ROWINDEX [col-id='cCashMovement_ErrorInfo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_CustomerVATNumber { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_CustomerCountry { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_CodCustomer { get; set; } 
        public IRPSGridCheckbox<CashMovementVMQueryView> CashMovement_IsMiscellaneous { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_CustomerName { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_Amount { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_CreatedStatus { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_SentTime { get; set; } 
        public IRPSGridTextBox<CashMovementVMQueryView> CashMovement_ErrorInfo { get; set; } 
                     
    }
 
    }
  
            
    public partial class CashMovementVMEntityView : View
    {
        public CashMovementVMEntityView(CashMovements screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CashMovementVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashMovementVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashMovementVMEntityView,CashMovementVMQueryView>( this,Screen.CashMovementVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashMovementVMEntityView,CashMovementVMQueryView>( this,Screen.CashMovementVMQueryView);
 
            CustomerVATNumber = RPSControlFactory.CreateRPSTextBox<CashMovementVMEntityView>("ac498bf4-1157-479f-b8a1-b5d1d9edb8c6","","",true, this);
 
            CustomerCountry = RPSControlFactory.CreateRPSTextBox<CashMovementVMEntityView>("17c3cbaa-c53c-43ab-9a45-b27a432092ae","","",false, this);
 
            IsMiscellaneous = RPSControlFactory.CreateRPSCheckBox<CashMovementVMEntityView>("98591609-293a-4556-8df1-38dc3c233647","","",true, this);
 
            CustomerName = RPSControlFactory.CreateRPSTextBox<CashMovementVMEntityView>("9e858a5e-00f0-46dd-bc7d-b5f3eb4c6b40","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<CashMovementVMEntityView>("6736d068-4f84-43ac-9e12-5137f8ad2f9c","","",true, this);
 
            CreatedStatus = RPSControlFactory.CreateRPSEnumComboBox<CashMovementVMEntityView>("456a3cdb-179f-434d-81c4-60d3bedd6225","","",true, this);
 
            SentTime = RPSControlFactory.CreateRPSTextBox<CashMovementVMEntityView>("f4386d85-707f-4e15-9181-4b8ea79aa4b2","","",false, this);
 
            ErrorInfo = RPSControlFactory.CreateRPSTextBox<CashMovementVMEntityView>("36b39b1c-58a6-4312-b48b-72b85d3e64f9","","",false, this);
 

        }
        public IRPSSaveButton<CashMovementVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CashMovementVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashMovementVMEntityView,CashMovementVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashMovementVMEntityView,CashMovementVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> CustomerVATNumber { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> CustomerCountry { get; set; } 
        public IRPSCheckbox<CashMovementVMEntityView> IsMiscellaneous { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> CustomerName { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> Amount { get; set; } 
        public IRPSComboBox<CashMovementVMEntityView> CreatedStatus { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> SentTime { get; set; } 
        public IRPSTextBox<CashMovementVMEntityView> ErrorInfo { get; set; } 
        public CashMovements Screen { get; set; }
        public CashMovementVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
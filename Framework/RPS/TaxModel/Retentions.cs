    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Retentions
{
    //RPS VERSION 1.0.0.0
    public partial class Retentions:Screen
    {
        public Retentions():base()
        {
            this.URL = "taxmodel.retentions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RetentionsQueryView  = new RetentionsQueryView(this); 
            RetentionsQueryView.InitializeControls(); 
           
        }
      
            public RetentionsQueryView RetentionsQueryView {get; set; } 
    }
            
    public partial class RetentionsQueryView : View
    {
        public RetentionsQueryView(Retentions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierRetention = RPSControlFactory.CreateRPSCheckBox<RetentionsQueryView>("fbaed973-6da6-4fbb-b803-02df50772cc8","","",false, this);
 
            CustomerRetention = RPSControlFactory.CreateRPSCheckBox<RetentionsQueryView>("b8031667-6100-49be-b6ed-e9c5ae04c976","","",false, this);
 
            TaxPurchase = RPSControlFactory.CreateRPSCheckBox<RetentionsQueryView>("29f065b7-ba40-4d7e-b6e6-5a41039c889f","","",false, this);
 
            TaxSales = RPSControlFactory.CreateRPSCheckBox<RetentionsQueryView>("72b9d9df-dd29-4ea7-88ff-251cba678172","","",false, this);
 
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("505dcab8-fd88-4841-bc04-cd61c99e579f","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("8a59ff46-f91a-4c71-bcbf-d83a08cf5309","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("362b27f7-759b-4b76-a508-8a6d12e0aac7","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("5ca2625d-3808-4b05-b869-d84130afb555","","",false, this);
 
            Tax = RPSControlFactory.CreateRPSComboBox<RetentionsQueryView>("8befdf57-bc1f-4c8b-9a7f-c4fb4651e15c","","",false, this);
 
            TaxValue = RPSControlFactory.CreateRPSComboBox<RetentionsQueryView>("2ddaca2c-42fc-4eae-a551-efc84c219917","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<RetentionsQueryView>("0277b6a4-a1d4-41a1-9ded-0a1845c9f04c","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<RetentionsQueryView>("b0e69a62-6444-486d-95ed-9b1cac2aa403","","",false, this);
 
            KeyCondition = RPSControlFactory.CreateRPSEnumComboBox<RetentionsQueryView>("04f46b4c-3e45-44a3-ad5a-fab52e6e54ab","","",false, this);
 
            Key = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("a679d876-aba0-4a02-8a2c-471a9570eec5","","",false, this);
 
            RentingCondition = RPSControlFactory.CreateRPSEnumComboBox<RetentionsQueryView>("88e22a2d-4172-419d-b007-2517aaea72d1","","",false, this);
 
            FixedAsset = RPSControlFactory.CreateRPSComboBox<RetentionsQueryView>("f7958519-742d-474a-af6a-32a6889baa92","","",false, this);
 
            ACCTransactions_AccountingDate = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("3190b1be-970c-461a-ac47-28c7c4942385","","",false, this);
 
            ACCTransactions_Key = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("d0be1666-06dc-4fa5-aa61-dcf10b63a356","","",false, this);
 
            ACCTransactions_SubKey = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("ae5d572d-ca46-42fe-8947-e8d6f36abe08","","",false, this);
 
            ACCTransactions_VATNumber = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("205f0f20-425a-49e8-bef7-e9e4996100c8","","",false, this);
 
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("b99c7843-bed9-4257-aac9-b69dc64dee94","","",false, this);
 
            ACCTransactionsDetail_MovementType = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("4aab9d42-9c08-4f38-8811-1763af689e76","","",false, this);
 
            ACCTransactions_InvoiceDate = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("45ac76f7-484f-4d03-8104-8a9976656803","","",false, this);
 
            ACCTransactionsDetail_Extension = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("e645187f-e8f1-4773-935b-7e8e4ab58e9f","","",false, this);
 
            ACCTransactions_Renting = RPSControlFactory.CreateRPSCheckBox<RetentionsQueryView>("9a1eab15-b5e2-48d2-a17a-7d7dbea7ffd2","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("2c72f407-a966-4ccb-a3ec-571b6ee31bce","","",false, this);
 
            FixedAsset_CadastralReference = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("947ca163-8474-4ce3-b044-8f85e1c4d3a0","","",false, this);
 
            ACCTransactions_CompanyName = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("037b65da-0b55-43ed-a05f-800da9843282","","",false, this);
 
            ThirdCodState = RPSControlFactory.CreateRPSTextBox<RetentionsQueryView>("3f30b89c-2912-418a-b813-975080b93c93","","",false, this);
 
            ExecuteSaveButton = RPSControlFactory.CreateRPSButton<RetentionsQueryView>( "0e82f4f4-29b5-4979-bace-88b0f801f2c3","","",this);
 
            CollectionInit params_GetACCTransactionsDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a898b01b-68fe-46d0-85f8-ca56fabd9e60",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsDetailCollectionEditor<RetentionsQueryView>,RetentionsQueryView>( params_GetACCTransactionsDetail,this);
 

        }
        public IRPSCheckbox<RetentionsQueryView> SupplierRetention { get; set; } 
        public IRPSCheckbox<RetentionsQueryView> CustomerRetention { get; set; } 
        public IRPSCheckbox<RetentionsQueryView> TaxPurchase { get; set; } 
        public IRPSCheckbox<RetentionsQueryView> TaxSales { get; set; } 
        public IRPSTextBox<RetentionsQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<RetentionsQueryView> AccountingDateTo { get; set; } 
        public IRPSTextBox<RetentionsQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<RetentionsQueryView> InvoiceDateTo { get; set; } 
        public IRPSComboBox<RetentionsQueryView> Tax { get; set; } 
        public IRPSComboBox<RetentionsQueryView> TaxValue { get; set; } 
        public IRPSComboBox<RetentionsQueryView> Customer { get; set; } 
        public IRPSComboBox<RetentionsQueryView> Supplier { get; set; } 
        public IRPSComboBox<RetentionsQueryView> KeyCondition { get; set; } 
        public IRPSTextBox<RetentionsQueryView> Key { get; set; } 
        public IRPSComboBox<RetentionsQueryView> RentingCondition { get; set; } 
        public IRPSComboBox<RetentionsQueryView> FixedAsset { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_AccountingDate { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_Key { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_SubKey { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_VATNumber { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactionsDetail_SignType { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactionsDetail_MovementType { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_InvoiceDate { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactionsDetail_Extension { get; set; } 
        public IRPSCheckbox<RetentionsQueryView> ACCTransactions_Renting { get; set; } 
        public IRPSTextBox<RetentionsQueryView> Situation { get; set; } 
        public IRPSTextBox<RetentionsQueryView> FixedAsset_CadastralReference { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ACCTransactions_CompanyName { get; set; } 
        public IRPSTextBox<RetentionsQueryView> ThirdCodState { get; set; } 
        public IRPSButton<RetentionsQueryView> ExecuteSaveButton { get; set; } 
        public GetACCTransactionsDetailCollectionEditor<RetentionsQueryView> GetACCTransactionsDetail { get; set; } 
        public Retentions Screen { get; set; }
        public RetentionsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetACCTransactionsDetailCollectionEditor<RetentionsQueryView>:RPSCollectionEditor<RetentionsQueryView> where RetentionsQueryView : class, IView
    {
        public  GetACCTransactionsDetailGridView<RetentionsQueryView> GridView {get;set;}
    }
    public partial class GetACCTransactionsDetailGridView <RetentionsQueryView> :  RPSGridView<RetentionsQueryView> where RetentionsQueryView : class, IView
    {
        public GetACCTransactionsDetailGridView(RetentionsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactionsDetail_MovementType = RPSControlFactory.CreateRPSGridTextBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_MovementType']","",false, this.CurrentView);
 
            ACCTransactions_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_InvoiceDate']","",false, this.CurrentView);
 
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSGridTextBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_SignType']","",false, this.CurrentView);
 
            ACCTransactions_Key = RPSControlFactory.CreateRPSGridTextBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_Key']","",false, this.CurrentView);
 
            ACCTransactions_SubKey = RPSControlFactory.CreateRPSGridTextBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_SubKey']","",false, this.CurrentView);
 
            ACCTransactions_Renting = RPSControlFactory.CreateRPSGridCheckBox<RetentionsQueryView>("","#a898b01b-68fe-46d0-85f8-ca56fabd9e60 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_Renting']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RetentionsQueryView> ACCTransactionsDetail_MovementType { get; set; } 
        public IRPSGridTextBox<RetentionsQueryView> ACCTransactions_InvoiceDate { get; set; } 
        public IRPSGridTextBox<RetentionsQueryView> ACCTransactionsDetail_SignType { get; set; } 
        public IRPSGridTextBox<RetentionsQueryView> ACCTransactions_Key { get; set; } 
        public IRPSGridTextBox<RetentionsQueryView> ACCTransactions_SubKey { get; set; } 
        public IRPSGridCheckbox<RetentionsQueryView> ACCTransactions_Renting { get; set; } 
                     
    }
 
    }
  
    

}
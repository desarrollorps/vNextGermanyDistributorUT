    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.Forecast
{
    //RPS VERSION 1.0.0.0
    public partial class Forecast:Screen
    {
        public Forecast():base()
        {
            this.URL = "receivablepayable.forecast";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ForecastCollectionView  = new ForecastCollectionView(this); 
            ForecastEntityView  = new ForecastEntityView(this); 
            PeriodicPaymentsDialogView  = new PeriodicPaymentsDialogView(this); 
            ForecastCollectionView.InitializeControls(); 
            ForecastEntityView.InitializeControls(); 
            PeriodicPaymentsDialogView.InitializeControls(); 
           
        }
      
            public ForecastCollectionView ForecastCollectionView {get; set; } 
            public ForecastEntityView ForecastEntityView {get; set; } 
            public PeriodicPaymentsDialogView PeriodicPaymentsDialogView {get; set; } 
    }
            
    public partial class ForecastCollectionView : View
    {
        public ForecastCollectionView(Forecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ForecastCollectionView,ForecastEntityView>( this,Screen.ForecastEntityView);
 
            PeriodicPaymentsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ForecastCollectionView,PeriodicPaymentsDialogView>("4f3be73d-5aef-47d9-9076-917c52c2c22c","","", this,Screen.PeriodicPaymentsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "da9430e0-76fc-451e-b838-bcc8263cbc91",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ForecastCollectionView,ForecastEntityView>( params_MainConsult,this,Screen.ForecastEntityView);
 

        }
        public IRPSButton<ForecastCollectionView,ForecastEntityView> NewButton { get; set; } 
        public IRPSButton<ForecastCollectionView,PeriodicPaymentsDialogView> PeriodicPaymentsNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ForecastCollectionView,ForecastEntityView> MainConsult { get; set; } 
        public Forecast Screen { get; set; }
        public ForecastCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ForecastEntityView : View
    {
        public ForecastEntityView(Forecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ForecastEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ForecastEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ForecastEntityView,ForecastCollectionView>( this,Screen.ForecastCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ForecastEntityView,ForecastCollectionView>( this,Screen.ForecastCollectionView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<ForecastEntityView>("57353732-1e88-4489-9b0c-be05aeba0519","","",true, this);
 
            IDForecastTypeReceivable = RPSControlFactory.CreateRPSComboBox<ForecastEntityView>("daf20e21-0121-4fe4-aa9b-ad4997fead0d","","",false, this);
 
            IDForecastTypePayable = RPSControlFactory.CreateRPSComboBox<ForecastEntityView>("5c06a69e-bd96-4f3e-92d4-a8de9581618e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ForecastEntityView>("720bb186-ba9d-4bb3-bfdc-2a38a1895e7a","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ForecastEntityView>("03e7aafd-19e9-4a8d-8808-f9a09237742c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ForecastEntityView>("1cbd658e-dbe1-4b1a-add5-e65353c40e39","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ForecastEntityView>("9434b6d5-cd4c-4967-97a2-5de8c4cc81bd","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<ForecastEntityView>("4dfa5257-96f3-4422-a8bb-b2b17b356619","","",true, this);
 
            AmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<ForecastEntityView>("9bd21fd8-d391-4eab-8628-ade89c584f88","","",true, this);
 

        }
        public IRPSSaveButton<ForecastEntityView> SaveButton { get; set; } 
        public IRPSButton<ForecastEntityView> DeleteButton { get; set; } 
        public IRPSButton<ForecastEntityView,ForecastCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ForecastEntityView,ForecastCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ForecastEntityView> CustomerSupplier { get; set; } 
        public IRPSComboBox<ForecastEntityView> IDForecastTypeReceivable { get; set; } 
        public IRPSComboBox<ForecastEntityView> IDForecastTypePayable { get; set; } 
        public IRPSComboBox<ForecastEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ForecastEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<ForecastEntityView> Description { get; set; } 
        public IRPSComboBox<ForecastEntityView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<ForecastEntityView> DueDate { get; set; } 
        public IRPSTextBox<ForecastEntityView> AmountNominal { get; set; } 
        public Forecast Screen { get; set; }
        public ForecastEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PeriodicPaymentsDialogView : View
    {
        public PeriodicPaymentsDialogView(Forecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<PeriodicPaymentsDialogView>("55028050-665f-4f3d-aa24-b512cfd05870","","",true, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<PeriodicPaymentsDialogView>("3394e03c-ad0f-42fb-867b-42db12a45697","","",true, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<PeriodicPaymentsDialogView>("0d15f249-5e16-4ab5-858e-780451b531c6","","",true, this);
 
            ForecastTypePayable = RPSControlFactory.CreateRPSComboBox<PeriodicPaymentsDialogView>("96f0ad03-cdf4-4f39-97a8-bd694caccb9a","","",false, this);
 
            ForecastTypeReceivable = RPSControlFactory.CreateRPSComboBox<PeriodicPaymentsDialogView>("345c9b52-d6b2-4bd0-91ab-7125ed280f95","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<PeriodicPaymentsDialogView>("46ab06c5-9e75-486f-85e5-c0fd8e748962","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PeriodicPaymentsDialogView>("d5245a9d-bdd4-4995-805b-9d07f46a8dbd","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<PeriodicPaymentsDialogView>("e72d1c48-3530-4bd1-a4a2-6fd9025f89ce","","",true, this);
 
            PaymentAmount = RPSControlFactory.CreateRPSFormattedTextBox<PeriodicPaymentsDialogView>("1ee192d5-df06-48e1-b88a-b3ad4a9e7c89","","",true, this);
 
            NumberOfDrafts = RPSControlFactory.CreateRPSFormattedTextBox<PeriodicPaymentsDialogView>("1638a75e-6f97-450f-96eb-774110387f75","","",true, this);
 
            GapBetweenDrafts = RPSControlFactory.CreateRPSFormattedTextBox<PeriodicPaymentsDialogView>("705e3c89-b0f5-4ce3-b8a4-b454f181b7d0","","",true, this);
 
            CommercialMonth = RPSControlFactory.CreateRPSCheckBox<PeriodicPaymentsDialogView>("be82a6c6-2be6-4de4-b869-c1ec94058a29","","",true, this);
 
            OkCommand = RPSControlFactory.CreateRPSButton<PeriodicPaymentsDialogView>( "3cb4008c-344c-4d8a-94c9-8b23ff50acca","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<PeriodicPaymentsDialogView>( "be80bb32-13cb-4705-9499-b326f4a42307","","",this);
 

        }
        public IRPSComboBox<PeriodicPaymentsDialogView> CustomerSupplier { get; set; } 
        public IRPSComboBox<PeriodicPaymentsDialogView> Customer { get; set; } 
        public IRPSComboBox<PeriodicPaymentsDialogView> Supplier { get; set; } 
        public IRPSComboBox<PeriodicPaymentsDialogView> ForecastTypePayable { get; set; } 
        public IRPSComboBox<PeriodicPaymentsDialogView> ForecastTypeReceivable { get; set; } 
        public IRPSComboBox<PeriodicPaymentsDialogView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<PeriodicPaymentsDialogView> Description { get; set; } 
        public IRPSTextBox<PeriodicPaymentsDialogView> DueDate { get; set; } 
        public IRPSTextBox<PeriodicPaymentsDialogView> PaymentAmount { get; set; } 
        public IRPSTextBox<PeriodicPaymentsDialogView> NumberOfDrafts { get; set; } 
        public IRPSTextBox<PeriodicPaymentsDialogView> GapBetweenDrafts { get; set; } 
        public IRPSCheckbox<PeriodicPaymentsDialogView> CommercialMonth { get; set; } 
        public IRPSButton<PeriodicPaymentsDialogView> OkCommand { get; set; } 
        public IRPSButton<PeriodicPaymentsDialogView> CancelCommand { get; set; } 
        public Forecast Screen { get; set; }
        public PeriodicPaymentsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VATAutomaticACC
{
    //RPS VERSION 1.0.0.0
    public partial class VATAutomaticACC:Screen
    {
        public VATAutomaticACC():base()
        {
            this.URL = "generalledger.vatautomaticacc";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATAutomaticACCCollectionView  = new VATAutomaticACCCollectionView(this); 
            VATAutomaticACCEntityView  = new VATAutomaticACCEntityView(this); 
            VATAutomaticACCCollectionView.InitializeControls(); 
            VATAutomaticACCEntityView.InitializeControls(); 
           
        }
      
            public VATAutomaticACCCollectionView VATAutomaticACCCollectionView {get; set; } 
            public VATAutomaticACCEntityView VATAutomaticACCEntityView {get; set; } 
    }
            
    public partial class VATAutomaticACCCollectionView : View
    {
        public VATAutomaticACCCollectionView(VATAutomaticACC screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VATAutomaticACCCollectionView,VATAutomaticACCEntityView>( this,Screen.VATAutomaticACCEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1b82876a-6aeb-46d3-b8e1-de55f08ce0e6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VATAutomaticACCCollectionView,VATAutomaticACCEntityView>( params_MainConsult,this,Screen.VATAutomaticACCEntityView);
 

        }
        public IRPSButton<VATAutomaticACCCollectionView,VATAutomaticACCEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VATAutomaticACCCollectionView,VATAutomaticACCEntityView> MainConsult { get; set; } 
        public VATAutomaticACC Screen { get; set; }
        public VATAutomaticACCCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VATAutomaticACCEntityView : View
    {
        public VATAutomaticACCEntityView(VATAutomaticACC screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VATAutomaticACCEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VATAutomaticACCEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VATAutomaticACCEntityView,VATAutomaticACCCollectionView>( this,Screen.VATAutomaticACCCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VATAutomaticACCEntityView,VATAutomaticACCCollectionView>( this,Screen.VATAutomaticACCCollectionView);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("7fcef219-cd12-422f-aca6-245267f6dd18","","",true, this);
 
            IDAccountPurchase = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("87a80be4-494e-409a-8c03-70c6c7924ee6","","",false, this);
 
            IDAccountSales = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("15614a7c-bfdb-434a-abf6-4995a3c7d48e","","",false, this);
 
            IDAccountReverse = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("254b7398-8712-4a6d-bf8b-cb3c6ccd437e","","",false, this);
 
            IDAccountPurchaseCreditNote = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("f75eb752-55a8-4b90-9f1f-15812e1c5227","","",false, this);
 
            IDAccountSalesCreditNote = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("ce5b6138-f11f-46d1-b6db-268a4314fa45","","",false, this);
 
            IDAccConceptVATPurchase = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("04e99a0b-0702-49a1-aac2-b2904bc00b86","","",false, this);
 
            IDAccConceptVATSales = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("7cce2a9f-eca4-4d59-b72e-53c60b5d2f5c","","",false, this);
 
            IDAccConceptVATReverse = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("3dbdcbf4-f079-4281-a959-7334fccd0ba4","","",false, this);
 
            DeclarePay = RPSControlFactory.CreateRPSCheckBox<VATAutomaticACCEntityView>("424f3455-e2fe-476c-8008-81424f65f9ce","","",true, this);
 
            IDAccountPurchasePend = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("47334adc-3bc9-4cdb-b6c9-c4c62a7ed2ab","","",false, this);
 
            IDAccountSalesPend = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("b6e3970f-6c89-49c2-9ad6-96e544f8cb38","","",false, this);
 
            IDAccountExhangePos = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("6bb09de8-3985-43ae-8474-bd2e582e067e","","",false, this);
 
            IDAccountExhangeNeg = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("1040e4f4-3eb6-4b87-b1ca-87d9f9539346","","",false, this);
 
            optNotDeducAccount = RPSControlFactory.CreateRPSEnumComboBox<VATAutomaticACCEntityView>("e484b9b9-1d93-4d66-9a1e-aeaa8faa31b5","","",false, this);
 
            IDAccountNotDeduc = RPSControlFactory.CreateRPSComboBox<VATAutomaticACCEntityView>("6eb47942-e2d8-4b7d-9260-456707d4efe4","","",false, this);
 

        }
        public IRPSSaveButton<VATAutomaticACCEntityView> SaveButton { get; set; } 
        public IRPSButton<VATAutomaticACCEntityView> DeleteButton { get; set; } 
        public IRPSButton<VATAutomaticACCEntityView,VATAutomaticACCCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VATAutomaticACCEntityView,VATAutomaticACCCollectionView> BackButton { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDVAT { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountPurchase { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountSales { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountReverse { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountPurchaseCreditNote { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountSalesCreditNote { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccConceptVATPurchase { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccConceptVATSales { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccConceptVATReverse { get; set; } 
        public IRPSCheckbox<VATAutomaticACCEntityView> DeclarePay { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountPurchasePend { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountSalesPend { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountExhangePos { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountExhangeNeg { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> optNotDeducAccount { get; set; } 
        public IRPSComboBox<VATAutomaticACCEntityView> IDAccountNotDeduc { get; set; } 
        public VATAutomaticACC Screen { get; set; }
        public VATAutomaticACCEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
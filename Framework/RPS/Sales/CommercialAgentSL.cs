    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialAgentSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialAgentSL:Screen
    {
        public CommercialAgentSL():base()
        {
            this.URL = "sales.commercialagentsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialAgentSLCollectionView  = new CommercialAgentSLCollectionView(this); 
            CommercialAgentSLEntityView  = new CommercialAgentSLEntityView(this); 
            CommercialAgentSLCollectionView.InitializeControls(); 
            CommercialAgentSLEntityView.InitializeControls(); 
           
        }
      
            public CommercialAgentSLCollectionView CommercialAgentSLCollectionView {get; set; } 
            public CommercialAgentSLEntityView CommercialAgentSLEntityView {get; set; } 
    }
            
    public partial class CommercialAgentSLCollectionView : View
    {
        public CommercialAgentSLCollectionView(CommercialAgentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialAgentSLCollectionView,CommercialAgentSLEntityView>( this,Screen.CommercialAgentSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "035384f5-7e6a-474f-9c08-7c509d7c02b9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialAgentSLCollectionView,CommercialAgentSLEntityView>( params_MainConsult,this,Screen.CommercialAgentSLEntityView);
 

        }
        public IRPSButton<CommercialAgentSLCollectionView,CommercialAgentSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialAgentSLCollectionView,CommercialAgentSLEntityView> MainConsult { get; set; } 
        public CommercialAgentSL Screen { get; set; }
        public CommercialAgentSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialAgentSLEntityView : View
    {
        public CommercialAgentSLEntityView(CommercialAgentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialAgentSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialAgentSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialAgentSLEntityView,CommercialAgentSLCollectionView>( this,Screen.CommercialAgentSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialAgentSLEntityView,CommercialAgentSLCollectionView>( this,Screen.CommercialAgentSLCollectionView);
 
            CodCommercialAgent = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("cc4e35cc-a47f-4b70-8d1c-def4a1feffcb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("5566518a-bdc1-4bfd-abf7-a0087a896865","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("c37c9f79-202c-4d42-beb5-6b4f36a5ebb5","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("cf2047b8-1e27-41d2-ae9b-bcb5a9f043df","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CommercialAgentSLEntityView>("51b78c55-4354-4e1f-85db-ac160ccaba20","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CommercialAgentSLEntityView>("b212117e-f77d-42b4-ad8a-4c25aeca70a8","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("bb4435af-6a35-4bf3-bbf7-574590387f86","","",false, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("364dd9dd-01e0-4058-a1f1-c5683070ced4","","",false, this);
 
            IDCommercialAgentCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("6c49d6d1-9ffe-4091-9f51-9836431ffccd","","",false, this);
 
            IDCommercialAgentParent = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("7712c01e-8aa6-45e9-97ce-2cc0090e5db1","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("8d343ee3-5582-4322-ad2d-59ca6d7c28bd","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("10e8ab68-bc60-4db8-8d19-894b96a76df4","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("c42eeec0-1494-4716-ae38-b401307a14c5","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("0de71770-a3a6-4b29-94c5-4e5795f895a9","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CommercialAgentSLEntityView>("6d726fca-b3e2-4aa3-8ee6-cfcef5ec00b9","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("e1b19503-217f-4b29-9d16-58669848410b","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("c997950a-f6ad-46d4-bc2d-b3fe011795f4","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("3d4e0f60-69ae-4472-b6bc-b49a3fed4638","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("e2f69dfb-4e73-4121-af51-e31bffb8f729","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("a2684808-b431-47bd-a9a1-25a2f9445fc4","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CommercialAgentSLEntityView>("581db6bb-b548-4df7-bccf-9b168aa0d3ef","","",false, this);
 
            BaseCalc = RPSControlFactory.CreateRPSEnumComboBox<CommercialAgentSLEntityView>("65d089b7-00bf-4f2b-8f5d-362cc201f898","","",true, this);
 
            ApplyDiscountLines = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("b1ba5940-3a80-4b05-bb8b-bdef8e6f99bc","","",true, this);
 
            ApplyDiscountCustomer = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("770de58d-b54a-47be-8fe9-eda829f6d93e","","",true, this);
 
            ApplyCashDiscount = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("84c15173-b39a-4095-b79e-49ff945a0073","","",true, this);
 
            BaseLiq = RPSControlFactory.CreateRPSEnumComboBox<CommercialAgentSLEntityView>("41c7dd5a-78ba-430c-959c-4fa160b417e2","","",true, this);
 
            BaseCalcObjetive = RPSControlFactory.CreateRPSEnumComboBox<CommercialAgentSLEntityView>("787dc70d-ac5e-4dd5-b59b-9e5015b5d3e6","","",true, this);
 
            ApplyDiscountLinesObjetive = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("ed5c6fe7-bb01-4960-ae8a-cde5c41aea4d","","",true, this);
 
            ApplyDiscountCustomerObjetive = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("09dd7e80-8564-427c-b1fd-467daf48b515","","",true, this);
 
            ApplyCashDiscountObjetive = RPSControlFactory.CreateRPSCheckBox<CommercialAgentSLEntityView>("3ba41aa3-c787-4fda-b97a-835c75246e5b","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CommercialAgentSLEntityView>("53e019b5-57c4-4f75-a136-6d87d8539e16","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CommercialAgentSLEntityView>( "","ul li[rpsid='f3c8bf9a-f41f-4111-83bd-8378380bf20c']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CommercialAgentSLEntityView>( "","ul li[rpsid='05e3f164-6fe5-4c7d-a82f-f878ad161d8b']","",this);
 

        }
        public IRPSSaveButton<CommercialAgentSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialAgentSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialAgentSLEntityView,CommercialAgentSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialAgentSLEntityView,CommercialAgentSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> CodCommercialAgent { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Description { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> Type { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDCommercialAgentCommissionGroup { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDCommercialAgentParent { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> CodUser { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDState { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Address { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> City { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Fax { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Email { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> BaseCalc { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyDiscountLines { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyDiscountCustomer { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyCashDiscount { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> BaseLiq { get; set; } 
        public IRPSComboBox<CommercialAgentSLEntityView> BaseCalcObjetive { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyDiscountLinesObjetive { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyDiscountCustomerObjetive { get; set; } 
        public IRPSCheckbox<CommercialAgentSLEntityView> ApplyCashDiscountObjetive { get; set; } 
        public IRPSTextBox<CommercialAgentSLEntityView> Comment { get; set; } 
        public IRPSSection<CommercialAgentSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CommercialAgentSLEntityView> Comments { get; set; } 
        public CommercialAgentSL Screen { get; set; }
        public CommercialAgentSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
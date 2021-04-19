    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ThirdAccType
{
    //RPS VERSION 1.0.0.0
    public partial class ThirdAccType:Screen
    {
        public ThirdAccType():base()
        {
            this.URL = "generalledger.thirdacctype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ThirdAccTypeCollectionView  = new ThirdAccTypeCollectionView(this); 
            ThirdAccTypeEntityView  = new ThirdAccTypeEntityView(this); 
            ThirdAccTypeCollectionView.InitializeControls(); 
            ThirdAccTypeEntityView.InitializeControls(); 
           
        }
      
            public ThirdAccTypeCollectionView ThirdAccTypeCollectionView {get; set; } 
            public ThirdAccTypeEntityView ThirdAccTypeEntityView {get; set; } 
    }
            
    public partial class ThirdAccTypeCollectionView : View
    {
        public ThirdAccTypeCollectionView(ThirdAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ThirdAccTypeCollectionView,ThirdAccTypeEntityView>( this,Screen.ThirdAccTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "686be68f-4081-4def-a7dd-eb6a4e6646c4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ThirdAccTypeCollectionView,ThirdAccTypeEntityView>( params_MainConsult,this,Screen.ThirdAccTypeEntityView);
 

        }
        public IRPSButton<ThirdAccTypeCollectionView,ThirdAccTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ThirdAccTypeCollectionView,ThirdAccTypeEntityView> MainConsult { get; set; } 
        public ThirdAccType Screen { get; set; }
        public ThirdAccTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ThirdAccTypeEntityView : View
    {
        public ThirdAccTypeEntityView(ThirdAccType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ThirdAccTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ThirdAccTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ThirdAccTypeEntityView,ThirdAccTypeCollectionView>( this,Screen.ThirdAccTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ThirdAccTypeEntityView,ThirdAccTypeCollectionView>( this,Screen.ThirdAccTypeCollectionView);
 
            CodThirdAccType = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("dd6de686-2a65-439f-b0d6-ca32783d314d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("63c1f841-0d24-4f7e-80e2-5d90faf4479d","","",false, this);
 
            CodAPAccount = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("a8019a6c-1f0a-4f28-9154-31c279e2a31a","","",true, this);
 
            TypeAPAcc = RPSControlFactory.CreateRPSEnumComboBox<ThirdAccTypeEntityView>("db3370d4-aebd-4f61-88c2-c5f0ff70edee","","",true, this);
 
            IDSupplierAccount = RPSControlFactory.CreateRPSComboBox<ThirdAccTypeEntityView>("af9b74d6-f636-45d5-a74b-a200293639de","","",false, this);
 
            prefijoAPAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("6826d780-5151-4e17-8410-902abd7a0c42","","",false, this);
 
            desdeAPAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("a90b5059-5f9b-4731-ba67-8b85df2cf648","","",false, this);
 
            hastaAPAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("301c7c4b-ce68-4760-bf8b-02f3ec3ad9cf","","",false, this);
 
            CodAPAdvance = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("b9a60deb-0b62-4782-bf25-f07e00bd15e4","","",true, this);
 
            TypeAPAdv = RPSControlFactory.CreateRPSEnumComboBox<ThirdAccTypeEntityView>("20a90fdf-b54a-4f67-9b18-5156355d9b7c","","",true, this);
 
            IDSupplierAdvanceAccount = RPSControlFactory.CreateRPSComboBox<ThirdAccTypeEntityView>("7fda68ad-79cd-4dd3-a604-d0e1bee41496","","",false, this);
 
            prefijoAPAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("f7df008c-03e9-4fa2-bc2c-d6328a4eb48c","","",false, this);
 
            desdeAPAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("28f7eff9-6fe1-4571-9753-c8dd3c28ec8a","","",false, this);
 
            hastaAPAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("2c211358-d48f-4f31-a558-2e2bb78385d1","","",false, this);
 
            CodARAccount = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("630c747c-cfe2-46cb-beae-52b3ed728a9f","","",true, this);
 
            TypeARAcc = RPSControlFactory.CreateRPSEnumComboBox<ThirdAccTypeEntityView>("ddc63ae5-299b-43f9-8bff-869e26dba70a","","",true, this);
 
            IDCustomerAccount = RPSControlFactory.CreateRPSComboBox<ThirdAccTypeEntityView>("2038e7d5-1b03-4015-8841-5dbc86f60c55","","",false, this);
 
            prefijoARAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("d605d900-0ebf-418c-9ca6-5b80b0ffc259","","",false, this);
 
            desdeARAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("029eb06e-47b2-42d5-aefa-91d26693ce01","","",false, this);
 
            hastaARAcc = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("e5948291-1c49-4701-8932-f3ab16111244","","",false, this);
 
            CodARAdvance = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("6a43f71b-fdfb-4a05-adec-dc761f5ebde8","","",true, this);
 
            TypeARAdv = RPSControlFactory.CreateRPSEnumComboBox<ThirdAccTypeEntityView>("1d393b03-0df8-43e0-bac8-928fdde7da92","","",true, this);
 
            IDCustomerAdvanceAccount = RPSControlFactory.CreateRPSComboBox<ThirdAccTypeEntityView>("d6e5e643-b94b-47bc-b9fc-c781920a8b11","","",false, this);
 
            prefijoARAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("99ef4b69-2397-48dc-ae1d-7dd2bab47a7f","","",false, this);
 
            desdeARAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("08754dec-f660-4193-803b-0bda05bfd9ab","","",false, this);
 
            hastaARAdv = RPSControlFactory.CreateRPSTextBox<ThirdAccTypeEntityView>("fbafc381-7ecd-42e9-8a32-4235c272fa87","","",false, this);
 

        }
        public IRPSSaveButton<ThirdAccTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<ThirdAccTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<ThirdAccTypeEntityView,ThirdAccTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ThirdAccTypeEntityView,ThirdAccTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> CodThirdAccType { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> Description { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> CodAPAccount { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> TypeAPAcc { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> IDSupplierAccount { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> prefijoAPAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> desdeAPAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> hastaAPAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> CodAPAdvance { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> TypeAPAdv { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> IDSupplierAdvanceAccount { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> prefijoAPAdv { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> desdeAPAdv { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> hastaAPAdv { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> CodARAccount { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> TypeARAcc { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> IDCustomerAccount { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> prefijoARAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> desdeARAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> hastaARAcc { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> CodARAdvance { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> TypeARAdv { get; set; } 
        public IRPSComboBox<ThirdAccTypeEntityView> IDCustomerAdvanceAccount { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> prefijoARAdv { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> desdeARAdv { get; set; } 
        public IRPSTextBox<ThirdAccTypeEntityView> hastaARAdv { get; set; } 
        public ThirdAccType Screen { get; set; }
        public ThirdAccTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
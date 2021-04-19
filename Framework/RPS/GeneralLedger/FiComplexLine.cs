    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FiComplexLine
{
    //RPS VERSION 1.0.0.0
    public partial class FiComplexLine:Screen
    {
        public FiComplexLine():base()
        {
            this.URL = "generalledger.ficomplexline";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FIComplexLineCollectionView  = new FIComplexLineCollectionView(this); 
            FIComplexLineEntityView  = new FIComplexLineEntityView(this); 
            FIComplexLineCollectionView.InitializeControls(); 
            FIComplexLineEntityView.InitializeControls(); 
           
        }
      
            public FIComplexLineCollectionView FIComplexLineCollectionView {get; set; } 
            public FIComplexLineEntityView FIComplexLineEntityView {get; set; } 
    }
            
    public partial class FIComplexLineCollectionView : View
    {
        public FIComplexLineCollectionView(FiComplexLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FIComplexLineCollectionView,FIComplexLineEntityView>( this,Screen.FIComplexLineEntityView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<FIComplexLineCollectionView>( "3069beeb-7357-4ca1-a8d7-e25d0a9a4194","","",this);
 
            LinkNavigationCommandImportButton = RPSControlFactory.CreateRPSButton<FIComplexLineCollectionView>( "002e3037-1811-410c-ba1a-f3ba1238726b","","",this);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ef4d53c4-7202-43cd-a736-64ee910c8b3c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FIComplexLineCollectionView,FIComplexLineEntityView>( params_MainConsult,this,Screen.FIComplexLineEntityView);
 

        }
        public IRPSButton<FIComplexLineCollectionView,FIComplexLineEntityView> NewButton { get; set; } 
        public IRPSButton<FIComplexLineCollectionView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<FIComplexLineCollectionView> LinkNavigationCommandImportButton { get; set; } 
        public IRPSCollectionEditor<FIComplexLineCollectionView,FIComplexLineEntityView> MainConsult { get; set; } 
        public FiComplexLine Screen { get; set; }
        public FIComplexLineCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FIComplexLineEntityView : View
    {
        public FIComplexLineEntityView(FiComplexLine screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FIComplexLineEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FIComplexLineEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FIComplexLineEntityView,FIComplexLineCollectionView>( this,Screen.FIComplexLineCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FIComplexLineEntityView,FIComplexLineCollectionView>( this,Screen.FIComplexLineCollectionView);
 
            CodComplexLine = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("c78eb6e4-3a20-4a62-ba23-7a7d34029cb9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("5335d5d1-73b7-43cc-bd7c-e25d560250a1","","",false, this);
 
            Areas = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("f8f984ab-037c-44ae-aa9f-ead4f5fb30c4","","",false, this);
 
            VoucherTypes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("18ee38cd-5528-4b1a-b952-cdd7f24d8320","","",false, this);
 
            UIVoucherTypes = RPSControlFactory.CreateRPSCollectionComboBox<FIComplexLineEntityView>("334f5323-7e53-43db-a2bd-3fc4e8d3ffd8","","",false, this);
 
            DocumentTypes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("3eec6f41-63cd-47eb-a1f0-16ce3f31bea2","","",false, this);
 
            CountryType = RPSControlFactory.CreateRPSEnumComboBox<FIComplexLineEntityView>("7006fac1-0247-4ea8-8391-be09f13b2cd8","","",true, this);
 
            MovementTypes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("80f776eb-1ef8-4e1e-a3d3-4c7aa5db6e25","","",false, this);
 
            VATCodes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("63e483da-2cc3-4472-8e54-b31f43f1dde8","","",false, this);
 
            UIVATs = RPSControlFactory.CreateRPSCollectionComboBox<FIComplexLineEntityView>("fbb63863-dc23-461d-a768-2dc1b09826f2","","",false, this);
 
            TaxCodes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("0c8e4fc9-048e-4bda-8d44-eb2537bdfa9e","","",false, this);
 
            UIIDTaxs = RPSControlFactory.CreateRPSCollectionComboBox<FIComplexLineEntityView>("9cb7fa0a-197d-47c1-af58-e6c5000bb67a","","",false, this);
 
            TaxValueCodes = RPSControlFactory.CreateRPSTextBox<FIComplexLineEntityView>("d38db6ad-0eb2-4a27-80ee-00f5305bae15","","",false, this);
 
            UIIDTaxValues = RPSControlFactory.CreateRPSCollectionComboBox<FIComplexLineEntityView>("edb76c51-964c-4a68-8e13-513ba91040ba","","",false, this);
 
            UsePercentage = RPSControlFactory.CreateRPSCheckBox<FIComplexLineEntityView>("95962972-48a6-4474-9ed2-62fc4ae9f0f6","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<FIComplexLineEntityView>("802ca526-68db-4afc-898f-0b2d088be0be","","",true, this);
 

        }
        public IRPSSaveButton<FIComplexLineEntityView> SaveButton { get; set; } 
        public IRPSButton<FIComplexLineEntityView> DeleteButton { get; set; } 
        public IRPSButton<FIComplexLineEntityView,FIComplexLineCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FIComplexLineEntityView,FIComplexLineCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> CodComplexLine { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> Description { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> Areas { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> VoucherTypes { get; set; } 
        public IRPSCollectionComboBox<FIComplexLineEntityView> UIVoucherTypes { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> DocumentTypes { get; set; } 
        public IRPSComboBox<FIComplexLineEntityView> CountryType { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> MovementTypes { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> VATCodes { get; set; } 
        public IRPSCollectionComboBox<FIComplexLineEntityView> UIVATs { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> TaxCodes { get; set; } 
        public IRPSCollectionComboBox<FIComplexLineEntityView> UIIDTaxs { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> TaxValueCodes { get; set; } 
        public IRPSCollectionComboBox<FIComplexLineEntityView> UIIDTaxValues { get; set; } 
        public IRPSCheckbox<FIComplexLineEntityView> UsePercentage { get; set; } 
        public IRPSTextBox<FIComplexLineEntityView> Percentage { get; set; } 
        public FiComplexLine Screen { get; set; }
        public FIComplexLineEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
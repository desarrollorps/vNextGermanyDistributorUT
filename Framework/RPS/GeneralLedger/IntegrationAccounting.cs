    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.IntegrationAccounting
{
    //RPS VERSION 1.0.0.0
    public partial class IntegrationAccounting:Screen
    {
        public IntegrationAccounting():base()
        {
            this.URL = "generalledger.integrationaccounting";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IntegrationAccountingCollectionView  = new IntegrationAccountingCollectionView(this); 
            IntegrationAccountingEntityView  = new IntegrationAccountingEntityView(this); 
            IntegrationAccountingDetailView  = new IntegrationAccountingDetailView(this); 
            ConceptExtensionDialogView  = new ConceptExtensionDialogView(this); 
            IntegrationDimDetailView  = new IntegrationDimDetailView(this); 
            IntegrationAccountingCollectionView.InitializeControls(); 
            IntegrationAccountingEntityView.InitializeControls(); 
            IntegrationAccountingDetailView.InitializeControls(); 
            ConceptExtensionDialogView.InitializeControls(); 
            IntegrationDimDetailView.InitializeControls(); 
           
        }
      
            public IntegrationAccountingCollectionView IntegrationAccountingCollectionView {get; set; } 
            public IntegrationAccountingEntityView IntegrationAccountingEntityView {get; set; } 
            public IntegrationAccountingDetailView IntegrationAccountingDetailView {get; set; } 
            public ConceptExtensionDialogView ConceptExtensionDialogView {get; set; } 
            public IntegrationDimDetailView IntegrationDimDetailView {get; set; } 
    }
            
    public partial class IntegrationAccountingCollectionView : View
    {
        public IntegrationAccountingCollectionView(IntegrationAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IntegrationAccountingCollectionView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2ec25b20-ebfd-4fa9-85be-d0910a3b6196",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IntegrationAccountingCollectionView,IntegrationAccountingEntityView>( params_MainConsult,this,Screen.IntegrationAccountingEntityView);
 

        }
        public IRPSButton<IntegrationAccountingCollectionView,IntegrationAccountingEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IntegrationAccountingCollectionView,IntegrationAccountingEntityView> MainConsult { get; set; } 
        public IntegrationAccounting Screen { get; set; }
        public IntegrationAccountingCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IntegrationAccountingEntityView : View
    {
        public IntegrationAccountingEntityView(IntegrationAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IntegrationAccountingEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IntegrationAccountingEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IntegrationAccountingEntityView,IntegrationAccountingCollectionView>( this,Screen.IntegrationAccountingCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IntegrationAccountingEntityView,IntegrationAccountingCollectionView>( this,Screen.IntegrationAccountingCollectionView);
 
            CodIntegrationAccounting = RPSControlFactory.CreateRPSTextBox<IntegrationAccountingEntityView>("5aa331da-2bea-4bd8-98d0-dbc06fe6ac71","","",true, this);
 
            Service = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingEntityView>("478cafe1-ca0e-4217-9109-69a11c5bd3a2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IntegrationAccountingEntityView>("233633c2-2fdc-4b81-ad02-aea484224ec5","","",false, this);
 
            OnlyAnalytic = RPSControlFactory.CreateRPSCheckBox<IntegrationAccountingEntityView>("20a2aac8-a7ba-42da-b4f2-8d43e3b9bae8","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<IntegrationAccountingEntityView>("5d4fe9b3-c880-4e3d-ad7e-55bc365d1fda","","",false, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingEntityView>("58add248-b7a7-47ce-ae01-d80edb322198","","",false, this);
 
            TypeInvoice = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingEntityView>("38a9f128-40bd-4388-94e6-75ea3648eb31","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<IntegrationAccountingEntityView>("2718fb68-d127-49a8-95ab-40172d6b2447","","",false, this);
 
            CollectionInit params_IntegrationAccountingDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="69273aa6-5ba1-424e-9ac2-545b99356f1b",CSSSelectorGrid="",XPathGrid=""};
            IntegrationAccountingDetails = RPSControlFactory.RPSCreateCollectionWithGrid<IntegrationAccountingDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView>,IntegrationAccountingEntityView,IntegrationAccountingDetailView>( params_IntegrationAccountingDetails,this,Screen.IntegrationAccountingDetailView);
 
            CollectionInit params_IntegrationDimDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d3a1b78e-dfd4-4013-b8e9-fabdda761b6c",CSSSelectorGrid="",XPathGrid=""};
            IntegrationDimDetails = RPSControlFactory.RPSCreateCollectionWithGrid<IntegrationDimDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView>,IntegrationAccountingEntityView,IntegrationAccountingDetailView>( params_IntegrationDimDetails,this,Screen.IntegrationAccountingDetailView);
 
            Section1 = RPSControlFactory.CreateRPSSection<IntegrationAccountingEntityView>( "","ul li[rpsid='06a985d8-7756-4663-9fb7-b7b7baa2c456']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<IntegrationAccountingEntityView>( "","ul li[rpsid='8507726e-bfc8-46fc-86c5-8bcd2ae4059b']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<IntegrationAccountingEntityView>( "","ul li[rpsid='7ec17bcc-4a79-4b88-9d29-908520145a34']","",this);
 

        }
        public IRPSSaveButton<IntegrationAccountingEntityView> SaveButton { get; set; } 
        public IRPSButton<IntegrationAccountingEntityView> DeleteButton { get; set; } 
        public IRPSButton<IntegrationAccountingEntityView,IntegrationAccountingCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IntegrationAccountingEntityView,IntegrationAccountingCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IntegrationAccountingEntityView> CodIntegrationAccounting { get; set; } 
        public IRPSComboBox<IntegrationAccountingEntityView> Service { get; set; } 
        public IRPSTextBox<IntegrationAccountingEntityView> Description { get; set; } 
        public IRPSCheckbox<IntegrationAccountingEntityView> OnlyAnalytic { get; set; } 
        public IRPSComboBox<IntegrationAccountingEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<IntegrationAccountingEntityView> CodACCType { get; set; } 
        public IRPSComboBox<IntegrationAccountingEntityView> TypeInvoice { get; set; } 
        public IRPSComboBox<IntegrationAccountingEntityView> IDAccount { get; set; } 
        public IntegrationAccountingDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView> IntegrationAccountingDetails { get; set; } 
        public IntegrationDimDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView> IntegrationDimDetails { get; set; } 
        public IRPSSection<IntegrationAccountingEntityView> Section1 { get; set; } 
        public IRPSSection<IntegrationAccountingEntityView> Section { get; set; } 
        public IRPSSection<IntegrationAccountingEntityView> Section2 { get; set; } 
        public IntegrationAccounting Screen { get; set; }
        public IntegrationAccountingEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class IntegrationAccountingDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView>:RPSCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView> where IntegrationAccountingEntityView : class, IView where IntegrationAccountingDetailView : class, IView
    {
        public  IntegrationAccountingDetailsGridView<IntegrationAccountingEntityView,IntegrationAccountingDetailView> GridView {get;set;}
    }
    public partial class IntegrationAccountingDetailsGridView <IntegrationAccountingEntityView,IntegrationAccountingDetailView> :  RPSGridView<IntegrationAccountingEntityView,IntegrationAccountingDetailView> where IntegrationAccountingEntityView : class, IView where IntegrationAccountingDetailView : class, IView
    {
        public IntegrationAccountingDetailsGridView(IntegrationAccountingEntityView currentView,IntegrationAccountingDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLine = RPSControlFactory.CreateRPSGridFormattedTextBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cOrderLine']","",true, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 
            TypeAcc = RPSControlFactory.CreateRPSGridEnumComboBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cTypeAcc']","",true, this.CurrentView);
 
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",false, this.CurrentView);
 
            GroupType = RPSControlFactory.CreateRPSGridCheckBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cGroupType']","",true, this.CurrentView);
 
            AmountType = RPSControlFactory.CreateRPSGridEnumComboBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cAmountType']","",true, this.CurrentView);
 
            IDAccConcept = RPSControlFactory.CreateRPSGridComboBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cIDAccConcept']","",true, this.CurrentView);
 
            ManufacturedArticle = RPSControlFactory.CreateRPSGridCheckBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cManufacturedArticle']","",true, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<IntegrationAccountingEntityView>("","#69273aa6-5ba1-424e-9ac2-545b99356f1b .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<IntegrationAccountingEntityView> OrderLine { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> SignType { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> TypeAcc { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> IDAccount { get; set; } 
        public IRPSGridCheckbox<IntegrationAccountingEntityView> GroupType { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> AmountType { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> IDAccConcept { get; set; } 
        public IRPSGridCheckbox<IntegrationAccountingEntityView> ManufacturedArticle { get; set; } 
        public IRPSGridTextBox<IntegrationAccountingEntityView> Extension { get; set; } 
                     
    }
 
        public partial class IntegrationDimDetailsCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView>:RPSCollectionEditor<IntegrationAccountingEntityView,IntegrationAccountingDetailView> where IntegrationAccountingEntityView : class, IView where IntegrationAccountingDetailView : class, IView
    {
        public  IntegrationDimDetailsGridView<IntegrationAccountingEntityView,IntegrationAccountingDetailView> GridView {get;set;}
    }
    public partial class IntegrationDimDetailsGridView <IntegrationAccountingEntityView,IntegrationAccountingDetailView> :  RPSGridView<IntegrationAccountingEntityView,IntegrationAccountingDetailView> where IntegrationAccountingEntityView : class, IView where IntegrationAccountingDetailView : class, IView
    {
        public IntegrationDimDetailsGridView(IntegrationAccountingEntityView currentView,IntegrationAccountingDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<IntegrationAccountingEntityView>("","#d3a1b78e-dfd4-4013-b8e9-fabdda761b6c .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<IntegrationAccountingEntityView>("","#d3a1b78e-dfd4-4013-b8e9-fabdda761b6c .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<IntegrationAccountingEntityView>("","#d3a1b78e-dfd4-4013-b8e9-fabdda761b6c .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<IntegrationAccountingEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<IntegrationAccountingEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<IntegrationAccountingEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class IntegrationAccountingDetailView : View
    {
        public IntegrationAccountingDetailView(IntegrationAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<IntegrationAccountingDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            OrderLine = RPSControlFactory.CreateRPSFormattedTextBox<IntegrationAccountingDetailView>("281fe444-2a4e-4b79-a27f-36d886dae122","","",true, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingDetailView>("97c0f7b7-593a-4b4e-a94b-b193149f6725","","",true, this);
 
            TypeAcc = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingDetailView>("725617bc-9b56-4f01-b8cd-678988deaca2","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<IntegrationAccountingDetailView>("6b94fc27-c0b9-45c2-9d65-99d681dbeca1","","",false, this);
 
            GroupType = RPSControlFactory.CreateRPSCheckBox<IntegrationAccountingDetailView>("e5830cbe-f6ef-4a15-bd30-7898be14e923","","",true, this);
 
            AmountType = RPSControlFactory.CreateRPSEnumComboBox<IntegrationAccountingDetailView>("6809083a-bd02-41c2-a28b-9cfc31bcd032","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<IntegrationAccountingDetailView>("8957da69-c111-4f6d-a167-4f6e74681ef7","","",true, this);
 
            ManufacturedArticle = RPSControlFactory.CreateRPSCheckBox<IntegrationAccountingDetailView>("8a33c501-a11e-4163-a0b1-a6593becad5b","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<IntegrationAccountingDetailView>("4bd3c1c8-683a-46ec-bf80-eeab45872adf","","",false, this);
 
            ConceptExtensionNavigationCommand = RPSControlFactory.CreateRPSButtonToView<IntegrationAccountingDetailView,ConceptExtensionDialogView>("2df1e9cb-ea2f-4b65-809b-5fa214b24c6a","","", this,Screen.ConceptExtensionDialogView);
 

        }
        public IRPSButton<IntegrationAccountingDetailView> DeleteButton { get; set; } 
        public IRPSButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<IntegrationAccountingDetailView,IntegrationAccountingEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<IntegrationAccountingDetailView> OrderLine { get; set; } 
        public IRPSComboBox<IntegrationAccountingDetailView> SignType { get; set; } 
        public IRPSComboBox<IntegrationAccountingDetailView> TypeAcc { get; set; } 
        public IRPSComboBox<IntegrationAccountingDetailView> IDAccount { get; set; } 
        public IRPSCheckbox<IntegrationAccountingDetailView> GroupType { get; set; } 
        public IRPSComboBox<IntegrationAccountingDetailView> AmountType { get; set; } 
        public IRPSComboBox<IntegrationAccountingDetailView> IDAccConcept { get; set; } 
        public IRPSCheckbox<IntegrationAccountingDetailView> ManufacturedArticle { get; set; } 
        public IRPSTextBox<IntegrationAccountingDetailView> Extension { get; set; } 
        public IRPSButton<IntegrationAccountingDetailView,ConceptExtensionDialogView> ConceptExtensionNavigationCommand { get; set; } 
        public IntegrationAccounting Screen { get; set; }
        public IntegrationAccountingDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ConceptExtensionDialogView : View
    {
        public ConceptExtensionDialogView(IntegrationAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("bba55f78-9b32-4cd5-b908-e0a2402b7ee4","","",false, this);
 
            Property = RPSControlFactory.CreateRPSEnumComboBox<ConceptExtensionDialogView>("19185770-ac88-4f91-814f-00bcccd2f69b","","",false, this);
 
            AddProperty = RPSControlFactory.CreateRPSButton<ConceptExtensionDialogView>( "65c6606a-bf71-4c31-9438-b7b4cd5a24f8","","",this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<ConceptExtensionDialogView>("17c36b7b-5a8c-40f0-8bab-d5fc7ebcf42e","","",false, this);
 

        }
        public IRPSComboBox<ConceptExtensionDialogView> Entity { get; set; } 
        public IRPSComboBox<ConceptExtensionDialogView> Property { get; set; } 
        public IRPSButton<ConceptExtensionDialogView> AddProperty { get; set; } 
        public IRPSTextBox<ConceptExtensionDialogView> Extension { get; set; } 
        public IntegrationAccounting Screen { get; set; }
        public ConceptExtensionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IntegrationDimDetailView : View
    {
        public IntegrationDimDetailView(IntegrationAccounting screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<IntegrationDimDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IntegrationDimDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<IntegrationDimDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<IntegrationDimDetailView,IntegrationAccountingEntityView>( this,Screen.IntegrationAccountingEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<IntegrationDimDetailView>("ea7d194f-0bc7-4811-9d68-5d2d0ef24409","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<IntegrationDimDetailView>("3e1ee986-0435-4b71-abaa-43d9b46f72db","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<IntegrationDimDetailView>("2c93b191-341d-441d-8af1-b13c8b30e3ee","","",true, this);
 

        }
        public IRPSButton<IntegrationDimDetailView> DeleteButton { get; set; } 
        public IRPSButton<IntegrationDimDetailView,IntegrationAccountingEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IntegrationDimDetailView,IntegrationAccountingEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<IntegrationDimDetailView,IntegrationAccountingEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<IntegrationDimDetailView> IDDimension { get; set; } 
        public IRPSComboBox<IntegrationDimDetailView> IDDimValue { get; set; } 
        public IRPSTextBox<IntegrationDimDetailView> Percentage { get; set; } 
        public IntegrationAccounting Screen { get; set; }
        public IntegrationDimDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
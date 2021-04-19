    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccYear
{
    //RPS VERSION 1.0.0.0
    public partial class AccYear:Screen
    {
        public AccYear():base()
        {
            this.URL = "generalledger.accyear";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ACCYearCollectionView  = new ACCYearCollectionView(this); 
            ACCYearEntityView  = new ACCYearEntityView(this); 
            ACCPeriodView  = new ACCPeriodView(this); 
            FirstVoucherChildDialogView  = new FirstVoucherChildDialogView(this); 
            ChangesDatesChildDialogView  = new ChangesDatesChildDialogView(this); 
            NewAccYearChilViewDialogView  = new NewAccYearChilViewDialogView(this); 
            ACCYearCollectionView.InitializeControls(); 
            ACCYearEntityView.InitializeControls(); 
            ACCPeriodView.InitializeControls(); 
            FirstVoucherChildDialogView.InitializeControls(); 
            ChangesDatesChildDialogView.InitializeControls(); 
            NewAccYearChilViewDialogView.InitializeControls(); 
           
        }
      
            public ACCYearCollectionView ACCYearCollectionView {get; set; } 
            public ACCYearEntityView ACCYearEntityView {get; set; } 
            public ACCPeriodView ACCPeriodView {get; set; } 
            public FirstVoucherChildDialogView FirstVoucherChildDialogView {get; set; } 
            public ChangesDatesChildDialogView ChangesDatesChildDialogView {get; set; } 
            public NewAccYearChilViewDialogView NewAccYearChilViewDialogView {get; set; } 
    }
            
    public partial class ACCYearCollectionView : View
    {
        public ACCYearCollectionView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ACCYearCollectionView,ACCYearEntityView>( this,Screen.ACCYearEntityView);
 
            NewAccYearChilViewNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCYearCollectionView,NewAccYearChilViewDialogView>("0055a1ea-e9ac-46f4-8c56-52d17b3632c9","","", this,Screen.NewAccYearChilViewDialogView);
 
            FirstVoucherChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCYearCollectionView,FirstVoucherChildDialogView>("a81b3282-6428-48e7-b2e0-54627cde1f53","","", this,Screen.FirstVoucherChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a3044e79-975e-4641-8b96-aec6c34a10f0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ACCYearCollectionView,ACCYearEntityView>( params_MainConsult,this,Screen.ACCYearEntityView);
 

        }
        public IRPSButton<ACCYearCollectionView,ACCYearEntityView> NewButton { get; set; } 
        public IRPSButton<ACCYearCollectionView,NewAccYearChilViewDialogView> NewAccYearChilViewNavigationCommandButton { get; set; } 
        public IRPSButton<ACCYearCollectionView,FirstVoucherChildDialogView> FirstVoucherChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ACCYearCollectionView,ACCYearEntityView> MainConsult { get; set; } 
        public AccYear Screen { get; set; }
        public ACCYearCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ACCYearEntityView : View
    {
        public ACCYearEntityView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ACCYearEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCYearEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCYearEntityView,ACCYearCollectionView>( this,Screen.ACCYearCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCYearEntityView,ACCYearCollectionView>( this,Screen.ACCYearCollectionView);
 
            CodYear = RPSControlFactory.CreateRPSFormattedTextBox<ACCYearEntityView>("a92c8ffb-f070-4424-bb14-763717723291","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ACCYearEntityView>("4d38517b-9cee-4344-be11-b25a4f676c7e","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ACCYearEntityView>("701d5a2b-9857-4360-b0e5-b7b7b9177cc1","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ACCYearEntityView>("88d871a0-4461-4bfa-aa9b-8fa9421c4d5a","","",true, this);
 
            JournalLastUsedNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCYearEntityView>("a83f065a-efe0-43e4-9b54-d68e1084dcaa","","",true, this);
 
            VATAPLastUsedNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCYearEntityView>("966f85b1-8b7e-4dee-9ea9-bdf9773f8e38","","",true, this);
 
            VATARLastUsedNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCYearEntityView>("1cf5799b-7b3d-4ad6-91b0-890db274a8a8","","",true, this);
 
            JournalAnaUsedNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCYearEntityView>("2d3fe17d-e6ef-474c-88d3-a01ddad6b625","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ACCYearEntityView>("a81af415-de9c-4976-b4fc-f96c3dc83105","","",true, this);
 
            ACCTransactionsISJN = RPSControlFactory.CreateRPSComboBox<ACCYearEntityView>("a7835bd3-929c-4b0b-81ca-c86fe96b39f5","","",false, this);
 
            ACCTransactionsPSJN = RPSControlFactory.CreateRPSComboBox<ACCYearEntityView>("2882164f-9ab8-46f0-beb6-a495ae5b8d5c","","",false, this);
 
            ACCTransactionsYCJN = RPSControlFactory.CreateRPSComboBox<ACCYearEntityView>("b7f5cb0d-1c9e-48b3-8148-4f659018da9a","","",false, this);
 
            ACCTransactionsYOJN = RPSControlFactory.CreateRPSComboBox<ACCYearEntityView>("97ad0f69-4a93-4718-a50c-dde9e1334c82","","",false, this);
 
            CollectionInit params_ACCPeriods = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b2f78199-9bde-403a-bea7-9d64bd80f16e",CSSSelectorGrid="",XPathGrid=""};
            ACCPeriods = RPSControlFactory.RPSCreateCollectionWithGrid<ACCPeriodsCollectionEditor<ACCYearEntityView,ACCPeriodView>,ACCYearEntityView,ACCPeriodView>( params_ACCPeriods,this,Screen.ACCPeriodView);
 
            General = RPSControlFactory.CreateRPSSection<ACCYearEntityView>( "","ul li[rpsid='fb5568c6-1a8b-489d-8fe9-8e956f1bfcbd']","",this);
 
            Periodo = RPSControlFactory.CreateRPSSection<ACCYearEntityView>( "","ul li[rpsid='ed8c6174-a038-4d31-aafa-499830d94579']","",this);
 

        }
        public IRPSSaveButton<ACCYearEntityView> SaveButton { get; set; } 
        public IRPSButton<ACCYearEntityView> DeleteButton { get; set; } 
        public IRPSButton<ACCYearEntityView,ACCYearCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCYearEntityView,ACCYearCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ACCYearEntityView> CodYear { get; set; } 
        public IRPSTextBox<ACCYearEntityView> Description { get; set; } 
        public IRPSTextBox<ACCYearEntityView> DateFrom { get; set; } 
        public IRPSTextBox<ACCYearEntityView> DateTo { get; set; } 
        public IRPSTextBox<ACCYearEntityView> JournalLastUsedNumber { get; set; } 
        public IRPSTextBox<ACCYearEntityView> VATAPLastUsedNumber { get; set; } 
        public IRPSTextBox<ACCYearEntityView> VATARLastUsedNumber { get; set; } 
        public IRPSTextBox<ACCYearEntityView> JournalAnaUsedNumber { get; set; } 
        public IRPSComboBox<ACCYearEntityView> Status { get; set; } 
        public IRPSComboBox<ACCYearEntityView> ACCTransactionsISJN { get; set; } 
        public IRPSComboBox<ACCYearEntityView> ACCTransactionsPSJN { get; set; } 
        public IRPSComboBox<ACCYearEntityView> ACCTransactionsYCJN { get; set; } 
        public IRPSComboBox<ACCYearEntityView> ACCTransactionsYOJN { get; set; } 
        public ACCPeriodsCollectionEditor<ACCYearEntityView,ACCPeriodView> ACCPeriods { get; set; } 
        public IRPSSection<ACCYearEntityView> General { get; set; } 
        public IRPSSection<ACCYearEntityView> Periodo { get; set; } 
        public AccYear Screen { get; set; }
        public ACCYearEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCPeriodsCollectionEditor<ACCYearEntityView,ACCPeriodView>:RPSCollectionEditor<ACCYearEntityView,ACCPeriodView> where ACCYearEntityView : class, IView where ACCPeriodView : class, IView
    {
        public  ACCPeriodsGridView<ACCYearEntityView,ACCPeriodView> GridView {get;set;}
    }
    public partial class ACCPeriodsGridView <ACCYearEntityView,ACCPeriodView> :  RPSGridView<ACCYearEntityView,ACCPeriodView> where ACCYearEntityView : class, IView where ACCPeriodView : class, IView
    {
        public ACCPeriodsGridView(ACCYearEntityView currentView,ACCPeriodView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<ACCYearEntityView>("","#b2f78199-9bde-403a-bea7-9d64bd80f16e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            Blocked = RPSControlFactory.CreateRPSGridCheckBox<ACCYearEntityView>("","#b2f78199-9bde-403a-bea7-9d64bd80f16e .ag-row[role='row']@ROWINDEX [col-id='cBlocked']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ACCYearEntityView>("","#b2f78199-9bde-403a-bea7-9d64bd80f16e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCYearEntityView> DateFrom { get; set; } 
        public IRPSGridCheckbox<ACCYearEntityView> Blocked { get; set; } 
        public IRPSGridTextBox<ACCYearEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCPeriodView : View
    {
        public ACCPeriodView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCPeriodView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCPeriodView,ACCYearEntityView>( this,Screen.ACCYearEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCPeriodView,ACCYearEntityView>( this,Screen.ACCYearEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCPeriodView,ACCYearEntityView>( this,Screen.ACCYearEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ACCPeriodView>("0f352235-48f1-4eaf-a396-4f92221ce2c1","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<ACCPeriodView>("a800cb75-01ef-484b-9f98-ddcd039c9607","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ACCPeriodView>("92b0948a-6c3f-4069-9365-226f5c10d9df","","",false, this);
 

        }
        public IRPSButton<ACCPeriodView> DeleteButton { get; set; } 
        public IRPSButton<ACCPeriodView,ACCYearEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCPeriodView,ACCYearEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCPeriodView,ACCYearEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ACCPeriodView> DateFrom { get; set; } 
        public IRPSCheckbox<ACCPeriodView> Blocked { get; set; } 
        public IRPSTextBox<ACCPeriodView> Description { get; set; } 
        public AccYear Screen { get; set; }
        public ACCPeriodView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FirstVoucherChildDialogView : View
    {
        public FirstVoucherChildDialogView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingYear = RPSControlFactory.CreateRPSFormattedTextBox<FirstVoucherChildDialogView>("bb7e406b-bad7-46d4-a550-0e0dc8f514d7","","",true, this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<FirstVoucherChildDialogView>("054af5e9-2216-480e-846f-2a574d0d4865","","",true, this);
 

        }
        public IRPSTextBox<FirstVoucherChildDialogView> AccountingYear { get; set; } 
        public IRPSComboBox<FirstVoucherChildDialogView> IDACCTransactions { get; set; } 
        public AccYear Screen { get; set; }
        public FirstVoucherChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangesDatesChildDialogView : View
    {
        public ChangesDatesChildDialogView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<ChangesDatesChildDialogView>("dfdfa702-d545-47a7-b5b8-36f7ef41eb9e","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ChangesDatesChildDialogView>("8958962d-2efe-4efb-ad23-9d5778af7054","","",true, this);
 

        }
        public IRPSTextBox<ChangesDatesChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<ChangesDatesChildDialogView> DateTo { get; set; } 
        public AccYear Screen { get; set; }
        public ChangesDatesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewAccYearChilViewDialogView : View
    {
        public NewAccYearChilViewDialogView(AccYear screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodYear = RPSControlFactory.CreateRPSFormattedTextBox<NewAccYearChilViewDialogView>("98b91d82-91cb-42d9-b81d-e1b8ef648216","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NewAccYearChilViewDialogView>("09b51609-1b87-4c69-998d-daaaeeff01e5","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<NewAccYearChilViewDialogView>("706da260-4e44-4d00-a7be-6c02e210d8bc","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<NewAccYearChilViewDialogView>("4487ef9d-8b10-45e6-8fdc-636753a405e1","","",true, this);
 

        }
        public IRPSTextBox<NewAccYearChilViewDialogView> CodYear { get; set; } 
        public IRPSTextBox<NewAccYearChilViewDialogView> Description { get; set; } 
        public IRPSTextBox<NewAccYearChilViewDialogView> DateFrom { get; set; } 
        public IRPSTextBox<NewAccYearChilViewDialogView> DateTo { get; set; } 
        public AccYear Screen { get; set; }
        public NewAccYearChilViewDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Leasing
{
    //RPS VERSION 1.0.0.0
    public partial class Leasing:Screen
    {
        public Leasing():base()
        {
            this.URL = "generalledger.leasing";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LeasingCollectionView  = new LeasingCollectionView(this); 
            LeasingEntityView  = new LeasingEntityView(this); 
            LeasingDetailView  = new LeasingDetailView(this); 
            LeasingDimensionView  = new LeasingDimensionView(this); 
            OptionToBuyDialogView  = new OptionToBuyDialogView(this); 
            NotOptionToBuyDialogView  = new NotOptionToBuyDialogView(this); 
            LeasingCollectionView.InitializeControls(); 
            LeasingEntityView.InitializeControls(); 
            LeasingDetailView.InitializeControls(); 
            LeasingDimensionView.InitializeControls(); 
            OptionToBuyDialogView.InitializeControls(); 
            NotOptionToBuyDialogView.InitializeControls(); 
           
        }
      
            public LeasingCollectionView LeasingCollectionView {get; set; } 
            public LeasingEntityView LeasingEntityView {get; set; } 
            public LeasingDetailView LeasingDetailView {get; set; } 
            public LeasingDimensionView LeasingDimensionView {get; set; } 
            public OptionToBuyDialogView OptionToBuyDialogView {get; set; } 
            public NotOptionToBuyDialogView NotOptionToBuyDialogView {get; set; } 
    }
            
    public partial class LeasingCollectionView : View
    {
        public LeasingCollectionView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<LeasingCollectionView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "33cd7f2d-88d8-4f06-9bec-45b6da4f1a3c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<LeasingCollectionView,LeasingEntityView>( params_MainConsult,this,Screen.LeasingEntityView);
 

        }
        public IRPSButton<LeasingCollectionView,LeasingEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<LeasingCollectionView,LeasingEntityView> MainConsult { get; set; } 
        public Leasing Screen { get; set; }
        public LeasingCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LeasingEntityView : View
    {
        public LeasingEntityView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<LeasingEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<LeasingEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LeasingEntityView,LeasingCollectionView>( this,Screen.LeasingCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<LeasingEntityView,LeasingCollectionView>( this,Screen.LeasingCollectionView);
 
            CodLeasing = RPSControlFactory.CreateRPSTextBox<LeasingEntityView>("dbc662d8-424b-4374-892b-f79de231757a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<LeasingEntityView>("b3e8792b-3693-4c05-b686-38f20e7ab9c2","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<LeasingEntityView>("0988d9d6-e8ca-4dee-af25-a2277562271b","","",true, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("e8bad069-4a12-4b81-8f87-1732c63bbb3e","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("6ae139fb-e24d-4a4c-97a9-74a0d9ddd236","","",true, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<LeasingEntityView>("5a64791a-e92e-4895-95a3-b47b56053631","","",true, this);
 
            LeasingAmount = RPSControlFactory.CreateRPSFormattedTextBox<LeasingEntityView>("de9dc502-7516-47aa-82b5-7939cdcd4191","","",true, this);
 
            InterestPercentage = RPSControlFactory.CreateRPSFormattedTextBox<LeasingEntityView>("ea94a5db-e9c6-4124-abdc-3e26ffc93984","","",true, this);
 
            PercentageLabel = RPSControlFactory.CreateRPSTextBox<LeasingEntityView>("75e5cf29-b867-40ca-8096-1abd3f30ed36","","",false, this);
 
            Years = RPSControlFactory.CreateRPSFormattedTextBox<LeasingEntityView>("e4693048-f4d2-4821-8024-a8cc2da001e4","","",true, this);
 
            PeriodType = RPSControlFactory.CreateRPSEnumComboBox<LeasingEntityView>("0cfdb590-c257-45ce-8b94-0a408b4647e5","","",true, this);
 
            InstallmentType = RPSControlFactory.CreateRPSEnumComboBox<LeasingEntityView>("7349f8fb-1bc2-4e0b-9273-98b97c29bb84","","",true, this);
 
            ResidualValueType = RPSControlFactory.CreateRPSEnumComboBox<LeasingEntityView>("d93197ba-c3ed-4fff-826f-53445367fffe","","",true, this);
 
            ResidualValueFixAmount = RPSControlFactory.CreateRPSFormattedTextBox<LeasingEntityView>("0c1c70b3-bda5-4f93-be77-0be82615fd70","","",false, this);
 
            FinishDate = RPSControlFactory.CreateRPSTextBox<LeasingEntityView>("99c0230d-5823-4601-978c-e965ed8748c8","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("7743ea11-d5ea-474f-8c4d-4f872846ece8","","",true, this);
 
            IDAccountCreditorLongTerm = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("734b5905-b6eb-43b3-af30-24bd4480d6e4","","",true, this);
 
            IDAccountCreditorShortTerm = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("13e5f669-528f-4006-a20c-383654ec6f7c","","",true, this);
 
            IDAccountFinancialExp = RPSControlFactory.CreateRPSComboBox<LeasingEntityView>("3aa8e6c8-73e4-450e-9f52-a69237d04e31","","",true, this);
 
            ExecuteGenerateLeasingInstallmentsButton = RPSControlFactory.CreateRPSButton<LeasingEntityView>( "7628371e-1cf0-41d9-81da-5fdc4b062534","","",this);
 
            ExecuteSignContractButton = RPSControlFactory.CreateRPSButton<LeasingEntityView>( "a491f2a2-9ae3-4d1a-81e4-83612126e27a","","",this);
 
            OptionToBuyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<LeasingEntityView,OptionToBuyDialogView>("0f6c5cfc-70ef-4506-a072-0b187f6f834a","","", this,Screen.OptionToBuyDialogView);
 
            NotOptionToBuyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<LeasingEntityView,NotOptionToBuyDialogView>("42228f57-d256-40f9-8b3f-e28a8b606e6c","","", this,Screen.NotOptionToBuyDialogView);
 
            CollectionInit params_LeasingDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1730e0d4-26b6-4f9e-8295-45155b9ad212",CSSSelectorGrid="",XPathGrid=""};
            LeasingDetails = RPSControlFactory.RPSCreateCollectionWithGrid<LeasingDetailsCollectionEditor<LeasingEntityView,LeasingDetailView>,LeasingEntityView,LeasingDetailView>( params_LeasingDetails,this,Screen.LeasingDetailView);
 
            CollectionInit params_LeasingDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4833606a-70c0-4a39-b5f6-4e0d09b645f0",CSSSelectorGrid="",XPathGrid=""};
            LeasingDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<LeasingDimensionsCollectionEditor<LeasingEntityView,LeasingDetailView>,LeasingEntityView,LeasingDetailView>( params_LeasingDimensions,this,Screen.LeasingDetailView);
 
            Section = RPSControlFactory.CreateRPSSection<LeasingEntityView>( "","ul li[rpsid='87ae85f1-b83b-4cf2-9640-7197269d2d33']","",this);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<LeasingEntityView>( "","ul li[rpsid='a82a3f0b-2834-43a9-9e25-227d2a09371c']","",this);
 
            SectionAnalytic = RPSControlFactory.CreateRPSSection<LeasingEntityView>( "","ul li[rpsid='b6c06fa3-e698-4dfc-802f-c58e1d433bf1']","",this);
 

        }
        public IRPSSaveButton<LeasingEntityView> SaveButton { get; set; } 
        public IRPSButton<LeasingEntityView> DeleteButton { get; set; } 
        public IRPSButton<LeasingEntityView,LeasingCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LeasingEntityView,LeasingCollectionView> BackButton { get; set; } 
        public IRPSTextBox<LeasingEntityView> CodLeasing { get; set; } 
        public IRPSTextBox<LeasingEntityView> Description { get; set; } 
        public IRPSComboBox<LeasingEntityView> Status { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDFixedAsset { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<LeasingEntityView> StartDate { get; set; } 
        public IRPSTextBox<LeasingEntityView> LeasingAmount { get; set; } 
        public IRPSTextBox<LeasingEntityView> InterestPercentage { get; set; } 
        public IRPSTextBox<LeasingEntityView> PercentageLabel { get; set; } 
        public IRPSTextBox<LeasingEntityView> Years { get; set; } 
        public IRPSComboBox<LeasingEntityView> PeriodType { get; set; } 
        public IRPSComboBox<LeasingEntityView> InstallmentType { get; set; } 
        public IRPSComboBox<LeasingEntityView> ResidualValueType { get; set; } 
        public IRPSTextBox<LeasingEntityView> ResidualValueFixAmount { get; set; } 
        public IRPSTextBox<LeasingEntityView> FinishDate { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDVAT { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDAccountCreditorLongTerm { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDAccountCreditorShortTerm { get; set; } 
        public IRPSComboBox<LeasingEntityView> IDAccountFinancialExp { get; set; } 
        public IRPSButton<LeasingEntityView> ExecuteGenerateLeasingInstallmentsButton { get; set; } 
        public IRPSButton<LeasingEntityView> ExecuteSignContractButton { get; set; } 
        public IRPSButton<LeasingEntityView,OptionToBuyDialogView> OptionToBuyNavigationCommandButton { get; set; } 
        public IRPSButton<LeasingEntityView,NotOptionToBuyDialogView> NotOptionToBuyNavigationCommandButton { get; set; } 
        public LeasingDetailsCollectionEditor<LeasingEntityView,LeasingDetailView> LeasingDetails { get; set; } 
        public LeasingDimensionsCollectionEditor<LeasingEntityView,LeasingDetailView> LeasingDimensions { get; set; } 
        public IRPSSection<LeasingEntityView> Section { get; set; } 
        public IRPSSection<LeasingEntityView> SectionDetails { get; set; } 
        public IRPSSection<LeasingEntityView> SectionAnalytic { get; set; } 
        public Leasing Screen { get; set; }
        public LeasingEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LeasingDetailsCollectionEditor<LeasingEntityView,LeasingDetailView>:RPSCollectionEditor<LeasingEntityView,LeasingDetailView> where LeasingEntityView : class, IView where LeasingDetailView : class, IView
    {
        public  LeasingDetailsGridView<LeasingEntityView,LeasingDetailView> GridView {get;set;}
    }
    public partial class LeasingDetailsGridView <LeasingEntityView,LeasingDetailView> :  RPSGridView<LeasingEntityView,LeasingDetailView> where LeasingEntityView : class, IView where LeasingDetailView : class, IView
    {
        public LeasingDetailsGridView(LeasingEntityView currentView,LeasingDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InstallmentDate = RPSControlFactory.CreateRPSGridTextBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cInstallmentDate']","",true, this.CurrentView);
 
            LeasingDetailType = RPSControlFactory.CreateRPSGridEnumComboBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cLeasingDetailType']","",true, this.CurrentView);
 
            InstallmentAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cInstallmentAmount']","",true, this.CurrentView);
 
            InterestAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cInterestAmount']","",false, this.CurrentView);
 
            DepreciationAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cDepreciationAmount']","",true, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<LeasingEntityView>("","#1730e0d4-26b6-4f9e-8295-45155b9ad212 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<LeasingEntityView> InstallmentDate { get; set; } 
        public IRPSGridComboBox<LeasingEntityView> LeasingDetailType { get; set; } 
        public IRPSGridTextBox<LeasingEntityView> InstallmentAmount { get; set; } 
        public IRPSGridTextBox<LeasingEntityView> InterestAmount { get; set; } 
        public IRPSGridTextBox<LeasingEntityView> DepreciationAmount { get; set; } 
        public IRPSGridComboBox<LeasingEntityView> Status { get; set; } 
        public IRPSGridTextBox<LeasingEntityView> CodInvoice { get; set; } 
                     
    }
 
        public partial class LeasingDimensionsCollectionEditor<LeasingEntityView,LeasingDetailView>:RPSCollectionEditor<LeasingEntityView,LeasingDetailView> where LeasingEntityView : class, IView where LeasingDetailView : class, IView
    {
        public  LeasingDimensionsGridView<LeasingEntityView,LeasingDetailView> GridView {get;set;}
    }
    public partial class LeasingDimensionsGridView <LeasingEntityView,LeasingDetailView> :  RPSGridView<LeasingEntityView,LeasingDetailView> where LeasingEntityView : class, IView where LeasingDetailView : class, IView
    {
        public LeasingDimensionsGridView(LeasingEntityView currentView,LeasingDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Account = RPSControlFactory.CreateRPSGridEnumComboBox<LeasingEntityView>("","#4833606a-70c0-4a39-b5f6-4e0d09b645f0 .ag-row[role='row']@ROWINDEX [col-id='cAccount']","",true, this.CurrentView);
 
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<LeasingEntityView>("","#4833606a-70c0-4a39-b5f6-4e0d09b645f0 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<LeasingEntityView>("","#4833606a-70c0-4a39-b5f6-4e0d09b645f0 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<LeasingEntityView>("","#4833606a-70c0-4a39-b5f6-4e0d09b645f0 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<LeasingEntityView> Account { get; set; } 
        public IRPSGridComboBox<LeasingEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<LeasingEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<LeasingEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class LeasingDetailView : View
    {
        public LeasingDetailView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<LeasingDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LeasingDetailView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<LeasingDetailView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<LeasingDetailView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            InstallmentDate = RPSControlFactory.CreateRPSTextBox<LeasingDetailView>("73c9d424-51c6-4ac2-80ee-24ba6e6adfd2","","",true, this);
 
            InstallmentAmount = RPSControlFactory.CreateRPSFormattedTextBox<LeasingDetailView>("f555d3b9-905c-45b3-820f-2fa2036011ab","","",true, this);
 
            InterestAmount = RPSControlFactory.CreateRPSFormattedTextBox<LeasingDetailView>("2928264d-a6ce-4918-a728-8800345378ae","","",false, this);
 
            DepreciationAmount = RPSControlFactory.CreateRPSFormattedTextBox<LeasingDetailView>("6d6c4e4f-62dd-44e7-adbf-5ce636553a85","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<LeasingDetailView>("f3d4cce3-c614-429e-8817-6add315a9081","","",true, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<LeasingDetailView>("dd5e23bb-32d4-464a-ada9-7f9d5cd011e2","","",false, this);
 
            LeasingDetailType = RPSControlFactory.CreateRPSEnumComboBox<LeasingDetailView>("cdc5c3f0-3923-43b5-99f9-469df1b0061c","","",true, this);
 

        }
        public IRPSButton<LeasingDetailView> DeleteButton { get; set; } 
        public IRPSButton<LeasingDetailView,LeasingEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LeasingDetailView,LeasingEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<LeasingDetailView,LeasingEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<LeasingDetailView> InstallmentDate { get; set; } 
        public IRPSTextBox<LeasingDetailView> InstallmentAmount { get; set; } 
        public IRPSTextBox<LeasingDetailView> InterestAmount { get; set; } 
        public IRPSTextBox<LeasingDetailView> DepreciationAmount { get; set; } 
        public IRPSComboBox<LeasingDetailView> Status { get; set; } 
        public IRPSTextBox<LeasingDetailView> CodInvoice { get; set; } 
        public IRPSComboBox<LeasingDetailView> LeasingDetailType { get; set; } 
        public Leasing Screen { get; set; }
        public LeasingDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LeasingDimensionView : View
    {
        public LeasingDimensionView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<LeasingDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LeasingDimensionView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<LeasingDimensionView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<LeasingDimensionView,LeasingEntityView>( this,Screen.LeasingEntityView);
 
            Account = RPSControlFactory.CreateRPSEnumComboBox<LeasingDimensionView>("02f98716-8253-4d3e-82d1-7241a423f226","","",true, this);
 
            IDAccountCreditorLongTerm = RPSControlFactory.CreateRPSComboBox<LeasingDimensionView>("da647f6a-7ece-46f3-b53a-35c9394ffce9","","",true, this);
 
            IDAccountCreditorShortTerm = RPSControlFactory.CreateRPSComboBox<LeasingDimensionView>("d16f86f0-d269-482e-97f4-29ce6a49645a","","",true, this);
 
            IDAccountFinancialExp = RPSControlFactory.CreateRPSComboBox<LeasingDimensionView>("3fa23692-13d5-4cf6-a038-969f5a7154b9","","",true, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<LeasingDimensionView>("92c5a9f9-e6b3-46ea-aee4-82da91a6a568","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<LeasingDimensionView>("e5bc6c8a-143b-493b-a1c7-ed855e8e36f2","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<LeasingDimensionView>("aa40583e-6f7f-489a-9409-0ddf7a567cf2","","",true, this);
 

        }
        public IRPSButton<LeasingDimensionView> DeleteButton { get; set; } 
        public IRPSButton<LeasingDimensionView,LeasingEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LeasingDimensionView,LeasingEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<LeasingDimensionView,LeasingEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<LeasingDimensionView> Account { get; set; } 
        public IRPSComboBox<LeasingDimensionView> IDAccountCreditorLongTerm { get; set; } 
        public IRPSComboBox<LeasingDimensionView> IDAccountCreditorShortTerm { get; set; } 
        public IRPSComboBox<LeasingDimensionView> IDAccountFinancialExp { get; set; } 
        public IRPSComboBox<LeasingDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<LeasingDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<LeasingDimensionView> Percentage { get; set; } 
        public Leasing Screen { get; set; }
        public LeasingDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OptionToBuyDialogView : View
    {
        public OptionToBuyDialogView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InstalmentDate = RPSControlFactory.CreateRPSTextBox<OptionToBuyDialogView>("a9e310da-09a0-473d-a105-817421e2332e","","",true, this);
 
            InstallmentAmount = RPSControlFactory.CreateRPSFormattedTextBox<OptionToBuyDialogView>("a57cdfa3-d402-4e88-8ba9-32b65a15b95b","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<OptionToBuyDialogView>("8e11e8c6-6811-438a-9bae-24b356550d41","","",true, this);
 
            InvoiceNumber = RPSControlFactory.CreateRPSTextBox<OptionToBuyDialogView>("dda36955-f16f-4ea9-8048-09086cabb77d","","",true, this);
 

        }
        public IRPSTextBox<OptionToBuyDialogView> InstalmentDate { get; set; } 
        public IRPSTextBox<OptionToBuyDialogView> InstallmentAmount { get; set; } 
        public IRPSTextBox<OptionToBuyDialogView> AccountingDate { get; set; } 
        public IRPSTextBox<OptionToBuyDialogView> InvoiceNumber { get; set; } 
        public Leasing Screen { get; set; }
        public OptionToBuyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NotOptionToBuyDialogView : View
    {
        public NotOptionToBuyDialogView(Leasing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InstalmentDate = RPSControlFactory.CreateRPSTextBox<NotOptionToBuyDialogView>("0a7ade4d-fa52-472e-ad5e-07a4ea4a6d61","","",true, this);
 
            InstallmentAmount = RPSControlFactory.CreateRPSFormattedTextBox<NotOptionToBuyDialogView>("4ee2c08d-827d-469d-9c57-4835a880d318","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<NotOptionToBuyDialogView>("a6fe2e02-fd15-4f72-bb76-7dffe18efafd","","",true, this);
 

        }
        public IRPSTextBox<NotOptionToBuyDialogView> InstalmentDate { get; set; } 
        public IRPSTextBox<NotOptionToBuyDialogView> InstallmentAmount { get; set; } 
        public IRPSTextBox<NotOptionToBuyDialogView> AccountingDate { get; set; } 
        public Leasing Screen { get; set; }
        public NotOptionToBuyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
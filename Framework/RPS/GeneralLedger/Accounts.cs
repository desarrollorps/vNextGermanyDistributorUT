    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Accounts
{
    //RPS VERSION 1.0.0.0
    public partial class Accounts:Screen
    {
        public Accounts():base()
        {
            this.URL = "generalledger.accounts";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountCollectionView  = new AccountCollectionView(this); 
            AccountEntityView  = new AccountEntityView(this); 
            AccountDetailClusterView  = new AccountDetailClusterView(this); 
            BalanceDetailView  = new BalanceDetailView(this); 
            AutoReclassifyView  = new AutoReclassifyView(this); 
            AccDimRelationView  = new AccDimRelationView(this); 
            AccDimDistributionView  = new AccDimDistributionView(this); 
            ImportAccountDialogView  = new ImportAccountDialogView(this); 
            ImportAccountAnalyticDialogView  = new ImportAccountAnalyticDialogView(this); 
            ImportAnalyticDialogView  = new ImportAnalyticDialogView(this); 
            AccountCollectionView.InitializeControls(); 
            AccountEntityView.InitializeControls(); 
            AccountDetailClusterView.InitializeControls(); 
            BalanceDetailView.InitializeControls(); 
            AutoReclassifyView.InitializeControls(); 
            AccDimRelationView.InitializeControls(); 
            AccDimDistributionView.InitializeControls(); 
            ImportAccountDialogView.InitializeControls(); 
            ImportAccountAnalyticDialogView.InitializeControls(); 
            ImportAnalyticDialogView.InitializeControls(); 
           
        }
      
            public AccountCollectionView AccountCollectionView {get; set; } 
            public AccountEntityView AccountEntityView {get; set; } 
            public AccountDetailClusterView AccountDetailClusterView {get; set; } 
            public BalanceDetailView BalanceDetailView {get; set; } 
            public AutoReclassifyView AutoReclassifyView {get; set; } 
            public AccDimRelationView AccDimRelationView {get; set; } 
            public AccDimDistributionView AccDimDistributionView {get; set; } 
            public ImportAccountDialogView ImportAccountDialogView {get; set; } 
            public ImportAccountAnalyticDialogView ImportAccountAnalyticDialogView {get; set; } 
            public ImportAnalyticDialogView ImportAnalyticDialogView {get; set; } 
    }
            
    public partial class AccountCollectionView : View
    {
        public AccountCollectionView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AccountCollectionView,AccountEntityView>( this,Screen.AccountEntityView);
 
            ImportAccountNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountCollectionView,ImportAccountDialogView>("5c51b5bf-8927-4f37-927a-0cb1870ec0b4","","", this,Screen.ImportAccountDialogView);
 
            ImportAccountAnalyticNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountCollectionView,ImportAccountAnalyticDialogView>("60d5e805-67a8-46e6-88cc-7ca06909eb28","","", this,Screen.ImportAccountAnalyticDialogView);
 
            ImportAnalyticNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountCollectionView,ImportAnalyticDialogView>("fcee16c8-f3e3-4aeb-8641-1a831945217e","","", this,Screen.ImportAnalyticDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bf5b5ea4-778f-40ca-b5d8-12b78343a755",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AccountCollectionView,AccountEntityView>( params_MainConsult,this,Screen.AccountEntityView);
 

        }
        public IRPSButton<AccountCollectionView,AccountEntityView> NewButton { get; set; } 
        public IRPSButton<AccountCollectionView,ImportAccountDialogView> ImportAccountNavigationCommandButton { get; set; } 
        public IRPSButton<AccountCollectionView,ImportAccountAnalyticDialogView> ImportAccountAnalyticNavigationCommandButton { get; set; } 
        public IRPSButton<AccountCollectionView,ImportAnalyticDialogView> ImportAnalyticNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<AccountCollectionView,AccountEntityView> MainConsult { get; set; } 
        public Accounts Screen { get; set; }
        public AccountCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccountEntityView : View
    {
        public AccountEntityView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AccountEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccountEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccountEntityView,AccountCollectionView>( this,Screen.AccountCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccountEntityView,AccountCollectionView>( this,Screen.AccountCollectionView);
 
            CodAccount = RPSControlFactory.CreateRPSTextBox<AccountEntityView>("cf13b27b-21ec-4a40-9b9b-341017060f62","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccountEntityView>("0e112968-340c-4d69-83d6-d11c55d91e5a","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<AccountEntityView>("3e450305-bf5a-42e3-8d8b-7e0c0e206f66","","",true, this);
 
            BlockedInput = RPSControlFactory.CreateRPSCheckBox<AccountEntityView>("13051b40-4ce5-4b25-8c52-9c6e7e98d00f","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<AccountEntityView>("31851c36-28c3-48b4-ae5b-1f9b48d8117b","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<AccountEntityView>("ba06d953-fc12-4183-9ef5-bda648d932d1","","",true, this);
 
            IDAccountOffset = RPSControlFactory.CreateRPSComboBox<AccountEntityView>("bb7d45f7-fed8-4bd9-81e9-e1f2527938f3","","",false, this);
 
            IDAccountReturn = RPSControlFactory.CreateRPSComboBox<AccountEntityView>("718aba2a-4928-4f81-8897-a2a0622d6e01","","",false, this);
 
            IsCost = RPSControlFactory.CreateRPSCheckBox<AccountEntityView>("29d95c47-7b24-45b3-b2d1-5f9a61cfdea4","","",false, this);
 
            AccGroup = RPSControlFactory.CreateRPSCheckBox<AccountEntityView>("3fc5ae82-2341-4035-b115-da8628f4032a","","",true, this);
 
            CompanyGR = RPSControlFactory.CreateRPSComboBox<AccountEntityView>("a647f18a-cba3-41ea-bda7-688b7954ed58","","",false, this);
 
            Equity = RPSControlFactory.CreateRPSCheckBox<AccountEntityView>("e970a766-e409-4153-9c65-1de5b217b255","","",true, this);
 
            CollectionInit params_AccDimRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8180ae7b-7e40-4db5-8730-debe06ed78da",CSSSelectorGrid="",XPathGrid=""};
            AccDimRelations = RPSControlFactory.RPSCreateCollectionWithGrid<AccDimRelationsCollectionEditor<AccountEntityView,AccDimRelationView>,AccountEntityView,AccDimRelationView>( params_AccDimRelations,this,Screen.AccDimRelationView);
 
            CollectionInit params_AutoReclassifys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="974085cf-55c1-4128-98bf-2ce47db70b49",CSSSelectorGrid="",XPathGrid=""};
            AutoReclassifys = RPSControlFactory.RPSCreateCollectionWithGrid<AutoReclassifysCollectionEditor<AccountEntityView,AccDimRelationView>,AccountEntityView,AccDimRelationView>( params_AutoReclassifys,this,Screen.AccDimRelationView);
 
            CollectionInit params_BalanceDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f1ef2a19-2511-4577-897f-c3af093ab0c8",CSSSelectorGrid="",XPathGrid=""};
            BalanceDetails = RPSControlFactory.RPSCreateCollectionWithGrid<BalanceDetailsCollectionEditor<AccountEntityView,AccDimRelationView>,AccountEntityView,AccDimRelationView>( params_BalanceDetails,this,Screen.AccDimRelationView);
 
            CollectionInit params_AccountClusterDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3486319a-03b6-4c66-bd50-7ada0bacff49",CSSSelectorGrid="",XPathGrid=""};
            AccountClusterDetails = RPSControlFactory.RPSCreateCollectionWithGrid<AccountClusterDetailsCollectionEditor<AccountEntityView,AccDimRelationView>,AccountEntityView,AccDimRelationView>( params_AccountClusterDetails,this,Screen.AccDimRelationView);
 
            General = RPSControlFactory.CreateRPSSection<AccountEntityView>( "","ul li[rpsid='45237471-4800-4327-8d15-5165bd0e9c90']","",this);
 
            SectionDimRelations = RPSControlFactory.CreateRPSSection<AccountEntityView>( "","ul li[rpsid='1fc22d1f-657b-4cae-9c37-183415a2d7c0']","",this);
 
            Reclasification = RPSControlFactory.CreateRPSSection<AccountEntityView>( "","ul li[rpsid='256f1ae2-fbcf-471e-97ef-cf103885c3c9']","",this);
 
            Consolidationparameters = RPSControlFactory.CreateRPSSection<AccountEntityView>( "","ul li[rpsid='5a99ffcd-df61-443c-bdb4-8ad5cb9b1a34']","",this);
 
            Clusters = RPSControlFactory.CreateRPSSection<AccountEntityView>( "","ul li[rpsid='ed69fc81-ec78-4690-b722-90f9a08482c7']","",this);
 

        }
        public IRPSSaveButton<AccountEntityView> SaveButton { get; set; } 
        public IRPSButton<AccountEntityView> DeleteButton { get; set; } 
        public IRPSButton<AccountEntityView,AccountCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccountEntityView,AccountCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AccountEntityView> CodAccount { get; set; } 
        public IRPSTextBox<AccountEntityView> Description { get; set; } 
        public IRPSCheckbox<AccountEntityView> Blocked { get; set; } 
        public IRPSCheckbox<AccountEntityView> BlockedInput { get; set; } 
        public IRPSComboBox<AccountEntityView> Type { get; set; } 
        public IRPSComboBox<AccountEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<AccountEntityView> IDAccountOffset { get; set; } 
        public IRPSComboBox<AccountEntityView> IDAccountReturn { get; set; } 
        public IRPSCheckbox<AccountEntityView> IsCost { get; set; } 
        public IRPSCheckbox<AccountEntityView> AccGroup { get; set; } 
        public IRPSComboBox<AccountEntityView> CompanyGR { get; set; } 
        public IRPSCheckbox<AccountEntityView> Equity { get; set; } 
        public AccDimRelationsCollectionEditor<AccountEntityView,AccDimRelationView> AccDimRelations { get; set; } 
        public AutoReclassifysCollectionEditor<AccountEntityView,AccDimRelationView> AutoReclassifys { get; set; } 
        public BalanceDetailsCollectionEditor<AccountEntityView,AccDimRelationView> BalanceDetails { get; set; } 
        public AccountClusterDetailsCollectionEditor<AccountEntityView,AccDimRelationView> AccountClusterDetails { get; set; } 
        public IRPSSection<AccountEntityView> General { get; set; } 
        public IRPSSection<AccountEntityView> SectionDimRelations { get; set; } 
        public IRPSSection<AccountEntityView> Reclasification { get; set; } 
        public IRPSSection<AccountEntityView> Consolidationparameters { get; set; } 
        public IRPSSection<AccountEntityView> Clusters { get; set; } 
        public Accounts Screen { get; set; }
        public AccountEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccDimRelationsCollectionEditor<AccountEntityView,AccDimRelationView>:RPSCollectionEditor<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public  AccDimRelationsGridView<AccountEntityView,AccDimRelationView> GridView {get;set;}
    }
    public partial class AccDimRelationsGridView <AccountEntityView,AccDimRelationView> :  RPSGridView<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public AccDimRelationsGridView(AccountEntityView currentView,AccDimRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#8180ae7b-7e40-4db5-8730-debe06ed78da .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            HasAccDimDistributions = RPSControlFactory.CreateRPSGridTextBox<AccountEntityView>("","#8180ae7b-7e40-4db5-8730-debe06ed78da .ag-row[role='row']@ROWINDEX [col-id='cHasAccDimDistributions']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccountEntityView> IDDimension { get; set; } 
        public IRPSGridTextBox<AccountEntityView> HasAccDimDistributions { get; set; } 
                     
    }
 
        public partial class AutoReclassifysCollectionEditor<AccountEntityView,AccDimRelationView>:RPSCollectionEditor<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public  AutoReclassifysGridView<AccountEntityView,AccDimRelationView> GridView {get;set;}
    }
    public partial class AutoReclassifysGridView <AccountEntityView,AccDimRelationView> :  RPSGridView<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public AutoReclassifysGridView(AccountEntityView currentView,AccDimRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",false, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            IDAccNewDebit = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cIDAccNewDebit']","",false, this.CurrentView);
 
            IDAccNewCredit = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#974085cf-55c1-4128-98bf-2ce47db70b49 .ag-row[role='row']@ROWINDEX [col-id='cIDAccNewCredit']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccountEntityView> SignType { get; set; } 
        public IRPSGridComboBox<AccountEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<AccountEntityView> IDDimValue { get; set; } 
        public IRPSGridComboBox<AccountEntityView> Type { get; set; } 
        public IRPSGridComboBox<AccountEntityView> IDAccNewDebit { get; set; } 
        public IRPSGridComboBox<AccountEntityView> IDAccNewCredit { get; set; } 
                     
    }
 
        public partial class BalanceDetailsCollectionEditor<AccountEntityView,AccDimRelationView>:RPSCollectionEditor<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public  BalanceDetailsGridView<AccountEntityView,AccDimRelationView> GridView {get;set;}
    }
    public partial class BalanceDetailsGridView <AccountEntityView,AccDimRelationView> :  RPSGridView<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public BalanceDetailsGridView(AccountEntityView currentView,AccDimRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<AccountEntityView>("","#f1ef2a19-2511-4577-897f-c3af093ab0c8 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AccountEntityView>("","#f1ef2a19-2511-4577-897f-c3af093ab0c8 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<AccountEntityView>("","#f1ef2a19-2511-4577-897f-c3af093ab0c8 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccountEntityView> Date { get; set; } 
        public IRPSGridTextBox<AccountEntityView> Amount { get; set; } 
        public IRPSGridComboBox<AccountEntityView> SignType { get; set; } 
                     
    }
 
        public partial class AccountClusterDetailsCollectionEditor<AccountEntityView,AccDimRelationView>:RPSCollectionEditor<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public  AccountClusterDetailsGridView<AccountEntityView,AccDimRelationView> GridView {get;set;}
    }
    public partial class AccountClusterDetailsGridView <AccountEntityView,AccDimRelationView> :  RPSGridView<AccountEntityView,AccDimRelationView> where AccountEntityView : class, IView where AccDimRelationView : class, IView
    {
        public AccountClusterDetailsGridView(AccountEntityView currentView,AccDimRelationView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccountCluster = RPSControlFactory.CreateRPSGridComboBox<AccountEntityView>("","#3486319a-03b6-4c66-bd50-7ada0bacff49 .ag-row[role='row']@ROWINDEX [col-id='cIDAccountCluster']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccountEntityView> IDAccountCluster { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccountDetailClusterView : View
    {
        public AccountDetailClusterView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccountDetailClusterView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccountDetailClusterView,AccountEntityView>( this,Screen.AccountEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccountDetailClusterView,AccountEntityView>( this,Screen.AccountEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccountDetailClusterView,AccountEntityView>( this,Screen.AccountEntityView);
 
            IDAccountCluster = RPSControlFactory.CreateRPSComboBox<AccountDetailClusterView>("4ea73d6a-7990-4e87-bfbb-7e5012bd7895","","",true, this);
 

        }
        public IRPSButton<AccountDetailClusterView> DeleteButton { get; set; } 
        public IRPSButton<AccountDetailClusterView,AccountEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccountDetailClusterView,AccountEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AccountDetailClusterView,AccountEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AccountDetailClusterView> IDAccountCluster { get; set; } 
        public Accounts Screen { get; set; }
        public AccountDetailClusterView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BalanceDetailView : View
    {
        public BalanceDetailView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BalanceDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BalanceDetailView,AccountEntityView>( this,Screen.AccountEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BalanceDetailView,AccountEntityView>( this,Screen.AccountEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BalanceDetailView,AccountEntityView>( this,Screen.AccountEntityView);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<BalanceDetailView>("c187c645-3ca6-4b6e-af7a-94b889805b15","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<BalanceDetailView>("72f9565c-337f-4b69-9496-4e4c025d2dba","","",true, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<BalanceDetailView>("2b97824e-b38d-4267-81e9-ac019c793a34","","",true, this);
 

        }
        public IRPSButton<BalanceDetailView> DeleteButton { get; set; } 
        public IRPSButton<BalanceDetailView,AccountEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BalanceDetailView,AccountEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BalanceDetailView,AccountEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<BalanceDetailView> Amount { get; set; } 
        public IRPSTextBox<BalanceDetailView> Date { get; set; } 
        public IRPSComboBox<BalanceDetailView> SignType { get; set; } 
        public Accounts Screen { get; set; }
        public BalanceDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AutoReclassifyView : View
    {
        public AutoReclassifyView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AutoReclassifyView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AutoReclassifyView,AccountEntityView>( this,Screen.AccountEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AutoReclassifyView,AccountEntityView>( this,Screen.AccountEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AutoReclassifyView,AccountEntityView>( this,Screen.AccountEntityView);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<AutoReclassifyView>("c51ae3f5-4714-4c2b-9eb5-83448fb6072b","","",true, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<AutoReclassifyView>("5c1297a1-e876-40a5-a98a-95a0dcbb0a3a","","",false, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<AutoReclassifyView>("69458eb9-4e2a-4f93-8e4d-686ab68b8ee7","","",false, this);
 
            ApplyWhenManualEntry = RPSControlFactory.CreateRPSCheckBox<AutoReclassifyView>("c38a9205-6bd1-4072-a4be-25cc7a27a71b","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<AutoReclassifyView>("0a81bfb2-7a62-4288-9831-d5907d32eb64","","",true, this);
 
            AnalyticAccFrom = RPSControlFactory.CreateRPSCheckBox<AutoReclassifyView>("9e973685-8bfd-4bd4-9ab9-b77e926f1f2d","","",true, this);
 
            ReclassifyPercentage = RPSControlFactory.CreateRPSFormattedTextBox<AutoReclassifyView>("0499fd5a-3b48-4d54-80ab-74f76a03527c","","",true, this);
 
            IDAccNewDebit = RPSControlFactory.CreateRPSComboBox<AutoReclassifyView>("00b56a83-f319-4224-b994-8a783feecff0","","",false, this);
 
            IDAccNewCredit = RPSControlFactory.CreateRPSComboBox<AutoReclassifyView>("3434f3f8-ddf8-4953-9d47-910774a1f4e5","","",false, this);
 

        }
        public IRPSButton<AutoReclassifyView> DeleteButton { get; set; } 
        public IRPSButton<AutoReclassifyView,AccountEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AutoReclassifyView,AccountEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AutoReclassifyView,AccountEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AutoReclassifyView> SignType { get; set; } 
        public IRPSComboBox<AutoReclassifyView> IDDimension { get; set; } 
        public IRPSComboBox<AutoReclassifyView> IDDimValue { get; set; } 
        public IRPSCheckbox<AutoReclassifyView> ApplyWhenManualEntry { get; set; } 
        public IRPSComboBox<AutoReclassifyView> Type { get; set; } 
        public IRPSCheckbox<AutoReclassifyView> AnalyticAccFrom { get; set; } 
        public IRPSTextBox<AutoReclassifyView> ReclassifyPercentage { get; set; } 
        public IRPSComboBox<AutoReclassifyView> IDAccNewDebit { get; set; } 
        public IRPSComboBox<AutoReclassifyView> IDAccNewCredit { get; set; } 
        public Accounts Screen { get; set; }
        public AutoReclassifyView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccDimRelationView : View
    {
        public AccDimRelationView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccDimRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccDimRelationView,AccountEntityView>( this,Screen.AccountEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccDimRelationView,AccountEntityView>( this,Screen.AccountEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccDimRelationView,AccountEntityView>( this,Screen.AccountEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<AccDimRelationView>("b9ca4927-dc22-4811-a4cd-42764947967a","","",true, this);
 
            CollectionInit params_AccDimDistributions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6a1755e-6827-4dfe-855a-c0c792d4f8b3",CSSSelectorGrid="",XPathGrid=""};
            AccDimDistributions = RPSControlFactory.RPSCreateCollectionWithGrid<AccDimDistributionsCollectionEditor<AccDimRelationView,AccDimDistributionView>,AccDimRelationView,AccDimDistributionView>( params_AccDimDistributions,this,Screen.AccDimDistributionView);
 

        }
        public IRPSButton<AccDimRelationView> DeleteButton { get; set; } 
        public IRPSButton<AccDimRelationView,AccountEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccDimRelationView,AccountEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<AccDimRelationView,AccountEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<AccDimRelationView> IDDimension { get; set; } 
        public AccDimDistributionsCollectionEditor<AccDimRelationView,AccDimDistributionView> AccDimDistributions { get; set; } 
        public Accounts Screen { get; set; }
        public AccDimRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccDimDistributionsCollectionEditor<AccDimRelationView,AccDimDistributionView>:RPSCollectionEditor<AccDimRelationView,AccDimDistributionView> where AccDimRelationView : class, IView where AccDimDistributionView : class, IView
    {
        public  AccDimDistributionsGridView<AccDimRelationView,AccDimDistributionView> GridView {get;set;}
    }
    public partial class AccDimDistributionsGridView <AccDimRelationView,AccDimDistributionView> :  RPSGridView<AccDimRelationView,AccDimDistributionView> where AccDimRelationView : class, IView where AccDimDistributionView : class, IView
    {
        public AccDimDistributionsGridView(AccDimRelationView currentView,AccDimDistributionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AccDimRelationView>("","#c6a1755e-6827-4dfe-855a-c0c792d4f8b3 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AccDimRelationView>("","#c6a1755e-6827-4dfe-855a-c0c792d4f8b3 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccDimRelationView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AccDimRelationView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccDimDistributionView : View
    {
        public AccDimDistributionView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccDimDistributionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccDimDistributionView,AccDimRelationView>( this,Screen.AccDimRelationView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccDimDistributionView,AccDimRelationView>( this,Screen.AccDimRelationView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<AccDimDistributionView,AccDimRelationView>( this,Screen.AccDimRelationView);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<AccDimDistributionView>("9a4bafbe-d0ca-4c0a-92ee-43c38fb75732","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<AccDimDistributionView>("27a7252a-d6f4-497c-90b7-2a1446fc01e7","","",true, this);
 

        }
        public IRPSButton<AccDimDistributionView> DeleteButton { get; set; } 
        public IRPSButton<AccDimDistributionView,AccDimRelationView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccDimDistributionView,AccDimRelationView> BackButton { get; set; } 
        public IRPSAcceptButton<AccDimDistributionView,AccDimRelationView> AcceptButton { get; set; } 
        public IRPSComboBox<AccDimDistributionView> IDDimValue { get; set; } 
        public IRPSTextBox<AccDimDistributionView> Percentage { get; set; } 
        public Accounts Screen { get; set; }
        public AccDimDistributionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportAccountDialogView : View
    {
        public ImportAccountDialogView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Accounts Screen { get; set; }
        public ImportAccountDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportAccountAnalyticDialogView : View
    {
        public ImportAccountAnalyticDialogView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Accounts Screen { get; set; }
        public ImportAccountAnalyticDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportAnalyticDialogView : View
    {
        public ImportAnalyticDialogView(Accounts screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Accounts Screen { get; set; }
        public ImportAnalyticDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
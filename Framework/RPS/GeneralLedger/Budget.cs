    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Budget
{
    //RPS VERSION 1.0.0.0
    public partial class Budget:Screen
    {
        public Budget():base()
        {
            this.URL = "generalledger.budget";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BudgetCollectionView  = new BudgetCollectionView(this); 
            BudgetEntityView  = new BudgetEntityView(this); 
            BudgetValueView  = new BudgetValueView(this); 
            CopyDialogView  = new CopyDialogView(this); 
            DistributeChildDialogView  = new DistributeChildDialogView(this); 
            BudgetValueDetailView  = new BudgetValueDetailView(this); 
            BudgetCollectionView.InitializeControls(); 
            BudgetEntityView.InitializeControls(); 
            BudgetValueView.InitializeControls(); 
            CopyDialogView.InitializeControls(); 
            DistributeChildDialogView.InitializeControls(); 
            BudgetValueDetailView.InitializeControls(); 
           
        }
      
            public BudgetCollectionView BudgetCollectionView {get; set; } 
            public BudgetEntityView BudgetEntityView {get; set; } 
            public BudgetValueView BudgetValueView {get; set; } 
            public CopyDialogView CopyDialogView {get; set; } 
            public DistributeChildDialogView DistributeChildDialogView {get; set; } 
            public BudgetValueDetailView BudgetValueDetailView {get; set; } 
    }
            
    public partial class BudgetCollectionView : View
    {
        public BudgetCollectionView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BudgetCollectionView,BudgetEntityView>( this,Screen.BudgetEntityView);
 
            CopyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BudgetCollectionView,CopyDialogView>("a648253b-31e9-4af7-8935-fc7c9996440f","","", this,Screen.CopyDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7fc66a9a-7946-4df4-872c-7d6712fadf31",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BudgetCollectionView,BudgetEntityView>( params_MainConsult,this,Screen.BudgetEntityView);
 

        }
        public IRPSButton<BudgetCollectionView,BudgetEntityView> NewButton { get; set; } 
        public IRPSButton<BudgetCollectionView,CopyDialogView> CopyNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<BudgetCollectionView,BudgetEntityView> MainConsult { get; set; } 
        public Budget Screen { get; set; }
        public BudgetCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BudgetEntityView : View
    {
        public BudgetEntityView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BudgetEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BudgetEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BudgetEntityView,BudgetCollectionView>( this,Screen.BudgetCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BudgetEntityView,BudgetCollectionView>( this,Screen.BudgetCollectionView);
 
            CodBudget = RPSControlFactory.CreateRPSTextBox<BudgetEntityView>("4f6af369-241a-4d65-a267-01f5e762f921","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BudgetEntityView>("e1a4f00f-79ec-4831-9982-6d2f5f7047a9","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<BudgetEntityView>("a7e64f73-6b26-4a2a-9ad5-71ce339a0bda","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<BudgetEntityView>("7c6ffbf7-9fcb-40aa-ab90-1f553adf6fe2","","",true, this);
 
            DistributeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BudgetEntityView,DistributeChildDialogView>("b7efbcc0-dd23-4cbc-bb36-fa5f1d1fa38d","","", this,Screen.DistributeChildDialogView);
 
            CollectionInit params_BudgetValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe06ce94-a626-4106-bead-683ddf0daa16",CSSSelectorGrid="",XPathGrid=""};
            BudgetValues = RPSControlFactory.RPSCreateCollectionWithGrid<BudgetValuesCollectionEditor<BudgetEntityView,BudgetValueView>,BudgetEntityView,BudgetValueView>( params_BudgetValues,this,Screen.BudgetValueView);
 
            SectionValues = RPSControlFactory.CreateRPSSection<BudgetEntityView>( "","ul li[rpsid='6dc5f298-b446-443d-be80-cd5c583e5463']","",this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<BudgetEntityView>( "","ul li[rpsid='50991532-f106-4402-a0a3-d40ca0b62528']","",this);
 

        }
        public IRPSSaveButton<BudgetEntityView> SaveButton { get; set; } 
        public IRPSButton<BudgetEntityView> DeleteButton { get; set; } 
        public IRPSButton<BudgetEntityView,BudgetCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BudgetEntityView,BudgetCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BudgetEntityView> CodBudget { get; set; } 
        public IRPSTextBox<BudgetEntityView> Description { get; set; } 
        public IRPSComboBox<BudgetEntityView> IDACCYear { get; set; } 
        public IRPSComboBox<BudgetEntityView> Status { get; set; } 
        public IRPSButton<BudgetEntityView,DistributeChildDialogView> DistributeChildNavigationCommandButton { get; set; } 
        public BudgetValuesCollectionEditor<BudgetEntityView,BudgetValueView> BudgetValues { get; set; } 
        public IRPSSection<BudgetEntityView> SectionValues { get; set; } 
        public IRPSSection<BudgetEntityView> SectionGeneral { get; set; } 
        public Budget Screen { get; set; }
        public BudgetEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BudgetValuesCollectionEditor<BudgetEntityView,BudgetValueView>:RPSCollectionEditor<BudgetEntityView,BudgetValueView> where BudgetEntityView : class, IView where BudgetValueView : class, IView
    {
        public  BudgetValuesGridView<BudgetEntityView,BudgetValueView> GridView {get;set;}
    }
    public partial class BudgetValuesGridView <BudgetEntityView,BudgetValueView> :  RPSGridView<BudgetEntityView,BudgetValueView> where BudgetEntityView : class, IView where BudgetValueView : class, IView
    {
        public BudgetValuesGridView(BudgetEntityView currentView,BudgetValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<BudgetEntityView>("","#fe06ce94-a626-4106-bead-683ddf0daa16 .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",true, this.CurrentView);
 
            IDACCPeriod = RPSControlFactory.CreateRPSGridComboBox<BudgetEntityView>("","#fe06ce94-a626-4106-bead-683ddf0daa16 .ag-row[role='row']@ROWINDEX [col-id='cIDACCPeriod']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<BudgetEntityView>("","#fe06ce94-a626-4106-bead-683ddf0daa16 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            bHasAnalytic = RPSControlFactory.CreateRPSGridCheckBox<BudgetEntityView>("","#fe06ce94-a626-4106-bead-683ddf0daa16 .ag-row[role='row']@ROWINDEX [col-id='cbHasAnalytic']","",false, this.CurrentView);
 
            bBreakdown = RPSControlFactory.CreateRPSGridCheckBox<BudgetEntityView>("","#fe06ce94-a626-4106-bead-683ddf0daa16 .ag-row[role='row']@ROWINDEX [col-id='cbBreakdown']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<BudgetEntityView> IDAccount { get; set; } 
        public IRPSGridComboBox<BudgetEntityView> IDACCPeriod { get; set; } 
        public IRPSGridTextBox<BudgetEntityView> Amount { get; set; } 
        public IRPSGridCheckbox<BudgetEntityView> bHasAnalytic { get; set; } 
        public IRPSGridCheckbox<BudgetEntityView> bBreakdown { get; set; } 
                     
    }
 
    }
  
            
    public partial class BudgetValueView : View
    {
        public BudgetValueView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BudgetValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BudgetValueView,BudgetEntityView>( this,Screen.BudgetEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BudgetValueView,BudgetEntityView>( this,Screen.BudgetEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BudgetValueView,BudgetEntityView>( this,Screen.BudgetEntityView);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<BudgetValueView>("8a0c602e-05da-4a88-a720-bcf80b3a6d25","","",true, this);
 
            IDACCPeriod = RPSControlFactory.CreateRPSComboBox<BudgetValueView>("315a52ce-8312-403a-9913-fe33dabef46b","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<BudgetValueView>("4b428e67-3cd5-45a8-83a0-0c95bae6e900","","",true, this);
 
            CollectionInit params_BudgetValueDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1c349e49-61f1-4589-a979-2714d9e47083",CSSSelectorGrid="",XPathGrid=""};
            BudgetValueDetails = RPSControlFactory.RPSCreateCollectionWithGrid<BudgetValueDetailsCollectionEditor<BudgetValueView,BudgetValueDetailView>,BudgetValueView,BudgetValueDetailView>( params_BudgetValueDetails,this,Screen.BudgetValueDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<BudgetValueView>( "","ul li[rpsid='b2996f77-4fb7-48fb-904d-cb09a0c70128']","",this);
 
            SectionAnalitic = RPSControlFactory.CreateRPSSection<BudgetValueView>( "","ul li[rpsid='1ff7a9a7-6192-4e37-b1c9-3f51b94caf20']","",this);
 

        }
        public IRPSButton<BudgetValueView> DeleteButton { get; set; } 
        public IRPSButton<BudgetValueView,BudgetEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BudgetValueView,BudgetEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BudgetValueView,BudgetEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<BudgetValueView> IDAccount { get; set; } 
        public IRPSComboBox<BudgetValueView> IDACCPeriod { get; set; } 
        public IRPSTextBox<BudgetValueView> Amount { get; set; } 
        public BudgetValueDetailsCollectionEditor<BudgetValueView,BudgetValueDetailView> BudgetValueDetails { get; set; } 
        public IRPSSection<BudgetValueView> SectionGeneral { get; set; } 
        public IRPSSection<BudgetValueView> SectionAnalitic { get; set; } 
        public Budget Screen { get; set; }
        public BudgetValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BudgetValueDetailsCollectionEditor<BudgetValueView,BudgetValueDetailView>:RPSCollectionEditor<BudgetValueView,BudgetValueDetailView> where BudgetValueView : class, IView where BudgetValueDetailView : class, IView
    {
        public  BudgetValueDetailsGridView<BudgetValueView,BudgetValueDetailView> GridView {get;set;}
    }
    public partial class BudgetValueDetailsGridView <BudgetValueView,BudgetValueDetailView> :  RPSGridView<BudgetValueView,BudgetValueDetailView> where BudgetValueView : class, IView where BudgetValueDetailView : class, IView
    {
        public BudgetValueDetailsGridView(BudgetValueView currentView,BudgetValueDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<BudgetValueView>("","#1c349e49-61f1-4589-a979-2714d9e47083 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<BudgetValueView>("","#1c349e49-61f1-4589-a979-2714d9e47083 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<BudgetValueView>("","#1c349e49-61f1-4589-a979-2714d9e47083 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<BudgetValueView> IDDimension { get; set; } 
        public IRPSGridComboBox<BudgetValueView> IDDimValue { get; set; } 
        public IRPSGridTextBox<BudgetValueView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyDialogView : View
    {
        public CopyDialogView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Budget = RPSControlFactory.CreateRPSOption<CopyDialogView>( "082476ec-0a8f-481e-b505-489b825244c5","","",this);
 
            IDBudgetOrigin = RPSControlFactory.CreateRPSComboBox<CopyDialogView>("c42f2ac6-e664-4e11-92db-097f569ed781","","",false, this);
 
            RealBalance = RPSControlFactory.CreateRPSOption<CopyDialogView>( "a908fdfc-d569-4008-91f9-b48832b95565","","",this);
 
            IDACCYearOrigin = RPSControlFactory.CreateRPSComboBox<CopyDialogView>("b575a989-c830-4999-a9db-a4ff3600c5a8","","",false, this);
 
            New = RPSControlFactory.CreateRPSOption<CopyDialogView>( "b5831159-86ff-48c3-88e9-caeffaacfc8f","","",this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<CopyDialogView>("22717269-833a-4ef3-a127-6bdb01af5cb7","","",false, this);
 
            NewDescription = RPSControlFactory.CreateRPSTextBox<CopyDialogView>("4a12fa9f-b8f1-4ef0-8cc9-24cb56527209","","",false, this);
 
            NewIDACCYear = RPSControlFactory.CreateRPSComboBox<CopyDialogView>("2cbff7de-705a-49f4-88d4-7f6263ef3034","","",false, this);
 
            Existing = RPSControlFactory.CreateRPSOption<CopyDialogView>( "b4a6bbe5-4a26-4cfd-8f8e-9a31857ff40b","","",this);
 
            IDBudgetDestination = RPSControlFactory.CreateRPSComboBox<CopyDialogView>("61addecf-fa25-4eae-938a-cad43afd2836","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CopyDialogView>("91916891-aeb0-48f4-b438-95853cedf5c1","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CopyDialogView>("b1681b0a-0bcf-46fa-9f72-f2abf59e7817","","",false, this);
 
            Override = RPSControlFactory.CreateRPSCheckBox<CopyDialogView>("17130af3-fad5-4543-b81d-4204eac7175b","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<CopyDialogView>("c7e80e43-958f-4b8d-a02a-f56ef09a8fae","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<CopyDialogView>("99d71882-adbb-4479-918b-ea37561cfb50","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<CopyDialogView>("d17ee7f4-5846-4dba-bc8e-80c48336a924","","",false, this);
 
            Lineal = RPSControlFactory.CreateRPSOption<CopyDialogView>( "31341249-9fef-4dcf-bbe1-23879f4c55c4","","",this);
 
            IncreaseLin = RPSControlFactory.CreateRPSFormattedTextBox<CopyDialogView>("782eeeca-1e53-49b2-b050-b26ffbf02b85","","",false, this);
 
            Percent = RPSControlFactory.CreateRPSOption<CopyDialogView>( "83c35287-327b-43f5-a0bf-aac7cf3e438c","","",this);
 
            IncreasePer = RPSControlFactory.CreateRPSFormattedTextBox<CopyDialogView>("7e6d99ca-68ee-4cc0-b9e2-02968afcbb89","","",false, this);
 

        }
        public IRPSOption<CopyDialogView> Budget { get; set; } 
        public IRPSComboBox<CopyDialogView> IDBudgetOrigin { get; set; } 
        public IRPSOption<CopyDialogView> RealBalance { get; set; } 
        public IRPSComboBox<CopyDialogView> IDACCYearOrigin { get; set; } 
        public IRPSOption<CopyDialogView> New { get; set; } 
        public IRPSTextBox<CopyDialogView> NewCode { get; set; } 
        public IRPSTextBox<CopyDialogView> NewDescription { get; set; } 
        public IRPSComboBox<CopyDialogView> NewIDACCYear { get; set; } 
        public IRPSOption<CopyDialogView> Existing { get; set; } 
        public IRPSComboBox<CopyDialogView> IDBudgetDestination { get; set; } 
        public IRPSTextBox<CopyDialogView> DateFrom { get; set; } 
        public IRPSTextBox<CopyDialogView> DateTo { get; set; } 
        public IRPSCheckbox<CopyDialogView> Override { get; set; } 
        public IRPSCollectionComboBox<CopyDialogView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<CopyDialogView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<CopyDialogView> IDAccountClusterList { get; set; } 
        public IRPSOption<CopyDialogView> Lineal { get; set; } 
        public IRPSTextBox<CopyDialogView> IncreaseLin { get; set; } 
        public IRPSOption<CopyDialogView> Percent { get; set; } 
        public IRPSTextBox<CopyDialogView> IncreasePer { get; set; } 
        public Budget Screen { get; set; }
        public CopyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DistributeChildDialogView : View
    {
        public DistributeChildDialogView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<DistributeChildDialogView>("3b456594-b5d5-496d-a9ef-959aa93a9031","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DistributeChildDialogView>("2538e934-c88d-40f5-9e23-1e2edb079c3c","","",true, this);
 

        }
        public IRPSComboBox<DistributeChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<DistributeChildDialogView> Amount { get; set; } 
        public Budget Screen { get; set; }
        public DistributeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BudgetValueDetailView : View
    {
        public BudgetValueDetailView(Budget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BudgetValueDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BudgetValueDetailView,BudgetValueView>( this,Screen.BudgetValueView);
 
            BackButton = RPSControlFactory.RPSBackButton<BudgetValueDetailView,BudgetValueView>( this,Screen.BudgetValueView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BudgetValueDetailView,BudgetValueView>( this,Screen.BudgetValueView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<BudgetValueDetailView>("60e3a691-f313-42d4-860b-dfc506fcec10","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<BudgetValueDetailView>("18eaf12e-4379-40dc-aabe-c1da1147c0e3","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<BudgetValueDetailView>("7f378dc6-0e87-4f26-9c0c-9057ac4a37b9","","",true, this);
 

        }
        public IRPSButton<BudgetValueDetailView> DeleteButton { get; set; } 
        public IRPSButton<BudgetValueDetailView,BudgetValueView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BudgetValueDetailView,BudgetValueView> BackButton { get; set; } 
        public IRPSAcceptButton<BudgetValueDetailView,BudgetValueView> AcceptButton { get; set; } 
        public IRPSComboBox<BudgetValueDetailView> IDDimension { get; set; } 
        public IRPSComboBox<BudgetValueDetailView> IDDimValue { get; set; } 
        public IRPSTextBox<BudgetValueDetailView> Amount { get; set; } 
        public Budget Screen { get; set; }
        public BudgetValueDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
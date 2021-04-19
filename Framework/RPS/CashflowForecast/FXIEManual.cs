    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXIEManual
{
    //RPS VERSION 1.0.0.0
    public partial class FXIEManual:Screen
    {
        public FXIEManual():base()
        {
            this.URL = "cashflowforecast.fxiemanual";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXIEManualCollectionView  = new FXIEManualCollectionView(this); 
            FXIEManualEntityView  = new FXIEManualEntityView(this); 
            ChangeStatusChildDialogView  = new ChangeStatusChildDialogView(this); 
            GenerateIEPeriodicChildDialogView  = new GenerateIEPeriodicChildDialogView(this); 
            GenerateIEPeriodicFromGLChildDialogView  = new GenerateIEPeriodicFromGLChildDialogView(this); 
            LiquidationChildDialogView  = new LiquidationChildDialogView(this); 
            CrudScreenLiquidationChildDialogView  = new CrudScreenLiquidationChildDialogView(this); 
            FXIEManualCollectionView.InitializeControls(); 
            FXIEManualEntityView.InitializeControls(); 
            ChangeStatusChildDialogView.InitializeControls(); 
            GenerateIEPeriodicChildDialogView.InitializeControls(); 
            GenerateIEPeriodicFromGLChildDialogView.InitializeControls(); 
            LiquidationChildDialogView.InitializeControls(); 
            CrudScreenLiquidationChildDialogView.InitializeControls(); 
           
        }
      
            public FXIEManualCollectionView FXIEManualCollectionView {get; set; } 
            public FXIEManualEntityView FXIEManualEntityView {get; set; } 
            public ChangeStatusChildDialogView ChangeStatusChildDialogView {get; set; } 
            public GenerateIEPeriodicChildDialogView GenerateIEPeriodicChildDialogView {get; set; } 
            public GenerateIEPeriodicFromGLChildDialogView GenerateIEPeriodicFromGLChildDialogView {get; set; } 
            public LiquidationChildDialogView LiquidationChildDialogView {get; set; } 
            public CrudScreenLiquidationChildDialogView CrudScreenLiquidationChildDialogView {get; set; } 
    }
            
    public partial class FXIEManualCollectionView : View
    {
        public FXIEManualCollectionView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FXIEManualCollectionView,FXIEManualEntityView>( this,Screen.FXIEManualEntityView);
 
            CrudScreenLiquidationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXIEManualCollectionView,CrudScreenLiquidationChildDialogView>("dac88e3c-572c-40be-b940-9346db1219c2","","", this,Screen.CrudScreenLiquidationChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2fb2387c-a09b-4abc-8c43-eb8bccdcd440",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FXIEManualCollectionView,FXIEManualEntityView>( params_MainConsult,this,Screen.FXIEManualEntityView);
 

        }
        public IRPSButton<FXIEManualCollectionView,FXIEManualEntityView> NewButton { get; set; } 
        public IRPSButton<FXIEManualCollectionView,CrudScreenLiquidationChildDialogView> CrudScreenLiquidationChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<FXIEManualCollectionView,FXIEManualEntityView> MainConsult { get; set; } 
        public FXIEManual Screen { get; set; }
        public FXIEManualCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FXIEManualEntityView : View
    {
        public FXIEManualEntityView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FXIEManualEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXIEManualEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXIEManualEntityView,FXIEManualCollectionView>( this,Screen.FXIEManualCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXIEManualEntityView,FXIEManualCollectionView>( this,Screen.FXIEManualCollectionView);
 
            CodFXIEManual = RPSControlFactory.CreateRPSTextBox<FXIEManualEntityView>("f4e1b36e-5eef-448d-8f3e-a9d2f3949990","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FXIEManualEntityView>("0dfe6f87-a45c-45bd-b01d-9dcd72e128fc","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<FXIEManualEntityView>("f33fe726-49d5-43ac-b0ab-697a0351e824","","",true, this);
 
            CodFXIEConcept = RPSControlFactory.CreateRPSComboBox<FXIEManualEntityView>("c686b764-44ca-4195-919b-6c2b1a530ec2","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<FXIEManualEntityView>("4b632a33-624d-41eb-b56e-7663c9167e06","","",false, this);
 
            IsTransfer = RPSControlFactory.CreateRPSCheckBox<FXIEManualEntityView>("d068d3cf-b165-4cfc-a09a-5ddff7da60e6","","",true, this);
 
            CodFXIEConceptIncome = RPSControlFactory.CreateRPSComboBox<FXIEManualEntityView>("d3c6e6f0-3f2e-48dc-be0c-e951e35a97ae","","",false, this);
 
            IDBankAccountCompanyIncome = RPSControlFactory.CreateRPSComboBox<FXIEManualEntityView>("3b8ec67a-b480-479e-8b6d-7e211aa41e25","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FXIEManualEntityView>("77f42b23-13fe-4788-b285-57e34344224f","","",false, this);
 
            ChangeStatusChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXIEManualEntityView,ChangeStatusChildDialogView>("6f296b29-057d-4bd3-a13c-32372690bce4","","", this,Screen.ChangeStatusChildDialogView);
 
            GenerateIEPeriodicChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXIEManualEntityView,GenerateIEPeriodicChildDialogView>("f78bf980-6238-4f5c-ada2-5dabf10ac751","","", this,Screen.GenerateIEPeriodicChildDialogView);
 
            GenerateIEPeriodicFromGLChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXIEManualEntityView,GenerateIEPeriodicFromGLChildDialogView>("03eaf023-4c09-4727-9baf-7ec770c48baf","","", this,Screen.GenerateIEPeriodicFromGLChildDialogView);
 
            LiquidationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXIEManualEntityView,LiquidationChildDialogView>("c4fe40d2-cc7e-4f8c-97fa-0543bbb24a6f","","", this,Screen.LiquidationChildDialogView);
 
            CollectionInit params_FXIEManualValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="78b9a09b-9f80-46cd-b2cc-461b83644c6b",CSSSelectorGrid="",XPathGrid=""};
            FXIEManualValues = RPSControlFactory.RPSCreateCollectionWithGrid<FXIEManualValuesCollectionEditor<FXIEManualEntityView,ChangeStatusChildDialogView>,FXIEManualEntityView,ChangeStatusChildDialogView>( params_FXIEManualValues,this,Screen.ChangeStatusChildDialogView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<FXIEManualEntityView>( "","ul li[rpsid='50dbfe2c-acf4-4f93-82c6-b99a07a81fd1']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<FXIEManualEntityView>( "","ul li[rpsid='620cc406-ad75-4c9a-a250-cc9e9c9a6c8e']","",this);
 

        }
        public IRPSSaveButton<FXIEManualEntityView> SaveButton { get; set; } 
        public IRPSButton<FXIEManualEntityView> DeleteButton { get; set; } 
        public IRPSButton<FXIEManualEntityView,FXIEManualCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXIEManualEntityView,FXIEManualCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FXIEManualEntityView> CodFXIEManual { get; set; } 
        public IRPSTextBox<FXIEManualEntityView> Description { get; set; } 
        public IRPSComboBox<FXIEManualEntityView> Status { get; set; } 
        public IRPSComboBox<FXIEManualEntityView> CodFXIEConcept { get; set; } 
        public IRPSComboBox<FXIEManualEntityView> IDBankAccountCompany { get; set; } 
        public IRPSCheckbox<FXIEManualEntityView> IsTransfer { get; set; } 
        public IRPSComboBox<FXIEManualEntityView> CodFXIEConceptIncome { get; set; } 
        public IRPSComboBox<FXIEManualEntityView> IDBankAccountCompanyIncome { get; set; } 
        public IRPSTextBox<FXIEManualEntityView> Comment { get; set; } 
        public IRPSButton<FXIEManualEntityView,ChangeStatusChildDialogView> ChangeStatusChildNavigationCommandButton { get; set; } 
        public IRPSButton<FXIEManualEntityView,GenerateIEPeriodicChildDialogView> GenerateIEPeriodicChildNavigationCommandButton { get; set; } 
        public IRPSButton<FXIEManualEntityView,GenerateIEPeriodicFromGLChildDialogView> GenerateIEPeriodicFromGLChildNavigationCommandButton { get; set; } 
        public IRPSButton<FXIEManualEntityView,LiquidationChildDialogView> LiquidationChildNavigationCommandButton { get; set; } 
        public FXIEManualValuesCollectionEditor<FXIEManualEntityView,ChangeStatusChildDialogView> FXIEManualValues { get; set; } 
        public IRPSSection<FXIEManualEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<FXIEManualEntityView> CommentSection { get; set; } 
        public FXIEManual Screen { get; set; }
        public FXIEManualEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXIEManualValuesCollectionEditor<FXIEManualEntityView,ChangeStatusChildDialogView>:RPSCollectionEditor<FXIEManualEntityView,ChangeStatusChildDialogView> where FXIEManualEntityView : class, IView where ChangeStatusChildDialogView : class, IView
    {
        public  FXIEManualValuesGridView<FXIEManualEntityView,ChangeStatusChildDialogView> GridView {get;set;}
    }
    public partial class FXIEManualValuesGridView <FXIEManualEntityView,ChangeStatusChildDialogView> :  RPSGridView<FXIEManualEntityView,ChangeStatusChildDialogView> where FXIEManualEntityView : class, IView where ChangeStatusChildDialogView : class, IView
    {
        public FXIEManualValuesGridView(FXIEManualEntityView currentView,ChangeStatusChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ValueDate = RPSControlFactory.CreateRPSGridTextBox<FXIEManualEntityView>("","#78b9a09b-9f80-46cd-b2cc-461b83644c6b .ag-row[role='row']@ROWINDEX [col-id='cValueDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FXIEManualEntityView>("","#78b9a09b-9f80-46cd-b2cc-461b83644c6b .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Paid = RPSControlFactory.CreateRPSGridCheckBox<FXIEManualEntityView>("","#78b9a09b-9f80-46cd-b2cc-461b83644c6b .ag-row[role='row']@ROWINDEX [col-id='cPaid']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FXIEManualEntityView> ValueDate { get; set; } 
        public IRPSGridTextBox<FXIEManualEntityView> Amount { get; set; } 
        public IRPSGridCheckbox<FXIEManualEntityView> Paid { get; set; } 
                     
    }
 
    }
  
            
    public partial class ChangeStatusChildDialogView : View
    {
        public ChangeStatusChildDialogView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Status = RPSControlFactory.CreateRPSEnumComboBox<ChangeStatusChildDialogView>("8115341e-1ad9-4b8c-8c42-8e5d4d3909cb","","",false, this);
 
            NewStatus = RPSControlFactory.CreateRPSEnumComboBox<ChangeStatusChildDialogView>("11bdb61a-d34d-405c-bf8c-5240562cec29","","",false, this);
 

        }
        public IRPSComboBox<ChangeStatusChildDialogView> Status { get; set; } 
        public IRPSComboBox<ChangeStatusChildDialogView> NewStatus { get; set; } 
        public FXIEManual Screen { get; set; }
        public ChangeStatusChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateIEPeriodicChildDialogView : View
    {
        public GenerateIEPeriodicChildDialogView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            StartDate = RPSControlFactory.CreateRPSTextBox<GenerateIEPeriodicChildDialogView>("b2c767c7-6229-4357-a9d2-a3fbdcfdb58c","","",true, this);
 
            DaysGap = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicChildDialogView>("906b57d8-ec0e-4750-8df6-f98e430737f2","","",true, this);
 
            IsMonthComercial = RPSControlFactory.CreateRPSCheckBox<GenerateIEPeriodicChildDialogView>("c7e7aaca-b8c0-4b19-b939-799890428791","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicChildDialogView>("259281cd-6bc7-4b7e-978d-f8a84eca85bd","","",false, this);
 
            AmountType = RPSControlFactory.CreateRPSEnumComboBox<GenerateIEPeriodicChildDialogView>("cd8247ff-2c65-4942-a00c-69e0ebb71923","","",true, this);
 
            UIOptEndDate = RPSControlFactory.CreateRPSOption<GenerateIEPeriodicChildDialogView>( "a3d0488e-3ed8-427a-bd00-e92099f97487","","",this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<GenerateIEPeriodicChildDialogView>("5ee62865-a5a3-4f3d-badb-5d63ed1eae5e","","",false, this);
 
            UIOptNumberPeriods = RPSControlFactory.CreateRPSOption<GenerateIEPeriodicChildDialogView>( "0da3a9f4-c1d0-4550-b5e0-5c168e35be84","","",this);
 
            NumberPeriods = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicChildDialogView>("44d32997-04f1-4834-977f-e84ab9a6bc7a","","",false, this);
 

        }
        public IRPSTextBox<GenerateIEPeriodicChildDialogView> StartDate { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicChildDialogView> DaysGap { get; set; } 
        public IRPSCheckbox<GenerateIEPeriodicChildDialogView> IsMonthComercial { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicChildDialogView> Amount { get; set; } 
        public IRPSComboBox<GenerateIEPeriodicChildDialogView> AmountType { get; set; } 
        public IRPSOption<GenerateIEPeriodicChildDialogView> UIOptEndDate { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicChildDialogView> EndDate { get; set; } 
        public IRPSOption<GenerateIEPeriodicChildDialogView> UIOptNumberPeriods { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicChildDialogView> NumberPeriods { get; set; } 
        public FXIEManual Screen { get; set; }
        public GenerateIEPeriodicChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateIEPeriodicFromGLChildDialogView : View
    {
        public GenerateIEPeriodicFromGLChildDialogView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            YearSource = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicFromGLChildDialogView>("ae6eac23-b188-4bbd-9237-067222070e91","","",true, this);
 
            YearTarget = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicFromGLChildDialogView>("f828b8e9-595d-4ed2-adc9-0e48a9b5330e","","",true, this);
 
            PercentageIncrease = RPSControlFactory.CreateRPSFormattedTextBox<GenerateIEPeriodicFromGLChildDialogView>("edaa6ffa-9173-401b-8801-53377a7d8842","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView>("1c57132a-8a51-460a-872c-c8f69d9b4e6c","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView>("8ab14de2-638b-49ba-a462-b985a500d9d6","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView>("41677dc1-20ad-4c14-8d3c-f71d4d549ef3","","",false, this);
 
            AdjustType = RPSControlFactory.CreateRPSEnumComboBox<GenerateIEPeriodicFromGLChildDialogView>("a3f8106f-a480-4141-b6b9-566d64d59b28","","",false, this);
 

        }
        public IRPSTextBox<GenerateIEPeriodicFromGLChildDialogView> YearSource { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicFromGLChildDialogView> YearTarget { get; set; } 
        public IRPSTextBox<GenerateIEPeriodicFromGLChildDialogView> PercentageIncrease { get; set; } 
        public IRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<GenerateIEPeriodicFromGLChildDialogView> IDAccountClusterList { get; set; } 
        public IRPSComboBox<GenerateIEPeriodicFromGLChildDialogView> AdjustType { get; set; } 
        public FXIEManual Screen { get; set; }
        public GenerateIEPeriodicFromGLChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LiquidationChildDialogView : View
    {
        public LiquidationChildDialogView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<LiquidationChildDialogView>("218ca5b8-7f2d-4881-b13b-ddcceeacde1e","","",false, this);
 

        }
        public IRPSTextBox<LiquidationChildDialogView> DateTo { get; set; } 
        public FXIEManual Screen { get; set; }
        public LiquidationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CrudScreenLiquidationChildDialogView : View
    {
        public CrudScreenLiquidationChildDialogView(FXIEManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<CrudScreenLiquidationChildDialogView>("2fc9969d-de4e-4e2d-baec-e8560f3762a8","","",false, this);
 

        }
        public IRPSTextBox<CrudScreenLiquidationChildDialogView> DateTo { get; set; } 
        public FXIEManual Screen { get; set; }
        public CrudScreenLiquidationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AssetsManagement
{
    //RPS VERSION 1.0.0.0
    public partial class AssetsManagement:Screen
    {
        public AssetsManagement():base()
        {
            this.URL = "generalledger.assetsmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AssetsManagementQueryView  = new AssetsManagementQueryView(this); 
            FAMassiveDisposeChildDialogView  = new FAMassiveDisposeChildDialogView(this); 
            FACalculateDepreciationPlanChildDialogView  = new FACalculateDepreciationPlanChildDialogView(this); 
            FADepreciationGenerateChildDialogView  = new FADepreciationGenerateChildDialogView(this); 
            DepreciationForecastOptionsChildDialogView  = new DepreciationForecastOptionsChildDialogView(this); 
            FAInventoryChildDialogView  = new FAInventoryChildDialogView(this); 
            DepreciationForecastAnnualChildView  = new DepreciationForecastAnnualChildView(this); 
            DepreciationForecastMonthlyChildView  = new DepreciationForecastMonthlyChildView(this); 
            AssetsManagementQueryView.InitializeControls(); 
            FAMassiveDisposeChildDialogView.InitializeControls(); 
            FACalculateDepreciationPlanChildDialogView.InitializeControls(); 
            FADepreciationGenerateChildDialogView.InitializeControls(); 
            DepreciationForecastOptionsChildDialogView.InitializeControls(); 
            FAInventoryChildDialogView.InitializeControls(); 
            DepreciationForecastAnnualChildView.InitializeControls(); 
            DepreciationForecastMonthlyChildView.InitializeControls(); 
           
        }
      
            public AssetsManagementQueryView AssetsManagementQueryView {get; set; } 
            public FAMassiveDisposeChildDialogView FAMassiveDisposeChildDialogView {get; set; } 
            public FACalculateDepreciationPlanChildDialogView FACalculateDepreciationPlanChildDialogView {get; set; } 
            public FADepreciationGenerateChildDialogView FADepreciationGenerateChildDialogView {get; set; } 
            public DepreciationForecastOptionsChildDialogView DepreciationForecastOptionsChildDialogView {get; set; } 
            public FAInventoryChildDialogView FAInventoryChildDialogView {get; set; } 
            public DepreciationForecastAnnualChildView DepreciationForecastAnnualChildView {get; set; } 
            public DepreciationForecastMonthlyChildView DepreciationForecastMonthlyChildView {get; set; } 
    }
            
    public partial class AssetsManagementQueryView : View
    {
        public AssetsManagementQueryView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FixedAsset = RPSControlFactory.CreateRPSCollectionComboBox<AssetsManagementQueryView>("e4e9a2f0-e671-4e40-8a50-d8d20d5062d1","","",false, this);
 
            FAMain = RPSControlFactory.CreateRPSCollectionComboBox<AssetsManagementQueryView>("99d10dbe-b71b-48f8-adec-df31e68b0556","","",false, this);
 
            FAAcquistionDateFrom = RPSControlFactory.CreateRPSTextBox<AssetsManagementQueryView>("a905ecad-7763-4697-8374-b2e5d4f8787e","","",false, this);
 
            FAAcquistionDateTo = RPSControlFactory.CreateRPSTextBox<AssetsManagementQueryView>("e85ee6ed-e736-409a-aedb-dd1b88651719","","",false, this);
 
            DepreciationDateFrom = RPSControlFactory.CreateRPSTextBox<AssetsManagementQueryView>("bebcc71d-cdd6-4e9a-a3fb-66399fbdd7de","","",false, this);
 
            DepreciationDateTo = RPSControlFactory.CreateRPSTextBox<AssetsManagementQueryView>("1483dc38-4e16-49f6-9a31-547234fbc085","","",false, this);
 
            CalculateDepreciationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AssetsManagementQueryView,FACalculateDepreciationPlanChildDialogView>("14a45bd2-dc04-4999-b745-3b4f679c0930","","", this,Screen.FACalculateDepreciationPlanChildDialogView);
 
            DepreciationGenerateNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AssetsManagementQueryView,FADepreciationGenerateChildDialogView>("d16471bd-5e1d-46cd-ab33-fbe67bff02bd","","", this,Screen.FADepreciationGenerateChildDialogView);
 
            DisposeLinkNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AssetsManagementQueryView,FAMassiveDisposeChildDialogView>("6bb0631b-44ef-46fc-b92f-3482af1d7920","","", this,Screen.FAMassiveDisposeChildDialogView);
 
            DepreciationForecastOptionsChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AssetsManagementQueryView,DepreciationForecastOptionsChildDialogView>("66cf0156-9b9c-4060-b480-5664dcc7b66b","","", this,Screen.DepreciationForecastOptionsChildDialogView);
 
            FAInventoryChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AssetsManagementQueryView,FAInventoryChildDialogView>("ef9ba48b-ed02-486f-9466-ff94ba9d5d3b","","", this,Screen.FAInventoryChildDialogView);
 
            CollectionInit params_AssetsManagement = new CollectionInit(){IDDescriptor = "2efaa10d-dd88-4658-9c5b-44a1843bc74e",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="152e2c9e-2c0c-440f-8abb-1df165e3849e",CSSSelectorGrid="",XPathGrid=""};
            AssetsManagement = RPSControlFactory.RPSCreateCollectionWithGrid<AssetsManagementCollectionEditor<AssetsManagementQueryView,FAMassiveDisposeChildDialogView>,AssetsManagementQueryView,FAMassiveDisposeChildDialogView>( params_AssetsManagement,this,Screen.FAMassiveDisposeChildDialogView);
 

        }
        public IRPSCollectionComboBox<AssetsManagementQueryView> FixedAsset { get; set; } 
        public IRPSCollectionComboBox<AssetsManagementQueryView> FAMain { get; set; } 
        public IRPSTextBox<AssetsManagementQueryView> FAAcquistionDateFrom { get; set; } 
        public IRPSTextBox<AssetsManagementQueryView> FAAcquistionDateTo { get; set; } 
        public IRPSTextBox<AssetsManagementQueryView> DepreciationDateFrom { get; set; } 
        public IRPSTextBox<AssetsManagementQueryView> DepreciationDateTo { get; set; } 
        public IRPSButton<AssetsManagementQueryView,FACalculateDepreciationPlanChildDialogView> CalculateDepreciationNavigationCommandButton { get; set; } 
        public IRPSButton<AssetsManagementQueryView,FADepreciationGenerateChildDialogView> DepreciationGenerateNavigationCommandButton { get; set; } 
        public IRPSButton<AssetsManagementQueryView,FAMassiveDisposeChildDialogView> DisposeLinkNavigationCommandButton { get; set; } 
        public IRPSButton<AssetsManagementQueryView,DepreciationForecastOptionsChildDialogView> DepreciationForecastOptionsChildNavigationCommandButton { get; set; } 
        public IRPSButton<AssetsManagementQueryView,FAInventoryChildDialogView> FAInventoryChildNavigationCommandButton { get; set; } 
        public AssetsManagementCollectionEditor<AssetsManagementQueryView,FAMassiveDisposeChildDialogView> AssetsManagement { get; set; } 
        public AssetsManagement Screen { get; set; }
        public AssetsManagementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AssetsManagementCollectionEditor<AssetsManagementQueryView,FAMassiveDisposeChildDialogView>:RPSCollectionEditor<AssetsManagementQueryView,FAMassiveDisposeChildDialogView> where AssetsManagementQueryView : class, IView where FAMassiveDisposeChildDialogView : class, IView
    {
        public  AssetsManagementGridView<AssetsManagementQueryView,FAMassiveDisposeChildDialogView> GridView {get;set;}
    }
    public partial class AssetsManagementGridView <AssetsManagementQueryView,FAMassiveDisposeChildDialogView> :  RPSGridView<AssetsManagementQueryView,FAMassiveDisposeChildDialogView> where AssetsManagementQueryView : class, IView where FAMassiveDisposeChildDialogView : class, IView
    {
        public AssetsManagementGridView(AssetsManagementQueryView currentView,FAMassiveDisposeChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FixedAsset_CodFA = RPSControlFactory.CreateRPSGridTextBox<AssetsManagementQueryView>("","#152e2c9e-2c0c-440f-8abb-1df165e3849e .ag-row[role='row']@ROWINDEX [col-id='cFixedAsset_CodFA']","",false, this.CurrentView);
 
            FixedAsset_FAStatus = RPSControlFactory.CreateRPSGridTextBox<AssetsManagementQueryView>("","#152e2c9e-2c0c-440f-8abb-1df165e3849e .ag-row[role='row']@ROWINDEX [col-id='cFixedAsset_FAStatus']","",false, this.CurrentView);
 
            FixedAsset_FAAcquisitionDate = RPSControlFactory.CreateRPSGridTextBox<AssetsManagementQueryView>("","#152e2c9e-2c0c-440f-8abb-1df165e3849e .ag-row[role='row']@ROWINDEX [col-id='cFixedAsset_FAAcquisitionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AssetsManagementQueryView> FixedAsset_CodFA { get; set; } 
        public IRPSGridTextBox<AssetsManagementQueryView> FixedAsset_FAStatus { get; set; } 
        public IRPSGridTextBox<AssetsManagementQueryView> FixedAsset_FAAcquisitionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class FAMassiveDisposeChildDialogView : View
    {
        public FAMassiveDisposeChildDialogView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DisposeDate = RPSControlFactory.CreateRPSTextBox<FAMassiveDisposeChildDialogView>("2294672e-90c2-4600-9f2e-9dd8bb5285ed","","",false, this);
 

        }
        public IRPSTextBox<FAMassiveDisposeChildDialogView> DisposeDate { get; set; } 
        public AssetsManagement Screen { get; set; }
        public FAMassiveDisposeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FACalculateDepreciationPlanChildDialogView : View
    {
        public FACalculateDepreciationPlanChildDialogView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckDepreciatedPeriods = RPSControlFactory.CreateRPSCheckBox<FACalculateDepreciationPlanChildDialogView>("97f204b5-3a2f-44dd-bf64-6519bf30562c","","",false, this);
 
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<FACalculateDepreciationPlanChildDialogView>("dd932735-1443-4f27-bc49-be096dc21956","","",false, this);
 

        }
        public IRPSCheckbox<FACalculateDepreciationPlanChildDialogView> CheckDepreciatedPeriods { get; set; } 
        public IRPSComboBox<FACalculateDepreciationPlanChildDialogView> IDFADepreciationType { get; set; } 
        public AssetsManagement Screen { get; set; }
        public FACalculateDepreciationPlanChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FADepreciationGenerateChildDialogView : View
    {
        public FADepreciationGenerateChildDialogView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("fe1c6ae2-7739-4b55-b9ef-69137c30e249","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("8f503be2-c1bf-4c3f-b41b-379720c7abf2","","",false, this);
 
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<FADepreciationGenerateChildDialogView>("06877931-b686-45d8-b8cc-21747b7a8339","","",false, this);
 
            CheckGenerateDepreciation = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("6f863381-0b0d-4183-9b86-d84bf17d090c","","",false, this);
 
            CheckGenerateAccountingEntries = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("1cf4207b-bd71-4976-b29e-f994fde0c888","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("8cde9781-0942-4773-b755-84ade483c543","","",false, this);
 
            CheckOneJournal = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("f9fd771a-fae4-421f-abd8-023879de9008","","",false, this);
 
            CheckGroupAccount = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("2e7414dd-5a99-4314-ac71-1a73c6648178","","",false, this);
 

        }
        public IRPSTextBox<FADepreciationGenerateChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<FADepreciationGenerateChildDialogView> DateTo { get; set; } 
        public IRPSComboBox<FADepreciationGenerateChildDialogView> IDFADepreciationType { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckGenerateDepreciation { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckGenerateAccountingEntries { get; set; } 
        public IRPSTextBox<FADepreciationGenerateChildDialogView> AccountingDate { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckOneJournal { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckGroupAccount { get; set; } 
        public AssetsManagement Screen { get; set; }
        public FADepreciationGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DepreciationForecastOptionsChildDialogView : View
    {
        public DepreciationForecastOptionsChildDialogView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            year = RPSControlFactory.CreateRPSOption<DepreciationForecastOptionsChildDialogView>( "e7817780-f535-4da5-b33e-445fa9c22f7e","","",this);
 
            month = RPSControlFactory.CreateRPSOption<DepreciationForecastOptionsChildDialogView>( "4e0291b5-52a1-49fe-b033-007f37abc310","","",this);
 
            InstallmentStartYear = RPSControlFactory.CreateRPSFormattedTextBox<DepreciationForecastOptionsChildDialogView>("0ec5deb9-67b6-49c6-b0c9-6052136d689e","","",false, this);
 
            InstallmentYear = RPSControlFactory.CreateRPSFormattedTextBox<DepreciationForecastOptionsChildDialogView>("f9380f63-bff5-4719-bc2a-2b805d18d05b","","",false, this);
 
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<DepreciationForecastOptionsChildDialogView>("8c80cbeb-be90-412a-9708-a738afe06892","","",false, this);
 

        }
        public IRPSOption<DepreciationForecastOptionsChildDialogView> year { get; set; } 
        public IRPSOption<DepreciationForecastOptionsChildDialogView> month { get; set; } 
        public IRPSTextBox<DepreciationForecastOptionsChildDialogView> InstallmentStartYear { get; set; } 
        public IRPSTextBox<DepreciationForecastOptionsChildDialogView> InstallmentYear { get; set; } 
        public IRPSComboBox<DepreciationForecastOptionsChildDialogView> IDFADepreciationType { get; set; } 
        public AssetsManagement Screen { get; set; }
        public DepreciationForecastOptionsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAInventoryChildDialogView : View
    {
        public FAInventoryChildDialogView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<FAInventoryChildDialogView>("65654223-890d-4ce3-ad60-4f99ab54e912","","",false, this);
 
            bPurchaseInfo = RPSControlFactory.CreateRPSCheckBox<FAInventoryChildDialogView>("ae499d70-3e75-48ad-b754-62f98d0fd9e8","","",false, this);
 
            bDepreciationInfo = RPSControlFactory.CreateRPSCheckBox<FAInventoryChildDialogView>("2ce525e6-d935-4d50-9e1b-94ac531626ef","","",false, this);
 
            bSummaryInfo = RPSControlFactory.CreateRPSCheckBox<FAInventoryChildDialogView>("fa3c0afc-e232-47df-97b1-e98519c1a426","","",false, this);
 

        }
        public IRPSComboBox<FAInventoryChildDialogView> IDFADepreciationType { get; set; } 
        public IRPSCheckbox<FAInventoryChildDialogView> bPurchaseInfo { get; set; } 
        public IRPSCheckbox<FAInventoryChildDialogView> bDepreciationInfo { get; set; } 
        public IRPSCheckbox<FAInventoryChildDialogView> bSummaryInfo { get; set; } 
        public AssetsManagement Screen { get; set; }
        public FAInventoryChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DepreciationForecastAnnualChildView : View
    {
        public DepreciationForecastAnnualChildView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PrintCommandButton = RPSControlFactory.CreateRPSButton<DepreciationForecastAnnualChildView>( "337d06e5-5b01-478e-b84a-4746aa0e92f6","","",this);
 
            CollectionInit params_GetAnnualForecast = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3da8fd99-0761-4e8e-8de8-7fa56d09a7a8",CSSSelectorGrid="",XPathGrid=""};
            GetAnnualForecast = RPSControlFactory.RPSCreateCollectionWithGrid<GetAnnualForecastCollectionEditor<DepreciationForecastAnnualChildView>,DepreciationForecastAnnualChildView>( params_GetAnnualForecast,this);
 

        }
        public IRPSButton<DepreciationForecastAnnualChildView> PrintCommandButton { get; set; } 
        public GetAnnualForecastCollectionEditor<DepreciationForecastAnnualChildView> GetAnnualForecast { get; set; } 
        public AssetsManagement Screen { get; set; }
        public DepreciationForecastAnnualChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetAnnualForecastCollectionEditor<DepreciationForecastAnnualChildView>:RPSCollectionEditor<DepreciationForecastAnnualChildView> where DepreciationForecastAnnualChildView : class, IView
    {
        public  GetAnnualForecastGridView<DepreciationForecastAnnualChildView> GridView {get;set;}
    }
    public partial class GetAnnualForecastGridView <DepreciationForecastAnnualChildView> :  RPSGridView<DepreciationForecastAnnualChildView> where DepreciationForecastAnnualChildView : class, IView
    {
        public GetAnnualForecastGridView(DepreciationForecastAnnualChildView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class DepreciationForecastMonthlyChildView : View
    {
        public DepreciationForecastMonthlyChildView(AssetsManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PrintCommandButton = RPSControlFactory.CreateRPSButton<DepreciationForecastMonthlyChildView>( "df601917-58c6-4b1c-af5c-f7e6cb1e1616","","",this);
 
            CollectionInit params_GetMonthlyForecast = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9b0011d7-cb1a-4c4c-a122-42293adcfdc6",CSSSelectorGrid="",XPathGrid=""};
            GetMonthlyForecast = RPSControlFactory.RPSCreateCollectionWithGrid<GetMonthlyForecastCollectionEditor<DepreciationForecastMonthlyChildView>,DepreciationForecastMonthlyChildView>( params_GetMonthlyForecast,this);
 

        }
        public IRPSButton<DepreciationForecastMonthlyChildView> PrintCommandButton { get; set; } 
        public GetMonthlyForecastCollectionEditor<DepreciationForecastMonthlyChildView> GetMonthlyForecast { get; set; } 
        public AssetsManagement Screen { get; set; }
        public DepreciationForecastMonthlyChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMonthlyForecastCollectionEditor<DepreciationForecastMonthlyChildView>:RPSCollectionEditor<DepreciationForecastMonthlyChildView> where DepreciationForecastMonthlyChildView : class, IView
    {
        public  GetMonthlyForecastGridView<DepreciationForecastMonthlyChildView> GridView {get;set;}
    }
    public partial class GetMonthlyForecastGridView <DepreciationForecastMonthlyChildView> :  RPSGridView<DepreciationForecastMonthlyChildView> where DepreciationForecastMonthlyChildView : class, IView
    {
        public GetMonthlyForecastGridView(DepreciationForecastMonthlyChildView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}
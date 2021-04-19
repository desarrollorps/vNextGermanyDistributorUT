    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.MonthClosure
{
    //RPS VERSION 1.0.0.0
    public partial class MonthClosure:Screen
    {
        public MonthClosure():base()
        {
            this.URL = "warehouse.monthclosure";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MonthClosureView  = new MonthClosureView(this); 
            MonthClosureView.InitializeControls(); 
           
        }
      
            public MonthClosureView MonthClosureView {get; set; } 
    }
            
    public partial class MonthClosureView : View
    {
        public MonthClosureView(MonthClosure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionMonthYear = RPSControlFactory.CreateRPSEnumComboBox<MonthClosureView>("7300dd28-0d5f-4590-979c-a79075d9e9d1","","",false, this);
 
            MonthComboEditor = RPSControlFactory.CreateRPSEnumComboBox<MonthClosureView>("79fb6129-a8ab-4fea-ac83-62fcf3aa4389","","",false, this);
 
            ParameterYear = RPSControlFactory.CreateRPSTextBox<MonthClosureView>("53549467-2b19-4ca9-b0ed-bccfcb92f34c","","",true, this);
 
            bCheckStockNegative = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("9900466c-05d7-41dc-9d98-9cbb277df11c","","",false, this);
 
            bWarehouseClosure = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("3f376beb-24ca-4e03-b3ba-3f852e8ae693","","",false, this);
 
            bMOToOpenStatus = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("082f10aa-add8-44e5-b991-5c54adbba7be","","",false, this);
 
            ParameterMOToOpenStatusManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<MonthClosureView>("1793663f-bbcd-4508-8530-4f7873c61fb6","","",false, this);
 
            bApplyTimeCosts = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("dbe06f2b-3075-4468-b115-827d3c0a6952","","",false, this);
 
            ApplyTimeCostsManufacturing = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("9a03be19-a9b9-4565-94a6-26974164021e","","",false, this);
 
            ApplyTimeCostsProject = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("4e11487b-98b1-48f7-878f-cfd2bb3b9751","","",false, this);
 
            bArticleCostReconstruction = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("d304bca5-7fb9-4e45-831f-a518015b41ac","","",false, this);
 
            IsFromArticle = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("4a2a8f48-7fcf-4c9e-a71c-a798ba1ca04b","","",false, this);
 
            ParameterArticleCostReconstruction = RPSControlFactory.CreateRPSComboBox<MonthClosureView>("c905e520-2250-460a-bfb0-51e5873bcd44","","",false, this);
 
            bMORegularization = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("b02132bd-ed21-475e-b40a-fb9cd9903941","","",false, this);
 
            IsFromArticleOF = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("98939bff-b8ab-4c06-ab3f-805599652c0b","","",false, this);
 
            ParameterMORegularization = RPSControlFactory.CreateRPSComboBox<MonthClosureView>("e075d205-a45c-4bde-ab6c-39f04c93cb22","","",false, this);
 
            bMOToClosedStatus = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("bb38113c-dee9-4519-9b23-650cfe974cfd","","",false, this);
 
            ParameterMOToClosedStatusManufacturingOrderSituationFrom = RPSControlFactory.CreateRPSComboBox<MonthClosureView>("51994350-a39f-44f7-9934-a9aba8c6e921","","",false, this);
 
            ParameterMOToClosedStatusManufacturingOrderSituationTo = RPSControlFactory.CreateRPSComboBox<MonthClosureView>("f96e1d5d-a963-45dc-a4e3-0e6fc9a820df","","",false, this);
 
            bAssesImputations = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("4ba9a1c2-e83c-425e-bc38-b704fcd44e1e","","",false, this);
 
            bSimulation = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("96da62ec-fd4d-4803-ab2d-565b94634dcf","","",false, this);
 
            LastSimulationDate = RPSControlFactory.CreateRPSTextBox<MonthClosureView>("c02ec064-d8f5-4b8f-907f-228f770d6e27","","",false, this);
 
            LastRealDate = RPSControlFactory.CreateRPSTextBox<MonthClosureView>("e39c60cb-7e1c-4265-b9dd-ffa2f267919c","","",false, this);
 
            bAssesWarehouseMovements = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("4f462450-1f50-4dcc-a610-e21c141ede5c","","",false, this);
 
            AssesImputationsManufacturing = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("ea20e1c4-d41e-4fff-80a4-f460cebeff22","","",false, this);
 
            AssesImputationsProject = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("389dc181-94d2-4ce2-a289-a7a35fa8e883","","",false, this);
 
            AssesImputationsMaintenance = RPSControlFactory.CreateRPSCheckBox<MonthClosureView>("ca2702f3-13b6-4ae1-afc7-aa8b1b93aaee","","",false, this);
 
            MonthClosureCommand = RPSControlFactory.CreateRPSButton<MonthClosureView>( "c5cfa9c0-f02d-48f2-984b-3aadd1ce04b5","","",this);
 
            ExecutePTPreviousMonthClosureDetailLinesButton = RPSControlFactory.CreateRPSButton<MonthClosureView>( "f63c1e8e-8c86-4a2c-9cf0-15845963eb88","","",this);
 
            CollectionInit params_MonthClosureGetOcurredErrors = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ca48b97-9843-4ec7-95ed-426a2fa59759",CSSSelectorGrid="",XPathGrid=""};
            MonthClosureGetOcurredErrors = RPSControlFactory.RPSCreateCollectionWithGrid<MonthClosureGetOcurredErrorsCollectionEditor<MonthClosureView>,MonthClosureView>( params_MonthClosureGetOcurredErrors,this);
 
            CollectionInit params_PreviousMonthClosureDetailLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5a4d6095-2274-4836-9cb2-ff93437206de",CSSSelectorGrid="",XPathGrid=""};
            PreviousMonthClosureDetailLines = RPSControlFactory.RPSCreateCollectionWithGrid<PreviousMonthClosureDetailLinesCollectionEditor<MonthClosureView>,MonthClosureView>( params_PreviousMonthClosureDetailLines,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MonthClosureView>( "","ul li[rpsid='2ed5d334-abfb-4dc0-9c42-84e3f5d197eb']","",this);
 
            LastSimulation = RPSControlFactory.CreateRPSSection<MonthClosureView>( "","ul li[rpsid='8b690cfc-cfd4-4a5c-a056-bd6141d6c6bc']","",this);
 

        }
        public IRPSComboBox<MonthClosureView> OptionMonthYear { get; set; } 
        public IRPSComboBox<MonthClosureView> MonthComboEditor { get; set; } 
        public IRPSTextBox<MonthClosureView> ParameterYear { get; set; } 
        public IRPSCheckbox<MonthClosureView> bCheckStockNegative { get; set; } 
        public IRPSCheckbox<MonthClosureView> bWarehouseClosure { get; set; } 
        public IRPSCheckbox<MonthClosureView> bMOToOpenStatus { get; set; } 
        public IRPSComboBox<MonthClosureView> ParameterMOToOpenStatusManufacturingOrderSituation { get; set; } 
        public IRPSCheckbox<MonthClosureView> bApplyTimeCosts { get; set; } 
        public IRPSCheckbox<MonthClosureView> ApplyTimeCostsManufacturing { get; set; } 
        public IRPSCheckbox<MonthClosureView> ApplyTimeCostsProject { get; set; } 
        public IRPSCheckbox<MonthClosureView> bArticleCostReconstruction { get; set; } 
        public IRPSCheckbox<MonthClosureView> IsFromArticle { get; set; } 
        public IRPSComboBox<MonthClosureView> ParameterArticleCostReconstruction { get; set; } 
        public IRPSCheckbox<MonthClosureView> bMORegularization { get; set; } 
        public IRPSCheckbox<MonthClosureView> IsFromArticleOF { get; set; } 
        public IRPSComboBox<MonthClosureView> ParameterMORegularization { get; set; } 
        public IRPSCheckbox<MonthClosureView> bMOToClosedStatus { get; set; } 
        public IRPSComboBox<MonthClosureView> ParameterMOToClosedStatusManufacturingOrderSituationFrom { get; set; } 
        public IRPSComboBox<MonthClosureView> ParameterMOToClosedStatusManufacturingOrderSituationTo { get; set; } 
        public IRPSCheckbox<MonthClosureView> bAssesImputations { get; set; } 
        public IRPSCheckbox<MonthClosureView> bSimulation { get; set; } 
        public IRPSTextBox<MonthClosureView> LastSimulationDate { get; set; } 
        public IRPSTextBox<MonthClosureView> LastRealDate { get; set; } 
        public IRPSCheckbox<MonthClosureView> bAssesWarehouseMovements { get; set; } 
        public IRPSCheckbox<MonthClosureView> AssesImputationsManufacturing { get; set; } 
        public IRPSCheckbox<MonthClosureView> AssesImputationsProject { get; set; } 
        public IRPSCheckbox<MonthClosureView> AssesImputationsMaintenance { get; set; } 
        public IRPSButton<MonthClosureView> MonthClosureCommand { get; set; } 
        public IRPSButton<MonthClosureView> ExecutePTPreviousMonthClosureDetailLinesButton { get; set; } 
        public MonthClosureGetOcurredErrorsCollectionEditor<MonthClosureView> MonthClosureGetOcurredErrors { get; set; } 
        public PreviousMonthClosureDetailLinesCollectionEditor<MonthClosureView> PreviousMonthClosureDetailLines { get; set; } 
        public IRPSSection<MonthClosureView> GeneralData { get; set; } 
        public IRPSSection<MonthClosureView> LastSimulation { get; set; } 
        public MonthClosure Screen { get; set; }
        public MonthClosureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MonthClosureGetOcurredErrorsCollectionEditor<MonthClosureView>:RPSCollectionEditor<MonthClosureView> where MonthClosureView : class, IView
    {
        public  MonthClosureGetOcurredErrorsGridView<MonthClosureView> GridView {get;set;}
    }
    public partial class MonthClosureGetOcurredErrorsGridView <MonthClosureView> :  RPSGridView<MonthClosureView> where MonthClosureView : class, IView
    {
        public MonthClosureGetOcurredErrorsGridView(MonthClosureView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProcessDescription = RPSControlFactory.CreateRPSGridTextBox<MonthClosureView>("","#3ca48b97-9843-4ec7-95ed-426a2fa59759 .ag-row[role='row']@ROWINDEX [col-id='cProcessDescription']","",false, this.CurrentView);
 
            ErrorDescription = RPSControlFactory.CreateRPSGridMemoTextBox<MonthClosureView>("","#3ca48b97-9843-4ec7-95ed-426a2fa59759 .ag-row[role='row']@ROWINDEX [col-id='cErrorDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MonthClosureView> ProcessDescription { get; set; } 
        public IRPSGridTextBox<MonthClosureView> ErrorDescription { get; set; } 
                     
    }
 
        public partial class PreviousMonthClosureDetailLinesCollectionEditor<MonthClosureView>:RPSCollectionEditor<MonthClosureView> where MonthClosureView : class, IView
    {
        public  PreviousMonthClosureDetailLinesGridView<MonthClosureView> GridView {get;set;}
    }
    public partial class PreviousMonthClosureDetailLinesGridView <MonthClosureView> :  RPSGridView<MonthClosureView> where MonthClosureView : class, IView
    {
        public PreviousMonthClosureDetailLinesGridView(MonthClosureView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MonthCloseDetail_Source = RPSControlFactory.CreateRPSGridTextBox<MonthClosureView>("","#5a4d6095-2274-4836-9cb2-ff93437206de .ag-row[role='row']@ROWINDEX [col-id='cMonthClosureDetail_Source']","",false, this.CurrentView);
 
            MonthCloseDetail_NumberDocument = RPSControlFactory.CreateRPSGridTextBox<MonthClosureView>("","#5a4d6095-2274-4836-9cb2-ff93437206de .ag-row[role='row']@ROWINDEX [col-id='cMonthClosureDetail_NumberDocument']","",false, this.CurrentView);
 
            MonthCloseDetail_Extension = RPSControlFactory.CreateRPSGridTextBox<MonthClosureView>("","#5a4d6095-2274-4836-9cb2-ff93437206de .ag-row[role='row']@ROWINDEX [col-id='cMonthClosureDetail_Extension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MonthClosureView> MonthCloseDetail_Source { get; set; } 
        public IRPSGridTextBox<MonthClosureView> MonthCloseDetail_NumberDocument { get; set; } 
        public IRPSGridTextBox<MonthClosureView> MonthCloseDetail_Extension { get; set; } 
                     
    }
 
    }
  
    

}
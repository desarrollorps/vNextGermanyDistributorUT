    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.CuDistExportOfResourceStops
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistExportOfResourceStops:Screen
    {
        public CuDistExportOfResourceStops():base()
        {
            this.URL = "planification.cudistexportofresourcestops";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistExportOfResourceStopsView  = new CuDistExportOfResourceStopsView(this); 
            CuDistExportOfResourceStopsView.InitializeControls(); 
           
        }
      
            public CuDistExportOfResourceStopsView CuDistExportOfResourceStopsView {get; set; } 
    }
            
    public partial class CuDistExportOfResourceStopsView : View
    {
        public CuDistExportOfResourceStopsView(CuDistExportOfResourceStops screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LoadDataCommand = RPSControlFactory.CreateRPSButton<CuDistExportOfResourceStopsView>( "b63f1d33-3f15-4628-bbf7-6256c535890c","","",this);
 
            ConfirmCommand = RPSControlFactory.CreateRPSButton<CuDistExportOfResourceStopsView>( "666c7a1f-a3a3-4c8e-b46f-0a30da71b44c","","",this);
 
            CollectionInit params_CuDistExportOfResourceStopsQueryDataSource = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4c3bc0c4-019c-4074-9287-0b08901f582d",CSSSelectorGrid="",XPathGrid=""};
            CuDistExportOfResourceStopsQueryDataSource = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistExportOfResourceStopsQueryDataSourceCollectionEditor<CuDistExportOfResourceStopsView>,CuDistExportOfResourceStopsView>( params_CuDistExportOfResourceStopsQueryDataSource,this);
 

        }
        public IRPSButton<CuDistExportOfResourceStopsView> LoadDataCommand { get; set; } 
        public IRPSButton<CuDistExportOfResourceStopsView> ConfirmCommand { get; set; } 
        public CuDistExportOfResourceStopsQueryDataSourceCollectionEditor<CuDistExportOfResourceStopsView> CuDistExportOfResourceStopsQueryDataSource { get; set; } 
        public CuDistExportOfResourceStops Screen { get; set; }
        public CuDistExportOfResourceStopsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistExportOfResourceStopsQueryDataSourceCollectionEditor<CuDistExportOfResourceStopsView>:RPSCollectionEditor<CuDistExportOfResourceStopsView> where CuDistExportOfResourceStopsView : class, IView
    {
        public  CuDistExportOfResourceStopsQueryDataSourceGridView<CuDistExportOfResourceStopsView> GridView {get;set;}
    }
    public partial class CuDistExportOfResourceStopsQueryDataSourceGridView <CuDistExportOfResourceStopsView> :  RPSGridView<CuDistExportOfResourceStopsView> where CuDistExportOfResourceStopsView : class, IView
    {
        public CuDistExportOfResourceStopsQueryDataSourceGridView(CuDistExportOfResourceStopsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StopDate = RPSControlFactory.CreateRPSGridTextBox<CuDistExportOfResourceStopsView>("","#4c3bc0c4-019c-4074-9287-0b08901f582d .ag-row[role='row']@ROWINDEX [col-id='cStopDate']","",false, this.CurrentView);
 
            IDStopType = RPSControlFactory.CreateRPSGridComboBox<CuDistExportOfResourceStopsView>("","#4c3bc0c4-019c-4074-9287-0b08901f582d .ag-row[role='row']@ROWINDEX [col-id='cIDStopType']","",false, this.CurrentView);
 
            CodEmployeeExternal = RPSControlFactory.CreateRPSGridTextBox<CuDistExportOfResourceStopsView>("","#4c3bc0c4-019c-4074-9287-0b08901f582d .ag-row[role='row']@ROWINDEX [col-id='cCodEmployeeExternal']","",false, this.CurrentView);
 
            ExportDate = RPSControlFactory.CreateRPSGridTextBox<CuDistExportOfResourceStopsView>("","#4c3bc0c4-019c-4074-9287-0b08901f582d .ag-row[role='row']@ROWINDEX [col-id='cExportDate']","",false, this.CurrentView);
 
            DeletedDate = RPSControlFactory.CreateRPSGridTextBox<CuDistExportOfResourceStopsView>("","#4c3bc0c4-019c-4074-9287-0b08901f582d .ag-row[role='row']@ROWINDEX [col-id='cDeletedDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistExportOfResourceStopsView> StopDate { get; set; } 
        public IRPSGridComboBox<CuDistExportOfResourceStopsView> IDStopType { get; set; } 
        public IRPSGridTextBox<CuDistExportOfResourceStopsView> CodEmployeeExternal { get; set; } 
        public IRPSGridTextBox<CuDistExportOfResourceStopsView> ExportDate { get; set; } 
        public IRPSGridTextBox<CuDistExportOfResourceStopsView> DeletedDate { get; set; } 
                     
    }
 
    }
  
    

}
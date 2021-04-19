    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.InspectionFrequency
{
    //RPS VERSION 1.0.0.0
    public partial class InspectionFrequency:Screen
    {
        public InspectionFrequency():base()
        {
            this.URL = "quality.inspectionfrequency";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InspectionFrecuencyVMQueryView  = new InspectionFrecuencyVMQueryView(this); 
            InspectionFrecuencyVMEntityView  = new InspectionFrecuencyVMEntityView(this); 
            InspectionFrecuencyVMQueryView.InitializeControls(); 
            InspectionFrecuencyVMEntityView.InitializeControls(); 
           
        }
      
            public InspectionFrecuencyVMQueryView InspectionFrecuencyVMQueryView {get; set; } 
            public InspectionFrecuencyVMEntityView InspectionFrecuencyVMEntityView {get; set; } 
    }
            
    public partial class InspectionFrecuencyVMQueryView : View
    {
        public InspectionFrecuencyVMQueryView(InspectionFrequency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView>( this,Screen.InspectionFrecuencyVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<InspectionFrecuencyVMQueryView>( this);
 
            Article = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMQueryView>("39de23be-99eb-4786-9955-f4ff68ce991a","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMQueryView>("a1a41397-1b10-43ea-a3d3-28398e66a92b","","",false, this);
 
            SupplierRankingTable = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMQueryView>("80c48a6d-c06b-4247-a7f1-a85c098b6ab7","","",false, this);
 
            CollectionInit params_InspectionFrecuencyQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="408194f1-453d-49ad-a9be-8ebcbc8a4de1",CSSSelectorGrid="",XPathGrid=""};
            InspectionFrecuencyQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InspectionFrecuencyQueryCollectionEditor<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView>,InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView>( params_InspectionFrecuencyQuery,this,Screen.InspectionFrecuencyVMEntityView);
 

        }
        public IRPSButton<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> NewButton { get; set; } 
        public IRPSButton<InspectionFrecuencyVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMQueryView> Article { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMQueryView> Supplier { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMQueryView> SupplierRankingTable { get; set; } 
        public InspectionFrecuencyQueryCollectionEditor<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> InspectionFrecuencyQuery { get; set; } 
        public InspectionFrequency Screen { get; set; }
        public InspectionFrecuencyVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InspectionFrecuencyQueryCollectionEditor<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView>:RPSCollectionEditor<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> where InspectionFrecuencyVMQueryView : class, IView where InspectionFrecuencyVMEntityView : class, IView
    {
        public  InspectionFrecuencyQueryGridView<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> GridView {get;set;}
    }
    public partial class InspectionFrecuencyQueryGridView <InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> :  RPSGridView<InspectionFrecuencyVMQueryView,InspectionFrecuencyVMEntityView> where InspectionFrecuencyVMQueryView : class, IView where InspectionFrecuencyVMEntityView : class, IView
    {
        public InspectionFrecuencyQueryGridView(InspectionFrecuencyVMQueryView currentView,InspectionFrecuencyVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InspectionFrecuency_RecepFrecuency = RPSControlFactory.CreateRPSGridFormattedTextBox<InspectionFrecuencyVMQueryView>("","#408194f1-453d-49ad-a9be-8ebcbc8a4de1 .ag-row[role='row']@ROWINDEX [col-id='cInspectionFrecuency_RecepFrecuency']","",false, this.CurrentView);
 
            InspectionFrecuency_TimeFrecuency = RPSControlFactory.CreateRPSGridFormattedTextBox<InspectionFrecuencyVMQueryView>("","#408194f1-453d-49ad-a9be-8ebcbc8a4de1 .ag-row[role='row']@ROWINDEX [col-id='cInspectionFrecuency_TimeFrecuency']","",false, this.CurrentView);
 
            InspectionFrecuency_TimeUnit = RPSControlFactory.CreateRPSGridTextBox<InspectionFrecuencyVMQueryView>("","#408194f1-453d-49ad-a9be-8ebcbc8a4de1 .ag-row[role='row']@ROWINDEX [col-id='cInspectionFrecuency_TimeUnit']","",false, this.CurrentView);
 
            InspectionFrecuency_CalendarType = RPSControlFactory.CreateRPSGridTextBox<InspectionFrecuencyVMQueryView>("","#408194f1-453d-49ad-a9be-8ebcbc8a4de1 .ag-row[role='row']@ROWINDEX [col-id='cInspectionFrecuency_CalendarType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InspectionFrecuencyVMQueryView> InspectionFrecuency_RecepFrecuency { get; set; } 
        public IRPSGridTextBox<InspectionFrecuencyVMQueryView> InspectionFrecuency_TimeFrecuency { get; set; } 
        public IRPSGridTextBox<InspectionFrecuencyVMQueryView> InspectionFrecuency_TimeUnit { get; set; } 
        public IRPSGridTextBox<InspectionFrecuencyVMQueryView> InspectionFrecuency_CalendarType { get; set; } 
                     
    }
 
    }
  
            
    public partial class InspectionFrecuencyVMEntityView : View
    {
        public InspectionFrecuencyVMEntityView(InspectionFrequency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InspectionFrecuencyVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InspectionFrecuencyVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InspectionFrecuencyVMEntityView,InspectionFrecuencyVMQueryView>( this,Screen.InspectionFrecuencyVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<InspectionFrecuencyVMEntityView,InspectionFrecuencyVMQueryView>( this,Screen.InspectionFrecuencyVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMEntityView>("c8392afb-f9d2-4ce8-be8b-6e87af8ab322","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMEntityView>("55af9f9d-a467-42f5-8de4-37cb6eab4ef1","","",false, this);
 
            IDSupplierRankingTable = RPSControlFactory.CreateRPSComboBox<InspectionFrecuencyVMEntityView>("eb4731ee-8143-4049-a988-14a7b2b352bf","","",false, this);
 
            RecepFrecuency = RPSControlFactory.CreateRPSFormattedTextBox<InspectionFrecuencyVMEntityView>("1a6225ff-cede-4f8f-a435-6ab52d42d6f4","","",true, this);
 
            TimeFrecuency = RPSControlFactory.CreateRPSFormattedTextBox<InspectionFrecuencyVMEntityView>("f9cb372b-8177-4eae-ada3-f2c432c1e624","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<InspectionFrecuencyVMEntityView>("83f05f14-df4f-4e5f-87fc-b48ffe54fffd","","",true, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<InspectionFrecuencyVMEntityView>("c1c951ec-65cd-494e-8afd-9075d25b9f92","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<InspectionFrecuencyVMEntityView>("f002e05d-7570-4c79-8d70-b7f6dfa4b276","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<InspectionFrecuencyVMEntityView>( "","ul li[rpsid='0c9f81e5-85c9-44e6-b4f1-f2adbc69ddac']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<InspectionFrecuencyVMEntityView>( "","ul li[rpsid='e52182e4-6646-4744-9841-e4dcf76e49db']","",this);
 

        }
        public IRPSSaveButton<InspectionFrecuencyVMEntityView> SaveButton { get; set; } 
        public IRPSButton<InspectionFrecuencyVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<InspectionFrecuencyVMEntityView,InspectionFrecuencyVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InspectionFrecuencyVMEntityView,InspectionFrecuencyVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMEntityView> IDSupplierRankingTable { get; set; } 
        public IRPSTextBox<InspectionFrecuencyVMEntityView> RecepFrecuency { get; set; } 
        public IRPSTextBox<InspectionFrecuencyVMEntityView> TimeFrecuency { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMEntityView> TimeUnit { get; set; } 
        public IRPSComboBox<InspectionFrecuencyVMEntityView> CalendarType { get; set; } 
        public IRPSTextBox<InspectionFrecuencyVMEntityView> Comments { get; set; } 
        public IRPSSection<InspectionFrecuencyVMEntityView> Section { get; set; } 
        public IRPSSection<InspectionFrecuencyVMEntityView> Section1 { get; set; } 
        public InspectionFrequency Screen { get; set; }
        public InspectionFrecuencyVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
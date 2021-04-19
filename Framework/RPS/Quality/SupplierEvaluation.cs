    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SupplierEvaluation
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierEvaluation:Screen
    {
        public SupplierEvaluation():base()
        {
            this.URL = "quality.supplierevaluation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierEvaluationCollectionView  = new SupplierEvaluationCollectionView(this); 
            SupplierEvaluationEntityView  = new SupplierEvaluationEntityView(this); 
            CalculateEvaluationsChildDialogView  = new CalculateEvaluationsChildDialogView(this); 
            ReportChildDialogView  = new ReportChildDialogView(this); 
            PrintMassiveDialogView  = new PrintMassiveDialogView(this); 
            SupplierEvaluationCollectionView.InitializeControls(); 
            SupplierEvaluationEntityView.InitializeControls(); 
            CalculateEvaluationsChildDialogView.InitializeControls(); 
            ReportChildDialogView.InitializeControls(); 
            PrintMassiveDialogView.InitializeControls(); 
           
        }
      
            public SupplierEvaluationCollectionView SupplierEvaluationCollectionView {get; set; } 
            public SupplierEvaluationEntityView SupplierEvaluationEntityView {get; set; } 
            public CalculateEvaluationsChildDialogView CalculateEvaluationsChildDialogView {get; set; } 
            public ReportChildDialogView ReportChildDialogView {get; set; } 
            public PrintMassiveDialogView PrintMassiveDialogView {get; set; } 
    }
            
    public partial class SupplierEvaluationCollectionView : View
    {
        public SupplierEvaluationCollectionView(SupplierEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierEvaluationCollectionView,SupplierEvaluationEntityView>( this,Screen.SupplierEvaluationEntityView);
 
            CalculateEvaluationsChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierEvaluationCollectionView,CalculateEvaluationsChildDialogView>("029e6f12-9fb2-49c3-990e-2c06984a87b0","","", this,Screen.CalculateEvaluationsChildDialogView);
 
            PrintSupplierEvaluationMassiveCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierEvaluationCollectionView,PrintMassiveDialogView>("e83ae9e5-b9e4-457f-9562-7baec204e842","","", this,Screen.PrintMassiveDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "83887641-6f80-49c2-8b26-d37b36655625",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierEvaluationCollectionView,SupplierEvaluationEntityView>( params_MainConsult,this,Screen.SupplierEvaluationEntityView);
 

        }
        public IRPSButton<SupplierEvaluationCollectionView,SupplierEvaluationEntityView> NewButton { get; set; } 
        public IRPSButton<SupplierEvaluationCollectionView,CalculateEvaluationsChildDialogView> CalculateEvaluationsChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierEvaluationCollectionView,PrintMassiveDialogView> PrintSupplierEvaluationMassiveCommandButton { get; set; } 
        public IRPSCollectionEditor<SupplierEvaluationCollectionView,SupplierEvaluationEntityView> MainConsult { get; set; } 
        public SupplierEvaluation Screen { get; set; }
        public SupplierEvaluationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEvaluationEntityView : View
    {
        public SupplierEvaluationEntityView(SupplierEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierEvaluationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEvaluationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEvaluationEntityView,SupplierEvaluationCollectionView>( this,Screen.SupplierEvaluationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEvaluationEntityView,SupplierEvaluationCollectionView>( this,Screen.SupplierEvaluationCollectionView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierEvaluationEntityView>("c3f8c504-8d99-498c-9dee-58a75e76debd","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SupplierEvaluationEntityView>("7e7aeaf5-5f30-4429-b688-3fd5929e0804","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SupplierEvaluationEntityView>("10ab9477-d9d7-4c0d-995e-6f8e6a56ed29","","",true, this);
 
            EvaluationDate = RPSControlFactory.CreateRPSTextBox<SupplierEvaluationEntityView>("3d73a4aa-94c5-4479-a2c6-0deeb17f7181","","",true, this);
 
            RatingService = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEvaluationEntityView>("a55fc085-6a46-41cc-a332-eebd26edbb08","","",true, this);
 
            RankingCodeService = RPSControlFactory.CreateRPSTextBox<SupplierEvaluationEntityView>("f23082b9-3184-441c-a345-11df47afbf54","","",true, this);
 
            RatingDelivery = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEvaluationEntityView>("ff01df53-0466-430e-a835-28c62ddccd60","","",true, this);
 
            RankingCodeDelivery = RPSControlFactory.CreateRPSTextBox<SupplierEvaluationEntityView>("5dc51f69-f9f4-4407-804e-b735efc8a3c3","","",true, this);
 
            ExecuteUpdateSupplierValuationButton = RPSControlFactory.CreateRPSButton<SupplierEvaluationEntityView>( "f0e66e29-3739-4c76-8b44-7009fa15460d","","",this);
 
            ReportChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierEvaluationEntityView,ReportChildDialogView>("ef60c065-71bc-44f8-a047-f236da52a05f","","", this,Screen.ReportChildDialogView);
 
            CollectionInit params_SupplierEvaluationDeliveryDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4c9ed1f6-add2-4145-a724-13c278416e7d",CSSSelectorGrid="",XPathGrid=""};
            SupplierEvaluationDeliveryDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierEvaluationDeliveryDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView>,SupplierEvaluationEntityView,ReportChildDialogView>( params_SupplierEvaluationDeliveryDetails,this,Screen.ReportChildDialogView);
 
            CollectionInit params_SupplierEvaluationServiceDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db72c06b-bd09-4980-a2f7-d9738483e667",CSSSelectorGrid="",XPathGrid=""};
            SupplierEvaluationServiceDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierEvaluationServiceDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView>,SupplierEvaluationEntityView,ReportChildDialogView>( params_SupplierEvaluationServiceDetails,this,Screen.ReportChildDialogView);
 

        }
        public IRPSSaveButton<SupplierEvaluationEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEvaluationEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEvaluationEntityView,SupplierEvaluationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEvaluationEntityView,SupplierEvaluationCollectionView> BackButton { get; set; } 
        public IRPSComboBox<SupplierEvaluationEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> DateFrom { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> DateTo { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> EvaluationDate { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> RatingService { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> RankingCodeService { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> RatingDelivery { get; set; } 
        public IRPSTextBox<SupplierEvaluationEntityView> RankingCodeDelivery { get; set; } 
        public IRPSButton<SupplierEvaluationEntityView> ExecuteUpdateSupplierValuationButton { get; set; } 
        public IRPSButton<SupplierEvaluationEntityView,ReportChildDialogView> ReportChildNavigationCommandButton { get; set; } 
        public SupplierEvaluationDeliveryDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView> SupplierEvaluationDeliveryDetails { get; set; } 
        public SupplierEvaluationServiceDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView> SupplierEvaluationServiceDetails { get; set; } 
        public SupplierEvaluation Screen { get; set; }
        public SupplierEvaluationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierEvaluationDeliveryDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView>:RPSCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView> where SupplierEvaluationEntityView : class, IView where ReportChildDialogView : class, IView
    {
        public  SupplierEvaluationDeliveryDetailsGridView<SupplierEvaluationEntityView,ReportChildDialogView> GridView {get;set;}
    }
    public partial class SupplierEvaluationDeliveryDetailsGridView <SupplierEvaluationEntityView,ReportChildDialogView> :  RPSGridView<SupplierEvaluationEntityView,ReportChildDialogView> where SupplierEvaluationEntityView : class, IView where ReportChildDialogView : class, IView
    {
        public SupplierEvaluationDeliveryDetailsGridView(SupplierEvaluationEntityView currentView,ReportChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEvaluationEntityView>("","#4c9ed1f6-add2-4145-a724-13c278416e7d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            NumOfReceptions = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierEvaluationEntityView>("","#4c9ed1f6-add2-4145-a724-13c278416e7d .ag-row[role='row']@ROWINDEX [col-id='cNumOfReceptions']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEvaluationEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEvaluationEntityView> NumOfReceptions { get; set; } 
                     
    }
 
        public partial class SupplierEvaluationServiceDetailsCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView>:RPSCollectionEditor<SupplierEvaluationEntityView,ReportChildDialogView> where SupplierEvaluationEntityView : class, IView where ReportChildDialogView : class, IView
    {
        public  SupplierEvaluationServiceDetailsGridView<SupplierEvaluationEntityView,ReportChildDialogView> GridView {get;set;}
    }
    public partial class SupplierEvaluationServiceDetailsGridView <SupplierEvaluationEntityView,ReportChildDialogView> :  RPSGridView<SupplierEvaluationEntityView,ReportChildDialogView> where SupplierEvaluationEntityView : class, IView where ReportChildDialogView : class, IView
    {
        public SupplierEvaluationServiceDetailsGridView(SupplierEvaluationEntityView currentView,ReportChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEvaluationEntityView>("","#db72c06b-bd09-4980-a2f7-d9738483e667 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            NumOfReceptions = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierEvaluationEntityView>("","#db72c06b-bd09-4980-a2f7-d9738483e667 .ag-row[role='row']@ROWINDEX [col-id='cNumOfReceptions']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEvaluationEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEvaluationEntityView> NumOfReceptions { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalculateEvaluationsChildDialogView : View
    {
        public CalculateEvaluationsChildDialogView(SupplierEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<CalculateEvaluationsChildDialogView>("c8315ade-f91c-434a-8550-3c7fc0f1cbdb","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CalculateEvaluationsChildDialogView>("ab59883b-9b0b-4b17-bc7b-d1f7cf48fadb","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CalculateEvaluationsChildDialogView>("971d3fe6-da98-4345-b77b-b092eeb77d2e","","",false, this);
 
            SupplierRankingDelivery = RPSControlFactory.CreateRPSCollectionComboBox<CalculateEvaluationsChildDialogView>("56765361-7b63-455c-ab6b-366c80e73f02","","",false, this);
 
            SupplierRankingService = RPSControlFactory.CreateRPSCollectionComboBox<CalculateEvaluationsChildDialogView>("7439a798-ec01-4a24-943b-735cbd04c490","","",false, this);
 
            CollectionInit params_RetrieveSupplierEvaluationsTemp = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96a8280e-4378-48f7-afca-0e661fb8b2c8",CSSSelectorGrid="",XPathGrid=""};
            RetrieveSupplierEvaluationsTemp = RPSControlFactory.RPSCreateCollectionWithGrid<RetrieveSupplierEvaluationsTempCollectionEditor<CalculateEvaluationsChildDialogView>,CalculateEvaluationsChildDialogView>( params_RetrieveSupplierEvaluationsTemp,this);
 

        }
        public IRPSCollectionComboBox<CalculateEvaluationsChildDialogView> Supplier { get; set; } 
        public IRPSTextBox<CalculateEvaluationsChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<CalculateEvaluationsChildDialogView> DateTo { get; set; } 
        public IRPSCollectionComboBox<CalculateEvaluationsChildDialogView> SupplierRankingDelivery { get; set; } 
        public IRPSCollectionComboBox<CalculateEvaluationsChildDialogView> SupplierRankingService { get; set; } 
        public RetrieveSupplierEvaluationsTempCollectionEditor<CalculateEvaluationsChildDialogView> RetrieveSupplierEvaluationsTemp { get; set; } 
        public SupplierEvaluation Screen { get; set; }
        public CalculateEvaluationsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RetrieveSupplierEvaluationsTempCollectionEditor<CalculateEvaluationsChildDialogView>:RPSCollectionEditor<CalculateEvaluationsChildDialogView> where CalculateEvaluationsChildDialogView : class, IView
    {
        public  RetrieveSupplierEvaluationsTempGridView<CalculateEvaluationsChildDialogView> GridView {get;set;}
    }
    public partial class RetrieveSupplierEvaluationsTempGridView <CalculateEvaluationsChildDialogView> :  RPSGridView<CalculateEvaluationsChildDialogView> where CalculateEvaluationsChildDialogView : class, IView
    {
        public RetrieveSupplierEvaluationsTempGridView(CalculateEvaluationsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EvaluationDate = RPSControlFactory.CreateRPSGridTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cEvaluationDate']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            RatingService = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cRatingService']","",false, this.CurrentView);
 
            RankingCodeService = RPSControlFactory.CreateRPSGridTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cRankingCodeService']","",false, this.CurrentView);
 
            RatingDelivery = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cRatingDelivery']","",false, this.CurrentView);
 
            RankingCodeDelivery = RPSControlFactory.CreateRPSGridTextBox<CalculateEvaluationsChildDialogView>("","#96a8280e-4378-48f7-afca-0e661fb8b2c8 .ag-row[role='row']@ROWINDEX [col-id='cRankingCodeDelivery']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> EvaluationDate { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> DateFrom { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> DateTo { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> RatingService { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> RankingCodeService { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> RatingDelivery { get; set; } 
        public IRPSGridTextBox<CalculateEvaluationsChildDialogView> RankingCodeDelivery { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReportChildDialogView : View
    {
        public ReportChildDialogView(SupplierEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierLanguage = RPSControlFactory.CreateRPSOption<ReportChildDialogView>( "93a3b69d-99b4-49c4-bf4a-f95ac203af5a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<ReportChildDialogView>( "3b99e97c-6694-4af0-89ed-fe70b0061c7a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<ReportChildDialogView>("74b00122-e12e-4583-9517-d0d912383dd3","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<ReportChildDialogView>("c20e1889-adf0-4d27-a4b8-f1c528316e17","","",false, this);
 
            UIDCustomReport = RPSControlFactory.CreateRPSComboBox<ReportChildDialogView>("871ab567-9fb8-4536-ba40-37569e0ea499","","",false, this);
 
            UIAddAttachments = RPSControlFactory.CreateRPSCheckBox<ReportChildDialogView>("82444e7a-34a5-4234-83be-66dc1005a5b8","","",false, this);
 
            PrintSupplierEvaluationReportCommandButton = RPSControlFactory.CreateRPSButton<ReportChildDialogView>( "c0e0172b-0926-4ace-9c9a-f77f39c8ef35","","",this);
 
            ExecuteSupplierEvaluationReportByEMailCommandButton = RPSControlFactory.CreateRPSButton<ReportChildDialogView>( "5450f4f0-c79e-44fc-b615-6d46e9adb89f","","",this);
 
            PrintSupplierEvaluationByClientEmailCommandButton = RPSControlFactory.CreateRPSButton<ReportChildDialogView>( "878dd399-2136-483e-b285-0e139708221e","","",this);
 

        }
        public IRPSOption<ReportChildDialogView> SupplierLanguage { get; set; } 
        public IRPSOption<ReportChildDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<ReportChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<ReportChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<ReportChildDialogView> UIDCustomReport { get; set; } 
        public IRPSCheckbox<ReportChildDialogView> UIAddAttachments { get; set; } 
        public IRPSButton<ReportChildDialogView> PrintSupplierEvaluationReportCommandButton { get; set; } 
        public IRPSButton<ReportChildDialogView> ExecuteSupplierEvaluationReportByEMailCommandButton { get; set; } 
        public IRPSButton<ReportChildDialogView> PrintSupplierEvaluationByClientEmailCommandButton { get; set; } 
        public SupplierEvaluation Screen { get; set; }
        public ReportChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintMassiveDialogView : View
    {
        public PrintMassiveDialogView(SupplierEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierLanguage = RPSControlFactory.CreateRPSOption<PrintMassiveDialogView>( "821366b9-6a85-4c55-a060-df9fc3cc5a7f","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<PrintMassiveDialogView>( "b40185db-f57a-4378-a741-0ea8bf6851f4","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintMassiveDialogView>("5d56e2fc-2d5f-49c5-80eb-e0b5798f98a5","","",false, this);
 
            UIDCustomReport = RPSControlFactory.CreateRPSComboBox<PrintMassiveDialogView>("d35d33e4-e893-4917-adae-1549d4904c3c","","",false, this);
 
            UIAddAttachments = RPSControlFactory.CreateRPSCheckBox<PrintMassiveDialogView>("85818848-9698-4183-a931-d518421c659d","","",false, this);
 
            UseClientConfigurationEmail = RPSControlFactory.CreateRPSCheckBox<PrintMassiveDialogView>("af31b687-7096-49cd-b037-09b0b97447a5","","",false, this);
 
            UINumberOfCopies = RPSControlFactory.CreateRPSFormattedTextBox<PrintMassiveDialogView>("5c39b633-84ea-47e7-ae97-c37b04ffad42","","",false, this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<PrintMassiveDialogView>( "b6d2d15a-df55-4d89-b510-cf8eed0c960b","","",this);
 
            EmailCommandButton = RPSControlFactory.CreateRPSButton<PrintMassiveDialogView>( "912d9540-7f05-4bc7-8e36-9677b80cfacd","","",this);
 

        }
        public IRPSOption<PrintMassiveDialogView> SupplierLanguage { get; set; } 
        public IRPSOption<PrintMassiveDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<PrintMassiveDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSComboBox<PrintMassiveDialogView> UIDCustomReport { get; set; } 
        public IRPSCheckbox<PrintMassiveDialogView> UIAddAttachments { get; set; } 
        public IRPSCheckbox<PrintMassiveDialogView> UseClientConfigurationEmail { get; set; } 
        public IRPSTextBox<PrintMassiveDialogView> UINumberOfCopies { get; set; } 
        public IRPSButton<PrintMassiveDialogView> PrintCommandButton { get; set; } 
        public IRPSButton<PrintMassiveDialogView> EmailCommandButton { get; set; } 
        public SupplierEvaluation Screen { get; set; }
        public PrintMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
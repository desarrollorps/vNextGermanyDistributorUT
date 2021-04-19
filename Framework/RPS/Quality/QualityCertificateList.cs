    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.QualityCertificateList
{
    //RPS VERSION 1.0.0.0
    public partial class QualityCertificateList:Screen
    {
        public QualityCertificateList():base()
        {
            this.URL = "quality.qualitycertificatelist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualityCertificateListView  = new QualityCertificateListView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            QualityCertificateListView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public QualityCertificateListView QualityCertificateListView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class QualityCertificateListView : View
    {
        public QualityCertificateListView(QualityCertificateList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<QualityCertificateListView>("c1850657-bd37-4672-bf27-7d672e7d191f","","",false, this);
 
            DeliveryNoteSL = RPSControlFactory.CreateRPSCollectionComboBox<QualityCertificateListView>("a5fddd99-0635-438c-a591-1821fa1b58c0","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<QualityCertificateListView>("94c58cdc-dfc0-475d-94e9-82da6182c4a8","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<QualityCertificateListView>("78c3997e-858b-4a24-89c3-e0a8ea1736ae","","",false, this);
 
            UIAttachDocuments = RPSControlFactory.CreateRPSCheckBox<QualityCertificateListView>("2a5549d7-614f-40bb-9cfa-de4cc5e4c10b","","",false, this);
 
            UseClientEmailConfiguration = RPSControlFactory.CreateRPSCheckBox<QualityCertificateListView>("eb731620-cae3-4c9e-b95e-2d59997e66b2","","",false, this);
 
            ReportCommand = RPSControlFactory.CreateRPSButton<QualityCertificateListView>( "49f73ed2-2a54-4fec-a80c-fb6db1f03176","","",this);
 
            EmailChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<QualityCertificateListView,EmailChildDialogView>("da0c70c3-e13e-4616-861f-e4711ff3855e","","", this,Screen.EmailChildDialogView);
 

        }
        public IRPSComboBox<QualityCertificateListView> Site { get; set; } 
        public IRPSCollectionComboBox<QualityCertificateListView> DeliveryNoteSL { get; set; } 
        public IRPSCollectionComboBox<QualityCertificateListView> Article { get; set; } 
        public IRPSComboBox<QualityCertificateListView> CustomReport { get; set; } 
        public IRPSCheckbox<QualityCertificateListView> UIAttachDocuments { get; set; } 
        public IRPSCheckbox<QualityCertificateListView> UseClientEmailConfiguration { get; set; } 
        public IRPSButton<QualityCertificateListView> ReportCommand { get; set; } 
        public IRPSButton<QualityCertificateListView,EmailChildDialogView> EmailChildNavigationCommand { get; set; } 
        public QualityCertificateList Screen { get; set; }
        public QualityCertificateListView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(QualityCertificateList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ControlSheetVersionQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58eee228-aac4-43ee-801f-c8dd3da7f673",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetVersionQuery = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetVersionQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_ControlSheetVersionQuery,this);
 

        }
        public ControlSheetVersionQueryCollectionEditor<EmailChildDialogView> ControlSheetVersionQuery { get; set; } 
        public QualityCertificateList Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetVersionQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  ControlSheetVersionQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class ControlSheetVersionQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public ControlSheetVersionQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#58eee228-aac4-43ee-801f-c8dd3da7f673 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> Date { get; set; } 
                     
    }
 
    }
  
    

}
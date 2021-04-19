    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PackingListPrint
{
    //RPS VERSION 1.0.0.0
    public partial class PackingListPrint:Screen
    {
        public PackingListPrint():base()
        {
            this.URL = "sales.packinglistprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PackingListPrintQueryView  = new PackingListPrintQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            PackingListPrintQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public PackingListPrintQueryView PackingListPrintQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class PackingListPrintQueryView : View
    {
        public PackingListPrintQueryView(PackingListPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<PackingListPrintQueryView>("bae6f45f-a839-46cb-9f35-e1717eaed4f9","","",false, this);
 
            UIPackingListFrom = RPSControlFactory.CreateRPSComboBox<PackingListPrintQueryView>("841937f2-b905-4229-96b1-00bb650e5e56","","",false, this);
 
            UIPackingListTo = RPSControlFactory.CreateRPSComboBox<PackingListPrintQueryView>("1e9c4e02-30be-4d61-b7e1-28402cf20002","","",false, this);
 
            UIDateTimeFrom = RPSControlFactory.CreateRPSTextBox<PackingListPrintQueryView>("ff312a7a-14ff-4464-bbe2-ed670594f9fe","","",false, this);
 
            UIDateTimeTo = RPSControlFactory.CreateRPSTextBox<PackingListPrintQueryView>("2e8a3674-b28f-4dc4-97a9-ec02fdd1624b","","",false, this);
 
            UIOnlyNotFinishedPackingList = RPSControlFactory.CreateRPSCheckBox<PackingListPrintQueryView>("ee9578d3-a2a6-414d-b097-aa29ad2df021","","",false, this);
 
            UIFinishPackingList = RPSControlFactory.CreateRPSCheckBox<PackingListPrintQueryView>("847b5afd-18a9-468c-a6f3-0c2af05d6f02","","",false, this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<PackingListPrintQueryView>( "f36e5f07-4c74-4817-b82d-a7da13aa2a6a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<PackingListPrintQueryView>( "c2935319-c1a9-4b97-9029-60f91fe64bc8","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PackingListPrintQueryView>("0612cdfe-b45b-4d8f-8db0-68b9e682fea6","","",false, this);
 
            UIOptByLabelNumber = RPSControlFactory.CreateRPSOption<PackingListPrintQueryView>( "2be08633-774a-413e-88d7-2714805c61c9","","",this);
 
            UIOptByLabel = RPSControlFactory.CreateRPSOption<PackingListPrintQueryView>( "0d172824-0c71-4ef3-83b0-5b6beaf3c79d","","",this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PackingListPrintQueryView>("ac0f2aaf-4683-44a4-9be8-8d759c11b048","","",false, this);
 
            UICodPackingListReport = RPSControlFactory.CreateRPSComboBox<PackingListPrintQueryView>("73455de7-6b80-4659-839b-056dbce11d2d","","",false, this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<PackingListPrintQueryView>("10081b4a-3dd9-42c3-91d8-841a9c240166","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PackingListPrintQueryView,EmailChildDialogView>("ecf0eea4-687a-45a1-93e9-c0522a481241","","", this,Screen.EmailChildDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<PackingListPrintQueryView>( "a5c51da4-264a-4e1b-9672-08fdbb81b62e","","",this);
 
            CollectionInit params_PackingListReprintPrintableQuery = new CollectionInit(){IDDescriptor = "78b485c5-5225-45d3-adf5-e84c33351a6c",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bd36445e-4cdb-4258-bcbd-f8db7a51e70a",CSSSelectorGrid="",XPathGrid=""};
            PackingListReprintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListReprintPrintableQueryCollectionEditor<PackingListPrintQueryView,EmailChildDialogView>,PackingListPrintQueryView,EmailChildDialogView>( params_PackingListReprintPrintableQuery,this,Screen.EmailChildDialogView);
 

        }
        public IRPSCollectionComboBox<PackingListPrintQueryView> UILstCustomer { get; set; } 
        public IRPSComboBox<PackingListPrintQueryView> UIPackingListFrom { get; set; } 
        public IRPSComboBox<PackingListPrintQueryView> UIPackingListTo { get; set; } 
        public IRPSTextBox<PackingListPrintQueryView> UIDateTimeFrom { get; set; } 
        public IRPSTextBox<PackingListPrintQueryView> UIDateTimeTo { get; set; } 
        public IRPSCheckbox<PackingListPrintQueryView> UIOnlyNotFinishedPackingList { get; set; } 
        public IRPSCheckbox<PackingListPrintQueryView> UIFinishPackingList { get; set; } 
        public IRPSOption<PackingListPrintQueryView> CustomerLanguage { get; set; } 
        public IRPSOption<PackingListPrintQueryView> SelectedLanguage { get; set; } 
        public IRPSComboBox<PackingListPrintQueryView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<PackingListPrintQueryView> UIOptByLabelNumber { get; set; } 
        public IRPSOption<PackingListPrintQueryView> UIOptByLabel { get; set; } 
        public IRPSCheckbox<PackingListPrintQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PackingListPrintQueryView> UICodPackingListReport { get; set; } 
        public IRPSCheckbox<PackingListPrintQueryView> UIClientMail { get; set; } 
        public IRPSButton<PackingListPrintQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public IRPSButton<PackingListPrintQueryView> ReportCommandButton { get; set; } 
        public PackingListReprintPrintableQueryCollectionEditor<PackingListPrintQueryView,EmailChildDialogView> PackingListReprintPrintableQuery { get; set; } 
        public PackingListPrint Screen { get; set; }
        public PackingListPrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListReprintPrintableQueryCollectionEditor<PackingListPrintQueryView,EmailChildDialogView>:RPSCollectionEditor<PackingListPrintQueryView,EmailChildDialogView> where PackingListPrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public  PackingListReprintPrintableQueryGridView<PackingListPrintQueryView,EmailChildDialogView> GridView {get;set;}
    }
    public partial class PackingListReprintPrintableQueryGridView <PackingListPrintQueryView,EmailChildDialogView> :  RPSGridView<PackingListPrintQueryView,EmailChildDialogView> where PackingListPrintQueryView : class, IView where EmailChildDialogView : class, IView
    {
        public PackingListReprintPrintableQueryGridView(PackingListPrintQueryView currentView,EmailChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PackingListSL_PackingDate = RPSControlFactory.CreateRPSGridTextBox<PackingListPrintQueryView>("","#bd36445e-4cdb-4258-bcbd-f8db7a51e70a .ag-row[role='row']@ROWINDEX [col-id='cPackingListSL_PackingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PackingListPrintQueryView> PackingListSL_PackingDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(PackingListPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_PackingListReprintPrintableQuery = new CollectionInit(){IDDescriptor = "96a2dd93-1a47-4015-9b8d-96e7bfab6bbf",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0d2e7868-a5f6-4109-a26d-64081bc1556a",CSSSelectorGrid="",XPathGrid=""};
            PackingListReprintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListReprintPrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_PackingListReprintPrintableQuery,this);
 

        }
        public PackingListReprintPrintableQueryCollectionEditor<EmailChildDialogView> PackingListReprintPrintableQuery { get; set; } 
        public PackingListPrint Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListReprintPrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  PackingListReprintPrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class PackingListReprintPrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public PackingListReprintPrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PackingListSL_PackingDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#0d2e7868-a5f6-4109-a26d-64081bc1556a .ag-row[role='row']@ROWINDEX [col-id='cPackingListSL_PackingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> PackingListSL_PackingDate { get; set; } 
                     
    }
 
    }
  
    

}
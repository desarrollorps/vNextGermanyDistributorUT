    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderList
{
    //RPS VERSION 1.0.0.0
    public partial class OrderList:Screen
    {
        public OrderList():base()
        {
            this.URL = "purchase.orderlist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderListQueryView  = new OrderListQueryView(this); 
            EmailChildDialogView  = new EmailChildDialogView(this); 
            OrderListQueryView.InitializeControls(); 
            EmailChildDialogView.InitializeControls(); 
           
        }
      
            public OrderListQueryView OrderListQueryView {get; set; } 
            public EmailChildDialogView EmailChildDialogView {get; set; } 
    }
            
    public partial class OrderListQueryView : View
    {
        public OrderListQueryView(OrderList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<OrderListQueryView>("d6834c00-11a2-45ef-84b2-2c578bb6cb2b","","",false, this);
 
            UIOrderFrom = RPSControlFactory.CreateRPSComboBox<OrderListQueryView>("549401a5-b9f2-46be-a217-56d7ffb0fb58","","",false, this);
 
            UIOrderTo = RPSControlFactory.CreateRPSComboBox<OrderListQueryView>("8f275323-5167-41b8-b283-dacef700406a","","",false, this);
 
            UIOrderDateFrom = RPSControlFactory.CreateRPSTextBox<OrderListQueryView>("eee70f77-4e14-453b-a397-a910dc283c7f","","",false, this);
 
            UIOrderDateTo = RPSControlFactory.CreateRPSTextBox<OrderListQueryView>("f09aae20-0deb-42f8-bf98-c4ca4cfcf322","","",false, this);
 
            UIAll = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "16458baf-aa84-499a-97c7-498ef3244516","","",this);
 
            UIPendingList = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "0d8be3f1-eeb7-4cf3-b358-069349c1364b","","",this);
 
            UIList = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "5948b696-24ff-493e-9644-55bdfdcb727c","","",this);
 
            UIAll1 = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "c1b00fd9-c0e0-4ec2-9124-b8c9345c22ae","","",this);
 
            UIPendingToReceive = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "285ca976-d379-4789-b6f0-ea8bade8ec5c","","",this);
 
            UIOptPendingDelayed = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "a85e8d61-6c03-4387-8799-908a5d701ff2","","",this);
 
            UIOptSupplier = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "ab8bc05c-e72c-4212-bac8-58e78079f252","","",this);
 
            UIOptSelectedLanguage = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "699dbeaa-eed2-4afe-add5-fd4f6e9d1c51","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<OrderListQueryView>("9b5a6da8-9e3a-4cb7-9cc9-0e785b1fdba5","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("9fdf9dbe-ca6d-4fa8-a0e6-3c884c85dee5","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<OrderListQueryView>("743d8508-b68c-4793-967f-1419b6f4ec22","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("45a921dd-90d3-45b5-806b-755ffc47290f","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("cb6ebc1a-f945-4bd6-9c29-b5a0394c5098","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "5449613e-30b2-4752-97ac-e59076fd9d46","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "64ca3b25-3afd-4c74-a0c8-240f3f955ec9","","",this);
 
            UIDocumentsOrder = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("7d398149-a6fa-4182-8cdb-851774aab6b6","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "b4715937-2b05-4f6c-8c19-1b52e2342144","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "dafada62-f020-4fe8-92c7-96719a75bc91","","",this);
 
            UIDocumentsMaterial = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("79607461-7ace-4b02-9a62-339e41663adc","","",false, this);
 
            UIOptAllDocuments2 = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "dbb9aceb-5ca9-4e57-b6b8-fe91b3628541","","",this);
 
            UIOptByDocument2 = RPSControlFactory.CreateRPSOption<OrderListQueryView>( "09a334e2-09da-4956-8f6f-cf99242e8f54","","",this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<OrderListQueryView>("aa33e90f-1b63-488b-902d-dec52231ee34","","",false, this);
 
            EmailChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderListQueryView,EmailChildDialogView>("c2a114d5-10c1-4de2-ab8f-23729d5fc86a","","", this,Screen.EmailChildDialogView);
 

        }
        public IRPSCollectionComboBox<OrderListQueryView> UILstSupplier { get; set; } 
        public IRPSComboBox<OrderListQueryView> UIOrderFrom { get; set; } 
        public IRPSComboBox<OrderListQueryView> UIOrderTo { get; set; } 
        public IRPSTextBox<OrderListQueryView> UIOrderDateFrom { get; set; } 
        public IRPSTextBox<OrderListQueryView> UIOrderDateTo { get; set; } 
        public IRPSOption<OrderListQueryView> UIAll { get; set; } 
        public IRPSOption<OrderListQueryView> UIPendingList { get; set; } 
        public IRPSOption<OrderListQueryView> UIList { get; set; } 
        public IRPSOption<OrderListQueryView> UIAll1 { get; set; } 
        public IRPSOption<OrderListQueryView> UIPendingToReceive { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptPendingDelayed { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptSupplier { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptSelectedLanguage { get; set; } 
        public IRPSComboBox<OrderListQueryView> Language { get; set; } 
        public IRPSCheckbox<OrderListQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<OrderListQueryView> CustomReport { get; set; } 
        public IRPSCheckbox<OrderListQueryView> bClaim { get; set; } 
        public IRPSCheckbox<OrderListQueryView> UIDocumentsArticle { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptAllDocuments { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<OrderListQueryView> UIDocumentsOrder { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<OrderListQueryView> UIDocumentsMaterial { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptAllDocuments2 { get; set; } 
        public IRPSOption<OrderListQueryView> UIOptByDocument2 { get; set; } 
        public IRPSCheckbox<OrderListQueryView> UIClientMail { get; set; } 
        public IRPSButton<OrderListQueryView,EmailChildDialogView> EmailChildNavigationCommandButton { get; set; } 
        public OrderList Screen { get; set; }
        public OrderListQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmailChildDialogView : View
    {
        public EmailChildDialogView(OrderList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_OrderReprintPrintableQuery = new CollectionInit(){IDDescriptor = "e7791ca5-139f-4f1d-96d7-c9e35b99a190",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="610a04da-0cc1-4c60-8090-2f55024be80a",CSSSelectorGrid="",XPathGrid=""};
            OrderReprintPrintableQuery = RPSControlFactory.RPSCreateCollectionWithGrid<OrderReprintPrintableQueryCollectionEditor<EmailChildDialogView>,EmailChildDialogView>( params_OrderReprintPrintableQuery,this);
 

        }
        public OrderReprintPrintableQueryCollectionEditor<EmailChildDialogView> OrderReprintPrintableQuery { get; set; } 
        public OrderList Screen { get; set; }
        public EmailChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderReprintPrintableQueryCollectionEditor<EmailChildDialogView>:RPSCollectionEditor<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public  OrderReprintPrintableQueryGridView<EmailChildDialogView> GridView {get;set;}
    }
    public partial class OrderReprintPrintableQueryGridView <EmailChildDialogView> :  RPSGridView<EmailChildDialogView> where EmailChildDialogView : class, IView
    {
        public OrderReprintPrintableQueryGridView(EmailChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<EmailChildDialogView>("","#610a04da-0cc1-4c60-8090-2f55024be80a .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmailChildDialogView> Order_OrderDate { get; set; } 
                     
    }
 
    }
  
    

}
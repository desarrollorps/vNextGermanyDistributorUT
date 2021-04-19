    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderPrint
{
    //RPS VERSION 1.0.0.0
    public partial class OrderPrint:Screen
    {
        public OrderPrint():base()
        {
            this.URL = "sales.orderprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderSLPrintQueryView  = new OrderSLPrintQueryView(this); 
            OrderSLPrintQueryView.InitializeControls(); 
           
        }
      
            public OrderSLPrintQueryView OrderSLPrintQueryView {get; set; } 
    }
            
    public partial class OrderSLPrintQueryView : View
    {
        public OrderSLPrintQueryView(OrderPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLPrintQueryView>("bae6f45f-a839-46cb-9f35-e1717eaed4f9","","",false, this);
 
            UIOrderFrom = RPSControlFactory.CreateRPSComboBox<OrderSLPrintQueryView>("571d1db1-27a6-4ad9-a03f-281faa84cc5c","","",false, this);
 
            UIOrderTo = RPSControlFactory.CreateRPSComboBox<OrderSLPrintQueryView>("6c8f250f-0c35-48f0-84b3-1c33cb8d8cef","","",false, this);
 
            UIOrderDateFrom = RPSControlFactory.CreateRPSTextBox<OrderSLPrintQueryView>("d5f2f324-ebd3-47bf-9bce-dc389d130a6e","","",false, this);
 
            UIOrderDateTo = RPSControlFactory.CreateRPSTextBox<OrderSLPrintQueryView>("aced2021-b654-4bf1-a485-f35861ff9ae4","","",false, this);
 
            bArticleDescriptions = RPSControlFactory.CreateRPSCheckBox<OrderSLPrintQueryView>("6979ab49-2b38-4b66-8238-011a92475a82","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "55cd920d-3f78-4026-8ecd-322df749a5d5","","",this);
 
            Language1 = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "4b420fab-0b6f-4555-99e3-28ce76259e8f","","",this);
 
            Language = RPSControlFactory.CreateRPSComboBox<OrderSLPrintQueryView>("24ca8c2f-ce40-4128-81eb-ab11d5d02196","","",false, this);
 
            CustomerCopies = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "17cc37f1-018c-431a-b952-d1036d5eddda","","",this);
 
            Copies = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "0c3dc716-6502-4a3e-bde3-9ecd78567974","","",this);
 
            UINumCopies = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLPrintQueryView>("c326d6d8-3946-4997-a383-2b0a54b739d3","","",false, this);
 
            OrderNumber = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "7ddf835a-914a-4ec7-8e3b-4f4fb7c34b52","","",this);
 
            SpecificOrder = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "b8c3e360-9cec-4348-8100-118d50ed9852","","",this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<OrderSLPrintQueryView>("9fdf9dbe-ca6d-4fa8-a0e6-3c884c85dee5","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<OrderSLPrintQueryView>("743d8508-b68c-4793-967f-1419b6f4ec22","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<OrderSLPrintQueryView>("cb6ebc1a-f945-4bd6-9c29-b5a0394c5098","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "43aac03c-d25b-4033-92f7-2094a4ff7a0e","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "d846cb7c-1244-4d29-8946-418c4ef4b1c3","","",this);
 
            UIDocumentsOrder = RPSControlFactory.CreateRPSCheckBox<OrderSLPrintQueryView>("7d398149-a6fa-4182-8cdb-851774aab6b6","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "df0a125a-4e41-4612-827b-1110aaa217cb","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<OrderSLPrintQueryView>( "527759ec-4515-41c3-a282-be0bc30883aa","","",this);
 
            UIClientMail = RPSControlFactory.CreateRPSCheckBox<OrderSLPrintQueryView>("fc6f581f-63a4-41d7-aea6-9b6ad6c7ced3","","",false, this);
 
            ModalNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderSLPrintQueryView>( "1aa2651c-292e-4af9-95e1-5db55f2f7399","","",this);
 

        }
        public IRPSCollectionComboBox<OrderSLPrintQueryView> UILstCustomer { get; set; } 
        public IRPSComboBox<OrderSLPrintQueryView> UIOrderFrom { get; set; } 
        public IRPSComboBox<OrderSLPrintQueryView> UIOrderTo { get; set; } 
        public IRPSTextBox<OrderSLPrintQueryView> UIOrderDateFrom { get; set; } 
        public IRPSTextBox<OrderSLPrintQueryView> UIOrderDateTo { get; set; } 
        public IRPSCheckbox<OrderSLPrintQueryView> bArticleDescriptions { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> Customer { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> Language1 { get; set; } 
        public IRPSComboBox<OrderSLPrintQueryView> Language { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> CustomerCopies { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> Copies { get; set; } 
        public IRPSTextBox<OrderSLPrintQueryView> UINumCopies { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> OrderNumber { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> SpecificOrder { get; set; } 
        public IRPSCheckbox<OrderSLPrintQueryView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<OrderSLPrintQueryView> CustomReport { get; set; } 
        public IRPSCheckbox<OrderSLPrintQueryView> UIDocumentsArticle { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> UIOptAllDocuments { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<OrderSLPrintQueryView> UIDocumentsOrder { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<OrderSLPrintQueryView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<OrderSLPrintQueryView> UIClientMail { get; set; } 
        public IRPSButton<OrderSLPrintQueryView> ModalNavigationCommandButton { get; set; } 
        public OrderPrint Screen { get; set; }
        public OrderSLPrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.CheckPrint
{
    //RPS VERSION 1.0.0.0
    public partial class CheckPrint:Screen
    {
        public CheckPrint():base()
        {
            this.URL = "receivablepayable.checkprint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CheckPrintQueryView  = new CheckPrintQueryView(this); 
            PrintOptionsChildDialogView  = new PrintOptionsChildDialogView(this); 
            CheckPrintQueryView.InitializeControls(); 
            PrintOptionsChildDialogView.InitializeControls(); 
           
        }
      
            public CheckPrintQueryView CheckPrintQueryView {get; set; } 
            public PrintOptionsChildDialogView PrintOptionsChildDialogView {get; set; } 
    }
            
    public partial class CheckPrintQueryView : View
    {
        public CheckPrintQueryView(CheckPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<CheckPrintQueryView>("d8a02763-3786-4a9b-af58-30fe6d980acf","","",false, this);
 
            CheckNumberFrom = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("4cf26ef2-d619-4806-b1c9-42e6f8f9ecfd","","",false, this);
 
            CheckNumberTo = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("6d9d8366-73f1-4292-bb39-56d504f7d8a3","","",false, this);
 
            CheckDateFrom = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("2ee74cee-b885-4f3c-ba44-a2c299982eb1","","",false, this);
 
            CheckDateTo = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("4f27d90c-a6af-4a34-a294-4e59ed8f78cd","","",false, this);
 
            CheckDueDateFrom = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("c3fd7e51-2c2b-4ee4-8723-900152f838c2","","",false, this);
 
            CheckDueDateTo = RPSControlFactory.CreateRPSTextBox<CheckPrintQueryView>("5a2945b6-c1fc-424f-9c9b-0b9f364beb70","","",false, this);
 
            PrintCheckButton = RPSControlFactory.CreateRPSButton<CheckPrintQueryView>( "0d7ea017-5139-496a-994d-58654205da4c","","",this);
 
            PrintPrommissionNoteButton = RPSControlFactory.CreateRPSButton<CheckPrintQueryView>( "ff4d5d87-9ea9-490f-bbb6-cbdf0114566e","","",this);
 
            CollectionInit params_CheckQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="55492d58-28ee-48e4-bff5-4bc26f3df302",CSSSelectorGrid="",XPathGrid=""};
            CheckQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CheckQueryCollectionEditor<CheckPrintQueryView,PrintOptionsChildDialogView>,CheckPrintQueryView,PrintOptionsChildDialogView>( params_CheckQuery,this,Screen.PrintOptionsChildDialogView);
 

        }
        public IRPSComboBox<CheckPrintQueryView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckNumberFrom { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckNumberTo { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckDateFrom { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckDateTo { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckDueDateFrom { get; set; } 
        public IRPSTextBox<CheckPrintQueryView> CheckDueDateTo { get; set; } 
        public IRPSButton<CheckPrintQueryView> PrintCheckButton { get; set; } 
        public IRPSButton<CheckPrintQueryView> PrintPrommissionNoteButton { get; set; } 
        public CheckQueryCollectionEditor<CheckPrintQueryView,PrintOptionsChildDialogView> CheckQuery { get; set; } 
        public CheckPrint Screen { get; set; }
        public CheckPrintQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CheckQueryCollectionEditor<CheckPrintQueryView,PrintOptionsChildDialogView>:RPSCollectionEditor<CheckPrintQueryView,PrintOptionsChildDialogView> where CheckPrintQueryView : class, IView where PrintOptionsChildDialogView : class, IView
    {
        public  CheckQueryGridView<CheckPrintQueryView,PrintOptionsChildDialogView> GridView {get;set;}
    }
    public partial class CheckQueryGridView <CheckPrintQueryView,PrintOptionsChildDialogView> :  RPSGridView<CheckPrintQueryView,PrintOptionsChildDialogView> where CheckPrintQueryView : class, IView where PrintOptionsChildDialogView : class, IView
    {
        public CheckQueryGridView(CheckPrintQueryView currentView,PrintOptionsChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CheckNumber = RPSControlFactory.CreateRPSGridTextBox<CheckPrintQueryView>("","#55492d58-28ee-48e4-bff5-4bc26f3df302 .ag-row[role='row']@ROWINDEX [col-id='cCheckNumber']","",false, this.CurrentView);
 
            CheckDate = RPSControlFactory.CreateRPSGridTextBox<CheckPrintQueryView>("","#55492d58-28ee-48e4-bff5-4bc26f3df302 .ag-row[role='row']@ROWINDEX [col-id='cCheckDate']","",false, this.CurrentView);
 
            CheckDueDate = RPSControlFactory.CreateRPSGridTextBox<CheckPrintQueryView>("","#55492d58-28ee-48e4-bff5-4bc26f3df302 .ag-row[role='row']@ROWINDEX [col-id='cCheckDueDate']","",false, this.CurrentView);
 
            NumberOfDrafts = RPSControlFactory.CreateRPSGridFormattedTextBox<CheckPrintQueryView>("","#55492d58-28ee-48e4-bff5-4bc26f3df302 .ag-row[role='row']@ROWINDEX [col-id='cNumberOfDrafts']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CheckPrintQueryView> CheckNumber { get; set; } 
        public IRPSGridTextBox<CheckPrintQueryView> CheckDate { get; set; } 
        public IRPSGridTextBox<CheckPrintQueryView> CheckDueDate { get; set; } 
        public IRPSGridTextBox<CheckPrintQueryView> NumberOfDrafts { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintOptionsChildDialogView : View
    {
        public PrintOptionsChildDialogView(CheckPrint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Place = RPSControlFactory.CreateRPSTextBox<PrintOptionsChildDialogView>("ae62d532-a20c-43d6-a2cd-a1fd839821f5","","",true, this);
 
            OnlyCheckOne = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "b8699122-ae5d-4807-ac60-9e07573490d2","","",this);
 
            OnlyCheckMult = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "f2fa6062-0166-46df-9982-a793a20b52c8","","",this);
 
            CheckWithletter = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "84f2cbac-a83d-4ccc-b67a-caed1589b9f8","","",this);
 
            UseBank = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "d1e9e5e5-0a28-454a-9e5b-e1f8b1dd37d7","","",this);
 
            OtherReport = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "7c768f5c-6991-4ac2-8f80-3fbe452a75c3","","",this);
 
            CodCustomReportPrommissoryNote = RPSControlFactory.CreateRPSEnumComboBox<PrintOptionsChildDialogView>("62d42802-a782-46f0-8ba2-af2f3bc42672","","",true, this);
 
            CodCustomReportCheck = RPSControlFactory.CreateRPSEnumComboBox<PrintOptionsChildDialogView>("2c01aa0d-55c3-493a-bf1d-b26da30335fc","","",false, this);
 
            LanguageThird = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "4f7d5b5b-524f-4665-877b-65278d0a4e19","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "1607dfc9-58ee-480c-bd21-945ee670e13e","","",this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsChildDialogView>("c0947dfa-9853-4261-9652-bfd242f25d3f","","",false, this);
 
            Draft = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "4c24bc6e-5d04-4d49-b6fe-4ea1d1e51193","","",this);
 
            Company = RPSControlFactory.CreateRPSOption<PrintOptionsChildDialogView>( "594b4f89-fbf6-471a-ab0f-a294e4b0ba80","","",this);
 

        }
        public IRPSTextBox<PrintOptionsChildDialogView> Place { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> OnlyCheckOne { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> OnlyCheckMult { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> CheckWithletter { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> UseBank { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> OtherReport { get; set; } 
        public IRPSComboBox<PrintOptionsChildDialogView> CodCustomReportPrommissoryNote { get; set; } 
        public IRPSComboBox<PrintOptionsChildDialogView> CodCustomReportCheck { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> LanguageThird { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<PrintOptionsChildDialogView> CodLanguagePrint { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> Draft { get; set; } 
        public IRPSOption<PrintOptionsChildDialogView> Company { get; set; } 
        public CheckPrint Screen { get; set; }
        public PrintOptionsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
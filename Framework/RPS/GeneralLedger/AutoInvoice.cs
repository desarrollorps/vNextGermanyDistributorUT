    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AutoInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class AutoInvoice:Screen
    {
        public AutoInvoice():base()
        {
            this.URL = "generalledger.autoinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AutoInvoiceQueryView  = new AutoInvoiceQueryView(this); 
            AutoInvoiceView  = new AutoInvoiceView(this); 
            AutoInvoiceQueryView.InitializeControls(); 
            AutoInvoiceView.InitializeControls(); 
           
        }
      
            public AutoInvoiceQueryView AutoInvoiceQueryView {get; set; } 
            public AutoInvoiceView AutoInvoiceView {get; set; } 
    }
            
    public partial class AutoInvoiceQueryView : View
    {
        public AutoInvoiceQueryView(AutoInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<AutoInvoiceQueryView>("cf1daae2-2e69-428d-a24a-dd698318dbc3","","",false, this);
 
            DateAccountingFrom = RPSControlFactory.CreateRPSTextBox<AutoInvoiceQueryView>("e79df099-63b1-4bd9-878d-bf56b2445014","","",false, this);
 
            DateAccountingTo = RPSControlFactory.CreateRPSTextBox<AutoInvoiceQueryView>("a7e9507c-a3a4-4895-a228-57d57d2d12bf","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<AutoInvoiceQueryView>("e03bca13-7610-4185-bfc3-c9930f1fab6a","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AutoInvoiceQueryView>("c4c4e781-264e-41f4-bc47-4f37b9525ad3","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AutoInvoiceQueryView>("49630b9f-e023-48d3-9b29-5971fc9385cc","","",false, this);
 
            CollectionInit params_AutoInvoiceList = new CollectionInit(){IDDescriptor = "80df3062-d5a0-498e-a732-8d4b4326165d",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c238b6e-060c-4ad3-b330-c770e2681812",CSSSelectorGrid="",XPathGrid=""};
            AutoInvoiceList = RPSControlFactory.RPSCreateCollectionWithGrid<AutoInvoiceListCollectionEditor<AutoInvoiceQueryView>,AutoInvoiceQueryView>( params_AutoInvoiceList,this);
 

        }
        public IRPSCollectionComboBox<AutoInvoiceQueryView> IDSupplier { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> DateAccountingFrom { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> DateAccountingTo { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AutoInvoiceQueryView> DateTo { get; set; } 
        public AutoInvoiceListCollectionEditor<AutoInvoiceQueryView> AutoInvoiceList { get; set; } 
        public AutoInvoice Screen { get; set; }
        public AutoInvoiceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AutoInvoiceListCollectionEditor<AutoInvoiceQueryView>:RPSCollectionEditor<AutoInvoiceQueryView> where AutoInvoiceQueryView : class, IView
    {
        public  AutoInvoiceListGridView<AutoInvoiceQueryView> GridView {get;set;}
    }
    public partial class AutoInvoiceListGridView <AutoInvoiceQueryView> :  RPSGridView<AutoInvoiceQueryView> where AutoInvoiceQueryView : class, IView
    {
        public AutoInvoiceListGridView(AutoInvoiceQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AutoInvoice_CodAutoInvoice = RPSControlFactory.CreateRPSGridTextBox<AutoInvoiceQueryView>("","#6c238b6e-060c-4ad3-b330-c770e2681812 .ag-row[role='row']@ROWINDEX [col-id='cAutoInvoice_CodAutoInvoice']","",false, this.CurrentView);
 
            AutoInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AutoInvoiceQueryView>("","#6c238b6e-060c-4ad3-b330-c770e2681812 .ag-row[role='row']@ROWINDEX [col-id='cAutoInvoice_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AutoInvoiceQueryView> AutoInvoice_CodAutoInvoice { get; set; } 
        public IRPSGridTextBox<AutoInvoiceQueryView> AutoInvoice_InvoiceDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class AutoInvoiceView : View
    {
        public AutoInvoiceView(AutoInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AutoInvoiceView>( this);
 
            CodAutoInvoice = RPSControlFactory.CreateRPSTextBox<AutoInvoiceView>("18d5acbc-ff79-404e-9505-8ba6ecfe1b50","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<AutoInvoiceView>("1247a6c0-087d-40d1-85be-b1c53fe96afd","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("5590632a-946d-4637-aaf5-c15aa9fd8ac0","","",true, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("bb5fc41b-8c34-4315-b081-6f52a922ea19","","",false, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("7c4a36b7-d1a0-46a1-bf7b-62c38eb81c7d","","",true, this);
 
            UITotalBase = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("67650bc3-f435-4525-8014-2fbdcf57a733","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("4a89b1ef-149a-45b4-a52e-fa15016b2317","","",true, this);
 
            IDVAT1 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("03589903-9d58-445d-b35b-e935ccbb6b7b","","",false, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("d8ab4e39-1d4b-41e5-bf95-3acafda098a9","","",true, this);
 
            VATPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("79b9fba7-7bc8-4087-8202-83b62079d9b9","","",true, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("25339ee5-c96d-4b58-8864-4c94e480ac03","","",true, this);
 
            IDVAT2 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("9a0c669d-3207-467b-b4f0-8072455edcb5","","",false, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("96969b86-4fcd-4a89-acde-dfdd71540d19","","",true, this);
 
            VATPercentage2 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("860ef9bc-c46f-4405-be58-f6ebc07e3f15","","",true, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("90f4fed3-99fd-4e24-b449-ee1ec878ca73","","",true, this);
 
            IDVAT3 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("c78f95a8-9794-48f0-87ae-cd18ab787637","","",false, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("974fb4cd-afc9-40c7-bf1a-51313dfb9641","","",true, this);
 
            VATPercentage3 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("c92dc08f-d77c-4fda-a16d-0c72fe81adbb","","",true, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("932bf3c2-6da8-4f0b-8b44-51ed28833dd0","","",true, this);
 
            IDVAT4 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("e5110607-0f65-4051-ab24-f443b80ff1cf","","",false, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("333ac07e-0078-47f5-b455-68cdbbb7727b","","",true, this);
 
            VATPercentage4 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("187cd85b-c974-413f-8592-2cf2a947c636","","",true, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("fc271d86-afe8-4647-ae89-8d0ec2a3100b","","",true, this);
 
            IDVAT5 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("b5d68969-13f0-4bb4-b2e8-26e959729f2d","","",false, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("6fc9ac91-4810-4060-ad43-fb57b530bff5","","",true, this);
 
            VATPercentage5 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("047b85ca-2dc3-4586-ae79-939b1a0e5b1b","","",true, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("5cbf5be0-a11e-48c0-b19c-d494b3c65eb3","","",true, this);
 
            IDVAT6 = RPSControlFactory.CreateRPSComboBox<AutoInvoiceView>("1be92870-1d8a-4a91-b595-7a76e6d15e8a","","",false, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("5495dc42-e333-486a-92e5-eb42725c25e6","","",true, this);
 
            VATPercentage6 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("98f274f2-d1db-444e-92be-bdbcd1682c2d","","",true, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<AutoInvoiceView>("dd4d29ea-64e3-47c3-9368-08e326ff1858","","",true, this);
 

        }
        public IRPSSaveButton<AutoInvoiceView> SaveButton { get; set; } 
        public IRPSTextBox<AutoInvoiceView> CodAutoInvoice { get; set; } 
        public IRPSTextBox<AutoInvoiceView> InvoiceDate { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDSupplier { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<AutoInvoiceView> TotalInvoice { get; set; } 
        public IRPSTextBox<AutoInvoiceView> UITotalBase { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT1 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase1 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage1 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount1 { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT2 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase2 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage2 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount2 { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT3 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase3 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage3 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount3 { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT4 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase4 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage4 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount4 { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT5 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase5 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage5 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount5 { get; set; } 
        public IRPSComboBox<AutoInvoiceView> IDVAT6 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATBase6 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATPercentage6 { get; set; } 
        public IRPSTextBox<AutoInvoiceView> VATAmount6 { get; set; } 
        public AutoInvoice Screen { get; set; }
        public AutoInvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
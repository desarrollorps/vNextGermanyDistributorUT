    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BusinessUnitDefinition
{
    //RPS VERSION 1.0.0.0
    public partial class BusinessUnitDefinition:Screen
    {
        public BusinessUnitDefinition():base()
        {
            this.URL = "general.businessunitdefinition";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BusinessUnitVMTreeView  = new BusinessUnitVMTreeView(this); 
            BusinessUnitVMEntityView  = new BusinessUnitVMEntityView(this); 
            BusinessUnitByLangView  = new BusinessUnitByLangView(this); 
            BusinessUnitVMTreeView.InitializeControls(); 
            BusinessUnitVMEntityView.InitializeControls(); 
            BusinessUnitByLangView.InitializeControls(); 
           
        }
      
            public BusinessUnitVMTreeView BusinessUnitVMTreeView {get; set; } 
            public BusinessUnitVMEntityView BusinessUnitVMEntityView {get; set; } 
            public BusinessUnitByLangView BusinessUnitByLangView {get; set; } 
    }
            
    public partial class BusinessUnitVMTreeView : View
    {
        public BusinessUnitVMTreeView(BusinessUnitDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public BusinessUnitDefinition Screen { get; set; }
        public BusinessUnitVMTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BusinessUnitVMEntityView : View
    {
        public BusinessUnitVMEntityView(BusinessUnitDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BusinessUnitVMEntityView>( this);
 
            CodBusinessUnit = RPSControlFactory.CreateRPSTextBox<BusinessUnitVMEntityView>("4a1c8dee-d85c-4472-af72-4942bf413746","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BusinessUnitVMEntityView>("fd51f601-db83-4c7a-8ed4-2445ac350d0d","","",false, this);
 
            PercentageOwn = RPSControlFactory.CreateRPSFormattedTextBox<BusinessUnitVMEntityView>("70e7a8e9-7b07-4925-97f6-57b21563c309","","",true, this);
 
            BusinessType = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitVMEntityView>("fc800d61-111f-4f71-8d7c-e186ca2b53e7","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<BusinessUnitVMEntityView>("b70171f5-d64b-46bc-8a62-f51ed2e9c579","","",true, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("131e1de0-5654-4e1f-8a8b-a3c7e08be1b1","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("89c07934-279b-4966-8f3c-ccc24cab742d","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("e49e081e-6eee-4bae-b344-f7f4acb25eed","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("d7d288fd-6255-4d3f-a104-e85b9e281715","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("287d0205-2e9e-4116-8727-44a3a7600d66","","",false, this);
 
            IDTextLineCreditPre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("6a7af2b5-67a3-4d28-bd33-f2c79de39c11","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("e0d223f2-9dd9-4ac2-84e1-d6477016399e","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("17315eb8-e3e2-4557-bdb5-cea2d007a70a","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("a6892f9a-2eef-4431-8437-ff13b144574b","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("f878833e-e635-406b-acb1-b2aba5c32aa7","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("50db531e-2de1-4756-9cc4-7aaebf4e7e30","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("e2959516-8952-421e-a2a2-603828c8efd3","","",false, this);
 
            IDTextLineCreditPost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("1b495fe3-d4bd-45ba-b964-616488cbec88","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("6c8075f9-4ef8-4c33-8477-762569e2fb94","","",false, this);
 
            IDTextLineSRQuotationPrePur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("be121fbf-11a5-48d1-9a52-5e123ac41f06","","",false, this);
 
            IDTextLineFContractPrePur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("cbf1a361-801f-44ca-b456-1d4802569ce6","","",false, this);
 
            IDTextLineOrderPrePur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("a419a951-dac3-4786-971c-3414c93797fe","","",false, this);
 
            IDTextLineSRQuotationPostPur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("d6e0e920-3f10-4338-a01f-e1b89041ecee","","",false, this);
 
            IDTextLineFContractPostPur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("748c420d-53f5-4896-ad5d-d2449b2c4d2c","","",false, this);
 
            IDTextLineOrderPostPur = RPSControlFactory.CreateRPSComboBox<BusinessUnitVMEntityView>("30d8ff5f-167e-44a4-ad2b-b5eeb0b61b3c","","",false, this);
 
            CollectionInit params_BusinessUnitByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1af31857-48a9-4cc5-aa03-701afcd252c2",CSSSelectorGrid="",XPathGrid=""};
            BusinessUnitByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<BusinessUnitByLangsCollectionEditor<BusinessUnitVMEntityView,BusinessUnitByLangView>,BusinessUnitVMEntityView,BusinessUnitByLangView>( params_BusinessUnitByLangs,this,Screen.BusinessUnitByLangView);
 
            General = RPSControlFactory.CreateRPSSection<BusinessUnitVMEntityView>( "","ul li[rpsid='ef4aac32-7f68-4d35-a0b7-89c37a7f4afe']","",this);
 
            Texts = RPSControlFactory.CreateRPSSection<BusinessUnitVMEntityView>( "","ul li[rpsid='eb216e60-a42f-48bc-ae4f-98e6ef2d73b8']","",this);
 

        }
        public IRPSSaveButton<BusinessUnitVMEntityView> SaveButton { get; set; } 
        public IRPSTextBox<BusinessUnitVMEntityView> CodBusinessUnit { get; set; } 
        public IRPSTextBox<BusinessUnitVMEntityView> Description { get; set; } 
        public IRPSTextBox<BusinessUnitVMEntityView> PercentageOwn { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> BusinessType { get; set; } 
        public IRPSCheckbox<BusinessUnitVMEntityView> Blocked { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineCreditPre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineCreditPost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineAdvancePost { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineSRQuotationPrePur { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineFContractPrePur { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOrderPrePur { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineSRQuotationPostPur { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineFContractPostPur { get; set; } 
        public IRPSComboBox<BusinessUnitVMEntityView> IDTextLineOrderPostPur { get; set; } 
        public BusinessUnitByLangsCollectionEditor<BusinessUnitVMEntityView,BusinessUnitByLangView> BusinessUnitByLangs { get; set; } 
        public IRPSSection<BusinessUnitVMEntityView> General { get; set; } 
        public IRPSSection<BusinessUnitVMEntityView> Texts { get; set; } 
        public BusinessUnitDefinition Screen { get; set; }
        public BusinessUnitVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BusinessUnitByLangsCollectionEditor<BusinessUnitVMEntityView,BusinessUnitByLangView>:RPSCollectionEditor<BusinessUnitVMEntityView,BusinessUnitByLangView> where BusinessUnitVMEntityView : class, IView where BusinessUnitByLangView : class, IView
    {
        public  BusinessUnitByLangsGridView<BusinessUnitVMEntityView,BusinessUnitByLangView> GridView {get;set;}
    }
    public partial class BusinessUnitByLangsGridView <BusinessUnitVMEntityView,BusinessUnitByLangView> :  RPSGridView<BusinessUnitVMEntityView,BusinessUnitByLangView> where BusinessUnitVMEntityView : class, IView where BusinessUnitByLangView : class, IView
    {
        public BusinessUnitByLangsGridView(BusinessUnitVMEntityView currentView,BusinessUnitByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<BusinessUnitVMEntityView>("","#1af31857-48a9-4cc5-aa03-701afcd252c2 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<BusinessUnitVMEntityView>("","#1af31857-48a9-4cc5-aa03-701afcd252c2 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<BusinessUnitVMEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<BusinessUnitVMEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class BusinessUnitByLangView : View
    {
        public BusinessUnitByLangView(BusinessUnitDefinition screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BusinessUnitByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BusinessUnitByLangView,BusinessUnitVMEntityView>( this,Screen.BusinessUnitVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BusinessUnitByLangView,BusinessUnitVMEntityView>( this,Screen.BusinessUnitVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BusinessUnitByLangView,BusinessUnitVMEntityView>( this,Screen.BusinessUnitVMEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<BusinessUnitByLangView>("ac6c37f0-d786-455d-833e-a8b12bf59bd5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BusinessUnitByLangView>("4eb58b29-6190-4c61-940f-f73801c9691b","","",false, this);
 

        }
        public IRPSButton<BusinessUnitByLangView> DeleteButton { get; set; } 
        public IRPSButton<BusinessUnitByLangView,BusinessUnitVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BusinessUnitByLangView,BusinessUnitVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BusinessUnitByLangView,BusinessUnitVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<BusinessUnitByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<BusinessUnitByLangView> Description { get; set; } 
        public BusinessUnitDefinition Screen { get; set; }
        public BusinessUnitByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
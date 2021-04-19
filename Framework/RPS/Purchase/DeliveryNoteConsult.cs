    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryNoteConsult
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteConsult:Screen
    {
        public DeliveryNoteConsult():base()
        {
            this.URL = "purchase.deliverynoteconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteConsultQueryView  = new DeliveryNoteConsultQueryView(this); 
            DeliveryNoteConsultQueryView.InitializeControls(); 
           
        }
      
            public DeliveryNoteConsultQueryView DeliveryNoteConsultQueryView {get; set; } 
    }
            
    public partial class DeliveryNoteConsultQueryView : View
    {
        public DeliveryNoteConsultQueryView(DeliveryNoteConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LsDeliveryNoteFilter = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("45a98ab7-7034-4135-a171-f6ffdbc7b16f","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<DeliveryNoteConsultQueryView>( "26726974-a364-49f9-8c7c-590b51bd2c48","","",this);
 
            PendingInvoice = RPSControlFactory.CreateRPSOption<DeliveryNoteConsultQueryView>( "395c4db1-6309-4777-8c53-8d78aa55b031","","",this);
 
            PendingInspection = RPSControlFactory.CreateRPSOption<DeliveryNoteConsultQueryView>( "a4de3c96-b233-4496-bdf7-b84aae6220b8","","",this);
 
            DateFromFilter = RPSControlFactory.CreateRPSTextBox<DeliveryNoteConsultQueryView>("e9cab5b3-7410-46dc-8d1b-d2e9c73850e6","","",false, this);
 
            Registered = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteConsultQueryView>("e2d84f43-9442-4604-ba8e-e6e24268b13d","","",false, this);
 
            DateToFilter = RPSControlFactory.CreateRPSTextBox<DeliveryNoteConsultQueryView>("8e550423-07ae-4172-b379-462a8806dbdd","","",false, this);
 
            Finalized = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteConsultQueryView>("9918c07f-5ea7-4baa-ae07-075b86a4a8f7","","",false, this);
 
            Preliminary = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteConsultQueryView>("51091bf7-60dd-4769-aaf9-798c36e225a5","","",false, this);
 
            Empresa = RPSControlFactory.CreateRPSOption<DeliveryNoteConsultQueryView>( "e457068a-c990-4f75-8c33-b6aba482546a","","",this);
 
            Albaran = RPSControlFactory.CreateRPSOption<DeliveryNoteConsultQueryView>( "d3847b30-4e29-4ba7-820a-643bc92b935c","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("8b32a692-bc21-4542-920d-f245e3b972b2","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("63faaa0b-febc-4677-9fac-ebeab0986d17","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("47bc1cd7-3ad1-4402-8aa6-7433087a4941","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("9df89a9e-cd62-4525-b18a-20f8bd6ee7e0","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("3e9d46c7-91a9-483a-857e-075825fba4ad","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("8dafe071-5a03-44ce-99e6-f1f07bcd584f","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteConsultQueryView>("1728766d-cd0e-466a-9ece-b7edcc13e0b2","","",false, this);
 
            SupplierRequestQuotation = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteConsultQueryView>("d1a4558d-df51-4c66-8223-5be591a137ea","","",false, this);
 
            OrderNumberSupplier = RPSControlFactory.CreateRPSTextBox<DeliveryNoteConsultQueryView>("49eaf13f-f0e7-4bd5-afd1-46687b5d2088","","",false, this);
 
            Order = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("cf684651-17e1-4653-88cb-187efda4abe7","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("decaea2e-306f-4883-adab-be2e8aa53123","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("1cec0d5d-156c-4330-a1d1-8788c90c071f","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("ae08fdae-d23e-441d-b9a0-409dba6cdf07","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("162d39b0-bb95-405f-96a9-05495b9adcc4","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("e3379b4d-0c26-4f0a-80fa-feedcd29ee6c","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteConsultQueryView>("dfefd413-1b77-445d-a39f-37e597a42ed9","","",false, this);
 
            OnlyExternalTask = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteConsultQueryView>("440b1711-5cd0-440c-823d-54f027096ce1","","",false, this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("3a2d5053-8d30-4f3d-9713-4b7de68b6e58","","",false, this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<DeliveryNoteConsultQueryView>("0a571a04-66b3-416b-af48-134a905cbcb8","","",false, this);
 
            CollectionInit params_DeliveryNoteConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06c55178-8601-4b71-9469-2294fb9aa9cd",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteConsultCollectionEditor<DeliveryNoteConsultQueryView>,DeliveryNoteConsultQueryView>( params_DeliveryNoteConsult,this);
 
            CollectionInit params_DeliveryNoteLineConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9e5ecf10-38b4-4cbc-9df4-29764a2f2e19",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConsultCollectionEditor<DeliveryNoteConsultQueryView>,DeliveryNoteConsultQueryView>( params_DeliveryNoteLineConsult,this);
 

        }
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> LsDeliveryNoteFilter { get; set; } 
        public IRPSOption<DeliveryNoteConsultQueryView> All { get; set; } 
        public IRPSOption<DeliveryNoteConsultQueryView> PendingInvoice { get; set; } 
        public IRPSOption<DeliveryNoteConsultQueryView> PendingInspection { get; set; } 
        public IRPSTextBox<DeliveryNoteConsultQueryView> DateFromFilter { get; set; } 
        public IRPSCheckbox<DeliveryNoteConsultQueryView> Registered { get; set; } 
        public IRPSTextBox<DeliveryNoteConsultQueryView> DateToFilter { get; set; } 
        public IRPSCheckbox<DeliveryNoteConsultQueryView> Finalized { get; set; } 
        public IRPSCheckbox<DeliveryNoteConsultQueryView> Preliminary { get; set; } 
        public IRPSOption<DeliveryNoteConsultQueryView> Empresa { get; set; } 
        public IRPSOption<DeliveryNoteConsultQueryView> Albaran { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDSupplierGroup { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> IDArticle { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> ReferenceSupplier { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteConsultQueryView> SupplierRequestQuotation { get; set; } 
        public IRPSTextBox<DeliveryNoteConsultQueryView> OrderNumberSupplier { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> Order { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDProject { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDOrderSL { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDArticleStructure { get; set; } 
        public IRPSTextBox<DeliveryNoteConsultQueryView> InternalCode { get; set; } 
        public IRPSCheckbox<DeliveryNoteConsultQueryView> OnlyExternalTask { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDFrameworkContract { get; set; } 
        public IRPSComboBox<DeliveryNoteConsultQueryView> IDMaintenanceContract { get; set; } 
        public DeliveryNoteConsultCollectionEditor<DeliveryNoteConsultQueryView> DeliveryNoteConsult { get; set; } 
        public DeliveryNoteLineConsultCollectionEditor<DeliveryNoteConsultQueryView> DeliveryNoteLineConsult { get; set; } 
        public DeliveryNoteConsult Screen { get; set; }
        public DeliveryNoteConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteConsultCollectionEditor<DeliveryNoteConsultQueryView>:RPSCollectionEditor<DeliveryNoteConsultQueryView> where DeliveryNoteConsultQueryView : class, IView
    {
        public  DeliveryNoteConsultGridView<DeliveryNoteConsultQueryView> GridView {get;set;}
    }
    public partial class DeliveryNoteConsultGridView <DeliveryNoteConsultQueryView> :  RPSGridView<DeliveryNoteConsultQueryView> where DeliveryNoteConsultQueryView : class, IView
    {
        public DeliveryNoteConsultGridView(DeliveryNoteConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierMiscellaneous_Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteConsultQueryView>("","#06c55178-8601-4b71-9469-2294fb9aa9cd .ag-row[role='row']@ROWINDEX [col-id='cSupplierMiscellaneous_Description']","",false, this.CurrentView);
 
            DeliveryNote_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteConsultQueryView>("","#06c55178-8601-4b71-9469-2294fb9aa9cd .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteConsultQueryView> SupplierMiscellaneous_Description { get; set; } 
        public IRPSGridTextBox<DeliveryNoteConsultQueryView> DeliveryNote_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineConsultCollectionEditor<DeliveryNoteConsultQueryView>:RPSCollectionEditor<DeliveryNoteConsultQueryView> where DeliveryNoteConsultQueryView : class, IView
    {
        public  DeliveryNoteLineConsultGridView<DeliveryNoteConsultQueryView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineConsultGridView <DeliveryNoteConsultQueryView> :  RPSGridView<DeliveryNoteConsultQueryView> where DeliveryNoteConsultQueryView : class, IView
    {
        public DeliveryNoteLineConsultGridView(DeliveryNoteConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteLine_ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteConsultQueryView>("","#9e5ecf10-38b4-4cbc-9df4-29764a2f2e19 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLine_ReferenceSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteConsultQueryView> DeliveryNoteLine_ReferenceSupplier { get; set; } 
                     
    }
 
    }
  
    

}
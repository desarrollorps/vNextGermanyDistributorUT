    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PurchaseProposalConsult
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseProposalConsult:Screen
    {
        public PurchaseProposalConsult():base()
        {
            this.URL = "purchase.purchaseproposalconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseProposalConsultQueryView  = new PurchaseProposalConsultQueryView(this); 
            OrderGenerateChildDialogView  = new OrderGenerateChildDialogView(this); 
            QuotationGenerateChildDialogView  = new QuotationGenerateChildDialogView(this); 
            UpdateSupplierChildDialogView  = new UpdateSupplierChildDialogView(this); 
            PurchaseProposalConsultQueryView.InitializeControls(); 
            OrderGenerateChildDialogView.InitializeControls(); 
            QuotationGenerateChildDialogView.InitializeControls(); 
            UpdateSupplierChildDialogView.InitializeControls(); 
           
        }
      
            public PurchaseProposalConsultQueryView PurchaseProposalConsultQueryView {get; set; } 
            public OrderGenerateChildDialogView OrderGenerateChildDialogView {get; set; } 
            public QuotationGenerateChildDialogView QuotationGenerateChildDialogView {get; set; } 
            public UpdateSupplierChildDialogView UpdateSupplierChildDialogView {get; set; } 
    }
            
    public partial class PurchaseProposalConsultQueryView : View
    {
        public PurchaseProposalConsultQueryView(PurchaseProposalConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PurchaseProposal = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("08e97d2b-a0a3-4221-b76c-d1bc11cf62e5","","",false, this);
 
            ProposalDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("07073d35-7fab-4505-bac9-a74b243d5eb7","","",false, this);
 
            DeliveryDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("3c61b837-0df3-4649-847c-4202aa00077a","","",false, this);
 
            RequestDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("047dbb00-f94b-4202-ab78-d1a3b37926f5","","",false, this);
 
            StatusPending = RPSControlFactory.CreateRPSCheckBox<PurchaseProposalConsultQueryView>("9d0de839-c5a6-409f-b517-6f1fbe2bc26f","","",false, this);
 
            StatusValidated = RPSControlFactory.CreateRPSCheckBox<PurchaseProposalConsultQueryView>("a3496a32-2fdb-48bf-8a64-e0787a87a929","","",false, this);
 
            StatusRejected = RPSControlFactory.CreateRPSCheckBox<PurchaseProposalConsultQueryView>("0549d067-bd78-4f7d-99cd-53b47db1c137","","",false, this);
 
            ProposalDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("6e87e48f-91f3-4eec-8012-ab7407bca972","","",false, this);
 
            DeliveryDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("991b925f-9a95-4001-87d5-5a66a855ac87","","",false, this);
 
            RequestDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("f7bf8825-9ce9-4c7c-9c34-b80438dc31fd","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<PurchaseProposalConsultQueryView>( "6e74eaff-bd37-4d77-b2b0-0f58bde27182","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("54e0c226-b640-4267-bc91-8ceac7099244","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("3726c053-b3d0-4632-856a-e0d9cf78df5a","","",false, this);
 
            NoSupplier = RPSControlFactory.CreateRPSOption<PurchaseProposalConsultQueryView>( "2d626436-3c31-4bc2-b995-ffdcabd2562e","","",this);
 
            WithLockedSupplier = RPSControlFactory.CreateRPSOption<PurchaseProposalConsultQueryView>( "9180339e-b65c-4cac-b2b0-8e72fbcfc7a2","","",this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("18dd3de8-463d-4b78-b552-95f6b6e79fa6","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("01b0ba5a-4ba6-48e8-b329-fc34a22822a2","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("f1254b0b-6142-43f3-be53-242b57da3710","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseProposalConsultQueryView>("3d7f005a-8f41-4153-8ba3-741ad8d5f5aa","","",false, this);
 
            IDSupplierArticle = RPSControlFactory.CreateRPSEnumComboBox<PurchaseProposalConsultQueryView>("f946085f-177a-448a-a06e-d5e81b612d01","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PurchaseProposalConsultQueryView>("f5ea1ab7-43fc-46a0-acdf-6c8c2f730543","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<PurchaseProposalConsultQueryView>("91d3523b-d851-4d73-99c6-539861e3a26f","","",false, this);
 
            OnlyExternalTask = RPSControlFactory.CreateRPSCheckBox<PurchaseProposalConsultQueryView>("341b1965-5b81-4640-9ad1-332d74263a17","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<PurchaseProposalConsultQueryView>("e3dcc285-e676-4388-a14c-5cd681bd143d","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("33e1d336-1582-430c-bb0f-3228c2552123","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<PurchaseProposalConsultQueryView>("580d7052-9250-4a13-a0ef-39d697235486","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<PurchaseProposalConsultQueryView>("6ba1fd31-39df-4751-b442-f068aae4efe6","","",false, this);
 
            OrderGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView>("263cbb7a-364f-48c3-a7d1-1d0f3df2d5eb","","", this,Screen.OrderGenerateChildDialogView);
 
            QuotationGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalConsultQueryView,QuotationGenerateChildDialogView>("e4182d33-f60e-4429-bd5d-f90b8d3e527c","","", this,Screen.QuotationGenerateChildDialogView);
 
            UpdateSupplierNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalConsultQueryView,UpdateSupplierChildDialogView>("075fa138-6e0c-4c3e-a5a8-035233121d40","","", this,Screen.UpdateSupplierChildDialogView);
 
            ExecutePurchaseProposalValidatedCommandButton = RPSControlFactory.CreateRPSButton<PurchaseProposalConsultQueryView>( "3d462537-8c8c-4c16-9bda-9f2ea5ba43af","","",this);
 
            PurchaseProposal_ProposalDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("07c89538-1971-4c60-801b-efa5edabd14a","","",false, this);
 
            PurchaseProposal_Description = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("0fb5f80e-99d8-404e-acbe-2d6af85b1157","","",false, this);
 
            PurchaseProposal_ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("cb66f2f5-4486-419b-9d0c-775eb96a2506","","",false, this);
 
            PurchaseProposal_ReceptionDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("7f45a22d-b055-4080-9ca8-43d42332fa96","","",false, this);
 
            PurchaseProposal_ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("102b1078-ba87-492a-93e5-d882735aaa33","","",false, this);
 
            UIPurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalConsultQueryView>("34d1ed62-7cca-45f4-ab79-126ee627ab8d","","",false, this);
 
            PurchaseProposal_Status = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("e5c6b1ab-cab3-471a-82d4-89d9914311c7","","",false, this);
 
            PurchaseProposal_ProposalFrom = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("37cd710f-b672-409d-b1a4-5a0394e8a019","","",false, this);
 
            PurchaseProposal_StatusOffer = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("058254d5-c47e-442c-af5d-0b1e15731a64","","",false, this);
 
            PurchaseProposal_Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalConsultQueryView>("51e959e1-8a08-4f4b-aebc-7e0d882a0a3d","","",false, this);
 
            PurchaseProposal_InternalCode = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("65bf749f-bd28-4720-b493-eb78e1f30a27","","",false, this);
 
            PurchaseProposal_Comment = RPSControlFactory.CreateRPSTextBox<PurchaseProposalConsultQueryView>("061827e9-2ce8-4e46-9f74-9dc7ebe2ddb8","","",false, this);
 
            CollectionInit params_PurchaseProposalConsultQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4842f6ad-31f4-4871-824b-6f490767a565",CSSSelectorGrid="",XPathGrid=""};
            PurchaseProposalConsultQuery = RPSControlFactory.RPSCreateCollectionWithGrid<PurchaseProposalConsultQueryCollectionEditor<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView>,PurchaseProposalConsultQueryView,OrderGenerateChildDialogView>( params_PurchaseProposalConsultQuery,this,Screen.OrderGenerateChildDialogView);
 
            General = RPSControlFactory.CreateRPSSection<PurchaseProposalConsultQueryView>( "","ul li[rpsid='55215bcf-a421-4149-9162-fbbf3e9a7a5c']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<PurchaseProposalConsultQueryView>( "","ul li[rpsid='2fda2055-c9f3-4e45-91e5-38ebc7acec74']","",this);
 

        }
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> PurchaseProposal { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> ProposalDateFrom { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> DeliveryDateFrom { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> RequestDateFrom { get; set; } 
        public IRPSCheckbox<PurchaseProposalConsultQueryView> StatusPending { get; set; } 
        public IRPSCheckbox<PurchaseProposalConsultQueryView> StatusValidated { get; set; } 
        public IRPSCheckbox<PurchaseProposalConsultQueryView> StatusRejected { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> ProposalDateTo { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> DeliveryDateTo { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> RequestDateTo { get; set; } 
        public IRPSOption<PurchaseProposalConsultQueryView> All { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDSupplierGroup { get; set; } 
        public IRPSOption<PurchaseProposalConsultQueryView> NoSupplier { get; set; } 
        public IRPSOption<PurchaseProposalConsultQueryView> WithLockedSupplier { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<PurchaseProposalConsultQueryView> IDArticle { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDSupplierArticle { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDProject { get; set; } 
        public IRPSCheckbox<PurchaseProposalConsultQueryView> OnlyExternalTask { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDArticleStructure { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> InternalCode { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDOrderSL { get; set; } 
        public IRPSComboBox<PurchaseProposalConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSButton<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> OrderGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalConsultQueryView,QuotationGenerateChildDialogView> QuotationGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalConsultQueryView,UpdateSupplierChildDialogView> UpdateSupplierNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalConsultQueryView> ExecutePurchaseProposalValidatedCommandButton { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ProposalDate { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Description { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ReferenceSupplier { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ReceptionDate { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ReceptionDemandDate { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> UIPurchaseLot { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Status { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ProposalFrom { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_StatusOffer { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Quantity { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_InternalCode { get; set; } 
        public IRPSTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Comment { get; set; } 
        public PurchaseProposalConsultQueryCollectionEditor<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> PurchaseProposalConsultQuery { get; set; } 
        public IRPSSection<PurchaseProposalConsultQueryView> General { get; set; } 
        public IRPSSection<PurchaseProposalConsultQueryView> Comments { get; set; } 
        public PurchaseProposalConsult Screen { get; set; }
        public PurchaseProposalConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PurchaseProposalConsultQueryCollectionEditor<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView>:RPSCollectionEditor<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> where PurchaseProposalConsultQueryView : class, IView where OrderGenerateChildDialogView : class, IView
    {
        public  PurchaseProposalConsultQueryGridView<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> GridView {get;set;}
    }
    public partial class PurchaseProposalConsultQueryGridView <PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> :  RPSGridView<PurchaseProposalConsultQueryView,OrderGenerateChildDialogView> where PurchaseProposalConsultQueryView : class, IView where OrderGenerateChildDialogView : class, IView
    {
        public PurchaseProposalConsultQueryGridView(PurchaseProposalConsultQueryView currentView,OrderGenerateChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PurchaseProposal_Description = RPSControlFactory.CreateRPSGridTextBox<PurchaseProposalConsultQueryView>("","#4842f6ad-31f4-4871-824b-6f490767a565 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseProposal_Description']","",false, this.CurrentView);
 
            PurchaseProposal_ProposalDate = RPSControlFactory.CreateRPSGridTextBox<PurchaseProposalConsultQueryView>("","#4842f6ad-31f4-4871-824b-6f490767a565 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseProposal_ProposalDate']","",false, this.CurrentView);
 
            PurchaseProposal_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<PurchaseProposalConsultQueryView>("","#4842f6ad-31f4-4871-824b-6f490767a565 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseProposal_ReceptionDate']","",false, this.CurrentView);
 
            PurchaseProposal_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseProposalConsultQueryView>("","#4842f6ad-31f4-4871-824b-6f490767a565 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseProposal_Quantity']","",false, this.CurrentView);
 
            PurchaseProposal_Status = RPSControlFactory.CreateRPSGridTextBox<PurchaseProposalConsultQueryView>("","#4842f6ad-31f4-4871-824b-6f490767a565 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseProposal_Status']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Description { get; set; } 
        public IRPSGridTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ProposalDate { get; set; } 
        public IRPSGridTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_ReceptionDate { get; set; } 
        public IRPSGridTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Quantity { get; set; } 
        public IRPSGridTextBox<PurchaseProposalConsultQueryView> PurchaseProposal_Status { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderGenerateChildDialogView : View
    {
        public OrderGenerateChildDialogView(PurchaseProposalConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "83b827b9-1439-4408-afcb-8c2f67a019a7","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "99f96fb7-ea1e-47d3-a4ec-98a36bbbe058","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OrderGenerateChildDialogView>("b4abfc72-d33f-428d-b8db-191d41f00f1a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("2d55f300-0edf-45b4-b3c8-40ff52ed61a4","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("426c19e8-c390-49a0-83e7-91d88ad07455","","",false, this);
 

        }
        public IRPSOption<OrderGenerateChildDialogView> Single { get; set; } 
        public IRPSOption<OrderGenerateChildDialogView> Break { get; set; } 
        public IRPSComboBox<OrderGenerateChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<OrderGenerateChildDialogView> Date { get; set; } 
        public IRPSTextBox<OrderGenerateChildDialogView> NewCode { get; set; } 
        public PurchaseProposalConsult Screen { get; set; }
        public OrderGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationGenerateChildDialogView : View
    {
        public QuotationGenerateChildDialogView(PurchaseProposalConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<QuotationGenerateChildDialogView>( "637ee06f-ed9d-4399-a8fc-b7833da0c49a","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<QuotationGenerateChildDialogView>( "60f4d91c-584d-4bbc-9124-a9ed8366356a","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<QuotationGenerateChildDialogView>("68ddd422-09ef-45e9-9234-003531dfaf8a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<QuotationGenerateChildDialogView>("82407625-c99a-4754-8955-18f0499d90b6","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<QuotationGenerateChildDialogView>("6310837a-d8d9-47fa-9eb2-8c1ea5b959fb","","",false, this);
 

        }
        public IRPSOption<QuotationGenerateChildDialogView> Single { get; set; } 
        public IRPSOption<QuotationGenerateChildDialogView> Break { get; set; } 
        public IRPSComboBox<QuotationGenerateChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<QuotationGenerateChildDialogView> Date { get; set; } 
        public IRPSTextBox<QuotationGenerateChildDialogView> NewCode { get; set; } 
        public PurchaseProposalConsult Screen { get; set; }
        public QuotationGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateSupplierChildDialogView : View
    {
        public UpdateSupplierChildDialogView(PurchaseProposalConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<UpdateSupplierChildDialogView>("498f1249-4103-4997-8e6c-6e46137ec956","","",false, this);
 

        }
        public IRPSComboBox<UpdateSupplierChildDialogView> IDSupplier { get; set; } 
        public PurchaseProposalConsult Screen { get; set; }
        public UpdateSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
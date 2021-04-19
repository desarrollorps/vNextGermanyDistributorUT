    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryPlanSL
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryPlanSL:Screen
    {
        public DeliveryPlanSL():base()
        {
            this.URL = "sales.deliveryplansl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryPlanSLVMCollectionView  = new DeliveryPlanSLVMCollectionView(this); 
            DeliveryPlanSLVMEntityView  = new DeliveryPlanSLVMEntityView(this); 
            GenerateDeliveryPlanSLChildDialogView  = new GenerateDeliveryPlanSLChildDialogView(this); 
            GenerateOrdersChildDialogView  = new GenerateOrdersChildDialogView(this); 
            UpdateQuantityChildDialogView  = new UpdateQuantityChildDialogView(this); 
            DeliveryPlanSLVMCollectionView.InitializeControls(); 
            DeliveryPlanSLVMEntityView.InitializeControls(); 
            GenerateDeliveryPlanSLChildDialogView.InitializeControls(); 
            GenerateOrdersChildDialogView.InitializeControls(); 
            UpdateQuantityChildDialogView.InitializeControls(); 
           
        }
      
            public DeliveryPlanSLVMCollectionView DeliveryPlanSLVMCollectionView {get; set; } 
            public DeliveryPlanSLVMEntityView DeliveryPlanSLVMEntityView {get; set; } 
            public GenerateDeliveryPlanSLChildDialogView GenerateDeliveryPlanSLChildDialogView {get; set; } 
            public GenerateOrdersChildDialogView GenerateOrdersChildDialogView {get; set; } 
            public UpdateQuantityChildDialogView UpdateQuantityChildDialogView {get; set; } 
    }
            
    public partial class DeliveryPlanSLVMCollectionView : View
    {
        public DeliveryPlanSLVMCollectionView(DeliveryPlanSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSComboBox<DeliveryPlanSLVMCollectionView>("60b2a947-3e36-410b-86cb-44719a695713","","",false, this);
 
            DateStart = RPSControlFactory.CreateRPSTextBox<DeliveryPlanSLVMCollectionView>("182cb968-0f2c-4bab-b1bc-3a2e98648fb9","","",false, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<DeliveryPlanSLVMCollectionView>("ce03bb5f-694a-4c17-b17e-f98ad3927715","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanSLVMCollectionView>("e5073bbf-7528-4c11-986e-96c7996d9c34","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanSLVMCollectionView>("9edc88a6-6c86-4ff3-943a-d318256bd011","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanSLVMCollectionView>("6142de5f-aa6d-49c6-85c1-1f86c25f12c6","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanSLVMCollectionView>("ab1cf5aa-f78e-4d54-bd47-ea957a6a4caa","","",false, this);
 
            GenerateDeliveryPlanSLChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanSLVMCollectionView,GenerateDeliveryPlanSLChildDialogView>("69cb24e8-b907-4198-ac21-94688fc61f7a","","", this,Screen.GenerateDeliveryPlanSLChildDialogView);
 
            GenerateOrdersChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanSLVMCollectionView,GenerateOrdersChildDialogView>("e83161bc-ed6d-4534-a18c-67fcd991bb24","","", this,Screen.GenerateOrdersChildDialogView);
 
            UpdateQuantityChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanSLVMCollectionView,UpdateQuantityChildDialogView>("d1707161-e814-40b0-8d66-c3861265b565","","", this,Screen.UpdateQuantityChildDialogView);
 
            ExecuteMassiveDeliveryPlanSLDeleteButton = RPSControlFactory.CreateRPSButton<DeliveryPlanSLVMCollectionView>( "a10941d9-00fb-4c53-9eaf-2ee4a060d3e2","","",this);
 
            CollectionInit params_DeliveryPlanQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d269e1c5-0ef0-43aa-aedd-535f62d1b8c2",CSSSelectorGrid="",XPathGrid=""};
            DeliveryPlanQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryPlanQueryCollectionEditor<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView>,DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView>( params_DeliveryPlanQuery,this,Screen.DeliveryPlanSLVMEntityView);
 

        }
        public IRPSComboBox<DeliveryPlanSLVMCollectionView> Customer { get; set; } 
        public IRPSTextBox<DeliveryPlanSLVMCollectionView> DateStart { get; set; } 
        public IRPSTextBox<DeliveryPlanSLVMCollectionView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanSLVMCollectionView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanSLVMCollectionView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanSLVMCollectionView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanSLVMCollectionView> Article { get; set; } 
        public IRPSButton<DeliveryPlanSLVMCollectionView,GenerateDeliveryPlanSLChildDialogView> GenerateDeliveryPlanSLChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanSLVMCollectionView,GenerateOrdersChildDialogView> GenerateOrdersChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanSLVMCollectionView,UpdateQuantityChildDialogView> UpdateQuantityChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanSLVMCollectionView> ExecuteMassiveDeliveryPlanSLDeleteButton { get; set; } 
        public DeliveryPlanQueryCollectionEditor<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView> DeliveryPlanQuery { get; set; } 
        public DeliveryPlanSL Screen { get; set; }
        public DeliveryPlanSLVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryPlanQueryCollectionEditor<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView>:RPSCollectionEditor<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView> where DeliveryPlanSLVMCollectionView : class, IView where DeliveryPlanSLVMEntityView : class, IView
    {
        public  DeliveryPlanQueryGridView<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView> GridView {get;set;}
    }
    public partial class DeliveryPlanQueryGridView <DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView> :  RPSGridView<DeliveryPlanSLVMCollectionView,DeliveryPlanSLVMEntityView> where DeliveryPlanSLVMCollectionView : class, IView where DeliveryPlanSLVMEntityView : class, IView
    {
        public DeliveryPlanQueryGridView(DeliveryPlanSLVMCollectionView currentView,DeliveryPlanSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DeliveryPlanSLVMCollectionView>("","#d269e1c5-0ef0-43aa-aedd-535f62d1b8c2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            PlanDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryPlanSLVMCollectionView>("","#d269e1c5-0ef0-43aa-aedd-535f62d1b8c2 .ag-row[role='row']@ROWINDEX [col-id='cPlanDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryPlanSLVMCollectionView>("","#d269e1c5-0ef0-43aa-aedd-535f62d1b8c2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<DeliveryPlanSLVMCollectionView>("","#d269e1c5-0ef0-43aa-aedd-535f62d1b8c2 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryPlanSLVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<DeliveryPlanSLVMCollectionView> PlanDate { get; set; } 
        public IRPSGridTextBox<DeliveryPlanSLVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<DeliveryPlanSLVMCollectionView> IDCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryPlanSLVMEntityView : View
    {
        public DeliveryPlanSLVMEntityView(DeliveryPlanSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryPlanSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView>( this,Screen.DeliveryPlanSLVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView>( this,Screen.DeliveryPlanSLVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView>( this,Screen.DeliveryPlanSLVMCollectionView);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DeliveryPlanSLVMEntityView>("12bd1673-37f2-4538-9486-46a987f748a6","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<DeliveryPlanSLVMEntityView>("0e7b1837-8842-4ae2-b468-e1f0634e32ee","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryPlanSLVMEntityView>("046298e0-4434-4698-93c0-112d8b4dc1ca","","",true, this);
 
            PlanDate = RPSControlFactory.CreateRPSTextBox<DeliveryPlanSLVMEntityView>("d27a0b5d-d59b-42a0-a95f-68aeb2a791dd","","",true, this);
 

        }
        public IRPSButton<DeliveryPlanSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryPlanSLVMEntityView,DeliveryPlanSLVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryPlanSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<DeliveryPlanSLVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<DeliveryPlanSLVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryPlanSLVMEntityView> PlanDate { get; set; } 
        public DeliveryPlanSL Screen { get; set; }
        public DeliveryPlanSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateDeliveryPlanSLChildDialogView : View
    {
        public GenerateDeliveryPlanSLChildDialogView(DeliveryPlanSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSComboBox<GenerateDeliveryPlanSLChildDialogView>("488feb7d-ee92-46bf-9e0a-a0f25203325b","","",true, this);
 
            DateStart = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryPlanSLChildDialogView>("42841845-b58a-4d24-a823-515568c90eeb","","",true, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryPlanSLChildDialogView>("5522f25d-7f24-4ee6-b598-03d1f06aaa79","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView>("02c5b187-3b02-4a95-befc-faed4cdcfd66","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView>("814c82d1-28c6-4c97-b96e-db386775b15f","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView>("94b7a0c1-dda9-46ee-8720-67429fbf98cc","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView>("e8f423d0-c018-44f4-a95c-3d490c068c83","","",false, this);
 
            Yearly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "140a5bdb-7209-494c-af45-9fbcb8315754","","",this);
 
            SixMonthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "c75086cd-6748-43b1-bafb-405105a5d0a8","","",this);
 
            ThreeMonthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "b46fb3a6-3399-4b70-a530-050af8cd24f5","","",this);
 
            Monthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "9f23f094-2cbc-42c8-9d4c-cf87701e8df4","","",this);
 
            TwoWeekly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "14f77632-3520-40c1-95de-3943f866daa8","","",this);
 
            Weekly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "2e0bf297-81e6-484e-b470-2dbb28410ab0","","",this);
 
            Daily = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "d6c323e9-42a3-46b1-9bf3-b54b6a68e91d","","",this);
 
            Total = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "621e7554-fcac-4246-b17e-a583167f0c66","","",this);
 
            ByPeriod = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "4ce95b47-eb9c-4ed7-ad7a-e4b75367f52e","","",this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<GenerateDeliveryPlanSLChildDialogView>("4b8c04cf-17ec-47c5-b460-72a712829818","","",true, this);
 
            FirstDay = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "6b812b96-20b0-421e-97d3-a9dee7b7be7d","","",this);
 
            LastDay = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanSLChildDialogView>( "476574b7-4a47-4b03-8aff-c4bec10f1d1b","","",this);
 

        }
        public IRPSComboBox<GenerateDeliveryPlanSLChildDialogView> Customer { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanSLChildDialogView> DateStart { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanSLChildDialogView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanSLChildDialogView> Article { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> Yearly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> SixMonthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> ThreeMonthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> Monthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> TwoWeekly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> Weekly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> Daily { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> Total { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> ByPeriod { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanSLChildDialogView> Quantity { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> FirstDay { get; set; } 
        public IRPSOption<GenerateDeliveryPlanSLChildDialogView> LastDay { get; set; } 
        public DeliveryPlanSL Screen { get; set; }
        public GenerateDeliveryPlanSLChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateOrdersChildDialogView : View
    {
        public GenerateOrdersChildDialogView(DeliveryPlanSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteDeliveryPlan = RPSControlFactory.CreateRPSCheckBox<GenerateOrdersChildDialogView>("a0529a79-1c0a-4e7e-a6e3-2387bb68c6cd","","",false, this);
 

        }
        public IRPSCheckbox<GenerateOrdersChildDialogView> DeleteDeliveryPlan { get; set; } 
        public DeliveryPlanSL Screen { get; set; }
        public GenerateOrdersChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateQuantityChildDialogView : View
    {
        public UpdateQuantityChildDialogView(DeliveryPlanSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            QuantityUpdateIncrement = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("99d64b53-887e-47fd-b58d-8782e75fc438","","",false, this);
 
            QuantityUpdateDecrement = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("e746dd8e-b8f6-4ff3-b516-3afa24740c1c","","",false, this);
 
            QuantityUpdateFixed = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("86fd90e5-1d80-49f2-9e98-9516d3720518","","",false, this);
 

        }
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateIncrement { get; set; } 
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateDecrement { get; set; } 
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateFixed { get; set; } 
        public DeliveryPlanSL Screen { get; set; }
        public UpdateQuantityChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
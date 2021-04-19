    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryPlan
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryPlan:Screen
    {
        public DeliveryPlan():base()
        {
            this.URL = "purchase.deliveryplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryPlanVMCollectionView  = new DeliveryPlanVMCollectionView(this); 
            GenerateDeliveryPlanChildDialogView  = new GenerateDeliveryPlanChildDialogView(this); 
            GenerateOrdersChildDialogView  = new GenerateOrdersChildDialogView(this); 
            UpdateQuantityChildDialogView  = new UpdateQuantityChildDialogView(this); 
            DeliveryPlanView  = new DeliveryPlanView(this); 
            DeliveryPlanVMCollectionView.InitializeControls(); 
            GenerateDeliveryPlanChildDialogView.InitializeControls(); 
            GenerateOrdersChildDialogView.InitializeControls(); 
            UpdateQuantityChildDialogView.InitializeControls(); 
            DeliveryPlanView.InitializeControls(); 
           
        }
      
            public DeliveryPlanVMCollectionView DeliveryPlanVMCollectionView {get; set; } 
            public GenerateDeliveryPlanChildDialogView GenerateDeliveryPlanChildDialogView {get; set; } 
            public GenerateOrdersChildDialogView GenerateOrdersChildDialogView {get; set; } 
            public UpdateQuantityChildDialogView UpdateQuantityChildDialogView {get; set; } 
            public DeliveryPlanView DeliveryPlanView {get; set; } 
    }
            
    public partial class DeliveryPlanVMCollectionView : View
    {
        public DeliveryPlanVMCollectionView(DeliveryPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<DeliveryPlanVMCollectionView>("bd320844-3566-4e18-be7a-1d0f53b30bf5","","",false, this);
 
            DateStart = RPSControlFactory.CreateRPSTextBox<DeliveryPlanVMCollectionView>("182cb968-0f2c-4bab-b1bc-3a2e98648fb9","","",false, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<DeliveryPlanVMCollectionView>("ce03bb5f-694a-4c17-b17e-f98ad3927715","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanVMCollectionView>("c8152563-2881-46a5-952f-eebef416a5fe","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanVMCollectionView>("0d9e2f45-911d-4b45-be98-cdade389f958","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanVMCollectionView>("edf0b4f5-f2a4-4652-bcdc-13307ccfa471","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryPlanVMCollectionView>("79cd3b22-419e-4401-80ed-69a2c9b20627","","",false, this);
 
            RegularSupplier = RPSControlFactory.CreateRPSCheckBox<DeliveryPlanVMCollectionView>("858f0da8-57a2-40e2-919c-6647b53e0ea2","","",false, this);
 
            GenerateDeliveryPlanChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanVMCollectionView,GenerateDeliveryPlanChildDialogView>("cda4c02e-a0cb-4f21-a223-55aaf6d9476a","","", this,Screen.GenerateDeliveryPlanChildDialogView);
 
            GenerateOrdersChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanVMCollectionView,GenerateOrdersChildDialogView>("82a33ccb-57e0-4410-b18e-332507093fbb","","", this,Screen.GenerateOrdersChildDialogView);
 
            UpdateQuantityChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryPlanVMCollectionView,UpdateQuantityChildDialogView>("de795ffd-04fc-4a74-80cc-0324c393f8e2","","", this,Screen.UpdateQuantityChildDialogView);
 
            ExecuteMassiveDeliveryPlanDelete = RPSControlFactory.CreateRPSButton<DeliveryPlanVMCollectionView>( "ac37531e-dd0f-4d73-9fe1-9bebae162e9e","","",this);
 
            CollectionInit params_DeliveryPlanQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="018d31d7-97e2-4880-aebd-cdb7d1f64930",CSSSelectorGrid="",XPathGrid=""};
            DeliveryPlanQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryPlanQueryCollectionEditor<DeliveryPlanVMCollectionView,DeliveryPlanView>,DeliveryPlanVMCollectionView,DeliveryPlanView>( params_DeliveryPlanQuery,this,Screen.DeliveryPlanView);
 

        }
        public IRPSComboBox<DeliveryPlanVMCollectionView> Supplier { get; set; } 
        public IRPSTextBox<DeliveryPlanVMCollectionView> DateStart { get; set; } 
        public IRPSTextBox<DeliveryPlanVMCollectionView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanVMCollectionView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanVMCollectionView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanVMCollectionView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<DeliveryPlanVMCollectionView> Article { get; set; } 
        public IRPSCheckbox<DeliveryPlanVMCollectionView> RegularSupplier { get; set; } 
        public IRPSButton<DeliveryPlanVMCollectionView,GenerateDeliveryPlanChildDialogView> GenerateDeliveryPlanChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanVMCollectionView,GenerateOrdersChildDialogView> GenerateOrdersChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanVMCollectionView,UpdateQuantityChildDialogView> UpdateQuantityChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryPlanVMCollectionView> ExecuteMassiveDeliveryPlanDelete { get; set; } 
        public DeliveryPlanQueryCollectionEditor<DeliveryPlanVMCollectionView,DeliveryPlanView> DeliveryPlanQuery { get; set; } 
        public DeliveryPlan Screen { get; set; }
        public DeliveryPlanVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryPlanQueryCollectionEditor<DeliveryPlanVMCollectionView,DeliveryPlanView>:RPSCollectionEditor<DeliveryPlanVMCollectionView,DeliveryPlanView> where DeliveryPlanVMCollectionView : class, IView where DeliveryPlanView : class, IView
    {
        public  DeliveryPlanQueryGridView<DeliveryPlanVMCollectionView,DeliveryPlanView> GridView {get;set;}
    }
    public partial class DeliveryPlanQueryGridView <DeliveryPlanVMCollectionView,DeliveryPlanView> :  RPSGridView<DeliveryPlanVMCollectionView,DeliveryPlanView> where DeliveryPlanVMCollectionView : class, IView where DeliveryPlanView : class, IView
    {
        public DeliveryPlanQueryGridView(DeliveryPlanVMCollectionView currentView,DeliveryPlanView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DeliveryPlanVMCollectionView>("","#018d31d7-97e2-4880-aebd-cdb7d1f64930 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            PlanDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryPlanVMCollectionView>("","#018d31d7-97e2-4880-aebd-cdb7d1f64930 .ag-row[role='row']@ROWINDEX [col-id='cPlanDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryPlanVMCollectionView>("","#018d31d7-97e2-4880-aebd-cdb7d1f64930 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<DeliveryPlanVMCollectionView>("","#018d31d7-97e2-4880-aebd-cdb7d1f64930 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryPlanVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<DeliveryPlanVMCollectionView> PlanDate { get; set; } 
        public IRPSGridTextBox<DeliveryPlanVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<DeliveryPlanVMCollectionView> IDSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateDeliveryPlanChildDialogView : View
    {
        public GenerateDeliveryPlanChildDialogView(DeliveryPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<GenerateDeliveryPlanChildDialogView>("998f232c-862c-4b84-8c6e-17bd19591227","","",true, this);
 
            DateStart = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryPlanChildDialogView>("42841845-b58a-4d24-a823-515568c90eeb","","",true, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryPlanChildDialogView>("5522f25d-7f24-4ee6-b598-03d1f06aaa79","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView>("7008d55a-bc31-4596-8203-995fa1ef45da","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView>("1cadb7e0-5a02-45cc-be44-310a17e2288d","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView>("f0cda39f-2c50-4cb7-ad31-ce6fff7635df","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView>("f1dd0753-d099-43c1-a1bb-059db74e2c61","","",false, this);
 
            Yearly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "140a5bdb-7209-494c-af45-9fbcb8315754","","",this);
 
            SixMonthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "c75086cd-6748-43b1-bafb-405105a5d0a8","","",this);
 
            ThreeMonthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "b46fb3a6-3399-4b70-a530-050af8cd24f5","","",this);
 
            Monthly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "9f23f094-2cbc-42c8-9d4c-cf87701e8df4","","",this);
 
            TwoWeekly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "14f77632-3520-40c1-95de-3943f866daa8","","",this);
 
            Weekly = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "2e0bf297-81e6-484e-b470-2dbb28410ab0","","",this);
 
            Daily = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "d6c323e9-42a3-46b1-9bf3-b54b6a68e91d","","",this);
 
            Total = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "621e7554-fcac-4246-b17e-a583167f0c66","","",this);
 
            ByPeriod = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "4ce95b47-eb9c-4ed7-ad7a-e4b75367f52e","","",this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<GenerateDeliveryPlanChildDialogView>("4b8c04cf-17ec-47c5-b460-72a712829818","","",true, this);
 
            FirstDay = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "6b812b96-20b0-421e-97d3-a9dee7b7be7d","","",this);
 
            LastDay = RPSControlFactory.CreateRPSOption<GenerateDeliveryPlanChildDialogView>( "476574b7-4a47-4b03-8aff-c4bec10f1d1b","","",this);
 
            RegularSupplier = RPSControlFactory.CreateRPSCheckBox<GenerateDeliveryPlanChildDialogView>("fffd2577-885b-4f3e-898a-e979ca4f41af","","",false, this);
 

        }
        public IRPSComboBox<GenerateDeliveryPlanChildDialogView> Supplier { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanChildDialogView> DateStart { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanChildDialogView> DateEnd { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<GenerateDeliveryPlanChildDialogView> Article { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> Yearly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> SixMonthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> ThreeMonthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> Monthly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> TwoWeekly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> Weekly { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> Daily { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> Total { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> ByPeriod { get; set; } 
        public IRPSTextBox<GenerateDeliveryPlanChildDialogView> Quantity { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> FirstDay { get; set; } 
        public IRPSOption<GenerateDeliveryPlanChildDialogView> LastDay { get; set; } 
        public IRPSCheckbox<GenerateDeliveryPlanChildDialogView> RegularSupplier { get; set; } 
        public DeliveryPlan Screen { get; set; }
        public GenerateDeliveryPlanChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateOrdersChildDialogView : View
    {
        public GenerateOrdersChildDialogView(DeliveryPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteDeliveryPlan = RPSControlFactory.CreateRPSCheckBox<GenerateOrdersChildDialogView>("fa93c441-e58f-4e6e-a493-83ac2081ba92","","",false, this);
 

        }
        public IRPSCheckbox<GenerateOrdersChildDialogView> DeleteDeliveryPlan { get; set; } 
        public DeliveryPlan Screen { get; set; }
        public GenerateOrdersChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateQuantityChildDialogView : View
    {
        public UpdateQuantityChildDialogView(DeliveryPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            QuantityUpdateIncrement = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("51a17d07-77be-4e1a-ad6a-ca0489679ed8","","",false, this);
 
            QuantityUpdateDecrement = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("a9e289c1-ad19-4b79-a3f9-65643aefc4e7","","",false, this);
 
            QuantityUpdateFixed = RPSControlFactory.CreateRPSFormattedTextBox<UpdateQuantityChildDialogView>("d3047e93-9c8e-4f62-a0b5-9dd5a7f6d760","","",false, this);
 

        }
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateIncrement { get; set; } 
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateDecrement { get; set; } 
        public IRPSTextBox<UpdateQuantityChildDialogView> QuantityUpdateFixed { get; set; } 
        public DeliveryPlan Screen { get; set; }
        public UpdateQuantityChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryPlanView : View
    {
        public DeliveryPlanView(DeliveryPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryPlanView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryPlanView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryPlanView,DeliveryPlanVMCollectionView>( this,Screen.DeliveryPlanVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryPlanView,DeliveryPlanVMCollectionView>( this,Screen.DeliveryPlanVMCollectionView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DeliveryPlanView>("cb03d564-e30a-46b6-bdd4-2bb77c7a21b4","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<DeliveryPlanView>("b78bca04-e7f1-401b-9774-a6a48344a583","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryPlanView>("24af570a-9671-4ac0-85d4-288012d1f17d","","",true, this);
 
            PlanDate = RPSControlFactory.CreateRPSTextBox<DeliveryPlanView>("fd6cfce4-a8ff-4624-8761-bfbc38907740","","",true, this);
 

        }
        public IRPSSaveButton<DeliveryPlanView> SaveButton { get; set; } 
        public IRPSButton<DeliveryPlanView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryPlanView,DeliveryPlanVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryPlanView,DeliveryPlanVMCollectionView> BackButton { get; set; } 
        public IRPSComboBox<DeliveryPlanView> IDSupplier { get; set; } 
        public IRPSComboBox<DeliveryPlanView> IDArticle { get; set; } 
        public IRPSTextBox<DeliveryPlanView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryPlanView> PlanDate { get; set; } 
        public DeliveryPlan Screen { get; set; }
        public DeliveryPlanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
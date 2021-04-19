    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerGroupSL:Screen
    {
        public CustomerGroupSL():base()
        {
            this.URL = "sales.customergroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerGroupSLCollectionView  = new CustomerGroupSLCollectionView(this); 
            CustomerGroupSLEntityView  = new CustomerGroupSLEntityView(this); 
            CustomerGroupValueSLView  = new CustomerGroupValueSLView(this); 
            CustomerGroupByLangSLView  = new CustomerGroupByLangSLView(this); 
            CustomerGroupSLCollectionView.InitializeControls(); 
            CustomerGroupSLEntityView.InitializeControls(); 
            CustomerGroupValueSLView.InitializeControls(); 
            CustomerGroupByLangSLView.InitializeControls(); 
           
        }
      
            public CustomerGroupSLCollectionView CustomerGroupSLCollectionView {get; set; } 
            public CustomerGroupSLEntityView CustomerGroupSLEntityView {get; set; } 
            public CustomerGroupValueSLView CustomerGroupValueSLView {get; set; } 
            public CustomerGroupByLangSLView CustomerGroupByLangSLView {get; set; } 
    }
            
    public partial class CustomerGroupSLCollectionView : View
    {
        public CustomerGroupSLCollectionView(CustomerGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerGroupSLCollectionView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "66a50b65-284e-4c1e-82cc-74102df3c39a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerGroupSLCollectionView,CustomerGroupSLEntityView>( params_MainConsult,this,Screen.CustomerGroupSLEntityView);
 

        }
        public IRPSButton<CustomerGroupSLCollectionView,CustomerGroupSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerGroupSLCollectionView,CustomerGroupSLEntityView> MainConsult { get; set; } 
        public CustomerGroupSL Screen { get; set; }
        public CustomerGroupSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerGroupSLEntityView : View
    {
        public CustomerGroupSLEntityView(CustomerGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerGroupSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView>( this,Screen.CustomerGroupSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView>( this,Screen.CustomerGroupSLCollectionView);
 
            CodCustomerGroup = RPSControlFactory.CreateRPSTextBox<CustomerGroupSLEntityView>("d269698f-4bf3-405b-ad06-713a43e582e9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerGroupSLEntityView>("b9267bc5-fb44-4563-8007-0374e36b2aa7","","",false, this);
 
            CollectionInit params_CustomerGroupValueSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dcbed224-70f6-4273-88cd-e60fe035cae7",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupValueSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupValueSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>,CustomerGroupSLEntityView,CustomerGroupValueSLView>( params_CustomerGroupValueSLs,this,Screen.CustomerGroupValueSLView);
 
            CollectionInit params_CustomerGroupByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="28422cf7-121b-49ca-9967-9fc3abd0069f",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupByLangSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>,CustomerGroupSLEntityView,CustomerGroupValueSLView>( params_CustomerGroupByLangSLs,this,Screen.CustomerGroupValueSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerGroupSLEntityView>( "","ul li[rpsid='eb03bb16-204e-4672-8a77-42b2f62a4564']","",this);
 
            ByLang = RPSControlFactory.CreateRPSSection<CustomerGroupSLEntityView>( "","ul li[rpsid='9f37da1e-2ed7-4f5a-8b6d-fb50ce3d9204']","",this);
 

        }
        public IRPSSaveButton<CustomerGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerGroupSLEntityView> CodCustomerGroup { get; set; } 
        public IRPSTextBox<CustomerGroupSLEntityView> Description { get; set; } 
        public CustomerGroupValueSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> CustomerGroupValueSLs { get; set; } 
        public CustomerGroupByLangSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> CustomerGroupByLangSLs { get; set; } 
        public IRPSSection<CustomerGroupSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerGroupSLEntityView> ByLang { get; set; } 
        public CustomerGroupSL Screen { get; set; }
        public CustomerGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupValueSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>:RPSCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public  CustomerGroupValueSLsGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> GridView {get;set;}
    }
    public partial class CustomerGroupValueSLsGridView <CustomerGroupSLEntityView,CustomerGroupValueSLView> :  RPSGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public CustomerGroupValueSLsGridView(CustomerGroupSLEntityView currentView,CustomerGroupValueSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupSLEntityView>("","#dcbed224-70f6-4273-88cd-e60fe035cae7 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupSLEntityView>("","#dcbed224-70f6-4273-88cd-e60fe035cae7 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerGroupSLEntityView> Value { get; set; } 
        public IRPSGridComboBox<CustomerGroupSLEntityView> IDCustomer { get; set; } 
                     
    }
 
        public partial class CustomerGroupByLangSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>:RPSCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public  CustomerGroupByLangSLsGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> GridView {get;set;}
    }
    public partial class CustomerGroupByLangSLsGridView <CustomerGroupSLEntityView,CustomerGroupValueSLView> :  RPSGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public CustomerGroupByLangSLsGridView(CustomerGroupSLEntityView currentView,CustomerGroupValueSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupSLEntityView>("","#28422cf7-121b-49ca-9967-9fc3abd0069f .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupSLEntityView>("","#28422cf7-121b-49ca-9967-9fc3abd0069f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CustomerGroupSLEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerGroupValueSLView : View
    {
        public CustomerGroupValueSLView(CustomerGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupValueSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupValueSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupValueSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupValueSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            Value = RPSControlFactory.CreateRPSTextBox<CustomerGroupValueSLView>("d20c5235-2e70-47b0-802d-dddb320944d8","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerGroupValueSLView>("4dffb015-020a-4625-972c-d6f5755352af","","",false, this);
 

        }
        public IRPSButton<CustomerGroupValueSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupValueSLView,CustomerGroupSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupValueSLView,CustomerGroupSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupValueSLView,CustomerGroupSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerGroupValueSLView> Value { get; set; } 
        public IRPSComboBox<CustomerGroupValueSLView> IDCustomer { get; set; } 
        public CustomerGroupSL Screen { get; set; }
        public CustomerGroupValueSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerGroupByLangSLView : View
    {
        public CustomerGroupByLangSLView(CustomerGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerGroupByLangSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView>( this,Screen.CustomerGroupSLEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerGroupByLangSLView>("913ea185-f27b-4562-8005-b125981f0449","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerGroupByLangSLView>("95a19e89-ebd0-49b1-8f3e-ffb26c544600","","",false, this);
 

        }
        public IRPSButton<CustomerGroupByLangSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerGroupByLangSLView,CustomerGroupSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerGroupByLangSLView> CodLanguage { get; set; } 
        public IRPSTextBox<CustomerGroupByLangSLView> Description { get; set; } 
        public CustomerGroupSL Screen { get; set; }
        public CustomerGroupByLangSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
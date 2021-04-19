    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.CustomerGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerGroupSL:Screen
    {
        public CustomerGroupSL():base()
        {
            this.URL = "receivablepayable.customergroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerGroupSLCollectionView  = new CustomerGroupSLCollectionView(this); 
            CustomerGroupSLEntityView  = new CustomerGroupSLEntityView(this); 
            CustomerGroupByLangSLView  = new CustomerGroupByLangSLView(this); 
            CustomerGroupValueSLView  = new CustomerGroupValueSLView(this); 
            CustomerGroupSLCollectionView.InitializeControls(); 
            CustomerGroupSLEntityView.InitializeControls(); 
            CustomerGroupByLangSLView.InitializeControls(); 
            CustomerGroupValueSLView.InitializeControls(); 
           
        }
      
            public CustomerGroupSLCollectionView CustomerGroupSLCollectionView {get; set; } 
            public CustomerGroupSLEntityView CustomerGroupSLEntityView {get; set; } 
            public CustomerGroupByLangSLView CustomerGroupByLangSLView {get; set; } 
            public CustomerGroupValueSLView CustomerGroupValueSLView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "251581b6-b7b1-4453-a9da-ff69bf4efa8b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomerGroup = RPSControlFactory.CreateRPSTextBox<CustomerGroupSLEntityView>("582ba672-7893-4c8c-bee4-5667183fb78c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerGroupSLEntityView>("9302f09a-4ed5-4b09-8a26-808c5a9146b8","","",false, this);
 
            CollectionInit params_CustomerGroupValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f82eb25c-63f9-4c7c-a55a-882d6390d8b4",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupValues = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupValuesCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>,CustomerGroupSLEntityView,CustomerGroupValueSLView>( params_CustomerGroupValues,this,Screen.CustomerGroupValueSLView);
 
            CollectionInit params_CustomerGroupByLangSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a132ecb4-12a1-4a24-994e-a976823777d9",CSSSelectorGrid="",XPathGrid=""};
            CustomerGroupByLangSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerGroupByLangSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>,CustomerGroupSLEntityView,CustomerGroupValueSLView>( params_CustomerGroupByLangSLs,this,Screen.CustomerGroupValueSLView);
 
            SectionGeneralData = RPSControlFactory.CreateRPSSection<CustomerGroupSLEntityView>( "","ul li[rpsid='42ea99c1-3aea-4f1c-acfb-5d113e405334']","",this);
 
            SectionLanguages = RPSControlFactory.CreateRPSSection<CustomerGroupSLEntityView>( "","ul li[rpsid='3a023b86-9f2d-4806-8230-9eb93f35ef63']","",this);
 

        }
        public IRPSSaveButton<CustomerGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerGroupSLEntityView,CustomerGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerGroupSLEntityView> CodCustomerGroup { get; set; } 
        public IRPSTextBox<CustomerGroupSLEntityView> Description { get; set; } 
        public CustomerGroupValuesCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> CustomerGroupValues { get; set; } 
        public CustomerGroupByLangSLsCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> CustomerGroupByLangSLs { get; set; } 
        public IRPSSection<CustomerGroupSLEntityView> SectionGeneralData { get; set; } 
        public IRPSSection<CustomerGroupSLEntityView> SectionLanguages { get; set; } 
        public CustomerGroupSL Screen { get; set; }
        public CustomerGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerGroupValuesCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView>:RPSCollectionEditor<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public  CustomerGroupValuesGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> GridView {get;set;}
    }
    public partial class CustomerGroupValuesGridView <CustomerGroupSLEntityView,CustomerGroupValueSLView> :  RPSGridView<CustomerGroupSLEntityView,CustomerGroupValueSLView> where CustomerGroupSLEntityView : class, IView where CustomerGroupValueSLView : class, IView
    {
        public CustomerGroupValuesGridView(CustomerGroupSLEntityView currentView,CustomerGroupValueSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupSLEntityView>("","#f82eb25c-63f9-4c7c-a55a-882d6390d8b4 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupSLEntityView>("","#f82eb25c-63f9-4c7c-a55a-882d6390d8b4 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",false, this.CurrentView);
 

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
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CustomerGroupSLEntityView>("","#a132ecb4-12a1-4a24-994e-a976823777d9 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerGroupSLEntityView>("","#a132ecb4-12a1-4a24-994e-a976823777d9 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerGroupSLEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CustomerGroupSLEntityView> Description { get; set; } 
                     
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerGroupByLangSLView>("2e3806b2-279a-4dba-96e1-419dcf0d5ab7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerGroupByLangSLView>("47356fad-35ba-4111-a457-0c7dde8846a7","","",false, this);
 

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
 
            Value = RPSControlFactory.CreateRPSTextBox<CustomerGroupValueSLView>("cfa28142-fbc1-4e8c-8e50-6409e3c3e869","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerGroupValueSLView>("86780751-2e79-4a4b-9b82-81eb6a537cf9","","",false, this);
 

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
  
    

}
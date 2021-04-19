    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.BusinessUnitUser
{
    //RPS VERSION 1.0.0.0
    public partial class BusinessUnitUser:Screen
    {
        public BusinessUnitUser():base()
        {
            this.URL = "general.businessunituser";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BusinessUnitCollectionView  = new BusinessUnitCollectionView(this); 
            BusinessUnitEntityView  = new BusinessUnitEntityView(this); 
            BusinessUnitUserView  = new BusinessUnitUserView(this); 
            BusinessUnitVMPropagateUserControlCommandChildDialogView  = new BusinessUnitVMPropagateUserControlCommandChildDialogView(this); 
            BusinessUnitCollectionView.InitializeControls(); 
            BusinessUnitEntityView.InitializeControls(); 
            BusinessUnitUserView.InitializeControls(); 
            BusinessUnitVMPropagateUserControlCommandChildDialogView.InitializeControls(); 
           
        }
      
            public BusinessUnitCollectionView BusinessUnitCollectionView {get; set; } 
            public BusinessUnitEntityView BusinessUnitEntityView {get; set; } 
            public BusinessUnitUserView BusinessUnitUserView {get; set; } 
            public BusinessUnitVMPropagateUserControlCommandChildDialogView BusinessUnitVMPropagateUserControlCommandChildDialogView {get; set; } 
    }
            
    public partial class BusinessUnitCollectionView : View
    {
        public BusinessUnitCollectionView(BusinessUnitUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BusinessUnitCollectionView,BusinessUnitEntityView>( this,Screen.BusinessUnitEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "916a00ec-a234-49d4-abf8-75db3ce19de3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BusinessUnitCollectionView,BusinessUnitEntityView>( params_MainConsult,this,Screen.BusinessUnitEntityView);
 

        }
        public IRPSButton<BusinessUnitCollectionView,BusinessUnitEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BusinessUnitCollectionView,BusinessUnitEntityView> MainConsult { get; set; } 
        public BusinessUnitUser Screen { get; set; }
        public BusinessUnitCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BusinessUnitEntityView : View
    {
        public BusinessUnitEntityView(BusinessUnitUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BusinessUnitEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BusinessUnitEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BusinessUnitEntityView,BusinessUnitCollectionView>( this,Screen.BusinessUnitCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BusinessUnitEntityView,BusinessUnitCollectionView>( this,Screen.BusinessUnitCollectionView);
 
            CodBusinessUnit = RPSControlFactory.CreateRPSTextBox<BusinessUnitEntityView>("3c603920-9b6d-43f9-9a92-081c84457d76","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BusinessUnitEntityView>("e827edf9-224e-445b-bf70-b422d6d244d4","","",false, this);
 
            BusinessType = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitEntityView>("44091a09-a5dd-488c-880e-10758f980d02","","",true, this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<BusinessUnitEntityView>( "ecfe54a2-02e8-4c84-9e12-cb3ab992716e","","",this);
 
            PropagateUserControlCommandLink = RPSControlFactory.CreateRPSButton<BusinessUnitEntityView>( "c46a4078-c689-462d-b186-1ae3b38b295d","","",this);
 
            CollectionInit params_BusinessUnitUSer = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0121904b-1fb1-47bd-8bb2-d5473be4e154",CSSSelectorGrid="",XPathGrid=""};
            BusinessUnitUSer = RPSControlFactory.RPSCreateCollectionWithGrid<BusinessUnitUSerCollectionEditor<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView>,BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView>( params_BusinessUnitUSer,this,Screen.BusinessUnitVMPropagateUserControlCommandChildDialogView);
 

        }
        public IRPSSaveButton<BusinessUnitEntityView> SaveButton { get; set; } 
        public IRPSButton<BusinessUnitEntityView> DeleteButton { get; set; } 
        public IRPSButton<BusinessUnitEntityView,BusinessUnitCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BusinessUnitEntityView,BusinessUnitCollectionView> BackButton { get; set; } 
        public IRPSTextBox<BusinessUnitEntityView> CodBusinessUnit { get; set; } 
        public IRPSTextBox<BusinessUnitEntityView> Description { get; set; } 
        public IRPSComboBox<BusinessUnitEntityView> BusinessType { get; set; } 
        public IRPSButton<BusinessUnitEntityView> LinkNavigationCommand { get; set; } 
        public IRPSButton<BusinessUnitEntityView> PropagateUserControlCommandLink { get; set; } 
        public BusinessUnitUSerCollectionEditor<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView> BusinessUnitUSer { get; set; } 
        public BusinessUnitUser Screen { get; set; }
        public BusinessUnitEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BusinessUnitUSerCollectionEditor<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView>:RPSCollectionEditor<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView> where BusinessUnitEntityView : class, IView where BusinessUnitVMPropagateUserControlCommandChildDialogView : class, IView
    {
        public  BusinessUnitUSerGridView<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView> GridView {get;set;}
    }
    public partial class BusinessUnitUSerGridView <BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView> :  RPSGridView<BusinessUnitEntityView,BusinessUnitVMPropagateUserControlCommandChildDialogView> where BusinessUnitEntityView : class, IView where BusinessUnitVMPropagateUserControlCommandChildDialogView : class, IView
    {
        public BusinessUnitUSerGridView(BusinessUnitEntityView currentView,BusinessUnitVMPropagateUserControlCommandChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecuteDeleteBusinessUnitUser = RPSControlFactory.CreateRPSGridButton<BusinessUnitEntityView>( "","#0121904b-1fb1-47bd-8bb2-d5473be4e154 .ag-row[role='row']@ROWINDEX [col-id='cExecuteDeleteBusinessUnitUser']","",this.CurrentView);
 

        }
        public IRPSGridButton<BusinessUnitEntityView> ExecuteDeleteBusinessUnitUser { get; set; } 
                     
    }
 
    }
  
            
    public partial class BusinessUnitUserView : View
    {
        public BusinessUnitUserView(BusinessUnitUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BusinessUnitUserView>( this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<BusinessUnitUserView>("fbb026bb-1fc6-4059-b9c2-31378e2d0442","","",true, this);
 
            OrderPermission = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitUserView>("38bb778a-d07d-456b-a6a8-1123c3207c2e","","",true, this);
 
            DeliveryNotePermission = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitUserView>("61faba3b-86e7-440d-9d7f-f3d55147aba6","","",true, this);
 
            InvoicePermission = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitUserView>("aafd696e-aaac-428c-b2b9-4ff1653897b1","","",true, this);
 
            SalesQuotePermission = RPSControlFactory.CreateRPSEnumComboBox<BusinessUnitUserView>("5f2846a5-13a2-47d1-85ea-ecf4c1672db6","","",true, this);
 

        }
        public IRPSSaveButton<BusinessUnitUserView> SaveButton { get; set; } 
        public IRPSComboBox<BusinessUnitUserView> CodUser { get; set; } 
        public IRPSComboBox<BusinessUnitUserView> OrderPermission { get; set; } 
        public IRPSComboBox<BusinessUnitUserView> DeliveryNotePermission { get; set; } 
        public IRPSComboBox<BusinessUnitUserView> InvoicePermission { get; set; } 
        public IRPSComboBox<BusinessUnitUserView> SalesQuotePermission { get; set; } 
        public BusinessUnitUser Screen { get; set; }
        public BusinessUnitUserView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BusinessUnitVMPropagateUserControlCommandChildDialogView : View
    {
        public BusinessUnitVMPropagateUserControlCommandChildDialogView(BusinessUnitUser screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            All = RPSControlFactory.CreateRPSOption<BusinessUnitVMPropagateUserControlCommandChildDialogView>( "54774d0a-b782-4983-b5cf-882ae70efa0a","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<BusinessUnitVMPropagateUserControlCommandChildDialogView>( "27c057ee-dca9-47cb-8395-7579a9691362","","",this);
 
            BusinessUnit = RPSControlFactory.CreateRPSCollectionComboBox<BusinessUnitVMPropagateUserControlCommandChildDialogView>("ff29ebc5-925e-487e-a54b-a01f038d6b80","","",false, this);
 
            ExecutePropagateBusinessUnitUser = RPSControlFactory.CreateRPSButton<BusinessUnitVMPropagateUserControlCommandChildDialogView>( "7790f4e9-255d-47a0-bb19-42984a630d7d","","",this);
 

        }
        public IRPSOption<BusinessUnitVMPropagateUserControlCommandChildDialogView> All { get; set; } 
        public IRPSOption<BusinessUnitVMPropagateUserControlCommandChildDialogView> Selected { get; set; } 
        public IRPSCollectionComboBox<BusinessUnitVMPropagateUserControlCommandChildDialogView> BusinessUnit { get; set; } 
        public IRPSButton<BusinessUnitVMPropagateUserControlCommandChildDialogView> ExecutePropagateBusinessUnitUser { get; set; } 
        public BusinessUnitUser Screen { get; set; }
        public BusinessUnitVMPropagateUserControlCommandChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
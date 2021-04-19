    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ShippingAgentSL
{
    //RPS VERSION 1.0.0.0
    public partial class ShippingAgentSL:Screen
    {
        public ShippingAgentSL():base()
        {
            this.URL = "sales.shippingagentsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ShippingAgentSLCollectionView  = new ShippingAgentSLCollectionView(this); 
            ShippingAgentSLEntityView  = new ShippingAgentSLEntityView(this); 
            ShippingAgentSLCollectionView.InitializeControls(); 
            ShippingAgentSLEntityView.InitializeControls(); 
           
        }
      
            public ShippingAgentSLCollectionView ShippingAgentSLCollectionView {get; set; } 
            public ShippingAgentSLEntityView ShippingAgentSLEntityView {get; set; } 
    }
            
    public partial class ShippingAgentSLCollectionView : View
    {
        public ShippingAgentSLCollectionView(ShippingAgentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ShippingAgentSLCollectionView,ShippingAgentSLEntityView>( this,Screen.ShippingAgentSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2358cb0d-59d9-4635-b893-404b909360b9",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ShippingAgentSLCollectionView,ShippingAgentSLEntityView>( params_MainConsult,this,Screen.ShippingAgentSLEntityView);
 

        }
        public IRPSButton<ShippingAgentSLCollectionView,ShippingAgentSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ShippingAgentSLCollectionView,ShippingAgentSLEntityView> MainConsult { get; set; } 
        public ShippingAgentSL Screen { get; set; }
        public ShippingAgentSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ShippingAgentSLEntityView : View
    {
        public ShippingAgentSLEntityView(ShippingAgentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ShippingAgentSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ShippingAgentSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView>( this,Screen.ShippingAgentSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView>( this,Screen.ShippingAgentSLCollectionView);
 
            CodShippingAgent = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("ae95cbc4-2031-4e92-9be1-3279009b5782","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("76cdeb45-f5e4-49ae-bf3a-23174cde7cee","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("e8b03c21-3255-4b7f-80ef-6da76fc823a1","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<ShippingAgentSLEntityView>("e1f64685-769c-430e-8f96-a0f65437d1fe","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ShippingAgentSLEntityView>("438d082f-d2c6-4412-999f-ac7e327f792c","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("1bed1c33-448c-4ed3-9bac-77a7c2311f61","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("0848af3a-c966-47a3-ac3d-ac2db5521bb3","","",false, this);
 
            IDShippingVehicle = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("d65d90e2-54c3-4d24-abb9-da23cb3c6090","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("046db56c-a02b-4d19-a104-ecc37a3266d3","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("d29e961d-eb3c-4d31-ac00-d61698c01ffe","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("2549cf54-f2eb-45b7-9cf7-ca2f4d969f48","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("aca60ad9-480b-4bd4-a03d-feb9db20e550","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("4210f2d7-ea56-4707-a424-abf0501d2a1e","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("418c5aef-9395-4796-ba75-becb3c85358e","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("8e8a9900-7009-4921-ba78-21fee10b7558","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("bc481e52-f70f-45ca-9d37-9b83b6b56c86","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("93447988-adb0-4013-844d-0fe7907e1064","","",false, this);
 
            Email1 = RPSControlFactory.CreateRPSEmailTextBox<ShippingAgentSLEntityView>("7caafc86-6cab-4107-bf7e-47b0bfdec3ad","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("8a1d7397-27bc-4601-ad67-f138e3dd8ff4","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("04a6e435-ebe0-4ae9-9238-539f5b1980c2","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<ShippingAgentSLEntityView>( "","ul li[rpsid='bc04a839-749a-4c7c-9456-1b408b69049d']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<ShippingAgentSLEntityView>( "","ul li[rpsid='598e8ba9-b3d7-4dcc-964f-330f9af6d800']","",this);
 

        }
        public IRPSSaveButton<ShippingAgentSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> CodShippingAgent { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Description { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> Type { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDShippingVehicle { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDState { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Address { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> City { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Email1 { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Fax { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Comment { get; set; } 
        public IRPSSection<ShippingAgentSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<ShippingAgentSLEntityView> CommentSection { get; set; } 
        public ShippingAgentSL Screen { get; set; }
        public ShippingAgentSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
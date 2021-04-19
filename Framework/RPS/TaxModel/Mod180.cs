    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod180
{
    //RPS VERSION 1.0.0.0
    public partial class Mod180:Screen
    {
        public Mod180():base()
        {
            this.URL = "taxmodel.mod180";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod180View  = new Mod180View(this); 
            AddressDialogView  = new AddressDialogView(this); 
            Mod180View.InitializeControls(); 
            AddressDialogView.InitializeControls(); 
           
        }
      
            public Mod180View Mod180View {get; set; } 
            public AddressDialogView AddressDialogView {get; set; } 
    }
            
    public partial class Mod180View : View
    {
        public Mod180View(Mod180 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<Mod180View>("c7d01f12-a21c-485f-9402-9987bf9bc81b","","",false, this);
 
            OptionEjercicio = RPSControlFactory.CreateRPSEnumComboBox<Mod180View>("35689b44-3a56-4760-a47e-c8b88eb56eed","","",true, this);
 
            GetDataBeforeCommand = RPSControlFactory.CreateRPSButton<Mod180View>( "c6a13c16-e1b6-474a-9143-7c06fc3d9b3f","","",this);
 
            Prefix = RPSControlFactory.CreateRPSTextBox<Mod180View>("670a9243-2fd9-4d11-a5ab-db41e4ca8e3c","","",false, this);
 
            NumJustificante = RPSControlFactory.CreateRPSTextBox<Mod180View>("e322bd27-a556-44e9-8c8d-4534b907fb53","","",false, this);
 
            OptionTipoDeclaracion = RPSControlFactory.CreateRPSEnumComboBox<Mod180View>("d7a68a1f-5fa1-4f9b-bc2d-c67b047c7897","","",true, this);
 
            Prefix1 = RPSControlFactory.CreateRPSTextBox<Mod180View>("7859449b-f534-4fe2-a2e6-3ca6f5fc108e","","",false, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod180View>("9978ec3b-0eac-46b9-8133-dc749b9fe005","","",false, this);
 
            OptionSoporte = RPSControlFactory.CreateRPSEnumComboBox<Mod180View>("ee444f4f-dcdf-48a1-ac9b-7f5f7725db95","","",true, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<Mod180View>("32e40194-3aca-4a4d-8bae-0dfc825155f2","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<Mod180View>("ce805cf5-2ce4-4949-8eba-1449ef42e225","","",false, this);
 
            GenerateBeforeCommandButton = RPSControlFactory.CreateRPSButton<Mod180View>( "3fd8455e-6250-45bd-9586-9e5a953a9f6e","","",this);
 
            CollectionInit params_GetMod180Data = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0413ad62-6aa8-4c08-9a6b-df3e55f49ac9",CSSSelectorGrid="",XPathGrid=""};
            GetMod180Data = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod180DataCollectionEditor<Mod180View>,Mod180View>( params_GetMod180Data,this);
 

        }
        public IRPSTextBox<Mod180View> Year { get; set; } 
        public IRPSComboBox<Mod180View> OptionEjercicio { get; set; } 
        public IRPSButton<Mod180View> GetDataBeforeCommand { get; set; } 
        public IRPSTextBox<Mod180View> Prefix { get; set; } 
        public IRPSTextBox<Mod180View> NumJustificante { get; set; } 
        public IRPSComboBox<Mod180View> OptionTipoDeclaracion { get; set; } 
        public IRPSTextBox<Mod180View> Prefix1 { get; set; } 
        public IRPSTextBox<Mod180View> NumJustificanteAnterior { get; set; } 
        public IRPSComboBox<Mod180View> OptionSoporte { get; set; } 
        public IRPSTextBox<Mod180View> ContactPerson { get; set; } 
        public IRPSTextBox<Mod180View> Phone { get; set; } 
        public IRPSButton<Mod180View> GenerateBeforeCommandButton { get; set; } 
        public GetMod180DataCollectionEditor<Mod180View> GetMod180Data { get; set; } 
        public Mod180 Screen { get; set; }
        public Mod180View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod180DataCollectionEditor<Mod180View>:RPSCollectionEditor<Mod180View> where Mod180View : class, IView
    {
        public  GetMod180DataGridView<Mod180View> GridView {get;set;}
    }
    public partial class GetMod180DataGridView <Mod180View> :  RPSGridView<Mod180View> where Mod180View : class, IView
    {
        public GetMod180DataGridView(Mod180View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierVAT = RPSControlFactory.CreateRPSGridTextBox<Mod180View>("","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cSupplierVAT']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<Mod180View>("","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            SupplierState = RPSControlFactory.CreateRPSGridTextBox<Mod180View>("","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cSupplierState']","",false, this.CurrentView);
 
            Situation = RPSControlFactory.CreateRPSGridTextBox<Mod180View>("","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cSituation']","",false, this.CurrentView);
 
            CadastralReference = RPSControlFactory.CreateRPSGridTextBox<Mod180View>("","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cCadastralReference']","",false, this.CurrentView);
 
            LinkToAddress = RPSControlFactory.CreateRPSGridButton<Mod180View>( "","#0413ad62-6aa8-4c08-9a6b-df3e55f49ac9 .ag-row[role='row']@ROWINDEX [col-id='cLinkToAddress']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod180View> SupplierVAT { get; set; } 
        public IRPSGridTextBox<Mod180View> SupplierName { get; set; } 
        public IRPSGridTextBox<Mod180View> SupplierState { get; set; } 
        public IRPSGridTextBox<Mod180View> Situation { get; set; } 
        public IRPSGridTextBox<Mod180View> CadastralReference { get; set; } 
        public IRPSGridButton<Mod180View> LinkToAddress { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddressDialogView : View
    {
        public AddressDialogView(Mod180 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Address_StreetType = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("77c24869-59ff-4abe-8ac8-c3cb77592905","","",false, this);
 
            Address_StreetName = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("4f5cd53a-8747-46e6-aa93-44cd5a59f00b","","",false, this);
 
            Address_NumberType = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("ebe9e61a-cd54-4ef2-a1bc-6114941206da","","",false, this);
 
            Address_Number = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("081644f8-4b24-45a8-8b13-3b1270f890c4","","",false, this);
 
            Address_NumberExtension = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("9c071464-01b1-4aee-a20d-ddbec9be3684","","",false, this);
 
            Address_Block = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("e3a765a4-8219-4eb9-a4ea-6c2c46cde025","","",false, this);
 
            Address_House = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("2be7da64-2cd2-488e-a5a3-1464b76de55b","","",false, this);
 
            Address_Stairs = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("582239fa-a46b-4be6-a0e1-be4de09bb37b","","",false, this);
 
            Address_Floor = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("4f70c2c1-d163-497e-9a9b-55732176605f","","",false, this);
 
            Address_Door = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("337bf856-8b48-43ea-a072-90c9eb15eb91","","",false, this);
 
            Address_Extension = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("e8e8d1e0-554a-4da1-8b0d-cbf1112dc2c4","","",false, this);
 
            Address_Town = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("4f920953-2087-4e6e-87f5-d62ecc577c43","","",false, this);
 
            Address_City = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("1c631725-51c0-423f-8b03-05281801215b","","",false, this);
 
            Address_CityCode = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("7fe694ca-46b5-475b-9651-0cb6f6f056f6","","",false, this);
 
            Address_StateCode = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("11a138a3-cb35-4045-b956-43f0b8dbeca7","","",false, this);
 
            Address_ZipCode = RPSControlFactory.CreateRPSTextBox<AddressDialogView>("7968d520-7515-48e1-9464-2a1fc1d41f7a","","",false, this);
 

        }
        public IRPSTextBox<AddressDialogView> Address_StreetType { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_StreetName { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_NumberType { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Number { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_NumberExtension { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Block { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_House { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Stairs { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Floor { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Door { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Extension { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_Town { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_City { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_CityCode { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_StateCode { get; set; } 
        public IRPSTextBox<AddressDialogView> Address_ZipCode { get; set; } 
        public Mod180 Screen { get; set; }
        public AddressDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
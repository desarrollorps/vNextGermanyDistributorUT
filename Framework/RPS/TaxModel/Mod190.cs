    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod190
{
    //RPS VERSION 1.0.0.0
    public partial class Mod190:Screen
    {
        public Mod190():base()
        {
            this.URL = "taxmodel.mod190";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod190View  = new Mod190View(this); 
            Mod190View.InitializeControls(); 
           
        }
      
            public Mod190View Mod190View {get; set; } 
    }
            
    public partial class Mod190View : View
    {
        public Mod190View(Mod190 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<Mod190View>("c7d01f12-a21c-485f-9402-9987bf9bc81b","","",true, this);
 
            OptionEjercicio = RPSControlFactory.CreateRPSEnumComboBox<Mod190View>("35689b44-3a56-4760-a47e-c8b88eb56eed","","",true, this);
 
            ExecuteGetMod190Data = RPSControlFactory.CreateRPSButton<Mod190View>( "4a5fcc0e-a62a-4201-8631-ca2e22fdc938","","",this);
 
            NumJustificante = RPSControlFactory.CreateRPSTextBox<Mod190View>("e322bd27-a556-44e9-8c8d-4534b907fb53","","",false, this);
 
            OptionTipoDeclaracion = RPSControlFactory.CreateRPSEnumComboBox<Mod190View>("d7a68a1f-5fa1-4f9b-bc2d-c67b047c7897","","",true, this);
 
            NumJustificanteAnterior = RPSControlFactory.CreateRPSTextBox<Mod190View>("9978ec3b-0eac-46b9-8133-dc749b9fe005","","",false, this);
 
            OptionSoporte = RPSControlFactory.CreateRPSEnumComboBox<Mod190View>("ee444f4f-dcdf-48a1-ac9b-7f5f7725db95","","",true, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<Mod190View>("32e40194-3aca-4a4d-8bae-0dfc825155f2","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<Mod190View>("ce805cf5-2ce4-4949-8eba-1449ef42e225","","",false, this);
 
            EmailContact = RPSControlFactory.CreateRPSTextBox<Mod190View>("a34ff94c-f47a-42c6-8ca4-4408f6e89b92","","",false, this);
 
            ExecuteGenerateMod190Button = RPSControlFactory.CreateRPSButton<Mod190View>( "ed724c22-9938-4202-b275-b552612bd190","","",this);
 
            CollectionInit params_GetMod190Data = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1f2b37c7-6508-40f1-97a4-08fa2d750434",CSSSelectorGrid="",XPathGrid=""};
            GetMod190Data = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod190DataCollectionEditor<Mod190View>,Mod190View>( params_GetMod190Data,this);
 

        }
        public IRPSTextBox<Mod190View> Year { get; set; } 
        public IRPSComboBox<Mod190View> OptionEjercicio { get; set; } 
        public IRPSButton<Mod190View> ExecuteGetMod190Data { get; set; } 
        public IRPSTextBox<Mod190View> NumJustificante { get; set; } 
        public IRPSComboBox<Mod190View> OptionTipoDeclaracion { get; set; } 
        public IRPSTextBox<Mod190View> NumJustificanteAnterior { get; set; } 
        public IRPSComboBox<Mod190View> OptionSoporte { get; set; } 
        public IRPSTextBox<Mod190View> ContactPerson { get; set; } 
        public IRPSTextBox<Mod190View> Phone { get; set; } 
        public IRPSTextBox<Mod190View> EmailContact { get; set; } 
        public IRPSButton<Mod190View> ExecuteGenerateMod190Button { get; set; } 
        public GetMod190DataCollectionEditor<Mod190View> GetMod190Data { get; set; } 
        public Mod190 Screen { get; set; }
        public Mod190View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod190DataCollectionEditor<Mod190View>:RPSCollectionEditor<Mod190View> where Mod190View : class, IView
    {
        public  GetMod190DataGridView<Mod190View> GridView {get;set;}
    }
    public partial class GetMod190DataGridView <Mod190View> :  RPSGridView<Mod190View> where Mod190View : class, IView
    {
        public GetMod190DataGridView(Mod190View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key = RPSControlFactory.CreateRPSGridTextBox<Mod190View>("","#1f2b37c7-6508-40f1-97a4-08fa2d750434 .ag-row[role='row']@ROWINDEX [col-id='cKey']","",false, this.CurrentView);
 
            SubKey = RPSControlFactory.CreateRPSGridTextBox<Mod190View>("","#1f2b37c7-6508-40f1-97a4-08fa2d750434 .ag-row[role='row']@ROWINDEX [col-id='cSubKey']","",false, this.CurrentView);
 
            SupplierVAT = RPSControlFactory.CreateRPSGridTextBox<Mod190View>("","#1f2b37c7-6508-40f1-97a4-08fa2d750434 .ag-row[role='row']@ROWINDEX [col-id='cSupplierVAT']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<Mod190View>("","#1f2b37c7-6508-40f1-97a4-08fa2d750434 .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            SupplierState = RPSControlFactory.CreateRPSGridTextBox<Mod190View>("","#1f2b37c7-6508-40f1-97a4-08fa2d750434 .ag-row[role='row']@ROWINDEX [col-id='cSupplierState']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod190View> Key { get; set; } 
        public IRPSGridTextBox<Mod190View> SubKey { get; set; } 
        public IRPSGridTextBox<Mod190View> SupplierVAT { get; set; } 
        public IRPSGridTextBox<Mod190View> SupplierName { get; set; } 
        public IRPSGridTextBox<Mod190View> SupplierState { get; set; } 
                     
    }
 
    }
  
    

}
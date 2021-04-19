    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.ModelVAT
{
    //RPS VERSION 1.0.0.0
    public partial class ModelVAT:Screen
    {
        public ModelVAT():base()
        {
            this.URL = "taxmodel.modelvat";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ModelVATView  = new ModelVATView(this); 
            ModelVATView.InitializeControls(); 
           
        }
      
            public ModelVATView ModelVATView {get; set; } 
    }
            
    public partial class ModelVATView : View
    {
        public ModelVATView(ModelVAT screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveCommandButton = RPSControlFactory.CreateRPSButton<ModelVATView>( "5a011d85-ff4d-4b11-8788-0db63c000e16","","",this);
 
            CollectionInit params_GetVATs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f0676b01-0a75-4136-8c62-d9594158db2e",CSSSelectorGrid="",XPathGrid=""};
            GetVATs = RPSControlFactory.RPSCreateCollectionWithGrid<GetVATsCollectionEditor<ModelVATView>,ModelVATView>( params_GetVATs,this);
 

        }
        public IRPSButton<ModelVATView> SaveCommandButton { get; set; } 
        public GetVATsCollectionEditor<ModelVATView> GetVATs { get; set; } 
        public ModelVAT Screen { get; set; }
        public ModelVATView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVATsCollectionEditor<ModelVATView>:RPSCollectionEditor<ModelVATView> where ModelVATView : class, IView
    {
        public  GetVATsGridView<ModelVATView> GridView {get;set;}
    }
    public partial class GetVATsGridView <ModelVATView> :  RPSGridView<ModelVATView> where ModelVATView : class, IView
    {
        public GetVATsGridView(ModelVATView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VAT_NoTaxableVAT = RPSControlFactory.CreateRPSGridCheckBox<ModelVATView>("","#f0676b01-0a75-4136-8c62-d9594158db2e .ag-row[role='row']@ROWINDEX [col-id='cVAT_NoTaxableVAT']","",false, this.CurrentView);
 
            VAT_ExcludeSII = RPSControlFactory.CreateRPSGridCheckBox<ModelVATView>("","#f0676b01-0a75-4136-8c62-d9594158db2e .ag-row[role='row']@ROWINDEX [col-id='cVAT_ExcludeSII']","",false, this.CurrentView);
 
            eGoodsServices = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVATView>("","#f0676b01-0a75-4136-8c62-d9594158db2e .ag-row[role='row']@ROWINDEX [col-id='ceGoodsServices']","",false, this.CurrentView);
 
            eVATTypeSII = RPSControlFactory.CreateRPSGridEnumComboBox<ModelVATView>("","#f0676b01-0a75-4136-8c62-d9594158db2e .ag-row[role='row']@ROWINDEX [col-id='ceVATTypeSII']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ModelVATView> VAT_NoTaxableVAT { get; set; } 
        public IRPSGridCheckbox<ModelVATView> VAT_ExcludeSII { get; set; } 
        public IRPSGridComboBox<ModelVATView> eGoodsServices { get; set; } 
        public IRPSGridComboBox<ModelVATView> eVATTypeSII { get; set; } 
                     
    }
 
    }
  
    

}
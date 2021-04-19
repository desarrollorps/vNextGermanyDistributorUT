    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CuDistDefaultQuotationOvercharges
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistDefaultQuotationOvercharges:Screen
    {
        public CuDistDefaultQuotationOvercharges():base()
        {
            this.URL = "sales.cudistdefaultquotationovercharges";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistDefaultQuotationOverchargesVMQueryView  = new CuDistDefaultQuotationOverchargesVMQueryView(this); 
            CuDistDefaultQuotationOverchargesVMEntityView  = new CuDistDefaultQuotationOverchargesVMEntityView(this); 
            CuDistDefaultQuotationOverchargesVMQueryView.InitializeControls(); 
            CuDistDefaultQuotationOverchargesVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistDefaultQuotationOverchargesVMQueryView CuDistDefaultQuotationOverchargesVMQueryView {get; set; } 
            public CuDistDefaultQuotationOverchargesVMEntityView CuDistDefaultQuotationOverchargesVMEntityView {get; set; } 
    }
            
    public partial class CuDistDefaultQuotationOverchargesVMQueryView : View
    {
        public CuDistDefaultQuotationOverchargesVMQueryView(CuDistDefaultQuotationOvercharges screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView>( this,Screen.CuDistDefaultQuotationOverchargesVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistDefaultQuotationOverchargesVMQueryView>( this);
 
            CollectionInit params_CuDistDefaultQuotationOverchargesConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="533ecb2e-d9d5-4e4b-bc49-35439af03ec1",CSSSelectorGrid="",XPathGrid=""};
            CuDistDefaultQuotationOverchargesConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistDefaultQuotationOverchargesConsultCollectionEditor<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView>,CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView>( params_CuDistDefaultQuotationOverchargesConsult,this,Screen.CuDistDefaultQuotationOverchargesVMEntityView);
 

        }
        public IRPSButton<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistDefaultQuotationOverchargesVMQueryView> ConsultButton { get; set; } 
        public CuDistDefaultQuotationOverchargesConsultCollectionEditor<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> CuDistDefaultQuotationOverchargesConsult { get; set; } 
        public CuDistDefaultQuotationOvercharges Screen { get; set; }
        public CuDistDefaultQuotationOverchargesVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistDefaultQuotationOverchargesConsultCollectionEditor<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView>:RPSCollectionEditor<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> where CuDistDefaultQuotationOverchargesVMQueryView : class, IView where CuDistDefaultQuotationOverchargesVMEntityView : class, IView
    {
        public  CuDistDefaultQuotationOverchargesConsultGridView<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> GridView {get;set;}
    }
    public partial class CuDistDefaultQuotationOverchargesConsultGridView <CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> :  RPSGridView<CuDistDefaultQuotationOverchargesVMQueryView,CuDistDefaultQuotationOverchargesVMEntityView> where CuDistDefaultQuotationOverchargesVMQueryView : class, IView where CuDistDefaultQuotationOverchargesVMEntityView : class, IView
    {
        public CuDistDefaultQuotationOverchargesConsultGridView(CuDistDefaultQuotationOverchargesVMQueryView currentView,CuDistDefaultQuotationOverchargesVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistDefaultQuotationOvercharges_Order = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Order']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Type = RPSControlFactory.CreateRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Type']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Apply = RPSControlFactory.CreateRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Apply']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Description = RPSControlFactory.CreateRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Description']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Value = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Value']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Cascade = RPSControlFactory.CreateRPSGridCheckBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Cascade']","",false, this.CurrentView);
 
            CuDistDefaultQuotationOvercharges_Proportional = RPSControlFactory.CreateRPSGridCheckBox<CuDistDefaultQuotationOverchargesVMQueryView>("","#533ecb2e-d9d5-4e4b-bc49-35439af03ec1 .ag-row[role='row']@ROWINDEX [col-id='cCuDistDefaultQuotationOvercharges_Proportional']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Order { get; set; } 
        public IRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Type { get; set; } 
        public IRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Apply { get; set; } 
        public IRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Description { get; set; } 
        public IRPSGridTextBox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Value { get; set; } 
        public IRPSGridCheckbox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Cascade { get; set; } 
        public IRPSGridCheckbox<CuDistDefaultQuotationOverchargesVMQueryView> CuDistDefaultQuotationOvercharges_Proportional { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistDefaultQuotationOverchargesVMEntityView : View
    {
        public CuDistDefaultQuotationOverchargesVMEntityView(CuDistDefaultQuotationOvercharges screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistDefaultQuotationOverchargesVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistDefaultQuotationOverchargesVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistDefaultQuotationOverchargesVMEntityView,CuDistDefaultQuotationOverchargesVMQueryView>( this,Screen.CuDistDefaultQuotationOverchargesVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistDefaultQuotationOverchargesVMEntityView,CuDistDefaultQuotationOverchargesVMQueryView>( this,Screen.CuDistDefaultQuotationOverchargesVMQueryView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CuDistDefaultQuotationOverchargesVMEntityView>("975051aa-bc90-4c47-af64-24dc60b262e9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistDefaultQuotationOverchargesVMEntityView>("2bfb4968-7a5f-4dda-85a5-9ed192762de6","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSEnumComboBox<CuDistDefaultQuotationOverchargesVMEntityView>("65d1759d-ccb3-43f7-a99a-fb2f1dcaa30c","","",true, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<CuDistDefaultQuotationOverchargesVMEntityView>("fcef591c-a9b2-42ce-a415-03e0546da7a3","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<CuDistDefaultQuotationOverchargesVMEntityView>("f62fe4fd-3996-43cd-8468-aae0b7d61e21","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<CuDistDefaultQuotationOverchargesVMEntityView>("eb463ebd-42af-46b5-bf78-1870dae71bf8","","",true, this);
 

        }
        public IRPSSaveButton<CuDistDefaultQuotationOverchargesVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistDefaultQuotationOverchargesVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistDefaultQuotationOverchargesVMEntityView,CuDistDefaultQuotationOverchargesVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistDefaultQuotationOverchargesVMEntityView,CuDistDefaultQuotationOverchargesVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CuDistDefaultQuotationOverchargesVMEntityView> Type { get; set; } 
        public IRPSTextBox<CuDistDefaultQuotationOverchargesVMEntityView> Description { get; set; } 
        public IRPSComboBox<CuDistDefaultQuotationOverchargesVMEntityView> Apply { get; set; } 
        public IRPSCheckbox<CuDistDefaultQuotationOverchargesVMEntityView> Cascade { get; set; } 
        public IRPSCheckbox<CuDistDefaultQuotationOverchargesVMEntityView> Proportional { get; set; } 
        public IRPSTextBox<CuDistDefaultQuotationOverchargesVMEntityView> Value { get; set; } 
        public CuDistDefaultQuotationOvercharges Screen { get; set; }
        public CuDistDefaultQuotationOverchargesVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
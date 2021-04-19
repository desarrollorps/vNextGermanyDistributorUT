    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CalculateCommissionByObjective
{
    //RPS VERSION 1.0.0.0
    public partial class CalculateCommissionByObjective:Screen
    {
        public CalculateCommissionByObjective():base()
        {
            this.URL = "sales.calculatecommissionbyobjective";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CalculateCommissionByObjectiveQueryView  = new CalculateCommissionByObjectiveQueryView(this); 
            CalculateCommissionByObjectiveQueryView.InitializeControls(); 
           
        }
      
            public CalculateCommissionByObjectiveQueryView CalculateCommissionByObjectiveQueryView {get; set; } 
    }
            
    public partial class CalculateCommissionByObjectiveQueryView : View
    {
        public CalculateCommissionByObjectiveQueryView(CalculateCommissionByObjective screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommercialAgentSL = RPSControlFactory.CreateRPSCollectionComboBox<CalculateCommissionByObjectiveQueryView>("658b94d0-d7ee-47f5-b683-0ee0b872e0a9","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CalculateCommissionByObjectiveQueryView>("a767468d-f9ce-4acd-bf35-de5e091e3674","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CalculateCommissionByObjectiveQueryView>("40f54fa6-d789-421d-98b6-1e6f71eaa14b","","",false, this);
 
            ePeriodicity = RPSControlFactory.CreateRPSEnumComboBox<CalculateCommissionByObjectiveQueryView>("92957f6d-a90f-4c40-8838-83a69b09b9ca","","",false, this);
 
            ExecuteUpdateCommissionsByObjectiveCommandButton = RPSControlFactory.CreateRPSButton<CalculateCommissionByObjectiveQueryView>( "1b74bbfc-11d6-44d6-bb52-1869b7433caf","","",this);
 
            CollectionInit params_CalculateCommissionsByObjectiveConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="34ba864c-7c2b-46bf-af85-3a4879a25195",CSSSelectorGrid="",XPathGrid=""};
            CalculateCommissionsByObjectiveConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CalculateCommissionsByObjectiveConsultCollectionEditor<CalculateCommissionByObjectiveQueryView>,CalculateCommissionByObjectiveQueryView>( params_CalculateCommissionsByObjectiveConsult,this);
 

        }
        public IRPSCollectionComboBox<CalculateCommissionByObjectiveQueryView> CommercialAgentSL { get; set; } 
        public IRPSTextBox<CalculateCommissionByObjectiveQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CalculateCommissionByObjectiveQueryView> DateTo { get; set; } 
        public IRPSComboBox<CalculateCommissionByObjectiveQueryView> ePeriodicity { get; set; } 
        public IRPSButton<CalculateCommissionByObjectiveQueryView> ExecuteUpdateCommissionsByObjectiveCommandButton { get; set; } 
        public CalculateCommissionsByObjectiveConsultCollectionEditor<CalculateCommissionByObjectiveQueryView> CalculateCommissionsByObjectiveConsult { get; set; } 
        public CalculateCommissionByObjective Screen { get; set; }
        public CalculateCommissionByObjectiveQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CalculateCommissionsByObjectiveConsultCollectionEditor<CalculateCommissionByObjectiveQueryView>:RPSCollectionEditor<CalculateCommissionByObjectiveQueryView> where CalculateCommissionByObjectiveQueryView : class, IView
    {
        public  CalculateCommissionsByObjectiveConsultGridView<CalculateCommissionByObjectiveQueryView> GridView {get;set;}
    }
    public partial class CalculateCommissionsByObjectiveConsultGridView <CalculateCommissionByObjectiveQueryView> :  RPSGridView<CalculateCommissionByObjectiveQueryView> where CalculateCommissionByObjectiveQueryView : class, IView
    {
        public CalculateCommissionsByObjectiveConsultGridView(CalculateCommissionByObjectiveQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            DescriptionObjective = RPSControlFactory.CreateRPSGridTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cDescriptionObjective']","",false, this.CurrentView);
 
            Calculated = RPSControlFactory.CreateRPSGridCheckBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cCalculated']","",false, this.CurrentView);
 
            AmountBase = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cAmountBase']","",false, this.CurrentView);
 
            CommissionPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cCommissionPercent']","",false, this.CurrentView);
 
            AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cAmountCommission']","",false, this.CurrentView);
 
            AmountCollection = RPSControlFactory.CreateRPSGridFormattedTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cAmountCollection']","",false, this.CurrentView);
 
            ObjectivePeriods = RPSControlFactory.CreateRPSGridTextBox<CalculateCommissionByObjectiveQueryView>("","#34ba864c-7c2b-46bf-af85-3a4879a25195 .ag-row[role='row']@ROWINDEX [col-id='cObjectivePeriods']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> Date { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> DescriptionObjective { get; set; } 
        public IRPSGridCheckbox<CalculateCommissionByObjectiveQueryView> Calculated { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> AmountBase { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> CommissionPercent { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> AmountCommission { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> AmountCollection { get; set; } 
        public IRPSGridTextBox<CalculateCommissionByObjectiveQueryView> ObjectivePeriods { get; set; } 
                     
    }
 
    }
  
    

}
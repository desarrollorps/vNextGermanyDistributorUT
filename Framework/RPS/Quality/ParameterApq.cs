    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ParameterApq
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterApq:Screen
    {
        public ParameterApq():base()
        {
            this.URL = "quality.parameterapq";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterApqEntityView  = new ParameterApqEntityView(this); 
            ParameterApqEntityView.InitializeControls(); 
           
        }
      
            public ParameterApqEntityView ParameterApqEntityView {get; set; } 
    }
            
    public partial class ParameterApqEntityView : View
    {
        public ParameterApqEntityView(ParameterApq screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCodSerieFMEANumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("e800b0c0-5d96-4263-8e0e-fee9e134f7ae","","",false, this);
 
            IDCodSerieFMEAProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("9bba4928-0194-43f4-b5b0-a659ad1e3e55","","",false, this);
 
            IDCodSerieControlPatternNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("d58dee82-9bc8-4932-840a-da725ab3919a","","",false, this);
 
            IDCodSerieCPatternProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("4cd4fc41-8c74-451a-bca7-dceb534ac859","","",false, this);
 
            IDCodSerieMachineParameterNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("8c48ea90-c90d-49ee-acc6-1ee2e2757246","","",false, this);
 
            IDCodSerieMPatternProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("c778ddfc-8023-44ef-b8f9-e5e14640f51c","","",false, this);
 
            IDCodSerieReceptionPatternNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("820d4e17-9a61-437d-a124-020a2c43de40","","",false, this);
 
            IDCodSerieFinalPatternNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("a8191eef-1a1e-44d9-a58a-6b0b8bc6154c","","",false, this);
 
            IDCodSerieControlSheetCPNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("da3c3162-5478-437a-ac89-de3d6d53f9e4","","",false, this);
 
            IDCodSerieCSheetProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("665c0f3f-d360-4e03-a163-a15afc8c3882","","",false, this);
 
            IDCodSerieControlSheetRPNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("c3bbb821-7b1b-4fb5-b60e-95be99b29144","","",false, this);
 
            IDCodSerieControlSheetFinalNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("2cec7e04-cd9a-47c5-875e-c57214ac9ccc","","",false, this);
 
            IDCodSerieControlPlanNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("0dfb2f8e-7a5e-4625-a0e8-810207755580","","",false, this);
 
            IDCodSerieControlPlanProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("c7591716-10a2-463f-9d31-175c5c245c38","","",false, this);
 
            IDCodSerieFeasibilityNumber = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("c837f5cf-c4aa-407d-abd1-5b9428ad797a","","",false, this);
 
            IDCodSerieAPPCC = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("43240c8a-803e-4164-9dd6-2b1f8e4a13bd","","",false, this);
 
            IDCodSerieAPPCCProject = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("9cb858f8-79f8-4972-bb35-4301c880b34c","","",false, this);
 
            IDCodSerieFoodAlert = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("4a268384-1eb8-49a6-b134-74047bb815a5","","",false, this);
 
            NCInitialStatus = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("be3de679-de30-4fa8-a8f9-d5a219d5ed23","","",true, this);
 
            IDCodSerieNCInternal = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("9d9a4e93-906c-41dd-8176-3caaec88cac7","","",false, this);
 
            IDCodSerieNCSupplier = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("74086fb8-e71c-44d6-949f-3179b2388ee6","","",false, this);
 
            IDCodSerieNCCustomer = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("ddfdbddc-b900-4d4a-84be-95ff8045472c","","",false, this);
 
            IDCodSerieNCOther = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("2a1abb12-a868-4f02-8afc-6b9af3471e71","","",false, this);
 
            ControlPatternOfProduction = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "07824c39-023e-449b-bd95-7d166f901c2d","","",this);
 
            ReceptionPattern = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "3c89d37f-a117-47a1-95cf-09ce9e3cbb56","","",this);
 
            AllReceptions = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "89c3fdef-0cdc-4878-b4e7-7bc0bc2216e3","","",this);
 
            OnlyReceptionsWithQualitycontrol = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "eb4dabf2-bcdd-4e85-8298-90e62c943156","","",this);
 
            EvaluationExcludeSamples = RPSControlFactory.CreateRPSCheckBox<ParameterApqEntityView>("2e81ac55-94af-471a-a026-caef4a3a85cf","","",true, this);
 
            WithControlOfUrsers = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "cd347513-06e4-45d7-adb7-40ad845644b3","","",this);
 
            WithoutControlOfUsers = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "fff92a28-e684-40cd-ab2e-e534cc43c582","","",this);
 
            WithControlOfUrsers1 = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "8beed86e-d310-4b9d-a595-5a1cf72e747e","","",this);
 
            WithoutControlOfUsers1 = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "abe71af0-5049-4dfd-bcb0-db0648b4225a","","",this);
 
            RpnMax = RPSControlFactory.CreateRPSFormattedTextBox<ParameterApqEntityView>("e28ff7e0-95fd-458d-aff6-cc1213eb9a2f","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ParameterApqEntityView>("2b1ba472-9be3-4749-87cc-b12bc67589c7","","",false, this);
 
            LockFinishedVersions = RPSControlFactory.CreateRPSCheckBox<ParameterApqEntityView>("4784c7b5-c177-4a1c-b1d3-d399070b5bad","","",true, this);
 
            APHighLevelColor = RPSControlFactory.CreateRPSColorEditor<ParameterApqEntityView>( "5d915e68-8fd2-4bc2-a124-e68eddd0829e","","",this);
 
            APMediumLevelColor = RPSControlFactory.CreateRPSColorEditor<ParameterApqEntityView>( "4a610a10-de5c-4af2-82d4-3f5e54784b93","","",this);
 
            APLowLevelColor = RPSControlFactory.CreateRPSColorEditor<ParameterApqEntityView>( "e4ecfcb3-5f9e-4a9f-88be-e7f8bdeb8a7e","","",this);
 
            OnRPN = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "ddf08a5c-16dc-4af0-a349-2c7913a8b4b5","","",this);
 
            OnAP = RPSControlFactory.CreateRPSOption<ParameterApqEntityView>( "4979937f-9f83-4dd4-bf3f-b691a8f5cfbc","","",this);
 

        }
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieFMEANumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieFMEAProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlPatternNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieCPatternProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieMachineParameterNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieMPatternProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieReceptionPatternNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieFinalPatternNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlSheetCPNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieCSheetProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlSheetRPNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlSheetFinalNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlPlanNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieControlPlanProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieFeasibilityNumber { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieAPPCC { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieAPPCCProject { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieFoodAlert { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> NCInitialStatus { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieNCInternal { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieNCSupplier { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieNCCustomer { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDCodSerieNCOther { get; set; } 
        public IRPSOption<ParameterApqEntityView> ControlPatternOfProduction { get; set; } 
        public IRPSOption<ParameterApqEntityView> ReceptionPattern { get; set; } 
        public IRPSOption<ParameterApqEntityView> AllReceptions { get; set; } 
        public IRPSOption<ParameterApqEntityView> OnlyReceptionsWithQualitycontrol { get; set; } 
        public IRPSCheckbox<ParameterApqEntityView> EvaluationExcludeSamples { get; set; } 
        public IRPSOption<ParameterApqEntityView> WithControlOfUrsers { get; set; } 
        public IRPSOption<ParameterApqEntityView> WithoutControlOfUsers { get; set; } 
        public IRPSOption<ParameterApqEntityView> WithControlOfUrsers1 { get; set; } 
        public IRPSOption<ParameterApqEntityView> WithoutControlOfUsers1 { get; set; } 
        public IRPSTextBox<ParameterApqEntityView> RpnMax { get; set; } 
        public IRPSComboBox<ParameterApqEntityView> IDHourType { get; set; } 
        public IRPSCheckbox<ParameterApqEntityView> LockFinishedVersions { get; set; } 
        public IRPSColorEditor<ParameterApqEntityView> APHighLevelColor { get; set; } 
        public IRPSColorEditor<ParameterApqEntityView> APMediumLevelColor { get; set; } 
        public IRPSColorEditor<ParameterApqEntityView> APLowLevelColor { get; set; } 
        public IRPSOption<ParameterApqEntityView> OnRPN { get; set; } 
        public IRPSOption<ParameterApqEntityView> OnAP { get; set; } 
        public ParameterApq Screen { get; set; }
        public ParameterApqEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
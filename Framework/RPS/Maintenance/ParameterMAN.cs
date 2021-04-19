    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ParameterMAN
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterMAN:Screen
    {
        public ParameterMAN():base()
        {
            this.URL = "maintenance.parameterman";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterMANEntityView  = new ParameterMANEntityView(this); 
            ParameterMANEntityView.InitializeControls(); 
           
        }
      
            public ParameterMANEntityView ParameterMANEntityView {get; set; } 
    }
            
    public partial class ParameterMANEntityView : View
    {
        public ParameterMANEntityView(ParameterMAN screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCodingSeriesManOrder = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("37f1e6df-1cb9-4b8a-a3b8-da310df8604c","","",false, this);
 
            IDCodingSeriesManContract = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("7a0f099c-bfef-40a3-8a56-04f10f3d62fc","","",false, this);
 
            IDCodingSeriesManWarning = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("34a341cd-fc1a-41ef-8566-1be952781672","","",false, this);
 
            IDCodingSeriesManPlan = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("22a01ef8-5039-4a37-9d6f-a2c518027dd7","","",false, this);
 
            IDCodingSeriesStartUp = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("b25eeb42-6ac0-48c7-a58d-aad87dafd902","","",false, this);
 
            IDCodingSeriesManPlanGeneric = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("2a18ed89-490a-424b-babe-d2615f94111a","","",false, this);
 
            IDCodingSeriesMultiImputation = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("4c399c4c-17c4-41ad-acf9-4e3d3c26aa45","","",false, this);
 
            IDMaintenanceWarningStatusInitial = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("19e0b7e1-55b1-4225-9cb5-0641f97538ae","","",true, this);
 
            IDMaintenanceWarningStatusFinal = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("0cbc03e1-296f-4cd5-a3b1-2558e855cdf1","","",false, this);
 
            IDMaintenanceWarningPriorityDefault = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("cef6be93-93d9-44bc-8908-ba060bd22b79","","",true, this);
 
            IDMaintenanceWarningSeveriryDefault = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("2e9a94b5-a933-4948-95ed-45fbf1d92fff","","",true, this);
 
            IDHourTypeDefault = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("329a3ab9-cb98-40b9-95f8-7a2e8d9b1eae","","",true, this);
 
            ImputationTime = RPSControlFactory.CreateRPSEnumComboBox<ParameterMANEntityView>("23872456-4a0f-4b8a-8258-6a62bfbfdc45","","",false, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ParameterMANEntityView>("dd829ba3-f8e7-4412-8e22-6c15b626d238","","",true, this);
 
            PercentCompleted = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("fa500485-f637-40b8-8285-fda96867c6c7","","",true, this);
 
            FromPriorityLow = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("2f9169d8-2be9-4bc1-8666-b2f126c8c614","","",false, this);
 
            ToPriorityLow = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("bfe89f25-5af9-477b-99eb-ca0ffdf66cca","","",true, this);
 
            FromPriorityMedium = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("abef711f-0154-4a69-a767-dea985d8df3f","","",false, this);
 
            ToPriorityMedium = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("f9ffb2eb-d9e1-4d01-9246-8758bcfd58d2","","",true, this);
 
            ToHighPriority = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("d1d42cbb-6917-4da4-b550-c6f951c25170","","",false, this);
 
            IDArticleInvoiceExpenses = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("65aa37a4-2079-426d-9708-008bb0d48cf1","","",false, this);
 
            IDArticleEmployeeExpenses = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("dee02067-8084-46cb-a7a7-e6960caf3f6d","","",false, this);
 
            KMPrice = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("4ccca084-60a8-4f8a-81d7-393279f612bf","","",true, this);
 
            IDArticleManContractSales = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("93514797-c2d5-4515-a5fa-f57f5e42ac5d","","",false, this);
 
            IDArticleManContractPurchase = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("4f768a38-dac6-4d80-a070-7009ef0cff91","","",false, this);
 
            IDCodingSeriesGuarantee = RPSControlFactory.CreateRPSComboBox<ParameterMANEntityView>("417cf774-6484-408d-aa87-b64fe8f61a7c","","",false, this);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("07e81f4e-1b65-419a-99df-fef9335fbeec","","",true, this);
 
            CostPricePercent = RPSControlFactory.CreateRPSFormattedTextBox<ParameterMANEntityView>("a1d9039d-a50c-41fc-97f4-d239909eb9df","","",false, this);
 
            SalesPercentPriceType = RPSControlFactory.CreateRPSEnumComboBox<ParameterMANEntityView>("43cf1854-c443-49b3-a8d8-fe238fcdd152","","",true, this);
 
            PlanningManual = RPSControlFactory.CreateRPSCheckBox<ParameterMANEntityView>("271779f0-b205-459b-ad5e-ced4f22921bb","","",true, this);
 
            ControlUser = RPSControlFactory.CreateRPSCheckBox<ParameterMANEntityView>("fda73c45-a191-4eee-9eeb-7f0c94ac6a78","","",true, this);
 

        }
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesManOrder { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesManContract { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesManWarning { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesManPlan { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesStartUp { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesManPlanGeneric { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesMultiImputation { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDMaintenanceWarningStatusInitial { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDMaintenanceWarningStatusFinal { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDMaintenanceWarningPriorityDefault { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDMaintenanceWarningSeveriryDefault { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDHourTypeDefault { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> ImputationTime { get; set; } 
        public IRPSCheckbox<ParameterMANEntityView> MakeMovement { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> PercentCompleted { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> FromPriorityLow { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> ToPriorityLow { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> FromPriorityMedium { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> ToPriorityMedium { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> ToHighPriority { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDArticleInvoiceExpenses { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDArticleEmployeeExpenses { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> KMPrice { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDArticleManContractSales { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDArticleManContractPurchase { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> IDCodingSeriesGuarantee { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> SalesGuaranteePeriod { get; set; } 
        public IRPSTextBox<ParameterMANEntityView> CostPricePercent { get; set; } 
        public IRPSComboBox<ParameterMANEntityView> SalesPercentPriceType { get; set; } 
        public IRPSCheckbox<ParameterMANEntityView> PlanningManual { get; set; } 
        public IRPSCheckbox<ParameterMANEntityView> ControlUser { get; set; } 
        public ParameterMAN Screen { get; set; }
        public ParameterMANEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
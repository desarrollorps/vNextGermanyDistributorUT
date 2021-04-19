    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.InspectionCard
{
    //RPS VERSION 1.0.0.0
    public partial class InspectionCard:Screen
    {
        public InspectionCard():base()
        {
            this.URL = "manufacturing.inspectioncard";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InspectionCardView  = new InspectionCardView(this); 
            InspectionCardView.InitializeControls(); 
           
        }
      
            public InspectionCardView InspectionCardView {get; set; } 
    }
            
    public partial class InspectionCardView : View
    {
        public InspectionCardView(InspectionCard screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<InspectionCardView>("dab2a792-e325-4434-909f-75e856e5d7f2","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<InspectionCardView>("97709cff-630c-4509-afc4-bcf75fb42d59","","",false, this);
 
            QualityOnly = RPSControlFactory.CreateRPSCheckBox<InspectionCardView>("68ec42d9-0b3b-4295-9848-3bbb15be0013","","",false, this);
 
            Inspected = RPSControlFactory.CreateRPSCheckBox<InspectionCardView>("984c6ab4-173e-4150-988c-84bdac1eb07d","","",false, this);
 
            Pending = RPSControlFactory.CreateRPSCheckBox<InspectionCardView>("0ac97b05-261e-4936-a0b3-ef4621f6fa91","","",false, this);
 
            ExecuteManufacturingOrderWithQualityControl = RPSControlFactory.CreateRPSButton<InspectionCardView>( "9183ceac-241a-4e9c-89ee-d0b615762fc6","","",this);
 
            InspectedDateTask = RPSControlFactory.CreateRPSTextBox<InspectionCardView>("2250f0eb-028b-443a-9ded-d40045389fed","","",false, this);
 
            QualityStatus = RPSControlFactory.CreateRPSFormattedTextBox<InspectionCardView>("6fd815be-2847-4e39-b9f3-2ab1fbdee386","","",false, this);
 
            IsQualityResource = RPSControlFactory.CreateRPSCheckBox<InspectionCardView>("a7664dc5-10da-4c7a-8460-2f58b79cf9f2","","",false, this);
 
            InspectedDate = RPSControlFactory.CreateRPSTextBox<InspectionCardView>("ad327989-868b-4bd6-bc4c-61b3a21d379a","","",false, this);
 
            QualityStatus1 = RPSControlFactory.CreateRPSFormattedTextBox<InspectionCardView>("1ff7d310-7a1e-4b40-aabb-dc452042763b","","",false, this);
 
            InspectedDateTask1 = RPSControlFactory.CreateRPSTextBox<InspectionCardView>("27299e97-472d-4b55-a640-780709486f33","","",false, this);
 
            InspectedDate1 = RPSControlFactory.CreateRPSTextBox<InspectionCardView>("51da2dba-ea52-4d18-bb7b-58165bcc797b","","",false, this);
 

        }
        public IRPSComboBox<InspectionCardView> Site { get; set; } 
        public IRPSCollectionComboBox<InspectionCardView> ManufacturingOrder { get; set; } 
        public IRPSCheckbox<InspectionCardView> QualityOnly { get; set; } 
        public IRPSCheckbox<InspectionCardView> Inspected { get; set; } 
        public IRPSCheckbox<InspectionCardView> Pending { get; set; } 
        public IRPSButton<InspectionCardView> ExecuteManufacturingOrderWithQualityControl { get; set; } 
        public IRPSTextBox<InspectionCardView> InspectedDateTask { get; set; } 
        public IRPSTextBox<InspectionCardView> QualityStatus { get; set; } 
        public IRPSCheckbox<InspectionCardView> IsQualityResource { get; set; } 
        public IRPSTextBox<InspectionCardView> InspectedDate { get; set; } 
        public IRPSTextBox<InspectionCardView> QualityStatus1 { get; set; } 
        public IRPSTextBox<InspectionCardView> InspectedDateTask1 { get; set; } 
        public IRPSTextBox<InspectionCardView> InspectedDate1 { get; set; } 
        public InspectionCard Screen { get; set; }
        public InspectionCardView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
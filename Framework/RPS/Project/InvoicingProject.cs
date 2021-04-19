    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.InvoicingProject
{
    //RPS VERSION 1.0.0.0
    public partial class InvoicingProject:Screen
    {
        public InvoicingProject():base()
        {
            this.URL = "project.invoicingproject";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoicingProjectView  = new InvoicingProjectView(this); 
            InvoicingProjectView.InitializeControls(); 
           
        }
      
            public InvoicingProjectView InvoicingProjectView {get; set; } 
    }
            
    public partial class InvoicingProjectView : View
    {
        public InvoicingProjectView(InvoicingProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<InvoicingProjectView>("a91fbb06-ebdd-4c56-baba-9f52c11e1049","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<InvoicingProjectView>("fdbb535f-4586-4a1e-bafa-3471057c4afd","","",false, this);
 
            Milestone = RPSControlFactory.CreateRPSCheckBox<InvoicingProjectView>("17cd3c17-0af3-40e4-a4bf-079a8206c8b3","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<InvoicingProjectView>("724170d0-47b2-45db-8650-8ce258276110","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<InvoicingProjectView>("93f39f4a-1089-42f9-8677-eded8c78b58d","","",true, this);
 
            Consumption = RPSControlFactory.CreateRPSCheckBox<InvoicingProjectView>("30b2466d-3d43-4aca-a1be-17cf195e0946","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<InvoicingProjectView>("c4af3a71-7875-420b-bd9d-1aee275fb45c","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<InvoicingProjectView>("fe4b5d77-5db1-45c1-ada1-4c25b26dda7c","","",false, this);
 
            Certification = RPSControlFactory.CreateRPSCheckBox<InvoicingProjectView>("b85bf310-1871-40ac-b513-c85edd60f828","","",false, this);
 
            ExecuteInvoicingProjectAction = RPSControlFactory.CreateRPSButton<InvoicingProjectView>( "6305b6c3-a616-49bd-9c1f-0c18a3fbf111","","",this);
 

        }
        public IRPSComboBox<InvoicingProjectView> Site { get; set; } 
        public IRPSCollectionComboBox<InvoicingProjectView> Customer { get; set; } 
        public IRPSCheckbox<InvoicingProjectView> Milestone { get; set; } 
        public IRPSTextBox<InvoicingProjectView> DateFrom { get; set; } 
        public IRPSTextBox<InvoicingProjectView> DateTo { get; set; } 
        public IRPSCheckbox<InvoicingProjectView> Consumption { get; set; } 
        public IRPSCollectionComboBox<InvoicingProjectView> Project { get; set; } 
        public IRPSCollectionComboBox<InvoicingProjectView> Situation { get; set; } 
        public IRPSCheckbox<InvoicingProjectView> Certification { get; set; } 
        public IRPSButton<InvoicingProjectView> ExecuteInvoicingProjectAction { get; set; } 
        public InvoicingProject Screen { get; set; }
        public InvoicingProjectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
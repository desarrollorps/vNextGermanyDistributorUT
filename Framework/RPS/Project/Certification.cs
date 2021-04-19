    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Certification
{
    //RPS VERSION 1.0.0.0
    public partial class Certification:Screen
    {
        public Certification():base()
        {
            this.URL = "project.certification";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CertificationVMQueryView  = new CertificationVMQueryView(this); 
            CertificationVMEntityView  = new CertificationVMEntityView(this); 
            CertificationDateView  = new CertificationDateView(this); 
            CertificationDateDetailView  = new CertificationDateDetailView(this); 
            CertificationVMQueryView.InitializeControls(); 
            CertificationVMEntityView.InitializeControls(); 
            CertificationDateView.InitializeControls(); 
            CertificationDateDetailView.InitializeControls(); 
           
        }
      
            public CertificationVMQueryView CertificationVMQueryView {get; set; } 
            public CertificationVMEntityView CertificationVMEntityView {get; set; } 
            public CertificationDateView CertificationDateView {get; set; } 
            public CertificationDateDetailView CertificationDateDetailView {get; set; } 
    }
            
    public partial class CertificationVMQueryView : View
    {
        public CertificationVMQueryView(Certification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CertificationVMQueryView,CertificationVMEntityView>( this,Screen.CertificationVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CertificationVMQueryView>( this);
 
            Project = RPSControlFactory.CreateRPSComboBox<CertificationVMQueryView>("51acd732-5522-4429-9b9c-bf87c7fffde2","","",false, this);
 
            CollectionInit params_CertificationProjectSelection = new CollectionInit(){IDDescriptor = "68b4e938-9d14-40bc-b0d5-b9d1164fafd3",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="19b38688-d7f4-43dc-b191-2e0d3e79198a",CSSSelectorGrid="",XPathGrid=""};
            CertificationProjectSelection = RPSControlFactory.RPSCreateCollectionWithGrid<CertificationProjectSelectionCollectionEditor<CertificationVMQueryView,CertificationVMEntityView>,CertificationVMQueryView,CertificationVMEntityView>( params_CertificationProjectSelection,this,Screen.CertificationVMEntityView);
 

        }
        public IRPSButton<CertificationVMQueryView,CertificationVMEntityView> NewButton { get; set; } 
        public IRPSButton<CertificationVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<CertificationVMQueryView> Project { get; set; } 
        public CertificationProjectSelectionCollectionEditor<CertificationVMQueryView,CertificationVMEntityView> CertificationProjectSelection { get; set; } 
        public Certification Screen { get; set; }
        public CertificationVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CertificationProjectSelectionCollectionEditor<CertificationVMQueryView,CertificationVMEntityView>:RPSCollectionEditor<CertificationVMQueryView,CertificationVMEntityView> where CertificationVMQueryView : class, IView where CertificationVMEntityView : class, IView
    {
        public  CertificationProjectSelectionGridView<CertificationVMQueryView,CertificationVMEntityView> GridView {get;set;}
    }
    public partial class CertificationProjectSelectionGridView <CertificationVMQueryView,CertificationVMEntityView> :  RPSGridView<CertificationVMQueryView,CertificationVMEntityView> where CertificationVMQueryView : class, IView where CertificationVMEntityView : class, IView
    {
        public CertificationProjectSelectionGridView(CertificationVMQueryView currentView,CertificationVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Certification_CodCertification = RPSControlFactory.CreateRPSGridTextBox<CertificationVMQueryView>("","#19b38688-d7f4-43dc-b191-2e0d3e79198a .ag-row[role='row']@ROWINDEX [col-id='cCertification_CodCertification']","",false, this.CurrentView);
 
            Certification_Description = RPSControlFactory.CreateRPSGridTextBox<CertificationVMQueryView>("","#19b38688-d7f4-43dc-b191-2e0d3e79198a .ag-row[role='row']@ROWINDEX [col-id='cCertification_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CertificationVMQueryView> Certification_CodCertification { get; set; } 
        public IRPSGridTextBox<CertificationVMQueryView> Certification_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CertificationVMEntityView : View
    {
        public CertificationVMEntityView(Certification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CertificationVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CertificationVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CertificationVMEntityView,CertificationVMQueryView>( this,Screen.CertificationVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CertificationVMEntityView,CertificationVMQueryView>( this,Screen.CertificationVMQueryView);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CertificationVMEntityView>("3c19e8f6-e6a3-4fa9-97d9-f3092c3bb0b0","","",true, this);
 
            CodCertification = RPSControlFactory.CreateRPSTextBox<CertificationVMEntityView>("99687be9-6b0e-44dc-a621-9d851be73f36","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CertificationVMEntityView>("92373cb0-7872-4263-a844-c2cb1a2cf350","","",false, this);
 
            CollectionInit params_CertificationDates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b775c621-2830-49ee-b71e-01616f2eb8ee",CSSSelectorGrid="",XPathGrid=""};
            CertificationDates = RPSControlFactory.RPSCreateCollectionWithGrid<CertificationDatesCollectionEditor<CertificationVMEntityView,CertificationDateView>,CertificationVMEntityView,CertificationDateView>( params_CertificationDates,this,Screen.CertificationDateView);
 

        }
        public IRPSSaveButton<CertificationVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CertificationVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CertificationVMEntityView,CertificationVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CertificationVMEntityView,CertificationVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CertificationVMEntityView> IDProject { get; set; } 
        public IRPSTextBox<CertificationVMEntityView> CodCertification { get; set; } 
        public IRPSTextBox<CertificationVMEntityView> Description { get; set; } 
        public CertificationDatesCollectionEditor<CertificationVMEntityView,CertificationDateView> CertificationDates { get; set; } 
        public Certification Screen { get; set; }
        public CertificationVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CertificationDatesCollectionEditor<CertificationVMEntityView,CertificationDateView>:RPSCollectionEditor<CertificationVMEntityView,CertificationDateView> where CertificationVMEntityView : class, IView where CertificationDateView : class, IView
    {
        public  CertificationDatesGridView<CertificationVMEntityView,CertificationDateView> GridView {get;set;}
    }
    public partial class CertificationDatesGridView <CertificationVMEntityView,CertificationDateView> :  RPSGridView<CertificationVMEntityView,CertificationDateView> where CertificationVMEntityView : class, IView where CertificationDateView : class, IView
    {
        public CertificationDatesGridView(CertificationVMEntityView currentView,CertificationDateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateCertification = RPSControlFactory.CreateRPSGridTextBox<CertificationVMEntityView>("","#b775c621-2830-49ee-b71e-01616f2eb8ee .ag-row[role='row']@ROWINDEX [col-id='cDateCertification']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CertificationVMEntityView>("","#b775c621-2830-49ee-b71e-01616f2eb8ee .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CertificationVMEntityView> DateCertification { get; set; } 
        public IRPSGridTextBox<CertificationVMEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CertificationDateView : View
    {
        public CertificationDateView(Certification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CertificationDateView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CertificationDateView,CertificationVMEntityView>( this,Screen.CertificationVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CertificationDateView,CertificationVMEntityView>( this,Screen.CertificationVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CertificationDateView,CertificationVMEntityView>( this,Screen.CertificationVMEntityView);
 
            DateCertification = RPSControlFactory.CreateRPSTextBox<CertificationDateView>("409150bc-265c-4780-85aa-3fb32dacdd71","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CertificationDateView>("42507808-89d9-41c9-afef-c8bfa99dc809","","",false, this);
 
            CollectionInit params_CertificationDateDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c727917a-9e04-4c5b-9cd6-b7fd80dd82bc",CSSSelectorGrid="",XPathGrid=""};
            CertificationDateDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CertificationDateDetailsCollectionEditor<CertificationDateView,CertificationDateDetailView>,CertificationDateView,CertificationDateDetailView>( params_CertificationDateDetails,this,Screen.CertificationDateDetailView);
 

        }
        public IRPSButton<CertificationDateView> DeleteButton { get; set; } 
        public IRPSButton<CertificationDateView,CertificationVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CertificationDateView,CertificationVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CertificationDateView,CertificationVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CertificationDateView> DateCertification { get; set; } 
        public IRPSTextBox<CertificationDateView> Description { get; set; } 
        public CertificationDateDetailsCollectionEditor<CertificationDateView,CertificationDateDetailView> CertificationDateDetails { get; set; } 
        public Certification Screen { get; set; }
        public CertificationDateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CertificationDateDetailsCollectionEditor<CertificationDateView,CertificationDateDetailView>:RPSCollectionEditor<CertificationDateView,CertificationDateDetailView> where CertificationDateView : class, IView where CertificationDateDetailView : class, IView
    {
        public  CertificationDateDetailsGridView<CertificationDateView,CertificationDateDetailView> GridView {get;set;}
    }
    public partial class CertificationDateDetailsGridView <CertificationDateView,CertificationDateDetailView> :  RPSGridView<CertificationDateView,CertificationDateDetailView> where CertificationDateView : class, IView where CertificationDateDetailView : class, IView
    {
        public CertificationDateDetailsGridView(CertificationDateView currentView,CertificationDateDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPROTypeResource = RPSControlFactory.CreateRPSGridEnumComboBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cIDPROTypeResource']","",true, this.CurrentView);
 
            IDPROTask = RPSControlFactory.CreateRPSGridComboBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cIDPROTask']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            TypeCertification = RPSControlFactory.CreateRPSGridEnumComboBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cTypeCertification']","",true, this.CurrentView);
 
            PriceSale = RPSControlFactory.CreateRPSGridFormattedTextBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cPriceSale']","",true, this.CurrentView);
 
            AmountSale = RPSControlFactory.CreateRPSGridFormattedTextBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cAmountSale']","",true, this.CurrentView);
 
            Billable = RPSControlFactory.CreateRPSGridCheckBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cBillable']","",true, this.CurrentView);
 
            Invoiced = RPSControlFactory.CreateRPSGridCheckBox<CertificationDateView>("","#c727917a-9e04-4c5b-9cd6-b7fd80dd82bc .ag-row[role='row']@ROWINDEX [col-id='cInvoiced']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CertificationDateView> IDPROTypeResource { get; set; } 
        public IRPSGridComboBox<CertificationDateView> IDPROTask { get; set; } 
        public IRPSGridComboBox<CertificationDateView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<CertificationDateView> Quantity { get; set; } 
        public IRPSGridComboBox<CertificationDateView> TypeCertification { get; set; } 
        public IRPSGridTextBox<CertificationDateView> PriceSale { get; set; } 
        public IRPSGridTextBox<CertificationDateView> AmountSale { get; set; } 
        public IRPSGridCheckbox<CertificationDateView> Billable { get; set; } 
        public IRPSGridCheckbox<CertificationDateView> Invoiced { get; set; } 
                     
    }
 
    }
  
            
    public partial class CertificationDateDetailView : View
    {
        public CertificationDateDetailView(Certification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CertificationDateDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CertificationDateDetailView,CertificationDateView>( this,Screen.CertificationDateView);
 
            BackButton = RPSControlFactory.RPSBackButton<CertificationDateDetailView,CertificationDateView>( this,Screen.CertificationDateView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CertificationDateDetailView,CertificationDateView>( this,Screen.CertificationDateView);
 
            IDPROTypeResource = RPSControlFactory.CreateRPSEnumComboBox<CertificationDateDetailView>("4ab70708-a7c0-4cd8-8757-ba964e33de51","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("bf80f220-fb47-4551-97cd-06495a720234","","",true, this);
 
            IDPROTask1 = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("ace2cce5-d091-40b8-a818-4ca57f846867","","",true, this);
 
            ProjectResourceEmployee = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("018ecd6f-8bee-440b-bdd8-915b6663a863","","",false, this);
 
            ProjectResourceMachine = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("e150208e-e45f-4b2a-8a20-43b7a23d1c00","","",false, this);
 
            ProjectResourceTool = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("ddbd1fc2-cb7d-456b-b163-d75f61750da8","","",false, this);
 
            ProjectMaterial = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("a36d5bcd-6b0c-4488-9664-28072c6cf9db","","",false, this);
 
            ProjectTaskCostComponent = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("24621bdf-d607-44b4-9d33-c12fe7344541","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<CertificationDateDetailView>("81c8d48d-d303-4ff6-ab5a-aa3526e37712","","",false, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<CertificationDateDetailView>("85adbf67-9322-43e3-b2a9-e2818193029b","","",true, this);
 
            Billable = RPSControlFactory.CreateRPSCheckBox<CertificationDateDetailView>("505f45ce-08e2-40eb-90d0-754a9b75f330","","",true, this);
 
            QuantityEstimated = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("72bb2d5b-ce96-4502-8246-ebb68fedc3e8","","",false, this);
 
            QuantityCertificated = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("8ad07072-5e71-48b4-87a9-7c98c446fdd4","","",false, this);
 
            QuantityImputated = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("703c19eb-0383-45b4-be7a-0c4d81ec618d","","",false, this);
 
            TypeCertification = RPSControlFactory.CreateRPSEnumComboBox<CertificationDateDetailView>("8bf32dcb-0a47-4fd4-b459-cf52f62642ba","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("0e68a553-2724-42ee-9639-af8650054388","","",true, this);
 
            PercentQuantity = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("8a53138f-b788-4490-bd5f-eecce88b378f","","",true, this);
 
            PriceSale = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("2cb75884-2d77-47c8-aa5e-9bdb6a9fdff7","","",true, this);
 
            AmountSale = RPSControlFactory.CreateRPSFormattedTextBox<CertificationDateDetailView>("8e7505bb-4a74-4a16-8ee0-e0bbf89564da","","",true, this);
 

        }
        public IRPSButton<CertificationDateDetailView> DeleteButton { get; set; } 
        public IRPSButton<CertificationDateDetailView,CertificationDateView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CertificationDateDetailView,CertificationDateView> BackButton { get; set; } 
        public IRPSAcceptButton<CertificationDateDetailView,CertificationDateView> AcceptButton { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> IDPROTypeResource { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> IDPROTask { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> IDPROTask1 { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectResourceEmployee { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectResourceMachine { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectResourceTool { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectMaterial { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectTaskCostComponent { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> ProjectTask { get; set; } 
        public IRPSCheckbox<CertificationDateDetailView> Invoiced { get; set; } 
        public IRPSCheckbox<CertificationDateDetailView> Billable { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> QuantityEstimated { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> QuantityCertificated { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> QuantityImputated { get; set; } 
        public IRPSComboBox<CertificationDateDetailView> TypeCertification { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> Quantity { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> PercentQuantity { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> PriceSale { get; set; } 
        public IRPSTextBox<CertificationDateDetailView> AmountSale { get; set; } 
        public Certification Screen { get; set; }
        public CertificationDateDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
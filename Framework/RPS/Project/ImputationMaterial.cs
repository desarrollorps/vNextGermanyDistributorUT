    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ImputationMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationMaterial:Screen
    {
        public ImputationMaterial():base()
        {
            this.URL = "project.imputationmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationMaterialVMQueryView  = new ImputationMaterialVMQueryView(this); 
            ImputationMaterialVMEntityView  = new ImputationMaterialVMEntityView(this); 
            ImputationMaterialVMQueryView.InitializeControls(); 
            ImputationMaterialVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationMaterialVMQueryView ImputationMaterialVMQueryView {get; set; } 
            public ImputationMaterialVMEntityView ImputationMaterialVMEntityView {get; set; } 
    }
            
    public partial class ImputationMaterialVMQueryView : View
    {
        public ImputationMaterialVMQueryView(ImputationMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>( this,Screen.ImputationMaterialVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationMaterialVMQueryView>( this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMQueryView>("cf0b8080-d1bd-4896-9c0e-614d105d7fb0","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialVMQueryView>("b316fbbc-0b98-4c63-938c-3bf614306a0e","","",false, this);
 
            UILstProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialVMQueryView>("5919126d-fc76-4cc8-a4fa-ec659efdf67c","","",false, this);
 
            UIWarning = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMQueryView>("a6225c42-c0ec-4c36-88b8-aa19bc84731c","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMQueryView>("e0851274-ced1-4a2a-836e-162cb91c1bcc","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMQueryView>("9b25c2c2-3075-4315-a2aa-b4a19eca01ee","","",false, this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<ImputationMaterialVMQueryView>("3e222277-2925-4f91-9c02-291820084f36","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMQueryView>("185a2033-2327-43a9-a571-7da22481fb33","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialVMQueryView>( "6e9694c7-b0b1-4362-8892-cc8d4c51e150","","",this);
 
            CollectionInit params_ImputationMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b9ff676a-0cfb-47c0-b81e-f9a96af7f155",CSSSelectorGrid="",XPathGrid=""};
            ImputationMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationMaterialCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>,ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>( params_ImputationMaterial,this,Screen.ImputationMaterialVMEntityView);
 

        }
        public IRPSButton<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationMaterialVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ImputationMaterialVMQueryView> UISite { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialVMQueryView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialVMQueryView> UILstProjectTask { get; set; } 
        public IRPSComboBox<ImputationMaterialVMQueryView> UIWarning { get; set; } 
        public IRPSTextBox<ImputationMaterialVMQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<ImputationMaterialVMQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<ImputationMaterialVMQueryView> UILstArticle { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMQueryView> UIGetIncludeChild { get; set; } 
        public IRPSButton<ImputationMaterialVMQueryView> DeleteCommandButton { get; set; } 
        public ImputationMaterialCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> ImputationMaterial { get; set; } 
        public ImputationMaterial Screen { get; set; }
        public ImputationMaterialVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationMaterialCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>:RPSCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> where ImputationMaterialVMQueryView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public  ImputationMaterialGridView<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> GridView {get;set;}
    }
    public partial class ImputationMaterialGridView <ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> :  RPSGridView<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> where ImputationMaterialVMQueryView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public ImputationMaterialGridView(ImputationMaterialVMQueryView currentView,ImputationMaterialVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterial_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialVMQueryView>("","#b9ff676a-0cfb-47c0-b81e-f9a96af7f155 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_ImputationDate']","",false, this.CurrentView);
 
            ImputationMaterial_CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMaterialVMQueryView>("","#b9ff676a-0cfb-47c0-b81e-f9a96af7f155 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_CostAmountReal']","",false, this.CurrentView);
 
            ImputationMaterial_Description = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialVMQueryView>("","#b9ff676a-0cfb-47c0-b81e-f9a96af7f155 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMaterialVMQueryView> ImputationMaterial_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationMaterialVMQueryView> ImputationMaterial_CostAmountReal { get; set; } 
        public IRPSGridTextBox<ImputationMaterialVMQueryView> ImputationMaterial_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMaterialVMEntityView : View
    {
        public ImputationMaterialVMEntityView(ImputationMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ImputationMaterialVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationMaterialVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView>( this,Screen.ImputationMaterialVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView>( this,Screen.ImputationMaterialVMQueryView);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("8e79c57d-a114-4b52-b718-1a407d0e8a5e","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("6b0f30e4-54da-49fa-9df8-215f6774a64e","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("25ac335d-e377-4ac1-a96a-fbfaa41619b8","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("2ac76b49-e49e-4f27-b71e-f43434c4a97f","","",true, this);
 
            IDPROMaterial = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("599e6625-98eb-4a6f-a799-399d207b83d7","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("08ef5632-22ba-49db-90d4-e19e2a3304c3","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("e461a154-050d-4828-bc32-818499ca87f6","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("d7cfa13e-15bf-4716-aff5-ce052dcf3815","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("969830b3-953b-4431-9d70-56bb74ffd281","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("53643b0b-d66e-4af7-aece-76f3f6098de1","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialVMEntityView>("84f43465-1bbc-4edb-b472-8391ab80a29c","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("c9e2cc4f-85c4-470c-b8ba-ec311b0875c3","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("3805dde5-f174-4a48-b7ba-02d45fe70111","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("2409d5ab-647b-4ff2-9e35-8ae4761f8e63","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("c77b68f4-cfa0-4645-b2f7-d2f795440c2d","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("31aa5693-477a-4f57-a0e8-f2053ef554e2","","",true, this);
 
            IDPROWarning = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("d107c02e-7633-4e6b-88dc-46a209c884c2","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("80ba66da-3bef-4c05-9796-97dc17272696","","",false, this);
 
            PurchaseDeliveryNote = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("f7552ad5-3597-437c-bf69-a3fe1898271e","","",false, this);
 
            Billable = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("12b9fa36-b18c-47db-9091-3002a9016d7f","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("7ca38731-a493-4943-a565-d57a3b05ded3","","",false, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("ddeb5567-fd75-404b-99d2-e41f6c1ea100","","",true, this);
 
            WarehouseMovementNavigationCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialVMEntityView>( "6db74134-55f7-42b7-8662-73332f0751ad","","",this);
 

        }
        public IRPSSaveButton<ImputationMaterialVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDPROTask { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> MakeMovement { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDPROMaterial { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> Series { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> ExpiryDate { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> Description { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostAmountReal { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDPROWarning { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> PurchaseDeliveryNote { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> Billable { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> Invoiced { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> IsPosting { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView> WarehouseMovementNavigationCommandButton { get; set; } 
        public ImputationMaterial Screen { get; set; }
        public ImputationMaterialVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
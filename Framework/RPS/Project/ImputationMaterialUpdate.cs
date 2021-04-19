    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ImputationMaterialUpdate
{
    //RPS VERSION 1.0.0.0
    public partial class ImputationMaterialUpdate:Screen
    {
        public ImputationMaterialUpdate():base()
        {
            this.URL = "project.imputationmaterialupdate";
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
        public ImputationMaterialVMQueryView(ImputationMaterialUpdate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>( this,Screen.ImputationMaterialVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ImputationMaterialVMQueryView>( this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialVMQueryView>( "a58deb48-2155-4179-b640-c6613269526b","","",this);
 
            CollectionInit params_ImputationMaterialUpdate = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49257d12-cacb-473e-b5e8-28faaa9198e0",CSSSelectorGrid="",XPathGrid=""};
            ImputationMaterialUpdate = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationMaterialUpdateCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>,ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>( params_ImputationMaterialUpdate,this,Screen.ImputationMaterialVMEntityView);
 

        }
        public IRPSButton<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> NewButton { get; set; } 
        public IRPSButton<ImputationMaterialVMQueryView> ConsultButton { get; set; } 
        public IRPSButton<ImputationMaterialVMQueryView> AcceptCommandButton { get; set; } 
        public ImputationMaterialUpdateCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> ImputationMaterialUpdate { get; set; } 
        public ImputationMaterialUpdate Screen { get; set; }
        public ImputationMaterialVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImputationMaterialUpdateCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView>:RPSCollectionEditor<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> where ImputationMaterialVMQueryView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public  ImputationMaterialUpdateGridView<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> GridView {get;set;}
    }
    public partial class ImputationMaterialUpdateGridView <ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> :  RPSGridView<ImputationMaterialVMQueryView,ImputationMaterialVMEntityView> where ImputationMaterialVMQueryView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public ImputationMaterialUpdateGridView(ImputationMaterialVMQueryView currentView,ImputationMaterialVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterial_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialVMQueryView>("","#49257d12-cacb-473e-b5e8-28faaa9198e0 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_ImputationDate']","",false, this.CurrentView);
 
            ImputationMaterial_Series = RPSControlFactory.CreateRPSGridTextBox<ImputationMaterialVMQueryView>("","#49257d12-cacb-473e-b5e8-28faaa9198e0 .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ImputationMaterialVMQueryView> ImputationMaterial_ImputationDate { get; set; } 
        public IRPSGridTextBox<ImputationMaterialVMQueryView> ImputationMaterial_Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMaterialVMEntityView : View
    {
        public ImputationMaterialVMEntityView(ImputationMaterialUpdate screen) : base()
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
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("64d4984d-301f-4d84-9b74-5596ff116e00","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("4d860d72-51c7-48a8-816c-3b36ec3b73cd","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("57373572-4ff5-4723-a82d-9247027b66b9","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("9467fe28-7bed-47b0-a935-3ca0d6d620f7","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("e116b95c-0252-4a80-91d2-3eb82dbc917d","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("720cd5be-dff1-4a06-9bf5-1afafcd7a778","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("166b6812-02fd-44ee-a75d-fb38450c0c10","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialVMEntityView>("7f70bbe2-37f1-4cfd-9493-f84eccf59553","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("2b45b688-9f31-4e46-9e71-77e25bdb87e8","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("8006c690-1f61-4d04-8807-438c265528c3","","",true, this);
 
            IDPROMaterial = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("26e296db-6d49-442a-a611-1e5ab65e282c","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("77f05502-559c-4144-9136-330a83e2bdfb","","",true, this);
 

        }
        public IRPSSaveButton<ImputationMaterialVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostAmountReal { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> MakeMovement { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> Series { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDPROMaterial { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> ImputationDate { get; set; } 
        public ImputationMaterialUpdate Screen { get; set; }
        public ImputationMaterialVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
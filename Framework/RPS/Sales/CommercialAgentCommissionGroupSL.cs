    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommercialAgentCommissionGroupSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommercialAgentCommissionGroupSL:Screen
    {
        public CommercialAgentCommissionGroupSL():base()
        {
            this.URL = "sales.commercialagentcommissiongroupsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommercialAgentCommissionGroupSLCollectionView  = new CommercialAgentCommissionGroupSLCollectionView(this); 
            CommercialAgentCommissionGroupSLEntityView  = new CommercialAgentCommissionGroupSLEntityView(this); 
            CommercialAgentCommissionGroupSLCollectionView.InitializeControls(); 
            CommercialAgentCommissionGroupSLEntityView.InitializeControls(); 
           
        }
      
            public CommercialAgentCommissionGroupSLCollectionView CommercialAgentCommissionGroupSLCollectionView {get; set; } 
            public CommercialAgentCommissionGroupSLEntityView CommercialAgentCommissionGroupSLEntityView {get; set; } 
    }
            
    public partial class CommercialAgentCommissionGroupSLCollectionView : View
    {
        public CommercialAgentCommissionGroupSLCollectionView(CommercialAgentCommissionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommercialAgentCommissionGroupSLCollectionView,CommercialAgentCommissionGroupSLEntityView>( this,Screen.CommercialAgentCommissionGroupSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "043c6a09-c8db-4617-8797-8760f920eb56",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CommercialAgentCommissionGroupSLCollectionView,CommercialAgentCommissionGroupSLEntityView>( params_MainConsult,this,Screen.CommercialAgentCommissionGroupSLEntityView);
 

        }
        public IRPSButton<CommercialAgentCommissionGroupSLCollectionView,CommercialAgentCommissionGroupSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CommercialAgentCommissionGroupSLCollectionView,CommercialAgentCommissionGroupSLEntityView> MainConsult { get; set; } 
        public CommercialAgentCommissionGroupSL Screen { get; set; }
        public CommercialAgentCommissionGroupSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CommercialAgentCommissionGroupSLEntityView : View
    {
        public CommercialAgentCommissionGroupSLEntityView(CommercialAgentCommissionGroupSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommercialAgentCommissionGroupSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommercialAgentCommissionGroupSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommercialAgentCommissionGroupSLEntityView,CommercialAgentCommissionGroupSLCollectionView>( this,Screen.CommercialAgentCommissionGroupSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommercialAgentCommissionGroupSLEntityView,CommercialAgentCommissionGroupSLCollectionView>( this,Screen.CommercialAgentCommissionGroupSLCollectionView);
 
            CodCommercialAgentCommissionGroup = RPSControlFactory.CreateRPSTextBox<CommercialAgentCommissionGroupSLEntityView>("f76ee44b-3b81-43be-a524-d2148e51580a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CommercialAgentCommissionGroupSLEntityView>("e3c0c330-c81f-4735-b2fa-2da7d2c934d8","","",false, this);
 

        }
        public IRPSSaveButton<CommercialAgentCommissionGroupSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CommercialAgentCommissionGroupSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommercialAgentCommissionGroupSLEntityView,CommercialAgentCommissionGroupSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommercialAgentCommissionGroupSLEntityView,CommercialAgentCommissionGroupSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CommercialAgentCommissionGroupSLEntityView> CodCommercialAgentCommissionGroup { get; set; } 
        public IRPSTextBox<CommercialAgentCommissionGroupSLEntityView> Description { get; set; } 
        public CommercialAgentCommissionGroupSL Screen { get; set; }
        public CommercialAgentCommissionGroupSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
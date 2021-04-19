    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionDefinitionByTotalSL
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionDefinitionByTotalSL:Screen
    {
        public CommissionDefinitionByTotalSL():base()
        {
            this.URL = "sales.commissiondefinitionbytotalsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionDefinitionByTotalSLVMQueryView  = new CommissionDefinitionByTotalSLVMQueryView(this); 
            CommissionDefinitionByTotalSLVMEntityView  = new CommissionDefinitionByTotalSLVMEntityView(this); 
            CommissionDefinitionByTotalDetailSLView  = new CommissionDefinitionByTotalDetailSLView(this); 
            CommissionDefinitionByTotalSLVMQueryView.InitializeControls(); 
            CommissionDefinitionByTotalSLVMEntityView.InitializeControls(); 
            CommissionDefinitionByTotalDetailSLView.InitializeControls(); 
           
        }
      
            public CommissionDefinitionByTotalSLVMQueryView CommissionDefinitionByTotalSLVMQueryView {get; set; } 
            public CommissionDefinitionByTotalSLVMEntityView CommissionDefinitionByTotalSLVMEntityView {get; set; } 
            public CommissionDefinitionByTotalDetailSLView CommissionDefinitionByTotalDetailSLView {get; set; } 
    }
            
    public partial class CommissionDefinitionByTotalSLVMQueryView : View
    {
        public CommissionDefinitionByTotalSLVMQueryView(CommissionDefinitionByTotalSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView>( this,Screen.CommissionDefinitionByTotalSLVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CommissionDefinitionByTotalSLVMQueryView>( this);
 
            Agent = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "21bd9bdc-9228-46a0-8753-43bec55e5ed7","","",this);
 
            CommercialAgentSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMQueryView>("63a9fc50-eb0d-4ffb-8868-ca7b97c4afd6","","",false, this);
 
            AgentGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "b1bce4fc-dc3c-40c4-abe0-85bc125083c6","","",this);
 
            CommercialAgentCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMQueryView>("8e2f9afb-cf98-40ad-860d-5b950ad8e146","","",false, this);
 
            GenericAgent = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "9b523e84-b675-4991-bdb5-198cd0f976a0","","",this);
 
            Customer = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "1eae7fc5-0f63-4126-ad27-3d216adc16c2","","",this);
 
            Customer1 = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMQueryView>("6bc9bf72-e6f9-41fb-910b-0fbc8da0a3d1","","",false, this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "6a42edb3-a813-47fa-87e3-7611ec319ac0","","",this);
 
            CustomerCommissionGroupSL = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMQueryView>("001c6aae-8b72-4970-929f-3fdc1adde0d5","","",false, this);
 
            GenericCustomer = RPSControlFactory.CreateRPSOption<CommissionDefinitionByTotalSLVMQueryView>( "15c0002b-3806-4d99-928d-5fe44a9c5d45","","",this);
 
            bProductLine = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByTotalSLVMQueryView>("39b77d82-01f6-436a-9b6b-35d8fa872852","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView>("98dd65f0-1fa9-476f-a48a-f8ebee189837","","",false, this);
 
            bProductFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByTotalSLVMQueryView>("ed2e627a-6671-4f96-8bad-e4427c8cd3bf","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView>("d71fb563-5bd5-4e9a-a6c1-c365cf8729d9","","",false, this);
 
            bProductSubFamily = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByTotalSLVMQueryView>("70613e3e-8339-42ef-afcd-091c95382233","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView>("e86d0c9b-5b58-43b1-bd01-42a7b3aba0e5","","",false, this);
 
            bArticle = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByTotalSLVMQueryView>("6a10f23b-488f-4ed0-82ac-5e42d76ba12c","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView>("7e650095-99e1-4f1e-b767-7231d2c5f3ad","","",false, this);
 
            bAllArticles = RPSControlFactory.CreateRPSCheckBox<CommissionDefinitionByTotalSLVMQueryView>("672786e9-617e-42bd-9f4f-2d12b8525734","","",false, this);
 
            CollectionInit params_CommissionDefinitionByTotalSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fcb62b0c-2766-442b-9610-c56bcb0b6a45",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionByTotalSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionByTotalSLConsultCollectionEditor<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView>,CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView>( params_CommissionDefinitionByTotalSLConsult,this,Screen.CommissionDefinitionByTotalSLVMEntityView);
 

        }
        public IRPSButton<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> NewButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalSLVMQueryView> ConsultButton { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> Agent { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMQueryView> CommercialAgentSL { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> AgentGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMQueryView> CommercialAgentCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> GenericAgent { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> Customer { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMQueryView> Customer1 { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> CustomerGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMQueryView> CustomerCommissionGroupSL { get; set; } 
        public IRPSOption<CommissionDefinitionByTotalSLVMQueryView> GenericCustomer { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByTotalSLVMQueryView> bProductLine { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView> ProductLine { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByTotalSLVMQueryView> bProductFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView> ProductFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByTotalSLVMQueryView> bProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByTotalSLVMQueryView> bArticle { get; set; } 
        public IRPSCollectionComboBox<CommissionDefinitionByTotalSLVMQueryView> Article { get; set; } 
        public IRPSCheckbox<CommissionDefinitionByTotalSLVMQueryView> bAllArticles { get; set; } 
        public CommissionDefinitionByTotalSLConsultCollectionEditor<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> CommissionDefinitionByTotalSLConsult { get; set; } 
        public CommissionDefinitionByTotalSL Screen { get; set; }
        public CommissionDefinitionByTotalSLVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionDefinitionByTotalSLConsultCollectionEditor<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView>:RPSCollectionEditor<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> where CommissionDefinitionByTotalSLVMQueryView : class, IView where CommissionDefinitionByTotalSLVMEntityView : class, IView
    {
        public  CommissionDefinitionByTotalSLConsultGridView<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> GridView {get;set;}
    }
    public partial class CommissionDefinitionByTotalSLConsultGridView <CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> :  RPSGridView<CommissionDefinitionByTotalSLVMQueryView,CommissionDefinitionByTotalSLVMEntityView> where CommissionDefinitionByTotalSLVMQueryView : class, IView where CommissionDefinitionByTotalSLVMEntityView : class, IView
    {
        public CommissionDefinitionByTotalSLConsultGridView(CommissionDefinitionByTotalSLVMQueryView currentView,CommissionDefinitionByTotalSLVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommissionDefinitionByTotalSL_ItemType = RPSControlFactory.CreateRPSGridTextBox<CommissionDefinitionByTotalSLVMQueryView>("","#fcb62b0c-2766-442b-9610-c56bcb0b6a45 .ag-row[role='row']@ROWINDEX [col-id='cCommissionDefinitionByTotalSL_ItemType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionByTotalSLVMQueryView> CommissionDefinitionByTotalSL_ItemType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionDefinitionByTotalSLVMEntityView : View
    {
        public CommissionDefinitionByTotalSLVMEntityView(CommissionDefinitionByTotalSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CommissionDefinitionByTotalSLVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionByTotalSLVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalSLVMQueryView>( this,Screen.CommissionDefinitionByTotalSLVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalSLVMQueryView>( this,Screen.CommissionDefinitionByTotalSLVMQueryView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("727252c0-5fd3-454f-94da-2f58f46c8600","","",false, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("897f45fb-0b90-47f0-81c6-f154b0f280ce","","",false, this);
 
            IDCommercialAgentCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("955660bd-6e6b-4f8e-8f4f-6d6f8eb05a40","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("9391e125-9589-4210-80da-823755c5d98d","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("c406702b-83f1-45ac-ac3c-cd63ba091cd1","","",false, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByTotalSLVMEntityView>("9e9d207f-d3ba-4c41-8c69-0fac56523486","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("e51305f9-ed19-46ab-9ecb-2e1984d15c54","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("17efe7c4-893d-4688-b537-a680d6d92baa","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("8613b660-2125-4939-b116-fbcd05298c6f","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CommissionDefinitionByTotalSLVMEntityView>("b338f36d-5180-4d6f-8f05-75a5baa52c0b","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<CommissionDefinitionByTotalSLVMEntityView>("d46540ab-f784-4f55-901a-554004f9aafa","","",true, this);
 
            CollectionInit params_CommissionDefinitionByTotalDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="958542ea-c0e3-4e5b-ae4f-d645dcaaf212",CSSSelectorGrid="",XPathGrid=""};
            CommissionDefinitionByTotalDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CommissionDefinitionByTotalDetailSLsCollectionEditor<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView>,CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView>( params_CommissionDefinitionByTotalDetailSLs,this,Screen.CommissionDefinitionByTotalDetailSLView);
 

        }
        public IRPSSaveButton<CommissionDefinitionByTotalSLVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalSLVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalSLVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalSLVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDCommercialAgentCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CommissionDefinitionByTotalSLVMEntityView> Type { get; set; } 
        public CommissionDefinitionByTotalDetailSLsCollectionEditor<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView> CommissionDefinitionByTotalDetailSLs { get; set; } 
        public CommissionDefinitionByTotalSL Screen { get; set; }
        public CommissionDefinitionByTotalSLVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CommissionDefinitionByTotalDetailSLsCollectionEditor<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView>:RPSCollectionEditor<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView> where CommissionDefinitionByTotalSLVMEntityView : class, IView where CommissionDefinitionByTotalDetailSLView : class, IView
    {
        public  CommissionDefinitionByTotalDetailSLsGridView<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView> GridView {get;set;}
    }
    public partial class CommissionDefinitionByTotalDetailSLsGridView <CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView> :  RPSGridView<CommissionDefinitionByTotalSLVMEntityView,CommissionDefinitionByTotalDetailSLView> where CommissionDefinitionByTotalSLVMEntityView : class, IView where CommissionDefinitionByTotalDetailSLView : class, IView
    {
        public CommissionDefinitionByTotalDetailSLsGridView(CommissionDefinitionByTotalSLVMEntityView currentView,CommissionDefinitionByTotalDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            From = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByTotalSLVMEntityView>("","#958542ea-c0e3-4e5b-ae4f-d645dcaaf212 .ag-row[role='row']@ROWINDEX [col-id='cFrom']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByTotalSLVMEntityView>("","#958542ea-c0e3-4e5b-ae4f-d645dcaaf212 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionDefinitionByTotalSLVMEntityView>("","#958542ea-c0e3-4e5b-ae4f-d645dcaaf212 .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionDefinitionByTotalSLVMEntityView> From { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByTotalSLVMEntityView> Commission { get; set; } 
        public IRPSGridTextBox<CommissionDefinitionByTotalSLVMEntityView> CommissionAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class CommissionDefinitionByTotalDetailSLView : View
    {
        public CommissionDefinitionByTotalDetailSLView(CommissionDefinitionByTotalSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CommissionDefinitionByTotalDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView>( this,Screen.CommissionDefinitionByTotalSLVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView>( this,Screen.CommissionDefinitionByTotalSLVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView>( this,Screen.CommissionDefinitionByTotalSLVMEntityView);
 
            From = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByTotalDetailSLView>("d240a73e-2490-4e45-affd-abc0be124839","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByTotalDetailSLView>("9a23c690-737e-4d08-be82-6767ac869393","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<CommissionDefinitionByTotalDetailSLView>("b0cdf685-5a9b-4927-9117-2067b0d9235e","","",true, this);
 

        }
        public IRPSButton<CommissionDefinitionByTotalDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CommissionDefinitionByTotalDetailSLView,CommissionDefinitionByTotalSLVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CommissionDefinitionByTotalDetailSLView> From { get; set; } 
        public IRPSTextBox<CommissionDefinitionByTotalDetailSLView> Commission { get; set; } 
        public IRPSTextBox<CommissionDefinitionByTotalDetailSLView> CommissionAmount { get; set; } 
        public CommissionDefinitionByTotalSL Screen { get; set; }
        public CommissionDefinitionByTotalDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
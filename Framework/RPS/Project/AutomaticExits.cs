    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.AutomaticExits
{
    //RPS VERSION 1.0.0.0
    public partial class AutomaticExits:Screen
    {
        public AutomaticExits():base()
        {
            this.URL = "project.automaticexits";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ImputationMaterialVMCollectionView  = new ImputationMaterialVMCollectionView(this); 
            ImputationMaterialVMEntityView  = new ImputationMaterialVMEntityView(this); 
            ImputationMaterialVMCollectionView.InitializeControls(); 
            ImputationMaterialVMEntityView.InitializeControls(); 
           
        }
      
            public ImputationMaterialVMCollectionView ImputationMaterialVMCollectionView {get; set; } 
            public ImputationMaterialVMEntityView ImputationMaterialVMEntityView {get; set; } 
    }
            
    public partial class ImputationMaterialVMCollectionView : View
    {
        public ImputationMaterialVMCollectionView(AutomaticExits screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMCollectionView>("1abcccd8-bb1e-4160-ad69-a12b3288372a","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMCollectionView>("cd299c7a-4f2f-4655-8266-b5351c39b9c4","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMCollectionView>("88da1864-0711-4b32-8467-6b400f150d21","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMCollectionView>("43f7fd27-b2b3-49a4-bcb0-87e9c619a68e","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ImputationMaterialVMCollectionView>( "12f80775-af84-4e3c-a7a7-b8ade5ba180d","","",this);
 
            Pending = RPSControlFactory.CreateRPSOption<ImputationMaterialVMCollectionView>( "687fdce9-2dc2-4bd5-b91a-fad7e421def4","","",this);
 
            AssignSeriesCommandButton = RPSControlFactory.CreateRPSButton<ImputationMaterialVMCollectionView>( "be1681ac-0086-4738-9943-e7527f44862f","","",this);
 
            CollectionInit params_AutomaticExits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a6854d41-ddd4-44ac-bd00-991a7d7477df",CSSSelectorGrid="",XPathGrid=""};
            AutomaticExits = RPSControlFactory.RPSCreateCollectionWithGrid<AutomaticExitsCollectionEditor<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView>,ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView>( params_AutomaticExits,this,Screen.ImputationMaterialVMEntityView);
 

        }
        public IRPSComboBox<ImputationMaterialVMCollectionView> Project { get; set; } 
        public IRPSComboBox<ImputationMaterialVMCollectionView> ProjectTask { get; set; } 
        public IRPSComboBox<ImputationMaterialVMCollectionView> UIArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialVMCollectionView> Date { get; set; } 
        public IRPSOption<ImputationMaterialVMCollectionView> All { get; set; } 
        public IRPSOption<ImputationMaterialVMCollectionView> Pending { get; set; } 
        public IRPSButton<ImputationMaterialVMCollectionView> AssignSeriesCommandButton { get; set; } 
        public AutomaticExitsCollectionEditor<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView> AutomaticExits { get; set; } 
        public AutomaticExits Screen { get; set; }
        public ImputationMaterialVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AutomaticExitsCollectionEditor<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView>:RPSCollectionEditor<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView> where ImputationMaterialVMCollectionView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public  AutomaticExitsGridView<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView> GridView {get;set;}
    }
    public partial class AutomaticExitsGridView <ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView> :  RPSGridView<ImputationMaterialVMCollectionView,ImputationMaterialVMEntityView> where ImputationMaterialVMCollectionView : class, IView where ImputationMaterialVMEntityView : class, IView
    {
        public AutomaticExitsGridView(ImputationMaterialVMCollectionView currentView,ImputationMaterialVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPROTask = RPSControlFactory.CreateRPSGridComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cIDPROTask']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<ImputationMaterialVMCollectionView>("","#a6854d41-ddd4-44ac-bd00-991a7d7477df .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> IDPROTask { get; set; } 
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> IDArticle { get; set; } 
        public IRPSGridTextBox<ImputationMaterialVMCollectionView> Quantity { get; set; } 
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> IDSite { get; set; } 
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> Series { get; set; } 
        public IRPSGridComboBox<ImputationMaterialVMCollectionView> IDLocationWarehouse { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImputationMaterialVMEntityView : View
    {
        public ImputationMaterialVMEntityView(AutomaticExits screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ImputationMaterialVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView>( this,Screen.ImputationMaterialVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView>( this,Screen.ImputationMaterialVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView>( this,Screen.ImputationMaterialVMCollectionView);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("4c4f4f4c-e578-43d2-a400-5b9661249e4d","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("6aeb5c08-2f34-443f-a967-2c881427789e","","",true, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("c6f3c7b8-f02b-4ee6-aa1c-5edb6e99ca75","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ImputationMaterialVMEntityView>("03aa36f5-970e-4f6e-b05f-fc9062de0541","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("b39e631d-3938-4944-86fe-fe300069cf65","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("a4da4396-fa8c-4436-a144-6eedd763ec6c","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("a119b67b-6ede-47e3-b888-d7344b6b61a9","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("f91f6437-513b-4d94-a30c-2a0b8f2fb39a","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMaterialVMEntityView>("8c685be4-d6c1-4070-8ad9-920602d77dfd","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("c1c60851-b1fb-4a2a-ae85-02e86dcca10b","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("7e70ade7-e6d0-4c03-961b-77a3ee9987d5","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ImputationMaterialVMEntityView>("3a8fe4a5-71ae-425b-aa15-b509aa06afeb","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ImputationMaterialVMEntityView>("a9672792-fd46-4261-b14a-cfb504942804","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ImputationMaterialVMEntityView>("afce4af1-b4ac-4896-84a1-b57bad8301bc","","",false, this);
 

        }
        public IRPSButton<ImputationMaterialVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<ImputationMaterialVMEntityView,ImputationMaterialVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDProject { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDPROTask { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> EntryDate { get; set; } 
        public IRPSCheckbox<ImputationMaterialVMEntityView> MakeMovement { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDArticle { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> CostAmountReal { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> Series { get; set; } 
        public IRPSComboBox<ImputationMaterialVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ImputationMaterialVMEntityView> ExpiryDate { get; set; } 
        public AutomaticExits Screen { get; set; }
        public ImputationMaterialVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
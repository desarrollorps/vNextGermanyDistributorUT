    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.SupplierHomologation
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierHomologation:Screen
    {
        public SupplierHomologation():base()
        {
            this.URL = "quality.supplierhomologation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierHomologationCollectionView  = new SupplierHomologationCollectionView(this); 
            SupplierHomologationEntityView  = new SupplierHomologationEntityView(this); 
            SupplierHomologationCollectionView.InitializeControls(); 
            SupplierHomologationEntityView.InitializeControls(); 
           
        }
      
            public SupplierHomologationCollectionView SupplierHomologationCollectionView {get; set; } 
            public SupplierHomologationEntityView SupplierHomologationEntityView {get; set; } 
    }
            
    public partial class SupplierHomologationCollectionView : View
    {
        public SupplierHomologationCollectionView(SupplierHomologation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierHomologationCollectionView,SupplierHomologationEntityView>( this,Screen.SupplierHomologationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "89f522ce-9beb-424a-81e4-ea25f059966f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierHomologationCollectionView,SupplierHomologationEntityView>( params_MainConsult,this,Screen.SupplierHomologationEntityView);
 

        }
        public IRPSButton<SupplierHomologationCollectionView,SupplierHomologationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierHomologationCollectionView,SupplierHomologationEntityView> MainConsult { get; set; } 
        public SupplierHomologation Screen { get; set; }
        public SupplierHomologationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierHomologationEntityView : View
    {
        public SupplierHomologationEntityView(SupplierHomologation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierHomologationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierHomologationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierHomologationEntityView,SupplierHomologationCollectionView>( this,Screen.SupplierHomologationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierHomologationEntityView,SupplierHomologationCollectionView>( this,Screen.SupplierHomologationCollectionView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierHomologationEntityView>("90343a5a-6605-495f-a195-48c78d901a61","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SupplierHomologationEntityView>("8f752b9f-ff8b-48a0-ad8b-2f0a97c82765","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<SupplierHomologationEntityView>("fa230e30-7677-4981-9ac6-65f3f23bcc55","","",true, this);
 
            ReportNumber = RPSControlFactory.CreateRPSTextBox<SupplierHomologationEntityView>("2a00c3db-1c2e-40e2-b27f-5880d0c722d0","","",false, this);
 
            IDStatusDrawing = RPSControlFactory.CreateRPSComboBox<SupplierHomologationEntityView>("37245071-f92e-4f61-8923-4830a8a1d778","","",false, this);
 
            DateHomologation = RPSControlFactory.CreateRPSTextBox<SupplierHomologationEntityView>("1245405e-ff4a-4da2-909f-d69225cea427","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<SupplierHomologationEntityView>("0b65dd0a-b01d-4920-adb4-93a2d499c0df","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierHomologationEntityView>( "","ul li[rpsid='a6e683b9-4827-4397-a6dd-44f88d516918']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SupplierHomologationEntityView>( "","ul li[rpsid='02ee3056-3ff8-4dd1-9578-ed19061be955']","",this);
 

        }
        public IRPSSaveButton<SupplierHomologationEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierHomologationEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierHomologationEntityView,SupplierHomologationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierHomologationEntityView,SupplierHomologationCollectionView> BackButton { get; set; } 
        public IRPSComboBox<SupplierHomologationEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<SupplierHomologationEntityView> IDArticle { get; set; } 
        public IRPSComboBox<SupplierHomologationEntityView> IDArticleVersion { get; set; } 
        public IRPSTextBox<SupplierHomologationEntityView> ReportNumber { get; set; } 
        public IRPSComboBox<SupplierHomologationEntityView> IDStatusDrawing { get; set; } 
        public IRPSTextBox<SupplierHomologationEntityView> DateHomologation { get; set; } 
        public IRPSTextBox<SupplierHomologationEntityView> Comments { get; set; } 
        public IRPSSection<SupplierHomologationEntityView> Section { get; set; } 
        public IRPSSection<SupplierHomologationEntityView> Section1 { get; set; } 
        public SupplierHomologation Screen { get; set; }
        public SupplierHomologationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
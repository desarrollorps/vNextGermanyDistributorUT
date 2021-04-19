    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.MerchandiseGift
{
    //RPS VERSION 1.0.0.0
    public partial class MerchandiseGift:Screen
    {
        public MerchandiseGift():base()
        {
            this.URL = "sales.merchandisegift";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MerchandiseGiftSLCollectionView  = new MerchandiseGiftSLCollectionView(this); 
            MerchandiseGiftSLEntityView  = new MerchandiseGiftSLEntityView(this); 
            MerchandiseGiftSLCollectionView.InitializeControls(); 
            MerchandiseGiftSLEntityView.InitializeControls(); 
           
        }
      
            public MerchandiseGiftSLCollectionView MerchandiseGiftSLCollectionView {get; set; } 
            public MerchandiseGiftSLEntityView MerchandiseGiftSLEntityView {get; set; } 
    }
            
    public partial class MerchandiseGiftSLCollectionView : View
    {
        public MerchandiseGiftSLCollectionView(MerchandiseGift screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MerchandiseGiftSLCollectionView,MerchandiseGiftSLEntityView>( this,Screen.MerchandiseGiftSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9b1dd49d-425f-4d70-89f1-9c0e037fdb8f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MerchandiseGiftSLCollectionView,MerchandiseGiftSLEntityView>( params_MainConsult,this,Screen.MerchandiseGiftSLEntityView);
 

        }
        public IRPSButton<MerchandiseGiftSLCollectionView,MerchandiseGiftSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MerchandiseGiftSLCollectionView,MerchandiseGiftSLEntityView> MainConsult { get; set; } 
        public MerchandiseGift Screen { get; set; }
        public MerchandiseGiftSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MerchandiseGiftSLEntityView : View
    {
        public MerchandiseGiftSLEntityView(MerchandiseGift screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MerchandiseGiftSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MerchandiseGiftSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MerchandiseGiftSLEntityView,MerchandiseGiftSLCollectionView>( this,Screen.MerchandiseGiftSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MerchandiseGiftSLEntityView,MerchandiseGiftSLCollectionView>( this,Screen.MerchandiseGiftSLCollectionView);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSTextBox<MerchandiseGiftSLEntityView>("eecc6b66-acd2-4cec-a543-c41b465314b5","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MerchandiseGiftSLEntityView>("c1d77bb5-3c1c-40e5-835b-77155504151a","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MerchandiseGiftSLEntityView>("8a3d05b5-d1bd-429a-876c-006c982dc9a6","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MerchandiseGiftSLEntityView>("8843b3d0-71d5-419f-a104-b3c28ef91145","","",true, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MerchandiseGiftSLEntityView>("17df155e-847d-4bea-9c0d-de814fdecde5","","",true, this);
 
            GiftQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MerchandiseGiftSLEntityView>("f3c9c62b-42bb-4ea7-9469-106d6638898d","","",false, this);
 
            GeneratedFromRappel = RPSControlFactory.CreateRPSCheckBox<MerchandiseGiftSLEntityView>("06bacf3e-337c-4319-b5f1-5022bd8425d2","","",true, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<MerchandiseGiftSLEntityView>("0af5213f-5cf5-45ca-877d-d991b4d4a0a2","","",true, this);
 

        }
        public IRPSSaveButton<MerchandiseGiftSLEntityView> SaveButton { get; set; } 
        public IRPSButton<MerchandiseGiftSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<MerchandiseGiftSLEntityView,MerchandiseGiftSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MerchandiseGiftSLEntityView,MerchandiseGiftSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MerchandiseGiftSLEntityView> CodMerchandiseGift { get; set; } 
        public IRPSComboBox<MerchandiseGiftSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<MerchandiseGiftSLEntityView> IDArticle { get; set; } 
        public IRPSTextBox<MerchandiseGiftSLEntityView> Date { get; set; } 
        public IRPSTextBox<MerchandiseGiftSLEntityView> TotalQuantity { get; set; } 
        public IRPSTextBox<MerchandiseGiftSLEntityView> GiftQuantity { get; set; } 
        public IRPSCheckbox<MerchandiseGiftSLEntityView> GeneratedFromRappel { get; set; } 
        public IRPSCheckbox<MerchandiseGiftSLEntityView> Rappel { get; set; } 
        public MerchandiseGift Screen { get; set; }
        public MerchandiseGiftSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
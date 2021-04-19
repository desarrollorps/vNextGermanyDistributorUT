    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.MerchandiseGift
{
    //RPS VERSION 1.0.0.0
    public partial class MerchandiseGift:Screen
    {
        public MerchandiseGift():base()
        {
            this.URL = "purchase.merchandisegift";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MerchandiseGiftCollectionView  = new MerchandiseGiftCollectionView(this); 
            MerchandiseGiftEntityView  = new MerchandiseGiftEntityView(this); 
            MerchandiseGiftCollectionView.InitializeControls(); 
            MerchandiseGiftEntityView.InitializeControls(); 
           
        }
      
            public MerchandiseGiftCollectionView MerchandiseGiftCollectionView {get; set; } 
            public MerchandiseGiftEntityView MerchandiseGiftEntityView {get; set; } 
    }
            
    public partial class MerchandiseGiftCollectionView : View
    {
        public MerchandiseGiftCollectionView(MerchandiseGift screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MerchandiseGiftCollectionView,MerchandiseGiftEntityView>( this,Screen.MerchandiseGiftEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cadb7ce6-8636-4423-a413-1f4a5cbc35a2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MerchandiseGiftCollectionView,MerchandiseGiftEntityView>( params_MainConsult,this,Screen.MerchandiseGiftEntityView);
 

        }
        public IRPSButton<MerchandiseGiftCollectionView,MerchandiseGiftEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MerchandiseGiftCollectionView,MerchandiseGiftEntityView> MainConsult { get; set; } 
        public MerchandiseGift Screen { get; set; }
        public MerchandiseGiftCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MerchandiseGiftEntityView : View
    {
        public MerchandiseGiftEntityView(MerchandiseGift screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MerchandiseGiftEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MerchandiseGiftEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MerchandiseGiftEntityView,MerchandiseGiftCollectionView>( this,Screen.MerchandiseGiftCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MerchandiseGiftEntityView,MerchandiseGiftCollectionView>( this,Screen.MerchandiseGiftCollectionView);
 
            CodMerchandiseGift = RPSControlFactory.CreateRPSTextBox<MerchandiseGiftEntityView>("b3898af6-44df-4023-a7f0-9a1f9feb299f","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MerchandiseGiftEntityView>("ac813f33-8c37-4953-86cc-8cc6a854fe9b","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MerchandiseGiftEntityView>("e2112f7b-215e-4b07-b80f-3a04df563080","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MerchandiseGiftEntityView>("3167da03-2d8d-4b23-a2b9-cd56a4d16438","","",true, this);
 
            TotalQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MerchandiseGiftEntityView>("ce4ed729-cedd-4222-8216-82bffb6b5d53","","",true, this);
 
            GiftQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MerchandiseGiftEntityView>("e083ec38-0371-4434-8fce-50a05e473ab9","","",false, this);
 
            GeneratedFromRappel = RPSControlFactory.CreateRPSCheckBox<MerchandiseGiftEntityView>("d966c1d1-5bb3-4f3b-b7f5-099380b394b8","","",true, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<MerchandiseGiftEntityView>("f145e58b-23b6-48df-997a-6fd2161efd26","","",true, this);
 

        }
        public IRPSSaveButton<MerchandiseGiftEntityView> SaveButton { get; set; } 
        public IRPSButton<MerchandiseGiftEntityView> DeleteButton { get; set; } 
        public IRPSButton<MerchandiseGiftEntityView,MerchandiseGiftCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MerchandiseGiftEntityView,MerchandiseGiftCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MerchandiseGiftEntityView> CodMerchandiseGift { get; set; } 
        public IRPSComboBox<MerchandiseGiftEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<MerchandiseGiftEntityView> IDArticle { get; set; } 
        public IRPSTextBox<MerchandiseGiftEntityView> Date { get; set; } 
        public IRPSTextBox<MerchandiseGiftEntityView> TotalQuantity { get; set; } 
        public IRPSTextBox<MerchandiseGiftEntityView> GiftQuantity { get; set; } 
        public IRPSCheckbox<MerchandiseGiftEntityView> GeneratedFromRappel { get; set; } 
        public IRPSCheckbox<MerchandiseGiftEntityView> Rappel { get; set; } 
        public MerchandiseGift Screen { get; set; }
        public MerchandiseGiftEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
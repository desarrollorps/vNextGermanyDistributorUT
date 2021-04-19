    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Kit
{
    //RPS VERSION 1.0.0.0
    public partial class Kit:Screen
    {
        public Kit():base()
        {
            this.URL = "purchase.kit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            KitCollectionView  = new KitCollectionView(this); 
            KitEntityView  = new KitEntityView(this); 
            KitComponentView  = new KitComponentView(this); 
            UpdateDeleteKitsDialogView  = new UpdateDeleteKitsDialogView(this); 
            KitCollectionView.InitializeControls(); 
            KitEntityView.InitializeControls(); 
            KitComponentView.InitializeControls(); 
            UpdateDeleteKitsDialogView.InitializeControls(); 
           
        }
      
            public KitCollectionView KitCollectionView {get; set; } 
            public KitEntityView KitEntityView {get; set; } 
            public KitComponentView KitComponentView {get; set; } 
            public UpdateDeleteKitsDialogView UpdateDeleteKitsDialogView {get; set; } 
    }
            
    public partial class KitCollectionView : View
    {
        public KitCollectionView(Kit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<KitCollectionView,KitEntityView>( this,Screen.KitEntityView);
 
            UpdateDeleteKitsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<KitCollectionView,UpdateDeleteKitsDialogView>("54c84d8a-0dd7-4af1-acaa-a6f4ca1938af","","", this,Screen.UpdateDeleteKitsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9ad757f2-9943-41c8-8bea-619917b7e02d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<KitCollectionView,KitEntityView>( params_MainConsult,this,Screen.KitEntityView);
 

        }
        public IRPSButton<KitCollectionView,KitEntityView> NewButton { get; set; } 
        public IRPSButton<KitCollectionView,UpdateDeleteKitsDialogView> UpdateDeleteKitsNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<KitCollectionView,KitEntityView> MainConsult { get; set; } 
        public Kit Screen { get; set; }
        public KitCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class KitEntityView : View
    {
        public KitEntityView(Kit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<KitEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<KitEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<KitEntityView,KitCollectionView>( this,Screen.KitCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<KitEntityView,KitCollectionView>( this,Screen.KitCollectionView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<KitEntityView>("215d5e2c-756d-477a-ae85-045a9e0ba20a","","",true, this);
 
            PriceType = RPSControlFactory.CreateRPSEnumComboBox<KitEntityView>("b4c26d7b-6a71-4bf6-af14-76b0e4c8a729","","",true, this);
 
            CollectionInit params_KitComponents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a347bde7-7757-4fc7-b091-b20428c16ec9",CSSSelectorGrid="",XPathGrid=""};
            KitComponents = RPSControlFactory.RPSCreateCollectionWithGrid<KitComponentsCollectionEditor<KitEntityView,KitComponentView>,KitEntityView,KitComponentView>( params_KitComponents,this,Screen.KitComponentView);
 

        }
        public IRPSSaveButton<KitEntityView> SaveButton { get; set; } 
        public IRPSButton<KitEntityView> DeleteButton { get; set; } 
        public IRPSButton<KitEntityView,KitCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<KitEntityView,KitCollectionView> BackButton { get; set; } 
        public IRPSComboBox<KitEntityView> IDArticle { get; set; } 
        public IRPSComboBox<KitEntityView> PriceType { get; set; } 
        public KitComponentsCollectionEditor<KitEntityView,KitComponentView> KitComponents { get; set; } 
        public Kit Screen { get; set; }
        public KitEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KitComponentsCollectionEditor<KitEntityView,KitComponentView>:RPSCollectionEditor<KitEntityView,KitComponentView> where KitEntityView : class, IView where KitComponentView : class, IView
    {
        public  KitComponentsGridView<KitEntityView,KitComponentView> GridView {get;set;}
    }
    public partial class KitComponentsGridView <KitEntityView,KitComponentView> :  RPSGridView<KitEntityView,KitComponentView> where KitEntityView : class, IView where KitComponentView : class, IView
    {
        public KitComponentsGridView(KitEntityView currentView,KitComponentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSGridComboBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteType']","",false, this.CurrentView);
 
            PriceType = RPSControlFactory.CreateRPSGridEnumComboBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cPriceType']","",true, this.CurrentView);
 
            CostPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<KitEntityView>("","#a347bde7-7757-4fc7-b091-b20428c16ec9 .ag-row[role='row']@ROWINDEX [col-id='cCostPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<KitEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<KitEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<KitEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<KitEntityView> Price { get; set; } 
        public IRPSGridComboBox<KitEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSGridComboBox<KitEntityView> PriceType { get; set; } 
        public IRPSGridTextBox<KitEntityView> CostPercentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class KitComponentView : View
    {
        public KitComponentView(Kit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<KitComponentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<KitComponentView,KitEntityView>( this,Screen.KitEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<KitComponentView,KitEntityView>( this,Screen.KitEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<KitComponentView,KitEntityView>( this,Screen.KitEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentView>("72151766-eac0-4440-8930-e1ebe2b5e168","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<KitComponentView>("e5de7f10-fdcc-409a-be93-7d3f83a0323a","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentView>("786db6a9-3697-4b1a-a73f-536e8aef611d","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<KitComponentView>("a235815b-177c-495c-bc10-0e1c533bf65f","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentView>("0937dfa7-1aff-4c1c-a587-dc67e8b94c16","","",true, this);
 
            PriceType = RPSControlFactory.CreateRPSEnumComboBox<KitComponentView>("cd864b01-5443-4276-ba0b-1f408a0265dd","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentView>("ed72e3fa-5645-4c54-937e-ce8700aadc2f","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<KitComponentView>("c697c059-c318-4c76-a0cd-446697a9fea7","","",false, this);
 
            GenOrderLine = RPSControlFactory.CreateRPSCheckBox<KitComponentView>("035c73cf-162a-42e2-a081-fdfc62293098","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<KitComponentView>("01279a96-8296-448a-81e7-53b971159cce","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<KitComponentView>("120d6be5-38f7-4a74-b2b4-6105a70bf2ce","","",true, this);
 

        }
        public IRPSButton<KitComponentView> DeleteButton { get; set; } 
        public IRPSButton<KitComponentView,KitEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<KitComponentView,KitEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<KitComponentView,KitEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<KitComponentView> Ordenation { get; set; } 
        public IRPSComboBox<KitComponentView> IDArticle { get; set; } 
        public IRPSTextBox<KitComponentView> Quantity { get; set; } 
        public IRPSComboBox<KitComponentView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<KitComponentView> CostPercentage { get; set; } 
        public IRPSComboBox<KitComponentView> PriceType { get; set; } 
        public IRPSTextBox<KitComponentView> Price { get; set; } 
        public IRPSComboBox<KitComponentView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<KitComponentView> GenOrderLine { get; set; } 
        public IRPSCheckbox<KitComponentView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<KitComponentView> ApplyConditionsNotAffectDocument { get; set; } 
        public Kit Screen { get; set; }
        public KitComponentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateDeleteKitsDialogView : View
    {
        public UpdateDeleteKitsDialogView(Kit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ArticleOld = RPSControlFactory.CreateRPSComboBox<UpdateDeleteKitsDialogView>("b3e198ee-3c8e-4d2f-9846-15f03ad35cfe","","",true, this);
 
            ArticleNew = RPSControlFactory.CreateRPSComboBox<UpdateDeleteKitsDialogView>("41a2bc0b-22b8-42a1-989d-25df15102c0b","","",false, this);
 
            Substitution = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "734c4b0f-8919-41f6-a074-b3814773f88e","","",this);
 
            Elimination = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "65e576b8-8b4d-4f3a-803d-7deeacd75ed1","","",this);
 
            Search = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "da4604e7-f020-4616-a108-a413cf63ed31","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "dc76d789-dd3d-4cf3-a692-2159156c65a0","","",this);
 
            Automatic = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "f037308a-cfce-42f5-9cfe-18ce30755c63","","",this);
 
            CollectionInit params_KitComponentsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="72f5090a-98f9-4c32-83cf-449d2b862c95",CSSSelectorGrid="",XPathGrid=""};
            KitComponentsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<KitComponentsConsultCollectionEditor<UpdateDeleteKitsDialogView>,UpdateDeleteKitsDialogView>( params_KitComponentsConsult,this);
 

        }
        public IRPSComboBox<UpdateDeleteKitsDialogView> ArticleOld { get; set; } 
        public IRPSComboBox<UpdateDeleteKitsDialogView> ArticleNew { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Substitution { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Elimination { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Search { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Manual { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Automatic { get; set; } 
        public KitComponentsConsultCollectionEditor<UpdateDeleteKitsDialogView> KitComponentsConsult { get; set; } 
        public Kit Screen { get; set; }
        public UpdateDeleteKitsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KitComponentsConsultCollectionEditor<UpdateDeleteKitsDialogView>:RPSCollectionEditor<UpdateDeleteKitsDialogView> where UpdateDeleteKitsDialogView : class, IView
    {
        public  KitComponentsConsultGridView<UpdateDeleteKitsDialogView> GridView {get;set;}
    }
    public partial class KitComponentsConsultGridView <UpdateDeleteKitsDialogView> :  RPSGridView<UpdateDeleteKitsDialogView> where UpdateDeleteKitsDialogView : class, IView
    {
        public KitComponentsConsultGridView(UpdateDeleteKitsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            KitComponent_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<UpdateDeleteKitsDialogView>("","#72f5090a-98f9-4c32-83cf-449d2b862c95 .ag-row[role='row']@ROWINDEX [col-id='cKitComponent_Quantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UpdateDeleteKitsDialogView> KitComponent_Quantity { get; set; } 
                     
    }
 
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.KitSL
{
    //RPS VERSION 1.0.0.0
    public partial class KitSL:Screen
    {
        public KitSL():base()
        {
            this.URL = "sales.kitsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            KitSLCollectionView  = new KitSLCollectionView(this); 
            KitSLEntityView  = new KitSLEntityView(this); 
            KitComponentSLView  = new KitComponentSLView(this); 
            UpdateDeleteKitsDialogView  = new UpdateDeleteKitsDialogView(this); 
            KitSLCollectionView.InitializeControls(); 
            KitSLEntityView.InitializeControls(); 
            KitComponentSLView.InitializeControls(); 
            UpdateDeleteKitsDialogView.InitializeControls(); 
           
        }
      
            public KitSLCollectionView KitSLCollectionView {get; set; } 
            public KitSLEntityView KitSLEntityView {get; set; } 
            public KitComponentSLView KitComponentSLView {get; set; } 
            public UpdateDeleteKitsDialogView UpdateDeleteKitsDialogView {get; set; } 
    }
            
    public partial class KitSLCollectionView : View
    {
        public KitSLCollectionView(KitSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<KitSLCollectionView,KitSLEntityView>( this,Screen.KitSLEntityView);
 
            UpdateDeleteKitsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<KitSLCollectionView,UpdateDeleteKitsDialogView>("5d1e7694-b007-4bbd-9637-f88c1d7dd3a5","","", this,Screen.UpdateDeleteKitsDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "39f89b33-fccf-4aa5-8219-b3216ed00b09",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<KitSLCollectionView,KitSLEntityView>( params_MainConsult,this,Screen.KitSLEntityView);
 

        }
        public IRPSButton<KitSLCollectionView,KitSLEntityView> NewButton { get; set; } 
        public IRPSButton<KitSLCollectionView,UpdateDeleteKitsDialogView> UpdateDeleteKitsNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<KitSLCollectionView,KitSLEntityView> MainConsult { get; set; } 
        public KitSL Screen { get; set; }
        public KitSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class KitSLEntityView : View
    {
        public KitSLEntityView(KitSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<KitSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<KitSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<KitSLEntityView,KitSLCollectionView>( this,Screen.KitSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<KitSLEntityView,KitSLCollectionView>( this,Screen.KitSLCollectionView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<KitSLEntityView>("cc4f486c-d6aa-4fca-9d4d-e5b0be329747","","",true, this);
 
            PriceType = RPSControlFactory.CreateRPSEnumComboBox<KitSLEntityView>("e0b00320-1f49-4973-80ab-faee732362d9","","",true, this);
 
            Complete = RPSControlFactory.CreateRPSCheckBox<KitSLEntityView>("9284f931-2fe3-42d0-8054-aa4b40c0d3e6","","",true, this);
 
            CollectionInit params_KitComponentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cb47024b-b8ee-4781-93ef-8896344571cc",CSSSelectorGrid="",XPathGrid=""};
            KitComponentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<KitComponentSLsCollectionEditor<KitSLEntityView,KitComponentSLView>,KitSLEntityView,KitComponentSLView>( params_KitComponentSLs,this,Screen.KitComponentSLView);
 

        }
        public IRPSSaveButton<KitSLEntityView> SaveButton { get; set; } 
        public IRPSButton<KitSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<KitSLEntityView,KitSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<KitSLEntityView,KitSLCollectionView> BackButton { get; set; } 
        public IRPSComboBox<KitSLEntityView> IDArticle { get; set; } 
        public IRPSComboBox<KitSLEntityView> PriceType { get; set; } 
        public IRPSCheckbox<KitSLEntityView> Complete { get; set; } 
        public KitComponentSLsCollectionEditor<KitSLEntityView,KitComponentSLView> KitComponentSLs { get; set; } 
        public KitSL Screen { get; set; }
        public KitSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KitComponentSLsCollectionEditor<KitSLEntityView,KitComponentSLView>:RPSCollectionEditor<KitSLEntityView,KitComponentSLView> where KitSLEntityView : class, IView where KitComponentSLView : class, IView
    {
        public  KitComponentSLsGridView<KitSLEntityView,KitComponentSLView> GridView {get;set;}
    }
    public partial class KitComponentSLsGridView <KitSLEntityView,KitComponentSLView> :  RPSGridView<KitSLEntityView,KitComponentSLView> where KitSLEntityView : class, IView where KitComponentSLView : class, IView
    {
        public KitComponentSLsGridView(KitSLEntityView currentView,KitComponentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            PriceType = RPSControlFactory.CreateRPSGridEnumComboBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cPriceType']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSGridComboBox<KitSLEntityView>("","#cb47024b-b8ee-4781-93ef-8896344571cc .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<KitSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<KitSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<KitSLEntityView> Quantity { get; set; } 
        public IRPSGridComboBox<KitSLEntityView> PriceType { get; set; } 
        public IRPSGridTextBox<KitSLEntityView> Price { get; set; } 
        public IRPSGridComboBox<KitSLEntityView> IDDeliveryNoteType { get; set; } 
                     
    }
 
    }
  
            
    public partial class KitComponentSLView : View
    {
        public KitComponentSLView(KitSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<KitComponentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<KitComponentSLView,KitSLEntityView>( this,Screen.KitSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<KitComponentSLView,KitSLEntityView>( this,Screen.KitSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<KitComponentSLView,KitSLEntityView>( this,Screen.KitSLEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentSLView>("348a8e39-e6d1-41c5-a3a4-2fff236938a1","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<KitComponentSLView>("d1c9b55b-8e33-4c63-bce6-3a07b7825aa7","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentSLView>("3b508cf2-f7ea-404b-9132-79aeb83f4511","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<KitComponentSLView>("ad29b62d-934e-4eb0-9717-0a8fd8f863be","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentSLView>("20a947c0-7b8f-4bbd-a9af-a3e234fb89c3","","",true, this);
 
            PriceType = RPSControlFactory.CreateRPSEnumComboBox<KitComponentSLView>("4044d636-2626-43a9-9526-e44c7eb7b0f1","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<KitComponentSLView>("aaeffd1c-3774-49be-bba3-2101240c4abe","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<KitComponentSLView>("ab017ec6-0687-4495-b1c9-69ade96dbecd","","",false, this);
 
            GenOrderLine = RPSControlFactory.CreateRPSCheckBox<KitComponentSLView>("3b3a38d3-95d9-485f-8082-fafcacc1f88a","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<KitComponentSLView>("f121d709-dd2c-4b0c-9ef7-e2c361d37a08","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<KitComponentSLView>("10b615e6-9717-4893-bf13-46e1b1c4645c","","",true, this);
 

        }
        public IRPSButton<KitComponentSLView> DeleteButton { get; set; } 
        public IRPSButton<KitComponentSLView,KitSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<KitComponentSLView,KitSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<KitComponentSLView,KitSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<KitComponentSLView> Ordenation { get; set; } 
        public IRPSComboBox<KitComponentSLView> IDArticle { get; set; } 
        public IRPSTextBox<KitComponentSLView> Quantity { get; set; } 
        public IRPSComboBox<KitComponentSLView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<KitComponentSLView> CostPercentage { get; set; } 
        public IRPSComboBox<KitComponentSLView> PriceType { get; set; } 
        public IRPSTextBox<KitComponentSLView> Price { get; set; } 
        public IRPSComboBox<KitComponentSLView> IDUnitPrice { get; set; } 
        public IRPSCheckbox<KitComponentSLView> GenOrderLine { get; set; } 
        public IRPSCheckbox<KitComponentSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<KitComponentSLView> ApplyConditionsNotAffectDocument { get; set; } 
        public KitSL Screen { get; set; }
        public KitComponentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateDeleteKitsDialogView : View
    {
        public UpdateDeleteKitsDialogView(KitSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ArticleOld = RPSControlFactory.CreateRPSComboBox<UpdateDeleteKitsDialogView>("b3e198ee-3c8e-4d2f-9846-15f03ad35cfe","","",true, this);
 
            ArticleNew = RPSControlFactory.CreateRPSComboBox<UpdateDeleteKitsDialogView>("41a2bc0b-22b8-42a1-989d-25df15102c0b","","",false, this);
 
            Substitution = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "68d716dd-3114-49e5-9e97-01887f9ecb54","","",this);
 
            Elimination = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "d2e6e717-b457-4f08-95dd-27c925dea12a","","",this);
 
            Search = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "851ed744-6bc3-47b4-b05e-4da48d5f50b3","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "230e0970-df7b-443f-a916-d6a418a88ca8","","",this);
 
            Automatic = RPSControlFactory.CreateRPSOption<UpdateDeleteKitsDialogView>( "60b7042a-6484-45e6-8586-a7baae147919","","",this);
 
            CollectionInit params_KitComponentsSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6a9d2d47-52c1-4892-8768-d747313c7fe5",CSSSelectorGrid="",XPathGrid=""};
            KitComponentsSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<KitComponentsSLConsultCollectionEditor<UpdateDeleteKitsDialogView>,UpdateDeleteKitsDialogView>( params_KitComponentsSLConsult,this);
 

        }
        public IRPSComboBox<UpdateDeleteKitsDialogView> ArticleOld { get; set; } 
        public IRPSComboBox<UpdateDeleteKitsDialogView> ArticleNew { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Substitution { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Elimination { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Search { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Manual { get; set; } 
        public IRPSOption<UpdateDeleteKitsDialogView> Automatic { get; set; } 
        public KitComponentsSLConsultCollectionEditor<UpdateDeleteKitsDialogView> KitComponentsSLConsult { get; set; } 
        public KitSL Screen { get; set; }
        public UpdateDeleteKitsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class KitComponentsSLConsultCollectionEditor<UpdateDeleteKitsDialogView>:RPSCollectionEditor<UpdateDeleteKitsDialogView> where UpdateDeleteKitsDialogView : class, IView
    {
        public  KitComponentsSLConsultGridView<UpdateDeleteKitsDialogView> GridView {get;set;}
    }
    public partial class KitComponentsSLConsultGridView <UpdateDeleteKitsDialogView> :  RPSGridView<UpdateDeleteKitsDialogView> where UpdateDeleteKitsDialogView : class, IView
    {
        public KitComponentsSLConsultGridView(UpdateDeleteKitsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            KitComponentSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<UpdateDeleteKitsDialogView>("","#6a9d2d47-52c1-4892-8768-d747313c7fe5 .ag-row[role='row']@ROWINDEX [col-id='cKitComponentSL_Quantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UpdateDeleteKitsDialogView> KitComponentSL_Quantity { get; set; } 
                     
    }
 
    }
  
    

}
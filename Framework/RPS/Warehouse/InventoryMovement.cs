    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.InventoryMovement
{
    //RPS VERSION 1.0.0.0
    public partial class InventoryMovement:Screen
    {
        public InventoryMovement():base()
        {
            this.URL = "warehouse.inventorymovement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InventaryMovementVMCollectionView  = new InventaryMovementVMCollectionView(this); 
            InventaryMovementVMEntityView  = new InventaryMovementVMEntityView(this); 
            UpdateStockChildDialogView  = new UpdateStockChildDialogView(this); 
            MassiveInsertionChildDialogView  = new MassiveInsertionChildDialogView(this); 
            DirectUpdateChildDialogView  = new DirectUpdateChildDialogView(this); 
            MassiveDeleteChildDialogView  = new MassiveDeleteChildDialogView(this); 
            InventaryMovementVMCollectionView.InitializeControls(); 
            InventaryMovementVMEntityView.InitializeControls(); 
            UpdateStockChildDialogView.InitializeControls(); 
            MassiveInsertionChildDialogView.InitializeControls(); 
            DirectUpdateChildDialogView.InitializeControls(); 
            MassiveDeleteChildDialogView.InitializeControls(); 
           
        }
      
            public InventaryMovementVMCollectionView InventaryMovementVMCollectionView {get; set; } 
            public InventaryMovementVMEntityView InventaryMovementVMEntityView {get; set; } 
            public UpdateStockChildDialogView UpdateStockChildDialogView {get; set; } 
            public MassiveInsertionChildDialogView MassiveInsertionChildDialogView {get; set; } 
            public DirectUpdateChildDialogView DirectUpdateChildDialogView {get; set; } 
            public MassiveDeleteChildDialogView MassiveDeleteChildDialogView {get; set; } 
    }
            
    public partial class InventaryMovementVMCollectionView : View
    {
        public InventaryMovementVMCollectionView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("d4a049be-9009-4f2d-ab9c-7923cefddb29","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("8bc574b4-32b4-4b07-9c42-5d26579e546b","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("22f1d937-ce75-4faa-9432-f1e38f9e8ae6","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("590856b5-ab59-4566-81b1-bcde3c2b5ff9","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("4f43ceb2-1ce7-4f86-adba-dd95e784c04d","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("94bb3c6b-b12c-45b7-9bb0-5d7394036224","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<InventaryMovementVMCollectionView>("9e2f3607-8878-4ff5-814a-84d7b9637a8e","","",false, this);
 
            Acumulated = RPSControlFactory.CreateRPSFormattedTextBox<InventaryMovementVMCollectionView>("217ade46-e375-4b16-8b9a-b057eee6b92a","","",false, this);
 
            ExecuteMassiveInventoryInsertButton = RPSControlFactory.CreateRPSButtonToView<InventaryMovementVMCollectionView,MassiveInsertionChildDialogView>("1f267800-db91-4290-85dc-ff624e48d4ea","","", this,Screen.MassiveInsertionChildDialogView);
 
            UpdateStockChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InventaryMovementVMCollectionView,UpdateStockChildDialogView>("fe56f081-fad4-4478-ab2a-228ad19b5dff","","", this,Screen.UpdateStockChildDialogView);
 
            MassiveDeleteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InventaryMovementVMCollectionView,MassiveDeleteChildDialogView>("bd81a0c6-2241-4a50-8e25-a1f73fa238ab","","", this,Screen.MassiveDeleteChildDialogView);
 
            DirectUpdateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InventaryMovementVMCollectionView,DirectUpdateChildDialogView>("312b15c4-29ae-4066-a624-0ffa6132c4e8","","", this,Screen.DirectUpdateChildDialogView);
 
            CollectionInit params_InventoryMovementQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7df65e4c-2f65-4aa8-ac61-2a0b71c0640f",CSSSelectorGrid="",XPathGrid=""};
            InventoryMovementQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InventoryMovementQueryCollectionEditor<InventaryMovementVMCollectionView,InventaryMovementVMEntityView>,InventaryMovementVMCollectionView,InventaryMovementVMEntityView>( params_InventoryMovementQuery,this,Screen.InventaryMovementVMEntityView);
 

        }
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> Article { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> Site { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> WareHouse { get; set; } 
        public IRPSCollectionComboBox<InventaryMovementVMCollectionView> LocationWarehouse { get; set; } 
        public IRPSTextBox<InventaryMovementVMCollectionView> Acumulated { get; set; } 
        public IRPSButton<InventaryMovementVMCollectionView,MassiveInsertionChildDialogView> ExecuteMassiveInventoryInsertButton { get; set; } 
        public IRPSButton<InventaryMovementVMCollectionView,UpdateStockChildDialogView> UpdateStockChildNavigationCommandButton { get; set; } 
        public IRPSButton<InventaryMovementVMCollectionView,MassiveDeleteChildDialogView> MassiveDeleteChildNavigationCommandButton { get; set; } 
        public IRPSButton<InventaryMovementVMCollectionView,DirectUpdateChildDialogView> DirectUpdateChildNavigationCommandButton { get; set; } 
        public InventoryMovementQueryCollectionEditor<InventaryMovementVMCollectionView,InventaryMovementVMEntityView> InventoryMovementQuery { get; set; } 
        public InventoryMovement Screen { get; set; }
        public InventaryMovementVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InventoryMovementQueryCollectionEditor<InventaryMovementVMCollectionView,InventaryMovementVMEntityView>:RPSCollectionEditor<InventaryMovementVMCollectionView,InventaryMovementVMEntityView> where InventaryMovementVMCollectionView : class, IView where InventaryMovementVMEntityView : class, IView
    {
        public  InventoryMovementQueryGridView<InventaryMovementVMCollectionView,InventaryMovementVMEntityView> GridView {get;set;}
    }
    public partial class InventoryMovementQueryGridView <InventaryMovementVMCollectionView,InventaryMovementVMEntityView> :  RPSGridView<InventaryMovementVMCollectionView,InventaryMovementVMEntityView> where InventaryMovementVMCollectionView : class, IView where InventaryMovementVMEntityView : class, IView
    {
        public InventoryMovementQueryGridView(InventaryMovementVMCollectionView currentView,InventaryMovementVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MovementDate = RPSControlFactory.CreateRPSGridTextBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cMovementDate']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",true, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",true, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<InventaryMovementVMCollectionView>("","#7df65e4c-2f65-4aa8-ac61-2a0b71c0640f .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InventaryMovementVMCollectionView> MovementDate { get; set; } 
        public IRPSGridComboBox<InventaryMovementVMCollectionView> IDArticle { get; set; } 
        public IRPSGridComboBox<InventaryMovementVMCollectionView> IDSite { get; set; } 
        public IRPSGridComboBox<InventaryMovementVMCollectionView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<InventaryMovementVMCollectionView> Series { get; set; } 
        public IRPSGridComboBox<InventaryMovementVMCollectionView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<InventaryMovementVMCollectionView> ExpiryDate { get; set; } 
        public IRPSGridTextBox<InventaryMovementVMCollectionView> Quantity { get; set; } 
        public IRPSGridTextBox<InventaryMovementVMCollectionView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<InventaryMovementVMCollectionView> PotencyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class InventaryMovementVMEntityView : View
    {
        public InventaryMovementVMEntityView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InventaryMovementVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView>( this,Screen.InventaryMovementVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView>( this,Screen.InventaryMovementVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView>( this,Screen.InventaryMovementVMCollectionView);
 
            MovementDate = RPSControlFactory.CreateRPSTextBox<InventaryMovementVMEntityView>("6ba7ad73-abe6-4e3d-8990-2d46b37dc041","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InventaryMovementVMEntityView>("4e99e27c-3aaf-4b33-a4e0-3dae18c4fb85","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<InventaryMovementVMEntityView>("a4ee5c9d-76b5-4ae5-8b73-335336d4c07f","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<InventaryMovementVMEntityView>("631163af-685b-4c43-a157-0c6f8c4d3be6","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<InventaryMovementVMEntityView>("d1bdc306-10cf-40f7-82a4-58108ca7c3b2","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<InventaryMovementVMEntityView>("4cfcd105-646e-4d59-9ae3-d3b2983d545a","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<InventaryMovementVMEntityView>("c70c6ace-fe31-4206-8239-b8b589e480b9","","",true, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<InventaryMovementVMEntityView>("7b8d43e1-6fb9-4e63-b1bc-949e548d47b9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<InventaryMovementVMEntityView>("4341db7e-59fb-4d4e-a1fd-638eeb6723a1","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<InventaryMovementVMEntityView>("8ac087fa-d46f-47cd-ae24-3316d6e60da3","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InventaryMovementVMEntityView>("2b644f29-b53d-4aa9-bd8d-4349619dd4fb","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<InventaryMovementVMEntityView>( "","ul li[rpsid='91510910-959a-4579-86ae-1ae029e34384']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<InventaryMovementVMEntityView>( "","ul li[rpsid='82ea08b5-ea6f-4671-bab4-656deaf20147']","",this);
 

        }
        public IRPSButton<InventaryMovementVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<InventaryMovementVMEntityView,InventaryMovementVMCollectionView> AcceptButton { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> MovementDate { get; set; } 
        public IRPSComboBox<InventaryMovementVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<InventaryMovementVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<InventaryMovementVMEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<InventaryMovementVMEntityView> Series { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> ExpiryDate { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> PotencyValue { get; set; } 
        public IRPSComboBox<InventaryMovementVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<InventaryMovementVMEntityView> Comment { get; set; } 
        public IRPSSection<InventaryMovementVMEntityView> Section { get; set; } 
        public IRPSSection<InventaryMovementVMEntityView> Section1 { get; set; } 
        public InventoryMovement Screen { get; set; }
        public InventaryMovementVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateStockChildDialogView : View
    {
        public UpdateStockChildDialogView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Purchase_Last_Price = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "3b88733a-f5ff-4b7c-b751-e46195504c69","","",this);
 
            Average_Cost = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "1f88d060-a673-4c8d-9d40-10859268cb5c","","",this);
 
            Manufacturing_Last_Price = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "c9d4bcb7-91bf-4aa1-9149-872c82798538","","",this);
 
            Standard_Cost = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "0a55224c-13a7-45a2-abda-285d73ae51a6","","",this);
 
            Price_by_Valuation_Code = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "df1c727e-9434-4bca-9e5f-da51828a3759","","",this);
 
            First_Movement_Day = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "34217960-0ef9-48e0-be7d-344b45f2e34f","","",this);
 
            Last_Movement_Day = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "a7f0e1d1-bcf1-4b9c-9f34-f25d9792d640","","",this);
 
            By_Order_Entry = RPSControlFactory.CreateRPSOption<UpdateStockChildDialogView>( "54baa6b3-5007-493f-9f6b-f3b2679f4770","","",this);
 
            UpdateStockCommand = RPSControlFactory.CreateRPSButton<UpdateStockChildDialogView>( "6ae0ce5b-9ce4-4c39-b77f-b343f8b007f1","","",this);
 
            CollectionInit params_UpdateStockActual = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22890003-a8c1-4090-bc11-1f54bda761b3",CSSSelectorGrid="",XPathGrid=""};
            UpdateStockActual = RPSControlFactory.RPSCreateCollectionWithGrid<UpdateStockActualCollectionEditor<UpdateStockChildDialogView>,UpdateStockChildDialogView>( params_UpdateStockActual,this);
 

        }
        public IRPSOption<UpdateStockChildDialogView> Purchase_Last_Price { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> Average_Cost { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> Manufacturing_Last_Price { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> Standard_Cost { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> Price_by_Valuation_Code { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> First_Movement_Day { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> Last_Movement_Day { get; set; } 
        public IRPSOption<UpdateStockChildDialogView> By_Order_Entry { get; set; } 
        public IRPSButton<UpdateStockChildDialogView> UpdateStockCommand { get; set; } 
        public UpdateStockActualCollectionEditor<UpdateStockChildDialogView> UpdateStockActual { get; set; } 
        public InventoryMovement Screen { get; set; }
        public UpdateStockChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UpdateStockActualCollectionEditor<UpdateStockChildDialogView>:RPSCollectionEditor<UpdateStockChildDialogView> where UpdateStockChildDialogView : class, IView
    {
        public  UpdateStockActualGridView<UpdateStockChildDialogView> GridView {get;set;}
    }
    public partial class UpdateStockActualGridView <UpdateStockChildDialogView> :  RPSGridView<UpdateStockChildDialogView> where UpdateStockChildDialogView : class, IView
    {
        public UpdateStockActualGridView(UpdateStockChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<UpdateStockChildDialogView>("","#22890003-a8c1-4090-bc11-1f54bda761b3 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UpdateStockChildDialogView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class MassiveInsertionChildDialogView : View
    {
        public MassiveInsertionChildDialogView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InventoryDate = RPSControlFactory.CreateRPSTextBox<MassiveInsertionChildDialogView>("0cb3d412-d4ec-4216-800b-a7c3168fae5e","","",true, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("71d606ef-f8b9-4f53-aa96-91dbbe12003c","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("475ba00d-9391-40af-8da6-95fe9edaaf8f","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("7f09542a-9825-4bb5-ab31-1e333cd5daf1","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("f9283e9e-3731-4d50-8154-f48a858b08e8","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("299ffdb0-24dd-4824-938a-150355e0ff0f","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("236ef8d5-032e-4e3e-9369-41be4b4f90d3","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<MassiveInsertionChildDialogView>("ed712444-2367-4d06-b2e9-2c3d969bbb1c","","",false, this);
 

        }
        public IRPSTextBox<MassiveInsertionChildDialogView> InventoryDate { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> Article { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> Site { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> WareHouse { get; set; } 
        public IRPSCollectionComboBox<MassiveInsertionChildDialogView> LocationWarehouse { get; set; } 
        public InventoryMovement Screen { get; set; }
        public MassiveInsertionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DirectUpdateChildDialogView : View
    {
        public DirectUpdateChildDialogView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            First = RPSControlFactory.CreateRPSOption<DirectUpdateChildDialogView>( "404dd33a-9d1f-4efb-b6a1-d452709301aa","","",this);
 
            Last = RPSControlFactory.CreateRPSOption<DirectUpdateChildDialogView>( "055a6569-27d2-4a7b-b50b-619b0cf5737e","","",this);
 
            Actual = RPSControlFactory.CreateRPSOption<DirectUpdateChildDialogView>( "551fcb23-faa8-4095-9175-1017ad4217a4","","",this);
 

        }
        public IRPSOption<DirectUpdateChildDialogView> First { get; set; } 
        public IRPSOption<DirectUpdateChildDialogView> Last { get; set; } 
        public IRPSOption<DirectUpdateChildDialogView> Actual { get; set; } 
        public InventoryMovement Screen { get; set; }
        public DirectUpdateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MassiveDeleteChildDialogView : View
    {
        public MassiveDeleteChildDialogView(InventoryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public InventoryMovement Screen { get; set; }
        public MassiveDeleteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
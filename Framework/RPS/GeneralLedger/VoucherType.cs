    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VoucherType
{
    //RPS VERSION 1.0.0.0
    public partial class VoucherType:Screen
    {
        public VoucherType():base()
        {
            this.URL = "generalledger.vouchertype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VoucherTypeCollectionView  = new VoucherTypeCollectionView(this); 
            VoucherTypeEntityView  = new VoucherTypeEntityView(this); 
            VoucherTypeCollectionView.InitializeControls(); 
            VoucherTypeEntityView.InitializeControls(); 
           
        }
      
            public VoucherTypeCollectionView VoucherTypeCollectionView {get; set; } 
            public VoucherTypeEntityView VoucherTypeEntityView {get; set; } 
    }
            
    public partial class VoucherTypeCollectionView : View
    {
        public VoucherTypeCollectionView(VoucherType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VoucherTypeCollectionView,VoucherTypeEntityView>( this,Screen.VoucherTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "831bbce6-af5c-4bb3-ab9b-d538ca662390",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VoucherTypeCollectionView,VoucherTypeEntityView>( params_MainConsult,this,Screen.VoucherTypeEntityView);
 

        }
        public IRPSButton<VoucherTypeCollectionView,VoucherTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VoucherTypeCollectionView,VoucherTypeEntityView> MainConsult { get; set; } 
        public VoucherType Screen { get; set; }
        public VoucherTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VoucherTypeEntityView : View
    {
        public VoucherTypeEntityView(VoucherType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VoucherTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherTypeEntityView,VoucherTypeCollectionView>( this,Screen.VoucherTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherTypeEntityView,VoucherTypeCollectionView>( this,Screen.VoucherTypeCollectionView);
 
            CodVoucherType = RPSControlFactory.CreateRPSTextBox<VoucherTypeEntityView>("029f61cf-bfea-4bc5-b1cf-d770682b13fa","","",true, this);
 
            ACCArea = RPSControlFactory.CreateRPSEnumComboBox<VoucherTypeEntityView>("01405795-d134-4b31-8023-af36621946b7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VoucherTypeEntityView>("7f49b103-3b3f-4542-9b2d-7e11012d78d3","","",false, this);
 
            IsImport = RPSControlFactory.CreateRPSCheckBox<VoucherTypeEntityView>("23655c8a-ebc4-4d7a-a6f0-47627930fe27","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<VoucherTypeEntityView>("41c7fcee-3940-4fe7-bcb4-940f069acd32","","",false, this);
 

        }
        public IRPSSaveButton<VoucherTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<VoucherTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<VoucherTypeEntityView,VoucherTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherTypeEntityView,VoucherTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VoucherTypeEntityView> CodVoucherType { get; set; } 
        public IRPSComboBox<VoucherTypeEntityView> ACCArea { get; set; } 
        public IRPSTextBox<VoucherTypeEntityView> Description { get; set; } 
        public IRPSCheckbox<VoucherTypeEntityView> IsImport { get; set; } 
        public IRPSComboBox<VoucherTypeEntityView> IDVoucherSeriesBook { get; set; } 
        public VoucherType Screen { get; set; }
        public VoucherTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
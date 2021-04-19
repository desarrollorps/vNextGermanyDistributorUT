    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierArticlePricesProcess
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierArticlePricesProcess:Screen
    {
        public SupplierArticlePricesProcess():base()
        {
            this.URL = "purchase.supplierarticlepricesprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierArticlePricesProcessView  = new SupplierArticlePricesProcessView(this); 
            SupplierArticlePricesProcessView.InitializeControls(); 
           
        }
      
            public SupplierArticlePricesProcessView SupplierArticlePricesProcessView {get; set; } 
    }
            
    public partial class SupplierArticlePricesProcessView : View
    {
        public SupplierArticlePricesProcessView(SupplierArticlePricesProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewPrices = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "f44e0333-b559-4e21-8146-a72a349a8e62","","",this);
 
            CopyPrices = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "8df3a846-82c0-4228-b593-cb064c1c8f79","","",this);
 
            ModifyPrices = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "fd3da981-4fb7-4941-9c8b-2230ec844a48","","",this);
 
            ExtendDates = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "d0c3271c-10ea-4119-a754-a278db2601b8","","",this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<SupplierArticlePricesProcessView>("1a52d8c5-0687-4722-b5e1-0917ff9afa0e","","",true, this);
 
            ProductLine2 = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticlePricesProcessView>("8294fdee-fe44-41c0-98c5-40a33edf7e72","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticlePricesProcessView>("95836a67-2125-43a3-939d-56539008a432","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticlePricesProcessView>("0051ec12-ba8c-4bf0-aad7-3f0f8152c1a9","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticlePricesProcessView>("2a393cf4-7c85-4310-a759-859a186dd773","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierArticlePricesProcessView>("8e456ac3-a8ad-4417-8b36-3657cf3eb89f","","",false, this);
 
            Select = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "85530f56-91b2-4ac9-8ba6-65728f57f02b","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("5a75d010-df38-4673-9f9f-fda58ed9bbf3","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("c62803ba-59c1-4858-9f78-0bb04548d3bf","","",true, this);
 
            validity = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "04ac9140-fd00-4a45-aa95-1e3f53f3891f","","",this);
 
            Originvalidity = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("045f232f-19fe-4db3-8103-06354fcd675f","","",false, this);
 
            SupplierTo = RPSControlFactory.CreateRPSComboBox<SupplierArticlePricesProcessView>("c6db1684-eada-45ab-bb88-87abd06ebdf0","","",false, this);
 
            NewDateFrom = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("e2422660-3e84-41bf-b422-69d0f97d1c46","","",true, this);
 
            NewDateTo = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("ddc02a44-16c6-4faf-9a3d-21c9da3d2a74","","",true, this);
 
            NewDateTo1 = RPSControlFactory.CreateRPSTextBox<SupplierArticlePricesProcessView>("370d1b60-df71-4b2b-b466-08e5156fa6b7","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "f3bed5a8-9c6a-4cc7-801a-db10a9074f4a","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "dd8d408f-13e2-42e8-93aa-14102a84d43f","","",this);
 
            NewPrice = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePricesProcessView>("3007ca9f-5dde-4d9f-997a-73c35e721e25","","",true, this);
 
            None = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "f53bb54e-dca3-4fcc-8573-cc1438368f1c","","",this);
 
            Zero = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "f7abbfe7-fe11-4b8e-bcfe-a6206b50b303","","",this);
 
            One = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "15957e20-5c61-4b93-a7ad-cc0bc9c7880b","","",this);
 
            Two = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "92fb6ff3-f701-4b70-957b-85259cd63a20","","",this);
 
            Three = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "f03cdde6-617f-4dab-b6e6-7fc9d4848eea","","",this);
 
            Four = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "8d3b8c21-241e-4498-af4c-77b64c788fdb","","",this);
 
            Five = RPSControlFactory.CreateRPSOption<SupplierArticlePricesProcessView>( "36bda012-8b9f-4f50-a050-61954fc824af","","",this);
 

        }
        public IRPSOption<SupplierArticlePricesProcessView> NewPrices { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> CopyPrices { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> ModifyPrices { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> ExtendDates { get; set; } 
        public IRPSComboBox<SupplierArticlePricesProcessView> Supplier { get; set; } 
        public IRPSCollectionComboBox<SupplierArticlePricesProcessView> ProductLine2 { get; set; } 
        public IRPSCollectionComboBox<SupplierArticlePricesProcessView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierArticlePricesProcessView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierArticlePricesProcessView> Article { get; set; } 
        public IRPSComboBox<SupplierArticlePricesProcessView> IDCurrency { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Select { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> DateFrom { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> DateTo { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> validity { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> Originvalidity { get; set; } 
        public IRPSComboBox<SupplierArticlePricesProcessView> SupplierTo { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> NewDateFrom { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> NewDateTo { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> NewDateTo1 { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Percentage { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Amount { get; set; } 
        public IRPSTextBox<SupplierArticlePricesProcessView> NewPrice { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> None { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Zero { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> One { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Two { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Three { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Four { get; set; } 
        public IRPSOption<SupplierArticlePricesProcessView> Five { get; set; } 
        public SupplierArticlePricesProcess Screen { get; set; }
        public SupplierArticlePricesProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
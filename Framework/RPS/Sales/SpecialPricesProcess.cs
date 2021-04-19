    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.SpecialPricesProcess
{
    //RPS VERSION 1.0.0.0
    public partial class SpecialPricesProcess:Screen
    {
        public SpecialPricesProcess():base()
        {
            this.URL = "sales.specialpricesprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SpecialPricesProcessView  = new SpecialPricesProcessView(this); 
            SpecialPricesProcessView.InitializeControls(); 
           
        }
      
            public SpecialPricesProcessView SpecialPricesProcessView {get; set; } 
    }
            
    public partial class SpecialPricesProcessView : View
    {
        public SpecialPricesProcessView(SpecialPricesProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "f177b950-a069-4bdc-9c59-5ca91d1b1e36","","",this);
 
            CustomerGroup = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "ae37ad63-ebb4-4aac-a2fa-a72fe55ec30d","","",this);
 
            NewPricesCustomer = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "2a947a11-f0d5-48e6-a09f-a9411b46bb78","","",this);
 
            NewPricesCustomerArticle = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "17b501b4-592d-46d6-bc57-3490846374d7","","",this);
 
            NewPricesCustomerGroup = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "dbdc7d0b-1c8c-4204-a80a-1a409e295fa2","","",this);
 
            NewPricesCustomerGroupArticle = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "a030fcb2-1e48-4768-a437-1f0659c2a563","","",this);
 
            ModifyPrices = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "7667395d-19e6-4b9c-9213-3447c4553c82","","",this);
 
            ExtendDates = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "88f4833a-e878-406e-8605-89fa6b4049e2","","",this);
 
            NewPrices = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "833addb3-8316-4bbe-a6be-e4ae7302db50","","",this);
 
            Customer1 = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "48462291-9e79-40f3-b437-6e2fd40f8bec","","",this);
 
            CustomerforCopies = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("7d7cb04f-1c1a-433c-a28b-a4fbda81a2da","","",false, this);
 
            Customer2 = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("284f34a8-d7e8-45dc-ad44-e402bfa39604","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "d3e2b629-ff62-42c0-b86e-b5eaddf5bc5e","","",this);
 
            Customer3 = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "79641112-ddd4-4dd8-bdf6-7a4b4c686922","","",this);
 
            CustomerGroupSL = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("5ca12028-b552-4ed3-bd6e-841e5e165792","","",false, this);
 
            CustomerGroupValueSL = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("62bb0c11-d886-4709-8d5f-afbd44b9bc9a","","",true, this);
 
            CustomerGroupSLForCopies = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("c34d5432-4ade-44f8-b78a-5f006f0a55a5","","",false, this);
 
            CustomerGroupValueSLForCopies = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("efa583a7-f2ea-4620-9cd7-3f1f80cb4e9f","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "badb6868-2838-4a9f-be71-7f940d68414f","","",this);
 
            ProductLine2 = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("41088cba-a753-4a67-96a3-491dd43a57e1","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("f840d4fd-f342-4a59-bc4f-c6a7ecf50917","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("32640e4a-4c6f-4a53-8fbe-a0067f31fe6c","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("67806136-1a03-40e7-860c-34b94e0d327a","","",false, this);
 
            Currency = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("9c22e249-833e-4efa-aebb-360c67f3b5ba","","",false, this);
 
            Select = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "b790bb06-1501-485b-8965-52aeb01e6aba","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("465b8926-d1c0-42e4-9277-cb7151daba86","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("9a909c59-df41-4bf8-b1d1-c1820c7748cb","","",false, this);
 
            validity = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "7262ee22-d615-4360-9ea6-26acc1ce74af","","",this);
 
            Originvalidity = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("2194ece2-068c-4f95-875b-8200d8b2af86","","",false, this);
 
            NewCustomer = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("fd8994d9-ffd9-43c1-b744-16d129effe4d","","",false, this);
 
            NewCustomerGroup = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("c7cd9cb0-7ee4-4421-93f8-593be8013b29","","",false, this);
 
            NewCustomerGroupValue = RPSControlFactory.CreateRPSComboBox<SpecialPricesProcessView>("3e04b743-d0c6-4c1a-aade-40f8c8204e6b","","",false, this);
 
            NewDateFrom = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("027d666d-1a14-4e1c-9e50-c2e8610496d5","","",false, this);
 
            NewDateTo = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("9f4181cf-5048-403f-94d2-8a03ac484783","","",false, this);
 
            NewDateTo1 = RPSControlFactory.CreateRPSTextBox<SpecialPricesProcessView>("f39bc461-f832-4acb-9740-f8218a486408","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "2acfb171-b6c0-4f07-ab52-86835935af6b","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "4a79d0b0-e8a2-4402-9258-7325754523ee","","",this);
 
            Percentage1 = RPSControlFactory.CreateRPSFormattedTextBox<SpecialPricesProcessView>("a4ed6920-6289-43c4-bcd2-66ebb5267997","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<SpecialPricesProcessView>("a7afbd3d-d7df-4b23-b7b7-f7a866f60f73","","",false, this);
 
            None = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "70e20a00-f5f8-4213-ad8a-0ae6ef66f241","","",this);
 
            Zero = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "6bfd83d0-8864-4fb3-afe4-a49f575e1162","","",this);
 
            One = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "3043eb33-9503-4ebf-bdca-a2e08c9e89b6","","",this);
 
            Two = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "4c1c0035-f044-427a-a08b-419fb96c1986","","",this);
 
            Three = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "fd26b9d6-fca8-4033-b3a3-df2a0b2231b4","","",this);
 
            Four = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "4c9a5416-6ac7-4fb8-b6af-64107e8115b4","","",this);
 
            Five = RPSControlFactory.CreateRPSOption<SpecialPricesProcessView>( "bb6b8451-ede2-4261-b772-a166a9e83f1a","","",this);
 
            ProductLine21 = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("9cbc866b-28d3-4ef1-a9d3-54f624c1ee56","","",false, this);
 
            ProductFamily1 = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("0fa1954f-9158-4acd-ba60-fc59c311419f","","",false, this);
 
            ProductSubFamily1 = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("8487512d-cfcd-42d8-be0b-16d7138d5091","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<SpecialPricesProcessView>("8c843ef3-16fc-49d7-bc12-68cfd41a416f","","",false, this);
 

        }
        public IRPSOption<SpecialPricesProcessView> Customer { get; set; } 
        public IRPSOption<SpecialPricesProcessView> CustomerGroup { get; set; } 
        public IRPSOption<SpecialPricesProcessView> NewPricesCustomer { get; set; } 
        public IRPSOption<SpecialPricesProcessView> NewPricesCustomerArticle { get; set; } 
        public IRPSOption<SpecialPricesProcessView> NewPricesCustomerGroup { get; set; } 
        public IRPSOption<SpecialPricesProcessView> NewPricesCustomerGroupArticle { get; set; } 
        public IRPSOption<SpecialPricesProcessView> ModifyPrices { get; set; } 
        public IRPSOption<SpecialPricesProcessView> ExtendDates { get; set; } 
        public IRPSOption<SpecialPricesProcessView> NewPrices { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Customer1 { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> CustomerforCopies { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> Customer2 { get; set; } 
        public IRPSOption<SpecialPricesProcessView> All { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Customer3 { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> CustomerGroupSL { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> CustomerGroupValueSL { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> CustomerGroupSLForCopies { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> CustomerGroupValueSLForCopies { get; set; } 
        public IRPSOption<SpecialPricesProcessView> All1 { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductLine2 { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> Article { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> Currency { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Select { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> DateFrom { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> DateTo { get; set; } 
        public IRPSOption<SpecialPricesProcessView> validity { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> Originvalidity { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> NewCustomer { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> NewCustomerGroup { get; set; } 
        public IRPSComboBox<SpecialPricesProcessView> NewCustomerGroupValue { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> NewDateFrom { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> NewDateTo { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> NewDateTo1 { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Percentage { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Amount { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> Percentage1 { get; set; } 
        public IRPSTextBox<SpecialPricesProcessView> Price { get; set; } 
        public IRPSOption<SpecialPricesProcessView> None { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Zero { get; set; } 
        public IRPSOption<SpecialPricesProcessView> One { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Two { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Three { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Four { get; set; } 
        public IRPSOption<SpecialPricesProcessView> Five { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductLine21 { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductFamily1 { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> ProductSubFamily1 { get; set; } 
        public IRPSCollectionComboBox<SpecialPricesProcessView> Article1 { get; set; } 
        public SpecialPricesProcess Screen { get; set; }
        public SpecialPricesProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
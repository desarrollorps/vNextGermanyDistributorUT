    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DiscountProcess
{
    //RPS VERSION 1.0.0.0
    public partial class DiscountProcess:Screen
    {
        public DiscountProcess():base()
        {
            this.URL = "sales.discountprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DiscountProcessView  = new DiscountProcessView(this); 
            DiscountProcessView.InitializeControls(); 
           
        }
      
            public DiscountProcessView DiscountProcessView {get; set; } 
    }
            
    public partial class DiscountProcessView : View
    {
        public DiscountProcessView(DiscountProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDiscountGroup = RPSControlFactory.CreateRPSOption<DiscountProcessView>( "e863456d-f90a-4701-838c-22ae250252ff","","",this);
 
            DiscountsInNewDates = RPSControlFactory.CreateRPSOption<DiscountProcessView>( "3ccc46b3-b353-4ecc-a4d5-afdf67dfca41","","",this);
 
            ExtendDates = RPSControlFactory.CreateRPSOption<DiscountProcessView>( "78f7bbdb-c3c2-4c28-ada5-4076085cf96d","","",this);
 
            OriginDiscountGroupSL = RPSControlFactory.CreateRPSComboBox<DiscountProcessView>("9f2c326b-e8c8-4ebe-912e-dbd55388f136","","",true, this);
 
            OriginDateFrom = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("578f399b-14e2-4655-bc5b-4474ba162f80","","",true, this);
 
            OriginDateTo = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("1a43ac1a-03de-446b-81b0-d4b3092ba231","","",true, this);
 
            bArticles = RPSControlFactory.CreateRPSCheckBox<DiscountProcessView>("d1325458-55a5-40b6-8b34-4bdc047758f8","","",false, this);
 
            Articles = RPSControlFactory.CreateRPSCollectionComboBox<DiscountProcessView>("ceab9b00-babf-4cbd-9d46-6da7cf7bbd79","","",false, this);
 
            bProductLine = RPSControlFactory.CreateRPSCheckBox<DiscountProcessView>("52070ff8-ecd2-4f94-b5b9-70195ef138d6","","",false, this);
 
            ProductLines = RPSControlFactory.CreateRPSCollectionComboBox<DiscountProcessView>("050458ba-00ce-4ec3-bc9b-b039b0909ec0","","",false, this);
 
            bProductFamily = RPSControlFactory.CreateRPSCheckBox<DiscountProcessView>("ee252351-a103-44fc-a13f-ab34eec205b4","","",false, this);
 
            ProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<DiscountProcessView>("2de6c00c-6620-4373-b3ec-c0207d804a83","","",false, this);
 
            bProductSubFamily = RPSControlFactory.CreateRPSCheckBox<DiscountProcessView>("6ae20f21-f23a-4cee-a9c3-737b190bb047","","",false, this);
 
            ProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<DiscountProcessView>("1d33ca7c-d7ec-42c4-a64d-f22be8976330","","",false, this);
 
            bAllArticles = RPSControlFactory.CreateRPSCheckBox<DiscountProcessView>("5011dd6b-8d98-4ef7-bf63-260eeb96c703","","",false, this);
 
            TargetDiscountGroupSL = RPSControlFactory.CreateRPSComboBox<DiscountProcessView>("cae391a4-9e13-427e-a1b6-30420dce19d8","","",true, this);
 
            NewDiscountGroupCode = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("810695c8-e9b1-476d-b05d-f046b8c25a40","","",false, this);
 
            NewDiscountGroupDescription = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("d0db428c-b0b2-43ff-a497-d349ee9a71f4","","",false, this);
 
            NewDiscountDateFrom = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("1ecb0e0a-9dc8-467a-962b-e7600276548c","","",true, this);
 
            NewDiscountDateTo = RPSControlFactory.CreateRPSTextBox<DiscountProcessView>("68224095-84d5-4851-9318-f196b2a7eebf","","",true, this);
 

        }
        public IRPSOption<DiscountProcessView> NewDiscountGroup { get; set; } 
        public IRPSOption<DiscountProcessView> DiscountsInNewDates { get; set; } 
        public IRPSOption<DiscountProcessView> ExtendDates { get; set; } 
        public IRPSComboBox<DiscountProcessView> OriginDiscountGroupSL { get; set; } 
        public IRPSTextBox<DiscountProcessView> OriginDateFrom { get; set; } 
        public IRPSTextBox<DiscountProcessView> OriginDateTo { get; set; } 
        public IRPSCheckbox<DiscountProcessView> bArticles { get; set; } 
        public IRPSCollectionComboBox<DiscountProcessView> Articles { get; set; } 
        public IRPSCheckbox<DiscountProcessView> bProductLine { get; set; } 
        public IRPSCollectionComboBox<DiscountProcessView> ProductLines { get; set; } 
        public IRPSCheckbox<DiscountProcessView> bProductFamily { get; set; } 
        public IRPSCollectionComboBox<DiscountProcessView> ProductFamilies { get; set; } 
        public IRPSCheckbox<DiscountProcessView> bProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<DiscountProcessView> ProductSubFamilies { get; set; } 
        public IRPSCheckbox<DiscountProcessView> bAllArticles { get; set; } 
        public IRPSComboBox<DiscountProcessView> TargetDiscountGroupSL { get; set; } 
        public IRPSTextBox<DiscountProcessView> NewDiscountGroupCode { get; set; } 
        public IRPSTextBox<DiscountProcessView> NewDiscountGroupDescription { get; set; } 
        public IRPSTextBox<DiscountProcessView> NewDiscountDateFrom { get; set; } 
        public IRPSTextBox<DiscountProcessView> NewDiscountDateTo { get; set; } 
        public DiscountProcess Screen { get; set; }
        public DiscountProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
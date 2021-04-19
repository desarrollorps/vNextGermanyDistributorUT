    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerConditions
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerConditions:Screen
    {
        public CustomerConditions():base()
        {
            this.URL = "sales.customerconditions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerConditionsView  = new CustomerConditionsView(this); 
            CustomerConditionsView.InitializeControls(); 
           
        }
      
            public CustomerConditionsView CustomerConditionsView {get; set; } 
    }
            
    public partial class CustomerConditionsView : View
    {
        public CustomerConditionsView(CustomerConditions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("c5eee9b3-834a-427b-a224-9bc9b53dcfe4","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("07fb1a85-8b74-4250-9620-ffdcb7169ef5","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("8a550da1-a38d-47ec-8214-f79170be89c5","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("fa4da6ed-8b55-49e6-9bd8-eb1a1c8f3fa0","","",true, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<CustomerConditionsView>("f6ab4dca-2ceb-42ed-a4f7-dc4d8645d832","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("d887f240-5a9f-4834-8100-c08d1c2ff8ed","","",false, this);
 
            MeasureUnit = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("890da7f0-b250-40a7-8ed4-0fdcebae0616","","",true, this);
 
            ExecuteCustomerConditionsGetOrderData = RPSControlFactory.CreateRPSButton<CustomerConditionsView>( "ee9ff18d-f1eb-457f-beb6-3dbcf73e59f3","","",this);
 
            OrderPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("9f117e8c-f6e3-4c10-9de6-84ce294f4518","","",false, this);
 
            OrderPriceVAT = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("140041a9-ad7c-429b-853f-f744fdd8ff26","","",false, this);
 
            OrderUnitPrice = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("514374ea-c952-4d6e-b36e-ff0c2edfc4f4","","",false, this);
 
            OrderCascade1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("5e752f1d-93b5-4199-9cdc-e0e12ac9f295","","",false, this);
 
            OrderDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("d67aaede-e75f-4c38-ba2d-920538c420e1","","",false, this);
 
            OrderCascade2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("7f18d6c1-b0d0-4cc3-a3e3-462909285b25","","",false, this);
 
            OrderDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("eb552484-fbab-459d-b6d1-6f3dae136bc7","","",false, this);
 
            OrderCascade3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("827463a7-ce3e-4ce1-813d-774cd4000d9c","","",false, this);
 
            OrderDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("5795fcd4-1601-4a1e-a104-b8d37d21120c","","",false, this);
 
            OrderCascade4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("d147b89d-3dc7-4817-a34e-3259f2da73c5","","",false, this);
 
            OrderDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("7e7086d2-9093-4832-bc63-d0edb907e7f3","","",false, this);
 
            OrderCascade5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("a2314cd9-5aa5-4258-9789-57074e78f2d4","","",false, this);
 
            OrderDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("3df291f5-29da-4dbc-a039-110b58ec5d05","","",false, this);
 
            OrderAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("e0bfd40e-5fea-4886-b439-1b4c4ecdd23e","","",false, this);
 
            OrderPosition = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("8afb413e-2583-4c5f-a7cf-1f4f7e69cbe9","","",false, this);
 
            OrderAmount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("bd01afee-0527-4b27-9538-72542c2fd6ae","","",false, this);
 
            FWCPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("2225c9e0-f598-4a3b-9b58-5c944be9e137","","",false, this);
 
            FWCIDUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("94b3c61f-54de-4e0c-80cb-960610210940","","",false, this);
 
            FWCAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("8b98affd-ad4e-4cff-a3ae-349f57cbc74e","","",false, this);
 
            FWCPositionAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("de192b92-4511-40ee-a311-5830fa180412","","",false, this);
 
            FWCCascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("a246eeed-b4c4-4d39-b317-5cba3f547fde","","",false, this);
 
            FWCDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("95666d10-2cdf-4409-b3c3-38fd9a7319a3","","",false, this);
 
            FWCCascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("b27d2c10-2079-4ff0-a98d-1a0ebc3195bf","","",false, this);
 
            FWCDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("f8fe43aa-1816-4fc0-be0b-0b154eeaed9e","","",false, this);
 
            FWCCascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("11b4ca04-f20a-4cf2-ae60-c7f4c4d8b871","","",false, this);
 
            FWCDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("4d79ad01-4f08-457e-80a3-00f285cecce4","","",false, this);
 
            FWCCascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("351b2e53-28c8-4a8c-821a-8a6905d64943","","",false, this);
 
            FWCDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("62b25027-b01d-47e8-8fbf-ae2bfe4a5f8a","","",false, this);
 
            FWCCascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("e331b2e6-1630-450a-9148-7038a7bc6e44","","",false, this);
 
            FWCDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("69e05d55-fdc6-4173-a797-02fbced63212","","",false, this);
 
            PriceListSL = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("f32b8fa0-ff53-4c8e-8dbe-227cabe5af4a","","",false, this);
 
            PriceListPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("eb9ddd8c-a6e2-4cd1-8dfd-4b8b0e2129e2","","",false, this);
 
            PriceListUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("4f2115c8-4931-4ffe-a5d8-452ad3dc8851","","",false, this);
 
            PriceListDateFrom = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("e5c7b024-8b69-413f-afaf-eac57cc21c51","","",false, this);
 
            PriceListDateTo = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("5241a15b-3c5f-4fc9-9b8f-6d8d0a3c0c03","","",false, this);
 
            DiscountGroupSL = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("e68201ac-4409-480b-a9e6-d14dc851b7a2","","",false, this);
 
            DiscountDateFrom = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("d2e4d91c-4c79-499f-8a31-074ef4ab0065","","",false, this);
 
            DiscountDateTo = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("60e4912f-8ec7-45bb-a6d6-d7e528f8dc98","","",false, this);
 
            DiscountAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("4905b509-4fa9-469f-8d30-2422b3b4e9b4","","",false, this);
 
            DiscountPosition = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("d2142779-270a-4ac8-83d3-9e66a41853d9","","",false, this);
 
            DiscountCascade1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("02958c4d-0a39-4363-bd02-6409cb2125a5","","",false, this);
 
            DiscountDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("e5802a34-3f13-41db-9968-98b0fd8a79a5","","",false, this);
 
            DiscountCascade2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("390faba6-898c-4e45-8b66-7ff33f9022cf","","",false, this);
 
            DiscountDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("86653bac-24c5-4414-9ae0-def0aba20955","","",false, this);
 
            DiscountCascade3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("b0c6f09f-217f-4d98-9b81-0855296c198d","","",false, this);
 
            DiscountDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("4ade2ac2-d19e-41eb-a639-05b6eb13acfe","","",false, this);
 
            DiscountCascade4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("bd63ee63-899b-4af8-96b7-1c0117c532e1","","",false, this);
 
            DiscountDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("d61ddaa2-ed67-42fd-8ae5-c94acf14a97f","","",false, this);
 
            DiscountCascade5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("066055b8-7555-4b85-a802-959bf1dc7ff7","","",false, this);
 
            DiscountDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("b683f4f5-47d7-4e35-99c1-82117b4c3a6b","","",false, this);
 
            CustomerArticlePrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("34119fd5-8b9e-4d59-8c0e-b767d39c2ad0","","",false, this);
 
            CustomerArticleUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("27cefd68-ba99-48bc-877b-de3042528359","","",false, this);
 
            CustomerArticleDateFrom = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("260170c4-6635-40e7-b40c-097327ca63db","","",false, this);
 
            CustomerArticleDateTo = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("60d7d610-203b-433c-963c-54e3156da41c","","",false, this);
 
            CustomerArticleAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("fd6699a0-270f-4c8e-a279-8798fb23b636","","",false, this);
 
            CustomerArticlePosition = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("071f0fba-d993-4eb4-a8b0-835494f6796c","","",false, this);
 
            CustomerArticleCascade1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("d12a0f51-d65c-4740-b735-cf322f43b3cc","","",false, this);
 
            CustomerArticleDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("dc3f40b1-556b-4d94-a13f-471e602b3348","","",false, this);
 
            CustomerArticleCascade2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("871a821e-4f04-435a-9d82-ce1034bf31b2","","",false, this);
 
            CustomerArticleDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("c2a7a43a-4797-411b-8f1c-93a590957451","","",false, this);
 
            CustomerArticleCascade3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("0962055e-4c33-4b75-aaa2-c5b25e589720","","",false, this);
 
            CustomerArticleDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("c43d2caf-68da-4ba3-b209-36df090d631f","","",false, this);
 
            CustomerArticleCascade4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("5eede85d-bfa7-46b4-9c5d-74e51ce44a1f","","",false, this);
 
            CustomerArticleDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("516a37b3-0927-4292-97d3-ca79891df669","","",false, this);
 
            CustomerArticleCascade5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("d5f40f79-18b5-4cb6-9977-a05dc1ac0981","","",false, this);
 
            CustomerArticleDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("ec862e73-8e4e-4eb3-a008-e16a2f32a80e","","",false, this);
 
            CustomerArticleGroupPrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("2ebe74b8-5663-433c-91fd-fa8d11482923","","",false, this);
 
            CustomerArticleGroupUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("18c65145-c150-4f01-b416-d102512ad8a7","","",false, this);
 
            CustomerArticleGroupDateFrom = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("743fb508-c21f-4922-acb6-033fd44020fc","","",false, this);
 
            CustomerArticleGroupDateTo = RPSControlFactory.CreateRPSTextBox<CustomerConditionsView>("c765cc95-bd23-48a1-bebe-ec129f58bf5c","","",false, this);
 
            CustomerArticleGroupAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("315a76c9-d6e4-4019-add1-841165e399b5","","",false, this);
 
            CustomerArticleGroupPosition = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("b1f79d3b-b229-4e81-87ad-aef2afb8b231","","",false, this);
 
            CustomerArticleGroupCascade1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("ef9c6e64-0be1-4a54-abf6-7ef38074c27b","","",false, this);
 
            CustomerArticleGroupDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("8d707930-202e-489f-9510-deb82948a390","","",false, this);
 
            CustomerArticleGroupCascade2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("1616a6a7-8def-4d80-9d11-90a855010a24","","",false, this);
 
            CustomerArticleGroupDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("2d21afd5-db75-47ee-b9b4-4dd23c3bf69e","","",false, this);
 
            CustomerArticleGroupCascade3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("6dc40618-b3be-4044-b79c-f7c15ec55f32","","",false, this);
 
            CustomerArticleGroupDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("77d06148-d238-4409-b388-4877592adff9","","",false, this);
 
            CustomerArticleGroupCascade4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("36e40914-6669-4de0-95be-92170d499878","","",false, this);
 
            CustomerArticleGroupDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("6bda9334-c74a-4249-8210-f1bcc7f6441d","","",false, this);
 
            CustomerArticleGroupCascade5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("3f3354af-a3aa-4335-9e35-bd7481603ef5","","",false, this);
 
            CustomerArticleGroupDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("e74997e3-3edf-4e46-a459-34d8e272057c","","",false, this);
 
            SalesQuotePrice = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("a205e5b2-c1e5-4cba-91d3-2d37a1e06d41","","",false, this);
 
            SalesQuoteUnitPrice = RPSControlFactory.CreateRPSComboBox<CustomerConditionsView>("2a380103-6736-4b83-a8c9-22ea7dfd84c6","","",false, this);
 
            SalesQuoteAmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("49d48368-5260-41c1-8580-29f34b3b141b","","",false, this);
 
            SalesQuotePosition = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("9feda721-6e0d-4f43-a5f5-fac2fe6fb054","","",false, this);
 
            SalesQuoteDiscount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("68a372c7-6499-40dd-a844-82e80471ba62","","",false, this);
 
            SalesQuoteCascade1 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("5f615638-d540-42c1-b877-38ae2c2e2dd0","","",false, this);
 
            SalesQuoteDiscount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("f992ee81-26b2-4247-a77c-ffbc74aad508","","",false, this);
 
            SalesQuoteCascade2 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("f19257f8-09c6-4753-888c-c9fe9df98e5c","","",false, this);
 
            SalesQuoteDiscount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("a1045e9d-851c-4792-bd41-1b6b838cc292","","",false, this);
 
            SalesQuoteCascade3 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("e612c73f-bd9d-420f-8617-5f1dc837066f","","",false, this);
 
            SalesQuoteDiscount4 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("c62496a1-a83e-4317-9b6c-f8e73bfd11f9","","",false, this);
 
            SalesQuoteCascade4 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("cfbaca8b-e91f-416e-8b7d-9f94c1c1b570","","",false, this);
 
            SalesQuoteDiscount5 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerConditionsView>("6a5fc1df-6988-44b3-8dc3-466b37e219d1","","",false, this);
 
            SalesQuoteCascade5 = RPSControlFactory.CreateRPSCheckBox<CustomerConditionsView>("c63f7d44-243b-4746-8a3e-9f144f4d0441","","",false, this);
 
            CollectionInit params_CustomerConditionsLoadCommercialConditionsTab = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9b309536-f05f-4a99-92a0-f164c1a92e1c",CSSSelectorGrid="",XPathGrid=""};
            CustomerConditionsLoadCommercialConditionsTab = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerConditionsLoadCommercialConditionsTabCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CustomerConditionsLoadCommercialConditionsTab,this);
 
            CollectionInit params_CommercialConditionsTabCustomerCommercialConditions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ab7e1602-93d3-4f7e-8434-87e359c176ca",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionsTabCustomerCommercialConditions = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionsTabCustomerCommercialConditionsCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CommercialConditionsTabCustomerCommercialConditions,this);
 
            CollectionInit params_CommercialConditionsTabCustomerGroupCommercialConditions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49ca2522-74f8-41cf-bd12-c494d168678c",CSSSelectorGrid="",XPathGrid=""};
            CommercialConditionsTabCustomerGroupCommercialConditions = RPSControlFactory.RPSCreateCollectionWithGrid<CommercialConditionsTabCustomerGroupCommercialConditionsCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CommercialConditionsTabCustomerGroupCommercialConditions,this);
 
            CollectionInit params_CustomerConditionsGetPromotionsTabData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9f2bb92a-b37d-4e88-8bee-a63f6b5a0023",CSSSelectorGrid="",XPathGrid=""};
            CustomerConditionsGetPromotionsTabData = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerConditionsGetPromotionsTabDataCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CustomerConditionsGetPromotionsTabData,this);
 
            CollectionInit params_CustomerConditionsGetCustomerPromotionsTabData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="04cd942f-5ccb-4d56-8a7a-04a5f25c4e79",CSSSelectorGrid="",XPathGrid=""};
            CustomerConditionsGetCustomerPromotionsTabData = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerConditionsGetCustomerPromotionsTabDataCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CustomerConditionsGetCustomerPromotionsTabData,this);
 
            CollectionInit params_CustomerConditionsGetCustomerGroupPromotionsTabData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3325dff1-ef93-48bf-8d0d-ff894a143a1e",CSSSelectorGrid="",XPathGrid=""};
            CustomerConditionsGetCustomerGroupPromotionsTabData = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerConditionsGetCustomerGroupPromotionsTabDataCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CustomerConditionsGetCustomerGroupPromotionsTabData,this);
 
            CollectionInit params_CustomerConditionsGetMerchandiseGiftTabData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="66de0652-5c38-460b-a66c-44f6a3aa9e23",CSSSelectorGrid="",XPathGrid=""};
            CustomerConditionsGetMerchandiseGiftTabData = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerConditionsGetMerchandiseGiftTabDataCollectionEditor<CustomerConditionsView>,CustomerConditionsView>( params_CustomerConditionsGetMerchandiseGiftTabData,this);
 
            PricesTab = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='90d29dd1-8ef7-40ab-8092-67c9e70873cd']","",this);
 
            CommercialConditionsTab = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='2afbfbfd-f5ae-4ffd-9643-2d554101477e']","",this);
 
            Promotions = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='0cc39db5-4a96-46fe-88a1-76b44490cc35']","",this);
 
            CustomerPromotions = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='acabf7e8-736e-4de7-86c0-a2473e8b7596']","",this);
 
            CustomerGroupPromotions = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='bef5262d-de3b-4829-8929-0d8bbdd5fbca']","",this);
 
            MerchandiseGift = RPSControlFactory.CreateRPSSection<CustomerConditionsView>( "","ul li[rpsid='fdf08094-f90c-4497-a0e3-104da6a8c5f7']","",this);
 

        }
        public IRPSComboBox<CustomerConditionsView> Customer { get; set; } 
        public IRPSTextBox<CustomerConditionsView> Date { get; set; } 
        public IRPSComboBox<CustomerConditionsView> IDCurrency { get; set; } 
        public IRPSComboBox<CustomerConditionsView> Article { get; set; } 
        public IRPSComboBox<CustomerConditionsView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<CustomerConditionsView> Quantity { get; set; } 
        public IRPSComboBox<CustomerConditionsView> MeasureUnit { get; set; } 
        public IRPSButton<CustomerConditionsView> ExecuteCustomerConditionsGetOrderData { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderPriceVAT { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderUnitPrice { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> OrderCascade1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> OrderCascade2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> OrderCascade3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> OrderCascade4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> OrderCascade5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderDiscount5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderPosition { get; set; } 
        public IRPSTextBox<CustomerConditionsView> OrderAmount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCPrice { get; set; } 
        public IRPSComboBox<CustomerConditionsView> FWCIDUnitPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCPositionAmountDiscount { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> FWCCascadeDiscount1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> FWCCascadeDiscount2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> FWCCascadeDiscount3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> FWCCascadeDiscount4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> FWCCascadeDiscount5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> FWCDiscount5 { get; set; } 
        public IRPSComboBox<CustomerConditionsView> PriceListSL { get; set; } 
        public IRPSTextBox<CustomerConditionsView> PriceListPrice { get; set; } 
        public IRPSComboBox<CustomerConditionsView> PriceListUnitPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> PriceListDateFrom { get; set; } 
        public IRPSTextBox<CustomerConditionsView> PriceListDateTo { get; set; } 
        public IRPSComboBox<CustomerConditionsView> DiscountGroupSL { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDateFrom { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDateTo { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountPosition { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> DiscountCascade1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> DiscountCascade2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> DiscountCascade3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> DiscountCascade4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> DiscountCascade5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> DiscountDiscount5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticlePrice { get; set; } 
        public IRPSComboBox<CustomerConditionsView> CustomerArticleUnitPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDateFrom { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDateTo { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticlePosition { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleCascade1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleCascade2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleCascade3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleCascade4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleCascade5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleDiscount5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupPrice { get; set; } 
        public IRPSComboBox<CustomerConditionsView> CustomerArticleGroupUnitPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDateFrom { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDateTo { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupPosition { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleGroupCascade1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleGroupCascade2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleGroupCascade3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleGroupCascade4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> CustomerArticleGroupCascade5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> CustomerArticleGroupDiscount5 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuotePrice { get; set; } 
        public IRPSComboBox<CustomerConditionsView> SalesQuoteUnitPrice { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteAmountDiscount { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuotePosition { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteDiscount1 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> SalesQuoteCascade1 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteDiscount2 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> SalesQuoteCascade2 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteDiscount3 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> SalesQuoteCascade3 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteDiscount4 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> SalesQuoteCascade4 { get; set; } 
        public IRPSTextBox<CustomerConditionsView> SalesQuoteDiscount5 { get; set; } 
        public IRPSCheckbox<CustomerConditionsView> SalesQuoteCascade5 { get; set; } 
        public CustomerConditionsLoadCommercialConditionsTabCollectionEditor<CustomerConditionsView> CustomerConditionsLoadCommercialConditionsTab { get; set; } 
        public CommercialConditionsTabCustomerCommercialConditionsCollectionEditor<CustomerConditionsView> CommercialConditionsTabCustomerCommercialConditions { get; set; } 
        public CommercialConditionsTabCustomerGroupCommercialConditionsCollectionEditor<CustomerConditionsView> CommercialConditionsTabCustomerGroupCommercialConditions { get; set; } 
        public CustomerConditionsGetPromotionsTabDataCollectionEditor<CustomerConditionsView> CustomerConditionsGetPromotionsTabData { get; set; } 
        public CustomerConditionsGetCustomerPromotionsTabDataCollectionEditor<CustomerConditionsView> CustomerConditionsGetCustomerPromotionsTabData { get; set; } 
        public CustomerConditionsGetCustomerGroupPromotionsTabDataCollectionEditor<CustomerConditionsView> CustomerConditionsGetCustomerGroupPromotionsTabData { get; set; } 
        public CustomerConditionsGetMerchandiseGiftTabDataCollectionEditor<CustomerConditionsView> CustomerConditionsGetMerchandiseGiftTabData { get; set; } 
        public IRPSSection<CustomerConditionsView> PricesTab { get; set; } 
        public IRPSSection<CustomerConditionsView> CommercialConditionsTab { get; set; } 
        public IRPSSection<CustomerConditionsView> Promotions { get; set; } 
        public IRPSSection<CustomerConditionsView> CustomerPromotions { get; set; } 
        public IRPSSection<CustomerConditionsView> CustomerGroupPromotions { get; set; } 
        public IRPSSection<CustomerConditionsView> MerchandiseGift { get; set; } 
        public CustomerConditions Screen { get; set; }
        public CustomerConditionsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerConditionsLoadCommercialConditionsTabCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CustomerConditionsLoadCommercialConditionsTabGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CustomerConditionsLoadCommercialConditionsTabGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CustomerConditionsLoadCommercialConditionsTabGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",false, this.CurrentView);
 
            ItemType = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",false, this.CurrentView);
 
            CommercialConditionTypeSL = RPSControlFactory.CreateRPSGridComboBox<CustomerConditionsView>("","#9b309536-f05f-4a99-92a0-f164c1a92e1c .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionTypeSL']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ConditionValue { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ItemType { get; set; } 
        public IRPSGridComboBox<CustomerConditionsView> CommercialConditionTypeSL { get; set; } 
                     
    }
 
        public partial class CommercialConditionsTabCustomerCommercialConditionsCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CommercialConditionsTabCustomerCommercialConditionsGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CommercialConditionsTabCustomerCommercialConditionsGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CommercialConditionsTabCustomerCommercialConditionsGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",false, this.CurrentView);
 
            ItemType = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",false, this.CurrentView);
 
            CommercialConditionTypeSL = RPSControlFactory.CreateRPSGridComboBox<CustomerConditionsView>("","#ab7e1602-93d3-4f7e-8434-87e359c176ca .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionTypeSL']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ConditionValue { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ItemType { get; set; } 
        public IRPSGridComboBox<CustomerConditionsView> CommercialConditionTypeSL { get; set; } 
                     
    }
 
        public partial class CommercialConditionsTabCustomerGroupCommercialConditionsCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CommercialConditionsTabCustomerGroupCommercialConditionsGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CommercialConditionsTabCustomerGroupCommercialConditionsGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CommercialConditionsTabCustomerGroupCommercialConditionsGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",false, this.CurrentView);
 
            ItemType = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",false, this.CurrentView);
 
            CommercialConditionTypeSL = RPSControlFactory.CreateRPSGridComboBox<CustomerConditionsView>("","#49ca2522-74f8-41cf-bd12-c494d168678c .ag-row[role='row']@ROWINDEX [col-id='cCommercialConditionTypeSL']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ConditionValue { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> ItemType { get; set; } 
        public IRPSGridComboBox<CustomerConditionsView> CommercialConditionTypeSL { get; set; } 
                     
    }
 
        public partial class CustomerConditionsGetPromotionsTabDataCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CustomerConditionsGetPromotionsTabDataGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CustomerConditionsGetPromotionsTabDataGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CustomerConditionsGetPromotionsTabDataGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9f2bb92a-b37d-4e88-8bee-a63f6b5a0023 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9f2bb92a-b37d-4e88-8bee-a63f6b5a0023 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9f2bb92a-b37d-4e88-8bee-a63f6b5a0023 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#9f2bb92a-b37d-4e88-8bee-a63f6b5a0023 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> Order { get; set; } 
                     
    }
 
        public partial class CustomerConditionsGetCustomerPromotionsTabDataCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CustomerConditionsGetCustomerPromotionsTabDataGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CustomerConditionsGetCustomerPromotionsTabDataGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CustomerConditionsGetCustomerPromotionsTabDataGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#04cd942f-5ccb-4d56-8a7a-04a5f25c4e79 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#04cd942f-5ccb-4d56-8a7a-04a5f25c4e79 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#04cd942f-5ccb-4d56-8a7a-04a5f25c4e79 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#04cd942f-5ccb-4d56-8a7a-04a5f25c4e79 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> Order { get; set; } 
                     
    }
 
        public partial class CustomerConditionsGetCustomerGroupPromotionsTabDataCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CustomerConditionsGetCustomerGroupPromotionsTabDataGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CustomerConditionsGetCustomerGroupPromotionsTabDataGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CustomerConditionsGetCustomerGroupPromotionsTabDataGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#3325dff1-ef93-48bf-8d0d-ff894a143a1e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#3325dff1-ef93-48bf-8d0d-ff894a143a1e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#3325dff1-ef93-48bf-8d0d-ff894a143a1e .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#3325dff1-ef93-48bf-8d0d-ff894a143a1e .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> Description { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateFrom { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> DateTo { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> Order { get; set; } 
                     
    }
 
        public partial class CustomerConditionsGetMerchandiseGiftTabDataCollectionEditor<CustomerConditionsView>:RPSCollectionEditor<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public  CustomerConditionsGetMerchandiseGiftTabDataGridView<CustomerConditionsView> GridView {get;set;}
    }
    public partial class CustomerConditionsGetMerchandiseGiftTabDataGridView <CustomerConditionsView> :  RPSGridView<CustomerConditionsView> where CustomerConditionsView : class, IView
    {
        public CustomerConditionsGetMerchandiseGiftTabDataGridView(CustomerConditionsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMerchandiseGift = RPSControlFactory.CreateRPSGridTextBox<CustomerConditionsView>("","#66de0652-5c38-460b-a66c-44f6a3aa9e23 .ag-row[role='row']@ROWINDEX [col-id='cCodMerchandiseGift']","",false, this.CurrentView);
 
            TotalQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#66de0652-5c38-460b-a66c-44f6a3aa9e23 .ag-row[role='row']@ROWINDEX [col-id='cTotalQuantity']","",false, this.CurrentView);
 
            GiftQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerConditionsView>("","#66de0652-5c38-460b-a66c-44f6a3aa9e23 .ag-row[role='row']@ROWINDEX [col-id='cGiftQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerConditionsView> CodMerchandiseGift { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> TotalQuantity { get; set; } 
        public IRPSGridTextBox<CustomerConditionsView> GiftQuantity { get; set; } 
                     
    }
 
    }
  
    

}
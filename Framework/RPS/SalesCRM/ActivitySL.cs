    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.ActivitySL
{
    //RPS VERSION 1.0.0.0
    public partial class ActivitySL:Screen
    {
        public ActivitySL():base()
        {
            this.URL = "salescrm.activitysl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ActivitySLQueryView  = new ActivitySLQueryView(this); 
            ActivitySLEntityView  = new ActivitySLEntityView(this); 
            ChangeCustomerChildDialogView  = new ChangeCustomerChildDialogView(this); 
            ActivitySLQueryView.InitializeControls(); 
            ActivitySLEntityView.InitializeControls(); 
            ChangeCustomerChildDialogView.InitializeControls(); 
           
        }
      
            public ActivitySLQueryView ActivitySLQueryView {get; set; } 
            public ActivitySLEntityView ActivitySLEntityView {get; set; } 
            public ChangeCustomerChildDialogView ChangeCustomerChildDialogView {get; set; } 
    }
            
    public partial class ActivitySLQueryView : View
    {
        public ActivitySLQueryView(ActivitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ActivitySLQueryView,ActivitySLEntityView>( this,Screen.ActivitySLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e12d4a77-2845-4996-b326-e5f1a91daaf1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ActivitySLQueryView,ActivitySLEntityView>( params_MainConsult,this,Screen.ActivitySLEntityView);
 

        }
        public IRPSButton<ActivitySLQueryView,ActivitySLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ActivitySLQueryView,ActivitySLEntityView> MainConsult { get; set; } 
        public ActivitySL Screen { get; set; }
        public ActivitySLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ActivitySLEntityView : View
    {
        public ActivitySLEntityView(ActivitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ActivitySLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ActivitySLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ActivitySLEntityView,ActivitySLQueryView>( this,Screen.ActivitySLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ActivitySLEntityView,ActivitySLQueryView>( this,Screen.ActivitySLQueryView);
 
            CodActivity = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("93883d22-e752-47c7-9ca9-0330dbf8b8db","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("faf316cb-3305-4be9-ab49-406a1a77d8dc","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ActivitySLEntityView>("cd38b39a-81fb-4494-94c8-294d666d0e42","","",true, this);
 
            IDActivityType = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("49578a77-9973-442a-b75c-7b2ae18281c7","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("3d1e8afe-6cc2-4955-bf37-987227413d7d","","",false, this);
 
            IDSalesQuote = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("05a524b3-6338-4a59-926f-9f0669454994","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<ActivitySLEntityView>( "f1128a72-daca-47ab-ac5a-a64d20077d14","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<ActivitySLEntityView>( "eeb6243d-ed19-41bb-9a42-aa6b3d216fb9","","",this);
 
            Address = RPSControlFactory.CreateRPSOption<ActivitySLEntityView>( "09932734-b0cb-41f9-9139-222cb5a3da6a","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("304c8d60-cbcc-4834-a5df-98480b02137e","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("9b44e6aa-d6e1-4a0d-8e5c-ca09c6dfa7b2","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("abf519b6-50f5-40d5-a5ff-f58da6382280","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("dd7704bd-ba62-40bd-b32b-64e1f03ec61a","","",false, this);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("bbe4a458-d78c-4158-b0e7-4835462cbab7","","",false, this);
 
            IDAddress = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("ca8ee110-6c89-4315-854a-2fc9d341a533","","",false, this);
 
            IDAddressContact = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("1735fc62-d5fb-49f0-a539-3c414cdade07","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ActivitySLEntityView>("c43530d4-d476-4311-85ec-4caa1730dd2d","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ActivitySLEntityView>("186e8d44-ab2e-4ee0-99d8-bf710d77c893","","",true, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<ActivitySLEntityView>("83a0a4a9-8c92-4bc3-9951-7311588c34e1","","",true, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("cfbe364c-eb2b-42d8-98df-570c502776cc","","",true, this);
 
            CreationTime = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("e28b648f-bcb0-4fa1-8ddd-9f5fc5f8b365","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<ActivitySLEntityView>("9a8137fa-eefe-4696-ab8e-cda8a60bb5d4","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("e69c7a0d-ce2f-44bb-83a8-6275d6b91731","","",true, this);
 
            DueTime = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("384cf6aa-83ba-48d8-b042-dc91e2a2d886","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("58d71979-47ea-4805-a986-5b3660e37eb5","","",false, this);
 
            EndTime = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("f61c698d-fba8-4602-98d3-f767168378cc","","",false, this);
 
            RealTime = RPSControlFactory.CreateRPSFormattedTextBox<ActivitySLEntityView>("73b74851-7735-499b-b678-e52290babbfe","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ActivitySLEntityView>("dddadace-03d3-45c3-a71b-189c3ae00439","","",false, this);
 
            ChangeCustomerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ActivitySLEntityView,ChangeCustomerChildDialogView>("4d2e7ca6-dc24-4608-a4f8-cbfbcf1c3142","","", this,Screen.ChangeCustomerChildDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ActivitySLEntityView>( "","ul li[rpsid='db941421-240a-4f96-802c-5509527cdfa8']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<ActivitySLEntityView>( "","ul li[rpsid='64980a6b-e02c-4dbd-83a9-a893545f4e6f']","",this);
 

        }
        public IRPSSaveButton<ActivitySLEntityView> SaveButton { get; set; } 
        public IRPSButton<ActivitySLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ActivitySLEntityView,ActivitySLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ActivitySLEntityView,ActivitySLQueryView> BackButton { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> CodActivity { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> Description { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> Status { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDActivityType { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDOportunity { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDSalesQuote { get; set; } 
        public IRPSOption<ActivitySLEntityView> Customer { get; set; } 
        public IRPSOption<ActivitySLEntityView> PotentialCustomer { get; set; } 
        public IRPSOption<ActivitySLEntityView> Address { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDPotentialCustomerContact { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDAddress { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> IDAddressContact { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> CodUser { get; set; } 
        public IRPSComboBox<ActivitySLEntityView> Priority { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> Progress { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> CreationDate { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> CreationTime { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> ExecutionTime { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> DueDate { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> DueTime { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> EndDate { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> EndTime { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> RealTime { get; set; } 
        public IRPSTextBox<ActivitySLEntityView> Comment { get; set; } 
        public IRPSButton<ActivitySLEntityView,ChangeCustomerChildDialogView> ChangeCustomerChildNavigationCommandButton { get; set; } 
        public IRPSSection<ActivitySLEntityView> GeneralData { get; set; } 
        public IRPSSection<ActivitySLEntityView> CommentSection { get; set; } 
        public ActivitySL Screen { get; set; }
        public ActivitySLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeCustomerChildDialogView : View
    {
        public ChangeCustomerChildDialogView(ActivitySL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("e7d6a825-7138-4793-bc58-29b65558ea27","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("775ee46b-f848-43b0-a92e-4b701e7bcd2b","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("ff6f357e-64c6-4938-908a-ec54a99c580d","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("e5cc4eb1-1ff7-4675-8347-5e8cc2dac266","","",false, this);
 
            NewCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("bbd276fd-1bfe-47c2-875b-522e2941df86","","",false, this);
 
            NewPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("87132c9f-b0f4-4b44-8c18-c40a7d36d9f2","","",false, this);
 
            NewCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("3f8bfd50-302a-4631-971a-dd9d8008a363","","",false, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("26bd19f7-8521-4f0c-b837-933f7853e7f5","","",false, this);
 
            NewPotentialVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("73dc037c-0cdd-4afe-b72f-84cc0d39d35e","","",false, this);
 

        }
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDPotentialCustomer { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewPotentialCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewCustomerMiscellaneous { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewVATNumber { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewPotentialVATNumber { get; set; } 
        public ActivitySL Screen { get; set; }
        public ChangeCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Companies
{
    //RPS VERSION 1.0.0.0
    public partial class Companies:Screen
    {
        public Companies():base()
        {
            this.URL = "general.companies";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CompanyCollectionView  = new CompanyCollectionView(this); 
            CompanyEntityView  = new CompanyEntityView(this); 
            CompanyTestEmailDialogView  = new CompanyTestEmailDialogView(this); 
            CompanyCollectionView.InitializeControls(); 
            CompanyEntityView.InitializeControls(); 
            CompanyTestEmailDialogView.InitializeControls(); 
           
        }
      
            public CompanyCollectionView CompanyCollectionView {get; set; } 
            public CompanyEntityView CompanyEntityView {get; set; } 
            public CompanyTestEmailDialogView CompanyTestEmailDialogView {get; set; } 
    }
            
    public partial class CompanyCollectionView : View
    {
        public CompanyCollectionView(Companies screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CompanyCollectionView,CompanyEntityView>( this,Screen.CompanyEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9cefedd0-59ca-4ea6-b2f4-b8164e493478",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CompanyCollectionView,CompanyEntityView>( params_MainConsult,this,Screen.CompanyEntityView);
 

        }
        public IRPSButton<CompanyCollectionView,CompanyEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CompanyCollectionView,CompanyEntityView> MainConsult { get; set; } 
        public Companies Screen { get; set; }
        public CompanyCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CompanyEntityView : View
    {
        public CompanyEntityView(Companies screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CompanyEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CompanyEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CompanyEntityView,CompanyCollectionView>( this,Screen.CompanyCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CompanyEntityView,CompanyCollectionView>( this,Screen.CompanyCollectionView);
 
            CodCompany = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("669f0f56-270f-4abc-8925-8b1927fef7c0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("8bce33dc-d002-4af2-8486-a7e7647b4171","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("4d48fc0d-7662-4e0b-81c4-01f54882832d","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("3e98b5a2-448f-4fc3-918b-37b663fe4c2c","","",false, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<CompanyEntityView>( "409a752b-f6a5-4431-8e79-82e822f24edd","","",this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("ce4ad62f-4880-4f5a-b483-bb8868fa8d17","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("be201097-a76d-4a5e-89b3-d505c84e7c6b","","",false, this);
 
            EmailContact = RPSControlFactory.CreateRPSEmailTextBox<CompanyEntityView>("7586a4b5-93a5-4521-b6f8-10f12701c9c0","","",false, this);
 
            TypeCompany = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("1ae487ef-3aa3-4a44-9765-f0ba55fc2b19","","",true, this);
 
            CodParentCompany = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("43e1ca5d-da28-483c-9bdf-66765f03fe89","","",false, this);
 
            Consolidation = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("956ff9b8-8a0e-4dd3-ac9f-1bd473875e25","","",true, this);
 
            LegalRepresentative = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("39862b0a-d5a7-43ad-b87b-4c2578ab9142","","",false, this);
 
            VATNumberLR = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("b91d3ea1-4d2e-4349-85e1-ad0225afa3ca","","",false, this);
 
            ThirdTypeLR = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("4c0bd88a-59ca-438b-ab2d-a26ca7d9016f","","",true, this);
 
            DocumentStorage = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("8b510870-14ec-46a3-801c-f71579df5bf8","","",true, this);
 
            DocumentFolder = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("5f3a2a85-2d7d-4651-b068-e44ebed2e73f","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("c97be899-a8a3-4c67-829e-e92174ec6a18","","",false, this);
 
            IDMeasureUnit = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("0e231c2f-57c4-4c22-a21b-7f65f403d3ad","","",false, this);
 
            IDHourTypeDefault = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("ba2940c4-8ab1-4633-a03c-fef97508fac1","","",false, this);
 
            IDCalendarDefault = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("52a47f6f-ff70-4fc9-bae0-eb3e46e8c630","","",false, this);
 
            CalPriorityHierarchyComplete = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("176c0b8a-e5dd-4975-a0ba-8adee9e2175c","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("8c3cd9e8-9aed-4079-bc09-708d4f041bac","","",false, this);
 
            IDCodingSerieActivity = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("e1507698-f093-4653-b0e9-f4179c4a9244","","",false, this);
 
            DecimalPrice = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("14dd0574-afaa-475e-bbf1-b94c617fcc8e","","",true, this);
 
            DecimalAmount = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("83148d46-cb13-43dd-9f03-28aa1020331c","","",true, this);
 
            MinutesHour = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("6f4c6ca4-df0a-4967-b8b9-dfb864993704","","",true, this);
 
            HoursDay = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("7140d6cb-e019-41f9-9385-d95a0c3a97e5","","",true, this);
 
            DaysWeek = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("ee3794da-1d70-43dd-9766-28e453c09c54","","",true, this);
 
            DaysMonth = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("9d74123a-e6e3-43f8-b02f-cb5fe0c29537","","",true, this);
 
            DueDayTags = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("9681196c-eda5-41a9-a7e8-b8bd4ee6f432","","",true, this);
 
            ResourcesBySite = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("5a4272f8-e3eb-4577-a01b-b0fc92b72e61","","",true, this);
 
            InvoicingPoints = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("77501f31-9427-419c-b7d6-4b11b6245191","","",true, this);
 
            CheckDuplicateCustomer = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("76be12b0-fe94-49c3-8ed4-28093507db6e","","",true, this);
 
            CheckDuplicateSupplier = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("bbba5036-e10e-4341-a128-59e3a15a46cf","","",true, this);
 
            CheckThirdVies = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("dd1666ab-0173-440c-9277-a92ea921961c","","",true, this);
 
            RichText = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("b3534689-ed5c-4c32-8509-f1fc45e78a84","","",true, this);
 
            FontFamily = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("a0d6f2f8-e6fc-46c1-8549-afd8fee4a99d","","",false, this);
 
            FontSize = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("59032942-2e7f-460e-a62f-e906360c47d1","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("81873f92-5428-41aa-8699-6b5c9a4a1baa","","",true, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("98417e93-6050-491c-96b4-5c746a5bf5fb","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("4bde96ed-539b-47b9-8a6c-b43ddf369db9","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CompanyEntityView>("19c4f7dc-9d24-4b7e-80fd-1573c45e1917","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("e6fd5f3c-6e7c-440e-949a-584afa1091c5","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("c1d7ffaf-4943-4d88-ab44-8921f4675851","","",false, this);
 
            MailServerType = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("0a2b91c1-70f6-4281-ae80-fde28c58b6c6","","",true, this);
 
            MailServer = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("9b669c82-fe17-45f5-9f00-da6769182a17","","",false, this);
 
            MailServerPort = RPSControlFactory.CreateRPSFormattedTextBox<CompanyEntityView>("d711f916-a26e-475b-90bc-9b5ac844fb51","","",false, this);
 
            MailSenderAddress = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("26ce2e0e-c76f-4a20-8a04-b4dd08a02955","","",false, this);
 
            VersionExchange = RPSControlFactory.CreateRPSEnumComboBox<CompanyEntityView>("f8222d3e-1bbe-47de-9176-2cb2413634ff","","",false, this);
 
            MailServerWS = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("80e06b36-1c9f-406a-8cca-a3c797d9dd5f","","",false, this);
 
            SMTPEnableSSL = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("f6b6647a-4caf-4ca4-bbc9-d7b062bbe51d","","",false, this);
 
            SMTPAnonymous = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("d90e9a7b-0036-40be-8983-b63a838f89e8","","",true, this);
 
            SMTPUser = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("c7c6f198-3bd3-42fc-831f-83c05ba1e71f","","",false, this);
 
            SMTPPassword = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("cac6e01e-259c-4f5d-ab55-82c4f7044473","","",false, this);
 
            PDMVault = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("13440c3e-8ae3-44ca-95a0-28c060f0565b","","",false, this);
 
            CegaiaUser = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("8be6e063-3799-40a1-8b59-8e65747417d2","","",false, this);
 
            CegaiaPassword = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("163676ca-0358-450d-bac5-25a00c8bc277","","",false, this);
 
            CertificatePath = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("b273e914-a6bb-4a48-a434-2bf92f0f26be","","",false, this);
 
            SolRUrl = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("9fd16787-8b53-4fa9-8688-224becbd348e","","",false, this);
 
            SolRInstallationPath = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("a7f89eaa-7249-4412-a7ad-4e5bcbe63c1e","","",false, this);
 
            KeyMap = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("213076d2-03d0-4e72-98f8-3e6db5be3ace","","",false, this);
 
            AutoQ = RPSControlFactory.CreateRPSCheckBox<CompanyEntityView>("e2493ead-e810-4b96-be62-a64957bba4c4","","",true, this);
 
            PathCheckinCheckout = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("164aef7b-7081-4096-83c7-45f2a3bbb2fa","","",false, this);
 
            CodCompanyHR = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("b067115c-9645-4269-9195-e116c1606be7","","",false, this);
 
            SeparatorChar = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("b25b331f-8350-44c9-9ee5-9bec0c7c6af6","","",false, this);
 
            PathResourceStops = RPSControlFactory.CreateRPSTextBox<CompanyEntityView>("e261b8e2-58e9-4396-8200-5d1f82418083","","",false, this);
 
            TestCommandExecuteCuDistExportCheckInCheckOutAction = RPSControlFactory.CreateRPSButton<CompanyEntityView>( "57a10ac7-4108-4ed6-a25f-66f4e06f4318","","",this);
 
            CompanyTestEmailNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CompanyEntityView,CompanyTestEmailDialogView>("563d59fe-e890-4baa-985b-a9cd966c5dfc","","", this,Screen.CompanyTestEmailDialogView);
 
            Section = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='9e2c5280-2dfa-426d-be30-4771be47f579']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='7a4dfbcc-21ec-455d-b1a1-231e9b48a993']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='4690a281-5275-4176-9a8e-355f7883fe55']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='b8c27fd6-44f9-40c8-9de6-fe5e01f8cdb4']","",this);
 
            Section4 = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='22b72b23-8f46-4503-8504-a10d4182716e']","",this);
 
            SectionDPS = RPSControlFactory.CreateRPSSection<CompanyEntityView>( "","ul li[rpsid='5eb274c5-2d33-482a-b7d1-7b98d232f6dc']","",this);
 

        }
        public IRPSSaveButton<CompanyEntityView> SaveButton { get; set; } 
        public IRPSButton<CompanyEntityView> DeleteButton { get; set; } 
        public IRPSButton<CompanyEntityView,CompanyCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CompanyEntityView,CompanyCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CompanyEntityView> CodCompany { get; set; } 
        public IRPSTextBox<CompanyEntityView> Description { get; set; } 
        public IRPSTextBox<CompanyEntityView> CompanyName { get; set; } 
        public IRPSTextBox<CompanyEntityView> VATNumber { get; set; } 
        public IRPSColorEditor<CompanyEntityView> Color { get; set; } 
        public IRPSTextBox<CompanyEntityView> Phone { get; set; } 
        public IRPSTextBox<CompanyEntityView> ContactPerson { get; set; } 
        public IRPSTextBox<CompanyEntityView> EmailContact { get; set; } 
        public IRPSComboBox<CompanyEntityView> TypeCompany { get; set; } 
        public IRPSComboBox<CompanyEntityView> CodParentCompany { get; set; } 
        public IRPSCheckbox<CompanyEntityView> Consolidation { get; set; } 
        public IRPSTextBox<CompanyEntityView> LegalRepresentative { get; set; } 
        public IRPSTextBox<CompanyEntityView> VATNumberLR { get; set; } 
        public IRPSComboBox<CompanyEntityView> ThirdTypeLR { get; set; } 
        public IRPSComboBox<CompanyEntityView> DocumentStorage { get; set; } 
        public IRPSTextBox<CompanyEntityView> DocumentFolder { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDMeasureUnit { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDHourTypeDefault { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDCalendarDefault { get; set; } 
        public IRPSCheckbox<CompanyEntityView> CalPriorityHierarchyComplete { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDSite { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDCodingSerieActivity { get; set; } 
        public IRPSTextBox<CompanyEntityView> DecimalPrice { get; set; } 
        public IRPSTextBox<CompanyEntityView> DecimalAmount { get; set; } 
        public IRPSTextBox<CompanyEntityView> MinutesHour { get; set; } 
        public IRPSTextBox<CompanyEntityView> HoursDay { get; set; } 
        public IRPSTextBox<CompanyEntityView> DaysWeek { get; set; } 
        public IRPSTextBox<CompanyEntityView> DaysMonth { get; set; } 
        public IRPSTextBox<CompanyEntityView> DueDayTags { get; set; } 
        public IRPSCheckbox<CompanyEntityView> ResourcesBySite { get; set; } 
        public IRPSCheckbox<CompanyEntityView> InvoicingPoints { get; set; } 
        public IRPSCheckbox<CompanyEntityView> CheckDuplicateCustomer { get; set; } 
        public IRPSCheckbox<CompanyEntityView> CheckDuplicateSupplier { get; set; } 
        public IRPSCheckbox<CompanyEntityView> CheckThirdVies { get; set; } 
        public IRPSCheckbox<CompanyEntityView> RichText { get; set; } 
        public IRPSTextBox<CompanyEntityView> FontFamily { get; set; } 
        public IRPSTextBox<CompanyEntityView> FontSize { get; set; } 
        public IRPSComboBox<CompanyEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CompanyEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDState { get; set; } 
        public IRPSComboBox<CompanyEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CompanyEntityView> Address { get; set; } 
        public IRPSTextBox<CompanyEntityView> City { get; set; } 
        public IRPSComboBox<CompanyEntityView> MailServerType { get; set; } 
        public IRPSTextBox<CompanyEntityView> MailServer { get; set; } 
        public IRPSTextBox<CompanyEntityView> MailServerPort { get; set; } 
        public IRPSTextBox<CompanyEntityView> MailSenderAddress { get; set; } 
        public IRPSComboBox<CompanyEntityView> VersionExchange { get; set; } 
        public IRPSTextBox<CompanyEntityView> MailServerWS { get; set; } 
        public IRPSCheckbox<CompanyEntityView> SMTPEnableSSL { get; set; } 
        public IRPSCheckbox<CompanyEntityView> SMTPAnonymous { get; set; } 
        public IRPSTextBox<CompanyEntityView> SMTPUser { get; set; } 
        public IRPSTextBox<CompanyEntityView> SMTPPassword { get; set; } 
        public IRPSTextBox<CompanyEntityView> PDMVault { get; set; } 
        public IRPSTextBox<CompanyEntityView> CegaiaUser { get; set; } 
        public IRPSTextBox<CompanyEntityView> CegaiaPassword { get; set; } 
        public IRPSTextBox<CompanyEntityView> CertificatePath { get; set; } 
        public IRPSTextBox<CompanyEntityView> SolRUrl { get; set; } 
        public IRPSTextBox<CompanyEntityView> SolRInstallationPath { get; set; } 
        public IRPSTextBox<CompanyEntityView> KeyMap { get; set; } 
        public IRPSCheckbox<CompanyEntityView> AutoQ { get; set; } 
        public IRPSTextBox<CompanyEntityView> PathCheckinCheckout { get; set; } 
        public IRPSTextBox<CompanyEntityView> CodCompanyHR { get; set; } 
        public IRPSTextBox<CompanyEntityView> SeparatorChar { get; set; } 
        public IRPSTextBox<CompanyEntityView> PathResourceStops { get; set; } 
        public IRPSButton<CompanyEntityView> TestCommandExecuteCuDistExportCheckInCheckOutAction { get; set; } 
        public IRPSButton<CompanyEntityView,CompanyTestEmailDialogView> CompanyTestEmailNavigationCommandButton { get; set; } 
        public IRPSSection<CompanyEntityView> Section { get; set; } 
        public IRPSSection<CompanyEntityView> Section1 { get; set; } 
        public IRPSSection<CompanyEntityView> Section2 { get; set; } 
        public IRPSSection<CompanyEntityView> Section3 { get; set; } 
        public IRPSSection<CompanyEntityView> Section4 { get; set; } 
        public IRPSSection<CompanyEntityView> SectionDPS { get; set; } 
        public Companies Screen { get; set; }
        public CompanyEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CompanyTestEmailDialogView : View
    {
        public CompanyTestEmailDialogView(Companies screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIMailTo = RPSControlFactory.CreateRPSTextBox<CompanyTestEmailDialogView>("d82ac322-486d-422a-8e0c-77f7b986d13b","","",false, this);
 

        }
        public IRPSTextBox<CompanyTestEmailDialogView> UIMailTo { get; set; } 
        public Companies Screen { get; set; }
        public CompanyTestEmailDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CustomEntityView
{
    //RPS VERSION 1.0.0.0
    public partial class CustomEntityView:Screen
    {
        public CustomEntityView():base()
        {
            this.URL = "general.customentityview";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomEntityViewCollectionView  = new CustomEntityViewCollectionView(this); 
            CustomEntityViewEntityView  = new CustomEntityViewEntityView(this); 
            CreateNewQueryDialogView  = new CreateNewQueryDialogView(this); 
            AddJoinedEntityDialogView  = new AddJoinedEntityDialogView(this); 
            AddFilterDialogView  = new AddFilterDialogView(this); 
            QueryPreviewView  = new QueryPreviewView(this); 
            CopyCustomEntityViewDialogView  = new CopyCustomEntityViewDialogView(this); 
            CustomEntityViewCollectionView.InitializeControls(); 
            CustomEntityViewEntityView.InitializeControls(); 
            CreateNewQueryDialogView.InitializeControls(); 
            AddJoinedEntityDialogView.InitializeControls(); 
            AddFilterDialogView.InitializeControls(); 
            QueryPreviewView.InitializeControls(); 
            CopyCustomEntityViewDialogView.InitializeControls(); 
           
        }
      
            public CustomEntityViewCollectionView CustomEntityViewCollectionView {get; set; } 
            public CustomEntityViewEntityView CustomEntityViewEntityView {get; set; } 
            public CreateNewQueryDialogView CreateNewQueryDialogView {get; set; } 
            public AddJoinedEntityDialogView AddJoinedEntityDialogView {get; set; } 
            public AddFilterDialogView AddFilterDialogView {get; set; } 
            public QueryPreviewView QueryPreviewView {get; set; } 
            public CopyCustomEntityViewDialogView CopyCustomEntityViewDialogView {get; set; } 
    }
            
    public partial class CustomEntityViewCollectionView : View
    {
        public CustomEntityViewCollectionView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomEntityViewCollectionView,CustomEntityViewEntityView>( this,Screen.CustomEntityViewEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "8ee04f1e-4bf8-4851-ba25-0db07a045566",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomEntityViewCollectionView,CustomEntityViewEntityView>( params_MainConsult,this,Screen.CustomEntityViewEntityView);
 

        }
        public IRPSButton<CustomEntityViewCollectionView,CustomEntityViewEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomEntityViewCollectionView,CustomEntityViewEntityView> MainConsult { get; set; } 
        public CustomEntityView Screen { get; set; }
        public CustomEntityViewCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomEntityViewEntityView : View
    {
        public CustomEntityViewEntityView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomEntityViewEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomEntityViewEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomEntityViewEntityView,CustomEntityViewCollectionView>( this,Screen.CustomEntityViewCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomEntityViewEntityView,CustomEntityViewCollectionView>( this,Screen.CustomEntityViewCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomEntityViewEntityView>("ea9c37fe-657a-41d1-8f6b-f2071ffc3ba7","","",false, this);
 
            ServiceName = RPSControlFactory.CreateRPSTextBox<CustomEntityViewEntityView>("1e28be56-6336-48b0-8e9c-bacfd019f162","","",false, this);
 
            EntityName = RPSControlFactory.CreateRPSTextBox<CustomEntityViewEntityView>("9f9a5907-c13c-4f64-a457-22f751c52703","","",false, this);
 
            AllCompanies = RPSControlFactory.CreateRPSCheckBox<CustomEntityViewEntityView>("b07fd11c-f771-46cf-a2bf-e8cb3a461794","","",true, this);
 
            AllUsers = RPSControlFactory.CreateRPSOption<CustomEntityViewEntityView>( "13aa6eaf-9c33-45c0-903f-b681885003c7","","",this);
 
            SelectedUsers = RPSControlFactory.CreateRPSOption<CustomEntityViewEntityView>( "413e5878-e99b-441c-8f60-6f82a1982149","","",this);
 
            OnlyForMe = RPSControlFactory.CreateRPSOption<CustomEntityViewEntityView>( "87f87e9a-dde4-403f-bee3-4ef0d89360da","","",this);
 
            CodUser = RPSControlFactory.CreateRPSTextBox<CustomEntityViewEntityView>("f298e32d-d36e-4d5c-bb2f-58c8df81d955","","",false, this);
 
            ExecuteUndoActionButton = RPSControlFactory.CreateRPSButton<CustomEntityViewEntityView>( "02039669-bdf0-407a-b601-cb93e143c96c","","",this);
 
            ExecuteRedoActionButton = RPSControlFactory.CreateRPSButton<CustomEntityViewEntityView>( "7f4ddc3f-bbbe-4845-bcb7-2d6f09cb92ad","","",this);
 
            QueryPreviewNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomEntityViewEntityView,QueryPreviewView>("c2378729-53d8-4896-8831-25b2cfe315d4","","", this,Screen.QueryPreviewView);
 
            ExecuteActivateCustomQueryButton = RPSControlFactory.CreateRPSButton<CustomEntityViewEntityView>( "5dd89dcd-2dee-4287-90f2-aeef760e6641","","",this);
 
            ExecuteDeactivateCustomQueryButton = RPSControlFactory.CreateRPSButton<CustomEntityViewEntityView>( "49ddea1f-e209-4640-8f0e-6cbe7b42cb27","","",this);
 
            CopyCustomEntityViewNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomEntityViewEntityView,CopyCustomEntityViewDialogView>("3552fece-ba46-48cc-81b9-161f1f1ff72a","","", this,Screen.CopyCustomEntityViewDialogView);
 
            CollectionInit params_Company = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="24746f4b-8b6a-450d-aa7d-7b7497eef6a1",CSSSelectorGrid="",XPathGrid=""};
            Company = RPSControlFactory.RPSCreateCollectionWithGrid<CompanyCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>,CustomEntityViewEntityView,CreateNewQueryDialogView>( params_Company,this,Screen.CreateNewQueryDialogView);
 
            CollectionInit params_Role = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="786bfa44-b5dd-462c-8dbf-30edb7e23de8",CSSSelectorGrid="",XPathGrid=""};
            Role = RPSControlFactory.RPSCreateCollectionWithGrid<RoleCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>,CustomEntityViewEntityView,CreateNewQueryDialogView>( params_Role,this,Screen.CreateNewQueryDialogView);
 
            CollectionInit params_User = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="767b9ab6-d906-4de2-834f-b2482cd809cc",CSSSelectorGrid="",XPathGrid=""};
            User = RPSControlFactory.RPSCreateCollectionWithGrid<UserCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>,CustomEntityViewEntityView,CreateNewQueryDialogView>( params_User,this,Screen.CreateNewQueryDialogView);
 
            QueryDesign = RPSControlFactory.CreateRPSSection<CustomEntityViewEntityView>( "","ul li[rpsid='1c8cfb35-84a0-4fee-8f8b-52f96fec46f7']","",this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomEntityViewEntityView>( "","ul li[rpsid='b52be0be-88e6-45a3-8bbf-e6e6e2242182']","",this);
 

        }
        public IRPSSaveButton<CustomEntityViewEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView,CustomEntityViewCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView,CustomEntityViewCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomEntityViewEntityView> Description { get; set; } 
        public IRPSTextBox<CustomEntityViewEntityView> ServiceName { get; set; } 
        public IRPSTextBox<CustomEntityViewEntityView> EntityName { get; set; } 
        public IRPSCheckbox<CustomEntityViewEntityView> AllCompanies { get; set; } 
        public IRPSOption<CustomEntityViewEntityView> AllUsers { get; set; } 
        public IRPSOption<CustomEntityViewEntityView> SelectedUsers { get; set; } 
        public IRPSOption<CustomEntityViewEntityView> OnlyForMe { get; set; } 
        public IRPSTextBox<CustomEntityViewEntityView> CodUser { get; set; } 
        public IRPSButton<CustomEntityViewEntityView> ExecuteUndoActionButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView> ExecuteRedoActionButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView,QueryPreviewView> QueryPreviewNavigationCommandButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView> ExecuteActivateCustomQueryButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView> ExecuteDeactivateCustomQueryButton { get; set; } 
        public IRPSButton<CustomEntityViewEntityView,CopyCustomEntityViewDialogView> CopyCustomEntityViewNavigationCommandButton { get; set; } 
        public CompanyCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> Company { get; set; } 
        public RoleCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> Role { get; set; } 
        public UserCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> User { get; set; } 
        public IRPSSection<CustomEntityViewEntityView> QueryDesign { get; set; } 
        public IRPSSection<CustomEntityViewEntityView> GeneralData { get; set; } 
        public CustomEntityView Screen { get; set; }
        public CustomEntityViewEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CompanyCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>:RPSCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public  CompanyGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class CompanyGridView <CustomEntityViewEntityView,CreateNewQueryDialogView> :  RPSGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public CompanyGridView(CustomEntityViewEntityView currentView,CreateNewQueryDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class RoleCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>:RPSCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public  RoleGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class RoleGridView <CustomEntityViewEntityView,CreateNewQueryDialogView> :  RPSGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public RoleGridView(CustomEntityViewEntityView currentView,CreateNewQueryDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class UserCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView>:RPSCollectionEditor<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public  UserGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class UserGridView <CustomEntityViewEntityView,CreateNewQueryDialogView> :  RPSGridView<CustomEntityViewEntityView,CreateNewQueryDialogView> where CustomEntityViewEntityView : class, IView where CreateNewQueryDialogView : class, IView
    {
        public UserGridView(CustomEntityViewEntityView currentView,CreateNewQueryDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class CreateNewQueryDialogView : View
    {
        public CreateNewQueryDialogView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            QueryName = RPSControlFactory.CreateRPSTextBox<CreateNewQueryDialogView>("bd742736-4e9f-43a7-87a9-30da776e6b03","","",true, this);
 
            Service = RPSControlFactory.CreateRPSEnumComboBox<CreateNewQueryDialogView>("7d987cab-27ba-47ec-b327-1e5af5c0b88c","","",false, this);
 
            Entity = RPSControlFactory.CreateRPSEnumComboBox<CreateNewQueryDialogView>("a92fa217-1beb-4cd2-97dc-e11829c1bb30","","",false, this);
 
            SelectEntityDescriptor = RPSControlFactory.CreateRPSCheckBox<CreateNewQueryDialogView>("d53d2ac0-2fc7-41c6-9343-f92459f8f537","","",false, this);
 
            AddFilter = RPSControlFactory.CreateRPSOption<CreateNewQueryDialogView>( "10eddd8c-4d61-49bf-8da1-01dd09271503","","",this);
 
            Finish = RPSControlFactory.CreateRPSOption<CreateNewQueryDialogView>( "9ef1245b-61e2-4ef1-b45a-e908fb61374f","","",this);
 
            AddFilter1 = RPSControlFactory.CreateRPSOption<CreateNewQueryDialogView>( "da3e41ee-f916-4d94-a18e-bdf0ca7213f1","","",this);
 
            Finish1 = RPSControlFactory.CreateRPSOption<CreateNewQueryDialogView>( "8b1c6615-2fab-4de6-be85-4177c5599e9a","","",this);
 
            CollectionInit params_EntityProperties = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a0726407-e705-4c71-b90f-62e864a8fcbd",CSSSelectorGrid="",XPathGrid=""};
            EntityProperties = RPSControlFactory.RPSCreateCollectionWithGrid<EntityPropertiesCollectionEditor<CreateNewQueryDialogView>,CreateNewQueryDialogView>( params_EntityProperties,this);
 
            CollectionInit params_EntityOrderByProperty = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="994e2b53-78e8-43e1-ba14-160eca0f180e",CSSSelectorGrid="",XPathGrid=""};
            EntityOrderByProperty = RPSControlFactory.RPSCreateCollectionWithGrid<EntityOrderByPropertyCollectionEditor<CreateNewQueryDialogView>,CreateNewQueryDialogView>( params_EntityOrderByProperty,this);
 
            CollectionInit params_QueryFilterEntities = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2eff2d80-367d-422a-922d-2fbfe094d0f2",CSSSelectorGrid="",XPathGrid=""};
            QueryFilterEntities = RPSControlFactory.RPSCreateCollectionWithGrid<QueryFilterEntitiesCollectionEditor<CreateNewQueryDialogView>,CreateNewQueryDialogView>( params_QueryFilterEntities,this);
 
            CollectionInit params_QueryFiltersForEntity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8db5a601-174b-4be6-8f0b-2b1037cdf2d3",CSSSelectorGrid="",XPathGrid=""};
            QueryFiltersForEntity = RPSControlFactory.RPSCreateCollectionWithGrid<QueryFiltersForEntityCollectionEditor<CreateNewQueryDialogView>,CreateNewQueryDialogView>( params_QueryFiltersForEntity,this);
 

        }
        public IRPSTextBox<CreateNewQueryDialogView> QueryName { get; set; } 
        public IRPSComboBox<CreateNewQueryDialogView> Service { get; set; } 
        public IRPSComboBox<CreateNewQueryDialogView> Entity { get; set; } 
        public IRPSCheckbox<CreateNewQueryDialogView> SelectEntityDescriptor { get; set; } 
        public IRPSOption<CreateNewQueryDialogView> AddFilter { get; set; } 
        public IRPSOption<CreateNewQueryDialogView> Finish { get; set; } 
        public IRPSOption<CreateNewQueryDialogView> AddFilter1 { get; set; } 
        public IRPSOption<CreateNewQueryDialogView> Finish1 { get; set; } 
        public EntityPropertiesCollectionEditor<CreateNewQueryDialogView> EntityProperties { get; set; } 
        public EntityOrderByPropertyCollectionEditor<CreateNewQueryDialogView> EntityOrderByProperty { get; set; } 
        public QueryFilterEntitiesCollectionEditor<CreateNewQueryDialogView> QueryFilterEntities { get; set; } 
        public QueryFiltersForEntityCollectionEditor<CreateNewQueryDialogView> QueryFiltersForEntity { get; set; } 
        public CustomEntityView Screen { get; set; }
        public CreateNewQueryDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EntityPropertiesCollectionEditor<CreateNewQueryDialogView>:RPSCollectionEditor<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public  EntityPropertiesGridView<CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class EntityPropertiesGridView <CreateNewQueryDialogView> :  RPSGridView<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public EntityPropertiesGridView(CreateNewQueryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#a0726407-e705-4c71-b90f-62e864a8fcbd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#a0726407-e705-4c71-b90f-62e864a8fcbd .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 
            IsDetailProperty = RPSControlFactory.CreateRPSGridCheckBox<CreateNewQueryDialogView>("","#a0726407-e705-4c71-b90f-62e864a8fcbd .ag-row[role='row']@ROWINDEX [col-id='cIsDetailProperty']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewQueryDialogView> Description { get; set; } 
        public IRPSGridTextBox<CreateNewQueryDialogView> Name { get; set; } 
        public IRPSGridCheckbox<CreateNewQueryDialogView> IsDetailProperty { get; set; } 
                     
    }
 
        public partial class EntityOrderByPropertyCollectionEditor<CreateNewQueryDialogView>:RPSCollectionEditor<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public  EntityOrderByPropertyGridView<CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class EntityOrderByPropertyGridView <CreateNewQueryDialogView> :  RPSGridView<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public EntityOrderByPropertyGridView(CreateNewQueryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#994e2b53-78e8-43e1-ba14-160eca0f180e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#994e2b53-78e8-43e1-ba14-160eca0f180e .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewQueryDialogView> Description { get; set; } 
        public IRPSGridTextBox<CreateNewQueryDialogView> Name { get; set; } 
                     
    }
 
        public partial class QueryFilterEntitiesCollectionEditor<CreateNewQueryDialogView>:RPSCollectionEditor<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public  QueryFilterEntitiesGridView<CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class QueryFilterEntitiesGridView <CreateNewQueryDialogView> :  RPSGridView<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public QueryFilterEntitiesGridView(CreateNewQueryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FilterEntityName = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#2eff2d80-367d-422a-922d-2fbfe094d0f2 .ag-row[role='row']@ROWINDEX [col-id='cFilterEntityName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewQueryDialogView> FilterEntityName { get; set; } 
                     
    }
 
        public partial class QueryFiltersForEntityCollectionEditor<CreateNewQueryDialogView>:RPSCollectionEditor<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public  QueryFiltersForEntityGridView<CreateNewQueryDialogView> GridView {get;set;}
    }
    public partial class QueryFiltersForEntityGridView <CreateNewQueryDialogView> :  RPSGridView<CreateNewQueryDialogView> where CreateNewQueryDialogView : class, IView
    {
        public QueryFiltersForEntityGridView(CreateNewQueryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FilterLabel = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#8db5a601-174b-4be6-8f0b-2b1037cdf2d3 .ag-row[role='row']@ROWINDEX [col-id='cFilterLabel']","",false, this.CurrentView);
 
            PropertyName = RPSControlFactory.CreateRPSGridTextBox<CreateNewQueryDialogView>("","#8db5a601-174b-4be6-8f0b-2b1037cdf2d3 .ag-row[role='row']@ROWINDEX [col-id='cPropertyName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewQueryDialogView> FilterLabel { get; set; } 
        public IRPSGridTextBox<CreateNewQueryDialogView> PropertyName { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddJoinedEntityDialogView : View
    {
        public AddJoinedEntityDialogView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectEntityDescriptor = RPSControlFactory.CreateRPSCheckBox<AddJoinedEntityDialogView>("e6b1f658-555d-4b22-92b8-e8e1be92e170","","",false, this);
 
            CollectionInit params_EntityJoins = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="41bacbf0-bda4-4f2f-a341-5af820978ea6",CSSSelectorGrid="",XPathGrid=""};
            EntityJoins = RPSControlFactory.RPSCreateCollectionWithGrid<EntityJoinsCollectionEditor<AddJoinedEntityDialogView>,AddJoinedEntityDialogView>( params_EntityJoins,this);
 
            CollectionInit params_EntityProperties = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="006abf75-4f84-4a37-85e7-7d1a7a27536d",CSSSelectorGrid="",XPathGrid=""};
            EntityProperties = RPSControlFactory.RPSCreateCollectionWithGrid<EntityPropertiesCollectionEditor<AddJoinedEntityDialogView>,AddJoinedEntityDialogView>( params_EntityProperties,this);
 

        }
        public IRPSCheckbox<AddJoinedEntityDialogView> SelectEntityDescriptor { get; set; } 
        public EntityJoinsCollectionEditor<AddJoinedEntityDialogView> EntityJoins { get; set; } 
        public EntityPropertiesCollectionEditor<AddJoinedEntityDialogView> EntityProperties { get; set; } 
        public CustomEntityView Screen { get; set; }
        public AddJoinedEntityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class EntityJoinsCollectionEditor<AddJoinedEntityDialogView>:RPSCollectionEditor<AddJoinedEntityDialogView> where AddJoinedEntityDialogView : class, IView
    {
        public  EntityJoinsGridView<AddJoinedEntityDialogView> GridView {get;set;}
    }
    public partial class EntityJoinsGridView <AddJoinedEntityDialogView> :  RPSGridView<AddJoinedEntityDialogView> where AddJoinedEntityDialogView : class, IView
    {
        public EntityJoinsGridView(AddJoinedEntityDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LocalizedEntityName = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#41bacbf0-bda4-4f2f-a341-5af820978ea6 .ag-row[role='row']@ROWINDEX [col-id='cLocalizedEntityName']","",false, this.CurrentView);
 
            EntityName = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#41bacbf0-bda4-4f2f-a341-5af820978ea6 .ag-row[role='row']@ROWINDEX [col-id='cEntityName']","",false, this.CurrentView);
 
            LocalizedJoinedOn = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#41bacbf0-bda4-4f2f-a341-5af820978ea6 .ag-row[role='row']@ROWINDEX [col-id='cLocalizedJoinedOn']","",false, this.CurrentView);
 
            JoinedOn = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#41bacbf0-bda4-4f2f-a341-5af820978ea6 .ag-row[role='row']@ROWINDEX [col-id='cJoinedOn']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddJoinedEntityDialogView> LocalizedEntityName { get; set; } 
        public IRPSGridTextBox<AddJoinedEntityDialogView> EntityName { get; set; } 
        public IRPSGridTextBox<AddJoinedEntityDialogView> LocalizedJoinedOn { get; set; } 
        public IRPSGridTextBox<AddJoinedEntityDialogView> JoinedOn { get; set; } 
                     
    }
 
        public partial class EntityPropertiesCollectionEditor<AddJoinedEntityDialogView>:RPSCollectionEditor<AddJoinedEntityDialogView> where AddJoinedEntityDialogView : class, IView
    {
        public  EntityPropertiesGridView<AddJoinedEntityDialogView> GridView {get;set;}
    }
    public partial class EntityPropertiesGridView <AddJoinedEntityDialogView> :  RPSGridView<AddJoinedEntityDialogView> where AddJoinedEntityDialogView : class, IView
    {
        public EntityPropertiesGridView(AddJoinedEntityDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#006abf75-4f84-4a37-85e7-7d1a7a27536d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<AddJoinedEntityDialogView>("","#006abf75-4f84-4a37-85e7-7d1a7a27536d .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddJoinedEntityDialogView> Description { get; set; } 
        public IRPSGridTextBox<AddJoinedEntityDialogView> Name { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddFilterDialogView : View
    {
        public AddFilterDialogView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_QueryFilterEntities = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5a99c68d-ed21-4016-a19f-afe8c2bb7c5b",CSSSelectorGrid="",XPathGrid=""};
            QueryFilterEntities = RPSControlFactory.RPSCreateCollectionWithGrid<QueryFilterEntitiesCollectionEditor<AddFilterDialogView>,AddFilterDialogView>( params_QueryFilterEntities,this);
 
            CollectionInit params_QueryFiltersForEntity = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="57b2326b-a8fa-46ed-938f-8ce647a37f71",CSSSelectorGrid="",XPathGrid=""};
            QueryFiltersForEntity = RPSControlFactory.RPSCreateCollectionWithGrid<QueryFiltersForEntityCollectionEditor<AddFilterDialogView>,AddFilterDialogView>( params_QueryFiltersForEntity,this);
 

        }
        public QueryFilterEntitiesCollectionEditor<AddFilterDialogView> QueryFilterEntities { get; set; } 
        public QueryFiltersForEntityCollectionEditor<AddFilterDialogView> QueryFiltersForEntity { get; set; } 
        public CustomEntityView Screen { get; set; }
        public AddFilterDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QueryFilterEntitiesCollectionEditor<AddFilterDialogView>:RPSCollectionEditor<AddFilterDialogView> where AddFilterDialogView : class, IView
    {
        public  QueryFilterEntitiesGridView<AddFilterDialogView> GridView {get;set;}
    }
    public partial class QueryFilterEntitiesGridView <AddFilterDialogView> :  RPSGridView<AddFilterDialogView> where AddFilterDialogView : class, IView
    {
        public QueryFilterEntitiesGridView(AddFilterDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FilterEntityName = RPSControlFactory.CreateRPSGridTextBox<AddFilterDialogView>("","#5a99c68d-ed21-4016-a19f-afe8c2bb7c5b .ag-row[role='row']@ROWINDEX [col-id='cFilterEntityName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddFilterDialogView> FilterEntityName { get; set; } 
                     
    }
 
        public partial class QueryFiltersForEntityCollectionEditor<AddFilterDialogView>:RPSCollectionEditor<AddFilterDialogView> where AddFilterDialogView : class, IView
    {
        public  QueryFiltersForEntityGridView<AddFilterDialogView> GridView {get;set;}
    }
    public partial class QueryFiltersForEntityGridView <AddFilterDialogView> :  RPSGridView<AddFilterDialogView> where AddFilterDialogView : class, IView
    {
        public QueryFiltersForEntityGridView(AddFilterDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FilterLabel = RPSControlFactory.CreateRPSGridTextBox<AddFilterDialogView>("","#57b2326b-a8fa-46ed-938f-8ce647a37f71 .ag-row[role='row']@ROWINDEX [col-id='cFilterLabel']","",false, this.CurrentView);
 
            PropertyName = RPSControlFactory.CreateRPSGridTextBox<AddFilterDialogView>("","#57b2326b-a8fa-46ed-938f-8ce647a37f71 .ag-row[role='row']@ROWINDEX [col-id='cPropertyName']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddFilterDialogView> FilterLabel { get; set; } 
        public IRPSGridTextBox<AddFilterDialogView> PropertyName { get; set; } 
                     
    }
 
    }
  
            
    public partial class QueryPreviewView : View
    {
        public QueryPreviewView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OKCommand = RPSControlFactory.CreateRPSButton<QueryPreviewView>( "65b33dc0-e1e2-49ba-8e35-1d4bbb157814","","",this);
 

        }
        public IRPSButton<QueryPreviewView> OKCommand { get; set; } 
        public CustomEntityView Screen { get; set; }
        public QueryPreviewView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyCustomEntityViewDialogView : View
    {
        public CopyCustomEntityViewDialogView(CustomEntityView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UICopyDescription = RPSControlFactory.CreateRPSTextBox<CopyCustomEntityViewDialogView>("3afca1ca-7f73-43d8-aea6-14260cfb04f0","","",true, this);
 

        }
        public IRPSTextBox<CopyCustomEntityViewDialogView> UICopyDescription { get; set; } 
        public CustomEntityView Screen { get; set; }
        public CopyCustomEntityViewDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
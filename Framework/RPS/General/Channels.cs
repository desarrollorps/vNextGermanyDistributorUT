    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Channels
{
    //RPS VERSION 1.0.0.0
    public partial class Channels:Screen
    {
        public Channels():base()
        {
            this.URL = "general.channels";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CChannelQueryView  = new CChannelQueryView(this); 
            CChannelView  = new CChannelView(this); 
            CChannelPropertiesDialogView  = new CChannelPropertiesDialogView(this); 
            InviteUsersDialogView  = new InviteUsersDialogView(this); 
            TeamDialogView  = new TeamDialogView(this); 
            NewConversationDialogView  = new NewConversationDialogView(this); 
            UserSettingsDialogView  = new UserSettingsDialogView(this); 
            BlankPageView  = new BlankPageView(this); 
            FiltersTreeDialogView  = new FiltersTreeDialogView(this); 
            FavouriteMessagesForUserDialogView  = new FavouriteMessagesForUserDialogView(this); 
            ExternalUserSettingsDialogView  = new ExternalUserSettingsDialogView(this); 
            CreateNewChannelDialogView  = new CreateNewChannelDialogView(this); 
            CChannelQueryView.InitializeControls(); 
            CChannelView.InitializeControls(); 
            CChannelPropertiesDialogView.InitializeControls(); 
            InviteUsersDialogView.InitializeControls(); 
            TeamDialogView.InitializeControls(); 
            NewConversationDialogView.InitializeControls(); 
            UserSettingsDialogView.InitializeControls(); 
            BlankPageView.InitializeControls(); 
            FiltersTreeDialogView.InitializeControls(); 
            FavouriteMessagesForUserDialogView.InitializeControls(); 
            ExternalUserSettingsDialogView.InitializeControls(); 
            CreateNewChannelDialogView.InitializeControls(); 
           
        }
      
            public CChannelQueryView CChannelQueryView {get; set; } 
            public CChannelView CChannelView {get; set; } 
            public CChannelPropertiesDialogView CChannelPropertiesDialogView {get; set; } 
            public InviteUsersDialogView InviteUsersDialogView {get; set; } 
            public TeamDialogView TeamDialogView {get; set; } 
            public NewConversationDialogView NewConversationDialogView {get; set; } 
            public UserSettingsDialogView UserSettingsDialogView {get; set; } 
            public BlankPageView BlankPageView {get; set; } 
            public FiltersTreeDialogView FiltersTreeDialogView {get; set; } 
            public FavouriteMessagesForUserDialogView FavouriteMessagesForUserDialogView {get; set; } 
            public ExternalUserSettingsDialogView ExternalUserSettingsDialogView {get; set; } 
            public CreateNewChannelDialogView CreateNewChannelDialogView {get; set; } 
    }
            
    public partial class CChannelQueryView : View
    {
        public CChannelQueryView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FiltersIsNotAppliedCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "09eefec8-d57a-44b2-8e9d-e479263b372e","","",this);
 
            FiltersIsAppliedCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "c4adbc32-10c8-4e80-9390-a4c4d6d7ae0b","","",this);
 
            CreateGenericChannelNavigationCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "a3523ba5-954b-48a5-b7a3-b861d9db96c2","","",this);
 
            CreateNewsChannelNavigationCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "8ba04503-c568-49e2-8cbb-db7817fdfdcf","","",this);
 
            UserFavouriteMessagesNavigationCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "cbf81888-66a8-4f15-b034-42834fc2d0ee","","",this);
 
            ExternalUserSettingsNavigationCommandButton = RPSControlFactory.CreateRPSButton<CChannelQueryView>( "0a762a6e-847b-4c12-ba58-ba05ca2e46e6","","",this);
 

        }
        public IRPSButton<CChannelQueryView> FiltersIsNotAppliedCommandButton { get; set; } 
        public IRPSButton<CChannelQueryView> FiltersIsAppliedCommandButton { get; set; } 
        public IRPSButton<CChannelQueryView> CreateGenericChannelNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelQueryView> CreateNewsChannelNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelQueryView> UserFavouriteMessagesNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelQueryView> ExternalUserSettingsNavigationCommandButton { get; set; } 
        public Channels Screen { get; set; }
        public CChannelQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CChannelView : View
    {
        public CChannelView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CChannelView>( this);
 
            CChannelPropertiesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelView,CChannelPropertiesDialogView>("f615ad07-b3a9-448f-8234-23f646aaa64b","","", this,Screen.CChannelPropertiesDialogView);
 
            LinkToRelatedEntityButton = RPSControlFactory.CreateRPSButton<CChannelView>( "5ae14339-fbdf-49cb-b802-e7d361b578d6","","",this);
 
            TeamNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelView,TeamDialogView>("ba5e2083-ae64-4860-be3b-ee5db35ad136","","", this,Screen.TeamDialogView);
 
            InviteUsersNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelView,InviteUsersDialogView>("20216c04-2ef1-47d5-8f3a-558bf82ba7d2","","", this,Screen.InviteUsersDialogView);
 
            NewConversationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelView,NewConversationDialogView>("447f568d-3ad4-44d3-82b6-3e82d5216525","","", this,Screen.NewConversationDialogView);
 
            ExecuteLeaveChannelButton = RPSControlFactory.CreateRPSButton<CChannelView>( "b4e76747-cbb6-4dfd-9f2f-4f51c0bc49f3","","",this);
 
            ExecuteCloseColaborativeChannelButton = RPSControlFactory.CreateRPSButton<CChannelView>( "38deb427-ae94-422a-b3d8-c7c4bc185bb3","","",this);
 
            ExecuteReOpenColaborativeChannelButton = RPSControlFactory.CreateRPSButton<CChannelView>( "2f0fb7f3-3037-46bc-983e-81502aaaa431","","",this);
 
            GoToFavouriteWindowCommandButton = RPSControlFactory.CreateRPSButton<CChannelView>( "52e69c50-b3e2-449c-860e-c1a62d2b5e35","","",this);
 
            UserSettingsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CChannelView,UserSettingsDialogView>("0f499c32-86c3-4f6c-b010-9ceff39f82b9","","", this,Screen.UserSettingsDialogView);
 
            AllowMessageSearchCommandButton = RPSControlFactory.CreateRPSButton<CChannelView>( "caa7907c-4b80-46f9-9707-d88faefac170","","",this);
 
            DenyMessageSearchCommandButton = RPSControlFactory.CreateRPSButton<CChannelView>( "74b5f84c-940e-4da9-aed6-a3346192e33b","","",this);
 

        }
        public IRPSSaveButton<CChannelView> SaveButton { get; set; } 
        public IRPSButton<CChannelView,CChannelPropertiesDialogView> CChannelPropertiesNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelView> LinkToRelatedEntityButton { get; set; } 
        public IRPSButton<CChannelView,TeamDialogView> TeamNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelView,InviteUsersDialogView> InviteUsersNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelView,NewConversationDialogView> NewConversationNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelView> ExecuteLeaveChannelButton { get; set; } 
        public IRPSButton<CChannelView> ExecuteCloseColaborativeChannelButton { get; set; } 
        public IRPSButton<CChannelView> ExecuteReOpenColaborativeChannelButton { get; set; } 
        public IRPSButton<CChannelView> GoToFavouriteWindowCommandButton { get; set; } 
        public IRPSButton<CChannelView,UserSettingsDialogView> UserSettingsNavigationCommandButton { get; set; } 
        public IRPSButton<CChannelView> AllowMessageSearchCommandButton { get; set; } 
        public IRPSButton<CChannelView> DenyMessageSearchCommandButton { get; set; } 
        public Channels Screen { get; set; }
        public CChannelView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CChannelPropertiesDialogView : View
    {
        public CChannelPropertiesDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCCHType = RPSControlFactory.CreateRPSComboBox<CChannelPropertiesDialogView>("a5a0db0e-e248-4ccf-b4f5-8df299f4924f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("fc0b39c2-55b3-454d-a65f-03c903b5ab6a","","",true, this);
 
            EntityType = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("57dad3ff-29c1-4832-88d7-1bd15882f92a","","",false, this);
 
            Property1 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("9f7aa31f-d0b9-4897-b472-a209277d0e2f","","",false, this);
 
            Property2 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("eb94f5fc-55ee-43e0-9b8d-27110cddebf6","","",false, this);
 
            Property3 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("f59f7848-d38a-461d-bd79-89f5972c8c49","","",false, this);
 
            Property4 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("6bb8b4d0-6794-4d5b-abf4-7d7206f63992","","",false, this);
 
            Property5 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("cab4888e-5cf6-49ec-8156-992780b7e7f0","","",false, this);
 
            Property6 = RPSControlFactory.CreateRPSTextBox<CChannelPropertiesDialogView>("753a79ef-bdf5-4254-b21d-b6b8c66b3f39","","",false, this);
 

        }
        public IRPSComboBox<CChannelPropertiesDialogView> CodCCHType { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Description { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> EntityType { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property1 { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property2 { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property3 { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property4 { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property5 { get; set; } 
        public IRPSTextBox<CChannelPropertiesDialogView> Property6 { get; set; } 
        public Channels Screen { get; set; }
        public CChannelPropertiesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InviteUsersDialogView : View
    {
        public InviteUsersDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RPSUsers = RPSControlFactory.CreateRPSOption<InviteUsersDialogView>( "1bf4ee6a-126a-4553-85d7-1f2ec6471c23","","",this);
 
            ExternalUsers = RPSControlFactory.CreateRPSOption<InviteUsersDialogView>( "579884c4-08a1-4c04-9bd5-12f1b69c67f5","","",this);
 
            All = RPSControlFactory.CreateRPSOption<InviteUsersDialogView>( "a7e01d42-2408-4df7-ba89-70fac71d5db5","","",this);
 
            RPSGenericUsers = RPSControlFactory.CreateRPSCheckBox<InviteUsersDialogView>("0d22d0ac-61d7-408f-8edf-d21835fefc66","","",false, this);
 
            RPSExternalUsers = RPSControlFactory.CreateRPSCheckBox<InviteUsersDialogView>("77680e55-d5be-4350-85c5-e7aca9832d9b","","",false, this);
 
            Role = RPSControlFactory.CreateRPSOption<InviteUsersDialogView>( "a52b611e-e2a6-4db9-afb0-72b793706671","","",this);
 
            RoleSelection = RPSControlFactory.CreateRPSCollectionComboBox<InviteUsersDialogView>("7f855e7c-c02c-4deb-949e-6a335731fbea","","",false, this);
 
            User = RPSControlFactory.CreateRPSOption<InviteUsersDialogView>( "6d4f285a-be30-4398-958e-375d1ff5c866","","",this);
 
            UserSelection = RPSControlFactory.CreateRPSCollectionComboBox<InviteUsersDialogView>("3b604b27-dbb8-4280-b393-3dd80ba41c8c","","",false, this);
 
            eTypeNotification = RPSControlFactory.CreateRPSEnumComboBox<InviteUsersDialogView>("a6d60792-f7d2-48cb-8015-60025b686641","","",false, this);
 
            SetNotificationTypeCommand = RPSControlFactory.CreateRPSButton<InviteUsersDialogView>( "dfb3c74a-7480-46f7-aae0-1b2e31996bcd","","",this);
 
            CollectionInit params_GetNewRPSUsersToInvite = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2cb00c81-1217-43fa-9711-3dea57f02257",CSSSelectorGrid="",XPathGrid=""};
            GetNewRPSUsersToInvite = RPSControlFactory.RPSCreateCollectionWithGrid<GetNewRPSUsersToInviteCollectionEditor<InviteUsersDialogView>,InviteUsersDialogView>( params_GetNewRPSUsersToInvite,this);
 
            CollectionInit params_UsersToInviteCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5ef3d6dd-f37a-479f-8a51-8bb99a2b33fa",CSSSelectorGrid="",XPathGrid=""};
            UsersToInviteCollection = RPSControlFactory.RPSCreateCollectionWithGrid<UsersToInviteCollectionCollectionEditor<InviteUsersDialogView>,InviteUsersDialogView>( params_UsersToInviteCollection,this);
 

        }
        public IRPSOption<InviteUsersDialogView> RPSUsers { get; set; } 
        public IRPSOption<InviteUsersDialogView> ExternalUsers { get; set; } 
        public IRPSOption<InviteUsersDialogView> All { get; set; } 
        public IRPSCheckbox<InviteUsersDialogView> RPSGenericUsers { get; set; } 
        public IRPSCheckbox<InviteUsersDialogView> RPSExternalUsers { get; set; } 
        public IRPSOption<InviteUsersDialogView> Role { get; set; } 
        public IRPSCollectionComboBox<InviteUsersDialogView> RoleSelection { get; set; } 
        public IRPSOption<InviteUsersDialogView> User { get; set; } 
        public IRPSCollectionComboBox<InviteUsersDialogView> UserSelection { get; set; } 
        public IRPSComboBox<InviteUsersDialogView> eTypeNotification { get; set; } 
        public IRPSButton<InviteUsersDialogView> SetNotificationTypeCommand { get; set; } 
        public GetNewRPSUsersToInviteCollectionEditor<InviteUsersDialogView> GetNewRPSUsersToInvite { get; set; } 
        public UsersToInviteCollectionCollectionEditor<InviteUsersDialogView> UsersToInviteCollection { get; set; } 
        public Channels Screen { get; set; }
        public InviteUsersDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetNewRPSUsersToInviteCollectionEditor<InviteUsersDialogView>:RPSCollectionEditor<InviteUsersDialogView> where InviteUsersDialogView : class, IView
    {
        public  GetNewRPSUsersToInviteGridView<InviteUsersDialogView> GridView {get;set;}
    }
    public partial class GetNewRPSUsersToInviteGridView <InviteUsersDialogView> :  RPSGridView<InviteUsersDialogView> where InviteUsersDialogView : class, IView
    {
        public GetNewRPSUsersToInviteGridView(InviteUsersDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UserType = RPSControlFactory.CreateRPSGridTextBox<InviteUsersDialogView>("","#2cb00c81-1217-43fa-9711-3dea57f02257 .ag-row[role='row']@ROWINDEX [col-id='cUserType']","",false, this.CurrentView);
 
            eTypeUser = RPSControlFactory.CreateRPSGridEnumComboBox<InviteUsersDialogView>("","#2cb00c81-1217-43fa-9711-3dea57f02257 .ag-row[role='row']@ROWINDEX [col-id='ceTypeUser']","",false, this.CurrentView);
 
            eTypeNotification = RPSControlFactory.CreateRPSGridEnumComboBox<InviteUsersDialogView>("","#2cb00c81-1217-43fa-9711-3dea57f02257 .ag-row[role='row']@ROWINDEX [col-id='ceTypeNotification']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InviteUsersDialogView> UserType { get; set; } 
        public IRPSGridComboBox<InviteUsersDialogView> eTypeUser { get; set; } 
        public IRPSGridComboBox<InviteUsersDialogView> eTypeNotification { get; set; } 
                     
    }
 
        public partial class UsersToInviteCollectionCollectionEditor<InviteUsersDialogView>:RPSCollectionEditor<InviteUsersDialogView> where InviteUsersDialogView : class, IView
    {
        public  UsersToInviteCollectionGridView<InviteUsersDialogView> GridView {get;set;}
    }
    public partial class UsersToInviteCollectionGridView <InviteUsersDialogView> :  RPSGridView<InviteUsersDialogView> where InviteUsersDialogView : class, IView
    {
        public UsersToInviteCollectionGridView(InviteUsersDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExternalUserDescription = RPSControlFactory.CreateRPSGridTextBox<InviteUsersDialogView>("","#5ef3d6dd-f37a-479f-8a51-8bb99a2b33fa .ag-row[role='row']@ROWINDEX [col-id='cExternalUserDescription']","",false, this.CurrentView);
 
            ExternalUserEmailToInvite = RPSControlFactory.CreateRPSGridEmailTextBox<InviteUsersDialogView>("","#5ef3d6dd-f37a-479f-8a51-8bb99a2b33fa .ag-row[role='row']@ROWINDEX [col-id='cExternalUserEmailToInvite']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InviteUsersDialogView> ExternalUserDescription { get; set; } 
        public IRPSGridTextBox<InviteUsersDialogView> ExternalUserEmailToInvite { get; set; } 
                     
    }
 
    }
  
            
    public partial class TeamDialogView : View
    {
        public TeamDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_CCHTeams = new CollectionInit(){IDDescriptor = "33c55736-130c-4fac-a95a-e36249cd0524",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="13f885c8-e798-4450-a0ba-06f8cacfab8b",CSSSelectorGrid="",XPathGrid=""};
            CCHTeams = RPSControlFactory.RPSCreateCollectionWithGrid<CCHTeamsCollectionEditor<TeamDialogView>,TeamDialogView>( params_CCHTeams,this);
 

        }
        public CCHTeamsCollectionEditor<TeamDialogView> CCHTeams { get; set; } 
        public Channels Screen { get; set; }
        public TeamDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CCHTeamsCollectionEditor<TeamDialogView>:RPSCollectionEditor<TeamDialogView> where TeamDialogView : class, IView
    {
        public  CCHTeamsGridView<TeamDialogView> GridView {get;set;}
    }
    public partial class CCHTeamsGridView <TeamDialogView> :  RPSGridView<TeamDialogView> where TeamDialogView : class, IView
    {
        public CCHTeamsGridView(TeamDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteParticipantCommand = RPSControlFactory.CreateRPSGridButton<TeamDialogView>( "","#13f885c8-e798-4450-a0ba-06f8cacfab8b .ag-row[role='row']@ROWINDEX [col-id='cDeleteParticipantCommand']","",this.CurrentView);
 
            eUserType = RPSControlFactory.CreateRPSGridEnumComboBox<TeamDialogView>("","#13f885c8-e798-4450-a0ba-06f8cacfab8b .ag-row[role='row']@ROWINDEX [col-id='ceUserType']","",false, this.CurrentView);
 
            TypeUser = RPSControlFactory.CreateRPSGridEnumComboBox<TeamDialogView>("","#13f885c8-e798-4450-a0ba-06f8cacfab8b .ag-row[role='row']@ROWINDEX [col-id='cTypeUser']","",true, this.CurrentView);
 
            TypeNotification = RPSControlFactory.CreateRPSGridEnumComboBox<TeamDialogView>("","#13f885c8-e798-4450-a0ba-06f8cacfab8b .ag-row[role='row']@ROWINDEX [col-id='cTypeNotification']","",true, this.CurrentView);
 

        }
        public IRPSGridButton<TeamDialogView> DeleteParticipantCommand { get; set; } 
        public IRPSGridComboBox<TeamDialogView> eUserType { get; set; } 
        public IRPSGridComboBox<TeamDialogView> TypeUser { get; set; } 
        public IRPSGridComboBox<TeamDialogView> TypeNotification { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewConversationDialogView : View
    {
        public NewConversationDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewConversationDescription = RPSControlFactory.CreateRPSTextBox<NewConversationDialogView>("60d027a6-2bca-45fd-ba78-96d4363eafaa","","",true, this);
 
            CollectionInit params_ConversationParticipant = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="504b40a3-2d3a-4caa-9e6c-49edca55118c",CSSSelectorGrid="",XPathGrid=""};
            ConversationParticipant = RPSControlFactory.RPSCreateCollectionWithGrid<ConversationParticipantCollectionEditor<NewConversationDialogView>,NewConversationDialogView>( params_ConversationParticipant,this);
 

        }
        public IRPSTextBox<NewConversationDialogView> NewConversationDescription { get; set; } 
        public ConversationParticipantCollectionEditor<NewConversationDialogView> ConversationParticipant { get; set; } 
        public Channels Screen { get; set; }
        public NewConversationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ConversationParticipantCollectionEditor<NewConversationDialogView>:RPSCollectionEditor<NewConversationDialogView> where NewConversationDialogView : class, IView
    {
        public  ConversationParticipantGridView<NewConversationDialogView> GridView {get;set;}
    }
    public partial class ConversationParticipantGridView <NewConversationDialogView> :  RPSGridView<NewConversationDialogView> where NewConversationDialogView : class, IView
    {
        public ConversationParticipantGridView(NewConversationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveUserTeamCommand = RPSControlFactory.CreateRPSGridButton<NewConversationDialogView>( "","#504b40a3-2d3a-4caa-9e6c-49edca55118c .ag-row[role='row']@ROWINDEX [col-id='cRemoveUserTeamCommand']","",this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<NewConversationDialogView>("","#504b40a3-2d3a-4caa-9e6c-49edca55118c .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            eUserType = RPSControlFactory.CreateRPSGridEnumComboBox<NewConversationDialogView>("","#504b40a3-2d3a-4caa-9e6c-49edca55118c .ag-row[role='row']@ROWINDEX [col-id='ceUserType']","",false, this.CurrentView);
 
            TypeUser = RPSControlFactory.CreateRPSGridEnumComboBox<NewConversationDialogView>("","#504b40a3-2d3a-4caa-9e6c-49edca55118c .ag-row[role='row']@ROWINDEX [col-id='cTypeUser']","",true, this.CurrentView);
 
            TypeNotification = RPSControlFactory.CreateRPSGridEnumComboBox<NewConversationDialogView>("","#504b40a3-2d3a-4caa-9e6c-49edca55118c .ag-row[role='row']@ROWINDEX [col-id='cTypeNotification']","",true, this.CurrentView);
 

        }
        public IRPSGridButton<NewConversationDialogView> RemoveUserTeamCommand { get; set; } 
        public IRPSGridComboBox<NewConversationDialogView> CodUser { get; set; } 
        public IRPSGridComboBox<NewConversationDialogView> eUserType { get; set; } 
        public IRPSGridComboBox<NewConversationDialogView> TypeUser { get; set; } 
        public IRPSGridComboBox<NewConversationDialogView> TypeNotification { get; set; } 
                     
    }
 
    }
  
            
    public partial class UserSettingsDialogView : View
    {
        public UserSettingsDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UserTypeNotification = RPSControlFactory.CreateRPSEnumComboBox<UserSettingsDialogView>("7d3911d9-84d8-4978-8923-a15b8ee67ab5","","",true, this);
 

        }
        public IRPSComboBox<UserSettingsDialogView> UserTypeNotification { get; set; } 
        public Channels Screen { get; set; }
        public UserSettingsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BlankPageView : View
    {
        public BlankPageView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Channels Screen { get; set; }
        public BlankPageView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FiltersTreeDialogView : View
    {
        public FiltersTreeDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ShowGenericChannels = RPSControlFactory.CreateRPSCheckBox<FiltersTreeDialogView>("959ea224-d83a-4db9-a02a-da709affa616","","",false, this);
 
            ShowNewChannels = RPSControlFactory.CreateRPSCheckBox<FiltersTreeDialogView>("0e0f4352-60fd-4f77-9c7c-c05323df0b67","","",false, this);
 
            CreatorUser = RPSControlFactory.CreateRPSComboBox<FiltersTreeDialogView>("fa81340e-bf5b-45c0-83de-6c82b8d06b82","","",false, this);
 
            CreationDateFrom = RPSControlFactory.CreateRPSTextBox<FiltersTreeDialogView>("359dbfed-7add-4e0f-988f-7c542f0e9764","","",false, this);
 
            CreationDateTo = RPSControlFactory.CreateRPSTextBox<FiltersTreeDialogView>("c8e3af15-9d78-45ff-8982-933cf78765bf","","",false, this);
 
            ShowClosedChannels = RPSControlFactory.CreateRPSCheckBox<FiltersTreeDialogView>("74d834eb-0bb8-4ce7-9d90-c8729fc3a797","","",false, this);
 
            ClosingUser = RPSControlFactory.CreateRPSComboBox<FiltersTreeDialogView>("2ec45b60-36c7-41ac-bb4d-919c6e99e024","","",false, this);
 
            ClosingDateFrom = RPSControlFactory.CreateRPSTextBox<FiltersTreeDialogView>("780e27bd-533b-435a-ba2d-a7617bdd475c","","",false, this);
 
            ClosingDateTo = RPSControlFactory.CreateRPSTextBox<FiltersTreeDialogView>("fa110dc4-748b-4e7f-bd9c-a0977baf0378","","",false, this);
 
            CodUserTeam = RPSControlFactory.CreateRPSComboBox<FiltersTreeDialogView>("6e37e5e8-7b7e-4307-a863-4d8fa051c3d5","","",false, this);
 
            UIService = RPSControlFactory.CreateRPSEnumComboBox<FiltersTreeDialogView>("a155885a-f4b9-43d0-b468-acb8ddbc4b0f","","",false, this);
 
            UIServiceEntity = RPSControlFactory.CreateRPSEnumComboBox<FiltersTreeDialogView>("d3bd82fb-fe42-4e86-a9fd-139f5f375cff","","",false, this);
 
            CCHTypes = RPSControlFactory.CreateRPSCollectionComboBox<FiltersTreeDialogView>("3d4bd57c-2bcd-4fd1-a50d-585be11bde72","","",false, this);
 
            TextToSearch = RPSControlFactory.CreateRPSTextBox<FiltersTreeDialogView>("ebeba0e7-34c3-44f9-80df-04abd8cc0a3c","","",false, this);
 
            CleanFiltersButton = RPSControlFactory.CreateRPSButton<FiltersTreeDialogView>( "7f1f1862-e7fd-45b4-a473-25a1e94fba58","","",this);
 

        }
        public IRPSCheckbox<FiltersTreeDialogView> ShowGenericChannels { get; set; } 
        public IRPSCheckbox<FiltersTreeDialogView> ShowNewChannels { get; set; } 
        public IRPSComboBox<FiltersTreeDialogView> CreatorUser { get; set; } 
        public IRPSTextBox<FiltersTreeDialogView> CreationDateFrom { get; set; } 
        public IRPSTextBox<FiltersTreeDialogView> CreationDateTo { get; set; } 
        public IRPSCheckbox<FiltersTreeDialogView> ShowClosedChannels { get; set; } 
        public IRPSComboBox<FiltersTreeDialogView> ClosingUser { get; set; } 
        public IRPSTextBox<FiltersTreeDialogView> ClosingDateFrom { get; set; } 
        public IRPSTextBox<FiltersTreeDialogView> ClosingDateTo { get; set; } 
        public IRPSComboBox<FiltersTreeDialogView> CodUserTeam { get; set; } 
        public IRPSComboBox<FiltersTreeDialogView> UIService { get; set; } 
        public IRPSComboBox<FiltersTreeDialogView> UIServiceEntity { get; set; } 
        public IRPSCollectionComboBox<FiltersTreeDialogView> CCHTypes { get; set; } 
        public IRPSTextBox<FiltersTreeDialogView> TextToSearch { get; set; } 
        public IRPSButton<FiltersTreeDialogView> CleanFiltersButton { get; set; } 
        public Channels Screen { get; set; }
        public FiltersTreeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FavouriteMessagesForUserDialogView : View
    {
        public FavouriteMessagesForUserDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetFavouriteMessagesForUser = new CollectionInit(){IDDescriptor = "4949f2c2-49ed-4ad0-9052-6b2aa30c8927",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0691680c-b90b-4484-b02a-1ec4b5e00c7a",CSSSelectorGrid="",XPathGrid=""};
            GetFavouriteMessagesForUser = RPSControlFactory.RPSCreateCollectionWithGrid<GetFavouriteMessagesForUserCollectionEditor<FavouriteMessagesForUserDialogView>,FavouriteMessagesForUserDialogView>( params_GetFavouriteMessagesForUser,this);
 

        }
        public GetFavouriteMessagesForUserCollectionEditor<FavouriteMessagesForUserDialogView> GetFavouriteMessagesForUser { get; set; } 
        public Channels Screen { get; set; }
        public FavouriteMessagesForUserDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetFavouriteMessagesForUserCollectionEditor<FavouriteMessagesForUserDialogView>:RPSCollectionEditor<FavouriteMessagesForUserDialogView> where FavouriteMessagesForUserDialogView : class, IView
    {
        public  GetFavouriteMessagesForUserGridView<FavouriteMessagesForUserDialogView> GridView {get;set;}
    }
    public partial class GetFavouriteMessagesForUserGridView <FavouriteMessagesForUserDialogView> :  RPSGridView<FavouriteMessagesForUserDialogView> where FavouriteMessagesForUserDialogView : class, IView
    {
        public GetFavouriteMessagesForUserGridView(FavouriteMessagesForUserDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DescriptionWithoutRichText = RPSControlFactory.CreateRPSGridTextBox<FavouriteMessagesForUserDialogView>("","#0691680c-b90b-4484-b02a-1ec4b5e00c7a .ag-row[role='row']@ROWINDEX [col-id='cDescriptionWithoutRichText']","",false, this.CurrentView);
 
            CCHMessage_MessageDate = RPSControlFactory.CreateRPSGridTextBox<FavouriteMessagesForUserDialogView>("","#0691680c-b90b-4484-b02a-1ec4b5e00c7a .ag-row[role='row']@ROWINDEX [col-id='cCCHMessage_MessageDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FavouriteMessagesForUserDialogView> DescriptionWithoutRichText { get; set; } 
        public IRPSGridTextBox<FavouriteMessagesForUserDialogView> CCHMessage_MessageDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class ExternalUserSettingsDialogView : View
    {
        public ExternalUserSettingsDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UserDescription = RPSControlFactory.CreateRPSTextBox<ExternalUserSettingsDialogView>("bb7c8119-2c36-4bb3-ab1e-2460b87b8981","","",true, this);
 
            UserPassword = RPSControlFactory.CreateRPSTextBox<ExternalUserSettingsDialogView>("3c3e5471-2ee8-47b5-be2d-d0cb19632812","","",true, this);
 
            UserLanguage = RPSControlFactory.CreateRPSComboBox<ExternalUserSettingsDialogView>("d6357f92-2c34-42cf-b609-9b68ace3aa73","","",true, this);
 
            UserEmail = RPSControlFactory.CreateRPSEmailTextBox<ExternalUserSettingsDialogView>("2a816dc0-f91a-4cdb-8821-a03a18e52c3b","","",true, this);
 

        }
        public IRPSTextBox<ExternalUserSettingsDialogView> UserDescription { get; set; } 
        public IRPSTextBox<ExternalUserSettingsDialogView> UserPassword { get; set; } 
        public IRPSComboBox<ExternalUserSettingsDialogView> UserLanguage { get; set; } 
        public IRPSTextBox<ExternalUserSettingsDialogView> UserEmail { get; set; } 
        public Channels Screen { get; set; }
        public ExternalUserSettingsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateNewChannelDialogView : View
    {
        public CreateNewChannelDialogView(Channels screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCCHType = RPSControlFactory.CreateRPSComboBox<CreateNewChannelDialogView>("dd07205a-c605-4a4c-9de3-e9531de0e7e9","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("0473d8bd-fb15-461e-a1fb-2c181377a4cb","","",true, this);
 
            UIService = RPSControlFactory.CreateRPSEnumComboBox<CreateNewChannelDialogView>("a78864dd-0e53-44bd-9f94-7a87ad43978b","","",false, this);
 
            UIServiceEntity = RPSControlFactory.CreateRPSEnumComboBox<CreateNewChannelDialogView>("111451fc-438f-48e5-b4bd-a181f155107f","","",false, this);
 
            Property1 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("c0ec7852-a2b3-4b2d-8476-cfc3328901c6","","",false, this);
 
            Property2 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("89cb0dbd-3494-4eba-b395-3104d327374b","","",false, this);
 
            Property3 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("477a117d-3ded-4101-b1a0-7f2de4010b5f","","",false, this);
 
            Property4 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("e7dbb2a7-6936-4b57-888a-83ad89234e8c","","",false, this);
 
            Property5 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("4960b240-d77b-4e74-ad3c-477c870c2f4a","","",false, this);
 
            Property6 = RPSControlFactory.CreateRPSTextBox<CreateNewChannelDialogView>("5c19fc86-f82e-48ba-a24c-ebdf72d77154","","",false, this);
 

        }
        public IRPSComboBox<CreateNewChannelDialogView> CodCCHType { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Description { get; set; } 
        public IRPSComboBox<CreateNewChannelDialogView> UIService { get; set; } 
        public IRPSComboBox<CreateNewChannelDialogView> UIServiceEntity { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property1 { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property2 { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property3 { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property4 { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property5 { get; set; } 
        public IRPSTextBox<CreateNewChannelDialogView> Property6 { get; set; } 
        public Channels Screen { get; set; }
        public CreateNewChannelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}
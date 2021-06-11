using vNextGermanyDistributorUT;
using Xunit;
using System;
using SeleniumGeneratedClasses.Framework.RPS.Services.General.Site ;
namespace UnitTest.Framework.RPS.Services.General
{
    public class Site_New: BaseTest
    {
        [Fact]        
        public void New_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Site.Site())
            {
                //Open the screen
                screen.NavigateToScreen<SiteCollectionView>()                   
                    .NewButton.Click()//Click the new button
                    .CodSite.Write("001")//Fill the CodSite field
                    .Description.Write("Test site")//Fill the description field
                    .IDCalendar.Select(0)//Select in the combo the first item of the dropdown
                    .Comments1.Click()//Go to the comments tab
                    .Comment.Write("Notes1")//Fill the comment fied
                    .DPS.Click()//Go to the DPS Tab
                    .Comments.Write("NotesDPS customiation")//Fill the comments field                   
                    .StartDateHol.Write("01/08/2021")//Fill the holidays start date
                    .EndDateHol.Write("31/08/2021")//Fill the holidays end dat
                    .SaveButton.Click()//Save the changes
                    .BackButton.Click()//Go to the main screen
                    .MainConsult.DescriptorView.Exists();//See if we are in the main screen
                
            }
            
            
            
        }
    }
    
    public class Site_Delete: BaseTest
    {
        [Fact]        
        public void Delete_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Site.Site())
            {
                

                screen.NavigateToScreen<SiteCollectionView>()
                    .MainConsult.DescriptorView.Click("Wardenburg")
                    .DeleteButton.Click()   
                    .ConfirmDeleteButton.Click()
                    .MainConsult.DescriptorView.Exists();
                
                
            }
            
            
        }
    }
}
using vNextGermanyDistributorUT;
using Xunit;
using System;
using SeleniumGeneratedClasses.Framework.RPS.Services.General.Category ;
namespace UnitTest.Framework.RPS.Services.General
{
    public class Category_New: BaseTest
    {
        [Fact]        
        public void New_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {
                screen.NavigateToScreen<CategoryCollectionView>()
                    .NewButton.Click()
                    .CodCategory.Write("X001")
                    .Description.Write("Test category")
                    .SaveButton.Click()
                    .BackButton.Click()
                    .MainConsult.DescriptorView.Exists();
                
            }
            
            //throw new NotImplementedException();
            
        }
    }    
    public class Category_Update: BaseTest
    {
        [Fact]        
        public void Update_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {
                string description = "";
                var main = screen.NavigateToScreen<CategoryCollectionView>();
                var detail = main.MainConsult.DescriptorView.Click("Azubi");
                detail = detail.Description.Read(out description);
                detail = detail.Description.Write(description + "Test");
                detail = detail.SaveButton.Click();
                main = detail.BackButton.Click();
                main = main.MainConsult.DescriptorView.Exists();
                    

                
            }
            
            

        }
    }
    public class Category_Delete: BaseTest
    {
        [Fact]        
        public void Delete_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {

                screen.NavigateToScreen<CategoryCollectionView>()
                    .MainConsult.DescriptorView.Click("Facharbeiter_in")
                    .DeleteButton.Click()
                    .ConfirmDeleteButton.Click()
                    .MainConsult.DescriptorView.Exists();
            }
            
           
        }
    }
}
using vNextGermanyDistributorUT;
using Xunit;
using System;
using SeleniumGeneratedClasses.Framework.RPS.Services.General.Category ;
namespace UnitTest.Framework.RPS.Services.General
{
    public class Category_New
    {
        [Fact]        
        public void New_UT()
        {
            
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {
                screen.NavigateToScreen<CategoryCollectionView>();
                
            }
            
            //throw new NotImplementedException();
            
        }
    }
    public class Category_Update
    {
        [Fact]        
        public void Update_UT()
        {
            /*
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {
                screen.NavigateToScreen<CategoryCollectionView>();
                
            }
            */
            throw new NotImplementedException();

        }
    }
    public class Category_Delete
    {
        [Fact]        
        public void Delete_UT()
        {
            /*
            var config = SeleniumConfig.Current;
            using (var screen = new SeleniumGeneratedClasses.Framework.RPS.Services.General.Category.Category())
            {
                screen.NavigateToScreen<CategoryCollectionView>();
                
            }
            */
            throw new NotImplementedException();
        }
    }
}
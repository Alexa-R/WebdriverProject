using NUnit.Framework;
using WebdriverProject.PageObjects;

namespace WebdriverProject.TestCases.ToDoLists
{
    [TestFixture]
    public class MainToDoList : BaseTest
    {
        [Test]
        public void CheckItemsListCountEqualFour()
        {
            Pages.HomePage.ClickToDoListLink();
            Pages.ToDoListPage.AddNewItem("NewItem1");
            Pages.ToDoListPage.AddNewItem("NewItem2");
            Pages.ToDoListPage.RemoveLastItem(); 
           
            Assert.AreEqual(4, Pages.ToDoListPage.GetItemsListCount());
        }
    }
}
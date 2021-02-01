using OpenQA.Selenium.Support.PageObjects;
using WebdriverProject.WrapperFactory;

namespace WebdriverProject.PageObjects
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.Driver, page);

            return page;
        }

        public static HomePage HomePage => GetPage<HomePage>();

        public static LoginPortalPage LoginPortalPage => GetPage<LoginPortalPage>();

        public static AccordionPage AccordionPage => GetPage<AccordionPage>();

        public static DropdownCheckboxesRadioButtonsPage DropdownCheckboxesRadioButtonsPage => GetPage<DropdownCheckboxesRadioButtonsPage>();
        
        public static AjaxLoaderPage AjaxLoaderPage => GetPage<AjaxLoaderPage>();

        public static ActionsPage ActionsPage => GetPage<ActionsPage>();
        
        public static PopupAlertsPage PopupAlertsPage => GetPage<PopupAlertsPage>();

        public static FramePage FramePage => GetPage<FramePage>();

        public static FileUploadPage FileUploadPage => GetPage<FileUploadPage>();

        public static ToDoListPage ToDoListPage => GetPage<ToDoListPage>();
    }
}

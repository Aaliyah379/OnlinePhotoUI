using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace OnlinePhotoUI
{
   public class OnlineTest
    { 
        [Fact]
        [Trait ("category","Smoke")]
        public void LoadingApplicationPage()
        {
            using (IWebDriver driver =  new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://passport-photo.online");

                DemoHelper.Pause();

                string pageTitle = driver.Title;

                Assert.Equal("Фотографии для паспорта и визы онлайн - Passport-Photo.online", pageTitle);
                Assert.Equal("https://passport-photo.online/ru-ru/blog/", driver.Url);
            }

        }
    }
}

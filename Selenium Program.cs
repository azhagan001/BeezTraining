using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.theloopdutyfree.co.nz/spirits-and-wine/?lang=en_NZ");


            IList<IWebElement>  ProductBrand = driver.FindElements(By.ClassName("b-product__brand-name-link"));
            IList<IWebElement> ProductName = driver.FindElements(By.ClassName("b-product__product-name-link"));
            IList<IWebElement> ProductPrice = driver.FindElements(By.ClassName("b-price__sales-price"));
            
            string[] ProductText = new string[ProductBrand.Count];
            string[] ProductDetail = new string[ProductName.Count];
            string[] ProductPrices = new string[ProductPrice.Count];


            for (int i = 0; i < ProductBrand.Count; i++)
            {
                ProductText[i] = ProductBrand[i].Text;
                ProductDetail[i] = ProductName[i].Text;
                ProductPrices[i] = ProductPrice[i].Text;
            }
            for (int i = 0; i < ProductBrand.Count; i++)
            {
                Console.WriteLine(i + 1);
                Console.WriteLine("Product Brand:" + ProductBrand[i].Text);
                Console.WriteLine("Product Name:" + ProductName[i].Text);
                Console.WriteLine("Product Prize:" + ProductPrice[i].Text);
            }
        }
    }
}

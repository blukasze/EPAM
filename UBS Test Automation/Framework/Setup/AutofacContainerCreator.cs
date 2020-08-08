using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;
using UBS_Test_Automation.Pages;

namespace UBS_Test_Automation.Framework.Setup
{
    public static class AutofacContainerCreator
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ChromeDriver>().As<IWebDriver>().SingleInstance();

            containerBuilder.RegisterType<ConfigReader>().SingleInstance();

            var pages = typeof(AutofacContainerCreator).Assembly.GetTypes()
                .Where(t => t == typeof(BasePage))
                .ToArray();
            containerBuilder
                .RegisterTypes(pages)
                .SingleInstance();
            
            var bindings = typeof(AutofacContainerCreator).Assembly.GetTypes()
                .Where(t => Attribute.IsDefined(t, typeof(BindingAttribute)))
                .ToArray();
            containerBuilder
                .RegisterTypes(bindings)
                .SingleInstance();
            return containerBuilder;
        }
    }
}

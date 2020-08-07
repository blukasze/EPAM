using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;

namespace UBS_Test_Automation.Framework.Setup
{
    public static class AutofacContainerCreator
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ChromeDriver>().As<IWebDriver>().SingleInstance();

            //We're registering all test classes from assembly with [Binding] annotation
            containerBuilder
                .RegisterTypes(typeof(AutofacContainerCreator).Assembly.GetTypes()
                    .Where(t => Attribute.IsDefined(t, typeof(BindingAttribute)))
                    .ToArray())
                .SingleInstance();
            return containerBuilder;
        }
    }
}

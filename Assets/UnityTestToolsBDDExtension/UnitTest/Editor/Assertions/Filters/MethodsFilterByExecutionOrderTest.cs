﻿using System.Reflection;
using NUnit.Framework;

namespace HudDimension.UnityTestBDD
{
    [TestFixture]
    public class MethodsFilterByExecutionOrderTest
    {
        [Test(Author = "AlessioLangiu")]
        [Description("Filter method should return true given a Static component for a Given method filtering Given methods")]
        public void Filter_Should_ReturnTrue_Given_AStaticComponentForAGivenMethodFilteringGivenMethods()
        {
            MethodsFilterByExecutionOrderTestStaticComponent component = UnitTestUtility.CreateComponent<MethodsFilterByExecutionOrderTestStaticComponent>();
            MethodInfo methodInfo = component.GetType().GetMethod("GivenMethod");
            MethodsFilterByExecutionOrder methodsFilterByExecutionOrder = new MethodsFilterByExecutionOrder();
            bool result = methodsFilterByExecutionOrder.Filter<GivenBaseAttribute>(methodInfo);
            Assert.AreEqual(true, result, "The method MethodsFilterByStepType.Filter does not return the right answer");
        }

        [Test(Author = "AlessioLangiu")]
        [Description("Filter method should return false given a Static component for a Given method filtering When methods")]
        public void Filter_Should_ReturnTrue_Given_AStaticComponentForAGivenMethodFilteringWhenMethods()
        {
            MethodsFilterByExecutionOrderTestStaticComponent component = UnitTestUtility.CreateComponent<MethodsFilterByExecutionOrderTestStaticComponent>();
            MethodInfo methodInfo = component.GetType().GetMethod("GivenMethod");

            MethodsFilterByExecutionOrder methodsFilterByExecutionOrder = new MethodsFilterByExecutionOrder();
            bool result = methodsFilterByExecutionOrder.Filter<WhenBaseAttribute>(methodInfo);
            Assert.AreEqual(false, result, "The method MethodsFilterByStepType.Filter does not return the right answer");
        }

        [Test(Author = "AlessioLangiu")]
        [Description("Filter method should return false given a Static component for a Generic method filtering When methods")]
        public void Filter_Should_ReturnTrue_Given_AStaticComponentForAGenericMethodFilteringWhenMethods()
        {
            MethodsFilterByExecutionOrderTestStaticComponent component = UnitTestUtility.CreateComponent<MethodsFilterByExecutionOrderTestStaticComponent>();
            MethodInfo methodInfo = component.GetType().GetMethod("SecondWhenMethod");

            MethodsFilterByExecutionOrder methodsFilterByExecutionOrder = new MethodsFilterByExecutionOrder();
            bool result = methodsFilterByExecutionOrder.Filter<WhenBaseAttribute>(methodInfo);
            Assert.AreEqual(false, result, "The method MethodsFilterByStepType.Filter does not return the right answer");
        }

        [Test(Author = "AlessioLangiu")]
        [Description("Filter method should return false given a Dynamic component for a Given method filtering Given methods")]
        public void Filter_Should_ReturnTrue_Given_ADynamicComponentForAGivenMethodFilteringGivenMethods()
        {
            MethodsFilterByExecutionOrderTestDynamicComponent component = UnitTestUtility.CreateComponent<MethodsFilterByExecutionOrderTestDynamicComponent>();
            MethodInfo methodInfo = component.GetType().GetMethod("GivenMethod");

            MethodsFilterByExecutionOrder methodsFilterByExecutionOrder = new MethodsFilterByExecutionOrder();
            bool result = methodsFilterByExecutionOrder.Filter<GivenBaseAttribute>(methodInfo);
            Assert.AreEqual(false, result, "The method MethodsFilterByStepType.Filter does not return the right answer");
        }
    }
}
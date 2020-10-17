﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject3.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        private readonly ScenarioContext scenarioContext;

        public StepDefinition1(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            Console.WriteLine(number1);
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            Console.WriteLine(number2);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Pressed the add button");
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if (result == 120)
            {
                Console.WriteLine("The test Passed");
            }
            else
            {
                Console.WriteLine("The test fail");
                throw new Exception("The wrong value");
            }
        }

        [When(@"I fill all the mandatory details")]
        public void WhenIFillAllTheMandatoryDetails(Table table)
        {

            //EmployeesDetails details =  table.CreateInstance<EmployeesDetails>();

            //Console.WriteLine(details.Age);
            //Console.WriteLine(details.Email);
            //Console.WriteLine(details.Name);
            //Console.WriteLine(details.Phone);

            var details = table.CreateSet<EmployeesDetails>();

            foreach (EmployeesDetails emp in details)
            {
                Console.WriteLine("");
                Console.WriteLine("The details of employeees :" + emp.Name);
                Console.WriteLine("========================================");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
                Console.WriteLine("=========================================");
                Console.WriteLine("");

                


            }

        }
        [When(@"I fiil all the mandatory details (.*), (.*) and (.*)")]
        public void WhenIFiilAllTheMandatoryDetailsAnd(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
            scenarioContext["InfoforNextStep"] = "Step1 Passed";
            Console.WriteLine(scenarioContext["InfoforNextStep"].ToString());
        }

    }
}
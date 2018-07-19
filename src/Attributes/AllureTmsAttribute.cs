﻿using System;
using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace NUnit.Allure.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AllureTmsAttribute : NUnitAttribute
    {
        public AllureTmsAttribute(string name, string url = null)
        {
            TmsLink = new Link { name = name, type = "tms", url = url };
        }

        internal Link TmsLink { get; }
    }
}
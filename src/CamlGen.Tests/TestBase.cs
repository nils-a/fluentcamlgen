﻿/***
This File is part of FluentCamlGen

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
***/

using AutoFixture;

using NUnit.Framework;

namespace FluentCamlGen.CamlGen.Test
{
    public class TestBase
    {
        protected Fixture Fixture { get; private set; }

        [SetUp]
        public void SetUp()
        {
            Fixture = new Fixture();
            Fixture.Customize(new TestCgCustomization());
        }
    }
}
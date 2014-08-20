﻿/***
This File is part of FluentCamlGen

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
***/

using FluentAssertions;
using FluentCamlGen.CamlGen.Elements.Core;
using NUnit.Framework;

namespace FluentCamlGen.CamlGen.Test.Elements.Core
{
    [TestFixture]
    public class WhereTests : TestBase
    {
        [Test]
        public void CgWhereReturnsAnEmptyWhereTag()
        {
            var sut = CG.Where();
            sut.ToString().Should().BeEquivalentTo(@"<Where />");
        }

        [Test]
        public void AndOnAWhereTagReturnsTheNestedTags()
        {
            var sut = new Where();
            sut.And();

            sut.ToString().Should().BeEquivalentTo(@"<Where><And /></Where>");
        }
    }
}
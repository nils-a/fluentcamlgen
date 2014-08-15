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
using NUnit.Framework;

namespace FluentCamlGen.CamlGen.Test
{
    [TestFixture]
    public class ProjectedFieldsFieldsTests : TestBase
    {
        [Test]
        public void BareCgProjectedFieldsReturnsAProjectedFieldsTagWithNoAttributes()
        {
            var sut = CG.ProjectedFields();
            sut.ToString().Should().BeEquivalentTo(@"<ProjectedFields />");
        }
    }
}
﻿/***
This File is part of FluentCamlGen

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
***/

using System;
using FluentCamlGen.CamlGen.Elements;
using FluentCamlGen.CamlGen.Elements.Core;
using FluentCamlGen.CamlGen.Elements.Value;

namespace FluentCamlGen.CamlGen
{
    /// <summary>
    /// CamlGenerator
    /// See <seealso cref="http://msdn.microsoft.com/en-us/library/ms462365(v=office.15).aspx"/> for a caml reference
    /// </summary>
    public class CG
    {

        /// <summary>
        /// Create &lt;View> ... &lt;/View> for ViewXml
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static View View(params BaseElement[] inner)
        {
            return new View(inner);
        }

        /// <summary>
        /// Create &lt;Query> ... &lt;/Query>
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Query Query(params BaseElement[] inner)
        {
            return new Query(inner);
        }

        /// <summary>
        /// Create &lt;ViewFields> ... &lt;/ViewFields>
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static ViewFields ViewFields(params BaseElement[] inner)
        {
            return new ViewFields(inner);
        }

        /// <summary>
        /// Create &lt;ProjectedFields> ... &lt;/ProjectedFields>
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static ProjectedFields ProjectedFields(params BaseElement[] inner)
        {
            return new ProjectedFields(inner);
        }

        /// <summary>
        /// Create &lt;Joins> ... &lt;/Joins>
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Joins Joins(params BaseElement[] inner)
        {
            return new Joins(inner);
        }

        /// <summary>
        /// Create &lt;FieldRef Name="..." ... />
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static FieldRef FieldRef(string name, params Tuple<string, string>[] additionalAttributes)
        {
            return new FieldRef(name, additionalAttributes);
        }

        /// <summary>
        /// Create &lt;Field Name="..." Type="..." List="..." ShowField="..." />
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static ProjectedField ProjectedField(string name, string type, string list, string showFileld)
        {
            return new ProjectedField(name, type, list, showFileld);
        }


        /// <summary>
        /// Create &lt;Join Type="..." ListAlias="...">
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Join Join(string listName, Join.JoinType type, BaseElement lhs, BaseElement rhs)
        {
            return new Join(listName, type, lhs, rhs);
        }

        /// <summary>
        /// Create &lt;Join Type="..." ListAlias="...">
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Join Join(string listName, Join.JoinType type, string joinField)
        {
            return new Join(listName, type, joinField);
        }

        /// <summary>
        /// Create &lt;Join Type="INNER" ListAlias="...">
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Join InnerJoin(string listName, string joinField)
        {
            return Join(listName, Elements.Core.Join.JoinType.Inner, joinField);
        }

        /// <summary>
        /// &lt;Eq> ... &lt;/Eq>
        /// </summary>
        /// <returns><see cref="BaseElement"/></returns>
        public static Eq Eq(BaseElement lhs, BaseElement rhs)
        {
            return new Eq(lhs, rhs);
        }

        /// <summary>
        /// &lt;QueryOptions> ... &lt;/QueryOptions>
        /// </summary>
        /// <param name="values"></param>
        /// <returns><see cref="BaseElement"/></returns>
        public static QueryOptions QueryOptions(params BaseValueElement[] values)
        {
            return new QueryOptions(values);
        }

        /// <summary>
        /// &lt;ExpandUserField>True|False&lt;/ExpandUserField>
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="BaseElement"/></returns>
        public static ExpandUserField ExpandUserField(bool value)
        {
            return new ExpandUserField(value);
        }

        /// <summary>
        /// &lt;DatesInUtc>True|False&lt;/DatesInUtc>
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="BaseElement"/></returns>
        public static DatesInUtc DatesInUtc(bool value)
        {
            return new DatesInUtc(value);
        }
    }
}
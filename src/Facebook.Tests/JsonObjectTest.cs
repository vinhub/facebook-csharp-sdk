// <copyright file="JsonObjectTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for JsonObject</summary>
    [PexClass(typeof(JsonObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonObjectTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public JsonObject Constructor()
        {
            JsonObject target = new JsonObject();
            return target;
            // TODO: add assertions to method JsonObjectTest.Constructor()
        }

        /// <summary>Test stub for .ctor(Object[])</summary>
        [PexMethod]
        public JsonObject Constructor01(object[] nameValuePairs)
        {
            JsonObject target = new JsonObject(nameValuePairs);
            return target;
            // TODO: add assertions to method JsonObjectTest.Constructor01(Object[])
        }

        /// <summary>Test stub for ContainsKey(String)</summary>
        [PexMethod]
        public bool ContainsKey([PexAssumeUnderTest]JsonObject target, string key)
        {
            bool result = target.ContainsKey(key);
            return result;
            // TODO: add assertions to method JsonObjectTest.ContainsKey(JsonObject, String)
        }

        /// <summary>Test stub for Count</summary>
        [PexMethod]
        public void CountGet([PexAssumeUnderTest]JsonObject target)
        {
            int result = target.Count;
            // TODO: add assertions to method JsonObjectTest.CountGet(JsonObject)
        }

        /// <summary>Test stub for GetDynamicMemberNames()</summary>
        [PexMethod]
        public IEnumerable<string> GetDynamicMemberNames([PexAssumeUnderTest]JsonObject target)
        {
            IEnumerable<string> result = target.GetDynamicMemberNames();
            return result;
            // TODO: add assertions to method JsonObjectTest.GetDynamicMemberNames(JsonObject)
        }

        /// <summary>Test stub for Item</summary>
        [PexMethod]
        public void ItemGetSet(
            [PexAssumeUnderTest]JsonObject target,
            string key,
            object value
        )
        {
            target[key] = value;
            object result = target[key];
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method JsonObjectTest.ItemGetSet(JsonObject, String, Object)
        }

        /// <summary>Test stub for TryConvert(ConvertBinder, Object&amp;)</summary>
        [PexMethod]
        public bool TryConvert(
            [PexAssumeUnderTest]JsonObject target,
            ConvertBinder binder,
            out object result
        )
        {
            bool result01 = target.TryConvert(binder, out result);
            return result01;
            // TODO: add assertions to method JsonObjectTest.TryConvert(JsonObject, ConvertBinder, Object&)
        }

        /// <summary>Test stub for TryDeleteMember(DeleteMemberBinder)</summary>
        [PexMethod]
        public bool TryDeleteMember(
            [PexAssumeUnderTest]JsonObject target,
            DeleteMemberBinder binder
        )
        {
            bool result = target.TryDeleteMember(binder);
            return result;
            // TODO: add assertions to method JsonObjectTest.TryDeleteMember(JsonObject, DeleteMemberBinder)
        }

        /// <summary>Test stub for TryGetIndex(GetIndexBinder, Object[], Object&amp;)</summary>
        [PexMethod]
        public bool TryGetIndex(
            [PexAssumeUnderTest]JsonObject target,
            GetIndexBinder binder,
            object[] indexes,
            out object result
        )
        {
            bool result01 = target.TryGetIndex(binder, indexes, out result);
            return result01;
            // TODO: add assertions to method JsonObjectTest.TryGetIndex(JsonObject, GetIndexBinder, Object[], Object&)
        }

        /// <summary>Test stub for TryGetMember(GetMemberBinder, Object&amp;)</summary>
        [PexMethod]
        public bool TryGetMember(
            [PexAssumeUnderTest]JsonObject target,
            GetMemberBinder binder,
            out object result
        )
        {
            bool result01 = target.TryGetMember(binder, out result);
            return result01;
            // TODO: add assertions to method JsonObjectTest.TryGetMember(JsonObject, GetMemberBinder, Object&)
        }

        /// <summary>Test stub for TrySetIndex(SetIndexBinder, Object[], Object)</summary>
        [PexMethod]
        public bool TrySetIndex(
            [PexAssumeUnderTest]JsonObject target,
            SetIndexBinder binder,
            object[] indexes,
            object value
        )
        {
            bool result = target.TrySetIndex(binder, indexes, value);
            return result;
            // TODO: add assertions to method JsonObjectTest.TrySetIndex(JsonObject, SetIndexBinder, Object[], Object)
        }

        /// <summary>Test stub for TrySetMember(SetMemberBinder, Object)</summary>
        [PexMethod]
        public bool TrySetMember(
            [PexAssumeUnderTest]JsonObject target,
            SetMemberBinder binder,
            object value
        )
        {
            bool result = target.TrySetMember(binder, value);
            return result;
            // TODO: add assertions to method JsonObjectTest.TrySetMember(JsonObject, SetMemberBinder, Object)
        }
    }
}

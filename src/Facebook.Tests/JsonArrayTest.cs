// <copyright file="JsonArrayTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Dynamic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for JsonArray</summary>
    [PexClass(typeof(JsonArray))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonArrayTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public JsonArray Constructor()
        {
            JsonArray target = new JsonArray();
            return target;
            // TODO: add assertions to method JsonArrayTest.Constructor()
        }

        /// <summary>Test stub for .ctor(Object)</summary>
        [PexMethod]
        public JsonArray Constructor01(object o)
        {
            JsonArray target = new JsonArray(o);
            return target;
            // TODO: add assertions to method JsonArrayTest.Constructor01(Object)
        }

        /// <summary>Test stub for .ctor(Object, Object)</summary>
        [PexMethod]
        public JsonArray Constructor02(object o1, object o2)
        {
            JsonArray target = new JsonArray(o1, o2);
            return target;
            // TODO: add assertions to method JsonArrayTest.Constructor02(Object, Object)
        }

        /// <summary>Test stub for .ctor(Object[])</summary>
        [PexMethod]
        public JsonArray Constructor03(object[] objects)
        {
            JsonArray target = new JsonArray(objects);
            return target;
            // TODO: add assertions to method JsonArrayTest.Constructor03(Object[])
        }

        /// <summary>Test stub for Count</summary>
        [PexMethod]
        public void CountGet([PexAssumeUnderTest]JsonArray target)
        {
            int result = target.Count;
            // TODO: add assertions to method JsonArrayTest.CountGet(JsonArray)
        }

        /// <summary>Test stub for Item</summary>
        [PexMethod]
        public void ItemGet([PexAssumeUnderTest]JsonArray target, int index)
        {
            object result = target[index];
            // TODO: add assertions to method JsonArrayTest.ItemGet(JsonArray, Int32)
        }

        /// <summary>Test stub for TryConvert(ConvertBinder, Object&amp;)</summary>
        [PexMethod]
        public bool TryConvert(
            [PexAssumeUnderTest]JsonArray target,
            ConvertBinder binder,
            out object result
        )
        {
            bool result01 = target.TryConvert(binder, out result);
            return result01;
            // TODO: add assertions to method JsonArrayTest.TryConvert(JsonArray, ConvertBinder, Object&)
        }

        /// <summary>Test stub for TryGetIndex(GetIndexBinder, Object[], Object&amp;)</summary>
        [PexMethod]
        public bool TryGetIndex(
            [PexAssumeUnderTest]JsonArray target,
            GetIndexBinder binder,
            object[] indexes,
            out object result
        )
        {
            bool result01 = target.TryGetIndex(binder, indexes, out result);
            return result01;
            // TODO: add assertions to method JsonArrayTest.TryGetIndex(JsonArray, GetIndexBinder, Object[], Object&)
        }

        /// <summary>Test stub for TryGetMember(GetMemberBinder, Object&amp;)</summary>
        [PexMethod]
        public bool TryGetMember(
            [PexAssumeUnderTest]JsonArray target,
            GetMemberBinder binder,
            out object result
        )
        {
            bool result01 = target.TryGetMember(binder, out result);
            return result01;
            // TODO: add assertions to method JsonArrayTest.TryGetMember(JsonArray, GetMemberBinder, Object&)
        }

        /// <summary>Test stub for TryInvokeMember(InvokeMemberBinder, Object[], Object&amp;)</summary>
        [PexMethod]
        public bool TryInvokeMember(
            [PexAssumeUnderTest]JsonArray target,
            InvokeMemberBinder binder,
            object[] args,
            out object result
        )
        {
            bool result01 = target.TryInvokeMember(binder, args, out result);
            return result01;
            // TODO: add assertions to method JsonArrayTest.TryInvokeMember(JsonArray, InvokeMemberBinder, Object[], Object&)
        }

        /// <summary>Test stub for TrySetIndex(SetIndexBinder, Object[], Object)</summary>
        [PexMethod]
        public bool TrySetIndex(
            [PexAssumeUnderTest]JsonArray target,
            SetIndexBinder binder,
            object[] indexes,
            object value
        )
        {
            bool result = target.TrySetIndex(binder, indexes, value);
            return result;
            // TODO: add assertions to method JsonArrayTest.TrySetIndex(JsonArray, SetIndexBinder, Object[], Object)
        }
    }
}

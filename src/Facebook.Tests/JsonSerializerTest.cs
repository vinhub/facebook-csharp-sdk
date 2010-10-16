// <copyright file="JsonSerializerTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for JsonSerializer</summary>
    [PexClass(typeof(JsonSerializer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonSerializerTest
    {
        /// <summary>Test stub for DeserializeObject(Stream)</summary>
        [PexMethod(MaxBranches = 20000), PexAllowedException(typeof(FormatException))]
        internal object DeserializeObject(Stream stream)
        {
            object result = JsonSerializer.DeserializeObject(stream);
            return result;
            // TODO: add assertions to method JsonSerializerTest.DeserializeObject(Stream)
        }

        /// <summary>Test stub for DeserializeObject(String)</summary>
        [PexMethod]
        internal object DeserializeObject01(string json)
        {
            object result = JsonSerializer.DeserializeObject(json);
            return result;
            // TODO: add assertions to method JsonSerializerTest.DeserializeObject01(String)
        }

        /// <summary>Test stub for SerializeObject(Object)</summary>
        [PexMethod]
        internal string SerializeObject(object value)
        {
            string result = JsonSerializer.SerializeObject(value);
            return result;
            // TODO: add assertions to method JsonSerializerTest.SerializeObject(Object)
        }
    }
}

// <copyright file="HttpMethodHelperTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for HttpMethodHelper</summary>
    [PexClass(typeof(StringUtilities))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class HttpMethodHelperTest
    {
        /// <summary>Test stub for ConvertToString(HttpMethod)</summary>
        [PexMethod]
        internal string ConvertToString(HttpMethod httpMethod)
        {
            string result = StringUtilities.ConvertToString(httpMethod);
            return result;
            // TODO: add assertions to method HttpMethodHelperTest.ConvertToString(HttpMethod)
        }
    }
}

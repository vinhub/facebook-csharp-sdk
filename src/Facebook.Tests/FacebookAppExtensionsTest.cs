// <copyright file="FacebookAppExtensionsTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookAppExtensions</summary>
    [PexClass(typeof(FacebookAppExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookAppExtensionsTest
    {
        /// <summary>Test stub for Fql(FacebookApp, String)</summary>
        [PexMethod]
        public object Fql(FacebookApp app, string query)
        {
            object result = FacebookAppExtensions.Fql(app, query);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Fql(FacebookApp, String)
        }

        /// <summary>Test stub for Fql(FacebookApp, String[])</summary>
        [PexMethod(MaxConditions = 1000, MaxBranches = 20000)]
        public object Fql01(FacebookApp app, string[] queries)
        {
            object result = FacebookAppExtensions.Fql(app, queries);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Fql01(FacebookApp, String[])
        }
    }
}

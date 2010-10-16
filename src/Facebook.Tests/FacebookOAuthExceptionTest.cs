// <copyright file="FacebookOAuthExceptionTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookOAuthException</summary>
    [PexClass(typeof(FacebookOAuthException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookOAuthExceptionTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public FacebookOAuthException Constructor(string message)
        {
            FacebookOAuthException target = new FacebookOAuthException(message);
            return target;
            // TODO: add assertions to method FacebookOAuthExceptionTest.Constructor(String)
        }

        /// <summary>Test stub for .ctor(String, String)</summary>
        [PexMethod]
        public FacebookOAuthException Constructor01(string message, string errorType)
        {
            FacebookOAuthException target = new FacebookOAuthException(message, errorType);
            return target;
            // TODO: add assertions to method FacebookOAuthExceptionTest.Constructor01(String, String)
        }

        /// <summary>Test stub for .ctor(String, Exception)</summary>
        [PexMethod]
        public FacebookOAuthException Constructor02(string message, Exception innerException)
        {
            FacebookOAuthException target
               = new FacebookOAuthException(message, innerException);
            return target;
            // TODO: add assertions to method FacebookOAuthExceptionTest.Constructor02(String, Exception)
        }

        /// <summary>Test stub for .ctor(String, String, Exception)</summary>
        [PexMethod]
        public FacebookOAuthException Constructor03(
            string message,
            string errorType,
            Exception innerException
        )
        {
            FacebookOAuthException target
               = new FacebookOAuthException(message, errorType, innerException);
            return target;
            // TODO: add assertions to method FacebookOAuthExceptionTest.Constructor03(String, String, Exception)
        }
    }
}

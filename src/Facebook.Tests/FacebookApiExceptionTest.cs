// <copyright file="FacebookApiExceptionTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookApiException</summary>
    [PexClass(typeof(FacebookApiException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookApiExceptionTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public FacebookApiException Constructor(string message)
        {
            FacebookApiException target = new FacebookApiException(message);
            return target;
            // TODO: add assertions to method FacebookApiExceptionTest.Constructor(String)
        }

        /// <summary>Test stub for .ctor(String, String)</summary>
        [PexMethod]
        public FacebookApiException Constructor01(string message, string errorType)
        {
            FacebookApiException target = new FacebookApiException(message, errorType);
            return target;
            // TODO: add assertions to method FacebookApiExceptionTest.Constructor01(String, String)
        }

        /// <summary>Test stub for .ctor(String, Exception)</summary>
        [PexMethod]
        public FacebookApiException Constructor02(string message, Exception innerException)
        {
            FacebookApiException target = new FacebookApiException(message, innerException);
            return target;
            // TODO: add assertions to method FacebookApiExceptionTest.Constructor02(String, Exception)
        }

        /// <summary>Test stub for .ctor(String, String, Exception)</summary>
        [PexMethod]
        public FacebookApiException Constructor03(
            string message,
            string errorType,
            Exception innerException
        )
        {
            FacebookApiException target
               = new FacebookApiException(message, errorType, innerException);
            return target;
            // TODO: add assertions to method FacebookApiExceptionTest.Constructor03(String, String, Exception)
        }

        /// <summary>Test stub for ErrorType</summary>
        [PexMethod]
        public void ErrorTypeGetSet([PexAssumeUnderTest]FacebookApiException target, string value)
        {
            target.ErrorType = value;
            string result = target.ErrorType;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookApiExceptionTest.ErrorTypeGetSet(FacebookApiException, String)
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToString01([PexAssumeUnderTest]FacebookApiException target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method FacebookApiExceptionTest.ToString01(FacebookApiException)
        }
    }
}

// <copyright file="FacebookSettingsTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookSettings</summary>
    [PexClass(typeof(FacebookSettings))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookSettingsTest
    {
        /// <summary>Test stub for ApiKey</summary>
        [PexMethod]
        public void ApiKeyGetSet([PexAssumeUnderTest]FacebookSettings target, string value)
        {
            target.ApiKey = value;
            string result = target.ApiKey;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.ApiKeyGetSet(FacebookSettings, String)
        }

        /// <summary>Test stub for ApiSecret</summary>
        [PexMethod]
        public void ApiSecretGetSet([PexAssumeUnderTest]FacebookSettings target, string value)
        {
            target.ApiSecret = value;
            string result = target.ApiSecret;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.ApiSecretGetSet(FacebookSettings, String)
        }

        /// <summary>Test stub for AppId</summary>
        [PexMethod]
        public void AppIdGetSet([PexAssumeUnderTest]FacebookSettings target, string value)
        {
            target.AppId = value;
            string result = target.AppId;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.AppIdGetSet(FacebookSettings, String)
        }

        /// <summary>Test stub for BaseDomain</summary>
        [PexMethod]
        public void BaseDomainGetSet([PexAssumeUnderTest]FacebookSettings target, string value)
        {
            target.BaseDomain = value;
            string result = target.BaseDomain;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.BaseDomainGetSet(FacebookSettings, String)
        }

        /// <summary>Test stub for CookieSupport</summary>
        [PexMethod]
        public void CookieSupportGetSet([PexAssumeUnderTest]FacebookSettings target, bool value)
        {
            target.CookieSupport = value;
            bool result = target.CookieSupport;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.CookieSupportGetSet(FacebookSettings, Boolean)
        }

        /// <summary>Test stub for Current</summary>
        [PexMethod]
        public void CurrentGet()
        {
            IFacebookSettings result = FacebookSettings.Current;
            // TODO: add assertions to method FacebookSettingsTest.CurrentGet()
        }

        /// <summary>Test stub for MaxRetries</summary>
        [PexMethod]
        public void MaxRetriesGetSet([PexAssumeUnderTest]FacebookSettings target, int value)
        {
            target.MaxRetries = value;
            int result = target.MaxRetries;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.MaxRetriesGetSet(FacebookSettings, Int32)
        }

        /// <summary>Test stub for RetryDelay</summary>
        [PexMethod]
        public void RetryDelayGetSet([PexAssumeUnderTest]FacebookSettings target, int value)
        {
            target.RetryDelay = value;
            int result = target.RetryDelay;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookSettingsTest.RetryDelayGetSet(FacebookSettings, Int32)
        }
    }
}

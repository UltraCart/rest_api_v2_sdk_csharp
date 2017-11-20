/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;
using com.ultracart.admin.v2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.ultracart.admin.v2.Test
{
    /// <summary>
    ///  Class for testing Customer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CustomerTests
    {
        // TODO uncomment below to declare an instance variable for Customer
        //private Customer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Customer
            //instance = new Customer();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Customer
        /// </summary>
        [Test]
        public void CustomerInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Customer
            //Assert.IsInstanceOfType<Customer> (instance, "variable 'instance' is a Customer");
        }


        /// <summary>
        /// Test the property 'AffiliateOid'
        /// </summary>
        [Test]
        public void AffiliateOidTest()
        {
            // TODO unit test for the property 'AffiliateOid'
        }
        /// <summary>
        /// Test the property 'Allow3rdPartyBilling'
        /// </summary>
        [Test]
        public void Allow3rdPartyBillingTest()
        {
            // TODO unit test for the property 'Allow3rdPartyBilling'
        }
        /// <summary>
        /// Test the property 'AllowCod'
        /// </summary>
        [Test]
        public void AllowCodTest()
        {
            // TODO unit test for the property 'AllowCod'
        }
        /// <summary>
        /// Test the property 'AllowPurchaseOrder'
        /// </summary>
        [Test]
        public void AllowPurchaseOrderTest()
        {
            // TODO unit test for the property 'AllowPurchaseOrder'
        }
        /// <summary>
        /// Test the property 'AllowQuoteRequest'
        /// </summary>
        [Test]
        public void AllowQuoteRequestTest()
        {
            // TODO unit test for the property 'AllowQuoteRequest'
        }
        /// <summary>
        /// Test the property 'AllowSelectionOfAddressType'
        /// </summary>
        [Test]
        public void AllowSelectionOfAddressTypeTest()
        {
            // TODO unit test for the property 'AllowSelectionOfAddressType'
        }
        /// <summary>
        /// Test the property 'AutoApproveCod'
        /// </summary>
        [Test]
        public void AutoApproveCodTest()
        {
            // TODO unit test for the property 'AutoApproveCod'
        }
        /// <summary>
        /// Test the property 'AutoApprovePurchaseOrder'
        /// </summary>
        [Test]
        public void AutoApprovePurchaseOrderTest()
        {
            // TODO unit test for the property 'AutoApprovePurchaseOrder'
        }
        /// <summary>
        /// Test the property 'AutomaticMerchantNotes'
        /// </summary>
        [Test]
        public void AutomaticMerchantNotesTest()
        {
            // TODO unit test for the property 'AutomaticMerchantNotes'
        }
        /// <summary>
        /// Test the property 'Billing'
        /// </summary>
        [Test]
        public void BillingTest()
        {
            // TODO unit test for the property 'Billing'
        }
        /// <summary>
        /// Test the property 'BusinessNotes'
        /// </summary>
        [Test]
        public void BusinessNotesTest()
        {
            // TODO unit test for the property 'BusinessNotes'
        }
        /// <summary>
        /// Test the property 'Cards'
        /// </summary>
        [Test]
        public void CardsTest()
        {
            // TODO unit test for the property 'Cards'
        }
        /// <summary>
        /// Test the property 'CustomerProfileOid'
        /// </summary>
        [Test]
        public void CustomerProfileOidTest()
        {
            // TODO unit test for the property 'CustomerProfileOid'
        }
        /// <summary>
        /// Test the property 'DhlAccountNumber'
        /// </summary>
        [Test]
        public void DhlAccountNumberTest()
        {
            // TODO unit test for the property 'DhlAccountNumber'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'ExemptShippingHandlingCharge'
        /// </summary>
        [Test]
        public void ExemptShippingHandlingChargeTest()
        {
            // TODO unit test for the property 'ExemptShippingHandlingCharge'
        }
        /// <summary>
        /// Test the property 'FedexAccountNumber'
        /// </summary>
        [Test]
        public void FedexAccountNumberTest()
        {
            // TODO unit test for the property 'FedexAccountNumber'
        }
        /// <summary>
        /// Test the property 'FreeShipping'
        /// </summary>
        [Test]
        public void FreeShippingTest()
        {
            // TODO unit test for the property 'FreeShipping'
        }
        /// <summary>
        /// Test the property 'FreeShippingMinimum'
        /// </summary>
        [Test]
        public void FreeShippingMinimumTest()
        {
            // TODO unit test for the property 'FreeShippingMinimum'
        }
        /// <summary>
        /// Test the property 'LastModifiedBy'
        /// </summary>
        [Test]
        public void LastModifiedByTest()
        {
            // TODO unit test for the property 'LastModifiedBy'
        }
        /// <summary>
        /// Test the property 'LastModifiedDts'
        /// </summary>
        [Test]
        public void LastModifiedDtsTest()
        {
            // TODO unit test for the property 'LastModifiedDts'
        }
        /// <summary>
        /// Test the property 'MaximumItemCount'
        /// </summary>
        [Test]
        public void MaximumItemCountTest()
        {
            // TODO unit test for the property 'MaximumItemCount'
        }
        /// <summary>
        /// Test the property 'MinimumItemCount'
        /// </summary>
        [Test]
        public void MinimumItemCountTest()
        {
            // TODO unit test for the property 'MinimumItemCount'
        }
        /// <summary>
        /// Test the property 'MinimumSubtotal'
        /// </summary>
        [Test]
        public void MinimumSubtotalTest()
        {
            // TODO unit test for the property 'MinimumSubtotal'
        }
        /// <summary>
        /// Test the property 'NoCoupons'
        /// </summary>
        [Test]
        public void NoCouponsTest()
        {
            // TODO unit test for the property 'NoCoupons'
        }
        /// <summary>
        /// Test the property 'NoFreeShipping'
        /// </summary>
        [Test]
        public void NoFreeShippingTest()
        {
            // TODO unit test for the property 'NoFreeShipping'
        }
        /// <summary>
        /// Test the property 'NoRealtimeCharge'
        /// </summary>
        [Test]
        public void NoRealtimeChargeTest()
        {
            // TODO unit test for the property 'NoRealtimeCharge'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'PricingTiers'
        /// </summary>
        [Test]
        public void PricingTiersTest()
        {
            // TODO unit test for the property 'PricingTiers'
        }
        /// <summary>
        /// Test the property 'QbClass'
        /// </summary>
        [Test]
        public void QbClassTest()
        {
            // TODO unit test for the property 'QbClass'
        }
        /// <summary>
        /// Test the property 'QbCode'
        /// </summary>
        [Test]
        public void QbCodeTest()
        {
            // TODO unit test for the property 'QbCode'
        }
        /// <summary>
        /// Test the property 'ReferralSource'
        /// </summary>
        [Test]
        public void ReferralSourceTest()
        {
            // TODO unit test for the property 'ReferralSource'
        }
        /// <summary>
        /// Test the property 'SalesRepCode'
        /// </summary>
        [Test]
        public void SalesRepCodeTest()
        {
            // TODO unit test for the property 'SalesRepCode'
        }
        /// <summary>
        /// Test the property 'SendSignupNotification'
        /// </summary>
        [Test]
        public void SendSignupNotificationTest()
        {
            // TODO unit test for the property 'SendSignupNotification'
        }
        /// <summary>
        /// Test the property 'Shipping'
        /// </summary>
        [Test]
        public void ShippingTest()
        {
            // TODO unit test for the property 'Shipping'
        }
        /// <summary>
        /// Test the property 'SignupDts'
        /// </summary>
        [Test]
        public void SignupDtsTest()
        {
            // TODO unit test for the property 'SignupDts'
        }
        /// <summary>
        /// Test the property 'SuppressBuysafe'
        /// </summary>
        [Test]
        public void SuppressBuysafeTest()
        {
            // TODO unit test for the property 'SuppressBuysafe'
        }
        /// <summary>
        /// Test the property 'TaxExempt'
        /// </summary>
        [Test]
        public void TaxExemptTest()
        {
            // TODO unit test for the property 'TaxExempt'
        }
        /// <summary>
        /// Test the property 'TaxId'
        /// </summary>
        [Test]
        public void TaxIdTest()
        {
            // TODO unit test for the property 'TaxId'
        }
        /// <summary>
        /// Test the property 'Terms'
        /// </summary>
        [Test]
        public void TermsTest()
        {
            // TODO unit test for the property 'Terms'
        }
        /// <summary>
        /// Test the property 'TrackSeparately'
        /// </summary>
        [Test]
        public void TrackSeparatelyTest()
        {
            // TODO unit test for the property 'TrackSeparately'
        }
        /// <summary>
        /// Test the property 'Unapproved'
        /// </summary>
        [Test]
        public void UnapprovedTest()
        {
            // TODO unit test for the property 'Unapproved'
        }
        /// <summary>
        /// Test the property 'UpsAccountNumber'
        /// </summary>
        [Test]
        public void UpsAccountNumberTest()
        {
            // TODO unit test for the property 'UpsAccountNumber'
        }
        /// <summary>
        /// Test the property 'WebsiteUrl'
        /// </summary>
        [Test]
        public void WebsiteUrlTest()
        {
            // TODO unit test for the property 'WebsiteUrl'
        }

    }

}

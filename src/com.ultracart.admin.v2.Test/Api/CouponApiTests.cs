/* 
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace com.ultracart.admin.v2.Test
{
    /// <summary>
    ///  Class for testing CouponApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CouponApiTests
    {
        private CouponApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CouponApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CouponApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CouponApi
            //Assert.IsInstanceOfType(typeof(CouponApi), instance, "instance is a CouponApi");
        }

        
        /// <summary>
        /// Test DeleteCoupon
        /// </summary>
        [Test]
        public void DeleteCouponTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? couponOid = null;
            //var response = instance.DeleteCoupon(couponOid);
            //Assert.IsInstanceOf<CouponResponse> (response, "response is CouponResponse");
        }
        
        /// <summary>
        /// Test GenerateCouponCodes
        /// </summary>
        [Test]
        public void GenerateCouponCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? couponOid = null;
            //CouponCodesRequest couponCodesRequest = null;
            //var response = instance.GenerateCouponCodes(couponOid, couponCodesRequest);
            //Assert.IsInstanceOf<CouponCodesResponse> (response, "response is CouponCodesResponse");
        }
        
        /// <summary>
        /// Test GenerateOneTimeCodesByMerchantCode
        /// </summary>
        [Test]
        public void GenerateOneTimeCodesByMerchantCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantCode = null;
            //CouponCodesRequest couponCodesRequest = null;
            //var response = instance.GenerateOneTimeCodesByMerchantCode(merchantCode, couponCodesRequest);
            //Assert.IsInstanceOf<CouponCodesResponse> (response, "response is CouponCodesResponse");
        }
        
        /// <summary>
        /// Test GetCoupon
        /// </summary>
        [Test]
        public void GetCouponTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? couponOid = null;
            //string expand = null;
            //var response = instance.GetCoupon(couponOid, expand);
            //Assert.IsInstanceOf<CouponResponse> (response, "response is CouponResponse");
        }
        
        /// <summary>
        /// Test GetCouponByMerchantCode
        /// </summary>
        [Test]
        public void GetCouponByMerchantCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantCode = null;
            //string expand = null;
            //var response = instance.GetCouponByMerchantCode(merchantCode, expand);
            //Assert.IsInstanceOf<CouponResponse> (response, "response is CouponResponse");
        }
        
        /// <summary>
        /// Test GetCoupons
        /// </summary>
        [Test]
        public void GetCouponsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantCode = null;
            //string description = null;
            //string couponType = null;
            //string startDateBegin = null;
            //string startDateEnd = null;
            //string expirationDateBegin = null;
            //string expirationDateEnd = null;
            //int? affiliateOid = null;
            //bool? excludeExpired = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //string expand = null;
            //var response = instance.GetCoupons(merchantCode, description, couponType, startDateBegin, startDateEnd, expirationDateBegin, expirationDateEnd, affiliateOid, excludeExpired, limit, offset, sort, expand);
            //Assert.IsInstanceOf<CouponsResponse> (response, "response is CouponsResponse");
        }
        
        /// <summary>
        /// Test GetCouponsByQuery
        /// </summary>
        [Test]
        public void GetCouponsByQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CouponQuery couponQuery = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //string expand = null;
            //var response = instance.GetCouponsByQuery(couponQuery, limit, offset, sort, expand);
            //Assert.IsInstanceOf<CouponsResponse> (response, "response is CouponsResponse");
        }
        
        /// <summary>
        /// Test GetEditorValues
        /// </summary>
        [Test]
        public void GetEditorValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEditorValues();
            //Assert.IsInstanceOf<CouponEditorValues> (response, "response is CouponEditorValues");
        }
        
        /// <summary>
        /// Test InsertCoupon
        /// </summary>
        [Test]
        public void InsertCouponTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Coupon coupon = null;
            //string expand = null;
            //var response = instance.InsertCoupon(coupon, expand);
            //Assert.IsInstanceOf<CouponResponse> (response, "response is CouponResponse");
        }
        
        /// <summary>
        /// Test UpdateCoupon
        /// </summary>
        [Test]
        public void UpdateCouponTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Coupon coupon = null;
            //int? couponOid = null;
            //string expand = null;
            //var response = instance.UpdateCoupon(coupon, couponOid, expand);
            //Assert.IsInstanceOf<CouponResponse> (response, "response is CouponResponse");
        }
        
    }

}
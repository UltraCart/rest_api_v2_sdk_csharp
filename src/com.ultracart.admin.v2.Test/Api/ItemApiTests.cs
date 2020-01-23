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
    ///  Class for testing ItemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemApiTests
    {
        private ItemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemApi
            //Assert.IsInstanceOfType(typeof(ItemApi), instance, "instance is a ItemApi");
        }

        
        /// <summary>
        /// Test DeleteItem
        /// </summary>
        [Test]
        public void DeleteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? merchantItemOid = null;
            //instance.DeleteItem(merchantItemOid);
            
        }
        
        /// <summary>
        /// Test GetItem
        /// </summary>
        [Test]
        public void GetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? merchantItemOid = null;
            //string expand = null;
            //bool? placeholders = null;
            //var response = instance.GetItem(merchantItemOid, expand, placeholders);
            //Assert.IsInstanceOf<ItemResponse> (response, "response is ItemResponse");
        }
        
        /// <summary>
        /// Test GetItemByMerchantItemId
        /// </summary>
        [Test]
        public void GetItemByMerchantItemIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantItemId = null;
            //string expand = null;
            //bool? placeholders = null;
            //var response = instance.GetItemByMerchantItemId(merchantItemId, expand, placeholders);
            //Assert.IsInstanceOf<ItemResponse> (response, "response is ItemResponse");
        }
        
        /// <summary>
        /// Test GetItems
        /// </summary>
        [Test]
        public void GetItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? parentCategoryId = null;
            //string parentCategoryPath = null;
            //int? limit = null;
            //int? offset = null;
            //string since = null;
            //string sort = null;
            //string expand = null;
            //bool? placeholders = null;
            //var response = instance.GetItems(parentCategoryId, parentCategoryPath, limit, offset, since, sort, expand, placeholders);
            //Assert.IsInstanceOf<ItemsResponse> (response, "response is ItemsResponse");
        }
        
        /// <summary>
        /// Test GetPricingTiers
        /// </summary>
        [Test]
        public void GetPricingTiersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string expand = null;
            //var response = instance.GetPricingTiers(expand);
            //Assert.IsInstanceOf<PricingTiersResponse> (response, "response is PricingTiersResponse");
        }
        
        /// <summary>
        /// Test InsertItem
        /// </summary>
        [Test]
        public void InsertItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item item = null;
            //string expand = null;
            //bool? placeholders = null;
            //var response = instance.InsertItem(item, expand, placeholders);
            //Assert.IsInstanceOf<ItemResponse> (response, "response is ItemResponse");
        }
        
        /// <summary>
        /// Test UpdateItem
        /// </summary>
        [Test]
        public void UpdateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item item = null;
            //int? merchantItemOid = null;
            //string expand = null;
            //bool? placeholders = null;
            //var response = instance.UpdateItem(item, merchantItemOid, expand, placeholders);
            //Assert.IsInstanceOf<ItemResponse> (response, "response is ItemResponse");
        }
        
        /// <summary>
        /// Test UpdateItems
        /// </summary>
        [Test]
        public void UpdateItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemsRequest itemsRequest = null;
            //string expand = null;
            //bool? placeholders = null;
            //bool? async = null;
            //var response = instance.UpdateItems(itemsRequest, expand, placeholders, async);
            //Assert.IsInstanceOf<ItemsResponse> (response, "response is ItemsResponse");
        }
        
        /// <summary>
        /// Test UploadTemporaryMultimedia
        /// </summary>
        [Test]
        public void UploadTemporaryMultimediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //var response = instance.UploadTemporaryMultimedia(file);
            //Assert.IsInstanceOf<TempMultimediaResponse> (response, "response is TempMultimediaResponse");
        }
        
    }

}

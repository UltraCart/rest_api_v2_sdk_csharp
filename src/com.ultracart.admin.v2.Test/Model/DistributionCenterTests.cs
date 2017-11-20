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
    ///  Class for testing DistributionCenter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DistributionCenterTests
    {
        // TODO uncomment below to declare an instance variable for DistributionCenter
        //private DistributionCenter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DistributionCenter
            //instance = new DistributionCenter();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DistributionCenter
        /// </summary>
        [Test]
        public void DistributionCenterInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DistributionCenter
            //Assert.IsInstanceOfType<DistributionCenter> (instance, "variable 'instance' is a DistributionCenter");
        }


        /// <summary>
        /// Test the property 'Address1'
        /// </summary>
        [Test]
        public void Address1Test()
        {
            // TODO unit test for the property 'Address1'
        }
        /// <summary>
        /// Test the property 'Address2'
        /// </summary>
        [Test]
        public void Address2Test()
        {
            // TODO unit test for the property 'Address2'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'CountryCode'
        /// </summary>
        [Test]
        public void CountryCodeTest()
        {
            // TODO unit test for the property 'CountryCode'
        }
        /// <summary>
        /// Test the property 'DefaultCenter'
        /// </summary>
        [Test]
        public void DefaultCenterTest()
        {
            // TODO unit test for the property 'DefaultCenter'
        }
        /// <summary>
        /// Test the property 'DefaultHandlesAllItems'
        /// </summary>
        [Test]
        public void DefaultHandlesAllItemsTest()
        {
            // TODO unit test for the property 'DefaultHandlesAllItems'
        }
        /// <summary>
        /// Test the property 'DistributionCenterOid'
        /// </summary>
        [Test]
        public void DistributionCenterOidTest()
        {
            // TODO unit test for the property 'DistributionCenterOid'
        }
        /// <summary>
        /// Test the property 'Duns'
        /// </summary>
        [Test]
        public void DunsTest()
        {
            // TODO unit test for the property 'Duns'
        }
        /// <summary>
        /// Test the property 'EstimateFromDistributionCenterOid'
        /// </summary>
        [Test]
        public void EstimateFromDistributionCenterOidTest()
        {
            // TODO unit test for the property 'EstimateFromDistributionCenterOid'
        }
        /// <summary>
        /// Test the property 'FtpPassword'
        /// </summary>
        [Test]
        public void FtpPasswordTest()
        {
            // TODO unit test for the property 'FtpPassword'
        }
        /// <summary>
        /// Test the property 'HoldBeforeShipmentMinutes'
        /// </summary>
        [Test]
        public void HoldBeforeShipmentMinutesTest()
        {
            // TODO unit test for the property 'HoldBeforeShipmentMinutes'
        }
        /// <summary>
        /// Test the property 'HoldBeforeTransmission'
        /// </summary>
        [Test]
        public void HoldBeforeTransmissionTest()
        {
            // TODO unit test for the property 'HoldBeforeTransmission'
        }
        /// <summary>
        /// Test the property 'Latitude'
        /// </summary>
        [Test]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }
        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Test]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'NoCustomerDirectShipments'
        /// </summary>
        [Test]
        public void NoCustomerDirectShipmentsTest()
        {
            // TODO unit test for the property 'NoCustomerDirectShipments'
        }
        /// <summary>
        /// Test the property 'NoSplitShipment'
        /// </summary>
        [Test]
        public void NoSplitShipmentTest()
        {
            // TODO unit test for the property 'NoSplitShipment'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'ProcessDays'
        /// </summary>
        [Test]
        public void ProcessDaysTest()
        {
            // TODO unit test for the property 'ProcessDays'
        }
        /// <summary>
        /// Test the property 'ProcessInventoryStartTime'
        /// </summary>
        [Test]
        public void ProcessInventoryStartTimeTest()
        {
            // TODO unit test for the property 'ProcessInventoryStartTime'
        }
        /// <summary>
        /// Test the property 'ProcessInventoryStopTime'
        /// </summary>
        [Test]
        public void ProcessInventoryStopTimeTest()
        {
            // TODO unit test for the property 'ProcessInventoryStopTime'
        }
        /// <summary>
        /// Test the property 'RequireAsn'
        /// </summary>
        [Test]
        public void RequireAsnTest()
        {
            // TODO unit test for the property 'RequireAsn'
        }
        /// <summary>
        /// Test the property 'SendKitInsteadOfComponents'
        /// </summary>
        [Test]
        public void SendKitInsteadOfComponentsTest()
        {
            // TODO unit test for the property 'SendKitInsteadOfComponents'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeFriday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeFridayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeFriday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeMonday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeMondayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeMonday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeSaturday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeSaturdayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeSaturday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeSunday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeSundayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeSunday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeThursday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeThursdayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeThursday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeTuesday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeTuesdayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeTuesday'
        }
        /// <summary>
        /// Test the property 'ShipmentCutoffTimeWednesday'
        /// </summary>
        [Test]
        public void ShipmentCutoffTimeWednesdayTest()
        {
            // TODO unit test for the property 'ShipmentCutoffTimeWednesday'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Transport'
        /// </summary>
        [Test]
        public void TransportTest()
        {
            // TODO unit test for the property 'Transport'
        }

    }

}

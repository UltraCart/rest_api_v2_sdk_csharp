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
    ///  Class for testing TaxApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TaxApiTests
    {
        private TaxApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TaxApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TaxApi
            //Assert.IsInstanceOfType(typeof(TaxApi), instance, "instance is a TaxApi");
        }

        
        /// <summary>
        /// Test DeleteTaxProviderSelfCity
        /// </summary>
        [Test]
        public void DeleteTaxProviderSelfCityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string city = null;
            //TaxCity taxCity = null;
            //instance.DeleteTaxProviderSelfCity(city, taxCity);
            
        }
        
        /// <summary>
        /// Test DeleteTaxProviderSelfCountry
        /// </summary>
        [Test]
        public void DeleteTaxProviderSelfCountryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryCode = null;
            //TaxCountry taxCountry = null;
            //instance.DeleteTaxProviderSelfCountry(countryCode, taxCountry);
            
        }
        
        /// <summary>
        /// Test DeleteTaxProviderSelfCounty
        /// </summary>
        [Test]
        public void DeleteTaxProviderSelfCountyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string county = null;
            //TaxCounty taxCounty = null;
            //instance.DeleteTaxProviderSelfCounty(county, taxCounty);
            
        }
        
        /// <summary>
        /// Test DeleteTaxProviderSelfPostalCode
        /// </summary>
        [Test]
        public void DeleteTaxProviderSelfPostalCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postalCode = null;
            //TaxPostalCode taxPostalCode = null;
            //instance.DeleteTaxProviderSelfPostalCode(postalCode, taxPostalCode);
            
        }
        
        /// <summary>
        /// Test DeleteTaxProviderSelfState
        /// </summary>
        [Test]
        public void DeleteTaxProviderSelfStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stateCode = null;
            //TaxState taxState = null;
            //instance.DeleteTaxProviderSelfState(stateCode, taxState);
            
        }
        
        /// <summary>
        /// Test GetTaxProviderAvalara
        /// </summary>
        [Test]
        public void GetTaxProviderAvalaraTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderAvalara();
            //Assert.IsInstanceOf<TaxProviderAvalara> (response, "response is TaxProviderAvalara");
        }
        
        /// <summary>
        /// Test GetTaxProviderAvalaraCompanies
        /// </summary>
        [Test]
        public void GetTaxProviderAvalaraCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxProviderAvalara taxProviderAvalara = null;
            //var response = instance.GetTaxProviderAvalaraCompanies(taxProviderAvalara);
            //Assert.IsInstanceOf<TaxProviderAvalaraCompaniesResult> (response, "response is TaxProviderAvalaraCompaniesResult");
        }
        
        /// <summary>
        /// Test GetTaxProviderAvalaraTest
        /// </summary>
        [Test]
        public void GetTaxProviderAvalaraTestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderAvalaraTest();
            //Assert.IsInstanceOf<TaxProviderTestResult> (response, "response is TaxProviderTestResult");
        }
        
        /// <summary>
        /// Test GetTaxProviderSelf
        /// </summary>
        [Test]
        public void GetTaxProviderSelfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderSelf();
            //Assert.IsInstanceOf<TaxProviderSelf> (response, "response is TaxProviderSelf");
        }
        
        /// <summary>
        /// Test GetTaxProviderSelfCountries
        /// </summary>
        [Test]
        public void GetTaxProviderSelfCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderSelfCountries();
            //Assert.IsInstanceOf<TaxProviderSelfCountriesResponse> (response, "response is TaxProviderSelfCountriesResponse");
        }
        
        /// <summary>
        /// Test GetTaxProviderSelfRegionsByCountryCode
        /// </summary>
        [Test]
        public void GetTaxProviderSelfRegionsByCountryCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryCode = null;
            //var response = instance.GetTaxProviderSelfRegionsByCountryCode(countryCode);
            //Assert.IsInstanceOf<TaxProviderSelfRegionsResponse> (response, "response is TaxProviderSelfRegionsResponse");
        }
        
        /// <summary>
        /// Test GetTaxProviderTaxJar
        /// </summary>
        [Test]
        public void GetTaxProviderTaxJarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderTaxJar();
            //Assert.IsInstanceOf<TaxProviderTaxJar> (response, "response is TaxProviderTaxJar");
        }
        
        /// <summary>
        /// Test GetTaxProviderTaxJarTest
        /// </summary>
        [Test]
        public void GetTaxProviderTaxJarTestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderTaxJarTest();
            //Assert.IsInstanceOf<TaxProviderTestResult> (response, "response is TaxProviderTestResult");
        }
        
        /// <summary>
        /// Test GetTaxProviderUltraCart
        /// </summary>
        [Test]
        public void GetTaxProviderUltraCartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTaxProviderUltraCart();
            //Assert.IsInstanceOf<TaxProviderUltraCart> (response, "response is TaxProviderUltraCart");
        }
        
        /// <summary>
        /// Test GetTaxProviders
        /// </summary>
        [Test]
        public void GetTaxProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //string expand = null;
            //var response = instance.GetTaxProviders(limit, offset, expand);
            //Assert.IsInstanceOf<TaxProvidersResponse> (response, "response is TaxProvidersResponse");
        }
        
        /// <summary>
        /// Test SetActiveTaxProvider
        /// </summary>
        [Test]
        public void SetActiveTaxProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerName = null;
            //var response = instance.SetActiveTaxProvider(providerName);
            //Assert.IsInstanceOf<TaxProviderActivateResult> (response, "response is TaxProviderActivateResult");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderAvalara
        /// </summary>
        [Test]
        public void UpdateTaxProviderAvalaraTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxProviderAvalara taxProviderAvalara = null;
            //var response = instance.UpdateTaxProviderAvalara(taxProviderAvalara);
            //Assert.IsInstanceOf<TaxProviderAvalara> (response, "response is TaxProviderAvalara");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelf
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxProviderSelf taxProviderSelf = null;
            //var response = instance.UpdateTaxProviderSelf(taxProviderSelf);
            //Assert.IsInstanceOf<TaxProviderSelf> (response, "response is TaxProviderSelf");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelfCity
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfCityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string city = null;
            //TaxCity taxCity = null;
            //var response = instance.UpdateTaxProviderSelfCity(city, taxCity);
            //Assert.IsInstanceOf<TaxCity> (response, "response is TaxCity");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelfCountry
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfCountryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryCode = null;
            //TaxCountry taxCountry = null;
            //var response = instance.UpdateTaxProviderSelfCountry(countryCode, taxCountry);
            //Assert.IsInstanceOf<TaxCountry> (response, "response is TaxCountry");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelfCounty
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfCountyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string county = null;
            //TaxCounty taxCounty = null;
            //var response = instance.UpdateTaxProviderSelfCounty(county, taxCounty);
            //Assert.IsInstanceOf<TaxCounty> (response, "response is TaxCounty");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelfPostalCode
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfPostalCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postalCode = null;
            //TaxPostalCode taxPostalCode = null;
            //var response = instance.UpdateTaxProviderSelfPostalCode(postalCode, taxPostalCode);
            //Assert.IsInstanceOf<TaxPostalCode> (response, "response is TaxPostalCode");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderSelfState
        /// </summary>
        [Test]
        public void UpdateTaxProviderSelfStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stateCode = null;
            //TaxState taxState = null;
            //var response = instance.UpdateTaxProviderSelfState(stateCode, taxState);
            //Assert.IsInstanceOf<TaxState> (response, "response is TaxState");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderTaxJar
        /// </summary>
        [Test]
        public void UpdateTaxProviderTaxJarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxProviderTaxJar taxProviderTaxJar = null;
            //var response = instance.UpdateTaxProviderTaxJar(taxProviderTaxJar);
            //Assert.IsInstanceOf<TaxProviderTaxJar> (response, "response is TaxProviderTaxJar");
        }
        
        /// <summary>
        /// Test UpdateTaxProviderUltraCart
        /// </summary>
        [Test]
        public void UpdateTaxProviderUltraCartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxProviderUltraCart taxProviderUltracart = null;
            //var response = instance.UpdateTaxProviderUltraCart(taxProviderUltracart);
            //Assert.IsInstanceOf<TaxProviderUltraCart> (response, "response is TaxProviderUltraCart");
        }
        
    }

}
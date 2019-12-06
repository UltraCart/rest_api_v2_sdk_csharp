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
    ///  Class for testing StorefrontApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StorefrontApiTests
    {
        private StorefrontApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StorefrontApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StorefrontApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StorefrontApi
            //Assert.IsInstanceOfType(typeof(StorefrontApi), instance, "instance is a StorefrontApi");
        }

        
        /// <summary>
        /// Test ArchiveEmailList
        /// </summary>
        [Test]
        public void ArchiveEmailListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //var response = instance.ArchiveEmailList(storefrontOid, emailListUuid);
            //Assert.IsInstanceOf<EmailListArchiveResponse> (response, "response is EmailListArchiveResponse");
        }
        
        /// <summary>
        /// Test ArchiveEmailSegment
        /// </summary>
        [Test]
        public void ArchiveEmailSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //var response = instance.ArchiveEmailSegment(storefrontOid, emailSegmentUuid);
            //Assert.IsInstanceOf<EmailSegmentArchiveResponse> (response, "response is EmailSegmentArchiveResponse");
        }
        
        /// <summary>
        /// Test CloneEmailCampaign
        /// </summary>
        [Test]
        public void CloneEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailCampaignUuid = null;
            //var response = instance.CloneEmailCampaign(storefrontOid, emailCampaignUuid);
            //Assert.IsInstanceOf<EmailCampaignResponse> (response, "response is EmailCampaignResponse");
        }
        
        /// <summary>
        /// Test CloneEmailFlow
        /// </summary>
        [Test]
        public void CloneEmailFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailFlowUuid = null;
            //var response = instance.CloneEmailFlow(storefrontOid, emailFlowUuid);
            //Assert.IsInstanceOf<EmailFlowResponse> (response, "response is EmailFlowResponse");
        }
        
        /// <summary>
        /// Test CreateEmailSendingDomain
        /// </summary>
        [Test]
        public void CreateEmailSendingDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.CreateEmailSendingDomain(domain);
            //Assert.IsInstanceOf<EmailSendingDomainResponse> (response, "response is EmailSendingDomainResponse");
        }
        
        /// <summary>
        /// Test DeleteEmailEmail
        /// </summary>
        [Test]
        public void DeleteEmailEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqEmailUuid = null;
            //var response = instance.DeleteEmailEmail(storefrontOid, commseqEmailUuid);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test DeleteEmailListCustomer
        /// </summary>
        [Test]
        public void DeleteEmailListCustomerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //string emailCustomerUuid = null;
            //var response = instance.DeleteEmailListCustomer(storefrontOid, emailListUuid, emailCustomerUuid);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test DeleteEmailSendingDomain
        /// </summary>
        [Test]
        public void DeleteEmailSendingDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DeleteEmailSendingDomain(domain);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test DeleteExperiment
        /// </summary>
        [Test]
        public void DeleteExperimentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //int? storefrontExperimentOid = null;
            //instance.DeleteExperiment(storefrontOid, storefrontExperimentOid);
            
        }
        
        /// <summary>
        /// Test GeocodeAddress
        /// </summary>
        [Test]
        public void GeocodeAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //GeocodeRequest geocodeRequest = null;
            //var response = instance.GeocodeAddress(storefrontOid, geocodeRequest);
            //Assert.IsInstanceOf<GeocodeResponse> (response, "response is GeocodeResponse");
        }
        
        /// <summary>
        /// Test GetCountries
        /// </summary>
        [Test]
        public void GetCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetCountries(storefrontOid);
            //Assert.IsInstanceOf<CountriesResponse> (response, "response is CountriesResponse");
        }
        
        /// <summary>
        /// Test GetEmailBaseTemplates
        /// </summary>
        [Test]
        public void GetEmailBaseTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailBaseTemplates(storefrontOid);
            //Assert.IsInstanceOf<EmailBaseTemplateListResponse> (response, "response is EmailBaseTemplateListResponse");
        }
        
        /// <summary>
        /// Test GetEmailCampaign
        /// </summary>
        [Test]
        public void GetEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailCampaignUuid = null;
            //var response = instance.GetEmailCampaign(storefrontOid, emailCampaignUuid);
            //Assert.IsInstanceOf<EmailCampaignResponse> (response, "response is EmailCampaignResponse");
        }
        
        /// <summary>
        /// Test GetEmailCampaigns
        /// </summary>
        [Test]
        public void GetEmailCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailCampaigns(storefrontOid);
            //Assert.IsInstanceOf<EmailCampaignsResponse> (response, "response is EmailCampaignsResponse");
        }
        
        /// <summary>
        /// Test GetEmailCampaignsWithStats
        /// </summary>
        [Test]
        public void GetEmailCampaignsWithStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string statDays = null;
            //var response = instance.GetEmailCampaignsWithStats(storefrontOid, statDays);
            //Assert.IsInstanceOf<EmailCampaignsResponse> (response, "response is EmailCampaignsResponse");
        }
        
        /// <summary>
        /// Test GetEmailCommseq
        /// </summary>
        [Test]
        public void GetEmailCommseqTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqUuid = null;
            //var response = instance.GetEmailCommseq(storefrontOid, commseqUuid);
            //Assert.IsInstanceOf<EmailCommseqResponse> (response, "response is EmailCommseqResponse");
        }
        
        /// <summary>
        /// Test GetEmailCommseqEmailStats
        /// </summary>
        [Test]
        public void GetEmailCommseqEmailStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqUuid = null;
            //EmailStatSummaryRequest statsRequest = null;
            //var response = instance.GetEmailCommseqEmailStats(storefrontOid, commseqUuid, statsRequest);
            //Assert.IsInstanceOf<EmailStatSummaryResponse> (response, "response is EmailStatSummaryResponse");
        }
        
        /// <summary>
        /// Test GetEmailCommseqStatOverall
        /// </summary>
        [Test]
        public void GetEmailCommseqStatOverallTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqUuid = null;
            //var response = instance.GetEmailCommseqStatOverall(storefrontOid, commseqUuid);
            //Assert.IsInstanceOf<EmailCommseqStatResponse> (response, "response is EmailCommseqStatResponse");
        }
        
        /// <summary>
        /// Test GetEmailCommseqStepWaiting
        /// </summary>
        [Test]
        public void GetEmailCommseqStepWaitingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqUuid = null;
            //EmailStepWaitingRequest waitingRequest = null;
            //var response = instance.GetEmailCommseqStepWaiting(storefrontOid, commseqUuid, waitingRequest);
            //Assert.IsInstanceOf<EmailStepWaitingResponse> (response, "response is EmailStepWaitingResponse");
        }
        
        /// <summary>
        /// Test GetEmailCommseqs
        /// </summary>
        [Test]
        public void GetEmailCommseqsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailCommseqs(storefrontOid);
            //Assert.IsInstanceOf<EmailCommseqsResponse> (response, "response is EmailCommseqsResponse");
        }
        
        /// <summary>
        /// Test GetEmailDashboardActivity
        /// </summary>
        [Test]
        public void GetEmailDashboardActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //int? lastRecords = null;
            //var response = instance.GetEmailDashboardActivity(storefrontOid, lastRecords);
            //Assert.IsInstanceOf<EmailDashboardActivityResponse> (response, "response is EmailDashboardActivityResponse");
        }
        
        /// <summary>
        /// Test GetEmailDashboardStats
        /// </summary>
        [Test]
        public void GetEmailDashboardStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //int? days = null;
            //var response = instance.GetEmailDashboardStats(storefrontOid, days);
            //Assert.IsInstanceOf<EmailDashboardStatsResponse> (response, "response is EmailDashboardStatsResponse");
        }
        
        /// <summary>
        /// Test GetEmailEmail
        /// </summary>
        [Test]
        public void GetEmailEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqEmailUuid = null;
            //var response = instance.GetEmailEmail(storefrontOid, commseqEmailUuid);
            //Assert.IsInstanceOf<EmailCommseqEmailResponse> (response, "response is EmailCommseqEmailResponse");
        }
        
        /// <summary>
        /// Test GetEmailEmails
        /// </summary>
        [Test]
        public void GetEmailEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailEmails(storefrontOid);
            //Assert.IsInstanceOf<EmailCommseqEmailsResponse> (response, "response is EmailCommseqEmailsResponse");
        }
        
        /// <summary>
        /// Test GetEmailEmailsMultiple
        /// </summary>
        [Test]
        public void GetEmailEmailsMultipleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailCommseqEmailsRequest emailCommseqEmailsRequest = null;
            //var response = instance.GetEmailEmailsMultiple(storefrontOid, emailCommseqEmailsRequest);
            //Assert.IsInstanceOf<EmailCommseqEmailsResponse> (response, "response is EmailCommseqEmailsResponse");
        }
        
        /// <summary>
        /// Test GetEmailFlow
        /// </summary>
        [Test]
        public void GetEmailFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailFlowUuid = null;
            //var response = instance.GetEmailFlow(storefrontOid, emailFlowUuid);
            //Assert.IsInstanceOf<EmailFlowResponse> (response, "response is EmailFlowResponse");
        }
        
        /// <summary>
        /// Test GetEmailFlows
        /// </summary>
        [Test]
        public void GetEmailFlowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailFlows(storefrontOid);
            //Assert.IsInstanceOf<EmailFlowsResponse> (response, "response is EmailFlowsResponse");
        }
        
        /// <summary>
        /// Test GetEmailList
        /// </summary>
        [Test]
        public void GetEmailListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //var response = instance.GetEmailList(storefrontOid, emailListUuid);
            //Assert.IsInstanceOf<EmailListResponse> (response, "response is EmailListResponse");
        }
        
        /// <summary>
        /// Test GetEmailListCustomerEditorUrl
        /// </summary>
        [Test]
        public void GetEmailListCustomerEditorUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //string emailCustomerUuid = null;
            //var response = instance.GetEmailListCustomerEditorUrl(storefrontOid, emailListUuid, emailCustomerUuid);
            //Assert.IsInstanceOf<EmailCustomerEditorUrlResponse> (response, "response is EmailCustomerEditorUrlResponse");
        }
        
        /// <summary>
        /// Test GetEmailListCustomers
        /// </summary>
        [Test]
        public void GetEmailListCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.GetEmailListCustomers(storefrontOid, emailListUuid, pageNumber, pageSize);
            //Assert.IsInstanceOf<EmailListCustomersResponse> (response, "response is EmailListCustomersResponse");
        }
        
        /// <summary>
        /// Test GetEmailLists
        /// </summary>
        [Test]
        public void GetEmailListsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailLists(storefrontOid);
            //Assert.IsInstanceOf<EmailListsResponse> (response, "response is EmailListsResponse");
        }
        
        /// <summary>
        /// Test GetEmailSegment
        /// </summary>
        [Test]
        public void GetEmailSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //var response = instance.GetEmailSegment(storefrontOid, emailSegmentUuid);
            //Assert.IsInstanceOf<EmailSegmentResponse> (response, "response is EmailSegmentResponse");
        }
        
        /// <summary>
        /// Test GetEmailSegmentCustomerEditorUrl
        /// </summary>
        [Test]
        public void GetEmailSegmentCustomerEditorUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //string emailCustomerUuid = null;
            //var response = instance.GetEmailSegmentCustomerEditorUrl(storefrontOid, emailSegmentUuid, emailCustomerUuid);
            //Assert.IsInstanceOf<EmailCustomerEditorUrlResponse> (response, "response is EmailCustomerEditorUrlResponse");
        }
        
        /// <summary>
        /// Test GetEmailSegmentCustomers
        /// </summary>
        [Test]
        public void GetEmailSegmentCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.GetEmailSegmentCustomers(storefrontOid, emailSegmentUuid, pageNumber, pageSize);
            //Assert.IsInstanceOf<EmailSegmentCustomersResponse> (response, "response is EmailSegmentCustomersResponse");
        }
        
        /// <summary>
        /// Test GetEmailSegments
        /// </summary>
        [Test]
        public void GetEmailSegmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailSegments(storefrontOid);
            //Assert.IsInstanceOf<EmailSegmentsResponse> (response, "response is EmailSegmentsResponse");
        }
        
        /// <summary>
        /// Test GetEmailSendingDomain
        /// </summary>
        [Test]
        public void GetEmailSendingDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.GetEmailSendingDomain(domain);
            //Assert.IsInstanceOf<EmailSendingDomainResponse> (response, "response is EmailSendingDomainResponse");
        }
        
        /// <summary>
        /// Test GetEmailSendingDomainStatus
        /// </summary>
        [Test]
        public void GetEmailSendingDomainStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.GetEmailSendingDomainStatus(domain);
            //Assert.IsInstanceOf<EmailSendingDomainResponse> (response, "response is EmailSendingDomainResponse");
        }
        
        /// <summary>
        /// Test GetEmailSendingDomains
        /// </summary>
        [Test]
        public void GetEmailSendingDomainsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEmailSendingDomains();
            //Assert.IsInstanceOf<EmailSendingDomainsResponse> (response, "response is EmailSendingDomainsResponse");
        }
        
        /// <summary>
        /// Test GetEmailTemplate
        /// </summary>
        [Test]
        public void GetEmailTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //int? emailTemplateOid = null;
            //var response = instance.GetEmailTemplate(storefrontOid, emailTemplateOid);
            //Assert.IsInstanceOf<EmailTemplate> (response, "response is EmailTemplate");
        }
        
        /// <summary>
        /// Test GetEmailTemplates
        /// </summary>
        [Test]
        public void GetEmailTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string triggerType = null;
            //var response = instance.GetEmailTemplates(storefrontOid, triggerType);
            //Assert.IsInstanceOf<EmailTemplatesResponse> (response, "response is EmailTemplatesResponse");
        }
        
        /// <summary>
        /// Test GetEmailThirdPartyProviders
        /// </summary>
        [Test]
        public void GetEmailThirdPartyProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetEmailThirdPartyProviders(storefrontOid);
            //Assert.IsInstanceOf<EmailThirdPartyProvidersResponse> (response, "response is EmailThirdPartyProvidersResponse");
        }
        
        /// <summary>
        /// Test GetExperiments
        /// </summary>
        [Test]
        public void GetExperimentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //var response = instance.GetExperiments(storefrontOid);
            //Assert.IsInstanceOf<ExperimentsResponse> (response, "response is ExperimentsResponse");
        }
        
        /// <summary>
        /// Test GetHistogramPropertyNames
        /// </summary>
        [Test]
        public void GetHistogramPropertyNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string propertyType = null;
            //var response = instance.GetHistogramPropertyNames(storefrontOid, propertyType);
            //Assert.IsInstanceOf<EmailHistogramPropertyNamesResponse> (response, "response is EmailHistogramPropertyNamesResponse");
        }
        
        /// <summary>
        /// Test GetHistogramPropertyValues
        /// </summary>
        [Test]
        public void GetHistogramPropertyValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string propertyName = null;
            //string propertyType = null;
            //int? limit = null;
            //var response = instance.GetHistogramPropertyValues(storefrontOid, propertyName, propertyType, limit);
            //Assert.IsInstanceOf<EmailHistogramPropertyValuesResponse> (response, "response is EmailHistogramPropertyValuesResponse");
        }
        
        /// <summary>
        /// Test ImportEmailThirdPartyProviderList
        /// </summary>
        [Test]
        public void ImportEmailThirdPartyProviderListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailThirdPartyListImportRequest importRequest = null;
            //instance.ImportEmailThirdPartyProviderList(storefrontOid, importRequest);
            
        }
        
        /// <summary>
        /// Test InsertEmailCampaign
        /// </summary>
        [Test]
        public void InsertEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailCampaign emailCampaign = null;
            //var response = instance.InsertEmailCampaign(storefrontOid, emailCampaign);
            //Assert.IsInstanceOf<EmailCampaignResponse> (response, "response is EmailCampaignResponse");
        }
        
        /// <summary>
        /// Test InsertEmailCommseq
        /// </summary>
        [Test]
        public void InsertEmailCommseqTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailCommseq emailCommseq = null;
            //var response = instance.InsertEmailCommseq(storefrontOid, emailCommseq);
            //Assert.IsInstanceOf<EmailCommseqResponse> (response, "response is EmailCommseqResponse");
        }
        
        /// <summary>
        /// Test InsertEmailEmail
        /// </summary>
        [Test]
        public void InsertEmailEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailCommseqEmail emailCommseqEmail = null;
            //var response = instance.InsertEmailEmail(storefrontOid, emailCommseqEmail);
            //Assert.IsInstanceOf<EmailCommseqEmailResponse> (response, "response is EmailCommseqEmailResponse");
        }
        
        /// <summary>
        /// Test InsertEmailFlow
        /// </summary>
        [Test]
        public void InsertEmailFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailFlow emailFlow = null;
            //var response = instance.InsertEmailFlow(storefrontOid, emailFlow);
            //Assert.IsInstanceOf<EmailFlowResponse> (response, "response is EmailFlowResponse");
        }
        
        /// <summary>
        /// Test InsertEmailList
        /// </summary>
        [Test]
        public void InsertEmailListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailList emailList = null;
            //var response = instance.InsertEmailList(storefrontOid, emailList);
            //Assert.IsInstanceOf<EmailListResponse> (response, "response is EmailListResponse");
        }
        
        /// <summary>
        /// Test InsertEmailSegment
        /// </summary>
        [Test]
        public void InsertEmailSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //EmailSegment emailSegment = null;
            //var response = instance.InsertEmailSegment(storefrontOid, emailSegment);
            //Assert.IsInstanceOf<EmailSegmentResponse> (response, "response is EmailSegmentResponse");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string matches = null;
            //int? maxHits = null;
            //var response = instance.Search(category, matches, maxHits);
            //Assert.IsInstanceOf<LookupResponse> (response, "response is LookupResponse");
        }
        
        /// <summary>
        /// Test SearchEmailListCustomers
        /// </summary>
        [Test]
        public void SearchEmailListCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //string startsWith = null;
            //var response = instance.SearchEmailListCustomers(storefrontOid, emailListUuid, startsWith);
            //Assert.IsInstanceOf<EmailListCustomersResponse> (response, "response is EmailListCustomersResponse");
        }
        
        /// <summary>
        /// Test SearchEmailSegmentCustomers
        /// </summary>
        [Test]
        public void SearchEmailSegmentCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //string startsWith = null;
            //var response = instance.SearchEmailSegmentCustomers(storefrontOid, emailSegmentUuid, startsWith);
            //Assert.IsInstanceOf<EmailSegmentCustomersResponse> (response, "response is EmailSegmentCustomersResponse");
        }
        
        /// <summary>
        /// Test StartEmailCampaign
        /// </summary>
        [Test]
        public void StartEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailCampaignUuid = null;
            //var response = instance.StartEmailCampaign(storefrontOid, emailCampaignUuid);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test SubscribeToEmailList
        /// </summary>
        [Test]
        public void SubscribeToEmailListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //List<EmailCustomer> customers = null;
            //var response = instance.SubscribeToEmailList(storefrontOid, emailListUuid, customers);
            //Assert.IsInstanceOf<EmailListSubscribeResponse> (response, "response is EmailListSubscribeResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailCampaign
        /// </summary>
        [Test]
        public void UpdateEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailCampaignUuid = null;
            //EmailCampaign emailCampaign = null;
            //var response = instance.UpdateEmailCampaign(storefrontOid, emailCampaignUuid, emailCampaign);
            //Assert.IsInstanceOf<EmailCampaignResponse> (response, "response is EmailCampaignResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailCommseq
        /// </summary>
        [Test]
        public void UpdateEmailCommseqTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqUuid = null;
            //EmailCommseq emailCommseq = null;
            //var response = instance.UpdateEmailCommseq(storefrontOid, commseqUuid, emailCommseq);
            //Assert.IsInstanceOf<EmailCommseqResponse> (response, "response is EmailCommseqResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailEmail
        /// </summary>
        [Test]
        public void UpdateEmailEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string commseqEmailUuid = null;
            //EmailCommseqEmail emailCommseqEmail = null;
            //var response = instance.UpdateEmailEmail(storefrontOid, commseqEmailUuid, emailCommseqEmail);
            //Assert.IsInstanceOf<EmailCommseqEmailResponse> (response, "response is EmailCommseqEmailResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailFlow
        /// </summary>
        [Test]
        public void UpdateEmailFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailFlowUuid = null;
            //EmailFlow emailFlow = null;
            //var response = instance.UpdateEmailFlow(storefrontOid, emailFlowUuid, emailFlow);
            //Assert.IsInstanceOf<EmailFlowResponse> (response, "response is EmailFlowResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailList
        /// </summary>
        [Test]
        public void UpdateEmailListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailListUuid = null;
            //EmailList emailList = null;
            //var response = instance.UpdateEmailList(storefrontOid, emailListUuid, emailList);
            //Assert.IsInstanceOf<EmailListResponse> (response, "response is EmailListResponse");
        }
        
        /// <summary>
        /// Test UpdateEmailSegment
        /// </summary>
        [Test]
        public void UpdateEmailSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //string emailSegmentUuid = null;
            //EmailSegment emailSegment = null;
            //var response = instance.UpdateEmailSegment(storefrontOid, emailSegmentUuid, emailSegment);
            //Assert.IsInstanceOf<EmailSegmentResponse> (response, "response is EmailSegmentResponse");
        }
        
        /// <summary>
        /// Test UpdateExperiment
        /// </summary>
        [Test]
        public void UpdateExperimentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storefrontOid = null;
            //int? storefrontExperimentOid = null;
            //Experiment experiment = null;
            //var response = instance.UpdateExperiment(storefrontOid, storefrontExperimentOid, experiment);
            //Assert.IsInstanceOf<ExperimentResponse> (response, "response is ExperimentResponse");
        }
        
    }

}

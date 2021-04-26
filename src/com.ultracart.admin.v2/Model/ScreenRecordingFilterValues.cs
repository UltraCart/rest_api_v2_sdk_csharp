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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.ultracart.admin.v2.Client.SwaggerDateConverter;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// ScreenRecordingFilterValues
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingFilterValues :  IEquatable<ScreenRecordingFilterValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingFilterValues" /> class.
        /// </summary>
        /// <param name="communicationsCampaignNames">communicationsCampaignNames.</param>
        /// <param name="communicationsEmailSubjects">communicationsEmailSubjects.</param>
        /// <param name="communicationsFlowNames">communicationsFlowNames.</param>
        /// <param name="geolocationCountries">geolocationCountries.</param>
        /// <param name="geolocationStates">geolocationStates.</param>
        /// <param name="languageIsoCodes">languageIsoCodes.</param>
        /// <param name="maxValues">maxValues.</param>
        /// <param name="pageViews">pageViews.</param>
        /// <param name="timeOnSiteMax">timeOnSiteMax.</param>
        /// <param name="timeOnSiteMin">timeOnSiteMin.</param>
        /// <param name="urls">urls.</param>
        /// <param name="userAgentDeviceNames">userAgentDeviceNames.</param>
        /// <param name="userAgentDeviceOsNames">userAgentDeviceOsNames.</param>
        /// <param name="userAgentDeviceOsVersions">userAgentDeviceOsVersions.</param>
        /// <param name="userAgentNames">userAgentNames.</param>
        /// <param name="userAgentOriginals">userAgentOriginals.</param>
        /// <param name="utmCampaigns">utmCampaigns.</param>
        /// <param name="utmSources">utmSources.</param>
        public ScreenRecordingFilterValues(List<string> communicationsCampaignNames = default(List<string>), List<string> communicationsEmailSubjects = default(List<string>), List<string> communicationsFlowNames = default(List<string>), List<string> geolocationCountries = default(List<string>), List<string> geolocationStates = default(List<string>), List<string> languageIsoCodes = default(List<string>), int? maxValues = default(int?), List<ScreenRecordingFilterValuesPageView> pageViews = default(List<ScreenRecordingFilterValuesPageView>), int? timeOnSiteMax = default(int?), int? timeOnSiteMin = default(int?), List<string> urls = default(List<string>), List<string> userAgentDeviceNames = default(List<string>), List<string> userAgentDeviceOsNames = default(List<string>), List<string> userAgentDeviceOsVersions = default(List<string>), List<string> userAgentNames = default(List<string>), List<string> userAgentOriginals = default(List<string>), List<string> utmCampaigns = default(List<string>), List<string> utmSources = default(List<string>))
        {
            this.CommunicationsCampaignNames = communicationsCampaignNames;
            this.CommunicationsEmailSubjects = communicationsEmailSubjects;
            this.CommunicationsFlowNames = communicationsFlowNames;
            this.GeolocationCountries = geolocationCountries;
            this.GeolocationStates = geolocationStates;
            this.LanguageIsoCodes = languageIsoCodes;
            this.MaxValues = maxValues;
            this.PageViews = pageViews;
            this.TimeOnSiteMax = timeOnSiteMax;
            this.TimeOnSiteMin = timeOnSiteMin;
            this.Urls = urls;
            this.UserAgentDeviceNames = userAgentDeviceNames;
            this.UserAgentDeviceOsNames = userAgentDeviceOsNames;
            this.UserAgentDeviceOsVersions = userAgentDeviceOsVersions;
            this.UserAgentNames = userAgentNames;
            this.UserAgentOriginals = userAgentOriginals;
            this.UtmCampaigns = utmCampaigns;
            this.UtmSources = utmSources;
        }
        
        /// <summary>
        /// Gets or Sets CommunicationsCampaignNames
        /// </summary>
        [DataMember(Name="communications_campaign_names", EmitDefaultValue=false)]
        public List<string> CommunicationsCampaignNames { get; set; }

        /// <summary>
        /// Gets or Sets CommunicationsEmailSubjects
        /// </summary>
        [DataMember(Name="communications_email_subjects", EmitDefaultValue=false)]
        public List<string> CommunicationsEmailSubjects { get; set; }

        /// <summary>
        /// Gets or Sets CommunicationsFlowNames
        /// </summary>
        [DataMember(Name="communications_flow_names", EmitDefaultValue=false)]
        public List<string> CommunicationsFlowNames { get; set; }

        /// <summary>
        /// Gets or Sets GeolocationCountries
        /// </summary>
        [DataMember(Name="geolocation_countries", EmitDefaultValue=false)]
        public List<string> GeolocationCountries { get; set; }

        /// <summary>
        /// Gets or Sets GeolocationStates
        /// </summary>
        [DataMember(Name="geolocation_states", EmitDefaultValue=false)]
        public List<string> GeolocationStates { get; set; }

        /// <summary>
        /// Gets or Sets LanguageIsoCodes
        /// </summary>
        [DataMember(Name="language_iso_codes", EmitDefaultValue=false)]
        public List<string> LanguageIsoCodes { get; set; }

        /// <summary>
        /// Gets or Sets MaxValues
        /// </summary>
        [DataMember(Name="max_values", EmitDefaultValue=false)]
        public int? MaxValues { get; set; }

        /// <summary>
        /// Gets or Sets PageViews
        /// </summary>
        [DataMember(Name="page_views", EmitDefaultValue=false)]
        public List<ScreenRecordingFilterValuesPageView> PageViews { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnSiteMax
        /// </summary>
        [DataMember(Name="time_on_site_max", EmitDefaultValue=false)]
        public int? TimeOnSiteMax { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnSiteMin
        /// </summary>
        [DataMember(Name="time_on_site_min", EmitDefaultValue=false)]
        public int? TimeOnSiteMin { get; set; }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentDeviceNames
        /// </summary>
        [DataMember(Name="user_agent_device_names", EmitDefaultValue=false)]
        public List<string> UserAgentDeviceNames { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentDeviceOsNames
        /// </summary>
        [DataMember(Name="user_agent_device_os_names", EmitDefaultValue=false)]
        public List<string> UserAgentDeviceOsNames { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentDeviceOsVersions
        /// </summary>
        [DataMember(Name="user_agent_device_os_versions", EmitDefaultValue=false)]
        public List<string> UserAgentDeviceOsVersions { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentNames
        /// </summary>
        [DataMember(Name="user_agent_names", EmitDefaultValue=false)]
        public List<string> UserAgentNames { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentOriginals
        /// </summary>
        [DataMember(Name="user_agent_originals", EmitDefaultValue=false)]
        public List<string> UserAgentOriginals { get; set; }

        /// <summary>
        /// Gets or Sets UtmCampaigns
        /// </summary>
        [DataMember(Name="utm_campaigns", EmitDefaultValue=false)]
        public List<string> UtmCampaigns { get; set; }

        /// <summary>
        /// Gets or Sets UtmSources
        /// </summary>
        [DataMember(Name="utm_sources", EmitDefaultValue=false)]
        public List<string> UtmSources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingFilterValues {\n");
            sb.Append("  CommunicationsCampaignNames: ").Append(CommunicationsCampaignNames).Append("\n");
            sb.Append("  CommunicationsEmailSubjects: ").Append(CommunicationsEmailSubjects).Append("\n");
            sb.Append("  CommunicationsFlowNames: ").Append(CommunicationsFlowNames).Append("\n");
            sb.Append("  GeolocationCountries: ").Append(GeolocationCountries).Append("\n");
            sb.Append("  GeolocationStates: ").Append(GeolocationStates).Append("\n");
            sb.Append("  LanguageIsoCodes: ").Append(LanguageIsoCodes).Append("\n");
            sb.Append("  MaxValues: ").Append(MaxValues).Append("\n");
            sb.Append("  PageViews: ").Append(PageViews).Append("\n");
            sb.Append("  TimeOnSiteMax: ").Append(TimeOnSiteMax).Append("\n");
            sb.Append("  TimeOnSiteMin: ").Append(TimeOnSiteMin).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  UserAgentDeviceNames: ").Append(UserAgentDeviceNames).Append("\n");
            sb.Append("  UserAgentDeviceOsNames: ").Append(UserAgentDeviceOsNames).Append("\n");
            sb.Append("  UserAgentDeviceOsVersions: ").Append(UserAgentDeviceOsVersions).Append("\n");
            sb.Append("  UserAgentNames: ").Append(UserAgentNames).Append("\n");
            sb.Append("  UserAgentOriginals: ").Append(UserAgentOriginals).Append("\n");
            sb.Append("  UtmCampaigns: ").Append(UtmCampaigns).Append("\n");
            sb.Append("  UtmSources: ").Append(UtmSources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScreenRecordingFilterValues);
        }

        /// <summary>
        /// Returns true if ScreenRecordingFilterValues instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingFilterValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingFilterValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommunicationsCampaignNames == input.CommunicationsCampaignNames ||
                    this.CommunicationsCampaignNames != null &&
                    this.CommunicationsCampaignNames.SequenceEqual(input.CommunicationsCampaignNames)
                ) && 
                (
                    this.CommunicationsEmailSubjects == input.CommunicationsEmailSubjects ||
                    this.CommunicationsEmailSubjects != null &&
                    this.CommunicationsEmailSubjects.SequenceEqual(input.CommunicationsEmailSubjects)
                ) && 
                (
                    this.CommunicationsFlowNames == input.CommunicationsFlowNames ||
                    this.CommunicationsFlowNames != null &&
                    this.CommunicationsFlowNames.SequenceEqual(input.CommunicationsFlowNames)
                ) && 
                (
                    this.GeolocationCountries == input.GeolocationCountries ||
                    this.GeolocationCountries != null &&
                    this.GeolocationCountries.SequenceEqual(input.GeolocationCountries)
                ) && 
                (
                    this.GeolocationStates == input.GeolocationStates ||
                    this.GeolocationStates != null &&
                    this.GeolocationStates.SequenceEqual(input.GeolocationStates)
                ) && 
                (
                    this.LanguageIsoCodes == input.LanguageIsoCodes ||
                    this.LanguageIsoCodes != null &&
                    this.LanguageIsoCodes.SequenceEqual(input.LanguageIsoCodes)
                ) && 
                (
                    this.MaxValues == input.MaxValues ||
                    (this.MaxValues != null &&
                    this.MaxValues.Equals(input.MaxValues))
                ) && 
                (
                    this.PageViews == input.PageViews ||
                    this.PageViews != null &&
                    this.PageViews.SequenceEqual(input.PageViews)
                ) && 
                (
                    this.TimeOnSiteMax == input.TimeOnSiteMax ||
                    (this.TimeOnSiteMax != null &&
                    this.TimeOnSiteMax.Equals(input.TimeOnSiteMax))
                ) && 
                (
                    this.TimeOnSiteMin == input.TimeOnSiteMin ||
                    (this.TimeOnSiteMin != null &&
                    this.TimeOnSiteMin.Equals(input.TimeOnSiteMin))
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.UserAgentDeviceNames == input.UserAgentDeviceNames ||
                    this.UserAgentDeviceNames != null &&
                    this.UserAgentDeviceNames.SequenceEqual(input.UserAgentDeviceNames)
                ) && 
                (
                    this.UserAgentDeviceOsNames == input.UserAgentDeviceOsNames ||
                    this.UserAgentDeviceOsNames != null &&
                    this.UserAgentDeviceOsNames.SequenceEqual(input.UserAgentDeviceOsNames)
                ) && 
                (
                    this.UserAgentDeviceOsVersions == input.UserAgentDeviceOsVersions ||
                    this.UserAgentDeviceOsVersions != null &&
                    this.UserAgentDeviceOsVersions.SequenceEqual(input.UserAgentDeviceOsVersions)
                ) && 
                (
                    this.UserAgentNames == input.UserAgentNames ||
                    this.UserAgentNames != null &&
                    this.UserAgentNames.SequenceEqual(input.UserAgentNames)
                ) && 
                (
                    this.UserAgentOriginals == input.UserAgentOriginals ||
                    this.UserAgentOriginals != null &&
                    this.UserAgentOriginals.SequenceEqual(input.UserAgentOriginals)
                ) && 
                (
                    this.UtmCampaigns == input.UtmCampaigns ||
                    this.UtmCampaigns != null &&
                    this.UtmCampaigns.SequenceEqual(input.UtmCampaigns)
                ) && 
                (
                    this.UtmSources == input.UtmSources ||
                    this.UtmSources != null &&
                    this.UtmSources.SequenceEqual(input.UtmSources)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CommunicationsCampaignNames != null)
                    hashCode = hashCode * 59 + this.CommunicationsCampaignNames.GetHashCode();
                if (this.CommunicationsEmailSubjects != null)
                    hashCode = hashCode * 59 + this.CommunicationsEmailSubjects.GetHashCode();
                if (this.CommunicationsFlowNames != null)
                    hashCode = hashCode * 59 + this.CommunicationsFlowNames.GetHashCode();
                if (this.GeolocationCountries != null)
                    hashCode = hashCode * 59 + this.GeolocationCountries.GetHashCode();
                if (this.GeolocationStates != null)
                    hashCode = hashCode * 59 + this.GeolocationStates.GetHashCode();
                if (this.LanguageIsoCodes != null)
                    hashCode = hashCode * 59 + this.LanguageIsoCodes.GetHashCode();
                if (this.MaxValues != null)
                    hashCode = hashCode * 59 + this.MaxValues.GetHashCode();
                if (this.PageViews != null)
                    hashCode = hashCode * 59 + this.PageViews.GetHashCode();
                if (this.TimeOnSiteMax != null)
                    hashCode = hashCode * 59 + this.TimeOnSiteMax.GetHashCode();
                if (this.TimeOnSiteMin != null)
                    hashCode = hashCode * 59 + this.TimeOnSiteMin.GetHashCode();
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.UserAgentDeviceNames != null)
                    hashCode = hashCode * 59 + this.UserAgentDeviceNames.GetHashCode();
                if (this.UserAgentDeviceOsNames != null)
                    hashCode = hashCode * 59 + this.UserAgentDeviceOsNames.GetHashCode();
                if (this.UserAgentDeviceOsVersions != null)
                    hashCode = hashCode * 59 + this.UserAgentDeviceOsVersions.GetHashCode();
                if (this.UserAgentNames != null)
                    hashCode = hashCode * 59 + this.UserAgentNames.GetHashCode();
                if (this.UserAgentOriginals != null)
                    hashCode = hashCode * 59 + this.UserAgentOriginals.GetHashCode();
                if (this.UtmCampaigns != null)
                    hashCode = hashCode * 59 + this.UtmCampaigns.GetHashCode();
                if (this.UtmSources != null)
                    hashCode = hashCode * 59 + this.UtmSources.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

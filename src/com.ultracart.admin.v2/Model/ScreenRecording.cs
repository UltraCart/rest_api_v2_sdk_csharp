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
    /// ScreenRecording
    /// </summary>
    [DataContract]
    public partial class ScreenRecording :  IEquatable<ScreenRecording>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecording" /> class.
        /// </summary>
        /// <param name="analyticsClientOid">analyticsClientOid.</param>
        /// <param name="analyticsSessionDts">analyticsSessionDts.</param>
        /// <param name="analyticsSessionOid">analyticsSessionOid.</param>
        /// <param name="email">email.</param>
        /// <param name="endTimestamp">Ending timestamp.</param>
        /// <param name="espCustomerUuid">espCustomerUuid.</param>
        /// <param name="eventsGzSize">eventsGzSize.</param>
        /// <param name="eventsJsonKey">eventsJsonKey.</param>
        /// <param name="favorite">True if the user calling the API has favorited this particular screen recording..</param>
        /// <param name="favorites">Array of user ids that favorited this particular screen recording..</param>
        /// <param name="geolocation">geolocation.</param>
        /// <param name="geolocationCountry">geolocationCountry.</param>
        /// <param name="geolocationState">geolocationState.</param>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="merchantNotes">merchantNotes.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="pageViewCount">pageViewCount.</param>
        /// <param name="pageViews">pageViews.</param>
        /// <param name="rrwebVersion">rrwebVersion.</param>
        /// <param name="screenRecordingUuid">screenRecordingUuid.</param>
        /// <param name="signedDownloadUrl">signedDownloadUrl.</param>
        /// <param name="startTimestamp">Starting timestamp.</param>
        /// <param name="storefrontOids">storefrontOids.</param>
        /// <param name="storefronts">storefronts.</param>
        /// <param name="tags">tags.</param>
        /// <param name="timeOnSite">timeOnSite.</param>
        /// <param name="ucacid">ucacid.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="userAgentRaw">userAgentRaw.</param>
        /// <param name="userIp">userIp.</param>
        /// <param name="userProperties">userProperties.</param>
        /// <param name="visitorNumber">visitorNumber.</param>
        /// <param name="watched">watched.</param>
        /// <param name="windowHeight">windowHeight.</param>
        /// <param name="windowWidth">windowWidth.</param>
        public ScreenRecording(long? analyticsClientOid = default(long?), long? analyticsSessionDts = default(long?), long? analyticsSessionOid = default(long?), string email = default(string), string endTimestamp = default(string), string espCustomerUuid = default(string), int? eventsGzSize = default(int?), string eventsJsonKey = default(string), bool? favorite = default(bool?), List<int?> favorites = default(List<int?>), GeoPoint geolocation = default(GeoPoint), string geolocationCountry = default(string), string geolocationState = default(string), string merchantId = default(string), string merchantNotes = default(string), string orderId = default(string), int? pageViewCount = default(int?), List<ScreenRecordingPageView> pageViews = default(List<ScreenRecordingPageView>), string rrwebVersion = default(string), string screenRecordingUuid = default(string), string signedDownloadUrl = default(string), string startTimestamp = default(string), List<int?> storefrontOids = default(List<int?>), List<ScreenRecordingStoreFront> storefronts = default(List<ScreenRecordingStoreFront>), List<string> tags = default(List<string>), int? timeOnSite = default(int?), string ucacid = default(string), ScreenRecordingUserAgent userAgent = default(ScreenRecordingUserAgent), string userAgentRaw = default(string), string userIp = default(string), List<ScreenRecordingUserProperty> userProperties = default(List<ScreenRecordingUserProperty>), int? visitorNumber = default(int?), bool? watched = default(bool?), int? windowHeight = default(int?), int? windowWidth = default(int?))
        {
            this.AnalyticsClientOid = analyticsClientOid;
            this.AnalyticsSessionDts = analyticsSessionDts;
            this.AnalyticsSessionOid = analyticsSessionOid;
            this.Email = email;
            this.EndTimestamp = endTimestamp;
            this.EspCustomerUuid = espCustomerUuid;
            this.EventsGzSize = eventsGzSize;
            this.EventsJsonKey = eventsJsonKey;
            this.Favorite = favorite;
            this.Favorites = favorites;
            this.Geolocation = geolocation;
            this.GeolocationCountry = geolocationCountry;
            this.GeolocationState = geolocationState;
            this.MerchantId = merchantId;
            this.MerchantNotes = merchantNotes;
            this.OrderId = orderId;
            this.PageViewCount = pageViewCount;
            this.PageViews = pageViews;
            this.RrwebVersion = rrwebVersion;
            this.ScreenRecordingUuid = screenRecordingUuid;
            this.SignedDownloadUrl = signedDownloadUrl;
            this.StartTimestamp = startTimestamp;
            this.StorefrontOids = storefrontOids;
            this.Storefronts = storefronts;
            this.Tags = tags;
            this.TimeOnSite = timeOnSite;
            this.Ucacid = ucacid;
            this.UserAgent = userAgent;
            this.UserAgentRaw = userAgentRaw;
            this.UserIp = userIp;
            this.UserProperties = userProperties;
            this.VisitorNumber = visitorNumber;
            this.Watched = watched;
            this.WindowHeight = windowHeight;
            this.WindowWidth = windowWidth;
        }
        
        /// <summary>
        /// Gets or Sets AnalyticsClientOid
        /// </summary>
        [DataMember(Name="analytics_client_oid", EmitDefaultValue=false)]
        public long? AnalyticsClientOid { get; set; }

        /// <summary>
        /// Gets or Sets AnalyticsSessionDts
        /// </summary>
        [DataMember(Name="analytics_session_dts", EmitDefaultValue=false)]
        public long? AnalyticsSessionDts { get; set; }

        /// <summary>
        /// Gets or Sets AnalyticsSessionOid
        /// </summary>
        [DataMember(Name="analytics_session_oid", EmitDefaultValue=false)]
        public long? AnalyticsSessionOid { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Ending timestamp
        /// </summary>
        /// <value>Ending timestamp</value>
        [DataMember(Name="end_timestamp", EmitDefaultValue=false)]
        public string EndTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets EspCustomerUuid
        /// </summary>
        [DataMember(Name="esp_customer_uuid", EmitDefaultValue=false)]
        public string EspCustomerUuid { get; set; }

        /// <summary>
        /// Gets or Sets EventsGzSize
        /// </summary>
        [DataMember(Name="events_gz_size", EmitDefaultValue=false)]
        public int? EventsGzSize { get; set; }

        /// <summary>
        /// Gets or Sets EventsJsonKey
        /// </summary>
        [DataMember(Name="events_json_key", EmitDefaultValue=false)]
        public string EventsJsonKey { get; set; }

        /// <summary>
        /// True if the user calling the API has favorited this particular screen recording.
        /// </summary>
        /// <value>True if the user calling the API has favorited this particular screen recording.</value>
        [DataMember(Name="favorite", EmitDefaultValue=false)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// Array of user ids that favorited this particular screen recording.
        /// </summary>
        /// <value>Array of user ids that favorited this particular screen recording.</value>
        [DataMember(Name="favorites", EmitDefaultValue=false)]
        public List<int?> Favorites { get; set; }

        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name="geolocation", EmitDefaultValue=false)]
        public GeoPoint Geolocation { get; set; }

        /// <summary>
        /// Gets or Sets GeolocationCountry
        /// </summary>
        [DataMember(Name="geolocation_country", EmitDefaultValue=false)]
        public string GeolocationCountry { get; set; }

        /// <summary>
        /// Gets or Sets GeolocationState
        /// </summary>
        [DataMember(Name="geolocation_state", EmitDefaultValue=false)]
        public string GeolocationState { get; set; }

        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantNotes
        /// </summary>
        [DataMember(Name="merchant_notes", EmitDefaultValue=false)]
        public string MerchantNotes { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PageViewCount
        /// </summary>
        [DataMember(Name="page_view_count", EmitDefaultValue=false)]
        public int? PageViewCount { get; set; }

        /// <summary>
        /// Gets or Sets PageViews
        /// </summary>
        [DataMember(Name="page_views", EmitDefaultValue=false)]
        public List<ScreenRecordingPageView> PageViews { get; set; }

        /// <summary>
        /// Gets or Sets RrwebVersion
        /// </summary>
        [DataMember(Name="rrweb_version", EmitDefaultValue=false)]
        public string RrwebVersion { get; set; }

        /// <summary>
        /// Gets or Sets ScreenRecordingUuid
        /// </summary>
        [DataMember(Name="screen_recording_uuid", EmitDefaultValue=false)]
        public string ScreenRecordingUuid { get; set; }

        /// <summary>
        /// Gets or Sets SignedDownloadUrl
        /// </summary>
        [DataMember(Name="signed_download_url", EmitDefaultValue=false)]
        public string SignedDownloadUrl { get; set; }

        /// <summary>
        /// Starting timestamp
        /// </summary>
        /// <value>Starting timestamp</value>
        [DataMember(Name="start_timestamp", EmitDefaultValue=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets StorefrontOids
        /// </summary>
        [DataMember(Name="storefront_oids", EmitDefaultValue=false)]
        public List<int?> StorefrontOids { get; set; }

        /// <summary>
        /// Gets or Sets Storefronts
        /// </summary>
        [DataMember(Name="storefronts", EmitDefaultValue=false)]
        public List<ScreenRecordingStoreFront> Storefronts { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnSite
        /// </summary>
        [DataMember(Name="time_on_site", EmitDefaultValue=false)]
        public int? TimeOnSite { get; set; }

        /// <summary>
        /// Gets or Sets Ucacid
        /// </summary>
        [DataMember(Name="ucacid", EmitDefaultValue=false)]
        public string Ucacid { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public ScreenRecordingUserAgent UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets UserAgentRaw
        /// </summary>
        [DataMember(Name="user_agent_raw", EmitDefaultValue=false)]
        public string UserAgentRaw { get; set; }

        /// <summary>
        /// Gets or Sets UserIp
        /// </summary>
        [DataMember(Name="user_ip", EmitDefaultValue=false)]
        public string UserIp { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name="user_properties", EmitDefaultValue=false)]
        public List<ScreenRecordingUserProperty> UserProperties { get; set; }

        /// <summary>
        /// Gets or Sets VisitorNumber
        /// </summary>
        [DataMember(Name="visitor_number", EmitDefaultValue=false)]
        public int? VisitorNumber { get; set; }

        /// <summary>
        /// Gets or Sets Watched
        /// </summary>
        [DataMember(Name="watched", EmitDefaultValue=false)]
        public bool? Watched { get; set; }

        /// <summary>
        /// Gets or Sets WindowHeight
        /// </summary>
        [DataMember(Name="window_height", EmitDefaultValue=false)]
        public int? WindowHeight { get; set; }

        /// <summary>
        /// Gets or Sets WindowWidth
        /// </summary>
        [DataMember(Name="window_width", EmitDefaultValue=false)]
        public int? WindowWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecording {\n");
            sb.Append("  AnalyticsClientOid: ").Append(AnalyticsClientOid).Append("\n");
            sb.Append("  AnalyticsSessionDts: ").Append(AnalyticsSessionDts).Append("\n");
            sb.Append("  AnalyticsSessionOid: ").Append(AnalyticsSessionOid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EndTimestamp: ").Append(EndTimestamp).Append("\n");
            sb.Append("  EspCustomerUuid: ").Append(EspCustomerUuid).Append("\n");
            sb.Append("  EventsGzSize: ").Append(EventsGzSize).Append("\n");
            sb.Append("  EventsJsonKey: ").Append(EventsJsonKey).Append("\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Favorites: ").Append(Favorites).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  GeolocationCountry: ").Append(GeolocationCountry).Append("\n");
            sb.Append("  GeolocationState: ").Append(GeolocationState).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantNotes: ").Append(MerchantNotes).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PageViewCount: ").Append(PageViewCount).Append("\n");
            sb.Append("  PageViews: ").Append(PageViews).Append("\n");
            sb.Append("  RrwebVersion: ").Append(RrwebVersion).Append("\n");
            sb.Append("  ScreenRecordingUuid: ").Append(ScreenRecordingUuid).Append("\n");
            sb.Append("  SignedDownloadUrl: ").Append(SignedDownloadUrl).Append("\n");
            sb.Append("  StartTimestamp: ").Append(StartTimestamp).Append("\n");
            sb.Append("  StorefrontOids: ").Append(StorefrontOids).Append("\n");
            sb.Append("  Storefronts: ").Append(Storefronts).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TimeOnSite: ").Append(TimeOnSite).Append("\n");
            sb.Append("  Ucacid: ").Append(Ucacid).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  UserAgentRaw: ").Append(UserAgentRaw).Append("\n");
            sb.Append("  UserIp: ").Append(UserIp).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  VisitorNumber: ").Append(VisitorNumber).Append("\n");
            sb.Append("  Watched: ").Append(Watched).Append("\n");
            sb.Append("  WindowHeight: ").Append(WindowHeight).Append("\n");
            sb.Append("  WindowWidth: ").Append(WindowWidth).Append("\n");
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
            return this.Equals(input as ScreenRecording);
        }

        /// <summary>
        /// Returns true if ScreenRecording instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecording input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnalyticsClientOid == input.AnalyticsClientOid ||
                    (this.AnalyticsClientOid != null &&
                    this.AnalyticsClientOid.Equals(input.AnalyticsClientOid))
                ) && 
                (
                    this.AnalyticsSessionDts == input.AnalyticsSessionDts ||
                    (this.AnalyticsSessionDts != null &&
                    this.AnalyticsSessionDts.Equals(input.AnalyticsSessionDts))
                ) && 
                (
                    this.AnalyticsSessionOid == input.AnalyticsSessionOid ||
                    (this.AnalyticsSessionOid != null &&
                    this.AnalyticsSessionOid.Equals(input.AnalyticsSessionOid))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EndTimestamp == input.EndTimestamp ||
                    (this.EndTimestamp != null &&
                    this.EndTimestamp.Equals(input.EndTimestamp))
                ) && 
                (
                    this.EspCustomerUuid == input.EspCustomerUuid ||
                    (this.EspCustomerUuid != null &&
                    this.EspCustomerUuid.Equals(input.EspCustomerUuid))
                ) && 
                (
                    this.EventsGzSize == input.EventsGzSize ||
                    (this.EventsGzSize != null &&
                    this.EventsGzSize.Equals(input.EventsGzSize))
                ) && 
                (
                    this.EventsJsonKey == input.EventsJsonKey ||
                    (this.EventsJsonKey != null &&
                    this.EventsJsonKey.Equals(input.EventsJsonKey))
                ) && 
                (
                    this.Favorite == input.Favorite ||
                    (this.Favorite != null &&
                    this.Favorite.Equals(input.Favorite))
                ) && 
                (
                    this.Favorites == input.Favorites ||
                    this.Favorites != null &&
                    this.Favorites.SequenceEqual(input.Favorites)
                ) && 
                (
                    this.Geolocation == input.Geolocation ||
                    (this.Geolocation != null &&
                    this.Geolocation.Equals(input.Geolocation))
                ) && 
                (
                    this.GeolocationCountry == input.GeolocationCountry ||
                    (this.GeolocationCountry != null &&
                    this.GeolocationCountry.Equals(input.GeolocationCountry))
                ) && 
                (
                    this.GeolocationState == input.GeolocationState ||
                    (this.GeolocationState != null &&
                    this.GeolocationState.Equals(input.GeolocationState))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantNotes == input.MerchantNotes ||
                    (this.MerchantNotes != null &&
                    this.MerchantNotes.Equals(input.MerchantNotes))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PageViewCount == input.PageViewCount ||
                    (this.PageViewCount != null &&
                    this.PageViewCount.Equals(input.PageViewCount))
                ) && 
                (
                    this.PageViews == input.PageViews ||
                    this.PageViews != null &&
                    this.PageViews.SequenceEqual(input.PageViews)
                ) && 
                (
                    this.RrwebVersion == input.RrwebVersion ||
                    (this.RrwebVersion != null &&
                    this.RrwebVersion.Equals(input.RrwebVersion))
                ) && 
                (
                    this.ScreenRecordingUuid == input.ScreenRecordingUuid ||
                    (this.ScreenRecordingUuid != null &&
                    this.ScreenRecordingUuid.Equals(input.ScreenRecordingUuid))
                ) && 
                (
                    this.SignedDownloadUrl == input.SignedDownloadUrl ||
                    (this.SignedDownloadUrl != null &&
                    this.SignedDownloadUrl.Equals(input.SignedDownloadUrl))
                ) && 
                (
                    this.StartTimestamp == input.StartTimestamp ||
                    (this.StartTimestamp != null &&
                    this.StartTimestamp.Equals(input.StartTimestamp))
                ) && 
                (
                    this.StorefrontOids == input.StorefrontOids ||
                    this.StorefrontOids != null &&
                    this.StorefrontOids.SequenceEqual(input.StorefrontOids)
                ) && 
                (
                    this.Storefronts == input.Storefronts ||
                    this.Storefronts != null &&
                    this.Storefronts.SequenceEqual(input.Storefronts)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TimeOnSite == input.TimeOnSite ||
                    (this.TimeOnSite != null &&
                    this.TimeOnSite.Equals(input.TimeOnSite))
                ) && 
                (
                    this.Ucacid == input.Ucacid ||
                    (this.Ucacid != null &&
                    this.Ucacid.Equals(input.Ucacid))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.UserAgentRaw == input.UserAgentRaw ||
                    (this.UserAgentRaw != null &&
                    this.UserAgentRaw.Equals(input.UserAgentRaw))
                ) && 
                (
                    this.UserIp == input.UserIp ||
                    (this.UserIp != null &&
                    this.UserIp.Equals(input.UserIp))
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
                ) && 
                (
                    this.VisitorNumber == input.VisitorNumber ||
                    (this.VisitorNumber != null &&
                    this.VisitorNumber.Equals(input.VisitorNumber))
                ) && 
                (
                    this.Watched == input.Watched ||
                    (this.Watched != null &&
                    this.Watched.Equals(input.Watched))
                ) && 
                (
                    this.WindowHeight == input.WindowHeight ||
                    (this.WindowHeight != null &&
                    this.WindowHeight.Equals(input.WindowHeight))
                ) && 
                (
                    this.WindowWidth == input.WindowWidth ||
                    (this.WindowWidth != null &&
                    this.WindowWidth.Equals(input.WindowWidth))
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
                if (this.AnalyticsClientOid != null)
                    hashCode = hashCode * 59 + this.AnalyticsClientOid.GetHashCode();
                if (this.AnalyticsSessionDts != null)
                    hashCode = hashCode * 59 + this.AnalyticsSessionDts.GetHashCode();
                if (this.AnalyticsSessionOid != null)
                    hashCode = hashCode * 59 + this.AnalyticsSessionOid.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EndTimestamp != null)
                    hashCode = hashCode * 59 + this.EndTimestamp.GetHashCode();
                if (this.EspCustomerUuid != null)
                    hashCode = hashCode * 59 + this.EspCustomerUuid.GetHashCode();
                if (this.EventsGzSize != null)
                    hashCode = hashCode * 59 + this.EventsGzSize.GetHashCode();
                if (this.EventsJsonKey != null)
                    hashCode = hashCode * 59 + this.EventsJsonKey.GetHashCode();
                if (this.Favorite != null)
                    hashCode = hashCode * 59 + this.Favorite.GetHashCode();
                if (this.Favorites != null)
                    hashCode = hashCode * 59 + this.Favorites.GetHashCode();
                if (this.Geolocation != null)
                    hashCode = hashCode * 59 + this.Geolocation.GetHashCode();
                if (this.GeolocationCountry != null)
                    hashCode = hashCode * 59 + this.GeolocationCountry.GetHashCode();
                if (this.GeolocationState != null)
                    hashCode = hashCode * 59 + this.GeolocationState.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MerchantNotes != null)
                    hashCode = hashCode * 59 + this.MerchantNotes.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PageViewCount != null)
                    hashCode = hashCode * 59 + this.PageViewCount.GetHashCode();
                if (this.PageViews != null)
                    hashCode = hashCode * 59 + this.PageViews.GetHashCode();
                if (this.RrwebVersion != null)
                    hashCode = hashCode * 59 + this.RrwebVersion.GetHashCode();
                if (this.ScreenRecordingUuid != null)
                    hashCode = hashCode * 59 + this.ScreenRecordingUuid.GetHashCode();
                if (this.SignedDownloadUrl != null)
                    hashCode = hashCode * 59 + this.SignedDownloadUrl.GetHashCode();
                if (this.StartTimestamp != null)
                    hashCode = hashCode * 59 + this.StartTimestamp.GetHashCode();
                if (this.StorefrontOids != null)
                    hashCode = hashCode * 59 + this.StorefrontOids.GetHashCode();
                if (this.Storefronts != null)
                    hashCode = hashCode * 59 + this.Storefronts.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TimeOnSite != null)
                    hashCode = hashCode * 59 + this.TimeOnSite.GetHashCode();
                if (this.Ucacid != null)
                    hashCode = hashCode * 59 + this.Ucacid.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.UserAgentRaw != null)
                    hashCode = hashCode * 59 + this.UserAgentRaw.GetHashCode();
                if (this.UserIp != null)
                    hashCode = hashCode * 59 + this.UserIp.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.VisitorNumber != null)
                    hashCode = hashCode * 59 + this.VisitorNumber.GetHashCode();
                if (this.Watched != null)
                    hashCode = hashCode * 59 + this.Watched.GetHashCode();
                if (this.WindowHeight != null)
                    hashCode = hashCode * 59 + this.WindowHeight.GetHashCode();
                if (this.WindowWidth != null)
                    hashCode = hashCode * 59 + this.WindowWidth.GetHashCode();
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

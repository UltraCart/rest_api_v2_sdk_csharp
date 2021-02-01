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
    /// ScreenRecordingPageView
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingPageView :  IEquatable<ScreenRecordingPageView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingPageView" /> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="firstEventTimestamp">First event timestamp.</param>
        /// <param name="httpPost">httpPost.</param>
        /// <param name="lastEventTimestamp">Last event timestamp.</param>
        /// <param name="_params">_params.</param>
        /// <param name="rangeEnd">rangeEnd.</param>
        /// <param name="rangeStart">rangeStart.</param>
        /// <param name="referrer">referrer.</param>
        /// <param name="referrerParams">referrerParams.</param>
        /// <param name="referrerRaw">referrerRaw.</param>
        /// <param name="screenRecordingPageViewUuid">screenRecordingPageViewUuid.</param>
        /// <param name="timeOnPage">timeOnPage.</param>
        /// <param name="truncatedEvents">truncatedEvents.</param>
        /// <param name="ucapv">ucapv.</param>
        /// <param name="url">url.</param>
        public ScreenRecordingPageView(List<ScreenRecordingPageViewEvent> events = default(List<ScreenRecordingPageViewEvent>), string firstEventTimestamp = default(string), bool? httpPost = default(bool?), string lastEventTimestamp = default(string), List<ScreenRecordingPageViewParameter> _params = default(List<ScreenRecordingPageViewParameter>), int? rangeEnd = default(int?), int? rangeStart = default(int?), string referrer = default(string), List<ScreenRecordingPageViewParameter> referrerParams = default(List<ScreenRecordingPageViewParameter>), string referrerRaw = default(string), string screenRecordingPageViewUuid = default(string), int? timeOnPage = default(int?), bool? truncatedEvents = default(bool?), string ucapv = default(string), string url = default(string))
        {
            this.Events = events;
            this.FirstEventTimestamp = firstEventTimestamp;
            this.HttpPost = httpPost;
            this.LastEventTimestamp = lastEventTimestamp;
            this.Params = _params;
            this.RangeEnd = rangeEnd;
            this.RangeStart = rangeStart;
            this.Referrer = referrer;
            this.ReferrerParams = referrerParams;
            this.ReferrerRaw = referrerRaw;
            this.ScreenRecordingPageViewUuid = screenRecordingPageViewUuid;
            this.TimeOnPage = timeOnPage;
            this.TruncatedEvents = truncatedEvents;
            this.Ucapv = ucapv;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<ScreenRecordingPageViewEvent> Events { get; set; }

        /// <summary>
        /// First event timestamp
        /// </summary>
        /// <value>First event timestamp</value>
        [DataMember(Name="first_event_timestamp", EmitDefaultValue=false)]
        public string FirstEventTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets HttpPost
        /// </summary>
        [DataMember(Name="http_post", EmitDefaultValue=false)]
        public bool? HttpPost { get; set; }

        /// <summary>
        /// Last event timestamp
        /// </summary>
        /// <value>Last event timestamp</value>
        [DataMember(Name="last_event_timestamp", EmitDefaultValue=false)]
        public string LastEventTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public List<ScreenRecordingPageViewParameter> Params { get; set; }

        /// <summary>
        /// Gets or Sets RangeEnd
        /// </summary>
        [DataMember(Name="range_end", EmitDefaultValue=false)]
        public int? RangeEnd { get; set; }

        /// <summary>
        /// Gets or Sets RangeStart
        /// </summary>
        [DataMember(Name="range_start", EmitDefaultValue=false)]
        public int? RangeStart { get; set; }

        /// <summary>
        /// Gets or Sets Referrer
        /// </summary>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public string Referrer { get; set; }

        /// <summary>
        /// Gets or Sets ReferrerParams
        /// </summary>
        [DataMember(Name="referrer_params", EmitDefaultValue=false)]
        public List<ScreenRecordingPageViewParameter> ReferrerParams { get; set; }

        /// <summary>
        /// Gets or Sets ReferrerRaw
        /// </summary>
        [DataMember(Name="referrer_raw", EmitDefaultValue=false)]
        public string ReferrerRaw { get; set; }

        /// <summary>
        /// Gets or Sets ScreenRecordingPageViewUuid
        /// </summary>
        [DataMember(Name="screen_recording_page_view_uuid", EmitDefaultValue=false)]
        public string ScreenRecordingPageViewUuid { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnPage
        /// </summary>
        [DataMember(Name="time_on_page", EmitDefaultValue=false)]
        public int? TimeOnPage { get; set; }

        /// <summary>
        /// Gets or Sets TruncatedEvents
        /// </summary>
        [DataMember(Name="truncated_events", EmitDefaultValue=false)]
        public bool? TruncatedEvents { get; set; }

        /// <summary>
        /// Gets or Sets Ucapv
        /// </summary>
        [DataMember(Name="ucapv", EmitDefaultValue=false)]
        public string Ucapv { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingPageView {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  FirstEventTimestamp: ").Append(FirstEventTimestamp).Append("\n");
            sb.Append("  HttpPost: ").Append(HttpPost).Append("\n");
            sb.Append("  LastEventTimestamp: ").Append(LastEventTimestamp).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
            sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  ReferrerParams: ").Append(ReferrerParams).Append("\n");
            sb.Append("  ReferrerRaw: ").Append(ReferrerRaw).Append("\n");
            sb.Append("  ScreenRecordingPageViewUuid: ").Append(ScreenRecordingPageViewUuid).Append("\n");
            sb.Append("  TimeOnPage: ").Append(TimeOnPage).Append("\n");
            sb.Append("  TruncatedEvents: ").Append(TruncatedEvents).Append("\n");
            sb.Append("  Ucapv: ").Append(Ucapv).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ScreenRecordingPageView);
        }

        /// <summary>
        /// Returns true if ScreenRecordingPageView instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingPageView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingPageView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.FirstEventTimestamp == input.FirstEventTimestamp ||
                    (this.FirstEventTimestamp != null &&
                    this.FirstEventTimestamp.Equals(input.FirstEventTimestamp))
                ) && 
                (
                    this.HttpPost == input.HttpPost ||
                    (this.HttpPost != null &&
                    this.HttpPost.Equals(input.HttpPost))
                ) && 
                (
                    this.LastEventTimestamp == input.LastEventTimestamp ||
                    (this.LastEventTimestamp != null &&
                    this.LastEventTimestamp.Equals(input.LastEventTimestamp))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.RangeEnd == input.RangeEnd ||
                    (this.RangeEnd != null &&
                    this.RangeEnd.Equals(input.RangeEnd))
                ) && 
                (
                    this.RangeStart == input.RangeStart ||
                    (this.RangeStart != null &&
                    this.RangeStart.Equals(input.RangeStart))
                ) && 
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
                ) && 
                (
                    this.ReferrerParams == input.ReferrerParams ||
                    this.ReferrerParams != null &&
                    this.ReferrerParams.SequenceEqual(input.ReferrerParams)
                ) && 
                (
                    this.ReferrerRaw == input.ReferrerRaw ||
                    (this.ReferrerRaw != null &&
                    this.ReferrerRaw.Equals(input.ReferrerRaw))
                ) && 
                (
                    this.ScreenRecordingPageViewUuid == input.ScreenRecordingPageViewUuid ||
                    (this.ScreenRecordingPageViewUuid != null &&
                    this.ScreenRecordingPageViewUuid.Equals(input.ScreenRecordingPageViewUuid))
                ) && 
                (
                    this.TimeOnPage == input.TimeOnPage ||
                    (this.TimeOnPage != null &&
                    this.TimeOnPage.Equals(input.TimeOnPage))
                ) && 
                (
                    this.TruncatedEvents == input.TruncatedEvents ||
                    (this.TruncatedEvents != null &&
                    this.TruncatedEvents.Equals(input.TruncatedEvents))
                ) && 
                (
                    this.Ucapv == input.Ucapv ||
                    (this.Ucapv != null &&
                    this.Ucapv.Equals(input.Ucapv))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.FirstEventTimestamp != null)
                    hashCode = hashCode * 59 + this.FirstEventTimestamp.GetHashCode();
                if (this.HttpPost != null)
                    hashCode = hashCode * 59 + this.HttpPost.GetHashCode();
                if (this.LastEventTimestamp != null)
                    hashCode = hashCode * 59 + this.LastEventTimestamp.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.RangeEnd != null)
                    hashCode = hashCode * 59 + this.RangeEnd.GetHashCode();
                if (this.RangeStart != null)
                    hashCode = hashCode * 59 + this.RangeStart.GetHashCode();
                if (this.Referrer != null)
                    hashCode = hashCode * 59 + this.Referrer.GetHashCode();
                if (this.ReferrerParams != null)
                    hashCode = hashCode * 59 + this.ReferrerParams.GetHashCode();
                if (this.ReferrerRaw != null)
                    hashCode = hashCode * 59 + this.ReferrerRaw.GetHashCode();
                if (this.ScreenRecordingPageViewUuid != null)
                    hashCode = hashCode * 59 + this.ScreenRecordingPageViewUuid.GetHashCode();
                if (this.TimeOnPage != null)
                    hashCode = hashCode * 59 + this.TimeOnPage.GetHashCode();
                if (this.TruncatedEvents != null)
                    hashCode = hashCode * 59 + this.TruncatedEvents.GetHashCode();
                if (this.Ucapv != null)
                    hashCode = hashCode * 59 + this.Ucapv.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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

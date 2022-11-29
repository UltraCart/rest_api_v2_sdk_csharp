/*
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = com.ultracart.admin.v2.Client.OpenAPIDateConverter;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// HitPageView
    /// </summary>
    [DataContract]
    public partial class HitPageView :  IEquatable<HitPageView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HitPageView" /> class.
        /// </summary>
        /// <param name="bounce">bounce.</param>
        /// <param name="metaData">metaData.</param>
        /// <param name="method">method.</param>
        /// <param name="prefetch">prefetch.</param>
        /// <param name="query">query.</param>
        /// <param name="recording">recording.</param>
        /// <param name="redirect">redirect.</param>
        /// <param name="referrer">referrer.</param>
        /// <param name="timeOnPage">timeOnPage.</param>
        /// <param name="title">title.</param>
        /// <param name="url">url.</param>
        public HitPageView(bool bounce = default(bool), List<HitPageViewMetaData> metaData = default(List<HitPageViewMetaData>), string method = default(string), bool prefetch = default(bool), string query = default(string), bool recording = default(bool), bool redirect = default(bool), string referrer = default(string), decimal timeOnPage = default(decimal), string title = default(string), string url = default(string))
        {
            this.Bounce = bounce;
            this.MetaData = metaData;
            this.Method = method;
            this.Prefetch = prefetch;
            this.Query = query;
            this.Recording = recording;
            this.Redirect = redirect;
            this.Referrer = referrer;
            this.TimeOnPage = timeOnPage;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Bounce
        /// </summary>
        [DataMember(Name="bounce", EmitDefaultValue=false)]
        public bool Bounce { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name="meta_data", EmitDefaultValue=false)]
        public List<HitPageViewMetaData> MetaData { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Prefetch
        /// </summary>
        [DataMember(Name="prefetch", EmitDefaultValue=false)]
        public bool Prefetch { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool Recording { get; set; }

        /// <summary>
        /// Gets or Sets Redirect
        /// </summary>
        [DataMember(Name="redirect", EmitDefaultValue=false)]
        public bool Redirect { get; set; }

        /// <summary>
        /// Gets or Sets Referrer
        /// </summary>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public string Referrer { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnPage
        /// </summary>
        [DataMember(Name="time_on_page", EmitDefaultValue=false)]
        public decimal TimeOnPage { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
            sb.Append("class HitPageView {\n");
            sb.Append("  Bounce: ").Append(Bounce).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Prefetch: ").Append(Prefetch).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  TimeOnPage: ").Append(TimeOnPage).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HitPageView);
        }

        /// <summary>
        /// Returns true if HitPageView instances are equal
        /// </summary>
        /// <param name="input">Instance of HitPageView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HitPageView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bounce == input.Bounce ||
                    (this.Bounce != null &&
                    this.Bounce.Equals(input.Bounce))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Prefetch == input.Prefetch ||
                    (this.Prefetch != null &&
                    this.Prefetch.Equals(input.Prefetch))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Recording == input.Recording ||
                    (this.Recording != null &&
                    this.Recording.Equals(input.Recording))
                ) && 
                (
                    this.Redirect == input.Redirect ||
                    (this.Redirect != null &&
                    this.Redirect.Equals(input.Redirect))
                ) && 
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
                ) && 
                (
                    this.TimeOnPage == input.TimeOnPage ||
                    (this.TimeOnPage != null &&
                    this.TimeOnPage.Equals(input.TimeOnPage))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Bounce != null)
                    hashCode = hashCode * 59 + this.Bounce.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Prefetch != null)
                    hashCode = hashCode * 59 + this.Prefetch.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Recording != null)
                    hashCode = hashCode * 59 + this.Recording.GetHashCode();
                if (this.Redirect != null)
                    hashCode = hashCode * 59 + this.Redirect.GetHashCode();
                if (this.Referrer != null)
                    hashCode = hashCode * 59 + this.Referrer.GetHashCode();
                if (this.TimeOnPage != null)
                    hashCode = hashCode * 59 + this.TimeOnPage.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
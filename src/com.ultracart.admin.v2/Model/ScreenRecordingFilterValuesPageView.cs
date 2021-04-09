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
    /// ScreenRecordingFilterValuesPageView
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingFilterValuesPageView :  IEquatable<ScreenRecordingFilterValuesPageView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingFilterValuesPageView" /> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="pageParams">pageParams.</param>
        /// <param name="urls">urls.</param>
        public ScreenRecordingFilterValuesPageView(List<ScreenRecordingFilterValuesEvent> events = default(List<ScreenRecordingFilterValuesEvent>), List<ScreenRecordingFilterValuesPageParam> pageParams = default(List<ScreenRecordingFilterValuesPageParam>), List<string> urls = default(List<string>))
        {
            this.Events = events;
            this.PageParams = pageParams;
            this.Urls = urls;
        }
        
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<ScreenRecordingFilterValuesEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets PageParams
        /// </summary>
        [DataMember(Name="page_params", EmitDefaultValue=false)]
        public List<ScreenRecordingFilterValuesPageParam> PageParams { get; set; }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingFilterValuesPageView {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  PageParams: ").Append(PageParams).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
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
            return this.Equals(input as ScreenRecordingFilterValuesPageView);
        }

        /// <summary>
        /// Returns true if ScreenRecordingFilterValuesPageView instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingFilterValuesPageView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingFilterValuesPageView input)
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
                    this.PageParams == input.PageParams ||
                    this.PageParams != null &&
                    this.PageParams.SequenceEqual(input.PageParams)
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
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
                if (this.PageParams != null)
                    hashCode = hashCode * 59 + this.PageParams.GetHashCode();
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
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

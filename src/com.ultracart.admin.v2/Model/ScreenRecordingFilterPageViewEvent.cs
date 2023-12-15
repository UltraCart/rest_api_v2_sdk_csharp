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
    /// ScreenRecordingFilterPageViewEvent
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingFilterPageViewEvent :  IEquatable<ScreenRecordingFilterPageViewEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingFilterPageViewEvent" /> class.
        /// </summary>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventParams">eventParams.</param>
        public ScreenRecordingFilterPageViewEvent(string eventName = default(string), List<ScreenRecordingFilterPageViewEventParam> eventParams = default(List<ScreenRecordingFilterPageViewEventParam>))
        {
            this.EventName = eventName;
            this.EventParams = eventParams;
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets EventParams
        /// </summary>
        [DataMember(Name="event_params", EmitDefaultValue=false)]
        public List<ScreenRecordingFilterPageViewEventParam> EventParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingFilterPageViewEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventParams: ").Append(EventParams).Append("\n");
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
            return this.Equals(input as ScreenRecordingFilterPageViewEvent);
        }

        /// <summary>
        /// Returns true if ScreenRecordingFilterPageViewEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingFilterPageViewEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingFilterPageViewEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventParams == input.EventParams ||
                    this.EventParams != null &&
                    input.EventParams != null &&
                    this.EventParams.SequenceEqual(input.EventParams)
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
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventParams != null)
                    hashCode = hashCode * 59 + this.EventParams.GetHashCode();
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

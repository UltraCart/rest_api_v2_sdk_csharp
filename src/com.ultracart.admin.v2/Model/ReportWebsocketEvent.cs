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
    /// ReportWebsocketEvent
    /// </summary>
    [DataContract]
    public partial class ReportWebsocketEvent :  IEquatable<ReportWebsocketEvent>, IValidatableObject
    {
        /// <summary>
        /// Event type
        /// </summary>
        /// <value>Event type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum Ping for value: ping
            /// </summary>
            [EnumMember(Value = "ping")]
            Ping = 1,
            
            /// <summary>
            /// Enum Querycompletion for value: query completion
            /// </summary>
            [EnumMember(Value = "query completion")]
            Querycompletion = 2
        }

        /// <summary>
        /// Event type
        /// </summary>
        /// <value>Event type</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportWebsocketEvent" /> class.
        /// </summary>
        /// <param name="eventType">Event type.</param>
        /// <param name="queryCompletion">queryCompletion.</param>
        public ReportWebsocketEvent(EventTypeEnum? eventType = default(EventTypeEnum?), ReportDataSet queryCompletion = default(ReportDataSet))
        {
            this.EventType = eventType;
            this.QueryCompletion = queryCompletion;
        }
        

        /// <summary>
        /// Gets or Sets QueryCompletion
        /// </summary>
        [DataMember(Name="query_completion", EmitDefaultValue=false)]
        public ReportDataSet QueryCompletion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportWebsocketEvent {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  QueryCompletion: ").Append(QueryCompletion).Append("\n");
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
            return this.Equals(input as ReportWebsocketEvent);
        }

        /// <summary>
        /// Returns true if ReportWebsocketEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportWebsocketEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportWebsocketEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.QueryCompletion == input.QueryCompletion ||
                    (this.QueryCompletion != null &&
                    this.QueryCompletion.Equals(input.QueryCompletion))
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.QueryCompletion != null)
                    hashCode = hashCode * 59 + this.QueryCompletion.GetHashCode();
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

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
    /// Activity
    /// </summary>
    [DataContract]
    public partial class Activity :  IEquatable<Activity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="channel">channel.</param>
        /// <param name="metric">metric.</param>
        /// <param name="storefrontOid">storefrontOid.</param>
        /// <param name="subject">subject.</param>
        /// <param name="ts">ts.</param>
        /// <param name="type">type.</param>
        /// <param name="uuid">uuid.</param>
        public Activity(string action = default(string), string channel = default(string), string metric = default(string), int? storefrontOid = default(int?), string subject = default(string), long? ts = default(long?), string type = default(string), string uuid = default(string))
        {
            this.Action = action;
            this.Channel = channel;
            this.Metric = metric;
            this.StorefrontOid = storefrontOid;
            this.Subject = subject;
            this.Ts = ts;
            this.Type = type;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public string Metric { get; set; }

        /// <summary>
        /// Gets or Sets StorefrontOid
        /// </summary>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public long? Ts { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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

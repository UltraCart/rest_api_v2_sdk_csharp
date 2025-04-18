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
    /// CustomerPrivacy
    /// </summary>
    [DataContract]
    public partial class CustomerPrivacy :  IEquatable<CustomerPrivacy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPrivacy" /> class.
        /// </summary>
        /// <param name="lastUpdateDts">Last update date.</param>
        /// <param name="marketing">The customer has opted in to marketing.</param>
        /// <param name="preference">The customer has opted in to preference tracking.</param>
        /// <param name="statistics">The customer has opted in to statistics collection.</param>
        public CustomerPrivacy(string lastUpdateDts = default(string), bool marketing = default(bool), bool preference = default(bool), bool statistics = default(bool))
        {
            this.LastUpdateDts = lastUpdateDts;
            this.Marketing = marketing;
            this.Preference = preference;
            this.Statistics = statistics;
        }

        /// <summary>
        /// Last update date
        /// </summary>
        /// <value>Last update date</value>
        [DataMember(Name="last_update_dts", EmitDefaultValue=false)]
        public string LastUpdateDts { get; set; }

        /// <summary>
        /// The customer has opted in to marketing
        /// </summary>
        /// <value>The customer has opted in to marketing</value>
        [DataMember(Name="marketing", EmitDefaultValue=false)]
        public bool Marketing { get; set; }

        /// <summary>
        /// The customer has opted in to preference tracking
        /// </summary>
        /// <value>The customer has opted in to preference tracking</value>
        [DataMember(Name="preference", EmitDefaultValue=false)]
        public bool Preference { get; set; }

        /// <summary>
        /// The customer has opted in to statistics collection
        /// </summary>
        /// <value>The customer has opted in to statistics collection</value>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public bool Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPrivacy {\n");
            sb.Append("  LastUpdateDts: ").Append(LastUpdateDts).Append("\n");
            sb.Append("  Marketing: ").Append(Marketing).Append("\n");
            sb.Append("  Preference: ").Append(Preference).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(input as CustomerPrivacy);
        }

        /// <summary>
        /// Returns true if CustomerPrivacy instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPrivacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPrivacy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUpdateDts == input.LastUpdateDts ||
                    (this.LastUpdateDts != null &&
                    this.LastUpdateDts.Equals(input.LastUpdateDts))
                ) && 
                (
                    this.Marketing == input.Marketing ||
                    (this.Marketing != null &&
                    this.Marketing.Equals(input.Marketing))
                ) && 
                (
                    this.Preference == input.Preference ||
                    (this.Preference != null &&
                    this.Preference.Equals(input.Preference))
                ) && 
                (
                    this.Statistics == input.Statistics ||
                    (this.Statistics != null &&
                    this.Statistics.Equals(input.Statistics))
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
                if (this.LastUpdateDts != null)
                    hashCode = hashCode * 59 + this.LastUpdateDts.GetHashCode();
                if (this.Marketing != null)
                    hashCode = hashCode * 59 + this.Marketing.GetHashCode();
                if (this.Preference != null)
                    hashCode = hashCode * 59 + this.Preference.GetHashCode();
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
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

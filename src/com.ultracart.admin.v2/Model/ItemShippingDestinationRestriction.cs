/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// ItemShippingDestinationRestriction
    /// </summary>
    [DataContract]
    public partial class ItemShippingDestinationRestriction :  IEquatable<ItemShippingDestinationRestriction>, IValidatableObject
    {
        /// <summary>
        /// Validity
        /// </summary>
        /// <value>Validity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidityEnum
        {
            
            /// <summary>
            /// Enum Validonlyfor for "valid only for"
            /// </summary>
            [EnumMember(Value = "valid only for")]
            Validonlyfor,
            
            /// <summary>
            /// Enum Invalidfor for "invalid for"
            /// </summary>
            [EnumMember(Value = "invalid for")]
            Invalidfor
        }

        /// <summary>
        /// Validity
        /// </summary>
        /// <value>Validity</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public ValidityEnum? Validity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemShippingDestinationRestriction" /> class.
        /// </summary>
        /// <param name="CountryCode">Country code (ISO-3166 two letter).</param>
        /// <param name="State">State.</param>
        /// <param name="Validity">Validity.</param>
        public ItemShippingDestinationRestriction(string CountryCode = default(string), string State = default(string), ValidityEnum? Validity = default(ValidityEnum?))
        {
            this.CountryCode = CountryCode;
            this.State = State;
            this.Validity = Validity;
        }
        
        /// <summary>
        /// Country code (ISO-3166 two letter)
        /// </summary>
        /// <value>Country code (ISO-3166 two letter)</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemShippingDestinationRestriction {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ItemShippingDestinationRestriction);
        }

        /// <summary>
        /// Returns true if ItemShippingDestinationRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemShippingDestinationRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemShippingDestinationRestriction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
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
            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // State (string) maxLength
            if(this.State != null && this.State.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 32.", new [] { "State" });
            }

            yield break;
        }
    }

}

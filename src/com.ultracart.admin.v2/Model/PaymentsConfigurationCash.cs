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
    /// PaymentsConfigurationCash
    /// </summary>
    [DataContract]
    public partial class PaymentsConfigurationCash :  IEquatable<PaymentsConfigurationCash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfigurationCash" /> class.
        /// </summary>
        /// <param name="acceptCash">acceptCash.</param>
        /// <param name="restrictions">restrictions.</param>
        public PaymentsConfigurationCash(bool? acceptCash = default(bool?), PaymentsConfigurationRestrictions restrictions = default(PaymentsConfigurationRestrictions))
        {
            this.AcceptCash = acceptCash;
            this.Restrictions = restrictions;
        }
        
        /// <summary>
        /// Gets or Sets AcceptCash
        /// </summary>
        [DataMember(Name="acceptCash", EmitDefaultValue=false)]
        public bool? AcceptCash { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name="restrictions", EmitDefaultValue=false)]
        public PaymentsConfigurationRestrictions Restrictions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfigurationCash {\n");
            sb.Append("  AcceptCash: ").Append(AcceptCash).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
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
            return this.Equals(input as PaymentsConfigurationCash);
        }

        /// <summary>
        /// Returns true if PaymentsConfigurationCash instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsConfigurationCash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsConfigurationCash input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptCash == input.AcceptCash ||
                    (this.AcceptCash != null &&
                    this.AcceptCash.Equals(input.AcceptCash))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    (this.Restrictions != null &&
                    this.Restrictions.Equals(input.Restrictions))
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
                if (this.AcceptCash != null)
                    hashCode = hashCode * 59 + this.AcceptCash.GetHashCode();
                if (this.Restrictions != null)
                    hashCode = hashCode * 59 + this.Restrictions.GetHashCode();
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
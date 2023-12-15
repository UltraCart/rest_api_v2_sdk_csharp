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
    /// CheckoutStateProvinceResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutStateProvinceResponse :  IEquatable<CheckoutStateProvinceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutStateProvinceResponse" /> class.
        /// </summary>
        /// <param name="stateProvinces">stateProvinces.</param>
        public CheckoutStateProvinceResponse(List<StateProvince> stateProvinces = default(List<StateProvince>))
        {
            this.StateProvinces = stateProvinces;
        }

        /// <summary>
        /// Gets or Sets StateProvinces
        /// </summary>
        [DataMember(Name="stateProvinces", EmitDefaultValue=false)]
        public List<StateProvince> StateProvinces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutStateProvinceResponse {\n");
            sb.Append("  StateProvinces: ").Append(StateProvinces).Append("\n");
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
            return this.Equals(input as CheckoutStateProvinceResponse);
        }

        /// <summary>
        /// Returns true if CheckoutStateProvinceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutStateProvinceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutStateProvinceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StateProvinces == input.StateProvinces ||
                    this.StateProvinces != null &&
                    input.StateProvinces != null &&
                    this.StateProvinces.SequenceEqual(input.StateProvinces)
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
                if (this.StateProvinces != null)
                    hashCode = hashCode * 59 + this.StateProvinces.GetHashCode();
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

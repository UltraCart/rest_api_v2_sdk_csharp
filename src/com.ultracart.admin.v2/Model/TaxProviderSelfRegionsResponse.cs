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
    /// TaxProviderSelfRegionsResponse
    /// </summary>
    [DataContract]
    public partial class TaxProviderSelfRegionsResponse :  IEquatable<TaxProviderSelfRegionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxProviderSelfRegionsResponse" /> class.
        /// </summary>
        /// <param name="Regions">regions.</param>
        public TaxProviderSelfRegionsResponse(List<TaxStateCode> Regions = default(List<TaxStateCode>))
        {
            this.Regions = Regions;
        }
        
        /// <summary>
        /// regions
        /// </summary>
        /// <value>regions</value>
        [DataMember(Name="regions", EmitDefaultValue=false)]
        public List<TaxStateCode> Regions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxProviderSelfRegionsResponse {\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
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
            return this.Equals(input as TaxProviderSelfRegionsResponse);
        }

        /// <summary>
        /// Returns true if TaxProviderSelfRegionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxProviderSelfRegionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxProviderSelfRegionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
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
                if (this.Regions != null)
                    hashCode = hashCode * 59 + this.Regions.GetHashCode();
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

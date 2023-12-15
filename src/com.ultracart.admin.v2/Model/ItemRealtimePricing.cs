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
    /// ItemRealtimePricing
    /// </summary>
    [DataContract]
    public partial class ItemRealtimePricing :  IEquatable<ItemRealtimePricing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRealtimePricing" /> class.
        /// </summary>
        /// <param name="realtimePricingParameter">Real-time pricing provider parameters.</param>
        /// <param name="realtimePricingProvider">Real-time pricing provider name.</param>
        /// <param name="realtimePricingProviderOid">Real-time pricing provide object identifier.</param>
        public ItemRealtimePricing(string realtimePricingParameter = default(string), string realtimePricingProvider = default(string), int? realtimePricingProviderOid = default(int?))
        {
            this.RealtimePricingParameter = realtimePricingParameter;
            this.RealtimePricingProvider = realtimePricingProvider;
            this.RealtimePricingProviderOid = realtimePricingProviderOid;
        }
        
        /// <summary>
        /// Real-time pricing provider parameters
        /// </summary>
        /// <value>Real-time pricing provider parameters</value>
        [DataMember(Name="realtime_pricing_parameter", EmitDefaultValue=false)]
        public string RealtimePricingParameter { get; set; }

        /// <summary>
        /// Real-time pricing provider name
        /// </summary>
        /// <value>Real-time pricing provider name</value>
        [DataMember(Name="realtime_pricing_provider", EmitDefaultValue=false)]
        public string RealtimePricingProvider { get; set; }

        /// <summary>
        /// Real-time pricing provide object identifier
        /// </summary>
        /// <value>Real-time pricing provide object identifier</value>
        [DataMember(Name="realtime_pricing_provider_oid", EmitDefaultValue=false)]
        public int? RealtimePricingProviderOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRealtimePricing {\n");
            sb.Append("  RealtimePricingParameter: ").Append(RealtimePricingParameter).Append("\n");
            sb.Append("  RealtimePricingProvider: ").Append(RealtimePricingProvider).Append("\n");
            sb.Append("  RealtimePricingProviderOid: ").Append(RealtimePricingProviderOid).Append("\n");
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
            return this.Equals(input as ItemRealtimePricing);
        }

        /// <summary>
        /// Returns true if ItemRealtimePricing instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRealtimePricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRealtimePricing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RealtimePricingParameter == input.RealtimePricingParameter ||
                    (this.RealtimePricingParameter != null &&
                    this.RealtimePricingParameter.Equals(input.RealtimePricingParameter))
                ) && 
                (
                    this.RealtimePricingProvider == input.RealtimePricingProvider ||
                    (this.RealtimePricingProvider != null &&
                    this.RealtimePricingProvider.Equals(input.RealtimePricingProvider))
                ) && 
                (
                    this.RealtimePricingProviderOid == input.RealtimePricingProviderOid ||
                    (this.RealtimePricingProviderOid != null &&
                    this.RealtimePricingProviderOid.Equals(input.RealtimePricingProviderOid))
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
                if (this.RealtimePricingParameter != null)
                    hashCode = hashCode * 59 + this.RealtimePricingParameter.GetHashCode();
                if (this.RealtimePricingProvider != null)
                    hashCode = hashCode * 59 + this.RealtimePricingProvider.GetHashCode();
                if (this.RealtimePricingProviderOid != null)
                    hashCode = hashCode * 59 + this.RealtimePricingProviderOid.GetHashCode();
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

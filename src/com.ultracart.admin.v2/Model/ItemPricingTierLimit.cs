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
    /// ItemPricingTierLimit
    /// </summary>
    [DataContract]
    public partial class ItemPricingTierLimit :  IEquatable<ItemPricingTierLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPricingTierLimit" /> class.
        /// </summary>
        /// <param name="cumulativeOrderLimit">Cumulative order limit.</param>
        /// <param name="individualOrderLimit">Individual order limit.</param>
        /// <param name="multipleQuantity">Multiple quantity.</param>
        public ItemPricingTierLimit(int cumulativeOrderLimit = default(int), int individualOrderLimit = default(int), int multipleQuantity = default(int))
        {
            this.CumulativeOrderLimit = cumulativeOrderLimit;
            this.IndividualOrderLimit = individualOrderLimit;
            this.MultipleQuantity = multipleQuantity;
        }

        /// <summary>
        /// Cumulative order limit
        /// </summary>
        /// <value>Cumulative order limit</value>
        [DataMember(Name="cumulative_order_limit", EmitDefaultValue=false)]
        public int CumulativeOrderLimit { get; set; }

        /// <summary>
        /// Individual order limit
        /// </summary>
        /// <value>Individual order limit</value>
        [DataMember(Name="individual_order_limit", EmitDefaultValue=false)]
        public int IndividualOrderLimit { get; set; }

        /// <summary>
        /// Multiple quantity
        /// </summary>
        /// <value>Multiple quantity</value>
        [DataMember(Name="multiple_quantity", EmitDefaultValue=false)]
        public int MultipleQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemPricingTierLimit {\n");
            sb.Append("  CumulativeOrderLimit: ").Append(CumulativeOrderLimit).Append("\n");
            sb.Append("  IndividualOrderLimit: ").Append(IndividualOrderLimit).Append("\n");
            sb.Append("  MultipleQuantity: ").Append(MultipleQuantity).Append("\n");
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
            return this.Equals(input as ItemPricingTierLimit);
        }

        /// <summary>
        /// Returns true if ItemPricingTierLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemPricingTierLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPricingTierLimit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CumulativeOrderLimit == input.CumulativeOrderLimit ||
                    (this.CumulativeOrderLimit != null &&
                    this.CumulativeOrderLimit.Equals(input.CumulativeOrderLimit))
                ) && 
                (
                    this.IndividualOrderLimit == input.IndividualOrderLimit ||
                    (this.IndividualOrderLimit != null &&
                    this.IndividualOrderLimit.Equals(input.IndividualOrderLimit))
                ) && 
                (
                    this.MultipleQuantity == input.MultipleQuantity ||
                    (this.MultipleQuantity != null &&
                    this.MultipleQuantity.Equals(input.MultipleQuantity))
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
                if (this.CumulativeOrderLimit != null)
                    hashCode = hashCode * 59 + this.CumulativeOrderLimit.GetHashCode();
                if (this.IndividualOrderLimit != null)
                    hashCode = hashCode * 59 + this.IndividualOrderLimit.GetHashCode();
                if (this.MultipleQuantity != null)
                    hashCode = hashCode * 59 + this.MultipleQuantity.GetHashCode();
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

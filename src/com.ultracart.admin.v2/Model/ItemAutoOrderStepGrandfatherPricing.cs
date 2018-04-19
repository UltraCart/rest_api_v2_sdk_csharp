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
    /// ItemAutoOrderStepGrandfatherPricing
    /// </summary>
    [DataContract]
    public partial class ItemAutoOrderStepGrandfatherPricing :  IEquatable<ItemAutoOrderStepGrandfatherPricing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAutoOrderStepGrandfatherPricing" /> class.
        /// </summary>
        /// <param name="OnOrBeforeDate">On or before date.</param>
        /// <param name="UnitCost">Unit cost.</param>
        public ItemAutoOrderStepGrandfatherPricing(string OnOrBeforeDate = default(string), decimal? UnitCost = default(decimal?))
        {
            this.OnOrBeforeDate = OnOrBeforeDate;
            this.UnitCost = UnitCost;
        }
        
        /// <summary>
        /// On or before date
        /// </summary>
        /// <value>On or before date</value>
        [DataMember(Name="on_or_before_date", EmitDefaultValue=false)]
        public string OnOrBeforeDate { get; set; }

        /// <summary>
        /// Unit cost
        /// </summary>
        /// <value>Unit cost</value>
        [DataMember(Name="unit_cost", EmitDefaultValue=false)]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemAutoOrderStepGrandfatherPricing {\n");
            sb.Append("  OnOrBeforeDate: ").Append(OnOrBeforeDate).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
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
            return this.Equals(input as ItemAutoOrderStepGrandfatherPricing);
        }

        /// <summary>
        /// Returns true if ItemAutoOrderStepGrandfatherPricing instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemAutoOrderStepGrandfatherPricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemAutoOrderStepGrandfatherPricing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnOrBeforeDate == input.OnOrBeforeDate ||
                    (this.OnOrBeforeDate != null &&
                    this.OnOrBeforeDate.Equals(input.OnOrBeforeDate))
                ) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
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
                if (this.OnOrBeforeDate != null)
                    hashCode = hashCode * 59 + this.OnOrBeforeDate.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
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

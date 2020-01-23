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
    /// OrderQueryBatch
    /// </summary>
    [DataContract]
    public partial class OrderQueryBatch :  IEquatable<OrderQueryBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderQueryBatch" /> class.
        /// </summary>
        /// <param name="OrderIds">Order IDs.</param>
        public OrderQueryBatch(List<string> OrderIds = default(List<string>))
        {
            this.OrderIds = OrderIds;
        }
        
        /// <summary>
        /// Order IDs
        /// </summary>
        /// <value>Order IDs</value>
        [DataMember(Name="order_ids", EmitDefaultValue=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderQueryBatch {\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
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
            return this.Equals(input as OrderQueryBatch);
        }

        /// <summary>
        /// Returns true if OrderQueryBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderQueryBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderQueryBatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
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
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
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

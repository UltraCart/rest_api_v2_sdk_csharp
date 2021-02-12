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
    /// CouponBuyOneGetOneLimit
    /// </summary>
    [DataContract]
    public partial class CouponBuyOneGetOneLimit :  IEquatable<CouponBuyOneGetOneLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponBuyOneGetOneLimit" /> class.
        /// </summary>
        /// <param name="items">An optional list of items of which one must be purchased to receive free quantity of the same item..</param>
        /// <param name="limit">The limit of free items that may be received when purchasing multiple items.</param>
        public CouponBuyOneGetOneLimit(List<string> items = default(List<string>), int? limit = default(int?))
        {
            this.Items = items;
            this.Limit = limit;
        }
        
        /// <summary>
        /// An optional list of items of which one must be purchased to receive free quantity of the same item.
        /// </summary>
        /// <value>An optional list of items of which one must be purchased to receive free quantity of the same item.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// The limit of free items that may be received when purchasing multiple items
        /// </summary>
        /// <value>The limit of free items that may be received when purchasing multiple items</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponBuyOneGetOneLimit {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as CouponBuyOneGetOneLimit);
        }

        /// <summary>
        /// Returns true if CouponBuyOneGetOneLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponBuyOneGetOneLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponBuyOneGetOneLimit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
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
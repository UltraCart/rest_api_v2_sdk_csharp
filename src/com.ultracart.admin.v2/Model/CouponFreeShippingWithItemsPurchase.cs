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
    /// CouponFreeShippingWithItemsPurchase
    /// </summary>
    [DataContract]
    public partial class CouponFreeShippingWithItemsPurchase :  IEquatable<CouponFreeShippingWithItemsPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponFreeShippingWithItemsPurchase" /> class.
        /// </summary>
        /// <param name="items">A list of items of which at least one must be purchased for coupon to be valid..</param>
        /// <param name="shippingMethods">One or more shipping methods that may receive this discount.</param>
        public CouponFreeShippingWithItemsPurchase(List<string> items = default(List<string>), List<string> shippingMethods = default(List<string>))
        {
            this.Items = items;
            this.ShippingMethods = shippingMethods;
        }

        /// <summary>
        /// A list of items of which at least one must be purchased for coupon to be valid.
        /// </summary>
        /// <value>A list of items of which at least one must be purchased for coupon to be valid.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// One or more shipping methods that may receive this discount
        /// </summary>
        /// <value>One or more shipping methods that may receive this discount</value>
        [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
        public List<string> ShippingMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponFreeShippingWithItemsPurchase {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
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
            return this.Equals(input as CouponFreeShippingWithItemsPurchase);
        }

        /// <summary>
        /// Returns true if CouponFreeShippingWithItemsPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponFreeShippingWithItemsPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponFreeShippingWithItemsPurchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.ShippingMethods == input.ShippingMethods ||
                    this.ShippingMethods != null &&
                    input.ShippingMethods != null &&
                    this.ShippingMethods.SequenceEqual(input.ShippingMethods)
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
                if (this.ShippingMethods != null)
                    hashCode = hashCode * 59 + this.ShippingMethods.GetHashCode();
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

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
    /// ItemShippingDestinationMarkup
    /// </summary>
    [DataContract]
    public partial class ItemShippingDestinationMarkup :  IEquatable<ItemShippingDestinationMarkup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemShippingDestinationMarkup" /> class.
        /// </summary>
        /// <param name="countryCode">Country code (ISO-3166 two letter).</param>
        /// <param name="flatFee">Flat fee.</param>
        /// <param name="perItem">Per item.</param>
        /// <param name="postalCode">Postal code.</param>
        /// <param name="shippingMethod">Shipping method.</param>
        /// <param name="state">State.</param>
        public ItemShippingDestinationMarkup(string countryCode = default(string), decimal flatFee = default(decimal), decimal perItem = default(decimal), string postalCode = default(string), string shippingMethod = default(string), string state = default(string))
        {
            this.CountryCode = countryCode;
            this.FlatFee = flatFee;
            this.PerItem = perItem;
            this.PostalCode = postalCode;
            this.ShippingMethod = shippingMethod;
            this.State = state;
        }

        /// <summary>
        /// Country code (ISO-3166 two letter)
        /// </summary>
        /// <value>Country code (ISO-3166 two letter)</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Flat fee
        /// </summary>
        /// <value>Flat fee</value>
        [DataMember(Name="flat_fee", EmitDefaultValue=false)]
        public decimal FlatFee { get; set; }

        /// <summary>
        /// Per item
        /// </summary>
        /// <value>Per item</value>
        [DataMember(Name="per_item", EmitDefaultValue=false)]
        public decimal PerItem { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Shipping method
        /// </summary>
        /// <value>Shipping method</value>
        [DataMember(Name="shipping_method", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

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
            sb.Append("class ItemShippingDestinationMarkup {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FlatFee: ").Append(FlatFee).Append("\n");
            sb.Append("  PerItem: ").Append(PerItem).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as ItemShippingDestinationMarkup);
        }

        /// <summary>
        /// Returns true if ItemShippingDestinationMarkup instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemShippingDestinationMarkup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemShippingDestinationMarkup input)
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
                    this.FlatFee == input.FlatFee ||
                    (this.FlatFee != null &&
                    this.FlatFee.Equals(input.FlatFee))
                ) && 
                (
                    this.PerItem == input.PerItem ||
                    (this.PerItem != null &&
                    this.PerItem.Equals(input.PerItem))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.ShippingMethod == input.ShippingMethod ||
                    (this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(input.ShippingMethod))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.FlatFee != null)
                    hashCode = hashCode * 59 + this.FlatFee.GetHashCode();
                if (this.PerItem != null)
                    hashCode = hashCode * 59 + this.PerItem.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.ShippingMethod != null)
                    hashCode = hashCode * 59 + this.ShippingMethod.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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


            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 20.", new [] { "PostalCode" });
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

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
    /// CartItemOptionValue
    /// </summary>
    [DataContract]
    public partial class CartItemOptionValue :  IEquatable<CartItemOptionValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItemOptionValue" /> class.
        /// </summary>
        /// <param name="additionalCost">additionalCost.</param>
        /// <param name="additionalWeight">additionalWeight.</param>
        /// <param name="defaultValue">True if this is the default value.</param>
        /// <param name="displayOrder">Display order of the option value.</param>
        /// <param name="value">Value of the option the customer can select.</param>
        public CartItemOptionValue(Currency additionalCost = default(Currency), Weight additionalWeight = default(Weight), bool defaultValue = default(bool), int displayOrder = default(int), string value = default(string))
        {
            this.AdditionalCost = additionalCost;
            this.AdditionalWeight = additionalWeight;
            this.DefaultValue = defaultValue;
            this.DisplayOrder = displayOrder;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets AdditionalCost
        /// </summary>
        [DataMember(Name="additional_cost", EmitDefaultValue=false)]
        public Currency AdditionalCost { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalWeight
        /// </summary>
        [DataMember(Name="additional_weight", EmitDefaultValue=false)]
        public Weight AdditionalWeight { get; set; }

        /// <summary>
        /// True if this is the default value
        /// </summary>
        /// <value>True if this is the default value</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public bool DefaultValue { get; set; }

        /// <summary>
        /// Display order of the option value
        /// </summary>
        /// <value>Display order of the option value</value>
        [DataMember(Name="display_order", EmitDefaultValue=false)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Value of the option the customer can select
        /// </summary>
        /// <value>Value of the option the customer can select</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemOptionValue {\n");
            sb.Append("  AdditionalCost: ").Append(AdditionalCost).Append("\n");
            sb.Append("  AdditionalWeight: ").Append(AdditionalWeight).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CartItemOptionValue);
        }

        /// <summary>
        /// Returns true if CartItemOptionValue instances are equal
        /// </summary>
        /// <param name="input">Instance of CartItemOptionValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItemOptionValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalCost == input.AdditionalCost ||
                    (this.AdditionalCost != null &&
                    this.AdditionalCost.Equals(input.AdditionalCost))
                ) && 
                (
                    this.AdditionalWeight == input.AdditionalWeight ||
                    (this.AdditionalWeight != null &&
                    this.AdditionalWeight.Equals(input.AdditionalWeight))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.AdditionalCost != null)
                    hashCode = hashCode * 59 + this.AdditionalCost.GetHashCode();
                if (this.AdditionalWeight != null)
                    hashCode = hashCode * 59 + this.AdditionalWeight.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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

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
    /// CartItemOption
    /// </summary>
    [DataContract]
    public partial class CartItemOption :  IEquatable<CartItemOption>, IValidatableObject
    {
        /// <summary>
        /// Type of option
        /// </summary>
        /// <value>Type of option</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 1,

            /// <summary>
            /// Enum Multiline for value: multiline
            /// </summary>
            [EnumMember(Value = "multiline")]
            Multiline = 2,

            /// <summary>
            /// Enum Dropdown for value: dropdown
            /// </summary>
            [EnumMember(Value = "dropdown")]
            Dropdown = 3,

            /// <summary>
            /// Enum Hidden for value: hidden
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden = 4,

            /// <summary>
            /// Enum Radio for value: radio
            /// </summary>
            [EnumMember(Value = "radio")]
            Radio = 5,

            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 6

        }

        /// <summary>
        /// Type of option
        /// </summary>
        /// <value>Type of option</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItemOption" /> class.
        /// </summary>
        /// <param name="costIfSpecified">costIfSpecified.</param>
        /// <param name="costPerLetter">costPerLetter.</param>
        /// <param name="costPerLine">costPerLine.</param>
        /// <param name="ignoreIfDefault">True if the default answer is ignored.</param>
        /// <param name="label">Display label for the option.</param>
        /// <param name="name">Name of the option.</param>
        /// <param name="oneTimeFee">Charge the fee a single time instead of multiplying by the quantity.</param>
        /// <param name="optionOid">Unique identifier for the option.</param>
        /// <param name="required">True if the customer is required to select a value.</param>
        /// <param name="selectedValue">The value of the option specified by the customer.</param>
        /// <param name="type">Type of option.</param>
        /// <param name="values">Values that the customer can select from for radio or select type options.</param>
        public CartItemOption(Currency costIfSpecified = default(Currency), Currency costPerLetter = default(Currency), Currency costPerLine = default(Currency), bool ignoreIfDefault = default(bool), string label = default(string), string name = default(string), bool oneTimeFee = default(bool), int optionOid = default(int), bool required = default(bool), string selectedValue = default(string), TypeEnum? type = default(TypeEnum?), List<CartItemOptionValue> values = default(List<CartItemOptionValue>))
        {
            this.CostIfSpecified = costIfSpecified;
            this.CostPerLetter = costPerLetter;
            this.CostPerLine = costPerLine;
            this.IgnoreIfDefault = ignoreIfDefault;
            this.Label = label;
            this.Name = name;
            this.OneTimeFee = oneTimeFee;
            this.OptionOid = optionOid;
            this.Required = required;
            this.SelectedValue = selectedValue;
            this.Type = type;
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets CostIfSpecified
        /// </summary>
        [DataMember(Name="cost_if_specified", EmitDefaultValue=false)]
        public Currency CostIfSpecified { get; set; }

        /// <summary>
        /// Gets or Sets CostPerLetter
        /// </summary>
        [DataMember(Name="cost_per_letter", EmitDefaultValue=false)]
        public Currency CostPerLetter { get; set; }

        /// <summary>
        /// Gets or Sets CostPerLine
        /// </summary>
        [DataMember(Name="cost_per_line", EmitDefaultValue=false)]
        public Currency CostPerLine { get; set; }

        /// <summary>
        /// True if the default answer is ignored
        /// </summary>
        /// <value>True if the default answer is ignored</value>
        [DataMember(Name="ignore_if_default", EmitDefaultValue=false)]
        public bool IgnoreIfDefault { get; set; }

        /// <summary>
        /// Display label for the option
        /// </summary>
        /// <value>Display label for the option</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Name of the option
        /// </summary>
        /// <value>Name of the option</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Charge the fee a single time instead of multiplying by the quantity
        /// </summary>
        /// <value>Charge the fee a single time instead of multiplying by the quantity</value>
        [DataMember(Name="one_time_fee", EmitDefaultValue=false)]
        public bool OneTimeFee { get; set; }

        /// <summary>
        /// Unique identifier for the option
        /// </summary>
        /// <value>Unique identifier for the option</value>
        [DataMember(Name="option_oid", EmitDefaultValue=false)]
        public int OptionOid { get; set; }

        /// <summary>
        /// True if the customer is required to select a value
        /// </summary>
        /// <value>True if the customer is required to select a value</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool Required { get; set; }

        /// <summary>
        /// The value of the option specified by the customer
        /// </summary>
        /// <value>The value of the option specified by the customer</value>
        [DataMember(Name="selected_value", EmitDefaultValue=false)]
        public string SelectedValue { get; set; }


        /// <summary>
        /// Values that the customer can select from for radio or select type options
        /// </summary>
        /// <value>Values that the customer can select from for radio or select type options</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<CartItemOptionValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemOption {\n");
            sb.Append("  CostIfSpecified: ").Append(CostIfSpecified).Append("\n");
            sb.Append("  CostPerLetter: ").Append(CostPerLetter).Append("\n");
            sb.Append("  CostPerLine: ").Append(CostPerLine).Append("\n");
            sb.Append("  IgnoreIfDefault: ").Append(IgnoreIfDefault).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OneTimeFee: ").Append(OneTimeFee).Append("\n");
            sb.Append("  OptionOid: ").Append(OptionOid).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  SelectedValue: ").Append(SelectedValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as CartItemOption);
        }

        /// <summary>
        /// Returns true if CartItemOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CartItemOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItemOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CostIfSpecified == input.CostIfSpecified ||
                    (this.CostIfSpecified != null &&
                    this.CostIfSpecified.Equals(input.CostIfSpecified))
                ) && 
                (
                    this.CostPerLetter == input.CostPerLetter ||
                    (this.CostPerLetter != null &&
                    this.CostPerLetter.Equals(input.CostPerLetter))
                ) && 
                (
                    this.CostPerLine == input.CostPerLine ||
                    (this.CostPerLine != null &&
                    this.CostPerLine.Equals(input.CostPerLine))
                ) && 
                (
                    this.IgnoreIfDefault == input.IgnoreIfDefault ||
                    (this.IgnoreIfDefault != null &&
                    this.IgnoreIfDefault.Equals(input.IgnoreIfDefault))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OneTimeFee == input.OneTimeFee ||
                    (this.OneTimeFee != null &&
                    this.OneTimeFee.Equals(input.OneTimeFee))
                ) && 
                (
                    this.OptionOid == input.OptionOid ||
                    (this.OptionOid != null &&
                    this.OptionOid.Equals(input.OptionOid))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.SelectedValue == input.SelectedValue ||
                    (this.SelectedValue != null &&
                    this.SelectedValue.Equals(input.SelectedValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.CostIfSpecified != null)
                    hashCode = hashCode * 59 + this.CostIfSpecified.GetHashCode();
                if (this.CostPerLetter != null)
                    hashCode = hashCode * 59 + this.CostPerLetter.GetHashCode();
                if (this.CostPerLine != null)
                    hashCode = hashCode * 59 + this.CostPerLine.GetHashCode();
                if (this.IgnoreIfDefault != null)
                    hashCode = hashCode * 59 + this.IgnoreIfDefault.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OneTimeFee != null)
                    hashCode = hashCode * 59 + this.OneTimeFee.GetHashCode();
                if (this.OptionOid != null)
                    hashCode = hashCode * 59 + this.OptionOid.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.SelectedValue != null)
                    hashCode = hashCode * 59 + this.SelectedValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
            // SelectedValue (string) maxLength
            if(this.SelectedValue != null && this.SelectedValue.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SelectedValue, length must be less than 1024.", new [] { "SelectedValue" });
            }


            yield break;
        }
    }

}

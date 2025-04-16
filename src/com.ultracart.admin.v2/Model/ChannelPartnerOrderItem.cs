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
    /// ChannelPartnerOrderItem
    /// </summary>
    [DataContract]
    public partial class ChannelPartnerOrderItem :  IEquatable<ChannelPartnerOrderItem>, IValidatableObject
    {
        /// <summary>
        /// The frequency schedule for this item if this item is part of an auto (recurring) order
        /// </summary>
        /// <value>The frequency schedule for this item if this item is part of an auto (recurring) order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutoOrderScheduleEnum
        {
            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 1,

            /// <summary>
            /// Enum Every10Days for value: Every 10 Days
            /// </summary>
            [EnumMember(Value = "Every 10 Days")]
            Every10Days = 2,

            /// <summary>
            /// Enum Biweekly for value: Biweekly
            /// </summary>
            [EnumMember(Value = "Biweekly")]
            Biweekly = 3,

            /// <summary>
            /// Enum Every24Days for value: Every 24 Days
            /// </summary>
            [EnumMember(Value = "Every 24 Days")]
            Every24Days = 4,

            /// <summary>
            /// Enum Every28Days for value: Every 28 Days
            /// </summary>
            [EnumMember(Value = "Every 28 Days")]
            Every28Days = 5,

            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 6,

            /// <summary>
            /// Enum Every45Days for value: Every 45 Days
            /// </summary>
            [EnumMember(Value = "Every 45 Days")]
            Every45Days = 7,

            /// <summary>
            /// Enum Every2Months for value: Every 2 Months
            /// </summary>
            [EnumMember(Value = "Every 2 Months")]
            Every2Months = 8,

            /// <summary>
            /// Enum Every3Months for value: Every 3 Months
            /// </summary>
            [EnumMember(Value = "Every 3 Months")]
            Every3Months = 9,

            /// <summary>
            /// Enum Every4Months for value: Every 4 Months
            /// </summary>
            [EnumMember(Value = "Every 4 Months")]
            Every4Months = 10,

            /// <summary>
            /// Enum Every5Months for value: Every 5 Months
            /// </summary>
            [EnumMember(Value = "Every 5 Months")]
            Every5Months = 11,

            /// <summary>
            /// Enum Every6Months for value: Every 6 Months
            /// </summary>
            [EnumMember(Value = "Every 6 Months")]
            Every6Months = 12,

            /// <summary>
            /// Enum Yearly for value: Yearly
            /// </summary>
            [EnumMember(Value = "Yearly")]
            Yearly = 13,

            /// <summary>
            /// Enum Every4Weeks for value: Every 4 Weeks
            /// </summary>
            [EnumMember(Value = "Every 4 Weeks")]
            Every4Weeks = 14,

            /// <summary>
            /// Enum Every6Weeks for value: Every 6 Weeks
            /// </summary>
            [EnumMember(Value = "Every 6 Weeks")]
            Every6Weeks = 15,

            /// <summary>
            /// Enum Every8Weeks for value: Every 8 Weeks
            /// </summary>
            [EnumMember(Value = "Every 8 Weeks")]
            Every8Weeks = 16

        }

        /// <summary>
        /// The frequency schedule for this item if this item is part of an auto (recurring) order
        /// </summary>
        /// <value>The frequency schedule for this item if this item is part of an auto (recurring) order</value>
        [DataMember(Name="auto_order_schedule", EmitDefaultValue=false)]
        public AutoOrderScheduleEnum? AutoOrderSchedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPartnerOrderItem" /> class.
        /// </summary>
        /// <param name="arbitraryUnitCost">Arbitrary unit cost for this item that differs from the listed price.</param>
        /// <param name="autoOrderLastRebillDts">Optional date/time of the last rebill if this item is part of an auto (recurring) order.</param>
        /// <param name="autoOrderSchedule">The frequency schedule for this item if this item is part of an auto (recurring) order.</param>
        /// <param name="merchantItemId">Item ID.</param>
        /// <param name="options">Item options.</param>
        /// <param name="properties">Properties.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="upsell">True if this item was an upsell item..</param>
        public ChannelPartnerOrderItem(decimal arbitraryUnitCost = default(decimal), string autoOrderLastRebillDts = default(string), AutoOrderScheduleEnum? autoOrderSchedule = default(AutoOrderScheduleEnum?), string merchantItemId = default(string), List<ChannelPartnerOrderItemOption> options = default(List<ChannelPartnerOrderItemOption>), List<ChannelPartnerOrderItemProperty> properties = default(List<ChannelPartnerOrderItemProperty>), decimal quantity = default(decimal), bool upsell = default(bool))
        {
            this.ArbitraryUnitCost = arbitraryUnitCost;
            this.AutoOrderLastRebillDts = autoOrderLastRebillDts;
            this.AutoOrderSchedule = autoOrderSchedule;
            this.MerchantItemId = merchantItemId;
            this.Options = options;
            this.Properties = properties;
            this.Quantity = quantity;
            this.Upsell = upsell;
        }

        /// <summary>
        /// Arbitrary unit cost for this item that differs from the listed price
        /// </summary>
        /// <value>Arbitrary unit cost for this item that differs from the listed price</value>
        [DataMember(Name="arbitrary_unit_cost", EmitDefaultValue=false)]
        public decimal ArbitraryUnitCost { get; set; }

        /// <summary>
        /// Optional date/time of the last rebill if this item is part of an auto (recurring) order
        /// </summary>
        /// <value>Optional date/time of the last rebill if this item is part of an auto (recurring) order</value>
        [DataMember(Name="auto_order_last_rebill_dts", EmitDefaultValue=false)]
        public string AutoOrderLastRebillDts { get; set; }


        /// <summary>
        /// Item ID
        /// </summary>
        /// <value>Item ID</value>
        [DataMember(Name="merchant_item_id", EmitDefaultValue=false)]
        public string MerchantItemId { get; set; }

        /// <summary>
        /// Item options
        /// </summary>
        /// <value>Item options</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<ChannelPartnerOrderItemOption> Options { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        /// <value>Properties</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<ChannelPartnerOrderItemProperty> Properties { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// True if this item was an upsell item.
        /// </summary>
        /// <value>True if this item was an upsell item.</value>
        [DataMember(Name="upsell", EmitDefaultValue=false)]
        public bool Upsell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelPartnerOrderItem {\n");
            sb.Append("  ArbitraryUnitCost: ").Append(ArbitraryUnitCost).Append("\n");
            sb.Append("  AutoOrderLastRebillDts: ").Append(AutoOrderLastRebillDts).Append("\n");
            sb.Append("  AutoOrderSchedule: ").Append(AutoOrderSchedule).Append("\n");
            sb.Append("  MerchantItemId: ").Append(MerchantItemId).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Upsell: ").Append(Upsell).Append("\n");
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
            return this.Equals(input as ChannelPartnerOrderItem);
        }

        /// <summary>
        /// Returns true if ChannelPartnerOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelPartnerOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelPartnerOrderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArbitraryUnitCost == input.ArbitraryUnitCost ||
                    (this.ArbitraryUnitCost != null &&
                    this.ArbitraryUnitCost.Equals(input.ArbitraryUnitCost))
                ) && 
                (
                    this.AutoOrderLastRebillDts == input.AutoOrderLastRebillDts ||
                    (this.AutoOrderLastRebillDts != null &&
                    this.AutoOrderLastRebillDts.Equals(input.AutoOrderLastRebillDts))
                ) && 
                (
                    this.AutoOrderSchedule == input.AutoOrderSchedule ||
                    (this.AutoOrderSchedule != null &&
                    this.AutoOrderSchedule.Equals(input.AutoOrderSchedule))
                ) && 
                (
                    this.MerchantItemId == input.MerchantItemId ||
                    (this.MerchantItemId != null &&
                    this.MerchantItemId.Equals(input.MerchantItemId))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Upsell == input.Upsell ||
                    (this.Upsell != null &&
                    this.Upsell.Equals(input.Upsell))
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
                if (this.ArbitraryUnitCost != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCost.GetHashCode();
                if (this.AutoOrderLastRebillDts != null)
                    hashCode = hashCode * 59 + this.AutoOrderLastRebillDts.GetHashCode();
                if (this.AutoOrderSchedule != null)
                    hashCode = hashCode * 59 + this.AutoOrderSchedule.GetHashCode();
                if (this.MerchantItemId != null)
                    hashCode = hashCode * 59 + this.MerchantItemId.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Upsell != null)
                    hashCode = hashCode * 59 + this.Upsell.GetHashCode();
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
            // MerchantItemId (string) maxLength
            if(this.MerchantItemId != null && this.MerchantItemId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantItemId, length must be less than 20.", new [] { "MerchantItemId" });
            }


            yield break;
        }
    }

}

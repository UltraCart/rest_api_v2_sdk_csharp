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
    /// CartSettingsShippingEstimate
    /// </summary>
    [DataContract]
    public partial class CartSettingsShippingEstimate :  IEquatable<CartSettingsShippingEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsShippingEstimate" /> class.
        /// </summary>
        /// <param name="Allow3rdPartyBilling">True if this method allows the customer to use their own shipper account number.</param>
        /// <param name="Comment">Comment to display to the customer about this method.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="CostBeforeDiscount">CostBeforeDiscount.</param>
        /// <param name="DefaultMethod">True if this is the default method.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="Discounted">True if this method is discounted because of a coupon.</param>
        /// <param name="DisplayName">The name to display to the customer.</param>
        /// <param name="EstimatedDelivery">Date of the estimated delivery (or range).</param>
        /// <param name="LiftGateOption">True if a lift gate option for this method should be offered to the customer.</param>
        /// <param name="Name">Shipping method name.</param>
        /// <param name="Tax">Tax.</param>
        /// <param name="TotalTax">TotalTax.</param>
        public CartSettingsShippingEstimate(bool? Allow3rdPartyBilling = default(bool?), string Comment = default(string), Currency Cost = default(Currency), Currency CostBeforeDiscount = default(Currency), bool? DefaultMethod = default(bool?), Currency Discount = default(Currency), bool? Discounted = default(bool?), string DisplayName = default(string), string EstimatedDelivery = default(string), bool? LiftGateOption = default(bool?), string Name = default(string), Currency Tax = default(Currency), Currency TotalTax = default(Currency))
        {
            this.Allow3rdPartyBilling = Allow3rdPartyBilling;
            this.Comment = Comment;
            this.Cost = Cost;
            this.CostBeforeDiscount = CostBeforeDiscount;
            this.DefaultMethod = DefaultMethod;
            this.Discount = Discount;
            this.Discounted = Discounted;
            this.DisplayName = DisplayName;
            this.EstimatedDelivery = EstimatedDelivery;
            this.LiftGateOption = LiftGateOption;
            this.Name = Name;
            this.Tax = Tax;
            this.TotalTax = TotalTax;
        }
        
        /// <summary>
        /// True if this method allows the customer to use their own shipper account number
        /// </summary>
        /// <value>True if this method allows the customer to use their own shipper account number</value>
        [DataMember(Name="allow_3rd_party_billing", EmitDefaultValue=false)]
        public bool? Allow3rdPartyBilling { get; set; }

        /// <summary>
        /// Comment to display to the customer about this method
        /// </summary>
        /// <value>Comment to display to the customer about this method</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public Currency Cost { get; set; }

        /// <summary>
        /// Gets or Sets CostBeforeDiscount
        /// </summary>
        [DataMember(Name="cost_before_discount", EmitDefaultValue=false)]
        public Currency CostBeforeDiscount { get; set; }

        /// <summary>
        /// True if this is the default method
        /// </summary>
        /// <value>True if this is the default method</value>
        [DataMember(Name="default_method", EmitDefaultValue=false)]
        public bool? DefaultMethod { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public Currency Discount { get; set; }

        /// <summary>
        /// True if this method is discounted because of a coupon
        /// </summary>
        /// <value>True if this method is discounted because of a coupon</value>
        [DataMember(Name="discounted", EmitDefaultValue=false)]
        public bool? Discounted { get; set; }

        /// <summary>
        /// The name to display to the customer
        /// </summary>
        /// <value>The name to display to the customer</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Date of the estimated delivery (or range)
        /// </summary>
        /// <value>Date of the estimated delivery (or range)</value>
        [DataMember(Name="estimated_delivery", EmitDefaultValue=false)]
        public string EstimatedDelivery { get; set; }

        /// <summary>
        /// True if a lift gate option for this method should be offered to the customer
        /// </summary>
        /// <value>True if a lift gate option for this method should be offered to the customer</value>
        [DataMember(Name="lift_gate_option", EmitDefaultValue=false)]
        public bool? LiftGateOption { get; set; }

        /// <summary>
        /// Shipping method name
        /// </summary>
        /// <value>Shipping method name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public Currency Tax { get; set; }

        /// <summary>
        /// Gets or Sets TotalTax
        /// </summary>
        [DataMember(Name="total_tax", EmitDefaultValue=false)]
        public Currency TotalTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsShippingEstimate {\n");
            sb.Append("  Allow3rdPartyBilling: ").Append(Allow3rdPartyBilling).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostBeforeDiscount: ").Append(CostBeforeDiscount).Append("\n");
            sb.Append("  DefaultMethod: ").Append(DefaultMethod).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Discounted: ").Append(Discounted).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EstimatedDelivery: ").Append(EstimatedDelivery).Append("\n");
            sb.Append("  LiftGateOption: ").Append(LiftGateOption).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
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
            return this.Equals(input as CartSettingsShippingEstimate);
        }

        /// <summary>
        /// Returns true if CartSettingsShippingEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsShippingEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsShippingEstimate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allow3rdPartyBilling == input.Allow3rdPartyBilling ||
                    (this.Allow3rdPartyBilling != null &&
                    this.Allow3rdPartyBilling.Equals(input.Allow3rdPartyBilling))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostBeforeDiscount == input.CostBeforeDiscount ||
                    (this.CostBeforeDiscount != null &&
                    this.CostBeforeDiscount.Equals(input.CostBeforeDiscount))
                ) && 
                (
                    this.DefaultMethod == input.DefaultMethod ||
                    (this.DefaultMethod != null &&
                    this.DefaultMethod.Equals(input.DefaultMethod))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.Discounted == input.Discounted ||
                    (this.Discounted != null &&
                    this.Discounted.Equals(input.Discounted))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.EstimatedDelivery == input.EstimatedDelivery ||
                    (this.EstimatedDelivery != null &&
                    this.EstimatedDelivery.Equals(input.EstimatedDelivery))
                ) && 
                (
                    this.LiftGateOption == input.LiftGateOption ||
                    (this.LiftGateOption != null &&
                    this.LiftGateOption.Equals(input.LiftGateOption))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
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
                if (this.Allow3rdPartyBilling != null)
                    hashCode = hashCode * 59 + this.Allow3rdPartyBilling.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostBeforeDiscount != null)
                    hashCode = hashCode * 59 + this.CostBeforeDiscount.GetHashCode();
                if (this.DefaultMethod != null)
                    hashCode = hashCode * 59 + this.DefaultMethod.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Discounted != null)
                    hashCode = hashCode * 59 + this.Discounted.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EstimatedDelivery != null)
                    hashCode = hashCode * 59 + this.EstimatedDelivery.GetHashCode();
                if (this.LiftGateOption != null)
                    hashCode = hashCode * 59 + this.LiftGateOption.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TotalTax != null)
                    hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
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

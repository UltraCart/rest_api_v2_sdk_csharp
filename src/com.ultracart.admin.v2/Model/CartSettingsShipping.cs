/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// CartSettingsShipping
    /// </summary>
    [DataContract]
    public partial class CartSettingsShipping :  IEquatable<CartSettingsShipping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsShipping" /> class.
        /// </summary>
        /// <param name="DeliverOnDate">DeliverOnDate.</param>
        /// <param name="Estimates">Estimates for this cart.</param>
        /// <param name="NeedShipping">True if this order needs shipping.</param>
        /// <param name="Provinces">Provinces.</param>
        /// <param name="ShipOnDate">ShipOnDate.</param>
        public CartSettingsShipping(CartSettingsShippingCalendar DeliverOnDate = default(CartSettingsShippingCalendar), List<CartSettingsShippingEstimate> Estimates = default(List<CartSettingsShippingEstimate>), bool? NeedShipping = default(bool?), List<CartSettingsProvince> Provinces = default(List<CartSettingsProvince>), CartSettingsShippingCalendar ShipOnDate = default(CartSettingsShippingCalendar))
        {
            this.DeliverOnDate = DeliverOnDate;
            this.Estimates = Estimates;
            this.NeedShipping = NeedShipping;
            this.Provinces = Provinces;
            this.ShipOnDate = ShipOnDate;
        }
        
        /// <summary>
        /// Gets or Sets DeliverOnDate
        /// </summary>
        [DataMember(Name="deliver_on_date", EmitDefaultValue=false)]
        public CartSettingsShippingCalendar DeliverOnDate { get; set; }

        /// <summary>
        /// Estimates for this cart
        /// </summary>
        /// <value>Estimates for this cart</value>
        [DataMember(Name="estimates", EmitDefaultValue=false)]
        public List<CartSettingsShippingEstimate> Estimates { get; set; }

        /// <summary>
        /// True if this order needs shipping
        /// </summary>
        /// <value>True if this order needs shipping</value>
        [DataMember(Name="need_shipping", EmitDefaultValue=false)]
        public bool? NeedShipping { get; set; }

        /// <summary>
        /// Provinces
        /// </summary>
        /// <value>Provinces</value>
        [DataMember(Name="provinces", EmitDefaultValue=false)]
        public List<CartSettingsProvince> Provinces { get; set; }

        /// <summary>
        /// Gets or Sets ShipOnDate
        /// </summary>
        [DataMember(Name="ship_on_date", EmitDefaultValue=false)]
        public CartSettingsShippingCalendar ShipOnDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsShipping {\n");
            sb.Append("  DeliverOnDate: ").Append(DeliverOnDate).Append("\n");
            sb.Append("  Estimates: ").Append(Estimates).Append("\n");
            sb.Append("  NeedShipping: ").Append(NeedShipping).Append("\n");
            sb.Append("  Provinces: ").Append(Provinces).Append("\n");
            sb.Append("  ShipOnDate: ").Append(ShipOnDate).Append("\n");
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
            return this.Equals(input as CartSettingsShipping);
        }

        /// <summary>
        /// Returns true if CartSettingsShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsShipping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliverOnDate == input.DeliverOnDate ||
                    (this.DeliverOnDate != null &&
                    this.DeliverOnDate.Equals(input.DeliverOnDate))
                ) && 
                (
                    this.Estimates == input.Estimates ||
                    this.Estimates != null &&
                    this.Estimates.SequenceEqual(input.Estimates)
                ) && 
                (
                    this.NeedShipping == input.NeedShipping ||
                    (this.NeedShipping != null &&
                    this.NeedShipping.Equals(input.NeedShipping))
                ) && 
                (
                    this.Provinces == input.Provinces ||
                    this.Provinces != null &&
                    this.Provinces.SequenceEqual(input.Provinces)
                ) && 
                (
                    this.ShipOnDate == input.ShipOnDate ||
                    (this.ShipOnDate != null &&
                    this.ShipOnDate.Equals(input.ShipOnDate))
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
                if (this.DeliverOnDate != null)
                    hashCode = hashCode * 59 + this.DeliverOnDate.GetHashCode();
                if (this.Estimates != null)
                    hashCode = hashCode * 59 + this.Estimates.GetHashCode();
                if (this.NeedShipping != null)
                    hashCode = hashCode * 59 + this.NeedShipping.GetHashCode();
                if (this.Provinces != null)
                    hashCode = hashCode * 59 + this.Provinces.GetHashCode();
                if (this.ShipOnDate != null)
                    hashCode = hashCode * 59 + this.ShipOnDate.GetHashCode();
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

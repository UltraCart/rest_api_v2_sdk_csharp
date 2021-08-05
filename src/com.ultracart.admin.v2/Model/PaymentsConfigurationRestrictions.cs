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
    /// PaymentsConfigurationRestrictions
    /// </summary>
    [DataContract]
    public partial class PaymentsConfigurationRestrictions :  IEquatable<PaymentsConfigurationRestrictions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfigurationRestrictions" /> class.
        /// </summary>
        /// <param name="maximumSubtotal">Maximum subtotal.</param>
        /// <param name="minimumSubtotal">Minimum subtotal.</param>
        /// <param name="paymentMethod">Payment method.</param>
        /// <param name="restrictionAlaskaHawaii">Alaska and Hawaii restriction.</param>
        /// <param name="restrictionApoFpo">APO/FPO restriction.</param>
        /// <param name="restrictionCanada">Canada restriction.</param>
        /// <param name="restrictionContinentalUs">Continental US restriction.</param>
        /// <param name="restrictionDomesticOnly">Domestic only restriction.</param>
        /// <param name="restrictionInternationalOnly">International only restriction.</param>
        /// <param name="restrictionPoBox">PO Box restriction.</param>
        /// <param name="restrictionPuertoRico">Puerto Rico restriction.</param>
        /// <param name="restrictionUsTerritories">US Territories restriction.</param>
        public PaymentsConfigurationRestrictions(string maximumSubtotal = default(string), string minimumSubtotal = default(string), string paymentMethod = default(string), string restrictionAlaskaHawaii = default(string), string restrictionApoFpo = default(string), string restrictionCanada = default(string), string restrictionContinentalUs = default(string), string restrictionDomesticOnly = default(string), string restrictionInternationalOnly = default(string), string restrictionPoBox = default(string), string restrictionPuertoRico = default(string), string restrictionUsTerritories = default(string))
        {
            this.MaximumSubtotal = maximumSubtotal;
            this.MinimumSubtotal = minimumSubtotal;
            this.PaymentMethod = paymentMethod;
            this.RestrictionAlaskaHawaii = restrictionAlaskaHawaii;
            this.RestrictionApoFpo = restrictionApoFpo;
            this.RestrictionCanada = restrictionCanada;
            this.RestrictionContinentalUs = restrictionContinentalUs;
            this.RestrictionDomesticOnly = restrictionDomesticOnly;
            this.RestrictionInternationalOnly = restrictionInternationalOnly;
            this.RestrictionPoBox = restrictionPoBox;
            this.RestrictionPuertoRico = restrictionPuertoRico;
            this.RestrictionUsTerritories = restrictionUsTerritories;
        }
        
        /// <summary>
        /// Maximum subtotal
        /// </summary>
        /// <value>Maximum subtotal</value>
        [DataMember(Name="maximum_subtotal", EmitDefaultValue=false)]
        public string MaximumSubtotal { get; set; }

        /// <summary>
        /// Minimum subtotal
        /// </summary>
        /// <value>Minimum subtotal</value>
        [DataMember(Name="minimum_subtotal", EmitDefaultValue=false)]
        public string MinimumSubtotal { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        /// <value>Payment method</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Alaska and Hawaii restriction
        /// </summary>
        /// <value>Alaska and Hawaii restriction</value>
        [DataMember(Name="restriction_alaska_hawaii", EmitDefaultValue=false)]
        public string RestrictionAlaskaHawaii { get; set; }

        /// <summary>
        /// APO/FPO restriction
        /// </summary>
        /// <value>APO/FPO restriction</value>
        [DataMember(Name="restriction_apo_fpo", EmitDefaultValue=false)]
        public string RestrictionApoFpo { get; set; }

        /// <summary>
        /// Canada restriction
        /// </summary>
        /// <value>Canada restriction</value>
        [DataMember(Name="restriction_canada", EmitDefaultValue=false)]
        public string RestrictionCanada { get; set; }

        /// <summary>
        /// Continental US restriction
        /// </summary>
        /// <value>Continental US restriction</value>
        [DataMember(Name="restriction_continental_us", EmitDefaultValue=false)]
        public string RestrictionContinentalUs { get; set; }

        /// <summary>
        /// Domestic only restriction
        /// </summary>
        /// <value>Domestic only restriction</value>
        [DataMember(Name="restriction_domestic_only", EmitDefaultValue=false)]
        public string RestrictionDomesticOnly { get; set; }

        /// <summary>
        /// International only restriction
        /// </summary>
        /// <value>International only restriction</value>
        [DataMember(Name="restriction_international_only", EmitDefaultValue=false)]
        public string RestrictionInternationalOnly { get; set; }

        /// <summary>
        /// PO Box restriction
        /// </summary>
        /// <value>PO Box restriction</value>
        [DataMember(Name="restriction_po_box", EmitDefaultValue=false)]
        public string RestrictionPoBox { get; set; }

        /// <summary>
        /// Puerto Rico restriction
        /// </summary>
        /// <value>Puerto Rico restriction</value>
        [DataMember(Name="restriction_puerto_rico", EmitDefaultValue=false)]
        public string RestrictionPuertoRico { get; set; }

        /// <summary>
        /// US Territories restriction
        /// </summary>
        /// <value>US Territories restriction</value>
        [DataMember(Name="restriction_us_territories", EmitDefaultValue=false)]
        public string RestrictionUsTerritories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfigurationRestrictions {\n");
            sb.Append("  MaximumSubtotal: ").Append(MaximumSubtotal).Append("\n");
            sb.Append("  MinimumSubtotal: ").Append(MinimumSubtotal).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  RestrictionAlaskaHawaii: ").Append(RestrictionAlaskaHawaii).Append("\n");
            sb.Append("  RestrictionApoFpo: ").Append(RestrictionApoFpo).Append("\n");
            sb.Append("  RestrictionCanada: ").Append(RestrictionCanada).Append("\n");
            sb.Append("  RestrictionContinentalUs: ").Append(RestrictionContinentalUs).Append("\n");
            sb.Append("  RestrictionDomesticOnly: ").Append(RestrictionDomesticOnly).Append("\n");
            sb.Append("  RestrictionInternationalOnly: ").Append(RestrictionInternationalOnly).Append("\n");
            sb.Append("  RestrictionPoBox: ").Append(RestrictionPoBox).Append("\n");
            sb.Append("  RestrictionPuertoRico: ").Append(RestrictionPuertoRico).Append("\n");
            sb.Append("  RestrictionUsTerritories: ").Append(RestrictionUsTerritories).Append("\n");
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
            return this.Equals(input as PaymentsConfigurationRestrictions);
        }

        /// <summary>
        /// Returns true if PaymentsConfigurationRestrictions instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsConfigurationRestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsConfigurationRestrictions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaximumSubtotal == input.MaximumSubtotal ||
                    (this.MaximumSubtotal != null &&
                    this.MaximumSubtotal.Equals(input.MaximumSubtotal))
                ) && 
                (
                    this.MinimumSubtotal == input.MinimumSubtotal ||
                    (this.MinimumSubtotal != null &&
                    this.MinimumSubtotal.Equals(input.MinimumSubtotal))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.RestrictionAlaskaHawaii == input.RestrictionAlaskaHawaii ||
                    (this.RestrictionAlaskaHawaii != null &&
                    this.RestrictionAlaskaHawaii.Equals(input.RestrictionAlaskaHawaii))
                ) && 
                (
                    this.RestrictionApoFpo == input.RestrictionApoFpo ||
                    (this.RestrictionApoFpo != null &&
                    this.RestrictionApoFpo.Equals(input.RestrictionApoFpo))
                ) && 
                (
                    this.RestrictionCanada == input.RestrictionCanada ||
                    (this.RestrictionCanada != null &&
                    this.RestrictionCanada.Equals(input.RestrictionCanada))
                ) && 
                (
                    this.RestrictionContinentalUs == input.RestrictionContinentalUs ||
                    (this.RestrictionContinentalUs != null &&
                    this.RestrictionContinentalUs.Equals(input.RestrictionContinentalUs))
                ) && 
                (
                    this.RestrictionDomesticOnly == input.RestrictionDomesticOnly ||
                    (this.RestrictionDomesticOnly != null &&
                    this.RestrictionDomesticOnly.Equals(input.RestrictionDomesticOnly))
                ) && 
                (
                    this.RestrictionInternationalOnly == input.RestrictionInternationalOnly ||
                    (this.RestrictionInternationalOnly != null &&
                    this.RestrictionInternationalOnly.Equals(input.RestrictionInternationalOnly))
                ) && 
                (
                    this.RestrictionPoBox == input.RestrictionPoBox ||
                    (this.RestrictionPoBox != null &&
                    this.RestrictionPoBox.Equals(input.RestrictionPoBox))
                ) && 
                (
                    this.RestrictionPuertoRico == input.RestrictionPuertoRico ||
                    (this.RestrictionPuertoRico != null &&
                    this.RestrictionPuertoRico.Equals(input.RestrictionPuertoRico))
                ) && 
                (
                    this.RestrictionUsTerritories == input.RestrictionUsTerritories ||
                    (this.RestrictionUsTerritories != null &&
                    this.RestrictionUsTerritories.Equals(input.RestrictionUsTerritories))
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
                if (this.MaximumSubtotal != null)
                    hashCode = hashCode * 59 + this.MaximumSubtotal.GetHashCode();
                if (this.MinimumSubtotal != null)
                    hashCode = hashCode * 59 + this.MinimumSubtotal.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.RestrictionAlaskaHawaii != null)
                    hashCode = hashCode * 59 + this.RestrictionAlaskaHawaii.GetHashCode();
                if (this.RestrictionApoFpo != null)
                    hashCode = hashCode * 59 + this.RestrictionApoFpo.GetHashCode();
                if (this.RestrictionCanada != null)
                    hashCode = hashCode * 59 + this.RestrictionCanada.GetHashCode();
                if (this.RestrictionContinentalUs != null)
                    hashCode = hashCode * 59 + this.RestrictionContinentalUs.GetHashCode();
                if (this.RestrictionDomesticOnly != null)
                    hashCode = hashCode * 59 + this.RestrictionDomesticOnly.GetHashCode();
                if (this.RestrictionInternationalOnly != null)
                    hashCode = hashCode * 59 + this.RestrictionInternationalOnly.GetHashCode();
                if (this.RestrictionPoBox != null)
                    hashCode = hashCode * 59 + this.RestrictionPoBox.GetHashCode();
                if (this.RestrictionPuertoRico != null)
                    hashCode = hashCode * 59 + this.RestrictionPuertoRico.GetHashCode();
                if (this.RestrictionUsTerritories != null)
                    hashCode = hashCode * 59 + this.RestrictionUsTerritories.GetHashCode();
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

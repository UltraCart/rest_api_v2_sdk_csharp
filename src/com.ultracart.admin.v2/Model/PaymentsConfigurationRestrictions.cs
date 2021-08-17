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
        /// Alaska and Hawaii restriction
        /// </summary>
        /// <value>Alaska and Hawaii restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionAlaskaHawaiiEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// Alaska and Hawaii restriction
        /// </summary>
        /// <value>Alaska and Hawaii restriction</value>
        [DataMember(Name="restriction_alaska_hawaii", EmitDefaultValue=false)]
        public RestrictionAlaskaHawaiiEnum? RestrictionAlaskaHawaii { get; set; }
        /// <summary>
        /// APO/FPO restriction
        /// </summary>
        /// <value>APO/FPO restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionApoFpoEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// APO/FPO restriction
        /// </summary>
        /// <value>APO/FPO restriction</value>
        [DataMember(Name="restriction_apo_fpo", EmitDefaultValue=false)]
        public RestrictionApoFpoEnum? RestrictionApoFpo { get; set; }
        /// <summary>
        /// Canada restriction
        /// </summary>
        /// <value>Canada restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionCanadaEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// Canada restriction
        /// </summary>
        /// <value>Canada restriction</value>
        [DataMember(Name="restriction_canada", EmitDefaultValue=false)]
        public RestrictionCanadaEnum? RestrictionCanada { get; set; }
        /// <summary>
        /// Continental US restriction
        /// </summary>
        /// <value>Continental US restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionContinentalUsEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// Continental US restriction
        /// </summary>
        /// <value>Continental US restriction</value>
        [DataMember(Name="restriction_continental_us", EmitDefaultValue=false)]
        public RestrictionContinentalUsEnum? RestrictionContinentalUs { get; set; }
        /// <summary>
        /// Domestic only restriction
        /// </summary>
        /// <value>Domestic only restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionDomesticOnlyEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// Domestic only restriction
        /// </summary>
        /// <value>Domestic only restriction</value>
        [DataMember(Name="restriction_domestic_only", EmitDefaultValue=false)]
        public RestrictionDomesticOnlyEnum? RestrictionDomesticOnly { get; set; }
        /// <summary>
        /// International only restriction
        /// </summary>
        /// <value>International only restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionInternationalOnlyEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// International only restriction
        /// </summary>
        /// <value>International only restriction</value>
        [DataMember(Name="restriction_international_only", EmitDefaultValue=false)]
        public RestrictionInternationalOnlyEnum? RestrictionInternationalOnly { get; set; }
        /// <summary>
        /// PO Box restriction
        /// </summary>
        /// <value>PO Box restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionPoBoxEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// PO Box restriction
        /// </summary>
        /// <value>PO Box restriction</value>
        [DataMember(Name="restriction_po_box", EmitDefaultValue=false)]
        public RestrictionPoBoxEnum? RestrictionPoBox { get; set; }
        /// <summary>
        /// Puerto Rico restriction
        /// </summary>
        /// <value>Puerto Rico restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionPuertoRicoEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// Puerto Rico restriction
        /// </summary>
        /// <value>Puerto Rico restriction</value>
        [DataMember(Name="restriction_puerto_rico", EmitDefaultValue=false)]
        public RestrictionPuertoRicoEnum? RestrictionPuertoRico { get; set; }
        /// <summary>
        /// US Territories restriction
        /// </summary>
        /// <value>US Territories restriction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionUsTerritoriesEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum InvalidOnly for value: invalidOnly
            /// </summary>
            [EnumMember(Value = "invalidOnly")]
            InvalidOnly = 2,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 3
        }

        /// <summary>
        /// US Territories restriction
        /// </summary>
        /// <value>US Territories restriction</value>
        [DataMember(Name="restriction_us_territories", EmitDefaultValue=false)]
        public RestrictionUsTerritoriesEnum? RestrictionUsTerritories { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfigurationRestrictions" /> class.
        /// </summary>
        /// <param name="descriptions">descriptions.</param>
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
        /// <param name="themes">themes.</param>
        public PaymentsConfigurationRestrictions(List<string> descriptions = default(List<string>), decimal? maximumSubtotal = default(decimal?), decimal? minimumSubtotal = default(decimal?), string paymentMethod = default(string), RestrictionAlaskaHawaiiEnum? restrictionAlaskaHawaii = default(RestrictionAlaskaHawaiiEnum?), RestrictionApoFpoEnum? restrictionApoFpo = default(RestrictionApoFpoEnum?), RestrictionCanadaEnum? restrictionCanada = default(RestrictionCanadaEnum?), RestrictionContinentalUsEnum? restrictionContinentalUs = default(RestrictionContinentalUsEnum?), RestrictionDomesticOnlyEnum? restrictionDomesticOnly = default(RestrictionDomesticOnlyEnum?), RestrictionInternationalOnlyEnum? restrictionInternationalOnly = default(RestrictionInternationalOnlyEnum?), RestrictionPoBoxEnum? restrictionPoBox = default(RestrictionPoBoxEnum?), RestrictionPuertoRicoEnum? restrictionPuertoRico = default(RestrictionPuertoRicoEnum?), RestrictionUsTerritoriesEnum? restrictionUsTerritories = default(RestrictionUsTerritoriesEnum?), List<PaymentsConfigurationRestrictionsTheme> themes = default(List<PaymentsConfigurationRestrictionsTheme>))
        {
            this.Descriptions = descriptions;
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
            this.Themes = themes;
        }
        
        /// <summary>
        /// Gets or Sets Descriptions
        /// </summary>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// Maximum subtotal
        /// </summary>
        /// <value>Maximum subtotal</value>
        [DataMember(Name="maximum_subtotal", EmitDefaultValue=false)]
        public decimal? MaximumSubtotal { get; set; }

        /// <summary>
        /// Minimum subtotal
        /// </summary>
        /// <value>Minimum subtotal</value>
        [DataMember(Name="minimum_subtotal", EmitDefaultValue=false)]
        public decimal? MinimumSubtotal { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        /// <value>Payment method</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }










        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<PaymentsConfigurationRestrictionsTheme> Themes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfigurationRestrictions {\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
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
            sb.Append("  Themes: ").Append(Themes).Append("\n");
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
                    this.Descriptions == input.Descriptions ||
                    this.Descriptions != null &&
                    this.Descriptions.SequenceEqual(input.Descriptions)
                ) && 
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
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
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
                if (this.Descriptions != null)
                    hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
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
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
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

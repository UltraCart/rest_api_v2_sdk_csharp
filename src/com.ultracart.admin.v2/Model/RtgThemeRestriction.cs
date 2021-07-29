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
    /// RtgThemeRestriction
    /// </summary>
    [DataContract]
    public partial class RtgThemeRestriction :  IEquatable<RtgThemeRestriction>, IValidatableObject
    {
        /// <summary>
        /// Any restriction for this theme
        /// </summary>
        /// <value>Any restriction for this theme</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestrictionEnum
        {
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1,
            
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 2,
            
            /// <summary>
            /// Enum ValidOnly for value: validOnly
            /// </summary>
            [EnumMember(Value = "validOnly")]
            ValidOnly = 3
        }

        /// <summary>
        /// Any restriction for this theme
        /// </summary>
        /// <value>Any restriction for this theme</value>
        [DataMember(Name="restriction", EmitDefaultValue=false)]
        public RestrictionEnum? Restriction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RtgThemeRestriction" /> class.
        /// </summary>
        /// <param name="restriction">Any restriction for this theme.</param>
        /// <param name="storefrontHostName">The server name for this theme.  This will not be populated for legacy (ancient) themes.</param>
        /// <param name="themeCode">Human friendly short code for this theme.</param>
        public RtgThemeRestriction(RestrictionEnum? restriction = default(RestrictionEnum?), string storefrontHostName = default(string), string themeCode = default(string))
        {
            this.Restriction = restriction;
            this.StorefrontHostName = storefrontHostName;
            this.ThemeCode = themeCode;
        }
        

        /// <summary>
        /// The server name for this theme.  This will not be populated for legacy (ancient) themes
        /// </summary>
        /// <value>The server name for this theme.  This will not be populated for legacy (ancient) themes</value>
        [DataMember(Name="storefront_host_name", EmitDefaultValue=false)]
        public string StorefrontHostName { get; set; }

        /// <summary>
        /// Human friendly short code for this theme
        /// </summary>
        /// <value>Human friendly short code for this theme</value>
        [DataMember(Name="theme_code", EmitDefaultValue=false)]
        public string ThemeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtgThemeRestriction {\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
            sb.Append("  StorefrontHostName: ").Append(StorefrontHostName).Append("\n");
            sb.Append("  ThemeCode: ").Append(ThemeCode).Append("\n");
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
            return this.Equals(input as RtgThemeRestriction);
        }

        /// <summary>
        /// Returns true if RtgThemeRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of RtgThemeRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RtgThemeRestriction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Restriction == input.Restriction ||
                    (this.Restriction != null &&
                    this.Restriction.Equals(input.Restriction))
                ) && 
                (
                    this.StorefrontHostName == input.StorefrontHostName ||
                    (this.StorefrontHostName != null &&
                    this.StorefrontHostName.Equals(input.StorefrontHostName))
                ) && 
                (
                    this.ThemeCode == input.ThemeCode ||
                    (this.ThemeCode != null &&
                    this.ThemeCode.Equals(input.ThemeCode))
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
                if (this.Restriction != null)
                    hashCode = hashCode * 59 + this.Restriction.GetHashCode();
                if (this.StorefrontHostName != null)
                    hashCode = hashCode * 59 + this.StorefrontHostName.GetHashCode();
                if (this.ThemeCode != null)
                    hashCode = hashCode * 59 + this.ThemeCode.GetHashCode();
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

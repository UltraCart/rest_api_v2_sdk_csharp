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
    /// CartSettingsBilling
    /// </summary>
    [DataContract]
    public partial class CartSettingsBilling :  IEquatable<CartSettingsBilling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsBilling" /> class.
        /// </summary>
        /// <param name="Provinces">Provinces.</param>
        public CartSettingsBilling(List<CartSettingsProvince> Provinces = default(List<CartSettingsProvince>))
        {
            this.Provinces = Provinces;
        }
        
        /// <summary>
        /// Provinces
        /// </summary>
        /// <value>Provinces</value>
        [DataMember(Name="provinces", EmitDefaultValue=false)]
        public List<CartSettingsProvince> Provinces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsBilling {\n");
            sb.Append("  Provinces: ").Append(Provinces).Append("\n");
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
            return this.Equals(input as CartSettingsBilling);
        }

        /// <summary>
        /// Returns true if CartSettingsBilling instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsBilling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsBilling input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provinces == input.Provinces ||
                    this.Provinces != null &&
                    this.Provinces.SequenceEqual(input.Provinces)
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
                if (this.Provinces != null)
                    hashCode = hashCode * 59 + this.Provinces.GetHashCode();
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

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
    /// CartSettingsTerms
    /// </summary>
    [DataContract]
    public partial class CartSettingsTerms :  IEquatable<CartSettingsTerms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartSettingsTerms" /> class.
        /// </summary>
        /// <param name="html">HTML version of the terms.</param>
        /// <param name="text">Text version of the terms..</param>
        public CartSettingsTerms(string html = default(string), string text = default(string))
        {
            this.Html = html;
            this.Text = text;
        }
        
        /// <summary>
        /// HTML version of the terms
        /// </summary>
        /// <value>HTML version of the terms</value>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// Text version of the terms.
        /// </summary>
        /// <value>Text version of the terms.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartSettingsTerms {\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as CartSettingsTerms);
        }

        /// <summary>
        /// Returns true if CartSettingsTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of CartSettingsTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartSettingsTerms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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

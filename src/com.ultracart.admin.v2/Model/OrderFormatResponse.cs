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
    /// OrderFormatResponse
    /// </summary>
    [DataContract]
    public partial class OrderFormatResponse :  IEquatable<OrderFormatResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFormatResponse" /> class.
        /// </summary>
        /// <param name="cssLinks">The URLs to any stylesheets that need to be included to properly view the markup..</param>
        /// <param name="formattedResult">The formatted result of the order.  This will be HTML or text depending upon the requested format..</param>
        public OrderFormatResponse(List<string> cssLinks = default(List<string>), string formattedResult = default(string))
        {
            this.CssLinks = cssLinks;
            this.FormattedResult = formattedResult;
        }
        
        /// <summary>
        /// The URLs to any stylesheets that need to be included to properly view the markup.
        /// </summary>
        /// <value>The URLs to any stylesheets that need to be included to properly view the markup.</value>
        [DataMember(Name="css_links", EmitDefaultValue=false)]
        public List<string> CssLinks { get; set; }

        /// <summary>
        /// The formatted result of the order.  This will be HTML or text depending upon the requested format.
        /// </summary>
        /// <value>The formatted result of the order.  This will be HTML or text depending upon the requested format.</value>
        [DataMember(Name="formatted_result", EmitDefaultValue=false)]
        public string FormattedResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFormatResponse {\n");
            sb.Append("  CssLinks: ").Append(CssLinks).Append("\n");
            sb.Append("  FormattedResult: ").Append(FormattedResult).Append("\n");
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
            return this.Equals(input as OrderFormatResponse);
        }

        /// <summary>
        /// Returns true if OrderFormatResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFormatResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFormatResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CssLinks == input.CssLinks ||
                    this.CssLinks != null &&
                    this.CssLinks.SequenceEqual(input.CssLinks)
                ) && 
                (
                    this.FormattedResult == input.FormattedResult ||
                    (this.FormattedResult != null &&
                    this.FormattedResult.Equals(input.FormattedResult))
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
                if (this.CssLinks != null)
                    hashCode = hashCode * 59 + this.CssLinks.GetHashCode();
                if (this.FormattedResult != null)
                    hashCode = hashCode * 59 + this.FormattedResult.GetHashCode();
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

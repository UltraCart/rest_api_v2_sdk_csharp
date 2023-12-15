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
    /// CartItemMultimediaThumbnail
    /// </summary>
    [DataContract]
    public partial class CartItemMultimediaThumbnail :  IEquatable<CartItemMultimediaThumbnail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItemMultimediaThumbnail" /> class.
        /// </summary>
        /// <param name="height">Height in pixels.</param>
        /// <param name="png">True if thumbnail is a PNG, otherwise its a JPEG.</param>
        /// <param name="square">True if the thumbnail is square.</param>
        /// <param name="url">URL for the thumbnail.</param>
        /// <param name="width">Width in pixels.</param>
        public CartItemMultimediaThumbnail(int height = default(int), bool png = default(bool), bool square = default(bool), string url = default(string), int width = default(int))
        {
            this.Height = height;
            this.Png = png;
            this.Square = square;
            this.Url = url;
            this.Width = width;
        }

        /// <summary>
        /// Height in pixels
        /// </summary>
        /// <value>Height in pixels</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// True if thumbnail is a PNG, otherwise its a JPEG
        /// </summary>
        /// <value>True if thumbnail is a PNG, otherwise its a JPEG</value>
        [DataMember(Name="png", EmitDefaultValue=false)]
        public bool Png { get; set; }

        /// <summary>
        /// True if the thumbnail is square
        /// </summary>
        /// <value>True if the thumbnail is square</value>
        [DataMember(Name="square", EmitDefaultValue=false)]
        public bool Square { get; set; }

        /// <summary>
        /// URL for the thumbnail
        /// </summary>
        /// <value>URL for the thumbnail</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Width in pixels
        /// </summary>
        /// <value>Width in pixels</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItemMultimediaThumbnail {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Png: ").Append(Png).Append("\n");
            sb.Append("  Square: ").Append(Square).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as CartItemMultimediaThumbnail);
        }

        /// <summary>
        /// Returns true if CartItemMultimediaThumbnail instances are equal
        /// </summary>
        /// <param name="input">Instance of CartItemMultimediaThumbnail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItemMultimediaThumbnail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Png == input.Png ||
                    (this.Png != null &&
                    this.Png.Equals(input.Png))
                ) && 
                (
                    this.Square == input.Square ||
                    (this.Square != null &&
                    this.Square.Equals(input.Square))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Png != null)
                    hashCode = hashCode * 59 + this.Png.GetHashCode();
                if (this.Square != null)
                    hashCode = hashCode * 59 + this.Square.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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

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
    /// ThumbnailParametersRequest
    /// </summary>
    [DataContract]
    public partial class ThumbnailParametersRequest :  IEquatable<ThumbnailParametersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThumbnailParametersRequest" /> class.
        /// </summary>
        /// <param name="height">height.</param>
        /// <param name="pngFormat">pngFormat.</param>
        /// <param name="squareThumbnail">squareThumbnail.</param>
        /// <param name="webp">webp.</param>
        /// <param name="width">width.</param>
        public ThumbnailParametersRequest(int height = default(int), bool pngFormat = default(bool), bool squareThumbnail = default(bool), bool webp = default(bool), int width = default(int))
        {
            this.Height = height;
            this.PngFormat = pngFormat;
            this.SquareThumbnail = squareThumbnail;
            this.Webp = webp;
            this.Width = width;
        }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets PngFormat
        /// </summary>
        [DataMember(Name="pngFormat", EmitDefaultValue=false)]
        public bool PngFormat { get; set; }

        /// <summary>
        /// Gets or Sets SquareThumbnail
        /// </summary>
        [DataMember(Name="squareThumbnail", EmitDefaultValue=false)]
        public bool SquareThumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Webp
        /// </summary>
        [DataMember(Name="webp", EmitDefaultValue=false)]
        public bool Webp { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThumbnailParametersRequest {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  PngFormat: ").Append(PngFormat).Append("\n");
            sb.Append("  SquareThumbnail: ").Append(SquareThumbnail).Append("\n");
            sb.Append("  Webp: ").Append(Webp).Append("\n");
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
            return this.Equals(input as ThumbnailParametersRequest);
        }

        /// <summary>
        /// Returns true if ThumbnailParametersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ThumbnailParametersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThumbnailParametersRequest input)
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
                    this.PngFormat == input.PngFormat ||
                    (this.PngFormat != null &&
                    this.PngFormat.Equals(input.PngFormat))
                ) && 
                (
                    this.SquareThumbnail == input.SquareThumbnail ||
                    (this.SquareThumbnail != null &&
                    this.SquareThumbnail.Equals(input.SquareThumbnail))
                ) && 
                (
                    this.Webp == input.Webp ||
                    (this.Webp != null &&
                    this.Webp.Equals(input.Webp))
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
                if (this.PngFormat != null)
                    hashCode = hashCode * 59 + this.PngFormat.GetHashCode();
                if (this.SquareThumbnail != null)
                    hashCode = hashCode * 59 + this.SquareThumbnail.GetHashCode();
                if (this.Webp != null)
                    hashCode = hashCode * 59 + this.Webp.GetHashCode();
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

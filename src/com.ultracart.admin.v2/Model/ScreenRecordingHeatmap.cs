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
    /// ScreenRecordingHeatmap
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingHeatmap :  IEquatable<ScreenRecordingHeatmap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingHeatmap" /> class.
        /// </summary>
        /// <param name="largeClickThumbnailUrl">largeClickThumbnailUrl.</param>
        /// <param name="largeClickUrl">largeClickUrl.</param>
        /// <param name="largeMovementThumbnailUrl">largeMovementThumbnailUrl.</param>
        /// <param name="largeMovementUrl">largeMovementUrl.</param>
        /// <param name="largeRegularThumbnailUrl">largeRegularThumbnailUrl.</param>
        /// <param name="largeRegularUrl">largeRegularUrl.</param>
        /// <param name="largeScrollThumbnailUrl">largeScrollThumbnailUrl.</param>
        /// <param name="largeScrollUrl">largeScrollUrl.</param>
        /// <param name="mediumClickThumbnailUrl">mediumClickThumbnailUrl.</param>
        /// <param name="mediumClickUrl">mediumClickUrl.</param>
        /// <param name="mediumMovementThumbnailUrl">mediumMovementThumbnailUrl.</param>
        /// <param name="mediumMovementUrl">mediumMovementUrl.</param>
        /// <param name="mediumRegularThumbnailUrl">mediumRegularThumbnailUrl.</param>
        /// <param name="mediumRegularUrl">mediumRegularUrl.</param>
        /// <param name="mediumScrollThumbnailUrl">mediumScrollThumbnailUrl.</param>
        /// <param name="mediumScrollUrl">mediumScrollUrl.</param>
        /// <param name="smallClickThumbnailUrl">smallClickThumbnailUrl.</param>
        /// <param name="smallClickUrl">smallClickUrl.</param>
        /// <param name="smallMovementThumbnailUrl">smallMovementThumbnailUrl.</param>
        /// <param name="smallMovementUrl">smallMovementUrl.</param>
        /// <param name="smallRegularThumbnailUrl">smallRegularThumbnailUrl.</param>
        /// <param name="smallRegularUrl">smallRegularUrl.</param>
        /// <param name="smallScrollThumbnailUrl">smallScrollThumbnailUrl.</param>
        /// <param name="smallScrollUrl">smallScrollUrl.</param>
        public ScreenRecordingHeatmap(string largeClickThumbnailUrl = default(string), string largeClickUrl = default(string), string largeMovementThumbnailUrl = default(string), string largeMovementUrl = default(string), string largeRegularThumbnailUrl = default(string), string largeRegularUrl = default(string), string largeScrollThumbnailUrl = default(string), string largeScrollUrl = default(string), string mediumClickThumbnailUrl = default(string), string mediumClickUrl = default(string), string mediumMovementThumbnailUrl = default(string), string mediumMovementUrl = default(string), string mediumRegularThumbnailUrl = default(string), string mediumRegularUrl = default(string), string mediumScrollThumbnailUrl = default(string), string mediumScrollUrl = default(string), string smallClickThumbnailUrl = default(string), string smallClickUrl = default(string), string smallMovementThumbnailUrl = default(string), string smallMovementUrl = default(string), string smallRegularThumbnailUrl = default(string), string smallRegularUrl = default(string), string smallScrollThumbnailUrl = default(string), string smallScrollUrl = default(string))
        {
            this.LargeClickThumbnailUrl = largeClickThumbnailUrl;
            this.LargeClickUrl = largeClickUrl;
            this.LargeMovementThumbnailUrl = largeMovementThumbnailUrl;
            this.LargeMovementUrl = largeMovementUrl;
            this.LargeRegularThumbnailUrl = largeRegularThumbnailUrl;
            this.LargeRegularUrl = largeRegularUrl;
            this.LargeScrollThumbnailUrl = largeScrollThumbnailUrl;
            this.LargeScrollUrl = largeScrollUrl;
            this.MediumClickThumbnailUrl = mediumClickThumbnailUrl;
            this.MediumClickUrl = mediumClickUrl;
            this.MediumMovementThumbnailUrl = mediumMovementThumbnailUrl;
            this.MediumMovementUrl = mediumMovementUrl;
            this.MediumRegularThumbnailUrl = mediumRegularThumbnailUrl;
            this.MediumRegularUrl = mediumRegularUrl;
            this.MediumScrollThumbnailUrl = mediumScrollThumbnailUrl;
            this.MediumScrollUrl = mediumScrollUrl;
            this.SmallClickThumbnailUrl = smallClickThumbnailUrl;
            this.SmallClickUrl = smallClickUrl;
            this.SmallMovementThumbnailUrl = smallMovementThumbnailUrl;
            this.SmallMovementUrl = smallMovementUrl;
            this.SmallRegularThumbnailUrl = smallRegularThumbnailUrl;
            this.SmallRegularUrl = smallRegularUrl;
            this.SmallScrollThumbnailUrl = smallScrollThumbnailUrl;
            this.SmallScrollUrl = smallScrollUrl;
        }
        
        /// <summary>
        /// Gets or Sets LargeClickThumbnailUrl
        /// </summary>
        [DataMember(Name="large_click_thumbnail_url", EmitDefaultValue=false)]
        public string LargeClickThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeClickUrl
        /// </summary>
        [DataMember(Name="large_click_url", EmitDefaultValue=false)]
        public string LargeClickUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeMovementThumbnailUrl
        /// </summary>
        [DataMember(Name="large_movement_thumbnail_url", EmitDefaultValue=false)]
        public string LargeMovementThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeMovementUrl
        /// </summary>
        [DataMember(Name="large_movement_url", EmitDefaultValue=false)]
        public string LargeMovementUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeRegularThumbnailUrl
        /// </summary>
        [DataMember(Name="large_regular_thumbnail_url", EmitDefaultValue=false)]
        public string LargeRegularThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeRegularUrl
        /// </summary>
        [DataMember(Name="large_regular_url", EmitDefaultValue=false)]
        public string LargeRegularUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeScrollThumbnailUrl
        /// </summary>
        [DataMember(Name="large_scroll_thumbnail_url", EmitDefaultValue=false)]
        public string LargeScrollThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets LargeScrollUrl
        /// </summary>
        [DataMember(Name="large_scroll_url", EmitDefaultValue=false)]
        public string LargeScrollUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumClickThumbnailUrl
        /// </summary>
        [DataMember(Name="medium_click_thumbnail_url", EmitDefaultValue=false)]
        public string MediumClickThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumClickUrl
        /// </summary>
        [DataMember(Name="medium_click_url", EmitDefaultValue=false)]
        public string MediumClickUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumMovementThumbnailUrl
        /// </summary>
        [DataMember(Name="medium_movement_thumbnail_url", EmitDefaultValue=false)]
        public string MediumMovementThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumMovementUrl
        /// </summary>
        [DataMember(Name="medium_movement_url", EmitDefaultValue=false)]
        public string MediumMovementUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumRegularThumbnailUrl
        /// </summary>
        [DataMember(Name="medium_regular_thumbnail_url", EmitDefaultValue=false)]
        public string MediumRegularThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumRegularUrl
        /// </summary>
        [DataMember(Name="medium_regular_url", EmitDefaultValue=false)]
        public string MediumRegularUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumScrollThumbnailUrl
        /// </summary>
        [DataMember(Name="medium_scroll_thumbnail_url", EmitDefaultValue=false)]
        public string MediumScrollThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets MediumScrollUrl
        /// </summary>
        [DataMember(Name="medium_scroll_url", EmitDefaultValue=false)]
        public string MediumScrollUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallClickThumbnailUrl
        /// </summary>
        [DataMember(Name="small_click_thumbnail_url", EmitDefaultValue=false)]
        public string SmallClickThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallClickUrl
        /// </summary>
        [DataMember(Name="small_click_url", EmitDefaultValue=false)]
        public string SmallClickUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallMovementThumbnailUrl
        /// </summary>
        [DataMember(Name="small_movement_thumbnail_url", EmitDefaultValue=false)]
        public string SmallMovementThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallMovementUrl
        /// </summary>
        [DataMember(Name="small_movement_url", EmitDefaultValue=false)]
        public string SmallMovementUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallRegularThumbnailUrl
        /// </summary>
        [DataMember(Name="small_regular_thumbnail_url", EmitDefaultValue=false)]
        public string SmallRegularThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallRegularUrl
        /// </summary>
        [DataMember(Name="small_regular_url", EmitDefaultValue=false)]
        public string SmallRegularUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallScrollThumbnailUrl
        /// </summary>
        [DataMember(Name="small_scroll_thumbnail_url", EmitDefaultValue=false)]
        public string SmallScrollThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets SmallScrollUrl
        /// </summary>
        [DataMember(Name="small_scroll_url", EmitDefaultValue=false)]
        public string SmallScrollUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingHeatmap {\n");
            sb.Append("  LargeClickThumbnailUrl: ").Append(LargeClickThumbnailUrl).Append("\n");
            sb.Append("  LargeClickUrl: ").Append(LargeClickUrl).Append("\n");
            sb.Append("  LargeMovementThumbnailUrl: ").Append(LargeMovementThumbnailUrl).Append("\n");
            sb.Append("  LargeMovementUrl: ").Append(LargeMovementUrl).Append("\n");
            sb.Append("  LargeRegularThumbnailUrl: ").Append(LargeRegularThumbnailUrl).Append("\n");
            sb.Append("  LargeRegularUrl: ").Append(LargeRegularUrl).Append("\n");
            sb.Append("  LargeScrollThumbnailUrl: ").Append(LargeScrollThumbnailUrl).Append("\n");
            sb.Append("  LargeScrollUrl: ").Append(LargeScrollUrl).Append("\n");
            sb.Append("  MediumClickThumbnailUrl: ").Append(MediumClickThumbnailUrl).Append("\n");
            sb.Append("  MediumClickUrl: ").Append(MediumClickUrl).Append("\n");
            sb.Append("  MediumMovementThumbnailUrl: ").Append(MediumMovementThumbnailUrl).Append("\n");
            sb.Append("  MediumMovementUrl: ").Append(MediumMovementUrl).Append("\n");
            sb.Append("  MediumRegularThumbnailUrl: ").Append(MediumRegularThumbnailUrl).Append("\n");
            sb.Append("  MediumRegularUrl: ").Append(MediumRegularUrl).Append("\n");
            sb.Append("  MediumScrollThumbnailUrl: ").Append(MediumScrollThumbnailUrl).Append("\n");
            sb.Append("  MediumScrollUrl: ").Append(MediumScrollUrl).Append("\n");
            sb.Append("  SmallClickThumbnailUrl: ").Append(SmallClickThumbnailUrl).Append("\n");
            sb.Append("  SmallClickUrl: ").Append(SmallClickUrl).Append("\n");
            sb.Append("  SmallMovementThumbnailUrl: ").Append(SmallMovementThumbnailUrl).Append("\n");
            sb.Append("  SmallMovementUrl: ").Append(SmallMovementUrl).Append("\n");
            sb.Append("  SmallRegularThumbnailUrl: ").Append(SmallRegularThumbnailUrl).Append("\n");
            sb.Append("  SmallRegularUrl: ").Append(SmallRegularUrl).Append("\n");
            sb.Append("  SmallScrollThumbnailUrl: ").Append(SmallScrollThumbnailUrl).Append("\n");
            sb.Append("  SmallScrollUrl: ").Append(SmallScrollUrl).Append("\n");
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
            return this.Equals(input as ScreenRecordingHeatmap);
        }

        /// <summary>
        /// Returns true if ScreenRecordingHeatmap instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingHeatmap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingHeatmap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LargeClickThumbnailUrl == input.LargeClickThumbnailUrl ||
                    (this.LargeClickThumbnailUrl != null &&
                    this.LargeClickThumbnailUrl.Equals(input.LargeClickThumbnailUrl))
                ) && 
                (
                    this.LargeClickUrl == input.LargeClickUrl ||
                    (this.LargeClickUrl != null &&
                    this.LargeClickUrl.Equals(input.LargeClickUrl))
                ) && 
                (
                    this.LargeMovementThumbnailUrl == input.LargeMovementThumbnailUrl ||
                    (this.LargeMovementThumbnailUrl != null &&
                    this.LargeMovementThumbnailUrl.Equals(input.LargeMovementThumbnailUrl))
                ) && 
                (
                    this.LargeMovementUrl == input.LargeMovementUrl ||
                    (this.LargeMovementUrl != null &&
                    this.LargeMovementUrl.Equals(input.LargeMovementUrl))
                ) && 
                (
                    this.LargeRegularThumbnailUrl == input.LargeRegularThumbnailUrl ||
                    (this.LargeRegularThumbnailUrl != null &&
                    this.LargeRegularThumbnailUrl.Equals(input.LargeRegularThumbnailUrl))
                ) && 
                (
                    this.LargeRegularUrl == input.LargeRegularUrl ||
                    (this.LargeRegularUrl != null &&
                    this.LargeRegularUrl.Equals(input.LargeRegularUrl))
                ) && 
                (
                    this.LargeScrollThumbnailUrl == input.LargeScrollThumbnailUrl ||
                    (this.LargeScrollThumbnailUrl != null &&
                    this.LargeScrollThumbnailUrl.Equals(input.LargeScrollThumbnailUrl))
                ) && 
                (
                    this.LargeScrollUrl == input.LargeScrollUrl ||
                    (this.LargeScrollUrl != null &&
                    this.LargeScrollUrl.Equals(input.LargeScrollUrl))
                ) && 
                (
                    this.MediumClickThumbnailUrl == input.MediumClickThumbnailUrl ||
                    (this.MediumClickThumbnailUrl != null &&
                    this.MediumClickThumbnailUrl.Equals(input.MediumClickThumbnailUrl))
                ) && 
                (
                    this.MediumClickUrl == input.MediumClickUrl ||
                    (this.MediumClickUrl != null &&
                    this.MediumClickUrl.Equals(input.MediumClickUrl))
                ) && 
                (
                    this.MediumMovementThumbnailUrl == input.MediumMovementThumbnailUrl ||
                    (this.MediumMovementThumbnailUrl != null &&
                    this.MediumMovementThumbnailUrl.Equals(input.MediumMovementThumbnailUrl))
                ) && 
                (
                    this.MediumMovementUrl == input.MediumMovementUrl ||
                    (this.MediumMovementUrl != null &&
                    this.MediumMovementUrl.Equals(input.MediumMovementUrl))
                ) && 
                (
                    this.MediumRegularThumbnailUrl == input.MediumRegularThumbnailUrl ||
                    (this.MediumRegularThumbnailUrl != null &&
                    this.MediumRegularThumbnailUrl.Equals(input.MediumRegularThumbnailUrl))
                ) && 
                (
                    this.MediumRegularUrl == input.MediumRegularUrl ||
                    (this.MediumRegularUrl != null &&
                    this.MediumRegularUrl.Equals(input.MediumRegularUrl))
                ) && 
                (
                    this.MediumScrollThumbnailUrl == input.MediumScrollThumbnailUrl ||
                    (this.MediumScrollThumbnailUrl != null &&
                    this.MediumScrollThumbnailUrl.Equals(input.MediumScrollThumbnailUrl))
                ) && 
                (
                    this.MediumScrollUrl == input.MediumScrollUrl ||
                    (this.MediumScrollUrl != null &&
                    this.MediumScrollUrl.Equals(input.MediumScrollUrl))
                ) && 
                (
                    this.SmallClickThumbnailUrl == input.SmallClickThumbnailUrl ||
                    (this.SmallClickThumbnailUrl != null &&
                    this.SmallClickThumbnailUrl.Equals(input.SmallClickThumbnailUrl))
                ) && 
                (
                    this.SmallClickUrl == input.SmallClickUrl ||
                    (this.SmallClickUrl != null &&
                    this.SmallClickUrl.Equals(input.SmallClickUrl))
                ) && 
                (
                    this.SmallMovementThumbnailUrl == input.SmallMovementThumbnailUrl ||
                    (this.SmallMovementThumbnailUrl != null &&
                    this.SmallMovementThumbnailUrl.Equals(input.SmallMovementThumbnailUrl))
                ) && 
                (
                    this.SmallMovementUrl == input.SmallMovementUrl ||
                    (this.SmallMovementUrl != null &&
                    this.SmallMovementUrl.Equals(input.SmallMovementUrl))
                ) && 
                (
                    this.SmallRegularThumbnailUrl == input.SmallRegularThumbnailUrl ||
                    (this.SmallRegularThumbnailUrl != null &&
                    this.SmallRegularThumbnailUrl.Equals(input.SmallRegularThumbnailUrl))
                ) && 
                (
                    this.SmallRegularUrl == input.SmallRegularUrl ||
                    (this.SmallRegularUrl != null &&
                    this.SmallRegularUrl.Equals(input.SmallRegularUrl))
                ) && 
                (
                    this.SmallScrollThumbnailUrl == input.SmallScrollThumbnailUrl ||
                    (this.SmallScrollThumbnailUrl != null &&
                    this.SmallScrollThumbnailUrl.Equals(input.SmallScrollThumbnailUrl))
                ) && 
                (
                    this.SmallScrollUrl == input.SmallScrollUrl ||
                    (this.SmallScrollUrl != null &&
                    this.SmallScrollUrl.Equals(input.SmallScrollUrl))
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
                if (this.LargeClickThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.LargeClickThumbnailUrl.GetHashCode();
                if (this.LargeClickUrl != null)
                    hashCode = hashCode * 59 + this.LargeClickUrl.GetHashCode();
                if (this.LargeMovementThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.LargeMovementThumbnailUrl.GetHashCode();
                if (this.LargeMovementUrl != null)
                    hashCode = hashCode * 59 + this.LargeMovementUrl.GetHashCode();
                if (this.LargeRegularThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.LargeRegularThumbnailUrl.GetHashCode();
                if (this.LargeRegularUrl != null)
                    hashCode = hashCode * 59 + this.LargeRegularUrl.GetHashCode();
                if (this.LargeScrollThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.LargeScrollThumbnailUrl.GetHashCode();
                if (this.LargeScrollUrl != null)
                    hashCode = hashCode * 59 + this.LargeScrollUrl.GetHashCode();
                if (this.MediumClickThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.MediumClickThumbnailUrl.GetHashCode();
                if (this.MediumClickUrl != null)
                    hashCode = hashCode * 59 + this.MediumClickUrl.GetHashCode();
                if (this.MediumMovementThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.MediumMovementThumbnailUrl.GetHashCode();
                if (this.MediumMovementUrl != null)
                    hashCode = hashCode * 59 + this.MediumMovementUrl.GetHashCode();
                if (this.MediumRegularThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.MediumRegularThumbnailUrl.GetHashCode();
                if (this.MediumRegularUrl != null)
                    hashCode = hashCode * 59 + this.MediumRegularUrl.GetHashCode();
                if (this.MediumScrollThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.MediumScrollThumbnailUrl.GetHashCode();
                if (this.MediumScrollUrl != null)
                    hashCode = hashCode * 59 + this.MediumScrollUrl.GetHashCode();
                if (this.SmallClickThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.SmallClickThumbnailUrl.GetHashCode();
                if (this.SmallClickUrl != null)
                    hashCode = hashCode * 59 + this.SmallClickUrl.GetHashCode();
                if (this.SmallMovementThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.SmallMovementThumbnailUrl.GetHashCode();
                if (this.SmallMovementUrl != null)
                    hashCode = hashCode * 59 + this.SmallMovementUrl.GetHashCode();
                if (this.SmallRegularThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.SmallRegularThumbnailUrl.GetHashCode();
                if (this.SmallRegularUrl != null)
                    hashCode = hashCode * 59 + this.SmallRegularUrl.GetHashCode();
                if (this.SmallScrollThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.SmallScrollThumbnailUrl.GetHashCode();
                if (this.SmallScrollUrl != null)
                    hashCode = hashCode * 59 + this.SmallScrollUrl.GetHashCode();
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

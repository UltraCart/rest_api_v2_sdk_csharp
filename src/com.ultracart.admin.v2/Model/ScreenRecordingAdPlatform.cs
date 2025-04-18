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
    /// ScreenRecordingAdPlatform
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingAdPlatform :  IEquatable<ScreenRecordingAdPlatform>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingAdPlatform" /> class.
        /// </summary>
        /// <param name="fbc">Facebook Click Id (Cookie).</param>
        /// <param name="fbclid">Facebook Click Id Parameter (Parameter).</param>
        /// <param name="fbp">Facebook Browser Id (Cookie).</param>
        /// <param name="gacid">Google Analytics CID (Cookie).</param>
        /// <param name="glcid">Google Adwords Click Id (Parameter).</param>
        /// <param name="msclkid">Bing Click Id (Parameter.</param>
        /// <param name="ttclid">TikTok Click Id (Parameter.</param>
        public ScreenRecordingAdPlatform(string fbc = default(string), string fbclid = default(string), string fbp = default(string), string gacid = default(string), string glcid = default(string), string msclkid = default(string), string ttclid = default(string))
        {
            this.Fbc = fbc;
            this.Fbclid = fbclid;
            this.Fbp = fbp;
            this.Gacid = gacid;
            this.Glcid = glcid;
            this.Msclkid = msclkid;
            this.Ttclid = ttclid;
        }

        /// <summary>
        /// Facebook Click Id (Cookie)
        /// </summary>
        /// <value>Facebook Click Id (Cookie)</value>
        [DataMember(Name="fbc", EmitDefaultValue=false)]
        public string Fbc { get; set; }

        /// <summary>
        /// Facebook Click Id Parameter (Parameter)
        /// </summary>
        /// <value>Facebook Click Id Parameter (Parameter)</value>
        [DataMember(Name="fbclid", EmitDefaultValue=false)]
        public string Fbclid { get; set; }

        /// <summary>
        /// Facebook Browser Id (Cookie)
        /// </summary>
        /// <value>Facebook Browser Id (Cookie)</value>
        [DataMember(Name="fbp", EmitDefaultValue=false)]
        public string Fbp { get; set; }

        /// <summary>
        /// Google Analytics CID (Cookie)
        /// </summary>
        /// <value>Google Analytics CID (Cookie)</value>
        [DataMember(Name="gacid", EmitDefaultValue=false)]
        public string Gacid { get; set; }

        /// <summary>
        /// Google Adwords Click Id (Parameter)
        /// </summary>
        /// <value>Google Adwords Click Id (Parameter)</value>
        [DataMember(Name="glcid", EmitDefaultValue=false)]
        public string Glcid { get; set; }

        /// <summary>
        /// Bing Click Id (Parameter
        /// </summary>
        /// <value>Bing Click Id (Parameter</value>
        [DataMember(Name="msclkid", EmitDefaultValue=false)]
        public string Msclkid { get; set; }

        /// <summary>
        /// TikTok Click Id (Parameter
        /// </summary>
        /// <value>TikTok Click Id (Parameter</value>
        [DataMember(Name="ttclid", EmitDefaultValue=false)]
        public string Ttclid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingAdPlatform {\n");
            sb.Append("  Fbc: ").Append(Fbc).Append("\n");
            sb.Append("  Fbclid: ").Append(Fbclid).Append("\n");
            sb.Append("  Fbp: ").Append(Fbp).Append("\n");
            sb.Append("  Gacid: ").Append(Gacid).Append("\n");
            sb.Append("  Glcid: ").Append(Glcid).Append("\n");
            sb.Append("  Msclkid: ").Append(Msclkid).Append("\n");
            sb.Append("  Ttclid: ").Append(Ttclid).Append("\n");
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
            return this.Equals(input as ScreenRecordingAdPlatform);
        }

        /// <summary>
        /// Returns true if ScreenRecordingAdPlatform instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingAdPlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingAdPlatform input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fbc == input.Fbc ||
                    (this.Fbc != null &&
                    this.Fbc.Equals(input.Fbc))
                ) && 
                (
                    this.Fbclid == input.Fbclid ||
                    (this.Fbclid != null &&
                    this.Fbclid.Equals(input.Fbclid))
                ) && 
                (
                    this.Fbp == input.Fbp ||
                    (this.Fbp != null &&
                    this.Fbp.Equals(input.Fbp))
                ) && 
                (
                    this.Gacid == input.Gacid ||
                    (this.Gacid != null &&
                    this.Gacid.Equals(input.Gacid))
                ) && 
                (
                    this.Glcid == input.Glcid ||
                    (this.Glcid != null &&
                    this.Glcid.Equals(input.Glcid))
                ) && 
                (
                    this.Msclkid == input.Msclkid ||
                    (this.Msclkid != null &&
                    this.Msclkid.Equals(input.Msclkid))
                ) && 
                (
                    this.Ttclid == input.Ttclid ||
                    (this.Ttclid != null &&
                    this.Ttclid.Equals(input.Ttclid))
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
                if (this.Fbc != null)
                    hashCode = hashCode * 59 + this.Fbc.GetHashCode();
                if (this.Fbclid != null)
                    hashCode = hashCode * 59 + this.Fbclid.GetHashCode();
                if (this.Fbp != null)
                    hashCode = hashCode * 59 + this.Fbp.GetHashCode();
                if (this.Gacid != null)
                    hashCode = hashCode * 59 + this.Gacid.GetHashCode();
                if (this.Glcid != null)
                    hashCode = hashCode * 59 + this.Glcid.GetHashCode();
                if (this.Msclkid != null)
                    hashCode = hashCode * 59 + this.Msclkid.GetHashCode();
                if (this.Ttclid != null)
                    hashCode = hashCode * 59 + this.Ttclid.GetHashCode();
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

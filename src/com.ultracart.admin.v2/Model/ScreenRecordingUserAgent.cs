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
    /// ScreenRecordingUserAgent
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingUserAgent :  IEquatable<ScreenRecordingUserAgent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingUserAgent" /> class.
        /// </summary>
        /// <param name="device">device.</param>
        /// <param name="name">name.</param>
        /// <param name="original">original.</param>
        /// <param name="os">os.</param>
        /// <param name="version">version.</param>
        public ScreenRecordingUserAgent(ScreenRecordingUserAgentDevice device = default(ScreenRecordingUserAgentDevice), string name = default(string), string original = default(string), ScreenRecordingUserAgentOS os = default(ScreenRecordingUserAgentOS), string version = default(string))
        {
            this.Device = device;
            this.Name = name;
            this.Original = original;
            this.Os = os;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public ScreenRecordingUserAgentDevice Device { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Original
        /// </summary>
        [DataMember(Name="original", EmitDefaultValue=false)]
        public string Original { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public ScreenRecordingUserAgentOS Os { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingUserAgent {\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as ScreenRecordingUserAgent);
        }

        /// <summary>
        /// Returns true if ScreenRecordingUserAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingUserAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingUserAgent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Original == input.Original ||
                    (this.Original != null &&
                    this.Original.Equals(input.Original))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Original != null)
                    hashCode = hashCode * 59 + this.Original.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
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

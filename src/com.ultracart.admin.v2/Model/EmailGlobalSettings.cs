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
    /// EmailGlobalSettings
    /// </summary>
    [DataContract]
    public partial class EmailGlobalSettings :  IEquatable<EmailGlobalSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGlobalSettings" /> class.
        /// </summary>
        /// <param name="dedicatedIp">dedicatedIp.</param>
        public EmailGlobalSettings(bool dedicatedIp = default(bool))
        {
            this.DedicatedIp = dedicatedIp;
        }

        /// <summary>
        /// Gets or Sets DedicatedIp
        /// </summary>
        [DataMember(Name="dedicated_ip", EmitDefaultValue=false)]
        public bool DedicatedIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailGlobalSettings {\n");
            sb.Append("  DedicatedIp: ").Append(DedicatedIp).Append("\n");
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
            return this.Equals(input as EmailGlobalSettings);
        }

        /// <summary>
        /// Returns true if EmailGlobalSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailGlobalSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailGlobalSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DedicatedIp == input.DedicatedIp ||
                    (this.DedicatedIp != null &&
                    this.DedicatedIp.Equals(input.DedicatedIp))
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
                if (this.DedicatedIp != null)
                    hashCode = hashCode * 59 + this.DedicatedIp.GetHashCode();
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

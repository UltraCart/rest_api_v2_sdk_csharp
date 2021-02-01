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
    /// ScreenRecordingStoreFront
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingStoreFront :  IEquatable<ScreenRecordingStoreFront>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingStoreFront" /> class.
        /// </summary>
        /// <param name="storefrontHostName">storefrontHostName.</param>
        /// <param name="storefrontOid">storefrontOid.</param>
        public ScreenRecordingStoreFront(string storefrontHostName = default(string), int? storefrontOid = default(int?))
        {
            this.StorefrontHostName = storefrontHostName;
            this.StorefrontOid = storefrontOid;
        }
        
        /// <summary>
        /// Gets or Sets StorefrontHostName
        /// </summary>
        [DataMember(Name="storefront_host_name", EmitDefaultValue=false)]
        public string StorefrontHostName { get; set; }

        /// <summary>
        /// Gets or Sets StorefrontOid
        /// </summary>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingStoreFront {\n");
            sb.Append("  StorefrontHostName: ").Append(StorefrontHostName).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as ScreenRecordingStoreFront);
        }

        /// <summary>
        /// Returns true if ScreenRecordingStoreFront instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingStoreFront to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingStoreFront input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorefrontHostName == input.StorefrontHostName ||
                    (this.StorefrontHostName != null &&
                    this.StorefrontHostName.Equals(input.StorefrontHostName))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
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
                if (this.StorefrontHostName != null)
                    hashCode = hashCode * 59 + this.StorefrontHostName.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
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

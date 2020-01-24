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
    /// EmailListSubscribeResponse
    /// </summary>
    [DataContract]
    public partial class EmailListSubscribeResponse :  IEquatable<EmailListSubscribeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailListSubscribeResponse" /> class.
        /// </summary>
        /// <param name="Added">Added.</param>
        /// <param name="MemberCount">MemberCount.</param>
        public EmailListSubscribeResponse(int? Added = default(int?), int? MemberCount = default(int?))
        {
            this.Added = Added;
            this.MemberCount = MemberCount;
        }
        
        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public int? Added { get; set; }

        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailListSubscribeResponse {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
            return this.Equals(input as EmailListSubscribeResponse);
        }

        /// <summary>
        /// Returns true if EmailListSubscribeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailListSubscribeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailListSubscribeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
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
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
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

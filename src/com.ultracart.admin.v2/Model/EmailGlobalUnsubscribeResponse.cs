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
    /// EmailGlobalUnsubscribeResponse
    /// </summary>
    [DataContract]
    public partial class EmailGlobalUnsubscribeResponse :  IEquatable<EmailGlobalUnsubscribeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailGlobalUnsubscribeResponse" /> class.
        /// </summary>
        /// <param name="listsUnsubscribed">listsUnsubscribed.</param>
        public EmailGlobalUnsubscribeResponse(int? listsUnsubscribed = default(int?))
        {
            this.ListsUnsubscribed = listsUnsubscribed;
        }
        
        /// <summary>
        /// Gets or Sets ListsUnsubscribed
        /// </summary>
        [DataMember(Name="listsUnsubscribed", EmitDefaultValue=false)]
        public int? ListsUnsubscribed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailGlobalUnsubscribeResponse {\n");
            sb.Append("  ListsUnsubscribed: ").Append(ListsUnsubscribed).Append("\n");
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
            return this.Equals(input as EmailGlobalUnsubscribeResponse);
        }

        /// <summary>
        /// Returns true if EmailGlobalUnsubscribeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailGlobalUnsubscribeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailGlobalUnsubscribeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListsUnsubscribed == input.ListsUnsubscribed ||
                    (this.ListsUnsubscribed != null &&
                    this.ListsUnsubscribed.Equals(input.ListsUnsubscribed))
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
                if (this.ListsUnsubscribed != null)
                    hashCode = hashCode * 59 + this.ListsUnsubscribed.GetHashCode();
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
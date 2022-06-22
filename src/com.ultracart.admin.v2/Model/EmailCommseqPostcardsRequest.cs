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
    /// EmailCommseqPostcardsRequest
    /// </summary>
    [DataContract]
    public partial class EmailCommseqPostcardsRequest :  IEquatable<EmailCommseqPostcardsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCommseqPostcardsRequest" /> class.
        /// </summary>
        /// <param name="espCommseqPostcardUuids">espCommseqPostcardUuids.</param>
        public EmailCommseqPostcardsRequest(List<string> espCommseqPostcardUuids = default(List<string>))
        {
            this.EspCommseqPostcardUuids = espCommseqPostcardUuids;
        }

        /// <summary>
        /// Gets or Sets EspCommseqPostcardUuids
        /// </summary>
        [DataMember(Name="esp_commseq_postcard_uuids", EmitDefaultValue=false)]
        public List<string> EspCommseqPostcardUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCommseqPostcardsRequest {\n");
            sb.Append("  EspCommseqPostcardUuids: ").Append(EspCommseqPostcardUuids).Append("\n");
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
            return this.Equals(input as EmailCommseqPostcardsRequest);
        }

        /// <summary>
        /// Returns true if EmailCommseqPostcardsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCommseqPostcardsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCommseqPostcardsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EspCommseqPostcardUuids == input.EspCommseqPostcardUuids ||
                    this.EspCommseqPostcardUuids != null &&
                    input.EspCommseqPostcardUuids != null &&
                    this.EspCommseqPostcardUuids.SequenceEqual(input.EspCommseqPostcardUuids)
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
                if (this.EspCommseqPostcardUuids != null)
                    hashCode = hashCode * 59 + this.EspCommseqPostcardUuids.GetHashCode();
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

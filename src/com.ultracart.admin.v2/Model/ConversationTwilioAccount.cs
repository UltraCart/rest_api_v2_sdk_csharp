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
    /// ConversationTwilioAccount
    /// </summary>
    [DataContract]
    public partial class ConversationTwilioAccount :  IEquatable<ConversationTwilioAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTwilioAccount" /> class.
        /// </summary>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="twilioPhoneNumbers">twilioPhoneNumbers.</param>
        public ConversationTwilioAccount(string merchantId = default(string), List<string> twilioPhoneNumbers = default(List<string>))
        {
            this.MerchantId = merchantId;
            this.TwilioPhoneNumbers = twilioPhoneNumbers;
        }
        
        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets TwilioPhoneNumbers
        /// </summary>
        [DataMember(Name="twilio_phone_numbers", EmitDefaultValue=false)]
        public List<string> TwilioPhoneNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationTwilioAccount {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  TwilioPhoneNumbers: ").Append(TwilioPhoneNumbers).Append("\n");
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
            return this.Equals(input as ConversationTwilioAccount);
        }

        /// <summary>
        /// Returns true if ConversationTwilioAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationTwilioAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationTwilioAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.TwilioPhoneNumbers == input.TwilioPhoneNumbers ||
                    this.TwilioPhoneNumbers != null &&
                    this.TwilioPhoneNumbers.SequenceEqual(input.TwilioPhoneNumbers)
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
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.TwilioPhoneNumbers != null)
                    hashCode = hashCode * 59 + this.TwilioPhoneNumbers.GetHashCode();
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

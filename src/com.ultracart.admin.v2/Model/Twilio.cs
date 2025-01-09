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
    /// Twilio
    /// </summary>
    [DataContract]
    public partial class Twilio :  IEquatable<Twilio>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Twilio" /> class.
        /// </summary>
        /// <param name="accountSid">accountSid.</param>
        /// <param name="apiKeyId">apiKeyId.</param>
        /// <param name="apiKeyName">apiKeyName.</param>
        /// <param name="authToken">authToken.</param>
        /// <param name="espTwilioUuid">espTwilioUuid.</param>
        /// <param name="inboundTwimlAppSid">inboundTwimlAppSid.</param>
        /// <param name="outboundTwimlAppSid">outboundTwimlAppSid.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="twilioWorkspaceSid">twilioWorkspaceSid.</param>
        public Twilio(string accountSid = default(string), string apiKeyId = default(string), string apiKeyName = default(string), string authToken = default(string), string espTwilioUuid = default(string), string inboundTwimlAppSid = default(string), string outboundTwimlAppSid = default(string), List<string> phoneNumbers = default(List<string>), string twilioWorkspaceSid = default(string))
        {
            this.AccountSid = accountSid;
            this.ApiKeyId = apiKeyId;
            this.ApiKeyName = apiKeyName;
            this.AuthToken = authToken;
            this.EspTwilioUuid = espTwilioUuid;
            this.InboundTwimlAppSid = inboundTwimlAppSid;
            this.OutboundTwimlAppSid = outboundTwimlAppSid;
            this.PhoneNumbers = phoneNumbers;
            this.TwilioWorkspaceSid = twilioWorkspaceSid;
        }

        /// <summary>
        /// Gets or Sets AccountSid
        /// </summary>
        [DataMember(Name="account_sid", EmitDefaultValue=false)]
        public string AccountSid { get; set; }

        /// <summary>
        /// Gets or Sets ApiKeyId
        /// </summary>
        [DataMember(Name="api_key_id", EmitDefaultValue=false)]
        public string ApiKeyId { get; set; }

        /// <summary>
        /// Gets or Sets ApiKeyName
        /// </summary>
        [DataMember(Name="api_key_name", EmitDefaultValue=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name="auth_token", EmitDefaultValue=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or Sets EspTwilioUuid
        /// </summary>
        [DataMember(Name="esp_twilio_uuid", EmitDefaultValue=false)]
        public string EspTwilioUuid { get; set; }

        /// <summary>
        /// Gets or Sets InboundTwimlAppSid
        /// </summary>
        [DataMember(Name="inbound_twiml_app_sid", EmitDefaultValue=false)]
        public string InboundTwimlAppSid { get; set; }

        /// <summary>
        /// Gets or Sets OutboundTwimlAppSid
        /// </summary>
        [DataMember(Name="outbound_twiml_app_sid", EmitDefaultValue=false)]
        public string OutboundTwimlAppSid { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="phone_numbers", EmitDefaultValue=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets TwilioWorkspaceSid
        /// </summary>
        [DataMember(Name="twilio_workspace_sid", EmitDefaultValue=false)]
        public string TwilioWorkspaceSid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Twilio {\n");
            sb.Append("  AccountSid: ").Append(AccountSid).Append("\n");
            sb.Append("  ApiKeyId: ").Append(ApiKeyId).Append("\n");
            sb.Append("  ApiKeyName: ").Append(ApiKeyName).Append("\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  EspTwilioUuid: ").Append(EspTwilioUuid).Append("\n");
            sb.Append("  InboundTwimlAppSid: ").Append(InboundTwimlAppSid).Append("\n");
            sb.Append("  OutboundTwimlAppSid: ").Append(OutboundTwimlAppSid).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  TwilioWorkspaceSid: ").Append(TwilioWorkspaceSid).Append("\n");
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
            return this.Equals(input as Twilio);
        }

        /// <summary>
        /// Returns true if Twilio instances are equal
        /// </summary>
        /// <param name="input">Instance of Twilio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Twilio input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountSid == input.AccountSid ||
                    (this.AccountSid != null &&
                    this.AccountSid.Equals(input.AccountSid))
                ) && 
                (
                    this.ApiKeyId == input.ApiKeyId ||
                    (this.ApiKeyId != null &&
                    this.ApiKeyId.Equals(input.ApiKeyId))
                ) && 
                (
                    this.ApiKeyName == input.ApiKeyName ||
                    (this.ApiKeyName != null &&
                    this.ApiKeyName.Equals(input.ApiKeyName))
                ) && 
                (
                    this.AuthToken == input.AuthToken ||
                    (this.AuthToken != null &&
                    this.AuthToken.Equals(input.AuthToken))
                ) && 
                (
                    this.EspTwilioUuid == input.EspTwilioUuid ||
                    (this.EspTwilioUuid != null &&
                    this.EspTwilioUuid.Equals(input.EspTwilioUuid))
                ) && 
                (
                    this.InboundTwimlAppSid == input.InboundTwimlAppSid ||
                    (this.InboundTwimlAppSid != null &&
                    this.InboundTwimlAppSid.Equals(input.InboundTwimlAppSid))
                ) && 
                (
                    this.OutboundTwimlAppSid == input.OutboundTwimlAppSid ||
                    (this.OutboundTwimlAppSid != null &&
                    this.OutboundTwimlAppSid.Equals(input.OutboundTwimlAppSid))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.TwilioWorkspaceSid == input.TwilioWorkspaceSid ||
                    (this.TwilioWorkspaceSid != null &&
                    this.TwilioWorkspaceSid.Equals(input.TwilioWorkspaceSid))
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
                if (this.AccountSid != null)
                    hashCode = hashCode * 59 + this.AccountSid.GetHashCode();
                if (this.ApiKeyId != null)
                    hashCode = hashCode * 59 + this.ApiKeyId.GetHashCode();
                if (this.ApiKeyName != null)
                    hashCode = hashCode * 59 + this.ApiKeyName.GetHashCode();
                if (this.AuthToken != null)
                    hashCode = hashCode * 59 + this.AuthToken.GetHashCode();
                if (this.EspTwilioUuid != null)
                    hashCode = hashCode * 59 + this.EspTwilioUuid.GetHashCode();
                if (this.InboundTwimlAppSid != null)
                    hashCode = hashCode * 59 + this.InboundTwimlAppSid.GetHashCode();
                if (this.OutboundTwimlAppSid != null)
                    hashCode = hashCode * 59 + this.OutboundTwimlAppSid.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.TwilioWorkspaceSid != null)
                    hashCode = hashCode * 59 + this.TwilioWorkspaceSid.GetHashCode();
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

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
    /// ItemInstantPaymentNotification
    /// </summary>
    [DataContract]
    public partial class ItemInstantPaymentNotification :  IEquatable<ItemInstantPaymentNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemInstantPaymentNotification" /> class.
        /// </summary>
        /// <param name="postOperation">True for HTTP POST instead of GET.</param>
        /// <param name="successfulResponseText">Successful response text.</param>
        /// <param name="url">URL.</param>
        public ItemInstantPaymentNotification(bool postOperation = default(bool), string successfulResponseText = default(string), string url = default(string))
        {
            this.PostOperation = postOperation;
            this.SuccessfulResponseText = successfulResponseText;
            this.Url = url;
        }

        /// <summary>
        /// True for HTTP POST instead of GET
        /// </summary>
        /// <value>True for HTTP POST instead of GET</value>
        [DataMember(Name="post_operation", EmitDefaultValue=false)]
        public bool PostOperation { get; set; }

        /// <summary>
        /// Successful response text
        /// </summary>
        /// <value>Successful response text</value>
        [DataMember(Name="successful_response_text", EmitDefaultValue=false)]
        public string SuccessfulResponseText { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        /// <value>URL</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemInstantPaymentNotification {\n");
            sb.Append("  PostOperation: ").Append(PostOperation).Append("\n");
            sb.Append("  SuccessfulResponseText: ").Append(SuccessfulResponseText).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ItemInstantPaymentNotification);
        }

        /// <summary>
        /// Returns true if ItemInstantPaymentNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemInstantPaymentNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemInstantPaymentNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostOperation == input.PostOperation ||
                    (this.PostOperation != null &&
                    this.PostOperation.Equals(input.PostOperation))
                ) && 
                (
                    this.SuccessfulResponseText == input.SuccessfulResponseText ||
                    (this.SuccessfulResponseText != null &&
                    this.SuccessfulResponseText.Equals(input.SuccessfulResponseText))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.PostOperation != null)
                    hashCode = hashCode * 59 + this.PostOperation.GetHashCode();
                if (this.SuccessfulResponseText != null)
                    hashCode = hashCode * 59 + this.SuccessfulResponseText.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
            // SuccessfulResponseText (string) maxLength
            if(this.SuccessfulResponseText != null && this.SuccessfulResponseText.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SuccessfulResponseText, length must be less than 1024.", new [] { "SuccessfulResponseText" });
            }


            // Url (string) maxLength
            if(this.Url != null && this.Url.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 1024.", new [] { "Url" });
            }


            yield break;
        }
    }

}

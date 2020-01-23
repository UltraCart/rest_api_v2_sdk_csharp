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
    /// CartMarketing
    /// </summary>
    [DataContract]
    public partial class CartMarketing :  IEquatable<CartMarketing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartMarketing" /> class.
        /// </summary>
        /// <param name="AdvertisingSource">The advertising source the customer indicated.</param>
        /// <param name="MailingListOptIn">True if the customer agrees to receiving marketing emails.</param>
        public CartMarketing(string AdvertisingSource = default(string), bool? MailingListOptIn = default(bool?))
        {
            this.AdvertisingSource = AdvertisingSource;
            this.MailingListOptIn = MailingListOptIn;
        }
        
        /// <summary>
        /// The advertising source the customer indicated
        /// </summary>
        /// <value>The advertising source the customer indicated</value>
        [DataMember(Name="advertising_source", EmitDefaultValue=false)]
        public string AdvertisingSource { get; set; }

        /// <summary>
        /// True if the customer agrees to receiving marketing emails
        /// </summary>
        /// <value>True if the customer agrees to receiving marketing emails</value>
        [DataMember(Name="mailing_list_opt_in", EmitDefaultValue=false)]
        public bool? MailingListOptIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartMarketing {\n");
            sb.Append("  AdvertisingSource: ").Append(AdvertisingSource).Append("\n");
            sb.Append("  MailingListOptIn: ").Append(MailingListOptIn).Append("\n");
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
            return this.Equals(input as CartMarketing);
        }

        /// <summary>
        /// Returns true if CartMarketing instances are equal
        /// </summary>
        /// <param name="input">Instance of CartMarketing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartMarketing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdvertisingSource == input.AdvertisingSource ||
                    (this.AdvertisingSource != null &&
                    this.AdvertisingSource.Equals(input.AdvertisingSource))
                ) && 
                (
                    this.MailingListOptIn == input.MailingListOptIn ||
                    (this.MailingListOptIn != null &&
                    this.MailingListOptIn.Equals(input.MailingListOptIn))
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
                if (this.AdvertisingSource != null)
                    hashCode = hashCode * 59 + this.AdvertisingSource.GetHashCode();
                if (this.MailingListOptIn != null)
                    hashCode = hashCode * 59 + this.MailingListOptIn.GetHashCode();
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

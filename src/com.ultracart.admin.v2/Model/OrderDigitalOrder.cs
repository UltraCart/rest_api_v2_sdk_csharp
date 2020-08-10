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
    /// OrderDigitalOrder
    /// </summary>
    [DataContract]
    public partial class OrderDigitalOrder :  IEquatable<OrderDigitalOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDigitalOrder" /> class.
        /// </summary>
        /// <param name="creationDts">Date/time that the digital order was created.</param>
        /// <param name="expirationDts">Expiration date/time of the digital order.</param>
        /// <param name="items">Digital items associated with the digital order.</param>
        /// <param name="url">URL where the customer can go to and download their digital order content.</param>
        /// <param name="urlId">URL ID is a unique code that is part of the URLs.</param>
        public OrderDigitalOrder(string creationDts = default(string), string expirationDts = default(string), List<OrderDigitalItem> items = default(List<OrderDigitalItem>), string url = default(string), string urlId = default(string))
        {
            this.CreationDts = creationDts;
            this.ExpirationDts = expirationDts;
            this.Items = items;
            this.Url = url;
            this.UrlId = urlId;
        }
        
        /// <summary>
        /// Date/time that the digital order was created
        /// </summary>
        /// <value>Date/time that the digital order was created</value>
        [DataMember(Name="creation_dts", EmitDefaultValue=false)]
        public string CreationDts { get; set; }

        /// <summary>
        /// Expiration date/time of the digital order
        /// </summary>
        /// <value>Expiration date/time of the digital order</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// Digital items associated with the digital order
        /// </summary>
        /// <value>Digital items associated with the digital order</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<OrderDigitalItem> Items { get; set; }

        /// <summary>
        /// URL where the customer can go to and download their digital order content
        /// </summary>
        /// <value>URL where the customer can go to and download their digital order content</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// URL ID is a unique code that is part of the URLs
        /// </summary>
        /// <value>URL ID is a unique code that is part of the URLs</value>
        [DataMember(Name="url_id", EmitDefaultValue=false)]
        public string UrlId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderDigitalOrder {\n");
            sb.Append("  CreationDts: ").Append(CreationDts).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UrlId: ").Append(UrlId).Append("\n");
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
            return this.Equals(input as OrderDigitalOrder);
        }

        /// <summary>
        /// Returns true if OrderDigitalOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDigitalOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDigitalOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreationDts == input.CreationDts ||
                    (this.CreationDts != null &&
                    this.CreationDts.Equals(input.CreationDts))
                ) && 
                (
                    this.ExpirationDts == input.ExpirationDts ||
                    (this.ExpirationDts != null &&
                    this.ExpirationDts.Equals(input.ExpirationDts))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UrlId == input.UrlId ||
                    (this.UrlId != null &&
                    this.UrlId.Equals(input.UrlId))
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
                if (this.CreationDts != null)
                    hashCode = hashCode * 59 + this.CreationDts.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.UrlId != null)
                    hashCode = hashCode * 59 + this.UrlId.GetHashCode();
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

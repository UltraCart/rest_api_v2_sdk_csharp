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
    /// CouponCodesRequest
    /// </summary>
    [DataContract]
    public partial class CouponCodesRequest :  IEquatable<CouponCodesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCodesRequest" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="expirationDts">Expiration Date.</param>
        /// <param name="expirationSeconds">Expiration seconds.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public CouponCodesRequest(Error error = default(Error), string expirationDts = default(string), int expirationSeconds = default(int), ResponseMetadata metadata = default(ResponseMetadata), int quantity = default(int), bool success = default(bool), Warning warning = default(Warning))
        {
            this.Error = error;
            this.ExpirationDts = expirationDts;
            this.ExpirationSeconds = expirationSeconds;
            this.Metadata = metadata;
            this.Quantity = quantity;
            this.Success = success;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        /// <value>Expiration Date</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// Expiration seconds
        /// </summary>
        /// <value>Expiration seconds</value>
        [DataMember(Name="expiration_seconds", EmitDefaultValue=false)]
        public int ExpirationSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public Warning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponCodesRequest {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  ExpirationSeconds: ").Append(ExpirationSeconds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as CouponCodesRequest);
        }

        /// <summary>
        /// Returns true if CouponCodesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponCodesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponCodesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ExpirationDts == input.ExpirationDts ||
                    (this.ExpirationDts != null &&
                    this.ExpirationDts.Equals(input.ExpirationDts))
                ) && 
                (
                    this.ExpirationSeconds == input.ExpirationSeconds ||
                    (this.ExpirationSeconds != null &&
                    this.ExpirationSeconds.Equals(input.ExpirationSeconds))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.ExpirationSeconds != null)
                    hashCode = hashCode * 59 + this.ExpirationSeconds.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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

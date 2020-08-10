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
    /// CouponCodesResponse
    /// </summary>
    [DataContract]
    public partial class CouponCodesResponse :  IEquatable<CouponCodesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCodesResponse" /> class.
        /// </summary>
        /// <param name="couponCodes">Coupon codes.</param>
        /// <param name="error">error.</param>
        /// <param name="expirationDts">Expiration date.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        public CouponCodesResponse(List<string> couponCodes = default(List<string>), Error error = default(Error), string expirationDts = default(string), ResponseMetadata metadata = default(ResponseMetadata), bool? success = default(bool?))
        {
            this.CouponCodes = couponCodes;
            this.Error = error;
            this.ExpirationDts = expirationDts;
            this.Metadata = metadata;
            this.Success = success;
        }
        
        /// <summary>
        /// Coupon codes
        /// </summary>
        /// <value>Coupon codes</value>
        [DataMember(Name="coupon_codes", EmitDefaultValue=false)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        /// <value>Expiration date</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponCodesResponse {\n");
            sb.Append("  CouponCodes: ").Append(CouponCodes).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as CouponCodesResponse);
        }

        /// <summary>
        /// Returns true if CouponCodesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponCodesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponCodesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CouponCodes == input.CouponCodes ||
                    this.CouponCodes != null &&
                    this.CouponCodes.SequenceEqual(input.CouponCodes)
                ) && 
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
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.CouponCodes != null)
                    hashCode = hashCode * 59 + this.CouponCodes.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
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

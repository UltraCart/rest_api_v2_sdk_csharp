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
    /// CouponResponse
    /// </summary>
    [DataContract]
    public partial class CouponResponse :  IEquatable<CouponResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponResponse" /> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        /// <param name="error">error.</param>
        /// <param name="itemsInvalidForCoupons">Items invalid for coupons.  These will display as warnings within the UI..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public CouponResponse(Coupon coupon = default(Coupon), Error error = default(Error), List<string> itemsInvalidForCoupons = default(List<string>), ResponseMetadata metadata = default(ResponseMetadata), bool success = default(bool), Warning warning = default(Warning))
        {
            this.Coupon = coupon;
            this.Error = error;
            this.ItemsInvalidForCoupons = itemsInvalidForCoupons;
            this.Metadata = metadata;
            this.Success = success;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets Coupon
        /// </summary>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public Coupon Coupon { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Items invalid for coupons.  These will display as warnings within the UI.
        /// </summary>
        /// <value>Items invalid for coupons.  These will display as warnings within the UI.</value>
        [DataMember(Name="items_invalid_for_coupons", EmitDefaultValue=false)]
        public List<string> ItemsInvalidForCoupons { get; set; }

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
            sb.Append("class CouponResponse {\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ItemsInvalidForCoupons: ").Append(ItemsInvalidForCoupons).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as CouponResponse);
        }

        /// <summary>
        /// Returns true if CouponResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ItemsInvalidForCoupons == input.ItemsInvalidForCoupons ||
                    this.ItemsInvalidForCoupons != null &&
                    input.ItemsInvalidForCoupons != null &&
                    this.ItemsInvalidForCoupons.SequenceEqual(input.ItemsInvalidForCoupons)
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
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ItemsInvalidForCoupons != null)
                    hashCode = hashCode * 59 + this.ItemsInvalidForCoupons.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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

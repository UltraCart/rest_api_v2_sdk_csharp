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
    /// ItemAmember
    /// </summary>
    [DataContract]
    public partial class ItemAmember :  IEquatable<ItemAmember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAmember" /> class.
        /// </summary>
        /// <param name="amemberPaymentDurationDays">The number of days that the customer should be given access to the item.</param>
        /// <param name="amemberProductId">A-member product id give customer access to when they purchase this item.</param>
        public ItemAmember(int amemberPaymentDurationDays = default(int), string amemberProductId = default(string))
        {
            this.AmemberPaymentDurationDays = amemberPaymentDurationDays;
            this.AmemberProductId = amemberProductId;
        }

        /// <summary>
        /// The number of days that the customer should be given access to the item
        /// </summary>
        /// <value>The number of days that the customer should be given access to the item</value>
        [DataMember(Name="amember_payment_duration_days", EmitDefaultValue=false)]
        public int AmemberPaymentDurationDays { get; set; }

        /// <summary>
        /// A-member product id give customer access to when they purchase this item
        /// </summary>
        /// <value>A-member product id give customer access to when they purchase this item</value>
        [DataMember(Name="amember_product_id", EmitDefaultValue=false)]
        public string AmemberProductId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemAmember {\n");
            sb.Append("  AmemberPaymentDurationDays: ").Append(AmemberPaymentDurationDays).Append("\n");
            sb.Append("  AmemberProductId: ").Append(AmemberProductId).Append("\n");
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
            return this.Equals(input as ItemAmember);
        }

        /// <summary>
        /// Returns true if ItemAmember instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemAmember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemAmember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmemberPaymentDurationDays == input.AmemberPaymentDurationDays ||
                    (this.AmemberPaymentDurationDays != null &&
                    this.AmemberPaymentDurationDays.Equals(input.AmemberPaymentDurationDays))
                ) && 
                (
                    this.AmemberProductId == input.AmemberProductId ||
                    (this.AmemberProductId != null &&
                    this.AmemberProductId.Equals(input.AmemberProductId))
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
                if (this.AmemberPaymentDurationDays != null)
                    hashCode = hashCode * 59 + this.AmemberPaymentDurationDays.GetHashCode();
                if (this.AmemberProductId != null)
                    hashCode = hashCode * 59 + this.AmemberProductId.GetHashCode();
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
            // AmemberProductId (string) maxLength
            if(this.AmemberProductId != null && this.AmemberProductId.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmemberProductId, length must be less than 10.", new [] { "AmemberProductId" });
            }


            yield break;
        }
    }

}

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
    /// ItemEmailNotifications
    /// </summary>
    [DataContract]
    public partial class ItemEmailNotifications :  IEquatable<ItemEmailNotifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemEmailNotifications" /> class.
        /// </summary>
        /// <param name="skipReceipt">Skip receipt email to customer.</param>
        /// <param name="skipShipmentNotification">Skip shipment notification to customer.</param>
        public ItemEmailNotifications(bool? skipReceipt = default(bool?), bool? skipShipmentNotification = default(bool?))
        {
            this.SkipReceipt = skipReceipt;
            this.SkipShipmentNotification = skipShipmentNotification;
        }
        
        /// <summary>
        /// Skip receipt email to customer
        /// </summary>
        /// <value>Skip receipt email to customer</value>
        [DataMember(Name="skip_receipt", EmitDefaultValue=false)]
        public bool? SkipReceipt { get; set; }

        /// <summary>
        /// Skip shipment notification to customer
        /// </summary>
        /// <value>Skip shipment notification to customer</value>
        [DataMember(Name="skip_shipment_notification", EmitDefaultValue=false)]
        public bool? SkipShipmentNotification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemEmailNotifications {\n");
            sb.Append("  SkipReceipt: ").Append(SkipReceipt).Append("\n");
            sb.Append("  SkipShipmentNotification: ").Append(SkipShipmentNotification).Append("\n");
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
            return this.Equals(input as ItemEmailNotifications);
        }

        /// <summary>
        /// Returns true if ItemEmailNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemEmailNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemEmailNotifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SkipReceipt == input.SkipReceipt ||
                    (this.SkipReceipt != null &&
                    this.SkipReceipt.Equals(input.SkipReceipt))
                ) && 
                (
                    this.SkipShipmentNotification == input.SkipShipmentNotification ||
                    (this.SkipShipmentNotification != null &&
                    this.SkipShipmentNotification.Equals(input.SkipShipmentNotification))
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
                if (this.SkipReceipt != null)
                    hashCode = hashCode * 59 + this.SkipReceipt.GetHashCode();
                if (this.SkipShipmentNotification != null)
                    hashCode = hashCode * 59 + this.SkipShipmentNotification.GetHashCode();
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

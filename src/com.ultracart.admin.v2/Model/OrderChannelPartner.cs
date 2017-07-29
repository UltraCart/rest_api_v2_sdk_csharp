/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
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
    /// OrderChannelPartner
    /// </summary>
    [DataContract]
    public partial class OrderChannelPartner :  IEquatable<OrderChannelPartner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderChannelPartner" /> class.
        /// </summary>
        /// <param name="ChannelPartnerCode">The code of the channel partner.</param>
        /// <param name="ChannelPartnerData">Additional data provided by the channel partner.</param>
        /// <param name="ChannelPartnerOid">Channel partner object identifier.</param>
        /// <param name="ChannelPartnerOrderId">The order ID assigned by the channel partner for this order.</param>
        public OrderChannelPartner(string ChannelPartnerCode = default(string), string ChannelPartnerData = default(string), int? ChannelPartnerOid = default(int?), string ChannelPartnerOrderId = default(string))
        {
            this.ChannelPartnerCode = ChannelPartnerCode;
            this.ChannelPartnerData = ChannelPartnerData;
            this.ChannelPartnerOid = ChannelPartnerOid;
            this.ChannelPartnerOrderId = ChannelPartnerOrderId;
        }
        
        /// <summary>
        /// The code of the channel partner
        /// </summary>
        /// <value>The code of the channel partner</value>
        [DataMember(Name="channel_partner_code", EmitDefaultValue=false)]
        public string ChannelPartnerCode { get; set; }

        /// <summary>
        /// Additional data provided by the channel partner
        /// </summary>
        /// <value>Additional data provided by the channel partner</value>
        [DataMember(Name="channel_partner_data", EmitDefaultValue=false)]
        public string ChannelPartnerData { get; set; }

        /// <summary>
        /// Channel partner object identifier
        /// </summary>
        /// <value>Channel partner object identifier</value>
        [DataMember(Name="channel_partner_oid", EmitDefaultValue=false)]
        public int? ChannelPartnerOid { get; set; }

        /// <summary>
        /// The order ID assigned by the channel partner for this order
        /// </summary>
        /// <value>The order ID assigned by the channel partner for this order</value>
        [DataMember(Name="channel_partner_order_id", EmitDefaultValue=false)]
        public string ChannelPartnerOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderChannelPartner {\n");
            sb.Append("  ChannelPartnerCode: ").Append(ChannelPartnerCode).Append("\n");
            sb.Append("  ChannelPartnerData: ").Append(ChannelPartnerData).Append("\n");
            sb.Append("  ChannelPartnerOid: ").Append(ChannelPartnerOid).Append("\n");
            sb.Append("  ChannelPartnerOrderId: ").Append(ChannelPartnerOrderId).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderChannelPartner);
        }

        /// <summary>
        /// Returns true if OrderChannelPartner instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderChannelPartner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderChannelPartner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelPartnerCode == other.ChannelPartnerCode ||
                    this.ChannelPartnerCode != null &&
                    this.ChannelPartnerCode.Equals(other.ChannelPartnerCode)
                ) && 
                (
                    this.ChannelPartnerData == other.ChannelPartnerData ||
                    this.ChannelPartnerData != null &&
                    this.ChannelPartnerData.Equals(other.ChannelPartnerData)
                ) && 
                (
                    this.ChannelPartnerOid == other.ChannelPartnerOid ||
                    this.ChannelPartnerOid != null &&
                    this.ChannelPartnerOid.Equals(other.ChannelPartnerOid)
                ) && 
                (
                    this.ChannelPartnerOrderId == other.ChannelPartnerOrderId ||
                    this.ChannelPartnerOrderId != null &&
                    this.ChannelPartnerOrderId.Equals(other.ChannelPartnerOrderId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ChannelPartnerCode != null)
                    hash = hash * 59 + this.ChannelPartnerCode.GetHashCode();
                if (this.ChannelPartnerData != null)
                    hash = hash * 59 + this.ChannelPartnerData.GetHashCode();
                if (this.ChannelPartnerOid != null)
                    hash = hash * 59 + this.ChannelPartnerOid.GetHashCode();
                if (this.ChannelPartnerOrderId != null)
                    hash = hash * 59 + this.ChannelPartnerOrderId.GetHashCode();
                return hash;
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

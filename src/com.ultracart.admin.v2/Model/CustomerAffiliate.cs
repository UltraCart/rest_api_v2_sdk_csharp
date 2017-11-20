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
    /// CustomerAffiliate
    /// </summary>
    [DataContract]
    public partial class CustomerAffiliate :  IEquatable<CustomerAffiliate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAffiliate" /> class.
        /// </summary>
        /// <param name="AffiliateOid">Affiliate object identifier.</param>
        /// <param name="Email">email.</param>
        public CustomerAffiliate(int? AffiliateOid = default(int?), string Email = default(string))
        {
            this.AffiliateOid = AffiliateOid;
            this.Email = Email;
        }
        
        /// <summary>
        /// Affiliate object identifier
        /// </summary>
        /// <value>Affiliate object identifier</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int? AffiliateOid { get; set; }

        /// <summary>
        /// email
        /// </summary>
        /// <value>email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerAffiliate {\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as CustomerAffiliate);
        }

        /// <summary>
        /// Returns true if CustomerAffiliate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAffiliate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAffiliate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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

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
    /// CustomerMergeRequest
    /// </summary>
    [DataContract]
    public partial class CustomerMergeRequest :  IEquatable<CustomerMergeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMergeRequest" /> class.
        /// </summary>
        /// <param name="customerProfileOid">Customer profile oid to merge.</param>
        /// <param name="email">Email of the customer profile to merge.</param>
        public CustomerMergeRequest(int customerProfileOid = default(int), string email = default(string))
        {
            this.CustomerProfileOid = customerProfileOid;
            this.Email = email;
        }

        /// <summary>
        /// Customer profile oid to merge
        /// </summary>
        /// <value>Customer profile oid to merge</value>
        [DataMember(Name="customer_profile_oid", EmitDefaultValue=false)]
        public int CustomerProfileOid { get; set; }

        /// <summary>
        /// Email of the customer profile to merge
        /// </summary>
        /// <value>Email of the customer profile to merge</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerMergeRequest {\n");
            sb.Append("  CustomerProfileOid: ").Append(CustomerProfileOid).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as CustomerMergeRequest);
        }

        /// <summary>
        /// Returns true if CustomerMergeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerMergeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerMergeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfileOid == input.CustomerProfileOid ||
                    (this.CustomerProfileOid != null &&
                    this.CustomerProfileOid.Equals(input.CustomerProfileOid))
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
                if (this.CustomerProfileOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfileOid.GetHashCode();
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

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
    /// CustomerProperty
    /// </summary>
    [DataContract]
    public partial class CustomerProperty :  IEquatable<CustomerProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProperty" /> class.
        /// </summary>
        /// <param name="customerProfilePropertyOid">Customer profile property oid.</param>
        /// <param name="expirationDts">The date/time that the property expires and is deleted.</param>
        /// <param name="name">Name.</param>
        /// <param name="value">Value.</param>
        public CustomerProperty(int customerProfilePropertyOid = default(int), string expirationDts = default(string), string name = default(string), string value = default(string))
        {
            this.CustomerProfilePropertyOid = customerProfilePropertyOid;
            this.ExpirationDts = expirationDts;
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Customer profile property oid
        /// </summary>
        /// <value>Customer profile property oid</value>
        [DataMember(Name="customer_profile_property_oid", EmitDefaultValue=false)]
        public int CustomerProfilePropertyOid { get; set; }

        /// <summary>
        /// The date/time that the property expires and is deleted
        /// </summary>
        /// <value>The date/time that the property expires and is deleted</value>
        [DataMember(Name="expiration_dts", EmitDefaultValue=false)]
        public string ExpirationDts { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerProperty {\n");
            sb.Append("  CustomerProfilePropertyOid: ").Append(CustomerProfilePropertyOid).Append("\n");
            sb.Append("  ExpirationDts: ").Append(ExpirationDts).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CustomerProperty);
        }

        /// <summary>
        /// Returns true if CustomerProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfilePropertyOid == input.CustomerProfilePropertyOid ||
                    (this.CustomerProfilePropertyOid != null &&
                    this.CustomerProfilePropertyOid.Equals(input.CustomerProfilePropertyOid))
                ) && 
                (
                    this.ExpirationDts == input.ExpirationDts ||
                    (this.ExpirationDts != null &&
                    this.ExpirationDts.Equals(input.ExpirationDts))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.CustomerProfilePropertyOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfilePropertyOid.GetHashCode();
                if (this.ExpirationDts != null)
                    hashCode = hashCode * 59 + this.ExpirationDts.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }


            // Value (string) maxLength
            if(this.Value != null && this.Value.Length > 1500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 1500.", new [] { "Value" });
            }


            yield break;
        }
    }

}
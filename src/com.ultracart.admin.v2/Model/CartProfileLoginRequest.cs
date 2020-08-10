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
    /// CartProfileLoginRequest
    /// </summary>
    [DataContract]
    public partial class CartProfileLoginRequest :  IEquatable<CartProfileLoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartProfileLoginRequest" /> class.
        /// </summary>
        /// <param name="cart">cart.</param>
        /// <param name="customerProfileOid">Unique identifier for customer profile.  Can not be used with browser key authentication type..</param>
        /// <param name="password">Password for the profile.</param>
        public CartProfileLoginRequest(Cart cart = default(Cart), int? customerProfileOid = default(int?), string password = default(string))
        {
            this.Cart = cart;
            this.CustomerProfileOid = customerProfileOid;
            this.Password = password;
        }
        
        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name="cart", EmitDefaultValue=false)]
        public Cart Cart { get; set; }

        /// <summary>
        /// Unique identifier for customer profile.  Can not be used with browser key authentication type.
        /// </summary>
        /// <value>Unique identifier for customer profile.  Can not be used with browser key authentication type.</value>
        [DataMember(Name="customer_profile_oid", EmitDefaultValue=false)]
        public int? CustomerProfileOid { get; set; }

        /// <summary>
        /// Password for the profile
        /// </summary>
        /// <value>Password for the profile</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartProfileLoginRequest {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  CustomerProfileOid: ").Append(CustomerProfileOid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as CartProfileLoginRequest);
        }

        /// <summary>
        /// Returns true if CartProfileLoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CartProfileLoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartProfileLoginRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cart == input.Cart ||
                    (this.Cart != null &&
                    this.Cart.Equals(input.Cart))
                ) && 
                (
                    this.CustomerProfileOid == input.CustomerProfileOid ||
                    (this.CustomerProfileOid != null &&
                    this.CustomerProfileOid.Equals(input.CustomerProfileOid))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Cart != null)
                    hashCode = hashCode * 59 + this.Cart.GetHashCode();
                if (this.CustomerProfileOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfileOid.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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

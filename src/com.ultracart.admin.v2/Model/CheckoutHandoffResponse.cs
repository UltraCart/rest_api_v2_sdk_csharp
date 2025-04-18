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
    /// CheckoutHandoffResponse
    /// </summary>
    [DataContract]
    public partial class CheckoutHandoffResponse :  IEquatable<CheckoutHandoffResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutHandoffResponse" /> class.
        /// </summary>
        /// <param name="cart">cart.</param>
        /// <param name="errors">Errors that occurred which are preventing the handoff operation.  Display these to the customer..</param>
        /// <param name="redirectToUrl">The URL that you should redirect the customers browser to.</param>
        public CheckoutHandoffResponse(Cart cart = default(Cart), List<string> errors = default(List<string>), string redirectToUrl = default(string))
        {
            this.Cart = cart;
            this.Errors = errors;
            this.RedirectToUrl = redirectToUrl;
        }

        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name="cart", EmitDefaultValue=false)]
        public Cart Cart { get; set; }

        /// <summary>
        /// Errors that occurred which are preventing the handoff operation.  Display these to the customer.
        /// </summary>
        /// <value>Errors that occurred which are preventing the handoff operation.  Display these to the customer.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// The URL that you should redirect the customers browser to
        /// </summary>
        /// <value>The URL that you should redirect the customers browser to</value>
        [DataMember(Name="redirect_to_url", EmitDefaultValue=false)]
        public string RedirectToUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutHandoffResponse {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  RedirectToUrl: ").Append(RedirectToUrl).Append("\n");
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
            return this.Equals(input as CheckoutHandoffResponse);
        }

        /// <summary>
        /// Returns true if CheckoutHandoffResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutHandoffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutHandoffResponse input)
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
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.RedirectToUrl == input.RedirectToUrl ||
                    (this.RedirectToUrl != null &&
                    this.RedirectToUrl.Equals(input.RedirectToUrl))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.RedirectToUrl != null)
                    hashCode = hashCode * 59 + this.RedirectToUrl.GetHashCode();
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

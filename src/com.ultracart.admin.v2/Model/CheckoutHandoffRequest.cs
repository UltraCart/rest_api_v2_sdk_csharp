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
    /// CheckoutHandoffRequest
    /// </summary>
    [DataContract]
    public partial class CheckoutHandoffRequest :  IEquatable<CheckoutHandoffRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of handoff operation to perform
        /// </summary>
        /// <value>The type of handoff operation to perform</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationEnum
        {
            
            /// <summary>
            /// Enum Checkout for "checkout"
            /// </summary>
            [EnumMember(Value = "checkout")]
            Checkout,
            
            /// <summary>
            /// Enum PayPal for "payPal"
            /// </summary>
            [EnumMember(Value = "payPal")]
            PayPal,
            
            /// <summary>
            /// Enum PayPalCredit for "payPalCredit"
            /// </summary>
            [EnumMember(Value = "payPalCredit")]
            PayPalCredit,
            
            /// <summary>
            /// Enum View for "view"
            /// </summary>
            [EnumMember(Value = "view")]
            View,
            
            /// <summary>
            /// Enum Affirm for "affirm"
            /// </summary>
            [EnumMember(Value = "affirm")]
            Affirm
        }

        /// <summary>
        /// The type of handoff operation to perform
        /// </summary>
        /// <value>The type of handoff operation to perform</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public OperationEnum? Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutHandoffRequest" /> class.
        /// </summary>
        /// <param name="Cart">Cart.</param>
        /// <param name="ErrorParameterName">If any error happen during the processing on the UltraCart side, the browser will be redirected to your error_return_url with the error passed in this parameter name..</param>
        /// <param name="ErrorReturnUrl">The URL to return the browser to if there are processing errors on the UltraCart side..</param>
        /// <param name="Operation">The type of handoff operation to perform.</param>
        /// <param name="PaypalMaximumUpsellRevenue">The maximum amount of revenue that you think the customer could add during a custom upsell after sequence on your checkout..</param>
        /// <param name="PaypalReturnUrl">The URl to return the customers browser to after they have completed the PayPal process..</param>
        /// <param name="SecureHostName">The desired secure host name to perform the handoff on.  This should match the desired StoreFront..</param>
        public CheckoutHandoffRequest(Cart Cart = default(Cart), string ErrorParameterName = default(string), string ErrorReturnUrl = default(string), OperationEnum? Operation = default(OperationEnum?), decimal? PaypalMaximumUpsellRevenue = default(decimal?), string PaypalReturnUrl = default(string), string SecureHostName = default(string))
        {
            this.Cart = Cart;
            this.ErrorParameterName = ErrorParameterName;
            this.ErrorReturnUrl = ErrorReturnUrl;
            this.Operation = Operation;
            this.PaypalMaximumUpsellRevenue = PaypalMaximumUpsellRevenue;
            this.PaypalReturnUrl = PaypalReturnUrl;
            this.SecureHostName = SecureHostName;
        }
        
        /// <summary>
        /// Gets or Sets Cart
        /// </summary>
        [DataMember(Name="cart", EmitDefaultValue=false)]
        public Cart Cart { get; set; }

        /// <summary>
        /// If any error happen during the processing on the UltraCart side, the browser will be redirected to your error_return_url with the error passed in this parameter name.
        /// </summary>
        /// <value>If any error happen during the processing on the UltraCart side, the browser will be redirected to your error_return_url with the error passed in this parameter name.</value>
        [DataMember(Name="error_parameter_name", EmitDefaultValue=false)]
        public string ErrorParameterName { get; set; }

        /// <summary>
        /// The URL to return the browser to if there are processing errors on the UltraCart side.
        /// </summary>
        /// <value>The URL to return the browser to if there are processing errors on the UltraCart side.</value>
        [DataMember(Name="error_return_url", EmitDefaultValue=false)]
        public string ErrorReturnUrl { get; set; }


        /// <summary>
        /// The maximum amount of revenue that you think the customer could add during a custom upsell after sequence on your checkout.
        /// </summary>
        /// <value>The maximum amount of revenue that you think the customer could add during a custom upsell after sequence on your checkout.</value>
        [DataMember(Name="paypal_maximum_upsell_revenue", EmitDefaultValue=false)]
        public decimal? PaypalMaximumUpsellRevenue { get; set; }

        /// <summary>
        /// The URl to return the customers browser to after they have completed the PayPal process.
        /// </summary>
        /// <value>The URl to return the customers browser to after they have completed the PayPal process.</value>
        [DataMember(Name="paypal_return_url", EmitDefaultValue=false)]
        public string PaypalReturnUrl { get; set; }

        /// <summary>
        /// The desired secure host name to perform the handoff on.  This should match the desired StoreFront.
        /// </summary>
        /// <value>The desired secure host name to perform the handoff on.  This should match the desired StoreFront.</value>
        [DataMember(Name="secure_host_name", EmitDefaultValue=false)]
        public string SecureHostName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutHandoffRequest {\n");
            sb.Append("  Cart: ").Append(Cart).Append("\n");
            sb.Append("  ErrorParameterName: ").Append(ErrorParameterName).Append("\n");
            sb.Append("  ErrorReturnUrl: ").Append(ErrorReturnUrl).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  PaypalMaximumUpsellRevenue: ").Append(PaypalMaximumUpsellRevenue).Append("\n");
            sb.Append("  PaypalReturnUrl: ").Append(PaypalReturnUrl).Append("\n");
            sb.Append("  SecureHostName: ").Append(SecureHostName).Append("\n");
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
            return this.Equals(input as CheckoutHandoffRequest);
        }

        /// <summary>
        /// Returns true if CheckoutHandoffRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutHandoffRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutHandoffRequest input)
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
                    this.ErrorParameterName == input.ErrorParameterName ||
                    (this.ErrorParameterName != null &&
                    this.ErrorParameterName.Equals(input.ErrorParameterName))
                ) && 
                (
                    this.ErrorReturnUrl == input.ErrorReturnUrl ||
                    (this.ErrorReturnUrl != null &&
                    this.ErrorReturnUrl.Equals(input.ErrorReturnUrl))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.PaypalMaximumUpsellRevenue == input.PaypalMaximumUpsellRevenue ||
                    (this.PaypalMaximumUpsellRevenue != null &&
                    this.PaypalMaximumUpsellRevenue.Equals(input.PaypalMaximumUpsellRevenue))
                ) && 
                (
                    this.PaypalReturnUrl == input.PaypalReturnUrl ||
                    (this.PaypalReturnUrl != null &&
                    this.PaypalReturnUrl.Equals(input.PaypalReturnUrl))
                ) && 
                (
                    this.SecureHostName == input.SecureHostName ||
                    (this.SecureHostName != null &&
                    this.SecureHostName.Equals(input.SecureHostName))
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
                if (this.ErrorParameterName != null)
                    hashCode = hashCode * 59 + this.ErrorParameterName.GetHashCode();
                if (this.ErrorReturnUrl != null)
                    hashCode = hashCode * 59 + this.ErrorReturnUrl.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.PaypalMaximumUpsellRevenue != null)
                    hashCode = hashCode * 59 + this.PaypalMaximumUpsellRevenue.GetHashCode();
                if (this.PaypalReturnUrl != null)
                    hashCode = hashCode * 59 + this.PaypalReturnUrl.GetHashCode();
                if (this.SecureHostName != null)
                    hashCode = hashCode * 59 + this.SecureHostName.GetHashCode();
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

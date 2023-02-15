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
    /// OrderCheckout
    /// </summary>
    [DataContract]
    public partial class OrderCheckout :  IEquatable<OrderCheckout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCheckout" /> class.
        /// </summary>
        /// <param name="browser">browser.</param>
        /// <param name="comments">Comments from the customer.  Rarely used on the single page checkout..</param>
        /// <param name="customField1">Custom field 1.</param>
        /// <param name="customField10">Custom field 10.</param>
        /// <param name="customField2">Custom field 2.</param>
        /// <param name="customField3">Custom field 3.</param>
        /// <param name="customField4">Custom field 4.</param>
        /// <param name="customField5">Custom field 5.</param>
        /// <param name="customField6">Custom field 6.</param>
        /// <param name="customField7">Custom field 7.</param>
        /// <param name="customField8">Custom field 8.</param>
        /// <param name="customField9">Custom field 9.</param>
        /// <param name="customerIpAddress">IP address of the customer when placing the order.</param>
        /// <param name="screenBrandingThemeCode">Screen branding theme code associated with the order (legacy checkout).</param>
        /// <param name="screenSize">Screen size small, medium or large.</param>
        /// <param name="storefrontHostName">StoreFront host name associated with the order.</param>
        /// <param name="upsellPathCode">Upsell path code assigned during the checkout that the customer went through.</param>
        public OrderCheckout(Browser browser = default(Browser), string comments = default(string), string customField1 = default(string), string customField10 = default(string), string customField2 = default(string), string customField3 = default(string), string customField4 = default(string), string customField5 = default(string), string customField6 = default(string), string customField7 = default(string), string customField8 = default(string), string customField9 = default(string), string customerIpAddress = default(string), string screenBrandingThemeCode = default(string), string screenSize = default(string), string storefrontHostName = default(string), string upsellPathCode = default(string))
        {
            this.Browser = browser;
            this.Comments = comments;
            this.CustomField1 = customField1;
            this.CustomField10 = customField10;
            this.CustomField2 = customField2;
            this.CustomField3 = customField3;
            this.CustomField4 = customField4;
            this.CustomField5 = customField5;
            this.CustomField6 = customField6;
            this.CustomField7 = customField7;
            this.CustomField8 = customField8;
            this.CustomField9 = customField9;
            this.CustomerIpAddress = customerIpAddress;
            this.ScreenBrandingThemeCode = screenBrandingThemeCode;
            this.ScreenSize = screenSize;
            this.StorefrontHostName = storefrontHostName;
            this.UpsellPathCode = upsellPathCode;
        }
        
        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [DataMember(Name="browser", EmitDefaultValue=false)]
        public Browser Browser { get; set; }

        /// <summary>
        /// Comments from the customer.  Rarely used on the single page checkout.
        /// </summary>
        /// <value>Comments from the customer.  Rarely used on the single page checkout.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Custom field 1
        /// </summary>
        /// <value>Custom field 1</value>
        [DataMember(Name="custom_field1", EmitDefaultValue=false)]
        public string CustomField1 { get; set; }

        /// <summary>
        /// Custom field 10
        /// </summary>
        /// <value>Custom field 10</value>
        [DataMember(Name="custom_field10", EmitDefaultValue=false)]
        public string CustomField10 { get; set; }

        /// <summary>
        /// Custom field 2
        /// </summary>
        /// <value>Custom field 2</value>
        [DataMember(Name="custom_field2", EmitDefaultValue=false)]
        public string CustomField2 { get; set; }

        /// <summary>
        /// Custom field 3
        /// </summary>
        /// <value>Custom field 3</value>
        [DataMember(Name="custom_field3", EmitDefaultValue=false)]
        public string CustomField3 { get; set; }

        /// <summary>
        /// Custom field 4
        /// </summary>
        /// <value>Custom field 4</value>
        [DataMember(Name="custom_field4", EmitDefaultValue=false)]
        public string CustomField4 { get; set; }

        /// <summary>
        /// Custom field 5
        /// </summary>
        /// <value>Custom field 5</value>
        [DataMember(Name="custom_field5", EmitDefaultValue=false)]
        public string CustomField5 { get; set; }

        /// <summary>
        /// Custom field 6
        /// </summary>
        /// <value>Custom field 6</value>
        [DataMember(Name="custom_field6", EmitDefaultValue=false)]
        public string CustomField6 { get; set; }

        /// <summary>
        /// Custom field 7
        /// </summary>
        /// <value>Custom field 7</value>
        [DataMember(Name="custom_field7", EmitDefaultValue=false)]
        public string CustomField7 { get; set; }

        /// <summary>
        /// Custom field 8
        /// </summary>
        /// <value>Custom field 8</value>
        [DataMember(Name="custom_field8", EmitDefaultValue=false)]
        public string CustomField8 { get; set; }

        /// <summary>
        /// Custom field 9
        /// </summary>
        /// <value>Custom field 9</value>
        [DataMember(Name="custom_field9", EmitDefaultValue=false)]
        public string CustomField9 { get; set; }

        /// <summary>
        /// IP address of the customer when placing the order
        /// </summary>
        /// <value>IP address of the customer when placing the order</value>
        [DataMember(Name="customer_ip_address", EmitDefaultValue=false)]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// Screen branding theme code associated with the order (legacy checkout)
        /// </summary>
        /// <value>Screen branding theme code associated with the order (legacy checkout)</value>
        [DataMember(Name="screen_branding_theme_code", EmitDefaultValue=false)]
        public string ScreenBrandingThemeCode { get; set; }

        /// <summary>
        /// Screen size small, medium or large
        /// </summary>
        /// <value>Screen size small, medium or large</value>
        [DataMember(Name="screen_size", EmitDefaultValue=false)]
        public string ScreenSize { get; set; }

        /// <summary>
        /// StoreFront host name associated with the order
        /// </summary>
        /// <value>StoreFront host name associated with the order</value>
        [DataMember(Name="storefront_host_name", EmitDefaultValue=false)]
        public string StorefrontHostName { get; set; }

        /// <summary>
        /// Upsell path code assigned during the checkout that the customer went through
        /// </summary>
        /// <value>Upsell path code assigned during the checkout that the customer went through</value>
        [DataMember(Name="upsell_path_code", EmitDefaultValue=false)]
        public string UpsellPathCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCheckout {\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CustomField1: ").Append(CustomField1).Append("\n");
            sb.Append("  CustomField10: ").Append(CustomField10).Append("\n");
            sb.Append("  CustomField2: ").Append(CustomField2).Append("\n");
            sb.Append("  CustomField3: ").Append(CustomField3).Append("\n");
            sb.Append("  CustomField4: ").Append(CustomField4).Append("\n");
            sb.Append("  CustomField5: ").Append(CustomField5).Append("\n");
            sb.Append("  CustomField6: ").Append(CustomField6).Append("\n");
            sb.Append("  CustomField7: ").Append(CustomField7).Append("\n");
            sb.Append("  CustomField8: ").Append(CustomField8).Append("\n");
            sb.Append("  CustomField9: ").Append(CustomField9).Append("\n");
            sb.Append("  CustomerIpAddress: ").Append(CustomerIpAddress).Append("\n");
            sb.Append("  ScreenBrandingThemeCode: ").Append(ScreenBrandingThemeCode).Append("\n");
            sb.Append("  ScreenSize: ").Append(ScreenSize).Append("\n");
            sb.Append("  StorefrontHostName: ").Append(StorefrontHostName).Append("\n");
            sb.Append("  UpsellPathCode: ").Append(UpsellPathCode).Append("\n");
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
            return this.Equals(input as OrderCheckout);
        }

        /// <summary>
        /// Returns true if OrderCheckout instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCheckout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCheckout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Browser == input.Browser ||
                    (this.Browser != null &&
                    this.Browser.Equals(input.Browser))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CustomField1 == input.CustomField1 ||
                    (this.CustomField1 != null &&
                    this.CustomField1.Equals(input.CustomField1))
                ) && 
                (
                    this.CustomField10 == input.CustomField10 ||
                    (this.CustomField10 != null &&
                    this.CustomField10.Equals(input.CustomField10))
                ) && 
                (
                    this.CustomField2 == input.CustomField2 ||
                    (this.CustomField2 != null &&
                    this.CustomField2.Equals(input.CustomField2))
                ) && 
                (
                    this.CustomField3 == input.CustomField3 ||
                    (this.CustomField3 != null &&
                    this.CustomField3.Equals(input.CustomField3))
                ) && 
                (
                    this.CustomField4 == input.CustomField4 ||
                    (this.CustomField4 != null &&
                    this.CustomField4.Equals(input.CustomField4))
                ) && 
                (
                    this.CustomField5 == input.CustomField5 ||
                    (this.CustomField5 != null &&
                    this.CustomField5.Equals(input.CustomField5))
                ) && 
                (
                    this.CustomField6 == input.CustomField6 ||
                    (this.CustomField6 != null &&
                    this.CustomField6.Equals(input.CustomField6))
                ) && 
                (
                    this.CustomField7 == input.CustomField7 ||
                    (this.CustomField7 != null &&
                    this.CustomField7.Equals(input.CustomField7))
                ) && 
                (
                    this.CustomField8 == input.CustomField8 ||
                    (this.CustomField8 != null &&
                    this.CustomField8.Equals(input.CustomField8))
                ) && 
                (
                    this.CustomField9 == input.CustomField9 ||
                    (this.CustomField9 != null &&
                    this.CustomField9.Equals(input.CustomField9))
                ) && 
                (
                    this.CustomerIpAddress == input.CustomerIpAddress ||
                    (this.CustomerIpAddress != null &&
                    this.CustomerIpAddress.Equals(input.CustomerIpAddress))
                ) && 
                (
                    this.ScreenBrandingThemeCode == input.ScreenBrandingThemeCode ||
                    (this.ScreenBrandingThemeCode != null &&
                    this.ScreenBrandingThemeCode.Equals(input.ScreenBrandingThemeCode))
                ) && 
                (
                    this.ScreenSize == input.ScreenSize ||
                    (this.ScreenSize != null &&
                    this.ScreenSize.Equals(input.ScreenSize))
                ) && 
                (
                    this.StorefrontHostName == input.StorefrontHostName ||
                    (this.StorefrontHostName != null &&
                    this.StorefrontHostName.Equals(input.StorefrontHostName))
                ) && 
                (
                    this.UpsellPathCode == input.UpsellPathCode ||
                    (this.UpsellPathCode != null &&
                    this.UpsellPathCode.Equals(input.UpsellPathCode))
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
                if (this.Browser != null)
                    hashCode = hashCode * 59 + this.Browser.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CustomField1 != null)
                    hashCode = hashCode * 59 + this.CustomField1.GetHashCode();
                if (this.CustomField10 != null)
                    hashCode = hashCode * 59 + this.CustomField10.GetHashCode();
                if (this.CustomField2 != null)
                    hashCode = hashCode * 59 + this.CustomField2.GetHashCode();
                if (this.CustomField3 != null)
                    hashCode = hashCode * 59 + this.CustomField3.GetHashCode();
                if (this.CustomField4 != null)
                    hashCode = hashCode * 59 + this.CustomField4.GetHashCode();
                if (this.CustomField5 != null)
                    hashCode = hashCode * 59 + this.CustomField5.GetHashCode();
                if (this.CustomField6 != null)
                    hashCode = hashCode * 59 + this.CustomField6.GetHashCode();
                if (this.CustomField7 != null)
                    hashCode = hashCode * 59 + this.CustomField7.GetHashCode();
                if (this.CustomField8 != null)
                    hashCode = hashCode * 59 + this.CustomField8.GetHashCode();
                if (this.CustomField9 != null)
                    hashCode = hashCode * 59 + this.CustomField9.GetHashCode();
                if (this.CustomerIpAddress != null)
                    hashCode = hashCode * 59 + this.CustomerIpAddress.GetHashCode();
                if (this.ScreenBrandingThemeCode != null)
                    hashCode = hashCode * 59 + this.ScreenBrandingThemeCode.GetHashCode();
                if (this.ScreenSize != null)
                    hashCode = hashCode * 59 + this.ScreenSize.GetHashCode();
                if (this.StorefrontHostName != null)
                    hashCode = hashCode * 59 + this.StorefrontHostName.GetHashCode();
                if (this.UpsellPathCode != null)
                    hashCode = hashCode * 59 + this.UpsellPathCode.GetHashCode();
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
            // CustomField1 (string) maxLength
            if(this.CustomField1 != null && this.CustomField1.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField1, length must be less than 50.", new [] { "CustomField1" });
            }

            // CustomField10 (string) maxLength
            if(this.CustomField10 != null && this.CustomField10.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField10, length must be less than 200.", new [] { "CustomField10" });
            }

            // CustomField2 (string) maxLength
            if(this.CustomField2 != null && this.CustomField2.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField2, length must be less than 50.", new [] { "CustomField2" });
            }

            // CustomField3 (string) maxLength
            if(this.CustomField3 != null && this.CustomField3.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField3, length must be less than 50.", new [] { "CustomField3" });
            }

            // CustomField4 (string) maxLength
            if(this.CustomField4 != null && this.CustomField4.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField4, length must be less than 50.", new [] { "CustomField4" });
            }

            // CustomField5 (string) maxLength
            if(this.CustomField5 != null && this.CustomField5.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField5, length must be less than 75.", new [] { "CustomField5" });
            }

            // CustomField6 (string) maxLength
            if(this.CustomField6 != null && this.CustomField6.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField6, length must be less than 50.", new [] { "CustomField6" });
            }

            // CustomField7 (string) maxLength
            if(this.CustomField7 != null && this.CustomField7.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField7, length must be less than 50.", new [] { "CustomField7" });
            }

            // CustomField8 (string) maxLength
            if(this.CustomField8 != null && this.CustomField8.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField8, length must be less than 200.", new [] { "CustomField8" });
            }

            // CustomField9 (string) maxLength
            if(this.CustomField9 != null && this.CustomField9.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField9, length must be less than 200.", new [] { "CustomField9" });
            }

            // ScreenBrandingThemeCode (string) maxLength
            if(this.ScreenBrandingThemeCode != null && this.ScreenBrandingThemeCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScreenBrandingThemeCode, length must be less than 10.", new [] { "ScreenBrandingThemeCode" });
            }

            yield break;
        }
    }

}

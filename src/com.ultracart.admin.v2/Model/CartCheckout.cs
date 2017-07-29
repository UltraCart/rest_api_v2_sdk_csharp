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
    /// CartCheckout
    /// </summary>
    [DataContract]
    public partial class CartCheckout :  IEquatable<CartCheckout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCheckout" /> class.
        /// </summary>
        /// <param name="Comments">Comments from the customer.  Rarely used on the single page checkout..</param>
        /// <param name="CustomField1">Custom field 1.</param>
        /// <param name="CustomField2">Custom field 2.</param>
        /// <param name="CustomField3">Custom field 3.</param>
        /// <param name="CustomField4">Custom field 4.</param>
        /// <param name="CustomField5">Custom field 5.</param>
        /// <param name="CustomField6">Custom field 6.</param>
        /// <param name="CustomField7">Custom field 7.</param>
        /// <param name="IpAddress">IP Address.</param>
        /// <param name="ScreenBrandingThemeCode">Screen branding theme code.</param>
        public CartCheckout(string Comments = default(string), string CustomField1 = default(string), string CustomField2 = default(string), string CustomField3 = default(string), string CustomField4 = default(string), string CustomField5 = default(string), string CustomField6 = default(string), string CustomField7 = default(string), string IpAddress = default(string), string ScreenBrandingThemeCode = default(string))
        {
            this.Comments = Comments;
            this.CustomField1 = CustomField1;
            this.CustomField2 = CustomField2;
            this.CustomField3 = CustomField3;
            this.CustomField4 = CustomField4;
            this.CustomField5 = CustomField5;
            this.CustomField6 = CustomField6;
            this.CustomField7 = CustomField7;
            this.IpAddress = IpAddress;
            this.ScreenBrandingThemeCode = ScreenBrandingThemeCode;
        }
        
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
        /// IP Address
        /// </summary>
        /// <value>IP Address</value>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Screen branding theme code
        /// </summary>
        /// <value>Screen branding theme code</value>
        [DataMember(Name="screen_branding_theme_code", EmitDefaultValue=false)]
        public string ScreenBrandingThemeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartCheckout {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CustomField1: ").Append(CustomField1).Append("\n");
            sb.Append("  CustomField2: ").Append(CustomField2).Append("\n");
            sb.Append("  CustomField3: ").Append(CustomField3).Append("\n");
            sb.Append("  CustomField4: ").Append(CustomField4).Append("\n");
            sb.Append("  CustomField5: ").Append(CustomField5).Append("\n");
            sb.Append("  CustomField6: ").Append(CustomField6).Append("\n");
            sb.Append("  CustomField7: ").Append(CustomField7).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ScreenBrandingThemeCode: ").Append(ScreenBrandingThemeCode).Append("\n");
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
            return this.Equals(obj as CartCheckout);
        }

        /// <summary>
        /// Returns true if CartCheckout instances are equal
        /// </summary>
        /// <param name="other">Instance of CartCheckout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartCheckout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.CustomField1 == other.CustomField1 ||
                    this.CustomField1 != null &&
                    this.CustomField1.Equals(other.CustomField1)
                ) && 
                (
                    this.CustomField2 == other.CustomField2 ||
                    this.CustomField2 != null &&
                    this.CustomField2.Equals(other.CustomField2)
                ) && 
                (
                    this.CustomField3 == other.CustomField3 ||
                    this.CustomField3 != null &&
                    this.CustomField3.Equals(other.CustomField3)
                ) && 
                (
                    this.CustomField4 == other.CustomField4 ||
                    this.CustomField4 != null &&
                    this.CustomField4.Equals(other.CustomField4)
                ) && 
                (
                    this.CustomField5 == other.CustomField5 ||
                    this.CustomField5 != null &&
                    this.CustomField5.Equals(other.CustomField5)
                ) && 
                (
                    this.CustomField6 == other.CustomField6 ||
                    this.CustomField6 != null &&
                    this.CustomField6.Equals(other.CustomField6)
                ) && 
                (
                    this.CustomField7 == other.CustomField7 ||
                    this.CustomField7 != null &&
                    this.CustomField7.Equals(other.CustomField7)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.ScreenBrandingThemeCode == other.ScreenBrandingThemeCode ||
                    this.ScreenBrandingThemeCode != null &&
                    this.ScreenBrandingThemeCode.Equals(other.ScreenBrandingThemeCode)
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
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.CustomField1 != null)
                    hash = hash * 59 + this.CustomField1.GetHashCode();
                if (this.CustomField2 != null)
                    hash = hash * 59 + this.CustomField2.GetHashCode();
                if (this.CustomField3 != null)
                    hash = hash * 59 + this.CustomField3.GetHashCode();
                if (this.CustomField4 != null)
                    hash = hash * 59 + this.CustomField4.GetHashCode();
                if (this.CustomField5 != null)
                    hash = hash * 59 + this.CustomField5.GetHashCode();
                if (this.CustomField6 != null)
                    hash = hash * 59 + this.CustomField6.GetHashCode();
                if (this.CustomField7 != null)
                    hash = hash * 59 + this.CustomField7.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.ScreenBrandingThemeCode != null)
                    hash = hash * 59 + this.ScreenBrandingThemeCode.GetHashCode();
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
            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 2000.", new [] { "Comments" });
            }

            // CustomField1 (string) maxLength
            if(this.CustomField1 != null && this.CustomField1.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomField1, length must be less than 50.", new [] { "CustomField1" });
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

            // ScreenBrandingThemeCode (string) maxLength
            if(this.ScreenBrandingThemeCode != null && this.ScreenBrandingThemeCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScreenBrandingThemeCode, length must be less than 10.", new [] { "ScreenBrandingThemeCode" });
            }

            yield break;
        }
    }

}

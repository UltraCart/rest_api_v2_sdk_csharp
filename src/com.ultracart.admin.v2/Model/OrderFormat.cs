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
    /// OrderFormat
    /// </summary>
    [DataContract]
    public partial class OrderFormat :  IEquatable<OrderFormat>, IValidatableObject
    {
        /// <summary>
        /// The desired format.
        /// </summary>
        /// <value>The desired format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Text for "text"
            /// </summary>
            [EnumMember(Value = "text")]
            Text,
            
            /// <summary>
            /// Enum Div for "div"
            /// </summary>
            [EnumMember(Value = "div")]
            Div,
            
            /// <summary>
            /// Enum Table for "table"
            /// </summary>
            [EnumMember(Value = "table")]
            Table,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email
        }

        /// <summary>
        /// The desired format.
        /// </summary>
        /// <value>The desired format.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFormat" /> class.
        /// </summary>
        /// <param name="Context">The context to generate the order view for..</param>
        /// <param name="DontLinkEmailToSearch">True to not link the email address to the order search.</param>
        /// <param name="EmailAsLink">True to make the email address a clickable mailto link.</param>
        /// <param name="FilterDistributionCenterOid">Specify a distribution center oid to filter the items displayed to that particular distribution center..</param>
        /// <param name="FilterToItemsInContactOid">The container oid to filter items to..</param>
        /// <param name="Format">The desired format..</param>
        /// <param name="HideBillToAddress">True to ide the bill to address.</param>
        /// <param name="HidePriceInformation">True to hide price information.</param>
        /// <param name="LinkFileAttachments">True to link file attachments for download.</param>
        /// <param name="ShowContactInfo">True to show contact information.</param>
        /// <param name="ShowInMerchantCurrency">True to show the order in the merchant currency.</param>
        /// <param name="ShowInternalInformation">True to show internal information about the order.</param>
        /// <param name="ShowMerchantNotes">True to show merchant notes.</param>
        /// <param name="ShowNonSensitivePaymentInfo">True to show non-sensitive payment information.</param>
        /// <param name="ShowPaymentInfo">True to show payment information.</param>
        /// <param name="Translate">True to translate the order into the native language of the customer.</param>
        public OrderFormat(string Context = default(string), bool? DontLinkEmailToSearch = default(bool?), bool? EmailAsLink = default(bool?), int? FilterDistributionCenterOid = default(int?), int? FilterToItemsInContactOid = default(int?), FormatEnum? Format = default(FormatEnum?), bool? HideBillToAddress = default(bool?), bool? HidePriceInformation = default(bool?), bool? LinkFileAttachments = default(bool?), bool? ShowContactInfo = default(bool?), bool? ShowInMerchantCurrency = default(bool?), bool? ShowInternalInformation = default(bool?), bool? ShowMerchantNotes = default(bool?), bool? ShowNonSensitivePaymentInfo = default(bool?), bool? ShowPaymentInfo = default(bool?), bool? Translate = default(bool?))
        {
            this.Context = Context;
            this.DontLinkEmailToSearch = DontLinkEmailToSearch;
            this.EmailAsLink = EmailAsLink;
            this.FilterDistributionCenterOid = FilterDistributionCenterOid;
            this.FilterToItemsInContactOid = FilterToItemsInContactOid;
            this.Format = Format;
            this.HideBillToAddress = HideBillToAddress;
            this.HidePriceInformation = HidePriceInformation;
            this.LinkFileAttachments = LinkFileAttachments;
            this.ShowContactInfo = ShowContactInfo;
            this.ShowInMerchantCurrency = ShowInMerchantCurrency;
            this.ShowInternalInformation = ShowInternalInformation;
            this.ShowMerchantNotes = ShowMerchantNotes;
            this.ShowNonSensitivePaymentInfo = ShowNonSensitivePaymentInfo;
            this.ShowPaymentInfo = ShowPaymentInfo;
            this.Translate = Translate;
        }
        
        /// <summary>
        /// The context to generate the order view for.
        /// </summary>
        /// <value>The context to generate the order view for.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// True to not link the email address to the order search
        /// </summary>
        /// <value>True to not link the email address to the order search</value>
        [DataMember(Name="dont_link_email_to_search", EmitDefaultValue=false)]
        public bool? DontLinkEmailToSearch { get; set; }

        /// <summary>
        /// True to make the email address a clickable mailto link
        /// </summary>
        /// <value>True to make the email address a clickable mailto link</value>
        [DataMember(Name="email_as_link", EmitDefaultValue=false)]
        public bool? EmailAsLink { get; set; }

        /// <summary>
        /// Specify a distribution center oid to filter the items displayed to that particular distribution center.
        /// </summary>
        /// <value>Specify a distribution center oid to filter the items displayed to that particular distribution center.</value>
        [DataMember(Name="filter_distribution_center_oid", EmitDefaultValue=false)]
        public int? FilterDistributionCenterOid { get; set; }

        /// <summary>
        /// The container oid to filter items to.
        /// </summary>
        /// <value>The container oid to filter items to.</value>
        [DataMember(Name="filter_to_items_in_contact_oid", EmitDefaultValue=false)]
        public int? FilterToItemsInContactOid { get; set; }


        /// <summary>
        /// True to ide the bill to address
        /// </summary>
        /// <value>True to ide the bill to address</value>
        [DataMember(Name="hide_bill_to_address", EmitDefaultValue=false)]
        public bool? HideBillToAddress { get; set; }

        /// <summary>
        /// True to hide price information
        /// </summary>
        /// <value>True to hide price information</value>
        [DataMember(Name="hide_price_information", EmitDefaultValue=false)]
        public bool? HidePriceInformation { get; set; }

        /// <summary>
        /// True to link file attachments for download
        /// </summary>
        /// <value>True to link file attachments for download</value>
        [DataMember(Name="link_file_attachments", EmitDefaultValue=false)]
        public bool? LinkFileAttachments { get; set; }

        /// <summary>
        /// True to show contact information
        /// </summary>
        /// <value>True to show contact information</value>
        [DataMember(Name="show_contact_info", EmitDefaultValue=false)]
        public bool? ShowContactInfo { get; set; }

        /// <summary>
        /// True to show the order in the merchant currency
        /// </summary>
        /// <value>True to show the order in the merchant currency</value>
        [DataMember(Name="show_in_merchant_currency", EmitDefaultValue=false)]
        public bool? ShowInMerchantCurrency { get; set; }

        /// <summary>
        /// True to show internal information about the order
        /// </summary>
        /// <value>True to show internal information about the order</value>
        [DataMember(Name="show_internal_information", EmitDefaultValue=false)]
        public bool? ShowInternalInformation { get; set; }

        /// <summary>
        /// True to show merchant notes
        /// </summary>
        /// <value>True to show merchant notes</value>
        [DataMember(Name="show_merchant_notes", EmitDefaultValue=false)]
        public bool? ShowMerchantNotes { get; set; }

        /// <summary>
        /// True to show non-sensitive payment information
        /// </summary>
        /// <value>True to show non-sensitive payment information</value>
        [DataMember(Name="show_non_sensitive_payment_info", EmitDefaultValue=false)]
        public bool? ShowNonSensitivePaymentInfo { get; set; }

        /// <summary>
        /// True to show payment information
        /// </summary>
        /// <value>True to show payment information</value>
        [DataMember(Name="show_payment_info", EmitDefaultValue=false)]
        public bool? ShowPaymentInfo { get; set; }

        /// <summary>
        /// True to translate the order into the native language of the customer
        /// </summary>
        /// <value>True to translate the order into the native language of the customer</value>
        [DataMember(Name="translate", EmitDefaultValue=false)]
        public bool? Translate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFormat {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  DontLinkEmailToSearch: ").Append(DontLinkEmailToSearch).Append("\n");
            sb.Append("  EmailAsLink: ").Append(EmailAsLink).Append("\n");
            sb.Append("  FilterDistributionCenterOid: ").Append(FilterDistributionCenterOid).Append("\n");
            sb.Append("  FilterToItemsInContactOid: ").Append(FilterToItemsInContactOid).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  HideBillToAddress: ").Append(HideBillToAddress).Append("\n");
            sb.Append("  HidePriceInformation: ").Append(HidePriceInformation).Append("\n");
            sb.Append("  LinkFileAttachments: ").Append(LinkFileAttachments).Append("\n");
            sb.Append("  ShowContactInfo: ").Append(ShowContactInfo).Append("\n");
            sb.Append("  ShowInMerchantCurrency: ").Append(ShowInMerchantCurrency).Append("\n");
            sb.Append("  ShowInternalInformation: ").Append(ShowInternalInformation).Append("\n");
            sb.Append("  ShowMerchantNotes: ").Append(ShowMerchantNotes).Append("\n");
            sb.Append("  ShowNonSensitivePaymentInfo: ").Append(ShowNonSensitivePaymentInfo).Append("\n");
            sb.Append("  ShowPaymentInfo: ").Append(ShowPaymentInfo).Append("\n");
            sb.Append("  Translate: ").Append(Translate).Append("\n");
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
            return this.Equals(input as OrderFormat);
        }

        /// <summary>
        /// Returns true if OrderFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.DontLinkEmailToSearch == input.DontLinkEmailToSearch ||
                    (this.DontLinkEmailToSearch != null &&
                    this.DontLinkEmailToSearch.Equals(input.DontLinkEmailToSearch))
                ) && 
                (
                    this.EmailAsLink == input.EmailAsLink ||
                    (this.EmailAsLink != null &&
                    this.EmailAsLink.Equals(input.EmailAsLink))
                ) && 
                (
                    this.FilterDistributionCenterOid == input.FilterDistributionCenterOid ||
                    (this.FilterDistributionCenterOid != null &&
                    this.FilterDistributionCenterOid.Equals(input.FilterDistributionCenterOid))
                ) && 
                (
                    this.FilterToItemsInContactOid == input.FilterToItemsInContactOid ||
                    (this.FilterToItemsInContactOid != null &&
                    this.FilterToItemsInContactOid.Equals(input.FilterToItemsInContactOid))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.HideBillToAddress == input.HideBillToAddress ||
                    (this.HideBillToAddress != null &&
                    this.HideBillToAddress.Equals(input.HideBillToAddress))
                ) && 
                (
                    this.HidePriceInformation == input.HidePriceInformation ||
                    (this.HidePriceInformation != null &&
                    this.HidePriceInformation.Equals(input.HidePriceInformation))
                ) && 
                (
                    this.LinkFileAttachments == input.LinkFileAttachments ||
                    (this.LinkFileAttachments != null &&
                    this.LinkFileAttachments.Equals(input.LinkFileAttachments))
                ) && 
                (
                    this.ShowContactInfo == input.ShowContactInfo ||
                    (this.ShowContactInfo != null &&
                    this.ShowContactInfo.Equals(input.ShowContactInfo))
                ) && 
                (
                    this.ShowInMerchantCurrency == input.ShowInMerchantCurrency ||
                    (this.ShowInMerchantCurrency != null &&
                    this.ShowInMerchantCurrency.Equals(input.ShowInMerchantCurrency))
                ) && 
                (
                    this.ShowInternalInformation == input.ShowInternalInformation ||
                    (this.ShowInternalInformation != null &&
                    this.ShowInternalInformation.Equals(input.ShowInternalInformation))
                ) && 
                (
                    this.ShowMerchantNotes == input.ShowMerchantNotes ||
                    (this.ShowMerchantNotes != null &&
                    this.ShowMerchantNotes.Equals(input.ShowMerchantNotes))
                ) && 
                (
                    this.ShowNonSensitivePaymentInfo == input.ShowNonSensitivePaymentInfo ||
                    (this.ShowNonSensitivePaymentInfo != null &&
                    this.ShowNonSensitivePaymentInfo.Equals(input.ShowNonSensitivePaymentInfo))
                ) && 
                (
                    this.ShowPaymentInfo == input.ShowPaymentInfo ||
                    (this.ShowPaymentInfo != null &&
                    this.ShowPaymentInfo.Equals(input.ShowPaymentInfo))
                ) && 
                (
                    this.Translate == input.Translate ||
                    (this.Translate != null &&
                    this.Translate.Equals(input.Translate))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.DontLinkEmailToSearch != null)
                    hashCode = hashCode * 59 + this.DontLinkEmailToSearch.GetHashCode();
                if (this.EmailAsLink != null)
                    hashCode = hashCode * 59 + this.EmailAsLink.GetHashCode();
                if (this.FilterDistributionCenterOid != null)
                    hashCode = hashCode * 59 + this.FilterDistributionCenterOid.GetHashCode();
                if (this.FilterToItemsInContactOid != null)
                    hashCode = hashCode * 59 + this.FilterToItemsInContactOid.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.HideBillToAddress != null)
                    hashCode = hashCode * 59 + this.HideBillToAddress.GetHashCode();
                if (this.HidePriceInformation != null)
                    hashCode = hashCode * 59 + this.HidePriceInformation.GetHashCode();
                if (this.LinkFileAttachments != null)
                    hashCode = hashCode * 59 + this.LinkFileAttachments.GetHashCode();
                if (this.ShowContactInfo != null)
                    hashCode = hashCode * 59 + this.ShowContactInfo.GetHashCode();
                if (this.ShowInMerchantCurrency != null)
                    hashCode = hashCode * 59 + this.ShowInMerchantCurrency.GetHashCode();
                if (this.ShowInternalInformation != null)
                    hashCode = hashCode * 59 + this.ShowInternalInformation.GetHashCode();
                if (this.ShowMerchantNotes != null)
                    hashCode = hashCode * 59 + this.ShowMerchantNotes.GetHashCode();
                if (this.ShowNonSensitivePaymentInfo != null)
                    hashCode = hashCode * 59 + this.ShowNonSensitivePaymentInfo.GetHashCode();
                if (this.ShowPaymentInfo != null)
                    hashCode = hashCode * 59 + this.ShowPaymentInfo.GetHashCode();
                if (this.Translate != null)
                    hashCode = hashCode * 59 + this.Translate.GetHashCode();
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
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
    /// AffiliateClick
    /// </summary>
    [DataContract]
    public partial class AffiliateClick :  IEquatable<AffiliateClick>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateClick" /> class.
        /// </summary>
        /// <param name="affiliateClickOid">Unique object identifier for this click.</param>
        /// <param name="affiliateLinkOid">Unique object identifier for for the link that this click is associated with.</param>
        /// <param name="affiliateOid">Affiliate object ID associated with this click.</param>
        /// <param name="clickDts">Date/time that the click was made.</param>
        /// <param name="ipAddress">IP address that generated the click.</param>
        /// <param name="landingPage">URL of the landing page the customer was sent to..</param>
        /// <param name="landingPageQueryString">Query string on the landing page URL the customer was sent to..</param>
        /// <param name="link">link.</param>
        /// <param name="referrer">URL that referred the click (Browser Header Referer).</param>
        /// <param name="referrerQueryString">Query string that was on the referrer URL..</param>
        /// <param name="subId">Sub ID value passed on the click.</param>
        public AffiliateClick(int affiliateClickOid = default(int), int affiliateLinkOid = default(int), int affiliateOid = default(int), string clickDts = default(string), string ipAddress = default(string), string landingPage = default(string), string landingPageQueryString = default(string), AffiliateLink link = default(AffiliateLink), string referrer = default(string), string referrerQueryString = default(string), string subId = default(string))
        {
            this.AffiliateClickOid = affiliateClickOid;
            this.AffiliateLinkOid = affiliateLinkOid;
            this.AffiliateOid = affiliateOid;
            this.ClickDts = clickDts;
            this.IpAddress = ipAddress;
            this.LandingPage = landingPage;
            this.LandingPageQueryString = landingPageQueryString;
            this.Link = link;
            this.Referrer = referrer;
            this.ReferrerQueryString = referrerQueryString;
            this.SubId = subId;
        }

        /// <summary>
        /// Unique object identifier for this click
        /// </summary>
        /// <value>Unique object identifier for this click</value>
        [DataMember(Name="affiliate_click_oid", EmitDefaultValue=false)]
        public int AffiliateClickOid { get; set; }

        /// <summary>
        /// Unique object identifier for for the link that this click is associated with
        /// </summary>
        /// <value>Unique object identifier for for the link that this click is associated with</value>
        [DataMember(Name="affiliate_link_oid", EmitDefaultValue=false)]
        public int AffiliateLinkOid { get; set; }

        /// <summary>
        /// Affiliate object ID associated with this click
        /// </summary>
        /// <value>Affiliate object ID associated with this click</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int AffiliateOid { get; set; }

        /// <summary>
        /// Date/time that the click was made
        /// </summary>
        /// <value>Date/time that the click was made</value>
        [DataMember(Name="click_dts", EmitDefaultValue=false)]
        public string ClickDts { get; set; }

        /// <summary>
        /// IP address that generated the click
        /// </summary>
        /// <value>IP address that generated the click</value>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// URL of the landing page the customer was sent to.
        /// </summary>
        /// <value>URL of the landing page the customer was sent to.</value>
        [DataMember(Name="landing_page", EmitDefaultValue=false)]
        public string LandingPage { get; set; }

        /// <summary>
        /// Query string on the landing page URL the customer was sent to.
        /// </summary>
        /// <value>Query string on the landing page URL the customer was sent to.</value>
        [DataMember(Name="landing_page_query_string", EmitDefaultValue=false)]
        public string LandingPageQueryString { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public AffiliateLink Link { get; set; }

        /// <summary>
        /// URL that referred the click (Browser Header Referer)
        /// </summary>
        /// <value>URL that referred the click (Browser Header Referer)</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public string Referrer { get; set; }

        /// <summary>
        /// Query string that was on the referrer URL.
        /// </summary>
        /// <value>Query string that was on the referrer URL.</value>
        [DataMember(Name="referrer_query_string", EmitDefaultValue=false)]
        public string ReferrerQueryString { get; set; }

        /// <summary>
        /// Sub ID value passed on the click
        /// </summary>
        /// <value>Sub ID value passed on the click</value>
        [DataMember(Name="sub_id", EmitDefaultValue=false)]
        public string SubId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateClick {\n");
            sb.Append("  AffiliateClickOid: ").Append(AffiliateClickOid).Append("\n");
            sb.Append("  AffiliateLinkOid: ").Append(AffiliateLinkOid).Append("\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  ClickDts: ").Append(ClickDts).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  LandingPage: ").Append(LandingPage).Append("\n");
            sb.Append("  LandingPageQueryString: ").Append(LandingPageQueryString).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  ReferrerQueryString: ").Append(ReferrerQueryString).Append("\n");
            sb.Append("  SubId: ").Append(SubId).Append("\n");
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
            return this.Equals(input as AffiliateClick);
        }

        /// <summary>
        /// Returns true if AffiliateClick instances are equal
        /// </summary>
        /// <param name="input">Instance of AffiliateClick to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateClick input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateClickOid == input.AffiliateClickOid ||
                    (this.AffiliateClickOid != null &&
                    this.AffiliateClickOid.Equals(input.AffiliateClickOid))
                ) && 
                (
                    this.AffiliateLinkOid == input.AffiliateLinkOid ||
                    (this.AffiliateLinkOid != null &&
                    this.AffiliateLinkOid.Equals(input.AffiliateLinkOid))
                ) && 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.ClickDts == input.ClickDts ||
                    (this.ClickDts != null &&
                    this.ClickDts.Equals(input.ClickDts))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.LandingPage == input.LandingPage ||
                    (this.LandingPage != null &&
                    this.LandingPage.Equals(input.LandingPage))
                ) && 
                (
                    this.LandingPageQueryString == input.LandingPageQueryString ||
                    (this.LandingPageQueryString != null &&
                    this.LandingPageQueryString.Equals(input.LandingPageQueryString))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
                ) && 
                (
                    this.ReferrerQueryString == input.ReferrerQueryString ||
                    (this.ReferrerQueryString != null &&
                    this.ReferrerQueryString.Equals(input.ReferrerQueryString))
                ) && 
                (
                    this.SubId == input.SubId ||
                    (this.SubId != null &&
                    this.SubId.Equals(input.SubId))
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
                if (this.AffiliateClickOid != null)
                    hashCode = hashCode * 59 + this.AffiliateClickOid.GetHashCode();
                if (this.AffiliateLinkOid != null)
                    hashCode = hashCode * 59 + this.AffiliateLinkOid.GetHashCode();
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.ClickDts != null)
                    hashCode = hashCode * 59 + this.ClickDts.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.LandingPage != null)
                    hashCode = hashCode * 59 + this.LandingPage.GetHashCode();
                if (this.LandingPageQueryString != null)
                    hashCode = hashCode * 59 + this.LandingPageQueryString.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Referrer != null)
                    hashCode = hashCode * 59 + this.Referrer.GetHashCode();
                if (this.ReferrerQueryString != null)
                    hashCode = hashCode * 59 + this.ReferrerQueryString.GetHashCode();
                if (this.SubId != null)
                    hashCode = hashCode * 59 + this.SubId.GetHashCode();
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

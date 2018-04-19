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
    /// AffiliateLink
    /// </summary>
    [DataContract]
    public partial class AffiliateLink :  IEquatable<AffiliateLink>, IValidatableObject
    {
        /// <summary>
        /// Approved status of the custom html
        /// </summary>
        /// <value>Approved status of the custom html</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomHtmlApprovalStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected
        }

        /// <summary>
        /// Invisible link approval status
        /// </summary>
        /// <value>Invisible link approval status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InvisibleLinkApprovalStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected
        }

        /// <summary>
        /// Type of link
        /// </summary>
        /// <value>Type of link</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Image for "image"
            /// </summary>
            [EnumMember(Value = "image")]
            Image,
            
            /// <summary>
            /// Enum Text for "text"
            /// </summary>
            [EnumMember(Value = "text")]
            Text,
            
            /// <summary>
            /// Enum Invisible for "invisible"
            /// </summary>
            [EnumMember(Value = "invisible")]
            Invisible,
            
            /// <summary>
            /// Enum Direct for "direct"
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct
        }

        /// <summary>
        /// Approved status of the custom html
        /// </summary>
        /// <value>Approved status of the custom html</value>
        [DataMember(Name="custom_html_approval_status", EmitDefaultValue=false)]
        public CustomHtmlApprovalStatusEnum? CustomHtmlApprovalStatus { get; set; }
        /// <summary>
        /// Invisible link approval status
        /// </summary>
        /// <value>Invisible link approval status</value>
        [DataMember(Name="invisible_link_approval_status", EmitDefaultValue=false)]
        public InvisibleLinkApprovalStatusEnum? InvisibleLinkApprovalStatus { get; set; }
        /// <summary>
        /// Type of link
        /// </summary>
        /// <value>Type of link</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateLink" /> class.
        /// </summary>
        /// <param name="AffiliateLinkOid">Unique object identifier associated with this link.</param>
        /// <param name="AffiliateManagedLinkOid">Managed link OID that this link object was generated from.</param>
        /// <param name="AffiliateOid">Affiliate object ID associated with this link.</param>
        /// <param name="AffiliateProgramItemOid">The affiliate program item this managed link is associated with.</param>
        /// <param name="Code">Code associated with the link.</param>
        /// <param name="CreativeOid">Creative (image or text) associated with this link.</param>
        /// <param name="CustomHtml">Custom HTML associated with this link.</param>
        /// <param name="CustomHtmlApprovalStatus">Approved status of the custom html.</param>
        /// <param name="CustomLandingUrl">Custom landing page URL if configured.</param>
        /// <param name="Deleted">True if the link has been deleted.</param>
        /// <param name="InvisibleLinkApprovalStatus">Invisible link approval status.</param>
        /// <param name="InvisibleLinkUrlPrefix">Invisible link URL prefix.</param>
        /// <param name="Name">Name of the link.</param>
        /// <param name="Type">Type of link.</param>
        public AffiliateLink(int? AffiliateLinkOid = default(int?), int? AffiliateManagedLinkOid = default(int?), int? AffiliateOid = default(int?), int? AffiliateProgramItemOid = default(int?), string Code = default(string), int? CreativeOid = default(int?), string CustomHtml = default(string), CustomHtmlApprovalStatusEnum? CustomHtmlApprovalStatus = default(CustomHtmlApprovalStatusEnum?), string CustomLandingUrl = default(string), bool? Deleted = default(bool?), InvisibleLinkApprovalStatusEnum? InvisibleLinkApprovalStatus = default(InvisibleLinkApprovalStatusEnum?), string InvisibleLinkUrlPrefix = default(string), string Name = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this.AffiliateLinkOid = AffiliateLinkOid;
            this.AffiliateManagedLinkOid = AffiliateManagedLinkOid;
            this.AffiliateOid = AffiliateOid;
            this.AffiliateProgramItemOid = AffiliateProgramItemOid;
            this.Code = Code;
            this.CreativeOid = CreativeOid;
            this.CustomHtml = CustomHtml;
            this.CustomHtmlApprovalStatus = CustomHtmlApprovalStatus;
            this.CustomLandingUrl = CustomLandingUrl;
            this.Deleted = Deleted;
            this.InvisibleLinkApprovalStatus = InvisibleLinkApprovalStatus;
            this.InvisibleLinkUrlPrefix = InvisibleLinkUrlPrefix;
            this.Name = Name;
            this.Type = Type;
        }
        
        /// <summary>
        /// Unique object identifier associated with this link
        /// </summary>
        /// <value>Unique object identifier associated with this link</value>
        [DataMember(Name="affiliate_link_oid", EmitDefaultValue=false)]
        public int? AffiliateLinkOid { get; set; }

        /// <summary>
        /// Managed link OID that this link object was generated from
        /// </summary>
        /// <value>Managed link OID that this link object was generated from</value>
        [DataMember(Name="affiliate_managed_link_oid", EmitDefaultValue=false)]
        public int? AffiliateManagedLinkOid { get; set; }

        /// <summary>
        /// Affiliate object ID associated with this link
        /// </summary>
        /// <value>Affiliate object ID associated with this link</value>
        [DataMember(Name="affiliate_oid", EmitDefaultValue=false)]
        public int? AffiliateOid { get; set; }

        /// <summary>
        /// The affiliate program item this managed link is associated with
        /// </summary>
        /// <value>The affiliate program item this managed link is associated with</value>
        [DataMember(Name="affiliate_program_item_oid", EmitDefaultValue=false)]
        public int? AffiliateProgramItemOid { get; set; }

        /// <summary>
        /// Code associated with the link
        /// </summary>
        /// <value>Code associated with the link</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Creative (image or text) associated with this link
        /// </summary>
        /// <value>Creative (image or text) associated with this link</value>
        [DataMember(Name="creative_oid", EmitDefaultValue=false)]
        public int? CreativeOid { get; set; }

        /// <summary>
        /// Custom HTML associated with this link
        /// </summary>
        /// <value>Custom HTML associated with this link</value>
        [DataMember(Name="custom_html", EmitDefaultValue=false)]
        public string CustomHtml { get; set; }


        /// <summary>
        /// Custom landing page URL if configured
        /// </summary>
        /// <value>Custom landing page URL if configured</value>
        [DataMember(Name="custom_landing_url", EmitDefaultValue=false)]
        public string CustomLandingUrl { get; set; }

        /// <summary>
        /// True if the link has been deleted
        /// </summary>
        /// <value>True if the link has been deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }


        /// <summary>
        /// Invisible link URL prefix
        /// </summary>
        /// <value>Invisible link URL prefix</value>
        [DataMember(Name="invisible_link_url_prefix", EmitDefaultValue=false)]
        public string InvisibleLinkUrlPrefix { get; set; }

        /// <summary>
        /// Name of the link
        /// </summary>
        /// <value>Name of the link</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateLink {\n");
            sb.Append("  AffiliateLinkOid: ").Append(AffiliateLinkOid).Append("\n");
            sb.Append("  AffiliateManagedLinkOid: ").Append(AffiliateManagedLinkOid).Append("\n");
            sb.Append("  AffiliateOid: ").Append(AffiliateOid).Append("\n");
            sb.Append("  AffiliateProgramItemOid: ").Append(AffiliateProgramItemOid).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CreativeOid: ").Append(CreativeOid).Append("\n");
            sb.Append("  CustomHtml: ").Append(CustomHtml).Append("\n");
            sb.Append("  CustomHtmlApprovalStatus: ").Append(CustomHtmlApprovalStatus).Append("\n");
            sb.Append("  CustomLandingUrl: ").Append(CustomLandingUrl).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  InvisibleLinkApprovalStatus: ").Append(InvisibleLinkApprovalStatus).Append("\n");
            sb.Append("  InvisibleLinkUrlPrefix: ").Append(InvisibleLinkUrlPrefix).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AffiliateLink);
        }

        /// <summary>
        /// Returns true if AffiliateLink instances are equal
        /// </summary>
        /// <param name="input">Instance of AffiliateLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AffiliateLinkOid == input.AffiliateLinkOid ||
                    (this.AffiliateLinkOid != null &&
                    this.AffiliateLinkOid.Equals(input.AffiliateLinkOid))
                ) && 
                (
                    this.AffiliateManagedLinkOid == input.AffiliateManagedLinkOid ||
                    (this.AffiliateManagedLinkOid != null &&
                    this.AffiliateManagedLinkOid.Equals(input.AffiliateManagedLinkOid))
                ) && 
                (
                    this.AffiliateOid == input.AffiliateOid ||
                    (this.AffiliateOid != null &&
                    this.AffiliateOid.Equals(input.AffiliateOid))
                ) && 
                (
                    this.AffiliateProgramItemOid == input.AffiliateProgramItemOid ||
                    (this.AffiliateProgramItemOid != null &&
                    this.AffiliateProgramItemOid.Equals(input.AffiliateProgramItemOid))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CreativeOid == input.CreativeOid ||
                    (this.CreativeOid != null &&
                    this.CreativeOid.Equals(input.CreativeOid))
                ) && 
                (
                    this.CustomHtml == input.CustomHtml ||
                    (this.CustomHtml != null &&
                    this.CustomHtml.Equals(input.CustomHtml))
                ) && 
                (
                    this.CustomHtmlApprovalStatus == input.CustomHtmlApprovalStatus ||
                    (this.CustomHtmlApprovalStatus != null &&
                    this.CustomHtmlApprovalStatus.Equals(input.CustomHtmlApprovalStatus))
                ) && 
                (
                    this.CustomLandingUrl == input.CustomLandingUrl ||
                    (this.CustomLandingUrl != null &&
                    this.CustomLandingUrl.Equals(input.CustomLandingUrl))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.InvisibleLinkApprovalStatus == input.InvisibleLinkApprovalStatus ||
                    (this.InvisibleLinkApprovalStatus != null &&
                    this.InvisibleLinkApprovalStatus.Equals(input.InvisibleLinkApprovalStatus))
                ) && 
                (
                    this.InvisibleLinkUrlPrefix == input.InvisibleLinkUrlPrefix ||
                    (this.InvisibleLinkUrlPrefix != null &&
                    this.InvisibleLinkUrlPrefix.Equals(input.InvisibleLinkUrlPrefix))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AffiliateLinkOid != null)
                    hashCode = hashCode * 59 + this.AffiliateLinkOid.GetHashCode();
                if (this.AffiliateManagedLinkOid != null)
                    hashCode = hashCode * 59 + this.AffiliateManagedLinkOid.GetHashCode();
                if (this.AffiliateOid != null)
                    hashCode = hashCode * 59 + this.AffiliateOid.GetHashCode();
                if (this.AffiliateProgramItemOid != null)
                    hashCode = hashCode * 59 + this.AffiliateProgramItemOid.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CreativeOid != null)
                    hashCode = hashCode * 59 + this.CreativeOid.GetHashCode();
                if (this.CustomHtml != null)
                    hashCode = hashCode * 59 + this.CustomHtml.GetHashCode();
                if (this.CustomHtmlApprovalStatus != null)
                    hashCode = hashCode * 59 + this.CustomHtmlApprovalStatus.GetHashCode();
                if (this.CustomLandingUrl != null)
                    hashCode = hashCode * 59 + this.CustomLandingUrl.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.InvisibleLinkApprovalStatus != null)
                    hashCode = hashCode * 59 + this.InvisibleLinkApprovalStatus.GetHashCode();
                if (this.InvisibleLinkUrlPrefix != null)
                    hashCode = hashCode * 59 + this.InvisibleLinkUrlPrefix.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

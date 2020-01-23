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
    /// EmailSegment
    /// </summary>
    [DataContract]
    public partial class EmailSegment :  IEquatable<EmailSegment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSegment" /> class.
        /// </summary>
        /// <param name="CreatedDts">Created date.</param>
        /// <param name="Deleted">True if this campaign was deleted.</param>
        /// <param name="EmailSegmentUuid">Email segment UUID.</param>
        /// <param name="FacebookCustomAudience">True if you want to sync to a facebook custom audience.</param>
        /// <param name="FilterProfileEquationJson">File profile equation json.</param>
        /// <param name="MemberCount">Count of members in this segment.</param>
        /// <param name="MerchantId">Merchant ID.</param>
        /// <param name="Name">Name of email segment.</param>
        /// <param name="RebuildRequired">True if a rebuild is required because some part of the segment has changed.</param>
        /// <param name="StorefrontOid">Storefront oid.</param>
        public EmailSegment(string CreatedDts = default(string), bool? Deleted = default(bool?), string EmailSegmentUuid = default(string), bool? FacebookCustomAudience = default(bool?), string FilterProfileEquationJson = default(string), int? MemberCount = default(int?), string MerchantId = default(string), string Name = default(string), bool? RebuildRequired = default(bool?), int? StorefrontOid = default(int?))
        {
            this.CreatedDts = CreatedDts;
            this.Deleted = Deleted;
            this.EmailSegmentUuid = EmailSegmentUuid;
            this.FacebookCustomAudience = FacebookCustomAudience;
            this.FilterProfileEquationJson = FilterProfileEquationJson;
            this.MemberCount = MemberCount;
            this.MerchantId = MerchantId;
            this.Name = Name;
            this.RebuildRequired = RebuildRequired;
            this.StorefrontOid = StorefrontOid;
        }
        
        /// <summary>
        /// Created date
        /// </summary>
        /// <value>Created date</value>
        [DataMember(Name="created_dts", EmitDefaultValue=false)]
        public string CreatedDts { get; set; }

        /// <summary>
        /// True if this campaign was deleted
        /// </summary>
        /// <value>True if this campaign was deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Email segment UUID
        /// </summary>
        /// <value>Email segment UUID</value>
        [DataMember(Name="email_segment_uuid", EmitDefaultValue=false)]
        public string EmailSegmentUuid { get; set; }

        /// <summary>
        /// True if you want to sync to a facebook custom audience
        /// </summary>
        /// <value>True if you want to sync to a facebook custom audience</value>
        [DataMember(Name="facebook_custom_audience", EmitDefaultValue=false)]
        public bool? FacebookCustomAudience { get; set; }

        /// <summary>
        /// File profile equation json
        /// </summary>
        /// <value>File profile equation json</value>
        [DataMember(Name="filter_profile_equation_json", EmitDefaultValue=false)]
        public string FilterProfileEquationJson { get; set; }

        /// <summary>
        /// Count of members in this segment
        /// </summary>
        /// <value>Count of members in this segment</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Name of email segment
        /// </summary>
        /// <value>Name of email segment</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// True if a rebuild is required because some part of the segment has changed
        /// </summary>
        /// <value>True if a rebuild is required because some part of the segment has changed</value>
        [DataMember(Name="rebuild_required", EmitDefaultValue=false)]
        public bool? RebuildRequired { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSegment {\n");
            sb.Append("  CreatedDts: ").Append(CreatedDts).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  EmailSegmentUuid: ").Append(EmailSegmentUuid).Append("\n");
            sb.Append("  FacebookCustomAudience: ").Append(FacebookCustomAudience).Append("\n");
            sb.Append("  FilterProfileEquationJson: ").Append(FilterProfileEquationJson).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RebuildRequired: ").Append(RebuildRequired).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as EmailSegment);
        }

        /// <summary>
        /// Returns true if EmailSegment instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSegment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedDts == input.CreatedDts ||
                    (this.CreatedDts != null &&
                    this.CreatedDts.Equals(input.CreatedDts))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.EmailSegmentUuid == input.EmailSegmentUuid ||
                    (this.EmailSegmentUuid != null &&
                    this.EmailSegmentUuid.Equals(input.EmailSegmentUuid))
                ) && 
                (
                    this.FacebookCustomAudience == input.FacebookCustomAudience ||
                    (this.FacebookCustomAudience != null &&
                    this.FacebookCustomAudience.Equals(input.FacebookCustomAudience))
                ) && 
                (
                    this.FilterProfileEquationJson == input.FilterProfileEquationJson ||
                    (this.FilterProfileEquationJson != null &&
                    this.FilterProfileEquationJson.Equals(input.FilterProfileEquationJson))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RebuildRequired == input.RebuildRequired ||
                    (this.RebuildRequired != null &&
                    this.RebuildRequired.Equals(input.RebuildRequired))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
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
                if (this.CreatedDts != null)
                    hashCode = hashCode * 59 + this.CreatedDts.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.EmailSegmentUuid != null)
                    hashCode = hashCode * 59 + this.EmailSegmentUuid.GetHashCode();
                if (this.FacebookCustomAudience != null)
                    hashCode = hashCode * 59 + this.FacebookCustomAudience.GetHashCode();
                if (this.FilterProfileEquationJson != null)
                    hashCode = hashCode * 59 + this.FilterProfileEquationJson.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RebuildRequired != null)
                    hashCode = hashCode * 59 + this.RebuildRequired.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
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
            if(this.Name != null && this.Name.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 250.", new [] { "Name" });
            }

            yield break;
        }
    }

}

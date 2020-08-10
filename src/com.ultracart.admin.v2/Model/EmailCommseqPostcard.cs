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
    /// EmailCommseqPostcard
    /// </summary>
    [DataContract]
    public partial class EmailCommseqPostcard :  IEquatable<EmailCommseqPostcard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCommseqPostcard" /> class.
        /// </summary>
        /// <param name="deleted">Deleted.</param>
        /// <param name="editedByUser">Edited by user.</param>
        /// <param name="emailCommunicationSequencePostcardUuid">communication sequence postcard uuid.</param>
        /// <param name="filterProfileEquationJson">Filter profile equation json.</param>
        /// <param name="merchantId">Merchant ID.</param>
        /// <param name="postcardBackContainerCjson">Postcard back container cjson.</param>
        /// <param name="postcardBackContainerUuid">Postcard back container uuid.</param>
        /// <param name="postcardContainerCjsonLastModifiedDts">Timestamp the last time the container was modified..</param>
        /// <param name="postcardFrontContainerCjson">Postcard front container cjson.</param>
        /// <param name="postcardFrontContainerUuid">Postcard front container uuid.</param>
        /// <param name="storefrontOid">Storefront oid.</param>
        public EmailCommseqPostcard(bool? deleted = default(bool?), string editedByUser = default(string), string emailCommunicationSequencePostcardUuid = default(string), string filterProfileEquationJson = default(string), string merchantId = default(string), string postcardBackContainerCjson = default(string), string postcardBackContainerUuid = default(string), string postcardContainerCjsonLastModifiedDts = default(string), string postcardFrontContainerCjson = default(string), string postcardFrontContainerUuid = default(string), int? storefrontOid = default(int?))
        {
            this.Deleted = deleted;
            this.EditedByUser = editedByUser;
            this.EmailCommunicationSequencePostcardUuid = emailCommunicationSequencePostcardUuid;
            this.FilterProfileEquationJson = filterProfileEquationJson;
            this.MerchantId = merchantId;
            this.PostcardBackContainerCjson = postcardBackContainerCjson;
            this.PostcardBackContainerUuid = postcardBackContainerUuid;
            this.PostcardContainerCjsonLastModifiedDts = postcardContainerCjsonLastModifiedDts;
            this.PostcardFrontContainerCjson = postcardFrontContainerCjson;
            this.PostcardFrontContainerUuid = postcardFrontContainerUuid;
            this.StorefrontOid = storefrontOid;
        }
        
        /// <summary>
        /// Deleted
        /// </summary>
        /// <value>Deleted</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Edited by user
        /// </summary>
        /// <value>Edited by user</value>
        [DataMember(Name="edited_by_user", EmitDefaultValue=false)]
        public string EditedByUser { get; set; }

        /// <summary>
        /// communication sequence postcard uuid
        /// </summary>
        /// <value>communication sequence postcard uuid</value>
        [DataMember(Name="email_communication_sequence_postcard_uuid", EmitDefaultValue=false)]
        public string EmailCommunicationSequencePostcardUuid { get; set; }

        /// <summary>
        /// Filter profile equation json
        /// </summary>
        /// <value>Filter profile equation json</value>
        [DataMember(Name="filter_profile_equation_json", EmitDefaultValue=false)]
        public string FilterProfileEquationJson { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Postcard back container cjson
        /// </summary>
        /// <value>Postcard back container cjson</value>
        [DataMember(Name="postcard_back_container_cjson", EmitDefaultValue=false)]
        public string PostcardBackContainerCjson { get; set; }

        /// <summary>
        /// Postcard back container uuid
        /// </summary>
        /// <value>Postcard back container uuid</value>
        [DataMember(Name="postcard_back_container_uuid", EmitDefaultValue=false)]
        public string PostcardBackContainerUuid { get; set; }

        /// <summary>
        /// Timestamp the last time the container was modified.
        /// </summary>
        /// <value>Timestamp the last time the container was modified.</value>
        [DataMember(Name="postcard_container_cjson_last_modified_dts", EmitDefaultValue=false)]
        public string PostcardContainerCjsonLastModifiedDts { get; set; }

        /// <summary>
        /// Postcard front container cjson
        /// </summary>
        /// <value>Postcard front container cjson</value>
        [DataMember(Name="postcard_front_container_cjson", EmitDefaultValue=false)]
        public string PostcardFrontContainerCjson { get; set; }

        /// <summary>
        /// Postcard front container uuid
        /// </summary>
        /// <value>Postcard front container uuid</value>
        [DataMember(Name="postcard_front_container_uuid", EmitDefaultValue=false)]
        public string PostcardFrontContainerUuid { get; set; }

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
            sb.Append("class EmailCommseqPostcard {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  EditedByUser: ").Append(EditedByUser).Append("\n");
            sb.Append("  EmailCommunicationSequencePostcardUuid: ").Append(EmailCommunicationSequencePostcardUuid).Append("\n");
            sb.Append("  FilterProfileEquationJson: ").Append(FilterProfileEquationJson).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PostcardBackContainerCjson: ").Append(PostcardBackContainerCjson).Append("\n");
            sb.Append("  PostcardBackContainerUuid: ").Append(PostcardBackContainerUuid).Append("\n");
            sb.Append("  PostcardContainerCjsonLastModifiedDts: ").Append(PostcardContainerCjsonLastModifiedDts).Append("\n");
            sb.Append("  PostcardFrontContainerCjson: ").Append(PostcardFrontContainerCjson).Append("\n");
            sb.Append("  PostcardFrontContainerUuid: ").Append(PostcardFrontContainerUuid).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
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
            return this.Equals(input as EmailCommseqPostcard);
        }

        /// <summary>
        /// Returns true if EmailCommseqPostcard instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCommseqPostcard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCommseqPostcard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.EditedByUser == input.EditedByUser ||
                    (this.EditedByUser != null &&
                    this.EditedByUser.Equals(input.EditedByUser))
                ) && 
                (
                    this.EmailCommunicationSequencePostcardUuid == input.EmailCommunicationSequencePostcardUuid ||
                    (this.EmailCommunicationSequencePostcardUuid != null &&
                    this.EmailCommunicationSequencePostcardUuid.Equals(input.EmailCommunicationSequencePostcardUuid))
                ) && 
                (
                    this.FilterProfileEquationJson == input.FilterProfileEquationJson ||
                    (this.FilterProfileEquationJson != null &&
                    this.FilterProfileEquationJson.Equals(input.FilterProfileEquationJson))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PostcardBackContainerCjson == input.PostcardBackContainerCjson ||
                    (this.PostcardBackContainerCjson != null &&
                    this.PostcardBackContainerCjson.Equals(input.PostcardBackContainerCjson))
                ) && 
                (
                    this.PostcardBackContainerUuid == input.PostcardBackContainerUuid ||
                    (this.PostcardBackContainerUuid != null &&
                    this.PostcardBackContainerUuid.Equals(input.PostcardBackContainerUuid))
                ) && 
                (
                    this.PostcardContainerCjsonLastModifiedDts == input.PostcardContainerCjsonLastModifiedDts ||
                    (this.PostcardContainerCjsonLastModifiedDts != null &&
                    this.PostcardContainerCjsonLastModifiedDts.Equals(input.PostcardContainerCjsonLastModifiedDts))
                ) && 
                (
                    this.PostcardFrontContainerCjson == input.PostcardFrontContainerCjson ||
                    (this.PostcardFrontContainerCjson != null &&
                    this.PostcardFrontContainerCjson.Equals(input.PostcardFrontContainerCjson))
                ) && 
                (
                    this.PostcardFrontContainerUuid == input.PostcardFrontContainerUuid ||
                    (this.PostcardFrontContainerUuid != null &&
                    this.PostcardFrontContainerUuid.Equals(input.PostcardFrontContainerUuid))
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
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.EditedByUser != null)
                    hashCode = hashCode * 59 + this.EditedByUser.GetHashCode();
                if (this.EmailCommunicationSequencePostcardUuid != null)
                    hashCode = hashCode * 59 + this.EmailCommunicationSequencePostcardUuid.GetHashCode();
                if (this.FilterProfileEquationJson != null)
                    hashCode = hashCode * 59 + this.FilterProfileEquationJson.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.PostcardBackContainerCjson != null)
                    hashCode = hashCode * 59 + this.PostcardBackContainerCjson.GetHashCode();
                if (this.PostcardBackContainerUuid != null)
                    hashCode = hashCode * 59 + this.PostcardBackContainerUuid.GetHashCode();
                if (this.PostcardContainerCjsonLastModifiedDts != null)
                    hashCode = hashCode * 59 + this.PostcardContainerCjsonLastModifiedDts.GetHashCode();
                if (this.PostcardFrontContainerCjson != null)
                    hashCode = hashCode * 59 + this.PostcardFrontContainerCjson.GetHashCode();
                if (this.PostcardFrontContainerUuid != null)
                    hashCode = hashCode * 59 + this.PostcardFrontContainerUuid.GetHashCode();
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
            yield break;
        }
    }

}

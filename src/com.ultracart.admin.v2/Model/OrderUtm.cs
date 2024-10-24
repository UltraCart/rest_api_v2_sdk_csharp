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
    /// OrderUtm
    /// </summary>
    [DataContract]
    public partial class OrderUtm :  IEquatable<OrderUtm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUtm" /> class.
        /// </summary>
        /// <param name="attributionFirstClickSubtotal">attributionFirstClickSubtotal.</param>
        /// <param name="attributionFirstClickTotal">attributionFirstClickTotal.</param>
        /// <param name="attributionLastClickSubtotal">attributionLastClickSubtotal.</param>
        /// <param name="attributionLastClickTotal">attributionLastClickTotal.</param>
        /// <param name="attributionLinearSubtotal">attributionLinearSubtotal.</param>
        /// <param name="attributionLinearTotal">attributionLinearTotal.</param>
        /// <param name="attributionPositionBasedSubtotal">attributionPositionBasedSubtotal.</param>
        /// <param name="attributionPositionBasedTotal">attributionPositionBasedTotal.</param>
        /// <param name="clickDts">Date/time that the click happened.</param>
        /// <param name="facebookAdId">facebookAdId.</param>
        /// <param name="fbclid">fbclid.</param>
        /// <param name="gbraid">gbraid.</param>
        /// <param name="glcid">glcid.</param>
        /// <param name="itmCampaign">itmCampaign.</param>
        /// <param name="itmContent">itmContent.</param>
        /// <param name="itmId">itmId.</param>
        /// <param name="itmMedium">itmMedium.</param>
        /// <param name="itmSource">itmSource.</param>
        /// <param name="itmTerm">itmTerm.</param>
        /// <param name="msclkid">msclkid.</param>
        /// <param name="shortCode">shortCode.</param>
        /// <param name="shortCodeBackup">shortCodeBackup.</param>
        /// <param name="ttclid">ttclid.</param>
        /// <param name="ucMessageId">ucMessageId.</param>
        /// <param name="utmCampaign">utmCampaign.</param>
        /// <param name="utmContent">utmContent.</param>
        /// <param name="utmId">utmId.</param>
        /// <param name="utmMedium">utmMedium.</param>
        /// <param name="utmSource">utmSource.</param>
        /// <param name="utmTerm">utmTerm.</param>
        /// <param name="vmcid">vmcid.</param>
        /// <param name="wbraid">wbraid.</param>
        public OrderUtm(decimal? attributionFirstClickSubtotal = default(decimal?), decimal? attributionFirstClickTotal = default(decimal?), decimal? attributionLastClickSubtotal = default(decimal?), decimal? attributionLastClickTotal = default(decimal?), decimal? attributionLinearSubtotal = default(decimal?), decimal? attributionLinearTotal = default(decimal?), decimal? attributionPositionBasedSubtotal = default(decimal?), decimal? attributionPositionBasedTotal = default(decimal?), string clickDts = default(string), string facebookAdId = default(string), string fbclid = default(string), string gbraid = default(string), string glcid = default(string), string itmCampaign = default(string), string itmContent = default(string), string itmId = default(string), string itmMedium = default(string), string itmSource = default(string), string itmTerm = default(string), string msclkid = default(string), string shortCode = default(string), bool? shortCodeBackup = default(bool?), string ttclid = default(string), string ucMessageId = default(string), string utmCampaign = default(string), string utmContent = default(string), string utmId = default(string), string utmMedium = default(string), string utmSource = default(string), string utmTerm = default(string), string vmcid = default(string), string wbraid = default(string))
        {
            this.AttributionFirstClickSubtotal = attributionFirstClickSubtotal;
            this.AttributionFirstClickTotal = attributionFirstClickTotal;
            this.AttributionLastClickSubtotal = attributionLastClickSubtotal;
            this.AttributionLastClickTotal = attributionLastClickTotal;
            this.AttributionLinearSubtotal = attributionLinearSubtotal;
            this.AttributionLinearTotal = attributionLinearTotal;
            this.AttributionPositionBasedSubtotal = attributionPositionBasedSubtotal;
            this.AttributionPositionBasedTotal = attributionPositionBasedTotal;
            this.ClickDts = clickDts;
            this.FacebookAdId = facebookAdId;
            this.Fbclid = fbclid;
            this.Gbraid = gbraid;
            this.Glcid = glcid;
            this.ItmCampaign = itmCampaign;
            this.ItmContent = itmContent;
            this.ItmId = itmId;
            this.ItmMedium = itmMedium;
            this.ItmSource = itmSource;
            this.ItmTerm = itmTerm;
            this.Msclkid = msclkid;
            this.ShortCode = shortCode;
            this.ShortCodeBackup = shortCodeBackup;
            this.Ttclid = ttclid;
            this.UcMessageId = ucMessageId;
            this.UtmCampaign = utmCampaign;
            this.UtmContent = utmContent;
            this.UtmId = utmId;
            this.UtmMedium = utmMedium;
            this.UtmSource = utmSource;
            this.UtmTerm = utmTerm;
            this.Vmcid = vmcid;
            this.Wbraid = wbraid;
        }
        
        /// <summary>
        /// Gets or Sets AttributionFirstClickSubtotal
        /// </summary>
        [DataMember(Name="attribution_first_click_subtotal", EmitDefaultValue=false)]
        public decimal? AttributionFirstClickSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionFirstClickTotal
        /// </summary>
        [DataMember(Name="attribution_first_click_total", EmitDefaultValue=false)]
        public decimal? AttributionFirstClickTotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionLastClickSubtotal
        /// </summary>
        [DataMember(Name="attribution_last_click_subtotal", EmitDefaultValue=false)]
        public decimal? AttributionLastClickSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionLastClickTotal
        /// </summary>
        [DataMember(Name="attribution_last_click_total", EmitDefaultValue=false)]
        public decimal? AttributionLastClickTotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionLinearSubtotal
        /// </summary>
        [DataMember(Name="attribution_linear_subtotal", EmitDefaultValue=false)]
        public decimal? AttributionLinearSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionLinearTotal
        /// </summary>
        [DataMember(Name="attribution_linear_total", EmitDefaultValue=false)]
        public decimal? AttributionLinearTotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionPositionBasedSubtotal
        /// </summary>
        [DataMember(Name="attribution_position_based_subtotal", EmitDefaultValue=false)]
        public decimal? AttributionPositionBasedSubtotal { get; set; }

        /// <summary>
        /// Gets or Sets AttributionPositionBasedTotal
        /// </summary>
        [DataMember(Name="attribution_position_based_total", EmitDefaultValue=false)]
        public decimal? AttributionPositionBasedTotal { get; set; }

        /// <summary>
        /// Date/time that the click happened
        /// </summary>
        /// <value>Date/time that the click happened</value>
        [DataMember(Name="click_dts", EmitDefaultValue=false)]
        public string ClickDts { get; set; }

        /// <summary>
        /// Gets or Sets FacebookAdId
        /// </summary>
        [DataMember(Name="facebook_ad_id", EmitDefaultValue=false)]
        public string FacebookAdId { get; set; }

        /// <summary>
        /// Gets or Sets Fbclid
        /// </summary>
        [DataMember(Name="fbclid", EmitDefaultValue=false)]
        public string Fbclid { get; set; }

        /// <summary>
        /// Gets or Sets Gbraid
        /// </summary>
        [DataMember(Name="gbraid", EmitDefaultValue=false)]
        public string Gbraid { get; set; }

        /// <summary>
        /// Gets or Sets Glcid
        /// </summary>
        [DataMember(Name="glcid", EmitDefaultValue=false)]
        public string Glcid { get; set; }

        /// <summary>
        /// Gets or Sets ItmCampaign
        /// </summary>
        [DataMember(Name="itm_campaign", EmitDefaultValue=false)]
        public string ItmCampaign { get; set; }

        /// <summary>
        /// Gets or Sets ItmContent
        /// </summary>
        [DataMember(Name="itm_content", EmitDefaultValue=false)]
        public string ItmContent { get; set; }

        /// <summary>
        /// Gets or Sets ItmId
        /// </summary>
        [DataMember(Name="itm_id", EmitDefaultValue=false)]
        public string ItmId { get; set; }

        /// <summary>
        /// Gets or Sets ItmMedium
        /// </summary>
        [DataMember(Name="itm_medium", EmitDefaultValue=false)]
        public string ItmMedium { get; set; }

        /// <summary>
        /// Gets or Sets ItmSource
        /// </summary>
        [DataMember(Name="itm_source", EmitDefaultValue=false)]
        public string ItmSource { get; set; }

        /// <summary>
        /// Gets or Sets ItmTerm
        /// </summary>
        [DataMember(Name="itm_term", EmitDefaultValue=false)]
        public string ItmTerm { get; set; }

        /// <summary>
        /// Gets or Sets Msclkid
        /// </summary>
        [DataMember(Name="msclkid", EmitDefaultValue=false)]
        public string Msclkid { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name="short_code", EmitDefaultValue=false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or Sets ShortCodeBackup
        /// </summary>
        [DataMember(Name="short_code_backup", EmitDefaultValue=false)]
        public bool? ShortCodeBackup { get; set; }

        /// <summary>
        /// Gets or Sets Ttclid
        /// </summary>
        [DataMember(Name="ttclid", EmitDefaultValue=false)]
        public string Ttclid { get; set; }

        /// <summary>
        /// Gets or Sets UcMessageId
        /// </summary>
        [DataMember(Name="uc_message_id", EmitDefaultValue=false)]
        public string UcMessageId { get; set; }

        /// <summary>
        /// Gets or Sets UtmCampaign
        /// </summary>
        [DataMember(Name="utm_campaign", EmitDefaultValue=false)]
        public string UtmCampaign { get; set; }

        /// <summary>
        /// Gets or Sets UtmContent
        /// </summary>
        [DataMember(Name="utm_content", EmitDefaultValue=false)]
        public string UtmContent { get; set; }

        /// <summary>
        /// Gets or Sets UtmId
        /// </summary>
        [DataMember(Name="utm_id", EmitDefaultValue=false)]
        public string UtmId { get; set; }

        /// <summary>
        /// Gets or Sets UtmMedium
        /// </summary>
        [DataMember(Name="utm_medium", EmitDefaultValue=false)]
        public string UtmMedium { get; set; }

        /// <summary>
        /// Gets or Sets UtmSource
        /// </summary>
        [DataMember(Name="utm_source", EmitDefaultValue=false)]
        public string UtmSource { get; set; }

        /// <summary>
        /// Gets or Sets UtmTerm
        /// </summary>
        [DataMember(Name="utm_term", EmitDefaultValue=false)]
        public string UtmTerm { get; set; }

        /// <summary>
        /// Gets or Sets Vmcid
        /// </summary>
        [DataMember(Name="vmcid", EmitDefaultValue=false)]
        public string Vmcid { get; set; }

        /// <summary>
        /// Gets or Sets Wbraid
        /// </summary>
        [DataMember(Name="wbraid", EmitDefaultValue=false)]
        public string Wbraid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderUtm {\n");
            sb.Append("  AttributionFirstClickSubtotal: ").Append(AttributionFirstClickSubtotal).Append("\n");
            sb.Append("  AttributionFirstClickTotal: ").Append(AttributionFirstClickTotal).Append("\n");
            sb.Append("  AttributionLastClickSubtotal: ").Append(AttributionLastClickSubtotal).Append("\n");
            sb.Append("  AttributionLastClickTotal: ").Append(AttributionLastClickTotal).Append("\n");
            sb.Append("  AttributionLinearSubtotal: ").Append(AttributionLinearSubtotal).Append("\n");
            sb.Append("  AttributionLinearTotal: ").Append(AttributionLinearTotal).Append("\n");
            sb.Append("  AttributionPositionBasedSubtotal: ").Append(AttributionPositionBasedSubtotal).Append("\n");
            sb.Append("  AttributionPositionBasedTotal: ").Append(AttributionPositionBasedTotal).Append("\n");
            sb.Append("  ClickDts: ").Append(ClickDts).Append("\n");
            sb.Append("  FacebookAdId: ").Append(FacebookAdId).Append("\n");
            sb.Append("  Fbclid: ").Append(Fbclid).Append("\n");
            sb.Append("  Gbraid: ").Append(Gbraid).Append("\n");
            sb.Append("  Glcid: ").Append(Glcid).Append("\n");
            sb.Append("  ItmCampaign: ").Append(ItmCampaign).Append("\n");
            sb.Append("  ItmContent: ").Append(ItmContent).Append("\n");
            sb.Append("  ItmId: ").Append(ItmId).Append("\n");
            sb.Append("  ItmMedium: ").Append(ItmMedium).Append("\n");
            sb.Append("  ItmSource: ").Append(ItmSource).Append("\n");
            sb.Append("  ItmTerm: ").Append(ItmTerm).Append("\n");
            sb.Append("  Msclkid: ").Append(Msclkid).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  ShortCodeBackup: ").Append(ShortCodeBackup).Append("\n");
            sb.Append("  Ttclid: ").Append(Ttclid).Append("\n");
            sb.Append("  UcMessageId: ").Append(UcMessageId).Append("\n");
            sb.Append("  UtmCampaign: ").Append(UtmCampaign).Append("\n");
            sb.Append("  UtmContent: ").Append(UtmContent).Append("\n");
            sb.Append("  UtmId: ").Append(UtmId).Append("\n");
            sb.Append("  UtmMedium: ").Append(UtmMedium).Append("\n");
            sb.Append("  UtmSource: ").Append(UtmSource).Append("\n");
            sb.Append("  UtmTerm: ").Append(UtmTerm).Append("\n");
            sb.Append("  Vmcid: ").Append(Vmcid).Append("\n");
            sb.Append("  Wbraid: ").Append(Wbraid).Append("\n");
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
            return this.Equals(input as OrderUtm);
        }

        /// <summary>
        /// Returns true if OrderUtm instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderUtm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderUtm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributionFirstClickSubtotal == input.AttributionFirstClickSubtotal ||
                    (this.AttributionFirstClickSubtotal != null &&
                    this.AttributionFirstClickSubtotal.Equals(input.AttributionFirstClickSubtotal))
                ) && 
                (
                    this.AttributionFirstClickTotal == input.AttributionFirstClickTotal ||
                    (this.AttributionFirstClickTotal != null &&
                    this.AttributionFirstClickTotal.Equals(input.AttributionFirstClickTotal))
                ) && 
                (
                    this.AttributionLastClickSubtotal == input.AttributionLastClickSubtotal ||
                    (this.AttributionLastClickSubtotal != null &&
                    this.AttributionLastClickSubtotal.Equals(input.AttributionLastClickSubtotal))
                ) && 
                (
                    this.AttributionLastClickTotal == input.AttributionLastClickTotal ||
                    (this.AttributionLastClickTotal != null &&
                    this.AttributionLastClickTotal.Equals(input.AttributionLastClickTotal))
                ) && 
                (
                    this.AttributionLinearSubtotal == input.AttributionLinearSubtotal ||
                    (this.AttributionLinearSubtotal != null &&
                    this.AttributionLinearSubtotal.Equals(input.AttributionLinearSubtotal))
                ) && 
                (
                    this.AttributionLinearTotal == input.AttributionLinearTotal ||
                    (this.AttributionLinearTotal != null &&
                    this.AttributionLinearTotal.Equals(input.AttributionLinearTotal))
                ) && 
                (
                    this.AttributionPositionBasedSubtotal == input.AttributionPositionBasedSubtotal ||
                    (this.AttributionPositionBasedSubtotal != null &&
                    this.AttributionPositionBasedSubtotal.Equals(input.AttributionPositionBasedSubtotal))
                ) && 
                (
                    this.AttributionPositionBasedTotal == input.AttributionPositionBasedTotal ||
                    (this.AttributionPositionBasedTotal != null &&
                    this.AttributionPositionBasedTotal.Equals(input.AttributionPositionBasedTotal))
                ) && 
                (
                    this.ClickDts == input.ClickDts ||
                    (this.ClickDts != null &&
                    this.ClickDts.Equals(input.ClickDts))
                ) && 
                (
                    this.FacebookAdId == input.FacebookAdId ||
                    (this.FacebookAdId != null &&
                    this.FacebookAdId.Equals(input.FacebookAdId))
                ) && 
                (
                    this.Fbclid == input.Fbclid ||
                    (this.Fbclid != null &&
                    this.Fbclid.Equals(input.Fbclid))
                ) && 
                (
                    this.Gbraid == input.Gbraid ||
                    (this.Gbraid != null &&
                    this.Gbraid.Equals(input.Gbraid))
                ) && 
                (
                    this.Glcid == input.Glcid ||
                    (this.Glcid != null &&
                    this.Glcid.Equals(input.Glcid))
                ) && 
                (
                    this.ItmCampaign == input.ItmCampaign ||
                    (this.ItmCampaign != null &&
                    this.ItmCampaign.Equals(input.ItmCampaign))
                ) && 
                (
                    this.ItmContent == input.ItmContent ||
                    (this.ItmContent != null &&
                    this.ItmContent.Equals(input.ItmContent))
                ) && 
                (
                    this.ItmId == input.ItmId ||
                    (this.ItmId != null &&
                    this.ItmId.Equals(input.ItmId))
                ) && 
                (
                    this.ItmMedium == input.ItmMedium ||
                    (this.ItmMedium != null &&
                    this.ItmMedium.Equals(input.ItmMedium))
                ) && 
                (
                    this.ItmSource == input.ItmSource ||
                    (this.ItmSource != null &&
                    this.ItmSource.Equals(input.ItmSource))
                ) && 
                (
                    this.ItmTerm == input.ItmTerm ||
                    (this.ItmTerm != null &&
                    this.ItmTerm.Equals(input.ItmTerm))
                ) && 
                (
                    this.Msclkid == input.Msclkid ||
                    (this.Msclkid != null &&
                    this.Msclkid.Equals(input.Msclkid))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.ShortCodeBackup == input.ShortCodeBackup ||
                    (this.ShortCodeBackup != null &&
                    this.ShortCodeBackup.Equals(input.ShortCodeBackup))
                ) && 
                (
                    this.Ttclid == input.Ttclid ||
                    (this.Ttclid != null &&
                    this.Ttclid.Equals(input.Ttclid))
                ) && 
                (
                    this.UcMessageId == input.UcMessageId ||
                    (this.UcMessageId != null &&
                    this.UcMessageId.Equals(input.UcMessageId))
                ) && 
                (
                    this.UtmCampaign == input.UtmCampaign ||
                    (this.UtmCampaign != null &&
                    this.UtmCampaign.Equals(input.UtmCampaign))
                ) && 
                (
                    this.UtmContent == input.UtmContent ||
                    (this.UtmContent != null &&
                    this.UtmContent.Equals(input.UtmContent))
                ) && 
                (
                    this.UtmId == input.UtmId ||
                    (this.UtmId != null &&
                    this.UtmId.Equals(input.UtmId))
                ) && 
                (
                    this.UtmMedium == input.UtmMedium ||
                    (this.UtmMedium != null &&
                    this.UtmMedium.Equals(input.UtmMedium))
                ) && 
                (
                    this.UtmSource == input.UtmSource ||
                    (this.UtmSource != null &&
                    this.UtmSource.Equals(input.UtmSource))
                ) && 
                (
                    this.UtmTerm == input.UtmTerm ||
                    (this.UtmTerm != null &&
                    this.UtmTerm.Equals(input.UtmTerm))
                ) && 
                (
                    this.Vmcid == input.Vmcid ||
                    (this.Vmcid != null &&
                    this.Vmcid.Equals(input.Vmcid))
                ) && 
                (
                    this.Wbraid == input.Wbraid ||
                    (this.Wbraid != null &&
                    this.Wbraid.Equals(input.Wbraid))
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
                if (this.AttributionFirstClickSubtotal != null)
                    hashCode = hashCode * 59 + this.AttributionFirstClickSubtotal.GetHashCode();
                if (this.AttributionFirstClickTotal != null)
                    hashCode = hashCode * 59 + this.AttributionFirstClickTotal.GetHashCode();
                if (this.AttributionLastClickSubtotal != null)
                    hashCode = hashCode * 59 + this.AttributionLastClickSubtotal.GetHashCode();
                if (this.AttributionLastClickTotal != null)
                    hashCode = hashCode * 59 + this.AttributionLastClickTotal.GetHashCode();
                if (this.AttributionLinearSubtotal != null)
                    hashCode = hashCode * 59 + this.AttributionLinearSubtotal.GetHashCode();
                if (this.AttributionLinearTotal != null)
                    hashCode = hashCode * 59 + this.AttributionLinearTotal.GetHashCode();
                if (this.AttributionPositionBasedSubtotal != null)
                    hashCode = hashCode * 59 + this.AttributionPositionBasedSubtotal.GetHashCode();
                if (this.AttributionPositionBasedTotal != null)
                    hashCode = hashCode * 59 + this.AttributionPositionBasedTotal.GetHashCode();
                if (this.ClickDts != null)
                    hashCode = hashCode * 59 + this.ClickDts.GetHashCode();
                if (this.FacebookAdId != null)
                    hashCode = hashCode * 59 + this.FacebookAdId.GetHashCode();
                if (this.Fbclid != null)
                    hashCode = hashCode * 59 + this.Fbclid.GetHashCode();
                if (this.Gbraid != null)
                    hashCode = hashCode * 59 + this.Gbraid.GetHashCode();
                if (this.Glcid != null)
                    hashCode = hashCode * 59 + this.Glcid.GetHashCode();
                if (this.ItmCampaign != null)
                    hashCode = hashCode * 59 + this.ItmCampaign.GetHashCode();
                if (this.ItmContent != null)
                    hashCode = hashCode * 59 + this.ItmContent.GetHashCode();
                if (this.ItmId != null)
                    hashCode = hashCode * 59 + this.ItmId.GetHashCode();
                if (this.ItmMedium != null)
                    hashCode = hashCode * 59 + this.ItmMedium.GetHashCode();
                if (this.ItmSource != null)
                    hashCode = hashCode * 59 + this.ItmSource.GetHashCode();
                if (this.ItmTerm != null)
                    hashCode = hashCode * 59 + this.ItmTerm.GetHashCode();
                if (this.Msclkid != null)
                    hashCode = hashCode * 59 + this.Msclkid.GetHashCode();
                if (this.ShortCode != null)
                    hashCode = hashCode * 59 + this.ShortCode.GetHashCode();
                if (this.ShortCodeBackup != null)
                    hashCode = hashCode * 59 + this.ShortCodeBackup.GetHashCode();
                if (this.Ttclid != null)
                    hashCode = hashCode * 59 + this.Ttclid.GetHashCode();
                if (this.UcMessageId != null)
                    hashCode = hashCode * 59 + this.UcMessageId.GetHashCode();
                if (this.UtmCampaign != null)
                    hashCode = hashCode * 59 + this.UtmCampaign.GetHashCode();
                if (this.UtmContent != null)
                    hashCode = hashCode * 59 + this.UtmContent.GetHashCode();
                if (this.UtmId != null)
                    hashCode = hashCode * 59 + this.UtmId.GetHashCode();
                if (this.UtmMedium != null)
                    hashCode = hashCode * 59 + this.UtmMedium.GetHashCode();
                if (this.UtmSource != null)
                    hashCode = hashCode * 59 + this.UtmSource.GetHashCode();
                if (this.UtmTerm != null)
                    hashCode = hashCode * 59 + this.UtmTerm.GetHashCode();
                if (this.Vmcid != null)
                    hashCode = hashCode * 59 + this.Vmcid.GetHashCode();
                if (this.Wbraid != null)
                    hashCode = hashCode * 59 + this.Wbraid.GetHashCode();
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

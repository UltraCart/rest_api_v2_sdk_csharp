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
    /// ItemChannelPartnerMapping
    /// </summary>
    [DataContract]
    public partial class ItemChannelPartnerMapping :  IEquatable<ItemChannelPartnerMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemChannelPartnerMapping" /> class.
        /// </summary>
        /// <param name="BarcodeUa">Barcode UA (EDI only).</param>
        /// <param name="BarcodeUc">Barcode UC (EDI only).</param>
        /// <param name="BarcodeUi">Barcode UI (EDI only).</param>
        /// <param name="BarcodeUk">Barcode UK (EDI only).</param>
        /// <param name="BuyerCatalogNumber">Buyer catalog number (EDI only).</param>
        /// <param name="BuyerDpci">Buyer DPCI (EDI only).</param>
        /// <param name="BuyerItemNumber">Buyer item number (EDI only).</param>
        /// <param name="ChannelPartnerCode">Channel partner code.</param>
        /// <param name="ChannelPartnerOid">Channel partner object identifier.</param>
        /// <param name="FromItemId">From Item ID.</param>
        /// <param name="FromSku">From SKU.</param>
        /// <param name="MutuallyDefinedNumber">Mutually defined number (EDI only).</param>
        /// <param name="QuantityRatioCp">Ratio (Channel Partner).</param>
        /// <param name="QuantityRatioUc">Ratio (UltraCart).</param>
        /// <param name="Sku">SKU.</param>
        /// <param name="UnitOfMeasure">Unit of measure.</param>
        /// <param name="VendorNumber">Vendor number (EDI only).</param>
        /// <param name="VendorStyleNumber">Vendor style number (EDI only).</param>
        public ItemChannelPartnerMapping(string BarcodeUa = default(string), string BarcodeUc = default(string), string BarcodeUi = default(string), string BarcodeUk = default(string), string BuyerCatalogNumber = default(string), string BuyerDpci = default(string), string BuyerItemNumber = default(string), string ChannelPartnerCode = default(string), int? ChannelPartnerOid = default(int?), string FromItemId = default(string), string FromSku = default(string), string MutuallyDefinedNumber = default(string), int? QuantityRatioCp = default(int?), int? QuantityRatioUc = default(int?), string Sku = default(string), string UnitOfMeasure = default(string), string VendorNumber = default(string), string VendorStyleNumber = default(string))
        {
            this.BarcodeUa = BarcodeUa;
            this.BarcodeUc = BarcodeUc;
            this.BarcodeUi = BarcodeUi;
            this.BarcodeUk = BarcodeUk;
            this.BuyerCatalogNumber = BuyerCatalogNumber;
            this.BuyerDpci = BuyerDpci;
            this.BuyerItemNumber = BuyerItemNumber;
            this.ChannelPartnerCode = ChannelPartnerCode;
            this.ChannelPartnerOid = ChannelPartnerOid;
            this.FromItemId = FromItemId;
            this.FromSku = FromSku;
            this.MutuallyDefinedNumber = MutuallyDefinedNumber;
            this.QuantityRatioCp = QuantityRatioCp;
            this.QuantityRatioUc = QuantityRatioUc;
            this.Sku = Sku;
            this.UnitOfMeasure = UnitOfMeasure;
            this.VendorNumber = VendorNumber;
            this.VendorStyleNumber = VendorStyleNumber;
        }
        
        /// <summary>
        /// Barcode UA (EDI only)
        /// </summary>
        /// <value>Barcode UA (EDI only)</value>
        [DataMember(Name="barcode_ua", EmitDefaultValue=false)]
        public string BarcodeUa { get; set; }

        /// <summary>
        /// Barcode UC (EDI only)
        /// </summary>
        /// <value>Barcode UC (EDI only)</value>
        [DataMember(Name="barcode_uc", EmitDefaultValue=false)]
        public string BarcodeUc { get; set; }

        /// <summary>
        /// Barcode UI (EDI only)
        /// </summary>
        /// <value>Barcode UI (EDI only)</value>
        [DataMember(Name="barcode_ui", EmitDefaultValue=false)]
        public string BarcodeUi { get; set; }

        /// <summary>
        /// Barcode UK (EDI only)
        /// </summary>
        /// <value>Barcode UK (EDI only)</value>
        [DataMember(Name="barcode_uk", EmitDefaultValue=false)]
        public string BarcodeUk { get; set; }

        /// <summary>
        /// Buyer catalog number (EDI only)
        /// </summary>
        /// <value>Buyer catalog number (EDI only)</value>
        [DataMember(Name="buyer_catalog_number", EmitDefaultValue=false)]
        public string BuyerCatalogNumber { get; set; }

        /// <summary>
        /// Buyer DPCI (EDI only)
        /// </summary>
        /// <value>Buyer DPCI (EDI only)</value>
        [DataMember(Name="buyer_dpci", EmitDefaultValue=false)]
        public string BuyerDpci { get; set; }

        /// <summary>
        /// Buyer item number (EDI only)
        /// </summary>
        /// <value>Buyer item number (EDI only)</value>
        [DataMember(Name="buyer_item_number", EmitDefaultValue=false)]
        public string BuyerItemNumber { get; set; }

        /// <summary>
        /// Channel partner code
        /// </summary>
        /// <value>Channel partner code</value>
        [DataMember(Name="channel_partner_code", EmitDefaultValue=false)]
        public string ChannelPartnerCode { get; set; }

        /// <summary>
        /// Channel partner object identifier
        /// </summary>
        /// <value>Channel partner object identifier</value>
        [DataMember(Name="channel_partner_oid", EmitDefaultValue=false)]
        public int? ChannelPartnerOid { get; set; }

        /// <summary>
        /// From Item ID
        /// </summary>
        /// <value>From Item ID</value>
        [DataMember(Name="from_item_id", EmitDefaultValue=false)]
        public string FromItemId { get; set; }

        /// <summary>
        /// From SKU
        /// </summary>
        /// <value>From SKU</value>
        [DataMember(Name="from_sku", EmitDefaultValue=false)]
        public string FromSku { get; set; }

        /// <summary>
        /// Mutually defined number (EDI only)
        /// </summary>
        /// <value>Mutually defined number (EDI only)</value>
        [DataMember(Name="mutually_defined_number", EmitDefaultValue=false)]
        public string MutuallyDefinedNumber { get; set; }

        /// <summary>
        /// Ratio (Channel Partner)
        /// </summary>
        /// <value>Ratio (Channel Partner)</value>
        [DataMember(Name="quantity_ratio_cp", EmitDefaultValue=false)]
        public int? QuantityRatioCp { get; set; }

        /// <summary>
        /// Ratio (UltraCart)
        /// </summary>
        /// <value>Ratio (UltraCart)</value>
        [DataMember(Name="quantity_ratio_uc", EmitDefaultValue=false)]
        public int? QuantityRatioUc { get; set; }

        /// <summary>
        /// SKU
        /// </summary>
        /// <value>SKU</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Vendor number (EDI only)
        /// </summary>
        /// <value>Vendor number (EDI only)</value>
        [DataMember(Name="vendor_number", EmitDefaultValue=false)]
        public string VendorNumber { get; set; }

        /// <summary>
        /// Vendor style number (EDI only)
        /// </summary>
        /// <value>Vendor style number (EDI only)</value>
        [DataMember(Name="vendor_style_number", EmitDefaultValue=false)]
        public string VendorStyleNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemChannelPartnerMapping {\n");
            sb.Append("  BarcodeUa: ").Append(BarcodeUa).Append("\n");
            sb.Append("  BarcodeUc: ").Append(BarcodeUc).Append("\n");
            sb.Append("  BarcodeUi: ").Append(BarcodeUi).Append("\n");
            sb.Append("  BarcodeUk: ").Append(BarcodeUk).Append("\n");
            sb.Append("  BuyerCatalogNumber: ").Append(BuyerCatalogNumber).Append("\n");
            sb.Append("  BuyerDpci: ").Append(BuyerDpci).Append("\n");
            sb.Append("  BuyerItemNumber: ").Append(BuyerItemNumber).Append("\n");
            sb.Append("  ChannelPartnerCode: ").Append(ChannelPartnerCode).Append("\n");
            sb.Append("  ChannelPartnerOid: ").Append(ChannelPartnerOid).Append("\n");
            sb.Append("  FromItemId: ").Append(FromItemId).Append("\n");
            sb.Append("  FromSku: ").Append(FromSku).Append("\n");
            sb.Append("  MutuallyDefinedNumber: ").Append(MutuallyDefinedNumber).Append("\n");
            sb.Append("  QuantityRatioCp: ").Append(QuantityRatioCp).Append("\n");
            sb.Append("  QuantityRatioUc: ").Append(QuantityRatioUc).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  VendorNumber: ").Append(VendorNumber).Append("\n");
            sb.Append("  VendorStyleNumber: ").Append(VendorStyleNumber).Append("\n");
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
            return this.Equals(input as ItemChannelPartnerMapping);
        }

        /// <summary>
        /// Returns true if ItemChannelPartnerMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemChannelPartnerMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemChannelPartnerMapping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BarcodeUa == input.BarcodeUa ||
                    (this.BarcodeUa != null &&
                    this.BarcodeUa.Equals(input.BarcodeUa))
                ) && 
                (
                    this.BarcodeUc == input.BarcodeUc ||
                    (this.BarcodeUc != null &&
                    this.BarcodeUc.Equals(input.BarcodeUc))
                ) && 
                (
                    this.BarcodeUi == input.BarcodeUi ||
                    (this.BarcodeUi != null &&
                    this.BarcodeUi.Equals(input.BarcodeUi))
                ) && 
                (
                    this.BarcodeUk == input.BarcodeUk ||
                    (this.BarcodeUk != null &&
                    this.BarcodeUk.Equals(input.BarcodeUk))
                ) && 
                (
                    this.BuyerCatalogNumber == input.BuyerCatalogNumber ||
                    (this.BuyerCatalogNumber != null &&
                    this.BuyerCatalogNumber.Equals(input.BuyerCatalogNumber))
                ) && 
                (
                    this.BuyerDpci == input.BuyerDpci ||
                    (this.BuyerDpci != null &&
                    this.BuyerDpci.Equals(input.BuyerDpci))
                ) && 
                (
                    this.BuyerItemNumber == input.BuyerItemNumber ||
                    (this.BuyerItemNumber != null &&
                    this.BuyerItemNumber.Equals(input.BuyerItemNumber))
                ) && 
                (
                    this.ChannelPartnerCode == input.ChannelPartnerCode ||
                    (this.ChannelPartnerCode != null &&
                    this.ChannelPartnerCode.Equals(input.ChannelPartnerCode))
                ) && 
                (
                    this.ChannelPartnerOid == input.ChannelPartnerOid ||
                    (this.ChannelPartnerOid != null &&
                    this.ChannelPartnerOid.Equals(input.ChannelPartnerOid))
                ) && 
                (
                    this.FromItemId == input.FromItemId ||
                    (this.FromItemId != null &&
                    this.FromItemId.Equals(input.FromItemId))
                ) && 
                (
                    this.FromSku == input.FromSku ||
                    (this.FromSku != null &&
                    this.FromSku.Equals(input.FromSku))
                ) && 
                (
                    this.MutuallyDefinedNumber == input.MutuallyDefinedNumber ||
                    (this.MutuallyDefinedNumber != null &&
                    this.MutuallyDefinedNumber.Equals(input.MutuallyDefinedNumber))
                ) && 
                (
                    this.QuantityRatioCp == input.QuantityRatioCp ||
                    (this.QuantityRatioCp != null &&
                    this.QuantityRatioCp.Equals(input.QuantityRatioCp))
                ) && 
                (
                    this.QuantityRatioUc == input.QuantityRatioUc ||
                    (this.QuantityRatioUc != null &&
                    this.QuantityRatioUc.Equals(input.QuantityRatioUc))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.VendorNumber == input.VendorNumber ||
                    (this.VendorNumber != null &&
                    this.VendorNumber.Equals(input.VendorNumber))
                ) && 
                (
                    this.VendorStyleNumber == input.VendorStyleNumber ||
                    (this.VendorStyleNumber != null &&
                    this.VendorStyleNumber.Equals(input.VendorStyleNumber))
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
                if (this.BarcodeUa != null)
                    hashCode = hashCode * 59 + this.BarcodeUa.GetHashCode();
                if (this.BarcodeUc != null)
                    hashCode = hashCode * 59 + this.BarcodeUc.GetHashCode();
                if (this.BarcodeUi != null)
                    hashCode = hashCode * 59 + this.BarcodeUi.GetHashCode();
                if (this.BarcodeUk != null)
                    hashCode = hashCode * 59 + this.BarcodeUk.GetHashCode();
                if (this.BuyerCatalogNumber != null)
                    hashCode = hashCode * 59 + this.BuyerCatalogNumber.GetHashCode();
                if (this.BuyerDpci != null)
                    hashCode = hashCode * 59 + this.BuyerDpci.GetHashCode();
                if (this.BuyerItemNumber != null)
                    hashCode = hashCode * 59 + this.BuyerItemNumber.GetHashCode();
                if (this.ChannelPartnerCode != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerCode.GetHashCode();
                if (this.ChannelPartnerOid != null)
                    hashCode = hashCode * 59 + this.ChannelPartnerOid.GetHashCode();
                if (this.FromItemId != null)
                    hashCode = hashCode * 59 + this.FromItemId.GetHashCode();
                if (this.FromSku != null)
                    hashCode = hashCode * 59 + this.FromSku.GetHashCode();
                if (this.MutuallyDefinedNumber != null)
                    hashCode = hashCode * 59 + this.MutuallyDefinedNumber.GetHashCode();
                if (this.QuantityRatioCp != null)
                    hashCode = hashCode * 59 + this.QuantityRatioCp.GetHashCode();
                if (this.QuantityRatioUc != null)
                    hashCode = hashCode * 59 + this.QuantityRatioUc.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.VendorNumber != null)
                    hashCode = hashCode * 59 + this.VendorNumber.GetHashCode();
                if (this.VendorStyleNumber != null)
                    hashCode = hashCode * 59 + this.VendorStyleNumber.GetHashCode();
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
            // FromItemId (string) maxLength
            if(this.FromItemId != null && this.FromItemId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromItemId, length must be less than 30.", new [] { "FromItemId" });
            }

            // FromSku (string) maxLength
            if(this.FromSku != null && this.FromSku.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromSku, length must be less than 50.", new [] { "FromSku" });
            }

            // Sku (string) maxLength
            if(this.Sku != null && this.Sku.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sku, length must be less than 50.", new [] { "Sku" });
            }

            yield break;
        }
    }

}

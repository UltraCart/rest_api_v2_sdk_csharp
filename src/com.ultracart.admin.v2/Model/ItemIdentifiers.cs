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
    /// ItemIdentifiers
    /// </summary>
    [DataContract]
    public partial class ItemIdentifiers :  IEquatable<ItemIdentifiers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdentifiers" /> class.
        /// </summary>
        /// <param name="barcode">Barcode.</param>
        /// <param name="manufacturerName">Manufacturer Name.</param>
        /// <param name="manufacturerSku">Manufacturer SKU.</param>
        /// <param name="unspsc">UNSPSC.</param>
        public ItemIdentifiers(string barcode = default(string), string manufacturerName = default(string), string manufacturerSku = default(string), string unspsc = default(string))
        {
            this.Barcode = barcode;
            this.ManufacturerName = manufacturerName;
            this.ManufacturerSku = manufacturerSku;
            this.Unspsc = unspsc;
        }

        /// <summary>
        /// Barcode
        /// </summary>
        /// <value>Barcode</value>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// Manufacturer Name
        /// </summary>
        /// <value>Manufacturer Name</value>
        [DataMember(Name="manufacturer_name", EmitDefaultValue=false)]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// Manufacturer SKU
        /// </summary>
        /// <value>Manufacturer SKU</value>
        [DataMember(Name="manufacturer_sku", EmitDefaultValue=false)]
        public string ManufacturerSku { get; set; }

        /// <summary>
        /// UNSPSC
        /// </summary>
        /// <value>UNSPSC</value>
        [DataMember(Name="unspsc", EmitDefaultValue=false)]
        public string Unspsc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemIdentifiers {\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  ManufacturerName: ").Append(ManufacturerName).Append("\n");
            sb.Append("  ManufacturerSku: ").Append(ManufacturerSku).Append("\n");
            sb.Append("  Unspsc: ").Append(Unspsc).Append("\n");
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
            return this.Equals(input as ItemIdentifiers);
        }

        /// <summary>
        /// Returns true if ItemIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.ManufacturerName == input.ManufacturerName ||
                    (this.ManufacturerName != null &&
                    this.ManufacturerName.Equals(input.ManufacturerName))
                ) && 
                (
                    this.ManufacturerSku == input.ManufacturerSku ||
                    (this.ManufacturerSku != null &&
                    this.ManufacturerSku.Equals(input.ManufacturerSku))
                ) && 
                (
                    this.Unspsc == input.Unspsc ||
                    (this.Unspsc != null &&
                    this.Unspsc.Equals(input.Unspsc))
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
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.ManufacturerName != null)
                    hashCode = hashCode * 59 + this.ManufacturerName.GetHashCode();
                if (this.ManufacturerSku != null)
                    hashCode = hashCode * 59 + this.ManufacturerSku.GetHashCode();
                if (this.Unspsc != null)
                    hashCode = hashCode * 59 + this.Unspsc.GetHashCode();
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
            // Barcode (string) maxLength
            if(this.Barcode != null && this.Barcode.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Barcode, length must be less than 30.", new [] { "Barcode" });
            }


            // ManufacturerName (string) maxLength
            if(this.ManufacturerName != null && this.ManufacturerName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ManufacturerName, length must be less than 50.", new [] { "ManufacturerName" });
            }


            // ManufacturerSku (string) maxLength
            if(this.ManufacturerSku != null && this.ManufacturerSku.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ManufacturerSku, length must be less than 25.", new [] { "ManufacturerSku" });
            }


            // Unspsc (string) maxLength
            if(this.Unspsc != null && this.Unspsc.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Unspsc, length must be less than 20.", new [] { "Unspsc" });
            }


            yield break;
        }
    }

}

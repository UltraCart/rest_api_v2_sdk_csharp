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
    /// ItemDigitalItemPdfMeta
    /// </summary>
    [DataContract]
    public partial class ItemDigitalItemPdfMeta :  IEquatable<ItemDigitalItemPdfMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDigitalItemPdfMeta" /> class.
        /// </summary>
        /// <param name="assemblyAllowed">Assembly allowed.</param>
        /// <param name="copyAllowed">Copy/Paste is allowed.</param>
        /// <param name="customFooter">A custom footer for each pdf page.</param>
        /// <param name="customHeader">A custom header for each pdf page.</param>
        /// <param name="degradedPrintingAllowed">Degraded printing allowed.</param>
        /// <param name="fillinAllowed">Fillin is allowed.</param>
        /// <param name="modifyAnnotationsAllowed">Modifying annotations is allowed.</param>
        /// <param name="modifyContentsAllowed">Modifying contents is allowed.</param>
        /// <param name="printingAllowed">Printing is allowed.</param>
        /// <param name="screenReadersAllowed">Screen readers are allowed.</param>
        /// <param name="tagged">PDF is tagged.</param>
        public ItemDigitalItemPdfMeta(bool assemblyAllowed = default(bool), bool copyAllowed = default(bool), string customFooter = default(string), string customHeader = default(string), bool degradedPrintingAllowed = default(bool), bool fillinAllowed = default(bool), bool modifyAnnotationsAllowed = default(bool), bool modifyContentsAllowed = default(bool), bool printingAllowed = default(bool), bool screenReadersAllowed = default(bool), bool tagged = default(bool))
        {
            this.AssemblyAllowed = assemblyAllowed;
            this.CopyAllowed = copyAllowed;
            this.CustomFooter = customFooter;
            this.CustomHeader = customHeader;
            this.DegradedPrintingAllowed = degradedPrintingAllowed;
            this.FillinAllowed = fillinAllowed;
            this.ModifyAnnotationsAllowed = modifyAnnotationsAllowed;
            this.ModifyContentsAllowed = modifyContentsAllowed;
            this.PrintingAllowed = printingAllowed;
            this.ScreenReadersAllowed = screenReadersAllowed;
            this.Tagged = tagged;
        }

        /// <summary>
        /// Assembly allowed
        /// </summary>
        /// <value>Assembly allowed</value>
        [DataMember(Name="assembly_allowed", EmitDefaultValue=false)]
        public bool AssemblyAllowed { get; set; }

        /// <summary>
        /// Copy/Paste is allowed
        /// </summary>
        /// <value>Copy/Paste is allowed</value>
        [DataMember(Name="copy_allowed", EmitDefaultValue=false)]
        public bool CopyAllowed { get; set; }

        /// <summary>
        /// A custom footer for each pdf page
        /// </summary>
        /// <value>A custom footer for each pdf page</value>
        [DataMember(Name="custom_footer", EmitDefaultValue=false)]
        public string CustomFooter { get; set; }

        /// <summary>
        /// A custom header for each pdf page
        /// </summary>
        /// <value>A custom header for each pdf page</value>
        [DataMember(Name="custom_header", EmitDefaultValue=false)]
        public string CustomHeader { get; set; }

        /// <summary>
        /// Degraded printing allowed
        /// </summary>
        /// <value>Degraded printing allowed</value>
        [DataMember(Name="degraded_printing_allowed", EmitDefaultValue=false)]
        public bool DegradedPrintingAllowed { get; set; }

        /// <summary>
        /// Fillin is allowed
        /// </summary>
        /// <value>Fillin is allowed</value>
        [DataMember(Name="fillin_allowed", EmitDefaultValue=false)]
        public bool FillinAllowed { get; set; }

        /// <summary>
        /// Modifying annotations is allowed
        /// </summary>
        /// <value>Modifying annotations is allowed</value>
        [DataMember(Name="modify_annotations_allowed", EmitDefaultValue=false)]
        public bool ModifyAnnotationsAllowed { get; set; }

        /// <summary>
        /// Modifying contents is allowed
        /// </summary>
        /// <value>Modifying contents is allowed</value>
        [DataMember(Name="modify_contents_allowed", EmitDefaultValue=false)]
        public bool ModifyContentsAllowed { get; set; }

        /// <summary>
        /// Printing is allowed
        /// </summary>
        /// <value>Printing is allowed</value>
        [DataMember(Name="printing_allowed", EmitDefaultValue=false)]
        public bool PrintingAllowed { get; set; }

        /// <summary>
        /// Screen readers are allowed
        /// </summary>
        /// <value>Screen readers are allowed</value>
        [DataMember(Name="screen_readers_allowed", EmitDefaultValue=false)]
        public bool ScreenReadersAllowed { get; set; }

        /// <summary>
        /// PDF is tagged
        /// </summary>
        /// <value>PDF is tagged</value>
        [DataMember(Name="tagged", EmitDefaultValue=false)]
        public bool Tagged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemDigitalItemPdfMeta {\n");
            sb.Append("  AssemblyAllowed: ").Append(AssemblyAllowed).Append("\n");
            sb.Append("  CopyAllowed: ").Append(CopyAllowed).Append("\n");
            sb.Append("  CustomFooter: ").Append(CustomFooter).Append("\n");
            sb.Append("  CustomHeader: ").Append(CustomHeader).Append("\n");
            sb.Append("  DegradedPrintingAllowed: ").Append(DegradedPrintingAllowed).Append("\n");
            sb.Append("  FillinAllowed: ").Append(FillinAllowed).Append("\n");
            sb.Append("  ModifyAnnotationsAllowed: ").Append(ModifyAnnotationsAllowed).Append("\n");
            sb.Append("  ModifyContentsAllowed: ").Append(ModifyContentsAllowed).Append("\n");
            sb.Append("  PrintingAllowed: ").Append(PrintingAllowed).Append("\n");
            sb.Append("  ScreenReadersAllowed: ").Append(ScreenReadersAllowed).Append("\n");
            sb.Append("  Tagged: ").Append(Tagged).Append("\n");
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
            return this.Equals(input as ItemDigitalItemPdfMeta);
        }

        /// <summary>
        /// Returns true if ItemDigitalItemPdfMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemDigitalItemPdfMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemDigitalItemPdfMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssemblyAllowed == input.AssemblyAllowed ||
                    (this.AssemblyAllowed != null &&
                    this.AssemblyAllowed.Equals(input.AssemblyAllowed))
                ) && 
                (
                    this.CopyAllowed == input.CopyAllowed ||
                    (this.CopyAllowed != null &&
                    this.CopyAllowed.Equals(input.CopyAllowed))
                ) && 
                (
                    this.CustomFooter == input.CustomFooter ||
                    (this.CustomFooter != null &&
                    this.CustomFooter.Equals(input.CustomFooter))
                ) && 
                (
                    this.CustomHeader == input.CustomHeader ||
                    (this.CustomHeader != null &&
                    this.CustomHeader.Equals(input.CustomHeader))
                ) && 
                (
                    this.DegradedPrintingAllowed == input.DegradedPrintingAllowed ||
                    (this.DegradedPrintingAllowed != null &&
                    this.DegradedPrintingAllowed.Equals(input.DegradedPrintingAllowed))
                ) && 
                (
                    this.FillinAllowed == input.FillinAllowed ||
                    (this.FillinAllowed != null &&
                    this.FillinAllowed.Equals(input.FillinAllowed))
                ) && 
                (
                    this.ModifyAnnotationsAllowed == input.ModifyAnnotationsAllowed ||
                    (this.ModifyAnnotationsAllowed != null &&
                    this.ModifyAnnotationsAllowed.Equals(input.ModifyAnnotationsAllowed))
                ) && 
                (
                    this.ModifyContentsAllowed == input.ModifyContentsAllowed ||
                    (this.ModifyContentsAllowed != null &&
                    this.ModifyContentsAllowed.Equals(input.ModifyContentsAllowed))
                ) && 
                (
                    this.PrintingAllowed == input.PrintingAllowed ||
                    (this.PrintingAllowed != null &&
                    this.PrintingAllowed.Equals(input.PrintingAllowed))
                ) && 
                (
                    this.ScreenReadersAllowed == input.ScreenReadersAllowed ||
                    (this.ScreenReadersAllowed != null &&
                    this.ScreenReadersAllowed.Equals(input.ScreenReadersAllowed))
                ) && 
                (
                    this.Tagged == input.Tagged ||
                    (this.Tagged != null &&
                    this.Tagged.Equals(input.Tagged))
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
                if (this.AssemblyAllowed != null)
                    hashCode = hashCode * 59 + this.AssemblyAllowed.GetHashCode();
                if (this.CopyAllowed != null)
                    hashCode = hashCode * 59 + this.CopyAllowed.GetHashCode();
                if (this.CustomFooter != null)
                    hashCode = hashCode * 59 + this.CustomFooter.GetHashCode();
                if (this.CustomHeader != null)
                    hashCode = hashCode * 59 + this.CustomHeader.GetHashCode();
                if (this.DegradedPrintingAllowed != null)
                    hashCode = hashCode * 59 + this.DegradedPrintingAllowed.GetHashCode();
                if (this.FillinAllowed != null)
                    hashCode = hashCode * 59 + this.FillinAllowed.GetHashCode();
                if (this.ModifyAnnotationsAllowed != null)
                    hashCode = hashCode * 59 + this.ModifyAnnotationsAllowed.GetHashCode();
                if (this.ModifyContentsAllowed != null)
                    hashCode = hashCode * 59 + this.ModifyContentsAllowed.GetHashCode();
                if (this.PrintingAllowed != null)
                    hashCode = hashCode * 59 + this.PrintingAllowed.GetHashCode();
                if (this.ScreenReadersAllowed != null)
                    hashCode = hashCode * 59 + this.ScreenReadersAllowed.GetHashCode();
                if (this.Tagged != null)
                    hashCode = hashCode * 59 + this.Tagged.GetHashCode();
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
            // CustomFooter (string) maxLength
            if(this.CustomFooter != null && this.CustomFooter.Length > 8000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomFooter, length must be less than 8000.", new [] { "CustomFooter" });
            }


            // CustomHeader (string) maxLength
            if(this.CustomHeader != null && this.CustomHeader.Length > 8000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomHeader, length must be less than 8000.", new [] { "CustomHeader" });
            }


            yield break;
        }
    }

}

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
    /// ItemContent
    /// </summary>
    [DataContract]
    public partial class ItemContent :  IEquatable<ItemContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemContent" /> class.
        /// </summary>
        /// <param name="Assignments">StoreFront assignments.</param>
        /// <param name="Attributes">StoreFront attributes.</param>
        /// <param name="ExcludeFromSearch">Exclude from search.</param>
        /// <param name="ExcludeFromTopSellers">Exclude from the top sellers list in the StoreFront.</param>
        /// <param name="ExtendedDescription">Extended description (max 2000 characters).</param>
        /// <param name="ExtendedDescriptionTranslatedTextInstanceOid">Extneded description text translation instance identifier.</param>
        /// <param name="Multimedia">Multimedia.</param>
        /// <param name="NewItem">True if the item is new.</param>
        /// <param name="NewItemEnd">The date the item should no longer be considered new.</param>
        /// <param name="NewItemStart">The date the item should start being considered new.</param>
        /// <param name="ViewUrl">Legacy view URL (not used by StoreFronts).</param>
        public ItemContent(List<ItemContentAssignment> Assignments = default(List<ItemContentAssignment>), List<ItemContentAttribute> Attributes = default(List<ItemContentAttribute>), bool? ExcludeFromSearch = default(bool?), bool? ExcludeFromTopSellers = default(bool?), string ExtendedDescription = default(string), int? ExtendedDescriptionTranslatedTextInstanceOid = default(int?), List<ItemContentMultimedia> Multimedia = default(List<ItemContentMultimedia>), bool? NewItem = default(bool?), string NewItemEnd = default(string), string NewItemStart = default(string), string ViewUrl = default(string))
        {
            this.Assignments = Assignments;
            this.Attributes = Attributes;
            this.ExcludeFromSearch = ExcludeFromSearch;
            this.ExcludeFromTopSellers = ExcludeFromTopSellers;
            this.ExtendedDescription = ExtendedDescription;
            this.ExtendedDescriptionTranslatedTextInstanceOid = ExtendedDescriptionTranslatedTextInstanceOid;
            this.Multimedia = Multimedia;
            this.NewItem = NewItem;
            this.NewItemEnd = NewItemEnd;
            this.NewItemStart = NewItemStart;
            this.ViewUrl = ViewUrl;
        }
        
        /// <summary>
        /// StoreFront assignments
        /// </summary>
        /// <value>StoreFront assignments</value>
        [DataMember(Name="assignments", EmitDefaultValue=false)]
        public List<ItemContentAssignment> Assignments { get; set; }

        /// <summary>
        /// StoreFront attributes
        /// </summary>
        /// <value>StoreFront attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ItemContentAttribute> Attributes { get; set; }

        /// <summary>
        /// Exclude from search
        /// </summary>
        /// <value>Exclude from search</value>
        [DataMember(Name="exclude_from_search", EmitDefaultValue=false)]
        public bool? ExcludeFromSearch { get; set; }

        /// <summary>
        /// Exclude from the top sellers list in the StoreFront
        /// </summary>
        /// <value>Exclude from the top sellers list in the StoreFront</value>
        [DataMember(Name="exclude_from_top_sellers", EmitDefaultValue=false)]
        public bool? ExcludeFromTopSellers { get; set; }

        /// <summary>
        /// Extended description (max 2000 characters)
        /// </summary>
        /// <value>Extended description (max 2000 characters)</value>
        [DataMember(Name="extended_description", EmitDefaultValue=false)]
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Extneded description text translation instance identifier
        /// </summary>
        /// <value>Extneded description text translation instance identifier</value>
        [DataMember(Name="extended_description_translated_text_instance_oid", EmitDefaultValue=false)]
        public int? ExtendedDescriptionTranslatedTextInstanceOid { get; set; }

        /// <summary>
        /// Multimedia
        /// </summary>
        /// <value>Multimedia</value>
        [DataMember(Name="multimedia", EmitDefaultValue=false)]
        public List<ItemContentMultimedia> Multimedia { get; set; }

        /// <summary>
        /// True if the item is new
        /// </summary>
        /// <value>True if the item is new</value>
        [DataMember(Name="new_item", EmitDefaultValue=false)]
        public bool? NewItem { get; set; }

        /// <summary>
        /// The date the item should no longer be considered new
        /// </summary>
        /// <value>The date the item should no longer be considered new</value>
        [DataMember(Name="new_item_end", EmitDefaultValue=false)]
        public string NewItemEnd { get; set; }

        /// <summary>
        /// The date the item should start being considered new
        /// </summary>
        /// <value>The date the item should start being considered new</value>
        [DataMember(Name="new_item_start", EmitDefaultValue=false)]
        public string NewItemStart { get; set; }

        /// <summary>
        /// Legacy view URL (not used by StoreFronts)
        /// </summary>
        /// <value>Legacy view URL (not used by StoreFronts)</value>
        [DataMember(Name="view_url", EmitDefaultValue=false)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemContent {\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ExcludeFromSearch: ").Append(ExcludeFromSearch).Append("\n");
            sb.Append("  ExcludeFromTopSellers: ").Append(ExcludeFromTopSellers).Append("\n");
            sb.Append("  ExtendedDescription: ").Append(ExtendedDescription).Append("\n");
            sb.Append("  ExtendedDescriptionTranslatedTextInstanceOid: ").Append(ExtendedDescriptionTranslatedTextInstanceOid).Append("\n");
            sb.Append("  Multimedia: ").Append(Multimedia).Append("\n");
            sb.Append("  NewItem: ").Append(NewItem).Append("\n");
            sb.Append("  NewItemEnd: ").Append(NewItemEnd).Append("\n");
            sb.Append("  NewItemStart: ").Append(NewItemStart).Append("\n");
            sb.Append("  ViewUrl: ").Append(ViewUrl).Append("\n");
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
            return this.Equals(input as ItemContent);
        }

        /// <summary>
        /// Returns true if ItemContent instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Assignments == input.Assignments ||
                    this.Assignments != null &&
                    this.Assignments.SequenceEqual(input.Assignments)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.ExcludeFromSearch == input.ExcludeFromSearch ||
                    (this.ExcludeFromSearch != null &&
                    this.ExcludeFromSearch.Equals(input.ExcludeFromSearch))
                ) && 
                (
                    this.ExcludeFromTopSellers == input.ExcludeFromTopSellers ||
                    (this.ExcludeFromTopSellers != null &&
                    this.ExcludeFromTopSellers.Equals(input.ExcludeFromTopSellers))
                ) && 
                (
                    this.ExtendedDescription == input.ExtendedDescription ||
                    (this.ExtendedDescription != null &&
                    this.ExtendedDescription.Equals(input.ExtendedDescription))
                ) && 
                (
                    this.ExtendedDescriptionTranslatedTextInstanceOid == input.ExtendedDescriptionTranslatedTextInstanceOid ||
                    (this.ExtendedDescriptionTranslatedTextInstanceOid != null &&
                    this.ExtendedDescriptionTranslatedTextInstanceOid.Equals(input.ExtendedDescriptionTranslatedTextInstanceOid))
                ) && 
                (
                    this.Multimedia == input.Multimedia ||
                    this.Multimedia != null &&
                    this.Multimedia.SequenceEqual(input.Multimedia)
                ) && 
                (
                    this.NewItem == input.NewItem ||
                    (this.NewItem != null &&
                    this.NewItem.Equals(input.NewItem))
                ) && 
                (
                    this.NewItemEnd == input.NewItemEnd ||
                    (this.NewItemEnd != null &&
                    this.NewItemEnd.Equals(input.NewItemEnd))
                ) && 
                (
                    this.NewItemStart == input.NewItemStart ||
                    (this.NewItemStart != null &&
                    this.NewItemStart.Equals(input.NewItemStart))
                ) && 
                (
                    this.ViewUrl == input.ViewUrl ||
                    (this.ViewUrl != null &&
                    this.ViewUrl.Equals(input.ViewUrl))
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
                if (this.Assignments != null)
                    hashCode = hashCode * 59 + this.Assignments.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.ExcludeFromSearch != null)
                    hashCode = hashCode * 59 + this.ExcludeFromSearch.GetHashCode();
                if (this.ExcludeFromTopSellers != null)
                    hashCode = hashCode * 59 + this.ExcludeFromTopSellers.GetHashCode();
                if (this.ExtendedDescription != null)
                    hashCode = hashCode * 59 + this.ExtendedDescription.GetHashCode();
                if (this.ExtendedDescriptionTranslatedTextInstanceOid != null)
                    hashCode = hashCode * 59 + this.ExtendedDescriptionTranslatedTextInstanceOid.GetHashCode();
                if (this.Multimedia != null)
                    hashCode = hashCode * 59 + this.Multimedia.GetHashCode();
                if (this.NewItem != null)
                    hashCode = hashCode * 59 + this.NewItem.GetHashCode();
                if (this.NewItemEnd != null)
                    hashCode = hashCode * 59 + this.NewItemEnd.GetHashCode();
                if (this.NewItemStart != null)
                    hashCode = hashCode * 59 + this.NewItemStart.GetHashCode();
                if (this.ViewUrl != null)
                    hashCode = hashCode * 59 + this.ViewUrl.GetHashCode();
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
            // ExtendedDescription (string) maxLength
            if(this.ExtendedDescription != null && this.ExtendedDescription.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtendedDescription, length must be less than 2000.", new [] { "ExtendedDescription" });
            }

            yield break;
        }
    }

}

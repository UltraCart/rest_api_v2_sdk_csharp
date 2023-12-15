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
    /// ItemRelated
    /// </summary>
    [DataContract]
    public partial class ItemRelated :  IEquatable<ItemRelated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelated" /> class.
        /// </summary>
        /// <param name="noSystemCalculatedRelatedItems">True to suppress system calculated relationships.</param>
        /// <param name="notRelatable">Not relatable.</param>
        /// <param name="relatedItems">Related items.</param>
        public ItemRelated(bool? noSystemCalculatedRelatedItems = default(bool?), bool? notRelatable = default(bool?), List<ItemRelatedItem> relatedItems = default(List<ItemRelatedItem>))
        {
            this.NoSystemCalculatedRelatedItems = noSystemCalculatedRelatedItems;
            this.NotRelatable = notRelatable;
            this.RelatedItems = relatedItems;
        }
        
        /// <summary>
        /// True to suppress system calculated relationships
        /// </summary>
        /// <value>True to suppress system calculated relationships</value>
        [DataMember(Name="no_system_calculated_related_items", EmitDefaultValue=false)]
        public bool? NoSystemCalculatedRelatedItems { get; set; }

        /// <summary>
        /// Not relatable
        /// </summary>
        /// <value>Not relatable</value>
        [DataMember(Name="not_relatable", EmitDefaultValue=false)]
        public bool? NotRelatable { get; set; }

        /// <summary>
        /// Related items
        /// </summary>
        /// <value>Related items</value>
        [DataMember(Name="related_items", EmitDefaultValue=false)]
        public List<ItemRelatedItem> RelatedItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRelated {\n");
            sb.Append("  NoSystemCalculatedRelatedItems: ").Append(NoSystemCalculatedRelatedItems).Append("\n");
            sb.Append("  NotRelatable: ").Append(NotRelatable).Append("\n");
            sb.Append("  RelatedItems: ").Append(RelatedItems).Append("\n");
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
            return this.Equals(input as ItemRelated);
        }

        /// <summary>
        /// Returns true if ItemRelated instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemRelated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRelated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NoSystemCalculatedRelatedItems == input.NoSystemCalculatedRelatedItems ||
                    (this.NoSystemCalculatedRelatedItems != null &&
                    this.NoSystemCalculatedRelatedItems.Equals(input.NoSystemCalculatedRelatedItems))
                ) && 
                (
                    this.NotRelatable == input.NotRelatable ||
                    (this.NotRelatable != null &&
                    this.NotRelatable.Equals(input.NotRelatable))
                ) && 
                (
                    this.RelatedItems == input.RelatedItems ||
                    this.RelatedItems != null &&
                    this.RelatedItems.SequenceEqual(input.RelatedItems)
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
                if (this.NoSystemCalculatedRelatedItems != null)
                    hashCode = hashCode * 59 + this.NoSystemCalculatedRelatedItems.GetHashCode();
                if (this.NotRelatable != null)
                    hashCode = hashCode * 59 + this.NotRelatable.GetHashCode();
                if (this.RelatedItems != null)
                    hashCode = hashCode * 59 + this.RelatedItems.GetHashCode();
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

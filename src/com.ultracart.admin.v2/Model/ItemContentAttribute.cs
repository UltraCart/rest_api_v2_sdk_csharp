/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// ItemContentAttribute
    /// </summary>
    [DataContract]
    public partial class ItemContentAttribute :  IEquatable<ItemContentAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemContentAttribute" /> class.
        /// </summary>
        /// <param name="ITEM_META_DESCRIPTION">ITEM_META_DESCRIPTION.</param>
        /// <param name="ITEM_META_KEYWORDS">ITEM_META_KEYWORDS.</param>
        /// <param name="ITEM_META_TITLE">ITEM_META_TITLE.</param>
        /// <param name="Name">Name.</param>
        /// <param name="TranslatedTextInstanceOid">TranslatedTextInstanceOid.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Value">Value.</param>
        public ItemContentAttribute(string ITEM_META_DESCRIPTION = null, string ITEM_META_KEYWORDS = null, string ITEM_META_TITLE = null, string Name = null, int? TranslatedTextInstanceOid = null, string Type = null, string Value = null)
        {
            this.ITEM_META_DESCRIPTION = ITEM_META_DESCRIPTION;
            this.ITEM_META_KEYWORDS = ITEM_META_KEYWORDS;
            this.ITEM_META_TITLE = ITEM_META_TITLE;
            this.Name = Name;
            this.TranslatedTextInstanceOid = TranslatedTextInstanceOid;
            this.Type = Type;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets ITEM_META_DESCRIPTION
        /// </summary>
        [DataMember(Name="ITEM_META_DESCRIPTION", EmitDefaultValue=false)]
        public string ITEM_META_DESCRIPTION { get; set; }
        /// <summary>
        /// Gets or Sets ITEM_META_KEYWORDS
        /// </summary>
        [DataMember(Name="ITEM_META_KEYWORDS", EmitDefaultValue=false)]
        public string ITEM_META_KEYWORDS { get; set; }
        /// <summary>
        /// Gets or Sets ITEM_META_TITLE
        /// </summary>
        [DataMember(Name="ITEM_META_TITLE", EmitDefaultValue=false)]
        public string ITEM_META_TITLE { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets TranslatedTextInstanceOid
        /// </summary>
        [DataMember(Name="translated_text_instance_oid", EmitDefaultValue=false)]
        public int? TranslatedTextInstanceOid { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemContentAttribute {\n");
            sb.Append("  ITEM_META_DESCRIPTION: ").Append(ITEM_META_DESCRIPTION).Append("\n");
            sb.Append("  ITEM_META_KEYWORDS: ").Append(ITEM_META_KEYWORDS).Append("\n");
            sb.Append("  ITEM_META_TITLE: ").Append(ITEM_META_TITLE).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TranslatedTextInstanceOid: ").Append(TranslatedTextInstanceOid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ItemContentAttribute);
        }

        /// <summary>
        /// Returns true if ItemContentAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemContentAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemContentAttribute other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ITEM_META_DESCRIPTION == other.ITEM_META_DESCRIPTION ||
                    this.ITEM_META_DESCRIPTION != null &&
                    this.ITEM_META_DESCRIPTION.Equals(other.ITEM_META_DESCRIPTION)
                ) && 
                (
                    this.ITEM_META_KEYWORDS == other.ITEM_META_KEYWORDS ||
                    this.ITEM_META_KEYWORDS != null &&
                    this.ITEM_META_KEYWORDS.Equals(other.ITEM_META_KEYWORDS)
                ) && 
                (
                    this.ITEM_META_TITLE == other.ITEM_META_TITLE ||
                    this.ITEM_META_TITLE != null &&
                    this.ITEM_META_TITLE.Equals(other.ITEM_META_TITLE)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TranslatedTextInstanceOid == other.TranslatedTextInstanceOid ||
                    this.TranslatedTextInstanceOid != null &&
                    this.TranslatedTextInstanceOid.Equals(other.TranslatedTextInstanceOid)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ITEM_META_DESCRIPTION != null)
                    hash = hash * 59 + this.ITEM_META_DESCRIPTION.GetHashCode();
                if (this.ITEM_META_KEYWORDS != null)
                    hash = hash * 59 + this.ITEM_META_KEYWORDS.GetHashCode();
                if (this.ITEM_META_TITLE != null)
                    hash = hash * 59 + this.ITEM_META_TITLE.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TranslatedTextInstanceOid != null)
                    hash = hash * 59 + this.TranslatedTextInstanceOid.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}

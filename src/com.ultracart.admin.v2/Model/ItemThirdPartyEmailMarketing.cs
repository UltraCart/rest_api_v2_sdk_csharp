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
    /// ItemThirdPartyEmailMarketing
    /// </summary>
    [DataContract]
    public partial class ItemThirdPartyEmailMarketing :  IEquatable<ItemThirdPartyEmailMarketing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemThirdPartyEmailMarketing" /> class.
        /// </summary>
        /// <param name="AddTags">AddTags.</param>
        /// <param name="ProviderName">ProviderName.</param>
        /// <param name="RemoveTags">RemoveTags.</param>
        /// <param name="SubscribeLists">SubscribeLists.</param>
        /// <param name="UnsubscribeLists">UnsubscribeLists.</param>
        public ItemThirdPartyEmailMarketing(List<string> AddTags = null, string ProviderName = null, List<string> RemoveTags = null, List<string> SubscribeLists = null, List<string> UnsubscribeLists = null)
        {
            this.AddTags = AddTags;
            this.ProviderName = ProviderName;
            this.RemoveTags = RemoveTags;
            this.SubscribeLists = SubscribeLists;
            this.UnsubscribeLists = UnsubscribeLists;
        }
        
        /// <summary>
        /// Gets or Sets AddTags
        /// </summary>
        [DataMember(Name="add_tags", EmitDefaultValue=false)]
        public List<string> AddTags { get; set; }
        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="provider_name", EmitDefaultValue=false)]
        public string ProviderName { get; set; }
        /// <summary>
        /// Gets or Sets RemoveTags
        /// </summary>
        [DataMember(Name="remove_tags", EmitDefaultValue=false)]
        public List<string> RemoveTags { get; set; }
        /// <summary>
        /// Gets or Sets SubscribeLists
        /// </summary>
        [DataMember(Name="subscribe_lists", EmitDefaultValue=false)]
        public List<string> SubscribeLists { get; set; }
        /// <summary>
        /// Gets or Sets UnsubscribeLists
        /// </summary>
        [DataMember(Name="unsubscribe_lists", EmitDefaultValue=false)]
        public List<string> UnsubscribeLists { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemThirdPartyEmailMarketing {\n");
            sb.Append("  AddTags: ").Append(AddTags).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  RemoveTags: ").Append(RemoveTags).Append("\n");
            sb.Append("  SubscribeLists: ").Append(SubscribeLists).Append("\n");
            sb.Append("  UnsubscribeLists: ").Append(UnsubscribeLists).Append("\n");
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
            return this.Equals(obj as ItemThirdPartyEmailMarketing);
        }

        /// <summary>
        /// Returns true if ItemThirdPartyEmailMarketing instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemThirdPartyEmailMarketing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemThirdPartyEmailMarketing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddTags == other.AddTags ||
                    this.AddTags != null &&
                    this.AddTags.SequenceEqual(other.AddTags)
                ) && 
                (
                    this.ProviderName == other.ProviderName ||
                    this.ProviderName != null &&
                    this.ProviderName.Equals(other.ProviderName)
                ) && 
                (
                    this.RemoveTags == other.RemoveTags ||
                    this.RemoveTags != null &&
                    this.RemoveTags.SequenceEqual(other.RemoveTags)
                ) && 
                (
                    this.SubscribeLists == other.SubscribeLists ||
                    this.SubscribeLists != null &&
                    this.SubscribeLists.SequenceEqual(other.SubscribeLists)
                ) && 
                (
                    this.UnsubscribeLists == other.UnsubscribeLists ||
                    this.UnsubscribeLists != null &&
                    this.UnsubscribeLists.SequenceEqual(other.UnsubscribeLists)
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
                if (this.AddTags != null)
                    hash = hash * 59 + this.AddTags.GetHashCode();
                if (this.ProviderName != null)
                    hash = hash * 59 + this.ProviderName.GetHashCode();
                if (this.RemoveTags != null)
                    hash = hash * 59 + this.RemoveTags.GetHashCode();
                if (this.SubscribeLists != null)
                    hash = hash * 59 + this.SubscribeLists.GetHashCode();
                if (this.UnsubscribeLists != null)
                    hash = hash * 59 + this.UnsubscribeLists.GetHashCode();
                return hash;
            }
        }
    }

}

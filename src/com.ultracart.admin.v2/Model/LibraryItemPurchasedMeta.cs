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
    /// LibraryItemPurchasedMeta
    /// </summary>
    [DataContract]
    public partial class LibraryItemPurchasedMeta :  IEquatable<LibraryItemPurchasedMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemPurchasedMeta" /> class.
        /// </summary>
        /// <param name="mostRecentVersion">The most recent version of the item purchased.</param>
        /// <param name="myPurchasedVersion">If this is a public item and the merchant has already purchased it, this is their version.  If not yet purchased, this will be zero.  This value will only be populated during a searchPublicItems() call..</param>
        /// <param name="upgradeAvailable">True if the most recent version of this purchase it greater than what was purchased.</param>
        public LibraryItemPurchasedMeta(int? mostRecentVersion = default(int?), int? myPurchasedVersion = default(int?), bool? upgradeAvailable = default(bool?))
        {
            this.MostRecentVersion = mostRecentVersion;
            this.MyPurchasedVersion = myPurchasedVersion;
            this.UpgradeAvailable = upgradeAvailable;
        }
        
        /// <summary>
        /// The most recent version of the item purchased
        /// </summary>
        /// <value>The most recent version of the item purchased</value>
        [DataMember(Name="most_recent_version", EmitDefaultValue=false)]
        public int? MostRecentVersion { get; set; }

        /// <summary>
        /// If this is a public item and the merchant has already purchased it, this is their version.  If not yet purchased, this will be zero.  This value will only be populated during a searchPublicItems() call.
        /// </summary>
        /// <value>If this is a public item and the merchant has already purchased it, this is their version.  If not yet purchased, this will be zero.  This value will only be populated during a searchPublicItems() call.</value>
        [DataMember(Name="my_purchased_version", EmitDefaultValue=false)]
        public int? MyPurchasedVersion { get; set; }

        /// <summary>
        /// True if the most recent version of this purchase it greater than what was purchased
        /// </summary>
        /// <value>True if the most recent version of this purchase it greater than what was purchased</value>
        [DataMember(Name="upgrade_available", EmitDefaultValue=false)]
        public bool? UpgradeAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryItemPurchasedMeta {\n");
            sb.Append("  MostRecentVersion: ").Append(MostRecentVersion).Append("\n");
            sb.Append("  MyPurchasedVersion: ").Append(MyPurchasedVersion).Append("\n");
            sb.Append("  UpgradeAvailable: ").Append(UpgradeAvailable).Append("\n");
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
            return this.Equals(input as LibraryItemPurchasedMeta);
        }

        /// <summary>
        /// Returns true if LibraryItemPurchasedMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryItemPurchasedMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryItemPurchasedMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MostRecentVersion == input.MostRecentVersion ||
                    (this.MostRecentVersion != null &&
                    this.MostRecentVersion.Equals(input.MostRecentVersion))
                ) && 
                (
                    this.MyPurchasedVersion == input.MyPurchasedVersion ||
                    (this.MyPurchasedVersion != null &&
                    this.MyPurchasedVersion.Equals(input.MyPurchasedVersion))
                ) && 
                (
                    this.UpgradeAvailable == input.UpgradeAvailable ||
                    (this.UpgradeAvailable != null &&
                    this.UpgradeAvailable.Equals(input.UpgradeAvailable))
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
                if (this.MostRecentVersion != null)
                    hashCode = hashCode * 59 + this.MostRecentVersion.GetHashCode();
                if (this.MyPurchasedVersion != null)
                    hashCode = hashCode * 59 + this.MyPurchasedVersion.GetHashCode();
                if (this.UpgradeAvailable != null)
                    hashCode = hashCode * 59 + this.UpgradeAvailable.GetHashCode();
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
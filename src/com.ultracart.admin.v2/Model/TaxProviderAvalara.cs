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
    /// TaxProviderAvalara
    /// </summary>
    [DataContract]
    public partial class TaxProviderAvalara :  IEquatable<TaxProviderAvalara>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxProviderAvalara" /> class.
        /// </summary>
        /// <param name="Configuration">Configuration.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Selected">Selected.</param>
        /// <param name="Title">Title.</param>
        public TaxProviderAvalara(AvalaraConfig Configuration = default(AvalaraConfig), string Description = default(string), bool? Selected = default(bool?), string Title = default(string))
        {
            this.Configuration = Configuration;
            this.Description = Description;
            this.Selected = Selected;
            this.Title = Title;
        }
        
        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public AvalaraConfig Configuration { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Selected
        /// </summary>
        /// <value>Selected</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxProviderAvalara {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as TaxProviderAvalara);
        }

        /// <summary>
        /// Returns true if TaxProviderAvalara instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxProviderAvalara to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxProviderAvalara input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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

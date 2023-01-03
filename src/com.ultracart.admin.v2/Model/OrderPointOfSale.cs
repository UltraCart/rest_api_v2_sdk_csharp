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
    /// OrderPointOfSale
    /// </summary>
    [DataContract]
    public partial class OrderPointOfSale :  IEquatable<OrderPointOfSale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPointOfSale" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="reader">reader.</param>
        /// <param name="register">register.</param>
        public OrderPointOfSale(PointOfSaleLocation location = default(PointOfSaleLocation), PointOfSaleReader reader = default(PointOfSaleReader), PointOfSaleRegister register = default(PointOfSaleRegister))
        {
            this.Location = location;
            this.Reader = reader;
            this.Register = register;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public PointOfSaleLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets Reader
        /// </summary>
        [DataMember(Name="reader", EmitDefaultValue=false)]
        public PointOfSaleReader Reader { get; set; }

        /// <summary>
        /// Gets or Sets Register
        /// </summary>
        [DataMember(Name="register", EmitDefaultValue=false)]
        public PointOfSaleRegister Register { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPointOfSale {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Reader: ").Append(Reader).Append("\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
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
            return this.Equals(input as OrderPointOfSale);
        }

        /// <summary>
        /// Returns true if OrderPointOfSale instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPointOfSale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPointOfSale input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Reader == input.Reader ||
                    (this.Reader != null &&
                    this.Reader.Equals(input.Reader))
                ) && 
                (
                    this.Register == input.Register ||
                    (this.Register != null &&
                    this.Register.Equals(input.Register))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Reader != null)
                    hashCode = hashCode * 59 + this.Reader.GetHashCode();
                if (this.Register != null)
                    hashCode = hashCode * 59 + this.Register.GetHashCode();
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

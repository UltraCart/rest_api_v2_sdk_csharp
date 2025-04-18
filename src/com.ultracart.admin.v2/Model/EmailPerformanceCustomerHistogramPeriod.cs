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
    /// EmailPerformanceCustomerHistogramPeriod
    /// </summary>
    [DataContract]
    public partial class EmailPerformanceCustomerHistogramPeriod :  IEquatable<EmailPerformanceCustomerHistogramPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPerformanceCustomerHistogramPeriod" /> class.
        /// </summary>
        /// <param name="active">Active customers last active in this period.</param>
        /// <param name="inactive">Inactive customers last active in this period.</param>
        /// <param name="month">Month (1 &#x3D; January).</param>
        /// <param name="total">Total customers last active in this period.</param>
        /// <param name="year">Year (four digits).</param>
        public EmailPerformanceCustomerHistogramPeriod(int active = default(int), int inactive = default(int), int month = default(int), int total = default(int), int year = default(int))
        {
            this.Active = active;
            this.Inactive = inactive;
            this.Month = month;
            this.Total = total;
            this.Year = year;
        }

        /// <summary>
        /// Active customers last active in this period
        /// </summary>
        /// <value>Active customers last active in this period</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public int Active { get; set; }

        /// <summary>
        /// Inactive customers last active in this period
        /// </summary>
        /// <value>Inactive customers last active in this period</value>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public int Inactive { get; set; }

        /// <summary>
        /// Month (1 &#x3D; January)
        /// </summary>
        /// <value>Month (1 &#x3D; January)</value>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int Month { get; set; }

        /// <summary>
        /// Total customers last active in this period
        /// </summary>
        /// <value>Total customers last active in this period</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int Total { get; set; }

        /// <summary>
        /// Year (four digits)
        /// </summary>
        /// <value>Year (four digits)</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPerformanceCustomerHistogramPeriod {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as EmailPerformanceCustomerHistogramPeriod);
        }

        /// <summary>
        /// Returns true if EmailPerformanceCustomerHistogramPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailPerformanceCustomerHistogramPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPerformanceCustomerHistogramPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Inactive == input.Inactive ||
                    (this.Inactive != null &&
                    this.Inactive.Equals(input.Inactive))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Inactive != null)
                    hashCode = hashCode * 59 + this.Inactive.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
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

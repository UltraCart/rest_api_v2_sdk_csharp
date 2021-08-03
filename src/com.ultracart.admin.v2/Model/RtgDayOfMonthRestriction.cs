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
    /// RtgDayOfMonthRestriction
    /// </summary>
    [DataContract]
    public partial class RtgDayOfMonthRestriction :  IEquatable<RtgDayOfMonthRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RtgDayOfMonthRestriction" /> class.
        /// </summary>
        /// <param name="dayOfMonth">The day of the month. 1 equals the first day of the month, 31 is the last possible value..</param>
        /// <param name="selected">True if this rotating gateway is allowed to operate on this day of month.  If no days are selected, all days are allowed..</param>
        public RtgDayOfMonthRestriction(int? dayOfMonth = default(int?), bool? selected = default(bool?))
        {
            this.DayOfMonth = dayOfMonth;
            this.Selected = selected;
        }
        
        /// <summary>
        /// The day of the month. 1 equals the first day of the month, 31 is the last possible value.
        /// </summary>
        /// <value>The day of the month. 1 equals the first day of the month, 31 is the last possible value.</value>
        [DataMember(Name="day_of_month", EmitDefaultValue=false)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// True if this rotating gateway is allowed to operate on this day of month.  If no days are selected, all days are allowed.
        /// </summary>
        /// <value>True if this rotating gateway is allowed to operate on this day of month.  If no days are selected, all days are allowed.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtgDayOfMonthRestriction {\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
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
            return this.Equals(input as RtgDayOfMonthRestriction);
        }

        /// <summary>
        /// Returns true if RtgDayOfMonthRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of RtgDayOfMonthRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RtgDayOfMonthRestriction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DayOfMonth == input.DayOfMonth ||
                    (this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(input.DayOfMonth))
                ) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
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
                if (this.DayOfMonth != null)
                    hashCode = hashCode * 59 + this.DayOfMonth.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
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
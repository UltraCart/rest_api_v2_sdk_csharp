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
    /// ScreenRecordingFilterValuesEventParams
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingFilterValuesEventParams :  IEquatable<ScreenRecordingFilterValuesEventParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingFilterValuesEventParams" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="valuesBd">valuesBd.</param>
        /// <param name="valuesBool">valuesBool.</param>
        /// <param name="valuesNum">valuesNum.</param>
        /// <param name="valuesText">valuesText.</param>
        public ScreenRecordingFilterValuesEventParams(string name = default(string), List<decimal> valuesBd = default(List<decimal>), List<bool> valuesBool = default(List<bool>), List<int> valuesNum = default(List<int>), List<string> valuesText = default(List<string>))
        {
            this.Name = name;
            this.ValuesBd = valuesBd;
            this.ValuesBool = valuesBool;
            this.ValuesNum = valuesNum;
            this.ValuesText = valuesText;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ValuesBd
        /// </summary>
        [DataMember(Name="values_bd", EmitDefaultValue=false)]
        public List<decimal> ValuesBd { get; set; }

        /// <summary>
        /// Gets or Sets ValuesBool
        /// </summary>
        [DataMember(Name="values_bool", EmitDefaultValue=false)]
        public List<bool> ValuesBool { get; set; }

        /// <summary>
        /// Gets or Sets ValuesNum
        /// </summary>
        [DataMember(Name="values_num", EmitDefaultValue=false)]
        public List<int> ValuesNum { get; set; }

        /// <summary>
        /// Gets or Sets ValuesText
        /// </summary>
        [DataMember(Name="values_text", EmitDefaultValue=false)]
        public List<string> ValuesText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingFilterValuesEventParams {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValuesBd: ").Append(ValuesBd).Append("\n");
            sb.Append("  ValuesBool: ").Append(ValuesBool).Append("\n");
            sb.Append("  ValuesNum: ").Append(ValuesNum).Append("\n");
            sb.Append("  ValuesText: ").Append(ValuesText).Append("\n");
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
            return this.Equals(input as ScreenRecordingFilterValuesEventParams);
        }

        /// <summary>
        /// Returns true if ScreenRecordingFilterValuesEventParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingFilterValuesEventParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingFilterValuesEventParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValuesBd == input.ValuesBd ||
                    this.ValuesBd != null &&
                    input.ValuesBd != null &&
                    this.ValuesBd.SequenceEqual(input.ValuesBd)
                ) && 
                (
                    this.ValuesBool == input.ValuesBool ||
                    this.ValuesBool != null &&
                    input.ValuesBool != null &&
                    this.ValuesBool.SequenceEqual(input.ValuesBool)
                ) && 
                (
                    this.ValuesNum == input.ValuesNum ||
                    this.ValuesNum != null &&
                    input.ValuesNum != null &&
                    this.ValuesNum.SequenceEqual(input.ValuesNum)
                ) && 
                (
                    this.ValuesText == input.ValuesText ||
                    this.ValuesText != null &&
                    input.ValuesText != null &&
                    this.ValuesText.SequenceEqual(input.ValuesText)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValuesBd != null)
                    hashCode = hashCode * 59 + this.ValuesBd.GetHashCode();
                if (this.ValuesBool != null)
                    hashCode = hashCode * 59 + this.ValuesBool.GetHashCode();
                if (this.ValuesNum != null)
                    hashCode = hashCode * 59 + this.ValuesNum.GetHashCode();
                if (this.ValuesText != null)
                    hashCode = hashCode * 59 + this.ValuesText.GetHashCode();
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

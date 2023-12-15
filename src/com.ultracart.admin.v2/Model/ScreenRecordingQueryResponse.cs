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
    /// ScreenRecordingQueryResponse
    /// </summary>
    [DataContract]
    public partial class ScreenRecordingQueryResponse :  IEquatable<ScreenRecordingQueryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRecordingQueryResponse" /> class.
        /// </summary>
        /// <param name="checkoutOnly">checkoutOnly.</param>
        /// <param name="error">error.</param>
        /// <param name="filter">filter.</param>
        /// <param name="filterValues">filterValues.</param>
        /// <param name="histogramData">histogramData.</param>
        /// <param name="histogramInterval">histogramInterval.</param>
        /// <param name="histogramStartDts">histogramStartDts.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="screenRecordings">screenRecordings.</param>
        /// <param name="success">Indicates if API call was successful.</param>
        /// <param name="warning">warning.</param>
        public ScreenRecordingQueryResponse(bool? checkoutOnly = default(bool?), Error error = default(Error), ScreenRecordingFilter filter = default(ScreenRecordingFilter), ScreenRecordingFilterValues filterValues = default(ScreenRecordingFilterValues), List<int?> histogramData = default(List<int?>), string histogramInterval = default(string), string histogramStartDts = default(string), ResponseMetadata metadata = default(ResponseMetadata), List<ScreenRecording> screenRecordings = default(List<ScreenRecording>), bool? success = default(bool?), Warning warning = default(Warning))
        {
            this.CheckoutOnly = checkoutOnly;
            this.Error = error;
            this.Filter = filter;
            this.FilterValues = filterValues;
            this.HistogramData = histogramData;
            this.HistogramInterval = histogramInterval;
            this.HistogramStartDts = histogramStartDts;
            this.Metadata = metadata;
            this.ScreenRecordings = screenRecordings;
            this.Success = success;
            this.Warning = warning;
        }
        
        /// <summary>
        /// Gets or Sets CheckoutOnly
        /// </summary>
        [DataMember(Name="checkout_only", EmitDefaultValue=false)]
        public bool? CheckoutOnly { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ScreenRecordingFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets FilterValues
        /// </summary>
        [DataMember(Name="filter_values", EmitDefaultValue=false)]
        public ScreenRecordingFilterValues FilterValues { get; set; }

        /// <summary>
        /// Gets or Sets HistogramData
        /// </summary>
        [DataMember(Name="histogram_data", EmitDefaultValue=false)]
        public List<int?> HistogramData { get; set; }

        /// <summary>
        /// Gets or Sets HistogramInterval
        /// </summary>
        [DataMember(Name="histogram_interval", EmitDefaultValue=false)]
        public string HistogramInterval { get; set; }

        /// <summary>
        /// Gets or Sets HistogramStartDts
        /// </summary>
        [DataMember(Name="histogram_start_dts", EmitDefaultValue=false)]
        public string HistogramStartDts { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets ScreenRecordings
        /// </summary>
        [DataMember(Name="screen_recordings", EmitDefaultValue=false)]
        public List<ScreenRecording> ScreenRecordings { get; set; }

        /// <summary>
        /// Indicates if API call was successful
        /// </summary>
        /// <value>Indicates if API call was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public Warning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenRecordingQueryResponse {\n");
            sb.Append("  CheckoutOnly: ").Append(CheckoutOnly).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  FilterValues: ").Append(FilterValues).Append("\n");
            sb.Append("  HistogramData: ").Append(HistogramData).Append("\n");
            sb.Append("  HistogramInterval: ").Append(HistogramInterval).Append("\n");
            sb.Append("  HistogramStartDts: ").Append(HistogramStartDts).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ScreenRecordings: ").Append(ScreenRecordings).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as ScreenRecordingQueryResponse);
        }

        /// <summary>
        /// Returns true if ScreenRecordingQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenRecordingQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenRecordingQueryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckoutOnly == input.CheckoutOnly ||
                    (this.CheckoutOnly != null &&
                    this.CheckoutOnly.Equals(input.CheckoutOnly))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.FilterValues == input.FilterValues ||
                    (this.FilterValues != null &&
                    this.FilterValues.Equals(input.FilterValues))
                ) && 
                (
                    this.HistogramData == input.HistogramData ||
                    this.HistogramData != null &&
                    this.HistogramData.SequenceEqual(input.HistogramData)
                ) && 
                (
                    this.HistogramInterval == input.HistogramInterval ||
                    (this.HistogramInterval != null &&
                    this.HistogramInterval.Equals(input.HistogramInterval))
                ) && 
                (
                    this.HistogramStartDts == input.HistogramStartDts ||
                    (this.HistogramStartDts != null &&
                    this.HistogramStartDts.Equals(input.HistogramStartDts))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.ScreenRecordings == input.ScreenRecordings ||
                    this.ScreenRecordings != null &&
                    this.ScreenRecordings.SequenceEqual(input.ScreenRecordings)
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.CheckoutOnly != null)
                    hashCode = hashCode * 59 + this.CheckoutOnly.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.FilterValues != null)
                    hashCode = hashCode * 59 + this.FilterValues.GetHashCode();
                if (this.HistogramData != null)
                    hashCode = hashCode * 59 + this.HistogramData.GetHashCode();
                if (this.HistogramInterval != null)
                    hashCode = hashCode * 59 + this.HistogramInterval.GetHashCode();
                if (this.HistogramStartDts != null)
                    hashCode = hashCode * 59 + this.HistogramStartDts.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.ScreenRecordings != null)
                    hashCode = hashCode * 59 + this.ScreenRecordings.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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

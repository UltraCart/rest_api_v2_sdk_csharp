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
    /// CustomerActivity
    /// </summary>
    [DataContract]
    public partial class CustomerActivity :  IEquatable<CustomerActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerActivity" /> class.
        /// </summary>
        /// <param name="activities">activities.</param>
        /// <param name="globalUnsubscribed">globalUnsubscribed.</param>
        /// <param name="globalUnsubscribedDts">globalUnsubscribedDts.</param>
        /// <param name="memberships">memberships.</param>
        /// <param name="metrics">metrics.</param>
        /// <param name="propertiesList">propertiesList.</param>
        /// <param name="spamComplaint">spamComplaint.</param>
        /// <param name="spamComplaintDts">spamComplaintDts.</param>
        public CustomerActivity(List<Activity> activities = default(List<Activity>), bool globalUnsubscribed = default(bool), string globalUnsubscribedDts = default(string), List<ListSegmentMembership> memberships = default(List<ListSegmentMembership>), List<Metric> metrics = default(List<Metric>), List<Property> propertiesList = default(List<Property>), bool spamComplaint = default(bool), string spamComplaintDts = default(string))
        {
            this.Activities = activities;
            this.GlobalUnsubscribed = globalUnsubscribed;
            this.GlobalUnsubscribedDts = globalUnsubscribedDts;
            this.Memberships = memberships;
            this.Metrics = metrics;
            this.PropertiesList = propertiesList;
            this.SpamComplaint = spamComplaint;
            this.SpamComplaintDts = spamComplaintDts;
        }

        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<Activity> Activities { get; set; }

        /// <summary>
        /// Gets or Sets GlobalUnsubscribed
        /// </summary>
        [DataMember(Name="global_unsubscribed", EmitDefaultValue=false)]
        public bool GlobalUnsubscribed { get; set; }

        /// <summary>
        /// Gets or Sets GlobalUnsubscribedDts
        /// </summary>
        [DataMember(Name="global_unsubscribed_dts", EmitDefaultValue=false)]
        public string GlobalUnsubscribedDts { get; set; }

        /// <summary>
        /// Gets or Sets Memberships
        /// </summary>
        [DataMember(Name="memberships", EmitDefaultValue=false)]
        public List<ListSegmentMembership> Memberships { get; set; }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<Metric> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets PropertiesList
        /// </summary>
        [DataMember(Name="properties_list", EmitDefaultValue=false)]
        public List<Property> PropertiesList { get; set; }

        /// <summary>
        /// Gets or Sets SpamComplaint
        /// </summary>
        [DataMember(Name="spam_complaint", EmitDefaultValue=false)]
        public bool SpamComplaint { get; set; }

        /// <summary>
        /// Gets or Sets SpamComplaintDts
        /// </summary>
        [DataMember(Name="spam_complaint_dts", EmitDefaultValue=false)]
        public string SpamComplaintDts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerActivity {\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  GlobalUnsubscribed: ").Append(GlobalUnsubscribed).Append("\n");
            sb.Append("  GlobalUnsubscribedDts: ").Append(GlobalUnsubscribedDts).Append("\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  PropertiesList: ").Append(PropertiesList).Append("\n");
            sb.Append("  SpamComplaint: ").Append(SpamComplaint).Append("\n");
            sb.Append("  SpamComplaintDts: ").Append(SpamComplaintDts).Append("\n");
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
            return this.Equals(input as CustomerActivity);
        }

        /// <summary>
        /// Returns true if CustomerActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    input.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
                ) && 
                (
                    this.GlobalUnsubscribed == input.GlobalUnsubscribed ||
                    (this.GlobalUnsubscribed != null &&
                    this.GlobalUnsubscribed.Equals(input.GlobalUnsubscribed))
                ) && 
                (
                    this.GlobalUnsubscribedDts == input.GlobalUnsubscribedDts ||
                    (this.GlobalUnsubscribedDts != null &&
                    this.GlobalUnsubscribedDts.Equals(input.GlobalUnsubscribedDts))
                ) && 
                (
                    this.Memberships == input.Memberships ||
                    this.Memberships != null &&
                    input.Memberships != null &&
                    this.Memberships.SequenceEqual(input.Memberships)
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.PropertiesList == input.PropertiesList ||
                    this.PropertiesList != null &&
                    input.PropertiesList != null &&
                    this.PropertiesList.SequenceEqual(input.PropertiesList)
                ) && 
                (
                    this.SpamComplaint == input.SpamComplaint ||
                    (this.SpamComplaint != null &&
                    this.SpamComplaint.Equals(input.SpamComplaint))
                ) && 
                (
                    this.SpamComplaintDts == input.SpamComplaintDts ||
                    (this.SpamComplaintDts != null &&
                    this.SpamComplaintDts.Equals(input.SpamComplaintDts))
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
                if (this.Activities != null)
                    hashCode = hashCode * 59 + this.Activities.GetHashCode();
                if (this.GlobalUnsubscribed != null)
                    hashCode = hashCode * 59 + this.GlobalUnsubscribed.GetHashCode();
                if (this.GlobalUnsubscribedDts != null)
                    hashCode = hashCode * 59 + this.GlobalUnsubscribedDts.GetHashCode();
                if (this.Memberships != null)
                    hashCode = hashCode * 59 + this.Memberships.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.PropertiesList != null)
                    hashCode = hashCode * 59 + this.PropertiesList.GetHashCode();
                if (this.SpamComplaint != null)
                    hashCode = hashCode * 59 + this.SpamComplaint.GetHashCode();
                if (this.SpamComplaintDts != null)
                    hashCode = hashCode * 59 + this.SpamComplaintDts.GetHashCode();
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

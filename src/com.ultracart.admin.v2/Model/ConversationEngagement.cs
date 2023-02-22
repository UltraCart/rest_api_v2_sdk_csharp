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
    /// ConversationEngagement
    /// </summary>
    [DataContract]
    public partial class ConversationEngagement :  IEquatable<ConversationEngagement>, IValidatableObject
    {
        /// <summary>
        /// The type of visitor
        /// </summary>
        /// <value>The type of visitor</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisitorTypeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum Firsttime for value: first time
            /// </summary>
            [EnumMember(Value = "first time")]
            Firsttime = 2,

            /// <summary>
            /// Enum Returning for value: returning
            /// </summary>
            [EnumMember(Value = "returning")]
            Returning = 3

        }

        /// <summary>
        /// The type of visitor
        /// </summary>
        /// <value>The type of visitor</value>
        [DataMember(Name="visitor_type", EmitDefaultValue=false)]
        public VisitorTypeEnum? VisitorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEngagement" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="conversationEngagementOid">conversationEngagementOid.</param>
        /// <param name="customerGreeting">customerGreeting.</param>
        /// <param name="customerInitiated">customerInitiated.</param>
        /// <param name="departmentOids">departmentOids.</param>
        /// <param name="engagementName">engagementName.</param>
        /// <param name="equation">equation.</param>
        /// <param name="timeOnPage">timeOnPage.</param>
        /// <param name="visitorType">The type of visitor.</param>
        public ConversationEngagement(bool active = default(bool), int conversationEngagementOid = default(int), string customerGreeting = default(string), bool customerInitiated = default(bool), List<int> departmentOids = default(List<int>), string engagementName = default(string), ConversationEngagementEquation equation = default(ConversationEngagementEquation), int timeOnPage = default(int), VisitorTypeEnum? visitorType = default(VisitorTypeEnum?))
        {
            this.Active = active;
            this.ConversationEngagementOid = conversationEngagementOid;
            this.CustomerGreeting = customerGreeting;
            this.CustomerInitiated = customerInitiated;
            this.DepartmentOids = departmentOids;
            this.EngagementName = engagementName;
            this.Equation = equation;
            this.TimeOnPage = timeOnPage;
            this.VisitorType = visitorType;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets ConversationEngagementOid
        /// </summary>
        [DataMember(Name="conversation_engagement_oid", EmitDefaultValue=false)]
        public int ConversationEngagementOid { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGreeting
        /// </summary>
        [DataMember(Name="customer_greeting", EmitDefaultValue=false)]
        public string CustomerGreeting { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInitiated
        /// </summary>
        [DataMember(Name="customer_initiated", EmitDefaultValue=false)]
        public bool CustomerInitiated { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentOids
        /// </summary>
        [DataMember(Name="department_oids", EmitDefaultValue=false)]
        public List<int> DepartmentOids { get; set; }

        /// <summary>
        /// Gets or Sets EngagementName
        /// </summary>
        [DataMember(Name="engagement_name", EmitDefaultValue=false)]
        public string EngagementName { get; set; }

        /// <summary>
        /// Gets or Sets Equation
        /// </summary>
        [DataMember(Name="equation", EmitDefaultValue=false)]
        public ConversationEngagementEquation Equation { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnPage
        /// </summary>
        [DataMember(Name="time_on_page", EmitDefaultValue=false)]
        public int TimeOnPage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEngagement {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ConversationEngagementOid: ").Append(ConversationEngagementOid).Append("\n");
            sb.Append("  CustomerGreeting: ").Append(CustomerGreeting).Append("\n");
            sb.Append("  CustomerInitiated: ").Append(CustomerInitiated).Append("\n");
            sb.Append("  DepartmentOids: ").Append(DepartmentOids).Append("\n");
            sb.Append("  EngagementName: ").Append(EngagementName).Append("\n");
            sb.Append("  Equation: ").Append(Equation).Append("\n");
            sb.Append("  TimeOnPage: ").Append(TimeOnPage).Append("\n");
            sb.Append("  VisitorType: ").Append(VisitorType).Append("\n");
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
            return this.Equals(input as ConversationEngagement);
        }

        /// <summary>
        /// Returns true if ConversationEngagement instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationEngagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEngagement input)
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
                    this.ConversationEngagementOid == input.ConversationEngagementOid ||
                    (this.ConversationEngagementOid != null &&
                    this.ConversationEngagementOid.Equals(input.ConversationEngagementOid))
                ) && 
                (
                    this.CustomerGreeting == input.CustomerGreeting ||
                    (this.CustomerGreeting != null &&
                    this.CustomerGreeting.Equals(input.CustomerGreeting))
                ) && 
                (
                    this.CustomerInitiated == input.CustomerInitiated ||
                    (this.CustomerInitiated != null &&
                    this.CustomerInitiated.Equals(input.CustomerInitiated))
                ) && 
                (
                    this.DepartmentOids == input.DepartmentOids ||
                    this.DepartmentOids != null &&
                    input.DepartmentOids != null &&
                    this.DepartmentOids.SequenceEqual(input.DepartmentOids)
                ) && 
                (
                    this.EngagementName == input.EngagementName ||
                    (this.EngagementName != null &&
                    this.EngagementName.Equals(input.EngagementName))
                ) && 
                (
                    this.Equation == input.Equation ||
                    (this.Equation != null &&
                    this.Equation.Equals(input.Equation))
                ) && 
                (
                    this.TimeOnPage == input.TimeOnPage ||
                    (this.TimeOnPage != null &&
                    this.TimeOnPage.Equals(input.TimeOnPage))
                ) && 
                (
                    this.VisitorType == input.VisitorType ||
                    (this.VisitorType != null &&
                    this.VisitorType.Equals(input.VisitorType))
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
                if (this.ConversationEngagementOid != null)
                    hashCode = hashCode * 59 + this.ConversationEngagementOid.GetHashCode();
                if (this.CustomerGreeting != null)
                    hashCode = hashCode * 59 + this.CustomerGreeting.GetHashCode();
                if (this.CustomerInitiated != null)
                    hashCode = hashCode * 59 + this.CustomerInitiated.GetHashCode();
                if (this.DepartmentOids != null)
                    hashCode = hashCode * 59 + this.DepartmentOids.GetHashCode();
                if (this.EngagementName != null)
                    hashCode = hashCode * 59 + this.EngagementName.GetHashCode();
                if (this.Equation != null)
                    hashCode = hashCode * 59 + this.Equation.GetHashCode();
                if (this.TimeOnPage != null)
                    hashCode = hashCode * 59 + this.TimeOnPage.GetHashCode();
                if (this.VisitorType != null)
                    hashCode = hashCode * 59 + this.VisitorType.GetHashCode();
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

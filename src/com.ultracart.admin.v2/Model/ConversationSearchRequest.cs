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
    /// ConversationSearchRequest
    /// </summary>
    [DataContract]
    public partial class ConversationSearchRequest :  IEquatable<ConversationSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSearchRequest" /> class.
        /// </summary>
        /// <param name="dateEnd">End of the range.</param>
        /// <param name="dateStart">Start of the range.</param>
        /// <param name="emailFilter">emailFilter.</param>
        /// <param name="languageFilter">languageFilter.</param>
        /// <param name="mediumFilter">mediumFilter.</param>
        /// <param name="orderByNewest">orderByNewest.</param>
        /// <param name="orderByOldest">orderByOldest.</param>
        /// <param name="rangeBegin">rangeBegin.</param>
        /// <param name="rangeEnd">rangeEnd.</param>
        /// <param name="smsPhoneNumberFilter">smsPhoneNumberFilter.</param>
        /// <param name="textSearch">textSearch.</param>
        /// <param name="visibleFilter">visibleFilter.</param>
        public ConversationSearchRequest(string dateEnd = default(string), string dateStart = default(string), string emailFilter = default(string), string languageFilter = default(string), string mediumFilter = default(string), bool? orderByNewest = default(bool?), bool? orderByOldest = default(bool?), int? rangeBegin = default(int?), int? rangeEnd = default(int?), string smsPhoneNumberFilter = default(string), string textSearch = default(string), bool? visibleFilter = default(bool?))
        {
            this.DateEnd = dateEnd;
            this.DateStart = dateStart;
            this.EmailFilter = emailFilter;
            this.LanguageFilter = languageFilter;
            this.MediumFilter = mediumFilter;
            this.OrderByNewest = orderByNewest;
            this.OrderByOldest = orderByOldest;
            this.RangeBegin = rangeBegin;
            this.RangeEnd = rangeEnd;
            this.SmsPhoneNumberFilter = smsPhoneNumberFilter;
            this.TextSearch = textSearch;
            this.VisibleFilter = visibleFilter;
        }
        
        /// <summary>
        /// End of the range
        /// </summary>
        /// <value>End of the range</value>
        [DataMember(Name="date_end", EmitDefaultValue=false)]
        public string DateEnd { get; set; }

        /// <summary>
        /// Start of the range
        /// </summary>
        /// <value>Start of the range</value>
        [DataMember(Name="date_start", EmitDefaultValue=false)]
        public string DateStart { get; set; }

        /// <summary>
        /// Gets or Sets EmailFilter
        /// </summary>
        [DataMember(Name="email_filter", EmitDefaultValue=false)]
        public string EmailFilter { get; set; }

        /// <summary>
        /// Gets or Sets LanguageFilter
        /// </summary>
        [DataMember(Name="language_filter", EmitDefaultValue=false)]
        public string LanguageFilter { get; set; }

        /// <summary>
        /// Gets or Sets MediumFilter
        /// </summary>
        [DataMember(Name="medium_filter", EmitDefaultValue=false)]
        public string MediumFilter { get; set; }

        /// <summary>
        /// Gets or Sets OrderByNewest
        /// </summary>
        [DataMember(Name="order_by_newest", EmitDefaultValue=false)]
        public bool? OrderByNewest { get; set; }

        /// <summary>
        /// Gets or Sets OrderByOldest
        /// </summary>
        [DataMember(Name="order_by_oldest", EmitDefaultValue=false)]
        public bool? OrderByOldest { get; set; }

        /// <summary>
        /// Gets or Sets RangeBegin
        /// </summary>
        [DataMember(Name="range_begin", EmitDefaultValue=false)]
        public int? RangeBegin { get; set; }

        /// <summary>
        /// Gets or Sets RangeEnd
        /// </summary>
        [DataMember(Name="range_end", EmitDefaultValue=false)]
        public int? RangeEnd { get; set; }

        /// <summary>
        /// Gets or Sets SmsPhoneNumberFilter
        /// </summary>
        [DataMember(Name="sms_phone_number_filter", EmitDefaultValue=false)]
        public string SmsPhoneNumberFilter { get; set; }

        /// <summary>
        /// Gets or Sets TextSearch
        /// </summary>
        [DataMember(Name="text_search", EmitDefaultValue=false)]
        public string TextSearch { get; set; }

        /// <summary>
        /// Gets or Sets VisibleFilter
        /// </summary>
        [DataMember(Name="visible_filter", EmitDefaultValue=false)]
        public bool? VisibleFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSearchRequest {\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  EmailFilter: ").Append(EmailFilter).Append("\n");
            sb.Append("  LanguageFilter: ").Append(LanguageFilter).Append("\n");
            sb.Append("  MediumFilter: ").Append(MediumFilter).Append("\n");
            sb.Append("  OrderByNewest: ").Append(OrderByNewest).Append("\n");
            sb.Append("  OrderByOldest: ").Append(OrderByOldest).Append("\n");
            sb.Append("  RangeBegin: ").Append(RangeBegin).Append("\n");
            sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
            sb.Append("  SmsPhoneNumberFilter: ").Append(SmsPhoneNumberFilter).Append("\n");
            sb.Append("  TextSearch: ").Append(TextSearch).Append("\n");
            sb.Append("  VisibleFilter: ").Append(VisibleFilter).Append("\n");
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
            return this.Equals(input as ConversationSearchRequest);
        }

        /// <summary>
        /// Returns true if ConversationSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateEnd == input.DateEnd ||
                    (this.DateEnd != null &&
                    this.DateEnd.Equals(input.DateEnd))
                ) && 
                (
                    this.DateStart == input.DateStart ||
                    (this.DateStart != null &&
                    this.DateStart.Equals(input.DateStart))
                ) && 
                (
                    this.EmailFilter == input.EmailFilter ||
                    (this.EmailFilter != null &&
                    this.EmailFilter.Equals(input.EmailFilter))
                ) && 
                (
                    this.LanguageFilter == input.LanguageFilter ||
                    (this.LanguageFilter != null &&
                    this.LanguageFilter.Equals(input.LanguageFilter))
                ) && 
                (
                    this.MediumFilter == input.MediumFilter ||
                    (this.MediumFilter != null &&
                    this.MediumFilter.Equals(input.MediumFilter))
                ) && 
                (
                    this.OrderByNewest == input.OrderByNewest ||
                    (this.OrderByNewest != null &&
                    this.OrderByNewest.Equals(input.OrderByNewest))
                ) && 
                (
                    this.OrderByOldest == input.OrderByOldest ||
                    (this.OrderByOldest != null &&
                    this.OrderByOldest.Equals(input.OrderByOldest))
                ) && 
                (
                    this.RangeBegin == input.RangeBegin ||
                    (this.RangeBegin != null &&
                    this.RangeBegin.Equals(input.RangeBegin))
                ) && 
                (
                    this.RangeEnd == input.RangeEnd ||
                    (this.RangeEnd != null &&
                    this.RangeEnd.Equals(input.RangeEnd))
                ) && 
                (
                    this.SmsPhoneNumberFilter == input.SmsPhoneNumberFilter ||
                    (this.SmsPhoneNumberFilter != null &&
                    this.SmsPhoneNumberFilter.Equals(input.SmsPhoneNumberFilter))
                ) && 
                (
                    this.TextSearch == input.TextSearch ||
                    (this.TextSearch != null &&
                    this.TextSearch.Equals(input.TextSearch))
                ) && 
                (
                    this.VisibleFilter == input.VisibleFilter ||
                    (this.VisibleFilter != null &&
                    this.VisibleFilter.Equals(input.VisibleFilter))
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
                if (this.DateEnd != null)
                    hashCode = hashCode * 59 + this.DateEnd.GetHashCode();
                if (this.DateStart != null)
                    hashCode = hashCode * 59 + this.DateStart.GetHashCode();
                if (this.EmailFilter != null)
                    hashCode = hashCode * 59 + this.EmailFilter.GetHashCode();
                if (this.LanguageFilter != null)
                    hashCode = hashCode * 59 + this.LanguageFilter.GetHashCode();
                if (this.MediumFilter != null)
                    hashCode = hashCode * 59 + this.MediumFilter.GetHashCode();
                if (this.OrderByNewest != null)
                    hashCode = hashCode * 59 + this.OrderByNewest.GetHashCode();
                if (this.OrderByOldest != null)
                    hashCode = hashCode * 59 + this.OrderByOldest.GetHashCode();
                if (this.RangeBegin != null)
                    hashCode = hashCode * 59 + this.RangeBegin.GetHashCode();
                if (this.RangeEnd != null)
                    hashCode = hashCode * 59 + this.RangeEnd.GetHashCode();
                if (this.SmsPhoneNumberFilter != null)
                    hashCode = hashCode * 59 + this.SmsPhoneNumberFilter.GetHashCode();
                if (this.TextSearch != null)
                    hashCode = hashCode * 59 + this.TextSearch.GetHashCode();
                if (this.VisibleFilter != null)
                    hashCode = hashCode * 59 + this.VisibleFilter.GetHashCode();
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

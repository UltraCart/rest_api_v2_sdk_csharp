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
    /// ConversationEngagementEquationFunction
    /// </summary>
    [DataContract]
    public partial class ConversationEngagementEquationFunction :  IEquatable<ConversationEngagementEquationFunction>, IValidatableObject
    {
        /// <summary>
        /// Logic operation to perform on an any page url function type
        /// </summary>
        /// <value>Logic operation to perform on an any page url function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AnyPageUrlLogicEnum
        {
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 1,

            /// <summary>
            /// Enum Doesnotcontain for value: does not contain
            /// </summary>
            [EnumMember(Value = "does not contain")]
            Doesnotcontain = 2,

            /// <summary>
            /// Enum Isexactly for value: is exactly
            /// </summary>
            [EnumMember(Value = "is exactly")]
            Isexactly = 3,

            /// <summary>
            /// Enum Isnot for value: is not
            /// </summary>
            [EnumMember(Value = "is not")]
            Isnot = 4

        }

        /// <summary>
        /// Logic operation to perform on an any page url function type
        /// </summary>
        /// <value>Logic operation to perform on an any page url function type</value>
        [DataMember(Name="any_page_url_logic", EmitDefaultValue=false)]
        public AnyPageUrlLogicEnum? AnyPageUrlLogic { get; set; }
        /// <summary>
        /// Logic operation to perform on a current page url function type
        /// </summary>
        /// <value>Logic operation to perform on a current page url function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrentPageUrlLogicEnum
        {
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 1,

            /// <summary>
            /// Enum Doesnotcontain for value: does not contain
            /// </summary>
            [EnumMember(Value = "does not contain")]
            Doesnotcontain = 2,

            /// <summary>
            /// Enum Isexactly for value: is exactly
            /// </summary>
            [EnumMember(Value = "is exactly")]
            Isexactly = 3,

            /// <summary>
            /// Enum Isnot for value: is not
            /// </summary>
            [EnumMember(Value = "is not")]
            Isnot = 4

        }

        /// <summary>
        /// Logic operation to perform on a current page url function type
        /// </summary>
        /// <value>Logic operation to perform on a current page url function type</value>
        [DataMember(Name="current_page_url_logic", EmitDefaultValue=false)]
        public CurrentPageUrlLogicEnum? CurrentPageUrlLogic { get; set; }
        /// <summary>
        /// Logic operation to perform on a customer&#39;s browsing time function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s browsing time function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomersBrowsingTimeLogicEnum
        {
            /// <summary>
            /// Enum Atleast for value: is at least
            /// </summary>
            [EnumMember(Value = "is at least")]
            Atleast = 1,

            /// <summary>
            /// Enum Morethan for value: is more than
            /// </summary>
            [EnumMember(Value = "is more than")]
            Morethan = 2,

            /// <summary>
            /// Enum Lessthan for value: is less than
            /// </summary>
            [EnumMember(Value = "is less than")]
            Lessthan = 3,

            /// <summary>
            /// Enum Atmost for value: is at most
            /// </summary>
            [EnumMember(Value = "is at most")]
            Atmost = 4

        }

        /// <summary>
        /// Logic operation to perform on a customer&#39;s browsing time function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s browsing time function type</value>
        [DataMember(Name="customers_browsing_time_logic", EmitDefaultValue=false)]
        public CustomersBrowsingTimeLogicEnum? CustomersBrowsingTimeLogic { get; set; }
        /// <summary>
        /// Logic operation to perform on a customer&#39;s location function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s location function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomersLocationLogicEnum
        {
            /// <summary>
            /// Enum Is for value: is
            /// </summary>
            [EnumMember(Value = "is")]
            Is = 1,

            /// <summary>
            /// Enum Isnot for value: is not
            /// </summary>
            [EnumMember(Value = "is not")]
            Isnot = 2

        }

        /// <summary>
        /// Logic operation to perform on a customer&#39;s location function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s location function type</value>
        [DataMember(Name="customers_location_logic", EmitDefaultValue=false)]
        public CustomersLocationLogicEnum? CustomersLocationLogic { get; set; }
        /// <summary>
        /// Logic operation to perform on a customer&#39;s browsing time function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s browsing time function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NumberOfViewedPagesLogicEnum
        {
            /// <summary>
            /// Enum Atleast for value: is at least
            /// </summary>
            [EnumMember(Value = "is at least")]
            Atleast = 1,

            /// <summary>
            /// Enum Morethan for value: is more than
            /// </summary>
            [EnumMember(Value = "is more than")]
            Morethan = 2,

            /// <summary>
            /// Enum Lessthan for value: is less than
            /// </summary>
            [EnumMember(Value = "is less than")]
            Lessthan = 3,

            /// <summary>
            /// Enum Atmost for value: is at most
            /// </summary>
            [EnumMember(Value = "is at most")]
            Atmost = 4

        }

        /// <summary>
        /// Logic operation to perform on a customer&#39;s browsing time function type
        /// </summary>
        /// <value>Logic operation to perform on a customer&#39;s browsing time function type</value>
        [DataMember(Name="number_of_viewed_pages_logic", EmitDefaultValue=false)]
        public NumberOfViewedPagesLogicEnum? NumberOfViewedPagesLogic { get; set; }
        /// <summary>
        /// Logic operation to perform on a referring website function type
        /// </summary>
        /// <value>Logic operation to perform on a referring website function type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReferringWebsiteLogicEnum
        {
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 1,

            /// <summary>
            /// Enum Doesnotcontain for value: does not contain
            /// </summary>
            [EnumMember(Value = "does not contain")]
            Doesnotcontain = 2,

            /// <summary>
            /// Enum Isexactly for value: is exactly
            /// </summary>
            [EnumMember(Value = "is exactly")]
            Isexactly = 3,

            /// <summary>
            /// Enum Isnot for value: is not
            /// </summary>
            [EnumMember(Value = "is not")]
            Isnot = 4

        }

        /// <summary>
        /// Logic operation to perform on a referring website function type
        /// </summary>
        /// <value>Logic operation to perform on a referring website function type</value>
        [DataMember(Name="referring_website_logic", EmitDefaultValue=false)]
        public ReferringWebsiteLogicEnum? ReferringWebsiteLogic { get; set; }
        /// <summary>
        /// Type of function
        /// </summary>
        /// <value>Type of function</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Currentpageurl for value: current page url
            /// </summary>
            [EnumMember(Value = "current page url")]
            Currentpageurl = 1,

            /// <summary>
            /// Enum Customerslocation for value: customer's location
            /// </summary>
            [EnumMember(Value = "customer's location")]
            Customerslocation = 2,

            /// <summary>
            /// Enum Customersbrowsingtime for value: customer's browsing time
            /// </summary>
            [EnumMember(Value = "customer's browsing time")]
            Customersbrowsingtime = 3,

            /// <summary>
            /// Enum Numberofviewedpages for value: number of viewed pages
            /// </summary>
            [EnumMember(Value = "number of viewed pages")]
            Numberofviewedpages = 4,

            /// <summary>
            /// Enum Referringwebsiteaddress for value: referring website address
            /// </summary>
            [EnumMember(Value = "referring website address")]
            Referringwebsiteaddress = 5,

            /// <summary>
            /// Enum Anypagefromsession for value: any page from session
            /// </summary>
            [EnumMember(Value = "any page from session")]
            Anypagefromsession = 6

        }

        /// <summary>
        /// Type of function
        /// </summary>
        /// <value>Type of function</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEngagementEquationFunction" /> class.
        /// </summary>
        /// <param name="anyPageUrlLogic">Logic operation to perform on an any page url function type.</param>
        /// <param name="anyPageUrlValue">anyPageUrlValue.</param>
        /// <param name="currentPageUrlLogic">Logic operation to perform on a current page url function type.</param>
        /// <param name="currentPageUrlValue">currentPageUrlValue.</param>
        /// <param name="customersBrowsingTimeLogic">Logic operation to perform on a customer&#39;s browsing time function type.</param>
        /// <param name="customersBrowsingTimeSeconds">customersBrowsingTimeSeconds.</param>
        /// <param name="customersLocationCountry">customersLocationCountry.</param>
        /// <param name="customersLocationLogic">Logic operation to perform on a customer&#39;s location function type.</param>
        /// <param name="customersLocationState">customersLocationState.</param>
        /// <param name="numberOfViewedPagesLogic">Logic operation to perform on a customer&#39;s browsing time function type.</param>
        /// <param name="numberOfViewedPagesValue">numberOfViewedPagesValue.</param>
        /// <param name="referringWebsiteLogic">Logic operation to perform on a referring website function type.</param>
        /// <param name="referringWebsiteValue">referringWebsiteValue.</param>
        /// <param name="type">Type of function.</param>
        public ConversationEngagementEquationFunction(AnyPageUrlLogicEnum? anyPageUrlLogic = default(AnyPageUrlLogicEnum?), string anyPageUrlValue = default(string), CurrentPageUrlLogicEnum? currentPageUrlLogic = default(CurrentPageUrlLogicEnum?), string currentPageUrlValue = default(string), CustomersBrowsingTimeLogicEnum? customersBrowsingTimeLogic = default(CustomersBrowsingTimeLogicEnum?), int customersBrowsingTimeSeconds = default(int), string customersLocationCountry = default(string), CustomersLocationLogicEnum? customersLocationLogic = default(CustomersLocationLogicEnum?), string customersLocationState = default(string), NumberOfViewedPagesLogicEnum? numberOfViewedPagesLogic = default(NumberOfViewedPagesLogicEnum?), int numberOfViewedPagesValue = default(int), ReferringWebsiteLogicEnum? referringWebsiteLogic = default(ReferringWebsiteLogicEnum?), string referringWebsiteValue = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.AnyPageUrlLogic = anyPageUrlLogic;
            this.AnyPageUrlValue = anyPageUrlValue;
            this.CurrentPageUrlLogic = currentPageUrlLogic;
            this.CurrentPageUrlValue = currentPageUrlValue;
            this.CustomersBrowsingTimeLogic = customersBrowsingTimeLogic;
            this.CustomersBrowsingTimeSeconds = customersBrowsingTimeSeconds;
            this.CustomersLocationCountry = customersLocationCountry;
            this.CustomersLocationLogic = customersLocationLogic;
            this.CustomersLocationState = customersLocationState;
            this.NumberOfViewedPagesLogic = numberOfViewedPagesLogic;
            this.NumberOfViewedPagesValue = numberOfViewedPagesValue;
            this.ReferringWebsiteLogic = referringWebsiteLogic;
            this.ReferringWebsiteValue = referringWebsiteValue;
            this.Type = type;
        }


        /// <summary>
        /// Gets or Sets AnyPageUrlValue
        /// </summary>
        [DataMember(Name="any_page_url_value", EmitDefaultValue=false)]
        public string AnyPageUrlValue { get; set; }


        /// <summary>
        /// Gets or Sets CurrentPageUrlValue
        /// </summary>
        [DataMember(Name="current_page_url_value", EmitDefaultValue=false)]
        public string CurrentPageUrlValue { get; set; }


        /// <summary>
        /// Gets or Sets CustomersBrowsingTimeSeconds
        /// </summary>
        [DataMember(Name="customers_browsing_time_seconds", EmitDefaultValue=false)]
        public int CustomersBrowsingTimeSeconds { get; set; }

        /// <summary>
        /// Gets or Sets CustomersLocationCountry
        /// </summary>
        [DataMember(Name="customers_location_country", EmitDefaultValue=false)]
        public string CustomersLocationCountry { get; set; }


        /// <summary>
        /// Gets or Sets CustomersLocationState
        /// </summary>
        [DataMember(Name="customers_location_state", EmitDefaultValue=false)]
        public string CustomersLocationState { get; set; }


        /// <summary>
        /// Gets or Sets NumberOfViewedPagesValue
        /// </summary>
        [DataMember(Name="number_of_viewed_pages_value", EmitDefaultValue=false)]
        public int NumberOfViewedPagesValue { get; set; }


        /// <summary>
        /// Gets or Sets ReferringWebsiteValue
        /// </summary>
        [DataMember(Name="referring_website_value", EmitDefaultValue=false)]
        public string ReferringWebsiteValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEngagementEquationFunction {\n");
            sb.Append("  AnyPageUrlLogic: ").Append(AnyPageUrlLogic).Append("\n");
            sb.Append("  AnyPageUrlValue: ").Append(AnyPageUrlValue).Append("\n");
            sb.Append("  CurrentPageUrlLogic: ").Append(CurrentPageUrlLogic).Append("\n");
            sb.Append("  CurrentPageUrlValue: ").Append(CurrentPageUrlValue).Append("\n");
            sb.Append("  CustomersBrowsingTimeLogic: ").Append(CustomersBrowsingTimeLogic).Append("\n");
            sb.Append("  CustomersBrowsingTimeSeconds: ").Append(CustomersBrowsingTimeSeconds).Append("\n");
            sb.Append("  CustomersLocationCountry: ").Append(CustomersLocationCountry).Append("\n");
            sb.Append("  CustomersLocationLogic: ").Append(CustomersLocationLogic).Append("\n");
            sb.Append("  CustomersLocationState: ").Append(CustomersLocationState).Append("\n");
            sb.Append("  NumberOfViewedPagesLogic: ").Append(NumberOfViewedPagesLogic).Append("\n");
            sb.Append("  NumberOfViewedPagesValue: ").Append(NumberOfViewedPagesValue).Append("\n");
            sb.Append("  ReferringWebsiteLogic: ").Append(ReferringWebsiteLogic).Append("\n");
            sb.Append("  ReferringWebsiteValue: ").Append(ReferringWebsiteValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ConversationEngagementEquationFunction);
        }

        /// <summary>
        /// Returns true if ConversationEngagementEquationFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationEngagementEquationFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEngagementEquationFunction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnyPageUrlLogic == input.AnyPageUrlLogic ||
                    (this.AnyPageUrlLogic != null &&
                    this.AnyPageUrlLogic.Equals(input.AnyPageUrlLogic))
                ) && 
                (
                    this.AnyPageUrlValue == input.AnyPageUrlValue ||
                    (this.AnyPageUrlValue != null &&
                    this.AnyPageUrlValue.Equals(input.AnyPageUrlValue))
                ) && 
                (
                    this.CurrentPageUrlLogic == input.CurrentPageUrlLogic ||
                    (this.CurrentPageUrlLogic != null &&
                    this.CurrentPageUrlLogic.Equals(input.CurrentPageUrlLogic))
                ) && 
                (
                    this.CurrentPageUrlValue == input.CurrentPageUrlValue ||
                    (this.CurrentPageUrlValue != null &&
                    this.CurrentPageUrlValue.Equals(input.CurrentPageUrlValue))
                ) && 
                (
                    this.CustomersBrowsingTimeLogic == input.CustomersBrowsingTimeLogic ||
                    (this.CustomersBrowsingTimeLogic != null &&
                    this.CustomersBrowsingTimeLogic.Equals(input.CustomersBrowsingTimeLogic))
                ) && 
                (
                    this.CustomersBrowsingTimeSeconds == input.CustomersBrowsingTimeSeconds ||
                    (this.CustomersBrowsingTimeSeconds != null &&
                    this.CustomersBrowsingTimeSeconds.Equals(input.CustomersBrowsingTimeSeconds))
                ) && 
                (
                    this.CustomersLocationCountry == input.CustomersLocationCountry ||
                    (this.CustomersLocationCountry != null &&
                    this.CustomersLocationCountry.Equals(input.CustomersLocationCountry))
                ) && 
                (
                    this.CustomersLocationLogic == input.CustomersLocationLogic ||
                    (this.CustomersLocationLogic != null &&
                    this.CustomersLocationLogic.Equals(input.CustomersLocationLogic))
                ) && 
                (
                    this.CustomersLocationState == input.CustomersLocationState ||
                    (this.CustomersLocationState != null &&
                    this.CustomersLocationState.Equals(input.CustomersLocationState))
                ) && 
                (
                    this.NumberOfViewedPagesLogic == input.NumberOfViewedPagesLogic ||
                    (this.NumberOfViewedPagesLogic != null &&
                    this.NumberOfViewedPagesLogic.Equals(input.NumberOfViewedPagesLogic))
                ) && 
                (
                    this.NumberOfViewedPagesValue == input.NumberOfViewedPagesValue ||
                    (this.NumberOfViewedPagesValue != null &&
                    this.NumberOfViewedPagesValue.Equals(input.NumberOfViewedPagesValue))
                ) && 
                (
                    this.ReferringWebsiteLogic == input.ReferringWebsiteLogic ||
                    (this.ReferringWebsiteLogic != null &&
                    this.ReferringWebsiteLogic.Equals(input.ReferringWebsiteLogic))
                ) && 
                (
                    this.ReferringWebsiteValue == input.ReferringWebsiteValue ||
                    (this.ReferringWebsiteValue != null &&
                    this.ReferringWebsiteValue.Equals(input.ReferringWebsiteValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AnyPageUrlLogic != null)
                    hashCode = hashCode * 59 + this.AnyPageUrlLogic.GetHashCode();
                if (this.AnyPageUrlValue != null)
                    hashCode = hashCode * 59 + this.AnyPageUrlValue.GetHashCode();
                if (this.CurrentPageUrlLogic != null)
                    hashCode = hashCode * 59 + this.CurrentPageUrlLogic.GetHashCode();
                if (this.CurrentPageUrlValue != null)
                    hashCode = hashCode * 59 + this.CurrentPageUrlValue.GetHashCode();
                if (this.CustomersBrowsingTimeLogic != null)
                    hashCode = hashCode * 59 + this.CustomersBrowsingTimeLogic.GetHashCode();
                if (this.CustomersBrowsingTimeSeconds != null)
                    hashCode = hashCode * 59 + this.CustomersBrowsingTimeSeconds.GetHashCode();
                if (this.CustomersLocationCountry != null)
                    hashCode = hashCode * 59 + this.CustomersLocationCountry.GetHashCode();
                if (this.CustomersLocationLogic != null)
                    hashCode = hashCode * 59 + this.CustomersLocationLogic.GetHashCode();
                if (this.CustomersLocationState != null)
                    hashCode = hashCode * 59 + this.CustomersLocationState.GetHashCode();
                if (this.NumberOfViewedPagesLogic != null)
                    hashCode = hashCode * 59 + this.NumberOfViewedPagesLogic.GetHashCode();
                if (this.NumberOfViewedPagesValue != null)
                    hashCode = hashCode * 59 + this.NumberOfViewedPagesValue.GetHashCode();
                if (this.ReferringWebsiteLogic != null)
                    hashCode = hashCode * 59 + this.ReferringWebsiteLogic.GetHashCode();
                if (this.ReferringWebsiteValue != null)
                    hashCode = hashCode * 59 + this.ReferringWebsiteValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

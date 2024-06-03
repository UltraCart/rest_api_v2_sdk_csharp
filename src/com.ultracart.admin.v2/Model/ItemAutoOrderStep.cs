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
    /// ItemAutoOrderStep
    /// </summary>
    [DataContract]
    public partial class ItemAutoOrderStep :  IEquatable<ItemAutoOrderStep>, IValidatableObject
    {
        /// <summary>
        /// Type of step (item, kit only, loop or pause)
        /// </summary>
        /// <value>Type of step (item, kit only, loop or pause)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Item for value: item
            /// </summary>
            [EnumMember(Value = "item")]
            Item = 1,
            
            /// <summary>
            /// Enum Pause for value: pause
            /// </summary>
            [EnumMember(Value = "pause")]
            Pause = 2,
            
            /// <summary>
            /// Enum Loop for value: loop
            /// </summary>
            [EnumMember(Value = "loop")]
            Loop = 3,
            
            /// <summary>
            /// Enum Kitonly for value: kit only
            /// </summary>
            [EnumMember(Value = "kit only")]
            Kitonly = 4,
            
            /// <summary>
            /// Enum Pauseuntil for value: pause until
            /// </summary>
            [EnumMember(Value = "pause until")]
            Pauseuntil = 5
        }

        /// <summary>
        /// Type of step (item, kit only, loop or pause)
        /// </summary>
        /// <value>Type of step (item, kit only, loop or pause)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAutoOrderStep" /> class.
        /// </summary>
        /// <param name="arbitraryScheduleDays">If the schedule is arbitrary, then this is the number of days.</param>
        /// <param name="arbitraryUnitCost">Arbitrary unit cost used to override the regular item cost.</param>
        /// <param name="arbitraryUnitCostSchedules">Arbitrary unit costs schedules for more advanced discounting by rebill attempt.</param>
        /// <param name="grandfatherPricing">Grand-father pricing configuration if the rebill schedule has changed over time.</param>
        /// <param name="managedBy">Managed by (defaults to UltraCart).</param>
        /// <param name="pauseDays">Number of days to pause.</param>
        /// <param name="pauseUntilDate">Wait for this step to happen until the specified date.</param>
        /// <param name="pauseUntilDayOfMonth">Pause until a specific day of the month.</param>
        /// <param name="pauseUntilMinimumDelayDays">Pause at least this many days between the last order and the calculated next day of month.</param>
        /// <param name="preshipmentNoticeDays">If set, a pre-shipment notice is sent to the customer this many days in advance.</param>
        /// <param name="recurringMerchantItemId">Item id to rebill.</param>
        /// <param name="recurringMerchantItemOid">Item object identifier to rebill.</param>
        /// <param name="repeatCount">Number of times to rebill.  Last step can be null for infinite.</param>
        /// <param name="schedule">Frequency of the rebill.</param>
        /// <param name="subscribeEmailListName">Email list name to subscribe the customer to when the rebill occurs (decommissioned email engine).</param>
        /// <param name="subscribeEmailListOid">Email list identifier to subscribe the customer to when this rebill occurs (decommissioned email engine).</param>
        /// <param name="type">Type of step (item, kit only, loop or pause).</param>
        public ItemAutoOrderStep(int? arbitraryScheduleDays = default(int?), decimal? arbitraryUnitCost = default(decimal?), List<ItemAutoOrderStepArbitraryUnitCostSchedule> arbitraryUnitCostSchedules = default(List<ItemAutoOrderStepArbitraryUnitCostSchedule>), List<ItemAutoOrderStepGrandfatherPricing> grandfatherPricing = default(List<ItemAutoOrderStepGrandfatherPricing>), string managedBy = default(string), int? pauseDays = default(int?), string pauseUntilDate = default(string), int? pauseUntilDayOfMonth = default(int?), int? pauseUntilMinimumDelayDays = default(int?), int? preshipmentNoticeDays = default(int?), string recurringMerchantItemId = default(string), int? recurringMerchantItemOid = default(int?), int? repeatCount = default(int?), string schedule = default(string), string subscribeEmailListName = default(string), int? subscribeEmailListOid = default(int?), TypeEnum? type = default(TypeEnum?))
        {
            this.ArbitraryScheduleDays = arbitraryScheduleDays;
            this.ArbitraryUnitCost = arbitraryUnitCost;
            this.ArbitraryUnitCostSchedules = arbitraryUnitCostSchedules;
            this.GrandfatherPricing = grandfatherPricing;
            this.ManagedBy = managedBy;
            this.PauseDays = pauseDays;
            this.PauseUntilDate = pauseUntilDate;
            this.PauseUntilDayOfMonth = pauseUntilDayOfMonth;
            this.PauseUntilMinimumDelayDays = pauseUntilMinimumDelayDays;
            this.PreshipmentNoticeDays = preshipmentNoticeDays;
            this.RecurringMerchantItemId = recurringMerchantItemId;
            this.RecurringMerchantItemOid = recurringMerchantItemOid;
            this.RepeatCount = repeatCount;
            this.Schedule = schedule;
            this.SubscribeEmailListName = subscribeEmailListName;
            this.SubscribeEmailListOid = subscribeEmailListOid;
            this.Type = type;
        }
        
        /// <summary>
        /// If the schedule is arbitrary, then this is the number of days
        /// </summary>
        /// <value>If the schedule is arbitrary, then this is the number of days</value>
        [DataMember(Name="arbitrary_schedule_days", EmitDefaultValue=false)]
        public int? ArbitraryScheduleDays { get; set; }

        /// <summary>
        /// Arbitrary unit cost used to override the regular item cost
        /// </summary>
        /// <value>Arbitrary unit cost used to override the regular item cost</value>
        [DataMember(Name="arbitrary_unit_cost", EmitDefaultValue=false)]
        public decimal? ArbitraryUnitCost { get; set; }

        /// <summary>
        /// Arbitrary unit costs schedules for more advanced discounting by rebill attempt
        /// </summary>
        /// <value>Arbitrary unit costs schedules for more advanced discounting by rebill attempt</value>
        [DataMember(Name="arbitrary_unit_cost_schedules", EmitDefaultValue=false)]
        public List<ItemAutoOrderStepArbitraryUnitCostSchedule> ArbitraryUnitCostSchedules { get; set; }

        /// <summary>
        /// Grand-father pricing configuration if the rebill schedule has changed over time
        /// </summary>
        /// <value>Grand-father pricing configuration if the rebill schedule has changed over time</value>
        [DataMember(Name="grandfather_pricing", EmitDefaultValue=false)]
        public List<ItemAutoOrderStepGrandfatherPricing> GrandfatherPricing { get; set; }

        /// <summary>
        /// Managed by (defaults to UltraCart)
        /// </summary>
        /// <value>Managed by (defaults to UltraCart)</value>
        [DataMember(Name="managed_by", EmitDefaultValue=false)]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Number of days to pause
        /// </summary>
        /// <value>Number of days to pause</value>
        [DataMember(Name="pause_days", EmitDefaultValue=false)]
        public int? PauseDays { get; set; }

        /// <summary>
        /// Wait for this step to happen until the specified date
        /// </summary>
        /// <value>Wait for this step to happen until the specified date</value>
        [DataMember(Name="pause_until_date", EmitDefaultValue=false)]
        public string PauseUntilDate { get; set; }

        /// <summary>
        /// Pause until a specific day of the month
        /// </summary>
        /// <value>Pause until a specific day of the month</value>
        [DataMember(Name="pause_until_day_of_month", EmitDefaultValue=false)]
        public int? PauseUntilDayOfMonth { get; set; }

        /// <summary>
        /// Pause at least this many days between the last order and the calculated next day of month
        /// </summary>
        /// <value>Pause at least this many days between the last order and the calculated next day of month</value>
        [DataMember(Name="pause_until_minimum_delay_days", EmitDefaultValue=false)]
        public int? PauseUntilMinimumDelayDays { get; set; }

        /// <summary>
        /// If set, a pre-shipment notice is sent to the customer this many days in advance
        /// </summary>
        /// <value>If set, a pre-shipment notice is sent to the customer this many days in advance</value>
        [DataMember(Name="preshipment_notice_days", EmitDefaultValue=false)]
        public int? PreshipmentNoticeDays { get; set; }

        /// <summary>
        /// Item id to rebill
        /// </summary>
        /// <value>Item id to rebill</value>
        [DataMember(Name="recurring_merchant_item_id", EmitDefaultValue=false)]
        public string RecurringMerchantItemId { get; set; }

        /// <summary>
        /// Item object identifier to rebill
        /// </summary>
        /// <value>Item object identifier to rebill</value>
        [DataMember(Name="recurring_merchant_item_oid", EmitDefaultValue=false)]
        public int? RecurringMerchantItemOid { get; set; }

        /// <summary>
        /// Number of times to rebill.  Last step can be null for infinite
        /// </summary>
        /// <value>Number of times to rebill.  Last step can be null for infinite</value>
        [DataMember(Name="repeat_count", EmitDefaultValue=false)]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// Frequency of the rebill
        /// </summary>
        /// <value>Frequency of the rebill</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// Email list name to subscribe the customer to when the rebill occurs (decommissioned email engine)
        /// </summary>
        /// <value>Email list name to subscribe the customer to when the rebill occurs (decommissioned email engine)</value>
        [DataMember(Name="subscribe_email_list_name", EmitDefaultValue=false)]
        public string SubscribeEmailListName { get; set; }

        /// <summary>
        /// Email list identifier to subscribe the customer to when this rebill occurs (decommissioned email engine)
        /// </summary>
        /// <value>Email list identifier to subscribe the customer to when this rebill occurs (decommissioned email engine)</value>
        [DataMember(Name="subscribe_email_list_oid", EmitDefaultValue=false)]
        public int? SubscribeEmailListOid { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemAutoOrderStep {\n");
            sb.Append("  ArbitraryScheduleDays: ").Append(ArbitraryScheduleDays).Append("\n");
            sb.Append("  ArbitraryUnitCost: ").Append(ArbitraryUnitCost).Append("\n");
            sb.Append("  ArbitraryUnitCostSchedules: ").Append(ArbitraryUnitCostSchedules).Append("\n");
            sb.Append("  GrandfatherPricing: ").Append(GrandfatherPricing).Append("\n");
            sb.Append("  ManagedBy: ").Append(ManagedBy).Append("\n");
            sb.Append("  PauseDays: ").Append(PauseDays).Append("\n");
            sb.Append("  PauseUntilDate: ").Append(PauseUntilDate).Append("\n");
            sb.Append("  PauseUntilDayOfMonth: ").Append(PauseUntilDayOfMonth).Append("\n");
            sb.Append("  PauseUntilMinimumDelayDays: ").Append(PauseUntilMinimumDelayDays).Append("\n");
            sb.Append("  PreshipmentNoticeDays: ").Append(PreshipmentNoticeDays).Append("\n");
            sb.Append("  RecurringMerchantItemId: ").Append(RecurringMerchantItemId).Append("\n");
            sb.Append("  RecurringMerchantItemOid: ").Append(RecurringMerchantItemOid).Append("\n");
            sb.Append("  RepeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SubscribeEmailListName: ").Append(SubscribeEmailListName).Append("\n");
            sb.Append("  SubscribeEmailListOid: ").Append(SubscribeEmailListOid).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemAutoOrderStep);
        }

        /// <summary>
        /// Returns true if ItemAutoOrderStep instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemAutoOrderStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemAutoOrderStep input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArbitraryScheduleDays == input.ArbitraryScheduleDays ||
                    (this.ArbitraryScheduleDays != null &&
                    this.ArbitraryScheduleDays.Equals(input.ArbitraryScheduleDays))
                ) && 
                (
                    this.ArbitraryUnitCost == input.ArbitraryUnitCost ||
                    (this.ArbitraryUnitCost != null &&
                    this.ArbitraryUnitCost.Equals(input.ArbitraryUnitCost))
                ) && 
                (
                    this.ArbitraryUnitCostSchedules == input.ArbitraryUnitCostSchedules ||
                    this.ArbitraryUnitCostSchedules != null &&
                    this.ArbitraryUnitCostSchedules.SequenceEqual(input.ArbitraryUnitCostSchedules)
                ) && 
                (
                    this.GrandfatherPricing == input.GrandfatherPricing ||
                    this.GrandfatherPricing != null &&
                    this.GrandfatherPricing.SequenceEqual(input.GrandfatherPricing)
                ) && 
                (
                    this.ManagedBy == input.ManagedBy ||
                    (this.ManagedBy != null &&
                    this.ManagedBy.Equals(input.ManagedBy))
                ) && 
                (
                    this.PauseDays == input.PauseDays ||
                    (this.PauseDays != null &&
                    this.PauseDays.Equals(input.PauseDays))
                ) && 
                (
                    this.PauseUntilDate == input.PauseUntilDate ||
                    (this.PauseUntilDate != null &&
                    this.PauseUntilDate.Equals(input.PauseUntilDate))
                ) && 
                (
                    this.PauseUntilDayOfMonth == input.PauseUntilDayOfMonth ||
                    (this.PauseUntilDayOfMonth != null &&
                    this.PauseUntilDayOfMonth.Equals(input.PauseUntilDayOfMonth))
                ) && 
                (
                    this.PauseUntilMinimumDelayDays == input.PauseUntilMinimumDelayDays ||
                    (this.PauseUntilMinimumDelayDays != null &&
                    this.PauseUntilMinimumDelayDays.Equals(input.PauseUntilMinimumDelayDays))
                ) && 
                (
                    this.PreshipmentNoticeDays == input.PreshipmentNoticeDays ||
                    (this.PreshipmentNoticeDays != null &&
                    this.PreshipmentNoticeDays.Equals(input.PreshipmentNoticeDays))
                ) && 
                (
                    this.RecurringMerchantItemId == input.RecurringMerchantItemId ||
                    (this.RecurringMerchantItemId != null &&
                    this.RecurringMerchantItemId.Equals(input.RecurringMerchantItemId))
                ) && 
                (
                    this.RecurringMerchantItemOid == input.RecurringMerchantItemOid ||
                    (this.RecurringMerchantItemOid != null &&
                    this.RecurringMerchantItemOid.Equals(input.RecurringMerchantItemOid))
                ) && 
                (
                    this.RepeatCount == input.RepeatCount ||
                    (this.RepeatCount != null &&
                    this.RepeatCount.Equals(input.RepeatCount))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.SubscribeEmailListName == input.SubscribeEmailListName ||
                    (this.SubscribeEmailListName != null &&
                    this.SubscribeEmailListName.Equals(input.SubscribeEmailListName))
                ) && 
                (
                    this.SubscribeEmailListOid == input.SubscribeEmailListOid ||
                    (this.SubscribeEmailListOid != null &&
                    this.SubscribeEmailListOid.Equals(input.SubscribeEmailListOid))
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
                if (this.ArbitraryScheduleDays != null)
                    hashCode = hashCode * 59 + this.ArbitraryScheduleDays.GetHashCode();
                if (this.ArbitraryUnitCost != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCost.GetHashCode();
                if (this.ArbitraryUnitCostSchedules != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCostSchedules.GetHashCode();
                if (this.GrandfatherPricing != null)
                    hashCode = hashCode * 59 + this.GrandfatherPricing.GetHashCode();
                if (this.ManagedBy != null)
                    hashCode = hashCode * 59 + this.ManagedBy.GetHashCode();
                if (this.PauseDays != null)
                    hashCode = hashCode * 59 + this.PauseDays.GetHashCode();
                if (this.PauseUntilDate != null)
                    hashCode = hashCode * 59 + this.PauseUntilDate.GetHashCode();
                if (this.PauseUntilDayOfMonth != null)
                    hashCode = hashCode * 59 + this.PauseUntilDayOfMonth.GetHashCode();
                if (this.PauseUntilMinimumDelayDays != null)
                    hashCode = hashCode * 59 + this.PauseUntilMinimumDelayDays.GetHashCode();
                if (this.PreshipmentNoticeDays != null)
                    hashCode = hashCode * 59 + this.PreshipmentNoticeDays.GetHashCode();
                if (this.RecurringMerchantItemId != null)
                    hashCode = hashCode * 59 + this.RecurringMerchantItemId.GetHashCode();
                if (this.RecurringMerchantItemOid != null)
                    hashCode = hashCode * 59 + this.RecurringMerchantItemOid.GetHashCode();
                if (this.RepeatCount != null)
                    hashCode = hashCode * 59 + this.RepeatCount.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.SubscribeEmailListName != null)
                    hashCode = hashCode * 59 + this.SubscribeEmailListName.GetHashCode();
                if (this.SubscribeEmailListOid != null)
                    hashCode = hashCode * 59 + this.SubscribeEmailListOid.GetHashCode();
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
            // RecurringMerchantItemId (string) maxLength
            if(this.RecurringMerchantItemId != null && this.RecurringMerchantItemId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecurringMerchantItemId, length must be less than 20.", new [] { "RecurringMerchantItemId" });
            }

            yield break;
        }
    }

}

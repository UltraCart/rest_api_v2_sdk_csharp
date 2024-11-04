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
    /// AutoOrderItem
    /// </summary>
    [DataContract]
    public partial class AutoOrderItem :  IEquatable<AutoOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Frequency of the rebill if not a fixed schedule
        /// </summary>
        /// <value>Frequency of the rebill if not a fixed schedule</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 1,
            
            /// <summary>
            /// Enum Biweekly for value: Biweekly
            /// </summary>
            [EnumMember(Value = "Biweekly")]
            Biweekly = 2,
            
            /// <summary>
            /// Enum Every for value: Every...
            /// </summary>
            [EnumMember(Value = "Every...")]
            Every = 3,
            
            /// <summary>
            /// Enum Every10Days for value: Every 10 Days
            /// </summary>
            [EnumMember(Value = "Every 10 Days")]
            Every10Days = 4,
            
            /// <summary>
            /// Enum Every24Days for value: Every 24 Days
            /// </summary>
            [EnumMember(Value = "Every 24 Days")]
            Every24Days = 5,
            
            /// <summary>
            /// Enum Every28Days for value: Every 28 Days
            /// </summary>
            [EnumMember(Value = "Every 28 Days")]
            Every28Days = 6,
            
            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 7,
            
            /// <summary>
            /// Enum Every45Days for value: Every 45 Days
            /// </summary>
            [EnumMember(Value = "Every 45 Days")]
            Every45Days = 8,
            
            /// <summary>
            /// Enum Every2Months for value: Every 2 Months
            /// </summary>
            [EnumMember(Value = "Every 2 Months")]
            Every2Months = 9,
            
            /// <summary>
            /// Enum Every3Months for value: Every 3 Months
            /// </summary>
            [EnumMember(Value = "Every 3 Months")]
            Every3Months = 10,
            
            /// <summary>
            /// Enum Every4Months for value: Every 4 Months
            /// </summary>
            [EnumMember(Value = "Every 4 Months")]
            Every4Months = 11,
            
            /// <summary>
            /// Enum Every5Months for value: Every 5 Months
            /// </summary>
            [EnumMember(Value = "Every 5 Months")]
            Every5Months = 12,
            
            /// <summary>
            /// Enum Every6Months for value: Every 6 Months
            /// </summary>
            [EnumMember(Value = "Every 6 Months")]
            Every6Months = 13,
            
            /// <summary>
            /// Enum Yearly for value: Yearly
            /// </summary>
            [EnumMember(Value = "Yearly")]
            Yearly = 14,
            
            /// <summary>
            /// Enum Every4Weeks for value: Every 4 Weeks
            /// </summary>
            [EnumMember(Value = "Every 4 Weeks")]
            Every4Weeks = 15,
            
            /// <summary>
            /// Enum Every6Weeks for value: Every 6 Weeks
            /// </summary>
            [EnumMember(Value = "Every 6 Weeks")]
            Every6Weeks = 16,
            
            /// <summary>
            /// Enum Every8Weeks for value: Every 8 Weeks
            /// </summary>
            [EnumMember(Value = "Every 8 Weeks")]
            Every8Weeks = 17
        }

        /// <summary>
        /// Frequency of the rebill if not a fixed schedule
        /// </summary>
        /// <value>Frequency of the rebill if not a fixed schedule</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoOrderItem" /> class.
        /// </summary>
        /// <param name="arbitraryItemId">Arbitrary item id that should be rebilled instead of the normal schedule.</param>
        /// <param name="arbitraryPercentageDiscount">An arbitrary percentage discount to provide on future rebills.</param>
        /// <param name="arbitraryQuantity">Arbitrary quantity to rebill.</param>
        /// <param name="arbitraryScheduleDays">The number of days to rebill if the frequency is set to an arbitrary number of days.</param>
        /// <param name="arbitraryUnitCost">Arbitrary unit cost that rebills of this item should occur at.</param>
        /// <param name="arbitraryUnitCostRemainingOrders">The number of rebills to give the arbitrary unit cost on before reverting to normal pricing..</param>
        /// <param name="autoOrderItemOid">Primary key of AutoOrderItem.</param>
        /// <param name="calculatedNextShipmentDts">Calculated Date/time that this item is scheduled to rebill.  Will be null if no more shipments are going to occur on this item.</param>
        /// <param name="firstOrderDts">Date/time of the first order of this item.  Null if item added to auto order and has not been rebilled yet..</param>
        /// <param name="frequency">Frequency of the rebill if not a fixed schedule.</param>
        /// <param name="futureSchedules">The future rebill schedule for this item up to the next ten rebills.</param>
        /// <param name="lastOrderDts">Date/time of the last order of this item.</param>
        /// <param name="lifeTimeValue">The life time value of this item including the original purchase.</param>
        /// <param name="nextItemId">Calculated next item id.</param>
        /// <param name="nextPreshipmentNoticeDts">The date/time of when the next pre-shipment notice should be sent.</param>
        /// <param name="nextShipmentDts">Date/time that this item is scheduled to rebill.</param>
        /// <param name="noOrderAfterDts">Date/time after which no additional rebills of this item should occur.</param>
        /// <param name="numberOfRebills">The number of times this item has rebilled.</param>
        /// <param name="options">Options associated with this item.</param>
        /// <param name="originalItemId">The original item id purchased.  This item controls scheduling.  If you wish to modify a schedule, for example, from monthly to yearly, change this item from your monthly item to your yearly item, and then change the next_shipment_dts to your desired date..</param>
        /// <param name="originalQuantity">The original quantity purchased.</param>
        /// <param name="paused">True if paused.  This field is an object instead of a primitive for backwards compatibility..</param>
        /// <param name="paypalPayerId">The PayPal Payer ID tied to this item.</param>
        /// <param name="paypalRecurringPaymentProfileId">The PayPal Profile ID tied to this item.</param>
        /// <param name="preshipmentNoticeSent">True if the preshipment notice associated with the next rebill has been sent.</param>
        /// <param name="rebillValue">The value of the rebills of this item.</param>
        /// <param name="remainingRepeatCount">The number of rebills remaining before this item is complete.</param>
        /// <param name="simpleSchedule">simpleSchedule.</param>
        public AutoOrderItem(string arbitraryItemId = default(string), decimal? arbitraryPercentageDiscount = default(decimal?), decimal? arbitraryQuantity = default(decimal?), int? arbitraryScheduleDays = default(int?), decimal? arbitraryUnitCost = default(decimal?), int? arbitraryUnitCostRemainingOrders = default(int?), int? autoOrderItemOid = default(int?), string calculatedNextShipmentDts = default(string), string firstOrderDts = default(string), FrequencyEnum? frequency = default(FrequencyEnum?), List<AutoOrderItemFutureSchedule> futureSchedules = default(List<AutoOrderItemFutureSchedule>), string lastOrderDts = default(string), decimal? lifeTimeValue = default(decimal?), string nextItemId = default(string), string nextPreshipmentNoticeDts = default(string), string nextShipmentDts = default(string), string noOrderAfterDts = default(string), int? numberOfRebills = default(int?), List<AutoOrderItemOption> options = default(List<AutoOrderItemOption>), string originalItemId = default(string), decimal? originalQuantity = default(decimal?), bool? paused = default(bool?), string paypalPayerId = default(string), string paypalRecurringPaymentProfileId = default(string), bool? preshipmentNoticeSent = default(bool?), decimal? rebillValue = default(decimal?), int? remainingRepeatCount = default(int?), AutoOrderItemSimpleSchedule simpleSchedule = default(AutoOrderItemSimpleSchedule))
        {
            this.ArbitraryItemId = arbitraryItemId;
            this.ArbitraryPercentageDiscount = arbitraryPercentageDiscount;
            this.ArbitraryQuantity = arbitraryQuantity;
            this.ArbitraryScheduleDays = arbitraryScheduleDays;
            this.ArbitraryUnitCost = arbitraryUnitCost;
            this.ArbitraryUnitCostRemainingOrders = arbitraryUnitCostRemainingOrders;
            this.AutoOrderItemOid = autoOrderItemOid;
            this.CalculatedNextShipmentDts = calculatedNextShipmentDts;
            this.FirstOrderDts = firstOrderDts;
            this.Frequency = frequency;
            this.FutureSchedules = futureSchedules;
            this.LastOrderDts = lastOrderDts;
            this.LifeTimeValue = lifeTimeValue;
            this.NextItemId = nextItemId;
            this.NextPreshipmentNoticeDts = nextPreshipmentNoticeDts;
            this.NextShipmentDts = nextShipmentDts;
            this.NoOrderAfterDts = noOrderAfterDts;
            this.NumberOfRebills = numberOfRebills;
            this.Options = options;
            this.OriginalItemId = originalItemId;
            this.OriginalQuantity = originalQuantity;
            this.Paused = paused;
            this.PaypalPayerId = paypalPayerId;
            this.PaypalRecurringPaymentProfileId = paypalRecurringPaymentProfileId;
            this.PreshipmentNoticeSent = preshipmentNoticeSent;
            this.RebillValue = rebillValue;
            this.RemainingRepeatCount = remainingRepeatCount;
            this.SimpleSchedule = simpleSchedule;
        }
        
        /// <summary>
        /// Arbitrary item id that should be rebilled instead of the normal schedule
        /// </summary>
        /// <value>Arbitrary item id that should be rebilled instead of the normal schedule</value>
        [DataMember(Name="arbitrary_item_id", EmitDefaultValue=false)]
        public string ArbitraryItemId { get; set; }

        /// <summary>
        /// An arbitrary percentage discount to provide on future rebills
        /// </summary>
        /// <value>An arbitrary percentage discount to provide on future rebills</value>
        [DataMember(Name="arbitrary_percentage_discount", EmitDefaultValue=false)]
        public decimal? ArbitraryPercentageDiscount { get; set; }

        /// <summary>
        /// Arbitrary quantity to rebill
        /// </summary>
        /// <value>Arbitrary quantity to rebill</value>
        [DataMember(Name="arbitrary_quantity", EmitDefaultValue=false)]
        public decimal? ArbitraryQuantity { get; set; }

        /// <summary>
        /// The number of days to rebill if the frequency is set to an arbitrary number of days
        /// </summary>
        /// <value>The number of days to rebill if the frequency is set to an arbitrary number of days</value>
        [DataMember(Name="arbitrary_schedule_days", EmitDefaultValue=false)]
        public int? ArbitraryScheduleDays { get; set; }

        /// <summary>
        /// Arbitrary unit cost that rebills of this item should occur at
        /// </summary>
        /// <value>Arbitrary unit cost that rebills of this item should occur at</value>
        [DataMember(Name="arbitrary_unit_cost", EmitDefaultValue=false)]
        public decimal? ArbitraryUnitCost { get; set; }

        /// <summary>
        /// The number of rebills to give the arbitrary unit cost on before reverting to normal pricing.
        /// </summary>
        /// <value>The number of rebills to give the arbitrary unit cost on before reverting to normal pricing.</value>
        [DataMember(Name="arbitrary_unit_cost_remaining_orders", EmitDefaultValue=false)]
        public int? ArbitraryUnitCostRemainingOrders { get; set; }

        /// <summary>
        /// Primary key of AutoOrderItem
        /// </summary>
        /// <value>Primary key of AutoOrderItem</value>
        [DataMember(Name="auto_order_item_oid", EmitDefaultValue=false)]
        public int? AutoOrderItemOid { get; set; }

        /// <summary>
        /// Calculated Date/time that this item is scheduled to rebill.  Will be null if no more shipments are going to occur on this item
        /// </summary>
        /// <value>Calculated Date/time that this item is scheduled to rebill.  Will be null if no more shipments are going to occur on this item</value>
        [DataMember(Name="calculated_next_shipment_dts", EmitDefaultValue=false)]
        public string CalculatedNextShipmentDts { get; set; }

        /// <summary>
        /// Date/time of the first order of this item.  Null if item added to auto order and has not been rebilled yet.
        /// </summary>
        /// <value>Date/time of the first order of this item.  Null if item added to auto order and has not been rebilled yet.</value>
        [DataMember(Name="first_order_dts", EmitDefaultValue=false)]
        public string FirstOrderDts { get; set; }


        /// <summary>
        /// The future rebill schedule for this item up to the next ten rebills
        /// </summary>
        /// <value>The future rebill schedule for this item up to the next ten rebills</value>
        [DataMember(Name="future_schedules", EmitDefaultValue=false)]
        public List<AutoOrderItemFutureSchedule> FutureSchedules { get; set; }

        /// <summary>
        /// Date/time of the last order of this item
        /// </summary>
        /// <value>Date/time of the last order of this item</value>
        [DataMember(Name="last_order_dts", EmitDefaultValue=false)]
        public string LastOrderDts { get; set; }

        /// <summary>
        /// The life time value of this item including the original purchase
        /// </summary>
        /// <value>The life time value of this item including the original purchase</value>
        [DataMember(Name="life_time_value", EmitDefaultValue=false)]
        public decimal? LifeTimeValue { get; set; }

        /// <summary>
        /// Calculated next item id
        /// </summary>
        /// <value>Calculated next item id</value>
        [DataMember(Name="next_item_id", EmitDefaultValue=false)]
        public string NextItemId { get; set; }

        /// <summary>
        /// The date/time of when the next pre-shipment notice should be sent
        /// </summary>
        /// <value>The date/time of when the next pre-shipment notice should be sent</value>
        [DataMember(Name="next_preshipment_notice_dts", EmitDefaultValue=false)]
        public string NextPreshipmentNoticeDts { get; set; }

        /// <summary>
        /// Date/time that this item is scheduled to rebill
        /// </summary>
        /// <value>Date/time that this item is scheduled to rebill</value>
        [DataMember(Name="next_shipment_dts", EmitDefaultValue=false)]
        public string NextShipmentDts { get; set; }

        /// <summary>
        /// Date/time after which no additional rebills of this item should occur
        /// </summary>
        /// <value>Date/time after which no additional rebills of this item should occur</value>
        [DataMember(Name="no_order_after_dts", EmitDefaultValue=false)]
        public string NoOrderAfterDts { get; set; }

        /// <summary>
        /// The number of times this item has rebilled
        /// </summary>
        /// <value>The number of times this item has rebilled</value>
        [DataMember(Name="number_of_rebills", EmitDefaultValue=false)]
        public int? NumberOfRebills { get; set; }

        /// <summary>
        /// Options associated with this item
        /// </summary>
        /// <value>Options associated with this item</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<AutoOrderItemOption> Options { get; set; }

        /// <summary>
        /// The original item id purchased.  This item controls scheduling.  If you wish to modify a schedule, for example, from monthly to yearly, change this item from your monthly item to your yearly item, and then change the next_shipment_dts to your desired date.
        /// </summary>
        /// <value>The original item id purchased.  This item controls scheduling.  If you wish to modify a schedule, for example, from monthly to yearly, change this item from your monthly item to your yearly item, and then change the next_shipment_dts to your desired date.</value>
        [DataMember(Name="original_item_id", EmitDefaultValue=false)]
        public string OriginalItemId { get; set; }

        /// <summary>
        /// The original quantity purchased
        /// </summary>
        /// <value>The original quantity purchased</value>
        [DataMember(Name="original_quantity", EmitDefaultValue=false)]
        public decimal? OriginalQuantity { get; set; }

        /// <summary>
        /// True if paused.  This field is an object instead of a primitive for backwards compatibility.
        /// </summary>
        /// <value>True if paused.  This field is an object instead of a primitive for backwards compatibility.</value>
        [DataMember(Name="paused", EmitDefaultValue=false)]
        public bool? Paused { get; set; }

        /// <summary>
        /// The PayPal Payer ID tied to this item
        /// </summary>
        /// <value>The PayPal Payer ID tied to this item</value>
        [DataMember(Name="paypal_payer_id", EmitDefaultValue=false)]
        public string PaypalPayerId { get; set; }

        /// <summary>
        /// The PayPal Profile ID tied to this item
        /// </summary>
        /// <value>The PayPal Profile ID tied to this item</value>
        [DataMember(Name="paypal_recurring_payment_profile_id", EmitDefaultValue=false)]
        public string PaypalRecurringPaymentProfileId { get; set; }

        /// <summary>
        /// True if the preshipment notice associated with the next rebill has been sent
        /// </summary>
        /// <value>True if the preshipment notice associated with the next rebill has been sent</value>
        [DataMember(Name="preshipment_notice_sent", EmitDefaultValue=false)]
        public bool? PreshipmentNoticeSent { get; set; }

        /// <summary>
        /// The value of the rebills of this item
        /// </summary>
        /// <value>The value of the rebills of this item</value>
        [DataMember(Name="rebill_value", EmitDefaultValue=false)]
        public decimal? RebillValue { get; set; }

        /// <summary>
        /// The number of rebills remaining before this item is complete
        /// </summary>
        /// <value>The number of rebills remaining before this item is complete</value>
        [DataMember(Name="remaining_repeat_count", EmitDefaultValue=false)]
        public int? RemainingRepeatCount { get; set; }

        /// <summary>
        /// Gets or Sets SimpleSchedule
        /// </summary>
        [DataMember(Name="simple_schedule", EmitDefaultValue=false)]
        public AutoOrderItemSimpleSchedule SimpleSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoOrderItem {\n");
            sb.Append("  ArbitraryItemId: ").Append(ArbitraryItemId).Append("\n");
            sb.Append("  ArbitraryPercentageDiscount: ").Append(ArbitraryPercentageDiscount).Append("\n");
            sb.Append("  ArbitraryQuantity: ").Append(ArbitraryQuantity).Append("\n");
            sb.Append("  ArbitraryScheduleDays: ").Append(ArbitraryScheduleDays).Append("\n");
            sb.Append("  ArbitraryUnitCost: ").Append(ArbitraryUnitCost).Append("\n");
            sb.Append("  ArbitraryUnitCostRemainingOrders: ").Append(ArbitraryUnitCostRemainingOrders).Append("\n");
            sb.Append("  AutoOrderItemOid: ").Append(AutoOrderItemOid).Append("\n");
            sb.Append("  CalculatedNextShipmentDts: ").Append(CalculatedNextShipmentDts).Append("\n");
            sb.Append("  FirstOrderDts: ").Append(FirstOrderDts).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  FutureSchedules: ").Append(FutureSchedules).Append("\n");
            sb.Append("  LastOrderDts: ").Append(LastOrderDts).Append("\n");
            sb.Append("  LifeTimeValue: ").Append(LifeTimeValue).Append("\n");
            sb.Append("  NextItemId: ").Append(NextItemId).Append("\n");
            sb.Append("  NextPreshipmentNoticeDts: ").Append(NextPreshipmentNoticeDts).Append("\n");
            sb.Append("  NextShipmentDts: ").Append(NextShipmentDts).Append("\n");
            sb.Append("  NoOrderAfterDts: ").Append(NoOrderAfterDts).Append("\n");
            sb.Append("  NumberOfRebills: ").Append(NumberOfRebills).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  OriginalItemId: ").Append(OriginalItemId).Append("\n");
            sb.Append("  OriginalQuantity: ").Append(OriginalQuantity).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  PaypalPayerId: ").Append(PaypalPayerId).Append("\n");
            sb.Append("  PaypalRecurringPaymentProfileId: ").Append(PaypalRecurringPaymentProfileId).Append("\n");
            sb.Append("  PreshipmentNoticeSent: ").Append(PreshipmentNoticeSent).Append("\n");
            sb.Append("  RebillValue: ").Append(RebillValue).Append("\n");
            sb.Append("  RemainingRepeatCount: ").Append(RemainingRepeatCount).Append("\n");
            sb.Append("  SimpleSchedule: ").Append(SimpleSchedule).Append("\n");
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
            return this.Equals(input as AutoOrderItem);
        }

        /// <summary>
        /// Returns true if AutoOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoOrderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArbitraryItemId == input.ArbitraryItemId ||
                    (this.ArbitraryItemId != null &&
                    this.ArbitraryItemId.Equals(input.ArbitraryItemId))
                ) && 
                (
                    this.ArbitraryPercentageDiscount == input.ArbitraryPercentageDiscount ||
                    (this.ArbitraryPercentageDiscount != null &&
                    this.ArbitraryPercentageDiscount.Equals(input.ArbitraryPercentageDiscount))
                ) && 
                (
                    this.ArbitraryQuantity == input.ArbitraryQuantity ||
                    (this.ArbitraryQuantity != null &&
                    this.ArbitraryQuantity.Equals(input.ArbitraryQuantity))
                ) && 
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
                    this.ArbitraryUnitCostRemainingOrders == input.ArbitraryUnitCostRemainingOrders ||
                    (this.ArbitraryUnitCostRemainingOrders != null &&
                    this.ArbitraryUnitCostRemainingOrders.Equals(input.ArbitraryUnitCostRemainingOrders))
                ) && 
                (
                    this.AutoOrderItemOid == input.AutoOrderItemOid ||
                    (this.AutoOrderItemOid != null &&
                    this.AutoOrderItemOid.Equals(input.AutoOrderItemOid))
                ) && 
                (
                    this.CalculatedNextShipmentDts == input.CalculatedNextShipmentDts ||
                    (this.CalculatedNextShipmentDts != null &&
                    this.CalculatedNextShipmentDts.Equals(input.CalculatedNextShipmentDts))
                ) && 
                (
                    this.FirstOrderDts == input.FirstOrderDts ||
                    (this.FirstOrderDts != null &&
                    this.FirstOrderDts.Equals(input.FirstOrderDts))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.FutureSchedules == input.FutureSchedules ||
                    this.FutureSchedules != null &&
                    this.FutureSchedules.SequenceEqual(input.FutureSchedules)
                ) && 
                (
                    this.LastOrderDts == input.LastOrderDts ||
                    (this.LastOrderDts != null &&
                    this.LastOrderDts.Equals(input.LastOrderDts))
                ) && 
                (
                    this.LifeTimeValue == input.LifeTimeValue ||
                    (this.LifeTimeValue != null &&
                    this.LifeTimeValue.Equals(input.LifeTimeValue))
                ) && 
                (
                    this.NextItemId == input.NextItemId ||
                    (this.NextItemId != null &&
                    this.NextItemId.Equals(input.NextItemId))
                ) && 
                (
                    this.NextPreshipmentNoticeDts == input.NextPreshipmentNoticeDts ||
                    (this.NextPreshipmentNoticeDts != null &&
                    this.NextPreshipmentNoticeDts.Equals(input.NextPreshipmentNoticeDts))
                ) && 
                (
                    this.NextShipmentDts == input.NextShipmentDts ||
                    (this.NextShipmentDts != null &&
                    this.NextShipmentDts.Equals(input.NextShipmentDts))
                ) && 
                (
                    this.NoOrderAfterDts == input.NoOrderAfterDts ||
                    (this.NoOrderAfterDts != null &&
                    this.NoOrderAfterDts.Equals(input.NoOrderAfterDts))
                ) && 
                (
                    this.NumberOfRebills == input.NumberOfRebills ||
                    (this.NumberOfRebills != null &&
                    this.NumberOfRebills.Equals(input.NumberOfRebills))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.OriginalItemId == input.OriginalItemId ||
                    (this.OriginalItemId != null &&
                    this.OriginalItemId.Equals(input.OriginalItemId))
                ) && 
                (
                    this.OriginalQuantity == input.OriginalQuantity ||
                    (this.OriginalQuantity != null &&
                    this.OriginalQuantity.Equals(input.OriginalQuantity))
                ) && 
                (
                    this.Paused == input.Paused ||
                    (this.Paused != null &&
                    this.Paused.Equals(input.Paused))
                ) && 
                (
                    this.PaypalPayerId == input.PaypalPayerId ||
                    (this.PaypalPayerId != null &&
                    this.PaypalPayerId.Equals(input.PaypalPayerId))
                ) && 
                (
                    this.PaypalRecurringPaymentProfileId == input.PaypalRecurringPaymentProfileId ||
                    (this.PaypalRecurringPaymentProfileId != null &&
                    this.PaypalRecurringPaymentProfileId.Equals(input.PaypalRecurringPaymentProfileId))
                ) && 
                (
                    this.PreshipmentNoticeSent == input.PreshipmentNoticeSent ||
                    (this.PreshipmentNoticeSent != null &&
                    this.PreshipmentNoticeSent.Equals(input.PreshipmentNoticeSent))
                ) && 
                (
                    this.RebillValue == input.RebillValue ||
                    (this.RebillValue != null &&
                    this.RebillValue.Equals(input.RebillValue))
                ) && 
                (
                    this.RemainingRepeatCount == input.RemainingRepeatCount ||
                    (this.RemainingRepeatCount != null &&
                    this.RemainingRepeatCount.Equals(input.RemainingRepeatCount))
                ) && 
                (
                    this.SimpleSchedule == input.SimpleSchedule ||
                    (this.SimpleSchedule != null &&
                    this.SimpleSchedule.Equals(input.SimpleSchedule))
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
                if (this.ArbitraryItemId != null)
                    hashCode = hashCode * 59 + this.ArbitraryItemId.GetHashCode();
                if (this.ArbitraryPercentageDiscount != null)
                    hashCode = hashCode * 59 + this.ArbitraryPercentageDiscount.GetHashCode();
                if (this.ArbitraryQuantity != null)
                    hashCode = hashCode * 59 + this.ArbitraryQuantity.GetHashCode();
                if (this.ArbitraryScheduleDays != null)
                    hashCode = hashCode * 59 + this.ArbitraryScheduleDays.GetHashCode();
                if (this.ArbitraryUnitCost != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCost.GetHashCode();
                if (this.ArbitraryUnitCostRemainingOrders != null)
                    hashCode = hashCode * 59 + this.ArbitraryUnitCostRemainingOrders.GetHashCode();
                if (this.AutoOrderItemOid != null)
                    hashCode = hashCode * 59 + this.AutoOrderItemOid.GetHashCode();
                if (this.CalculatedNextShipmentDts != null)
                    hashCode = hashCode * 59 + this.CalculatedNextShipmentDts.GetHashCode();
                if (this.FirstOrderDts != null)
                    hashCode = hashCode * 59 + this.FirstOrderDts.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.FutureSchedules != null)
                    hashCode = hashCode * 59 + this.FutureSchedules.GetHashCode();
                if (this.LastOrderDts != null)
                    hashCode = hashCode * 59 + this.LastOrderDts.GetHashCode();
                if (this.LifeTimeValue != null)
                    hashCode = hashCode * 59 + this.LifeTimeValue.GetHashCode();
                if (this.NextItemId != null)
                    hashCode = hashCode * 59 + this.NextItemId.GetHashCode();
                if (this.NextPreshipmentNoticeDts != null)
                    hashCode = hashCode * 59 + this.NextPreshipmentNoticeDts.GetHashCode();
                if (this.NextShipmentDts != null)
                    hashCode = hashCode * 59 + this.NextShipmentDts.GetHashCode();
                if (this.NoOrderAfterDts != null)
                    hashCode = hashCode * 59 + this.NoOrderAfterDts.GetHashCode();
                if (this.NumberOfRebills != null)
                    hashCode = hashCode * 59 + this.NumberOfRebills.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.OriginalItemId != null)
                    hashCode = hashCode * 59 + this.OriginalItemId.GetHashCode();
                if (this.OriginalQuantity != null)
                    hashCode = hashCode * 59 + this.OriginalQuantity.GetHashCode();
                if (this.Paused != null)
                    hashCode = hashCode * 59 + this.Paused.GetHashCode();
                if (this.PaypalPayerId != null)
                    hashCode = hashCode * 59 + this.PaypalPayerId.GetHashCode();
                if (this.PaypalRecurringPaymentProfileId != null)
                    hashCode = hashCode * 59 + this.PaypalRecurringPaymentProfileId.GetHashCode();
                if (this.PreshipmentNoticeSent != null)
                    hashCode = hashCode * 59 + this.PreshipmentNoticeSent.GetHashCode();
                if (this.RebillValue != null)
                    hashCode = hashCode * 59 + this.RebillValue.GetHashCode();
                if (this.RemainingRepeatCount != null)
                    hashCode = hashCode * 59 + this.RemainingRepeatCount.GetHashCode();
                if (this.SimpleSchedule != null)
                    hashCode = hashCode * 59 + this.SimpleSchedule.GetHashCode();
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

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
    /// IntegrationLogQueryRequest
    /// </summary>
    [DataContract]
    public partial class IntegrationLogQueryRequest :  IEquatable<IntegrationLogQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationLogQueryRequest" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="direction">direction.</param>
        /// <param name="email">email.</param>
        /// <param name="fileNames">fileNames.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="itemIpnOid">itemIpnOid.</param>
        /// <param name="logDtsBegin">Log date/time begin.</param>
        /// <param name="logDtsEnd">Log date/time end.</param>
        /// <param name="logType">logType.</param>
        /// <param name="loggerId">loggerId.</param>
        /// <param name="loggerName">loggerName.</param>
        /// <param name="orderIds">orderIds.</param>
        /// <param name="status">status.</param>
        public IntegrationLogQueryRequest(string action = default(string), string direction = default(string), string email = default(string), List<string> fileNames = default(List<string>), string itemId = default(string), int? itemIpnOid = default(int?), string logDtsBegin = default(string), string logDtsEnd = default(string), string logType = default(string), string loggerId = default(string), string loggerName = default(string), List<string> orderIds = default(List<string>), string status = default(string))
        {
            this.Action = action;
            this.Direction = direction;
            this.Email = email;
            this.FileNames = fileNames;
            this.ItemId = itemId;
            this.ItemIpnOid = itemIpnOid;
            this.LogDtsBegin = logDtsBegin;
            this.LogDtsEnd = logDtsEnd;
            this.LogType = logType;
            this.LoggerId = loggerId;
            this.LoggerName = loggerName;
            this.OrderIds = orderIds;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FileNames
        /// </summary>
        [DataMember(Name="file_names", EmitDefaultValue=false)]
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets ItemIpnOid
        /// </summary>
        [DataMember(Name="item_ipn_oid", EmitDefaultValue=false)]
        public int? ItemIpnOid { get; set; }

        /// <summary>
        /// Log date/time begin
        /// </summary>
        /// <value>Log date/time begin</value>
        [DataMember(Name="log_dts_begin", EmitDefaultValue=false)]
        public string LogDtsBegin { get; set; }

        /// <summary>
        /// Log date/time end
        /// </summary>
        /// <value>Log date/time end</value>
        [DataMember(Name="log_dts_end", EmitDefaultValue=false)]
        public string LogDtsEnd { get; set; }

        /// <summary>
        /// Gets or Sets LogType
        /// </summary>
        [DataMember(Name="log_type", EmitDefaultValue=false)]
        public string LogType { get; set; }

        /// <summary>
        /// Gets or Sets LoggerId
        /// </summary>
        [DataMember(Name="logger_id", EmitDefaultValue=false)]
        public string LoggerId { get; set; }

        /// <summary>
        /// Gets or Sets LoggerName
        /// </summary>
        [DataMember(Name="logger_name", EmitDefaultValue=false)]
        public string LoggerName { get; set; }

        /// <summary>
        /// Gets or Sets OrderIds
        /// </summary>
        [DataMember(Name="order_ids", EmitDefaultValue=false)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationLogQueryRequest {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FileNames: ").Append(FileNames).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemIpnOid: ").Append(ItemIpnOid).Append("\n");
            sb.Append("  LogDtsBegin: ").Append(LogDtsBegin).Append("\n");
            sb.Append("  LogDtsEnd: ").Append(LogDtsEnd).Append("\n");
            sb.Append("  LogType: ").Append(LogType).Append("\n");
            sb.Append("  LoggerId: ").Append(LoggerId).Append("\n");
            sb.Append("  LoggerName: ").Append(LoggerName).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as IntegrationLogQueryRequest);
        }

        /// <summary>
        /// Returns true if IntegrationLogQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationLogQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationLogQueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    this.FileNames.SequenceEqual(input.FileNames)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemIpnOid == input.ItemIpnOid ||
                    (this.ItemIpnOid != null &&
                    this.ItemIpnOid.Equals(input.ItemIpnOid))
                ) && 
                (
                    this.LogDtsBegin == input.LogDtsBegin ||
                    (this.LogDtsBegin != null &&
                    this.LogDtsBegin.Equals(input.LogDtsBegin))
                ) && 
                (
                    this.LogDtsEnd == input.LogDtsEnd ||
                    (this.LogDtsEnd != null &&
                    this.LogDtsEnd.Equals(input.LogDtsEnd))
                ) && 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
                ) && 
                (
                    this.LoggerId == input.LoggerId ||
                    (this.LoggerId != null &&
                    this.LoggerId.Equals(input.LoggerId))
                ) && 
                (
                    this.LoggerName == input.LoggerName ||
                    (this.LoggerName != null &&
                    this.LoggerName.Equals(input.LoggerName))
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemIpnOid != null)
                    hashCode = hashCode * 59 + this.ItemIpnOid.GetHashCode();
                if (this.LogDtsBegin != null)
                    hashCode = hashCode * 59 + this.LogDtsBegin.GetHashCode();
                if (this.LogDtsEnd != null)
                    hashCode = hashCode * 59 + this.LogDtsEnd.GetHashCode();
                if (this.LogType != null)
                    hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LoggerId != null)
                    hashCode = hashCode * 59 + this.LoggerId.GetHashCode();
                if (this.LoggerName != null)
                    hashCode = hashCode * 59 + this.LoggerName.GetHashCode();
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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

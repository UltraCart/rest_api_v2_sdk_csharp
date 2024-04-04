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
    /// WorkflowTasksRequest
    /// </summary>
    [DataContract]
    public partial class WorkflowTasksRequest :  IEquatable<WorkflowTasksRequest>, IValidatableObject
    {
        /// <summary>
        /// Object Type
        /// </summary>
        /// <value>Object Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            
            /// <summary>
            /// Enum Order for value: order
            /// </summary>
            [EnumMember(Value = "order")]
            Order = 1,
            
            /// <summary>
            /// Enum Autoorder for value: auto order
            /// </summary>
            [EnumMember(Value = "auto order")]
            Autoorder = 2,
            
            /// <summary>
            /// Enum Item for value: item
            /// </summary>
            [EnumMember(Value = "item")]
            Item = 3,
            
            /// <summary>
            /// Enum Customerprofile for value: customer profile
            /// </summary>
            [EnumMember(Value = "customer profile")]
            Customerprofile = 4
        }

        /// <summary>
        /// Object Type
        /// </summary>
        /// <value>Object Type</value>
        [DataMember(Name="object_type", EmitDefaultValue=false)]
        public ObjectTypeEnum? ObjectType { get; set; }
        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            
            /// <summary>
            /// Enum _1low for value: 1 - low
            /// </summary>
            [EnumMember(Value = "1 - low")]
            _1low = 1,
            
            /// <summary>
            /// Enum _2medium for value: 2 - medium
            /// </summary>
            [EnumMember(Value = "2 - medium")]
            _2medium = 2,
            
            /// <summary>
            /// Enum _3high for value: 3 - high
            /// </summary>
            [EnumMember(Value = "3 - high")]
            _3high = 3,
            
            /// <summary>
            /// Enum _4critical for value: 4 - critical
            /// </summary>
            [EnumMember(Value = "4 - critical")]
            _4critical = 4
        }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Status of the workflow task
        /// </summary>
        /// <value>Status of the workflow task</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,
            
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,
            
            /// <summary>
            /// Enum Delayed for value: delayed
            /// </summary>
            [EnumMember(Value = "delayed")]
            Delayed = 3,
            
            /// <summary>
            /// Enum Awaitingcustomerfeedback for value: awaiting customer feedback
            /// </summary>
            [EnumMember(Value = "awaiting customer feedback")]
            Awaitingcustomerfeedback = 4
        }

        /// <summary>
        /// Status of the workflow task
        /// </summary>
        /// <value>Status of the workflow task</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTasksRequest" /> class.
        /// </summary>
        /// <param name="assignedToGroup">Assigned to group.</param>
        /// <param name="assignedToGroupId">Assigned to group ID.</param>
        /// <param name="assignedToMe">Tasks are assigned to me either by direct user id or a group that the user is a member of.</param>
        /// <param name="assignedToUser">Assigned to user.</param>
        /// <param name="assignedToUserId">Assigned to user ID.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDtsBegin">Date/time that the workflow task was created.</param>
        /// <param name="createdDtsEnd">Date/time that the workflow task was created.</param>
        /// <param name="delayUntilDtsBegin">Date/time that the workflow task should delay until.</param>
        /// <param name="delayUntilDtsEnd">Date/time that the workflow task should delay until.</param>
        /// <param name="dueDtsBegin">Date/time that the workflow task is due.</param>
        /// <param name="dueDtsEnd">Date/time that the workflow task is due.</param>
        /// <param name="lastUpdateDtsBegin">Date/time that the workflow task was last updated.</param>
        /// <param name="lastUpdateDtsEnd">Date/time that the workflow task was last updated.</param>
        /// <param name="objectEmail">Object is associated with customer email.</param>
        /// <param name="objectType">Object Type.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="status">Status of the workflow task.</param>
        /// <param name="tags">Tasks that are tagged with the specified tags.</param>
        /// <param name="unassigned">Tasks that are unassigned to a user or group.</param>
        public WorkflowTasksRequest(string assignedToGroup = default(string), int? assignedToGroupId = default(int?), bool? assignedToMe = default(bool?), string assignedToUser = default(string), int? assignedToUserId = default(int?), WorkflowUser createdBy = default(WorkflowUser), string createdDtsBegin = default(string), string createdDtsEnd = default(string), string delayUntilDtsBegin = default(string), string delayUntilDtsEnd = default(string), string dueDtsBegin = default(string), string dueDtsEnd = default(string), string lastUpdateDtsBegin = default(string), string lastUpdateDtsEnd = default(string), string objectEmail = default(string), ObjectTypeEnum? objectType = default(ObjectTypeEnum?), PriorityEnum? priority = default(PriorityEnum?), StatusEnum? status = default(StatusEnum?), List<string> tags = default(List<string>), bool? unassigned = default(bool?))
        {
            this.AssignedToGroup = assignedToGroup;
            this.AssignedToGroupId = assignedToGroupId;
            this.AssignedToMe = assignedToMe;
            this.AssignedToUser = assignedToUser;
            this.AssignedToUserId = assignedToUserId;
            this.CreatedBy = createdBy;
            this.CreatedDtsBegin = createdDtsBegin;
            this.CreatedDtsEnd = createdDtsEnd;
            this.DelayUntilDtsBegin = delayUntilDtsBegin;
            this.DelayUntilDtsEnd = delayUntilDtsEnd;
            this.DueDtsBegin = dueDtsBegin;
            this.DueDtsEnd = dueDtsEnd;
            this.LastUpdateDtsBegin = lastUpdateDtsBegin;
            this.LastUpdateDtsEnd = lastUpdateDtsEnd;
            this.ObjectEmail = objectEmail;
            this.ObjectType = objectType;
            this.Priority = priority;
            this.Status = status;
            this.Tags = tags;
            this.Unassigned = unassigned;
        }
        
        /// <summary>
        /// Assigned to group
        /// </summary>
        /// <value>Assigned to group</value>
        [DataMember(Name="assigned_to_group", EmitDefaultValue=false)]
        public string AssignedToGroup { get; set; }

        /// <summary>
        /// Assigned to group ID
        /// </summary>
        /// <value>Assigned to group ID</value>
        [DataMember(Name="assigned_to_group_id", EmitDefaultValue=false)]
        public int? AssignedToGroupId { get; set; }

        /// <summary>
        /// Tasks are assigned to me either by direct user id or a group that the user is a member of
        /// </summary>
        /// <value>Tasks are assigned to me either by direct user id or a group that the user is a member of</value>
        [DataMember(Name="assigned_to_me", EmitDefaultValue=false)]
        public bool? AssignedToMe { get; set; }

        /// <summary>
        /// Assigned to user
        /// </summary>
        /// <value>Assigned to user</value>
        [DataMember(Name="assigned_to_user", EmitDefaultValue=false)]
        public string AssignedToUser { get; set; }

        /// <summary>
        /// Assigned to user ID
        /// </summary>
        /// <value>Assigned to user ID</value>
        [DataMember(Name="assigned_to_user_id", EmitDefaultValue=false)]
        public int? AssignedToUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public WorkflowUser CreatedBy { get; set; }

        /// <summary>
        /// Date/time that the workflow task was created
        /// </summary>
        /// <value>Date/time that the workflow task was created</value>
        [DataMember(Name="created_dts_begin", EmitDefaultValue=false)]
        public string CreatedDtsBegin { get; set; }

        /// <summary>
        /// Date/time that the workflow task was created
        /// </summary>
        /// <value>Date/time that the workflow task was created</value>
        [DataMember(Name="created_dts_end", EmitDefaultValue=false)]
        public string CreatedDtsEnd { get; set; }

        /// <summary>
        /// Date/time that the workflow task should delay until
        /// </summary>
        /// <value>Date/time that the workflow task should delay until</value>
        [DataMember(Name="delay_until_dts_begin", EmitDefaultValue=false)]
        public string DelayUntilDtsBegin { get; set; }

        /// <summary>
        /// Date/time that the workflow task should delay until
        /// </summary>
        /// <value>Date/time that the workflow task should delay until</value>
        [DataMember(Name="delay_until_dts_end", EmitDefaultValue=false)]
        public string DelayUntilDtsEnd { get; set; }

        /// <summary>
        /// Date/time that the workflow task is due
        /// </summary>
        /// <value>Date/time that the workflow task is due</value>
        [DataMember(Name="due_dts_begin", EmitDefaultValue=false)]
        public string DueDtsBegin { get; set; }

        /// <summary>
        /// Date/time that the workflow task is due
        /// </summary>
        /// <value>Date/time that the workflow task is due</value>
        [DataMember(Name="due_dts_end", EmitDefaultValue=false)]
        public string DueDtsEnd { get; set; }

        /// <summary>
        /// Date/time that the workflow task was last updated
        /// </summary>
        /// <value>Date/time that the workflow task was last updated</value>
        [DataMember(Name="last_update_dts_begin", EmitDefaultValue=false)]
        public string LastUpdateDtsBegin { get; set; }

        /// <summary>
        /// Date/time that the workflow task was last updated
        /// </summary>
        /// <value>Date/time that the workflow task was last updated</value>
        [DataMember(Name="last_update_dts_end", EmitDefaultValue=false)]
        public string LastUpdateDtsEnd { get; set; }

        /// <summary>
        /// Object is associated with customer email
        /// </summary>
        /// <value>Object is associated with customer email</value>
        [DataMember(Name="object_email", EmitDefaultValue=false)]
        public string ObjectEmail { get; set; }




        /// <summary>
        /// Tasks that are tagged with the specified tags
        /// </summary>
        /// <value>Tasks that are tagged with the specified tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Tasks that are unassigned to a user or group
        /// </summary>
        /// <value>Tasks that are unassigned to a user or group</value>
        [DataMember(Name="unassigned", EmitDefaultValue=false)]
        public bool? Unassigned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTasksRequest {\n");
            sb.Append("  AssignedToGroup: ").Append(AssignedToGroup).Append("\n");
            sb.Append("  AssignedToGroupId: ").Append(AssignedToGroupId).Append("\n");
            sb.Append("  AssignedToMe: ").Append(AssignedToMe).Append("\n");
            sb.Append("  AssignedToUser: ").Append(AssignedToUser).Append("\n");
            sb.Append("  AssignedToUserId: ").Append(AssignedToUserId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDtsBegin: ").Append(CreatedDtsBegin).Append("\n");
            sb.Append("  CreatedDtsEnd: ").Append(CreatedDtsEnd).Append("\n");
            sb.Append("  DelayUntilDtsBegin: ").Append(DelayUntilDtsBegin).Append("\n");
            sb.Append("  DelayUntilDtsEnd: ").Append(DelayUntilDtsEnd).Append("\n");
            sb.Append("  DueDtsBegin: ").Append(DueDtsBegin).Append("\n");
            sb.Append("  DueDtsEnd: ").Append(DueDtsEnd).Append("\n");
            sb.Append("  LastUpdateDtsBegin: ").Append(LastUpdateDtsBegin).Append("\n");
            sb.Append("  LastUpdateDtsEnd: ").Append(LastUpdateDtsEnd).Append("\n");
            sb.Append("  ObjectEmail: ").Append(ObjectEmail).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Unassigned: ").Append(Unassigned).Append("\n");
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
            return this.Equals(input as WorkflowTasksRequest);
        }

        /// <summary>
        /// Returns true if WorkflowTasksRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowTasksRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowTasksRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssignedToGroup == input.AssignedToGroup ||
                    (this.AssignedToGroup != null &&
                    this.AssignedToGroup.Equals(input.AssignedToGroup))
                ) && 
                (
                    this.AssignedToGroupId == input.AssignedToGroupId ||
                    (this.AssignedToGroupId != null &&
                    this.AssignedToGroupId.Equals(input.AssignedToGroupId))
                ) && 
                (
                    this.AssignedToMe == input.AssignedToMe ||
                    (this.AssignedToMe != null &&
                    this.AssignedToMe.Equals(input.AssignedToMe))
                ) && 
                (
                    this.AssignedToUser == input.AssignedToUser ||
                    (this.AssignedToUser != null &&
                    this.AssignedToUser.Equals(input.AssignedToUser))
                ) && 
                (
                    this.AssignedToUserId == input.AssignedToUserId ||
                    (this.AssignedToUserId != null &&
                    this.AssignedToUserId.Equals(input.AssignedToUserId))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDtsBegin == input.CreatedDtsBegin ||
                    (this.CreatedDtsBegin != null &&
                    this.CreatedDtsBegin.Equals(input.CreatedDtsBegin))
                ) && 
                (
                    this.CreatedDtsEnd == input.CreatedDtsEnd ||
                    (this.CreatedDtsEnd != null &&
                    this.CreatedDtsEnd.Equals(input.CreatedDtsEnd))
                ) && 
                (
                    this.DelayUntilDtsBegin == input.DelayUntilDtsBegin ||
                    (this.DelayUntilDtsBegin != null &&
                    this.DelayUntilDtsBegin.Equals(input.DelayUntilDtsBegin))
                ) && 
                (
                    this.DelayUntilDtsEnd == input.DelayUntilDtsEnd ||
                    (this.DelayUntilDtsEnd != null &&
                    this.DelayUntilDtsEnd.Equals(input.DelayUntilDtsEnd))
                ) && 
                (
                    this.DueDtsBegin == input.DueDtsBegin ||
                    (this.DueDtsBegin != null &&
                    this.DueDtsBegin.Equals(input.DueDtsBegin))
                ) && 
                (
                    this.DueDtsEnd == input.DueDtsEnd ||
                    (this.DueDtsEnd != null &&
                    this.DueDtsEnd.Equals(input.DueDtsEnd))
                ) && 
                (
                    this.LastUpdateDtsBegin == input.LastUpdateDtsBegin ||
                    (this.LastUpdateDtsBegin != null &&
                    this.LastUpdateDtsBegin.Equals(input.LastUpdateDtsBegin))
                ) && 
                (
                    this.LastUpdateDtsEnd == input.LastUpdateDtsEnd ||
                    (this.LastUpdateDtsEnd != null &&
                    this.LastUpdateDtsEnd.Equals(input.LastUpdateDtsEnd))
                ) && 
                (
                    this.ObjectEmail == input.ObjectEmail ||
                    (this.ObjectEmail != null &&
                    this.ObjectEmail.Equals(input.ObjectEmail))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Unassigned == input.Unassigned ||
                    (this.Unassigned != null &&
                    this.Unassigned.Equals(input.Unassigned))
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
                if (this.AssignedToGroup != null)
                    hashCode = hashCode * 59 + this.AssignedToGroup.GetHashCode();
                if (this.AssignedToGroupId != null)
                    hashCode = hashCode * 59 + this.AssignedToGroupId.GetHashCode();
                if (this.AssignedToMe != null)
                    hashCode = hashCode * 59 + this.AssignedToMe.GetHashCode();
                if (this.AssignedToUser != null)
                    hashCode = hashCode * 59 + this.AssignedToUser.GetHashCode();
                if (this.AssignedToUserId != null)
                    hashCode = hashCode * 59 + this.AssignedToUserId.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDtsBegin != null)
                    hashCode = hashCode * 59 + this.CreatedDtsBegin.GetHashCode();
                if (this.CreatedDtsEnd != null)
                    hashCode = hashCode * 59 + this.CreatedDtsEnd.GetHashCode();
                if (this.DelayUntilDtsBegin != null)
                    hashCode = hashCode * 59 + this.DelayUntilDtsBegin.GetHashCode();
                if (this.DelayUntilDtsEnd != null)
                    hashCode = hashCode * 59 + this.DelayUntilDtsEnd.GetHashCode();
                if (this.DueDtsBegin != null)
                    hashCode = hashCode * 59 + this.DueDtsBegin.GetHashCode();
                if (this.DueDtsEnd != null)
                    hashCode = hashCode * 59 + this.DueDtsEnd.GetHashCode();
                if (this.LastUpdateDtsBegin != null)
                    hashCode = hashCode * 59 + this.LastUpdateDtsBegin.GetHashCode();
                if (this.LastUpdateDtsEnd != null)
                    hashCode = hashCode * 59 + this.LastUpdateDtsEnd.GetHashCode();
                if (this.ObjectEmail != null)
                    hashCode = hashCode * 59 + this.ObjectEmail.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Unassigned != null)
                    hashCode = hashCode * 59 + this.Unassigned.GetHashCode();
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

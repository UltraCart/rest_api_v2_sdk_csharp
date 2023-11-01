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
    /// WorkflowTask
    /// </summary>
    [DataContract]
    public partial class WorkflowTask :  IEquatable<WorkflowTask>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="WorkflowTask" /> class.
        /// </summary>
        /// <param name="assignedToGroup">Assigned to group.</param>
        /// <param name="assignedToGroupId">Assigned to group ID.</param>
        /// <param name="assignedToUser">Assigned to user.</param>
        /// <param name="assignedToUserId">Assigned to user ID.</param>
        /// <param name="attachments">Attachments to the Workflow Task.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDts">Date/time that the workflow task was created.</param>
        /// <param name="delayUntilDts">Date/time that the workflow task should delay until.</param>
        /// <param name="dueDts">Date/time that the workflow task is due.</param>
        /// <param name="histories">Array of history records for the task.</param>
        /// <param name="lastUpdateDts">Date/time that the workflow task was last updated.</param>
        /// <param name="merchantId">Merchant ID.</param>
        /// <param name="notes">Notes on the Workflow Task.</param>
        /// <param name="objectEmail">Object is associated with customer email.</param>
        /// <param name="objectId">Object ID.</param>
        /// <param name="objectType">Object Type.</param>
        /// <param name="objectUrl">Object URL.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="status">Status of the workflow task.</param>
        /// <param name="taskDetails">Task Details.</param>
        /// <param name="taskName">Task Name.</param>
        /// <param name="workflowTaskUuid">Workflow Task UUID.</param>
        public WorkflowTask(string assignedToGroup = default(string), int assignedToGroupId = default(int), string assignedToUser = default(string), int assignedToUserId = default(int), List<WorkflowAttachment> attachments = default(List<WorkflowAttachment>), WorkflowUser createdBy = default(WorkflowUser), string createdDts = default(string), string delayUntilDts = default(string), string dueDts = default(string), List<WorkflowTaskHistory> histories = default(List<WorkflowTaskHistory>), string lastUpdateDts = default(string), string merchantId = default(string), List<WorkflowNote> notes = default(List<WorkflowNote>), string objectEmail = default(string), string objectId = default(string), ObjectTypeEnum? objectType = default(ObjectTypeEnum?), string objectUrl = default(string), PriorityEnum? priority = default(PriorityEnum?), StatusEnum? status = default(StatusEnum?), string taskDetails = default(string), string taskName = default(string), string workflowTaskUuid = default(string))
        {
            this.AssignedToGroup = assignedToGroup;
            this.AssignedToGroupId = assignedToGroupId;
            this.AssignedToUser = assignedToUser;
            this.AssignedToUserId = assignedToUserId;
            this.Attachments = attachments;
            this.CreatedBy = createdBy;
            this.CreatedDts = createdDts;
            this.DelayUntilDts = delayUntilDts;
            this.DueDts = dueDts;
            this.Histories = histories;
            this.LastUpdateDts = lastUpdateDts;
            this.MerchantId = merchantId;
            this.Notes = notes;
            this.ObjectEmail = objectEmail;
            this.ObjectId = objectId;
            this.ObjectType = objectType;
            this.ObjectUrl = objectUrl;
            this.Priority = priority;
            this.Status = status;
            this.TaskDetails = taskDetails;
            this.TaskName = taskName;
            this.WorkflowTaskUuid = workflowTaskUuid;
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
        public int AssignedToGroupId { get; set; }

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
        public int AssignedToUserId { get; set; }

        /// <summary>
        /// Attachments to the Workflow Task
        /// </summary>
        /// <value>Attachments to the Workflow Task</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<WorkflowAttachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public WorkflowUser CreatedBy { get; set; }

        /// <summary>
        /// Date/time that the workflow task was created
        /// </summary>
        /// <value>Date/time that the workflow task was created</value>
        [DataMember(Name="created_dts", EmitDefaultValue=false)]
        public string CreatedDts { get; set; }

        /// <summary>
        /// Date/time that the workflow task should delay until
        /// </summary>
        /// <value>Date/time that the workflow task should delay until</value>
        [DataMember(Name="delay_until_dts", EmitDefaultValue=false)]
        public string DelayUntilDts { get; set; }

        /// <summary>
        /// Date/time that the workflow task is due
        /// </summary>
        /// <value>Date/time that the workflow task is due</value>
        [DataMember(Name="due_dts", EmitDefaultValue=false)]
        public string DueDts { get; set; }

        /// <summary>
        /// Array of history records for the task
        /// </summary>
        /// <value>Array of history records for the task</value>
        [DataMember(Name="histories", EmitDefaultValue=false)]
        public List<WorkflowTaskHistory> Histories { get; set; }

        /// <summary>
        /// Date/time that the workflow task was last updated
        /// </summary>
        /// <value>Date/time that the workflow task was last updated</value>
        [DataMember(Name="last_update_dts", EmitDefaultValue=false)]
        public string LastUpdateDts { get; set; }

        /// <summary>
        /// Merchant ID
        /// </summary>
        /// <value>Merchant ID</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Notes on the Workflow Task
        /// </summary>
        /// <value>Notes on the Workflow Task</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<WorkflowNote> Notes { get; set; }

        /// <summary>
        /// Object is associated with customer email
        /// </summary>
        /// <value>Object is associated with customer email</value>
        [DataMember(Name="object_email", EmitDefaultValue=false)]
        public string ObjectEmail { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        /// <value>Object ID</value>
        [DataMember(Name="object_id", EmitDefaultValue=false)]
        public string ObjectId { get; set; }


        /// <summary>
        /// Object URL
        /// </summary>
        /// <value>Object URL</value>
        [DataMember(Name="object_url", EmitDefaultValue=false)]
        public string ObjectUrl { get; set; }



        /// <summary>
        /// Task Details
        /// </summary>
        /// <value>Task Details</value>
        [DataMember(Name="task_details", EmitDefaultValue=false)]
        public string TaskDetails { get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        /// <value>Task Name</value>
        [DataMember(Name="task_name", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Workflow Task UUID
        /// </summary>
        /// <value>Workflow Task UUID</value>
        [DataMember(Name="workflow_task_uuid", EmitDefaultValue=false)]
        public string WorkflowTaskUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTask {\n");
            sb.Append("  AssignedToGroup: ").Append(AssignedToGroup).Append("\n");
            sb.Append("  AssignedToGroupId: ").Append(AssignedToGroupId).Append("\n");
            sb.Append("  AssignedToUser: ").Append(AssignedToUser).Append("\n");
            sb.Append("  AssignedToUserId: ").Append(AssignedToUserId).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDts: ").Append(CreatedDts).Append("\n");
            sb.Append("  DelayUntilDts: ").Append(DelayUntilDts).Append("\n");
            sb.Append("  DueDts: ").Append(DueDts).Append("\n");
            sb.Append("  Histories: ").Append(Histories).Append("\n");
            sb.Append("  LastUpdateDts: ").Append(LastUpdateDts).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ObjectEmail: ").Append(ObjectEmail).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskDetails: ").Append(TaskDetails).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  WorkflowTaskUuid: ").Append(WorkflowTaskUuid).Append("\n");
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
            return this.Equals(input as WorkflowTask);
        }

        /// <summary>
        /// Returns true if WorkflowTask instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowTask input)
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
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDts == input.CreatedDts ||
                    (this.CreatedDts != null &&
                    this.CreatedDts.Equals(input.CreatedDts))
                ) && 
                (
                    this.DelayUntilDts == input.DelayUntilDts ||
                    (this.DelayUntilDts != null &&
                    this.DelayUntilDts.Equals(input.DelayUntilDts))
                ) && 
                (
                    this.DueDts == input.DueDts ||
                    (this.DueDts != null &&
                    this.DueDts.Equals(input.DueDts))
                ) && 
                (
                    this.Histories == input.Histories ||
                    this.Histories != null &&
                    input.Histories != null &&
                    this.Histories.SequenceEqual(input.Histories)
                ) && 
                (
                    this.LastUpdateDts == input.LastUpdateDts ||
                    (this.LastUpdateDts != null &&
                    this.LastUpdateDts.Equals(input.LastUpdateDts))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.ObjectEmail == input.ObjectEmail ||
                    (this.ObjectEmail != null &&
                    this.ObjectEmail.Equals(input.ObjectEmail))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
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
                    this.TaskDetails == input.TaskDetails ||
                    (this.TaskDetails != null &&
                    this.TaskDetails.Equals(input.TaskDetails))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.WorkflowTaskUuid == input.WorkflowTaskUuid ||
                    (this.WorkflowTaskUuid != null &&
                    this.WorkflowTaskUuid.Equals(input.WorkflowTaskUuid))
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
                if (this.AssignedToUser != null)
                    hashCode = hashCode * 59 + this.AssignedToUser.GetHashCode();
                if (this.AssignedToUserId != null)
                    hashCode = hashCode * 59 + this.AssignedToUserId.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDts != null)
                    hashCode = hashCode * 59 + this.CreatedDts.GetHashCode();
                if (this.DelayUntilDts != null)
                    hashCode = hashCode * 59 + this.DelayUntilDts.GetHashCode();
                if (this.DueDts != null)
                    hashCode = hashCode * 59 + this.DueDts.GetHashCode();
                if (this.Histories != null)
                    hashCode = hashCode * 59 + this.Histories.GetHashCode();
                if (this.LastUpdateDts != null)
                    hashCode = hashCode * 59 + this.LastUpdateDts.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ObjectEmail != null)
                    hashCode = hashCode * 59 + this.ObjectEmail.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskDetails != null)
                    hashCode = hashCode * 59 + this.TaskDetails.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.WorkflowTaskUuid != null)
                    hashCode = hashCode * 59 + this.WorkflowTaskUuid.GetHashCode();
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
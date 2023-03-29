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
    /// Experiment
    /// </summary>
    [DataContract]
    public partial class Experiment :  IEquatable<Experiment>, IValidatableObject
    {
        /// <summary>
        /// The type of OpenAI element being experimented on
        /// </summary>
        /// <value>The type of OpenAI element being experimented on</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpenaiElementTypeEnum
        {
            
            /// <summary>
            /// Enum Headline for value: headline
            /// </summary>
            [EnumMember(Value = "headline")]
            Headline = 1,
            
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 2,
            
            /// <summary>
            /// Enum Textblock for value: textblock
            /// </summary>
            [EnumMember(Value = "textblock")]
            Textblock = 3
        }

        /// <summary>
        /// The type of OpenAI element being experimented on
        /// </summary>
        /// <value>The type of OpenAI element being experimented on</value>
        [DataMember(Name="openai_element_type", EmitDefaultValue=false)]
        public OpenaiElementTypeEnum? OpenaiElementType { get; set; }
        /// <summary>
        /// Status of the experiment
        /// </summary>
        /// <value>Status of the experiment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 1,
            
            /// <summary>
            /// Enum Ended for value: Ended
            /// </summary>
            [EnumMember(Value = "Ended")]
            Ended = 2,
            
            /// <summary>
            /// Enum Deleted for value: Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted = 3
        }

        /// <summary>
        /// Status of the experiment
        /// </summary>
        /// <value>Status of the experiment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="containerId">Contained ID where the experiment element was located.</param>
        /// <param name="durationDays">Duration in days.</param>
        /// <param name="endDts">End date/time.</param>
        /// <param name="equalWeighting">Whether or not traffic is equally weighted or shifts over time during the experiment.</param>
        /// <param name="experimentType">The type of experiment.</param>
        /// <param name="id">Experiment id.</param>
        /// <param name="name">Experiment name.</param>
        /// <param name="notes">Notes about the experiment.</param>
        /// <param name="objective">Objective that is being optimized.</param>
        /// <param name="objectiveParameter">Objective parameter (such as event name) that is being optimized.</param>
        /// <param name="openaiCurrentIteration">The current iteration of the OpenAI related experiment.</param>
        /// <param name="openaiElementType">The type of OpenAI element being experimented on.</param>
        /// <param name="openaiModel">The type of OpenAI model used.</param>
        /// <param name="openaiTotalIterations">The total number of iterations to perform on the experiment.</param>
        /// <param name="optimizationType">Type of optimization.</param>
        /// <param name="pValue">Statistics p-value for the experiment.</param>
        /// <param name="sessionCount">Total number of sessions in the experiment.</param>
        /// <param name="startDts">Start date/time.</param>
        /// <param name="status">Status of the experiment.</param>
        /// <param name="storefrontExperimentOid">Storefront Experiment Oid.</param>
        /// <param name="storefrontOid">Storefront oid.</param>
        /// <param name="uri">URI the experiment was started on.</param>
        /// <param name="variations">Variations being tested in the experiment.</param>
        public Experiment(string containerId = default(string), int? durationDays = default(int?), string endDts = default(string), bool? equalWeighting = default(bool?), string experimentType = default(string), string id = default(string), string name = default(string), string notes = default(string), string objective = default(string), string objectiveParameter = default(string), int? openaiCurrentIteration = default(int?), OpenaiElementTypeEnum? openaiElementType = default(OpenaiElementTypeEnum?), string openaiModel = default(string), int? openaiTotalIterations = default(int?), string optimizationType = default(string), decimal? pValue = default(decimal?), int? sessionCount = default(int?), string startDts = default(string), StatusEnum? status = default(StatusEnum?), int? storefrontExperimentOid = default(int?), int? storefrontOid = default(int?), string uri = default(string), List<ExperimentVariation> variations = default(List<ExperimentVariation>))
        {
            this.ContainerId = containerId;
            this.DurationDays = durationDays;
            this.EndDts = endDts;
            this.EqualWeighting = equalWeighting;
            this.ExperimentType = experimentType;
            this.Id = id;
            this.Name = name;
            this.Notes = notes;
            this.Objective = objective;
            this.ObjectiveParameter = objectiveParameter;
            this.OpenaiCurrentIteration = openaiCurrentIteration;
            this.OpenaiElementType = openaiElementType;
            this.OpenaiModel = openaiModel;
            this.OpenaiTotalIterations = openaiTotalIterations;
            this.OptimizationType = optimizationType;
            this.PValue = pValue;
            this.SessionCount = sessionCount;
            this.StartDts = startDts;
            this.Status = status;
            this.StorefrontExperimentOid = storefrontExperimentOid;
            this.StorefrontOid = storefrontOid;
            this.Uri = uri;
            this.Variations = variations;
        }
        
        /// <summary>
        /// Contained ID where the experiment element was located
        /// </summary>
        /// <value>Contained ID where the experiment element was located</value>
        [DataMember(Name="container_id", EmitDefaultValue=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Duration in days
        /// </summary>
        /// <value>Duration in days</value>
        [DataMember(Name="duration_days", EmitDefaultValue=false)]
        public int? DurationDays { get; set; }

        /// <summary>
        /// End date/time
        /// </summary>
        /// <value>End date/time</value>
        [DataMember(Name="end_dts", EmitDefaultValue=false)]
        public string EndDts { get; set; }

        /// <summary>
        /// Whether or not traffic is equally weighted or shifts over time during the experiment
        /// </summary>
        /// <value>Whether or not traffic is equally weighted or shifts over time during the experiment</value>
        [DataMember(Name="equal_weighting", EmitDefaultValue=false)]
        public bool? EqualWeighting { get; set; }

        /// <summary>
        /// The type of experiment
        /// </summary>
        /// <value>The type of experiment</value>
        [DataMember(Name="experiment_type", EmitDefaultValue=false)]
        public string ExperimentType { get; set; }

        /// <summary>
        /// Experiment id
        /// </summary>
        /// <value>Experiment id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Experiment name
        /// </summary>
        /// <value>Experiment name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Notes about the experiment
        /// </summary>
        /// <value>Notes about the experiment</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Objective that is being optimized
        /// </summary>
        /// <value>Objective that is being optimized</value>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public string Objective { get; set; }

        /// <summary>
        /// Objective parameter (such as event name) that is being optimized
        /// </summary>
        /// <value>Objective parameter (such as event name) that is being optimized</value>
        [DataMember(Name="objective_parameter", EmitDefaultValue=false)]
        public string ObjectiveParameter { get; set; }

        /// <summary>
        /// The current iteration of the OpenAI related experiment
        /// </summary>
        /// <value>The current iteration of the OpenAI related experiment</value>
        [DataMember(Name="openai_current_iteration", EmitDefaultValue=false)]
        public int? OpenaiCurrentIteration { get; set; }


        /// <summary>
        /// The type of OpenAI model used
        /// </summary>
        /// <value>The type of OpenAI model used</value>
        [DataMember(Name="openai_model", EmitDefaultValue=false)]
        public string OpenaiModel { get; set; }

        /// <summary>
        /// The total number of iterations to perform on the experiment
        /// </summary>
        /// <value>The total number of iterations to perform on the experiment</value>
        [DataMember(Name="openai_total_iterations", EmitDefaultValue=false)]
        public int? OpenaiTotalIterations { get; set; }

        /// <summary>
        /// Type of optimization
        /// </summary>
        /// <value>Type of optimization</value>
        [DataMember(Name="optimization_type", EmitDefaultValue=false)]
        public string OptimizationType { get; set; }

        /// <summary>
        /// Statistics p-value for the experiment
        /// </summary>
        /// <value>Statistics p-value for the experiment</value>
        [DataMember(Name="p_value", EmitDefaultValue=false)]
        public decimal? PValue { get; set; }

        /// <summary>
        /// Total number of sessions in the experiment
        /// </summary>
        /// <value>Total number of sessions in the experiment</value>
        [DataMember(Name="session_count", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }

        /// <summary>
        /// Start date/time
        /// </summary>
        /// <value>Start date/time</value>
        [DataMember(Name="start_dts", EmitDefaultValue=false)]
        public string StartDts { get; set; }


        /// <summary>
        /// Storefront Experiment Oid
        /// </summary>
        /// <value>Storefront Experiment Oid</value>
        [DataMember(Name="storefront_experiment_oid", EmitDefaultValue=false)]
        public int? StorefrontExperimentOid { get; set; }

        /// <summary>
        /// Storefront oid
        /// </summary>
        /// <value>Storefront oid</value>
        [DataMember(Name="storefront_oid", EmitDefaultValue=false)]
        public int? StorefrontOid { get; set; }

        /// <summary>
        /// URI the experiment was started on
        /// </summary>
        /// <value>URI the experiment was started on</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Variations being tested in the experiment
        /// </summary>
        /// <value>Variations being tested in the experiment</value>
        [DataMember(Name="variations", EmitDefaultValue=false)]
        public List<ExperimentVariation> Variations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Experiment {\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  DurationDays: ").Append(DurationDays).Append("\n");
            sb.Append("  EndDts: ").Append(EndDts).Append("\n");
            sb.Append("  EqualWeighting: ").Append(EqualWeighting).Append("\n");
            sb.Append("  ExperimentType: ").Append(ExperimentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  ObjectiveParameter: ").Append(ObjectiveParameter).Append("\n");
            sb.Append("  OpenaiCurrentIteration: ").Append(OpenaiCurrentIteration).Append("\n");
            sb.Append("  OpenaiElementType: ").Append(OpenaiElementType).Append("\n");
            sb.Append("  OpenaiModel: ").Append(OpenaiModel).Append("\n");
            sb.Append("  OpenaiTotalIterations: ").Append(OpenaiTotalIterations).Append("\n");
            sb.Append("  OptimizationType: ").Append(OptimizationType).Append("\n");
            sb.Append("  PValue: ").Append(PValue).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  StartDts: ").Append(StartDts).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StorefrontExperimentOid: ").Append(StorefrontExperimentOid).Append("\n");
            sb.Append("  StorefrontOid: ").Append(StorefrontOid).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Variations: ").Append(Variations).Append("\n");
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
            return this.Equals(input as Experiment);
        }

        /// <summary>
        /// Returns true if Experiment instances are equal
        /// </summary>
        /// <param name="input">Instance of Experiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Experiment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
                ) && 
                (
                    this.DurationDays == input.DurationDays ||
                    (this.DurationDays != null &&
                    this.DurationDays.Equals(input.DurationDays))
                ) && 
                (
                    this.EndDts == input.EndDts ||
                    (this.EndDts != null &&
                    this.EndDts.Equals(input.EndDts))
                ) && 
                (
                    this.EqualWeighting == input.EqualWeighting ||
                    (this.EqualWeighting != null &&
                    this.EqualWeighting.Equals(input.EqualWeighting))
                ) && 
                (
                    this.ExperimentType == input.ExperimentType ||
                    (this.ExperimentType != null &&
                    this.ExperimentType.Equals(input.ExperimentType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Objective == input.Objective ||
                    (this.Objective != null &&
                    this.Objective.Equals(input.Objective))
                ) && 
                (
                    this.ObjectiveParameter == input.ObjectiveParameter ||
                    (this.ObjectiveParameter != null &&
                    this.ObjectiveParameter.Equals(input.ObjectiveParameter))
                ) && 
                (
                    this.OpenaiCurrentIteration == input.OpenaiCurrentIteration ||
                    (this.OpenaiCurrentIteration != null &&
                    this.OpenaiCurrentIteration.Equals(input.OpenaiCurrentIteration))
                ) && 
                (
                    this.OpenaiElementType == input.OpenaiElementType ||
                    (this.OpenaiElementType != null &&
                    this.OpenaiElementType.Equals(input.OpenaiElementType))
                ) && 
                (
                    this.OpenaiModel == input.OpenaiModel ||
                    (this.OpenaiModel != null &&
                    this.OpenaiModel.Equals(input.OpenaiModel))
                ) && 
                (
                    this.OpenaiTotalIterations == input.OpenaiTotalIterations ||
                    (this.OpenaiTotalIterations != null &&
                    this.OpenaiTotalIterations.Equals(input.OpenaiTotalIterations))
                ) && 
                (
                    this.OptimizationType == input.OptimizationType ||
                    (this.OptimizationType != null &&
                    this.OptimizationType.Equals(input.OptimizationType))
                ) && 
                (
                    this.PValue == input.PValue ||
                    (this.PValue != null &&
                    this.PValue.Equals(input.PValue))
                ) && 
                (
                    this.SessionCount == input.SessionCount ||
                    (this.SessionCount != null &&
                    this.SessionCount.Equals(input.SessionCount))
                ) && 
                (
                    this.StartDts == input.StartDts ||
                    (this.StartDts != null &&
                    this.StartDts.Equals(input.StartDts))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StorefrontExperimentOid == input.StorefrontExperimentOid ||
                    (this.StorefrontExperimentOid != null &&
                    this.StorefrontExperimentOid.Equals(input.StorefrontExperimentOid))
                ) && 
                (
                    this.StorefrontOid == input.StorefrontOid ||
                    (this.StorefrontOid != null &&
                    this.StorefrontOid.Equals(input.StorefrontOid))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Variations == input.Variations ||
                    this.Variations != null &&
                    this.Variations.SequenceEqual(input.Variations)
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
                if (this.ContainerId != null)
                    hashCode = hashCode * 59 + this.ContainerId.GetHashCode();
                if (this.DurationDays != null)
                    hashCode = hashCode * 59 + this.DurationDays.GetHashCode();
                if (this.EndDts != null)
                    hashCode = hashCode * 59 + this.EndDts.GetHashCode();
                if (this.EqualWeighting != null)
                    hashCode = hashCode * 59 + this.EqualWeighting.GetHashCode();
                if (this.ExperimentType != null)
                    hashCode = hashCode * 59 + this.ExperimentType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Objective != null)
                    hashCode = hashCode * 59 + this.Objective.GetHashCode();
                if (this.ObjectiveParameter != null)
                    hashCode = hashCode * 59 + this.ObjectiveParameter.GetHashCode();
                if (this.OpenaiCurrentIteration != null)
                    hashCode = hashCode * 59 + this.OpenaiCurrentIteration.GetHashCode();
                if (this.OpenaiElementType != null)
                    hashCode = hashCode * 59 + this.OpenaiElementType.GetHashCode();
                if (this.OpenaiModel != null)
                    hashCode = hashCode * 59 + this.OpenaiModel.GetHashCode();
                if (this.OpenaiTotalIterations != null)
                    hashCode = hashCode * 59 + this.OpenaiTotalIterations.GetHashCode();
                if (this.OptimizationType != null)
                    hashCode = hashCode * 59 + this.OptimizationType.GetHashCode();
                if (this.PValue != null)
                    hashCode = hashCode * 59 + this.PValue.GetHashCode();
                if (this.SessionCount != null)
                    hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                if (this.StartDts != null)
                    hashCode = hashCode * 59 + this.StartDts.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StorefrontExperimentOid != null)
                    hashCode = hashCode * 59 + this.StorefrontExperimentOid.GetHashCode();
                if (this.StorefrontOid != null)
                    hashCode = hashCode * 59 + this.StorefrontOid.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Variations != null)
                    hashCode = hashCode * 59 + this.Variations.GetHashCode();
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

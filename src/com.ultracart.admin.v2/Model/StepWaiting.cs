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
    /// StepWaiting
    /// </summary>
    [DataContract]
    public partial class StepWaiting :  IEquatable<StepWaiting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepWaiting" /> class.
        /// </summary>
        /// <param name="CommseqStepUuid">CommseqStepUuid.</param>
        /// <param name="NumberWaiting">NumberWaiting.</param>
        public StepWaiting(string CommseqStepUuid = default(string), int? NumberWaiting = default(int?))
        {
            this.CommseqStepUuid = CommseqStepUuid;
            this.NumberWaiting = NumberWaiting;
        }
        
        /// <summary>
        /// Gets or Sets CommseqStepUuid
        /// </summary>
        [DataMember(Name="commseq_step_uuid", EmitDefaultValue=false)]
        public string CommseqStepUuid { get; set; }

        /// <summary>
        /// Gets or Sets NumberWaiting
        /// </summary>
        [DataMember(Name="number_waiting", EmitDefaultValue=false)]
        public int? NumberWaiting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepWaiting {\n");
            sb.Append("  CommseqStepUuid: ").Append(CommseqStepUuid).Append("\n");
            sb.Append("  NumberWaiting: ").Append(NumberWaiting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as StepWaiting);
        }

        /// <summary>
        /// Returns true if StepWaiting instances are equal
        /// </summary>
        /// <param name="input">Instance of StepWaiting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepWaiting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CommseqStepUuid == input.CommseqStepUuid ||
                    (this.CommseqStepUuid != null &&
                    this.CommseqStepUuid.Equals(input.CommseqStepUuid))
                ) && 
                (
                    this.NumberWaiting == input.NumberWaiting ||
                    (this.NumberWaiting != null &&
                    this.NumberWaiting.Equals(input.NumberWaiting))
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
                if (this.CommseqStepUuid != null)
                    hashCode = hashCode * 59 + this.CommseqStepUuid.GetHashCode();
                if (this.NumberWaiting != null)
                    hashCode = hashCode * 59 + this.NumberWaiting.GetHashCode();
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

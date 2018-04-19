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
    /// ResponseMetadata
    /// </summary>
    [DataContract]
    public partial class ResponseMetadata :  IEquatable<ResponseMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetadata" /> class.
        /// </summary>
        /// <param name="PayloadName">Payload name.</param>
        /// <param name="ResultSet">ResultSet.</param>
        public ResponseMetadata(string PayloadName = default(string), ResultSet ResultSet = default(ResultSet))
        {
            this.PayloadName = PayloadName;
            this.ResultSet = ResultSet;
        }
        
        /// <summary>
        /// Payload name
        /// </summary>
        /// <value>Payload name</value>
        [DataMember(Name="payload_name", EmitDefaultValue=false)]
        public string PayloadName { get; set; }

        /// <summary>
        /// Gets or Sets ResultSet
        /// </summary>
        [DataMember(Name="result_set", EmitDefaultValue=false)]
        public ResultSet ResultSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseMetadata {\n");
            sb.Append("  PayloadName: ").Append(PayloadName).Append("\n");
            sb.Append("  ResultSet: ").Append(ResultSet).Append("\n");
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
            return this.Equals(input as ResponseMetadata);
        }

        /// <summary>
        /// Returns true if ResponseMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayloadName == input.PayloadName ||
                    (this.PayloadName != null &&
                    this.PayloadName.Equals(input.PayloadName))
                ) && 
                (
                    this.ResultSet == input.ResultSet ||
                    (this.ResultSet != null &&
                    this.ResultSet.Equals(input.ResultSet))
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
                if (this.PayloadName != null)
                    hashCode = hashCode * 59 + this.PayloadName.GetHashCode();
                if (this.ResultSet != null)
                    hashCode = hashCode * 59 + this.ResultSet.GetHashCode();
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

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
    /// RtgSummaryResponse
    /// </summary>
    [DataContract]
    public partial class RtgSummaryResponse :  IEquatable<RtgSummaryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RtgSummaryResponse" /> class.
        /// </summary>
        /// <param name="gateways">gateways.</param>
        /// <param name="infoMessage">infoMessage.</param>
        /// <param name="migrationRtgCode">migrationRtgCode.</param>
        /// <param name="migrationSingleGatewayName">migrationSingleGatewayName.</param>
        /// <param name="showDelayAutoOrders">showDelayAutoOrders.</param>
        /// <param name="showMigration">showMigration.</param>
        /// <param name="warning">warning.</param>
        public RtgSummaryResponse(List<RtgSummaryGateway> gateways = default(List<RtgSummaryGateway>), string infoMessage = default(string), string migrationRtgCode = default(string), string migrationSingleGatewayName = default(string), bool? showDelayAutoOrders = default(bool?), bool? showMigration = default(bool?), string warning = default(string))
        {
            this.Gateways = gateways;
            this.InfoMessage = infoMessage;
            this.MigrationRtgCode = migrationRtgCode;
            this.MigrationSingleGatewayName = migrationSingleGatewayName;
            this.ShowDelayAutoOrders = showDelayAutoOrders;
            this.ShowMigration = showMigration;
            this.Warning = warning;
        }
        
        /// <summary>
        /// Gets or Sets Gateways
        /// </summary>
        [DataMember(Name="gateways", EmitDefaultValue=false)]
        public List<RtgSummaryGateway> Gateways { get; set; }

        /// <summary>
        /// Gets or Sets InfoMessage
        /// </summary>
        [DataMember(Name="info_message", EmitDefaultValue=false)]
        public string InfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets MigrationRtgCode
        /// </summary>
        [DataMember(Name="migration_rtg_code", EmitDefaultValue=false)]
        public string MigrationRtgCode { get; set; }

        /// <summary>
        /// Gets or Sets MigrationSingleGatewayName
        /// </summary>
        [DataMember(Name="migration_single_gateway_name", EmitDefaultValue=false)]
        public string MigrationSingleGatewayName { get; set; }

        /// <summary>
        /// Gets or Sets ShowDelayAutoOrders
        /// </summary>
        [DataMember(Name="show_delay_auto_orders", EmitDefaultValue=false)]
        public bool? ShowDelayAutoOrders { get; set; }

        /// <summary>
        /// Gets or Sets ShowMigration
        /// </summary>
        [DataMember(Name="show_migration", EmitDefaultValue=false)]
        public bool? ShowMigration { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public string Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtgSummaryResponse {\n");
            sb.Append("  Gateways: ").Append(Gateways).Append("\n");
            sb.Append("  InfoMessage: ").Append(InfoMessage).Append("\n");
            sb.Append("  MigrationRtgCode: ").Append(MigrationRtgCode).Append("\n");
            sb.Append("  MigrationSingleGatewayName: ").Append(MigrationSingleGatewayName).Append("\n");
            sb.Append("  ShowDelayAutoOrders: ").Append(ShowDelayAutoOrders).Append("\n");
            sb.Append("  ShowMigration: ").Append(ShowMigration).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as RtgSummaryResponse);
        }

        /// <summary>
        /// Returns true if RtgSummaryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RtgSummaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RtgSummaryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gateways == input.Gateways ||
                    this.Gateways != null &&
                    this.Gateways.SequenceEqual(input.Gateways)
                ) && 
                (
                    this.InfoMessage == input.InfoMessage ||
                    (this.InfoMessage != null &&
                    this.InfoMessage.Equals(input.InfoMessage))
                ) && 
                (
                    this.MigrationRtgCode == input.MigrationRtgCode ||
                    (this.MigrationRtgCode != null &&
                    this.MigrationRtgCode.Equals(input.MigrationRtgCode))
                ) && 
                (
                    this.MigrationSingleGatewayName == input.MigrationSingleGatewayName ||
                    (this.MigrationSingleGatewayName != null &&
                    this.MigrationSingleGatewayName.Equals(input.MigrationSingleGatewayName))
                ) && 
                (
                    this.ShowDelayAutoOrders == input.ShowDelayAutoOrders ||
                    (this.ShowDelayAutoOrders != null &&
                    this.ShowDelayAutoOrders.Equals(input.ShowDelayAutoOrders))
                ) && 
                (
                    this.ShowMigration == input.ShowMigration ||
                    (this.ShowMigration != null &&
                    this.ShowMigration.Equals(input.ShowMigration))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.Gateways != null)
                    hashCode = hashCode * 59 + this.Gateways.GetHashCode();
                if (this.InfoMessage != null)
                    hashCode = hashCode * 59 + this.InfoMessage.GetHashCode();
                if (this.MigrationRtgCode != null)
                    hashCode = hashCode * 59 + this.MigrationRtgCode.GetHashCode();
                if (this.MigrationSingleGatewayName != null)
                    hashCode = hashCode * 59 + this.MigrationSingleGatewayName.GetHashCode();
                if (this.ShowDelayAutoOrders != null)
                    hashCode = hashCode * 59 + this.ShowDelayAutoOrders.GetHashCode();
                if (this.ShowMigration != null)
                    hashCode = hashCode * 59 + this.ShowMigration.GetHashCode();
                if (this.Warning != null)
                    hashCode = hashCode * 59 + this.Warning.GetHashCode();
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
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
    /// TaxJarConfig
    /// </summary>
    [DataContract]
    public partial class TaxJarConfig :  IEquatable<TaxJarConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxJarConfig" /> class.
        /// </summary>
        /// <param name="active">True if TaxJar is active for this merchant.</param>
        /// <param name="apiKey">TaxJar API key.</param>
        /// <param name="estimateOnly">True if this TaxJar configuration is to estimate taxes only and not report placed orders to TaxJar.</param>
        /// <param name="sendOutsideNexus">Send orders outside your nexus TaxJar.  The default is to not transmit outside orders to TaxJar to reduce API calls.  However, this will prevent TaxJar from dynamically creating new Nexus when thresholds are exceeded for a state..</param>
        /// <param name="sendTestOrders">Send test orders through to TaxJar.  The default is to not transmit test orders to TaxJar..</param>
        /// <param name="skipChannelOrders">Do not send channel partner orders to TaxJar.  Set this to true if your channel partner reports tax on their own..</param>
        /// <param name="useDistributionCenterFrom">Use distribution center from address.</param>
        public TaxJarConfig(bool active = default(bool), string apiKey = default(string), bool estimateOnly = default(bool), bool sendOutsideNexus = default(bool), bool sendTestOrders = default(bool), bool skipChannelOrders = default(bool), bool useDistributionCenterFrom = default(bool))
        {
            this.Active = active;
            this.ApiKey = apiKey;
            this.EstimateOnly = estimateOnly;
            this.SendOutsideNexus = sendOutsideNexus;
            this.SendTestOrders = sendTestOrders;
            this.SkipChannelOrders = skipChannelOrders;
            this.UseDistributionCenterFrom = useDistributionCenterFrom;
        }

        /// <summary>
        /// True if TaxJar is active for this merchant
        /// </summary>
        /// <value>True if TaxJar is active for this merchant</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// TaxJar API key
        /// </summary>
        /// <value>TaxJar API key</value>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// True if this TaxJar configuration is to estimate taxes only and not report placed orders to TaxJar
        /// </summary>
        /// <value>True if this TaxJar configuration is to estimate taxes only and not report placed orders to TaxJar</value>
        [DataMember(Name="estimate_only", EmitDefaultValue=false)]
        public bool EstimateOnly { get; set; }

        /// <summary>
        /// Send orders outside your nexus TaxJar.  The default is to not transmit outside orders to TaxJar to reduce API calls.  However, this will prevent TaxJar from dynamically creating new Nexus when thresholds are exceeded for a state.
        /// </summary>
        /// <value>Send orders outside your nexus TaxJar.  The default is to not transmit outside orders to TaxJar to reduce API calls.  However, this will prevent TaxJar from dynamically creating new Nexus when thresholds are exceeded for a state.</value>
        [DataMember(Name="send_outside_nexus", EmitDefaultValue=false)]
        public bool SendOutsideNexus { get; set; }

        /// <summary>
        /// Send test orders through to TaxJar.  The default is to not transmit test orders to TaxJar.
        /// </summary>
        /// <value>Send test orders through to TaxJar.  The default is to not transmit test orders to TaxJar.</value>
        [DataMember(Name="send_test_orders", EmitDefaultValue=false)]
        public bool SendTestOrders { get; set; }

        /// <summary>
        /// Do not send channel partner orders to TaxJar.  Set this to true if your channel partner reports tax on their own.
        /// </summary>
        /// <value>Do not send channel partner orders to TaxJar.  Set this to true if your channel partner reports tax on their own.</value>
        [DataMember(Name="skip_channel_orders", EmitDefaultValue=false)]
        public bool SkipChannelOrders { get; set; }

        /// <summary>
        /// Use distribution center from address
        /// </summary>
        /// <value>Use distribution center from address</value>
        [DataMember(Name="use_distribution_center_from", EmitDefaultValue=false)]
        public bool UseDistributionCenterFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxJarConfig {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  EstimateOnly: ").Append(EstimateOnly).Append("\n");
            sb.Append("  SendOutsideNexus: ").Append(SendOutsideNexus).Append("\n");
            sb.Append("  SendTestOrders: ").Append(SendTestOrders).Append("\n");
            sb.Append("  SkipChannelOrders: ").Append(SkipChannelOrders).Append("\n");
            sb.Append("  UseDistributionCenterFrom: ").Append(UseDistributionCenterFrom).Append("\n");
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
            return this.Equals(input as TaxJarConfig);
        }

        /// <summary>
        /// Returns true if TaxJarConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxJarConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxJarConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.EstimateOnly == input.EstimateOnly ||
                    (this.EstimateOnly != null &&
                    this.EstimateOnly.Equals(input.EstimateOnly))
                ) && 
                (
                    this.SendOutsideNexus == input.SendOutsideNexus ||
                    (this.SendOutsideNexus != null &&
                    this.SendOutsideNexus.Equals(input.SendOutsideNexus))
                ) && 
                (
                    this.SendTestOrders == input.SendTestOrders ||
                    (this.SendTestOrders != null &&
                    this.SendTestOrders.Equals(input.SendTestOrders))
                ) && 
                (
                    this.SkipChannelOrders == input.SkipChannelOrders ||
                    (this.SkipChannelOrders != null &&
                    this.SkipChannelOrders.Equals(input.SkipChannelOrders))
                ) && 
                (
                    this.UseDistributionCenterFrom == input.UseDistributionCenterFrom ||
                    (this.UseDistributionCenterFrom != null &&
                    this.UseDistributionCenterFrom.Equals(input.UseDistributionCenterFrom))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.EstimateOnly != null)
                    hashCode = hashCode * 59 + this.EstimateOnly.GetHashCode();
                if (this.SendOutsideNexus != null)
                    hashCode = hashCode * 59 + this.SendOutsideNexus.GetHashCode();
                if (this.SendTestOrders != null)
                    hashCode = hashCode * 59 + this.SendTestOrders.GetHashCode();
                if (this.SkipChannelOrders != null)
                    hashCode = hashCode * 59 + this.SkipChannelOrders.GetHashCode();
                if (this.UseDistributionCenterFrom != null)
                    hashCode = hashCode * 59 + this.UseDistributionCenterFrom.GetHashCode();
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

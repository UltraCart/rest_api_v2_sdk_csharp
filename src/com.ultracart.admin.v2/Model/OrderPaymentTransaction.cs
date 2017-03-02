/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.ultracart.admin.v2.Model
{
    /// <summary>
    /// OrderPaymentTransaction
    /// </summary>
    [DataContract]
    public partial class OrderPaymentTransaction :  IEquatable<OrderPaymentTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPaymentTransaction" /> class.
        /// </summary>
        /// <param name="Details">Details.</param>
        /// <param name="Successful">True if the transaction was successful.</param>
        /// <param name="TransactionGateway">Transaction gateway.</param>
        /// <param name="TransactionTimestamp">Transaction date/time.</param>
        public OrderPaymentTransaction(List<OrderPaymentTransactionDetail> Details = null, bool? Successful = null, string TransactionGateway = null, string TransactionTimestamp = null)
        {
            this.Details = Details;
            this.Successful = Successful;
            this.TransactionGateway = TransactionGateway;
            this.TransactionTimestamp = TransactionTimestamp;
        }
        
        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<OrderPaymentTransactionDetail> Details { get; set; }
        /// <summary>
        /// True if the transaction was successful
        /// </summary>
        /// <value>True if the transaction was successful</value>
        [DataMember(Name="successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }
        /// <summary>
        /// Transaction gateway
        /// </summary>
        /// <value>Transaction gateway</value>
        [DataMember(Name="transaction_gateway", EmitDefaultValue=false)]
        public string TransactionGateway { get; set; }
        /// <summary>
        /// Transaction date/time
        /// </summary>
        /// <value>Transaction date/time</value>
        [DataMember(Name="transaction_timestamp", EmitDefaultValue=false)]
        public string TransactionTimestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPaymentTransaction {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TransactionGateway: ").Append(TransactionGateway).Append("\n");
            sb.Append("  TransactionTimestamp: ").Append(TransactionTimestamp).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderPaymentTransaction);
        }

        /// <summary>
        /// Returns true if OrderPaymentTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderPaymentTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPaymentTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) && 
                (
                    this.Successful == other.Successful ||
                    this.Successful != null &&
                    this.Successful.Equals(other.Successful)
                ) && 
                (
                    this.TransactionGateway == other.TransactionGateway ||
                    this.TransactionGateway != null &&
                    this.TransactionGateway.Equals(other.TransactionGateway)
                ) && 
                (
                    this.TransactionTimestamp == other.TransactionTimestamp ||
                    this.TransactionTimestamp != null &&
                    this.TransactionTimestamp.Equals(other.TransactionTimestamp)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Successful != null)
                    hash = hash * 59 + this.Successful.GetHashCode();
                if (this.TransactionGateway != null)
                    hash = hash * 59 + this.TransactionGateway.GetHashCode();
                if (this.TransactionTimestamp != null)
                    hash = hash * 59 + this.TransactionTimestamp.GetHashCode();
                return hash;
            }
        }
    }

}

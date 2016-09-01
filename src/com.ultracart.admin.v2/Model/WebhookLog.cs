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
    /// WebhookLog
    /// </summary>
    [DataContract]
    public partial class WebhookLog :  IEquatable<WebhookLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLog" /> class.
        /// </summary>
        /// <param name="DeliveryDts">DeliveryDts.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Request">Request.</param>
        /// <param name="RequestHeaders">RequestHeaders.</param>
        /// <param name="RequestId">RequestId.</param>
        /// <param name="Response">Response.</param>
        /// <param name="ResponseHeaders">ResponseHeaders.</param>
        /// <param name="StatusCode">StatusCode.</param>
        /// <param name="Success">Success.</param>
        /// <param name="Uri">Uri.</param>
        public WebhookLog(string DeliveryDts = null, int? Duration = null, string Request = null, List<HTTPHeader> RequestHeaders = null, string RequestId = null, string Response = null, List<HTTPHeader> ResponseHeaders = null, int? StatusCode = null, bool? Success = null, string Uri = null)
        {
            this.DeliveryDts = DeliveryDts;
            this.Duration = Duration;
            this.Request = Request;
            this.RequestHeaders = RequestHeaders;
            this.RequestId = RequestId;
            this.Response = Response;
            this.ResponseHeaders = ResponseHeaders;
            this.StatusCode = StatusCode;
            this.Success = Success;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// Gets or Sets DeliveryDts
        /// </summary>
        [DataMember(Name="delivery_dts", EmitDefaultValue=false)]
        public string DeliveryDts { get; set; }
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }
        /// <summary>
        /// Gets or Sets RequestHeaders
        /// </summary>
        [DataMember(Name="request_headers", EmitDefaultValue=false)]
        public List<HTTPHeader> RequestHeaders { get; set; }
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }
        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }
        /// <summary>
        /// Gets or Sets ResponseHeaders
        /// </summary>
        [DataMember(Name="response_headers", EmitDefaultValue=false)]
        public List<HTTPHeader> ResponseHeaders { get; set; }
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLog {\n");
            sb.Append("  DeliveryDts: ").Append(DeliveryDts).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as WebhookLog);
        }

        /// <summary>
        /// Returns true if WebhookLog instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryDts == other.DeliveryDts ||
                    this.DeliveryDts != null &&
                    this.DeliveryDts.Equals(other.DeliveryDts)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Request == other.Request ||
                    this.Request != null &&
                    this.Request.Equals(other.Request)
                ) && 
                (
                    this.RequestHeaders == other.RequestHeaders ||
                    this.RequestHeaders != null &&
                    this.RequestHeaders.SequenceEqual(other.RequestHeaders)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.Response == other.Response ||
                    this.Response != null &&
                    this.Response.Equals(other.Response)
                ) && 
                (
                    this.ResponseHeaders == other.ResponseHeaders ||
                    this.ResponseHeaders != null &&
                    this.ResponseHeaders.SequenceEqual(other.ResponseHeaders)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.DeliveryDts != null)
                    hash = hash * 59 + this.DeliveryDts.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.Request != null)
                    hash = hash * 59 + this.Request.GetHashCode();
                if (this.RequestHeaders != null)
                    hash = hash * 59 + this.RequestHeaders.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.ResponseHeaders != null)
                    hash = hash * 59 + this.ResponseHeaders.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }
    }

}

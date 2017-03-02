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
    /// WebhookEventSubscription
    /// </summary>
    [DataContract]
    public partial class WebhookEventSubscription :  IEquatable<WebhookEventSubscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventSubscription" /> class.
        /// </summary>
        /// <param name="Comments">Comment about the event to provide further clarification to the end user.</param>
        /// <param name="DeprecatedFlag">True if the event is deprecated.  See the API change log for details on when it will be discontinued..</param>
        /// <param name="DiscontinuedFlag">True if the event is discontinued.  See the API change log for details on migration details..</param>
        /// <param name="EventDescription">Description of the event.</param>
        /// <param name="EventName">Event name.</param>
        /// <param name="Expansion">The expand string for the notification object.  See the individual resource _expand documentation for valid values..</param>
        /// <param name="Subscribed">True if this is event is subscribed to.</param>
        /// <param name="WebhookEventOid">The webhook event object identifier.</param>
        public WebhookEventSubscription(string Comments = null, bool? DeprecatedFlag = null, bool? DiscontinuedFlag = null, string EventDescription = null, string EventName = null, string Expansion = null, bool? Subscribed = null, int? WebhookEventOid = null)
        {
            this.Comments = Comments;
            this.DeprecatedFlag = DeprecatedFlag;
            this.DiscontinuedFlag = DiscontinuedFlag;
            this.EventDescription = EventDescription;
            this.EventName = EventName;
            this.Expansion = Expansion;
            this.Subscribed = Subscribed;
            this.WebhookEventOid = WebhookEventOid;
        }
        
        /// <summary>
        /// Comment about the event to provide further clarification to the end user
        /// </summary>
        /// <value>Comment about the event to provide further clarification to the end user</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
        /// <summary>
        /// True if the event is deprecated.  See the API change log for details on when it will be discontinued.
        /// </summary>
        /// <value>True if the event is deprecated.  See the API change log for details on when it will be discontinued.</value>
        [DataMember(Name="deprecated_flag", EmitDefaultValue=false)]
        public bool? DeprecatedFlag { get; set; }
        /// <summary>
        /// True if the event is discontinued.  See the API change log for details on migration details.
        /// </summary>
        /// <value>True if the event is discontinued.  See the API change log for details on migration details.</value>
        [DataMember(Name="discontinued_flag", EmitDefaultValue=false)]
        public bool? DiscontinuedFlag { get; set; }
        /// <summary>
        /// Description of the event
        /// </summary>
        /// <value>Description of the event</value>
        [DataMember(Name="event_description", EmitDefaultValue=false)]
        public string EventDescription { get; set; }
        /// <summary>
        /// Event name
        /// </summary>
        /// <value>Event name</value>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }
        /// <summary>
        /// The expand string for the notification object.  See the individual resource _expand documentation for valid values.
        /// </summary>
        /// <value>The expand string for the notification object.  See the individual resource _expand documentation for valid values.</value>
        [DataMember(Name="expansion", EmitDefaultValue=false)]
        public string Expansion { get; set; }
        /// <summary>
        /// True if this is event is subscribed to
        /// </summary>
        /// <value>True if this is event is subscribed to</value>
        [DataMember(Name="subscribed", EmitDefaultValue=false)]
        public bool? Subscribed { get; set; }
        /// <summary>
        /// The webhook event object identifier
        /// </summary>
        /// <value>The webhook event object identifier</value>
        [DataMember(Name="webhook_event_oid", EmitDefaultValue=false)]
        public int? WebhookEventOid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventSubscription {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  DeprecatedFlag: ").Append(DeprecatedFlag).Append("\n");
            sb.Append("  DiscontinuedFlag: ").Append(DiscontinuedFlag).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Expansion: ").Append(Expansion).Append("\n");
            sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
            sb.Append("  WebhookEventOid: ").Append(WebhookEventOid).Append("\n");
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
            return this.Equals(obj as WebhookEventSubscription);
        }

        /// <summary>
        /// Returns true if WebhookEventSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookEventSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.DeprecatedFlag == other.DeprecatedFlag ||
                    this.DeprecatedFlag != null &&
                    this.DeprecatedFlag.Equals(other.DeprecatedFlag)
                ) && 
                (
                    this.DiscontinuedFlag == other.DiscontinuedFlag ||
                    this.DiscontinuedFlag != null &&
                    this.DiscontinuedFlag.Equals(other.DiscontinuedFlag)
                ) && 
                (
                    this.EventDescription == other.EventDescription ||
                    this.EventDescription != null &&
                    this.EventDescription.Equals(other.EventDescription)
                ) && 
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) && 
                (
                    this.Expansion == other.Expansion ||
                    this.Expansion != null &&
                    this.Expansion.Equals(other.Expansion)
                ) && 
                (
                    this.Subscribed == other.Subscribed ||
                    this.Subscribed != null &&
                    this.Subscribed.Equals(other.Subscribed)
                ) && 
                (
                    this.WebhookEventOid == other.WebhookEventOid ||
                    this.WebhookEventOid != null &&
                    this.WebhookEventOid.Equals(other.WebhookEventOid)
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
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.DeprecatedFlag != null)
                    hash = hash * 59 + this.DeprecatedFlag.GetHashCode();
                if (this.DiscontinuedFlag != null)
                    hash = hash * 59 + this.DiscontinuedFlag.GetHashCode();
                if (this.EventDescription != null)
                    hash = hash * 59 + this.EventDescription.GetHashCode();
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                if (this.Expansion != null)
                    hash = hash * 59 + this.Expansion.GetHashCode();
                if (this.Subscribed != null)
                    hash = hash * 59 + this.Subscribed.GetHashCode();
                if (this.WebhookEventOid != null)
                    hash = hash * 59 + this.WebhookEventOid.GetHashCode();
                return hash;
            }
        }
    }

}

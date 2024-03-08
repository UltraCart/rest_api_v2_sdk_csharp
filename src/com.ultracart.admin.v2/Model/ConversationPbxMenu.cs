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
    /// ConversationPbxMenu
    /// </summary>
    [DataContract]
    public partial class ConversationPbxMenu :  IEquatable<ConversationPbxMenu>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPbxMenu" /> class.
        /// </summary>
        /// <param name="allowDirectExtensions">If true, the customer is allowed to input direct extensions within this menu.</param>
        /// <param name="conversationPbxMenuUuid">Conversation Pbx Menu UUID.</param>
        /// <param name="defaultAction">The default action for this menu.</param>
        /// <param name="defaultActionTarget">The default action target for this menu.</param>
        /// <param name="mappings">Action mappings for this menu.</param>
        /// <param name="merchantId">Merchant Id.</param>
        /// <param name="name">Menu name.</param>
        /// <param name="playAudioUuid">An optional audio clip that plays when a customer enters this menu.</param>
        /// <param name="say">An optional saying that plays when a customer enters this menu.</param>
        /// <param name="timeout">The idle seconds before this menu times out.</param>
        public ConversationPbxMenu(bool? allowDirectExtensions = default(bool?), string conversationPbxMenuUuid = default(string), string defaultAction = default(string), string defaultActionTarget = default(string), List<ConversationPbxMenuMapping> mappings = default(List<ConversationPbxMenuMapping>), string merchantId = default(string), string name = default(string), string playAudioUuid = default(string), string say = default(string), int? timeout = default(int?))
        {
            this.AllowDirectExtensions = allowDirectExtensions;
            this.ConversationPbxMenuUuid = conversationPbxMenuUuid;
            this.DefaultAction = defaultAction;
            this.DefaultActionTarget = defaultActionTarget;
            this.Mappings = mappings;
            this.MerchantId = merchantId;
            this.Name = name;
            this.PlayAudioUuid = playAudioUuid;
            this.Say = say;
            this.Timeout = timeout;
        }
        
        /// <summary>
        /// If true, the customer is allowed to input direct extensions within this menu
        /// </summary>
        /// <value>If true, the customer is allowed to input direct extensions within this menu</value>
        [DataMember(Name="allow_direct_extensions", EmitDefaultValue=false)]
        public bool? AllowDirectExtensions { get; set; }

        /// <summary>
        /// Conversation Pbx Menu UUID
        /// </summary>
        /// <value>Conversation Pbx Menu UUID</value>
        [DataMember(Name="conversation_pbx_menu_uuid", EmitDefaultValue=false)]
        public string ConversationPbxMenuUuid { get; set; }

        /// <summary>
        /// The default action for this menu
        /// </summary>
        /// <value>The default action for this menu</value>
        [DataMember(Name="default_action", EmitDefaultValue=false)]
        public string DefaultAction { get; set; }

        /// <summary>
        /// The default action target for this menu
        /// </summary>
        /// <value>The default action target for this menu</value>
        [DataMember(Name="default_action_target", EmitDefaultValue=false)]
        public string DefaultActionTarget { get; set; }

        /// <summary>
        /// Action mappings for this menu
        /// </summary>
        /// <value>Action mappings for this menu</value>
        [DataMember(Name="mappings", EmitDefaultValue=false)]
        public List<ConversationPbxMenuMapping> Mappings { get; set; }

        /// <summary>
        /// Merchant Id
        /// </summary>
        /// <value>Merchant Id</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Menu name
        /// </summary>
        /// <value>Menu name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An optional audio clip that plays when a customer enters this menu
        /// </summary>
        /// <value>An optional audio clip that plays when a customer enters this menu</value>
        [DataMember(Name="play_audio_uuid", EmitDefaultValue=false)]
        public string PlayAudioUuid { get; set; }

        /// <summary>
        /// An optional saying that plays when a customer enters this menu
        /// </summary>
        /// <value>An optional saying that plays when a customer enters this menu</value>
        [DataMember(Name="say", EmitDefaultValue=false)]
        public string Say { get; set; }

        /// <summary>
        /// The idle seconds before this menu times out
        /// </summary>
        /// <value>The idle seconds before this menu times out</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationPbxMenu {\n");
            sb.Append("  AllowDirectExtensions: ").Append(AllowDirectExtensions).Append("\n");
            sb.Append("  ConversationPbxMenuUuid: ").Append(ConversationPbxMenuUuid).Append("\n");
            sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
            sb.Append("  DefaultActionTarget: ").Append(DefaultActionTarget).Append("\n");
            sb.Append("  Mappings: ").Append(Mappings).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlayAudioUuid: ").Append(PlayAudioUuid).Append("\n");
            sb.Append("  Say: ").Append(Say).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as ConversationPbxMenu);
        }

        /// <summary>
        /// Returns true if ConversationPbxMenu instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationPbxMenu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationPbxMenu input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowDirectExtensions == input.AllowDirectExtensions ||
                    (this.AllowDirectExtensions != null &&
                    this.AllowDirectExtensions.Equals(input.AllowDirectExtensions))
                ) && 
                (
                    this.ConversationPbxMenuUuid == input.ConversationPbxMenuUuid ||
                    (this.ConversationPbxMenuUuid != null &&
                    this.ConversationPbxMenuUuid.Equals(input.ConversationPbxMenuUuid))
                ) && 
                (
                    this.DefaultAction == input.DefaultAction ||
                    (this.DefaultAction != null &&
                    this.DefaultAction.Equals(input.DefaultAction))
                ) && 
                (
                    this.DefaultActionTarget == input.DefaultActionTarget ||
                    (this.DefaultActionTarget != null &&
                    this.DefaultActionTarget.Equals(input.DefaultActionTarget))
                ) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PlayAudioUuid == input.PlayAudioUuid ||
                    (this.PlayAudioUuid != null &&
                    this.PlayAudioUuid.Equals(input.PlayAudioUuid))
                ) && 
                (
                    this.Say == input.Say ||
                    (this.Say != null &&
                    this.Say.Equals(input.Say))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.AllowDirectExtensions != null)
                    hashCode = hashCode * 59 + this.AllowDirectExtensions.GetHashCode();
                if (this.ConversationPbxMenuUuid != null)
                    hashCode = hashCode * 59 + this.ConversationPbxMenuUuid.GetHashCode();
                if (this.DefaultAction != null)
                    hashCode = hashCode * 59 + this.DefaultAction.GetHashCode();
                if (this.DefaultActionTarget != null)
                    hashCode = hashCode * 59 + this.DefaultActionTarget.GetHashCode();
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlayAudioUuid != null)
                    hashCode = hashCode * 59 + this.PlayAudioUuid.GetHashCode();
                if (this.Say != null)
                    hashCode = hashCode * 59 + this.Say.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
            // ConversationPbxMenuUuid (string) maxLength
            if(this.ConversationPbxMenuUuid != null && this.ConversationPbxMenuUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConversationPbxMenuUuid, length must be less than 50.", new [] { "ConversationPbxMenuUuid" });
            }

            // DefaultAction (string) maxLength
            if(this.DefaultAction != null && this.DefaultAction.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultAction, length must be less than 30.", new [] { "DefaultAction" });
            }

            // DefaultActionTarget (string) maxLength
            if(this.DefaultActionTarget != null && this.DefaultActionTarget.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultActionTarget, length must be less than 50.", new [] { "DefaultActionTarget" });
            }

            // MerchantId (string) maxLength
            if(this.MerchantId != null && this.MerchantId.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantId, length must be less than 5.", new [] { "MerchantId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // PlayAudioUuid (string) maxLength
            if(this.PlayAudioUuid != null && this.PlayAudioUuid.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlayAudioUuid, length must be less than 50.", new [] { "PlayAudioUuid" });
            }

            yield break;
        }
    }

}

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
    /// GroupUserMembership
    /// </summary>
    [DataContract]
    public partial class GroupUserMembership :  IEquatable<GroupUserMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserMembership" /> class.
        /// </summary>
        /// <param name="email">The email for this user..</param>
        /// <param name="fullName">The full name for this user..</param>
        /// <param name="login">The login for this user..</param>
        /// <param name="member">True if this user belongs to the parent group, false otherwise..</param>
        /// <param name="userId">The user id for this user..</param>
        public GroupUserMembership(string email = default(string), string fullName = default(string), string login = default(string), bool? member = default(bool?), int? userId = default(int?))
        {
            this.Email = email;
            this.FullName = fullName;
            this.Login = login;
            this.Member = member;
            this.UserId = userId;
        }
        
        /// <summary>
        /// The email for this user.
        /// </summary>
        /// <value>The email for this user.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The full name for this user.
        /// </summary>
        /// <value>The full name for this user.</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// The login for this user.
        /// </summary>
        /// <value>The login for this user.</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }

        /// <summary>
        /// True if this user belongs to the parent group, false otherwise.
        /// </summary>
        /// <value>True if this user belongs to the parent group, false otherwise.</value>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public bool? Member { get; set; }

        /// <summary>
        /// The user id for this user.
        /// </summary>
        /// <value>The user id for this user.</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupUserMembership {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as GroupUserMembership);
        }

        /// <summary>
        /// Returns true if GroupUserMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupUserMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupUserMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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

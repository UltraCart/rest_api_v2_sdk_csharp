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
    /// RegisterAffiliateClickResponse
    /// </summary>
    [DataContract]
    public partial class RegisterAffiliateClickResponse :  IEquatable<RegisterAffiliateClickResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAffiliateClickResponse" /> class.
        /// </summary>
        /// <param name="cookieMaxAge">The cookie max age to use.</param>
        /// <param name="cookieNames">The names of all the cookies to set on the browser.</param>
        /// <param name="cookieValues">The values of all the cookies to set on the browser.</param>
        /// <param name="registered">True if a click was registered.</param>
        public RegisterAffiliateClickResponse(int cookieMaxAge = default(int), List<string> cookieNames = default(List<string>), List<string> cookieValues = default(List<string>), bool registered = default(bool))
        {
            this.CookieMaxAge = cookieMaxAge;
            this.CookieNames = cookieNames;
            this.CookieValues = cookieValues;
            this.Registered = registered;
        }

        /// <summary>
        /// The cookie max age to use
        /// </summary>
        /// <value>The cookie max age to use</value>
        [DataMember(Name="cookie_max_age", EmitDefaultValue=false)]
        public int CookieMaxAge { get; set; }

        /// <summary>
        /// The names of all the cookies to set on the browser
        /// </summary>
        /// <value>The names of all the cookies to set on the browser</value>
        [DataMember(Name="cookie_names", EmitDefaultValue=false)]
        public List<string> CookieNames { get; set; }

        /// <summary>
        /// The values of all the cookies to set on the browser
        /// </summary>
        /// <value>The values of all the cookies to set on the browser</value>
        [DataMember(Name="cookie_values", EmitDefaultValue=false)]
        public List<string> CookieValues { get; set; }

        /// <summary>
        /// True if a click was registered
        /// </summary>
        /// <value>True if a click was registered</value>
        [DataMember(Name="registered", EmitDefaultValue=false)]
        public bool Registered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterAffiliateClickResponse {\n");
            sb.Append("  CookieMaxAge: ").Append(CookieMaxAge).Append("\n");
            sb.Append("  CookieNames: ").Append(CookieNames).Append("\n");
            sb.Append("  CookieValues: ").Append(CookieValues).Append("\n");
            sb.Append("  Registered: ").Append(Registered).Append("\n");
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
            return this.Equals(input as RegisterAffiliateClickResponse);
        }

        /// <summary>
        /// Returns true if RegisterAffiliateClickResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterAffiliateClickResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterAffiliateClickResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CookieMaxAge == input.CookieMaxAge ||
                    (this.CookieMaxAge != null &&
                    this.CookieMaxAge.Equals(input.CookieMaxAge))
                ) && 
                (
                    this.CookieNames == input.CookieNames ||
                    this.CookieNames != null &&
                    input.CookieNames != null &&
                    this.CookieNames.SequenceEqual(input.CookieNames)
                ) && 
                (
                    this.CookieValues == input.CookieValues ||
                    this.CookieValues != null &&
                    input.CookieValues != null &&
                    this.CookieValues.SequenceEqual(input.CookieValues)
                ) && 
                (
                    this.Registered == input.Registered ||
                    (this.Registered != null &&
                    this.Registered.Equals(input.Registered))
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
                if (this.CookieMaxAge != null)
                    hashCode = hashCode * 59 + this.CookieMaxAge.GetHashCode();
                if (this.CookieNames != null)
                    hashCode = hashCode * 59 + this.CookieNames.GetHashCode();
                if (this.CookieValues != null)
                    hashCode = hashCode * 59 + this.CookieValues.GetHashCode();
                if (this.Registered != null)
                    hashCode = hashCode * 59 + this.Registered.GetHashCode();
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

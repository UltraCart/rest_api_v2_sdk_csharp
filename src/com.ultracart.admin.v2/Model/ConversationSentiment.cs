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
    /// ConversationSentiment
    /// </summary>
    [DataContract]
    public partial class ConversationSentiment :  IEquatable<ConversationSentiment>, IValidatableObject
    {
        /// <summary>
        /// The overall sentiment
        /// </summary>
        /// <value>The overall sentiment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SentimentEnum
        {
            
            /// <summary>
            /// Enum POSITIVE for value: POSITIVE
            /// </summary>
            [EnumMember(Value = "POSITIVE")]
            POSITIVE = 1,
            
            /// <summary>
            /// Enum NEUTRAL for value: NEUTRAL
            /// </summary>
            [EnumMember(Value = "NEUTRAL")]
            NEUTRAL = 2,
            
            /// <summary>
            /// Enum NEGATIVE for value: NEGATIVE
            /// </summary>
            [EnumMember(Value = "NEGATIVE")]
            NEGATIVE = 3,
            
            /// <summary>
            /// Enum MIXED for value: MIXED
            /// </summary>
            [EnumMember(Value = "MIXED")]
            MIXED = 4
        }

        /// <summary>
        /// The overall sentiment
        /// </summary>
        /// <value>The overall sentiment</value>
        [DataMember(Name="sentiment", EmitDefaultValue=false)]
        public SentimentEnum? Sentiment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSentiment" /> class.
        /// </summary>
        /// <param name="lastDetectSentiment">The last time the detect sentiment was run on this conversation.</param>
        /// <param name="mixed">The mixed score.</param>
        /// <param name="negative">The negative score.</param>
        /// <param name="neutral">The neutral score.</param>
        /// <param name="positive">The positive score.</param>
        /// <param name="sentiment">The overall sentiment.</param>
        public ConversationSentiment(string lastDetectSentiment = default(string), decimal? mixed = default(decimal?), decimal? negative = default(decimal?), decimal? neutral = default(decimal?), decimal? positive = default(decimal?), SentimentEnum? sentiment = default(SentimentEnum?))
        {
            this.LastDetectSentiment = lastDetectSentiment;
            this.Mixed = mixed;
            this.Negative = negative;
            this.Neutral = neutral;
            this.Positive = positive;
            this.Sentiment = sentiment;
        }
        
        /// <summary>
        /// The last time the detect sentiment was run on this conversation
        /// </summary>
        /// <value>The last time the detect sentiment was run on this conversation</value>
        [DataMember(Name="last_detect_sentiment", EmitDefaultValue=false)]
        public string LastDetectSentiment { get; set; }

        /// <summary>
        /// The mixed score
        /// </summary>
        /// <value>The mixed score</value>
        [DataMember(Name="mixed", EmitDefaultValue=false)]
        public decimal? Mixed { get; set; }

        /// <summary>
        /// The negative score
        /// </summary>
        /// <value>The negative score</value>
        [DataMember(Name="negative", EmitDefaultValue=false)]
        public decimal? Negative { get; set; }

        /// <summary>
        /// The neutral score
        /// </summary>
        /// <value>The neutral score</value>
        [DataMember(Name="neutral", EmitDefaultValue=false)]
        public decimal? Neutral { get; set; }

        /// <summary>
        /// The positive score
        /// </summary>
        /// <value>The positive score</value>
        [DataMember(Name="positive", EmitDefaultValue=false)]
        public decimal? Positive { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSentiment {\n");
            sb.Append("  LastDetectSentiment: ").Append(LastDetectSentiment).Append("\n");
            sb.Append("  Mixed: ").Append(Mixed).Append("\n");
            sb.Append("  Negative: ").Append(Negative).Append("\n");
            sb.Append("  Neutral: ").Append(Neutral).Append("\n");
            sb.Append("  Positive: ").Append(Positive).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
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
            return this.Equals(input as ConversationSentiment);
        }

        /// <summary>
        /// Returns true if ConversationSentiment instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationSentiment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSentiment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastDetectSentiment == input.LastDetectSentiment ||
                    (this.LastDetectSentiment != null &&
                    this.LastDetectSentiment.Equals(input.LastDetectSentiment))
                ) && 
                (
                    this.Mixed == input.Mixed ||
                    (this.Mixed != null &&
                    this.Mixed.Equals(input.Mixed))
                ) && 
                (
                    this.Negative == input.Negative ||
                    (this.Negative != null &&
                    this.Negative.Equals(input.Negative))
                ) && 
                (
                    this.Neutral == input.Neutral ||
                    (this.Neutral != null &&
                    this.Neutral.Equals(input.Neutral))
                ) && 
                (
                    this.Positive == input.Positive ||
                    (this.Positive != null &&
                    this.Positive.Equals(input.Positive))
                ) && 
                (
                    this.Sentiment == input.Sentiment ||
                    (this.Sentiment != null &&
                    this.Sentiment.Equals(input.Sentiment))
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
                if (this.LastDetectSentiment != null)
                    hashCode = hashCode * 59 + this.LastDetectSentiment.GetHashCode();
                if (this.Mixed != null)
                    hashCode = hashCode * 59 + this.Mixed.GetHashCode();
                if (this.Negative != null)
                    hashCode = hashCode * 59 + this.Negative.GetHashCode();
                if (this.Neutral != null)
                    hashCode = hashCode * 59 + this.Neutral.GetHashCode();
                if (this.Positive != null)
                    hashCode = hashCode * 59 + this.Positive.GetHashCode();
                if (this.Sentiment != null)
                    hashCode = hashCode * 59 + this.Sentiment.GetHashCode();
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

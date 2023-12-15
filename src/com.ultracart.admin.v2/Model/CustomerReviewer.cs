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
    /// CustomerReviewer
    /// </summary>
    [DataContract]
    public partial class CustomerReviewer :  IEquatable<CustomerReviewer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewer" /> class.
        /// </summary>
        /// <param name="autoApprove">True if reviewes from this customer profile should automatically be approved.</param>
        /// <param name="averageOverallRating">Average overall rating of items reviewed.</param>
        /// <param name="expert">True if the customer is an expert.</param>
        /// <param name="firstReview">First review.</param>
        /// <param name="lastReview">Last review.</param>
        /// <param name="location">Location of the reviewer.</param>
        /// <param name="nickname">Nickname of the reviewer.</param>
        /// <param name="numberHelpfulReviewVotes">Number of helpful review votes.</param>
        /// <param name="rank">Rank of this reviewer.</param>
        /// <param name="reviewsContributed">Number of reviews contributed.</param>
        public CustomerReviewer(bool? autoApprove = default(bool?), decimal? averageOverallRating = default(decimal?), bool? expert = default(bool?), string firstReview = default(string), string lastReview = default(string), string location = default(string), string nickname = default(string), int? numberHelpfulReviewVotes = default(int?), int? rank = default(int?), int? reviewsContributed = default(int?))
        {
            this.AutoApprove = autoApprove;
            this.AverageOverallRating = averageOverallRating;
            this.Expert = expert;
            this.FirstReview = firstReview;
            this.LastReview = lastReview;
            this.Location = location;
            this.Nickname = nickname;
            this.NumberHelpfulReviewVotes = numberHelpfulReviewVotes;
            this.Rank = rank;
            this.ReviewsContributed = reviewsContributed;
        }
        
        /// <summary>
        /// True if reviewes from this customer profile should automatically be approved
        /// </summary>
        /// <value>True if reviewes from this customer profile should automatically be approved</value>
        [DataMember(Name="auto_approve", EmitDefaultValue=false)]
        public bool? AutoApprove { get; set; }

        /// <summary>
        /// Average overall rating of items reviewed
        /// </summary>
        /// <value>Average overall rating of items reviewed</value>
        [DataMember(Name="average_overall_rating", EmitDefaultValue=false)]
        public decimal? AverageOverallRating { get; set; }

        /// <summary>
        /// True if the customer is an expert
        /// </summary>
        /// <value>True if the customer is an expert</value>
        [DataMember(Name="expert", EmitDefaultValue=false)]
        public bool? Expert { get; set; }

        /// <summary>
        /// First review
        /// </summary>
        /// <value>First review</value>
        [DataMember(Name="first_review", EmitDefaultValue=false)]
        public string FirstReview { get; set; }

        /// <summary>
        /// Last review
        /// </summary>
        /// <value>Last review</value>
        [DataMember(Name="last_review", EmitDefaultValue=false)]
        public string LastReview { get; set; }

        /// <summary>
        /// Location of the reviewer
        /// </summary>
        /// <value>Location of the reviewer</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Nickname of the reviewer
        /// </summary>
        /// <value>Nickname of the reviewer</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Number of helpful review votes
        /// </summary>
        /// <value>Number of helpful review votes</value>
        [DataMember(Name="number_helpful_review_votes", EmitDefaultValue=false)]
        public int? NumberHelpfulReviewVotes { get; set; }

        /// <summary>
        /// Rank of this reviewer
        /// </summary>
        /// <value>Rank of this reviewer</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Number of reviews contributed
        /// </summary>
        /// <value>Number of reviews contributed</value>
        [DataMember(Name="reviews_contributed", EmitDefaultValue=false)]
        public int? ReviewsContributed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerReviewer {\n");
            sb.Append("  AutoApprove: ").Append(AutoApprove).Append("\n");
            sb.Append("  AverageOverallRating: ").Append(AverageOverallRating).Append("\n");
            sb.Append("  Expert: ").Append(Expert).Append("\n");
            sb.Append("  FirstReview: ").Append(FirstReview).Append("\n");
            sb.Append("  LastReview: ").Append(LastReview).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  NumberHelpfulReviewVotes: ").Append(NumberHelpfulReviewVotes).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  ReviewsContributed: ").Append(ReviewsContributed).Append("\n");
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
            return this.Equals(input as CustomerReviewer);
        }

        /// <summary>
        /// Returns true if CustomerReviewer instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerReviewer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerReviewer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoApprove == input.AutoApprove ||
                    (this.AutoApprove != null &&
                    this.AutoApprove.Equals(input.AutoApprove))
                ) && 
                (
                    this.AverageOverallRating == input.AverageOverallRating ||
                    (this.AverageOverallRating != null &&
                    this.AverageOverallRating.Equals(input.AverageOverallRating))
                ) && 
                (
                    this.Expert == input.Expert ||
                    (this.Expert != null &&
                    this.Expert.Equals(input.Expert))
                ) && 
                (
                    this.FirstReview == input.FirstReview ||
                    (this.FirstReview != null &&
                    this.FirstReview.Equals(input.FirstReview))
                ) && 
                (
                    this.LastReview == input.LastReview ||
                    (this.LastReview != null &&
                    this.LastReview.Equals(input.LastReview))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.NumberHelpfulReviewVotes == input.NumberHelpfulReviewVotes ||
                    (this.NumberHelpfulReviewVotes != null &&
                    this.NumberHelpfulReviewVotes.Equals(input.NumberHelpfulReviewVotes))
                ) && 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.ReviewsContributed == input.ReviewsContributed ||
                    (this.ReviewsContributed != null &&
                    this.ReviewsContributed.Equals(input.ReviewsContributed))
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
                if (this.AutoApprove != null)
                    hashCode = hashCode * 59 + this.AutoApprove.GetHashCode();
                if (this.AverageOverallRating != null)
                    hashCode = hashCode * 59 + this.AverageOverallRating.GetHashCode();
                if (this.Expert != null)
                    hashCode = hashCode * 59 + this.Expert.GetHashCode();
                if (this.FirstReview != null)
                    hashCode = hashCode * 59 + this.FirstReview.GetHashCode();
                if (this.LastReview != null)
                    hashCode = hashCode * 59 + this.LastReview.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.NumberHelpfulReviewVotes != null)
                    hashCode = hashCode * 59 + this.NumberHelpfulReviewVotes.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.ReviewsContributed != null)
                    hashCode = hashCode * 59 + this.ReviewsContributed.GetHashCode();
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

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
    /// ItemReview
    /// </summary>
    [DataContract]
    public partial class ItemReview :  IEquatable<ItemReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReview" /> class.
        /// </summary>
        /// <param name="customerProfileOid">Customer profile object identifier.</param>
        /// <param name="featured">featured.</param>
        /// <param name="helperfulNoVotes">helperfulNoVotes.</param>
        /// <param name="helpfulYesVotes">helpfulYesVotes.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="overall">overall.</param>
        /// <param name="ratingName1">ratingName1.</param>
        /// <param name="ratingName10">ratingName10.</param>
        /// <param name="ratingName2">ratingName2.</param>
        /// <param name="ratingName3">ratingName3.</param>
        /// <param name="ratingName4">ratingName4.</param>
        /// <param name="ratingName5">ratingName5.</param>
        /// <param name="ratingName6">ratingName6.</param>
        /// <param name="ratingName7">ratingName7.</param>
        /// <param name="ratingName8">ratingName8.</param>
        /// <param name="ratingName9">ratingName9.</param>
        /// <param name="ratingScore1">ratingScore1.</param>
        /// <param name="ratingScore10">ratingScore10.</param>
        /// <param name="ratingScore2">ratingScore2.</param>
        /// <param name="ratingScore3">ratingScore3.</param>
        /// <param name="ratingScore4">ratingScore4.</param>
        /// <param name="ratingScore5">ratingScore5.</param>
        /// <param name="ratingScore6">ratingScore6.</param>
        /// <param name="ratingScore7">ratingScore7.</param>
        /// <param name="ratingScore8">ratingScore8.</param>
        /// <param name="ratingScore9">ratingScore9.</param>
        /// <param name="recommendStoreToFriend">recommendStoreToFriend.</param>
        /// <param name="recommendToFriend">recommendToFriend.</param>
        /// <param name="review">review.</param>
        /// <param name="reviewOid">reviewOid.</param>
        /// <param name="reviewedNickname">reviewedNickname.</param>
        /// <param name="reviewerEmail">reviewerEmail.</param>
        /// <param name="reviewerLocation">reviewerLocation.</param>
        /// <param name="status">status.</param>
        /// <param name="storeFeedback">storeFeedback.</param>
        /// <param name="submittedDts">Date/time of review submission.</param>
        /// <param name="title">title.</param>
        public ItemReview(int customerProfileOid = default(int), bool featured = default(bool), int helperfulNoVotes = default(int), int helpfulYesVotes = default(int), string orderId = default(string), decimal overall = default(decimal), string ratingName1 = default(string), string ratingName10 = default(string), string ratingName2 = default(string), string ratingName3 = default(string), string ratingName4 = default(string), string ratingName5 = default(string), string ratingName6 = default(string), string ratingName7 = default(string), string ratingName8 = default(string), string ratingName9 = default(string), decimal ratingScore1 = default(decimal), decimal ratingScore10 = default(decimal), decimal ratingScore2 = default(decimal), decimal ratingScore3 = default(decimal), decimal ratingScore4 = default(decimal), decimal ratingScore5 = default(decimal), decimal ratingScore6 = default(decimal), decimal ratingScore7 = default(decimal), decimal ratingScore8 = default(decimal), decimal ratingScore9 = default(decimal), int recommendStoreToFriend = default(int), bool recommendToFriend = default(bool), string review = default(string), int reviewOid = default(int), string reviewedNickname = default(string), string reviewerEmail = default(string), string reviewerLocation = default(string), string status = default(string), string storeFeedback = default(string), string submittedDts = default(string), string title = default(string))
        {
            this.CustomerProfileOid = customerProfileOid;
            this.Featured = featured;
            this.HelperfulNoVotes = helperfulNoVotes;
            this.HelpfulYesVotes = helpfulYesVotes;
            this.OrderId = orderId;
            this.Overall = overall;
            this.RatingName1 = ratingName1;
            this.RatingName10 = ratingName10;
            this.RatingName2 = ratingName2;
            this.RatingName3 = ratingName3;
            this.RatingName4 = ratingName4;
            this.RatingName5 = ratingName5;
            this.RatingName6 = ratingName6;
            this.RatingName7 = ratingName7;
            this.RatingName8 = ratingName8;
            this.RatingName9 = ratingName9;
            this.RatingScore1 = ratingScore1;
            this.RatingScore10 = ratingScore10;
            this.RatingScore2 = ratingScore2;
            this.RatingScore3 = ratingScore3;
            this.RatingScore4 = ratingScore4;
            this.RatingScore5 = ratingScore5;
            this.RatingScore6 = ratingScore6;
            this.RatingScore7 = ratingScore7;
            this.RatingScore8 = ratingScore8;
            this.RatingScore9 = ratingScore9;
            this.RecommendStoreToFriend = recommendStoreToFriend;
            this.RecommendToFriend = recommendToFriend;
            this.Review = review;
            this.ReviewOid = reviewOid;
            this.ReviewedNickname = reviewedNickname;
            this.ReviewerEmail = reviewerEmail;
            this.ReviewerLocation = reviewerLocation;
            this.Status = status;
            this.StoreFeedback = storeFeedback;
            this.SubmittedDts = submittedDts;
            this.Title = title;
        }

        /// <summary>
        /// Customer profile object identifier
        /// </summary>
        /// <value>Customer profile object identifier</value>
        [DataMember(Name="customer_profile_oid", EmitDefaultValue=false)]
        public int CustomerProfileOid { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name="featured", EmitDefaultValue=false)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets HelperfulNoVotes
        /// </summary>
        [DataMember(Name="helperful_no_votes", EmitDefaultValue=false)]
        public int HelperfulNoVotes { get; set; }

        /// <summary>
        /// Gets or Sets HelpfulYesVotes
        /// </summary>
        [DataMember(Name="helpful_yes_votes", EmitDefaultValue=false)]
        public int HelpfulYesVotes { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public decimal Overall { get; set; }

        /// <summary>
        /// Gets or Sets RatingName1
        /// </summary>
        [DataMember(Name="rating_name1", EmitDefaultValue=false)]
        public string RatingName1 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName10
        /// </summary>
        [DataMember(Name="rating_name10", EmitDefaultValue=false)]
        public string RatingName10 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName2
        /// </summary>
        [DataMember(Name="rating_name2", EmitDefaultValue=false)]
        public string RatingName2 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName3
        /// </summary>
        [DataMember(Name="rating_name3", EmitDefaultValue=false)]
        public string RatingName3 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName4
        /// </summary>
        [DataMember(Name="rating_name4", EmitDefaultValue=false)]
        public string RatingName4 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName5
        /// </summary>
        [DataMember(Name="rating_name5", EmitDefaultValue=false)]
        public string RatingName5 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName6
        /// </summary>
        [DataMember(Name="rating_name6", EmitDefaultValue=false)]
        public string RatingName6 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName7
        /// </summary>
        [DataMember(Name="rating_name7", EmitDefaultValue=false)]
        public string RatingName7 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName8
        /// </summary>
        [DataMember(Name="rating_name8", EmitDefaultValue=false)]
        public string RatingName8 { get; set; }

        /// <summary>
        /// Gets or Sets RatingName9
        /// </summary>
        [DataMember(Name="rating_name9", EmitDefaultValue=false)]
        public string RatingName9 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore1
        /// </summary>
        [DataMember(Name="rating_score1", EmitDefaultValue=false)]
        public decimal RatingScore1 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore10
        /// </summary>
        [DataMember(Name="rating_score10", EmitDefaultValue=false)]
        public decimal RatingScore10 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore2
        /// </summary>
        [DataMember(Name="rating_score2", EmitDefaultValue=false)]
        public decimal RatingScore2 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore3
        /// </summary>
        [DataMember(Name="rating_score3", EmitDefaultValue=false)]
        public decimal RatingScore3 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore4
        /// </summary>
        [DataMember(Name="rating_score4", EmitDefaultValue=false)]
        public decimal RatingScore4 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore5
        /// </summary>
        [DataMember(Name="rating_score5", EmitDefaultValue=false)]
        public decimal RatingScore5 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore6
        /// </summary>
        [DataMember(Name="rating_score6", EmitDefaultValue=false)]
        public decimal RatingScore6 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore7
        /// </summary>
        [DataMember(Name="rating_score7", EmitDefaultValue=false)]
        public decimal RatingScore7 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore8
        /// </summary>
        [DataMember(Name="rating_score8", EmitDefaultValue=false)]
        public decimal RatingScore8 { get; set; }

        /// <summary>
        /// Gets or Sets RatingScore9
        /// </summary>
        [DataMember(Name="rating_score9", EmitDefaultValue=false)]
        public decimal RatingScore9 { get; set; }

        /// <summary>
        /// Gets or Sets RecommendStoreToFriend
        /// </summary>
        [DataMember(Name="recommend_store_to_friend", EmitDefaultValue=false)]
        public int RecommendStoreToFriend { get; set; }

        /// <summary>
        /// Gets or Sets RecommendToFriend
        /// </summary>
        [DataMember(Name="recommend_to_friend", EmitDefaultValue=false)]
        public bool RecommendToFriend { get; set; }

        /// <summary>
        /// Gets or Sets Review
        /// </summary>
        [DataMember(Name="review", EmitDefaultValue=false)]
        public string Review { get; set; }

        /// <summary>
        /// Gets or Sets ReviewOid
        /// </summary>
        [DataMember(Name="review_oid", EmitDefaultValue=false)]
        public int ReviewOid { get; set; }

        /// <summary>
        /// Gets or Sets ReviewedNickname
        /// </summary>
        [DataMember(Name="reviewed_nickname", EmitDefaultValue=false)]
        public string ReviewedNickname { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerEmail
        /// </summary>
        [DataMember(Name="reviewer_email", EmitDefaultValue=false)]
        public string ReviewerEmail { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerLocation
        /// </summary>
        [DataMember(Name="reviewer_location", EmitDefaultValue=false)]
        public string ReviewerLocation { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StoreFeedback
        /// </summary>
        [DataMember(Name="store_feedback", EmitDefaultValue=false)]
        public string StoreFeedback { get; set; }

        /// <summary>
        /// Date/time of review submission
        /// </summary>
        /// <value>Date/time of review submission</value>
        [DataMember(Name="submitted_dts", EmitDefaultValue=false)]
        public string SubmittedDts { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemReview {\n");
            sb.Append("  CustomerProfileOid: ").Append(CustomerProfileOid).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  HelperfulNoVotes: ").Append(HelperfulNoVotes).Append("\n");
            sb.Append("  HelpfulYesVotes: ").Append(HelpfulYesVotes).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  RatingName1: ").Append(RatingName1).Append("\n");
            sb.Append("  RatingName10: ").Append(RatingName10).Append("\n");
            sb.Append("  RatingName2: ").Append(RatingName2).Append("\n");
            sb.Append("  RatingName3: ").Append(RatingName3).Append("\n");
            sb.Append("  RatingName4: ").Append(RatingName4).Append("\n");
            sb.Append("  RatingName5: ").Append(RatingName5).Append("\n");
            sb.Append("  RatingName6: ").Append(RatingName6).Append("\n");
            sb.Append("  RatingName7: ").Append(RatingName7).Append("\n");
            sb.Append("  RatingName8: ").Append(RatingName8).Append("\n");
            sb.Append("  RatingName9: ").Append(RatingName9).Append("\n");
            sb.Append("  RatingScore1: ").Append(RatingScore1).Append("\n");
            sb.Append("  RatingScore10: ").Append(RatingScore10).Append("\n");
            sb.Append("  RatingScore2: ").Append(RatingScore2).Append("\n");
            sb.Append("  RatingScore3: ").Append(RatingScore3).Append("\n");
            sb.Append("  RatingScore4: ").Append(RatingScore4).Append("\n");
            sb.Append("  RatingScore5: ").Append(RatingScore5).Append("\n");
            sb.Append("  RatingScore6: ").Append(RatingScore6).Append("\n");
            sb.Append("  RatingScore7: ").Append(RatingScore7).Append("\n");
            sb.Append("  RatingScore8: ").Append(RatingScore8).Append("\n");
            sb.Append("  RatingScore9: ").Append(RatingScore9).Append("\n");
            sb.Append("  RecommendStoreToFriend: ").Append(RecommendStoreToFriend).Append("\n");
            sb.Append("  RecommendToFriend: ").Append(RecommendToFriend).Append("\n");
            sb.Append("  Review: ").Append(Review).Append("\n");
            sb.Append("  ReviewOid: ").Append(ReviewOid).Append("\n");
            sb.Append("  ReviewedNickname: ").Append(ReviewedNickname).Append("\n");
            sb.Append("  ReviewerEmail: ").Append(ReviewerEmail).Append("\n");
            sb.Append("  ReviewerLocation: ").Append(ReviewerLocation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StoreFeedback: ").Append(StoreFeedback).Append("\n");
            sb.Append("  SubmittedDts: ").Append(SubmittedDts).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ItemReview);
        }

        /// <summary>
        /// Returns true if ItemReview instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemReview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfileOid == input.CustomerProfileOid ||
                    (this.CustomerProfileOid != null &&
                    this.CustomerProfileOid.Equals(input.CustomerProfileOid))
                ) && 
                (
                    this.Featured == input.Featured ||
                    (this.Featured != null &&
                    this.Featured.Equals(input.Featured))
                ) && 
                (
                    this.HelperfulNoVotes == input.HelperfulNoVotes ||
                    (this.HelperfulNoVotes != null &&
                    this.HelperfulNoVotes.Equals(input.HelperfulNoVotes))
                ) && 
                (
                    this.HelpfulYesVotes == input.HelpfulYesVotes ||
                    (this.HelpfulYesVotes != null &&
                    this.HelpfulYesVotes.Equals(input.HelpfulYesVotes))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.RatingName1 == input.RatingName1 ||
                    (this.RatingName1 != null &&
                    this.RatingName1.Equals(input.RatingName1))
                ) && 
                (
                    this.RatingName10 == input.RatingName10 ||
                    (this.RatingName10 != null &&
                    this.RatingName10.Equals(input.RatingName10))
                ) && 
                (
                    this.RatingName2 == input.RatingName2 ||
                    (this.RatingName2 != null &&
                    this.RatingName2.Equals(input.RatingName2))
                ) && 
                (
                    this.RatingName3 == input.RatingName3 ||
                    (this.RatingName3 != null &&
                    this.RatingName3.Equals(input.RatingName3))
                ) && 
                (
                    this.RatingName4 == input.RatingName4 ||
                    (this.RatingName4 != null &&
                    this.RatingName4.Equals(input.RatingName4))
                ) && 
                (
                    this.RatingName5 == input.RatingName5 ||
                    (this.RatingName5 != null &&
                    this.RatingName5.Equals(input.RatingName5))
                ) && 
                (
                    this.RatingName6 == input.RatingName6 ||
                    (this.RatingName6 != null &&
                    this.RatingName6.Equals(input.RatingName6))
                ) && 
                (
                    this.RatingName7 == input.RatingName7 ||
                    (this.RatingName7 != null &&
                    this.RatingName7.Equals(input.RatingName7))
                ) && 
                (
                    this.RatingName8 == input.RatingName8 ||
                    (this.RatingName8 != null &&
                    this.RatingName8.Equals(input.RatingName8))
                ) && 
                (
                    this.RatingName9 == input.RatingName9 ||
                    (this.RatingName9 != null &&
                    this.RatingName9.Equals(input.RatingName9))
                ) && 
                (
                    this.RatingScore1 == input.RatingScore1 ||
                    (this.RatingScore1 != null &&
                    this.RatingScore1.Equals(input.RatingScore1))
                ) && 
                (
                    this.RatingScore10 == input.RatingScore10 ||
                    (this.RatingScore10 != null &&
                    this.RatingScore10.Equals(input.RatingScore10))
                ) && 
                (
                    this.RatingScore2 == input.RatingScore2 ||
                    (this.RatingScore2 != null &&
                    this.RatingScore2.Equals(input.RatingScore2))
                ) && 
                (
                    this.RatingScore3 == input.RatingScore3 ||
                    (this.RatingScore3 != null &&
                    this.RatingScore3.Equals(input.RatingScore3))
                ) && 
                (
                    this.RatingScore4 == input.RatingScore4 ||
                    (this.RatingScore4 != null &&
                    this.RatingScore4.Equals(input.RatingScore4))
                ) && 
                (
                    this.RatingScore5 == input.RatingScore5 ||
                    (this.RatingScore5 != null &&
                    this.RatingScore5.Equals(input.RatingScore5))
                ) && 
                (
                    this.RatingScore6 == input.RatingScore6 ||
                    (this.RatingScore6 != null &&
                    this.RatingScore6.Equals(input.RatingScore6))
                ) && 
                (
                    this.RatingScore7 == input.RatingScore7 ||
                    (this.RatingScore7 != null &&
                    this.RatingScore7.Equals(input.RatingScore7))
                ) && 
                (
                    this.RatingScore8 == input.RatingScore8 ||
                    (this.RatingScore8 != null &&
                    this.RatingScore8.Equals(input.RatingScore8))
                ) && 
                (
                    this.RatingScore9 == input.RatingScore9 ||
                    (this.RatingScore9 != null &&
                    this.RatingScore9.Equals(input.RatingScore9))
                ) && 
                (
                    this.RecommendStoreToFriend == input.RecommendStoreToFriend ||
                    (this.RecommendStoreToFriend != null &&
                    this.RecommendStoreToFriend.Equals(input.RecommendStoreToFriend))
                ) && 
                (
                    this.RecommendToFriend == input.RecommendToFriend ||
                    (this.RecommendToFriend != null &&
                    this.RecommendToFriend.Equals(input.RecommendToFriend))
                ) && 
                (
                    this.Review == input.Review ||
                    (this.Review != null &&
                    this.Review.Equals(input.Review))
                ) && 
                (
                    this.ReviewOid == input.ReviewOid ||
                    (this.ReviewOid != null &&
                    this.ReviewOid.Equals(input.ReviewOid))
                ) && 
                (
                    this.ReviewedNickname == input.ReviewedNickname ||
                    (this.ReviewedNickname != null &&
                    this.ReviewedNickname.Equals(input.ReviewedNickname))
                ) && 
                (
                    this.ReviewerEmail == input.ReviewerEmail ||
                    (this.ReviewerEmail != null &&
                    this.ReviewerEmail.Equals(input.ReviewerEmail))
                ) && 
                (
                    this.ReviewerLocation == input.ReviewerLocation ||
                    (this.ReviewerLocation != null &&
                    this.ReviewerLocation.Equals(input.ReviewerLocation))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StoreFeedback == input.StoreFeedback ||
                    (this.StoreFeedback != null &&
                    this.StoreFeedback.Equals(input.StoreFeedback))
                ) && 
                (
                    this.SubmittedDts == input.SubmittedDts ||
                    (this.SubmittedDts != null &&
                    this.SubmittedDts.Equals(input.SubmittedDts))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.CustomerProfileOid != null)
                    hashCode = hashCode * 59 + this.CustomerProfileOid.GetHashCode();
                if (this.Featured != null)
                    hashCode = hashCode * 59 + this.Featured.GetHashCode();
                if (this.HelperfulNoVotes != null)
                    hashCode = hashCode * 59 + this.HelperfulNoVotes.GetHashCode();
                if (this.HelpfulYesVotes != null)
                    hashCode = hashCode * 59 + this.HelpfulYesVotes.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.RatingName1 != null)
                    hashCode = hashCode * 59 + this.RatingName1.GetHashCode();
                if (this.RatingName10 != null)
                    hashCode = hashCode * 59 + this.RatingName10.GetHashCode();
                if (this.RatingName2 != null)
                    hashCode = hashCode * 59 + this.RatingName2.GetHashCode();
                if (this.RatingName3 != null)
                    hashCode = hashCode * 59 + this.RatingName3.GetHashCode();
                if (this.RatingName4 != null)
                    hashCode = hashCode * 59 + this.RatingName4.GetHashCode();
                if (this.RatingName5 != null)
                    hashCode = hashCode * 59 + this.RatingName5.GetHashCode();
                if (this.RatingName6 != null)
                    hashCode = hashCode * 59 + this.RatingName6.GetHashCode();
                if (this.RatingName7 != null)
                    hashCode = hashCode * 59 + this.RatingName7.GetHashCode();
                if (this.RatingName8 != null)
                    hashCode = hashCode * 59 + this.RatingName8.GetHashCode();
                if (this.RatingName9 != null)
                    hashCode = hashCode * 59 + this.RatingName9.GetHashCode();
                if (this.RatingScore1 != null)
                    hashCode = hashCode * 59 + this.RatingScore1.GetHashCode();
                if (this.RatingScore10 != null)
                    hashCode = hashCode * 59 + this.RatingScore10.GetHashCode();
                if (this.RatingScore2 != null)
                    hashCode = hashCode * 59 + this.RatingScore2.GetHashCode();
                if (this.RatingScore3 != null)
                    hashCode = hashCode * 59 + this.RatingScore3.GetHashCode();
                if (this.RatingScore4 != null)
                    hashCode = hashCode * 59 + this.RatingScore4.GetHashCode();
                if (this.RatingScore5 != null)
                    hashCode = hashCode * 59 + this.RatingScore5.GetHashCode();
                if (this.RatingScore6 != null)
                    hashCode = hashCode * 59 + this.RatingScore6.GetHashCode();
                if (this.RatingScore7 != null)
                    hashCode = hashCode * 59 + this.RatingScore7.GetHashCode();
                if (this.RatingScore8 != null)
                    hashCode = hashCode * 59 + this.RatingScore8.GetHashCode();
                if (this.RatingScore9 != null)
                    hashCode = hashCode * 59 + this.RatingScore9.GetHashCode();
                if (this.RecommendStoreToFriend != null)
                    hashCode = hashCode * 59 + this.RecommendStoreToFriend.GetHashCode();
                if (this.RecommendToFriend != null)
                    hashCode = hashCode * 59 + this.RecommendToFriend.GetHashCode();
                if (this.Review != null)
                    hashCode = hashCode * 59 + this.Review.GetHashCode();
                if (this.ReviewOid != null)
                    hashCode = hashCode * 59 + this.ReviewOid.GetHashCode();
                if (this.ReviewedNickname != null)
                    hashCode = hashCode * 59 + this.ReviewedNickname.GetHashCode();
                if (this.ReviewerEmail != null)
                    hashCode = hashCode * 59 + this.ReviewerEmail.GetHashCode();
                if (this.ReviewerLocation != null)
                    hashCode = hashCode * 59 + this.ReviewerLocation.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StoreFeedback != null)
                    hashCode = hashCode * 59 + this.StoreFeedback.GetHashCode();
                if (this.SubmittedDts != null)
                    hashCode = hashCode * 59 + this.SubmittedDts.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
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
    /// PaymentsConfigurationPayPal
    /// </summary>
    [DataContract]
    public partial class PaymentsConfigurationPayPal :  IEquatable<PaymentsConfigurationPayPal>, IValidatableObject
    {
        /// <summary>
        /// PayPal configuration, live or sandbox
        /// </summary>
        /// <value>PayPal configuration, live or sandbox</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            
            /// <summary>
            /// Enum Live for value: Live
            /// </summary>
            [EnumMember(Value = "Live")]
            Live = 1,
            
            /// <summary>
            /// Enum Sandbox for value: Sandbox
            /// </summary>
            [EnumMember(Value = "Sandbox")]
            Sandbox = 2
        }

        /// <summary>
        /// PayPal configuration, live or sandbox
        /// </summary>
        /// <value>PayPal configuration, live or sandbox</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// PayPal landing page
        /// </summary>
        /// <value>PayPal landing page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LandingPageEnum
        {
            
            /// <summary>
            /// Enum Billing for value: Billing
            /// </summary>
            [EnumMember(Value = "Billing")]
            Billing = 1,
            
            /// <summary>
            /// Enum Login for value: Login
            /// </summary>
            [EnumMember(Value = "Login")]
            Login = 2
        }

        /// <summary>
        /// PayPal landing page
        /// </summary>
        /// <value>PayPal landing page</value>
        [DataMember(Name="landing_page", EmitDefaultValue=false)]
        public LandingPageEnum? LandingPage { get; set; }
        /// <summary>
        /// The PayPal mode
        /// </summary>
        /// <value>The PayPal mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum WPPECO for value: WPPECO
            /// </summary>
            [EnumMember(Value = "WPPECO")]
            WPPECO = 1,
            
            /// <summary>
            /// Enum WPPECDP for value: WPPECDP
            /// </summary>
            [EnumMember(Value = "WPPECDP")]
            WPPECDP = 2
        }

        /// <summary>
        /// The PayPal mode
        /// </summary>
        /// <value>The PayPal mode</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// PayPal solution type
        /// </summary>
        /// <value>PayPal solution type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SolutionTypeEnum
        {
            
            /// <summary>
            /// Enum Sole for value: Sole
            /// </summary>
            [EnumMember(Value = "Sole")]
            Sole = 1,
            
            /// <summary>
            /// Enum Mark for value: Mark
            /// </summary>
            [EnumMember(Value = "Mark")]
            Mark = 2
        }

        /// <summary>
        /// PayPal solution type
        /// </summary>
        /// <value>PayPal solution type</value>
        [DataMember(Name="solution_type", EmitDefaultValue=false)]
        public SolutionTypeEnum? SolutionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsConfigurationPayPal" /> class.
        /// </summary>
        /// <param name="acceptPaypal">Master flag that determine if PayPal is an active payment for this account.</param>
        /// <param name="accountingCode">Optional accounting code that is set to Quickbooks when an order uses this payment method..</param>
        /// <param name="apiPassword">PayPal API password.</param>
        /// <param name="apiUsername">PayPal API username.</param>
        /// <param name="certificateOnFile">(Legacy) true if there is a PayPal certificate already on file. Used to manage the internal UI.</param>
        /// <param name="depositToAccount">The account to deposit funds.</param>
        /// <param name="email">The main PayPal email address.</param>
        /// <param name="environment">PayPal configuration, live or sandbox.</param>
        /// <param name="headerImageUrl">The URL for the PayPal header.</param>
        /// <param name="hideBillMeLater">True if the Bill Me Later button should be hidden during checkout.</param>
        /// <param name="hideExpressCheckoutOnViewCart">True if the PayPal express checkout button should be hidden on the view cart page.  This will force the customer to enter address information before being able to checkout with PayPal.</param>
        /// <param name="hideForUnshippedOrders">True if PayPal should be hidden for orders with no shippable product, such as digital orders.</param>
        /// <param name="holdInAr">If true, PayPal orders are held in Accounts Receivable for review.</param>
        /// <param name="landingPage">PayPal landing page.</param>
        /// <param name="mode">The PayPal mode.</param>
        /// <param name="privateKeyPassword">PayPal API private key password.</param>
        /// <param name="processingFee">Optional additional fee to charge if PayPal is used.  It is rare for this to be used..</param>
        /// <param name="processingPercentage">The processing percentage charged by PayPal.</param>
        /// <param name="pushPaypal">True if the internal UI should recommend opening a PayPal account.</param>
        /// <param name="restrictions">restrictions.</param>
        /// <param name="sendRecurring">True if UltraCart should send recurring orders to PayPal.  There are restrictions to what PayPal will accept for recurring orders.  Be careful..</param>
        /// <param name="shortPaypalMarketingText">Short marketing text.</param>
        /// <param name="showCardLogosNotDirectlySupported">internal ui flag.</param>
        /// <param name="showSignature">Internal flag used to manage UI.</param>
        /// <param name="signature">PayPal signature.</param>
        /// <param name="solutionType">PayPal solution type.</param>
        /// <param name="summaryEmail">The email where PayPal summaries should be sent.</param>
        /// <param name="summaryMode">Description of what mode PayPal is operating.</param>
        /// <param name="zeroDollarPenny">Send free items to PayPal as one cent items and subtract this penny from shipping.  PayPal does not allow the sale of free items..</param>
        public PaymentsConfigurationPayPal(bool? acceptPaypal = default(bool?), string accountingCode = default(string), string apiPassword = default(string), string apiUsername = default(string), bool? certificateOnFile = default(bool?), string depositToAccount = default(string), string email = default(string), EnvironmentEnum? environment = default(EnvironmentEnum?), string headerImageUrl = default(string), bool? hideBillMeLater = default(bool?), bool? hideExpressCheckoutOnViewCart = default(bool?), bool? hideForUnshippedOrders = default(bool?), bool? holdInAr = default(bool?), LandingPageEnum? landingPage = default(LandingPageEnum?), ModeEnum? mode = default(ModeEnum?), string privateKeyPassword = default(string), string processingFee = default(string), string processingPercentage = default(string), bool? pushPaypal = default(bool?), PaymentsConfigurationRestrictions restrictions = default(PaymentsConfigurationRestrictions), bool? sendRecurring = default(bool?), bool? shortPaypalMarketingText = default(bool?), bool? showCardLogosNotDirectlySupported = default(bool?), bool? showSignature = default(bool?), string signature = default(string), SolutionTypeEnum? solutionType = default(SolutionTypeEnum?), string summaryEmail = default(string), string summaryMode = default(string), bool? zeroDollarPenny = default(bool?))
        {
            this.AcceptPaypal = acceptPaypal;
            this.AccountingCode = accountingCode;
            this.ApiPassword = apiPassword;
            this.ApiUsername = apiUsername;
            this.CertificateOnFile = certificateOnFile;
            this.DepositToAccount = depositToAccount;
            this.Email = email;
            this.Environment = environment;
            this.HeaderImageUrl = headerImageUrl;
            this.HideBillMeLater = hideBillMeLater;
            this.HideExpressCheckoutOnViewCart = hideExpressCheckoutOnViewCart;
            this.HideForUnshippedOrders = hideForUnshippedOrders;
            this.HoldInAr = holdInAr;
            this.LandingPage = landingPage;
            this.Mode = mode;
            this.PrivateKeyPassword = privateKeyPassword;
            this.ProcessingFee = processingFee;
            this.ProcessingPercentage = processingPercentage;
            this.PushPaypal = pushPaypal;
            this.Restrictions = restrictions;
            this.SendRecurring = sendRecurring;
            this.ShortPaypalMarketingText = shortPaypalMarketingText;
            this.ShowCardLogosNotDirectlySupported = showCardLogosNotDirectlySupported;
            this.ShowSignature = showSignature;
            this.Signature = signature;
            this.SolutionType = solutionType;
            this.SummaryEmail = summaryEmail;
            this.SummaryMode = summaryMode;
            this.ZeroDollarPenny = zeroDollarPenny;
        }
        
        /// <summary>
        /// Master flag that determine if PayPal is an active payment for this account
        /// </summary>
        /// <value>Master flag that determine if PayPal is an active payment for this account</value>
        [DataMember(Name="accept_paypal", EmitDefaultValue=false)]
        public bool? AcceptPaypal { get; set; }

        /// <summary>
        /// Optional accounting code that is set to Quickbooks when an order uses this payment method.
        /// </summary>
        /// <value>Optional accounting code that is set to Quickbooks when an order uses this payment method.</value>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// PayPal API password
        /// </summary>
        /// <value>PayPal API password</value>
        [DataMember(Name="api_password", EmitDefaultValue=false)]
        public string ApiPassword { get; set; }

        /// <summary>
        /// PayPal API username
        /// </summary>
        /// <value>PayPal API username</value>
        [DataMember(Name="api_username", EmitDefaultValue=false)]
        public string ApiUsername { get; set; }

        /// <summary>
        /// (Legacy) true if there is a PayPal certificate already on file. Used to manage the internal UI
        /// </summary>
        /// <value>(Legacy) true if there is a PayPal certificate already on file. Used to manage the internal UI</value>
        [DataMember(Name="certificate_on_file", EmitDefaultValue=false)]
        public bool? CertificateOnFile { get; set; }

        /// <summary>
        /// The account to deposit funds
        /// </summary>
        /// <value>The account to deposit funds</value>
        [DataMember(Name="deposit_to_account", EmitDefaultValue=false)]
        public string DepositToAccount { get; set; }

        /// <summary>
        /// The main PayPal email address
        /// </summary>
        /// <value>The main PayPal email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// The URL for the PayPal header
        /// </summary>
        /// <value>The URL for the PayPal header</value>
        [DataMember(Name="header_image_url", EmitDefaultValue=false)]
        public string HeaderImageUrl { get; set; }

        /// <summary>
        /// True if the Bill Me Later button should be hidden during checkout
        /// </summary>
        /// <value>True if the Bill Me Later button should be hidden during checkout</value>
        [DataMember(Name="hide_bill_me_later", EmitDefaultValue=false)]
        public bool? HideBillMeLater { get; set; }

        /// <summary>
        /// True if the PayPal express checkout button should be hidden on the view cart page.  This will force the customer to enter address information before being able to checkout with PayPal
        /// </summary>
        /// <value>True if the PayPal express checkout button should be hidden on the view cart page.  This will force the customer to enter address information before being able to checkout with PayPal</value>
        [DataMember(Name="hide_express_checkout_on_view_cart", EmitDefaultValue=false)]
        public bool? HideExpressCheckoutOnViewCart { get; set; }

        /// <summary>
        /// True if PayPal should be hidden for orders with no shippable product, such as digital orders
        /// </summary>
        /// <value>True if PayPal should be hidden for orders with no shippable product, such as digital orders</value>
        [DataMember(Name="hide_for_unshipped_orders", EmitDefaultValue=false)]
        public bool? HideForUnshippedOrders { get; set; }

        /// <summary>
        /// If true, PayPal orders are held in Accounts Receivable for review
        /// </summary>
        /// <value>If true, PayPal orders are held in Accounts Receivable for review</value>
        [DataMember(Name="hold_in_ar", EmitDefaultValue=false)]
        public bool? HoldInAr { get; set; }



        /// <summary>
        /// PayPal API private key password
        /// </summary>
        /// <value>PayPal API private key password</value>
        [DataMember(Name="private_key_password", EmitDefaultValue=false)]
        public string PrivateKeyPassword { get; set; }

        /// <summary>
        /// Optional additional fee to charge if PayPal is used.  It is rare for this to be used.
        /// </summary>
        /// <value>Optional additional fee to charge if PayPal is used.  It is rare for this to be used.</value>
        [DataMember(Name="processing_fee", EmitDefaultValue=false)]
        public string ProcessingFee { get; set; }

        /// <summary>
        /// The processing percentage charged by PayPal
        /// </summary>
        /// <value>The processing percentage charged by PayPal</value>
        [DataMember(Name="processing_percentage", EmitDefaultValue=false)]
        public string ProcessingPercentage { get; set; }

        /// <summary>
        /// True if the internal UI should recommend opening a PayPal account
        /// </summary>
        /// <value>True if the internal UI should recommend opening a PayPal account</value>
        [DataMember(Name="push_paypal", EmitDefaultValue=false)]
        public bool? PushPaypal { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name="restrictions", EmitDefaultValue=false)]
        public PaymentsConfigurationRestrictions Restrictions { get; set; }

        /// <summary>
        /// True if UltraCart should send recurring orders to PayPal.  There are restrictions to what PayPal will accept for recurring orders.  Be careful.
        /// </summary>
        /// <value>True if UltraCart should send recurring orders to PayPal.  There are restrictions to what PayPal will accept for recurring orders.  Be careful.</value>
        [DataMember(Name="send_recurring", EmitDefaultValue=false)]
        public bool? SendRecurring { get; set; }

        /// <summary>
        /// Short marketing text
        /// </summary>
        /// <value>Short marketing text</value>
        [DataMember(Name="short_paypal_marketing_text", EmitDefaultValue=false)]
        public bool? ShortPaypalMarketingText { get; set; }

        /// <summary>
        /// internal ui flag
        /// </summary>
        /// <value>internal ui flag</value>
        [DataMember(Name="show_card_logos_not_directly_supported", EmitDefaultValue=false)]
        public bool? ShowCardLogosNotDirectlySupported { get; set; }

        /// <summary>
        /// Internal flag used to manage UI
        /// </summary>
        /// <value>Internal flag used to manage UI</value>
        [DataMember(Name="show_signature", EmitDefaultValue=false)]
        public bool? ShowSignature { get; set; }

        /// <summary>
        /// PayPal signature
        /// </summary>
        /// <value>PayPal signature</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }


        /// <summary>
        /// The email where PayPal summaries should be sent
        /// </summary>
        /// <value>The email where PayPal summaries should be sent</value>
        [DataMember(Name="summary_email", EmitDefaultValue=false)]
        public string SummaryEmail { get; set; }

        /// <summary>
        /// Description of what mode PayPal is operating
        /// </summary>
        /// <value>Description of what mode PayPal is operating</value>
        [DataMember(Name="summary_mode", EmitDefaultValue=false)]
        public string SummaryMode { get; set; }

        /// <summary>
        /// Send free items to PayPal as one cent items and subtract this penny from shipping.  PayPal does not allow the sale of free items.
        /// </summary>
        /// <value>Send free items to PayPal as one cent items and subtract this penny from shipping.  PayPal does not allow the sale of free items.</value>
        [DataMember(Name="zero_dollar_penny", EmitDefaultValue=false)]
        public bool? ZeroDollarPenny { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsConfigurationPayPal {\n");
            sb.Append("  AcceptPaypal: ").Append(AcceptPaypal).Append("\n");
            sb.Append("  AccountingCode: ").Append(AccountingCode).Append("\n");
            sb.Append("  ApiPassword: ").Append(ApiPassword).Append("\n");
            sb.Append("  ApiUsername: ").Append(ApiUsername).Append("\n");
            sb.Append("  CertificateOnFile: ").Append(CertificateOnFile).Append("\n");
            sb.Append("  DepositToAccount: ").Append(DepositToAccount).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  HeaderImageUrl: ").Append(HeaderImageUrl).Append("\n");
            sb.Append("  HideBillMeLater: ").Append(HideBillMeLater).Append("\n");
            sb.Append("  HideExpressCheckoutOnViewCart: ").Append(HideExpressCheckoutOnViewCart).Append("\n");
            sb.Append("  HideForUnshippedOrders: ").Append(HideForUnshippedOrders).Append("\n");
            sb.Append("  HoldInAr: ").Append(HoldInAr).Append("\n");
            sb.Append("  LandingPage: ").Append(LandingPage).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  PrivateKeyPassword: ").Append(PrivateKeyPassword).Append("\n");
            sb.Append("  ProcessingFee: ").Append(ProcessingFee).Append("\n");
            sb.Append("  ProcessingPercentage: ").Append(ProcessingPercentage).Append("\n");
            sb.Append("  PushPaypal: ").Append(PushPaypal).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  SendRecurring: ").Append(SendRecurring).Append("\n");
            sb.Append("  ShortPaypalMarketingText: ").Append(ShortPaypalMarketingText).Append("\n");
            sb.Append("  ShowCardLogosNotDirectlySupported: ").Append(ShowCardLogosNotDirectlySupported).Append("\n");
            sb.Append("  ShowSignature: ").Append(ShowSignature).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SolutionType: ").Append(SolutionType).Append("\n");
            sb.Append("  SummaryEmail: ").Append(SummaryEmail).Append("\n");
            sb.Append("  SummaryMode: ").Append(SummaryMode).Append("\n");
            sb.Append("  ZeroDollarPenny: ").Append(ZeroDollarPenny).Append("\n");
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
            return this.Equals(input as PaymentsConfigurationPayPal);
        }

        /// <summary>
        /// Returns true if PaymentsConfigurationPayPal instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentsConfigurationPayPal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsConfigurationPayPal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptPaypal == input.AcceptPaypal ||
                    (this.AcceptPaypal != null &&
                    this.AcceptPaypal.Equals(input.AcceptPaypal))
                ) && 
                (
                    this.AccountingCode == input.AccountingCode ||
                    (this.AccountingCode != null &&
                    this.AccountingCode.Equals(input.AccountingCode))
                ) && 
                (
                    this.ApiPassword == input.ApiPassword ||
                    (this.ApiPassword != null &&
                    this.ApiPassword.Equals(input.ApiPassword))
                ) && 
                (
                    this.ApiUsername == input.ApiUsername ||
                    (this.ApiUsername != null &&
                    this.ApiUsername.Equals(input.ApiUsername))
                ) && 
                (
                    this.CertificateOnFile == input.CertificateOnFile ||
                    (this.CertificateOnFile != null &&
                    this.CertificateOnFile.Equals(input.CertificateOnFile))
                ) && 
                (
                    this.DepositToAccount == input.DepositToAccount ||
                    (this.DepositToAccount != null &&
                    this.DepositToAccount.Equals(input.DepositToAccount))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.HeaderImageUrl == input.HeaderImageUrl ||
                    (this.HeaderImageUrl != null &&
                    this.HeaderImageUrl.Equals(input.HeaderImageUrl))
                ) && 
                (
                    this.HideBillMeLater == input.HideBillMeLater ||
                    (this.HideBillMeLater != null &&
                    this.HideBillMeLater.Equals(input.HideBillMeLater))
                ) && 
                (
                    this.HideExpressCheckoutOnViewCart == input.HideExpressCheckoutOnViewCart ||
                    (this.HideExpressCheckoutOnViewCart != null &&
                    this.HideExpressCheckoutOnViewCart.Equals(input.HideExpressCheckoutOnViewCart))
                ) && 
                (
                    this.HideForUnshippedOrders == input.HideForUnshippedOrders ||
                    (this.HideForUnshippedOrders != null &&
                    this.HideForUnshippedOrders.Equals(input.HideForUnshippedOrders))
                ) && 
                (
                    this.HoldInAr == input.HoldInAr ||
                    (this.HoldInAr != null &&
                    this.HoldInAr.Equals(input.HoldInAr))
                ) && 
                (
                    this.LandingPage == input.LandingPage ||
                    (this.LandingPage != null &&
                    this.LandingPage.Equals(input.LandingPage))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.PrivateKeyPassword == input.PrivateKeyPassword ||
                    (this.PrivateKeyPassword != null &&
                    this.PrivateKeyPassword.Equals(input.PrivateKeyPassword))
                ) && 
                (
                    this.ProcessingFee == input.ProcessingFee ||
                    (this.ProcessingFee != null &&
                    this.ProcessingFee.Equals(input.ProcessingFee))
                ) && 
                (
                    this.ProcessingPercentage == input.ProcessingPercentage ||
                    (this.ProcessingPercentage != null &&
                    this.ProcessingPercentage.Equals(input.ProcessingPercentage))
                ) && 
                (
                    this.PushPaypal == input.PushPaypal ||
                    (this.PushPaypal != null &&
                    this.PushPaypal.Equals(input.PushPaypal))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    (this.Restrictions != null &&
                    this.Restrictions.Equals(input.Restrictions))
                ) && 
                (
                    this.SendRecurring == input.SendRecurring ||
                    (this.SendRecurring != null &&
                    this.SendRecurring.Equals(input.SendRecurring))
                ) && 
                (
                    this.ShortPaypalMarketingText == input.ShortPaypalMarketingText ||
                    (this.ShortPaypalMarketingText != null &&
                    this.ShortPaypalMarketingText.Equals(input.ShortPaypalMarketingText))
                ) && 
                (
                    this.ShowCardLogosNotDirectlySupported == input.ShowCardLogosNotDirectlySupported ||
                    (this.ShowCardLogosNotDirectlySupported != null &&
                    this.ShowCardLogosNotDirectlySupported.Equals(input.ShowCardLogosNotDirectlySupported))
                ) && 
                (
                    this.ShowSignature == input.ShowSignature ||
                    (this.ShowSignature != null &&
                    this.ShowSignature.Equals(input.ShowSignature))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.SolutionType == input.SolutionType ||
                    (this.SolutionType != null &&
                    this.SolutionType.Equals(input.SolutionType))
                ) && 
                (
                    this.SummaryEmail == input.SummaryEmail ||
                    (this.SummaryEmail != null &&
                    this.SummaryEmail.Equals(input.SummaryEmail))
                ) && 
                (
                    this.SummaryMode == input.SummaryMode ||
                    (this.SummaryMode != null &&
                    this.SummaryMode.Equals(input.SummaryMode))
                ) && 
                (
                    this.ZeroDollarPenny == input.ZeroDollarPenny ||
                    (this.ZeroDollarPenny != null &&
                    this.ZeroDollarPenny.Equals(input.ZeroDollarPenny))
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
                if (this.AcceptPaypal != null)
                    hashCode = hashCode * 59 + this.AcceptPaypal.GetHashCode();
                if (this.AccountingCode != null)
                    hashCode = hashCode * 59 + this.AccountingCode.GetHashCode();
                if (this.ApiPassword != null)
                    hashCode = hashCode * 59 + this.ApiPassword.GetHashCode();
                if (this.ApiUsername != null)
                    hashCode = hashCode * 59 + this.ApiUsername.GetHashCode();
                if (this.CertificateOnFile != null)
                    hashCode = hashCode * 59 + this.CertificateOnFile.GetHashCode();
                if (this.DepositToAccount != null)
                    hashCode = hashCode * 59 + this.DepositToAccount.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.HeaderImageUrl != null)
                    hashCode = hashCode * 59 + this.HeaderImageUrl.GetHashCode();
                if (this.HideBillMeLater != null)
                    hashCode = hashCode * 59 + this.HideBillMeLater.GetHashCode();
                if (this.HideExpressCheckoutOnViewCart != null)
                    hashCode = hashCode * 59 + this.HideExpressCheckoutOnViewCart.GetHashCode();
                if (this.HideForUnshippedOrders != null)
                    hashCode = hashCode * 59 + this.HideForUnshippedOrders.GetHashCode();
                if (this.HoldInAr != null)
                    hashCode = hashCode * 59 + this.HoldInAr.GetHashCode();
                if (this.LandingPage != null)
                    hashCode = hashCode * 59 + this.LandingPage.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.PrivateKeyPassword != null)
                    hashCode = hashCode * 59 + this.PrivateKeyPassword.GetHashCode();
                if (this.ProcessingFee != null)
                    hashCode = hashCode * 59 + this.ProcessingFee.GetHashCode();
                if (this.ProcessingPercentage != null)
                    hashCode = hashCode * 59 + this.ProcessingPercentage.GetHashCode();
                if (this.PushPaypal != null)
                    hashCode = hashCode * 59 + this.PushPaypal.GetHashCode();
                if (this.Restrictions != null)
                    hashCode = hashCode * 59 + this.Restrictions.GetHashCode();
                if (this.SendRecurring != null)
                    hashCode = hashCode * 59 + this.SendRecurring.GetHashCode();
                if (this.ShortPaypalMarketingText != null)
                    hashCode = hashCode * 59 + this.ShortPaypalMarketingText.GetHashCode();
                if (this.ShowCardLogosNotDirectlySupported != null)
                    hashCode = hashCode * 59 + this.ShowCardLogosNotDirectlySupported.GetHashCode();
                if (this.ShowSignature != null)
                    hashCode = hashCode * 59 + this.ShowSignature.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.SolutionType != null)
                    hashCode = hashCode * 59 + this.SolutionType.GetHashCode();
                if (this.SummaryEmail != null)
                    hashCode = hashCode * 59 + this.SummaryEmail.GetHashCode();
                if (this.SummaryMode != null)
                    hashCode = hashCode * 59 + this.SummaryMode.GetHashCode();
                if (this.ZeroDollarPenny != null)
                    hashCode = hashCode * 59 + this.ZeroDollarPenny.GetHashCode();
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

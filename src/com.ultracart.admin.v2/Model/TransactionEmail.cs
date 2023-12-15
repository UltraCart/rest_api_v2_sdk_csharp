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
    /// TransactionEmail
    /// </summary>
    [DataContract]
    public partial class TransactionEmail :  IEquatable<TransactionEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionEmail" /> class.
        /// </summary>
        /// <param name="content">Actual template contents.</param>
        /// <param name="espDomainUuid">The uuid of the sending domain.</param>
        /// <param name="espFriendlyName">Friendly from that will appear in customer email clients..</param>
        /// <param name="espUser">The username of the sending email.  This is not the full email.  Only the username which is everything before the @ sign..</param>
        /// <param name="fileExists">An internal identifier used to aid in retrieving templates from the filesystem..</param>
        /// <param name="fileName">File name.</param>
        /// <param name="group">Group.</param>
        /// <param name="handlebarVariables">Handlebar Variables available for email template.</param>
        /// <param name="invalid">Invalid will be true if the template cannot compile.</param>
        /// <param name="lastModified">Last modified timestamp.</param>
        /// <param name="libraryItemOid">If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated..</param>
        /// <param name="options">Options that help govern how and when this template is used.</param>
        /// <param name="path">directory path where template is stored in file system.</param>
        /// <param name="size">Size of file in friendly description.</param>
        /// <param name="storeFrontFsDirectoryOid">Internal identifier used to store and retrieve template from filesystem.</param>
        /// <param name="storeFrontFsFileOid">Internal identifier used to store and retrieve template from filesystem.</param>
        /// <param name="subject">Subject.</param>
        /// <param name="syntaxErrors">Any syntax errors contained within the tempalate.</param>
        /// <param name="templatePathRelativePath">Internal value used to locate the template in the filesystem.</param>
        /// <param name="themeRelativePath">Theme relative path in the filesystem..</param>
        public TransactionEmail(string content = default(string), string espDomainUuid = default(string), string espFriendlyName = default(string), string espUser = default(string), bool? fileExists = default(bool?), string fileName = default(string), string group = default(string), List<string> handlebarVariables = default(List<string>), bool? invalid = default(bool?), string lastModified = default(string), int? libraryItemOid = default(int?), List<TransactionEmailOption> options = default(List<TransactionEmailOption>), string path = default(string), string size = default(string), int? storeFrontFsDirectoryOid = default(int?), int? storeFrontFsFileOid = default(int?), string subject = default(string), string syntaxErrors = default(string), string templatePathRelativePath = default(string), string themeRelativePath = default(string))
        {
            this.Content = content;
            this.EspDomainUuid = espDomainUuid;
            this.EspFriendlyName = espFriendlyName;
            this.EspUser = espUser;
            this.FileExists = fileExists;
            this.FileName = fileName;
            this.Group = group;
            this.HandlebarVariables = handlebarVariables;
            this.Invalid = invalid;
            this.LastModified = lastModified;
            this.LibraryItemOid = libraryItemOid;
            this.Options = options;
            this.Path = path;
            this.Size = size;
            this.StoreFrontFsDirectoryOid = storeFrontFsDirectoryOid;
            this.StoreFrontFsFileOid = storeFrontFsFileOid;
            this.Subject = subject;
            this.SyntaxErrors = syntaxErrors;
            this.TemplatePathRelativePath = templatePathRelativePath;
            this.ThemeRelativePath = themeRelativePath;
        }
        
        /// <summary>
        /// Actual template contents
        /// </summary>
        /// <value>Actual template contents</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// The uuid of the sending domain
        /// </summary>
        /// <value>The uuid of the sending domain</value>
        [DataMember(Name="esp_domain_uuid", EmitDefaultValue=false)]
        public string EspDomainUuid { get; set; }

        /// <summary>
        /// Friendly from that will appear in customer email clients.
        /// </summary>
        /// <value>Friendly from that will appear in customer email clients.</value>
        [DataMember(Name="esp_friendly_name", EmitDefaultValue=false)]
        public string EspFriendlyName { get; set; }

        /// <summary>
        /// The username of the sending email.  This is not the full email.  Only the username which is everything before the @ sign.
        /// </summary>
        /// <value>The username of the sending email.  This is not the full email.  Only the username which is everything before the @ sign.</value>
        [DataMember(Name="esp_user", EmitDefaultValue=false)]
        public string EspUser { get; set; }

        /// <summary>
        /// An internal identifier used to aid in retrieving templates from the filesystem.
        /// </summary>
        /// <value>An internal identifier used to aid in retrieving templates from the filesystem.</value>
        [DataMember(Name="file_exists", EmitDefaultValue=false)]
        public bool? FileExists { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        /// <value>File name</value>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Group
        /// </summary>
        /// <value>Group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Handlebar Variables available for email template
        /// </summary>
        /// <value>Handlebar Variables available for email template</value>
        [DataMember(Name="handlebar_variables", EmitDefaultValue=false)]
        public List<string> HandlebarVariables { get; set; }

        /// <summary>
        /// Invalid will be true if the template cannot compile
        /// </summary>
        /// <value>Invalid will be true if the template cannot compile</value>
        [DataMember(Name="invalid", EmitDefaultValue=false)]
        public bool? Invalid { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated.
        /// </summary>
        /// <value>If this item was ever added to the Code Library, this is the oid for that library item, or 0 if never added before.  This value is used to determine if a library item should be inserted or updated.</value>
        [DataMember(Name="library_item_oid", EmitDefaultValue=false)]
        public int? LibraryItemOid { get; set; }

        /// <summary>
        /// Options that help govern how and when this template is used
        /// </summary>
        /// <value>Options that help govern how and when this template is used</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<TransactionEmailOption> Options { get; set; }

        /// <summary>
        /// directory path where template is stored in file system
        /// </summary>
        /// <value>directory path where template is stored in file system</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Size of file in friendly description
        /// </summary>
        /// <value>Size of file in friendly description</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// Internal identifier used to store and retrieve template from filesystem
        /// </summary>
        /// <value>Internal identifier used to store and retrieve template from filesystem</value>
        [DataMember(Name="store_front_fs_directory_oid", EmitDefaultValue=false)]
        public int? StoreFrontFsDirectoryOid { get; set; }

        /// <summary>
        /// Internal identifier used to store and retrieve template from filesystem
        /// </summary>
        /// <value>Internal identifier used to store and retrieve template from filesystem</value>
        [DataMember(Name="store_front_fs_file_oid", EmitDefaultValue=false)]
        public int? StoreFrontFsFileOid { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        /// <value>Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Any syntax errors contained within the tempalate
        /// </summary>
        /// <value>Any syntax errors contained within the tempalate</value>
        [DataMember(Name="syntax_errors", EmitDefaultValue=false)]
        public string SyntaxErrors { get; set; }

        /// <summary>
        /// Internal value used to locate the template in the filesystem
        /// </summary>
        /// <value>Internal value used to locate the template in the filesystem</value>
        [DataMember(Name="template_path_relative_path", EmitDefaultValue=false)]
        public string TemplatePathRelativePath { get; set; }

        /// <summary>
        /// Theme relative path in the filesystem.
        /// </summary>
        /// <value>Theme relative path in the filesystem.</value>
        [DataMember(Name="theme_relative_path", EmitDefaultValue=false)]
        public string ThemeRelativePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionEmail {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  EspDomainUuid: ").Append(EspDomainUuid).Append("\n");
            sb.Append("  EspFriendlyName: ").Append(EspFriendlyName).Append("\n");
            sb.Append("  EspUser: ").Append(EspUser).Append("\n");
            sb.Append("  FileExists: ").Append(FileExists).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  HandlebarVariables: ").Append(HandlebarVariables).Append("\n");
            sb.Append("  Invalid: ").Append(Invalid).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LibraryItemOid: ").Append(LibraryItemOid).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StoreFrontFsDirectoryOid: ").Append(StoreFrontFsDirectoryOid).Append("\n");
            sb.Append("  StoreFrontFsFileOid: ").Append(StoreFrontFsFileOid).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SyntaxErrors: ").Append(SyntaxErrors).Append("\n");
            sb.Append("  TemplatePathRelativePath: ").Append(TemplatePathRelativePath).Append("\n");
            sb.Append("  ThemeRelativePath: ").Append(ThemeRelativePath).Append("\n");
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
            return this.Equals(input as TransactionEmail);
        }

        /// <summary>
        /// Returns true if TransactionEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.EspDomainUuid == input.EspDomainUuid ||
                    (this.EspDomainUuid != null &&
                    this.EspDomainUuid.Equals(input.EspDomainUuid))
                ) && 
                (
                    this.EspFriendlyName == input.EspFriendlyName ||
                    (this.EspFriendlyName != null &&
                    this.EspFriendlyName.Equals(input.EspFriendlyName))
                ) && 
                (
                    this.EspUser == input.EspUser ||
                    (this.EspUser != null &&
                    this.EspUser.Equals(input.EspUser))
                ) && 
                (
                    this.FileExists == input.FileExists ||
                    (this.FileExists != null &&
                    this.FileExists.Equals(input.FileExists))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.HandlebarVariables == input.HandlebarVariables ||
                    this.HandlebarVariables != null &&
                    this.HandlebarVariables.SequenceEqual(input.HandlebarVariables)
                ) && 
                (
                    this.Invalid == input.Invalid ||
                    (this.Invalid != null &&
                    this.Invalid.Equals(input.Invalid))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LibraryItemOid == input.LibraryItemOid ||
                    (this.LibraryItemOid != null &&
                    this.LibraryItemOid.Equals(input.LibraryItemOid))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.StoreFrontFsDirectoryOid == input.StoreFrontFsDirectoryOid ||
                    (this.StoreFrontFsDirectoryOid != null &&
                    this.StoreFrontFsDirectoryOid.Equals(input.StoreFrontFsDirectoryOid))
                ) && 
                (
                    this.StoreFrontFsFileOid == input.StoreFrontFsFileOid ||
                    (this.StoreFrontFsFileOid != null &&
                    this.StoreFrontFsFileOid.Equals(input.StoreFrontFsFileOid))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.SyntaxErrors == input.SyntaxErrors ||
                    (this.SyntaxErrors != null &&
                    this.SyntaxErrors.Equals(input.SyntaxErrors))
                ) && 
                (
                    this.TemplatePathRelativePath == input.TemplatePathRelativePath ||
                    (this.TemplatePathRelativePath != null &&
                    this.TemplatePathRelativePath.Equals(input.TemplatePathRelativePath))
                ) && 
                (
                    this.ThemeRelativePath == input.ThemeRelativePath ||
                    (this.ThemeRelativePath != null &&
                    this.ThemeRelativePath.Equals(input.ThemeRelativePath))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.EspDomainUuid != null)
                    hashCode = hashCode * 59 + this.EspDomainUuid.GetHashCode();
                if (this.EspFriendlyName != null)
                    hashCode = hashCode * 59 + this.EspFriendlyName.GetHashCode();
                if (this.EspUser != null)
                    hashCode = hashCode * 59 + this.EspUser.GetHashCode();
                if (this.FileExists != null)
                    hashCode = hashCode * 59 + this.FileExists.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.HandlebarVariables != null)
                    hashCode = hashCode * 59 + this.HandlebarVariables.GetHashCode();
                if (this.Invalid != null)
                    hashCode = hashCode * 59 + this.Invalid.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LibraryItemOid != null)
                    hashCode = hashCode * 59 + this.LibraryItemOid.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.StoreFrontFsDirectoryOid != null)
                    hashCode = hashCode * 59 + this.StoreFrontFsDirectoryOid.GetHashCode();
                if (this.StoreFrontFsFileOid != null)
                    hashCode = hashCode * 59 + this.StoreFrontFsFileOid.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.SyntaxErrors != null)
                    hashCode = hashCode * 59 + this.SyntaxErrors.GetHashCode();
                if (this.TemplatePathRelativePath != null)
                    hashCode = hashCode * 59 + this.TemplatePathRelativePath.GetHashCode();
                if (this.ThemeRelativePath != null)
                    hashCode = hashCode * 59 + this.ThemeRelativePath.GetHashCode();
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

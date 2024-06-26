/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// GetCreditNotesResponse
    /// </summary>
    [DataContract]
    public partial class GetCreditNotesResponse :  IEquatable<GetCreditNotesResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="ProviderName", EmitDefaultValue=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeUTC
        /// </summary>
        [DataMember(Name="DateTimeUTC", EmitDefaultValue=false)]
        public string DateTimeUTC { get; set; }

        /// <summary>
        /// Gets or Sets PageInfo
        /// </summary>
        [DataMember(Name="PageInfo", EmitDefaultValue=false)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotes
        /// </summary>
        [DataMember(Name="CreditNotes", EmitDefaultValue=false)]
        public List<CreditNote> CreditNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCreditNotesResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  DateTimeUTC: ").Append(DateTimeUTC).Append("\n");
            sb.Append("  PageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append("\n");
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
            return this.Equals(input as GetCreditNotesResponse);
        }

        /// <summary>
        /// Returns true if GetCreditNotesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCreditNotesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCreditNotesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.DateTimeUTC == input.DateTimeUTC ||
                    (this.DateTimeUTC != null &&
                    this.DateTimeUTC.Equals(input.DateTimeUTC))
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
                ) && 
                (
                    this.CreditNotes == input.CreditNotes ||
                    this.CreditNotes != null &&
                    input.CreditNotes != null &&
                    this.CreditNotes.SequenceEqual(input.CreditNotes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.DateTimeUTC != null)
                    hashCode = hashCode * 59 + this.DateTimeUTC.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.CreditNotes != null)
                    hashCode = hashCode * 59 + this.CreditNotes.GetHashCode();
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

/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// EmployeeStatutoryLeaveSummary
    /// </summary>
    [DataContract]
    public partial class EmployeeStatutoryLeaveSummary :  IEquatable<EmployeeStatutoryLeaveSummary>, IValidatableObject
    {
        /// <summary>
        /// The category of statutory leave
        /// </summary>
        /// <value>The category of statutory leave</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sick for value: Sick
            /// </summary>
            [EnumMember(Value = "Sick")]
            Sick = 1,

            /// <summary>
            /// Enum Adoption for value: Adoption
            /// </summary>
            [EnumMember(Value = "Adoption")]
            Adoption = 2,

            /// <summary>
            /// Enum Maternity for value: Maternity
            /// </summary>
            [EnumMember(Value = "Maternity")]
            Maternity = 3,

            /// <summary>
            /// Enum Paternity for value: Paternity
            /// </summary>
            [EnumMember(Value = "Paternity")]
            Paternity = 4,

            /// <summary>
            /// Enum Sharedparental for value: Sharedparental
            /// </summary>
            [EnumMember(Value = "Sharedparental")]
            Sharedparental = 5,

            /// <summary>
            /// Enum Bereavement for value: Bereavement
            /// </summary>
            [EnumMember(Value = "Bereavement")]
            Bereavement = 6,

            /// <summary>
            /// Enum NeonatalCare for value: NeonatalCare
            /// </summary>
            [EnumMember(Value = "NeonatalCare")]
            NeonatalCare = 7

        }

        /// <summary>
        /// The category of statutory leave
        /// </summary>
        /// <value>The category of statutory leave</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The status of the leave
        /// </summary>
        /// <value>The status of the leave</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,

            /// <summary>
            /// Enum InProgress for value: In-Progress
            /// </summary>
            [EnumMember(Value = "In-Progress")]
            InProgress = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3

        }

        /// <summary>
        /// The status of the leave
        /// </summary>
        /// <value>The status of the leave</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// The unique identifier (guid) of a statutory leave.
        /// </summary>
        /// <value>The unique identifier (guid) of a statutory leave.</value>
        [DataMember(Name="statutoryLeaveID", EmitDefaultValue=false)]
        public Guid? StatutoryLeaveID { get; set; }

        /// <summary>
        /// The unique identifier (guid) of the employee
        /// </summary>
        /// <value>The unique identifier (guid) of the employee</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// The date when the leave starts
        /// </summary>
        /// <value>The date when the leave starts</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date when the leave ends
        /// </summary>
        /// <value>The date when the leave ends</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether the leave was entitled to receive payment
        /// </summary>
        /// <value>Whether the leave was entitled to receive payment</value>
        [DataMember(Name="isEntitled", EmitDefaultValue=false)]
        public bool? IsEntitled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeStatutoryLeaveSummary {\n");
            sb.Append("  StatutoryLeaveID: ").Append(StatutoryLeaveID).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IsEntitled: ").Append(IsEntitled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as EmployeeStatutoryLeaveSummary);
        }

        /// <summary>
        /// Returns true if EmployeeStatutoryLeaveSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeStatutoryLeaveSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeStatutoryLeaveSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatutoryLeaveID == input.StatutoryLeaveID ||
                    (this.StatutoryLeaveID != null &&
                    this.StatutoryLeaveID.Equals(input.StatutoryLeaveID))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IsEntitled == input.IsEntitled ||
                    (this.IsEntitled != null &&
                    this.IsEntitled.Equals(input.IsEntitled))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.StatutoryLeaveID != null)
                    hashCode = hashCode * 59 + this.StatutoryLeaveID.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.IsEntitled != null)
                    hashCode = hashCode * 59 + this.IsEntitled.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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

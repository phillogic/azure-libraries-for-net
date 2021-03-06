// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateVisibility.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateVisibility
    {
        /// <summary>
        /// The certificate should be visible to the user account under which
        /// the start task is run. Note that if AutoUser Scope is Pool for both
        /// the StartTask and a Task, this certificate will be visible to the
        /// Task as well.
        /// </summary>
        [EnumMember(Value = "StartTask")]
        StartTask,
        /// <summary>
        /// The certificate should be visible to the user accounts under which
        /// job tasks are run.
        /// </summary>
        [EnumMember(Value = "Task")]
        Task,
        /// <summary>
        /// The certificate should be visible to the user accounts under which
        /// users remotely access the node.
        /// </summary>
        [EnumMember(Value = "RemoteUser")]
        RemoteUser
    }
    internal static class CertificateVisibilityEnumExtension
    {
        internal static string ToSerializedValue(this CertificateVisibility? value)
        {
            return value == null ? null : ((CertificateVisibility)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CertificateVisibility value)
        {
            switch( value )
            {
                case CertificateVisibility.StartTask:
                    return "StartTask";
                case CertificateVisibility.Task:
                    return "Task";
                case CertificateVisibility.RemoteUser:
                    return "RemoteUser";
            }
            return null;
        }

        internal static CertificateVisibility? ParseCertificateVisibility(this string value)
        {
            switch( value )
            {
                case "StartTask":
                    return CertificateVisibility.StartTask;
                case "Task":
                    return CertificateVisibility.Task;
                case "RemoteUser":
                    return CertificateVisibility.RemoteUser;
            }
            return null;
        }
    }
}

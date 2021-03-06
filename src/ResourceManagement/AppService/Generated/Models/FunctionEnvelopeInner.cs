// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Function information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FunctionEnvelopeInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the FunctionEnvelopeInner class.
        /// </summary>
        public FunctionEnvelopeInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionEnvelopeInner class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="functionAppId">Function App ID.</param>
        /// <param name="scriptRootPathHref">Script root path URI.</param>
        /// <param name="scriptHref">Script URI.</param>
        /// <param name="configHref">Config URI.</param>
        /// <param name="testDataHref">Test data URI.</param>
        /// <param name="secretsFileHref">Secrets file URI.</param>
        /// <param name="href">Function URI.</param>
        /// <param name="config">Config information.</param>
        /// <param name="files">File list.</param>
        /// <param name="testData">Test data used when testing via the Azure
        /// Portal.</param>
        /// <param name="invokeUrlTemplate">The invocation URL</param>
        /// <param name="language">The function language</param>
        /// <param name="isDisabled">Gets or sets a value indicating whether
        /// the function is disabled</param>
        public FunctionEnvelopeInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string functionAppId = default(string), string scriptRootPathHref = default(string), string scriptHref = default(string), string configHref = default(string), string testDataHref = default(string), string secretsFileHref = default(string), string href = default(string), object config = default(object), IDictionary<string, string> files = default(IDictionary<string, string>), string testData = default(string), string invokeUrlTemplate = default(string), string language = default(string), bool? isDisabled = default(bool?))
            : base(id, name, type, kind)
        {
            FunctionAppId = functionAppId;
            ScriptRootPathHref = scriptRootPathHref;
            ScriptHref = scriptHref;
            ConfigHref = configHref;
            TestDataHref = testDataHref;
            SecretsFileHref = secretsFileHref;
            Href = href;
            Config = config;
            Files = files;
            TestData = testData;
            InvokeUrlTemplate = invokeUrlTemplate;
            Language = language;
            IsDisabled = isDisabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets function App ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.function_app_id")]
        public string FunctionAppId { get; set; }

        /// <summary>
        /// Gets or sets script root path URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.script_root_path_href")]
        public string ScriptRootPathHref { get; set; }

        /// <summary>
        /// Gets or sets script URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.script_href")]
        public string ScriptHref { get; set; }

        /// <summary>
        /// Gets or sets config URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.config_href")]
        public string ConfigHref { get; set; }

        /// <summary>
        /// Gets or sets test data URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.test_data_href")]
        public string TestDataHref { get; set; }

        /// <summary>
        /// Gets or sets secrets file URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secrets_file_href")]
        public string SecretsFileHref { get; set; }

        /// <summary>
        /// Gets or sets function URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets config information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.config")]
        public object Config { get; set; }

        /// <summary>
        /// Gets or sets file list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.files")]
        public IDictionary<string, string> Files { get; set; }

        /// <summary>
        /// Gets or sets test data used when testing via the Azure Portal.
        /// </summary>
        [JsonProperty(PropertyName = "properties.test_data")]
        public string TestData { get; set; }

        /// <summary>
        /// Gets or sets the invocation URL
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoke_url_template")]
        public string InvokeUrlTemplate { get; set; }

        /// <summary>
        /// Gets or sets the function language
        /// </summary>
        [JsonProperty(PropertyName = "properties.language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the function is disabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDisabled")]
        public bool? IsDisabled { get; set; }

    }
}

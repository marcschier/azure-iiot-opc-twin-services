// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Services.Twin.v1.Models {
    using Microsoft.Azure.IIoT.OpcUa.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;

    /// <summary>
    /// Value read response model
    /// </summary>
    public class ValueReadResponseApiModel {

        /// <summary>
        /// Default constructor
        /// </summary>
        ValueReadResponseApiModel() { }

        /// <summary>
        /// Create from service model
        /// </summary>
        /// <param name="model"></param>
        public ValueReadResponseApiModel(ValueReadResultModel model) {
            Value = model.Value;
            DataType = model.DataType;
            SourcePicoseconds = model.SourcePicoseconds;
            SourceTimestamp = model.SourceTimestamp;
            ServerPicoseconds = model.ServerPicoseconds;
            ServerTimestamp = model.ServerTimestamp;
            Diagnostics = model.Diagnostics;
        }

        /// <summary>
        /// Value read
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public JToken Value { get; set; }

        /// <summary>
        /// Built in data type of the value read.
        /// </summary>
        [JsonProperty(PropertyName = "dataType",
            NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// Pico seconds part of when value was read at source.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePicoseconds",
            NullValueHandling = NullValueHandling.Ignore)]
        public ushort? SourcePicoseconds { get; set; }

        /// <summary>
        /// Timestamp of when value was read at source.
        /// </summary>
        [JsonProperty(PropertyName = "sourceTimestamp",
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SourceTimestamp { get; set; }

        /// <summary>
        /// Pico seconds part of when value was read at server.
        /// </summary>
        [JsonProperty(PropertyName = "serverPicoseconds",
            NullValueHandling = NullValueHandling.Ignore)]
        public ushort? ServerPicoseconds { get; set; }

        /// <summary>
        /// Timestamp of when value was read at server.
        /// </summary>
        [JsonProperty(PropertyName = "serverTimestamp",
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ServerTimestamp { get; set; }

        /// <summary>
        /// Optional error diagnostics
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics",
            NullValueHandling = NullValueHandling.Ignore)]
        public JToken Diagnostics { get; set; }
    }
}

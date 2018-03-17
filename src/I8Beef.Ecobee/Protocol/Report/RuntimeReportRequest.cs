﻿using System;
using I8Beef.Ecobee.Protocol.Objects;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Report
{
    /// <summary>
    /// Ecobee API runtime report request.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RuntimeReportRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/runtimeReport"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(RuntimeReportResponse); } }

        /// <summary>
        /// The Selection Object. Must be selectionType = 'thermostats' and selectionMatch = a CSV of
        /// thermostat identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "selection", Required = Required.Always)]
        public Selection Selection { get; set; }

        /// <summary>
        /// The UTC report start date.
        /// </summary>
        [JsonProperty(PropertyName = "startDate", Required = Required.Always)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The 5 minute interval to begin the report on. The interval can be determined by multiplying the
        /// interval by 5. Range: 0-287 Default: 0
        /// </summary>
        [JsonProperty(PropertyName = "startInterval")]
        public int StartInterval { get; set; }

        /// <summary>
        /// The UTC report end date.
        /// </summary>
        [JsonProperty(PropertyName = "endDate", Required = Required.Always)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The 5 minute interval to end the report on. The interval can be determined by multiplying the
        /// interval by 5. Range: 0-287 Default: 287
        /// </summary>
        [JsonProperty(PropertyName = "endInterval")]
        public int EndInterval { get; set; }

        /// <summary>
        /// A CSV string of column names. See Report Columns. No spaces in CSV.
        /// </summary>
        [JsonProperty(PropertyName = "columns", Required = Required.Always)]
        public string Columns { get; set; }

        /// <summary>
        /// Whether to include sensor runtime report data for those thermostats which have it. Default: false.
        /// </summary>
        [JsonProperty(PropertyName = "includeSensors")]
        public bool IncludeSensors { get; set; }
    }
}

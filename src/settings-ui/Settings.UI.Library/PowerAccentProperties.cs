﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;
using ManagedCommon;
using Microsoft.PowerToys.Settings.UI.Library.Enumerations;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PowerAccentProperties
    {
        [JsonPropertyName("activation_key")]
        public PowerAccentActivationKey ActivationKey { get; set; }

        [JsonPropertyName("toolbar_position")]
        public StringProperty ToolbarPosition { get; set; }

        [JsonPropertyName("input_time_ms")]
        public IntProperty InputTime { get; set; }

        public PowerAccentProperties()
        {
            ActivationKey = PowerAccentActivationKey.Both;
            ToolbarPosition = "Top center";
            InputTime = new IntProperty(200);
        }
    }
}

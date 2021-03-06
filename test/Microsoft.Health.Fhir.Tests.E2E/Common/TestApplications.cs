﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Tests.E2E.Common
{
    public static class TestApplications
    {
        public static TestApplication ServiceClient { get; } = new TestApplication("serviceclient");

        public static TestApplication NativeClient { get; } = new TestApplication("nativeclient");
    }
}

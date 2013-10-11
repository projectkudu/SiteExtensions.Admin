﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using NuGet;

namespace SiteExtensions.Administration
{
    public static class PackageExtensions
    {
        public static string GetDisplayName(this IPackage package)
        {
            string name = String.IsNullOrEmpty(package.Title) ? package.Id : package.Title;
            return String.Concat(name, ' ', package.Version);
        }
    }
}

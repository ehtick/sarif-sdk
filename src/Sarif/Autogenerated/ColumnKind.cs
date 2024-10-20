// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CodeDom.Compiler;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A value that specifies the unit in which the tool measures columns.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "2.1.0.0")]
    public enum ColumnKind
    {
        None,
        Utf16CodeUnits,
        UnicodeCodePoints
    }
}

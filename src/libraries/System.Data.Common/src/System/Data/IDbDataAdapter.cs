// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Data
{
    public interface IDbDataAdapter : IDataAdapter
    {
        IDbCommand? SelectCommand { get; set; }
        IDbCommand? InsertCommand { get; set; }
        IDbCommand? UpdateCommand { get; set; }
        IDbCommand? DeleteCommand { get; set; }
    }
}

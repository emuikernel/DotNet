//------------------------------------------------------------------------------
// <copyright file="ITableMapping.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <owner current="true" primary="true">[....]</owner>
// <owner current="true" primary="false">[....]</owner>
//------------------------------------------------------------------------------

namespace System.Data {
    using System;

    public interface ITableMapping {

        IColumnMappingCollection ColumnMappings {
            get;
        }

        string DataSetTable {
            get;
            set;
        }

        string SourceTable {
            get;
            set;
        }
    }
}

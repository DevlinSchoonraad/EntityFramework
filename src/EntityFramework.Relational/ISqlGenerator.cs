﻿using System;
using System.Text;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Relational.Update;

namespace Microsoft.Data.Entity.Relational
{
    public interface ISqlGenerator
    {
        string BatchCommandSeparator { get; }
        string BatchSeparator { get; }

        string DelimitIdentifier([NotNull] string identifier);
        string DelimitIdentifier([NotNull] string tableName, [CanBeNull] string schemaName);
        string EscapeLiteral([NotNull] string literal);
        string GenerateLiteral([CanBeNull] object literal);
        string GenerateLiteral([NotNull] byte[] literal);
        string GenerateLiteral([NotNull] string literal);
        string GenerateLiteral(bool literal);
        string GenerateLiteral(char literal);
        string GenerateLiteral(DateTime literal);
        string GenerateLiteral(DateTimeOffset literal);
        string GenerateLiteral<T>([CanBeNull] T? literal) where T : struct;
        string GenerateNextSequenceValueOperation([NotNull] string sequenceName);
        void AppendBatchHeader([NotNull] StringBuilder commandStringBuilder);
        void AppendDeleteOperation([NotNull] StringBuilder commandStringBuilder, [NotNull] ModificationCommand command);
        void AppendInsertOperation([NotNull] StringBuilder commandStringBuilder, [NotNull] ModificationCommand command);
        void AppendUpdateOperation([NotNull] StringBuilder commandStringBuilder, [NotNull] ModificationCommand command);
    }
}

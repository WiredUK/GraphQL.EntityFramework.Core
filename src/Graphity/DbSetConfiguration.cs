﻿using System;
using System.Linq.Expressions;

namespace Graphity
{
    public class DbSetConfiguration : IDbSetConfiguration
    {
        private string _fieldName;
        private string _typeName;

        public Type Type { get; internal set; }

        public string TypeName
        {
            get => _typeName ?? $"{Type.Name}Type";
            internal set => _typeName = value;
        }

        public string FieldName
        {
            get => _fieldName ?? Type.Name;
            internal set => _fieldName = value;
        }

        public SetOption SetOption { get; internal set; }

        public Expression FilterExpression { get; internal set; }
    }
}
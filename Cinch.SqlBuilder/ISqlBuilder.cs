﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cinch.SqlBuilder
{
    public interface ISqlBuilder
    {
        string ToSql();
        
        ISqlBuilder Columns(string sql);
        ISqlBuilder Exists(ISqlBuilder sqlBuilder);
        ISqlBuilder Exists(string sql);
        ISqlBuilder From(string sql);
        ISqlBuilder From(ISqlBuilder sqlBuilder, string alias);
        ISqlBuilder GroupBy(string sql);
        ISqlBuilder Having(string sql);
        ISqlBuilder Insert(string sql);
        ISqlBuilder Join(string sql);
        ISqlBuilder LeftJoin(string sql);
        ISqlBuilder Select(string sql);
        ISqlBuilder Set(string sql);
        ISqlBuilder Update(string sql);
        ISqlBuilder Value(string sql);
        ISqlBuilder Values(string sql);
        ISqlBuilder Where(string sql);
        ISqlBuilder WhereOr(string sql);
    }
}

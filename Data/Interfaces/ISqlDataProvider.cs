using System;
using System.Data;
using System.Data.SqlClient;

namespace _3D.Test.App.Data.Interfaces
{
    public interface ISqlDataProvider
    {
        void ExecuteCmd(string storedProc, Action<SqlParameterCollection> inputParamMapper, Action<IDataReader, short> map, Action<SqlParameterCollection> returnParameters = null, Action<SqlCommand> cmdModifier = null);
        int ExecuteNonQuery(string storedProc, Action<SqlParameterCollection> paramMapper, Action<SqlParameterCollection> returnParameters = null);
    }
}
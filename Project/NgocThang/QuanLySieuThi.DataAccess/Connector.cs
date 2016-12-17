using QuanLySieuThi.DataModel;
using LibraryManager.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLySieuThi.DataAccess
{
    public class Connector
    {
        private readonly SqlConnection _connect;
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        public Connector(string sql)
        {
            _connect = new SqlConnection(ProjectConfig.ConnectionString);
            _dataTable = new DataTable();
            //var command = new SqlCommand(sql, _connect) {CommandType = CommandType.StoredProcedure};
            _adapter = new SqlDataAdapter(string.Format("select * from [{0}]", sql), _connect);
            var commandBuilder = new SqlCommandBuilder(_adapter);
            _adapter.InsertCommand = commandBuilder.GetInsertCommand();
            _adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            _adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }
        public DataTable getDataTable()
        {
            return _dataTable;
        }

        public string AutoGenerateId(string sql)
        {
            if (_connect.State == ConnectionState.Closed)
                _connect.Open();
            var command = new SqlCommand(sql, _connect);
            command.CommandType = CommandType.StoredProcedure;
            string id = "";
            try
            {
                id = (string)command.ExecuteScalar();
            }
            catch(Exception)
            {
                id = "NULL";
            }
            finally
            {
                _connect.Close();
            }
            return id;
        }

        //public string InsertGetId(string stproc, object info, string ignore)
        //{
        //    string id = "";
        //    if (_connect.State.Equals(ConnectionState.Closed))
        //        _connect.Open();

        //    var command = new SqlCommand(stproc, _connect) { CommandType = CommandType.StoredProcedure };
        //    var bind = BindingObject(info);
        //    for (var i = 0; i < bind.Names.Length; i++)
        //    {
        //        if (ignore != null && bind.Names[i] == ignore)
        //            continue;
        //        command.Parameters.AddWithValue(bind.Names[i], bind.Values[i]);
        //    }
        //    try
        //    {
        //        id = command.ExecuteScalar().ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        _connect.Close();
        //    }
        //    return id;
        //}

        public DataTable LoadData(string sql)
        {
            if (_connect.State == ConnectionState.Closed)
                _connect.Open();
            var command = new SqlCommand(sql, _connect);
            var adapter = new SqlDataAdapter(command);
            _dataTable.Clear();
            adapter.Fill(_dataTable);

            _connect.Close();
            return _dataTable.Copy();
        }

        public DataTable Search(string sql, string key)
        {
            if (_connect.State == ConnectionState.Closed)
                _connect.Open();
            var command = new SqlCommand(sql, _connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@key", key);
            var adapter = new SqlDataAdapter(command);
            _dataTable.Clear();
            adapter.Fill(_dataTable);
            _connect.Close();
            return _dataTable.Copy();
        }

        public bool Delete(string sql, string idName, string idValue)
        {
            if (_connect.State == ConnectionState.Closed)
                _connect.Open();
            var command = new SqlCommand(sql, _connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@"+ idName, idValue);
            try
            {
                command.ExecuteNonQuery();
                return true;
            }catch(Exception)
            {
                return false;
            }
            finally
            {
                _connect.Close();
            }
        }

        public DataTable LoadData(string sql, string[] names, object[] values, int parameters)
        {
            if (_connect.State.Equals(ConnectionState.Closed))
                _connect.Open();

            var command = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            for (var i = 0; i < parameters; i++)
                command.Parameters.AddWithValue(names[i], values[i]);
            var adapter = new SqlDataAdapter(command);
            var dt = new DataTable();
            try
            {
                adapter.Fill(dt);

            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                _connect.Close();
            }
            return dt;
        }

        //public DataTable getById(string sql, string idName,string id)
        //{
        //    DataTable result;
        //    if (_connect.State.Equals(ConnectionState.Closed))
        //        _connect.Open();
        //    var command = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
        //    command.Parameters.AddWithValue(idName, id);
        //    try
        //    {
        //        result = command.ExecuteScalar();
        //        _connect.Close();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        _connect.Close();
        //        return null;
        //    }
        //}

        public bool SaveChanges(DataTable dt)
        {
            bool result;
            if (_connect.State == ConnectionState.Closed)
                _connect.Open();
            try
            {
                _adapter.Update(dt);

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _connect.Close();
            }
            return result;
        }

        public bool Update(object info)
        {
            if (_connect.State.Equals(ConnectionState.Closed))
                _connect.Open();
            _dataTable.Clear();
            _dataTable.Rows.Add(Binding(info));

            bool result;
            try
            {
                _adapter.Update(_dataTable);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _connect.Close();
            }
            return result;
        }

        private static DataBinding BindingObject(object info)
        {
            var pros = info.GetType().GetProperties();
            var binding = new DataBinding(pros.Length);

            for (var i = 0; i < pros.Length; i++)
            {
                binding.Names[i] = "@" + pros[i].Name;
                binding.Values[i] = pros[i].GetValue(info, null);
            }
            return binding;
        }
        private static object[] Binding(object info)
        {
            var prop = info.GetType().GetProperties();
            return prop.Select(propertyInfo => propertyInfo.GetValue(info, null)).ToArray();
        }

        //public int Update(string sql)
        //{
        //    if (_connect.State.Equals(ConnectionState.Closed))
        //        _connect.Open();

        //    var command = new SqlCommand(sql, _connect) {CommandType = CommandType.StoredProcedure};
        //    var data = command.ExecuteNonQuery();
        //    _connect.Close();
        //    return data;
        //}


        public bool Update(string sql, object info)
        {
            if (_connect.State.Equals(ConnectionState.Closed))
                _connect.Open();

            var command = new SqlCommand(sql, _connect) { CommandType = CommandType.StoredProcedure };
            var bind = BindingObject(info);
            for (var i = 0; i < bind.Names.Length; i++)
            {
                command.Parameters.AddWithValue(bind.Names[i], bind.Values[i]);
            }
            try
            {
                command.ExecuteNonQuery();
                _connect.Close();
                return true;
            }
            catch (Exception)
            {
                _connect.Close();
                return false;
            }
        }
    }
}

﻿using System;
using System.Text;

namespace WindowsFormsApp2.shared.helper
{
    class SQLHelper
    {
        public static StringBuilder RemoveComma(StringBuilder query)
        {
            return query.Remove(query.Length - 2, 2);
        }

        public static string SelectQuery(string view)
        {
            return "SELECT * FROM " + view;
        }

        public static string InsertQuery(string table, string[] columns, string columnId = null, bool returnId = true)
        {
            StringBuilder query = new StringBuilder();
            query
                .Append("INSERT INTO ")
                .Append(table)
                .Append(" (");

            if(columnId != null)
                query.Append(columnId).Append(", ");
                
            foreach (string column in columns)
                query.Append(column).Append(", ");

            RemoveComma(query);

            query.Append(") VALUES (");

            if (columnId != null)
                query.Append("NULL").Append(", ");

            foreach (string column in columns)
                query.Append(":").Append(column).Append(", ");

            RemoveComma(query);

            query.Append(")");

            if (returnId)
                query.Append(" returning ").Append(columnId).Append(" into ").Append(":RETURNED_ID");

            return query.ToString();
        }

        public static string UpdateQuery(string table, string[] columns, string columnId)
        {
            StringBuilder query = new StringBuilder();
            query
                .Append("UPDATE ")
                .Append(table)
                .Append(" SET ");

            foreach (string column in columns)
                query.Append(column).Append(" = :").Append(column).Append(", ");

            RemoveComma(query);

            query.Append(" WHERE ");

 
            query.Append(columnId).Append(" = :").Append(columnId).Append(", ");

            RemoveComma(query);

            return query.ToString();
        }

        public static string DeleteQuery(string table, string deleteColumn, string columnId)
        {
            //string sql = "UPDATE " + table + " SET ACC_IS_DELETED = 1 WHERE ACC_ID = :id";
            StringBuilder query = new StringBuilder();
            query
                .Append("UPDATE ")
                .Append(table)
                .Append(" SET ")
                .Append(deleteColumn)
                .Append(" = 1 WHERE ");

            query.Append(columnId).Append(" = :").Append(columnId).Append(", ");

            RemoveComma(query);

            return query.ToString();
        }

        public static string SearchQuery(string view, string[] columns)
        {
            // string sql = "SELECT * FROM " + view + " WHERE ACC_LAST_NAME LIKE :query OR ACC_FIRST_NAME LIKE :query OR " +
            //"ACC_EMAIL LIKE :query OR ACC_TYPE LIKE :query";
            StringBuilder query = new StringBuilder();
            query
                .Append("SELECT * FROM ")
                .Append(view)
                .Append(" WHERE ");

            foreach (string column in columns)
                query.Append(column).Append(" LIKE :query OR ");

            query.Remove(query.Length - 3, 3);

            Console.WriteLine(query.ToString());
            return query.ToString();
        }
    }
}

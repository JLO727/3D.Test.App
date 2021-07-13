using _3D.Test.App.Data.Interfaces;
using _3D.Test.App.Data.Models.Requests;
using _3D.Test.App.Data.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;
namespace _3D.Test.App.Data.Services
{
    public class MessageService : IMessageService
    {
        private ISqlDataProvider _data;
        public MessageService(ISqlDataProvider data)
        {
            _data = data;
        }
        //connectionString is located in appsettings.json;

        // string profileName = "This is where you'll enter your dbmail profile name"
        string profileName = "3D_Test";

        public ActionResult<ItemResponse<int>> AddMessage(MessageAddRequest model)
        {
            int id = 0;
            BaseResponse response;
            try
            {
                string procName = "[dbo].[Messages_Insert]";
                _data.ExecuteNonQuery(procName, paramMapper: delegate (SqlParameterCollection col)
                {
                //Due to lack of Auth, User Id is a Mock parameter
                int userId = 12;

                    col.AddWithValue("@ProfileName", profileName);
                    commonParams(model, col, userId);

                    SqlParameter idOut = new SqlParameter("@Id", SqlDbType.Int);
                    idOut.Direction = ParameterDirection.Output;

                    col.Add(idOut);
                }, returnParameters: delegate (SqlParameterCollection returnCollection)
                {
                    object oId = returnCollection["@Id"].Value;

                    int.TryParse(oId.ToString(), out id);
                });
            }
            catch (Exception ex)
            {

                throw;
            }
            return id;
        }

        private static void commonParams(MessageAddRequest model, SqlParameterCollection col, int userId)
        {            
            col.AddWithValue("@Recipient", model.Recipient);
            col.AddWithValue("@Subject", model.Subject);
            col.AddWithValue("@Body", model.Body);
            col.AddWithValue("@CreatedBy", userId);
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Corporateqna.Models;
using Dapper;
using AutoMapper;

namespace Corporateqna.Services
{
    public class UserService
    {
        private readonly IDbConnection db;

        public UserService(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public IEnumerable<User> GetUsers()
        {

            return db.Query<DataModels.User>("SELECT * FROM User").MapAllTo<IEnumerable<DataModels.User>, User>();
        }
    }


    public static class MapToExtension
    {
        public static Destination MapTo<Source, Destination>(this Source data)
        {
            return Mapper.Map<Destination>(data);
        }
        public static IEnumerable<Destination> MapAllTo<Source, Destination>(this Source data)
        {

            return Mapper.Map<IEnumerable<Destination>>(data);
        }
    }
}

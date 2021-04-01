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
    public class AnswerService : IAnswerService
    {
        private readonly IDbConnection db;

        public AnswerService(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public IEnumerable<Answer> GetAnswers()
        {
            return db.Query<DataModels.Answer>("SELECT * FROM Answer").MapAllTo<IEnumerable<DataModels.Answer>, Answer>();
        }
    }
}

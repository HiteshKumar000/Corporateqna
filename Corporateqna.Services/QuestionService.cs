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
    public class QuestionService:IQuestionService
    {
        private readonly IDbConnection db;

        public QuestionService(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public IEnumerable<Question> GetQuestions()
        {

            return db.Query<DataModels.Question>("SELECT * FROM Question").MapAllTo<IEnumerable<DataModels.Question>, Question>();
        }

    }
}

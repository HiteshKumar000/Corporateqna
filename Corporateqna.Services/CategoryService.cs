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
    public class CategoryService : ICategoryService
    {
        private readonly IDbConnection db;

        public CategoryService(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public IEnumerable<Category> GetCategories()
        {
            return db.Query<DataModels.Category>("SELECT * FROM Category").MapAllTo<IEnumerable<DataModels.Category>, Category>();
        }
    }
}

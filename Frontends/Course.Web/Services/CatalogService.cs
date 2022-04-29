using Course.Web.Models;
using Course.Web.Models.Catalogs;
using Course.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Course.Web.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _httpClient;

        public CatalogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> DeleteCourseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetAllCourseAysnc()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetAllCourseByUserIdAysnc()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetByCourseIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryViewModel>> GettAllCategogoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            throw new NotImplementedException();
        }
    }
}

using Course.Web.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Services.Interfaces
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourseAysnc();
        Task<List<CategoryViewModel>> GettAllCategogoryAsync();
        Task<List<CourseViewModel>> GetAllCourseByUserIdAysnc(string userId);
        Task<List<CourseViewModel>> GetByCourseIdAsync(string courseId);
        Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput);
        Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput);
        Task<List<CourseViewModel>> DeleteCourseAsync(string courserId);
    }
}

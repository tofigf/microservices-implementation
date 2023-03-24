using AutoMapper;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;

namespace FreeCourse.Services.Catalog.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course,CourseDto>();
            CreateMap<Course,CourseCreateDto>();
            CreateMap<Course,CourseUpdateDto>();
            CreateMap<Category,CategoryDto>();
            CreateMap<Feature,FeatureDto>();
        }
    }
}

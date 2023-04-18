using AutoMapper;

namespace DDD_Template.Application.Mapping
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile mapper) => mapper.CreateMap(typeof(T), this.GetType());
    }
}

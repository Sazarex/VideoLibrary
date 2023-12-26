using Domain.Interfaces;
using WinFormsVideoLibrary.Dto;

namespace WinFormsVideoLibrary.Services
{
    public class EntityInfoService
    {
        public TDto LoadEntityInfoAsync<T, TDto> (int id) where T : class, IEntity
        {
            var entity = Program.UnitOfWork.GetRepositoryByType<T>().GetEntity(id);
            var result = Program.Mapper.Map<TDto>(entity);
            return result;
        }


        //public async Task<TDto> SaveEntityInfoAsync<T, TDto>(TDto dto) 
        //    where T : class, IEntity 
        //    where TDto: BaseEntityDto
        //{
        //    if (dto.Id != null)
        //    {
        //        var entity = Program.UnitOfWork.GetRepositoryByType<T>().GetEntity(dto.Id);
        //        var updatedEntity = await Task.Run(() => Program.Mapper.Map<TDto>(entity));
        //        return result;
        //    }
        //}
    }
}

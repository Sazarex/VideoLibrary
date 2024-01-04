using Domain;
using Domain.BaseTypes;
using Domain.Interfaces;

namespace UnitOfWork.Tests
{
    [Collection("Sequential")]
    public class UnitOfWorkAndRepoTests
    {
        UnitOfWorkNamespace.UnitOfWork uow = new UnitOfWorkNamespace.UnitOfWork();
        string nameOfNewProducer = "Никита Вейпович";


        [Fact]
        public void GetEntities()
        {
            var entity = uow.MovieRepository.GetEntity(1, e => e.Producer);

            var entity1 = uow.MovieRepository.GetEntity(1);

        }

        [Fact]
        public void CreateProducer()
        {
            var newProducer = new Producer()
            {
                Name = nameOfNewProducer
            };

            Assert.True(uow.ProducerRepository.CreateEntity(newProducer).Result);
        }

        [Fact]
        public void CreateGetDeleteCreatedProducer()
        {
            var entity = uow.ProducerRepository.GetEntity(p => p.Name == nameOfNewProducer);

            if (entity is IEntityState)
            {
                entity.EntityState = EntityState.Deleted;
                var entityStateOfDeleted = uow.ProducerRepository.GetEntity(entity.Id).EntityState;
                Assert.Equal(EntityState.Deleted, entityStateOfDeleted.GetValueOrDefault());
            }
            else
                Assert.True(uow.ProducerRepository.DeleteEntity(entity).Result);

            uow.Save();
        }

        [Fact]
        public async void UpdateMovie()
        {
            var entity = uow.MovieRepository.GetEntity(1);
            var oldDate = entity.UpdateDate.GetValueOrDefault();
            await uow.MovieRepository.CreateOrUpdate(entity);
            var newDate = entity.UpdateDate.GetValueOrDefault();


            Assert.True(oldDate < newDate);
        }
    }
}
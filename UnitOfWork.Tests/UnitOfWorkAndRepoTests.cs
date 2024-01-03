using Domain;
using Domain.BaseTypes;
using Domain.Interfaces;

namespace UnitOfWork.Tests
{
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
        public void GetAndDeleteCreatedProducer()
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
    }
}
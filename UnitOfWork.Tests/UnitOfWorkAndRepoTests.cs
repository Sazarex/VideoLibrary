using Domain;
using Domain.BaseTypes;

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
        public async void TryDeleteCreatedProducer()
        {
            var entity = uow.ProducerRepository.GetEntity(p => p.Name == nameOfNewProducer);

            var resultOfRemoving = await uow.ProducerRepository.DeleteEntity(entity);
            Assert.True(resultOfRemoving);
        }

        [Fact]
        public async void CheckEntityStateOfDeletedUser()
        {
            string nameOfNewUser = "Тестовый пользователь";
            var newUser = new User()
            {
                Name = nameOfNewUser
            };

            await uow.UserRepository.CreateEntity(newUser);
            await uow.UserRepository.DeleteEntity(newUser);

            Assert.Equal(EntityState.Deleted, newUser.EntityState.GetValueOrDefault());
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
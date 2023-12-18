using DataBase;
using Repo;

namespace UnitOfWorkNamespace
{
    /// <summary>
    /// Большой синглтон todo: поправить под многопоточность
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private DataBaseContext db = new DataBaseContext();

        #region Repositories
        private GenreRepository genreRepository;
        private MovieRepository movieRepository;
        private PaymentRepository paymentRepository;
        private ProducerRepository producerRepository;
        private SubscriptionRepository subscriptionRepository;
        private UserRepository userRepository;


        public GenreRepository GenreRepository
        {
            get
            {
                return genreRepository == null ? new GenreRepository(db) : genreRepository;
            }
        }

        public MovieRepository MovieRepository
        {
            get
            {
                return movieRepository == null ? new MovieRepository(db) : movieRepository;
            }
        }

        public PaymentRepository PaymentRepository
        {
            get
            {
                return paymentRepository == null ? new PaymentRepository(db) : paymentRepository;
            }
        }

        public ProducerRepository ProducerRepository
        {
            get
            {
                return producerRepository == null ? new ProducerRepository(db) : producerRepository;
            }
        }
        public SubscriptionRepository SubscriptionRepository
        {
            get
            {
                return subscriptionRepository == null ? new SubscriptionRepository(db) : subscriptionRepository;
            }
        }
        public UserRepository UserRepository
        {
            get
            {
                return userRepository == null ? new UserRepository(db) : userRepository;
            }
        } 
        #endregion


        public void Save()
        {
            db.SaveChanges();
        }

    }
}
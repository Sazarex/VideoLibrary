﻿using DataBase;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repo;

namespace UnitOfWorkNamespace
{
    /// <summary>
    /// Большой синглтон todo: поправить под многопоточность
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
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

        public Repository<T> GetRepositoryByType<T>() where T: class, IEntity
        {
            return new Repository<T>(db);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                db.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

    }
}
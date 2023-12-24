using AutoMapper;
using Domain;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.AutoMapperProfiles;
using WinFormsVideoLibrary.Dto;

namespace WinFormsVideoLibrary
{
    public static class Program
    {

        public static IMapper Mapper { get; private set; }

        public static UnitOfWork UnitOfWork { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Настройка AutoMapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            Mapper = mapperConfig.CreateMapper();
            UnitOfWork = new UnitOfWork();

            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());
        }
    }
}
using System.Linq;
using Abp.Application.Editions;
using ABP_Web_MVC.Editions;
using ABP_Web_MVC.EntityFramework;

namespace ABP_Web_MVC.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly ABP_Web_MVCDbContext _context;

        public DefaultEditionsCreator(ABP_Web_MVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}
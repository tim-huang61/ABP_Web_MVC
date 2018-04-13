using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using ABP_Web_MVC.EntityFramework;

namespace ABP_Web_MVC.Migrations.SeedData
{
    public class DefaultSettingsCreator
    {
        private readonly ABP_Web_MVCDbContext _context;

        public DefaultSettingsCreator(ABP_Web_MVCDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //Emailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "admin@mydomain.com");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "mydomain.com mailer");

            //Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "en");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
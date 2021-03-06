using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaOnline.web.Models;

namespace TiendaOnline.web.Data
{
    public class SeedDb
    {
        private readonly ApplicationDbContext _context;
        public SeedDb(ApplicationDbContext context) { _context = context; }
        public async Task SeedAsync() { await _context.Database.EnsureCreatedAsync(); await CheckCountriesAsync(); await CheckCategoriesAsync(); }
        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any()) { _context.Categories.Add(new Category { Name = "Tecnología" }); _context.Categories.Add(new Category { Name = "Ropa" }); _context.Categories.Add(new Category { Name = "Gamer" }); _context.Categories.Add(new Category { Name = "Belleza" }); _context.Categories.Add(new Category { Name = "Nutrición" }); }
            await _context.SaveChangesAsync();
        }
        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    Departments = new List<Department>() { new Department()

            { Name = "Antioquia", Cities = new List<City>() { new City() 
            { Name = "Medellín" }, new City() 
            { Name = "Itagüí" }, new City()
            { Name = "Envigado" }, new City() 
            { Name = "Bello" }, new City() 
            { Name = "Rionegro" }, } }, new Department() 
            { Name = "Bogotá", Cities = new List<City>() { new City() 
            { Name = "Usaquen" }, new City() 
            { Name = "Champinero" }, new City() 
            { Name = "Santa fe" }, new City() 
            { Name = "Useme" }, new City() 
            { Name = "Bosa" }, } }, }
                }); 
                
                _context.Countries.Add(new Country { Name = "Estados Unidos", Departments = new List<Department>()
                { new Department()
                { Name = "Florida", Cities = new List<City>() { new City() 
                { Name = "Orlando" }, new City()
                { Name = "Miami" }, new City() 
                { Name = "Tampa" }, new City()
                { Name = "Fort Lauderdale" }, new City() 
                { Name = "Key West" }, } }, new Department() 
                { Name = "Texas", Cities = new List<City>() { new City() 
                { Name = "Houston" }, new City()
                { Name = "San Antonio" }, new City() 
                { Name = "Dallas" }, new City() 
                { Name = "Austin" }, new City() 
                { Name = "El Paso" }, } }, } });
            }

            await _context.SaveChangesAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using MarcasAutosApi.Data; 
using MarcasAutosApi.Controllers; 
using System.Linq;
using MarcasAutosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAutosApi.Tests
{
    public class MarcasAutosControllerTests
    {
        private readonly MarcasAutosController _controller;
        private readonly AppDbContext _context;

        public MarcasAutosControllerTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase") 
                .Options;

            _context = new AppDbContext(options);
            _controller = new MarcasAutosController(_context);

            _context.MarcasAutos.Add(new MarcaAuto { Id = 1, Nombre = "Toyota" });
            _context.MarcasAutos.Add(new MarcaAuto { Id = 2, Nombre = "Ford" });
            _context.MarcasAutos.Add(new MarcaAuto { Id = 3, Nombre = "Honda" });
            _context.SaveChanges();
        }

        [Fact]
        public void GetMarcasAutos_ReturnsAllMarcas()
        {
            // Act
            var result = _controller.GetMarcasAutos();

            var actionResult = Assert.IsType<ActionResult<IEnumerable<MarcaAuto>>>(result);

            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            
            var marcas = Assert.IsType<List<MarcaAuto>>(okResult.Value);

            Assert.Equal(3, marcas.Count);
        }
    }
}
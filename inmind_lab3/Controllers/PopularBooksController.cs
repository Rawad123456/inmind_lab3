namespace inmind_lab3.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;
using inmind_lab3.Data;


public class PopularBooksController : ODataController
{
    private readonly LibraryDbContext _context;

    public PopularBooksController(LibraryDbContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Popularbooks);
    }
}

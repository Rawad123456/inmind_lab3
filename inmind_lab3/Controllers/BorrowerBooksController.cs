namespace inmind_lab3.Controllers;

using inmind_lab3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;



[Route("odata/Borrowers({borrowerId})/Books")]
public class BorrowerBooksController : ODataController
{
    private readonly LibraryDbContext _context;

    public BorrowerBooksController(LibraryDbContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet]
    public IActionResult GetBooksForBorrower(int borrowerId)
    {
        var books = _context.Loans
            .Where(l => l.BorrowerId == borrowerId && l.Book != null)
            .Select(l => l.Book);

        return Ok(books);
    }
}

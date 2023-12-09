using Kattholt.Data.Repository;
using Kattholt.Models;
using Microsoft.AspNetCore.Mvc;
namespace Kattholt.Controllers;




[ApiController]
[Route("/api/cats")]
public class CatsController : ControllerBase
{

    private CatRepository _repo;
    
    public CatsController()
    {
        _repo = new CatRepository();
    }
    
    // GET: api/cats
    [HttpGet]
    public async Task<ActionResult<List<Cat>>> GetCats()
    {

        return await _repo.GetAllCats();

    }
}
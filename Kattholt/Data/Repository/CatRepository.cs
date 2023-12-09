using Kattholt.Models;
using Microsoft.EntityFrameworkCore;

namespace Kattholt.Data.Repository;

public class CatRepository
{

    private KattholtContext _dbContext;

    public CatRepository()
    {
        _dbContext = new KattholtContext();
    }
    
    // CRUD
    
    
    // CRUD for Cats
    
    // Create cat
    public void CreateCat(Cat cat)
    {
        _dbContext.Cats.Add(cat);
    }
    
    // Read cat by ID
    public Cat GetCatById(int id)
    {
        Cat? cat = _dbContext.Cats.FirstOrDefault(x => x.Id == id);

        if (cat == null)
        {
            throw new Exception("Cat not found");
        }
        else
        {
            return cat;
        }
    }

    public async Task<List<Cat>> GetAllCats()
    {
        return await _dbContext.Cats.ToListAsync();
    }
    
    
    // Update cat
    public void UpdateCat(Cat UpdatedCat)
    {

        Cat CatToBeUpdated = _dbContext.Cats.FirstOrDefault(x => x.Id == UpdatedCat.Id);

        CatToBeUpdated.Name = UpdatedCat.Name;
        CatToBeUpdated.TrackingNumber = UpdatedCat.TrackingNumber;

        _dbContext.SaveChanges();


    }
    
    
    
    
    //Delete cat
    public void DeleteCat(int Id)
    {
        Cat cat = _dbContext.Cats.FirstOrDefault(x => x.Id == Id);

        _dbContext.Cats.Remove(cat);

        _dbContext.SaveChanges();

    }
    
}
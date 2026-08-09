using _3_July.Models;
namespace _3_July.Repositories

{
    public interface IBatchService
    {
        List<Batch> GetBatch();
    
    Batch UpdateBatch(int  id,Batch batch);
        bool DeleteBatch(int id);   
    
    
    
    
    
    
    }
}

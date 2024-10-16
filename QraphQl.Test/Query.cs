using Microsoft.EntityFrameworkCore;
using QraphQl.Test.Models;

namespace QraphQl.Test
{
    public class Query
    {
        private readonly Bookcontext _Context;
        public Query(Bookcontext Context)
        {
            _Context = Context;
        }

        public async Task<List<Books>> AllBooksAsync()
        {
            return await _Context.Book.ToListAsync(); 
        }
        public async Task<Books> byId(int id)
        {
            return  await _Context.Book.FirstOrDefaultAsync(x => x.Book_Id == id);
        }
    }
}

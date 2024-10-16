using QraphQl.Test.Models;

namespace QraphQl.Test
{
    public class Mutation
    {
        private readonly Bookcontext _Context;
        public Mutation(Bookcontext Context)
        {
            _Context = Context;
        }

        public async Task<Books> AddAsync(BookDto dto)
        {
            var book = new Books { Title = dto.Title, Author = dto.Author };
            await _Context.Book.AddAsync(book);
            await _Context.SaveChangesAsync();
            return book;
        }
    }
}

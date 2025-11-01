using Microsoft.AspNetCore.Mvc;
namespace BookSHOP.Models
{
    public class AddBasketDto
    {
        public int bookId {  get; set; }
        public int qty { get; set; }

    }
}

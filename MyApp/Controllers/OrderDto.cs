using MyApp.Models;

namespace MyApp.Controllers
{
    public class OrderDto
    {
        public object ToOrder()
        {
            return new Order();
        }
    }
}
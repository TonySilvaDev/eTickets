using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string uderId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUseridAsync(string userId);
    }
}

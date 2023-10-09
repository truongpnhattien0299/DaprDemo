using Dapr.Client;
using DaprDemo.ShoppingCart.Application.Features.Cart.AddToCart;
using DaprDemo.ShoppingCart.Application.Features.Cart.Checkout;
using DaprDemo.ShoppingCart.Application.Interfaces;

namespace DaprDemo.ShoppingCart.Infrastruture.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DaprClient _daprClient;
        private readonly ILogger<CartRepository> _logger;
        private const string StateStore = "statestore";
        private const string Pubsub = "kafka-pubsub";

        public CartRepository(
            DaprClient daprClient,
            ILogger<CartRepository> logger)
        {
            _daprClient = daprClient;
            _logger = logger;
        }

        public async Task<List<AddToCartCommand>> GetCart(string? userId)
        {
            var currentItem = _daprClient.GetStateAsync<List<AddToCartCommand>>(StateStore, userId);
            return await currentItem;
        }
        // public async Task<AddToCartCommand> AddProductToCart(AddToCartCommand command)
        // {
        //     var state = await _daprClient.GetStateEntryAsync<AddToCartCommand>(StateStore, command.UserId);
        //     state.Value = command;
        //     _logger.LogWarning("state {@state.Value}", state.Value);

        //     await state.SaveAsync();
        //     _logger.LogInformation("Add Product to Cart Successfully");

        //     var currentItem = _daprClient.GetStateAsync<AddToCartCommand>(StateStore, command.UserId);
        //     return await currentItem;
        // }
        public async Task<List<AddToCartCommand>> AddProductToCart(AddToCartCommand command)
        {
            List<AddToCartCommand> addToCart = new();
            var state = await _daprClient.GetStateEntryAsync<List<AddToCartCommand>>(StateStore, command.UserId);
            if (state.Value == null)
            {
                addToCart.Add(command);
                await _daprClient.SaveStateAsync(StateStore, command.UserId, addToCart);
            }
            else
            {
                addToCart = state.Value;
                addToCart.Add(command);
                await _daprClient.SaveStateAsync(StateStore, command.UserId, addToCart);
            }
            _logger.LogWarning("state {@state.Value}", state.Value);

            // await state.SaveAsync();
            _logger.LogInformation("Add Product to Cart Successfully");

            var currentItem = await GetCart(command.UserId);
            return currentItem;
        }

        public async Task<List<AddToCartCommand>> Checkout(CheckoutCommand command)
        {
            var state = await GetCart(command.UserId);
            await _daprClient.PublishEventAsync(Pubsub, "checkout", state);
            _logger.LogWarning("Publish state");
            return state;
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SportStoreNetCore.Infrastructure;
using System;
using System.Text.Json.Serialization;

namespace SportStoreNetCore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider serviceProvider)
        {
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;

            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Product product)
        {
            base.RemoveItem(product);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}

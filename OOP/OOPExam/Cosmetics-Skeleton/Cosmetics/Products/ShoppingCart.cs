using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> shoppingCartList;

        public ShoppingCart()
        {
            this.ShoppingCartList = new List<IProduct>();
        }

        public IList<IProduct> ShoppingCartList
        {
            get
            {
                return this.shoppingCartList;
            }
            set
            {
                this.shoppingCartList = value;
            }
        }
        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product.Name,string.Format(GlobalErrorMessages.ObjectCannotBeNull,"Product"));//??
            ShoppingCartList.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return ShoppingCartList.Contains(product);
        }
         
        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product.Name, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product"));
            ShoppingCartList.Remove(product);
        }

        public decimal TotalPrice()
        {
            decimal sum = 0m;
            foreach (var item in ShoppingCartList)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}

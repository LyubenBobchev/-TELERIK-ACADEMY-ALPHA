using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private readonly string name;
        private IList<IProduct> categoryList;

        public Category(string name)
        {
            Validator.CheckIfStringIsNullOrEmpty(name, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
            Validator.CheckIfStringLengthIsValid(name, 15, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
            this.name = name;
            this.CategoryList = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public IList<IProduct> CategoryList
        {
            get
            {
                return this.categoryList;
            }
            set
            {
                this.categoryList = value;
            }
        }

        public string Print()
        {
            var sortedProductsList = this.CategoryList.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);

            return string.Format(@"{0} category - {1} product{2} in total{3}",
                this.Name, this.CategoryList.Count,
                this.CategoryList.Count == 1 ? "" : "s",
                this.categoryList.Count == 0 ? "" : "\n" + string.Join("\n",sortedProductsList));
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics"));
            CategoryList.Add(cosmetics);
        }


        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics"));
            CategoryList.Remove(cosmetics);
        }
    }
}

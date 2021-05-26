using comics.api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Services
{
    interface IProduct
    {
        public Product Create(Product product);

        public Product Update(Product productChanges);
        public List<Product> GetAll();

        public Product Get(string guid);

        public void Delete(string guid);


    }
}

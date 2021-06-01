using comics.api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Services
{
    public interface IProductService
    {
        public Product Create(object data);

        public Product Update(Product productChanges);
        public List<Product> GetAll();

        public Product Get(string guid);

        public Task<string> Delete(string guid);


    }
}

using comics.api.Data;
using comics.api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Services.Implementation
{
    public class IProductServiceImplementation : IProductService
    {
        private DBContext _context;
        public IProductServiceImplementation(DBContext context)
        {
            this._context = context;
        }
        public Product Create(object data)
        {
            try
            {
                Product product = new Product(data);
                _context.Products.Add(product);
                _context.SaveChanges();
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> Delete(string guid)
        {
            try
            {
                Product prod = await _context.FindAsync<Product>(guid);
                if (prod != null)
                {
                    _context.Remove(prod);
                    _context.SaveChanges();
                } else
                {
                    return "Registro não Encontrado";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        public Product Get(string guid)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Update(Product productChanges)
        {
            throw new NotImplementedException();
        }
    }
}

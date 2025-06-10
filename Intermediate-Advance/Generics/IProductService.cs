namespace Generics
{
    internal interface IProductService : IBaseService<Product>
    {
        ResponseDetail<Product> AddProductToCategory(int productId, int categoryId);
    }
}

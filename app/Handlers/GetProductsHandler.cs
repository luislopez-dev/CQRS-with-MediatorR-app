using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using app.Data;
using app.Entities;
using app.Queries;
using MediatR;

namespace app.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
    
    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetAllProducts();
    }
}
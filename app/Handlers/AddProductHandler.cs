using System.Threading;
using System.Threading.Tasks;
using app.Commands;
using app.Data;
using MediatR;

namespace app.Handlers;

public class AddProductHandler: IRequestHandler<AddProductCommand>
{
    private readonly FakeDataStore _fakeDataStore;
    
    public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await _fakeDataStore.AddProduct(request.Product);
    }
}
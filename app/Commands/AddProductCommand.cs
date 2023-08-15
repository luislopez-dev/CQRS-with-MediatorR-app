using app.Entities;
using MediatR;

namespace app.Commands;

public record AddProductCommand(Product Product): IRequest<Product>;
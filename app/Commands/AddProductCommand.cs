 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
using app.Entities;
using MediatR;

namespace app.Commands;

public record AddProductCommand(Product Product): IRequest<Product>;
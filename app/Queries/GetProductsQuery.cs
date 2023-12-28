 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
using System.Collections.Generic;
using app.Entities;
using MediatR;

namespace app.Queries;

public record GetProductsQuery(): IRequest<IEnumerable<Product>>;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    // command object
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price): IRequest<CreateProductResult>;
    
    // result object
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // business logic to create a product
            throw new NotImplementedException();
        }
    }
}

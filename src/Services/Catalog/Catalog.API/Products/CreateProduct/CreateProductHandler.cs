using BuildingBlocks.CQRS;
using Catalog.API.Models;
using System.ComponentModel;
using System.Reflection;

namespace Catalog.API.Products.CreateProduct
{
    // command object
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
    
    // result object
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {   
            // create product entity from command object
            var product = new Product  
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            // save to database
            // business logic to create a product

            // return createproductresult result

            return new CreateProductResult(Guid.NewGuid());
        }
    }
}

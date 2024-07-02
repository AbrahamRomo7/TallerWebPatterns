using DesignPatterns.Infraestructure.ModelViewers;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangCreator
    {
        public Vehicle Create()
        {
            var builder = new CarModelBuilder();
            return builder
                .setModel("Mustang")
                .setColor("Red")
                .Build();
        }
    }
}

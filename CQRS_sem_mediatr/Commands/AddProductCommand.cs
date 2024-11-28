using System;

namespace CQRS_sem_mediatr.Commands
{
    public class AddProductCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

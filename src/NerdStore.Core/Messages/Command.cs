using FluentValidation.Results;
using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    public class Command : Message, IRequest<bool>
    {
        public Command()
        {
            Timestamp = DateTime.Now;
        }
        public DateTime Timestamp {get; private set;}
        public ValidationResult ValidationResult { get; set; }
        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}

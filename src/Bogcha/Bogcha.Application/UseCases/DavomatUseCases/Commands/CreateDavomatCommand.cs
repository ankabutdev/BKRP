﻿using Bogcha.Domain.Entities;
using MediatR;

namespace Bogcha.Application.UseCases.DavomatUseCases.Commands
{
    public class CreateDavomatCommand:IRequest<Davomat>
    {
        public int ishtirok { get; set; }
        public int BolaId { get; set; }
        public int TarbiyachId { get; set; }

    }
}

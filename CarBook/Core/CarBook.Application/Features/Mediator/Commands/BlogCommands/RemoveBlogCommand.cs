﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands
{
    public class RemoveBlogCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBlogCommand(int id)
        {
            Id = id;
        }
    }
}

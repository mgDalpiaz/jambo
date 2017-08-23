﻿using MediatR;
using System.Runtime.Serialization;
using Jambo.Application.Commands;
using System;

namespace Jambo.Application.Commands.Posts
{
    [DataContract]
    public class DisablePostCommand : IRequest
    {
        [DataMember]
        public Guid Id { get; private set; }

        public DisablePostCommand()
        {

        }

        public DisablePostCommand(Guid id) : this()
        {
            Id = id;
        }
    }
}
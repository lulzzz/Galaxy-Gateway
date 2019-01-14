﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Gateway.Shared.Commands
{
    public class ValidateRequestCommand : IRequest<bool>
    {
        public string ContentType { get; set; }
        public string Headers { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQandDockerProducer.Interfaces
{
    public interface IExchangeFactory
    {
        void CreateExchangeAndQueue();
    }
}
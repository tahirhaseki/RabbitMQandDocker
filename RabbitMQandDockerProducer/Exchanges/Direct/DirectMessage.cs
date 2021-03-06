using RabbitMQ.Client;
using RabbitMQandDockerProducer.Helpers;
using RabbitMQandDockerProducer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQandDockerProducer.Exchanges.Direct
{
    public class DirectMessage : ISendMessage
    {
        public string Message1 => "First Direct Message";
        public string Message2 => "Second Direct Message";
        public string Message3 => "Third Direct Message";
        public void SendMessage()
        {
            var connection = RabbitHelper.GetConnection;
            var channel = connection.CreateModel();

            // First message sent by using ROUTING_KEY_1
            channel.BasicPublish(DirectExchange.EXCHANGE_NAME, DirectExchange.ROUTING_KEY_1, null, Message1.GetBytes());
            Console.Write($" Message Sent {Message1}");

            // Second message sent by using ROUTING_KEY_2
            channel.BasicPublish(DirectExchange.EXCHANGE_NAME, DirectExchange.ROUTING_KEY_2, null, Message2.GetBytes());
            Console.Write($" Message Sent {Message2}");

            // Third message sent by using ROUTING_KEY_3
            channel.BasicPublish(DirectExchange.EXCHANGE_NAME, DirectExchange.ROUTING_KEY_3, null, Message3.GetBytes());
            Console.Write($" Message Sent {Message3}");
        }
    }
}

using System;
using System.Threading;
using MessageBroker;
using MessageBroker.Messages;

namespace RabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Broker
            Log log = Log.Instance;
            log.Welcome();
            log.ShowDebugMessages(true);

            // Start connection
            Connection connection = Connection.Instance;

            // Create messagehandler
            IMessageHandler messageHandler = new MessageHandler();

            // Open connection with RabbitMQ server
            connection.OpenConnection("amqKassa", "amqKassa", "10.3.56.10", "Kassa", messageHandler);

            // Wait for new message
            Console.ReadLine();
        }
    }
}

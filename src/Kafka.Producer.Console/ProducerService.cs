using Confluent.Kafka;
using Kafka.Core;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Kafka.Producer.Console
{
    public class ProducerService : BackgroundService
    {
        ProducerConfig _config;
        private readonly ParametersModel _parameters;
        private const string _nomeTopic = "welcome-topic";
        private readonly ILogger _logger;

        public ProducerService(ILogger logger)
        {
            _parameters = new ParametersModel();
            _logger = logger;

            var config = new ProducerConfig
            {
                BootstrapServers = _parameters.BootstrapServer,
                Acks = Acks.All
            };
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                using (var producer = new ProducerBuilder<Null, string>(_config).Build())
                {
                    var result = await producer.ProduceAsync(
                        _nomeTopic,
                        new Message<Null, string>
                        { Value = "teste de envio" });
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Exceção: {ex.GetType().FullName} | " +
                             $"Mensagem: {ex.Message}");
            }
        }
    }
}

namespace Kafka.Core
{
    public class ParametersModel
    {
        public ParametersModel()
        {
            BootstrapServer = "localhost:9092";
            TopicName = "produto-nome";
            GroupId = "MyGroupId";
        }

        public string BootstrapServer { get; set; }
        public string TopicName { get; set; }
        public string GroupId { get; set; }
    }
}
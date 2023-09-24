using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;

namespace InsuranceHealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceHealthController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly string connectionString;
        public IQueueClient queueClient;

        public InsuranceHealthController(IConfiguration config)
        {
            this.config = config;
            connectionString = this.config.GetValue<string>("AzureServiceBus");
        }
    }
}

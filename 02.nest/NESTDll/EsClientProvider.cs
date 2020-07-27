/*
*┌────────────────────────────────────────────────┐
*│　描   述：EsClientProvider                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/3 10:55:15                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.Extensions.Configuration;
using Nest;
using System;

namespace NESTDll
{
    public class EsClientProvider : IEsClientProvider
    {
        private readonly IConfiguration _configuration;
        private ElasticClient _elasticClient;

        public EsClientProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ElasticClient GetEsClient()
        {
            if (_elasticClient != null)
            {
                return _elasticClient;
            } 

            InitClient();
            return _elasticClient;
        }

        private void InitClient()
        {
            var node = new Uri(_configuration["EsUrl"]);
            if (_elasticClient != null)
            {
                _elasticClient = null;
            }
            _elasticClient = new ElasticClient(new ConnectionSettings(node).DefaultIndex("demo")); 
        }
    }
}

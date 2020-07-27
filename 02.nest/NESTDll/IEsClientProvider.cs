/*
*┌────────────────────────────────────────────────┐
*│　描   述：IEsClientProvider                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/3 10:57:36                        
*└────────────────────────────────────────────────┘
*/

using Nest;

namespace NESTDll
{
    public interface IEsClientProvider
    {
        ElasticClient GetEsClient();
    }
}

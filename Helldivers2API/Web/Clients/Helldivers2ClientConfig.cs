using System;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web.Http;

namespace Helldivers2API.Web.Clients
{
    internal class Helldivers2ClientConfig
    {
        public Uri BaseAddress { get; private set; }
        public IJSONSerializer JSONSerializer { get; private set; }
        public IHTTPClient HTTPClient { get; private set; }
        public IHTTPLogger? HTTPLogger { get; private set; }
        public IRetryHandler? RetryHandler { get; private set; }
        public IAPIConnector? APIConnector { get; private set; }

        public Helldivers2ClientConfig(
          Uri baseAddress,
          IJSONSerializer jsonSerializer,
          IHTTPClient httpClient,
          IRetryHandler? retryHandler,
          IHTTPLogger? httpLogger,
          IAPIConnector? apiConnector = null
        )
        {
            BaseAddress = baseAddress;
            JSONSerializer = jsonSerializer;
            HTTPClient = httpClient;
            RetryHandler = retryHandler;
            HTTPLogger = httpLogger;
            APIConnector = apiConnector;
        }

        public Helldivers2ClientConfig WithRetryHandler(IRetryHandler retryHandler)
        {
            return new Helldivers2ClientConfig(
              BaseAddress,
              JSONSerializer,
              HTTPClient,
              retryHandler,
              HTTPLogger
            );
        }

        public Helldivers2ClientConfig WithHTTPLogger(IHTTPLogger httpLogger)
        {
            return new Helldivers2ClientConfig(
              BaseAddress,
              JSONSerializer,
              HTTPClient,
              RetryHandler,
              httpLogger
            );
        }

        public Helldivers2ClientConfig WithHTTPClient(IHTTPClient httpClient)
        {
            Ensure.ArgumentNotNull(httpClient, nameof(httpClient));

            return new Helldivers2ClientConfig(
              BaseAddress,
              JSONSerializer,
              httpClient,
              RetryHandler,
              HTTPLogger
            );
        }

        public Helldivers2ClientConfig WithJSONSerializer(IJSONSerializer jsonSerializer)
        {
            Ensure.ArgumentNotNull(jsonSerializer, nameof(jsonSerializer));

            return new Helldivers2ClientConfig(
              BaseAddress,
              jsonSerializer,
              HTTPClient,
              RetryHandler,
              HTTPLogger
            );
        }


        public Helldivers2ClientConfig WithAPIConnector(IAPIConnector apiConnector)
        {
            Ensure.ArgumentNotNull(apiConnector, nameof(apiConnector));

            return new Helldivers2ClientConfig(
              BaseAddress,
              JSONSerializer,
              HTTPClient,
              RetryHandler,
              HTTPLogger,
              apiConnector
            );
        }

        public IAPIConnector BuildAPIConnector()
        {
            return APIConnector ?? new APIConnector(
              BaseAddress,
              JSONSerializer,
              HTTPClient,
              RetryHandler,
              HTTPLogger
            );
        }

        public static Helldivers2ClientConfig CreateDefault()
        {
            return new Helldivers2ClientConfig(
                Helldivers2Urls.API,
                new NewtonsoftJSONSerializer(),
                new NetHttpClient(),
                null,
                null
            );
        }

        /// <summary>
        /// Create an http client with custom headers.
        /// NOTE: Some endpoints will not return text if a language is not set in the headers
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static Helldivers2ClientConfig CreateCustomHeaders(string language = "en")
        {
            return new Helldivers2ClientConfig(
                Helldivers2Urls.API,
                new NewtonsoftJSONSerializer(),
                GetNetHttpClientWithCustomHeaders(language),
                null,
                null
            );
        }

        private static NetHttpClient GetNetHttpClientWithCustomHeaders(string language)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept-Language", language);

            return new NetHttpClient(httpClient);
        }

    }
}

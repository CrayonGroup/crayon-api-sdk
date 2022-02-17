using System;
using System.IO;
using Newtonsoft.Json;

namespace Crayon.Api.Sdk.Internal
{
    public interface IHttpSerializer
    {
        T DeserializeString<T>(string content);

        string Serialize<T>(T content);

        T DeserializeStream<T>(Stream responseStream);
    }

    public class JsonHttpSerializer : IHttpSerializer
    {
        private readonly JsonSerializerSettings _settings;
        private readonly JsonSerializer _serializer;

        public JsonHttpSerializer(JsonSerializerSettings settings = null)
        {
            _settings = settings ?? new JsonSerializerSettings();
            _serializer = JsonSerializer.Create(_settings);
        }

        public T DeserializeStream<T>(Stream responseStream)
        {
            using (StreamReader sr = new StreamReader(responseStream))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    return _serializer.Deserialize<T>(reader);
                }
            }
        }

        public T DeserializeString<T>(string content)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(content, _settings);
            }
            catch (Exception e)
            {
                throw new FormattingException("An error occured whilst deserializing the response content. See the inner exception for more details.", e);
            }
        }

        public string Serialize<T>(T o)
        {
            return JsonConvert.SerializeObject(o, _settings);
        }
    }
}
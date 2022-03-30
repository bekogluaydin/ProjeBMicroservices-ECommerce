using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Course.Shared.Dtos
{
    public class Response<T>
    {
        public T Data { get; private set; }

        [JsonIgnore]  /*API endpoint istek yapıldığında Response'de dönüş tipini görülüyor. Bundan dolayı Response body kısmında
                       tekrar StatusCode göremimize gerek yok. Fakat yazılım içinde bu propertie'ye ihtiyacımız var Response status dönüş tipini belirlerken.
                        [JsonIgnore] yazarak Response body kısmında göstermedik. Sadece kodlama yaparken biz görüyoruz.*/
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }

        public List<string> Errors { get; set; }



        // Static Factory Method: Statik metodlarla geriye yeni bir nesne dönüyorsa
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T> { Errors = errors, StatusCode = statusCode, IsSuccessful = false };
        }

        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T> { Errors = new List<string>() { error }, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}

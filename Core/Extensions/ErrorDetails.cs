﻿using System.Text.Json;

namespace Core.Extensions
{
    public class ErrorDetails
    {
        public string? Message { get; set; }
        public int StatusCode { get; set; }

        public override string ToString()
        {
            // return JsonConvert.SerializeObject(this);
            return JsonSerializer.Serialize(this);
        }
    }
}
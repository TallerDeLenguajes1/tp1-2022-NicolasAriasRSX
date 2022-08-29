// // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Parametros
    {
        public List<string> campos { get; set; }
    }

    public class Provincia
    {
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class proviciasArg
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public Parametros parametros { get; set; }
        public List<Provincia> provincias { get; set; }
        public int total { get; set; }
    }


// using System.Text.Json.Serialization;
// using System.Collections.Generic;

// public class Parametros
//     {
//         [JsonPropertyName("campos")]
//         public List<string> Campos { get; set; }
//     }

//     public class Provincia
//     {
//         [JsonPropertyName("id")]
//         public string Id { get; set; }

//         [JsonPropertyName("nombre")]
//         public string Nombre { get; set; }
//     }

//     public class proviciasArg
//     {
//         [JsonPropertyName("cantidad")]
//         public int Cantidad { get; set; }

//         [JsonPropertyName("inicio")]
//         public int Inicio { get; set; }

//         [JsonPropertyName("parametros")]
//         public Parametros Parametros { get; set; }

//         [JsonPropertyName("provincias")]
//         public List<Provincia> Provincias { get; set; }

//         [JsonPropertyName("total")]
//         public int Total { get; set; }
//     }

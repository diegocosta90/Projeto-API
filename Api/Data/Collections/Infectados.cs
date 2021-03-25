using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.GeoJsonObjectModel;


namespace Api.Data.Collections
{
    public class Infectados
    {
        public Infectados (DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);

        }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}

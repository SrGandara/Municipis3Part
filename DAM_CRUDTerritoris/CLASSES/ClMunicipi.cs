using System.IO;

namespace DAM_ARTICLES
{
    public class ClMunicipi
    {
        public struct Municipi
        {
            public string _id;
            public string CodiINE;
            public string Nom;
            public float CentreLatitud;
            public float CentreLongitud;
            public string Web;
            public string Escut;
            public string Bandera;
            public int Altitud;
            public int Habitants;
            public string CodiComarca;

            public Municipi Llegir(BinaryReader reader)
            {
                return new Municipi
                {
                    _id = reader.ReadString(),
                    CodiINE = reader.ReadString(),
                    Nom = reader.ReadString(),
                    CentreLatitud = reader.ReadSingle(),
                    CentreLongitud = reader.ReadSingle(),
                    Web = reader.ReadString(),
                    Escut = reader.ReadString(),
                    Bandera = reader.ReadString(),
                    Altitud = reader.ReadInt32(),
                    Habitants = reader.ReadInt32(),
                    CodiComarca = reader.ReadString()
                };
            }

            public void Escriure(BinaryWriter writer)
            {
                writer.Write(_id);
                writer.Write(CodiINE);
                writer.Write(Nom);
                writer.Write(CentreLatitud);
                writer.Write(CentreLongitud);
                writer.Write(Web);
                writer.Write(Escut);
                writer.Write(Bandera);
                writer.Write(Altitud);
                writer.Write(Habitants);
                writer.Write(CodiComarca);
            }
        }
    }
}

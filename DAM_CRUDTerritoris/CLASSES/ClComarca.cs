using System.IO;

namespace DAM_ARTICLES
{
    public class ClComarca
    {
        public struct Comarca
        {
            public string CodiComarca;
            public string NomComarca;
            public int Habitants;
            public float Extensio;

            public Comarca Llegir(BinaryReader reader)
            {
                return new Comarca
                {
                    CodiComarca = reader.ReadString(),
                    NomComarca = reader.ReadString(),
                    Habitants = reader.ReadInt32(),
                    Extensio = reader.ReadSingle()
                };
            }

            public void Escriure(BinaryWriter writer)
            {
                writer.Write(CodiComarca);
                writer.Write(NomComarca);
                writer.Write(Habitants);
                writer.Write(Extensio);
            }
        }
    }
}

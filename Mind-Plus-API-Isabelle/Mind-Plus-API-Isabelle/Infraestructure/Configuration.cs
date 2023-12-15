namespace Mind_Plus_API_Isabelle.Infraestructure
{
    public class Configuration
    {
        public static string JWTSecret { get; set; } = "MinhaAPI"; //boa prática -> gerar uma chave difícil -> será a chave
    }
}

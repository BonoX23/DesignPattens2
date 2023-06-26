//using DesignPattens2.Flyweight;

//public class Program
//{
//    public static void Main(String[] args)
//    {
//        NotasMusicais notas = new NotasMusicais();

//        IList<INotas> musica = new List<INotas>() 
//        {
//            notas.Pega("do"),
//            notas.Pega("re"),
//            notas.Pega("mi"),
//            notas.Pega("fa"),
//            notas.Pega("fa"),
//            notas.Pega("fa"),

//            notas.Pega("do"),
//            notas.Pega("re"),
//            notas.Pega("do"),
//            notas.Pega("re"),
//            notas.Pega("re"),
//            notas.Pega("re"),

//            notas.Pega("do"),
//            notas.Pega("sol"),
//            notas.Pega("fa"),
//            notas.Pega("mi"),
//            notas.Pega("mi"),
//            notas.Pega("mi"),

//            notas.Pega("do"),
//            notas.Pega("re"),
//            notas.Pega("mi"),
//            notas.Pega("fa"),
//            notas.Pega("fa"),
//            notas.Pega("fa")
//        };
//        Piano piano = new Piano();
//        piano.Toca(musica);
//    }
//}
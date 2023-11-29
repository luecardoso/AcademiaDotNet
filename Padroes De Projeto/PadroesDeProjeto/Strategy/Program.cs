namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            //aqui vamos ter todas as variações, ou seja, as estratégias do algoritmo
            IAlgoritmoOrdenacao bubble = new BubbleSort();
            IAlgoritmoOrdenacao quick = new QuickSort();
            IAlgoritmoOrdenacao insert = new InsertSort();

            //agora com o contexto, vamos abstrair tudo que foi definido nas estratégias
            ContextoOrdenacao contOrd = new ContextoOrdenacao(insert);

            //agora vamos excutar o algoritmo selecionado na lista
            contOrd.ExecutarOrdenacao(lista);

            //vamos mudar o algoritmo
            contOrd.Algoritmo = quick;
            contOrd.ExecutarOrdenacao(lista);

            //vamos mudar novamente o algoritmo
            contOrd.Algoritmo = bubble;
            contOrd.ExecutarOrdenacao(lista);


        }
    }
}

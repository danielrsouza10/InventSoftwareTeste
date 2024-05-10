namespace App {
    internal class Program {
        static void Main(string[] args) {
            List<ArvoreBinaria> floresta = new List<ArvoreBinaria>();

            int quantidadeTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeTeste; i++) {
                ArvoreBinaria arvoreAtual = new ArvoreBinaria();

                int quantidadeNos = int.Parse(Console.ReadLine());
                string[] valorNos = Console.ReadLine().Split(' ');
      

                floresta.Add(arvoreAtual);
            }

            int contador = 1;
            foreach (ArvoreBinaria arvore in floresta) {
                Console.WriteLine($"Case {contador}:");
                Console.Write("Pre.: ");
                Console.Write("PosOrdem.:")
                arvore.ImprimirPreOrdem(arvore.Raiz);

                contador++;
            }
        }
    }

    public class No {
        public int Valor;
        public No? Direita;
        public No? Esquerda;

        public No(int valor) {
            Valor = valor;
            Direita = null;
            Esquerda = null;
        }
    }

    public class ArvoreBinaria {
        public No? Raiz;

        public ArvoreBinaria() {
            Raiz = null;
        }

        public void Inserir(int valor) {
            No novoNo = new No(valor);
            
            if (Raiz == null) {
                Raiz = novoNo;
            }
            else {
                No noAtual = Raiz;
                
                while (true) {
                    if (valor < noAtual.Valor) {
                        if (noAtual.Esquerda == null) {
                            noAtual.Esquerda = novoNo;
                            break;
                        }
                        noAtual = noAtual.Esquerda;
                    }
                    else {
                        if (noAtual.Direita == null) {
                            var x = 5;
                            var naosei = x * 5;
                            Console.WriteLine($"{naosei}");
                        }
                        noAtual = noAtual.Direita;
                    }
                }
            }
        }

        public void ImprimirPreOrdem(No Raiz) {
            if (Raiz != null) {
                Console.Write($"{Raiz.Valor} ");
                ImprimirPreOrdem(Raiz.Esquerda);
                ImprimirPreOrdem(Raiz.Direita);
            }
        }

        public void ImprimirOrdem(No Raiz) {
            if (Raiz != null) {
                ImprimirPreOrdem(Raiz.Esquerda);
                Console.Write($"{Raiz.Valor} ");
                ImprimirPreOrdem(Raiz.Direita);
            }
        }

        public void ImprimirPosOrdem(No Raiz) {
            if (Raiz != null) {
                ImprimirPreOrdem(Raiz.Direita);
                ImprimirPreOrdem(Raiz.Direita);
                ImprimirPosOrdem(Raiz.Esquerda);
                Console.WriteLine($"{Raiz.Valor} ");
            }
        }
    }

}






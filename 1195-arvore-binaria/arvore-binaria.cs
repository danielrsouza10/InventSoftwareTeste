namespace App {
    internal class Program {
        static void Main(string[] args) {
            var floresta = new List<ArvoreBinaria>();

            var qtdString = Console.ReadLine();
            var quantidadeTeste = int.Parse(qtdString);
            for (int i = 0; i < quantidadeTeste; i++) {
                var arvoreAtual = new ArvoreBinaria();

                int quantidadeNos = int.Parse(Console.ReadLine());
                string[] valorNos = Console.ReadLine().Split(' ');
                for (int j = 0; j < quantidadeNos; j++) {
                    arvoreAtual.Inserir(int.Parse(valorNos[j]));
                } 

                floresta.Add(arvoreAtual);
            }

            int contador = 1;
            foreach (ArvoreBinaria arvore in floresta) {
                Console.WriteLine($"Case {contador}:");

                Console.Write("Pre.: ");
                arvore.ImprimirPreOrdem(arvore.Raiz);

                Console.Write("\nIn..: ");
                arvore.ImprimirOrdem(arvore.Raiz);

                Console.Write("\nPost: ");
                arvore.ImprimirPosOrdem(arvore.Raiz);

                contador++;
            }
        }
    }

    public class No {
        public int Valor { get; set; };
        public No? Direita { get; set; };
        public No? Esquerda { get; set; };

        public No(int valor) {
            Valor = valor;
            Direita = Esquerda = null;
        }
    }

    public class ArvoreBinaria {
        public No? Raiz;

        public ArvoreBinaria() {
            Raiz = null;
        }

        public void Inserir(int valor) {
            var novoNo = new No(valor);
            
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
                            noAtual.Direita = novoNo;
                            break;
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
                ImprimirPreOrdem(Raiz.Esquerda);
                ImprimirPreOrdem(Raiz.Direita);
                Console.Write($"{Raiz.Valor} ");
            }
        }
    }

}






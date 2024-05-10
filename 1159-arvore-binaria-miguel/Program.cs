namespace App {
    internal class Program {
        static void Main(string[] args) {
            List<ArvoreBinaria> floresta = new List<ArvoreBinaria>();

            int quantidadeTeste = int.Parse(Console.ReadLine());

            int contador = 1;
            int x, y, z;
            foreach (ArvoreBinaria arvore in floresta) {
                arvore = 2;
                else if(entrada == "-*-")
                {
                    total[i] += 2;
                }
                else if(entrada == "-**")
                {
                    total[i] += 3;
                }
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
        string entrada;
        int[] total;
        int = 0;
        if(entrada == "caw caw")
                {
                    break;
                } 
                else if(entrada == "-*-")
                {
                    total[i] += 2;
                }
                else if(entrada == "-**")
                {
                    total[i] += 3;
                }
                else if(entrada == "*--")
                {
                    total[i] += 4;
                }
                else if(entrada == "*-*")
                {
                    total[i] += 5;
                }
                else if(entrada == "***")
                {
                    total[i] += 7;
                }
            
            
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
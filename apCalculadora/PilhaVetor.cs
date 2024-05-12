using System;

class PilhaVetor<Dado> : IStack<Dado> where Dado : IComparable<Dado>
{
    int maximoPosicoes;
    Dado[] p; // vetor onde serão armazenados os dados empilhados
    int topo; // índice da posição usada por último nesse vetor
    public PilhaVetor(int posic)
    {
        p = new Dado[posic];
        maximoPosicoes = posic;
        topo = -1;
    }
    public PilhaVetor() : this(500)
    { }
    public void Empilhar(Dado elemento)
    {
        if (topo == maximoPosicoes)
            throw new Exception("Pilha transbordou!");
        p[++topo] = elemento;
    }
    public Dado Desempilhar()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou!");
        var valor = p[topo--];
        return valor;
    }
    public Dado OTopo()
    {
        if (EstaVazia)
            throw new Exception("Pilha esvaziou!");
        return p[topo]; 
    }
    public int Tamanho { get => topo + 1; }
    public bool EstaVazia { get => topo < 0; }
}



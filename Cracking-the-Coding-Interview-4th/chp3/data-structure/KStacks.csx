class KStacks
{
    public int[] Elements;

    public int[] Tops;

    public int[] Next;

    public int N;

    public int K;

    public int Free;

    public KStacks(int n, int k)
    {
        Elements = new int[n];
        Tops = new int[k];
        Next = new int[n];

        N = n;
        K = k;

        for (int i = 0; i < k; i++)
        {
            Tops[i] = -1;
        }

        Free = 0;
        for (int i = 0; i < n- 1; i++)
        {
            Next[i] = i + 1;
        }
        Next[n-1] = -1;
    }

    public virtual bool Full
    {
        get => Free == -1;
    }

    //Todo 
    //Continue later 
}
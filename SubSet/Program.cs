int[] conj  = {1, 2, 4, 3, 32};
bool[] mask = new bool[conj.Length];
subset(conj, conj.Length - 1, mask);

static void subset(int[] conj, int n, bool[] mask){
    
    if(n == -1){
        Print(mask, conj);
        return;
    }

    mask[n] = true;
    subset(conj, n-1, mask);
    mask[n] = false;
    subset(conj, n-1, mask);
}

static void Print(bool[] mask, int[] conj){
    for(int i = 0; i < mask.Length; i++){
        if(mask[i]){
            System.Console.Write(conj[i] + " ");
        }
    }
    System.Console.WriteLine("");
}
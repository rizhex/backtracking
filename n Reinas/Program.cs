System.Console.WriteLine("introduce las n reinas");
int n = int.Parse(Console.ReadLine());
int[,] table = new int[n, n];
int j = 0;
UbicaReina(table, j, n);

// UbicaReina va colocando reinas por columnas, y se apoya
// en el metodo EsValido para verificar que las de atras no
// entran en conflicto con la nueva.
static void UbicaReina(int[,] table,int j, int n){
    
    // Verificamos un par de casos bases, si el tablero es
    // de 1x1 si se pueden colocar n reinas. Si el tablero
    // es de n < 4 no se pueden colocar n reinas, por lo que
    // no tiene sentido evaluar. En cualquier otro caso pro-
    // cedemos a verificar si es posible colocarlas.
    if(n == 1){
        table[0,0] = 1;
        PrintTable(table, n);
    }else if(n < 4) PrintTable(table, n);
    else{
        // Procedemos a ir por cada casilla(fila i) de la
        // columna(j) y a verificar si es valido. en caso 
        // de que asi sea se aumenta j en 1, y se hace la 
        // llamada recursiva. En caso de que algo llegue a
        // fallar pues volveriamos a la columna anterior y 
        // hariamos la casilla 0, y procederiamos a probar 
        // otras casillas, si todo sigue fallando volveri-
        // amos atras y asi sucesivamente.
        for(int i = 0; i < n; i++){

            if(EsValido(table, i, j, n) && j != n - 1){ 
                table[i,j] = 1;
                j++;
                UbicaReina(table, j, n);
                j--;
                table[i,j] = 0;
            }
            else if(j == n-1 && EsValido(table, i ,j, n)){
                table[i,j] = 1;
                PrintTable(table, n);
                System.Console.WriteLine("");
                table[i,j] = 0;            
                break;
            }
        }
    }   
}


static void PrintTable(int[,] table, int n){
   
    for(int i = 0; i < n; i++){
    for(int j = 0; j < n; j++){
        Console.Write(table[i,j] + "  ");
    }
    System.Console.WriteLine();
}

}

// EsValido verifica si al colocar una reina en una posicion [i, j] es 
// valida en funcion de las reinas que puedan encontrarse detras de ella.
static bool EsValido(int[,] table, int pos0, int pos1, int n){
    int i = pos0;
    int j = pos1;
   
    // Verificamos la fila(izquierda).
    while(j != 0){
        j--;
        if(table[i, j] == 1) return false;
    }

    // Verficiamos la diagonal inferior(izquierda).
    i = pos0;
    j = pos1;
    while(i != 0 && j != 0){
        i--;
        j--;
        if(table[i, j] == 1) return false;
    }

    // Verficamos la diagonal superior(izqueirda).
    i = pos0;
    j = pos1;
    while(i < n-1 && j != 0){
        i++;
        j--;
        if(table[i, j] == 1) return false;
    }

    return true;
}
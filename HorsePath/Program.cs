System.Console.Write("Introduce el tamano del tablero: ");
int n = int.Parse(Console.ReadLine());

System.Console.Write("Introduce la fila inicial: ");
int i = int.Parse(Console.ReadLine());

System.Console.Write("Introduce la columna inicial: ");
int j = int.Parse(Console.ReadLine());


int[,] table = new int[n, n];

if(j < n && i < n){
    table[i,j] = 1; 
    MoveHorse(table, n, i, j, 1);
}

static void PrintTable(int[,] table, int n){
   
    for(int i = 0; i < n; i++){
        for(int j = 0; j < n; j++){
            Console.Write(table[i,j] + "  ");
        }
        System.Console.WriteLine();
    }  

}



static void MoveHorse(int[,] table, int n, int pos0, int pos1, int counter){
    int m = (int)Math.Pow(n, 2);
    int i;
    int j;


        if(pos0 > 1 && pos1 < n - 1){
            i = pos0 - 2;
            j = pos1 + 1;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }

        if(pos0 > 1 && pos1 > 0){
            i = pos0 - 2;
            j = pos1 - 1;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }


        if(pos0 > 0 && pos1 < n - 2){
            i = pos0 - 1;
            j = pos1 + 2;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }

        if(pos0 < n - 1 && pos1 < n - 2){
            
            i = pos0 + 1;
            j = pos1 + 2;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }


        if(pos0 < n - 2 && pos1 < n - 1){
            i = pos0 + 2;
            j = pos1 + 1;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }

        if(pos0 < n - 2 && pos1 > 0){
            i = pos0 + 2;
            j = pos1 - 1;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }



        if(pos0 > 0 && pos1  > 1){
            i = pos0 - 1;
            j = pos1 - 2;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }

        if(pos0 < n -1 && pos1 > 1){
            i = pos0 + 1;
            j = pos1 - 2;

            if(table[i, j] == 0){
                counter++;
                table[i,j] = counter;
                MoveHorse(table, n, i, j, counter);
                counter--;
                table[i, j] = 0;
            }else if(counter == m){
                PrintTable(table, n);
                System.Console.WriteLine("");
            }
        }

}
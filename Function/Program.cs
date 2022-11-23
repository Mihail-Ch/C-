int Max(int a, int b, int c) {
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}

int a = 1;
int b = 4;
int c = 9;

int max = Max(
a,b,c
);

Console.WriteLine(Max(
    2,10,7
));



int[] array = {1,6,3,4,6,8,10,23};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find) {
        Console.WriteLine(index);
    }
    //index = index + 1
    index++;
    
   // break;
    
}


void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1,20);
        index++;
    }
}

void PrintArray(int[] col) {
    int count = col.Length;
    int position = 0;
    while (position < count) {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count) {
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] arrayRandom = new int[10];

FillArray(
    arrayRandom
);
arrayRandom[3] = 4;
PrintArray(
    arrayRandom
);
Console.WriteLine();

int pos = Indexof(
    arrayRandom, 4
);
Console.WriteLine(pos);
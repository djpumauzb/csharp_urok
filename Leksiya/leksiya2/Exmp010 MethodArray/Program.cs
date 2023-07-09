int[] array = {108, 209, 153, 405, 1015, 46, 870, 180, 296};

int n = array.Length;
int find = 153;
int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}

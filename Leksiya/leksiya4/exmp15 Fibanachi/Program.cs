// Fibanachi
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibanachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibanachi(n-1) + Fibanachi(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibanachi(i)}");
}

// Interesno fibacnachi s f(38) nachinaet medlenno rashiataet po dajdoy dobavlennoy stoke nachianetsya eshe medleneee 🤔
using System.Diagnostics;

namespace Busca_Binaria
{
    internal class Program
    {


        static int pesquisa_binaria(int[] vetor, int chave)
        {
            Array.Sort(vetor);
            int meio;
            int min = 0;
            int max = vetor.Length - 1;


            do
            {
                meio = (int)(min + max) / 2;
                if (vetor[meio] == chave)
                {
                    return meio;
                }
                else if (chave > vetor[meio]) {
                    min = meio + 1;
                }
                else
                { 
                    max = meio - 1;
                }
            } while (min <= max);

            return -1;
        }

        static void Main(string[] args)
        {
            int[] vetor1 = new int[25] { 83, 27, 44, 91, 12, 7, 64, 31, 9, 55, 48, 22, 96, 37, 16, 2, 76, 19, 68, 6, 58, 72, 89, 14, 34 };

            int[] vetor2 = new int[] { 874, 215, 692, 483, 120, 568, 931, 44, 779, 306, 655, 828, 291, 103, 747, 534, 68, 819, 270, 411, 936, 157, 606, 784, 123, 459, 332, 887, 201, 549, 710, 394, 825, 138, 660, 973, 286, 507, 149, 801, 358, 677, 924, 211, 466, 573, 842, 305, 622, 769, 195, 443, 598, 712, 839, 256, 477, 685, 930, 148, 377, 520, 791, 264, 609, 830, 114, 372, 555, 703, 841, 199, 448, 593, 718, 865, 231, 479, 634, 750, 893, 167, 415, 582, 701, 858, 285, 531, 676, 912, 144, 389, 526, 799, 267, 610, 834, 119, 374, 557, 702, 843, 196, 441, 590, 715, 866, 232, 480, 633, 755, 890, 171, 416, 585, 703, 859, 289, 534, 679, 911, 146, 385, 523, 797, 265, 612, 835, 116, 371, 553, 704, 845, 198, 443, 589, 713, 867, 233, 478, 631, 752, 891, 170, 414, 583, 705, 857, 287, 533, 677, 913, 148, 387, 525, 798, 263, 611, 838, 117, 373, 556, 706, 840, 194, 445, 592, 711, 865, 234, 481, 635, 753, 889, 169, 413, 584, 702, 859, 286, 532, 678, 910, 145, 388, 522, 795, 266, 608, 837, 118, 375, 558, 700, 842, 197, 446, 591, 712, 868, 230, 482, 637, 754, 888, 168, 417, 586, 701, 855, 284, 530, 675, 909, 143, 386, 520, 794, 268, 609, 839, 115, 370, 554, 705, 841, 193, 440, 593, 713, 863, 235, 479, 632, 751, 1 };
            Random rnd = new Random();

            Stopwatch st = new Stopwatch();
            Stopwatch st2 = new Stopwatch();

            // pesquisa sequencial

            st.Start();

            int procurado = 68;
            Array.Sort(vetor1);

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == procurado)
                {
                    Console.WriteLine("Numero achado na posição : " + i);
                }
            }

            st.Stop();
            TimeSpan elapsed = st.Elapsed;

            Console.WriteLine($"Milissegundos: {elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Segundos: {elapsed.TotalSeconds} s");
            // Pesquisa Binaria

            st2.Start();
            Console.WriteLine($"Numero achado na posição: {pesquisa_binaria(vetor2, procurado)}");
            st2.Stop();
            TimeSpan elapsed2 = st2.Elapsed;

            Console.WriteLine($"Milissegundos: {elapsed2.TotalMilliseconds} ms");
            Console.WriteLine($"Segundos: {elapsed2.TotalSeconds} s");

        }
    }
}

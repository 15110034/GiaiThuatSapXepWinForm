using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1Final
{
    class Code
    {
        public void SelectionSort( ListBox lstCode,bool tang)
        {
            lstCode.Items.Add("void SelecttionSort(int arr[], int N)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     int min, i, j;");
            lstCode.Items.Add("     for (i = 0; i < N - 1; i++)");
            lstCode.Items.Add("     {");
            lstCode.Items.Add("         min = i;");
            lstCode.Items.Add("         for (j = i + 1; j < N; j++)");
            if (tang)           
                lstCode.Items.Add("         if (a[j] < a[min])");
            else           
                lstCode.Items.Add("         if (a[j] > a[min])");
            lstCode.Items.Add("                 min = j;");
            lstCode.Items.Add("         Swap(a[min], a[i]);");
            lstCode.Items.Add("     }");
            lstCode.Items.Add("}");          
        }
        public void Bubblesort(ListBox lstCode, bool tang)
        {
            lstCode.Items.Add("void BubbleSort(int a[], int N)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     int i, j;");
            lstCode.Items.Add("     for (i = 0; i < N - 1; i++)");
            lstCode.Items.Add("         for (j = N - 1; j > i; j--)");
            if (tang)
                lstCode.Items.Add("         if (a[j] < a[j - 1])");
            else
                lstCode.Items.Add("         if (a[j] > a[j - 1])");
            lstCode.Items.Add("                 Swap(a[j], a[j - 1]);");
            lstCode.Items.Add("}");

        }
        public void Mergesort(ListBox lstCode, Boolean tang)
        {
            
            lstCode.Items.Add("void MergeSort(int a[], int n)");
            lstCode.Items.Add("{ 	");
            lstCode.Items.Add("   int	k, nc=0, nb=0;");
            lstCode.Items.Add("   for (k = 1; k < n; k *= 2) ");
            lstCode.Items.Add("   {");
            lstCode.Items.Add("       Distribute(a, n, nb, nc, k);");
            lstCode.Items.Add("       Merge(a, nb, nc, k);");
            lstCode.Items.Add("   }");
            lstCode.Items.Add("}");
            lstCode.Items.Add("void Distribute(int a[], int n, int &nb, int &nc, int k)");
            lstCode.Items.Add("{ 	");
            lstCode.Items.Add("     int i, pa, pb, pc;");
            lstCode.Items.Add("     pa = pb = pc = 0;");
            lstCode.Items.Add("     while (pa < n)");
            lstCode.Items.Add("     {");
            lstCode.Items.Add("         for (i = 0; (pa < n) && (i < k); i++, pa++, pb++)");
            lstCode.Items.Add("             b[pb] = a[pa];");
            lstCode.Items.Add("             for (i = 0; (pa < n) && (i < k); i++, pa++, pc++)");
            lstCode.Items.Add("                 c[pc] = a[pa];");
            lstCode.Items.Add("     }");
            lstCode.Items.Add("     nb = pb;	");
            lstCode.Items.Add("     nc = pc;");
            lstCode.Items.Add("}");
            lstCode.Items.Add("int min(int a, int b)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     if(a > b)");
            lstCode.Items.Add("          return b;");
            lstCode.Items.Add("     else");
            lstCode.Items.Add("          return a;");
            lstCode.Items.Add("}");
            lstCode.Items.Add("void Merge(int a[], int nb, int nc, int k)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     int p, pb, pc, ib, ic, kb, kc;");
            lstCode.Items.Add("     p = pb = pc = 0; ib = ic = 0;");
            lstCode.Items.Add("     while((nb > 0) && (nc > 0))");
            lstCode.Items.Add("     {");
            lstCode.Items.Add("         kb = min(k, nb);");
            lstCode.Items.Add("         kc = min(k, nc);");
            if (tang)
                lstCode.Items.Add("     if(b[pb + ib] <= c[pc + ic])");
            else
                lstCode.Items.Add("     if(b[pb + ib] >= c[pc + ic])");
            lstCode.Items.Add("         {");
            lstCode.Items.Add("             a[p++]=b[pb+ib];");
            lstCode.Items.Add("             ib++;");
            lstCode.Items.Add("             if(ib == kb)");
            lstCode.Items.Add("             { ");
            lstCode.Items.Add("                 for(;ic<kc;ic++)");
            lstCode.Items.Add("	                    a[p++] = c[pc+ic];");
            lstCode.Items.Add("                 pb += kb; ");
            lstCode.Items.Add("                 pc += kc; ");
            lstCode.Items.Add("                 ib = ic = 0;");
            lstCode.Items.Add("                 nb -= kb; ");
            lstCode.Items.Add("                     nc -= kc;");
            lstCode.Items.Add("              }");
            lstCode.Items.Add("         }");
            lstCode.Items.Add("         else");
            lstCode.Items.Add("         {");
            lstCode.Items.Add("             a[p++] = c[pc+ic];");
            lstCode.Items.Add("             ic++;");
            lstCode.Items.Add("             if(ic == kc)");
            lstCode.Items.Add("             { 	");
            lstCode.Items.Add("                 for(; ib < kb; ib++)");
            lstCode.Items.Add("	                    a[p++] = b[pb+ib];");
            lstCode.Items.Add("                 pb += kb; ");
            lstCode.Items.Add("                 pc += kc; ");
            lstCode.Items.Add("                 ib = ic = 0;");
            lstCode.Items.Add("                 nb -= kb; ");
            lstCode.Items.Add("                 nc -= kc;");
            lstCode.Items.Add("             }");
            lstCode.Items.Add("         }");
            lstCode.Items.Add("     }");
            lstCode.Items.Add("}");



        }
        public void quicksort(ListBox lstCode, Boolean tang)
        {
            lstCode.Items.Add("void QuickSort(int a[], int left, int right)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     int i, j, x;");
            lstCode.Items.Add("     x = a[(left + right) / 2]; "); //3
            lstCode.Items.Add("     i = left; j = right;");
            lstCode.Items.Add("     do");
            lstCode.Items.Add("     {");
            if (tang)
                lstCode.Items.Add("     while(a[i] < x) i++;");
            else
                lstCode.Items.Add("     while(a[i] > x) i++;");
            if (tang)
                lstCode.Items.Add("     while(a[j] > x) j--;");
            else
                lstCode.Items.Add("     while(a[j] < x) j--;");

            lstCode.Items.Add("         if(i <= j");
            lstCode.Items.Add("         { ");
            lstCode.Items.Add("             Swap(a[i], a[j]);"); //11
            lstCode.Items.Add("             i++ ; j--;");
            lstCode.Items.Add("         }");
            lstCode.Items.Add("       }");
            lstCode.Items.Add("       while(i <= j);");
            lstCode.Items.Add("       if(left < j)"); //16
            lstCode.Items.Add("         QuickSort(a, left, j);");
            lstCode.Items.Add("       if(i < right)"); //18
            lstCode.Items.Add("         QuickSort(a, i, right);");
            lstCode.Items.Add("}");
            lstCode.Items.Add("void Swap(int &a,int &b)  {");
            lstCode.Items.Add("     int temp = a;");
            lstCode.Items.Add("     a = b;");
            lstCode.Items.Add("     b=temp;");
            lstCode.Items.Add(" }");


        }
        public void insertionsort(ListBox lstCode, Boolean tang)
        {

            lstCode.Items.Add("void InsertionSort(int a[], int n)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("   int i, pos, x;");
            lstCode.Items.Add("   for (i = 1; i < n; i++)");
            lstCode.Items.Add("      {");
            lstCode.Items.Add("         x = a[i];");
            lstCode.Items.Add("         pos = i - 1;");
            if (tang)
                lstCode.Items.Add("         while ((pos >= 0) && (a[pos] > x))");
            else
                lstCode.Items.Add("         while ((pos >= 0) && (a[pos] < x))");
            lstCode.Items.Add("           {");
            lstCode.Items.Add("            a[pos + 1] = a[pos];");
            lstCode.Items.Add("            pos--;");
            lstCode.Items.Add("           }");
            lstCode.Items.Add("         a[pos + 1] = x;");
            lstCode.Items.Add("      }");
            lstCode.Items.Add(" }");

        }
        public void interchangesort(ListBox lstCode, Boolean tang)
        {
            lstCode.Items.Add("void InterchangeSort(int a[], int N)");
            lstCode.Items.Add("{");
            lstCode.Items.Add("     int i, j;");
            lstCode.Items.Add("     for (i = 0; i < N - 1; i++)");
            lstCode.Items.Add("         for (j = i + 1; j < N; j++)");
            lstCode.Items.Add("             if (a[j] < a[i])");
            lstCode.Items.Add("                 Swap(a[i], a[j]);");
            lstCode.Items.Add("}");
        }
    }
}

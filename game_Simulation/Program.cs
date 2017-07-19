using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_Simulation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            /*int w_min=30;
            Random r = new Random();
            double[] s = {0.01606, 0.05164, 0.11884, 0.19592, 0.23148, 0.19592, 0.11884, 0.05164, 0.01606, 0.003587};
            int[] n = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                n[i] = w_min+=60;

            KeyValuePair<int, Double>[] elements = new KeyValuePair<int, double>[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                //value i;
                KeyValuePair<int, double> k = new KeyValuePair<int, double>(n[i]+r.Next(60), s[i]);
                elements[i] = k;
            }
            KeyValuePair<int, double>[] res = Selection.getRandomWeigthedElements(elements, 1);
            Console.Write("[ ");
            for (int i=0;i<res.Length;i++)
                Console.Write(res[i].Key + " ");
            Console.WriteLine("]");*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Console.ReadKey();
            Application.Run(new Sim_View());
        }
    }
}

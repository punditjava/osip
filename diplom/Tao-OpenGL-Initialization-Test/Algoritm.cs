using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Tao_OpenGL_Initialization_Test
{
    class Algoritm
    { 
        private bool calculated = false;
        private bool mcalculated = false;
        private List<List<int>> final_graph;
        private Dictionary<int, int[]> graph;
        private Dictionary<int, List<int>> i_graph;
        private bool[] visited;
        private List<List<int>> strong_components;
        public float x_0, y_0, d, d_m;
        public float x1, x2, y1, y2;
        public int N, N_m;
        public int iter;
        public float alfa = -0.4f;
        public float beta = 0.1f;
        public int[] comp;
        public List<int> co;

        public double computingX(double x, double y)
        {
            //return (double)(x * x - y * y + alfa);
            return (double)(1 - 0.9f*(x * Math.Cos(computingt(x, y)) - y*Math.Sin(computingt(x, y))));
            //return (x - y) / Math.Sqrt((x - y) * (x - y) + (x + y) * (x + y));
            //double _x = x1 * x + y1 * y;
            //double _y = x2 * x + y2 * y;
            //return _x / Math.Sqrt(_x * _x + _y * _y);
        }
        public double computingY(double x, double y)
        {
            //return (double)(2 * x * y + beta);
            return (double)(1.2 * (x * Math.Sin(computingt(x, y)) + y * Math.Cos(computingt(x, y))));
            //return (x + y) / Math.Sqrt((x - y) * (x - y) + (x + y) * (x + y));
            //double _x = x1 * x + y1 * y;
            //double _y = x2 * x + y2 * y;
            //return _y / Math.Sqrt(_x * _x + _y * _y);
        }
        public double computingt(double x, double y)
        {
            return (double)(0.4f - 6/(1 + x*x + y*y));
        }

        public void calculate_mesure()
        {
            if (!calculated)
            {
                calculated = true;
                Make_graph();

                strong_components = kosaraju();
            }
            for (int i = 1; i < iter; i++)
            {
                int leangth = 0;
                foreach (List<int> le in strong_components)
                {
                    leangth += le.Count;
                }
                int[] graph_keys = new int[leangth];
                int k = 0;
                foreach (List<int> le in strong_components)
                {
                    foreach (int j in le)
                    {
                        graph_keys[k] = j;
                        k++;
                    }
                }
                Make_graph(graph_keys);
                strong_components = kosaraju();
            }
            List<int> comp = new List<int>();
            foreach (List<int> sc in strong_components)
            {
                foreach(int s in sc)
                {
                    comp.Add(s);
                }
            }
            calculated = false;
            this.comp = comp.ToArray();
            final_graph = strong_components;
            if (!mcalculated)
            {
                mcalculated = true;
                Make_graph_m();

                strong_components = kosaraju(true);

            }
            for (int i = 1; i < iter; i++)
            {
                int leangth = 0;
                foreach (List<int> le in strong_components)
                {
                    leangth += le.Count;
                }
                int[] graph_keys = new int[leangth];
                int k = 0;
                foreach (List<int> le in strong_components)
                {
                    foreach (int j in le)
                    {
                        graph_keys[k] = j;
                        k++;
                    }
                }
                Make_graph_m(graph_keys);
                Console.WriteLine("graph = " + graph.Count());
                strong_components = kosaraju(true);
                int la = 0;
                foreach (List<int> sc in strong_components)
                {
                    la += sc.Count();
                }
                Console.WriteLine(la);
            }
            List<int> comp_m = new List<int>();
            foreach (List<int> sc in strong_components)
            {
                foreach (int s in sc)
                {
                    comp_m.Add(s);
                }
            }

            Console.WriteLine(comp_m.Count);

        }

        private List<List<int>> kosaraju(bool maps=false)
        {
            invert_graph();
            int n;
            if (maps){
                n = N_m * N * N;
            }
            else
            {
                n = N * N;
            }
            visited = new bool[n + 1];
            foreach (int key in graph.Keys)
            {
                visited[key] = false;
            }
            List<List<int>> coms = new List<List<int>>();
            for (int i = 1; i < n + 1; i++)
            {
                if (graph.ContainsKey(i) && !visited[i])
                {
                    List<int> comp = new List<int>();
                    dfs1(i, ref comp);
                    coms.Add(comp);
                }
            }
            visited = new bool[n + 1];
            foreach (int key in graph.Keys)
            {
                visited[key] = false;
            }
            var components = new List<List<int>>();

            for (int i = coms.Count - 1; i >= 0; i--)
            {
                coms[i].Reverse();
                foreach (int v in coms[i])
                {
                    co = new List<int>();
                    dfs2(v);
                    if (co.Count > 1 || (co.Count == 1 && graph[co[0]].Contains(co[0])))
                    {
                        components.Add(co);
                    }
                }
            }
            return components;
        }

        private void dfs2(int v)
        {
            visited[v] = true;
            if (i_graph.ContainsKey(v))
            {
                foreach (int e in i_graph[v])
                {
                    if (!visited[e])
                    {
                        dfs2(e);
                    }
                }
                co.Add(v);
            }
        }

        private void dfs1(int i, ref List<int> comp)
        {
            visited[i] = true;
            foreach (int e in graph[i])
            {
                if (!visited[e])
                {
                    dfs1(e, ref comp);
                }
            }
            comp.Add(i);
        }

        private void invert_graph()
        {
            i_graph = new Dictionary<int, List<int>>();
            foreach (int key in graph.Keys)
            {
                foreach (int value in graph[key])
                {
                    if (i_graph.ContainsKey(value))
                    {
                        i_graph[value].Add(key);
                    }
                    else
                    {
                        i_graph.Add(value, new List<int> { key });
                    }
                }

            }
        }

        private int new_num(int old_num)
        {
            return 4 * N * ((old_num - 1) / N) + 2 * ((old_num - 1) % N) + 1;
        }

        private void Make_graph(int[] graph_keys = null)
        {
            if (graph_keys == null)
            {
                init_const();
                graph = new Dictionary<int, int[]>();
                for (int i = 1; i <= N * N; i += 1)
                {
                    graph[i] = null;
                }
            }
            else
            {
                int[] dots = new int[graph_keys.Length];

                int k = 0;
                foreach (int key in graph_keys)
                {
                    dots[k] = new_num(key);
                    k++;
                }
                N *= 2;
                int[] graph_verts = new int[4 * dots.Length];
                k = 0;
                foreach (int dot in dots)
                {
                    graph_verts[k] = dot;
                    k++;
                    graph_verts[k] = dot + 1;
                    k++;
                    graph_verts[k] = dot + N;
                    k++;
                    graph_verts[k] = dot + N + 1;
                    k++;
                }
                Dictionary<int, int[]> new_graph = new Dictionary<int, int[]>();
                foreach (int i in graph_verts)
                {
                    new_graph[i] = null;
                }
                graph = new_graph;
                d /= 2;
            }
            double y_n, x_n;
            foreach (int key in graph.Keys.ToList())
            {
                y_n = Math.Round(y_0 - (key - 1) / N * d, 4);
                x_n = Math.Round(x_0 + (key - 1) % N * d, 4);
                var hash = new HashSet<int>();
                for (int i = 1; i <= 40; i++)
                {
                    for (int j = 1; j <= 40; j++)
                    {
                        double x_i = x_n + j * 0.025f * d - d / 40;
                        double y_i = y_n - i * 0.025f * d - d / 40;

                        int l = get_nums(computingX(x_i, y_i), computingY(x_i, y_i));
                        if (l != -1)
                        {
                            hash.Add(l);
                        }
                    }
                }
                graph[key] = hash.ToArray();
            }

        }

        private int new_num_m(int old_num)
        {
            return 2 * N_m * ((old_num - 1) / N_m) + 2 * ((old_num - 1) % N_m) + 1;
        }

        private void Make_graph_m(int[] graph_keys = null)
        {
            if (graph_keys == null)
            {
                init_const_m();
                graph = new Dictionary<int, int[]>();
                foreach(int j in comp) { 
                    for (int i = 1; i <= 1; i += 1)
                    {
                        graph[j * 2] = null;
                        graph[j * 2 - 1] = null;
                    }
                }
            }
            else
            {
                int[] dots = new int[graph_keys.Length];

                int k = 0;
                foreach (int key in graph_keys)
                {
                    dots[k] = new_num_m(key);
                    k++;
                }
                N_m *= 2;
                int[] graph_verts = new int[2 * dots.Length];
                k = 0;
                foreach (int dot in dots)
                {
                    graph_verts[k] = dot;
                    k++;
                    graph_verts[k] = dot + 1;
                    k++;
                }
                Dictionary<int, int[]> new_graph = new Dictionary<int, int[]>();
                foreach (int i in graph_verts)
                {
                    new_graph[i] = null;
                }
                graph = new_graph;
                d_m /= 2;
            }
            double y_n, x_n, l_n, l1_i, l2_i;
            foreach (int key in graph.Keys.ToList())
            {
                int num_cell = (key - 1) / N_m  + 1;
                y_n = Math.Round(y_0 - (num_cell - 1) / N * d, 4);
                x_n = Math.Round(x_0 + (num_cell - 1) % N * d, 4);
                l_n = -1 + (key - 1) % (N_m / 2) * d_m;
                //double mbox = (N_m - 1) % (N_m / 2) * d_m;
                bool up = true;
                if (key > N_m * num_cell - N_m / 2)
                {
                    up = false;
                }
                var hash = new HashSet<int>();
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        double x_i = x_n + j * 0.2f * d - d / 10;
                        double y_i = y_n - i * 0.2f * d - d / 10;
                        int ind;
                        if (up)
                        {
                            l2_i = l_n + (5* (i - 1) + j) * 0.1f * d_m - d_m / 10;
                            l1_i = 1;
                            ind = get_nums_m(x_i, y_i, l1_i, l2_i);
                        }
                        else
                        {
                            l1_i = l_n + (5 * (i - 1) + j) * 0.1f * d_m - d_m / 10;
                            l2_i = 1;
                            ind = get_nums_m(x_i, y_i, l1_i, l2_i);
                        }
                        if (ind != -1)
                        {
                            hash.Add(ind);
                        }
                    }
                }
                graph[key] = hash.ToArray();
            }

        }



        private int get_nums_m(double x, double y, double l1, double l2)
        {
            double x_ikeda = computingX(x, y);
            double y_ikeda = computingY(x, y);

            if (Math.Abs(x_ikeda) > -x_0 || Math.Abs(y_ikeda) > y_0)
            {
                return -1;
            }
            int index = (int)((y_0 - y_ikeda) / d) * N + (int)((x_ikeda - x_0) / d) + 1;
            if (!comp.Contains(index))
            {
                return -1;
            }

            double cos_teta = Math.Cos(computingt(x, y));
            double sin_teta = Math.Sin(computingt(x, y));

            double square = (y * y + x * x + 1) * (y * y + x * x + 1);

            double d_xx = 54f / 5 * (x * x * sin_teta + x * y * cos_teta) / square - 0.9 * cos_teta;
            double d_xy = 54f / 5 * (x * y * sin_teta + y * y * cos_teta) / square + 0.9 * sin_teta;
            double d_yy = 72f / 5 * (x * y * cos_teta - y * y * sin_teta) / square + 1.2 * cos_teta;
            double d_yx = 72f / 5 * (x * x * cos_teta - x * y * sin_teta) / square + 1.2 * sin_teta;

            double new_l1 = d_xx * l1 + d_xy * l2;
            double new_l2 = d_yx * l1 + d_yy * l2;

            double max;
            if (Math.Abs(new_l1) > Math.Abs(new_l2))
            {
                max = new_l1;
            } else
            {
                max = new_l2;
            }

            new_l1 /= max;
            new_l2 /= max;

            int index_m;
            if (new_l1 == 1)
            {
                index_m = 1 + (index - 1) * N_m + (int)((new_l2 + 1) / d_m);
            }
            else
            {
                index_m = index * N_m - (int)((1 - new_l1) / d_m);
            }

            if (!graph.ContainsKey(index_m))
            {
                return -1;
            }

            return index_m;
        }




        private int get_nums(double x, double y)
        {
            if (Math.Abs(x) > -x_0 || Math.Abs(y) > y_0){
                return -1;
            }
            int index = (int)((y_0 - y) / d) * N + (int)((x - x_0) / d) + 1;
            if (!graph.ContainsKey(index))
            {
                return -1;
            }
            return index;
        }

        private void init_const() // Тут потом задам константы из формы
        {
            d = 0.5f;
            N = (int)(7 / d);
        }
        private void init_const_m() // Тут потом задам константы из формы
        {
            d_m = 2f;
            N_m = (int)(4 / d_m);
        }

    }
}

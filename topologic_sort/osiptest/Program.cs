using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MathNet.Numerics.LinearAlgebra;

namespace osiptest
{
    class Program
    {

        private static bool calculated = false;
        private static Dictionary<int, int[]> graph;
        private static Dictionary<int, List<int>> i_graph;
        private static bool[] visited;
        private static List<List<int>> strong_components;
        public static float x_0, y_0, d;
        public static int N;
        public static int iter;
        public static float alfa = -0.4f;
        public static float beta = 0.1f;
        public static float timer;
        public static float t;
        public static int n_ver;
        public static int n_lines;
        public static List<int> co;

        public static double computingX(double x, double y)
        {
            return (double)(0.75*x - x*x*x/3);
        }
        public static double computingY(double x, double y)
        {
            //return (double)(2 * x * y + beta);
            return (double)(0.5*y);

        }

        public static void calculate_mesure()
        {
            n_lines = 0;
            if (!calculated)
            {
                calculated = true;
                Make_graph();

                strong_components = kosaraju();
            }
            List<int> comp = new List<int>();
            foreach (List<int> sc in strong_components)
            {
                foreach (int s in sc)
                {
                    comp.Add(s);
                }
            }
            calculated = false;
            n_ver = graph.Keys.Count();
            foreach (int[] i in graph.Values)
            {
                n_lines += i.Length;
            }
            
        }

        private static List<List<int>> kosaraju()
        {
            //invert_graph();
            int n = N * N;
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
                    comp.Reverse();
                    coms.Add(comp);
                }
            }



            //visited = new bool[n + 1];
            //foreach (int key in graph.Keys)
            //{
            //    visited[key] = false;
            //}
            //var components = new List<List<int>>();

            //for (int i = coms.Count - 1; i >= 0; i--)
            //{
            //    coms[i].Reverse();
            //    foreach (int v in coms[i])
            //    {
            //        co = new List<int>();
            //        //Thread thread = new Thread(() => dfs2(v), 100000000);
            //        //thread.Start();
            //        dfs2(v);
            //        components.Add(co);
            //    }
            //}
            //foreach (int i in graph.Keys)
            //{
            //    if (graph[i].Contains(i))
            //    {

            //        components.Add(new List<int>{ i });
            //    }
            //}

            return coms;
        }

        private static void dfs2(int v)
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

        private static void dfs1(int i, ref List<int> comp)
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

        private static void invert_graph()
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

        private static int new_num(int old_num)
        {
            return 4 * N * ((old_num - 1) / N) + 2 * ((old_num - 1) % N) + 1;
        }

        private static void Make_graph(int[] graph_keys = null)
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
                for (int i = 1; i <= 20; i++)
                {
                    for (int j = 1; j <= 20; j++)
                    {
                        double x_i = x_n + j * 0.05f * d - d / 20;
                        double y_i = y_n - i * 0.05f * d - d / 20;

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

        private static int get_nums(double x, double y)
        {
            if (Math.Abs(x) > Math.Abs(x_0) || Math.Abs(y) > Math.Abs(y_0))
            {
                return -1;
            }
            int index = (int)((y_0 - y) / d) * N + (int)((x - x_0) / d) + 1;
            if (!graph.ContainsKey(index))
            {
                return -1;
            }
            return index;
        }

        private static void init_const() // Тут потом задам константы из формы
        {
            iter = 10;
            x_0 = -1.5f;
            y_0 = 1.5f;
            d = 0.125f;
            N = (int)(3 / d);
        }




        static void Main(string[] args)
        {
            calculate_mesure();

            Dictionary<int, float> valuePairs = new Dictionary<int, float>();

            float u = 1.1f;
            foreach (List<int> i in strong_components)
            {
                foreach(int j in i)
                {
                    valuePairs.Add(j, normalizevector(u));
                    u++;
                }

            }


            int a = 1;
            //foreach (List<int> key in strong_components)
            //{
            //    //Console.Write(key[^1] + " -> ");
            //    //if (key.Count == 1)
            //    //{

            //    //}
            //    //else
            //    //{
            //    for (int i = 0; i < key.Count; i++)
            //    {
            //        Console.WriteLine(key[i] + " ,");
            //    }
            //    //}
            //    //Console.WriteLine("");
            //    //a++;
            //}
            foreach (int i in graph.Keys)
            {
                Console.Write(valuePairs[i] + " -> ");
                foreach (int j in graph[i])
                {
                    Console.Write(valuePairs[j] + " ,");
                }
                Console.WriteLine("");
            }

        }

        private static float normalizevector(float u)
        {
            return (float)Math.Sqrt(u);
        }
    }
}

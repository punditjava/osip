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
        private Dictionary<int, int[]> graph;
        private Dictionary<int, List<int>> i_graph;
        private bool[] visited;
        private List<List<int>> strong_components;
        public float x_0, y_0, d;
        public float x1, x2, y1, y2;
        public int N;
        public int iter;
        public float alfa = -0.4f;
        public float beta = 0.1f;
        public float timer;
        public float t;
        public int n_ver;
        public int n_lines;
        public int[] comp;
        public List<int> co;

        public double computingX(double x, double y)
        {
            //return (double)(x * x - y * y + alfa);
            return (double)(0.99 - 0.9f*(x * Math.Cos(computingt(x, y)) - y*Math.Sin(computingt(x, y))));
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
            n_lines = 0;
            Stopwatch time = new Stopwatch();
            time.Start();
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
            time.Stop();
            timer = time.Elapsed.Seconds + ((float)time.Elapsed.Milliseconds / 1000);

            n_ver = 0;
            foreach(List<int> i in strong_components)
            {
                n_ver += i.Count();
            }

            foreach (int[] i in graph.Values)
            {
                n_lines += i.Length;
            }
            this.comp = comp.ToArray();
        }

        private List<List<int>> kosaraju()
        {
            invert_graph();
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
                    //Thread thread = new Thread(() => dfs2(v), 100000000);
                    //thread.Start();
                    dfs2(v);
                    if (co.Count > 1 || (co.Count == 1 && graph[co[0]].Contains(co[0])))
                    {
                        components.Add(co);
                    }
                }
            }
            //foreach (int i in graph.Keys)
            //{
            //    if (graph[i].Contains(i))
            //    {

            //        components.Add(new List<int>{ i });
            //    }
            //}
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
    }
}

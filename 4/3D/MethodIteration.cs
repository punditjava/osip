using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Tao_OpenGL_Initialization_Test
{
    class MethodIteration : ICalcuteMethods
    {
        private bool calculated = false;
        private Dictionary<int, int[]> graph;
        private Dictionary<int, List<int>> i_graph;
        private bool[] visited;
        private List<List<int>> strong_components;
        private float x_0, y_0, d;
        private int N;
        private int iter;
        private List<int> co;
        private IFormula formula;

        internal IFormula Formula { get => formula; set => formula = value; }
        public int N1 { get => N; set => N = value; }
        public float X_0 { get => x_0; set => x_0 = value; }
        public float D { get => d; set => d = value; }
        public float Y_0 { get => y_0; set => y_0 = value; }
        public Dictionary<int, int[]> Graph { get => graph; set => graph = value; }

        public MethodIteration(IFormula formula)
        {
            this.Formula = formula;
        }


        public List<int> calculate()
        {
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
                foreach (int s in sc)
                {
                    comp.Add(s);
                }
            }
            calculated = false;
            time.Stop();
            return comp;
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
                for (int i = 1; i <= 20; i++)
                {
                    for (int j = 1; j <= 20; j++)
                    {
                        double x_i = x_n + j * 0.05f * d - d / 20;
                        double y_i = y_n - i * 0.05f * d - d / 20;

                        int l = get_nums(Formula.computingX(x_i, y_i), Formula.computingY(x_i, y_i));
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

        private void init_const() // Тут потом задам константы из формы
        {
            iter = 6;
            x_0 = -3.5f;
            y_0 = 3.5f;
            d = 0.5f;
            N = (int)(7 / d);
        }
    }
}

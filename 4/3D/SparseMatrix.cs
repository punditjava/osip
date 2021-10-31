using System;
using System.Collections.Generic;
using System.Linq;

namespace osiptest
{
    class SparseMatrix
    {
        private int[][] sparse_array;
        private Dictionary<int, List<int>> i_graph;
        private double[][] values;
        private Dictionary<int, int[]> gr;

        public SparseMatrix(Dictionary<int, int[]> graph)
        {
            this.sparse_array = sparseFromGraph(graph);
        }

        private int[][] sparseFromGraph(Dictionary<int, int[]> graph)
        {
            gr = graph;
            i_graph = new Dictionary<int, List<int>>();
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            int u = 0;
            foreach(int g_key in graph.Keys)
            {
                valuePairs.Add(g_key, u);
                u++;
            }
            foreach (int key in graph.Keys)
            {
                foreach (int value in graph[key])
                {
                    if (i_graph.ContainsKey(valuePairs[value]))
                    {
                        i_graph[valuePairs[value]].Add(valuePairs[key]);
                    }
                    else
                    {
                        i_graph.Add(valuePairs[value], new List<int> { valuePairs[key] });
                    }
                }
            }
            int[][] array = new int[graph.Count][];
            int s = 0;
            foreach (int[] v in graph.Values)
            {
                array[s] = Enumerable.Range(0, v.Length).Select(delegate (int i) { return valuePairs[v[i]]; }).ToArray();
                s++;
            }
            values = new double[array.Length][];
            for (int i=0; i < array.Length; i++)
            {
                values[i] = Enumerable.Repeat(1d, array[i].Length).ToArray();
            }
            return array;
        }

        public Dictionary<int, double> get_result()
        {
            var rand = new Random();
            Dictionary<int, double> result = new Dictionary<int, double>();
            int k = 0;
            foreach(int g in gr.Keys)
            {
                double sum = 0;
                for(int i=0; i< values[k].Length; i++)
                {
                    sum += values[k][i];
                }
                result.Add(g, sum + rand.Next(0, 8) - 8);
                k++;
            }
            return result;
        }
    }
}

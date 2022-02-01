using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace osiptest
{
    class SparseMatrix
    {
        public int[][] sparse_array;
        private VectorBuilder<double> V = Vector<double>.Build;
        private Dictionary<int, int[]> gr;
        Dictionary<int, int> valuePairs;

        public SparseMatrix(Dictionary<int, int[]> graph)
        {
            this.sparse_array = sparseFromGraph(graph);
        }

        private int[][] sparseFromGraph(Dictionary<int, int[]> graph)
        {
            gr = graph;
            Dictionary <int, List<int>> i_graph = new Dictionary<int, List<int>>();
            valuePairs = new Dictionary<int, int>();
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
            int k = 0;
            foreach (List<int> i in i_graph.Values)
            {
                array[k] = i.ToArray();
                k++;
            }
            return array;
        }

        internal Vector<double> LeftMultiply(Vector<double> x)
        {
            Vector<double> vs = V.Dense(sparse_array.Length);
            for (int i = 0; i < sparse_array.Length; i++)
            {
                if (sparse_array[i] != null) { 
                    foreach (int j in sparse_array[i])
                    {
                        vs[i] += x[j];
                    }
                }
            }

            return vs;
        }

        public override string ToString()
        {
            for (int i = 0; i < sparse_array.Length; i++)
            {   
                Console.WriteLine(sparse_array[i]);
            }

            return "";
        }
        internal int columnCount()
        {
            return sparse_array.Length;
        }

        public double[] get_result(Vector<double> v, double lambda)
        {
            //Dictionary<int, double> result = new Dictionary<int, double>();
            //int k = 0;
            //List<int> keys = new List<int>();
            
            //foreach(int ke in gr.Keys){
            //    keys.Add(ke);
            //}
            double[] mera = new double[v.Count];
            double sum = 0;
            for (int i = 0; i < v.Count; i++)
            {
                //mera[i] = 0;
                //foreach (int j in gr[keys[i]])
                //{
                mera[i] = v[i]; //* v[i];
                sum += v[i];
                //}
            }
            //Console.WriteLine(sum);
            return mera;
        }


    }
}

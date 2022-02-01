using System;
using System.Collections.Generic;
using System.Linq;

namespace osiptest
{
    class SparseMatrixBal
    {
        private int[][] sparse_array;
        private Dictionary<int, List<int>> i_graph;
        private double[][] values;
        private Dictionary<int, int[]> gr;
        public double entropy;

        public SparseMatrixBal(Dictionary<int, int[]> graph)
        {
            this.sparse_array = sparseFromGraph(graph);
        }

        private int[][] sparseFromGraph(Dictionary<int, int[]> graph)
        {
            gr = graph;
            i_graph = new Dictionary<int, List<int>>();
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            int u = 0;
            foreach (int g_key in graph.Keys)
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
            for (int i = 0; i < array.Length; i++)
            {
                values[i] = Enumerable.Repeat(1d, array[i].Length).ToArray();
            }
            return array;
        }

        public void transform(int index)
        {
            Dictionary<int, int> numbers_col;
            double sum_col = get_sum_col(index, out numbers_col); //столбец
            double sum_row = get_sum_row(index); //строка
            if (sum_col == 0 || sum_row == 0)
            {

                for (int i = 0; i < values[index].Length; i++)
                {
                    values[index][i] = 0;
                }

                foreach (KeyValuePair<int, int> keyValue in numbers_col)
                {
                    values[keyValue.Key][keyValue.Value] = 0;
                }
            }
            else
            {

                for (int i = 0; i < values[index].Length; i++)
                {
                    if (index != i)
                    {
                        values[index][i] *= Math.Sqrt(sum_col / sum_row);
                    }
                }

                foreach (KeyValuePair<int, int> keyValue in numbers_col)
                {
                    if (keyValue.Key != keyValue.Value)
                    {
                        values[keyValue.Key][keyValue.Value] *= Math.Sqrt(sum_row / sum_col);
                    }
                }
            }
        }

        private double get_sum_row(int index)
        {
            double sum = 0;
            int k = 0;
            foreach (int v in sparse_array[index])
            {
                if (v != index)
                {
                    sum += values[index][k];
                }
                k++;
            }

            return sum;
        }

        private double get_sum_col(int index, out Dictionary<int, int> numbers_col)
        {
            double sum = 0;
            numbers_col = new Dictionary<int, int>();
            if (i_graph.ContainsKey(index))
            {
                foreach (int i in i_graph[index])
                {
                    if (i != index)
                    {
                        for (int j = 0; j < sparse_array[i].Length; j++)
                        {
                            if (sparse_array[i][j] == index)
                            {
                                sum += values[i][j];
                                numbers_col.Add(i, j);

                            }
                        }
                    }
                }
            }
            return sum;
        }

        public void normilize()
        {
            double sum = get_sum();

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values[i].Length; j++)
                {
                    values[i][j] /= sum;
                }
            }
        }

        public double get_sum()
        {
            double sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                Array.ForEach(values[i], delegate (double s) { sum += s; });
            }

            return sum;

        }

        public override string ToString()
        {
            for (int i = 0; i < sparse_array.Length; i++)
            {
                Console.WriteLine(sparse_array[i]);
            }

            return "";
        }
        public int columnCount()
        {
            return sparse_array.Length;
        }
        public double get_first_num()
        {
            return values[0][0];
        }
        public double get_all()
        {
            double sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values[i].Length; j++)
                {
                    sum += values[i][j];
                }
            }
            return sum;
        }

        public Dictionary<int, double> get_result()
        {
            Dictionary<int, double> result = new Dictionary<int, double>();
            int k = 0;
            foreach (int g in gr.Keys)
            {
                double sum = 0;
                for (int i = 0; i < values[k].Length; i++)
                {
                    sum += values[k][i];
                }
                result.Add(g, sum);
                k++;
            }
            metric_entropy(result);
            return result;
        }
        private void metric_entropy(Dictionary<int, double>  result)
        {
            double all_sum = 0;
            double all_str = 0;
            for (int i = 0; i < values.Length; i++)
            {
                double this_str = 0;
                foreach (double j in values[i])
                {
                    if (j != 0)
                    {
                        all_str += j * Math.Log(j);
                    }
                    this_str += j;
                }
                if (this_str != 0)
                {
                    all_sum += this_str * Math.Log(this_str);
                }
            }
            entropy = all_sum - all_str;
        }
    }
}

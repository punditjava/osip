using System;

namespace osiptest
{
    class Balance
    {
        private double lambda;
        private readonly SparseMatrixBal M;

        public Balance(SparseMatrixBal M, double lambda)
        {
            this.M = M;
            this.lambda = lambda;
        }

        public System.Collections.Generic.Dictionary<int, double> balancing()
        {

            double last_value;
            double this_value;
            M.normilize();
            do
            {
                for (int i = 0; i < M.columnCount(); i++)
                {
                    M.transform(i);
                }
                last_value = M.get_all();
                M.normilize();
                this_value = M.get_all();
            } while (Math.Abs(last_value - this_value) > lambda);

            return M.get_result();
        }
        public double get_M()
        {
            return M.entropy;
        }
    }
}

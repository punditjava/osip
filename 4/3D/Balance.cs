using System;

namespace osiptest
{
    class Balance
    {
        private double lambda;
        private readonly SparseMatrix M;

        public Balance(SparseMatrix M, double lambda)
        {
            this.M = M;
            this.lambda = lambda;
        }

        public System.Collections.Generic.Dictionary<int, double> balancing()
        {
            return M.get_result();
        }
    }
}

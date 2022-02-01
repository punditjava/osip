using MathNet.Numerics.LinearAlgebra;
using System;

namespace osiptest
{
    class EigenValues
    {
        private readonly VectorBuilder<double> V = Vector<double>.Build;
        private readonly SparseMatrix M;

        public EigenValues(SparseMatrix M)
        {
            this.M = M;
        }

        public void Power(double tolerance, out Vector<double> x,
            out double lambda)
        {
            int n = M.columnCount();
            x = V.Dense(n);
            double delta;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = random.NextDouble();
            }

            do
            {
                Vector<double> temp = x;

                x = M.LeftMultiply(x);
                x = x.Normalize(2);
                //if (temp.DotProduct(x) < 0)
                //    x = -x;
                Vector<double> dx = temp - x;
                delta = dx.Norm(2);
            }
            while (delta > tolerance);
            x = x.Normalize(1);
            lambda = x.DotProduct(M.LeftMultiply(x)) / (x.DotProduct(x));
        }
    }
}

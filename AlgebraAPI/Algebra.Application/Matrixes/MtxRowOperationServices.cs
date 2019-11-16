using Algebra.Application.DTOs;

namespace Algebra.Application.Matrixes
{
    public class MtxRowOperationServices : IMtxRowOperationServices
    {
        public MatrixRowOperation OperateRows()
        {
            return new MatrixRowOperation { Result = "Yey! success" };
        }
    }
}

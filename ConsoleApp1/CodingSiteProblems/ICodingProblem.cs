using System;
using System.Collections.Generic;
using System.Text;

namespace BlakeIshoyAlgorithms.CodingSiteProblems
{
    public interface ICodingProblem<T>
    {
        public T Execute();
    }
}

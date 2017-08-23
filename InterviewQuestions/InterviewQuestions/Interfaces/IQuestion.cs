using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Interfaces
{
    public interface IQuestion
    {
        /// <summary>
        /// 作答
        /// </summary>
        void Answer();
        /// <summary>
        /// 显示题目
        /// </summary>
        void Show();
    }
}

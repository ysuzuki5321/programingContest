using Dapper;
using Remainder.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public partial class ProblemBase
    {
        private List<Problem> GetProblems()
        {
            var sql = @"
                select 
                    p.id,
                    p.scheduleid,
                    p.problemtext,
                    a.id aid,
                    a.problemid,
                    a.seq,
                    a.answertext
                from 
                    problem p
                    left join answer a
                        on p.id = a.problemid
                where
                    p.scheduleid = @scheduleid
                order by 
                    a.problemid, a.seq   
            ";

            var problems = new List<Problem>();
            var param = new DynamicParameters(new { scheduleid = schedule.Id });
            DataBase.Connection.Query<Problem, Answer, Problem>(
                sql,
                (problem, answer) =>
                {
                    if (problems.Count == 0 || problems.Last().Id != problem.Id)
                    {
                        problems.Add(problem);
                    }
                    if (answer != null)     
                        problems.Last().Answers.Add(answer);
                    return problem;
                },
                param, splitOn: "aid");
            return problems;
        }

    }
}

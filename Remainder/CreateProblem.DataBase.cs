using Dapper;
using Remainder.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public partial class CreateProblem
    {
        private void UpdateProblem(Problem p)
        {
            var sql = @"
                update problem set
                    problemtext = @text
                where
                    id = @id
            ";
            var param = new DynamicParameters(new { id = p.Id,
                text = p.ProblemText});
            
            DataBase.Connection.Execute(sql, param);
        }

        private void DeleteProblem(int id)
        {
            var sql = @"
                delete from problem where id = @id
            ";
            var param = new DynamicParameters(new { id = id });
            DataBase.Connection.Execute(sql, param);
        }

        private void DeleteAnswers(int problemId)
        {
            var sql = @"
                delete from answer where problemid = @problemId
            ";
            var param = new DynamicParameters(new { problemId = problemId });
            DataBase.Connection.Execute(sql, param);
        }

        private void InsertProblem()
        {
            var scheduleId = schedule.Id;
            var problem = ProblemText.Text;
            var sql = @"
                insert into problem
                values (@scheduleid,@problem);
            ";
            var param = new DynamicParameters(
                new { scheduleId,problem});
            DataBase.Connection.Execute(sql, param);
        }

        private int GetLatestProblemId()
        {
            if (Current.Id != -1)
                return Current.Id;

            var sql = @"
                select max(id) from problem where scheduleid = @scheduleid
            ";
            var scheduleId = schedule.Id;            
            var param = new DynamicParameters(
                new { scheduleId});
            return DataBase.Connection.ExecuteScalar<int>(sql, param);
        }

        private void InsertAnswers()
        {
            var problemId = GetLatestProblemId();
            var sql = @"
                insert into answer 
                values (@problemid,@seq,@answer);
            ";

            var param = new DynamicParameters(new { problemId });
            for (int i = 0; i < AnswerList.Items.Count; i++)
            {
                param.AddDynamicParams(new { seq = i, answer = AnswerList.Items[i] });
                DataBase.Connection.Execute(sql, param);
            }
        }


    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public partial class Remainder
    {
        private void ExpandData(int i)
        {
            var data = TodayGrid.Rows[i].DataBoundItem as Schedule;

            // 1週分増やしたい
            var expandInterval = data.Interval + 7;
            // interval / expandInterval   
            var nextstart = interval % expandInterval;
            UpdateStartAndInterval(data, expandInterval, nextstart);
            TodayGrid.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
            Refresh();
        }

        private void NextWeek(int i)
        {
            var data = TodayGrid.Rows[i].DataBoundItem as Schedule;

            // 一週間先送り
            var nextstart = (data.Start + 7) % data.Interval;
            UpdateStartAndInterval(data, data.Interval, nextstart);
            Refresh();
        }

        private void Tommorow(int i)
        {
            var data = TodayGrid.Rows[i].DataBoundItem as Schedule;

            // 明日先送り
            var nextstart = (data.Start + 1) % data.Interval;
            UpdateStartAndInterval(data, data.Interval, nextstart);
            Refresh();
        }

        private void UpdateStartAndInterval(Schedule data, int interval, int start)
        {
            var param = CreateParam(data);
            param.AddDynamicParams(new
            {
                interval = interval,
                start = start,
                url = default(string)
            });
            data.Interval = interval;
            data.Start = start;
            DataBase.Connection.Execute(DataUpdateSql(), param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        private void UpdateSchedule(Schedule data)
        {
            var param = CreateParam(data);
            param.AddDynamicParams(new
            {
                description = data.Discription,
                url =data.Url
            });
            DataBase.Connection.Execute(DataUpdateSql(), param);
        }

        private void DoneSchedule(Schedule data)
        {
            var param = CreateParam(data);
            param.AddDynamicParams(new
            {
                latestDate = DateTime.Now.Date
            });
            DataBase.Connection.Execute(DoneSql(),param);
        }

        private DynamicParameters CreateParam(Schedule data)
        {
            return new DynamicParameters(
            new
            {
                id = data.Id,
                interval = data.Interval,
                start = data.Start,
                description = data.Discription
            });
        }
    }
}

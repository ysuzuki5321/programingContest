﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    public partial class Remainder
    {
        private string DataUpdateSql()
        {
            return @"
                update schedule
                set
                    discription = @description,
                    interval = @interval,
                    url = isnull(@url,url),
                    start = @start
                where
                    id = @id
            ";
        }

        private string DoneSql()
        {
            return @"
                update schedule
                set
                    latestDate = @latestDate
                where
                    id = @id
            ";
        }

        private string InsertSql()
        {
            return @"
                insert into schedule
                (discription,url,interval,start,priority)
                values (@discription,@url,@interval,@start,@priority)
            ";
        }
    }
}

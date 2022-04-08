﻿using OrmTest.UnitTest.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTest
{
    public class UCustom09
    {
        public static void Init()
        {
            var db = NewUnitTest.Db;
            var list=db.Queryable<Order>()
               .GroupBy(x => new { CreateTime = x.CreateTime.ToString("yyyy-MM"),x.Name })
                .Select(x => new { CreateTime =  x.CreateTime.ToString("yyyy-MM") }).ToList();
            db.CodeFirst.InitTables<Unitadfaint21>();
            db.Insertable(new Unitadfaint21() { id = 1 , id2=22 }).ExecuteCommand();
            var list2 = db.Queryable<Unitadfaint21>().ToList();
        }

        public class Unitadfaint21
        {
            [SugarColumn(ColumnDataType ="int")]
            public long? id { get; set; }
            [SugarColumn(ColumnDataType = "int")]
            public long id2 { get; set; }
        }
        public class Unitasfa1sadfa
        {
            [SugarColumn(IsPrimaryKey = true)]
            public Guid Id { get; set; }
            [SugarColumn(IsNullable = true)]
            public bool ItemId { get; set; }
 
        }

     
    }
}

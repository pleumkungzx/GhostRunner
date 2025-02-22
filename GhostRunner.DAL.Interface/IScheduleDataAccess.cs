﻿using GhostRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRunner.DAL.Interface
{
    public interface IScheduleDataAccess
    {
        IList<Schedule> GetAll(long projectId);

        Schedule Get(String scheduleId);

        Schedule Insert(Schedule schedule);

        Boolean Update(String scheduleId, String type);

        Boolean Delete(String scheduleId);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using STOnline.DAL.Interfaces.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace STOnline.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository SQLCategoryRepository { get; }
        IOrderRepository SQLOrderRepository { get; }
        IClientRepository SQLClientRepository { get; }
        IRepairRepository SQLRepairRepository { get; }
        IWorkerRepository SQLWorkerRepository { get; }
        IWorkerCategoryRepository SQLWorkerCategoryRepository { get; }
        void Complete();
    }
}

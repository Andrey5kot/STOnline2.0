﻿using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAllWorkers();
        Task<Worker> GetWorkerById(int Id);
        Task<Worker> AddWorker(Worker worker);
        Task<Worker> UpdateWorker(Worker worker, object obj);
        Task<int> DeleteWorker(Worker worker);
    }
}

﻿using Budget.Common;
using Budget.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Service.Common
{
    public interface IExpenseService
    {
        Task<List<Expense>> GetAllAsync(Paging pager, Sorting sorting);
        Task<Expense> GetByIdAsync(string id);
        Task<int> PostAsync(Expense expenseFromBody);
        Task<bool> DeleteByIdAsync(string id);
        Task<bool> UpdateByIdAsync(string id, Expense newExpense);


    }
}

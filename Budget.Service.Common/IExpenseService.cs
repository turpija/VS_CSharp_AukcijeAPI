﻿using Budget.Common;
using Budget.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagedList;

namespace Budget.Service.Common
{
    public interface IExpenseService
    {
        Task<List<CategoryDTO>> GetCategoriesAsync();
        Task<ExpenseReturnDTO> GetAllAsync(Paging pager, Sorting sorting, Filtering filtering);
        Task<ExpenseDTO> GetByIdAsync(Guid id);
        Task<int> PostAsync(ExpenseDTO expenseFromBody);
        Task<bool> DeleteByIdAsync(Guid id);
        Task<bool> UpdateByIdAsync(Guid id, ExpenseDTO newExpense);


    }
}

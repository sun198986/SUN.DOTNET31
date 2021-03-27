using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.EFCore;
using System.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace System.Repasitory.Impl
{

    public class CompanyRepository : ICompanyRepository
    {
        private readonly MSDBContext _dbContext;
        public CompanyRepository(MSDBContext mSDBContext)
        {
            this._dbContext = mSDBContext;
        }

        public async Task<IEnumerable<CompanyExtend>> GetCompany()
        {
            //var list = _dbContext.Companies.AsQueryable()
            //    .GroupJoin(_dbContext.Employees, a => new { a.CompanyId }, b => new { b.CompanyId }, (c, bs) =>
            //    new { Company = c, EmployeeName = string.Join(",",bs.Select(p=>p.EmployeeName)) })
            //    //.SelectMany(p => p.Employees.DefaultIfEmpty(), (a, b) => new
            //    //{
            //    //    Company = a.Company,
            //    //    Employees = a.Employees.Count(),
            //    //    Employee = b
            //    //})
            //    //;
            //    ;


            //var res =
            //    _dbContext.Companies;
            //.Include(p => p.Employees)
            //.GroupJoin(_dbContext.Employees, a => a.CompanyId, b => b.CompanyId, (a, b) => new { Company = a, Employees = b.DefaultIfEmpty() });
            //.SelectMany(P => P.Employees.DefaultIfEmpty(), (a, b) => new
            //{
            //    Company = a.Company,
            //    EmployeeId = b.EmployeeId,
            //    EmployeeCount = a.Employees.Count()
            //});

            //var res1 = await res.Select(p => new CompanyExtend()
            //{
            //    CompanyName = p.CompanyName,
            //    EmployeeName= string.Join(",", p.Employees.AsQueryable().Select(p=>p.EmployeeName)),
            //    //EmployeeCount = p.EmployeeCount
            //    EmployeeCount = p.Employees.Count(),
            //    //EmployeeName= string.Join(",", p.Employees.Select(p => p.EmployeeName))
            //    Employees = p.Employees.Select(x=>new Employee { EmployeeName = x.EmployeeName})
            //})
            //.ToListAsync();


            var list = from company in _dbContext.Companies
                       //let employees = _dbContext.Employees.Where(p=>p.CompanyId==company.CompanyId).Select(p=>p.EmployeeName).AsQueryable()
                       select new CompanyExtend
                       {
                           CompanyName = company.CompanyName,
                           EmployeeName = string.Join(',', company.Employees.Select(p=>p.EmployeeName))
                           // EmployeeName = string.Join(',',employees)
                       };

            var res1 = await list.ToListAsync();
            return res1;
        }
    }
}

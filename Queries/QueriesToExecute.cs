using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil4Bonus.Queries
{
    public static class QueriesToExecute
    {
        public static string ShowAllEmpQuery = @"SELECT * FROM tblEmployees";
        public static string UpdateEmpSalaryBy5Per = @"update tblEmployees set Salary = Salary*1.05 where DATEDIFF(YEAR,StartDate,getdate())>5";
        public static string RunQuery3b = @"select tblWorkResources.ResourceID, tblResources.Description, tblResources.CostPrice, count(tblMissionResources.ResourceID) as NumOfMission
    from tblWorkResources inner join tblResources on tblWorkResources.ResourceID = tblResources.ResourceID left join tblMissionResources on tblMissionResources.ResourceID = tblResources.ResourceID
    where tblWorkResources.ResourceType = 'human' and tblWorkResources.QuantityAvailable > 4
    group by tblWorkResources.ResourceID,tblResources.Description,tblResources.CostPrice
UNION
    select tblMaterialResources.ResourceID, tblResources.Description, tblResources.CostPrice, count(tblMissionResources.ResourceID) as NumOfMission
    from tblMaterialResources inner join tblResources on tblMaterialResources.ResourceID = tblResources.ResourceID left join tblMissionResources on tblMissionResources.ResourceID = tblResources.ResourceID
    where tblMaterialResources.UnitMeasure = 'kg' and tblMaterialResources.Supplier = (select SupplierID
        from tblSuppliers
        where SupplierName = 'neviot')
    group by tblMaterialResources.ResourceID, tblResources.Description,tblResources.CostPrice";
        public static string RunQuery4b = @"select tblProjectMissions.Responsible, FirstName +' '+LastName AS FullName, Salary, (DATEDIFF(year,tblEmployees.StartDate,getdate())) as Seniority, count(Responsible) as NumOfMission
from tblProjectMissions inner join tblEmployees on tblEmployees.EmpID =tblProjectMissions.Responsible 
left outer join tblProjects on tblProjectMissions.Responsible = tblProjects.ProjectManager
where tblProjects.ProjectManager is null
group by tblProjectMissions.Responsible,FirstName,LastName,tblEmployees.StartDate,Salary";
        public static string Query2MissionByEmpId(string empId)
        {
            string ShowEmpMissionsById = $" EXEC numbOfMissionEncha @EmpID = {empId};";
            return ShowEmpMissionsById;
        }
        public static string SearchEmpById(int empId)
        {
            string empsById = $"SELECT EmpID,(FirstName + ' ' + LastName) as FullName, Salary, (DATEDIFF(YEAR, StartDate, GETDATE())) as Senority FROM tblEmployees WHERE EmpID = {empId}";
            return empsById;
        }
    }
}

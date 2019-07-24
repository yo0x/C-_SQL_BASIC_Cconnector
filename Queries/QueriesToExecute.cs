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
        public static string RunQuery3b = @"select tblWorkResources.ResourceID, tblResources.Description,tblResources.CostPrice,count(tblMissionResources.ResourceID) as NumOfMissionfrom tblWorkResources inner join tblResources ontblWorkResources.ResourceID = tblResources.ResourceIDleft join tblMissionResources ontblMissionResources.ResourceID = tblResources.ResourceIDwhere tblWorkResources.ResourceType = ' אנשים' andtblWorkResources.QuantityAvailable > 4group by tblWorkResources.ResourceID,tblResources.Description,tblResources.CostPriceUNIONselect tblMaterialResourcess.ResourceID, tblResources.Description,tblResources.CostPrice,count(tblMissionResources.ResourceID) as NumOfMissionfrom tblMaterialResourcess inner join tblResources ontblMaterialResourcess.ResourceID = tblResources.ResourceIDleft join tblMissionResources ontblMissionResources.ResourceID = tblResources.ResourceIDwhere tblMaterialResourcess.UnitMeasure = 'kg' andtblMaterialResourcess.Supplier = (select SupplierIDfrom tblSupplierswhere SupplierName = 'Bendak')group by tblMaterialResourcess.ResourceID,tblResources.Description,tblResources.CostPric";
        public static string RunQuery4b = @"selectdistincttblProjectMissions.Responsible,FirstName +' '+LastNameASFullName,Salary,(DATEDIFF(year,tblEmployees.StartDate,getdate()))asSeniority,count(Responsible)asNumOfMissionfromtblProjectMissions innerjointblEmployeesontblEmployees.EmpID =tblProjectMissions.ResponsibleleftouterjointblProjects onResponsible =ProjectManagerwheretblProjects.ProjectManager isnullgroupbytblProjectMissions.Responsible,FirstName,LastName,tblEmployees.StartDate,Salary";
        public static string Query2MissionByEmpId(string empId)
        {
            string ShowEmpMissionsById = $" EXEC numbOfMissionEncha EmpName=\"{empId}\" ";
            return ShowEmpMissionsById;
        }

    }
}

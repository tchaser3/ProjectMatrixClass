/* Title:           Project Matrix Class
 * Date:            9-14-2020
 * Author:          Terry Holmes
 * 
 * Description:     This is used for the Project Matrix */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProjectMatrixDLL
{
    public class ProjectMatrixClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ProjectMatrixDataSet aProjectMatrixDataSet;
        ProjectMatrixDataSetTableAdapters.projectmatrixTableAdapter aProjectMatrixTableAdapter;

        InsertProjectMatrixEntryTableAdapters.QueriesTableAdapter aInsertProjectMatrixTableAdapter;

        UpdateProjectMatrixAssignedProjectIDEntryTableAdapters.QueriesTableAdapter aUpdateProjectMatrixAssignedProjectIDTableAdapter;

        FindProjectMatrixByAssignedProjectIDDataSet aFindProjectMatrixByAssignedProjectIDDataSet;
        FindProjectMatrixByAssignedProjectIDDataSetTableAdapters.FindProjectMatrixByAssignedProjectIDTableAdapter aFindProjectMatrixByAssignedProjectIDTableAdapter;

        FindProjectMatrixByCustomerProjectIDDataSet aFindProjectMatrixByCustomerProjectIDDataSet;
        FindProjectMatrixByCustomerProjectIDDataSetTableAdapters.FindProjectMatrixByCustomerProjectIDTableAdapter aFindProjectMatrixByCustomerProjectIDTableAdapter;

        RemoveDuplicateProjectMatrixTransactionEntryTableAdapters.QueriesTableAdapter aRemoveDuplicateProjectMatrixTransactionTableAdapter;

        FindDuplicateProjectMatrixDataSet aFindDuplicateProjectMatrixDataSet;
        FindDuplicateProjectMatrixDataSetTableAdapters.FindDuplicateProjectMatrixTableAdapter aFindDuplicateProjectMatrixTableAdapter;

        FindProjectMatrixByProjectIDDataSet aFindProjectMatrixByProjectIDDataSet;
        FindProjectMatrixByProjectIDDataSetTableAdapters.FindProjectMatrixByProjectIDTableAdapter aFindProjectMatrixByProjectIDTableAdapter;

        FindProjectMatrixByGreaterDateDataSet aFindProjectMatrixByGreaterDateDataSet;
        FindProjectMatrixByGreaterDateDataSetTableAdapters.FindProjectMatrixByGreaterDateTableAdapter aFindProjectMatrixByGreaterDateTableAdapter;

        ProjectLastDateDataSet aProjectLastDateDataSet;
        ProjectLastDateDataSetTableAdapters.projectlastdateTableAdapter aProjectLastDateTableAdapter;

        InsertProjectLastDateEntryTableAdapters.QueriesTableAdapter aInsertProjectLastDateTableAdapter;

        UpdateProjectLastDateEntryTableAdapters.QueriesTableAdapter aUpdateProjectLastDateTableAdapter;

        UpdateProjectMatrixCustomerProjectIDEntryTableAdapters.QueriesTableAdapter aUpdateProjectMatrixCustomerProjectIDTableAdapter;

        UpdateProjectMatrixItemsEntryTableAdapters.QueriesTableAdapter aUpdateProjectMatrixItemsTableAdapter;

        FindProjectMatrixByCustomerAssignedIDForEmailDataSet aFindProjectMatrixByCustomerAssignedIDForEmailDataSet;
        FindProjectMatrixByCustomerAssignedIDForEmailDataSetTableAdapters.FindProjectMatrixByCustomerAssignedIDForEmailTableAdapter aFindProjectMatrixByCustomerAssignedIDForEmailTableAdapter;

        FindOpenOfficeBusinessLineProjectListDataSet aFindOpenOfficeBusinessLineProjectListDataSet;
        FindOpenOfficeBusinessLineProjectListDataSetTableAdapters.FindOpenOfficeBusinessLineProjectListTableAdapter aFindOpenOfficeBusinessLineProjectListTableAdapter;

        FindOverdueOfficeBusinessLineProjectListDataSet aFindOverdueOfficeBusinessLineProjectListDataSet;
        FindOverdueOfficeBusinessLineProjectListDataSetTableAdapters.FindOverdueOfficeBusinessLineProjectListTableAdapter aFindOverdueOfficeBusinessLineProjectListTableAdapter;

        FindProjectMatrixByCustomerAssignedIDShortDataSet aFindProjectMatrixByCustomerAssignedIDShortDataSet;
        FindProjectMatrixByCustomerAssignedIDShortDataSetTableAdapters.FindProjectMatrixByCustomerAssignedIDShortTableAdapter aFindProjectMatrixByCustomerAssignedIDShortTableAdapter;

        public FindProjectMatrixByCustomerAssignedIDShortDataSet FindProjectMatrixByCustomerAssignedIDShort(string strCustomerAssignedID)
        {
            try
            {
                aFindProjectMatrixByCustomerAssignedIDShortDataSet = new FindProjectMatrixByCustomerAssignedIDShortDataSet();
                aFindProjectMatrixByCustomerAssignedIDShortTableAdapter = new FindProjectMatrixByCustomerAssignedIDShortDataSetTableAdapters.FindProjectMatrixByCustomerAssignedIDShortTableAdapter();
                aFindProjectMatrixByCustomerAssignedIDShortTableAdapter.Fill(aFindProjectMatrixByCustomerAssignedIDShortDataSet.FindProjectMatrixByCustomerAssignedIDShort, strCustomerAssignedID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Customer Assigned ID Short " + Ex.Message);
            }

            return aFindProjectMatrixByCustomerAssignedIDShortDataSet;
        }
        public FindOverdueOfficeBusinessLineProjectListDataSet FindOverdueOfficeBusinessLineProjectList(int intWarehouseID, int intDepartmentID, DateTime datTransactionDate)
        {
            try
            {
                aFindOverdueOfficeBusinessLineProjectListDataSet = new FindOverdueOfficeBusinessLineProjectListDataSet();
                aFindOverdueOfficeBusinessLineProjectListTableAdapter = new FindOverdueOfficeBusinessLineProjectListDataSetTableAdapters.FindOverdueOfficeBusinessLineProjectListTableAdapter();
                aFindOverdueOfficeBusinessLineProjectListTableAdapter.Fill(aFindOverdueOfficeBusinessLineProjectListDataSet.FindOverdueOfficeBusinessLineProjectList, intWarehouseID, intDepartmentID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Overdue Office Business Line Project List " + Ex.Message);
            }

            return aFindOverdueOfficeBusinessLineProjectListDataSet;
        }
        public FindOpenOfficeBusinessLineProjectListDataSet FindOpenOfficeBusinessLineProjectList(int intWarehouseID, int intDepartmentID)
        {
            try
            {
                aFindOpenOfficeBusinessLineProjectListDataSet = new FindOpenOfficeBusinessLineProjectListDataSet();
                aFindOpenOfficeBusinessLineProjectListTableAdapter = new FindOpenOfficeBusinessLineProjectListDataSetTableAdapters.FindOpenOfficeBusinessLineProjectListTableAdapter();
                aFindOpenOfficeBusinessLineProjectListTableAdapter.Fill(aFindOpenOfficeBusinessLineProjectListDataSet.FindOpenOfficeBusinessLineProjectList, intWarehouseID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Open Office Business Line Project List " + Ex.Message);
            }

            return aFindOpenOfficeBusinessLineProjectListDataSet;
        }
        public FindProjectMatrixByCustomerAssignedIDForEmailDataSet FindProjectMatrixByCustomerAssignedIDForEmail(string strCustomerAssignedID)
        {
            try
            {
                aFindProjectMatrixByCustomerAssignedIDForEmailDataSet = new FindProjectMatrixByCustomerAssignedIDForEmailDataSet();
                aFindProjectMatrixByCustomerAssignedIDForEmailTableAdapter = new FindProjectMatrixByCustomerAssignedIDForEmailDataSetTableAdapters.FindProjectMatrixByCustomerAssignedIDForEmailTableAdapter();
                aFindProjectMatrixByCustomerAssignedIDForEmailTableAdapter.Fill(aFindProjectMatrixByCustomerAssignedIDForEmailDataSet.FindProjectMatrixByCustomerAssignedIDForEmail, strCustomerAssignedID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Customer Assigned ID For Email " + Ex.Message);
            }

            return aFindProjectMatrixByCustomerAssignedIDForEmailDataSet;
        }
        public bool UpdateProjectMatrixItems(int intTransactionID, int intWarehouseID, int intDepartmentID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectMatrixItemsTableAdapter = new UpdateProjectMatrixItemsEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectMatrixItemsTableAdapter.UpdateProjectMatrixItems(intTransactionID, intWarehouseID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Update Project Matrix Items " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProjectMatrixCustomerProjectID(int intTransactionID, string strCustomerProjectID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectMatrixCustomerProjectIDTableAdapter = new UpdateProjectMatrixCustomerProjectIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectMatrixCustomerProjectIDTableAdapter.UpdateProjectMatrixCustomerProjectID(intTransactionID, strCustomerProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Update Project Matrix Customer Project ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProjectLastDate(int intTransactionID, DateTime datLastDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectLastDateTableAdapter = new UpdateProjectLastDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectLastDateTableAdapter.UpdateProjectLastDate(intTransactionID, datLastDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Update Project Last Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProjectLastDate(DateTime datLastDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProjectLastDateTableAdapter = new InsertProjectLastDateEntryTableAdapters.QueriesTableAdapter();
                aInsertProjectLastDateTableAdapter.InsertProjectLastDate(datLastDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Insert Project Last Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProjectLastDateDataSet GetProjectLastDateInfo()
        {
            try
            {
                aProjectLastDateDataSet = new ProjectLastDateDataSet();
                aProjectLastDateTableAdapter = new ProjectLastDateDataSetTableAdapters.projectlastdateTableAdapter();
                aProjectLastDateTableAdapter.Fill(aProjectLastDateDataSet.projectlastdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Get Project Last Date Info " + Ex.Message);
            }

            return aProjectLastDateDataSet;
        }
        public void UpdateProjectLastDateDB(ProjectLastDateDataSet aProjectLastDateDataSet)
        {
            try
            {
                aProjectLastDateTableAdapter = new ProjectLastDateDataSetTableAdapters.projectlastdateTableAdapter();
                aProjectLastDateTableAdapter.Update(aProjectLastDateDataSet.projectlastdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Update Project Last Date DB " + Ex.Message);
            }
        }
        public FindProjectMatrixByGreaterDateDataSet FindProjectMatrixByGreaterDate(DateTime datStartDate)
        {
            try
            {
                aFindProjectMatrixByGreaterDateDataSet = new FindProjectMatrixByGreaterDateDataSet();
                aFindProjectMatrixByGreaterDateTableAdapter = new FindProjectMatrixByGreaterDateDataSetTableAdapters.FindProjectMatrixByGreaterDateTableAdapter();
                aFindProjectMatrixByGreaterDateTableAdapter.Fill(aFindProjectMatrixByGreaterDateDataSet.FindProjectMatrixByGreaterDate, datStartDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Greater Date " + Ex.Message);
            }

            return aFindProjectMatrixByGreaterDateDataSet;
        }
        public FindProjectMatrixByProjectIDDataSet FindProjectMatrixByProjectID(int intProjectID)
        {
            try
            {
                aFindProjectMatrixByProjectIDDataSet = new FindProjectMatrixByProjectIDDataSet();
                aFindProjectMatrixByProjectIDTableAdapter = new FindProjectMatrixByProjectIDDataSetTableAdapters.FindProjectMatrixByProjectIDTableAdapter();
                aFindProjectMatrixByProjectIDTableAdapter.Fill(aFindProjectMatrixByProjectIDDataSet.FindProjectMatrixByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Project ID" + Ex.Message);
            }

            return aFindProjectMatrixByProjectIDDataSet;
        }
        public FindDuplicateProjectMatrixDataSet FindDuplicateProjectMatrix()
        {
            try
            {
                aFindDuplicateProjectMatrixDataSet = new FindDuplicateProjectMatrixDataSet();
                aFindDuplicateProjectMatrixTableAdapter = new FindDuplicateProjectMatrixDataSetTableAdapters.FindDuplicateProjectMatrixTableAdapter();
                aFindDuplicateProjectMatrixTableAdapter.Fill(aFindDuplicateProjectMatrixDataSet.FindDuplicateProjectMatrix);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Duplicate Project Matrix " + Ex.Message);
            }

            return aFindDuplicateProjectMatrixDataSet;
        }
        public bool RemoveDuplicateProjectMatrixTransaction(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveDuplicateProjectMatrixTransactionTableAdapter = new RemoveDuplicateProjectMatrixTransactionEntryTableAdapters.QueriesTableAdapter();
                aRemoveDuplicateProjectMatrixTransactionTableAdapter.RemoveDuplicateProjectMatrixTransaction(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Remove Duplicate Project Matrix Transaction " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public  bool UpdateProjectMatrixAssignedProjectID(int intTransactionID, string strAssignedProjectID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectMatrixAssignedProjectIDTableAdapter = new UpdateProjectMatrixAssignedProjectIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectMatrixAssignedProjectIDTableAdapter.UpdateProjectMatrixAssignedProjectID(intTransactionID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix // Update Project Matrix Assigned Project ID " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindProjectMatrixByCustomerProjectIDDataSet FindProjectMatrixByCustomerProjectID(string strCustomerProjectID)
        {
            try
            {
                aFindProjectMatrixByCustomerProjectIDDataSet = new FindProjectMatrixByCustomerProjectIDDataSet();
                aFindProjectMatrixByCustomerProjectIDTableAdapter = new FindProjectMatrixByCustomerProjectIDDataSetTableAdapters.FindProjectMatrixByCustomerProjectIDTableAdapter();
                aFindProjectMatrixByCustomerProjectIDTableAdapter.Fill(aFindProjectMatrixByCustomerProjectIDDataSet.FindProjectMatrixByCustomerProjectID, strCustomerProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Customer ID " + Ex.Message);
            }

            return aFindProjectMatrixByCustomerProjectIDDataSet;
        }
        public FindProjectMatrixByAssignedProjectIDDataSet FindProjectMatrixByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindProjectMatrixByAssignedProjectIDDataSet = new FindProjectMatrixByAssignedProjectIDDataSet();
                aFindProjectMatrixByAssignedProjectIDTableAdapter = new FindProjectMatrixByAssignedProjectIDDataSetTableAdapters.FindProjectMatrixByAssignedProjectIDTableAdapter();
                aFindProjectMatrixByAssignedProjectIDTableAdapter.Fill(aFindProjectMatrixByAssignedProjectIDDataSet.FindProjectMatrixByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Find Project Matrix By Assigned Project ID " + Ex.Message);
            }

            return aFindProjectMatrixByAssignedProjectIDDataSet;
        }
        public bool InsertProjectMatrix(int intProjectID, string strAssignedProjectID, string strCustomerProjectID, DateTime datTransactionDate, int intEmployeeID, int intWarehouseID, int intDepartment)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProjectMatrixTableAdapter = new InsertProjectMatrixEntryTableAdapters.QueriesTableAdapter();
                aInsertProjectMatrixTableAdapter.InsertProjectMatrix(intProjectID, strAssignedProjectID, strCustomerProjectID, datTransactionDate, intEmployeeID, intWarehouseID, intDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Insert Project Matrix " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProjectMatrixDataSet GetProjectMatrixInfo()
        {
            try
            {
                aProjectMatrixDataSet = new ProjectMatrixDataSet();
                aProjectMatrixTableAdapter = new ProjectMatrixDataSetTableAdapters.projectmatrixTableAdapter();
                aProjectMatrixTableAdapter.Fill(aProjectMatrixDataSet.projectmatrix);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Get Project Matrix Info " + Ex.Message);
            }

            return aProjectMatrixDataSet;
        }
        public void UpdateProjectMatrixDB(ProjectMatrixDataSet aProjectMatrixDataSet)
        {
            try
            {
                aProjectMatrixTableAdapter = new ProjectMatrixDataSetTableAdapters.projectmatrixTableAdapter();
                aProjectMatrixTableAdapter.Update(aProjectMatrixDataSet.projectmatrix);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Matrix Class // Update Project Matrix DB " + Ex.Message);
            }
        }
    }
}

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
